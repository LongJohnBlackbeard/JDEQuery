using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S78 - .
/// </summary>
public class F74S78 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAN8.
        /// </summary>
        public const string ATAN8 = "ATAN8";

        /// <summary>
        /// ATS74BLCK.
        /// </summary>
        public const string ATS74BLCK = "ATS74BLCK";

        /// <summary>
        /// ATS74CMLT.
        /// </summary>
        public const string ATS74CMLT = "ATS74CMLT";

        /// <summary>
        /// ATS74LCTY.
        /// </summary>
        public const string ATS74LCTY = "ATS74LCTY";

        /// <summary>
        /// ATS74MNCD.
        /// </summary>
        public const string ATS74MNCD = "ATS74MNCD";

        /// <summary>
        /// ATS74NMTY.
        /// </summary>
        public const string ATS74NMTY = "ATS74NMTY";

        /// <summary>
        /// ATS74NMQL.
        /// </summary>
        public const string ATS74NMQL = "ATS74NMQL";

        /// <summary>
        /// ATS74PRTL.
        /// </summary>
        public const string ATS74PRTL = "ATS74PRTL";

        /// <summary>
        /// ATS74STTY.
        /// </summary>
        public const string ATS74STTY = "ATS74STTY";
    }

    /// <inheritdoc />
    public override string TableName => "F74S78";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAN8", "ATAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ATS74BLCK", "ATS74BLCK", JdeDataType.String, 6),
        new JdeField("ATS74CMLT", "ATS74CMLT", JdeDataType.String, 80),
        new JdeField("ATS74LCTY", "ATS74LCTY", JdeDataType.String, 60),
        new JdeField("ATS74MNCD", "ATS74MNCD", JdeDataType.String, 10),
        new JdeField("ATS74NMTY", "ATS74NMTY", JdeDataType.String, 6),
        new JdeField("ATS74NMQL", "ATS74NMQL", JdeDataType.String, 6),
        new JdeField("ATS74PRTL", "ATS74PRTL", JdeDataType.String, 6),
        new JdeField("ATS74STTY", "ATS74STTY", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S78_0", "Primary Key on ATAN8", new[] { "ATAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
