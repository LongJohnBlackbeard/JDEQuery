using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31112 - .
/// </summary>
public class FF31112 : JdeTable
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
        /// EHDFMLINE.
        /// </summary>
        public const string EHDFMLINE = "EHDFMLINE";

        /// <summary>
        /// EHPRODF31.
        /// </summary>
        public const string EHPRODF31 = "EHPRODF31";

        /// <summary>
        /// EHMTID.
        /// </summary>
        public const string EHMTID = "EHMTID";

        /// <summary>
        /// EHTRSID.
        /// </summary>
        public const string EHTRSID = "EHTRSID";

        /// <summary>
        /// EHLTDATE.
        /// </summary>
        public const string EHLTDATE = "EHLTDATE";

        /// <summary>
        /// EHUCNDJ.
        /// </summary>
        public const string EHUCNDJ = "EHUCNDJ";

        /// <summary>
        /// EHUEFFD.
        /// </summary>
        public const string EHUEFFD = "EHUEFFD";

        /// <summary>
        /// EHUEFTD.
        /// </summary>
        public const string EHUEFTD = "EHUEFTD";

        /// <summary>
        /// EHBQTE1.
        /// </summary>
        public const string EHBQTE1 = "EHBQTE1";

        /// <summary>
        /// EHJBCD.
        /// </summary>
        public const string EHJBCD = "EHJBCD";

        /// <summary>
        /// EHTRT.
        /// </summary>
        public const string EHTRT = "EHTRT";

        /// <summary>
        /// EHKIT.
        /// </summary>
        public const string EHKIT = "EHKIT";

        /// <summary>
        /// EHITM.
        /// </summary>
        public const string EHITM = "EHITM";

        /// <summary>
        /// EHLITM.
        /// </summary>
        public const string EHLITM = "EHLITM";

        /// <summary>
        /// EHAITM.
        /// </summary>
        public const string EHAITM = "EHAITM";

        /// <summary>
        /// EHLROUT.
        /// </summary>
        public const string EHLROUT = "EHLROUT";

        /// <summary>
        /// EHERUNL.
        /// </summary>
        public const string EHERUNL = "EHERUNL";

        /// <summary>
        /// EHCMHR.
        /// </summary>
        public const string EHCMHR = "EHCMHR";

        /// <summary>
        /// EHCLHR.
        /// </summary>
        public const string EHCLHR = "EHCLHR";

        /// <summary>
        /// EHCSHR.
        /// </summary>
        public const string EHCSHR = "EHCSHR";

        /// <summary>
        /// EHMMCU.
        /// </summary>
        public const string EHMMCU = "EHMMCU";

        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHLINE.
        /// </summary>
        public const string EHLINE = "EHLINE";

        /// <summary>
        /// EHDSC1.
        /// </summary>
        public const string EHDSC1 = "EHDSC1";

        /// <summary>
        /// EHOPSC.
        /// </summary>
        public const string EHOPSC = "EHOPSC";

        /// <summary>
        /// EHTIMB.
        /// </summary>
        public const string EHTIMB = "EHTIMB";

        /// <summary>
        /// EHLAMC.
        /// </summary>
        public const string EHLAMC = "EHLAMC";

        /// <summary>
        /// EHINPE.
        /// </summary>
        public const string EHINPE = "EHINPE";

        /// <summary>
        /// EHBFPF.
        /// </summary>
        public const string EHBFPF = "EHBFPF";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHRREV.
        /// </summary>
        public const string EHRREV = "EHRREV";

        /// <summary>
        /// EHVEND.
        /// </summary>
        public const string EHVEND = "EHVEND";

        /// <summary>
        /// EHPOVR.
        /// </summary>
        public const string EHPOVR = "EHPOVR";

        /// <summary>
        /// EHOPYP.
        /// </summary>
        public const string EHOPYP = "EHOPYP";

        /// <summary>
        /// EHCPYP.
        /// </summary>
        public const string EHCPYP = "EHCPYP";

        /// <summary>
        /// EHOBJ.
        /// </summary>
        public const string EHOBJ = "EHOBJ";

        /// <summary>
        /// EHSUB.
        /// </summary>
        public const string EHSUB = "EHSUB";

        /// <summary>
        /// EHPOY.
        /// </summary>
        public const string EHPOY = "EHPOY";

        /// <summary>
        /// EHOMCU.
        /// </summary>
        public const string EHOMCU = "EHOMCU";

        /// <summary>
        /// EHUORG.
        /// </summary>
        public const string EHUORG = "EHUORG";

        /// <summary>
        /// EHAPID.
        /// </summary>
        public const string EHAPID = "EHAPID";

        /// <summary>
        /// EHNXOP.
        /// </summary>
        public const string EHNXOP = "EHNXOP";

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
        /// EHERUNM.
        /// </summary>
        public const string EHERUNM = "EHERUNM";

        /// <summary>
        /// EHRUNM.
        /// </summary>
        public const string EHRUNM = "EHRUNM";

        /// <summary>
        /// EHRUNL.
        /// </summary>
        public const string EHRUNL = "EHRUNL";

        /// <summary>
        /// EHSETL.
        /// </summary>
        public const string EHSETL = "EHSETL";

        /// <summary>
        /// EHOPSR.
        /// </summary>
        public const string EHOPSR = "EHOPSR";

        /// <summary>
        /// EHQMTO.
        /// </summary>
        public const string EHQMTO = "EHQMTO";

        /// <summary>
        /// EHOPSQ.
        /// </summary>
        public const string EHOPSQ = "EHOPSQ";

        /// <summary>
        /// EHCOST.
        /// </summary>
        public const string EHCOST = "EHCOST";

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
        /// EHCMPE.
        /// </summary>
        public const string EHCMPE = "EHCMPE";

        /// <summary>
        /// EHWMCU.
        /// </summary>
        public const string EHWMCU = "EHWMCU";

        /// <summary>
        /// EHUM.
        /// </summary>
        public const string EHUM = "EHUM";

        /// <summary>
        /// EHLOCN.
        /// </summary>
        public const string EHLOCN = "EHLOCN";

        /// <summary>
        /// EHPPRF.
        /// </summary>
        public const string EHPPRF = "EHPPRF";

        /// <summary>
        /// EHRCTO.
        /// </summary>
        public const string EHRCTO = "EHRCTO";

        /// <summary>
        /// EHRLLN.
        /// </summary>
        public const string EHRLLN = "EHRLLN";

        /// <summary>
        /// EHRORN.
        /// </summary>
        public const string EHRORN = "EHRORN";

        /// <summary>
        /// EHRKCO.
        /// </summary>
        public const string EHRKCO = "EHRKCO";

        /// <summary>
        /// EHUOM.
        /// </summary>
        public const string EHUOM = "EHUOM";

        /// <summary>
        /// EHCSFT.
        /// </summary>
        public const string EHCSFT = "EHCSFT";

        /// <summary>
        /// EHSSFT.
        /// </summary>
        public const string EHSSFT = "EHSSFT";

        /// <summary>
        /// EHRSFT.
        /// </summary>
        public const string EHRSFT = "EHRSFT";

        /// <summary>
        /// EHSOQS.
        /// </summary>
        public const string EHSOQS = "EHSOQS";

        /// <summary>
        /// EHSOCN.
        /// </summary>
        public const string EHSOCN = "EHSOCN";

        /// <summary>
        /// EHRTRST.
        /// </summary>
        public const string EHRTRST = "EHRTRST";

        /// <summary>
        /// EHTUSER.
        /// </summary>
        public const string EHTUSER = "EHTUSER";

        /// <summary>
        /// EHCUSER.
        /// </summary>
        public const string EHCUSER = "EHCUSER";

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
        /// EHTRSTS.
        /// </summary>
        public const string EHTRSTS = "EHTRSTS";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHMKEY.
        /// </summary>
        public const string EHMKEY = "EHMKEY";

        /// <summary>
        /// EHUUPMJ.
        /// </summary>
        public const string EHUUPMJ = "EHUUPMJ";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHRUNLEX.
        /// </summary>
        public const string EHRUNLEX = "EHRUNLEX";

        /// <summary>
        /// EHRUNMEX.
        /// </summary>
        public const string EHRUNMEX = "EHRUNMEX";

        /// <summary>
        /// EHRUNLCU.
        /// </summary>
        public const string EHRUNLCU = "EHRUNLCU";

        /// <summary>
        /// EHRUNMCU.
        /// </summary>
        public const string EHRUNMCU = "EHRUNMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF31112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDFMLINE", "EHDFMLINE", JdeDataType.String, 24),
        new JdeField("EHPRODF31", "EHPRODF31", JdeDataType.Numeric),
        new JdeField("EHMTID", "EHMTID", JdeDataType.Numeric),
        new JdeField("EHTRSID", "EHTRSID", JdeDataType.Numeric),
        new JdeField("EHLTDATE", "EHLTDATE", JdeDataType.Date),
        new JdeField("EHUCNDJ", "EHUCNDJ", JdeDataType.Date),
        new JdeField("EHUEFFD", "EHUEFFD", JdeDataType.Date),
        new JdeField("EHUEFTD", "EHUEFTD", JdeDataType.Date),
        new JdeField("EHBQTE1", "EHBQTE1", JdeDataType.Numeric),
        new JdeField("EHJBCD", "EHJBCD", JdeDataType.String, 12),
        new JdeField("EHTRT", "EHTRT", JdeDataType.String, 6),
        new JdeField("EHKIT", "EHKIT", JdeDataType.Numeric),
        new JdeField("EHITM", "EHITM", JdeDataType.Numeric),
        new JdeField("EHLITM", "EHLITM", JdeDataType.String, 50),
        new JdeField("EHAITM", "EHAITM", JdeDataType.String, 50),
        new JdeField("EHLROUT", "EHLROUT", JdeDataType.Numeric),
        new JdeField("EHERUNL", "EHERUNL", JdeDataType.Numeric),
        new JdeField("EHCMHR", "EHCMHR", JdeDataType.Numeric),
        new JdeField("EHCLHR", "EHCLHR", JdeDataType.Numeric),
        new JdeField("EHCSHR", "EHCSHR", JdeDataType.Numeric),
        new JdeField("EHMMCU", "EHMMCU", JdeDataType.String, 24),
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24),
        new JdeField("EHLINE", "EHLINE", JdeDataType.String, 24),
        new JdeField("EHDSC1", "EHDSC1", JdeDataType.String, 60),
        new JdeField("EHOPSC", "EHOPSC", JdeDataType.String, 4),
        new JdeField("EHTIMB", "EHTIMB", JdeDataType.String, 2),
        new JdeField("EHLAMC", "EHLAMC", JdeDataType.String, 2),
        new JdeField("EHINPE", "EHINPE", JdeDataType.String, 4),
        new JdeField("EHBFPF", "EHBFPF", JdeDataType.String, 2),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHRREV", "EHRREV", JdeDataType.String, 6),
        new JdeField("EHVEND", "EHVEND", JdeDataType.Numeric),
        new JdeField("EHPOVR", "EHPOVR", JdeDataType.Numeric),
        new JdeField("EHOPYP", "EHOPYP", JdeDataType.Numeric),
        new JdeField("EHCPYP", "EHCPYP", JdeDataType.Numeric),
        new JdeField("EHOBJ", "EHOBJ", JdeDataType.String, 12),
        new JdeField("EHSUB", "EHSUB", JdeDataType.String, 16),
        new JdeField("EHPOY", "EHPOY", JdeDataType.String, 2),
        new JdeField("EHOMCU", "EHOMCU", JdeDataType.String, 24),
        new JdeField("EHUORG", "EHUORG", JdeDataType.Numeric),
        new JdeField("EHAPID", "EHAPID", JdeDataType.String, 24),
        new JdeField("EHNXOP", "EHNXOP", JdeDataType.Numeric),
        new JdeField("EHSETC", "EHSETC", JdeDataType.Numeric),
        new JdeField("EHMOVD", "EHMOVD", JdeDataType.Numeric),
        new JdeField("EHQUED", "EHQUED", JdeDataType.Numeric),
        new JdeField("EHERUNM", "EHERUNM", JdeDataType.Numeric),
        new JdeField("EHRUNM", "EHRUNM", JdeDataType.Numeric),
        new JdeField("EHRUNL", "EHRUNL", JdeDataType.Numeric),
        new JdeField("EHSETL", "EHSETL", JdeDataType.Numeric),
        new JdeField("EHOPSR", "EHOPSR", JdeDataType.Numeric),
        new JdeField("EHQMTO", "EHQMTO", JdeDataType.Numeric),
        new JdeField("EHOPSQ", "EHOPSQ", JdeDataType.Numeric),
        new JdeField("EHCOST", "EHCOST", JdeDataType.String, 6),
        new JdeField("EHCMPC", "EHCMPC", JdeDataType.String, 20),
        new JdeField("EHCPLVLFR", "EHCPLVLFR", JdeDataType.Numeric),
        new JdeField("EHCPLVLTO", "EHCPLVLTO", JdeDataType.Numeric),
        new JdeField("EHCMPE", "EHCMPE", JdeDataType.String, 6),
        new JdeField("EHWMCU", "EHWMCU", JdeDataType.String, 24),
        new JdeField("EHUM", "EHUM", JdeDataType.String, 4),
        new JdeField("EHLOCN", "EHLOCN", JdeDataType.String, 40),
        new JdeField("EHPPRF", "EHPPRF", JdeDataType.String, 2),
        new JdeField("EHRCTO", "EHRCTO", JdeDataType.String, 4),
        new JdeField("EHRLLN", "EHRLLN", JdeDataType.Numeric),
        new JdeField("EHRORN", "EHRORN", JdeDataType.String, 16),
        new JdeField("EHRKCO", "EHRKCO", JdeDataType.String, 10),
        new JdeField("EHUOM", "EHUOM", JdeDataType.String, 4),
        new JdeField("EHCSFT", "EHCSFT", JdeDataType.String, 2),
        new JdeField("EHSSFT", "EHSSFT", JdeDataType.String, 2),
        new JdeField("EHRSFT", "EHRSFT", JdeDataType.String, 2),
        new JdeField("EHSOQS", "EHSOQS", JdeDataType.Numeric),
        new JdeField("EHSOCN", "EHSOCN", JdeDataType.Numeric),
        new JdeField("EHRTRST", "EHRTRST", JdeDataType.String, 2),
        new JdeField("EHTUSER", "EHTUSER", JdeDataType.String, 20),
        new JdeField("EHCUSER", "EHCUSER", JdeDataType.String, 20),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHTRSTS", "EHTRSTS", JdeDataType.String, 4),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHMKEY", "EHMKEY", JdeDataType.String, 30),
        new JdeField("EHUUPMJ", "EHUUPMJ", JdeDataType.Date),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHRUNLEX", "EHRUNLEX", JdeDataType.Numeric),
        new JdeField("EHRUNMEX", "EHRUNMEX", JdeDataType.Numeric),
        new JdeField("EHRUNLCU", "EHRUNLCU", JdeDataType.Numeric),
        new JdeField("EHRUNMCU", "EHRUNMCU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31112_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31112_2", "Index on EHPRODF31, EHTRSID, EHOPSQ, EHOPSC, EHMCU", new[] { "EHPRODF31", "EHTRSID", "EHOPSQ", "EHOPSC", "EHMCU" }),
        new JdeIndex("FF31112_3", "Index on EHPRODF31, EHMTID", new[] { "EHPRODF31", "EHMTID" })
    };
}
