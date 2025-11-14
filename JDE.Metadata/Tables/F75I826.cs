using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I826 - .
/// </summary>
public class F75I826 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSASN.
        /// </summary>
        public const string TSASN = "TSASN";

        /// <summary>
        /// TSI75TXRL.
        /// </summary>
        public const string TSI75TXRL = "TSI75TXRL";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSUPMT.
        /// </summary>
        public const string TSUPMT = "TSUPMT";

        /// <summary>
        /// TSYFUTDT1.
        /// </summary>
        public const string TSYFUTDT1 = "TSYFUTDT1";

        /// <summary>
        /// TSFUT6.
        /// </summary>
        public const string TSFUT6 = "TSFUT6";

        /// <summary>
        /// TSYT04.
        /// </summary>
        public const string TSYT04 = "TSYT04";

        /// <summary>
        /// TSYFLAG.
        /// </summary>
        public const string TSYFLAG = "TSYFLAG";

        /// <summary>
        /// TSYNUM1.
        /// </summary>
        public const string TSYNUM1 = "TSYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I826";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSASN", "TSASN", JdeDataType.String, 16, true, true),
        new JdeField("TSI75TXRL", "TSI75TXRL", JdeDataType.String, 12),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric),
        new JdeField("TSYFUTDT1", "TSYFUTDT1", JdeDataType.Numeric),
        new JdeField("TSFUT6", "TSFUT6", JdeDataType.String, 60),
        new JdeField("TSYT04", "TSYT04", JdeDataType.String, 2),
        new JdeField("TSYFLAG", "TSYFLAG", JdeDataType.String, 2),
        new JdeField("TSYNUM1", "TSYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I826_0", "Primary Key on TSASN", new[] { "TSASN" }, isUnique: true, isPrimaryKey: true)
    };
}
