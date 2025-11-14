using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI011 - .
/// </summary>
public class F09UI011 : JdeTable
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
        /// GLPAAP.
        /// </summary>
        public const string GLPAAP = "GLPAAP";

        /// <summary>
        /// GLPFAP.
        /// </summary>
        public const string GLPFAP = "GLPFAP";

        /// <summary>
        /// GLGLC.
        /// </summary>
        public const string GLGLC = "GLGLC";

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
        /// GLVINV.
        /// </summary>
        public const string GLVINV = "GLVINV";

        /// <summary>
        /// GLPO.
        /// </summary>
        public const string GLPO = "GLPO";

        /// <summary>
        /// GLDSVJ.
        /// </summary>
        public const string GLDSVJ = "GLDSVJ";

        /// <summary>
        /// GLPYID.
        /// </summary>
        public const string GLPYID = "GLPYID";

        /// <summary>
        /// GLITEM.
        /// </summary>
        public const string GLITEM = "GLITEM";

        /// <summary>
        /// GLALT6.
        /// </summary>
        public const string GLALT6 = "GLALT6";

        /// <summary>
        /// GLRCND.
        /// </summary>
        public const string GLRCND = "GLRCND";

        /// <summary>
        /// GLR3.
        /// </summary>
        public const string GLR3 = "GLR3";

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
    public override string TableName => "F09UI011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4, true, true),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GLDGJ", "GLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4, true, true),
        new JdeField("GLDICJ", "GLDICJ", JdeDataType.Numeric),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10, true, true),
        new JdeField("GLANI", "GLANI", JdeDataType.String, 58),
        new JdeField("GLAM", "GLAM", JdeDataType.String, 2),
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16, true, true),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24),
        new JdeField("GLOBJ", "GLOBJ", JdeDataType.String, 12),
        new JdeField("GLSUB", "GLSUB", JdeDataType.String, 16),
        new JdeField("GLSBL", "GLSBL", JdeDataType.String, 16),
        new JdeField("GLSBLT", "GLSBLT", JdeDataType.String, 2),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric),
        new JdeField("GLCTRY", "GLCTRY", JdeDataType.Numeric),
        new JdeField("GLFY", "GLFY", JdeDataType.Numeric),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GLCRR", "GLCRR", JdeDataType.Numeric, null, true, true),
        new JdeField("GLHCRR", "GLHCRR", JdeDataType.Numeric),
        new JdeField("GLHDGJ", "GLHDGJ", JdeDataType.Numeric),
        new JdeField("GLPAAP", "GLPAAP", JdeDataType.Numeric),
        new JdeField("GLPFAP", "GLPFAP", JdeDataType.Numeric),
        new JdeField("GLGLC", "GLGLC", JdeDataType.String, 8, true, true),
        new JdeField("GLEXA", "GLEXA", JdeDataType.String, 60),
        new JdeField("GLEXR", "GLEXR", JdeDataType.String, 60),
        new JdeField("GLR1", "GLR1", JdeDataType.String, 16),
        new JdeField("GLR2", "GLR2", JdeDataType.String, 16),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLCN", "GLCN", JdeDataType.String, 16),
        new JdeField("GLDKJ", "GLDKJ", JdeDataType.Numeric),
        new JdeField("GLVINV", "GLVINV", JdeDataType.String, 50),
        new JdeField("GLPO", "GLPO", JdeDataType.String, 16),
        new JdeField("GLDSVJ", "GLDSVJ", JdeDataType.Numeric),
        new JdeField("GLPYID", "GLPYID", JdeDataType.Numeric),
        new JdeField("GLITEM", "GLITEM", JdeDataType.String, 12),
        new JdeField("GLALT6", "GLALT6", JdeDataType.String, 2),
        new JdeField("GLRCND", "GLRCND", JdeDataType.String, 2),
        new JdeField("GLR3", "GLR3", JdeDataType.String, 16),
        new JdeField("GLDKC", "GLDKC", JdeDataType.Numeric),
        new JdeField("GLRC5", "GLRC5", JdeDataType.Numeric),
        new JdeField("GLOFM", "GLOFM", JdeDataType.String, 2),
        new JdeField("GLSFX", "GLSFX", JdeDataType.String, 6),
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
        new JdeIndex("F09UI011_0", "Primary Key on GLICU, GLICUT, GLDCT, GLDOC, GLDGJ, GLGLC, GLCRCD, GLCRR, GLCO, GLAID", new[] { "GLICU", "GLICUT", "GLDCT", "GLDOC", "GLDGJ", "GLGLC", "GLCRCD", "GLCRR", "GLCO", "GLAID" }, isUnique: true, isPrimaryKey: true)
    };
}
