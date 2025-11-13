# JDE Query Library

A **database-agnostic .NET library** for querying JD Edwards (JDE) EnterpriseOne database tables with strongly-typed interfaces, predefined queries, and high performance.

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

## Features

- **Database Agnostic** - Provider pattern supports multiple databases (Oracle, SQL Server, PostgreSQL, DB2)
- **Strongly Typed** - Type-safe DTOs for JDE tables with IntelliSense support
- **High Performance** - Built on Dapper with optimized SQL generation
- **Column Selection** - Fetch only the columns you need for better performance
- **Pagination Support** - Built-in Skip/Take for efficient large dataset handling
- **Predefined Queries** - Hard-coded metadata for vanilla JDE tables and indexes
- **Fluent API** - Intuitive, chainable query builder interface
- **Configuration Driven** - Environment-aware connection and schema management

## Quick Start

### Installation

```bash
dotnet add package JDE.Client
dotnet add package JDE.Providers.Oracle  # For Oracle databases
```

### Basic Usage

```csharp
using JDE.Client;
using JDE.Models;

// Configure the JDE client
var jdeClient = new JdeClientBuilder()
    .UseOracle(connectionString)
    .UseSchema("JDEPROD")
    .Build();

// Query a single customer by address book number
var customer = await jdeClient.Query<F0101>()
    .UsingIndex("PK_F0101")
    .Where("ABAN8", 1001)
    .FetchSingleAsync();

// Query multiple suppliers with column selection
var suppliers = await jdeClient.Query<F0101>()
    .SelectFields("ABAN8", "ABALPH", "ABAT1")
    .Filter("ABAT1", "V")  // V = Supplier
    .Take(100)
    .FetchManyAsync();

// Pagination example
var page2 = await jdeClient.Query<F0101>()
    .Filter("ABAT1", "C")  // C = Customer
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

## Supported JDE Tables (Initial Release)

- **F0101** - Address Book Master
- **F0111** - Address Book - Who's Who
- **F4801** - Work Order Master File
- More tables coming soon!

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

- [ ] Core abstractions and Oracle provider
- [ ] F0101 (Address Book) implementation
- [ ] SQL Server provider
- [ ] PostgreSQL provider
- [ ] Custom table support via external metadata (JSON/YAML)
- [ ] Optional caching layer (Redis/in-memory)
- [ ] Async streaming for large datasets
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
