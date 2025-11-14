using JDE.Abstractions;
using JDE.Abstractions.Queries;
using JDE.Abstractions.Configuration;
using JDE.Abstractions.Exceptions;

namespace JDE.Core.Queries;

/// <summary>
/// Fluent query builder for constructing JDE queries.
/// </summary>
/// <typeparam name="T">The type of result returned by the query.</typeparam>
public class QueryBuilder<T> : IQueryBuilder<T>
{
    private readonly ISqlDialect _sqlDialect;
    private readonly IDbProvider _dbProvider;
    private readonly IJdeConfiguration _configuration;
    private readonly string _tableName;

    private List<string>? _selectedFields;
    private string? _indexName;
    private readonly List<WhereCondition> _conditions = new();
    private int? _skip;
    private int? _take;

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryBuilder{T}"/> class.
    /// </summary>
    /// <param name="tableName">The table name to query.</param>
    /// <param name="sqlDialect">The SQL dialect to use.</param>
    /// <param name="dbProvider">The database provider.</param>
    /// <param name="configuration">The JDE configuration.</param>
    public QueryBuilder(
        string tableName,
        ISqlDialect sqlDialect,
        IDbProvider dbProvider,
        IJdeConfiguration configuration)
    {
        _tableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
        _sqlDialect = sqlDialect ?? throw new ArgumentNullException(nameof(sqlDialect));
        _dbProvider = dbProvider ?? throw new ArgumentNullException(nameof(dbProvider));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    /// <inheritdoc />
    public IQueryBuilder<T> SelectFields(params string[] fields)
    {
        if (fields == null || fields.Length == 0)
        {
            throw new ArgumentException("At least one field must be specified.", nameof(fields));
        }

        _selectedFields = new List<string>(fields);
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> SelectFields(IEnumerable<string> fields)
    {
        if (fields == null)
        {
            throw new ArgumentNullException(nameof(fields));
        }

        var fieldList = fields.ToList();
        if (fieldList.Count == 0)
        {
            throw new ArgumentException("At least one field must be specified.", nameof(fields));
        }

        _selectedFields = fieldList;
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> UsingIndex(string indexName)
    {
        if (string.IsNullOrWhiteSpace(indexName))
        {
            throw new ArgumentException("Index name cannot be null or whitespace.", nameof(indexName));
        }

        _indexName = indexName;
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> Where(string fieldName, object? value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.Equal, value));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> Where(IDictionary<string, object?> filters)
    {
        if (filters == null)
        {
            throw new ArgumentNullException(nameof(filters));
        }

        foreach (var filter in filters)
        {
            _conditions.Add(new WhereCondition(filter.Key, WhereOperator.Equal, filter.Value));
        }

        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> Filter(string fieldName, object? value)
    {
        return Where(fieldName, value);
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereGreaterThan(string fieldName, object value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Value cannot be null for comparison operators.");
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.GreaterThan, value));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereLessThan(string fieldName, object value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Value cannot be null for comparison operators.");
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.LessThan, value));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereGreaterThanOrEqual(string fieldName, object value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Value cannot be null for comparison operators.");
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.GreaterThanOrEqual, value));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereLessThanOrEqual(string fieldName, object value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Value cannot be null for comparison operators.");
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.LessThanOrEqual, value));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereNotEqual(string fieldName, object? value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.NotEqual, value));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereLike(string fieldName, string pattern)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        if (pattern == null)
        {
            throw new ArgumentNullException(nameof(pattern));
        }

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.Like, pattern));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> WhereTrimmedEqual(string fieldName, string value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        // Automatically trim the user's input to handle cases where they copy values
        // directly from the database with padding
        var trimmedValue = value.Trim();

        _conditions.Add(new WhereCondition(fieldName, WhereOperator.TrimmedEqual, trimmedValue));
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> Skip(int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Skip count cannot be negative.");
        }

        _skip = count;
        return this;
    }

    /// <inheritdoc />
    public IQueryBuilder<T> Take(int count)
    {
        if (count <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Take count must be greater than 0.");
        }

        _take = count;
        return this;
    }

    /// <inheritdoc />
    public IJdeQuery<T> Build()
    {
        // Build WHERE clause
        string? whereClause = null;
        if (_conditions.Count > 0)
        {
            whereClause = _sqlDialect.BuildWhereClause(_conditions);
        }

        // Build base SELECT statement
        var sql = _sqlDialect.BuildSelectSql(
            _selectedFields,
            _tableName,
            _configuration.Schema,
            whereClause);

        // Apply pagination if specified
        if (_skip.HasValue || _take.HasValue)
        {
            sql = _sqlDialect.ApplyPagination(sql, _skip, _take);
        }

        // Convert conditions to parameter object for Dapper
        object? parameters = null;
        if (_conditions.Count > 0)
        {
            var paramDict = new Dictionary<string, object?>();
            for (int i = 0; i < _conditions.Count; i++)
            {
                paramDict[$"p{i}"] = _conditions[i].Value;
            }
            parameters = paramDict;
        }

        return new JdeQuery<T>(sql, parameters, _tableName, _configuration.Schema);
    }

    /// <inheritdoc />
    public async Task<T?> FetchSingleAsync(CancellationToken cancellationToken = default)
    {
        var query = Build();

        try
        {
            return await _dbProvider.QuerySingleOrDefaultAsync<T>(
                query.Sql,
                query.Parameters,
                cancellationToken);
        }
        catch (Exception ex)
        {
            throw new JdeDataException(
                $"Failed to execute single-row query on table {_tableName}.",
                query.Sql,
                ex);
        }
    }

    /// <inheritdoc />
    public async Task<IEnumerable<T>> FetchManyAsync(CancellationToken cancellationToken = default)
    {
        var query = Build();

        try
        {
            return await _dbProvider.QueryAsync<T>(
                query.Sql,
                query.Parameters,
                cancellationToken);
        }
        catch (Exception ex)
        {
            throw new JdeDataException(
                $"Failed to execute multi-row query on table {_tableName}.",
                query.Sql,
                ex);
        }
    }
}
