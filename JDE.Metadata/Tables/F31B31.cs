using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B31 - .
/// </summary>
public class F31B31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLWLOTN.
        /// </summary>
        public const string WLWLOTN = "WLWLOTN";

        /// <summary>
        /// WLWBID.
        /// </summary>
        public const string WLWBID = "WLWBID";

        /// <summary>
        /// WLWBIDAPP.
        /// </summary>
        public const string WLWBIDAPP = "WLWBIDAPP";

        /// <summary>
        /// WLAWBID.
        /// </summary>
        public const string WLAWBID = "WLAWBID";

        /// <summary>
        /// WLLTQNTY.
        /// </summary>
        public const string WLLTQNTY = "WLLTQNTY";

        /// <summary>
        /// WLLTUOM.
        /// </summary>
        public const string WLLTUOM = "WLLTUOM";

        /// <summary>
        /// WLLTSTAT.
        /// </summary>
        public const string WLLTSTAT = "WLLTSTAT";

        /// <summary>
        /// WLMATYP.
        /// </summary>
        public const string WLMATYP = "WLMATYP";

        /// <summary>
        /// WLWISSC.
        /// </summary>
        public const string WLWISSC = "WLWISSC";

        /// <summary>
        /// WLSRVGAV.
        /// </summary>
        public const string WLSRVGAV = "WLSRVGAV";

        /// <summary>
        /// WLSRVGAP.
        /// </summary>
        public const string WLSRVGAP = "WLSRVGAP";

        /// <summary>
        /// WLOPRGAV.
        /// </summary>
        public const string WLOPRGAV = "WLOPRGAV";

        /// <summary>
        /// WLOPRGAP.
        /// </summary>
        public const string WLOPRGAP = "WLOPRGAP";

        /// <summary>
        /// WLLOTYLD.
        /// </summary>
        public const string WLLOTYLD = "WLLOTYLD";

        /// <summary>
        /// WLCUMYLD.
        /// </summary>
        public const string WLCUMYLD = "WLCUMYLD";

        /// <summary>
        /// WLSATTN1.
        /// </summary>
        public const string WLSATTN1 = "WLSATTN1";

        /// <summary>
        /// WLSATTN2.
        /// </summary>
        public const string WLSATTN2 = "WLSATTN2";

        /// <summary>
        /// WLSATTN3.
        /// </summary>
        public const string WLSATTN3 = "WLSATTN3";

        /// <summary>
        /// WLSATTN4.
        /// </summary>
        public const string WLSATTN4 = "WLSATTN4";

        /// <summary>
        /// WLSATTN5.
        /// </summary>
        public const string WLSATTN5 = "WLSATTN5";

        /// <summary>
        /// WLSATTN6.
        /// </summary>
        public const string WLSATTN6 = "WLSATTN6";

        /// <summary>
        /// WLSATTN7.
        /// </summary>
        public const string WLSATTN7 = "WLSATTN7";

        /// <summary>
        /// WLSATTN8.
        /// </summary>
        public const string WLSATTN8 = "WLSATTN8";

        /// <summary>
        /// WLSATTN9.
        /// </summary>
        public const string WLSATTN9 = "WLSATTN9";

        /// <summary>
        /// WLSATTN10.
        /// </summary>
        public const string WLSATTN10 = "WLSATTN10";

        /// <summary>
        /// WLSATTN11.
        /// </summary>
        public const string WLSATTN11 = "WLSATTN11";

        /// <summary>
        /// WLSATTN12.
        /// </summary>
        public const string WLSATTN12 = "WLSATTN12";

        /// <summary>
        /// WLSATTN13.
        /// </summary>
        public const string WLSATTN13 = "WLSATTN13";

        /// <summary>
        /// WLSATTN14.
        /// </summary>
        public const string WLSATTN14 = "WLSATTN14";

        /// <summary>
        /// WLSATTN15.
        /// </summary>
        public const string WLSATTN15 = "WLSATTN15";

        /// <summary>
        /// WLSATTS16.
        /// </summary>
        public const string WLSATTS16 = "WLSATTS16";

        /// <summary>
        /// WLSATTS17.
        /// </summary>
        public const string WLSATTS17 = "WLSATTS17";

        /// <summary>
        /// WLSATTS18.
        /// </summary>
        public const string WLSATTS18 = "WLSATTS18";

        /// <summary>
        /// WLSATTS19.
        /// </summary>
        public const string WLSATTS19 = "WLSATTS19";

        /// <summary>
        /// WLSATTS20.
        /// </summary>
        public const string WLSATTS20 = "WLSATTS20";

        /// <summary>
        /// WLSATTS21.
        /// </summary>
        public const string WLSATTS21 = "WLSATTS21";

        /// <summary>
        /// WLSATTS22.
        /// </summary>
        public const string WLSATTS22 = "WLSATTS22";

        /// <summary>
        /// WLSATTS23.
        /// </summary>
        public const string WLSATTS23 = "WLSATTS23";

        /// <summary>
        /// WLSATTS24.
        /// </summary>
        public const string WLSATTS24 = "WLSATTS24";

        /// <summary>
        /// WLSATTS25.
        /// </summary>
        public const string WLSATTS25 = "WLSATTS25";

        /// <summary>
        /// WLINATTN1.
        /// </summary>
        public const string WLINATTN1 = "WLINATTN1";

        /// <summary>
        /// WLINATTN2.
        /// </summary>
        public const string WLINATTN2 = "WLINATTN2";

        /// <summary>
        /// WLINATTN3.
        /// </summary>
        public const string WLINATTN3 = "WLINATTN3";

        /// <summary>
        /// WLINATTN4.
        /// </summary>
        public const string WLINATTN4 = "WLINATTN4";

        /// <summary>
        /// WLINATTS5.
        /// </summary>
        public const string WLINATTS5 = "WLINATTS5";

        /// <summary>
        /// WLINATTS6.
        /// </summary>
        public const string WLINATTS6 = "WLINATTS6";

        /// <summary>
        /// WLINATTS7.
        /// </summary>
        public const string WLINATTS7 = "WLINATTS7";

        /// <summary>
        /// WLINATTS8.
        /// </summary>
        public const string WLINATTS8 = "WLINATTS8";

        /// <summary>
        /// WLINATTD9.
        /// </summary>
        public const string WLINATTD9 = "WLINATTD9";

        /// <summary>
        /// WLINATTD10.
        /// </summary>
        public const string WLINATTD10 = "WLINATTD10";

        /// <summary>
        /// WLINATTD11.
        /// </summary>
        public const string WLINATTD11 = "WLINATTD11";

        /// <summary>
        /// WLINATTD12.
        /// </summary>
        public const string WLINATTD12 = "WLINATTD12";

        /// <summary>
        /// WLDECLOV.
        /// </summary>
        public const string WLDECLOV = "WLDECLOV";

        /// <summary>
        /// WLSAMLOV.
        /// </summary>
        public const string WLSAMLOV = "WLSAMLOV";

        /// <summary>
        /// WLMATOVR.
        /// </summary>
        public const string WLMATOVR = "WLMATOVR";

        /// <summary>
        /// WLWSOVR.
        /// </summary>
        public const string WLWSOVR = "WLWSOVR";

        /// <summary>
        /// WLINATOVR1.
        /// </summary>
        public const string WLINATOVR1 = "WLINATOVR1";

        /// <summary>
        /// WLINATOVR2.
        /// </summary>
        public const string WLINATOVR2 = "WLINATOVR2";

        /// <summary>
        /// WLINATOVR3.
        /// </summary>
        public const string WLINATOVR3 = "WLINATOVR3";

        /// <summary>
        /// WLINATOVR4.
        /// </summary>
        public const string WLINATOVR4 = "WLINATOVR4";

        /// <summary>
        /// WLINATOVR5.
        /// </summary>
        public const string WLINATOVR5 = "WLINATOVR5";

        /// <summary>
        /// WLINATOVR6.
        /// </summary>
        public const string WLINATOVR6 = "WLINATOVR6";

        /// <summary>
        /// WLINATOVR7.
        /// </summary>
        public const string WLINATOVR7 = "WLINATOVR7";

        /// <summary>
        /// WLINATOVR8.
        /// </summary>
        public const string WLINATOVR8 = "WLINATOVR8";

        /// <summary>
        /// WLINATOVR9.
        /// </summary>
        public const string WLINATOVR9 = "WLINATOVR9";

        /// <summary>
        /// WLINAOVR10.
        /// </summary>
        public const string WLINAOVR10 = "WLINAOVR10";

        /// <summary>
        /// WLINAOVR11.
        /// </summary>
        public const string WLINAOVR11 = "WLINAOVR11";

        /// <summary>
        /// WLINAOVR12.
        /// </summary>
        public const string WLINAOVR12 = "WLINAOVR12";

        /// <summary>
        /// WLEUROVR.
        /// </summary>
        public const string WLEUROVR = "WLEUROVR";

        /// <summary>
        /// WLOWNOVR.
        /// </summary>
        public const string WLOWNOVR = "WLOWNOVR";

        /// <summary>
        /// WLLTCMTOVR.
        /// </summary>
        public const string WLLTCMTOVR = "WLLTCMTOVR";

        /// <summary>
        /// WLVLI.
        /// </summary>
        public const string WLVLI = "WLVLI";

        /// <summary>
        /// WLWRF.
        /// </summary>
        public const string WLWRF = "WLWRF";

        /// <summary>
        /// WLWCD.
        /// </summary>
        public const string WLWCD = "WLWCD";

        /// <summary>
        /// WLWAB.
        /// </summary>
        public const string WLWAB = "WLWAB";

        /// <summary>
        /// WLWNUM.
        /// </summary>
        public const string WLWNUM = "WLWNUM";

        /// <summary>
        /// WLWMDT.
        /// </summary>
        public const string WLWMDT = "WLWMDT";

        /// <summary>
        /// WLURCD.
        /// </summary>
        public const string WLURCD = "WLURCD";

        /// <summary>
        /// WLURDT.
        /// </summary>
        public const string WLURDT = "WLURDT";

        /// <summary>
        /// WLURAT.
        /// </summary>
        public const string WLURAT = "WLURAT";

        /// <summary>
        /// WLURRF.
        /// </summary>
        public const string WLURRF = "WLURRF";

        /// <summary>
        /// WLURAB.
        /// </summary>
        public const string WLURAB = "WLURAB";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLUPMT.
        /// </summary>
        public const string WLUPMT = "WLUPMT";

        /// <summary>
        /// WLBIDOVR.
        /// </summary>
        public const string WLBIDOVR = "WLBIDOVR";

        /// <summary>
        /// WLWERCS.
        /// </summary>
        public const string WLWERCS = "WLWERCS";

        /// <summary>
        /// WLWOVC.
        /// </summary>
        public const string WLWOVC = "WLWOVC";
    }

    /// <inheritdoc />
    public override string TableName => "F31B31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLWLOTN", "WLWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WLWBID", "WLWBID", JdeDataType.String, 60),
        new JdeField("WLWBIDAPP", "WLWBIDAPP", JdeDataType.String, 2),
        new JdeField("WLAWBID", "WLAWBID", JdeDataType.String, 60),
        new JdeField("WLLTQNTY", "WLLTQNTY", JdeDataType.Numeric),
        new JdeField("WLLTUOM", "WLLTUOM", JdeDataType.String, 6),
        new JdeField("WLLTSTAT", "WLLTSTAT", JdeDataType.String, 20),
        new JdeField("WLMATYP", "WLMATYP", JdeDataType.String, 8),
        new JdeField("WLWISSC", "WLWISSC", JdeDataType.String, 12),
        new JdeField("WLSRVGAV", "WLSRVGAV", JdeDataType.Numeric),
        new JdeField("WLSRVGAP", "WLSRVGAP", JdeDataType.Numeric),
        new JdeField("WLOPRGAV", "WLOPRGAV", JdeDataType.Numeric),
        new JdeField("WLOPRGAP", "WLOPRGAP", JdeDataType.Numeric),
        new JdeField("WLLOTYLD", "WLLOTYLD", JdeDataType.Numeric),
        new JdeField("WLCUMYLD", "WLCUMYLD", JdeDataType.Numeric),
        new JdeField("WLSATTN1", "WLSATTN1", JdeDataType.Numeric),
        new JdeField("WLSATTN2", "WLSATTN2", JdeDataType.Numeric),
        new JdeField("WLSATTN3", "WLSATTN3", JdeDataType.Numeric),
        new JdeField("WLSATTN4", "WLSATTN4", JdeDataType.Numeric),
        new JdeField("WLSATTN5", "WLSATTN5", JdeDataType.Numeric),
        new JdeField("WLSATTN6", "WLSATTN6", JdeDataType.Numeric),
        new JdeField("WLSATTN7", "WLSATTN7", JdeDataType.Numeric),
        new JdeField("WLSATTN8", "WLSATTN8", JdeDataType.Numeric),
        new JdeField("WLSATTN9", "WLSATTN9", JdeDataType.Numeric),
        new JdeField("WLSATTN10", "WLSATTN10", JdeDataType.Numeric),
        new JdeField("WLSATTN11", "WLSATTN11", JdeDataType.Numeric),
        new JdeField("WLSATTN12", "WLSATTN12", JdeDataType.Numeric),
        new JdeField("WLSATTN13", "WLSATTN13", JdeDataType.Numeric),
        new JdeField("WLSATTN14", "WLSATTN14", JdeDataType.Numeric),
        new JdeField("WLSATTN15", "WLSATTN15", JdeDataType.Numeric),
        new JdeField("WLSATTS16", "WLSATTS16", JdeDataType.String, 40),
        new JdeField("WLSATTS17", "WLSATTS17", JdeDataType.String, 40),
        new JdeField("WLSATTS18", "WLSATTS18", JdeDataType.String, 40),
        new JdeField("WLSATTS19", "WLSATTS19", JdeDataType.String, 40),
        new JdeField("WLSATTS20", "WLSATTS20", JdeDataType.String, 40),
        new JdeField("WLSATTS21", "WLSATTS21", JdeDataType.String, 40),
        new JdeField("WLSATTS22", "WLSATTS22", JdeDataType.String, 40),
        new JdeField("WLSATTS23", "WLSATTS23", JdeDataType.String, 40),
        new JdeField("WLSATTS24", "WLSATTS24", JdeDataType.String, 40),
        new JdeField("WLSATTS25", "WLSATTS25", JdeDataType.String, 40),
        new JdeField("WLINATTN1", "WLINATTN1", JdeDataType.Numeric),
        new JdeField("WLINATTN2", "WLINATTN2", JdeDataType.Numeric),
        new JdeField("WLINATTN3", "WLINATTN3", JdeDataType.Numeric),
        new JdeField("WLINATTN4", "WLINATTN4", JdeDataType.Numeric),
        new JdeField("WLINATTS5", "WLINATTS5", JdeDataType.String, 40),
        new JdeField("WLINATTS6", "WLINATTS6", JdeDataType.String, 40),
        new JdeField("WLINATTS7", "WLINATTS7", JdeDataType.String, 40),
        new JdeField("WLINATTS8", "WLINATTS8", JdeDataType.String, 40),
        new JdeField("WLINATTD9", "WLINATTD9", JdeDataType.Numeric),
        new JdeField("WLINATTD10", "WLINATTD10", JdeDataType.Numeric),
        new JdeField("WLINATTD11", "WLINATTD11", JdeDataType.Numeric),
        new JdeField("WLINATTD12", "WLINATTD12", JdeDataType.Numeric),
        new JdeField("WLDECLOV", "WLDECLOV", JdeDataType.Numeric),
        new JdeField("WLSAMLOV", "WLSAMLOV", JdeDataType.Numeric),
        new JdeField("WLMATOVR", "WLMATOVR", JdeDataType.String, 2),
        new JdeField("WLWSOVR", "WLWSOVR", JdeDataType.String, 2),
        new JdeField("WLINATOVR1", "WLINATOVR1", JdeDataType.String, 2),
        new JdeField("WLINATOVR2", "WLINATOVR2", JdeDataType.String, 2),
        new JdeField("WLINATOVR3", "WLINATOVR3", JdeDataType.String, 2),
        new JdeField("WLINATOVR4", "WLINATOVR4", JdeDataType.String, 2),
        new JdeField("WLINATOVR5", "WLINATOVR5", JdeDataType.String, 2),
        new JdeField("WLINATOVR6", "WLINATOVR6", JdeDataType.String, 2),
        new JdeField("WLINATOVR7", "WLINATOVR7", JdeDataType.String, 2),
        new JdeField("WLINATOVR8", "WLINATOVR8", JdeDataType.String, 2),
        new JdeField("WLINATOVR9", "WLINATOVR9", JdeDataType.String, 2),
        new JdeField("WLINAOVR10", "WLINAOVR10", JdeDataType.String, 2),
        new JdeField("WLINAOVR11", "WLINAOVR11", JdeDataType.String, 2),
        new JdeField("WLINAOVR12", "WLINAOVR12", JdeDataType.String, 2),
        new JdeField("WLEUROVR", "WLEUROVR", JdeDataType.String, 2),
        new JdeField("WLOWNOVR", "WLOWNOVR", JdeDataType.String, 2),
        new JdeField("WLLTCMTOVR", "WLLTCMTOVR", JdeDataType.String, 2),
        new JdeField("WLVLI", "WLVLI", JdeDataType.String, 2),
        new JdeField("WLWRF", "WLWRF", JdeDataType.String, 60),
        new JdeField("WLWCD", "WLWCD", JdeDataType.String, 6),
        new JdeField("WLWAB", "WLWAB", JdeDataType.Numeric),
        new JdeField("WLWNUM", "WLWNUM", JdeDataType.Numeric),
        new JdeField("WLWMDT", "WLWMDT", JdeDataType.Numeric),
        new JdeField("WLURCD", "WLURCD", JdeDataType.String, 4),
        new JdeField("WLURDT", "WLURDT", JdeDataType.Numeric),
        new JdeField("WLURAT", "WLURAT", JdeDataType.Numeric),
        new JdeField("WLURRF", "WLURRF", JdeDataType.String, 30),
        new JdeField("WLURAB", "WLURAB", JdeDataType.Numeric),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLUPMT", "WLUPMT", JdeDataType.Numeric),
        new JdeField("WLBIDOVR", "WLBIDOVR", JdeDataType.String, 2),
        new JdeField("WLWERCS", "WLWERCS", JdeDataType.String, 2),
        new JdeField("WLWOVC", "WLWOVC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B31_0", "Primary Key on WLMCU, WLWLOTN", new[] { "WLMCU", "WLWLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B31_2", "Index on WLWISSC", new[] { "WLWISSC" }),
        new JdeIndex("F31B31_3", "Index on WLMATYP", new[] { "WLMATYP" }),
        new JdeIndex("F31B31_4", "Index on WLWLOTN", new[] { "WLWLOTN" }),
        new JdeIndex("F31B31_5", "Index on WLVLI, WLMCU", new[] { "WLVLI", "WLMCU" })
    };
}
