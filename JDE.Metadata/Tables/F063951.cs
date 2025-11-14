using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F063951 - .
/// </summary>
public class F063951 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLPOST.
        /// </summary>
        public const string GLPOST = "GLPOST";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLANI.
        /// </summary>
        public const string GLANI = "GLANI";

        /// <summary>
        /// GLCTRY.
        /// </summary>
        public const string GLCTRY = "GLCTRY";

        /// <summary>
        /// GLFY.
        /// </summary>
        public const string GLFY = "GLFY";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLSBL.
        /// </summary>
        public const string GLSBL = "GLSBL";

        /// <summary>
        /// GLAM.
        /// </summary>
        public const string GLAM = "GLAM";

        /// <summary>
        /// GLR1.
        /// </summary>
        public const string GLR1 = "GLR1";

        /// <summary>
        /// GLR2.
        /// </summary>
        public const string GLR2 = "GLR2";

        /// <summary>
        /// GLDCT.
        /// </summary>
        public const string GLDCT = "GLDCT";

        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";

        /// <summary>
        /// GLASID.
        /// </summary>
        public const string GLASID = "GLASID";

        /// <summary>
        /// GLDGJ.
        /// </summary>
        public const string GLDGJ = "GLDGJ";

        /// <summary>
        /// GLPN.
        /// </summary>
        public const string GLPN = "GLPN";

        /// <summary>
        /// GLEXA.
        /// </summary>
        public const string GLEXA = "GLEXA";

        /// <summary>
        /// GLEXR.
        /// </summary>
        public const string GLEXR = "GLEXR";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";

        /// <summary>
        /// GLU.
        /// </summary>
        public const string GLU = "GLU";

        /// <summary>
        /// GLJELN.
        /// </summary>
        public const string GLJELN = "GLJELN";

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
        /// GLSBLT.
        /// </summary>
        public const string GLSBLT = "GLSBLT";

        /// <summary>
        /// GLWR01.
        /// </summary>
        public const string GLWR01 = "GLWR01";

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
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLCRR.
        /// </summary>
        public const string GLCRR = "GLCRR";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLKCO.
        /// </summary>
        public const string GLKCO = "GLKCO";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLLNID.
        /// </summary>
        public const string GLLNID = "GLLNID";

        /// <summary>
        /// GLCRDC.
        /// </summary>
        public const string GLCRDC = "GLCRDC";

        /// <summary>
        /// GLACR.
        /// </summary>
        public const string GLACR = "GLACR";

        /// <summary>
        /// GLCRRM.
        /// </summary>
        public const string GLCRRM = "GLCRRM";

        /// <summary>
        /// GLLDED.
        /// </summary>
        public const string GLLDED = "GLLDED";

        /// <summary>
        /// GLEPGC.
        /// </summary>
        public const string GLEPGC = "GLEPGC";

        /// <summary>
        /// GLJPGC.
        /// </summary>
        public const string GLJPGC = "GLJPGC";

        /// <summary>
        /// GLPJRDT01.
        /// </summary>
        public const string GLPJRDT01 = "GLPJRDT01";

        /// <summary>
        /// GLPJRDT02.
        /// </summary>
        public const string GLPJRDT02 = "GLPJRDT02";

        /// <summary>
        /// GLPJRDT03.
        /// </summary>
        public const string GLPJRDT03 = "GLPJRDT03";

        /// <summary>
        /// GLPJRMN01.
        /// </summary>
        public const string GLPJRMN01 = "GLPJRMN01";

        /// <summary>
        /// GLPJRMN02.
        /// </summary>
        public const string GLPJRMN02 = "GLPJRMN02";

        /// <summary>
        /// GLPJRMN03.
        /// </summary>
        public const string GLPJRMN03 = "GLPJRMN03";

        /// <summary>
        /// GLPJRMN04.
        /// </summary>
        public const string GLPJRMN04 = "GLPJRMN04";

        /// <summary>
        /// GLPJRST01.
        /// </summary>
        public const string GLPJRST01 = "GLPJRST01";

        /// <summary>
        /// GLPJRST02.
        /// </summary>
        public const string GLPJRST02 = "GLPJRST02";

        /// <summary>
        /// GLPJRST03.
        /// </summary>
        public const string GLPJRST03 = "GLPJRST03";

        /// <summary>
        /// GLPJRST04.
        /// </summary>
        public const string GLPJRST04 = "GLPJRST04";

        /// <summary>
        /// GLPJRST05.
        /// </summary>
        public const string GLPJRST05 = "GLPJRST05";

        /// <summary>
        /// GLPJRST06.
        /// </summary>
        public const string GLPJRST06 = "GLPJRST06";

        /// <summary>
        /// GLPJRCH01.
        /// </summary>
        public const string GLPJRCH01 = "GLPJRCH01";

        /// <summary>
        /// GLPJRCH02.
        /// </summary>
        public const string GLPJRCH02 = "GLPJRCH02";

        /// <summary>
        /// GLPJRCH03.
        /// </summary>
        public const string GLPJRCH03 = "GLPJRCH03";

        /// <summary>
        /// GLPJRCH04.
        /// </summary>
        public const string GLPJRCH04 = "GLPJRCH04";

        /// <summary>
        /// GLACTB.
        /// </summary>
        public const string GLACTB = "GLACTB";

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
    }

    /// <inheritdoc />
    public override string TableName => "F063951";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLPOST", "GLPOST", JdeDataType.String, 2),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLANI", "GLANI", JdeDataType.String, 58),
        new JdeField("GLCTRY", "GLCTRY", JdeDataType.Numeric),
        new JdeField("GLFY", "GLFY", JdeDataType.Numeric),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4),
        new JdeField("GLSBL", "GLSBL", JdeDataType.String, 16),
        new JdeField("GLAM", "GLAM", JdeDataType.String, 2),
        new JdeField("GLR1", "GLR1", JdeDataType.String, 16),
        new JdeField("GLR2", "GLR2", JdeDataType.String, 16),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLASID", "GLASID", JdeDataType.String, 50),
        new JdeField("GLDGJ", "GLDGJ", JdeDataType.Numeric),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric),
        new JdeField("GLEXA", "GLEXA", JdeDataType.String, 60),
        new JdeField("GLEXR", "GLEXR", JdeDataType.String, 60),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric),
        new JdeField("GLU", "GLU", JdeDataType.Numeric),
        new JdeField("GLJELN", "GLJELN", JdeDataType.Numeric),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24),
        new JdeField("GLOBJ", "GLOBJ", JdeDataType.String, 12),
        new JdeField("GLSUB", "GLSUB", JdeDataType.String, 16),
        new JdeField("GLSBLT", "GLSBLT", JdeDataType.String, 2),
        new JdeField("GLWR01", "GLWR01", JdeDataType.String, 8),
        new JdeField("GLJBCD", "GLJBCD", JdeDataType.String, 12),
        new JdeField("GLJBST", "GLJBST", JdeDataType.String, 8),
        new JdeField("GLHMCU", "GLHMCU", JdeDataType.String, 24),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6),
        new JdeField("GLCRR", "GLCRR", JdeDataType.Numeric),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLLNID", "GLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("GLCRDC", "GLCRDC", JdeDataType.String, 6),
        new JdeField("GLACR", "GLACR", JdeDataType.Numeric),
        new JdeField("GLCRRM", "GLCRRM", JdeDataType.String, 2),
        new JdeField("GLLDED", "GLLDED", JdeDataType.Numeric),
        new JdeField("GLEPGC", "GLEPGC", JdeDataType.String, 6),
        new JdeField("GLJPGC", "GLJPGC", JdeDataType.String, 6),
        new JdeField("GLPJRDT01", "GLPJRDT01", JdeDataType.Numeric),
        new JdeField("GLPJRDT02", "GLPJRDT02", JdeDataType.Numeric),
        new JdeField("GLPJRDT03", "GLPJRDT03", JdeDataType.Numeric),
        new JdeField("GLPJRMN01", "GLPJRMN01", JdeDataType.Numeric),
        new JdeField("GLPJRMN02", "GLPJRMN02", JdeDataType.Numeric),
        new JdeField("GLPJRMN03", "GLPJRMN03", JdeDataType.Numeric),
        new JdeField("GLPJRMN04", "GLPJRMN04", JdeDataType.Numeric),
        new JdeField("GLPJRST01", "GLPJRST01", JdeDataType.String, 20),
        new JdeField("GLPJRST02", "GLPJRST02", JdeDataType.String, 20),
        new JdeField("GLPJRST03", "GLPJRST03", JdeDataType.String, 20),
        new JdeField("GLPJRST04", "GLPJRST04", JdeDataType.String, 20),
        new JdeField("GLPJRST05", "GLPJRST05", JdeDataType.String, 40),
        new JdeField("GLPJRST06", "GLPJRST06", JdeDataType.String, 40),
        new JdeField("GLPJRCH01", "GLPJRCH01", JdeDataType.String, 2),
        new JdeField("GLPJRCH02", "GLPJRCH02", JdeDataType.String, 2),
        new JdeField("GLPJRCH03", "GLPJRCH03", JdeDataType.String, 2),
        new JdeField("GLPJRCH04", "GLPJRCH04", JdeDataType.String, 2),
        new JdeField("GLACTB", "GLACTB", JdeDataType.String, 20),
        new JdeField("GLABR1", "GLABR1", JdeDataType.String, 24),
        new JdeField("GLABR2", "GLABR2", JdeDataType.String, 24),
        new JdeField("GLABR3", "GLABR3", JdeDataType.String, 24),
        new JdeField("GLABR4", "GLABR4", JdeDataType.String, 24),
        new JdeField("GLABT1", "GLABT1", JdeDataType.String, 2),
        new JdeField("GLABT2", "GLABT2", JdeDataType.String, 2),
        new JdeField("GLABT3", "GLABT3", JdeDataType.String, 2),
        new JdeField("GLABT4", "GLABT4", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F063951_0", "Primary Key on GLICU, GLLNID", new[] { "GLICU", "GLLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F063951_2", "Index on GLMCU, GLOBJ, GLSUB, GLSBL, GLWR01, GLSBLT, GLCTRY, GLFY, GLPN, GLDGJ, GLDCT, GLJBCD, GLJBST, GLAN8, GLHMCU, GLLNID", new[] { "GLMCU", "GLOBJ", "GLSUB", "GLSBL", "GLWR01", "GLSBLT", "GLCTRY", "GLFY", "GLPN", "GLDGJ", "GLDCT", "GLJBCD", "GLJBST", "GLAN8", "GLHMCU", "GLLNID" }),
        new JdeIndex("F063951_3", "Index on GLMCU, GLOBJ, GLSUB, GLSBL, GLSBLT, GLWR01, GLCTRY, GLFY, GLPN, GLDGJ, GLDCT, GLR2, GLAN8, GLJBCD, GLJBST, GLHMCU", new[] { "GLMCU", "GLOBJ", "GLSUB", "GLSBL", "GLSBLT", "GLWR01", "GLCTRY", "GLFY", "GLPN", "GLDGJ", "GLDCT", "GLR2", "GLAN8", "GLJBCD", "GLJBST", "GLHMCU" })
    };
}
