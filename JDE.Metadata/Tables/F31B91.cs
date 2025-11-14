using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B91 - .
/// </summary>
public class F31B91 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLWVID.
        /// </summary>
        public const string BLWVID = "BLWVID";

        /// <summary>
        /// BLWVNUM.
        /// </summary>
        public const string BLWVNUM = "BLWVNUM";

        /// <summary>
        /// BLMATYP.
        /// </summary>
        public const string BLMATYP = "BLMATYP";

        /// <summary>
        /// BLMCUSHIP.
        /// </summary>
        public const string BLMCUSHIP = "BLMCUSHIP";

        /// <summary>
        /// BLMCUREC.
        /// </summary>
        public const string BLMCUREC = "BLMCUREC";

        /// <summary>
        /// BLSRCEID.
        /// </summary>
        public const string BLSRCEID = "BLSRCEID";

        /// <summary>
        /// BLSRCETYPE.
        /// </summary>
        public const string BLSRCETYPE = "BLSRCETYPE";

        /// <summary>
        /// BLBMRSFLAG.
        /// </summary>
        public const string BLBMRSFLAG = "BLBMRSFLAG";

        /// <summary>
        /// BLWAVL.
        /// </summary>
        public const string BLWAVL = "BLWAVL";

        /// <summary>
        /// BLWVUM.
        /// </summary>
        public const string BLWVUM = "BLWVUM";

        /// <summary>
        /// BLWNMVH.
        /// </summary>
        public const string BLWNMVH = "BLWNMVH";

        /// <summary>
        /// BLGOAHL.
        /// </summary>
        public const string BLGOAHL = "BLGOAHL";

        /// <summary>
        /// BLWAVNUM.
        /// </summary>
        public const string BLWAVNUM = "BLWAVNUM";

        /// <summary>
        /// BLBMPODOCO.
        /// </summary>
        public const string BLBMPODOCO = "BLBMPODOCO";

        /// <summary>
        /// BLBMPOKCOO.
        /// </summary>
        public const string BLBMPOKCOO = "BLBMPOKCOO";

        /// <summary>
        /// BLBMPODCTO.
        /// </summary>
        public const string BLBMPODCTO = "BLBMPODCTO";

        /// <summary>
        /// BLBMPOSFXO.
        /// </summary>
        public const string BLBMPOSFXO = "BLBMPOSFXO";

        /// <summary>
        /// BLBMPOLNID.
        /// </summary>
        public const string BLBMPOLNID = "BLBMPOLNID";

        /// <summary>
        /// BLBMPOLOCN.
        /// </summary>
        public const string BLBMPOLOCN = "BLBMPOLOCN";

        /// <summary>
        /// BLBMPOLOTN.
        /// </summary>
        public const string BLBMPOLOTN = "BLBMPOLOTN";

        /// <summary>
        /// BLBMSODOCO.
        /// </summary>
        public const string BLBMSODOCO = "BLBMSODOCO";

        /// <summary>
        /// BLBMSOKCOO.
        /// </summary>
        public const string BLBMSOKCOO = "BLBMSOKCOO";

        /// <summary>
        /// BLBMSODCTO.
        /// </summary>
        public const string BLBMSODCTO = "BLBMSODCTO";

        /// <summary>
        /// BLBMSOLNID.
        /// </summary>
        public const string BLBMSOLNID = "BLBMSOLNID";

        /// <summary>
        /// BLBMSOLOCN.
        /// </summary>
        public const string BLBMSOLOCN = "BLBMSOLOCN";

        /// <summary>
        /// BLBMSOLOTN.
        /// </summary>
        public const string BLBMSOLOTN = "BLBMSOLOTN";

        /// <summary>
        /// BLWBOLCUS.
        /// </summary>
        public const string BLWBOLCUS = "BLWBOLCUS";

        /// <summary>
        /// BLWBOLSUP.
        /// </summary>
        public const string BLWBOLSUP = "BLWBOLSUP";

        /// <summary>
        /// BLWSPGV.
        /// </summary>
        public const string BLWSPGV = "BLWSPGV";

        /// <summary>
        /// BLWWTFT.
        /// </summary>
        public const string BLWWTFT = "BLWWTFT";

        /// <summary>
        /// BLEURID.
        /// </summary>
        public const string BLEURID = "BLEURID";

        /// <summary>
        /// BLURCD.
        /// </summary>
        public const string BLURCD = "BLURCD";

        /// <summary>
        /// BLURDT.
        /// </summary>
        public const string BLURDT = "BLURDT";

        /// <summary>
        /// BLURAT.
        /// </summary>
        public const string BLURAT = "BLURAT";

        /// <summary>
        /// BLURRF.
        /// </summary>
        public const string BLURRF = "BLURRF";

        /// <summary>
        /// BLURAB.
        /// </summary>
        public const string BLURAB = "BLURAB";

        /// <summary>
        /// BLWMDT.
        /// </summary>
        public const string BLWMDT = "BLWMDT";

        /// <summary>
        /// BLWNUM.
        /// </summary>
        public const string BLWNUM = "BLWNUM";

        /// <summary>
        /// BLWAB.
        /// </summary>
        public const string BLWAB = "BLWAB";

        /// <summary>
        /// BLWCD.
        /// </summary>
        public const string BLWCD = "BLWCD";

        /// <summary>
        /// BLWRF.
        /// </summary>
        public const string BLWRF = "BLWRF";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLJOBN.
        /// </summary>
        public const string BLJOBN = "BLJOBN";

        /// <summary>
        /// BLUPMJ.
        /// </summary>
        public const string BLUPMJ = "BLUPMJ";

        /// <summary>
        /// BLUPMT.
        /// </summary>
        public const string BLUPMT = "BLUPMT";

        /// <summary>
        /// BLNLIN.
        /// </summary>
        public const string BLNLIN = "BLNLIN";

        /// <summary>
        /// BLDOC.
        /// </summary>
        public const string BLDOC = "BLDOC";

        /// <summary>
        /// BLWTEMP.
        /// </summary>
        public const string BLWTEMP = "BLWTEMP";

        /// <summary>
        /// BLTEMPUOM.
        /// </summary>
        public const string BLTEMPUOM = "BLTEMPUOM";

        /// <summary>
        /// BLGRECID.
        /// </summary>
        public const string BLGRECID = "BLGRECID";

        /// <summary>
        /// BLBLACT.
        /// </summary>
        public const string BLBLACT = "BLBLACT";

        /// <summary>
        /// BLBMVLWBID.
        /// </summary>
        public const string BLBMVLWBID = "BLBMVLWBID";

        /// <summary>
        /// BLBMVLOPID.
        /// </summary>
        public const string BLBMVLOPID = "BLBMVLOPID";

        /// <summary>
        /// BLBMVLWVID.
        /// </summary>
        public const string BLBMVLWVID = "BLBMVLWVID";

        /// <summary>
        /// BLBMVLLOTN.
        /// </summary>
        public const string BLBMVLLOTN = "BLBMVLLOTN";

        /// <summary>
        /// BLBMVLWVTY.
        /// </summary>
        public const string BLBMVLWVTY = "BLBMVLWVTY";

        /// <summary>
        /// BLBMVLMCU.
        /// </summary>
        public const string BLBMVLMCU = "BLBMVLMCU";

        /// <summary>
        /// BLWGAGDOC.
        /// </summary>
        public const string BLWGAGDOC = "BLWGAGDOC";

        /// <summary>
        /// BLLOT1.
        /// </summary>
        public const string BLLOT1 = "BLLOT1";

        /// <summary>
        /// BLLOT2.
        /// </summary>
        public const string BLLOT2 = "BLLOT2";

        /// <summary>
        /// BLLOT3.
        /// </summary>
        public const string BLLOT3 = "BLLOT3";

        /// <summary>
        /// BLRLOT.
        /// </summary>
        public const string BLRLOT = "BLRLOT";

        /// <summary>
        /// BLSQOR.
        /// </summary>
        public const string BLSQOR = "BLSQOR";

        /// <summary>
        /// BLUOM2.
        /// </summary>
        public const string BLUOM2 = "BLUOM2";
    }

    /// <inheritdoc />
    public override string TableName => "F31B91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLWVID", "BLWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("BLWVNUM", "BLWVNUM", JdeDataType.String, 60),
        new JdeField("BLMATYP", "BLMATYP", JdeDataType.String, 8),
        new JdeField("BLMCUSHIP", "BLMCUSHIP", JdeDataType.String, 24),
        new JdeField("BLMCUREC", "BLMCUREC", JdeDataType.String, 24),
        new JdeField("BLSRCEID", "BLSRCEID", JdeDataType.Numeric),
        new JdeField("BLSRCETYPE", "BLSRCETYPE", JdeDataType.String, 6),
        new JdeField("BLBMRSFLAG", "BLBMRSFLAG", JdeDataType.String, 2),
        new JdeField("BLWAVL", "BLWAVL", JdeDataType.Numeric),
        new JdeField("BLWVUM", "BLWVUM", JdeDataType.String, 6),
        new JdeField("BLWNMVH", "BLWNMVH", JdeDataType.Numeric),
        new JdeField("BLGOAHL", "BLGOAHL", JdeDataType.Numeric),
        new JdeField("BLWAVNUM", "BLWAVNUM", JdeDataType.String, 60),
        new JdeField("BLBMPODOCO", "BLBMPODOCO", JdeDataType.Numeric),
        new JdeField("BLBMPOKCOO", "BLBMPOKCOO", JdeDataType.String, 10),
        new JdeField("BLBMPODCTO", "BLBMPODCTO", JdeDataType.String, 4),
        new JdeField("BLBMPOSFXO", "BLBMPOSFXO", JdeDataType.String, 6),
        new JdeField("BLBMPOLNID", "BLBMPOLNID", JdeDataType.Numeric),
        new JdeField("BLBMPOLOCN", "BLBMPOLOCN", JdeDataType.String, 40),
        new JdeField("BLBMPOLOTN", "BLBMPOLOTN", JdeDataType.String, 60),
        new JdeField("BLBMSODOCO", "BLBMSODOCO", JdeDataType.Numeric),
        new JdeField("BLBMSOKCOO", "BLBMSOKCOO", JdeDataType.String, 10),
        new JdeField("BLBMSODCTO", "BLBMSODCTO", JdeDataType.String, 4),
        new JdeField("BLBMSOLNID", "BLBMSOLNID", JdeDataType.Numeric),
        new JdeField("BLBMSOLOCN", "BLBMSOLOCN", JdeDataType.String, 40),
        new JdeField("BLBMSOLOTN", "BLBMSOLOTN", JdeDataType.String, 60),
        new JdeField("BLWBOLCUS", "BLWBOLCUS", JdeDataType.Numeric),
        new JdeField("BLWBOLSUP", "BLWBOLSUP", JdeDataType.Numeric),
        new JdeField("BLWSPGV", "BLWSPGV", JdeDataType.Numeric),
        new JdeField("BLWWTFT", "BLWWTFT", JdeDataType.Numeric),
        new JdeField("BLEURID", "BLEURID", JdeDataType.Numeric),
        new JdeField("BLURCD", "BLURCD", JdeDataType.String, 4),
        new JdeField("BLURDT", "BLURDT", JdeDataType.Numeric),
        new JdeField("BLURAT", "BLURAT", JdeDataType.Numeric),
        new JdeField("BLURRF", "BLURRF", JdeDataType.String, 30),
        new JdeField("BLURAB", "BLURAB", JdeDataType.Numeric),
        new JdeField("BLWMDT", "BLWMDT", JdeDataType.Numeric),
        new JdeField("BLWNUM", "BLWNUM", JdeDataType.Numeric),
        new JdeField("BLWAB", "BLWAB", JdeDataType.Numeric),
        new JdeField("BLWCD", "BLWCD", JdeDataType.String, 6),
        new JdeField("BLWRF", "BLWRF", JdeDataType.String, 60),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLJOBN", "BLJOBN", JdeDataType.String, 20),
        new JdeField("BLUPMJ", "BLUPMJ", JdeDataType.Numeric),
        new JdeField("BLUPMT", "BLUPMT", JdeDataType.Numeric),
        new JdeField("BLNLIN", "BLNLIN", JdeDataType.Numeric),
        new JdeField("BLDOC", "BLDOC", JdeDataType.Numeric),
        new JdeField("BLWTEMP", "BLWTEMP", JdeDataType.Numeric),
        new JdeField("BLTEMPUOM", "BLTEMPUOM", JdeDataType.String, 4),
        new JdeField("BLGRECID", "BLGRECID", JdeDataType.Numeric),
        new JdeField("BLBLACT", "BLBLACT", JdeDataType.String, 2),
        new JdeField("BLBMVLWBID", "BLBMVLWBID", JdeDataType.String, 60),
        new JdeField("BLBMVLOPID", "BLBMVLOPID", JdeDataType.Numeric),
        new JdeField("BLBMVLWVID", "BLBMVLWVID", JdeDataType.Numeric),
        new JdeField("BLBMVLLOTN", "BLBMVLLOTN", JdeDataType.String, 60),
        new JdeField("BLBMVLWVTY", "BLBMVLWVTY", JdeDataType.String, 2),
        new JdeField("BLBMVLMCU", "BLBMVLMCU", JdeDataType.String, 24),
        new JdeField("BLWGAGDOC", "BLWGAGDOC", JdeDataType.String, 60),
        new JdeField("BLLOT1", "BLLOT1", JdeDataType.String, 60),
        new JdeField("BLLOT2", "BLLOT2", JdeDataType.String, 60),
        new JdeField("BLLOT3", "BLLOT3", JdeDataType.String, 60),
        new JdeField("BLRLOT", "BLRLOT", JdeDataType.String, 60),
        new JdeField("BLSQOR", "BLSQOR", JdeDataType.Numeric),
        new JdeField("BLUOM2", "BLUOM2", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B91_0", "Primary Key on BLWVID", new[] { "BLWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B91_2", "Index on BLWVNUM, BLMCUREC", new[] { "BLWVNUM", "BLMCUREC" }),
        new JdeIndex("F31B91_3", "Index on BLWVNUM", new[] { "BLWVNUM" })
    };
}
