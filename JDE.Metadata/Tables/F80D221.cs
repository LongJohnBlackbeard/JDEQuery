using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D221 - .
/// </summary>
public class F80D221 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLPRDJ.
        /// </summary>
        public const string GLPRDJ = "GLPRDJ";

        /// <summary>
        /// GLMCU.
        /// </summary>
        public const string GLMCU = "GLMCU";

        /// <summary>
        /// GLITM.
        /// </summary>
        public const string GLITM = "GLITM";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";

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
        /// GLUTIME.
        /// </summary>
        public const string GLUTIME = "GLUTIME";

        /// <summary>
        /// GLURCD.
        /// </summary>
        public const string GLURCD = "GLURCD";

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
    }

    /// <inheritdoc />
    public override string TableName => "F80D221";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLPRDJ", "GLPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24, true, true),
        new JdeField("GLITM", "GLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLMKEY", "GLMKEY", JdeDataType.String, 30),
        new JdeField("GLUTIME", "GLUTIME", JdeDataType.Date),
        new JdeField("GLURCD", "GLURCD", JdeDataType.String, 4),
        new JdeField("GLURDT", "GLURDT", JdeDataType.Numeric),
        new JdeField("GLURAT", "GLURAT", JdeDataType.Numeric),
        new JdeField("GLURAB", "GLURAB", JdeDataType.Numeric),
        new JdeField("GLURRF", "GLURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D221_0", "Primary Key on GLPRDJ, GLMCU, GLITM", new[] { "GLPRDJ", "GLMCU", "GLITM" }, isUnique: true, isPrimaryKey: true)
    };
}
