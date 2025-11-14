using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T012 - .
/// </summary>
public class F75T012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// GLAID.
        /// </summary>
        public const string GLAID = "GLAID";

        /// <summary>
        /// GLDL01.
        /// </summary>
        public const string GLDL01 = "GLDL01";

        /// <summary>
        /// GL75TDCF.
        /// </summary>
        public const string GL75TDCF = "GL75TDCF";

        /// <summary>
        /// GLURC1.
        /// </summary>
        public const string GLURC1 = "GLURC1";

        /// <summary>
        /// GLURDT.
        /// </summary>
        public const string GLURDT = "GLURDT";

        /// <summary>
        /// GLURAT.
        /// </summary>
        public const string GLURAT = "GLURAT";

        /// <summary>
        /// GLURAB.
        /// </summary>
        public const string GLURAB = "GLURAB";

        /// <summary>
        /// GLURRF.
        /// </summary>
        public const string GLURRF = "GLURRF";

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
        /// GLTDAY.
        /// </summary>
        public const string GLTDAY = "GLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24, true, true),
        new JdeField("GLOBJ", "GLOBJ", JdeDataType.String, 12, true, true),
        new JdeField("GLSUB", "GLSUB", JdeDataType.String, 16, true, true),
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16),
        new JdeField("GLDL01", "GLDL01", JdeDataType.String, 60),
        new JdeField("GL75TDCF", "GL75TDCF", JdeDataType.String, 2),
        new JdeField("GLURC1", "GLURC1", JdeDataType.String, 6),
        new JdeField("GLURDT", "GLURDT", JdeDataType.Numeric),
        new JdeField("GLURAT", "GLURAT", JdeDataType.Numeric),
        new JdeField("GLURAB", "GLURAB", JdeDataType.Numeric),
        new JdeField("GLURRF", "GLURRF", JdeDataType.String, 30),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLTDAY", "GLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T012_0", "Primary Key on GLMCU, GLOBJ, GLSUB", new[] { "GLMCU", "GLOBJ", "GLSUB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T012_2", "Unique Index on GLAID", new[] { "GLAID" }, isUnique: true)
    };
}
