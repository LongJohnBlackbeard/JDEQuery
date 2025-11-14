using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A32 - .
/// </summary>
public class F76A32 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// X3AID.
        /// </summary>
        public const string X3AID = "X3AID";

        /// <summary>
        /// X3AID2.
        /// </summary>
        public const string X3AID2 = "X3AID2";
    }

    /// <inheritdoc />
    public override string TableName => "F76A32";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("X3AID", "X3AID", JdeDataType.String, 16, true, true),
        new JdeField("X3AID2", "X3AID2", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A32_0", "Primary Key on X3AID", new[] { "X3AID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A32_2", "Index on X3AID2", new[] { "X3AID2" })
    };
}
