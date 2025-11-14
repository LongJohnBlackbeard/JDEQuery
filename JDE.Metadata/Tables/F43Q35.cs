using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q35 - .
/// </summary>
public class F43Q35 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTIDLN.
        /// </summary>
        public const string PTIDLN = "PTIDLN";

        /// <summary>
        /// PTSPWD.
        /// </summary>
        public const string PTSPWD = "PTSPWD";

        /// <summary>
        /// PTURCD.
        /// </summary>
        public const string PTURCD = "PTURCD";

        /// <summary>
        /// PTURDT.
        /// </summary>
        public const string PTURDT = "PTURDT";

        /// <summary>
        /// PTURAT.
        /// </summary>
        public const string PTURAT = "PTURAT";

        /// <summary>
        /// PTURAB.
        /// </summary>
        public const string PTURAB = "PTURAB";

        /// <summary>
        /// PTURRF.
        /// </summary>
        public const string PTURRF = "PTURRF";

        /// <summary>
        /// PTTORG.
        /// </summary>
        public const string PTTORG = "PTTORG";

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
    public override string TableName => "F43Q35";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PTIDLN", "PTIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PTSPWD", "PTSPWD", JdeDataType.String, 20),
        new JdeField("PTURCD", "PTURCD", JdeDataType.String, 4),
        new JdeField("PTURDT", "PTURDT", JdeDataType.Numeric),
        new JdeField("PTURAT", "PTURAT", JdeDataType.Numeric),
        new JdeField("PTURAB", "PTURAB", JdeDataType.Numeric),
        new JdeField("PTURRF", "PTURRF", JdeDataType.String, 30),
        new JdeField("PTTORG", "PTTORG", JdeDataType.String, 20),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q35_0", "Primary Key on PTAN8, PTIDLN", new[] { "PTAN8", "PTIDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
