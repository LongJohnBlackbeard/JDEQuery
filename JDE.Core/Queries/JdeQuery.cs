using JDE.Abstractions.Queries;

namespace JDE.Core.Queries;

/// <summary>
/// Base implementation of a JDE query.
/// </summary>
/// <typeparam name="T">The type of result returned by the query.</typeparam>
public class JdeQuery<T> : IJdeQuery<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JdeQuery{T}"/> class.
    /// </summary>
    /// <param name="sql">The SQL statement.</param>
    /// <param name="parameters">The query parameters.</param>
    /// <param name="tableName">The table name.</param>
    /// <param name="schema">The schema name.</param>
    public JdeQuery(string sql, object? parameters, string tableName, string? schema = null)
    {
        Sql = sql ?? throw new ArgumentNullException(nameof(sql));
        Parameters = parameters;
        TableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
        Schema = schema;
    }

    /// <inheritdoc />
    public string Sql { get; }

    /// <inheritdoc />
    public object? Parameters { get; }

    /// <inheritdoc />
    public string TableName { get; }

    /// <inheritdoc />
    public string? Schema { get; }
}
