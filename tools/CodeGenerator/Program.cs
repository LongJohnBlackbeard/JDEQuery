using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace CodeGenerator;

class Program
{
    static int Main(string[] args)
    {
        try
        {
            var options = ParseArguments(args);
            if (options == null)
            {
                PrintUsage();
                return 1;
            }

            Console.WriteLine("JDE Code Generator");
            Console.WriteLine("==================");
            Console.WriteLine($"Input: {options.InputPath}");
            Console.WriteLine($"Metadata Output: {options.OutputPath}");
            Console.WriteLine($"Models Output: {options.ModelsOutputPath}");
            Console.WriteLine($"Skip Existing: {options.SkipExisting}");
            Console.WriteLine();

            // Read CSV files
            var tables = ReadTables(options.InputPath);
            var columns = ReadColumns(options.InputPath);
            var indexes = ReadIndexes(options.InputPath);

            Console.WriteLine($"Loaded {tables.Count} tables, {columns.Count} columns, {indexes.Count} index columns.");

            // Ensure output directories exist
            Directory.CreateDirectory(options.OutputPath);
            Directory.CreateDirectory(options.ModelsOutputPath);

            // Group data by table
            var tableData = PrepareTableData(tables, columns, indexes);

            // Generate metadata classes
            Console.WriteLine("\nGenerating metadata classes...");
            int metadataGenerated = 0;
            int metadataSkipped = 0;
            foreach (var table in tableData)
            {
                var fileName = $"{table.TableName}.cs";
                var filePath = Path.Combine(options.OutputPath, fileName);

                if (options.SkipExisting && File.Exists(filePath))
                {
                    metadataSkipped++;
                }
                else
                {
                    var code = GenerateTableClass(table);
                    File.WriteAllText(filePath, code, Encoding.UTF8);
                    metadataGenerated++;

                    if (metadataGenerated % 100 == 0)
                    {
                        Console.WriteLine($"  Generated {metadataGenerated}/{tableData.Count} metadata files...");
                    }
                }
            }

            // Generate model classes
            Console.WriteLine("\nGenerating model classes...");
            int modelsGenerated = 0;
            int modelsSkipped = 0;
            foreach (var table in tableData)
            {
                var fileName = $"{table.TableName}Model.cs";
                var filePath = Path.Combine(options.ModelsOutputPath, fileName);

                if (options.SkipExisting && File.Exists(filePath))
                {
                    modelsSkipped++;
                }
                else
                {
                    var code = GenerateModelClass(table);
                    File.WriteAllText(filePath, code, Encoding.UTF8);
                    modelsGenerated++;

                    if (modelsGenerated % 100 == 0)
                    {
                        Console.WriteLine($"  Generated {modelsGenerated}/{tableData.Count} model files...");
                    }
                }
            }

            Console.WriteLine($"\nGeneration completed!");
            Console.WriteLine($"  Metadata classes: {metadataGenerated} generated, {metadataSkipped} skipped (already exist)");
            Console.WriteLine($"  Model classes: {modelsGenerated} generated, {modelsSkipped} skipped (already exist)");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            Console.Error.WriteLine(ex.StackTrace);
            return 1;
        }
    }

