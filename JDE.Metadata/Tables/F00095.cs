using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00095 - .
/// </summary>
public class F00095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1OBNM.
        /// </summary>
        public const string A1OBNM = "A1OBNM";

        /// <summary>
        /// A1GENKEY.
        /// </summary>
        public const string A1GENKEY = "A1GENKEY";

        /// <summary>
        /// A1USER.
        /// </summary>
        public const string A1USER = "A1USER";

        /// <summary>
        /// A1PID.
        /// </summary>
        public const string A1PID = "A1PID";

        /// <summary>
        /// A1UPMJ.
        /// </summary>
        public const string A1UPMJ = "A1UPMJ";

        /// <summary>
        /// A1UPMT.
        /// </summary>
        public const string A1UPMT = "A1UPMT";

        /// <summary>
        /// A1JOBN.
        /// </summary>
        public const string A1JOBN = "A1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F00095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1OBNM", "A1OBNM", JdeDataType.String, 20, true, true),
        new JdeField("A1GENKEY", "A1GENKEY", JdeDataType.String, 80, true, true),
        new JdeField("A1USER", "A1USER", JdeDataType.String, 20),
        new JdeField("A1PID", "A1PID", JdeDataType.String, 20),
        new JdeField("A1UPMJ", "A1UPMJ", JdeDataType.Numeric),
        new JdeField("A1UPMT", "A1UPMT", JdeDataType.Numeric),
        new JdeField("A1JOBN", "A1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00095_0", "Primary Key on A1OBNM, A1GENKEY", new[] { "A1OBNM", "A1GENKEY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00095_2", "Index on A1USER", new[] { "A1USER" }),
        new JdeIndex("F00095_3", "Index on A1OBNM, A1USER, A1PID", new[] { "A1OBNM", "A1USER", "A1PID" })
    };
}
