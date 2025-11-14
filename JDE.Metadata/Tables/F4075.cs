using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4075 - .
/// </summary>
public class F4075 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VBVBT.
        /// </summary>
        public const string VBVBT = "VBVBT";

        /// <summary>
        /// VBCRCD.
        /// </summary>
        public const string VBCRCD = "VBCRCD";

        /// <summary>
        /// VBUOM.
        /// </summary>
        public const string VBUOM = "VBUOM";

        /// <summary>
        /// VBUPRC.
        /// </summary>
        public const string VBUPRC = "VBUPRC";

        /// <summary>
        /// VBEFTJ.
        /// </summary>
        public const string VBEFTJ = "VBEFTJ";

        /// <summary>
        /// VBEXDJ.
        /// </summary>
        public const string VBEXDJ = "VBEXDJ";

        /// <summary>
        /// VBAPRS.
        /// </summary>
        public const string VBAPRS = "VBAPRS";

        /// <summary>
        /// VBUSER.
        /// </summary>
        public const string VBUSER = "VBUSER";

        /// <summary>
        /// VBPID.
        /// </summary>
        public const string VBPID = "VBPID";

        /// <summary>
        /// VBJOBN.
        /// </summary>
        public const string VBJOBN = "VBJOBN";

        /// <summary>
        /// VBUPMJ.
        /// </summary>
        public const string VBUPMJ = "VBUPMJ";

        /// <summary>
        /// VBTDAY.
        /// </summary>
        public const string VBTDAY = "VBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4075";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VBVBT", "VBVBT", JdeDataType.String, 20, true, true),
        new JdeField("VBCRCD", "VBCRCD", JdeDataType.String, 6),
        new JdeField("VBUOM", "VBUOM", JdeDataType.String, 4),
        new JdeField("VBUPRC", "VBUPRC", JdeDataType.Numeric),
        new JdeField("VBEFTJ", "VBEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VBEXDJ", "VBEXDJ", JdeDataType.Numeric),
        new JdeField("VBAPRS", "VBAPRS", JdeDataType.String, 2),
        new JdeField("VBUSER", "VBUSER", JdeDataType.String, 20),
        new JdeField("VBPID", "VBPID", JdeDataType.String, 20),
        new JdeField("VBJOBN", "VBJOBN", JdeDataType.String, 20),
        new JdeField("VBUPMJ", "VBUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VBTDAY", "VBTDAY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4075_0", "Primary Key on VBVBT, VBEFTJ, VBUPMJ, VBTDAY", new[] { "VBVBT", "VBEFTJ", "VBUPMJ", "VBTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4075_3", "Index on VBVBT, SYS_NC00013$, SYS_NC00014$", new[] { "VBVBT", "SYS_NC00013$", "SYS_NC00014$" }),
        new JdeIndex("F4075_4", "Index on VBVBT, SYS_NC00015$, VBPID", new[] { "VBVBT", "SYS_NC00015$", "VBPID" })
    };
}
