namespace JDE.Abstractions.Metadata;

/// <summary>
/// Represents a JD Edwards table with its metadata.
/// </summary>
public interface IJdeTable
{
    /// <summary>
    /// Gets the JDE table name (e.g., "F0101").
    /// </summary>
    string TableName { get; }

    /// <summary>
    /// Gets the table description.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Gets the list of fields in this table.
    /// </summary>
    IReadOnlyList<IJdeField> Fields { get; }

    /// <summary>
    /// Gets the list of indexes defined for this table.
    /// </summary>
    IReadOnlyList<IJdeIndex> Indexes { get; }

    /// <summary>
    /// Gets the primary key index for this table.
    /// </summary>
    IJdeIndex? PrimaryKey { get; }
}
