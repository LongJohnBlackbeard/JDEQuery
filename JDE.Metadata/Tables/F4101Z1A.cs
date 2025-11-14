using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101Z1A - .
/// </summary>
public class F4101Z1A : JdeTable
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
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZITBR.
        /// </summary>
        public const string SZITBR = "SZITBR";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZKIT.
        /// </summary>
        public const string SZKIT = "SZKIT";

        /// <summary>
        /// SZNMFC.
        /// </summary>
        public const string SZNMFC = "SZNMFC";

        /// <summary>
        /// SZNMFI.
        /// </summary>
        public const string SZNMFI = "SZNMFI";

        /// <summary>
        /// SZSTCC.
        /// </summary>
        public const string SZSTCC = "SZSTCC";

        /// <summary>
        /// SZFRT1.
        /// </summary>
        public const string SZFRT1 = "SZFRT1";

        /// <summary>
        /// SZFRT2.
        /// </summary>
        public const string SZFRT2 = "SZFRT2";

        /// <summary>
        /// SZHSCD.
        /// </summary>
        public const string SZHSCD = "SZHSCD";

        /// <summary>
        /// SZPDCG.
        /// </summary>
        public const string SZPDCG = "SZPDCG";

        /// <summary>
        /// SZRETPOL.
        /// </summary>
        public const string SZRETPOL = "SZRETPOL";

        /// <summary>
        /// SZSRYN.
        /// </summary>
        public const string SZSRYN = "SZSRYN";

        /// <summary>
        /// SZIBYN.
        /// </summary>
        public const string SZIBYN = "SZIBYN";

        /// <summary>
        /// SZPFCT.
        /// </summary>
        public const string SZPFCT = "SZPFCT";

        /// <summary>
        /// SZECCN.
        /// </summary>
        public const string SZECCN = "SZECCN";

        /// <summary>
        /// SZDMFR.
        /// </summary>
        public const string SZDMFR = "SZDMFR";

        /// <summary>
        /// SZUNNA.
        /// </summary>
        public const string SZUNNA = "SZUNNA";

        /// <summary>
        /// SZHZDC.
        /// </summary>
        public const string SZHZDC = "SZHZDC";

        /// <summary>
        /// SZHZDL.
        /// </summary>
        public const string SZHZDL = "SZHZDL";

        /// <summary>
        /// SZFPNT.
        /// </summary>
        public const string SZFPNT = "SZFPNT";

        /// <summary>
        /// SZSTPU.
        /// </summary>
        public const string SZSTPU = "SZSTPU";

        /// <summary>
        /// SZPKGP.
        /// </summary>
        public const string SZPKGP = "SZPKGP";

        /// <summary>
        /// SZPKIN.
        /// </summary>
        public const string SZPKIN = "SZPKIN";

        /// <summary>
        /// SZSRSK.
        /// </summary>
        public const string SZSRSK = "SZSRSK";

        /// <summary>
        /// SZPDGR.
        /// </summary>
        public const string SZPDGR = "SZPDGR";

        /// <summary>
        /// SZDSGP.
        /// </summary>
        public const string SZDSGP = "SZDSGP";

        /// <summary>
        /// SZDNTB.
        /// </summary>
        public const string SZDNTB = "SZDNTB";

        /// <summary>
        /// SZSTCN.
        /// </summary>
        public const string SZSTCN = "SZSTCN";

        /// <summary>
        /// SZRPTM.
        /// </summary>
        public const string SZRPTM = "SZRPTM";

        /// <summary>
        /// SZRQTC.
        /// </summary>
        public const string SZRQTC = "SZRQTC";

        /// <summary>
        /// SZLPGP.
        /// </summary>
        public const string SZLPGP = "SZLPGP";

        /// <summary>
        /// SZCAVP.
        /// </summary>
        public const string SZCAVP = "SZCAVP";

        /// <summary>
        /// SZDNTY.
        /// </summary>
        public const string SZDNTY = "SZDNTY";

        /// <summary>
        /// SZDNTP.
        /// </summary>
        public const string SZDNTP = "SZDNTP";

        /// <summary>
        /// SZDETP.
        /// </summary>
        public const string SZDETP = "SZDETP";

        /// <summary>
        /// SZDTPU.
        /// </summary>
        public const string SZDTPU = "SZDTPU";

        /// <summary>
        /// SZCOEX.
        /// </summary>
        public const string SZCOEX = "SZCOEX";

        /// <summary>
        /// SZTMMN.
        /// </summary>
        public const string SZTMMN = "SZTMMN";

        /// <summary>
        /// SZTPUM.
        /// </summary>
        public const string SZTPUM = "SZTPUM";

        /// <summary>
        /// SZTMMX.
        /// </summary>
        public const string SZTMMX = "SZTMMX";

        /// <summary>
        /// SZTPUX.
        /// </summary>
        public const string SZTPUX = "SZTPUX";

        /// <summary>
        /// SZDSMN.
        /// </summary>
        public const string SZDSMN = "SZDSMN";

        /// <summary>
        /// SZDNTM.
        /// </summary>
        public const string SZDNTM = "SZDNTM";

        /// <summary>
        /// SZDNMX.
        /// </summary>
        public const string SZDNMX = "SZDNMX";

        /// <summary>
        /// SZDNTX.
        /// </summary>
        public const string SZDNTX = "SZDNTX";

        /// <summary>
        /// SZLPGV.
        /// </summary>
        public const string SZLPGV = "SZLPGV";

        /// <summary>
        /// SZTPU1.
        /// </summary>
        public const string SZTPU1 = "SZTPU1";

        /// <summary>
        /// SZMNVC.
        /// </summary>
        public const string SZMNVC = "SZMNVC";

        /// <summary>
        /// SZMXVC.
        /// </summary>
        public const string SZMXVC = "SZMXVC";

        /// <summary>
        /// SZRTOB.
        /// </summary>
        public const string SZRTOB = "SZRTOB";

        /// <summary>
        /// SZPRODM.
        /// </summary>
        public const string SZPRODM = "SZPRODM";

        /// <summary>
        /// SZPRODF.
        /// </summary>
        public const string SZPRODF = "SZPRODF";

        /// <summary>
        /// SZMCUZ.
        /// </summary>
        public const string SZMCUZ = "SZMCUZ";

        /// <summary>
        /// SZDCD1.
        /// </summary>
        public const string SZDCD1 = "SZDCD1";

        /// <summary>
        /// SZDCD2.
        /// </summary>
        public const string SZDCD2 = "SZDCD2";

        /// <summary>
        /// SZDCD3.
        /// </summary>
        public const string SZDCD3 = "SZDCD3";

        /// <summary>
        /// SZDCD4.
        /// </summary>
        public const string SZDCD4 = "SZDCD4";

        /// <summary>
        /// SZDCD5.
        /// </summary>
        public const string SZDCD5 = "SZDCD5";

        /// <summary>
        /// SZCRTU.
        /// </summary>
        public const string SZCRTU = "SZCRTU";

        /// <summary>
        /// SZRPRBL.
        /// </summary>
        public const string SZRPRBL = "SZRPRBL";

        /// <summary>
        /// SZRTRND.
        /// </summary>
        public const string SZRTRND = "SZRTRND";

        /// <summary>
        /// SZCCOST.
        /// </summary>
        public const string SZCCOST = "SZCCOST";

        /// <summary>
        /// SZSTVL.
        /// </summary>
        public const string SZSTVL = "SZSTVL";

        /// <summary>
        /// SZBUM0.
        /// </summary>
        public const string SZBUM0 = "SZBUM0";

        /// <summary>
        /// SZLRFG.
        /// </summary>
        public const string SZLRFG = "SZLRFG";

        /// <summary>
        /// SZHCOR.
        /// </summary>
        public const string SZHCOR = "SZHCOR";

        /// <summary>
        /// SZACOR.
        /// </summary>
        public const string SZACOR = "SZACOR";

        /// <summary>
        /// SZABBL.
        /// </summary>
        public const string SZABBL = "SZABBL";

        /// <summary>
        /// SZATWH.
        /// </summary>
        public const string SZATWH = "SZATWH";

        /// <summary>
        /// SZRPLT.
        /// </summary>
        public const string SZRPLT = "SZRPLT";

        /// <summary>
        /// SZBCAT.
        /// </summary>
        public const string SZBCAT = "SZBCAT";

        /// <summary>
        /// SZFCAT.
        /// </summary>
        public const string SZFCAT = "SZFCAT";

        /// <summary>
        /// SZRECD.
        /// </summary>
        public const string SZRECD = "SZRECD";

        /// <summary>
        /// SZMLIT.
        /// </summary>
        public const string SZMLIT = "SZMLIT";

        /// <summary>
        /// SZMLOT.
        /// </summary>
        public const string SZMLOT = "SZMLOT";

        /// <summary>
        /// SZSPLP.
        /// </summary>
        public const string SZSPLP = "SZSPLP";

        /// <summary>
        /// SZPTPH.
        /// </summary>
        public const string SZPTPH = "SZPTPH";

        /// <summary>
        /// SZPKPH.
        /// </summary>
        public const string SZPKPH = "SZPKPH";

        /// <summary>
        /// SZRPPH.
        /// </summary>
        public const string SZRPPH = "SZRPPH";

        /// <summary>
        /// SZDEFI.
        /// </summary>
        public const string SZDEFI = "SZDEFI";

        /// <summary>
        /// SZLCOD.
        /// </summary>
        public const string SZLCOD = "SZLCOD";

        /// <summary>
        /// SZDLTN.
        /// </summary>
        public const string SZDLTN = "SZDLTN";

        /// <summary>
        /// SZVLOC.
        /// </summary>
        public const string SZVLOC = "SZVLOC";

        /// <summary>
        /// SZHLOC.
        /// </summary>
        public const string SZHLOC = "SZHLOC";

        /// <summary>
        /// SZPPUT.
        /// </summary>
        public const string SZPPUT = "SZPPUT";

        /// <summary>
        /// SZPPIK.
        /// </summary>
        public const string SZPPIK = "SZPPIK";

        /// <summary>
        /// SZPRLC.
        /// </summary>
        public const string SZPRLC = "SZPRLC";

        /// <summary>
        /// SZMPTL.
        /// </summary>
        public const string SZMPTL = "SZMPTL";

        /// <summary>
        /// SZMUMS.
        /// </summary>
        public const string SZMUMS = "SZMUMS";

        /// <summary>
        /// SZFIFR.
        /// </summary>
        public const string SZFIFR = "SZFIFR";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZSTAW.
        /// </summary>
        public const string SZSTAW = "SZSTAW";

        /// <summary>
        /// SZEFFT.
        /// </summary>
        public const string SZEFFT = "SZEFFT";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4101Z1A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZITBR", "SZITBR", JdeDataType.String, 2),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZKIT", "SZKIT", JdeDataType.Numeric),
        new JdeField("SZNMFC", "SZNMFC", JdeDataType.String, 8),
        new JdeField("SZNMFI", "SZNMFI", JdeDataType.String, 12),
        new JdeField("SZSTCC", "SZSTCC", JdeDataType.String, 20),
        new JdeField("SZFRT1", "SZFRT1", JdeDataType.String, 12),
        new JdeField("SZFRT2", "SZFRT2", JdeDataType.String, 12),
        new JdeField("SZHSCD", "SZHSCD", JdeDataType.String, 24),
        new JdeField("SZPDCG", "SZPDCG", JdeDataType.String, 8),
        new JdeField("SZRETPOL", "SZRETPOL", JdeDataType.String, 2),
        new JdeField("SZSRYN", "SZSRYN", JdeDataType.String, 2),
        new JdeField("SZIBYN", "SZIBYN", JdeDataType.String, 2),
        new JdeField("SZPFCT", "SZPFCT", JdeDataType.String, 2),
        new JdeField("SZECCN", "SZECCN", JdeDataType.String, 20),
        new JdeField("SZDMFR", "SZDMFR", JdeDataType.String, 2),
        new JdeField("SZUNNA", "SZUNNA", JdeDataType.String, 12),
        new JdeField("SZHZDC", "SZHZDC", JdeDataType.String, 6),
        new JdeField("SZHZDL", "SZHZDL", JdeDataType.String, 6),
        new JdeField("SZFPNT", "SZFPNT", JdeDataType.Numeric),
        new JdeField("SZSTPU", "SZSTPU", JdeDataType.String, 2),
        new JdeField("SZPKGP", "SZPKGP", JdeDataType.String, 6),
        new JdeField("SZPKIN", "SZPKIN", JdeDataType.String, 8),
        new JdeField("SZSRSK", "SZSRSK", JdeDataType.String, 6),
        new JdeField("SZPDGR", "SZPDGR", JdeDataType.String, 6),
        new JdeField("SZDSGP", "SZDSGP", JdeDataType.String, 6),
        new JdeField("SZDNTB", "SZDNTB", JdeDataType.String, 8),
        new JdeField("SZSTCN", "SZSTCN", JdeDataType.String, 8),
        new JdeField("SZRPTM", "SZRPTM", JdeDataType.String, 8),
        new JdeField("SZRQTC", "SZRQTC", JdeDataType.String, 2),
        new JdeField("SZLPGP", "SZLPGP", JdeDataType.String, 2),
        new JdeField("SZCAVP", "SZCAVP", JdeDataType.String, 2),
        new JdeField("SZDNTY", "SZDNTY", JdeDataType.Numeric),
        new JdeField("SZDNTP", "SZDNTP", JdeDataType.String, 2),
        new JdeField("SZDETP", "SZDETP", JdeDataType.Numeric),
        new JdeField("SZDTPU", "SZDTPU", JdeDataType.String, 2),
        new JdeField("SZCOEX", "SZCOEX", JdeDataType.Numeric),
        new JdeField("SZTMMN", "SZTMMN", JdeDataType.Numeric),
        new JdeField("SZTPUM", "SZTPUM", JdeDataType.String, 2),
        new JdeField("SZTMMX", "SZTMMX", JdeDataType.Numeric),
        new JdeField("SZTPUX", "SZTPUX", JdeDataType.String, 2),
        new JdeField("SZDSMN", "SZDSMN", JdeDataType.Numeric),
        new JdeField("SZDNTM", "SZDNTM", JdeDataType.String, 2),
        new JdeField("SZDNMX", "SZDNMX", JdeDataType.Numeric),
        new JdeField("SZDNTX", "SZDNTX", JdeDataType.String, 2),
        new JdeField("SZLPGV", "SZLPGV", JdeDataType.Numeric),
        new JdeField("SZTPU1", "SZTPU1", JdeDataType.String, 2),
        new JdeField("SZMNVC", "SZMNVC", JdeDataType.Numeric),
        new JdeField("SZMXVC", "SZMXVC", JdeDataType.Numeric),
        new JdeField("SZRTOB", "SZRTOB", JdeDataType.String, 2),
        new JdeField("SZPRODM", "SZPRODM", JdeDataType.String, 16),
        new JdeField("SZPRODF", "SZPRODF", JdeDataType.String, 16),
        new JdeField("SZMCUZ", "SZMCUZ", JdeDataType.String, 24),
        new JdeField("SZDCD1", "SZDCD1", JdeDataType.String, 6),
        new JdeField("SZDCD2", "SZDCD2", JdeDataType.String, 6),
        new JdeField("SZDCD3", "SZDCD3", JdeDataType.String, 6),
        new JdeField("SZDCD4", "SZDCD4", JdeDataType.String, 6),
        new JdeField("SZDCD5", "SZDCD5", JdeDataType.String, 6),
        new JdeField("SZCRTU", "SZCRTU", JdeDataType.String, 20),
        new JdeField("SZRPRBL", "SZRPRBL", JdeDataType.String, 2),
        new JdeField("SZRTRND", "SZRTRND", JdeDataType.String, 2),
        new JdeField("SZCCOST", "SZCCOST", JdeDataType.String, 6),
        new JdeField("SZSTVL", "SZSTVL", JdeDataType.Numeric),
        new JdeField("SZBUM0", "SZBUM0", JdeDataType.String, 4),
        new JdeField("SZLRFG", "SZLRFG", JdeDataType.String, 2),
        new JdeField("SZHCOR", "SZHCOR", JdeDataType.String, 2),
        new JdeField("SZACOR", "SZACOR", JdeDataType.String, 2),
        new JdeField("SZABBL", "SZABBL", JdeDataType.String, 2),
        new JdeField("SZATWH", "SZATWH", JdeDataType.String, 2),
        new JdeField("SZRPLT", "SZRPLT", JdeDataType.String, 6),
        new JdeField("SZBCAT", "SZBCAT", JdeDataType.String, 6),
        new JdeField("SZFCAT", "SZFCAT", JdeDataType.String, 6),
        new JdeField("SZRECD", "SZRECD", JdeDataType.Numeric),
        new JdeField("SZMLIT", "SZMLIT", JdeDataType.String, 2),
        new JdeField("SZMLOT", "SZMLOT", JdeDataType.String, 2),
        new JdeField("SZSPLP", "SZSPLP", JdeDataType.String, 2),
        new JdeField("SZPTPH", "SZPTPH", JdeDataType.String, 2),
        new JdeField("SZPKPH", "SZPKPH", JdeDataType.String, 2),
        new JdeField("SZRPPH", "SZRPPH", JdeDataType.String, 2),
        new JdeField("SZDEFI", "SZDEFI", JdeDataType.String, 20),
        new JdeField("SZLCOD", "SZLCOD", JdeDataType.String, 4),
        new JdeField("SZDLTN", "SZDLTN", JdeDataType.String, 40),
        new JdeField("SZVLOC", "SZVLOC", JdeDataType.String, 40),
        new JdeField("SZHLOC", "SZHLOC", JdeDataType.String, 40),
        new JdeField("SZPPUT", "SZPPUT", JdeDataType.String, 40),
        new JdeField("SZPPIK", "SZPPIK", JdeDataType.String, 40),
        new JdeField("SZPRLC", "SZPRLC", JdeDataType.String, 40),
        new JdeField("SZMPTL", "SZMPTL", JdeDataType.String, 2),
        new JdeField("SZMUMS", "SZMUMS", JdeDataType.String, 2),
        new JdeField("SZFIFR", "SZFIFR", JdeDataType.String, 2),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZSTAW", "SZSTAW", JdeDataType.String, 2),
        new JdeField("SZEFFT", "SZEFFT", JdeDataType.Numeric),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101Z1A_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
