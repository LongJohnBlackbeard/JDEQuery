using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB010 - .
/// </summary>
public class F90CB010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDLEADID.
        /// </summary>
        public const string LDLEADID = "LDLEADID";

        /// <summary>
        /// LDSRCHTY.
        /// </summary>
        public const string LDSRCHTY = "LDSRCHTY";

        /// <summary>
        /// LDFNAME.
        /// </summary>
        public const string LDFNAME = "LDFNAME";

        /// <summary>
        /// LDLNAME.
        /// </summary>
        public const string LDLNAME = "LDLNAME";

        /// <summary>
        /// LDCOMNY.
        /// </summary>
        public const string LDCOMNY = "LDCOMNY";

        /// <summary>
        /// LDMDNAM.
        /// </summary>
        public const string LDMDNAM = "LDMDNAM";

        /// <summary>
        /// LDCAAN8.
        /// </summary>
        public const string LDCAAN8 = "LDCAAN8";

        /// <summary>
        /// LDTLE.
        /// </summary>
        public const string LDTLE = "LDTLE";

        /// <summary>
        /// LDINDTRY.
        /// </summary>
        public const string LDINDTRY = "LDINDTRY";

        /// <summary>
        /// LDUURL.
        /// </summary>
        public const string LDUURL = "LDUURL";

        /// <summary>
        /// LDLDAR1.
        /// </summary>
        public const string LDLDAR1 = "LDLDAR1";

        /// <summary>
        /// LDLDPH1.
        /// </summary>
        public const string LDLDPH1 = "LDLDPH1";

        /// <summary>
        /// LDLDFAX.
        /// </summary>
        public const string LDLDFAX = "LDLDFAX";

        /// <summary>
        /// LDLDFAXN.
        /// </summary>
        public const string LDLDFAXN = "LDLDFAXN";

        /// <summary>
        /// LDEMAIL.
        /// </summary>
        public const string LDEMAIL = "LDEMAIL";

        /// <summary>
        /// LDSTAS.
        /// </summary>
        public const string LDSTAS = "LDSTAS";

        /// <summary>
        /// LDSTSDES.
        /// </summary>
        public const string LDSTSDES = "LDSTSDES";

        /// <summary>
        /// LDEVTID.
        /// </summary>
        public const string LDEVTID = "LDEVTID";

        /// <summary>
        /// LDEMAN8.
        /// </summary>
        public const string LDEMAN8 = "LDEMAN8";

        /// <summary>
        /// LDLEADSRC.
        /// </summary>
        public const string LDLEADSRC = "LDLEADSRC";

        /// <summary>
        /// LDQUFID.
        /// </summary>
        public const string LDQUFID = "LDQUFID";

        /// <summary>
        /// LDQUFSCR.
        /// </summary>
        public const string LDQUFSCR = "LDQUFSCR";

        /// <summary>
        /// LDDTREC.
        /// </summary>
        public const string LDDTREC = "LDDTREC";

        /// <summary>
        /// LDFUNSCD.
        /// </summary>
        public const string LDFUNSCD = "LDFUNSCD";

        /// <summary>
        /// LDCAMPID.
        /// </summary>
        public const string LDCAMPID = "LDCAMPID";

        /// <summary>
        /// LDPMADD.
        /// </summary>
        public const string LDPMADD = "LDPMADD";

        /// <summary>
        /// LDQUFGL.
        /// </summary>
        public const string LDQUFGL = "LDQUFGL";

        /// <summary>
        /// LDBILLTY.
        /// </summary>
        public const string LDBILLTY = "LDBILLTY";

        /// <summary>
        /// LDENTDBY.
        /// </summary>
        public const string LDENTDBY = "LDENTDBY";

        /// <summary>
        /// LDEDATE.
        /// </summary>
        public const string LDEDATE = "LDEDATE";

        /// <summary>
        /// LDCRMCT01.
        /// </summary>
        public const string LDCRMCT01 = "LDCRMCT01";

        /// <summary>
        /// LDCRMCT02.
        /// </summary>
        public const string LDCRMCT02 = "LDCRMCT02";

        /// <summary>
        /// LDCRMCT03.
        /// </summary>
        public const string LDCRMCT03 = "LDCRMCT03";

        /// <summary>
        /// LDCRMCT04.
        /// </summary>
        public const string LDCRMCT04 = "LDCRMCT04";

        /// <summary>
        /// LDCRMCT05.
        /// </summary>
        public const string LDCRMCT05 = "LDCRMCT05";

        /// <summary>
        /// LDCRMCT06.
        /// </summary>
        public const string LDCRMCT06 = "LDCRMCT06";

        /// <summary>
        /// LDCRMCT07.
        /// </summary>
        public const string LDCRMCT07 = "LDCRMCT07";

        /// <summary>
        /// LDCRMCT08.
        /// </summary>
        public const string LDCRMCT08 = "LDCRMCT08";

        /// <summary>
        /// LDCRMCT09.
        /// </summary>
        public const string LDCRMCT09 = "LDCRMCT09";

        /// <summary>
        /// LDCRMCT10.
        /// </summary>
        public const string LDCRMCT10 = "LDCRMCT10";

        /// <summary>
        /// LDCRMCT11.
        /// </summary>
        public const string LDCRMCT11 = "LDCRMCT11";

        /// <summary>
        /// LDCRMCT12.
        /// </summary>
        public const string LDCRMCT12 = "LDCRMCT12";

        /// <summary>
        /// LDCRMCT13.
        /// </summary>
        public const string LDCRMCT13 = "LDCRMCT13";

        /// <summary>
        /// LDCRMCT14.
        /// </summary>
        public const string LDCRMCT14 = "LDCRMCT14";

        /// <summary>
        /// LDCRMCT15.
        /// </summary>
        public const string LDCRMCT15 = "LDCRMCT15";

        /// <summary>
        /// LDCRMCT16.
        /// </summary>
        public const string LDCRMCT16 = "LDCRMCT16";

        /// <summary>
        /// LDCRMCT17.
        /// </summary>
        public const string LDCRMCT17 = "LDCRMCT17";

        /// <summary>
        /// LDCRMCT18.
        /// </summary>
        public const string LDCRMCT18 = "LDCRMCT18";

        /// <summary>
        /// LDCRMCT19.
        /// </summary>
        public const string LDCRMCT19 = "LDCRMCT19";

        /// <summary>
        /// LDCRMCT20.
        /// </summary>
        public const string LDCRMCT20 = "LDCRMCT20";

        /// <summary>
        /// LDCRMCT21.
        /// </summary>
        public const string LDCRMCT21 = "LDCRMCT21";

        /// <summary>
        /// LDCRMCT22.
        /// </summary>
        public const string LDCRMCT22 = "LDCRMCT22";

        /// <summary>
        /// LDCRMCT23.
        /// </summary>
        public const string LDCRMCT23 = "LDCRMCT23";

        /// <summary>
        /// LDCRMCT24.
        /// </summary>
        public const string LDCRMCT24 = "LDCRMCT24";

        /// <summary>
        /// LDCRMCT25.
        /// </summary>
        public const string LDCRMCT25 = "LDCRMCT25";

        /// <summary>
        /// LDCRMCT26.
        /// </summary>
        public const string LDCRMCT26 = "LDCRMCT26";

        /// <summary>
        /// LDCRMCT27.
        /// </summary>
        public const string LDCRMCT27 = "LDCRMCT27";

        /// <summary>
        /// LDCRMCT28.
        /// </summary>
        public const string LDCRMCT28 = "LDCRMCT28";

        /// <summary>
        /// LDCRMCT29.
        /// </summary>
        public const string LDCRMCT29 = "LDCRMCT29";

        /// <summary>
        /// LDCRMCT30.
        /// </summary>
        public const string LDCRMCT30 = "LDCRMCT30";

        /// <summary>
        /// LDEXVAR0.
        /// </summary>
        public const string LDEXVAR0 = "LDEXVAR0";

        /// <summary>
        /// LDEXVAR1.
        /// </summary>
        public const string LDEXVAR1 = "LDEXVAR1";

        /// <summary>
        /// LDEXVAR2.
        /// </summary>
        public const string LDEXVAR2 = "LDEXVAR2";

        /// <summary>
        /// LDEXVAR3.
        /// </summary>
        public const string LDEXVAR3 = "LDEXVAR3";

        /// <summary>
        /// LDEXVAR4.
        /// </summary>
        public const string LDEXVAR4 = "LDEXVAR4";

        /// <summary>
        /// LDEXVAR5.
        /// </summary>
        public const string LDEXVAR5 = "LDEXVAR5";

        /// <summary>
        /// LDEXVAR6.
        /// </summary>
        public const string LDEXVAR6 = "LDEXVAR6";

        /// <summary>
        /// LDEXVAR7.
        /// </summary>
        public const string LDEXVAR7 = "LDEXVAR7";

        /// <summary>
        /// LDEXVAR8.
        /// </summary>
        public const string LDEXVAR8 = "LDEXVAR8";

        /// <summary>
        /// LDEXVAR9.
        /// </summary>
        public const string LDEXVAR9 = "LDEXVAR9";

        /// <summary>
        /// LDEXVAR10.
        /// </summary>
        public const string LDEXVAR10 = "LDEXVAR10";

        /// <summary>
        /// LDEXVAR11.
        /// </summary>
        public const string LDEXVAR11 = "LDEXVAR11";

        /// <summary>
        /// LDEXVAR12.
        /// </summary>
        public const string LDEXVAR12 = "LDEXVAR12";

        /// <summary>
        /// LDEXVAR13.
        /// </summary>
        public const string LDEXVAR13 = "LDEXVAR13";

        /// <summary>
        /// LDEXVAR14.
        /// </summary>
        public const string LDEXVAR14 = "LDEXVAR14";

        /// <summary>
        /// LDEXNM0.
        /// </summary>
        public const string LDEXNM0 = "LDEXNM0";

        /// <summary>
        /// LDEXNM1.
        /// </summary>
        public const string LDEXNM1 = "LDEXNM1";

        /// <summary>
        /// LDEXNM2.
        /// </summary>
        public const string LDEXNM2 = "LDEXNM2";

        /// <summary>
        /// LDEXNM3.
        /// </summary>
        public const string LDEXNM3 = "LDEXNM3";

        /// <summary>
        /// LDEXNM4.
        /// </summary>
        public const string LDEXNM4 = "LDEXNM4";

        /// <summary>
        /// LDEXNMP0.
        /// </summary>
        public const string LDEXNMP0 = "LDEXNMP0";

        /// <summary>
        /// LDEXNMP1.
        /// </summary>
        public const string LDEXNMP1 = "LDEXNMP1";

        /// <summary>
        /// LDEXNMP2.
        /// </summary>
        public const string LDEXNMP2 = "LDEXNMP2";

        /// <summary>
        /// LDEXNMP3.
        /// </summary>
        public const string LDEXNMP3 = "LDEXNMP3";

        /// <summary>
        /// LDEXNMP4.
        /// </summary>
        public const string LDEXNMP4 = "LDEXNMP4";

        /// <summary>
        /// LDEXDT0.
        /// </summary>
        public const string LDEXDT0 = "LDEXDT0";

        /// <summary>
        /// LDEXDT1.
        /// </summary>
        public const string LDEXDT1 = "LDEXDT1";

        /// <summary>
        /// LDEXDT2.
        /// </summary>
        public const string LDEXDT2 = "LDEXDT2";

        /// <summary>
        /// LDEXDT3.
        /// </summary>
        public const string LDEXDT3 = "LDEXDT3";

        /// <summary>
        /// LDEXDT4.
        /// </summary>
        public const string LDEXDT4 = "LDEXDT4";

        /// <summary>
        /// LDSTSUDT.
        /// </summary>
        public const string LDSTSUDT = "LDSTSUDT";

        /// <summary>
        /// LDACTIND.
        /// </summary>
        public const string LDACTIND = "LDACTIND";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDVID.
        /// </summary>
        public const string LDVID = "LDVID";

        /// <summary>
        /// LDMKEY.
        /// </summary>
        public const string LDMKEY = "LDMKEY";

        /// <summary>
        /// LDUDTTM.
        /// </summary>
        public const string LDUDTTM = "LDUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDLEADID", "LDLEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDSRCHTY", "LDSRCHTY", JdeDataType.String, 20),
        new JdeField("LDFNAME", "LDFNAME", JdeDataType.String, 50),
        new JdeField("LDLNAME", "LDLNAME", JdeDataType.String, 50),
        new JdeField("LDCOMNY", "LDCOMNY", JdeDataType.String, 80),
        new JdeField("LDMDNAM", "LDMDNAM", JdeDataType.String, 60),
        new JdeField("LDCAAN8", "LDCAAN8", JdeDataType.Numeric),
        new JdeField("LDTLE", "LDTLE", JdeDataType.String, 100),
        new JdeField("LDINDTRY", "LDINDTRY", JdeDataType.String, 20),
        new JdeField("LDUURL", "LDUURL", JdeDataType.String, 150),
        new JdeField("LDLDAR1", "LDLDAR1", JdeDataType.String, 12),
        new JdeField("LDLDPH1", "LDLDPH1", JdeDataType.String, 40),
        new JdeField("LDLDFAX", "LDLDFAX", JdeDataType.String, 12),
        new JdeField("LDLDFAXN", "LDLDFAXN", JdeDataType.String, 40),
        new JdeField("LDEMAIL", "LDEMAIL", JdeDataType.String, 150),
        new JdeField("LDSTAS", "LDSTAS", JdeDataType.String, 10),
        new JdeField("LDSTSDES", "LDSTSDES", JdeDataType.String, 510),
        new JdeField("LDEVTID", "LDEVTID", JdeDataType.Numeric),
        new JdeField("LDEMAN8", "LDEMAN8", JdeDataType.Numeric),
        new JdeField("LDLEADSRC", "LDLEADSRC", JdeDataType.String, 6),
        new JdeField("LDQUFID", "LDQUFID", JdeDataType.Numeric),
        new JdeField("LDQUFSCR", "LDQUFSCR", JdeDataType.Numeric),
        new JdeField("LDDTREC", "LDDTREC", JdeDataType.Date),
        new JdeField("LDFUNSCD", "LDFUNSCD", JdeDataType.String, 20),
        new JdeField("LDCAMPID", "LDCAMPID", JdeDataType.Numeric),
        new JdeField("LDPMADD", "LDPMADD", JdeDataType.Numeric),
        new JdeField("LDQUFGL", "LDQUFGL", JdeDataType.Numeric),
        new JdeField("LDBILLTY", "LDBILLTY", JdeDataType.String, 20),
        new JdeField("LDENTDBY", "LDENTDBY", JdeDataType.Numeric),
        new JdeField("LDEDATE", "LDEDATE", JdeDataType.Date),
        new JdeField("LDCRMCT01", "LDCRMCT01", JdeDataType.String, 20),
        new JdeField("LDCRMCT02", "LDCRMCT02", JdeDataType.String, 20),
        new JdeField("LDCRMCT03", "LDCRMCT03", JdeDataType.String, 20),
        new JdeField("LDCRMCT04", "LDCRMCT04", JdeDataType.String, 20),
        new JdeField("LDCRMCT05", "LDCRMCT05", JdeDataType.String, 20),
        new JdeField("LDCRMCT06", "LDCRMCT06", JdeDataType.String, 20),
        new JdeField("LDCRMCT07", "LDCRMCT07", JdeDataType.String, 20),
        new JdeField("LDCRMCT08", "LDCRMCT08", JdeDataType.String, 20),
        new JdeField("LDCRMCT09", "LDCRMCT09", JdeDataType.String, 20),
        new JdeField("LDCRMCT10", "LDCRMCT10", JdeDataType.String, 20),
        new JdeField("LDCRMCT11", "LDCRMCT11", JdeDataType.String, 20),
        new JdeField("LDCRMCT12", "LDCRMCT12", JdeDataType.String, 20),
        new JdeField("LDCRMCT13", "LDCRMCT13", JdeDataType.String, 20),
        new JdeField("LDCRMCT14", "LDCRMCT14", JdeDataType.String, 20),
        new JdeField("LDCRMCT15", "LDCRMCT15", JdeDataType.String, 20),
        new JdeField("LDCRMCT16", "LDCRMCT16", JdeDataType.String, 20),
        new JdeField("LDCRMCT17", "LDCRMCT17", JdeDataType.String, 20),
        new JdeField("LDCRMCT18", "LDCRMCT18", JdeDataType.String, 20),
        new JdeField("LDCRMCT19", "LDCRMCT19", JdeDataType.String, 20),
        new JdeField("LDCRMCT20", "LDCRMCT20", JdeDataType.String, 20),
        new JdeField("LDCRMCT21", "LDCRMCT21", JdeDataType.String, 20),
        new JdeField("LDCRMCT22", "LDCRMCT22", JdeDataType.String, 20),
        new JdeField("LDCRMCT23", "LDCRMCT23", JdeDataType.String, 20),
        new JdeField("LDCRMCT24", "LDCRMCT24", JdeDataType.String, 20),
        new JdeField("LDCRMCT25", "LDCRMCT25", JdeDataType.String, 20),
        new JdeField("LDCRMCT26", "LDCRMCT26", JdeDataType.String, 20),
        new JdeField("LDCRMCT27", "LDCRMCT27", JdeDataType.String, 20),
        new JdeField("LDCRMCT28", "LDCRMCT28", JdeDataType.String, 20),
        new JdeField("LDCRMCT29", "LDCRMCT29", JdeDataType.String, 20),
        new JdeField("LDCRMCT30", "LDCRMCT30", JdeDataType.String, 20),
        new JdeField("LDEXVAR0", "LDEXVAR0", JdeDataType.String, 510),
        new JdeField("LDEXVAR1", "LDEXVAR1", JdeDataType.String, 510),
        new JdeField("LDEXVAR2", "LDEXVAR2", JdeDataType.String, 510),
        new JdeField("LDEXVAR3", "LDEXVAR3", JdeDataType.String, 510),
        new JdeField("LDEXVAR4", "LDEXVAR4", JdeDataType.String, 100),
        new JdeField("LDEXVAR5", "LDEXVAR5", JdeDataType.String, 100),
        new JdeField("LDEXVAR6", "LDEXVAR6", JdeDataType.String, 100),
        new JdeField("LDEXVAR7", "LDEXVAR7", JdeDataType.String, 100),
        new JdeField("LDEXVAR8", "LDEXVAR8", JdeDataType.String, 100),
        new JdeField("LDEXVAR9", "LDEXVAR9", JdeDataType.String, 100),
        new JdeField("LDEXVAR10", "LDEXVAR10", JdeDataType.String, 100),
        new JdeField("LDEXVAR11", "LDEXVAR11", JdeDataType.String, 100),
        new JdeField("LDEXVAR12", "LDEXVAR12", JdeDataType.String, 50),
        new JdeField("LDEXVAR13", "LDEXVAR13", JdeDataType.String, 50),
        new JdeField("LDEXVAR14", "LDEXVAR14", JdeDataType.String, 50),
        new JdeField("LDEXNM0", "LDEXNM0", JdeDataType.Numeric),
        new JdeField("LDEXNM1", "LDEXNM1", JdeDataType.Numeric),
        new JdeField("LDEXNM2", "LDEXNM2", JdeDataType.Numeric),
        new JdeField("LDEXNM3", "LDEXNM3", JdeDataType.Numeric),
        new JdeField("LDEXNM4", "LDEXNM4", JdeDataType.Numeric),
        new JdeField("LDEXNMP0", "LDEXNMP0", JdeDataType.Numeric),
        new JdeField("LDEXNMP1", "LDEXNMP1", JdeDataType.Numeric),
        new JdeField("LDEXNMP2", "LDEXNMP2", JdeDataType.Numeric),
        new JdeField("LDEXNMP3", "LDEXNMP3", JdeDataType.Numeric),
        new JdeField("LDEXNMP4", "LDEXNMP4", JdeDataType.Numeric),
        new JdeField("LDEXDT0", "LDEXDT0", JdeDataType.Date),
        new JdeField("LDEXDT1", "LDEXDT1", JdeDataType.Date),
        new JdeField("LDEXDT2", "LDEXDT2", JdeDataType.Date),
        new JdeField("LDEXDT3", "LDEXDT3", JdeDataType.Date),
        new JdeField("LDEXDT4", "LDEXDT4", JdeDataType.Date),
        new JdeField("LDSTSUDT", "LDSTSUDT", JdeDataType.Date),
        new JdeField("LDACTIND", "LDACTIND", JdeDataType.String, 2),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDVID", "LDVID", JdeDataType.String, 20),
        new JdeField("LDMKEY", "LDMKEY", JdeDataType.String, 30),
        new JdeField("LDUDTTM", "LDUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB010_0", "Primary Key on LDLEADID", new[] { "LDLEADID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB010_2", "Index on LDEMAN8, LDDTREC", new[] { "LDEMAN8", "LDDTREC" }),
        new JdeIndex("F90CB010_3", "Index on LDCOMNY", new[] { "LDCOMNY" })
    };
}
