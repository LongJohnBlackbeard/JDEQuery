using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277730 - .
/// </summary>
public class F4277730 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADALLRNME.
        /// </summary>
        public const string ADALLRNME = "ADALLRNME";

        /// <summary>
        /// ADALRID.
        /// </summary>
        public const string ADALRID = "ADALRID";

        /// <summary>
        /// ADALLSEQ.
        /// </summary>
        public const string ADALLSEQ = "ADALLSEQ";

        /// <summary>
        /// ADSSFR.
        /// </summary>
        public const string ADSSFR = "ADSSFR";

        /// <summary>
        /// ADSSPERC.
        /// </summary>
        public const string ADSSPERC = "ADSSPERC";

        /// <summary>
        /// ADALPERC.
        /// </summary>
        public const string ADALPERC = "ADALPERC";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADTDAY.
        /// </summary>
        public const string ADTDAY = "ADTDAY";

        /// <summary>
        /// ADUTIME.
        /// </summary>
        public const string ADUTIME = "ADUTIME";

        /// <summary>
        /// ADCTID.
        /// </summary>
        public const string ADCTID = "ADCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F4277730";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADALLRNME", "ADALLRNME", JdeDataType.String, 30, true, true),
        new JdeField("ADALRID", "ADALRID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADALLSEQ", "ADALLSEQ", JdeDataType.Numeric),
        new JdeField("ADSSFR", "ADSSFR", JdeDataType.Numeric),
        new JdeField("ADSSPERC", "ADSSPERC", JdeDataType.Numeric),
        new JdeField("ADALPERC", "ADALPERC", JdeDataType.Numeric),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADTDAY", "ADTDAY", JdeDataType.Numeric),
        new JdeField("ADUTIME", "ADUTIME", JdeDataType.Date),
        new JdeField("ADCTID", "ADCTID", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277730_0", "Primary Key on ADALLRNME, ADALRID", new[] { "ADALLRNME", "ADALRID" }, isUnique: true, isPrimaryKey: true)
    };
}
