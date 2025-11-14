using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40312 - .
/// </summary>
public class F40312 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P2AN8.
        /// </summary>
        public const string P2AN8 = "P2AN8";

        /// <summary>
        /// P2CS12.
        /// </summary>
        public const string P2CS12 = "P2CS12";

        /// <summary>
        /// P2ITM.
        /// </summary>
        public const string P2ITM = "P2ITM";

        /// <summary>
        /// P2IT12.
        /// </summary>
        public const string P2IT12 = "P2IT12";

        /// <summary>
        /// P2EFTJ.
        /// </summary>
        public const string P2EFTJ = "P2EFTJ";

        /// <summary>
        /// P2EXDJ.
        /// </summary>
        public const string P2EXDJ = "P2EXDJ";

        /// <summary>
        /// P2MNQ.
        /// </summary>
        public const string P2MNQ = "P2MNQ";

        /// <summary>
        /// P2MXQ.
        /// </summary>
        public const string P2MXQ = "P2MXQ";

        /// <summary>
        /// P2UOM.
        /// </summary>
        public const string P2UOM = "P2UOM";

        /// <summary>
        /// P2TXID.
        /// </summary>
        public const string P2TXID = "P2TXID";

        /// <summary>
        /// P2STPR.
        /// </summary>
        public const string P2STPR = "P2STPR";

        /// <summary>
        /// P2UPC2.
        /// </summary>
        public const string P2UPC2 = "P2UPC2";

        /// <summary>
        /// P2URCD.
        /// </summary>
        public const string P2URCD = "P2URCD";

        /// <summary>
        /// P2URDT.
        /// </summary>
        public const string P2URDT = "P2URDT";

        /// <summary>
        /// P2URAT.
        /// </summary>
        public const string P2URAT = "P2URAT";

        /// <summary>
        /// P2URAB.
        /// </summary>
        public const string P2URAB = "P2URAB";

        /// <summary>
        /// P2URRF.
        /// </summary>
        public const string P2URRF = "P2URRF";

        /// <summary>
        /// P2USER.
        /// </summary>
        public const string P2USER = "P2USER";

        /// <summary>
        /// P2PID.
        /// </summary>
        public const string P2PID = "P2PID";

        /// <summary>
        /// P2JOBN.
        /// </summary>
        public const string P2JOBN = "P2JOBN";

        /// <summary>
        /// P2UPMJ.
        /// </summary>
        public const string P2UPMJ = "P2UPMJ";

        /// <summary>
        /// P2TDAY.
        /// </summary>
        public const string P2TDAY = "P2TDAY";

        /// <summary>
        /// P2OSEQ.
        /// </summary>
        public const string P2OSEQ = "P2OSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F40312";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P2AN8", "P2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("P2CS12", "P2CS12", JdeDataType.String, 16, true, true),
        new JdeField("P2ITM", "P2ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("P2IT12", "P2IT12", JdeDataType.String, 16, true, true),
        new JdeField("P2EFTJ", "P2EFTJ", JdeDataType.Numeric),
        new JdeField("P2EXDJ", "P2EXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("P2MNQ", "P2MNQ", JdeDataType.Numeric),
        new JdeField("P2MXQ", "P2MXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("P2UOM", "P2UOM", JdeDataType.String, 4, true, true),
        new JdeField("P2TXID", "P2TXID", JdeDataType.Numeric),
        new JdeField("P2STPR", "P2STPR", JdeDataType.String, 2),
        new JdeField("P2UPC2", "P2UPC2", JdeDataType.String, 4),
        new JdeField("P2URCD", "P2URCD", JdeDataType.String, 4),
        new JdeField("P2URDT", "P2URDT", JdeDataType.Numeric),
        new JdeField("P2URAT", "P2URAT", JdeDataType.Numeric),
        new JdeField("P2URAB", "P2URAB", JdeDataType.Numeric),
        new JdeField("P2URRF", "P2URRF", JdeDataType.String, 30),
        new JdeField("P2USER", "P2USER", JdeDataType.String, 20),
        new JdeField("P2PID", "P2PID", JdeDataType.String, 20),
        new JdeField("P2JOBN", "P2JOBN", JdeDataType.String, 20),
        new JdeField("P2UPMJ", "P2UPMJ", JdeDataType.Numeric),
        new JdeField("P2TDAY", "P2TDAY", JdeDataType.Numeric),
        new JdeField("P2OSEQ", "P2OSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40312_0", "Primary Key on P2AN8, P2CS12, P2ITM, P2IT12, P2EXDJ, P2UOM, P2MXQ", new[] { "P2AN8", "P2CS12", "P2ITM", "P2IT12", "P2EXDJ", "P2UOM", "P2MXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
