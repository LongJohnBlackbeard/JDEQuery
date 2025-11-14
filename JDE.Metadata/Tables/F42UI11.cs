using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI11 - .
/// </summary>
public class F42UI11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDCTID.
        /// </summary>
        public const string ZDCTID = "ZDCTID";

        /// <summary>
        /// ZDJOBS.
        /// </summary>
        public const string ZDJOBS = "ZDJOBS";

        /// <summary>
        /// ZDLNIX.
        /// </summary>
        public const string ZDLNIX = "ZDLNIX";

        /// <summary>
        /// ZDACTN.
        /// </summary>
        public const string ZDACTN = "ZDACTN";

        /// <summary>
        /// ZDKCOO.
        /// </summary>
        public const string ZDKCOO = "ZDKCOO";

        /// <summary>
        /// ZDDOCO.
        /// </summary>
        public const string ZDDOCO = "ZDDOCO";

        /// <summary>
        /// ZDDCTO.
        /// </summary>
        public const string ZDDCTO = "ZDDCTO";

        /// <summary>
        /// ZDLNID.
        /// </summary>
        public const string ZDLNID = "ZDLNID";

        /// <summary>
        /// ZDSFXO.
        /// </summary>
        public const string ZDSFXO = "ZDSFXO";

        /// <summary>
        /// ZDMCU.
        /// </summary>
        public const string ZDMCU = "ZDMCU";

        /// <summary>
        /// ZDCO.
        /// </summary>
        public const string ZDCO = "ZDCO";

        /// <summary>
        /// ZDOKCO.
        /// </summary>
        public const string ZDOKCO = "ZDOKCO";

        /// <summary>
        /// ZDOORN.
        /// </summary>
        public const string ZDOORN = "ZDOORN";

        /// <summary>
        /// ZDOCTO.
        /// </summary>
        public const string ZDOCTO = "ZDOCTO";

        /// <summary>
        /// ZDOGNO.
        /// </summary>
        public const string ZDOGNO = "ZDOGNO";

        /// <summary>
        /// ZDRKCO.
        /// </summary>
        public const string ZDRKCO = "ZDRKCO";

        /// <summary>
        /// ZDRORN.
        /// </summary>
        public const string ZDRORN = "ZDRORN";

        /// <summary>
        /// ZDRCTO.
        /// </summary>
        public const string ZDRCTO = "ZDRCTO";

        /// <summary>
        /// ZDRLLN.
        /// </summary>
        public const string ZDRLLN = "ZDRLLN";

        /// <summary>
        /// ZDDMCT.
        /// </summary>
        public const string ZDDMCT = "ZDDMCT";

        /// <summary>
        /// ZDDMCS.
        /// </summary>
        public const string ZDDMCS = "ZDDMCS";

        /// <summary>
        /// ZDAN8.
        /// </summary>
        public const string ZDAN8 = "ZDAN8";

        /// <summary>
        /// ZDSHAN.
        /// </summary>
        public const string ZDSHAN = "ZDSHAN";

        /// <summary>
        /// ZDPA8.
        /// </summary>
        public const string ZDPA8 = "ZDPA8";

        /// <summary>
        /// ZDDRQJ.
        /// </summary>
        public const string ZDDRQJ = "ZDDRQJ";

        /// <summary>
        /// ZDTRDJ.
        /// </summary>
        public const string ZDTRDJ = "ZDTRDJ";

        /// <summary>
        /// ZDPDDJ.
        /// </summary>
        public const string ZDPDDJ = "ZDPDDJ";

        /// <summary>
        /// ZDADDJ.
        /// </summary>
        public const string ZDADDJ = "ZDADDJ";

        /// <summary>
        /// ZDIVD.
        /// </summary>
        public const string ZDIVD = "ZDIVD";

        /// <summary>
        /// ZDCNDJ.
        /// </summary>
        public const string ZDCNDJ = "ZDCNDJ";

        /// <summary>
        /// ZDDGL.
        /// </summary>
        public const string ZDDGL = "ZDDGL";

        /// <summary>
        /// ZDRSDJ.
        /// </summary>
        public const string ZDRSDJ = "ZDRSDJ";

        /// <summary>
        /// ZDPEFJ.
        /// </summary>
        public const string ZDPEFJ = "ZDPEFJ";

        /// <summary>
        /// ZDVR01.
        /// </summary>
        public const string ZDVR01 = "ZDVR01";

        /// <summary>
        /// ZDVR02.
        /// </summary>
        public const string ZDVR02 = "ZDVR02";

        /// <summary>
        /// ZDITM.
        /// </summary>
        public const string ZDITM = "ZDITM";

        /// <summary>
        /// ZDLITM.
        /// </summary>
        public const string ZDLITM = "ZDLITM";

        /// <summary>
        /// ZDAITM.
        /// </summary>
        public const string ZDAITM = "ZDAITM";

        /// <summary>
        /// ZDLOCN.
        /// </summary>
        public const string ZDLOCN = "ZDLOCN";

        /// <summary>
        /// ZDLOTN.
        /// </summary>
        public const string ZDLOTN = "ZDLOTN";

        /// <summary>
        /// ZDEXDP.
        /// </summary>
        public const string ZDEXDP = "ZDEXDP";

        /// <summary>
        /// ZDDSC1.
        /// </summary>
        public const string ZDDSC1 = "ZDDSC1";

        /// <summary>
        /// ZDDSC2.
        /// </summary>
        public const string ZDDSC2 = "ZDDSC2";

        /// <summary>
        /// ZDLNTY.
        /// </summary>
        public const string ZDLNTY = "ZDLNTY";

        /// <summary>
        /// ZDNXTR.
        /// </summary>
        public const string ZDNXTR = "ZDNXTR";

        /// <summary>
        /// ZDLTTR.
        /// </summary>
        public const string ZDLTTR = "ZDLTTR";

        /// <summary>
        /// ZDRLIT.
        /// </summary>
        public const string ZDRLIT = "ZDRLIT";

        /// <summary>
        /// ZDKTLN.
        /// </summary>
        public const string ZDKTLN = "ZDKTLN";

        /// <summary>
        /// ZDCPNT.
        /// </summary>
        public const string ZDCPNT = "ZDCPNT";

        /// <summary>
        /// ZDRKIT.
        /// </summary>
        public const string ZDRKIT = "ZDRKIT";

        /// <summary>
        /// ZDKTP.
        /// </summary>
        public const string ZDKTP = "ZDKTP";

        /// <summary>
        /// ZDUOM.
        /// </summary>
        public const string ZDUOM = "ZDUOM";

        /// <summary>
        /// ZDUORG.
        /// </summary>
        public const string ZDUORG = "ZDUORG";

        /// <summary>
        /// ZDSOQS.
        /// </summary>
        public const string ZDSOQS = "ZDSOQS";

        /// <summary>
        /// ZDSOBK.
        /// </summary>
        public const string ZDSOBK = "ZDSOBK";

        /// <summary>
        /// ZDSOCN.
        /// </summary>
        public const string ZDSOCN = "ZDSOCN";

        /// <summary>
        /// ZDSONE.
        /// </summary>
        public const string ZDSONE = "ZDSONE";

        /// <summary>
        /// ZDUOPN.
        /// </summary>
        public const string ZDUOPN = "ZDUOPN";

        /// <summary>
        /// ZDQTYT.
        /// </summary>
        public const string ZDQTYT = "ZDQTYT";

        /// <summary>
        /// ZDQRLV.
        /// </summary>
        public const string ZDQRLV = "ZDQRLV";

        /// <summary>
        /// ZDCOMM.
        /// </summary>
        public const string ZDCOMM = "ZDCOMM";

        /// <summary>
        /// ZDOTQY.
        /// </summary>
        public const string ZDOTQY = "ZDOTQY";

        /// <summary>
        /// ZDUPRC.
        /// </summary>
        public const string ZDUPRC = "ZDUPRC";

        /// <summary>
        /// ZDAEXP.
        /// </summary>
        public const string ZDAEXP = "ZDAEXP";

        /// <summary>
        /// ZDAOPN.
        /// </summary>
        public const string ZDAOPN = "ZDAOPN";

        /// <summary>
        /// ZDPROV.
        /// </summary>
        public const string ZDPROV = "ZDPROV";

        /// <summary>
        /// ZDTPC.
        /// </summary>
        public const string ZDTPC = "ZDTPC";

        /// <summary>
        /// ZDAPUM.
        /// </summary>
        public const string ZDAPUM = "ZDAPUM";

        /// <summary>
        /// ZDLPRC.
        /// </summary>
        public const string ZDLPRC = "ZDLPRC";

        /// <summary>
        /// ZDUNCS.
        /// </summary>
        public const string ZDUNCS = "ZDUNCS";

        /// <summary>
        /// ZDECST.
        /// </summary>
        public const string ZDECST = "ZDECST";

        /// <summary>
        /// ZDCSTO.
        /// </summary>
        public const string ZDCSTO = "ZDCSTO";

        /// <summary>
        /// ZDTCST.
        /// </summary>
        public const string ZDTCST = "ZDTCST";

        /// <summary>
        /// ZDFUN2.
        /// </summary>
        public const string ZDFUN2 = "ZDFUN2";

        /// <summary>
        /// ZDASN.
        /// </summary>
        public const string ZDASN = "ZDASN";

        /// <summary>
        /// ZDCLVL.
        /// </summary>
        public const string ZDCLVL = "ZDCLVL";

        /// <summary>
        /// ZDODOC.
        /// </summary>
        public const string ZDODOC = "ZDODOC";

        /// <summary>
        /// ZDODCT.
        /// </summary>
        public const string ZDODCT = "ZDODCT";

        /// <summary>
        /// ZDOKC.
        /// </summary>
        public const string ZDOKC = "ZDOKC";

        /// <summary>
        /// ZDPSN.
        /// </summary>
        public const string ZDPSN = "ZDPSN";

        /// <summary>
        /// ZDDELN.
        /// </summary>
        public const string ZDDELN = "ZDDELN";

        /// <summary>
        /// ZDTAX1.
        /// </summary>
        public const string ZDTAX1 = "ZDTAX1";

        /// <summary>
        /// ZDATXT.
        /// </summary>
        public const string ZDATXT = "ZDATXT";

        /// <summary>
        /// ZDRESL.
        /// </summary>
        public const string ZDRESL = "ZDRESL";

        /// <summary>
        /// ZDAPTS.
        /// </summary>
        public const string ZDAPTS = "ZDAPTS";

        /// <summary>
        /// ZDVEND.
        /// </summary>
        public const string ZDVEND = "ZDVEND";

        /// <summary>
        /// ZDCNID.
        /// </summary>
        public const string ZDCNID = "ZDCNID";

        /// <summary>
        /// ZDUOM1.
        /// </summary>
        public const string ZDUOM1 = "ZDUOM1";

        /// <summary>
        /// ZDPQOR.
        /// </summary>
        public const string ZDPQOR = "ZDPQOR";

        /// <summary>
        /// ZDUOM2.
        /// </summary>
        public const string ZDUOM2 = "ZDUOM2";

        /// <summary>
        /// ZDSQOR.
        /// </summary>
        public const string ZDSQOR = "ZDSQOR";

        /// <summary>
        /// ZDUOM4.
        /// </summary>
        public const string ZDUOM4 = "ZDUOM4";

        /// <summary>
        /// ZDITWT.
        /// </summary>
        public const string ZDITWT = "ZDITWT";

        /// <summary>
        /// ZDWTUM.
        /// </summary>
        public const string ZDWTUM = "ZDWTUM";

        /// <summary>
        /// ZDVLUM.
        /// </summary>
        public const string ZDVLUM = "ZDVLUM";

        /// <summary>
        /// ZDITVL.
        /// </summary>
        public const string ZDITVL = "ZDITVL";

        /// <summary>
        /// ZDRPRC.
        /// </summary>
        public const string ZDRPRC = "ZDRPRC";

        /// <summary>
        /// ZDORPR.
        /// </summary>
        public const string ZDORPR = "ZDORPR";

        /// <summary>
        /// ZDORP.
        /// </summary>
        public const string ZDORP = "ZDORP";

        /// <summary>
        /// ZDCMGP.
        /// </summary>
        public const string ZDCMGP = "ZDCMGP";

        /// <summary>
        /// ZDCTRY.
        /// </summary>
        public const string ZDCTRY = "ZDCTRY";

        /// <summary>
        /// ZDFY.
        /// </summary>
        public const string ZDFY = "ZDFY";

        /// <summary>
        /// ZDCMCG.
        /// </summary>
        public const string ZDCMCG = "ZDCMCG";

        /// <summary>
        /// ZDGRWT.
        /// </summary>
        public const string ZDGRWT = "ZDGRWT";

        /// <summary>
        /// ZDUPC1.
        /// </summary>
        public const string ZDUPC1 = "ZDUPC1";

        /// <summary>
        /// ZDUPC2.
        /// </summary>
        public const string ZDUPC2 = "ZDUPC2";

        /// <summary>
        /// ZDUPC3.
        /// </summary>
        public const string ZDUPC3 = "ZDUPC3";

        /// <summary>
        /// ZDCRCD.
        /// </summary>
        public const string ZDCRCD = "ZDCRCD";

        /// <summary>
        /// ZDCRR.
        /// </summary>
        public const string ZDCRR = "ZDCRR";

        /// <summary>
        /// ZDFPRC.
        /// </summary>
        public const string ZDFPRC = "ZDFPRC";

        /// <summary>
        /// ZDFUP.
        /// </summary>
        public const string ZDFUP = "ZDFUP";

        /// <summary>
        /// ZDFEA.
        /// </summary>
        public const string ZDFEA = "ZDFEA";

        /// <summary>
        /// ZDFUC.
        /// </summary>
        public const string ZDFUC = "ZDFUC";

        /// <summary>
        /// ZDFEC.
        /// </summary>
        public const string ZDFEC = "ZDFEC";

        /// <summary>
        /// ZDTORG.
        /// </summary>
        public const string ZDTORG = "ZDTORG";

        /// <summary>
        /// ZDUSER.
        /// </summary>
        public const string ZDUSER = "ZDUSER";

        /// <summary>
        /// ZDPID.
        /// </summary>
        public const string ZDPID = "ZDPID";

        /// <summary>
        /// ZDJOBN.
        /// </summary>
        public const string ZDJOBN = "ZDJOBN";

        /// <summary>
        /// ZDUPMJ.
        /// </summary>
        public const string ZDUPMJ = "ZDUPMJ";

        /// <summary>
        /// ZDTDAY.
        /// </summary>
        public const string ZDTDAY = "ZDTDAY";

        /// <summary>
        /// ZDSTKT.
        /// </summary>
        public const string ZDSTKT = "ZDSTKT";

        /// <summary>
        /// ZDWRTH.
        /// </summary>
        public const string ZDWRTH = "ZDWRTH";

        /// <summary>
        /// ZDIVI.
        /// </summary>
        public const string ZDIVI = "ZDIVI";

        /// <summary>
        /// ZDCONV.
        /// </summary>
        public const string ZDCONV = "ZDCONV";

        /// <summary>
        /// ZDCNV3.
        /// </summary>
        public const string ZDCNV3 = "ZDCNV3";

        /// <summary>
        /// ZDKTCM.
        /// </summary>
        public const string ZDKTCM = "ZDKTCM";

        /// <summary>
        /// ZDOT1Y.
        /// </summary>
        public const string ZDOT1Y = "ZDOT1Y";

        /// <summary>
        /// ZDSTDP.
        /// </summary>
        public const string ZDSTDP = "ZDSTDP";

        /// <summary>
        /// ZDCS07.
        /// </summary>
        public const string ZDCS07 = "ZDCS07";

        /// <summary>
        /// ZDIT07.
        /// </summary>
        public const string ZDIT07 = "ZDIT07";

        /// <summary>
        /// ZDTFLA.
        /// </summary>
        public const string ZDTFLA = "ZDTFLA";

        /// <summary>
        /// ZDEDLN.
        /// </summary>
        public const string ZDEDLN = "ZDEDLN";

        /// <summary>
        /// ZDRJOB.
        /// </summary>
        public const string ZDRJOB = "ZDRJOB";

        /// <summary>
        /// ZDDETD.
        /// </summary>
        public const string ZDDETD = "ZDDETD";

        /// <summary>
        /// ZDDETF.
        /// </summary>
        public const string ZDDETF = "ZDDETF";

        /// <summary>
        /// ZDSHPN.
        /// </summary>
        public const string ZDSHPN = "ZDSHPN";

        /// <summary>
        /// ZDLINN.
        /// </summary>
        public const string ZDLINN = "ZDLINN";

        /// <summary>
        /// ZDSLNE.
        /// </summary>
        public const string ZDSLNE = "ZDSLNE";

        /// <summary>
        /// ZDDSGP.
        /// </summary>
        public const string ZDDSGP = "ZDDSGP";

        /// <summary>
        /// ZDBPFG.
        /// </summary>
        public const string ZDBPFG = "ZDBPFG";

        /// <summary>
        /// ZDHCDS.
        /// </summary>
        public const string ZDHCDS = "ZDHCDS";

        /// <summary>
        /// ZDPSR.
        /// </summary>
        public const string ZDPSR = "ZDPSR";

        /// <summary>
        /// ZDPSRY.
        /// </summary>
        public const string ZDPSRY = "ZDPSRY";

        /// <summary>
        /// ZDSEQ.
        /// </summary>
        public const string ZDSEQ = "ZDSEQ";

        /// <summary>
        /// ZDRCUP.
        /// </summary>
        public const string ZDRCUP = "ZDRCUP";

        /// <summary>
        /// ZDCMTR.
        /// </summary>
        public const string ZDCMTR = "ZDCMTR";

        /// <summary>
        /// ZDALPH.
        /// </summary>
        public const string ZDALPH = "ZDALPH";

        /// <summary>
        /// ZDPMTH.
        /// </summary>
        public const string ZDPMTH = "ZDPMTH";

        /// <summary>
        /// ZDSO16.
        /// </summary>
        public const string ZDSO16 = "ZDSO16";

        /// <summary>
        /// ZDSO17.
        /// </summary>
        public const string ZDSO17 = "ZDSO17";

        /// <summary>
        /// ZDSO18.
        /// </summary>
        public const string ZDSO18 = "ZDSO18";

        /// <summary>
        /// ZDSO19.
        /// </summary>
        public const string ZDSO19 = "ZDSO19";

        /// <summary>
        /// ZDSO20.
        /// </summary>
        public const string ZDSO20 = "ZDSO20";

        /// <summary>
        /// ZDIR01.
        /// </summary>
        public const string ZDIR01 = "ZDIR01";

        /// <summary>
        /// ZDIR02.
        /// </summary>
        public const string ZDIR02 = "ZDIR02";

        /// <summary>
        /// ZDIR03.
        /// </summary>
        public const string ZDIR03 = "ZDIR03";

        /// <summary>
        /// ZDIR04.
        /// </summary>
        public const string ZDIR04 = "ZDIR04";

        /// <summary>
        /// ZDIR05.
        /// </summary>
        public const string ZDIR05 = "ZDIR05";

        /// <summary>
        /// ZDSOOR.
        /// </summary>
        public const string ZDSOOR = "ZDSOOR";

        /// <summary>
        /// ZDVR03.
        /// </summary>
        public const string ZDVR03 = "ZDVR03";

        /// <summary>
        /// ZDBSC.
        /// </summary>
        public const string ZDBSC = "ZDBSC";

        /// <summary>
        /// ZDCBSC.
        /// </summary>
        public const string ZDCBSC = "ZDCBSC";

        /// <summary>
        /// ZDCORD.
        /// </summary>
        public const string ZDCORD = "ZDCORD";

        /// <summary>
        /// ZDDVAN.
        /// </summary>
        public const string ZDDVAN = "ZDDVAN";

        /// <summary>
        /// ZDPEND.
        /// </summary>
        public const string ZDPEND = "ZDPEND";

        /// <summary>
        /// ZDRFRV.
        /// </summary>
        public const string ZDRFRV = "ZDRFRV";

        /// <summary>
        /// ZDPRJM.
        /// </summary>
        public const string ZDPRJM = "ZDPRJM";

        /// <summary>
        /// ZDHOLD.
        /// </summary>
        public const string ZDHOLD = "ZDHOLD";

        /// <summary>
        /// ZDODLN.
        /// </summary>
        public const string ZDODLN = "ZDODLN";

        /// <summary>
        /// ZDRLNU.
        /// </summary>
        public const string ZDRLNU = "ZDRLNU";

        /// <summary>
        /// ZDDRQT.
        /// </summary>
        public const string ZDDRQT = "ZDDRQT";

        /// <summary>
        /// ZDMCLN.
        /// </summary>
        public const string ZDMCLN = "ZDMCLN";

        /// <summary>
        /// ZDPOE.
        /// </summary>
        public const string ZDPOE = "ZDPOE";

        /// <summary>
        /// ZDPMTO.
        /// </summary>
        public const string ZDPMTO = "ZDPMTO";

        /// <summary>
        /// ZDNUMB.
        /// </summary>
        public const string ZDNUMB = "ZDNUMB";

        /// <summary>
        /// ZDAAID.
        /// </summary>
        public const string ZDAAID = "ZDAAID";

        /// <summary>
        /// ZDSPATTN.
        /// </summary>
        public const string ZDSPATTN = "ZDSPATTN";

        /// <summary>
        /// ZDPRAN8.
        /// </summary>
        public const string ZDPRAN8 = "ZDPRAN8";

        /// <summary>
        /// ZDPRCIDLN.
        /// </summary>
        public const string ZDPRCIDLN = "ZDPRCIDLN";

        /// <summary>
        /// ZDCCIDLN.
        /// </summary>
        public const string ZDCCIDLN = "ZDCCIDLN";

        /// <summary>
        /// ZDSHCCIDLN.
        /// </summary>
        public const string ZDSHCCIDLN = "ZDSHCCIDLN";

        /// <summary>
        /// ZDOPPID.
        /// </summary>
        public const string ZDOPPID = "ZDOPPID";

        /// <summary>
        /// ZDOSTP.
        /// </summary>
        public const string ZDOSTP = "ZDOSTP";

        /// <summary>
        /// ZDUKID.
        /// </summary>
        public const string ZDUKID = "ZDUKID";

        /// <summary>
        /// ZDCATNM.
        /// </summary>
        public const string ZDCATNM = "ZDCATNM";

        /// <summary>
        /// ZDOPFR.
        /// </summary>
        public const string ZDOPFR = "ZDOPFR";

        /// <summary>
        /// ZDOPERROR.
        /// </summary>
        public const string ZDOPERROR = "ZDOPERROR";

        /// <summary>
        /// ZDPMPN.
        /// </summary>
        public const string ZDPMPN = "ZDPMPN";

        /// <summary>
        /// ZDPNS.
        /// </summary>
        public const string ZDPNS = "ZDPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDCTID", "ZDCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZDJOBS", "ZDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDLNIX", "ZDLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDACTN", "ZDACTN", JdeDataType.String, 2),
        new JdeField("ZDKCOO", "ZDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ZDDOCO", "ZDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDDCTO", "ZDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ZDLNID", "ZDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDSFXO", "ZDSFXO", JdeDataType.String, 6),
        new JdeField("ZDMCU", "ZDMCU", JdeDataType.String, 24),
        new JdeField("ZDCO", "ZDCO", JdeDataType.String, 10),
        new JdeField("ZDOKCO", "ZDOKCO", JdeDataType.String, 10),
        new JdeField("ZDOORN", "ZDOORN", JdeDataType.String, 16),
        new JdeField("ZDOCTO", "ZDOCTO", JdeDataType.String, 4),
        new JdeField("ZDOGNO", "ZDOGNO", JdeDataType.Numeric),
        new JdeField("ZDRKCO", "ZDRKCO", JdeDataType.String, 10),
        new JdeField("ZDRORN", "ZDRORN", JdeDataType.String, 16),
        new JdeField("ZDRCTO", "ZDRCTO", JdeDataType.String, 4),
        new JdeField("ZDRLLN", "ZDRLLN", JdeDataType.Numeric),
        new JdeField("ZDDMCT", "ZDDMCT", JdeDataType.String, 24),
        new JdeField("ZDDMCS", "ZDDMCS", JdeDataType.Numeric),
        new JdeField("ZDAN8", "ZDAN8", JdeDataType.Numeric),
        new JdeField("ZDSHAN", "ZDSHAN", JdeDataType.Numeric),
        new JdeField("ZDPA8", "ZDPA8", JdeDataType.Numeric),
        new JdeField("ZDDRQJ", "ZDDRQJ", JdeDataType.Numeric),
        new JdeField("ZDTRDJ", "ZDTRDJ", JdeDataType.Numeric),
        new JdeField("ZDPDDJ", "ZDPDDJ", JdeDataType.Numeric),
        new JdeField("ZDADDJ", "ZDADDJ", JdeDataType.Numeric),
        new JdeField("ZDIVD", "ZDIVD", JdeDataType.Numeric),
        new JdeField("ZDCNDJ", "ZDCNDJ", JdeDataType.Numeric),
        new JdeField("ZDDGL", "ZDDGL", JdeDataType.Numeric),
        new JdeField("ZDRSDJ", "ZDRSDJ", JdeDataType.Numeric),
        new JdeField("ZDPEFJ", "ZDPEFJ", JdeDataType.Numeric),
        new JdeField("ZDVR01", "ZDVR01", JdeDataType.String, 50),
        new JdeField("ZDVR02", "ZDVR02", JdeDataType.String, 50),
        new JdeField("ZDITM", "ZDITM", JdeDataType.Numeric),
        new JdeField("ZDLITM", "ZDLITM", JdeDataType.String, 50),
        new JdeField("ZDAITM", "ZDAITM", JdeDataType.String, 50),
        new JdeField("ZDLOCN", "ZDLOCN", JdeDataType.String, 40),
        new JdeField("ZDLOTN", "ZDLOTN", JdeDataType.String, 60),
        new JdeField("ZDEXDP", "ZDEXDP", JdeDataType.Numeric),
        new JdeField("ZDDSC1", "ZDDSC1", JdeDataType.String, 60),
        new JdeField("ZDDSC2", "ZDDSC2", JdeDataType.String, 60),
        new JdeField("ZDLNTY", "ZDLNTY", JdeDataType.String, 4),
        new JdeField("ZDNXTR", "ZDNXTR", JdeDataType.String, 6),
        new JdeField("ZDLTTR", "ZDLTTR", JdeDataType.String, 6),
        new JdeField("ZDRLIT", "ZDRLIT", JdeDataType.String, 16),
        new JdeField("ZDKTLN", "ZDKTLN", JdeDataType.Numeric),
        new JdeField("ZDCPNT", "ZDCPNT", JdeDataType.Numeric),
        new JdeField("ZDRKIT", "ZDRKIT", JdeDataType.Numeric),
        new JdeField("ZDKTP", "ZDKTP", JdeDataType.Numeric),
        new JdeField("ZDUOM", "ZDUOM", JdeDataType.String, 4),
        new JdeField("ZDUORG", "ZDUORG", JdeDataType.Numeric),
        new JdeField("ZDSOQS", "ZDSOQS", JdeDataType.Numeric),
        new JdeField("ZDSOBK", "ZDSOBK", JdeDataType.Numeric),
        new JdeField("ZDSOCN", "ZDSOCN", JdeDataType.Numeric),
        new JdeField("ZDSONE", "ZDSONE", JdeDataType.Numeric),
        new JdeField("ZDUOPN", "ZDUOPN", JdeDataType.Numeric),
        new JdeField("ZDQTYT", "ZDQTYT", JdeDataType.Numeric),
        new JdeField("ZDQRLV", "ZDQRLV", JdeDataType.Numeric),
        new JdeField("ZDCOMM", "ZDCOMM", JdeDataType.String, 2),
        new JdeField("ZDOTQY", "ZDOTQY", JdeDataType.String, 2),
        new JdeField("ZDUPRC", "ZDUPRC", JdeDataType.Numeric),
        new JdeField("ZDAEXP", "ZDAEXP", JdeDataType.Numeric),
        new JdeField("ZDAOPN", "ZDAOPN", JdeDataType.Numeric),
        new JdeField("ZDPROV", "ZDPROV", JdeDataType.String, 2),
        new JdeField("ZDTPC", "ZDTPC", JdeDataType.String, 2),
        new JdeField("ZDAPUM", "ZDAPUM", JdeDataType.String, 4),
        new JdeField("ZDLPRC", "ZDLPRC", JdeDataType.Numeric),
        new JdeField("ZDUNCS", "ZDUNCS", JdeDataType.Numeric),
        new JdeField("ZDECST", "ZDECST", JdeDataType.Numeric),
        new JdeField("ZDCSTO", "ZDCSTO", JdeDataType.String, 2),
        new JdeField("ZDTCST", "ZDTCST", JdeDataType.Numeric),
        new JdeField("ZDFUN2", "ZDFUN2", JdeDataType.Numeric),
        new JdeField("ZDASN", "ZDASN", JdeDataType.String, 16),
        new JdeField("ZDCLVL", "ZDCLVL", JdeDataType.String, 6),
        new JdeField("ZDODOC", "ZDODOC", JdeDataType.Numeric),
        new JdeField("ZDODCT", "ZDODCT", JdeDataType.String, 4),
        new JdeField("ZDOKC", "ZDOKC", JdeDataType.String, 10),
        new JdeField("ZDPSN", "ZDPSN", JdeDataType.Numeric),
        new JdeField("ZDDELN", "ZDDELN", JdeDataType.Numeric),
        new JdeField("ZDTAX1", "ZDTAX1", JdeDataType.String, 2),
        new JdeField("ZDATXT", "ZDATXT", JdeDataType.String, 2),
        new JdeField("ZDRESL", "ZDRESL", JdeDataType.String, 2),
        new JdeField("ZDAPTS", "ZDAPTS", JdeDataType.String, 2),
        new JdeField("ZDVEND", "ZDVEND", JdeDataType.Numeric),
        new JdeField("ZDCNID", "ZDCNID", JdeDataType.String, 40),
        new JdeField("ZDUOM1", "ZDUOM1", JdeDataType.String, 4),
        new JdeField("ZDPQOR", "ZDPQOR", JdeDataType.Numeric),
        new JdeField("ZDUOM2", "ZDUOM2", JdeDataType.String, 4),
        new JdeField("ZDSQOR", "ZDSQOR", JdeDataType.Numeric),
        new JdeField("ZDUOM4", "ZDUOM4", JdeDataType.String, 4),
        new JdeField("ZDITWT", "ZDITWT", JdeDataType.Numeric),
        new JdeField("ZDWTUM", "ZDWTUM", JdeDataType.String, 4),
        new JdeField("ZDVLUM", "ZDVLUM", JdeDataType.String, 4),
        new JdeField("ZDITVL", "ZDITVL", JdeDataType.Numeric),
        new JdeField("ZDRPRC", "ZDRPRC", JdeDataType.String, 16),
        new JdeField("ZDORPR", "ZDORPR", JdeDataType.String, 16),
        new JdeField("ZDORP", "ZDORP", JdeDataType.String, 2),
        new JdeField("ZDCMGP", "ZDCMGP", JdeDataType.String, 4),
        new JdeField("ZDCTRY", "ZDCTRY", JdeDataType.Numeric),
        new JdeField("ZDFY", "ZDFY", JdeDataType.Numeric),
        new JdeField("ZDCMCG", "ZDCMCG", JdeDataType.String, 16),
        new JdeField("ZDGRWT", "ZDGRWT", JdeDataType.Numeric),
        new JdeField("ZDUPC1", "ZDUPC1", JdeDataType.String, 4),
        new JdeField("ZDUPC2", "ZDUPC2", JdeDataType.String, 4),
        new JdeField("ZDUPC3", "ZDUPC3", JdeDataType.String, 4),
        new JdeField("ZDCRCD", "ZDCRCD", JdeDataType.String, 6),
        new JdeField("ZDCRR", "ZDCRR", JdeDataType.Numeric),
        new JdeField("ZDFPRC", "ZDFPRC", JdeDataType.Numeric),
        new JdeField("ZDFUP", "ZDFUP", JdeDataType.Numeric),
        new JdeField("ZDFEA", "ZDFEA", JdeDataType.Numeric),
        new JdeField("ZDFUC", "ZDFUC", JdeDataType.Numeric),
        new JdeField("ZDFEC", "ZDFEC", JdeDataType.Numeric),
        new JdeField("ZDTORG", "ZDTORG", JdeDataType.String, 20),
        new JdeField("ZDUSER", "ZDUSER", JdeDataType.String, 20),
        new JdeField("ZDPID", "ZDPID", JdeDataType.String, 20),
        new JdeField("ZDJOBN", "ZDJOBN", JdeDataType.String, 20),
        new JdeField("ZDUPMJ", "ZDUPMJ", JdeDataType.Numeric),
        new JdeField("ZDTDAY", "ZDTDAY", JdeDataType.Numeric),
        new JdeField("ZDSTKT", "ZDSTKT", JdeDataType.String, 2),
        new JdeField("ZDWRTH", "ZDWRTH", JdeDataType.String, 2),
        new JdeField("ZDIVI", "ZDIVI", JdeDataType.String, 2),
        new JdeField("ZDCONV", "ZDCONV", JdeDataType.Numeric),
        new JdeField("ZDCNV3", "ZDCNV3", JdeDataType.Numeric),
        new JdeField("ZDKTCM", "ZDKTCM", JdeDataType.String, 2),
        new JdeField("ZDOT1Y", "ZDOT1Y", JdeDataType.String, 2),
        new JdeField("ZDSTDP", "ZDSTDP", JdeDataType.Numeric),
        new JdeField("ZDCS07", "ZDCS07", JdeDataType.String, 16),
        new JdeField("ZDIT07", "ZDIT07", JdeDataType.String, 16),
        new JdeField("ZDTFLA", "ZDTFLA", JdeDataType.String, 4),
        new JdeField("ZDEDLN", "ZDEDLN", JdeDataType.Numeric),
        new JdeField("ZDRJOB", "ZDRJOB", JdeDataType.Numeric),
        new JdeField("ZDDETD", "ZDDETD", JdeDataType.Numeric),
        new JdeField("ZDDETF", "ZDDETF", JdeDataType.Numeric),
        new JdeField("ZDSHPN", "ZDSHPN", JdeDataType.Numeric),
        new JdeField("ZDLINN", "ZDLINN", JdeDataType.Numeric),
        new JdeField("ZDSLNE", "ZDSLNE", JdeDataType.Numeric),
        new JdeField("ZDDSGP", "ZDDSGP", JdeDataType.String, 6),
        new JdeField("ZDBPFG", "ZDBPFG", JdeDataType.String, 2),
        new JdeField("ZDHCDS", "ZDHCDS", JdeDataType.String, 20),
        new JdeField("ZDPSR", "ZDPSR", JdeDataType.String, 24),
        new JdeField("ZDPSRY", "ZDPSRY", JdeDataType.String, 4),
        new JdeField("ZDSEQ", "ZDSEQ", JdeDataType.Numeric),
        new JdeField("ZDRCUP", "ZDRCUP", JdeDataType.String, 2),
        new JdeField("ZDCMTR", "ZDCMTR", JdeDataType.String, 2),
        new JdeField("ZDALPH", "ZDALPH", JdeDataType.String, 80),
        new JdeField("ZDPMTH", "ZDPMTH", JdeDataType.String, 2),
        new JdeField("ZDSO16", "ZDSO16", JdeDataType.String, 2),
        new JdeField("ZDSO17", "ZDSO17", JdeDataType.String, 2),
        new JdeField("ZDSO18", "ZDSO18", JdeDataType.String, 2),
        new JdeField("ZDSO19", "ZDSO19", JdeDataType.String, 2),
        new JdeField("ZDSO20", "ZDSO20", JdeDataType.String, 2),
        new JdeField("ZDIR01", "ZDIR01", JdeDataType.String, 60),
        new JdeField("ZDIR02", "ZDIR02", JdeDataType.String, 60),
        new JdeField("ZDIR03", "ZDIR03", JdeDataType.String, 60),
        new JdeField("ZDIR04", "ZDIR04", JdeDataType.String, 60),
        new JdeField("ZDIR05", "ZDIR05", JdeDataType.String, 60),
        new JdeField("ZDSOOR", "ZDSOOR", JdeDataType.Numeric),
        new JdeField("ZDVR03", "ZDVR03", JdeDataType.String, 50),
        new JdeField("ZDBSC", "ZDBSC", JdeDataType.String, 20),
        new JdeField("ZDCBSC", "ZDCBSC", JdeDataType.String, 20),
        new JdeField("ZDCORD", "ZDCORD", JdeDataType.Numeric),
        new JdeField("ZDDVAN", "ZDDVAN", JdeDataType.Numeric),
        new JdeField("ZDPEND", "ZDPEND", JdeDataType.String, 2),
        new JdeField("ZDRFRV", "ZDRFRV", JdeDataType.String, 6),
        new JdeField("ZDPRJM", "ZDPRJM", JdeDataType.Numeric),
        new JdeField("ZDHOLD", "ZDHOLD", JdeDataType.String, 4),
        new JdeField("ZDODLN", "ZDODLN", JdeDataType.Numeric),
        new JdeField("ZDRLNU", "ZDRLNU", JdeDataType.String, 20),
        new JdeField("ZDDRQT", "ZDDRQT", JdeDataType.Numeric),
        new JdeField("ZDMCLN", "ZDMCLN", JdeDataType.Numeric),
        new JdeField("ZDPOE", "ZDPOE", JdeDataType.String, 12),
        new JdeField("ZDPMTO", "ZDPMTO", JdeDataType.String, 2),
        new JdeField("ZDNUMB", "ZDNUMB", JdeDataType.Numeric),
        new JdeField("ZDAAID", "ZDAAID", JdeDataType.Numeric),
        new JdeField("ZDSPATTN", "ZDSPATTN", JdeDataType.String, 100),
        new JdeField("ZDPRAN8", "ZDPRAN8", JdeDataType.Numeric),
        new JdeField("ZDPRCIDLN", "ZDPRCIDLN", JdeDataType.Numeric),
        new JdeField("ZDCCIDLN", "ZDCCIDLN", JdeDataType.Numeric),
        new JdeField("ZDSHCCIDLN", "ZDSHCCIDLN", JdeDataType.Numeric),
        new JdeField("ZDOPPID", "ZDOPPID", JdeDataType.Numeric),
        new JdeField("ZDOSTP", "ZDOSTP", JdeDataType.String, 6),
        new JdeField("ZDUKID", "ZDUKID", JdeDataType.Numeric),
        new JdeField("ZDCATNM", "ZDCATNM", JdeDataType.String, 60),
        new JdeField("ZDOPFR", "ZDOPFR", JdeDataType.String, 2),
        new JdeField("ZDOPERROR", "ZDOPERROR", JdeDataType.String, 80),
        new JdeField("ZDPMPN", "ZDPMPN", JdeDataType.String, 60),
        new JdeField("ZDPNS", "ZDPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI11_0", "Primary Key on ZDCTID, ZDJOBS, ZDLNIX, ZDDOCO, ZDDCTO, ZDKCOO, ZDLNID", new[] { "ZDCTID", "ZDJOBS", "ZDLNIX", "ZDDOCO", "ZDDCTO", "ZDKCOO", "ZDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI11_2", "Index on ZDJOBS, ZDCTID, ZDITM", new[] { "ZDJOBS", "ZDCTID", "ZDITM" }),
        new JdeIndex("F42UI11_3", "Index on ZDCTID, ZDJOBS, ZDSLNE", new[] { "ZDCTID", "ZDJOBS", "ZDSLNE" }),
        new JdeIndex("F42UI11_4", "Index on ZDCTID, ZDJOBS, ZDMCLN, ZDLNID", new[] { "ZDCTID", "ZDJOBS", "ZDMCLN", "ZDLNID" })
    };
}
