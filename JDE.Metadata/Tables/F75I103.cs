using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I103 - .
/// </summary>
public class F75I103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TACO.
        /// </summary>
        public const string TACO = "TACO";

        /// <summary>
        /// TAI75QNO.
        /// </summary>
        public const string TAI75QNO = "TAI75QNO";

        /// <summary>
        /// TAFYR.
        /// </summary>
        public const string TAFYR = "TAFYR";

        /// <summary>
        /// TAI75TXRG.
        /// </summary>
        public const string TAI75TXRG = "TAI75TXRG";

        /// <summary>
        /// TAI75ACK.
        /// </summary>
        public const string TAI75ACK = "TAI75ACK";

        /// <summary>
        /// TAI75TOFF.
        /// </summary>
        public const string TAI75TOFF = "TAI75TOFF";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TACO", "TACO", JdeDataType.String, 10, true, true),
        new JdeField("TAI75QNO", "TAI75QNO", JdeDataType.String, 6, true, true),
        new JdeField("TAFYR", "TAFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("TAI75TXRG", "TAI75TXRG", JdeDataType.String, 10, true, true),
        new JdeField("TAI75ACK", "TAI75ACK", JdeDataType.String, 80),
        new JdeField("TAI75TOFF", "TAI75TOFF", JdeDataType.String, 120),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I103_0", "Primary Key on TACO, TAI75QNO, TAFYR, TAI75TXRG", new[] { "TACO", "TAI75QNO", "TAFYR", "TAI75TXRG" }, isUnique: true, isPrimaryKey: true)
    };
}
