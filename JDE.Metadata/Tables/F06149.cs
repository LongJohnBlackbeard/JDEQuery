using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06149 - .
/// </summary>
public class F06149 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y7AN8.
        /// </summary>
        public const string Y7AN8 = "Y7AN8";

        /// <summary>
        /// Y7PDBA.
        /// </summary>
        public const string Y7PDBA = "Y7PDBA";

        /// <summary>
        /// Y7DTE.
        /// </summary>
        public const string Y7DTE = "Y7DTE";

        /// <summary>
        /// Y7TAXX.
        /// </summary>
        public const string Y7TAXX = "Y7TAXX";

        /// <summary>
        /// Y7HMCO.
        /// </summary>
        public const string Y7HMCO = "Y7HMCO";

        /// <summary>
        /// Y7BWPY.
        /// </summary>
        public const string Y7BWPY = "Y7BWPY";

        /// <summary>
        /// Y7BWBB.
        /// </summary>
        public const string Y7BWBB = "Y7BWBB";

        /// <summary>
        /// Y7FY$.
        /// </summary>
        public const string Y7FY_ = "Y7FY$";

        /// <summary>
        /// Y7BHPY.
        /// </summary>
        public const string Y7BHPY = "Y7BHPY";

        /// <summary>
        /// Y7BHBB.
        /// </summary>
        public const string Y7BHBB = "Y7BHBB";

        /// <summary>
        /// Y7FYH.
        /// </summary>
        public const string Y7FYH = "Y7FYH";

        /// <summary>
        /// Y7BIPY.
        /// </summary>
        public const string Y7BIPY = "Y7BIPY";

        /// <summary>
        /// Y7BIBB.
        /// </summary>
        public const string Y7BIBB = "Y7BIBB";

        /// <summary>
        /// Y7FYP.
        /// </summary>
        public const string Y7FYP = "Y7FYP";
    }

    /// <inheritdoc />
    public override string TableName => "F06149";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y7AN8", "Y7AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y7PDBA", "Y7PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y7DTE", "Y7DTE", JdeDataType.Numeric, null, true, true),
        new JdeField("Y7TAXX", "Y7TAXX", JdeDataType.String, 40, true, true),
        new JdeField("Y7HMCO", "Y7HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y7BWPY", "Y7BWPY", JdeDataType.Numeric),
        new JdeField("Y7BWBB", "Y7BWBB", JdeDataType.Numeric),
        new JdeField("Y7FY$", "Y7FY$", JdeDataType.Numeric),
        new JdeField("Y7BHPY", "Y7BHPY", JdeDataType.Numeric),
        new JdeField("Y7BHBB", "Y7BHBB", JdeDataType.Numeric),
        new JdeField("Y7FYH", "Y7FYH", JdeDataType.Numeric),
        new JdeField("Y7BIPY", "Y7BIPY", JdeDataType.Numeric),
        new JdeField("Y7BIBB", "Y7BIBB", JdeDataType.Numeric),
        new JdeField("Y7FYP", "Y7FYP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06149_0", "Primary Key on Y7AN8, Y7PDBA, Y7DTE, Y7TAXX, Y7HMCO", new[] { "Y7AN8", "Y7PDBA", "Y7DTE", "Y7TAXX", "Y7HMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
