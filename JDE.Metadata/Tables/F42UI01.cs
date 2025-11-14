using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI01 - .
/// </summary>
public class F42UI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZHCTID.
        /// </summary>
        public const string ZHCTID = "ZHCTID";

        /// <summary>
        /// ZHJOBS.
        /// </summary>
        public const string ZHJOBS = "ZHJOBS";

        /// <summary>
        /// ZHPEID.
        /// </summary>
        public const string ZHPEID = "ZHPEID";

        /// <summary>
        /// ZHTCID.
        /// </summary>
        public const string ZHTCID = "ZHTCID";

        /// <summary>
        /// ZHACTN.
        /// </summary>
        public const string ZHACTN = "ZHACTN";

        /// <summary>
        /// ZHKCOO.
        /// </summary>
        public const string ZHKCOO = "ZHKCOO";

        /// <summary>
        /// ZHDOCO.
        /// </summary>
        public const string ZHDOCO = "ZHDOCO";

        /// <summary>
        /// ZHDCTO.
        /// </summary>
        public const string ZHDCTO = "ZHDCTO";

        /// <summary>
        /// ZHSFXO.
        /// </summary>
        public const string ZHSFXO = "ZHSFXO";

        /// <summary>
        /// ZHMCU.
        /// </summary>
        public const string ZHMCU = "ZHMCU";

        /// <summary>
        /// ZHCO.
        /// </summary>
        public const string ZHCO = "ZHCO";

        /// <summary>
        /// ZHOKCO.
        /// </summary>
        public const string ZHOKCO = "ZHOKCO";

        /// <summary>
        /// ZHOORN.
        /// </summary>
        public const string ZHOORN = "ZHOORN";

        /// <summary>
        /// ZHOCTO.
        /// </summary>
        public const string ZHOCTO = "ZHOCTO";

        /// <summary>
        /// ZHRKCO.
        /// </summary>
        public const string ZHRKCO = "ZHRKCO";

        /// <summary>
        /// ZHRORN.
        /// </summary>
        public const string ZHRORN = "ZHRORN";

        /// <summary>
        /// ZHRCTO.
        /// </summary>
        public const string ZHRCTO = "ZHRCTO";

        /// <summary>
        /// ZHAN8.
        /// </summary>
        public const string ZHAN8 = "ZHAN8";

        /// <summary>
        /// ZHSHAN.
        /// </summary>
        public const string ZHSHAN = "ZHSHAN";

        /// <summary>
        /// ZHPA8.
        /// </summary>
        public const string ZHPA8 = "ZHPA8";

        /// <summary>
        /// ZHDRQJ.
        /// </summary>
        public const string ZHDRQJ = "ZHDRQJ";

        /// <summary>
        /// ZHTRDJ.
        /// </summary>
        public const string ZHTRDJ = "ZHTRDJ";

        /// <summary>
        /// ZHPDDJ.
        /// </summary>
        public const string ZHPDDJ = "ZHPDDJ";

        /// <summary>
        /// ZHOPDJ.
        /// </summary>
        public const string ZHOPDJ = "ZHOPDJ";

        /// <summary>
        /// ZHADDJ.
        /// </summary>
        public const string ZHADDJ = "ZHADDJ";

        /// <summary>
        /// ZHCNDJ.
        /// </summary>
        public const string ZHCNDJ = "ZHCNDJ";

        /// <summary>
        /// ZHPEFJ.
        /// </summary>
        public const string ZHPEFJ = "ZHPEFJ";

        /// <summary>
        /// ZHPPDJ.
        /// </summary>
        public const string ZHPPDJ = "ZHPPDJ";

        /// <summary>
        /// ZHVR01.
        /// </summary>
        public const string ZHVR01 = "ZHVR01";

        /// <summary>
        /// ZHVR02.
        /// </summary>
        public const string ZHVR02 = "ZHVR02";

        /// <summary>
        /// ZHDEL1.
        /// </summary>
        public const string ZHDEL1 = "ZHDEL1";

        /// <summary>
        /// ZHDEL2.
        /// </summary>
        public const string ZHDEL2 = "ZHDEL2";

        /// <summary>
        /// ZHINMG.
        /// </summary>
        public const string ZHINMG = "ZHINMG";

        /// <summary>
        /// ZHPTC.
        /// </summary>
        public const string ZHPTC = "ZHPTC";

        /// <summary>
        /// ZHRYIN.
        /// </summary>
        public const string ZHRYIN = "ZHRYIN";

        /// <summary>
        /// ZHASN.
        /// </summary>
        public const string ZHASN = "ZHASN";

        /// <summary>
        /// ZHPRGP.
        /// </summary>
        public const string ZHPRGP = "ZHPRGP";

        /// <summary>
        /// ZHTRDC.
        /// </summary>
        public const string ZHTRDC = "ZHTRDC";

        /// <summary>
        /// ZHPCRT.
        /// </summary>
        public const string ZHPCRT = "ZHPCRT";

        /// <summary>
        /// ZHTXA1.
        /// </summary>
        public const string ZHTXA1 = "ZHTXA1";

        /// <summary>
        /// ZHEXR1.
        /// </summary>
        public const string ZHEXR1 = "ZHEXR1";

        /// <summary>
        /// ZHTXCT.
        /// </summary>
        public const string ZHTXCT = "ZHTXCT";

        /// <summary>
        /// ZHATXT.
        /// </summary>
        public const string ZHATXT = "ZHATXT";

        /// <summary>
        /// ZHPRIO.
        /// </summary>
        public const string ZHPRIO = "ZHPRIO";

        /// <summary>
        /// ZHBACK.
        /// </summary>
        public const string ZHBACK = "ZHBACK";

        /// <summary>
        /// ZHSBAL.
        /// </summary>
        public const string ZHSBAL = "ZHSBAL";

        /// <summary>
        /// ZHHOLD.
        /// </summary>
        public const string ZHHOLD = "ZHHOLD";

        /// <summary>
        /// ZHPLST.
        /// </summary>
        public const string ZHPLST = "ZHPLST";

        /// <summary>
        /// ZHINVC.
        /// </summary>
        public const string ZHINVC = "ZHINVC";

        /// <summary>
        /// ZHNTR.
        /// </summary>
        public const string ZHNTR = "ZHNTR";

        /// <summary>
        /// ZHANBY.
        /// </summary>
        public const string ZHANBY = "ZHANBY";

        /// <summary>
        /// ZHCARS.
        /// </summary>
        public const string ZHCARS = "ZHCARS";

        /// <summary>
        /// ZHMOT.
        /// </summary>
        public const string ZHMOT = "ZHMOT";

        /// <summary>
        /// ZHCOT.
        /// </summary>
        public const string ZHCOT = "ZHCOT";

        /// <summary>
        /// ZHROUT.
        /// </summary>
        public const string ZHROUT = "ZHROUT";

        /// <summary>
        /// ZHSTOP.
        /// </summary>
        public const string ZHSTOP = "ZHSTOP";

        /// <summary>
        /// ZHZON.
        /// </summary>
        public const string ZHZON = "ZHZON";

        /// <summary>
        /// ZHCNID.
        /// </summary>
        public const string ZHCNID = "ZHCNID";

        /// <summary>
        /// ZHFRTH.
        /// </summary>
        public const string ZHFRTH = "ZHFRTH";

        /// <summary>
        /// ZHAFT.
        /// </summary>
        public const string ZHAFT = "ZHAFT";

        /// <summary>
        /// ZHFUF1.
        /// </summary>
        public const string ZHFUF1 = "ZHFUF1";

        /// <summary>
        /// ZHFRTC.
        /// </summary>
        public const string ZHFRTC = "ZHFRTC";

        /// <summary>
        /// ZHMORD.
        /// </summary>
        public const string ZHMORD = "ZHMORD";

        /// <summary>
        /// ZHRCD.
        /// </summary>
        public const string ZHRCD = "ZHRCD";

        /// <summary>
        /// ZHFUF2.
        /// </summary>
        public const string ZHFUF2 = "ZHFUF2";

        /// <summary>
        /// ZHOTOT.
        /// </summary>
        public const string ZHOTOT = "ZHOTOT";

        /// <summary>
        /// ZHTOTC.
        /// </summary>
        public const string ZHTOTC = "ZHTOTC";

        /// <summary>
        /// ZHWUMD.
        /// </summary>
        public const string ZHWUMD = "ZHWUMD";

        /// <summary>
        /// ZHVUMD.
        /// </summary>
        public const string ZHVUMD = "ZHVUMD";

        /// <summary>
        /// ZHAUTN.
        /// </summary>
        public const string ZHAUTN = "ZHAUTN";

        /// <summary>
        /// ZHCACT.
        /// </summary>
        public const string ZHCACT = "ZHCACT";

        /// <summary>
        /// ZHCEXP.
        /// </summary>
        public const string ZHCEXP = "ZHCEXP";

        /// <summary>
        /// ZHSBLI.
        /// </summary>
        public const string ZHSBLI = "ZHSBLI";

        /// <summary>
        /// ZHCRMD.
        /// </summary>
        public const string ZHCRMD = "ZHCRMD";

        /// <summary>
        /// ZHCRRM.
        /// </summary>
        public const string ZHCRRM = "ZHCRRM";

        /// <summary>
        /// ZHCRCD.
        /// </summary>
        public const string ZHCRCD = "ZHCRCD";

        /// <summary>
        /// ZHCRR.
        /// </summary>
        public const string ZHCRR = "ZHCRR";

        /// <summary>
        /// ZHLNGP.
        /// </summary>
        public const string ZHLNGP = "ZHLNGP";

        /// <summary>
        /// ZHFAP.
        /// </summary>
        public const string ZHFAP = "ZHFAP";

        /// <summary>
        /// ZHFCST.
        /// </summary>
        public const string ZHFCST = "ZHFCST";

        /// <summary>
        /// ZHORBY.
        /// </summary>
        public const string ZHORBY = "ZHORBY";

        /// <summary>
        /// ZHTKBY.
        /// </summary>
        public const string ZHTKBY = "ZHTKBY";

        /// <summary>
        /// ZHURCD.
        /// </summary>
        public const string ZHURCD = "ZHURCD";

        /// <summary>
        /// ZHURDT.
        /// </summary>
        public const string ZHURDT = "ZHURDT";

        /// <summary>
        /// ZHURAT.
        /// </summary>
        public const string ZHURAT = "ZHURAT";

        /// <summary>
        /// ZHURAB.
        /// </summary>
        public const string ZHURAB = "ZHURAB";

        /// <summary>
        /// ZHURRF.
        /// </summary>
        public const string ZHURRF = "ZHURRF";

        /// <summary>
        /// ZHUSER.
        /// </summary>
        public const string ZHUSER = "ZHUSER";

        /// <summary>
        /// ZHPID.
        /// </summary>
        public const string ZHPID = "ZHPID";

        /// <summary>
        /// ZHJOBN.
        /// </summary>
        public const string ZHJOBN = "ZHJOBN";

        /// <summary>
        /// ZHUPMJ.
        /// </summary>
        public const string ZHUPMJ = "ZHUPMJ";

        /// <summary>
        /// ZHTDAY.
        /// </summary>
        public const string ZHTDAY = "ZHTDAY";

        /// <summary>
        /// ZHAPTS.
        /// </summary>
        public const string ZHAPTS = "ZHAPTS";

        /// <summary>
        /// ZHEDF2.
        /// </summary>
        public const string ZHEDF2 = "ZHEDF2";

        /// <summary>
        /// ZHMAXO.
        /// </summary>
        public const string ZHMAXO = "ZHMAXO";

        /// <summary>
        /// ZHMINO.
        /// </summary>
        public const string ZHMINO = "ZHMINO";

        /// <summary>
        /// ZHSI01.
        /// </summary>
        public const string ZHSI01 = "ZHSI01";

        /// <summary>
        /// ZHEDSP.
        /// </summary>
        public const string ZHEDSP = "ZHEDSP";

        /// <summary>
        /// ZHDTE.
        /// </summary>
        public const string ZHDTE = "ZHDTE";

        /// <summary>
        /// ZHADVP.
        /// </summary>
        public const string ZHADVP = "ZHADVP";

        /// <summary>
        /// ZHCP01.
        /// </summary>
        public const string ZHCP01 = "ZHCP01";

        /// <summary>
        /// ZHUMB1.
        /// </summary>
        public const string ZHUMB1 = "ZHUMB1";

        /// <summary>
        /// ZHBUMC.
        /// </summary>
        public const string ZHBUMC = "ZHBUMC";

        /// <summary>
        /// ZHCRDC.
        /// </summary>
        public const string ZHCRDC = "ZHCRDC";

        /// <summary>
        /// ZHCRRD.
        /// </summary>
        public const string ZHCRRD = "ZHCRRD";

        /// <summary>
        /// ZHCPGP.
        /// </summary>
        public const string ZHCPGP = "ZHCPGP";

        /// <summary>
        /// ZHLNIX.
        /// </summary>
        public const string ZHLNIX = "ZHLNIX";

        /// <summary>
        /// ZHORNN.
        /// </summary>
        public const string ZHORNN = "ZHORNN";

        /// <summary>
        /// ZHAPRC.
        /// </summary>
        public const string ZHAPRC = "ZHAPRC";

        /// <summary>
        /// ZHAOPN.
        /// </summary>
        public const string ZHAOPN = "ZHAOPN";

        /// <summary>
        /// ZHFY.
        /// </summary>
        public const string ZHFY = "ZHFY";

        /// <summary>
        /// ZHCTRY.
        /// </summary>
        public const string ZHCTRY = "ZHCTRY";

        /// <summary>
        /// ZHTRR1.
        /// </summary>
        public const string ZHTRR1 = "ZHTRR1";

        /// <summary>
        /// ZHTRR2.
        /// </summary>
        public const string ZHTRR2 = "ZHTRR2";

        /// <summary>
        /// ZHCRCM.
        /// </summary>
        public const string ZHCRCM = "ZHCRCM";

        /// <summary>
        /// ZHTRD1.
        /// </summary>
        public const string ZHTRD1 = "ZHTRD1";

        /// <summary>
        /// ZHTRD2.
        /// </summary>
        public const string ZHTRD2 = "ZHTRD2";

        /// <summary>
        /// ZHDCFL.
        /// </summary>
        public const string ZHDCFL = "ZHDCFL";

        /// <summary>
        /// ZHRCUP.
        /// </summary>
        public const string ZHRCUP = "ZHRCUP";

        /// <summary>
        /// ZHLNID.
        /// </summary>
        public const string ZHLNID = "ZHLNID";

        /// <summary>
        /// ZHVVTX.
        /// </summary>
        public const string ZHVVTX = "ZHVVTX";

        /// <summary>
        /// ZHTRAR.
        /// </summary>
        public const string ZHTRAR = "ZHTRAR";

        /// <summary>
        /// ZHEXR0.
        /// </summary>
        public const string ZHEXR0 = "ZHEXR0";

        /// <summary>
        /// ZHCRCE.
        /// </summary>
        public const string ZHCRCE = "ZHCRCE";

        /// <summary>
        /// ZHIAN8.
        /// </summary>
        public const string ZHIAN8 = "ZHIAN8";

        /// <summary>
        /// ZHIR01.
        /// </summary>
        public const string ZHIR01 = "ZHIR01";

        /// <summary>
        /// ZHIR02.
        /// </summary>
        public const string ZHIR02 = "ZHIR02";

        /// <summary>
        /// ZHIR03.
        /// </summary>
        public const string ZHIR03 = "ZHIR03";

        /// <summary>
        /// ZHIR04.
        /// </summary>
        public const string ZHIR04 = "ZHIR04";

        /// <summary>
        /// ZHIR05.
        /// </summary>
        public const string ZHIR05 = "ZHIR05";

        /// <summary>
        /// ZHVR03.
        /// </summary>
        public const string ZHVR03 = "ZHVR03";

        /// <summary>
        /// ZHSOOR.
        /// </summary>
        public const string ZHSOOR = "ZHSOOR";

        /// <summary>
        /// ZHPMDT.
        /// </summary>
        public const string ZHPMDT = "ZHPMDT";

        /// <summary>
        /// ZHRSDT.
        /// </summary>
        public const string ZHRSDT = "ZHRSDT";

        /// <summary>
        /// ZHRQSJ.
        /// </summary>
        public const string ZHRQSJ = "ZHRQSJ";

        /// <summary>
        /// ZHPSTM.
        /// </summary>
        public const string ZHPSTM = "ZHPSTM";

        /// <summary>
        /// ZHPDTT.
        /// </summary>
        public const string ZHPDTT = "ZHPDTT";

        /// <summary>
        /// ZHOPTT.
        /// </summary>
        public const string ZHOPTT = "ZHOPTT";

        /// <summary>
        /// ZHDRQT.
        /// </summary>
        public const string ZHDRQT = "ZHDRQT";

        /// <summary>
        /// ZHADTM.
        /// </summary>
        public const string ZHADTM = "ZHADTM";

        /// <summary>
        /// ZHADLJ.
        /// </summary>
        public const string ZHADLJ = "ZHADLJ";

        /// <summary>
        /// ZHPBAN.
        /// </summary>
        public const string ZHPBAN = "ZHPBAN";

        /// <summary>
        /// ZHITAN.
        /// </summary>
        public const string ZHITAN = "ZHITAN";

        /// <summary>
        /// ZHFTAN.
        /// </summary>
        public const string ZHFTAN = "ZHFTAN";

        /// <summary>
        /// ZHDVAN.
        /// </summary>
        public const string ZHDVAN = "ZHDVAN";

        /// <summary>
        /// ZHDOC1.
        /// </summary>
        public const string ZHDOC1 = "ZHDOC1";

        /// <summary>
        /// ZHDCT4.
        /// </summary>
        public const string ZHDCT4 = "ZHDCT4";

        /// <summary>
        /// ZHCORD.
        /// </summary>
        public const string ZHCORD = "ZHCORD";

        /// <summary>
        /// ZHBSC.
        /// </summary>
        public const string ZHBSC = "ZHBSC";

        /// <summary>
        /// ZHBCRC.
        /// </summary>
        public const string ZHBCRC = "ZHBCRC";

        /// <summary>
        /// ZHAUFT.
        /// </summary>
        public const string ZHAUFT = "ZHAUFT";

        /// <summary>
        /// ZHAUFI.
        /// </summary>
        public const string ZHAUFI = "ZHAUFI";

        /// <summary>
        /// ZHOPBO.
        /// </summary>
        public const string ZHOPBO = "ZHOPBO";

        /// <summary>
        /// ZHOPTC.
        /// </summary>
        public const string ZHOPTC = "ZHOPTC";

        /// <summary>
        /// ZHOPLD.
        /// </summary>
        public const string ZHOPLD = "ZHOPLD";

        /// <summary>
        /// ZHOPBK.
        /// </summary>
        public const string ZHOPBK = "ZHOPBK";

        /// <summary>
        /// ZHOPSB.
        /// </summary>
        public const string ZHOPSB = "ZHOPSB";

        /// <summary>
        /// ZHOPPS.
        /// </summary>
        public const string ZHOPPS = "ZHOPPS";

        /// <summary>
        /// ZHOPPL.
        /// </summary>
        public const string ZHOPPL = "ZHOPPL";

        /// <summary>
        /// ZHOPMS.
        /// </summary>
        public const string ZHOPMS = "ZHOPMS";

        /// <summary>
        /// ZHOPSS.
        /// </summary>
        public const string ZHOPSS = "ZHOPSS";

        /// <summary>
        /// ZHOPBA.
        /// </summary>
        public const string ZHOPBA = "ZHOPBA";

        /// <summary>
        /// ZHOPLL.
        /// </summary>
        public const string ZHOPLL = "ZHOPLL";

        /// <summary>
        /// ZHSOEF.
        /// </summary>
        public const string ZHSOEF = "ZHSOEF";

        /// <summary>
        /// ZHPRAN8.
        /// </summary>
        public const string ZHPRAN8 = "ZHPRAN8";

        /// <summary>
        /// ZHOPPID.
        /// </summary>
        public const string ZHOPPID = "ZHOPPID";

        /// <summary>
        /// ZHSDATTN.
        /// </summary>
        public const string ZHSDATTN = "ZHSDATTN";

        /// <summary>
        /// ZHSPATTN.
        /// </summary>
        public const string ZHSPATTN = "ZHSPATTN";

        /// <summary>
        /// ZHOTIND.
        /// </summary>
        public const string ZHOTIND = "ZHOTIND";

        /// <summary>
        /// ZHPRCIDLN.
        /// </summary>
        public const string ZHPRCIDLN = "ZHPRCIDLN";

        /// <summary>
        /// ZHCCIDLN.
        /// </summary>
        public const string ZHCCIDLN = "ZHCCIDLN";

        /// <summary>
        /// ZHSHCCIDLN.
        /// </summary>
        public const string ZHSHCCIDLN = "ZHSHCCIDLN";

        /// <summary>
        /// ZHUTP.
        /// </summary>
        public const string ZHUTP = "ZHUTP";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZHCTID", "ZHCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZHJOBS", "ZHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHPEID", "ZHPEID", JdeDataType.Numeric),
        new JdeField("ZHTCID", "ZHTCID", JdeDataType.Numeric),
        new JdeField("ZHACTN", "ZHACTN", JdeDataType.String, 2),
        new JdeField("ZHKCOO", "ZHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ZHDOCO", "ZHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHDCTO", "ZHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ZHSFXO", "ZHSFXO", JdeDataType.String, 6),
        new JdeField("ZHMCU", "ZHMCU", JdeDataType.String, 24),
        new JdeField("ZHCO", "ZHCO", JdeDataType.String, 10),
        new JdeField("ZHOKCO", "ZHOKCO", JdeDataType.String, 10),
        new JdeField("ZHOORN", "ZHOORN", JdeDataType.String, 16),
        new JdeField("ZHOCTO", "ZHOCTO", JdeDataType.String, 4),
        new JdeField("ZHRKCO", "ZHRKCO", JdeDataType.String, 10),
        new JdeField("ZHRORN", "ZHRORN", JdeDataType.String, 16),
        new JdeField("ZHRCTO", "ZHRCTO", JdeDataType.String, 4),
        new JdeField("ZHAN8", "ZHAN8", JdeDataType.Numeric),
        new JdeField("ZHSHAN", "ZHSHAN", JdeDataType.Numeric),
        new JdeField("ZHPA8", "ZHPA8", JdeDataType.Numeric),
        new JdeField("ZHDRQJ", "ZHDRQJ", JdeDataType.Numeric),
        new JdeField("ZHTRDJ", "ZHTRDJ", JdeDataType.Numeric),
        new JdeField("ZHPDDJ", "ZHPDDJ", JdeDataType.Numeric),
        new JdeField("ZHOPDJ", "ZHOPDJ", JdeDataType.Numeric),
        new JdeField("ZHADDJ", "ZHADDJ", JdeDataType.Numeric),
        new JdeField("ZHCNDJ", "ZHCNDJ", JdeDataType.Numeric),
        new JdeField("ZHPEFJ", "ZHPEFJ", JdeDataType.Numeric),
        new JdeField("ZHPPDJ", "ZHPPDJ", JdeDataType.Numeric),
        new JdeField("ZHVR01", "ZHVR01", JdeDataType.String, 50),
        new JdeField("ZHVR02", "ZHVR02", JdeDataType.String, 50),
        new JdeField("ZHDEL1", "ZHDEL1", JdeDataType.String, 60),
        new JdeField("ZHDEL2", "ZHDEL2", JdeDataType.String, 60),
        new JdeField("ZHINMG", "ZHINMG", JdeDataType.String, 20),
        new JdeField("ZHPTC", "ZHPTC", JdeDataType.String, 6),
        new JdeField("ZHRYIN", "ZHRYIN", JdeDataType.String, 2),
        new JdeField("ZHASN", "ZHASN", JdeDataType.String, 16),
        new JdeField("ZHPRGP", "ZHPRGP", JdeDataType.String, 16),
        new JdeField("ZHTRDC", "ZHTRDC", JdeDataType.Numeric),
        new JdeField("ZHPCRT", "ZHPCRT", JdeDataType.Numeric),
        new JdeField("ZHTXA1", "ZHTXA1", JdeDataType.String, 20),
        new JdeField("ZHEXR1", "ZHEXR1", JdeDataType.String, 4),
        new JdeField("ZHTXCT", "ZHTXCT", JdeDataType.String, 40),
        new JdeField("ZHATXT", "ZHATXT", JdeDataType.String, 2),
        new JdeField("ZHPRIO", "ZHPRIO", JdeDataType.String, 2),
        new JdeField("ZHBACK", "ZHBACK", JdeDataType.String, 2),
        new JdeField("ZHSBAL", "ZHSBAL", JdeDataType.String, 2),
        new JdeField("ZHHOLD", "ZHHOLD", JdeDataType.String, 4),
        new JdeField("ZHPLST", "ZHPLST", JdeDataType.String, 2),
        new JdeField("ZHINVC", "ZHINVC", JdeDataType.Numeric),
        new JdeField("ZHNTR", "ZHNTR", JdeDataType.String, 4),
        new JdeField("ZHANBY", "ZHANBY", JdeDataType.Numeric),
        new JdeField("ZHCARS", "ZHCARS", JdeDataType.Numeric),
        new JdeField("ZHMOT", "ZHMOT", JdeDataType.String, 6),
        new JdeField("ZHCOT", "ZHCOT", JdeDataType.String, 6),
        new JdeField("ZHROUT", "ZHROUT", JdeDataType.String, 6),
        new JdeField("ZHSTOP", "ZHSTOP", JdeDataType.String, 6),
        new JdeField("ZHZON", "ZHZON", JdeDataType.String, 6),
        new JdeField("ZHCNID", "ZHCNID", JdeDataType.String, 40),
        new JdeField("ZHFRTH", "ZHFRTH", JdeDataType.String, 6),
        new JdeField("ZHAFT", "ZHAFT", JdeDataType.String, 2),
        new JdeField("ZHFUF1", "ZHFUF1", JdeDataType.String, 2),
        new JdeField("ZHFRTC", "ZHFRTC", JdeDataType.String, 2),
        new JdeField("ZHMORD", "ZHMORD", JdeDataType.String, 2),
        new JdeField("ZHRCD", "ZHRCD", JdeDataType.String, 6),
        new JdeField("ZHFUF2", "ZHFUF2", JdeDataType.String, 2),
        new JdeField("ZHOTOT", "ZHOTOT", JdeDataType.Numeric),
        new JdeField("ZHTOTC", "ZHTOTC", JdeDataType.Numeric),
        new JdeField("ZHWUMD", "ZHWUMD", JdeDataType.String, 4),
        new JdeField("ZHVUMD", "ZHVUMD", JdeDataType.String, 4),
        new JdeField("ZHAUTN", "ZHAUTN", JdeDataType.String, 20),
        new JdeField("ZHCACT", "ZHCACT", JdeDataType.String, 50),
        new JdeField("ZHCEXP", "ZHCEXP", JdeDataType.Numeric),
        new JdeField("ZHSBLI", "ZHSBLI", JdeDataType.String, 2),
        new JdeField("ZHCRMD", "ZHCRMD", JdeDataType.String, 2),
        new JdeField("ZHCRRM", "ZHCRRM", JdeDataType.String, 2),
        new JdeField("ZHCRCD", "ZHCRCD", JdeDataType.String, 6),
        new JdeField("ZHCRR", "ZHCRR", JdeDataType.Numeric),
        new JdeField("ZHLNGP", "ZHLNGP", JdeDataType.String, 4),
        new JdeField("ZHFAP", "ZHFAP", JdeDataType.Numeric),
        new JdeField("ZHFCST", "ZHFCST", JdeDataType.Numeric),
        new JdeField("ZHORBY", "ZHORBY", JdeDataType.String, 20),
        new JdeField("ZHTKBY", "ZHTKBY", JdeDataType.String, 20),
        new JdeField("ZHURCD", "ZHURCD", JdeDataType.String, 4),
        new JdeField("ZHURDT", "ZHURDT", JdeDataType.Numeric),
        new JdeField("ZHURAT", "ZHURAT", JdeDataType.Numeric),
        new JdeField("ZHURAB", "ZHURAB", JdeDataType.Numeric),
        new JdeField("ZHURRF", "ZHURRF", JdeDataType.String, 30),
        new JdeField("ZHUSER", "ZHUSER", JdeDataType.String, 20),
        new JdeField("ZHPID", "ZHPID", JdeDataType.String, 20),
        new JdeField("ZHJOBN", "ZHJOBN", JdeDataType.String, 20),
        new JdeField("ZHUPMJ", "ZHUPMJ", JdeDataType.Numeric),
        new JdeField("ZHTDAY", "ZHTDAY", JdeDataType.Numeric),
        new JdeField("ZHAPTS", "ZHAPTS", JdeDataType.String, 2),
        new JdeField("ZHEDF2", "ZHEDF2", JdeDataType.String, 2),
        new JdeField("ZHMAXO", "ZHMAXO", JdeDataType.Numeric),
        new JdeField("ZHMINO", "ZHMINO", JdeDataType.Numeric),
        new JdeField("ZHSI01", "ZHSI01", JdeDataType.String, 2),
        new JdeField("ZHEDSP", "ZHEDSP", JdeDataType.String, 2),
        new JdeField("ZHDTE", "ZHDTE", JdeDataType.Numeric),
        new JdeField("ZHADVP", "ZHADVP", JdeDataType.String, 2),
        new JdeField("ZHCP01", "ZHCP01", JdeDataType.String, 2),
        new JdeField("ZHUMB1", "ZHUMB1", JdeDataType.String, 2),
        new JdeField("ZHBUMC", "ZHBUMC", JdeDataType.String, 2),
        new JdeField("ZHCRDC", "ZHCRDC", JdeDataType.String, 6),
        new JdeField("ZHCRRD", "ZHCRRD", JdeDataType.Numeric),
        new JdeField("ZHCPGP", "ZHCPGP", JdeDataType.String, 16),
        new JdeField("ZHLNIX", "ZHLNIX", JdeDataType.Numeric),
        new JdeField("ZHORNN", "ZHORNN", JdeDataType.Numeric),
        new JdeField("ZHAPRC", "ZHAPRC", JdeDataType.Numeric),
        new JdeField("ZHAOPN", "ZHAOPN", JdeDataType.Numeric),
        new JdeField("ZHFY", "ZHFY", JdeDataType.Numeric),
        new JdeField("ZHCTRY", "ZHCTRY", JdeDataType.Numeric),
        new JdeField("ZHTRR1", "ZHTRR1", JdeDataType.Numeric),
        new JdeField("ZHTRR2", "ZHTRR2", JdeDataType.Numeric),
        new JdeField("ZHCRCM", "ZHCRCM", JdeDataType.String, 2),
        new JdeField("ZHTRD1", "ZHTRD1", JdeDataType.Numeric),
        new JdeField("ZHTRD2", "ZHTRD2", JdeDataType.Numeric),
        new JdeField("ZHDCFL", "ZHDCFL", JdeDataType.String, 2),
        new JdeField("ZHRCUP", "ZHRCUP", JdeDataType.String, 2),
        new JdeField("ZHLNID", "ZHLNID", JdeDataType.Numeric),
        new JdeField("ZHVVTX", "ZHVVTX", JdeDataType.String, 2),
        new JdeField("ZHTRAR", "ZHTRAR", JdeDataType.String, 6),
        new JdeField("ZHEXR0", "ZHEXR0", JdeDataType.String, 4),
        new JdeField("ZHCRCE", "ZHCRCE", JdeDataType.String, 6),
        new JdeField("ZHIAN8", "ZHIAN8", JdeDataType.Numeric),
        new JdeField("ZHIR01", "ZHIR01", JdeDataType.String, 60),
        new JdeField("ZHIR02", "ZHIR02", JdeDataType.String, 60),
        new JdeField("ZHIR03", "ZHIR03", JdeDataType.String, 60),
        new JdeField("ZHIR04", "ZHIR04", JdeDataType.String, 60),
        new JdeField("ZHIR05", "ZHIR05", JdeDataType.String, 60),
        new JdeField("ZHVR03", "ZHVR03", JdeDataType.String, 50),
        new JdeField("ZHSOOR", "ZHSOOR", JdeDataType.Numeric),
        new JdeField("ZHPMDT", "ZHPMDT", JdeDataType.Numeric),
        new JdeField("ZHRSDT", "ZHRSDT", JdeDataType.Numeric),
        new JdeField("ZHRQSJ", "ZHRQSJ", JdeDataType.Numeric),
        new JdeField("ZHPSTM", "ZHPSTM", JdeDataType.Numeric),
        new JdeField("ZHPDTT", "ZHPDTT", JdeDataType.Numeric),
        new JdeField("ZHOPTT", "ZHOPTT", JdeDataType.Numeric),
        new JdeField("ZHDRQT", "ZHDRQT", JdeDataType.Numeric),
        new JdeField("ZHADTM", "ZHADTM", JdeDataType.Numeric),
        new JdeField("ZHADLJ", "ZHADLJ", JdeDataType.Numeric),
        new JdeField("ZHPBAN", "ZHPBAN", JdeDataType.Numeric),
        new JdeField("ZHITAN", "ZHITAN", JdeDataType.Numeric),
        new JdeField("ZHFTAN", "ZHFTAN", JdeDataType.Numeric),
        new JdeField("ZHDVAN", "ZHDVAN", JdeDataType.Numeric),
        new JdeField("ZHDOC1", "ZHDOC1", JdeDataType.Numeric),
        new JdeField("ZHDCT4", "ZHDCT4", JdeDataType.String, 4),
        new JdeField("ZHCORD", "ZHCORD", JdeDataType.Numeric),
        new JdeField("ZHBSC", "ZHBSC", JdeDataType.String, 20),
        new JdeField("ZHBCRC", "ZHBCRC", JdeDataType.String, 6),
        new JdeField("ZHAUFT", "ZHAUFT", JdeDataType.String, 2),
        new JdeField("ZHAUFI", "ZHAUFI", JdeDataType.String, 2),
        new JdeField("ZHOPBO", "ZHOPBO", JdeDataType.String, 60),
        new JdeField("ZHOPTC", "ZHOPTC", JdeDataType.Numeric),
        new JdeField("ZHOPLD", "ZHOPLD", JdeDataType.Numeric),
        new JdeField("ZHOPBK", "ZHOPBK", JdeDataType.Numeric),
        new JdeField("ZHOPSB", "ZHOPSB", JdeDataType.Numeric),
        new JdeField("ZHOPPS", "ZHOPPS", JdeDataType.String, 60),
        new JdeField("ZHOPPL", "ZHOPPL", JdeDataType.String, 2),
        new JdeField("ZHOPMS", "ZHOPMS", JdeDataType.String, 2),
        new JdeField("ZHOPSS", "ZHOPSS", JdeDataType.String, 2),
        new JdeField("ZHOPBA", "ZHOPBA", JdeDataType.String, 2),
        new JdeField("ZHOPLL", "ZHOPLL", JdeDataType.String, 2),
        new JdeField("ZHSOEF", "ZHSOEF", JdeDataType.String, 60),
        new JdeField("ZHPRAN8", "ZHPRAN8", JdeDataType.Numeric),
        new JdeField("ZHOPPID", "ZHOPPID", JdeDataType.Numeric),
        new JdeField("ZHSDATTN", "ZHSDATTN", JdeDataType.String, 100),
        new JdeField("ZHSPATTN", "ZHSPATTN", JdeDataType.String, 100),
        new JdeField("ZHOTIND", "ZHOTIND", JdeDataType.String, 2),
        new JdeField("ZHPRCIDLN", "ZHPRCIDLN", JdeDataType.Numeric),
        new JdeField("ZHCCIDLN", "ZHCCIDLN", JdeDataType.Numeric),
        new JdeField("ZHSHCCIDLN", "ZHSHCCIDLN", JdeDataType.Numeric),
        new JdeField("ZHUTP", "ZHUTP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI01_0", "Primary Key on ZHCTID, ZHJOBS, ZHDOCO, ZHDCTO, ZHKCOO", new[] { "ZHCTID", "ZHJOBS", "ZHDOCO", "ZHDCTO", "ZHKCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI01_2", "Index on ZHCTID, ZHPEID, ZHTCID, ZHAN8, ZHMCU, ZHCRCD, ZHSHAN", new[] { "ZHCTID", "ZHPEID", "ZHTCID", "ZHAN8", "ZHMCU", "ZHCRCD", "ZHSHAN" }),
        new JdeIndex("F42UI01_3", "Index on ZHCTID, ZHDOCO, ZHDCTO, ZHKCOO", new[] { "ZHCTID", "ZHDOCO", "ZHDCTO", "ZHKCOO" })
    };
}
