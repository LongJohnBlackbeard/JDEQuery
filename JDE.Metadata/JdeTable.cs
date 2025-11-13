using JDE.Abstractions.Metadata;

namespace JDE.Metadata;

/// <summary>
/// Base class for JDE table metadata.
/// </summary>
public abstract class JdeTable : IJdeTable
{
    private readonly Lazy<IJdeIndex?> _primaryKey;

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeTable"/> class.
    /// </summary>
    protected JdeTable()
    {
        _primaryKey = new Lazy<IJdeIndex?>(() => Indexes.FirstOrDefault(i => i.IsPrimaryKey));
    }

    /// <inheritdoc />
    public abstract string TableName { get; }

    /// <inheritdoc />
    public abstract string Description { get; }

    /// <inheritdoc />
    public abstract IReadOnlyList<IJdeField> Fields { get; }

    /// <inheritdoc />
    public abstract IReadOnlyList<IJdeIndex> Indexes { get; }

    /// <inheritdoc />
    public IJdeIndex? PrimaryKey => _primaryKey.Value;

    /// <summary>
    /// Gets a field by name.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <returns>The field, or null if not found.</returns>
    public IJdeField? GetField(string fieldName)
    {
        return Fields.FirstOrDefault(f =>
            string.Equals(f.FieldName, fieldName, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets an index by name.
    /// </summary>
    /// <param name="indexName">The index name.</param>
    /// <returns>The index, or null if not found.</returns>
    public IJdeIndex? GetIndex(string indexName)
    {
        return Indexes.FirstOrDefault(i =>
            string.Equals(i.IndexName, indexName, StringComparison.OrdinalIgnoreCase));
    }
}
