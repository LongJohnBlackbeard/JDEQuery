using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4817 - .
/// </summary>
public class F4817 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRDOCO.
        /// </summary>
        public const string SRDOCO = "SRDOCO";

        /// <summary>
        /// SRISSUE.
        /// </summary>
        public const string SRISSUE = "SRISSUE";

        /// <summary>
        /// SRPRODM.
        /// </summary>
        public const string SRPRODM = "SRPRODM";

        /// <summary>
        /// SRWHO2.
        /// </summary>
        public const string SRWHO2 = "SRWHO2";

        /// <summary>
        /// SRAR1.
        /// </summary>
        public const string SRAR1 = "SRAR1";

        /// <summary>
        /// SRPHN1.
        /// </summary>
        public const string SRPHN1 = "SRPHN1";

        /// <summary>
        /// SRTMCO.
        /// </summary>
        public const string SRTMCO = "SRTMCO";

        /// <summary>
        /// SRSCALL.
        /// </summary>
        public const string SRSCALL = "SRSCALL";

        /// <summary>
        /// SRMTHPR.
        /// </summary>
        public const string SRMTHPR = "SRMTHPR";

        /// <summary>
        /// SRENTCK.
        /// </summary>
        public const string SRENTCK = "SRENTCK";

        /// <summary>
        /// SRGWAUT.
        /// </summary>
        public const string SRGWAUT = "SRGWAUT";

        /// <summary>
        /// SRRYIN.
        /// </summary>
        public const string SRRYIN = "SRRYIN";

        /// <summary>
        /// SRRSTM.
        /// </summary>
        public const string SRRSTM = "SRRSTM";

        /// <summary>
        /// SRCTR.
        /// </summary>
        public const string SRCTR = "SRCTR";

        /// <summary>
        /// SRREGION.
        /// </summary>
        public const string SRREGION = "SRREGION";

        /// <summary>
        /// SRTXA1.
        /// </summary>
        public const string SRTXA1 = "SRTXA1";

        /// <summary>
        /// SREXR1.
        /// </summary>
        public const string SREXR1 = "SREXR1";

        /// <summary>
        /// SRLNGP.
        /// </summary>
        public const string SRLNGP = "SRLNGP";

        /// <summary>
        /// SRGLCCV.
        /// </summary>
        public const string SRGLCCV = "SRGLCCV";

        /// <summary>
        /// SRGLCNC.
        /// </summary>
        public const string SRGLCNC = "SRGLCNC";

        /// <summary>
        /// SRISNO.
        /// </summary>
        public const string SRISNO = "SRISNO";

        /// <summary>
        /// SRDOC.
        /// </summary>
        public const string SRDOC = "SRDOC";

        /// <summary>
        /// SRDCT.
        /// </summary>
        public const string SRDCT = "SRDCT";

        /// <summary>
        /// SRKCO.
        /// </summary>
        public const string SRKCO = "SRKCO";

        /// <summary>
        /// SRCOCH.
        /// </summary>
        public const string SRCOCH = "SRCOCH";

        /// <summary>
        /// SRLNID.
        /// </summary>
        public const string SRLNID = "SRLNID";

        /// <summary>
        /// SRCRTU.
        /// </summary>
        public const string SRCRTU = "SRCRTU";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRTDAY.
        /// </summary>
        public const string SRTDAY = "SRTDAY";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRCOVGR.
        /// </summary>
        public const string SRCOVGR = "SRCOVGR";

        /// <summary>
        /// SRASN4.
        /// </summary>
        public const string SRASN4 = "SRASN4";

        /// <summary>
        /// SRASN2.
        /// </summary>
        public const string SRASN2 = "SRASN2";

        /// <summary>
        /// SRSEST.
        /// </summary>
        public const string SRSEST = "SRSEST";

        /// <summary>
        /// SRSEET.
        /// </summary>
        public const string SRSEET = "SRSEET";

        /// <summary>
        /// SRDSAVNAME.
        /// </summary>
        public const string SRDSAVNAME = "SRDSAVNAME";

        /// <summary>
        /// SRTIMEZONES.
        /// </summary>
        public const string SRTIMEZONES = "SRTIMEZONES";

        /// <summary>
        /// SRCSLPRT.
        /// </summary>
        public const string SRCSLPRT = "SRCSLPRT";

        /// <summary>
        /// SRFAILCD.
        /// </summary>
        public const string SRFAILCD = "SRFAILCD";

        /// <summary>
        /// SRAN8AS.
        /// </summary>
        public const string SRAN8AS = "SRAN8AS";

        /// <summary>
        /// SRAN8SRM.
        /// </summary>
        public const string SRAN8SRM = "SRAN8SRM";

        /// <summary>
        /// SRFAILDT.
        /// </summary>
        public const string SRFAILDT = "SRFAILDT";

        /// <summary>
        /// SRFAILTM.
        /// </summary>
        public const string SRFAILTM = "SRFAILTM";

        /// <summary>
        /// SRREPDT.
        /// </summary>
        public const string SRREPDT = "SRREPDT";

        /// <summary>
        /// SRREPTM.
        /// </summary>
        public const string SRREPTM = "SRREPTM";

        /// <summary>
        /// SRVEND.
        /// </summary>
        public const string SRVEND = "SRVEND";

        /// <summary>
        /// SRPRODF.
        /// </summary>
        public const string SRPRODF = "SRPRODF";

        /// <summary>
        /// SRRMTHD.
        /// </summary>
        public const string SRRMTHD = "SRRMTHD";

        /// <summary>
        /// SRSRYN.
        /// </summary>
        public const string SRSRYN = "SRSRYN";

        /// <summary>
        /// SRCRDC.
        /// </summary>
        public const string SRCRDC = "SRCRDC";

        /// <summary>
        /// SRCRCD.
        /// </summary>
        public const string SRCRCD = "SRCRCD";

        /// <summary>
        /// SRCRRM.
        /// </summary>
        public const string SRCRRM = "SRCRRM";

        /// <summary>
        /// SRCRR.
        /// </summary>
        public const string SRCRR = "SRCRR";

        /// <summary>
        /// SRENTCKS.
        /// </summary>
        public const string SRENTCKS = "SRENTCKS";

        /// <summary>
        /// SRKNLTD.
        /// </summary>
        public const string SRKNLTD = "SRKNLTD";

        /// <summary>
        /// SRUKID.
        /// </summary>
        public const string SRUKID = "SRUKID";

        /// <summary>
        /// SRVMRS31.
        /// </summary>
        public const string SRVMRS31 = "SRVMRS31";

        /// <summary>
        /// SRVMRS32.
        /// </summary>
        public const string SRVMRS32 = "SRVMRS32";

        /// <summary>
        /// SRMCUCSL.
        /// </summary>
        public const string SRMCUCSL = "SRMCUCSL";

        /// <summary>
        /// SRRLOT.
        /// </summary>
        public const string SRRLOT = "SRRLOT";

        /// <summary>
        /// SRCURBALM1.
        /// </summary>
        public const string SRCURBALM1 = "SRCURBALM1";

        /// <summary>
        /// SRCURBALM2.
        /// </summary>
        public const string SRCURBALM2 = "SRCURBALM2";

        /// <summary>
        /// SRCURBALM3.
        /// </summary>
        public const string SRCURBALM3 = "SRCURBALM3";
    }

    /// <inheritdoc />
    public override string TableName => "F4817";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRDOCO", "SRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SRISSUE", "SRISSUE", JdeDataType.String, 160),
        new JdeField("SRPRODM", "SRPRODM", JdeDataType.String, 16),
        new JdeField("SRWHO2", "SRWHO2", JdeDataType.String, 80),
        new JdeField("SRAR1", "SRAR1", JdeDataType.String, 12),
        new JdeField("SRPHN1", "SRPHN1", JdeDataType.String, 40),
        new JdeField("SRTMCO", "SRTMCO", JdeDataType.Numeric),
        new JdeField("SRSCALL", "SRSCALL", JdeDataType.String, 2),
        new JdeField("SRMTHPR", "SRMTHPR", JdeDataType.String, 2),
        new JdeField("SRENTCK", "SRENTCK", JdeDataType.String, 6),
        new JdeField("SRGWAUT", "SRGWAUT", JdeDataType.String, 8),
        new JdeField("SRRYIN", "SRRYIN", JdeDataType.String, 2),
        new JdeField("SRRSTM", "SRRSTM", JdeDataType.Numeric),
        new JdeField("SRCTR", "SRCTR", JdeDataType.String, 6),
        new JdeField("SRREGION", "SRREGION", JdeDataType.String, 6),
        new JdeField("SRTXA1", "SRTXA1", JdeDataType.String, 20),
        new JdeField("SREXR1", "SREXR1", JdeDataType.String, 4),
        new JdeField("SRLNGP", "SRLNGP", JdeDataType.String, 4),
        new JdeField("SRGLCCV", "SRGLCCV", JdeDataType.String, 8),
        new JdeField("SRGLCNC", "SRGLCNC", JdeDataType.String, 8),
        new JdeField("SRISNO", "SRISNO", JdeDataType.Numeric),
        new JdeField("SRDOC", "SRDOC", JdeDataType.Numeric),
        new JdeField("SRDCT", "SRDCT", JdeDataType.String, 4),
        new JdeField("SRKCO", "SRKCO", JdeDataType.String, 10),
        new JdeField("SRCOCH", "SRCOCH", JdeDataType.String, 6),
        new JdeField("SRLNID", "SRLNID", JdeDataType.Numeric),
        new JdeField("SRCRTU", "SRCRTU", JdeDataType.String, 20),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRTDAY", "SRTDAY", JdeDataType.Numeric),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRCOVGR", "SRCOVGR", JdeDataType.String, 16),
        new JdeField("SRASN4", "SRASN4", JdeDataType.String, 16),
        new JdeField("SRASN2", "SRASN2", JdeDataType.String, 16),
        new JdeField("SRSEST", "SRSEST", JdeDataType.Numeric),
        new JdeField("SRSEET", "SRSEET", JdeDataType.Numeric),
        new JdeField("SRDSAVNAME", "SRDSAVNAME", JdeDataType.String, 20),
        new JdeField("SRTIMEZONES", "SRTIMEZONES", JdeDataType.String, 4),
        new JdeField("SRCSLPRT", "SRCSLPRT", JdeDataType.Numeric),
        new JdeField("SRFAILCD", "SRFAILCD", JdeDataType.String, 16),
        new JdeField("SRAN8AS", "SRAN8AS", JdeDataType.Numeric),
        new JdeField("SRAN8SRM", "SRAN8SRM", JdeDataType.Numeric),
        new JdeField("SRFAILDT", "SRFAILDT", JdeDataType.Numeric),
        new JdeField("SRFAILTM", "SRFAILTM", JdeDataType.Numeric),
        new JdeField("SRREPDT", "SRREPDT", JdeDataType.Numeric),
        new JdeField("SRREPTM", "SRREPTM", JdeDataType.Numeric),
        new JdeField("SRVEND", "SRVEND", JdeDataType.Numeric),
        new JdeField("SRPRODF", "SRPRODF", JdeDataType.String, 16),
        new JdeField("SRRMTHD", "SRRMTHD", JdeDataType.String, 2),
        new JdeField("SRSRYN", "SRSRYN", JdeDataType.String, 2),
        new JdeField("SRCRDC", "SRCRDC", JdeDataType.String, 6),
        new JdeField("SRCRCD", "SRCRCD", JdeDataType.String, 6),
        new JdeField("SRCRRM", "SRCRRM", JdeDataType.String, 2),
        new JdeField("SRCRR", "SRCRR", JdeDataType.Numeric),
        new JdeField("SRENTCKS", "SRENTCKS", JdeDataType.String, 6),
        new JdeField("SRKNLTD", "SRKNLTD", JdeDataType.String, 20),
        new JdeField("SRUKID", "SRUKID", JdeDataType.Numeric),
        new JdeField("SRVMRS31", "SRVMRS31", JdeDataType.String, 4),
        new JdeField("SRVMRS32", "SRVMRS32", JdeDataType.String, 16),
        new JdeField("SRMCUCSL", "SRMCUCSL", JdeDataType.String, 24),
        new JdeField("SRRLOT", "SRRLOT", JdeDataType.String, 60),
        new JdeField("SRCURBALM1", "SRCURBALM1", JdeDataType.Numeric),
        new JdeField("SRCURBALM2", "SRCURBALM2", JdeDataType.Numeric),
        new JdeField("SRCURBALM3", "SRCURBALM3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4817_0", "Primary Key on SRDOCO", new[] { "SRDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4817_2", "Index on SRPRODM", new[] { "SRPRODM" }),
        new JdeIndex("F4817_3", "Index on SRFAILCD", new[] { "SRFAILCD" })
    };
}
