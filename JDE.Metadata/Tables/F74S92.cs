using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S92 - .
/// </summary>
public class F74S92 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q2SRTI.
        /// </summary>
        public const string Q2SRTI = "Q2SRTI";

        /// <summary>
        /// Q2SDTI.
        /// </summary>
        public const string Q2SDTI = "Q2SDTI";

        /// <summary>
        /// Q2SYEA.
        /// </summary>
        public const string Q2SYEA = "Q2SYEA";

        /// <summary>
        /// Q2SDPE.
        /// </summary>
        public const string Q2SDPE = "Q2SDPE";

        /// <summary>
        /// Q2STON.
        /// </summary>
        public const string Q2STON = "Q2STON";

        /// <summary>
        /// Q2STID.
        /// </summary>
        public const string Q2STID = "Q2STID";

        /// <summary>
        /// Q2SOPE.
        /// </summary>
        public const string Q2SOPE = "Q2SOPE";

        /// <summary>
        /// Q2SCCC.
        /// </summary>
        public const string Q2SCCC = "Q2SCCC";

        /// <summary>
        /// Q2SCTI.
        /// </summary>
        public const string Q2SCTI = "Q2SCTI";

        /// <summary>
        /// Q2SCNA.
        /// </summary>
        public const string Q2SCNA = "Q2SCNA";

        /// <summary>
        /// Q2STOA.
        /// </summary>
        public const string Q2STOA = "Q2STOA";

        /// <summary>
        /// Q2STCW.
        /// </summary>
        public const string Q2STCW = "Q2STCW";

        /// <summary>
        /// Q2SASG.
        /// </summary>
        public const string Q2SASG = "Q2SASG";

        /// <summary>
        /// Q2SRDY.
        /// </summary>
        public const string Q2SRDY = "Q2SRDY";

        /// <summary>
        /// Q2SRDP.
        /// </summary>
        public const string Q2SRDP = "Q2SRDP";

        /// <summary>
        /// Q2SF38.
        /// </summary>
        public const string Q2SF38 = "Q2SF38";

        /// <summary>
        /// Q2CO.
        /// </summary>
        public const string Q2CO = "Q2CO";

        /// <summary>
        /// Q2CRDC.
        /// </summary>
        public const string Q2CRDC = "Q2CRDC";

        /// <summary>
        /// Q2SAR2.
        /// </summary>
        public const string Q2SAR2 = "Q2SAR2";

        /// <summary>
        /// Q2SAR3.
        /// </summary>
        public const string Q2SAR3 = "Q2SAR3";
    }

    /// <inheritdoc />
    public override string TableName => "F74S92";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q2SRTI", "Q2SRTI", JdeDataType.Numeric),
        new JdeField("Q2SDTI", "Q2SDTI", JdeDataType.Numeric),
        new JdeField("Q2SYEA", "Q2SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2SDPE", "Q2SDPE", JdeDataType.String, 4, true, true),
        new JdeField("Q2STON", "Q2STON", JdeDataType.Numeric),
        new JdeField("Q2STID", "Q2STID", JdeDataType.String, 18, true, true),
        new JdeField("Q2SOPE", "Q2SOPE", JdeDataType.String, 2, true, true),
        new JdeField("Q2SCCC", "Q2SCCC", JdeDataType.String, 6, true, true),
        new JdeField("Q2SCTI", "Q2SCTI", JdeDataType.String, 24, true, true),
        new JdeField("Q2SCNA", "Q2SCNA", JdeDataType.String, 80),
        new JdeField("Q2STOA", "Q2STOA", JdeDataType.Numeric),
        new JdeField("Q2STCW", "Q2STCW", JdeDataType.String, 2),
        new JdeField("Q2SASG", "Q2SASG", JdeDataType.String, 2),
        new JdeField("Q2SRDY", "Q2SRDY", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2SRDP", "Q2SRDP", JdeDataType.String, 4, true, true),
        new JdeField("Q2SF38", "Q2SF38", JdeDataType.String, 76),
        new JdeField("Q2CO", "Q2CO", JdeDataType.String, 10),
        new JdeField("Q2CRDC", "Q2CRDC", JdeDataType.String, 6),
        new JdeField("Q2SAR2", "Q2SAR2", JdeDataType.Numeric),
        new JdeField("Q2SAR3", "Q2SAR3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S92_0", "Primary Key on Q2STID, Q2SYEA, Q2SDPE, Q2SCCC, Q2SCTI, Q2SOPE, Q2SRDY, Q2SRDP", new[] { "Q2STID", "Q2SYEA", "Q2SDPE", "Q2SCCC", "Q2SCTI", "Q2SOPE", "Q2SRDY", "Q2SRDP" }, isUnique: true, isPrimaryKey: true)
    };
}
