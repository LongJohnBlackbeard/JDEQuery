using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H309 - .
/// </summary>
public class F74H309 : JdeTable
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
        /// GLH74RDT.
        /// </summary>
        public const string GLH74RDT = "GLH74RDT";

        /// <summary>
        /// GLFAP.
        /// </summary>
        public const string GLFAP = "GLFAP";

        /// <summary>
        /// GLH74RDA.
        /// </summary>
        public const string GLH74RDA = "GLH74RDA";

        /// <summary>
        /// GLCRR.
        /// </summary>
        public const string GLCRR = "GLCRR";

        /// <summary>
        /// GLVOID.
        /// </summary>
        public const string GLVOID = "GLVOID";

        /// <summary>
        /// GLVDGJ.
        /// </summary>
        public const string GLVDGJ = "GLVDGJ";

        /// <summary>
        /// GLICUT.
        /// </summary>
        public const string GLICUT = "GLICUT";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLCRR1.
        /// </summary>
        public const string GLCRR1 = "GLCRR1";

        /// <summary>
        /// GLCRR2.
        /// </summary>
        public const string GLCRR2 = "GLCRR2";

        /// <summary>
        /// GLCRCM.
        /// </summary>
        public const string GLCRCM = "GLCRCM";

        /// <summary>
        /// GLCTRY.
        /// </summary>
        public const string GLCTRY = "GLCTRY";

        /// <summary>
        /// GLFY.
        /// </summary>
        public const string GLFY = "GLFY";

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
    public override string TableName => "F74H309";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10, true, true),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4, true, true),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GLOKCO", "GLOKCO", JdeDataType.String, 10),
        new JdeField("GLODCT", "GLODCT", JdeDataType.String, 4),
        new JdeField("GLODOC", "GLODOC", JdeDataType.Numeric),
        new JdeField("GLH74RDT", "GLH74RDT", JdeDataType.Numeric),
        new JdeField("GLFAP", "GLFAP", JdeDataType.Numeric),
        new JdeField("GLH74RDA", "GLH74RDA", JdeDataType.Numeric),
        new JdeField("GLCRR", "GLCRR", JdeDataType.Numeric),
        new JdeField("GLVOID", "GLVOID", JdeDataType.String, 2),
        new JdeField("GLVDGJ", "GLVDGJ", JdeDataType.Numeric),
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6),
        new JdeField("GLCRR1", "GLCRR1", JdeDataType.Numeric),
        new JdeField("GLCRR2", "GLCRR2", JdeDataType.Numeric),
        new JdeField("GLCRCM", "GLCRCM", JdeDataType.String, 2),
        new JdeField("GLCTRY", "GLCTRY", JdeDataType.Numeric),
        new JdeField("GLFY", "GLFY", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H309_0", "Primary Key on GLKCO, GLDCT, GLDOC", new[] { "GLKCO", "GLDCT", "GLDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74H309_2", "Index on GLOKCO, GLODCT, GLODOC, GLVOID", new[] { "GLOKCO", "GLODCT", "GLODOC", "GLVOID" })
    };
}
