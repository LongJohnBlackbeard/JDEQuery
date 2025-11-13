using JDE.Abstractions.Metadata;

namespace JDE.Metadata;

/// <summary>
/// Represents a field in a JDE table.
/// </summary>
public class JdeField : IJdeField
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JdeField"/> class.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <param name="description">The field description.</param>
    /// <param name="dataType">The data type.</param>
    /// <param name="maxLength">The maximum length (for string types).</param>
    /// <param name="isRequired">Whether the field is required.</param>
    /// <param name="isPrimaryKey">Whether the field is part of the primary key.</param>
    public JdeField(
        string fieldName,
        string description,
        JdeDataType dataType,
        int? maxLength = null,
        bool isRequired = false,
        bool isPrimaryKey = false)
    {
        FieldName = fieldName ?? throw new ArgumentNullException(nameof(fieldName));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        DataType = dataType;
        MaxLength = maxLength;
        IsRequired = isRequired;
        IsPrimaryKey = isPrimaryKey;
    }

    /// <inheritdoc />
    public string FieldName { get; }

    /// <inheritdoc />
    public string Description { get; }

    /// <inheritdoc />
    public JdeDataType DataType { get; }

    /// <inheritdoc />
    public int? MaxLength { get; }

    /// <inheritdoc />
    public bool IsRequired { get; }

    /// <inheritdoc />
    public bool IsPrimaryKey { get; }
}
