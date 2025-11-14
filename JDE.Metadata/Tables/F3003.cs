using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3003 - .
/// </summary>
public class F3003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRTRT.
        /// </summary>
        public const string IRTRT = "IRTRT";

        /// <summary>
        /// IRKIT.
        /// </summary>
        public const string IRKIT = "IRKIT";

        /// <summary>
        /// IRKITL.
        /// </summary>
        public const string IRKITL = "IRKITL";

        /// <summary>
        /// IRKITA.
        /// </summary>
        public const string IRKITA = "IRKITA";

        /// <summary>
        /// IRMMCU.
        /// </summary>
        public const string IRMMCU = "IRMMCU";

        /// <summary>
        /// IRALD.
        /// </summary>
        public const string IRALD = "IRALD";

        /// <summary>
        /// IRDSC1.
        /// </summary>
        public const string IRDSC1 = "IRDSC1";

        /// <summary>
        /// IRLINE.
        /// </summary>
        public const string IRLINE = "IRLINE";

        /// <summary>
        /// IRMCU.
        /// </summary>
        public const string IRMCU = "IRMCU";

        /// <summary>
        /// IROPSQ.
        /// </summary>
        public const string IROPSQ = "IROPSQ";

        /// <summary>
        /// IREFFF.
        /// </summary>
        public const string IREFFF = "IREFFF";

        /// <summary>
        /// IREFFT.
        /// </summary>
        public const string IREFFT = "IREFFT";

        /// <summary>
        /// IRBFPF.
        /// </summary>
        public const string IRBFPF = "IRBFPF";

        /// <summary>
        /// IRLAMC.
        /// </summary>
        public const string IRLAMC = "IRLAMC";

        /// <summary>
        /// IRTIMB.
        /// </summary>
        public const string IRTIMB = "IRTIMB";

        /// <summary>
        /// IROPSR.
        /// </summary>
        public const string IROPSR = "IROPSR";

        /// <summary>
        /// IRBQTY.
        /// </summary>
        public const string IRBQTY = "IRBQTY";

        /// <summary>
        /// IRUOM.
        /// </summary>
        public const string IRUOM = "IRUOM";

        /// <summary>
        /// IRRUNM.
        /// </summary>
        public const string IRRUNM = "IRRUNM";

        /// <summary>
        /// IRRUNL.
        /// </summary>
        public const string IRRUNL = "IRRUNL";

        /// <summary>
        /// IRSETL.
        /// </summary>
        public const string IRSETL = "IRSETL";

        /// <summary>
        /// IRPWRT.
        /// </summary>
        public const string IRPWRT = "IRPWRT";

        /// <summary>
        /// IRSETC.
        /// </summary>
        public const string IRSETC = "IRSETC";

        /// <summary>
        /// IRMOVD.
        /// </summary>
        public const string IRMOVD = "IRMOVD";

        /// <summary>
        /// IRQUED.
        /// </summary>
        public const string IRQUED = "IRQUED";

        /// <summary>
        /// IRLTPC.
        /// </summary>
        public const string IRLTPC = "IRLTPC";

        /// <summary>
        /// IRPOVR.
        /// </summary>
        public const string IRPOVR = "IRPOVR";

        /// <summary>
        /// IRNXOP.
        /// </summary>
        public const string IRNXOP = "IRNXOP";

        /// <summary>
        /// IROPYP.
        /// </summary>
        public const string IROPYP = "IROPYP";

        /// <summary>
        /// IRCPYP.
        /// </summary>
        public const string IRCPYP = "IRCPYP";

        /// <summary>
        /// IRAPID.
        /// </summary>
        public const string IRAPID = "IRAPID";

        /// <summary>
        /// IRSHNO.
        /// </summary>
        public const string IRSHNO = "IRSHNO";

        /// <summary>
        /// IROPSC.
        /// </summary>
        public const string IROPSC = "IROPSC";

        /// <summary>
        /// IRINPE.
        /// </summary>
        public const string IRINPE = "IRINPE";

        /// <summary>
        /// IRJBCD.
        /// </summary>
        public const string IRJBCD = "IRJBCD";

        /// <summary>
        /// IRAN8.
        /// </summary>
        public const string IRAN8 = "IRAN8";

        /// <summary>
        /// IRVEND.
        /// </summary>
        public const string IRVEND = "IRVEND";

        /// <summary>
        /// IRPOY.
        /// </summary>
        public const string IRPOY = "IRPOY";

        /// <summary>
        /// IRCOST.
        /// </summary>
        public const string IRCOST = "IRCOST";

        /// <summary>
        /// IROMCU.
        /// </summary>
        public const string IROMCU = "IROMCU";

        /// <summary>
        /// IROBJ.
        /// </summary>
        public const string IROBJ = "IROBJ";

        /// <summary>
        /// IRSUB.
        /// </summary>
        public const string IRSUB = "IRSUB";

        /// <summary>
        /// IRRREV.
        /// </summary>
        public const string IRRREV = "IRRREV";

        /// <summary>
        /// IRURCD.
        /// </summary>
        public const string IRURCD = "IRURCD";

        /// <summary>
        /// IRURDT.
        /// </summary>
        public const string IRURDT = "IRURDT";

        /// <summary>
        /// IRURAT.
        /// </summary>
        public const string IRURAT = "IRURAT";

        /// <summary>
        /// IRURRF.
        /// </summary>
        public const string IRURRF = "IRURRF";

        /// <summary>
        /// IRURAB.
        /// </summary>
        public const string IRURAB = "IRURAB";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IRTDAY.
        /// </summary>
        public const string IRTDAY = "IRTDAY";

        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";

        /// <summary>
        /// IRWMCU.
        /// </summary>
        public const string IRWMCU = "IRWMCU";

        /// <summary>
        /// IRLOCN.
        /// </summary>
        public const string IRLOCN = "IRLOCN";

        /// <summary>
        /// IRRUC.
        /// </summary>
        public const string IRRUC = "IRRUC";

        /// <summary>
        /// IRCAPU.
        /// </summary>
        public const string IRCAPU = "IRCAPU";

        /// <summary>
        /// IRACTB.
        /// </summary>
        public const string IRACTB = "IRACTB";

        /// <summary>
        /// IRNUMB.
        /// </summary>
        public const string IRNUMB = "IRNUMB";

        /// <summary>
        /// IRCBCO.
        /// </summary>
        public const string IRCBCO = "IRCBCO";

        /// <summary>
        /// IRCICO.
        /// </summary>
        public const string IRCICO = "IRCICO";

        /// <summary>
        /// IRIMCO.
        /// </summary>
        public const string IRIMCO = "IRIMCO";

        /// <summary>
        /// IRMPRO.
        /// </summary>
        public const string IRMPRO = "IRMPRO";

        /// <summary>
        /// IRAPSC.
        /// </summary>
        public const string IRAPSC = "IRAPSC";

        /// <summary>
        /// IRMNSP.
        /// </summary>
        public const string IRMNSP = "IRMNSP";

        /// <summary>
        /// IRMXSP.
        /// </summary>
        public const string IRMXSP = "IRMXSP";

        /// <summary>
        /// IRCMPE.
        /// </summary>
        public const string IRCMPE = "IRCMPE";

        /// <summary>
        /// IRCMPC.
        /// </summary>
        public const string IRCMPC = "IRCMPC";

        /// <summary>
        /// IRCPLVLFR.
        /// </summary>
        public const string IRCPLVLFR = "IRCPLVLFR";

        /// <summary>
        /// IRCPLVLTO.
        /// </summary>
        public const string IRCPLVLTO = "IRCPLVLTO";

        /// <summary>
        /// IRCMRQ.
        /// </summary>
        public const string IRCMRQ = "IRCMRQ";

        /// <summary>
        /// IRANSA.
        /// </summary>
        public const string IRANSA = "IRANSA";

        /// <summary>
        /// IRANPA.
        /// </summary>
        public const string IRANPA = "IRANPA";

        /// <summary>
        /// IRANP.
        /// </summary>
        public const string IRANP = "IRANP";

        /// <summary>
        /// IRWSCHF.
        /// </summary>
        public const string IRWSCHF = "IRWSCHF";

        /// <summary>
        /// IRTRAF.
        /// </summary>
        public const string IRTRAF = "IRTRAF";

        /// <summary>
        /// IRDFOPC.
        /// </summary>
        public const string IRDFOPC = "IRDFOPC";
    }

    /// <inheritdoc />
    public override string TableName => "F3003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRTRT", "IRTRT", JdeDataType.String, 6, true, true),
        new JdeField("IRKIT", "IRKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("IRKITL", "IRKITL", JdeDataType.String, 50),
        new JdeField("IRKITA", "IRKITA", JdeDataType.String, 50),
        new JdeField("IRMMCU", "IRMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IRALD", "IRALD", JdeDataType.String, 8),
        new JdeField("IRDSC1", "IRDSC1", JdeDataType.String, 60),
        new JdeField("IRLINE", "IRLINE", JdeDataType.String, 24, true, true),
        new JdeField("IRMCU", "IRMCU", JdeDataType.String, 24),
        new JdeField("IROPSQ", "IROPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IREFFF", "IREFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("IREFFT", "IREFFT", JdeDataType.Numeric),
        new JdeField("IRBFPF", "IRBFPF", JdeDataType.String, 2),
        new JdeField("IRLAMC", "IRLAMC", JdeDataType.String, 2),
        new JdeField("IRTIMB", "IRTIMB", JdeDataType.String, 2),
        new JdeField("IROPSR", "IROPSR", JdeDataType.Numeric),
        new JdeField("IRBQTY", "IRBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("IRUOM", "IRUOM", JdeDataType.String, 4),
        new JdeField("IRRUNM", "IRRUNM", JdeDataType.Numeric),
        new JdeField("IRRUNL", "IRRUNL", JdeDataType.Numeric),
        new JdeField("IRSETL", "IRSETL", JdeDataType.Numeric),
        new JdeField("IRPWRT", "IRPWRT", JdeDataType.Numeric),
        new JdeField("IRSETC", "IRSETC", JdeDataType.Numeric),
        new JdeField("IRMOVD", "IRMOVD", JdeDataType.Numeric),
        new JdeField("IRQUED", "IRQUED", JdeDataType.Numeric),
        new JdeField("IRLTPC", "IRLTPC", JdeDataType.Numeric),
        new JdeField("IRPOVR", "IRPOVR", JdeDataType.Numeric),
        new JdeField("IRNXOP", "IRNXOP", JdeDataType.Numeric),
        new JdeField("IROPYP", "IROPYP", JdeDataType.Numeric),
        new JdeField("IRCPYP", "IRCPYP", JdeDataType.Numeric),
        new JdeField("IRAPID", "IRAPID", JdeDataType.String, 24),
        new JdeField("IRSHNO", "IRSHNO", JdeDataType.String, 20),
        new JdeField("IROPSC", "IROPSC", JdeDataType.String, 4, true, true),
        new JdeField("IRINPE", "IRINPE", JdeDataType.String, 4),
        new JdeField("IRJBCD", "IRJBCD", JdeDataType.String, 12),
        new JdeField("IRAN8", "IRAN8", JdeDataType.Numeric),
        new JdeField("IRVEND", "IRVEND", JdeDataType.Numeric),
        new JdeField("IRPOY", "IRPOY", JdeDataType.String, 2),
        new JdeField("IRCOST", "IRCOST", JdeDataType.String, 6),
        new JdeField("IROMCU", "IROMCU", JdeDataType.String, 24),
        new JdeField("IROBJ", "IROBJ", JdeDataType.String, 12),
        new JdeField("IRSUB", "IRSUB", JdeDataType.String, 16),
        new JdeField("IRRREV", "IRRREV", JdeDataType.String, 6),
        new JdeField("IRURCD", "IRURCD", JdeDataType.String, 4),
        new JdeField("IRURDT", "IRURDT", JdeDataType.Numeric),
        new JdeField("IRURAT", "IRURAT", JdeDataType.Numeric),
        new JdeField("IRURRF", "IRURRF", JdeDataType.String, 30),
        new JdeField("IRURAB", "IRURAB", JdeDataType.Numeric),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRTDAY", "IRTDAY", JdeDataType.Numeric),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRWMCU", "IRWMCU", JdeDataType.String, 24),
        new JdeField("IRLOCN", "IRLOCN", JdeDataType.String, 40),
        new JdeField("IRRUC", "IRRUC", JdeDataType.Numeric),
        new JdeField("IRCAPU", "IRCAPU", JdeDataType.String, 4),
        new JdeField("IRACTB", "IRACTB", JdeDataType.String, 20),
        new JdeField("IRNUMB", "IRNUMB", JdeDataType.Numeric),
        new JdeField("IRCBCO", "IRCBCO", JdeDataType.Numeric),
        new JdeField("IRCICO", "IRCICO", JdeDataType.Numeric),
        new JdeField("IRIMCO", "IRIMCO", JdeDataType.Numeric),
        new JdeField("IRMPRO", "IRMPRO", JdeDataType.Numeric),
        new JdeField("IRAPSC", "IRAPSC", JdeDataType.String, 2),
        new JdeField("IRMNSP", "IRMNSP", JdeDataType.Numeric),
        new JdeField("IRMXSP", "IRMXSP", JdeDataType.Numeric),
        new JdeField("IRCMPE", "IRCMPE", JdeDataType.String, 6),
        new JdeField("IRCMPC", "IRCMPC", JdeDataType.String, 20),
        new JdeField("IRCPLVLFR", "IRCPLVLFR", JdeDataType.Numeric),
        new JdeField("IRCPLVLTO", "IRCPLVLTO", JdeDataType.Numeric),
        new JdeField("IRCMRQ", "IRCMRQ", JdeDataType.String, 2),
        new JdeField("IRANSA", "IRANSA", JdeDataType.Numeric),
        new JdeField("IRANPA", "IRANPA", JdeDataType.Numeric),
        new JdeField("IRANP", "IRANP", JdeDataType.Numeric),
        new JdeField("IRWSCHF", "IRWSCHF", JdeDataType.String, 2),
        new JdeField("IRTRAF", "IRTRAF", JdeDataType.String, 2),
        new JdeField("IRDFOPC", "IRDFOPC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3003_0", "Primary Key on IRMMCU, IRKIT, IRTRT, IRBQTY, IROPSQ, IROPSC, IRLINE, IREFFF", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IROPSQ", "IROPSC", "IRLINE", "IREFFF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3003_10", "Index on IRKIT, IRMMCU, IRBQTY, IROPSC", new[] { "IRKIT", "IRMMCU", "IRBQTY", "IROPSC" }),
        new JdeIndex("F3003_11", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY, IRDFOPC, IROPSQ", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IRDFOPC", "IROPSQ" }),
        new JdeIndex("F3003_12", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY" }),
        new JdeIndex("F3003_13", "Index on IRURAB", new[] { "IRURAB" }),
        new JdeIndex("F3003_14", "Index on IRKIT, IRMMCU, IRTRT", new[] { "IRKIT", "IRMMCU", "IRTRT" }),
        new JdeIndex("F3003_2", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY, IROPSQ, IROPSC", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IROPSQ", "IROPSC" }),
        new JdeIndex("F3003_3", "Index on IRMCU, IRMMCU, IROPSQ, IRKIT", new[] { "IRMCU", "IRMMCU", "IROPSQ", "IRKIT" }),
        new JdeIndex("F3003_4", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY, IRLINE, IROPSQ, IROPSC, IRMCU", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IRLINE", "IROPSQ", "IROPSC", "IRMCU" }),
        new JdeIndex("F3003_5", "Index on IRKIT, IRMMCU, IRTRT, IRBQTY, IRMCU, IRLINE, IROPSC", new[] { "IRKIT", "IRMMCU", "IRTRT", "IRBQTY", "IRMCU", "IRLINE", "IROPSC" }),
        new JdeIndex("F3003_6", "Index on IRMMCU, IRTRT, IRBQTY, IRMCU, IRLINE, IRKIT", new[] { "IRMMCU", "IRTRT", "IRBQTY", "IRMCU", "IRLINE", "IRKIT" }),
        new JdeIndex("F3003_7", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY, IROPSQ, IROPSC, IRMCU", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IROPSQ", "IROPSC", "IRMCU" }),
        new JdeIndex("F3003_8", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY, SYS_NC00078$", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "SYS_NC00078$" }),
        new JdeIndex("F3003_9", "Index on IRMMCU, IRKIT, IRTRT, IRBQTY, IRLINE, SYS_NC00078$", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IRLINE", "SYS_NC00078$" })
    };
}
