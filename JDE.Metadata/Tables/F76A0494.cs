using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0494 - .
/// </summary>
public class F76A0494 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D1DOC.
        /// </summary>
        public const string D1DOC = "D1DOC";

        /// <summary>
        /// D1ARCP.
        /// </summary>
        public const string D1ARCP = "D1ARCP";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0494";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D1DOC", "D1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D1ARCP", "D1ARCP", JdeDataType.String, 738)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0494_0", "Primary Key on D1DOC", new[] { "D1DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
