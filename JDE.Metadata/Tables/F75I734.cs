using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I734 - .
/// </summary>
public class F75I734 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFPYID.
        /// </summary>
        public const string PFPYID = "PFPYID";

        /// <summary>
        /// PFRC5.
        /// </summary>
        public const string PFRC5 = "PFRC5";

        /// <summary>
        /// PFI75RCLA.
        /// </summary>
        public const string PFI75RCLA = "PFI75RCLA";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFTDAY.
        /// </summary>
        public const string PFTDAY = "PFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I734";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFPYID", "PFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("PFRC5", "PFRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("PFI75RCLA", "PFI75RCLA", JdeDataType.String, 2),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFTDAY", "PFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I734_0", "Primary Key on PFPYID, PFRC5", new[] { "PFPYID", "PFRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
