using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B115W - .
/// </summary>
public class F31B115W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LWWTBID.
        /// </summary>
        public const string LWWTBID = "LWWTBID";

        /// <summary>
        /// LWMCU.
        /// </summary>
        public const string LWMCU = "LWMCU";

        /// <summary>
        /// LWWTBINOT.
        /// </summary>
        public const string LWWTBINOT = "LWWTBINOT";

        /// <summary>
        /// LWWLOTN.
        /// </summary>
        public const string LWWLOTN = "LWWLOTN";

        /// <summary>
        /// LWWTBLOSE.
        /// </summary>
        public const string LWWTBLOSE = "LWWTBLOSE";

        /// <summary>
        /// LWWVID.
        /// </summary>
        public const string LWWVID = "LWWVID";

        /// <summary>
        /// LWWVNUM.
        /// </summary>
        public const string LWWVNUM = "LWWVNUM";

        /// <summary>
        /// LWWBID.
        /// </summary>
        public const string LWWBID = "LWWBID";

        /// <summary>
        /// LWEURID.
        /// </summary>
        public const string LWEURID = "LWEURID";

        /// <summary>
        /// LWEURSCD.
        /// </summary>
        public const string LWEURSCD = "LWEURSCD";

        /// <summary>
        /// LWWISSC.
        /// </summary>
        public const string LWWISSC = "LWWISSC";

        /// <summary>
        /// LWAWBID.
        /// </summary>
        public const string LWAWBID = "LWAWBID";

        /// <summary>
        /// LWMATYP.
        /// </summary>
        public const string LWMATYP = "LWMATYP";

        /// <summary>
        /// LWWOPID.
        /// </summary>
        public const string LWWOPID = "LWWOPID";

        /// <summary>
        /// LWSATTN1.
        /// </summary>
        public const string LWSATTN1 = "LWSATTN1";

        /// <summary>
        /// LWSATTN2.
        /// </summary>
        public const string LWSATTN2 = "LWSATTN2";

        /// <summary>
        /// LWSATTN3.
        /// </summary>
        public const string LWSATTN3 = "LWSATTN3";

        /// <summary>
        /// LWSATTN4.
        /// </summary>
        public const string LWSATTN4 = "LWSATTN4";

        /// <summary>
        /// LWSATTN5.
        /// </summary>
        public const string LWSATTN5 = "LWSATTN5";

        /// <summary>
        /// LWSATTN6.
        /// </summary>
        public const string LWSATTN6 = "LWSATTN6";

        /// <summary>
        /// LWSATTN7.
        /// </summary>
        public const string LWSATTN7 = "LWSATTN7";

        /// <summary>
        /// LWSATTN8.
        /// </summary>
        public const string LWSATTN8 = "LWSATTN8";

        /// <summary>
        /// LWSATTN9.
        /// </summary>
        public const string LWSATTN9 = "LWSATTN9";

        /// <summary>
        /// LWSATTN10.
        /// </summary>
        public const string LWSATTN10 = "LWSATTN10";

        /// <summary>
        /// LWSATTN11.
        /// </summary>
        public const string LWSATTN11 = "LWSATTN11";

        /// <summary>
        /// LWSATTN12.
        /// </summary>
        public const string LWSATTN12 = "LWSATTN12";

        /// <summary>
        /// LWSATTN13.
        /// </summary>
        public const string LWSATTN13 = "LWSATTN13";

        /// <summary>
        /// LWSATTN14.
        /// </summary>
        public const string LWSATTN14 = "LWSATTN14";

        /// <summary>
        /// LWSATTN15.
        /// </summary>
        public const string LWSATTN15 = "LWSATTN15";

        /// <summary>
        /// LWSATTS16.
        /// </summary>
        public const string LWSATTS16 = "LWSATTS16";

        /// <summary>
        /// LWSATTS17.
        /// </summary>
        public const string LWSATTS17 = "LWSATTS17";

        /// <summary>
        /// LWSATTS18.
        /// </summary>
        public const string LWSATTS18 = "LWSATTS18";

        /// <summary>
        /// LWSATTS19.
        /// </summary>
        public const string LWSATTS19 = "LWSATTS19";

        /// <summary>
        /// LWSATTS20.
        /// </summary>
        public const string LWSATTS20 = "LWSATTS20";

        /// <summary>
        /// LWSATTS21.
        /// </summary>
        public const string LWSATTS21 = "LWSATTS21";

        /// <summary>
        /// LWSATTS22.
        /// </summary>
        public const string LWSATTS22 = "LWSATTS22";

        /// <summary>
        /// LWSATTS23.
        /// </summary>
        public const string LWSATTS23 = "LWSATTS23";

        /// <summary>
        /// LWSATTS24.
        /// </summary>
        public const string LWSATTS24 = "LWSATTS24";

        /// <summary>
        /// LWSATTS25.
        /// </summary>
        public const string LWSATTS25 = "LWSATTS25";

        /// <summary>
        /// LWLTQNTY.
        /// </summary>
        public const string LWLTQNTY = "LWLTQNTY";

        /// <summary>
        /// LWLTUOM.
        /// </summary>
        public const string LWLTUOM = "LWLTUOM";

        /// <summary>
        /// LWWTBQCN.
        /// </summary>
        public const string LWWTBQCN = "LWWTBQCN";

        /// <summary>
        /// LWWTBPCN.
        /// </summary>
        public const string LWWTBPCN = "LWWTBPCN";

        /// <summary>
        /// LWWTBCPER.
        /// </summary>
        public const string LWWTBCPER = "LWWTBCPER";

        /// <summary>
        /// LWWPERLQTY.
        /// </summary>
        public const string LWWPERLQTY = "LWWPERLQTY";

        /// <summary>
        /// LWWPERTBE.
        /// </summary>
        public const string LWWPERTBE = "LWWPERTBE";

        /// <summary>
        /// LWWPERTBQ.
        /// </summary>
        public const string LWWPERTBQ = "LWWPERTBQ";

        /// <summary>
        /// LWWTBSTAT.
        /// </summary>
        public const string LWWTBSTAT = "LWWTBSTAT";

        /// <summary>
        /// LWWNCCOLN1.
        /// </summary>
        public const string LWWNCCOLN1 = "LWWNCCOLN1";

        /// <summary>
        /// LWWNCCOLN2.
        /// </summary>
        public const string LWWNCCOLN2 = "LWWNCCOLN2";

        /// <summary>
        /// LWWNCCOLN3.
        /// </summary>
        public const string LWWNCCOLN3 = "LWWNCCOLN3";

        /// <summary>
        /// LWWNCCOLN4.
        /// </summary>
        public const string LWWNCCOLN4 = "LWWNCCOLN4";

        /// <summary>
        /// LWWNCCOLN5.
        /// </summary>
        public const string LWWNCCOLN5 = "LWWNCCOLN5";

        /// <summary>
        /// LWWNCCOLN6.
        /// </summary>
        public const string LWWNCCOLN6 = "LWWNCCOLN6";

        /// <summary>
        /// LWWNCCOLS1.
        /// </summary>
        public const string LWWNCCOLS1 = "LWWNCCOLS1";

        /// <summary>
        /// LWWNCCOLS2.
        /// </summary>
        public const string LWWNCCOLS2 = "LWWNCCOLS2";

        /// <summary>
        /// LWWNCCOLS3.
        /// </summary>
        public const string LWWNCCOLS3 = "LWWNCCOLS3";

        /// <summary>
        /// LWWNCCOLS4.
        /// </summary>
        public const string LWWNCCOLS4 = "LWWNCCOLS4";

        /// <summary>
        /// LWWNCCOLS5.
        /// </summary>
        public const string LWWNCCOLS5 = "LWWNCCOLS5";

        /// <summary>
        /// LWWNCCOLS6.
        /// </summary>
        public const string LWWNCCOLS6 = "LWWNCCOLS6";

        /// <summary>
        /// LWWNCCOLD1.
        /// </summary>
        public const string LWWNCCOLD1 = "LWWNCCOLD1";

        /// <summary>
        /// LWWNCCOLD2.
        /// </summary>
        public const string LWWNCCOLD2 = "LWWNCCOLD2";

        /// <summary>
        /// LWWNCCOLD3.
        /// </summary>
        public const string LWWNCCOLD3 = "LWWNCCOLD3";

        /// <summary>
        /// LWWNCCOLD4.
        /// </summary>
        public const string LWWNCCOLD4 = "LWWNCCOLD4";

        /// <summary>
        /// LWWNCCOLD5.
        /// </summary>
        public const string LWWNCCOLD5 = "LWWNCCOLD5";

        /// <summary>
        /// LWWNCCOLD6.
        /// </summary>
        public const string LWWNCCOLD6 = "LWWNCCOLD6";

        /// <summary>
        /// LWURAB.
        /// </summary>
        public const string LWURAB = "LWURAB";

        /// <summary>
        /// LWURAT.
        /// </summary>
        public const string LWURAT = "LWURAT";

        /// <summary>
        /// LWURCD.
        /// </summary>
        public const string LWURCD = "LWURCD";

        /// <summary>
        /// LWURDT.
        /// </summary>
        public const string LWURDT = "LWURDT";

        /// <summary>
        /// LWURRF.
        /// </summary>
        public const string LWURRF = "LWURRF";

        /// <summary>
        /// LWWAB.
        /// </summary>
        public const string LWWAB = "LWWAB";

        /// <summary>
        /// LWWNUM.
        /// </summary>
        public const string LWWNUM = "LWWNUM";

        /// <summary>
        /// LWWCD.
        /// </summary>
        public const string LWWCD = "LWWCD";

        /// <summary>
        /// LWWMDT.
        /// </summary>
        public const string LWWMDT = "LWWMDT";

        /// <summary>
        /// LWWRF.
        /// </summary>
        public const string LWWRF = "LWWRF";

        /// <summary>
        /// LWUSER.
        /// </summary>
        public const string LWUSER = "LWUSER";

        /// <summary>
        /// LWUPMJ.
        /// </summary>
        public const string LWUPMJ = "LWUPMJ";

        /// <summary>
        /// LWUPMT.
        /// </summary>
        public const string LWUPMT = "LWUPMT";

        /// <summary>
        /// LWJOBN.
        /// </summary>
        public const string LWJOBN = "LWJOBN";

        /// <summary>
        /// LWMKEY.
        /// </summary>
        public const string LWMKEY = "LWMKEY";

        /// <summary>
        /// LWPID.
        /// </summary>
        public const string LWPID = "LWPID";

        /// <summary>
        /// LWINATTN1.
        /// </summary>
        public const string LWINATTN1 = "LWINATTN1";

        /// <summary>
        /// LWINATTN2.
        /// </summary>
        public const string LWINATTN2 = "LWINATTN2";

        /// <summary>
        /// LWINATTN3.
        /// </summary>
        public const string LWINATTN3 = "LWINATTN3";

        /// <summary>
        /// LWINATTN4.
        /// </summary>
        public const string LWINATTN4 = "LWINATTN4";

        /// <summary>
        /// LWINATTS5.
        /// </summary>
        public const string LWINATTS5 = "LWINATTS5";

        /// <summary>
        /// LWINATTS6.
        /// </summary>
        public const string LWINATTS6 = "LWINATTS6";

        /// <summary>
        /// LWINATTS7.
        /// </summary>
        public const string LWINATTS7 = "LWINATTS7";

        /// <summary>
        /// LWINATTS8.
        /// </summary>
        public const string LWINATTS8 = "LWINATTS8";

        /// <summary>
        /// LWINATTD9.
        /// </summary>
        public const string LWINATTD9 = "LWINATTD9";

        /// <summary>
        /// LWINATTD10.
        /// </summary>
        public const string LWINATTD10 = "LWINATTD10";

        /// <summary>
        /// LWINATTD11.
        /// </summary>
        public const string LWINATTD11 = "LWINATTD11";

        /// <summary>
        /// LWINATTD12.
        /// </summary>
        public const string LWINATTD12 = "LWINATTD12";

        /// <summary>
        /// LWWVTY.
        /// </summary>
        public const string LWWVTY = "LWWVTY";

        /// <summary>
        /// LWWTBOQTY.
        /// </summary>
        public const string LWWTBOQTY = "LWWTBOQTY";

        /// <summary>
        /// LWWTBOUOM.
        /// </summary>
        public const string LWWTBOUOM = "LWWTBOUOM";

        /// <summary>
        /// LWWTBOTB.
        /// </summary>
        public const string LWWTBOTB = "LWWTBOTB";

        /// <summary>
        /// LWWTBOMAT.
        /// </summary>
        public const string LWWTBOMAT = "LWWTBOMAT";

        /// <summary>
        /// LWWTBOST.
        /// </summary>
        public const string LWWTBOST = "LWWTBOST";

        /// <summary>
        /// LWWTBQOP.
        /// </summary>
        public const string LWWTBQOP = "LWWTBQOP";

        /// <summary>
        /// LWDL01.
        /// </summary>
        public const string LWDL01 = "LWDL01";

        /// <summary>
        /// LWEURQTY.
        /// </summary>
        public const string LWEURQTY = "LWEURQTY";

        /// <summary>
        /// LWWTBCLOTN.
        /// </summary>
        public const string LWWTBCLOTN = "LWWTBCLOTN";

        /// <summary>
        /// LWWTBCMAT.
        /// </summary>
        public const string LWWTBCMAT = "LWWTBCMAT";

        /// <summary>
        /// LWWTBCTB.
        /// </summary>
        public const string LWWTBCTB = "LWWTBCTB";

        /// <summary>
        /// LWWTBCUOM.
        /// </summary>
        public const string LWWTBCUOM = "LWWTBCUOM";

        /// <summary>
        /// LWWTBCWST.
        /// </summary>
        public const string LWWTBCWST = "LWWTBCWST";

        /// <summary>
        /// LWWTBCQTY.
        /// </summary>
        public const string LWWTBCQTY = "LWWTBCQTY";

        /// <summary>
        /// LWWTBCOPID.
        /// </summary>
        public const string LWWTBCOPID = "LWWTBCOPID";

        /// <summary>
        /// LWBQSSZ.
        /// </summary>
        public const string LWBQSSZ = "LWBQSSZ";

        /// <summary>
        /// LWQUM.
        /// </summary>
        public const string LWQUM = "LWQUM";

        /// <summary>
        /// LWBSNBR.
        /// </summary>
        public const string LWBSNBR = "LWBSNBR";
    }

    /// <inheritdoc />
    public override string TableName => "F31B115W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LWWTBID", "LWWTBID", JdeDataType.Numeric, null, true, true),
        new JdeField("LWMCU", "LWMCU", JdeDataType.String, 24, true, true),
        new JdeField("LWWTBINOT", "LWWTBINOT", JdeDataType.String, 2, true, true),
        new JdeField("LWWLOTN", "LWWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LWWTBLOSE", "LWWTBLOSE", JdeDataType.String, 2),
        new JdeField("LWWVID", "LWWVID", JdeDataType.Numeric),
        new JdeField("LWWVNUM", "LWWVNUM", JdeDataType.String, 60),
        new JdeField("LWWBID", "LWWBID", JdeDataType.String, 60),
        new JdeField("LWEURID", "LWEURID", JdeDataType.Numeric),
        new JdeField("LWEURSCD", "LWEURSCD", JdeDataType.String, 20),
        new JdeField("LWWISSC", "LWWISSC", JdeDataType.String, 12),
        new JdeField("LWAWBID", "LWAWBID", JdeDataType.String, 60),
        new JdeField("LWMATYP", "LWMATYP", JdeDataType.String, 8),
        new JdeField("LWWOPID", "LWWOPID", JdeDataType.Numeric),
        new JdeField("LWSATTN1", "LWSATTN1", JdeDataType.Numeric),
        new JdeField("LWSATTN2", "LWSATTN2", JdeDataType.Numeric),
        new JdeField("LWSATTN3", "LWSATTN3", JdeDataType.Numeric),
        new JdeField("LWSATTN4", "LWSATTN4", JdeDataType.Numeric),
        new JdeField("LWSATTN5", "LWSATTN5", JdeDataType.Numeric),
        new JdeField("LWSATTN6", "LWSATTN6", JdeDataType.Numeric),
        new JdeField("LWSATTN7", "LWSATTN7", JdeDataType.Numeric),
        new JdeField("LWSATTN8", "LWSATTN8", JdeDataType.Numeric),
        new JdeField("LWSATTN9", "LWSATTN9", JdeDataType.Numeric),
        new JdeField("LWSATTN10", "LWSATTN10", JdeDataType.Numeric),
        new JdeField("LWSATTN11", "LWSATTN11", JdeDataType.Numeric),
        new JdeField("LWSATTN12", "LWSATTN12", JdeDataType.Numeric),
        new JdeField("LWSATTN13", "LWSATTN13", JdeDataType.Numeric),
        new JdeField("LWSATTN14", "LWSATTN14", JdeDataType.Numeric),
        new JdeField("LWSATTN15", "LWSATTN15", JdeDataType.Numeric),
        new JdeField("LWSATTS16", "LWSATTS16", JdeDataType.String, 40),
        new JdeField("LWSATTS17", "LWSATTS17", JdeDataType.String, 40),
        new JdeField("LWSATTS18", "LWSATTS18", JdeDataType.String, 40),
        new JdeField("LWSATTS19", "LWSATTS19", JdeDataType.String, 40),
        new JdeField("LWSATTS20", "LWSATTS20", JdeDataType.String, 40),
        new JdeField("LWSATTS21", "LWSATTS21", JdeDataType.String, 40),
        new JdeField("LWSATTS22", "LWSATTS22", JdeDataType.String, 40),
        new JdeField("LWSATTS23", "LWSATTS23", JdeDataType.String, 40),
        new JdeField("LWSATTS24", "LWSATTS24", JdeDataType.String, 40),
        new JdeField("LWSATTS25", "LWSATTS25", JdeDataType.String, 40),
        new JdeField("LWLTQNTY", "LWLTQNTY", JdeDataType.Numeric),
        new JdeField("LWLTUOM", "LWLTUOM", JdeDataType.String, 6),
        new JdeField("LWWTBQCN", "LWWTBQCN", JdeDataType.Numeric),
        new JdeField("LWWTBPCN", "LWWTBPCN", JdeDataType.Numeric),
        new JdeField("LWWTBCPER", "LWWTBCPER", JdeDataType.Numeric),
        new JdeField("LWWPERLQTY", "LWWPERLQTY", JdeDataType.Numeric),
        new JdeField("LWWPERTBE", "LWWPERTBE", JdeDataType.Numeric),
        new JdeField("LWWPERTBQ", "LWWPERTBQ", JdeDataType.Numeric),
        new JdeField("LWWTBSTAT", "LWWTBSTAT", JdeDataType.String, 2),
        new JdeField("LWWNCCOLN1", "LWWNCCOLN1", JdeDataType.Numeric),
        new JdeField("LWWNCCOLN2", "LWWNCCOLN2", JdeDataType.Numeric),
        new JdeField("LWWNCCOLN3", "LWWNCCOLN3", JdeDataType.Numeric),
        new JdeField("LWWNCCOLN4", "LWWNCCOLN4", JdeDataType.Numeric),
        new JdeField("LWWNCCOLN5", "LWWNCCOLN5", JdeDataType.Numeric),
        new JdeField("LWWNCCOLN6", "LWWNCCOLN6", JdeDataType.Numeric),
        new JdeField("LWWNCCOLS1", "LWWNCCOLS1", JdeDataType.String, 40),
        new JdeField("LWWNCCOLS2", "LWWNCCOLS2", JdeDataType.String, 40),
        new JdeField("LWWNCCOLS3", "LWWNCCOLS3", JdeDataType.String, 40),
        new JdeField("LWWNCCOLS4", "LWWNCCOLS4", JdeDataType.String, 40),
        new JdeField("LWWNCCOLS5", "LWWNCCOLS5", JdeDataType.String, 40),
        new JdeField("LWWNCCOLS6", "LWWNCCOLS6", JdeDataType.String, 40),
        new JdeField("LWWNCCOLD1", "LWWNCCOLD1", JdeDataType.Numeric),
        new JdeField("LWWNCCOLD2", "LWWNCCOLD2", JdeDataType.Numeric),
        new JdeField("LWWNCCOLD3", "LWWNCCOLD3", JdeDataType.Numeric),
        new JdeField("LWWNCCOLD4", "LWWNCCOLD4", JdeDataType.Numeric),
        new JdeField("LWWNCCOLD5", "LWWNCCOLD5", JdeDataType.Numeric),
        new JdeField("LWWNCCOLD6", "LWWNCCOLD6", JdeDataType.Numeric),
        new JdeField("LWURAB", "LWURAB", JdeDataType.Numeric),
        new JdeField("LWURAT", "LWURAT", JdeDataType.Numeric),
        new JdeField("LWURCD", "LWURCD", JdeDataType.String, 4),
        new JdeField("LWURDT", "LWURDT", JdeDataType.Numeric),
        new JdeField("LWURRF", "LWURRF", JdeDataType.String, 30),
        new JdeField("LWWAB", "LWWAB", JdeDataType.Numeric),
        new JdeField("LWWNUM", "LWWNUM", JdeDataType.Numeric),
        new JdeField("LWWCD", "LWWCD", JdeDataType.String, 6),
        new JdeField("LWWMDT", "LWWMDT", JdeDataType.Numeric),
        new JdeField("LWWRF", "LWWRF", JdeDataType.String, 60),
        new JdeField("LWUSER", "LWUSER", JdeDataType.String, 20),
        new JdeField("LWUPMJ", "LWUPMJ", JdeDataType.Numeric),
        new JdeField("LWUPMT", "LWUPMT", JdeDataType.Numeric),
        new JdeField("LWJOBN", "LWJOBN", JdeDataType.String, 20),
        new JdeField("LWMKEY", "LWMKEY", JdeDataType.String, 30),
        new JdeField("LWPID", "LWPID", JdeDataType.String, 20),
        new JdeField("LWINATTN1", "LWINATTN1", JdeDataType.Numeric),
        new JdeField("LWINATTN2", "LWINATTN2", JdeDataType.Numeric),
        new JdeField("LWINATTN3", "LWINATTN3", JdeDataType.Numeric),
        new JdeField("LWINATTN4", "LWINATTN4", JdeDataType.Numeric),
        new JdeField("LWINATTS5", "LWINATTS5", JdeDataType.String, 40),
        new JdeField("LWINATTS6", "LWINATTS6", JdeDataType.String, 40),
        new JdeField("LWINATTS7", "LWINATTS7", JdeDataType.String, 40),
        new JdeField("LWINATTS8", "LWINATTS8", JdeDataType.String, 40),
        new JdeField("LWINATTD9", "LWINATTD9", JdeDataType.Numeric),
        new JdeField("LWINATTD10", "LWINATTD10", JdeDataType.Numeric),
        new JdeField("LWINATTD11", "LWINATTD11", JdeDataType.Numeric),
        new JdeField("LWINATTD12", "LWINATTD12", JdeDataType.Numeric),
        new JdeField("LWWVTY", "LWWVTY", JdeDataType.String, 2),
        new JdeField("LWWTBOQTY", "LWWTBOQTY", JdeDataType.Numeric),
        new JdeField("LWWTBOUOM", "LWWTBOUOM", JdeDataType.String, 6),
        new JdeField("LWWTBOTB", "LWWTBOTB", JdeDataType.String, 60),
        new JdeField("LWWTBOMAT", "LWWTBOMAT", JdeDataType.String, 8),
        new JdeField("LWWTBOST", "LWWTBOST", JdeDataType.String, 12),
        new JdeField("LWWTBQOP", "LWWTBQOP", JdeDataType.String, 2),
        new JdeField("LWDL01", "LWDL01", JdeDataType.String, 60),
        new JdeField("LWEURQTY", "LWEURQTY", JdeDataType.Numeric),
        new JdeField("LWWTBCLOTN", "LWWTBCLOTN", JdeDataType.String, 60),
        new JdeField("LWWTBCMAT", "LWWTBCMAT", JdeDataType.String, 8),
        new JdeField("LWWTBCTB", "LWWTBCTB", JdeDataType.String, 60),
        new JdeField("LWWTBCUOM", "LWWTBCUOM", JdeDataType.String, 6),
        new JdeField("LWWTBCWST", "LWWTBCWST", JdeDataType.String, 12),
        new JdeField("LWWTBCQTY", "LWWTBCQTY", JdeDataType.Numeric),
        new JdeField("LWWTBCOPID", "LWWTBCOPID", JdeDataType.Numeric),
        new JdeField("LWBQSSZ", "LWBQSSZ", JdeDataType.Numeric),
        new JdeField("LWQUM", "LWQUM", JdeDataType.String, 6),
        new JdeField("LWBSNBR", "LWBSNBR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B115W_0", "Primary Key on LWWTBID, LWWTBINOT, LWMCU, LWWLOTN", new[] { "LWWTBID", "LWWTBINOT", "LWMCU", "LWWLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B115W_2", "Index on LWWTBID, LWWLOTN, LWWVID", new[] { "LWWTBID", "LWWLOTN", "LWWVID" }),
        new JdeIndex("F31B115W_3", "Index on LWWVID, LWWOPID", new[] { "LWWVID", "LWWOPID" }),
        new JdeIndex("F31B115W_4", "Index on LWWVID, LWWTBID", new[] { "LWWVID", "LWWTBID" }),
        new JdeIndex("F31B115W_5", "Index on LWWVID, LWEURID", new[] { "LWWVID", "LWEURID" }),
        new JdeIndex("F31B115W_6", "Index on LWAWBID, LWWOPID", new[] { "LWAWBID", "LWWOPID" })
    };
}
