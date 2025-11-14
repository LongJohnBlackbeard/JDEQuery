using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB020 - .
/// </summary>
public class F90CB020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTOPPID.
        /// </summary>
        public const string OTOPPID = "OTOPPID";

        /// <summary>
        /// OTDSCRP1.
        /// </summary>
        public const string OTDSCRP1 = "OTDSCRP1";

        /// <summary>
        /// OTOPTYCD.
        /// </summary>
        public const string OTOPTYCD = "OTOPTYCD";

        /// <summary>
        /// OTCAMPID.
        /// </summary>
        public const string OTCAMPID = "OTCAMPID";

        /// <summary>
        /// OTEVTID.
        /// </summary>
        public const string OTEVTID = "OTEVTID";

        /// <summary>
        /// OTPRAN8.
        /// </summary>
        public const string OTPRAN8 = "OTPRAN8";

        /// <summary>
        /// OTPRCIDLN.
        /// </summary>
        public const string OTPRCIDLN = "OTPRCIDLN";

        /// <summary>
        /// OTCUAN8.
        /// </summary>
        public const string OTCUAN8 = "OTCUAN8";

        /// <summary>
        /// OTCCIDLN.
        /// </summary>
        public const string OTCCIDLN = "OTCCIDLN";

        /// <summary>
        /// OTCUSAN8.
        /// </summary>
        public const string OTCUSAN8 = "OTCUSAN8";

        /// <summary>
        /// OTSHCCIDLN.
        /// </summary>
        public const string OTSHCCIDLN = "OTSHCCIDLN";

        /// <summary>
        /// OTLTAN8.
        /// </summary>
        public const string OTLTAN8 = "OTLTAN8";

        /// <summary>
        /// OTQUFID.
        /// </summary>
        public const string OTQUFID = "OTQUFID";

        /// <summary>
        /// OTQUFSCR.
        /// </summary>
        public const string OTQUFSCR = "OTQUFSCR";

        /// <summary>
        /// OTQUFGL.
        /// </summary>
        public const string OTQUFGL = "OTQUFGL";

        /// <summary>
        /// OTSMEID.
        /// </summary>
        public const string OTSMEID = "OTSMEID";

        /// <summary>
        /// OTSLCYID.
        /// </summary>
        public const string OTSLCYID = "OTSLCYID";

        /// <summary>
        /// OTPBLTY.
        /// </summary>
        public const string OTPBLTY = "OTPBLTY";

        /// <summary>
        /// OTPBLTYQ.
        /// </summary>
        public const string OTPBLTYQ = "OTPBLTYQ";

        /// <summary>
        /// OTCLDATE.
        /// </summary>
        public const string OTCLDATE = "OTCLDATE";

        /// <summary>
        /// OTBDAMT.
        /// </summary>
        public const string OTBDAMT = "OTBDAMT";

        /// <summary>
        /// OTPTAMT.
        /// </summary>
        public const string OTPTAMT = "OTPTAMT";

        /// <summary>
        /// OTCRCD.
        /// </summary>
        public const string OTCRCD = "OTCRCD";

        /// <summary>
        /// OTLRTXT.
        /// </summary>
        public const string OTLRTXT = "OTLRTXT";

        /// <summary>
        /// OTSTSCD.
        /// </summary>
        public const string OTSTSCD = "OTSTSCD";

        /// <summary>
        /// OTOPMCU.
        /// </summary>
        public const string OTOPMCU = "OTOPMCU";

        /// <summary>
        /// OTLITOT.
        /// </summary>
        public const string OTLITOT = "OTLITOT";

        /// <summary>
        /// OTLOBCO.
        /// </summary>
        public const string OTLOBCO = "OTLOBCO";

        /// <summary>
        /// OTLEADSRC.
        /// </summary>
        public const string OTLEADSRC = "OTLEADSRC";

        /// <summary>
        /// OTENTDBY.
        /// </summary>
        public const string OTENTDBY = "OTENTDBY";

        /// <summary>
        /// OTEDATE.
        /// </summary>
        public const string OTEDATE = "OTEDATE";

        /// <summary>
        /// OTEXVAR0.
        /// </summary>
        public const string OTEXVAR0 = "OTEXVAR0";

        /// <summary>
        /// OTEXVAR1.
        /// </summary>
        public const string OTEXVAR1 = "OTEXVAR1";

        /// <summary>
        /// OTEXVAR2.
        /// </summary>
        public const string OTEXVAR2 = "OTEXVAR2";

        /// <summary>
        /// OTEXVAR3.
        /// </summary>
        public const string OTEXVAR3 = "OTEXVAR3";

        /// <summary>
        /// OTEXVAR4.
        /// </summary>
        public const string OTEXVAR4 = "OTEXVAR4";

        /// <summary>
        /// OTEXVAR5.
        /// </summary>
        public const string OTEXVAR5 = "OTEXVAR5";

        /// <summary>
        /// OTEXVAR6.
        /// </summary>
        public const string OTEXVAR6 = "OTEXVAR6";

        /// <summary>
        /// OTEXVAR7.
        /// </summary>
        public const string OTEXVAR7 = "OTEXVAR7";

        /// <summary>
        /// OTEXVAR8.
        /// </summary>
        public const string OTEXVAR8 = "OTEXVAR8";

        /// <summary>
        /// OTEXVAR9.
        /// </summary>
        public const string OTEXVAR9 = "OTEXVAR9";

        /// <summary>
        /// OTEXVAR10.
        /// </summary>
        public const string OTEXVAR10 = "OTEXVAR10";

        /// <summary>
        /// OTEXVAR11.
        /// </summary>
        public const string OTEXVAR11 = "OTEXVAR11";

        /// <summary>
        /// OTEXVAR12.
        /// </summary>
        public const string OTEXVAR12 = "OTEXVAR12";

        /// <summary>
        /// OTEXVAR13.
        /// </summary>
        public const string OTEXVAR13 = "OTEXVAR13";

        /// <summary>
        /// OTEXVAR14.
        /// </summary>
        public const string OTEXVAR14 = "OTEXVAR14";

        /// <summary>
        /// OTEXNM0.
        /// </summary>
        public const string OTEXNM0 = "OTEXNM0";

        /// <summary>
        /// OTEXNM1.
        /// </summary>
        public const string OTEXNM1 = "OTEXNM1";

        /// <summary>
        /// OTEXNM2.
        /// </summary>
        public const string OTEXNM2 = "OTEXNM2";

        /// <summary>
        /// OTEXNM3.
        /// </summary>
        public const string OTEXNM3 = "OTEXNM3";

        /// <summary>
        /// OTEXNM4.
        /// </summary>
        public const string OTEXNM4 = "OTEXNM4";

        /// <summary>
        /// OTEXNMP0.
        /// </summary>
        public const string OTEXNMP0 = "OTEXNMP0";

        /// <summary>
        /// OTEXNMP1.
        /// </summary>
        public const string OTEXNMP1 = "OTEXNMP1";

        /// <summary>
        /// OTEXNMP2.
        /// </summary>
        public const string OTEXNMP2 = "OTEXNMP2";

        /// <summary>
        /// OTEXNMP3.
        /// </summary>
        public const string OTEXNMP3 = "OTEXNMP3";

        /// <summary>
        /// OTEXNMP4.
        /// </summary>
        public const string OTEXNMP4 = "OTEXNMP4";

        /// <summary>
        /// OTEXDT0.
        /// </summary>
        public const string OTEXDT0 = "OTEXDT0";

        /// <summary>
        /// OTEXDT1.
        /// </summary>
        public const string OTEXDT1 = "OTEXDT1";

        /// <summary>
        /// OTEXDT2.
        /// </summary>
        public const string OTEXDT2 = "OTEXDT2";

        /// <summary>
        /// OTEXDT3.
        /// </summary>
        public const string OTEXDT3 = "OTEXDT3";

        /// <summary>
        /// OTEXDT4.
        /// </summary>
        public const string OTEXDT4 = "OTEXDT4";

        /// <summary>
        /// OTSTSUDT.
        /// </summary>
        public const string OTSTSUDT = "OTSTSUDT";

        /// <summary>
        /// OTACTIND.
        /// </summary>
        public const string OTACTIND = "OTACTIND";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTVID.
        /// </summary>
        public const string OTVID = "OTVID";

        /// <summary>
        /// OTMKEY.
        /// </summary>
        public const string OTMKEY = "OTMKEY";

        /// <summary>
        /// OTUDTTM.
        /// </summary>
        public const string OTUDTTM = "OTUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTOPPID", "OTOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTDSCRP1", "OTDSCRP1", JdeDataType.String, 100),
        new JdeField("OTOPTYCD", "OTOPTYCD", JdeDataType.String, 10),
        new JdeField("OTCAMPID", "OTCAMPID", JdeDataType.Numeric),
        new JdeField("OTEVTID", "OTEVTID", JdeDataType.Numeric),
        new JdeField("OTPRAN8", "OTPRAN8", JdeDataType.Numeric),
        new JdeField("OTPRCIDLN", "OTPRCIDLN", JdeDataType.Numeric),
        new JdeField("OTCUAN8", "OTCUAN8", JdeDataType.Numeric),
        new JdeField("OTCCIDLN", "OTCCIDLN", JdeDataType.Numeric),
        new JdeField("OTCUSAN8", "OTCUSAN8", JdeDataType.Numeric),
        new JdeField("OTSHCCIDLN", "OTSHCCIDLN", JdeDataType.Numeric),
        new JdeField("OTLTAN8", "OTLTAN8", JdeDataType.Numeric),
        new JdeField("OTQUFID", "OTQUFID", JdeDataType.Numeric),
        new JdeField("OTQUFSCR", "OTQUFSCR", JdeDataType.Numeric),
        new JdeField("OTQUFGL", "OTQUFGL", JdeDataType.Numeric),
        new JdeField("OTSMEID", "OTSMEID", JdeDataType.Numeric),
        new JdeField("OTSLCYID", "OTSLCYID", JdeDataType.Numeric),
        new JdeField("OTPBLTY", "OTPBLTY", JdeDataType.Numeric),
        new JdeField("OTPBLTYQ", "OTPBLTYQ", JdeDataType.Numeric),
        new JdeField("OTCLDATE", "OTCLDATE", JdeDataType.Date),
        new JdeField("OTBDAMT", "OTBDAMT", JdeDataType.Numeric),
        new JdeField("OTPTAMT", "OTPTAMT", JdeDataType.Numeric),
        new JdeField("OTCRCD", "OTCRCD", JdeDataType.String, 6),
        new JdeField("OTLRTXT", "OTLRTXT", JdeDataType.String, 200),
        new JdeField("OTSTSCD", "OTSTSCD", JdeDataType.String, 10),
        new JdeField("OTOPMCU", "OTOPMCU", JdeDataType.String, 24),
        new JdeField("OTLITOT", "OTLITOT", JdeDataType.Numeric),
        new JdeField("OTLOBCO", "OTLOBCO", JdeDataType.String, 10),
        new JdeField("OTLEADSRC", "OTLEADSRC", JdeDataType.String, 6),
        new JdeField("OTENTDBY", "OTENTDBY", JdeDataType.Numeric),
        new JdeField("OTEDATE", "OTEDATE", JdeDataType.Date),
        new JdeField("OTEXVAR0", "OTEXVAR0", JdeDataType.String, 510),
        new JdeField("OTEXVAR1", "OTEXVAR1", JdeDataType.String, 510),
        new JdeField("OTEXVAR2", "OTEXVAR2", JdeDataType.String, 510),
        new JdeField("OTEXVAR3", "OTEXVAR3", JdeDataType.String, 510),
        new JdeField("OTEXVAR4", "OTEXVAR4", JdeDataType.String, 100),
        new JdeField("OTEXVAR5", "OTEXVAR5", JdeDataType.String, 100),
        new JdeField("OTEXVAR6", "OTEXVAR6", JdeDataType.String, 100),
        new JdeField("OTEXVAR7", "OTEXVAR7", JdeDataType.String, 100),
        new JdeField("OTEXVAR8", "OTEXVAR8", JdeDataType.String, 100),
        new JdeField("OTEXVAR9", "OTEXVAR9", JdeDataType.String, 100),
        new JdeField("OTEXVAR10", "OTEXVAR10", JdeDataType.String, 100),
        new JdeField("OTEXVAR11", "OTEXVAR11", JdeDataType.String, 100),
        new JdeField("OTEXVAR12", "OTEXVAR12", JdeDataType.String, 50),
        new JdeField("OTEXVAR13", "OTEXVAR13", JdeDataType.String, 50),
        new JdeField("OTEXVAR14", "OTEXVAR14", JdeDataType.String, 50),
        new JdeField("OTEXNM0", "OTEXNM0", JdeDataType.Numeric),
        new JdeField("OTEXNM1", "OTEXNM1", JdeDataType.Numeric),
        new JdeField("OTEXNM2", "OTEXNM2", JdeDataType.Numeric),
        new JdeField("OTEXNM3", "OTEXNM3", JdeDataType.Numeric),
        new JdeField("OTEXNM4", "OTEXNM4", JdeDataType.Numeric),
        new JdeField("OTEXNMP0", "OTEXNMP0", JdeDataType.Numeric),
        new JdeField("OTEXNMP1", "OTEXNMP1", JdeDataType.Numeric),
        new JdeField("OTEXNMP2", "OTEXNMP2", JdeDataType.Numeric),
        new JdeField("OTEXNMP3", "OTEXNMP3", JdeDataType.Numeric),
        new JdeField("OTEXNMP4", "OTEXNMP4", JdeDataType.Numeric),
        new JdeField("OTEXDT0", "OTEXDT0", JdeDataType.Date),
        new JdeField("OTEXDT1", "OTEXDT1", JdeDataType.Date),
        new JdeField("OTEXDT2", "OTEXDT2", JdeDataType.Date),
        new JdeField("OTEXDT3", "OTEXDT3", JdeDataType.Date),
        new JdeField("OTEXDT4", "OTEXDT4", JdeDataType.Date),
        new JdeField("OTSTSUDT", "OTSTSUDT", JdeDataType.Date),
        new JdeField("OTACTIND", "OTACTIND", JdeDataType.String, 2),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTVID", "OTVID", JdeDataType.String, 20),
        new JdeField("OTMKEY", "OTMKEY", JdeDataType.String, 30),
        new JdeField("OTUDTTM", "OTUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB020_0", "Primary Key on OTOPPID", new[] { "OTOPPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB020_10", "Index on OTPBLTY", new[] { "OTPBLTY" }),
        new JdeIndex("F90CB020_11", "Index on OTCLDATE", new[] { "OTCLDATE" }),
        new JdeIndex("F90CB020_2", "Index on OTPRAN8, OTPRCIDLN", new[] { "OTPRAN8", "OTPRCIDLN" }),
        new JdeIndex("F90CB020_3", "Index on OTCUAN8, OTCCIDLN", new[] { "OTCUAN8", "OTCCIDLN" }),
        new JdeIndex("F90CB020_4", "Index on OTCUSAN8, OTSHCCIDLN", new[] { "OTCUSAN8", "OTSHCCIDLN" }),
        new JdeIndex("F90CB020_5", "Index on OTCAMPID, OTEVTID", new[] { "OTCAMPID", "OTEVTID" }),
        new JdeIndex("F90CB020_6", "Index on OTEVTID", new[] { "OTEVTID" }),
        new JdeIndex("F90CB020_7", "Index on OTCUSAN8, OTLOBCO", new[] { "OTCUSAN8", "OTLOBCO" }),
        new JdeIndex("F90CB020_8", "Index on OTCUAN8, OTLOBCO", new[] { "OTCUAN8", "OTLOBCO" }),
        new JdeIndex("F90CB020_9", "Index on OTCUAN8", new[] { "OTCUAN8" })
    };
}
