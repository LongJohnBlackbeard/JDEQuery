using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083202 - .
/// </summary>
public class F083202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B5PLAN.
        /// </summary>
        public const string B5PLAN = "B5PLAN";

        /// <summary>
        /// B5AOPT.
        /// </summary>
        public const string B5AOPT = "B5AOPT";

        /// <summary>
        /// B5DL01.
        /// </summary>
        public const string B5DL01 = "B5DL01";

        /// <summary>
        /// B5FDBA.
        /// </summary>
        public const string B5FDBA = "B5FDBA";

        /// <summary>
        /// B5EEAM.
        /// </summary>
        public const string B5EEAM = "B5EEAM";

        /// <summary>
        /// B5OPR1.
        /// </summary>
        public const string B5OPR1 = "B5OPR1";

        /// <summary>
        /// B5SDBA.
        /// </summary>
        public const string B5SDBA = "B5SDBA";

        /// <summary>
        /// B5ERAM.
        /// </summary>
        public const string B5ERAM = "B5ERAM";

        /// <summary>
        /// B5OPR2.
        /// </summary>
        public const string B5OPR2 = "B5OPR2";

        /// <summary>
        /// B5PDDP.
        /// </summary>
        public const string B5PDDP = "B5PDDP";

        /// <summary>
        /// B5EEPT.
        /// </summary>
        public const string B5EEPT = "B5EEPT";

        /// <summary>
        /// B5OPR3.
        /// </summary>
        public const string B5OPR3 = "B5OPR3";

        /// <summary>
        /// B5PDCP.
        /// </summary>
        public const string B5PDCP = "B5PDCP";

        /// <summary>
        /// B5ERPT.
        /// </summary>
        public const string B5ERPT = "B5ERPT";

        /// <summary>
        /// B5OPR4.
        /// </summary>
        public const string B5OPR4 = "B5OPR4";

        /// <summary>
        /// B5OPTD.
        /// </summary>
        public const string B5OPTD = "B5OPTD";

        /// <summary>
        /// B5OPTF.
        /// </summary>
        public const string B5OPTF = "B5OPTF";

        /// <summary>
        /// B5BENF.
        /// </summary>
        public const string B5BENF = "B5BENF";

        /// <summary>
        /// B5PREP.
        /// </summary>
        public const string B5PREP = "B5PREP";
    }

    /// <inheritdoc />
    public override string TableName => "F083202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B5PLAN", "B5PLAN", JdeDataType.String, 16, true, true),
        new JdeField("B5AOPT", "B5AOPT", JdeDataType.String, 6, true, true),
        new JdeField("B5DL01", "B5DL01", JdeDataType.String, 60),
        new JdeField("B5FDBA", "B5FDBA", JdeDataType.Numeric),
        new JdeField("B5EEAM", "B5EEAM", JdeDataType.Numeric),
        new JdeField("B5OPR1", "B5OPR1", JdeDataType.String, 2),
        new JdeField("B5SDBA", "B5SDBA", JdeDataType.Numeric),
        new JdeField("B5ERAM", "B5ERAM", JdeDataType.Numeric),
        new JdeField("B5OPR2", "B5OPR2", JdeDataType.String, 2),
        new JdeField("B5PDDP", "B5PDDP", JdeDataType.Numeric),
        new JdeField("B5EEPT", "B5EEPT", JdeDataType.Numeric),
        new JdeField("B5OPR3", "B5OPR3", JdeDataType.String, 2),
        new JdeField("B5PDCP", "B5PDCP", JdeDataType.Numeric),
        new JdeField("B5ERPT", "B5ERPT", JdeDataType.Numeric),
        new JdeField("B5OPR4", "B5OPR4", JdeDataType.String, 2),
        new JdeField("B5OPTD", "B5OPTD", JdeDataType.String, 2),
        new JdeField("B5OPTF", "B5OPTF", JdeDataType.String, 2),
        new JdeField("B5BENF", "B5BENF", JdeDataType.String, 2),
        new JdeField("B5PREP", "B5PREP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083202_0", "Primary Key on B5PLAN, B5AOPT", new[] { "B5PLAN", "B5AOPT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F083202_2", "Index on B5PLAN, B5OPTF", new[] { "B5PLAN", "B5OPTF" })
    };
}
