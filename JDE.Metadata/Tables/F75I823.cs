using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I823 - .
/// </summary>
public class F75I823 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLI75GSTU.
        /// </summary>
        public const string GLI75GSTU = "GLI75GSTU";

        /// <summary>
        /// GLI75LEDAT.
        /// </summary>
        public const string GLI75LEDAT = "GLI75LEDAT";

        /// <summary>
        /// GLI75GSTLT.
        /// </summary>
        public const string GLI75GSTLT = "GLI75GSTLT";

        /// <summary>
        /// GLPN.
        /// </summary>
        public const string GLPN = "GLPN";

        /// <summary>
        /// GLYLYR.
        /// </summary>
        public const string GLYLYR = "GLYLYR";

        /// <summary>
        /// GLI75IGSTA.
        /// </summary>
        public const string GLI75IGSTA = "GLI75IGSTA";

        /// <summary>
        /// GLI75CGSTA.
        /// </summary>
        public const string GLI75CGSTA = "GLI75CGSTA";

        /// <summary>
        /// GLI75SGSTA.
        /// </summary>
        public const string GLI75SGSTA = "GLI75SGSTA";

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
        /// GLYFUTDT1.
        /// </summary>
        public const string GLYFUTDT1 = "GLYFUTDT1";

        /// <summary>
        /// GLFUT6.
        /// </summary>
        public const string GLFUT6 = "GLFUT6";

        /// <summary>
        /// GLYT04.
        /// </summary>
        public const string GLYT04 = "GLYT04";

        /// <summary>
        /// GLYFLAG.
        /// </summary>
        public const string GLYFLAG = "GLYFLAG";

        /// <summary>
        /// GLYNUM1.
        /// </summary>
        public const string GLYNUM1 = "GLYNUM1";

        /// <summary>
        /// GLICUT.
        /// </summary>
        public const string GLICUT = "GLICUT";

        /// <summary>
        /// GLI75CESSA.
        /// </summary>
        public const string GLI75CESSA = "GLI75CESSA";

        /// <summary>
        /// GLI75ATX1A.
        /// </summary>
        public const string GLI75ATX1A = "GLI75ATX1A";

        /// <summary>
        /// GLI75ATX2A.
        /// </summary>
        public const string GLI75ATX2A = "GLI75ATX2A";

        /// <summary>
        /// GLI75ATX3A.
        /// </summary>
        public const string GLI75ATX3A = "GLI75ATX3A";

        /// <summary>
        /// GLI75AT4A.
        /// </summary>
        public const string GLI75AT4A = "GLI75AT4A";
    }

    /// <inheritdoc />
    public override string TableName => "F75I823";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLI75GSTU", "GLI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLI75LEDAT", "GLI75LEDAT", JdeDataType.Numeric, null, true, true),
        new JdeField("GLI75GSTLT", "GLI75GSTLT", JdeDataType.String, 12, true, true),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric),
        new JdeField("GLYLYR", "GLYLYR", JdeDataType.Numeric),
        new JdeField("GLI75IGSTA", "GLI75IGSTA", JdeDataType.Numeric),
        new JdeField("GLI75CGSTA", "GLI75CGSTA", JdeDataType.Numeric),
        new JdeField("GLI75SGSTA", "GLI75SGSTA", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLYFUTDT1", "GLYFUTDT1", JdeDataType.Numeric),
        new JdeField("GLFUT6", "GLFUT6", JdeDataType.String, 60),
        new JdeField("GLYT04", "GLYT04", JdeDataType.String, 2),
        new JdeField("GLYFLAG", "GLYFLAG", JdeDataType.String, 2),
        new JdeField("GLYNUM1", "GLYNUM1", JdeDataType.Numeric),
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4, true, true),
        new JdeField("GLI75CESSA", "GLI75CESSA", JdeDataType.Numeric),
        new JdeField("GLI75ATX1A", "GLI75ATX1A", JdeDataType.Numeric),
        new JdeField("GLI75ATX2A", "GLI75ATX2A", JdeDataType.Numeric),
        new JdeField("GLI75ATX3A", "GLI75ATX3A", JdeDataType.Numeric),
        new JdeField("GLI75AT4A", "GLI75AT4A", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I823_0", "Primary Key on GLICU, GLI75GSTU, GLI75LEDAT, GLI75GSTLT, GLICUT", new[] { "GLICU", "GLI75GSTU", "GLI75LEDAT", "GLI75GSTLT", "GLICUT" }, isUnique: true, isPrimaryKey: true)
    };
}
