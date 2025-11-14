using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q60 - .
/// </summary>
public class F43Q60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BQBIDCODE.
        /// </summary>
        public const string BQBIDCODE = "BQBIDCODE";

        /// <summary>
        /// BQCMDCDE.
        /// </summary>
        public const string BQCMDCDE = "BQCMDCDE";

        /// <summary>
        /// BQITM.
        /// </summary>
        public const string BQITM = "BQITM";

        /// <summary>
        /// BQEFDT.
        /// </summary>
        public const string BQEFDT = "BQEFDT";

        /// <summary>
        /// BQEEDA.
        /// </summary>
        public const string BQEEDA = "BQEEDA";

        /// <summary>
        /// BQBQS.
        /// </summary>
        public const string BQBQS = "BQBQS";

        /// <summary>
        /// BQBQTYP.
        /// </summary>
        public const string BQBQTYP = "BQBQTYP";

        /// <summary>
        /// BQDESC.
        /// </summary>
        public const string BQDESC = "BQDESC";

        /// <summary>
        /// BQBIDQUES.
        /// </summary>
        public const string BQBIDQUES = "BQBIDQUES";

        /// <summary>
        /// BQUOM.
        /// </summary>
        public const string BQUOM = "BQUOM";

        /// <summary>
        /// BQWSTQ.
        /// </summary>
        public const string BQWSTQ = "BQWSTQ";

        /// <summary>
        /// BQBESTQTY.
        /// </summary>
        public const string BQBESTQTY = "BQBESTQTY";

        /// <summary>
        /// BQWSAMT.
        /// </summary>
        public const string BQWSAMT = "BQWSAMT";

        /// <summary>
        /// BQBESTAMT.
        /// </summary>
        public const string BQBESTAMT = "BQBESTAMT";

        /// <summary>
        /// BQWDAT.
        /// </summary>
        public const string BQWDAT = "BQWDAT";

        /// <summary>
        /// BQBESTDATE.
        /// </summary>
        public const string BQBESTDATE = "BQBESTDATE";

        /// <summary>
        /// BQIDTX.
        /// </summary>
        public const string BQIDTX = "BQIDTX";

        /// <summary>
        /// BQIYON.
        /// </summary>
        public const string BQIYON = "BQIYON";

        /// <summary>
        /// BQBRQD.
        /// </summary>
        public const string BQBRQD = "BQBRQD";

        /// <summary>
        /// BQWHTG.
        /// </summary>
        public const string BQWHTG = "BQWHTG";

        /// <summary>
        /// BQOUTRANGE.
        /// </summary>
        public const string BQOUTRANGE = "BQOUTRANGE";

        /// <summary>
        /// BQMULTSEL.
        /// </summary>
        public const string BQMULTSEL = "BQMULTSEL";

        /// <summary>
        /// BQHDQUEST.
        /// </summary>
        public const string BQHDQUEST = "BQHDQUEST";

        /// <summary>
        /// BQURCD.
        /// </summary>
        public const string BQURCD = "BQURCD";

        /// <summary>
        /// BQURDT.
        /// </summary>
        public const string BQURDT = "BQURDT";

        /// <summary>
        /// BQURAT.
        /// </summary>
        public const string BQURAT = "BQURAT";

        /// <summary>
        /// BQURAB.
        /// </summary>
        public const string BQURAB = "BQURAB";

        /// <summary>
        /// BQURRF.
        /// </summary>
        public const string BQURRF = "BQURRF";

        /// <summary>
        /// BQTORG.
        /// </summary>
        public const string BQTORG = "BQTORG";

        /// <summary>
        /// BQUSER.
        /// </summary>
        public const string BQUSER = "BQUSER";

        /// <summary>
        /// BQPID.
        /// </summary>
        public const string BQPID = "BQPID";

        /// <summary>
        /// BQJOBN.
        /// </summary>
        public const string BQJOBN = "BQJOBN";

        /// <summary>
        /// BQUPMJ.
        /// </summary>
        public const string BQUPMJ = "BQUPMJ";

        /// <summary>
        /// BQTDAY.
        /// </summary>
        public const string BQTDAY = "BQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BQBIDCODE", "BQBIDCODE", JdeDataType.String, 36, true, true),
        new JdeField("BQCMDCDE", "BQCMDCDE", JdeDataType.String, 30, true, true),
        new JdeField("BQITM", "BQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BQEFDT", "BQEFDT", JdeDataType.Date),
        new JdeField("BQEEDA", "BQEEDA", JdeDataType.Date),
        new JdeField("BQBQS", "BQBQS", JdeDataType.String, 4),
        new JdeField("BQBQTYP", "BQBQTYP", JdeDataType.String, 4),
        new JdeField("BQDESC", "BQDESC", JdeDataType.String, 60),
        new JdeField("BQBIDQUES", "BQBIDQUES", JdeDataType.String, 3998),
        new JdeField("BQUOM", "BQUOM", JdeDataType.String, 4),
        new JdeField("BQWSTQ", "BQWSTQ", JdeDataType.Numeric),
        new JdeField("BQBESTQTY", "BQBESTQTY", JdeDataType.Numeric),
        new JdeField("BQWSAMT", "BQWSAMT", JdeDataType.Numeric),
        new JdeField("BQBESTAMT", "BQBESTAMT", JdeDataType.Numeric),
        new JdeField("BQWDAT", "BQWDAT", JdeDataType.Numeric),
        new JdeField("BQBESTDATE", "BQBESTDATE", JdeDataType.Numeric),
        new JdeField("BQIDTX", "BQIDTX", JdeDataType.String, 1000),
        new JdeField("BQIYON", "BQIYON", JdeDataType.String, 2),
        new JdeField("BQBRQD", "BQBRQD", JdeDataType.String, 2),
        new JdeField("BQWHTG", "BQWHTG", JdeDataType.Numeric),
        new JdeField("BQOUTRANGE", "BQOUTRANGE", JdeDataType.String, 2),
        new JdeField("BQMULTSEL", "BQMULTSEL", JdeDataType.String, 2),
        new JdeField("BQHDQUEST", "BQHDQUEST", JdeDataType.String, 2),
        new JdeField("BQURCD", "BQURCD", JdeDataType.String, 4),
        new JdeField("BQURDT", "BQURDT", JdeDataType.Numeric),
        new JdeField("BQURAT", "BQURAT", JdeDataType.Numeric),
        new JdeField("BQURAB", "BQURAB", JdeDataType.Numeric),
        new JdeField("BQURRF", "BQURRF", JdeDataType.String, 30),
        new JdeField("BQTORG", "BQTORG", JdeDataType.String, 20),
        new JdeField("BQUSER", "BQUSER", JdeDataType.String, 20),
        new JdeField("BQPID", "BQPID", JdeDataType.String, 20),
        new JdeField("BQJOBN", "BQJOBN", JdeDataType.String, 20),
        new JdeField("BQUPMJ", "BQUPMJ", JdeDataType.Numeric),
        new JdeField("BQTDAY", "BQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q60_0", "Primary Key on BQBIDCODE, BQCMDCDE, BQITM", new[] { "BQBIDCODE", "BQCMDCDE", "BQITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q60_2", "Index on BQCMDCDE, BQBQTYP, BQBQS", new[] { "BQCMDCDE", "BQBQTYP", "BQBQS" }),
        new JdeIndex("F43Q60_3", "Index on BQITM, BQBQTYP, BQBQS", new[] { "BQITM", "BQBQTYP", "BQBQS" }),
        new JdeIndex("F43Q60_4", "Index on BQITM", new[] { "BQITM" }),
        new JdeIndex("F43Q60_5", "Index on BQCMDCDE", new[] { "BQCMDCDE" }),
        new JdeIndex("F43Q60_6", "Index on BQBIDCODE", new[] { "BQBIDCODE" }),
        new JdeIndex("F43Q60_7", "Index on BQITM, BQCMDCDE", new[] { "BQITM", "BQCMDCDE" })
    };
}
