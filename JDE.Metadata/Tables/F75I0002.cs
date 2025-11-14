using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I0002 - .
/// </summary>
public class F75I0002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1KCO.
        /// </summary>
        public const string Q1KCO = "Q1KCO";

        /// <summary>
        /// Q1DCT.
        /// </summary>
        public const string Q1DCT = "Q1DCT";

        /// <summary>
        /// Q1DOC.
        /// </summary>
        public const string Q1DOC = "Q1DOC";

        /// <summary>
        /// Q1IVD.
        /// </summary>
        public const string Q1IVD = "Q1IVD";

        /// <summary>
        /// Q1MOT.
        /// </summary>
        public const string Q1MOT = "Q1MOT";

        /// <summary>
        /// Q1VEHI.
        /// </summary>
        public const string Q1VEHI = "Q1VEHI";

        /// <summary>
        /// Q1DL01.
        /// </summary>
        public const string Q1DL01 = "Q1DL01";

        /// <summary>
        /// Q1RSDJ.
        /// </summary>
        public const string Q1RSDJ = "Q1RSDJ";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1UPMT.
        /// </summary>
        public const string Q1UPMT = "Q1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I0002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1KCO", "Q1KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q1DCT", "Q1DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q1DOC", "Q1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1IVD", "Q1IVD", JdeDataType.Numeric),
        new JdeField("Q1MOT", "Q1MOT", JdeDataType.String, 6),
        new JdeField("Q1VEHI", "Q1VEHI", JdeDataType.String, 24),
        new JdeField("Q1DL01", "Q1DL01", JdeDataType.String, 60),
        new JdeField("Q1RSDJ", "Q1RSDJ", JdeDataType.Numeric),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric),
        new JdeField("Q1UPMT", "Q1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I0002_0", "Primary Key on Q1KCO, Q1DCT, Q1DOC", new[] { "Q1KCO", "Q1DCT", "Q1DOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I0002_2", "Index on SYS_NC00013$, SYS_NC00014$", new[] { "SYS_NC00013$", "SYS_NC00014$" }),
        new JdeIndex("F75I0002_3", "Index on Q1IVD", new[] { "Q1IVD" })
    };
}
