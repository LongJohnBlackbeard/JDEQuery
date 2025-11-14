using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M990 - .
/// </summary>
public class F76M990 : JdeTable
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
        /// GLJELN.
        /// </summary>
        public const string GLJELN = "GLJELN";

        /// <summary>
        /// GLDGJ.
        /// </summary>
        public const string GLDGJ = "GLDGJ";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLEXTL.
        /// </summary>
        public const string GLEXTL = "GLEXTL";

        /// <summary>
        /// GLM76JEKCO.
        /// </summary>
        public const string GLM76JEKCO = "GLM76JEKCO";

        /// <summary>
        /// GLM76JEDCT.
        /// </summary>
        public const string GLM76JEDCT = "GLM76JEDCT";

        /// <summary>
        /// GLM76JEDOC.
        /// </summary>
        public const string GLM76JEDOC = "GLM76JEDOC";

        /// <summary>
        /// GLM76JELN.
        /// </summary>
        public const string GLM76JELN = "GLM76JELN";

        /// <summary>
        /// GLM76JEDGJ.
        /// </summary>
        public const string GLM76JEDGJ = "GLM76JEDGJ";

        /// <summary>
        /// GLM76JELT.
        /// </summary>
        public const string GLM76JELT = "GLM76JELT";

        /// <summary>
        /// GLM76EXTL.
        /// </summary>
        public const string GLM76EXTL = "GLM76EXTL";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLICUT.
        /// </summary>
        public const string GLICUT = "GLICUT";

        /// <summary>
        /// GLPYID.
        /// </summary>
        public const string GLPYID = "GLPYID";

        /// <summary>
        /// GLRC5.
        /// </summary>
        public const string GLRC5 = "GLRC5";

        /// <summary>
        /// GLDCTM.
        /// </summary>
        public const string GLDCTM = "GLDCTM";

        /// <summary>
        /// GLOKCO.
        /// </summary>
        public const string GLOKCO = "GLOKCO";

        /// <summary>
        /// GLODCT.
        /// </summary>
        public const string GLODCT = "GLODCT";

        /// <summary>
        /// GLODOC.
        /// </summary>
        public const string GLODOC = "GLODOC";

        /// <summary>
        /// GLSFX.
        /// </summary>
        public const string GLSFX = "GLSFX";

        /// <summary>
        /// GLSFXE.
        /// </summary>
        public const string GLSFXE = "GLSFXE";

        /// <summary>
        /// GLM76GLTA.
        /// </summary>
        public const string GLM76GLTA = "GLM76GLTA";

        /// <summary>
        /// GLM76GLVA.
        /// </summary>
        public const string GLM76GLVA = "GLM76GLVA";

        /// <summary>
        /// GLBCRC.
        /// </summary>
        public const string GLBCRC = "GLBCRC";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76M990";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10, true, true),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4, true, true),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GLJELN", "GLJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("GLDGJ", "GLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4, true, true),
        new JdeField("GLEXTL", "GLEXTL", JdeDataType.String, 4, true, true),
        new JdeField("GLM76JEKCO", "GLM76JEKCO", JdeDataType.String, 10),
        new JdeField("GLM76JEDCT", "GLM76JEDCT", JdeDataType.String, 4),
        new JdeField("GLM76JEDOC", "GLM76JEDOC", JdeDataType.Numeric),
        new JdeField("GLM76JELN", "GLM76JELN", JdeDataType.Numeric),
        new JdeField("GLM76JEDGJ", "GLM76JEDGJ", JdeDataType.Numeric),
        new JdeField("GLM76JELT", "GLM76JELT", JdeDataType.String, 4),
        new JdeField("GLM76EXTL", "GLM76EXTL", JdeDataType.String, 4),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric),
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4),
        new JdeField("GLPYID", "GLPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("GLRC5", "GLRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("GLDCTM", "GLDCTM", JdeDataType.String, 4),
        new JdeField("GLOKCO", "GLOKCO", JdeDataType.String, 10),
        new JdeField("GLODCT", "GLODCT", JdeDataType.String, 4),
        new JdeField("GLODOC", "GLODOC", JdeDataType.Numeric),
        new JdeField("GLSFX", "GLSFX", JdeDataType.String, 6),
        new JdeField("GLSFXE", "GLSFXE", JdeDataType.Numeric),
        new JdeField("GLM76GLTA", "GLM76GLTA", JdeDataType.Numeric),
        new JdeField("GLM76GLVA", "GLM76GLVA", JdeDataType.Numeric),
        new JdeField("GLBCRC", "GLBCRC", JdeDataType.String, 6),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M990_0", "Primary Key on GLKCO, GLDCT, GLDOC, GLJELN, GLDGJ, GLLT, GLEXTL, GLPYID, GLRC5", new[] { "GLKCO", "GLDCT", "GLDOC", "GLJELN", "GLDGJ", "GLLT", "GLEXTL", "GLPYID", "GLRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76M990_2", "Index on GLPYID, GLRC5", new[] { "GLPYID", "GLRC5" }),
        new JdeIndex("F76M990_3", "Index on GLOKCO, GLODCT, GLODOC, GLSFX, GLSFXE", new[] { "GLOKCO", "GLODCT", "GLODOC", "GLSFX", "GLSFXE" }),
        new JdeIndex("F76M990_4", "Index on GLM76JEKCO, GLM76JEDCT, GLM76JEDOC, GLM76JELN, GLM76JEDGJ, GLM76JELT, GLM76EXTL", new[] { "GLM76JEKCO", "GLM76JEDCT", "GLM76JEDOC", "GLM76JELN", "GLM76JEDGJ", "GLM76JELT", "GLM76EXTL" })
    };
}
