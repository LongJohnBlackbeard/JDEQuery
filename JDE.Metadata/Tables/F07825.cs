using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07825 - .
/// </summary>
public class F07825 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAIDYE.
        /// </summary>
        public const string JAIDYE = "JAIDYE";

        /// <summary>
        /// JADTEY.
        /// </summary>
        public const string JADTEY = "JADTEY";

        /// <summary>
        /// JAHMCO.
        /// </summary>
        public const string JAHMCO = "JAHMCO";

        /// <summary>
        /// JATAXX.
        /// </summary>
        public const string JATAXX = "JATAXX";

        /// <summary>
        /// JAW2RT.
        /// </summary>
        public const string JAW2RT = "JAW2RT";

        /// <summary>
        /// JATFYE.
        /// </summary>
        public const string JATFYE = "JATFYE";

        /// <summary>
        /// JATWYE.
        /// </summary>
        public const string JATWYE = "JATWYE";

        /// <summary>
        /// JADTCF.
        /// </summary>
        public const string JADTCF = "JADTCF";

        /// <summary>
        /// JAWST.
        /// </summary>
        public const string JAWST = "JAWST";

        /// <summary>
        /// JAWCNT.
        /// </summary>
        public const string JAWCNT = "JAWCNT";

        /// <summary>
        /// JAWCTY.
        /// </summary>
        public const string JAWCTY = "JAWCTY";

        /// <summary>
        /// JAPDBA.
        /// </summary>
        public const string JAPDBA = "JAPDBA";

        /// <summary>
        /// JAAMSP.
        /// </summary>
        public const string JAAMSP = "JAAMSP";

        /// <summary>
        /// JAW2EX.
        /// </summary>
        public const string JAW2EX = "JAW2EX";

        /// <summary>
        /// JAHT01.
        /// </summary>
        public const string JAHT01 = "JAHT01";

        /// <summary>
        /// JAHT02.
        /// </summary>
        public const string JAHT02 = "JAHT02";

        /// <summary>
        /// JAHT03.
        /// </summary>
        public const string JAHT03 = "JAHT03";

        /// <summary>
        /// JAHT04.
        /// </summary>
        public const string JAHT04 = "JAHT04";

        /// <summary>
        /// JAHT05.
        /// </summary>
        public const string JAHT05 = "JAHT05";

        /// <summary>
        /// JAHT06.
        /// </summary>
        public const string JAHT06 = "JAHT06";

        /// <summary>
        /// JAHT07.
        /// </summary>
        public const string JAHT07 = "JAHT07";

        /// <summary>
        /// JAHT08.
        /// </summary>
        public const string JAHT08 = "JAHT08";

        /// <summary>
        /// JAHT09.
        /// </summary>
        public const string JAHT09 = "JAHT09";

        /// <summary>
        /// JAHT10.
        /// </summary>
        public const string JAHT10 = "JAHT10";

        /// <summary>
        /// JAHT11.
        /// </summary>
        public const string JAHT11 = "JAHT11";

        /// <summary>
        /// JAHT12.
        /// </summary>
        public const string JAHT12 = "JAHT12";

        /// <summary>
        /// JAHT13.
        /// </summary>
        public const string JAHT13 = "JAHT13";

        /// <summary>
        /// JAHT14.
        /// </summary>
        public const string JAHT14 = "JAHT14";

        /// <summary>
        /// JAHT15.
        /// </summary>
        public const string JAHT15 = "JAHT15";

        /// <summary>
        /// JAHT16.
        /// </summary>
        public const string JAHT16 = "JAHT16";

        /// <summary>
        /// JAHT17.
        /// </summary>
        public const string JAHT17 = "JAHT17";

        /// <summary>
        /// JAHT18.
        /// </summary>
        public const string JAHT18 = "JAHT18";

        /// <summary>
        /// JAHT19.
        /// </summary>
        public const string JAHT19 = "JAHT19";

        /// <summary>
        /// JAHT20.
        /// </summary>
        public const string JAHT20 = "JAHT20";

        /// <summary>
        /// JAHT21.
        /// </summary>
        public const string JAHT21 = "JAHT21";

        /// <summary>
        /// JAHT22.
        /// </summary>
        public const string JAHT22 = "JAHT22";

        /// <summary>
        /// JAHT23.
        /// </summary>
        public const string JAHT23 = "JAHT23";

        /// <summary>
        /// JAHT24.
        /// </summary>
        public const string JAHT24 = "JAHT24";

        /// <summary>
        /// JAHT25.
        /// </summary>
        public const string JAHT25 = "JAHT25";

        /// <summary>
        /// JAHT26.
        /// </summary>
        public const string JAHT26 = "JAHT26";

        /// <summary>
        /// JAHT27.
        /// </summary>
        public const string JAHT27 = "JAHT27";

        /// <summary>
        /// JAHT28.
        /// </summary>
        public const string JAHT28 = "JAHT28";

        /// <summary>
        /// JAHT29.
        /// </summary>
        public const string JAHT29 = "JAHT29";

        /// <summary>
        /// JAHT30.
        /// </summary>
        public const string JAHT30 = "JAHT30";

        /// <summary>
        /// JAUPMJ.
        /// </summary>
        public const string JAUPMJ = "JAUPMJ";

        /// <summary>
        /// JAUPMT.
        /// </summary>
        public const string JAUPMT = "JAUPMT";

        /// <summary>
        /// JAPID.
        /// </summary>
        public const string JAPID = "JAPID";

        /// <summary>
        /// JAJOBN.
        /// </summary>
        public const string JAJOBN = "JAJOBN";

        /// <summary>
        /// JAUSER.
        /// </summary>
        public const string JAUSER = "JAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07825";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAIDYE", "JAIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JADTEY", "JADTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JAHMCO", "JAHMCO", JdeDataType.String, 10, true, true),
        new JdeField("JATAXX", "JATAXX", JdeDataType.String, 40, true, true),
        new JdeField("JAW2RT", "JAW2RT", JdeDataType.String, 2, true, true),
        new JdeField("JATFYE", "JATFYE", JdeDataType.String, 2, true, true),
        new JdeField("JATWYE", "JATWYE", JdeDataType.String, 2, true, true),
        new JdeField("JADTCF", "JADTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("JAWST", "JAWST", JdeDataType.Numeric, null, true, true),
        new JdeField("JAWCNT", "JAWCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("JAWCTY", "JAWCTY", JdeDataType.Numeric, null, true, true),
        new JdeField("JAPDBA", "JAPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JAAMSP", "JAAMSP", JdeDataType.Numeric),
        new JdeField("JAW2EX", "JAW2EX", JdeDataType.String, 20),
        new JdeField("JAHT01", "JAHT01", JdeDataType.String, 2),
        new JdeField("JAHT02", "JAHT02", JdeDataType.String, 2),
        new JdeField("JAHT03", "JAHT03", JdeDataType.String, 2),
        new JdeField("JAHT04", "JAHT04", JdeDataType.String, 2),
        new JdeField("JAHT05", "JAHT05", JdeDataType.String, 2),
        new JdeField("JAHT06", "JAHT06", JdeDataType.String, 2),
        new JdeField("JAHT07", "JAHT07", JdeDataType.String, 2),
        new JdeField("JAHT08", "JAHT08", JdeDataType.String, 2),
        new JdeField("JAHT09", "JAHT09", JdeDataType.String, 2),
        new JdeField("JAHT10", "JAHT10", JdeDataType.String, 2),
        new JdeField("JAHT11", "JAHT11", JdeDataType.String, 2),
        new JdeField("JAHT12", "JAHT12", JdeDataType.String, 2),
        new JdeField("JAHT13", "JAHT13", JdeDataType.String, 2),
        new JdeField("JAHT14", "JAHT14", JdeDataType.String, 2),
        new JdeField("JAHT15", "JAHT15", JdeDataType.String, 2),
        new JdeField("JAHT16", "JAHT16", JdeDataType.String, 2),
        new JdeField("JAHT17", "JAHT17", JdeDataType.String, 2),
        new JdeField("JAHT18", "JAHT18", JdeDataType.String, 2),
        new JdeField("JAHT19", "JAHT19", JdeDataType.String, 2),
        new JdeField("JAHT20", "JAHT20", JdeDataType.String, 2),
        new JdeField("JAHT21", "JAHT21", JdeDataType.String, 2),
        new JdeField("JAHT22", "JAHT22", JdeDataType.String, 2),
        new JdeField("JAHT23", "JAHT23", JdeDataType.String, 2),
        new JdeField("JAHT24", "JAHT24", JdeDataType.String, 2),
        new JdeField("JAHT25", "JAHT25", JdeDataType.String, 2),
        new JdeField("JAHT26", "JAHT26", JdeDataType.String, 2),
        new JdeField("JAHT27", "JAHT27", JdeDataType.String, 2),
        new JdeField("JAHT28", "JAHT28", JdeDataType.String, 2),
        new JdeField("JAHT29", "JAHT29", JdeDataType.String, 2),
        new JdeField("JAHT30", "JAHT30", JdeDataType.String, 2),
        new JdeField("JAUPMJ", "JAUPMJ", JdeDataType.Numeric),
        new JdeField("JAUPMT", "JAUPMT", JdeDataType.Numeric),
        new JdeField("JAPID", "JAPID", JdeDataType.String, 20),
        new JdeField("JAJOBN", "JAJOBN", JdeDataType.String, 20),
        new JdeField("JAUSER", "JAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07825_0", "Primary Key on JAIDYE, JADTEY, JAHMCO, JAWST, JAWCNT, JAWCTY, JAPDBA, JATAXX, JATFYE, JATWYE, JADTCF, JAW2RT", new[] { "JAIDYE", "JADTEY", "JAHMCO", "JAWST", "JAWCNT", "JAWCTY", "JAPDBA", "JATAXX", "JATFYE", "JATWYE", "JADTCF", "JAW2RT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07825_2", "Index on JAIDYE, JADTEY, JAHMCO, JAPDBA", new[] { "JAIDYE", "JADTEY", "JAHMCO", "JAPDBA" }),
        new JdeIndex("F07825_3", "Index on JAIDYE, JADTEY, JAHMCO, JATAXX, JAW2RT, JATFYE, JATWYE, JADTCF, JAHT05", new[] { "JAIDYE", "JADTEY", "JAHMCO", "JATAXX", "JAW2RT", "JATFYE", "JATWYE", "JADTCF", "JAHT05" })
    };
}
