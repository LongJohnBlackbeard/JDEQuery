using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S91 - .
/// </summary>
public class F74S91 : JdeTable
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
        /// Q1SDPE.
        /// </summary>
        public const string Q1SDPE = "Q1SDPE";

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
        /// Q1SA91.
        /// </summary>
        public const string Q1SA91 = "Q1SA91";

        /// <summary>
        /// Q1SRTB.
        /// </summary>
        public const string Q1SRTB = "Q1SRTB";

        /// <summary>
        /// Q1SA92.
        /// </summary>
        public const string Q1SA92 = "Q1SA92";

        /// <summary>
        /// Q1SRTC.
        /// </summary>
        public const string Q1SRTC = "Q1SRTC";

        /// <summary>
        /// Q1SSTY.
        /// </summary>
        public const string Q1SSTY = "Q1SSTY";

        /// <summary>
        /// Q1SACO.
        /// </summary>
        public const string Q1SACO = "Q1SACO";

        /// <summary>
        /// Q1SPNU.
        /// </summary>
        public const string Q1SPNU = "Q1SPNU";

        /// <summary>
        /// Q1DS40.
        /// </summary>
        public const string Q1DS40 = "Q1DS40";

        /// <summary>
        /// Q1SDNU.
        /// </summary>
        public const string Q1SDNU = "Q1SDNU";

        /// <summary>
        /// Q1SFL2.
        /// </summary>
        public const string Q1SFL2 = "Q1SFL2";

        /// <summary>
        /// Q1SCVT.
        /// </summary>
        public const string Q1SCVT = "Q1SCVT";

        /// <summary>
        /// Q1CO.
        /// </summary>
        public const string Q1CO = "Q1CO";

        /// <summary>
        /// Q1CRDC.
        /// </summary>
        public const string Q1CRDC = "Q1CRDC";

        /// <summary>
        /// Q1GFL1.
        /// </summary>
        public const string Q1GFL1 = "Q1GFL1";

        /// <summary>
        /// Q1SPDN.
        /// </summary>
        public const string Q1SPDN = "Q1SPDN";
    }

    /// <inheritdoc />
    public override string TableName => "F74S91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1SRTI", "Q1SRTI", JdeDataType.Numeric),
        new JdeField("Q1SDTI", "Q1SDTI", JdeDataType.Numeric),
        new JdeField("Q1SYEA", "Q1SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1SDPE", "Q1SDPE", JdeDataType.String, 4, true, true),
        new JdeField("Q1STON", "Q1STON", JdeDataType.Numeric),
        new JdeField("Q1STID", "Q1STID", JdeDataType.String, 18, true, true),
        new JdeField("Q1SCNA", "Q1SCNA", JdeDataType.String, 80),
        new JdeField("Q1SRTA", "Q1SRTA", JdeDataType.Numeric),
        new JdeField("Q1SA91", "Q1SA91", JdeDataType.Numeric),
        new JdeField("Q1SRTB", "Q1SRTB", JdeDataType.Numeric),
        new JdeField("Q1SA92", "Q1SA92", JdeDataType.Numeric),
        new JdeField("Q1SRTC", "Q1SRTC", JdeDataType.Numeric),
        new JdeField("Q1SSTY", "Q1SSTY", JdeDataType.String, 2),
        new JdeField("Q1SACO", "Q1SACO", JdeDataType.String, 6),
        new JdeField("Q1SPNU", "Q1SPNU", JdeDataType.String, 14),
        new JdeField("Q1DS40", "Q1DS40", JdeDataType.String, 80),
        new JdeField("Q1SDNU", "Q1SDNU", JdeDataType.Numeric),
        new JdeField("Q1SFL2", "Q1SFL2", JdeDataType.String, 4),
        new JdeField("Q1SCVT", "Q1SCVT", JdeDataType.String, 18, true, true),
        new JdeField("Q1CO", "Q1CO", JdeDataType.String, 10),
        new JdeField("Q1CRDC", "Q1CRDC", JdeDataType.String, 6),
        new JdeField("Q1GFL1", "Q1GFL1", JdeDataType.String, 2),
        new JdeField("Q1SPDN", "Q1SPDN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S91_0", "Primary Key on Q1STID, Q1SYEA, Q1SDPE, Q1SCVT", new[] { "Q1STID", "Q1SYEA", "Q1SDPE", "Q1SCVT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S91_2", "Index on Q1SCVT, Q1SYEA, Q1SDPE", new[] { "Q1SCVT", "Q1SYEA", "Q1SDPE" })
    };
}
