# JDE Query Library - Development Context

**Last Updated:** 2025-11-13
**Status:** Oracle Provider Complete - Building Metadata System
**Latest Commit:** 795979f - feat: implement Oracle provider with SQL dialect

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

### 🔄 In Progress

- [ ] Building metadata system for JDE tables

### 📋 Pending (Priority Order)

1. Complete core abstractions implementation
3. Build query builder with fluent API (SelectFields, Take, Skip, Where)
4. Implement Oracle SQL dialect
5. Create Oracle provider with Dapper integration
6. Build metadata system (start with F0101)
7. Implement JdeClient API with DI
8. Add configuration support
9. Create F0101 DTO model
10. Write tests

---

## API Design Examples

### Basic Query (Full Columns)
```csharp
var customer = await jdeClient.Query<F0101>()
    .UsingIndex("PK_F0101")
    .Where("ABAN8", 1001)
    .FetchSingleAsync();
```

### Column Selection
```csharp
var result = await jdeClient.Query<F0101>()
    .SelectFields("ABAN8", "ABALPH", "ABAT1")
    .Where("ABAT1", "C")
    .FetchManyAsync();
```

### Pagination
```csharp
var page1 = await jdeClient.Query<F0101>()
    .Filter("ABAT1", "C")
    .Take(100)
    .FetchManyAsync();

var page2 = await jdeClient.Query<F0101>()
    .Filter("ABAT1", "C")
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

## Notes

- JDE tables often have 70-100+ columns, column selection is critical for performance
- Oracle pagination: Use OFFSET-FETCH (12c+) or ROWNUM fallback for older versions
- All queries must be parameterized for security
- Connection string configuration per environment (DEV, TEST, PROD)
- Start with F0101 (Address Book) as the reference table implementation

---

**Repository:** C:\Users\dtujo\RiderProjects\JDEQuery
**Documentation:** See JDE_Library_Project_Summary.md for detailed design specs
