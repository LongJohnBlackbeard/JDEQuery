using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S73 - .
/// </summary>
public class F74S73 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q3SRTI.
        /// </summary>
        public const string Q3SRTI = "Q3SRTI";

        /// <summary>
        /// Q3SDTI.
        /// </summary>
        public const string Q3SDTI = "Q3SDTI";

        /// <summary>
        /// Q3SYEA.
        /// </summary>
        public const string Q3SYEA = "Q3SYEA";

        /// <summary>
        /// Q3STON.
        /// </summary>
        public const string Q3STON = "Q3STON";

        /// <summary>
        /// Q3STID.
        /// </summary>
        public const string Q3STID = "Q3STID";

        /// <summary>
        /// Q3SCVT.
        /// </summary>
        public const string Q3SCVT = "Q3SCVT";

        /// <summary>
        /// Q3SCNA.
        /// </summary>
        public const string Q3SCNA = "Q3SCNA";

        /// <summary>
        /// Q3SLTA.
        /// </summary>
        public const string Q3SLTA = "Q3SLTA";

        /// <summary>
        /// Q3SZCO.
        /// </summary>
        public const string Q3SZCO = "Q3SZCO";

        /// <summary>
        /// Q3SPCO.
        /// </summary>
        public const string Q3SPCO = "Q3SPCO";

        /// <summary>
        /// Q3SGRE.
        /// </summary>
        public const string Q3SGRE = "Q3SGRE";

        /// <summary>
        /// Q3SAAB.
        /// </summary>
        public const string Q3SAAB = "Q3SAAB";

        /// <summary>
        /// Q3SCSA.
        /// </summary>
        public const string Q3SCSA = "Q3SCSA";

        /// <summary>
        /// Q3SFAN.
        /// </summary>
        public const string Q3SFAN = "Q3SFAN";

        /// <summary>
        /// Q3SSTA.
        /// </summary>
        public const string Q3SSTA = "Q3SSTA";

        /// <summary>
        /// Q3SFLO.
        /// </summary>
        public const string Q3SFLO = "Q3SFLO";

        /// <summary>
        /// Q3SDOO.
        /// </summary>
        public const string Q3SDOO = "Q3SDOO";

        /// <summary>
        /// Q3SFL5.
        /// </summary>
        public const string Q3SFL5 = "Q3SFL5";

        /// <summary>
        /// Q3SLT2.
        /// </summary>
        public const string Q3SLT2 = "Q3SLT2";

        /// <summary>
        /// Q3CO.
        /// </summary>
        public const string Q3CO = "Q3CO";

        /// <summary>
        /// Q3CRDC.
        /// </summary>
        public const string Q3CRDC = "Q3CRDC";

        /// <summary>
        /// Q3S74BLCK.
        /// </summary>
        public const string Q3S74BLCK = "Q3S74BLCK";

        /// <summary>
        /// Q3S74CMLT.
        /// </summary>
        public const string Q3S74CMLT = "Q3S74CMLT";

        /// <summary>
        /// Q3S74LCPY.
        /// </summary>
        public const string Q3S74LCPY = "Q3S74LCPY";

        /// <summary>
        /// Q3S74LCTY.
        /// </summary>
        public const string Q3S74LCTY = "Q3S74LCTY";

        /// <summary>
        /// Q3S74MNCD.
        /// </summary>
        public const string Q3S74MNCD = "Q3S74MNCD";

        /// <summary>
        /// Q3S74NMQL.
        /// </summary>
        public const string Q3S74NMQL = "Q3S74NMQL";

        /// <summary>
        /// Q3S74NMTY.
        /// </summary>
        public const string Q3S74NMTY = "Q3S74NMTY";

        /// <summary>
        /// Q3S74PRTL.
        /// </summary>
        public const string Q3S74PRTL = "Q3S74PRTL";

        /// <summary>
        /// Q3S74STTY.
        /// </summary>
        public const string Q3S74STTY = "Q3S74STTY";
    }

    /// <inheritdoc />
    public override string TableName => "F74S73";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3SRTI", "Q3SRTI", JdeDataType.Numeric),
        new JdeField("Q3SDTI", "Q3SDTI", JdeDataType.Numeric),
        new JdeField("Q3SYEA", "Q3SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3STON", "Q3STON", JdeDataType.Numeric),
        new JdeField("Q3STID", "Q3STID", JdeDataType.String, 18, true, true),
        new JdeField("Q3SCVT", "Q3SCVT", JdeDataType.String, 18, true, true),
        new JdeField("Q3SCNA", "Q3SCNA", JdeDataType.String, 80),
        new JdeField("Q3SLTA", "Q3SLTA", JdeDataType.Numeric),
        new JdeField("Q3SZCO", "Q3SZCO", JdeDataType.Numeric),
        new JdeField("Q3SPCO", "Q3SPCO", JdeDataType.String, 48),
        new JdeField("Q3SGRE", "Q3SGRE", JdeDataType.String, 50, true, true),
        new JdeField("Q3SAAB", "Q3SAAB", JdeDataType.String, 4),
        new JdeField("Q3SCSA", "Q3SCSA", JdeDataType.String, 50),
        new JdeField("Q3SFAN", "Q3SFAN", JdeDataType.Numeric),
        new JdeField("Q3SSTA", "Q3SSTA", JdeDataType.String, 4),
        new JdeField("Q3SFLO", "Q3SFLO", JdeDataType.String, 4),
        new JdeField("Q3SDOO", "Q3SDOO", JdeDataType.String, 4),
        new JdeField("Q3SFL5", "Q3SFL5", JdeDataType.String, 10),
        new JdeField("Q3SLT2", "Q3SLT2", JdeDataType.Numeric),
        new JdeField("Q3CO", "Q3CO", JdeDataType.String, 10),
        new JdeField("Q3CRDC", "Q3CRDC", JdeDataType.String, 6),
        new JdeField("Q3S74BLCK", "Q3S74BLCK", JdeDataType.String, 6),
        new JdeField("Q3S74CMLT", "Q3S74CMLT", JdeDataType.String, 80),
        new JdeField("Q3S74LCPY", "Q3S74LCPY", JdeDataType.String, 2),
        new JdeField("Q3S74LCTY", "Q3S74LCTY", JdeDataType.String, 60),
        new JdeField("Q3S74MNCD", "Q3S74MNCD", JdeDataType.String, 10),
        new JdeField("Q3S74NMQL", "Q3S74NMQL", JdeDataType.String, 6),
        new JdeField("Q3S74NMTY", "Q3S74NMTY", JdeDataType.String, 6),
        new JdeField("Q3S74PRTL", "Q3S74PRTL", JdeDataType.String, 6),
        new JdeField("Q3S74STTY", "Q3S74STTY", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S73_0", "Primary Key on Q3STID, Q3SYEA, Q3SCVT, Q3SGRE", new[] { "Q3STID", "Q3SYEA", "Q3SCVT", "Q3SGRE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S73_2", "Index on Q3SYEA, Q3SRTI, Q3STID", new[] { "Q3SYEA", "Q3SRTI", "Q3STID" }),
        new JdeIndex("F74S73_3", "Index on Q3SYEA, Q3STID, Q3SCVT", new[] { "Q3SYEA", "Q3STID", "Q3SCVT" })
    };
}
