# JDE Query Library - Development Context

**Last Updated:** 2025-11-13
**Status:** MVP Complete - Tests Passing, Sample App Ready, GitHub Configured
**Latest Commit:** fc6e5ce - chore: add GitHub repository configuration

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

### 🔄 In Progress

None currently - MVP is complete!

### 📋 Pending (Priority Order)

1. **Enable GitHub repository features** - Issues, Discussions, Projects, Wiki
2. **Sync repository labels** - Apply labels.yml to GitHub (via label-syncer action or manual)
3. Implement MetadataExtractor Program.cs logic
4. Implement CodeGenerator to generate C# classes from CSV
5. Write integration tests with Oracle database (requires DB access)
6. Add more JDE table metadata (F0111, F0006, F4801, etc.)
7. Create comprehensive documentation (README updates, wiki)
8. Create first release (v0.1.0-alpha.1) to test release workflow
9. Publish NuGet packages to nuget.org

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
| Oracle | 🟡 Planned | P0 (MVP) |
| SQL Server | ⚪ Future | P1 |
| PostgreSQL | ⚪ Future | P2 |
| IBM Db2 | ⚪ Future | P3 |

---

## Testing and Validation

### Unit Tests (42 tests - all passing)

**Run tests:** `dotnet test JDE.Tests/JDE.Tests.csproj`

**OracleSqlDialectTests (24 tests):**
- SQL generation for all operators (=, <>, <, >, <=, >=, LIKE, TRIM)
- Parameter formatting (`:p0`, `:p1`, etc.)
- Identifier quoting (`"COLUMN"`)
- SELECT statement generation (columns, schema, WHERE)
- Pagination (OFFSET/FETCH)
- NULL handling (IS NULL, IS NOT NULL)
- Multiple WHERE conditions with AND

**QueryBuilderTests (18 tests):**
- Field selection validation
- All operator methods (WhereGreaterThan, WhereLessThan, etc.)
- Field padding methods (WhereLike, WhereTrimmedEqual)
- Pagination (Skip/Take) with validation
- Parameter generation from WhereCondition objects
- Async execution (FetchSingleAsync, FetchManyAsync)
- Mock-based testing with IDbProvider

### Sample Application

**Location:** `samples/JDE.Samples.QueryExamples/`

**Run sample:**
```bash
cd samples/JDE.Samples.QueryExamples
# Update appsettings.json with your connection string
dotnet run
```

**7 Example Queries:**
1. Basic Query - Single record retrieval
2. Column Selection - Performance optimization
3. Comparison Operators - Range queries
4. Field Padding Handling - LIKE and TRIM
5. Pagination - Skip/Take patterns
6. Item Master Queries - F4101 examples
7. Multiple Conditions - Complex WHERE clauses

**Environments Configured:**
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
  - Use `WhereTrimmedEqual()` for exact matches without padding
  - Use `WhereLike()` for pattern matching
  - Regular `Where()` requires exact match including padding
- **Vanilla Tables:** Tables starting with 'F' EXCLUDING F55xxx-F59xxx (custom/OneWorld)
- **Tools Projects:** MetadataExtractor and CodeGenerator are marked `IsPackable=false` and excluded from NuGet packages
- **Test Coverage:** 42 unit tests covering all operators, pagination, and field padding

---

**Repository:** https://github.com/LongJohnBlackbeard/JDEQuery
**Local Path:** C:\Users\dtujo\RiderProjects\JDEQuery
**Documentation:** See JDE_Library_Project_Summary.md for detailed design specs
