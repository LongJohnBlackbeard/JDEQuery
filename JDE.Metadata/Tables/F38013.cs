using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38013 - .
/// </summary>
public class F38013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DQDMCT.
        /// </summary>
        public const string DQDMCT = "DQDMCT";

        /// <summary>
        /// DQDMCS.
        /// </summary>
        public const string DQDMCS = "DQDMCS";

        /// <summary>
        /// DQSEQ.
        /// </summary>
        public const string DQSEQ = "DQSEQ";

        /// <summary>
        /// DQPSR.
        /// </summary>
        public const string DQPSR = "DQPSR";

        /// <summary>
        /// DQPSRY.
        /// </summary>
        public const string DQPSRY = "DQPSRY";

        /// <summary>
        /// DQEFTJ.
        /// </summary>
        public const string DQEFTJ = "DQEFTJ";

        /// <summary>
        /// DQEXDJ.
        /// </summary>
        public const string DQEXDJ = "DQEXDJ";

        /// <summary>
        /// DQCNQT.
        /// </summary>
        public const string DQCNQT = "DQCNQT";

        /// <summary>
        /// DQAA.
        /// </summary>
        public const string DQAA = "DQAA";

        /// <summary>
        /// DQTV01.
        /// </summary>
        public const string DQTV01 = "DQTV01";

        /// <summary>
        /// DQTV02.
        /// </summary>
        public const string DQTV02 = "DQTV02";

        /// <summary>
        /// DQTV03.
        /// </summary>
        public const string DQTV03 = "DQTV03";

        /// <summary>
        /// DQURCD.
        /// </summary>
        public const string DQURCD = "DQURCD";

        /// <summary>
        /// DQURDT.
        /// </summary>
        public const string DQURDT = "DQURDT";

        /// <summary>
        /// DQURAT.
        /// </summary>
        public const string DQURAT = "DQURAT";

        /// <summary>
        /// DQURAB.
        /// </summary>
        public const string DQURAB = "DQURAB";

        /// <summary>
        /// DQURRF.
        /// </summary>
        public const string DQURRF = "DQURRF";

        /// <summary>
        /// DQUSER.
        /// </summary>
        public const string DQUSER = "DQUSER";

        /// <summary>
        /// DQPID.
        /// </summary>
        public const string DQPID = "DQPID";

        /// <summary>
        /// DQJOBN.
        /// </summary>
        public const string DQJOBN = "DQJOBN";

        /// <summary>
        /// DQUPMJ.
        /// </summary>
        public const string DQUPMJ = "DQUPMJ";

        /// <summary>
        /// DQTDAY.
        /// </summary>
        public const string DQTDAY = "DQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F38013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DQDMCT", "DQDMCT", JdeDataType.String, 24, true, true),
        new JdeField("DQDMCS", "DQDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("DQSEQ", "DQSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DQPSR", "DQPSR", JdeDataType.String, 24, true, true),
        new JdeField("DQPSRY", "DQPSRY", JdeDataType.String, 4, true, true),
        new JdeField("DQEFTJ", "DQEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DQEXDJ", "DQEXDJ", JdeDataType.Numeric),
        new JdeField("DQCNQT", "DQCNQT", JdeDataType.Numeric),
        new JdeField("DQAA", "DQAA", JdeDataType.Numeric),
        new JdeField("DQTV01", "DQTV01", JdeDataType.String, 2),
        new JdeField("DQTV02", "DQTV02", JdeDataType.String, 2),
        new JdeField("DQTV03", "DQTV03", JdeDataType.String, 2),
        new JdeField("DQURCD", "DQURCD", JdeDataType.String, 4),
        new JdeField("DQURDT", "DQURDT", JdeDataType.Numeric),
        new JdeField("DQURAT", "DQURAT", JdeDataType.Numeric),
        new JdeField("DQURAB", "DQURAB", JdeDataType.Numeric),
        new JdeField("DQURRF", "DQURRF", JdeDataType.String, 30),
        new JdeField("DQUSER", "DQUSER", JdeDataType.String, 20),
        new JdeField("DQPID", "DQPID", JdeDataType.String, 20),
        new JdeField("DQJOBN", "DQJOBN", JdeDataType.String, 20),
        new JdeField("DQUPMJ", "DQUPMJ", JdeDataType.Numeric),
        new JdeField("DQTDAY", "DQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38013_0", "Primary Key on DQDMCT, DQDMCS, DQSEQ, DQPSR, DQPSRY, DQEFTJ", new[] { "DQDMCT", "DQDMCS", "DQSEQ", "DQPSR", "DQPSRY", "DQEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
