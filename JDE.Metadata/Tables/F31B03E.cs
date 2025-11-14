using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B03E - .
/// </summary>
public class F31B03E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BEUKID.
        /// </summary>
        public const string BEUKID = "BEUKID";

        /// <summary>
        /// BEMCU.
        /// </summary>
        public const string BEMCU = "BEMCU";

        /// <summary>
        /// BEBRLNUM.
        /// </summary>
        public const string BEBRLNUM = "BEBRLNUM";

        /// <summary>
        /// BEBVST.
        /// </summary>
        public const string BEBVST = "BEBVST";

        /// <summary>
        /// BELOCN.
        /// </summary>
        public const string BELOCN = "BELOCN";

        /// <summary>
        /// BERKNUM.
        /// </summary>
        public const string BERKNUM = "BERKNUM";

        /// <summary>
        /// BEBATP.
        /// </summary>
        public const string BEBATP = "BEBATP";

        /// <summary>
        /// BENUMFL.
        /// </summary>
        public const string BENUMFL = "BENUMFL";

        /// <summary>
        /// BEWOPID.
        /// </summary>
        public const string BEWOPID = "BEWOPID";

        /// <summary>
        /// BETLEV.
        /// </summary>
        public const string BETLEV = "BETLEV";

        /// <summary>
        /// BETSTH.
        /// </summary>
        public const string BETSTH = "BETSTH";

        /// <summary>
        /// BEBCST.
        /// </summary>
        public const string BEBCST = "BEBCST";

        /// <summary>
        /// BEFORES.
        /// </summary>
        public const string BEFORES = "BEFORES";

        /// <summary>
        /// BEPOWN.
        /// </summary>
        public const string BEPOWN = "BEPOWN";

        /// <summary>
        /// BELDREF.
        /// </summary>
        public const string BELDREF = "BELDREF";

        /// <summary>
        /// BEWBPO.
        /// </summary>
        public const string BEWBPO = "BEWBPO";

        /// <summary>
        /// BERKNMR.
        /// </summary>
        public const string BERKNMR = "BERKNMR";

        /// <summary>
        /// BERECY.
        /// </summary>
        public const string BERECY = "BERECY";

        /// <summary>
        /// BEWVID.
        /// </summary>
        public const string BEWVID = "BEWVID";

        /// <summary>
        /// BEWBID.
        /// </summary>
        public const string BEWBID = "BEWBID";

        /// <summary>
        /// BEWISSC.
        /// </summary>
        public const string BEWISSC = "BEWISSC";

        /// <summary>
        /// BEMATYP.
        /// </summary>
        public const string BEMATYP = "BEMATYP";

        /// <summary>
        /// BESATTN1.
        /// </summary>
        public const string BESATTN1 = "BESATTN1";

        /// <summary>
        /// BESATTN2.
        /// </summary>
        public const string BESATTN2 = "BESATTN2";

        /// <summary>
        /// BESATTN3.
        /// </summary>
        public const string BESATTN3 = "BESATTN3";

        /// <summary>
        /// BESATTN4.
        /// </summary>
        public const string BESATTN4 = "BESATTN4";

        /// <summary>
        /// BESATTN5.
        /// </summary>
        public const string BESATTN5 = "BESATTN5";

        /// <summary>
        /// BESATTN6.
        /// </summary>
        public const string BESATTN6 = "BESATTN6";

        /// <summary>
        /// BESATTN7.
        /// </summary>
        public const string BESATTN7 = "BESATTN7";

        /// <summary>
        /// BESATTN8.
        /// </summary>
        public const string BESATTN8 = "BESATTN8";

        /// <summary>
        /// BESATTN9.
        /// </summary>
        public const string BESATTN9 = "BESATTN9";

        /// <summary>
        /// BESATTN10.
        /// </summary>
        public const string BESATTN10 = "BESATTN10";

        /// <summary>
        /// BESATTN11.
        /// </summary>
        public const string BESATTN11 = "BESATTN11";

        /// <summary>
        /// BESATTN12.
        /// </summary>
        public const string BESATTN12 = "BESATTN12";

        /// <summary>
        /// BESATTN13.
        /// </summary>
        public const string BESATTN13 = "BESATTN13";

        /// <summary>
        /// BESATTN14.
        /// </summary>
        public const string BESATTN14 = "BESATTN14";

        /// <summary>
        /// BESATTN15.
        /// </summary>
        public const string BESATTN15 = "BESATTN15";

        /// <summary>
        /// BESATTS16.
        /// </summary>
        public const string BESATTS16 = "BESATTS16";

        /// <summary>
        /// BESATTS17.
        /// </summary>
        public const string BESATTS17 = "BESATTS17";

        /// <summary>
        /// BESATTS18.
        /// </summary>
        public const string BESATTS18 = "BESATTS18";

        /// <summary>
        /// BESATTS19.
        /// </summary>
        public const string BESATTS19 = "BESATTS19";

        /// <summary>
        /// BESATTS20.
        /// </summary>
        public const string BESATTS20 = "BESATTS20";

        /// <summary>
        /// BESATTS21.
        /// </summary>
        public const string BESATTS21 = "BESATTS21";

        /// <summary>
        /// BESATTS22.
        /// </summary>
        public const string BESATTS22 = "BESATTS22";

        /// <summary>
        /// BESATTS23.
        /// </summary>
        public const string BESATTS23 = "BESATTS23";

        /// <summary>
        /// BESATTS24.
        /// </summary>
        public const string BESATTS24 = "BESATTS24";

        /// <summary>
        /// BESATTS25.
        /// </summary>
        public const string BESATTS25 = "BESATTS25";

        /// <summary>
        /// BEINATTN1.
        /// </summary>
        public const string BEINATTN1 = "BEINATTN1";

        /// <summary>
        /// BEINATTN2.
        /// </summary>
        public const string BEINATTN2 = "BEINATTN2";

        /// <summary>
        /// BEINATTN3.
        /// </summary>
        public const string BEINATTN3 = "BEINATTN3";

        /// <summary>
        /// BEINATTN4.
        /// </summary>
        public const string BEINATTN4 = "BEINATTN4";

        /// <summary>
        /// BEINATTS5.
        /// </summary>
        public const string BEINATTS5 = "BEINATTS5";

        /// <summary>
        /// BEINATTS6.
        /// </summary>
        public const string BEINATTS6 = "BEINATTS6";

        /// <summary>
        /// BEINATTS7.
        /// </summary>
        public const string BEINATTS7 = "BEINATTS7";

        /// <summary>
        /// BEINATTS8.
        /// </summary>
        public const string BEINATTS8 = "BEINATTS8";

        /// <summary>
        /// BEINATTD9.
        /// </summary>
        public const string BEINATTD9 = "BEINATTD9";

        /// <summary>
        /// BEINATTD10.
        /// </summary>
        public const string BEINATTD10 = "BEINATTD10";

        /// <summary>
        /// BEINATTD11.
        /// </summary>
        public const string BEINATTD11 = "BEINATTD11";

        /// <summary>
        /// BEINATTD12.
        /// </summary>
        public const string BEINATTD12 = "BEINATTD12";

        /// <summary>
        /// BEWLOTN.
        /// </summary>
        public const string BEWLOTN = "BEWLOTN";

        /// <summary>
        /// BEBARID.
        /// </summary>
        public const string BEBARID = "BEBARID";

        /// <summary>
        /// BEWOPST.
        /// </summary>
        public const string BEWOPST = "BEWOPST";

        /// <summary>
        /// BEWAEDT.
        /// </summary>
        public const string BEWAEDT = "BEWAEDT";

        /// <summary>
        /// BEWASDT.
        /// </summary>
        public const string BEWASDT = "BEWASDT";

        /// <summary>
        /// BEBOWN.
        /// </summary>
        public const string BEBOWN = "BEBOWN";

        /// <summary>
        /// BEWOPN.
        /// </summary>
        public const string BEWOPN = "BEWOPN";

        /// <summary>
        /// BEVBTN.
        /// </summary>
        public const string BEVBTN = "BEVBTN";

        /// <summary>
        /// BEWSDT.
        /// </summary>
        public const string BEWSDT = "BEWSDT";

        /// <summary>
        /// BEWEDT.
        /// </summary>
        public const string BEWEDT = "BEWEDT";

        /// <summary>
        /// BEVBID.
        /// </summary>
        public const string BEVBID = "BEVBID";

        /// <summary>
        /// BECOOP.
        /// </summary>
        public const string BECOOP = "BECOOP";

        /// <summary>
        /// BEWCTRO.
        /// </summary>
        public const string BEWCTRO = "BEWCTRO";

        /// <summary>
        /// BECAPTYP.
        /// </summary>
        public const string BECAPTYP = "BECAPTYP";

        /// <summary>
        /// BETOCAP.
        /// </summary>
        public const string BETOCAP = "BETOCAP";

        /// <summary>
        /// BEFCAP.
        /// </summary>
        public const string BEFCAP = "BEFCAP";

        /// <summary>
        /// BEBAVC.
        /// </summary>
        public const string BEBAVC = "BEBAVC";

        /// <summary>
        /// BEWV2VLNID.
        /// </summary>
        public const string BEWV2VLNID = "BEWV2VLNID";

        /// <summary>
        /// BEBIDSEQ.
        /// </summary>
        public const string BEBIDSEQ = "BEBIDSEQ";

        /// <summary>
        /// BEDL01.
        /// </summary>
        public const string BEDL01 = "BEDL01";

        /// <summary>
        /// BEDSCSMT.
        /// </summary>
        public const string BEDSCSMT = "BEDSCSMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B03E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BEUKID", "BEUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BEMCU", "BEMCU", JdeDataType.String, 24, true, true),
        new JdeField("BEBRLNUM", "BEBRLNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("BEBVST", "BEBVST", JdeDataType.String, 6),
        new JdeField("BELOCN", "BELOCN", JdeDataType.String, 40),
        new JdeField("BERKNUM", "BERKNUM", JdeDataType.Numeric),
        new JdeField("BEBATP", "BEBATP", JdeDataType.String, 8),
        new JdeField("BENUMFL", "BENUMFL", JdeDataType.Numeric),
        new JdeField("BEWOPID", "BEWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("BETLEV", "BETLEV", JdeDataType.String, 6),
        new JdeField("BETSTH", "BETSTH", JdeDataType.String, 2),
        new JdeField("BEBCST", "BEBCST", JdeDataType.String, 20),
        new JdeField("BEFORES", "BEFORES", JdeDataType.String, 16),
        new JdeField("BEPOWN", "BEPOWN", JdeDataType.Numeric),
        new JdeField("BELDREF", "BELDREF", JdeDataType.String, 80),
        new JdeField("BEWBPO", "BEWBPO", JdeDataType.Numeric),
        new JdeField("BERKNMR", "BERKNMR", JdeDataType.String, 40),
        new JdeField("BERECY", "BERECY", JdeDataType.Numeric),
        new JdeField("BEWVID", "BEWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("BEWBID", "BEWBID", JdeDataType.String, 60),
        new JdeField("BEWISSC", "BEWISSC", JdeDataType.String, 12),
        new JdeField("BEMATYP", "BEMATYP", JdeDataType.String, 8),
        new JdeField("BESATTN1", "BESATTN1", JdeDataType.Numeric),
        new JdeField("BESATTN2", "BESATTN2", JdeDataType.Numeric),
        new JdeField("BESATTN3", "BESATTN3", JdeDataType.Numeric),
        new JdeField("BESATTN4", "BESATTN4", JdeDataType.Numeric),
        new JdeField("BESATTN5", "BESATTN5", JdeDataType.Numeric),
        new JdeField("BESATTN6", "BESATTN6", JdeDataType.Numeric),
        new JdeField("BESATTN7", "BESATTN7", JdeDataType.Numeric),
        new JdeField("BESATTN8", "BESATTN8", JdeDataType.Numeric),
        new JdeField("BESATTN9", "BESATTN9", JdeDataType.Numeric),
        new JdeField("BESATTN10", "BESATTN10", JdeDataType.Numeric),
        new JdeField("BESATTN11", "BESATTN11", JdeDataType.Numeric),
        new JdeField("BESATTN12", "BESATTN12", JdeDataType.Numeric),
        new JdeField("BESATTN13", "BESATTN13", JdeDataType.Numeric),
        new JdeField("BESATTN14", "BESATTN14", JdeDataType.Numeric),
        new JdeField("BESATTN15", "BESATTN15", JdeDataType.Numeric),
        new JdeField("BESATTS16", "BESATTS16", JdeDataType.String, 40),
        new JdeField("BESATTS17", "BESATTS17", JdeDataType.String, 40),
        new JdeField("BESATTS18", "BESATTS18", JdeDataType.String, 40),
        new JdeField("BESATTS19", "BESATTS19", JdeDataType.String, 40),
        new JdeField("BESATTS20", "BESATTS20", JdeDataType.String, 40),
        new JdeField("BESATTS21", "BESATTS21", JdeDataType.String, 40),
        new JdeField("BESATTS22", "BESATTS22", JdeDataType.String, 40),
        new JdeField("BESATTS23", "BESATTS23", JdeDataType.String, 40),
        new JdeField("BESATTS24", "BESATTS24", JdeDataType.String, 40),
        new JdeField("BESATTS25", "BESATTS25", JdeDataType.String, 40),
        new JdeField("BEINATTN1", "BEINATTN1", JdeDataType.Numeric),
        new JdeField("BEINATTN2", "BEINATTN2", JdeDataType.Numeric),
        new JdeField("BEINATTN3", "BEINATTN3", JdeDataType.Numeric),
        new JdeField("BEINATTN4", "BEINATTN4", JdeDataType.Numeric),
        new JdeField("BEINATTS5", "BEINATTS5", JdeDataType.String, 40),
        new JdeField("BEINATTS6", "BEINATTS6", JdeDataType.String, 40),
        new JdeField("BEINATTS7", "BEINATTS7", JdeDataType.String, 40),
        new JdeField("BEINATTS8", "BEINATTS8", JdeDataType.String, 40),
        new JdeField("BEINATTD9", "BEINATTD9", JdeDataType.Numeric),
        new JdeField("BEINATTD10", "BEINATTD10", JdeDataType.Numeric),
        new JdeField("BEINATTD11", "BEINATTD11", JdeDataType.Numeric),
        new JdeField("BEINATTD12", "BEINATTD12", JdeDataType.Numeric),
        new JdeField("BEWLOTN", "BEWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("BEBARID", "BEBARID", JdeDataType.String, 60, true, true),
        new JdeField("BEWOPST", "BEWOPST", JdeDataType.String, 20),
        new JdeField("BEWAEDT", "BEWAEDT", JdeDataType.Date),
        new JdeField("BEWASDT", "BEWASDT", JdeDataType.Date),
        new JdeField("BEBOWN", "BEBOWN", JdeDataType.Numeric),
        new JdeField("BEWOPN", "BEWOPN", JdeDataType.Numeric),
        new JdeField("BEVBTN", "BEVBTN", JdeDataType.String, 60),
        new JdeField("BEWSDT", "BEWSDT", JdeDataType.Date),
        new JdeField("BEWEDT", "BEWEDT", JdeDataType.Date),
        new JdeField("BEVBID", "BEVBID", JdeDataType.Numeric),
        new JdeField("BECOOP", "BECOOP", JdeDataType.String, 6),
        new JdeField("BEWCTRO", "BEWCTRO", JdeDataType.String, 6),
        new JdeField("BECAPTYP", "BECAPTYP", JdeDataType.String, 2),
        new JdeField("BETOCAP", "BETOCAP", JdeDataType.Numeric),
        new JdeField("BEFCAP", "BEFCAP", JdeDataType.Numeric),
        new JdeField("BEBAVC", "BEBAVC", JdeDataType.String, 8),
        new JdeField("BEWV2VLNID", "BEWV2VLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BEBIDSEQ", "BEBIDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BEDL01", "BEDL01", JdeDataType.String, 60),
        new JdeField("BEDSCSMT", "BEDSCSMT", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B03E_0", "Primary Key on BEUKID, BEBRLNUM, BEWLOTN, BEBARID, BEMCU, BEWOPID, BEWVID, BEWV2VLNID, BEBIDSEQ", new[] { "BEUKID", "BEBRLNUM", "BEWLOTN", "BEBARID", "BEMCU", "BEWOPID", "BEWVID", "BEWV2VLNID", "BEBIDSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B03E_2", "Index on BEBRLNUM, SYS_NC00081$", new[] { "BEBRLNUM", "SYS_NC00081$" }),
        new JdeIndex("F31B03E_3", "Index on BEBARID", new[] { "BEBARID" })
    };
}
