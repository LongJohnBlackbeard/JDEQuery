# JDE Query Library

A **database-agnostic .NET library** for querying JD Edwards (JDE) EnterpriseOne database tables with strongly-typed interfaces, predefined queries, and high performance.

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

## Features

- **4,937 JDE Tables Ready** - Complete metadata and models for all vanilla JDE tables (F* excluding F55-F59 custom tables)
- **Type-Safe Column Constants** - IntelliSense-enabled column references with compile-time validation (`F0101.Columns.ABAN8`)
- **Database Agnostic** - Provider pattern supports multiple databases (Oracle implemented, others planned)
- **Strongly Typed Models** - Auto-generated DTOs with proper nullable types and field mappings
- **High Performance** - Built on Dapper with optimized SQL generation and column selection
- **Pagination Support** - Built-in Skip/Take for efficient large dataset handling
- **Rich Query Operators** - Comparison operators (>, <, >=, <=, !=), LIKE patterns, trimmed equality
- **Fluent API** - Intuitive, chainable query builder interface
- **Configuration Driven** - Dependency injection ready with multiple configuration options
- **Metadata Tools** - Extract and generate JDE table metadata from any Oracle database

## Quick Start

### Installation

```bash
dotnet add package JDE.Client
dotnet add package JDE.Providers.Oracle  # For Oracle databases
```

### Basic Usage

```csharp
using JDE.Client;
using JDE.Metadata.Tables;
using JDE.Models;
using Microsoft.Extensions.DependencyInjection;

// Configure with dependency injection
services.AddJdeQuery(configuration, "JdeQuery");

// Get the client
var jdeClient = serviceProvider.GetRequiredService<JdeClient>();

// Query a single customer - with type-safe column constants
var customer = await jdeClient.Query<F0101Model>("F0101")
    .Where(F0101.Columns.ABAN8, 1001)
    .FetchSingleAsync();

Console.WriteLine($"Customer: {customer.ABAN8} - {customer.ABALPH?.Trim()}");

// Query multiple suppliers with column selection and type-safety
var suppliers = await jdeClient.Query<F0101Model>("F0101")
    .SelectFields(F0101.Columns.ABAN8, F0101.Columns.ABALPH, F0101.Columns.ABAT1)
    .Where(F0101.Columns.ABAT1, "V")  // V = Supplier
    .Take(100)
    .FetchManyAsync();

// Range query with comparison operators
var highValueCustomers = await jdeClient.Query<F0101Model>("F0101")
    .WhereGreaterThan(F0101.Columns.ABAN8, 100000)
    .Take(50)
    .FetchManyAsync();

// Field padding handling with LIKE and TRIM
var searchResults = await jdeClient.Query<F0101Model>("F0101")
    .SelectFields(F0101.Columns.ABAN8, F0101.Columns.ABALPH)
    .WhereLike(F0101.Columns.ABALPH, "ACME%")
    .FetchManyAsync();

// Pagination example
var page2 = await jdeClient.Query<F0101Model>("F0101")
    .Where(F0101.Columns.ABAT1, "C")  // C = Customer
    .Skip(100)
    .Take(50)
    .FetchManyAsync();
```

## Architecture

The library is organized into layered projects:

```
JDEQuery/
├── JDE.Abstractions          # Core interfaces (IDbProvider, ISqlDialect)
├── JDE.Core                  # Database-agnostic query engine
├── JDE.Providers.Abstractions # Shared provider base classes
├── JDE.Providers.Oracle      # Oracle-specific implementation
├── JDE.Metadata              # JDE table/index definitions
├── JDE.Models                # DTOs for JDE tables
├── JDE.Client                # Public API facade
└── JDE.Tests                 # Unit and integration tests
```

### Key Design Patterns

- **Provider Strategy Pattern** - Database-specific SQL generation via `ISqlDialect`
- **Repository Pattern** - Encapsulated data access through query abstractions
- **Fluent Builder** - Chainable query construction API
- **Options Pattern** - Configuration via Microsoft.Extensions.Options

## Configuration

### Dependency Injection

```csharp
services.AddJdeQuery(options =>
{
    options.ConnectionString = "User Id=user;Password=pwd;Data Source=jdeprod";
    options.Schema = "JDEPROD";
    options.Provider = "Oracle";
});
```

### appsettings.json

```json
{
  "JdeQuery": {
    "ConnectionString": "User Id=user;Password=pwd;Data Source=jdeprod",
    "Schema": "JDEPROD",
    "Provider": "Oracle"
  }
}
```

## Supported JDE Tables

**4,937 vanilla JDE tables** are included with complete metadata and models:

