using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0010Z - .
/// </summary>
public class F0010Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZACTN.
        /// </summary>
        public const string SZACTN = "SZACTN";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZNAME.
        /// </summary>
        public const string SZNAME = "SZNAME";

        /// <summary>
        /// SZALTC.
        /// </summary>
        public const string SZALTC = "SZALTC";

        /// <summary>
        /// SZDFYJ.
        /// </summary>
        public const string SZDFYJ = "SZDFYJ";

        /// <summary>
        /// SZPNC.
        /// </summary>
        public const string SZPNC = "SZPNC";

        /// <summary>
        /// SZDOT1.
        /// </summary>
        public const string SZDOT1 = "SZDOT1";

        /// <summary>
        /// SZCRYR.
        /// </summary>
        public const string SZCRYR = "SZCRYR";

        /// <summary>
        /// SZCRYC.
        /// </summary>
        public const string SZCRYC = "SZCRYC";

        /// <summary>
        /// SZDOT2.
        /// </summary>
        public const string SZDOT2 = "SZDOT2";

        /// <summary>
        /// SZMCUA.
        /// </summary>
        public const string SZMCUA = "SZMCUA";

        /// <summary>
        /// SZMCUD.
        /// </summary>
        public const string SZMCUD = "SZMCUD";

        /// <summary>
        /// SZMCUC.
        /// </summary>
        public const string SZMCUC = "SZMCUC";

        /// <summary>
        /// SZMCUB.
        /// </summary>
        public const string SZMCUB = "SZMCUB";

        /// <summary>
        /// SZDPRC.
        /// </summary>
        public const string SZDPRC = "SZDPRC";

        /// <summary>
        /// SZBKTX.
        /// </summary>
        public const string SZBKTX = "SZBKTX";

        /// <summary>
        /// SZTXBM.
        /// </summary>
        public const string SZTXBM = "SZTXBM";

        /// <summary>
        /// SZTXBO.
        /// </summary>
        public const string SZTXBO = "SZTXBO";

        /// <summary>
        /// SZNWXJ.
        /// </summary>
        public const string SZNWXJ = "SZNWXJ";

        /// <summary>
        /// SZGLIE.
        /// </summary>
        public const string SZGLIE = "SZGLIE";

        /// <summary>
        /// SZABIN.
        /// </summary>
        public const string SZABIN = "SZABIN";

        /// <summary>
        /// SZCALD.
        /// </summary>
        public const string SZCALD = "SZCALD";

        /// <summary>
        /// SZDTPN.
        /// </summary>
        public const string SZDTPN = "SZDTPN";

        /// <summary>
        /// SZPNF.
        /// </summary>
        public const string SZPNF = "SZPNF";

        /// <summary>
        /// SZDFF.
        /// </summary>
        public const string SZDFF = "SZDFF";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZSMI.
        /// </summary>
        public const string SZSMI = "SZSMI";

        /// <summary>
        /// SZSMU.
        /// </summary>
        public const string SZSMU = "SZSMU";

        /// <summary>
        /// SZSMS.
        /// </summary>
        public const string SZSMS = "SZSMS";

        /// <summary>
        /// SZDNLT.
        /// </summary>
        public const string SZDNLT = "SZDNLT";

        /// <summary>
        /// SZSTMT.
        /// </summary>
        public const string SZSTMT = "SZSTMT";

        /// <summary>
        /// SZATCS.
        /// </summary>
        public const string SZATCS = "SZATCS";

        /// <summary>
        /// SZALGM.
        /// </summary>
        public const string SZALGM = "SZALGM";

        /// <summary>
        /// SZAGEM.
        /// </summary>
        public const string SZAGEM = "SZAGEM";

        /// <summary>
        /// SZCRDY.
        /// </summary>
        public const string SZCRDY = "SZCRDY";

        /// <summary>
        /// SZAGR1.
        /// </summary>
        public const string SZAGR1 = "SZAGR1";

        /// <summary>
        /// SZAGR2.
        /// </summary>
        public const string SZAGR2 = "SZAGR2";

        /// <summary>
        /// SZAGR3.
        /// </summary>
        public const string SZAGR3 = "SZAGR3";

        /// <summary>
        /// SZAGR4.
        /// </summary>
        public const string SZAGR4 = "SZAGR4";

        /// <summary>
        /// SZAGR5.
        /// </summary>
        public const string SZAGR5 = "SZAGR5";

        /// <summary>
        /// SZAGR6.
        /// </summary>
        public const string SZAGR6 = "SZAGR6";

        /// <summary>
        /// SZAGR7.
        /// </summary>
        public const string SZAGR7 = "SZAGR7";

        /// <summary>
        /// SZFRY.
        /// </summary>
        public const string SZFRY = "SZFRY";

        /// <summary>
        /// SZFRP.
        /// </summary>
        public const string SZFRP = "SZFRP";

        /// <summary>
        /// SZNNP.
        /// </summary>
        public const string SZNNP = "SZNNP";

        /// <summary>
        /// SZFP.
        /// </summary>
        public const string SZFP = "SZFP";

        /// <summary>
        /// SZAGE.
        /// </summary>
        public const string SZAGE = "SZAGE";

        /// <summary>
        /// SZDAG.
        /// </summary>
        public const string SZDAG = "SZDAG";

        /// <summary>
        /// SZARPN.
        /// </summary>
        public const string SZARPN = "SZARPN";

        /// <summary>
        /// SZAPPN.
        /// </summary>
        public const string SZAPPN = "SZAPPN";

        /// <summary>
        /// SZARFJ.
        /// </summary>
        public const string SZARFJ = "SZARFJ";

        /// <summary>
        /// SZAPFJ.
        /// </summary>
        public const string SZAPFJ = "SZAPFJ";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZSGBK.
        /// </summary>
        public const string SZSGBK = "SZSGBK";

        /// <summary>
        /// SZPTCO.
        /// </summary>
        public const string SZPTCO = "SZPTCO";

        /// <summary>
        /// SZX1.
        /// </summary>
        public const string SZX1 = "SZX1";

        /// <summary>
        /// SZX2.
        /// </summary>
        public const string SZX2 = "SZX2";

        /// <summary>
        /// SZTSCO.
        /// </summary>
        public const string SZTSCO = "SZTSCO";

        /// <summary>
        /// SZTSID.
        /// </summary>
        public const string SZTSID = "SZTSID";

        /// <summary>
        /// SZTHCO.
        /// </summary>
        public const string SZTHCO = "SZTHCO";

        /// <summary>
        /// SZAN8C.
        /// </summary>
        public const string SZAN8C = "SZAN8C";

        /// <summary>
        /// SZCTBPI.
        /// </summary>
        public const string SZCTBPI = "SZCTBPI";

        /// <summary>
        /// SZTFUC1.
        /// </summary>
        public const string SZTFUC1 = "SZTFUC1";

        /// <summary>
        /// SZTFUC2.
        /// </summary>
        public const string SZTFUC2 = "SZTFUC2";

        /// <summary>
        /// SZTFUN1.
        /// </summary>
        public const string SZTFUN1 = "SZTFUN1";

        /// <summary>
        /// SZTFUS1.
        /// </summary>
        public const string SZTFUS1 = "SZTFUS1";

        /// <summary>
        /// SZTFUDJ.
        /// </summary>
        public const string SZTFUDJ = "SZTFUDJ";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0010Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZACTN", "SZACTN", JdeDataType.String, 2),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZNAME", "SZNAME", JdeDataType.String, 60),
        new JdeField("SZALTC", "SZALTC", JdeDataType.String, 80),
        new JdeField("SZDFYJ", "SZDFYJ", JdeDataType.Numeric),
        new JdeField("SZPNC", "SZPNC", JdeDataType.Numeric),
        new JdeField("SZDOT1", "SZDOT1", JdeDataType.String, 2),
        new JdeField("SZCRYR", "SZCRYR", JdeDataType.String, 2),
        new JdeField("SZCRYC", "SZCRYC", JdeDataType.String, 2),
        new JdeField("SZDOT2", "SZDOT2", JdeDataType.String, 2),
        new JdeField("SZMCUA", "SZMCUA", JdeDataType.String, 2),
        new JdeField("SZMCUD", "SZMCUD", JdeDataType.String, 2),
        new JdeField("SZMCUC", "SZMCUC", JdeDataType.String, 2),
        new JdeField("SZMCUB", "SZMCUB", JdeDataType.String, 2),
        new JdeField("SZDPRC", "SZDPRC", JdeDataType.String, 2),
        new JdeField("SZBKTX", "SZBKTX", JdeDataType.String, 2),
        new JdeField("SZTXBM", "SZTXBM", JdeDataType.Numeric),
        new JdeField("SZTXBO", "SZTXBO", JdeDataType.Numeric),
        new JdeField("SZNWXJ", "SZNWXJ", JdeDataType.Numeric),
        new JdeField("SZGLIE", "SZGLIE", JdeDataType.String, 2),
        new JdeField("SZABIN", "SZABIN", JdeDataType.String, 2),
        new JdeField("SZCALD", "SZCALD", JdeDataType.String, 4),
        new JdeField("SZDTPN", "SZDTPN", JdeDataType.String, 2),
        new JdeField("SZPNF", "SZPNF", JdeDataType.Numeric),
        new JdeField("SZDFF", "SZDFF", JdeDataType.Numeric),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZSMI", "SZSMI", JdeDataType.String, 2),
        new JdeField("SZSMU", "SZSMU", JdeDataType.String, 2),
        new JdeField("SZSMS", "SZSMS", JdeDataType.String, 2),
        new JdeField("SZDNLT", "SZDNLT", JdeDataType.String, 2),
        new JdeField("SZSTMT", "SZSTMT", JdeDataType.String, 2),
        new JdeField("SZATCS", "SZATCS", JdeDataType.String, 2),
        new JdeField("SZALGM", "SZALGM", JdeDataType.String, 4),
        new JdeField("SZAGEM", "SZAGEM", JdeDataType.String, 2),
        new JdeField("SZCRDY", "SZCRDY", JdeDataType.Numeric),
        new JdeField("SZAGR1", "SZAGR1", JdeDataType.Numeric),
        new JdeField("SZAGR2", "SZAGR2", JdeDataType.Numeric),
        new JdeField("SZAGR3", "SZAGR3", JdeDataType.Numeric),
        new JdeField("SZAGR4", "SZAGR4", JdeDataType.Numeric),
        new JdeField("SZAGR5", "SZAGR5", JdeDataType.Numeric),
        new JdeField("SZAGR6", "SZAGR6", JdeDataType.Numeric),
        new JdeField("SZAGR7", "SZAGR7", JdeDataType.Numeric),
        new JdeField("SZFRY", "SZFRY", JdeDataType.Numeric),
        new JdeField("SZFRP", "SZFRP", JdeDataType.Numeric),
        new JdeField("SZNNP", "SZNNP", JdeDataType.Numeric),
        new JdeField("SZFP", "SZFP", JdeDataType.Numeric),
        new JdeField("SZAGE", "SZAGE", JdeDataType.String, 2),
        new JdeField("SZDAG", "SZDAG", JdeDataType.Numeric),
        new JdeField("SZARPN", "SZARPN", JdeDataType.Numeric),
        new JdeField("SZAPPN", "SZAPPN", JdeDataType.Numeric),
        new JdeField("SZARFJ", "SZARFJ", JdeDataType.Numeric),
        new JdeField("SZAPFJ", "SZAPFJ", JdeDataType.Numeric),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZSGBK", "SZSGBK", JdeDataType.String, 80),
        new JdeField("SZPTCO", "SZPTCO", JdeDataType.String, 2),
        new JdeField("SZX1", "SZX1", JdeDataType.String, 2),
        new JdeField("SZX2", "SZX2", JdeDataType.String, 2),
        new JdeField("SZTSCO", "SZTSCO", JdeDataType.String, 10),
        new JdeField("SZTSID", "SZTSID", JdeDataType.Numeric),
        new JdeField("SZTHCO", "SZTHCO", JdeDataType.String, 6),
        new JdeField("SZAN8C", "SZAN8C", JdeDataType.Numeric),
        new JdeField("SZCTBPI", "SZCTBPI", JdeDataType.String, 2),
        new JdeField("SZTFUC1", "SZTFUC1", JdeDataType.String, 2),
        new JdeField("SZTFUC2", "SZTFUC2", JdeDataType.String, 2),
        new JdeField("SZTFUN1", "SZTFUN1", JdeDataType.Numeric),
        new JdeField("SZTFUS1", "SZTFUS1", JdeDataType.String, 80),
        new JdeField("SZTFUDJ", "SZTFUDJ", JdeDataType.Numeric),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0010Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
