using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47057W - .
/// </summary>
public class F47057W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D3EDTY.
        /// </summary>
        public const string D3EDTY = "D3EDTY";

        /// <summary>
        /// D3EDSQ.
        /// </summary>
        public const string D3EDSQ = "D3EDSQ";

        /// <summary>
        /// D3EKCO.
        /// </summary>
        public const string D3EKCO = "D3EKCO";

        /// <summary>
        /// D3EDOC.
        /// </summary>
        public const string D3EDOC = "D3EDOC";

        /// <summary>
        /// D3EDCT.
        /// </summary>
        public const string D3EDCT = "D3EDCT";

        /// <summary>
        /// D3EDLN.
        /// </summary>
        public const string D3EDLN = "D3EDLN";

        /// <summary>
        /// D3EDST.
        /// </summary>
        public const string D3EDST = "D3EDST";

        /// <summary>
        /// D3EDFT.
        /// </summary>
        public const string D3EDFT = "D3EDFT";

        /// <summary>
        /// D3EDDT.
        /// </summary>
        public const string D3EDDT = "D3EDDT";

        /// <summary>
        /// D3EDER.
        /// </summary>
        public const string D3EDER = "D3EDER";

        /// <summary>
        /// D3EDDL.
        /// </summary>
        public const string D3EDDL = "D3EDDL";

        /// <summary>
        /// D3EDSP.
        /// </summary>
        public const string D3EDSP = "D3EDSP";

        /// <summary>
        /// D3EDBT.
        /// </summary>
        public const string D3EDBT = "D3EDBT";

        /// <summary>
        /// D3PNID.
        /// </summary>
        public const string D3PNID = "D3PNID";

        /// <summary>
        /// D3ICU.
        /// </summary>
        public const string D3ICU = "D3ICU";

        /// <summary>
        /// D3ICUT.
        /// </summary>
        public const string D3ICUT = "D3ICUT";

        /// <summary>
        /// D3KCO.
        /// </summary>
        public const string D3KCO = "D3KCO";

        /// <summary>
        /// D3CO.
        /// </summary>
        public const string D3CO = "D3CO";

        /// <summary>
        /// D3MCU.
        /// </summary>
        public const string D3MCU = "D3MCU";

        /// <summary>
        /// D3DOCM.
        /// </summary>
        public const string D3DOCM = "D3DOCM";

        /// <summary>
        /// D3DCTM.
        /// </summary>
        public const string D3DCTM = "D3DCTM";

        /// <summary>
        /// D3SFXM.
        /// </summary>
        public const string D3SFXM = "D3SFXM";

        /// <summary>
        /// D3DMTJ.
        /// </summary>
        public const string D3DMTJ = "D3DMTJ";

        /// <summary>
        /// D3PYIN.
        /// </summary>
        public const string D3PYIN = "D3PYIN";

        /// <summary>
        /// D3PRMK.
        /// </summary>
        public const string D3PRMK = "D3PRMK";

        /// <summary>
        /// D3AN8.
        /// </summary>
        public const string D3AN8 = "D3AN8";

        /// <summary>
        /// D3PYE.
        /// </summary>
        public const string D3PYE = "D3PYE";

        /// <summary>
        /// D3CRRM.
        /// </summary>
        public const string D3CRRM = "D3CRRM";

        /// <summary>
        /// D3DMCD.
        /// </summary>
        public const string D3DMCD = "D3DMCD";

        /// <summary>
        /// D3CRCD.
        /// </summary>
        public const string D3CRCD = "D3CRCD";

        /// <summary>
        /// D3CDEC.
        /// </summary>
        public const string D3CDEC = "D3CDEC";

        /// <summary>
        /// D3CRR.
        /// </summary>
        public const string D3CRR = "D3CRR";

        /// <summary>
        /// D3DCT.
        /// </summary>
        public const string D3DCT = "D3DCT";

        /// <summary>
        /// D3DOC.
        /// </summary>
        public const string D3DOC = "D3DOC";

        /// <summary>
        /// D3SFX.
        /// </summary>
        public const string D3SFX = "D3SFX";

        /// <summary>
        /// D3VINV.
        /// </summary>
        public const string D3VINV = "D3VINV";

        /// <summary>
        /// D3SFXE.
        /// </summary>
        public const string D3SFXE = "D3SFXE";

        /// <summary>
        /// D3DCTA.
        /// </summary>
        public const string D3DCTA = "D3DCTA";

        /// <summary>
        /// D3DIVJ.
        /// </summary>
        public const string D3DIVJ = "D3DIVJ";

        /// <summary>
        /// D3DDJ.
        /// </summary>
        public const string D3DDJ = "D3DDJ";

        /// <summary>
        /// D3DDNJ.
        /// </summary>
        public const string D3DDNJ = "D3DDNJ";

        /// <summary>
        /// D3DSVJ.
        /// </summary>
        public const string D3DSVJ = "D3DSVJ";

        /// <summary>
        /// D3ODOC.
        /// </summary>
        public const string D3ODOC = "D3ODOC";

        /// <summary>
        /// D3ODCT.
        /// </summary>
        public const string D3ODCT = "D3ODCT";

        /// <summary>
        /// D3OSFX.
        /// </summary>
        public const string D3OSFX = "D3OSFX";

        /// <summary>
        /// D3OKCO.
        /// </summary>
        public const string D3OKCO = "D3OKCO";

        /// <summary>
        /// D3QUAL.
        /// </summary>
        public const string D3QUAL = "D3QUAL";

        /// <summary>
        /// D3PO.
        /// </summary>
        public const string D3PO = "D3PO";

        /// <summary>
        /// D3PDCT.
        /// </summary>
        public const string D3PDCT = "D3PDCT";

        /// <summary>
        /// D3PKCO.
        /// </summary>
        public const string D3PKCO = "D3PKCO";

        /// <summary>
        /// D3LNID.
        /// </summary>
        public const string D3LNID = "D3LNID";

        /// <summary>
        /// D3SFXO.
        /// </summary>
        public const string D3SFXO = "D3SFXO";

        /// <summary>
        /// D3OPSQ.
        /// </summary>
        public const string D3OPSQ = "D3OPSQ";

        /// <summary>
        /// D3ITM.
        /// </summary>
        public const string D3ITM = "D3ITM";

        /// <summary>
        /// D3VR01.
        /// </summary>
        public const string D3VR01 = "D3VR01";

        /// <summary>
        /// D3AG.
        /// </summary>
        public const string D3AG = "D3AG";

        /// <summary>
        /// D3ADSC.
        /// </summary>
        public const string D3ADSC = "D3ADSC";

        /// <summary>
        /// D3PAAP.
        /// </summary>
        public const string D3PAAP = "D3PAAP";

        /// <summary>
        /// D3ADSA.
        /// </summary>
        public const string D3ADSA = "D3ADSA";

        /// <summary>
        /// D3ATXN.
        /// </summary>
        public const string D3ATXN = "D3ATXN";

        /// <summary>
        /// D3ATXA.
        /// </summary>
        public const string D3ATXA = "D3ATXA";

        /// <summary>
        /// D3STAM.
        /// </summary>
        public const string D3STAM = "D3STAM";

        /// <summary>
        /// D3ACR.
        /// </summary>
        public const string D3ACR = "D3ACR";

        /// <summary>
        /// D3CDS.
        /// </summary>
        public const string D3CDS = "D3CDS";

        /// <summary>
        /// D3PFAP.
        /// </summary>
        public const string D3PFAP = "D3PFAP";

        /// <summary>
        /// D3CDSA.
        /// </summary>
        public const string D3CDSA = "D3CDSA";

        /// <summary>
        /// D3CTXN.
        /// </summary>
        public const string D3CTXN = "D3CTXN";

        /// <summary>
        /// D3CTXA.
        /// </summary>
        public const string D3CTXA = "D3CTXA";

        /// <summary>
        /// D3CTAM.
        /// </summary>
        public const string D3CTAM = "D3CTAM";

        /// <summary>
        /// D3TGA.
        /// </summary>
        public const string D3TGA = "D3TGA";

        /// <summary>
        /// D3TDSC.
        /// </summary>
        public const string D3TDSC = "D3TDSC";

        /// <summary>
        /// D3TAP.
        /// </summary>
        public const string D3TAP = "D3TAP";

        /// <summary>
        /// D3TDSA.
        /// </summary>
        public const string D3TDSA = "D3TDSA";

        /// <summary>
        /// D3TTXN.
        /// </summary>
        public const string D3TTXN = "D3TTXN";

        /// <summary>
        /// D3TTXA.
        /// </summary>
        public const string D3TTXA = "D3TTXA";

        /// <summary>
        /// D3TTAM.
        /// </summary>
        public const string D3TTAM = "D3TTAM";

        /// <summary>
        /// D3TXA1.
        /// </summary>
        public const string D3TXA1 = "D3TXA1";

        /// <summary>
        /// D3EXR1.
        /// </summary>
        public const string D3EXR1 = "D3EXR1";

        /// <summary>
        /// D3CRC.
        /// </summary>
        public const string D3CRC = "D3CRC";

        /// <summary>
        /// D3RMK.
        /// </summary>
        public const string D3RMK = "D3RMK";

        /// <summary>
        /// D3NSF.
        /// </summary>
        public const string D3NSF = "D3NSF";

        /// <summary>
        /// D3AR.
        /// </summary>
        public const string D3AR = "D3AR";

        /// <summary>
        /// D3PTC.
        /// </summary>
        public const string D3PTC = "D3PTC";

        /// <summary>
        /// D3RF.
        /// </summary>
        public const string D3RF = "D3RF";

        /// <summary>
        /// D3DRF.
        /// </summary>
        public const string D3DRF = "D3DRF";

        /// <summary>
        /// D3FNLP.
        /// </summary>
        public const string D3FNLP = "D3FNLP";

        /// <summary>
        /// D3U.
        /// </summary>
        public const string D3U = "D3U";

        /// <summary>
        /// D3UM.
        /// </summary>
        public const string D3UM = "D3UM";

        /// <summary>
        /// D3ALT6.
        /// </summary>
        public const string D3ALT6 = "D3ALT6";

        /// <summary>
        /// D3RP1.
        /// </summary>
        public const string D3RP1 = "D3RP1";

        /// <summary>
        /// D3RP2.
        /// </summary>
        public const string D3RP2 = "D3RP2";

        /// <summary>
        /// D3RP3.
        /// </summary>
        public const string D3RP3 = "D3RP3";

        /// <summary>
        /// D3GLC.
        /// </summary>
        public const string D3GLC = "D3GLC";

        /// <summary>
        /// D3GLBA.
        /// </summary>
        public const string D3GLBA = "D3GLBA";

        /// <summary>
        /// D3AM.
        /// </summary>
        public const string D3AM = "D3AM";

        /// <summary>
        /// D3AID2.
        /// </summary>
        public const string D3AID2 = "D3AID2";

        /// <summary>
        /// D3AM2.
        /// </summary>
        public const string D3AM2 = "D3AM2";

        /// <summary>
        /// D3UNIT.
        /// </summary>
        public const string D3UNIT = "D3UNIT";

        /// <summary>
        /// D3MCU2.
        /// </summary>
        public const string D3MCU2 = "D3MCU2";

        /// <summary>
        /// D3OBJ.
        /// </summary>
        public const string D3OBJ = "D3OBJ";

        /// <summary>
        /// D3SUB.
        /// </summary>
        public const string D3SUB = "D3SUB";

        /// <summary>
        /// D3SBLT.
        /// </summary>
        public const string D3SBLT = "D3SBLT";

        /// <summary>
        /// D3SBL.
        /// </summary>
        public const string D3SBL = "D3SBL";

        /// <summary>
        /// D3BAID.
        /// </summary>
        public const string D3BAID = "D3BAID";

        /// <summary>
        /// D3PYID.
        /// </summary>
        public const string D3PYID = "D3PYID";

        /// <summary>
        /// D3RC5.
        /// </summary>
        public const string D3RC5 = "D3RC5";

        /// <summary>
        /// D3HCRR.
        /// </summary>
        public const string D3HCRR = "D3HCRR";

        /// <summary>
        /// D3HDGJ.
        /// </summary>
        public const string D3HDGJ = "D3HDGJ";

        /// <summary>
        /// D3TXA3.
        /// </summary>
        public const string D3TXA3 = "D3TXA3";

        /// <summary>
        /// D3EXR3.
        /// </summary>
        public const string D3EXR3 = "D3EXR3";

        /// <summary>
        /// D3URCD.
        /// </summary>
        public const string D3URCD = "D3URCD";

        /// <summary>
        /// D3URDT.
        /// </summary>
        public const string D3URDT = "D3URDT";

        /// <summary>
        /// D3URAT.
        /// </summary>
        public const string D3URAT = "D3URAT";

        /// <summary>
        /// D3URAB.
        /// </summary>
        public const string D3URAB = "D3URAB";

        /// <summary>
        /// D3URRF.
        /// </summary>
        public const string D3URRF = "D3URRF";

        /// <summary>
        /// D3TORG.
        /// </summary>
        public const string D3TORG = "D3TORG";

        /// <summary>
        /// D3USER.
        /// </summary>
        public const string D3USER = "D3USER";

        /// <summary>
        /// D3PID.
        /// </summary>
        public const string D3PID = "D3PID";

        /// <summary>
        /// D3JOBN.
        /// </summary>
        public const string D3JOBN = "D3JOBN";

        /// <summary>
        /// D3UPMJ.
        /// </summary>
        public const string D3UPMJ = "D3UPMJ";

        /// <summary>
        /// D3TDAY.
        /// </summary>
        public const string D3TDAY = "D3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47057W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D3EDTY", "D3EDTY", JdeDataType.String, 2, true, true),
        new JdeField("D3EDSQ", "D3EDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D3EKCO", "D3EKCO", JdeDataType.String, 10, true, true),
        new JdeField("D3EDOC", "D3EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D3EDCT", "D3EDCT", JdeDataType.String, 4, true, true),
        new JdeField("D3EDLN", "D3EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("D3EDST", "D3EDST", JdeDataType.String, 12),
        new JdeField("D3EDFT", "D3EDFT", JdeDataType.String, 20),
        new JdeField("D3EDDT", "D3EDDT", JdeDataType.Numeric),
        new JdeField("D3EDER", "D3EDER", JdeDataType.String, 2),
        new JdeField("D3EDDL", "D3EDDL", JdeDataType.Numeric),
        new JdeField("D3EDSP", "D3EDSP", JdeDataType.String, 2),
        new JdeField("D3EDBT", "D3EDBT", JdeDataType.String, 30),
        new JdeField("D3PNID", "D3PNID", JdeDataType.String, 30),
        new JdeField("D3ICU", "D3ICU", JdeDataType.Numeric),
        new JdeField("D3ICUT", "D3ICUT", JdeDataType.String, 4),
        new JdeField("D3KCO", "D3KCO", JdeDataType.String, 10),
        new JdeField("D3CO", "D3CO", JdeDataType.String, 10),
        new JdeField("D3MCU", "D3MCU", JdeDataType.String, 24),
        new JdeField("D3DOCM", "D3DOCM", JdeDataType.Numeric),
        new JdeField("D3DCTM", "D3DCTM", JdeDataType.String, 4),
        new JdeField("D3SFXM", "D3SFXM", JdeDataType.String, 6),
        new JdeField("D3DMTJ", "D3DMTJ", JdeDataType.Numeric),
        new JdeField("D3PYIN", "D3PYIN", JdeDataType.String, 2),
        new JdeField("D3PRMK", "D3PRMK", JdeDataType.String, 20),
        new JdeField("D3AN8", "D3AN8", JdeDataType.Numeric),
        new JdeField("D3PYE", "D3PYE", JdeDataType.Numeric),
        new JdeField("D3CRRM", "D3CRRM", JdeDataType.String, 2),
        new JdeField("D3DMCD", "D3DMCD", JdeDataType.String, 2),
        new JdeField("D3CRCD", "D3CRCD", JdeDataType.String, 6),
        new JdeField("D3CDEC", "D3CDEC", JdeDataType.String, 2),
        new JdeField("D3CRR", "D3CRR", JdeDataType.Numeric),
        new JdeField("D3DCT", "D3DCT", JdeDataType.String, 4),
        new JdeField("D3DOC", "D3DOC", JdeDataType.Numeric),
        new JdeField("D3SFX", "D3SFX", JdeDataType.String, 6),
        new JdeField("D3VINV", "D3VINV", JdeDataType.String, 50),
        new JdeField("D3SFXE", "D3SFXE", JdeDataType.Numeric),
        new JdeField("D3DCTA", "D3DCTA", JdeDataType.String, 4),
        new JdeField("D3DIVJ", "D3DIVJ", JdeDataType.Numeric),
        new JdeField("D3DDJ", "D3DDJ", JdeDataType.Numeric),
        new JdeField("D3DDNJ", "D3DDNJ", JdeDataType.Numeric),
        new JdeField("D3DSVJ", "D3DSVJ", JdeDataType.Numeric),
        new JdeField("D3ODOC", "D3ODOC", JdeDataType.Numeric),
        new JdeField("D3ODCT", "D3ODCT", JdeDataType.String, 4),
        new JdeField("D3OSFX", "D3OSFX", JdeDataType.String, 6),
        new JdeField("D3OKCO", "D3OKCO", JdeDataType.String, 10),
        new JdeField("D3QUAL", "D3QUAL", JdeDataType.String, 4),
        new JdeField("D3PO", "D3PO", JdeDataType.String, 16),
        new JdeField("D3PDCT", "D3PDCT", JdeDataType.String, 4),
        new JdeField("D3PKCO", "D3PKCO", JdeDataType.String, 10),
        new JdeField("D3LNID", "D3LNID", JdeDataType.Numeric),
        new JdeField("D3SFXO", "D3SFXO", JdeDataType.String, 6),
        new JdeField("D3OPSQ", "D3OPSQ", JdeDataType.Numeric),
        new JdeField("D3ITM", "D3ITM", JdeDataType.Numeric),
        new JdeField("D3VR01", "D3VR01", JdeDataType.String, 50),
        new JdeField("D3AG", "D3AG", JdeDataType.Numeric),
        new JdeField("D3ADSC", "D3ADSC", JdeDataType.Numeric),
        new JdeField("D3PAAP", "D3PAAP", JdeDataType.Numeric),
        new JdeField("D3ADSA", "D3ADSA", JdeDataType.Numeric),
        new JdeField("D3ATXN", "D3ATXN", JdeDataType.Numeric),
        new JdeField("D3ATXA", "D3ATXA", JdeDataType.Numeric),
        new JdeField("D3STAM", "D3STAM", JdeDataType.Numeric),
        new JdeField("D3ACR", "D3ACR", JdeDataType.Numeric),
        new JdeField("D3CDS", "D3CDS", JdeDataType.Numeric),
        new JdeField("D3PFAP", "D3PFAP", JdeDataType.Numeric),
        new JdeField("D3CDSA", "D3CDSA", JdeDataType.Numeric),
        new JdeField("D3CTXN", "D3CTXN", JdeDataType.Numeric),
        new JdeField("D3CTXA", "D3CTXA", JdeDataType.Numeric),
        new JdeField("D3CTAM", "D3CTAM", JdeDataType.Numeric),
        new JdeField("D3TGA", "D3TGA", JdeDataType.Numeric),
        new JdeField("D3TDSC", "D3TDSC", JdeDataType.Numeric),
        new JdeField("D3TAP", "D3TAP", JdeDataType.Numeric),
        new JdeField("D3TDSA", "D3TDSA", JdeDataType.Numeric),
        new JdeField("D3TTXN", "D3TTXN", JdeDataType.Numeric),
        new JdeField("D3TTXA", "D3TTXA", JdeDataType.Numeric),
        new JdeField("D3TTAM", "D3TTAM", JdeDataType.Numeric),
        new JdeField("D3TXA1", "D3TXA1", JdeDataType.String, 20),
        new JdeField("D3EXR1", "D3EXR1", JdeDataType.String, 4),
        new JdeField("D3CRC", "D3CRC", JdeDataType.String, 6),
        new JdeField("D3RMK", "D3RMK", JdeDataType.String, 60),
        new JdeField("D3NSF", "D3NSF", JdeDataType.String, 2),
        new JdeField("D3AR", "D3AR", JdeDataType.String, 4),
        new JdeField("D3PTC", "D3PTC", JdeDataType.String, 6),
        new JdeField("D3RF", "D3RF", JdeDataType.String, 4),
        new JdeField("D3DRF", "D3DRF", JdeDataType.Numeric),
        new JdeField("D3FNLP", "D3FNLP", JdeDataType.String, 2),
        new JdeField("D3U", "D3U", JdeDataType.Numeric),
        new JdeField("D3UM", "D3UM", JdeDataType.String, 4),
        new JdeField("D3ALT6", "D3ALT6", JdeDataType.String, 2),
        new JdeField("D3RP1", "D3RP1", JdeDataType.String, 2),
        new JdeField("D3RP2", "D3RP2", JdeDataType.String, 2),
        new JdeField("D3RP3", "D3RP3", JdeDataType.String, 2),
        new JdeField("D3GLC", "D3GLC", JdeDataType.String, 8),
        new JdeField("D3GLBA", "D3GLBA", JdeDataType.String, 16),
        new JdeField("D3AM", "D3AM", JdeDataType.String, 2),
        new JdeField("D3AID2", "D3AID2", JdeDataType.String, 16),
        new JdeField("D3AM2", "D3AM2", JdeDataType.String, 2),
        new JdeField("D3UNIT", "D3UNIT", JdeDataType.String, 16),
        new JdeField("D3MCU2", "D3MCU2", JdeDataType.String, 24),
        new JdeField("D3OBJ", "D3OBJ", JdeDataType.String, 12),
        new JdeField("D3SUB", "D3SUB", JdeDataType.String, 16),
        new JdeField("D3SBLT", "D3SBLT", JdeDataType.String, 2),
        new JdeField("D3SBL", "D3SBL", JdeDataType.String, 16),
        new JdeField("D3BAID", "D3BAID", JdeDataType.String, 16),
        new JdeField("D3PYID", "D3PYID", JdeDataType.Numeric),
        new JdeField("D3RC5", "D3RC5", JdeDataType.Numeric),
        new JdeField("D3HCRR", "D3HCRR", JdeDataType.Numeric),
        new JdeField("D3HDGJ", "D3HDGJ", JdeDataType.Numeric),
        new JdeField("D3TXA3", "D3TXA3", JdeDataType.String, 20),
        new JdeField("D3EXR3", "D3EXR3", JdeDataType.String, 4),
        new JdeField("D3URCD", "D3URCD", JdeDataType.String, 4),
        new JdeField("D3URDT", "D3URDT", JdeDataType.Numeric),
        new JdeField("D3URAT", "D3URAT", JdeDataType.Numeric),
        new JdeField("D3URAB", "D3URAB", JdeDataType.Numeric),
        new JdeField("D3URRF", "D3URRF", JdeDataType.String, 30),
        new JdeField("D3TORG", "D3TORG", JdeDataType.String, 20),
        new JdeField("D3USER", "D3USER", JdeDataType.String, 20),
        new JdeField("D3PID", "D3PID", JdeDataType.String, 20),
        new JdeField("D3JOBN", "D3JOBN", JdeDataType.String, 20),
        new JdeField("D3UPMJ", "D3UPMJ", JdeDataType.Numeric),
        new JdeField("D3TDAY", "D3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47057W_0", "Primary Key on D3EDTY, D3EDSQ, D3EKCO, D3EDOC, D3EDCT, D3EDLN", new[] { "D3EDTY", "D3EDSQ", "D3EKCO", "D3EDOC", "D3EDCT", "D3EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
