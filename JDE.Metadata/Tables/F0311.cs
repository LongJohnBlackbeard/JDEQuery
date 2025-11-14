using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0311 - .
/// </summary>
public class F0311 : JdeTable
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
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPDIVJ.
        /// </summary>
        public const string RPDIVJ = "RPDIVJ";

        /// <summary>
        /// RPDCTM.
        /// </summary>
        public const string RPDCTM = "RPDCTM";

        /// <summary>
        /// RPDOCM.
        /// </summary>
        public const string RPDOCM = "RPDOCM";

        /// <summary>
        /// RPSFXM.
        /// </summary>
        public const string RPSFXM = "RPSFXM";

        /// <summary>
        /// RPDMTJ.
        /// </summary>
        public const string RPDMTJ = "RPDMTJ";

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
        /// RPPA8.
        /// </summary>
        public const string RPPA8 = "RPPA8";

        /// <summary>
        /// RPAN8J.
        /// </summary>
        public const string RPAN8J = "RPAN8J";

        /// <summary>
        /// RPPOST.
        /// </summary>
        public const string RPPOST = "RPPOST";

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
        /// RPGLC.
        /// </summary>
        public const string RPGLC = "RPGLC";

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
        /// RPBAID.
        /// </summary>
        public const string RPBAID = "RPBAID";

        /// <summary>
        /// RPCM.
        /// </summary>
        public const string RPCM = "RPCM";

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
        /// RPDPRJ.
        /// </summary>
        public const string RPDPRJ = "RPDPRJ";

        /// <summary>
        /// RPSMTJ.
        /// </summary>
        public const string RPSMTJ = "RPSMTJ";

        /// <summary>
        /// RPCLDJ.
        /// </summary>
        public const string RPCLDJ = "RPCLDJ";

        /// <summary>
        /// RPITIJ.
        /// </summary>
        public const string RPITIJ = "RPITIJ";

        /// <summary>
        /// RPRDDJ.
        /// </summary>
        public const string RPRDDJ = "RPRDDJ";

        /// <summary>
        /// RPRDSJ.
        /// </summary>
        public const string RPRDSJ = "RPRDSJ";

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
        /// RPCLRC.
        /// </summary>
        public const string RPCLRC = "RPCLRC";

        /// <summary>
        /// RPAFC.
        /// </summary>
        public const string RPAFC = "RPAFC";

        /// <summary>
        /// RPNSF.
        /// </summary>
        public const string RPNSF = "RPNSF";

        /// <summary>
        /// RPAR.
        /// </summary>
        public const string RPAR = "RPAR";

        /// <summary>
        /// RPTRTC.
        /// </summary>
        public const string RPTRTC = "RPTRTC";

        /// <summary>
        /// RPPRT1.
        /// </summary>
        public const string RPPRT1 = "RPPRT1";

        /// <summary>
        /// RPODOC.
        /// </summary>
        public const string RPODOC = "RPODOC";

        /// <summary>
        /// RPODCT.
        /// </summary>
        public const string RPODCT = "RPODCT";

        /// <summary>
        /// RPOSFX.
        /// </summary>
        public const string RPOSFX = "RPOSFX";

        /// <summary>
        /// RPCRC.
        /// </summary>
        public const string RPCRC = "RPCRC";

        /// <summary>
        /// RPVLDT.
        /// </summary>
        public const string RPVLDT = "RPVLDT";

        /// <summary>
        /// RPVINV.
        /// </summary>
        public const string RPVINV = "RPVINV";

        /// <summary>
        /// RPPO.
        /// </summary>
        public const string RPPO = "RPPO";

        /// <summary>
        /// RPDCTO.
        /// </summary>
        public const string RPDCTO = "RPDCTO";

        /// <summary>
        /// RPLNID.
        /// </summary>
        public const string RPLNID = "RPLNID";

        /// <summary>
        /// RPSFXO.
        /// </summary>
        public const string RPSFXO = "RPSFXO";

        /// <summary>
        /// RPSDCT.
        /// </summary>
        public const string RPSDCT = "RPSDCT";

        /// <summary>
        /// RPSDOC.
        /// </summary>
        public const string RPSDOC = "RPSDOC";

        /// <summary>
        /// RPOPSQ.
        /// </summary>
        public const string RPOPSQ = "RPOPSQ";

        /// <summary>
        /// RPCMC1.
        /// </summary>
        public const string RPCMC1 = "RPCMC1";

        /// <summary>
        /// RPVR01.
        /// </summary>
        public const string RPVR01 = "RPVR01";

        /// <summary>
        /// RPNUMB.
        /// </summary>
        public const string RPNUMB = "RPNUMB";

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
        /// RPALT6.
        /// </summary>
        public const string RPALT6 = "RPALT6";

        /// <summary>
        /// RPPYIN.
        /// </summary>
        public const string RPPYIN = "RPPYIN";

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
        /// RPALPH.
        /// </summary>
        public const string RPALPH = "RPALPH";

        /// <summary>
        /// RPAC01.
        /// </summary>
        public const string RPAC01 = "RPAC01";

        /// <summary>
        /// RPAC02.
        /// </summary>
        public const string RPAC02 = "RPAC02";

        /// <summary>
        /// RPAC03.
        /// </summary>
        public const string RPAC03 = "RPAC03";

        /// <summary>
        /// RPAC04.
        /// </summary>
        public const string RPAC04 = "RPAC04";

        /// <summary>
        /// RPAC05.
        /// </summary>
        public const string RPAC05 = "RPAC05";

        /// <summary>
        /// RPAC06.
        /// </summary>
        public const string RPAC06 = "RPAC06";

        /// <summary>
        /// RPAC07.
        /// </summary>
        public const string RPAC07 = "RPAC07";

        /// <summary>
        /// RPAC08.
        /// </summary>
        public const string RPAC08 = "RPAC08";

        /// <summary>
        /// RPAC09.
        /// </summary>
        public const string RPAC09 = "RPAC09";

        /// <summary>
        /// RPAC10.
        /// </summary>
        public const string RPAC10 = "RPAC10";

        /// <summary>
        /// RPATE.
        /// </summary>
        public const string RPATE = "RPATE";

        /// <summary>
        /// RPATR.
        /// </summary>
        public const string RPATR = "RPATR";

        /// <summary>
        /// RPATP.
        /// </summary>
        public const string RPATP = "RPATP";

        /// <summary>
        /// RPATO.
        /// </summary>
        public const string RPATO = "RPATO";

        /// <summary>
        /// RPATPR.
        /// </summary>
        public const string RPATPR = "RPATPR";

        /// <summary>
        /// RPAT1.
        /// </summary>
        public const string RPAT1 = "RPAT1";

        /// <summary>
        /// RPAT2.
        /// </summary>
        public const string RPAT2 = "RPAT2";

        /// <summary>
        /// RPAT3.
        /// </summary>
        public const string RPAT3 = "RPAT3";

        /// <summary>
        /// RPAT4.
        /// </summary>
        public const string RPAT4 = "RPAT4";

        /// <summary>
        /// RPAT5.
        /// </summary>
        public const string RPAT5 = "RPAT5";

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
        /// RPDMCD.
        /// </summary>
        public const string RPDMCD = "RPDMCD";

        /// <summary>
        /// RPSKCO.
        /// </summary>
        public const string RPSKCO = "RPSKCO";

        /// <summary>
        /// RPPDCT.
        /// </summary>
        public const string RPPDCT = "RPPDCT";

        /// <summary>
        /// RPPKCO.
        /// </summary>
        public const string RPPKCO = "RPPKCO";

        /// <summary>
        /// RPOKCO.
        /// </summary>
        public const string RPOKCO = "RPOKCO";

        /// <summary>
        /// RPITM.
        /// </summary>
        public const string RPITM = "RPITM";

        /// <summary>
        /// RPBKTR.
        /// </summary>
        public const string RPBKTR = "RPBKTR";

        /// <summary>
        /// RPHCRR.
        /// </summary>
        public const string RPHCRR = "RPHCRR";

        /// <summary>
        /// RPHDGJ.
        /// </summary>
        public const string RPHDGJ = "RPHDGJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPDIVJ", "RPDIVJ", JdeDataType.Numeric),
        new JdeField("RPDCTM", "RPDCTM", JdeDataType.String, 4, true, true),
        new JdeField("RPDOCM", "RPDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("RPSFXM", "RPSFXM", JdeDataType.String, 6),
        new JdeField("RPDMTJ", "RPDMTJ", JdeDataType.Numeric),
        new JdeField("RPDGJ", "RPDGJ", JdeDataType.Numeric),
        new JdeField("RPFY", "RPFY", JdeDataType.Numeric),
        new JdeField("RPCTRY", "RPCTRY", JdeDataType.Numeric),
        new JdeField("RPPN", "RPPN", JdeDataType.Numeric),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10),
        new JdeField("RPICUT", "RPICUT", JdeDataType.String, 4),
        new JdeField("RPICU", "RPICU", JdeDataType.Numeric),
        new JdeField("RPDICJ", "RPDICJ", JdeDataType.Numeric),
        new JdeField("RPPA8", "RPPA8", JdeDataType.Numeric),
        new JdeField("RPAN8J", "RPAN8J", JdeDataType.Numeric),
        new JdeField("RPPOST", "RPPOST", JdeDataType.String, 2),
        new JdeField("RPBALJ", "RPBALJ", JdeDataType.String, 2),
        new JdeField("RPPST", "RPPST", JdeDataType.String, 2),
        new JdeField("RPAG", "RPAG", JdeDataType.Numeric),
        new JdeField("RPAAP", "RPAAP", JdeDataType.Numeric),
        new JdeField("RPADSC", "RPADSC", JdeDataType.Numeric),
        new JdeField("RPADSA", "RPADSA", JdeDataType.Numeric),
        new JdeField("RPATXA", "RPATXA", JdeDataType.Numeric),
        new JdeField("RPATXN", "RPATXN", JdeDataType.Numeric),
        new JdeField("RPSTAM", "RPSTAM", JdeDataType.Numeric),
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
        new JdeField("RPTXA1", "RPTXA1", JdeDataType.String, 20),
        new JdeField("RPEXR1", "RPEXR1", JdeDataType.String, 4),
        new JdeField("RPDSVJ", "RPDSVJ", JdeDataType.Numeric),
        new JdeField("RPGLC", "RPGLC", JdeDataType.String, 8),
        new JdeField("RPGLBA", "RPGLBA", JdeDataType.String, 16),
        new JdeField("RPAM", "RPAM", JdeDataType.String, 2),
        new JdeField("RPAID2", "RPAID2", JdeDataType.String, 16),
        new JdeField("RPAM2", "RPAM2", JdeDataType.String, 2),
        new JdeField("RPMCU", "RPMCU", JdeDataType.String, 24),
        new JdeField("RPOBJ", "RPOBJ", JdeDataType.String, 12),
        new JdeField("RPSUB", "RPSUB", JdeDataType.String, 16),
        new JdeField("RPSBLT", "RPSBLT", JdeDataType.String, 2),
        new JdeField("RPSBL", "RPSBL", JdeDataType.String, 16),
        new JdeField("RPBAID", "RPBAID", JdeDataType.String, 16),
        new JdeField("RPCM", "RPCM", JdeDataType.String, 4),
        new JdeField("RPPTC", "RPPTC", JdeDataType.String, 6),
        new JdeField("RPDDJ", "RPDDJ", JdeDataType.Numeric),
        new JdeField("RPDDNJ", "RPDDNJ", JdeDataType.Numeric),
        new JdeField("RPDPRJ", "RPDPRJ", JdeDataType.Numeric),
        new JdeField("RPSMTJ", "RPSMTJ", JdeDataType.Numeric),
        new JdeField("RPCLDJ", "RPCLDJ", JdeDataType.Numeric),
        new JdeField("RPITIJ", "RPITIJ", JdeDataType.Numeric),
        new JdeField("RPRDDJ", "RPRDDJ", JdeDataType.Numeric),
        new JdeField("RPRDSJ", "RPRDSJ", JdeDataType.Numeric),
        new JdeField("RPNBRR", "RPNBRR", JdeDataType.String, 2),
        new JdeField("RPRDRL", "RPRDRL", JdeDataType.String, 2),
        new JdeField("RPRMDS", "RPRMDS", JdeDataType.Numeric),
        new JdeField("RPCOLL", "RPCOLL", JdeDataType.String, 2),
        new JdeField("RPCLRC", "RPCLRC", JdeDataType.String, 4),
        new JdeField("RPAFC", "RPAFC", JdeDataType.String, 2),
        new JdeField("RPNSF", "RPNSF", JdeDataType.String, 2),
        new JdeField("RPAR", "RPAR", JdeDataType.String, 4),
        new JdeField("RPTRTC", "RPTRTC", JdeDataType.String, 2),
        new JdeField("RPPRT1", "RPPRT1", JdeDataType.String, 2),
        new JdeField("RPODOC", "RPODOC", JdeDataType.Numeric),
        new JdeField("RPODCT", "RPODCT", JdeDataType.String, 4),
        new JdeField("RPOSFX", "RPOSFX", JdeDataType.String, 6),
        new JdeField("RPCRC", "RPCRC", JdeDataType.String, 6),
        new JdeField("RPVLDT", "RPVLDT", JdeDataType.Numeric),
        new JdeField("RPVINV", "RPVINV", JdeDataType.String, 50),
        new JdeField("RPPO", "RPPO", JdeDataType.String, 16),
        new JdeField("RPDCTO", "RPDCTO", JdeDataType.String, 4),
        new JdeField("RPLNID", "RPLNID", JdeDataType.Numeric),
        new JdeField("RPSFXO", "RPSFXO", JdeDataType.String, 6),
        new JdeField("RPSDCT", "RPSDCT", JdeDataType.String, 4),
        new JdeField("RPSDOC", "RPSDOC", JdeDataType.Numeric),
        new JdeField("RPOPSQ", "RPOPSQ", JdeDataType.Numeric),
        new JdeField("RPCMC1", "RPCMC1", JdeDataType.Numeric),
        new JdeField("RPVR01", "RPVR01", JdeDataType.String, 50),
        new JdeField("RPNUMB", "RPNUMB", JdeDataType.Numeric),
        new JdeField("RPUNIT", "RPUNIT", JdeDataType.String, 16),
        new JdeField("RPMCU2", "RPMCU2", JdeDataType.String, 24),
        new JdeField("RPRMK", "RPRMK", JdeDataType.String, 60),
        new JdeField("RPRF", "RPRF", JdeDataType.String, 4),
        new JdeField("RPDRF", "RPDRF", JdeDataType.Numeric),
        new JdeField("RPCTL", "RPCTL", JdeDataType.String, 26),
        new JdeField("RPFNLP", "RPFNLP", JdeDataType.String, 2),
        new JdeField("RPU", "RPU", JdeDataType.Numeric),
        new JdeField("RPUM", "RPUM", JdeDataType.String, 4),
        new JdeField("RPALT6", "RPALT6", JdeDataType.String, 2),
        new JdeField("RPPYIN", "RPPYIN", JdeDataType.String, 2),
        new JdeField("RPRP1", "RPRP1", JdeDataType.String, 2),
        new JdeField("RPRP2", "RPRP2", JdeDataType.String, 2),
        new JdeField("RPRP3", "RPRP3", JdeDataType.String, 2),
        new JdeField("RPALPH", "RPALPH", JdeDataType.String, 80),
        new JdeField("RPAC01", "RPAC01", JdeDataType.String, 6),
        new JdeField("RPAC02", "RPAC02", JdeDataType.String, 6),
        new JdeField("RPAC03", "RPAC03", JdeDataType.String, 6),
        new JdeField("RPAC04", "RPAC04", JdeDataType.String, 6),
        new JdeField("RPAC05", "RPAC05", JdeDataType.String, 6),
        new JdeField("RPAC06", "RPAC06", JdeDataType.String, 6),
        new JdeField("RPAC07", "RPAC07", JdeDataType.String, 6),
        new JdeField("RPAC08", "RPAC08", JdeDataType.String, 6),
        new JdeField("RPAC09", "RPAC09", JdeDataType.String, 6),
        new JdeField("RPAC10", "RPAC10", JdeDataType.String, 6),
        new JdeField("RPATE", "RPATE", JdeDataType.String, 2),
        new JdeField("RPATR", "RPATR", JdeDataType.String, 2),
        new JdeField("RPATP", "RPATP", JdeDataType.String, 2),
        new JdeField("RPATO", "RPATO", JdeDataType.String, 2),
        new JdeField("RPATPR", "RPATPR", JdeDataType.String, 2),
        new JdeField("RPAT1", "RPAT1", JdeDataType.String, 6),
        new JdeField("RPAT2", "RPAT2", JdeDataType.String, 2),
        new JdeField("RPAT3", "RPAT3", JdeDataType.String, 2),
        new JdeField("RPAT4", "RPAT4", JdeDataType.String, 2),
        new JdeField("RPAT5", "RPAT5", JdeDataType.String, 2),
        new JdeField("RPTORG", "RPTORG", JdeDataType.String, 20),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPDMCD", "RPDMCD", JdeDataType.String, 2),
        new JdeField("RPSKCO", "RPSKCO", JdeDataType.String, 10),
        new JdeField("RPPDCT", "RPPDCT", JdeDataType.String, 4),
        new JdeField("RPPKCO", "RPPKCO", JdeDataType.String, 10),
        new JdeField("RPOKCO", "RPOKCO", JdeDataType.String, 10),
        new JdeField("RPITM", "RPITM", JdeDataType.Numeric),
        new JdeField("RPBKTR", "RPBKTR", JdeDataType.String, 16),
        new JdeField("RPHCRR", "RPHCRR", JdeDataType.Numeric),
        new JdeField("RPHDGJ", "RPHDGJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0311_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX, RPDOCM, RPDCTM", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX", "RPDOCM", "RPDCTM" }, isPrimaryKey: true),
        new JdeIndex("F0311_2", "Index on RPAN8", new[] { "RPAN8" }),
        new JdeIndex("F0311_3", "Index on RPDOC, RPDCT, RPKCO, SYS_NC00141$, RPDOCM, RPDCTM", new[] { "RPDOC", "RPDCT", "RPKCO", "SYS_NC00141$", "RPDOCM", "RPDCTM" }),
        new JdeIndex("F0311_4", "Index on RPCO", new[] { "RPCO" }),
        new JdeIndex("F0311_6", "Index on RPPO, RPPDCT, RPPKCO, RPSFXO, RPLNID", new[] { "RPPO", "RPPDCT", "RPPKCO", "RPSFXO", "RPLNID" })
    };
}
