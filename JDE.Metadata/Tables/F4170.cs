using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4170 - .
/// </summary>
public class F4170 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I0LOTC.
        /// </summary>
        public const string I0LOTC = "I0LOTC";

        /// <summary>
        /// I0LSAR.
        /// </summary>
        public const string I0LSAR = "I0LSAR";

        /// <summary>
        /// I0LARV.
        /// </summary>
        public const string I0LARV = "I0LARV";

        /// <summary>
        /// I0PID.
        /// </summary>
        public const string I0PID = "I0PID";

        /// <summary>
        /// I0UPMJ.
        /// </summary>
        public const string I0UPMJ = "I0UPMJ";

        /// <summary>
        /// I0TDAY.
        /// </summary>
        public const string I0TDAY = "I0TDAY";

        /// <summary>
        /// I0USER.
        /// </summary>
        public const string I0USER = "I0USER";

        /// <summary>
        /// I0JOBN.
        /// </summary>
        public const string I0JOBN = "I0JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4170";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I0LOTC", "I0LOTC", JdeDataType.String, 6, true, true),
        new JdeField("I0LSAR", "I0LSAR", JdeDataType.String, 2, true, true),
        new JdeField("I0LARV", "I0LARV", JdeDataType.String, 2),
        new JdeField("I0PID", "I0PID", JdeDataType.String, 20),
        new JdeField("I0UPMJ", "I0UPMJ", JdeDataType.Numeric),
        new JdeField("I0TDAY", "I0TDAY", JdeDataType.Numeric),
        new JdeField("I0USER", "I0USER", JdeDataType.String, 20),
        new JdeField("I0JOBN", "I0JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4170_0", "Primary Key on I0LOTC, I0LSAR", new[] { "I0LOTC", "I0LSAR" }, isUnique: true, isPrimaryKey: true)
    };
}
