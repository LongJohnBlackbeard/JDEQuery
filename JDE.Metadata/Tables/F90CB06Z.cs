using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB06Z - .
/// </summary>
public class F90CB06Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZFCFGSID.
        /// </summary>
        public const string ZFCFGSID = "ZFCFGSID";

        /// <summary>
        /// ZFOPPID.
        /// </summary>
        public const string ZFOPPID = "ZFOPPID";

        /// <summary>
        /// ZFFCID.
        /// </summary>
        public const string ZFFCID = "ZFFCID";

        /// <summary>
        /// ZFDSCRP1.
        /// </summary>
        public const string ZFDSCRP1 = "ZFDSCRP1";

        /// <summary>
        /// ZFOPTYCD.
        /// </summary>
        public const string ZFOPTYCD = "ZFOPTYCD";

        /// <summary>
        /// ZFCAMPID.
        /// </summary>
        public const string ZFCAMPID = "ZFCAMPID";

        /// <summary>
        /// ZFEVTID.
        /// </summary>
        public const string ZFEVTID = "ZFEVTID";

        /// <summary>
        /// ZFPRAN8.
        /// </summary>
        public const string ZFPRAN8 = "ZFPRAN8";

        /// <summary>
        /// ZFPRCIDLN.
        /// </summary>
        public const string ZFPRCIDLN = "ZFPRCIDLN";

        /// <summary>
        /// ZFCUAN8.
        /// </summary>
        public const string ZFCUAN8 = "ZFCUAN8";

        /// <summary>
        /// ZFCCIDLN.
        /// </summary>
        public const string ZFCCIDLN = "ZFCCIDLN";

        /// <summary>
        /// ZFCUSAN8.
        /// </summary>
        public const string ZFCUSAN8 = "ZFCUSAN8";

        /// <summary>
        /// ZFSHCCIDLN.
        /// </summary>
        public const string ZFSHCCIDLN = "ZFSHCCIDLN";

        /// <summary>
        /// ZFLTAN8.
        /// </summary>
        public const string ZFLTAN8 = "ZFLTAN8";

        /// <summary>
        /// ZFQUFID.
        /// </summary>
        public const string ZFQUFID = "ZFQUFID";

        /// <summary>
        /// ZFQUFSCR.
        /// </summary>
        public const string ZFQUFSCR = "ZFQUFSCR";

        /// <summary>
        /// ZFQUFGL.
        /// </summary>
        public const string ZFQUFGL = "ZFQUFGL";

        /// <summary>
        /// ZFSMEID.
        /// </summary>
        public const string ZFSMEID = "ZFSMEID";

        /// <summary>
        /// ZFSLCYID.
        /// </summary>
        public const string ZFSLCYID = "ZFSLCYID";

        /// <summary>
        /// ZFPBLTY.
        /// </summary>
        public const string ZFPBLTY = "ZFPBLTY";

        /// <summary>
        /// ZFCLDATE.
        /// </summary>
        public const string ZFCLDATE = "ZFCLDATE";

        /// <summary>
        /// ZFBDAMT.
        /// </summary>
        public const string ZFBDAMT = "ZFBDAMT";

        /// <summary>
        /// ZFPTAMT.
        /// </summary>
        public const string ZFPTAMT = "ZFPTAMT";

        /// <summary>
        /// ZFCRCD.
        /// </summary>
        public const string ZFCRCD = "ZFCRCD";

        /// <summary>
        /// ZFLRTXT.
        /// </summary>
        public const string ZFLRTXT = "ZFLRTXT";

        /// <summary>
        /// ZFSTSCD.
        /// </summary>
        public const string ZFSTSCD = "ZFSTSCD";

        /// <summary>
        /// ZFOPMCU.
        /// </summary>
        public const string ZFOPMCU = "ZFOPMCU";

        /// <summary>
        /// ZFLITOT.
        /// </summary>
        public const string ZFLITOT = "ZFLITOT";

        /// <summary>
        /// ZFLOBCO.
        /// </summary>
        public const string ZFLOBCO = "ZFLOBCO";

        /// <summary>
        /// ZFLEADSRC.
        /// </summary>
        public const string ZFLEADSRC = "ZFLEADSRC";

        /// <summary>
        /// ZFENTDBY.
        /// </summary>
        public const string ZFENTDBY = "ZFENTDBY";

        /// <summary>
        /// ZFEDATE.
        /// </summary>
        public const string ZFEDATE = "ZFEDATE";

        /// <summary>
        /// ZFEXVAR0.
        /// </summary>
        public const string ZFEXVAR0 = "ZFEXVAR0";

        /// <summary>
        /// ZFEXVAR1.
        /// </summary>
        public const string ZFEXVAR1 = "ZFEXVAR1";

        /// <summary>
        /// ZFEXVAR2.
        /// </summary>
        public const string ZFEXVAR2 = "ZFEXVAR2";

        /// <summary>
        /// ZFEXVAR3.
        /// </summary>
        public const string ZFEXVAR3 = "ZFEXVAR3";

        /// <summary>
        /// ZFEXVAR4.
        /// </summary>
        public const string ZFEXVAR4 = "ZFEXVAR4";

        /// <summary>
        /// ZFEXVAR5.
        /// </summary>
        public const string ZFEXVAR5 = "ZFEXVAR5";

        /// <summary>
        /// ZFEXVAR6.
        /// </summary>
        public const string ZFEXVAR6 = "ZFEXVAR6";

        /// <summary>
        /// ZFEXVAR7.
        /// </summary>
        public const string ZFEXVAR7 = "ZFEXVAR7";

        /// <summary>
        /// ZFEXVAR8.
        /// </summary>
        public const string ZFEXVAR8 = "ZFEXVAR8";

        /// <summary>
        /// ZFEXVAR9.
        /// </summary>
        public const string ZFEXVAR9 = "ZFEXVAR9";

        /// <summary>
        /// ZFEXVAR10.
        /// </summary>
        public const string ZFEXVAR10 = "ZFEXVAR10";

        /// <summary>
        /// ZFEXVAR11.
        /// </summary>
        public const string ZFEXVAR11 = "ZFEXVAR11";

        /// <summary>
        /// ZFEXVAR12.
        /// </summary>
        public const string ZFEXVAR12 = "ZFEXVAR12";

        /// <summary>
        /// ZFEXVAR13.
        /// </summary>
        public const string ZFEXVAR13 = "ZFEXVAR13";

        /// <summary>
        /// ZFEXVAR14.
        /// </summary>
        public const string ZFEXVAR14 = "ZFEXVAR14";

        /// <summary>
        /// ZFEXNM0.
        /// </summary>
        public const string ZFEXNM0 = "ZFEXNM0";

        /// <summary>
        /// ZFEXNM1.
        /// </summary>
        public const string ZFEXNM1 = "ZFEXNM1";

        /// <summary>
        /// ZFEXNM2.
        /// </summary>
        public const string ZFEXNM2 = "ZFEXNM2";

        /// <summary>
        /// ZFEXNM3.
        /// </summary>
        public const string ZFEXNM3 = "ZFEXNM3";

        /// <summary>
        /// ZFEXNM4.
        /// </summary>
        public const string ZFEXNM4 = "ZFEXNM4";

        /// <summary>
        /// ZFEXNMP0.
        /// </summary>
        public const string ZFEXNMP0 = "ZFEXNMP0";

        /// <summary>
        /// ZFEXNMP1.
        /// </summary>
        public const string ZFEXNMP1 = "ZFEXNMP1";

        /// <summary>
        /// ZFEXNMP2.
        /// </summary>
        public const string ZFEXNMP2 = "ZFEXNMP2";

        /// <summary>
        /// ZFEXNMP3.
        /// </summary>
        public const string ZFEXNMP3 = "ZFEXNMP3";

        /// <summary>
        /// ZFEXNMP4.
        /// </summary>
        public const string ZFEXNMP4 = "ZFEXNMP4";

        /// <summary>
        /// ZFEXDT0.
        /// </summary>
        public const string ZFEXDT0 = "ZFEXDT0";

        /// <summary>
        /// ZFEXDT1.
        /// </summary>
        public const string ZFEXDT1 = "ZFEXDT1";

        /// <summary>
        /// ZFEXDT2.
        /// </summary>
        public const string ZFEXDT2 = "ZFEXDT2";

        /// <summary>
        /// ZFEXDT3.
        /// </summary>
        public const string ZFEXDT3 = "ZFEXDT3";

        /// <summary>
        /// ZFEXDT4.
        /// </summary>
        public const string ZFEXDT4 = "ZFEXDT4";

        /// <summary>
        /// ZFSTSUDT.
        /// </summary>
        public const string ZFSTSUDT = "ZFSTSUDT";

        /// <summary>
        /// ZFACTIND.
        /// </summary>
        public const string ZFACTIND = "ZFACTIND";

        /// <summary>
        /// ZFUSER.
        /// </summary>
        public const string ZFUSER = "ZFUSER";

        /// <summary>
        /// ZFPID.
        /// </summary>
        public const string ZFPID = "ZFPID";

        /// <summary>
        /// ZFVID.
        /// </summary>
        public const string ZFVID = "ZFVID";

        /// <summary>
        /// ZFMKEY.
        /// </summary>
        public const string ZFMKEY = "ZFMKEY";

        /// <summary>
        /// ZFUDTTM.
        /// </summary>
        public const string ZFUDTTM = "ZFUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB06Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZFCFGSID", "ZFCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("ZFOPPID", "ZFOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZFFCID", "ZFFCID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZFDSCRP1", "ZFDSCRP1", JdeDataType.String, 100),
        new JdeField("ZFOPTYCD", "ZFOPTYCD", JdeDataType.String, 10),
        new JdeField("ZFCAMPID", "ZFCAMPID", JdeDataType.Numeric),
        new JdeField("ZFEVTID", "ZFEVTID", JdeDataType.Numeric),
        new JdeField("ZFPRAN8", "ZFPRAN8", JdeDataType.Numeric),
        new JdeField("ZFPRCIDLN", "ZFPRCIDLN", JdeDataType.Numeric),
        new JdeField("ZFCUAN8", "ZFCUAN8", JdeDataType.Numeric),
        new JdeField("ZFCCIDLN", "ZFCCIDLN", JdeDataType.Numeric),
        new JdeField("ZFCUSAN8", "ZFCUSAN8", JdeDataType.Numeric),
        new JdeField("ZFSHCCIDLN", "ZFSHCCIDLN", JdeDataType.Numeric),
        new JdeField("ZFLTAN8", "ZFLTAN8", JdeDataType.Numeric),
        new JdeField("ZFQUFID", "ZFQUFID", JdeDataType.Numeric),
        new JdeField("ZFQUFSCR", "ZFQUFSCR", JdeDataType.Numeric),
        new JdeField("ZFQUFGL", "ZFQUFGL", JdeDataType.Numeric),
        new JdeField("ZFSMEID", "ZFSMEID", JdeDataType.Numeric),
        new JdeField("ZFSLCYID", "ZFSLCYID", JdeDataType.Numeric),
        new JdeField("ZFPBLTY", "ZFPBLTY", JdeDataType.Numeric),
        new JdeField("ZFCLDATE", "ZFCLDATE", JdeDataType.Date),
        new JdeField("ZFBDAMT", "ZFBDAMT", JdeDataType.Numeric),
        new JdeField("ZFPTAMT", "ZFPTAMT", JdeDataType.Numeric),
        new JdeField("ZFCRCD", "ZFCRCD", JdeDataType.String, 6),
        new JdeField("ZFLRTXT", "ZFLRTXT", JdeDataType.String, 200),
        new JdeField("ZFSTSCD", "ZFSTSCD", JdeDataType.String, 10),
        new JdeField("ZFOPMCU", "ZFOPMCU", JdeDataType.String, 24),
        new JdeField("ZFLITOT", "ZFLITOT", JdeDataType.Numeric),
        new JdeField("ZFLOBCO", "ZFLOBCO", JdeDataType.String, 10),
        new JdeField("ZFLEADSRC", "ZFLEADSRC", JdeDataType.String, 6),
        new JdeField("ZFENTDBY", "ZFENTDBY", JdeDataType.Numeric),
        new JdeField("ZFEDATE", "ZFEDATE", JdeDataType.Date),
        new JdeField("ZFEXVAR0", "ZFEXVAR0", JdeDataType.String, 510),
        new JdeField("ZFEXVAR1", "ZFEXVAR1", JdeDataType.String, 510),
        new JdeField("ZFEXVAR2", "ZFEXVAR2", JdeDataType.String, 510),
        new JdeField("ZFEXVAR3", "ZFEXVAR3", JdeDataType.String, 510),
        new JdeField("ZFEXVAR4", "ZFEXVAR4", JdeDataType.String, 100),
        new JdeField("ZFEXVAR5", "ZFEXVAR5", JdeDataType.String, 100),
        new JdeField("ZFEXVAR6", "ZFEXVAR6", JdeDataType.String, 100),
        new JdeField("ZFEXVAR7", "ZFEXVAR7", JdeDataType.String, 100),
        new JdeField("ZFEXVAR8", "ZFEXVAR8", JdeDataType.String, 100),
        new JdeField("ZFEXVAR9", "ZFEXVAR9", JdeDataType.String, 100),
        new JdeField("ZFEXVAR10", "ZFEXVAR10", JdeDataType.String, 100),
        new JdeField("ZFEXVAR11", "ZFEXVAR11", JdeDataType.String, 100),
        new JdeField("ZFEXVAR12", "ZFEXVAR12", JdeDataType.String, 50),
        new JdeField("ZFEXVAR13", "ZFEXVAR13", JdeDataType.String, 50),
        new JdeField("ZFEXVAR14", "ZFEXVAR14", JdeDataType.String, 50),
        new JdeField("ZFEXNM0", "ZFEXNM0", JdeDataType.Numeric),
        new JdeField("ZFEXNM1", "ZFEXNM1", JdeDataType.Numeric),
        new JdeField("ZFEXNM2", "ZFEXNM2", JdeDataType.Numeric),
        new JdeField("ZFEXNM3", "ZFEXNM3", JdeDataType.Numeric),
        new JdeField("ZFEXNM4", "ZFEXNM4", JdeDataType.Numeric),
        new JdeField("ZFEXNMP0", "ZFEXNMP0", JdeDataType.Numeric),
        new JdeField("ZFEXNMP1", "ZFEXNMP1", JdeDataType.Numeric),
        new JdeField("ZFEXNMP2", "ZFEXNMP2", JdeDataType.Numeric),
        new JdeField("ZFEXNMP3", "ZFEXNMP3", JdeDataType.Numeric),
        new JdeField("ZFEXNMP4", "ZFEXNMP4", JdeDataType.Numeric),
        new JdeField("ZFEXDT0", "ZFEXDT0", JdeDataType.Date),
        new JdeField("ZFEXDT1", "ZFEXDT1", JdeDataType.Date),
        new JdeField("ZFEXDT2", "ZFEXDT2", JdeDataType.Date),
        new JdeField("ZFEXDT3", "ZFEXDT3", JdeDataType.Date),
        new JdeField("ZFEXDT4", "ZFEXDT4", JdeDataType.Date),
        new JdeField("ZFSTSUDT", "ZFSTSUDT", JdeDataType.Date),
        new JdeField("ZFACTIND", "ZFACTIND", JdeDataType.String, 2),
        new JdeField("ZFUSER", "ZFUSER", JdeDataType.String, 20),
        new JdeField("ZFPID", "ZFPID", JdeDataType.String, 20),
        new JdeField("ZFVID", "ZFVID", JdeDataType.String, 20),
        new JdeField("ZFMKEY", "ZFMKEY", JdeDataType.String, 30),
        new JdeField("ZFUDTTM", "ZFUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB06Z_0", "Primary Key on ZFCFGSID, ZFFCID, ZFOPPID", new[] { "ZFCFGSID", "ZFFCID", "ZFOPPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB06Z_2", "Index on ZFFCID, ZFCFGSID, ZFOPPID", new[] { "ZFFCID", "ZFCFGSID", "ZFOPPID" })
    };
}
