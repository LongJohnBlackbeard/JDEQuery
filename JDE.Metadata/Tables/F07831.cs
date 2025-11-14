using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07831 - .
/// </summary>
public class F07831 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YBIDYE.
        /// </summary>
        public const string YBIDYE = "YBIDYE";

        /// <summary>
        /// YBDTEY.
        /// </summary>
        public const string YBDTEY = "YBDTEY";

        /// <summary>
        /// YBTAXX.
        /// </summary>
        public const string YBTAXX = "YBTAXX";

        /// <summary>
        /// YBCO.
        /// </summary>
        public const string YBCO = "YBCO";

        /// <summary>
        /// YBAN8.
        /// </summary>
        public const string YBAN8 = "YBAN8";

        /// <summary>
        /// YBTFYE.
        /// </summary>
        public const string YBTFYE = "YBTFYE";

        /// <summary>
        /// YBTWYE.
        /// </summary>
        public const string YBTWYE = "YBTWYE";

        /// <summary>
        /// YBCORF.
        /// </summary>
        public const string YBCORF = "YBCORF";

        /// <summary>
        /// YBDTCF.
        /// </summary>
        public const string YBDTCF = "YBDTCF";

        /// <summary>
        /// YBPTAX.
        /// </summary>
        public const string YBPTAX = "YBPTAX";

        /// <summary>
        /// YBWST.
        /// </summary>
        public const string YBWST = "YBWST";

        /// <summary>
        /// YBPRTR.
        /// </summary>
        public const string YBPRTR = "YBPRTR";

        /// <summary>
        /// YBWCN.
        /// </summary>
        public const string YBWCN = "YBWCN";

        /// <summary>
        /// YBWSCN.
        /// </summary>
        public const string YBWSCN = "YBWSCN";

        /// <summary>
        /// YBW2RT.
        /// </summary>
        public const string YBW2RT = "YBW2RT";

        /// <summary>
        /// YBTIS.
        /// </summary>
        public const string YBTIS = "YBTIS";

        /// <summary>
        /// YBSSN.
        /// </summary>
        public const string YBSSN = "YBSSN";

        /// <summary>
        /// YBTAXS.
        /// </summary>
        public const string YBTAXS = "YBTAXS";

        /// <summary>
        /// YBSCOD.
        /// </summary>
        public const string YBSCOD = "YBSCOD";

        /// <summary>
        /// YBW2DS.
        /// </summary>
        public const string YBW2DS = "YBW2DS";

        /// <summary>
        /// YBWCNT.
        /// </summary>
        public const string YBWCNT = "YBWCNT";

        /// <summary>
        /// YBWCTY.
        /// </summary>
        public const string YBWCTY = "YBWCTY";

        /// <summary>
        /// YBSTWG.
        /// </summary>
        public const string YBSTWG = "YBSTWG";

        /// <summary>
        /// YBSTAJ.
        /// </summary>
        public const string YBSTAJ = "YBSTAJ";

        /// <summary>
        /// YBSTTX.
        /// </summary>
        public const string YBSTTX = "YBSTTX";

        /// <summary>
        /// YBFDWG.
        /// </summary>
        public const string YBFDWG = "YBFDWG";

        /// <summary>
        /// YBFDTX.
        /// </summary>
        public const string YBFDTX = "YBFDTX";

        /// <summary>
        /// YBALPC.
        /// </summary>
        public const string YBALPC = "YBALPC";

        /// <summary>
        /// YBW2SU.
        /// </summary>
        public const string YBW2SU = "YBW2SU";

        /// <summary>
        /// YBW2SD.
        /// </summary>
        public const string YBW2SD = "YBW2SD";

        /// <summary>
        /// YBW2PC.
        /// </summary>
        public const string YBW2PC = "YBW2PC";

        /// <summary>
        /// YBW2BF.
        /// </summary>
        public const string YBW2BF = "YBW2BF";

        /// <summary>
        /// YBW2P1.
        /// </summary>
        public const string YBW2P1 = "YBW2P1";

        /// <summary>
        /// YBDTMT.
        /// </summary>
        public const string YBDTMT = "YBDTMT";

        /// <summary>
        /// YBPALF.
        /// </summary>
        public const string YBPALF = "YBPALF";

        /// <summary>
        /// YBHMCO.
        /// </summary>
        public const string YBHMCO = "YBHMCO";

        /// <summary>
        /// YBHMCU.
        /// </summary>
        public const string YBHMCU = "YBHMCU";

        /// <summary>
        /// YBADDZ.
        /// </summary>
        public const string YBADDZ = "YBADDZ";

        /// <summary>
        /// YBMAIL.
        /// </summary>
        public const string YBMAIL = "YBMAIL";

        /// <summary>
        /// YBSG.
        /// </summary>
        public const string YBSG = "YBSG";

        /// <summary>
        /// YBPWCN.
        /// </summary>
        public const string YBPWCN = "YBPWCN";

        /// <summary>
        /// YBPFRQ.
        /// </summary>
        public const string YBPFRQ = "YBPFRQ";

        /// <summary>
        /// YBPAST.
        /// </summary>
        public const string YBPAST = "YBPAST";

        /// <summary>
        /// YBDT.
        /// </summary>
        public const string YBDT = "YBDT";

        /// <summary>
        /// YBTXSU.
        /// </summary>
        public const string YBTXSU = "YBTXSU";

        /// <summary>
        /// YBSUWG.
        /// </summary>
        public const string YBSUWG = "YBSUWG";

        /// <summary>
        /// YBUPMJ.
        /// </summary>
        public const string YBUPMJ = "YBUPMJ";

        /// <summary>
        /// YBUPMT.
        /// </summary>
        public const string YBUPMT = "YBUPMT";

        /// <summary>
        /// YBPID.
        /// </summary>
        public const string YBPID = "YBPID";

        /// <summary>
        /// YBJOBN.
        /// </summary>
        public const string YBJOBN = "YBJOBN";

        /// <summary>
        /// YBUSER.
        /// </summary>
        public const string YBUSER = "YBUSER";

        /// <summary>
        /// YBSEIC.
        /// </summary>
        public const string YBSEIC = "YBSEIC";

        /// <summary>
        /// YBSCDC.
        /// </summary>
        public const string YBSCDC = "YBSCDC";
    }

    /// <inheritdoc />
    public override string TableName => "F07831";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YBIDYE", "YBIDYE", JdeDataType.String, 20, true, true),
        new JdeField("YBDTEY", "YBDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YBTAXX", "YBTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YBCO", "YBCO", JdeDataType.String, 10, true, true),
        new JdeField("YBAN8", "YBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YBTFYE", "YBTFYE", JdeDataType.String, 2, true, true),
        new JdeField("YBTWYE", "YBTWYE", JdeDataType.String, 2, true, true),
        new JdeField("YBCORF", "YBCORF", JdeDataType.String, 2, true, true),
        new JdeField("YBDTCF", "YBDTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("YBPTAX", "YBPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YBWST", "YBWST", JdeDataType.Numeric, null, true, true),
        new JdeField("YBPRTR", "YBPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YBWCN", "YBWCN", JdeDataType.Numeric),
        new JdeField("YBWSCN", "YBWSCN", JdeDataType.Numeric),
        new JdeField("YBW2RT", "YBW2RT", JdeDataType.String, 2),
        new JdeField("YBTIS", "YBTIS", JdeDataType.String, 2),
        new JdeField("YBSSN", "YBSSN", JdeDataType.String, 40),
        new JdeField("YBTAXS", "YBTAXS", JdeDataType.String, 40),
        new JdeField("YBSCOD", "YBSCOD", JdeDataType.String, 6),
        new JdeField("YBW2DS", "YBW2DS", JdeDataType.String, 20),
        new JdeField("YBWCNT", "YBWCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("YBWCTY", "YBWCTY", JdeDataType.Numeric, null, true, true),
        new JdeField("YBSTWG", "YBSTWG", JdeDataType.Numeric),
        new JdeField("YBSTAJ", "YBSTAJ", JdeDataType.Numeric),
        new JdeField("YBSTTX", "YBSTTX", JdeDataType.Numeric),
        new JdeField("YBFDWG", "YBFDWG", JdeDataType.Numeric),
        new JdeField("YBFDTX", "YBFDTX", JdeDataType.Numeric),
        new JdeField("YBALPC", "YBALPC", JdeDataType.Numeric),
        new JdeField("YBW2SU", "YBW2SU", JdeDataType.Numeric),
        new JdeField("YBW2SD", "YBW2SD", JdeDataType.Numeric),
        new JdeField("YBW2PC", "YBW2PC", JdeDataType.String, 2),
        new JdeField("YBW2BF", "YBW2BF", JdeDataType.String, 2),
        new JdeField("YBW2P1", "YBW2P1", JdeDataType.Numeric),
        new JdeField("YBDTMT", "YBDTMT", JdeDataType.Numeric),
        new JdeField("YBPALF", "YBPALF", JdeDataType.String, 24),
        new JdeField("YBHMCO", "YBHMCO", JdeDataType.String, 10),
        new JdeField("YBHMCU", "YBHMCU", JdeDataType.String, 24),
        new JdeField("YBADDZ", "YBADDZ", JdeDataType.String, 24),
        new JdeField("YBMAIL", "YBMAIL", JdeDataType.String, 20),
        new JdeField("YBSG", "YBSG", JdeDataType.String, 24),
        new JdeField("YBPWCN", "YBPWCN", JdeDataType.Numeric),
        new JdeField("YBPFRQ", "YBPFRQ", JdeDataType.String, 2),
        new JdeField("YBPAST", "YBPAST", JdeDataType.String, 2),
        new JdeField("YBDT", "YBDT", JdeDataType.Numeric),
        new JdeField("YBTXSU", "YBTXSU", JdeDataType.String, 40),
        new JdeField("YBSUWG", "YBSUWG", JdeDataType.Numeric),
        new JdeField("YBUPMJ", "YBUPMJ", JdeDataType.Numeric),
        new JdeField("YBUPMT", "YBUPMT", JdeDataType.Numeric),
        new JdeField("YBPID", "YBPID", JdeDataType.String, 20),
        new JdeField("YBJOBN", "YBJOBN", JdeDataType.String, 20),
        new JdeField("YBUSER", "YBUSER", JdeDataType.String, 20),
        new JdeField("YBSEIC", "YBSEIC", JdeDataType.Numeric),
        new JdeField("YBSCDC", "YBSCDC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07831_0", "Primary Key on YBIDYE, YBDTEY, YBTAXX, YBCO, YBAN8, YBTFYE, YBTWYE, YBCORF, YBDTCF, YBPTAX, YBWST, YBWCNT, YBWCTY, YBPRTR, YBSCDC", new[] { "YBIDYE", "YBDTEY", "YBTAXX", "YBCO", "YBAN8", "YBTFYE", "YBTWYE", "YBCORF", "YBDTCF", "YBPTAX", "YBWST", "YBWCNT", "YBWCTY", "YBPRTR", "YBSCDC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07831_10", "Index on YBIDYE, YBDTEY, YBWCN, YBAN8, YBCO, YBWST, YBWCNT, YBWCTY, YBPTAX", new[] { "YBIDYE", "YBDTEY", "YBWCN", "YBAN8", "YBCO", "YBWST", "YBWCNT", "YBWCTY", "YBPTAX" }),
        new JdeIndex("F07831_11", "Index on YBIDYE, YBDTEY, YBTAXX, YBTFYE, YBTWYE", new[] { "YBIDYE", "YBDTEY", "YBTAXX", "YBTFYE", "YBTWYE" }),
        new JdeIndex("F07831_12", "Index on YBIDYE, YBDTEY, YBTAXX, YBAN8, YBTFYE, YBTWYE, YBCORF, YBDTCF, YBW2RT, YBTIS", new[] { "YBIDYE", "YBDTEY", "YBTAXX", "YBAN8", "YBTFYE", "YBTWYE", "YBCORF", "YBDTCF", "YBW2RT", "YBTIS" }),
        new JdeIndex("F07831_13", "Index on YBIDYE, YBDTEY, YBAN8, YBTFYE, YBPRTR", new[] { "YBIDYE", "YBDTEY", "YBAN8", "YBTFYE", "YBPRTR" }),
        new JdeIndex("F07831_14", "Index on YBIDYE, YBDTEY, YBTAXX, YBCO, YBAN8, YBTFYE, YBTWYE, YBPTAX, YBW2RT, YBWCN", new[] { "YBIDYE", "YBDTEY", "YBTAXX", "YBCO", "YBAN8", "YBTFYE", "YBTWYE", "YBPTAX", "YBW2RT", "YBWCN" }),
        new JdeIndex("F07831_15", "Index on YBIDYE, YBDTEY, YBPTAX, YBW2RT, YBTAXX, YBCO, YBAN8, YBTFYE, YBTWYE, YBCORF, YBDTCF, YBWST, YBWCNT, YBWCTY, YBSCDC", new[] { "YBIDYE", "YBDTEY", "YBPTAX", "YBW2RT", "YBTAXX", "YBCO", "YBAN8", "YBTFYE", "YBTWYE", "YBCORF", "YBDTCF", "YBWST", "YBWCNT", "YBWCTY", "YBSCDC" }),
        new JdeIndex("F07831_2", "Index on YBIDYE, YBDTEY, YBTFYE, YBTAXX, YBCO, YBAN8", new[] { "YBIDYE", "YBDTEY", "YBTFYE", "YBTAXX", "YBCO", "YBAN8" }),
        new JdeIndex("F07831_3", "Index on YBDTEY, YBTFYE, YBAN8, YBWCN", new[] { "YBDTEY", "YBTFYE", "YBAN8", "YBWCN" }),
        new JdeIndex("F07831_4", "Index on YBIDYE, YBDTEY, YBPTAX, YBW2RT, YBTAXX, YBCO, YBAN8, YBTFYE, YBTWYE, YBCORF, YBDTCF, YBWST, YBWCNT, YBWCTY", new[] { "YBIDYE", "YBDTEY", "YBPTAX", "YBW2RT", "YBTAXX", "YBCO", "YBAN8", "YBTFYE", "YBTWYE", "YBCORF", "YBDTCF", "YBWST", "YBWCNT", "YBWCTY" }),
        new JdeIndex("F07831_5", "Index on YBIDYE, YBDTEY, YBWCN, YBTAXX, YBSSN, YBTWYE, SYS_NC00054$", new[] { "YBIDYE", "YBDTEY", "YBWCN", "YBTAXX", "YBSSN", "YBTWYE", "SYS_NC00054$" }),
        new JdeIndex("F07831_6", "Index on YBIDYE, YBDTEY, YBTFYE, YBWCN, YBPTAX, YBW2BF", new[] { "YBIDYE", "YBDTEY", "YBTFYE", "YBWCN", "YBPTAX", "YBW2BF" }),
        new JdeIndex("F07831_7", "Index on YBIDYE, YBDTEY, YBAN8, YBTAXX, YBTFYE, YBTWYE, YBCORF, YBDTCF, YBPTAX, YBWST, YBWCNT, YBWCTY, YBW2RT", new[] { "YBIDYE", "YBDTEY", "YBAN8", "YBTAXX", "YBTFYE", "YBTWYE", "YBCORF", "YBDTCF", "YBPTAX", "YBWST", "YBWCNT", "YBWCTY", "YBW2RT" }),
        new JdeIndex("F07831_8", "Index on YBIDYE, YBDTEY, YBTAXX, YBCO, YBAN8, YBTFYE, YBTWYE, YBCORF, YBDTCF, YBWST, YBWCNT, YBWCTY", new[] { "YBIDYE", "YBDTEY", "YBTAXX", "YBCO", "YBAN8", "YBTFYE", "YBTWYE", "YBCORF", "YBDTCF", "YBWST", "YBWCNT", "YBWCTY" })
    };
}
