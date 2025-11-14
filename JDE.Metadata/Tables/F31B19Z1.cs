using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B19Z1 - .
/// </summary>
public class F31B19Z1 : JdeTable
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
        /// SZWAPRN.
        /// </summary>
        public const string SZWAPRN = "SZWAPRN";

        /// <summary>
        /// SZWVID.
        /// </summary>
        public const string SZWVID = "SZWVID";

        /// <summary>
        /// SZWCFTF.
        /// </summary>
        public const string SZWCFTF = "SZWCFTF";

        /// <summary>
        /// SZWV2VLNID.
        /// </summary>
        public const string SZWV2VLNID = "SZWV2VLNID";

        /// <summary>
        /// SZINATTN1.
        /// </summary>
        public const string SZINATTN1 = "SZINATTN1";

        /// <summary>
        /// SZINATTN2.
        /// </summary>
        public const string SZINATTN2 = "SZINATTN2";

        /// <summary>
        /// SZINATTN3.
        /// </summary>
        public const string SZINATTN3 = "SZINATTN3";

        /// <summary>
        /// SZINATTN4.
        /// </summary>
        public const string SZINATTN4 = "SZINATTN4";

        /// <summary>
        /// SZINATTS5.
        /// </summary>
        public const string SZINATTS5 = "SZINATTS5";

        /// <summary>
        /// SZINATTS6.
        /// </summary>
        public const string SZINATTS6 = "SZINATTS6";

        /// <summary>
        /// SZINATTS7.
        /// </summary>
        public const string SZINATTS7 = "SZINATTS7";

        /// <summary>
        /// SZINATTS8.
        /// </summary>
        public const string SZINATTS8 = "SZINATTS8";

        /// <summary>
        /// SZINATTD9.
        /// </summary>
        public const string SZINATTD9 = "SZINATTD9";

        /// <summary>
        /// SZINATTD10.
        /// </summary>
        public const string SZINATTD10 = "SZINATTD10";

        /// <summary>
        /// SZINATTD11.
        /// </summary>
        public const string SZINATTD11 = "SZINATTD11";

        /// <summary>
        /// SZINATTD12.
        /// </summary>
        public const string SZINATTD12 = "SZINATTD12";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

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
        /// SZINATOVR1.
        /// </summary>
        public const string SZINATOVR1 = "SZINATOVR1";

        /// <summary>
        /// SZINATOVR2.
        /// </summary>
        public const string SZINATOVR2 = "SZINATOVR2";

        /// <summary>
        /// SZINATOVR3.
        /// </summary>
        public const string SZINATOVR3 = "SZINATOVR3";

        /// <summary>
        /// SZINATOVR4.
        /// </summary>
        public const string SZINATOVR4 = "SZINATOVR4";

        /// <summary>
        /// SZINATOVR5.
        /// </summary>
        public const string SZINATOVR5 = "SZINATOVR5";

        /// <summary>
        /// SZINATOVR6.
        /// </summary>
        public const string SZINATOVR6 = "SZINATOVR6";

        /// <summary>
        /// SZINATOVR7.
        /// </summary>
        public const string SZINATOVR7 = "SZINATOVR7";

        /// <summary>
        /// SZINATOVR8.
        /// </summary>
        public const string SZINATOVR8 = "SZINATOVR8";

        /// <summary>
        /// SZINATOVR9.
        /// </summary>
        public const string SZINATOVR9 = "SZINATOVR9";

        /// <summary>
        /// SZINAOVR10.
        /// </summary>
        public const string SZINAOVR10 = "SZINAOVR10";

        /// <summary>
        /// SZINAOVR11.
        /// </summary>
        public const string SZINAOVR11 = "SZINAOVR11";

        /// <summary>
        /// SZINAOVR12.
        /// </summary>
        public const string SZINAOVR12 = "SZINAOVR12";
    }

    /// <inheritdoc />
    public override string TableName => "F31B19Z1";

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
        new JdeField("SZWAPRN", "SZWAPRN", JdeDataType.String, 40),
        new JdeField("SZWVID", "SZWVID", JdeDataType.Numeric),
        new JdeField("SZWCFTF", "SZWCFTF", JdeDataType.String, 2),
        new JdeField("SZWV2VLNID", "SZWV2VLNID", JdeDataType.Numeric),
        new JdeField("SZINATTN1", "SZINATTN1", JdeDataType.Numeric),
        new JdeField("SZINATTN2", "SZINATTN2", JdeDataType.Numeric),
        new JdeField("SZINATTN3", "SZINATTN3", JdeDataType.Numeric),
        new JdeField("SZINATTN4", "SZINATTN4", JdeDataType.Numeric),
        new JdeField("SZINATTS5", "SZINATTS5", JdeDataType.String, 40),
        new JdeField("SZINATTS6", "SZINATTS6", JdeDataType.String, 40),
        new JdeField("SZINATTS7", "SZINATTS7", JdeDataType.String, 40),
        new JdeField("SZINATTS8", "SZINATTS8", JdeDataType.String, 40),
        new JdeField("SZINATTD9", "SZINATTD9", JdeDataType.Numeric),
        new JdeField("SZINATTD10", "SZINATTD10", JdeDataType.Numeric),
        new JdeField("SZINATTD11", "SZINATTD11", JdeDataType.Numeric),
        new JdeField("SZINATTD12", "SZINATTD12", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZINATOVR1", "SZINATOVR1", JdeDataType.String, 2),
        new JdeField("SZINATOVR2", "SZINATOVR2", JdeDataType.String, 2),
        new JdeField("SZINATOVR3", "SZINATOVR3", JdeDataType.String, 2),
        new JdeField("SZINATOVR4", "SZINATOVR4", JdeDataType.String, 2),
        new JdeField("SZINATOVR5", "SZINATOVR5", JdeDataType.String, 2),
        new JdeField("SZINATOVR6", "SZINATOVR6", JdeDataType.String, 2),
        new JdeField("SZINATOVR7", "SZINATOVR7", JdeDataType.String, 2),
        new JdeField("SZINATOVR8", "SZINATOVR8", JdeDataType.String, 2),
        new JdeField("SZINATOVR9", "SZINATOVR9", JdeDataType.String, 2),
        new JdeField("SZINAOVR10", "SZINAOVR10", JdeDataType.String, 2),
        new JdeField("SZINAOVR11", "SZINAOVR11", JdeDataType.String, 2),
        new JdeField("SZINAOVR12", "SZINAOVR12", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B19Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B19Z1_2", "Index on SZWAPRN", new[] { "SZWAPRN" })
    };
}
