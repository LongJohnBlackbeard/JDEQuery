# JDE Metadata Extraction Tools

This folder contains tools to extract JDE table metadata and generate C# classes.

## Tools Overview

### 1. MetadataExtractor
Connects to Oracle JDE database and exports table metadata to CSV files.

**What it extracts:**
- All vanilla JDE tables (starts with 'F' but excludes F55xxx, F56xxx, F57xxx, F58xxx, F59xxx)
- Column definitions (name, type, length, nullability)
- Index definitions (name, columns, uniqueness)
- Primary key information

**Output:**
- `jde_tables.csv` - List of all JDE tables
- `jde_columns.csv` - All column definitions
- `jde_indexes.csv` - All index definitions

### 2. CodeGenerator *(Coming Soon)*
Reads CSV files and generates C# metadata classes for JDE.Metadata project.

## Usage

### Step 1: Extract Metadata from JDE Database

```bash
cd tools/MetadataExtractor
dotnet run -- --connection "User Id=JDE;Password=yourpass;Data Source=jdeprod" --schema "PROD920" --output "../../metadata_output"
```

**Parameters:**
- `--connection`: Oracle connection string
- `--schema`: JDE schema/owner name (e.g., PROD920, TESTDTA, CRPDTA)
- `--output`: Output directory for CSV files (default: current directory)
- `--vanilla-only`: Extract only vanilla JDE tables (default: true)
- `--prefix`: Custom table prefix filter (overrides --vanilla-only)

**Example:**
```bash
dotnet run -- --connection "User Id=JDE;Password=pass;Data Source=localhost:1521/XE" --schema "CRPDTA"
```

### Step 2: Generate C# Code *(Manual for now)*

The extracted CSV files can be used to:
1. Review JDE table structure
2. Manually create metadata classes (using F0101 as template)
3. Build automated code generation (future enhancement)

## Output File Format

### jde_tables.csv
```csv
TableName,Description,RowCount
F0101,Address Book Master,150000
F4801,Work Order Master File,50000
...
```

### jde_columns.csv
```csv
TableName,ColumnName,DataType,Length,Precision,Scale,Nullable,ColumnId
F0101,ABAN8,NUMBER,22,15,0,N,1
F0101,ABALPH,VARCHAR2,40,,,Y,2
...
```

### jde_indexes.csv
```csv
TableName,IndexName,ColumnName,ColumnPosition,IsUnique,IsPrimaryKey
F0101,F0101_PK,ABAN8,1,Y,Y
F0101,F0101_X1,ABAT1,1,N,N
F0101,F0101_X1,ABALKY,2,N,N
...
```

## Filtering Tables

### Vanilla JDE Tables (Default)
By default, the tool extracts only **vanilla JDE tables**:
- Tables starting with 'F'
- **EXCLUDING** F55xxx, F56xxx, F57xxx, F58xxx, F59xxx (custom/OneWorld tables)

Examples of vanilla tables: F0101, F0111, F4801, F0005, F4101, etc.

### Extract All Tables
To extract all tables (including custom):

```bash
dotnet run -- --connection "..." --schema "CRPDTA" --vanilla-only false
```

### Extract Custom Tables Only
To extract only custom tables (F55-F59 range):

```bash
dotnet run -- --connection "..." --schema "CRPDTA" --vanilla-only false --prefix "F5"
```

### Extract Specific Prefix
To extract tables with a specific prefix (e.g., Z-tables):

```bash
dotnet run -- --connection "..." --schema "CRPDTA" --prefix "Z"
```

## Vanilla Table Identification

**Vanilla JDE tables** are Oracle E1 standard tables that:
1. Start with 'F' (File)
2. Do NOT start with F55, F56, F57, F58, or F59 (reserved for custom/OneWorld)

This filtering ensures only Oracle's standard JDE EnterpriseOne tables are extracted.

## Oracle Dictionary Views Used

The tool queries Oracle system views:
- `ALL_TABLES` - Table metadata
- `ALL_TAB_COLUMNS` - Column definitions
- `ALL_INDEXES` - Index metadata
- `ALL_IND_COLUMNS` - Index column mappings
- `ALL_CONSTRAINTS` - Primary key identification

## Notes

- Extraction can take 5-30 minutes depending on JDE instance size
- Requires SELECT permission on Oracle data dictionary views
- Does not modify the JDE database (read-only queries)
- CSV files can be version-controlled to track JDE schema changes over time

## Future Enhancements

- [ ] CodeGenerator tool to auto-generate C# classes
- [ ] Support for table descriptions from JDE Data Dictionary (F9860)
- [ ] UDC (User Defined Code) extraction
- [ ] Progress reporting during extraction
- [ ] Incremental extraction (only changed tables)
- [ ] JSON output format option
