namespace JDE.Abstractions.Queries;

/// <summary>
/// Represents the type of WHERE condition operator.
/// </summary>
public enum WhereOperator
{
    /// <summary>
    /// Equality operator (=).
    /// </summary>
    Equal,

    /// <summary>
    /// Not equal operator (!= or <>).
    /// </summary>
    NotEqual,

    /// <summary>
    /// Greater than operator (>).
    /// </summary>
    GreaterThan,

    /// <summary>
    /// Less than operator (<).
    /// </summary>
    LessThan,

    /// <summary>
    /// Greater than or equal operator (>=).
    /// </summary>
    GreaterThanOrEqual,

    /// <summary>
    /// Less than or equal operator (<=).
    /// </summary>
    LessThanOrEqual,

    /// <summary>
    /// LIKE operator for pattern matching.
    /// </summary>
    Like,

    /// <summary>
    /// Trimmed equality - uses TRIM function before comparison.
    /// </summary>
    TrimmedEqual
}

/// <summary>
/// Represents a WHERE condition with field, operator, and value.
/// </summary>
public class WhereCondition
{
    /// <summary>
    /// Gets the field name.
    /// </summary>
    public string FieldName { get; }

    /// <summary>
    /// Gets the comparison operator.
    /// </summary>
    public WhereOperator Operator { get; }

    /// <summary>
    /// Gets the value to compare against.
    /// </summary>
    public object? Value { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WhereCondition"/> class.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="operator">The comparison operator.</param>
    /// <param name="value">The value to compare against.</param>
    public WhereCondition(string fieldName, WhereOperator @operator, object? value)
    {
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            throw new ArgumentException("Field name cannot be null or whitespace.", nameof(fieldName));
        }

        FieldName = fieldName;
        Operator = @operator;
        Value = value;
    }
}
