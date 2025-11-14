# JDE Query Library - Development Context

**Last Updated:** 2025-11-14
**Status:** Metadata Generation Complete - Documentation Updates Pending
**Default Branch:** main (renamed from master)
**Latest Session:** Completed metadata/model generation tools + type-safe column constants

---

## Project Overview

A **database-agnostic C# class library** for querying JD Edwards (JDE) database tables with strongly-typed interfaces, predefined queries, and configurable providers.

**Key Goals:**
- Out-of-the-box query access to standard JDE tables
- Database-agnostic core with provider pattern (start with Oracle, expand later)
- Column selection and pagination for performance
- Fluent API for easy consumption
- Hard-coded metadata for vanilla JDE tables

---

## Architecture Decisions

### ✅ Confirmed Decisions

| Decision | Rationale |
|----------|-----------|
| **Data Access:** Dapper | Lightweight micro-ORM, excellent performance, good SQL control |
| **Database Abstraction:** Provider Strategy Pattern | Clean separation, ISqlDialect per provider, easy to extend |
| **Initial Provider:** Oracle only | Most common JDE backend, architect for future DB support |
| **Column Selection:** Yes | JDE tables have 70-100+ columns, fetch only needed fields for performance |
| **Pagination:** Yes | Support Take/Skip for large result sets |
| **Target Framework:** .NET 8 | Modern, LTS, cross-platform |

### SQL Dialect Strategy
- Each database provider implements `ISqlDialect`
- Handles parameter syntax (`:p0` Oracle, `@p0` SQL Server)
- Manages pagination differences (ROWNUM vs OFFSET-FETCH vs LIMIT)
- Quote identifiers correctly (`"col"` vs `[col]`)

---

## Project Structure

### Solution Layout (8 Projects)

```
JDEQuery.sln
├── JDE.Abstractions         - Core interfaces (IDbProvider, ISqlDialect)
├── JDE.Core                 - Database-agnostic query logic
├── JDE.Providers.Abstractions - Shared provider base classes
├── JDE.Providers.Oracle     - Oracle implementation (Dapper + ODP.NET)
├── JDE.Metadata             - Hard-coded JDE table/index definitions
├── JDE.Models               - DTOs for JDE tables (F0101, F4801, etc.)
├── JDE.Client               - Public API facade with fluent interface
└── JDE.Tests                - Unit and integration tests
```

### Key Dependencies
- **Dapper** - Object mapping
- **Oracle.ManagedDataAccess.Core** - Oracle provider
- **Microsoft.Extensions.DependencyInjection** - DI support
- **Microsoft.Extensions.Configuration** - Configuration binding
- **Microsoft.Extensions.Options** - Options pattern

---

## Implementation Status

### ✅ Completed

- [x] Project planning and architecture design
- [x] CLAUDE.md context tracker created
- [x] Architecture decisions documented
- [x] **Solution structure created** - All 8 projects created and added to solution
- [x] **Project references configured** - Proper dependency hierarchy established
- [x] **NuGet packages installed**:
  - Dapper (2.1.66) in Providers.Abstractions and Providers.Oracle
  - Oracle.ManagedDataAccess.Core (23.26.0) in Providers.Oracle
  - Microsoft.Extensions.* (10.0.0) in Client
  - FluentAssertions (8.8.0) and Moq (4.20.72) in Tests
- [x] **Solution builds successfully** - 0 errors, 0 warnings
- [x] **Git repository initialized**:
  - Created .gitignore for .NET projects
  - Added MIT LICENSE
  - Created README.md with usage examples and project overview
  - Created CONTRIBUTING.md with development guidelines
  - Initial commit: `5cc5edf` - "chore: initial project setup"
- [x] **NuGet versioning strategy**:
  - Created VERSIONING.md documenting Semantic Versioning 2.0
  - Implemented Directory.Build.props for centralized version management
  - Set initial version to 0.1.0-alpha.1
  - Commit: `9d86292` - "chore: add NuGet versioning strategy"
