using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3313 - .
/// </summary>
public class F3313 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCAPM.
        /// </summary>
        public const string CRCAPM = "CRCAPM";

        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CRCQT.
        /// </summary>
        public const string CRCQT = "CRCQT";

        /// <summary>
        /// CRUM.
        /// </summary>
        public const string CRUM = "CRUM";

        /// <summary>
        /// CRUNTY.
        /// </summary>
        public const string CRUNTY = "CRUNTY";

        /// <summary>
        /// CRSTRT.
        /// </summary>
        public const string CRSTRT = "CRSTRT";

        /// <summary>
        /// CRTRQT.
        /// </summary>
        public const string CRTRQT = "CRTRQT";

        /// <summary>
        /// CRWMCU.
        /// </summary>
        public const string CRWMCU = "CRWMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F3313";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCAPM", "CRCAPM", JdeDataType.String, 2, true, true),
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24, true, true),
        new JdeField("CRCQT", "CRCQT", JdeDataType.String, 4, true, true),
        new JdeField("CRUM", "CRUM", JdeDataType.String, 4, true, true),
        new JdeField("CRUNTY", "CRUNTY", JdeDataType.String, 2),
        new JdeField("CRSTRT", "CRSTRT", JdeDataType.Numeric, null, true, true),
        new JdeField("CRTRQT", "CRTRQT", JdeDataType.Numeric),
        new JdeField("CRWMCU", "CRWMCU", JdeDataType.String, 24, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3313_0", "Primary Key on CRCAPM, CRMCU, CRWMCU, CRUM, CRCQT, CRSTRT", new[] { "CRCAPM", "CRMCU", "CRWMCU", "CRUM", "CRCQT", "CRSTRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3313_2", "Index on CRCAPM, CRMCU, CRWMCU, CRUM, CRCQT, SYS_NC00009$", new[] { "CRCAPM", "CRMCU", "CRWMCU", "CRUM", "CRCQT", "SYS_NC00009$" })
    };
}
