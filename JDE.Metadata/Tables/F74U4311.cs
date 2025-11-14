using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4311 - .
/// </summary>
public class F74U4311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTKCOO.
        /// </summary>
        public const string PTKCOO = "PTKCOO";

        /// <summary>
        /// PTDOCO.
        /// </summary>
        public const string PTDOCO = "PTDOCO";

        /// <summary>
        /// PTDCTO.
        /// </summary>
        public const string PTDCTO = "PTDCTO";

        /// <summary>
        /// PTSFXO.
        /// </summary>
        public const string PTSFXO = "PTSFXO";

        /// <summary>
        /// PTLNID.
        /// </summary>
        public const string PTLNID = "PTLNID";

        /// <summary>
        /// PTUNIT.
        /// </summary>
        public const string PTUNIT = "PTUNIT";

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
        /// PTTDAY.
        /// </summary>
        public const string PTTDAY = "PTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTKCOO", "PTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PTDOCO", "PTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDCTO", "PTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PTSFXO", "PTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PTLNID", "PTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PTUNIT", "PTUNIT", JdeDataType.String, 16),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4311_0", "Primary Key on PTDOCO, PTDCTO, PTKCOO, PTSFXO, PTLNID", new[] { "PTDOCO", "PTDCTO", "PTKCOO", "PTSFXO", "PTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
