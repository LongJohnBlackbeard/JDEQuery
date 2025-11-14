using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4355 - .
/// </summary>
public class F4355 : JdeTable
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
        /// PTATHR.
        /// </summary>
        public const string PTATHR = "PTATHR";

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
    public override string TableName => "F4355";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PTATHR", "PTATHR", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4355_0", "Primary Key on PTAN8", new[] { "PTAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
