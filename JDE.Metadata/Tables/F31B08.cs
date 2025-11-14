using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B08 - .
/// </summary>
public class F31B08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMWTKID.
        /// </summary>
        public const string TMWTKID = "TMWTKID";

        /// <summary>
        /// TMTKNU.
        /// </summary>
        public const string TMTKNU = "TMTKNU";

        /// <summary>
        /// TMTKNM.
        /// </summary>
        public const string TMTKNM = "TMTKNM";

        /// <summary>
        /// TMTKDS.
        /// </summary>
        public const string TMTKDS = "TMTKDS";

        /// <summary>
        /// TMTKGR.
        /// </summary>
        public const string TMTKGR = "TMTKGR";

        /// <summary>
        /// TMTKVS.
        /// </summary>
        public const string TMTKVS = "TMTKVS";

        /// <summary>
        /// TMTKHS.
        /// </summary>
        public const string TMTKHS = "TMTKHS";

        /// <summary>
        /// TMTKSTA.
        /// </summary>
        public const string TMTKSTA = "TMTKSTA";

        /// <summary>
        /// TMTDOC.
        /// </summary>
        public const string TMTDOC = "TMTDOC";

        /// <summary>
        /// TMTCRS.
        /// </summary>
        public const string TMTCRS = "TMTCRS";

        /// <summary>
        /// TMMCU.
        /// </summary>
        public const string TMMCU = "TMMCU";

        /// <summary>
        /// TMTDIC.
        /// </summary>
        public const string TMTDIC = "TMTDIC";

        /// <summary>
        /// TMLOCN.
        /// </summary>
        public const string TMLOCN = "TMLOCN";

        /// <summary>
        /// TMWLOTN.
        /// </summary>
        public const string TMWLOTN = "TMWLOTN";

        /// <summary>
        /// TMWLOTN2.
        /// </summary>
        public const string TMWLOTN2 = "TMWLOTN2";

        /// <summary>
        /// TMTKTYP.
        /// </summary>
        public const string TMTKTYP = "TMTKTYP";

        /// <summary>
        /// TMTSHP.
        /// </summary>
        public const string TMTSHP = "TMTSHP";

        /// <summary>
        /// TMTKFM.
        /// </summary>
        public const string TMTKFM = "TMTKFM";

        /// <summary>
        /// TMTKFF.
        /// </summary>
        public const string TMTKFF = "TMTKFF";

        /// <summary>
        /// TMTKCS.
        /// </summary>
        public const string TMTKCS = "TMTKCS";

        /// <summary>
        /// TMTKCW.
        /// </summary>
        public const string TMTKCW = "TMTKCW";

        /// <summary>
        /// TMTKCR.
        /// </summary>
        public const string TMTKCR = "TMTKCR";

        /// <summary>
        /// TMUMTW.
        /// </summary>
        public const string TMUMTW = "TMUMTW";

        /// <summary>
        /// TMUMTV.
        /// </summary>
        public const string TMUMTV = "TMUMTV";

        /// <summary>
        /// TMUMTD.
        /// </summary>
        public const string TMUMTD = "TMUMTD";

        /// <summary>
        /// TMWUMP1.
        /// </summary>
        public const string TMWUMP1 = "TMWUMP1";

        /// <summary>
        /// TMUMT1.
        /// </summary>
        public const string TMUMT1 = "TMUMT1";

        /// <summary>
        /// TMTKRP.
        /// </summary>
        public const string TMTKRP = "TMTKRP";

        /// <summary>
        /// TMTKRH.
        /// </summary>
        public const string TMTKRH = "TMTKRH";

        /// <summary>
        /// TMTRHM1.
        /// </summary>
        public const string TMTRHM1 = "TMTRHM1";

        /// <summary>
        /// TMTHU1.
        /// </summary>
        public const string TMTHU1 = "TMTHU1";

        /// <summary>
        /// TMTHU2.
        /// </summary>
        public const string TMTHU2 = "TMTHU2";

        /// <summary>
        /// TMTHU3.
        /// </summary>
        public const string TMTHU3 = "TMTHU3";

        /// <summary>
        /// TMTKFHS.
        /// </summary>
        public const string TMTKFHS = "TMTKFHS";

        /// <summary>
        /// TMTSM1.
        /// </summary>
        public const string TMTSM1 = "TMTSM1";

        /// <summary>
        /// TMTSU1.
        /// </summary>
        public const string TMTSU1 = "TMTSU1";

        /// <summary>
        /// TMTSU2.
        /// </summary>
        public const string TMTSU2 = "TMTSU2";

        /// <summary>
        /// TMTSU3.
        /// </summary>
        public const string TMTSU3 = "TMTSU3";

        /// <summary>
        /// TMTKFHW.
        /// </summary>
        public const string TMTKFHW = "TMTKFHW";

        /// <summary>
        /// TMTWM1.
        /// </summary>
        public const string TMTWM1 = "TMTWM1";

        /// <summary>
        /// TMTWU1.
        /// </summary>
        public const string TMTWU1 = "TMTWU1";

        /// <summary>
        /// TMTWU2.
        /// </summary>
        public const string TMTWU2 = "TMTWU2";

        /// <summary>
        /// TMTWU3.
        /// </summary>
        public const string TMTWU3 = "TMTWU3";

        /// <summary>
        /// TMTKFHR.
        /// </summary>
        public const string TMTKFHR = "TMTKFHR";

        /// <summary>
        /// TMTRMT1.
        /// </summary>
        public const string TMTRMT1 = "TMTRMT1";

        /// <summary>
        /// TMTRU1.
        /// </summary>
        public const string TMTRU1 = "TMTRU1";

        /// <summary>
        /// TMTRU2.
        /// </summary>
        public const string TMTRU2 = "TMTRU2";

        /// <summary>
        /// TMTRU3.
        /// </summary>
        public const string TMTRU3 = "TMTRU3";

        /// <summary>
        /// TMDCCO.
        /// </summary>
        public const string TMDCCO = "TMDCCO";

        /// <summary>
        /// TMTDCD.
        /// </summary>
        public const string TMTDCD = "TMTDCD";

        /// <summary>
        /// TMTKFC.
        /// </summary>
        public const string TMTKFC = "TMTKFC";

        /// <summary>
        /// TMTKIN.
        /// </summary>
        public const string TMTKIN = "TMTKIN";

        /// <summary>
        /// TMTKTC.
        /// </summary>
        public const string TMTKTC = "TMTKTC";

        /// <summary>
        /// TMTKSC.
        /// </summary>
        public const string TMTKSC = "TMTKSC";

        /// <summary>
        /// TMTKCC.
        /// </summary>
        public const string TMTKCC = "TMTKCC";

        /// <summary>
        /// TMTCRF.
        /// </summary>
        public const string TMTCRF = "TMTCRF";

        /// <summary>
        /// TMTTRC.
        /// </summary>
        public const string TMTTRC = "TMTTRC";

        /// <summary>
        /// TMTTRCM.
        /// </summary>
        public const string TMTTRCM = "TMTTRCM";

        /// <summary>
        /// TMTKSH.
        /// </summary>
        public const string TMTKSH = "TMTKSH";

        /// <summary>
        /// TMTKCH.
        /// </summary>
        public const string TMTKCH = "TMTKCH";

        /// <summary>
        /// TMTKHM.
        /// </summary>
        public const string TMTKHM = "TMTKHM";

        /// <summary>
        /// TMTTRH.
        /// </summary>
        public const string TMTTRH = "TMTTRH";

        /// <summary>
        /// TMTTRHM.
        /// </summary>
        public const string TMTTRHM = "TMTTRHM";

        /// <summary>
        /// TMTKPL.
        /// </summary>
        public const string TMTKPL = "TMTKPL";

        /// <summary>
        /// TMTKCF.
        /// </summary>
        public const string TMTKCF = "TMTKCF";

        /// <summary>
        /// TMTKFA.
        /// </summary>
        public const string TMTKFA = "TMTKFA";

        /// <summary>
        /// TMTKPU.
        /// </summary>
        public const string TMTKPU = "TMTKPU";

        /// <summary>
        /// TMTKRV.
        /// </summary>
        public const string TMTKRV = "TMTKRV";

        /// <summary>
        /// TMTKMO.
        /// </summary>
        public const string TMTKMO = "TMTKMO";

        /// <summary>
        /// TMTKSA.
        /// </summary>
        public const string TMTKSA = "TMTKSA";

        /// <summary>
        /// TMTKPR.
        /// </summary>
        public const string TMTKPR = "TMTKPR";

        /// <summary>
        /// TMTKLP.
        /// </summary>
        public const string TMTKLP = "TMTKLP";

        /// <summary>
        /// TMTKPS.
        /// </summary>
        public const string TMTKPS = "TMTKPS";

        /// <summary>
        /// TMCPNUM.
        /// </summary>
        public const string TMCPNUM = "TMCPNUM";

        /// <summary>
        /// TMSUPL.
        /// </summary>
        public const string TMSUPL = "TMSUPL";

        /// <summary>
        /// TMCTROW.
        /// </summary>
        public const string TMCTROW = "TMCTROW";

        /// <summary>
        /// TMFORES.
        /// </summary>
        public const string TMFORES = "TMFORES";

        /// <summary>
        /// TMTKPQ.
        /// </summary>
        public const string TMTKPQ = "TMTKPQ";

        /// <summary>
        /// TMTPBN.
        /// </summary>
        public const string TMTPBN = "TMTPBN";

        /// <summary>
        /// TMANUMW.
        /// </summary>
        public const string TMANUMW = "TMANUMW";

        /// <summary>
        /// TMTKGT.
        /// </summary>
        public const string TMTKGT = "TMTKGT";

        /// <summary>
        /// TMWCG.
        /// </summary>
        public const string TMWCG = "TMWCG";

        /// <summary>
        /// TMWOTC.
        /// </summary>
        public const string TMWOTC = "TMWOTC";

        /// <summary>
        /// TMVVI.
        /// </summary>
        public const string TMVVI = "TMVVI";

        /// <summary>
        /// TMWRF.
        /// </summary>
        public const string TMWRF = "TMWRF";

        /// <summary>
        /// TMWCD.
        /// </summary>
        public const string TMWCD = "TMWCD";

        /// <summary>
        /// TMWAB.
        /// </summary>
        public const string TMWAB = "TMWAB";

        /// <summary>
        /// TMWNUM.
        /// </summary>
        public const string TMWNUM = "TMWNUM";

        /// <summary>
        /// TMWMDT.
        /// </summary>
        public const string TMWMDT = "TMWMDT";

        /// <summary>
        /// TMURCD.
        /// </summary>
        public const string TMURCD = "TMURCD";

        /// <summary>
        /// TMURDT.
        /// </summary>
        public const string TMURDT = "TMURDT";

        /// <summary>
        /// TMURAT.
        /// </summary>
        public const string TMURAT = "TMURAT";

        /// <summary>
        /// TMURRF.
        /// </summary>
        public const string TMURRF = "TMURRF";

        /// <summary>
        /// TMURAB.
        /// </summary>
        public const string TMURAB = "TMURAB";

        /// <summary>
        /// TMUSER.
        /// </summary>
        public const string TMUSER = "TMUSER";

        /// <summary>
        /// TMPID.
        /// </summary>
        public const string TMPID = "TMPID";

        /// <summary>
        /// TMJOBN.
        /// </summary>
        public const string TMJOBN = "TMJOBN";

        /// <summary>
        /// TMMKEY.
        /// </summary>
        public const string TMMKEY = "TMMKEY";

        /// <summary>
        /// TMUPMJ.
        /// </summary>
        public const string TMUPMJ = "TMUPMJ";

        /// <summary>
        /// TMUPMT.
        /// </summary>
        public const string TMUPMT = "TMUPMT";

        /// <summary>
        /// TMWTKC01.
        /// </summary>
        public const string TMWTKC01 = "TMWTKC01";

        /// <summary>
        /// TMWTKC02.
        /// </summary>
        public const string TMWTKC02 = "TMWTKC02";

        /// <summary>
        /// TMWTKC03.
        /// </summary>
        public const string TMWTKC03 = "TMWTKC03";

        /// <summary>
        /// TMWTKC04.
        /// </summary>
        public const string TMWTKC04 = "TMWTKC04";

        /// <summary>
        /// TMWTKC05.
        /// </summary>
        public const string TMWTKC05 = "TMWTKC05";
    }

    /// <inheritdoc />
    public override string TableName => "F31B08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMWTKID", "TMWTKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TMTKNU", "TMTKNU", JdeDataType.String, 20),
        new JdeField("TMTKNM", "TMTKNM", JdeDataType.String, 30),
        new JdeField("TMTKDS", "TMTKDS", JdeDataType.String, 60),
        new JdeField("TMTKGR", "TMTKGR", JdeDataType.String, 20),
        new JdeField("TMTKVS", "TMTKVS", JdeDataType.String, 2),
        new JdeField("TMTKHS", "TMTKHS", JdeDataType.String, 2),
        new JdeField("TMTKSTA", "TMTKSTA", JdeDataType.String, 2),
        new JdeField("TMTDOC", "TMTDOC", JdeDataType.Numeric),
        new JdeField("TMTCRS", "TMTCRS", JdeDataType.String, 60),
        new JdeField("TMMCU", "TMMCU", JdeDataType.String, 24, true, true),
        new JdeField("TMTDIC", "TMTDIC", JdeDataType.Numeric),
        new JdeField("TMLOCN", "TMLOCN", JdeDataType.String, 40),
        new JdeField("TMWLOTN", "TMWLOTN", JdeDataType.String, 60),
        new JdeField("TMWLOTN2", "TMWLOTN2", JdeDataType.String, 60),
        new JdeField("TMTKTYP", "TMTKTYP", JdeDataType.String, 6),
        new JdeField("TMTSHP", "TMTSHP", JdeDataType.String, 60),
        new JdeField("TMTKFM", "TMTKFM", JdeDataType.String, 60),
        new JdeField("TMTKFF", "TMTKFF", JdeDataType.String, 2),
        new JdeField("TMTKCS", "TMTKCS", JdeDataType.Numeric),
        new JdeField("TMTKCW", "TMTKCW", JdeDataType.Numeric),
        new JdeField("TMTKCR", "TMTKCR", JdeDataType.Numeric),
        new JdeField("TMUMTW", "TMUMTW", JdeDataType.String, 4),
        new JdeField("TMUMTV", "TMUMTV", JdeDataType.String, 4),
        new JdeField("TMUMTD", "TMUMTD", JdeDataType.String, 4),
        new JdeField("TMWUMP1", "TMWUMP1", JdeDataType.String, 4),
        new JdeField("TMUMT1", "TMUMT1", JdeDataType.String, 4),
        new JdeField("TMTKRP", "TMTKRP", JdeDataType.String, 60),
        new JdeField("TMTKRH", "TMTKRH", JdeDataType.Numeric),
        new JdeField("TMTRHM1", "TMTRHM1", JdeDataType.Numeric),
        new JdeField("TMTHU1", "TMTHU1", JdeDataType.Numeric),
        new JdeField("TMTHU2", "TMTHU2", JdeDataType.Numeric),
        new JdeField("TMTHU3", "TMTHU3", JdeDataType.Numeric),
        new JdeField("TMTKFHS", "TMTKFHS", JdeDataType.Numeric),
        new JdeField("TMTSM1", "TMTSM1", JdeDataType.Numeric),
        new JdeField("TMTSU1", "TMTSU1", JdeDataType.Numeric),
        new JdeField("TMTSU2", "TMTSU2", JdeDataType.Numeric),
        new JdeField("TMTSU3", "TMTSU3", JdeDataType.Numeric),
        new JdeField("TMTKFHW", "TMTKFHW", JdeDataType.Numeric),
        new JdeField("TMTWM1", "TMTWM1", JdeDataType.Numeric),
        new JdeField("TMTWU1", "TMTWU1", JdeDataType.Numeric),
        new JdeField("TMTWU2", "TMTWU2", JdeDataType.Numeric),
        new JdeField("TMTWU3", "TMTWU3", JdeDataType.Numeric),
        new JdeField("TMTKFHR", "TMTKFHR", JdeDataType.Numeric),
        new JdeField("TMTRMT1", "TMTRMT1", JdeDataType.Numeric),
        new JdeField("TMTRU1", "TMTRU1", JdeDataType.Numeric),
        new JdeField("TMTRU2", "TMTRU2", JdeDataType.Numeric),
        new JdeField("TMTRU3", "TMTRU3", JdeDataType.Numeric),
        new JdeField("TMDCCO", "TMDCCO", JdeDataType.String, 16),
        new JdeField("TMTDCD", "TMTDCD", JdeDataType.String, 60),
        new JdeField("TMTKFC", "TMTKFC", JdeDataType.String, 6),
        new JdeField("TMTKIN", "TMTKIN", JdeDataType.String, 2),
        new JdeField("TMTKTC", "TMTKTC", JdeDataType.String, 2),
        new JdeField("TMTKSC", "TMTKSC", JdeDataType.String, 2),
        new JdeField("TMTKCC", "TMTKCC", JdeDataType.String, 6),
        new JdeField("TMTCRF", "TMTCRF", JdeDataType.String, 8),
        new JdeField("TMTTRC", "TMTTRC", JdeDataType.Numeric),
        new JdeField("TMTTRCM", "TMTTRCM", JdeDataType.Numeric),
        new JdeField("TMTKSH", "TMTKSH", JdeDataType.String, 2),
        new JdeField("TMTKCH", "TMTKCH", JdeDataType.String, 6),
        new JdeField("TMTKHM", "TMTKHM", JdeDataType.String, 8),
        new JdeField("TMTTRH", "TMTTRH", JdeDataType.Numeric),
        new JdeField("TMTTRHM", "TMTTRHM", JdeDataType.Numeric),
        new JdeField("TMTKPL", "TMTKPL", JdeDataType.String, 2),
        new JdeField("TMTKCF", "TMTKCF", JdeDataType.String, 2),
        new JdeField("TMTKFA", "TMTKFA", JdeDataType.String, 2),
        new JdeField("TMTKPU", "TMTKPU", JdeDataType.String, 6),
        new JdeField("TMTKRV", "TMTKRV", JdeDataType.String, 2),
        new JdeField("TMTKMO", "TMTKMO", JdeDataType.String, 2),
        new JdeField("TMTKSA", "TMTKSA", JdeDataType.String, 2),
        new JdeField("TMTKPR", "TMTKPR", JdeDataType.String, 2),
        new JdeField("TMTKLP", "TMTKLP", JdeDataType.Numeric),
        new JdeField("TMTKPS", "TMTKPS", JdeDataType.String, 2),
        new JdeField("TMCPNUM", "TMCPNUM", JdeDataType.Numeric),
        new JdeField("TMSUPL", "TMSUPL", JdeDataType.Numeric),
        new JdeField("TMCTROW", "TMCTROW", JdeDataType.String, 6),
        new JdeField("TMFORES", "TMFORES", JdeDataType.String, 16),
        new JdeField("TMTKPQ", "TMTKPQ", JdeDataType.Numeric),
        new JdeField("TMTPBN", "TMTPBN", JdeDataType.String, 20),
        new JdeField("TMANUMW", "TMANUMW", JdeDataType.Numeric),
        new JdeField("TMTKGT", "TMTKGT", JdeDataType.String, 2),
        new JdeField("TMWCG", "TMWCG", JdeDataType.String, 24),
        new JdeField("TMWOTC", "TMWOTC", JdeDataType.String, 2),
        new JdeField("TMVVI", "TMVVI", JdeDataType.String, 2),
        new JdeField("TMWRF", "TMWRF", JdeDataType.String, 60),
        new JdeField("TMWCD", "TMWCD", JdeDataType.String, 6),
        new JdeField("TMWAB", "TMWAB", JdeDataType.Numeric),
        new JdeField("TMWNUM", "TMWNUM", JdeDataType.Numeric),
        new JdeField("TMWMDT", "TMWMDT", JdeDataType.Numeric),
        new JdeField("TMURCD", "TMURCD", JdeDataType.String, 4),
        new JdeField("TMURDT", "TMURDT", JdeDataType.Numeric),
        new JdeField("TMURAT", "TMURAT", JdeDataType.Numeric),
        new JdeField("TMURRF", "TMURRF", JdeDataType.String, 30),
        new JdeField("TMURAB", "TMURAB", JdeDataType.Numeric),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMJOBN", "TMJOBN", JdeDataType.String, 20),
        new JdeField("TMMKEY", "TMMKEY", JdeDataType.String, 30),
        new JdeField("TMUPMJ", "TMUPMJ", JdeDataType.Numeric),
        new JdeField("TMUPMT", "TMUPMT", JdeDataType.Numeric),
        new JdeField("TMWTKC01", "TMWTKC01", JdeDataType.String, 20),
        new JdeField("TMWTKC02", "TMWTKC02", JdeDataType.String, 20),
        new JdeField("TMWTKC03", "TMWTKC03", JdeDataType.String, 20),
        new JdeField("TMWTKC04", "TMWTKC04", JdeDataType.String, 20),
        new JdeField("TMWTKC05", "TMWTKC05", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B08_0", "Primary Key on TMWTKID, TMMCU", new[] { "TMWTKID", "TMMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B08_2", "Index on TMTKNM, TMMCU", new[] { "TMTKNM", "TMMCU" }),
        new JdeIndex("F31B08_3", "Index on TMTKNU, TMMCU", new[] { "TMTKNU", "TMMCU" }),
        new JdeIndex("F31B08_4", "Index on TMMCU, TMDCCO", new[] { "TMMCU", "TMDCCO" })
    };
}
