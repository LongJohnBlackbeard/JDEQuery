using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1811 - .
/// </summary>
public class F1811 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKTSKID.
        /// </summary>
        public const string TKTSKID = "TKTSKID";

        /// <summary>
        /// TKRSSEQ.
        /// </summary>
        public const string TKRSSEQ = "TKRSSEQ";

        /// <summary>
        /// TKTSKSTAT.
        /// </summary>
        public const string TKTSKSTAT = "TKTSKSTAT";

        /// <summary>
        /// TKASSN.
        /// </summary>
        public const string TKASSN = "TKASSN";

        /// <summary>
        /// TKIAVL.
        /// </summary>
        public const string TKIAVL = "TKIAVL";

        /// <summary>
        /// TKCALRMK.
        /// </summary>
        public const string TKCALRMK = "TKCALRMK";

        /// <summary>
        /// TKCALREM.
        /// </summary>
        public const string TKCALREM = "TKCALREM";

        /// <summary>
        /// TKRRTY.
        /// </summary>
        public const string TKRRTY = "TKRRTY";

        /// <summary>
        /// TKRSCN.
        /// </summary>
        public const string TKRSCN = "TKRSCN";

        /// <summary>
        /// TKMCU2.
        /// </summary>
        public const string TKMCU2 = "TKMCU2";

        /// <summary>
        /// TKANSA.
        /// </summary>
        public const string TKANSA = "TKANSA";

        /// <summary>
        /// TKDAP.
        /// </summary>
        public const string TKDAP = "TKDAP";

        /// <summary>
        /// TKSTRT.
        /// </summary>
        public const string TKSTRT = "TKSTRT";

        /// <summary>
        /// TKPBTM.
        /// </summary>
        public const string TKPBTM = "TKPBTM";

        /// <summary>
        /// TKSTRX.
        /// </summary>
        public const string TKSTRX = "TKSTRX";

        /// <summary>
        /// TKPETM.
        /// </summary>
        public const string TKPETM = "TKPETM";

        /// <summary>
        /// TKHRSA.
        /// </summary>
        public const string TKHRSA = "TKHRSA";

        /// <summary>
        /// TKTARULEN.
        /// </summary>
        public const string TKTARULEN = "TKTARULEN";

        /// <summary>
        /// TKTARUSEQN.
        /// </summary>
        public const string TKTARUSEQN = "TKTARUSEQN";

        /// <summary>
        /// TKTSKURN1.
        /// </summary>
        public const string TKTSKURN1 = "TKTSKURN1";

        /// <summary>
        /// TKTSKURN2.
        /// </summary>
        public const string TKTSKURN2 = "TKTSKURN2";

        /// <summary>
        /// TKTSKURN3.
        /// </summary>
        public const string TKTSKURN3 = "TKTSKURN3";

        /// <summary>
        /// TKURCD.
        /// </summary>
        public const string TKURCD = "TKURCD";

        /// <summary>
        /// TKURDT.
        /// </summary>
        public const string TKURDT = "TKURDT";

        /// <summary>
        /// TKURAT.
        /// </summary>
        public const string TKURAT = "TKURAT";

        /// <summary>
        /// TKURAB.
        /// </summary>
        public const string TKURAB = "TKURAB";

        /// <summary>
        /// TKURRF.
        /// </summary>
        public const string TKURRF = "TKURRF";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKTDAY.
        /// </summary>
        public const string TKTDAY = "TKTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F1811";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKTSKID", "TKTSKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TKRSSEQ", "TKRSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TKTSKSTAT", "TKTSKSTAT", JdeDataType.String, 6),
        new JdeField("TKASSN", "TKASSN", JdeDataType.String, 20),
        new JdeField("TKIAVL", "TKIAVL", JdeDataType.String, 2),
        new JdeField("TKCALRMK", "TKCALRMK", JdeDataType.String, 60),
        new JdeField("TKCALREM", "TKCALREM", JdeDataType.String, 2),
        new JdeField("TKRRTY", "TKRRTY", JdeDataType.String, 4),
        new JdeField("TKRSCN", "TKRSCN", JdeDataType.Numeric),
        new JdeField("TKMCU2", "TKMCU2", JdeDataType.String, 24),
        new JdeField("TKANSA", "TKANSA", JdeDataType.Numeric),
        new JdeField("TKDAP", "TKDAP", JdeDataType.Numeric),
        new JdeField("TKSTRT", "TKSTRT", JdeDataType.Numeric),
        new JdeField("TKPBTM", "TKPBTM", JdeDataType.Numeric),
        new JdeField("TKSTRX", "TKSTRX", JdeDataType.Numeric),
        new JdeField("TKPETM", "TKPETM", JdeDataType.Numeric),
        new JdeField("TKHRSA", "TKHRSA", JdeDataType.Numeric),
        new JdeField("TKTARULEN", "TKTARULEN", JdeDataType.Numeric),
        new JdeField("TKTARUSEQN", "TKTARUSEQN", JdeDataType.Numeric),
        new JdeField("TKTSKURN1", "TKTSKURN1", JdeDataType.Numeric),
        new JdeField("TKTSKURN2", "TKTSKURN2", JdeDataType.Numeric),
        new JdeField("TKTSKURN3", "TKTSKURN3", JdeDataType.Numeric),
        new JdeField("TKURCD", "TKURCD", JdeDataType.String, 4),
        new JdeField("TKURDT", "TKURDT", JdeDataType.Numeric),
        new JdeField("TKURAT", "TKURAT", JdeDataType.Numeric),
        new JdeField("TKURAB", "TKURAB", JdeDataType.Numeric),
        new JdeField("TKURRF", "TKURRF", JdeDataType.String, 30),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKTDAY", "TKTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1811_0", "Primary Key on TKTSKID, TKRSSEQ", new[] { "TKTSKID", "TKRSSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1811_2", "Index on TKRRTY, TKRSCN, TKTSKID, TKRSSEQ", new[] { "TKRRTY", "TKRSCN", "TKTSKID", "TKRSSEQ" }),
        new JdeIndex("F1811_3", "Index on TKANSA", new[] { "TKANSA" }),
        new JdeIndex("F1811_4", "Index on TKMCU2", new[] { "TKMCU2" })
    };
}