    static GeneratorOptions? ParseArguments(string[] args)
    {
        var options = new GeneratorOptions();

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--input":
                    if (i + 1 < args.Length)
                        options.InputPath = args[++i];
                    break;
                case "--output":
                    if (i + 1 < args.Length)
                        options.OutputPath = args[++i];
                    break;
                case "--models-output":
                    if (i + 1 < args.Length)
                        options.ModelsOutputPath = args[++i];
                    break;
                case "--skip-existing":
                    options.SkipExisting = true;
                    break;
                case "--help":
                case "-h":
                    return null;
            }
        }

        if (string.IsNullOrEmpty(options.InputPath) || string.IsNullOrEmpty(options.OutputPath))
        {
            return null;
        }

        // Default models output to same as output if not specified
        if (string.IsNullOrEmpty(options.ModelsOutputPath))
        {
            options.ModelsOutputPath = options.OutputPath;
        }

        return options;
    }

    static void PrintUsage()
    {
        Console.WriteLine("Usage: CodeGenerator [options]");
        Console.WriteLine();
        Console.WriteLine("Required Options:");
        Console.WriteLine("  --input <path>          Directory containing CSV files from MetadataExtractor");
        Console.WriteLine("  --output <path>         Output directory for metadata class files");
        Console.WriteLine();
        Console.WriteLine("Optional:");
        Console.WriteLine("  --models-output <path>  Output directory for model class files (default: same as --output)");
        Console.WriteLine("  --skip-existing         Skip files that already exist (preserve hand-crafted files)");
        Console.WriteLine("  --help, -h              Show this help message");
        Console.WriteLine();
        Console.WriteLine("Examples:");
        Console.WriteLine("  CodeGenerator --input ./metadata_output --output ../JDE.Metadata/Tables --models-output ../JDE.Models");
        Console.WriteLine("  CodeGenerator --input ./metadata_output --output ../JDE.Metadata/Tables --skip-existing");
        Console.WriteLine("  CodeGenerator --input ./metadata_output --output ../JDE.Metadata/Tables");
    }

    static List<TableMetadata> ReadTables(string inputPath)
    {
        var filePath = Path.Combine(inputPath, "jde_tables.csv");
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<TableMetadata>().ToList();
    }

    static List<ColumnMetadata> ReadColumns(string inputPath)
    {
        var filePath = Path.Combine(inputPath, "jde_columns.csv");
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<ColumnMetadata>().ToList();
    }

    static List<IndexMetadata> ReadIndexes(string inputPath)
    {
        var filePath = Path.Combine(inputPath, "jde_indexes.csv");
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<IndexMetadata>().ToList();
    }

    static List<TableData> PrepareTableData(
        List<TableMetadata> tables,
        List<ColumnMetadata> allColumns,
        List<IndexMetadata> allIndexes)
    {
        var result = new List<TableData>();

        foreach (var table in tables)
        {
            var columns = allColumns
                .Where(c => c.TableName == table.TableName)
                .OrderBy(c => c.ColumnId)
                .ToList();

            var indexColumns = allIndexes
                .Where(i => i.TableName == table.TableName)
                .ToList();

            // Group indexes
            var indexes = indexColumns
                .GroupBy(i => i.IndexName)
                .Select(g => new IndexData
                {
                    IndexName = g.Key,
                    Columns = g.OrderBy(c => c.ColumnPosition).Select(c => c.ColumnName).ToList(),
                    IsUnique = g.First().IsUnique == "Y",
                    IsPrimaryKey = g.First().IsPrimaryKey == "Y"
                })
                .ToList();

            // Determine primary key columns
            var primaryKey = indexes.FirstOrDefault(i => i.IsPrimaryKey);
            var primaryKeyColumns = primaryKey?.Columns ?? new List<string>();

            result.Add(new TableData
            {
                TableName = table.TableName,
                Description = table.Description ?? table.TableName,
                Columns = columns,
                Indexes = indexes,
                PrimaryKeyColumns = primaryKeyColumns
            });
        }

        return result;
    }

    static string GenerateTableClass(TableData table)
    {
        var sb = new StringBuilder();

        // File header
        sb.AppendLine("using JDE.Abstractions.Metadata;");
        sb.AppendLine();
        sb.AppendLine("namespace JDE.Metadata.Tables;");
        sb.AppendLine();

        // Class documentation
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"/// {table.TableName} - {table.Description}.");
        sb.AppendLine("/// </summary>");
        sb.AppendLine($"public class {table.TableName} : JdeTable");
        sb.AppendLine("{");

        // Columns nested class for type-safe column references
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Column name constants for type-safe queries.");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    public static class Columns");
        sb.AppendLine("    {");

        // Generate column constants
        for (int i = 0; i < table.Columns.Count; i++)
        {
            var column = table.Columns[i];
            var constantName = SanitizePropertyName(column.ColumnName); // Sanitize for C# identifier
            var description = string.IsNullOrWhiteSpace(column.Description)
                ? column.ColumnName
                : column.Description;

            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// {EscapeString(description)}.");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine($"        public const string {constantName} = \"{column.ColumnName}\";");

            // Add blank line except after last constant
            if (i < table.Columns.Count - 1)
            {
                sb.AppendLine();
            }
        }

        sb.AppendLine("    }");
        sb.AppendLine();

        // TableName property
        sb.AppendLine("    /// <inheritdoc />");
        sb.AppendLine($"    public override string TableName => \"{table.TableName}\";");
        sb.AppendLine();

        // Description property
        sb.AppendLine("    /// <inheritdoc />");
        sb.AppendLine($"    public override string Description => \"{EscapeString(table.Description)}\";");
        sb.AppendLine();

        // Fields property
        sb.AppendLine("    /// <inheritdoc />");
        sb.AppendLine("    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>");
        sb.AppendLine("    {");

        // Generate fields
        for (int i = 0; i < table.Columns.Count; i++)
        {
            var column = table.Columns[i];
            var isPrimaryKey = table.PrimaryKeyColumns.Contains(column.ColumnName);
            var isRequired = column.Nullable == "N";

            var dataType = MapDataType(column.DataType);
            var maxLength = GetMaxLength(column);
            var description = string.IsNullOrWhiteSpace(column.Description)
                ? column.ColumnName
                : column.Description;

            var fieldLine = new StringBuilder();
            fieldLine.Append($"        new JdeField(\"{column.ColumnName}\", \"{EscapeString(description)}\", JdeDataType.{dataType}");

            if (maxLength.HasValue)
            {
                fieldLine.Append($", {maxLength.Value}");
            }
            else if (isRequired || isPrimaryKey)
            {
                fieldLine.Append(", null");
            }

            if (isRequired)
            {
                fieldLine.Append(", true");
            }
            else if (isPrimaryKey)
            {
                fieldLine.Append(", false");
            }

            if (isPrimaryKey)
            {
                fieldLine.Append(", true");
            }

            fieldLine.Append(")");

            if (i < table.Columns.Count - 1)
            {
                fieldLine.Append(",");
            }

            sb.AppendLine(fieldLine.ToString());
        }

        sb.AppendLine("    };");
        sb.AppendLine();

        // Indexes property
        sb.AppendLine("    /// <inheritdoc />");
        sb.AppendLine("    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>");
        sb.AppendLine("    {");

        for (int i = 0; i < table.Indexes.Count; i++)
        {
            var index = table.Indexes[i];
            var indexType = index.IsPrimaryKey ? "Primary Key" :
                           index.IsUnique ? "Unique Index" : "Index";
            var description = $"{indexType} on {string.Join(", ", index.Columns)}";

            var columnsArray = string.Join(", ", index.Columns.Select(c => $"\"{c}\""));

            sb.Append($"        new JdeIndex(");
            sb.Append($"\"{index.IndexName}\", ");
            sb.Append($"\"{description}\", ");
            sb.Append($"new[] {{ {columnsArray} }}");

            if (index.IsUnique || index.IsPrimaryKey)
            {
                if (index.IsUnique)
                {
                    sb.Append($", isUnique: true");
                }

                if (index.IsPrimaryKey)
                {
                    sb.Append($", isPrimaryKey: true");
                }
            }

            sb.Append(")");

            if (i < table.Indexes.Count - 1)
            {
                sb.AppendLine(",");
            }
            else
            {
                sb.AppendLine();
            }
        }

        sb.AppendLine("    };");
        sb.AppendLine("}");

        return sb.ToString();
    }

    static string MapDataType(string oracleType)
    {
        return oracleType.ToUpper() switch
        {
            "VARCHAR2" => "String",
            "CHAR" => "String",
            "NVARCHAR2" => "String",
            "NCHAR" => "String",
            "NUMBER" => "Numeric",
            "DATE" => "Date",
            "TIMESTAMP" => "Date",
            "FLOAT" => "Decimal",
            "BINARY_FLOAT" => "Decimal",
            "BINARY_DOUBLE" => "Decimal",
            _ => "String" // Default to String for unknown types
        };
    }

    static int? GetMaxLength(ColumnMetadata column)
    {
        // For string types, return the length
        if (column.DataType.Equals("VARCHAR2", StringComparison.OrdinalIgnoreCase) ||
            column.DataType.Equals("CHAR", StringComparison.OrdinalIgnoreCase) ||
            column.DataType.Equals("NVARCHAR2", StringComparison.OrdinalIgnoreCase) ||
            column.DataType.Equals("NCHAR", StringComparison.OrdinalIgnoreCase))
        {
            return column.Length;
        }

        return null;
    }

    static string EscapeString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return input.Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r");
    }

    /// <summary>
    /// Sanitizes a column name to be a valid C# identifier.
    /// Removes or replaces invalid characters like #, $, @, etc.
    /// </summary>
    static string SanitizePropertyName(string columnName)
    {
        if (string.IsNullOrEmpty(columnName))
            return columnName;

        // Replace common JDE special characters with underscores
        return columnName
            .Replace("#", "_")
            .Replace("$", "_")
            .Replace("@", "_")
            .Replace("-", "_")
            .Replace(" ", "_")
            .Replace(".", "_");
    }

    static string GenerateModelClass(TableData table)
    {
        var sb = new StringBuilder();

        // Check if any columns need sanitization (have special characters)
        bool needsUsingStatement = table.Columns.Any(c => c.ColumnName != SanitizePropertyName(c.ColumnName));

        // File header
        if (needsUsingStatement)
        {
            sb.AppendLine("using System.ComponentModel.DataAnnotations.Schema;");
            sb.AppendLine();
        }

        sb.AppendLine("namespace JDE.Models;");
        sb.AppendLine();

        // Class documentation
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"/// {table.TableName} - {table.Description}.");
        sb.AppendLine("/// </summary>");
        sb.AppendLine($"public class {table.TableName}Model");
        sb.AppendLine("{");

        // Generate properties
        for (int i = 0; i < table.Columns.Count; i++)
        {
            var column = table.Columns[i];
            var isPrimaryKey = table.PrimaryKeyColumns.Contains(column.ColumnName);
            var isNullable = column.Nullable == "Y";

            var csharpType = MapToCSharpType(column.DataType, isNullable && !isPrimaryKey);
            var propertyName = SanitizePropertyName(column.ColumnName);
            var needsColumnAttribute = column.ColumnName != propertyName;

            var description = string.IsNullOrWhiteSpace(column.Description)
                ? column.ColumnName
                : column.Description;

            // Property documentation
            sb.AppendLine("    /// <summary>");
            if (isPrimaryKey)
            {
                sb.AppendLine($"    /// {EscapeString(description)} (Primary Key).");
            }
            else
            {
                sb.AppendLine($"    /// {EscapeString(description)}.");
            }
            sb.AppendLine("    /// </summary>");

            // Add Column attribute if property name was sanitized
            if (needsColumnAttribute)
            {
                sb.AppendLine($"    [Column(\"{column.ColumnName}\")]");
            }

            // Property declaration
            sb.AppendLine($"    public {csharpType} {propertyName} {{ get; set; }}");

            // Add blank line between properties except after last one
            if (i < table.Columns.Count - 1)
            {
                sb.AppendLine();
            }
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    static string MapToCSharpType(string oracleType, bool isNullable)
    {
        var baseType = oracleType.ToUpper() switch
        {
            "VARCHAR2" => "string",
            "CHAR" => "string",
            "NVARCHAR2" => "string",
            "NCHAR" => "string",
            "NUMBER" => "decimal",
            "DATE" => "DateTime",
            "TIMESTAMP" => "DateTime",
            "FLOAT" => "decimal",
            "BINARY_FLOAT" => "float",
            "BINARY_DOUBLE" => "double",
            _ => "string" // Default to string for unknown types
        };

        // Strings are already nullable reference types
        if (baseType == "string")
        {
            return isNullable ? "string?" : "string";
        }

        // Value types need ? for nullable
        return isNullable ? $"{baseType}?" : baseType;
    }
}

class GeneratorOptions
{
    public string InputPath { get; set; } = string.Empty;
    public string OutputPath { get; set; } = string.Empty;
    public string ModelsOutputPath { get; set; } = string.Empty;
    public bool SkipExisting { get; set; } = false;
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
    public string IsUnique { get; set; } = string.Empty;
    public string IsPrimaryKey { get; set; } = string.Empty;
}

class TableData
{
    public string TableName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<ColumnMetadata> Columns { get; set; } = new();
    public List<IndexData> Indexes { get; set; } = new();
    public List<string> PrimaryKeyColumns { get; set; } = new();
}

class IndexData
{
    public string IndexName { get; set; } = string.Empty;
    public List<string> Columns { get; set; } = new();
    public bool IsUnique { get; set; }
    public bool IsPrimaryKey { get; set; }
}
