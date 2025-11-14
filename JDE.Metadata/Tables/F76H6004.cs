using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6004 - .
/// </summary>
public class F76H6004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICH76LECO.
        /// </summary>
        public const string ICH76LECO = "ICH76LECO";

        /// <summary>
        /// ICCFY.
        /// </summary>
        public const string ICCFY = "ICCFY";

        /// <summary>
        /// ICFFP.
        /// </summary>
        public const string ICFFP = "ICFFP";

        /// <summary>
        /// ICITM.
        /// </summary>
        public const string ICITM = "ICITM";

        /// <summary>
        /// ICMMCU.
        /// </summary>
        public const string ICMMCU = "ICMMCU";

        /// <summary>
        /// ICLOCN.
        /// </summary>
        public const string ICLOCN = "ICLOCN";

        /// <summary>
        /// ICLOTN.
        /// </summary>
        public const string ICLOTN = "ICLOTN";

        /// <summary>
        /// ICLEDG.
        /// </summary>
        public const string ICLEDG = "ICLEDG";

        /// <summary>
        /// ICCOST.
        /// </summary>
        public const string ICCOST = "ICCOST";

        /// <summary>
        /// ICXSMC.
        /// </summary>
        public const string ICXSMC = "ICXSMC";

        /// <summary>
        /// ICXSCR.
        /// </summary>
        public const string ICXSCR = "ICXSCR";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICH76LECO", "ICH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("ICCFY", "ICCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ICFFP", "ICFFP", JdeDataType.Numeric, null, true, true),
        new JdeField("ICITM", "ICITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ICMMCU", "ICMMCU", JdeDataType.String, 24, true, true),
        new JdeField("ICLOCN", "ICLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ICLOTN", "ICLOTN", JdeDataType.String, 60, true, true),
        new JdeField("ICLEDG", "ICLEDG", JdeDataType.String, 4, true, true),
        new JdeField("ICCOST", "ICCOST", JdeDataType.String, 6, true, true),
        new JdeField("ICXSMC", "ICXSMC", JdeDataType.Numeric),
        new JdeField("ICXSCR", "ICXSCR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6004_0", "Primary Key on ICH76LECO, ICCFY, ICFFP, ICITM, ICMMCU, ICLOCN, ICLOTN, ICLEDG, ICCOST", new[] { "ICH76LECO", "ICCFY", "ICFFP", "ICITM", "ICMMCU", "ICLOCN", "ICLOTN", "ICLEDG", "ICCOST" }, isUnique: true, isPrimaryKey: true)
    };
}
