using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45520TX - .
/// </summary>
public class F45520TX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTDOCO.
        /// </summary>
        public const string PTDOCO = "PTDOCO";

        /// <summary>
        /// PTDCTO.
        /// </summary>
        public const string PTDCTO = "PTDCTO";

        /// <summary>
        /// PTUTP.
        /// </summary>
        public const string PTUTP = "PTUTP";

        /// <summary>
        /// PTTXA1.
        /// </summary>
        public const string PTTXA1 = "PTTXA1";

        /// <summary>
        /// PTEXR1.
        /// </summary>
        public const string PTEXR1 = "PTEXR1";

        /// <summary>
        /// PTDTXJ.
        /// </summary>
        public const string PTDTXJ = "PTDTXJ";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45520TX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTDOCO", "PTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDCTO", "PTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PTUTP", "PTUTP", JdeDataType.String, 2),
        new JdeField("PTTXA1", "PTTXA1", JdeDataType.String, 20),
        new JdeField("PTEXR1", "PTEXR1", JdeDataType.String, 4),
        new JdeField("PTDTXJ", "PTDTXJ", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45520TX_0", "Primary Key on PTDOCO, PTDCTO", new[] { "PTDOCO", "PTDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
