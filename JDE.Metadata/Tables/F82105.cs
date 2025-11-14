using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82105 - .
/// </summary>
public class F82105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2QRYG.
        /// </summary>
        public const string A2QRYG = "A2QRYG";

        /// <summary>
        /// A2QRYN.
        /// </summary>
        public const string A2QRYN = "A2QRYN";

        /// <summary>
        /// A2SQND.
        /// </summary>
        public const string A2SQND = "A2SQND";

        /// <summary>
        /// A2SLFD.
        /// </summary>
        public const string A2SLFD = "A2SLFD";

        /// <summary>
        /// A2FILI.
        /// </summary>
        public const string A2FILI = "A2FILI";

        /// <summary>
        /// A2SREL.
        /// </summary>
        public const string A2SREL = "A2SREL";

        /// <summary>
        /// A2AO.
        /// </summary>
        public const string A2AO = "A2AO";

        /// <summary>
        /// A2DSCR.
        /// </summary>
        public const string A2DSCR = "A2DSCR";

        /// <summary>
        /// A2QSVL.
        /// </summary>
        public const string A2QSVL = "A2QSVL";

        /// <summary>
        /// A2DVC.
        /// </summary>
        public const string A2DVC = "A2DVC";

        /// <summary>
        /// A2VLL.
        /// </summary>
        public const string A2VLL = "A2VLL";

        /// <summary>
        /// A2SVTY.
        /// </summary>
        public const string A2SVTY = "A2SVTY";

        /// <summary>
        /// A2LR.
        /// </summary>
        public const string A2LR = "A2LR";

        /// <summary>
        /// A2DTAS.
        /// </summary>
        public const string A2DTAS = "A2DTAS";

        /// <summary>
        /// A2DTAT.
        /// </summary>
        public const string A2DTAT = "A2DTAT";

        /// <summary>
        /// A2MCRG.
        /// </summary>
        public const string A2MCRG = "A2MCRG";
    }

    /// <inheritdoc />
    public override string TableName => "F82105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2QRYG", "A2QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A2QRYN", "A2QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A2SQND", "A2SQND", JdeDataType.Numeric, null, true, true),
        new JdeField("A2SLFD", "A2SLFD", JdeDataType.String, 20, true, true),
        new JdeField("A2FILI", "A2FILI", JdeDataType.Numeric),
        new JdeField("A2SREL", "A2SREL", JdeDataType.String, 12),
        new JdeField("A2AO", "A2AO", JdeDataType.String, 2),
        new JdeField("A2DSCR", "A2DSCR", JdeDataType.String, 80),
        new JdeField("A2QSVL", "A2QSVL", JdeDataType.String, 50),
        new JdeField("A2DVC", "A2DVC", JdeDataType.Numeric),
        new JdeField("A2VLL", "A2VLL", JdeDataType.Numeric),
        new JdeField("A2SVTY", "A2SVTY", JdeDataType.String, 2),
        new JdeField("A2LR", "A2LR", JdeDataType.String, 2),
        new JdeField("A2DTAS", "A2DTAS", JdeDataType.Numeric),
        new JdeField("A2DTAT", "A2DTAT", JdeDataType.String, 2),
        new JdeField("A2MCRG", "A2MCRG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82105_0", "Primary Key on A2QRYG, A2QRYN, A2SQND, A2SLFD", new[] { "A2QRYG", "A2QRYN", "A2SQND", "A2SLFD" }, isUnique: true, isPrimaryKey: true)
    };
}
