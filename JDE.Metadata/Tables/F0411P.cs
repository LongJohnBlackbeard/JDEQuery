using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0411P - .
/// </summary>
public class F0411P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPSFXE.
        /// </summary>
        public const string RPSFXE = "RPSFXE";

        /// <summary>
        /// RPDCTA.
        /// </summary>
        public const string RPDCTA = "RPDCTA";

        /// <summary>
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

        /// <summary>
        /// RPPYE.
        /// </summary>
        public const string RPPYE = "RPPYE";

        /// <summary>
        /// RPSNTO.
        /// </summary>
        public const string RPSNTO = "RPSNTO";

        /// <summary>
        /// RPDIVJ.
        /// </summary>
        public const string RPDIVJ = "RPDIVJ";

        /// <summary>
        /// RPDSVJ.
        /// </summary>
        public const string RPDSVJ = "RPDSVJ";

        /// <summary>
        /// RPDDJ.
        /// </summary>
        public const string RPDDJ = "RPDDJ";

        /// <summary>
        /// RPDDNJ.
        /// </summary>
        public const string RPDDNJ = "RPDDNJ";

        /// <summary>
        /// RPDGJ.
        /// </summary>
        public const string RPDGJ = "RPDGJ";

        /// <summary>
        /// RPFY.
        /// </summary>
        public const string RPFY = "RPFY";

        /// <summary>
        /// RPCTRY.
        /// </summary>
        public const string RPCTRY = "RPCTRY";

        /// <summary>
        /// RPPN.
        /// </summary>
        public const string RPPN = "RPPN";

        /// <summary>
        /// RPCO.
        /// </summary>
        public const string RPCO = "RPCO";

        /// <summary>
        /// RPICU.
        /// </summary>
        public const string RPICU = "RPICU";

        /// <summary>
        /// RPICUT.
        /// </summary>
        public const string RPICUT = "RPICUT";

        /// <summary>
        /// RPDICJ.
        /// </summary>
        public const string RPDICJ = "RPDICJ";

        /// <summary>
        /// RPBALJ.
        /// </summary>
        public const string RPBALJ = "RPBALJ";

        /// <summary>
        /// RPPST.
        /// </summary>
        public const string RPPST = "RPPST";

        /// <summary>
        /// RPAG.
        /// </summary>
        public const string RPAG = "RPAG";

        /// <summary>
        /// RPAAP.
        /// </summary>
        public const string RPAAP = "RPAAP";

        /// <summary>
        /// RPADSC.
        /// </summary>
        public const string RPADSC = "RPADSC";

        /// <summary>
        /// RPADSA.
        /// </summary>
        public const string RPADSA = "RPADSA";

        /// <summary>
        /// RPATXA.
        /// </summary>
        public const string RPATXA = "RPATXA";

        /// <summary>
        /// RPATXN.
        /// </summary>
        public const string RPATXN = "RPATXN";

        /// <summary>
        /// RPSTAM.
        /// </summary>
        public const string RPSTAM = "RPSTAM";

        /// <summary>
        /// RPTXA1.
        /// </summary>
        public const string RPTXA1 = "RPTXA1";

        /// <summary>
        /// RPEXR1.
        /// </summary>
        public const string RPEXR1 = "RPEXR1";

        /// <summary>
        /// RPCRRM.
        /// </summary>
        public const string RPCRRM = "RPCRRM";

        /// <summary>
        /// RPCRCD.
        /// </summary>
        public const string RPCRCD = "RPCRCD";

        /// <summary>
        /// RPCRR.
        /// </summary>
        public const string RPCRR = "RPCRR";

        /// <summary>
        /// RPACR.
        /// </summary>
        public const string RPACR = "RPACR";

        /// <summary>
        /// RPFAP.
        /// </summary>
        public const string RPFAP = "RPFAP";

        /// <summary>
        /// RPCDS.
        /// </summary>
        public const string RPCDS = "RPCDS";

        /// <summary>
        /// RPCDSA.
        /// </summary>
        public const string RPCDSA = "RPCDSA";

        /// <summary>
        /// RPCTXA.
        /// </summary>
        public const string RPCTXA = "RPCTXA";

        /// <summary>
        /// RPCTXN.
        /// </summary>
        public const string RPCTXN = "RPCTXN";

        /// <summary>
        /// RPCTAM.
        /// </summary>
        public const string RPCTAM = "RPCTAM";

        /// <summary>
        /// RPGLC.
        /// </summary>
        public const string RPGLC = "RPGLC";

        /// <summary>
        /// RPGLBA.
        /// </summary>
        public const string RPGLBA = "RPGLBA";

        /// <summary>
        /// RPPOST.
        /// </summary>
        public const string RPPOST = "RPPOST";

        /// <summary>
        /// RPAM.
        /// </summary>
        public const string RPAM = "RPAM";

        /// <summary>
        /// RPAID2.
        /// </summary>
        public const string RPAID2 = "RPAID2";

        /// <summary>
        /// RPMCU.
        /// </summary>
        public const string RPMCU = "RPMCU";

        /// <summary>
        /// RPOBJ.
        /// </summary>
        public const string RPOBJ = "RPOBJ";

        /// <summary>
        /// RPSUB.
        /// </summary>
        public const string RPSUB = "RPSUB";

        /// <summary>
        /// RPSBLT.
        /// </summary>
        public const string RPSBLT = "RPSBLT";

        /// <summary>
        /// RPSBL.
        /// </summary>
        public const string RPSBL = "RPSBL";

        /// <summary>
        /// RPBAID.
        /// </summary>
        public const string RPBAID = "RPBAID";

        /// <summary>
        /// RPPTC.
        /// </summary>
        public const string RPPTC = "RPPTC";

        /// <summary>
        /// RPVOD.
        /// </summary>
        public const string RPVOD = "RPVOD";

        /// <summary>
        /// RPOKCO.
        /// </summary>
        public const string RPOKCO = "RPOKCO";

        /// <summary>
        /// RPODCT.
        /// </summary>
        public const string RPODCT = "RPODCT";

        /// <summary>
        /// RPODOC.
        /// </summary>
        public const string RPODOC = "RPODOC";

        /// <summary>
        /// RPOSFX.
        /// </summary>
        public const string RPOSFX = "RPOSFX";

        /// <summary>
        /// RPCRC.
        /// </summary>
        public const string RPCRC = "RPCRC";

        /// <summary>
        /// RPVINV.
        /// </summary>
        public const string RPVINV = "RPVINV";

        /// <summary>
        /// RPPKCO.
        /// </summary>
        public const string RPPKCO = "RPPKCO";

        /// <summary>
        /// RPPO.
        /// </summary>
        public const string RPPO = "RPPO";

        /// <summary>
        /// RPPDCT.
        /// </summary>
        public const string RPPDCT = "RPPDCT";

        /// <summary>
        /// RPLNID.
        /// </summary>
        public const string RPLNID = "RPLNID";

        /// <summary>
        /// RPSFXO.
        /// </summary>
        public const string RPSFXO = "RPSFXO";

        /// <summary>
        /// RPOPSQ.
        /// </summary>
        public const string RPOPSQ = "RPOPSQ";

        /// <summary>
        /// RPVR01.
        /// </summary>
        public const string RPVR01 = "RPVR01";

        /// <summary>
        /// RPUNIT.
        /// </summary>
        public const string RPUNIT = "RPUNIT";

        /// <summary>
        /// RPMCU2.
        /// </summary>
        public const string RPMCU2 = "RPMCU2";

        /// <summary>
        /// RPRMK.
        /// </summary>
        public const string RPRMK = "RPRMK";

        /// <summary>
        /// RPRF.
        /// </summary>
        public const string RPRF = "RPRF";

        /// <summary>
        /// RPDRF.
        /// </summary>
        public const string RPDRF = "RPDRF";

        /// <summary>
        /// RPCTL.
        /// </summary>
        public const string RPCTL = "RPCTL";

        /// <summary>
        /// RPFNLP.
        /// </summary>
        public const string RPFNLP = "RPFNLP";

        /// <summary>
        /// RPU.
        /// </summary>
        public const string RPU = "RPU";

        /// <summary>
        /// RPUM.
        /// </summary>
        public const string RPUM = "RPUM";

        /// <summary>
        /// RPPYIN.
        /// </summary>
        public const string RPPYIN = "RPPYIN";

        /// <summary>
        /// RPTXA3.
        /// </summary>
        public const string RPTXA3 = "RPTXA3";

        /// <summary>
        /// RPEXR3.
        /// </summary>
        public const string RPEXR3 = "RPEXR3";

        /// <summary>
        /// RPRP1.
        /// </summary>
        public const string RPRP1 = "RPRP1";

        /// <summary>
        /// RPRP2.
        /// </summary>
        public const string RPRP2 = "RPRP2";

        /// <summary>
        /// RPRP3.
        /// </summary>
        public const string RPRP3 = "RPRP3";

        /// <summary>
        /// RPAC07.
        /// </summary>
        public const string RPAC07 = "RPAC07";

        /// <summary>
        /// RPTNN.
        /// </summary>
        public const string RPTNN = "RPTNN";

        /// <summary>
        /// RPDMCD.
        /// </summary>
        public const string RPDMCD = "RPDMCD";

        /// <summary>
        /// RPITM.
        /// </summary>
        public const string RPITM = "RPITM";

        /// <summary>
        /// RPHCRR.
        /// </summary>
        public const string RPHCRR = "RPHCRR";

        /// <summary>
        /// RPHDGJ.
        /// </summary>
        public const string RPHDGJ = "RPHDGJ";

        /// <summary>
        /// RPURC1.
        /// </summary>
        public const string RPURC1 = "RPURC1";

        /// <summary>
        /// RPURDT.
        /// </summary>
        public const string RPURDT = "RPURDT";

        /// <summary>
        /// RPURAT.
        /// </summary>
        public const string RPURAT = "RPURAT";

        /// <summary>
        /// RPURAB.
        /// </summary>
        public const string RPURAB = "RPURAB";

        /// <summary>
        /// RPURRF.
        /// </summary>
        public const string RPURRF = "RPURRF";

        /// <summary>
        /// RPTORG.
        /// </summary>
        public const string RPTORG = "RPTORG";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPTNST.
        /// </summary>
        public const string RPTNST = "RPTNST";

        /// <summary>
        /// RPYC01.
        /// </summary>
        public const string RPYC01 = "RPYC01";

        /// <summary>
        /// RPYC02.
        /// </summary>
        public const string RPYC02 = "RPYC02";

        /// <summary>
        /// RPYC03.
        /// </summary>
        public const string RPYC03 = "RPYC03";

        /// <summary>
        /// RPYC04.
        /// </summary>
        public const string RPYC04 = "RPYC04";

        /// <summary>
        /// RPYC05.
        /// </summary>
        public const string RPYC05 = "RPYC05";

        /// <summary>
        /// RPYC06.
        /// </summary>
        public const string RPYC06 = "RPYC06";

        /// <summary>
        /// RPYC07.
        /// </summary>
        public const string RPYC07 = "RPYC07";

        /// <summary>
        /// RPYC08.
        /// </summary>
        public const string RPYC08 = "RPYC08";

        /// <summary>
        /// RPYC09.
        /// </summary>
        public const string RPYC09 = "RPYC09";

        /// <summary>
        /// RPYC10.
        /// </summary>
        public const string RPYC10 = "RPYC10";

        /// <summary>
        /// RPDTXS.
        /// </summary>
        public const string RPDTXS = "RPDTXS";

        /// <summary>
        /// RPBCRC.
        /// </summary>
        public const string RPBCRC = "RPBCRC";

        /// <summary>
        /// RPATAD.
        /// </summary>
        public const string RPATAD = "RPATAD";

        /// <summary>
        /// RPCTAD.
        /// </summary>
        public const string RPCTAD = "RPCTAD";

        /// <summary>
        /// RPNRTA.
        /// </summary>
        public const string RPNRTA = "RPNRTA";

        /// <summary>
        /// RPFNRT.
        /// </summary>
        public const string RPFNRT = "RPFNRT";

        /// <summary>
        /// RPTAXP.
        /// </summary>
        public const string RPTAXP = "RPTAXP";

        /// <summary>
        /// RPPRGF.
        /// </summary>
        public const string RPPRGF = "RPPRGF";

        /// <summary>
        /// RPGFL5.
        /// </summary>
        public const string RPGFL5 = "RPGFL5";

        /// <summary>
        /// RPGFL6.
        /// </summary>
        public const string RPGFL6 = "RPGFL6";

        /// <summary>
        /// RPGAM1.
        /// </summary>
        public const string RPGAM1 = "RPGAM1";

        /// <summary>
        /// RPGAM2.
        /// </summary>
        public const string RPGAM2 = "RPGAM2";

        /// <summary>
        /// RPGEN4.
        /// </summary>
        public const string RPGEN4 = "RPGEN4";

        /// <summary>
        /// RPGEN5.
        /// </summary>
        public const string RPGEN5 = "RPGEN5";

        /// <summary>
        /// RPWTAD.
        /// </summary>
        public const string RPWTAD = "RPWTAD";

        /// <summary>
        /// RPWTAF.
        /// </summary>
        public const string RPWTAF = "RPWTAF";

        /// <summary>
        /// RPSMMF.
        /// </summary>
        public const string RPSMMF = "RPSMMF";

        /// <summary>
        /// RPPYWP.
        /// </summary>
        public const string RPPYWP = "RPPYWP";

        /// <summary>
        /// RPPWPG.
        /// </summary>
        public const string RPPWPG = "RPPWPG";

        /// <summary>
        /// RPNETTCID.
        /// </summary>
        public const string RPNETTCID = "RPNETTCID";

        /// <summary>
        /// RPNETDOC.
        /// </summary>
        public const string RPNETDOC = "RPNETDOC";

        /// <summary>
        /// RPNETRC5.
        /// </summary>
        public const string RPNETRC5 = "RPNETRC5";

        /// <summary>
        /// RPNETST.
        /// </summary>
        public const string RPNETST = "RPNETST";

        /// <summary>
        /// RPCNTRTID.
        /// </summary>
        public const string RPCNTRTID = "RPCNTRTID";

        /// <summary>
        /// RPCNTRTCD.
        /// </summary>
        public const string RPCNTRTCD = "RPCNTRTCD";

        /// <summary>
        /// RPWVID.
        /// </summary>
        public const string RPWVID = "RPWVID";

        /// <summary>
        /// RPBLSCD2.
        /// </summary>
        public const string RPBLSCD2 = "RPBLSCD2";

        /// <summary>
        /// RPHARPER.
        /// </summary>
        public const string RPHARPER = "RPHARPER";

        /// <summary>
        /// RPHARSFX.
        /// </summary>
        public const string RPHARSFX = "RPHARSFX";

        /// <summary>
        /// RPDDRL.
        /// </summary>
        public const string RPDDRL = "RPDDRL";

        /// <summary>
        /// RPSEQN.
        /// </summary>
        public const string RPSEQN = "RPSEQN";

        /// <summary>
        /// RPCLASS01.
        /// </summary>
        public const string RPCLASS01 = "RPCLASS01";

        /// <summary>
        /// RPCLASS02.
        /// </summary>
        public const string RPCLASS02 = "RPCLASS02";

        /// <summary>
        /// RPCLASS03.
        /// </summary>
        public const string RPCLASS03 = "RPCLASS03";

        /// <summary>
        /// RPCLASS04.
        /// </summary>
        public const string RPCLASS04 = "RPCLASS04";

        /// <summary>
        /// RPCLASS05.
        /// </summary>
        public const string RPCLASS05 = "RPCLASS05";
    }

    /// <inheritdoc />
    public override string TableName => "F0411P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPSFXE", "RPSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCTA", "RPDCTA", JdeDataType.String, 4),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric),
        new JdeField("RPPYE", "RPPYE", JdeDataType.Numeric),
        new JdeField("RPSNTO", "RPSNTO", JdeDataType.Numeric),
        new JdeField("RPDIVJ", "RPDIVJ", JdeDataType.Numeric),
        new JdeField("RPDSVJ", "RPDSVJ", JdeDataType.Numeric),
        new JdeField("RPDDJ", "RPDDJ", JdeDataType.Numeric),
        new JdeField("RPDDNJ", "RPDDNJ", JdeDataType.Numeric),
        new JdeField("RPDGJ", "RPDGJ", JdeDataType.Numeric),
        new JdeField("RPFY", "RPFY", JdeDataType.Numeric),
        new JdeField("RPCTRY", "RPCTRY", JdeDataType.Numeric),
        new JdeField("RPPN", "RPPN", JdeDataType.Numeric),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10),
        new JdeField("RPICU", "RPICU", JdeDataType.Numeric),
        new JdeField("RPICUT", "RPICUT", JdeDataType.String, 4),
        new JdeField("RPDICJ", "RPDICJ", JdeDataType.Numeric),
        new JdeField("RPBALJ", "RPBALJ", JdeDataType.String, 2),
        new JdeField("RPPST", "RPPST", JdeDataType.String, 2),
        new JdeField("RPAG", "RPAG", JdeDataType.Numeric),
        new JdeField("RPAAP", "RPAAP", JdeDataType.Numeric),
        new JdeField("RPADSC", "RPADSC", JdeDataType.Numeric),
        new JdeField("RPADSA", "RPADSA", JdeDataType.Numeric),
        new JdeField("RPATXA", "RPATXA", JdeDataType.Numeric),
        new JdeField("RPATXN", "RPATXN", JdeDataType.Numeric),
        new JdeField("RPSTAM", "RPSTAM", JdeDataType.Numeric),
        new JdeField("RPTXA1", "RPTXA1", JdeDataType.String, 20),
        new JdeField("RPEXR1", "RPEXR1", JdeDataType.String, 4),
        new JdeField("RPCRRM", "RPCRRM", JdeDataType.String, 2),
        new JdeField("RPCRCD", "RPCRCD", JdeDataType.String, 6),
        new JdeField("RPCRR", "RPCRR", JdeDataType.Numeric),
        new JdeField("RPACR", "RPACR", JdeDataType.Numeric),
        new JdeField("RPFAP", "RPFAP", JdeDataType.Numeric),
        new JdeField("RPCDS", "RPCDS", JdeDataType.Numeric),
        new JdeField("RPCDSA", "RPCDSA", JdeDataType.Numeric),
        new JdeField("RPCTXA", "RPCTXA", JdeDataType.Numeric),
        new JdeField("RPCTXN", "RPCTXN", JdeDataType.Numeric),
        new JdeField("RPCTAM", "RPCTAM", JdeDataType.Numeric),
        new JdeField("RPGLC", "RPGLC", JdeDataType.String, 8),
        new JdeField("RPGLBA", "RPGLBA", JdeDataType.String, 16),
        new JdeField("RPPOST", "RPPOST", JdeDataType.String, 2),
        new JdeField("RPAM", "RPAM", JdeDataType.String, 2),
        new JdeField("RPAID2", "RPAID2", JdeDataType.String, 16),
        new JdeField("RPMCU", "RPMCU", JdeDataType.String, 24),
        new JdeField("RPOBJ", "RPOBJ", JdeDataType.String, 12),
        new JdeField("RPSUB", "RPSUB", JdeDataType.String, 16),
        new JdeField("RPSBLT", "RPSBLT", JdeDataType.String, 2),
        new JdeField("RPSBL", "RPSBL", JdeDataType.String, 16),
        new JdeField("RPBAID", "RPBAID", JdeDataType.String, 16),
        new JdeField("RPPTC", "RPPTC", JdeDataType.String, 6),
        new JdeField("RPVOD", "RPVOD", JdeDataType.String, 2),
        new JdeField("RPOKCO", "RPOKCO", JdeDataType.String, 10),
        new JdeField("RPODCT", "RPODCT", JdeDataType.String, 4),
        new JdeField("RPODOC", "RPODOC", JdeDataType.Numeric),
        new JdeField("RPOSFX", "RPOSFX", JdeDataType.String, 6),
        new JdeField("RPCRC", "RPCRC", JdeDataType.String, 6),
        new JdeField("RPVINV", "RPVINV", JdeDataType.String, 50),
        new JdeField("RPPKCO", "RPPKCO", JdeDataType.String, 10),
        new JdeField("RPPO", "RPPO", JdeDataType.String, 16),
        new JdeField("RPPDCT", "RPPDCT", JdeDataType.String, 4),
        new JdeField("RPLNID", "RPLNID", JdeDataType.Numeric),
        new JdeField("RPSFXO", "RPSFXO", JdeDataType.String, 6),
        new JdeField("RPOPSQ", "RPOPSQ", JdeDataType.Numeric),
        new JdeField("RPVR01", "RPVR01", JdeDataType.String, 50),
        new JdeField("RPUNIT", "RPUNIT", JdeDataType.String, 16),
        new JdeField("RPMCU2", "RPMCU2", JdeDataType.String, 24),
        new JdeField("RPRMK", "RPRMK", JdeDataType.String, 60),
        new JdeField("RPRF", "RPRF", JdeDataType.String, 4),
        new JdeField("RPDRF", "RPDRF", JdeDataType.Numeric),
        new JdeField("RPCTL", "RPCTL", JdeDataType.String, 26),
        new JdeField("RPFNLP", "RPFNLP", JdeDataType.String, 2),
        new JdeField("RPU", "RPU", JdeDataType.Numeric),
        new JdeField("RPUM", "RPUM", JdeDataType.String, 4),
        new JdeField("RPPYIN", "RPPYIN", JdeDataType.String, 2),
        new JdeField("RPTXA3", "RPTXA3", JdeDataType.String, 20),
        new JdeField("RPEXR3", "RPEXR3", JdeDataType.String, 4),
        new JdeField("RPRP1", "RPRP1", JdeDataType.String, 2),
        new JdeField("RPRP2", "RPRP2", JdeDataType.String, 2),
        new JdeField("RPRP3", "RPRP3", JdeDataType.String, 2),
        new JdeField("RPAC07", "RPAC07", JdeDataType.String, 6),
        new JdeField("RPTNN", "RPTNN", JdeDataType.String, 2),
        new JdeField("RPDMCD", "RPDMCD", JdeDataType.String, 2),
        new JdeField("RPITM", "RPITM", JdeDataType.Numeric),
        new JdeField("RPHCRR", "RPHCRR", JdeDataType.Numeric),
        new JdeField("RPHDGJ", "RPHDGJ", JdeDataType.Numeric),
        new JdeField("RPURC1", "RPURC1", JdeDataType.String, 6),
        new JdeField("RPURDT", "RPURDT", JdeDataType.Numeric),
        new JdeField("RPURAT", "RPURAT", JdeDataType.Numeric),
        new JdeField("RPURAB", "RPURAB", JdeDataType.Numeric),
        new JdeField("RPURRF", "RPURRF", JdeDataType.String, 30),
        new JdeField("RPTORG", "RPTORG", JdeDataType.String, 20),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPTNST", "RPTNST", JdeDataType.String, 40),
        new JdeField("RPYC01", "RPYC01", JdeDataType.String, 6),
        new JdeField("RPYC02", "RPYC02", JdeDataType.String, 6),
        new JdeField("RPYC03", "RPYC03", JdeDataType.String, 6),
        new JdeField("RPYC04", "RPYC04", JdeDataType.String, 6),
        new JdeField("RPYC05", "RPYC05", JdeDataType.String, 6),
        new JdeField("RPYC06", "RPYC06", JdeDataType.String, 6),
        new JdeField("RPYC07", "RPYC07", JdeDataType.String, 6),
        new JdeField("RPYC08", "RPYC08", JdeDataType.String, 6),
        new JdeField("RPYC09", "RPYC09", JdeDataType.String, 6),
        new JdeField("RPYC10", "RPYC10", JdeDataType.String, 6),
        new JdeField("RPDTXS", "RPDTXS", JdeDataType.String, 2),
        new JdeField("RPBCRC", "RPBCRC", JdeDataType.String, 6),
        new JdeField("RPATAD", "RPATAD", JdeDataType.Numeric),
        new JdeField("RPCTAD", "RPCTAD", JdeDataType.Numeric),
        new JdeField("RPNRTA", "RPNRTA", JdeDataType.Numeric),
        new JdeField("RPFNRT", "RPFNRT", JdeDataType.Numeric),
        new JdeField("RPTAXP", "RPTAXP", JdeDataType.String, 2),
        new JdeField("RPPRGF", "RPPRGF", JdeDataType.String, 2),
        new JdeField("RPGFL5", "RPGFL5", JdeDataType.String, 2),
        new JdeField("RPGFL6", "RPGFL6", JdeDataType.String, 2),
        new JdeField("RPGAM1", "RPGAM1", JdeDataType.Numeric),
        new JdeField("RPGAM2", "RPGAM2", JdeDataType.Numeric),
        new JdeField("RPGEN4", "RPGEN4", JdeDataType.String, 50),
        new JdeField("RPGEN5", "RPGEN5", JdeDataType.String, 50),
        new JdeField("RPWTAD", "RPWTAD", JdeDataType.Numeric),
        new JdeField("RPWTAF", "RPWTAF", JdeDataType.Numeric),
        new JdeField("RPSMMF", "RPSMMF", JdeDataType.String, 2),
        new JdeField("RPPYWP", "RPPYWP", JdeDataType.String, 2),
        new JdeField("RPPWPG", "RPPWPG", JdeDataType.Numeric),
        new JdeField("RPNETTCID", "RPNETTCID", JdeDataType.Numeric),
        new JdeField("RPNETDOC", "RPNETDOC", JdeDataType.Numeric),
        new JdeField("RPNETRC5", "RPNETRC5", JdeDataType.Numeric),
        new JdeField("RPNETST", "RPNETST", JdeDataType.String, 2),
        new JdeField("RPCNTRTID", "RPCNTRTID", JdeDataType.Numeric),
        new JdeField("RPCNTRTCD", "RPCNTRTCD", JdeDataType.String, 24),
        new JdeField("RPWVID", "RPWVID", JdeDataType.Numeric),
        new JdeField("RPBLSCD2", "RPBLSCD2", JdeDataType.String, 20),
        new JdeField("RPHARPER", "RPHARPER", JdeDataType.String, 12),
        new JdeField("RPHARSFX", "RPHARSFX", JdeDataType.String, 20),
        new JdeField("RPDDRL", "RPDDRL", JdeDataType.String, 10),
        new JdeField("RPSEQN", "RPSEQN", JdeDataType.Numeric),
        new JdeField("RPCLASS01", "RPCLASS01", JdeDataType.String, 6),
        new JdeField("RPCLASS02", "RPCLASS02", JdeDataType.String, 6),
        new JdeField("RPCLASS03", "RPCLASS03", JdeDataType.String, 6),
        new JdeField("RPCLASS04", "RPCLASS04", JdeDataType.String, 6),
        new JdeField("RPCLASS05", "RPCLASS05", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0411P_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX, RPSFXE", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX", "RPSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
