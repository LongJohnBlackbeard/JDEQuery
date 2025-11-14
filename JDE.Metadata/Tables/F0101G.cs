using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101G - .
/// </summary>
public class F0101G : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";

        /// <summary>
        /// GLKCO.
        /// </summary>
        public const string GLKCO = "GLKCO";

        /// <summary>
        /// GLGAN8.
        /// </summary>
        public const string GLGAN8 = "GLGAN8";

        /// <summary>
        /// GLGLNGN.
        /// </summary>
        public const string GLGLNGN = "GLGLNGN";

        /// <summary>
        /// GLFUAN1.
        /// </summary>
        public const string GLFUAN1 = "GLFUAN1";

        /// <summary>
        /// GLDATF01.
        /// </summary>
        public const string GLDATF01 = "GLDATF01";

        /// <summary>
        /// GLFUTSTR1.
        /// </summary>
        public const string GLFUTSTR1 = "GLFUTSTR1";

        /// <summary>
        /// GLUKFN1.
        /// </summary>
        public const string GLUKFN1 = "GLUKFN1";

        /// <summary>
        /// GLFUTCHAR1.
        /// </summary>
        public const string GLFUTCHAR1 = "GLFUTCHAR1";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLMKEY.
        /// </summary>
        public const string GLMKEY = "GLMKEY";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLTDAY.
        /// </summary>
        public const string GLTDAY = "GLTDAY";

        /// <summary>
        /// GLURCD.
        /// </summary>
        public const string GLURCD = "GLURCD";

        /// <summary>
        /// GLURDT.
        /// </summary>
        public const string GLURDT = "GLURDT";

        /// <summary>
        /// GLURAB.
        /// </summary>
        public const string GLURAB = "GLURAB";

        /// <summary>
        /// GLURRF.
        /// </summary>
        public const string GLURRF = "GLURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F0101G";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10),
        new JdeField("GLGAN8", "GLGAN8", JdeDataType.Numeric),
        new JdeField("GLGLNGN", "GLGLNGN", JdeDataType.String, 2),
        new JdeField("GLFUAN1", "GLFUAN1", JdeDataType.Numeric),
        new JdeField("GLDATF01", "GLDATF01", JdeDataType.Numeric),
        new JdeField("GLFUTSTR1", "GLFUTSTR1", JdeDataType.String, 100),
        new JdeField("GLUKFN1", "GLUKFN1", JdeDataType.Numeric),
        new JdeField("GLFUTCHAR1", "GLFUTCHAR1", JdeDataType.String, 2),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLMKEY", "GLMKEY", JdeDataType.String, 30),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLTDAY", "GLTDAY", JdeDataType.Numeric),
        new JdeField("GLURCD", "GLURCD", JdeDataType.String, 4),
        new JdeField("GLURDT", "GLURDT", JdeDataType.Numeric),
        new JdeField("GLURAB", "GLURAB", JdeDataType.Numeric),
        new JdeField("GLURRF", "GLURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0101G_0", "Primary Key on GLAN8", new[] { "GLAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0101G_2", "Index on GLGAN8", new[] { "GLGAN8" })
    };
}
