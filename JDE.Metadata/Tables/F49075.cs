using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49075 - .
/// </summary>
public class F49075 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMITM.
        /// </summary>
        public const string PMITM = "PMITM";

        /// <summary>
        /// PMITMM.
        /// </summary>
        public const string PMITMM = "PMITMM";

        /// <summary>
        /// PMTYPI.
        /// </summary>
        public const string PMTYPI = "PMTYPI";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMTDAY.
        /// </summary>
        public const string PMTDAY = "PMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49075";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMITM", "PMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PMITMM", "PMITMM", JdeDataType.Numeric, null, true, true),
        new JdeField("PMTYPI", "PMTYPI", JdeDataType.String, 2, true, true),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMTDAY", "PMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49075_0", "Primary Key on PMITM, PMITMM, PMTYPI", new[] { "PMITM", "PMITMM", "PMTYPI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49075_3", "Index on PMTYPI, PMITM", new[] { "PMTYPI", "PMITM" }),
        new JdeIndex("F49075_4", "Index on PMTYPI, PMITMM", new[] { "PMTYPI", "PMITMM" })
    };
}
