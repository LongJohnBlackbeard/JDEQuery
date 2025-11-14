using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F075611 - .
/// </summary>
public class F075611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y9CKY2.
        /// </summary>
        public const string Y9CKY2 = "Y9CKY2";
    }

    /// <inheritdoc />
    public override string TableName => "F075611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y9CKY2", "Y9CKY2", JdeDataType.String, 240, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F075611_0", "Primary Key on Y9CKY2", new[] { "Y9CKY2" }, isUnique: true, isPrimaryKey: true)
    };
}
