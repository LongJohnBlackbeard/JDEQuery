using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34UI004 - .
/// </summary>
public class F34UI004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M8JOBS.
        /// </summary>
        public const string M8JOBS = "M8JOBS";

        /// <summary>
        /// M8CTID.
        /// </summary>
        public const string M8CTID = "M8CTID";

        /// <summary>
        /// M8ITM.
        /// </summary>
        public const string M8ITM = "M8ITM";

        /// <summary>
        /// M8MCU.
        /// </summary>
        public const string M8MCU = "M8MCU";

        /// <summary>
        /// M8LLX.
        /// </summary>
        public const string M8LLX = "M8LLX";

        /// <summary>
        /// M8PRP1.
        /// </summary>
        public const string M8PRP1 = "M8PRP1";

        /// <summary>
        /// M8PRP2.
        /// </summary>
        public const string M8PRP2 = "M8PRP2";

        /// <summary>
        /// M8PRP3.
        /// </summary>
        public const string M8PRP3 = "M8PRP3";

        /// <summary>
        /// M8PRP4.
        /// </summary>
        public const string M8PRP4 = "M8PRP4";

        /// <summary>
        /// M8PRP5.
        /// </summary>
        public const string M8PRP5 = "M8PRP5";

        /// <summary>
        /// M8MRPC.
        /// </summary>
        public const string M8MRPC = "M8MRPC";

        /// <summary>
        /// M8STKT.
        /// </summary>
        public const string M8STKT = "M8STKT";

        /// <summary>
        /// M8EV01.
        /// </summary>
        public const string M8EV01 = "M8EV01";
    }

    /// <inheritdoc />
    public override string TableName => "F34UI004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M8JOBS", "M8JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("M8CTID", "M8CTID", JdeDataType.String, 30, true, true),
        new JdeField("M8ITM", "M8ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("M8MCU", "M8MCU", JdeDataType.String, 24, true, true),
        new JdeField("M8LLX", "M8LLX", JdeDataType.Numeric),
        new JdeField("M8PRP1", "M8PRP1", JdeDataType.String, 6),
        new JdeField("M8PRP2", "M8PRP2", JdeDataType.String, 6),
        new JdeField("M8PRP3", "M8PRP3", JdeDataType.String, 6),
        new JdeField("M8PRP4", "M8PRP4", JdeDataType.String, 6),
        new JdeField("M8PRP5", "M8PRP5", JdeDataType.String, 6),
        new JdeField("M8MRPC", "M8MRPC", JdeDataType.String, 2),
        new JdeField("M8STKT", "M8STKT", JdeDataType.String, 2),
        new JdeField("M8EV01", "M8EV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34UI004_0", "Primary Key on M8JOBS, M8CTID, M8ITM, M8MCU", new[] { "M8JOBS", "M8CTID", "M8ITM", "M8MCU" }, isUnique: true, isPrimaryKey: true)
    };
}
