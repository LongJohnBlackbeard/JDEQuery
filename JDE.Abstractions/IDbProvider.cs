namespace JDE.Abstractions;

/// <summary>
/// Represents a database provider that executes queries and returns results.
/// </summary>
public interface IDbProvider : IDisposable
{
    /// <summary>
    /// Gets the name of the database provider (e.g., "Oracle", "SqlServer").
    /// </summary>
    string ProviderName { get; }

    /// <summary>
    /// Executes a query and returns a single result or null if no results found.
    /// </summary>
    /// <typeparam name="T">The type to map the result to.</typeparam>
    /// <param name="sql">The SQL query to execute.</param>
    /// <param name="param">Optional parameters for the query.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A single result of type T, or null if no results found.</returns>
    Task<T?> QuerySingleOrDefaultAsync<T>(string sql, object? param = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes a query and returns multiple results.
    /// </summary>
    /// <typeparam name="T">The type to map the results to.</typeparam>
    /// <param name="sql">The SQL query to execute.</param>
    /// <param name="param">Optional parameters for the query.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of results of type T.</returns>
    Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Tests the database connection.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if connection is successful, false otherwise.</returns>
    Task<bool> TestConnectionAsync(CancellationToken cancellationToken = default);
}
