using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3112Z1 - .
/// </summary>
public class F3112Z1 : JdeTable
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
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

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
        /// SZLINE.
        /// </summary>
        public const string SZLINE = "SZLINE";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZALD.
        /// </summary>
        public const string SZALD = "SZALD";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZOPSC.
        /// </summary>
        public const string SZOPSC = "SZOPSC";

        /// <summary>
        /// SZOPST.
        /// </summary>
        public const string SZOPST = "SZOPST";

        /// <summary>
        /// SZINPE.
        /// </summary>
        public const string SZINPE = "SZINPE";

        /// <summary>
        /// SZTIMB.
        /// </summary>
        public const string SZTIMB = "SZTIMB";

        /// <summary>
        /// SZLAMC.
        /// </summary>
        public const string SZLAMC = "SZLAMC";

        /// <summary>
        /// SZBFPF.
        /// </summary>
        public const string SZBFPF = "SZBFPF";

        /// <summary>
        /// SZPPRF.
        /// </summary>
        public const string SZPPRF = "SZPPRF";

        /// <summary>
        /// SZJBCD.
        /// </summary>
        public const string SZJBCD = "SZJBCD";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZCRTR.
        /// </summary>
        public const string SZCRTR = "SZCRTR";

        /// <summary>
        /// SZSLTR.
        /// </summary>
        public const string SZSLTR = "SZSLTR";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZDRQJ.
        /// </summary>
        public const string SZDRQJ = "SZDRQJ";

        /// <summary>
        /// SZSTRT.
        /// </summary>
        public const string SZSTRT = "SZSTRT";

        /// <summary>
        /// SZRSFT.
        /// </summary>
        public const string SZRSFT = "SZRSFT";

        /// <summary>
        /// SZSSFT.
        /// </summary>
        public const string SZSSFT = "SZSSFT";

        /// <summary>
        /// SZCSFT.
        /// </summary>
        public const string SZCSFT = "SZCSFT";

        /// <summary>
        /// SZLTPC.
        /// </summary>
        public const string SZLTPC = "SZLTPC";

        /// <summary>
        /// SZPOVR.
        /// </summary>
        public const string SZPOVR = "SZPOVR";

        /// <summary>
        /// SZOPYP.
        /// </summary>
        public const string SZOPYP = "SZOPYP";

        /// <summary>
        /// SZCPYP.
        /// </summary>
        public const string SZCPYP = "SZCPYP";

        /// <summary>
        /// SZNXOP.
        /// </summary>
        public const string SZNXOP = "SZNXOP";

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
        /// SZMACA.
        /// </summary>
        public const string SZMACA = "SZMACA";

        /// <summary>
        /// SZLABA.
        /// </summary>
        public const string SZLABA = "SZLABA";

        /// <summary>
        /// SZSETA.
        /// </summary>
        public const string SZSETA = "SZSETA";

        /// <summary>
        /// SZOPSR.
        /// </summary>
        public const string SZOPSR = "SZOPSR";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZSOCN.
        /// </summary>
        public const string SZSOCN = "SZSOCN";

        /// <summary>
        /// SZSOQS.
        /// </summary>
        public const string SZSOQS = "SZSOQS";

        /// <summary>
        /// SZQMTO.
        /// </summary>
        public const string SZQMTO = "SZQMTO";

        /// <summary>
        /// SZPWRT.
        /// </summary>
        public const string SZPWRT = "SZPWRT";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZCTS2.
        /// </summary>
        public const string SZCTS2 = "SZCTS2";

        /// <summary>
        /// SZCTS3.
        /// </summary>
        public const string SZCTS3 = "SZCTS3";

        /// <summary>
        /// SZCTS4.
        /// </summary>
        public const string SZCTS4 = "SZCTS4";

        /// <summary>
        /// SZCTS5.
        /// </summary>
        public const string SZCTS5 = "SZCTS5";

        /// <summary>
        /// SZCTS6.
        /// </summary>
        public const string SZCTS6 = "SZCTS6";

        /// <summary>
        /// SZAPID.
        /// </summary>
        public const string SZAPID = "SZAPID";

        /// <summary>
        /// SZSHNO.
        /// </summary>
        public const string SZSHNO = "SZSHNO";

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
        /// SZVEND.
        /// </summary>
        public const string SZVEND = "SZVEND";

        /// <summary>
        /// SZRKCO.
        /// </summary>
        public const string SZRKCO = "SZRKCO";

        /// <summary>
        /// SZRORN.
        /// </summary>
        public const string SZRORN = "SZRORN";

        /// <summary>
        /// SZRCTO.
        /// </summary>
        public const string SZRCTO = "SZRCTO";

        /// <summary>
        /// SZRLLN.
        /// </summary>
        public const string SZRLLN = "SZRLLN";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

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
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

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
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZCAPU.
        /// </summary>
        public const string SZCAPU = "SZCAPU";

        /// <summary>
        /// SZCLHR.
        /// </summary>
        public const string SZCLHR = "SZCLHR";

        /// <summary>
        /// SZCMHR.
        /// </summary>
        public const string SZCMHR = "SZCMHR";

        /// <summary>
        /// SZCOST.
        /// </summary>
        public const string SZCOST = "SZCOST";

        /// <summary>
        /// SZCSHR.
        /// </summary>
        public const string SZCSHR = "SZCSHR";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZRUC.
        /// </summary>
        public const string SZRUC = "SZRUC";

        /// <summary>
        /// SZWMCU.
        /// </summary>
        public const string SZWMCU = "SZWMCU";

        /// <summary>
        /// SZNUMB.
        /// </summary>
        public const string SZNUMB = "SZNUMB";

        /// <summary>
        /// SZCTS7.
        /// </summary>
        public const string SZCTS7 = "SZCTS7";

        /// <summary>
        /// SZCTS8.
        /// </summary>
        public const string SZCTS8 = "SZCTS8";

        /// <summary>
        /// SZSHFT.
        /// </summary>
        public const string SZSHFT = "SZSHFT";

        /// <summary>
        /// SZACTB.
        /// </summary>
        public const string SZACTB = "SZACTB";

        /// <summary>
        /// SZCTS9.
        /// </summary>
        public const string SZCTS9 = "SZCTS9";

        /// <summary>
        /// SZLABP.
        /// </summary>
        public const string SZLABP = "SZLABP";

        /// <summary>
        /// SZMACR.
        /// </summary>
        public const string SZMACR = "SZMACR";

        /// <summary>
        /// SZSETR.
        /// </summary>
        public const string SZSETR = "SZSETR";

        /// <summary>
        /// SZAPSC.
        /// </summary>
        public const string SZAPSC = "SZAPSC";

        /// <summary>
        /// SZSEST.
        /// </summary>
        public const string SZSEST = "SZSEST";

        /// <summary>
        /// SZSEET.
        /// </summary>
        public const string SZSEET = "SZSEET";

        /// <summary>
        /// SZTMCO.
        /// </summary>
        public const string SZTMCO = "SZTMCO";

        /// <summary>
        /// SZD2J.
        /// </summary>
        public const string SZD2J = "SZD2J";

        /// <summary>
        /// SZSTTI.
        /// </summary>
        public const string SZSTTI = "SZSTTI";

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
    public override string TableName => "F3112Z1";

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
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZTRT", "SZTRT", JdeDataType.String, 6),
        new JdeField("SZKIT", "SZKIT", JdeDataType.Numeric),
        new JdeField("SZKITL", "SZKITL", JdeDataType.String, 50),
        new JdeField("SZKITA", "SZKITA", JdeDataType.String, 50),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZLINE", "SZLINE", JdeDataType.String, 24),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24, true, true),
        new JdeField("SZALD", "SZALD", JdeDataType.String, 8),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SZOPSC", "SZOPSC", JdeDataType.String, 4, true, true),
        new JdeField("SZOPST", "SZOPST", JdeDataType.String, 4),
        new JdeField("SZINPE", "SZINPE", JdeDataType.String, 4),
        new JdeField("SZTIMB", "SZTIMB", JdeDataType.String, 2),
        new JdeField("SZLAMC", "SZLAMC", JdeDataType.String, 2),
        new JdeField("SZBFPF", "SZBFPF", JdeDataType.String, 2),
        new JdeField("SZPPRF", "SZPPRF", JdeDataType.String, 2),
        new JdeField("SZJBCD", "SZJBCD", JdeDataType.String, 12),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZCRTR", "SZCRTR", JdeDataType.Numeric),
        new JdeField("SZSLTR", "SZSLTR", JdeDataType.Numeric),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZSTRT", "SZSTRT", JdeDataType.Numeric),
        new JdeField("SZRSFT", "SZRSFT", JdeDataType.String, 2),
        new JdeField("SZSSFT", "SZSSFT", JdeDataType.String, 2),
        new JdeField("SZCSFT", "SZCSFT", JdeDataType.String, 2),
        new JdeField("SZLTPC", "SZLTPC", JdeDataType.Numeric),
        new JdeField("SZPOVR", "SZPOVR", JdeDataType.Numeric),
        new JdeField("SZOPYP", "SZOPYP", JdeDataType.Numeric),
        new JdeField("SZCPYP", "SZCPYP", JdeDataType.Numeric),
        new JdeField("SZNXOP", "SZNXOP", JdeDataType.Numeric),
        new JdeField("SZSETC", "SZSETC", JdeDataType.Numeric),
        new JdeField("SZMOVD", "SZMOVD", JdeDataType.Numeric),
        new JdeField("SZQUED", "SZQUED", JdeDataType.Numeric),
        new JdeField("SZRUNM", "SZRUNM", JdeDataType.Numeric),
        new JdeField("SZRUNL", "SZRUNL", JdeDataType.Numeric),
        new JdeField("SZSETL", "SZSETL", JdeDataType.Numeric),
        new JdeField("SZMACA", "SZMACA", JdeDataType.Numeric),
        new JdeField("SZLABA", "SZLABA", JdeDataType.Numeric),
        new JdeField("SZSETA", "SZSETA", JdeDataType.Numeric),
        new JdeField("SZOPSR", "SZOPSR", JdeDataType.Numeric),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZSOCN", "SZSOCN", JdeDataType.Numeric),
        new JdeField("SZSOQS", "SZSOQS", JdeDataType.Numeric),
        new JdeField("SZQMTO", "SZQMTO", JdeDataType.Numeric),
        new JdeField("SZPWRT", "SZPWRT", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZCTS2", "SZCTS2", JdeDataType.Numeric),
        new JdeField("SZCTS3", "SZCTS3", JdeDataType.Numeric),
        new JdeField("SZCTS4", "SZCTS4", JdeDataType.Numeric),
        new JdeField("SZCTS5", "SZCTS5", JdeDataType.Numeric),
        new JdeField("SZCTS6", "SZCTS6", JdeDataType.Numeric),
        new JdeField("SZAPID", "SZAPID", JdeDataType.String, 24),
        new JdeField("SZSHNO", "SZSHNO", JdeDataType.String, 20),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZVEND", "SZVEND", JdeDataType.Numeric),
        new JdeField("SZRKCO", "SZRKCO", JdeDataType.String, 10),
        new JdeField("SZRORN", "SZRORN", JdeDataType.String, 16),
        new JdeField("SZRCTO", "SZRCTO", JdeDataType.String, 4),
        new JdeField("SZRLLN", "SZRLLN", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZCAPU", "SZCAPU", JdeDataType.String, 4),
        new JdeField("SZCLHR", "SZCLHR", JdeDataType.Numeric),
        new JdeField("SZCMHR", "SZCMHR", JdeDataType.Numeric),
        new JdeField("SZCOST", "SZCOST", JdeDataType.String, 6),
        new JdeField("SZCSHR", "SZCSHR", JdeDataType.Numeric),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZRUC", "SZRUC", JdeDataType.Numeric),
        new JdeField("SZWMCU", "SZWMCU", JdeDataType.String, 24),
        new JdeField("SZNUMB", "SZNUMB", JdeDataType.Numeric),
        new JdeField("SZCTS7", "SZCTS7", JdeDataType.Numeric),
        new JdeField("SZCTS8", "SZCTS8", JdeDataType.Numeric),
        new JdeField("SZSHFT", "SZSHFT", JdeDataType.String, 2),
        new JdeField("SZACTB", "SZACTB", JdeDataType.String, 20),
        new JdeField("SZCTS9", "SZCTS9", JdeDataType.Numeric),
        new JdeField("SZLABP", "SZLABP", JdeDataType.Numeric),
        new JdeField("SZMACR", "SZMACR", JdeDataType.Numeric),
        new JdeField("SZSETR", "SZSETR", JdeDataType.Numeric),
        new JdeField("SZAPSC", "SZAPSC", JdeDataType.String, 2),
        new JdeField("SZSEST", "SZSEST", JdeDataType.Numeric),
        new JdeField("SZSEET", "SZSEET", JdeDataType.Numeric),
        new JdeField("SZTMCO", "SZTMCO", JdeDataType.Numeric),
        new JdeField("SZD2J", "SZD2J", JdeDataType.Numeric),
        new JdeField("SZSTTI", "SZSTTI", JdeDataType.Numeric),
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
        new JdeIndex("F3112Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN, SZOPSQ, SZOPSC, SZMCU", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN", "SZOPSQ", "SZOPSC", "SZMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
