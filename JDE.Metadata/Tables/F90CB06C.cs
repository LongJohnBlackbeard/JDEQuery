using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB06C - .
/// </summary>
public class F90CB06C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OHFCID.
        /// </summary>
        public const string OHFCID = "OHFCID";

        /// <summary>
        /// OHOPPID.
        /// </summary>
        public const string OHOPPID = "OHOPPID";

        /// <summary>
        /// OHSEQNU.
        /// </summary>
        public const string OHSEQNU = "OHSEQNU";

        /// <summary>
        /// OHCUAN8.
        /// </summary>
        public const string OHCUAN8 = "OHCUAN8";

        /// <summary>
        /// OHCUSAN8.
        /// </summary>
        public const string OHCUSAN8 = "OHCUSAN8";

        /// <summary>
        /// OHITMHID.
        /// </summary>
        public const string OHITMHID = "OHITMHID";

        /// <summary>
        /// OHCATL.
        /// </summary>
        public const string OHCATL = "OHCATL";

        /// <summary>
        /// OHITM.
        /// </summary>
        public const string OHITM = "OHITM";

        /// <summary>
        /// OHLITM.
        /// </summary>
        public const string OHLITM = "OHLITM";

        /// <summary>
        /// OHLNID.
        /// </summary>
        public const string OHLNID = "OHLNID";

        /// <summary>
        /// OHITQTY.
        /// </summary>
        public const string OHITQTY = "OHITQTY";

        /// <summary>
        /// OHITUOM.
        /// </summary>
        public const string OHITUOM = "OHITUOM";

        /// <summary>
        /// OHPRUOM.
        /// </summary>
        public const string OHPRUOM = "OHPRUOM";

        /// <summary>
        /// OHACTPRC.
        /// </summary>
        public const string OHACTPRC = "OHACTPRC";

        /// <summary>
        /// OHPCE.
        /// </summary>
        public const string OHPCE = "OHPCE";

        /// <summary>
        /// OHTITMPR.
        /// </summary>
        public const string OHTITMPR = "OHTITMPR";

        /// <summary>
        /// OHPRCRCD.
        /// </summary>
        public const string OHPRCRCD = "OHPRCRCD";

        /// <summary>
        /// OHTICRCD.
        /// </summary>
        public const string OHTICRCD = "OHTICRCD";

        /// <summary>
        /// OHOVRBP.
        /// </summary>
        public const string OHOVRBP = "OHOVRBP";

        /// <summary>
        /// OHOPMCU.
        /// </summary>
        public const string OHOPMCU = "OHOPMCU";

        /// <summary>
        /// OHOVPRFL.
        /// </summary>
        public const string OHOVPRFL = "OHOVPRFL";

        /// <summary>
        /// OHLFLNTY.
        /// </summary>
        public const string OHLFLNTY = "OHLFLNTY";

        /// <summary>
        /// OHMSCHGF.
        /// </summary>
        public const string OHMSCHGF = "OHMSCHGF";

        /// <summary>
        /// OHDSCRP2.
        /// </summary>
        public const string OHDSCRP2 = "OHDSCRP2";

        /// <summary>
        /// OHRDATE.
        /// </summary>
        public const string OHRDATE = "OHRDATE";

        /// <summary>
        /// OHCFGFLG.
        /// </summary>
        public const string OHCFGFLG = "OHCFGFLG";

        /// <summary>
        /// OHMCHITM.
        /// </summary>
        public const string OHMCHITM = "OHMCHITM";

        /// <summary>
        /// OHENTDBY.
        /// </summary>
        public const string OHENTDBY = "OHENTDBY";

        /// <summary>
        /// OHMODB.
        /// </summary>
        public const string OHMODB = "OHMODB";

        /// <summary>
        /// OHEDATE.
        /// </summary>
        public const string OHEDATE = "OHEDATE";

        /// <summary>
        /// OHMDATE.
        /// </summary>
        public const string OHMDATE = "OHMDATE";

        /// <summary>
        /// OHEXVAR0.
        /// </summary>
        public const string OHEXVAR0 = "OHEXVAR0";

        /// <summary>
        /// OHEXVAR1.
        /// </summary>
        public const string OHEXVAR1 = "OHEXVAR1";

        /// <summary>
        /// OHEXVAR4.
        /// </summary>
        public const string OHEXVAR4 = "OHEXVAR4";

        /// <summary>
        /// OHEXVAR5.
        /// </summary>
        public const string OHEXVAR5 = "OHEXVAR5";

        /// <summary>
        /// OHEXVAR6.
        /// </summary>
        public const string OHEXVAR6 = "OHEXVAR6";

        /// <summary>
        /// OHEXVAR7.
        /// </summary>
        public const string OHEXVAR7 = "OHEXVAR7";

        /// <summary>
        /// OHEXVAR12.
        /// </summary>
        public const string OHEXVAR12 = "OHEXVAR12";

        /// <summary>
        /// OHEXVAR13.
        /// </summary>
        public const string OHEXVAR13 = "OHEXVAR13";

        /// <summary>
        /// OHEXNM0.
        /// </summary>
        public const string OHEXNM0 = "OHEXNM0";

        /// <summary>
        /// OHEXNM1.
        /// </summary>
        public const string OHEXNM1 = "OHEXNM1";

        /// <summary>
        /// OHEXNM2.
        /// </summary>
        public const string OHEXNM2 = "OHEXNM2";

        /// <summary>
        /// OHEXNMP0.
        /// </summary>
        public const string OHEXNMP0 = "OHEXNMP0";

        /// <summary>
        /// OHEXNMP1.
        /// </summary>
        public const string OHEXNMP1 = "OHEXNMP1";

        /// <summary>
        /// OHEXNMP2.
        /// </summary>
        public const string OHEXNMP2 = "OHEXNMP2";

        /// <summary>
        /// OHEXDT0.
        /// </summary>
        public const string OHEXDT0 = "OHEXDT0";

        /// <summary>
        /// OHEXDT1.
        /// </summary>
        public const string OHEXDT1 = "OHEXDT1";

        /// <summary>
        /// OHEXDT2.
        /// </summary>
        public const string OHEXDT2 = "OHEXDT2";

        /// <summary>
        /// OHSTSUDT.
        /// </summary>
        public const string OHSTSUDT = "OHSTSUDT";

        /// <summary>
        /// OHACTIND.
        /// </summary>
        public const string OHACTIND = "OHACTIND";

        /// <summary>
        /// OHUSER.
        /// </summary>
        public const string OHUSER = "OHUSER";

        /// <summary>
        /// OHPID.
        /// </summary>
        public const string OHPID = "OHPID";

        /// <summary>
        /// OHVID.
        /// </summary>
        public const string OHVID = "OHVID";

        /// <summary>
        /// OHMKEY.
        /// </summary>
        public const string OHMKEY = "OHMKEY";

        /// <summary>
        /// OHUDTTM.
        /// </summary>
        public const string OHUDTTM = "OHUDTTM";

        /// <summary>
        /// OHUKID.
        /// </summary>
        public const string OHUKID = "OHUKID";

        /// <summary>
        /// OHOSTP.
        /// </summary>
        public const string OHOSTP = "OHOSTP";

        /// <summary>
        /// OHCATNM.
        /// </summary>
        public const string OHCATNM = "OHCATNM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB06C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OHFCID", "OHFCID", JdeDataType.Numeric, null, true, true),
        new JdeField("OHOPPID", "OHOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OHSEQNU", "OHSEQNU", JdeDataType.Numeric, null, true, true),
        new JdeField("OHCUAN8", "OHCUAN8", JdeDataType.Numeric),
        new JdeField("OHCUSAN8", "OHCUSAN8", JdeDataType.Numeric),
        new JdeField("OHITMHID", "OHITMHID", JdeDataType.Numeric),
        new JdeField("OHCATL", "OHCATL", JdeDataType.String, 60),
        new JdeField("OHITM", "OHITM", JdeDataType.Numeric),
        new JdeField("OHLITM", "OHLITM", JdeDataType.String, 50),
        new JdeField("OHLNID", "OHLNID", JdeDataType.Numeric),
        new JdeField("OHITQTY", "OHITQTY", JdeDataType.Numeric),
        new JdeField("OHITUOM", "OHITUOM", JdeDataType.String, 20),
        new JdeField("OHPRUOM", "OHPRUOM", JdeDataType.String, 20),
        new JdeField("OHACTPRC", "OHACTPRC", JdeDataType.Numeric),
        new JdeField("OHPCE", "OHPCE", JdeDataType.Numeric),
        new JdeField("OHTITMPR", "OHTITMPR", JdeDataType.Numeric),
        new JdeField("OHPRCRCD", "OHPRCRCD", JdeDataType.String, 6),
        new JdeField("OHTICRCD", "OHTICRCD", JdeDataType.String, 6),
        new JdeField("OHOVRBP", "OHOVRBP", JdeDataType.String, 2),
        new JdeField("OHOPMCU", "OHOPMCU", JdeDataType.String, 24),
        new JdeField("OHOVPRFL", "OHOVPRFL", JdeDataType.String, 2),
        new JdeField("OHLFLNTY", "OHLFLNTY", JdeDataType.String, 4),
        new JdeField("OHMSCHGF", "OHMSCHGF", JdeDataType.String, 2),
        new JdeField("OHDSCRP2", "OHDSCRP2", JdeDataType.String, 60),
        new JdeField("OHRDATE", "OHRDATE", JdeDataType.Date),
        new JdeField("OHCFGFLG", "OHCFGFLG", JdeDataType.String, 2),
        new JdeField("OHMCHITM", "OHMCHITM", JdeDataType.Numeric),
        new JdeField("OHENTDBY", "OHENTDBY", JdeDataType.Numeric),
        new JdeField("OHMODB", "OHMODB", JdeDataType.Numeric),
        new JdeField("OHEDATE", "OHEDATE", JdeDataType.Date),
        new JdeField("OHMDATE", "OHMDATE", JdeDataType.Date),
        new JdeField("OHEXVAR0", "OHEXVAR0", JdeDataType.String, 510),
        new JdeField("OHEXVAR1", "OHEXVAR1", JdeDataType.String, 510),
        new JdeField("OHEXVAR4", "OHEXVAR4", JdeDataType.String, 100),
        new JdeField("OHEXVAR5", "OHEXVAR5", JdeDataType.String, 100),
        new JdeField("OHEXVAR6", "OHEXVAR6", JdeDataType.String, 100),
        new JdeField("OHEXVAR7", "OHEXVAR7", JdeDataType.String, 100),
        new JdeField("OHEXVAR12", "OHEXVAR12", JdeDataType.String, 50),
        new JdeField("OHEXVAR13", "OHEXVAR13", JdeDataType.String, 50),
        new JdeField("OHEXNM0", "OHEXNM0", JdeDataType.Numeric),
        new JdeField("OHEXNM1", "OHEXNM1", JdeDataType.Numeric),
        new JdeField("OHEXNM2", "OHEXNM2", JdeDataType.Numeric),
        new JdeField("OHEXNMP0", "OHEXNMP0", JdeDataType.Numeric),
        new JdeField("OHEXNMP1", "OHEXNMP1", JdeDataType.Numeric),
        new JdeField("OHEXNMP2", "OHEXNMP2", JdeDataType.Numeric),
        new JdeField("OHEXDT0", "OHEXDT0", JdeDataType.Date),
        new JdeField("OHEXDT1", "OHEXDT1", JdeDataType.Date),
        new JdeField("OHEXDT2", "OHEXDT2", JdeDataType.Date),
        new JdeField("OHSTSUDT", "OHSTSUDT", JdeDataType.Date),
        new JdeField("OHACTIND", "OHACTIND", JdeDataType.String, 2),
        new JdeField("OHUSER", "OHUSER", JdeDataType.String, 20),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20),
        new JdeField("OHVID", "OHVID", JdeDataType.String, 20),
        new JdeField("OHMKEY", "OHMKEY", JdeDataType.String, 30),
        new JdeField("OHUDTTM", "OHUDTTM", JdeDataType.Date),
        new JdeField("OHUKID", "OHUKID", JdeDataType.Numeric),
        new JdeField("OHOSTP", "OHOSTP", JdeDataType.String, 6),
        new JdeField("OHCATNM", "OHCATNM", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB06C_0", "Primary Key on OHOPPID, OHSEQNU, OHFCID", new[] { "OHOPPID", "OHSEQNU", "OHFCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB06C_2", "Index on OHFCID, OHOPPID, OHSEQNU", new[] { "OHFCID", "OHOPPID", "OHSEQNU" })
    };
}
