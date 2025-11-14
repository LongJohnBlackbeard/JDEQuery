using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4576Z1 - .
/// </summary>
public class F4576Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z1EDUS.
        /// </summary>
        public const string Z1EDUS = "Z1EDUS";

        /// <summary>
        /// Z1EDBT.
        /// </summary>
        public const string Z1EDBT = "Z1EDBT";

        /// <summary>
        /// Z1EDTN.
        /// </summary>
        public const string Z1EDTN = "Z1EDTN";

        /// <summary>
        /// Z1EDLN.
        /// </summary>
        public const string Z1EDLN = "Z1EDLN";

        /// <summary>
        /// Z1EDCT.
        /// </summary>
        public const string Z1EDCT = "Z1EDCT";

        /// <summary>
        /// Z1TYTN.
        /// </summary>
        public const string Z1TYTN = "Z1TYTN";

        /// <summary>
        /// Z1EDFT.
        /// </summary>
        public const string Z1EDFT = "Z1EDFT";

        /// <summary>
        /// Z1EDDT.
        /// </summary>
        public const string Z1EDDT = "Z1EDDT";

        /// <summary>
        /// Z1DRIN.
        /// </summary>
        public const string Z1DRIN = "Z1DRIN";

        /// <summary>
        /// Z1EDDL.
        /// </summary>
        public const string Z1EDDL = "Z1EDDL";

        /// <summary>
        /// Z1EDSP.
        /// </summary>
        public const string Z1EDSP = "Z1EDSP";

        /// <summary>
        /// Z1PNID.
        /// </summary>
        public const string Z1PNID = "Z1PNID";

        /// <summary>
        /// Z1TNAC.
        /// </summary>
        public const string Z1TNAC = "Z1TNAC";

        /// <summary>
        /// Z1DOCO.
        /// </summary>
        public const string Z1DOCO = "Z1DOCO";

        /// <summary>
        /// Z1DCTO.
        /// </summary>
        public const string Z1DCTO = "Z1DCTO";

        /// <summary>
        /// Z1KCOO.
        /// </summary>
        public const string Z1KCOO = "Z1KCOO";

        /// <summary>
        /// Z1SFXO.
        /// </summary>
        public const string Z1SFXO = "Z1SFXO";

        /// <summary>
        /// Z1LNID.
        /// </summary>
        public const string Z1LNID = "Z1LNID";

        /// <summary>
        /// Z1OSEQ.
        /// </summary>
        public const string Z1OSEQ = "Z1OSEQ";

        /// <summary>
        /// Z1PA04.
        /// </summary>
        public const string Z1PA04 = "Z1PA04";

        /// <summary>
        /// Z1AST.
        /// </summary>
        public const string Z1AST = "Z1AST";

        /// <summary>
        /// Z1AGTY.
        /// </summary>
        public const string Z1AGTY = "Z1AGTY";

        /// <summary>
        /// Z1ANS8.
        /// </summary>
        public const string Z1ANS8 = "Z1ANS8";

        /// <summary>
        /// Z1MCU.
        /// </summary>
        public const string Z1MCU = "Z1MCU";

        /// <summary>
        /// Z1IGID.
        /// </summary>
        public const string Z1IGID = "Z1IGID";

        /// <summary>
        /// Z1CGID.
        /// </summary>
        public const string Z1CGID = "Z1CGID";

        /// <summary>
        /// Z1AN8.
        /// </summary>
        public const string Z1AN8 = "Z1AN8";

        /// <summary>
        /// Z1CPGP.
        /// </summary>
        public const string Z1CPGP = "Z1CPGP";

        /// <summary>
        /// Z1ITM.
        /// </summary>
        public const string Z1ITM = "Z1ITM";

        /// <summary>
        /// Z1PRGR.
        /// </summary>
        public const string Z1PRGR = "Z1PRGR";

        /// <summary>
        /// Z1CATN.
        /// </summary>
        public const string Z1CATN = "Z1CATN";

        /// <summary>
        /// Z1CCF3.
        /// </summary>
        public const string Z1CCF3 = "Z1CCF3";

        /// <summary>
        /// Z1CTYE.
        /// </summary>
        public const string Z1CTYE = "Z1CTYE";

        /// <summary>
        /// Z1CLMD.
        /// </summary>
        public const string Z1CLMD = "Z1CLMD";

        /// <summary>
        /// Z1SCNT.
        /// </summary>
        public const string Z1SCNT = "Z1SCNT";

        /// <summary>
        /// Z1ACCS.
        /// </summary>
        public const string Z1ACCS = "Z1ACCS";

        /// <summary>
        /// Z1ACCA.
        /// </summary>
        public const string Z1ACCA = "Z1ACCA";

        /// <summary>
        /// Z1CLAD.
        /// </summary>
        public const string Z1CLAD = "Z1CLAD";

        /// <summary>
        /// Z1CAF.
        /// </summary>
        public const string Z1CAF = "Z1CAF";

        /// <summary>
        /// Z1CRCD.
        /// </summary>
        public const string Z1CRCD = "Z1CRCD";

        /// <summary>
        /// Z1BCRC.
        /// </summary>
        public const string Z1BCRC = "Z1BCRC";

        /// <summary>
        /// Z1CLNR.
        /// </summary>
        public const string Z1CLNR = "Z1CLNR";

        /// <summary>
        /// Z1DESC.
        /// </summary>
        public const string Z1DESC = "Z1DESC";

        /// <summary>
        /// Z1DOC.
        /// </summary>
        public const string Z1DOC = "Z1DOC";

        /// <summary>
        /// Z1DCT.
        /// </summary>
        public const string Z1DCT = "Z1DCT";

        /// <summary>
        /// Z1KCO.
        /// </summary>
        public const string Z1KCO = "Z1KCO";

        /// <summary>
        /// Z1SFX.
        /// </summary>
        public const string Z1SFX = "Z1SFX";

        /// <summary>
        /// Z1SFXE.
        /// </summary>
        public const string Z1SFXE = "Z1SFXE";

        /// <summary>
        /// Z1SDOC.
        /// </summary>
        public const string Z1SDOC = "Z1SDOC";

        /// <summary>
        /// Z1SDCT.
        /// </summary>
        public const string Z1SDCT = "Z1SDCT";

        /// <summary>
        /// Z1SKCO.
        /// </summary>
        public const string Z1SKCO = "Z1SKCO";

        /// <summary>
        /// Z1SFX0.
        /// </summary>
        public const string Z1SFX0 = "Z1SFX0";

        /// <summary>
        /// Z1DOCM.
        /// </summary>
        public const string Z1DOCM = "Z1DOCM";

        /// <summary>
        /// Z1DCTM.
        /// </summary>
        public const string Z1DCTM = "Z1DCTM";

        /// <summary>
        /// Z1SCLM.
        /// </summary>
        public const string Z1SCLM = "Z1SCLM";

        /// <summary>
        /// Z1ADDJ.
        /// </summary>
        public const string Z1ADDJ = "Z1ADDJ";

        /// <summary>
        /// Z1CNFD.
        /// </summary>
        public const string Z1CNFD = "Z1CNFD";

        /// <summary>
        /// Z1CSCD.
        /// </summary>
        public const string Z1CSCD = "Z1CSCD";

        /// <summary>
        /// Z1DSC1.
        /// </summary>
        public const string Z1DSC1 = "Z1DSC1";

        /// <summary>
        /// Z1RPER.
        /// </summary>
        public const string Z1RPER = "Z1RPER";

        /// <summary>
        /// Z1UOM.
        /// </summary>
        public const string Z1UOM = "Z1UOM";

        /// <summary>
        /// Z1SOQS.
        /// </summary>
        public const string Z1SOQS = "Z1SOQS";

        /// <summary>
        /// Z1QYCL.
        /// </summary>
        public const string Z1QYCL = "Z1QYCL";

        /// <summary>
        /// Z1CLRR.
        /// </summary>
        public const string Z1CLRR = "Z1CLRR";

        /// <summary>
        /// Z1BN01.
        /// </summary>
        public const string Z1BN01 = "Z1BN01";

        /// <summary>
        /// Z1BTY1.
        /// </summary>
        public const string Z1BTY1 = "Z1BTY1";

        /// <summary>
        /// Z1SLSP.
        /// </summary>
        public const string Z1SLSP = "Z1SLSP";

        /// <summary>
        /// Z1ABR1.
        /// </summary>
        public const string Z1ABR1 = "Z1ABR1";

        /// <summary>
        /// Z1ABR2.
        /// </summary>
        public const string Z1ABR2 = "Z1ABR2";

        /// <summary>
        /// Z1ABR3.
        /// </summary>
        public const string Z1ABR3 = "Z1ABR3";

        /// <summary>
        /// Z1ABR4.
        /// </summary>
        public const string Z1ABR4 = "Z1ABR4";

        /// <summary>
        /// Z1ABT1.
        /// </summary>
        public const string Z1ABT1 = "Z1ABT1";

        /// <summary>
        /// Z1ABT2.
        /// </summary>
        public const string Z1ABT2 = "Z1ABT2";

        /// <summary>
        /// Z1ABT3.
        /// </summary>
        public const string Z1ABT3 = "Z1ABT3";

        /// <summary>
        /// Z1ABT4.
        /// </summary>
        public const string Z1ABT4 = "Z1ABT4";

        /// <summary>
        /// Z1UM.
        /// </summary>
        public const string Z1UM = "Z1UM";

        /// <summary>
        /// Z1SBL.
        /// </summary>
        public const string Z1SBL = "Z1SBL";

        /// <summary>
        /// Z1SBLT.
        /// </summary>
        public const string Z1SBLT = "Z1SBLT";

        /// <summary>
        /// Z1ANI.
        /// </summary>
        public const string Z1ANI = "Z1ANI";

        /// <summary>
        /// Z1DAMD.
        /// </summary>
        public const string Z1DAMD = "Z1DAMD";

        /// <summary>
        /// Z1DAMF.
        /// </summary>
        public const string Z1DAMF = "Z1DAMF";

        /// <summary>
        /// Z1EMCU.
        /// </summary>
        public const string Z1EMCU = "Z1EMCU";

        /// <summary>
        /// Z1CO.
        /// </summary>
        public const string Z1CO = "Z1CO";

        /// <summary>
        /// Z1FLIT.
        /// </summary>
        public const string Z1FLIT = "Z1FLIT";

        /// <summary>
        /// Z1ICU.
        /// </summary>
        public const string Z1ICU = "Z1ICU";

        /// <summary>
        /// Z1ICUT.
        /// </summary>
        public const string Z1ICUT = "Z1ICUT";

        /// <summary>
        /// Z1DE01.
        /// </summary>
        public const string Z1DE01 = "Z1DE01";

        /// <summary>
        /// Z1DE02.
        /// </summary>
        public const string Z1DE02 = "Z1DE02";

        /// <summary>
        /// Z1DE03.
        /// </summary>
        public const string Z1DE03 = "Z1DE03";

        /// <summary>
        /// Z1DE04.
        /// </summary>
        public const string Z1DE04 = "Z1DE04";

        /// <summary>
        /// Z1DE05.
        /// </summary>
        public const string Z1DE05 = "Z1DE05";

        /// <summary>
        /// Z1URCD.
        /// </summary>
        public const string Z1URCD = "Z1URCD";

        /// <summary>
        /// Z1URDT.
        /// </summary>
        public const string Z1URDT = "Z1URDT";

        /// <summary>
        /// Z1URAT.
        /// </summary>
        public const string Z1URAT = "Z1URAT";

        /// <summary>
        /// Z1URAB.
        /// </summary>
        public const string Z1URAB = "Z1URAB";

        /// <summary>
        /// Z1URRF.
        /// </summary>
        public const string Z1URRF = "Z1URRF";

        /// <summary>
        /// Z1USER.
        /// </summary>
        public const string Z1USER = "Z1USER";

        /// <summary>
        /// Z1PID.
        /// </summary>
        public const string Z1PID = "Z1PID";

        /// <summary>
        /// Z1JOBN.
        /// </summary>
        public const string Z1JOBN = "Z1JOBN";

        /// <summary>
        /// Z1UPMJ.
        /// </summary>
        public const string Z1UPMJ = "Z1UPMJ";

        /// <summary>
        /// Z1TDAY.
        /// </summary>
        public const string Z1TDAY = "Z1TDAY";

        /// <summary>
        /// Z1EDOC.
        /// </summary>
        public const string Z1EDOC = "Z1EDOC";

        /// <summary>
        /// Z1TPUR.
        /// </summary>
        public const string Z1TPUR = "Z1TPUR";

        /// <summary>
        /// Z1CITM.
        /// </summary>
        public const string Z1CITM = "Z1CITM";

        /// <summary>
        /// Z1EDST.
        /// </summary>
        public const string Z1EDST = "Z1EDST";

        /// <summary>
        /// Z1IVD.
        /// </summary>
        public const string Z1IVD = "Z1IVD";

        /// <summary>
        /// Z1ASN.
        /// </summary>
        public const string Z1ASN = "Z1ASN";

        /// <summary>
        /// Z1MNQ.
        /// </summary>
        public const string Z1MNQ = "Z1MNQ";

        /// <summary>
        /// Z1LEDG.
        /// </summary>
        public const string Z1LEDG = "Z1LEDG";

        /// <summary>
        /// Z1UPRC.
        /// </summary>
        public const string Z1UPRC = "Z1UPRC";

        /// <summary>
        /// Z1FUP.
        /// </summary>
        public const string Z1FUP = "Z1FUP";

        /// <summary>
        /// Z1GLC.
        /// </summary>
        public const string Z1GLC = "Z1GLC";

        /// <summary>
        /// Z1FVMD.
        /// </summary>
        public const string Z1FVMD = "Z1FVMD";

        /// <summary>
        /// Z1FVTR.
        /// </summary>
        public const string Z1FVTR = "Z1FVTR";

        /// <summary>
        /// Z1QYAP.
        /// </summary>
        public const string Z1QYAP = "Z1QYAP";

        /// <summary>
        /// Z1ACNT.
        /// </summary>
        public const string Z1ACNT = "Z1ACNT";

        /// <summary>
        /// Z1EFTJ.
        /// </summary>
        public const string Z1EFTJ = "Z1EFTJ";

        /// <summary>
        /// Z1EXDJ.
        /// </summary>
        public const string Z1EXDJ = "Z1EXDJ";

        /// <summary>
        /// Z1BDCS.
        /// </summary>
        public const string Z1BDCS = "Z1BDCS";

        /// <summary>
        /// Z1BDCL.
        /// </summary>
        public const string Z1BDCL = "Z1BDCL";

        /// <summary>
        /// Z1FRMN.
        /// </summary>
        public const string Z1FRMN = "Z1FRMN";

        /// <summary>
        /// Z1MQYQ.
        /// </summary>
        public const string Z1MQYQ = "Z1MQYQ";

        /// <summary>
        /// Z1MAQY.
        /// </summary>
        public const string Z1MAQY = "Z1MAQY";

        /// <summary>
        /// Z1QYOA.
        /// </summary>
        public const string Z1QYOA = "Z1QYOA";

        /// <summary>
        /// Z1AGNB.
        /// </summary>
        public const string Z1AGNB = "Z1AGNB";

        /// <summary>
        /// Z1OKCO.
        /// </summary>
        public const string Z1OKCO = "Z1OKCO";

        /// <summary>
        /// Z1OORN.
        /// </summary>
        public const string Z1OORN = "Z1OORN";

        /// <summary>
        /// Z1OCTO.
        /// </summary>
        public const string Z1OCTO = "Z1OCTO";

        /// <summary>
        /// Z1OGNO.
        /// </summary>
        public const string Z1OGNO = "Z1OGNO";

        /// <summary>
        /// Z1RORN.
        /// </summary>
        public const string Z1RORN = "Z1RORN";

        /// <summary>
        /// Z1RCTO.
        /// </summary>
        public const string Z1RCTO = "Z1RCTO";

        /// <summary>
        /// Z1RLLN.
        /// </summary>
        public const string Z1RLLN = "Z1RLLN";

        /// <summary>
        /// Z1SHAN.
        /// </summary>
        public const string Z1SHAN = "Z1SHAN";

        /// <summary>
        /// Z1PA8.
        /// </summary>
        public const string Z1PA8 = "Z1PA8";

        /// <summary>
        /// Z1TRDJ.
        /// </summary>
        public const string Z1TRDJ = "Z1TRDJ";

        /// <summary>
        /// Z1LITM.
        /// </summary>
        public const string Z1LITM = "Z1LITM";

        /// <summary>
        /// Z1AITM.
        /// </summary>
        public const string Z1AITM = "Z1AITM";

        /// <summary>
        /// Z1RLIT.
        /// </summary>
        public const string Z1RLIT = "Z1RLIT";

        /// <summary>
        /// Z1KTLN.
        /// </summary>
        public const string Z1KTLN = "Z1KTLN";

        /// <summary>
        /// Z1CPNT.
        /// </summary>
        public const string Z1CPNT = "Z1CPNT";

        /// <summary>
        /// Z1RKIT.
        /// </summary>
        public const string Z1RKIT = "Z1RKIT";

        /// <summary>
        /// Z1KTP.
        /// </summary>
        public const string Z1KTP = "Z1KTP";

        /// <summary>
        /// Z1AEXP.
        /// </summary>
        public const string Z1AEXP = "Z1AEXP";

        /// <summary>
        /// Z1UNCS.
        /// </summary>
        public const string Z1UNCS = "Z1UNCS";

        /// <summary>
        /// Z1ECST.
        /// </summary>
        public const string Z1ECST = "Z1ECST";

        /// <summary>
        /// Z1ODOC.
        /// </summary>
        public const string Z1ODOC = "Z1ODOC";

        /// <summary>
        /// Z1ODCT.
        /// </summary>
        public const string Z1ODCT = "Z1ODCT";

        /// <summary>
        /// Z1OKC.
        /// </summary>
        public const string Z1OKC = "Z1OKC";

        /// <summary>
        /// Z1TAX1.
        /// </summary>
        public const string Z1TAX1 = "Z1TAX1";

        /// <summary>
        /// Z1TXA1.
        /// </summary>
        public const string Z1TXA1 = "Z1TXA1";

        /// <summary>
        /// Z1EXR1.
        /// </summary>
        public const string Z1EXR1 = "Z1EXR1";

        /// <summary>
        /// Z1VEND.
        /// </summary>
        public const string Z1VEND = "Z1VEND";

        /// <summary>
        /// Z1UOM1.
        /// </summary>
        public const string Z1UOM1 = "Z1UOM1";

        /// <summary>
        /// Z1CRR.
        /// </summary>
        public const string Z1CRR = "Z1CRR";

        /// <summary>
        /// Z1FPRC.
        /// </summary>
        public const string Z1FPRC = "Z1FPRC";

        /// <summary>
        /// Z1FEA.
        /// </summary>
        public const string Z1FEA = "Z1FEA";

        /// <summary>
        /// Z1FUC.
        /// </summary>
        public const string Z1FUC = "Z1FUC";

        /// <summary>
        /// Z1FEC.
        /// </summary>
        public const string Z1FEC = "Z1FEC";
    }

    /// <inheritdoc />
    public override string TableName => "F4576Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z1EDUS", "Z1EDUS", JdeDataType.String, 20, true, true),
        new JdeField("Z1EDBT", "Z1EDBT", JdeDataType.String, 30, true, true),
        new JdeField("Z1EDTN", "Z1EDTN", JdeDataType.String, 44, true, true),
        new JdeField("Z1EDLN", "Z1EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z1EDCT", "Z1EDCT", JdeDataType.String, 4),
        new JdeField("Z1TYTN", "Z1TYTN", JdeDataType.String, 16),
        new JdeField("Z1EDFT", "Z1EDFT", JdeDataType.String, 20),
        new JdeField("Z1EDDT", "Z1EDDT", JdeDataType.Numeric),
        new JdeField("Z1DRIN", "Z1DRIN", JdeDataType.String, 2),
        new JdeField("Z1EDDL", "Z1EDDL", JdeDataType.Numeric),
        new JdeField("Z1EDSP", "Z1EDSP", JdeDataType.String, 2),
        new JdeField("Z1PNID", "Z1PNID", JdeDataType.String, 30),
        new JdeField("Z1TNAC", "Z1TNAC", JdeDataType.String, 4),
        new JdeField("Z1DOCO", "Z1DOCO", JdeDataType.Numeric),
        new JdeField("Z1DCTO", "Z1DCTO", JdeDataType.String, 4),
        new JdeField("Z1KCOO", "Z1KCOO", JdeDataType.String, 10),
        new JdeField("Z1SFXO", "Z1SFXO", JdeDataType.String, 6),
        new JdeField("Z1LNID", "Z1LNID", JdeDataType.Numeric),
        new JdeField("Z1OSEQ", "Z1OSEQ", JdeDataType.Numeric),
        new JdeField("Z1PA04", "Z1PA04", JdeDataType.String, 2),
        new JdeField("Z1AST", "Z1AST", JdeDataType.String, 16),
        new JdeField("Z1AGTY", "Z1AGTY", JdeDataType.String, 4),
        new JdeField("Z1ANS8", "Z1ANS8", JdeDataType.Numeric),
        new JdeField("Z1MCU", "Z1MCU", JdeDataType.String, 24),
        new JdeField("Z1IGID", "Z1IGID", JdeDataType.Numeric),
        new JdeField("Z1CGID", "Z1CGID", JdeDataType.Numeric),
        new JdeField("Z1AN8", "Z1AN8", JdeDataType.Numeric),
        new JdeField("Z1CPGP", "Z1CPGP", JdeDataType.String, 16),
        new JdeField("Z1ITM", "Z1ITM", JdeDataType.Numeric),
        new JdeField("Z1PRGR", "Z1PRGR", JdeDataType.String, 16),
        new JdeField("Z1CATN", "Z1CATN", JdeDataType.String, 16),
        new JdeField("Z1CCF3", "Z1CCF3", JdeDataType.String, 6),
        new JdeField("Z1CTYE", "Z1CTYE", JdeDataType.String, 4),
        new JdeField("Z1CLMD", "Z1CLMD", JdeDataType.String, 2),
        new JdeField("Z1SCNT", "Z1SCNT", JdeDataType.String, 4),
        new JdeField("Z1ACCS", "Z1ACCS", JdeDataType.String, 58),
        new JdeField("Z1ACCA", "Z1ACCA", JdeDataType.String, 58),
        new JdeField("Z1CLAD", "Z1CLAD", JdeDataType.Numeric),
        new JdeField("Z1CAF", "Z1CAF", JdeDataType.Numeric),
        new JdeField("Z1CRCD", "Z1CRCD", JdeDataType.String, 6),
        new JdeField("Z1BCRC", "Z1BCRC", JdeDataType.String, 6),
        new JdeField("Z1CLNR", "Z1CLNR", JdeDataType.Numeric),
        new JdeField("Z1DESC", "Z1DESC", JdeDataType.String, 60),
        new JdeField("Z1DOC", "Z1DOC", JdeDataType.Numeric),
        new JdeField("Z1DCT", "Z1DCT", JdeDataType.String, 4),
        new JdeField("Z1KCO", "Z1KCO", JdeDataType.String, 10),
        new JdeField("Z1SFX", "Z1SFX", JdeDataType.String, 6),
        new JdeField("Z1SFXE", "Z1SFXE", JdeDataType.Numeric),
        new JdeField("Z1SDOC", "Z1SDOC", JdeDataType.Numeric),
        new JdeField("Z1SDCT", "Z1SDCT", JdeDataType.String, 4),
        new JdeField("Z1SKCO", "Z1SKCO", JdeDataType.String, 10),
        new JdeField("Z1SFX0", "Z1SFX0", JdeDataType.String, 6),
        new JdeField("Z1DOCM", "Z1DOCM", JdeDataType.Numeric),
        new JdeField("Z1DCTM", "Z1DCTM", JdeDataType.String, 4),
        new JdeField("Z1SCLM", "Z1SCLM", JdeDataType.Numeric),
        new JdeField("Z1ADDJ", "Z1ADDJ", JdeDataType.Numeric),
        new JdeField("Z1CNFD", "Z1CNFD", JdeDataType.Numeric),
        new JdeField("Z1CSCD", "Z1CSCD", JdeDataType.Numeric),
        new JdeField("Z1DSC1", "Z1DSC1", JdeDataType.String, 60),
        new JdeField("Z1RPER", "Z1RPER", JdeDataType.Numeric),
        new JdeField("Z1UOM", "Z1UOM", JdeDataType.String, 4),
        new JdeField("Z1SOQS", "Z1SOQS", JdeDataType.Numeric),
        new JdeField("Z1QYCL", "Z1QYCL", JdeDataType.Numeric),
        new JdeField("Z1CLRR", "Z1CLRR", JdeDataType.String, 4),
        new JdeField("Z1BN01", "Z1BN01", JdeDataType.Numeric),
        new JdeField("Z1BTY1", "Z1BTY1", JdeDataType.String, 4),
        new JdeField("Z1SLSP", "Z1SLSP", JdeDataType.Numeric),
        new JdeField("Z1ABR1", "Z1ABR1", JdeDataType.String, 24),
        new JdeField("Z1ABR2", "Z1ABR2", JdeDataType.String, 24),
        new JdeField("Z1ABR3", "Z1ABR3", JdeDataType.String, 24),
        new JdeField("Z1ABR4", "Z1ABR4", JdeDataType.String, 24),
        new JdeField("Z1ABT1", "Z1ABT1", JdeDataType.String, 2),
        new JdeField("Z1ABT2", "Z1ABT2", JdeDataType.String, 2),
        new JdeField("Z1ABT3", "Z1ABT3", JdeDataType.String, 2),
        new JdeField("Z1ABT4", "Z1ABT4", JdeDataType.String, 2),
        new JdeField("Z1UM", "Z1UM", JdeDataType.String, 4),
        new JdeField("Z1SBL", "Z1SBL", JdeDataType.String, 16),
        new JdeField("Z1SBLT", "Z1SBLT", JdeDataType.String, 2),
        new JdeField("Z1ANI", "Z1ANI", JdeDataType.String, 58),
        new JdeField("Z1DAMD", "Z1DAMD", JdeDataType.Numeric),
        new JdeField("Z1DAMF", "Z1DAMF", JdeDataType.Numeric),
        new JdeField("Z1EMCU", "Z1EMCU", JdeDataType.String, 24),
        new JdeField("Z1CO", "Z1CO", JdeDataType.String, 10),
        new JdeField("Z1FLIT", "Z1FLIT", JdeDataType.Numeric),
        new JdeField("Z1ICU", "Z1ICU", JdeDataType.Numeric),
        new JdeField("Z1ICUT", "Z1ICUT", JdeDataType.String, 4),
        new JdeField("Z1DE01", "Z1DE01", JdeDataType.String, 6),
        new JdeField("Z1DE02", "Z1DE02", JdeDataType.String, 6),
        new JdeField("Z1DE03", "Z1DE03", JdeDataType.String, 6),
        new JdeField("Z1DE04", "Z1DE04", JdeDataType.String, 6),
        new JdeField("Z1DE05", "Z1DE05", JdeDataType.String, 6),
        new JdeField("Z1URCD", "Z1URCD", JdeDataType.String, 4),
        new JdeField("Z1URDT", "Z1URDT", JdeDataType.Numeric),
        new JdeField("Z1URAT", "Z1URAT", JdeDataType.Numeric),
        new JdeField("Z1URAB", "Z1URAB", JdeDataType.Numeric),
        new JdeField("Z1URRF", "Z1URRF", JdeDataType.String, 30),
        new JdeField("Z1USER", "Z1USER", JdeDataType.String, 20),
        new JdeField("Z1PID", "Z1PID", JdeDataType.String, 20),
        new JdeField("Z1JOBN", "Z1JOBN", JdeDataType.String, 20),
        new JdeField("Z1UPMJ", "Z1UPMJ", JdeDataType.Numeric),
        new JdeField("Z1TDAY", "Z1TDAY", JdeDataType.Numeric),
        new JdeField("Z1EDOC", "Z1EDOC", JdeDataType.Numeric),
        new JdeField("Z1TPUR", "Z1TPUR", JdeDataType.String, 4),
        new JdeField("Z1CITM", "Z1CITM", JdeDataType.String, 50),
        new JdeField("Z1EDST", "Z1EDST", JdeDataType.String, 12),
        new JdeField("Z1IVD", "Z1IVD", JdeDataType.Numeric),
        new JdeField("Z1ASN", "Z1ASN", JdeDataType.String, 16),
        new JdeField("Z1MNQ", "Z1MNQ", JdeDataType.Numeric),
        new JdeField("Z1LEDG", "Z1LEDG", JdeDataType.String, 4),
        new JdeField("Z1UPRC", "Z1UPRC", JdeDataType.Numeric),
        new JdeField("Z1FUP", "Z1FUP", JdeDataType.Numeric),
        new JdeField("Z1GLC", "Z1GLC", JdeDataType.String, 8),
        new JdeField("Z1FVMD", "Z1FVMD", JdeDataType.String, 2),
        new JdeField("Z1FVTR", "Z1FVTR", JdeDataType.Numeric),
        new JdeField("Z1QYAP", "Z1QYAP", JdeDataType.Numeric),
        new JdeField("Z1ACNT", "Z1ACNT", JdeDataType.String, 2),
        new JdeField("Z1EFTJ", "Z1EFTJ", JdeDataType.Numeric),
        new JdeField("Z1EXDJ", "Z1EXDJ", JdeDataType.Numeric),
        new JdeField("Z1BDCS", "Z1BDCS", JdeDataType.Numeric),
        new JdeField("Z1BDCL", "Z1BDCL", JdeDataType.String, 2),
        new JdeField("Z1FRMN", "Z1FRMN", JdeDataType.String, 20),
        new JdeField("Z1MQYQ", "Z1MQYQ", JdeDataType.Numeric),
        new JdeField("Z1MAQY", "Z1MAQY", JdeDataType.Numeric),
        new JdeField("Z1QYOA", "Z1QYOA", JdeDataType.Numeric),
        new JdeField("Z1AGNB", "Z1AGNB", JdeDataType.String, 60),
        new JdeField("Z1OKCO", "Z1OKCO", JdeDataType.String, 10),
        new JdeField("Z1OORN", "Z1OORN", JdeDataType.String, 16),
        new JdeField("Z1OCTO", "Z1OCTO", JdeDataType.String, 4),
        new JdeField("Z1OGNO", "Z1OGNO", JdeDataType.Numeric),
        new JdeField("Z1RORN", "Z1RORN", JdeDataType.String, 16),
        new JdeField("Z1RCTO", "Z1RCTO", JdeDataType.String, 4),
        new JdeField("Z1RLLN", "Z1RLLN", JdeDataType.Numeric),
        new JdeField("Z1SHAN", "Z1SHAN", JdeDataType.Numeric),
        new JdeField("Z1PA8", "Z1PA8", JdeDataType.Numeric),
        new JdeField("Z1TRDJ", "Z1TRDJ", JdeDataType.Numeric),
        new JdeField("Z1LITM", "Z1LITM", JdeDataType.String, 50),
        new JdeField("Z1AITM", "Z1AITM", JdeDataType.String, 50),
        new JdeField("Z1RLIT", "Z1RLIT", JdeDataType.String, 16),
        new JdeField("Z1KTLN", "Z1KTLN", JdeDataType.Numeric),
        new JdeField("Z1CPNT", "Z1CPNT", JdeDataType.Numeric),
        new JdeField("Z1RKIT", "Z1RKIT", JdeDataType.Numeric),
        new JdeField("Z1KTP", "Z1KTP", JdeDataType.Numeric),
        new JdeField("Z1AEXP", "Z1AEXP", JdeDataType.Numeric),
        new JdeField("Z1UNCS", "Z1UNCS", JdeDataType.Numeric),
        new JdeField("Z1ECST", "Z1ECST", JdeDataType.Numeric),
        new JdeField("Z1ODOC", "Z1ODOC", JdeDataType.Numeric),
        new JdeField("Z1ODCT", "Z1ODCT", JdeDataType.String, 4),
        new JdeField("Z1OKC", "Z1OKC", JdeDataType.String, 10),
        new JdeField("Z1TAX1", "Z1TAX1", JdeDataType.String, 2),
        new JdeField("Z1TXA1", "Z1TXA1", JdeDataType.String, 20),
        new JdeField("Z1EXR1", "Z1EXR1", JdeDataType.String, 4),
        new JdeField("Z1VEND", "Z1VEND", JdeDataType.Numeric),
        new JdeField("Z1UOM1", "Z1UOM1", JdeDataType.String, 4),
        new JdeField("Z1CRR", "Z1CRR", JdeDataType.Numeric),
        new JdeField("Z1FPRC", "Z1FPRC", JdeDataType.Numeric),
        new JdeField("Z1FEA", "Z1FEA", JdeDataType.Numeric),
        new JdeField("Z1FUC", "Z1FUC", JdeDataType.Numeric),
        new JdeField("Z1FEC", "Z1FEC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4576Z1_0", "Primary Key on Z1EDUS, Z1EDBT, Z1EDTN, Z1EDLN", new[] { "Z1EDUS", "Z1EDBT", "Z1EDTN", "Z1EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
