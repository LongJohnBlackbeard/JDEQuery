using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08362 - .
/// </summary>
public class F08362 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBPLAN.
        /// </summary>
        public const string NBPLAN = "NBPLAN";

        /// <summary>
        /// NBTSTN.
        /// </summary>
        public const string NBTSTN = "NBTSTN";

        /// <summary>
        /// NBTSTY.
        /// </summary>
        public const string NBTSTY = "NBTSTY";

        /// <summary>
        /// NBSEQ5.
        /// </summary>
        public const string NBSEQ5 = "NBSEQ5";

        /// <summary>
        /// NBVERS.
        /// </summary>
        public const string NBVERS = "NBVERS";

        /// <summary>
        /// NBUSER.
        /// </summary>
        public const string NBUSER = "NBUSER";

        /// <summary>
        /// NBPID.
        /// </summary>
        public const string NBPID = "NBPID";

        /// <summary>
        /// NBJOBN.
        /// </summary>
        public const string NBJOBN = "NBJOBN";

        /// <summary>
        /// NBUPMJ.
        /// </summary>
        public const string NBUPMJ = "NBUPMJ";

        /// <summary>
        /// NBUPMT.
        /// </summary>
        public const string NBUPMT = "NBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08362";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBPLAN", "NBPLAN", JdeDataType.String, 16, true, true),
        new JdeField("NBTSTN", "NBTSTN", JdeDataType.String, 16, true, true),
        new JdeField("NBTSTY", "NBTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("NBSEQ5", "NBSEQ5", JdeDataType.Numeric, null, true, true),
        new JdeField("NBVERS", "NBVERS", JdeDataType.String, 20),
        new JdeField("NBUSER", "NBUSER", JdeDataType.String, 20),
        new JdeField("NBPID", "NBPID", JdeDataType.String, 20),
        new JdeField("NBJOBN", "NBJOBN", JdeDataType.String, 20),
        new JdeField("NBUPMJ", "NBUPMJ", JdeDataType.Numeric),
        new JdeField("NBUPMT", "NBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08362_0", "Primary Key on NBPLAN, NBTSTN, NBTSTY, NBSEQ5", new[] { "NBPLAN", "NBTSTN", "NBTSTY", "NBSEQ5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08362_2", "Index on NBPLAN, NBSEQ5, NBTSTN, NBTSTY", new[] { "NBPLAN", "NBSEQ5", "NBTSTN", "NBTSTY" }),
        new JdeIndex("F08362_3", "Index on NBPLAN", new[] { "NBPLAN" }),
        new JdeIndex("F08362_4", "Index on NBPLAN, NBTSTN, NBTSTY", new[] { "NBPLAN", "NBTSTN", "NBTSTY" })
    };
}
