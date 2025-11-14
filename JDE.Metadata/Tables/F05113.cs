using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05113 - .
/// </summary>
public class F05113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAN8.
        /// </summary>
        public const string ATAN8 = "ATAN8";

        /// <summary>
        /// ATCMPC.
        /// </summary>
        public const string ATCMPC = "ATCMPC";

        /// <summary>
        /// ATSEQ.
        /// </summary>
        public const string ATSEQ = "ATSEQ";

        /// <summary>
        /// ATACCP.
        /// </summary>
        public const string ATACCP = "ATACCP";

        /// <summary>
        /// ATACDA.
        /// </summary>
        public const string ATACDA = "ATACDA";

        /// <summary>
        /// ATAWRO.
        /// </summary>
        public const string ATAWRO = "ATAWRO";

        /// <summary>
        /// ATDTAW.
        /// </summary>
        public const string ATDTAW = "ATDTAW";

        /// <summary>
        /// ATSTA.
        /// </summary>
        public const string ATSTA = "ATSTA";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATJOBN.
        /// </summary>
        public const string ATJOBN = "ATJOBN";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAN8", "ATAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ATCMPC", "ATCMPC", JdeDataType.String, 20, true, true),
        new JdeField("ATSEQ", "ATSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ATACCP", "ATACCP", JdeDataType.String, 20),
        new JdeField("ATACDA", "ATACDA", JdeDataType.Numeric),
        new JdeField("ATAWRO", "ATAWRO", JdeDataType.String, 60),
        new JdeField("ATDTAW", "ATDTAW", JdeDataType.Numeric),
        new JdeField("ATSTA", "ATSTA", JdeDataType.String, 2),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATJOBN", "ATJOBN", JdeDataType.String, 20),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05113_0", "Primary Key on ATAN8, ATCMPC, ATSEQ", new[] { "ATAN8", "ATCMPC", "ATSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
