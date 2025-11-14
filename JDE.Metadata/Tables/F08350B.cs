using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08350B - .
/// </summary>
public class F08350B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I8DIVC.
        /// </summary>
        public const string I8DIVC = "I8DIVC";

        /// <summary>
        /// I8SBGR.
        /// </summary>
        public const string I8SBGR = "I8SBGR";

        /// <summary>
        /// I8CATY.
        /// </summary>
        public const string I8CATY = "I8CATY";

        /// <summary>
        /// I8PID.
        /// </summary>
        public const string I8PID = "I8PID";

        /// <summary>
        /// I8UPMJ.
        /// </summary>
        public const string I8UPMJ = "I8UPMJ";

        /// <summary>
        /// I8UPMT.
        /// </summary>
        public const string I8UPMT = "I8UPMT";

        /// <summary>
        /// I8USER.
        /// </summary>
        public const string I8USER = "I8USER";

        /// <summary>
        /// I8JOBN.
        /// </summary>
        public const string I8JOBN = "I8JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08350B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I8DIVC", "I8DIVC", JdeDataType.String, 12, true, true),
        new JdeField("I8SBGR", "I8SBGR", JdeDataType.String, 20, true, true),
        new JdeField("I8CATY", "I8CATY", JdeDataType.String, 2),
        new JdeField("I8PID", "I8PID", JdeDataType.String, 20),
        new JdeField("I8UPMJ", "I8UPMJ", JdeDataType.Numeric),
        new JdeField("I8UPMT", "I8UPMT", JdeDataType.Numeric),
        new JdeField("I8USER", "I8USER", JdeDataType.String, 20),
        new JdeField("I8JOBN", "I8JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08350B_0", "Primary Key on I8DIVC, I8SBGR", new[] { "I8DIVC", "I8SBGR" }, isUnique: true, isPrimaryKey: true)
    };
}
