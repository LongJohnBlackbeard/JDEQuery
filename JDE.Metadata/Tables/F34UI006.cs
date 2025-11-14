using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34UI006 - .
/// </summary>
public class F34UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W6JOBS.
        /// </summary>
        public const string W6JOBS = "W6JOBS";

        /// <summary>
        /// W6CTID.
        /// </summary>
        public const string W6CTID = "W6CTID";

        /// <summary>
        /// W6MCU.
        /// </summary>
        public const string W6MCU = "W6MCU";

        /// <summary>
        /// W6DRQJ.
        /// </summary>
        public const string W6DRQJ = "W6DRQJ";

        /// <summary>
        /// W6ITM.
        /// </summary>
        public const string W6ITM = "W6ITM";

        /// <summary>
        /// W6NQ01.
        /// </summary>
        public const string W6NQ01 = "W6NQ01";
    }

    /// <inheritdoc />
    public override string TableName => "F34UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W6JOBS", "W6JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("W6CTID", "W6CTID", JdeDataType.String, 30, true, true),
        new JdeField("W6MCU", "W6MCU", JdeDataType.String, 24, true, true),
        new JdeField("W6DRQJ", "W6DRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("W6ITM", "W6ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("W6NQ01", "W6NQ01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34UI006_0", "Primary Key on W6JOBS, W6CTID, W6MCU, W6DRQJ, W6ITM", new[] { "W6JOBS", "W6CTID", "W6MCU", "W6DRQJ", "W6ITM" }, isUnique: true, isPrimaryKey: true)
    };
}
