using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B211 - .
/// </summary>
public class F31B211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGWCG.
        /// </summary>
        public const string CGWCG = "CGWCG";

        /// <summary>
        /// CGLNID.
        /// </summary>
        public const string CGLNID = "CGLNID";

        /// <summary>
        /// CGWCOST.
        /// </summary>
        public const string CGWCOST = "CGWCOST";

        /// <summary>
        /// CGUNCS.
        /// </summary>
        public const string CGUNCS = "CGUNCS";

        /// <summary>
        /// CGWVUM.
        /// </summary>
        public const string CGWVUM = "CGWVUM";

        /// <summary>
        /// CGWPCF.
        /// </summary>
        public const string CGWPCF = "CGWPCF";

        /// <summary>
        /// CGWUOMT.
        /// </summary>
        public const string CGWUOMT = "CGWUOMT";

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
    public override string TableName => "F31B211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGWCG", "CGWCG", JdeDataType.String, 24, true, true),
        new JdeField("CGLNID", "CGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CGWCOST", "CGWCOST", JdeDataType.String, 24),
        new JdeField("CGUNCS", "CGUNCS", JdeDataType.Numeric),
        new JdeField("CGWVUM", "CGWVUM", JdeDataType.String, 6),
        new JdeField("CGWPCF", "CGWPCF", JdeDataType.String, 2),
        new JdeField("CGWUOMT", "CGWUOMT", JdeDataType.String, 2),
        new JdeField("CGUSER", "CGUSER", JdeDataType.String, 20),
        new JdeField("CGPID", "CGPID", JdeDataType.String, 20),
        new JdeField("CGJOBN", "CGJOBN", JdeDataType.String, 20),
        new JdeField("CGUPMJ", "CGUPMJ", JdeDataType.Numeric),
        new JdeField("CGTDAY", "CGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B211_0", "Primary Key on CGWCG, CGLNID", new[] { "CGWCG", "CGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
