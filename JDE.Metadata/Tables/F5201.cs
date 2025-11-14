using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5201 - .
/// </summary>
public class F5201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G4DOCO.
        /// </summary>
        public const string G4DOCO = "G4DOCO";

        /// <summary>
        /// G4DCTO.
        /// </summary>
        public const string G4DCTO = "G4DCTO";

        /// <summary>
        /// G4KCOO.
        /// </summary>
        public const string G4KCOO = "G4KCOO";

        /// <summary>
        /// G4ICU.
        /// </summary>
        public const string G4ICU = "G4ICU";

        /// <summary>
        /// G4ICUJ.
        /// </summary>
        public const string G4ICUJ = "G4ICUJ";

        /// <summary>
        /// G4DL01.
        /// </summary>
        public const string G4DL01 = "G4DL01";

        /// <summary>
        /// G4DC.
        /// </summary>
        public const string G4DC = "G4DC";

        /// <summary>
        /// G4DL02.
        /// </summary>
        public const string G4DL02 = "G4DL02";

        /// <summary>
        /// G4DL03.
        /// </summary>
        public const string G4DL03 = "G4DL03";

        /// <summary>
        /// G4ODCM.
        /// </summary>
        public const string G4ODCM = "G4ODCM";

        /// <summary>
        /// G4OCNC.
        /// </summary>
        public const string G4OCNC = "G4OCNC";

        /// <summary>
        /// G4AN8O.
        /// </summary>
        public const string G4AN8O = "G4AN8O";

        /// <summary>
        /// G4MCIF.
        /// </summary>
        public const string G4MCIF = "G4MCIF";

        /// <summary>
        /// G4NTEF.
        /// </summary>
        public const string G4NTEF = "G4NTEF";

        /// <summary>
        /// G4RCTL.
        /// </summary>
        public const string G4RCTL = "G4RCTL";

        /// <summary>
        /// G4ANOB.
        /// </summary>
        public const string G4ANOB = "G4ANOB";

        /// <summary>
        /// G4ADCM.
        /// </summary>
        public const string G4ADCM = "G4ADCM";

        /// <summary>
        /// G4AN8K.
        /// </summary>
        public const string G4AN8K = "G4AN8K";

        /// <summary>
        /// G4USA3.
        /// </summary>
        public const string G4USA3 = "G4USA3";

        /// <summary>
        /// G4USA4.
        /// </summary>
        public const string G4USA4 = "G4USA4";

        /// <summary>
        /// G4USA1.
        /// </summary>
        public const string G4USA1 = "G4USA1";

        /// <summary>
        /// G4USA2.
        /// </summary>
        public const string G4USA2 = "G4USA2";

        /// <summary>
        /// G4USA5.
        /// </summary>
        public const string G4USA5 = "G4USA5";

        /// <summary>
        /// G4DS.
        /// </summary>
        public const string G4DS = "G4DS";

        /// <summary>
        /// G4CT.
        /// </summary>
        public const string G4CT = "G4CT";

        /// <summary>
        /// G4MCUS.
        /// </summary>
        public const string G4MCUS = "G4MCUS";

        /// <summary>
        /// G4JMCU.
        /// </summary>
        public const string G4JMCU = "G4JMCU";

        /// <summary>
        /// G4CO.
        /// </summary>
        public const string G4CO = "G4CO";

        /// <summary>
        /// G4PCTN.
        /// </summary>
        public const string G4PCTN = "G4PCTN";

        /// <summary>
        /// G4PCTT.
        /// </summary>
        public const string G4PCTT = "G4PCTT";

        /// <summary>
        /// G4PCKO.
        /// </summary>
        public const string G4PCKO = "G4PCKO";

        /// <summary>
        /// G4RTNR.
        /// </summary>
        public const string G4RTNR = "G4RTNR";

        /// <summary>
        /// G4RGLC.
        /// </summary>
        public const string G4RGLC = "G4RGLC";

        /// <summary>
        /// G4RTN1.
        /// </summary>
        public const string G4RTN1 = "G4RTN1";

        /// <summary>
        /// G4EXR1.
        /// </summary>
        public const string G4EXR1 = "G4EXR1";

        /// <summary>
        /// G4TXA1.
        /// </summary>
        public const string G4TXA1 = "G4TXA1";

        /// <summary>
        /// G4INVF.
        /// </summary>
        public const string G4INVF = "G4INVF";

        /// <summary>
        /// G4AIAB.
        /// </summary>
        public const string G4AIAB = "G4AIAB";

        /// <summary>
        /// G4CTOV.
        /// </summary>
        public const string G4CTOV = "G4CTOV";

        /// <summary>
        /// G4PTC.
        /// </summary>
        public const string G4PTC = "G4PTC";

        /// <summary>
        /// G4BLWP.
        /// </summary>
        public const string G4BLWP = "G4BLWP";

        /// <summary>
        /// G4PYWP.
        /// </summary>
        public const string G4PYWP = "G4PYWP";

        /// <summary>
        /// G4BROV.
        /// </summary>
        public const string G4BROV = "G4BROV";

        /// <summary>
        /// G4FSLV.
        /// </summary>
        public const string G4FSLV = "G4FSLV";

        /// <summary>
        /// G4CRCD.
        /// </summary>
        public const string G4CRCD = "G4CRCD";

        /// <summary>
        /// G4CRCF.
        /// </summary>
        public const string G4CRCF = "G4CRCF";

        /// <summary>
        /// G4CRRM.
        /// </summary>
        public const string G4CRRM = "G4CRRM";

        /// <summary>
        /// G4NTEX.
        /// </summary>
        public const string G4NTEX = "G4NTEX";

        /// <summary>
        /// G4RNTE.
        /// </summary>
        public const string G4RNTE = "G4RNTE";

        /// <summary>
        /// G4ERDB.
        /// </summary>
        public const string G4ERDB = "G4ERDB";

        /// <summary>
        /// G4LMEX.
        /// </summary>
        public const string G4LMEX = "G4LMEX";

        /// <summary>
        /// G4MCIA.
        /// </summary>
        public const string G4MCIA = "G4MCIA";

        /// <summary>
        /// G4CSDT.
        /// </summary>
        public const string G4CSDT = "G4CSDT";

        /// <summary>
        /// G4CDTE.
        /// </summary>
        public const string G4CDTE = "G4CDTE";

        /// <summary>
        /// G4USD1.
        /// </summary>
        public const string G4USD1 = "G4USD1";

        /// <summary>
        /// G4USD2.
        /// </summary>
        public const string G4USD2 = "G4USD2";

        /// <summary>
        /// G4USD3.
        /// </summary>
        public const string G4USD3 = "G4USD3";

        /// <summary>
        /// G4USD4.
        /// </summary>
        public const string G4USD4 = "G4USD4";

        /// <summary>
        /// G4AI01.
        /// </summary>
        public const string G4AI01 = "G4AI01";

        /// <summary>
        /// G4AI02.
        /// </summary>
        public const string G4AI02 = "G4AI02";

        /// <summary>
        /// G4AI03.
        /// </summary>
        public const string G4AI03 = "G4AI03";

        /// <summary>
        /// G4AI04.
        /// </summary>
        public const string G4AI04 = "G4AI04";

        /// <summary>
        /// G4AI05.
        /// </summary>
        public const string G4AI05 = "G4AI05";

        /// <summary>
        /// G4AI11.
        /// </summary>
        public const string G4AI11 = "G4AI11";

        /// <summary>
        /// G4AI12.
        /// </summary>
        public const string G4AI12 = "G4AI12";

        /// <summary>
        /// G4AI13.
        /// </summary>
        public const string G4AI13 = "G4AI13";

        /// <summary>
        /// G4AI14.
        /// </summary>
        public const string G4AI14 = "G4AI14";

        /// <summary>
        /// G4AI15.
        /// </summary>
        public const string G4AI15 = "G4AI15";

        /// <summary>
        /// G4CRR.
        /// </summary>
        public const string G4CRR = "G4CRR";

        /// <summary>
        /// G4CRRD.
        /// </summary>
        public const string G4CRRD = "G4CRRD";

        /// <summary>
        /// G4CTF2.
        /// </summary>
        public const string G4CTF2 = "G4CTF2";

        /// <summary>
        /// G4CTF3.
        /// </summary>
        public const string G4CTF3 = "G4CTF3";

        /// <summary>
        /// G4CTF4.
        /// </summary>
        public const string G4CTF4 = "G4CTF4";

        /// <summary>
        /// G4CTF5.
        /// </summary>
        public const string G4CTF5 = "G4CTF5";

        /// <summary>
        /// G4BCTK.
        /// </summary>
        public const string G4BCTK = "G4BCTK";

        /// <summary>
        /// G4PID.
        /// </summary>
        public const string G4PID = "G4PID";

        /// <summary>
        /// G4JOBN.
        /// </summary>
        public const string G4JOBN = "G4JOBN";

        /// <summary>
        /// G4USER.
        /// </summary>
        public const string G4USER = "G4USER";

        /// <summary>
        /// G4MUPM.
        /// </summary>
        public const string G4MUPM = "G4MUPM";

        /// <summary>
        /// G4UPMT.
        /// </summary>
        public const string G4UPMT = "G4UPMT";

        /// <summary>
        /// G4GCSE.
        /// </summary>
        public const string G4GCSE = "G4GCSE";

        /// <summary>
        /// G4CLNU.
        /// </summary>
        public const string G4CLNU = "G4CLNU";

        /// <summary>
        /// G4CLTT.
        /// </summary>
        public const string G4CLTT = "G4CLTT";

        /// <summary>
        /// G4CLKO.
        /// </summary>
        public const string G4CLKO = "G4CLKO";

        /// <summary>
        /// G4FCCM.
        /// </summary>
        public const string G4FCCM = "G4FCCM";

        /// <summary>
        /// G4BURTC.
        /// </summary>
        public const string G4BURTC = "G4BURTC";

        /// <summary>
        /// G4CCFLG.
        /// </summary>
        public const string G4CCFLG = "G4CCFLG";

        /// <summary>
        /// G4BURTAC.
        /// </summary>
        public const string G4BURTAC = "G4BURTAC";

        /// <summary>
        /// G4ACFLG.
        /// </summary>
        public const string G4ACFLG = "G4ACFLG";

        /// <summary>
        /// G4BURTI.
        /// </summary>
        public const string G4BURTI = "G4BURTI";

        /// <summary>
        /// G4ICFLG.
        /// </summary>
        public const string G4ICFLG = "G4ICFLG";

        /// <summary>
        /// G4BURTR.
        /// </summary>
        public const string G4BURTR = "G4BURTR";

        /// <summary>
        /// G4RCFLG.
        /// </summary>
        public const string G4RCFLG = "G4RCFLG";

        /// <summary>
        /// G4TOCC.
        /// </summary>
        public const string G4TOCC = "G4TOCC";

        /// <summary>
        /// G4TOCS.
        /// </summary>
        public const string G4TOCS = "G4TOCS";

        /// <summary>
        /// G4PRCO.
        /// </summary>
        public const string G4PRCO = "G4PRCO";

        /// <summary>
        /// G4OWOR.
        /// </summary>
        public const string G4OWOR = "G4OWOR";

        /// <summary>
        /// G4POPF.
        /// </summary>
        public const string G4POPF = "G4POPF";

        /// <summary>
        /// G4POPT.
        /// </summary>
        public const string G4POPT = "G4POPT";

        /// <summary>
        /// G4EPOP.
        /// </summary>
        public const string G4EPOP = "G4EPOP";

        /// <summary>
        /// G4POTA.
        /// </summary>
        public const string G4POTA = "G4POTA";

        /// <summary>
        /// G4AWCOST.
        /// </summary>
        public const string G4AWCOST = "G4AWCOST";

        /// <summary>
        /// G4AWFE.
        /// </summary>
        public const string G4AWFE = "G4AWFE";

        /// <summary>
        /// G4AWAFE.
        /// </summary>
        public const string G4AWAFE = "G4AWAFE";

        /// <summary>
        /// G4FUNDC.
        /// </summary>
        public const string G4FUNDC = "G4FUNDC";

        /// <summary>
        /// G4FUNF.
        /// </summary>
        public const string G4FUNF = "G4FUNF";

        /// <summary>
        /// G4FUNAF.
        /// </summary>
        public const string G4FUNAF = "G4FUNAF";

        /// <summary>
        /// G4RICO.
        /// </summary>
        public const string G4RICO = "G4RICO";

        /// <summary>
        /// G4RIFE.
        /// </summary>
        public const string G4RIFE = "G4RIFE";

        /// <summary>
        /// G4RIAWF.
        /// </summary>
        public const string G4RIAWF = "G4RIAWF";

        /// <summary>
        /// G4RETMX.
        /// </summary>
        public const string G4RETMX = "G4RETMX";

        /// <summary>
        /// G4POTAF.
        /// </summary>
        public const string G4POTAF = "G4POTAF";

        /// <summary>
        /// G4AWCOSTF.
        /// </summary>
        public const string G4AWCOSTF = "G4AWCOSTF";

        /// <summary>
        /// G4AWFEF.
        /// </summary>
        public const string G4AWFEF = "G4AWFEF";

        /// <summary>
        /// G4AWAFEF.
        /// </summary>
        public const string G4AWAFEF = "G4AWAFEF";

        /// <summary>
        /// G4FUNDCF.
        /// </summary>
        public const string G4FUNDCF = "G4FUNDCF";

        /// <summary>
        /// G4FUNFF.
        /// </summary>
        public const string G4FUNFF = "G4FUNFF";

        /// <summary>
        /// G4FUNAFF.
        /// </summary>
        public const string G4FUNAFF = "G4FUNAFF";

        /// <summary>
        /// G4RICOF.
        /// </summary>
        public const string G4RICOF = "G4RICOF";

        /// <summary>
        /// G4RIFEF.
        /// </summary>
        public const string G4RIFEF = "G4RIFEF";

        /// <summary>
        /// G4RIAWFF.
        /// </summary>
        public const string G4RIAWFF = "G4RIAWFF";

        /// <summary>
        /// G4RETMXF.
        /// </summary>
        public const string G4RETMXF = "G4RETMXF";

        /// <summary>
        /// G4BILLST.
        /// </summary>
        public const string G4BILLST = "G4BILLST";

        /// <summary>
        /// G4BILLMET.
        /// </summary>
        public const string G4BILLMET = "G4BILLMET";

        /// <summary>
        /// G4BILLFRE.
        /// </summary>
        public const string G4BILLFRE = "G4BILLFRE";

        /// <summary>
        /// G4BILLLIM.
        /// </summary>
        public const string G4BILLLIM = "G4BILLLIM";

        /// <summary>
        /// G4BILLGRP.
        /// </summary>
        public const string G4BILLGRP = "G4BILLGRP";

        /// <summary>
        /// G4BILLOVT.
        /// </summary>
        public const string G4BILLOVT = "G4BILLOVT";

        /// <summary>
        /// G4REVST.
        /// </summary>
        public const string G4REVST = "G4REVST";

        /// <summary>
        /// G4REVMET.
        /// </summary>
        public const string G4REVMET = "G4REVMET";

        /// <summary>
        /// G4REVLIM.
        /// </summary>
        public const string G4REVLIM = "G4REVLIM";

        /// <summary>
        /// G4CAB1.
        /// </summary>
        public const string G4CAB1 = "G4CAB1";

        /// <summary>
        /// G4CAB2.
        /// </summary>
        public const string G4CAB2 = "G4CAB2";

        /// <summary>
        /// G4CAB3.
        /// </summary>
        public const string G4CAB3 = "G4CAB3";

        /// <summary>
        /// G4CAB4.
        /// </summary>
        public const string G4CAB4 = "G4CAB4";

        /// <summary>
        /// G4CAB5.
        /// </summary>
        public const string G4CAB5 = "G4CAB5";

        /// <summary>
        /// G4CAB6.
        /// </summary>
        public const string G4CAB6 = "G4CAB6";

        /// <summary>
        /// G4CAB7.
        /// </summary>
        public const string G4CAB7 = "G4CAB7";

        /// <summary>
        /// G4CAB8.
        /// </summary>
        public const string G4CAB8 = "G4CAB8";

        /// <summary>
        /// G4CAB9.
        /// </summary>
        public const string G4CAB9 = "G4CAB9";

        /// <summary>
        /// G4CAB10.
        /// </summary>
        public const string G4CAB10 = "G4CAB10";

        /// <summary>
        /// G4CAB11.
        /// </summary>
        public const string G4CAB11 = "G4CAB11";

        /// <summary>
        /// G4CAB12.
        /// </summary>
        public const string G4CAB12 = "G4CAB12";

        /// <summary>
        /// G4CAB13.
        /// </summary>
        public const string G4CAB13 = "G4CAB13";

        /// <summary>
        /// G4CAB14.
        /// </summary>
        public const string G4CAB14 = "G4CAB14";

        /// <summary>
        /// G4CAB15.
        /// </summary>
        public const string G4CAB15 = "G4CAB15";

        /// <summary>
        /// G4CLCA.
        /// </summary>
        public const string G4CLCA = "G4CLCA";

        /// <summary>
        /// G4SUBLAB.
        /// </summary>
        public const string G4SUBLAB = "G4SUBLAB";

        /// <summary>
        /// G4ALLEV.
        /// </summary>
        public const string G4ALLEV = "G4ALLEV";

        /// <summary>
        /// G4ALDES.
        /// </summary>
        public const string G4ALDES = "G4ALDES";

        /// <summary>
        /// G4ACRNCF.
        /// </summary>
        public const string G4ACRNCF = "G4ACRNCF";

        /// <summary>
        /// G4ACRNAF.
        /// </summary>
        public const string G4ACRNAF = "G4ACRNAF";

        /// <summary>
        /// G4GOVPR.
        /// </summary>
        public const string G4GOVPR = "G4GOVPR";

        /// <summary>
        /// G4LOER.
        /// </summary>
        public const string G4LOER = "G4LOER";

        /// <summary>
        /// G4THRS.
        /// </summary>
        public const string G4THRS = "G4THRS";

        /// <summary>
        /// G4VARP.
        /// </summary>
        public const string G4VARP = "G4VARP";

        /// <summary>
        /// G4SECOA.
        /// </summary>
        public const string G4SECOA = "G4SECOA";

        /// <summary>
        /// G4DABA.
        /// </summary>
        public const string G4DABA = "G4DABA";

        /// <summary>
        /// G4CASCO.
        /// </summary>
        public const string G4CASCO = "G4CASCO";

        /// <summary>
        /// G4TINACO.
        /// </summary>
        public const string G4TINACO = "G4TINACO";

        /// <summary>
        /// G4FDCL.
        /// </summary>
        public const string G4FDCL = "G4FDCL";

        /// <summary>
        /// G4QCOPR.
        /// </summary>
        public const string G4QCOPR = "G4QCOPR";

        /// <summary>
        /// G4KEYP.
        /// </summary>
        public const string G4KEYP = "G4KEYP";

        /// <summary>
        /// G4VTGR.
        /// </summary>
        public const string G4VTGR = "G4VTGR";

        /// <summary>
        /// G4AI06.
        /// </summary>
        public const string G4AI06 = "G4AI06";

        /// <summary>
        /// G4AI07.
        /// </summary>
        public const string G4AI07 = "G4AI07";

        /// <summary>
        /// G4AI08.
        /// </summary>
        public const string G4AI08 = "G4AI08";

        /// <summary>
        /// G4AI09.
        /// </summary>
        public const string G4AI09 = "G4AI09";

        /// <summary>
        /// G4AI10.
        /// </summary>
        public const string G4AI10 = "G4AI10";

        /// <summary>
        /// G4AI16.
        /// </summary>
        public const string G4AI16 = "G4AI16";

        /// <summary>
        /// G4AI17.
        /// </summary>
        public const string G4AI17 = "G4AI17";

        /// <summary>
        /// G4AI18.
        /// </summary>
        public const string G4AI18 = "G4AI18";

        /// <summary>
        /// G4AI19.
        /// </summary>
        public const string G4AI19 = "G4AI19";

        /// <summary>
        /// G4AI20.
        /// </summary>
        public const string G4AI20 = "G4AI20";

        /// <summary>
        /// G4USD5.
        /// </summary>
        public const string G4USD5 = "G4USD5";

        /// <summary>
        /// G4USD6.
        /// </summary>
        public const string G4USD6 = "G4USD6";

        /// <summary>
        /// G4USD7.
        /// </summary>
        public const string G4USD7 = "G4USD7";

        /// <summary>
        /// G4USD8.
        /// </summary>
        public const string G4USD8 = "G4USD8";

        /// <summary>
        /// G4USD9.
        /// </summary>
        public const string G4USD9 = "G4USD9";
    }

    /// <inheritdoc />
    public override string TableName => "F5201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G4DOCO", "G4DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("G4DCTO", "G4DCTO", JdeDataType.String, 4, true, true),
        new JdeField("G4KCOO", "G4KCOO", JdeDataType.String, 10, true, true),
        new JdeField("G4ICU", "G4ICU", JdeDataType.Numeric),
        new JdeField("G4ICUJ", "G4ICUJ", JdeDataType.Numeric),
        new JdeField("G4DL01", "G4DL01", JdeDataType.String, 60),
        new JdeField("G4DC", "G4DC", JdeDataType.String, 80),
        new JdeField("G4DL02", "G4DL02", JdeDataType.String, 60),
        new JdeField("G4DL03", "G4DL03", JdeDataType.String, 60),
        new JdeField("G4ODCM", "G4ODCM", JdeDataType.String, 50),
        new JdeField("G4OCNC", "G4OCNC", JdeDataType.String, 40),
        new JdeField("G4AN8O", "G4AN8O", JdeDataType.Numeric),
        new JdeField("G4MCIF", "G4MCIF", JdeDataType.Numeric),
        new JdeField("G4NTEF", "G4NTEF", JdeDataType.Numeric),
        new JdeField("G4RCTL", "G4RCTL", JdeDataType.String, 2),
        new JdeField("G4ANOB", "G4ANOB", JdeDataType.Numeric),
        new JdeField("G4ADCM", "G4ADCM", JdeDataType.String, 50),
        new JdeField("G4AN8K", "G4AN8K", JdeDataType.Numeric),
        new JdeField("G4USA3", "G4USA3", JdeDataType.Numeric),
        new JdeField("G4USA4", "G4USA4", JdeDataType.Numeric),
        new JdeField("G4USA1", "G4USA1", JdeDataType.Numeric),
        new JdeField("G4USA2", "G4USA2", JdeDataType.Numeric),
        new JdeField("G4USA5", "G4USA5", JdeDataType.Numeric),
        new JdeField("G4DS", "G4DS", JdeDataType.String, 4),
        new JdeField("G4CT", "G4CT", JdeDataType.String, 8),
        new JdeField("G4MCUS", "G4MCUS", JdeDataType.String, 24),
        new JdeField("G4JMCU", "G4JMCU", JdeDataType.String, 24),
        new JdeField("G4CO", "G4CO", JdeDataType.String, 10),
        new JdeField("G4PCTN", "G4PCTN", JdeDataType.Numeric),
        new JdeField("G4PCTT", "G4PCTT", JdeDataType.String, 4),
        new JdeField("G4PCKO", "G4PCKO", JdeDataType.String, 10),
        new JdeField("G4RTNR", "G4RTNR", JdeDataType.String, 6),
        new JdeField("G4RGLC", "G4RGLC", JdeDataType.String, 8),
        new JdeField("G4RTN1", "G4RTN1", JdeDataType.String, 6),
        new JdeField("G4EXR1", "G4EXR1", JdeDataType.String, 4),
        new JdeField("G4TXA1", "G4TXA1", JdeDataType.String, 20),
        new JdeField("G4INVF", "G4INVF", JdeDataType.String, 20),
        new JdeField("G4AIAB", "G4AIAB", JdeDataType.String, 2),
        new JdeField("G4CTOV", "G4CTOV", JdeDataType.String, 2),
        new JdeField("G4PTC", "G4PTC", JdeDataType.String, 6),
        new JdeField("G4BLWP", "G4BLWP", JdeDataType.String, 2),
        new JdeField("G4PYWP", "G4PYWP", JdeDataType.String, 2),
        new JdeField("G4BROV", "G4BROV", JdeDataType.String, 2),
        new JdeField("G4FSLV", "G4FSLV", JdeDataType.String, 2),
        new JdeField("G4CRCD", "G4CRCD", JdeDataType.String, 6),
        new JdeField("G4CRCF", "G4CRCF", JdeDataType.String, 6),
        new JdeField("G4CRRM", "G4CRRM", JdeDataType.String, 2),
        new JdeField("G4NTEX", "G4NTEX", JdeDataType.Numeric),
        new JdeField("G4RNTE", "G4RNTE", JdeDataType.Numeric),
        new JdeField("G4ERDB", "G4ERDB", JdeDataType.String, 2),
        new JdeField("G4LMEX", "G4LMEX", JdeDataType.String, 2),
        new JdeField("G4MCIA", "G4MCIA", JdeDataType.Numeric),
        new JdeField("G4CSDT", "G4CSDT", JdeDataType.Numeric),
        new JdeField("G4CDTE", "G4CDTE", JdeDataType.Numeric),
        new JdeField("G4USD1", "G4USD1", JdeDataType.Numeric),
        new JdeField("G4USD2", "G4USD2", JdeDataType.Numeric),
        new JdeField("G4USD3", "G4USD3", JdeDataType.Numeric),
        new JdeField("G4USD4", "G4USD4", JdeDataType.Numeric),
        new JdeField("G4AI01", "G4AI01", JdeDataType.String, 6),
        new JdeField("G4AI02", "G4AI02", JdeDataType.String, 6),
        new JdeField("G4AI03", "G4AI03", JdeDataType.String, 6),
        new JdeField("G4AI04", "G4AI04", JdeDataType.String, 6),
        new JdeField("G4AI05", "G4AI05", JdeDataType.String, 6),
        new JdeField("G4AI11", "G4AI11", JdeDataType.String, 20),
        new JdeField("G4AI12", "G4AI12", JdeDataType.String, 20),
        new JdeField("G4AI13", "G4AI13", JdeDataType.String, 20),
        new JdeField("G4AI14", "G4AI14", JdeDataType.String, 20),
        new JdeField("G4AI15", "G4AI15", JdeDataType.String, 20),
        new JdeField("G4CRR", "G4CRR", JdeDataType.Numeric),
        new JdeField("G4CRRD", "G4CRRD", JdeDataType.Numeric),
        new JdeField("G4CTF2", "G4CTF2", JdeDataType.String, 2),
        new JdeField("G4CTF3", "G4CTF3", JdeDataType.String, 2),
        new JdeField("G4CTF4", "G4CTF4", JdeDataType.String, 2),
        new JdeField("G4CTF5", "G4CTF5", JdeDataType.String, 2),
        new JdeField("G4BCTK", "G4BCTK", JdeDataType.String, 20),
        new JdeField("G4PID", "G4PID", JdeDataType.String, 20),
        new JdeField("G4JOBN", "G4JOBN", JdeDataType.String, 20),
        new JdeField("G4USER", "G4USER", JdeDataType.String, 20),
        new JdeField("G4MUPM", "G4MUPM", JdeDataType.Numeric),
        new JdeField("G4UPMT", "G4UPMT", JdeDataType.Numeric),
        new JdeField("G4GCSE", "G4GCSE", JdeDataType.Numeric),
        new JdeField("G4CLNU", "G4CLNU", JdeDataType.Numeric),
        new JdeField("G4CLTT", "G4CLTT", JdeDataType.String, 4),
        new JdeField("G4CLKO", "G4CLKO", JdeDataType.String, 10),
        new JdeField("G4FCCM", "G4FCCM", JdeDataType.String, 2),
        new JdeField("G4BURTC", "G4BURTC", JdeDataType.String, 10),
        new JdeField("G4CCFLG", "G4CCFLG", JdeDataType.String, 2),
        new JdeField("G4BURTAC", "G4BURTAC", JdeDataType.String, 10),
        new JdeField("G4ACFLG", "G4ACFLG", JdeDataType.String, 2),
        new JdeField("G4BURTI", "G4BURTI", JdeDataType.String, 10),
        new JdeField("G4ICFLG", "G4ICFLG", JdeDataType.String, 2),
        new JdeField("G4BURTR", "G4BURTR", JdeDataType.String, 10),
        new JdeField("G4RCFLG", "G4RCFLG", JdeDataType.String, 2),
        new JdeField("G4TOCC", "G4TOCC", JdeDataType.String, 8),
        new JdeField("G4TOCS", "G4TOCS", JdeDataType.String, 8),
        new JdeField("G4PRCO", "G4PRCO", JdeDataType.String, 60),
        new JdeField("G4OWOR", "G4OWOR", JdeDataType.String, 24),
        new JdeField("G4POPF", "G4POPF", JdeDataType.Numeric),
        new JdeField("G4POPT", "G4POPT", JdeDataType.Numeric),
        new JdeField("G4EPOP", "G4EPOP", JdeDataType.String, 2),
        new JdeField("G4POTA", "G4POTA", JdeDataType.Numeric),
        new JdeField("G4AWCOST", "G4AWCOST", JdeDataType.Numeric),
        new JdeField("G4AWFE", "G4AWFE", JdeDataType.Numeric),
        new JdeField("G4AWAFE", "G4AWAFE", JdeDataType.Numeric),
        new JdeField("G4FUNDC", "G4FUNDC", JdeDataType.Numeric),
        new JdeField("G4FUNF", "G4FUNF", JdeDataType.Numeric),
        new JdeField("G4FUNAF", "G4FUNAF", JdeDataType.Numeric),
        new JdeField("G4RICO", "G4RICO", JdeDataType.Numeric),
        new JdeField("G4RIFE", "G4RIFE", JdeDataType.Numeric),
        new JdeField("G4RIAWF", "G4RIAWF", JdeDataType.Numeric),
        new JdeField("G4RETMX", "G4RETMX", JdeDataType.Numeric),
        new JdeField("G4POTAF", "G4POTAF", JdeDataType.Numeric),
        new JdeField("G4AWCOSTF", "G4AWCOSTF", JdeDataType.Numeric),
        new JdeField("G4AWFEF", "G4AWFEF", JdeDataType.Numeric),
        new JdeField("G4AWAFEF", "G4AWAFEF", JdeDataType.Numeric),
        new JdeField("G4FUNDCF", "G4FUNDCF", JdeDataType.Numeric),
        new JdeField("G4FUNFF", "G4FUNFF", JdeDataType.Numeric),
        new JdeField("G4FUNAFF", "G4FUNAFF", JdeDataType.Numeric),
        new JdeField("G4RICOF", "G4RICOF", JdeDataType.Numeric),
        new JdeField("G4RIFEF", "G4RIFEF", JdeDataType.Numeric),
        new JdeField("G4RIAWFF", "G4RIAWFF", JdeDataType.Numeric),
        new JdeField("G4RETMXF", "G4RETMXF", JdeDataType.Numeric),
        new JdeField("G4BILLST", "G4BILLST", JdeDataType.String, 2),
        new JdeField("G4BILLMET", "G4BILLMET", JdeDataType.String, 2),
        new JdeField("G4BILLFRE", "G4BILLFRE", JdeDataType.String, 6),
        new JdeField("G4BILLLIM", "G4BILLLIM", JdeDataType.String, 2),
        new JdeField("G4BILLGRP", "G4BILLGRP", JdeDataType.String, 6),
        new JdeField("G4BILLOVT", "G4BILLOVT", JdeDataType.String, 2),
        new JdeField("G4REVST", "G4REVST", JdeDataType.String, 2),
        new JdeField("G4REVMET", "G4REVMET", JdeDataType.String, 2),
        new JdeField("G4REVLIM", "G4REVLIM", JdeDataType.String, 2),
        new JdeField("G4CAB1", "G4CAB1", JdeDataType.Numeric),
        new JdeField("G4CAB2", "G4CAB2", JdeDataType.Numeric),
        new JdeField("G4CAB3", "G4CAB3", JdeDataType.Numeric),
        new JdeField("G4CAB4", "G4CAB4", JdeDataType.Numeric),
        new JdeField("G4CAB5", "G4CAB5", JdeDataType.Numeric),
        new JdeField("G4CAB6", "G4CAB6", JdeDataType.Numeric),
        new JdeField("G4CAB7", "G4CAB7", JdeDataType.Numeric),
        new JdeField("G4CAB8", "G4CAB8", JdeDataType.Numeric),
        new JdeField("G4CAB9", "G4CAB9", JdeDataType.Numeric),
        new JdeField("G4CAB10", "G4CAB10", JdeDataType.Numeric),
        new JdeField("G4CAB11", "G4CAB11", JdeDataType.Numeric),
        new JdeField("G4CAB12", "G4CAB12", JdeDataType.Numeric),
        new JdeField("G4CAB13", "G4CAB13", JdeDataType.Numeric),
        new JdeField("G4CAB14", "G4CAB14", JdeDataType.Numeric),
        new JdeField("G4CAB15", "G4CAB15", JdeDataType.Numeric),
        new JdeField("G4CLCA", "G4CLCA", JdeDataType.String, 2),
        new JdeField("G4SUBLAB", "G4SUBLAB", JdeDataType.String, 2),
        new JdeField("G4ALLEV", "G4ALLEV", JdeDataType.String, 2),
        new JdeField("G4ALDES", "G4ALDES", JdeDataType.String, 24),
        new JdeField("G4ACRNCF", "G4ACRNCF", JdeDataType.String, 2),
        new JdeField("G4ACRNAF", "G4ACRNAF", JdeDataType.String, 2),
        new JdeField("G4GOVPR", "G4GOVPR", JdeDataType.String, 20),
        new JdeField("G4LOER", "G4LOER", JdeDataType.String, 2),
        new JdeField("G4THRS", "G4THRS", JdeDataType.Numeric),
        new JdeField("G4VARP", "G4VARP", JdeDataType.Numeric),
        new JdeField("G4SECOA", "G4SECOA", JdeDataType.String, 2),
        new JdeField("G4DABA", "G4DABA", JdeDataType.String, 2),
        new JdeField("G4CASCO", "G4CASCO", JdeDataType.String, 2),
        new JdeField("G4TINACO", "G4TINACO", JdeDataType.String, 2),
        new JdeField("G4FDCL", "G4FDCL", JdeDataType.String, 2),
        new JdeField("G4QCOPR", "G4QCOPR", JdeDataType.String, 2),
        new JdeField("G4KEYP", "G4KEYP", JdeDataType.String, 2),
        new JdeField("G4VTGR", "G4VTGR", JdeDataType.String, 2),
        new JdeField("G4AI06", "G4AI06", JdeDataType.String, 6),
        new JdeField("G4AI07", "G4AI07", JdeDataType.String, 6),
        new JdeField("G4AI08", "G4AI08", JdeDataType.String, 6),
        new JdeField("G4AI09", "G4AI09", JdeDataType.String, 6),
        new JdeField("G4AI10", "G4AI10", JdeDataType.String, 6),
        new JdeField("G4AI16", "G4AI16", JdeDataType.String, 20),
        new JdeField("G4AI17", "G4AI17", JdeDataType.String, 20),
        new JdeField("G4AI18", "G4AI18", JdeDataType.String, 20),
        new JdeField("G4AI19", "G4AI19", JdeDataType.String, 20),
        new JdeField("G4AI20", "G4AI20", JdeDataType.String, 20),
        new JdeField("G4USD5", "G4USD5", JdeDataType.Numeric),
        new JdeField("G4USD6", "G4USD6", JdeDataType.Numeric),
        new JdeField("G4USD7", "G4USD7", JdeDataType.Numeric),
        new JdeField("G4USD8", "G4USD8", JdeDataType.Numeric),
        new JdeField("G4USD9", "G4USD9", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5201_0", "Primary Key on G4DOCO, G4DCTO, G4KCOO", new[] { "G4DOCO", "G4DCTO", "G4KCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5201_10", "Index on G4PCTN, G4PCTT", new[] { "G4PCTN", "G4PCTT" }),
        new JdeIndex("F5201_12", "Index on G4DOCO, G4DCTO", new[] { "G4DOCO", "G4DCTO" }),
        new JdeIndex("F5201_13", "Index on G4CLNU, G4CLTT", new[] { "G4CLNU", "G4CLTT" }),
        new JdeIndex("F5201_14", "Index on G4DOCO, G4DCTO, G4DS, G4CLNU, G4CLTT", new[] { "G4DOCO", "G4DCTO", "G4DS", "G4CLNU", "G4CLTT" }),
        new JdeIndex("F5201_15", "Index on G4DL01", new[] { "G4DL01" }),
        new JdeIndex("F5201_2", "Index on G4AN8O, G4DOCO, G4DCTO, G4KCOO", new[] { "G4AN8O", "G4DOCO", "G4DCTO", "G4KCOO" }),
        new JdeIndex("F5201_3", "Index on G4MCUS, G4DOCO, G4DCTO, G4KCOO", new[] { "G4MCUS", "G4DOCO", "G4DCTO", "G4KCOO" }),
        new JdeIndex("F5201_5", "Index on G4DC, G4DOCO, G4DCTO, G4KCOO", new[] { "G4DC", "G4DOCO", "G4DCTO", "G4KCOO" }),
        new JdeIndex("F5201_6", "Index on G4OCNC, G4DOCO, G4DCTO, G4KCOO", new[] { "G4OCNC", "G4DOCO", "G4DCTO", "G4KCOO" }),
        new JdeIndex("F5201_8", "Index on G4CT, G4DOCO, G4DCTO, G4KCOO", new[] { "G4CT", "G4DOCO", "G4DCTO", "G4KCOO" }),
        new JdeIndex("F5201_9", "Index on G4DS, G4DOCO, G4DCTO, G4KCOO", new[] { "G4DS", "G4DOCO", "G4DCTO", "G4KCOO" })
    };
}
