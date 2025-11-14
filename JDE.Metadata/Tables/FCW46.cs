using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW46 - .
/// </summary>
public class FCW46 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTC9GRCD.
        /// </summary>
        public const string RTC9GRCD = "RTC9GRCD";

        /// <summary>
        /// RTLCTR.
        /// </summary>
        public const string RTLCTR = "RTLCTR";

        /// <summary>
        /// RTC9LVCO.
        /// </summary>
        public const string RTC9LVCO = "RTC9LVCO";

        /// <summary>
        /// RTC9MULT.
        /// </summary>
        public const string RTC9MULT = "RTC9MULT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW46";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTC9GRCD", "RTC9GRCD", JdeDataType.String, 6, true, true),
        new JdeField("RTLCTR", "RTLCTR", JdeDataType.String, 6, true, true),
        new JdeField("RTC9LVCO", "RTC9LVCO", JdeDataType.String, 50, true, true),
        new JdeField("RTC9MULT", "RTC9MULT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW46_0", "Primary Key on RTC9GRCD, RTLCTR, RTC9LVCO", new[] { "RTC9GRCD", "RTLCTR", "RTC9LVCO" }, isUnique: true, isPrimaryKey: true)
    };
}
