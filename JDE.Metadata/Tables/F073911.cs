using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F073911 - .
/// </summary>
public class F073911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y8PAYD.
        /// </summary>
        public const string Y8PAYD = "Y8PAYD";

        /// <summary>
        /// Y8AN8.
        /// </summary>
        public const string Y8AN8 = "Y8AN8";

        /// <summary>
        /// Y8HMCO.
        /// </summary>
        public const string Y8HMCO = "Y8HMCO";

        /// <summary>
        /// Y8DTE.
        /// </summary>
        public const string Y8DTE = "Y8DTE";

        /// <summary>
        /// Y8PDBA.
        /// </summary>
        public const string Y8PDBA = "Y8PDBA";

        /// <summary>
        /// Y8AA12.
        /// </summary>
        public const string Y8AA12 = "Y8AA12";

        /// <summary>
        /// Y8BHBB.
        /// </summary>
        public const string Y8BHBB = "Y8BHBB";

        /// <summary>
        /// Y8BWBB.
        /// </summary>
        public const string Y8BWBB = "Y8BWBB";

        /// <summary>
        /// Y8FYH.
        /// </summary>
        public const string Y8FYH = "Y8FYH";

        /// <summary>
        /// Y8FY$.
        /// </summary>
        public const string Y8FY_ = "Y8FY$";

        /// <summary>
        /// Y8PPYF.
        /// </summary>
        public const string Y8PPYF = "Y8PPYF";

        /// <summary>
        /// Y8BH01.
        /// </summary>
        public const string Y8BH01 = "Y8BH01";

        /// <summary>
        /// Y8BW01.
        /// </summary>
        public const string Y8BW01 = "Y8BW01";

        /// <summary>
        /// Y8PPYT.
        /// </summary>
        public const string Y8PPYT = "Y8PPYT";

        /// <summary>
        /// Y8BH02.
        /// </summary>
        public const string Y8BH02 = "Y8BH02";

        /// <summary>
        /// Y8BW02.
        /// </summary>
        public const string Y8BW02 = "Y8BW02";

        /// <summary>
        /// Y8URNUM09.
        /// </summary>
        public const string Y8URNUM09 = "Y8URNUM09";
    }

    /// <inheritdoc />
    public override string TableName => "F073911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y8PAYD", "Y8PAYD", JdeDataType.String, 20, true, true),
        new JdeField("Y8AN8", "Y8AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8HMCO", "Y8HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y8DTE", "Y8DTE", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8PDBA", "Y8PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8AA12", "Y8AA12", JdeDataType.String, 24),
        new JdeField("Y8BHBB", "Y8BHBB", JdeDataType.Numeric),
        new JdeField("Y8BWBB", "Y8BWBB", JdeDataType.Numeric),
        new JdeField("Y8FYH", "Y8FYH", JdeDataType.Numeric),
        new JdeField("Y8FY$", "Y8FY$", JdeDataType.Numeric),
        new JdeField("Y8PPYF", "Y8PPYF", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8BH01", "Y8BH01", JdeDataType.Numeric),
        new JdeField("Y8BW01", "Y8BW01", JdeDataType.Numeric),
        new JdeField("Y8PPYT", "Y8PPYT", JdeDataType.Numeric),
        new JdeField("Y8BH02", "Y8BH02", JdeDataType.Numeric),
        new JdeField("Y8BW02", "Y8BW02", JdeDataType.Numeric),
        new JdeField("Y8URNUM09", "Y8URNUM09", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F073911_0", "Primary Key on Y8PAYD, Y8AN8, Y8DTE, Y8PDBA, Y8PPYF, Y8HMCO", new[] { "Y8PAYD", "Y8AN8", "Y8DTE", "Y8PDBA", "Y8PPYF", "Y8HMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
