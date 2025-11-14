using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS02 - .
/// </summary>
public class F54HS02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S2HSINO.
        /// </summary>
        public const string S2HSINO = "S2HSINO";

        /// <summary>
        /// S2UKID.
        /// </summary>
        public const string S2UKID = "S2UKID";

        /// <summary>
        /// S2AN8.
        /// </summary>
        public const string S2AN8 = "S2AN8";

        /// <summary>
        /// S2DL01.
        /// </summary>
        public const string S2DL01 = "S2DL01";

        /// <summary>
        /// S2HSIRL.
        /// </summary>
        public const string S2HSIRL = "S2HSIRL";

        /// <summary>
        /// S2HSIID.
        /// </summary>
        public const string S2HSIID = "S2HSIID";

        /// <summary>
        /// S2HSIPC.
        /// </summary>
        public const string S2HSIPC = "S2HSIPC";

        /// <summary>
        /// S2HSIPD.
        /// </summary>
        public const string S2HSIPD = "S2HSIPD";

        /// <summary>
        /// S2HSIEM.
        /// </summary>
        public const string S2HSIEM = "S2HSIEM";

        /// <summary>
        /// S2HSICON.
        /// </summary>
        public const string S2HSICON = "S2HSICON";

        /// <summary>
        /// S2JBCX.
        /// </summary>
        public const string S2JBCX = "S2JBCX";

        /// <summary>
        /// S2HSIINJD.
        /// </summary>
        public const string S2HSIINJD = "S2HSIINJD";

        /// <summary>
        /// S2WCMP.
        /// </summary>
        public const string S2WCMP = "S2WCMP";

        /// <summary>
        /// S2WET.
        /// </summary>
        public const string S2WET = "S2WET";

        /// <summary>
        /// S2HSICIA.
        /// </summary>
        public const string S2HSICIA = "S2HSICIA";

        /// <summary>
        /// S2HSICN.
        /// </summary>
        public const string S2HSICN = "S2HSICN";

        /// <summary>
        /// S2HSICIR.
        /// </summary>
        public const string S2HSICIR = "S2HSICIR";

        /// <summary>
        /// S2HMCO.
        /// </summary>
        public const string S2HMCO = "S2HMCO";

        /// <summary>
        /// S2HMCU.
        /// </summary>
        public const string S2HMCU = "S2HMCU";

        /// <summary>
        /// S2DSI.
        /// </summary>
        public const string S2DSI = "S2DSI";

        /// <summary>
        /// S2HSIRHD.
        /// </summary>
        public const string S2HSIRHD = "S2HSIRHD";

        /// <summary>
        /// S2JBCD.
        /// </summary>
        public const string S2JBCD = "S2JBCD";

        /// <summary>
        /// S2JBST.
        /// </summary>
        public const string S2JBST = "S2JBST";

        /// <summary>
        /// S2SEX.
        /// </summary>
        public const string S2SEX = "S2SEX";

        /// <summary>
        /// S2HSITOP.
        /// </summary>
        public const string S2HSITOP = "S2HSITOP";

        /// <summary>
        /// S2UOM.
        /// </summary>
        public const string S2UOM = "S2UOM";

        /// <summary>
        /// S2HSIHW.
        /// </summary>
        public const string S2HSIHW = "S2HSIHW";

        /// <summary>
        /// S2HSIWB.
        /// </summary>
        public const string S2HSIWB = "S2HSIWB";

        /// <summary>
        /// S2ANPA.
        /// </summary>
        public const string S2ANPA = "S2ANPA";

        /// <summary>
        /// S2XAN8.
        /// </summary>
        public const string S2XAN8 = "S2XAN8";

        /// <summary>
        /// S2DOB.
        /// </summary>
        public const string S2DOB = "S2DOB";

        /// <summary>
        /// S2HSIAG.
        /// </summary>
        public const string S2HSIAG = "S2HSIAG";

        /// <summary>
        /// S2SHFT.
        /// </summary>
        public const string S2SHFT = "S2SHFT";

        /// <summary>
        /// S2HSIDAC.
        /// </summary>
        public const string S2HSIDAC = "S2HSIDAC";

        /// <summary>
        /// S2HSIDC.
        /// </summary>
        public const string S2HSIDC = "S2HSIDC";

        /// <summary>
        /// S2HSIDAR.
        /// </summary>
        public const string S2HSIDAR = "S2HSIDAR";

        /// <summary>
        /// S2HSI3P.
        /// </summary>
        public const string S2HSI3P = "S2HSI3P";

        /// <summary>
        /// S2VR01.
        /// </summary>
        public const string S2VR01 = "S2VR01";

        /// <summary>
        /// S2MNTR.
        /// </summary>
        public const string S2MNTR = "S2MNTR";

        /// <summary>
        /// S2ADD1.
        /// </summary>
        public const string S2ADD1 = "S2ADD1";

        /// <summary>
        /// S2ADD2.
        /// </summary>
        public const string S2ADD2 = "S2ADD2";

        /// <summary>
        /// S2ADD3.
        /// </summary>
        public const string S2ADD3 = "S2ADD3";

        /// <summary>
        /// S2CTY1.
        /// </summary>
        public const string S2CTY1 = "S2CTY1";

        /// <summary>
        /// S2ADDS.
        /// </summary>
        public const string S2ADDS = "S2ADDS";

        /// <summary>
        /// S2ADDZ.
        /// </summary>
        public const string S2ADDZ = "S2ADDZ";

        /// <summary>
        /// S2COUN.
        /// </summary>
        public const string S2COUN = "S2COUN";

        /// <summary>
        /// S2CTR.
        /// </summary>
        public const string S2CTR = "S2CTR";

        /// <summary>
        /// S2PH1.
        /// </summary>
        public const string S2PH1 = "S2PH1";

        /// <summary>
        /// S2PH2.
        /// </summary>
        public const string S2PH2 = "S2PH2";

        /// <summary>
        /// S2PH3.
        /// </summary>
        public const string S2PH3 = "S2PH3";

        /// <summary>
        /// S2HSIEE.
        /// </summary>
        public const string S2HSIEE = "S2HSIEE";

        /// <summary>
        /// S2HSIIC.
        /// </summary>
        public const string S2HSIIC = "S2HSIIC";

        /// <summary>
        /// S2HSIIC2.
        /// </summary>
        public const string S2HSIIC2 = "S2HSIIC2";

        /// <summary>
        /// S2HSISI.
        /// </summary>
        public const string S2HSISI = "S2HSISI";

        /// <summary>
        /// S2HSICF.
        /// </summary>
        public const string S2HSICF = "S2HSICF";

        /// <summary>
        /// S2HSIP01.
        /// </summary>
        public const string S2HSIP01 = "S2HSIP01";

        /// <summary>
        /// S2HSIP02.
        /// </summary>
        public const string S2HSIP02 = "S2HSIP02";

        /// <summary>
        /// S2HSIP03.
        /// </summary>
        public const string S2HSIP03 = "S2HSIP03";

        /// <summary>
        /// S2HSIP04.
        /// </summary>
        public const string S2HSIP04 = "S2HSIP04";

        /// <summary>
        /// S2HSIP05.
        /// </summary>
        public const string S2HSIP05 = "S2HSIP05";

        /// <summary>
        /// S2HSIP06.
        /// </summary>
        public const string S2HSIP06 = "S2HSIP06";

        /// <summary>
        /// S2HSIP07.
        /// </summary>
        public const string S2HSIP07 = "S2HSIP07";

        /// <summary>
        /// S2HSIP08.
        /// </summary>
        public const string S2HSIP08 = "S2HSIP08";

        /// <summary>
        /// S2HSIP09.
        /// </summary>
        public const string S2HSIP09 = "S2HSIP09";

        /// <summary>
        /// S2HSIP10.
        /// </summary>
        public const string S2HSIP10 = "S2HSIP10";

        /// <summary>
        /// S2HSISR.
        /// </summary>
        public const string S2HSISR = "S2HSISR";

        /// <summary>
        /// S2HSISIG.
        /// </summary>
        public const string S2HSISIG = "S2HSISIG";

        /// <summary>
        /// S2HSIDOS.
        /// </summary>
        public const string S2HSIDOS = "S2HSIDOS";

        /// <summary>
        /// S2OSH.
        /// </summary>
        public const string S2OSH = "S2OSH";

        /// <summary>
        /// S2HSIYRC.
        /// </summary>
        public const string S2HSIYRC = "S2HSIYRC";

        /// <summary>
        /// S2CASE.
        /// </summary>
        public const string S2CASE = "S2CASE";

        /// <summary>
        /// S2CSFX.
        /// </summary>
        public const string S2CSFX = "S2CSFX";

        /// <summary>
        /// S2CSTS.
        /// </summary>
        public const string S2CSTS = "S2CSTS";

        /// <summary>
        /// S2DCLO.
        /// </summary>
        public const string S2DCLO = "S2DCLO";

        /// <summary>
        /// S2IR.
        /// </summary>
        public const string S2IR = "S2IR";

        /// <summary>
        /// S2HSIOI.
        /// </summary>
        public const string S2HSIOI = "S2HSIOI";

        /// <summary>
        /// S2HSIBP.
        /// </summary>
        public const string S2HSIBP = "S2HSIBP";

        /// <summary>
        /// S2NDAW.
        /// </summary>
        public const string S2NDAW = "S2NDAW";

        /// <summary>
        /// S2NDWA.
        /// </summary>
        public const string S2NDWA = "S2NDWA";

        /// <summary>
        /// S2DDEC.
        /// </summary>
        public const string S2DDEC = "S2DDEC";

        /// <summary>
        /// S2DRT.
        /// </summary>
        public const string S2DRT = "S2DRT";

        /// <summary>
        /// S2ONPRM.
        /// </summary>
        public const string S2ONPRM = "S2ONPRM";

        /// <summary>
        /// S2HSIOL.
        /// </summary>
        public const string S2HSIOL = "S2HSIOL";

        /// <summary>
        /// S2ERCHKBX.
        /// </summary>
        public const string S2ERCHKBX = "S2ERCHKBX";

        /// <summary>
        /// S2HCHKBX.
        /// </summary>
        public const string S2HCHKBX = "S2HCHKBX";

        /// <summary>
        /// S2FACAN8.
        /// </summary>
        public const string S2FACAN8 = "S2FACAN8";

        /// <summary>
        /// S2HSIMC.
        /// </summary>
        public const string S2HSIMC = "S2HSIMC";

        /// <summary>
        /// S2HSISD.
        /// </summary>
        public const string S2HSISD = "S2HSISD";

        /// <summary>
        /// S2HSIHCP.
        /// </summary>
        public const string S2HSIHCP = "S2HSIHCP";

        /// <summary>
        /// S2HSINOC.
        /// </summary>
        public const string S2HSINOC = "S2HSINOC";

        /// <summary>
        /// S2HSINC.
        /// </summary>
        public const string S2HSINC = "S2HSINC";

        /// <summary>
        /// S2HSIAT.
        /// </summary>
        public const string S2HSIAT = "S2HSIAT";

        /// <summary>
        /// S2HSIHO.
        /// </summary>
        public const string S2HSIHO = "S2HSIHO";

        /// <summary>
        /// S2HSIPO.
        /// </summary>
        public const string S2HSIPO = "S2HSIPO";

        /// <summary>
        /// S2HSIBJ.
        /// </summary>
        public const string S2HSIBJ = "S2HSIBJ";

        /// <summary>
        /// S2HSIBJO.
        /// </summary>
        public const string S2HSIBJO = "S2HSIBJO";

        /// <summary>
        /// S2HSIBL.
        /// </summary>
        public const string S2HSIBL = "S2HSIBL";

        /// <summary>
        /// S2HSIBW.
        /// </summary>
        public const string S2HSIBW = "S2HSIBW";

        /// <summary>
        /// S2HSIO1.
        /// </summary>
        public const string S2HSIO1 = "S2HSIO1";

        /// <summary>
        /// S2HSIO2.
        /// </summary>
        public const string S2HSIO2 = "S2HSIO2";

        /// <summary>
        /// S2HSIO3.
        /// </summary>
        public const string S2HSIO3 = "S2HSIO3";

        /// <summary>
        /// S2HSIO4.
        /// </summary>
        public const string S2HSIO4 = "S2HSIO4";

        /// <summary>
        /// S2URAB.
        /// </summary>
        public const string S2URAB = "S2URAB";

        /// <summary>
        /// S2URCD.
        /// </summary>
        public const string S2URCD = "S2URCD";

        /// <summary>
        /// S2URAT.
        /// </summary>
        public const string S2URAT = "S2URAT";

        /// <summary>
        /// S2URDT.
        /// </summary>
        public const string S2URDT = "S2URDT";

        /// <summary>
        /// S2URRF.
        /// </summary>
        public const string S2URRF = "S2URRF";

        /// <summary>
        /// S2USER.
        /// </summary>
        public const string S2USER = "S2USER";

        /// <summary>
        /// S2UPMJ.
        /// </summary>
        public const string S2UPMJ = "S2UPMJ";

        /// <summary>
        /// S2UPMT.
        /// </summary>
        public const string S2UPMT = "S2UPMT";

        /// <summary>
        /// S2JOBN.
        /// </summary>
        public const string S2JOBN = "S2JOBN";

        /// <summary>
        /// S2PID.
        /// </summary>
        public const string S2PID = "S2PID";

        /// <summary>
        /// S2HSISB.
        /// </summary>
        public const string S2HSISB = "S2HSISB";

        /// <summary>
        /// S2HSICS.
        /// </summary>
        public const string S2HSICS = "S2HSICS";

        /// <summary>
        /// S2HSIAMP.
        /// </summary>
        public const string S2HSIAMP = "S2HSIAMP";

        /// <summary>
        /// S2HSIFAT.
        /// </summary>
        public const string S2HSIFAT = "S2HSIFAT";

        /// <summary>
        /// S2HSIEYE.
        /// </summary>
        public const string S2HSIEYE = "S2HSIEYE";

        /// <summary>
        /// S2OSHRPT.
        /// </summary>
        public const string S2OSHRPT = "S2OSHRPT";

        /// <summary>
        /// S2HSIAGE.
        /// </summary>
        public const string S2HSIAGE = "S2HSIAGE";

        /// <summary>
        /// S2HSIU18.
        /// </summary>
        public const string S2HSIU18 = "S2HSIU18";

        /// <summary>
        /// S2HSIEPT.
        /// </summary>
        public const string S2HSIEPT = "S2HSIEPT";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S2HSINO", "S2HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S2UKID", "S2UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S2AN8", "S2AN8", JdeDataType.Numeric),
        new JdeField("S2DL01", "S2DL01", JdeDataType.String, 60),
        new JdeField("S2HSIRL", "S2HSIRL", JdeDataType.String, 4),
        new JdeField("S2HSIID", "S2HSIID", JdeDataType.String, 80),
        new JdeField("S2HSIPC", "S2HSIPC", JdeDataType.String, 2),
        new JdeField("S2HSIPD", "S2HSIPD", JdeDataType.String, 80),
        new JdeField("S2HSIEM", "S2HSIEM", JdeDataType.String, 2),
        new JdeField("S2HSICON", "S2HSICON", JdeDataType.String, 2),
        new JdeField("S2JBCX", "S2JBCX", JdeDataType.String, 60),
        new JdeField("S2HSIINJD", "S2HSIINJD", JdeDataType.String, 2),
        new JdeField("S2WCMP", "S2WCMP", JdeDataType.String, 8),
        new JdeField("S2WET", "S2WET", JdeDataType.String, 2),
        new JdeField("S2HSICIA", "S2HSICIA", JdeDataType.String, 2),
        new JdeField("S2HSICN", "S2HSICN", JdeDataType.String, 80),
        new JdeField("S2HSICIR", "S2HSICIR", JdeDataType.String, 4),
        new JdeField("S2HMCO", "S2HMCO", JdeDataType.String, 10),
        new JdeField("S2HMCU", "S2HMCU", JdeDataType.String, 24),
        new JdeField("S2DSI", "S2DSI", JdeDataType.Numeric),
        new JdeField("S2HSIRHD", "S2HSIRHD", JdeDataType.Numeric),
        new JdeField("S2JBCD", "S2JBCD", JdeDataType.String, 12),
        new JdeField("S2JBST", "S2JBST", JdeDataType.String, 8),
        new JdeField("S2SEX", "S2SEX", JdeDataType.String, 2),
        new JdeField("S2HSITOP", "S2HSITOP", JdeDataType.Numeric),
        new JdeField("S2UOM", "S2UOM", JdeDataType.String, 4),
        new JdeField("S2HSIHW", "S2HSIHW", JdeDataType.Numeric),
        new JdeField("S2HSIWB", "S2HSIWB", JdeDataType.Numeric),
        new JdeField("S2ANPA", "S2ANPA", JdeDataType.Numeric),
        new JdeField("S2XAN8", "S2XAN8", JdeDataType.Numeric),
        new JdeField("S2DOB", "S2DOB", JdeDataType.Numeric),
        new JdeField("S2HSIAG", "S2HSIAG", JdeDataType.String, 4),
        new JdeField("S2SHFT", "S2SHFT", JdeDataType.String, 2),
        new JdeField("S2HSIDAC", "S2HSIDAC", JdeDataType.String, 2),
        new JdeField("S2HSIDC", "S2HSIDC", JdeDataType.String, 80),
        new JdeField("S2HSIDAR", "S2HSIDAR", JdeDataType.String, 4),
        new JdeField("S2HSI3P", "S2HSI3P", JdeDataType.String, 2),
        new JdeField("S2VR01", "S2VR01", JdeDataType.String, 50),
        new JdeField("S2MNTR", "S2MNTR", JdeDataType.Numeric),
        new JdeField("S2ADD1", "S2ADD1", JdeDataType.String, 80),
        new JdeField("S2ADD2", "S2ADD2", JdeDataType.String, 80),
        new JdeField("S2ADD3", "S2ADD3", JdeDataType.String, 80),
        new JdeField("S2CTY1", "S2CTY1", JdeDataType.String, 50),
        new JdeField("S2ADDS", "S2ADDS", JdeDataType.String, 6),
        new JdeField("S2ADDZ", "S2ADDZ", JdeDataType.String, 24),
        new JdeField("S2COUN", "S2COUN", JdeDataType.String, 50),
        new JdeField("S2CTR", "S2CTR", JdeDataType.String, 6),
        new JdeField("S2PH1", "S2PH1", JdeDataType.String, 40),
        new JdeField("S2PH2", "S2PH2", JdeDataType.String, 40),
        new JdeField("S2PH3", "S2PH3", JdeDataType.String, 40),
        new JdeField("S2HSIEE", "S2HSIEE", JdeDataType.String, 150),
        new JdeField("S2HSIIC", "S2HSIIC", JdeDataType.String, 4),
        new JdeField("S2HSIIC2", "S2HSIIC2", JdeDataType.String, 4),
        new JdeField("S2HSISI", "S2HSISI", JdeDataType.String, 4),
        new JdeField("S2HSICF", "S2HSICF", JdeDataType.String, 4),
        new JdeField("S2HSIP01", "S2HSIP01", JdeDataType.String, 6),
        new JdeField("S2HSIP02", "S2HSIP02", JdeDataType.String, 6),
        new JdeField("S2HSIP03", "S2HSIP03", JdeDataType.String, 6),
        new JdeField("S2HSIP04", "S2HSIP04", JdeDataType.String, 6),
        new JdeField("S2HSIP05", "S2HSIP05", JdeDataType.String, 6),
        new JdeField("S2HSIP06", "S2HSIP06", JdeDataType.String, 6),
        new JdeField("S2HSIP07", "S2HSIP07", JdeDataType.String, 6),
        new JdeField("S2HSIP08", "S2HSIP08", JdeDataType.String, 6),
        new JdeField("S2HSIP09", "S2HSIP09", JdeDataType.String, 6),
        new JdeField("S2HSIP10", "S2HSIP10", JdeDataType.String, 6),
        new JdeField("S2HSISR", "S2HSISR", JdeDataType.String, 2),
        new JdeField("S2HSISIG", "S2HSISIG", JdeDataType.String, 80),
        new JdeField("S2HSIDOS", "S2HSIDOS", JdeDataType.Numeric),
        new JdeField("S2OSH", "S2OSH", JdeDataType.String, 2),
        new JdeField("S2HSIYRC", "S2HSIYRC", JdeDataType.Numeric),
        new JdeField("S2CASE", "S2CASE", JdeDataType.Numeric),
        new JdeField("S2CSFX", "S2CSFX", JdeDataType.Numeric),
        new JdeField("S2CSTS", "S2CSTS", JdeDataType.String, 4),
        new JdeField("S2DCLO", "S2DCLO", JdeDataType.Numeric),
        new JdeField("S2IR", "S2IR", JdeDataType.String, 4),
        new JdeField("S2HSIOI", "S2HSIOI", JdeDataType.String, 6),
        new JdeField("S2HSIBP", "S2HSIBP", JdeDataType.String, 8),
        new JdeField("S2NDAW", "S2NDAW", JdeDataType.Numeric),
        new JdeField("S2NDWA", "S2NDWA", JdeDataType.Numeric),
        new JdeField("S2DDEC", "S2DDEC", JdeDataType.Numeric),
        new JdeField("S2DRT", "S2DRT", JdeDataType.Numeric),
        new JdeField("S2ONPRM", "S2ONPRM", JdeDataType.String, 2),
        new JdeField("S2HSIOL", "S2HSIOL", JdeDataType.String, 6),
        new JdeField("S2ERCHKBX", "S2ERCHKBX", JdeDataType.String, 2),
        new JdeField("S2HCHKBX", "S2HCHKBX", JdeDataType.String, 2),
        new JdeField("S2FACAN8", "S2FACAN8", JdeDataType.Numeric),
        new JdeField("S2HSIMC", "S2HSIMC", JdeDataType.String, 2),
        new JdeField("S2HSISD", "S2HSISD", JdeDataType.String, 2),
        new JdeField("S2HSIHCP", "S2HSIHCP", JdeDataType.String, 80),
        new JdeField("S2HSINOC", "S2HSINOC", JdeDataType.String, 2),
        new JdeField("S2HSINC", "S2HSINC", JdeDataType.String, 2),
        new JdeField("S2HSIAT", "S2HSIAT", JdeDataType.String, 400),
        new JdeField("S2HSIHO", "S2HSIHO", JdeDataType.String, 400),
        new JdeField("S2HSIPO", "S2HSIPO", JdeDataType.String, 400),
        new JdeField("S2HSIBJ", "S2HSIBJ", JdeDataType.String, 4),
        new JdeField("S2HSIBJO", "S2HSIBJO", JdeDataType.String, 80),
        new JdeField("S2HSIBL", "S2HSIBL", JdeDataType.String, 4),
        new JdeField("S2HSIBW", "S2HSIBW", JdeDataType.String, 2),
        new JdeField("S2HSIO1", "S2HSIO1", JdeDataType.String, 8),
        new JdeField("S2HSIO2", "S2HSIO2", JdeDataType.String, 8),
        new JdeField("S2HSIO3", "S2HSIO3", JdeDataType.String, 8),
        new JdeField("S2HSIO4", "S2HSIO4", JdeDataType.String, 8),
        new JdeField("S2URAB", "S2URAB", JdeDataType.Numeric),
        new JdeField("S2URCD", "S2URCD", JdeDataType.String, 4),
        new JdeField("S2URAT", "S2URAT", JdeDataType.Numeric),
        new JdeField("S2URDT", "S2URDT", JdeDataType.Numeric),
        new JdeField("S2URRF", "S2URRF", JdeDataType.String, 30),
        new JdeField("S2USER", "S2USER", JdeDataType.String, 20),
        new JdeField("S2UPMJ", "S2UPMJ", JdeDataType.Numeric),
        new JdeField("S2UPMT", "S2UPMT", JdeDataType.Numeric),
        new JdeField("S2JOBN", "S2JOBN", JdeDataType.String, 20),
        new JdeField("S2PID", "S2PID", JdeDataType.String, 20),
        new JdeField("S2HSISB", "S2HSISB", JdeDataType.String, 4),
        new JdeField("S2HSICS", "S2HSICS", JdeDataType.String, 4),
        new JdeField("S2HSIAMP", "S2HSIAMP", JdeDataType.String, 2),
        new JdeField("S2HSIFAT", "S2HSIFAT", JdeDataType.String, 2),
        new JdeField("S2HSIEYE", "S2HSIEYE", JdeDataType.String, 2),
        new JdeField("S2OSHRPT", "S2OSHRPT", JdeDataType.String, 2),
        new JdeField("S2HSIAGE", "S2HSIAGE", JdeDataType.Numeric),
        new JdeField("S2HSIU18", "S2HSIU18", JdeDataType.String, 2),
        new JdeField("S2HSIEPT", "S2HSIEPT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS02_0", "Primary Key on S2HSINO, S2UKID", new[] { "S2HSINO", "S2UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54HS02_2", "Index on S2HSINO", new[] { "S2HSINO" }),
        new JdeIndex("F54HS02_3", "Index on S2HSIYRC, S2CASE", new[] { "S2HSIYRC", "S2CASE" })
    };
}
