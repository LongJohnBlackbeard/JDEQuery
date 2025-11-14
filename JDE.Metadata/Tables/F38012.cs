using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38012 - .
/// </summary>
public class F38012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPDMCT.
        /// </summary>
        public const string DPDMCT = "DPDMCT";

        /// <summary>
        /// DPDMCS.
        /// </summary>
        public const string DPDMCS = "DPDMCS";

        /// <summary>
        /// DPITM.
        /// </summary>
        public const string DPITM = "DPITM";

        /// <summary>
        /// DPDTO.
        /// </summary>
        public const string DPDTO = "DPDTO";

        /// <summary>
        /// DPDES.
        /// </summary>
        public const string DPDES = "DPDES";

        /// <summary>
        /// DPDESY.
        /// </summary>
        public const string DPDESY = "DPDESY";

        /// <summary>
        /// DPSEQ.
        /// </summary>
        public const string DPSEQ = "DPSEQ";

        /// <summary>
        /// DPPSR.
        /// </summary>
        public const string DPPSR = "DPPSR";

        /// <summary>
        /// DPPSRY.
        /// </summary>
        public const string DPPSRY = "DPPSRY";

        /// <summary>
        /// DPCNQY.
        /// </summary>
        public const string DPCNQY = "DPCNQY";

        /// <summary>
        /// DPCNQT.
        /// </summary>
        public const string DPCNQT = "DPCNQT";

        /// <summary>
        /// DPAA.
        /// </summary>
        public const string DPAA = "DPAA";

        /// <summary>
        /// DPCRCD.
        /// </summary>
        public const string DPCRCD = "DPCRCD";

        /// <summary>
        /// DPUOM.
        /// </summary>
        public const string DPUOM = "DPUOM";

        /// <summary>
        /// DPMINQ.
        /// </summary>
        public const string DPMINQ = "DPMINQ";

        /// <summary>
        /// DPMAXQ.
        /// </summary>
        public const string DPMAXQ = "DPMAXQ";

        /// <summary>
        /// DPQBAL.
        /// </summary>
        public const string DPQBAL = "DPQBAL";

        /// <summary>
        /// DPQCOM.
        /// </summary>
        public const string DPQCOM = "DPQCOM";

        /// <summary>
        /// DPEFTJ.
        /// </summary>
        public const string DPEFTJ = "DPEFTJ";

        /// <summary>
        /// DPEXDJ.
        /// </summary>
        public const string DPEXDJ = "DPEXDJ";

        /// <summary>
        /// DPTV01.
        /// </summary>
        public const string DPTV01 = "DPTV01";

        /// <summary>
        /// DPTV02.
        /// </summary>
        public const string DPTV02 = "DPTV02";

        /// <summary>
        /// DPTV03.
        /// </summary>
        public const string DPTV03 = "DPTV03";

        /// <summary>
        /// DPQTY1.
        /// </summary>
        public const string DPQTY1 = "DPQTY1";

        /// <summary>
        /// DPTVUM.
        /// </summary>
        public const string DPTVUM = "DPTVUM";

        /// <summary>
        /// DPURCD.
        /// </summary>
        public const string DPURCD = "DPURCD";

        /// <summary>
        /// DPURDT.
        /// </summary>
        public const string DPURDT = "DPURDT";

        /// <summary>
        /// DPURAB.
        /// </summary>
        public const string DPURAB = "DPURAB";

        /// <summary>
        /// DPURRF.
        /// </summary>
        public const string DPURRF = "DPURRF";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPTDAY.
        /// </summary>
        public const string DPTDAY = "DPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F38012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPDMCT", "DPDMCT", JdeDataType.String, 24, true, true),
        new JdeField("DPDMCS", "DPDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("DPITM", "DPITM", JdeDataType.Numeric),
        new JdeField("DPDTO", "DPDTO", JdeDataType.String, 2),
        new JdeField("DPDES", "DPDES", JdeDataType.String, 24),
        new JdeField("DPDESY", "DPDESY", JdeDataType.String, 4),
        new JdeField("DPSEQ", "DPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DPPSR", "DPPSR", JdeDataType.String, 24, true, true),
        new JdeField("DPPSRY", "DPPSRY", JdeDataType.String, 4, true, true),
        new JdeField("DPCNQY", "DPCNQY", JdeDataType.String, 2),
        new JdeField("DPCNQT", "DPCNQT", JdeDataType.Numeric),
        new JdeField("DPAA", "DPAA", JdeDataType.Numeric),
        new JdeField("DPCRCD", "DPCRCD", JdeDataType.String, 6),
        new JdeField("DPUOM", "DPUOM", JdeDataType.String, 4),
        new JdeField("DPMINQ", "DPMINQ", JdeDataType.Numeric),
        new JdeField("DPMAXQ", "DPMAXQ", JdeDataType.Numeric),
        new JdeField("DPQBAL", "DPQBAL", JdeDataType.Numeric),
        new JdeField("DPQCOM", "DPQCOM", JdeDataType.Numeric),
        new JdeField("DPEFTJ", "DPEFTJ", JdeDataType.Numeric),
        new JdeField("DPEXDJ", "DPEXDJ", JdeDataType.Numeric),
        new JdeField("DPTV01", "DPTV01", JdeDataType.String, 2),
        new JdeField("DPTV02", "DPTV02", JdeDataType.String, 2),
        new JdeField("DPTV03", "DPTV03", JdeDataType.String, 2),
        new JdeField("DPQTY1", "DPQTY1", JdeDataType.Numeric),
        new JdeField("DPTVUM", "DPTVUM", JdeDataType.String, 4),
        new JdeField("DPURCD", "DPURCD", JdeDataType.String, 4),
        new JdeField("DPURDT", "DPURDT", JdeDataType.Numeric),
        new JdeField("DPURAB", "DPURAB", JdeDataType.Numeric),
        new JdeField("DPURRF", "DPURRF", JdeDataType.String, 30),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPTDAY", "DPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38012_0", "Primary Key on DPDMCT, DPDMCS, DPSEQ, DPPSR, DPPSRY", new[] { "DPDMCT", "DPDMCS", "DPSEQ", "DPPSR", "DPPSRY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F38012_2", "Index on SYS_NC00035$, DPDMCT, DPDMCS, DPSEQ, DPPSRY, DPPSR", new[] { "SYS_NC00035$", "DPDMCT", "DPDMCS", "DPSEQ", "DPPSRY", "DPPSR" })
    };
}
