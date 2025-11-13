using JDE.Abstractions.Metadata;

namespace JDE.Metadata;

/// <summary>
/// Represents an index on a JDE table.
/// </summary>
public class JdeIndex : IJdeIndex
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JdeIndex"/> class.
    /// </summary>
    /// <param name="indexName">The index name.</param>
    /// <param name="description">The index description.</param>
    /// <param name="fields">The fields that comprise this index.</param>
    /// <param name="isUnique">Whether this is a unique index.</param>
    /// <param name="isPrimaryKey">Whether this is the primary key.</param>
    public JdeIndex(
        string indexName,
        string description,
        IReadOnlyList<string> fields,
        bool isUnique = false,
        bool isPrimaryKey = false)
    {
        if (fields == null || fields.Count == 0)
        {
            throw new ArgumentException("Index must have at least one field.", nameof(fields));
        }

        IndexName = indexName ?? throw new ArgumentNullException(nameof(indexName));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        Fields = fields;
        IsUnique = isUnique;
        IsPrimaryKey = isPrimaryKey;
    }

    /// <inheritdoc />
    public string IndexName { get; }

    /// <inheritdoc />
    public string Description { get; }

    /// <inheritdoc />
    public IReadOnlyList<string> Fields { get; }

    /// <inheritdoc />
    public bool IsUnique { get; }

    /// <inheritdoc />
    public bool IsPrimaryKey { get; }
}
