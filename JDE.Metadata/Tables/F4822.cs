using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4822 - .
/// </summary>
public class F4822 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W4DOCO.
        /// </summary>
        public const string W4DOCO = "W4DOCO";

        /// <summary>
        /// W4DCTO.
        /// </summary>
        public const string W4DCTO = "W4DCTO";

        /// <summary>
        /// W4KCOO.
        /// </summary>
        public const string W4KCOO = "W4KCOO";

        /// <summary>
        /// W4PCTN.
        /// </summary>
        public const string W4PCTN = "W4PCTN";

        /// <summary>
        /// W4PCTT.
        /// </summary>
        public const string W4PCTT = "W4PCTT";

        /// <summary>
        /// W4PCKO.
        /// </summary>
        public const string W4PCKO = "W4PCKO";

        /// <summary>
        /// W4APPL.
        /// </summary>
        public const string W4APPL = "W4APPL";

        /// <summary>
        /// W4ADJN.
        /// </summary>
        public const string W4ADJN = "W4ADJN";

        /// <summary>
        /// W4COCH.
        /// </summary>
        public const string W4COCH = "W4COCH";

        /// <summary>
        /// W4LNID.
        /// </summary>
        public const string W4LNID = "W4LNID";

        /// <summary>
        /// W4OPIM.
        /// </summary>
        public const string W4OPIM = "W4OPIM";

        /// <summary>
        /// W4PRTP.
        /// </summary>
        public const string W4PRTP = "W4PRTP";

        /// <summary>
        /// W4BLSP.
        /// </summary>
        public const string W4BLSP = "W4BLSP";

        /// <summary>
        /// W4AN8O.
        /// </summary>
        public const string W4AN8O = "W4AN8O";

        /// <summary>
        /// W4AN8J.
        /// </summary>
        public const string W4AN8J = "W4AN8J";

        /// <summary>
        /// W4PTC.
        /// </summary>
        public const string W4PTC = "W4PTC";

        /// <summary>
        /// W4CO.
        /// </summary>
        public const string W4CO = "W4CO";

        /// <summary>
        /// W4MCU.
        /// </summary>
        public const string W4MCU = "W4MCU";

        /// <summary>
        /// W4SBL.
        /// </summary>
        public const string W4SBL = "W4SBL";

        /// <summary>
        /// W4SBLT.
        /// </summary>
        public const string W4SBLT = "W4SBLT";

        /// <summary>
        /// W4GLC.
        /// </summary>
        public const string W4GLC = "W4GLC";

        /// <summary>
        /// W4BTFR.
        /// </summary>
        public const string W4BTFR = "W4BTFR";

        /// <summary>
        /// W4BTDT.
        /// </summary>
        public const string W4BTDT = "W4BTDT";

        /// <summary>
        /// W4DGL.
        /// </summary>
        public const string W4DGL = "W4DGL";

        /// <summary>
        /// W4DDJ.
        /// </summary>
        public const string W4DDJ = "W4DDJ";

        /// <summary>
        /// W4DSVJ.
        /// </summary>
        public const string W4DSVJ = "W4DSVJ";

        /// <summary>
        /// W4ICU.
        /// </summary>
        public const string W4ICU = "W4ICU";

        /// <summary>
        /// W4DOCZ.
        /// </summary>
        public const string W4DOCZ = "W4DOCZ";

        /// <summary>
        /// W4DCTI.
        /// </summary>
        public const string W4DCTI = "W4DCTI";

        /// <summary>
        /// W4KCOI.
        /// </summary>
        public const string W4KCOI = "W4KCOI";

        /// <summary>
        /// W4SFX.
        /// </summary>
        public const string W4SFX = "W4SFX";

        /// <summary>
        /// W4APDT.
        /// </summary>
        public const string W4APDT = "W4APDT";

        /// <summary>
        /// W4APPO.
        /// </summary>
        public const string W4APPO = "W4APPO";

        /// <summary>
        /// W4VOID.
        /// </summary>
        public const string W4VOID = "W4VOID";

        /// <summary>
        /// W4INVF.
        /// </summary>
        public const string W4INVF = "W4INVF";

        /// <summary>
        /// W4INTY.
        /// </summary>
        public const string W4INTY = "W4INTY";

        /// <summary>
        /// W4U.
        /// </summary>
        public const string W4U = "W4U";

        /// <summary>
        /// W4UM.
        /// </summary>
        public const string W4UM = "W4UM";

        /// <summary>
        /// W4UP.
        /// </summary>
        public const string W4UP = "W4UP";

        /// <summary>
        /// W4FUP.
        /// </summary>
        public const string W4FUP = "W4FUP";

        /// <summary>
        /// W4PUHP.
        /// </summary>
        public const string W4PUHP = "W4PUHP";

        /// <summary>
        /// W4AA.
        /// </summary>
        public const string W4AA = "W4AA";

        /// <summary>
        /// W4ACR.
        /// </summary>
        public const string W4ACR = "W4ACR";

        /// <summary>
        /// W4THPD.
        /// </summary>
        public const string W4THPD = "W4THPD";

        /// <summary>
        /// W4FHPD.
        /// </summary>
        public const string W4FHPD = "W4FHPD";

        /// <summary>
        /// W4RTHP.
        /// </summary>
        public const string W4RTHP = "W4RTHP";

        /// <summary>
        /// W4PTHP.
        /// </summary>
        public const string W4PTHP = "W4PTHP";

        /// <summary>
        /// W4FTHP.
        /// </summary>
        public const string W4FTHP = "W4FTHP";

        /// <summary>
        /// W4TXA1.
        /// </summary>
        public const string W4TXA1 = "W4TXA1";

        /// <summary>
        /// W4EXR1.
        /// </summary>
        public const string W4EXR1 = "W4EXR1";

        /// <summary>
        /// W4STAM.
        /// </summary>
        public const string W4STAM = "W4STAM";

        /// <summary>
        /// W4CTAM.
        /// </summary>
        public const string W4CTAM = "W4CTAM";

        /// <summary>
        /// W4PTAM.
        /// </summary>
        public const string W4PTAM = "W4PTAM";

        /// <summary>
        /// W4FPTA.
        /// </summary>
        public const string W4FPTA = "W4FPTA";

        /// <summary>
        /// W4ATXA.
        /// </summary>
        public const string W4ATXA = "W4ATXA";

        /// <summary>
        /// W4CTXA.
        /// </summary>
        public const string W4CTXA = "W4CTXA";

        /// <summary>
        /// W4PATX.
        /// </summary>
        public const string W4PATX = "W4PATX";

        /// <summary>
        /// W4FATX.
        /// </summary>
        public const string W4FATX = "W4FATX";

        /// <summary>
        /// W4ATXN.
        /// </summary>
        public const string W4ATXN = "W4ATXN";

        /// <summary>
        /// W4CTXN.
        /// </summary>
        public const string W4CTXN = "W4CTXN";

        /// <summary>
        /// W4RTRE.
        /// </summary>
        public const string W4RTRE = "W4RTRE";

        /// <summary>
        /// W4RGLC.
        /// </summary>
        public const string W4RGLC = "W4RGLC";

        /// <summary>
        /// W4PRET.
        /// </summary>
        public const string W4PRET = "W4PRET";

        /// <summary>
        /// W4RTNR.
        /// </summary>
        public const string W4RTNR = "W4RTNR";

        /// <summary>
        /// W4RCTL.
        /// </summary>
        public const string W4RCTL = "W4RCTL";

        /// <summary>
        /// W4RTNG.
        /// </summary>
        public const string W4RTNG = "W4RTNG";

        /// <summary>
        /// W4FTNG.
        /// </summary>
        public const string W4FTNG = "W4FTNG";

        /// <summary>
        /// W4RTNP.
        /// </summary>
        public const string W4RTNP = "W4RTNP";

        /// <summary>
        /// W4FTNP.
        /// </summary>
        public const string W4FTNP = "W4FTNP";

        /// <summary>
        /// W4DDTR.
        /// </summary>
        public const string W4DDTR = "W4DDTR";

        /// <summary>
        /// W4FDTR.
        /// </summary>
        public const string W4FDTR = "W4FDTR";

        /// <summary>
        /// W4STML.
        /// </summary>
        public const string W4STML = "W4STML";

        /// <summary>
        /// W4FTML.
        /// </summary>
        public const string W4FTML = "W4FTML";

        /// <summary>
        /// W4PSMA.
        /// </summary>
        public const string W4PSMA = "W4PSMA";

        /// <summary>
        /// W4FSMA.
        /// </summary>
        public const string W4FSMA = "W4FSMA";

        /// <summary>
        /// W4RTN1.
        /// </summary>
        public const string W4RTN1 = "W4RTN1";

        /// <summary>
        /// W4SMRT.
        /// </summary>
        public const string W4SMRT = "W4SMRT";

        /// <summary>
        /// W4SMRF.
        /// </summary>
        public const string W4SMRF = "W4SMRF";

        /// <summary>
        /// W4SMRP.
        /// </summary>
        public const string W4SMRP = "W4SMRP";

        /// <summary>
        /// W4SMPF.
        /// </summary>
        public const string W4SMPF = "W4SMPF";

        /// <summary>
        /// W4TLAB.
        /// </summary>
        public const string W4TLAB = "W4TLAB";

        /// <summary>
        /// W4FLAB.
        /// </summary>
        public const string W4FLAB = "W4FLAB";

        /// <summary>
        /// W4TBUR.
        /// </summary>
        public const string W4TBUR = "W4TBUR";

        /// <summary>
        /// W4FBUR.
        /// </summary>
        public const string W4FBUR = "W4FBUR";

        /// <summary>
        /// W4ADSC.
        /// </summary>
        public const string W4ADSC = "W4ADSC";

        /// <summary>
        /// W4CDS.
        /// </summary>
        public const string W4CDS = "W4CDS";

        /// <summary>
        /// W4CRRM.
        /// </summary>
        public const string W4CRRM = "W4CRRM";

        /// <summary>
        /// W4CRCD.
        /// </summary>
        public const string W4CRCD = "W4CRCD";

        /// <summary>
        /// W4CRCF.
        /// </summary>
        public const string W4CRCF = "W4CRCF";

        /// <summary>
        /// W4CRR.
        /// </summary>
        public const string W4CRR = "W4CRR";

        /// <summary>
        /// W4CRRD.
        /// </summary>
        public const string W4CRRD = "W4CRRD";

        /// <summary>
        /// W4RMK.
        /// </summary>
        public const string W4RMK = "W4RMK";

        /// <summary>
        /// W4MIVL.
        /// </summary>
        public const string W4MIVL = "W4MIVL";

        /// <summary>
        /// W4MISM.
        /// </summary>
        public const string W4MISM = "W4MISM";

        /// <summary>
        /// W4PID.
        /// </summary>
        public const string W4PID = "W4PID";

        /// <summary>
        /// W4JOBN.
        /// </summary>
        public const string W4JOBN = "W4JOBN";

        /// <summary>
        /// W4USER.
        /// </summary>
        public const string W4USER = "W4USER";

        /// <summary>
        /// W4MUPM.
        /// </summary>
        public const string W4MUPM = "W4MUPM";

        /// <summary>
        /// W4UPMT.
        /// </summary>
        public const string W4UPMT = "W4UPMT";

        /// <summary>
        /// W4VGCSF.
        /// </summary>
        public const string W4VGCSF = "W4VGCSF";

        /// <summary>
        /// W4VGCOA.
        /// </summary>
        public const string W4VGCOA = "W4VGCOA";

        /// <summary>
        /// W4VVTY.
        /// </summary>
        public const string W4VVTY = "W4VVTY";

        /// <summary>
        /// W4VVTC.
        /// </summary>
        public const string W4VVTC = "W4VVTC";

        /// <summary>
        /// W4PYWP.
        /// </summary>
        public const string W4PYWP = "W4PYWP";

        /// <summary>
        /// W4DTFPTF.
        /// </summary>
        public const string W4DTFPTF = "W4DTFPTF";

        /// <summary>
        /// W4DTFPTT.
        /// </summary>
        public const string W4DTFPTT = "W4DTFPTT";

        /// <summary>
        /// W4DTIPTF.
        /// </summary>
        public const string W4DTIPTF = "W4DTIPTF";

        /// <summary>
        /// W4DTIPTT.
        /// </summary>
        public const string W4DTIPTT = "W4DTIPTT";

        /// <summary>
        /// W4CLNU.
        /// </summary>
        public const string W4CLNU = "W4CLNU";

        /// <summary>
        /// W4CLTT.
        /// </summary>
        public const string W4CLTT = "W4CLTT";

        /// <summary>
        /// W4CLKO.
        /// </summary>
        public const string W4CLKO = "W4CLKO";

        /// <summary>
        /// W4GCSC.
        /// </summary>
        public const string W4GCSC = "W4GCSC";

        /// <summary>
        /// W4RETD.
        /// </summary>
        public const string W4RETD = "W4RETD";

        /// <summary>
        /// W4FRETD.
        /// </summary>
        public const string W4FRETD = "W4FRETD";
    }

    /// <inheritdoc />
    public override string TableName => "F4822";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W4DOCO", "W4DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("W4DCTO", "W4DCTO", JdeDataType.String, 4, true, true),
        new JdeField("W4KCOO", "W4KCOO", JdeDataType.String, 10, true, true),
        new JdeField("W4PCTN", "W4PCTN", JdeDataType.Numeric),
        new JdeField("W4PCTT", "W4PCTT", JdeDataType.String, 4),
        new JdeField("W4PCKO", "W4PCKO", JdeDataType.String, 10),
        new JdeField("W4APPL", "W4APPL", JdeDataType.Numeric),
        new JdeField("W4ADJN", "W4ADJN", JdeDataType.Numeric),
        new JdeField("W4COCH", "W4COCH", JdeDataType.String, 6),
        new JdeField("W4LNID", "W4LNID", JdeDataType.Numeric),
        new JdeField("W4OPIM", "W4OPIM", JdeDataType.String, 30),
        new JdeField("W4PRTP", "W4PRTP", JdeDataType.String, 2),
        new JdeField("W4BLSP", "W4BLSP", JdeDataType.String, 2),
        new JdeField("W4AN8O", "W4AN8O", JdeDataType.Numeric),
        new JdeField("W4AN8J", "W4AN8J", JdeDataType.Numeric),
        new JdeField("W4PTC", "W4PTC", JdeDataType.String, 6),
        new JdeField("W4CO", "W4CO", JdeDataType.String, 10),
        new JdeField("W4MCU", "W4MCU", JdeDataType.String, 24),
        new JdeField("W4SBL", "W4SBL", JdeDataType.String, 16),
        new JdeField("W4SBLT", "W4SBLT", JdeDataType.String, 2),
        new JdeField("W4GLC", "W4GLC", JdeDataType.String, 8),
        new JdeField("W4BTFR", "W4BTFR", JdeDataType.Numeric),
        new JdeField("W4BTDT", "W4BTDT", JdeDataType.Numeric),
        new JdeField("W4DGL", "W4DGL", JdeDataType.Numeric),
        new JdeField("W4DDJ", "W4DDJ", JdeDataType.Numeric),
        new JdeField("W4DSVJ", "W4DSVJ", JdeDataType.Numeric),
        new JdeField("W4ICU", "W4ICU", JdeDataType.Numeric),
        new JdeField("W4DOCZ", "W4DOCZ", JdeDataType.Numeric, null, true, true),
        new JdeField("W4DCTI", "W4DCTI", JdeDataType.String, 4, true, true),
        new JdeField("W4KCOI", "W4KCOI", JdeDataType.String, 10, true, true),
        new JdeField("W4SFX", "W4SFX", JdeDataType.String, 6, true, true),
        new JdeField("W4APDT", "W4APDT", JdeDataType.Numeric),
        new JdeField("W4APPO", "W4APPO", JdeDataType.String, 2),
        new JdeField("W4VOID", "W4VOID", JdeDataType.String, 2),
        new JdeField("W4INVF", "W4INVF", JdeDataType.String, 20),
        new JdeField("W4INTY", "W4INTY", JdeDataType.String, 2),
        new JdeField("W4U", "W4U", JdeDataType.Numeric),
        new JdeField("W4UM", "W4UM", JdeDataType.String, 4),
        new JdeField("W4UP", "W4UP", JdeDataType.Numeric),
        new JdeField("W4FUP", "W4FUP", JdeDataType.Numeric),
        new JdeField("W4PUHP", "W4PUHP", JdeDataType.Numeric),
        new JdeField("W4AA", "W4AA", JdeDataType.Numeric),
        new JdeField("W4ACR", "W4ACR", JdeDataType.Numeric),
        new JdeField("W4THPD", "W4THPD", JdeDataType.Numeric),
        new JdeField("W4FHPD", "W4FHPD", JdeDataType.Numeric),
        new JdeField("W4RTHP", "W4RTHP", JdeDataType.Numeric),
        new JdeField("W4PTHP", "W4PTHP", JdeDataType.Numeric),
        new JdeField("W4FTHP", "W4FTHP", JdeDataType.Numeric),
        new JdeField("W4TXA1", "W4TXA1", JdeDataType.String, 20),
        new JdeField("W4EXR1", "W4EXR1", JdeDataType.String, 4),
        new JdeField("W4STAM", "W4STAM", JdeDataType.Numeric),
        new JdeField("W4CTAM", "W4CTAM", JdeDataType.Numeric),
        new JdeField("W4PTAM", "W4PTAM", JdeDataType.Numeric),
        new JdeField("W4FPTA", "W4FPTA", JdeDataType.Numeric),
        new JdeField("W4ATXA", "W4ATXA", JdeDataType.Numeric),
        new JdeField("W4CTXA", "W4CTXA", JdeDataType.Numeric),
        new JdeField("W4PATX", "W4PATX", JdeDataType.Numeric),
        new JdeField("W4FATX", "W4FATX", JdeDataType.Numeric),
        new JdeField("W4ATXN", "W4ATXN", JdeDataType.Numeric),
        new JdeField("W4CTXN", "W4CTXN", JdeDataType.Numeric),
        new JdeField("W4RTRE", "W4RTRE", JdeDataType.String, 2),
        new JdeField("W4RGLC", "W4RGLC", JdeDataType.String, 8),
        new JdeField("W4PRET", "W4PRET", JdeDataType.Numeric),
        new JdeField("W4RTNR", "W4RTNR", JdeDataType.String, 6),
        new JdeField("W4RCTL", "W4RCTL", JdeDataType.String, 2),
        new JdeField("W4RTNG", "W4RTNG", JdeDataType.Numeric),
        new JdeField("W4FTNG", "W4FTNG", JdeDataType.Numeric),
        new JdeField("W4RTNP", "W4RTNP", JdeDataType.Numeric),
        new JdeField("W4FTNP", "W4FTNP", JdeDataType.Numeric),
        new JdeField("W4DDTR", "W4DDTR", JdeDataType.Numeric),
        new JdeField("W4FDTR", "W4FDTR", JdeDataType.Numeric),
        new JdeField("W4STML", "W4STML", JdeDataType.Numeric),
        new JdeField("W4FTML", "W4FTML", JdeDataType.Numeric),
        new JdeField("W4PSMA", "W4PSMA", JdeDataType.Numeric),
        new JdeField("W4FSMA", "W4FSMA", JdeDataType.Numeric),
        new JdeField("W4RTN1", "W4RTN1", JdeDataType.String, 6),
        new JdeField("W4SMRT", "W4SMRT", JdeDataType.Numeric),
        new JdeField("W4SMRF", "W4SMRF", JdeDataType.Numeric),
        new JdeField("W4SMRP", "W4SMRP", JdeDataType.Numeric),
        new JdeField("W4SMPF", "W4SMPF", JdeDataType.Numeric),
        new JdeField("W4TLAB", "W4TLAB", JdeDataType.Numeric),
        new JdeField("W4FLAB", "W4FLAB", JdeDataType.Numeric),
        new JdeField("W4TBUR", "W4TBUR", JdeDataType.Numeric),
        new JdeField("W4FBUR", "W4FBUR", JdeDataType.Numeric),
        new JdeField("W4ADSC", "W4ADSC", JdeDataType.Numeric),
        new JdeField("W4CDS", "W4CDS", JdeDataType.Numeric),
        new JdeField("W4CRRM", "W4CRRM", JdeDataType.String, 2),
        new JdeField("W4CRCD", "W4CRCD", JdeDataType.String, 6),
        new JdeField("W4CRCF", "W4CRCF", JdeDataType.String, 6),
        new JdeField("W4CRR", "W4CRR", JdeDataType.Numeric),
        new JdeField("W4CRRD", "W4CRRD", JdeDataType.Numeric),
        new JdeField("W4RMK", "W4RMK", JdeDataType.String, 60),
        new JdeField("W4MIVL", "W4MIVL", JdeDataType.String, 2),
        new JdeField("W4MISM", "W4MISM", JdeDataType.String, 2),
        new JdeField("W4PID", "W4PID", JdeDataType.String, 20),
        new JdeField("W4JOBN", "W4JOBN", JdeDataType.String, 20),
        new JdeField("W4USER", "W4USER", JdeDataType.String, 20),
        new JdeField("W4MUPM", "W4MUPM", JdeDataType.Numeric),
        new JdeField("W4UPMT", "W4UPMT", JdeDataType.Numeric),
        new JdeField("W4VGCSF", "W4VGCSF", JdeDataType.String, 20),
        new JdeField("W4VGCOA", "W4VGCOA", JdeDataType.String, 20),
        new JdeField("W4VVTY", "W4VVTY", JdeDataType.String, 12),
        new JdeField("W4VVTC", "W4VVTC", JdeDataType.String, 20),
        new JdeField("W4PYWP", "W4PYWP", JdeDataType.String, 2),
        new JdeField("W4DTFPTF", "W4DTFPTF", JdeDataType.Numeric),
        new JdeField("W4DTFPTT", "W4DTFPTT", JdeDataType.Numeric),
        new JdeField("W4DTIPTF", "W4DTIPTF", JdeDataType.Numeric),
        new JdeField("W4DTIPTT", "W4DTIPTT", JdeDataType.Numeric),
        new JdeField("W4CLNU", "W4CLNU", JdeDataType.Numeric),
        new JdeField("W4CLTT", "W4CLTT", JdeDataType.String, 4),
        new JdeField("W4CLKO", "W4CLKO", JdeDataType.String, 10),
        new JdeField("W4GCSC", "W4GCSC", JdeDataType.String, 2),
        new JdeField("W4RETD", "W4RETD", JdeDataType.Numeric),
        new JdeField("W4FRETD", "W4FRETD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4822_0", "Primary Key on W4DOCZ, W4DCTI, W4KCOI, W4DOCO, W4DCTO, W4KCOO, W4SFX", new[] { "W4DOCZ", "W4DCTI", "W4KCOI", "W4DOCO", "W4DCTO", "W4KCOO", "W4SFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4822_10", "Index on W4ICU, W4AN8O, W4KCOI, W4DOCZ, W4DCTI", new[] { "W4ICU", "W4AN8O", "W4KCOI", "W4DOCZ", "W4DCTI" }),
        new JdeIndex("F4822_11", "Index on W4DOCO, W4DCTO, W4KCOO, SYS_NC00115$, SYS_NC00116$, W4COCH, W4LNID", new[] { "W4DOCO", "W4DCTO", "W4KCOO", "SYS_NC00115$", "SYS_NC00116$", "W4COCH", "W4LNID" }),
        new JdeIndex("F4822_12", "Index on W4DOCO, W4DCTO, W4KCOO, W4COCH, W4LNID, SYS_NC00115$, SYS_NC00116$", new[] { "W4DOCO", "W4DCTO", "W4KCOO", "W4COCH", "W4LNID", "SYS_NC00115$", "SYS_NC00116$" }),
        new JdeIndex("F4822_13", "Index on W4DOCO, W4DCTO, W4KCOO", new[] { "W4DOCO", "W4DCTO", "W4KCOO" }),
        new JdeIndex("F4822_14", "Index on W4PCTN, W4PCTT, W4PCKO, SYS_NC00115$, SYS_NC00116$", new[] { "W4PCTN", "W4PCTT", "W4PCKO", "SYS_NC00115$", "SYS_NC00116$" }),
        new JdeIndex("F4822_15", "Index on W4CLNU, W4CLTT, W4CLKO", new[] { "W4CLNU", "W4CLTT", "W4CLKO" }),
        new JdeIndex("F4822_2", "Index on W4ICU, W4DOCZ, W4DCTI, W4KCOI", new[] { "W4ICU", "W4DOCZ", "W4DCTI", "W4KCOI" }),
        new JdeIndex("F4822_3", "Index on W4DOCZ, W4DCTI, W4KCOI, W4ICU, W4SFX", new[] { "W4DOCZ", "W4DCTI", "W4KCOI", "W4ICU", "W4SFX" }),
        new JdeIndex("F4822_4", "Index on W4DOCO, W4DCTO, W4KCOO, W4COCH, W4LNID", new[] { "W4DOCO", "W4DCTO", "W4KCOO", "W4COCH", "W4LNID" }),
        new JdeIndex("F4822_7", "Index on W4DOCO, W4DCTO, W4KCOO, W4APPL, W4ADJN, W4COCH, W4LNID", new[] { "W4DOCO", "W4DCTO", "W4KCOO", "W4APPL", "W4ADJN", "W4COCH", "W4LNID" }),
        new JdeIndex("F4822_8", "Index on W4DOCO, W4DCTO, W4KCOO, W4COCH, W4LNID, W4APPL, W4ADJN", new[] { "W4DOCO", "W4DCTO", "W4KCOO", "W4COCH", "W4LNID", "W4APPL", "W4ADJN" }),
        new JdeIndex("F4822_9", "Index on W4DOCO, W4DCTO, W4KCOO, W4APPO", new[] { "W4DOCO", "W4DCTO", "W4KCOO", "W4APPO" })
    };
}
