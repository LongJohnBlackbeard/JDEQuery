using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S0618 - .
/// </summary>
public class F48S0618 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YTAN8.
        /// </summary>
        public const string YTAN8 = "YTAN8";

        /// <summary>
        /// YTPALF.
        /// </summary>
        public const string YTPALF = "YTPALF";

        /// <summary>
        /// YTPRTR.
        /// </summary>
        public const string YTPRTR = "YTPRTR";

        /// <summary>
        /// YTRCCD.
        /// </summary>
        public const string YTRCCD = "YTRCCD";

        /// <summary>
        /// YTCKCN.
        /// </summary>
        public const string YTCKCN = "YTCKCN";

        /// <summary>
        /// YTAM.
        /// </summary>
        public const string YTAM = "YTAM";

        /// <summary>
        /// YTCO.
        /// </summary>
        public const string YTCO = "YTCO";

        /// <summary>
        /// YTHMCO.
        /// </summary>
        public const string YTHMCO = "YTHMCO";

        /// <summary>
        /// YTHMCU.
        /// </summary>
        public const string YTHMCU = "YTHMCU";

        /// <summary>
        /// YTMCU.
        /// </summary>
        public const string YTMCU = "YTMCU";

        /// <summary>
        /// YTOBJ.
        /// </summary>
        public const string YTOBJ = "YTOBJ";

        /// <summary>
        /// YTSUB.
        /// </summary>
        public const string YTSUB = "YTSUB";

        /// <summary>
        /// YTRCO.
        /// </summary>
        public const string YTRCO = "YTRCO";

        /// <summary>
        /// YTGMCU.
        /// </summary>
        public const string YTGMCU = "YTGMCU";

        /// <summary>
        /// YTGOBJ.
        /// </summary>
        public const string YTGOBJ = "YTGOBJ";

        /// <summary>
        /// YTGSUB.
        /// </summary>
        public const string YTGSUB = "YTGSUB";

        /// <summary>
        /// YTSBL.
        /// </summary>
        public const string YTSBL = "YTSBL";

        /// <summary>
        /// YTSBLT.
        /// </summary>
        public const string YTSBLT = "YTSBLT";

        /// <summary>
        /// YTWR01.
        /// </summary>
        public const string YTWR01 = "YTWR01";

        /// <summary>
        /// YTMCUO.
        /// </summary>
        public const string YTMCUO = "YTMCUO";

        /// <summary>
        /// YTMAIL.
        /// </summary>
        public const string YTMAIL = "YTMAIL";

        /// <summary>
        /// YTPHRW.
        /// </summary>
        public const string YTPHRW = "YTPHRW";

        /// <summary>
        /// YTOPSQ.
        /// </summary>
        public const string YTOPSQ = "YTOPSQ";

        /// <summary>
        /// YTRILT.
        /// </summary>
        public const string YTRILT = "YTRILT";

        /// <summary>
        /// YTITM.
        /// </summary>
        public const string YTITM = "YTITM";

        /// <summary>
        /// YTPCUN.
        /// </summary>
        public const string YTPCUN = "YTPCUN";

        /// <summary>
        /// YTUM.
        /// </summary>
        public const string YTUM = "YTUM";

        /// <summary>
        /// YTPHRT.
        /// </summary>
        public const string YTPHRT = "YTPHRT";

        /// <summary>
        /// YTPPRT.
        /// </summary>
        public const string YTPPRT = "YTPPRT";

        /// <summary>
        /// YTBHRT.
        /// </summary>
        public const string YTBHRT = "YTBHRT";

        /// <summary>
        /// YTPBRT.
        /// </summary>
        public const string YTPBRT = "YTPBRT";

        /// <summary>
        /// YTBDRT.
        /// </summary>
        public const string YTBDRT = "YTBDRT";

        /// <summary>
        /// YTSHRT.
        /// </summary>
        public const string YTSHRT = "YTSHRT";

        /// <summary>
        /// YTSHFT.
        /// </summary>
        public const string YTSHFT = "YTSHFT";

        /// <summary>
        /// YTSHD.
        /// </summary>
        public const string YTSHD = "YTSHD";

        /// <summary>
        /// YTPAYM.
        /// </summary>
        public const string YTPAYM = "YTPAYM";

        /// <summary>
        /// YTLD.
        /// </summary>
        public const string YTLD = "YTLD";

        /// <summary>
        /// YTGPA.
        /// </summary>
        public const string YTGPA = "YTGPA";

        /// <summary>
        /// YTDPA.
        /// </summary>
        public const string YTDPA = "YTDPA";

        /// <summary>
        /// YTRCPY.
        /// </summary>
        public const string YTRCPY = "YTRCPY";

        /// <summary>
        /// YTSAMT.
        /// </summary>
        public const string YTSAMT = "YTSAMT";

        /// <summary>
        /// YTUN.
        /// </summary>
        public const string YTUN = "YTUN";

        /// <summary>
        /// YTJBCD.
        /// </summary>
        public const string YTJBCD = "YTJBCD";

        /// <summary>
        /// YTJBST.
        /// </summary>
        public const string YTJBST = "YTJBST";

        /// <summary>
        /// YTWST.
        /// </summary>
        public const string YTWST = "YTWST";

        /// <summary>
        /// YTWCNT.
        /// </summary>
        public const string YTWCNT = "YTWCNT";

        /// <summary>
        /// YTWCTY.
        /// </summary>
        public const string YTWCTY = "YTWCTY";

        /// <summary>
        /// YTWCMP.
        /// </summary>
        public const string YTWCMP = "YTWCMP";

        /// <summary>
        /// YTWET.
        /// </summary>
        public const string YTWET = "YTWET";

        /// <summary>
        /// YTGENA.
        /// </summary>
        public const string YTGENA = "YTGENA";

        /// <summary>
        /// YTWCAM.
        /// </summary>
        public const string YTWCAM = "YTWCAM";

        /// <summary>
        /// YTWCMB.
        /// </summary>
        public const string YTWCMB = "YTWCMB";

        /// <summary>
        /// YTGENB.
        /// </summary>
        public const string YTGENB = "YTGENB";

        /// <summary>
        /// YTWCMO.
        /// </summary>
        public const string YTWCMO = "YTWCMO";

        /// <summary>
        /// YTGENO.
        /// </summary>
        public const string YTGENO = "YTGENO";

        /// <summary>
        /// YTWCMX.
        /// </summary>
        public const string YTWCMX = "YTWCMX";

        /// <summary>
        /// YTGENX.
        /// </summary>
        public const string YTGENX = "YTGENX";

        /// <summary>
        /// YTWCBN.
        /// </summary>
        public const string YTWCBN = "YTWCBN";

        /// <summary>
        /// YTHMO.
        /// </summary>
        public const string YTHMO = "YTHMO";

        /// <summary>
        /// YTPDBA.
        /// </summary>
        public const string YTPDBA = "YTPDBA";

        /// <summary>
        /// YTPB.
        /// </summary>
        public const string YTPB = "YTPB";

        /// <summary>
        /// YTDEDM.
        /// </summary>
        public const string YTDEDM = "YTDEDM";

        /// <summary>
        /// YTSALY.
        /// </summary>
        public const string YTSALY = "YTSALY";

        /// <summary>
        /// YTNMTH.
        /// </summary>
        public const string YTNMTH = "YTNMTH";

        /// <summary>
        /// YTPFRQ.
        /// </summary>
        public const string YTPFRQ = "YTPFRQ";

        /// <summary>
        /// YTFY.
        /// </summary>
        public const string YTFY = "YTFY";

        /// <summary>
        /// YTDGL.
        /// </summary>
        public const string YTDGL = "YTDGL";

        /// <summary>
        /// YTPN.
        /// </summary>
        public const string YTPN = "YTPN";

        /// <summary>
        /// YTDWK.
        /// </summary>
        public const string YTDWK = "YTDWK";

        /// <summary>
        /// YTDW.
        /// </summary>
        public const string YTDW = "YTDW";

        /// <summary>
        /// YTPPED.
        /// </summary>
        public const string YTPPED = "YTPPED";

        /// <summary>
        /// YTPPP.
        /// </summary>
        public const string YTPPP = "YTPPP";

        /// <summary>
        /// YTDTBT.
        /// </summary>
        public const string YTDTBT = "YTDTBT";

        /// <summary>
        /// YTTCDE.
        /// </summary>
        public const string YTTCDE = "YTTCDE";

        /// <summary>
        /// YTEQCO.
        /// </summary>
        public const string YTEQCO = "YTEQCO";

        /// <summary>
        /// YTEQWO.
        /// </summary>
        public const string YTEQWO = "YTEQWO";

        /// <summary>
        /// YTEQCG.
        /// </summary>
        public const string YTEQCG = "YTEQCG";

        /// <summary>
        /// YTQOBJ.
        /// </summary>
        public const string YTQOBJ = "YTQOBJ";

        /// <summary>
        /// YTERC.
        /// </summary>
        public const string YTERC = "YTERC";

        /// <summary>
        /// YTEQRT.
        /// </summary>
        public const string YTEQRT = "YTEQRT";

        /// <summary>
        /// YTEQGR.
        /// </summary>
        public const string YTEQGR = "YTEQGR";

        /// <summary>
        /// YTEQHR.
        /// </summary>
        public const string YTEQHR = "YTEQHR";

        /// <summary>
        /// YTEXR.
        /// </summary>
        public const string YTEXR = "YTEXR";

        /// <summary>
        /// YTP001.
        /// </summary>
        public const string YTP001 = "YTP001";

        /// <summary>
        /// YTP002.
        /// </summary>
        public const string YTP002 = "YTP002";

        /// <summary>
        /// YTP003.
        /// </summary>
        public const string YTP003 = "YTP003";

        /// <summary>
        /// YTP004.
        /// </summary>
        public const string YTP004 = "YTP004";

        /// <summary>
        /// YTUSER.
        /// </summary>
        public const string YTUSER = "YTUSER";

        /// <summary>
        /// YTCMMT.
        /// </summary>
        public const string YTCMMT = "YTCMMT";

        /// <summary>
        /// YTCKDT.
        /// </summary>
        public const string YTCKDT = "YTCKDT";

        /// <summary>
        /// YTUAMT.
        /// </summary>
        public const string YTUAMT = "YTUAMT";

        /// <summary>
        /// YTRTWC.
        /// </summary>
        public const string YTRTWC = "YTRTWC";

        /// <summary>
        /// YTGENR.
        /// </summary>
        public const string YTGENR = "YTGENR";

        /// <summary>
        /// YTCKCS.
        /// </summary>
        public const string YTCKCS = "YTCKCS";

        /// <summary>
        /// YTGICU.
        /// </summary>
        public const string YTGICU = "YTGICU";

        /// <summary>
        /// YTAID.
        /// </summary>
        public const string YTAID = "YTAID";

        /// <summary>
        /// YTCMTH.
        /// </summary>
        public const string YTCMTH = "YTCMTH";

        /// <summary>
        /// YTALT0.
        /// </summary>
        public const string YTALT0 = "YTALT0";

        /// <summary>
        /// YTPOS.
        /// </summary>
        public const string YTPOS = "YTPOS";

        /// <summary>
        /// YTACTB.
        /// </summary>
        public const string YTACTB = "YTACTB";

        /// <summary>
        /// YTABR1.
        /// </summary>
        public const string YTABR1 = "YTABR1";

        /// <summary>
        /// YTABT1.
        /// </summary>
        public const string YTABT1 = "YTABT1";

        /// <summary>
        /// YTABR2.
        /// </summary>
        public const string YTABR2 = "YTABR2";

        /// <summary>
        /// YTABT2.
        /// </summary>
        public const string YTABT2 = "YTABT2";

        /// <summary>
        /// YTABR3.
        /// </summary>
        public const string YTABR3 = "YTABR3";

        /// <summary>
        /// YTABT3.
        /// </summary>
        public const string YTABT3 = "YTABT3";

        /// <summary>
        /// YTABR4.
        /// </summary>
        public const string YTABR4 = "YTABR4";

        /// <summary>
        /// YTABT4.
        /// </summary>
        public const string YTABT4 = "YTABT4";

        /// <summary>
        /// YTBLGRT.
        /// </summary>
        public const string YTBLGRT = "YTBLGRT";

        /// <summary>
        /// YTRCHGAMT.
        /// </summary>
        public const string YTRCHGAMT = "YTRCHGAMT";

        /// <summary>
        /// YTFBLGRT.
        /// </summary>
        public const string YTFBLGRT = "YTFBLGRT";

        /// <summary>
        /// YTFRCHGAMT.
        /// </summary>
        public const string YTFRCHGAMT = "YTFRCHGAMT";

        /// <summary>
        /// YTCRR.
        /// </summary>
        public const string YTCRR = "YTCRR";

        /// <summary>
        /// YTCRCD.
        /// </summary>
        public const string YTCRCD = "YTCRCD";

        /// <summary>
        /// YTCRDC.
        /// </summary>
        public const string YTCRDC = "YTCRDC";

        /// <summary>
        /// YTRCHGMODE.
        /// </summary>
        public const string YTRCHGMODE = "YTRCHGMODE";

        /// <summary>
        /// YTLTTP.
        /// </summary>
        public const string YTLTTP = "YTLTTP";

        /// <summary>
        /// YTRKID.
        /// </summary>
        public const string YTRKID = "YTRKID";

        /// <summary>
        /// YTAPPRCFLG.
        /// </summary>
        public const string YTAPPRCFLG = "YTAPPRCFLG";

        /// <summary>
        /// YTOTRULECD.
        /// </summary>
        public const string YTOTRULECD = "YTOTRULECD";

        /// <summary>
        /// YTTSKID.
        /// </summary>
        public const string YTTSKID = "YTTSKID";

        /// <summary>
        /// YTTAXX.
        /// </summary>
        public const string YTTAXX = "YTTAXX";

        /// <summary>
        /// YTSCTR.
        /// </summary>
        public const string YTSCTR = "YTSCTR";

        /// <summary>
        /// YTSCRX.
        /// </summary>
        public const string YTSCRX = "YTSCRX";

        /// <summary>
        /// YTSVH.
        /// </summary>
        public const string YTSVH = "YTSVH";

        /// <summary>
        /// YTTCFD.
        /// </summary>
        public const string YTTCFD = "YTTCFD";

        /// <summary>
        /// YTTCTD.
        /// </summary>
        public const string YTTCTD = "YTTCTD";

        /// <summary>
        /// YTHWPD.
        /// </summary>
        public const string YTHWPD = "YTHWPD";

        /// <summary>
        /// YTINSTID.
        /// </summary>
        public const string YTINSTID = "YTINSTID";

        /// <summary>
        /// YTJBLC.
        /// </summary>
        public const string YTJBLC = "YTJBLC";

        /// <summary>
        /// YTCOPX.
        /// </summary>
        public const string YTCOPX = "YTCOPX";

        /// <summary>
        /// YTBPTX.
        /// </summary>
        public const string YTBPTX = "YTBPTX";

        /// <summary>
        /// YTCOPB.
        /// </summary>
        public const string YTCOPB = "YTCOPB";

        /// <summary>
        /// YTCMED.
        /// </summary>
        public const string YTCMED = "YTCMED";

        /// <summary>
        /// YTCOPR.
        /// </summary>
        public const string YTCOPR = "YTCOPR";

        /// <summary>
        /// YTGLBN.
        /// </summary>
        public const string YTGLBN = "YTGLBN";

        /// <summary>
        /// YTWCEX.
        /// </summary>
        public const string YTWCEX = "YTWCEX";

        /// <summary>
        /// YTGLEX.
        /// </summary>
        public const string YTGLEX = "YTGLEX";

        /// <summary>
        /// YTLDID.
        /// </summary>
        public const string YTLDID = "YTLDID";

        /// <summary>
        /// YTLDED.
        /// </summary>
        public const string YTLDED = "YTLDED";

        /// <summary>
        /// YTTTAP.
        /// </summary>
        public const string YTTTAP = "YTTTAP";

        /// <summary>
        /// YTINVA.
        /// </summary>
        public const string YTINVA = "YTINVA";

        /// <summary>
        /// YTINRA.
        /// </summary>
        public const string YTINRA = "YTINRA";

        /// <summary>
        /// YTINEA.
        /// </summary>
        public const string YTINEA = "YTINEA";

        /// <summary>
        /// YTCRFL.
        /// </summary>
        public const string YTCRFL = "YTCRFL";

        /// <summary>
        /// YTCPTR.
        /// </summary>
        public const string YTCPTR = "YTCPTR";

        /// <summary>
        /// YTPCOR.
        /// </summary>
        public const string YTPCOR = "YTPCOR";
    }

    /// <inheritdoc />
    public override string TableName => "F48S0618";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YTAN8", "YTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YTPALF", "YTPALF", JdeDataType.String, 24),
        new JdeField("YTPRTR", "YTPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YTRCCD", "YTRCCD", JdeDataType.String, 2),
        new JdeField("YTCKCN", "YTCKCN", JdeDataType.Numeric),
        new JdeField("YTAM", "YTAM", JdeDataType.String, 2),
        new JdeField("YTCO", "YTCO", JdeDataType.String, 10),
        new JdeField("YTHMCO", "YTHMCO", JdeDataType.String, 10),
        new JdeField("YTHMCU", "YTHMCU", JdeDataType.String, 24),
        new JdeField("YTMCU", "YTMCU", JdeDataType.String, 24),
        new JdeField("YTOBJ", "YTOBJ", JdeDataType.String, 12),
        new JdeField("YTSUB", "YTSUB", JdeDataType.String, 16),
        new JdeField("YTRCO", "YTRCO", JdeDataType.String, 10),
        new JdeField("YTGMCU", "YTGMCU", JdeDataType.String, 24),
        new JdeField("YTGOBJ", "YTGOBJ", JdeDataType.String, 12),
        new JdeField("YTGSUB", "YTGSUB", JdeDataType.String, 16),
        new JdeField("YTSBL", "YTSBL", JdeDataType.String, 16),
        new JdeField("YTSBLT", "YTSBLT", JdeDataType.String, 2),
        new JdeField("YTWR01", "YTWR01", JdeDataType.String, 8),
        new JdeField("YTMCUO", "YTMCUO", JdeDataType.String, 24),
        new JdeField("YTMAIL", "YTMAIL", JdeDataType.String, 20),
        new JdeField("YTPHRW", "YTPHRW", JdeDataType.Numeric),
        new JdeField("YTOPSQ", "YTOPSQ", JdeDataType.Numeric),
        new JdeField("YTRILT", "YTRILT", JdeDataType.String, 2),
        new JdeField("YTITM", "YTITM", JdeDataType.Numeric),
        new JdeField("YTPCUN", "YTPCUN", JdeDataType.Numeric),
        new JdeField("YTUM", "YTUM", JdeDataType.String, 4),
        new JdeField("YTPHRT", "YTPHRT", JdeDataType.Numeric),
        new JdeField("YTPPRT", "YTPPRT", JdeDataType.Numeric),
        new JdeField("YTBHRT", "YTBHRT", JdeDataType.Numeric),
        new JdeField("YTPBRT", "YTPBRT", JdeDataType.Numeric),
        new JdeField("YTBDRT", "YTBDRT", JdeDataType.Numeric),
        new JdeField("YTSHRT", "YTSHRT", JdeDataType.Numeric),
        new JdeField("YTSHFT", "YTSHFT", JdeDataType.String, 2),
        new JdeField("YTSHD", "YTSHD", JdeDataType.Numeric),
        new JdeField("YTPAYM", "YTPAYM", JdeDataType.Numeric),
        new JdeField("YTLD", "YTLD", JdeDataType.String, 2),
        new JdeField("YTGPA", "YTGPA", JdeDataType.Numeric),
        new JdeField("YTDPA", "YTDPA", JdeDataType.Numeric),
        new JdeField("YTRCPY", "YTRCPY", JdeDataType.Numeric),
        new JdeField("YTSAMT", "YTSAMT", JdeDataType.Numeric),
        new JdeField("YTUN", "YTUN", JdeDataType.String, 12),
        new JdeField("YTJBCD", "YTJBCD", JdeDataType.String, 12),
        new JdeField("YTJBST", "YTJBST", JdeDataType.String, 8),
        new JdeField("YTWST", "YTWST", JdeDataType.Numeric),
        new JdeField("YTWCNT", "YTWCNT", JdeDataType.Numeric),
        new JdeField("YTWCTY", "YTWCTY", JdeDataType.Numeric),
        new JdeField("YTWCMP", "YTWCMP", JdeDataType.String, 8),
        new JdeField("YTWET", "YTWET", JdeDataType.String, 2),
        new JdeField("YTGENA", "YTGENA", JdeDataType.Numeric),
        new JdeField("YTWCAM", "YTWCAM", JdeDataType.Numeric),
        new JdeField("YTWCMB", "YTWCMB", JdeDataType.Numeric),
        new JdeField("YTGENB", "YTGENB", JdeDataType.Numeric),
        new JdeField("YTWCMO", "YTWCMO", JdeDataType.Numeric),
        new JdeField("YTGENO", "YTGENO", JdeDataType.Numeric),
        new JdeField("YTWCMX", "YTWCMX", JdeDataType.Numeric),
        new JdeField("YTGENX", "YTGENX", JdeDataType.Numeric),
        new JdeField("YTWCBN", "YTWCBN", JdeDataType.Numeric),
        new JdeField("YTHMO", "YTHMO", JdeDataType.Numeric),
        new JdeField("YTPDBA", "YTPDBA", JdeDataType.Numeric),
        new JdeField("YTPB", "YTPB", JdeDataType.String, 2),
        new JdeField("YTDEDM", "YTDEDM", JdeDataType.String, 2),
        new JdeField("YTSALY", "YTSALY", JdeDataType.String, 2),
        new JdeField("YTNMTH", "YTNMTH", JdeDataType.String, 2),
        new JdeField("YTPFRQ", "YTPFRQ", JdeDataType.String, 2),
        new JdeField("YTFY", "YTFY", JdeDataType.Numeric),
        new JdeField("YTDGL", "YTDGL", JdeDataType.Numeric),
        new JdeField("YTPN", "YTPN", JdeDataType.Numeric),
        new JdeField("YTDWK", "YTDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("YTDW", "YTDW", JdeDataType.String, 2),
        new JdeField("YTPPED", "YTPPED", JdeDataType.Numeric),
        new JdeField("YTPPP", "YTPPP", JdeDataType.String, 2),
        new JdeField("YTDTBT", "YTDTBT", JdeDataType.Numeric),
        new JdeField("YTTCDE", "YTTCDE", JdeDataType.Numeric),
        new JdeField("YTEQCO", "YTEQCO", JdeDataType.String, 10),
        new JdeField("YTEQWO", "YTEQWO", JdeDataType.String, 18),
        new JdeField("YTEQCG", "YTEQCG", JdeDataType.String, 18),
        new JdeField("YTQOBJ", "YTQOBJ", JdeDataType.String, 12),
        new JdeField("YTERC", "YTERC", JdeDataType.String, 4),
        new JdeField("YTEQRT", "YTEQRT", JdeDataType.Numeric),
        new JdeField("YTEQGR", "YTEQGR", JdeDataType.Numeric),
        new JdeField("YTEQHR", "YTEQHR", JdeDataType.Numeric),
        new JdeField("YTEXR", "YTEXR", JdeDataType.String, 60),
        new JdeField("YTP001", "YTP001", JdeDataType.String, 6),
        new JdeField("YTP002", "YTP002", JdeDataType.String, 6),
        new JdeField("YTP003", "YTP003", JdeDataType.String, 6),
        new JdeField("YTP004", "YTP004", JdeDataType.String, 6),
        new JdeField("YTUSER", "YTUSER", JdeDataType.String, 20),
        new JdeField("YTCMMT", "YTCMMT", JdeDataType.String, 2),
        new JdeField("YTCKDT", "YTCKDT", JdeDataType.Numeric),
        new JdeField("YTUAMT", "YTUAMT", JdeDataType.Numeric),
        new JdeField("YTRTWC", "YTRTWC", JdeDataType.Numeric),
        new JdeField("YTGENR", "YTGENR", JdeDataType.Numeric),
        new JdeField("YTCKCS", "YTCKCS", JdeDataType.String, 30),
        new JdeField("YTGICU", "YTGICU", JdeDataType.Numeric),
        new JdeField("YTAID", "YTAID", JdeDataType.String, 16),
        new JdeField("YTCMTH", "YTCMTH", JdeDataType.String, 2),
        new JdeField("YTALT0", "YTALT0", JdeDataType.String, 2),
        new JdeField("YTPOS", "YTPOS", JdeDataType.String, 16),
        new JdeField("YTACTB", "YTACTB", JdeDataType.String, 20),
        new JdeField("YTABR1", "YTABR1", JdeDataType.String, 24),
        new JdeField("YTABT1", "YTABT1", JdeDataType.String, 2),
        new JdeField("YTABR2", "YTABR2", JdeDataType.String, 24),
        new JdeField("YTABT2", "YTABT2", JdeDataType.String, 2),
        new JdeField("YTABR3", "YTABR3", JdeDataType.String, 24),
        new JdeField("YTABT3", "YTABT3", JdeDataType.String, 2),
        new JdeField("YTABR4", "YTABR4", JdeDataType.String, 24),
        new JdeField("YTABT4", "YTABT4", JdeDataType.String, 2),
        new JdeField("YTBLGRT", "YTBLGRT", JdeDataType.Numeric),
        new JdeField("YTRCHGAMT", "YTRCHGAMT", JdeDataType.Numeric),
        new JdeField("YTFBLGRT", "YTFBLGRT", JdeDataType.Numeric),
        new JdeField("YTFRCHGAMT", "YTFRCHGAMT", JdeDataType.Numeric),
        new JdeField("YTCRR", "YTCRR", JdeDataType.Numeric),
        new JdeField("YTCRCD", "YTCRCD", JdeDataType.String, 6),
        new JdeField("YTCRDC", "YTCRDC", JdeDataType.String, 6),
        new JdeField("YTRCHGMODE", "YTRCHGMODE", JdeDataType.String, 2),
        new JdeField("YTLTTP", "YTLTTP", JdeDataType.String, 4),
        new JdeField("YTRKID", "YTRKID", JdeDataType.Numeric),
        new JdeField("YTAPPRCFLG", "YTAPPRCFLG", JdeDataType.String, 2),
        new JdeField("YTOTRULECD", "YTOTRULECD", JdeDataType.String, 6),
        new JdeField("YTTSKID", "YTTSKID", JdeDataType.Numeric),
        new JdeField("YTTAXX", "YTTAXX", JdeDataType.String, 40),
        new JdeField("YTSCTR", "YTSCTR", JdeDataType.String, 2),
        new JdeField("YTSCRX", "YTSCRX", JdeDataType.String, 2),
        new JdeField("YTSVH", "YTSVH", JdeDataType.String, 2),
        new JdeField("YTTCFD", "YTTCFD", JdeDataType.Numeric),
        new JdeField("YTTCTD", "YTTCTD", JdeDataType.Numeric),
        new JdeField("YTHWPD", "YTHWPD", JdeDataType.Numeric),
        new JdeField("YTINSTID", "YTINSTID", JdeDataType.String, 72),
        new JdeField("YTJBLC", "YTJBLC", JdeDataType.String, 12),
        new JdeField("YTCOPX", "YTCOPX", JdeDataType.String, 2),
        new JdeField("YTBPTX", "YTBPTX", JdeDataType.Numeric),
        new JdeField("YTCOPB", "YTCOPB", JdeDataType.Numeric),
        new JdeField("YTCMED", "YTCMED", JdeDataType.String, 2),
        new JdeField("YTCOPR", "YTCOPR", JdeDataType.Numeric),
        new JdeField("YTGLBN", "YTGLBN", JdeDataType.Numeric),
        new JdeField("YTWCEX", "YTWCEX", JdeDataType.Numeric),
        new JdeField("YTGLEX", "YTGLEX", JdeDataType.Numeric),
        new JdeField("YTLDID", "YTLDID", JdeDataType.String, 10),
        new JdeField("YTLDED", "YTLDED", JdeDataType.Numeric),
        new JdeField("YTTTAP", "YTTTAP", JdeDataType.String, 2),
        new JdeField("YTINVA", "YTINVA", JdeDataType.String, 58),
        new JdeField("YTINRA", "YTINRA", JdeDataType.String, 58),
        new JdeField("YTINEA", "YTINEA", JdeDataType.String, 58),
        new JdeField("YTCRFL", "YTCRFL", JdeDataType.String, 2),
        new JdeField("YTCPTR", "YTCPTR", JdeDataType.Numeric),
        new JdeField("YTPCOR", "YTPCOR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S0618_0", "Primary Key on YTAN8, YTDWK, YTPRTR", new[] { "YTAN8", "YTDWK", "YTPRTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S0618_10", "Index on YTMCUO, YTPPED, YTPALF, YTAN8", new[] { "YTMCUO", "YTPPED", "YTPALF", "YTAN8" }),
        new JdeIndex("F48S0618_11", "Index on YTMCU, YTPPED", new[] { "YTMCU", "YTPPED" }),
        new JdeIndex("F48S0618_12", "Index on YTUN, YTPPED, YTAN8", new[] { "YTUN", "YTPPED", "YTAN8" }),
        new JdeIndex("F48S0618_13", "Index on YTAN8, YTCKCN, YTDWK", new[] { "YTAN8", "YTCKCN", "YTDWK" }),
        new JdeIndex("F48S0618_14", "Index on YTMCU, YTOBJ, YTSUB, YTSBL", new[] { "YTMCU", "YTOBJ", "YTSUB", "YTSBL" }),
        new JdeIndex("F48S0618_15", "Index on YTPRTR", new[] { "YTPRTR" }),
        new JdeIndex("F48S0618_16", "Index on YTAN8, YTCKDT", new[] { "YTAN8", "YTCKDT" }),
        new JdeIndex("F48S0618_18", "Index on YTGMCU, YTGOBJ, YTGSUB, YTSBL, YTSBLT, YTDGL, YTGICU, YTPDBA, YTJBCD, YTJBST", new[] { "YTGMCU", "YTGOBJ", "YTGSUB", "YTSBL", "YTSBLT", "YTDGL", "YTGICU", "YTPDBA", "YTJBCD", "YTJBST" }),
        new JdeIndex("F48S0618_19", "Index on YTMCU, YTOBJ, YTSUB, YTSBL, YTSBLT, YTDGL, YTGICU, YTPDBA, YTJBCD, YTJBST", new[] { "YTMCU", "YTOBJ", "YTSUB", "YTSBL", "YTSBLT", "YTDGL", "YTGICU", "YTPDBA", "YTJBCD", "YTJBST" }),
        new JdeIndex("F48S0618_2", "Index on YTAN8, YTCKCN, YTPDBA, YTPHRT", new[] { "YTAN8", "YTCKCN", "YTPDBA", "YTPHRT" }),
        new JdeIndex("F48S0618_20", "Index on YTMCU, YTQOBJ, YTSUB, YTSBL, YTSBLT, YTDGL, YTGICU", new[] { "YTMCU", "YTQOBJ", "YTSUB", "YTSBL", "YTSBLT", "YTDGL", "YTGICU" }),
        new JdeIndex("F48S0618_21", "Index on YTSBL, YTSBLT, YTOPSQ", new[] { "YTSBL", "YTSBLT", "YTOPSQ" }),
        new JdeIndex("F48S0618_22", "Index on YTGMCU, YTQOBJ, YTGSUB, YTSBL, YTSBLT, YTDGL, YTGICU", new[] { "YTGMCU", "YTQOBJ", "YTGSUB", "YTSBL", "YTSBLT", "YTDGL", "YTGICU" }),
        new JdeIndex("F48S0618_23", "Index on YTAN8, YTCKCN, YTPDBA, YTPRTR", new[] { "YTAN8", "YTCKCN", "YTPDBA", "YTPRTR" }),
        new JdeIndex("F48S0618_24", "Index on YTAN8, YTTSKID", new[] { "YTAN8", "YTTSKID" }),
        new JdeIndex("F48S0618_25", "Index on YTTSKID", new[] { "YTTSKID" }),
        new JdeIndex("F48S0618_26", "Index on YTAN8, YTOTRULECD", new[] { "YTAN8", "YTOTRULECD" }),
        new JdeIndex("F48S0618_3", "Index on YTMCU, YTDWK, YTAN8, YTJBCD", new[] { "YTMCU", "YTDWK", "YTAN8", "YTJBCD" }),
        new JdeIndex("F48S0618_4", "Index on YTGMCU, YTDWK", new[] { "YTGMCU", "YTDWK" }),
        new JdeIndex("F48S0618_5", "Index on YTAN8, YTPDBA, YTHMO, YTCKDT", new[] { "YTAN8", "YTPDBA", "YTHMO", "YTCKDT" }),
        new JdeIndex("F48S0618_6", "Index on YTMCU, YTAN8, YTDWK, YTPDBA", new[] { "YTMCU", "YTAN8", "YTDWK", "YTPDBA" }),
        new JdeIndex("F48S0618_7", "Index on YTMCU, YTSUB, YTAN8, YTDWK", new[] { "YTMCU", "YTSUB", "YTAN8", "YTDWK" }),
        new JdeIndex("F48S0618_8", "Index on YTMCUO, YTJBCD, YTJBST, YTAN8", new[] { "YTMCUO", "YTJBCD", "YTJBST", "YTAN8" }),
        new JdeIndex("F48S0618_9", "Index on YTAN8, YTPPED, YTUN, YTPDBA", new[] { "YTAN8", "YTPPED", "YTUN", "YTPDBA" })
    };
}
