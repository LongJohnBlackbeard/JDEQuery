using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31129 - .
/// </summary>
public class F31129 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WZDOCO.
        /// </summary>
        public const string WZDOCO = "WZDOCO";

        /// <summary>
        /// WZOPSQ.
        /// </summary>
        public const string WZOPSQ = "WZOPSQ";

        /// <summary>
        /// WZOPSC.
        /// </summary>
        public const string WZOPSC = "WZOPSC";

        /// <summary>
        /// WZMCU.
        /// </summary>
        public const string WZMCU = "WZMCU";

        /// <summary>
        /// WZDCTO.
        /// </summary>
        public const string WZDCTO = "WZDCTO";

        /// <summary>
        /// WZSFXO.
        /// </summary>
        public const string WZSFXO = "WZSFXO";

        /// <summary>
        /// WZTRT.
        /// </summary>
        public const string WZTRT = "WZTRT";

        /// <summary>
        /// WZKIT.
        /// </summary>
        public const string WZKIT = "WZKIT";

        /// <summary>
        /// WZKITL.
        /// </summary>
        public const string WZKITL = "WZKITL";

        /// <summary>
        /// WZKITA.
        /// </summary>
        public const string WZKITA = "WZKITA";

        /// <summary>
        /// WZMMCU.
        /// </summary>
        public const string WZMMCU = "WZMMCU";

        /// <summary>
        /// WZLINE.
        /// </summary>
        public const string WZLINE = "WZLINE";

        /// <summary>
        /// WZALD.
        /// </summary>
        public const string WZALD = "WZALD";

        /// <summary>
        /// WZDSC1.
        /// </summary>
        public const string WZDSC1 = "WZDSC1";

        /// <summary>
        /// WZOPST.
        /// </summary>
        public const string WZOPST = "WZOPST";

        /// <summary>
        /// WZINPE.
        /// </summary>
        public const string WZINPE = "WZINPE";

        /// <summary>
        /// WZTIMB.
        /// </summary>
        public const string WZTIMB = "WZTIMB";

        /// <summary>
        /// WZLAMC.
        /// </summary>
        public const string WZLAMC = "WZLAMC";

        /// <summary>
        /// WZBFPF.
        /// </summary>
        public const string WZBFPF = "WZBFPF";

        /// <summary>
        /// WZPPRF.
        /// </summary>
        public const string WZPPRF = "WZPPRF";

        /// <summary>
        /// WZJBCD.
        /// </summary>
        public const string WZJBCD = "WZJBCD";

        /// <summary>
        /// WZAN8.
        /// </summary>
        public const string WZAN8 = "WZAN8";

        /// <summary>
        /// WZCRTR.
        /// </summary>
        public const string WZCRTR = "WZCRTR";

        /// <summary>
        /// WZSLTR.
        /// </summary>
        public const string WZSLTR = "WZSLTR";

        /// <summary>
        /// WZTRDJ.
        /// </summary>
        public const string WZTRDJ = "WZTRDJ";

        /// <summary>
        /// WZDRQJ.
        /// </summary>
        public const string WZDRQJ = "WZDRQJ";

        /// <summary>
        /// WZSTRT.
        /// </summary>
        public const string WZSTRT = "WZSTRT";

        /// <summary>
        /// WZSTRX.
        /// </summary>
        public const string WZSTRX = "WZSTRX";

        /// <summary>
        /// WZRSFT.
        /// </summary>
        public const string WZRSFT = "WZRSFT";

        /// <summary>
        /// WZCSFT.
        /// </summary>
        public const string WZCSFT = "WZCSFT";

        /// <summary>
        /// WZSSFT.
        /// </summary>
        public const string WZSSFT = "WZSSFT";

        /// <summary>
        /// WZLTPC.
        /// </summary>
        public const string WZLTPC = "WZLTPC";

        /// <summary>
        /// WZPOVR.
        /// </summary>
        public const string WZPOVR = "WZPOVR";

        /// <summary>
        /// WZOPYP.
        /// </summary>
        public const string WZOPYP = "WZOPYP";

        /// <summary>
        /// WZCPYP.
        /// </summary>
        public const string WZCPYP = "WZCPYP";

        /// <summary>
        /// WZNXOP.
        /// </summary>
        public const string WZNXOP = "WZNXOP";

        /// <summary>
        /// WZSETC.
        /// </summary>
        public const string WZSETC = "WZSETC";

        /// <summary>
        /// WZMOVD.
        /// </summary>
        public const string WZMOVD = "WZMOVD";

        /// <summary>
        /// WZQUED.
        /// </summary>
        public const string WZQUED = "WZQUED";

        /// <summary>
        /// WZRUNM.
        /// </summary>
        public const string WZRUNM = "WZRUNM";

        /// <summary>
        /// WZRUNL.
        /// </summary>
        public const string WZRUNL = "WZRUNL";

        /// <summary>
        /// WZSETL.
        /// </summary>
        public const string WZSETL = "WZSETL";

        /// <summary>
        /// WZMACA.
        /// </summary>
        public const string WZMACA = "WZMACA";

        /// <summary>
        /// WZLABA.
        /// </summary>
        public const string WZLABA = "WZLABA";

        /// <summary>
        /// WZSETA.
        /// </summary>
        public const string WZSETA = "WZSETA";

        /// <summary>
        /// WZOPSR.
        /// </summary>
        public const string WZOPSR = "WZOPSR";

        /// <summary>
        /// WZUORG.
        /// </summary>
        public const string WZUORG = "WZUORG";

        /// <summary>
        /// WZSOCN.
        /// </summary>
        public const string WZSOCN = "WZSOCN";

        /// <summary>
        /// WZSOQS.
        /// </summary>
        public const string WZSOQS = "WZSOQS";

        /// <summary>
        /// WZQMTO.
        /// </summary>
        public const string WZQMTO = "WZQMTO";

        /// <summary>
        /// WZPWRT.
        /// </summary>
        public const string WZPWRT = "WZPWRT";

        /// <summary>
        /// WZUOM.
        /// </summary>
        public const string WZUOM = "WZUOM";

        /// <summary>
        /// WZCTS2.
        /// </summary>
        public const string WZCTS2 = "WZCTS2";

        /// <summary>
        /// WZCTS3.
        /// </summary>
        public const string WZCTS3 = "WZCTS3";

        /// <summary>
        /// WZCTS4.
        /// </summary>
        public const string WZCTS4 = "WZCTS4";

        /// <summary>
        /// WZCTS5.
        /// </summary>
        public const string WZCTS5 = "WZCTS5";

        /// <summary>
        /// WZCTS6.
        /// </summary>
        public const string WZCTS6 = "WZCTS6";

        /// <summary>
        /// WZAPID.
        /// </summary>
        public const string WZAPID = "WZAPID";

        /// <summary>
        /// WZSHNO.
        /// </summary>
        public const string WZSHNO = "WZSHNO";

        /// <summary>
        /// WZOMCU.
        /// </summary>
        public const string WZOMCU = "WZOMCU";

        /// <summary>
        /// WZOBJ.
        /// </summary>
        public const string WZOBJ = "WZOBJ";

        /// <summary>
        /// WZSUB.
        /// </summary>
        public const string WZSUB = "WZSUB";

        /// <summary>
        /// WZVEND.
        /// </summary>
        public const string WZVEND = "WZVEND";

        /// <summary>
        /// WZRKCO.
        /// </summary>
        public const string WZRKCO = "WZRKCO";

        /// <summary>
        /// WZRORN.
        /// </summary>
        public const string WZRORN = "WZRORN";

        /// <summary>
        /// WZRCTO.
        /// </summary>
        public const string WZRCTO = "WZRCTO";

        /// <summary>
        /// WZRLLN.
        /// </summary>
        public const string WZRLLN = "WZRLLN";

        /// <summary>
        /// WZDCT.
        /// </summary>
        public const string WZDCT = "WZDCT";

        /// <summary>
        /// WZURCD.
        /// </summary>
        public const string WZURCD = "WZURCD";

        /// <summary>
        /// WZURDT.
        /// </summary>
        public const string WZURDT = "WZURDT";

        /// <summary>
        /// WZURAT.
        /// </summary>
        public const string WZURAT = "WZURAT";

        /// <summary>
        /// WZURRF.
        /// </summary>
        public const string WZURRF = "WZURRF";

        /// <summary>
        /// WZURAB.
        /// </summary>
        public const string WZURAB = "WZURAB";

        /// <summary>
        /// WZUSER.
        /// </summary>
        public const string WZUSER = "WZUSER";

        /// <summary>
        /// WZPID.
        /// </summary>
        public const string WZPID = "WZPID";

        /// <summary>
        /// WZJOBN.
        /// </summary>
        public const string WZJOBN = "WZJOBN";

        /// <summary>
        /// WZUPMJ.
        /// </summary>
        public const string WZUPMJ = "WZUPMJ";

        /// <summary>
        /// WZTDAY.
        /// </summary>
        public const string WZTDAY = "WZTDAY";

        /// <summary>
        /// WZLOCN.
        /// </summary>
        public const string WZLOCN = "WZLOCN";

        /// <summary>
        /// WZRUC.
        /// </summary>
        public const string WZRUC = "WZRUC";

        /// <summary>
        /// WZCAPU.
        /// </summary>
        public const string WZCAPU = "WZCAPU";

        /// <summary>
        /// WZWMCU.
        /// </summary>
        public const string WZWMCU = "WZWMCU";

        /// <summary>
        /// WZCMHR.
        /// </summary>
        public const string WZCMHR = "WZCMHR";

        /// <summary>
        /// WZCLHR.
        /// </summary>
        public const string WZCLHR = "WZCLHR";

        /// <summary>
        /// WZCSHR.
        /// </summary>
        public const string WZCSHR = "WZCSHR";

        /// <summary>
        /// WZCOST.
        /// </summary>
        public const string WZCOST = "WZCOST";

        /// <summary>
        /// WZACTB.
        /// </summary>
        public const string WZACTB = "WZACTB";

        /// <summary>
        /// WZNUMB.
        /// </summary>
        public const string WZNUMB = "WZNUMB";

        /// <summary>
        /// WZCTS7.
        /// </summary>
        public const string WZCTS7 = "WZCTS7";

        /// <summary>
        /// WZCTS8.
        /// </summary>
        public const string WZCTS8 = "WZCTS8";

        /// <summary>
        /// WZCTS9.
        /// </summary>
        public const string WZCTS9 = "WZCTS9";

        /// <summary>
        /// WZLABP.
        /// </summary>
        public const string WZLABP = "WZLABP";

        /// <summary>
        /// WZMACR.
        /// </summary>
        public const string WZMACR = "WZMACR";

        /// <summary>
        /// WZSETR.
        /// </summary>
        public const string WZSETR = "WZSETR";

        /// <summary>
        /// WZAPSC.
        /// </summary>
        public const string WZAPSC = "WZAPSC";

        /// <summary>
        /// WZSEST.
        /// </summary>
        public const string WZSEST = "WZSEST";

        /// <summary>
        /// WZSEET.
        /// </summary>
        public const string WZSEET = "WZSEET";

        /// <summary>
        /// WZTMCO.
        /// </summary>
        public const string WZTMCO = "WZTMCO";

        /// <summary>
        /// WZD2J.
        /// </summary>
        public const string WZD2J = "WZD2J";

        /// <summary>
        /// WZSTTI.
        /// </summary>
        public const string WZSTTI = "WZSTTI";

        /// <summary>
        /// WZCMPE.
        /// </summary>
        public const string WZCMPE = "WZCMPE";

        /// <summary>
        /// WZCMPC.
        /// </summary>
        public const string WZCMPC = "WZCMPC";

        /// <summary>
        /// WZCPLVLFR.
        /// </summary>
        public const string WZCPLVLFR = "WZCPLVLFR";

        /// <summary>
        /// WZCPLVLTO.
        /// </summary>
        public const string WZCPLVLTO = "WZCPLVLTO";

        /// <summary>
        /// WZCMRQ.
        /// </summary>
        public const string WZCMRQ = "WZCMRQ";

        /// <summary>
        /// WZANSA.
        /// </summary>
        public const string WZANSA = "WZANSA";

        /// <summary>
        /// WZANPA.
        /// </summary>
        public const string WZANPA = "WZANPA";

        /// <summary>
        /// WZANP.
        /// </summary>
        public const string WZANP = "WZANP";

        /// <summary>
        /// WZWSCHF.
        /// </summary>
        public const string WZWSCHF = "WZWSCHF";

        /// <summary>
        /// WZTRAF.
        /// </summary>
        public const string WZTRAF = "WZTRAF";

        /// <summary>
        /// WZACTN.
        /// </summary>
        public const string WZACTN = "WZACTN";
    }

    /// <inheritdoc />
    public override string TableName => "F31129";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WZDOCO", "WZDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WZOPSQ", "WZOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WZOPSC", "WZOPSC", JdeDataType.String, 4, true, true),
        new JdeField("WZMCU", "WZMCU", JdeDataType.String, 24, true, true),
        new JdeField("WZDCTO", "WZDCTO", JdeDataType.String, 4),
        new JdeField("WZSFXO", "WZSFXO", JdeDataType.String, 6),
        new JdeField("WZTRT", "WZTRT", JdeDataType.String, 6),
        new JdeField("WZKIT", "WZKIT", JdeDataType.Numeric),
        new JdeField("WZKITL", "WZKITL", JdeDataType.String, 50),
        new JdeField("WZKITA", "WZKITA", JdeDataType.String, 50),
        new JdeField("WZMMCU", "WZMMCU", JdeDataType.String, 24),
        new JdeField("WZLINE", "WZLINE", JdeDataType.String, 24),
        new JdeField("WZALD", "WZALD", JdeDataType.String, 8),
        new JdeField("WZDSC1", "WZDSC1", JdeDataType.String, 60),
        new JdeField("WZOPST", "WZOPST", JdeDataType.String, 4),
        new JdeField("WZINPE", "WZINPE", JdeDataType.String, 4),
        new JdeField("WZTIMB", "WZTIMB", JdeDataType.String, 2),
        new JdeField("WZLAMC", "WZLAMC", JdeDataType.String, 2),
        new JdeField("WZBFPF", "WZBFPF", JdeDataType.String, 2),
        new JdeField("WZPPRF", "WZPPRF", JdeDataType.String, 2),
        new JdeField("WZJBCD", "WZJBCD", JdeDataType.String, 12),
        new JdeField("WZAN8", "WZAN8", JdeDataType.Numeric),
        new JdeField("WZCRTR", "WZCRTR", JdeDataType.Numeric),
        new JdeField("WZSLTR", "WZSLTR", JdeDataType.Numeric),
        new JdeField("WZTRDJ", "WZTRDJ", JdeDataType.Numeric),
        new JdeField("WZDRQJ", "WZDRQJ", JdeDataType.Numeric),
        new JdeField("WZSTRT", "WZSTRT", JdeDataType.Numeric),
        new JdeField("WZSTRX", "WZSTRX", JdeDataType.Numeric),
        new JdeField("WZRSFT", "WZRSFT", JdeDataType.String, 2),
        new JdeField("WZCSFT", "WZCSFT", JdeDataType.String, 2),
        new JdeField("WZSSFT", "WZSSFT", JdeDataType.String, 2),
        new JdeField("WZLTPC", "WZLTPC", JdeDataType.Numeric),
        new JdeField("WZPOVR", "WZPOVR", JdeDataType.Numeric),
        new JdeField("WZOPYP", "WZOPYP", JdeDataType.Numeric),
        new JdeField("WZCPYP", "WZCPYP", JdeDataType.Numeric),
        new JdeField("WZNXOP", "WZNXOP", JdeDataType.Numeric),
        new JdeField("WZSETC", "WZSETC", JdeDataType.Numeric),
        new JdeField("WZMOVD", "WZMOVD", JdeDataType.Numeric),
        new JdeField("WZQUED", "WZQUED", JdeDataType.Numeric),
        new JdeField("WZRUNM", "WZRUNM", JdeDataType.Numeric),
        new JdeField("WZRUNL", "WZRUNL", JdeDataType.Numeric),
        new JdeField("WZSETL", "WZSETL", JdeDataType.Numeric),
        new JdeField("WZMACA", "WZMACA", JdeDataType.Numeric),
        new JdeField("WZLABA", "WZLABA", JdeDataType.Numeric),
        new JdeField("WZSETA", "WZSETA", JdeDataType.Numeric),
        new JdeField("WZOPSR", "WZOPSR", JdeDataType.Numeric),
        new JdeField("WZUORG", "WZUORG", JdeDataType.Numeric),
        new JdeField("WZSOCN", "WZSOCN", JdeDataType.Numeric),
        new JdeField("WZSOQS", "WZSOQS", JdeDataType.Numeric),
        new JdeField("WZQMTO", "WZQMTO", JdeDataType.Numeric),
        new JdeField("WZPWRT", "WZPWRT", JdeDataType.Numeric),
        new JdeField("WZUOM", "WZUOM", JdeDataType.String, 4),
        new JdeField("WZCTS2", "WZCTS2", JdeDataType.Numeric),
        new JdeField("WZCTS3", "WZCTS3", JdeDataType.Numeric),
        new JdeField("WZCTS4", "WZCTS4", JdeDataType.Numeric),
        new JdeField("WZCTS5", "WZCTS5", JdeDataType.Numeric),
        new JdeField("WZCTS6", "WZCTS6", JdeDataType.Numeric),
        new JdeField("WZAPID", "WZAPID", JdeDataType.String, 24),
        new JdeField("WZSHNO", "WZSHNO", JdeDataType.String, 20),
        new JdeField("WZOMCU", "WZOMCU", JdeDataType.String, 24),
        new JdeField("WZOBJ", "WZOBJ", JdeDataType.String, 12),
        new JdeField("WZSUB", "WZSUB", JdeDataType.String, 16),
        new JdeField("WZVEND", "WZVEND", JdeDataType.Numeric),
        new JdeField("WZRKCO", "WZRKCO", JdeDataType.String, 10),
        new JdeField("WZRORN", "WZRORN", JdeDataType.String, 16),
        new JdeField("WZRCTO", "WZRCTO", JdeDataType.String, 4),
        new JdeField("WZRLLN", "WZRLLN", JdeDataType.Numeric),
        new JdeField("WZDCT", "WZDCT", JdeDataType.String, 4),
        new JdeField("WZURCD", "WZURCD", JdeDataType.String, 4),
        new JdeField("WZURDT", "WZURDT", JdeDataType.Numeric),
        new JdeField("WZURAT", "WZURAT", JdeDataType.Numeric),
        new JdeField("WZURRF", "WZURRF", JdeDataType.String, 30),
        new JdeField("WZURAB", "WZURAB", JdeDataType.Numeric),
        new JdeField("WZUSER", "WZUSER", JdeDataType.String, 20, true, true),
        new JdeField("WZPID", "WZPID", JdeDataType.String, 20),
        new JdeField("WZJOBN", "WZJOBN", JdeDataType.String, 20),
        new JdeField("WZUPMJ", "WZUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WZTDAY", "WZTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("WZLOCN", "WZLOCN", JdeDataType.String, 40),
        new JdeField("WZRUC", "WZRUC", JdeDataType.Numeric),
        new JdeField("WZCAPU", "WZCAPU", JdeDataType.String, 4),
        new JdeField("WZWMCU", "WZWMCU", JdeDataType.String, 24),
        new JdeField("WZCMHR", "WZCMHR", JdeDataType.Numeric),
        new JdeField("WZCLHR", "WZCLHR", JdeDataType.Numeric),
        new JdeField("WZCSHR", "WZCSHR", JdeDataType.Numeric),
        new JdeField("WZCOST", "WZCOST", JdeDataType.String, 6),
        new JdeField("WZACTB", "WZACTB", JdeDataType.String, 20),
        new JdeField("WZNUMB", "WZNUMB", JdeDataType.Numeric),
        new JdeField("WZCTS7", "WZCTS7", JdeDataType.Numeric),
        new JdeField("WZCTS8", "WZCTS8", JdeDataType.Numeric),
        new JdeField("WZCTS9", "WZCTS9", JdeDataType.Numeric),
        new JdeField("WZLABP", "WZLABP", JdeDataType.Numeric),
        new JdeField("WZMACR", "WZMACR", JdeDataType.Numeric),
        new JdeField("WZSETR", "WZSETR", JdeDataType.Numeric),
        new JdeField("WZAPSC", "WZAPSC", JdeDataType.String, 2),
        new JdeField("WZSEST", "WZSEST", JdeDataType.Numeric),
        new JdeField("WZSEET", "WZSEET", JdeDataType.Numeric),
        new JdeField("WZTMCO", "WZTMCO", JdeDataType.Numeric),
        new JdeField("WZD2J", "WZD2J", JdeDataType.Numeric),
        new JdeField("WZSTTI", "WZSTTI", JdeDataType.Numeric),
        new JdeField("WZCMPE", "WZCMPE", JdeDataType.String, 6),
        new JdeField("WZCMPC", "WZCMPC", JdeDataType.String, 20),
        new JdeField("WZCPLVLFR", "WZCPLVLFR", JdeDataType.Numeric),
        new JdeField("WZCPLVLTO", "WZCPLVLTO", JdeDataType.Numeric),
        new JdeField("WZCMRQ", "WZCMRQ", JdeDataType.String, 2),
        new JdeField("WZANSA", "WZANSA", JdeDataType.Numeric),
        new JdeField("WZANPA", "WZANPA", JdeDataType.Numeric),
        new JdeField("WZANP", "WZANP", JdeDataType.Numeric),
        new JdeField("WZWSCHF", "WZWSCHF", JdeDataType.String, 2),
        new JdeField("WZTRAF", "WZTRAF", JdeDataType.String, 2),
        new JdeField("WZACTN", "WZACTN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31129_0", "Primary Key on WZDOCO, WZOPSQ, WZOPSC, WZMCU, WZUSER, WZUPMJ, WZTDAY", new[] { "WZDOCO", "WZOPSQ", "WZOPSC", "WZMCU", "WZUSER", "WZUPMJ", "WZTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
