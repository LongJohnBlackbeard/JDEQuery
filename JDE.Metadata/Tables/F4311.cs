using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4311 - .
/// </summary>
public class F4311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDKCOO.
        /// </summary>
        public const string PDKCOO = "PDKCOO";

        /// <summary>
        /// PDDOCO.
        /// </summary>
        public const string PDDOCO = "PDDOCO";

        /// <summary>
        /// PDDCTO.
        /// </summary>
        public const string PDDCTO = "PDDCTO";

        /// <summary>
        /// PDSFXO.
        /// </summary>
        public const string PDSFXO = "PDSFXO";

        /// <summary>
        /// PDLNID.
        /// </summary>
        public const string PDLNID = "PDLNID";

        /// <summary>
        /// PDMCU.
        /// </summary>
        public const string PDMCU = "PDMCU";

        /// <summary>
        /// PDCO.
        /// </summary>
        public const string PDCO = "PDCO";

        /// <summary>
        /// PDOKCO.
        /// </summary>
        public const string PDOKCO = "PDOKCO";

        /// <summary>
        /// PDOORN.
        /// </summary>
        public const string PDOORN = "PDOORN";

        /// <summary>
        /// PDOCTO.
        /// </summary>
        public const string PDOCTO = "PDOCTO";

        /// <summary>
        /// PDOGNO.
        /// </summary>
        public const string PDOGNO = "PDOGNO";

        /// <summary>
        /// PDRKCO.
        /// </summary>
        public const string PDRKCO = "PDRKCO";

        /// <summary>
        /// PDRORN.
        /// </summary>
        public const string PDRORN = "PDRORN";

        /// <summary>
        /// PDRCTO.
        /// </summary>
        public const string PDRCTO = "PDRCTO";

        /// <summary>
        /// PDRLLN.
        /// </summary>
        public const string PDRLLN = "PDRLLN";

        /// <summary>
        /// PDDMCT.
        /// </summary>
        public const string PDDMCT = "PDDMCT";

        /// <summary>
        /// PDDMCS.
        /// </summary>
        public const string PDDMCS = "PDDMCS";

        /// <summary>
        /// PDBALU.
        /// </summary>
        public const string PDBALU = "PDBALU";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

        /// <summary>
        /// PDSHAN.
        /// </summary>
        public const string PDSHAN = "PDSHAN";

        /// <summary>
        /// PDDRQJ.
        /// </summary>
        public const string PDDRQJ = "PDDRQJ";

        /// <summary>
        /// PDTRDJ.
        /// </summary>
        public const string PDTRDJ = "PDTRDJ";

        /// <summary>
        /// PDPDDJ.
        /// </summary>
        public const string PDPDDJ = "PDPDDJ";

        /// <summary>
        /// PDOPDJ.
        /// </summary>
        public const string PDOPDJ = "PDOPDJ";

        /// <summary>
        /// PDADDJ.
        /// </summary>
        public const string PDADDJ = "PDADDJ";

        /// <summary>
        /// PDCNDJ.
        /// </summary>
        public const string PDCNDJ = "PDCNDJ";

        /// <summary>
        /// PDPEFJ.
        /// </summary>
        public const string PDPEFJ = "PDPEFJ";

        /// <summary>
        /// PDPPDJ.
        /// </summary>
        public const string PDPPDJ = "PDPPDJ";

        /// <summary>
        /// PDPSDJ.
        /// </summary>
        public const string PDPSDJ = "PDPSDJ";

        /// <summary>
        /// PDDSVJ.
        /// </summary>
        public const string PDDSVJ = "PDDSVJ";

        /// <summary>
        /// PDDGL.
        /// </summary>
        public const string PDDGL = "PDDGL";

        /// <summary>
        /// PDPN.
        /// </summary>
        public const string PDPN = "PDPN";

        /// <summary>
        /// PDVR01.
        /// </summary>
        public const string PDVR01 = "PDVR01";

        /// <summary>
        /// PDVR02.
        /// </summary>
        public const string PDVR02 = "PDVR02";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDLITM.
        /// </summary>
        public const string PDLITM = "PDLITM";

        /// <summary>
        /// PDAITM.
        /// </summary>
        public const string PDAITM = "PDAITM";

        /// <summary>
        /// PDLOCN.
        /// </summary>
        public const string PDLOCN = "PDLOCN";

        /// <summary>
        /// PDLOTN.
        /// </summary>
        public const string PDLOTN = "PDLOTN";

        /// <summary>
        /// PDFRGD.
        /// </summary>
        public const string PDFRGD = "PDFRGD";

        /// <summary>
        /// PDTHGD.
        /// </summary>
        public const string PDTHGD = "PDTHGD";

        /// <summary>
        /// PDFRMP.
        /// </summary>
        public const string PDFRMP = "PDFRMP";

        /// <summary>
        /// PDTHRP.
        /// </summary>
        public const string PDTHRP = "PDTHRP";

        /// <summary>
        /// PDDSC1.
        /// </summary>
        public const string PDDSC1 = "PDDSC1";

        /// <summary>
        /// PDDSC2.
        /// </summary>
        public const string PDDSC2 = "PDDSC2";

        /// <summary>
        /// PDLNTY.
        /// </summary>
        public const string PDLNTY = "PDLNTY";

        /// <summary>
        /// PDNXTR.
        /// </summary>
        public const string PDNXTR = "PDNXTR";

        /// <summary>
        /// PDLTTR.
        /// </summary>
        public const string PDLTTR = "PDLTTR";

        /// <summary>
        /// PDRLIT.
        /// </summary>
        public const string PDRLIT = "PDRLIT";

        /// <summary>
        /// PDPDS1.
        /// </summary>
        public const string PDPDS1 = "PDPDS1";

        /// <summary>
        /// PDPDS2.
        /// </summary>
        public const string PDPDS2 = "PDPDS2";

        /// <summary>
        /// PDPDS3.
        /// </summary>
        public const string PDPDS3 = "PDPDS3";

        /// <summary>
        /// PDPDS4.
        /// </summary>
        public const string PDPDS4 = "PDPDS4";

        /// <summary>
        /// PDPDS5.
        /// </summary>
        public const string PDPDS5 = "PDPDS5";

        /// <summary>
        /// PDPDP1.
        /// </summary>
        public const string PDPDP1 = "PDPDP1";

        /// <summary>
        /// PDPDP2.
        /// </summary>
        public const string PDPDP2 = "PDPDP2";

        /// <summary>
        /// PDPDP3.
        /// </summary>
        public const string PDPDP3 = "PDPDP3";

        /// <summary>
        /// PDPDP4.
        /// </summary>
        public const string PDPDP4 = "PDPDP4";

        /// <summary>
        /// PDPDP5.
        /// </summary>
        public const string PDPDP5 = "PDPDP5";

        /// <summary>
        /// PDUOM.
        /// </summary>
        public const string PDUOM = "PDUOM";

        /// <summary>
        /// PDUORG.
        /// </summary>
        public const string PDUORG = "PDUORG";

        /// <summary>
        /// PDUCHG.
        /// </summary>
        public const string PDUCHG = "PDUCHG";

        /// <summary>
        /// PDUOPN.
        /// </summary>
        public const string PDUOPN = "PDUOPN";

        /// <summary>
        /// PDUREC.
        /// </summary>
        public const string PDUREC = "PDUREC";

        /// <summary>
        /// PDCREC.
        /// </summary>
        public const string PDCREC = "PDCREC";

        /// <summary>
        /// PDURLV.
        /// </summary>
        public const string PDURLV = "PDURLV";

        /// <summary>
        /// PDOTQY.
        /// </summary>
        public const string PDOTQY = "PDOTQY";

        /// <summary>
        /// PDPRRC.
        /// </summary>
        public const string PDPRRC = "PDPRRC";

        /// <summary>
        /// PDAEXP.
        /// </summary>
        public const string PDAEXP = "PDAEXP";

        /// <summary>
        /// PDACHG.
        /// </summary>
        public const string PDACHG = "PDACHG";

        /// <summary>
        /// PDAOPN.
        /// </summary>
        public const string PDAOPN = "PDAOPN";

        /// <summary>
        /// PDAREC.
        /// </summary>
        public const string PDAREC = "PDAREC";

        /// <summary>
        /// PDARLV.
        /// </summary>
        public const string PDARLV = "PDARLV";

        /// <summary>
        /// PDFTN1.
        /// </summary>
        public const string PDFTN1 = "PDFTN1";

        /// <summary>
        /// PDTRLV.
        /// </summary>
        public const string PDTRLV = "PDTRLV";

        /// <summary>
        /// PDPROV.
        /// </summary>
        public const string PDPROV = "PDPROV";

        /// <summary>
        /// PDAMC3.
        /// </summary>
        public const string PDAMC3 = "PDAMC3";

        /// <summary>
        /// PDECST.
        /// </summary>
        public const string PDECST = "PDECST";

        /// <summary>
        /// PDCSTO.
        /// </summary>
        public const string PDCSTO = "PDCSTO";

        /// <summary>
        /// PDCSMP.
        /// </summary>
        public const string PDCSMP = "PDCSMP";

        /// <summary>
        /// PDINMG.
        /// </summary>
        public const string PDINMG = "PDINMG";

        /// <summary>
        /// PDASN.
        /// </summary>
        public const string PDASN = "PDASN";

        /// <summary>
        /// PDPRGR.
        /// </summary>
        public const string PDPRGR = "PDPRGR";

        /// <summary>
        /// PDCLVL.
        /// </summary>
        public const string PDCLVL = "PDCLVL";

        /// <summary>
        /// PDCATN.
        /// </summary>
        public const string PDCATN = "PDCATN";

        /// <summary>
        /// PDDSPR.
        /// </summary>
        public const string PDDSPR = "PDDSPR";

        /// <summary>
        /// PDPTC.
        /// </summary>
        public const string PDPTC = "PDPTC";

        /// <summary>
        /// PDTX.
        /// </summary>
        public const string PDTX = "PDTX";

        /// <summary>
        /// PDEXR1.
        /// </summary>
        public const string PDEXR1 = "PDEXR1";

        /// <summary>
        /// PDTXA1.
        /// </summary>
        public const string PDTXA1 = "PDTXA1";

        /// <summary>
        /// PDATXT.
        /// </summary>
        public const string PDATXT = "PDATXT";

        /// <summary>
        /// PDCNID.
        /// </summary>
        public const string PDCNID = "PDCNID";

        /// <summary>
        /// PDCDCD.
        /// </summary>
        public const string PDCDCD = "PDCDCD";

        /// <summary>
        /// PDNTR.
        /// </summary>
        public const string PDNTR = "PDNTR";

        /// <summary>
        /// PDFRTH.
        /// </summary>
        public const string PDFRTH = "PDFRTH";

        /// <summary>
        /// PDFRTC.
        /// </summary>
        public const string PDFRTC = "PDFRTC";

        /// <summary>
        /// PDZON.
        /// </summary>
        public const string PDZON = "PDZON";

        /// <summary>
        /// PDFRAT.
        /// </summary>
        public const string PDFRAT = "PDFRAT";

        /// <summary>
        /// PDRATT.
        /// </summary>
        public const string PDRATT = "PDRATT";

        /// <summary>
        /// PDANBY.
        /// </summary>
        public const string PDANBY = "PDANBY";

        /// <summary>
        /// PDANCR.
        /// </summary>
        public const string PDANCR = "PDANCR";

        /// <summary>
        /// PDMOT.
        /// </summary>
        public const string PDMOT = "PDMOT";

        /// <summary>
        /// PDCOT.
        /// </summary>
        public const string PDCOT = "PDCOT";

        /// <summary>
        /// PDSHCM.
        /// </summary>
        public const string PDSHCM = "PDSHCM";

        /// <summary>
        /// PDSHCN.
        /// </summary>
        public const string PDSHCN = "PDSHCN";

        /// <summary>
        /// PDUOM1.
        /// </summary>
        public const string PDUOM1 = "PDUOM1";

        /// <summary>
        /// PDPQOR.
        /// </summary>
        public const string PDPQOR = "PDPQOR";

        /// <summary>
        /// PDUOM2.
        /// </summary>
        public const string PDUOM2 = "PDUOM2";

        /// <summary>
        /// PDSQOR.
        /// </summary>
        public const string PDSQOR = "PDSQOR";

        /// <summary>
        /// PDUOM3.
        /// </summary>
        public const string PDUOM3 = "PDUOM3";

        /// <summary>
        /// PDITWT.
        /// </summary>
        public const string PDITWT = "PDITWT";

        /// <summary>
        /// PDWTUM.
        /// </summary>
        public const string PDWTUM = "PDWTUM";

        /// <summary>
        /// PDITVL.
        /// </summary>
        public const string PDITVL = "PDITVL";

        /// <summary>
        /// PDVLUM.
        /// </summary>
        public const string PDVLUM = "PDVLUM";

        /// <summary>
        /// PDGLC.
        /// </summary>
        public const string PDGLC = "PDGLC";

        /// <summary>
        /// PDCTRY.
        /// </summary>
        public const string PDCTRY = "PDCTRY";

        /// <summary>
        /// PDFY.
        /// </summary>
        public const string PDFY = "PDFY";

        /// <summary>
        /// PDSTTS.
        /// </summary>
        public const string PDSTTS = "PDSTTS";

        /// <summary>
        /// PDRCD.
        /// </summary>
        public const string PDRCD = "PDRCD";

        /// <summary>
        /// PDFUF1.
        /// </summary>
        public const string PDFUF1 = "PDFUF1";

        /// <summary>
        /// PDFUF2.
        /// </summary>
        public const string PDFUF2 = "PDFUF2";

        /// <summary>
        /// PDGRWT.
        /// </summary>
        public const string PDGRWT = "PDGRWT";

        /// <summary>
        /// PDGWUM.
        /// </summary>
        public const string PDGWUM = "PDGWUM";

        /// <summary>
        /// PDLT.
        /// </summary>
        public const string PDLT = "PDLT";

        /// <summary>
        /// PDANI.
        /// </summary>
        public const string PDANI = "PDANI";

        /// <summary>
        /// PDAID.
        /// </summary>
        public const string PDAID = "PDAID";

        /// <summary>
        /// PDOMCU.
        /// </summary>
        public const string PDOMCU = "PDOMCU";

        /// <summary>
        /// PDOBJ.
        /// </summary>
        public const string PDOBJ = "PDOBJ";

        /// <summary>
        /// PDSUB.
        /// </summary>
        public const string PDSUB = "PDSUB";

        /// <summary>
        /// PDSBLT.
        /// </summary>
        public const string PDSBLT = "PDSBLT";

        /// <summary>
        /// PDSBL.
        /// </summary>
        public const string PDSBL = "PDSBL";

        /// <summary>
        /// PDASID.
        /// </summary>
        public const string PDASID = "PDASID";

        /// <summary>
        /// PDCCMP.
        /// </summary>
        public const string PDCCMP = "PDCCMP";

        /// <summary>
        /// PDTAG.
        /// </summary>
        public const string PDTAG = "PDTAG";

        /// <summary>
        /// PDWR01.
        /// </summary>
        public const string PDWR01 = "PDWR01";

        /// <summary>
        /// PDPL.
        /// </summary>
        public const string PDPL = "PDPL";

        /// <summary>
        /// PDELEV.
        /// </summary>
        public const string PDELEV = "PDELEV";

        /// <summary>
        /// PDR001.
        /// </summary>
        public const string PDR001 = "PDR001";

        /// <summary>
        /// PDRTNR.
        /// </summary>
        public const string PDRTNR = "PDRTNR";

        /// <summary>
        /// PDLCOD.
        /// </summary>
        public const string PDLCOD = "PDLCOD";

        /// <summary>
        /// PDPURG.
        /// </summary>
        public const string PDPURG = "PDPURG";

        /// <summary>
        /// PDPROM.
        /// </summary>
        public const string PDPROM = "PDPROM";

        /// <summary>
        /// PDFNLP.
        /// </summary>
        public const string PDFNLP = "PDFNLP";

        /// <summary>
        /// PDAVCH.
        /// </summary>
        public const string PDAVCH = "PDAVCH";

        /// <summary>
        /// PDPRPY.
        /// </summary>
        public const string PDPRPY = "PDPRPY";

        /// <summary>
        /// PDUNCD.
        /// </summary>
        public const string PDUNCD = "PDUNCD";

        /// <summary>
        /// PDMATY.
        /// </summary>
        public const string PDMATY = "PDMATY";

        /// <summary>
        /// PDRTGC.
        /// </summary>
        public const string PDRTGC = "PDRTGC";

        /// <summary>
        /// PDRCPF.
        /// </summary>
        public const string PDRCPF = "PDRCPF";

        /// <summary>
        /// PDPS01.
        /// </summary>
        public const string PDPS01 = "PDPS01";

        /// <summary>
        /// PDPS02.
        /// </summary>
        public const string PDPS02 = "PDPS02";

        /// <summary>
        /// PDPS03.
        /// </summary>
        public const string PDPS03 = "PDPS03";

        /// <summary>
        /// PDPS04.
        /// </summary>
        public const string PDPS04 = "PDPS04";

        /// <summary>
        /// PDPS05.
        /// </summary>
        public const string PDPS05 = "PDPS05";

        /// <summary>
        /// PDPS06.
        /// </summary>
        public const string PDPS06 = "PDPS06";

        /// <summary>
        /// PDPS07.
        /// </summary>
        public const string PDPS07 = "PDPS07";

        /// <summary>
        /// PDPS08.
        /// </summary>
        public const string PDPS08 = "PDPS08";

        /// <summary>
        /// PDPS09.
        /// </summary>
        public const string PDPS09 = "PDPS09";

        /// <summary>
        /// PDPS10.
        /// </summary>
        public const string PDPS10 = "PDPS10";

        /// <summary>
        /// PDCRMD.
        /// </summary>
        public const string PDCRMD = "PDCRMD";

        /// <summary>
        /// PDARTG.
        /// </summary>
        public const string PDARTG = "PDARTG";

        /// <summary>
        /// PDCORD.
        /// </summary>
        public const string PDCORD = "PDCORD";

        /// <summary>
        /// PDCHDT.
        /// </summary>
        public const string PDCHDT = "PDCHDT";

        /// <summary>
        /// PDDOCC.
        /// </summary>
        public const string PDDOCC = "PDDOCC";

        /// <summary>
        /// PDCHLN.
        /// </summary>
        public const string PDCHLN = "PDCHLN";

        /// <summary>
        /// PDCRCD.
        /// </summary>
        public const string PDCRCD = "PDCRCD";

        /// <summary>
        /// PDCRR.
        /// </summary>
        public const string PDCRR = "PDCRR";

        /// <summary>
        /// PDFRRC.
        /// </summary>
        public const string PDFRRC = "PDFRRC";

        /// <summary>
        /// PDFEA.
        /// </summary>
        public const string PDFEA = "PDFEA";

        /// <summary>
        /// PDFUC.
        /// </summary>
        public const string PDFUC = "PDFUC";

        /// <summary>
        /// PDFEC.
        /// </summary>
        public const string PDFEC = "PDFEC";

        /// <summary>
        /// PDFCHG.
        /// </summary>
        public const string PDFCHG = "PDFCHG";

        /// <summary>
        /// PDFAP.
        /// </summary>
        public const string PDFAP = "PDFAP";

        /// <summary>
        /// PDFREC.
        /// </summary>
        public const string PDFREC = "PDFREC";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDTORG.
        /// </summary>
        public const string PDTORG = "PDTORG";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";

        /// <summary>
        /// PDVR05.
        /// </summary>
        public const string PDVR05 = "PDVR05";

        /// <summary>
        /// PDVR04.
        /// </summary>
        public const string PDVR04 = "PDVR04";

        /// <summary>
        /// PDSHPN.
        /// </summary>
        public const string PDSHPN = "PDSHPN";

        /// <summary>
        /// PDRSHT.
        /// </summary>
        public const string PDRSHT = "PDRSHT";

        /// <summary>
        /// PDPRJM.
        /// </summary>
        public const string PDPRJM = "PDPRJM";

        /// <summary>
        /// PDOSFX.
        /// </summary>
        public const string PDOSFX = "PDOSFX";

        /// <summary>
        /// PDMERL.
        /// </summary>
        public const string PDMERL = "PDMERL";

        /// <summary>
        /// PDMCLN.
        /// </summary>
        public const string PDMCLN = "PDMCLN";

        /// <summary>
        /// PDMACT.
        /// </summary>
        public const string PDMACT = "PDMACT";

        /// <summary>
        /// PDKTLN.
        /// </summary>
        public const string PDKTLN = "PDKTLN";

        /// <summary>
        /// PDFTRL.
        /// </summary>
        public const string PDFTRL = "PDFTRL";

        /// <summary>
        /// PDDUAL.
        /// </summary>
        public const string PDDUAL = "PDDUAL";

        /// <summary>
        /// PDDRQT.
        /// </summary>
        public const string PDDRQT = "PDDRQT";

        /// <summary>
        /// PDDLEJ.
        /// </summary>
        public const string PDDLEJ = "PDDLEJ";

        /// <summary>
        /// PDCTAM.
        /// </summary>
        public const string PDCTAM = "PDCTAM";

        /// <summary>
        /// PDCPNT.
        /// </summary>
        public const string PDCPNT = "PDCPNT";

        /// <summary>
        /// PDCHT.
        /// </summary>
        public const string PDCHT = "PDCHT";

        /// <summary>
        /// PDCHRT.
        /// </summary>
        public const string PDCHRT = "PDCHRT";

        /// <summary>
        /// PDCHRS.
        /// </summary>
        public const string PDCHRS = "PDCHRS";

        /// <summary>
        /// PDCHMJ.
        /// </summary>
        public const string PDCHMJ = "PDCHMJ";

        /// <summary>
        /// PDBCRC.
        /// </summary>
        public const string PDBCRC = "PDBCRC";

        /// <summary>
        /// PDVR03.
        /// </summary>
        public const string PDVR03 = "PDVR03";

        /// <summary>
        /// PDLDNM.
        /// </summary>
        public const string PDLDNM = "PDLDNM";

        /// <summary>
        /// PDMKFR.
        /// </summary>
        public const string PDMKFR = "PDMKFR";

        /// <summary>
        /// PDPMTN.
        /// </summary>
        public const string PDPMTN = "PDPMTN";

        /// <summary>
        /// PDUKID.
        /// </summary>
        public const string PDUKID = "PDUKID";

        /// <summary>
        /// PDUNSPSC.
        /// </summary>
        public const string PDUNSPSC = "PDUNSPSC";

        /// <summary>
        /// PDCMDCDE.
        /// </summary>
        public const string PDCMDCDE = "PDCMDCDE";

        /// <summary>
        /// PDRSFX.
        /// </summary>
        public const string PDRSFX = "PDRSFX";

        /// <summary>
        /// PDWVID.
        /// </summary>
        public const string PDWVID = "PDWVID";

        /// <summary>
        /// PDCNTRTID.
        /// </summary>
        public const string PDCNTRTID = "PDCNTRTID";

        /// <summary>
        /// PDCNTRTDID.
        /// </summary>
        public const string PDCNTRTDID = "PDCNTRTDID";

        /// <summary>
        /// PDMOADJ.
        /// </summary>
        public const string PDMOADJ = "PDMOADJ";

        /// <summary>
        /// PDPODC01.
        /// </summary>
        public const string PDPODC01 = "PDPODC01";

        /// <summary>
        /// PDPODC02.
        /// </summary>
        public const string PDPODC02 = "PDPODC02";

        /// <summary>
        /// PDPODC03.
        /// </summary>
        public const string PDPODC03 = "PDPODC03";

        /// <summary>
        /// PDPODC04.
        /// </summary>
        public const string PDPODC04 = "PDPODC04";

        /// <summary>
        /// PDJBCD.
        /// </summary>
        public const string PDJBCD = "PDJBCD";

        /// <summary>
        /// PDSRQTY.
        /// </summary>
        public const string PDSRQTY = "PDSRQTY";

        /// <summary>
        /// PDSRUOM.
        /// </summary>
        public const string PDSRUOM = "PDSRUOM";

        /// <summary>
        /// PDCFGFL.
        /// </summary>
        public const string PDCFGFL = "PDCFGFL";

        /// <summary>
        /// PDPMPN.
        /// </summary>
        public const string PDPMPN = "PDPMPN";

        /// <summary>
        /// PDPNS.
        /// </summary>
        public const string PDPNS = "PDPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F4311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDKCOO", "PDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PDDOCO", "PDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDCTO", "PDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PDSFXO", "PDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PDLNID", "PDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDMCU", "PDMCU", JdeDataType.String, 24),
        new JdeField("PDCO", "PDCO", JdeDataType.String, 10),
        new JdeField("PDOKCO", "PDOKCO", JdeDataType.String, 10),
        new JdeField("PDOORN", "PDOORN", JdeDataType.String, 16),
        new JdeField("PDOCTO", "PDOCTO", JdeDataType.String, 4),
        new JdeField("PDOGNO", "PDOGNO", JdeDataType.Numeric),
        new JdeField("PDRKCO", "PDRKCO", JdeDataType.String, 10),
        new JdeField("PDRORN", "PDRORN", JdeDataType.String, 16),
        new JdeField("PDRCTO", "PDRCTO", JdeDataType.String, 4),
        new JdeField("PDRLLN", "PDRLLN", JdeDataType.Numeric),
        new JdeField("PDDMCT", "PDDMCT", JdeDataType.String, 24),
        new JdeField("PDDMCS", "PDDMCS", JdeDataType.Numeric),
        new JdeField("PDBALU", "PDBALU", JdeDataType.String, 2),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric),
        new JdeField("PDSHAN", "PDSHAN", JdeDataType.Numeric),
        new JdeField("PDDRQJ", "PDDRQJ", JdeDataType.Numeric),
        new JdeField("PDTRDJ", "PDTRDJ", JdeDataType.Numeric),
        new JdeField("PDPDDJ", "PDPDDJ", JdeDataType.Numeric),
        new JdeField("PDOPDJ", "PDOPDJ", JdeDataType.Numeric),
        new JdeField("PDADDJ", "PDADDJ", JdeDataType.Numeric),
        new JdeField("PDCNDJ", "PDCNDJ", JdeDataType.Numeric),
        new JdeField("PDPEFJ", "PDPEFJ", JdeDataType.Numeric),
        new JdeField("PDPPDJ", "PDPPDJ", JdeDataType.Numeric),
        new JdeField("PDPSDJ", "PDPSDJ", JdeDataType.Numeric),
        new JdeField("PDDSVJ", "PDDSVJ", JdeDataType.Numeric),
        new JdeField("PDDGL", "PDDGL", JdeDataType.Numeric),
        new JdeField("PDPN", "PDPN", JdeDataType.Numeric),
        new JdeField("PDVR01", "PDVR01", JdeDataType.String, 50),
        new JdeField("PDVR02", "PDVR02", JdeDataType.String, 50),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric),
        new JdeField("PDLITM", "PDLITM", JdeDataType.String, 50),
        new JdeField("PDAITM", "PDAITM", JdeDataType.String, 50),
        new JdeField("PDLOCN", "PDLOCN", JdeDataType.String, 40),
        new JdeField("PDLOTN", "PDLOTN", JdeDataType.String, 60),
        new JdeField("PDFRGD", "PDFRGD", JdeDataType.String, 6),
        new JdeField("PDTHGD", "PDTHGD", JdeDataType.String, 6),
        new JdeField("PDFRMP", "PDFRMP", JdeDataType.Numeric),
        new JdeField("PDTHRP", "PDTHRP", JdeDataType.Numeric),
        new JdeField("PDDSC1", "PDDSC1", JdeDataType.String, 60),
        new JdeField("PDDSC2", "PDDSC2", JdeDataType.String, 60),
        new JdeField("PDLNTY", "PDLNTY", JdeDataType.String, 4),
        new JdeField("PDNXTR", "PDNXTR", JdeDataType.String, 6),
        new JdeField("PDLTTR", "PDLTTR", JdeDataType.String, 6),
        new JdeField("PDRLIT", "PDRLIT", JdeDataType.String, 16),
        new JdeField("PDPDS1", "PDPDS1", JdeDataType.String, 6),
        new JdeField("PDPDS2", "PDPDS2", JdeDataType.String, 6),
        new JdeField("PDPDS3", "PDPDS3", JdeDataType.String, 6),
        new JdeField("PDPDS4", "PDPDS4", JdeDataType.String, 6),
        new JdeField("PDPDS5", "PDPDS5", JdeDataType.String, 6),
        new JdeField("PDPDP1", "PDPDP1", JdeDataType.String, 6),
        new JdeField("PDPDP2", "PDPDP2", JdeDataType.String, 6),
        new JdeField("PDPDP3", "PDPDP3", JdeDataType.String, 6),
        new JdeField("PDPDP4", "PDPDP4", JdeDataType.String, 6),
        new JdeField("PDPDP5", "PDPDP5", JdeDataType.String, 6),
        new JdeField("PDUOM", "PDUOM", JdeDataType.String, 4),
        new JdeField("PDUORG", "PDUORG", JdeDataType.Numeric),
        new JdeField("PDUCHG", "PDUCHG", JdeDataType.Numeric),
        new JdeField("PDUOPN", "PDUOPN", JdeDataType.Numeric),
        new JdeField("PDUREC", "PDUREC", JdeDataType.Numeric),
        new JdeField("PDCREC", "PDCREC", JdeDataType.Numeric),
        new JdeField("PDURLV", "PDURLV", JdeDataType.Numeric),
        new JdeField("PDOTQY", "PDOTQY", JdeDataType.String, 2),
        new JdeField("PDPRRC", "PDPRRC", JdeDataType.Numeric),
        new JdeField("PDAEXP", "PDAEXP", JdeDataType.Numeric),
        new JdeField("PDACHG", "PDACHG", JdeDataType.Numeric),
        new JdeField("PDAOPN", "PDAOPN", JdeDataType.Numeric),
        new JdeField("PDAREC", "PDAREC", JdeDataType.Numeric),
        new JdeField("PDARLV", "PDARLV", JdeDataType.Numeric),
        new JdeField("PDFTN1", "PDFTN1", JdeDataType.Numeric),
        new JdeField("PDTRLV", "PDTRLV", JdeDataType.Numeric),
        new JdeField("PDPROV", "PDPROV", JdeDataType.String, 2),
        new JdeField("PDAMC3", "PDAMC3", JdeDataType.Numeric),
        new JdeField("PDECST", "PDECST", JdeDataType.Numeric),
        new JdeField("PDCSTO", "PDCSTO", JdeDataType.String, 2),
        new JdeField("PDCSMP", "PDCSMP", JdeDataType.String, 2),
        new JdeField("PDINMG", "PDINMG", JdeDataType.String, 20),
        new JdeField("PDASN", "PDASN", JdeDataType.String, 16),
        new JdeField("PDPRGR", "PDPRGR", JdeDataType.String, 16),
        new JdeField("PDCLVL", "PDCLVL", JdeDataType.String, 6),
        new JdeField("PDCATN", "PDCATN", JdeDataType.String, 16),
        new JdeField("PDDSPR", "PDDSPR", JdeDataType.Numeric),
        new JdeField("PDPTC", "PDPTC", JdeDataType.String, 6),
        new JdeField("PDTX", "PDTX", JdeDataType.String, 2),
        new JdeField("PDEXR1", "PDEXR1", JdeDataType.String, 4),
        new JdeField("PDTXA1", "PDTXA1", JdeDataType.String, 20),
        new JdeField("PDATXT", "PDATXT", JdeDataType.String, 2),
        new JdeField("PDCNID", "PDCNID", JdeDataType.String, 40),
        new JdeField("PDCDCD", "PDCDCD", JdeDataType.String, 30),
        new JdeField("PDNTR", "PDNTR", JdeDataType.String, 4),
        new JdeField("PDFRTH", "PDFRTH", JdeDataType.String, 6),
        new JdeField("PDFRTC", "PDFRTC", JdeDataType.String, 2),
        new JdeField("PDZON", "PDZON", JdeDataType.String, 6),
        new JdeField("PDFRAT", "PDFRAT", JdeDataType.String, 20),
        new JdeField("PDRATT", "PDRATT", JdeDataType.String, 2),
        new JdeField("PDANBY", "PDANBY", JdeDataType.Numeric),
        new JdeField("PDANCR", "PDANCR", JdeDataType.Numeric),
        new JdeField("PDMOT", "PDMOT", JdeDataType.String, 6),
        new JdeField("PDCOT", "PDCOT", JdeDataType.String, 6),
        new JdeField("PDSHCM", "PDSHCM", JdeDataType.String, 6),
        new JdeField("PDSHCN", "PDSHCN", JdeDataType.String, 6),
        new JdeField("PDUOM1", "PDUOM1", JdeDataType.String, 4),
        new JdeField("PDPQOR", "PDPQOR", JdeDataType.Numeric),
        new JdeField("PDUOM2", "PDUOM2", JdeDataType.String, 4),
        new JdeField("PDSQOR", "PDSQOR", JdeDataType.Numeric),
        new JdeField("PDUOM3", "PDUOM3", JdeDataType.String, 4),
        new JdeField("PDITWT", "PDITWT", JdeDataType.Numeric),
        new JdeField("PDWTUM", "PDWTUM", JdeDataType.String, 4),
        new JdeField("PDITVL", "PDITVL", JdeDataType.Numeric),
        new JdeField("PDVLUM", "PDVLUM", JdeDataType.String, 4),
        new JdeField("PDGLC", "PDGLC", JdeDataType.String, 8),
        new JdeField("PDCTRY", "PDCTRY", JdeDataType.Numeric),
        new JdeField("PDFY", "PDFY", JdeDataType.Numeric),
        new JdeField("PDSTTS", "PDSTTS", JdeDataType.String, 4),
        new JdeField("PDRCD", "PDRCD", JdeDataType.String, 6),
        new JdeField("PDFUF1", "PDFUF1", JdeDataType.String, 2),
        new JdeField("PDFUF2", "PDFUF2", JdeDataType.String, 2),
        new JdeField("PDGRWT", "PDGRWT", JdeDataType.Numeric),
        new JdeField("PDGWUM", "PDGWUM", JdeDataType.String, 4),
        new JdeField("PDLT", "PDLT", JdeDataType.String, 4),
        new JdeField("PDANI", "PDANI", JdeDataType.String, 58),
        new JdeField("PDAID", "PDAID", JdeDataType.String, 16),
        new JdeField("PDOMCU", "PDOMCU", JdeDataType.String, 24),
        new JdeField("PDOBJ", "PDOBJ", JdeDataType.String, 12),
        new JdeField("PDSUB", "PDSUB", JdeDataType.String, 16),
        new JdeField("PDSBLT", "PDSBLT", JdeDataType.String, 2),
        new JdeField("PDSBL", "PDSBL", JdeDataType.String, 16),
        new JdeField("PDASID", "PDASID", JdeDataType.String, 50),
        new JdeField("PDCCMP", "PDCCMP", JdeDataType.Numeric),
        new JdeField("PDTAG", "PDTAG", JdeDataType.String, 16),
        new JdeField("PDWR01", "PDWR01", JdeDataType.String, 8),
        new JdeField("PDPL", "PDPL", JdeDataType.String, 8),
        new JdeField("PDELEV", "PDELEV", JdeDataType.String, 6),
        new JdeField("PDR001", "PDR001", JdeDataType.String, 6),
        new JdeField("PDRTNR", "PDRTNR", JdeDataType.String, 6),
        new JdeField("PDLCOD", "PDLCOD", JdeDataType.String, 4),
        new JdeField("PDPURG", "PDPURG", JdeDataType.String, 2),
        new JdeField("PDPROM", "PDPROM", JdeDataType.String, 2),
        new JdeField("PDFNLP", "PDFNLP", JdeDataType.String, 2),
        new JdeField("PDAVCH", "PDAVCH", JdeDataType.String, 2),
        new JdeField("PDPRPY", "PDPRPY", JdeDataType.String, 2),
        new JdeField("PDUNCD", "PDUNCD", JdeDataType.String, 2),
        new JdeField("PDMATY", "PDMATY", JdeDataType.String, 2),
        new JdeField("PDRTGC", "PDRTGC", JdeDataType.String, 2),
        new JdeField("PDRCPF", "PDRCPF", JdeDataType.String, 2),
        new JdeField("PDPS01", "PDPS01", JdeDataType.String, 2),
        new JdeField("PDPS02", "PDPS02", JdeDataType.String, 2),
        new JdeField("PDPS03", "PDPS03", JdeDataType.String, 2),
        new JdeField("PDPS04", "PDPS04", JdeDataType.String, 2),
        new JdeField("PDPS05", "PDPS05", JdeDataType.String, 2),
        new JdeField("PDPS06", "PDPS06", JdeDataType.String, 2),
        new JdeField("PDPS07", "PDPS07", JdeDataType.String, 2),
        new JdeField("PDPS08", "PDPS08", JdeDataType.String, 2),
        new JdeField("PDPS09", "PDPS09", JdeDataType.String, 2),
        new JdeField("PDPS10", "PDPS10", JdeDataType.String, 2),
        new JdeField("PDCRMD", "PDCRMD", JdeDataType.String, 2),
        new JdeField("PDARTG", "PDARTG", JdeDataType.String, 24),
        new JdeField("PDCORD", "PDCORD", JdeDataType.Numeric),
        new JdeField("PDCHDT", "PDCHDT", JdeDataType.String, 4),
        new JdeField("PDDOCC", "PDDOCC", JdeDataType.Numeric),
        new JdeField("PDCHLN", "PDCHLN", JdeDataType.Numeric),
        new JdeField("PDCRCD", "PDCRCD", JdeDataType.String, 6),
        new JdeField("PDCRR", "PDCRR", JdeDataType.Numeric),
        new JdeField("PDFRRC", "PDFRRC", JdeDataType.Numeric),
        new JdeField("PDFEA", "PDFEA", JdeDataType.Numeric),
        new JdeField("PDFUC", "PDFUC", JdeDataType.Numeric),
        new JdeField("PDFEC", "PDFEC", JdeDataType.Numeric),
        new JdeField("PDFCHG", "PDFCHG", JdeDataType.Numeric),
        new JdeField("PDFAP", "PDFAP", JdeDataType.Numeric),
        new JdeField("PDFREC", "PDFREC", JdeDataType.Numeric),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDTORG", "PDTORG", JdeDataType.String, 20),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric),
        new JdeField("PDVR05", "PDVR05", JdeDataType.String, 50),
        new JdeField("PDVR04", "PDVR04", JdeDataType.String, 50),
        new JdeField("PDSHPN", "PDSHPN", JdeDataType.Numeric),
        new JdeField("PDRSHT", "PDRSHT", JdeDataType.Numeric),
        new JdeField("PDPRJM", "PDPRJM", JdeDataType.Numeric),
        new JdeField("PDOSFX", "PDOSFX", JdeDataType.String, 6),
        new JdeField("PDMERL", "PDMERL", JdeDataType.String, 6),
        new JdeField("PDMCLN", "PDMCLN", JdeDataType.Numeric),
        new JdeField("PDMACT", "PDMACT", JdeDataType.String, 2),
        new JdeField("PDKTLN", "PDKTLN", JdeDataType.Numeric),
        new JdeField("PDFTRL", "PDFTRL", JdeDataType.Numeric),
        new JdeField("PDDUAL", "PDDUAL", JdeDataType.String, 2),
        new JdeField("PDDRQT", "PDDRQT", JdeDataType.Numeric),
        new JdeField("PDDLEJ", "PDDLEJ", JdeDataType.Numeric),
        new JdeField("PDCTAM", "PDCTAM", JdeDataType.Numeric),
        new JdeField("PDCPNT", "PDCPNT", JdeDataType.Numeric),
        new JdeField("PDCHT", "PDCHT", JdeDataType.Numeric),
        new JdeField("PDCHRT", "PDCHRT", JdeDataType.Numeric),
        new JdeField("PDCHRS", "PDCHRS", JdeDataType.String, 2),
        new JdeField("PDCHMJ", "PDCHMJ", JdeDataType.Numeric),
        new JdeField("PDBCRC", "PDBCRC", JdeDataType.String, 6),
        new JdeField("PDVR03", "PDVR03", JdeDataType.String, 50),
        new JdeField("PDLDNM", "PDLDNM", JdeDataType.Numeric),
        new JdeField("PDMKFR", "PDMKFR", JdeDataType.Numeric),
        new JdeField("PDPMTN", "PDPMTN", JdeDataType.String, 24),
        new JdeField("PDUKID", "PDUKID", JdeDataType.Numeric),
        new JdeField("PDUNSPSC", "PDUNSPSC", JdeDataType.String, 16),
        new JdeField("PDCMDCDE", "PDCMDCDE", JdeDataType.String, 30),
        new JdeField("PDRSFX", "PDRSFX", JdeDataType.String, 6),
        new JdeField("PDWVID", "PDWVID", JdeDataType.Numeric),
        new JdeField("PDCNTRTID", "PDCNTRTID", JdeDataType.Numeric),
        new JdeField("PDCNTRTDID", "PDCNTRTDID", JdeDataType.Numeric),
        new JdeField("PDMOADJ", "PDMOADJ", JdeDataType.String, 2),
        new JdeField("PDPODC01", "PDPODC01", JdeDataType.String, 6),
        new JdeField("PDPODC02", "PDPODC02", JdeDataType.String, 6),
        new JdeField("PDPODC03", "PDPODC03", JdeDataType.String, 20),
        new JdeField("PDPODC04", "PDPODC04", JdeDataType.String, 20),
        new JdeField("PDJBCD", "PDJBCD", JdeDataType.String, 12),
        new JdeField("PDSRQTY", "PDSRQTY", JdeDataType.Numeric),
        new JdeField("PDSRUOM", "PDSRUOM", JdeDataType.String, 4),
        new JdeField("PDCFGFL", "PDCFGFL", JdeDataType.String, 2),
        new JdeField("PDPMPN", "PDPMPN", JdeDataType.String, 60),
        new JdeField("PDPNS", "PDPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4311_0", "Primary Key on PDDOCO, PDDCTO, PDKCOO, PDSFXO, PDLNID", new[] { "PDDOCO", "PDDCTO", "PDKCOO", "PDSFXO", "PDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4311_10", "Index on PDSBL, PDSBLT", new[] { "PDSBL", "PDSBLT" }),
        new JdeIndex("F4311_11", "Index on PDDOCO, PDDCTO, PDKCOO, PDSHAN, PDSFXO, PDLNID", new[] { "PDDOCO", "PDDCTO", "PDKCOO", "PDSHAN", "PDSFXO", "PDLNID" }),
        new JdeIndex("F4311_12", "Index on PDITM, PDNXTR", new[] { "PDITM", "PDNXTR" }),
        new JdeIndex("F4311_13", "Index on PDSHPN", new[] { "PDSHPN" }),
        new JdeIndex("F4311_14", "Index on PDMCU, PDDCTO, PDDOCO, PDLNID", new[] { "PDMCU", "PDDCTO", "PDDOCO", "PDLNID" }),
        new JdeIndex("F4311_15", "Index on PDUKID, PDDCTO", new[] { "PDUKID", "PDDCTO" }),
        new JdeIndex("F4311_2", "Index on PDDCTO, PDNXTR, PDLNTY", new[] { "PDDCTO", "PDNXTR", "PDLNTY" }),
        new JdeIndex("F4311_3", "Index on PDAN8", new[] { "PDAN8" }),
        new JdeIndex("F4311_4", "Index on PDITM, PDMCU, PDPDDJ", new[] { "PDITM", "PDMCU", "PDPDDJ" }),
        new JdeIndex("F4311_5", "Index on PDITM, PDDCTO, PDDOCO, PDKCOO, PDSFXO, PDLNID", new[] { "PDITM", "PDDCTO", "PDDOCO", "PDKCOO", "PDSFXO", "PDLNID" }),
        new JdeIndex("F4311_6", "Index on PDOORN, PDOCTO, PDOKCO, PDOGNO, PDPDDJ", new[] { "PDOORN", "PDOCTO", "PDOKCO", "PDOGNO", "PDPDDJ" }),
        new JdeIndex("F4311_7", "Index on PDAN8, PDITM, PDUOM, PDCRCD, PDOTQY, PDDCTO, PDDOCO", new[] { "PDAN8", "PDITM", "PDUOM", "PDCRCD", "PDOTQY", "PDDCTO", "PDDOCO" }),
        new JdeIndex("F4311_9", "Index on PDAID, PDDCTO, PDDOCO, PDKCOO, PDSFXO, PDLNID", new[] { "PDAID", "PDDCTO", "PDDOCO", "PDKCOO", "PDSFXO", "PDLNID" })
    };
}
