# JDE Database Interface Library - Project Summary

## 1. Objective

Develop a **C# Class Library** that provides a strongly-typed, configurable, and performant interface to query **JD Edwards (JDE)** database tables and views.  
The library will contain **predefined SQL queries** for all *vanilla* (standard, non-custom) JDE tables and join views.  
It aims to simplify JDE data access, enforce query consistency, and provide structured access to indexes and filters.

---

## 2. Key Goals

- Provide **out-of-the-box query access** to standard JDE tables and views.
- Eliminate need for manual SQL construction for common JDE data retrieval.
- Support both **single-row lookups** (index-based) and **multi-row queries** (filter-based).
- Provide **configurable database connection handling** and **schema mapping**.
- Allow **index configuration** (but not dynamic creation)—indexes are hard-coded based on vanilla JDE structure.
- Enable **cross-environment compatibility** (e.g., DEV, TEST, PROD) via configuration.

---

## 3. High-Level Architecture

### 3.1 Layered Design

| Layer | Responsibility |
|-------|----------------|
| **Core** | Query abstractions, JDE metadata definitions (tables, fields, indexes) |
| **Data Access** | SQL generation and Oracle execution layer |
| **Configuration** | Environment, connection string, schema handling |
| **Facade/API** | Public-facing API exposing high-level query interfaces |
| **Models** | Strongly-typed DTOs representing JDE tables and joined views |

### 3.2 Namespaces (Proposed)

- `JDE.Data` – Core data access and Oracle connection logic.  
- `JDE.Metadata` – Table and index metadata definitions.  
- `JDE.Queries` – Predefined query classes for tables and views.  
- `JDE.Models` – DTO classes representing JDE table rows.  
- `JDE.Config` – Configuration and environment handling.  
- `JDE.Abstractions` – Interfaces and base classes for extensibility.

---

## 4. Core Concepts

### 4.1 Table Definitions

Each vanilla JDE table will be represented by a **metadata class** defining:
- Table name
- Schema
- Column list
- Predefined indexes

```csharp
public class F0101Table : JdeTable
{
    public override string TableName => "F0101";
    public override IReadOnlyList<JdeIndex> Indexes => new[]
    {
        new JdeIndex("PK_F0101", new[] { "ABAN8" }),
        new JdeIndex("IDX_F0101_TYPE", new[] { "ABAT1", "ABALKY" })
    };
}
```

---

### 4.2 Query Modes

1. **Single-Row Query (IndexedQuery)**  
   - Uses a predefined index (e.g., primary key).  
   - Example: Get customer by `ABAN8`.

2. **Multi-Row Query (FilteredQuery)**  
   - Allows arbitrary field filters (e.g., where `ABAT1 = 'C'`).  
   - Can limit result count or paging.

3. **Joined View Query (JoinQuery)**  
   - Predefined joins for standard JDE views (e.g., Address Book + Category Codes).  
   - Views encapsulated as structured metadata.

---

### 4.3 Query Abstractions

```csharp
public abstract class JdeQuery<T>
{
    public abstract string BuildSql();
    public abstract IEnumerable<OracleParameter> GetParameters();
}

public class IndexedQuery<T> : JdeQuery<T> { /* Uses hard-coded index */ }
public class FilteredQuery<T> : JdeQuery<T> { /* Dynamic WHERE clause */ }
public class JoinQuery<T> : JdeQuery<T> { /* Predefined joins */ }
```

---

## 5. Index Handling

Indexes are **hard-coded per table**, not user-generated.  
The library will expose metadata to allow consumers to **select which index to use** when constructing indexed queries.

```csharp
var query = new IndexedQuery<F0101>(F0101.Indexes["PK_F0101"])
    .WithParameter("ABAN8", 12345);
```

---

## 6. Configuration Management

### 6.1 Environment-Aware Configuration

Use an external configuration provider (e.g., appsettings.json or injected options) to define:
- Oracle connection string
- Default schema (per environment)
- Logging behavior

```json
{
  "Environment": "DEV",
  "Schema": "JDEDEV",
  "ConnectionString": "User Id=user;Password=pwd;Data Source=devdb"
}
```

---

## 7. Database Connectivity

- **Provider:** Oracle Managed Data Access (ODP.NET)  
- **Connection management:** Connection pooling via `OracleConnection`.  
- **Execution:** Parameterized queries to prevent injection.  
- **Error handling:** Centralized exception wrapping via custom `JdeDataException`.

---

## 8. Extensibility Model

- New tables can be added by extending `JdeTable`.
- New queries can inherit from `JdeQuery<T>`.
- Additional databases (SQL Server, PostgreSQL) could later be supported by implementing an `ISqlDialect` interface.

---

## 9. Performance Considerations

- Index-based queries minimize full table scans.  
- Connection reuse and parameter binding for efficiency.  
- Optional caching layer (in-memory or Redis) for frequent lookups.  
- Batched read operations for large data retrieval.

---

## 10. Security

- All queries are parameterized.  
- Connection credentials stored securely (e.g., Azure Key Vault or Windows Credential Store).  
- Option for least-privilege database accounts.

---

## 11. Example Usage

```csharp
var jde = new JdeClient(config);
var customer = jde.Query<F0101>()
    .UsingIndex("PK_F0101")
    .Where("ABAN8", 1001)
    .FetchSingle();

var suppliers = jde.Query<F0101>()
    .Filter("ABAT1", "V")
    .FetchMany();
```

---

## 12. Deliverables

- `JDE.Core` – Base types and abstractions  
- `JDE.Metadata` – Hard-coded metadata definitions for vanilla tables/views  
- `JDE.Queries` – Predefined query classes  
- `JDE.Models` – DTOs for major JDE tables  
- `JDE.Tests` – Unit and integration tests  
- Example console or Blazor sample app demonstrating use

---

## 13. Future Enhancements

- Support for **JDE custom tables** via external metadata definitions (JSON/YAML).  
- ORM-style mapping (optional lightweight model binding).  
- Async query execution.  
- Schema introspection utilities.  
- GraphQL or REST interface generator for the library.

---

This architecture provides a clean separation of concerns, ensuring maintainability and extensibility while aligning with JDE’s rigid structure.  
Each part of the library is deterministic and predictable—ideal for enterprise environments where schema drift is minimal but reliability and performance are paramount.
