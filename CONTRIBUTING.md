# Contributing to JDE Query Library

Thank you for your interest in contributing to the JDE Query Library! This document provides guidelines and instructions for contributing.

## Code of Conduct

- Be respectful and inclusive
- Welcome newcomers and help them learn
- Focus on constructive feedback
- Maintain professionalism in all interactions

## How to Contribute

### Reporting Issues

- Use the GitHub issue tracker
- Check if the issue already exists before creating a new one
- Provide clear, detailed descriptions
- Include steps to reproduce bugs
- Specify your environment (.NET version, database provider, OS)

### Suggesting Features

- Open an issue with the "enhancement" label
- Describe the use case and benefits
- Consider implementation complexity
- Be open to discussion and alternatives

### Pull Requests

1. **Fork the repository** and create your branch from `main`
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make your changes**
   - Follow the coding standards below
   - Add or update tests as needed
   - Update documentation if applicable

3. **Test your changes**
   ```bash
   dotnet build
   dotnet test
   ```

4. **Commit with clear messages**
   - Use conventional commit format: `type: description`
   - Types: `feat`, `fix`, `docs`, `test`, `refactor`, `chore`
   - Example: `feat: add SQL Server provider support`

5. **Push and create a pull request**
   - Provide a clear description of changes
   - Reference related issues
   - Ensure CI checks pass

## Development Setup

### Prerequisites

- .NET 8.0 SDK or later
- Git
- An IDE: Visual Studio, Rider, or VS Code
- Access to a JDE database (for integration testing)

### Getting Started

```bash
# Clone your fork
git clone https://github.com/YOUR-USERNAME/JDEQuery.git
cd JDEQuery

# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run tests
dotnet test
```

## Coding Standards

### C# Style Guide

- Follow [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use meaningful variable and method names
- Add XML documentation comments for public APIs
- Keep methods focused and concise (single responsibility)
- Prefer `async`/`await` for I/O operations

### Naming Conventions

- **Interfaces**: `IDbProvider`, `ISqlDialect`
- **Classes**: `OracleDbProvider`, `SqlDialect`
- **Methods**: PascalCase - `BuildSelectSql()`
- **Private fields**: `_camelCase` with underscore
- **Parameters**: camelCase

### Code Organization

- One class per file
- Group related functionality in folders
- Keep namespaces aligned with folder structure
- Avoid circular dependencies

## Project Structure

```
JDE.Abstractions/          # Core interfaces and base classes
JDE.Core/                  # Database-agnostic query logic
JDE.Providers.Abstractions/ # Shared provider utilities
JDE.Providers.Oracle/      # Oracle-specific implementation
JDE.Metadata/              # JDE table and index definitions
JDE.Models/                # DTOs for JDE tables
JDE.Client/                # Public API facade
JDE.Tests/                 # Unit and integration tests
```

## Testing

### Writing Tests

- Use xUnit for all tests
- Follow AAA pattern: Arrange, Act, Assert
- Use FluentAssertions for readable assertions
- Use Moq for mocking dependencies

### Test Categories

```csharp
// Unit tests
[Fact]
public void BuildSelectSql_WithColumns_GeneratesCorrectSql()
{
    // Arrange
    var dialect = new OracleSqlDialect();

    // Act
    var sql = dialect.BuildSelectSql(new[] { "ABAN8", "ABALPH" }, "F0101", null);

    // Assert
    sql.Should().Contain("SELECT ABAN8, ABALPH FROM F0101");
}

// Integration tests (require database)
[Fact(Skip = "Integration test - requires Oracle database")]
public async Task QueryAsync_ReturnsExpectedResults()
{
    // Test implementation
}
```

## Adding a New Database Provider

1. Create a new project: `JDE.Providers.{DatabaseName}`
2. Implement `ISqlDialect` for SQL generation
3. Implement `IDbProvider` for connection and execution
4. Add provider-specific type mappings
5. Write comprehensive tests
6. Update documentation

## Documentation

- Update README.md for user-facing changes
- Update CLAUDE.md for development context
- Add XML doc comments for public APIs
- Include code examples for new features

## Commit Message Format

```
<type>: <short summary>

<optional detailed description>

<optional footer>
```

### Types

- `feat`: New feature
- `fix`: Bug fix
- `docs`: Documentation changes
- `test`: Adding or updating tests
- `refactor`: Code refactoring
- `perf`: Performance improvements
- `chore`: Maintenance tasks
- `ci`: CI/CD changes

### Examples

```
feat: add SQL Server provider support

Implement ISqlDialect and IDbProvider for SQL Server
using Microsoft.Data.SqlClient and Dapper.

Closes #42
```

```
fix: correct Oracle pagination for versions < 12c

Use ROWNUM-based pagination for Oracle 11g compatibility
instead of OFFSET-FETCH syntax.

Fixes #89
```

## Review Process

1. Automated CI checks must pass
2. Code review by maintainers
3. Documentation review
4. Approval and merge

## Questions?

- Open a discussion on GitHub
- Check existing issues and documentation
- Reach out to maintainers

Thank you for contributing to JDE Query Library!
