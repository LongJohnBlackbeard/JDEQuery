namespace JDE.Abstractions.Metadata;

/// <summary>
/// Represents an index on a JD Edwards table.
/// </summary>
public interface IJdeIndex
{
    /// <summary>
    /// Gets the index name (e.g., "PK_F0101", "IDX_F0101_TYPE").
    /// </summary>
    string IndexName { get; }

    /// <summary>
    /// Gets the description of the index.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Gets the ordered list of field names that comprise this index.
    /// </summary>
    IReadOnlyList<string> Fields { get; }

    /// <summary>
    /// Gets whether this is a unique index.
    /// </summary>
    bool IsUnique { get; }

    /// <summary>
    /// Gets whether this is the primary key index.
    /// </summary>
    bool IsPrimaryKey { get; }
}
