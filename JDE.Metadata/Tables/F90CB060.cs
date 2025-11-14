using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB060 - .
/// </summary>
public class F90CB060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCFCID.
        /// </summary>
        public const string FCFCID = "FCFCID";

        /// <summary>
        /// FCDSCRP1.
        /// </summary>
        public const string FCDSCRP1 = "FCDSCRP1";

        /// <summary>
        /// FCFORFOR.
        /// </summary>
        public const string FCFORFOR = "FCFORFOR";

        /// <summary>
        /// FCIDLN.
        /// </summary>
        public const string FCIDLN = "FCIDLN";

        /// <summary>
        /// FCRNGSTART.
        /// </summary>
        public const string FCRNGSTART = "FCRNGSTART";

        /// <summary>
        /// FCRNGEND.
        /// </summary>
        public const string FCRNGEND = "FCRNGEND";

        /// <summary>
        /// FCREVENUE.
        /// </summary>
        public const string FCREVENUE = "FCREVENUE";

        /// <summary>
        /// FCREVLITOT.
        /// </summary>
        public const string FCREVLITOT = "FCREVLITOT";

        /// <summary>
        /// FCREVCRCD.
        /// </summary>
        public const string FCREVCRCD = "FCREVCRCD";

        /// <summary>
        /// FCOVRDREV.
        /// </summary>
        public const string FCOVRDREV = "FCOVRDREV";

        /// <summary>
        /// FCORCVCRCD.
        /// </summary>
        public const string FCORCVCRCD = "FCORCVCRCD";

        /// <summary>
        /// FCFRZFC.
        /// </summary>
        public const string FCFRZFC = "FCFRZFC";

        /// <summary>
        /// FCDPFLG.
        /// </summary>
        public const string FCDPFLG = "FCDPFLG";

        /// <summary>
        /// FCFCSTATUS.
        /// </summary>
        public const string FCFCSTATUS = "FCFCSTATUS";

        /// <summary>
        /// FCSBMTDT.
        /// </summary>
        public const string FCSBMTDT = "FCSBMTDT";

        /// <summary>
        /// FCEDATE.
        /// </summary>
        public const string FCEDATE = "FCEDATE";

        /// <summary>
        /// FCENTDBY.
        /// </summary>
        public const string FCENTDBY = "FCENTDBY";

        /// <summary>
        /// FCACTIND.
        /// </summary>
        public const string FCACTIND = "FCACTIND";

        /// <summary>
        /// FCSTSUDT.
        /// </summary>
        public const string FCSTSUDT = "FCSTSUDT";

        /// <summary>
        /// FCINDTRY.
        /// </summary>
        public const string FCINDTRY = "FCINDTRY";

        /// <summary>
        /// FCEMPID.
        /// </summary>
        public const string FCEMPID = "FCEMPID";

        /// <summary>
        /// FCPBLTY.
        /// </summary>
        public const string FCPBLTY = "FCPBLTY";

        /// <summary>
        /// FCOPTYCD.
        /// </summary>
        public const string FCOPTYCD = "FCOPTYCD";

        /// <summary>
        /// FCSTRTDT.
        /// </summary>
        public const string FCSTRTDT = "FCSTRTDT";

        /// <summary>
        /// FCENDDT.
        /// </summary>
        public const string FCENDDT = "FCENDDT";

        /// <summary>
        /// FCEXVAR0.
        /// </summary>
        public const string FCEXVAR0 = "FCEXVAR0";

        /// <summary>
        /// FCEXVAR1.
        /// </summary>
        public const string FCEXVAR1 = "FCEXVAR1";

        /// <summary>
        /// FCEXVAR2.
        /// </summary>
        public const string FCEXVAR2 = "FCEXVAR2";

        /// <summary>
        /// FCEXVAR3.
        /// </summary>
        public const string FCEXVAR3 = "FCEXVAR3";

        /// <summary>
        /// FCEXVAR4.
        /// </summary>
        public const string FCEXVAR4 = "FCEXVAR4";

        /// <summary>
        /// FCEXVAR5.
        /// </summary>
        public const string FCEXVAR5 = "FCEXVAR5";

        /// <summary>
        /// FCEXVAR6.
        /// </summary>
        public const string FCEXVAR6 = "FCEXVAR6";

        /// <summary>
        /// FCEXVAR7.
        /// </summary>
        public const string FCEXVAR7 = "FCEXVAR7";

        /// <summary>
        /// FCEXVAR8.
        /// </summary>
        public const string FCEXVAR8 = "FCEXVAR8";

        /// <summary>
        /// FCEXVAR9.
        /// </summary>
        public const string FCEXVAR9 = "FCEXVAR9";

        /// <summary>
        /// FCEXVAR10.
        /// </summary>
        public const string FCEXVAR10 = "FCEXVAR10";

        /// <summary>
        /// FCEXVAR11.
        /// </summary>
        public const string FCEXVAR11 = "FCEXVAR11";

        /// <summary>
        /// FCEXVAR12.
        /// </summary>
        public const string FCEXVAR12 = "FCEXVAR12";

        /// <summary>
        /// FCEXVAR13.
        /// </summary>
        public const string FCEXVAR13 = "FCEXVAR13";

        /// <summary>
        /// FCEXVAR14.
        /// </summary>
        public const string FCEXVAR14 = "FCEXVAR14";

        /// <summary>
        /// FCEXNM0.
        /// </summary>
        public const string FCEXNM0 = "FCEXNM0";

        /// <summary>
        /// FCEXNM1.
        /// </summary>
        public const string FCEXNM1 = "FCEXNM1";

        /// <summary>
        /// FCEXNM2.
        /// </summary>
        public const string FCEXNM2 = "FCEXNM2";

        /// <summary>
        /// FCEXNM3.
        /// </summary>
        public const string FCEXNM3 = "FCEXNM3";

        /// <summary>
        /// FCEXNM4.
        /// </summary>
        public const string FCEXNM4 = "FCEXNM4";

        /// <summary>
        /// FCEXNMP0.
        /// </summary>
        public const string FCEXNMP0 = "FCEXNMP0";

        /// <summary>
        /// FCEXNMP1.
        /// </summary>
        public const string FCEXNMP1 = "FCEXNMP1";

        /// <summary>
        /// FCEXNMP2.
        /// </summary>
        public const string FCEXNMP2 = "FCEXNMP2";

        /// <summary>
        /// FCEXNMP3.
        /// </summary>
        public const string FCEXNMP3 = "FCEXNMP3";

        /// <summary>
        /// FCEXNMP4.
        /// </summary>
        public const string FCEXNMP4 = "FCEXNMP4";

        /// <summary>
        /// FCEXDT0.
        /// </summary>
        public const string FCEXDT0 = "FCEXDT0";

        /// <summary>
        /// FCEXDT1.
        /// </summary>
        public const string FCEXDT1 = "FCEXDT1";

        /// <summary>
        /// FCEXDT2.
        /// </summary>
        public const string FCEXDT2 = "FCEXDT2";

        /// <summary>
        /// FCEXDT3.
        /// </summary>
        public const string FCEXDT3 = "FCEXDT3";

        /// <summary>
        /// FCEXDT4.
        /// </summary>
        public const string FCEXDT4 = "FCEXDT4";

        /// <summary>
        /// FCPERMFC.
        /// </summary>
        public const string FCPERMFC = "FCPERMFC";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";

        /// <summary>
        /// FCVID.
        /// </summary>
        public const string FCVID = "FCVID";

        /// <summary>
        /// FCMKEY.
        /// </summary>
        public const string FCMKEY = "FCMKEY";

        /// <summary>
        /// FCUDTTM.
        /// </summary>
        public const string FCUDTTM = "FCUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCFCID", "FCFCID", JdeDataType.Numeric, null, true, true),
        new JdeField("FCDSCRP1", "FCDSCRP1", JdeDataType.String, 100),
        new JdeField("FCFORFOR", "FCFORFOR", JdeDataType.Numeric),
        new JdeField("FCIDLN", "FCIDLN", JdeDataType.Numeric),
        new JdeField("FCRNGSTART", "FCRNGSTART", JdeDataType.Date),
        new JdeField("FCRNGEND", "FCRNGEND", JdeDataType.Date),
        new JdeField("FCREVENUE", "FCREVENUE", JdeDataType.Numeric),
        new JdeField("FCREVLITOT", "FCREVLITOT", JdeDataType.Numeric),
        new JdeField("FCREVCRCD", "FCREVCRCD", JdeDataType.String, 6),
        new JdeField("FCOVRDREV", "FCOVRDREV", JdeDataType.Numeric),
        new JdeField("FCORCVCRCD", "FCORCVCRCD", JdeDataType.String, 6),
        new JdeField("FCFRZFC", "FCFRZFC", JdeDataType.String, 2),
        new JdeField("FCDPFLG", "FCDPFLG", JdeDataType.String, 2),
        new JdeField("FCFCSTATUS", "FCFCSTATUS", JdeDataType.String, 20),
        new JdeField("FCSBMTDT", "FCSBMTDT", JdeDataType.Date),
        new JdeField("FCEDATE", "FCEDATE", JdeDataType.Date),
        new JdeField("FCENTDBY", "FCENTDBY", JdeDataType.Numeric),
        new JdeField("FCACTIND", "FCACTIND", JdeDataType.String, 2),
        new JdeField("FCSTSUDT", "FCSTSUDT", JdeDataType.Date),
        new JdeField("FCINDTRY", "FCINDTRY", JdeDataType.String, 20),
        new JdeField("FCEMPID", "FCEMPID", JdeDataType.Numeric),
        new JdeField("FCPBLTY", "FCPBLTY", JdeDataType.Numeric),
        new JdeField("FCOPTYCD", "FCOPTYCD", JdeDataType.String, 10),
        new JdeField("FCSTRTDT", "FCSTRTDT", JdeDataType.Date),
        new JdeField("FCENDDT", "FCENDDT", JdeDataType.Date),
        new JdeField("FCEXVAR0", "FCEXVAR0", JdeDataType.String, 510),
        new JdeField("FCEXVAR1", "FCEXVAR1", JdeDataType.String, 510),
        new JdeField("FCEXVAR2", "FCEXVAR2", JdeDataType.String, 510),
        new JdeField("FCEXVAR3", "FCEXVAR3", JdeDataType.String, 510),
        new JdeField("FCEXVAR4", "FCEXVAR4", JdeDataType.String, 100),
        new JdeField("FCEXVAR5", "FCEXVAR5", JdeDataType.String, 100),
        new JdeField("FCEXVAR6", "FCEXVAR6", JdeDataType.String, 100),
        new JdeField("FCEXVAR7", "FCEXVAR7", JdeDataType.String, 100),
        new JdeField("FCEXVAR8", "FCEXVAR8", JdeDataType.String, 100),
        new JdeField("FCEXVAR9", "FCEXVAR9", JdeDataType.String, 100),
        new JdeField("FCEXVAR10", "FCEXVAR10", JdeDataType.String, 100),
        new JdeField("FCEXVAR11", "FCEXVAR11", JdeDataType.String, 100),
        new JdeField("FCEXVAR12", "FCEXVAR12", JdeDataType.String, 50),
        new JdeField("FCEXVAR13", "FCEXVAR13", JdeDataType.String, 50),
        new JdeField("FCEXVAR14", "FCEXVAR14", JdeDataType.String, 50),
        new JdeField("FCEXNM0", "FCEXNM0", JdeDataType.Numeric),
        new JdeField("FCEXNM1", "FCEXNM1", JdeDataType.Numeric),
        new JdeField("FCEXNM2", "FCEXNM2", JdeDataType.Numeric),
        new JdeField("FCEXNM3", "FCEXNM3", JdeDataType.Numeric),
        new JdeField("FCEXNM4", "FCEXNM4", JdeDataType.Numeric),
        new JdeField("FCEXNMP0", "FCEXNMP0", JdeDataType.Numeric),
        new JdeField("FCEXNMP1", "FCEXNMP1", JdeDataType.Numeric),
        new JdeField("FCEXNMP2", "FCEXNMP2", JdeDataType.Numeric),
        new JdeField("FCEXNMP3", "FCEXNMP3", JdeDataType.Numeric),
        new JdeField("FCEXNMP4", "FCEXNMP4", JdeDataType.Numeric),
        new JdeField("FCEXDT0", "FCEXDT0", JdeDataType.Date),
        new JdeField("FCEXDT1", "FCEXDT1", JdeDataType.Date),
        new JdeField("FCEXDT2", "FCEXDT2", JdeDataType.Date),
        new JdeField("FCEXDT3", "FCEXDT3", JdeDataType.Date),
        new JdeField("FCEXDT4", "FCEXDT4", JdeDataType.Date),
        new JdeField("FCPERMFC", "FCPERMFC", JdeDataType.String, 30),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCVID", "FCVID", JdeDataType.String, 20),
        new JdeField("FCMKEY", "FCMKEY", JdeDataType.String, 30),
        new JdeField("FCUDTTM", "FCUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB060_0", "Primary Key on FCFCID", new[] { "FCFCID" }, isUnique: true, isPrimaryKey: true)
    };
}
