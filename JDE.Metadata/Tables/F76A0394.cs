using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0394 - .
/// </summary>
public class F76A0394 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R0DOC.
        /// </summary>
        public const string R0DOC = "R0DOC";

        /// <summary>
        /// R0AVTA.
        /// </summary>
        public const string R0AVTA = "R0AVTA";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0394";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R0DOC", "R0DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("R0AVTA", "R0AVTA", JdeDataType.String, 750)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0394_0", "Primary Key on R0DOC", new[] { "R0DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
