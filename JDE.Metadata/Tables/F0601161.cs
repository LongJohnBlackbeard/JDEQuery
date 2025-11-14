using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0601161 - .
/// </summary>
public class F0601161 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTEFTO.
        /// </summary>
        public const string PTEFTO = "PTEFTO";

        /// <summary>
        /// PTSVER.
        /// </summary>
        public const string PTSVER = "PTSVER";

        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTALPH.
        /// </summary>
        public const string PTALPH = "PTALPH";

        /// <summary>
        /// PTSSN.
        /// </summary>
        public const string PTSSN = "PTSSN";

        /// <summary>
        /// PTOEMP.
        /// </summary>
        public const string PTOEMP = "PTOEMP";

        /// <summary>
        /// PTSEX.
        /// </summary>
        public const string PTSEX = "PTSEX";

        /// <summary>
        /// PTMSTX.
        /// </summary>
        public const string PTMSTX = "PTMSTX";

        /// <summary>
        /// PTMSTI.
        /// </summary>
        public const string PTMSTI = "PTMSTI";

        /// <summary>
        /// PTWSPS.
        /// </summary>
        public const string PTWSPS = "PTWSPS";

        /// <summary>
        /// PTEIC.
        /// </summary>
        public const string PTEIC = "PTEIC";

        /// <summary>
        /// PTNDEP.
        /// </summary>
        public const string PTNDEP = "PTNDEP";

        /// <summary>
        /// PTEST.
        /// </summary>
        public const string PTEST = "PTEST";

        /// <summary>
        /// PTECNT.
        /// </summary>
        public const string PTECNT = "PTECNT";

        /// <summary>
        /// PTTARR.
        /// </summary>
        public const string PTTARR = "PTTARR";

        /// <summary>
        /// PTTARA.
        /// </summary>
        public const string PTTARA = "PTTARA";

        /// <summary>
        /// PTSCDC.
        /// </summary>
        public const string PTSCDC = "PTSCDC";

        /// <summary>
        /// PTHMST.
        /// </summary>
        public const string PTHMST = "PTHMST";

        /// <summary>
        /// PTWKSE.
        /// </summary>
        public const string PTWKSE = "PTWKSE";

        /// <summary>
        /// PTHMLC.
        /// </summary>
        public const string PTHMLC = "PTHMLC";

        /// <summary>
        /// PTLWK1.
        /// </summary>
        public const string PTLWK1 = "PTLWK1";

        /// <summary>
        /// PTLWK2.
        /// </summary>
        public const string PTLWK2 = "PTLWK2";

        /// <summary>
        /// PTHMCO.
        /// </summary>
        public const string PTHMCO = "PTHMCO";

        /// <summary>
        /// PTMCU.
        /// </summary>
        public const string PTMCU = "PTMCU";

        /// <summary>
        /// PTHMCU.
        /// </summary>
        public const string PTHMCU = "PTHMCU";

        /// <summary>
        /// PTSG.
        /// </summary>
        public const string PTSG = "PTSG";

        /// <summary>
        /// PTMAIL.
        /// </summary>
        public const string PTMAIL = "PTMAIL";

        /// <summary>
        /// PTPAST.
        /// </summary>
        public const string PTPAST = "PTPAST";

        /// <summary>
        /// PTPFRQ.
        /// </summary>
        public const string PTPFRQ = "PTPFRQ";

        /// <summary>
        /// PTSALY.
        /// </summary>
        public const string PTSALY = "PTSALY";

        /// <summary>
        /// PTPYCB.
        /// </summary>
        public const string PTPYCB = "PTPYCB";

        /// <summary>
        /// PTBCB.
        /// </summary>
        public const string PTBCB = "PTBCB";

        /// <summary>
        /// PTUN.
        /// </summary>
        public const string PTUN = "PTUN";

        /// <summary>
        /// PTJBCD.
        /// </summary>
        public const string PTJBCD = "PTJBCD";

        /// <summary>
        /// PTJBST.
        /// </summary>
        public const string PTJBST = "PTJBST";

        /// <summary>
        /// PTEEOJ.
        /// </summary>
        public const string PTEEOJ = "PTEEOJ";

        /// <summary>
        /// PTEEOM.
        /// </summary>
        public const string PTEEOM = "PTEEOM";

        /// <summary>
        /// PTTRS.
        /// </summary>
        public const string PTTRS = "PTTRS";

        /// <summary>
        /// PTWCMP.
        /// </summary>
        public const string PTWCMP = "PTWCMP";

        /// <summary>
        /// PTFLSA.
        /// </summary>
        public const string PTFLSA = "PTFLSA";

        /// <summary>
        /// PTWS.
        /// </summary>
        public const string PTWS = "PTWS";

        /// <summary>
        /// PTSHFT.
        /// </summary>
        public const string PTSHFT = "PTSHFT";

        /// <summary>
        /// PTLMTH.
        /// </summary>
        public const string PTLMTH = "PTLMTH";

        /// <summary>
        /// PTPBRT.
        /// </summary>
        public const string PTPBRT = "PTPBRT";

        /// <summary>
        /// PTLF.
        /// </summary>
        public const string PTLF = "PTLF";

        /// <summary>
        /// PTSAL.
        /// </summary>
        public const string PTSAL = "PTSAL";

        /// <summary>
        /// PTPHRT.
        /// </summary>
        public const string PTPHRT = "PTPHRT";

        /// <summary>
        /// PTPPRT.
        /// </summary>
        public const string PTPPRT = "PTPPRT";

        /// <summary>
        /// PTPWRN.
        /// </summary>
        public const string PTPWRN = "PTPWRN";

        /// <summary>
        /// PTHRTN.
        /// </summary>
        public const string PTHRTN = "PTHRTN";

        /// <summary>
        /// PTBRTN.
        /// </summary>
        public const string PTBRTN = "PTBRTN";

        /// <summary>
        /// PTSALN.
        /// </summary>
        public const string PTSALN = "PTSALN";

        /// <summary>
        /// PTSTDH.
        /// </summary>
        public const string PTSTDH = "PTSTDH";

        /// <summary>
        /// PTSTDD.
        /// </summary>
        public const string PTSTDD = "PTSTDD";

        /// <summary>
        /// PTSDYY.
        /// </summary>
        public const string PTSDYY = "PTSDYY";

        /// <summary>
        /// PTUSR.
        /// </summary>
        public const string PTUSR = "PTUSR";

        /// <summary>
        /// PTUFLG.
        /// </summary>
        public const string PTUFLG = "PTUFLG";

        /// <summary>
        /// PTNS.
        /// </summary>
        public const string PTNS = "PTNS";

        /// <summary>
        /// PTIFN.
        /// </summary>
        public const string PTIFN = "PTIFN";

        /// <summary>
        /// PTIMN.
        /// </summary>
        public const string PTIMN = "PTIMN";

        /// <summary>
        /// PTDOB.
        /// </summary>
        public const string PTDOB = "PTDOB";

        /// <summary>
        /// PTDSI.
        /// </summary>
        public const string PTDSI = "PTDSI";

        /// <summary>
        /// PTDT.
        /// </summary>
        public const string PTDT = "PTDT";

        /// <summary>
        /// PTDST.
        /// </summary>
        public const string PTDST = "PTDST";

        /// <summary>
        /// PTPSDT.
        /// </summary>
        public const string PTPSDT = "PTPSDT";

        /// <summary>
        /// PTPTDT.
        /// </summary>
        public const string PTPTDT = "PTPTDT";

        /// <summary>
        /// PTNRDT.
        /// </summary>
        public const string PTNRDT = "PTNRDT";

        /// <summary>
        /// PTNBDT.
        /// </summary>
        public const string PTNBDT = "PTNBDT";

        /// <summary>
        /// PTNPDT.
        /// </summary>
        public const string PTNPDT = "PTNPDT";

        /// <summary>
        /// PTLCDT.
        /// </summary>
        public const string PTLCDT = "PTLCDT";

        /// <summary>
        /// PTDR.
        /// </summary>
        public const string PTDR = "PTDR";

        /// <summary>
        /// PTCTDT.
        /// </summary>
        public const string PTCTDT = "PTCTDT";

        /// <summary>
        /// PTLADT.
        /// </summary>
        public const string PTLADT = "PTLADT";

        /// <summary>
        /// PTBSDT.
        /// </summary>
        public const string PTBSDT = "PTBSDT";

        /// <summary>
        /// PTCPDT.
        /// </summary>
        public const string PTCPDT = "PTCPDT";

        /// <summary>
        /// PTFICM.
        /// </summary>
        public const string PTFICM = "PTFICM";

        /// <summary>
        /// PTP001.
        /// </summary>
        public const string PTP001 = "PTP001";

        /// <summary>
        /// PTP002.
        /// </summary>
        public const string PTP002 = "PTP002";

        /// <summary>
        /// PTP003.
        /// </summary>
        public const string PTP003 = "PTP003";

        /// <summary>
        /// PTP004.
        /// </summary>
        public const string PTP004 = "PTP004";

        /// <summary>
        /// PTP005.
        /// </summary>
        public const string PTP005 = "PTP005";

        /// <summary>
        /// PTP006.
        /// </summary>
        public const string PTP006 = "PTP006";

        /// <summary>
        /// PTP007.
        /// </summary>
        public const string PTP007 = "PTP007";

        /// <summary>
        /// PTP008.
        /// </summary>
        public const string PTP008 = "PTP008";

        /// <summary>
        /// PTP009.
        /// </summary>
        public const string PTP009 = "PTP009";

        /// <summary>
        /// PTP010.
        /// </summary>
        public const string PTP010 = "PTP010";

        /// <summary>
        /// PTP011.
        /// </summary>
        public const string PTP011 = "PTP011";

        /// <summary>
        /// PTP012.
        /// </summary>
        public const string PTP012 = "PTP012";

        /// <summary>
        /// PTP013.
        /// </summary>
        public const string PTP013 = "PTP013";

        /// <summary>
        /// PTP014.
        /// </summary>
        public const string PTP014 = "PTP014";

        /// <summary>
        /// PTP015.
        /// </summary>
        public const string PTP015 = "PTP015";

        /// <summary>
        /// PTP016.
        /// </summary>
        public const string PTP016 = "PTP016";

        /// <summary>
        /// PTP017.
        /// </summary>
        public const string PTP017 = "PTP017";

        /// <summary>
        /// PTP018.
        /// </summary>
        public const string PTP018 = "PTP018";

        /// <summary>
        /// PTP019.
        /// </summary>
        public const string PTP019 = "PTP019";

        /// <summary>
        /// PTP020.
        /// </summary>
        public const string PTP020 = "PTP020";

        /// <summary>
        /// PTE001.
        /// </summary>
        public const string PTE001 = "PTE001";

        /// <summary>
        /// PTE002.
        /// </summary>
        public const string PTE002 = "PTE002";

        /// <summary>
        /// PTE003.
        /// </summary>
        public const string PTE003 = "PTE003";

        /// <summary>
        /// PTE004.
        /// </summary>
        public const string PTE004 = "PTE004";

        /// <summary>
        /// PTE005.
        /// </summary>
        public const string PTE005 = "PTE005";

        /// <summary>
        /// PTE006.
        /// </summary>
        public const string PTE006 = "PTE006";

        /// <summary>
        /// PTE007.
        /// </summary>
        public const string PTE007 = "PTE007";

        /// <summary>
        /// PTE008.
        /// </summary>
        public const string PTE008 = "PTE008";

        /// <summary>
        /// PTE009.
        /// </summary>
        public const string PTE009 = "PTE009";

        /// <summary>
        /// PTE010.
        /// </summary>
        public const string PTE010 = "PTE010";

        /// <summary>
        /// PTICC.
        /// </summary>
        public const string PTICC = "PTICC";

        /// <summary>
        /// PTNMAX.
        /// </summary>
        public const string PTNMAX = "PTNMAX";

        /// <summary>
        /// PTSOCC.
        /// </summary>
        public const string PTSOCC = "PTSOCC";

        /// <summary>
        /// PTIUSR.
        /// </summary>
        public const string PTIUSR = "PTIUSR";

        /// <summary>
        /// PTITRM.
        /// </summary>
        public const string PTITRM = "PTITRM";

        /// <summary>
        /// PTINBT.
        /// </summary>
        public const string PTINBT = "PTINBT";

        /// <summary>
        /// PTREGN.
        /// </summary>
        public const string PTREGN = "PTREGN";

        /// <summary>
        /// PTPSTP.
        /// </summary>
        public const string PTPSTP = "PTPSTP";

        /// <summary>
        /// PTIH.
        /// </summary>
        public const string PTIH = "PTIH";

        /// <summary>
        /// PTCCPR.
        /// </summary>
        public const string PTCCPR = "PTCCPR";

        /// <summary>
        /// PTADPN.
        /// </summary>
        public const string PTADPN = "PTADPN";

        /// <summary>
        /// PTTCNF.
        /// </summary>
        public const string PTTCNF = "PTTCNF";

        /// <summary>
        /// PTRAF.
        /// </summary>
        public const string PTRAF = "PTRAF";

        /// <summary>
        /// PTTIPE.
        /// </summary>
        public const string PTTIPE = "PTTIPE";

        /// <summary>
        /// PTRCCD.
        /// </summary>
        public const string PTRCCD = "PTRCCD";

        /// <summary>
        /// PTBDRT.
        /// </summary>
        public const string PTBDRT = "PTBDRT";

        /// <summary>
        /// PTBORN.
        /// </summary>
        public const string PTBORN = "PTBORN";

        /// <summary>
        /// PTNBDR.
        /// </summary>
        public const string PTNBDR = "PTNBDR";

        /// <summary>
        /// PTWET.
        /// </summary>
        public const string PTWET = "PTWET";

        /// <summary>
        /// PTAFLG.
        /// </summary>
        public const string PTAFLG = "PTAFLG";

        /// <summary>
        /// PTRMST.
        /// </summary>
        public const string PTRMST = "PTRMST";

        /// <summary>
        /// PTLMST.
        /// </summary>
        public const string PTLMST = "PTLMST";

        /// <summary>
        /// PTSMKR.
        /// </summary>
        public const string PTSMKR = "PTSMKR";

        /// <summary>
        /// PTCBAC.
        /// </summary>
        public const string PTCBAC = "PTCBAC";

        /// <summary>
        /// PTCBAF.
        /// </summary>
        public const string PTCBAF = "PTCBAF";

        /// <summary>
        /// PTPCCD.
        /// </summary>
        public const string PTPCCD = "PTPCCD";

        /// <summary>
        /// PTRCDT.
        /// </summary>
        public const string PTRCDT = "PTRCDT";

        /// <summary>
        /// PTLSDT.
        /// </summary>
        public const string PTLSDT = "PTLSDT";

        /// <summary>
        /// PTPADT.
        /// </summary>
        public const string PTPADT = "PTPADT";

        /// <summary>
        /// PTPYMH.
        /// </summary>
        public const string PTPYMH = "PTPYMH";

        /// <summary>
        /// PTUYST.
        /// </summary>
        public const string PTUYST = "PTUYST";

        /// <summary>
        /// PTDTSP.
        /// </summary>
        public const string PTDTSP = "PTDTSP";

        /// <summary>
        /// PTANN8.
        /// </summary>
        public const string PTANN8 = "PTANN8";

        /// <summary>
        /// PTPPNB.
        /// </summary>
        public const string PTPPNB = "PTPPNB";

        /// <summary>
        /// PTPYDT.
        /// </summary>
        public const string PTPYDT = "PTPYDT";

        /// <summary>
        /// PTCBEN.
        /// </summary>
        public const string PTCBEN = "PTCBEN";

        /// <summary>
        /// PTDOBM.
        /// </summary>
        public const string PTDOBM = "PTDOBM";

        /// <summary>
        /// PTDSTM.
        /// </summary>
        public const string PTDSTM = "PTDSTM";

        /// <summary>
        /// PTPSAL.
        /// </summary>
        public const string PTPSAL = "PTPSAL";

        /// <summary>
        /// PTHIPN.
        /// </summary>
        public const string PTHIPN = "PTHIPN";

        /// <summary>
        /// PTCM.
        /// </summary>
        public const string PTCM = "PTCM";

        /// <summary>
        /// PTLSAL.
        /// </summary>
        public const string PTLSAL = "PTLSAL";

        /// <summary>
        /// PTDIVC.
        /// </summary>
        public const string PTDIVC = "PTDIVC";

        /// <summary>
        /// PTVSHF.
        /// </summary>
        public const string PTVSHF = "PTVSHF";

        /// <summary>
        /// PTPYRV.
        /// </summary>
        public const string PTPYRV = "PTPYRV";

        /// <summary>
        /// PTANPA.
        /// </summary>
        public const string PTANPA = "PTANPA";

        /// <summary>
        /// PTPGRD.
        /// </summary>
        public const string PTPGRD = "PTPGRD";

        /// <summary>
        /// PTPGRS.
        /// </summary>
        public const string PTPGRS = "PTPGRS";

        /// <summary>
        /// PTSLOC.
        /// </summary>
        public const string PTSLOC = "PTSLOC";

        /// <summary>
        /// PTNRVW.
        /// </summary>
        public const string PTNRVW = "PTNRVW";

        /// <summary>
        /// PTTINC.
        /// </summary>
        public const string PTTINC = "PTTINC";

        /// <summary>
        /// PTHM01.
        /// </summary>
        public const string PTHM01 = "PTHM01";

        /// <summary>
        /// PTHM02.
        /// </summary>
        public const string PTHM02 = "PTHM02";

        /// <summary>
        /// PTHM03.
        /// </summary>
        public const string PTHM03 = "PTHM03";

        /// <summary>
        /// PTHM04.
        /// </summary>
        public const string PTHM04 = "PTHM04";

        /// <summary>
        /// PTPOS.
        /// </summary>
        public const string PTPOS = "PTPOS";

        /// <summary>
        /// PTED01.
        /// </summary>
        public const string PTED01 = "PTED01";

        /// <summary>
        /// PTED02.
        /// </summary>
        public const string PTED02 = "PTED02";

        /// <summary>
        /// PTED03.
        /// </summary>
        public const string PTED03 = "PTED03";

        /// <summary>
        /// PTED04.
        /// </summary>
        public const string PTED04 = "PTED04";

        /// <summary>
        /// PTED05.
        /// </summary>
        public const string PTED05 = "PTED05";

        /// <summary>
        /// PTED06.
        /// </summary>
        public const string PTED06 = "PTED06";

        /// <summary>
        /// PTED07.
        /// </summary>
        public const string PTED07 = "PTED07";

        /// <summary>
        /// PTED08.
        /// </summary>
        public const string PTED08 = "PTED08";

        /// <summary>
        /// PTED09.
        /// </summary>
        public const string PTED09 = "PTED09";

        /// <summary>
        /// PTED10.
        /// </summary>
        public const string PTED10 = "PTED10";

        /// <summary>
        /// PTED11.
        /// </summary>
        public const string PTED11 = "PTED11";

        /// <summary>
        /// PTED12.
        /// </summary>
        public const string PTED12 = "PTED12";

        /// <summary>
        /// PTED13.
        /// </summary>
        public const string PTED13 = "PTED13";

        /// <summary>
        /// PTED14.
        /// </summary>
        public const string PTED14 = "PTED14";

        /// <summary>
        /// PTED15.
        /// </summary>
        public const string PTED15 = "PTED15";

        /// <summary>
        /// PTED16.
        /// </summary>
        public const string PTED16 = "PTED16";

        /// <summary>
        /// PTED17.
        /// </summary>
        public const string PTED17 = "PTED17";

        /// <summary>
        /// PTED18.
        /// </summary>
        public const string PTED18 = "PTED18";

        /// <summary>
        /// PTED19.
        /// </summary>
        public const string PTED19 = "PTED19";

        /// <summary>
        /// PTED20.
        /// </summary>
        public const string PTED20 = "PTED20";

        /// <summary>
        /// PTDEPT.
        /// </summary>
        public const string PTDEPT = "PTDEPT";

        /// <summary>
        /// PTFAGE.
        /// </summary>
        public const string PTFAGE = "PTFAGE";

        /// <summary>
        /// PTFSAL.
        /// </summary>
        public const string PTFSAL = "PTFSAL";

        /// <summary>
        /// PTADSD.
        /// </summary>
        public const string PTADSD = "PTADSD";

        /// <summary>
        /// PTCMPA.
        /// </summary>
        public const string PTCMPA = "PTCMPA";

        /// <summary>
        /// PTEPNT.
        /// </summary>
        public const string PTEPNT = "PTEPNT";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTK001.
        /// </summary>
        public const string PTK001 = "PTK001";

        /// <summary>
        /// PTK002.
        /// </summary>
        public const string PTK002 = "PTK002";

        /// <summary>
        /// PTK003.
        /// </summary>
        public const string PTK003 = "PTK003";

        /// <summary>
        /// PTK004.
        /// </summary>
        public const string PTK004 = "PTK004";

        /// <summary>
        /// PTK005.
        /// </summary>
        public const string PTK005 = "PTK005";

        /// <summary>
        /// PTK006.
        /// </summary>
        public const string PTK006 = "PTK006";

        /// <summary>
        /// PTK007.
        /// </summary>
        public const string PTK007 = "PTK007";

        /// <summary>
        /// PTK008.
        /// </summary>
        public const string PTK008 = "PTK008";

        /// <summary>
        /// PTK009.
        /// </summary>
        public const string PTK009 = "PTK009";

        /// <summary>
        /// PTK010.
        /// </summary>
        public const string PTK010 = "PTK010";

        /// <summary>
        /// PTATPY.
        /// </summary>
        public const string PTATPY = "PTATPY";

        /// <summary>
        /// PTPENS.
        /// </summary>
        public const string PTPENS = "PTPENS";

        /// <summary>
        /// PTORG.
        /// </summary>
        public const string PTORG = "PTORG";

        /// <summary>
        /// PTBENS.
        /// </summary>
        public const string PTBENS = "PTBENS";

        /// <summary>
        /// PTFTE.
        /// </summary>
        public const string PTFTE = "PTFTE";

        /// <summary>
        /// PTAAF.
        /// </summary>
        public const string PTAAF = "PTAAF";

        /// <summary>
        /// PTSUI.
        /// </summary>
        public const string PTSUI = "PTSUI";

        /// <summary>
        /// PTDTSF.
        /// </summary>
        public const string PTDTSF = "PTDTSF";

        /// <summary>
        /// PTSMOY.
        /// </summary>
        public const string PTSMOY = "PTSMOY";

        /// <summary>
        /// PTLDID.
        /// </summary>
        public const string PTLDID = "PTLDID";

        /// <summary>
        /// PTTTAR.
        /// </summary>
        public const string PTTTAR = "PTTTAR";
    }

    /// <inheritdoc />
    public override string TableName => "F0601161";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTEFTO", "PTEFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTSVER", "PTSVER", JdeDataType.String, 20, true, true),
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PTALPH", "PTALPH", JdeDataType.String, 80),
        new JdeField("PTSSN", "PTSSN", JdeDataType.String, 40),
        new JdeField("PTOEMP", "PTOEMP", JdeDataType.String, 16),
        new JdeField("PTSEX", "PTSEX", JdeDataType.String, 2),
        new JdeField("PTMSTX", "PTMSTX", JdeDataType.String, 2),
        new JdeField("PTMSTI", "PTMSTI", JdeDataType.String, 2),
        new JdeField("PTWSPS", "PTWSPS", JdeDataType.String, 2),
        new JdeField("PTEIC", "PTEIC", JdeDataType.String, 2),
        new JdeField("PTNDEP", "PTNDEP", JdeDataType.Numeric),
        new JdeField("PTEST", "PTEST", JdeDataType.String, 2),
        new JdeField("PTECNT", "PTECNT", JdeDataType.String, 2),
        new JdeField("PTTARR", "PTTARR", JdeDataType.String, 20),
        new JdeField("PTTARA", "PTTARA", JdeDataType.String, 20),
        new JdeField("PTSCDC", "PTSCDC", JdeDataType.Numeric),
        new JdeField("PTHMST", "PTHMST", JdeDataType.String, 6),
        new JdeField("PTWKSE", "PTWKSE", JdeDataType.String, 6),
        new JdeField("PTHMLC", "PTHMLC", JdeDataType.String, 6),
        new JdeField("PTLWK1", "PTLWK1", JdeDataType.String, 6),
        new JdeField("PTLWK2", "PTLWK2", JdeDataType.String, 6),
        new JdeField("PTHMCO", "PTHMCO", JdeDataType.String, 10),
        new JdeField("PTMCU", "PTMCU", JdeDataType.String, 24),
        new JdeField("PTHMCU", "PTHMCU", JdeDataType.String, 24),
        new JdeField("PTSG", "PTSG", JdeDataType.String, 24),
        new JdeField("PTMAIL", "PTMAIL", JdeDataType.String, 20),
        new JdeField("PTPAST", "PTPAST", JdeDataType.String, 2),
        new JdeField("PTPFRQ", "PTPFRQ", JdeDataType.String, 2),
        new JdeField("PTSALY", "PTSALY", JdeDataType.String, 2),
        new JdeField("PTPYCB", "PTPYCB", JdeDataType.Numeric),
        new JdeField("PTBCB", "PTBCB", JdeDataType.Numeric),
        new JdeField("PTUN", "PTUN", JdeDataType.String, 12),
        new JdeField("PTJBCD", "PTJBCD", JdeDataType.String, 12),
        new JdeField("PTJBST", "PTJBST", JdeDataType.String, 8),
        new JdeField("PTEEOJ", "PTEEOJ", JdeDataType.String, 6),
        new JdeField("PTEEOM", "PTEEOM", JdeDataType.String, 4),
        new JdeField("PTTRS", "PTTRS", JdeDataType.String, 6),
        new JdeField("PTWCMP", "PTWCMP", JdeDataType.String, 8),
        new JdeField("PTFLSA", "PTFLSA", JdeDataType.String, 2),
        new JdeField("PTWS", "PTWS", JdeDataType.String, 2),
        new JdeField("PTSHFT", "PTSHFT", JdeDataType.String, 2),
        new JdeField("PTLMTH", "PTLMTH", JdeDataType.String, 2),
        new JdeField("PTPBRT", "PTPBRT", JdeDataType.Numeric),
        new JdeField("PTLF", "PTLF", JdeDataType.Numeric),
        new JdeField("PTSAL", "PTSAL", JdeDataType.Numeric),
        new JdeField("PTPHRT", "PTPHRT", JdeDataType.Numeric),
        new JdeField("PTPPRT", "PTPPRT", JdeDataType.Numeric),
        new JdeField("PTPWRN", "PTPWRN", JdeDataType.Numeric),
        new JdeField("PTHRTN", "PTHRTN", JdeDataType.Numeric),
        new JdeField("PTBRTN", "PTBRTN", JdeDataType.Numeric),
        new JdeField("PTSALN", "PTSALN", JdeDataType.Numeric),
        new JdeField("PTSTDH", "PTSTDH", JdeDataType.Numeric),
        new JdeField("PTSTDD", "PTSTDD", JdeDataType.Numeric),
        new JdeField("PTSDYY", "PTSDYY", JdeDataType.Numeric),
        new JdeField("PTUSR", "PTUSR", JdeDataType.String, 36),
        new JdeField("PTUFLG", "PTUFLG", JdeDataType.String, 2),
        new JdeField("PTNS", "PTNS", JdeDataType.String, 2),
        new JdeField("PTIFN", "PTIFN", JdeDataType.String, 2),
        new JdeField("PTIMN", "PTIMN", JdeDataType.String, 2),
        new JdeField("PTDOB", "PTDOB", JdeDataType.Numeric),
        new JdeField("PTDSI", "PTDSI", JdeDataType.Numeric),
        new JdeField("PTDT", "PTDT", JdeDataType.Numeric),
        new JdeField("PTDST", "PTDST", JdeDataType.Numeric),
        new JdeField("PTPSDT", "PTPSDT", JdeDataType.Numeric),
        new JdeField("PTPTDT", "PTPTDT", JdeDataType.Numeric),
        new JdeField("PTNRDT", "PTNRDT", JdeDataType.Numeric),
        new JdeField("PTNBDT", "PTNBDT", JdeDataType.Numeric),
        new JdeField("PTNPDT", "PTNPDT", JdeDataType.Numeric),
        new JdeField("PTLCDT", "PTLCDT", JdeDataType.Numeric),
        new JdeField("PTDR", "PTDR", JdeDataType.Numeric),
        new JdeField("PTCTDT", "PTCTDT", JdeDataType.Numeric),
        new JdeField("PTLADT", "PTLADT", JdeDataType.Numeric),
        new JdeField("PTBSDT", "PTBSDT", JdeDataType.Numeric),
        new JdeField("PTCPDT", "PTCPDT", JdeDataType.Numeric),
        new JdeField("PTFICM", "PTFICM", JdeDataType.String, 2),
        new JdeField("PTP001", "PTP001", JdeDataType.String, 6),
        new JdeField("PTP002", "PTP002", JdeDataType.String, 6),
        new JdeField("PTP003", "PTP003", JdeDataType.String, 6),
        new JdeField("PTP004", "PTP004", JdeDataType.String, 6),
        new JdeField("PTP005", "PTP005", JdeDataType.String, 6),
        new JdeField("PTP006", "PTP006", JdeDataType.String, 6),
        new JdeField("PTP007", "PTP007", JdeDataType.String, 6),
        new JdeField("PTP008", "PTP008", JdeDataType.String, 6),
        new JdeField("PTP009", "PTP009", JdeDataType.String, 6),
        new JdeField("PTP010", "PTP010", JdeDataType.String, 6),
        new JdeField("PTP011", "PTP011", JdeDataType.String, 6),
        new JdeField("PTP012", "PTP012", JdeDataType.String, 6),
        new JdeField("PTP013", "PTP013", JdeDataType.String, 6),
        new JdeField("PTP014", "PTP014", JdeDataType.String, 6),
        new JdeField("PTP015", "PTP015", JdeDataType.String, 6),
        new JdeField("PTP016", "PTP016", JdeDataType.String, 6),
        new JdeField("PTP017", "PTP017", JdeDataType.String, 6),
        new JdeField("PTP018", "PTP018", JdeDataType.String, 6),
        new JdeField("PTP019", "PTP019", JdeDataType.String, 6),
        new JdeField("PTP020", "PTP020", JdeDataType.String, 6),
        new JdeField("PTE001", "PTE001", JdeDataType.String, 2),
        new JdeField("PTE002", "PTE002", JdeDataType.String, 2),
        new JdeField("PTE003", "PTE003", JdeDataType.String, 2),
        new JdeField("PTE004", "PTE004", JdeDataType.String, 2),
        new JdeField("PTE005", "PTE005", JdeDataType.String, 2),
        new JdeField("PTE006", "PTE006", JdeDataType.String, 2),
        new JdeField("PTE007", "PTE007", JdeDataType.String, 2),
        new JdeField("PTE008", "PTE008", JdeDataType.String, 2),
        new JdeField("PTE009", "PTE009", JdeDataType.String, 2),
        new JdeField("PTE010", "PTE010", JdeDataType.String, 2),
        new JdeField("PTICC", "PTICC", JdeDataType.String, 2),
        new JdeField("PTNMAX", "PTNMAX", JdeDataType.Numeric),
        new JdeField("PTSOCC", "PTSOCC", JdeDataType.String, 8),
        new JdeField("PTIUSR", "PTIUSR", JdeDataType.String, 20),
        new JdeField("PTITRM", "PTITRM", JdeDataType.String, 20),
        new JdeField("PTINBT", "PTINBT", JdeDataType.String, 2),
        new JdeField("PTREGN", "PTREGN", JdeDataType.String, 6),
        new JdeField("PTPSTP", "PTPSTP", JdeDataType.String, 8),
        new JdeField("PTIH", "PTIH", JdeDataType.Numeric),
        new JdeField("PTCCPR", "PTCCPR", JdeDataType.String, 6),
        new JdeField("PTADPN", "PTADPN", JdeDataType.String, 2),
        new JdeField("PTTCNF", "PTTCNF", JdeDataType.String, 2),
        new JdeField("PTRAF", "PTRAF", JdeDataType.String, 2),
        new JdeField("PTTIPE", "PTTIPE", JdeDataType.String, 2),
        new JdeField("PTRCCD", "PTRCCD", JdeDataType.String, 2),
        new JdeField("PTBDRT", "PTBDRT", JdeDataType.Numeric),
        new JdeField("PTBORN", "PTBORN", JdeDataType.Numeric),
        new JdeField("PTNBDR", "PTNBDR", JdeDataType.Numeric),
        new JdeField("PTWET", "PTWET", JdeDataType.String, 2),
        new JdeField("PTAFLG", "PTAFLG", JdeDataType.String, 2),
        new JdeField("PTRMST", "PTRMST", JdeDataType.String, 2),
        new JdeField("PTLMST", "PTLMST", JdeDataType.String, 2),
        new JdeField("PTSMKR", "PTSMKR", JdeDataType.String, 4),
        new JdeField("PTCBAC", "PTCBAC", JdeDataType.Numeric),
        new JdeField("PTCBAF", "PTCBAF", JdeDataType.String, 2),
        new JdeField("PTPCCD", "PTPCCD", JdeDataType.String, 10),
        new JdeField("PTRCDT", "PTRCDT", JdeDataType.Numeric),
        new JdeField("PTLSDT", "PTLSDT", JdeDataType.Numeric),
        new JdeField("PTPADT", "PTPADT", JdeDataType.Numeric),
        new JdeField("PTPYMH", "PTPYMH", JdeDataType.String, 2),
        new JdeField("PTUYST", "PTUYST", JdeDataType.String, 2),
        new JdeField("PTDTSP", "PTDTSP", JdeDataType.Numeric),
        new JdeField("PTANN8", "PTANN8", JdeDataType.Numeric),
        new JdeField("PTPPNB", "PTPPNB", JdeDataType.String, 6),
        new JdeField("PTPYDT", "PTPYDT", JdeDataType.Numeric),
        new JdeField("PTCBEN", "PTCBEN", JdeDataType.String, 2),
        new JdeField("PTDOBM", "PTDOBM", JdeDataType.Numeric),
        new JdeField("PTDSTM", "PTDSTM", JdeDataType.Numeric),
        new JdeField("PTPSAL", "PTPSAL", JdeDataType.Numeric),
        new JdeField("PTHIPN", "PTHIPN", JdeDataType.String, 22),
        new JdeField("PTCM", "PTCM", JdeDataType.String, 4),
        new JdeField("PTLSAL", "PTLSAL", JdeDataType.Numeric),
        new JdeField("PTDIVC", "PTDIVC", JdeDataType.String, 12),
        new JdeField("PTVSHF", "PTVSHF", JdeDataType.String, 2),
        new JdeField("PTPYRV", "PTPYRV", JdeDataType.Numeric),
        new JdeField("PTANPA", "PTANPA", JdeDataType.Numeric),
        new JdeField("PTPGRD", "PTPGRD", JdeDataType.String, 12),
        new JdeField("PTPGRS", "PTPGRS", JdeDataType.String, 8),
        new JdeField("PTSLOC", "PTSLOC", JdeDataType.String, 16),
        new JdeField("PTNRVW", "PTNRVW", JdeDataType.Numeric),
        new JdeField("PTTINC", "PTTINC", JdeDataType.String, 2),
        new JdeField("PTHM01", "PTHM01", JdeDataType.String, 2),
        new JdeField("PTHM02", "PTHM02", JdeDataType.String, 2),
        new JdeField("PTHM03", "PTHM03", JdeDataType.String, 2),
        new JdeField("PTHM04", "PTHM04", JdeDataType.String, 2),
        new JdeField("PTPOS", "PTPOS", JdeDataType.String, 16),
        new JdeField("PTED01", "PTED01", JdeDataType.Numeric),
        new JdeField("PTED02", "PTED02", JdeDataType.Numeric),
        new JdeField("PTED03", "PTED03", JdeDataType.Numeric),
        new JdeField("PTED04", "PTED04", JdeDataType.Numeric),
        new JdeField("PTED05", "PTED05", JdeDataType.Numeric),
        new JdeField("PTED06", "PTED06", JdeDataType.Numeric),
        new JdeField("PTED07", "PTED07", JdeDataType.Numeric),
        new JdeField("PTED08", "PTED08", JdeDataType.Numeric),
        new JdeField("PTED09", "PTED09", JdeDataType.Numeric),
        new JdeField("PTED10", "PTED10", JdeDataType.Numeric),
        new JdeField("PTED11", "PTED11", JdeDataType.Numeric),
        new JdeField("PTED12", "PTED12", JdeDataType.Numeric),
        new JdeField("PTED13", "PTED13", JdeDataType.Numeric),
        new JdeField("PTED14", "PTED14", JdeDataType.Numeric),
        new JdeField("PTED15", "PTED15", JdeDataType.Numeric),
        new JdeField("PTED16", "PTED16", JdeDataType.Numeric),
        new JdeField("PTED17", "PTED17", JdeDataType.Numeric),
        new JdeField("PTED18", "PTED18", JdeDataType.Numeric),
        new JdeField("PTED19", "PTED19", JdeDataType.Numeric),
        new JdeField("PTED20", "PTED20", JdeDataType.Numeric),
        new JdeField("PTDEPT", "PTDEPT", JdeDataType.String, 24),
        new JdeField("PTFAGE", "PTFAGE", JdeDataType.Numeric),
        new JdeField("PTFSAL", "PTFSAL", JdeDataType.Numeric),
        new JdeField("PTADSD", "PTADSD", JdeDataType.Numeric),
        new JdeField("PTCMPA", "PTCMPA", JdeDataType.Numeric),
        new JdeField("PTEPNT", "PTEPNT", JdeDataType.Numeric),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTK001", "PTK001", JdeDataType.String, 2),
        new JdeField("PTK002", "PTK002", JdeDataType.String, 2),
        new JdeField("PTK003", "PTK003", JdeDataType.String, 2),
        new JdeField("PTK004", "PTK004", JdeDataType.String, 2),
        new JdeField("PTK005", "PTK005", JdeDataType.String, 2),
        new JdeField("PTK006", "PTK006", JdeDataType.String, 2),
        new JdeField("PTK007", "PTK007", JdeDataType.String, 2),
        new JdeField("PTK008", "PTK008", JdeDataType.String, 2),
        new JdeField("PTK009", "PTK009", JdeDataType.String, 2),
        new JdeField("PTK010", "PTK010", JdeDataType.String, 2),
        new JdeField("PTATPY", "PTATPY", JdeDataType.Numeric),
        new JdeField("PTPENS", "PTPENS", JdeDataType.String, 2),
        new JdeField("PTORG", "PTORG", JdeDataType.String, 2),
        new JdeField("PTBENS", "PTBENS", JdeDataType.String, 2),
        new JdeField("PTFTE", "PTFTE", JdeDataType.Numeric),
        new JdeField("PTAAF", "PTAAF", JdeDataType.String, 2),
        new JdeField("PTSUI", "PTSUI", JdeDataType.String, 2),
        new JdeField("PTDTSF", "PTDTSF", JdeDataType.Numeric),
        new JdeField("PTSMOY", "PTSMOY", JdeDataType.Numeric),
        new JdeField("PTLDID", "PTLDID", JdeDataType.String, 10),
        new JdeField("PTTTAR", "PTTTAR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0601161_0", "Primary Key on PTEFTO, PTSVER, PTAN8", new[] { "PTEFTO", "PTSVER", "PTAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
