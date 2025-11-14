using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L001W - .
/// </summary>
public class F15L001W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1MCU.
        /// </summary>
        public const string Q1MCU = "Q1MCU";

        /// <summary>
        /// Q1SBL.
        /// </summary>
        public const string Q1SBL = "Q1SBL";

        /// <summary>
        /// Q1AN8.
        /// </summary>
        public const string Q1AN8 = "Q1AN8";

        /// <summary>
        /// Q1ALPH.
        /// </summary>
        public const string Q1ALPH = "Q1ALPH";

        /// <summary>
        /// Q1AN01.
        /// </summary>
        public const string Q1AN01 = "Q1AN01";

        /// <summary>
        /// Q1AN02.
        /// </summary>
        public const string Q1AN02 = "Q1AN02";

        /// <summary>
        /// Q1AN03.
        /// </summary>
        public const string Q1AN03 = "Q1AN03";

        /// <summary>
        /// Q1AN04.
        /// </summary>
        public const string Q1AN04 = "Q1AN04";

        /// <summary>
        /// Q1AN05.
        /// </summary>
        public const string Q1AN05 = "Q1AN05";

        /// <summary>
        /// Q1AN06.
        /// </summary>
        public const string Q1AN06 = "Q1AN06";

        /// <summary>
        /// Q1AN07.
        /// </summary>
        public const string Q1AN07 = "Q1AN07";

        /// <summary>
        /// Q1AN08.
        /// </summary>
        public const string Q1AN08 = "Q1AN08";

        /// <summary>
        /// Q1AN09.
        /// </summary>
        public const string Q1AN09 = "Q1AN09";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";

        /// <summary>
        /// Q1UPMT.
        /// </summary>
        public const string Q1UPMT = "Q1UPMT";

        /// <summary>
        /// Q1JOBN.
        /// </summary>
        public const string Q1JOBN = "Q1JOBN";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1MATH01.
        /// </summary>
        public const string Q1MATH01 = "Q1MATH01";
    }

    /// <inheritdoc />
    public override string TableName => "F15L001W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1MCU", "Q1MCU", JdeDataType.String, 24, true, true),
        new JdeField("Q1SBL", "Q1SBL", JdeDataType.String, 16, true, true),
        new JdeField("Q1AN8", "Q1AN8", JdeDataType.Numeric),
        new JdeField("Q1ALPH", "Q1ALPH", JdeDataType.String, 80),
        new JdeField("Q1AN01", "Q1AN01", JdeDataType.Numeric),
        new JdeField("Q1AN02", "Q1AN02", JdeDataType.Numeric),
        new JdeField("Q1AN03", "Q1AN03", JdeDataType.Numeric),
        new JdeField("Q1AN04", "Q1AN04", JdeDataType.Numeric),
        new JdeField("Q1AN05", "Q1AN05", JdeDataType.Numeric),
        new JdeField("Q1AN06", "Q1AN06", JdeDataType.Numeric),
        new JdeField("Q1AN07", "Q1AN07", JdeDataType.Numeric),
        new JdeField("Q1AN08", "Q1AN08", JdeDataType.Numeric),
        new JdeField("Q1AN09", "Q1AN09", JdeDataType.Numeric),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20),
        new JdeField("Q1UPMT", "Q1UPMT", JdeDataType.Numeric),
        new JdeField("Q1JOBN", "Q1JOBN", JdeDataType.String, 20),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric),
        new JdeField("Q1MATH01", "Q1MATH01", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L001W_0", "Primary Key on Q1MCU, Q1SBL, Q1MATH01", new[] { "Q1MCU", "Q1SBL", "Q1MATH01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L001W_2", "Index on Q1MCU, Q1AN8", new[] { "Q1MCU", "Q1AN8" })
    };
}
