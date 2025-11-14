using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43092 - .
/// </summary>
public class F43092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PXKCOO.
        /// </summary>
        public const string PXKCOO = "PXKCOO";

        /// <summary>
        /// PXDOCO.
        /// </summary>
        public const string PXDOCO = "PXDOCO";

        /// <summary>
        /// PXDCTO.
        /// </summary>
        public const string PXDCTO = "PXDCTO";

        /// <summary>
        /// PXSFXO.
        /// </summary>
        public const string PXSFXO = "PXSFXO";

        /// <summary>
        /// PXLNID.
        /// </summary>
        public const string PXLNID = "PXLNID";

        /// <summary>
        /// PXNLIN.
        /// </summary>
        public const string PXNLIN = "PXNLIN";

        /// <summary>
        /// PXMCU.
        /// </summary>
        public const string PXMCU = "PXMCU";

        /// <summary>
        /// PXNROU.
        /// </summary>
        public const string PXNROU = "PXNROU";

        /// <summary>
        /// PXOPRS.
        /// </summary>
        public const string PXOPRS = "PXOPRS";

        /// <summary>
        /// PXOPRC.
        /// </summary>
        public const string PXOPRC = "PXOPRC";

        /// <summary>
        /// PXTRTY.
        /// </summary>
        public const string PXTRTY = "PXTRTY";

        /// <summary>
        /// PXPDAY.
        /// </summary>
        public const string PXPDAY = "PXPDAY";

        /// <summary>
        /// PXADAY.
        /// </summary>
        public const string PXADAY = "PXADAY";

        /// <summary>
        /// PXUPIB.
        /// </summary>
        public const string PXUPIB = "PXUPIB";

        /// <summary>
        /// PXUPGL.
        /// </summary>
        public const string PXUPGL = "PXUPGL";

        /// <summary>
        /// PXGLPT.
        /// </summary>
        public const string PXGLPT = "PXGLPT";

        /// <summary>
        /// PXRCPT.
        /// </summary>
        public const string PXRCPT = "PXRCPT";

        /// <summary>
        /// PXPMTE.
        /// </summary>
        public const string PXPMTE = "PXPMTE";

        /// <summary>
        /// PXACTO.
        /// </summary>
        public const string PXACTO = "PXACTO";

        /// <summary>
        /// PXUOM.
        /// </summary>
        public const string PXUOM = "PXUOM";

        /// <summary>
        /// PXQTYO.
        /// </summary>
        public const string PXQTYO = "PXQTYO";

        /// <summary>
        /// PXLOCN.
        /// </summary>
        public const string PXLOCN = "PXLOCN";
    }

    /// <inheritdoc />
    public override string TableName => "F43092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PXKCOO", "PXKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PXDOCO", "PXDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PXDCTO", "PXDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PXSFXO", "PXSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PXLNID", "PXLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PXNLIN", "PXNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PXMCU", "PXMCU", JdeDataType.String, 24),
        new JdeField("PXNROU", "PXNROU", JdeDataType.String, 8),
        new JdeField("PXOPRS", "PXOPRS", JdeDataType.Numeric, null, true, true),
        new JdeField("PXOPRC", "PXOPRC", JdeDataType.String, 8),
        new JdeField("PXTRTY", "PXTRTY", JdeDataType.String, 6),
        new JdeField("PXPDAY", "PXPDAY", JdeDataType.Numeric),
        new JdeField("PXADAY", "PXADAY", JdeDataType.Numeric),
        new JdeField("PXUPIB", "PXUPIB", JdeDataType.String, 8),
        new JdeField("PXUPGL", "PXUPGL", JdeDataType.String, 2),
        new JdeField("PXGLPT", "PXGLPT", JdeDataType.String, 8),
        new JdeField("PXRCPT", "PXRCPT", JdeDataType.String, 2),
        new JdeField("PXPMTE", "PXPMTE", JdeDataType.String, 2),
        new JdeField("PXACTO", "PXACTO", JdeDataType.String, 2),
        new JdeField("PXUOM", "PXUOM", JdeDataType.String, 4, true, true),
        new JdeField("PXQTYO", "PXQTYO", JdeDataType.Numeric),
        new JdeField("PXLOCN", "PXLOCN", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43092_0", "Primary Key on PXDOCO, PXDCTO, PXKCOO, PXSFXO, PXLNID, PXNLIN, PXUOM, PXOPRS", new[] { "PXDOCO", "PXDCTO", "PXKCOO", "PXSFXO", "PXLNID", "PXNLIN", "PXUOM", "PXOPRS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43092_2", "Index on PXACTO, PXDOCO, PXDCTO, PXKCOO, PXSFXO, PXLNID", new[] { "PXACTO", "PXDOCO", "PXDCTO", "PXKCOO", "PXSFXO", "PXLNID" }),
        new JdeIndex("F43092_3", "Index on PXACTO, PXUPIB, PXDOCO, PXDCTO, PXKCOO, PXSFXO, PXLNID", new[] { "PXACTO", "PXUPIB", "PXDOCO", "PXDCTO", "PXKCOO", "PXSFXO", "PXLNID" }),
        new JdeIndex("F43092_4", "Index on PXDOCO, PXDCTO, PXKCOO, PXSFXO, PXLNID, PXNLIN, PXOPRS, PXUOM", new[] { "PXDOCO", "PXDCTO", "PXKCOO", "PXSFXO", "PXLNID", "PXNLIN", "PXOPRS", "PXUOM" })
    };
}
