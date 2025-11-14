using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI7 - .
/// </summary>
public class F75IUI7 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFPYID.
        /// </summary>
        public const string WFPYID = "WFPYID";

        /// <summary>
        /// WFRC5.
        /// </summary>
        public const string WFRC5 = "WFRC5";

        /// <summary>
        /// WFFLAG.
        /// </summary>
        public const string WFFLAG = "WFFLAG";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";

        /// <summary>
        /// WFSFXE.
        /// </summary>
        public const string WFSFXE = "WFSFXE";

        /// <summary>
        /// WFDMTJ.
        /// </summary>
        public const string WFDMTJ = "WFDMTJ";

        /// <summary>
        /// WFICU.
        /// </summary>
        public const string WFICU = "WFICU";

        /// <summary>
        /// WFICUT.
        /// </summary>
        public const string WFICUT = "WFICUT";

        /// <summary>
        /// WFPAAP.
        /// </summary>
        public const string WFPAAP = "WFPAAP";

        /// <summary>
        /// WFPFAP.
        /// </summary>
        public const string WFPFAP = "WFPFAP";

        /// <summary>
        /// WFCRCD.
        /// </summary>
        public const string WFCRCD = "WFCRCD";

        /// <summary>
        /// WFI75TXRG.
        /// </summary>
        public const string WFI75TXRG = "WFI75TXRG";

        /// <summary>
        /// WFI75TXTY.
        /// </summary>
        public const string WFI75TXTY = "WFI75TXTY";

        /// <summary>
        /// WFI75SRCT.
        /// </summary>
        public const string WFI75SRCT = "WFI75SRCT";

        /// <summary>
        /// WFDL01.
        /// </summary>
        public const string WFDL01 = "WFDL01";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFYS05.
        /// </summary>
        public const string WFYS05 = "WFYS05";

        /// <summary>
        /// WFYS06.
        /// </summary>
        public const string WFYS06 = "WFYS06";

        /// <summary>
        /// WFMATH01.
        /// </summary>
        public const string WFMATH01 = "WFMATH01";

        /// <summary>
        /// WFMATH02.
        /// </summary>
        public const string WFMATH02 = "WFMATH02";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI7";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFPYID", "WFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFRC5", "WFRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("WFFLAG", "WFFLAG", JdeDataType.String, 2, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6),
        new JdeField("WFSFXE", "WFSFXE", JdeDataType.Numeric),
        new JdeField("WFDMTJ", "WFDMTJ", JdeDataType.Numeric),
        new JdeField("WFICU", "WFICU", JdeDataType.Numeric),
        new JdeField("WFICUT", "WFICUT", JdeDataType.String, 4),
        new JdeField("WFPAAP", "WFPAAP", JdeDataType.Numeric),
        new JdeField("WFPFAP", "WFPFAP", JdeDataType.Numeric),
        new JdeField("WFCRCD", "WFCRCD", JdeDataType.String, 6),
        new JdeField("WFI75TXRG", "WFI75TXRG", JdeDataType.String, 10),
        new JdeField("WFI75TXTY", "WFI75TXTY", JdeDataType.String, 10),
        new JdeField("WFI75SRCT", "WFI75SRCT", JdeDataType.String, 12),
        new JdeField("WFDL01", "WFDL01", JdeDataType.String, 60),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFYS05", "WFYS05", JdeDataType.String, 40),
        new JdeField("WFYS06", "WFYS06", JdeDataType.String, 40),
        new JdeField("WFMATH01", "WFMATH01", JdeDataType.Numeric),
        new JdeField("WFMATH02", "WFMATH02", JdeDataType.Numeric),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI7_0", "Primary Key on WFPYID, WFRC5, WFFLAG", new[] { "WFPYID", "WFRC5", "WFFLAG" }, isUnique: true, isPrimaryKey: true)
    };
}
