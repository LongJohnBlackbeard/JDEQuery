using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4215 - .
/// </summary>
public class F4215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XHSHPN.
        /// </summary>
        public const string XHSHPN = "XHSHPN";

        /// <summary>
        /// XHSSTS.
        /// </summary>
        public const string XHSSTS = "XHSSTS";

        /// <summary>
        /// XHPNID.
        /// </summary>
        public const string XHPNID = "XHPNID";

        /// <summary>
        /// XHHLCF.
        /// </summary>
        public const string XHHLCF = "XHHLCF";

        /// <summary>
        /// XHPKCD.
        /// </summary>
        public const string XHPKCD = "XHPKCD";

        /// <summary>
        /// XHWGQ.
        /// </summary>
        public const string XHWGQ = "XHWGQ";

        /// <summary>
        /// XHWGTS.
        /// </summary>
        public const string XHWGTS = "XHWGTS";

        /// <summary>
        /// XHWGTU.
        /// </summary>
        public const string XHWGTU = "XHWGTU";

        /// <summary>
        /// XHIDQ1.
        /// </summary>
        public const string XHIDQ1 = "XHIDQ1";

        /// <summary>
        /// XHID1.
        /// </summary>
        public const string XHID1 = "XHID1";

        /// <summary>
        /// XHIDQ2.
        /// </summary>
        public const string XHIDQ2 = "XHIDQ2";

        /// <summary>
        /// XHID2.
        /// </summary>
        public const string XHID2 = "XHID2";

        /// <summary>
        /// XHMOT.
        /// </summary>
        public const string XHMOT = "XHMOT";

        /// <summary>
        /// XHROTE.
        /// </summary>
        public const string XHROTE = "XHROTE";

        /// <summary>
        /// XHEQCD.
        /// </summary>
        public const string XHEQCD = "XHEQCD";

        /// <summary>
        /// XHEQIN.
        /// </summary>
        public const string XHEQIN = "XHEQIN";

        /// <summary>
        /// XHEQNB.
        /// </summary>
        public const string XHEQNB = "XHEQNB";

        /// <summary>
        /// XHASNA.
        /// </summary>
        public const string XHASNA = "XHASNA";

        /// <summary>
        /// XHASND.
        /// </summary>
        public const string XHASND = "XHASND";

        /// <summary>
        /// XHASNT.
        /// </summary>
        public const string XHASNT = "XHASNT";

        /// <summary>
        /// XHMCU.
        /// </summary>
        public const string XHMCU = "XHMCU";

        /// <summary>
        /// XHNMCU.
        /// </summary>
        public const string XHNMCU = "XHNMCU";

        /// <summary>
        /// XHORGN.
        /// </summary>
        public const string XHORGN = "XHORGN";

        /// <summary>
        /// XHSRCO.
        /// </summary>
        public const string XHSRCO = "XHSRCO";

        /// <summary>
        /// XHBPFG.
        /// </summary>
        public const string XHBPFG = "XHBPFG";

        /// <summary>
        /// XHAEXP.
        /// </summary>
        public const string XHAEXP = "XHAEXP";

        /// <summary>
        /// XHECST.
        /// </summary>
        public const string XHECST = "XHECST";

        /// <summary>
        /// XHDRQJ.
        /// </summary>
        public const string XHDRQJ = "XHDRQJ";

        /// <summary>
        /// XHDRQT.
        /// </summary>
        public const string XHDRQT = "XHDRQT";

        /// <summary>
        /// XHRSDJ.
        /// </summary>
        public const string XHRSDJ = "XHRSDJ";

        /// <summary>
        /// XHRSDT.
        /// </summary>
        public const string XHRSDT = "XHRSDT";

        /// <summary>
        /// XHPDOV.
        /// </summary>
        public const string XHPDOV = "XHPDOV";

        /// <summary>
        /// XHAN8.
        /// </summary>
        public const string XHAN8 = "XHAN8";

        /// <summary>
        /// XHSHAN.
        /// </summary>
        public const string XHSHAN = "XHSHAN";

        /// <summary>
        /// XHCTY1.
        /// </summary>
        public const string XHCTY1 = "XHCTY1";

        /// <summary>
        /// XHADDS.
        /// </summary>
        public const string XHADDS = "XHADDS";

        /// <summary>
        /// XHADDZ.
        /// </summary>
        public const string XHADDZ = "XHADDZ";

        /// <summary>
        /// XHCTR.
        /// </summary>
        public const string XHCTR = "XHCTR";

        /// <summary>
        /// XHZON.
        /// </summary>
        public const string XHZON = "XHZON";

        /// <summary>
        /// XHSCT1.
        /// </summary>
        public const string XHSCT1 = "XHSCT1";

        /// <summary>
        /// XHSCT2.
        /// </summary>
        public const string XHSCT2 = "XHSCT2";

        /// <summary>
        /// XHSCT3.
        /// </summary>
        public const string XHSCT3 = "XHSCT3";

        /// <summary>
        /// XHCAR1.
        /// </summary>
        public const string XHCAR1 = "XHCAR1";

        /// <summary>
        /// XHCAR2.
        /// </summary>
        public const string XHCAR2 = "XHCAR2";

        /// <summary>
        /// XHCAR3.
        /// </summary>
        public const string XHCAR3 = "XHCAR3";

        /// <summary>
        /// XHILEL.
        /// </summary>
        public const string XHILEL = "XHILEL";

        /// <summary>
        /// XHFRTH.
        /// </summary>
        public const string XHFRTH = "XHFRTH";

        /// <summary>
        /// XHFRSC.
        /// </summary>
        public const string XHFRSC = "XHFRSC";

        /// <summary>
        /// XHDLLV.
        /// </summary>
        public const string XHDLLV = "XHDLLV";

        /// <summary>
        /// XHRSLT.
        /// </summary>
        public const string XHRSLT = "XHRSLT";

        /// <summary>
        /// XHBFSD.
        /// </summary>
        public const string XHBFSD = "XHBFSD";

        /// <summary>
        /// XHDSTN.
        /// </summary>
        public const string XHDSTN = "XHDSTN";

        /// <summary>
        /// XHUMD1.
        /// </summary>
        public const string XHUMD1 = "XHUMD1";

        /// <summary>
        /// XHNRTS.
        /// </summary>
        public const string XHNRTS = "XHNRTS";

        /// <summary>
        /// XHUSER.
        /// </summary>
        public const string XHUSER = "XHUSER";

        /// <summary>
        /// XHPID.
        /// </summary>
        public const string XHPID = "XHPID";

        /// <summary>
        /// XHJOBN.
        /// </summary>
        public const string XHJOBN = "XHJOBN";

        /// <summary>
        /// XHUPMJ.
        /// </summary>
        public const string XHUPMJ = "XHUPMJ";

        /// <summary>
        /// XHTDAY.
        /// </summary>
        public const string XHTDAY = "XHTDAY";

        /// <summary>
        /// XHCTYO.
        /// </summary>
        public const string XHCTYO = "XHCTYO";

        /// <summary>
        /// XHADSO.
        /// </summary>
        public const string XHADSO = "XHADSO";

        /// <summary>
        /// XHADZO.
        /// </summary>
        public const string XHADZO = "XHADZO";

        /// <summary>
        /// XHCTRO.
        /// </summary>
        public const string XHCTRO = "XHCTRO";

        /// <summary>
        /// XHSC1O.
        /// </summary>
        public const string XHSC1O = "XHSC1O";

        /// <summary>
        /// XHSC2O.
        /// </summary>
        public const string XHSC2O = "XHSC2O";

        /// <summary>
        /// XHSC3O.
        /// </summary>
        public const string XHSC3O = "XHSC3O";

        /// <summary>
        /// XHAETC.
        /// </summary>
        public const string XHAETC = "XHAETC";

        /// <summary>
        /// XHETRSC.
        /// </summary>
        public const string XHETRSC = "XHETRSC";

        /// <summary>
        /// XHETRC.
        /// </summary>
        public const string XHETRC = "XHETRC";

        /// <summary>
        /// XHURCD.
        /// </summary>
        public const string XHURCD = "XHURCD";

        /// <summary>
        /// XHURDT.
        /// </summary>
        public const string XHURDT = "XHURDT";

        /// <summary>
        /// XHURAT.
        /// </summary>
        public const string XHURAT = "XHURAT";

        /// <summary>
        /// XHURAB.
        /// </summary>
        public const string XHURAB = "XHURAB";

        /// <summary>
        /// XHURRF.
        /// </summary>
        public const string XHURRF = "XHURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F4215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XHSHPN", "XHSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("XHSSTS", "XHSSTS", JdeDataType.String, 4),
        new JdeField("XHPNID", "XHPNID", JdeDataType.String, 30),
        new JdeField("XHHLCF", "XHHLCF", JdeDataType.String, 36),
        new JdeField("XHPKCD", "XHPKCD", JdeDataType.String, 10),
        new JdeField("XHWGQ", "XHWGQ", JdeDataType.String, 4),
        new JdeField("XHWGTS", "XHWGTS", JdeDataType.Numeric),
        new JdeField("XHWGTU", "XHWGTU", JdeDataType.String, 4),
        new JdeField("XHIDQ1", "XHIDQ1", JdeDataType.String, 4),
        new JdeField("XHID1", "XHID1", JdeDataType.String, 34),
        new JdeField("XHIDQ2", "XHIDQ2", JdeDataType.String, 4),
        new JdeField("XHID2", "XHID2", JdeDataType.String, 34),
        new JdeField("XHMOT", "XHMOT", JdeDataType.String, 6),
        new JdeField("XHROTE", "XHROTE", JdeDataType.String, 70),
        new JdeField("XHEQCD", "XHEQCD", JdeDataType.String, 4),
        new JdeField("XHEQIN", "XHEQIN", JdeDataType.String, 8),
        new JdeField("XHEQNB", "XHEQNB", JdeDataType.String, 20),
        new JdeField("XHASNA", "XHASNA", JdeDataType.String, 4),
        new JdeField("XHASND", "XHASND", JdeDataType.Numeric),
        new JdeField("XHASNT", "XHASNT", JdeDataType.Numeric),
        new JdeField("XHMCU", "XHMCU", JdeDataType.String, 24),
        new JdeField("XHNMCU", "XHNMCU", JdeDataType.String, 24),
        new JdeField("XHORGN", "XHORGN", JdeDataType.Numeric),
        new JdeField("XHSRCO", "XHSRCO", JdeDataType.String, 2),
        new JdeField("XHBPFG", "XHBPFG", JdeDataType.String, 2),
        new JdeField("XHAEXP", "XHAEXP", JdeDataType.Numeric),
        new JdeField("XHECST", "XHECST", JdeDataType.Numeric),
        new JdeField("XHDRQJ", "XHDRQJ", JdeDataType.Numeric),
        new JdeField("XHDRQT", "XHDRQT", JdeDataType.Numeric),
        new JdeField("XHRSDJ", "XHRSDJ", JdeDataType.Numeric),
        new JdeField("XHRSDT", "XHRSDT", JdeDataType.Numeric),
        new JdeField("XHPDOV", "XHPDOV", JdeDataType.String, 2),
        new JdeField("XHAN8", "XHAN8", JdeDataType.Numeric),
        new JdeField("XHSHAN", "XHSHAN", JdeDataType.Numeric),
        new JdeField("XHCTY1", "XHCTY1", JdeDataType.String, 50),
        new JdeField("XHADDS", "XHADDS", JdeDataType.String, 6),
        new JdeField("XHADDZ", "XHADDZ", JdeDataType.String, 24),
        new JdeField("XHCTR", "XHCTR", JdeDataType.String, 6),
        new JdeField("XHZON", "XHZON", JdeDataType.String, 6),
        new JdeField("XHSCT1", "XHSCT1", JdeDataType.String, 6),
        new JdeField("XHSCT2", "XHSCT2", JdeDataType.String, 6),
        new JdeField("XHSCT3", "XHSCT3", JdeDataType.String, 6),
        new JdeField("XHCAR1", "XHCAR1", JdeDataType.Numeric),
        new JdeField("XHCAR2", "XHCAR2", JdeDataType.Numeric),
        new JdeField("XHCAR3", "XHCAR3", JdeDataType.Numeric),
        new JdeField("XHILEL", "XHILEL", JdeDataType.String, 2),
        new JdeField("XHFRTH", "XHFRTH", JdeDataType.String, 6),
        new JdeField("XHFRSC", "XHFRSC", JdeDataType.String, 16),
        new JdeField("XHDLLV", "XHDLLV", JdeDataType.String, 2),
        new JdeField("XHRSLT", "XHRSLT", JdeDataType.String, 2),
        new JdeField("XHBFSD", "XHBFSD", JdeDataType.String, 2),
        new JdeField("XHDSTN", "XHDSTN", JdeDataType.Numeric),
        new JdeField("XHUMD1", "XHUMD1", JdeDataType.String, 4),
        new JdeField("XHNRTS", "XHNRTS", JdeDataType.Numeric),
        new JdeField("XHUSER", "XHUSER", JdeDataType.String, 20),
        new JdeField("XHPID", "XHPID", JdeDataType.String, 20),
        new JdeField("XHJOBN", "XHJOBN", JdeDataType.String, 20),
        new JdeField("XHUPMJ", "XHUPMJ", JdeDataType.Numeric),
        new JdeField("XHTDAY", "XHTDAY", JdeDataType.Numeric),
        new JdeField("XHCTYO", "XHCTYO", JdeDataType.String, 50),
        new JdeField("XHADSO", "XHADSO", JdeDataType.String, 6),
        new JdeField("XHADZO", "XHADZO", JdeDataType.String, 24),
        new JdeField("XHCTRO", "XHCTRO", JdeDataType.String, 6),
        new JdeField("XHSC1O", "XHSC1O", JdeDataType.String, 6),
        new JdeField("XHSC2O", "XHSC2O", JdeDataType.String, 6),
        new JdeField("XHSC3O", "XHSC3O", JdeDataType.String, 6),
        new JdeField("XHAETC", "XHAETC", JdeDataType.String, 20),
        new JdeField("XHETRSC", "XHETRSC", JdeDataType.String, 6),
        new JdeField("XHETRC", "XHETRC", JdeDataType.String, 6),
        new JdeField("XHURCD", "XHURCD", JdeDataType.String, 4),
        new JdeField("XHURDT", "XHURDT", JdeDataType.Numeric),
        new JdeField("XHURAT", "XHURAT", JdeDataType.Numeric),
        new JdeField("XHURAB", "XHURAB", JdeDataType.Numeric),
        new JdeField("XHURRF", "XHURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4215_0", "Primary Key on XHSHPN", new[] { "XHSHPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4215_2", "Index on XHSHAN", new[] { "XHSHAN" }),
        new JdeIndex("F4215_3", "Index on XHAN8", new[] { "XHAN8" }),
        new JdeIndex("F4215_4", "Index on XHSSTS", new[] { "XHSSTS" }),
        new JdeIndex("F4215_5", "Index on XHADDZ", new[] { "XHADDZ" }),
        new JdeIndex("F4215_6", "Index on XHNMCU", new[] { "XHNMCU" }),
        new JdeIndex("F4215_7", "Index on XHORGN", new[] { "XHORGN" })
    };
}
