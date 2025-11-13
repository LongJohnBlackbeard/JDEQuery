using JDE.Abstractions;
using JDE.Abstractions.Configuration;
using JDE.Abstractions.Queries;
using JDE.Core.Queries;

namespace JDE.Client;

/// <summary>
/// Main client for querying JD Edwards database.
/// </summary>
public class JdeClient : IDisposable
{
    private readonly QueryFactory _queryFactory;
    private readonly IDbProvider _dbProvider;
    private readonly IJdeConfiguration _configuration;
    private bool _disposed;

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeClient"/> class.
    /// </summary>
    /// <param name="dbProvider">The database provider.</param>
    /// <param name="sqlDialect">The SQL dialect.</param>
    /// <param name="configuration">The JDE configuration.</param>
    public JdeClient(
        IDbProvider dbProvider,
        ISqlDialect sqlDialect,
        IJdeConfiguration configuration)
    {
        _dbProvider = dbProvider ?? throw new ArgumentNullException(nameof(dbProvider));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

        if (sqlDialect == null)
        {
            throw new ArgumentNullException(nameof(sqlDialect));
        }

        _queryFactory = new QueryFactory(sqlDialect, dbProvider, configuration);
    }

    /// <summary>
    /// Gets the database provider name.
    /// </summary>
    public string ProviderName => _dbProvider.ProviderName;

    /// <summary>
    /// Gets the schema name.
    /// </summary>
    public string Schema => _configuration.Schema;

    /// <summary>
    /// Gets the environment name.
    /// </summary>
    public string? Environment => _configuration.Environment;

    /// <summary>
    /// Creates a new query builder for the specified table.
    /// </summary>
    /// <typeparam name="T">The type of result.</typeparam>
    /// <param name="tableName">The table name (e.g., "F0101").</param>
    /// <returns>A query builder for the specified table.</returns>
    public IQueryBuilder<T> Query<T>(string tableName)
    {
        if (string.IsNullOrWhiteSpace(tableName))
        {
            throw new ArgumentException("Table name cannot be null or whitespace.", nameof(tableName));
        }

        return _queryFactory.CreateQuery<T>(tableName);
    }

    /// <summary>
    /// Tests the database connection.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>True if connection is successful.</returns>
    public async Task<bool> TestConnectionAsync(CancellationToken cancellationToken = default)
    {
        return await _dbProvider.TestConnectionAsync(cancellationToken);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases resources used by the client.
    /// </summary>
    /// <param name="disposing">True if disposing managed resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _dbProvider?.Dispose();
            }

            _disposed = true;
        }
    }
}
