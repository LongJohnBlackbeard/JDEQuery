using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI521 - .
/// </summary>
public class F42UI521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S9SEQ.
        /// </summary>
        public const string S9SEQ = "S9SEQ";

        /// <summary>
        /// S9DOCO.
        /// </summary>
        public const string S9DOCO = "S9DOCO";

        /// <summary>
        /// S9KCOO.
        /// </summary>
        public const string S9KCOO = "S9KCOO";

        /// <summary>
        /// S9DCTO.
        /// </summary>
        public const string S9DCTO = "S9DCTO";

        /// <summary>
        /// S9LNID.
        /// </summary>
        public const string S9LNID = "S9LNID";

        /// <summary>
        /// S9MCU.
        /// </summary>
        public const string S9MCU = "S9MCU";

        /// <summary>
        /// S9CO.
        /// </summary>
        public const string S9CO = "S9CO";

        /// <summary>
        /// S9OKCO.
        /// </summary>
        public const string S9OKCO = "S9OKCO";

        /// <summary>
        /// S9OCTO.
        /// </summary>
        public const string S9OCTO = "S9OCTO";

        /// <summary>
        /// S9OORN.
        /// </summary>
        public const string S9OORN = "S9OORN";

        /// <summary>
        /// S9OGNO.
        /// </summary>
        public const string S9OGNO = "S9OGNO";

        /// <summary>
        /// S9RKCO.
        /// </summary>
        public const string S9RKCO = "S9RKCO";

        /// <summary>
        /// S9RORN.
        /// </summary>
        public const string S9RORN = "S9RORN";

        /// <summary>
        /// S9RCTO.
        /// </summary>
        public const string S9RCTO = "S9RCTO";

        /// <summary>
        /// S9RLLN.
        /// </summary>
        public const string S9RLLN = "S9RLLN";

        /// <summary>
        /// S9AN8.
        /// </summary>
        public const string S9AN8 = "S9AN8";

        /// <summary>
        /// S9SHAN.
        /// </summary>
        public const string S9SHAN = "S9SHAN";

        /// <summary>
        /// S9PA8.
        /// </summary>
        public const string S9PA8 = "S9PA8";

        /// <summary>
        /// S9DRQJ.
        /// </summary>
        public const string S9DRQJ = "S9DRQJ";

        /// <summary>
        /// S9TRDJ.
        /// </summary>
        public const string S9TRDJ = "S9TRDJ";

        /// <summary>
        /// S9PDDJ.
        /// </summary>
        public const string S9PDDJ = "S9PDDJ";

        /// <summary>
        /// S9OPDJ.
        /// </summary>
        public const string S9OPDJ = "S9OPDJ";

        /// <summary>
        /// S9ADDJ.
        /// </summary>
        public const string S9ADDJ = "S9ADDJ";

        /// <summary>
        /// S9RSDJ.
        /// </summary>
        public const string S9RSDJ = "S9RSDJ";

        /// <summary>
        /// S9PEFJ.
        /// </summary>
        public const string S9PEFJ = "S9PEFJ";

        /// <summary>
        /// S9PPDJ.
        /// </summary>
        public const string S9PPDJ = "S9PPDJ";

        /// <summary>
        /// S9VR01.
        /// </summary>
        public const string S9VR01 = "S9VR01";

        /// <summary>
        /// S9ITM.
        /// </summary>
        public const string S9ITM = "S9ITM";

        /// <summary>
        /// S9LITM.
        /// </summary>
        public const string S9LITM = "S9LITM";

        /// <summary>
        /// S9AITM.
        /// </summary>
        public const string S9AITM = "S9AITM";

        /// <summary>
        /// S9LOCN.
        /// </summary>
        public const string S9LOCN = "S9LOCN";

        /// <summary>
        /// S9LOTN.
        /// </summary>
        public const string S9LOTN = "S9LOTN";

        /// <summary>
        /// S9FRGD.
        /// </summary>
        public const string S9FRGD = "S9FRGD";

        /// <summary>
        /// S9THGD.
        /// </summary>
        public const string S9THGD = "S9THGD";

        /// <summary>
        /// S9FRMP.
        /// </summary>
        public const string S9FRMP = "S9FRMP";

        /// <summary>
        /// S9THRP.
        /// </summary>
        public const string S9THRP = "S9THRP";

        /// <summary>
        /// S9EXDP.
        /// </summary>
        public const string S9EXDP = "S9EXDP";

        /// <summary>
        /// S9DSC1.
        /// </summary>
        public const string S9DSC1 = "S9DSC1";

        /// <summary>
        /// S9DSC2.
        /// </summary>
        public const string S9DSC2 = "S9DSC2";

        /// <summary>
        /// S9LNTY.
        /// </summary>
        public const string S9LNTY = "S9LNTY";

        /// <summary>
        /// S9IVI.
        /// </summary>
        public const string S9IVI = "S9IVI";

        /// <summary>
        /// S9NXTR.
        /// </summary>
        public const string S9NXTR = "S9NXTR";

        /// <summary>
        /// S9LTTR.
        /// </summary>
        public const string S9LTTR = "S9LTTR";

        /// <summary>
        /// S9EMCU.
        /// </summary>
        public const string S9EMCU = "S9EMCU";

        /// <summary>
        /// S9RLIT.
        /// </summary>
        public const string S9RLIT = "S9RLIT";

        /// <summary>
        /// S9KTLN.
        /// </summary>
        public const string S9KTLN = "S9KTLN";

        /// <summary>
        /// S9CPNT.
        /// </summary>
        public const string S9CPNT = "S9CPNT";

        /// <summary>
        /// S9RKIT.
        /// </summary>
        public const string S9RKIT = "S9RKIT";

        /// <summary>
        /// S9KTP.
        /// </summary>
        public const string S9KTP = "S9KTP";

        /// <summary>
        /// S9SRP1.
        /// </summary>
        public const string S9SRP1 = "S9SRP1";

        /// <summary>
        /// S9SRP2.
        /// </summary>
        public const string S9SRP2 = "S9SRP2";

        /// <summary>
        /// S9SRP3.
        /// </summary>
        public const string S9SRP3 = "S9SRP3";

        /// <summary>
        /// S9SRP4.
        /// </summary>
        public const string S9SRP4 = "S9SRP4";

        /// <summary>
        /// S9SRP5.
        /// </summary>
        public const string S9SRP5 = "S9SRP5";

        /// <summary>
        /// S9PRP1.
        /// </summary>
        public const string S9PRP1 = "S9PRP1";

        /// <summary>
        /// S9PRP2.
        /// </summary>
        public const string S9PRP2 = "S9PRP2";

        /// <summary>
        /// S9PRP3.
        /// </summary>
        public const string S9PRP3 = "S9PRP3";

        /// <summary>
        /// S9PRP4.
        /// </summary>
        public const string S9PRP4 = "S9PRP4";

        /// <summary>
        /// S9PRP5.
        /// </summary>
        public const string S9PRP5 = "S9PRP5";

        /// <summary>
        /// S9UOM.
        /// </summary>
        public const string S9UOM = "S9UOM";

        /// <summary>
        /// S9UORG.
        /// </summary>
        public const string S9UORG = "S9UORG";

        /// <summary>
        /// S9SOQS.
        /// </summary>
        public const string S9SOQS = "S9SOQS";

        /// <summary>
        /// S9SOBK.
        /// </summary>
        public const string S9SOBK = "S9SOBK";

        /// <summary>
        /// S9SOCN.
        /// </summary>
        public const string S9SOCN = "S9SOCN";

        /// <summary>
        /// S9SONE.
        /// </summary>
        public const string S9SONE = "S9SONE";

        /// <summary>
        /// S9UOPN.
        /// </summary>
        public const string S9UOPN = "S9UOPN";

        /// <summary>
        /// S9QTYT.
        /// </summary>
        public const string S9QTYT = "S9QTYT";

        /// <summary>
        /// S9COMM.
        /// </summary>
        public const string S9COMM = "S9COMM";

        /// <summary>
        /// S9OTQY.
        /// </summary>
        public const string S9OTQY = "S9OTQY";

        /// <summary>
        /// S9UPRC.
        /// </summary>
        public const string S9UPRC = "S9UPRC";

        /// <summary>
        /// S9AEXP.
        /// </summary>
        public const string S9AEXP = "S9AEXP";

        /// <summary>
        /// S9PROV.
        /// </summary>
        public const string S9PROV = "S9PROV";

        /// <summary>
        /// S9APUM.
        /// </summary>
        public const string S9APUM = "S9APUM";

        /// <summary>
        /// S9LPRC.
        /// </summary>
        public const string S9LPRC = "S9LPRC";

        /// <summary>
        /// S9UNCS.
        /// </summary>
        public const string S9UNCS = "S9UNCS";

        /// <summary>
        /// S9ECST.
        /// </summary>
        public const string S9ECST = "S9ECST";

        /// <summary>
        /// S9CSTO.
        /// </summary>
        public const string S9CSTO = "S9CSTO";

        /// <summary>
        /// S9TCST.
        /// </summary>
        public const string S9TCST = "S9TCST";

        /// <summary>
        /// S9INMG.
        /// </summary>
        public const string S9INMG = "S9INMG";

        /// <summary>
        /// S9PTC.
        /// </summary>
        public const string S9PTC = "S9PTC";

        /// <summary>
        /// S9RYIN.
        /// </summary>
        public const string S9RYIN = "S9RYIN";

        /// <summary>
        /// S9TRDC.
        /// </summary>
        public const string S9TRDC = "S9TRDC";

        /// <summary>
        /// S9ASN.
        /// </summary>
        public const string S9ASN = "S9ASN";

        /// <summary>
        /// S9PRGR.
        /// </summary>
        public const string S9PRGR = "S9PRGR";

        /// <summary>
        /// S9CLVL.
        /// </summary>
        public const string S9CLVL = "S9CLVL";

        /// <summary>
        /// S9PSN.
        /// </summary>
        public const string S9PSN = "S9PSN";

        /// <summary>
        /// S9TAX1.
        /// </summary>
        public const string S9TAX1 = "S9TAX1";

        /// <summary>
        /// S9TXA1.
        /// </summary>
        public const string S9TXA1 = "S9TXA1";

        /// <summary>
        /// S9EXR1.
        /// </summary>
        public const string S9EXR1 = "S9EXR1";

        /// <summary>
        /// S9ATXT.
        /// </summary>
        public const string S9ATXT = "S9ATXT";

        /// <summary>
        /// S9PRIO.
        /// </summary>
        public const string S9PRIO = "S9PRIO";

        /// <summary>
        /// S9RESL.
        /// </summary>
        public const string S9RESL = "S9RESL";

        /// <summary>
        /// S9BACK.
        /// </summary>
        public const string S9BACK = "S9BACK";

        /// <summary>
        /// S9SBAL.
        /// </summary>
        public const string S9SBAL = "S9SBAL";

        /// <summary>
        /// S9APTS.
        /// </summary>
        public const string S9APTS = "S9APTS";

        /// <summary>
        /// S9CDCD.
        /// </summary>
        public const string S9CDCD = "S9CDCD";

        /// <summary>
        /// S9ROUT.
        /// </summary>
        public const string S9ROUT = "S9ROUT";

        /// <summary>
        /// S9STOP.
        /// </summary>
        public const string S9STOP = "S9STOP";

        /// <summary>
        /// S9UOM1.
        /// </summary>
        public const string S9UOM1 = "S9UOM1";

        /// <summary>
        /// S9PQOR.
        /// </summary>
        public const string S9PQOR = "S9PQOR";

        /// <summary>
        /// S9UOM2.
        /// </summary>
        public const string S9UOM2 = "S9UOM2";

        /// <summary>
        /// S9SQOR.
        /// </summary>
        public const string S9SQOR = "S9SQOR";

        /// <summary>
        /// S9UOM4.
        /// </summary>
        public const string S9UOM4 = "S9UOM4";

        /// <summary>
        /// S9ITWT.
        /// </summary>
        public const string S9ITWT = "S9ITWT";

        /// <summary>
        /// S9WTUM.
        /// </summary>
        public const string S9WTUM = "S9WTUM";

        /// <summary>
        /// S9ITVL.
        /// </summary>
        public const string S9ITVL = "S9ITVL";

        /// <summary>
        /// S9VLUM.
        /// </summary>
        public const string S9VLUM = "S9VLUM";

        /// <summary>
        /// S9CMGL.
        /// </summary>
        public const string S9CMGL = "S9CMGL";

        /// <summary>
        /// S9STTS.
        /// </summary>
        public const string S9STTS = "S9STTS";

        /// <summary>
        /// S9SO01.
        /// </summary>
        public const string S9SO01 = "S9SO01";

        /// <summary>
        /// S9SO02.
        /// </summary>
        public const string S9SO02 = "S9SO02";

        /// <summary>
        /// S9RCD.
        /// </summary>
        public const string S9RCD = "S9RCD";

        /// <summary>
        /// S9GRWT.
        /// </summary>
        public const string S9GRWT = "S9GRWT";

        /// <summary>
        /// S9GWUM.
        /// </summary>
        public const string S9GWUM = "S9GWUM";

        /// <summary>
        /// S9SBL.
        /// </summary>
        public const string S9SBL = "S9SBL";

        /// <summary>
        /// S9SBLT.
        /// </summary>
        public const string S9SBLT = "S9SBLT";

        /// <summary>
        /// S9CRCD.
        /// </summary>
        public const string S9CRCD = "S9CRCD";

        /// <summary>
        /// S9CRR.
        /// </summary>
        public const string S9CRR = "S9CRR";

        /// <summary>
        /// S9FPRC.
        /// </summary>
        public const string S9FPRC = "S9FPRC";

        /// <summary>
        /// S9FUP.
        /// </summary>
        public const string S9FUP = "S9FUP";

        /// <summary>
        /// S9FEA.
        /// </summary>
        public const string S9FEA = "S9FEA";

        /// <summary>
        /// S9FUC.
        /// </summary>
        public const string S9FUC = "S9FUC";

        /// <summary>
        /// S9FEC.
        /// </summary>
        public const string S9FEC = "S9FEC";

        /// <summary>
        /// S9TXYN.
        /// </summary>
        public const string S9TXYN = "S9TXYN";

        /// <summary>
        /// S9URCD.
        /// </summary>
        public const string S9URCD = "S9URCD";

        /// <summary>
        /// S9URDT.
        /// </summary>
        public const string S9URDT = "S9URDT";

        /// <summary>
        /// S9URAT.
        /// </summary>
        public const string S9URAT = "S9URAT";

        /// <summary>
        /// S9URAB.
        /// </summary>
        public const string S9URAB = "S9URAB";

        /// <summary>
        /// S9URRF.
        /// </summary>
        public const string S9URRF = "S9URRF";

        /// <summary>
        /// S9USER.
        /// </summary>
        public const string S9USER = "S9USER";

        /// <summary>
        /// S9PID.
        /// </summary>
        public const string S9PID = "S9PID";

        /// <summary>
        /// S9JOBN.
        /// </summary>
        public const string S9JOBN = "S9JOBN";

        /// <summary>
        /// S9UPMJ.
        /// </summary>
        public const string S9UPMJ = "S9UPMJ";

        /// <summary>
        /// S9TDAY.
        /// </summary>
        public const string S9TDAY = "S9TDAY";

        /// <summary>
        /// S9CTID.
        /// </summary>
        public const string S9CTID = "S9CTID";

        /// <summary>
        /// S9JOBS.
        /// </summary>
        public const string S9JOBS = "S9JOBS";

        /// <summary>
        /// S9KITID.
        /// </summary>
        public const string S9KITID = "S9KITID";

        /// <summary>
        /// S9KITAMTDOM.
        /// </summary>
        public const string S9KITAMTDOM = "S9KITAMTDOM";

        /// <summary>
        /// S9KITAMTFOR.
        /// </summary>
        public const string S9KITAMTFOR = "S9KITAMTFOR";

        /// <summary>
        /// S9KITDIRTY.
        /// </summary>
        public const string S9KITDIRTY = "S9KITDIRTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S9SEQ", "S9SEQ", JdeDataType.Numeric),
        new JdeField("S9DOCO", "S9DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("S9KCOO", "S9KCOO", JdeDataType.String, 10, true, true),
        new JdeField("S9DCTO", "S9DCTO", JdeDataType.String, 4, true, true),
        new JdeField("S9LNID", "S9LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("S9MCU", "S9MCU", JdeDataType.String, 24),
        new JdeField("S9CO", "S9CO", JdeDataType.String, 10),
        new JdeField("S9OKCO", "S9OKCO", JdeDataType.String, 10),
        new JdeField("S9OCTO", "S9OCTO", JdeDataType.String, 4),
        new JdeField("S9OORN", "S9OORN", JdeDataType.String, 16),
        new JdeField("S9OGNO", "S9OGNO", JdeDataType.Numeric),
        new JdeField("S9RKCO", "S9RKCO", JdeDataType.String, 10),
        new JdeField("S9RORN", "S9RORN", JdeDataType.String, 16),
        new JdeField("S9RCTO", "S9RCTO", JdeDataType.String, 4),
        new JdeField("S9RLLN", "S9RLLN", JdeDataType.Numeric),
        new JdeField("S9AN8", "S9AN8", JdeDataType.Numeric),
        new JdeField("S9SHAN", "S9SHAN", JdeDataType.Numeric),
        new JdeField("S9PA8", "S9PA8", JdeDataType.Numeric),
        new JdeField("S9DRQJ", "S9DRQJ", JdeDataType.Numeric),
        new JdeField("S9TRDJ", "S9TRDJ", JdeDataType.Numeric),
        new JdeField("S9PDDJ", "S9PDDJ", JdeDataType.Numeric),
        new JdeField("S9OPDJ", "S9OPDJ", JdeDataType.Numeric),
        new JdeField("S9ADDJ", "S9ADDJ", JdeDataType.Numeric),
        new JdeField("S9RSDJ", "S9RSDJ", JdeDataType.Numeric),
        new JdeField("S9PEFJ", "S9PEFJ", JdeDataType.Numeric),
        new JdeField("S9PPDJ", "S9PPDJ", JdeDataType.Numeric),
        new JdeField("S9VR01", "S9VR01", JdeDataType.String, 50),
        new JdeField("S9ITM", "S9ITM", JdeDataType.Numeric),
        new JdeField("S9LITM", "S9LITM", JdeDataType.String, 50),
        new JdeField("S9AITM", "S9AITM", JdeDataType.String, 50),
        new JdeField("S9LOCN", "S9LOCN", JdeDataType.String, 40),
        new JdeField("S9LOTN", "S9LOTN", JdeDataType.String, 60),
        new JdeField("S9FRGD", "S9FRGD", JdeDataType.String, 6),
        new JdeField("S9THGD", "S9THGD", JdeDataType.String, 6),
        new JdeField("S9FRMP", "S9FRMP", JdeDataType.Numeric),
        new JdeField("S9THRP", "S9THRP", JdeDataType.Numeric),
        new JdeField("S9EXDP", "S9EXDP", JdeDataType.Numeric),
        new JdeField("S9DSC1", "S9DSC1", JdeDataType.String, 60),
        new JdeField("S9DSC2", "S9DSC2", JdeDataType.String, 60),
        new JdeField("S9LNTY", "S9LNTY", JdeDataType.String, 4),
        new JdeField("S9IVI", "S9IVI", JdeDataType.String, 2),
        new JdeField("S9NXTR", "S9NXTR", JdeDataType.String, 6),
        new JdeField("S9LTTR", "S9LTTR", JdeDataType.String, 6),
        new JdeField("S9EMCU", "S9EMCU", JdeDataType.String, 24),
        new JdeField("S9RLIT", "S9RLIT", JdeDataType.String, 16),
        new JdeField("S9KTLN", "S9KTLN", JdeDataType.Numeric),
        new JdeField("S9CPNT", "S9CPNT", JdeDataType.Numeric),
        new JdeField("S9RKIT", "S9RKIT", JdeDataType.Numeric),
        new JdeField("S9KTP", "S9KTP", JdeDataType.Numeric),
        new JdeField("S9SRP1", "S9SRP1", JdeDataType.String, 6),
        new JdeField("S9SRP2", "S9SRP2", JdeDataType.String, 6),
        new JdeField("S9SRP3", "S9SRP3", JdeDataType.String, 6),
        new JdeField("S9SRP4", "S9SRP4", JdeDataType.String, 6),
        new JdeField("S9SRP5", "S9SRP5", JdeDataType.String, 6),
        new JdeField("S9PRP1", "S9PRP1", JdeDataType.String, 6),
        new JdeField("S9PRP2", "S9PRP2", JdeDataType.String, 6),
        new JdeField("S9PRP3", "S9PRP3", JdeDataType.String, 6),
        new JdeField("S9PRP4", "S9PRP4", JdeDataType.String, 6),
        new JdeField("S9PRP5", "S9PRP5", JdeDataType.String, 6),
        new JdeField("S9UOM", "S9UOM", JdeDataType.String, 4),
        new JdeField("S9UORG", "S9UORG", JdeDataType.Numeric),
        new JdeField("S9SOQS", "S9SOQS", JdeDataType.Numeric),
        new JdeField("S9SOBK", "S9SOBK", JdeDataType.Numeric),
        new JdeField("S9SOCN", "S9SOCN", JdeDataType.Numeric),
        new JdeField("S9SONE", "S9SONE", JdeDataType.Numeric),
        new JdeField("S9UOPN", "S9UOPN", JdeDataType.Numeric),
        new JdeField("S9QTYT", "S9QTYT", JdeDataType.Numeric),
        new JdeField("S9COMM", "S9COMM", JdeDataType.String, 2),
        new JdeField("S9OTQY", "S9OTQY", JdeDataType.String, 2),
        new JdeField("S9UPRC", "S9UPRC", JdeDataType.Numeric),
        new JdeField("S9AEXP", "S9AEXP", JdeDataType.Numeric),
        new JdeField("S9PROV", "S9PROV", JdeDataType.String, 2),
        new JdeField("S9APUM", "S9APUM", JdeDataType.String, 4),
        new JdeField("S9LPRC", "S9LPRC", JdeDataType.Numeric),
        new JdeField("S9UNCS", "S9UNCS", JdeDataType.Numeric),
        new JdeField("S9ECST", "S9ECST", JdeDataType.Numeric),
        new JdeField("S9CSTO", "S9CSTO", JdeDataType.String, 2),
        new JdeField("S9TCST", "S9TCST", JdeDataType.Numeric),
        new JdeField("S9INMG", "S9INMG", JdeDataType.String, 20),
        new JdeField("S9PTC", "S9PTC", JdeDataType.String, 6),
        new JdeField("S9RYIN", "S9RYIN", JdeDataType.String, 2),
        new JdeField("S9TRDC", "S9TRDC", JdeDataType.Numeric),
        new JdeField("S9ASN", "S9ASN", JdeDataType.String, 16),
        new JdeField("S9PRGR", "S9PRGR", JdeDataType.String, 16),
        new JdeField("S9CLVL", "S9CLVL", JdeDataType.String, 6),
        new JdeField("S9PSN", "S9PSN", JdeDataType.Numeric),
        new JdeField("S9TAX1", "S9TAX1", JdeDataType.String, 2),
        new JdeField("S9TXA1", "S9TXA1", JdeDataType.String, 20),
        new JdeField("S9EXR1", "S9EXR1", JdeDataType.String, 4),
        new JdeField("S9ATXT", "S9ATXT", JdeDataType.String, 2),
        new JdeField("S9PRIO", "S9PRIO", JdeDataType.String, 2),
        new JdeField("S9RESL", "S9RESL", JdeDataType.String, 2),
        new JdeField("S9BACK", "S9BACK", JdeDataType.String, 2),
        new JdeField("S9SBAL", "S9SBAL", JdeDataType.String, 2),
        new JdeField("S9APTS", "S9APTS", JdeDataType.String, 2),
        new JdeField("S9CDCD", "S9CDCD", JdeDataType.String, 30),
        new JdeField("S9ROUT", "S9ROUT", JdeDataType.String, 6),
        new JdeField("S9STOP", "S9STOP", JdeDataType.String, 6),
        new JdeField("S9UOM1", "S9UOM1", JdeDataType.String, 4),
        new JdeField("S9PQOR", "S9PQOR", JdeDataType.Numeric),
        new JdeField("S9UOM2", "S9UOM2", JdeDataType.String, 4),
        new JdeField("S9SQOR", "S9SQOR", JdeDataType.Numeric),
        new JdeField("S9UOM4", "S9UOM4", JdeDataType.String, 4),
        new JdeField("S9ITWT", "S9ITWT", JdeDataType.Numeric),
        new JdeField("S9WTUM", "S9WTUM", JdeDataType.String, 4),
        new JdeField("S9ITVL", "S9ITVL", JdeDataType.Numeric),
        new JdeField("S9VLUM", "S9VLUM", JdeDataType.String, 4),
        new JdeField("S9CMGL", "S9CMGL", JdeDataType.String, 2),
        new JdeField("S9STTS", "S9STTS", JdeDataType.String, 4),
        new JdeField("S9SO01", "S9SO01", JdeDataType.String, 2),
        new JdeField("S9SO02", "S9SO02", JdeDataType.String, 2),
        new JdeField("S9RCD", "S9RCD", JdeDataType.String, 6),
        new JdeField("S9GRWT", "S9GRWT", JdeDataType.Numeric),
        new JdeField("S9GWUM", "S9GWUM", JdeDataType.String, 4),
        new JdeField("S9SBL", "S9SBL", JdeDataType.String, 16),
        new JdeField("S9SBLT", "S9SBLT", JdeDataType.String, 2),
        new JdeField("S9CRCD", "S9CRCD", JdeDataType.String, 6),
        new JdeField("S9CRR", "S9CRR", JdeDataType.Numeric),
        new JdeField("S9FPRC", "S9FPRC", JdeDataType.Numeric),
        new JdeField("S9FUP", "S9FUP", JdeDataType.Numeric),
        new JdeField("S9FEA", "S9FEA", JdeDataType.Numeric),
        new JdeField("S9FUC", "S9FUC", JdeDataType.Numeric),
        new JdeField("S9FEC", "S9FEC", JdeDataType.Numeric),
        new JdeField("S9TXYN", "S9TXYN", JdeDataType.String, 2),
        new JdeField("S9URCD", "S9URCD", JdeDataType.String, 4),
        new JdeField("S9URDT", "S9URDT", JdeDataType.Numeric),
        new JdeField("S9URAT", "S9URAT", JdeDataType.Numeric),
        new JdeField("S9URAB", "S9URAB", JdeDataType.Numeric),
        new JdeField("S9URRF", "S9URRF", JdeDataType.String, 30),
        new JdeField("S9USER", "S9USER", JdeDataType.String, 20),
        new JdeField("S9PID", "S9PID", JdeDataType.String, 20),
        new JdeField("S9JOBN", "S9JOBN", JdeDataType.String, 20),
        new JdeField("S9UPMJ", "S9UPMJ", JdeDataType.Numeric),
        new JdeField("S9TDAY", "S9TDAY", JdeDataType.Numeric),
        new JdeField("S9CTID", "S9CTID", JdeDataType.String, 30),
        new JdeField("S9JOBS", "S9JOBS", JdeDataType.Numeric),
        new JdeField("S9KITID", "S9KITID", JdeDataType.Numeric),
        new JdeField("S9KITAMTDOM", "S9KITAMTDOM", JdeDataType.Numeric),
        new JdeField("S9KITAMTFOR", "S9KITAMTFOR", JdeDataType.Numeric),
        new JdeField("S9KITDIRTY", "S9KITDIRTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI521_0", "Primary Key on S9DOCO, S9KCOO, S9DCTO, S9LNID", new[] { "S9DOCO", "S9KCOO", "S9DCTO", "S9LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI521_1", "Index on S9SEQ, S9DOCO, S9KCOO, S9DCTO", new[] { "S9SEQ", "S9DOCO", "S9KCOO", "S9DCTO" }),
        new JdeIndex("F42UI521_3", "Index on S9DOCO, S9KCOO, S9DCTO", new[] { "S9DOCO", "S9KCOO", "S9DCTO" }),
        new JdeIndex("F42UI521_5", "Index on S9DOCO, S9DCTO, S9KCOO, S9KITID, S9LNID", new[] { "S9DOCO", "S9DCTO", "S9KCOO", "S9KITID", "S9LNID" })
    };
}
