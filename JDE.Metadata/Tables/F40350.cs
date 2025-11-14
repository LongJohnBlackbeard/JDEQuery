using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40350 - .
/// </summary>
public class F40350 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OQAN8.
        /// </summary>
        public const string OQAN8 = "OQAN8";

        /// <summary>
        /// OQCS17.
        /// </summary>
        public const string OQCS17 = "OQCS17";

        /// <summary>
        /// OQITM.
        /// </summary>
        public const string OQITM = "OQITM";

        /// <summary>
        /// OQIT17.
        /// </summary>
        public const string OQIT17 = "OQIT17";

        /// <summary>
        /// OQEFTJ.
        /// </summary>
        public const string OQEFTJ = "OQEFTJ";

        /// <summary>
        /// OQEXDJ.
        /// </summary>
        public const string OQEXDJ = "OQEXDJ";

        /// <summary>
        /// OQMNQ.
        /// </summary>
        public const string OQMNQ = "OQMNQ";

        /// <summary>
        /// OQMXQ.
        /// </summary>
        public const string OQMXQ = "OQMXQ";

        /// <summary>
        /// OQUOM.
        /// </summary>
        public const string OQUOM = "OQUOM";

        /// <summary>
        /// OQTXID.
        /// </summary>
        public const string OQTXID = "OQTXID";

        /// <summary>
        /// OQSTPR.
        /// </summary>
        public const string OQSTPR = "OQSTPR";

        /// <summary>
        /// OQOSEQ.
        /// </summary>
        public const string OQOSEQ = "OQOSEQ";

        /// <summary>
        /// OQMCU.
        /// </summary>
        public const string OQMCU = "OQMCU";

        /// <summary>
        /// OQCTDR.
        /// </summary>
        public const string OQCTDR = "OQCTDR";

        /// <summary>
        /// OQCTTS.
        /// </summary>
        public const string OQCTTS = "OQCTTS";

        /// <summary>
        /// OQGLC.
        /// </summary>
        public const string OQGLC = "OQGLC";

        /// <summary>
        /// OQSRNR.
        /// </summary>
        public const string OQSRNR = "OQSRNR";

        /// <summary>
        /// OQBLGR.
        /// </summary>
        public const string OQBLGR = "OQBLGR";

        /// <summary>
        /// OQURDT.
        /// </summary>
        public const string OQURDT = "OQURDT";

        /// <summary>
        /// OQURCD.
        /// </summary>
        public const string OQURCD = "OQURCD";

        /// <summary>
        /// OQURAT.
        /// </summary>
        public const string OQURAT = "OQURAT";

        /// <summary>
        /// OQURAB.
        /// </summary>
        public const string OQURAB = "OQURAB";

        /// <summary>
        /// OQURRF.
        /// </summary>
        public const string OQURRF = "OQURRF";

        /// <summary>
        /// OQUSER.
        /// </summary>
        public const string OQUSER = "OQUSER";

        /// <summary>
        /// OQPID.
        /// </summary>
        public const string OQPID = "OQPID";

        /// <summary>
        /// OQJOBN.
        /// </summary>
        public const string OQJOBN = "OQJOBN";

        /// <summary>
        /// OQUPMJ.
        /// </summary>
        public const string OQUPMJ = "OQUPMJ";

        /// <summary>
        /// OQTDAY.
        /// </summary>
        public const string OQTDAY = "OQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40350";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OQAN8", "OQAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OQCS17", "OQCS17", JdeDataType.String, 16, true, true),
        new JdeField("OQITM", "OQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OQIT17", "OQIT17", JdeDataType.String, 16, true, true),
        new JdeField("OQEFTJ", "OQEFTJ", JdeDataType.Numeric),
        new JdeField("OQEXDJ", "OQEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("OQMNQ", "OQMNQ", JdeDataType.Numeric),
        new JdeField("OQMXQ", "OQMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OQUOM", "OQUOM", JdeDataType.String, 4, true, true),
        new JdeField("OQTXID", "OQTXID", JdeDataType.Numeric),
        new JdeField("OQSTPR", "OQSTPR", JdeDataType.String, 2),
        new JdeField("OQOSEQ", "OQOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OQMCU", "OQMCU", JdeDataType.String, 24),
        new JdeField("OQCTDR", "OQCTDR", JdeDataType.String, 2),
        new JdeField("OQCTTS", "OQCTTS", JdeDataType.String, 2),
        new JdeField("OQGLC", "OQGLC", JdeDataType.String, 8),
        new JdeField("OQSRNR", "OQSRNR", JdeDataType.String, 2),
        new JdeField("OQBLGR", "OQBLGR", JdeDataType.String, 24),
        new JdeField("OQURDT", "OQURDT", JdeDataType.Numeric),
        new JdeField("OQURCD", "OQURCD", JdeDataType.String, 4),
        new JdeField("OQURAT", "OQURAT", JdeDataType.Numeric),
        new JdeField("OQURAB", "OQURAB", JdeDataType.Numeric),
        new JdeField("OQURRF", "OQURRF", JdeDataType.String, 30),
        new JdeField("OQUSER", "OQUSER", JdeDataType.String, 20),
        new JdeField("OQPID", "OQPID", JdeDataType.String, 20),
        new JdeField("OQJOBN", "OQJOBN", JdeDataType.String, 20),
        new JdeField("OQUPMJ", "OQUPMJ", JdeDataType.Numeric),
        new JdeField("OQTDAY", "OQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40350_0", "Primary Key on OQAN8, OQCS17, OQITM, OQIT17, OQEXDJ, OQMXQ, OQUOM, OQOSEQ", new[] { "OQAN8", "OQCS17", "OQITM", "OQIT17", "OQEXDJ", "OQMXQ", "OQUOM", "OQOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
