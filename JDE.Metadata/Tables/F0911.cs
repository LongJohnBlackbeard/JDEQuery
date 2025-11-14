using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0911 - .
/// </summary>
public class F0911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLKCO.
        /// </summary>
        public const string GLKCO = "GLKCO";

        /// <summary>
        /// GLDCT.
        /// </summary>
        public const string GLDCT = "GLDCT";

        /// <summary>
        /// GLDOC.
        /// </summary>
        public const string GLDOC = "GLDOC";

        /// <summary>
        /// GLDGJ.
        /// </summary>
        public const string GLDGJ = "GLDGJ";

        /// <summary>
        /// GLJELN.
        /// </summary>
        public const string GLJELN = "GLJELN";

        /// <summary>
        /// GLEXTL.
        /// </summary>
        public const string GLEXTL = "GLEXTL";

        /// <summary>
        /// GLPOST.
        /// </summary>
        public const string GLPOST = "GLPOST";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLICUT.
        /// </summary>
        public const string GLICUT = "GLICUT";

        /// <summary>
        /// GLDICJ.
        /// </summary>
        public const string GLDICJ = "GLDICJ";

        /// <summary>
        /// GLDSYJ.
        /// </summary>
        public const string GLDSYJ = "GLDSYJ";

        /// <summary>
        /// GLTICU.
        /// </summary>
        public const string GLTICU = "GLTICU";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLANI.
        /// </summary>
        public const string GLANI = "GLANI";

        /// <summary>
        /// GLAM.
        /// </summary>
        public const string GLAM = "GLAM";

        /// <summary>
        /// GLAID.
        /// </summary>
        public const string GLAID = "GLAID";

        /// <summary>
        /// GLMCU.
        /// </summary>
        public const string GLMCU = "GLMCU";

        /// <summary>
        /// GLOBJ.
        /// </summary>
        public const string GLOBJ = "GLOBJ";

        /// <summary>
        /// GLSUB.
        /// </summary>
        public const string GLSUB = "GLSUB";

        /// <summary>
        /// GLSBL.
        /// </summary>
        public const string GLSBL = "GLSBL";

        /// <summary>
        /// GLSBLT.
        /// </summary>
        public const string GLSBLT = "GLSBLT";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLPN.
        /// </summary>
        public const string GLPN = "GLPN";

        /// <summary>
        /// GLCTRY.
        /// </summary>
        public const string GLCTRY = "GLCTRY";

        /// <summary>
        /// GLFY.
        /// </summary>
        public const string GLFY = "GLFY";

        /// <summary>
        /// GLFQ.
        /// </summary>
        public const string GLFQ = "GLFQ";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLCRR.
        /// </summary>
        public const string GLCRR = "GLCRR";

        /// <summary>
        /// GLHCRR.
        /// </summary>
        public const string GLHCRR = "GLHCRR";

        /// <summary>
        /// GLHDGJ.
        /// </summary>
        public const string GLHDGJ = "GLHDGJ";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";

        /// <summary>
        /// GLU.
        /// </summary>
        public const string GLU = "GLU";

        /// <summary>
        /// GLUM.
        /// </summary>
        public const string GLUM = "GLUM";

        /// <summary>
        /// GLGLC.
        /// </summary>
        public const string GLGLC = "GLGLC";

        /// <summary>
        /// GLRE.
        /// </summary>
        public const string GLRE = "GLRE";

        /// <summary>
        /// GLEXA.
        /// </summary>
        public const string GLEXA = "GLEXA";

        /// <summary>
        /// GLEXR.
        /// </summary>
        public const string GLEXR = "GLEXR";

        /// <summary>
        /// GLR1.
        /// </summary>
        public const string GLR1 = "GLR1";

        /// <summary>
        /// GLR2.
        /// </summary>
        public const string GLR2 = "GLR2";

        /// <summary>
        /// GLR3.
        /// </summary>
        public const string GLR3 = "GLR3";

        /// <summary>
        /// GLSFX.
        /// </summary>
        public const string GLSFX = "GLSFX";

        /// <summary>
        /// GLODOC.
        /// </summary>
        public const string GLODOC = "GLODOC";

        /// <summary>
        /// GLODCT.
        /// </summary>
        public const string GLODCT = "GLODCT";

        /// <summary>
        /// GLOSFX.
        /// </summary>
        public const string GLOSFX = "GLOSFX";

        /// <summary>
        /// GLPKCO.
        /// </summary>
        public const string GLPKCO = "GLPKCO";

        /// <summary>
        /// GLOKCO.
        /// </summary>
        public const string GLOKCO = "GLOKCO";

        /// <summary>
        /// GLPDCT.
        /// </summary>
        public const string GLPDCT = "GLPDCT";

        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";

        /// <summary>
        /// GLCN.
        /// </summary>
        public const string GLCN = "GLCN";

        /// <summary>
        /// GLDKJ.
        /// </summary>
        public const string GLDKJ = "GLDKJ";

        /// <summary>
        /// GLDKC.
        /// </summary>
        public const string GLDKC = "GLDKC";

        /// <summary>
        /// GLASID.
        /// </summary>
        public const string GLASID = "GLASID";

        /// <summary>
        /// GLBRE.
        /// </summary>
        public const string GLBRE = "GLBRE";

        /// <summary>
        /// GLRCND.
        /// </summary>
        public const string GLRCND = "GLRCND";

        /// <summary>
        /// GLSUMM.
        /// </summary>
        public const string GLSUMM = "GLSUMM";

        /// <summary>
        /// GLPRGE.
        /// </summary>
        public const string GLPRGE = "GLPRGE";

        /// <summary>
        /// GLTNN.
        /// </summary>
        public const string GLTNN = "GLTNN";

        /// <summary>
        /// GLALT1.
        /// </summary>
        public const string GLALT1 = "GLALT1";

        /// <summary>
        /// GLALT2.
        /// </summary>
        public const string GLALT2 = "GLALT2";

        /// <summary>
        /// GLALT3.
        /// </summary>
        public const string GLALT3 = "GLALT3";

        /// <summary>
        /// GLALT4.
        /// </summary>
        public const string GLALT4 = "GLALT4";

        /// <summary>
        /// GLALT5.
        /// </summary>
        public const string GLALT5 = "GLALT5";

        /// <summary>
        /// GLALT6.
        /// </summary>
        public const string GLALT6 = "GLALT6";

        /// <summary>
        /// GLALT7.
        /// </summary>
        public const string GLALT7 = "GLALT7";

        /// <summary>
        /// GLALT8.
        /// </summary>
        public const string GLALT8 = "GLALT8";

        /// <summary>
        /// GLALT9.
        /// </summary>
        public const string GLALT9 = "GLALT9";

        /// <summary>
        /// GLALT0.
        /// </summary>
        public const string GLALT0 = "GLALT0";

        /// <summary>
        /// GLALTT.
        /// </summary>
        public const string GLALTT = "GLALTT";

        /// <summary>
        /// GLALTU.
        /// </summary>
        public const string GLALTU = "GLALTU";

        /// <summary>
        /// GLALTV.
        /// </summary>
        public const string GLALTV = "GLALTV";

        /// <summary>
        /// GLALTW.
        /// </summary>
        public const string GLALTW = "GLALTW";

        /// <summary>
        /// GLALTX.
        /// </summary>
        public const string GLALTX = "GLALTX";

        /// <summary>
        /// GLALTZ.
        /// </summary>
        public const string GLALTZ = "GLALTZ";

        /// <summary>
        /// GLDLNA.
        /// </summary>
        public const string GLDLNA = "GLDLNA";

        /// <summary>
        /// GLCFF1.
        /// </summary>
        public const string GLCFF1 = "GLCFF1";

        /// <summary>
        /// GLCFF2.
        /// </summary>
        public const string GLCFF2 = "GLCFF2";

        /// <summary>
        /// GLASM.
        /// </summary>
        public const string GLASM = "GLASM";

        /// <summary>
        /// GLBC.
        /// </summary>
        public const string GLBC = "GLBC";

        /// <summary>
        /// GLVINV.
        /// </summary>
        public const string GLVINV = "GLVINV";

        /// <summary>
        /// GLIVD.
        /// </summary>
        public const string GLIVD = "GLIVD";

        /// <summary>
        /// GLWR01.
        /// </summary>
        public const string GLWR01 = "GLWR01";

        /// <summary>
        /// GLPO.
        /// </summary>
        public const string GLPO = "GLPO";

        /// <summary>
        /// GLPSFX.
        /// </summary>
        public const string GLPSFX = "GLPSFX";

        /// <summary>
        /// GLDCTO.
        /// </summary>
        public const string GLDCTO = "GLDCTO";

        /// <summary>
        /// GLLNID.
        /// </summary>
        public const string GLLNID = "GLLNID";

        /// <summary>
        /// GLWY.
        /// </summary>
        public const string GLWY = "GLWY";

        /// <summary>
        /// GLWN.
        /// </summary>
        public const string GLWN = "GLWN";

        /// <summary>
        /// GLFNLP.
        /// </summary>
        public const string GLFNLP = "GLFNLP";

        /// <summary>
        /// GLOPSQ.
        /// </summary>
        public const string GLOPSQ = "GLOPSQ";

        /// <summary>
        /// GLJBCD.
        /// </summary>
        public const string GLJBCD = "GLJBCD";

        /// <summary>
        /// GLJBST.
        /// </summary>
        public const string GLJBST = "GLJBST";

        /// <summary>
        /// GLHMCU.
        /// </summary>
        public const string GLHMCU = "GLHMCU";

        /// <summary>
        /// GLDOI.
        /// </summary>
        public const string GLDOI = "GLDOI";

        /// <summary>
        /// GLALID.
        /// </summary>
        public const string GLALID = "GLALID";

        /// <summary>
        /// GLALTY.
        /// </summary>
        public const string GLALTY = "GLALTY";

        /// <summary>
        /// GLDSVJ.
        /// </summary>
        public const string GLDSVJ = "GLDSVJ";

        /// <summary>
        /// GLTORG.
        /// </summary>
        public const string GLTORG = "GLTORG";

        /// <summary>
        /// GLREG#.
        /// </summary>
        public const string GLREG_ = "GLREG#";

        /// <summary>
        /// GLPYID.
        /// </summary>
        public const string GLPYID = "GLPYID";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";

        /// <summary>
        /// GLABR1.
        /// </summary>
        public const string GLABR1 = "GLABR1";

        /// <summary>
        /// GLABR2.
        /// </summary>
        public const string GLABR2 = "GLABR2";

        /// <summary>
        /// GLABR3.
        /// </summary>
        public const string GLABR3 = "GLABR3";

        /// <summary>
        /// GLABR4.
        /// </summary>
        public const string GLABR4 = "GLABR4";

        /// <summary>
        /// GLABT1.
        /// </summary>
        public const string GLABT1 = "GLABT1";

        /// <summary>
        /// GLABT2.
        /// </summary>
        public const string GLABT2 = "GLABT2";

        /// <summary>
        /// GLABT3.
        /// </summary>
        public const string GLABT3 = "GLABT3";

        /// <summary>
        /// GLABT4.
        /// </summary>
        public const string GLABT4 = "GLABT4";

        /// <summary>
        /// GLITM.
        /// </summary>
        public const string GLITM = "GLITM";

        /// <summary>
        /// GLPM01.
        /// </summary>
        public const string GLPM01 = "GLPM01";

        /// <summary>
        /// GLPM02.
        /// </summary>
        public const string GLPM02 = "GLPM02";

        /// <summary>
        /// GLPM03.
        /// </summary>
        public const string GLPM03 = "GLPM03";

        /// <summary>
        /// GLPM04.
        /// </summary>
        public const string GLPM04 = "GLPM04";

        /// <summary>
        /// GLPM05.
        /// </summary>
        public const string GLPM05 = "GLPM05";

        /// <summary>
        /// GLPM06.
        /// </summary>
        public const string GLPM06 = "GLPM06";

        /// <summary>
        /// GLPM07.
        /// </summary>
        public const string GLPM07 = "GLPM07";

        /// <summary>
        /// GLPM08.
        /// </summary>
        public const string GLPM08 = "GLPM08";

        /// <summary>
        /// GLPM09.
        /// </summary>
        public const string GLPM09 = "GLPM09";

        /// <summary>
        /// GLPM10.
        /// </summary>
        public const string GLPM10 = "GLPM10";

        /// <summary>
        /// GLBCRC.
        /// </summary>
        public const string GLBCRC = "GLBCRC";

        /// <summary>
        /// GLCRRM.
        /// </summary>
        public const string GLCRRM = "GLCRRM";

        /// <summary>
        /// GLPRGF.
        /// </summary>
        public const string GLPRGF = "GLPRGF";

        /// <summary>
        /// GLTXA1.
        /// </summary>
        public const string GLTXA1 = "GLTXA1";

        /// <summary>
        /// GLEXR1.
        /// </summary>
        public const string GLEXR1 = "GLEXR1";

        /// <summary>
        /// GLTXITM.
        /// </summary>
        public const string GLTXITM = "GLTXITM";

        /// <summary>
        /// GLACTB.
        /// </summary>
        public const string GLACTB = "GLACTB";

        /// <summary>
        /// GLGPF1.
        /// </summary>
        public const string GLGPF1 = "GLGPF1";

        /// <summary>
        /// GLACR.
        /// </summary>
        public const string GLACR = "GLACR";

        /// <summary>
        /// GLDLNID.
        /// </summary>
        public const string GLDLNID = "GLDLNID";

        /// <summary>
        /// GLCKNU.
        /// </summary>
        public const string GLCKNU = "GLCKNU";

        /// <summary>
        /// GLBUPC.
        /// </summary>
        public const string GLBUPC = "GLBUPC";

        /// <summary>
        /// GLAHBU.
        /// </summary>
        public const string GLAHBU = "GLAHBU";

        /// <summary>
        /// GLEPGC.
        /// </summary>
        public const string GLEPGC = "GLEPGC";

        /// <summary>
        /// GLJPGC.
        /// </summary>
        public const string GLJPGC = "GLJPGC";

        /// <summary>
        /// GLRC5.
        /// </summary>
        public const string GLRC5 = "GLRC5";

        /// <summary>
        /// GLSFXE.
        /// </summary>
        public const string GLSFXE = "GLSFXE";

        /// <summary>
        /// GLOFM.
        /// </summary>
        public const string GLOFM = "GLOFM";
    }

    /// <inheritdoc />
    public override string TableName => "F0911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10, true, true),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4, true, true),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GLDGJ", "GLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLJELN", "GLJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("GLEXTL", "GLEXTL", JdeDataType.String, 4, true, true),
        new JdeField("GLPOST", "GLPOST", JdeDataType.String, 2),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric),
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4),
        new JdeField("GLDICJ", "GLDICJ", JdeDataType.Numeric),
        new JdeField("GLDSYJ", "GLDSYJ", JdeDataType.Numeric),
        new JdeField("GLTICU", "GLTICU", JdeDataType.Numeric),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10),
        new JdeField("GLANI", "GLANI", JdeDataType.String, 58),
        new JdeField("GLAM", "GLAM", JdeDataType.String, 2),
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24),
        new JdeField("GLOBJ", "GLOBJ", JdeDataType.String, 12),
        new JdeField("GLSUB", "GLSUB", JdeDataType.String, 16),
        new JdeField("GLSBL", "GLSBL", JdeDataType.String, 16),
        new JdeField("GLSBLT", "GLSBLT", JdeDataType.String, 2),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4, true, true),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric),
        new JdeField("GLCTRY", "GLCTRY", JdeDataType.Numeric),
        new JdeField("GLFY", "GLFY", JdeDataType.Numeric),
        new JdeField("GLFQ", "GLFQ", JdeDataType.String, 8),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6),
        new JdeField("GLCRR", "GLCRR", JdeDataType.Numeric),
        new JdeField("GLHCRR", "GLHCRR", JdeDataType.Numeric),
        new JdeField("GLHDGJ", "GLHDGJ", JdeDataType.Numeric),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric),
        new JdeField("GLU", "GLU", JdeDataType.Numeric),
        new JdeField("GLUM", "GLUM", JdeDataType.String, 4),
        new JdeField("GLGLC", "GLGLC", JdeDataType.String, 8),
        new JdeField("GLRE", "GLRE", JdeDataType.String, 2),
        new JdeField("GLEXA", "GLEXA", JdeDataType.String, 60),
        new JdeField("GLEXR", "GLEXR", JdeDataType.String, 60),
        new JdeField("GLR1", "GLR1", JdeDataType.String, 16),
        new JdeField("GLR2", "GLR2", JdeDataType.String, 16),
        new JdeField("GLR3", "GLR3", JdeDataType.String, 16),
        new JdeField("GLSFX", "GLSFX", JdeDataType.String, 6),
        new JdeField("GLODOC", "GLODOC", JdeDataType.Numeric),
        new JdeField("GLODCT", "GLODCT", JdeDataType.String, 4),
        new JdeField("GLOSFX", "GLOSFX", JdeDataType.String, 6),
        new JdeField("GLPKCO", "GLPKCO", JdeDataType.String, 10),
        new JdeField("GLOKCO", "GLOKCO", JdeDataType.String, 10),
        new JdeField("GLPDCT", "GLPDCT", JdeDataType.String, 4),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLCN", "GLCN", JdeDataType.String, 16),
        new JdeField("GLDKJ", "GLDKJ", JdeDataType.Numeric),
        new JdeField("GLDKC", "GLDKC", JdeDataType.Numeric),
        new JdeField("GLASID", "GLASID", JdeDataType.String, 50),
        new JdeField("GLBRE", "GLBRE", JdeDataType.String, 2),
        new JdeField("GLRCND", "GLRCND", JdeDataType.String, 2),
        new JdeField("GLSUMM", "GLSUMM", JdeDataType.String, 2),
        new JdeField("GLPRGE", "GLPRGE", JdeDataType.String, 2),
        new JdeField("GLTNN", "GLTNN", JdeDataType.String, 2),
        new JdeField("GLALT1", "GLALT1", JdeDataType.String, 2),
        new JdeField("GLALT2", "GLALT2", JdeDataType.String, 2),
        new JdeField("GLALT3", "GLALT3", JdeDataType.String, 2),
        new JdeField("GLALT4", "GLALT4", JdeDataType.String, 2),
        new JdeField("GLALT5", "GLALT5", JdeDataType.String, 2),
        new JdeField("GLALT6", "GLALT6", JdeDataType.String, 2),
        new JdeField("GLALT7", "GLALT7", JdeDataType.String, 2),
        new JdeField("GLALT8", "GLALT8", JdeDataType.String, 2),
        new JdeField("GLALT9", "GLALT9", JdeDataType.String, 2),
        new JdeField("GLALT0", "GLALT0", JdeDataType.String, 2),
        new JdeField("GLALTT", "GLALTT", JdeDataType.String, 2),
        new JdeField("GLALTU", "GLALTU", JdeDataType.String, 2),
        new JdeField("GLALTV", "GLALTV", JdeDataType.String, 2),
        new JdeField("GLALTW", "GLALTW", JdeDataType.String, 2),
        new JdeField("GLALTX", "GLALTX", JdeDataType.String, 2),
        new JdeField("GLALTZ", "GLALTZ", JdeDataType.String, 2),
        new JdeField("GLDLNA", "GLDLNA", JdeDataType.String, 2),
        new JdeField("GLCFF1", "GLCFF1", JdeDataType.String, 2),
        new JdeField("GLCFF2", "GLCFF2", JdeDataType.String, 2),
        new JdeField("GLASM", "GLASM", JdeDataType.String, 2),
        new JdeField("GLBC", "GLBC", JdeDataType.String, 2),
        new JdeField("GLVINV", "GLVINV", JdeDataType.String, 50),
        new JdeField("GLIVD", "GLIVD", JdeDataType.Numeric),
        new JdeField("GLWR01", "GLWR01", JdeDataType.String, 8),
        new JdeField("GLPO", "GLPO", JdeDataType.String, 16),
        new JdeField("GLPSFX", "GLPSFX", JdeDataType.String, 6),
        new JdeField("GLDCTO", "GLDCTO", JdeDataType.String, 4),
        new JdeField("GLLNID", "GLLNID", JdeDataType.Numeric),
        new JdeField("GLWY", "GLWY", JdeDataType.Numeric),
        new JdeField("GLWN", "GLWN", JdeDataType.Numeric),
        new JdeField("GLFNLP", "GLFNLP", JdeDataType.String, 2),
        new JdeField("GLOPSQ", "GLOPSQ", JdeDataType.Numeric),
        new JdeField("GLJBCD", "GLJBCD", JdeDataType.String, 12),
        new JdeField("GLJBST", "GLJBST", JdeDataType.String, 8),
        new JdeField("GLHMCU", "GLHMCU", JdeDataType.String, 24),
        new JdeField("GLDOI", "GLDOI", JdeDataType.Numeric),
        new JdeField("GLALID", "GLALID", JdeDataType.String, 50),
        new JdeField("GLALTY", "GLALTY", JdeDataType.String, 4),
        new JdeField("GLDSVJ", "GLDSVJ", JdeDataType.Numeric),
        new JdeField("GLTORG", "GLTORG", JdeDataType.String, 20),
        new JdeField("GLREG#", "GLREG#", JdeDataType.Numeric),
        new JdeField("GLPYID", "GLPYID", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLABR1", "GLABR1", JdeDataType.String, 24),
        new JdeField("GLABR2", "GLABR2", JdeDataType.String, 24),
        new JdeField("GLABR3", "GLABR3", JdeDataType.String, 24),
        new JdeField("GLABR4", "GLABR4", JdeDataType.String, 24),
        new JdeField("GLABT1", "GLABT1", JdeDataType.String, 2),
        new JdeField("GLABT2", "GLABT2", JdeDataType.String, 2),
        new JdeField("GLABT3", "GLABT3", JdeDataType.String, 2),
        new JdeField("GLABT4", "GLABT4", JdeDataType.String, 2),
        new JdeField("GLITM", "GLITM", JdeDataType.Numeric),
        new JdeField("GLPM01", "GLPM01", JdeDataType.String, 2),
        new JdeField("GLPM02", "GLPM02", JdeDataType.String, 2),
        new JdeField("GLPM03", "GLPM03", JdeDataType.String, 2),
        new JdeField("GLPM04", "GLPM04", JdeDataType.String, 2),
        new JdeField("GLPM05", "GLPM05", JdeDataType.String, 2),
        new JdeField("GLPM06", "GLPM06", JdeDataType.String, 2),
        new JdeField("GLPM07", "GLPM07", JdeDataType.String, 2),
        new JdeField("GLPM08", "GLPM08", JdeDataType.String, 2),
        new JdeField("GLPM09", "GLPM09", JdeDataType.String, 2),
        new JdeField("GLPM10", "GLPM10", JdeDataType.String, 2),
        new JdeField("GLBCRC", "GLBCRC", JdeDataType.String, 6),
        new JdeField("GLCRRM", "GLCRRM", JdeDataType.String, 2),
        new JdeField("GLPRGF", "GLPRGF", JdeDataType.String, 2),
        new JdeField("GLTXA1", "GLTXA1", JdeDataType.String, 20),
        new JdeField("GLEXR1", "GLEXR1", JdeDataType.String, 4),
        new JdeField("GLTXITM", "GLTXITM", JdeDataType.Numeric),
        new JdeField("GLACTB", "GLACTB", JdeDataType.String, 20),
        new JdeField("GLGPF1", "GLGPF1", JdeDataType.String, 2),
        new JdeField("GLACR", "GLACR", JdeDataType.Numeric),
        new JdeField("GLDLNID", "GLDLNID", JdeDataType.Numeric),
        new JdeField("GLCKNU", "GLCKNU", JdeDataType.String, 50),
        new JdeField("GLBUPC", "GLBUPC", JdeDataType.String, 2),
        new JdeField("GLAHBU", "GLAHBU", JdeDataType.String, 24),
        new JdeField("GLEPGC", "GLEPGC", JdeDataType.String, 6),
        new JdeField("GLJPGC", "GLJPGC", JdeDataType.String, 6),
        new JdeField("GLRC5", "GLRC5", JdeDataType.Numeric),
        new JdeField("GLSFXE", "GLSFXE", JdeDataType.Numeric),
        new JdeField("GLOFM", "GLOFM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0911_0", "Primary Key on GLDCT, GLDOC, GLKCO, GLDGJ, GLJELN, GLLT, GLEXTL", new[] { "GLDCT", "GLDOC", "GLKCO", "GLDGJ", "GLJELN", "GLLT", "GLEXTL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0911_10", "Index on GLPOST, GLAID, GLLT, GLCTRY, GLFY, GLPN, GLSBL, GLSBLT, GLDGJ, GLASID, GLBRE", new[] { "GLPOST", "GLAID", "GLLT", "GLCTRY", "GLFY", "GLPN", "GLSBL", "GLSBLT", "GLDGJ", "GLASID", "GLBRE" }),
        new JdeIndex("F0911_11", "Index on GLPOST, GLAID, GLLT, GLCTRY, GLFY, GLPN, GLCRCD, GLDGJ", new[] { "GLPOST", "GLAID", "GLLT", "GLCTRY", "GLFY", "GLPN", "GLCRCD", "GLDGJ" }),
        new JdeIndex("F0911_12", "Index on GLICUT, GLICU, GLDCT, GLDOC, GLKCO, GLDGJ", new[] { "GLICUT", "GLICU", "GLDCT", "GLDOC", "GLKCO", "GLDGJ" }),
        new JdeIndex("F0911_13", "Index on GLPOST, GLAID, GLLT, GLCTRY, GLFY, GLPN, GLDGJ", new[] { "GLPOST", "GLAID", "GLLT", "GLCTRY", "GLFY", "GLPN", "GLDGJ" }),
        new JdeIndex("F0911_15", "Index on GLDCT, GLDOC, GLKCO, GLDGJ, GLLT, GLEXTL, SYS_NC00145$", new[] { "GLDCT", "GLDOC", "GLKCO", "GLDGJ", "GLLT", "GLEXTL", "SYS_NC00145$" }),
        new JdeIndex("F0911_17", "Index on GLDCT, GLEXA, GLDOC, GLKCO", new[] { "GLDCT", "GLEXA", "GLDOC", "GLKCO" }),
        new JdeIndex("F0911_18", "Index on GLAID, GLLT, SYS_NC00144$, GLCRCD, GLSBL, GLSBLT", new[] { "GLAID", "GLLT", "SYS_NC00144$", "GLCRCD", "GLSBL", "GLSBLT" }),
        new JdeIndex("F0911_19", "Index on GLDCT, GLDOC, GLKCO, GLDGJ, GLLT, GLEXTL, GLJELN", new[] { "GLDCT", "GLDOC", "GLKCO", "GLDGJ", "GLLT", "GLEXTL", "GLJELN" }),
        new JdeIndex("F0911_23", "Index on GLASID, GLAID, GLLT, GLDGJ, GLDCT", new[] { "GLASID", "GLAID", "GLLT", "GLDGJ", "GLDCT" }),
        new JdeIndex("F0911_24", "Index on GLBC, GLLT, GLMCU, GLOBJ, GLSUB, GLSBL, GLSBLT, GLDGJ", new[] { "GLBC", "GLLT", "GLMCU", "GLOBJ", "GLSUB", "GLSBL", "GLSBLT", "GLDGJ" }),
        new JdeIndex("F0911_25", "Index on GLCO, GLMCU, GLSUB, GLOBJ, GLDGJ, GLLT, GLSBL, GLSBLT, GLPOST, GLDCT, GLAN8", new[] { "GLCO", "GLMCU", "GLSUB", "GLOBJ", "GLDGJ", "GLLT", "GLSBL", "GLSBLT", "GLPOST", "GLDCT", "GLAN8" }),
        new JdeIndex("F0911_27", "Index on GLPOST, GLLT, GLAID, SYS_NC00144$", new[] { "GLPOST", "GLLT", "GLAID", "SYS_NC00144$" }),
        new JdeIndex("F0911_28", "Index on GLAID, GLR1", new[] { "GLAID", "GLR1" }),
        new JdeIndex("F0911_29", "Index on GLAID, GLCTRY, GLFY, GLFQ, GLLT, GLSBL, GLSBLT, GLCRCD", new[] { "GLAID", "GLCTRY", "GLFY", "GLFQ", "GLLT", "GLSBL", "GLSBLT", "GLCRCD" }),
        new JdeIndex("F0911_30", "Index on GLPOST, GLICUT, GLICU, GLLT, GLDGJ, GLDOC, SYS_NC00142$, SYS_NC00143$, GLJELN, GLEXTL", new[] { "GLPOST", "GLICUT", "GLICU", "GLLT", "GLDGJ", "GLDOC", "SYS_NC00142$", "SYS_NC00143$", "GLJELN", "GLEXTL" }),
        new JdeIndex("F0911_32", "Index on GLSBL, GLSBLT, GLLT", new[] { "GLSBL", "GLSBLT", "GLLT" }),
        new JdeIndex("F0911_33", "Index on GLAID, GLCTRY, GLFY, GLFQ, GLLT, GLSBLT, GLSBL, GLCRCD", new[] { "GLAID", "GLCTRY", "GLFY", "GLFQ", "GLLT", "GLSBLT", "GLSBL", "GLCRCD" }),
        new JdeIndex("F0911_34", "Index on GLICUT, GLICU, GLEXTL, GLPOST", new[] { "GLICUT", "GLICU", "GLEXTL", "GLPOST" }),
        new JdeIndex("F0911_35", "Index on GLAID, GLLT, GLDGJ, GLDCT, GLDOC, GLKCO, GLSBL, GLSBLT", new[] { "GLAID", "GLLT", "GLDGJ", "GLDCT", "GLDOC", "GLKCO", "GLSBL", "GLSBLT" }),
        new JdeIndex("F0911_36", "Index on GLDCT, GLDOC, GLKCO, SYS_NC00144$, GLLT", new[] { "GLDCT", "GLDOC", "GLKCO", "SYS_NC00144$", "GLLT" }),
        new JdeIndex("F0911_37", "Index on GLR2", new[] { "GLR2" }),
        new JdeIndex("F0911_6", "Index on GLPOST, GLICUT, GLICU, GLLT, GLDGJ, GLDOC, GLKCO, GLDCT, GLJELN, GLEXTL", new[] { "GLPOST", "GLICUT", "GLICU", "GLLT", "GLDGJ", "GLDOC", "GLKCO", "GLDCT", "GLJELN", "GLEXTL" }),
        new JdeIndex("F0911_8", "Index on GLRCND, GLAID, GLLT, GLDCT, GLDGJ", new[] { "GLRCND", "GLAID", "GLLT", "GLDCT", "GLDGJ" }),
        new JdeIndex("F0911_9", "Index on GLPOST, GLAID, GLLT, GLCTRY, GLFY, GLPN, GLSBL, GLSBLT, GLCRCD, GLDGJ", new[] { "GLPOST", "GLAID", "GLLT", "GLCTRY", "GLFY", "GLPN", "GLSBL", "GLSBLT", "GLCRCD", "GLDGJ" })
    };
}
