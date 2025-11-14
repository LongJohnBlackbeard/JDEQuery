using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01505 - .
/// </summary>
public class F01505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDRA8.
        /// </summary>
        public const string TDRA8 = "TDRA8";

        /// <summary>
        /// TDOSTP.
        /// </summary>
        public const string TDOSTP = "TDOSTP";

        /// <summary>
        /// TDTIER.
        /// </summary>
        public const string TDTIER = "TDTIER";

        /// <summary>
        /// TDTRDS.
        /// </summary>
        public const string TDTRDS = "TDTRDS";

        /// <summary>
        /// TDEFTJ.
        /// </summary>
        public const string TDEFTJ = "TDEFTJ";

        /// <summary>
        /// TDEXDJ.
        /// </summary>
        public const string TDEXDJ = "TDEXDJ";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDTIME.
        /// </summary>
        public const string TDTIME = "TDTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F01505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDRA8", "TDRA8", JdeDataType.Numeric, null, true, true),
        new JdeField("TDOSTP", "TDOSTP", JdeDataType.String, 6, true, true),
        new JdeField("TDTIER", "TDTIER", JdeDataType.Numeric, null, true, true),
        new JdeField("TDTRDS", "TDTRDS", JdeDataType.String, 80),
        new JdeField("TDEFTJ", "TDEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDEXDJ", "TDEXDJ", JdeDataType.Numeric),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDTIME", "TDTIME", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01505_0", "Primary Key on TDRA8, TDOSTP, TDTIER, TDEFTJ", new[] { "TDRA8", "TDOSTP", "TDTIER", "TDEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01505_4", "Index on TDRA8, TDOSTP, SYS_NC00011$", new[] { "TDRA8", "TDOSTP", "SYS_NC00011$" }),
        new JdeIndex("F01505_5", "Index on TDRA8, TDOSTP, TDTIER, SYS_NC00012$", new[] { "TDRA8", "TDOSTP", "TDTIER", "SYS_NC00012$" }),
        new JdeIndex("F01505_6", "Index on TDRA8, TDOSTP, TDTIER", new[] { "TDRA8", "TDOSTP", "TDTIER" })
    };
}
