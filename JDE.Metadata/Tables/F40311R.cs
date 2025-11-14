using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40311R - .
/// </summary>
public class F40311R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P1UKID.
        /// </summary>
        public const string P1UKID = "P1UKID";

        /// <summary>
        /// P1REFC.
        /// </summary>
        public const string P1REFC = "P1REFC";

        /// <summary>
        /// P1AN8.
        /// </summary>
        public const string P1AN8 = "P1AN8";

        /// <summary>
        /// P1CS11.
        /// </summary>
        public const string P1CS11 = "P1CS11";

        /// <summary>
        /// P1ITM.
        /// </summary>
        public const string P1ITM = "P1ITM";

        /// <summary>
        /// P1IT11.
        /// </summary>
        public const string P1IT11 = "P1IT11";

        /// <summary>
        /// P1EFTJ.
        /// </summary>
        public const string P1EFTJ = "P1EFTJ";

        /// <summary>
        /// P1EXDJ.
        /// </summary>
        public const string P1EXDJ = "P1EXDJ";

        /// <summary>
        /// P1MNQ.
        /// </summary>
        public const string P1MNQ = "P1MNQ";

        /// <summary>
        /// P1MXQ.
        /// </summary>
        public const string P1MXQ = "P1MXQ";

        /// <summary>
        /// P1UOM.
        /// </summary>
        public const string P1UOM = "P1UOM";

        /// <summary>
        /// P1TXID.
        /// </summary>
        public const string P1TXID = "P1TXID";

        /// <summary>
        /// P1STPR.
        /// </summary>
        public const string P1STPR = "P1STPR";

        /// <summary>
        /// P1UPC1.
        /// </summary>
        public const string P1UPC1 = "P1UPC1";

        /// <summary>
        /// P1URCD.
        /// </summary>
        public const string P1URCD = "P1URCD";

        /// <summary>
        /// P1URDT.
        /// </summary>
        public const string P1URDT = "P1URDT";

        /// <summary>
        /// P1URAT.
        /// </summary>
        public const string P1URAT = "P1URAT";

        /// <summary>
        /// P1URAB.
        /// </summary>
        public const string P1URAB = "P1URAB";

        /// <summary>
        /// P1URRF.
        /// </summary>
        public const string P1URRF = "P1URRF";

        /// <summary>
        /// P1USER.
        /// </summary>
        public const string P1USER = "P1USER";

        /// <summary>
        /// P1PID.
        /// </summary>
        public const string P1PID = "P1PID";

        /// <summary>
        /// P1JOBN.
        /// </summary>
        public const string P1JOBN = "P1JOBN";

        /// <summary>
        /// P1UPMJ.
        /// </summary>
        public const string P1UPMJ = "P1UPMJ";

        /// <summary>
        /// P1TDAY.
        /// </summary>
        public const string P1TDAY = "P1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40311R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P1UKID", "P1UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("P1REFC", "P1REFC", JdeDataType.Numeric),
        new JdeField("P1AN8", "P1AN8", JdeDataType.Numeric),
        new JdeField("P1CS11", "P1CS11", JdeDataType.String, 16),
        new JdeField("P1ITM", "P1ITM", JdeDataType.Numeric),
        new JdeField("P1IT11", "P1IT11", JdeDataType.String, 16),
        new JdeField("P1EFTJ", "P1EFTJ", JdeDataType.Numeric),
        new JdeField("P1EXDJ", "P1EXDJ", JdeDataType.Numeric),
        new JdeField("P1MNQ", "P1MNQ", JdeDataType.Numeric),
        new JdeField("P1MXQ", "P1MXQ", JdeDataType.Numeric),
        new JdeField("P1UOM", "P1UOM", JdeDataType.String, 4),
        new JdeField("P1TXID", "P1TXID", JdeDataType.Numeric),
        new JdeField("P1STPR", "P1STPR", JdeDataType.String, 2),
        new JdeField("P1UPC1", "P1UPC1", JdeDataType.String, 4),
        new JdeField("P1URCD", "P1URCD", JdeDataType.String, 4),
        new JdeField("P1URDT", "P1URDT", JdeDataType.Numeric),
        new JdeField("P1URAT", "P1URAT", JdeDataType.Numeric),
        new JdeField("P1URAB", "P1URAB", JdeDataType.Numeric),
        new JdeField("P1URRF", "P1URRF", JdeDataType.String, 30),
        new JdeField("P1USER", "P1USER", JdeDataType.String, 20),
        new JdeField("P1PID", "P1PID", JdeDataType.String, 20),
        new JdeField("P1JOBN", "P1JOBN", JdeDataType.String, 20),
        new JdeField("P1UPMJ", "P1UPMJ", JdeDataType.Numeric),
        new JdeField("P1TDAY", "P1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40311R_0", "Primary Key on P1UKID", new[] { "P1UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40311R_2", "Index on P1AN8, P1CS11, P1ITM, P1IT11, P1EXDJ, P1MXQ, P1UOM, P1UPC1, P1UPMJ, P1TDAY", new[] { "P1AN8", "P1CS11", "P1ITM", "P1IT11", "P1EXDJ", "P1MXQ", "P1UOM", "P1UPC1", "P1UPMJ", "P1TDAY" })
    };
}
