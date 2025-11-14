using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS02M - .
/// </summary>
public class F54HS02M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I2HSINO.
        /// </summary>
        public const string I2HSINO = "I2HSINO";

        /// <summary>
        /// I2UKID.
        /// </summary>
        public const string I2UKID = "I2UKID";

        /// <summary>
        /// I2HSIMN.
        /// </summary>
        public const string I2HSIMN = "I2HSIMN";

        /// <summary>
        /// I2HSIMT.
        /// </summary>
        public const string I2HSIMT = "I2HSIMT";

        /// <summary>
        /// I2MODDT.
        /// </summary>
        public const string I2MODDT = "I2MODDT";

        /// <summary>
        /// I2AN8.
        /// </summary>
        public const string I2AN8 = "I2AN8";

        /// <summary>
        /// I2DL01.
        /// </summary>
        public const string I2DL01 = "I2DL01";

        /// <summary>
        /// I2HSIRL.
        /// </summary>
        public const string I2HSIRL = "I2HSIRL";

        /// <summary>
        /// I2HSIID.
        /// </summary>
        public const string I2HSIID = "I2HSIID";

        /// <summary>
        /// I2HSIPC.
        /// </summary>
        public const string I2HSIPC = "I2HSIPC";

        /// <summary>
        /// I2HSIPD.
        /// </summary>
        public const string I2HSIPD = "I2HSIPD";

        /// <summary>
        /// I2HSIEM.
        /// </summary>
        public const string I2HSIEM = "I2HSIEM";

        /// <summary>
        /// I2HSICON.
        /// </summary>
        public const string I2HSICON = "I2HSICON";

        /// <summary>
        /// I2JBCX.
        /// </summary>
        public const string I2JBCX = "I2JBCX";

        /// <summary>
        /// I2HSIINJD.
        /// </summary>
        public const string I2HSIINJD = "I2HSIINJD";

        /// <summary>
        /// I2WCMP.
        /// </summary>
        public const string I2WCMP = "I2WCMP";

        /// <summary>
        /// I2WET.
        /// </summary>
        public const string I2WET = "I2WET";

        /// <summary>
        /// I2HSICIA.
        /// </summary>
        public const string I2HSICIA = "I2HSICIA";

        /// <summary>
        /// I2HSICN.
        /// </summary>
        public const string I2HSICN = "I2HSICN";

        /// <summary>
        /// I2HSICIR.
        /// </summary>
        public const string I2HSICIR = "I2HSICIR";

        /// <summary>
        /// I2HMCO.
        /// </summary>
        public const string I2HMCO = "I2HMCO";

        /// <summary>
        /// I2HMCU.
        /// </summary>
        public const string I2HMCU = "I2HMCU";

        /// <summary>
        /// I2DSI.
        /// </summary>
        public const string I2DSI = "I2DSI";

        /// <summary>
        /// I2HSIRHD.
        /// </summary>
        public const string I2HSIRHD = "I2HSIRHD";

        /// <summary>
        /// I2JBCD.
        /// </summary>
        public const string I2JBCD = "I2JBCD";

        /// <summary>
        /// I2JBST.
        /// </summary>
        public const string I2JBST = "I2JBST";

        /// <summary>
        /// I2SEX.
        /// </summary>
        public const string I2SEX = "I2SEX";

        /// <summary>
        /// I2HSITOP.
        /// </summary>
        public const string I2HSITOP = "I2HSITOP";

        /// <summary>
        /// I2UOM.
        /// </summary>
        public const string I2UOM = "I2UOM";

        /// <summary>
        /// I2HSIHW.
        /// </summary>
        public const string I2HSIHW = "I2HSIHW";

        /// <summary>
        /// I2HSIWB.
        /// </summary>
        public const string I2HSIWB = "I2HSIWB";

        /// <summary>
        /// I2ANPA.
        /// </summary>
        public const string I2ANPA = "I2ANPA";

        /// <summary>
        /// I2XAN8.
        /// </summary>
        public const string I2XAN8 = "I2XAN8";

        /// <summary>
        /// I2DOB.
        /// </summary>
        public const string I2DOB = "I2DOB";

        /// <summary>
        /// I2HSIAG.
        /// </summary>
        public const string I2HSIAG = "I2HSIAG";

        /// <summary>
        /// I2SHFT.
        /// </summary>
        public const string I2SHFT = "I2SHFT";

        /// <summary>
        /// I2HSIDAC.
        /// </summary>
        public const string I2HSIDAC = "I2HSIDAC";

        /// <summary>
        /// I2HSIDC.
        /// </summary>
        public const string I2HSIDC = "I2HSIDC";

        /// <summary>
        /// I2HSIDAR.
        /// </summary>
        public const string I2HSIDAR = "I2HSIDAR";

        /// <summary>
        /// I2HSI3P.
        /// </summary>
        public const string I2HSI3P = "I2HSI3P";

        /// <summary>
        /// I2VR01.
        /// </summary>
        public const string I2VR01 = "I2VR01";

        /// <summary>
        /// I2MNTR.
        /// </summary>
        public const string I2MNTR = "I2MNTR";

        /// <summary>
        /// I2ADD1.
        /// </summary>
        public const string I2ADD1 = "I2ADD1";

        /// <summary>
        /// I2ADD2.
        /// </summary>
        public const string I2ADD2 = "I2ADD2";

        /// <summary>
        /// I2ADD3.
        /// </summary>
        public const string I2ADD3 = "I2ADD3";

        /// <summary>
        /// I2CTY1.
        /// </summary>
        public const string I2CTY1 = "I2CTY1";

        /// <summary>
        /// I2ADDS.
        /// </summary>
        public const string I2ADDS = "I2ADDS";

        /// <summary>
        /// I2ADDZ.
        /// </summary>
        public const string I2ADDZ = "I2ADDZ";

        /// <summary>
        /// I2COUN.
        /// </summary>
        public const string I2COUN = "I2COUN";

        /// <summary>
        /// I2CTR.
        /// </summary>
        public const string I2CTR = "I2CTR";

        /// <summary>
        /// I2PH1.
        /// </summary>
        public const string I2PH1 = "I2PH1";

        /// <summary>
        /// I2PH2.
        /// </summary>
        public const string I2PH2 = "I2PH2";

        /// <summary>
        /// I2PH3.
        /// </summary>
        public const string I2PH3 = "I2PH3";

        /// <summary>
        /// I2HSIEE.
        /// </summary>
        public const string I2HSIEE = "I2HSIEE";

        /// <summary>
        /// I2HSIIC.
        /// </summary>
        public const string I2HSIIC = "I2HSIIC";

        /// <summary>
        /// I2HSIIC2.
        /// </summary>
        public const string I2HSIIC2 = "I2HSIIC2";

        /// <summary>
        /// I2HSISI.
        /// </summary>
        public const string I2HSISI = "I2HSISI";

        /// <summary>
        /// I2HSICF.
        /// </summary>
        public const string I2HSICF = "I2HSICF";

        /// <summary>
        /// I2HSIP01.
        /// </summary>
        public const string I2HSIP01 = "I2HSIP01";

        /// <summary>
        /// I2HSIP02.
        /// </summary>
        public const string I2HSIP02 = "I2HSIP02";

        /// <summary>
        /// I2HSIP03.
        /// </summary>
        public const string I2HSIP03 = "I2HSIP03";

        /// <summary>
        /// I2HSIP04.
        /// </summary>
        public const string I2HSIP04 = "I2HSIP04";

        /// <summary>
        /// I2HSIP05.
        /// </summary>
        public const string I2HSIP05 = "I2HSIP05";

        /// <summary>
        /// I2HSIP06.
        /// </summary>
        public const string I2HSIP06 = "I2HSIP06";

        /// <summary>
        /// I2HSIP07.
        /// </summary>
        public const string I2HSIP07 = "I2HSIP07";

        /// <summary>
        /// I2HSIP08.
        /// </summary>
        public const string I2HSIP08 = "I2HSIP08";

        /// <summary>
        /// I2HSIP09.
        /// </summary>
        public const string I2HSIP09 = "I2HSIP09";

        /// <summary>
        /// I2HSIP10.
        /// </summary>
        public const string I2HSIP10 = "I2HSIP10";

        /// <summary>
        /// I2HSISR.
        /// </summary>
        public const string I2HSISR = "I2HSISR";

        /// <summary>
        /// I2HSISIG.
        /// </summary>
        public const string I2HSISIG = "I2HSISIG";

        /// <summary>
        /// I2HSIDOS.
        /// </summary>
        public const string I2HSIDOS = "I2HSIDOS";

        /// <summary>
        /// I2OSH.
        /// </summary>
        public const string I2OSH = "I2OSH";

        /// <summary>
        /// I2HSIYRC.
        /// </summary>
        public const string I2HSIYRC = "I2HSIYRC";

        /// <summary>
        /// I2CASE.
        /// </summary>
        public const string I2CASE = "I2CASE";

        /// <summary>
        /// I2CSFX.
        /// </summary>
        public const string I2CSFX = "I2CSFX";

        /// <summary>
        /// I2CSTS.
        /// </summary>
        public const string I2CSTS = "I2CSTS";

        /// <summary>
        /// I2DCLO.
        /// </summary>
        public const string I2DCLO = "I2DCLO";

        /// <summary>
        /// I2IR.
        /// </summary>
        public const string I2IR = "I2IR";

        /// <summary>
        /// I2HSIOI.
        /// </summary>
        public const string I2HSIOI = "I2HSIOI";

        /// <summary>
        /// I2HSIBP.
        /// </summary>
        public const string I2HSIBP = "I2HSIBP";

        /// <summary>
        /// I2NDAW.
        /// </summary>
        public const string I2NDAW = "I2NDAW";

        /// <summary>
        /// I2NDWA.
        /// </summary>
        public const string I2NDWA = "I2NDWA";

        /// <summary>
        /// I2DDEC.
        /// </summary>
        public const string I2DDEC = "I2DDEC";

        /// <summary>
        /// I2DRT.
        /// </summary>
        public const string I2DRT = "I2DRT";

        /// <summary>
        /// I2ONPRM.
        /// </summary>
        public const string I2ONPRM = "I2ONPRM";

        /// <summary>
        /// I2HSIOL.
        /// </summary>
        public const string I2HSIOL = "I2HSIOL";

        /// <summary>
        /// I2ERCHKBX.
        /// </summary>
        public const string I2ERCHKBX = "I2ERCHKBX";

        /// <summary>
        /// I2HCHKBX.
        /// </summary>
        public const string I2HCHKBX = "I2HCHKBX";

        /// <summary>
        /// I2FACAN8.
        /// </summary>
        public const string I2FACAN8 = "I2FACAN8";

        /// <summary>
        /// I2HSIMC.
        /// </summary>
        public const string I2HSIMC = "I2HSIMC";

        /// <summary>
        /// I2HSISD.
        /// </summary>
        public const string I2HSISD = "I2HSISD";

        /// <summary>
        /// I2HSIHCP.
        /// </summary>
        public const string I2HSIHCP = "I2HSIHCP";

        /// <summary>
        /// I2HSINOC.
        /// </summary>
        public const string I2HSINOC = "I2HSINOC";

        /// <summary>
        /// I2HSINC.
        /// </summary>
        public const string I2HSINC = "I2HSINC";

        /// <summary>
        /// I2HSIAT.
        /// </summary>
        public const string I2HSIAT = "I2HSIAT";

        /// <summary>
        /// I2HSIHO.
        /// </summary>
        public const string I2HSIHO = "I2HSIHO";

        /// <summary>
        /// I2HSIPO.
        /// </summary>
        public const string I2HSIPO = "I2HSIPO";

        /// <summary>
        /// I2HSIBJ.
        /// </summary>
        public const string I2HSIBJ = "I2HSIBJ";

        /// <summary>
        /// I2HSIBJO.
        /// </summary>
        public const string I2HSIBJO = "I2HSIBJO";

        /// <summary>
        /// I2HSIBL.
        /// </summary>
        public const string I2HSIBL = "I2HSIBL";

        /// <summary>
        /// I2HSIBW.
        /// </summary>
        public const string I2HSIBW = "I2HSIBW";

        /// <summary>
        /// I2HSIO1.
        /// </summary>
        public const string I2HSIO1 = "I2HSIO1";

        /// <summary>
        /// I2HSIO2.
        /// </summary>
        public const string I2HSIO2 = "I2HSIO2";

        /// <summary>
        /// I2HSIO3.
        /// </summary>
        public const string I2HSIO3 = "I2HSIO3";

        /// <summary>
        /// I2HSIO4.
        /// </summary>
        public const string I2HSIO4 = "I2HSIO4";

        /// <summary>
        /// I2URAB.
        /// </summary>
        public const string I2URAB = "I2URAB";

        /// <summary>
        /// I2URCD.
        /// </summary>
        public const string I2URCD = "I2URCD";

        /// <summary>
        /// I2URAT.
        /// </summary>
        public const string I2URAT = "I2URAT";

        /// <summary>
        /// I2URDT.
        /// </summary>
        public const string I2URDT = "I2URDT";

        /// <summary>
        /// I2URRF.
        /// </summary>
        public const string I2URRF = "I2URRF";

        /// <summary>
        /// I2USER.
        /// </summary>
        public const string I2USER = "I2USER";

        /// <summary>
        /// I2UPMJ.
        /// </summary>
        public const string I2UPMJ = "I2UPMJ";

        /// <summary>
        /// I2UPMT.
        /// </summary>
        public const string I2UPMT = "I2UPMT";

        /// <summary>
        /// I2JOBN.
        /// </summary>
        public const string I2JOBN = "I2JOBN";

        /// <summary>
        /// I2PID.
        /// </summary>
        public const string I2PID = "I2PID";

        /// <summary>
        /// I2HSISB.
        /// </summary>
        public const string I2HSISB = "I2HSISB";

        /// <summary>
        /// I2HSICS.
        /// </summary>
        public const string I2HSICS = "I2HSICS";

        /// <summary>
        /// I2HSIAMP.
        /// </summary>
        public const string I2HSIAMP = "I2HSIAMP";

        /// <summary>
        /// I2HSIFAT.
        /// </summary>
        public const string I2HSIFAT = "I2HSIFAT";

        /// <summary>
        /// I2HSIEYE.
        /// </summary>
        public const string I2HSIEYE = "I2HSIEYE";

        /// <summary>
        /// I2OSHRPT.
        /// </summary>
        public const string I2OSHRPT = "I2OSHRPT";

        /// <summary>
        /// I2HSIAGE.
        /// </summary>
        public const string I2HSIAGE = "I2HSIAGE";

        /// <summary>
        /// I2HSIU18.
        /// </summary>
        public const string I2HSIU18 = "I2HSIU18";

        /// <summary>
        /// I2HSIEPT.
        /// </summary>
        public const string I2HSIEPT = "I2HSIEPT";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS02M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I2HSINO", "I2HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I2UKID", "I2UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I2HSIMN", "I2HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I2HSIMT", "I2HSIMT", JdeDataType.String, 2),
        new JdeField("I2MODDT", "I2MODDT", JdeDataType.Numeric),
        new JdeField("I2AN8", "I2AN8", JdeDataType.Numeric),
        new JdeField("I2DL01", "I2DL01", JdeDataType.String, 60),
        new JdeField("I2HSIRL", "I2HSIRL", JdeDataType.String, 4),
        new JdeField("I2HSIID", "I2HSIID", JdeDataType.String, 80),
        new JdeField("I2HSIPC", "I2HSIPC", JdeDataType.String, 2),
        new JdeField("I2HSIPD", "I2HSIPD", JdeDataType.String, 80),
        new JdeField("I2HSIEM", "I2HSIEM", JdeDataType.String, 2),
        new JdeField("I2HSICON", "I2HSICON", JdeDataType.String, 2),
        new JdeField("I2JBCX", "I2JBCX", JdeDataType.String, 60),
        new JdeField("I2HSIINJD", "I2HSIINJD", JdeDataType.String, 2),
        new JdeField("I2WCMP", "I2WCMP", JdeDataType.String, 8),
        new JdeField("I2WET", "I2WET", JdeDataType.String, 2),
        new JdeField("I2HSICIA", "I2HSICIA", JdeDataType.String, 2),
        new JdeField("I2HSICN", "I2HSICN", JdeDataType.String, 80),
        new JdeField("I2HSICIR", "I2HSICIR", JdeDataType.String, 4),
        new JdeField("I2HMCO", "I2HMCO", JdeDataType.String, 10),
        new JdeField("I2HMCU", "I2HMCU", JdeDataType.String, 24),
        new JdeField("I2DSI", "I2DSI", JdeDataType.Numeric),
        new JdeField("I2HSIRHD", "I2HSIRHD", JdeDataType.Numeric),
        new JdeField("I2JBCD", "I2JBCD", JdeDataType.String, 12),
        new JdeField("I2JBST", "I2JBST", JdeDataType.String, 8),
        new JdeField("I2SEX", "I2SEX", JdeDataType.String, 2),
        new JdeField("I2HSITOP", "I2HSITOP", JdeDataType.Numeric),
        new JdeField("I2UOM", "I2UOM", JdeDataType.String, 4),
        new JdeField("I2HSIHW", "I2HSIHW", JdeDataType.Numeric),
        new JdeField("I2HSIWB", "I2HSIWB", JdeDataType.Numeric),
        new JdeField("I2ANPA", "I2ANPA", JdeDataType.Numeric),
        new JdeField("I2XAN8", "I2XAN8", JdeDataType.Numeric),
        new JdeField("I2DOB", "I2DOB", JdeDataType.Numeric),
        new JdeField("I2HSIAG", "I2HSIAG", JdeDataType.String, 4),
        new JdeField("I2SHFT", "I2SHFT", JdeDataType.String, 2),
        new JdeField("I2HSIDAC", "I2HSIDAC", JdeDataType.String, 2),
        new JdeField("I2HSIDC", "I2HSIDC", JdeDataType.String, 80),
        new JdeField("I2HSIDAR", "I2HSIDAR", JdeDataType.String, 4),
        new JdeField("I2HSI3P", "I2HSI3P", JdeDataType.String, 2),
        new JdeField("I2VR01", "I2VR01", JdeDataType.String, 50),
        new JdeField("I2MNTR", "I2MNTR", JdeDataType.Numeric),
        new JdeField("I2ADD1", "I2ADD1", JdeDataType.String, 80),
        new JdeField("I2ADD2", "I2ADD2", JdeDataType.String, 80),
        new JdeField("I2ADD3", "I2ADD3", JdeDataType.String, 80),
        new JdeField("I2CTY1", "I2CTY1", JdeDataType.String, 50),
        new JdeField("I2ADDS", "I2ADDS", JdeDataType.String, 6),
        new JdeField("I2ADDZ", "I2ADDZ", JdeDataType.String, 24),
        new JdeField("I2COUN", "I2COUN", JdeDataType.String, 50),
        new JdeField("I2CTR", "I2CTR", JdeDataType.String, 6),
        new JdeField("I2PH1", "I2PH1", JdeDataType.String, 40),
        new JdeField("I2PH2", "I2PH2", JdeDataType.String, 40),
        new JdeField("I2PH3", "I2PH3", JdeDataType.String, 40),
        new JdeField("I2HSIEE", "I2HSIEE", JdeDataType.String, 150),
        new JdeField("I2HSIIC", "I2HSIIC", JdeDataType.String, 4),
        new JdeField("I2HSIIC2", "I2HSIIC2", JdeDataType.String, 4),
        new JdeField("I2HSISI", "I2HSISI", JdeDataType.String, 4),
        new JdeField("I2HSICF", "I2HSICF", JdeDataType.String, 4),
        new JdeField("I2HSIP01", "I2HSIP01", JdeDataType.String, 6),
        new JdeField("I2HSIP02", "I2HSIP02", JdeDataType.String, 6),
        new JdeField("I2HSIP03", "I2HSIP03", JdeDataType.String, 6),
        new JdeField("I2HSIP04", "I2HSIP04", JdeDataType.String, 6),
        new JdeField("I2HSIP05", "I2HSIP05", JdeDataType.String, 6),
        new JdeField("I2HSIP06", "I2HSIP06", JdeDataType.String, 6),
        new JdeField("I2HSIP07", "I2HSIP07", JdeDataType.String, 6),
        new JdeField("I2HSIP08", "I2HSIP08", JdeDataType.String, 6),
        new JdeField("I2HSIP09", "I2HSIP09", JdeDataType.String, 6),
        new JdeField("I2HSIP10", "I2HSIP10", JdeDataType.String, 6),
        new JdeField("I2HSISR", "I2HSISR", JdeDataType.String, 2),
        new JdeField("I2HSISIG", "I2HSISIG", JdeDataType.String, 80),
        new JdeField("I2HSIDOS", "I2HSIDOS", JdeDataType.Numeric),
        new JdeField("I2OSH", "I2OSH", JdeDataType.String, 2),
        new JdeField("I2HSIYRC", "I2HSIYRC", JdeDataType.Numeric),
        new JdeField("I2CASE", "I2CASE", JdeDataType.Numeric),
        new JdeField("I2CSFX", "I2CSFX", JdeDataType.Numeric),
        new JdeField("I2CSTS", "I2CSTS", JdeDataType.String, 4),
        new JdeField("I2DCLO", "I2DCLO", JdeDataType.Numeric),
        new JdeField("I2IR", "I2IR", JdeDataType.String, 4),
        new JdeField("I2HSIOI", "I2HSIOI", JdeDataType.String, 6),
        new JdeField("I2HSIBP", "I2HSIBP", JdeDataType.String, 8),
        new JdeField("I2NDAW", "I2NDAW", JdeDataType.Numeric),
        new JdeField("I2NDWA", "I2NDWA", JdeDataType.Numeric),
        new JdeField("I2DDEC", "I2DDEC", JdeDataType.Numeric),
        new JdeField("I2DRT", "I2DRT", JdeDataType.Numeric),
        new JdeField("I2ONPRM", "I2ONPRM", JdeDataType.String, 2),
        new JdeField("I2HSIOL", "I2HSIOL", JdeDataType.String, 6),
        new JdeField("I2ERCHKBX", "I2ERCHKBX", JdeDataType.String, 2),
        new JdeField("I2HCHKBX", "I2HCHKBX", JdeDataType.String, 2),
        new JdeField("I2FACAN8", "I2FACAN8", JdeDataType.Numeric),
        new JdeField("I2HSIMC", "I2HSIMC", JdeDataType.String, 2),
        new JdeField("I2HSISD", "I2HSISD", JdeDataType.String, 2),
        new JdeField("I2HSIHCP", "I2HSIHCP", JdeDataType.String, 80),
        new JdeField("I2HSINOC", "I2HSINOC", JdeDataType.String, 2),
        new JdeField("I2HSINC", "I2HSINC", JdeDataType.String, 2),
        new JdeField("I2HSIAT", "I2HSIAT", JdeDataType.String, 400),
        new JdeField("I2HSIHO", "I2HSIHO", JdeDataType.String, 400),
        new JdeField("I2HSIPO", "I2HSIPO", JdeDataType.String, 400),
        new JdeField("I2HSIBJ", "I2HSIBJ", JdeDataType.String, 4),
        new JdeField("I2HSIBJO", "I2HSIBJO", JdeDataType.String, 80),
        new JdeField("I2HSIBL", "I2HSIBL", JdeDataType.String, 4),
        new JdeField("I2HSIBW", "I2HSIBW", JdeDataType.String, 2),
        new JdeField("I2HSIO1", "I2HSIO1", JdeDataType.String, 8),
        new JdeField("I2HSIO2", "I2HSIO2", JdeDataType.String, 8),
        new JdeField("I2HSIO3", "I2HSIO3", JdeDataType.String, 8),
        new JdeField("I2HSIO4", "I2HSIO4", JdeDataType.String, 8),
        new JdeField("I2URAB", "I2URAB", JdeDataType.Numeric),
        new JdeField("I2URCD", "I2URCD", JdeDataType.String, 4),
        new JdeField("I2URAT", "I2URAT", JdeDataType.Numeric),
        new JdeField("I2URDT", "I2URDT", JdeDataType.Numeric),
        new JdeField("I2URRF", "I2URRF", JdeDataType.String, 30),
        new JdeField("I2USER", "I2USER", JdeDataType.String, 20),
        new JdeField("I2UPMJ", "I2UPMJ", JdeDataType.Numeric),
        new JdeField("I2UPMT", "I2UPMT", JdeDataType.Numeric),
        new JdeField("I2JOBN", "I2JOBN", JdeDataType.String, 20),
        new JdeField("I2PID", "I2PID", JdeDataType.String, 20),
        new JdeField("I2HSISB", "I2HSISB", JdeDataType.String, 4),
        new JdeField("I2HSICS", "I2HSICS", JdeDataType.String, 4),
        new JdeField("I2HSIAMP", "I2HSIAMP", JdeDataType.String, 2),
        new JdeField("I2HSIFAT", "I2HSIFAT", JdeDataType.String, 2),
        new JdeField("I2HSIEYE", "I2HSIEYE", JdeDataType.String, 2),
        new JdeField("I2OSHRPT", "I2OSHRPT", JdeDataType.String, 2),
        new JdeField("I2HSIAGE", "I2HSIAGE", JdeDataType.Numeric),
        new JdeField("I2HSIU18", "I2HSIU18", JdeDataType.String, 2),
        new JdeField("I2HSIEPT", "I2HSIEPT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS02M_0", "Primary Key on I2HSINO, I2UKID, I2HSIMN", new[] { "I2HSINO", "I2UKID", "I2HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
