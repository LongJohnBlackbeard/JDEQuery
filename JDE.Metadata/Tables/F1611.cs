using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1611 - .
/// </summary>
public class F1611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTVWNM.
        /// </summary>
        public const string CTVWNM = "CTVWNM";

        /// <summary>
        /// CTASBN.
        /// </summary>
        public const string CTASBN = "CTASBN";

        /// <summary>
        /// CTASNM.
        /// </summary>
        public const string CTASNM = "CTASNM";

        /// <summary>
        /// CTSEQ.
        /// </summary>
        public const string CTSEQ = "CTSEQ";

        /// <summary>
        /// CTLNID.
        /// </summary>
        public const string CTLNID = "CTLNID";

        /// <summary>
        /// CTAA.
        /// </summary>
        public const string CTAA = "CTAA";

        /// <summary>
        /// CTANOG.
        /// </summary>
        public const string CTANOG = "CTANOG";

        /// <summary>
        /// CTRFAC.
        /// </summary>
        public const string CTRFAC = "CTRFAC";

        /// <summary>
        /// CTACTB.
        /// </summary>
        public const string CTACTB = "CTACTB";

        /// <summary>
        /// CTAID.
        /// </summary>
        public const string CTAID = "CTAID";

        /// <summary>
        /// CTDRCD.
        /// </summary>
        public const string CTDRCD = "CTDRCD";

        /// <summary>
        /// CTCFY.
        /// </summary>
        public const string CTCFY = "CTCFY";

        /// <summary>
        /// CTPN.
        /// </summary>
        public const string CTPN = "CTPN";

        /// <summary>
        /// CTLT.
        /// </summary>
        public const string CTLT = "CTLT";

        /// <summary>
        /// CTSBL.
        /// </summary>
        public const string CTSBL = "CTSBL";

        /// <summary>
        /// CTSBLT.
        /// </summary>
        public const string CTSBLT = "CTSBLT";

        /// <summary>
        /// CTABR1.
        /// </summary>
        public const string CTABR1 = "CTABR1";

        /// <summary>
        /// CTABT1.
        /// </summary>
        public const string CTABT1 = "CTABT1";

        /// <summary>
        /// CTABR2.
        /// </summary>
        public const string CTABR2 = "CTABR2";

        /// <summary>
        /// CTABT2.
        /// </summary>
        public const string CTABT2 = "CTABT2";

        /// <summary>
        /// CTABR3.
        /// </summary>
        public const string CTABR3 = "CTABR3";

        /// <summary>
        /// CTABT3.
        /// </summary>
        public const string CTABT3 = "CTABT3";

        /// <summary>
        /// CTABR4.
        /// </summary>
        public const string CTABR4 = "CTABR4";

        /// <summary>
        /// CTABT4.
        /// </summary>
        public const string CTABT4 = "CTABT4";

        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTTATB.
        /// </summary>
        public const string CTTATB = "CTTATB";

        /// <summary>
        /// CTTAID.
        /// </summary>
        public const string CTTAID = "CTTAID";

        /// <summary>
        /// CTTCFY.
        /// </summary>
        public const string CTTCFY = "CTTCFY";

        /// <summary>
        /// CTTPN.
        /// </summary>
        public const string CTTPN = "CTTPN";

        /// <summary>
        /// CTLTT.
        /// </summary>
        public const string CTLTT = "CTLTT";

        /// <summary>
        /// CTTSB.
        /// </summary>
        public const string CTTSB = "CTTSB";

        /// <summary>
        /// CTTSBT.
        /// </summary>
        public const string CTTSBT = "CTTSBT";

        /// <summary>
        /// CTTAB1.
        /// </summary>
        public const string CTTAB1 = "CTTAB1";

        /// <summary>
        /// CTTAT1.
        /// </summary>
        public const string CTTAT1 = "CTTAT1";

        /// <summary>
        /// CTTAB2.
        /// </summary>
        public const string CTTAB2 = "CTTAB2";

        /// <summary>
        /// CTTAT2.
        /// </summary>
        public const string CTTAT2 = "CTTAT2";

        /// <summary>
        /// CTTAB3.
        /// </summary>
        public const string CTTAB3 = "CTTAB3";

        /// <summary>
        /// CTTAT3.
        /// </summary>
        public const string CTTAT3 = "CTTAT3";

        /// <summary>
        /// CTTAB4.
        /// </summary>
        public const string CTTAB4 = "CTTAB4";

        /// <summary>
        /// CTTAT4.
        /// </summary>
        public const string CTTAT4 = "CTTAT4";

        /// <summary>
        /// CTTITM.
        /// </summary>
        public const string CTTITM = "CTTITM";

        /// <summary>
        /// CTCRCX.
        /// </summary>
        public const string CTCRCX = "CTCRCX";

        /// <summary>
        /// CTRHID.
        /// </summary>
        public const string CTRHID = "CTRHID";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTVWNM", "CTVWNM", JdeDataType.Numeric, null, true, true),
        new JdeField("CTASBN", "CTASBN", JdeDataType.Numeric, null, true, true),
        new JdeField("CTASNM", "CTASNM", JdeDataType.Numeric, null, true, true),
        new JdeField("CTSEQ", "CTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTLNID", "CTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTAA", "CTAA", JdeDataType.Numeric),
        new JdeField("CTANOG", "CTANOG", JdeDataType.Numeric),
        new JdeField("CTRFAC", "CTRFAC", JdeDataType.Numeric),
        new JdeField("CTACTB", "CTACTB", JdeDataType.String, 20),
        new JdeField("CTAID", "CTAID", JdeDataType.String, 16),
        new JdeField("CTDRCD", "CTDRCD", JdeDataType.String, 20),
        new JdeField("CTCFY", "CTCFY", JdeDataType.Numeric),
        new JdeField("CTPN", "CTPN", JdeDataType.Numeric),
        new JdeField("CTLT", "CTLT", JdeDataType.String, 4),
        new JdeField("CTSBL", "CTSBL", JdeDataType.String, 16),
        new JdeField("CTSBLT", "CTSBLT", JdeDataType.String, 2),
        new JdeField("CTABR1", "CTABR1", JdeDataType.String, 24),
        new JdeField("CTABT1", "CTABT1", JdeDataType.String, 2),
        new JdeField("CTABR2", "CTABR2", JdeDataType.String, 24),
        new JdeField("CTABT2", "CTABT2", JdeDataType.String, 2),
        new JdeField("CTABR3", "CTABR3", JdeDataType.String, 24),
        new JdeField("CTABT3", "CTABT3", JdeDataType.String, 2),
        new JdeField("CTABR4", "CTABR4", JdeDataType.String, 24),
        new JdeField("CTABT4", "CTABT4", JdeDataType.String, 2),
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric),
        new JdeField("CTTATB", "CTTATB", JdeDataType.String, 20),
        new JdeField("CTTAID", "CTTAID", JdeDataType.String, 16),
        new JdeField("CTTCFY", "CTTCFY", JdeDataType.Numeric),
        new JdeField("CTTPN", "CTTPN", JdeDataType.Numeric),
        new JdeField("CTLTT", "CTLTT", JdeDataType.String, 4),
        new JdeField("CTTSB", "CTTSB", JdeDataType.String, 16),
        new JdeField("CTTSBT", "CTTSBT", JdeDataType.String, 2),
        new JdeField("CTTAB1", "CTTAB1", JdeDataType.String, 24),
        new JdeField("CTTAT1", "CTTAT1", JdeDataType.String, 2),
        new JdeField("CTTAB2", "CTTAB2", JdeDataType.String, 24),
        new JdeField("CTTAT2", "CTTAT2", JdeDataType.String, 2),
        new JdeField("CTTAB3", "CTTAB3", JdeDataType.String, 24),
        new JdeField("CTTAT3", "CTTAT3", JdeDataType.String, 2),
        new JdeField("CTTAB4", "CTTAB4", JdeDataType.String, 24),
        new JdeField("CTTAT4", "CTTAT4", JdeDataType.String, 2),
        new JdeField("CTTITM", "CTTITM", JdeDataType.Numeric),
        new JdeField("CTCRCX", "CTCRCX", JdeDataType.String, 6),
        new JdeField("CTRHID", "CTRHID", JdeDataType.Numeric),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1611_0", "Primary Key on CTVWNM, CTASBN, CTASNM, CTSEQ, CTLNID", new[] { "CTVWNM", "CTASBN", "CTASNM", "CTSEQ", "CTLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1611_2", "Index on CTVWNM, CTTCFY", new[] { "CTVWNM", "CTTCFY" })
    };
}
