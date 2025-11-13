using JDE.Abstractions;
using JDE.Abstractions.Configuration;
using JDE.Abstractions.Queries;

namespace JDE.Core.Queries;

/// <summary>
/// Factory for creating query builders.
/// </summary>
public class QueryFactory
{
    private readonly ISqlDialect _sqlDialect;
    private readonly IDbProvider _dbProvider;
    private readonly IJdeConfiguration _configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryFactory"/> class.
    /// </summary>
    /// <param name="sqlDialect">The SQL dialect.</param>
    /// <param name="dbProvider">The database provider.</param>
    /// <param name="configuration">The JDE configuration.</param>
    public QueryFactory(
        ISqlDialect sqlDialect,
        IDbProvider dbProvider,
        IJdeConfiguration configuration)
    {
        _sqlDialect = sqlDialect ?? throw new ArgumentNullException(nameof(sqlDialect));
        _dbProvider = dbProvider ?? throw new ArgumentNullException(nameof(dbProvider));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    /// <summary>
    /// Creates a new query builder for the specified table.
    /// </summary>
    /// <typeparam name="T">The type of result returned by the query.</typeparam>
    /// <param name="tableName">The table name.</param>
    /// <returns>A new query builder instance.</returns>
    public IQueryBuilder<T> CreateQuery<T>(string tableName)
    {
        if (string.IsNullOrWhiteSpace(tableName))
        {
            throw new ArgumentException("Table name cannot be null or whitespace.", nameof(tableName));
        }

        return new QueryBuilder<T>(tableName, _sqlDialect, _dbProvider, _configuration);
    }
}
