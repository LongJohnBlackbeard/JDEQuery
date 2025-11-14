using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I804 - .
/// </summary>
public class F75I804 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLI75GSTU.
        /// </summary>
        public const string GLI75GSTU = "GLI75GSTU";

        /// <summary>
        /// GLPN.
        /// </summary>
        public const string GLPN = "GLPN";

        /// <summary>
        /// GLYRM.
        /// </summary>
        public const string GLYRM = "GLYRM";

        /// <summary>
        /// GLI75GSTLT.
        /// </summary>
        public const string GLI75GSTLT = "GLI75GSTLT";

        /// <summary>
        /// GLI75CGOPB.
        /// </summary>
        public const string GLI75CGOPB = "GLI75CGOPB";

        /// <summary>
        /// GLI75CGCLB.
        /// </summary>
        public const string GLI75CGCLB = "GLI75CGCLB";

        /// <summary>
        /// GLI75SGOPB.
        /// </summary>
        public const string GLI75SGOPB = "GLI75SGOPB";

        /// <summary>
        /// GLI75SGCLB.
        /// </summary>
        public const string GLI75SGCLB = "GLI75SGCLB";

        /// <summary>
        /// GLI75IGOPB.
        /// </summary>
        public const string GLI75IGOPB = "GLI75IGOPB";

        /// <summary>
        /// GLI75IGCLB.
        /// </summary>
        public const string GLI75IGCLB = "GLI75IGCLB";

        /// <summary>
        /// GLI75CGDEB.
        /// </summary>
        public const string GLI75CGDEB = "GLI75CGDEB";

        /// <summary>
        /// GLI75CGCRD.
        /// </summary>
        public const string GLI75CGCRD = "GLI75CGCRD";

        /// <summary>
        /// GLI75SGDEB.
        /// </summary>
        public const string GLI75SGDEB = "GLI75SGDEB";

        /// <summary>
        /// GLI75SGCRD.
        /// </summary>
        public const string GLI75SGCRD = "GLI75SGCRD";

        /// <summary>
        /// GLI75IGDEB.
        /// </summary>
        public const string GLI75IGDEB = "GLI75IGDEB";

        /// <summary>
        /// GLI75IGCRD.
        /// </summary>
        public const string GLI75IGCRD = "GLI75IGCRD";

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
        /// GLI75AT1OP.
        /// </summary>
        public const string GLI75AT1OP = "GLI75AT1OP";

        /// <summary>
        /// GLI75AT1CL.
        /// </summary>
        public const string GLI75AT1CL = "GLI75AT1CL";

        /// <summary>
        /// GLI75AT1DB.
        /// </summary>
        public const string GLI75AT1DB = "GLI75AT1DB";

        /// <summary>
        /// GLI75AT1CD.
        /// </summary>
        public const string GLI75AT1CD = "GLI75AT1CD";

        /// <summary>
        /// GLI75AT2OP.
        /// </summary>
        public const string GLI75AT2OP = "GLI75AT2OP";

        /// <summary>
        /// GLI75AT2CL.
        /// </summary>
        public const string GLI75AT2CL = "GLI75AT2CL";

        /// <summary>
        /// GLI75AT2DB.
        /// </summary>
        public const string GLI75AT2DB = "GLI75AT2DB";

        /// <summary>
        /// GLI75AT2CD.
        /// </summary>
        public const string GLI75AT2CD = "GLI75AT2CD";

        /// <summary>
        /// GLI75AT3OP.
        /// </summary>
        public const string GLI75AT3OP = "GLI75AT3OP";

        /// <summary>
        /// GLI75AT3CL.
        /// </summary>
        public const string GLI75AT3CL = "GLI75AT3CL";

        /// <summary>
        /// GLI75AT3DB.
        /// </summary>
        public const string GLI75AT3DB = "GLI75AT3DB";

        /// <summary>
        /// GLI75AT3CD.
        /// </summary>
        public const string GLI75AT3CD = "GLI75AT3CD";

        /// <summary>
        /// GLDATF01.
        /// </summary>
        public const string GLDATF01 = "GLDATF01";

        /// <summary>
        /// GLDEPFUT2.
        /// </summary>
        public const string GLDEPFUT2 = "GLDEPFUT2";

        /// <summary>
        /// GLACTFU1.
        /// </summary>
        public const string GLACTFU1 = "GLACTFU1";

        /// <summary>
        /// GLFLAG.
        /// </summary>
        public const string GLFLAG = "GLFLAG";

        /// <summary>
        /// GLI75CSOPB.
        /// </summary>
        public const string GLI75CSOPB = "GLI75CSOPB";

        /// <summary>
        /// GLI75CSCLB.
        /// </summary>
        public const string GLI75CSCLB = "GLI75CSCLB";

        /// <summary>
        /// GLI75CSDEB.
        /// </summary>
        public const string GLI75CSDEB = "GLI75CSDEB";

        /// <summary>
        /// GLI75CSCRD.
        /// </summary>
        public const string GLI75CSCRD = "GLI75CSCRD";

        /// <summary>
        /// GLI75AT4OP.
        /// </summary>
        public const string GLI75AT4OP = "GLI75AT4OP";

        /// <summary>
        /// GLI75AT4CL.
        /// </summary>
        public const string GLI75AT4CL = "GLI75AT4CL";

        /// <summary>
        /// GLI75AT4DB.
        /// </summary>
        public const string GLI75AT4DB = "GLI75AT4DB";

        /// <summary>
        /// GLI75AT4CD.
        /// </summary>
        public const string GLI75AT4CD = "GLI75AT4CD";
    }

    /// <inheritdoc />
    public override string TableName => "F75I804";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLI75GSTU", "GLI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric, null, true, true),
        new JdeField("GLYRM", "GLYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("GLI75GSTLT", "GLI75GSTLT", JdeDataType.String, 12, true, true),
        new JdeField("GLI75CGOPB", "GLI75CGOPB", JdeDataType.Numeric),
        new JdeField("GLI75CGCLB", "GLI75CGCLB", JdeDataType.Numeric),
        new JdeField("GLI75SGOPB", "GLI75SGOPB", JdeDataType.Numeric),
        new JdeField("GLI75SGCLB", "GLI75SGCLB", JdeDataType.Numeric),
        new JdeField("GLI75IGOPB", "GLI75IGOPB", JdeDataType.Numeric),
        new JdeField("GLI75IGCLB", "GLI75IGCLB", JdeDataType.Numeric),
        new JdeField("GLI75CGDEB", "GLI75CGDEB", JdeDataType.Numeric),
        new JdeField("GLI75CGCRD", "GLI75CGCRD", JdeDataType.Numeric),
        new JdeField("GLI75SGDEB", "GLI75SGDEB", JdeDataType.Numeric),
        new JdeField("GLI75SGCRD", "GLI75SGCRD", JdeDataType.Numeric),
        new JdeField("GLI75IGDEB", "GLI75IGDEB", JdeDataType.Numeric),
        new JdeField("GLI75IGCRD", "GLI75IGCRD", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLI75AT1OP", "GLI75AT1OP", JdeDataType.Numeric),
        new JdeField("GLI75AT1CL", "GLI75AT1CL", JdeDataType.Numeric),
        new JdeField("GLI75AT1DB", "GLI75AT1DB", JdeDataType.Numeric),
        new JdeField("GLI75AT1CD", "GLI75AT1CD", JdeDataType.Numeric),
        new JdeField("GLI75AT2OP", "GLI75AT2OP", JdeDataType.Numeric),
        new JdeField("GLI75AT2CL", "GLI75AT2CL", JdeDataType.Numeric),
        new JdeField("GLI75AT2DB", "GLI75AT2DB", JdeDataType.Numeric),
        new JdeField("GLI75AT2CD", "GLI75AT2CD", JdeDataType.Numeric),
        new JdeField("GLI75AT3OP", "GLI75AT3OP", JdeDataType.Numeric),
        new JdeField("GLI75AT3CL", "GLI75AT3CL", JdeDataType.Numeric),
        new JdeField("GLI75AT3DB", "GLI75AT3DB", JdeDataType.Numeric),
        new JdeField("GLI75AT3CD", "GLI75AT3CD", JdeDataType.Numeric),
        new JdeField("GLDATF01", "GLDATF01", JdeDataType.Numeric),
        new JdeField("GLDEPFUT2", "GLDEPFUT2", JdeDataType.String, 60),
        new JdeField("GLACTFU1", "GLACTFU1", JdeDataType.String, 2),
        new JdeField("GLFLAG", "GLFLAG", JdeDataType.String, 2),
        new JdeField("GLI75CSOPB", "GLI75CSOPB", JdeDataType.Numeric),
        new JdeField("GLI75CSCLB", "GLI75CSCLB", JdeDataType.Numeric),
        new JdeField("GLI75CSDEB", "GLI75CSDEB", JdeDataType.Numeric),
        new JdeField("GLI75CSCRD", "GLI75CSCRD", JdeDataType.Numeric),
        new JdeField("GLI75AT4OP", "GLI75AT4OP", JdeDataType.Numeric),
        new JdeField("GLI75AT4CL", "GLI75AT4CL", JdeDataType.Numeric),
        new JdeField("GLI75AT4DB", "GLI75AT4DB", JdeDataType.Numeric),
        new JdeField("GLI75AT4CD", "GLI75AT4CD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I804_0", "Primary Key on GLI75GSTU, GLYRM, GLPN, GLI75GSTLT", new[] { "GLI75GSTU", "GLYRM", "GLPN", "GLI75GSTLT" }, isUnique: true, isPrimaryKey: true)
    };
}
