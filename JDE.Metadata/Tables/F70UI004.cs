using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70UI004 - .
/// </summary>
public class F70UI004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TXJOBS.
        /// </summary>
        public const string TXJOBS = "TXJOBS";

        /// <summary>
        /// TXTXA1.
        /// </summary>
        public const string TXTXA1 = "TXTXA1";

        /// <summary>
        /// TXEFDJ.
        /// </summary>
        public const string TXEFDJ = "TXEFDJ";

        /// <summary>
        /// TXITM.
        /// </summary>
        public const string TXITM = "TXITM";

        /// <summary>
        /// TXTXR1.
        /// </summary>
        public const string TXTXR1 = "TXTXR1";

        /// <summary>
        /// TXK70TT.
        /// </summary>
        public const string TXK70TT = "TXK70TT";

        /// <summary>
        /// TXK70TR.
        /// </summary>
        public const string TXK70TR = "TXK70TR";

        /// <summary>
        /// TXK70TC.
        /// </summary>
        public const string TXK70TC = "TXK70TC";

        /// <summary>
        /// TXSTAM.
        /// </summary>
        public const string TXSTAM = "TXSTAM";

        /// <summary>
        /// TXUSER.
        /// </summary>
        public const string TXUSER = "TXUSER";

        /// <summary>
        /// TXPID.
        /// </summary>
        public const string TXPID = "TXPID";

        /// <summary>
        /// TXJOBN.
        /// </summary>
        public const string TXJOBN = "TXJOBN";

        /// <summary>
        /// TXUPMJ.
        /// </summary>
        public const string TXUPMJ = "TXUPMJ";

        /// <summary>
        /// TXUPMT.
        /// </summary>
        public const string TXUPMT = "TXUPMT";

        /// <summary>
        /// TXK70CTR.
        /// </summary>
        public const string TXK70CTR = "TXK70CTR";
    }

    /// <inheritdoc />
    public override string TableName => "F70UI004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TXJOBS", "TXJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TXTXA1", "TXTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TXEFDJ", "TXEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TXITM", "TXITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TXTXR1", "TXTXR1", JdeDataType.Numeric),
        new JdeField("TXK70TT", "TXK70TT", JdeDataType.String, 18),
        new JdeField("TXK70TR", "TXK70TR", JdeDataType.String, 18),
        new JdeField("TXK70TC", "TXK70TC", JdeDataType.String, 18),
        new JdeField("TXSTAM", "TXSTAM", JdeDataType.Numeric),
        new JdeField("TXUSER", "TXUSER", JdeDataType.String, 20, true, true),
        new JdeField("TXPID", "TXPID", JdeDataType.String, 20),
        new JdeField("TXJOBN", "TXJOBN", JdeDataType.String, 20),
        new JdeField("TXUPMJ", "TXUPMJ", JdeDataType.Numeric),
        new JdeField("TXUPMT", "TXUPMT", JdeDataType.Numeric),
        new JdeField("TXK70CTR", "TXK70CTR", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70UI004_0", "Primary Key on TXJOBS, TXTXA1, TXEFDJ, TXITM, TXUSER", new[] { "TXJOBS", "TXTXA1", "TXEFDJ", "TXITM", "TXUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
