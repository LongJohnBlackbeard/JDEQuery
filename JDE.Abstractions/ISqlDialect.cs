namespace JDE.Abstractions;

/// <summary>
/// Represents a SQL dialect that generates database-specific SQL statements.
/// </summary>
public interface ISqlDialect
{
    /// <summary>
    /// Gets the name of the database dialect (e.g., "Oracle", "SqlServer").
    /// </summary>
    string DialectName { get; }

    /// <summary>
    /// Gets the parameter prefix used by this dialect (e.g., ":" for Oracle, "@" for SQL Server).
    /// </summary>
    string ParameterPrefix { get; }

    /// <summary>
    /// Builds a SELECT SQL statement.
    /// </summary>
    /// <param name="columns">The columns to select, or null for SELECT *.</param>
    /// <param name="tableName">The table name to select from.</param>
    /// <param name="schema">Optional schema name.</param>
    /// <param name="whereClause">Optional WHERE clause (without the WHERE keyword).</param>
    /// <returns>A SELECT SQL statement.</returns>
    string BuildSelectSql(
        IEnumerable<string>? columns,
        string tableName,
        string? schema = null,
        string? whereClause = null);

    /// <summary>
    /// Applies pagination to a SQL statement.
    /// </summary>
    /// <param name="sql">The base SQL statement.</param>
    /// <param name="skip">Number of rows to skip.</param>
    /// <param name="take">Number of rows to take.</param>
    /// <returns>SQL statement with pagination applied.</returns>
    string ApplyPagination(string sql, int? skip, int? take);

    /// <summary>
    /// Quotes an identifier (table name, column name, etc.) for the specific database.
    /// </summary>
    /// <param name="identifier">The identifier to quote.</param>
    /// <returns>The quoted identifier.</returns>
    string QuoteIdentifier(string identifier);

    /// <summary>
    /// Builds a parameterized WHERE clause from field/value pairs.
    /// </summary>
    /// <param name="filters">Dictionary of field names and their values.</param>
    /// <returns>WHERE clause with parameters (without the WHERE keyword).</returns>
    string BuildWhereClause(IDictionary<string, object?> filters);

    /// <summary>
    /// Formats a parameter name with the correct prefix.
    /// </summary>
    /// <param name="parameterName">The parameter name without prefix.</param>
    /// <returns>The formatted parameter name with prefix.</returns>
    string FormatParameterName(string parameterName);
}
