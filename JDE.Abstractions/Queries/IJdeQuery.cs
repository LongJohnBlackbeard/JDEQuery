namespace JDE.Abstractions.Queries;

/// <summary>
/// Represents a query that can be executed against a JDE database.
/// </summary>
/// <typeparam name="T">The type of result returned by the query.</typeparam>
public interface IJdeQuery<T>
{
    /// <summary>
    /// Gets the SQL statement for this query.
    /// </summary>
    string Sql { get; }

    /// <summary>
    /// Gets the parameters for this query.
    /// </summary>
    object? Parameters { get; }

    /// <summary>
    /// Gets the JDE table being queried.
    /// </summary>
    string TableName { get; }

    /// <summary>
    /// Gets the schema name.
    /// </summary>
    string? Schema { get; }
}
