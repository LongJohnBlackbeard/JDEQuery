using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B406 - .
/// </summary>
public class F76B406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSB76CTYC.
        /// </summary>
        public const string TSB76CTYC = "TSB76CTYC";

        /// <summary>
        /// TSAN8J.
        /// </summary>
        public const string TSAN8J = "TSAN8J";

        /// <summary>
        /// TSPTC.
        /// </summary>
        public const string TSPTC = "TSPTC";

        /// <summary>
        /// TSB76SSFF.
        /// </summary>
        public const string TSB76SSFF = "TSB76SSFF";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSUPMT.
        /// </summary>
        public const string TSUPMT = "TSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSB76CTYC", "TSB76CTYC", JdeDataType.String, 20, true, true),
        new JdeField("TSAN8J", "TSAN8J", JdeDataType.Numeric),
        new JdeField("TSPTC", "TSPTC", JdeDataType.String, 6),
        new JdeField("TSB76SSFF", "TSB76SSFF", JdeDataType.String, 2),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B406_0", "Primary Key on TSB76CTYC", new[] { "TSB76CTYC" }, isUnique: true, isPrimaryKey: true)
    };
}
