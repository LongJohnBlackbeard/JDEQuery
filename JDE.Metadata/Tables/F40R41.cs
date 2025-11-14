using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R41 - .
/// </summary>
public class F40R41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIUKID.
        /// </summary>
        public const string DIUKID = "DIUKID";

        /// <summary>
        /// DIDEID.
        /// </summary>
        public const string DIDEID = "DIDEID";

        /// <summary>
        /// DICREATEDJ.
        /// </summary>
        public const string DICREATEDJ = "DICREATEDJ";

        /// <summary>
        /// DICREATETM.
        /// </summary>
        public const string DICREATETM = "DICREATETM";

        /// <summary>
        /// DIMCU.
        /// </summary>
        public const string DIMCU = "DIMCU";

        /// <summary>
        /// DIAN8.
        /// </summary>
        public const string DIAN8 = "DIAN8";

        /// <summary>
        /// DISHAN.
        /// </summary>
        public const string DISHAN = "DISHAN";

        /// <summary>
        /// DIDVAN.
        /// </summary>
        public const string DIDVAN = "DIDVAN";

        /// <summary>
        /// DISHPN.
        /// </summary>
        public const string DISHPN = "DISHPN";

        /// <summary>
        /// DIADDJ.
        /// </summary>
        public const string DIADDJ = "DIADDJ";

        /// <summary>
        /// DIADTM.
        /// </summary>
        public const string DIADTM = "DIADTM";

        /// <summary>
        /// DIITM.
        /// </summary>
        public const string DIITM = "DIITM";

        /// <summary>
        /// DIDETYP.
        /// </summary>
        public const string DIDETYP = "DIDETYP";

        /// <summary>
        /// DIDEPER.
        /// </summary>
        public const string DIDEPER = "DIDEPER";

        /// <summary>
        /// DICRTSOSTS.
        /// </summary>
        public const string DICRTSOSTS = "DICRTSOSTS";

        /// <summary>
        /// DIRLSNO.
        /// </summary>
        public const string DIRLSNO = "DIRLSNO";

        /// <summary>
        /// DIRLSDJ.
        /// </summary>
        public const string DIRLSDJ = "DIRLSDJ";

        /// <summary>
        /// DIRLSTM.
        /// </summary>
        public const string DIRLSTM = "DIRLSTM";

        /// <summary>
        /// DIRQSJ.
        /// </summary>
        public const string DIRQSJ = "DIRQSJ";

        /// <summary>
        /// DIERQSHPDJ.
        /// </summary>
        public const string DIERQSHPDJ = "DIERQSHPDJ";

        /// <summary>
        /// DIRSHT.
        /// </summary>
        public const string DIRSHT = "DIRSHT";

        /// <summary>
        /// DIRQSHPQTY.
        /// </summary>
        public const string DIRQSHPQTY = "DIRQSHPQTY";

        /// <summary>
        /// DIUOM.
        /// </summary>
        public const string DIUOM = "DIUOM";

        /// <summary>
        /// DIRSDJ.
        /// </summary>
        public const string DIRSDJ = "DIRSDJ";

        /// <summary>
        /// DIRSDT.
        /// </summary>
        public const string DIRSDT = "DIRSDT";

        /// <summary>
        /// DIHZED.
        /// </summary>
        public const string DIHZED = "DIHZED";

        /// <summary>
        /// DIHZSD.
        /// </summary>
        public const string DIHZSD = "DIHZSD";

        /// <summary>
        /// DIASBLNFD.
        /// </summary>
        public const string DIASBLNFD = "DIASBLNFD";

        /// <summary>
        /// DIASBLNLOC.
        /// </summary>
        public const string DIASBLNLOC = "DIASBLNLOC";

        /// <summary>
        /// DIASBNO.
        /// </summary>
        public const string DIASBNO = "DIASBNO";

        /// <summary>
        /// DIDMDBTHNO.
        /// </summary>
        public const string DIDMDBTHNO = "DIDMDBTHNO";

        /// <summary>
        /// DICSGSHPNO.
        /// </summary>
        public const string DICSGSHPNO = "DICSGSHPNO";

        /// <summary>
        /// DIGCNT.
        /// </summary>
        public const string DIGCNT = "DIGCNT";

        /// <summary>
        /// DICUMID.
        /// </summary>
        public const string DICUMID = "DICUMID";

        /// <summary>
        /// DITXTREFNO.
        /// </summary>
        public const string DITXTREFNO = "DITXTREFNO";

        /// <summary>
        /// DIREQFRQ.
        /// </summary>
        public const string DIREQFRQ = "DIREQFRQ";

        /// <summary>
        /// DICSTDMDPT.
        /// </summary>
        public const string DICSTDMDPT = "DICSTDMDPT";

        /// <summary>
        /// DIREQTYP.
        /// </summary>
        public const string DIREQTYP = "DIREQTYP";

        /// <summary>
        /// DICSTORDNO.
        /// </summary>
        public const string DICSTORDNO = "DICSTORDNO";

        /// <summary>
        /// DIDKID.
        /// </summary>
        public const string DIDKID = "DIDKID";

        /// <summary>
        /// DIENDJOBSQ.
        /// </summary>
        public const string DIENDJOBSQ = "DIENDJOBSQ";

        /// <summary>
        /// DIPSJOBNO.
        /// </summary>
        public const string DIPSJOBNO = "DIPSJOBNO";

        /// <summary>
        /// DIHZCLSNO.
        /// </summary>
        public const string DIHZCLSNO = "DIHZCLSNO";

        /// <summary>
        /// DIJOBSQ.
        /// </summary>
        public const string DIJOBSQ = "DIJOBSQ";

        /// <summary>
        /// DIKBSNO.
        /// </summary>
        public const string DIKBSNO = "DIKBSNO";

        /// <summary>
        /// DIKBENO.
        /// </summary>
        public const string DIKBENO = "DIKBENO";

        /// <summary>
        /// DILABORHR.
        /// </summary>
        public const string DILABORHR = "DILABORHR";

        /// <summary>
        /// DICIRV.
        /// </summary>
        public const string DICIRV = "DICIRV";

        /// <summary>
        /// DIYEAR1.
        /// </summary>
        public const string DIYEAR1 = "DIYEAR1";

        /// <summary>
        /// DIPTRLSSTS.
        /// </summary>
        public const string DIPTRLSSTS = "DIPTRLSSTS";

        /// <summary>
        /// DICSTPODJ.
        /// </summary>
        public const string DICSTPODJ = "DICSTPODJ";

        /// <summary>
        /// DICSTPOTM.
        /// </summary>
        public const string DICSTPOTM = "DICSTPOTM";

        /// <summary>
        /// DICSTPOLIN.
        /// </summary>
        public const string DICSTPOLIN = "DICSTPOLIN";

        /// <summary>
        /// DICSTPO.
        /// </summary>
        public const string DICSTPO = "DICSTPO";

        /// <summary>
        /// DITPUR.
        /// </summary>
        public const string DITPUR = "DITPUR";

        /// <summary>
        /// DIQTYBYPOS.
        /// </summary>
        public const string DIQTYBYPOS = "DIQTYBYPOS";

        /// <summary>
        /// DISOCN.
        /// </summary>
        public const string DISOCN = "DISOCN";

        /// <summary>
        /// DIPSIG.
        /// </summary>
        public const string DIPSIG = "DIPSIG";

        /// <summary>
        /// DIRSVLNFD.
        /// </summary>
        public const string DIRSVLNFD = "DIRSVLNFD";

        /// <summary>
        /// DISTSSQIND.
        /// </summary>
        public const string DISTSSQIND = "DISTSSQIND";

        /// <summary>
        /// DIEDTCTDJ.
        /// </summary>
        public const string DIEDTCTDJ = "DIEDTCTDJ";

        /// <summary>
        /// DIEDTCTTM.
        /// </summary>
        public const string DIEDTCTTM = "DIEDTCTTM";

        /// <summary>
        /// DIOGDMDQTY.
        /// </summary>
        public const string DIOGDMDQTY = "DIOGDMDQTY";

        /// <summary>
        /// DIEDTMSGNM.
        /// </summary>
        public const string DIEDTMSGNM = "DIEDTMSGNM";

        /// <summary>
        /// DIEDTMSGSB.
        /// </summary>
        public const string DIEDTMSGSB = "DIEDTMSGSB";

        /// <summary>
        /// DIEDTMSGTP.
        /// </summary>
        public const string DIEDTMSGTP = "DIEDTMSGTP";

        /// <summary>
        /// DITRSRTE.
        /// </summary>
        public const string DITRSRTE = "DITRSRTE";

        /// <summary>
        /// DITRSRTSFX.
        /// </summary>
        public const string DITRSRTSFX = "DITRSRTSFX";

        /// <summary>
        /// DIUCARTNO.
        /// </summary>
        public const string DIUCARTNO = "DIUCARTNO";

        /// <summary>
        /// DIVINNO.
        /// </summary>
        public const string DIVINNO = "DIVINNO";

        /// <summary>
        /// DIPENDDLT.
        /// </summary>
        public const string DIPENDDLT = "DIPENDDLT";

        /// <summary>
        /// DISDID.
        /// </summary>
        public const string DISDID = "DISDID";

        /// <summary>
        /// DINETVC.
        /// </summary>
        public const string DINETVC = "DINETVC";

        /// <summary>
        /// DINETVCNTF.
        /// </summary>
        public const string DINETVCNTF = "DINETVCNTF";

        /// <summary>
        /// DICRTCLID.
        /// </summary>
        public const string DICRTCLID = "DICRTCLID";

        /// <summary>
        /// DISOQS.
        /// </summary>
        public const string DISOQS = "DISOQS";

        /// <summary>
        /// DIDMD06.
        /// </summary>
        public const string DIDMD06 = "DIDMD06";

        /// <summary>
        /// DIDMD07.
        /// </summary>
        public const string DIDMD07 = "DIDMD07";

        /// <summary>
        /// DIDMD08.
        /// </summary>
        public const string DIDMD08 = "DIDMD08";

        /// <summary>
        /// DIDMD09.
        /// </summary>
        public const string DIDMD09 = "DIDMD09";

        /// <summary>
        /// DIDMD10.
        /// </summary>
        public const string DIDMD10 = "DIDMD10";

        /// <summary>
        /// DIDMDREF1.
        /// </summary>
        public const string DIDMDREF1 = "DIDMDREF1";

        /// <summary>
        /// DIDMDREF2.
        /// </summary>
        public const string DIDMDREF2 = "DIDMDREF2";

        /// <summary>
        /// DICTLNUM.
        /// </summary>
        public const string DICTLNUM = "DICTLNUM";

        /// <summary>
        /// DIURCD.
        /// </summary>
        public const string DIURCD = "DIURCD";

        /// <summary>
        /// DIURDT.
        /// </summary>
        public const string DIURDT = "DIURDT";

        /// <summary>
        /// DIURAT.
        /// </summary>
        public const string DIURAT = "DIURAT";

        /// <summary>
        /// DIURAB.
        /// </summary>
        public const string DIURAB = "DIURAB";

        /// <summary>
        /// DIURRF.
        /// </summary>
        public const string DIURRF = "DIURRF";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DITDAY.
        /// </summary>
        public const string DITDAY = "DITDAY";

        /// <summary>
        /// DICARDNO.
        /// </summary>
        public const string DICARDNO = "DICARDNO";

        /// <summary>
        /// DIDELBATCH.
        /// </summary>
        public const string DIDELBATCH = "DIDELBATCH";

        /// <summary>
        /// DICIRVQ.
        /// </summary>
        public const string DICIRVQ = "DICIRVQ";

        /// <summary>
        /// DIPRODTYPE.
        /// </summary>
        public const string DIPRODTYPE = "DIPRODTYPE";

        /// <summary>
        /// DIRTORSQ.
        /// </summary>
        public const string DIRTORSQ = "DIRTORSQ";

        /// <summary>
        /// DIRTGDAT.
        /// </summary>
        public const string DIRTGDAT = "DIRTGDAT";

        /// <summary>
        /// DIRTGTIM.
        /// </summary>
        public const string DIRTGTIM = "DIRTGTIM";

        /// <summary>
        /// DIDMDREF3.
        /// </summary>
        public const string DIDMDREF3 = "DIDMDREF3";

        /// <summary>
        /// DIDMDREF4.
        /// </summary>
        public const string DIDMDREF4 = "DIDMDREF4";

        /// <summary>
        /// DIDMDREF5.
        /// </summary>
        public const string DIDMDREF5 = "DIDMDREF5";

        /// <summary>
        /// DIDMDREF6.
        /// </summary>
        public const string DIDMDREF6 = "DIDMDREF6";

        /// <summary>
        /// DIDMDREF7.
        /// </summary>
        public const string DIDMDREF7 = "DIDMDREF7";

        /// <summary>
        /// DIDMDREF8.
        /// </summary>
        public const string DIDMDREF8 = "DIDMDREF8";

        /// <summary>
        /// DIDMDREF9.
        /// </summary>
        public const string DIDMDREF9 = "DIDMDREF9";

        /// <summary>
        /// DIDMDREF10.
        /// </summary>
        public const string DIDMDREF10 = "DIDMDREF10";

        /// <summary>
        /// DISCAC.
        /// </summary>
        public const string DISCAC = "DISCAC";

        /// <summary>
        /// DIATMCN.
        /// </summary>
        public const string DIATMCN = "DIATMCN";

        /// <summary>
        /// DIOFFLNDT.
        /// </summary>
        public const string DIOFFLNDT = "DIOFFLNDT";

        /// <summary>
        /// DIENGTAG1.
        /// </summary>
        public const string DIENGTAG1 = "DIENGTAG1";

        /// <summary>
        /// DIENGTAGR1.
        /// </summary>
        public const string DIENGTAGR1 = "DIENGTAGR1";

        /// <summary>
        /// DIENGTAG2.
        /// </summary>
        public const string DIENGTAG2 = "DIENGTAG2";

        /// <summary>
        /// DIENGTAGR2.
        /// </summary>
        public const string DIENGTAGR2 = "DIENGTAGR2";
    }

    /// <inheritdoc />
    public override string TableName => "F40R41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIUKID", "DIUKID", JdeDataType.Numeric),
        new JdeField("DIDEID", "DIDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DICREATEDJ", "DICREATEDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DICREATETM", "DICREATETM", JdeDataType.Numeric, null, true, true),
        new JdeField("DIMCU", "DIMCU", JdeDataType.String, 24),
        new JdeField("DIAN8", "DIAN8", JdeDataType.Numeric),
        new JdeField("DISHAN", "DISHAN", JdeDataType.Numeric),
        new JdeField("DIDVAN", "DIDVAN", JdeDataType.Numeric),
        new JdeField("DISHPN", "DISHPN", JdeDataType.Numeric),
        new JdeField("DIADDJ", "DIADDJ", JdeDataType.Numeric),
        new JdeField("DIADTM", "DIADTM", JdeDataType.Numeric),
        new JdeField("DIITM", "DIITM", JdeDataType.Numeric),
        new JdeField("DIDETYP", "DIDETYP", JdeDataType.String, 4),
        new JdeField("DIDEPER", "DIDEPER", JdeDataType.String, 4),
        new JdeField("DICRTSOSTS", "DICRTSOSTS", JdeDataType.String, 2),
        new JdeField("DIRLSNO", "DIRLSNO", JdeDataType.String, 20),
        new JdeField("DIRLSDJ", "DIRLSDJ", JdeDataType.Numeric),
        new JdeField("DIRLSTM", "DIRLSTM", JdeDataType.Numeric),
        new JdeField("DIRQSJ", "DIRQSJ", JdeDataType.Numeric),
        new JdeField("DIERQSHPDJ", "DIERQSHPDJ", JdeDataType.Numeric),
        new JdeField("DIRSHT", "DIRSHT", JdeDataType.Numeric),
        new JdeField("DIRQSHPQTY", "DIRQSHPQTY", JdeDataType.Numeric),
        new JdeField("DIUOM", "DIUOM", JdeDataType.String, 4),
        new JdeField("DIRSDJ", "DIRSDJ", JdeDataType.Numeric),
        new JdeField("DIRSDT", "DIRSDT", JdeDataType.Numeric),
        new JdeField("DIHZED", "DIHZED", JdeDataType.Numeric),
        new JdeField("DIHZSD", "DIHZSD", JdeDataType.Numeric),
        new JdeField("DIASBLNFD", "DIASBLNFD", JdeDataType.String, 20),
        new JdeField("DIASBLNLOC", "DIASBLNLOC", JdeDataType.String, 12),
        new JdeField("DIASBNO", "DIASBNO", JdeDataType.String, 30),
        new JdeField("DIDMDBTHNO", "DIDMDBTHNO", JdeDataType.Numeric),
        new JdeField("DICSGSHPNO", "DICSGSHPNO", JdeDataType.String, 70),
        new JdeField("DIGCNT", "DIGCNT", JdeDataType.String, 24),
        new JdeField("DICUMID", "DICUMID", JdeDataType.Numeric),
        new JdeField("DITXTREFNO", "DITXTREFNO", JdeDataType.String, 30),
        new JdeField("DIREQFRQ", "DIREQFRQ", JdeDataType.String, 6),
        new JdeField("DICSTDMDPT", "DICSTDMDPT", JdeDataType.String, 6),
        new JdeField("DIREQTYP", "DIREQTYP", JdeDataType.String, 6),
        new JdeField("DICSTORDNO", "DICSTORDNO", JdeDataType.String, 30),
        new JdeField("DIDKID", "DIDKID", JdeDataType.String, 40),
        new JdeField("DIENDJOBSQ", "DIENDJOBSQ", JdeDataType.String, 30),
        new JdeField("DIPSJOBNO", "DIPSJOBNO", JdeDataType.String, 30),
        new JdeField("DIHZCLSNO", "DIHZCLSNO", JdeDataType.String, 30),
        new JdeField("DIJOBSQ", "DIJOBSQ", JdeDataType.String, 30),
        new JdeField("DIKBSNO", "DIKBSNO", JdeDataType.String, 30),
        new JdeField("DIKBENO", "DIKBENO", JdeDataType.String, 30),
        new JdeField("DILABORHR", "DILABORHR", JdeDataType.Numeric),
        new JdeField("DICIRV", "DICIRV", JdeDataType.String, 40),
        new JdeField("DIYEAR1", "DIYEAR1", JdeDataType.Numeric),
        new JdeField("DIPTRLSSTS", "DIPTRLSSTS", JdeDataType.String, 4),
        new JdeField("DICSTPODJ", "DICSTPODJ", JdeDataType.Numeric),
        new JdeField("DICSTPOTM", "DICSTPOTM", JdeDataType.Numeric),
        new JdeField("DICSTPOLIN", "DICSTPOLIN", JdeDataType.String, 10),
        new JdeField("DICSTPO", "DICSTPO", JdeDataType.String, 60),
        new JdeField("DITPUR", "DITPUR", JdeDataType.String, 4),
        new JdeField("DIQTYBYPOS", "DIQTYBYPOS", JdeDataType.Numeric),
        new JdeField("DISOCN", "DISOCN", JdeDataType.Numeric),
        new JdeField("DIPSIG", "DIPSIG", JdeDataType.String, 60),
        new JdeField("DIRSVLNFD", "DIRSVLNFD", JdeDataType.String, 20),
        new JdeField("DISTSSQIND", "DISTSSQIND", JdeDataType.String, 6),
        new JdeField("DIEDTCTDJ", "DIEDTCTDJ", JdeDataType.Numeric),
        new JdeField("DIEDTCTTM", "DIEDTCTTM", JdeDataType.Numeric),
        new JdeField("DIOGDMDQTY", "DIOGDMDQTY", JdeDataType.Numeric),
        new JdeField("DIEDTMSGNM", "DIEDTMSGNM", JdeDataType.String, 20),
        new JdeField("DIEDTMSGSB", "DIEDTMSGSB", JdeDataType.String, 6),
        new JdeField("DIEDTMSGTP", "DIEDTMSGTP", JdeDataType.String, 6),
        new JdeField("DITRSRTE", "DITRSRTE", JdeDataType.String, 30),
        new JdeField("DITRSRTSFX", "DITRSRTSFX", JdeDataType.String, 30),
        new JdeField("DIUCARTNO", "DIUCARTNO", JdeDataType.String, 30),
        new JdeField("DIVINNO", "DIVINNO", JdeDataType.String, 40),
        new JdeField("DIPENDDLT", "DIPENDDLT", JdeDataType.String, 2),
        new JdeField("DISDID", "DISDID", JdeDataType.Numeric),
        new JdeField("DINETVC", "DINETVC", JdeDataType.Numeric),
        new JdeField("DINETVCNTF", "DINETVCNTF", JdeDataType.String, 2),
        new JdeField("DICRTCLID", "DICRTCLID", JdeDataType.String, 4),
        new JdeField("DISOQS", "DISOQS", JdeDataType.Numeric),
        new JdeField("DIDMD06", "DIDMD06", JdeDataType.String, 6),
        new JdeField("DIDMD07", "DIDMD07", JdeDataType.String, 6),
        new JdeField("DIDMD08", "DIDMD08", JdeDataType.String, 6),
        new JdeField("DIDMD09", "DIDMD09", JdeDataType.String, 6),
        new JdeField("DIDMD10", "DIDMD10", JdeDataType.String, 6),
        new JdeField("DIDMDREF1", "DIDMDREF1", JdeDataType.String, 70),
        new JdeField("DIDMDREF2", "DIDMDREF2", JdeDataType.String, 70),
        new JdeField("DICTLNUM", "DICTLNUM", JdeDataType.String, 70),
        new JdeField("DIURCD", "DIURCD", JdeDataType.String, 4),
        new JdeField("DIURDT", "DIURDT", JdeDataType.Numeric),
        new JdeField("DIURAT", "DIURAT", JdeDataType.Numeric),
        new JdeField("DIURAB", "DIURAB", JdeDataType.Numeric),
        new JdeField("DIURRF", "DIURRF", JdeDataType.String, 30),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DITDAY", "DITDAY", JdeDataType.Numeric),
        new JdeField("DICARDNO", "DICARDNO", JdeDataType.String, 8),
        new JdeField("DIDELBATCH", "DIDELBATCH", JdeDataType.String, 12),
        new JdeField("DICIRVQ", "DICIRVQ", JdeDataType.String, 4),
        new JdeField("DIPRODTYPE", "DIPRODTYPE", JdeDataType.String, 60),
        new JdeField("DIRTORSQ", "DIRTORSQ", JdeDataType.String, 60),
        new JdeField("DIRTGDAT", "DIRTGDAT", JdeDataType.Numeric),
        new JdeField("DIRTGTIM", "DIRTGTIM", JdeDataType.Numeric),
        new JdeField("DIDMDREF3", "DIDMDREF3", JdeDataType.String, 70),
        new JdeField("DIDMDREF4", "DIDMDREF4", JdeDataType.String, 70),
        new JdeField("DIDMDREF5", "DIDMDREF5", JdeDataType.String, 70),
        new JdeField("DIDMDREF6", "DIDMDREF6", JdeDataType.String, 70),
        new JdeField("DIDMDREF7", "DIDMDREF7", JdeDataType.String, 70),
        new JdeField("DIDMDREF8", "DIDMDREF8", JdeDataType.String, 70),
        new JdeField("DIDMDREF9", "DIDMDREF9", JdeDataType.String, 70),
        new JdeField("DIDMDREF10", "DIDMDREF10", JdeDataType.String, 70),
        new JdeField("DISCAC", "DISCAC", JdeDataType.String, 8),
        new JdeField("DIATMCN", "DIATMCN", JdeDataType.Numeric),
        new JdeField("DIOFFLNDT", "DIOFFLNDT", JdeDataType.Numeric),
        new JdeField("DIENGTAG1", "DIENGTAG1", JdeDataType.String, 30),
        new JdeField("DIENGTAGR1", "DIENGTAGR1", JdeDataType.String, 4),
        new JdeField("DIENGTAG2", "DIENGTAG2", JdeDataType.String, 30),
        new JdeField("DIENGTAGR2", "DIENGTAGR2", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R41_0", "Primary Key on DIDEID, DICREATEDJ, DICREATETM", new[] { "DIDEID", "DICREATEDJ", "DICREATETM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R41_2", "Index on DIMCU, DIAN8, DISHAN, DIITM, DIRLSDJ, DIRLSTM", new[] { "DIMCU", "DIAN8", "DISHAN", "DIITM", "DIRLSDJ", "DIRLSTM" }),
        new JdeIndex("F40R41_3", "Index on DIMCU, DIAN8, DISHAN, DIITM, DIEDTCTDJ, DIEDTCTTM", new[] { "DIMCU", "DIAN8", "DISHAN", "DIITM", "DIEDTCTDJ", "DIEDTCTTM" }),
        new JdeIndex("F40R41_4", "Index on DIMCU, DIAN8, DISHAN, DIITM, DIRSDJ, DIRSDT", new[] { "DIMCU", "DIAN8", "DISHAN", "DIITM", "DIRSDJ", "DIRSDT" }),
        new JdeIndex("F40R41_5", "Index on DIMCU, DIAN8, DISHAN, DIITM, DIRQSJ, DIRSHT", new[] { "DIMCU", "DIAN8", "DISHAN", "DIITM", "DIRQSJ", "DIRSHT" }),
        new JdeIndex("F40R41_6", "Index on DIMCU, DIAN8, DISHAN, DIITM, DICREATEDJ, DICREATETM", new[] { "DIMCU", "DIAN8", "DISHAN", "DIITM", "DICREATEDJ", "DICREATETM" }),
        new JdeIndex("F40R41_7", "Index on DIDEID, DISHPN, SYS_NC00117$, SYS_NC00118$", new[] { "DIDEID", "DISHPN", "SYS_NC00117$", "SYS_NC00118$" }),
        new JdeIndex("F40R41_8", "Index on DIUKID, SYS_NC00117$, SYS_NC00118$", new[] { "DIUKID", "SYS_NC00117$", "SYS_NC00118$" })
    };
}
