using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31112S - .
/// </summary>
public class FF31112S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETUKID.
        /// </summary>
        public const string ETUKID = "ETUKID";

        /// <summary>
        /// ETDFMLINE.
        /// </summary>
        public const string ETDFMLINE = "ETDFMLINE";

        /// <summary>
        /// ETPRODF31.
        /// </summary>
        public const string ETPRODF31 = "ETPRODF31";

        /// <summary>
        /// ETMTID.
        /// </summary>
        public const string ETMTID = "ETMTID";

        /// <summary>
        /// ETTRSID.
        /// </summary>
        public const string ETTRSID = "ETTRSID";

        /// <summary>
        /// ETLTDATE.
        /// </summary>
        public const string ETLTDATE = "ETLTDATE";

        /// <summary>
        /// ETUCNDJ.
        /// </summary>
        public const string ETUCNDJ = "ETUCNDJ";

        /// <summary>
        /// ETUEFFD.
        /// </summary>
        public const string ETUEFFD = "ETUEFFD";

        /// <summary>
        /// ETUEFTD.
        /// </summary>
        public const string ETUEFTD = "ETUEFTD";

        /// <summary>
        /// ETBQTE1.
        /// </summary>
        public const string ETBQTE1 = "ETBQTE1";

        /// <summary>
        /// ETJBCD.
        /// </summary>
        public const string ETJBCD = "ETJBCD";

        /// <summary>
        /// ETTRT.
        /// </summary>
        public const string ETTRT = "ETTRT";

        /// <summary>
        /// ETKIT.
        /// </summary>
        public const string ETKIT = "ETKIT";

        /// <summary>
        /// ETITM.
        /// </summary>
        public const string ETITM = "ETITM";

        /// <summary>
        /// ETLITM.
        /// </summary>
        public const string ETLITM = "ETLITM";

        /// <summary>
        /// ETAITM.
        /// </summary>
        public const string ETAITM = "ETAITM";

        /// <summary>
        /// ETLROUT.
        /// </summary>
        public const string ETLROUT = "ETLROUT";

        /// <summary>
        /// ETERUNL.
        /// </summary>
        public const string ETERUNL = "ETERUNL";

        /// <summary>
        /// ETCMHR.
        /// </summary>
        public const string ETCMHR = "ETCMHR";

        /// <summary>
        /// ETCLHR.
        /// </summary>
        public const string ETCLHR = "ETCLHR";

        /// <summary>
        /// ETCSHR.
        /// </summary>
        public const string ETCSHR = "ETCSHR";

        /// <summary>
        /// ETMMCU.
        /// </summary>
        public const string ETMMCU = "ETMMCU";

        /// <summary>
        /// ETMCU.
        /// </summary>
        public const string ETMCU = "ETMCU";

        /// <summary>
        /// ETLINE.
        /// </summary>
        public const string ETLINE = "ETLINE";

        /// <summary>
        /// ETDSC1.
        /// </summary>
        public const string ETDSC1 = "ETDSC1";

        /// <summary>
        /// ETOPSC.
        /// </summary>
        public const string ETOPSC = "ETOPSC";

        /// <summary>
        /// ETTIMB.
        /// </summary>
        public const string ETTIMB = "ETTIMB";

        /// <summary>
        /// ETLAMC.
        /// </summary>
        public const string ETLAMC = "ETLAMC";

        /// <summary>
        /// ETINPE.
        /// </summary>
        public const string ETINPE = "ETINPE";

        /// <summary>
        /// ETBFPF.
        /// </summary>
        public const string ETBFPF = "ETBFPF";

        /// <summary>
        /// ETAN8.
        /// </summary>
        public const string ETAN8 = "ETAN8";

        /// <summary>
        /// ETRREV.
        /// </summary>
        public const string ETRREV = "ETRREV";

        /// <summary>
        /// ETVEND.
        /// </summary>
        public const string ETVEND = "ETVEND";

        /// <summary>
        /// ETPOVR.
        /// </summary>
        public const string ETPOVR = "ETPOVR";

        /// <summary>
        /// ETOPYP.
        /// </summary>
        public const string ETOPYP = "ETOPYP";

        /// <summary>
        /// ETCPYP.
        /// </summary>
        public const string ETCPYP = "ETCPYP";

        /// <summary>
        /// ETOBJ.
        /// </summary>
        public const string ETOBJ = "ETOBJ";

        /// <summary>
        /// ETSUB.
        /// </summary>
        public const string ETSUB = "ETSUB";

        /// <summary>
        /// ETPOY.
        /// </summary>
        public const string ETPOY = "ETPOY";

        /// <summary>
        /// ETOMCU.
        /// </summary>
        public const string ETOMCU = "ETOMCU";

        /// <summary>
        /// ETUORG.
        /// </summary>
        public const string ETUORG = "ETUORG";

        /// <summary>
        /// ETAPID.
        /// </summary>
        public const string ETAPID = "ETAPID";

        /// <summary>
        /// ETNXOP.
        /// </summary>
        public const string ETNXOP = "ETNXOP";

        /// <summary>
        /// ETSETC.
        /// </summary>
        public const string ETSETC = "ETSETC";

        /// <summary>
        /// ETMOVD.
        /// </summary>
        public const string ETMOVD = "ETMOVD";

        /// <summary>
        /// ETQUED.
        /// </summary>
        public const string ETQUED = "ETQUED";

        /// <summary>
        /// ETERUNM.
        /// </summary>
        public const string ETERUNM = "ETERUNM";

        /// <summary>
        /// ETRUNM.
        /// </summary>
        public const string ETRUNM = "ETRUNM";

        /// <summary>
        /// ETRUNL.
        /// </summary>
        public const string ETRUNL = "ETRUNL";

        /// <summary>
        /// ETSETL.
        /// </summary>
        public const string ETSETL = "ETSETL";

        /// <summary>
        /// ETOPSR.
        /// </summary>
        public const string ETOPSR = "ETOPSR";

        /// <summary>
        /// ETQMTO.
        /// </summary>
        public const string ETQMTO = "ETQMTO";

        /// <summary>
        /// ETOPSQ.
        /// </summary>
        public const string ETOPSQ = "ETOPSQ";

        /// <summary>
        /// ETCOST.
        /// </summary>
        public const string ETCOST = "ETCOST";

        /// <summary>
        /// ETCMPC.
        /// </summary>
        public const string ETCMPC = "ETCMPC";

        /// <summary>
        /// ETCPLVLFR.
        /// </summary>
        public const string ETCPLVLFR = "ETCPLVLFR";

        /// <summary>
        /// ETCPLVLTO.
        /// </summary>
        public const string ETCPLVLTO = "ETCPLVLTO";

        /// <summary>
        /// ETCMPE.
        /// </summary>
        public const string ETCMPE = "ETCMPE";

        /// <summary>
        /// ETWMCU.
        /// </summary>
        public const string ETWMCU = "ETWMCU";

        /// <summary>
        /// ETUM.
        /// </summary>
        public const string ETUM = "ETUM";

        /// <summary>
        /// ETLOCN.
        /// </summary>
        public const string ETLOCN = "ETLOCN";

        /// <summary>
        /// ETPPRF.
        /// </summary>
        public const string ETPPRF = "ETPPRF";

        /// <summary>
        /// ETRCTO.
        /// </summary>
        public const string ETRCTO = "ETRCTO";

        /// <summary>
        /// ETRLLN.
        /// </summary>
        public const string ETRLLN = "ETRLLN";

        /// <summary>
        /// ETRORN.
        /// </summary>
        public const string ETRORN = "ETRORN";

        /// <summary>
        /// ETRKCO.
        /// </summary>
        public const string ETRKCO = "ETRKCO";

        /// <summary>
        /// ETUOM.
        /// </summary>
        public const string ETUOM = "ETUOM";

        /// <summary>
        /// ETCSFT.
        /// </summary>
        public const string ETCSFT = "ETCSFT";

        /// <summary>
        /// ETSSFT.
        /// </summary>
        public const string ETSSFT = "ETSSFT";

        /// <summary>
        /// ETRSFT.
        /// </summary>
        public const string ETRSFT = "ETRSFT";

        /// <summary>
        /// ETSOQS.
        /// </summary>
        public const string ETSOQS = "ETSOQS";

        /// <summary>
        /// ETSOCN.
        /// </summary>
        public const string ETSOCN = "ETSOCN";

        /// <summary>
        /// ETRTRST.
        /// </summary>
        public const string ETRTRST = "ETRTRST";

        /// <summary>
        /// ETTUSER.
        /// </summary>
        public const string ETTUSER = "ETTUSER";

        /// <summary>
        /// ETCUSER.
        /// </summary>
        public const string ETCUSER = "ETCUSER";

        /// <summary>
        /// ETURCD.
        /// </summary>
        public const string ETURCD = "ETURCD";

        /// <summary>
        /// ETURDT.
        /// </summary>
        public const string ETURDT = "ETURDT";

        /// <summary>
        /// ETURAT.
        /// </summary>
        public const string ETURAT = "ETURAT";

        /// <summary>
        /// ETURRF.
        /// </summary>
        public const string ETURRF = "ETURRF";

        /// <summary>
        /// ETTRSTS.
        /// </summary>
        public const string ETTRSTS = "ETTRSTS";

        /// <summary>
        /// ETURAB.
        /// </summary>
        public const string ETURAB = "ETURAB";

        /// <summary>
        /// ETMKEY.
        /// </summary>
        public const string ETMKEY = "ETMKEY";

        /// <summary>
        /// ETUUPMJ.
        /// </summary>
        public const string ETUUPMJ = "ETUUPMJ";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETPID.
        /// </summary>
        public const string ETPID = "ETPID";

        /// <summary>
        /// ETRUNLEX.
        /// </summary>
        public const string ETRUNLEX = "ETRUNLEX";

        /// <summary>
        /// ETRUNMEX.
        /// </summary>
        public const string ETRUNMEX = "ETRUNMEX";

        /// <summary>
        /// ETRUNLCU.
        /// </summary>
        public const string ETRUNLCU = "ETRUNLCU";

        /// <summary>
        /// ETRUNMCU.
        /// </summary>
        public const string ETRUNMCU = "ETRUNMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF31112S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETUKID", "ETUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ETDFMLINE", "ETDFMLINE", JdeDataType.String, 24),
        new JdeField("ETPRODF31", "ETPRODF31", JdeDataType.Numeric),
        new JdeField("ETMTID", "ETMTID", JdeDataType.Numeric),
        new JdeField("ETTRSID", "ETTRSID", JdeDataType.Numeric),
        new JdeField("ETLTDATE", "ETLTDATE", JdeDataType.Date),
        new JdeField("ETUCNDJ", "ETUCNDJ", JdeDataType.Date),
        new JdeField("ETUEFFD", "ETUEFFD", JdeDataType.Date),
        new JdeField("ETUEFTD", "ETUEFTD", JdeDataType.Date),
        new JdeField("ETBQTE1", "ETBQTE1", JdeDataType.Numeric),
        new JdeField("ETJBCD", "ETJBCD", JdeDataType.String, 12),
        new JdeField("ETTRT", "ETTRT", JdeDataType.String, 6),
        new JdeField("ETKIT", "ETKIT", JdeDataType.Numeric),
        new JdeField("ETITM", "ETITM", JdeDataType.Numeric),
        new JdeField("ETLITM", "ETLITM", JdeDataType.String, 50),
        new JdeField("ETAITM", "ETAITM", JdeDataType.String, 50),
        new JdeField("ETLROUT", "ETLROUT", JdeDataType.Numeric),
        new JdeField("ETERUNL", "ETERUNL", JdeDataType.Numeric),
        new JdeField("ETCMHR", "ETCMHR", JdeDataType.Numeric),
        new JdeField("ETCLHR", "ETCLHR", JdeDataType.Numeric),
        new JdeField("ETCSHR", "ETCSHR", JdeDataType.Numeric),
        new JdeField("ETMMCU", "ETMMCU", JdeDataType.String, 24),
        new JdeField("ETMCU", "ETMCU", JdeDataType.String, 24),
        new JdeField("ETLINE", "ETLINE", JdeDataType.String, 24),
        new JdeField("ETDSC1", "ETDSC1", JdeDataType.String, 60),
        new JdeField("ETOPSC", "ETOPSC", JdeDataType.String, 4),
        new JdeField("ETTIMB", "ETTIMB", JdeDataType.String, 2),
        new JdeField("ETLAMC", "ETLAMC", JdeDataType.String, 2),
        new JdeField("ETINPE", "ETINPE", JdeDataType.String, 4),
        new JdeField("ETBFPF", "ETBFPF", JdeDataType.String, 2),
        new JdeField("ETAN8", "ETAN8", JdeDataType.Numeric),
        new JdeField("ETRREV", "ETRREV", JdeDataType.String, 6),
        new JdeField("ETVEND", "ETVEND", JdeDataType.Numeric),
        new JdeField("ETPOVR", "ETPOVR", JdeDataType.Numeric),
        new JdeField("ETOPYP", "ETOPYP", JdeDataType.Numeric),
        new JdeField("ETCPYP", "ETCPYP", JdeDataType.Numeric),
        new JdeField("ETOBJ", "ETOBJ", JdeDataType.String, 12),
        new JdeField("ETSUB", "ETSUB", JdeDataType.String, 16),
        new JdeField("ETPOY", "ETPOY", JdeDataType.String, 2),
        new JdeField("ETOMCU", "ETOMCU", JdeDataType.String, 24),
        new JdeField("ETUORG", "ETUORG", JdeDataType.Numeric),
        new JdeField("ETAPID", "ETAPID", JdeDataType.String, 24),
        new JdeField("ETNXOP", "ETNXOP", JdeDataType.Numeric),
        new JdeField("ETSETC", "ETSETC", JdeDataType.Numeric),
        new JdeField("ETMOVD", "ETMOVD", JdeDataType.Numeric),
        new JdeField("ETQUED", "ETQUED", JdeDataType.Numeric),
        new JdeField("ETERUNM", "ETERUNM", JdeDataType.Numeric),
        new JdeField("ETRUNM", "ETRUNM", JdeDataType.Numeric),
        new JdeField("ETRUNL", "ETRUNL", JdeDataType.Numeric),
        new JdeField("ETSETL", "ETSETL", JdeDataType.Numeric),
        new JdeField("ETOPSR", "ETOPSR", JdeDataType.Numeric),
        new JdeField("ETQMTO", "ETQMTO", JdeDataType.Numeric),
        new JdeField("ETOPSQ", "ETOPSQ", JdeDataType.Numeric),
        new JdeField("ETCOST", "ETCOST", JdeDataType.String, 6),
        new JdeField("ETCMPC", "ETCMPC", JdeDataType.String, 20),
        new JdeField("ETCPLVLFR", "ETCPLVLFR", JdeDataType.Numeric),
        new JdeField("ETCPLVLTO", "ETCPLVLTO", JdeDataType.Numeric),
        new JdeField("ETCMPE", "ETCMPE", JdeDataType.String, 6),
        new JdeField("ETWMCU", "ETWMCU", JdeDataType.String, 24),
        new JdeField("ETUM", "ETUM", JdeDataType.String, 4),
        new JdeField("ETLOCN", "ETLOCN", JdeDataType.String, 40),
        new JdeField("ETPPRF", "ETPPRF", JdeDataType.String, 2),
        new JdeField("ETRCTO", "ETRCTO", JdeDataType.String, 4),
        new JdeField("ETRLLN", "ETRLLN", JdeDataType.Numeric),
        new JdeField("ETRORN", "ETRORN", JdeDataType.String, 16),
        new JdeField("ETRKCO", "ETRKCO", JdeDataType.String, 10),
        new JdeField("ETUOM", "ETUOM", JdeDataType.String, 4),
        new JdeField("ETCSFT", "ETCSFT", JdeDataType.String, 2),
        new JdeField("ETSSFT", "ETSSFT", JdeDataType.String, 2),
        new JdeField("ETRSFT", "ETRSFT", JdeDataType.String, 2),
        new JdeField("ETSOQS", "ETSOQS", JdeDataType.Numeric),
        new JdeField("ETSOCN", "ETSOCN", JdeDataType.Numeric),
        new JdeField("ETRTRST", "ETRTRST", JdeDataType.String, 2),
        new JdeField("ETTUSER", "ETTUSER", JdeDataType.String, 20),
        new JdeField("ETCUSER", "ETCUSER", JdeDataType.String, 20),
        new JdeField("ETURCD", "ETURCD", JdeDataType.String, 4),
        new JdeField("ETURDT", "ETURDT", JdeDataType.Numeric),
        new JdeField("ETURAT", "ETURAT", JdeDataType.Numeric),
        new JdeField("ETURRF", "ETURRF", JdeDataType.String, 30),
        new JdeField("ETTRSTS", "ETTRSTS", JdeDataType.String, 4),
        new JdeField("ETURAB", "ETURAB", JdeDataType.Numeric),
        new JdeField("ETMKEY", "ETMKEY", JdeDataType.String, 30),
        new JdeField("ETUUPMJ", "ETUUPMJ", JdeDataType.Date),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETPID", "ETPID", JdeDataType.String, 20),
        new JdeField("ETRUNLEX", "ETRUNLEX", JdeDataType.Numeric),
        new JdeField("ETRUNMEX", "ETRUNMEX", JdeDataType.Numeric),
        new JdeField("ETRUNLCU", "ETRUNLCU", JdeDataType.Numeric),
        new JdeField("ETRUNMCU", "ETRUNMCU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31112S_0", "Primary Key on ETUKID", new[] { "ETUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31112S_2", "Index on ETPRODF31, ETTRSID, ETOPSQ, ETOPSC, ETMCU", new[] { "ETPRODF31", "ETTRSID", "ETOPSQ", "ETOPSC", "ETMCU" }),
        new JdeIndex("FF31112S_3", "Index on ETPRODF31, ETMTID", new[] { "ETPRODF31", "ETMTID" })
    };
}
