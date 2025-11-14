using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H300W - .
/// </summary>
public class F74H300W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTSEQ.
        /// </summary>
        public const string WTSEQ = "WTSEQ";

        /// <summary>
        /// WT74MNDOC.
        /// </summary>
        public const string WT74MNDOC = "WT74MNDOC";

        /// <summary>
        /// WT74MXDOC.
        /// </summary>
        public const string WT74MXDOC = "WT74MXDOC";

        /// <summary>
        /// WT74MNDIVJ.
        /// </summary>
        public const string WT74MNDIVJ = "WT74MNDIVJ";

        /// <summary>
        /// WT74MXDIVJ.
        /// </summary>
        public const string WT74MXDIVJ = "WT74MXDIVJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74H300W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTSEQ", "WTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WT74MNDOC", "WT74MNDOC", JdeDataType.Numeric),
        new JdeField("WT74MXDOC", "WT74MXDOC", JdeDataType.Numeric),
        new JdeField("WT74MNDIVJ", "WT74MNDIVJ", JdeDataType.Numeric),
        new JdeField("WT74MXDIVJ", "WT74MXDIVJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H300W_0", "Primary Key on WTSEQ", new[] { "WTSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
