using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4611 - .
/// </summary>
public class F4611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R2TYFL.
        /// </summary>
        public const string R2TYFL = "R2TYFL";

        /// <summary>
        /// R2OCDE.
        /// </summary>
        public const string R2OCDE = "R2OCDE";

        /// <summary>
        /// R2RQBT.
        /// </summary>
        public const string R2RQBT = "R2RQBT";

        /// <summary>
        /// R2RQSQ.
        /// </summary>
        public const string R2RQSQ = "R2RQSQ";

        /// <summary>
        /// R2SGBT.
        /// </summary>
        public const string R2SGBT = "R2SGBT";

        /// <summary>
        /// R2SGSQ.
        /// </summary>
        public const string R2SGSQ = "R2SGSQ";

        /// <summary>
        /// R2PWAV.
        /// </summary>
        public const string R2PWAV = "R2PWAV";

        /// <summary>
        /// R2PTSK.
        /// </summary>
        public const string R2PTSK = "R2PTSK";

        /// <summary>
        /// R2TRIP.
        /// </summary>
        public const string R2TRIP = "R2TRIP";

        /// <summary>
        /// R2MCU.
        /// </summary>
        public const string R2MCU = "R2MCU";

        /// <summary>
        /// R2KCOO.
        /// </summary>
        public const string R2KCOO = "R2KCOO";

        /// <summary>
        /// R2DOCO.
        /// </summary>
        public const string R2DOCO = "R2DOCO";

        /// <summary>
        /// R2DCTO.
        /// </summary>
        public const string R2DCTO = "R2DCTO";

        /// <summary>
        /// R2LNID.
        /// </summary>
        public const string R2LNID = "R2LNID";

        /// <summary>
        /// R2NLIN.
        /// </summary>
        public const string R2NLIN = "R2NLIN";

        /// <summary>
        /// R2SFXO.
        /// </summary>
        public const string R2SFXO = "R2SFXO";

        /// <summary>
        /// R2CLID.
        /// </summary>
        public const string R2CLID = "R2CLID";

        /// <summary>
        /// R2ITM.
        /// </summary>
        public const string R2ITM = "R2ITM";

        /// <summary>
        /// R2LITM.
        /// </summary>
        public const string R2LITM = "R2LITM";

        /// <summary>
        /// R2AITM.
        /// </summary>
        public const string R2AITM = "R2AITM";

        /// <summary>
        /// R2UML1.
        /// </summary>
        public const string R2UML1 = "R2UML1";

        /// <summary>
        /// R2TQL1.
        /// </summary>
        public const string R2TQL1 = "R2TQL1";

        /// <summary>
        /// R2EQL1.
        /// </summary>
        public const string R2EQL1 = "R2EQL1";

        /// <summary>
        /// R2UML2.
        /// </summary>
        public const string R2UML2 = "R2UML2";

        /// <summary>
        /// R2QPL2.
        /// </summary>
        public const string R2QPL2 = "R2QPL2";

        /// <summary>
        /// R2TQL2.
        /// </summary>
        public const string R2TQL2 = "R2TQL2";

        /// <summary>
        /// R2EQL2.
        /// </summary>
        public const string R2EQL2 = "R2EQL2";

        /// <summary>
        /// R2UML3.
        /// </summary>
        public const string R2UML3 = "R2UML3";

        /// <summary>
        /// R2QPL3.
        /// </summary>
        public const string R2QPL3 = "R2QPL3";

        /// <summary>
        /// R2TQL3.
        /// </summary>
        public const string R2TQL3 = "R2TQL3";

        /// <summary>
        /// R2EQL3.
        /// </summary>
        public const string R2EQL3 = "R2EQL3";

        /// <summary>
        /// R2UML4.
        /// </summary>
        public const string R2UML4 = "R2UML4";

        /// <summary>
        /// R2QPL4.
        /// </summary>
        public const string R2QPL4 = "R2QPL4";

        /// <summary>
        /// R2TQL4.
        /// </summary>
        public const string R2TQL4 = "R2TQL4";

        /// <summary>
        /// R2EQL4.
        /// </summary>
        public const string R2EQL4 = "R2EQL4";

        /// <summary>
        /// R2CPNB.
        /// </summary>
        public const string R2CPNB = "R2CPNB";

        /// <summary>
        /// R2UML5.
        /// </summary>
        public const string R2UML5 = "R2UML5";

        /// <summary>
        /// R2QPL5.
        /// </summary>
        public const string R2QPL5 = "R2QPL5";

        /// <summary>
        /// R2TQL5.
        /// </summary>
        public const string R2TQL5 = "R2TQL5";

        /// <summary>
        /// R2EQL5.
        /// </summary>
        public const string R2EQL5 = "R2EQL5";

        /// <summary>
        /// R2UOM1.
        /// </summary>
        public const string R2UOM1 = "R2UOM1";

        /// <summary>
        /// R2TQTY.
        /// </summary>
        public const string R2TQTY = "R2TQTY";

        /// <summary>
        /// R2CUBE.
        /// </summary>
        public const string R2CUBE = "R2CUBE";

        /// <summary>
        /// R2VUMD.
        /// </summary>
        public const string R2VUMD = "R2VUMD";

        /// <summary>
        /// R2WEIT.
        /// </summary>
        public const string R2WEIT = "R2WEIT";

        /// <summary>
        /// R2UWUM.
        /// </summary>
        public const string R2UWUM = "R2UWUM";

        /// <summary>
        /// R2LDFS.
        /// </summary>
        public const string R2LDFS = "R2LDFS";

        /// <summary>
        /// R2FLOC.
        /// </summary>
        public const string R2FLOC = "R2FLOC";

        /// <summary>
        /// R2FLOT.
        /// </summary>
        public const string R2FLOT = "R2FLOT";

        /// <summary>
        /// R2STNF.
        /// </summary>
        public const string R2STNF = "R2STNF";

        /// <summary>
        /// R2LDTS.
        /// </summary>
        public const string R2LDTS = "R2LDTS";

        /// <summary>
        /// R2TLOC.
        /// </summary>
        public const string R2TLOC = "R2TLOC";

        /// <summary>
        /// R2TLOT.
        /// </summary>
        public const string R2TLOT = "R2TLOT";

        /// <summary>
        /// R2STNT.
        /// </summary>
        public const string R2STNT = "R2STNT";

        /// <summary>
        /// R2LOTP.
        /// </summary>
        public const string R2LOTP = "R2LOTP";

        /// <summary>
        /// R2LOTG.
        /// </summary>
        public const string R2LOTG = "R2LOTG";

        /// <summary>
        /// R2MERG.
        /// </summary>
        public const string R2MERG = "R2MERG";

        /// <summary>
        /// R2EQTY.
        /// </summary>
        public const string R2EQTY = "R2EQTY";

        /// <summary>
        /// R2CRMT.
        /// </summary>
        public const string R2CRMT = "R2CRMT";

        /// <summary>
        /// R2BACK.
        /// </summary>
        public const string R2BACK = "R2BACK";

        /// <summary>
        /// R2APTS.
        /// </summary>
        public const string R2APTS = "R2APTS";

        /// <summary>
        /// R2COMM.
        /// </summary>
        public const string R2COMM = "R2COMM";

        /// <summary>
        /// R2ITCM.
        /// </summary>
        public const string R2ITCM = "R2ITCM";

        /// <summary>
        /// R2DSC1.
        /// </summary>
        public const string R2DSC1 = "R2DSC1";

        /// <summary>
        /// R2DSC2.
        /// </summary>
        public const string R2DSC2 = "R2DSC2";

        /// <summary>
        /// R2INMG.
        /// </summary>
        public const string R2INMG = "R2INMG";

        /// <summary>
        /// R2VR01.
        /// </summary>
        public const string R2VR01 = "R2VR01";

        /// <summary>
        /// R2PALC.
        /// </summary>
        public const string R2PALC = "R2PALC";

        /// <summary>
        /// R2MORD.
        /// </summary>
        public const string R2MORD = "R2MORD";

        /// <summary>
        /// R2RLIT.
        /// </summary>
        public const string R2RLIT = "R2RLIT";

        /// <summary>
        /// R2KTLN.
        /// </summary>
        public const string R2KTLN = "R2KTLN";

        /// <summary>
        /// R2CPNT.
        /// </summary>
        public const string R2CPNT = "R2CPNT";

        /// <summary>
        /// R2RKIT.
        /// </summary>
        public const string R2RKIT = "R2RKIT";

        /// <summary>
        /// R2KTP.
        /// </summary>
        public const string R2KTP = "R2KTP";

        /// <summary>
        /// R2KTBL.
        /// </summary>
        public const string R2KTBL = "R2KTBL";

        /// <summary>
        /// R2PTPH.
        /// </summary>
        public const string R2PTPH = "R2PTPH";

        /// <summary>
        /// R2ZIP.
        /// </summary>
        public const string R2ZIP = "R2ZIP";

        /// <summary>
        /// R2SRP1.
        /// </summary>
        public const string R2SRP1 = "R2SRP1";

        /// <summary>
        /// R2SRP2.
        /// </summary>
        public const string R2SRP2 = "R2SRP2";

        /// <summary>
        /// R2SRP3.
        /// </summary>
        public const string R2SRP3 = "R2SRP3";

        /// <summary>
        /// R2SRP4.
        /// </summary>
        public const string R2SRP4 = "R2SRP4";

        /// <summary>
        /// R2SRP5.
        /// </summary>
        public const string R2SRP5 = "R2SRP5";

        /// <summary>
        /// R2PRP6.
        /// </summary>
        public const string R2PRP6 = "R2PRP6";

        /// <summary>
        /// R2PRP7.
        /// </summary>
        public const string R2PRP7 = "R2PRP7";

        /// <summary>
        /// R2PRP8.
        /// </summary>
        public const string R2PRP8 = "R2PRP8";

        /// <summary>
        /// R2PRP9.
        /// </summary>
        public const string R2PRP9 = "R2PRP9";

        /// <summary>
        /// R2MPUT.
        /// </summary>
        public const string R2MPUT = "R2MPUT";

        /// <summary>
        /// R2PUTP.
        /// </summary>
        public const string R2PUTP = "R2PUTP";

        /// <summary>
        /// R2SEQ.
        /// </summary>
        public const string R2SEQ = "R2SEQ";

        /// <summary>
        /// R2RCDJ.
        /// </summary>
        public const string R2RCDJ = "R2RCDJ";

        /// <summary>
        /// R2TRDJ.
        /// </summary>
        public const string R2TRDJ = "R2TRDJ";

        /// <summary>
        /// R2DRQJ.
        /// </summary>
        public const string R2DRQJ = "R2DRQJ";

        /// <summary>
        /// R2PDDJ.
        /// </summary>
        public const string R2PDDJ = "R2PDDJ";

        /// <summary>
        /// R2PACK.
        /// </summary>
        public const string R2PACK = "R2PACK";

        /// <summary>
        /// R2RPCK.
        /// </summary>
        public const string R2RPCK = "R2RPCK";

        /// <summary>
        /// R2EKEY.
        /// </summary>
        public const string R2EKEY = "R2EKEY";

        /// <summary>
        /// R2CODR.
        /// </summary>
        public const string R2CODR = "R2CODR";

        /// <summary>
        /// R2PSTB.
        /// </summary>
        public const string R2PSTB = "R2PSTB";

        /// <summary>
        /// R2RESX.
        /// </summary>
        public const string R2RESX = "R2RESX";

        /// <summary>
        /// R2PZON.
        /// </summary>
        public const string R2PZON = "R2PZON";

        /// <summary>
        /// R2KZON.
        /// </summary>
        public const string R2KZON = "R2KZON";

        /// <summary>
        /// R2ZONR.
        /// </summary>
        public const string R2ZONR = "R2ZONR";

        /// <summary>
        /// R2AISL.
        /// </summary>
        public const string R2AISL = "R2AISL";

        /// <summary>
        /// R2BIN.
        /// </summary>
        public const string R2BIN = "R2BIN";

        /// <summary>
        /// R2LA03.
        /// </summary>
        public const string R2LA03 = "R2LA03";

        /// <summary>
        /// R2LA04.
        /// </summary>
        public const string R2LA04 = "R2LA04";

        /// <summary>
        /// R2LA05.
        /// </summary>
        public const string R2LA05 = "R2LA05";

        /// <summary>
        /// R2LA06.
        /// </summary>
        public const string R2LA06 = "R2LA06";

        /// <summary>
        /// R2LA07.
        /// </summary>
        public const string R2LA07 = "R2LA07";

        /// <summary>
        /// R2LA08.
        /// </summary>
        public const string R2LA08 = "R2LA08";

        /// <summary>
        /// R2LA09.
        /// </summary>
        public const string R2LA09 = "R2LA09";

        /// <summary>
        /// R2LA10.
        /// </summary>
        public const string R2LA10 = "R2LA10";

        /// <summary>
        /// R2WSQP.
        /// </summary>
        public const string R2WSQP = "R2WSQP";

        /// <summary>
        /// R2WSQQ.
        /// </summary>
        public const string R2WSQQ = "R2WSQQ";

        /// <summary>
        /// R2WSQR.
        /// </summary>
        public const string R2WSQR = "R2WSQR";

        /// <summary>
        /// R2MMTH.
        /// </summary>
        public const string R2MMTH = "R2MMTH";

        /// <summary>
        /// R2AN8.
        /// </summary>
        public const string R2AN8 = "R2AN8";

        /// <summary>
        /// R2SHAN.
        /// </summary>
        public const string R2SHAN = "R2SHAN";

        /// <summary>
        /// R2LNTY.
        /// </summary>
        public const string R2LNTY = "R2LNTY";

        /// <summary>
        /// R2PRIO.
        /// </summary>
        public const string R2PRIO = "R2PRIO";

        /// <summary>
        /// R2CARS.
        /// </summary>
        public const string R2CARS = "R2CARS";

        /// <summary>
        /// R2ROUT.
        /// </summary>
        public const string R2ROUT = "R2ROUT";

        /// <summary>
        /// R2STOP.
        /// </summary>
        public const string R2STOP = "R2STOP";

        /// <summary>
        /// R2ZON.
        /// </summary>
        public const string R2ZON = "R2ZON";

        /// <summary>
        /// R2CTNF.
        /// </summary>
        public const string R2CTNF = "R2CTNF";

        /// <summary>
        /// R2VSUG.
        /// </summary>
        public const string R2VSUG = "R2VSUG";

        /// <summary>
        /// R2PHAS.
        /// </summary>
        public const string R2PHAS = "R2PHAS";

        /// <summary>
        /// R2RSBT.
        /// </summary>
        public const string R2RSBT = "R2RSBT";

        /// <summary>
        /// R2RSSQ.
        /// </summary>
        public const string R2RSSQ = "R2RSSQ";

        /// <summary>
        /// R2IUSE.
        /// </summary>
        public const string R2IUSE = "R2IUSE";

        /// <summary>
        /// R2TREX.
        /// </summary>
        public const string R2TREX = "R2TREX";

        /// <summary>
        /// R2DTCR.
        /// </summary>
        public const string R2DTCR = "R2DTCR";

        /// <summary>
        /// R2TMCR.
        /// </summary>
        public const string R2TMCR = "R2TMCR";

        /// <summary>
        /// R2DTPT.
        /// </summary>
        public const string R2DTPT = "R2DTPT";

        /// <summary>
        /// R2TMPT.
        /// </summary>
        public const string R2TMPT = "R2TMPT";

        /// <summary>
        /// R2TRPR.
        /// </summary>
        public const string R2TRPR = "R2TRPR";

        /// <summary>
        /// R2URCD.
        /// </summary>
        public const string R2URCD = "R2URCD";

        /// <summary>
        /// R2URDT.
        /// </summary>
        public const string R2URDT = "R2URDT";

        /// <summary>
        /// R2URAT.
        /// </summary>
        public const string R2URAT = "R2URAT";

        /// <summary>
        /// R2URAB.
        /// </summary>
        public const string R2URAB = "R2URAB";

        /// <summary>
        /// R2URRF.
        /// </summary>
        public const string R2URRF = "R2URRF";

        /// <summary>
        /// R2RCDS.
        /// </summary>
        public const string R2RCDS = "R2RCDS";

        /// <summary>
        /// R2USER.
        /// </summary>
        public const string R2USER = "R2USER";

        /// <summary>
        /// R2PID.
        /// </summary>
        public const string R2PID = "R2PID";

        /// <summary>
        /// R2JOBN.
        /// </summary>
        public const string R2JOBN = "R2JOBN";

        /// <summary>
        /// R2UPMJ.
        /// </summary>
        public const string R2UPMJ = "R2UPMJ";

        /// <summary>
        /// R2TDAY.
        /// </summary>
        public const string R2TDAY = "R2TDAY";

        /// <summary>
        /// R2UKID.
        /// </summary>
        public const string R2UKID = "R2UKID";

        /// <summary>
        /// R2CKID.
        /// </summary>
        public const string R2CKID = "R2CKID";

        /// <summary>
        /// R2VR03.
        /// </summary>
        public const string R2VR03 = "R2VR03";

        /// <summary>
        /// R2SHPN.
        /// </summary>
        public const string R2SHPN = "R2SHPN";

        /// <summary>
        /// R2LDNM.
        /// </summary>
        public const string R2LDNM = "R2LDNM";

        /// <summary>
        /// R2VMCU.
        /// </summary>
        public const string R2VMCU = "R2VMCU";

        /// <summary>
        /// R2PLPNU.
        /// </summary>
        public const string R2PLPNU = "R2PLPNU";

        /// <summary>
        /// R2LPNUF.
        /// </summary>
        public const string R2LPNUF = "R2LPNUF";

        /// <summary>
        /// R2LPNUT.
        /// </summary>
        public const string R2LPNUT = "R2LPNUT";

        /// <summary>
        /// R2PSJOBNO.
        /// </summary>
        public const string R2PSJOBNO = "R2PSJOBNO";

        /// <summary>
        /// R2JOBSQ.
        /// </summary>
        public const string R2JOBSQ = "R2JOBSQ";

        /// <summary>
        /// R2DELBATCH.
        /// </summary>
        public const string R2DELBATCH = "R2DELBATCH";
    }

    /// <inheritdoc />
    public override string TableName => "F4611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R2TYFL", "R2TYFL", JdeDataType.String, 2),
        new JdeField("R2OCDE", "R2OCDE", JdeDataType.String, 4),
        new JdeField("R2RQBT", "R2RQBT", JdeDataType.Numeric),
        new JdeField("R2RQSQ", "R2RQSQ", JdeDataType.Numeric),
        new JdeField("R2SGBT", "R2SGBT", JdeDataType.Numeric, null, true, true),
        new JdeField("R2SGSQ", "R2SGSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("R2PWAV", "R2PWAV", JdeDataType.Numeric),
        new JdeField("R2PTSK", "R2PTSK", JdeDataType.Numeric),
        new JdeField("R2TRIP", "R2TRIP", JdeDataType.Numeric),
        new JdeField("R2MCU", "R2MCU", JdeDataType.String, 24),
        new JdeField("R2KCOO", "R2KCOO", JdeDataType.String, 10),
        new JdeField("R2DOCO", "R2DOCO", JdeDataType.Numeric),
        new JdeField("R2DCTO", "R2DCTO", JdeDataType.String, 4),
        new JdeField("R2LNID", "R2LNID", JdeDataType.Numeric),
        new JdeField("R2NLIN", "R2NLIN", JdeDataType.Numeric),
        new JdeField("R2SFXO", "R2SFXO", JdeDataType.String, 6),
        new JdeField("R2CLID", "R2CLID", JdeDataType.Numeric),
        new JdeField("R2ITM", "R2ITM", JdeDataType.Numeric),
        new JdeField("R2LITM", "R2LITM", JdeDataType.String, 50),
        new JdeField("R2AITM", "R2AITM", JdeDataType.String, 50),
        new JdeField("R2UML1", "R2UML1", JdeDataType.String, 4),
        new JdeField("R2TQL1", "R2TQL1", JdeDataType.Numeric),
        new JdeField("R2EQL1", "R2EQL1", JdeDataType.String, 10),
        new JdeField("R2UML2", "R2UML2", JdeDataType.String, 4),
        new JdeField("R2QPL2", "R2QPL2", JdeDataType.Numeric),
        new JdeField("R2TQL2", "R2TQL2", JdeDataType.Numeric),
        new JdeField("R2EQL2", "R2EQL2", JdeDataType.String, 10),
        new JdeField("R2UML3", "R2UML3", JdeDataType.String, 4),
        new JdeField("R2QPL3", "R2QPL3", JdeDataType.Numeric),
        new JdeField("R2TQL3", "R2TQL3", JdeDataType.Numeric),
        new JdeField("R2EQL3", "R2EQL3", JdeDataType.String, 10),
        new JdeField("R2UML4", "R2UML4", JdeDataType.String, 4),
        new JdeField("R2QPL4", "R2QPL4", JdeDataType.Numeric),
        new JdeField("R2TQL4", "R2TQL4", JdeDataType.Numeric),
        new JdeField("R2EQL4", "R2EQL4", JdeDataType.String, 10),
        new JdeField("R2CPNB", "R2CPNB", JdeDataType.Numeric),
        new JdeField("R2UML5", "R2UML5", JdeDataType.String, 4),
        new JdeField("R2QPL5", "R2QPL5", JdeDataType.Numeric),
        new JdeField("R2TQL5", "R2TQL5", JdeDataType.Numeric),
        new JdeField("R2EQL5", "R2EQL5", JdeDataType.String, 10),
        new JdeField("R2UOM1", "R2UOM1", JdeDataType.String, 4),
        new JdeField("R2TQTY", "R2TQTY", JdeDataType.Numeric),
        new JdeField("R2CUBE", "R2CUBE", JdeDataType.Numeric),
        new JdeField("R2VUMD", "R2VUMD", JdeDataType.String, 4),
        new JdeField("R2WEIT", "R2WEIT", JdeDataType.Numeric),
        new JdeField("R2UWUM", "R2UWUM", JdeDataType.String, 4),
        new JdeField("R2LDFS", "R2LDFS", JdeDataType.Numeric),
        new JdeField("R2FLOC", "R2FLOC", JdeDataType.String, 40),
        new JdeField("R2FLOT", "R2FLOT", JdeDataType.String, 60),
        new JdeField("R2STNF", "R2STNF", JdeDataType.Numeric),
        new JdeField("R2LDTS", "R2LDTS", JdeDataType.Numeric),
        new JdeField("R2TLOC", "R2TLOC", JdeDataType.String, 40),
        new JdeField("R2TLOT", "R2TLOT", JdeDataType.String, 60),
        new JdeField("R2STNT", "R2STNT", JdeDataType.Numeric),
        new JdeField("R2LOTP", "R2LOTP", JdeDataType.Numeric),
        new JdeField("R2LOTG", "R2LOTG", JdeDataType.String, 6),
        new JdeField("R2MERG", "R2MERG", JdeDataType.String, 2),
        new JdeField("R2EQTY", "R2EQTY", JdeDataType.String, 10),
        new JdeField("R2CRMT", "R2CRMT", JdeDataType.String, 2),
        new JdeField("R2BACK", "R2BACK", JdeDataType.String, 2),
        new JdeField("R2APTS", "R2APTS", JdeDataType.String, 2),
        new JdeField("R2COMM", "R2COMM", JdeDataType.String, 2),
        new JdeField("R2ITCM", "R2ITCM", JdeDataType.String, 2),
        new JdeField("R2DSC1", "R2DSC1", JdeDataType.String, 60),
        new JdeField("R2DSC2", "R2DSC2", JdeDataType.String, 60),
        new JdeField("R2INMG", "R2INMG", JdeDataType.String, 20),
        new JdeField("R2VR01", "R2VR01", JdeDataType.String, 50),
        new JdeField("R2PALC", "R2PALC", JdeDataType.String, 2),
        new JdeField("R2MORD", "R2MORD", JdeDataType.String, 2),
        new JdeField("R2RLIT", "R2RLIT", JdeDataType.String, 16),
        new JdeField("R2KTLN", "R2KTLN", JdeDataType.Numeric),
        new JdeField("R2CPNT", "R2CPNT", JdeDataType.Numeric),
        new JdeField("R2RKIT", "R2RKIT", JdeDataType.Numeric),
        new JdeField("R2KTP", "R2KTP", JdeDataType.Numeric),
        new JdeField("R2KTBL", "R2KTBL", JdeDataType.String, 2),
        new JdeField("R2PTPH", "R2PTPH", JdeDataType.String, 2),
        new JdeField("R2ZIP", "R2ZIP", JdeDataType.String, 24),
        new JdeField("R2SRP1", "R2SRP1", JdeDataType.String, 6),
        new JdeField("R2SRP2", "R2SRP2", JdeDataType.String, 6),
        new JdeField("R2SRP3", "R2SRP3", JdeDataType.String, 6),
        new JdeField("R2SRP4", "R2SRP4", JdeDataType.String, 6),
        new JdeField("R2SRP5", "R2SRP5", JdeDataType.String, 6),
        new JdeField("R2PRP6", "R2PRP6", JdeDataType.String, 12),
        new JdeField("R2PRP7", "R2PRP7", JdeDataType.String, 12),
        new JdeField("R2PRP8", "R2PRP8", JdeDataType.String, 12),
        new JdeField("R2PRP9", "R2PRP9", JdeDataType.String, 12),
        new JdeField("R2MPUT", "R2MPUT", JdeDataType.String, 12),
        new JdeField("R2PUTP", "R2PUTP", JdeDataType.String, 2),
        new JdeField("R2SEQ", "R2SEQ", JdeDataType.Numeric),
        new JdeField("R2RCDJ", "R2RCDJ", JdeDataType.Numeric),
        new JdeField("R2TRDJ", "R2TRDJ", JdeDataType.Numeric),
        new JdeField("R2DRQJ", "R2DRQJ", JdeDataType.Numeric),
        new JdeField("R2PDDJ", "R2PDDJ", JdeDataType.Numeric),
        new JdeField("R2PACK", "R2PACK", JdeDataType.String, 8),
        new JdeField("R2RPCK", "R2RPCK", JdeDataType.String, 2),
        new JdeField("R2EKEY", "R2EKEY", JdeDataType.String, 8),
        new JdeField("R2CODR", "R2CODR", JdeDataType.String, 6),
        new JdeField("R2PSTB", "R2PSTB", JdeDataType.String, 6),
        new JdeField("R2RESX", "R2RESX", JdeDataType.String, 2),
        new JdeField("R2PZON", "R2PZON", JdeDataType.String, 12),
        new JdeField("R2KZON", "R2KZON", JdeDataType.String, 12),
        new JdeField("R2ZONR", "R2ZONR", JdeDataType.String, 12),
        new JdeField("R2AISL", "R2AISL", JdeDataType.String, 16),
        new JdeField("R2BIN", "R2BIN", JdeDataType.String, 16),
        new JdeField("R2LA03", "R2LA03", JdeDataType.String, 8),
        new JdeField("R2LA04", "R2LA04", JdeDataType.String, 8),
        new JdeField("R2LA05", "R2LA05", JdeDataType.String, 8),
        new JdeField("R2LA06", "R2LA06", JdeDataType.String, 8),
        new JdeField("R2LA07", "R2LA07", JdeDataType.String, 8),
        new JdeField("R2LA08", "R2LA08", JdeDataType.String, 8),
        new JdeField("R2LA09", "R2LA09", JdeDataType.String, 8),
        new JdeField("R2LA10", "R2LA10", JdeDataType.String, 8),
        new JdeField("R2WSQP", "R2WSQP", JdeDataType.Numeric),
        new JdeField("R2WSQQ", "R2WSQQ", JdeDataType.Numeric),
        new JdeField("R2WSQR", "R2WSQR", JdeDataType.Numeric),
        new JdeField("R2MMTH", "R2MMTH", JdeDataType.String, 8),
        new JdeField("R2AN8", "R2AN8", JdeDataType.Numeric),
        new JdeField("R2SHAN", "R2SHAN", JdeDataType.Numeric),
        new JdeField("R2LNTY", "R2LNTY", JdeDataType.String, 4),
        new JdeField("R2PRIO", "R2PRIO", JdeDataType.String, 2),
        new JdeField("R2CARS", "R2CARS", JdeDataType.Numeric),
        new JdeField("R2ROUT", "R2ROUT", JdeDataType.String, 6),
        new JdeField("R2STOP", "R2STOP", JdeDataType.String, 6),
        new JdeField("R2ZON", "R2ZON", JdeDataType.String, 6),
        new JdeField("R2CTNF", "R2CTNF", JdeDataType.String, 2),
        new JdeField("R2VSUG", "R2VSUG", JdeDataType.String, 2),
        new JdeField("R2PHAS", "R2PHAS", JdeDataType.String, 2),
        new JdeField("R2RSBT", "R2RSBT", JdeDataType.Numeric),
        new JdeField("R2RSSQ", "R2RSSQ", JdeDataType.Numeric),
        new JdeField("R2IUSE", "R2IUSE", JdeDataType.String, 2),
        new JdeField("R2TREX", "R2TREX", JdeDataType.String, 60),
        new JdeField("R2DTCR", "R2DTCR", JdeDataType.Numeric),
        new JdeField("R2TMCR", "R2TMCR", JdeDataType.Numeric),
        new JdeField("R2DTPT", "R2DTPT", JdeDataType.Numeric),
        new JdeField("R2TMPT", "R2TMPT", JdeDataType.Numeric),
        new JdeField("R2TRPR", "R2TRPR", JdeDataType.Numeric),
        new JdeField("R2URCD", "R2URCD", JdeDataType.String, 4),
        new JdeField("R2URDT", "R2URDT", JdeDataType.Numeric),
        new JdeField("R2URAT", "R2URAT", JdeDataType.Numeric),
        new JdeField("R2URAB", "R2URAB", JdeDataType.Numeric),
        new JdeField("R2URRF", "R2URRF", JdeDataType.String, 30),
        new JdeField("R2RCDS", "R2RCDS", JdeDataType.String, 2),
        new JdeField("R2USER", "R2USER", JdeDataType.String, 20),
        new JdeField("R2PID", "R2PID", JdeDataType.String, 20),
        new JdeField("R2JOBN", "R2JOBN", JdeDataType.String, 20),
        new JdeField("R2UPMJ", "R2UPMJ", JdeDataType.Numeric),
        new JdeField("R2TDAY", "R2TDAY", JdeDataType.Numeric),
        new JdeField("R2UKID", "R2UKID", JdeDataType.Numeric),
        new JdeField("R2CKID", "R2CKID", JdeDataType.Numeric),
        new JdeField("R2VR03", "R2VR03", JdeDataType.String, 50),
        new JdeField("R2SHPN", "R2SHPN", JdeDataType.Numeric),
        new JdeField("R2LDNM", "R2LDNM", JdeDataType.Numeric),
        new JdeField("R2VMCU", "R2VMCU", JdeDataType.String, 24),
        new JdeField("R2PLPNU", "R2PLPNU", JdeDataType.String, 80),
        new JdeField("R2LPNUF", "R2LPNUF", JdeDataType.String, 80),
        new JdeField("R2LPNUT", "R2LPNUT", JdeDataType.String, 80),
        new JdeField("R2PSJOBNO", "R2PSJOBNO", JdeDataType.String, 30),
        new JdeField("R2JOBSQ", "R2JOBSQ", JdeDataType.String, 30),
        new JdeField("R2DELBATCH", "R2DELBATCH", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4611_0", "Primary Key on R2SGBT, R2SGSQ", new[] { "R2SGBT", "R2SGSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4611_10", "Index on R2TYFL, R2OCDE, R2MCU, R2ITM, R2FLOC, R2FLOT, R2PSTB", new[] { "R2TYFL", "R2OCDE", "R2MCU", "R2ITM", "R2FLOC", "R2FLOT", "R2PSTB" }),
        new JdeIndex("F4611_11", "Index on R2UKID, R2FLOT, R2CKID", new[] { "R2UKID", "R2FLOT", "R2CKID" }),
        new JdeIndex("F4611_12", "Index on R2MCU, R2ITM, R2FLOC, R2FLOT", new[] { "R2MCU", "R2ITM", "R2FLOC", "R2FLOT" }),
        new JdeIndex("F4611_13", "Index on R2MCU, R2ITM, R2TLOC, R2TLOT", new[] { "R2MCU", "R2ITM", "R2TLOC", "R2TLOT" }),
        new JdeIndex("F4611_14", "Index on R2PTSK, R2TRIP", new[] { "R2PTSK", "R2TRIP" }),
        new JdeIndex("F4611_15", "Index on R2SGBT, R2PTSK, R2TRIP", new[] { "R2SGBT", "R2PTSK", "R2TRIP" }),
        new JdeIndex("F4611_16", "Index on R2SHPN, R2TYFL", new[] { "R2SHPN", "R2TYFL" }),
        new JdeIndex("F4611_17", "Index on R2SHPN, R2PSJOBNO, R2JOBSQ", new[] { "R2SHPN", "R2PSJOBNO", "R2JOBSQ" }),
        new JdeIndex("F4611_2", "Index on R2TYFL, R2OCDE, R2MCU, R2ITM, R2PSTB", new[] { "R2TYFL", "R2OCDE", "R2MCU", "R2ITM", "R2PSTB" }),
        new JdeIndex("F4611_4", "Index on R2RQBT, R2RQSQ", new[] { "R2RQBT", "R2RQSQ" }),
        new JdeIndex("F4611_7", "Index on R2TYFL, R2DOCO, R2DCTO, R2KCOO, R2CLID", new[] { "R2TYFL", "R2DOCO", "R2DCTO", "R2KCOO", "R2CLID" }),
        new JdeIndex("F4611_8", "Index on R2TYFL, R2DOCO, R2DCTO, R2KCOO, R2LNID, R2NLIN, R2SFXO, R2PTSK, R2TRIP", new[] { "R2TYFL", "R2DOCO", "R2DCTO", "R2KCOO", "R2LNID", "R2NLIN", "R2SFXO", "R2PTSK", "R2TRIP" }),
        new JdeIndex("F4611_9", "Index on R2TYFL, R2PSTB, R2PTSK, R2TRIP", new[] { "R2TYFL", "R2PSTB", "R2PTSK", "R2TRIP" })
    };
}
