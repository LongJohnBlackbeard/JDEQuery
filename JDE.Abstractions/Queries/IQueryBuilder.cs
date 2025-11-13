namespace JDE.Abstractions.Queries;

/// <summary>
/// Represents a fluent query builder for constructing JDE queries.
/// </summary>
/// <typeparam name="T">The type of result returned by the query.</typeparam>
public interface IQueryBuilder<T>
{
    /// <summary>
    /// Specifies which columns to select. If not called, SELECT * is used.
    /// </summary>
    /// <param name="fields">The field names to select.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> SelectFields(params string[] fields);

    /// <summary>
    /// Specifies which columns to select. If not called, SELECT * is used.
    /// </summary>
    /// <param name="fields">The field names to select.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> SelectFields(IEnumerable<string> fields);

    /// <summary>
    /// Uses a specific index for the query.
    /// </summary>
    /// <param name="indexName">The name of the index to use.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> UsingIndex(string indexName);

    /// <summary>
    /// Adds a WHERE condition for a specific field.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to filter by.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> Where(string fieldName, object? value);

    /// <summary>
    /// Adds multiple WHERE conditions.
    /// </summary>
    /// <param name="filters">Dictionary of field names and values.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> Where(IDictionary<string, object?> filters);

    /// <summary>
    /// Adds a filter condition (alias for Where).
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to filter by.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> Filter(string fieldName, object? value);

    /// <summary>
    /// Adds a WHERE condition with greater than operator.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereGreaterThan(string fieldName, object value);

    /// <summary>
    /// Adds a WHERE condition with less than operator.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereLessThan(string fieldName, object value);

    /// <summary>
    /// Adds a WHERE condition with greater than or equal operator.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereGreaterThanOrEqual(string fieldName, object value);

    /// <summary>
    /// Adds a WHERE condition with less than or equal operator.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereLessThanOrEqual(string fieldName, object value);

    /// <summary>
    /// Adds a WHERE condition with not equal operator.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereNotEqual(string fieldName, object? value);

    /// <summary>
    /// Adds a LIKE condition for pattern matching.
    /// Useful for JDE fields with padding where exact match may not work.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="pattern">The LIKE pattern (use % for wildcards).</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereLike(string fieldName, string pattern);

    /// <summary>
    /// Adds a WHERE condition that trims the field before comparison.
    /// Useful for JDE fields that are padded to max length.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="value">The value to compare against (without padding).</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> WhereTrimmedEqual(string fieldName, string value);

    /// <summary>
    /// Skips a specified number of rows (for pagination).
    /// </summary>
    /// <param name="count">Number of rows to skip.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> Skip(int count);

    /// <summary>
    /// Takes a specified number of rows (for pagination).
    /// </summary>
    /// <param name="count">Number of rows to take.</param>
    /// <returns>The query builder for chaining.</returns>
    IQueryBuilder<T> Take(int count);

    /// <summary>
    /// Builds and returns the query.
    /// </summary>
    /// <returns>The constructed query.</returns>
    IJdeQuery<T> Build();

    /// <summary>
    /// Executes the query and returns a single result.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A single result or null.</returns>
    Task<T?> FetchSingleAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes the query and returns multiple results.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of results.</returns>
    Task<IEnumerable<T>> FetchManyAsync(CancellationToken cancellationToken = default);
}
