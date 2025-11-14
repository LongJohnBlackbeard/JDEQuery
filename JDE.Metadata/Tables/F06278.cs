using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06278 - .
/// </summary>
public class F06278 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YTVERS.
        /// </summary>
        public const string YTVERS = "YTVERS";

        /// <summary>
        /// YTAN8.
        /// </summary>
        public const string YTAN8 = "YTAN8";

        /// <summary>
        /// YTSSN.
        /// </summary>
        public const string YTSSN = "YTSSN";

        /// <summary>
        /// YTOEMP.
        /// </summary>
        public const string YTOEMP = "YTOEMP";

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
        /// YTPAYM.
        /// </summary>
        public const string YTPAYM = "YTPAYM";

        /// <summary>
        /// YTSHFT.
        /// </summary>
        public const string YTSHFT = "YTSHFT";

        /// <summary>
        /// YTSHD.
        /// </summary>
        public const string YTSHD = "YTSHD";

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
        /// YTYST.
        /// </summary>
        public const string YTYST = "YTYST";

        /// <summary>
        /// YTICU.
        /// </summary>
        public const string YTICU = "YTICU";

        /// <summary>
        /// YTGICU.
        /// </summary>
        public const string YTGICU = "YTGICU";

        /// <summary>
        /// YTDICJ.
        /// </summary>
        public const string YTDICJ = "YTDICJ";

        /// <summary>
        /// YTUPMJ.
        /// </summary>
        public const string YTUPMJ = "YTUPMJ";

        /// <summary>
        /// YTPID.
        /// </summary>
        public const string YTPID = "YTPID";

        /// <summary>
        /// YTANI.
        /// </summary>
        public const string YTANI = "YTANI";

        /// <summary>
        /// YTCTRY.
        /// </summary>
        public const string YTCTRY = "YTCTRY";

        /// <summary>
        /// YTANN8.
        /// </summary>
        public const string YTANN8 = "YTANN8";

        /// <summary>
        /// YTPGRP.
        /// </summary>
        public const string YTPGRP = "YTPGRP";

        /// <summary>
        /// YTPAYG.
        /// </summary>
        public const string YTPAYG = "YTPAYG";

        /// <summary>
        /// YTPAYN.
        /// </summary>
        public const string YTPAYN = "YTPAYN";

        /// <summary>
        /// YTSFLG.
        /// </summary>
        public const string YTSFLG = "YTSFLG";

        /// <summary>
        /// YTWS.
        /// </summary>
        public const string YTWS = "YTWS";

        /// <summary>
        /// YTPCK.
        /// </summary>
        public const string YTPCK = "YTPCK";

        /// <summary>
        /// YTICC.
        /// </summary>
        public const string YTICC = "YTICC";

        /// <summary>
        /// YTICS.
        /// </summary>
        public const string YTICS = "YTICS";

        /// <summary>
        /// YTCMTH.
        /// </summary>
        public const string YTCMTH = "YTCMTH";

        /// <summary>
        /// YTACO.
        /// </summary>
        public const string YTACO = "YTACO";

        /// <summary>
        /// YTAI.
        /// </summary>
        public const string YTAI = "YTAI";

        /// <summary>
        /// YTSEC$.
        /// </summary>
        public const string YTSEC_ = "YTSEC$";

        /// <summary>
        /// YTOHF.
        /// </summary>
        public const string YTOHF = "YTOHF";

        /// <summary>
        /// YTDEP1.
        /// </summary>
        public const string YTDEP1 = "YTDEP1";

        /// <summary>
        /// YTDEP2.
        /// </summary>
        public const string YTDEP2 = "YTDEP2";

        /// <summary>
        /// YTDEP3.
        /// </summary>
        public const string YTDEP3 = "YTDEP3";

        /// <summary>
        /// YTDEP4.
        /// </summary>
        public const string YTDEP4 = "YTDEP4";

        /// <summary>
        /// YTDEP5.
        /// </summary>
        public const string YTDEP5 = "YTDEP5";

        /// <summary>
        /// YTTT01.
        /// </summary>
        public const string YTTT01 = "YTTT01";

        /// <summary>
        /// YTTT02.
        /// </summary>
        public const string YTTT02 = "YTTT02";

        /// <summary>
        /// YTTT03.
        /// </summary>
        public const string YTTT03 = "YTTT03";

        /// <summary>
        /// YTTT04.
        /// </summary>
        public const string YTTT04 = "YTTT04";

        /// <summary>
        /// YTTT05.
        /// </summary>
        public const string YTTT05 = "YTTT05";

        /// <summary>
        /// YTTT06.
        /// </summary>
        public const string YTTT06 = "YTTT06";

        /// <summary>
        /// YTTT07.
        /// </summary>
        public const string YTTT07 = "YTTT07";

        /// <summary>
        /// YTTT08.
        /// </summary>
        public const string YTTT08 = "YTTT08";

        /// <summary>
        /// YTTT09.
        /// </summary>
        public const string YTTT09 = "YTTT09";

        /// <summary>
        /// YTTT10.
        /// </summary>
        public const string YTTT10 = "YTTT10";

        /// <summary>
        /// YTTT11.
        /// </summary>
        public const string YTTT11 = "YTTT11";

        /// <summary>
        /// YTTT12.
        /// </summary>
        public const string YTTT12 = "YTTT12";

        /// <summary>
        /// YTTT13.
        /// </summary>
        public const string YTTT13 = "YTTT13";

        /// <summary>
        /// YTTT14.
        /// </summary>
        public const string YTTT14 = "YTTT14";

        /// <summary>
        /// YTTT15.
        /// </summary>
        public const string YTTT15 = "YTTT15";

        /// <summary>
        /// YTUSR.
        /// </summary>
        public const string YTUSR = "YTUSR";

        /// <summary>
        /// YTEPA.
        /// </summary>
        public const string YTEPA = "YTEPA";

        /// <summary>
        /// YTBFA.
        /// </summary>
        public const string YTBFA = "YTBFA";

        /// <summary>
        /// YTRTWC.
        /// </summary>
        public const string YTRTWC = "YTRTWC";

        /// <summary>
        /// YTGENR.
        /// </summary>
        public const string YTGENR = "YTGENR";

        /// <summary>
        /// YTADV.
        /// </summary>
        public const string YTADV = "YTADV";

        /// <summary>
        /// YTSTIP.
        /// </summary>
        public const string YTSTIP = "YTSTIP";

        /// <summary>
        /// YTALPH.
        /// </summary>
        public const string YTALPH = "YTALPH";

        /// <summary>
        /// YTIIAP.
        /// </summary>
        public const string YTIIAP = "YTIIAP";

        /// <summary>
        /// YTFICM.
        /// </summary>
        public const string YTFICM = "YTFICM";

        /// <summary>
        /// YTDTAB.
        /// </summary>
        public const string YTDTAB = "YTDTAB";

        /// <summary>
        /// YTDTSP.
        /// </summary>
        public const string YTDTSP = "YTDTSP";

        /// <summary>
        /// YTYST1.
        /// </summary>
        public const string YTYST1 = "YTYST1";

        /// <summary>
        /// YTRPM.
        /// </summary>
        public const string YTRPM = "YTRPM";

        /// <summary>
        /// YTRTHR.
        /// </summary>
        public const string YTRTHR = "YTRTHR";

        /// <summary>
        /// YTRTBR.
        /// </summary>
        public const string YTRTBR = "YTRTBR";

        /// <summary>
        /// YTRTPR.
        /// </summary>
        public const string YTRTPR = "YTRTPR";

        /// <summary>
        /// YTRTGP.
        /// </summary>
        public const string YTRTGP = "YTRTGP";

        /// <summary>
        /// YTRTBP.
        /// </summary>
        public const string YTRTBP = "YTRTBP";

        /// <summary>
        /// YTRTDP.
        /// </summary>
        public const string YTRTDP = "YTRTDP";

        /// <summary>
        /// YTRTGE.
        /// </summary>
        public const string YTRTGE = "YTRTGE";

        /// <summary>
        /// YTRTAC.
        /// </summary>
        public const string YTRTAC = "YTRTAC";

        /// <summary>
        /// YTRTCS.
        /// </summary>
        public const string YTRTCS = "YTRTCS";

        /// <summary>
        /// YTRTRT.
        /// </summary>
        public const string YTRTRT = "YTRTRT";
    }

    /// <inheritdoc />
    public override string TableName => "F06278";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YTVERS", "YTVERS", JdeDataType.String, 20, true, true),
        new JdeField("YTAN8", "YTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YTSSN", "YTSSN", JdeDataType.String, 40),
        new JdeField("YTOEMP", "YTOEMP", JdeDataType.String, 16),
        new JdeField("YTPALF", "YTPALF", JdeDataType.String, 24),
        new JdeField("YTPRTR", "YTPRTR", JdeDataType.Numeric),
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
        new JdeField("YTGPA", "YTGPA", JdeDataType.Numeric),
        new JdeField("YTDPA", "YTDPA", JdeDataType.Numeric),
        new JdeField("YTRCPY", "YTRCPY", JdeDataType.Numeric),
        new JdeField("YTSAMT", "YTSAMT", JdeDataType.Numeric),
        new JdeField("YTUN", "YTUN", JdeDataType.String, 12, true, true),
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
        new JdeField("YTHMO", "YTHMO", JdeDataType.Numeric),
        new JdeField("YTPDBA", "YTPDBA", JdeDataType.Numeric),
        new JdeField("YTPB", "YTPB", JdeDataType.String, 2),
        new JdeField("YTDEDM", "YTDEDM", JdeDataType.String, 2),
        new JdeField("YTPAYM", "YTPAYM", JdeDataType.Numeric),
        new JdeField("YTSHFT", "YTSHFT", JdeDataType.String, 2),
        new JdeField("YTSHD", "YTSHD", JdeDataType.Numeric),
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
        new JdeField("YTYST", "YTYST", JdeDataType.String, 2),
        new JdeField("YTICU", "YTICU", JdeDataType.Numeric),
        new JdeField("YTGICU", "YTGICU", JdeDataType.Numeric),
        new JdeField("YTDICJ", "YTDICJ", JdeDataType.Numeric),
        new JdeField("YTUPMJ", "YTUPMJ", JdeDataType.Numeric),
        new JdeField("YTPID", "YTPID", JdeDataType.String, 20),
        new JdeField("YTANI", "YTANI", JdeDataType.String, 58),
        new JdeField("YTCTRY", "YTCTRY", JdeDataType.Numeric),
        new JdeField("YTANN8", "YTANN8", JdeDataType.Numeric),
        new JdeField("YTPGRP", "YTPGRP", JdeDataType.String, 4),
        new JdeField("YTPAYG", "YTPAYG", JdeDataType.String, 2),
        new JdeField("YTPAYN", "YTPAYN", JdeDataType.String, 2),
        new JdeField("YTSFLG", "YTSFLG", JdeDataType.String, 2),
        new JdeField("YTWS", "YTWS", JdeDataType.String, 2),
        new JdeField("YTPCK", "YTPCK", JdeDataType.String, 2),
        new JdeField("YTICC", "YTICC", JdeDataType.String, 2),
        new JdeField("YTICS", "YTICS", JdeDataType.String, 2),
        new JdeField("YTCMTH", "YTCMTH", JdeDataType.String, 2),
        new JdeField("YTACO", "YTACO", JdeDataType.String, 2),
        new JdeField("YTAI", "YTAI", JdeDataType.String, 2),
        new JdeField("YTSEC$", "YTSEC$", JdeDataType.String, 2),
        new JdeField("YTOHF", "YTOHF", JdeDataType.String, 2),
        new JdeField("YTDEP1", "YTDEP1", JdeDataType.String, 2),
        new JdeField("YTDEP2", "YTDEP2", JdeDataType.String, 2),
        new JdeField("YTDEP3", "YTDEP3", JdeDataType.String, 2),
        new JdeField("YTDEP4", "YTDEP4", JdeDataType.String, 2),
        new JdeField("YTDEP5", "YTDEP5", JdeDataType.String, 2),
        new JdeField("YTTT01", "YTTT01", JdeDataType.String, 4),
        new JdeField("YTTT02", "YTTT02", JdeDataType.String, 4),
        new JdeField("YTTT03", "YTTT03", JdeDataType.String, 4),
        new JdeField("YTTT04", "YTTT04", JdeDataType.String, 4),
        new JdeField("YTTT05", "YTTT05", JdeDataType.String, 4),
        new JdeField("YTTT06", "YTTT06", JdeDataType.String, 4),
        new JdeField("YTTT07", "YTTT07", JdeDataType.String, 4),
        new JdeField("YTTT08", "YTTT08", JdeDataType.String, 4),
        new JdeField("YTTT09", "YTTT09", JdeDataType.String, 4),
        new JdeField("YTTT10", "YTTT10", JdeDataType.String, 4),
        new JdeField("YTTT11", "YTTT11", JdeDataType.String, 4),
        new JdeField("YTTT12", "YTTT12", JdeDataType.String, 4),
        new JdeField("YTTT13", "YTTT13", JdeDataType.String, 4),
        new JdeField("YTTT14", "YTTT14", JdeDataType.String, 4),
        new JdeField("YTTT15", "YTTT15", JdeDataType.String, 4),
        new JdeField("YTUSR", "YTUSR", JdeDataType.String, 36),
        new JdeField("YTEPA", "YTEPA", JdeDataType.Numeric),
        new JdeField("YTBFA", "YTBFA", JdeDataType.Numeric),
        new JdeField("YTRTWC", "YTRTWC", JdeDataType.Numeric),
        new JdeField("YTGENR", "YTGENR", JdeDataType.Numeric),
        new JdeField("YTADV", "YTADV", JdeDataType.String, 2),
        new JdeField("YTSTIP", "YTSTIP", JdeDataType.String, 2),
        new JdeField("YTALPH", "YTALPH", JdeDataType.String, 80),
        new JdeField("YTIIAP", "YTIIAP", JdeDataType.String, 2),
        new JdeField("YTFICM", "YTFICM", JdeDataType.String, 2),
        new JdeField("YTDTAB", "YTDTAB", JdeDataType.String, 10),
        new JdeField("YTDTSP", "YTDTSP", JdeDataType.Numeric),
        new JdeField("YTYST1", "YTYST1", JdeDataType.String, 2),
        new JdeField("YTRPM", "YTRPM", JdeDataType.String, 2),
        new JdeField("YTRTHR", "YTRTHR", JdeDataType.Numeric),
        new JdeField("YTRTBR", "YTRTBR", JdeDataType.Numeric),
        new JdeField("YTRTPR", "YTRTPR", JdeDataType.Numeric),
        new JdeField("YTRTGP", "YTRTGP", JdeDataType.Numeric),
        new JdeField("YTRTBP", "YTRTBP", JdeDataType.Numeric),
        new JdeField("YTRTDP", "YTRTDP", JdeDataType.Numeric),
        new JdeField("YTRTGE", "YTRTGE", JdeDataType.Numeric),
        new JdeField("YTRTAC", "YTRTAC", JdeDataType.String, 2),
        new JdeField("YTRTCS", "YTRTCS", JdeDataType.String, 2),
        new JdeField("YTRTRT", "YTRTRT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06278_0", "Primary Key on YTVERS, YTAN8, YTUN, YTDWK", new[] { "YTVERS", "YTAN8", "YTUN", "YTDWK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06278_2", "Index on YTVERS, YTSSN, YTUN, YTDWK", new[] { "YTVERS", "YTSSN", "YTUN", "YTDWK" }),
        new JdeIndex("F06278_3", "Index on YTVERS, YTAN8, YTPDBA", new[] { "YTVERS", "YTAN8", "YTPDBA" }),
        new JdeIndex("F06278_4", "Index on YTVERS, YTUN, YTJBCD, YTJBST", new[] { "YTVERS", "YTUN", "YTJBCD", "YTJBST" }),
        new JdeIndex("F06278_5", "Index on YTVERS, YTAN8, YTDWK", new[] { "YTVERS", "YTAN8", "YTDWK" }),
        new JdeIndex("F06278_6", "Index on YTVERS, YTJBCD, YTJBST", new[] { "YTVERS", "YTJBCD", "YTJBST" }),
        new JdeIndex("F06278_7", "Index on YTVERS, YTAN8, YTPRTR", new[] { "YTVERS", "YTAN8", "YTPRTR" }),
        new JdeIndex("F06278_8", "Index on YTAN8", new[] { "YTAN8" })
    };
}
