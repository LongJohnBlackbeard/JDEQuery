using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B88 - .
/// </summary>
public class F31B88 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IVMCU.
        /// </summary>
        public const string IVMCU = "IVMCU";

        /// <summary>
        /// IVWVTY.
        /// </summary>
        public const string IVWVTY = "IVWVTY";

        /// <summary>
        /// IVWVID.
        /// </summary>
        public const string IVWVID = "IVWVID";

        /// <summary>
        /// IVUKID.
        /// </summary>
        public const string IVUKID = "IVUKID";

        /// <summary>
        /// IVWOPID.
        /// </summary>
        public const string IVWOPID = "IVWOPID";

        /// <summary>
        /// IVWVNUM.
        /// </summary>
        public const string IVWVNUM = "IVWVNUM";

        /// <summary>
        /// IVTKTYP.
        /// </summary>
        public const string IVTKTYP = "IVTKTYP";

        /// <summary>
        /// IVLOCN.
        /// </summary>
        public const string IVLOCN = "IVLOCN";

        /// <summary>
        /// IVTKCS.
        /// </summary>
        public const string IVTKCS = "IVTKCS";

        /// <summary>
        /// IVTKSTA.
        /// </summary>
        public const string IVTKSTA = "IVTKSTA";

        /// <summary>
        /// IVTKVS.
        /// </summary>
        public const string IVTKVS = "IVTKVS";

        /// <summary>
        /// IVNUMBAR.
        /// </summary>
        public const string IVNUMBAR = "IVNUMBAR";

        /// <summary>
        /// IVWBID.
        /// </summary>
        public const string IVWBID = "IVWBID";

        /// <summary>
        /// IVMATYP.
        /// </summary>
        public const string IVMATYP = "IVMATYP";

        /// <summary>
        /// IVWISSC.
        /// </summary>
        public const string IVWISSC = "IVWISSC";

        /// <summary>
        /// IVWEURQTY.
        /// </summary>
        public const string IVWEURQTY = "IVWEURQTY";

        /// <summary>
        /// IVLTQNTY.
        /// </summary>
        public const string IVLTQNTY = "IVLTQNTY";

        /// <summary>
        /// IVLTSTAT.
        /// </summary>
        public const string IVLTSTAT = "IVLTSTAT";

        /// <summary>
        /// IVSATTN1.
        /// </summary>
        public const string IVSATTN1 = "IVSATTN1";

        /// <summary>
        /// IVSATTN2.
        /// </summary>
        public const string IVSATTN2 = "IVSATTN2";

        /// <summary>
        /// IVSATTN3.
        /// </summary>
        public const string IVSATTN3 = "IVSATTN3";

        /// <summary>
        /// IVSATTN4.
        /// </summary>
        public const string IVSATTN4 = "IVSATTN4";

        /// <summary>
        /// IVSATTN5.
        /// </summary>
        public const string IVSATTN5 = "IVSATTN5";

        /// <summary>
        /// IVSATTN6.
        /// </summary>
        public const string IVSATTN6 = "IVSATTN6";

        /// <summary>
        /// IVSATTN7.
        /// </summary>
        public const string IVSATTN7 = "IVSATTN7";

        /// <summary>
        /// IVSATTN8.
        /// </summary>
        public const string IVSATTN8 = "IVSATTN8";

        /// <summary>
        /// IVSATTN9.
        /// </summary>
        public const string IVSATTN9 = "IVSATTN9";

        /// <summary>
        /// IVSATTN10.
        /// </summary>
        public const string IVSATTN10 = "IVSATTN10";

        /// <summary>
        /// IVSATTN11.
        /// </summary>
        public const string IVSATTN11 = "IVSATTN11";

        /// <summary>
        /// IVSATTN12.
        /// </summary>
        public const string IVSATTN12 = "IVSATTN12";

        /// <summary>
        /// IVSATTN13.
        /// </summary>
        public const string IVSATTN13 = "IVSATTN13";

        /// <summary>
        /// IVSATTN14.
        /// </summary>
        public const string IVSATTN14 = "IVSATTN14";

        /// <summary>
        /// IVSATTN15.
        /// </summary>
        public const string IVSATTN15 = "IVSATTN15";

        /// <summary>
        /// IVSATTS16.
        /// </summary>
        public const string IVSATTS16 = "IVSATTS16";

        /// <summary>
        /// IVSATTS17.
        /// </summary>
        public const string IVSATTS17 = "IVSATTS17";

        /// <summary>
        /// IVSATTS18.
        /// </summary>
        public const string IVSATTS18 = "IVSATTS18";

        /// <summary>
        /// IVSATTS19.
        /// </summary>
        public const string IVSATTS19 = "IVSATTS19";

        /// <summary>
        /// IVSATTS20.
        /// </summary>
        public const string IVSATTS20 = "IVSATTS20";

        /// <summary>
        /// IVSATTS21.
        /// </summary>
        public const string IVSATTS21 = "IVSATTS21";

        /// <summary>
        /// IVSATTS22.
        /// </summary>
        public const string IVSATTS22 = "IVSATTS22";

        /// <summary>
        /// IVSATTS23.
        /// </summary>
        public const string IVSATTS23 = "IVSATTS23";

        /// <summary>
        /// IVSATTS24.
        /// </summary>
        public const string IVSATTS24 = "IVSATTS24";

        /// <summary>
        /// IVSATTS25.
        /// </summary>
        public const string IVSATTS25 = "IVSATTS25";

        /// <summary>
        /// IVINATTN1.
        /// </summary>
        public const string IVINATTN1 = "IVINATTN1";

        /// <summary>
        /// IVINATTN2.
        /// </summary>
        public const string IVINATTN2 = "IVINATTN2";

        /// <summary>
        /// IVINATTN3.
        /// </summary>
        public const string IVINATTN3 = "IVINATTN3";

        /// <summary>
        /// IVINATTN4.
        /// </summary>
        public const string IVINATTN4 = "IVINATTN4";

        /// <summary>
        /// IVINATTS5.
        /// </summary>
        public const string IVINATTS5 = "IVINATTS5";

        /// <summary>
        /// IVINATTS6.
        /// </summary>
        public const string IVINATTS6 = "IVINATTS6";

        /// <summary>
        /// IVINATTS7.
        /// </summary>
        public const string IVINATTS7 = "IVINATTS7";

        /// <summary>
        /// IVINATTS8.
        /// </summary>
        public const string IVINATTS8 = "IVINATTS8";

        /// <summary>
        /// IVINATTD9.
        /// </summary>
        public const string IVINATTD9 = "IVINATTD9";

        /// <summary>
        /// IVINATTD10.
        /// </summary>
        public const string IVINATTD10 = "IVINATTD10";

        /// <summary>
        /// IVINATTD11.
        /// </summary>
        public const string IVINATTD11 = "IVINATTD11";

        /// <summary>
        /// IVINATTD12.
        /// </summary>
        public const string IVINATTD12 = "IVINATTD12";

        /// <summary>
        /// IVWLOTN.
        /// </summary>
        public const string IVWLOTN = "IVWLOTN";

        /// <summary>
        /// IVWOPN.
        /// </summary>
        public const string IVWOPN = "IVWOPN";

        /// <summary>
        /// IVLTUOM.
        /// </summary>
        public const string IVLTUOM = "IVLTUOM";

        /// <summary>
        /// IVEURID.
        /// </summary>
        public const string IVEURID = "IVEURID";

        /// <summary>
        /// IVVLI.
        /// </summary>
        public const string IVVLI = "IVVLI";

        /// <summary>
        /// IVWPRFVOL.
        /// </summary>
        public const string IVWPRFVOL = "IVWPRFVOL";

        /// <summary>
        /// IVWALCVOL.
        /// </summary>
        public const string IVWALCVOL = "IVWALCVOL";

        /// <summary>
        /// IVWSREXFL.
        /// </summary>
        public const string IVWSREXFL = "IVWSREXFL";

        /// <summary>
        /// IVWDOCO.
        /// </summary>
        public const string IVWDOCO = "IVWDOCO";

        /// <summary>
        /// IVTKIN.
        /// </summary>
        public const string IVTKIN = "IVTKIN";

        /// <summary>
        /// IVTKFA.
        /// </summary>
        public const string IVTKFA = "IVTKFA";

        /// <summary>
        /// IVTKSC.
        /// </summary>
        public const string IVTKSC = "IVTKSC";

        /// <summary>
        /// IVTKSH.
        /// </summary>
        public const string IVTKSH = "IVTKSH";

        /// <summary>
        /// IVTKPS.
        /// </summary>
        public const string IVTKPS = "IVTKPS";

        /// <summary>
        /// IVTKPR.
        /// </summary>
        public const string IVTKPR = "IVTKPR";

        /// <summary>
        /// IVAWBID.
        /// </summary>
        public const string IVAWBID = "IVAWBID";

        /// <summary>
        /// IVVBTUSEF.
        /// </summary>
        public const string IVVBTUSEF = "IVVBTUSEF";

        /// <summary>
        /// IVQTYBSVY.
        /// </summary>
        public const string IVQTYBSVY = "IVQTYBSVY";

        /// <summary>
        /// IVWNCCOLN1.
        /// </summary>
        public const string IVWNCCOLN1 = "IVWNCCOLN1";

        /// <summary>
        /// IVWNCCOLN2.
        /// </summary>
        public const string IVWNCCOLN2 = "IVWNCCOLN2";

        /// <summary>
        /// IVWNCCOLN3.
        /// </summary>
        public const string IVWNCCOLN3 = "IVWNCCOLN3";

        /// <summary>
        /// IVWNCCOLN4.
        /// </summary>
        public const string IVWNCCOLN4 = "IVWNCCOLN4";

        /// <summary>
        /// IVWNCCOLN5.
        /// </summary>
        public const string IVWNCCOLN5 = "IVWNCCOLN5";

        /// <summary>
        /// IVWNCCOLN6.
        /// </summary>
        public const string IVWNCCOLN6 = "IVWNCCOLN6";

        /// <summary>
        /// IVWNCCOLS1.
        /// </summary>
        public const string IVWNCCOLS1 = "IVWNCCOLS1";

        /// <summary>
        /// IVWNCCOLS2.
        /// </summary>
        public const string IVWNCCOLS2 = "IVWNCCOLS2";

        /// <summary>
        /// IVWNCCOLS3.
        /// </summary>
        public const string IVWNCCOLS3 = "IVWNCCOLS3";

        /// <summary>
        /// IVWNCCOLS4.
        /// </summary>
        public const string IVWNCCOLS4 = "IVWNCCOLS4";

        /// <summary>
        /// IVWNCCOLS5.
        /// </summary>
        public const string IVWNCCOLS5 = "IVWNCCOLS5";

        /// <summary>
        /// IVWNCCOLS6.
        /// </summary>
        public const string IVWNCCOLS6 = "IVWNCCOLS6";

        /// <summary>
        /// IVWNCCOLD1.
        /// </summary>
        public const string IVWNCCOLD1 = "IVWNCCOLD1";

        /// <summary>
        /// IVWNCCOLD2.
        /// </summary>
        public const string IVWNCCOLD2 = "IVWNCCOLD2";

        /// <summary>
        /// IVWNCCOLD3.
        /// </summary>
        public const string IVWNCCOLD3 = "IVWNCCOLD3";

        /// <summary>
        /// IVWNCCOLD4.
        /// </summary>
        public const string IVWNCCOLD4 = "IVWNCCOLD4";

        /// <summary>
        /// IVWNCCOLD5.
        /// </summary>
        public const string IVWNCCOLD5 = "IVWNCCOLD5";

        /// <summary>
        /// IVWNCCOLD6.
        /// </summary>
        public const string IVWNCCOLD6 = "IVWNCCOLD6";

        /// <summary>
        /// IVNCCOLNM.
        /// </summary>
        public const string IVNCCOLNM = "IVNCCOLNM";

        /// <summary>
        /// IVNCCOLNM2.
        /// </summary>
        public const string IVNCCOLNM2 = "IVNCCOLNM2";

        /// <summary>
        /// IVNCCOLNM3.
        /// </summary>
        public const string IVNCCOLNM3 = "IVNCCOLNM3";

        /// <summary>
        /// IVNCCOLNM4.
        /// </summary>
        public const string IVNCCOLNM4 = "IVNCCOLNM4";

        /// <summary>
        /// IVNCCOLNM5.
        /// </summary>
        public const string IVNCCOLNM5 = "IVNCCOLNM5";

        /// <summary>
        /// IVNCCOLNM6.
        /// </summary>
        public const string IVNCCOLNM6 = "IVNCCOLNM6";

        /// <summary>
        /// IVWNCDT1.
        /// </summary>
        public const string IVWNCDT1 = "IVWNCDT1";

        /// <summary>
        /// IVWNCDT2.
        /// </summary>
        public const string IVWNCDT2 = "IVWNCDT2";

        /// <summary>
        /// IVWNCDT3.
        /// </summary>
        public const string IVWNCDT3 = "IVWNCDT3";

        /// <summary>
        /// IVWNCDT4.
        /// </summary>
        public const string IVWNCDT4 = "IVWNCDT4";

        /// <summary>
        /// IVWNCDT5.
        /// </summary>
        public const string IVWNCDT5 = "IVWNCDT5";

        /// <summary>
        /// IVWNCDT6.
        /// </summary>
        public const string IVWNCDT6 = "IVWNCDT6";

        /// <summary>
        /// IVWSD.
        /// </summary>
        public const string IVWSD = "IVWSD";

        /// <summary>
        /// IVITM.
        /// </summary>
        public const string IVITM = "IVITM";

        /// <summary>
        /// IVLITM.
        /// </summary>
        public const string IVLITM = "IVLITM";

        /// <summary>
        /// IVAITM.
        /// </summary>
        public const string IVAITM = "IVAITM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B88";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IVMCU", "IVMCU", JdeDataType.String, 24, true, true),
        new JdeField("IVWVTY", "IVWVTY", JdeDataType.String, 2, true, true),
        new JdeField("IVWVID", "IVWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("IVUKID", "IVUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IVWOPID", "IVWOPID", JdeDataType.Numeric),
        new JdeField("IVWVNUM", "IVWVNUM", JdeDataType.String, 60),
        new JdeField("IVTKTYP", "IVTKTYP", JdeDataType.String, 6),
        new JdeField("IVLOCN", "IVLOCN", JdeDataType.String, 40),
        new JdeField("IVTKCS", "IVTKCS", JdeDataType.Numeric),
        new JdeField("IVTKSTA", "IVTKSTA", JdeDataType.String, 2),
        new JdeField("IVTKVS", "IVTKVS", JdeDataType.String, 2),
        new JdeField("IVNUMBAR", "IVNUMBAR", JdeDataType.Numeric),
        new JdeField("IVWBID", "IVWBID", JdeDataType.String, 60),
        new JdeField("IVMATYP", "IVMATYP", JdeDataType.String, 8),
        new JdeField("IVWISSC", "IVWISSC", JdeDataType.String, 12),
        new JdeField("IVWEURQTY", "IVWEURQTY", JdeDataType.Numeric),
        new JdeField("IVLTQNTY", "IVLTQNTY", JdeDataType.Numeric),
        new JdeField("IVLTSTAT", "IVLTSTAT", JdeDataType.String, 20),
        new JdeField("IVSATTN1", "IVSATTN1", JdeDataType.Numeric),
        new JdeField("IVSATTN2", "IVSATTN2", JdeDataType.Numeric),
        new JdeField("IVSATTN3", "IVSATTN3", JdeDataType.Numeric),
        new JdeField("IVSATTN4", "IVSATTN4", JdeDataType.Numeric),
        new JdeField("IVSATTN5", "IVSATTN5", JdeDataType.Numeric),
        new JdeField("IVSATTN6", "IVSATTN6", JdeDataType.Numeric),
        new JdeField("IVSATTN7", "IVSATTN7", JdeDataType.Numeric),
        new JdeField("IVSATTN8", "IVSATTN8", JdeDataType.Numeric),
        new JdeField("IVSATTN9", "IVSATTN9", JdeDataType.Numeric),
        new JdeField("IVSATTN10", "IVSATTN10", JdeDataType.Numeric),
        new JdeField("IVSATTN11", "IVSATTN11", JdeDataType.Numeric),
        new JdeField("IVSATTN12", "IVSATTN12", JdeDataType.Numeric),
        new JdeField("IVSATTN13", "IVSATTN13", JdeDataType.Numeric),
        new JdeField("IVSATTN14", "IVSATTN14", JdeDataType.Numeric),
        new JdeField("IVSATTN15", "IVSATTN15", JdeDataType.Numeric),
        new JdeField("IVSATTS16", "IVSATTS16", JdeDataType.String, 40),
        new JdeField("IVSATTS17", "IVSATTS17", JdeDataType.String, 40),
        new JdeField("IVSATTS18", "IVSATTS18", JdeDataType.String, 40),
        new JdeField("IVSATTS19", "IVSATTS19", JdeDataType.String, 40),
        new JdeField("IVSATTS20", "IVSATTS20", JdeDataType.String, 40),
        new JdeField("IVSATTS21", "IVSATTS21", JdeDataType.String, 40),
        new JdeField("IVSATTS22", "IVSATTS22", JdeDataType.String, 40),
        new JdeField("IVSATTS23", "IVSATTS23", JdeDataType.String, 40),
        new JdeField("IVSATTS24", "IVSATTS24", JdeDataType.String, 40),
        new JdeField("IVSATTS25", "IVSATTS25", JdeDataType.String, 40),
        new JdeField("IVINATTN1", "IVINATTN1", JdeDataType.Numeric),
        new JdeField("IVINATTN2", "IVINATTN2", JdeDataType.Numeric),
        new JdeField("IVINATTN3", "IVINATTN3", JdeDataType.Numeric),
        new JdeField("IVINATTN4", "IVINATTN4", JdeDataType.Numeric),
        new JdeField("IVINATTS5", "IVINATTS5", JdeDataType.String, 40),
        new JdeField("IVINATTS6", "IVINATTS6", JdeDataType.String, 40),
        new JdeField("IVINATTS7", "IVINATTS7", JdeDataType.String, 40),
        new JdeField("IVINATTS8", "IVINATTS8", JdeDataType.String, 40),
        new JdeField("IVINATTD9", "IVINATTD9", JdeDataType.Numeric),
        new JdeField("IVINATTD10", "IVINATTD10", JdeDataType.Numeric),
        new JdeField("IVINATTD11", "IVINATTD11", JdeDataType.Numeric),
        new JdeField("IVINATTD12", "IVINATTD12", JdeDataType.Numeric),
        new JdeField("IVWLOTN", "IVWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IVWOPN", "IVWOPN", JdeDataType.Numeric),
        new JdeField("IVLTUOM", "IVLTUOM", JdeDataType.String, 6),
        new JdeField("IVEURID", "IVEURID", JdeDataType.Numeric),
        new JdeField("IVVLI", "IVVLI", JdeDataType.String, 2),
        new JdeField("IVWPRFVOL", "IVWPRFVOL", JdeDataType.Numeric),
        new JdeField("IVWALCVOL", "IVWALCVOL", JdeDataType.Numeric),
        new JdeField("IVWSREXFL", "IVWSREXFL", JdeDataType.String, 2),
        new JdeField("IVWDOCO", "IVWDOCO", JdeDataType.Numeric),
        new JdeField("IVTKIN", "IVTKIN", JdeDataType.String, 2),
        new JdeField("IVTKFA", "IVTKFA", JdeDataType.String, 2),
        new JdeField("IVTKSC", "IVTKSC", JdeDataType.String, 2),
        new JdeField("IVTKSH", "IVTKSH", JdeDataType.String, 2),
        new JdeField("IVTKPS", "IVTKPS", JdeDataType.String, 2),
        new JdeField("IVTKPR", "IVTKPR", JdeDataType.String, 2),
        new JdeField("IVAWBID", "IVAWBID", JdeDataType.String, 60),
        new JdeField("IVVBTUSEF", "IVVBTUSEF", JdeDataType.String, 2),
        new JdeField("IVQTYBSVY", "IVQTYBSVY", JdeDataType.Numeric),
        new JdeField("IVWNCCOLN1", "IVWNCCOLN1", JdeDataType.Numeric),
        new JdeField("IVWNCCOLN2", "IVWNCCOLN2", JdeDataType.Numeric),
        new JdeField("IVWNCCOLN3", "IVWNCCOLN3", JdeDataType.Numeric),
        new JdeField("IVWNCCOLN4", "IVWNCCOLN4", JdeDataType.Numeric),
        new JdeField("IVWNCCOLN5", "IVWNCCOLN5", JdeDataType.Numeric),
        new JdeField("IVWNCCOLN6", "IVWNCCOLN6", JdeDataType.Numeric),
        new JdeField("IVWNCCOLS1", "IVWNCCOLS1", JdeDataType.String, 40),
        new JdeField("IVWNCCOLS2", "IVWNCCOLS2", JdeDataType.String, 40),
        new JdeField("IVWNCCOLS3", "IVWNCCOLS3", JdeDataType.String, 40),
        new JdeField("IVWNCCOLS4", "IVWNCCOLS4", JdeDataType.String, 40),
        new JdeField("IVWNCCOLS5", "IVWNCCOLS5", JdeDataType.String, 40),
        new JdeField("IVWNCCOLS6", "IVWNCCOLS6", JdeDataType.String, 40),
        new JdeField("IVWNCCOLD1", "IVWNCCOLD1", JdeDataType.Numeric),
        new JdeField("IVWNCCOLD2", "IVWNCCOLD2", JdeDataType.Numeric),
        new JdeField("IVWNCCOLD3", "IVWNCCOLD3", JdeDataType.Numeric),
        new JdeField("IVWNCCOLD4", "IVWNCCOLD4", JdeDataType.Numeric),
        new JdeField("IVWNCCOLD5", "IVWNCCOLD5", JdeDataType.Numeric),
        new JdeField("IVWNCCOLD6", "IVWNCCOLD6", JdeDataType.Numeric),
        new JdeField("IVNCCOLNM", "IVNCCOLNM", JdeDataType.String, 40),
        new JdeField("IVNCCOLNM2", "IVNCCOLNM2", JdeDataType.String, 40),
        new JdeField("IVNCCOLNM3", "IVNCCOLNM3", JdeDataType.String, 40),
        new JdeField("IVNCCOLNM4", "IVNCCOLNM4", JdeDataType.String, 40),
        new JdeField("IVNCCOLNM5", "IVNCCOLNM5", JdeDataType.String, 40),
        new JdeField("IVNCCOLNM6", "IVNCCOLNM6", JdeDataType.String, 40),
        new JdeField("IVWNCDT1", "IVWNCDT1", JdeDataType.String, 4),
        new JdeField("IVWNCDT2", "IVWNCDT2", JdeDataType.String, 4),
        new JdeField("IVWNCDT3", "IVWNCDT3", JdeDataType.String, 4),
        new JdeField("IVWNCDT4", "IVWNCDT4", JdeDataType.String, 4),
        new JdeField("IVWNCDT5", "IVWNCDT5", JdeDataType.String, 4),
        new JdeField("IVWNCDT6", "IVWNCDT6", JdeDataType.String, 4),
        new JdeField("IVWSD", "IVWSD", JdeDataType.String, 60),
        new JdeField("IVITM", "IVITM", JdeDataType.Numeric),
        new JdeField("IVLITM", "IVLITM", JdeDataType.String, 50),
        new JdeField("IVAITM", "IVAITM", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B88_0", "Primary Key on IVUKID, IVMCU, IVWVTY, IVWVID, IVWLOTN", new[] { "IVUKID", "IVMCU", "IVWVTY", "IVWVID", "IVWLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