- [x] **Core abstractions implemented** (JDE.Abstractions):
  - IDbProvider - database connection and execution interface
  - ISqlDialect - SQL generation interface
  - IJdeTable, IJdeField, IJdeIndex - metadata interfaces
  - IJdeQuery<T>, IQueryBuilder<T> - query interfaces
  - JdeOptions - configuration with validation
  - JdeException hierarchy - custom exception types
  - Commit: `1872c7b` - "feat: implement core abstractions"
- [x] **Query engine implemented** (JDE.Core):
  - JdeQuery<T> - base query implementation
  - QueryBuilder<T> - fluent API with SelectFields, Where, Skip, Take
  - QueryFactory - creates query builders
  - Full async/await support with cancellation tokens
  - Commit: `f08b881` - "feat: implement query builder with fluent API"
- [x] **Oracle provider implemented** (JDE.Providers.Oracle):
  - OracleSqlDialect - Oracle-specific SQL generation
  - OracleDbProvider - Dapper + Oracle.ManagedDataAccess integration
  - OFFSET-FETCH pagination (Oracle 12c+)
  - Parameterized queries with colon-prefix (:p0)
  - Connection testing and proper error handling
  - Commit: `795979f` - "feat: implement Oracle provider with SQL dialect"
- [x] **Metadata system implemented** (JDE.Metadata):
  - JdeField, JdeIndex, JdeTable base classes
  - F0101 Address Book Master metadata (50+ fields, 4 indexes)
  - F0101Model DTO for Dapper mapping
  - GetField(), GetIndex() lookup methods
  - Commit: `44a64bc` - "feat: implement metadata system and F0101 model"
