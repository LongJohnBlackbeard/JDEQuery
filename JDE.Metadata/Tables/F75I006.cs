using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I006 - .
/// </summary>
public class F75I006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSAST.
        /// </summary>
        public const string TSAST = "TSAST";

        /// <summary>
        /// TSI75TXTY.
        /// </summary>
        public const string TSI75TXTY = "TSI75TXTY";

        /// <summary>
        /// TSI75TXRG.
        /// </summary>
        public const string TSI75TXRG = "TSI75TXRG";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSUPMT.
        /// </summary>
        public const string TSUPMT = "TSUPMT";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSAST", "TSAST", JdeDataType.String, 16, true, true),
        new JdeField("TSI75TXTY", "TSI75TXTY", JdeDataType.String, 10),
        new JdeField("TSI75TXRG", "TSI75TXRG", JdeDataType.String, 10),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I006_0", "Primary Key on TSAST", new[] { "TSAST" }, isUnique: true, isPrimaryKey: true)
    };
}
