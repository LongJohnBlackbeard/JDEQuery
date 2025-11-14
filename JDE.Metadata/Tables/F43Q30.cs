using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q30 - .
/// </summary>
public class F43Q30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EVEVNU.
        /// </summary>
        public const string EVEVNU = "EVEVNU";

        /// <summary>
        /// EVDCTO.
        /// </summary>
        public const string EVDCTO = "EVDCTO";

        /// <summary>
        /// EVKCOO.
        /// </summary>
        public const string EVKCOO = "EVKCOO";

        /// <summary>
        /// EVAN8.
        /// </summary>
        public const string EVAN8 = "EVAN8";

        /// <summary>
        /// EVCRMD.
        /// </summary>
        public const string EVCRMD = "EVCRMD";

        /// <summary>
        /// EVIVST.
        /// </summary>
        public const string EVIVST = "EVIVST";

        /// <summary>
        /// EVRUTE.
        /// </summary>
        public const string EVRUTE = "EVRUTE";

        /// <summary>
        /// EVALPH.
        /// </summary>
        public const string EVALPH = "EVALPH";

        /// <summary>
        /// EVPH3.
        /// </summary>
        public const string EVPH3 = "EVPH3";

        /// <summary>
        /// EVEMAL.
        /// </summary>
        public const string EVEMAL = "EVEMAL";

        /// <summary>
        /// EVIDLN.
        /// </summary>
        public const string EVIDLN = "EVIDLN";

        /// <summary>
        /// EVAT1.
        /// </summary>
        public const string EVAT1 = "EVAT1";

        /// <summary>
        /// EVURCD.
        /// </summary>
        public const string EVURCD = "EVURCD";

        /// <summary>
        /// EVURDT.
        /// </summary>
        public const string EVURDT = "EVURDT";

        /// <summary>
        /// EVURAT.
        /// </summary>
        public const string EVURAT = "EVURAT";

        /// <summary>
        /// EVURAB.
        /// </summary>
        public const string EVURAB = "EVURAB";

        /// <summary>
        /// EVURRF.
        /// </summary>
        public const string EVURRF = "EVURRF";

        /// <summary>
        /// EVTORG.
        /// </summary>
        public const string EVTORG = "EVTORG";

        /// <summary>
        /// EVUSER.
        /// </summary>
        public const string EVUSER = "EVUSER";

        /// <summary>
        /// EVPID.
        /// </summary>
        public const string EVPID = "EVPID";

        /// <summary>
        /// EVJOBN.
        /// </summary>
        public const string EVJOBN = "EVJOBN";

        /// <summary>
        /// EVUPMJ.
        /// </summary>
        public const string EVUPMJ = "EVUPMJ";

        /// <summary>
        /// EVTDAY.
        /// </summary>
        public const string EVTDAY = "EVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EVEVNU", "EVEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EVDCTO", "EVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EVKCOO", "EVKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EVAN8", "EVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EVCRMD", "EVCRMD", JdeDataType.String, 2),
        new JdeField("EVIVST", "EVIVST", JdeDataType.String, 4),
        new JdeField("EVRUTE", "EVRUTE", JdeDataType.String, 2),
        new JdeField("EVALPH", "EVALPH", JdeDataType.String, 80),
        new JdeField("EVPH3", "EVPH3", JdeDataType.String, 40),
        new JdeField("EVEMAL", "EVEMAL", JdeDataType.String, 512),
        new JdeField("EVIDLN", "EVIDLN", JdeDataType.Numeric),
        new JdeField("EVAT1", "EVAT1", JdeDataType.String, 6),
        new JdeField("EVURCD", "EVURCD", JdeDataType.String, 4),
        new JdeField("EVURDT", "EVURDT", JdeDataType.Numeric),
        new JdeField("EVURAT", "EVURAT", JdeDataType.Numeric),
        new JdeField("EVURAB", "EVURAB", JdeDataType.Numeric),
        new JdeField("EVURRF", "EVURRF", JdeDataType.String, 30),
        new JdeField("EVTORG", "EVTORG", JdeDataType.String, 20),
        new JdeField("EVUSER", "EVUSER", JdeDataType.String, 20),
        new JdeField("EVPID", "EVPID", JdeDataType.String, 20),
        new JdeField("EVJOBN", "EVJOBN", JdeDataType.String, 20),
        new JdeField("EVUPMJ", "EVUPMJ", JdeDataType.Numeric),
        new JdeField("EVTDAY", "EVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q30_0", "Primary Key on EVEVNU, EVDCTO, EVKCOO, EVAN8", new[] { "EVEVNU", "EVDCTO", "EVKCOO", "EVAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q30_2", "Index on EVEVNU, EVDCTO, EVKCOO", new[] { "EVEVNU", "EVDCTO", "EVKCOO" })
    };
}
