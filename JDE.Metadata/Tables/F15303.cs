using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15303 - .
/// </summary>
public class F15303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHICU.
        /// </summary>
        public const string CHICU = "CHICU";

        /// <summary>
        /// CHCAPID.
        /// </summary>
        public const string CHCAPID = "CHCAPID";

        /// <summary>
        /// CHEPCL.
        /// </summary>
        public const string CHEPCL = "CHEPCL";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHOBJ.
        /// </summary>
        public const string CHOBJ = "CHOBJ";

        /// <summary>
        /// CHSUB.
        /// </summary>
        public const string CHSUB = "CHSUB";

        /// <summary>
        /// CHSBL.
        /// </summary>
        public const string CHSBL = "CHSBL";

        /// <summary>
        /// CHSBLT.
        /// </summary>
        public const string CHSBLT = "CHSBLT";

        /// <summary>
        /// CHACTEXP.
        /// </summary>
        public const string CHACTEXP = "CHACTEXP";

        /// <summary>
        /// CHALWEXP.
        /// </summary>
        public const string CHALWEXP = "CHALWEXP";

        /// <summary>
        /// CHCAPPCT.
        /// </summary>
        public const string CHCAPPCT = "CHCAPPCT";

        /// <summary>
        /// CHCENTYR.
        /// </summary>
        public const string CHCENTYR = "CHCENTYR";

        /// <summary>
        /// CHGENT.
        /// </summary>
        public const string CHGENT = "CHGENT";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHMKEY.
        /// </summary>
        public const string CHMKEY = "CHMKEY";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHTORG.
        /// </summary>
        public const string CHTORG = "CHTORG";

        /// <summary>
        /// CHENTJ.
        /// </summary>
        public const string CHENTJ = "CHENTJ";

        /// <summary>
        /// CHRFRECC.
        /// </summary>
        public const string CHRFRECC = "CHRFRECC";

        /// <summary>
        /// CHCAPADJC.
        /// </summary>
        public const string CHCAPADJC = "CHCAPADJC";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHRFRECB.
        /// </summary>
        public const string CHRFRECB = "CHRFRECB";

        /// <summary>
        /// CHCAPPROF.
        /// </summary>
        public const string CHCAPPROF = "CHCAPPROF";

        /// <summary>
        /// CHFNLAMT.
        /// </summary>
        public const string CHFNLAMT = "CHFNLAMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHICU", "CHICU", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCAPID", "CHCAPID", JdeDataType.String, 20, true, true),
        new JdeField("CHEPCL", "CHEPCL", JdeDataType.String, 8, true, true),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24, true, true),
        new JdeField("CHOBJ", "CHOBJ", JdeDataType.String, 12, true, true),
        new JdeField("CHSUB", "CHSUB", JdeDataType.String, 16, true, true),
        new JdeField("CHSBL", "CHSBL", JdeDataType.String, 16, true, true),
        new JdeField("CHSBLT", "CHSBLT", JdeDataType.String, 2, true, true),
        new JdeField("CHACTEXP", "CHACTEXP", JdeDataType.Numeric),
        new JdeField("CHALWEXP", "CHALWEXP", JdeDataType.Numeric),
        new JdeField("CHCAPPCT", "CHCAPPCT", JdeDataType.Numeric),
        new JdeField("CHCENTYR", "CHCENTYR", JdeDataType.Numeric),
        new JdeField("CHGENT", "CHGENT", JdeDataType.String, 2),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHMKEY", "CHMKEY", JdeDataType.String, 30),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHTORG", "CHTORG", JdeDataType.String, 20),
        new JdeField("CHENTJ", "CHENTJ", JdeDataType.Numeric),
        new JdeField("CHRFRECC", "CHRFRECC", JdeDataType.Numeric),
        new JdeField("CHCAPADJC", "CHCAPADJC", JdeDataType.Numeric),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHRFRECB", "CHRFRECB", JdeDataType.Numeric),
        new JdeField("CHCAPPROF", "CHCAPPROF", JdeDataType.Numeric),
        new JdeField("CHFNLAMT", "CHFNLAMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15303_0", "Primary Key on CHICU, CHCAPID, CHEPCL, CHMCU, CHOBJ, CHSUB, CHSBL, CHSBLT", new[] { "CHICU", "CHCAPID", "CHEPCL", "CHMCU", "CHOBJ", "CHSUB", "CHSBL", "CHSBLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15303_2", "Index on CHCAPID, CHEPCL, CHMCU, CHGENT, CHCENTYR", new[] { "CHCAPID", "CHEPCL", "CHMCU", "CHGENT", "CHCENTYR" })
    };
}
