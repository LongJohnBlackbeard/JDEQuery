using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F300311 - .
/// </summary>
public class F300311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHUKID.
        /// </summary>
        public const string EHUKID = "EHUKID";

        /// <summary>
        /// EHTRT.
        /// </summary>
        public const string EHTRT = "EHTRT";

        /// <summary>
        /// EHKIT.
        /// </summary>
        public const string EHKIT = "EHKIT";

        /// <summary>
        /// EHMMCU.
        /// </summary>
        public const string EHMMCU = "EHMMCU";

        /// <summary>
        /// EHDSC1.
        /// </summary>
        public const string EHDSC1 = "EHDSC1";

        /// <summary>
        /// EHLINE.
        /// </summary>
        public const string EHLINE = "EHLINE";

        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHOPSQ.
        /// </summary>
        public const string EHOPSQ = "EHOPSQ";

        /// <summary>
        /// EHUEFFD.
        /// </summary>
        public const string EHUEFFD = "EHUEFFD";

        /// <summary>
        /// EHUEFTD.
        /// </summary>
        public const string EHUEFTD = "EHUEFTD";

        /// <summary>
        /// EHBFPF.
        /// </summary>
        public const string EHBFPF = "EHBFPF";

        /// <summary>
        /// EHLAMC.
        /// </summary>
        public const string EHLAMC = "EHLAMC";

        /// <summary>
        /// EHTIMB.
        /// </summary>
        public const string EHTIMB = "EHTIMB";

        /// <summary>
        /// EHOPSR.
        /// </summary>
        public const string EHOPSR = "EHOPSR";

        /// <summary>
        /// EHBQTY.
        /// </summary>
        public const string EHBQTY = "EHBQTY";

        /// <summary>
        /// EHUOM.
        /// </summary>
        public const string EHUOM = "EHUOM";

        /// <summary>
        /// EHRUNM.
        /// </summary>
        public const string EHRUNM = "EHRUNM";

        /// <summary>
        /// EHERUNM.
        /// </summary>
        public const string EHERUNM = "EHERUNM";

        /// <summary>
        /// EHRUNL.
        /// </summary>
        public const string EHRUNL = "EHRUNL";

        /// <summary>
        /// EHERUNL.
        /// </summary>
        public const string EHERUNL = "EHERUNL";

        /// <summary>
        /// EHSETL.
        /// </summary>
        public const string EHSETL = "EHSETL";

        /// <summary>
        /// EHSETC.
        /// </summary>
        public const string EHSETC = "EHSETC";

        /// <summary>
        /// EHMOVD.
        /// </summary>
        public const string EHMOVD = "EHMOVD";

        /// <summary>
        /// EHQUED.
        /// </summary>
        public const string EHQUED = "EHQUED";

        /// <summary>
        /// EHPOVR.
        /// </summary>
        public const string EHPOVR = "EHPOVR";

        /// <summary>
        /// EHNXOP.
        /// </summary>
        public const string EHNXOP = "EHNXOP";

        /// <summary>
        /// EHOPYP.
        /// </summary>
        public const string EHOPYP = "EHOPYP";

        /// <summary>
        /// EHCPYP.
        /// </summary>
        public const string EHCPYP = "EHCPYP";

        /// <summary>
        /// EHAPID.
        /// </summary>
        public const string EHAPID = "EHAPID";

        /// <summary>
        /// EHOPSC.
        /// </summary>
        public const string EHOPSC = "EHOPSC";

        /// <summary>
        /// EHJBCD.
        /// </summary>
        public const string EHJBCD = "EHJBCD";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHVEND.
        /// </summary>
        public const string EHVEND = "EHVEND";

        /// <summary>
        /// EHPOY.
        /// </summary>
        public const string EHPOY = "EHPOY";

        /// <summary>
        /// EHCOST.
        /// </summary>
        public const string EHCOST = "EHCOST";

        /// <summary>
        /// EHOMCU.
        /// </summary>
        public const string EHOMCU = "EHOMCU";

        /// <summary>
        /// EHOBJ.
        /// </summary>
        public const string EHOBJ = "EHOBJ";

        /// <summary>
        /// EHRREV.
        /// </summary>
        public const string EHRREV = "EHRREV";

        /// <summary>
        /// EHSUB.
        /// </summary>
        public const string EHSUB = "EHSUB";

        /// <summary>
        /// EHWMCU.
        /// </summary>
        public const string EHWMCU = "EHWMCU";

        /// <summary>
        /// EHLOCN.
        /// </summary>
        public const string EHLOCN = "EHLOCN";

        /// <summary>
        /// EHCMPE.
        /// </summary>
        public const string EHCMPE = "EHCMPE";

        /// <summary>
        /// EHCMPC.
        /// </summary>
        public const string EHCMPC = "EHCMPC";

        /// <summary>
        /// EHCPLVLFR.
        /// </summary>
        public const string EHCPLVLFR = "EHCPLVLFR";

        /// <summary>
        /// EHCPLVLTO.
        /// </summary>
        public const string EHCPLVLTO = "EHCPLVLTO";

        /// <summary>
        /// EHITM.
        /// </summary>
        public const string EHITM = "EHITM";

        /// <summary>
        /// EHCMCU.
        /// </summary>
        public const string EHCMCU = "EHCMCU";

        /// <summary>
        /// EHBQTE1.
        /// </summary>
        public const string EHBQTE1 = "EHBQTE1";

        /// <summary>
        /// EHLROUT.
        /// </summary>
        public const string EHLROUT = "EHLROUT";

        /// <summary>
        /// EHDFMLINE.
        /// </summary>
        public const string EHDFMLINE = "EHDFMLINE";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHMKEY.
        /// </summary>
        public const string EHMKEY = "EHMKEY";

        /// <summary>
        /// EHUUPMJ.
        /// </summary>
        public const string EHUUPMJ = "EHUUPMJ";

        /// <summary>
        /// EHRUNLEX.
        /// </summary>
        public const string EHRUNLEX = "EHRUNLEX";

        /// <summary>
        /// EHRUNMEX.
        /// </summary>
        public const string EHRUNMEX = "EHRUNMEX";
    }

    /// <inheritdoc />
    public override string TableName => "F300311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHTRT", "EHTRT", JdeDataType.String, 6),
        new JdeField("EHKIT", "EHKIT", JdeDataType.Numeric),
        new JdeField("EHMMCU", "EHMMCU", JdeDataType.String, 24),
        new JdeField("EHDSC1", "EHDSC1", JdeDataType.String, 60),
        new JdeField("EHLINE", "EHLINE", JdeDataType.String, 24),
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24),
        new JdeField("EHOPSQ", "EHOPSQ", JdeDataType.Numeric),
        new JdeField("EHUEFFD", "EHUEFFD", JdeDataType.Date),
        new JdeField("EHUEFTD", "EHUEFTD", JdeDataType.Date),
        new JdeField("EHBFPF", "EHBFPF", JdeDataType.String, 2),
        new JdeField("EHLAMC", "EHLAMC", JdeDataType.String, 2),
        new JdeField("EHTIMB", "EHTIMB", JdeDataType.String, 2),
        new JdeField("EHOPSR", "EHOPSR", JdeDataType.Numeric),
        new JdeField("EHBQTY", "EHBQTY", JdeDataType.Numeric),
        new JdeField("EHUOM", "EHUOM", JdeDataType.String, 4),
        new JdeField("EHRUNM", "EHRUNM", JdeDataType.Numeric),
        new JdeField("EHERUNM", "EHERUNM", JdeDataType.Numeric),
        new JdeField("EHRUNL", "EHRUNL", JdeDataType.Numeric),
        new JdeField("EHERUNL", "EHERUNL", JdeDataType.Numeric),
        new JdeField("EHSETL", "EHSETL", JdeDataType.Numeric),
        new JdeField("EHSETC", "EHSETC", JdeDataType.Numeric),
        new JdeField("EHMOVD", "EHMOVD", JdeDataType.Numeric),
        new JdeField("EHQUED", "EHQUED", JdeDataType.Numeric),
        new JdeField("EHPOVR", "EHPOVR", JdeDataType.Numeric),
        new JdeField("EHNXOP", "EHNXOP", JdeDataType.Numeric),
        new JdeField("EHOPYP", "EHOPYP", JdeDataType.Numeric),
        new JdeField("EHCPYP", "EHCPYP", JdeDataType.Numeric),
        new JdeField("EHAPID", "EHAPID", JdeDataType.String, 24),
        new JdeField("EHOPSC", "EHOPSC", JdeDataType.String, 4),
        new JdeField("EHJBCD", "EHJBCD", JdeDataType.String, 12),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHVEND", "EHVEND", JdeDataType.Numeric),
        new JdeField("EHPOY", "EHPOY", JdeDataType.String, 2),
        new JdeField("EHCOST", "EHCOST", JdeDataType.String, 6),
        new JdeField("EHOMCU", "EHOMCU", JdeDataType.String, 24),
        new JdeField("EHOBJ", "EHOBJ", JdeDataType.String, 12),
        new JdeField("EHRREV", "EHRREV", JdeDataType.String, 6),
        new JdeField("EHSUB", "EHSUB", JdeDataType.String, 16),
        new JdeField("EHWMCU", "EHWMCU", JdeDataType.String, 24),
        new JdeField("EHLOCN", "EHLOCN", JdeDataType.String, 40),
        new JdeField("EHCMPE", "EHCMPE", JdeDataType.String, 6),
        new JdeField("EHCMPC", "EHCMPC", JdeDataType.String, 20),
        new JdeField("EHCPLVLFR", "EHCPLVLFR", JdeDataType.Numeric),
        new JdeField("EHCPLVLTO", "EHCPLVLTO", JdeDataType.Numeric),
        new JdeField("EHITM", "EHITM", JdeDataType.Numeric),
        new JdeField("EHCMCU", "EHCMCU", JdeDataType.String, 24),
        new JdeField("EHBQTE1", "EHBQTE1", JdeDataType.Numeric),
        new JdeField("EHLROUT", "EHLROUT", JdeDataType.Numeric),
        new JdeField("EHDFMLINE", "EHDFMLINE", JdeDataType.String, 24),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHMKEY", "EHMKEY", JdeDataType.String, 30),
        new JdeField("EHUUPMJ", "EHUUPMJ", JdeDataType.Date),
        new JdeField("EHRUNLEX", "EHRUNLEX", JdeDataType.Numeric),
        new JdeField("EHRUNMEX", "EHRUNMEX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F300311_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F300311_2", "Index on EHKIT, EHMMCU, EHTRT, EHBQTY, EHITM, EHCMCU, EHBQTE1, EHDFMLINE", new[] { "EHKIT", "EHMMCU", "EHTRT", "EHBQTY", "EHITM", "EHCMCU", "EHBQTE1", "EHDFMLINE" }),
        new JdeIndex("F300311_3", "Index on EHKIT, EHMMCU, EHITM, EHDFMLINE, EHBQTE1, EHUOM", new[] { "EHKIT", "EHMMCU", "EHITM", "EHDFMLINE", "EHBQTE1", "EHUOM" }),
        new JdeIndex("F300311_4", "Index on EHKIT, EHDFMLINE, EHMMCU, EHTRT", new[] { "EHKIT", "EHDFMLINE", "EHMMCU", "EHTRT" })
    };
}
