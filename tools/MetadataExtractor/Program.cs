using System.Globalization;
using CsvHelper;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace MetadataExtractor;

class Program
{
    static async Task<int> Main(string[] args)
    {
        try
        {
            var options = ParseArguments(args);
            if (options == null)
            {
                PrintUsage();
                return 1;
            }

            Console.WriteLine("JDE Metadata Extractor");
            Console.WriteLine("======================");
            Console.WriteLine($"Connection: {MaskPassword(options.ConnectionString)}");
            Console.WriteLine($"Schema: {options.Schema}");
            Console.WriteLine($"Output: {options.OutputPath}");
            Console.WriteLine($"Vanilla Only: {options.VanillaOnly}");
            if (!string.IsNullOrEmpty(options.Prefix))
                Console.WriteLine($"Prefix Filter: {options.Prefix}");
            Console.WriteLine();

            // Ensure output directory exists
            Directory.CreateDirectory(options.OutputPath);

            await using var connection = new OracleConnection(options.ConnectionString);
            await connection.OpenAsync();
            Console.WriteLine("Connected to Oracle database.");

            // Extract metadata
            var tables = await ExtractTables(connection, options);
            Console.WriteLine($"Found {tables.Count} tables.");

            var columns = await ExtractColumns(connection, options, tables);
            Console.WriteLine($"Found {columns.Count} columns.");

            var indexes = await ExtractIndexes(connection, options, tables);
            Console.WriteLine($"Found {indexes.Count} index columns.");

            // Export to CSV
            var tablesFile = Path.Combine(options.OutputPath, "jde_tables.csv");
            var columnsFile = Path.Combine(options.OutputPath, "jde_columns.csv");
            var indexesFile = Path.Combine(options.OutputPath, "jde_indexes.csv");

            ExportToCsv(tablesFile, tables);
            Console.WriteLine($"Exported tables to {tablesFile}");

            ExportToCsv(columnsFile, columns);
            Console.WriteLine($"Exported columns to {columnsFile}");

            ExportToCsv(indexesFile, indexes);
            Console.WriteLine($"Exported indexes to {indexesFile}");

            Console.WriteLine();
            Console.WriteLine("Extraction completed successfully!");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            Console.Error.WriteLine(ex.StackTrace);
            return 1;
        }
    }

