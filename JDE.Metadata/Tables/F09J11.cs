using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J11 - .
/// </summary>
public class F09J11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JFDCT.
        /// </summary>
        public const string JFDCT = "JFDCT";

        /// <summary>
        /// JFDOC.
        /// </summary>
        public const string JFDOC = "JFDOC";

        /// <summary>
        /// JFKCO.
        /// </summary>
        public const string JFKCO = "JFKCO";

        /// <summary>
        /// JFDGJ.
        /// </summary>
        public const string JFDGJ = "JFDGJ";

        /// <summary>
        /// JFJELN.
        /// </summary>
        public const string JFJELN = "JFJELN";

        /// <summary>
        /// JFLT.
        /// </summary>
        public const string JFLT = "JFLT";

        /// <summary>
        /// JFEXTL.
        /// </summary>
        public const string JFEXTL = "JFEXTL";

        /// <summary>
        /// JFCO.
        /// </summary>
        public const string JFCO = "JFCO";

        /// <summary>
        /// JFAID.
        /// </summary>
        public const string JFAID = "JFAID";

        /// <summary>
        /// JFMCU.
        /// </summary>
        public const string JFMCU = "JFMCU";

        /// <summary>
        /// JFMCUS.
        /// </summary>
        public const string JFMCUS = "JFMCUS";

        /// <summary>
        /// JFOBJ.
        /// </summary>
        public const string JFOBJ = "JFOBJ";

        /// <summary>
        /// JFSUB.
        /// </summary>
        public const string JFSUB = "JFSUB";

        /// <summary>
        /// JFSBL.
        /// </summary>
        public const string JFSBL = "JFSBL";

        /// <summary>
        /// JFSBLT.
        /// </summary>
        public const string JFSBLT = "JFSBLT";

        /// <summary>
        /// JFPN.
        /// </summary>
        public const string JFPN = "JFPN";

        /// <summary>
        /// JFCTRY.
        /// </summary>
        public const string JFCTRY = "JFCTRY";

        /// <summary>
        /// JFFY.
        /// </summary>
        public const string JFFY = "JFFY";

        /// <summary>
        /// JFAA.
        /// </summary>
        public const string JFAA = "JFAA";

        /// <summary>
        /// JFU.
        /// </summary>
        public const string JFU = "JFU";

        /// <summary>
        /// JFUM.
        /// </summary>
        public const string JFUM = "JFUM";

        /// <summary>
        /// JFEXA.
        /// </summary>
        public const string JFEXA = "JFEXA";

        /// <summary>
        /// JFEXR.
        /// </summary>
        public const string JFEXR = "JFEXR";

        /// <summary>
        /// JFDSVJ.
        /// </summary>
        public const string JFDSVJ = "JFDSVJ";

        /// <summary>
        /// JFJVNAME.
        /// </summary>
        public const string JFJVNAME = "JFJVNAME";

        /// <summary>
        /// JFJVCO.
        /// </summary>
        public const string JFJVCO = "JFJVCO";

        /// <summary>
        /// JFJVDOI.
        /// </summary>
        public const string JFJVDOI = "JFJVDOI";

        /// <summary>
        /// JFEFTB.
        /// </summary>
        public const string JFEFTB = "JFEFTB";

        /// <summary>
        /// JFJVODOI.
        /// </summary>
        public const string JFJVODOI = "JFJVODOI";

        /// <summary>
        /// JFJVOEFTB.
        /// </summary>
        public const string JFJVOEFTB = "JFJVOEFTB";

        /// <summary>
        /// JFJVTSTS.
        /// </summary>
        public const string JFJVTSTS = "JFJVTSTS";

        /// <summary>
        /// JFJVJOBS.
        /// </summary>
        public const string JFJVJOBS = "JFJVJOBS";

        /// <summary>
        /// JFTORG.
        /// </summary>
        public const string JFTORG = "JFTORG";

        /// <summary>
        /// JFENTJ.
        /// </summary>
        public const string JFENTJ = "JFENTJ";

        /// <summary>
        /// JFUSER.
        /// </summary>
        public const string JFUSER = "JFUSER";

        /// <summary>
        /// JFUPMJ.
        /// </summary>
        public const string JFUPMJ = "JFUPMJ";

        /// <summary>
        /// JFUPMT.
        /// </summary>
        public const string JFUPMT = "JFUPMT";

        /// <summary>
        /// JFPID.
        /// </summary>
        public const string JFPID = "JFPID";

        /// <summary>
        /// JFMKEY.
        /// </summary>
        public const string JFMKEY = "JFMKEY";

        /// <summary>
        /// JFURAB.
        /// </summary>
        public const string JFURAB = "JFURAB";

        /// <summary>
        /// JFURCD.
        /// </summary>
        public const string JFURCD = "JFURCD";

        /// <summary>
        /// JFURAT.
        /// </summary>
        public const string JFURAT = "JFURAT";

        /// <summary>
        /// JFURDT.
        /// </summary>
        public const string JFURDT = "JFURDT";

        /// <summary>
        /// JFURRF.
        /// </summary>
        public const string JFURRF = "JFURRF";

        /// <summary>
        /// JFJVWNU1.
        /// </summary>
        public const string JFJVWNU1 = "JFJVWNU1";

        /// <summary>
        /// JFJVWNU2.
        /// </summary>
        public const string JFJVWNU2 = "JFJVWNU2";

        /// <summary>
        /// JFJVWNU3.
        /// </summary>
        public const string JFJVWNU3 = "JFJVWNU3";

        /// <summary>
        /// JFJVWST1.
        /// </summary>
        public const string JFJVWST1 = "JFJVWST1";

        /// <summary>
        /// JFJVWST2.
        /// </summary>
        public const string JFJVWST2 = "JFJVWST2";

        /// <summary>
        /// JFJVWST3.
        /// </summary>
        public const string JFJVWST3 = "JFJVWST3";

        /// <summary>
        /// JFJVWCH1.
        /// </summary>
        public const string JFJVWCH1 = "JFJVWCH1";

        /// <summary>
        /// JFJVWCH2.
        /// </summary>
        public const string JFJVWCH2 = "JFJVWCH2";

        /// <summary>
        /// JFJVWCH3.
        /// </summary>
        public const string JFJVWCH3 = "JFJVWCH3";

        /// <summary>
        /// JFJVWDT1.
        /// </summary>
        public const string JFJVWDT1 = "JFJVWDT1";

        /// <summary>
        /// JFJVWDT2.
        /// </summary>
        public const string JFJVWDT2 = "JFJVWDT2";

        /// <summary>
        /// JFJVWDT3.
        /// </summary>
        public const string JFJVWDT3 = "JFJVWDT3";

        /// <summary>
        /// JFRE.
        /// </summary>
        public const string JFRE = "JFRE";

        /// <summary>
        /// JFJVDC.
        /// </summary>
        public const string JFJVDC = "JFJVDC";

        /// <summary>
        /// JFJVMCO.
        /// </summary>
        public const string JFJVMCO = "JFJVMCO";

        /// <summary>
        /// JFRMK.
        /// </summary>
        public const string JFRMK = "JFRMK";

        /// <summary>
        /// JFAN8.
        /// </summary>
        public const string JFAN8 = "JFAN8";

        /// <summary>
        /// JFASID.
        /// </summary>
        public const string JFASID = "JFASID";

        /// <summary>
        /// JFABR1.
        /// </summary>
        public const string JFABR1 = "JFABR1";

        /// <summary>
        /// JFABR2.
        /// </summary>
        public const string JFABR2 = "JFABR2";

        /// <summary>
        /// JFABR3.
        /// </summary>
        public const string JFABR3 = "JFABR3";

        /// <summary>
        /// JFABR4.
        /// </summary>
        public const string JFABR4 = "JFABR4";

        /// <summary>
        /// JFABT1.
        /// </summary>
        public const string JFABT1 = "JFABT1";

        /// <summary>
        /// JFABT2.
        /// </summary>
        public const string JFABT2 = "JFABT2";

        /// <summary>
        /// JFABT3.
        /// </summary>
        public const string JFABT3 = "JFABT3";

        /// <summary>
        /// JFABT4.
        /// </summary>
        public const string JFABT4 = "JFABT4";

        /// <summary>
        /// JFITM.
        /// </summary>
        public const string JFITM = "JFITM";

        /// <summary>
        /// JFJVDBTP.
        /// </summary>
        public const string JFJVDBTP = "JFJVDBTP";

        /// <summary>
        /// JFJVODBTP.
        /// </summary>
        public const string JFJVODBTP = "JFJVODBTP";

        /// <summary>
        /// JFJVDBTIBU.
        /// </summary>
        public const string JFJVDBTIBU = "JFJVDBTIBU";

        /// <summary>
        /// JFJVODBIBU.
        /// </summary>
        public const string JFJVODBIBU = "JFJVODBIBU";
    }

    /// <inheritdoc />
    public override string TableName => "F09J11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JFDCT", "JFDCT", JdeDataType.String, 4, true, true),
        new JdeField("JFDOC", "JFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("JFKCO", "JFKCO", JdeDataType.String, 10, true, true),
        new JdeField("JFDGJ", "JFDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("JFJELN", "JFJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("JFLT", "JFLT", JdeDataType.String, 4, true, true),
        new JdeField("JFEXTL", "JFEXTL", JdeDataType.String, 4, true, true),
        new JdeField("JFCO", "JFCO", JdeDataType.String, 10),
        new JdeField("JFAID", "JFAID", JdeDataType.String, 16),
        new JdeField("JFMCU", "JFMCU", JdeDataType.String, 24),
        new JdeField("JFMCUS", "JFMCUS", JdeDataType.String, 24),
        new JdeField("JFOBJ", "JFOBJ", JdeDataType.String, 12),
        new JdeField("JFSUB", "JFSUB", JdeDataType.String, 16),
        new JdeField("JFSBL", "JFSBL", JdeDataType.String, 16),
        new JdeField("JFSBLT", "JFSBLT", JdeDataType.String, 2),
        new JdeField("JFPN", "JFPN", JdeDataType.Numeric),
        new JdeField("JFCTRY", "JFCTRY", JdeDataType.Numeric),
        new JdeField("JFFY", "JFFY", JdeDataType.Numeric),
        new JdeField("JFAA", "JFAA", JdeDataType.Numeric),
        new JdeField("JFU", "JFU", JdeDataType.Numeric),
        new JdeField("JFUM", "JFUM", JdeDataType.String, 4),
        new JdeField("JFEXA", "JFEXA", JdeDataType.String, 60),
        new JdeField("JFEXR", "JFEXR", JdeDataType.String, 60),
        new JdeField("JFDSVJ", "JFDSVJ", JdeDataType.Numeric),
        new JdeField("JFJVNAME", "JFJVNAME", JdeDataType.String, 40),
        new JdeField("JFJVCO", "JFJVCO", JdeDataType.String, 10),
        new JdeField("JFJVDOI", "JFJVDOI", JdeDataType.String, 40),
        new JdeField("JFEFTB", "JFEFTB", JdeDataType.Numeric),
        new JdeField("JFJVODOI", "JFJVODOI", JdeDataType.String, 40),
        new JdeField("JFJVOEFTB", "JFJVOEFTB", JdeDataType.Numeric),
        new JdeField("JFJVTSTS", "JFJVTSTS", JdeDataType.String, 6),
        new JdeField("JFJVJOBS", "JFJVJOBS", JdeDataType.Numeric),
        new JdeField("JFTORG", "JFTORG", JdeDataType.String, 20),
        new JdeField("JFENTJ", "JFENTJ", JdeDataType.Numeric),
        new JdeField("JFUSER", "JFUSER", JdeDataType.String, 20),
        new JdeField("JFUPMJ", "JFUPMJ", JdeDataType.Numeric),
        new JdeField("JFUPMT", "JFUPMT", JdeDataType.Numeric),
        new JdeField("JFPID", "JFPID", JdeDataType.String, 20),
        new JdeField("JFMKEY", "JFMKEY", JdeDataType.String, 30),
        new JdeField("JFURAB", "JFURAB", JdeDataType.Numeric),
        new JdeField("JFURCD", "JFURCD", JdeDataType.String, 4),
        new JdeField("JFURAT", "JFURAT", JdeDataType.Numeric),
        new JdeField("JFURDT", "JFURDT", JdeDataType.Numeric),
        new JdeField("JFURRF", "JFURRF", JdeDataType.String, 30),
        new JdeField("JFJVWNU1", "JFJVWNU1", JdeDataType.Numeric),
        new JdeField("JFJVWNU2", "JFJVWNU2", JdeDataType.Numeric),
        new JdeField("JFJVWNU3", "JFJVWNU3", JdeDataType.Numeric),
        new JdeField("JFJVWST1", "JFJVWST1", JdeDataType.String, 160),
        new JdeField("JFJVWST2", "JFJVWST2", JdeDataType.String, 160),
        new JdeField("JFJVWST3", "JFJVWST3", JdeDataType.String, 160),
        new JdeField("JFJVWCH1", "JFJVWCH1", JdeDataType.String, 2),
        new JdeField("JFJVWCH2", "JFJVWCH2", JdeDataType.String, 2),
        new JdeField("JFJVWCH3", "JFJVWCH3", JdeDataType.String, 2),
        new JdeField("JFJVWDT1", "JFJVWDT1", JdeDataType.Numeric),
        new JdeField("JFJVWDT2", "JFJVWDT2", JdeDataType.Numeric),
        new JdeField("JFJVWDT3", "JFJVWDT3", JdeDataType.Numeric),
        new JdeField("JFRE", "JFRE", JdeDataType.String, 2),
        new JdeField("JFJVDC", "JFJVDC", JdeDataType.String, 2),
        new JdeField("JFJVMCO", "JFJVMCO", JdeDataType.String, 10),
        new JdeField("JFRMK", "JFRMK", JdeDataType.String, 60),
        new JdeField("JFAN8", "JFAN8", JdeDataType.Numeric),
        new JdeField("JFASID", "JFASID", JdeDataType.String, 50),
        new JdeField("JFABR1", "JFABR1", JdeDataType.String, 24),
        new JdeField("JFABR2", "JFABR2", JdeDataType.String, 24),
        new JdeField("JFABR3", "JFABR3", JdeDataType.String, 24),
        new JdeField("JFABR4", "JFABR4", JdeDataType.String, 24),
        new JdeField("JFABT1", "JFABT1", JdeDataType.String, 2),
        new JdeField("JFABT2", "JFABT2", JdeDataType.String, 2),
        new JdeField("JFABT3", "JFABT3", JdeDataType.String, 2),
        new JdeField("JFABT4", "JFABT4", JdeDataType.String, 2),
        new JdeField("JFITM", "JFITM", JdeDataType.Numeric),
        new JdeField("JFJVDBTP", "JFJVDBTP", JdeDataType.Numeric),
        new JdeField("JFJVODBTP", "JFJVODBTP", JdeDataType.Numeric),
        new JdeField("JFJVDBTIBU", "JFJVDBTIBU", JdeDataType.String, 24),
        new JdeField("JFJVODBIBU", "JFJVODBIBU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J11_0", "Primary Key on JFDCT, JFDOC, JFKCO, JFDGJ, JFJELN, JFLT, JFEXTL", new[] { "JFDCT", "JFDOC", "JFKCO", "JFDGJ", "JFJELN", "JFLT", "JFEXTL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J11_2", "Index on JFJVJOBS, JFJVCO, JFJVNAME, JFMCUS, JFMCU, JFOBJ, JFSUB", new[] { "JFJVJOBS", "JFJVCO", "JFJVNAME", "JFMCUS", "JFMCU", "JFOBJ", "JFSUB" }),
        new JdeIndex("F09J11_3", "Index on JFJVDBTIBU, JFJVDBTP, JFJVDOI, JFDSVJ, JFDCT, JFDOC, JFKCO, JFDGJ, JFJELN, JFLT, SYS_NC00076$", new[] { "JFJVDBTIBU", "JFJVDBTP", "JFJVDOI", "JFDSVJ", "JFDCT", "JFDOC", "JFKCO", "JFDGJ", "JFJELN", "JFLT", "SYS_NC00076$" }),
        new JdeIndex("F09J11_4", "Index on JFJVNAME", new[] { "JFJVNAME" }),
        new JdeIndex("F09J11_5", "Index on JFJVDOI, JFEFTB", new[] { "JFJVDOI", "JFEFTB" })
    };
}
