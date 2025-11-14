using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B03 - .
/// </summary>
public class F31B03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BMBATP.
        /// </summary>
        public const string BMBATP = "BMBATP";

        /// <summary>
        /// BMBATV.
        /// </summary>
        public const string BMBATV = "BMBATV";

        /// <summary>
        /// BMBPCO.
        /// </summary>
        public const string BMBPCO = "BMBPCO";

        /// <summary>
        /// BMMCU.
        /// </summary>
        public const string BMMCU = "BMMCU";

        /// <summary>
        /// BMBARID.
        /// </summary>
        public const string BMBARID = "BMBARID";

        /// <summary>
        /// BMBARCN.
        /// </summary>
        public const string BMBARCN = "BMBARCN";

        /// <summary>
        /// BMVBID.
        /// </summary>
        public const string BMVBID = "BMVBID";

        /// <summary>
        /// BMIDNOFR.
        /// </summary>
        public const string BMIDNOFR = "BMIDNOFR";

        /// <summary>
        /// BMRKNUM.
        /// </summary>
        public const string BMRKNUM = "BMRKNUM";

        /// <summary>
        /// BMIDMTHD.
        /// </summary>
        public const string BMIDMTHD = "BMIDMTHD";

        /// <summary>
        /// BMLOCN.
        /// </summary>
        public const string BMLOCN = "BMLOCN";

        /// <summary>
        /// BMWODOC.
        /// </summary>
        public const string BMWODOC = "BMWODOC";

        /// <summary>
        /// BMCTRO.
        /// </summary>
        public const string BMCTRO = "BMCTRO";

        /// <summary>
        /// BMOLOC.
        /// </summary>
        public const string BMOLOC = "BMOLOC";

        /// <summary>
        /// BMBCST.
        /// </summary>
        public const string BMBCST = "BMBCST";

        /// <summary>
        /// BMRECY.
        /// </summary>
        public const string BMRECY = "BMRECY";

        /// <summary>
        /// BMOYRC.
        /// </summary>
        public const string BMOYRC = "BMOYRC";

        /// <summary>
        /// BMBARCO.
        /// </summary>
        public const string BMBARCO = "BMBARCO";

        /// <summary>
        /// BMPOWN.
        /// </summary>
        public const string BMPOWN = "BMPOWN";

        /// <summary>
        /// BMSUPL.
        /// </summary>
        public const string BMSUPL = "BMSUPL";

        /// <summary>
        /// BMCPNUM.
        /// </summary>
        public const string BMCPNUM = "BMCPNUM";

        /// <summary>
        /// BMFORES.
        /// </summary>
        public const string BMFORES = "BMFORES";

        /// <summary>
        /// BMTLEV.
        /// </summary>
        public const string BMTLEV = "BMTLEV";

        /// <summary>
        /// BMTSTH.
        /// </summary>
        public const string BMTSTH = "BMTSTH";

        /// <summary>
        /// BMTOCAP.
        /// </summary>
        public const string BMTOCAP = "BMTOCAP";

        /// <summary>
        /// BMBCUOM.
        /// </summary>
        public const string BMBCUOM = "BMBCUOM";

        /// <summary>
        /// BMFCAP.
        /// </summary>
        public const string BMFCAP = "BMFCAP";

        /// <summary>
        /// BMNUMHP.
        /// </summary>
        public const string BMNUMHP = "BMNUMHP";

        /// <summary>
        /// BMSCTM.
        /// </summary>
        public const string BMSCTM = "BMSCTM";

        /// <summary>
        /// BMSTAVT.
        /// </summary>
        public const string BMSTAVT = "BMSTAVT";

        /// <summary>
        /// BMSDRM.
        /// </summary>
        public const string BMSDRM = "BMSDRM";

        /// <summary>
        /// BMSBDM.
        /// </summary>
        public const string BMSBDM = "BMSBDM";

        /// <summary>
        /// BMSDRL.
        /// </summary>
        public const string BMSDRL = "BMSDRL";

        /// <summary>
        /// BMSDDR.
        /// </summary>
        public const string BMSDDR = "BMSDDR";

        /// <summary>
        /// BMBSMK.
        /// </summary>
        public const string BMBSMK = "BMBSMK";

        /// <summary>
        /// BMGRAIN.
        /// </summary>
        public const string BMGRAIN = "BMGRAIN";

        /// <summary>
        /// BMBNMS.
        /// </summary>
        public const string BMBNMS = "BMBNMS";

        /// <summary>
        /// BMBAVC.
        /// </summary>
        public const string BMBAVC = "BMBAVC";

        /// <summary>
        /// BMAJRS.
        /// </summary>
        public const string BMAJRS = "BMAJRS";

        /// <summary>
        /// BMDAOS.
        /// </summary>
        public const string BMDAOS = "BMDAOS";

        /// <summary>
        /// BMBVST.
        /// </summary>
        public const string BMBVST = "BMBVST";

        /// <summary>
        /// BMSHAV.
        /// </summary>
        public const string BMSHAV = "BMSHAV";

        /// <summary>
        /// BMSHAVD.
        /// </summary>
        public const string BMSHAVD = "BMSHAVD";

        /// <summary>
        /// BMSHAVB.
        /// </summary>
        public const string BMSHAVB = "BMSHAVB";

        /// <summary>
        /// BMTSTR.
        /// </summary>
        public const string BMTSTR = "BMTSTR";

        /// <summary>
        /// BMDAFU.
        /// </summary>
        public const string BMDAFU = "BMDAFU";

        /// <summary>
        /// BMCUSE.
        /// </summary>
        public const string BMCUSE = "BMCUSE";

        /// <summary>
        /// BMNXUSE.
        /// </summary>
        public const string BMNXUSE = "BMNXUSE";

        /// <summary>
        /// BMNUMFL.
        /// </summary>
        public const string BMNUMFL = "BMNUMFL";

        /// <summary>
        /// BMMTDLT.
        /// </summary>
        public const string BMMTDLT = "BMMTDLT";

        /// <summary>
        /// BMDALT.
        /// </summary>
        public const string BMDALT = "BMDALT";

        /// <summary>
        /// BMDALS.
        /// </summary>
        public const string BMDALS = "BMDALS";

        /// <summary>
        /// BMBOWN.
        /// </summary>
        public const string BMBOWN = "BMBOWN";

        /// <summary>
        /// BMLEAS.
        /// </summary>
        public const string BMLEAS = "BMLEAS";

        /// <summary>
        /// BMLESTM.
        /// </summary>
        public const string BMLESTM = "BMLESTM";

        /// <summary>
        /// BMLESDT.
        /// </summary>
        public const string BMLESDT = "BMLESDT";

        /// <summary>
        /// BMLESDN.
        /// </summary>
        public const string BMLESDN = "BMLESDN";

        /// <summary>
        /// BMLESCO.
        /// </summary>
        public const string BMLESCO = "BMLESCO";

        /// <summary>
        /// BMLESCN.
        /// </summary>
        public const string BMLESCN = "BMLESCN";

        /// <summary>
        /// BMANUMW.
        /// </summary>
        public const string BMANUMW = "BMANUMW";

        /// <summary>
        /// BMWBPO.
        /// </summary>
        public const string BMWBPO = "BMWBPO";

        /// <summary>
        /// BMBRLC.
        /// </summary>
        public const string BMBRLC = "BMBRLC";

        /// <summary>
        /// BMIUOM.
        /// </summary>
        public const string BMIUOM = "BMIUOM";

        /// <summary>
        /// BMINUM.
        /// </summary>
        public const string BMINUM = "BMINUM";

        /// <summary>
        /// BMINSU.
        /// </summary>
        public const string BMINSU = "BMINSU";

        /// <summary>
        /// BMINLG.
        /// </summary>
        public const string BMINLG = "BMINLG";

        /// <summary>
        /// BMINWD.
        /// </summary>
        public const string BMINWD = "BMINWD";

        /// <summary>
        /// BMINHG.
        /// </summary>
        public const string BMINHG = "BMINHG";

        /// <summary>
        /// BMINGR.
        /// </summary>
        public const string BMINGR = "BMINGR";

        /// <summary>
        /// BMINQT.
        /// </summary>
        public const string BMINQT = "BMINQT";

        /// <summary>
        /// BMINTS.
        /// </summary>
        public const string BMINTS = "BMINTS";

        /// <summary>
        /// BMINFO.
        /// </summary>
        public const string BMINFO = "BMINFO";

        /// <summary>
        /// BMINMS.
        /// </summary>
        public const string BMINMS = "BMINMS";

        /// <summary>
        /// BMINUS.
        /// </summary>
        public const string BMINUS = "BMINUS";

        /// <summary>
        /// BMSYAR.
        /// </summary>
        public const string BMSYAR = "BMSYAR";

        /// <summary>
        /// BMINOO.
        /// </summary>
        public const string BMINOO = "BMINOO";

        /// <summary>
        /// BMISAR.
        /// </summary>
        public const string BMISAR = "BMISAR";

        /// <summary>
        /// BMIUMSA.
        /// </summary>
        public const string BMIUMSA = "BMIUMSA";

        /// <summary>
        /// BMISVR.
        /// </summary>
        public const string BMISVR = "BMISVR";

        /// <summary>
        /// BMDAFC.
        /// </summary>
        public const string BMDAFC = "BMDAFC";

        /// <summary>
        /// BMINSF.
        /// </summary>
        public const string BMINSF = "BMINSF";

        /// <summary>
        /// BMQTOR.
        /// </summary>
        public const string BMQTOR = "BMQTOR";

        /// <summary>
        /// BMQTRC.
        /// </summary>
        public const string BMQTRC = "BMQTRC";

        /// <summary>
        /// BMQTCU.
        /// </summary>
        public const string BMQTCU = "BMQTCU";

        /// <summary>
        /// BMURAT.
        /// </summary>
        public const string BMURAT = "BMURAT";

        /// <summary>
        /// BMURCD.
        /// </summary>
        public const string BMURCD = "BMURCD";

        /// <summary>
        /// BMURDT.
        /// </summary>
        public const string BMURDT = "BMURDT";

        /// <summary>
        /// BMURAB.
        /// </summary>
        public const string BMURAB = "BMURAB";

        /// <summary>
        /// BMURRF.
        /// </summary>
        public const string BMURRF = "BMURRF";

        /// <summary>
        /// BMUSER.
        /// </summary>
        public const string BMUSER = "BMUSER";

        /// <summary>
        /// BMDTE.
        /// </summary>
        public const string BMDTE = "BMDTE";

        /// <summary>
        /// BMTDAY.
        /// </summary>
        public const string BMTDAY = "BMTDAY";

        /// <summary>
        /// BMUPMJ.
        /// </summary>
        public const string BMUPMJ = "BMUPMJ";

        /// <summary>
        /// BMUPMT.
        /// </summary>
        public const string BMUPMT = "BMUPMT";

        /// <summary>
        /// BMJOBN.
        /// </summary>
        public const string BMJOBN = "BMJOBN";

        /// <summary>
        /// BMMKEY.
        /// </summary>
        public const string BMMKEY = "BMMKEY";

        /// <summary>
        /// BMPID.
        /// </summary>
        public const string BMPID = "BMPID";

        /// <summary>
        /// BMGECM.
        /// </summary>
        public const string BMGECM = "BMGECM";

        /// <summary>
        /// BMLDREF.
        /// </summary>
        public const string BMLDREF = "BMLDREF";

        /// <summary>
        /// BMBRLNUM.
        /// </summary>
        public const string BMBRLNUM = "BMBRLNUM";

        /// <summary>
        /// BMBPDESC.
        /// </summary>
        public const string BMBPDESC = "BMBPDESC";

        /// <summary>
        /// BMBRLCLA.
        /// </summary>
        public const string BMBRLCLA = "BMBRLCLA";

        /// <summary>
        /// BMRKNMR.
        /// </summary>
        public const string BMRKNMR = "BMRKNMR";

        /// <summary>
        /// BMSHAVEBY.
        /// </summary>
        public const string BMSHAVEBY = "BMSHAVEBY";

        /// <summary>
        /// BMWOTC.
        /// </summary>
        public const string BMWOTC = "BMWOTC";

        /// <summary>
        /// BMWRF.
        /// </summary>
        public const string BMWRF = "BMWRF";

        /// <summary>
        /// BMWCD.
        /// </summary>
        public const string BMWCD = "BMWCD";

        /// <summary>
        /// BMWAB.
        /// </summary>
        public const string BMWAB = "BMWAB";

        /// <summary>
        /// BMWNUM.
        /// </summary>
        public const string BMWNUM = "BMWNUM";

        /// <summary>
        /// BMWMDT.
        /// </summary>
        public const string BMWMDT = "BMWMDT";

        /// <summary>
        /// BMNXTUSEID.
        /// </summary>
        public const string BMNXTUSEID = "BMNXTUSEID";

        /// <summary>
        /// BMCURUSEID.
        /// </summary>
        public const string BMCURUSEID = "BMCURUSEID";

        /// <summary>
        /// BMWCG.
        /// </summary>
        public const string BMWCG = "BMWCG";

        /// <summary>
        /// BMCOOP.
        /// </summary>
        public const string BMCOOP = "BMCOOP";

        /// <summary>
        /// BMWCTRO.
        /// </summary>
        public const string BMWCTRO = "BMWCTRO";

        /// <summary>
        /// BMWVID.
        /// </summary>
        public const string BMWVID = "BMWVID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BMBATP", "BMBATP", JdeDataType.String, 8),
        new JdeField("BMBATV", "BMBATV", JdeDataType.String, 4),
        new JdeField("BMBPCO", "BMBPCO", JdeDataType.String, 24),
        new JdeField("BMMCU", "BMMCU", JdeDataType.String, 24),
        new JdeField("BMBARID", "BMBARID", JdeDataType.String, 60),
        new JdeField("BMBARCN", "BMBARCN", JdeDataType.Numeric),
        new JdeField("BMVBID", "BMVBID", JdeDataType.Numeric),
        new JdeField("BMIDNOFR", "BMIDNOFR", JdeDataType.Numeric),
        new JdeField("BMRKNUM", "BMRKNUM", JdeDataType.Numeric),
        new JdeField("BMIDMTHD", "BMIDMTHD", JdeDataType.String, 12),
        new JdeField("BMLOCN", "BMLOCN", JdeDataType.String, 40),
        new JdeField("BMWODOC", "BMWODOC", JdeDataType.Numeric),
        new JdeField("BMCTRO", "BMCTRO", JdeDataType.String, 6),
        new JdeField("BMOLOC", "BMOLOC", JdeDataType.String, 12),
        new JdeField("BMBCST", "BMBCST", JdeDataType.String, 20),
        new JdeField("BMRECY", "BMRECY", JdeDataType.Numeric),
        new JdeField("BMOYRC", "BMOYRC", JdeDataType.Numeric),
        new JdeField("BMBARCO", "BMBARCO", JdeDataType.String, 2),
        new JdeField("BMPOWN", "BMPOWN", JdeDataType.Numeric),
        new JdeField("BMSUPL", "BMSUPL", JdeDataType.Numeric),
        new JdeField("BMCPNUM", "BMCPNUM", JdeDataType.Numeric),
        new JdeField("BMFORES", "BMFORES", JdeDataType.String, 16),
        new JdeField("BMTLEV", "BMTLEV", JdeDataType.String, 6),
        new JdeField("BMTSTH", "BMTSTH", JdeDataType.String, 2),
        new JdeField("BMTOCAP", "BMTOCAP", JdeDataType.Numeric),
        new JdeField("BMBCUOM", "BMBCUOM", JdeDataType.String, 4),
        new JdeField("BMFCAP", "BMFCAP", JdeDataType.Numeric),
        new JdeField("BMNUMHP", "BMNUMHP", JdeDataType.Numeric),
        new JdeField("BMSCTM", "BMSCTM", JdeDataType.String, 20),
        new JdeField("BMSTAVT", "BMSTAVT", JdeDataType.Numeric),
        new JdeField("BMSDRM", "BMSDRM", JdeDataType.String, 20),
        new JdeField("BMSBDM", "BMSBDM", JdeDataType.String, 20),
        new JdeField("BMSDRL", "BMSDRL", JdeDataType.String, 40),
        new JdeField("BMSDDR", "BMSDDR", JdeDataType.Numeric),
        new JdeField("BMBSMK", "BMBSMK", JdeDataType.String, 16),
        new JdeField("BMGRAIN", "BMGRAIN", JdeDataType.String, 6),
        new JdeField("BMBNMS", "BMBNMS", JdeDataType.Numeric),
        new JdeField("BMBAVC", "BMBAVC", JdeDataType.String, 8),
        new JdeField("BMAJRS", "BMAJRS", JdeDataType.String, 40),
        new JdeField("BMDAOS", "BMDAOS", JdeDataType.Numeric),
        new JdeField("BMBVST", "BMBVST", JdeDataType.String, 6),
        new JdeField("BMSHAV", "BMSHAV", JdeDataType.String, 2),
        new JdeField("BMSHAVD", "BMSHAVD", JdeDataType.Numeric),
        new JdeField("BMSHAVB", "BMSHAVB", JdeDataType.String, 16),
        new JdeField("BMTSTR", "BMTSTR", JdeDataType.String, 2),
        new JdeField("BMDAFU", "BMDAFU", JdeDataType.Numeric),
        new JdeField("BMCUSE", "BMCUSE", JdeDataType.String, 8),
        new JdeField("BMNXUSE", "BMNXUSE", JdeDataType.String, 8),
        new JdeField("BMNUMFL", "BMNUMFL", JdeDataType.Numeric),
        new JdeField("BMMTDLT", "BMMTDLT", JdeDataType.String, 16),
        new JdeField("BMDALT", "BMDALT", JdeDataType.Numeric),
        new JdeField("BMDALS", "BMDALS", JdeDataType.Numeric),
        new JdeField("BMBOWN", "BMBOWN", JdeDataType.Numeric),
        new JdeField("BMLEAS", "BMLEAS", JdeDataType.String, 2),
        new JdeField("BMLESTM", "BMLESTM", JdeDataType.Numeric),
        new JdeField("BMLESDT", "BMLESDT", JdeDataType.Numeric),
        new JdeField("BMLESDN", "BMLESDN", JdeDataType.Numeric),
        new JdeField("BMLESCO", "BMLESCO", JdeDataType.Numeric),
        new JdeField("BMLESCN", "BMLESCN", JdeDataType.String, 60),
        new JdeField("BMANUMW", "BMANUMW", JdeDataType.Numeric),
        new JdeField("BMWBPO", "BMWBPO", JdeDataType.Numeric),
        new JdeField("BMBRLC", "BMBRLC", JdeDataType.String, 40),
        new JdeField("BMIUOM", "BMIUOM", JdeDataType.String, 4),
        new JdeField("BMINUM", "BMINUM", JdeDataType.Numeric),
        new JdeField("BMINSU", "BMINSU", JdeDataType.Numeric),
        new JdeField("BMINLG", "BMINLG", JdeDataType.Numeric),
        new JdeField("BMINWD", "BMINWD", JdeDataType.Numeric),
        new JdeField("BMINHG", "BMINHG", JdeDataType.Numeric),
        new JdeField("BMINGR", "BMINGR", JdeDataType.String, 6),
        new JdeField("BMINQT", "BMINQT", JdeDataType.Numeric),
        new JdeField("BMINTS", "BMINTS", JdeDataType.String, 4),
        new JdeField("BMINFO", "BMINFO", JdeDataType.String, 20),
        new JdeField("BMINMS", "BMINMS", JdeDataType.Numeric),
        new JdeField("BMINUS", "BMINUS", JdeDataType.Numeric),
        new JdeField("BMSYAR", "BMSYAR", JdeDataType.String, 6),
        new JdeField("BMINOO", "BMINOO", JdeDataType.String, 40),
        new JdeField("BMISAR", "BMISAR", JdeDataType.Numeric),
        new JdeField("BMIUMSA", "BMIUMSA", JdeDataType.String, 4),
        new JdeField("BMISVR", "BMISVR", JdeDataType.Numeric),
        new JdeField("BMDAFC", "BMDAFC", JdeDataType.Numeric),
        new JdeField("BMINSF", "BMINSF", JdeDataType.String, 2),
        new JdeField("BMQTOR", "BMQTOR", JdeDataType.Numeric),
        new JdeField("BMQTRC", "BMQTRC", JdeDataType.Numeric),
        new JdeField("BMQTCU", "BMQTCU", JdeDataType.Numeric),
        new JdeField("BMURAT", "BMURAT", JdeDataType.Numeric),
        new JdeField("BMURCD", "BMURCD", JdeDataType.String, 4),
        new JdeField("BMURDT", "BMURDT", JdeDataType.Numeric),
        new JdeField("BMURAB", "BMURAB", JdeDataType.Numeric),
        new JdeField("BMURRF", "BMURRF", JdeDataType.String, 30),
        new JdeField("BMUSER", "BMUSER", JdeDataType.String, 20),
        new JdeField("BMDTE", "BMDTE", JdeDataType.Numeric),
        new JdeField("BMTDAY", "BMTDAY", JdeDataType.Numeric),
        new JdeField("BMUPMJ", "BMUPMJ", JdeDataType.Numeric),
        new JdeField("BMUPMT", "BMUPMT", JdeDataType.Numeric),
        new JdeField("BMJOBN", "BMJOBN", JdeDataType.String, 20),
        new JdeField("BMMKEY", "BMMKEY", JdeDataType.String, 30),
        new JdeField("BMPID", "BMPID", JdeDataType.String, 20),
        new JdeField("BMGECM", "BMGECM", JdeDataType.String, 80),
        new JdeField("BMLDREF", "BMLDREF", JdeDataType.String, 80),
        new JdeField("BMBRLNUM", "BMBRLNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("BMBPDESC", "BMBPDESC", JdeDataType.String, 80),
        new JdeField("BMBRLCLA", "BMBRLCLA", JdeDataType.String, 4),
        new JdeField("BMRKNMR", "BMRKNMR", JdeDataType.String, 40),
        new JdeField("BMSHAVEBY", "BMSHAVEBY", JdeDataType.Numeric),
        new JdeField("BMWOTC", "BMWOTC", JdeDataType.String, 2),
        new JdeField("BMWRF", "BMWRF", JdeDataType.String, 60),
        new JdeField("BMWCD", "BMWCD", JdeDataType.String, 6),
        new JdeField("BMWAB", "BMWAB", JdeDataType.Numeric),
        new JdeField("BMWNUM", "BMWNUM", JdeDataType.Numeric),
        new JdeField("BMWMDT", "BMWMDT", JdeDataType.Numeric),
        new JdeField("BMNXTUSEID", "BMNXTUSEID", JdeDataType.Numeric),
        new JdeField("BMCURUSEID", "BMCURUSEID", JdeDataType.Numeric),
        new JdeField("BMWCG", "BMWCG", JdeDataType.String, 24),
        new JdeField("BMCOOP", "BMCOOP", JdeDataType.String, 6),
        new JdeField("BMWCTRO", "BMWCTRO", JdeDataType.String, 6),
        new JdeField("BMWVID", "BMWVID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B03_0", "Primary Key on BMBRLNUM", new[] { "BMBRLNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B03_1", "Index on BMBPCO, BMMCU", new[] { "BMBPCO", "BMMCU" }),
        new JdeIndex("F31B03_2", "Index on BMMCU", new[] { "BMMCU" }),
        new JdeIndex("F31B03_3", "Unique Index on BMBARID", new[] { "BMBARID" }, isUnique: true),
        new JdeIndex("F31B03_5", "Index on BMBATP, BMMCU, BMBAVC", new[] { "BMBATP", "BMMCU", "BMBAVC" })
    };
}
