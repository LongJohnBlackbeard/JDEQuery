using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI44 - .
/// </summary>
public class F76AUI44 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFGLBA.
        /// </summary>
        public const string WFGLBA = "WFGLBA";

        /// <summary>
        /// WFDIVJ.
        /// </summary>
        public const string WFDIVJ = "WFDIVJ";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFURRF.
        /// </summary>
        public const string WFURRF = "WFURRF";

        /// <summary>
        /// WFMATH01.
        /// </summary>
        public const string WFMATH01 = "WFMATH01";

        /// <summary>
        /// WFEV02.
        /// </summary>
        public const string WFEV02 = "WFEV02";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFALPH.
        /// </summary>
        public const string WFALPH = "WFALPH";

        /// <summary>
        /// WFAC01.
        /// </summary>
        public const string WFAC01 = "WFAC01";

        /// <summary>
        /// WFEV03.
        /// </summary>
        public const string WFEV03 = "WFEV03";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFDDJ.
        /// </summary>
        public const string WFDDJ = "WFDDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI44";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFGLBA", "WFGLBA", JdeDataType.String, 16, true, true),
        new JdeField("WFDIVJ", "WFDIVJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFURRF", "WFURRF", JdeDataType.String, 30, true, true),
        new JdeField("WFMATH01", "WFMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV02", "WFEV02", JdeDataType.String, 2, true, true),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WFALPH", "WFALPH", JdeDataType.String, 80, true, true),
        new JdeField("WFAC01", "WFAC01", JdeDataType.String, 6, true, true),
        new JdeField("WFEV03", "WFEV03", JdeDataType.String, 2, true, true),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDDJ", "WFDDJ", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI44_0", "Primary Key on WFEV01, WFDOC, WFGLBA, WFDIVJ, WFDCT, WFURRF, WFMATH01, WFEV02, WFAN8, WFALPH, WFAC01, WFEV03, WFUPMJ, WFUSER, WFUPMT, WFDDJ", new[] { "WFEV01", "WFDOC", "WFGLBA", "WFDIVJ", "WFDCT", "WFURRF", "WFMATH01", "WFEV02", "WFAN8", "WFALPH", "WFAC01", "WFEV03", "WFUPMJ", "WFUSER", "WFUPMT", "WFDDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
