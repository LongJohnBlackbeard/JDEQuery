using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B75C - .
/// </summary>
public class F31B75C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGWCFGID.
        /// </summary>
        public const string CGWCFGID = "CGWCFGID";

        /// <summary>
        /// CGMCU.
        /// </summary>
        public const string CGMCU = "CGMCU";

        /// <summary>
        /// CGWCG.
        /// </summary>
        public const string CGWCG = "CGWCG";

        /// <summary>
        /// CGURCD.
        /// </summary>
        public const string CGURCD = "CGURCD";

        /// <summary>
        /// CGURDT.
        /// </summary>
        public const string CGURDT = "CGURDT";

        /// <summary>
        /// CGURAT.
        /// </summary>
        public const string CGURAT = "CGURAT";

        /// <summary>
        /// CGURAB.
        /// </summary>
        public const string CGURAB = "CGURAB";

        /// <summary>
        /// CGURRF.
        /// </summary>
        public const string CGURRF = "CGURRF";

        /// <summary>
        /// CGUSER.
        /// </summary>
        public const string CGUSER = "CGUSER";

        /// <summary>
        /// CGPID.
        /// </summary>
        public const string CGPID = "CGPID";

        /// <summary>
        /// CGJOBN.
        /// </summary>
        public const string CGJOBN = "CGJOBN";

        /// <summary>
        /// CGUPMJ.
        /// </summary>
        public const string CGUPMJ = "CGUPMJ";

        /// <summary>
        /// CGTDAY.
        /// </summary>
        public const string CGTDAY = "CGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B75C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGWCFGID", "CGWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("CGMCU", "CGMCU", JdeDataType.String, 24, true, true),
        new JdeField("CGWCG", "CGWCG", JdeDataType.String, 24, true, true),
        new JdeField("CGURCD", "CGURCD", JdeDataType.String, 4),
        new JdeField("CGURDT", "CGURDT", JdeDataType.Numeric),
        new JdeField("CGURAT", "CGURAT", JdeDataType.Numeric),
        new JdeField("CGURAB", "CGURAB", JdeDataType.Numeric),
        new JdeField("CGURRF", "CGURRF", JdeDataType.String, 30),
        new JdeField("CGUSER", "CGUSER", JdeDataType.String, 20),
        new JdeField("CGPID", "CGPID", JdeDataType.String, 20),
        new JdeField("CGJOBN", "CGJOBN", JdeDataType.String, 20),
        new JdeField("CGUPMJ", "CGUPMJ", JdeDataType.Numeric),
        new JdeField("CGTDAY", "CGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B75C_0", "Primary Key on CGWCFGID, CGMCU, CGWCG", new[] { "CGWCFGID", "CGMCU", "CGWCG" }, isUnique: true, isPrimaryKey: true)
    };
}