- [x] **Metadata extraction tooling created** (tools/):
  - MetadataExtractor console app (C#, Oracle, Dapper, CsvHelper)
  - CodeGenerator placeholder for code generation
  - Comprehensive README.md with usage docs
  - Vanilla table filtering: F* excluding F55-F59
  - Projects marked as IsPackable=false to exclude from NuGet
  - Commit: `d145875`, `7655dc8` - "chore: add metadata extraction tooling"
- [x] **JdeClient API implemented** (JDE.Client):
  - Main JdeClient class with Query<T>() method
  - ServiceCollectionExtensions with 3 DI configuration methods:
    * AddJdeQuery(IConfiguration, sectionName)
    * AddJdeQuery(Action<JdeOptions>)
    * AddJdeQueryOracle(connectionString, schema, environment)
  - Automatic provider registration based on configuration
  - TestConnectionAsync() for connection validation
  - Disposable pattern for resource cleanup
  - Commit: `0beacaf` - "feat: add JdeClient API with query operators..."
- [x] **Query operator support**:
  - WhereGreaterThan, WhereLessThan for numeric comparisons
  - WhereGreaterThanOrEqual, WhereLessThanOrEqual for inclusive ranges
  - WhereNotEqual for inequality checks
  - WhereCondition class with WhereOperator enum for type safety
  - ISqlDialect overload accepting WhereCondition list
  - OracleSqlDialect support for all operators (=, <>, <, >, <=, >=)
  - Proper NULL handling with IS NULL and IS NOT NULL
- [x] **Field padding handling** (for JDE's max-length padded fields):
  - WhereLike for pattern matching with wildcards (e.g., "ABC%")
  - WhereTrimmedEqual for comparing fields without trailing spaces
  - Oracle TRIM() function integration
  - LIKE operator support with parameterized patterns
- [x] **Comprehensive unit tests** (42 tests, all passing):
  - OracleSqlDialectTests (24 tests) - SQL generation, operators, pagination
  - QueryBuilderTests (18 tests) - Fluent API, parameter generation, async execution
  - 100% coverage of all query operators and field padding methods
  - Mock-based testing with Moq and FluentAssertions
  - Commit: `1bea30f` - "test: add comprehensive unit tests..."
- [x] **F4101 Item Master metadata and model**:
  - Complete metadata with 43 fields and 5 indexes
  - F4101Model DTO with full field mapping
  - Product classifications, procurement codes, audit fields
- [x] **Sample application** (JDE.Samples.QueryExamples):
  - Console app with 7 comprehensive query examples
  - Demonstrates all query operators and field padding
  - Configuration for DV920/PY920/PROD environments
  - Dependency injection setup examples
  - Complete README with setup and troubleshooting
  - Ready to run against real JDE databases
- [x] **GitHub repository configuration**:
  - Issue templates (bug report, feature request, question)
  - Pull request template with comprehensive checklist
  - GitHub Actions workflows (CI/CD for build, test, and releases)
  - CODEOWNERS file (@LongJohnBlackbeard)
  - Dependabot configuration for NuGet and GitHub Actions
  - Repository labels (type, priority, status, component, area, JDE-specific)
  - Code of Conduct (Contributor Covenant v2.0)
  - Security policy with vulnerability reporting and best practices
  - Commit: `fc6e5ce` - "chore: add GitHub repository configuration"
- [x] **CI/CD fixes and improvements**:
  - Added label-sync workflow to automatically create repository labels
  - Fixed CI workflow permissions for Dependabot PRs
  - Updated all GitHub Actions to latest versions (v5)
  - Fixed security scan to only upload on push events
  - Fixed sample app typo: AddCommandLineArgs → AddCommandLine
  - Commits: `a4a30f9`, `fdec8b5`
- [x] **Branch rename from master to main**:
  - Updated all workflow files to reference 'main' branch
  - Updated issue template URLs from master to main
  - Renamed local and remote branches
  - Changed default branch on GitHub
  - Deleted old master branch
  - Commit: `173ef6e` - "refactor: update all branch references from master to main"
- [x] **Git configuration for GitHub account**:
  - Updated local git config to use GitHub username: LongJohnBlackbeard
  - Set email to noreply address to keep personal email private
  - All future commits properly attributed to GitHub account
- [x] **Sample application launch profiles**:
  - Added sample project to solution (JDE.Samples.QueryExamples)
  - Created launch profiles for Rider/VS (default, TESTDTA, DV920, PY920)
  - Enabled one-click run from IDE
  - Commit: `c129a11` - "feat: add launch profiles and protect connection strings"
- [x] **Connection string security**:
  - Added `appsettings.json` to .gitignore to prevent credential commits
  - Created `appsettings.example.json` template without credentials
  - Removed existing appsettings.json from git tracking
  - Local credentials preserved and functional
- [x] **Real database testing completed**:
  - Successfully tested against TESTDTA schema on Oracle database
  - All 7 sample examples executed successfully:
    * Example 1: Basic Query - Single record retrieval ✅
    * Example 2: Column Selection - Performance optimization ✅
    * Example 3: Comparison Operators - Range queries ✅
    * Example 4: Field Padding - LIKE and TRIM operations ✅
    * Example 5: Pagination - Skip/Take patterns ✅
    * Example 6: Item Master (F4101) queries ✅
    * Example 7: Multiple WHERE conditions ✅
  - Validated against real JDE data (F0101 Address Book, F4101 Item Master)
- [x] **WhereTrimmedEqual UX improvement**:
  - Now automatically trims user input to handle padded values
  - Users can pass values with or without trailing spaces - both work
  - Handles cases where users copy values directly from database
  - Added test: WhereTrimmedEqual_ShouldAutomaticallyTrimUserInput
  - Scrubbed personal data from sample queries
  - All 43 unit tests passing
  - Commit: `ef4f7fa` - "feat: auto-trim user input in WhereTrimmedEqual for better UX"
- [x] **MetadataExtractor tool implemented and tested**:
  - Command-line tool to extract JDE table metadata from Oracle
  - Connects to Oracle database and queries data dictionary views
  - Extracts vanilla JDE tables (F* excluding F55xxx-F59xxx custom tables)
  - Batched queries to handle Oracle's 1000-item IN clause limit
  - Progress bars for real-time extraction feedback
  - Exports to 3 CSV files: jde_tables.csv, jde_columns.csv, jde_indexes.csv
  - Successfully tested against TESTDTA schema
  - **Extracted 4,937 tables, 150,838 columns, 35,726 index columns**
  - Command-line arguments: --connection, --schema, --output, --vanilla-only, --prefix
  - Password masking in console output for security
  - Uses CsvHelper, Dapper, and Oracle.ManagedDataAccess.Core
- [x] **CodeGenerator tool implemented and tested**:
  - Reads CSV files from MetadataExtractor output
  - Generates C# metadata classes AND model classes for all JDE tables
  - Maps Oracle data types to JdeDataType (VARCHAR2→String, NUMBER→Numeric, DATE→Date)
  - Maps Oracle types to C# types for models (NUMBER→decimal, VARCHAR2→string, DATE→DateTime)
  - Identifies primary keys and required (NOT NULL) fields
  - Generates index definitions with proper unique/PK flags
  - Creates properly formatted C# files with XML documentation
  - Progress reporting every 100 files
  - **Successfully generated 4,937 metadata classes + 4,937 model classes**
  - Generated classes tested with QueryExamples - working correctly
  - Command-line arguments: --input, --output, --models-output, --skip-existing
  - Uses CsvHelper for CSV parsing and StringBuilder for code generation
  - Special character handling: Sanitizes column names with #, $, @, etc. using [Column] attributes
  - --skip-existing flag preserves hand-crafted files during regeneration
- [x] **Type-safe column constants** (CodeGenerator enhancement):
  - Added nested `Columns` class to all metadata classes
  - Provides IntelliSense support and compile-time validation
  - Example: `F0101.Columns.ABAN8` instead of `"ABAN8"`
  - Backward compatible - string-based column names still work
  - Prevents typos and improves developer experience
  - **4,937 metadata classes now include type-safe column constants**
- [x] **Column name sanitization fix** (CodeGenerator):
  - Fixed compilation errors from special characters (#, $, @) in column names
  - Sanitizes both property names in models AND constant names in Columns class
  - Example: `R#HST` → constant name `R_HST` with value `"R#HST"`
  - Preserves original database column names for correct mapping
  - Regenerated all 4,937 metadata and model classes successfully
- [x] **Sample application updated with type-safe columns**:
  - Updated Examples 2-7 to use type-safe column constants
  - Added explanatory log messages about type-safety to each example
  - Demonstrates F0101.Columns and F4101.Columns usage throughout
  - All examples now follow best practices with compile-time validated column names
- [x] **README.md comprehensive update**:
  - Updated Features section highlighting 4,937 tables and type-safe columns
  - Replaced draft API with actual implementation in Basic Usage
  - Added complete Metadata Tools section with MetadataExtractor and CodeGenerator
  - Updated Supported JDE Tables section with comprehensive list
  - Reorganized Roadmap into Completed/In Progress/Planned with checkmarks
  - All code examples now demonstrate type-safe column constants

### 🔄 In Progress

None currently - planning JDE-specific features (UDC, decimals, multi-schema)

### 📋 Pending (Priority Order)

**Remaining Documentation:**
1. **Update tools/README.md** - Add comprehensive documentation for:
   - MetadataExtractor usage, options, and examples
   - CodeGenerator usage, options, and examples
   - Workflow: Extract → Generate → Use
2. **Update CONTRIBUTING.md** - Add section on regenerating metadata classes
3. **Update API Design Examples in CLAUDE.md** - Convert to type-safe column syntax

**Session Cleanup:**
4. **Commit all changes** - CodeGenerator fixes, sample updates, README.md updates, CLAUDE.md updates
5. **Push to GitHub** - Share all recent work

**JDE-Specific Features (Designed, Not Implemented):**
3. **Multi-schema/database configuration** - Support F9210, F0005 in different schemas/databases
4. **Data Dictionary Service (F9210)** - Field alias lookups, UDC codes, decimal metadata
5. **UDC Service (F0005)** - User Defined Code lookups with full field support
6. **Decimal Conversion Service** - Apply/remove decimals based on F9210.FRCDEC
7. **Query Builder enhancements** - WithDecimals(), WithUdcDescriptions() methods
8. **Configurable caching** - Optional caching for F9210/F0005 (user opt-in)

**Infrastructure:**
9. **Merge Dependabot PRs** - Now that labels are synced and CI is fixed
10. **Enable GitHub repository features** - Issues, Discussions, Projects, Wiki
11. Write integration tests with Oracle database (requires DB access)
12. Create comprehensive documentation (README updates, wiki)
13. Create first release (v0.1.0-alpha.1) to test release workflow
14. Publish NuGet packages to nuget.org

---

## API Design Examples

### Dependency Injection Setup
```csharp
// Method 1: From IConfiguration (appsettings.json)
services.AddJdeQuery(configuration, "JdeQuery");

// Method 2: With Action<JdeOptions>
services.AddJdeQuery(options =>
{
    options.ConnectionString = "User Id=JDE;Password=pass;Data Source=prod";
    options.Schema = "PROD920";
    options.Provider = "Oracle";
});

// Method 3: Oracle-specific shorthand
services.AddJdeQueryOracle(
    connectionString: "User Id=JDE;Password=pass;Data Source=prod",
    schema: "PROD920",
    environment: "Production");
```

### Basic Query (Full Columns)
```csharp
var customer = await jdeClient.Query<F0101Model>("F0101")
    .Where("ABAN8", 1001)
    .FetchSingleAsync();
```

### Column Selection
```csharp
var result = await jdeClient.Query<F0101Model>("F0101")
    .SelectFields("ABAN8", "ABALPH", "ABAT1")
    .Where("ABAT1", "C")
    .FetchManyAsync();
```

### Comparison Operators
```csharp
// Greater than
var highValueCustomers = await jdeClient.Query<F0101Model>("F0101")
    .WhereGreaterThan("ABAN8", 100000)
    .FetchManyAsync();

// Range queries
var recentOrders = await jdeClient.Query<F4801Model>("F4801")
    .WhereGreaterThanOrEqual("WDDGJ", 123001)  // Julian date >= Jan 1, 2023
    .WhereLessThanOrEqual("WDDGJ", 123365)     // Julian date <= Dec 31, 2023
    .FetchManyAsync();

// Not equal
var nonCustomers = await jdeClient.Query<F0101Model>("F0101")
    .WhereNotEqual("ABAT1", "C")
    .FetchManyAsync();
```

### Field Padding Handling
```csharp
// JDE fields are padded - use WhereTrimmedEqual for exact match
var customer = await jdeClient.Query<F0101Model>("F0101")
    .WhereTrimmedEqual("ABALPH", "ACME CORP")  // Matches "ACME CORP          "
    .FetchSingleAsync();

// Pattern matching with LIKE
var results = await jdeClient.Query<F0101Model>("F0101")
    .WhereLike("ABALPH", "ACME%")  // Starts with ACME
    .FetchManyAsync();
```

### Pagination
```csharp
var page1 = await jdeClient.Query<F0101Model>("F0101")
    .Where("ABAT1", "C")
    .Take(100)
    .FetchManyAsync();

var page2 = await jdeClient.Query<F0101Model>("F0101")
    .Where("ABAT1", "C")
    .Skip(100).Take(100)
    .FetchManyAsync();
```

---

## Core Interfaces (Draft)

### IDbProvider
```csharp
public interface IDbProvider
{
    Task<T?> QuerySingleAsync<T>(string sql, object? param = null);
    Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null);
    string ProviderName { get; }
}
```

### ISqlDialect
```csharp
public interface ISqlDialect
{
    string BuildSelectSql(IEnumerable<string>? columns, string table, string? where);
    string ApplyPagination(string sql, int? skip, int? take);
    string GetParameterPrefix();
    string QuoteIdentifier(string identifier);
}
```

---

## Next Session Priorities

1. **Create project structure** - All 8 .csproj files, solution references
2. **Implement abstractions** - Core interfaces in JDE.Abstractions
3. **Start Oracle dialect** - Basic SQL generation for Oracle

---

## Open Questions / Blockers

None currently.

---

## Future Enhancements (Post-MVP)

- SQL Server provider
- PostgreSQL provider
- IBM Db2 provider
- Custom table support via external metadata (JSON/YAML)
- Async query execution patterns
- Optional caching layer (Redis/in-memory)
- GraphQL or REST API generator

---

## Database Provider Roadmap

| Provider | Status | Priority |
|----------|--------|----------|
| Oracle | ✅ Complete & Tested | P0 (MVP) |
| SQL Server | ⚪ Future | P1 |
| PostgreSQL | ⚪ Future | P2 |
| IBM Db2 | ⚪ Future | P3 |

---

## Testing and Validation

### Unit Tests (43 tests - all passing)

**Run tests:** `dotnet test JDE.Tests/JDE.Tests.csproj`

**OracleSqlDialectTests (24 tests):**
- SQL generation for all operators (=, <>, <, >, <=, >=, LIKE, TRIM)
- Parameter formatting (`:p0`, `:p1`, etc.)
- Identifier quoting (`"COLUMN"`)
- SELECT statement generation (columns, schema, WHERE)
- Pagination (OFFSET/FETCH)
- NULL handling (IS NULL, IS NOT NULL)
- Multiple WHERE conditions with AND

**QueryBuilderTests (19 tests):**
- Field selection validation
- All operator methods (WhereGreaterThan, WhereLessThan, etc.)
- Field padding methods (WhereLike, WhereTrimmedEqual)
- Auto-trimming of user input in WhereTrimmedEqual
- Pagination (Skip/Take) with validation
- Parameter generation from WhereCondition objects
- Async execution (FetchSingleAsync, FetchManyAsync)
- Mock-based testing with IDbProvider

### Sample Application ✅ TESTED

**Location:** `samples/JDE.Samples.QueryExamples/`

**Run sample:**
```bash
# From Rider/Visual Studio: Select launch profile and click Run
# Or from command line:
cd samples/JDE.Samples.QueryExamples
# Copy appsettings.example.json to appsettings.json and configure your connection
dotnet run
```

**7 Example Queries (All Tested Successfully):**
1. Basic Query - Single record retrieval ✅
2. Column Selection - Performance optimization ✅
3. Comparison Operators - Range queries ✅
4. Field Padding Handling - LIKE and TRIM ✅
5. Pagination - Skip/Take patterns ✅
6. Item Master Queries - F4101 examples ✅
7. Multiple Conditions - Complex WHERE clauses ✅

**Launch Profiles Available:**
- JDE.Samples.QueryExamples (default - uses appsettings.json)
- JDE Samples - TESTDTA
- JDE Samples - DV920
- JDE Samples - PY920

**Environments Configured:**
- TESTDTA (Test data) ✅ Tested
- DV920 (Development on non-prod)
- PY920 (Test on non-prod)
- PROD920 (Production)

## Notes

- JDE tables often have 70-100+ columns, column selection is critical for performance
- Oracle pagination: Use OFFSET-FETCH (12c+) or ROWNUM fallback for older versions
- All queries must be parameterized for security
- Connection string configuration per environment (DEV, TEST, PROD)
- F0101 (Address Book) serves as the reference table implementation
- **JDE Field Padding:** JDE pads all character fields to max length with spaces
  - Use `WhereTrimmedEqual()` for exact matches - automatically trims BOTH database field AND user input
  - Users can pass values with or without padding - library handles both cases
  - Use `WhereLike()` for pattern matching with wildcards
  - Regular `Where()` requires exact match including padding
- **Vanilla Tables:** Tables starting with 'F' EXCLUDING F55xxx-F59xxx (custom/OneWorld)
- **Tools Projects:** MetadataExtractor and CodeGenerator are marked `IsPackable=false` and excluded from NuGet packages
- **Test Coverage:** 43 unit tests covering all operators, pagination, field padding, and auto-trimming
- **Connection String Security:** appsettings.json is in .gitignore - use appsettings.example.json as template

---

**Repository:** https://github.com/LongJohnBlackbeard/JDEQuery
**Local Path:** C:\Users\dtujo\RiderProjects\JDEQuery
**Documentation:** See JDE_Library_Project_Summary.md for detailed design specs