    static ExtractionOptions? ParseArguments(string[] args)
    {
        var options = new ExtractionOptions
        {
            OutputPath = Directory.GetCurrentDirectory(),
            VanillaOnly = true
        };

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--connection":
                    if (i + 1 < args.Length)
                        options.ConnectionString = args[++i];
                    break;
                case "--schema":
                    if (i + 1 < args.Length)
                        options.Schema = args[++i];
                    break;
                case "--output":
                    if (i + 1 < args.Length)
                        options.OutputPath = args[++i];
                    break;
                case "--vanilla-only":
                    if (i + 1 < args.Length)
                        options.VanillaOnly = bool.Parse(args[++i]);
                    break;
                case "--prefix":
                    if (i + 1 < args.Length)
                    {
                        options.Prefix = args[++i];
                        options.VanillaOnly = false; // Prefix overrides vanilla filter
                    }
                    break;
                case "--help":
                case "-h":
                    return null;
            }
        }

        if (string.IsNullOrEmpty(options.ConnectionString) || string.IsNullOrEmpty(options.Schema))
        {
            return null;
        }

        return options;
    }

    static void PrintUsage()
    {
        Console.WriteLine("Usage: MetadataExtractor [options]");
        Console.WriteLine();
        Console.WriteLine("Required Options:");
        Console.WriteLine("  --connection <string>    Oracle connection string");
        Console.WriteLine("  --schema <string>        JDE schema/owner name (e.g., PROD920, TESTDTA)");
        Console.WriteLine();
        Console.WriteLine("Optional:");
        Console.WriteLine("  --output <path>          Output directory for CSV files (default: current)");
        Console.WriteLine("  --vanilla-only <bool>    Extract only vanilla JDE tables (default: true)");
        Console.WriteLine("  --prefix <string>        Custom table prefix filter (overrides --vanilla-only)");
        Console.WriteLine("  --help, -h               Show this help message");
        Console.WriteLine();
        Console.WriteLine("Examples:");
        Console.WriteLine("  MetadataExtractor --connection \"User Id=JDE;Password=pass;Data Source=db\" --schema TESTDTA");
        Console.WriteLine("  MetadataExtractor --connection \"...\" --schema PROD920 --output ./metadata --vanilla-only true");
    }

    static async Task<List<TableMetadata>> ExtractTables(OracleConnection connection, ExtractionOptions options)
    {
        Console.WriteLine("Extracting table metadata...");

        var whereClause = BuildTableFilter(options);

        var sql = $@"
            SELECT
                t.TABLE_NAME as TableName,
                c.COMMENTS as Description,
                t.NUM_ROWS as RowCount
            FROM ALL_TABLES t
            LEFT JOIN ALL_TAB_COMMENTS c
                ON t.OWNER = c.OWNER AND t.TABLE_NAME = c.TABLE_NAME
            WHERE t.OWNER = :schema
              {whereClause}
            ORDER BY t.TABLE_NAME";

        var tables = await connection.QueryAsync<TableMetadata>(sql, new { schema = options.Schema });
        return tables.ToList();
    }

    static async Task<List<ColumnMetadata>> ExtractColumns(OracleConnection connection, ExtractionOptions options, List<TableMetadata> tables)
    {
        if (tables.Count == 0) return new List<ColumnMetadata>();

        var allColumns = new List<ColumnMetadata>();
        var tableNames = tables.Select(t => t.TableName).ToList();

        // Oracle has a limit of 1000 items in IN clause, so batch the requests
        const int batchSize = 900; // Use 900 to be safe
        var batches = (int)Math.Ceiling(tableNames.Count / (double)batchSize);

        var progress = new ProgressBar("Extracting columns", batches);

        for (int i = 0; i < batches; i++)
        {
            var batch = tableNames.Skip(i * batchSize).Take(batchSize).ToList();

            var sql = @"
                SELECT
                    c.TABLE_NAME as TableName,
                    c.COLUMN_NAME as ColumnName,
                    c.DATA_TYPE as DataType,
                    c.DATA_LENGTH as Length,
                    c.DATA_PRECISION as Precision,
                    c.DATA_SCALE as Scale,
                    c.NULLABLE as Nullable,
                    c.COLUMN_ID as ColumnId,
                    cc.COMMENTS as Description
                FROM ALL_TAB_COLUMNS c
                LEFT JOIN ALL_COL_COMMENTS cc
                    ON c.OWNER = cc.OWNER
                    AND c.TABLE_NAME = cc.TABLE_NAME
                    AND c.COLUMN_NAME = cc.COLUMN_NAME
                WHERE c.OWNER = :schema
                  AND c.TABLE_NAME IN :tableNames
                ORDER BY c.TABLE_NAME, c.COLUMN_ID";

            var columns = await connection.QueryAsync<ColumnMetadata>(sql, new { schema = options.Schema, tableNames = batch });
            allColumns.AddRange(columns);

            progress.Update(i + 1);
        }

        progress.Complete();
        return allColumns;
    }

    static async Task<List<IndexMetadata>> ExtractIndexes(OracleConnection connection, ExtractionOptions options, List<TableMetadata> tables)
    {
        if (tables.Count == 0) return new List<IndexMetadata>();

        var allIndexes = new List<IndexMetadata>();
        var tableNames = tables.Select(t => t.TableName).ToList();

        // Oracle has a limit of 1000 items in IN clause, so batch the requests
        const int batchSize = 900; // Use 900 to be safe
        var batches = (int)Math.Ceiling(tableNames.Count / (double)batchSize);

        var progress = new ProgressBar("Extracting indexes", batches);

        for (int i = 0; i < batches; i++)
        {
            var batch = tableNames.Skip(i * batchSize).Take(batchSize).ToList();

            var sql = @"
                SELECT
                    ic.TABLE_NAME as TableName,
                    i.INDEX_NAME as IndexName,
                    ic.COLUMN_NAME as ColumnName,
                    ic.COLUMN_POSITION as ColumnPosition,
                    i.UNIQUENESS as Uniqueness,
                    CASE
                        WHEN con.CONSTRAINT_TYPE = 'P' THEN 'Y'
                        ELSE 'N'
                    END as IsPrimaryKey
                FROM ALL_IND_COLUMNS ic
                INNER JOIN ALL_INDEXES i
                    ON ic.INDEX_OWNER = i.OWNER
                    AND ic.INDEX_NAME = i.INDEX_NAME
                LEFT JOIN ALL_CONSTRAINTS con
                    ON i.INDEX_NAME = con.INDEX_NAME
                    AND i.TABLE_OWNER = con.OWNER
                    AND con.CONSTRAINT_TYPE = 'P'
                WHERE ic.INDEX_OWNER = :schema
                  AND ic.TABLE_NAME IN :tableNames
                ORDER BY ic.TABLE_NAME, i.INDEX_NAME, ic.COLUMN_POSITION";

            var indexes = await connection.QueryAsync<IndexMetadata>(sql, new { schema = options.Schema, tableNames = batch });

            // Convert UNIQUE/NONUNIQUE to Y/N
            foreach (var idx in indexes)
            {
                idx.IsUnique = idx.Uniqueness?.Equals("UNIQUE", StringComparison.OrdinalIgnoreCase) == true ? "Y" : "N";
            }

            allIndexes.AddRange(indexes);

            progress.Update(i + 1);
        }

        progress.Complete();
        return allIndexes;
    }

    static string BuildTableFilter(ExtractionOptions options)
    {
        if (!string.IsNullOrEmpty(options.Prefix))
        {
            return $"AND t.TABLE_NAME LIKE '{options.Prefix}%'";
        }

        if (options.VanillaOnly)
        {
            // Vanilla tables: start with F, exclude F55xxx-F59xxx
            return @"AND t.TABLE_NAME LIKE 'F%'
              AND t.TABLE_NAME NOT LIKE 'F55%'
              AND t.TABLE_NAME NOT LIKE 'F56%'
              AND t.TABLE_NAME NOT LIKE 'F57%'
              AND t.TABLE_NAME NOT LIKE 'F58%'
              AND t.TABLE_NAME NOT LIKE 'F59%'";
        }

        return string.Empty;
    }

    static void ExportToCsv<T>(string filePath, List<T> records)
    {
        using var writer = new StreamWriter(filePath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(records);
    }

    static string MaskPassword(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
            return connectionString;

        var parts = connectionString.Split(';');
        for (int i = 0; i < parts.Length; i++)
        {
            if (parts[i].Trim().StartsWith("Password=", StringComparison.OrdinalIgnoreCase))
            {
                parts[i] = "Password=****";
            }
        }
        return string.Join(';', parts);
    }
}

