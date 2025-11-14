using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0010 - .
/// </summary>
public class F0010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCNAME.
        /// </summary>
        public const string CCNAME = "CCNAME";

        /// <summary>
        /// CCALTC.
        /// </summary>
        public const string CCALTC = "CCALTC";

        /// <summary>
        /// CCDFYJ.
        /// </summary>
        public const string CCDFYJ = "CCDFYJ";

        /// <summary>
        /// CCPNC.
        /// </summary>
        public const string CCPNC = "CCPNC";

        /// <summary>
        /// CCDOT1.
        /// </summary>
        public const string CCDOT1 = "CCDOT1";

        /// <summary>
        /// CCCRYR.
        /// </summary>
        public const string CCCRYR = "CCCRYR";

        /// <summary>
        /// CCCRYC.
        /// </summary>
        public const string CCCRYC = "CCCRYC";

        /// <summary>
        /// CCDOT2.
        /// </summary>
        public const string CCDOT2 = "CCDOT2";

        /// <summary>
        /// CCMCUA.
        /// </summary>
        public const string CCMCUA = "CCMCUA";

        /// <summary>
        /// CCMCUD.
        /// </summary>
        public const string CCMCUD = "CCMCUD";

        /// <summary>
        /// CCMCUC.
        /// </summary>
        public const string CCMCUC = "CCMCUC";

        /// <summary>
        /// CCMCUB.
        /// </summary>
        public const string CCMCUB = "CCMCUB";

        /// <summary>
        /// CCDPRC.
        /// </summary>
        public const string CCDPRC = "CCDPRC";

        /// <summary>
        /// CCBKTX.
        /// </summary>
        public const string CCBKTX = "CCBKTX";

        /// <summary>
        /// CCTXBM.
        /// </summary>
        public const string CCTXBM = "CCTXBM";

        /// <summary>
        /// CCTXBO.
        /// </summary>
        public const string CCTXBO = "CCTXBO";

        /// <summary>
        /// CCNWXJ.
        /// </summary>
        public const string CCNWXJ = "CCNWXJ";

        /// <summary>
        /// CCGLIE.
        /// </summary>
        public const string CCGLIE = "CCGLIE";

        /// <summary>
        /// CCABIN.
        /// </summary>
        public const string CCABIN = "CCABIN";

        /// <summary>
        /// CCCALD.
        /// </summary>
        public const string CCCALD = "CCCALD";

        /// <summary>
        /// CCDTPN.
        /// </summary>
        public const string CCDTPN = "CCDTPN";

        /// <summary>
        /// CCPNF.
        /// </summary>
        public const string CCPNF = "CCPNF";

        /// <summary>
        /// CCDFF.
        /// </summary>
        public const string CCDFF = "CCDFF";

        /// <summary>
        /// CCCRCD.
        /// </summary>
        public const string CCCRCD = "CCCRCD";

        /// <summary>
        /// CCSMI.
        /// </summary>
        public const string CCSMI = "CCSMI";

        /// <summary>
        /// CCSMU.
        /// </summary>
        public const string CCSMU = "CCSMU";

        /// <summary>
        /// CCSMS.
        /// </summary>
        public const string CCSMS = "CCSMS";

        /// <summary>
        /// CCDNLT.
        /// </summary>
        public const string CCDNLT = "CCDNLT";

        /// <summary>
        /// CCSTMT.
        /// </summary>
        public const string CCSTMT = "CCSTMT";

        /// <summary>
        /// CCATCS.
        /// </summary>
        public const string CCATCS = "CCATCS";

        /// <summary>
        /// CCALGM.
        /// </summary>
        public const string CCALGM = "CCALGM";

        /// <summary>
        /// CCAGEM.
        /// </summary>
        public const string CCAGEM = "CCAGEM";

        /// <summary>
        /// CCCRDY.
        /// </summary>
        public const string CCCRDY = "CCCRDY";

        /// <summary>
        /// CCAGR1.
        /// </summary>
        public const string CCAGR1 = "CCAGR1";

        /// <summary>
        /// CCAGR2.
        /// </summary>
        public const string CCAGR2 = "CCAGR2";

        /// <summary>
        /// CCAGR3.
        /// </summary>
        public const string CCAGR3 = "CCAGR3";

        /// <summary>
        /// CCAGR4.
        /// </summary>
        public const string CCAGR4 = "CCAGR4";

        /// <summary>
        /// CCAGR5.
        /// </summary>
        public const string CCAGR5 = "CCAGR5";

        /// <summary>
        /// CCAGR6.
        /// </summary>
        public const string CCAGR6 = "CCAGR6";

        /// <summary>
        /// CCAGR7.
        /// </summary>
        public const string CCAGR7 = "CCAGR7";

        /// <summary>
        /// CCFRY.
        /// </summary>
        public const string CCFRY = "CCFRY";

        /// <summary>
        /// CCFRP.
        /// </summary>
        public const string CCFRP = "CCFRP";

        /// <summary>
        /// CCNNP.
        /// </summary>
        public const string CCNNP = "CCNNP";

        /// <summary>
        /// CCFP.
        /// </summary>
        public const string CCFP = "CCFP";

        /// <summary>
        /// CCAGE.
        /// </summary>
        public const string CCAGE = "CCAGE";

        /// <summary>
        /// CCDAG.
        /// </summary>
        public const string CCDAG = "CCDAG";

        /// <summary>
        /// CCARPN.
        /// </summary>
        public const string CCARPN = "CCARPN";

        /// <summary>
        /// CCAPPN.
        /// </summary>
        public const string CCAPPN = "CCAPPN";

        /// <summary>
        /// CCARFJ.
        /// </summary>
        public const string CCARFJ = "CCARFJ";

        /// <summary>
        /// CCAPFJ.
        /// </summary>
        public const string CCAPFJ = "CCAPFJ";

        /// <summary>
        /// CCAN8.
        /// </summary>
        public const string CCAN8 = "CCAN8";

        /// <summary>
        /// CCSGBK.
        /// </summary>
        public const string CCSGBK = "CCSGBK";

        /// <summary>
        /// CCPTCO.
        /// </summary>
        public const string CCPTCO = "CCPTCO";

        /// <summary>
        /// CCX1.
        /// </summary>
        public const string CCX1 = "CCX1";

        /// <summary>
        /// CCX2.
        /// </summary>
        public const string CCX2 = "CCX2";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCTSID.
        /// </summary>
        public const string CCTSID = "CCTSID";

        /// <summary>
        /// CCTSCO.
        /// </summary>
        public const string CCTSCO = "CCTSCO";

        /// <summary>
        /// CCTHCO.
        /// </summary>
        public const string CCTHCO = "CCTHCO";

        /// <summary>
        /// CCAN8C.
        /// </summary>
        public const string CCAN8C = "CCAN8C";
    }

    /// <inheritdoc />
    public override string TableName => "F0010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCNAME", "CCNAME", JdeDataType.String, 60),
        new JdeField("CCALTC", "CCALTC", JdeDataType.String, 80),
        new JdeField("CCDFYJ", "CCDFYJ", JdeDataType.Numeric),
        new JdeField("CCPNC", "CCPNC", JdeDataType.Numeric),
        new JdeField("CCDOT1", "CCDOT1", JdeDataType.String, 2),
        new JdeField("CCCRYR", "CCCRYR", JdeDataType.String, 2),
        new JdeField("CCCRYC", "CCCRYC", JdeDataType.String, 2),
        new JdeField("CCDOT2", "CCDOT2", JdeDataType.String, 2),
        new JdeField("CCMCUA", "CCMCUA", JdeDataType.String, 2),
        new JdeField("CCMCUD", "CCMCUD", JdeDataType.String, 2),
        new JdeField("CCMCUC", "CCMCUC", JdeDataType.String, 2),
        new JdeField("CCMCUB", "CCMCUB", JdeDataType.String, 2),
        new JdeField("CCDPRC", "CCDPRC", JdeDataType.String, 2),
        new JdeField("CCBKTX", "CCBKTX", JdeDataType.String, 2),
        new JdeField("CCTXBM", "CCTXBM", JdeDataType.Numeric),
        new JdeField("CCTXBO", "CCTXBO", JdeDataType.Numeric),
        new JdeField("CCNWXJ", "CCNWXJ", JdeDataType.Numeric),
        new JdeField("CCGLIE", "CCGLIE", JdeDataType.String, 2),
        new JdeField("CCABIN", "CCABIN", JdeDataType.String, 2),
        new JdeField("CCCALD", "CCCALD", JdeDataType.String, 4),
        new JdeField("CCDTPN", "CCDTPN", JdeDataType.String, 2),
        new JdeField("CCPNF", "CCPNF", JdeDataType.Numeric),
        new JdeField("CCDFF", "CCDFF", JdeDataType.Numeric),
        new JdeField("CCCRCD", "CCCRCD", JdeDataType.String, 6),
        new JdeField("CCSMI", "CCSMI", JdeDataType.String, 2),
        new JdeField("CCSMU", "CCSMU", JdeDataType.String, 2),
        new JdeField("CCSMS", "CCSMS", JdeDataType.String, 2),
        new JdeField("CCDNLT", "CCDNLT", JdeDataType.String, 2),
        new JdeField("CCSTMT", "CCSTMT", JdeDataType.String, 2),
        new JdeField("CCATCS", "CCATCS", JdeDataType.String, 2),
        new JdeField("CCALGM", "CCALGM", JdeDataType.String, 4),
        new JdeField("CCAGEM", "CCAGEM", JdeDataType.String, 2),
        new JdeField("CCCRDY", "CCCRDY", JdeDataType.Numeric),
        new JdeField("CCAGR1", "CCAGR1", JdeDataType.Numeric),
        new JdeField("CCAGR2", "CCAGR2", JdeDataType.Numeric),
        new JdeField("CCAGR3", "CCAGR3", JdeDataType.Numeric),
        new JdeField("CCAGR4", "CCAGR4", JdeDataType.Numeric),
        new JdeField("CCAGR5", "CCAGR5", JdeDataType.Numeric),
        new JdeField("CCAGR6", "CCAGR6", JdeDataType.Numeric),
        new JdeField("CCAGR7", "CCAGR7", JdeDataType.Numeric),
        new JdeField("CCFRY", "CCFRY", JdeDataType.Numeric),
        new JdeField("CCFRP", "CCFRP", JdeDataType.Numeric),
        new JdeField("CCNNP", "CCNNP", JdeDataType.Numeric),
        new JdeField("CCFP", "CCFP", JdeDataType.Numeric),
        new JdeField("CCAGE", "CCAGE", JdeDataType.String, 2),
        new JdeField("CCDAG", "CCDAG", JdeDataType.Numeric),
        new JdeField("CCARPN", "CCARPN", JdeDataType.Numeric),
        new JdeField("CCAPPN", "CCAPPN", JdeDataType.Numeric),
        new JdeField("CCARFJ", "CCARFJ", JdeDataType.Numeric),
        new JdeField("CCAPFJ", "CCAPFJ", JdeDataType.Numeric),
        new JdeField("CCAN8", "CCAN8", JdeDataType.Numeric),
        new JdeField("CCSGBK", "CCSGBK", JdeDataType.String, 80),
        new JdeField("CCPTCO", "CCPTCO", JdeDataType.String, 2),
        new JdeField("CCX1", "CCX1", JdeDataType.String, 2),
        new JdeField("CCX2", "CCX2", JdeDataType.String, 2),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCTSID", "CCTSID", JdeDataType.Numeric),
        new JdeField("CCTSCO", "CCTSCO", JdeDataType.String, 10),
        new JdeField("CCTHCO", "CCTHCO", JdeDataType.String, 6),
        new JdeField("CCAN8C", "CCAN8C", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0010_0", "Primary Key on CCCO", new[] { "CCCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0010_2", "Index on CCDTPN, CCDFYJ", new[] { "CCDTPN", "CCDFYJ" }),
        new JdeIndex("F0010_3", "Index on CCAN8", new[] { "CCAN8" }),
        new JdeIndex("F0010_4", "Index on SYS_NC00066$", new[] { "SYS_NC00066$" }),
        new JdeIndex("F0010_5", "Index on CCNAME", new[] { "CCNAME" })
    };
}
