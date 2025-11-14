using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B61 - .
/// </summary>
public class F31B61 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ELWFSSID.
        /// </summary>
        public const string ELWFSSID = "ELWFSSID";

        /// <summary>
        /// ELWVID.
        /// </summary>
        public const string ELWVID = "ELWVID";

        /// <summary>
        /// ELWOPID.
        /// </summary>
        public const string ELWOPID = "ELWOPID";

        /// <summary>
        /// ELMMCU.
        /// </summary>
        public const string ELMMCU = "ELMMCU";

        /// <summary>
        /// ELWOPN.
        /// </summary>
        public const string ELWOPN = "ELWOPN";

        /// <summary>
        /// ELWVNUM.
        /// </summary>
        public const string ELWVNUM = "ELWVNUM";

        /// <summary>
        /// ELWVTY.
        /// </summary>
        public const string ELWVTY = "ELWVTY";

        /// <summary>
        /// ELWBID.
        /// </summary>
        public const string ELWBID = "ELWBID";

        /// <summary>
        /// ELWLOTN.
        /// </summary>
        public const string ELWLOTN = "ELWLOTN";

        /// <summary>
        /// ELLTQNTY.
        /// </summary>
        public const string ELLTQNTY = "ELLTQNTY";

        /// <summary>
        /// ELLTUOM.
        /// </summary>
        public const string ELLTUOM = "ELLTUOM";

        /// <summary>
        /// ELDOCO.
        /// </summary>
        public const string ELDOCO = "ELDOCO";

        /// <summary>
        /// ELMATYP.
        /// </summary>
        public const string ELMATYP = "ELMATYP";

        /// <summary>
        /// ELWISSC.
        /// </summary>
        public const string ELWISSC = "ELWISSC";

        /// <summary>
        /// ELWASDT.
        /// </summary>
        public const string ELWASDT = "ELWASDT";

        /// <summary>
        /// ELWSD.
        /// </summary>
        public const string ELWSD = "ELWSD";

        /// <summary>
        /// ELUSER.
        /// </summary>
        public const string ELUSER = "ELUSER";

        /// <summary>
        /// ELPID.
        /// </summary>
        public const string ELPID = "ELPID";

        /// <summary>
        /// ELJOBN.
        /// </summary>
        public const string ELJOBN = "ELJOBN";

        /// <summary>
        /// ELUPMJ.
        /// </summary>
        public const string ELUPMJ = "ELUPMJ";

        /// <summary>
        /// ELTDAY.
        /// </summary>
        public const string ELTDAY = "ELTDAY";

        /// <summary>
        /// ELWNCCOLD1.
        /// </summary>
        public const string ELWNCCOLD1 = "ELWNCCOLD1";

        /// <summary>
        /// ELWNCCOLD2.
        /// </summary>
        public const string ELWNCCOLD2 = "ELWNCCOLD2";

        /// <summary>
        /// ELWNCCOLD3.
        /// </summary>
        public const string ELWNCCOLD3 = "ELWNCCOLD3";

        /// <summary>
        /// ELWNCCOLD4.
        /// </summary>
        public const string ELWNCCOLD4 = "ELWNCCOLD4";

        /// <summary>
        /// ELWNCCOLD5.
        /// </summary>
        public const string ELWNCCOLD5 = "ELWNCCOLD5";

        /// <summary>
        /// ELWNCCOLD6.
        /// </summary>
        public const string ELWNCCOLD6 = "ELWNCCOLD6";

        /// <summary>
        /// ELWNCCOLN1.
        /// </summary>
        public const string ELWNCCOLN1 = "ELWNCCOLN1";

        /// <summary>
        /// ELWNCCOLN2.
        /// </summary>
        public const string ELWNCCOLN2 = "ELWNCCOLN2";

        /// <summary>
        /// ELWNCCOLN3.
        /// </summary>
        public const string ELWNCCOLN3 = "ELWNCCOLN3";

        /// <summary>
        /// ELWNCCOLN4.
        /// </summary>
        public const string ELWNCCOLN4 = "ELWNCCOLN4";

        /// <summary>
        /// ELWNCCOLN5.
        /// </summary>
        public const string ELWNCCOLN5 = "ELWNCCOLN5";

        /// <summary>
        /// ELWNCCOLN6.
        /// </summary>
        public const string ELWNCCOLN6 = "ELWNCCOLN6";

        /// <summary>
        /// ELWNCCOLS1.
        /// </summary>
        public const string ELWNCCOLS1 = "ELWNCCOLS1";

        /// <summary>
        /// ELWNCCOLS2.
        /// </summary>
        public const string ELWNCCOLS2 = "ELWNCCOLS2";

        /// <summary>
        /// ELWNCCOLS3.
        /// </summary>
        public const string ELWNCCOLS3 = "ELWNCCOLS3";

        /// <summary>
        /// ELWNCCOLS4.
        /// </summary>
        public const string ELWNCCOLS4 = "ELWNCCOLS4";

        /// <summary>
        /// ELWNCCOLS5.
        /// </summary>
        public const string ELWNCCOLS5 = "ELWNCCOLS5";

        /// <summary>
        /// ELWNCCOLS6.
        /// </summary>
        public const string ELWNCCOLS6 = "ELWNCCOLS6";

        /// <summary>
        /// ELSATTN1.
        /// </summary>
        public const string ELSATTN1 = "ELSATTN1";

        /// <summary>
        /// ELSATTN2.
        /// </summary>
        public const string ELSATTN2 = "ELSATTN2";

        /// <summary>
        /// ELSATTN3.
        /// </summary>
        public const string ELSATTN3 = "ELSATTN3";

        /// <summary>
        /// ELSATTN4.
        /// </summary>
        public const string ELSATTN4 = "ELSATTN4";

        /// <summary>
        /// ELSATTN5.
        /// </summary>
        public const string ELSATTN5 = "ELSATTN5";

        /// <summary>
        /// ELSATTN6.
        /// </summary>
        public const string ELSATTN6 = "ELSATTN6";

        /// <summary>
        /// ELSATTN7.
        /// </summary>
        public const string ELSATTN7 = "ELSATTN7";

        /// <summary>
        /// ELSATTN8.
        /// </summary>
        public const string ELSATTN8 = "ELSATTN8";

        /// <summary>
        /// ELSATTN9.
        /// </summary>
        public const string ELSATTN9 = "ELSATTN9";

        /// <summary>
        /// ELSATTN10.
        /// </summary>
        public const string ELSATTN10 = "ELSATTN10";

        /// <summary>
        /// ELSATTN11.
        /// </summary>
        public const string ELSATTN11 = "ELSATTN11";

        /// <summary>
        /// ELSATTN12.
        /// </summary>
        public const string ELSATTN12 = "ELSATTN12";

        /// <summary>
        /// ELSATTN13.
        /// </summary>
        public const string ELSATTN13 = "ELSATTN13";

        /// <summary>
        /// ELSATTN14.
        /// </summary>
        public const string ELSATTN14 = "ELSATTN14";

        /// <summary>
        /// ELSATTN15.
        /// </summary>
        public const string ELSATTN15 = "ELSATTN15";

        /// <summary>
        /// ELSATTS16.
        /// </summary>
        public const string ELSATTS16 = "ELSATTS16";

        /// <summary>
        /// ELSATTS17.
        /// </summary>
        public const string ELSATTS17 = "ELSATTS17";

        /// <summary>
        /// ELSATTS18.
        /// </summary>
        public const string ELSATTS18 = "ELSATTS18";

        /// <summary>
        /// ELSATTS19.
        /// </summary>
        public const string ELSATTS19 = "ELSATTS19";

        /// <summary>
        /// ELSATTS20.
        /// </summary>
        public const string ELSATTS20 = "ELSATTS20";

        /// <summary>
        /// ELSATTS21.
        /// </summary>
        public const string ELSATTS21 = "ELSATTS21";

        /// <summary>
        /// ELSATTS22.
        /// </summary>
        public const string ELSATTS22 = "ELSATTS22";

        /// <summary>
        /// ELSATTS23.
        /// </summary>
        public const string ELSATTS23 = "ELSATTS23";

        /// <summary>
        /// ELSATTS24.
        /// </summary>
        public const string ELSATTS24 = "ELSATTS24";

        /// <summary>
        /// ELSATTS25.
        /// </summary>
        public const string ELSATTS25 = "ELSATTS25";

        /// <summary>
        /// ELINATTN1.
        /// </summary>
        public const string ELINATTN1 = "ELINATTN1";

        /// <summary>
        /// ELINATTN2.
        /// </summary>
        public const string ELINATTN2 = "ELINATTN2";

        /// <summary>
        /// ELINATTN3.
        /// </summary>
        public const string ELINATTN3 = "ELINATTN3";

        /// <summary>
        /// ELINATTN4.
        /// </summary>
        public const string ELINATTN4 = "ELINATTN4";

        /// <summary>
        /// ELINATTS5.
        /// </summary>
        public const string ELINATTS5 = "ELINATTS5";

        /// <summary>
        /// ELINATTS6.
        /// </summary>
        public const string ELINATTS6 = "ELINATTS6";

        /// <summary>
        /// ELINATTS7.
        /// </summary>
        public const string ELINATTS7 = "ELINATTS7";

        /// <summary>
        /// ELINATTS8.
        /// </summary>
        public const string ELINATTS8 = "ELINATTS8";

        /// <summary>
        /// ELINATTD9.
        /// </summary>
        public const string ELINATTD9 = "ELINATTD9";

        /// <summary>
        /// ELINATTD10.
        /// </summary>
        public const string ELINATTD10 = "ELINATTD10";

        /// <summary>
        /// ELINATTD11.
        /// </summary>
        public const string ELINATTD11 = "ELINATTD11";

        /// <summary>
        /// ELINATTD12.
        /// </summary>
        public const string ELINATTD12 = "ELINATTD12";
    }

    /// <inheritdoc />
    public override string TableName => "F31B61";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ELWFSSID", "ELWFSSID", JdeDataType.String, 64, true, true),
        new JdeField("ELWVID", "ELWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("ELWOPID", "ELWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ELMMCU", "ELMMCU", JdeDataType.String, 24),
        new JdeField("ELWOPN", "ELWOPN", JdeDataType.Numeric),
        new JdeField("ELWVNUM", "ELWVNUM", JdeDataType.String, 60),
        new JdeField("ELWVTY", "ELWVTY", JdeDataType.String, 2),
        new JdeField("ELWBID", "ELWBID", JdeDataType.String, 60),
        new JdeField("ELWLOTN", "ELWLOTN", JdeDataType.String, 60),
        new JdeField("ELLTQNTY", "ELLTQNTY", JdeDataType.Numeric),
        new JdeField("ELLTUOM", "ELLTUOM", JdeDataType.String, 6),
        new JdeField("ELDOCO", "ELDOCO", JdeDataType.Numeric),
        new JdeField("ELMATYP", "ELMATYP", JdeDataType.String, 8),
        new JdeField("ELWISSC", "ELWISSC", JdeDataType.String, 12),
        new JdeField("ELWASDT", "ELWASDT", JdeDataType.Date),
        new JdeField("ELWSD", "ELWSD", JdeDataType.String, 60),
        new JdeField("ELUSER", "ELUSER", JdeDataType.String, 20),
        new JdeField("ELPID", "ELPID", JdeDataType.String, 20),
        new JdeField("ELJOBN", "ELJOBN", JdeDataType.String, 20),
        new JdeField("ELUPMJ", "ELUPMJ", JdeDataType.Numeric),
        new JdeField("ELTDAY", "ELTDAY", JdeDataType.Numeric),
        new JdeField("ELWNCCOLD1", "ELWNCCOLD1", JdeDataType.Numeric),
        new JdeField("ELWNCCOLD2", "ELWNCCOLD2", JdeDataType.Numeric),
        new JdeField("ELWNCCOLD3", "ELWNCCOLD3", JdeDataType.Numeric),
        new JdeField("ELWNCCOLD4", "ELWNCCOLD4", JdeDataType.Numeric),
        new JdeField("ELWNCCOLD5", "ELWNCCOLD5", JdeDataType.Numeric),
        new JdeField("ELWNCCOLD6", "ELWNCCOLD6", JdeDataType.Numeric),
        new JdeField("ELWNCCOLN1", "ELWNCCOLN1", JdeDataType.Numeric),
        new JdeField("ELWNCCOLN2", "ELWNCCOLN2", JdeDataType.Numeric),
        new JdeField("ELWNCCOLN3", "ELWNCCOLN3", JdeDataType.Numeric),
        new JdeField("ELWNCCOLN4", "ELWNCCOLN4", JdeDataType.Numeric),
        new JdeField("ELWNCCOLN5", "ELWNCCOLN5", JdeDataType.Numeric),
        new JdeField("ELWNCCOLN6", "ELWNCCOLN6", JdeDataType.Numeric),
        new JdeField("ELWNCCOLS1", "ELWNCCOLS1", JdeDataType.String, 40),
        new JdeField("ELWNCCOLS2", "ELWNCCOLS2", JdeDataType.String, 40),
        new JdeField("ELWNCCOLS3", "ELWNCCOLS3", JdeDataType.String, 40),
        new JdeField("ELWNCCOLS4", "ELWNCCOLS4", JdeDataType.String, 40),
        new JdeField("ELWNCCOLS5", "ELWNCCOLS5", JdeDataType.String, 40),
        new JdeField("ELWNCCOLS6", "ELWNCCOLS6", JdeDataType.String, 40),
        new JdeField("ELSATTN1", "ELSATTN1", JdeDataType.Numeric),
        new JdeField("ELSATTN2", "ELSATTN2", JdeDataType.Numeric),
        new JdeField("ELSATTN3", "ELSATTN3", JdeDataType.Numeric),
        new JdeField("ELSATTN4", "ELSATTN4", JdeDataType.Numeric),
        new JdeField("ELSATTN5", "ELSATTN5", JdeDataType.Numeric),
        new JdeField("ELSATTN6", "ELSATTN6", JdeDataType.Numeric),
        new JdeField("ELSATTN7", "ELSATTN7", JdeDataType.Numeric),
        new JdeField("ELSATTN8", "ELSATTN8", JdeDataType.Numeric),
        new JdeField("ELSATTN9", "ELSATTN9", JdeDataType.Numeric),
        new JdeField("ELSATTN10", "ELSATTN10", JdeDataType.Numeric),
        new JdeField("ELSATTN11", "ELSATTN11", JdeDataType.Numeric),
        new JdeField("ELSATTN12", "ELSATTN12", JdeDataType.Numeric),
        new JdeField("ELSATTN13", "ELSATTN13", JdeDataType.Numeric),
        new JdeField("ELSATTN14", "ELSATTN14", JdeDataType.Numeric),
        new JdeField("ELSATTN15", "ELSATTN15", JdeDataType.Numeric),
        new JdeField("ELSATTS16", "ELSATTS16", JdeDataType.String, 40),
        new JdeField("ELSATTS17", "ELSATTS17", JdeDataType.String, 40),
        new JdeField("ELSATTS18", "ELSATTS18", JdeDataType.String, 40),
        new JdeField("ELSATTS19", "ELSATTS19", JdeDataType.String, 40),
        new JdeField("ELSATTS20", "ELSATTS20", JdeDataType.String, 40),
        new JdeField("ELSATTS21", "ELSATTS21", JdeDataType.String, 40),
        new JdeField("ELSATTS22", "ELSATTS22", JdeDataType.String, 40),
        new JdeField("ELSATTS23", "ELSATTS23", JdeDataType.String, 40),
        new JdeField("ELSATTS24", "ELSATTS24", JdeDataType.String, 40),
        new JdeField("ELSATTS25", "ELSATTS25", JdeDataType.String, 40),
        new JdeField("ELINATTN1", "ELINATTN1", JdeDataType.Numeric),
        new JdeField("ELINATTN2", "ELINATTN2", JdeDataType.Numeric),
        new JdeField("ELINATTN3", "ELINATTN3", JdeDataType.Numeric),
        new JdeField("ELINATTN4", "ELINATTN4", JdeDataType.Numeric),
        new JdeField("ELINATTS5", "ELINATTS5", JdeDataType.String, 40),
        new JdeField("ELINATTS6", "ELINATTS6", JdeDataType.String, 40),
        new JdeField("ELINATTS7", "ELINATTS7", JdeDataType.String, 40),
        new JdeField("ELINATTS8", "ELINATTS8", JdeDataType.String, 40),
        new JdeField("ELINATTD9", "ELINATTD9", JdeDataType.Numeric),
        new JdeField("ELINATTD10", "ELINATTD10", JdeDataType.Numeric),
        new JdeField("ELINATTD11", "ELINATTD11", JdeDataType.Numeric),
        new JdeField("ELINATTD12", "ELINATTD12", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B61_0", "Primary Key on ELWFSSID, ELWVID, ELWOPID", new[] { "ELWFSSID", "ELWVID", "ELWOPID" }, isUnique: true, isPrimaryKey: true)
    };
}