class ProgressBar
{
    private readonly int _total;
    private readonly string _description;
    private int _current;
    private readonly int _barWidth = 40;

    public ProgressBar(string description, int total)
    {
        _description = description;
        _total = total;
        _current = 0;
    }

    public void Update(int current)
    {
        _current = current;
        Draw();
    }

    public void Increment()
    {
        _current++;
        Draw();
    }

    public void Complete()
    {
        _current = _total;
        Draw();
        Console.WriteLine(); // Move to next line when done
    }

    private void Draw()
    {
        var percentage = _total > 0 ? (double)_current / _total : 0;
        var filled = (int)(_barWidth * percentage);
        var bar = new string('█', filled) + new string('░', _barWidth - filled);

        Console.Write($"\r{_description}: [{bar}] {percentage:P0} ({_current}/{_total})");
    }
}

class ExtractionOptions
{
    public string ConnectionString { get; set; } = string.Empty;
    public string Schema { get; set; } = string.Empty;
    public string OutputPath { get; set; } = string.Empty;
    public bool VanillaOnly { get; set; }
    public string? Prefix { get; set; }
}

class TableMetadata
{
    public string TableName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public long? RowCount { get; set; }
}

class ColumnMetadata
{
    public string TableName { get; set; } = string.Empty;
    public string ColumnName { get; set; } = string.Empty;
    public string DataType { get; set; } = string.Empty;
    public int? Length { get; set; }
    public int? Precision { get; set; }
    public int? Scale { get; set; }
    public string Nullable { get; set; } = string.Empty;
    public int ColumnId { get; set; }
    public string? Description { get; set; }
}

class IndexMetadata
{
    public string TableName { get; set; } = string.Empty;
    public string IndexName { get; set; } = string.Empty;
    public string ColumnName { get; set; } = string.Empty;
    public int ColumnPosition { get; set; }
    public string? Uniqueness { get; set; }
    public string IsUnique { get; set; } = string.Empty;
    public string IsPrimaryKey { get; set; } = string.Empty;
}
