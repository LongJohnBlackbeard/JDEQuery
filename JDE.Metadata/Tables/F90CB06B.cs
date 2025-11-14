using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB06B - .
/// </summary>
public class F90CB06B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OFFCID.
        /// </summary>
        public const string OFFCID = "OFFCID";

        /// <summary>
        /// OFOPPID.
        /// </summary>
        public const string OFOPPID = "OFOPPID";

        /// <summary>
        /// OFDSCRP1.
        /// </summary>
        public const string OFDSCRP1 = "OFDSCRP1";

        /// <summary>
        /// OFOPTYCD.
        /// </summary>
        public const string OFOPTYCD = "OFOPTYCD";

        /// <summary>
        /// OFCAMPID.
        /// </summary>
        public const string OFCAMPID = "OFCAMPID";

        /// <summary>
        /// OFEVTID.
        /// </summary>
        public const string OFEVTID = "OFEVTID";

        /// <summary>
        /// OFPRAN8.
        /// </summary>
        public const string OFPRAN8 = "OFPRAN8";

        /// <summary>
        /// OFPRCIDLN.
        /// </summary>
        public const string OFPRCIDLN = "OFPRCIDLN";

        /// <summary>
        /// OFCUAN8.
        /// </summary>
        public const string OFCUAN8 = "OFCUAN8";

        /// <summary>
        /// OFCCIDLN.
        /// </summary>
        public const string OFCCIDLN = "OFCCIDLN";

        /// <summary>
        /// OFCUSAN8.
        /// </summary>
        public const string OFCUSAN8 = "OFCUSAN8";

        /// <summary>
        /// OFSHCCIDLN.
        /// </summary>
        public const string OFSHCCIDLN = "OFSHCCIDLN";

        /// <summary>
        /// OFLTAN8.
        /// </summary>
        public const string OFLTAN8 = "OFLTAN8";

        /// <summary>
        /// OFQUFID.
        /// </summary>
        public const string OFQUFID = "OFQUFID";

        /// <summary>
        /// OFQUFSCR.
        /// </summary>
        public const string OFQUFSCR = "OFQUFSCR";

        /// <summary>
        /// OFQUFGL.
        /// </summary>
        public const string OFQUFGL = "OFQUFGL";

        /// <summary>
        /// OFSMEID.
        /// </summary>
        public const string OFSMEID = "OFSMEID";

        /// <summary>
        /// OFSLCYID.
        /// </summary>
        public const string OFSLCYID = "OFSLCYID";

        /// <summary>
        /// OFPBLTY.
        /// </summary>
        public const string OFPBLTY = "OFPBLTY";

        /// <summary>
        /// OFCLDATE.
        /// </summary>
        public const string OFCLDATE = "OFCLDATE";

        /// <summary>
        /// OFBDAMT.
        /// </summary>
        public const string OFBDAMT = "OFBDAMT";

        /// <summary>
        /// OFPTAMT.
        /// </summary>
        public const string OFPTAMT = "OFPTAMT";

        /// <summary>
        /// OFCRCD.
        /// </summary>
        public const string OFCRCD = "OFCRCD";

        /// <summary>
        /// OFLRTXT.
        /// </summary>
        public const string OFLRTXT = "OFLRTXT";

        /// <summary>
        /// OFSTSCD.
        /// </summary>
        public const string OFSTSCD = "OFSTSCD";

        /// <summary>
        /// OFOPMCU.
        /// </summary>
        public const string OFOPMCU = "OFOPMCU";

        /// <summary>
        /// OFLITOT.
        /// </summary>
        public const string OFLITOT = "OFLITOT";

        /// <summary>
        /// OFLOBCO.
        /// </summary>
        public const string OFLOBCO = "OFLOBCO";

        /// <summary>
        /// OFLEADSRC.
        /// </summary>
        public const string OFLEADSRC = "OFLEADSRC";

        /// <summary>
        /// OFENTDBY.
        /// </summary>
        public const string OFENTDBY = "OFENTDBY";

        /// <summary>
        /// OFEDATE.
        /// </summary>
        public const string OFEDATE = "OFEDATE";

        /// <summary>
        /// OFEXVAR0.
        /// </summary>
        public const string OFEXVAR0 = "OFEXVAR0";

        /// <summary>
        /// OFEXVAR1.
        /// </summary>
        public const string OFEXVAR1 = "OFEXVAR1";

        /// <summary>
        /// OFEXVAR2.
        /// </summary>
        public const string OFEXVAR2 = "OFEXVAR2";

        /// <summary>
        /// OFEXVAR3.
        /// </summary>
        public const string OFEXVAR3 = "OFEXVAR3";

        /// <summary>
        /// OFEXVAR4.
        /// </summary>
        public const string OFEXVAR4 = "OFEXVAR4";

        /// <summary>
        /// OFEXVAR5.
        /// </summary>
        public const string OFEXVAR5 = "OFEXVAR5";

        /// <summary>
        /// OFEXVAR6.
        /// </summary>
        public const string OFEXVAR6 = "OFEXVAR6";

        /// <summary>
        /// OFEXVAR7.
        /// </summary>
        public const string OFEXVAR7 = "OFEXVAR7";

        /// <summary>
        /// OFEXVAR8.
        /// </summary>
        public const string OFEXVAR8 = "OFEXVAR8";

        /// <summary>
        /// OFEXVAR9.
        /// </summary>
        public const string OFEXVAR9 = "OFEXVAR9";

        /// <summary>
        /// OFEXVAR10.
        /// </summary>
        public const string OFEXVAR10 = "OFEXVAR10";

        /// <summary>
        /// OFEXVAR11.
        /// </summary>
        public const string OFEXVAR11 = "OFEXVAR11";

        /// <summary>
        /// OFEXVAR12.
        /// </summary>
        public const string OFEXVAR12 = "OFEXVAR12";

        /// <summary>
        /// OFEXVAR13.
        /// </summary>
        public const string OFEXVAR13 = "OFEXVAR13";

        /// <summary>
        /// OFEXVAR14.
        /// </summary>
        public const string OFEXVAR14 = "OFEXVAR14";

        /// <summary>
        /// OFEXNM0.
        /// </summary>
        public const string OFEXNM0 = "OFEXNM0";

        /// <summary>
        /// OFEXNM1.
        /// </summary>
        public const string OFEXNM1 = "OFEXNM1";

        /// <summary>
        /// OFEXNM2.
        /// </summary>
        public const string OFEXNM2 = "OFEXNM2";

        /// <summary>
        /// OFEXNM3.
        /// </summary>
        public const string OFEXNM3 = "OFEXNM3";

        /// <summary>
        /// OFEXNM4.
        /// </summary>
        public const string OFEXNM4 = "OFEXNM4";

        /// <summary>
        /// OFEXNMP0.
        /// </summary>
        public const string OFEXNMP0 = "OFEXNMP0";

        /// <summary>
        /// OFEXNMP1.
        /// </summary>
        public const string OFEXNMP1 = "OFEXNMP1";

        /// <summary>
        /// OFEXNMP2.
        /// </summary>
        public const string OFEXNMP2 = "OFEXNMP2";

        /// <summary>
        /// OFEXNMP3.
        /// </summary>
        public const string OFEXNMP3 = "OFEXNMP3";

        /// <summary>
        /// OFEXNMP4.
        /// </summary>
        public const string OFEXNMP4 = "OFEXNMP4";

        /// <summary>
        /// OFEXDT0.
        /// </summary>
        public const string OFEXDT0 = "OFEXDT0";

        /// <summary>
        /// OFEXDT1.
        /// </summary>
        public const string OFEXDT1 = "OFEXDT1";

        /// <summary>
        /// OFEXDT2.
        /// </summary>
        public const string OFEXDT2 = "OFEXDT2";

        /// <summary>
        /// OFEXDT3.
        /// </summary>
        public const string OFEXDT3 = "OFEXDT3";

        /// <summary>
        /// OFEXDT4.
        /// </summary>
        public const string OFEXDT4 = "OFEXDT4";

        /// <summary>
        /// OFSTSUDT.
        /// </summary>
        public const string OFSTSUDT = "OFSTSUDT";

        /// <summary>
        /// OFACTIND.
        /// </summary>
        public const string OFACTIND = "OFACTIND";

        /// <summary>
        /// OFUSER.
        /// </summary>
        public const string OFUSER = "OFUSER";

        /// <summary>
        /// OFPID.
        /// </summary>
        public const string OFPID = "OFPID";

        /// <summary>
        /// OFVID.
        /// </summary>
        public const string OFVID = "OFVID";

        /// <summary>
        /// OFMKEY.
        /// </summary>
        public const string OFMKEY = "OFMKEY";

        /// <summary>
        /// OFUDTTM.
        /// </summary>
        public const string OFUDTTM = "OFUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB06B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OFFCID", "OFFCID", JdeDataType.Numeric, null, true, true),
        new JdeField("OFOPPID", "OFOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OFDSCRP1", "OFDSCRP1", JdeDataType.String, 100),
        new JdeField("OFOPTYCD", "OFOPTYCD", JdeDataType.String, 10),
        new JdeField("OFCAMPID", "OFCAMPID", JdeDataType.Numeric),
        new JdeField("OFEVTID", "OFEVTID", JdeDataType.Numeric),
        new JdeField("OFPRAN8", "OFPRAN8", JdeDataType.Numeric),
        new JdeField("OFPRCIDLN", "OFPRCIDLN", JdeDataType.Numeric),
        new JdeField("OFCUAN8", "OFCUAN8", JdeDataType.Numeric),
        new JdeField("OFCCIDLN", "OFCCIDLN", JdeDataType.Numeric),
        new JdeField("OFCUSAN8", "OFCUSAN8", JdeDataType.Numeric),
        new JdeField("OFSHCCIDLN", "OFSHCCIDLN", JdeDataType.Numeric),
        new JdeField("OFLTAN8", "OFLTAN8", JdeDataType.Numeric),
        new JdeField("OFQUFID", "OFQUFID", JdeDataType.Numeric),
        new JdeField("OFQUFSCR", "OFQUFSCR", JdeDataType.Numeric),
        new JdeField("OFQUFGL", "OFQUFGL", JdeDataType.Numeric),
        new JdeField("OFSMEID", "OFSMEID", JdeDataType.Numeric),
        new JdeField("OFSLCYID", "OFSLCYID", JdeDataType.Numeric),
        new JdeField("OFPBLTY", "OFPBLTY", JdeDataType.Numeric),
        new JdeField("OFCLDATE", "OFCLDATE", JdeDataType.Date),
        new JdeField("OFBDAMT", "OFBDAMT", JdeDataType.Numeric),
        new JdeField("OFPTAMT", "OFPTAMT", JdeDataType.Numeric),
        new JdeField("OFCRCD", "OFCRCD", JdeDataType.String, 6),
        new JdeField("OFLRTXT", "OFLRTXT", JdeDataType.String, 200),
        new JdeField("OFSTSCD", "OFSTSCD", JdeDataType.String, 10),
        new JdeField("OFOPMCU", "OFOPMCU", JdeDataType.String, 24),
        new JdeField("OFLITOT", "OFLITOT", JdeDataType.Numeric),
        new JdeField("OFLOBCO", "OFLOBCO", JdeDataType.String, 10),
        new JdeField("OFLEADSRC", "OFLEADSRC", JdeDataType.String, 6),
        new JdeField("OFENTDBY", "OFENTDBY", JdeDataType.Numeric),
        new JdeField("OFEDATE", "OFEDATE", JdeDataType.Date),
        new JdeField("OFEXVAR0", "OFEXVAR0", JdeDataType.String, 510),
        new JdeField("OFEXVAR1", "OFEXVAR1", JdeDataType.String, 510),
        new JdeField("OFEXVAR2", "OFEXVAR2", JdeDataType.String, 510),
        new JdeField("OFEXVAR3", "OFEXVAR3", JdeDataType.String, 510),
        new JdeField("OFEXVAR4", "OFEXVAR4", JdeDataType.String, 100),
        new JdeField("OFEXVAR5", "OFEXVAR5", JdeDataType.String, 100),
        new JdeField("OFEXVAR6", "OFEXVAR6", JdeDataType.String, 100),
        new JdeField("OFEXVAR7", "OFEXVAR7", JdeDataType.String, 100),
        new JdeField("OFEXVAR8", "OFEXVAR8", JdeDataType.String, 100),
        new JdeField("OFEXVAR9", "OFEXVAR9", JdeDataType.String, 100),
        new JdeField("OFEXVAR10", "OFEXVAR10", JdeDataType.String, 100),
        new JdeField("OFEXVAR11", "OFEXVAR11", JdeDataType.String, 100),
        new JdeField("OFEXVAR12", "OFEXVAR12", JdeDataType.String, 50),
        new JdeField("OFEXVAR13", "OFEXVAR13", JdeDataType.String, 50),
        new JdeField("OFEXVAR14", "OFEXVAR14", JdeDataType.String, 50),
        new JdeField("OFEXNM0", "OFEXNM0", JdeDataType.Numeric),
        new JdeField("OFEXNM1", "OFEXNM1", JdeDataType.Numeric),
        new JdeField("OFEXNM2", "OFEXNM2", JdeDataType.Numeric),
        new JdeField("OFEXNM3", "OFEXNM3", JdeDataType.Numeric),
        new JdeField("OFEXNM4", "OFEXNM4", JdeDataType.Numeric),
        new JdeField("OFEXNMP0", "OFEXNMP0", JdeDataType.Numeric),
        new JdeField("OFEXNMP1", "OFEXNMP1", JdeDataType.Numeric),
        new JdeField("OFEXNMP2", "OFEXNMP2", JdeDataType.Numeric),
        new JdeField("OFEXNMP3", "OFEXNMP3", JdeDataType.Numeric),
        new JdeField("OFEXNMP4", "OFEXNMP4", JdeDataType.Numeric),
        new JdeField("OFEXDT0", "OFEXDT0", JdeDataType.Date),
        new JdeField("OFEXDT1", "OFEXDT1", JdeDataType.Date),
        new JdeField("OFEXDT2", "OFEXDT2", JdeDataType.Date),
        new JdeField("OFEXDT3", "OFEXDT3", JdeDataType.Date),
        new JdeField("OFEXDT4", "OFEXDT4", JdeDataType.Date),
        new JdeField("OFSTSUDT", "OFSTSUDT", JdeDataType.Date),
        new JdeField("OFACTIND", "OFACTIND", JdeDataType.String, 2),
        new JdeField("OFUSER", "OFUSER", JdeDataType.String, 20),
        new JdeField("OFPID", "OFPID", JdeDataType.String, 20),
        new JdeField("OFVID", "OFVID", JdeDataType.String, 20),
        new JdeField("OFMKEY", "OFMKEY", JdeDataType.String, 30),
        new JdeField("OFUDTTM", "OFUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB06B_0", "Primary Key on OFFCID, OFOPPID", new[] { "OFFCID", "OFOPPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB06B_2", "Index on OFOPPID, OFFCID", new[] { "OFOPPID", "OFFCID" })
    };
}
