namespace JDE.Abstractions.Metadata;

/// <summary>
/// Represents a field (column) in a JD Edwards table.
/// </summary>
public interface IJdeField
{
    /// <summary>
    /// Gets the field name (e.g., "ABAN8").
    /// </summary>
    string FieldName { get; }

    /// <summary>
    /// Gets the field description.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Gets the data type of the field.
    /// </summary>
    JdeDataType DataType { get; }

    /// <summary>
    /// Gets the maximum length of the field (for string types).
    /// </summary>
    int? MaxLength { get; }

    /// <summary>
    /// Gets whether the field is required (not nullable).
    /// </summary>
    bool IsRequired { get; }

    /// <summary>
    /// Gets whether this field is part of the primary key.
    /// </summary>
    bool IsPrimaryKey { get; }
}

/// <summary>
/// Represents JDE data types.
/// </summary>
public enum JdeDataType
{
    /// <summary>String/Character data.</summary>
    String,

    /// <summary>Numeric data.</summary>
    Numeric,

    /// <summary>Date data.</summary>
    Date,

    /// <summary>Decimal data.</summary>
    Decimal,

    /// <summary>Integer data.</summary>
    Integer,

    /// <summary>Long integer data.</summary>
    Long,

    /// <summary>Binary/BLOB data.</summary>
    Binary
}
