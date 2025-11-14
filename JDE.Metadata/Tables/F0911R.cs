using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0911R - .
/// </summary>
public class F0911R : JdeTable
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
        /// GLBC.
        /// </summary>
        public const string GLBC = "GLBC";

        /// <summary>
        /// GLPO.
        /// </summary>
        public const string GLPO = "GLPO";

        /// <summary>
        /// GLPSFX.
        /// </summary>
        public const string GLPSFX = "GLPSFX";

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
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLTORG.
        /// </summary>
        public const string GLTORG = "GLTORG";

        /// <summary>
        /// GLRRNO.
        /// </summary>
        public const string GLRRNO = "GLRRNO";

        /// <summary>
        /// GLAA1.
        /// </summary>
        public const string GLAA1 = "GLAA1";

        /// <summary>
        /// GLBCRC.
        /// </summary>
        public const string GLBCRC = "GLBCRC";

        /// <summary>
        /// GLABR1.
        /// </summary>
        public const string GLABR1 = "GLABR1";

        /// <summary>
        /// GLABT1.
        /// </summary>
        public const string GLABT1 = "GLABT1";

        /// <summary>
        /// GLABR2.
        /// </summary>
        public const string GLABR2 = "GLABR2";

        /// <summary>
        /// GLABT2.
        /// </summary>
        public const string GLABT2 = "GLABT2";

        /// <summary>
        /// GLABR3.
        /// </summary>
        public const string GLABR3 = "GLABR3";

        /// <summary>
        /// GLABT3.
        /// </summary>
        public const string GLABT3 = "GLABT3";

        /// <summary>
        /// GLABR4.
        /// </summary>
        public const string GLABR4 = "GLABR4";

        /// <summary>
        /// GLABT4.
        /// </summary>
        public const string GLABT4 = "GLABT4";

        /// <summary>
        /// GLITM.
        /// </summary>
        public const string GLITM = "GLITM";

        /// <summary>
        /// GLCRRM.
        /// </summary>
        public const string GLCRRM = "GLCRRM";

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
        /// GLCKNU.
        /// </summary>
        public const string GLCKNU = "GLCKNU";

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

        /// <summary>
        /// GLDKC.
        /// </summary>
        public const string GLDKC = "GLDKC";

        /// <summary>
        /// GLLNID.
        /// </summary>
        public const string GLLNID = "GLLNID";

        /// <summary>
        /// GLPKCO.
        /// </summary>
        public const string GLPKCO = "GLPKCO";

        /// <summary>
        /// GLPDCT.
        /// </summary>
        public const string GLPDCT = "GLPDCT";

        /// <summary>
        /// GLOSFX.
        /// </summary>
        public const string GLOSFX = "GLOSFX";

        /// <summary>
        /// GLALT5.
        /// </summary>
        public const string GLALT5 = "GLALT5";

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
    }

    /// <inheritdoc />
    public override string TableName => "F0911R";

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
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLCN", "GLCN", JdeDataType.String, 16),
        new JdeField("GLDKJ", "GLDKJ", JdeDataType.Numeric),
        new JdeField("GLASID", "GLASID", JdeDataType.String, 50),
        new JdeField("GLBRE", "GLBRE", JdeDataType.String, 2),
        new JdeField("GLRCND", "GLRCND", JdeDataType.String, 2),
        new JdeField("GLSUMM", "GLSUMM", JdeDataType.String, 2),
        new JdeField("GLPRGE", "GLPRGE", JdeDataType.String, 2),
        new JdeField("GLTNN", "GLTNN", JdeDataType.String, 2),
        new JdeField("GLBC", "GLBC", JdeDataType.String, 2),
        new JdeField("GLPO", "GLPO", JdeDataType.String, 16),
        new JdeField("GLPSFX", "GLPSFX", JdeDataType.String, 6),
        new JdeField("GLDOI", "GLDOI", JdeDataType.Numeric),
        new JdeField("GLALID", "GLALID", JdeDataType.String, 50),
        new JdeField("GLALTY", "GLALTY", JdeDataType.String, 4),
        new JdeField("GLDSVJ", "GLDSVJ", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLTORG", "GLTORG", JdeDataType.String, 20),
        new JdeField("GLRRNO", "GLRRNO", JdeDataType.Numeric),
        new JdeField("GLAA1", "GLAA1", JdeDataType.Numeric),
        new JdeField("GLBCRC", "GLBCRC", JdeDataType.String, 6),
        new JdeField("GLABR1", "GLABR1", JdeDataType.String, 24),
        new JdeField("GLABT1", "GLABT1", JdeDataType.String, 2),
        new JdeField("GLABR2", "GLABR2", JdeDataType.String, 24),
        new JdeField("GLABT2", "GLABT2", JdeDataType.String, 2),
        new JdeField("GLABR3", "GLABR3", JdeDataType.String, 24),
        new JdeField("GLABT3", "GLABT3", JdeDataType.String, 2),
        new JdeField("GLABR4", "GLABR4", JdeDataType.String, 24),
        new JdeField("GLABT4", "GLABT4", JdeDataType.String, 2),
        new JdeField("GLITM", "GLITM", JdeDataType.Numeric),
        new JdeField("GLCRRM", "GLCRRM", JdeDataType.String, 2),
        new JdeField("GLTXA1", "GLTXA1", JdeDataType.String, 20),
        new JdeField("GLEXR1", "GLEXR1", JdeDataType.String, 4),
        new JdeField("GLTXITM", "GLTXITM", JdeDataType.Numeric),
        new JdeField("GLACTB", "GLACTB", JdeDataType.String, 20),
        new JdeField("GLGPF1", "GLGPF1", JdeDataType.String, 2),
        new JdeField("GLACR", "GLACR", JdeDataType.Numeric),
        new JdeField("GLCKNU", "GLCKNU", JdeDataType.String, 50),
        new JdeField("GLRC5", "GLRC5", JdeDataType.Numeric),
        new JdeField("GLSFXE", "GLSFXE", JdeDataType.Numeric),
        new JdeField("GLOFM", "GLOFM", JdeDataType.String, 2),
        new JdeField("GLDKC", "GLDKC", JdeDataType.Numeric),
        new JdeField("GLLNID", "GLLNID", JdeDataType.Numeric),
        new JdeField("GLPKCO", "GLPKCO", JdeDataType.String, 10),
        new JdeField("GLPDCT", "GLPDCT", JdeDataType.String, 4),
        new JdeField("GLOSFX", "GLOSFX", JdeDataType.String, 6),
        new JdeField("GLALT5", "GLALT5", JdeDataType.String, 2),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0911R_0", "Primary Key on GLDCT, GLDOC, GLKCO, GLDGJ, GLJELN, GLLT, GLEXTL", new[] { "GLDCT", "GLDOC", "GLKCO", "GLDGJ", "GLJELN", "GLLT", "GLEXTL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0911R_2", "Index on GLAID, GLR1", new[] { "GLAID", "GLR1" }),
        new JdeIndex("F0911R_3", "Index on GLRCND, GLLT, GLAID, GLICUT, GLDCT, GLDOC, GLJELN, GLALT5, GLOFM", new[] { "GLRCND", "GLLT", "GLAID", "GLICUT", "GLDCT", "GLDOC", "GLJELN", "GLALT5", "GLOFM" }),
        new JdeIndex("F0911R_4", "Index on GLRCND, GLLT, GLDCT, GLDOC, GLSFX, GLICUT, GLICU, GLKCO, GLSFXE, GLRC5", new[] { "GLRCND", "GLLT", "GLDCT", "GLDOC", "GLSFX", "GLICUT", "GLICU", "GLKCO", "GLSFXE", "GLRC5" }),
        new JdeIndex("F0911R_5", "Index on GLPID, GLUSER, GLJOBN, GLUPMJ, GLUPMT, GLAID, GLR3, GLDKC, GLDGJ, GLDOC, GLJELN", new[] { "GLPID", "GLUSER", "GLJOBN", "GLUPMJ", "GLUPMT", "GLAID", "GLR3", "GLDKC", "GLDGJ", "GLDOC", "GLJELN" }),
        new JdeIndex("F0911R_6", "Index on GLRCND, GLLT, GLAID, GLDCT, GLDOC, GLKCO, GLALT5", new[] { "GLRCND", "GLLT", "GLAID", "GLDCT", "GLDOC", "GLKCO", "GLALT5" })
    };
}
