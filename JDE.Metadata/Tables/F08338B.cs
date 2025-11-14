using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08338B - .
/// </summary>
public class F08338B : JdeTable
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
        /// PTPLAN.
        /// </summary>
        public const string PTPLAN = "PTPLAN";

        /// <summary>
        /// PTAOPT.
        /// </summary>
        public const string PTAOPT = "PTAOPT";

        /// <summary>
        /// PTEFT.
        /// </summary>
        public const string PTEFT = "PTEFT";

        /// <summary>
        /// PTPCP#.
        /// </summary>
        public const string PTPCP_ = "PTPCP#";

        /// <summary>
        /// PTPCPVST.
        /// </summary>
        public const string PTPCPVST = "PTPCPVST";

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
    public override string TableName => "F08338B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PTPLAN", "PTPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PTAOPT", "PTAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PTEFT", "PTEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("PTPCP#", "PTPCP#", JdeDataType.String, 40),
        new JdeField("PTPCPVST", "PTPCPVST", JdeDataType.String, 2),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08338B_0", "Primary Key on PTAN8, PTPLAN, PTAOPT, PTEFT", new[] { "PTAN8", "PTPLAN", "PTAOPT", "PTEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08338B_2", "Index on PTAN8, PTPLAN, PTAOPT, SYS_NC00012$", new[] { "PTAN8", "PTPLAN", "PTAOPT", "SYS_NC00012$" })
    };
}
