using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07832 - .
/// </summary>
public class F07832 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YHIDYE.
        /// </summary>
        public const string YHIDYE = "YHIDYE";

        /// <summary>
        /// YHDTEY.
        /// </summary>
        public const string YHDTEY = "YHDTEY";

        /// <summary>
        /// YHTAXX.
        /// </summary>
        public const string YHTAXX = "YHTAXX";

        /// <summary>
        /// YHAN8.
        /// </summary>
        public const string YHAN8 = "YHAN8";

        /// <summary>
        /// YHTFYE.
        /// </summary>
        public const string YHTFYE = "YHTFYE";

        /// <summary>
        /// YHTWYE.
        /// </summary>
        public const string YHTWYE = "YHTWYE";

        /// <summary>
        /// YHCORF.
        /// </summary>
        public const string YHCORF = "YHCORF";

        /// <summary>
        /// YHDTCF.
        /// </summary>
        public const string YHDTCF = "YHDTCF";

        /// <summary>
        /// YHPDBA.
        /// </summary>
        public const string YHPDBA = "YHPDBA";

        /// <summary>
        /// YHWST.
        /// </summary>
        public const string YHWST = "YHWST";

        /// <summary>
        /// YHWCNT.
        /// </summary>
        public const string YHWCNT = "YHWCNT";

        /// <summary>
        /// YHWCTY.
        /// </summary>
        public const string YHWCTY = "YHWCTY";

        /// <summary>
        /// YHW2RT.
        /// </summary>
        public const string YHW2RT = "YHW2RT";

        /// <summary>
        /// YHW2EX.
        /// </summary>
        public const string YHW2EX = "YHW2EX";

        /// <summary>
        /// YHWCN.
        /// </summary>
        public const string YHWCN = "YHWCN";

        /// <summary>
        /// YHWSCN.
        /// </summary>
        public const string YHWSCN = "YHWSCN";

        /// <summary>
        /// YHTIS.
        /// </summary>
        public const string YHTIS = "YHTIS";

        /// <summary>
        /// YHSSN.
        /// </summary>
        public const string YHSSN = "YHSSN";

        /// <summary>
        /// YHCO.
        /// </summary>
        public const string YHCO = "YHCO";

        /// <summary>
        /// YHAMSP.
        /// </summary>
        public const string YHAMSP = "YHAMSP";

        /// <summary>
        /// YHPALF.
        /// </summary>
        public const string YHPALF = "YHPALF";

        /// <summary>
        /// YHHMCO.
        /// </summary>
        public const string YHHMCO = "YHHMCO";

        /// <summary>
        /// YHHMCU.
        /// </summary>
        public const string YHHMCU = "YHHMCU";

        /// <summary>
        /// YHADDZ.
        /// </summary>
        public const string YHADDZ = "YHADDZ";

        /// <summary>
        /// YHMAIL.
        /// </summary>
        public const string YHMAIL = "YHMAIL";

        /// <summary>
        /// YHSG.
        /// </summary>
        public const string YHSG = "YHSG";

        /// <summary>
        /// YHW2P1.
        /// </summary>
        public const string YHW2P1 = "YHW2P1";

        /// <summary>
        /// YHDTMT.
        /// </summary>
        public const string YHDTMT = "YHDTMT";

        /// <summary>
        /// YHHT01.
        /// </summary>
        public const string YHHT01 = "YHHT01";

        /// <summary>
        /// YHHT02.
        /// </summary>
        public const string YHHT02 = "YHHT02";

        /// <summary>
        /// YHHT03.
        /// </summary>
        public const string YHHT03 = "YHHT03";

        /// <summary>
        /// YHHT04.
        /// </summary>
        public const string YHHT04 = "YHHT04";

        /// <summary>
        /// YHHT05.
        /// </summary>
        public const string YHHT05 = "YHHT05";

        /// <summary>
        /// YHHT06.
        /// </summary>
        public const string YHHT06 = "YHHT06";

        /// <summary>
        /// YHHT07.
        /// </summary>
        public const string YHHT07 = "YHHT07";

        /// <summary>
        /// YHHT08.
        /// </summary>
        public const string YHHT08 = "YHHT08";

        /// <summary>
        /// YHHT09.
        /// </summary>
        public const string YHHT09 = "YHHT09";

        /// <summary>
        /// YHHT10.
        /// </summary>
        public const string YHHT10 = "YHHT10";

        /// <summary>
        /// YHHT11.
        /// </summary>
        public const string YHHT11 = "YHHT11";

        /// <summary>
        /// YHHT12.
        /// </summary>
        public const string YHHT12 = "YHHT12";

        /// <summary>
        /// YHHT13.
        /// </summary>
        public const string YHHT13 = "YHHT13";

        /// <summary>
        /// YHHT14.
        /// </summary>
        public const string YHHT14 = "YHHT14";

        /// <summary>
        /// YHHT15.
        /// </summary>
        public const string YHHT15 = "YHHT15";

        /// <summary>
        /// YHHT16.
        /// </summary>
        public const string YHHT16 = "YHHT16";

        /// <summary>
        /// YHHT17.
        /// </summary>
        public const string YHHT17 = "YHHT17";

        /// <summary>
        /// YHHT18.
        /// </summary>
        public const string YHHT18 = "YHHT18";

        /// <summary>
        /// YHHT19.
        /// </summary>
        public const string YHHT19 = "YHHT19";

        /// <summary>
        /// YHHT20.
        /// </summary>
        public const string YHHT20 = "YHHT20";

        /// <summary>
        /// YHHT21.
        /// </summary>
        public const string YHHT21 = "YHHT21";

        /// <summary>
        /// YHHT22.
        /// </summary>
        public const string YHHT22 = "YHHT22";

        /// <summary>
        /// YHHT23.
        /// </summary>
        public const string YHHT23 = "YHHT23";

        /// <summary>
        /// YHHT24.
        /// </summary>
        public const string YHHT24 = "YHHT24";

        /// <summary>
        /// YHHT25.
        /// </summary>
        public const string YHHT25 = "YHHT25";

        /// <summary>
        /// YHHT26.
        /// </summary>
        public const string YHHT26 = "YHHT26";

        /// <summary>
        /// YHHT27.
        /// </summary>
        public const string YHHT27 = "YHHT27";

        /// <summary>
        /// YHHT28.
        /// </summary>
        public const string YHHT28 = "YHHT28";

        /// <summary>
        /// YHHT29.
        /// </summary>
        public const string YHHT29 = "YHHT29";

        /// <summary>
        /// YHHT30.
        /// </summary>
        public const string YHHT30 = "YHHT30";

        /// <summary>
        /// YHPFRQ.
        /// </summary>
        public const string YHPFRQ = "YHPFRQ";

        /// <summary>
        /// YHPAST.
        /// </summary>
        public const string YHPAST = "YHPAST";

        /// <summary>
        /// YHDT.
        /// </summary>
        public const string YHDT = "YHDT";

        /// <summary>
        /// YHUPMJ.
        /// </summary>
        public const string YHUPMJ = "YHUPMJ";

        /// <summary>
        /// YHUPMT.
        /// </summary>
        public const string YHUPMT = "YHUPMT";

        /// <summary>
        /// YHPID.
        /// </summary>
        public const string YHPID = "YHPID";

        /// <summary>
        /// YHJOBN.
        /// </summary>
        public const string YHJOBN = "YHJOBN";

        /// <summary>
        /// YHUSER.
        /// </summary>
        public const string YHUSER = "YHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07832";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YHIDYE", "YHIDYE", JdeDataType.String, 20, true, true),
        new JdeField("YHDTEY", "YHDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YHTAXX", "YHTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YHAN8", "YHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YHTFYE", "YHTFYE", JdeDataType.String, 2, true, true),
        new JdeField("YHTWYE", "YHTWYE", JdeDataType.String, 2, true, true),
        new JdeField("YHCORF", "YHCORF", JdeDataType.String, 2, true, true),
        new JdeField("YHDTCF", "YHDTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("YHPDBA", "YHPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YHWST", "YHWST", JdeDataType.Numeric, null, true, true),
        new JdeField("YHWCNT", "YHWCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("YHWCTY", "YHWCTY", JdeDataType.Numeric, null, true, true),
        new JdeField("YHW2RT", "YHW2RT", JdeDataType.String, 2, true, true),
        new JdeField("YHW2EX", "YHW2EX", JdeDataType.String, 20),
        new JdeField("YHWCN", "YHWCN", JdeDataType.Numeric),
        new JdeField("YHWSCN", "YHWSCN", JdeDataType.Numeric),
        new JdeField("YHTIS", "YHTIS", JdeDataType.String, 2),
        new JdeField("YHSSN", "YHSSN", JdeDataType.String, 40),
        new JdeField("YHCO", "YHCO", JdeDataType.String, 10, true, true),
        new JdeField("YHAMSP", "YHAMSP", JdeDataType.Numeric),
        new JdeField("YHPALF", "YHPALF", JdeDataType.String, 24),
        new JdeField("YHHMCO", "YHHMCO", JdeDataType.String, 10),
        new JdeField("YHHMCU", "YHHMCU", JdeDataType.String, 24),
        new JdeField("YHADDZ", "YHADDZ", JdeDataType.String, 24),
        new JdeField("YHMAIL", "YHMAIL", JdeDataType.String, 20),
        new JdeField("YHSG", "YHSG", JdeDataType.String, 24),
        new JdeField("YHW2P1", "YHW2P1", JdeDataType.Numeric),
        new JdeField("YHDTMT", "YHDTMT", JdeDataType.Numeric),
        new JdeField("YHHT01", "YHHT01", JdeDataType.String, 2),
        new JdeField("YHHT02", "YHHT02", JdeDataType.String, 2),
        new JdeField("YHHT03", "YHHT03", JdeDataType.String, 2),
        new JdeField("YHHT04", "YHHT04", JdeDataType.String, 2),
        new JdeField("YHHT05", "YHHT05", JdeDataType.String, 2),
        new JdeField("YHHT06", "YHHT06", JdeDataType.String, 2),
        new JdeField("YHHT07", "YHHT07", JdeDataType.String, 2),
        new JdeField("YHHT08", "YHHT08", JdeDataType.String, 2),
        new JdeField("YHHT09", "YHHT09", JdeDataType.String, 2),
        new JdeField("YHHT10", "YHHT10", JdeDataType.String, 2),
        new JdeField("YHHT11", "YHHT11", JdeDataType.String, 2),
        new JdeField("YHHT12", "YHHT12", JdeDataType.String, 2),
        new JdeField("YHHT13", "YHHT13", JdeDataType.String, 2),
        new JdeField("YHHT14", "YHHT14", JdeDataType.String, 2),
        new JdeField("YHHT15", "YHHT15", JdeDataType.String, 2),
        new JdeField("YHHT16", "YHHT16", JdeDataType.String, 2),
        new JdeField("YHHT17", "YHHT17", JdeDataType.String, 2),
        new JdeField("YHHT18", "YHHT18", JdeDataType.String, 2),
        new JdeField("YHHT19", "YHHT19", JdeDataType.String, 2),
        new JdeField("YHHT20", "YHHT20", JdeDataType.String, 2),
        new JdeField("YHHT21", "YHHT21", JdeDataType.String, 2),
        new JdeField("YHHT22", "YHHT22", JdeDataType.String, 2),
        new JdeField("YHHT23", "YHHT23", JdeDataType.String, 2),
        new JdeField("YHHT24", "YHHT24", JdeDataType.String, 2),
        new JdeField("YHHT25", "YHHT25", JdeDataType.String, 2),
        new JdeField("YHHT26", "YHHT26", JdeDataType.String, 2),
        new JdeField("YHHT27", "YHHT27", JdeDataType.String, 2),
        new JdeField("YHHT28", "YHHT28", JdeDataType.String, 2),
        new JdeField("YHHT29", "YHHT29", JdeDataType.String, 2),
        new JdeField("YHHT30", "YHHT30", JdeDataType.String, 2),
        new JdeField("YHPFRQ", "YHPFRQ", JdeDataType.String, 2),
        new JdeField("YHPAST", "YHPAST", JdeDataType.String, 2),
        new JdeField("YHDT", "YHDT", JdeDataType.Numeric),
        new JdeField("YHUPMJ", "YHUPMJ", JdeDataType.Numeric),
        new JdeField("YHUPMT", "YHUPMT", JdeDataType.Numeric),
        new JdeField("YHPID", "YHPID", JdeDataType.String, 20),
        new JdeField("YHJOBN", "YHJOBN", JdeDataType.String, 20),
        new JdeField("YHUSER", "YHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07832_0", "Primary Key on YHIDYE, YHDTEY, YHTAXX, YHAN8, YHTFYE, YHTWYE, YHCORF, YHDTCF, YHPDBA, YHWST, YHWCNT, YHWCTY, YHW2RT, YHCO", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHAN8", "YHTFYE", "YHTWYE", "YHCORF", "YHDTCF", "YHPDBA", "YHWST", "YHWCNT", "YHWCTY", "YHW2RT", "YHCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07832_10", "Index on YHIDYE, YHDTEY, YHTAXX, YHAN8, YHTFYE, YHTWYE, YHCORF, YHDTCF, YHCO", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHAN8", "YHTFYE", "YHTWYE", "YHCORF", "YHDTCF", "YHCO" }),
        new JdeIndex("F07832_11", "Index on YHIDYE, YHDTEY, YHTAXX, YHAN8, YHTFYE, YHTWYE, YHW2RT, YHCO", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHAN8", "YHTFYE", "YHTWYE", "YHW2RT", "YHCO" }),
        new JdeIndex("F07832_2", "Index on YHIDYE, YHDTEY, YHAN8, YHTAXX, YHTFYE, YHTWYE, YHCORF, YHDTCF, YHPDBA, YHWST, YHWCNT, YHWCTY, YHW2RT", new[] { "YHIDYE", "YHDTEY", "YHAN8", "YHTAXX", "YHTFYE", "YHTWYE", "YHCORF", "YHDTCF", "YHPDBA", "YHWST", "YHWCNT", "YHWCTY", "YHW2RT" }),
        new JdeIndex("F07832_3", "Index on YHIDYE, YHDTEY, YHTAXX, YHCO, YHAN8, YHTFYE, YHTWYE, YHCORF, YHDTCF, YHWST, YHWCNT, YHWCTY, YHW2EX", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHCO", "YHAN8", "YHTFYE", "YHTWYE", "YHCORF", "YHDTCF", "YHWST", "YHWCNT", "YHWCTY", "YHW2EX" }),
        new JdeIndex("F07832_4", "Index on YHIDYE, YHDTEY, YHWCN", new[] { "YHIDYE", "YHDTEY", "YHWCN" }),
        new JdeIndex("F07832_5", "Index on YHIDYE, YHDTEY, YHWCN, YHAN8, YHCO, YHWST, YHWCNT, YHWCTY", new[] { "YHIDYE", "YHDTEY", "YHWCN", "YHAN8", "YHCO", "YHWST", "YHWCNT", "YHWCTY" }),
        new JdeIndex("F07832_6", "Index on YHIDYE, YHDTEY, YHTAXX, YHCO, YHTIS, YHW2RT, YHTWYE, YHAN8", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHCO", "YHTIS", "YHW2RT", "YHTWYE", "YHAN8" }),
        new JdeIndex("F07832_7", "Index on YHIDYE, YHDTEY, YHTAXX, YHAN8, YHTFYE, YHCO", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHAN8", "YHTFYE", "YHCO" }),
        new JdeIndex("F07832_8", "Index on YHIDYE, YHDTEY, YHTAXX, YHAN8, YHDTCF", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHAN8", "YHDTCF" }),
        new JdeIndex("F07832_9", "Index on YHIDYE, YHDTEY, YHTAXX, YHCO, YHAN8, YHTFYE, YHTWYE, YHCORF, YHDTCF", new[] { "YHIDYE", "YHDTEY", "YHTAXX", "YHCO", "YHAN8", "YHTFYE", "YHTWYE", "YHCORF", "YHDTCF" })
    };
}
