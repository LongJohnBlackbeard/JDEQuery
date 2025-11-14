using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3015 - .
/// </summary>
public class F3015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CQKIT.
        /// </summary>
        public const string CQKIT = "CQKIT";

        /// <summary>
        /// CQITM.
        /// </summary>
        public const string CQITM = "CQITM";

        /// <summary>
        /// CQCPNT.
        /// </summary>
        public const string CQCPNT = "CQCPNT";

        /// <summary>
        /// CQEFFF.
        /// </summary>
        public const string CQEFFF = "CQEFFF";

        /// <summary>
        /// CQEFFT.
        /// </summary>
        public const string CQEFFT = "CQEFFT";

        /// <summary>
        /// CQBLOC.
        /// </summary>
        public const string CQBLOC = "CQBLOC";

        /// <summary>
        /// CQMMCU.
        /// </summary>
        public const string CQMMCU = "CQMMCU";

        /// <summary>
        /// CQUSER.
        /// </summary>
        public const string CQUSER = "CQUSER";

        /// <summary>
        /// CQPID.
        /// </summary>
        public const string CQPID = "CQPID";

        /// <summary>
        /// CQUPMJ.
        /// </summary>
        public const string CQUPMJ = "CQUPMJ";

        /// <summary>
        /// CQJOBN.
        /// </summary>
        public const string CQJOBN = "CQJOBN";

        /// <summary>
        /// CQUKID.
        /// </summary>
        public const string CQUKID = "CQUKID";

        /// <summary>
        /// CQCPNB.
        /// </summary>
        public const string CQCPNB = "CQCPNB";
    }

    /// <inheritdoc />
    public override string TableName => "F3015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CQKIT", "CQKIT", JdeDataType.Numeric),
        new JdeField("CQITM", "CQITM", JdeDataType.Numeric),
        new JdeField("CQCPNT", "CQCPNT", JdeDataType.Numeric),
        new JdeField("CQEFFF", "CQEFFF", JdeDataType.Numeric),
        new JdeField("CQEFFT", "CQEFFT", JdeDataType.Numeric),
        new JdeField("CQBLOC", "CQBLOC", JdeDataType.String, 10),
        new JdeField("CQMMCU", "CQMMCU", JdeDataType.String, 24),
        new JdeField("CQUSER", "CQUSER", JdeDataType.String, 20),
        new JdeField("CQPID", "CQPID", JdeDataType.String, 20),
        new JdeField("CQUPMJ", "CQUPMJ", JdeDataType.Numeric),
        new JdeField("CQJOBN", "CQJOBN", JdeDataType.String, 20),
        new JdeField("CQUKID", "CQUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CQCPNB", "CQCPNB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3015_0", "Primary Key on CQUKID", new[] { "CQUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3015_2", "Index on CQKIT", new[] { "CQKIT" }),
        new JdeIndex("F3015_3", "Index on CQMMCU, CQKIT, CQITM, CQCPNB, CQEFFF, CQEFFT, CQBLOC", new[] { "CQMMCU", "CQKIT", "CQITM", "CQCPNB", "CQEFFF", "CQEFFT", "CQBLOC" }),
        new JdeIndex("F3015_4", "Index on CQMMCU, CQKIT, CQBLOC", new[] { "CQMMCU", "CQKIT", "CQBLOC" })
    };
}
