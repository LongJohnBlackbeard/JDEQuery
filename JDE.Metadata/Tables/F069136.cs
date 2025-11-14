using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069136 - .
/// </summary>
public class F069136 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEAN8.
        /// </summary>
        public const string JEAN8 = "JEAN8";

        /// <summary>
        /// JELSTA.
        /// </summary>
        public const string JELSTA = "JELSTA";

        /// <summary>
        /// JEDGL.
        /// </summary>
        public const string JEDGL = "JEDGL";

        /// <summary>
        /// JEALPH.
        /// </summary>
        public const string JEALPH = "JEALPH";

        /// <summary>
        /// JEDPCT.
        /// </summary>
        public const string JEDPCT = "JEDPCT";

        /// <summary>
        /// JEJBCD.
        /// </summary>
        public const string JEJBCD = "JEJBCD";

        /// <summary>
        /// JESHFT.
        /// </summary>
        public const string JESHFT = "JESHFT";

        /// <summary>
        /// JEPDBA.
        /// </summary>
        public const string JEPDBA = "JEPDBA";

        /// <summary>
        /// JEEXR.
        /// </summary>
        public const string JEEXR = "JEEXR";

        /// <summary>
        /// JEMCU.
        /// </summary>
        public const string JEMCU = "JEMCU";

        /// <summary>
        /// JEOBJ.
        /// </summary>
        public const string JEOBJ = "JEOBJ";

        /// <summary>
        /// JESUB.
        /// </summary>
        public const string JESUB = "JESUB";

        /// <summary>
        /// JEAID.
        /// </summary>
        public const string JEAID = "JEAID";

        /// <summary>
        /// JEANI.
        /// </summary>
        public const string JEANI = "JEANI";

        /// <summary>
        /// JEAM.
        /// </summary>
        public const string JEAM = "JEAM";

        /// <summary>
        /// JEUN.
        /// </summary>
        public const string JEUN = "JEUN";

        /// <summary>
        /// JEJBST.
        /// </summary>
        public const string JEJBST = "JEJBST";

        /// <summary>
        /// JEWCMP.
        /// </summary>
        public const string JEWCMP = "JEWCMP";

        /// <summary>
        /// JEWET.
        /// </summary>
        public const string JEWET = "JEWET";

        /// <summary>
        /// JETARA.
        /// </summary>
        public const string JETARA = "JETARA";

        /// <summary>
        /// JEDPA.
        /// </summary>
        public const string JEDPA = "JEDPA";

        /// <summary>
        /// JEICU.
        /// </summary>
        public const string JEICU = "JEICU";

        /// <summary>
        /// JEDICJ.
        /// </summary>
        public const string JEDICJ = "JEDICJ";

        /// <summary>
        /// JEYST.
        /// </summary>
        public const string JEYST = "JEYST";

        /// <summary>
        /// JEUSER.
        /// </summary>
        public const string JEUSER = "JEUSER";

        /// <summary>
        /// JEPID.
        /// </summary>
        public const string JEPID = "JEPID";

        /// <summary>
        /// JEUPMJ.
        /// </summary>
        public const string JEUPMJ = "JEUPMJ";

        /// <summary>
        /// JEMAIL.
        /// </summary>
        public const string JEMAIL = "JEMAIL";

        /// <summary>
        /// JEPHRW.
        /// </summary>
        public const string JEPHRW = "JEPHRW";
    }

    /// <inheritdoc />
    public override string TableName => "F069136";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEAN8", "JEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JELSTA", "JELSTA", JdeDataType.Numeric, null, true, true),
        new JdeField("JEDGL", "JEDGL", JdeDataType.Numeric, null, true, true),
        new JdeField("JEALPH", "JEALPH", JdeDataType.String, 80),
        new JdeField("JEDPCT", "JEDPCT", JdeDataType.Numeric),
        new JdeField("JEJBCD", "JEJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JESHFT", "JESHFT", JdeDataType.String, 2),
        new JdeField("JEPDBA", "JEPDBA", JdeDataType.Numeric),
        new JdeField("JEEXR", "JEEXR", JdeDataType.String, 60),
        new JdeField("JEMCU", "JEMCU", JdeDataType.String, 24),
        new JdeField("JEOBJ", "JEOBJ", JdeDataType.String, 12),
        new JdeField("JESUB", "JESUB", JdeDataType.String, 16),
        new JdeField("JEAID", "JEAID", JdeDataType.String, 16),
        new JdeField("JEANI", "JEANI", JdeDataType.String, 58),
        new JdeField("JEAM", "JEAM", JdeDataType.String, 2),
        new JdeField("JEUN", "JEUN", JdeDataType.String, 12),
        new JdeField("JEJBST", "JEJBST", JdeDataType.String, 8),
        new JdeField("JEWCMP", "JEWCMP", JdeDataType.String, 8),
        new JdeField("JEWET", "JEWET", JdeDataType.String, 2),
        new JdeField("JETARA", "JETARA", JdeDataType.String, 20),
        new JdeField("JEDPA", "JEDPA", JdeDataType.Numeric),
        new JdeField("JEICU", "JEICU", JdeDataType.Numeric, null, true, true),
        new JdeField("JEDICJ", "JEDICJ", JdeDataType.Numeric),
        new JdeField("JEYST", "JEYST", JdeDataType.String, 2),
        new JdeField("JEUSER", "JEUSER", JdeDataType.String, 20),
        new JdeField("JEPID", "JEPID", JdeDataType.String, 20),
        new JdeField("JEUPMJ", "JEUPMJ", JdeDataType.Numeric),
        new JdeField("JEMAIL", "JEMAIL", JdeDataType.String, 20),
        new JdeField("JEPHRW", "JEPHRW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069136_0", "Primary Key on JEICU, JELSTA, JEDGL, JEAN8, JEJBCD", new[] { "JEICU", "JELSTA", "JEDGL", "JEAN8", "JEJBCD" }, isUnique: true, isPrimaryKey: true)
    };
}