- All standard JDE tables (F* prefix)
- Excludes F55xxx-F59xxx (custom/OneWorld tables)
- Auto-generated from Oracle data dictionary
- Includes table descriptions, column definitions, indexes, and primary keys

**Common Tables Available:**
- **F0101** - Address Book Master
- **F0111** - Address Book - Who's Who
- **F4101** - Item Master
- **F4801** - Work Order Master File
- **F0005** - User Defined Codes
- **F9210** - Data Dictionary
- **And 4,931 more!**

See the complete list in `JDE.Metadata/Tables/` and `JDE.Models/`

## Metadata Tools

The library includes command-line tools for extracting and generating JDE metadata:

### MetadataExtractor

Extracts table metadata from Oracle data dictionary views and exports to CSV:

```bash
cd tools/MetadataExtractor
dotnet run -- \
  --connection "User Id=JDE;Password=***;Data Source=jdeprod" \
  --schema TESTDTA \
  --output ./metadata_output \
  --vanilla-only
```

**Features:**
- Extracts tables, columns, and indexes from Oracle
- Batched queries to handle Oracle's 1000-item IN clause limit
- Progress bars for real-time feedback
- Filters vanilla JDE tables (F* excluding F55xxx-F59xxx)
- Exports to CSV: `jde_tables.csv`, `jde_columns.csv`, `jde_indexes.csv`

### CodeGenerator

Generates C# metadata and model classes from extracted CSV files:

```bash
cd tools/CodeGenerator
dotnet run -- \
  --input ./metadata_output \
  --output ../../JDE.Metadata/Tables \
  --models-output ../../JDE.Models \
  --skip-existing
```

**Features:**
- Generates metadata classes with type-safe column constants
- Generates model classes (DTOs) with proper C# types
- Handles special characters in column names (#, $, @) with `[Column]` attributes
- `--skip-existing` flag preserves hand-crafted files
- Progress reporting every 100 files

See [tools/README.md](tools/README.md) for detailed documentation.

## Database Provider Support

| Provider    | Status      | Package                   |
|-------------|-------------|---------------------------|
| Oracle      | ✅ Supported | JDE.Providers.Oracle      |
| SQL Server  | 🚧 Planned  | JDE.Providers.SqlServer   |
| PostgreSQL  | 🚧 Planned  | JDE.Providers.PostgreSQL  |
| IBM Db2     | 🚧 Planned  | JDE.Providers.Db2         |

## Performance Considerations

- **Column Selection**: Only fetch needed columns (JDE tables often have 70-100+ columns)
- **Index Usage**: Use predefined indexes for optimal query performance
- **Pagination**: Leverage Skip/Take to limit result sets
- **Connection Pooling**: Built-in connection reuse via provider implementation
- **Parameterized Queries**: All queries use parameters to prevent SQL injection

## Contributing

Contributions are welcome! Please see [CONTRIBUTING.md](CONTRIBUTING.md) for details.

### Development Setup

```bash
git clone https://github.com/YOUR-USERNAME/JDEQuery.git
cd JDEQuery
dotnet restore
dotnet build
dotnet test
```

## Roadmap

**Completed ✅**
- [x] Core abstractions and Oracle provider
- [x] 4,937 vanilla JDE table metadata and models
- [x] Type-safe column constants for all tables
- [x] Fluent query API with comparison operators
- [x] Field padding handling (LIKE, TRIM)
- [x] Pagination support (Skip/Take)
- [x] Metadata extraction and code generation tools
- [x] Comprehensive unit tests (43 tests)
- [x] Sample application with 8 examples

**In Progress 🚧**
- [ ] JDE-specific features (UDC lookups, decimal handling, multi-schema)
- [ ] Additional database providers (SQL Server, PostgreSQL, DB2)

**Planned 📋**
- [ ] Optional configurable caching layer (Redis/in-memory)
- [ ] Async streaming for large datasets
- [ ] Custom table support via external metadata
- [ ] Advanced join support
- [ ] GraphQL or REST API generator

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Built with [Dapper](https://github.com/DapperLib/Dapper) for high-performance object mapping
- Inspired by the need for modern, type-safe JDE data access in .NET

## Support

- **Issues**: [GitHub Issues](https://github.com/YOUR-USERNAME/JDEQuery/issues)
- **Documentation**: See [JDE_Library_Project_Summary.md](JDE_Library_Project_Summary.md) for detailed architecture
- **Development Context**: See [CLAUDE.md](CLAUDE.md) for development session tracking

---

**Note**: This library is designed for JD Edwards EnterpriseOne (JDE) databases. It is not affiliated with or endorsed by Oracle Corporation.
