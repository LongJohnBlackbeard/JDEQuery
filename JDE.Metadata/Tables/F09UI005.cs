using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI005 - .
/// </summary>
public class F09UI005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLAG.
        /// </summary>
        public const string GLAG = "GLAG";

        /// <summary>
        /// GLDSVJ.
        /// </summary>
        public const string GLDSVJ = "GLDSVJ";

        /// <summary>
        /// GLDOC.
        /// </summary>
        public const string GLDOC = "GLDOC";

        /// <summary>
        /// GLICUT.
        /// </summary>
        public const string GLICUT = "GLICUT";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

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
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLMMCO.
        /// </summary>
        public const string GLMMCO = "GLMMCO";

        /// <summary>
        /// GLDGJ.
        /// </summary>
        public const string GLDGJ = "GLDGJ";

        /// <summary>
        /// GLPN.
        /// </summary>
        public const string GLPN = "GLPN";

        /// <summary>
        /// GLFY.
        /// </summary>
        public const string GLFY = "GLFY";

        /// <summary>
        /// GLCTRY.
        /// </summary>
        public const string GLCTRY = "GLCTRY";

        /// <summary>
        /// GLGLC.
        /// </summary>
        public const string GLGLC = "GLGLC";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLCN.
        /// </summary>
        public const string GLCN = "GLCN";

        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";

        /// <summary>
        /// GLKCO.
        /// </summary>
        public const string GLKCO = "GLKCO";

        /// <summary>
        /// GLPYID.
        /// </summary>
        public const string GLPYID = "GLPYID";

        /// <summary>
        /// GLPO.
        /// </summary>
        public const string GLPO = "GLPO";

        /// <summary>
        /// GLDKJ.
        /// </summary>
        public const string GLDKJ = "GLDKJ";

        /// <summary>
        /// GLDICJ.
        /// </summary>
        public const string GLDICJ = "GLDICJ";

        /// <summary>
        /// GLEXA.
        /// </summary>
        public const string GLEXA = "GLEXA";

        /// <summary>
        /// GLDCT.
        /// </summary>
        public const string GLDCT = "GLDCT";

        /// <summary>
        /// GLCRR.
        /// </summary>
        public const string GLCRR = "GLCRR";

        /// <summary>
        /// GLACR.
        /// </summary>
        public const string GLACR = "GLACR";

        /// <summary>
        /// GLMMCU.
        /// </summary>
        public const string GLMMCU = "GLMMCU";

        /// <summary>
        /// GLAM.
        /// </summary>
        public const string GLAM = "GLAM";

        /// <summary>
        /// GLANI.
        /// </summary>
        public const string GLANI = "GLANI";

        /// <summary>
        /// GLRMK.
        /// </summary>
        public const string GLRMK = "GLRMK";

        /// <summary>
        /// GLHCRR.
        /// </summary>
        public const string GLHCRR = "GLHCRR";

        /// <summary>
        /// GLSBL.
        /// </summary>
        public const string GLSBL = "GLSBL";

        /// <summary>
        /// GLSBLT.
        /// </summary>
        public const string GLSBLT = "GLSBLT";

        /// <summary>
        /// GLVINV.
        /// </summary>
        public const string GLVINV = "GLVINV";

        /// <summary>
        /// GLHDGJ.
        /// </summary>
        public const string GLHDGJ = "GLHDGJ";

        /// <summary>
        /// GLAAP.
        /// </summary>
        public const string GLAAP = "GLAAP";

        /// <summary>
        /// GLFAP.
        /// </summary>
        public const string GLFAP = "GLFAP";

        /// <summary>
        /// GLEXR.
        /// </summary>
        public const string GLEXR = "GLEXR";

        /// <summary>
        /// GLITEM.
        /// </summary>
        public const string GLITEM = "GLITEM";

        /// <summary>
        /// GLBCRC.
        /// </summary>
        public const string GLBCRC = "GLBCRC";

        /// <summary>
        /// GLCRRM.
        /// </summary>
        public const string GLCRRM = "GLCRRM";

        /// <summary>
        /// GLRCND.
        /// </summary>
        public const string GLRCND = "GLRCND";

        /// <summary>
        /// GLR3.
        /// </summary>
        public const string GLR3 = "GLR3";

        /// <summary>
        /// GLSFX.
        /// </summary>
        public const string GLSFX = "GLSFX";

        /// <summary>
        /// GLSFXE.
        /// </summary>
        public const string GLSFXE = "GLSFXE";

        /// <summary>
        /// GLDKC.
        /// </summary>
        public const string GLDKC = "GLDKC";

        /// <summary>
        /// GLRC5.
        /// </summary>
        public const string GLRC5 = "GLRC5";

        /// <summary>
        /// GLOFM.
        /// </summary>
        public const string GLOFM = "GLOFM";

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
        /// GLOKCO.
        /// </summary>
        public const string GLOKCO = "GLOKCO";

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
    }

    /// <inheritdoc />
    public override string TableName => "F09UI005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLAG", "GLAG", JdeDataType.Numeric),
        new JdeField("GLDSVJ", "GLDSVJ", JdeDataType.Numeric),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric),
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4, true, true),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16, true, true),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24),
        new JdeField("GLOBJ", "GLOBJ", JdeDataType.String, 12),
        new JdeField("GLSUB", "GLSUB", JdeDataType.String, 16),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10, true, true),
        new JdeField("GLMMCO", "GLMMCO", JdeDataType.String, 10),
        new JdeField("GLDGJ", "GLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric),
        new JdeField("GLFY", "GLFY", JdeDataType.Numeric),
        new JdeField("GLCTRY", "GLCTRY", JdeDataType.Numeric),
        new JdeField("GLGLC", "GLGLC", JdeDataType.String, 8, true, true),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GLCN", "GLCN", JdeDataType.String, 16),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10),
        new JdeField("GLPYID", "GLPYID", JdeDataType.Numeric),
        new JdeField("GLPO", "GLPO", JdeDataType.String, 16),
        new JdeField("GLDKJ", "GLDKJ", JdeDataType.Numeric),
        new JdeField("GLDICJ", "GLDICJ", JdeDataType.Numeric),
        new JdeField("GLEXA", "GLEXA", JdeDataType.String, 60),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4, true, true),
        new JdeField("GLCRR", "GLCRR", JdeDataType.Numeric, null, true, true),
        new JdeField("GLACR", "GLACR", JdeDataType.Numeric),
        new JdeField("GLMMCU", "GLMMCU", JdeDataType.String, 24),
        new JdeField("GLAM", "GLAM", JdeDataType.String, 2),
        new JdeField("GLANI", "GLANI", JdeDataType.String, 58),
        new JdeField("GLRMK", "GLRMK", JdeDataType.String, 60),
        new JdeField("GLHCRR", "GLHCRR", JdeDataType.Numeric),
        new JdeField("GLSBL", "GLSBL", JdeDataType.String, 16),
        new JdeField("GLSBLT", "GLSBLT", JdeDataType.String, 2),
        new JdeField("GLVINV", "GLVINV", JdeDataType.String, 50),
        new JdeField("GLHDGJ", "GLHDGJ", JdeDataType.Numeric),
        new JdeField("GLAAP", "GLAAP", JdeDataType.Numeric),
        new JdeField("GLFAP", "GLFAP", JdeDataType.Numeric),
        new JdeField("GLEXR", "GLEXR", JdeDataType.String, 60),
        new JdeField("GLITEM", "GLITEM", JdeDataType.String, 12),
        new JdeField("GLBCRC", "GLBCRC", JdeDataType.String, 6),
        new JdeField("GLCRRM", "GLCRRM", JdeDataType.String, 2),
        new JdeField("GLRCND", "GLRCND", JdeDataType.String, 2),
        new JdeField("GLR3", "GLR3", JdeDataType.String, 16),
        new JdeField("GLSFX", "GLSFX", JdeDataType.String, 6),
        new JdeField("GLSFXE", "GLSFXE", JdeDataType.Numeric),
        new JdeField("GLDKC", "GLDKC", JdeDataType.Numeric),
        new JdeField("GLRC5", "GLRC5", JdeDataType.Numeric),
        new JdeField("GLOFM", "GLOFM", JdeDataType.String, 2),
        new JdeField("GLODOC", "GLODOC", JdeDataType.Numeric),
        new JdeField("GLODCT", "GLODCT", JdeDataType.String, 4),
        new JdeField("GLOSFX", "GLOSFX", JdeDataType.String, 6),
        new JdeField("GLOKCO", "GLOKCO", JdeDataType.String, 10),
        new JdeField("GLTXA1", "GLTXA1", JdeDataType.String, 20),
        new JdeField("GLEXR1", "GLEXR1", JdeDataType.String, 4),
        new JdeField("GLTXITM", "GLTXITM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI005_0", "Primary Key on GLICU, GLICUT, GLDGJ, GLGLC, GLCRCD, GLCRR, GLCO, GLAID, GLDCT", new[] { "GLICU", "GLICUT", "GLDGJ", "GLGLC", "GLCRCD", "GLCRR", "GLCO", "GLAID", "GLDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
