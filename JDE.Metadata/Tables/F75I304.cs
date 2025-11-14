using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I304 - .
/// </summary>
public class F75I304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q3YEXU.
        /// </summary>
        public const string Q3YEXU = "Q3YEXU";

        /// <summary>
        /// Q3MCU.
        /// </summary>
        public const string Q3MCU = "Q3MCU";

        /// <summary>
        /// Q3YCHL.
        /// </summary>
        public const string Q3YCHL = "Q3YCHL";

        /// <summary>
        /// Q3USER.
        /// </summary>
        public const string Q3USER = "Q3USER";

        /// <summary>
        /// Q3PID.
        /// </summary>
        public const string Q3PID = "Q3PID";

        /// <summary>
        /// Q3JOBN.
        /// </summary>
        public const string Q3JOBN = "Q3JOBN";

        /// <summary>
        /// Q3UPMJ.
        /// </summary>
        public const string Q3UPMJ = "Q3UPMJ";

        /// <summary>
        /// Q3TDAY.
        /// </summary>
        public const string Q3TDAY = "Q3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3YEXU", "Q3YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3MCU", "Q3MCU", JdeDataType.String, 24, true, true),
        new JdeField("Q3YCHL", "Q3YCHL", JdeDataType.Numeric),
        new JdeField("Q3USER", "Q3USER", JdeDataType.String, 20),
        new JdeField("Q3PID", "Q3PID", JdeDataType.String, 20),
        new JdeField("Q3JOBN", "Q3JOBN", JdeDataType.String, 20),
        new JdeField("Q3UPMJ", "Q3UPMJ", JdeDataType.Numeric),
        new JdeField("Q3TDAY", "Q3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I304_0", "Primary Key on Q3YEXU, Q3MCU", new[] { "Q3YEXU", "Q3MCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I304_2", "Index on Q3MCU", new[] { "Q3MCU" })
    };
}
