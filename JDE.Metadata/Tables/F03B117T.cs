using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B117T - .
/// </summary>
public class F03B117T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLKCO.
        /// </summary>
        public const string RLKCO = "RLKCO";

        /// <summary>
        /// RLDOC.
        /// </summary>
        public const string RLDOC = "RLDOC";

        /// <summary>
        /// RLDCT.
        /// </summary>
        public const string RLDCT = "RLDCT";

        /// <summary>
        /// RLAA.
        /// </summary>
        public const string RLAA = "RLAA";

        /// <summary>
        /// RLDGJ.
        /// </summary>
        public const string RLDGJ = "RLDGJ";

        /// <summary>
        /// RLAN8.
        /// </summary>
        public const string RLAN8 = "RLAN8";

        /// <summary>
        /// RLIVD.
        /// </summary>
        public const string RLIVD = "RLIVD";

        /// <summary>
        /// RLUKID.
        /// </summary>
        public const string RLUKID = "RLUKID";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLANI.
        /// </summary>
        public const string RLANI = "RLANI";

        /// <summary>
        /// RLOJELN.
        /// </summary>
        public const string RLOJELN = "RLOJELN";

        /// <summary>
        /// RLODGJ.
        /// </summary>
        public const string RLODGJ = "RLODGJ";

        /// <summary>
        /// RLOEXTL.
        /// </summary>
        public const string RLOEXTL = "RLOEXTL";

        /// <summary>
        /// RLJELN.
        /// </summary>
        public const string RLJELN = "RLJELN";

        /// <summary>
        /// RLEXTL.
        /// </summary>
        public const string RLEXTL = "RLEXTL";

        /// <summary>
        /// RLCFAMT1.
        /// </summary>
        public const string RLCFAMT1 = "RLCFAMT1";

        /// <summary>
        /// RLCFAMT2.
        /// </summary>
        public const string RLCFAMT2 = "RLCFAMT2";
    }

    /// <inheritdoc />
    public override string TableName => "F03B117T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLKCO", "RLKCO", JdeDataType.String, 10, true, true),
        new JdeField("RLDOC", "RLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RLDCT", "RLDCT", JdeDataType.String, 4, true, true),
        new JdeField("RLAA", "RLAA", JdeDataType.Numeric),
        new JdeField("RLDGJ", "RLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RLAN8", "RLAN8", JdeDataType.Numeric),
        new JdeField("RLIVD", "RLIVD", JdeDataType.Numeric),
        new JdeField("RLUKID", "RLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20, true, true),
        new JdeField("RLANI", "RLANI", JdeDataType.String, 58, true, true),
        new JdeField("RLOJELN", "RLOJELN", JdeDataType.Numeric),
        new JdeField("RLODGJ", "RLODGJ", JdeDataType.Numeric),
        new JdeField("RLOEXTL", "RLOEXTL", JdeDataType.String, 4),
        new JdeField("RLJELN", "RLJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RLEXTL", "RLEXTL", JdeDataType.String, 4, true, true),
        new JdeField("RLCFAMT1", "RLCFAMT1", JdeDataType.Numeric),
        new JdeField("RLCFAMT2", "RLCFAMT2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B117T_0", "Primary Key on RLKCO, RLDOC, RLDCT, RLUKID, RLUSER, RLANI, RLDGJ, RLJELN, RLEXTL", new[] { "RLKCO", "RLDOC", "RLDCT", "RLUKID", "RLUSER", "RLANI", "RLDGJ", "RLJELN", "RLEXTL" }, isUnique: true, isPrimaryKey: true)
    };
}
