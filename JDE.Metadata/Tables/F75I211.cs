using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I211 - .
/// </summary>
public class F75I211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRAN8.
        /// </summary>
        public const string TRAN8 = "TRAN8";

        /// <summary>
        /// TRYPN1.
        /// </summary>
        public const string TRYPN1 = "TRYPN1";

        /// <summary>
        /// TRYTN1.
        /// </summary>
        public const string TRYTN1 = "TRYTN1";

        /// <summary>
        /// TRI75FTX1.
        /// </summary>
        public const string TRI75FTX1 = "TRI75FTX1";

        /// <summary>
        /// TRI75FTX2.
        /// </summary>
        public const string TRI75FTX2 = "TRI75FTX2";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRAN8", "TRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TRYPN1", "TRYPN1", JdeDataType.String, 80),
        new JdeField("TRYTN1", "TRYTN1", JdeDataType.String, 80),
        new JdeField("TRI75FTX1", "TRI75FTX1", JdeDataType.Numeric),
        new JdeField("TRI75FTX2", "TRI75FTX2", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I211_0", "Primary Key on TRAN8", new[] { "TRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
