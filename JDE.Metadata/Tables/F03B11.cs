using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B11 - .
/// </summary>
public class F03B11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

        /// <summary>
        /// RPDGJ.
        /// </summary>
        public const string RPDGJ = "RPDGJ";

        /// <summary>
        /// RPDIVJ.
        /// </summary>
        public const string RPDIVJ = "RPDIVJ";

        /// <summary>
        /// RPICUT.
        /// </summary>
        public const string RPICUT = "RPICUT";

        /// <summary>
        /// RPICU.
        /// </summary>
        public const string RPICU = "RPICU";

        /// <summary>
        /// RPDICJ.
        /// </summary>
        public const string RPDICJ = "RPDICJ";

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
        /// RPGLC.
        /// </summary>
        public const string RPGLC = "RPGLC";

        /// <summary>
        /// RPAID.
        /// </summary>
        public const string RPAID = "RPAID";

        /// <summary>
        /// RPPA8.
        /// </summary>
        public const string RPPA8 = "RPPA8";

        /// <summary>
        /// RPAN8J.
        /// </summary>
        public const string RPAN8J = "RPAN8J";

        /// <summary>
        /// RPPYR.
        /// </summary>
        public const string RPPYR = "RPPYR";

        /// <summary>
        /// RPPOST.
        /// </summary>
        public const string RPPOST = "RPPOST";

        /// <summary>
        /// RPISTR.
        /// </summary>
        public const string RPISTR = "RPISTR";

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
        /// RPBCRC.
        /// </summary>
        public const string RPBCRC = "RPBCRC";

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
        /// RPDMCD.
        /// </summary>
        public const string RPDMCD = "RPDMCD";

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
        /// RPTXA1.
        /// </summary>
        public const string RPTXA1 = "RPTXA1";

        /// <summary>
        /// RPEXR1.
        /// </summary>
        public const string RPEXR1 = "RPEXR1";

        /// <summary>
        /// RPDSVJ.
        /// </summary>
        public const string RPDSVJ = "RPDSVJ";

        /// <summary>
        /// RPGLBA.
        /// </summary>
        public const string RPGLBA = "RPGLBA";

        /// <summary>
        /// RPAM.
        /// </summary>
        public const string RPAM = "RPAM";

        /// <summary>
        /// RPAID2.
        /// </summary>
        public const string RPAID2 = "RPAID2";

        /// <summary>
        /// RPAM2.
        /// </summary>
        public const string RPAM2 = "RPAM2";

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
        /// RPPTC.
        /// </summary>
        public const string RPPTC = "RPPTC";

        /// <summary>
        /// RPDDJ.
        /// </summary>
        public const string RPDDJ = "RPDDJ";

        /// <summary>
        /// RPDDNJ.
        /// </summary>
        public const string RPDDNJ = "RPDDNJ";

        /// <summary>
        /// RPRDDJ.
        /// </summary>
        public const string RPRDDJ = "RPRDDJ";

        /// <summary>
        /// RPRDSJ.
        /// </summary>
        public const string RPRDSJ = "RPRDSJ";

        /// <summary>
        /// RPLFCJ.
        /// </summary>
        public const string RPLFCJ = "RPLFCJ";

        /// <summary>
        /// RPSMTJ.
        /// </summary>
        public const string RPSMTJ = "RPSMTJ";

        /// <summary>
        /// RPNBRR.
        /// </summary>
        public const string RPNBRR = "RPNBRR";

        /// <summary>
        /// RPRDRL.
        /// </summary>
        public const string RPRDRL = "RPRDRL";

        /// <summary>
        /// RPRMDS.
        /// </summary>
        public const string RPRMDS = "RPRMDS";

        /// <summary>
        /// RPCOLL.
        /// </summary>
        public const string RPCOLL = "RPCOLL";

        /// <summary>
        /// RPCORC.
        /// </summary>
        public const string RPCORC = "RPCORC";

        /// <summary>
        /// RPAFC.
        /// </summary>
        public const string RPAFC = "RPAFC";

        /// <summary>
        /// RPDNLT.
        /// </summary>
        public const string RPDNLT = "RPDNLT";

        /// <summary>
        /// RPRSCO.
        /// </summary>
        public const string RPRSCO = "RPRSCO";

        /// <summary>
        /// RPODOC.
        /// </summary>
        public const string RPODOC = "RPODOC";

        /// <summary>
        /// RPODCT.
        /// </summary>
        public const string RPODCT = "RPODCT";

        /// <summary>
        /// RPOKCO.
        /// </summary>
        public const string RPOKCO = "RPOKCO";

        /// <summary>
        /// RPOSFX.
        /// </summary>
        public const string RPOSFX = "RPOSFX";

        /// <summary>
        /// RPVINV.
        /// </summary>
        public const string RPVINV = "RPVINV";

        /// <summary>
        /// RPPO.
        /// </summary>
        public const string RPPO = "RPPO";

        /// <summary>
        /// RPPDCT.
        /// </summary>
        public const string RPPDCT = "RPPDCT";

        /// <summary>
        /// RPPKCO.
        /// </summary>
        public const string RPPKCO = "RPPKCO";

        /// <summary>
        /// RPDCTO.
        /// </summary>
        public const string RPDCTO = "RPDCTO";

        /// <summary>
        /// RPLNID.
        /// </summary>
        public const string RPLNID = "RPLNID";

        /// <summary>
        /// RPSDOC.
        /// </summary>
        public const string RPSDOC = "RPSDOC";

        /// <summary>
        /// RPSDCT.
        /// </summary>
        public const string RPSDCT = "RPSDCT";

        /// <summary>
        /// RPSKCO.
        /// </summary>
        public const string RPSKCO = "RPSKCO";

        /// <summary>
        /// RPSFXO.
        /// </summary>
        public const string RPSFXO = "RPSFXO";

        /// <summary>
        /// RPVLDT.
        /// </summary>
        public const string RPVLDT = "RPVLDT";

        /// <summary>
        /// RPCMC1.
        /// </summary>
        public const string RPCMC1 = "RPCMC1";

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
        /// RPALPH.
        /// </summary>
        public const string RPALPH = "RPALPH";

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
        /// RPITM.
        /// </summary>
        public const string RPITM = "RPITM";

        /// <summary>
        /// RPU.
        /// </summary>
        public const string RPU = "RPU";

        /// <summary>
        /// RPUM.
        /// </summary>
        public const string RPUM = "RPUM";

        /// <summary>
        /// RPALT6.
        /// </summary>
        public const string RPALT6 = "RPALT6";

        /// <summary>
        /// RPRYIN.
        /// </summary>
        public const string RPRYIN = "RPRYIN";

        /// <summary>
        /// RPVDGJ.
        /// </summary>
        public const string RPVDGJ = "RPVDGJ";

        /// <summary>
        /// RPVOD.
        /// </summary>
        public const string RPVOD = "RPVOD";

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
        /// RPAR01.
        /// </summary>
        public const string RPAR01 = "RPAR01";

        /// <summary>
        /// RPAR02.
        /// </summary>
        public const string RPAR02 = "RPAR02";

        /// <summary>
        /// RPAR03.
        /// </summary>
        public const string RPAR03 = "RPAR03";

        /// <summary>
        /// RPAR04.
        /// </summary>
        public const string RPAR04 = "RPAR04";

        /// <summary>
        /// RPAR05.
        /// </summary>
        public const string RPAR05 = "RPAR05";

        /// <summary>
        /// RPAR06.
        /// </summary>
        public const string RPAR06 = "RPAR06";

        /// <summary>
        /// RPAR07.
        /// </summary>
        public const string RPAR07 = "RPAR07";

        /// <summary>
        /// RPAR08.
        /// </summary>
        public const string RPAR08 = "RPAR08";

        /// <summary>
        /// RPAR09.
        /// </summary>
        public const string RPAR09 = "RPAR09";

        /// <summary>
        /// RPAR10.
        /// </summary>
        public const string RPAR10 = "RPAR10";

        /// <summary>
        /// RPISTC.
        /// </summary>
        public const string RPISTC = "RPISTC";

        /// <summary>
        /// RPPYID.
        /// </summary>
        public const string RPPYID = "RPPYID";

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
        /// RPRNID.
        /// </summary>
        public const string RPRNID = "RPRNID";

        /// <summary>
        /// RPPPDI.
        /// </summary>
        public const string RPPPDI = "RPPPDI";

        /// <summary>
        /// RPTORG.
        /// </summary>
        public const string RPTORG = "RPTORG";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPJCL.
        /// </summary>
        public const string RPJCL = "RPJCL";

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
        /// RPDDEX.
        /// </summary>
        public const string RPDDEX = "RPDDEX";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPHCRR.
        /// </summary>
        public const string RPHCRR = "RPHCRR";

        /// <summary>
        /// RPHDGJ.
        /// </summary>
        public const string RPHDGJ = "RPHDGJ";

        /// <summary>
        /// RPSHPN.
        /// </summary>
        public const string RPSHPN = "RPSHPN";

        /// <summary>
        /// RPDTXS.
        /// </summary>
        public const string RPDTXS = "RPDTXS";

        /// <summary>
        /// RPOMOD.
        /// </summary>
        public const string RPOMOD = "RPOMOD";

        /// <summary>
        /// RPCLMG.
        /// </summary>
        public const string RPCLMG = "RPCLMG";

        /// <summary>
        /// RPCMGR.
        /// </summary>
        public const string RPCMGR = "RPCMGR";

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
        /// RPPRGF.
        /// </summary>
        public const string RPPRGF = "RPPRGF";

        /// <summary>
        /// RPGFL1.
        /// </summary>
        public const string RPGFL1 = "RPGFL1";

        /// <summary>
        /// RPGFL2.
        /// </summary>
        public const string RPGFL2 = "RPGFL2";

        /// <summary>
        /// RPDOCO.
        /// </summary>
        public const string RPDOCO = "RPDOCO";

        /// <summary>
        /// RPKCOO.
        /// </summary>
        public const string RPKCOO = "RPKCOO";

        /// <summary>
        /// RPSOTF.
        /// </summary>
        public const string RPSOTF = "RPSOTF";

        /// <summary>
        /// RPDTPB.
        /// </summary>
        public const string RPDTPB = "RPDTPB";

        /// <summary>
        /// RPERDJ.
        /// </summary>
        public const string RPERDJ = "RPERDJ";

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
        /// RPAJCL.
        /// </summary>
        public const string RPAJCL = "RPAJCL";

        /// <summary>
        /// RPRMR1.
        /// </summary>
        public const string RPRMR1 = "RPRMR1";
    }

    /// <inheritdoc />
    public override string TableName => "F03B11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric),
        new JdeField("RPDGJ", "RPDGJ", JdeDataType.Numeric),
        new JdeField("RPDIVJ", "RPDIVJ", JdeDataType.Numeric),
        new JdeField("RPICUT", "RPICUT", JdeDataType.String, 4),
        new JdeField("RPICU", "RPICU", JdeDataType.Numeric),
        new JdeField("RPDICJ", "RPDICJ", JdeDataType.Numeric),
        new JdeField("RPFY", "RPFY", JdeDataType.Numeric),
        new JdeField("RPCTRY", "RPCTRY", JdeDataType.Numeric),
        new JdeField("RPPN", "RPPN", JdeDataType.Numeric),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10),
        new JdeField("RPGLC", "RPGLC", JdeDataType.String, 8),
        new JdeField("RPAID", "RPAID", JdeDataType.String, 16),
        new JdeField("RPPA8", "RPPA8", JdeDataType.Numeric),
        new JdeField("RPAN8J", "RPAN8J", JdeDataType.Numeric),
        new JdeField("RPPYR", "RPPYR", JdeDataType.Numeric),
        new JdeField("RPPOST", "RPPOST", JdeDataType.String, 2),
        new JdeField("RPISTR", "RPISTR", JdeDataType.String, 2),
        new JdeField("RPBALJ", "RPBALJ", JdeDataType.String, 2),
        new JdeField("RPPST", "RPPST", JdeDataType.String, 2),
        new JdeField("RPAG", "RPAG", JdeDataType.Numeric),
        new JdeField("RPAAP", "RPAAP", JdeDataType.Numeric),
        new JdeField("RPADSC", "RPADSC", JdeDataType.Numeric),
        new JdeField("RPADSA", "RPADSA", JdeDataType.Numeric),
        new JdeField("RPATXA", "RPATXA", JdeDataType.Numeric),
        new JdeField("RPATXN", "RPATXN", JdeDataType.Numeric),
        new JdeField("RPSTAM", "RPSTAM", JdeDataType.Numeric),
        new JdeField("RPBCRC", "RPBCRC", JdeDataType.String, 6),
        new JdeField("RPCRRM", "RPCRRM", JdeDataType.String, 2),
        new JdeField("RPCRCD", "RPCRCD", JdeDataType.String, 6),
        new JdeField("RPCRR", "RPCRR", JdeDataType.Numeric),
        new JdeField("RPDMCD", "RPDMCD", JdeDataType.String, 2),
        new JdeField("RPACR", "RPACR", JdeDataType.Numeric),
        new JdeField("RPFAP", "RPFAP", JdeDataType.Numeric),
        new JdeField("RPCDS", "RPCDS", JdeDataType.Numeric),
        new JdeField("RPCDSA", "RPCDSA", JdeDataType.Numeric),
        new JdeField("RPCTXA", "RPCTXA", JdeDataType.Numeric),
        new JdeField("RPCTXN", "RPCTXN", JdeDataType.Numeric),
        new JdeField("RPCTAM", "RPCTAM", JdeDataType.Numeric),
        new JdeField("RPTXA1", "RPTXA1", JdeDataType.String, 20),
        new JdeField("RPEXR1", "RPEXR1", JdeDataType.String, 4),
        new JdeField("RPDSVJ", "RPDSVJ", JdeDataType.Numeric),
        new JdeField("RPGLBA", "RPGLBA", JdeDataType.String, 16),
        new JdeField("RPAM", "RPAM", JdeDataType.String, 2),
        new JdeField("RPAID2", "RPAID2", JdeDataType.String, 16),
        new JdeField("RPAM2", "RPAM2", JdeDataType.String, 2),
        new JdeField("RPMCU", "RPMCU", JdeDataType.String, 24),
        new JdeField("RPOBJ", "RPOBJ", JdeDataType.String, 12),
        new JdeField("RPSUB", "RPSUB", JdeDataType.String, 16),
        new JdeField("RPSBLT", "RPSBLT", JdeDataType.String, 2),
        new JdeField("RPSBL", "RPSBL", JdeDataType.String, 16),
        new JdeField("RPPTC", "RPPTC", JdeDataType.String, 6),
        new JdeField("RPDDJ", "RPDDJ", JdeDataType.Numeric),
        new JdeField("RPDDNJ", "RPDDNJ", JdeDataType.Numeric),
        new JdeField("RPRDDJ", "RPRDDJ", JdeDataType.Numeric),
        new JdeField("RPRDSJ", "RPRDSJ", JdeDataType.Numeric),
        new JdeField("RPLFCJ", "RPLFCJ", JdeDataType.Numeric),
        new JdeField("RPSMTJ", "RPSMTJ", JdeDataType.Numeric),
        new JdeField("RPNBRR", "RPNBRR", JdeDataType.String, 2),
        new JdeField("RPRDRL", "RPRDRL", JdeDataType.String, 2),
        new JdeField("RPRMDS", "RPRMDS", JdeDataType.Numeric),
        new JdeField("RPCOLL", "RPCOLL", JdeDataType.String, 2),
        new JdeField("RPCORC", "RPCORC", JdeDataType.String, 4),
        new JdeField("RPAFC", "RPAFC", JdeDataType.String, 2),
        new JdeField("RPDNLT", "RPDNLT", JdeDataType.String, 2),
        new JdeField("RPRSCO", "RPRSCO", JdeDataType.String, 4),
        new JdeField("RPODOC", "RPODOC", JdeDataType.Numeric),
        new JdeField("RPODCT", "RPODCT", JdeDataType.String, 4),
        new JdeField("RPOKCO", "RPOKCO", JdeDataType.String, 10),
        new JdeField("RPOSFX", "RPOSFX", JdeDataType.String, 6),
        new JdeField("RPVINV", "RPVINV", JdeDataType.String, 50),
        new JdeField("RPPO", "RPPO", JdeDataType.String, 16),
        new JdeField("RPPDCT", "RPPDCT", JdeDataType.String, 4),
        new JdeField("RPPKCO", "RPPKCO", JdeDataType.String, 10),
        new JdeField("RPDCTO", "RPDCTO", JdeDataType.String, 4),
        new JdeField("RPLNID", "RPLNID", JdeDataType.Numeric),
        new JdeField("RPSDOC", "RPSDOC", JdeDataType.Numeric),
        new JdeField("RPSDCT", "RPSDCT", JdeDataType.String, 4),
        new JdeField("RPSKCO", "RPSKCO", JdeDataType.String, 10),
        new JdeField("RPSFXO", "RPSFXO", JdeDataType.String, 6),
        new JdeField("RPVLDT", "RPVLDT", JdeDataType.Numeric),
        new JdeField("RPCMC1", "RPCMC1", JdeDataType.Numeric),
        new JdeField("RPVR01", "RPVR01", JdeDataType.String, 50),
        new JdeField("RPUNIT", "RPUNIT", JdeDataType.String, 16),
        new JdeField("RPMCU2", "RPMCU2", JdeDataType.String, 24),
        new JdeField("RPRMK", "RPRMK", JdeDataType.String, 60),
        new JdeField("RPALPH", "RPALPH", JdeDataType.String, 80),
        new JdeField("RPRF", "RPRF", JdeDataType.String, 4),
        new JdeField("RPDRF", "RPDRF", JdeDataType.Numeric),
        new JdeField("RPCTL", "RPCTL", JdeDataType.String, 26),
        new JdeField("RPFNLP", "RPFNLP", JdeDataType.String, 2),
        new JdeField("RPITM", "RPITM", JdeDataType.Numeric),
        new JdeField("RPU", "RPU", JdeDataType.Numeric),
        new JdeField("RPUM", "RPUM", JdeDataType.String, 4),
        new JdeField("RPALT6", "RPALT6", JdeDataType.String, 2),
        new JdeField("RPRYIN", "RPRYIN", JdeDataType.String, 2),
        new JdeField("RPVDGJ", "RPVDGJ", JdeDataType.Numeric),
        new JdeField("RPVOD", "RPVOD", JdeDataType.String, 2),
        new JdeField("RPRP1", "RPRP1", JdeDataType.String, 2),
        new JdeField("RPRP2", "RPRP2", JdeDataType.String, 2),
        new JdeField("RPRP3", "RPRP3", JdeDataType.String, 2),
        new JdeField("RPAR01", "RPAR01", JdeDataType.String, 6),
        new JdeField("RPAR02", "RPAR02", JdeDataType.String, 6),
        new JdeField("RPAR03", "RPAR03", JdeDataType.String, 6),
        new JdeField("RPAR04", "RPAR04", JdeDataType.String, 6),
        new JdeField("RPAR05", "RPAR05", JdeDataType.String, 6),
        new JdeField("RPAR06", "RPAR06", JdeDataType.String, 6),
        new JdeField("RPAR07", "RPAR07", JdeDataType.String, 6),
        new JdeField("RPAR08", "RPAR08", JdeDataType.String, 6),
        new JdeField("RPAR09", "RPAR09", JdeDataType.String, 6),
        new JdeField("RPAR10", "RPAR10", JdeDataType.String, 6),
        new JdeField("RPISTC", "RPISTC", JdeDataType.String, 2),
        new JdeField("RPPYID", "RPPYID", JdeDataType.Numeric),
        new JdeField("RPURC1", "RPURC1", JdeDataType.String, 6),
        new JdeField("RPURDT", "RPURDT", JdeDataType.Numeric),
        new JdeField("RPURAT", "RPURAT", JdeDataType.Numeric),
        new JdeField("RPURAB", "RPURAB", JdeDataType.Numeric),
        new JdeField("RPURRF", "RPURRF", JdeDataType.String, 30),
        new JdeField("RPRNID", "RPRNID", JdeDataType.Numeric),
        new JdeField("RPPPDI", "RPPPDI", JdeDataType.Numeric),
        new JdeField("RPTORG", "RPTORG", JdeDataType.String, 20),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPJCL", "RPJCL", JdeDataType.Numeric),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPDDEX", "RPDDEX", JdeDataType.String, 4),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPHCRR", "RPHCRR", JdeDataType.Numeric),
        new JdeField("RPHDGJ", "RPHDGJ", JdeDataType.Numeric),
        new JdeField("RPSHPN", "RPSHPN", JdeDataType.Numeric),
        new JdeField("RPDTXS", "RPDTXS", JdeDataType.String, 2),
        new JdeField("RPOMOD", "RPOMOD", JdeDataType.String, 2),
        new JdeField("RPCLMG", "RPCLMG", JdeDataType.String, 20),
        new JdeField("RPCMGR", "RPCMGR", JdeDataType.String, 20),
        new JdeField("RPATAD", "RPATAD", JdeDataType.Numeric),
        new JdeField("RPCTAD", "RPCTAD", JdeDataType.Numeric),
        new JdeField("RPNRTA", "RPNRTA", JdeDataType.Numeric),
        new JdeField("RPFNRT", "RPFNRT", JdeDataType.Numeric),
        new JdeField("RPPRGF", "RPPRGF", JdeDataType.String, 2),
        new JdeField("RPGFL1", "RPGFL1", JdeDataType.String, 2),
        new JdeField("RPGFL2", "RPGFL2", JdeDataType.String, 2),
        new JdeField("RPDOCO", "RPDOCO", JdeDataType.Numeric),
        new JdeField("RPKCOO", "RPKCOO", JdeDataType.String, 10),
        new JdeField("RPSOTF", "RPSOTF", JdeDataType.String, 2),
        new JdeField("RPDTPB", "RPDTPB", JdeDataType.Numeric),
        new JdeField("RPERDJ", "RPERDJ", JdeDataType.Numeric),
        new JdeField("RPPWPG", "RPPWPG", JdeDataType.Numeric),
        new JdeField("RPNETTCID", "RPNETTCID", JdeDataType.Numeric),
        new JdeField("RPNETDOC", "RPNETDOC", JdeDataType.Numeric),
        new JdeField("RPNETRC5", "RPNETRC5", JdeDataType.Numeric),
        new JdeField("RPNETST", "RPNETST", JdeDataType.String, 2),
        new JdeField("RPAJCL", "RPAJCL", JdeDataType.Numeric),
        new JdeField("RPRMR1", "RPRMR1", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B11_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B11_10", "Index on RPCTL, RPAN8", new[] { "RPCTL", "RPAN8" }),
        new JdeIndex("F03B11_11", "Index on RPPYR, RPDDJ, RPDOC, RPDCT, RPKCO, RPSFX", new[] { "RPPYR", "RPDDJ", "RPDOC", "RPDCT", "RPKCO", "RPSFX" }),
        new JdeIndex("F03B11_12", "Index on RPDOC, RPDCT, RPKCO, SYS_NC00158$", new[] { "RPDOC", "RPDCT", "RPKCO", "SYS_NC00158$" }),
        new JdeIndex("F03B11_13", "Index on RPDCT, RPDOC, RPKCO, RPSFX", new[] { "RPDCT", "RPDOC", "RPKCO", "RPSFX" }),
        new JdeIndex("F03B11_14", "Index on RPCO, RPPYR, RPAN8, RPCRCD, RPDGJ, RPDOC, RPDCT, RPKCO", new[] { "RPCO", "RPPYR", "RPAN8", "RPCRCD", "RPDGJ", "RPDOC", "RPDCT", "RPKCO" }),
        new JdeIndex("F03B11_15", "Index on RPPO, RPGLC, RPDGJ", new[] { "RPPO", "RPGLC", "RPDGJ" }),
        new JdeIndex("F03B11_16", "Index on RPPO, RPDIVJ", new[] { "RPPO", "RPDIVJ" }),
        new JdeIndex("F03B11_17", "Index on RPAN8, RPDCT, RPDOC, RPKCO, RPSFX", new[] { "RPAN8", "RPDCT", "RPDOC", "RPKCO", "RPSFX" }),
        new JdeIndex("F03B11_18", "Index on RPAN8, RPDGJ, RPDCT, RPDOC, RPKCO, RPSFX", new[] { "RPAN8", "RPDGJ", "RPDCT", "RPDOC", "RPKCO", "RPSFX" }),
        new JdeIndex("F03B11_19", "Index on RPAN8, RPLNID, RPDOC, RPDDJ, RPPO", new[] { "RPAN8", "RPLNID", "RPDOC", "RPDDJ", "RPPO" }),
        new JdeIndex("F03B11_20", "Index on RPDOC, RPDCT, RPKCO", new[] { "RPDOC", "RPDCT", "RPKCO" }),
        new JdeIndex("F03B11_21", "Index on RPAN8, RPCO", new[] { "RPAN8", "RPCO" }),
        new JdeIndex("F03B11_22", "Index on RPPO, RPPDCT, RPPKCO, RPSFXO, RPLNID", new[] { "RPPO", "RPPDCT", "RPPKCO", "RPSFXO", "RPLNID" }),
        new JdeIndex("F03B11_23", "Index on RPAN8, RPCO, RPDGJ, RPVDGJ", new[] { "RPAN8", "RPCO", "RPDGJ", "RPVDGJ" }),
        new JdeIndex("F03B11_24", "Index on RPPWPG, RPAN8, RPCO", new[] { "RPPWPG", "RPAN8", "RPCO" }),
        new JdeIndex("F03B11_25", "Index on RPNETTCID, RPNETDOC, RPNETRC5", new[] { "RPNETTCID", "RPNETDOC", "RPNETRC5" }),
        new JdeIndex("F03B11_26", "Index on RPNETTCID, RPNETDOC, RPNETRC5, RPVOD", new[] { "RPNETTCID", "RPNETDOC", "RPNETRC5", "RPVOD" }),
        new JdeIndex("F03B11_3", "Index on RPAN8, RPDDJ, RPDOC, RPDCT, RPKCO, RPSFX", new[] { "RPAN8", "RPDDJ", "RPDOC", "RPDCT", "RPKCO", "RPSFX" }),
        new JdeIndex("F03B11_4", "Index on RPICUT, RPICU, RPDOC, RPDCT, RPKCO, RPSFX, RPCO, RPGLC", new[] { "RPICUT", "RPICU", "RPDOC", "RPDCT", "RPKCO", "RPSFX", "RPCO", "RPGLC" }),
        new JdeIndex("F03B11_5", "Index on RPICUT, RPICU, RPCO, RPGLC, RPPN, RPFY, RPCTRY", new[] { "RPICUT", "RPICU", "RPCO", "RPGLC", "RPPN", "RPFY", "RPCTRY" }),
        new JdeIndex("F03B11_6", "Index on RPICUT, RPICU, RPPOST", new[] { "RPICUT", "RPICU", "RPPOST" }),
        new JdeIndex("F03B11_7", "Index on RPAN8, RPKCO", new[] { "RPAN8", "RPKCO" }),
        new JdeIndex("F03B11_9", "Index on RPPYID, RPDCT, RPDOC, RPKCO, RPSFX", new[] { "RPPYID", "RPDCT", "RPDOC", "RPKCO", "RPSFX" })
    };
}
