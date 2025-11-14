using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J12 - .
/// </summary>
public class F09J12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JIDCT.
        /// </summary>
        public const string JIDCT = "JIDCT";

        /// <summary>
        /// JIDOC.
        /// </summary>
        public const string JIDOC = "JIDOC";

        /// <summary>
        /// JIKCO.
        /// </summary>
        public const string JIKCO = "JIKCO";

        /// <summary>
        /// JIDGJ.
        /// </summary>
        public const string JIDGJ = "JIDGJ";

        /// <summary>
        /// JIJELN.
        /// </summary>
        public const string JIJELN = "JIJELN";

        /// <summary>
        /// JILT.
        /// </summary>
        public const string JILT = "JILT";

        /// <summary>
        /// JIEXTL.
        /// </summary>
        public const string JIEXTL = "JIEXTL";

        /// <summary>
        /// JIAN8.
        /// </summary>
        public const string JIAN8 = "JIAN8";

        /// <summary>
        /// JIJVPOI.
        /// </summary>
        public const string JIJVPOI = "JIJVPOI";

        /// <summary>
        /// JIJVDAA.
        /// </summary>
        public const string JIJVDAA = "JIJVDAA";

        /// <summary>
        /// JIJVDU.
        /// </summary>
        public const string JIJVDU = "JIJVDU";

        /// <summary>
        /// JICO.
        /// </summary>
        public const string JICO = "JICO";

        /// <summary>
        /// JIAID.
        /// </summary>
        public const string JIAID = "JIAID";

        /// <summary>
        /// JIMCU.
        /// </summary>
        public const string JIMCU = "JIMCU";

        /// <summary>
        /// JIMCUS.
        /// </summary>
        public const string JIMCUS = "JIMCUS";

        /// <summary>
        /// JIOBJ.
        /// </summary>
        public const string JIOBJ = "JIOBJ";

        /// <summary>
        /// JISUB.
        /// </summary>
        public const string JISUB = "JISUB";

        /// <summary>
        /// JISBL.
        /// </summary>
        public const string JISBL = "JISBL";

        /// <summary>
        /// JISBLT.
        /// </summary>
        public const string JISBLT = "JISBLT";

        /// <summary>
        /// JIPN.
        /// </summary>
        public const string JIPN = "JIPN";

        /// <summary>
        /// JICTRY.
        /// </summary>
        public const string JICTRY = "JICTRY";

        /// <summary>
        /// JIFY.
        /// </summary>
        public const string JIFY = "JIFY";

        /// <summary>
        /// JIAA.
        /// </summary>
        public const string JIAA = "JIAA";

        /// <summary>
        /// JIU.
        /// </summary>
        public const string JIU = "JIU";

        /// <summary>
        /// JIUM.
        /// </summary>
        public const string JIUM = "JIUM";

        /// <summary>
        /// JIEXA.
        /// </summary>
        public const string JIEXA = "JIEXA";

        /// <summary>
        /// JIEXR.
        /// </summary>
        public const string JIEXR = "JIEXR";

        /// <summary>
        /// JIDSVJ.
        /// </summary>
        public const string JIDSVJ = "JIDSVJ";

        /// <summary>
        /// JIJVNAME.
        /// </summary>
        public const string JIJVNAME = "JIJVNAME";

        /// <summary>
        /// JIJVCO.
        /// </summary>
        public const string JIJVCO = "JIJVCO";

        /// <summary>
        /// JIJVDOI.
        /// </summary>
        public const string JIJVDOI = "JIJVDOI";

        /// <summary>
        /// JIEFTB.
        /// </summary>
        public const string JIEFTB = "JIEFTB";

        /// <summary>
        /// JIJVAN8.
        /// </summary>
        public const string JIJVAN8 = "JIJVAN8";

        /// <summary>
        /// JIJVDIS.
        /// </summary>
        public const string JIJVDIS = "JIJVDIS";

        /// <summary>
        /// JIJVTSTS.
        /// </summary>
        public const string JIJVTSTS = "JIJVTSTS";

        /// <summary>
        /// JITORG.
        /// </summary>
        public const string JITORG = "JITORG";

        /// <summary>
        /// JIENTJ.
        /// </summary>
        public const string JIENTJ = "JIENTJ";

        /// <summary>
        /// JIUSER.
        /// </summary>
        public const string JIUSER = "JIUSER";

        /// <summary>
        /// JIUPMJ.
        /// </summary>
        public const string JIUPMJ = "JIUPMJ";

        /// <summary>
        /// JIUPMT.
        /// </summary>
        public const string JIUPMT = "JIUPMT";

        /// <summary>
        /// JIPID.
        /// </summary>
        public const string JIPID = "JIPID";

        /// <summary>
        /// JIMKEY.
        /// </summary>
        public const string JIMKEY = "JIMKEY";

        /// <summary>
        /// JIURAB.
        /// </summary>
        public const string JIURAB = "JIURAB";

        /// <summary>
        /// JIURCD.
        /// </summary>
        public const string JIURCD = "JIURCD";

        /// <summary>
        /// JIURAT.
        /// </summary>
        public const string JIURAT = "JIURAT";

        /// <summary>
        /// JIURDT.
        /// </summary>
        public const string JIURDT = "JIURDT";

        /// <summary>
        /// JIURRF.
        /// </summary>
        public const string JIURRF = "JIURRF";

        /// <summary>
        /// JIJVSNU1.
        /// </summary>
        public const string JIJVSNU1 = "JIJVSNU1";

        /// <summary>
        /// JIJVSNU2.
        /// </summary>
        public const string JIJVSNU2 = "JIJVSNU2";

        /// <summary>
        /// JIJVSNU3.
        /// </summary>
        public const string JIJVSNU3 = "JIJVSNU3";

        /// <summary>
        /// JIJVSST1.
        /// </summary>
        public const string JIJVSST1 = "JIJVSST1";

        /// <summary>
        /// JIJVSST2.
        /// </summary>
        public const string JIJVSST2 = "JIJVSST2";

        /// <summary>
        /// JIJVSST3.
        /// </summary>
        public const string JIJVSST3 = "JIJVSST3";

        /// <summary>
        /// JIJVSCH1.
        /// </summary>
        public const string JIJVSCH1 = "JIJVSCH1";

        /// <summary>
        /// JIJVSCH2.
        /// </summary>
        public const string JIJVSCH2 = "JIJVSCH2";

        /// <summary>
        /// JIJVSCH3.
        /// </summary>
        public const string JIJVSCH3 = "JIJVSCH3";

        /// <summary>
        /// JIJVSDT1.
        /// </summary>
        public const string JIJVSDT1 = "JIJVSDT1";

        /// <summary>
        /// JIJVSDT2.
        /// </summary>
        public const string JIJVSDT2 = "JIJVSDT2";

        /// <summary>
        /// JIJVSDT3.
        /// </summary>
        public const string JIJVSDT3 = "JIJVSDT3";

        /// <summary>
        /// JIRE.
        /// </summary>
        public const string JIRE = "JIRE";

        /// <summary>
        /// JIJVIBU.
        /// </summary>
        public const string JIJVIBU = "JIJVIBU";

        /// <summary>
        /// JIJVIVI.
        /// </summary>
        public const string JIJVIVI = "JIJVIVI";

        /// <summary>
        /// JIJVMCO.
        /// </summary>
        public const string JIJVMCO = "JIJVMCO";

        /// <summary>
        /// JIJVDSID.
        /// </summary>
        public const string JIJVDSID = "JIJVDSID";

        /// <summary>
        /// JIJVDTT.
        /// </summary>
        public const string JIJVDTT = "JIJVDTT";

        /// <summary>
        /// JIJVDOC.
        /// </summary>
        public const string JIJVDOC = "JIJVDOC";

        /// <summary>
        /// JIJVDCT.
        /// </summary>
        public const string JIJVDCT = "JIJVDCT";

        /// <summary>
        /// JIJVKCO.
        /// </summary>
        public const string JIJVKCO = "JIJVKCO";

        /// <summary>
        /// JIJVSFX.
        /// </summary>
        public const string JIJVSFX = "JIJVSFX";

        /// <summary>
        /// JIJVSFXE.
        /// </summary>
        public const string JIJVSFXE = "JIJVSFXE";

        /// <summary>
        /// JIJVDGJ.
        /// </summary>
        public const string JIJVDGJ = "JIJVDGJ";

        /// <summary>
        /// JIJVJELN.
        /// </summary>
        public const string JIJVJELN = "JIJVJELN";

        /// <summary>
        /// JIJVLT.
        /// </summary>
        public const string JIJVLT = "JIJVLT";

        /// <summary>
        /// JIJVEXTL.
        /// </summary>
        public const string JIJVEXTL = "JIJVEXTL";

        /// <summary>
        /// JIRMK.
        /// </summary>
        public const string JIRMK = "JIRMK";

        /// <summary>
        /// JIASID.
        /// </summary>
        public const string JIASID = "JIASID";

        /// <summary>
        /// JIABR1.
        /// </summary>
        public const string JIABR1 = "JIABR1";

        /// <summary>
        /// JIABR2.
        /// </summary>
        public const string JIABR2 = "JIABR2";

        /// <summary>
        /// JIABR3.
        /// </summary>
        public const string JIABR3 = "JIABR3";

        /// <summary>
        /// JIABR4.
        /// </summary>
        public const string JIABR4 = "JIABR4";

        /// <summary>
        /// JIABT1.
        /// </summary>
        public const string JIABT1 = "JIABT1";

        /// <summary>
        /// JIABT2.
        /// </summary>
        public const string JIABT2 = "JIABT2";

        /// <summary>
        /// JIABT3.
        /// </summary>
        public const string JIABT3 = "JIABT3";

        /// <summary>
        /// JIABT4.
        /// </summary>
        public const string JIABT4 = "JIABT4";

        /// <summary>
        /// JIITM.
        /// </summary>
        public const string JIITM = "JIITM";

        /// <summary>
        /// JIJVCBAI.
        /// </summary>
        public const string JIJVCBAI = "JIJVCBAI";

        /// <summary>
        /// JIJVCBLT.
        /// </summary>
        public const string JIJVCBLT = "JIJVCBLT";

        /// <summary>
        /// JIJVVOID.
        /// </summary>
        public const string JIJVVOID = "JIJVVOID";

        /// <summary>
        /// JIVDGJ.
        /// </summary>
        public const string JIVDGJ = "JIVDGJ";

        /// <summary>
        /// JIJVDLN.
        /// </summary>
        public const string JIJVDLN = "JIJVDLN";

        /// <summary>
        /// JIJVCCID.
        /// </summary>
        public const string JIJVCCID = "JIJVCCID";

        /// <summary>
        /// JIJVCCEX.
        /// </summary>
        public const string JIJVCCEX = "JIJVCCEX";

        /// <summary>
        /// JIJVODAA.
        /// </summary>
        public const string JIJVODAA = "JIJVODAA";
    }

    /// <inheritdoc />
    public override string TableName => "F09J12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JIDCT", "JIDCT", JdeDataType.String, 4, true, true),
        new JdeField("JIDOC", "JIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("JIKCO", "JIKCO", JdeDataType.String, 10, true, true),
        new JdeField("JIDGJ", "JIDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("JIJELN", "JIJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("JILT", "JILT", JdeDataType.String, 4, true, true),
        new JdeField("JIEXTL", "JIEXTL", JdeDataType.String, 4, true, true),
        new JdeField("JIAN8", "JIAN8", JdeDataType.Numeric),
        new JdeField("JIJVPOI", "JIJVPOI", JdeDataType.Numeric),
        new JdeField("JIJVDAA", "JIJVDAA", JdeDataType.Numeric),
        new JdeField("JIJVDU", "JIJVDU", JdeDataType.Numeric),
        new JdeField("JICO", "JICO", JdeDataType.String, 10),
        new JdeField("JIAID", "JIAID", JdeDataType.String, 16),
        new JdeField("JIMCU", "JIMCU", JdeDataType.String, 24),
        new JdeField("JIMCUS", "JIMCUS", JdeDataType.String, 24),
        new JdeField("JIOBJ", "JIOBJ", JdeDataType.String, 12),
        new JdeField("JISUB", "JISUB", JdeDataType.String, 16),
        new JdeField("JISBL", "JISBL", JdeDataType.String, 16),
        new JdeField("JISBLT", "JISBLT", JdeDataType.String, 2),
        new JdeField("JIPN", "JIPN", JdeDataType.Numeric),
        new JdeField("JICTRY", "JICTRY", JdeDataType.Numeric),
        new JdeField("JIFY", "JIFY", JdeDataType.Numeric),
        new JdeField("JIAA", "JIAA", JdeDataType.Numeric),
        new JdeField("JIU", "JIU", JdeDataType.Numeric),
        new JdeField("JIUM", "JIUM", JdeDataType.String, 4),
        new JdeField("JIEXA", "JIEXA", JdeDataType.String, 60),
        new JdeField("JIEXR", "JIEXR", JdeDataType.String, 60),
        new JdeField("JIDSVJ", "JIDSVJ", JdeDataType.Numeric),
        new JdeField("JIJVNAME", "JIJVNAME", JdeDataType.String, 40),
        new JdeField("JIJVCO", "JIJVCO", JdeDataType.String, 10),
        new JdeField("JIJVDOI", "JIJVDOI", JdeDataType.String, 40),
        new JdeField("JIEFTB", "JIEFTB", JdeDataType.Numeric),
        new JdeField("JIJVAN8", "JIJVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JIJVDIS", "JIJVDIS", JdeDataType.String, 2),
        new JdeField("JIJVTSTS", "JIJVTSTS", JdeDataType.String, 6),
        new JdeField("JITORG", "JITORG", JdeDataType.String, 20),
        new JdeField("JIENTJ", "JIENTJ", JdeDataType.Numeric),
        new JdeField("JIUSER", "JIUSER", JdeDataType.String, 20),
        new JdeField("JIUPMJ", "JIUPMJ", JdeDataType.Numeric),
        new JdeField("JIUPMT", "JIUPMT", JdeDataType.Numeric),
        new JdeField("JIPID", "JIPID", JdeDataType.String, 20),
        new JdeField("JIMKEY", "JIMKEY", JdeDataType.String, 30),
        new JdeField("JIURAB", "JIURAB", JdeDataType.Numeric),
        new JdeField("JIURCD", "JIURCD", JdeDataType.String, 4),
        new JdeField("JIURAT", "JIURAT", JdeDataType.Numeric),
        new JdeField("JIURDT", "JIURDT", JdeDataType.Numeric),
        new JdeField("JIURRF", "JIURRF", JdeDataType.String, 30),
        new JdeField("JIJVSNU1", "JIJVSNU1", JdeDataType.Numeric, null, true, true),
        new JdeField("JIJVSNU2", "JIJVSNU2", JdeDataType.Numeric),
        new JdeField("JIJVSNU3", "JIJVSNU3", JdeDataType.Numeric),
        new JdeField("JIJVSST1", "JIJVSST1", JdeDataType.String, 160),
        new JdeField("JIJVSST2", "JIJVSST2", JdeDataType.String, 160),
        new JdeField("JIJVSST3", "JIJVSST3", JdeDataType.String, 160),
        new JdeField("JIJVSCH1", "JIJVSCH1", JdeDataType.String, 2),
        new JdeField("JIJVSCH2", "JIJVSCH2", JdeDataType.String, 2),
        new JdeField("JIJVSCH3", "JIJVSCH3", JdeDataType.String, 2),
        new JdeField("JIJVSDT1", "JIJVSDT1", JdeDataType.Numeric),
        new JdeField("JIJVSDT2", "JIJVSDT2", JdeDataType.Numeric),
        new JdeField("JIJVSDT3", "JIJVSDT3", JdeDataType.Numeric),
        new JdeField("JIRE", "JIRE", JdeDataType.String, 2),
        new JdeField("JIJVIBU", "JIJVIBU", JdeDataType.String, 24, true, true),
        new JdeField("JIJVIVI", "JIJVIVI", JdeDataType.String, 2),
        new JdeField("JIJVMCO", "JIJVMCO", JdeDataType.String, 10),
        new JdeField("JIJVDSID", "JIJVDSID", JdeDataType.Numeric),
        new JdeField("JIJVDTT", "JIJVDTT", JdeDataType.String, 2),
        new JdeField("JIJVDOC", "JIJVDOC", JdeDataType.Numeric),
        new JdeField("JIJVDCT", "JIJVDCT", JdeDataType.String, 4),
        new JdeField("JIJVKCO", "JIJVKCO", JdeDataType.String, 10),
        new JdeField("JIJVSFX", "JIJVSFX", JdeDataType.String, 6),
        new JdeField("JIJVSFXE", "JIJVSFXE", JdeDataType.Numeric),
        new JdeField("JIJVDGJ", "JIJVDGJ", JdeDataType.Numeric),
        new JdeField("JIJVJELN", "JIJVJELN", JdeDataType.Numeric),
        new JdeField("JIJVLT", "JIJVLT", JdeDataType.String, 4),
        new JdeField("JIJVEXTL", "JIJVEXTL", JdeDataType.String, 4),
        new JdeField("JIRMK", "JIRMK", JdeDataType.String, 60),
        new JdeField("JIASID", "JIASID", JdeDataType.String, 50),
        new JdeField("JIABR1", "JIABR1", JdeDataType.String, 24),
        new JdeField("JIABR2", "JIABR2", JdeDataType.String, 24),
        new JdeField("JIABR3", "JIABR3", JdeDataType.String, 24),
        new JdeField("JIABR4", "JIABR4", JdeDataType.String, 24),
        new JdeField("JIABT1", "JIABT1", JdeDataType.String, 2),
        new JdeField("JIABT2", "JIABT2", JdeDataType.String, 2),
        new JdeField("JIABT3", "JIABT3", JdeDataType.String, 2),
        new JdeField("JIABT4", "JIABT4", JdeDataType.String, 2),
        new JdeField("JIITM", "JIITM", JdeDataType.Numeric),
        new JdeField("JIJVCBAI", "JIJVCBAI", JdeDataType.String, 12),
        new JdeField("JIJVCBLT", "JIJVCBLT", JdeDataType.String, 4),
        new JdeField("JIJVVOID", "JIJVVOID", JdeDataType.String, 2, true, true),
        new JdeField("JIVDGJ", "JIVDGJ", JdeDataType.Numeric),
        new JdeField("JIJVDLN", "JIJVDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("JIJVCCID", "JIJVCCID", JdeDataType.Numeric),
        new JdeField("JIJVCCEX", "JIJVCCEX", JdeDataType.Numeric),
        new JdeField("JIJVODAA", "JIJVODAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J12_0", "Primary Key on JIDCT, JIDOC, JIKCO, JIDGJ, JIJELN, JILT, JIEXTL, JIJVIBU, JIJVAN8, JIJVDLN, JIJVVOID, JIJVSNU1", new[] { "JIDCT", "JIDOC", "JIKCO", "JIDGJ", "JIJELN", "JILT", "JIEXTL", "JIJVIBU", "JIJVAN8", "JIJVDLN", "JIJVVOID", "JIJVSNU1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J12_2", "Index on JIJVNAME, JIJVIBU, JIJVAN8", new[] { "JIJVNAME", "JIJVIBU", "JIJVAN8" }),
        new JdeIndex("F09J12_3", "Index on JIJVIBU, JIJVAN8, JIJVNAME, SYS_NC00094$, JIDCT, JIDOC, JIKCO, SYS_NC00095$, JIJELN, JIEXTL, JILT, JIJVDLN", new[] { "JIJVIBU", "JIJVAN8", "JIJVNAME", "SYS_NC00094$", "JIDCT", "JIDOC", "JIKCO", "SYS_NC00095$", "JIJELN", "JIEXTL", "JILT", "JIJVDLN" }),
        new JdeIndex("F09J12_4", "Index on JIDOC, JIKCO, JIDCT, JIDGJ, JIJELN, JILT", new[] { "JIDOC", "JIKCO", "JIDCT", "JIDGJ", "JIJELN", "JILT" }),
        new JdeIndex("F09J12_5", "Index on JIJVDOC, JIJVDCT, JIJVKCO, JIJVVOID, JIJVDGJ, JIJVSFX, JIJVSFXE, JIJVJELN, JIJVLT, JIJVEXTL", new[] { "JIJVDOC", "JIJVDCT", "JIJVKCO", "JIJVVOID", "JIJVDGJ", "JIJVSFX", "JIJVSFXE", "JIJVJELN", "JIJVLT", "JIJVEXTL" }),
        new JdeIndex("F09J12_6", "Index on JIJVCCID, JIJVVOID, JIJVTSTS", new[] { "JIJVCCID", "JIJVVOID", "JIJVTSTS" }),
        new JdeIndex("F09J12_7", "Index on JIJVCCEX, JIJVTSTS", new[] { "JIJVCCEX", "JIJVTSTS" })
    };
}
