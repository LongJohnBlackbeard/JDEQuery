using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I320Y - .
/// </summary>
public class F75I320Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QBKCO.
        /// </summary>
        public const string QBKCO = "QBKCO";

        /// <summary>
        /// QBDOC.
        /// </summary>
        public const string QBDOC = "QBDOC";

        /// <summary>
        /// QBLNID.
        /// </summary>
        public const string QBLNID = "QBLNID";

        /// <summary>
        /// QBDCT.
        /// </summary>
        public const string QBDCT = "QBDCT";

        /// <summary>
        /// QBIVD.
        /// </summary>
        public const string QBIVD = "QBIVD";

        /// <summary>
        /// QBKCOO.
        /// </summary>
        public const string QBKCOO = "QBKCOO";

        /// <summary>
        /// QBDOCO.
        /// </summary>
        public const string QBDOCO = "QBDOCO";

        /// <summary>
        /// QBDCTO.
        /// </summary>
        public const string QBDCTO = "QBDCTO";

        /// <summary>
        /// QBDTPD.
        /// </summary>
        public const string QBDTPD = "QBDTPD";

        /// <summary>
        /// QBAN8.
        /// </summary>
        public const string QBAN8 = "QBAN8";

        /// <summary>
        /// QBYEXU.
        /// </summary>
        public const string QBYEXU = "QBYEXU";

        /// <summary>
        /// QBYNXP.
        /// </summary>
        public const string QBYNXP = "QBYNXP";

        /// <summary>
        /// QBYDTP.
        /// </summary>
        public const string QBYDTP = "QBYDTP";

        /// <summary>
        /// QBYPDR.
        /// </summary>
        public const string QBYPDR = "QBYPDR";

        /// <summary>
        /// QBYNXE.
        /// </summary>
        public const string QBYNXE = "QBYNXE";

        /// <summary>
        /// QBYDTA.
        /// </summary>
        public const string QBYDTA = "QBYDTA";

        /// <summary>
        /// QBYDEA.
        /// </summary>
        public const string QBYDEA = "QBYDEA";

        /// <summary>
        /// QBYCXP.
        /// </summary>
        public const string QBYCXP = "QBYCXP";

        /// <summary>
        /// QBYDTC.
        /// </summary>
        public const string QBYDTC = "QBYDTC";

        /// <summary>
        /// QBYDEB.
        /// </summary>
        public const string QBYDEB = "QBYDEB";

        /// <summary>
        /// QBI75BED.
        /// </summary>
        public const string QBI75BED = "QBI75BED";

        /// <summary>
        /// QBI75CESS.
        /// </summary>
        public const string QBI75CESS = "QBI75CESS";

        /// <summary>
        /// QBI75CCS.
        /// </summary>
        public const string QBI75CCS = "QBI75CCS";

        /// <summary>
        /// QBI75CVD.
        /// </summary>
        public const string QBI75CVD = "QBI75CVD";

        /// <summary>
        /// QBI75AED.
        /// </summary>
        public const string QBI75AED = "QBI75AED";

        /// <summary>
        /// QBI75FTX2.
        /// </summary>
        public const string QBI75FTX2 = "QBI75FTX2";

        /// <summary>
        /// QBI75FTX1.
        /// </summary>
        public const string QBI75FTX1 = "QBI75FTX1";

        /// <summary>
        /// QBI75SED.
        /// </summary>
        public const string QBI75SED = "QBI75SED";

        /// <summary>
        /// QBYTNM.
        /// </summary>
        public const string QBYTNM = "QBYTNM";

        /// <summary>
        /// QBMOT.
        /// </summary>
        public const string QBMOT = "QBMOT";

        /// <summary>
        /// QBYVRN.
        /// </summary>
        public const string QBYVRN = "QBYVRN";

        /// <summary>
        /// QBYCNN.
        /// </summary>
        public const string QBYCNN = "QBYCNN";

        /// <summary>
        /// QBTNST.
        /// </summary>
        public const string QBTNST = "QBTNST";

        /// <summary>
        /// QBYPKG.
        /// </summary>
        public const string QBYPKG = "QBYPKG";

        /// <summary>
        /// QBRDJ.
        /// </summary>
        public const string QBRDJ = "QBRDJ";

        /// <summary>
        /// QBRDT.
        /// </summary>
        public const string QBRDT = "QBRDT";

        /// <summary>
        /// QBRMK.
        /// </summary>
        public const string QBRMK = "QBRMK";

        /// <summary>
        /// QBREMK.
        /// </summary>
        public const string QBREMK = "QBREMK";

        /// <summary>
        /// QBYC2BEDDR.
        /// </summary>
        public const string QBYC2BEDDR = "QBYC2BEDDR";

        /// <summary>
        /// QBYC2SEDDR.
        /// </summary>
        public const string QBYC2SEDDR = "QBYC2SEDDR";

        /// <summary>
        /// QBYC2AEDDR.
        /// </summary>
        public const string QBYC2AEDDR = "QBYC2AEDDR";

        /// <summary>
        /// QBYC2NCDDR.
        /// </summary>
        public const string QBYC2NCDDR = "QBYC2NCDDR";

        /// <summary>
        /// QBYA2BEDDR.
        /// </summary>
        public const string QBYA2BEDDR = "QBYA2BEDDR";

        /// <summary>
        /// QBYA2SEDDR.
        /// </summary>
        public const string QBYA2SEDDR = "QBYA2SEDDR";

        /// <summary>
        /// QBYA2AEDDR.
        /// </summary>
        public const string QBYA2AEDDR = "QBYA2AEDDR";

        /// <summary>
        /// QBYA2NCDDR.
        /// </summary>
        public const string QBYA2NCDDR = "QBYA2NCDDR";

        /// <summary>
        /// QBYPLBEDDR.
        /// </summary>
        public const string QBYPLBEDDR = "QBYPLBEDDR";

        /// <summary>
        /// QBYPLSEDDR.
        /// </summary>
        public const string QBYPLSEDDR = "QBYPLSEDDR";

        /// <summary>
        /// QBYPLNCDDR.
        /// </summary>
        public const string QBYPLNCDDR = "QBYPLNCDDR";

        /// <summary>
        /// QBYPLAEDDR.
        /// </summary>
        public const string QBYPLAEDDR = "QBYPLAEDDR";

        /// <summary>
        /// QBJOBN.
        /// </summary>
        public const string QBJOBN = "QBJOBN";

        /// <summary>
        /// QBUPMJ.
        /// </summary>
        public const string QBUPMJ = "QBUPMJ";

        /// <summary>
        /// QBPID.
        /// </summary>
        public const string QBPID = "QBPID";

        /// <summary>
        /// QBTDAY.
        /// </summary>
        public const string QBTDAY = "QBTDAY";

        /// <summary>
        /// QBUSER.
        /// </summary>
        public const string QBUSER = "QBUSER";

        /// <summary>
        /// QBTORG.
        /// </summary>
        public const string QBTORG = "QBTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I320Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QBKCO", "QBKCO", JdeDataType.String, 10, true, true),
        new JdeField("QBDOC", "QBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("QBLNID", "QBLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QBDCT", "QBDCT", JdeDataType.String, 4, true, true),
        new JdeField("QBIVD", "QBIVD", JdeDataType.Numeric),
        new JdeField("QBKCOO", "QBKCOO", JdeDataType.String, 10),
        new JdeField("QBDOCO", "QBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("QBDCTO", "QBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("QBDTPD", "QBDTPD", JdeDataType.Numeric),
        new JdeField("QBAN8", "QBAN8", JdeDataType.Numeric),
        new JdeField("QBYEXU", "QBYEXU", JdeDataType.Numeric),
        new JdeField("QBYNXP", "QBYNXP", JdeDataType.Numeric),
        new JdeField("QBYDTP", "QBYDTP", JdeDataType.Numeric),
        new JdeField("QBYPDR", "QBYPDR", JdeDataType.Numeric),
        new JdeField("QBYNXE", "QBYNXE", JdeDataType.Numeric),
        new JdeField("QBYDTA", "QBYDTA", JdeDataType.Numeric),
        new JdeField("QBYDEA", "QBYDEA", JdeDataType.Numeric),
        new JdeField("QBYCXP", "QBYCXP", JdeDataType.Numeric),
        new JdeField("QBYDTC", "QBYDTC", JdeDataType.Numeric),
        new JdeField("QBYDEB", "QBYDEB", JdeDataType.Numeric),
        new JdeField("QBI75BED", "QBI75BED", JdeDataType.Numeric),
        new JdeField("QBI75CESS", "QBI75CESS", JdeDataType.Numeric),
        new JdeField("QBI75CCS", "QBI75CCS", JdeDataType.Numeric),
        new JdeField("QBI75CVD", "QBI75CVD", JdeDataType.Numeric),
        new JdeField("QBI75AED", "QBI75AED", JdeDataType.Numeric),
        new JdeField("QBI75FTX2", "QBI75FTX2", JdeDataType.Numeric),
        new JdeField("QBI75FTX1", "QBI75FTX1", JdeDataType.Numeric),
        new JdeField("QBI75SED", "QBI75SED", JdeDataType.Numeric),
        new JdeField("QBYTNM", "QBYTNM", JdeDataType.Numeric),
        new JdeField("QBMOT", "QBMOT", JdeDataType.String, 6),
        new JdeField("QBYVRN", "QBYVRN", JdeDataType.String, 36),
        new JdeField("QBYCNN", "QBYCNN", JdeDataType.String, 30),
        new JdeField("QBTNST", "QBTNST", JdeDataType.String, 40),
        new JdeField("QBYPKG", "QBYPKG", JdeDataType.Numeric),
        new JdeField("QBRDJ", "QBRDJ", JdeDataType.Numeric),
        new JdeField("QBRDT", "QBRDT", JdeDataType.Numeric),
        new JdeField("QBRMK", "QBRMK", JdeDataType.String, 60),
        new JdeField("QBREMK", "QBREMK", JdeDataType.String, 60),
        new JdeField("QBYC2BEDDR", "QBYC2BEDDR", JdeDataType.Numeric),
        new JdeField("QBYC2SEDDR", "QBYC2SEDDR", JdeDataType.Numeric),
        new JdeField("QBYC2AEDDR", "QBYC2AEDDR", JdeDataType.Numeric),
        new JdeField("QBYC2NCDDR", "QBYC2NCDDR", JdeDataType.Numeric),
        new JdeField("QBYA2BEDDR", "QBYA2BEDDR", JdeDataType.Numeric),
        new JdeField("QBYA2SEDDR", "QBYA2SEDDR", JdeDataType.Numeric),
        new JdeField("QBYA2AEDDR", "QBYA2AEDDR", JdeDataType.Numeric),
        new JdeField("QBYA2NCDDR", "QBYA2NCDDR", JdeDataType.Numeric),
        new JdeField("QBYPLBEDDR", "QBYPLBEDDR", JdeDataType.Numeric),
        new JdeField("QBYPLSEDDR", "QBYPLSEDDR", JdeDataType.Numeric),
        new JdeField("QBYPLNCDDR", "QBYPLNCDDR", JdeDataType.Numeric),
        new JdeField("QBYPLAEDDR", "QBYPLAEDDR", JdeDataType.Numeric),
        new JdeField("QBJOBN", "QBJOBN", JdeDataType.String, 20),
        new JdeField("QBUPMJ", "QBUPMJ", JdeDataType.Numeric),
        new JdeField("QBPID", "QBPID", JdeDataType.String, 20),
        new JdeField("QBTDAY", "QBTDAY", JdeDataType.Numeric),
        new JdeField("QBUSER", "QBUSER", JdeDataType.String, 20),
        new JdeField("QBTORG", "QBTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I320Y_0", "Primary Key on QBKCO, QBDCT, QBDOC, QBLNID, QBDOCO, QBDCTO", new[] { "QBKCO", "QBDCT", "QBDOC", "QBLNID", "QBDOCO", "QBDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
