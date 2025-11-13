using JDE.Abstractions;
using System.Text;

namespace JDE.Providers.Oracle;

/// <summary>
/// Oracle-specific SQL dialect implementation.
/// </summary>
public class OracleSqlDialect : ISqlDialect
{
    /// <inheritdoc />
    public string DialectName => "Oracle";

    /// <inheritdoc />
    public string ParameterPrefix => ":";

    /// <inheritdoc />
    public string BuildSelectSql(
        IEnumerable<string>? columns,
        string tableName,
        string? schema = null,
        string? whereClause = null)
    {
        if (string.IsNullOrWhiteSpace(tableName))
        {
            throw new ArgumentException("Table name cannot be null or whitespace.", nameof(tableName));
        }

        var sql = new StringBuilder();

        // Build SELECT clause
        sql.Append("SELECT ");

        if (columns == null || !columns.Any())
        {
            sql.Append('*');
        }
        else
        {
            sql.Append(string.Join(", ", columns.Select(QuoteIdentifier)));
        }

        // Build FROM clause
        sql.Append(" FROM ");

        if (!string.IsNullOrWhiteSpace(schema))
        {
            sql.Append(QuoteIdentifier(schema));
            sql.Append('.');
        }

        sql.Append(QuoteIdentifier(tableName));

        // Build WHERE clause
        if (!string.IsNullOrWhiteSpace(whereClause))
        {
            sql.Append(" WHERE ");
            sql.Append(whereClause);
        }

        return sql.ToString();
    }

    /// <inheritdoc />
    public string ApplyPagination(string sql, int? skip, int? take)
    {
        if (string.IsNullOrWhiteSpace(sql))
        {
            throw new ArgumentException("SQL cannot be null or whitespace.", nameof(sql));
        }

        // If no pagination, return original SQL
        if (!skip.HasValue && !take.HasValue)
        {
            return sql;
        }

        // Oracle 12c+ supports OFFSET-FETCH syntax
        // For compatibility, we'll use this modern syntax
        var paginatedSql = new StringBuilder(sql);

        if (skip.HasValue && skip.Value > 0)
        {
            paginatedSql.Append($" OFFSET {skip.Value} ROWS");
        }

        if (take.HasValue && take.Value > 0)
        {
            if (!skip.HasValue || skip.Value == 0)
            {
                // If no OFFSET, we still need to specify it for FETCH
                paginatedSql.Append(" OFFSET 0 ROWS");
            }

            paginatedSql.Append($" FETCH NEXT {take.Value} ROWS ONLY");
        }

        return paginatedSql.ToString();
    }

    /// <inheritdoc />
    public string QuoteIdentifier(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
        {
            throw new ArgumentException("Identifier cannot be null or whitespace.", nameof(identifier));
        }

        // Oracle uses double quotes for identifiers
        // Remove any existing quotes first to avoid double-quoting
        var cleanIdentifier = identifier.Trim('"');

        return $"\"{cleanIdentifier}\"";
    }

    /// <inheritdoc />
    public string BuildWhereClause(IDictionary<string, object?> filters)
    {
        if (filters == null || filters.Count == 0)
        {
            return string.Empty;
        }

        var conditions = new List<string>();
        var paramIndex = 0;

        foreach (var filter in filters)
        {
            var fieldName = QuoteIdentifier(filter.Key);
            var paramName = FormatParameterName($"p{paramIndex}");

            if (filter.Value == null)
            {
                conditions.Add($"{fieldName} IS NULL");
            }
            else
            {
                conditions.Add($"{fieldName} = {paramName}");
            }

            paramIndex++;
        }

        return string.Join(" AND ", conditions);
    }

    /// <inheritdoc />
    public string FormatParameterName(string parameterName)
    {
        if (string.IsNullOrWhiteSpace(parameterName))
        {
            throw new ArgumentException("Parameter name cannot be null or whitespace.", nameof(parameterName));
        }

        // Remove any existing prefix
        var cleanName = parameterName.TrimStart(':', '@');

        return $"{ParameterPrefix}{cleanName}";
    }
}
