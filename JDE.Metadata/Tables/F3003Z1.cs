using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3003Z1 - .
/// </summary>
public class F3003Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZTRT.
        /// </summary>
        public const string SZTRT = "SZTRT";

        /// <summary>
        /// SZKIT.
        /// </summary>
        public const string SZKIT = "SZKIT";

        /// <summary>
        /// SZKITL.
        /// </summary>
        public const string SZKITL = "SZKITL";

        /// <summary>
        /// SZKITA.
        /// </summary>
        public const string SZKITA = "SZKITA";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZALD.
        /// </summary>
        public const string SZALD = "SZALD";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZLINE.
        /// </summary>
        public const string SZLINE = "SZLINE";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZEFFF.
        /// </summary>
        public const string SZEFFF = "SZEFFF";

        /// <summary>
        /// SZEFFT.
        /// </summary>
        public const string SZEFFT = "SZEFFT";

        /// <summary>
        /// SZBFPF.
        /// </summary>
        public const string SZBFPF = "SZBFPF";

        /// <summary>
        /// SZLAMC.
        /// </summary>
        public const string SZLAMC = "SZLAMC";

        /// <summary>
        /// SZTIMB.
        /// </summary>
        public const string SZTIMB = "SZTIMB";

        /// <summary>
        /// SZOPSR.
        /// </summary>
        public const string SZOPSR = "SZOPSR";

        /// <summary>
        /// SZBQTY.
        /// </summary>
        public const string SZBQTY = "SZBQTY";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZRUNM.
        /// </summary>
        public const string SZRUNM = "SZRUNM";

        /// <summary>
        /// SZRUNL.
        /// </summary>
        public const string SZRUNL = "SZRUNL";

        /// <summary>
        /// SZSETL.
        /// </summary>
        public const string SZSETL = "SZSETL";

        /// <summary>
        /// SZPWRT.
        /// </summary>
        public const string SZPWRT = "SZPWRT";

        /// <summary>
        /// SZSETC.
        /// </summary>
        public const string SZSETC = "SZSETC";

        /// <summary>
        /// SZMOVD.
        /// </summary>
        public const string SZMOVD = "SZMOVD";

        /// <summary>
        /// SZQUED.
        /// </summary>
        public const string SZQUED = "SZQUED";

        /// <summary>
        /// SZLTPC.
        /// </summary>
        public const string SZLTPC = "SZLTPC";

        /// <summary>
        /// SZPOVR.
        /// </summary>
        public const string SZPOVR = "SZPOVR";

        /// <summary>
        /// SZNXOP.
        /// </summary>
        public const string SZNXOP = "SZNXOP";

        /// <summary>
        /// SZCPYP.
        /// </summary>
        public const string SZCPYP = "SZCPYP";

        /// <summary>
        /// SZOPYP.
        /// </summary>
        public const string SZOPYP = "SZOPYP";

        /// <summary>
        /// SZAPID.
        /// </summary>
        public const string SZAPID = "SZAPID";

        /// <summary>
        /// SZSHNO.
        /// </summary>
        public const string SZSHNO = "SZSHNO";

        /// <summary>
        /// SZOPSC.
        /// </summary>
        public const string SZOPSC = "SZOPSC";

        /// <summary>
        /// SZINPE.
        /// </summary>
        public const string SZINPE = "SZINPE";

        /// <summary>
        /// SZJBCD.
        /// </summary>
        public const string SZJBCD = "SZJBCD";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZVEND.
        /// </summary>
        public const string SZVEND = "SZVEND";

        /// <summary>
        /// SZPOY.
        /// </summary>
        public const string SZPOY = "SZPOY";

        /// <summary>
        /// SZCOST.
        /// </summary>
        public const string SZCOST = "SZCOST";

        /// <summary>
        /// SZOMCU.
        /// </summary>
        public const string SZOMCU = "SZOMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZRREV.
        /// </summary>
        public const string SZRREV = "SZRREV";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZRUC.
        /// </summary>
        public const string SZRUC = "SZRUC";

        /// <summary>
        /// SZCAPU.
        /// </summary>
        public const string SZCAPU = "SZCAPU";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZNUMB.
        /// </summary>
        public const string SZNUMB = "SZNUMB";

        /// <summary>
        /// SZWMCU.
        /// </summary>
        public const string SZWMCU = "SZWMCU";

        /// <summary>
        /// SZACTB.
        /// </summary>
        public const string SZACTB = "SZACTB";

        /// <summary>
        /// SZCBCO.
        /// </summary>
        public const string SZCBCO = "SZCBCO";

        /// <summary>
        /// SZCICO.
        /// </summary>
        public const string SZCICO = "SZCICO";

        /// <summary>
        /// SZIMCO.
        /// </summary>
        public const string SZIMCO = "SZIMCO";

        /// <summary>
        /// SZMPRO.
        /// </summary>
        public const string SZMPRO = "SZMPRO";

        /// <summary>
        /// SZAPSC.
        /// </summary>
        public const string SZAPSC = "SZAPSC";

        /// <summary>
        /// SZMNSP.
        /// </summary>
        public const string SZMNSP = "SZMNSP";

        /// <summary>
        /// SZMXSP.
        /// </summary>
        public const string SZMXSP = "SZMXSP";

        /// <summary>
        /// SZCMPE.
        /// </summary>
        public const string SZCMPE = "SZCMPE";

        /// <summary>
        /// SZCMPC.
        /// </summary>
        public const string SZCMPC = "SZCMPC";

        /// <summary>
        /// SZCPLVLFR.
        /// </summary>
        public const string SZCPLVLFR = "SZCPLVLFR";

        /// <summary>
        /// SZCPLVLTO.
        /// </summary>
        public const string SZCPLVLTO = "SZCPLVLTO";

        /// <summary>
        /// SZCMRQ.
        /// </summary>
        public const string SZCMRQ = "SZCMRQ";

        /// <summary>
        /// SZANSA.
        /// </summary>
        public const string SZANSA = "SZANSA";

        /// <summary>
        /// SZANPA.
        /// </summary>
        public const string SZANPA = "SZANPA";

        /// <summary>
        /// SZANP.
        /// </summary>
        public const string SZANP = "SZANP";

        /// <summary>
        /// SZWSCHF.
        /// </summary>
        public const string SZWSCHF = "SZWSCHF";

        /// <summary>
        /// SZTRAF.
        /// </summary>
        public const string SZTRAF = "SZTRAF";
    }

    /// <inheritdoc />
    public override string TableName => "F3003Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZTRT", "SZTRT", JdeDataType.String, 6),
        new JdeField("SZKIT", "SZKIT", JdeDataType.Numeric),
        new JdeField("SZKITL", "SZKITL", JdeDataType.String, 50),
        new JdeField("SZKITA", "SZKITA", JdeDataType.String, 50),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZALD", "SZALD", JdeDataType.String, 8),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZLINE", "SZLINE", JdeDataType.String, 24),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZEFFF", "SZEFFF", JdeDataType.Numeric),
        new JdeField("SZEFFT", "SZEFFT", JdeDataType.Numeric),
        new JdeField("SZBFPF", "SZBFPF", JdeDataType.String, 2),
        new JdeField("SZLAMC", "SZLAMC", JdeDataType.String, 2),
        new JdeField("SZTIMB", "SZTIMB", JdeDataType.String, 2),
        new JdeField("SZOPSR", "SZOPSR", JdeDataType.Numeric),
        new JdeField("SZBQTY", "SZBQTY", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZRUNM", "SZRUNM", JdeDataType.Numeric),
        new JdeField("SZRUNL", "SZRUNL", JdeDataType.Numeric),
        new JdeField("SZSETL", "SZSETL", JdeDataType.Numeric),
        new JdeField("SZPWRT", "SZPWRT", JdeDataType.Numeric),
        new JdeField("SZSETC", "SZSETC", JdeDataType.Numeric),
        new JdeField("SZMOVD", "SZMOVD", JdeDataType.Numeric),
        new JdeField("SZQUED", "SZQUED", JdeDataType.Numeric),
        new JdeField("SZLTPC", "SZLTPC", JdeDataType.Numeric),
        new JdeField("SZPOVR", "SZPOVR", JdeDataType.Numeric),
        new JdeField("SZNXOP", "SZNXOP", JdeDataType.Numeric),
        new JdeField("SZCPYP", "SZCPYP", JdeDataType.Numeric),
        new JdeField("SZOPYP", "SZOPYP", JdeDataType.Numeric),
        new JdeField("SZAPID", "SZAPID", JdeDataType.String, 24),
        new JdeField("SZSHNO", "SZSHNO", JdeDataType.String, 20),
        new JdeField("SZOPSC", "SZOPSC", JdeDataType.String, 4),
        new JdeField("SZINPE", "SZINPE", JdeDataType.String, 4),
        new JdeField("SZJBCD", "SZJBCD", JdeDataType.String, 12),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZVEND", "SZVEND", JdeDataType.Numeric),
        new JdeField("SZPOY", "SZPOY", JdeDataType.String, 2),
        new JdeField("SZCOST", "SZCOST", JdeDataType.String, 6),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZRREV", "SZRREV", JdeDataType.String, 6),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZRUC", "SZRUC", JdeDataType.Numeric),
        new JdeField("SZCAPU", "SZCAPU", JdeDataType.String, 4),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZNUMB", "SZNUMB", JdeDataType.Numeric),
        new JdeField("SZWMCU", "SZWMCU", JdeDataType.String, 24),
        new JdeField("SZACTB", "SZACTB", JdeDataType.String, 20),
        new JdeField("SZCBCO", "SZCBCO", JdeDataType.Numeric),
        new JdeField("SZCICO", "SZCICO", JdeDataType.Numeric),
        new JdeField("SZIMCO", "SZIMCO", JdeDataType.Numeric),
        new JdeField("SZMPRO", "SZMPRO", JdeDataType.Numeric),
        new JdeField("SZAPSC", "SZAPSC", JdeDataType.String, 2),
        new JdeField("SZMNSP", "SZMNSP", JdeDataType.Numeric),
        new JdeField("SZMXSP", "SZMXSP", JdeDataType.Numeric),
        new JdeField("SZCMPE", "SZCMPE", JdeDataType.String, 6),
        new JdeField("SZCMPC", "SZCMPC", JdeDataType.String, 20),
        new JdeField("SZCPLVLFR", "SZCPLVLFR", JdeDataType.Numeric),
        new JdeField("SZCPLVLTO", "SZCPLVLTO", JdeDataType.Numeric),
        new JdeField("SZCMRQ", "SZCMRQ", JdeDataType.String, 2),
        new JdeField("SZANSA", "SZANSA", JdeDataType.Numeric),
        new JdeField("SZANPA", "SZANPA", JdeDataType.Numeric),
        new JdeField("SZANP", "SZANP", JdeDataType.Numeric),
        new JdeField("SZWSCHF", "SZWSCHF", JdeDataType.String, 2),
        new JdeField("SZTRAF", "SZTRAF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3003Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3003Z1_2", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDSP" }),
        new JdeIndex("F3003Z1_3", "Index on SZEDUS, SZEDBT, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDSP" }),
        new JdeIndex("F3003Z1_4", "Index on SZEDBT, SZEDTN, SZMMCU, SZKIT, SZTRT, SZBQTY", new[] { "SZEDBT", "SZEDTN", "SZMMCU", "SZKIT", "SZTRT", "SZBQTY" }),
        new JdeIndex("F3003Z1_6", "Index on SZEDUS, SZEDBT, SZEDTN", new[] { "SZEDUS", "SZEDBT", "SZEDTN" }),
        new JdeIndex("F3003Z1_8", "Index on SZEDUS, SZEDBT, SZEDTN, SYS_NC00091$", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SYS_NC00091$" })
    };
}
