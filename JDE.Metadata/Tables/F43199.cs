using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43199 - .
/// </summary>
public class F43199 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OLKCOO.
        /// </summary>
        public const string OLKCOO = "OLKCOO";

        /// <summary>
        /// OLDOCO.
        /// </summary>
        public const string OLDOCO = "OLDOCO";

        /// <summary>
        /// OLDCTO.
        /// </summary>
        public const string OLDCTO = "OLDCTO";

        /// <summary>
        /// OLSFXO.
        /// </summary>
        public const string OLSFXO = "OLSFXO";

        /// <summary>
        /// OLLNID.
        /// </summary>
        public const string OLLNID = "OLLNID";

        /// <summary>
        /// OLMCU.
        /// </summary>
        public const string OLMCU = "OLMCU";

        /// <summary>
        /// OLCO.
        /// </summary>
        public const string OLCO = "OLCO";

        /// <summary>
        /// OLOKCO.
        /// </summary>
        public const string OLOKCO = "OLOKCO";

        /// <summary>
        /// OLOORN.
        /// </summary>
        public const string OLOORN = "OLOORN";

        /// <summary>
        /// OLOCTO.
        /// </summary>
        public const string OLOCTO = "OLOCTO";

        /// <summary>
        /// OLOGNO.
        /// </summary>
        public const string OLOGNO = "OLOGNO";

        /// <summary>
        /// OLRKCO.
        /// </summary>
        public const string OLRKCO = "OLRKCO";

        /// <summary>
        /// OLRORN.
        /// </summary>
        public const string OLRORN = "OLRORN";

        /// <summary>
        /// OLRCTO.
        /// </summary>
        public const string OLRCTO = "OLRCTO";

        /// <summary>
        /// OLRLLN.
        /// </summary>
        public const string OLRLLN = "OLRLLN";

        /// <summary>
        /// OLDMCT.
        /// </summary>
        public const string OLDMCT = "OLDMCT";

        /// <summary>
        /// OLDMCS.
        /// </summary>
        public const string OLDMCS = "OLDMCS";

        /// <summary>
        /// OLBALU.
        /// </summary>
        public const string OLBALU = "OLBALU";

        /// <summary>
        /// OLAN8.
        /// </summary>
        public const string OLAN8 = "OLAN8";

        /// <summary>
        /// OLSHAN.
        /// </summary>
        public const string OLSHAN = "OLSHAN";

        /// <summary>
        /// OLDRQJ.
        /// </summary>
        public const string OLDRQJ = "OLDRQJ";

        /// <summary>
        /// OLTRDJ.
        /// </summary>
        public const string OLTRDJ = "OLTRDJ";

        /// <summary>
        /// OLPDDJ.
        /// </summary>
        public const string OLPDDJ = "OLPDDJ";

        /// <summary>
        /// OLOPDJ.
        /// </summary>
        public const string OLOPDJ = "OLOPDJ";

        /// <summary>
        /// OLADDJ.
        /// </summary>
        public const string OLADDJ = "OLADDJ";

        /// <summary>
        /// OLCNDJ.
        /// </summary>
        public const string OLCNDJ = "OLCNDJ";

        /// <summary>
        /// OLPEFJ.
        /// </summary>
        public const string OLPEFJ = "OLPEFJ";

        /// <summary>
        /// OLPPDJ.
        /// </summary>
        public const string OLPPDJ = "OLPPDJ";

        /// <summary>
        /// OLPSDJ.
        /// </summary>
        public const string OLPSDJ = "OLPSDJ";

        /// <summary>
        /// OLDSVJ.
        /// </summary>
        public const string OLDSVJ = "OLDSVJ";

        /// <summary>
        /// OLDGL.
        /// </summary>
        public const string OLDGL = "OLDGL";

        /// <summary>
        /// OLPN.
        /// </summary>
        public const string OLPN = "OLPN";

        /// <summary>
        /// OLVR01.
        /// </summary>
        public const string OLVR01 = "OLVR01";

        /// <summary>
        /// OLVR02.
        /// </summary>
        public const string OLVR02 = "OLVR02";

        /// <summary>
        /// OLITM.
        /// </summary>
        public const string OLITM = "OLITM";

        /// <summary>
        /// OLLITM.
        /// </summary>
        public const string OLLITM = "OLLITM";

        /// <summary>
        /// OLAITM.
        /// </summary>
        public const string OLAITM = "OLAITM";

        /// <summary>
        /// OLLOCN.
        /// </summary>
        public const string OLLOCN = "OLLOCN";

        /// <summary>
        /// OLLOTN.
        /// </summary>
        public const string OLLOTN = "OLLOTN";

        /// <summary>
        /// OLFRGD.
        /// </summary>
        public const string OLFRGD = "OLFRGD";

        /// <summary>
        /// OLTHGD.
        /// </summary>
        public const string OLTHGD = "OLTHGD";

        /// <summary>
        /// OLFRMP.
        /// </summary>
        public const string OLFRMP = "OLFRMP";

        /// <summary>
        /// OLTHRP.
        /// </summary>
        public const string OLTHRP = "OLTHRP";

        /// <summary>
        /// OLDSC1.
        /// </summary>
        public const string OLDSC1 = "OLDSC1";

        /// <summary>
        /// OLDSC2.
        /// </summary>
        public const string OLDSC2 = "OLDSC2";

        /// <summary>
        /// OLLNTY.
        /// </summary>
        public const string OLLNTY = "OLLNTY";

        /// <summary>
        /// OLNXTR.
        /// </summary>
        public const string OLNXTR = "OLNXTR";

        /// <summary>
        /// OLLTTR.
        /// </summary>
        public const string OLLTTR = "OLLTTR";

        /// <summary>
        /// OLRLIT.
        /// </summary>
        public const string OLRLIT = "OLRLIT";

        /// <summary>
        /// OLPDS1.
        /// </summary>
        public const string OLPDS1 = "OLPDS1";

        /// <summary>
        /// OLPDS2.
        /// </summary>
        public const string OLPDS2 = "OLPDS2";

        /// <summary>
        /// OLPDS3.
        /// </summary>
        public const string OLPDS3 = "OLPDS3";

        /// <summary>
        /// OLPDS4.
        /// </summary>
        public const string OLPDS4 = "OLPDS4";

        /// <summary>
        /// OLPDS5.
        /// </summary>
        public const string OLPDS5 = "OLPDS5";

        /// <summary>
        /// OLPDP1.
        /// </summary>
        public const string OLPDP1 = "OLPDP1";

        /// <summary>
        /// OLPDP2.
        /// </summary>
        public const string OLPDP2 = "OLPDP2";

        /// <summary>
        /// OLPDP3.
        /// </summary>
        public const string OLPDP3 = "OLPDP3";

        /// <summary>
        /// OLPDP4.
        /// </summary>
        public const string OLPDP4 = "OLPDP4";

        /// <summary>
        /// OLPDP5.
        /// </summary>
        public const string OLPDP5 = "OLPDP5";

        /// <summary>
        /// OLUOM.
        /// </summary>
        public const string OLUOM = "OLUOM";

        /// <summary>
        /// OLUORG.
        /// </summary>
        public const string OLUORG = "OLUORG";

        /// <summary>
        /// OLUCHG.
        /// </summary>
        public const string OLUCHG = "OLUCHG";

        /// <summary>
        /// OLUOPN.
        /// </summary>
        public const string OLUOPN = "OLUOPN";

        /// <summary>
        /// OLUREC.
        /// </summary>
        public const string OLUREC = "OLUREC";

        /// <summary>
        /// OLCREC.
        /// </summary>
        public const string OLCREC = "OLCREC";

        /// <summary>
        /// OLURLV.
        /// </summary>
        public const string OLURLV = "OLURLV";

        /// <summary>
        /// OLOTQY.
        /// </summary>
        public const string OLOTQY = "OLOTQY";

        /// <summary>
        /// OLPRRC.
        /// </summary>
        public const string OLPRRC = "OLPRRC";

        /// <summary>
        /// OLAEXP.
        /// </summary>
        public const string OLAEXP = "OLAEXP";

        /// <summary>
        /// OLACHG.
        /// </summary>
        public const string OLACHG = "OLACHG";

        /// <summary>
        /// OLAOPN.
        /// </summary>
        public const string OLAOPN = "OLAOPN";

        /// <summary>
        /// OLAREC.
        /// </summary>
        public const string OLAREC = "OLAREC";

        /// <summary>
        /// OLARLV.
        /// </summary>
        public const string OLARLV = "OLARLV";

        /// <summary>
        /// OLFTN1.
        /// </summary>
        public const string OLFTN1 = "OLFTN1";

        /// <summary>
        /// OLTRLV.
        /// </summary>
        public const string OLTRLV = "OLTRLV";

        /// <summary>
        /// OLPROV.
        /// </summary>
        public const string OLPROV = "OLPROV";

        /// <summary>
        /// OLAMC3.
        /// </summary>
        public const string OLAMC3 = "OLAMC3";

        /// <summary>
        /// OLECST.
        /// </summary>
        public const string OLECST = "OLECST";

        /// <summary>
        /// OLCSTO.
        /// </summary>
        public const string OLCSTO = "OLCSTO";

        /// <summary>
        /// OLCSMP.
        /// </summary>
        public const string OLCSMP = "OLCSMP";

        /// <summary>
        /// OLINMG.
        /// </summary>
        public const string OLINMG = "OLINMG";

        /// <summary>
        /// OLASN.
        /// </summary>
        public const string OLASN = "OLASN";

        /// <summary>
        /// OLPRGR.
        /// </summary>
        public const string OLPRGR = "OLPRGR";

        /// <summary>
        /// OLCLVL.
        /// </summary>
        public const string OLCLVL = "OLCLVL";

        /// <summary>
        /// OLCATN.
        /// </summary>
        public const string OLCATN = "OLCATN";

        /// <summary>
        /// OLDSPR.
        /// </summary>
        public const string OLDSPR = "OLDSPR";

        /// <summary>
        /// OLPTC.
        /// </summary>
        public const string OLPTC = "OLPTC";

        /// <summary>
        /// OLTX.
        /// </summary>
        public const string OLTX = "OLTX";

        /// <summary>
        /// OLEXR1.
        /// </summary>
        public const string OLEXR1 = "OLEXR1";

        /// <summary>
        /// OLTXA1.
        /// </summary>
        public const string OLTXA1 = "OLTXA1";

        /// <summary>
        /// OLATXT.
        /// </summary>
        public const string OLATXT = "OLATXT";

        /// <summary>
        /// OLCNID.
        /// </summary>
        public const string OLCNID = "OLCNID";

        /// <summary>
        /// OLCDCD.
        /// </summary>
        public const string OLCDCD = "OLCDCD";

        /// <summary>
        /// OLNTR.
        /// </summary>
        public const string OLNTR = "OLNTR";

        /// <summary>
        /// OLFRTH.
        /// </summary>
        public const string OLFRTH = "OLFRTH";

        /// <summary>
        /// OLFRTC.
        /// </summary>
        public const string OLFRTC = "OLFRTC";

        /// <summary>
        /// OLZON.
        /// </summary>
        public const string OLZON = "OLZON";

        /// <summary>
        /// OLFRAT.
        /// </summary>
        public const string OLFRAT = "OLFRAT";

        /// <summary>
        /// OLRATT.
        /// </summary>
        public const string OLRATT = "OLRATT";

        /// <summary>
        /// OLANBY.
        /// </summary>
        public const string OLANBY = "OLANBY";

        /// <summary>
        /// OLANCR.
        /// </summary>
        public const string OLANCR = "OLANCR";

        /// <summary>
        /// OLMOT.
        /// </summary>
        public const string OLMOT = "OLMOT";

        /// <summary>
        /// OLCOT.
        /// </summary>
        public const string OLCOT = "OLCOT";

        /// <summary>
        /// OLSHCM.
        /// </summary>
        public const string OLSHCM = "OLSHCM";

        /// <summary>
        /// OLSHCN.
        /// </summary>
        public const string OLSHCN = "OLSHCN";

        /// <summary>
        /// OLUOM1.
        /// </summary>
        public const string OLUOM1 = "OLUOM1";

        /// <summary>
        /// OLPQOR.
        /// </summary>
        public const string OLPQOR = "OLPQOR";

        /// <summary>
        /// OLUOM2.
        /// </summary>
        public const string OLUOM2 = "OLUOM2";

        /// <summary>
        /// OLSQOR.
        /// </summary>
        public const string OLSQOR = "OLSQOR";

        /// <summary>
        /// OLUOM3.
        /// </summary>
        public const string OLUOM3 = "OLUOM3";

        /// <summary>
        /// OLITWT.
        /// </summary>
        public const string OLITWT = "OLITWT";

        /// <summary>
        /// OLWTUM.
        /// </summary>
        public const string OLWTUM = "OLWTUM";

        /// <summary>
        /// OLITVL.
        /// </summary>
        public const string OLITVL = "OLITVL";

        /// <summary>
        /// OLVLUM.
        /// </summary>
        public const string OLVLUM = "OLVLUM";

        /// <summary>
        /// OLGLC.
        /// </summary>
        public const string OLGLC = "OLGLC";

        /// <summary>
        /// OLCTRY.
        /// </summary>
        public const string OLCTRY = "OLCTRY";

        /// <summary>
        /// OLFY.
        /// </summary>
        public const string OLFY = "OLFY";

        /// <summary>
        /// OLSTTS.
        /// </summary>
        public const string OLSTTS = "OLSTTS";

        /// <summary>
        /// OLRCD.
        /// </summary>
        public const string OLRCD = "OLRCD";

        /// <summary>
        /// OLFUF1.
        /// </summary>
        public const string OLFUF1 = "OLFUF1";

        /// <summary>
        /// OLFUF2.
        /// </summary>
        public const string OLFUF2 = "OLFUF2";

        /// <summary>
        /// OLGRWT.
        /// </summary>
        public const string OLGRWT = "OLGRWT";

        /// <summary>
        /// OLGWUM.
        /// </summary>
        public const string OLGWUM = "OLGWUM";

        /// <summary>
        /// OLLT.
        /// </summary>
        public const string OLLT = "OLLT";

        /// <summary>
        /// OLANI.
        /// </summary>
        public const string OLANI = "OLANI";

        /// <summary>
        /// OLAID.
        /// </summary>
        public const string OLAID = "OLAID";

        /// <summary>
        /// OLOMCU.
        /// </summary>
        public const string OLOMCU = "OLOMCU";

        /// <summary>
        /// OLOBJ.
        /// </summary>
        public const string OLOBJ = "OLOBJ";

        /// <summary>
        /// OLSUB.
        /// </summary>
        public const string OLSUB = "OLSUB";

        /// <summary>
        /// OLSBLT.
        /// </summary>
        public const string OLSBLT = "OLSBLT";

        /// <summary>
        /// OLSBL.
        /// </summary>
        public const string OLSBL = "OLSBL";

        /// <summary>
        /// OLASID.
        /// </summary>
        public const string OLASID = "OLASID";

        /// <summary>
        /// OLCCMP.
        /// </summary>
        public const string OLCCMP = "OLCCMP";

        /// <summary>
        /// OLTAG.
        /// </summary>
        public const string OLTAG = "OLTAG";

        /// <summary>
        /// OLWR01.
        /// </summary>
        public const string OLWR01 = "OLWR01";

        /// <summary>
        /// OLPL.
        /// </summary>
        public const string OLPL = "OLPL";

        /// <summary>
        /// OLELEV.
        /// </summary>
        public const string OLELEV = "OLELEV";

        /// <summary>
        /// OLR001.
        /// </summary>
        public const string OLR001 = "OLR001";

        /// <summary>
        /// OLRTNR.
        /// </summary>
        public const string OLRTNR = "OLRTNR";

        /// <summary>
        /// OLLCOD.
        /// </summary>
        public const string OLLCOD = "OLLCOD";

        /// <summary>
        /// OLPURG.
        /// </summary>
        public const string OLPURG = "OLPURG";

        /// <summary>
        /// OLPROM.
        /// </summary>
        public const string OLPROM = "OLPROM";

        /// <summary>
        /// OLFNLP.
        /// </summary>
        public const string OLFNLP = "OLFNLP";

        /// <summary>
        /// OLAVCH.
        /// </summary>
        public const string OLAVCH = "OLAVCH";

        /// <summary>
        /// OLPRPY.
        /// </summary>
        public const string OLPRPY = "OLPRPY";

        /// <summary>
        /// OLUNCD.
        /// </summary>
        public const string OLUNCD = "OLUNCD";

        /// <summary>
        /// OLMATY.
        /// </summary>
        public const string OLMATY = "OLMATY";

        /// <summary>
        /// OLRTGC.
        /// </summary>
        public const string OLRTGC = "OLRTGC";

        /// <summary>
        /// OLRCPF.
        /// </summary>
        public const string OLRCPF = "OLRCPF";

        /// <summary>
        /// OLPS01.
        /// </summary>
        public const string OLPS01 = "OLPS01";

        /// <summary>
        /// OLPS02.
        /// </summary>
        public const string OLPS02 = "OLPS02";

        /// <summary>
        /// OLPS03.
        /// </summary>
        public const string OLPS03 = "OLPS03";

        /// <summary>
        /// OLPS04.
        /// </summary>
        public const string OLPS04 = "OLPS04";

        /// <summary>
        /// OLPS05.
        /// </summary>
        public const string OLPS05 = "OLPS05";

        /// <summary>
        /// OLPS06.
        /// </summary>
        public const string OLPS06 = "OLPS06";

        /// <summary>
        /// OLPS07.
        /// </summary>
        public const string OLPS07 = "OLPS07";

        /// <summary>
        /// OLPS08.
        /// </summary>
        public const string OLPS08 = "OLPS08";

        /// <summary>
        /// OLPS09.
        /// </summary>
        public const string OLPS09 = "OLPS09";

        /// <summary>
        /// OLPS10.
        /// </summary>
        public const string OLPS10 = "OLPS10";

        /// <summary>
        /// OLCRMD.
        /// </summary>
        public const string OLCRMD = "OLCRMD";

        /// <summary>
        /// OLARTG.
        /// </summary>
        public const string OLARTG = "OLARTG";

        /// <summary>
        /// OLCORD.
        /// </summary>
        public const string OLCORD = "OLCORD";

        /// <summary>
        /// OLCHDT.
        /// </summary>
        public const string OLCHDT = "OLCHDT";

        /// <summary>
        /// OLDOCC.
        /// </summary>
        public const string OLDOCC = "OLDOCC";

        /// <summary>
        /// OLCHLN.
        /// </summary>
        public const string OLCHLN = "OLCHLN";

        /// <summary>
        /// OLCRCD.
        /// </summary>
        public const string OLCRCD = "OLCRCD";

        /// <summary>
        /// OLCRR.
        /// </summary>
        public const string OLCRR = "OLCRR";

        /// <summary>
        /// OLFRRC.
        /// </summary>
        public const string OLFRRC = "OLFRRC";

        /// <summary>
        /// OLFEA.
        /// </summary>
        public const string OLFEA = "OLFEA";

        /// <summary>
        /// OLFUC.
        /// </summary>
        public const string OLFUC = "OLFUC";

        /// <summary>
        /// OLFEC.
        /// </summary>
        public const string OLFEC = "OLFEC";

        /// <summary>
        /// OLFCHG.
        /// </summary>
        public const string OLFCHG = "OLFCHG";

        /// <summary>
        /// OLFAP.
        /// </summary>
        public const string OLFAP = "OLFAP";

        /// <summary>
        /// OLFREC.
        /// </summary>
        public const string OLFREC = "OLFREC";

        /// <summary>
        /// OLURCD.
        /// </summary>
        public const string OLURCD = "OLURCD";

        /// <summary>
        /// OLURDT.
        /// </summary>
        public const string OLURDT = "OLURDT";

        /// <summary>
        /// OLURAT.
        /// </summary>
        public const string OLURAT = "OLURAT";

        /// <summary>
        /// OLURAB.
        /// </summary>
        public const string OLURAB = "OLURAB";

        /// <summary>
        /// OLURRF.
        /// </summary>
        public const string OLURRF = "OLURRF";

        /// <summary>
        /// OLTORG.
        /// </summary>
        public const string OLTORG = "OLTORG";

        /// <summary>
        /// OLUSER.
        /// </summary>
        public const string OLUSER = "OLUSER";

        /// <summary>
        /// OLPID.
        /// </summary>
        public const string OLPID = "OLPID";

        /// <summary>
        /// OLJOBN.
        /// </summary>
        public const string OLJOBN = "OLJOBN";

        /// <summary>
        /// OLUPMJ.
        /// </summary>
        public const string OLUPMJ = "OLUPMJ";

        /// <summary>
        /// OLTDAY.
        /// </summary>
        public const string OLTDAY = "OLTDAY";

        /// <summary>
        /// OLVR05.
        /// </summary>
        public const string OLVR05 = "OLVR05";

        /// <summary>
        /// OLVR04.
        /// </summary>
        public const string OLVR04 = "OLVR04";

        /// <summary>
        /// OLSHPN.
        /// </summary>
        public const string OLSHPN = "OLSHPN";

        /// <summary>
        /// OLSHMT.
        /// </summary>
        public const string OLSHMT = "OLSHMT";

        /// <summary>
        /// OLRSHT.
        /// </summary>
        public const string OLRSHT = "OLRSHT";

        /// <summary>
        /// OLPRJM.
        /// </summary>
        public const string OLPRJM = "OLPRJM";

        /// <summary>
        /// OLDLEJ.
        /// </summary>
        public const string OLDLEJ = "OLDLEJ";

        /// <summary>
        /// OLOSFX.
        /// </summary>
        public const string OLOSFX = "OLOSFX";

        /// <summary>
        /// OLMERL.
        /// </summary>
        public const string OLMERL = "OLMERL";

        /// <summary>
        /// OLMCLN.
        /// </summary>
        public const string OLMCLN = "OLMCLN";

        /// <summary>
        /// OLMACT.
        /// </summary>
        public const string OLMACT = "OLMACT";

        /// <summary>
        /// OLKTLN.
        /// </summary>
        public const string OLKTLN = "OLKTLN";

        /// <summary>
        /// OLFTRL.
        /// </summary>
        public const string OLFTRL = "OLFTRL";

        /// <summary>
        /// OLDRQT.
        /// </summary>
        public const string OLDRQT = "OLDRQT";

        /// <summary>
        /// OLCTAM.
        /// </summary>
        public const string OLCTAM = "OLCTAM";

        /// <summary>
        /// OLCPNT.
        /// </summary>
        public const string OLCPNT = "OLCPNT";

        /// <summary>
        /// OLCHT.
        /// </summary>
        public const string OLCHT = "OLCHT";

        /// <summary>
        /// OLPMTN.
        /// </summary>
        public const string OLPMTN = "OLPMTN";

        /// <summary>
        /// OLCHRT.
        /// </summary>
        public const string OLCHRT = "OLCHRT";

        /// <summary>
        /// OLCHRS.
        /// </summary>
        public const string OLCHRS = "OLCHRS";

        /// <summary>
        /// OLCHMJ.
        /// </summary>
        public const string OLCHMJ = "OLCHMJ";

        /// <summary>
        /// OLBCRC.
        /// </summary>
        public const string OLBCRC = "OLBCRC";

        /// <summary>
        /// OLDUAL.
        /// </summary>
        public const string OLDUAL = "OLDUAL";

        /// <summary>
        /// OLUKID.
        /// </summary>
        public const string OLUKID = "OLUKID";

        /// <summary>
        /// OLLDNM.
        /// </summary>
        public const string OLLDNM = "OLLDNM";

        /// <summary>
        /// OLMKFR.
        /// </summary>
        public const string OLMKFR = "OLMKFR";

        /// <summary>
        /// OLMFLG.
        /// </summary>
        public const string OLMFLG = "OLMFLG";

        /// <summary>
        /// OLDLNID.
        /// </summary>
        public const string OLDLNID = "OLDLNID";

        /// <summary>
        /// OLCMDCDE.
        /// </summary>
        public const string OLCMDCDE = "OLCMDCDE";

        /// <summary>
        /// OLUNSPSC.
        /// </summary>
        public const string OLUNSPSC = "OLUNSPSC";

        /// <summary>
        /// OLRSFX.
        /// </summary>
        public const string OLRSFX = "OLRSFX";

        /// <summary>
        /// OLWVID.
        /// </summary>
        public const string OLWVID = "OLWVID";

        /// <summary>
        /// OLCNTRTID.
        /// </summary>
        public const string OLCNTRTID = "OLCNTRTID";

        /// <summary>
        /// OLCNTRTDID.
        /// </summary>
        public const string OLCNTRTDID = "OLCNTRTDID";

        /// <summary>
        /// OLMOADJ.
        /// </summary>
        public const string OLMOADJ = "OLMOADJ";

        /// <summary>
        /// OLPODC01.
        /// </summary>
        public const string OLPODC01 = "OLPODC01";

        /// <summary>
        /// OLPODC02.
        /// </summary>
        public const string OLPODC02 = "OLPODC02";

        /// <summary>
        /// OLPODC03.
        /// </summary>
        public const string OLPODC03 = "OLPODC03";

        /// <summary>
        /// OLPODC04.
        /// </summary>
        public const string OLPODC04 = "OLPODC04";

        /// <summary>
        /// OLJBCD.
        /// </summary>
        public const string OLJBCD = "OLJBCD";

        /// <summary>
        /// OLSRQTY.
        /// </summary>
        public const string OLSRQTY = "OLSRQTY";

        /// <summary>
        /// OLSRUOM.
        /// </summary>
        public const string OLSRUOM = "OLSRUOM";

        /// <summary>
        /// OLCFGFL.
        /// </summary>
        public const string OLCFGFL = "OLCFGFL";

        /// <summary>
        /// OLPMPN.
        /// </summary>
        public const string OLPMPN = "OLPMPN";

        /// <summary>
        /// OLPNS.
        /// </summary>
        public const string OLPNS = "OLPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F43199";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OLKCOO", "OLKCOO", JdeDataType.String, 10),
        new JdeField("OLDOCO", "OLDOCO", JdeDataType.Numeric),
        new JdeField("OLDCTO", "OLDCTO", JdeDataType.String, 4),
        new JdeField("OLSFXO", "OLSFXO", JdeDataType.String, 6),
        new JdeField("OLLNID", "OLLNID", JdeDataType.Numeric),
        new JdeField("OLMCU", "OLMCU", JdeDataType.String, 24),
        new JdeField("OLCO", "OLCO", JdeDataType.String, 10),
        new JdeField("OLOKCO", "OLOKCO", JdeDataType.String, 10),
        new JdeField("OLOORN", "OLOORN", JdeDataType.String, 16),
        new JdeField("OLOCTO", "OLOCTO", JdeDataType.String, 4),
        new JdeField("OLOGNO", "OLOGNO", JdeDataType.Numeric),
        new JdeField("OLRKCO", "OLRKCO", JdeDataType.String, 10),
        new JdeField("OLRORN", "OLRORN", JdeDataType.String, 16),
        new JdeField("OLRCTO", "OLRCTO", JdeDataType.String, 4),
        new JdeField("OLRLLN", "OLRLLN", JdeDataType.Numeric),
        new JdeField("OLDMCT", "OLDMCT", JdeDataType.String, 24),
        new JdeField("OLDMCS", "OLDMCS", JdeDataType.Numeric),
        new JdeField("OLBALU", "OLBALU", JdeDataType.String, 2),
        new JdeField("OLAN8", "OLAN8", JdeDataType.Numeric),
        new JdeField("OLSHAN", "OLSHAN", JdeDataType.Numeric),
        new JdeField("OLDRQJ", "OLDRQJ", JdeDataType.Numeric),
        new JdeField("OLTRDJ", "OLTRDJ", JdeDataType.Numeric),
        new JdeField("OLPDDJ", "OLPDDJ", JdeDataType.Numeric),
        new JdeField("OLOPDJ", "OLOPDJ", JdeDataType.Numeric),
        new JdeField("OLADDJ", "OLADDJ", JdeDataType.Numeric),
        new JdeField("OLCNDJ", "OLCNDJ", JdeDataType.Numeric),
        new JdeField("OLPEFJ", "OLPEFJ", JdeDataType.Numeric),
        new JdeField("OLPPDJ", "OLPPDJ", JdeDataType.Numeric),
        new JdeField("OLPSDJ", "OLPSDJ", JdeDataType.Numeric),
        new JdeField("OLDSVJ", "OLDSVJ", JdeDataType.Numeric),
        new JdeField("OLDGL", "OLDGL", JdeDataType.Numeric),
        new JdeField("OLPN", "OLPN", JdeDataType.Numeric),
        new JdeField("OLVR01", "OLVR01", JdeDataType.String, 50),
        new JdeField("OLVR02", "OLVR02", JdeDataType.String, 50),
        new JdeField("OLITM", "OLITM", JdeDataType.Numeric),
        new JdeField("OLLITM", "OLLITM", JdeDataType.String, 50),
        new JdeField("OLAITM", "OLAITM", JdeDataType.String, 50),
        new JdeField("OLLOCN", "OLLOCN", JdeDataType.String, 40),
        new JdeField("OLLOTN", "OLLOTN", JdeDataType.String, 60),
        new JdeField("OLFRGD", "OLFRGD", JdeDataType.String, 6),
        new JdeField("OLTHGD", "OLTHGD", JdeDataType.String, 6),
        new JdeField("OLFRMP", "OLFRMP", JdeDataType.Numeric),
        new JdeField("OLTHRP", "OLTHRP", JdeDataType.Numeric),
        new JdeField("OLDSC1", "OLDSC1", JdeDataType.String, 60),
        new JdeField("OLDSC2", "OLDSC2", JdeDataType.String, 60),
        new JdeField("OLLNTY", "OLLNTY", JdeDataType.String, 4),
        new JdeField("OLNXTR", "OLNXTR", JdeDataType.String, 6),
        new JdeField("OLLTTR", "OLLTTR", JdeDataType.String, 6),
        new JdeField("OLRLIT", "OLRLIT", JdeDataType.String, 16),
        new JdeField("OLPDS1", "OLPDS1", JdeDataType.String, 6),
        new JdeField("OLPDS2", "OLPDS2", JdeDataType.String, 6),
        new JdeField("OLPDS3", "OLPDS3", JdeDataType.String, 6),
        new JdeField("OLPDS4", "OLPDS4", JdeDataType.String, 6),
        new JdeField("OLPDS5", "OLPDS5", JdeDataType.String, 6),
        new JdeField("OLPDP1", "OLPDP1", JdeDataType.String, 6),
        new JdeField("OLPDP2", "OLPDP2", JdeDataType.String, 6),
        new JdeField("OLPDP3", "OLPDP3", JdeDataType.String, 6),
        new JdeField("OLPDP4", "OLPDP4", JdeDataType.String, 6),
        new JdeField("OLPDP5", "OLPDP5", JdeDataType.String, 6),
        new JdeField("OLUOM", "OLUOM", JdeDataType.String, 4),
        new JdeField("OLUORG", "OLUORG", JdeDataType.Numeric),
        new JdeField("OLUCHG", "OLUCHG", JdeDataType.Numeric),
        new JdeField("OLUOPN", "OLUOPN", JdeDataType.Numeric),
        new JdeField("OLUREC", "OLUREC", JdeDataType.Numeric),
        new JdeField("OLCREC", "OLCREC", JdeDataType.Numeric),
        new JdeField("OLURLV", "OLURLV", JdeDataType.Numeric),
        new JdeField("OLOTQY", "OLOTQY", JdeDataType.String, 2),
        new JdeField("OLPRRC", "OLPRRC", JdeDataType.Numeric),
        new JdeField("OLAEXP", "OLAEXP", JdeDataType.Numeric),
        new JdeField("OLACHG", "OLACHG", JdeDataType.Numeric),
        new JdeField("OLAOPN", "OLAOPN", JdeDataType.Numeric),
        new JdeField("OLAREC", "OLAREC", JdeDataType.Numeric),
        new JdeField("OLARLV", "OLARLV", JdeDataType.Numeric),
        new JdeField("OLFTN1", "OLFTN1", JdeDataType.Numeric),
        new JdeField("OLTRLV", "OLTRLV", JdeDataType.Numeric),
        new JdeField("OLPROV", "OLPROV", JdeDataType.String, 2),
        new JdeField("OLAMC3", "OLAMC3", JdeDataType.Numeric),
        new JdeField("OLECST", "OLECST", JdeDataType.Numeric),
        new JdeField("OLCSTO", "OLCSTO", JdeDataType.String, 2),
        new JdeField("OLCSMP", "OLCSMP", JdeDataType.String, 2),
        new JdeField("OLINMG", "OLINMG", JdeDataType.String, 20),
        new JdeField("OLASN", "OLASN", JdeDataType.String, 16),
        new JdeField("OLPRGR", "OLPRGR", JdeDataType.String, 16),
        new JdeField("OLCLVL", "OLCLVL", JdeDataType.String, 6),
        new JdeField("OLCATN", "OLCATN", JdeDataType.String, 16),
        new JdeField("OLDSPR", "OLDSPR", JdeDataType.Numeric),
        new JdeField("OLPTC", "OLPTC", JdeDataType.String, 6),
        new JdeField("OLTX", "OLTX", JdeDataType.String, 2),
        new JdeField("OLEXR1", "OLEXR1", JdeDataType.String, 4),
        new JdeField("OLTXA1", "OLTXA1", JdeDataType.String, 20),
        new JdeField("OLATXT", "OLATXT", JdeDataType.String, 2),
        new JdeField("OLCNID", "OLCNID", JdeDataType.String, 40),
        new JdeField("OLCDCD", "OLCDCD", JdeDataType.String, 30),
        new JdeField("OLNTR", "OLNTR", JdeDataType.String, 4),
        new JdeField("OLFRTH", "OLFRTH", JdeDataType.String, 6),
        new JdeField("OLFRTC", "OLFRTC", JdeDataType.String, 2),
        new JdeField("OLZON", "OLZON", JdeDataType.String, 6),
        new JdeField("OLFRAT", "OLFRAT", JdeDataType.String, 20),
        new JdeField("OLRATT", "OLRATT", JdeDataType.String, 2),
        new JdeField("OLANBY", "OLANBY", JdeDataType.Numeric),
        new JdeField("OLANCR", "OLANCR", JdeDataType.Numeric),
        new JdeField("OLMOT", "OLMOT", JdeDataType.String, 6),
        new JdeField("OLCOT", "OLCOT", JdeDataType.String, 6),
        new JdeField("OLSHCM", "OLSHCM", JdeDataType.String, 6),
        new JdeField("OLSHCN", "OLSHCN", JdeDataType.String, 6),
        new JdeField("OLUOM1", "OLUOM1", JdeDataType.String, 4),
        new JdeField("OLPQOR", "OLPQOR", JdeDataType.Numeric),
        new JdeField("OLUOM2", "OLUOM2", JdeDataType.String, 4),
        new JdeField("OLSQOR", "OLSQOR", JdeDataType.Numeric),
        new JdeField("OLUOM3", "OLUOM3", JdeDataType.String, 4),
        new JdeField("OLITWT", "OLITWT", JdeDataType.Numeric),
        new JdeField("OLWTUM", "OLWTUM", JdeDataType.String, 4),
        new JdeField("OLITVL", "OLITVL", JdeDataType.Numeric),
        new JdeField("OLVLUM", "OLVLUM", JdeDataType.String, 4),
        new JdeField("OLGLC", "OLGLC", JdeDataType.String, 8),
        new JdeField("OLCTRY", "OLCTRY", JdeDataType.Numeric),
        new JdeField("OLFY", "OLFY", JdeDataType.Numeric),
        new JdeField("OLSTTS", "OLSTTS", JdeDataType.String, 4),
        new JdeField("OLRCD", "OLRCD", JdeDataType.String, 6),
        new JdeField("OLFUF1", "OLFUF1", JdeDataType.String, 2),
        new JdeField("OLFUF2", "OLFUF2", JdeDataType.String, 2),
        new JdeField("OLGRWT", "OLGRWT", JdeDataType.Numeric),
        new JdeField("OLGWUM", "OLGWUM", JdeDataType.String, 4),
        new JdeField("OLLT", "OLLT", JdeDataType.String, 4),
        new JdeField("OLANI", "OLANI", JdeDataType.String, 58),
        new JdeField("OLAID", "OLAID", JdeDataType.String, 16),
        new JdeField("OLOMCU", "OLOMCU", JdeDataType.String, 24),
        new JdeField("OLOBJ", "OLOBJ", JdeDataType.String, 12),
        new JdeField("OLSUB", "OLSUB", JdeDataType.String, 16),
        new JdeField("OLSBLT", "OLSBLT", JdeDataType.String, 2),
        new JdeField("OLSBL", "OLSBL", JdeDataType.String, 16),
        new JdeField("OLASID", "OLASID", JdeDataType.String, 50),
        new JdeField("OLCCMP", "OLCCMP", JdeDataType.Numeric),
        new JdeField("OLTAG", "OLTAG", JdeDataType.String, 16),
        new JdeField("OLWR01", "OLWR01", JdeDataType.String, 8),
        new JdeField("OLPL", "OLPL", JdeDataType.String, 8),
        new JdeField("OLELEV", "OLELEV", JdeDataType.String, 6),
        new JdeField("OLR001", "OLR001", JdeDataType.String, 6),
        new JdeField("OLRTNR", "OLRTNR", JdeDataType.String, 6),
        new JdeField("OLLCOD", "OLLCOD", JdeDataType.String, 4),
        new JdeField("OLPURG", "OLPURG", JdeDataType.String, 2),
        new JdeField("OLPROM", "OLPROM", JdeDataType.String, 2),
        new JdeField("OLFNLP", "OLFNLP", JdeDataType.String, 2),
        new JdeField("OLAVCH", "OLAVCH", JdeDataType.String, 2),
        new JdeField("OLPRPY", "OLPRPY", JdeDataType.String, 2),
        new JdeField("OLUNCD", "OLUNCD", JdeDataType.String, 2),
        new JdeField("OLMATY", "OLMATY", JdeDataType.String, 2),
        new JdeField("OLRTGC", "OLRTGC", JdeDataType.String, 2),
        new JdeField("OLRCPF", "OLRCPF", JdeDataType.String, 2),
        new JdeField("OLPS01", "OLPS01", JdeDataType.String, 2),
        new JdeField("OLPS02", "OLPS02", JdeDataType.String, 2),
        new JdeField("OLPS03", "OLPS03", JdeDataType.String, 2),
        new JdeField("OLPS04", "OLPS04", JdeDataType.String, 2),
        new JdeField("OLPS05", "OLPS05", JdeDataType.String, 2),
        new JdeField("OLPS06", "OLPS06", JdeDataType.String, 2),
        new JdeField("OLPS07", "OLPS07", JdeDataType.String, 2),
        new JdeField("OLPS08", "OLPS08", JdeDataType.String, 2),
        new JdeField("OLPS09", "OLPS09", JdeDataType.String, 2),
        new JdeField("OLPS10", "OLPS10", JdeDataType.String, 2),
        new JdeField("OLCRMD", "OLCRMD", JdeDataType.String, 2),
        new JdeField("OLARTG", "OLARTG", JdeDataType.String, 24),
        new JdeField("OLCORD", "OLCORD", JdeDataType.Numeric),
        new JdeField("OLCHDT", "OLCHDT", JdeDataType.String, 4),
        new JdeField("OLDOCC", "OLDOCC", JdeDataType.Numeric),
        new JdeField("OLCHLN", "OLCHLN", JdeDataType.Numeric),
        new JdeField("OLCRCD", "OLCRCD", JdeDataType.String, 6),
        new JdeField("OLCRR", "OLCRR", JdeDataType.Numeric),
        new JdeField("OLFRRC", "OLFRRC", JdeDataType.Numeric),
        new JdeField("OLFEA", "OLFEA", JdeDataType.Numeric),
        new JdeField("OLFUC", "OLFUC", JdeDataType.Numeric),
        new JdeField("OLFEC", "OLFEC", JdeDataType.Numeric),
        new JdeField("OLFCHG", "OLFCHG", JdeDataType.Numeric),
        new JdeField("OLFAP", "OLFAP", JdeDataType.Numeric),
        new JdeField("OLFREC", "OLFREC", JdeDataType.Numeric),
        new JdeField("OLURCD", "OLURCD", JdeDataType.String, 4),
        new JdeField("OLURDT", "OLURDT", JdeDataType.Numeric),
        new JdeField("OLURAT", "OLURAT", JdeDataType.Numeric),
        new JdeField("OLURAB", "OLURAB", JdeDataType.Numeric),
        new JdeField("OLURRF", "OLURRF", JdeDataType.String, 30),
        new JdeField("OLTORG", "OLTORG", JdeDataType.String, 20),
        new JdeField("OLUSER", "OLUSER", JdeDataType.String, 20),
        new JdeField("OLPID", "OLPID", JdeDataType.String, 20),
        new JdeField("OLJOBN", "OLJOBN", JdeDataType.String, 20),
        new JdeField("OLUPMJ", "OLUPMJ", JdeDataType.Numeric),
        new JdeField("OLTDAY", "OLTDAY", JdeDataType.Numeric),
        new JdeField("OLVR05", "OLVR05", JdeDataType.String, 50),
        new JdeField("OLVR04", "OLVR04", JdeDataType.String, 50),
        new JdeField("OLSHPN", "OLSHPN", JdeDataType.Numeric),
        new JdeField("OLSHMT", "OLSHMT", JdeDataType.String, 30),
        new JdeField("OLRSHT", "OLRSHT", JdeDataType.Numeric),
        new JdeField("OLPRJM", "OLPRJM", JdeDataType.Numeric),
        new JdeField("OLDLEJ", "OLDLEJ", JdeDataType.Numeric),
        new JdeField("OLOSFX", "OLOSFX", JdeDataType.String, 6),
        new JdeField("OLMERL", "OLMERL", JdeDataType.String, 6),
        new JdeField("OLMCLN", "OLMCLN", JdeDataType.Numeric),
        new JdeField("OLMACT", "OLMACT", JdeDataType.String, 2),
        new JdeField("OLKTLN", "OLKTLN", JdeDataType.Numeric),
        new JdeField("OLFTRL", "OLFTRL", JdeDataType.Numeric),
        new JdeField("OLDRQT", "OLDRQT", JdeDataType.Numeric),
        new JdeField("OLCTAM", "OLCTAM", JdeDataType.Numeric),
        new JdeField("OLCPNT", "OLCPNT", JdeDataType.Numeric),
        new JdeField("OLCHT", "OLCHT", JdeDataType.Numeric),
        new JdeField("OLPMTN", "OLPMTN", JdeDataType.String, 24),
        new JdeField("OLCHRT", "OLCHRT", JdeDataType.Numeric),
        new JdeField("OLCHRS", "OLCHRS", JdeDataType.String, 2),
        new JdeField("OLCHMJ", "OLCHMJ", JdeDataType.Numeric),
        new JdeField("OLBCRC", "OLBCRC", JdeDataType.String, 6),
        new JdeField("OLDUAL", "OLDUAL", JdeDataType.String, 2),
        new JdeField("OLUKID", "OLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OLLDNM", "OLLDNM", JdeDataType.Numeric),
        new JdeField("OLMKFR", "OLMKFR", JdeDataType.Numeric),
        new JdeField("OLMFLG", "OLMFLG", JdeDataType.String, 2),
        new JdeField("OLDLNID", "OLDLNID", JdeDataType.Numeric),
        new JdeField("OLCMDCDE", "OLCMDCDE", JdeDataType.String, 30),
        new JdeField("OLUNSPSC", "OLUNSPSC", JdeDataType.String, 16),
        new JdeField("OLRSFX", "OLRSFX", JdeDataType.String, 6),
        new JdeField("OLWVID", "OLWVID", JdeDataType.Numeric),
        new JdeField("OLCNTRTID", "OLCNTRTID", JdeDataType.Numeric),
        new JdeField("OLCNTRTDID", "OLCNTRTDID", JdeDataType.Numeric),
        new JdeField("OLMOADJ", "OLMOADJ", JdeDataType.String, 2),
        new JdeField("OLPODC01", "OLPODC01", JdeDataType.String, 6),
        new JdeField("OLPODC02", "OLPODC02", JdeDataType.String, 6),
        new JdeField("OLPODC03", "OLPODC03", JdeDataType.String, 20),
        new JdeField("OLPODC04", "OLPODC04", JdeDataType.String, 20),
        new JdeField("OLJBCD", "OLJBCD", JdeDataType.String, 12),
        new JdeField("OLSRQTY", "OLSRQTY", JdeDataType.Numeric),
        new JdeField("OLSRUOM", "OLSRUOM", JdeDataType.String, 4),
        new JdeField("OLCFGFL", "OLCFGFL", JdeDataType.String, 2),
        new JdeField("OLPMPN", "OLPMPN", JdeDataType.String, 60),
        new JdeField("OLPNS", "OLPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43199_0", "Primary Key on OLUKID", new[] { "OLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43199_1", "Index on OLDOCO, OLDCTO, OLKCOO, OLSFXO, OLLNID, OLLT, OLCORD, OLUPMJ, OLTDAY", new[] { "OLDOCO", "OLDCTO", "OLKCOO", "OLSFXO", "OLLNID", "OLLT", "OLCORD", "OLUPMJ", "OLTDAY" }),
        new JdeIndex("F43199_2", "Index on OLDOCO, OLDCTO, OLKCOO, OLSFXO, OLCORD", new[] { "OLDOCO", "OLDCTO", "OLKCOO", "OLSFXO", "OLCORD" }),
        new JdeIndex("F43199_3", "Index on OLDOCO, OLDCTO, OLKCOO, OLSFXO, OLLNID, OLLT, OLCHLN", new[] { "OLDOCO", "OLDCTO", "OLKCOO", "OLSFXO", "OLLNID", "OLLT", "OLCHLN" }),
        new JdeIndex("F43199_4", "Index on OLLT, OLAID, OLDGL", new[] { "OLLT", "OLAID", "OLDGL" }),
        new JdeIndex("F43199_5", "Index on OLMCU, OLNXTR, OLDOCO, OLDCTO, OLKCOO, OLSFXO, OLLNID", new[] { "OLMCU", "OLNXTR", "OLDOCO", "OLDCTO", "OLKCOO", "OLSFXO", "OLLNID" }),
        new JdeIndex("F43199_6", "Index on OLMCU, OLLTTR, OLDOCO, OLDCTO, OLKCOO, OLSFXO, OLLNID", new[] { "OLMCU", "OLLTTR", "OLDOCO", "OLDCTO", "OLKCOO", "OLSFXO", "OLLNID" }),
        new JdeIndex("F43199_8", "Index on OLKCOO, OLDOCO, OLDCTO, OLSFXO, OLLNID, OLDLNID", new[] { "OLKCOO", "OLDOCO", "OLDCTO", "OLSFXO", "OLLNID", "OLDLNID" })
    };
}
