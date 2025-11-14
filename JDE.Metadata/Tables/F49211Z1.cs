using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49211Z1 - .
/// </summary>
public class F49211Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S1EDUS.
        /// </summary>
        public const string S1EDUS = "S1EDUS";

        /// <summary>
        /// S1EDBT.
        /// </summary>
        public const string S1EDBT = "S1EDBT";

        /// <summary>
        /// S1EDTN.
        /// </summary>
        public const string S1EDTN = "S1EDTN";

        /// <summary>
        /// S1EDLN.
        /// </summary>
        public const string S1EDLN = "S1EDLN";

        /// <summary>
        /// S1EDCT.
        /// </summary>
        public const string S1EDCT = "S1EDCT";

        /// <summary>
        /// S1TYTN.
        /// </summary>
        public const string S1TYTN = "S1TYTN";

        /// <summary>
        /// S1EDFT.
        /// </summary>
        public const string S1EDFT = "S1EDFT";

        /// <summary>
        /// S1EDDT.
        /// </summary>
        public const string S1EDDT = "S1EDDT";

        /// <summary>
        /// S1DRIN.
        /// </summary>
        public const string S1DRIN = "S1DRIN";

        /// <summary>
        /// S1EDDL.
        /// </summary>
        public const string S1EDDL = "S1EDDL";

        /// <summary>
        /// S1EDSP.
        /// </summary>
        public const string S1EDSP = "S1EDSP";

        /// <summary>
        /// S1PNID.
        /// </summary>
        public const string S1PNID = "S1PNID";

        /// <summary>
        /// S1TNAC.
        /// </summary>
        public const string S1TNAC = "S1TNAC";

        /// <summary>
        /// S1DOCO.
        /// </summary>
        public const string S1DOCO = "S1DOCO";

        /// <summary>
        /// S1DCTO.
        /// </summary>
        public const string S1DCTO = "S1DCTO";

        /// <summary>
        /// S1KCOO.
        /// </summary>
        public const string S1KCOO = "S1KCOO";

        /// <summary>
        /// S1LNID.
        /// </summary>
        public const string S1LNID = "S1LNID";

        /// <summary>
        /// S1VMCU.
        /// </summary>
        public const string S1VMCU = "S1VMCU";

        /// <summary>
        /// S1TRP.
        /// </summary>
        public const string S1TRP = "S1TRP";

        /// <summary>
        /// S1LOAD.
        /// </summary>
        public const string S1LOAD = "S1LOAD";

        /// <summary>
        /// S1DSGP.
        /// </summary>
        public const string S1DSGP = "S1DSGP";

        /// <summary>
        /// S1BPFG.
        /// </summary>
        public const string S1BPFG = "S1BPFG";

        /// <summary>
        /// S1DSTN.
        /// </summary>
        public const string S1DSTN = "S1DSTN";

        /// <summary>
        /// S1UM.
        /// </summary>
        public const string S1UM = "S1UM";

        /// <summary>
        /// S1DEFF.
        /// </summary>
        public const string S1DEFF = "S1DEFF";

        /// <summary>
        /// S1DUNC.
        /// </summary>
        public const string S1DUNC = "S1DUNC";

        /// <summary>
        /// S1FDUC.
        /// </summary>
        public const string S1FDUC = "S1FDUC";

        /// <summary>
        /// S1DREV.
        /// </summary>
        public const string S1DREV = "S1DREV";

        /// <summary>
        /// S1FDRV.
        /// </summary>
        public const string S1FDRV = "S1FDRV";

        /// <summary>
        /// S1ANUM.
        /// </summary>
        public const string S1ANUM = "S1ANUM";

        /// <summary>
        /// S1SIDT.
        /// </summary>
        public const string S1SIDT = "S1SIDT";

        /// <summary>
        /// S1INCY.
        /// </summary>
        public const string S1INCY = "S1INCY";

        /// <summary>
        /// S1LDDT.
        /// </summary>
        public const string S1LDDT = "S1LDDT";

        /// <summary>
        /// S1LDTM.
        /// </summary>
        public const string S1LDTM = "S1LDTM";

        /// <summary>
        /// S1DCDT.
        /// </summary>
        public const string S1DCDT = "S1DCDT";

        /// <summary>
        /// S1PCQY.
        /// </summary>
        public const string S1PCQY = "S1PCQY";

        /// <summary>
        /// S1UOMC.
        /// </summary>
        public const string S1UOMC = "S1UOMC";

        /// <summary>
        /// S1TEMP.
        /// </summary>
        public const string S1TEMP = "S1TEMP";

        /// <summary>
        /// S1STPU.
        /// </summary>
        public const string S1STPU = "S1STPU";

        /// <summary>
        /// S1DNTY.
        /// </summary>
        public const string S1DNTY = "S1DNTY";

        /// <summary>
        /// S1DNTP.
        /// </summary>
        public const string S1DNTP = "S1DNTP";

        /// <summary>
        /// S1DETP.
        /// </summary>
        public const string S1DETP = "S1DETP";

        /// <summary>
        /// S1DTPU.
        /// </summary>
        public const string S1DTPU = "S1DTPU";

        /// <summary>
        /// S1VCF.
        /// </summary>
        public const string S1VCF = "S1VCF";

        /// <summary>
        /// S1PRAS.
        /// </summary>
        public const string S1PRAS = "S1PRAS";

        /// <summary>
        /// S1CP01.
        /// </summary>
        public const string S1CP01 = "S1CP01";

        /// <summary>
        /// S1IQTY.
        /// </summary>
        public const string S1IQTY = "S1IQTY";

        /// <summary>
        /// S1STUM.
        /// </summary>
        public const string S1STUM = "S1STUM";

        /// <summary>
        /// S1BUM6.
        /// </summary>
        public const string S1BUM6 = "S1BUM6";

        /// <summary>
        /// S1AMBR.
        /// </summary>
        public const string S1AMBR = "S1AMBR";

        /// <summary>
        /// S1BUM3.
        /// </summary>
        public const string S1BUM3 = "S1BUM3";

        /// <summary>
        /// S1WGTR.
        /// </summary>
        public const string S1WGTR = "S1WGTR";

        /// <summary>
        /// S1BUM5.
        /// </summary>
        public const string S1BUM5 = "S1BUM5";

        /// <summary>
        /// S1FRTV.
        /// </summary>
        public const string S1FRTV = "S1FRTV";

        /// <summary>
        /// S1FRTD.
        /// </summary>
        public const string S1FRTD = "S1FRTD";

        /// <summary>
        /// S1FRCC.
        /// </summary>
        public const string S1FRCC = "S1FRCC";

        /// <summary>
        /// S1FRVC.
        /// </summary>
        public const string S1FRVC = "S1FRVC";

        /// <summary>
        /// S1PVEH.
        /// </summary>
        public const string S1PVEH = "S1PVEH";

        /// <summary>
        /// S1RLNO.
        /// </summary>
        public const string S1RLNO = "S1RLNO";

        /// <summary>
        /// S1MCUR.
        /// </summary>
        public const string S1MCUR = "S1MCUR";

        /// <summary>
        /// S1FLTN.
        /// </summary>
        public const string S1FLTN = "S1FLTN";

        /// <summary>
        /// S1DSNN.
        /// </summary>
        public const string S1DSNN = "S1DSNN";

        /// <summary>
        /// S1ARCT.
        /// </summary>
        public const string S1ARCT = "S1ARCT";

        /// <summary>
        /// S1SORG.
        /// </summary>
        public const string S1SORG = "S1SORG";

        /// <summary>
        /// S1ELTM.
        /// </summary>
        public const string S1ELTM = "S1ELTM";

        /// <summary>
        /// S1PTNR.
        /// </summary>
        public const string S1PTNR = "S1PTNR";

        /// <summary>
        /// S1IAN8.
        /// </summary>
        public const string S1IAN8 = "S1IAN8";

        /// <summary>
        /// S1PTC.
        /// </summary>
        public const string S1PTC = "S1PTC";

        /// <summary>
        /// S1DOC.
        /// </summary>
        public const string S1DOC = "S1DOC";

        /// <summary>
        /// S1DCT.
        /// </summary>
        public const string S1DCT = "S1DCT";

        /// <summary>
        /// S1KCO.
        /// </summary>
        public const string S1KCO = "S1KCO";

        /// <summary>
        /// S1CRR.
        /// </summary>
        public const string S1CRR = "S1CRR";

        /// <summary>
        /// S1CRCD.
        /// </summary>
        public const string S1CRCD = "S1CRCD";

        /// <summary>
        /// S1TXA1.
        /// </summary>
        public const string S1TXA1 = "S1TXA1";

        /// <summary>
        /// S1EXR1.
        /// </summary>
        public const string S1EXR1 = "S1EXR1";

        /// <summary>
        /// S1FRDM.
        /// </summary>
        public const string S1FRDM = "S1FRDM";

        /// <summary>
        /// S1FUPT.
        /// </summary>
        public const string S1FUPT = "S1FUPT";

        /// <summary>
        /// S1RINO.
        /// </summary>
        public const string S1RINO = "S1RINO";

        /// <summary>
        /// S1GLOC.
        /// </summary>
        public const string S1GLOC = "S1GLOC";

        /// <summary>
        /// S1AUTA.
        /// </summary>
        public const string S1AUTA = "S1AUTA";

        /// <summary>
        /// S1ALPH.
        /// </summary>
        public const string S1ALPH = "S1ALPH";

        /// <summary>
        /// S1MET1.
        /// </summary>
        public const string S1MET1 = "S1MET1";

        /// <summary>
        /// S1OPN1.
        /// </summary>
        public const string S1OPN1 = "S1OPN1";

        /// <summary>
        /// S1PNR1.
        /// </summary>
        public const string S1PNR1 = "S1PNR1";

        /// <summary>
        /// S1MET2.
        /// </summary>
        public const string S1MET2 = "S1MET2";

        /// <summary>
        /// S1OPN2.
        /// </summary>
        public const string S1OPN2 = "S1OPN2";

        /// <summary>
        /// S1PNR2.
        /// </summary>
        public const string S1PNR2 = "S1PNR2";

        /// <summary>
        /// S1MET3.
        /// </summary>
        public const string S1MET3 = "S1MET3";

        /// <summary>
        /// S1OPN3.
        /// </summary>
        public const string S1OPN3 = "S1OPN3";

        /// <summary>
        /// S1PNR3.
        /// </summary>
        public const string S1PNR3 = "S1PNR3";

        /// <summary>
        /// S1ARDT.
        /// </summary>
        public const string S1ARDT = "S1ARDT";

        /// <summary>
        /// S1ARTM.
        /// </summary>
        public const string S1ARTM = "S1ARTM";

        /// <summary>
        /// S1DPDT.
        /// </summary>
        public const string S1DPDT = "S1DPDT";

        /// <summary>
        /// S1DETM.
        /// </summary>
        public const string S1DETM = "S1DETM";

        /// <summary>
        /// S1DSTJ.
        /// </summary>
        public const string S1DSTJ = "S1DSTJ";

        /// <summary>
        /// S1STM.
        /// </summary>
        public const string S1STM = "S1STM";

        /// <summary>
        /// S1END.
        /// </summary>
        public const string S1END = "S1END";

        /// <summary>
        /// S1ETM.
        /// </summary>
        public const string S1ETM = "S1ETM";

        /// <summary>
        /// S1TV01.
        /// </summary>
        public const string S1TV01 = "S1TV01";

        /// <summary>
        /// S1TV02.
        /// </summary>
        public const string S1TV02 = "S1TV02";

        /// <summary>
        /// S1TV03.
        /// </summary>
        public const string S1TV03 = "S1TV03";

        /// <summary>
        /// S1TV04.
        /// </summary>
        public const string S1TV04 = "S1TV04";

        /// <summary>
        /// S1TV05.
        /// </summary>
        public const string S1TV05 = "S1TV05";

        /// <summary>
        /// S1TVCD.
        /// </summary>
        public const string S1TVCD = "S1TVCD";

        /// <summary>
        /// S1TVQT.
        /// </summary>
        public const string S1TVQT = "S1TVQT";

        /// <summary>
        /// S1TVDT.
        /// </summary>
        public const string S1TVDT = "S1TVDT";

        /// <summary>
        /// S1TVUM.
        /// </summary>
        public const string S1TVUM = "S1TVUM";

        /// <summary>
        /// S1URCD.
        /// </summary>
        public const string S1URCD = "S1URCD";

        /// <summary>
        /// S1URDT.
        /// </summary>
        public const string S1URDT = "S1URDT";

        /// <summary>
        /// S1URAT.
        /// </summary>
        public const string S1URAT = "S1URAT";

        /// <summary>
        /// S1URAB.
        /// </summary>
        public const string S1URAB = "S1URAB";

        /// <summary>
        /// S1URRF.
        /// </summary>
        public const string S1URRF = "S1URRF";

        /// <summary>
        /// S1TORG.
        /// </summary>
        public const string S1TORG = "S1TORG";

        /// <summary>
        /// S1USER.
        /// </summary>
        public const string S1USER = "S1USER";

        /// <summary>
        /// S1PID.
        /// </summary>
        public const string S1PID = "S1PID";

        /// <summary>
        /// S1JOBN.
        /// </summary>
        public const string S1JOBN = "S1JOBN";

        /// <summary>
        /// S1UPMJ.
        /// </summary>
        public const string S1UPMJ = "S1UPMJ";

        /// <summary>
        /// S1TDAY.
        /// </summary>
        public const string S1TDAY = "S1TDAY";

        /// <summary>
        /// S1SBCK.
        /// </summary>
        public const string S1SBCK = "S1SBCK";

        /// <summary>
        /// S1EDCK.
        /// </summary>
        public const string S1EDCK = "S1EDCK";

        /// <summary>
        /// S1CMDM.
        /// </summary>
        public const string S1CMDM = "S1CMDM";

        /// <summary>
        /// S1BBCK.
        /// </summary>
        public const string S1BBCK = "S1BBCK";

        /// <summary>
        /// S1RQSJ.
        /// </summary>
        public const string S1RQSJ = "S1RQSJ";

        /// <summary>
        /// S1PSDJ.
        /// </summary>
        public const string S1PSDJ = "S1PSDJ";

        /// <summary>
        /// S1ADLJ.
        /// </summary>
        public const string S1ADLJ = "S1ADLJ";

        /// <summary>
        /// S1SUB.
        /// </summary>
        public const string S1SUB = "S1SUB";

        /// <summary>
        /// S1STTS.
        /// </summary>
        public const string S1STTS = "S1STTS";

        /// <summary>
        /// S1RATT.
        /// </summary>
        public const string S1RATT = "S1RATT";

        /// <summary>
        /// S1FUF1.
        /// </summary>
        public const string S1FUF1 = "S1FUF1";

        /// <summary>
        /// S1FRTC.
        /// </summary>
        public const string S1FRTC = "S1FRTC";

        /// <summary>
        /// S1FRAT.
        /// </summary>
        public const string S1FRAT = "S1FRAT";

        /// <summary>
        /// S1AFT.
        /// </summary>
        public const string S1AFT = "S1AFT";

        /// <summary>
        /// S1OMCU.
        /// </summary>
        public const string S1OMCU = "S1OMCU";

        /// <summary>
        /// S1OBJ.
        /// </summary>
        public const string S1OBJ = "S1OBJ";

        /// <summary>
        /// S1LT.
        /// </summary>
        public const string S1LT = "S1LT";

        /// <summary>
        /// S1FAPP.
        /// </summary>
        public const string S1FAPP = "S1FAPP";

        /// <summary>
        /// S1DSPR.
        /// </summary>
        public const string S1DSPR = "S1DSPR";

        /// <summary>
        /// S1DSFT.
        /// </summary>
        public const string S1DSFT = "S1DSFT";

        /// <summary>
        /// S1DMT1.
        /// </summary>
        public const string S1DMT1 = "S1DMT1";

        /// <summary>
        /// S1DMS1.
        /// </summary>
        public const string S1DMS1 = "S1DMS1";

        /// <summary>
        /// S1COT.
        /// </summary>
        public const string S1COT = "S1COT";

        /// <summary>
        /// S1CMGL.
        /// </summary>
        public const string S1CMGL = "S1CMGL";

        /// <summary>
        /// S1BALU.
        /// </summary>
        public const string S1BALU = "S1BALU";

        /// <summary>
        /// S1APOT.
        /// </summary>
        public const string S1APOT = "S1APOT";

        /// <summary>
        /// S1ACGD.
        /// </summary>
        public const string S1ACGD = "S1ACGD";

        /// <summary>
        /// S1ANI.
        /// </summary>
        public const string S1ANI = "S1ANI";

        /// <summary>
        /// S1AID.
        /// </summary>
        public const string S1AID = "S1AID";

        /// <summary>
        /// S1OPOL.
        /// </summary>
        public const string S1OPOL = "S1OPOL";

        /// <summary>
        /// S1OPBO.
        /// </summary>
        public const string S1OPBO = "S1OPBO";

        /// <summary>
        /// S1OPID.
        /// </summary>
        public const string S1OPID = "S1OPID";

        /// <summary>
        /// S1OPCS.
        /// </summary>
        public const string S1OPCS = "S1OPCS";

        /// <summary>
        /// S1OPLL.
        /// </summary>
        public const string S1OPLL = "S1OPLL";

        /// <summary>
        /// S1OPMS.
        /// </summary>
        public const string S1OPMS = "S1OPMS";

        /// <summary>
        /// S1OPSS.
        /// </summary>
        public const string S1OPSS = "S1OPSS";

        /// <summary>
        /// S1OPBA.
        /// </summary>
        public const string S1OPBA = "S1OPBA";

        /// <summary>
        /// S1FXSR.
        /// </summary>
        public const string S1FXSR = "S1FXSR";

        /// <summary>
        /// S1PSJOBNO.
        /// </summary>
        public const string S1PSJOBNO = "S1PSJOBNO";

        /// <summary>
        /// S1JOBSQ.
        /// </summary>
        public const string S1JOBSQ = "S1JOBSQ";

        /// <summary>
        /// S1CARDNO.
        /// </summary>
        public const string S1CARDNO = "S1CARDNO";

        /// <summary>
        /// S1DELBATCH.
        /// </summary>
        public const string S1DELBATCH = "S1DELBATCH";
    }

    /// <inheritdoc />
    public override string TableName => "F49211Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S1EDUS", "S1EDUS", JdeDataType.String, 20, true, true),
        new JdeField("S1EDBT", "S1EDBT", JdeDataType.String, 30, true, true),
        new JdeField("S1EDTN", "S1EDTN", JdeDataType.String, 44, true, true),
        new JdeField("S1EDLN", "S1EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S1EDCT", "S1EDCT", JdeDataType.String, 4),
        new JdeField("S1TYTN", "S1TYTN", JdeDataType.String, 16),
        new JdeField("S1EDFT", "S1EDFT", JdeDataType.String, 20),
        new JdeField("S1EDDT", "S1EDDT", JdeDataType.Numeric),
        new JdeField("S1DRIN", "S1DRIN", JdeDataType.String, 2),
        new JdeField("S1EDDL", "S1EDDL", JdeDataType.Numeric),
        new JdeField("S1EDSP", "S1EDSP", JdeDataType.String, 2),
        new JdeField("S1PNID", "S1PNID", JdeDataType.String, 30),
        new JdeField("S1TNAC", "S1TNAC", JdeDataType.String, 4),
        new JdeField("S1DOCO", "S1DOCO", JdeDataType.Numeric),
        new JdeField("S1DCTO", "S1DCTO", JdeDataType.String, 4),
        new JdeField("S1KCOO", "S1KCOO", JdeDataType.String, 10),
        new JdeField("S1LNID", "S1LNID", JdeDataType.Numeric),
        new JdeField("S1VMCU", "S1VMCU", JdeDataType.String, 24),
        new JdeField("S1TRP", "S1TRP", JdeDataType.Numeric),
        new JdeField("S1LOAD", "S1LOAD", JdeDataType.Numeric),
        new JdeField("S1DSGP", "S1DSGP", JdeDataType.String, 6),
        new JdeField("S1BPFG", "S1BPFG", JdeDataType.String, 2),
        new JdeField("S1DSTN", "S1DSTN", JdeDataType.Numeric),
        new JdeField("S1UM", "S1UM", JdeDataType.String, 4),
        new JdeField("S1DEFF", "S1DEFF", JdeDataType.String, 2),
        new JdeField("S1DUNC", "S1DUNC", JdeDataType.Numeric),
        new JdeField("S1FDUC", "S1FDUC", JdeDataType.Numeric),
        new JdeField("S1DREV", "S1DREV", JdeDataType.Numeric),
        new JdeField("S1FDRV", "S1FDRV", JdeDataType.Numeric),
        new JdeField("S1ANUM", "S1ANUM", JdeDataType.Numeric),
        new JdeField("S1SIDT", "S1SIDT", JdeDataType.Numeric),
        new JdeField("S1INCY", "S1INCY", JdeDataType.String, 6),
        new JdeField("S1LDDT", "S1LDDT", JdeDataType.Numeric),
        new JdeField("S1LDTM", "S1LDTM", JdeDataType.Numeric),
        new JdeField("S1DCDT", "S1DCDT", JdeDataType.Numeric),
        new JdeField("S1PCQY", "S1PCQY", JdeDataType.Numeric),
        new JdeField("S1UOMC", "S1UOMC", JdeDataType.String, 4),
        new JdeField("S1TEMP", "S1TEMP", JdeDataType.Numeric),
        new JdeField("S1STPU", "S1STPU", JdeDataType.String, 2),
        new JdeField("S1DNTY", "S1DNTY", JdeDataType.Numeric),
        new JdeField("S1DNTP", "S1DNTP", JdeDataType.String, 2),
        new JdeField("S1DETP", "S1DETP", JdeDataType.Numeric),
        new JdeField("S1DTPU", "S1DTPU", JdeDataType.String, 2),
        new JdeField("S1VCF", "S1VCF", JdeDataType.Numeric),
        new JdeField("S1PRAS", "S1PRAS", JdeDataType.String, 2),
        new JdeField("S1CP01", "S1CP01", JdeDataType.String, 2),
        new JdeField("S1IQTY", "S1IQTY", JdeDataType.Numeric),
        new JdeField("S1STUM", "S1STUM", JdeDataType.Numeric),
        new JdeField("S1BUM6", "S1BUM6", JdeDataType.String, 4),
        new JdeField("S1AMBR", "S1AMBR", JdeDataType.Numeric),
        new JdeField("S1BUM3", "S1BUM3", JdeDataType.String, 4),
        new JdeField("S1WGTR", "S1WGTR", JdeDataType.Numeric),
        new JdeField("S1BUM5", "S1BUM5", JdeDataType.String, 4),
        new JdeField("S1FRTV", "S1FRTV", JdeDataType.String, 2),
        new JdeField("S1FRTD", "S1FRTD", JdeDataType.String, 2),
        new JdeField("S1FRCC", "S1FRCC", JdeDataType.Numeric),
        new JdeField("S1FRVC", "S1FRVC", JdeDataType.Numeric),
        new JdeField("S1PVEH", "S1PVEH", JdeDataType.String, 24),
        new JdeField("S1RLNO", "S1RLNO", JdeDataType.String, 26),
        new JdeField("S1MCUR", "S1MCUR", JdeDataType.String, 24),
        new JdeField("S1FLTN", "S1FLTN", JdeDataType.String, 16),
        new JdeField("S1DSNN", "S1DSNN", JdeDataType.String, 10),
        new JdeField("S1ARCT", "S1ARCT", JdeDataType.String, 10),
        new JdeField("S1SORG", "S1SORG", JdeDataType.String, 30),
        new JdeField("S1ELTM", "S1ELTM", JdeDataType.Numeric),
        new JdeField("S1PTNR", "S1PTNR", JdeDataType.Numeric),
        new JdeField("S1IAN8", "S1IAN8", JdeDataType.Numeric),
        new JdeField("S1PTC", "S1PTC", JdeDataType.String, 6),
        new JdeField("S1DOC", "S1DOC", JdeDataType.Numeric),
        new JdeField("S1DCT", "S1DCT", JdeDataType.String, 4),
        new JdeField("S1KCO", "S1KCO", JdeDataType.String, 10),
        new JdeField("S1CRR", "S1CRR", JdeDataType.Numeric),
        new JdeField("S1CRCD", "S1CRCD", JdeDataType.String, 6),
        new JdeField("S1TXA1", "S1TXA1", JdeDataType.String, 20),
        new JdeField("S1EXR1", "S1EXR1", JdeDataType.String, 4),
        new JdeField("S1FRDM", "S1FRDM", JdeDataType.String, 2),
        new JdeField("S1FUPT", "S1FUPT", JdeDataType.String, 6),
        new JdeField("S1RINO", "S1RINO", JdeDataType.String, 30),
        new JdeField("S1GLOC", "S1GLOC", JdeDataType.String, 30),
        new JdeField("S1AUTA", "S1AUTA", JdeDataType.String, 60),
        new JdeField("S1ALPH", "S1ALPH", JdeDataType.String, 80),
        new JdeField("S1MET1", "S1MET1", JdeDataType.String, 20),
        new JdeField("S1OPN1", "S1OPN1", JdeDataType.Numeric),
        new JdeField("S1PNR1", "S1PNR1", JdeDataType.Numeric),
        new JdeField("S1MET2", "S1MET2", JdeDataType.String, 20),
        new JdeField("S1OPN2", "S1OPN2", JdeDataType.Numeric),
        new JdeField("S1PNR2", "S1PNR2", JdeDataType.Numeric),
        new JdeField("S1MET3", "S1MET3", JdeDataType.String, 20),
        new JdeField("S1OPN3", "S1OPN3", JdeDataType.Numeric),
        new JdeField("S1PNR3", "S1PNR3", JdeDataType.Numeric),
        new JdeField("S1ARDT", "S1ARDT", JdeDataType.Numeric),
        new JdeField("S1ARTM", "S1ARTM", JdeDataType.Numeric),
        new JdeField("S1DPDT", "S1DPDT", JdeDataType.Numeric),
        new JdeField("S1DETM", "S1DETM", JdeDataType.Numeric),
        new JdeField("S1DSTJ", "S1DSTJ", JdeDataType.Numeric),
        new JdeField("S1STM", "S1STM", JdeDataType.Numeric),
        new JdeField("S1END", "S1END", JdeDataType.Numeric),
        new JdeField("S1ETM", "S1ETM", JdeDataType.Numeric),
        new JdeField("S1TV01", "S1TV01", JdeDataType.String, 2),
        new JdeField("S1TV02", "S1TV02", JdeDataType.String, 2),
        new JdeField("S1TV03", "S1TV03", JdeDataType.String, 2),
        new JdeField("S1TV04", "S1TV04", JdeDataType.String, 2),
        new JdeField("S1TV05", "S1TV05", JdeDataType.String, 2),
        new JdeField("S1TVCD", "S1TVCD", JdeDataType.String, 4),
        new JdeField("S1TVQT", "S1TVQT", JdeDataType.Numeric),
        new JdeField("S1TVDT", "S1TVDT", JdeDataType.Numeric),
        new JdeField("S1TVUM", "S1TVUM", JdeDataType.String, 4),
        new JdeField("S1URCD", "S1URCD", JdeDataType.String, 4),
        new JdeField("S1URDT", "S1URDT", JdeDataType.Numeric),
        new JdeField("S1URAT", "S1URAT", JdeDataType.Numeric),
        new JdeField("S1URAB", "S1URAB", JdeDataType.Numeric),
        new JdeField("S1URRF", "S1URRF", JdeDataType.String, 30),
        new JdeField("S1TORG", "S1TORG", JdeDataType.String, 20),
        new JdeField("S1USER", "S1USER", JdeDataType.String, 20),
        new JdeField("S1PID", "S1PID", JdeDataType.String, 20),
        new JdeField("S1JOBN", "S1JOBN", JdeDataType.String, 20),
        new JdeField("S1UPMJ", "S1UPMJ", JdeDataType.Numeric),
        new JdeField("S1TDAY", "S1TDAY", JdeDataType.Numeric),
        new JdeField("S1SBCK", "S1SBCK", JdeDataType.String, 2),
        new JdeField("S1EDCK", "S1EDCK", JdeDataType.String, 2),
        new JdeField("S1CMDM", "S1CMDM", JdeDataType.String, 2),
        new JdeField("S1BBCK", "S1BBCK", JdeDataType.String, 2),
        new JdeField("S1RQSJ", "S1RQSJ", JdeDataType.Numeric),
        new JdeField("S1PSDJ", "S1PSDJ", JdeDataType.Numeric),
        new JdeField("S1ADLJ", "S1ADLJ", JdeDataType.Numeric),
        new JdeField("S1SUB", "S1SUB", JdeDataType.String, 16),
        new JdeField("S1STTS", "S1STTS", JdeDataType.String, 4),
        new JdeField("S1RATT", "S1RATT", JdeDataType.String, 2),
        new JdeField("S1FUF1", "S1FUF1", JdeDataType.String, 2),
        new JdeField("S1FRTC", "S1FRTC", JdeDataType.String, 2),
        new JdeField("S1FRAT", "S1FRAT", JdeDataType.String, 20),
        new JdeField("S1AFT", "S1AFT", JdeDataType.String, 2),
        new JdeField("S1OMCU", "S1OMCU", JdeDataType.String, 24),
        new JdeField("S1OBJ", "S1OBJ", JdeDataType.String, 12),
        new JdeField("S1LT", "S1LT", JdeDataType.String, 4),
        new JdeField("S1FAPP", "S1FAPP", JdeDataType.String, 2),
        new JdeField("S1DSPR", "S1DSPR", JdeDataType.Numeric),
        new JdeField("S1DSFT", "S1DSFT", JdeDataType.String, 2),
        new JdeField("S1DMT1", "S1DMT1", JdeDataType.String, 24),
        new JdeField("S1DMS1", "S1DMS1", JdeDataType.Numeric),
        new JdeField("S1COT", "S1COT", JdeDataType.String, 6),
        new JdeField("S1CMGL", "S1CMGL", JdeDataType.String, 2),
        new JdeField("S1BALU", "S1BALU", JdeDataType.String, 2),
        new JdeField("S1APOT", "S1APOT", JdeDataType.Numeric),
        new JdeField("S1ACGD", "S1ACGD", JdeDataType.String, 6),
        new JdeField("S1ANI", "S1ANI", JdeDataType.String, 58),
        new JdeField("S1AID", "S1AID", JdeDataType.String, 16),
        new JdeField("S1OPOL", "S1OPOL", JdeDataType.Numeric),
        new JdeField("S1OPBO", "S1OPBO", JdeDataType.String, 60),
        new JdeField("S1OPID", "S1OPID", JdeDataType.String, 60),
        new JdeField("S1OPCS", "S1OPCS", JdeDataType.Numeric),
        new JdeField("S1OPLL", "S1OPLL", JdeDataType.String, 2),
        new JdeField("S1OPMS", "S1OPMS", JdeDataType.String, 2),
        new JdeField("S1OPSS", "S1OPSS", JdeDataType.String, 2),
        new JdeField("S1OPBA", "S1OPBA", JdeDataType.String, 2),
        new JdeField("S1FXSR", "S1FXSR", JdeDataType.String, 2),
        new JdeField("S1PSJOBNO", "S1PSJOBNO", JdeDataType.String, 30),
        new JdeField("S1JOBSQ", "S1JOBSQ", JdeDataType.String, 30),
        new JdeField("S1CARDNO", "S1CARDNO", JdeDataType.String, 8),
        new JdeField("S1DELBATCH", "S1DELBATCH", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49211Z1_0", "Primary Key on S1EDUS, S1EDBT, S1EDTN, S1EDLN", new[] { "S1EDUS", "S1EDBT", "S1EDTN", "S1EDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49211Z1_2", "Index on S1DOCO, S1DCTO, S1KCOO, S1EDUS, S1LNID", new[] { "S1DOCO", "S1DCTO", "S1KCOO", "S1EDUS", "S1LNID" }),
        new JdeIndex("F49211Z1_3", "Index on S1DOCO, S1DCTO, S1KCOO, S1LNID, S1EDUS", new[] { "S1DOCO", "S1DCTO", "S1KCOO", "S1LNID", "S1EDUS" })
    };
}
