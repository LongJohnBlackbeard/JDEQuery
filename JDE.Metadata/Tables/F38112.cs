using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38112 - .
/// </summary>
public class F38112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DXDOCO.
        /// </summary>
        public const string DXDOCO = "DXDOCO";

        /// <summary>
        /// DXDCTO.
        /// </summary>
        public const string DXDCTO = "DXDCTO";

        /// <summary>
        /// DXKCOO.
        /// </summary>
        public const string DXKCOO = "DXKCOO";

        /// <summary>
        /// DXLNID.
        /// </summary>
        public const string DXLNID = "DXLNID";

        /// <summary>
        /// DXDMCT.
        /// </summary>
        public const string DXDMCT = "DXDMCT";

        /// <summary>
        /// DXDMCS.
        /// </summary>
        public const string DXDMCS = "DXDMCS";

        /// <summary>
        /// DXMCU.
        /// </summary>
        public const string DXMCU = "DXMCU";

        /// <summary>
        /// DXSEQ.
        /// </summary>
        public const string DXSEQ = "DXSEQ";

        /// <summary>
        /// DXPSR.
        /// </summary>
        public const string DXPSR = "DXPSR";

        /// <summary>
        /// DXPSRY.
        /// </summary>
        public const string DXPSRY = "DXPSRY";

        /// <summary>
        /// DXQCOM.
        /// </summary>
        public const string DXQCOM = "DXQCOM";

        /// <summary>
        /// DXCNQY.
        /// </summary>
        public const string DXCNQY = "DXCNQY";

        /// <summary>
        /// DXAA.
        /// </summary>
        public const string DXAA = "DXAA";

        /// <summary>
        /// DXCRCD.
        /// </summary>
        public const string DXCRCD = "DXCRCD";

        /// <summary>
        /// DXUOM.
        /// </summary>
        public const string DXUOM = "DXUOM";

        /// <summary>
        /// DXTRDJ.
        /// </summary>
        public const string DXTRDJ = "DXTRDJ";

        /// <summary>
        /// DXTV01.
        /// </summary>
        public const string DXTV01 = "DXTV01";

        /// <summary>
        /// DXTV02.
        /// </summary>
        public const string DXTV02 = "DXTV02";

        /// <summary>
        /// DXTV03.
        /// </summary>
        public const string DXTV03 = "DXTV03";

        /// <summary>
        /// DXURCD.
        /// </summary>
        public const string DXURCD = "DXURCD";

        /// <summary>
        /// DXURDT.
        /// </summary>
        public const string DXURDT = "DXURDT";

        /// <summary>
        /// DXURAB.
        /// </summary>
        public const string DXURAB = "DXURAB";

        /// <summary>
        /// DXURRF.
        /// </summary>
        public const string DXURRF = "DXURRF";

        /// <summary>
        /// DXUSER.
        /// </summary>
        public const string DXUSER = "DXUSER";

        /// <summary>
        /// DXPID.
        /// </summary>
        public const string DXPID = "DXPID";

        /// <summary>
        /// DXJOBN.
        /// </summary>
        public const string DXJOBN = "DXJOBN";

        /// <summary>
        /// DXUPMJ.
        /// </summary>
        public const string DXUPMJ = "DXUPMJ";

        /// <summary>
        /// DXTDAY.
        /// </summary>
        public const string DXTDAY = "DXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F38112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DXDOCO", "DXDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DXDCTO", "DXDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DXKCOO", "DXKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DXLNID", "DXLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DXDMCT", "DXDMCT", JdeDataType.String, 24),
        new JdeField("DXDMCS", "DXDMCS", JdeDataType.Numeric),
        new JdeField("DXMCU", "DXMCU", JdeDataType.String, 24),
        new JdeField("DXSEQ", "DXSEQ", JdeDataType.Numeric),
        new JdeField("DXPSR", "DXPSR", JdeDataType.String, 24),
        new JdeField("DXPSRY", "DXPSRY", JdeDataType.String, 4),
        new JdeField("DXQCOM", "DXQCOM", JdeDataType.Numeric),
        new JdeField("DXCNQY", "DXCNQY", JdeDataType.String, 2),
        new JdeField("DXAA", "DXAA", JdeDataType.Numeric),
        new JdeField("DXCRCD", "DXCRCD", JdeDataType.String, 6),
        new JdeField("DXUOM", "DXUOM", JdeDataType.String, 4),
        new JdeField("DXTRDJ", "DXTRDJ", JdeDataType.Numeric),
        new JdeField("DXTV01", "DXTV01", JdeDataType.String, 2),
        new JdeField("DXTV02", "DXTV02", JdeDataType.String, 2),
        new JdeField("DXTV03", "DXTV03", JdeDataType.String, 2),
        new JdeField("DXURCD", "DXURCD", JdeDataType.String, 4),
        new JdeField("DXURDT", "DXURDT", JdeDataType.Numeric),
        new JdeField("DXURAB", "DXURAB", JdeDataType.Numeric),
        new JdeField("DXURRF", "DXURRF", JdeDataType.String, 30),
        new JdeField("DXUSER", "DXUSER", JdeDataType.String, 20),
        new JdeField("DXPID", "DXPID", JdeDataType.String, 20),
        new JdeField("DXJOBN", "DXJOBN", JdeDataType.String, 20),
        new JdeField("DXUPMJ", "DXUPMJ", JdeDataType.Numeric),
        new JdeField("DXTDAY", "DXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38112_0", "Primary Key on DXDOCO, DXDCTO, DXKCOO, DXLNID", new[] { "DXDOCO", "DXDCTO", "DXKCOO", "DXLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F38112_3", "Index on DXDMCT, DXDMCS, DXSEQ, DXPSR, DXPSRY, DXTRDJ", new[] { "DXDMCT", "DXDMCS", "DXSEQ", "DXPSR", "DXPSRY", "DXTRDJ" })
    };
}
