using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0009 - .
/// </summary>
public class F75A0009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A9AN8.
        /// </summary>
        public const string A9AN8 = "A9AN8";

        /// <summary>
        /// A9PDBA.
        /// </summary>
        public const string A9PDBA = "A9PDBA";

        /// <summary>
        /// A9PSDT.
        /// </summary>
        public const string A9PSDT = "A9PSDT";

        /// <summary>
        /// A9UD01.
        /// </summary>
        public const string A9UD01 = "A9UD01";

        /// <summary>
        /// A9UD02.
        /// </summary>
        public const string A9UD02 = "A9UD02";

        /// <summary>
        /// A9UD03.
        /// </summary>
        public const string A9UD03 = "A9UD03";

        /// <summary>
        /// A9UD04.
        /// </summary>
        public const string A9UD04 = "A9UD04";

        /// <summary>
        /// A9UPMJ.
        /// </summary>
        public const string A9UPMJ = "A9UPMJ";

        /// <summary>
        /// A9UPMT.
        /// </summary>
        public const string A9UPMT = "A9UPMT";

        /// <summary>
        /// A9PID.
        /// </summary>
        public const string A9PID = "A9PID";

        /// <summary>
        /// A9USER.
        /// </summary>
        public const string A9USER = "A9USER";

        /// <summary>
        /// A9JOBN.
        /// </summary>
        public const string A9JOBN = "A9JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A9AN8", "A9AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A9PDBA", "A9PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("A9PSDT", "A9PSDT", JdeDataType.Numeric, null, true, true),
        new JdeField("A9UD01", "A9UD01", JdeDataType.String, 30),
        new JdeField("A9UD02", "A9UD02", JdeDataType.String, 30),
        new JdeField("A9UD03", "A9UD03", JdeDataType.String, 30),
        new JdeField("A9UD04", "A9UD04", JdeDataType.String, 30),
        new JdeField("A9UPMJ", "A9UPMJ", JdeDataType.Numeric),
        new JdeField("A9UPMT", "A9UPMT", JdeDataType.Numeric),
        new JdeField("A9PID", "A9PID", JdeDataType.String, 20),
        new JdeField("A9USER", "A9USER", JdeDataType.String, 20),
        new JdeField("A9JOBN", "A9JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0009_0", "Primary Key on A9AN8, A9PDBA, A9PSDT", new[] { "A9AN8", "A9PDBA", "A9PSDT" }, isUnique: true, isPrimaryKey: true)
    };
}
