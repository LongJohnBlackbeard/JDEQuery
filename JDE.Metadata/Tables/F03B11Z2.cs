using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B11Z2 - .
/// </summary>
public class F03B11Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYTYTN.
        /// </summary>
        public const string SYTYTN = "SYTYTN";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYDRIN.
        /// </summary>
        public const string SYDRIN = "SYDRIN";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYDOC.
        /// </summary>
        public const string SYDOC = "SYDOC";

        /// <summary>
        /// SYDCT.
        /// </summary>
        public const string SYDCT = "SYDCT";

        /// <summary>
        /// SYKCO.
        /// </summary>
        public const string SYKCO = "SYKCO";

        /// <summary>
        /// SYSFX.
        /// </summary>
        public const string SYSFX = "SYSFX";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYDGJ.
        /// </summary>
        public const string SYDGJ = "SYDGJ";

        /// <summary>
        /// SYDIVJ.
        /// </summary>
        public const string SYDIVJ = "SYDIVJ";

        /// <summary>
        /// SYICUT.
        /// </summary>
        public const string SYICUT = "SYICUT";

        /// <summary>
        /// SYICU.
        /// </summary>
        public const string SYICU = "SYICU";

        /// <summary>
        /// SYDICJ.
        /// </summary>
        public const string SYDICJ = "SYDICJ";

        /// <summary>
        /// SYFY.
        /// </summary>
        public const string SYFY = "SYFY";

        /// <summary>
        /// SYCTRY.
        /// </summary>
        public const string SYCTRY = "SYCTRY";

        /// <summary>
        /// SYPN.
        /// </summary>
        public const string SYPN = "SYPN";

        /// <summary>
        /// SYCO.
        /// </summary>
        public const string SYCO = "SYCO";

        /// <summary>
        /// SYGLC.
        /// </summary>
        public const string SYGLC = "SYGLC";

        /// <summary>
        /// SYAID.
        /// </summary>
        public const string SYAID = "SYAID";

        /// <summary>
        /// SYPA8.
        /// </summary>
        public const string SYPA8 = "SYPA8";

        /// <summary>
        /// SYAN8J.
        /// </summary>
        public const string SYAN8J = "SYAN8J";

        /// <summary>
        /// SYPYR.
        /// </summary>
        public const string SYPYR = "SYPYR";

        /// <summary>
        /// SYPOST.
        /// </summary>
        public const string SYPOST = "SYPOST";

        /// <summary>
        /// SYISTR.
        /// </summary>
        public const string SYISTR = "SYISTR";

        /// <summary>
        /// SYBALJ.
        /// </summary>
        public const string SYBALJ = "SYBALJ";

        /// <summary>
        /// SYPST.
        /// </summary>
        public const string SYPST = "SYPST";

        /// <summary>
        /// SYAG.
        /// </summary>
        public const string SYAG = "SYAG";

        /// <summary>
        /// SYAAP.
        /// </summary>
        public const string SYAAP = "SYAAP";

        /// <summary>
        /// SYADSC.
        /// </summary>
        public const string SYADSC = "SYADSC";

        /// <summary>
        /// SYADSA.
        /// </summary>
        public const string SYADSA = "SYADSA";

        /// <summary>
        /// SYATXA.
        /// </summary>
        public const string SYATXA = "SYATXA";

        /// <summary>
        /// SYATXN.
        /// </summary>
        public const string SYATXN = "SYATXN";

        /// <summary>
        /// SYSTAM.
        /// </summary>
        public const string SYSTAM = "SYSTAM";

        /// <summary>
        /// SYBCRC.
        /// </summary>
        public const string SYBCRC = "SYBCRC";

        /// <summary>
        /// SYCRRM.
        /// </summary>
        public const string SYCRRM = "SYCRRM";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRR.
        /// </summary>
        public const string SYCRR = "SYCRR";

        /// <summary>
        /// SYDMCD.
        /// </summary>
        public const string SYDMCD = "SYDMCD";

        /// <summary>
        /// SYACR.
        /// </summary>
        public const string SYACR = "SYACR";

        /// <summary>
        /// SYFAP.
        /// </summary>
        public const string SYFAP = "SYFAP";

        /// <summary>
        /// SYCDS.
        /// </summary>
        public const string SYCDS = "SYCDS";

        /// <summary>
        /// SYCDSA.
        /// </summary>
        public const string SYCDSA = "SYCDSA";

        /// <summary>
        /// SYCTXA.
        /// </summary>
        public const string SYCTXA = "SYCTXA";

        /// <summary>
        /// SYCTXN.
        /// </summary>
        public const string SYCTXN = "SYCTXN";

        /// <summary>
        /// SYCTAM.
        /// </summary>
        public const string SYCTAM = "SYCTAM";

        /// <summary>
        /// SYTXA1.
        /// </summary>
        public const string SYTXA1 = "SYTXA1";

        /// <summary>
        /// SYEXR1.
        /// </summary>
        public const string SYEXR1 = "SYEXR1";

        /// <summary>
        /// SYDSVJ.
        /// </summary>
        public const string SYDSVJ = "SYDSVJ";

        /// <summary>
        /// SYGLBA.
        /// </summary>
        public const string SYGLBA = "SYGLBA";

        /// <summary>
        /// SYAM.
        /// </summary>
        public const string SYAM = "SYAM";

        /// <summary>
        /// SYAID2.
        /// </summary>
        public const string SYAID2 = "SYAID2";

        /// <summary>
        /// SYAM2.
        /// </summary>
        public const string SYAM2 = "SYAM2";

        /// <summary>
        /// SYMCU.
        /// </summary>
        public const string SYMCU = "SYMCU";

        /// <summary>
        /// SYOBJ.
        /// </summary>
        public const string SYOBJ = "SYOBJ";

        /// <summary>
        /// SYSUB.
        /// </summary>
        public const string SYSUB = "SYSUB";

        /// <summary>
        /// SYSBLT.
        /// </summary>
        public const string SYSBLT = "SYSBLT";

        /// <summary>
        /// SYSBL.
        /// </summary>
        public const string SYSBL = "SYSBL";

        /// <summary>
        /// SYPTC.
        /// </summary>
        public const string SYPTC = "SYPTC";

        /// <summary>
        /// SYDDJ.
        /// </summary>
        public const string SYDDJ = "SYDDJ";

        /// <summary>
        /// SYDDNJ.
        /// </summary>
        public const string SYDDNJ = "SYDDNJ";

        /// <summary>
        /// SYRDDJ.
        /// </summary>
        public const string SYRDDJ = "SYRDDJ";

        /// <summary>
        /// SYRDSJ.
        /// </summary>
        public const string SYRDSJ = "SYRDSJ";

        /// <summary>
        /// SYLFCJ.
        /// </summary>
        public const string SYLFCJ = "SYLFCJ";

        /// <summary>
        /// SYSMTJ.
        /// </summary>
        public const string SYSMTJ = "SYSMTJ";

        /// <summary>
        /// SYNBRR.
        /// </summary>
        public const string SYNBRR = "SYNBRR";

        /// <summary>
        /// SYRDRL.
        /// </summary>
        public const string SYRDRL = "SYRDRL";

        /// <summary>
        /// SYRMDS.
        /// </summary>
        public const string SYRMDS = "SYRMDS";

        /// <summary>
        /// SYCOLL.
        /// </summary>
        public const string SYCOLL = "SYCOLL";

        /// <summary>
        /// SYCORC.
        /// </summary>
        public const string SYCORC = "SYCORC";

        /// <summary>
        /// SYAFC.
        /// </summary>
        public const string SYAFC = "SYAFC";

        /// <summary>
        /// SYDNLT.
        /// </summary>
        public const string SYDNLT = "SYDNLT";

        /// <summary>
        /// SYRSCO.
        /// </summary>
        public const string SYRSCO = "SYRSCO";

        /// <summary>
        /// SYODOC.
        /// </summary>
        public const string SYODOC = "SYODOC";

        /// <summary>
        /// SYODCT.
        /// </summary>
        public const string SYODCT = "SYODCT";

        /// <summary>
        /// SYOKCO.
        /// </summary>
        public const string SYOKCO = "SYOKCO";

        /// <summary>
        /// SYOSFX.
        /// </summary>
        public const string SYOSFX = "SYOSFX";

        /// <summary>
        /// SYVINV.
        /// </summary>
        public const string SYVINV = "SYVINV";

        /// <summary>
        /// SYPO.
        /// </summary>
        public const string SYPO = "SYPO";

        /// <summary>
        /// SYPDCT.
        /// </summary>
        public const string SYPDCT = "SYPDCT";

        /// <summary>
        /// SYPKCO.
        /// </summary>
        public const string SYPKCO = "SYPKCO";

        /// <summary>
        /// SYDCTO.
        /// </summary>
        public const string SYDCTO = "SYDCTO";

        /// <summary>
        /// SYLNID.
        /// </summary>
        public const string SYLNID = "SYLNID";

        /// <summary>
        /// SYSDOC.
        /// </summary>
        public const string SYSDOC = "SYSDOC";

        /// <summary>
        /// SYSDCT.
        /// </summary>
        public const string SYSDCT = "SYSDCT";

        /// <summary>
        /// SYSKCO.
        /// </summary>
        public const string SYSKCO = "SYSKCO";

        /// <summary>
        /// SYSFXO.
        /// </summary>
        public const string SYSFXO = "SYSFXO";

        /// <summary>
        /// SYVLDT.
        /// </summary>
        public const string SYVLDT = "SYVLDT";

        /// <summary>
        /// SYCMC1.
        /// </summary>
        public const string SYCMC1 = "SYCMC1";

        /// <summary>
        /// SYVR01.
        /// </summary>
        public const string SYVR01 = "SYVR01";

        /// <summary>
        /// SYUNIT.
        /// </summary>
        public const string SYUNIT = "SYUNIT";

        /// <summary>
        /// SYMCU2.
        /// </summary>
        public const string SYMCU2 = "SYMCU2";

        /// <summary>
        /// SYRMK.
        /// </summary>
        public const string SYRMK = "SYRMK";

        /// <summary>
        /// SYALPH.
        /// </summary>
        public const string SYALPH = "SYALPH";

        /// <summary>
        /// SYRF.
        /// </summary>
        public const string SYRF = "SYRF";

        /// <summary>
        /// SYDRF.
        /// </summary>
        public const string SYDRF = "SYDRF";

        /// <summary>
        /// SYCTL.
        /// </summary>
        public const string SYCTL = "SYCTL";

        /// <summary>
        /// SYFNLP.
        /// </summary>
        public const string SYFNLP = "SYFNLP";

        /// <summary>
        /// SYITM.
        /// </summary>
        public const string SYITM = "SYITM";

        /// <summary>
        /// SYU.
        /// </summary>
        public const string SYU = "SYU";

        /// <summary>
        /// SYUM.
        /// </summary>
        public const string SYUM = "SYUM";

        /// <summary>
        /// SYALT6.
        /// </summary>
        public const string SYALT6 = "SYALT6";

        /// <summary>
        /// SYRYIN.
        /// </summary>
        public const string SYRYIN = "SYRYIN";

        /// <summary>
        /// SYVDGJ.
        /// </summary>
        public const string SYVDGJ = "SYVDGJ";

        /// <summary>
        /// SYVOD.
        /// </summary>
        public const string SYVOD = "SYVOD";

        /// <summary>
        /// SYRP1.
        /// </summary>
        public const string SYRP1 = "SYRP1";

        /// <summary>
        /// SYRP2.
        /// </summary>
        public const string SYRP2 = "SYRP2";

        /// <summary>
        /// SYRP3.
        /// </summary>
        public const string SYRP3 = "SYRP3";

        /// <summary>
        /// SYAR01.
        /// </summary>
        public const string SYAR01 = "SYAR01";

        /// <summary>
        /// SYAR02.
        /// </summary>
        public const string SYAR02 = "SYAR02";

        /// <summary>
        /// SYAR03.
        /// </summary>
        public const string SYAR03 = "SYAR03";

        /// <summary>
        /// SYAR04.
        /// </summary>
        public const string SYAR04 = "SYAR04";

        /// <summary>
        /// SYAR05.
        /// </summary>
        public const string SYAR05 = "SYAR05";

        /// <summary>
        /// SYAR06.
        /// </summary>
        public const string SYAR06 = "SYAR06";

        /// <summary>
        /// SYAR07.
        /// </summary>
        public const string SYAR07 = "SYAR07";

        /// <summary>
        /// SYAR08.
        /// </summary>
        public const string SYAR08 = "SYAR08";

        /// <summary>
        /// SYAR09.
        /// </summary>
        public const string SYAR09 = "SYAR09";

        /// <summary>
        /// SYAR10.
        /// </summary>
        public const string SYAR10 = "SYAR10";

        /// <summary>
        /// SYISTC.
        /// </summary>
        public const string SYISTC = "SYISTC";

        /// <summary>
        /// SYPYID.
        /// </summary>
        public const string SYPYID = "SYPYID";

        /// <summary>
        /// SYRNID.
        /// </summary>
        public const string SYRNID = "SYRNID";

        /// <summary>
        /// SYPPDI.
        /// </summary>
        public const string SYPPDI = "SYPPDI";

        /// <summary>
        /// SYJCL.
        /// </summary>
        public const string SYJCL = "SYJCL";

        /// <summary>
        /// SYDDEX.
        /// </summary>
        public const string SYDDEX = "SYDDEX";

        /// <summary>
        /// SYHCRR.
        /// </summary>
        public const string SYHCRR = "SYHCRR";

        /// <summary>
        /// SYHDGJ.
        /// </summary>
        public const string SYHDGJ = "SYHDGJ";

        /// <summary>
        /// SYDCP.
        /// </summary>
        public const string SYDCP = "SYDCP";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYSHPN.
        /// </summary>
        public const string SYSHPN = "SYSHPN";

        /// <summary>
        /// SYDTXS.
        /// </summary>
        public const string SYDTXS = "SYDTXS";

        /// <summary>
        /// SYOMOD.
        /// </summary>
        public const string SYOMOD = "SYOMOD";

        /// <summary>
        /// SYCLMG.
        /// </summary>
        public const string SYCLMG = "SYCLMG";

        /// <summary>
        /// SYCMGR.
        /// </summary>
        public const string SYCMGR = "SYCMGR";

        /// <summary>
        /// SYATAD.
        /// </summary>
        public const string SYATAD = "SYATAD";

        /// <summary>
        /// SYCTAD.
        /// </summary>
        public const string SYCTAD = "SYCTAD";

        /// <summary>
        /// SYNRTA.
        /// </summary>
        public const string SYNRTA = "SYNRTA";

        /// <summary>
        /// SYFNRT.
        /// </summary>
        public const string SYFNRT = "SYFNRT";

        /// <summary>
        /// SYPRGF.
        /// </summary>
        public const string SYPRGF = "SYPRGF";

        /// <summary>
        /// SYGFL1.
        /// </summary>
        public const string SYGFL1 = "SYGFL1";

        /// <summary>
        /// SYGFL2.
        /// </summary>
        public const string SYGFL2 = "SYGFL2";

        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYKCOO.
        /// </summary>
        public const string SYKCOO = "SYKCOO";

        /// <summary>
        /// SYSOTF.
        /// </summary>
        public const string SYSOTF = "SYSOTF";

        /// <summary>
        /// SYDTPB.
        /// </summary>
        public const string SYDTPB = "SYDTPB";

        /// <summary>
        /// SYERDJ.
        /// </summary>
        public const string SYERDJ = "SYERDJ";

        /// <summary>
        /// SYPWPG.
        /// </summary>
        public const string SYPWPG = "SYPWPG";

        /// <summary>
        /// SYNETTCID.
        /// </summary>
        public const string SYNETTCID = "SYNETTCID";

        /// <summary>
        /// SYNETDOC.
        /// </summary>
        public const string SYNETDOC = "SYNETDOC";

        /// <summary>
        /// SYNETRC5.
        /// </summary>
        public const string SYNETRC5 = "SYNETRC5";

        /// <summary>
        /// SYNETST.
        /// </summary>
        public const string SYNETST = "SYNETST";

        /// <summary>
        /// SYAJCL.
        /// </summary>
        public const string SYAJCL = "SYAJCL";

        /// <summary>
        /// SYRMR1.
        /// </summary>
        public const string SYRMR1 = "SYRMR1";
    }

    /// <inheritdoc />
    public override string TableName => "F03B11Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYDOC", "SYDOC", JdeDataType.Numeric),
        new JdeField("SYDCT", "SYDCT", JdeDataType.String, 4),
        new JdeField("SYKCO", "SYKCO", JdeDataType.String, 10),
        new JdeField("SYSFX", "SYSFX", JdeDataType.String, 6),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYDGJ", "SYDGJ", JdeDataType.Numeric),
        new JdeField("SYDIVJ", "SYDIVJ", JdeDataType.Numeric),
        new JdeField("SYICUT", "SYICUT", JdeDataType.String, 4),
        new JdeField("SYICU", "SYICU", JdeDataType.Numeric),
        new JdeField("SYDICJ", "SYDICJ", JdeDataType.Numeric),
        new JdeField("SYFY", "SYFY", JdeDataType.Numeric),
        new JdeField("SYCTRY", "SYCTRY", JdeDataType.Numeric),
        new JdeField("SYPN", "SYPN", JdeDataType.Numeric),
        new JdeField("SYCO", "SYCO", JdeDataType.String, 10),
        new JdeField("SYGLC", "SYGLC", JdeDataType.String, 8),
        new JdeField("SYAID", "SYAID", JdeDataType.String, 16),
        new JdeField("SYPA8", "SYPA8", JdeDataType.Numeric),
        new JdeField("SYAN8J", "SYAN8J", JdeDataType.Numeric),
        new JdeField("SYPYR", "SYPYR", JdeDataType.Numeric),
        new JdeField("SYPOST", "SYPOST", JdeDataType.String, 2),
        new JdeField("SYISTR", "SYISTR", JdeDataType.String, 2),
        new JdeField("SYBALJ", "SYBALJ", JdeDataType.String, 2),
        new JdeField("SYPST", "SYPST", JdeDataType.String, 2),
        new JdeField("SYAG", "SYAG", JdeDataType.Numeric),
        new JdeField("SYAAP", "SYAAP", JdeDataType.Numeric),
        new JdeField("SYADSC", "SYADSC", JdeDataType.Numeric),
        new JdeField("SYADSA", "SYADSA", JdeDataType.Numeric),
        new JdeField("SYATXA", "SYATXA", JdeDataType.Numeric),
        new JdeField("SYATXN", "SYATXN", JdeDataType.Numeric),
        new JdeField("SYSTAM", "SYSTAM", JdeDataType.Numeric),
        new JdeField("SYBCRC", "SYBCRC", JdeDataType.String, 6),
        new JdeField("SYCRRM", "SYCRRM", JdeDataType.String, 2),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRR", "SYCRR", JdeDataType.Numeric),
        new JdeField("SYDMCD", "SYDMCD", JdeDataType.String, 2),
        new JdeField("SYACR", "SYACR", JdeDataType.Numeric),
        new JdeField("SYFAP", "SYFAP", JdeDataType.Numeric),
        new JdeField("SYCDS", "SYCDS", JdeDataType.Numeric),
        new JdeField("SYCDSA", "SYCDSA", JdeDataType.Numeric),
        new JdeField("SYCTXA", "SYCTXA", JdeDataType.Numeric),
        new JdeField("SYCTXN", "SYCTXN", JdeDataType.Numeric),
        new JdeField("SYCTAM", "SYCTAM", JdeDataType.Numeric),
        new JdeField("SYTXA1", "SYTXA1", JdeDataType.String, 20),
        new JdeField("SYEXR1", "SYEXR1", JdeDataType.String, 4),
        new JdeField("SYDSVJ", "SYDSVJ", JdeDataType.Numeric),
        new JdeField("SYGLBA", "SYGLBA", JdeDataType.String, 16),
        new JdeField("SYAM", "SYAM", JdeDataType.String, 2),
        new JdeField("SYAID2", "SYAID2", JdeDataType.String, 16),
        new JdeField("SYAM2", "SYAM2", JdeDataType.String, 2),
        new JdeField("SYMCU", "SYMCU", JdeDataType.String, 24),
        new JdeField("SYOBJ", "SYOBJ", JdeDataType.String, 12),
        new JdeField("SYSUB", "SYSUB", JdeDataType.String, 16),
        new JdeField("SYSBLT", "SYSBLT", JdeDataType.String, 2),
        new JdeField("SYSBL", "SYSBL", JdeDataType.String, 16),
        new JdeField("SYPTC", "SYPTC", JdeDataType.String, 6),
        new JdeField("SYDDJ", "SYDDJ", JdeDataType.Numeric),
        new JdeField("SYDDNJ", "SYDDNJ", JdeDataType.Numeric),
        new JdeField("SYRDDJ", "SYRDDJ", JdeDataType.Numeric),
        new JdeField("SYRDSJ", "SYRDSJ", JdeDataType.Numeric),
        new JdeField("SYLFCJ", "SYLFCJ", JdeDataType.Numeric),
        new JdeField("SYSMTJ", "SYSMTJ", JdeDataType.Numeric),
        new JdeField("SYNBRR", "SYNBRR", JdeDataType.String, 2),
        new JdeField("SYRDRL", "SYRDRL", JdeDataType.String, 2),
        new JdeField("SYRMDS", "SYRMDS", JdeDataType.Numeric),
        new JdeField("SYCOLL", "SYCOLL", JdeDataType.String, 2),
        new JdeField("SYCORC", "SYCORC", JdeDataType.String, 4),
        new JdeField("SYAFC", "SYAFC", JdeDataType.String, 2),
        new JdeField("SYDNLT", "SYDNLT", JdeDataType.String, 2),
        new JdeField("SYRSCO", "SYRSCO", JdeDataType.String, 4),
        new JdeField("SYODOC", "SYODOC", JdeDataType.Numeric),
        new JdeField("SYODCT", "SYODCT", JdeDataType.String, 4),
        new JdeField("SYOKCO", "SYOKCO", JdeDataType.String, 10),
        new JdeField("SYOSFX", "SYOSFX", JdeDataType.String, 6),
        new JdeField("SYVINV", "SYVINV", JdeDataType.String, 50),
        new JdeField("SYPO", "SYPO", JdeDataType.String, 16),
        new JdeField("SYPDCT", "SYPDCT", JdeDataType.String, 4),
        new JdeField("SYPKCO", "SYPKCO", JdeDataType.String, 10),
        new JdeField("SYDCTO", "SYDCTO", JdeDataType.String, 4),
        new JdeField("SYLNID", "SYLNID", JdeDataType.Numeric),
        new JdeField("SYSDOC", "SYSDOC", JdeDataType.Numeric),
        new JdeField("SYSDCT", "SYSDCT", JdeDataType.String, 4),
        new JdeField("SYSKCO", "SYSKCO", JdeDataType.String, 10),
        new JdeField("SYSFXO", "SYSFXO", JdeDataType.String, 6),
        new JdeField("SYVLDT", "SYVLDT", JdeDataType.Numeric),
        new JdeField("SYCMC1", "SYCMC1", JdeDataType.Numeric),
        new JdeField("SYVR01", "SYVR01", JdeDataType.String, 50),
        new JdeField("SYUNIT", "SYUNIT", JdeDataType.String, 16),
        new JdeField("SYMCU2", "SYMCU2", JdeDataType.String, 24),
        new JdeField("SYRMK", "SYRMK", JdeDataType.String, 60),
        new JdeField("SYALPH", "SYALPH", JdeDataType.String, 80),
        new JdeField("SYRF", "SYRF", JdeDataType.String, 4),
        new JdeField("SYDRF", "SYDRF", JdeDataType.Numeric),
        new JdeField("SYCTL", "SYCTL", JdeDataType.String, 26),
        new JdeField("SYFNLP", "SYFNLP", JdeDataType.String, 2),
        new JdeField("SYITM", "SYITM", JdeDataType.Numeric),
        new JdeField("SYU", "SYU", JdeDataType.Numeric),
        new JdeField("SYUM", "SYUM", JdeDataType.String, 4),
        new JdeField("SYALT6", "SYALT6", JdeDataType.String, 2),
        new JdeField("SYRYIN", "SYRYIN", JdeDataType.String, 2),
        new JdeField("SYVDGJ", "SYVDGJ", JdeDataType.Numeric),
        new JdeField("SYVOD", "SYVOD", JdeDataType.String, 2),
        new JdeField("SYRP1", "SYRP1", JdeDataType.String, 2),
        new JdeField("SYRP2", "SYRP2", JdeDataType.String, 2),
        new JdeField("SYRP3", "SYRP3", JdeDataType.String, 2),
        new JdeField("SYAR01", "SYAR01", JdeDataType.String, 6),
        new JdeField("SYAR02", "SYAR02", JdeDataType.String, 6),
        new JdeField("SYAR03", "SYAR03", JdeDataType.String, 6),
        new JdeField("SYAR04", "SYAR04", JdeDataType.String, 6),
        new JdeField("SYAR05", "SYAR05", JdeDataType.String, 6),
        new JdeField("SYAR06", "SYAR06", JdeDataType.String, 6),
        new JdeField("SYAR07", "SYAR07", JdeDataType.String, 6),
        new JdeField("SYAR08", "SYAR08", JdeDataType.String, 6),
        new JdeField("SYAR09", "SYAR09", JdeDataType.String, 6),
        new JdeField("SYAR10", "SYAR10", JdeDataType.String, 6),
        new JdeField("SYISTC", "SYISTC", JdeDataType.String, 2),
        new JdeField("SYPYID", "SYPYID", JdeDataType.Numeric),
        new JdeField("SYRNID", "SYRNID", JdeDataType.Numeric),
        new JdeField("SYPPDI", "SYPPDI", JdeDataType.Numeric),
        new JdeField("SYJCL", "SYJCL", JdeDataType.Numeric),
        new JdeField("SYDDEX", "SYDDEX", JdeDataType.String, 4),
        new JdeField("SYHCRR", "SYHCRR", JdeDataType.Numeric),
        new JdeField("SYHDGJ", "SYHDGJ", JdeDataType.Numeric),
        new JdeField("SYDCP", "SYDCP", JdeDataType.Numeric),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYSHPN", "SYSHPN", JdeDataType.Numeric),
        new JdeField("SYDTXS", "SYDTXS", JdeDataType.String, 2),
        new JdeField("SYOMOD", "SYOMOD", JdeDataType.String, 2),
        new JdeField("SYCLMG", "SYCLMG", JdeDataType.String, 20),
        new JdeField("SYCMGR", "SYCMGR", JdeDataType.String, 20),
        new JdeField("SYATAD", "SYATAD", JdeDataType.Numeric),
        new JdeField("SYCTAD", "SYCTAD", JdeDataType.Numeric),
        new JdeField("SYNRTA", "SYNRTA", JdeDataType.Numeric),
        new JdeField("SYFNRT", "SYFNRT", JdeDataType.Numeric),
        new JdeField("SYPRGF", "SYPRGF", JdeDataType.String, 2),
        new JdeField("SYGFL1", "SYGFL1", JdeDataType.String, 2),
        new JdeField("SYGFL2", "SYGFL2", JdeDataType.String, 2),
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYKCOO", "SYKCOO", JdeDataType.String, 10),
        new JdeField("SYSOTF", "SYSOTF", JdeDataType.String, 2),
        new JdeField("SYDTPB", "SYDTPB", JdeDataType.Numeric),
        new JdeField("SYERDJ", "SYERDJ", JdeDataType.Numeric),
        new JdeField("SYPWPG", "SYPWPG", JdeDataType.Numeric),
        new JdeField("SYNETTCID", "SYNETTCID", JdeDataType.Numeric),
        new JdeField("SYNETDOC", "SYNETDOC", JdeDataType.Numeric),
        new JdeField("SYNETRC5", "SYNETRC5", JdeDataType.Numeric),
        new JdeField("SYNETST", "SYNETST", JdeDataType.String, 2),
        new JdeField("SYAJCL", "SYAJCL", JdeDataType.Numeric),
        new JdeField("SYRMR1", "SYRMR1", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B11Z2_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B11Z2_2", "Index on SYDOC, SYDCT, SYKCO, SYSFX", new[] { "SYDOC", "SYDCT", "SYKCO", "SYSFX" })
    };
}
