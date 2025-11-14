using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I005 - .
/// </summary>
public class F75I005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TGI75TXTY.
        /// </summary>
        public const string TGI75TXTY = "TGI75TXTY";

        /// <summary>
        /// TGI75TXRG.
        /// </summary>
        public const string TGI75TXRG = "TGI75TXRG";

        /// <summary>
        /// TGI75TXR.
        /// </summary>
        public const string TGI75TXR = "TGI75TXR";

        /// <summary>
        /// TGUSER.
        /// </summary>
        public const string TGUSER = "TGUSER";

        /// <summary>
        /// TGPID.
        /// </summary>
        public const string TGPID = "TGPID";

        /// <summary>
        /// TGUPMJ.
        /// </summary>
        public const string TGUPMJ = "TGUPMJ";

        /// <summary>
        /// TGUPMT.
        /// </summary>
        public const string TGUPMT = "TGUPMT";

        /// <summary>
        /// TGJOBN.
        /// </summary>
        public const string TGJOBN = "TGJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75I005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TGI75TXTY", "TGI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("TGI75TXRG", "TGI75TXRG", JdeDataType.String, 10, true, true),
        new JdeField("TGI75TXR", "TGI75TXR", JdeDataType.Numeric),
        new JdeField("TGUSER", "TGUSER", JdeDataType.String, 20),
        new JdeField("TGPID", "TGPID", JdeDataType.String, 20),
        new JdeField("TGUPMJ", "TGUPMJ", JdeDataType.Numeric),
        new JdeField("TGUPMT", "TGUPMT", JdeDataType.Numeric),
        new JdeField("TGJOBN", "TGJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I005_0", "Primary Key on TGI75TXTY, TGI75TXRG", new[] { "TGI75TXTY", "TGI75TXRG" }, isUnique: true, isPrimaryKey: true)
    };
}
