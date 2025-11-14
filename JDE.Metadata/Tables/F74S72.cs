using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S72 - .
/// </summary>
public class F74S72 : JdeTable
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
        /// Q2S74IDY.
        /// </summary>
        public const string Q2S74IDY = "Q2S74IDY";

        /// <summary>
        /// Q2STON.
        /// </summary>
        public const string Q2STON = "Q2STON";

        /// <summary>
        /// Q2STID.
        /// </summary>
        public const string Q2STID = "Q2STID";

        /// <summary>
        /// Q2SOTP.
        /// </summary>
        public const string Q2SOTP = "Q2SOTP";

        /// <summary>
        /// Q2SCVT.
        /// </summary>
        public const string Q2SCVT = "Q2SCVT";

        /// <summary>
        /// Q2SCNA.
        /// </summary>
        public const string Q2SCNA = "Q2SCNA";

        /// <summary>
        /// Q2SLRE.
        /// </summary>
        public const string Q2SLRE = "Q2SLRE";

        /// <summary>
        /// Q2SPRO.
        /// </summary>
        public const string Q2SPRO = "Q2SPRO";

        /// <summary>
        /// Q2SOTA.
        /// </summary>
        public const string Q2SOTA = "Q2SOTA";

        /// <summary>
        /// Q2SIOP.
        /// </summary>
        public const string Q2SIOP = "Q2SIOP";

        /// <summary>
        /// Q2SLOP.
        /// </summary>
        public const string Q2SLOP = "Q2SLOP";

        /// <summary>
        /// Q2SF88.
        /// </summary>
        public const string Q2SF88 = "Q2SF88";

        /// <summary>
        /// Q2SOT2.
        /// </summary>
        public const string Q2SOT2 = "Q2SOT2";

        /// <summary>
        /// Q2CO.
        /// </summary>
        public const string Q2CO = "Q2CO";

        /// <summary>
        /// Q2CRDC.
        /// </summary>
        public const string Q2CRDC = "Q2CRDC";

        /// <summary>
        /// Q2S74CAMR.
        /// </summary>
        public const string Q2S74CAMR = "Q2S74CAMR";

        /// <summary>
        /// Q2S74ARPV.
        /// </summary>
        public const string Q2S74ARPV = "Q2S74ARPV";

        /// <summary>
        /// Q2S74COCN.
        /// </summary>
        public const string Q2S74COCN = "Q2S74COCN";

        /// <summary>
        /// Q2S74SDVR.
        /// </summary>
        public const string Q2S74SDVR = "Q2S74SDVR";

        /// <summary>
        /// Q2S74RVCT.
        /// </summary>
        public const string Q2S74RVCT = "Q2S74RVCT";

        /// <summary>
        /// Q2S74GOTC.
        /// </summary>
        public const string Q2S74GOTC = "Q2S74GOTC";

        /// <summary>
        /// Q2S74YADV.
        /// </summary>
        public const string Q2S74YADV = "Q2S74YADV";
    }

    /// <inheritdoc />
    public override string TableName => "F74S72";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q2SRTI", "Q2SRTI", JdeDataType.Numeric),
        new JdeField("Q2SDTI", "Q2SDTI", JdeDataType.Numeric),
        new JdeField("Q2SYEA", "Q2SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2S74IDY", "Q2S74IDY", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2STON", "Q2STON", JdeDataType.Numeric),
        new JdeField("Q2STID", "Q2STID", JdeDataType.String, 18, true, true),
        new JdeField("Q2SOTP", "Q2SOTP", JdeDataType.String, 2, true, true),
        new JdeField("Q2SCVT", "Q2SCVT", JdeDataType.String, 18, true, true),
        new JdeField("Q2SCNA", "Q2SCNA", JdeDataType.String, 80),
        new JdeField("Q2SLRE", "Q2SLRE", JdeDataType.String, 2),
        new JdeField("Q2SPRO", "Q2SPRO", JdeDataType.Numeric),
        new JdeField("Q2SOTA", "Q2SOTA", JdeDataType.Numeric),
        new JdeField("Q2SIOP", "Q2SIOP", JdeDataType.String, 2, true, true),
        new JdeField("Q2SLOP", "Q2SLOP", JdeDataType.String, 2, true, true),
        new JdeField("Q2SF88", "Q2SF88", JdeDataType.String, 176),
        new JdeField("Q2SOT2", "Q2SOT2", JdeDataType.Numeric),
        new JdeField("Q2CO", "Q2CO", JdeDataType.String, 10),
        new JdeField("Q2CRDC", "Q2CRDC", JdeDataType.String, 6),
        new JdeField("Q2S74CAMR", "Q2S74CAMR", JdeDataType.Numeric),
        new JdeField("Q2S74ARPV", "Q2S74ARPV", JdeDataType.Numeric),
        new JdeField("Q2S74COCN", "Q2S74COCN", JdeDataType.String, 34, true, true),
        new JdeField("Q2S74SDVR", "Q2S74SDVR", JdeDataType.String, 2, true, true),
        new JdeField("Q2S74RVCT", "Q2S74RVCT", JdeDataType.String, 2, true, true),
        new JdeField("Q2S74GOTC", "Q2S74GOTC", JdeDataType.String, 2, true, true),
        new JdeField("Q2S74YADV", "Q2S74YADV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S72_0", "Primary Key on Q2SYEA, Q2STID, Q2SCVT, Q2S74COCN, Q2SOTP, Q2SIOP, Q2SLOP, Q2S74IDY, Q2S74SDVR, Q2S74RVCT, Q2S74GOTC", new[] { "Q2SYEA", "Q2STID", "Q2SCVT", "Q2S74COCN", "Q2SOTP", "Q2SIOP", "Q2SLOP", "Q2S74IDY", "Q2S74SDVR", "Q2S74RVCT", "Q2S74GOTC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S72_2", "Index on Q2SYEA, Q2SRTI, Q2STID", new[] { "Q2SYEA", "Q2SRTI", "Q2STID" })
    };
}
