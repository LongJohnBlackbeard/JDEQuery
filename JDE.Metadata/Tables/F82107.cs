using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82107 - .
/// </summary>
public class F82107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A3QRYG.
        /// </summary>
        public const string A3QRYG = "A3QRYG";

        /// <summary>
        /// A3QRYN.
        /// </summary>
        public const string A3QRYN = "A3QRYN";

        /// <summary>
        /// A3SQNE.
        /// </summary>
        public const string A3SQNE = "A3SQNE";

        /// <summary>
        /// A3SFD.
        /// </summary>
        public const string A3SFD = "A3SFD";

        /// <summary>
        /// A3SFDI.
        /// </summary>
        public const string A3SFDI = "A3SFDI";

        /// <summary>
        /// A3DSCR.
        /// </summary>
        public const string A3DSCR = "A3DSCR";

        /// <summary>
        /// A3SRTS.
        /// </summary>
        public const string A3SRTS = "A3SRTS";

        /// <summary>
        /// A3QTOT.
        /// </summary>
        public const string A3QTOT = "A3QTOT";

        /// <summary>
        /// A3QPBK.
        /// </summary>
        public const string A3QPBK = "A3QPBK";

        /// <summary>
        /// A3LSP.
        /// </summary>
        public const string A3LSP = "A3LSP";

        /// <summary>
        /// A3SUMF.
        /// </summary>
        public const string A3SUMF = "A3SUMF";

        /// <summary>
        /// A3TPRT.
        /// </summary>
        public const string A3TPRT = "A3TPRT";

        /// <summary>
        /// A3THDR.
        /// </summary>
        public const string A3THDR = "A3THDR";
    }

    /// <inheritdoc />
    public override string TableName => "F82107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A3QRYG", "A3QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A3QRYN", "A3QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A3SQNE", "A3SQNE", JdeDataType.Numeric, null, true, true),
        new JdeField("A3SFD", "A3SFD", JdeDataType.String, 20),
        new JdeField("A3SFDI", "A3SFDI", JdeDataType.Numeric),
        new JdeField("A3DSCR", "A3DSCR", JdeDataType.String, 80),
        new JdeField("A3SRTS", "A3SRTS", JdeDataType.String, 2),
        new JdeField("A3QTOT", "A3QTOT", JdeDataType.Numeric),
        new JdeField("A3QPBK", "A3QPBK", JdeDataType.String, 2),
        new JdeField("A3LSP", "A3LSP", JdeDataType.Numeric),
        new JdeField("A3SUMF", "A3SUMF", JdeDataType.String, 2),
        new JdeField("A3TPRT", "A3TPRT", JdeDataType.String, 120),
        new JdeField("A3THDR", "A3THDR", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82107_0", "Primary Key on A3QRYG, A3QRYN, A3SQNE", new[] { "A3QRYG", "A3QRYN", "A3SQNE" }, isUnique: true, isPrimaryKey: true)
    };
}
