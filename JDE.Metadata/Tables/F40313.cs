using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40313 - .
/// </summary>
public class F40313 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P3AN8.
        /// </summary>
        public const string P3AN8 = "P3AN8";

        /// <summary>
        /// P3CS13.
        /// </summary>
        public const string P3CS13 = "P3CS13";

        /// <summary>
        /// P3ITM.
        /// </summary>
        public const string P3ITM = "P3ITM";

        /// <summary>
        /// P3IT13.
        /// </summary>
        public const string P3IT13 = "P3IT13";

        /// <summary>
        /// P3EFTJ.
        /// </summary>
        public const string P3EFTJ = "P3EFTJ";

        /// <summary>
        /// P3EXDJ.
        /// </summary>
        public const string P3EXDJ = "P3EXDJ";

        /// <summary>
        /// P3MNQ.
        /// </summary>
        public const string P3MNQ = "P3MNQ";

        /// <summary>
        /// P3MXQ.
        /// </summary>
        public const string P3MXQ = "P3MXQ";

        /// <summary>
        /// P3UOM.
        /// </summary>
        public const string P3UOM = "P3UOM";

        /// <summary>
        /// P3TXID.
        /// </summary>
        public const string P3TXID = "P3TXID";

        /// <summary>
        /// P3STPR.
        /// </summary>
        public const string P3STPR = "P3STPR";

        /// <summary>
        /// P3UPC3.
        /// </summary>
        public const string P3UPC3 = "P3UPC3";

        /// <summary>
        /// P3URCD.
        /// </summary>
        public const string P3URCD = "P3URCD";

        /// <summary>
        /// P3URDT.
        /// </summary>
        public const string P3URDT = "P3URDT";

        /// <summary>
        /// P3URAT.
        /// </summary>
        public const string P3URAT = "P3URAT";

        /// <summary>
        /// P3URAB.
        /// </summary>
        public const string P3URAB = "P3URAB";

        /// <summary>
        /// P3URRF.
        /// </summary>
        public const string P3URRF = "P3URRF";

        /// <summary>
        /// P3USER.
        /// </summary>
        public const string P3USER = "P3USER";

        /// <summary>
        /// P3PID.
        /// </summary>
        public const string P3PID = "P3PID";

        /// <summary>
        /// P3JOBN.
        /// </summary>
        public const string P3JOBN = "P3JOBN";

        /// <summary>
        /// P3UPMJ.
        /// </summary>
        public const string P3UPMJ = "P3UPMJ";

        /// <summary>
        /// P3TDAY.
        /// </summary>
        public const string P3TDAY = "P3TDAY";

        /// <summary>
        /// P3OSEQ.
        /// </summary>
        public const string P3OSEQ = "P3OSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F40313";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P3AN8", "P3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("P3CS13", "P3CS13", JdeDataType.String, 16, true, true),
        new JdeField("P3ITM", "P3ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("P3IT13", "P3IT13", JdeDataType.String, 16, true, true),
        new JdeField("P3EFTJ", "P3EFTJ", JdeDataType.Numeric),
        new JdeField("P3EXDJ", "P3EXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("P3MNQ", "P3MNQ", JdeDataType.Numeric),
        new JdeField("P3MXQ", "P3MXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("P3UOM", "P3UOM", JdeDataType.String, 4, true, true),
        new JdeField("P3TXID", "P3TXID", JdeDataType.Numeric),
        new JdeField("P3STPR", "P3STPR", JdeDataType.String, 2),
        new JdeField("P3UPC3", "P3UPC3", JdeDataType.String, 4),
        new JdeField("P3URCD", "P3URCD", JdeDataType.String, 4),
        new JdeField("P3URDT", "P3URDT", JdeDataType.Numeric),
        new JdeField("P3URAT", "P3URAT", JdeDataType.Numeric),
        new JdeField("P3URAB", "P3URAB", JdeDataType.Numeric),
        new JdeField("P3URRF", "P3URRF", JdeDataType.String, 30),
        new JdeField("P3USER", "P3USER", JdeDataType.String, 20),
        new JdeField("P3PID", "P3PID", JdeDataType.String, 20),
        new JdeField("P3JOBN", "P3JOBN", JdeDataType.String, 20),
        new JdeField("P3UPMJ", "P3UPMJ", JdeDataType.Numeric),
        new JdeField("P3TDAY", "P3TDAY", JdeDataType.Numeric),
        new JdeField("P3OSEQ", "P3OSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40313_0", "Primary Key on P3AN8, P3CS13, P3ITM, P3IT13, P3EXDJ, P3UOM, P3MXQ", new[] { "P3AN8", "P3CS13", "P3ITM", "P3IT13", "P3EXDJ", "P3UOM", "P3MXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
