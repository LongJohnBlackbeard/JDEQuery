using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S71 - .
/// </summary>
public class F74S71 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1SRTI.
        /// </summary>
        public const string Q1SRTI = "Q1SRTI";

        /// <summary>
        /// Q1SDTI.
        /// </summary>
        public const string Q1SDTI = "Q1SDTI";

        /// <summary>
        /// Q1SYEA.
        /// </summary>
        public const string Q1SYEA = "Q1SYEA";

        /// <summary>
        /// Q1STON.
        /// </summary>
        public const string Q1STON = "Q1STON";

        /// <summary>
        /// Q1STID.
        /// </summary>
        public const string Q1STID = "Q1STID";

        /// <summary>
        /// Q1SCNA.
        /// </summary>
        public const string Q1SCNA = "Q1SCNA";

        /// <summary>
        /// Q1SRTA.
        /// </summary>
        public const string Q1SRTA = "Q1SRTA";

        /// <summary>
        /// Q1SARA.
        /// </summary>
        public const string Q1SARA = "Q1SARA";

        /// <summary>
        /// Q1SRTB.
        /// </summary>
        public const string Q1SRTB = "Q1SRTB";

        /// <summary>
        /// Q1SARB.
        /// </summary>
        public const string Q1SARB = "Q1SARB";

        /// <summary>
        /// Q1SRTC.
        /// </summary>
        public const string Q1SRTC = "Q1SRTC";

        /// <summary>
        /// Q1SATC.
        /// </summary>
        public const string Q1SATC = "Q1SATC";

        /// <summary>
        /// Q1SRTD.
        /// </summary>
        public const string Q1SRTD = "Q1SRTD";

        /// <summary>
        /// Q1SARD.
        /// </summary>
        public const string Q1SARD = "Q1SARD";

        /// <summary>
        /// Q1SRTE.
        /// </summary>
        public const string Q1SRTE = "Q1SRTE";

        /// <summary>
        /// Q1SARE.
        /// </summary>
        public const string Q1SARE = "Q1SARE";

        /// <summary>
        /// Q1SFI1.
        /// </summary>
        public const string Q1SFI1 = "Q1SFI1";

        /// <summary>
        /// Q1SAR2.
        /// </summary>
        public const string Q1SAR2 = "Q1SAR2";

        /// <summary>
        /// Q1SAR3.
        /// </summary>
        public const string Q1SAR3 = "Q1SAR3";

        /// <summary>
        /// Q1SAT2.
        /// </summary>
        public const string Q1SAT2 = "Q1SAT2";

        /// <summary>
        /// Q1SAR4.
        /// </summary>
        public const string Q1SAR4 = "Q1SAR4";

        /// <summary>
        /// Q1SAR5.
        /// </summary>
        public const string Q1SAR5 = "Q1SAR5";

        /// <summary>
        /// Q1CO.
        /// </summary>
        public const string Q1CO = "Q1CO";

        /// <summary>
        /// Q1CRDC.
        /// </summary>
        public const string Q1CRDC = "Q1CRDC";
    }

    /// <inheritdoc />
    public override string TableName => "F74S71";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1SRTI", "Q1SRTI", JdeDataType.Numeric),
        new JdeField("Q1SDTI", "Q1SDTI", JdeDataType.Numeric),
        new JdeField("Q1SYEA", "Q1SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1STON", "Q1STON", JdeDataType.Numeric),
        new JdeField("Q1STID", "Q1STID", JdeDataType.String, 18, true, true),
        new JdeField("Q1SCNA", "Q1SCNA", JdeDataType.String, 80),
        new JdeField("Q1SRTA", "Q1SRTA", JdeDataType.Numeric),
        new JdeField("Q1SARA", "Q1SARA", JdeDataType.Numeric),
        new JdeField("Q1SRTB", "Q1SRTB", JdeDataType.Numeric),
        new JdeField("Q1SARB", "Q1SARB", JdeDataType.Numeric),
        new JdeField("Q1SRTC", "Q1SRTC", JdeDataType.Numeric),
        new JdeField("Q1SATC", "Q1SATC", JdeDataType.Numeric),
        new JdeField("Q1SRTD", "Q1SRTD", JdeDataType.Numeric),
        new JdeField("Q1SARD", "Q1SARD", JdeDataType.Numeric),
        new JdeField("Q1SRTE", "Q1SRTE", JdeDataType.Numeric),
        new JdeField("Q1SARE", "Q1SARE", JdeDataType.Numeric),
        new JdeField("Q1SFI1", "Q1SFI1", JdeDataType.String, 2),
        new JdeField("Q1SAR2", "Q1SAR2", JdeDataType.Numeric),
        new JdeField("Q1SAR3", "Q1SAR3", JdeDataType.Numeric),
        new JdeField("Q1SAT2", "Q1SAT2", JdeDataType.Numeric),
        new JdeField("Q1SAR4", "Q1SAR4", JdeDataType.Numeric),
        new JdeField("Q1SAR5", "Q1SAR5", JdeDataType.Numeric),
        new JdeField("Q1CO", "Q1CO", JdeDataType.String, 10),
        new JdeField("Q1CRDC", "Q1CRDC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S71_0", "Primary Key on Q1STID, Q1SYEA", new[] { "Q1STID", "Q1SYEA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S71_2", "Index on Q1SYEA, Q1SRTI, Q1STID", new[] { "Q1SYEA", "Q1SRTI", "Q1STID" })
    };
}
