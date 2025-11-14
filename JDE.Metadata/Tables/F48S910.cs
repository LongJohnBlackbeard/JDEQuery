using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S910 - .
/// </summary>
public class F48S910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W2ICU.
        /// </summary>
        public const string W2ICU = "W2ICU";

        /// <summary>
        /// W2ICUA.
        /// </summary>
        public const string W2ICUA = "W2ICUA";

        /// <summary>
        /// W2BCTY.
        /// </summary>
        public const string W2BCTY = "W2BCTY";

        /// <summary>
        /// W2GTYP.
        /// </summary>
        public const string W2GTYP = "W2GTYP";

        /// <summary>
        /// W2CRDB.
        /// </summary>
        public const string W2CRDB = "W2CRDB";

        /// <summary>
        /// W2KCO.
        /// </summary>
        public const string W2KCO = "W2KCO";

        /// <summary>
        /// W2CO.
        /// </summary>
        public const string W2CO = "W2CO";

        /// <summary>
        /// W2DGJ.
        /// </summary>
        public const string W2DGJ = "W2DGJ";

        /// <summary>
        /// W2PN.
        /// </summary>
        public const string W2PN = "W2PN";

        /// <summary>
        /// W2FY.
        /// </summary>
        public const string W2FY = "W2FY";

        /// <summary>
        /// W2CTRY.
        /// </summary>
        public const string W2CTRY = "W2CTRY";

        /// <summary>
        /// W2DCT.
        /// </summary>
        public const string W2DCT = "W2DCT";

        /// <summary>
        /// W2DOC.
        /// </summary>
        public const string W2DOC = "W2DOC";

        /// <summary>
        /// W2SFX.
        /// </summary>
        public const string W2SFX = "W2SFX";

        /// <summary>
        /// W2JELN.
        /// </summary>
        public const string W2JELN = "W2JELN";

        /// <summary>
        /// W2MCU.
        /// </summary>
        public const string W2MCU = "W2MCU";

        /// <summary>
        /// W2OBJ.
        /// </summary>
        public const string W2OBJ = "W2OBJ";

        /// <summary>
        /// W2SUB.
        /// </summary>
        public const string W2SUB = "W2SUB";

        /// <summary>
        /// W2SBL.
        /// </summary>
        public const string W2SBL = "W2SBL";

        /// <summary>
        /// W2SBLT.
        /// </summary>
        public const string W2SBLT = "W2SBLT";

        /// <summary>
        /// W2AID.
        /// </summary>
        public const string W2AID = "W2AID";

        /// <summary>
        /// W2AM.
        /// </summary>
        public const string W2AM = "W2AM";

        /// <summary>
        /// W2ANI.
        /// </summary>
        public const string W2ANI = "W2ANI";

        /// <summary>
        /// W2LT.
        /// </summary>
        public const string W2LT = "W2LT";

        /// <summary>
        /// W2EXA.
        /// </summary>
        public const string W2EXA = "W2EXA";

        /// <summary>
        /// W2EXR.
        /// </summary>
        public const string W2EXR = "W2EXR";

        /// <summary>
        /// W2GLC.
        /// </summary>
        public const string W2GLC = "W2GLC";

        /// <summary>
        /// W2AN8.
        /// </summary>
        public const string W2AN8 = "W2AN8";

        /// <summary>
        /// W2ASID.
        /// </summary>
        public const string W2ASID = "W2ASID";

        /// <summary>
        /// W2AA.
        /// </summary>
        public const string W2AA = "W2AA";

        /// <summary>
        /// W2ACR.
        /// </summary>
        public const string W2ACR = "W2ACR";

        /// <summary>
        /// W2U.
        /// </summary>
        public const string W2U = "W2U";

        /// <summary>
        /// W2UM.
        /// </summary>
        public const string W2UM = "W2UM";

        /// <summary>
        /// W2JTAX.
        /// </summary>
        public const string W2JTAX = "W2JTAX";

        /// <summary>
        /// W2JTXF.
        /// </summary>
        public const string W2JTXF = "W2JTXF";

        /// <summary>
        /// W2AA1.
        /// </summary>
        public const string W2AA1 = "W2AA1";

        /// <summary>
        /// W2AA2.
        /// </summary>
        public const string W2AA2 = "W2AA2";

        /// <summary>
        /// W2CRCD.
        /// </summary>
        public const string W2CRCD = "W2CRCD";

        /// <summary>
        /// W2CRCE.
        /// </summary>
        public const string W2CRCE = "W2CRCE";

        /// <summary>
        /// W2CRCF.
        /// </summary>
        public const string W2CRCF = "W2CRCF";

        /// <summary>
        /// W2ERDB.
        /// </summary>
        public const string W2ERDB = "W2ERDB";

        /// <summary>
        /// W2CRRM.
        /// </summary>
        public const string W2CRRM = "W2CRRM";

        /// <summary>
        /// W2ERDT.
        /// </summary>
        public const string W2ERDT = "W2ERDT";

        /// <summary>
        /// W2CRR.
        /// </summary>
        public const string W2CRR = "W2CRR";

        /// <summary>
        /// W2CRRD.
        /// </summary>
        public const string W2CRRD = "W2CRRD";

        /// <summary>
        /// W2EXR1.
        /// </summary>
        public const string W2EXR1 = "W2EXR1";

        /// <summary>
        /// W2WR01.
        /// </summary>
        public const string W2WR01 = "W2WR01";

        /// <summary>
        /// W2JBCD.
        /// </summary>
        public const string W2JBCD = "W2JBCD";

        /// <summary>
        /// W2JBST.
        /// </summary>
        public const string W2JBST = "W2JBST";

        /// <summary>
        /// W2HMCU.
        /// </summary>
        public const string W2HMCU = "W2HMCU";

        /// <summary>
        /// W2JMCU.
        /// </summary>
        public const string W2JMCU = "W2JMCU";

        /// <summary>
        /// W2ANUM.
        /// </summary>
        public const string W2ANUM = "W2ANUM";

        /// <summary>
        /// W2TYKY.
        /// </summary>
        public const string W2TYKY = "W2TYKY";

        /// <summary>
        /// W2TKEY.
        /// </summary>
        public const string W2TKEY = "W2TKEY";

        /// <summary>
        /// W2TBDT.
        /// </summary>
        public const string W2TBDT = "W2TBDT";

        /// <summary>
        /// W2AN8O.
        /// </summary>
        public const string W2AN8O = "W2AN8O";

        /// <summary>
        /// W2DOCO.
        /// </summary>
        public const string W2DOCO = "W2DOCO";

        /// <summary>
        /// W2PCTN.
        /// </summary>
        public const string W2PCTN = "W2PCTN";

        /// <summary>
        /// W2COCH.
        /// </summary>
        public const string W2COCH = "W2COCH";

        /// <summary>
        /// W2LNID.
        /// </summary>
        public const string W2LNID = "W2LNID";

        /// <summary>
        /// W2MCUF.
        /// </summary>
        public const string W2MCUF = "W2MCUF";

        /// <summary>
        /// W2OBJF.
        /// </summary>
        public const string W2OBJF = "W2OBJF";

        /// <summary>
        /// W2SUBSID.
        /// </summary>
        public const string W2SUBSID = "W2SUBSID";

        /// <summary>
        /// W2SBLC.
        /// </summary>
        public const string W2SBLC = "W2SBLC";

        /// <summary>
        /// W2SBTC.
        /// </summary>
        public const string W2SBTC = "W2SBTC";

        /// <summary>
        /// W2WR07.
        /// </summary>
        public const string W2WR07 = "W2WR07";

        /// <summary>
        /// W2RP11.
        /// </summary>
        public const string W2RP11 = "W2RP11";

        /// <summary>
        /// W2BCI.
        /// </summary>
        public const string W2BCI = "W2BCI";

        /// <summary>
        /// W2DGL.
        /// </summary>
        public const string W2DGL = "W2DGL";

        /// <summary>
        /// W2PRSQ.
        /// </summary>
        public const string W2PRSQ = "W2PRSQ";

        /// <summary>
        /// W2SBSQ.
        /// </summary>
        public const string W2SBSQ = "W2SBSQ";

        /// <summary>
        /// W2SCSQ.
        /// </summary>
        public const string W2SCSQ = "W2SCSQ";

        /// <summary>
        /// W2SLNK.
        /// </summary>
        public const string W2SLNK = "W2SLNK";

        /// <summary>
        /// W2CLNK.
        /// </summary>
        public const string W2CLNK = "W2CLNK";

        /// <summary>
        /// W2CCOD.
        /// </summary>
        public const string W2CCOD = "W2CCOD";

        /// <summary>
        /// W2TCLS.
        /// </summary>
        public const string W2TCLS = "W2TCLS";

        /// <summary>
        /// W2ELGC.
        /// </summary>
        public const string W2ELGC = "W2ELGC";

        /// <summary>
        /// W2DSVJ.
        /// </summary>
        public const string W2DSVJ = "W2DSVJ";

        /// <summary>
        /// W2PRTR.
        /// </summary>
        public const string W2PRTR = "W2PRTR";

        /// <summary>
        /// W2PRTO.
        /// </summary>
        public const string W2PRTO = "W2PRTO";

        /// <summary>
        /// W2UKID.
        /// </summary>
        public const string W2UKID = "W2UKID";

        /// <summary>
        /// W2JOBN.
        /// </summary>
        public const string W2JOBN = "W2JOBN";

        /// <summary>
        /// W2PID.
        /// </summary>
        public const string W2PID = "W2PID";

        /// <summary>
        /// W2USER.
        /// </summary>
        public const string W2USER = "W2USER";

        /// <summary>
        /// W2UPMJ.
        /// </summary>
        public const string W2UPMJ = "W2UPMJ";

        /// <summary>
        /// W2UPMT.
        /// </summary>
        public const string W2UPMT = "W2UPMT";

        /// <summary>
        /// W2TXA1.
        /// </summary>
        public const string W2TXA1 = "W2TXA1";

        /// <summary>
        /// W2TXITM.
        /// </summary>
        public const string W2TXITM = "W2TXITM";
    }

    /// <inheritdoc />
    public override string TableName => "F48S910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W2ICU", "W2ICU", JdeDataType.Numeric),
        new JdeField("W2ICUA", "W2ICUA", JdeDataType.Numeric),
        new JdeField("W2BCTY", "W2BCTY", JdeDataType.String, 2),
        new JdeField("W2GTYP", "W2GTYP", JdeDataType.String, 2),
        new JdeField("W2CRDB", "W2CRDB", JdeDataType.String, 2),
        new JdeField("W2KCO", "W2KCO", JdeDataType.String, 10),
        new JdeField("W2CO", "W2CO", JdeDataType.String, 10),
        new JdeField("W2DGJ", "W2DGJ", JdeDataType.Numeric),
        new JdeField("W2PN", "W2PN", JdeDataType.Numeric),
        new JdeField("W2FY", "W2FY", JdeDataType.Numeric),
        new JdeField("W2CTRY", "W2CTRY", JdeDataType.Numeric),
        new JdeField("W2DCT", "W2DCT", JdeDataType.String, 4),
        new JdeField("W2DOC", "W2DOC", JdeDataType.Numeric),
        new JdeField("W2SFX", "W2SFX", JdeDataType.String, 6),
        new JdeField("W2JELN", "W2JELN", JdeDataType.Numeric),
        new JdeField("W2MCU", "W2MCU", JdeDataType.String, 24),
        new JdeField("W2OBJ", "W2OBJ", JdeDataType.String, 12),
        new JdeField("W2SUB", "W2SUB", JdeDataType.String, 16),
        new JdeField("W2SBL", "W2SBL", JdeDataType.String, 16),
        new JdeField("W2SBLT", "W2SBLT", JdeDataType.String, 2),
        new JdeField("W2AID", "W2AID", JdeDataType.String, 16),
        new JdeField("W2AM", "W2AM", JdeDataType.String, 2),
        new JdeField("W2ANI", "W2ANI", JdeDataType.String, 58),
        new JdeField("W2LT", "W2LT", JdeDataType.String, 4),
        new JdeField("W2EXA", "W2EXA", JdeDataType.String, 60),
        new JdeField("W2EXR", "W2EXR", JdeDataType.String, 60),
        new JdeField("W2GLC", "W2GLC", JdeDataType.String, 8),
        new JdeField("W2AN8", "W2AN8", JdeDataType.Numeric),
        new JdeField("W2ASID", "W2ASID", JdeDataType.String, 50),
        new JdeField("W2AA", "W2AA", JdeDataType.Numeric),
        new JdeField("W2ACR", "W2ACR", JdeDataType.Numeric),
        new JdeField("W2U", "W2U", JdeDataType.Numeric),
        new JdeField("W2UM", "W2UM", JdeDataType.String, 4),
        new JdeField("W2JTAX", "W2JTAX", JdeDataType.Numeric),
        new JdeField("W2JTXF", "W2JTXF", JdeDataType.Numeric),
        new JdeField("W2AA1", "W2AA1", JdeDataType.Numeric),
        new JdeField("W2AA2", "W2AA2", JdeDataType.Numeric),
        new JdeField("W2CRCD", "W2CRCD", JdeDataType.String, 6),
        new JdeField("W2CRCE", "W2CRCE", JdeDataType.String, 6),
        new JdeField("W2CRCF", "W2CRCF", JdeDataType.String, 6),
        new JdeField("W2ERDB", "W2ERDB", JdeDataType.String, 2),
        new JdeField("W2CRRM", "W2CRRM", JdeDataType.String, 2),
        new JdeField("W2ERDT", "W2ERDT", JdeDataType.Numeric),
        new JdeField("W2CRR", "W2CRR", JdeDataType.Numeric),
        new JdeField("W2CRRD", "W2CRRD", JdeDataType.Numeric),
        new JdeField("W2EXR1", "W2EXR1", JdeDataType.String, 4),
        new JdeField("W2WR01", "W2WR01", JdeDataType.String, 8),
        new JdeField("W2JBCD", "W2JBCD", JdeDataType.String, 12),
        new JdeField("W2JBST", "W2JBST", JdeDataType.String, 8),
        new JdeField("W2HMCU", "W2HMCU", JdeDataType.String, 24),
        new JdeField("W2JMCU", "W2JMCU", JdeDataType.String, 24),
        new JdeField("W2ANUM", "W2ANUM", JdeDataType.Numeric),
        new JdeField("W2TYKY", "W2TYKY", JdeDataType.String, 2),
        new JdeField("W2TKEY", "W2TKEY", JdeDataType.String, 24),
        new JdeField("W2TBDT", "W2TBDT", JdeDataType.Numeric),
        new JdeField("W2AN8O", "W2AN8O", JdeDataType.Numeric),
        new JdeField("W2DOCO", "W2DOCO", JdeDataType.Numeric),
        new JdeField("W2PCTN", "W2PCTN", JdeDataType.Numeric),
        new JdeField("W2COCH", "W2COCH", JdeDataType.String, 6),
        new JdeField("W2LNID", "W2LNID", JdeDataType.Numeric),
        new JdeField("W2MCUF", "W2MCUF", JdeDataType.String, 24),
        new JdeField("W2OBJF", "W2OBJF", JdeDataType.String, 12),
        new JdeField("W2SUBSID", "W2SUBSID", JdeDataType.String, 16),
        new JdeField("W2SBLC", "W2SBLC", JdeDataType.String, 16),
        new JdeField("W2SBTC", "W2SBTC", JdeDataType.String, 2),
        new JdeField("W2WR07", "W2WR07", JdeDataType.String, 6),
        new JdeField("W2RP11", "W2RP11", JdeDataType.String, 6),
        new JdeField("W2BCI", "W2BCI", JdeDataType.Numeric),
        new JdeField("W2DGL", "W2DGL", JdeDataType.Numeric),
        new JdeField("W2PRSQ", "W2PRSQ", JdeDataType.Numeric),
        new JdeField("W2SBSQ", "W2SBSQ", JdeDataType.Numeric),
        new JdeField("W2SCSQ", "W2SCSQ", JdeDataType.Numeric),
        new JdeField("W2SLNK", "W2SLNK", JdeDataType.Numeric),
        new JdeField("W2CLNK", "W2CLNK", JdeDataType.Numeric),
        new JdeField("W2CCOD", "W2CCOD", JdeDataType.String, 10),
        new JdeField("W2TCLS", "W2TCLS", JdeDataType.String, 2),
        new JdeField("W2ELGC", "W2ELGC", JdeDataType.String, 2),
        new JdeField("W2DSVJ", "W2DSVJ", JdeDataType.Numeric),
        new JdeField("W2PRTR", "W2PRTR", JdeDataType.Numeric),
        new JdeField("W2PRTO", "W2PRTO", JdeDataType.Numeric),
        new JdeField("W2UKID", "W2UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("W2JOBN", "W2JOBN", JdeDataType.String, 20),
        new JdeField("W2PID", "W2PID", JdeDataType.String, 20),
        new JdeField("W2USER", "W2USER", JdeDataType.String, 20),
        new JdeField("W2UPMJ", "W2UPMJ", JdeDataType.Numeric),
        new JdeField("W2UPMT", "W2UPMT", JdeDataType.Numeric),
        new JdeField("W2TXA1", "W2TXA1", JdeDataType.String, 20),
        new JdeField("W2TXITM", "W2TXITM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S910_0", "Primary Key on W2UKID", new[] { "W2UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S910_2", "Index on W2ICUA", new[] { "W2ICUA" }),
        new JdeIndex("F48S910_3", "Index on W2ICU", new[] { "W2ICU" }),
        new JdeIndex("F48S910_4", "Index on W2ICU, W2ANUM", new[] { "W2ICU", "W2ANUM" })
    };
}
