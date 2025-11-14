using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI12 - .
/// </summary>
public class F42UI12 : JdeTable
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
        /// ZDOPDJ.
        /// </summary>
        public const string ZDOPDJ = "ZDOPDJ";

        /// <summary>
        /// ZDPPDJ.
        /// </summary>
        public const string ZDPPDJ = "ZDPPDJ";

        /// <summary>
        /// ZDTHGD.
        /// </summary>
        public const string ZDTHGD = "ZDTHGD";

        /// <summary>
        /// ZDTHRP.
        /// </summary>
        public const string ZDTHRP = "ZDTHRP";

        /// <summary>
        /// ZDFRGD.
        /// </summary>
        public const string ZDFRGD = "ZDFRGD";

        /// <summary>
        /// ZDFRMP.
        /// </summary>
        public const string ZDFRMP = "ZDFRMP";

        /// <summary>
        /// ZDEMCU.
        /// </summary>
        public const string ZDEMCU = "ZDEMCU";

        /// <summary>
        /// ZDSRP1.
        /// </summary>
        public const string ZDSRP1 = "ZDSRP1";

        /// <summary>
        /// ZDSRP2.
        /// </summary>
        public const string ZDSRP2 = "ZDSRP2";

        /// <summary>
        /// ZDSRP3.
        /// </summary>
        public const string ZDSRP3 = "ZDSRP3";

        /// <summary>
        /// ZDSRP4.
        /// </summary>
        public const string ZDSRP4 = "ZDSRP4";

        /// <summary>
        /// ZDSRP5.
        /// </summary>
        public const string ZDSRP5 = "ZDSRP5";

        /// <summary>
        /// ZDPRP1.
        /// </summary>
        public const string ZDPRP1 = "ZDPRP1";

        /// <summary>
        /// ZDPRP2.
        /// </summary>
        public const string ZDPRP2 = "ZDPRP2";

        /// <summary>
        /// ZDPRP3.
        /// </summary>
        public const string ZDPRP3 = "ZDPRP3";

        /// <summary>
        /// ZDPRP4.
        /// </summary>
        public const string ZDPRP4 = "ZDPRP4";

        /// <summary>
        /// ZDPRP5.
        /// </summary>
        public const string ZDPRP5 = "ZDPRP5";

        /// <summary>
        /// ZDINMG.
        /// </summary>
        public const string ZDINMG = "ZDINMG";

        /// <summary>
        /// ZDPTC.
        /// </summary>
        public const string ZDPTC = "ZDPTC";

        /// <summary>
        /// ZDDTBS.
        /// </summary>
        public const string ZDDTBS = "ZDDTBS";

        /// <summary>
        /// ZDRYIN.
        /// </summary>
        public const string ZDRYIN = "ZDRYIN";

        /// <summary>
        /// ZDTRDC.
        /// </summary>
        public const string ZDTRDC = "ZDTRDC";

        /// <summary>
        /// ZDPRGR.
        /// </summary>
        public const string ZDPRGR = "ZDPRGR";

        /// <summary>
        /// ZDCADC.
        /// </summary>
        public const string ZDCADC = "ZDCADC";

        /// <summary>
        /// ZDKCO.
        /// </summary>
        public const string ZDKCO = "ZDKCO";

        /// <summary>
        /// ZDDOC.
        /// </summary>
        public const string ZDDOC = "ZDDOC";

        /// <summary>
        /// ZDDCT.
        /// </summary>
        public const string ZDDCT = "ZDDCT";

        /// <summary>
        /// ZDTXA1.
        /// </summary>
        public const string ZDTXA1 = "ZDTXA1";

        /// <summary>
        /// ZDEXR1.
        /// </summary>
        public const string ZDEXR1 = "ZDEXR1";

        /// <summary>
        /// ZDPRIO.
        /// </summary>
        public const string ZDPRIO = "ZDPRIO";

        /// <summary>
        /// ZDBACK.
        /// </summary>
        public const string ZDBACK = "ZDBACK";

        /// <summary>
        /// ZDSBAL.
        /// </summary>
        public const string ZDSBAL = "ZDSBAL";

        /// <summary>
        /// ZDLOB.
        /// </summary>
        public const string ZDLOB = "ZDLOB";

        /// <summary>
        /// ZDEUSE.
        /// </summary>
        public const string ZDEUSE = "ZDEUSE";

        /// <summary>
        /// ZDDTYS.
        /// </summary>
        public const string ZDDTYS = "ZDDTYS";

        /// <summary>
        /// ZDNTR.
        /// </summary>
        public const string ZDNTR = "ZDNTR";

        /// <summary>
        /// ZDCARS.
        /// </summary>
        public const string ZDCARS = "ZDCARS";

        /// <summary>
        /// ZDMOT.
        /// </summary>
        public const string ZDMOT = "ZDMOT";

        /// <summary>
        /// ZDROUT.
        /// </summary>
        public const string ZDROUT = "ZDROUT";

        /// <summary>
        /// ZDSTOP.
        /// </summary>
        public const string ZDSTOP = "ZDSTOP";

        /// <summary>
        /// ZDZON.
        /// </summary>
        public const string ZDZON = "ZDZON";

        /// <summary>
        /// ZDAFT.
        /// </summary>
        public const string ZDAFT = "ZDAFT";

        /// <summary>
        /// ZDFRTH.
        /// </summary>
        public const string ZDFRTH = "ZDFRTH";

        /// <summary>
        /// ZDSHCM.
        /// </summary>
        public const string ZDSHCM = "ZDSHCM";

        /// <summary>
        /// ZDSHCN.
        /// </summary>
        public const string ZDSHCN = "ZDSHCN";

        /// <summary>
        /// ZDSERN.
        /// </summary>
        public const string ZDSERN = "ZDSERN";

        /// <summary>
        /// ZDGLC.
        /// </summary>
        public const string ZDGLC = "ZDGLC";

        /// <summary>
        /// ZDACOM.
        /// </summary>
        public const string ZDACOM = "ZDACOM";

        /// <summary>
        /// ZDRCD.
        /// </summary>
        public const string ZDRCD = "ZDRCD";

        /// <summary>
        /// ZDGWUM.
        /// </summary>
        public const string ZDGWUM = "ZDGWUM";

        /// <summary>
        /// ZDSBL.
        /// </summary>
        public const string ZDSBL = "ZDSBL";

        /// <summary>
        /// ZDSBLT.
        /// </summary>
        public const string ZDSBLT = "ZDSBLT";

        /// <summary>
        /// ZDLCOD.
        /// </summary>
        public const string ZDLCOD = "ZDLCOD";

        /// <summary>
        /// ZDSWMS.
        /// </summary>
        public const string ZDSWMS = "ZDSWMS";

        /// <summary>
        /// ZDUNCD.
        /// </summary>
        public const string ZDUNCD = "ZDUNCD";

        /// <summary>
        /// ZDCRMD.
        /// </summary>
        public const string ZDCRMD = "ZDCRMD";

        /// <summary>
        /// ZDURCD.
        /// </summary>
        public const string ZDURCD = "ZDURCD";

        /// <summary>
        /// ZDURDT.
        /// </summary>
        public const string ZDURDT = "ZDURDT";

        /// <summary>
        /// ZDURAT.
        /// </summary>
        public const string ZDURAT = "ZDURAT";

        /// <summary>
        /// ZDURAB.
        /// </summary>
        public const string ZDURAB = "ZDURAB";

        /// <summary>
        /// ZDURRF.
        /// </summary>
        public const string ZDURRF = "ZDURRF";

        /// <summary>
        /// ZDFRAT.
        /// </summary>
        public const string ZDFRAT = "ZDFRAT";

        /// <summary>
        /// ZDMCU.
        /// </summary>
        public const string ZDMCU = "ZDMCU";

        /// <summary>
        /// ZDITM.
        /// </summary>
        public const string ZDITM = "ZDITM";

        /// <summary>
        /// ZDLOCN.
        /// </summary>
        public const string ZDLOCN = "ZDLOCN";

        /// <summary>
        /// ZDLOTN.
        /// </summary>
        public const string ZDLOTN = "ZDLOTN";

        /// <summary>
        /// ZDUOM.
        /// </summary>
        public const string ZDUOM = "ZDUOM";

        /// <summary>
        /// ZDSOQS.
        /// </summary>
        public const string ZDSOQS = "ZDSOQS";

        /// <summary>
        /// ZDSOBK.
        /// </summary>
        public const string ZDSOBK = "ZDSOBK";

        /// <summary>
        /// ZDSONE.
        /// </summary>
        public const string ZDSONE = "ZDSONE";

        /// <summary>
        /// ZDOTQY.
        /// </summary>
        public const string ZDOTQY = "ZDOTQY";

        /// <summary>
        /// ZDFFG1.
        /// </summary>
        public const string ZDFFG1 = "ZDFFG1";

        /// <summary>
        /// ZDFFG2.
        /// </summary>
        public const string ZDFFG2 = "ZDFFG2";

        /// <summary>
        /// ZDFFU2.
        /// </summary>
        public const string ZDFFU2 = "ZDFFU2";

        /// <summary>
        /// ZDSHPN.
        /// </summary>
        public const string ZDSHPN = "ZDSHPN";

        /// <summary>
        /// ZDRSDT.
        /// </summary>
        public const string ZDRSDT = "ZDRSDT";

        /// <summary>
        /// ZDOSEQ.
        /// </summary>
        public const string ZDOSEQ = "ZDOSEQ";

        /// <summary>
        /// ZDMERL.
        /// </summary>
        public const string ZDMERL = "ZDMERL";

        /// <summary>
        /// ZDHDBU.
        /// </summary>
        public const string ZDHDBU = "ZDHDBU";

        /// <summary>
        /// ZDDMBU.
        /// </summary>
        public const string ZDDMBU = "ZDDMBU";

        /// <summary>
        /// ZDBCRC.
        /// </summary>
        public const string ZDBCRC = "ZDBCRC";

        /// <summary>
        /// ZDDEID.
        /// </summary>
        public const string ZDDEID = "ZDDEID";

        /// <summary>
        /// ZDPSIG.
        /// </summary>
        public const string ZDPSIG = "ZDPSIG";

        /// <summary>
        /// ZDPMDT.
        /// </summary>
        public const string ZDPMDT = "ZDPMDT";

        /// <summary>
        /// ZDRLTM.
        /// </summary>
        public const string ZDRLTM = "ZDRLTM";

        /// <summary>
        /// ZDRLDJ.
        /// </summary>
        public const string ZDRLDJ = "ZDRLDJ";

        /// <summary>
        /// ZDADTM.
        /// </summary>
        public const string ZDADTM = "ZDADTM";

        /// <summary>
        /// ZDOPTT.
        /// </summary>
        public const string ZDOPTT = "ZDOPTT";

        /// <summary>
        /// ZDPDTT.
        /// </summary>
        public const string ZDPDTT = "ZDPDTT";

        /// <summary>
        /// ZDPSTM.
        /// </summary>
        public const string ZDPSTM = "ZDPSTM";

        /// <summary>
        /// ZDXDCK.
        /// </summary>
        public const string ZDXDCK = "ZDXDCK";

        /// <summary>
        /// ZDXPTY.
        /// </summary>
        public const string ZDXPTY = "ZDXPTY";

        /// <summary>
        /// ZDXKCO.
        /// </summary>
        public const string ZDXKCO = "ZDXKCO";

        /// <summary>
        /// ZDXORN.
        /// </summary>
        public const string ZDXORN = "ZDXORN";

        /// <summary>
        /// ZDXCTO.
        /// </summary>
        public const string ZDXCTO = "ZDXCTO";

        /// <summary>
        /// ZDXLLN.
        /// </summary>
        public const string ZDXLLN = "ZDXLLN";

        /// <summary>
        /// ZDXSFX.
        /// </summary>
        public const string ZDXSFX = "ZDXSFX";

        /// <summary>
        /// ZDANBY.
        /// </summary>
        public const string ZDANBY = "ZDANBY";

        /// <summary>
        /// ZDPMTN.
        /// </summary>
        public const string ZDPMTN = "ZDPMTN";

        /// <summary>
        /// ZDOPOL.
        /// </summary>
        public const string ZDOPOL = "ZDOPOL";

        /// <summary>
        /// ZDOPBO.
        /// </summary>
        public const string ZDOPBO = "ZDOPBO";

        /// <summary>
        /// ZDOPID.
        /// </summary>
        public const string ZDOPID = "ZDOPID";

        /// <summary>
        /// ZDOPCS.
        /// </summary>
        public const string ZDOPCS = "ZDOPCS";

        /// <summary>
        /// ZDOPLL.
        /// </summary>
        public const string ZDOPLL = "ZDOPLL";

        /// <summary>
        /// ZDOPMS.
        /// </summary>
        public const string ZDOPMS = "ZDOPMS";

        /// <summary>
        /// ZDOPSS.
        /// </summary>
        public const string ZDOPSS = "ZDOPSS";

        /// <summary>
        /// ZDOPBA.
        /// </summary>
        public const string ZDOPBA = "ZDOPBA";

        /// <summary>
        /// ZDOPMG.
        /// </summary>
        public const string ZDOPMG = "ZDOPMG";

        /// <summary>
        /// ZDOPSG.
        /// </summary>
        public const string ZDOPSG = "ZDOPSG";

        /// <summary>
        /// ZDOPYN.
        /// </summary>
        public const string ZDOPYN = "ZDOPYN";

        /// <summary>
        /// ZDOPSU.
        /// </summary>
        public const string ZDOPSU = "ZDOPSU";

        /// <summary>
        /// ZDFXSR.
        /// </summary>
        public const string ZDFXSR = "ZDFXSR";

        /// <summary>
        /// ZDEDCK.
        /// </summary>
        public const string ZDEDCK = "ZDEDCK";

        /// <summary>
        /// ZDSBCK.
        /// </summary>
        public const string ZDSBCK = "ZDSBCK";

        /// <summary>
        /// ZDBBCK.
        /// </summary>
        public const string ZDBBCK = "ZDBBCK";

        /// <summary>
        /// ZDCMDM.
        /// </summary>
        public const string ZDCMDM = "ZDCMDM";

        /// <summary>
        /// ZDDUAL.
        /// </summary>
        public const string ZDDUAL = "ZDDUAL";

        /// <summary>
        /// ZDSOEF.
        /// </summary>
        public const string ZDSOEF = "ZDSOEF";

        /// <summary>
        /// ZDSOEG.
        /// </summary>
        public const string ZDSOEG = "ZDSOEG";

        /// <summary>
        /// ZDPSJOBNO.
        /// </summary>
        public const string ZDPSJOBNO = "ZDPSJOBNO";

        /// <summary>
        /// ZDJOBSQ.
        /// </summary>
        public const string ZDJOBSQ = "ZDJOBSQ";

        /// <summary>
        /// ZDDELBATCH.
        /// </summary>
        public const string ZDDELBATCH = "ZDDELBATCH";

        /// <summary>
        /// ZDCARDNO.
        /// </summary>
        public const string ZDCARDNO = "ZDCARDNO";

        /// <summary>
        /// ZDALLOC.
        /// </summary>
        public const string ZDALLOC = "ZDALLOC";

        /// <summary>
        /// ZDFULPID.
        /// </summary>
        public const string ZDFULPID = "ZDFULPID";

        /// <summary>
        /// ZDALLSTS.
        /// </summary>
        public const string ZDALLSTS = "ZDALLSTS";

        /// <summary>
        /// ZDOSCORE.
        /// </summary>
        public const string ZDOSCORE = "ZDOSCORE";

        /// <summary>
        /// ZDOSCOREO.
        /// </summary>
        public const string ZDOSCOREO = "ZDOSCOREO";

        /// <summary>
        /// ZDCMCO.
        /// </summary>
        public const string ZDCMCO = "ZDCMCO";

        /// <summary>
        /// ZDKITID.
        /// </summary>
        public const string ZDKITID = "ZDKITID";

        /// <summary>
        /// ZDKITAMTDOM.
        /// </summary>
        public const string ZDKITAMTDOM = "ZDKITAMTDOM";

        /// <summary>
        /// ZDKITAMTFOR.
        /// </summary>
        public const string ZDKITAMTFOR = "ZDKITAMTFOR";

        /// <summary>
        /// ZDKITDIRTY.
        /// </summary>
        public const string ZDKITDIRTY = "ZDKITDIRTY";

        /// <summary>
        /// ZDOCITT.
        /// </summary>
        public const string ZDOCITT = "ZDOCITT";

        /// <summary>
        /// ZDOCCARDNO.
        /// </summary>
        public const string ZDOCCARDNO = "ZDOCCARDNO";

        /// <summary>
        /// ZDTUPRC.
        /// </summary>
        public const string ZDTUPRC = "ZDTUPRC";

        /// <summary>
        /// ZDUTA.
        /// </summary>
        public const string ZDUTA = "ZDUTA";

        /// <summary>
        /// ZDTAEXP.
        /// </summary>
        public const string ZDTAEXP = "ZDTAEXP";

        /// <summary>
        /// ZDETA.
        /// </summary>
        public const string ZDETA = "ZDETA";

        /// <summary>
        /// ZDTFUP.
        /// </summary>
        public const string ZDTFUP = "ZDTFUP";

        /// <summary>
        /// ZDFUTA.
        /// </summary>
        public const string ZDFUTA = "ZDFUTA";

        /// <summary>
        /// ZDTFEA.
        /// </summary>
        public const string ZDTFEA = "ZDTFEA";

        /// <summary>
        /// ZDFETA.
        /// </summary>
        public const string ZDFETA = "ZDFETA";

        /// <summary>
        /// ZDTPROV.
        /// </summary>
        public const string ZDTPROV = "ZDTPROV";

        /// <summary>
        /// ZDDTXJ.
        /// </summary>
        public const string ZDDTXJ = "ZDDTXJ";

        /// <summary>
        /// ZDTKITAMTD.
        /// </summary>
        public const string ZDTKITAMTD = "ZDTKITAMTD";

        /// <summary>
        /// ZDTKITAMTF.
        /// </summary>
        public const string ZDTKITAMTF = "ZDTKITAMTF";

        /// <summary>
        /// ZDCRCD.
        /// </summary>
        public const string ZDCRCD = "ZDCRCD";

        /// <summary>
        /// ZDGOPSUR.
        /// </summary>
        public const string ZDGOPSUR = "ZDGOPSUR";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDCTID", "ZDCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZDJOBS", "ZDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDLNIX", "ZDLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDKCOO", "ZDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ZDDOCO", "ZDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDDCTO", "ZDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ZDLNID", "ZDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDOPDJ", "ZDOPDJ", JdeDataType.Numeric),
        new JdeField("ZDPPDJ", "ZDPPDJ", JdeDataType.Numeric),
        new JdeField("ZDTHGD", "ZDTHGD", JdeDataType.String, 6),
        new JdeField("ZDTHRP", "ZDTHRP", JdeDataType.Numeric),
        new JdeField("ZDFRGD", "ZDFRGD", JdeDataType.String, 6),
        new JdeField("ZDFRMP", "ZDFRMP", JdeDataType.Numeric),
        new JdeField("ZDEMCU", "ZDEMCU", JdeDataType.String, 24),
        new JdeField("ZDSRP1", "ZDSRP1", JdeDataType.String, 6),
        new JdeField("ZDSRP2", "ZDSRP2", JdeDataType.String, 6),
        new JdeField("ZDSRP3", "ZDSRP3", JdeDataType.String, 6),
        new JdeField("ZDSRP4", "ZDSRP4", JdeDataType.String, 6),
        new JdeField("ZDSRP5", "ZDSRP5", JdeDataType.String, 6),
        new JdeField("ZDPRP1", "ZDPRP1", JdeDataType.String, 6),
        new JdeField("ZDPRP2", "ZDPRP2", JdeDataType.String, 6),
        new JdeField("ZDPRP3", "ZDPRP3", JdeDataType.String, 6),
        new JdeField("ZDPRP4", "ZDPRP4", JdeDataType.String, 6),
        new JdeField("ZDPRP5", "ZDPRP5", JdeDataType.String, 6),
        new JdeField("ZDINMG", "ZDINMG", JdeDataType.String, 20),
        new JdeField("ZDPTC", "ZDPTC", JdeDataType.String, 6),
        new JdeField("ZDDTBS", "ZDDTBS", JdeDataType.String, 2),
        new JdeField("ZDRYIN", "ZDRYIN", JdeDataType.String, 2),
        new JdeField("ZDTRDC", "ZDTRDC", JdeDataType.Numeric),
        new JdeField("ZDPRGR", "ZDPRGR", JdeDataType.String, 16),
        new JdeField("ZDCADC", "ZDCADC", JdeDataType.Numeric),
        new JdeField("ZDKCO", "ZDKCO", JdeDataType.String, 10),
        new JdeField("ZDDOC", "ZDDOC", JdeDataType.Numeric),
        new JdeField("ZDDCT", "ZDDCT", JdeDataType.String, 4),
        new JdeField("ZDTXA1", "ZDTXA1", JdeDataType.String, 20),
        new JdeField("ZDEXR1", "ZDEXR1", JdeDataType.String, 4),
        new JdeField("ZDPRIO", "ZDPRIO", JdeDataType.String, 2),
        new JdeField("ZDBACK", "ZDBACK", JdeDataType.String, 2),
        new JdeField("ZDSBAL", "ZDSBAL", JdeDataType.String, 2),
        new JdeField("ZDLOB", "ZDLOB", JdeDataType.String, 6),
        new JdeField("ZDEUSE", "ZDEUSE", JdeDataType.String, 6),
        new JdeField("ZDDTYS", "ZDDTYS", JdeDataType.String, 4),
        new JdeField("ZDNTR", "ZDNTR", JdeDataType.String, 4),
        new JdeField("ZDCARS", "ZDCARS", JdeDataType.Numeric),
        new JdeField("ZDMOT", "ZDMOT", JdeDataType.String, 6),
        new JdeField("ZDROUT", "ZDROUT", JdeDataType.String, 6),
        new JdeField("ZDSTOP", "ZDSTOP", JdeDataType.String, 6),
        new JdeField("ZDZON", "ZDZON", JdeDataType.String, 6),
        new JdeField("ZDAFT", "ZDAFT", JdeDataType.String, 2),
        new JdeField("ZDFRTH", "ZDFRTH", JdeDataType.String, 6),
        new JdeField("ZDSHCM", "ZDSHCM", JdeDataType.String, 6),
        new JdeField("ZDSHCN", "ZDSHCN", JdeDataType.String, 6),
        new JdeField("ZDSERN", "ZDSERN", JdeDataType.String, 60),
        new JdeField("ZDGLC", "ZDGLC", JdeDataType.String, 8),
        new JdeField("ZDACOM", "ZDACOM", JdeDataType.String, 2),
        new JdeField("ZDRCD", "ZDRCD", JdeDataType.String, 6),
        new JdeField("ZDGWUM", "ZDGWUM", JdeDataType.String, 4),
        new JdeField("ZDSBL", "ZDSBL", JdeDataType.String, 16),
        new JdeField("ZDSBLT", "ZDSBLT", JdeDataType.String, 2),
        new JdeField("ZDLCOD", "ZDLCOD", JdeDataType.String, 4),
        new JdeField("ZDSWMS", "ZDSWMS", JdeDataType.String, 2),
        new JdeField("ZDUNCD", "ZDUNCD", JdeDataType.String, 2),
        new JdeField("ZDCRMD", "ZDCRMD", JdeDataType.String, 2),
        new JdeField("ZDURCD", "ZDURCD", JdeDataType.String, 4),
        new JdeField("ZDURDT", "ZDURDT", JdeDataType.Numeric),
        new JdeField("ZDURAT", "ZDURAT", JdeDataType.Numeric),
        new JdeField("ZDURAB", "ZDURAB", JdeDataType.Numeric),
        new JdeField("ZDURRF", "ZDURRF", JdeDataType.String, 30),
        new JdeField("ZDFRAT", "ZDFRAT", JdeDataType.String, 20),
        new JdeField("ZDMCU", "ZDMCU", JdeDataType.String, 24),
        new JdeField("ZDITM", "ZDITM", JdeDataType.Numeric),
        new JdeField("ZDLOCN", "ZDLOCN", JdeDataType.String, 40),
        new JdeField("ZDLOTN", "ZDLOTN", JdeDataType.String, 60),
        new JdeField("ZDUOM", "ZDUOM", JdeDataType.String, 4),
        new JdeField("ZDSOQS", "ZDSOQS", JdeDataType.Numeric),
        new JdeField("ZDSOBK", "ZDSOBK", JdeDataType.Numeric),
        new JdeField("ZDSONE", "ZDSONE", JdeDataType.Numeric),
        new JdeField("ZDOTQY", "ZDOTQY", JdeDataType.String, 2),
        new JdeField("ZDFFG1", "ZDFFG1", JdeDataType.String, 2),
        new JdeField("ZDFFG2", "ZDFFG2", JdeDataType.String, 2),
        new JdeField("ZDFFU2", "ZDFFU2", JdeDataType.String, 2),
        new JdeField("ZDSHPN", "ZDSHPN", JdeDataType.Numeric),
        new JdeField("ZDRSDT", "ZDRSDT", JdeDataType.Numeric),
        new JdeField("ZDOSEQ", "ZDOSEQ", JdeDataType.Numeric),
        new JdeField("ZDMERL", "ZDMERL", JdeDataType.String, 6),
        new JdeField("ZDHDBU", "ZDHDBU", JdeDataType.String, 24),
        new JdeField("ZDDMBU", "ZDDMBU", JdeDataType.String, 24),
        new JdeField("ZDBCRC", "ZDBCRC", JdeDataType.String, 6),
        new JdeField("ZDDEID", "ZDDEID", JdeDataType.Numeric),
        new JdeField("ZDPSIG", "ZDPSIG", JdeDataType.String, 60),
        new JdeField("ZDPMDT", "ZDPMDT", JdeDataType.Numeric),
        new JdeField("ZDRLTM", "ZDRLTM", JdeDataType.Numeric),
        new JdeField("ZDRLDJ", "ZDRLDJ", JdeDataType.Numeric),
        new JdeField("ZDADTM", "ZDADTM", JdeDataType.Numeric),
        new JdeField("ZDOPTT", "ZDOPTT", JdeDataType.Numeric),
        new JdeField("ZDPDTT", "ZDPDTT", JdeDataType.Numeric),
        new JdeField("ZDPSTM", "ZDPSTM", JdeDataType.Numeric),
        new JdeField("ZDXDCK", "ZDXDCK", JdeDataType.String, 2),
        new JdeField("ZDXPTY", "ZDXPTY", JdeDataType.Numeric),
        new JdeField("ZDXKCO", "ZDXKCO", JdeDataType.String, 10),
        new JdeField("ZDXORN", "ZDXORN", JdeDataType.Numeric),
        new JdeField("ZDXCTO", "ZDXCTO", JdeDataType.String, 4),
        new JdeField("ZDXLLN", "ZDXLLN", JdeDataType.Numeric),
        new JdeField("ZDXSFX", "ZDXSFX", JdeDataType.String, 6),
        new JdeField("ZDANBY", "ZDANBY", JdeDataType.Numeric),
        new JdeField("ZDPMTN", "ZDPMTN", JdeDataType.String, 24),
        new JdeField("ZDOPOL", "ZDOPOL", JdeDataType.Numeric),
        new JdeField("ZDOPBO", "ZDOPBO", JdeDataType.String, 60),
        new JdeField("ZDOPID", "ZDOPID", JdeDataType.String, 60),
        new JdeField("ZDOPCS", "ZDOPCS", JdeDataType.Numeric),
        new JdeField("ZDOPLL", "ZDOPLL", JdeDataType.String, 2),
        new JdeField("ZDOPMS", "ZDOPMS", JdeDataType.String, 2),
        new JdeField("ZDOPSS", "ZDOPSS", JdeDataType.String, 2),
        new JdeField("ZDOPBA", "ZDOPBA", JdeDataType.String, 2),
        new JdeField("ZDOPMG", "ZDOPMG", JdeDataType.String, 60),
        new JdeField("ZDOPSG", "ZDOPSG", JdeDataType.String, 60),
        new JdeField("ZDOPYN", "ZDOPYN", JdeDataType.String, 2),
        new JdeField("ZDOPSU", "ZDOPSU", JdeDataType.String, 2),
        new JdeField("ZDFXSR", "ZDFXSR", JdeDataType.String, 2),
        new JdeField("ZDEDCK", "ZDEDCK", JdeDataType.String, 2),
        new JdeField("ZDSBCK", "ZDSBCK", JdeDataType.String, 2),
        new JdeField("ZDBBCK", "ZDBBCK", JdeDataType.String, 2),
        new JdeField("ZDCMDM", "ZDCMDM", JdeDataType.String, 2),
        new JdeField("ZDDUAL", "ZDDUAL", JdeDataType.String, 2),
        new JdeField("ZDSOEF", "ZDSOEF", JdeDataType.String, 60),
        new JdeField("ZDSOEG", "ZDSOEG", JdeDataType.String, 60),
        new JdeField("ZDPSJOBNO", "ZDPSJOBNO", JdeDataType.String, 30),
        new JdeField("ZDJOBSQ", "ZDJOBSQ", JdeDataType.String, 30),
        new JdeField("ZDDELBATCH", "ZDDELBATCH", JdeDataType.String, 12),
        new JdeField("ZDCARDNO", "ZDCARDNO", JdeDataType.String, 8),
        new JdeField("ZDALLOC", "ZDALLOC", JdeDataType.String, 2),
        new JdeField("ZDFULPID", "ZDFULPID", JdeDataType.Numeric),
        new JdeField("ZDALLSTS", "ZDALLSTS", JdeDataType.String, 60),
        new JdeField("ZDOSCORE", "ZDOSCORE", JdeDataType.Numeric),
        new JdeField("ZDOSCOREO", "ZDOSCOREO", JdeDataType.String, 2),
        new JdeField("ZDCMCO", "ZDCMCO", JdeDataType.String, 10),
        new JdeField("ZDKITID", "ZDKITID", JdeDataType.Numeric),
        new JdeField("ZDKITAMTDOM", "ZDKITAMTDOM", JdeDataType.Numeric),
        new JdeField("ZDKITAMTFOR", "ZDKITAMTFOR", JdeDataType.Numeric),
        new JdeField("ZDKITDIRTY", "ZDKITDIRTY", JdeDataType.String, 2),
        new JdeField("ZDOCITT", "ZDOCITT", JdeDataType.String, 2),
        new JdeField("ZDOCCARDNO", "ZDOCCARDNO", JdeDataType.Numeric),
        new JdeField("ZDTUPRC", "ZDTUPRC", JdeDataType.Numeric),
        new JdeField("ZDUTA", "ZDUTA", JdeDataType.Numeric),
        new JdeField("ZDTAEXP", "ZDTAEXP", JdeDataType.Numeric),
        new JdeField("ZDETA", "ZDETA", JdeDataType.Numeric),
        new JdeField("ZDTFUP", "ZDTFUP", JdeDataType.Numeric),
        new JdeField("ZDFUTA", "ZDFUTA", JdeDataType.Numeric),
        new JdeField("ZDTFEA", "ZDTFEA", JdeDataType.Numeric),
        new JdeField("ZDFETA", "ZDFETA", JdeDataType.Numeric),
        new JdeField("ZDTPROV", "ZDTPROV", JdeDataType.String, 2),
        new JdeField("ZDDTXJ", "ZDDTXJ", JdeDataType.Numeric),
        new JdeField("ZDTKITAMTD", "ZDTKITAMTD", JdeDataType.Numeric),
        new JdeField("ZDTKITAMTF", "ZDTKITAMTF", JdeDataType.Numeric),
        new JdeField("ZDCRCD", "ZDCRCD", JdeDataType.String, 6),
        new JdeField("ZDGOPSUR", "ZDGOPSUR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI12_0", "Primary Key on ZDCTID, ZDJOBS, ZDLNIX, ZDDOCO, ZDDCTO, ZDKCOO, ZDLNID", new[] { "ZDCTID", "ZDJOBS", "ZDLNIX", "ZDDOCO", "ZDDCTO", "ZDKCOO", "ZDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI12_2", "Index on ZDCTID, ZDJOBS, ZDLNIX", new[] { "ZDCTID", "ZDJOBS", "ZDLNIX" }),
        new JdeIndex("F42UI12_3", "Index on ZDCTID, ZDJOBS, ZDKCOO, ZDDOCO, ZDDCTO, ZDLNID", new[] { "ZDCTID", "ZDJOBS", "ZDKCOO", "ZDDOCO", "ZDDCTO", "ZDLNID" })
    };
}
