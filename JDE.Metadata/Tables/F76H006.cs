using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H006 - .
/// </summary>
public class F76H006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRDCT.
        /// </summary>
        public const string LRDCT = "LRDCT";

        /// <summary>
        /// LRH76CC02.
        /// </summary>
        public const string LRH76CC02 = "LRH76CC02";

        /// <summary>
        /// LRH76LEDT.
        /// </summary>
        public const string LRH76LEDT = "LRH76LEDT";

        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LRPID.
        /// </summary>
        public const string LRPID = "LRPID";

        /// <summary>
        /// LRJOBN.
        /// </summary>
        public const string LRJOBN = "LRJOBN";

        /// <summary>
        /// LRUPMJ.
        /// </summary>
        public const string LRUPMJ = "LRUPMJ";

        /// <summary>
        /// LRUPMT.
        /// </summary>
        public const string LRUPMT = "LRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRDCT", "LRDCT", JdeDataType.String, 4, true, true),
        new JdeField("LRH76CC02", "LRH76CC02", JdeDataType.String, 6, true, true),
        new JdeField("LRH76LEDT", "LRH76LEDT", JdeDataType.String, 6),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRJOBN", "LRJOBN", JdeDataType.String, 20),
        new JdeField("LRUPMJ", "LRUPMJ", JdeDataType.Numeric),
        new JdeField("LRUPMT", "LRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H006_0", "Primary Key on LRDCT, LRH76CC02", new[] { "LRDCT", "LRH76CC02" }, isUnique: true, isPrimaryKey: true)
    };
}
