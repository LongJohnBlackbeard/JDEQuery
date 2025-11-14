using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07149 - .
/// </summary>
public class F07149 : JdeTable
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
        /// Y8PDBA.
        /// </summary>
        public const string Y8PDBA = "Y8PDBA";

        /// <summary>
        /// Y8TAXX.
        /// </summary>
        public const string Y8TAXX = "Y8TAXX";

        /// <summary>
        /// Y8HMCO.
        /// </summary>
        public const string Y8HMCO = "Y8HMCO";

        /// <summary>
        /// Y8ANNIVDT.
        /// </summary>
        public const string Y8ANNIVDT = "Y8ANNIVDT";

        /// <summary>
        /// Y8RECC.
        /// </summary>
        public const string Y8RECC = "Y8RECC";

        /// <summary>
        /// Y8BWPY.
        /// </summary>
        public const string Y8BWPY = "Y8BWPY";

        /// <summary>
        /// Y8BWBB.
        /// </summary>
        public const string Y8BWBB = "Y8BWBB";

        /// <summary>
        /// Y8FY$.
        /// </summary>
        public const string Y8FY_ = "Y8FY$";

        /// <summary>
        /// Y8BHPY.
        /// </summary>
        public const string Y8BHPY = "Y8BHPY";

        /// <summary>
        /// Y8BHBB.
        /// </summary>
        public const string Y8BHBB = "Y8BHBB";

        /// <summary>
        /// Y8FYH.
        /// </summary>
        public const string Y8FYH = "Y8FYH";

        /// <summary>
        /// Y8USER.
        /// </summary>
        public const string Y8USER = "Y8USER";

        /// <summary>
        /// Y8PID.
        /// </summary>
        public const string Y8PID = "Y8PID";

        /// <summary>
        /// Y8JOBN.
        /// </summary>
        public const string Y8JOBN = "Y8JOBN";

        /// <summary>
        /// Y8UPMJ.
        /// </summary>
        public const string Y8UPMJ = "Y8UPMJ";

        /// <summary>
        /// Y8UPMT.
        /// </summary>
        public const string Y8UPMT = "Y8UPMT";

        /// <summary>
        /// Y8PGRP.
        /// </summary>
        public const string Y8PGRP = "Y8PGRP";

        /// <summary>
        /// Y8CKCN.
        /// </summary>
        public const string Y8CKCN = "Y8CKCN";
    }

    /// <inheritdoc />
    public override string TableName => "F07149";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y8PAYD", "Y8PAYD", JdeDataType.String, 20, true, true),
        new JdeField("Y8AN8", "Y8AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8PDBA", "Y8PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8TAXX", "Y8TAXX", JdeDataType.String, 40, true, true),
        new JdeField("Y8HMCO", "Y8HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y8ANNIVDT", "Y8ANNIVDT", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8RECC", "Y8RECC", JdeDataType.String, 4),
        new JdeField("Y8BWPY", "Y8BWPY", JdeDataType.Numeric),
        new JdeField("Y8BWBB", "Y8BWBB", JdeDataType.Numeric),
        new JdeField("Y8FY$", "Y8FY$", JdeDataType.Numeric),
        new JdeField("Y8BHPY", "Y8BHPY", JdeDataType.Numeric),
        new JdeField("Y8BHBB", "Y8BHBB", JdeDataType.Numeric),
        new JdeField("Y8FYH", "Y8FYH", JdeDataType.Numeric),
        new JdeField("Y8USER", "Y8USER", JdeDataType.String, 20),
        new JdeField("Y8PID", "Y8PID", JdeDataType.String, 20),
        new JdeField("Y8JOBN", "Y8JOBN", JdeDataType.String, 20),
        new JdeField("Y8UPMJ", "Y8UPMJ", JdeDataType.Numeric),
        new JdeField("Y8UPMT", "Y8UPMT", JdeDataType.Numeric),
        new JdeField("Y8PGRP", "Y8PGRP", JdeDataType.String, 4),
        new JdeField("Y8CKCN", "Y8CKCN", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07149_0", "Primary Key on Y8PAYD, Y8AN8, Y8PDBA, Y8ANNIVDT, Y8HMCO, Y8TAXX, Y8CKCN", new[] { "Y8PAYD", "Y8AN8", "Y8PDBA", "Y8ANNIVDT", "Y8HMCO", "Y8TAXX", "Y8CKCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07149_2", "Index on Y8PAYD, Y8RECC", new[] { "Y8PAYD", "Y8RECC" }),
        new JdeIndex("F07149_3", "Index on Y8PAYD, Y8AN8, Y8CKCN", new[] { "Y8PAYD", "Y8AN8", "Y8CKCN" })
    };
}
