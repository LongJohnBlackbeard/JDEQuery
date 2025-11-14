using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I072 - .
/// </summary>
public class F75I072 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSI75TXRN.
        /// </summary>
        public const string TSI75TXRN = "TSI75TXRN";

        /// <summary>
        /// TSITM.
        /// </summary>
        public const string TSITM = "TSITM";

        /// <summary>
        /// TSMCU.
        /// </summary>
        public const string TSMCU = "TSMCU";

        /// <summary>
        /// TSDL01.
        /// </summary>
        public const string TSDL01 = "TSDL01";

        /// <summary>
        /// TSI75TXRT.
        /// </summary>
        public const string TSI75TXRT = "TSI75TXRT";

        /// <summary>
        /// TSEFTJ.
        /// </summary>
        public const string TSEFTJ = "TSEFTJ";

        /// <summary>
        /// TSEXDJ.
        /// </summary>
        public const string TSEXDJ = "TSEXDJ";

        /// <summary>
        /// TSI75TRPE.
        /// </summary>
        public const string TSI75TRPE = "TSI75TRPE";

        /// <summary>
        /// TSI75TRNO.
        /// </summary>
        public const string TSI75TRNO = "TSI75TRNO";

        /// <summary>
        /// TSI75TRVA.
        /// </summary>
        public const string TSI75TRVA = "TSI75TRVA";

        /// <summary>
        /// TSI75TRS1.
        /// </summary>
        public const string TSI75TRS1 = "TSI75TRS1";

        /// <summary>
        /// TSI75TRS2.
        /// </summary>
        public const string TSI75TRS2 = "TSI75TRS2";

        /// <summary>
        /// TSI75TRF1.
        /// </summary>
        public const string TSI75TRF1 = "TSI75TRF1";

        /// <summary>
        /// TSI75TRF2.
        /// </summary>
        public const string TSI75TRF2 = "TSI75TRF2";

        /// <summary>
        /// TSI75TRV1.
        /// </summary>
        public const string TSI75TRV1 = "TSI75TRV1";

        /// <summary>
        /// TSI75TRV2.
        /// </summary>
        public const string TSI75TRV2 = "TSI75TRV2";

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
    }

    /// <inheritdoc />
    public override string TableName => "F75I072";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSI75TXRN", "TSI75TXRN", JdeDataType.String, 20, true, true),
        new JdeField("TSITM", "TSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TSMCU", "TSMCU", JdeDataType.String, 24, true, true),
        new JdeField("TSDL01", "TSDL01", JdeDataType.String, 60),
        new JdeField("TSI75TXRT", "TSI75TXRT", JdeDataType.String, 2),
        new JdeField("TSEFTJ", "TSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TSEXDJ", "TSEXDJ", JdeDataType.Numeric),
        new JdeField("TSI75TRPE", "TSI75TRPE", JdeDataType.Numeric),
        new JdeField("TSI75TRNO", "TSI75TRNO", JdeDataType.String, 60),
        new JdeField("TSI75TRVA", "TSI75TRVA", JdeDataType.Numeric),
        new JdeField("TSI75TRS1", "TSI75TRS1", JdeDataType.String, 60),
        new JdeField("TSI75TRS2", "TSI75TRS2", JdeDataType.String, 60),
        new JdeField("TSI75TRF1", "TSI75TRF1", JdeDataType.String, 2),
        new JdeField("TSI75TRF2", "TSI75TRF2", JdeDataType.String, 2),
        new JdeField("TSI75TRV1", "TSI75TRV1", JdeDataType.Numeric),
        new JdeField("TSI75TRV2", "TSI75TRV2", JdeDataType.Numeric),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I072_0", "Primary Key on TSI75TXRN, TSITM, TSMCU, TSEFTJ", new[] { "TSI75TXRN", "TSITM", "TSMCU", "TSEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I072_2", "Index on TSI75TXRN", new[] { "TSI75TXRN" })
    };
}
