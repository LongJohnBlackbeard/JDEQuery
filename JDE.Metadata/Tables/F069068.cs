using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069068 - .
/// </summary>
public class F069068 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTPCCD.
        /// </summary>
        public const string PTPCCD = "PTPCCD";

        /// <summary>
        /// PTPTFPT.
        /// </summary>
        public const string PTPTFPT = "PTPTFPT";

        /// <summary>
        /// PTPTTPT.
        /// </summary>
        public const string PTPTTPT = "PTPTTPT";

        /// <summary>
        /// PTSPASUST1.
        /// </summary>
        public const string PTSPASUST1 = "PTSPASUST1";

        /// <summary>
        /// PTSPASUST2.
        /// </summary>
        public const string PTSPASUST2 = "PTSPASUST2";

        /// <summary>
        /// PTSPASUST3.
        /// </summary>
        public const string PTSPASUST3 = "PTSPASUST3";

        /// <summary>
        /// PTSPASUST4.
        /// </summary>
        public const string PTSPASUST4 = "PTSPASUST4";

        /// <summary>
        /// PTSPACUST1.
        /// </summary>
        public const string PTSPACUST1 = "PTSPACUST1";

        /// <summary>
        /// PTSPACUST2.
        /// </summary>
        public const string PTSPACUST2 = "PTSPACUST2";

        /// <summary>
        /// PTSPACUST3.
        /// </summary>
        public const string PTSPACUST3 = "PTSPACUST3";

        /// <summary>
        /// PTSPACUST4.
        /// </summary>
        public const string PTSPACUST4 = "PTSPACUST4";

        /// <summary>
        /// PTSPANUST1.
        /// </summary>
        public const string PTSPANUST1 = "PTSPANUST1";

        /// <summary>
        /// PTSPANUST2.
        /// </summary>
        public const string PTSPANUST2 = "PTSPANUST2";

        /// <summary>
        /// PTSPANUST3.
        /// </summary>
        public const string PTSPANUST3 = "PTSPANUST3";

        /// <summary>
        /// PTSPANUST4.
        /// </summary>
        public const string PTSPANUST4 = "PTSPANUST4";

        /// <summary>
        /// PTSPADUST1.
        /// </summary>
        public const string PTSPADUST1 = "PTSPADUST1";

        /// <summary>
        /// PTSPADUST2.
        /// </summary>
        public const string PTSPADUST2 = "PTSPADUST2";

        /// <summary>
        /// PTSPADUST3.
        /// </summary>
        public const string PTSPADUST3 = "PTSPADUST3";

        /// <summary>
        /// PTSPADUST4.
        /// </summary>
        public const string PTSPADUST4 = "PTSPADUST4";

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
    public override string TableName => "F069068";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTPCCD", "PTPCCD", JdeDataType.String, 10, true, true),
        new JdeField("PTPTFPT", "PTPTFPT", JdeDataType.Numeric, null, true, true),
        new JdeField("PTPTTPT", "PTPTTPT", JdeDataType.Numeric),
        new JdeField("PTSPASUST1", "PTSPASUST1", JdeDataType.String, 60),
        new JdeField("PTSPASUST2", "PTSPASUST2", JdeDataType.String, 60),
        new JdeField("PTSPASUST3", "PTSPASUST3", JdeDataType.String, 60),
        new JdeField("PTSPASUST4", "PTSPASUST4", JdeDataType.String, 60),
        new JdeField("PTSPACUST1", "PTSPACUST1", JdeDataType.String, 2),
        new JdeField("PTSPACUST2", "PTSPACUST2", JdeDataType.String, 2),
        new JdeField("PTSPACUST3", "PTSPACUST3", JdeDataType.String, 2),
        new JdeField("PTSPACUST4", "PTSPACUST4", JdeDataType.String, 2),
        new JdeField("PTSPANUST1", "PTSPANUST1", JdeDataType.Numeric),
        new JdeField("PTSPANUST2", "PTSPANUST2", JdeDataType.Numeric),
        new JdeField("PTSPANUST3", "PTSPANUST3", JdeDataType.Numeric),
        new JdeField("PTSPANUST4", "PTSPANUST4", JdeDataType.Numeric),
        new JdeField("PTSPADUST1", "PTSPADUST1", JdeDataType.Numeric),
        new JdeField("PTSPADUST2", "PTSPADUST2", JdeDataType.Numeric),
        new JdeField("PTSPADUST3", "PTSPADUST3", JdeDataType.Numeric),
        new JdeField("PTSPADUST4", "PTSPADUST4", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069068_0", "Primary Key on PTPCCD, PTPTFPT", new[] { "PTPCCD", "PTPTFPT" }, isUnique: true, isPrimaryKey: true)
    };
}
