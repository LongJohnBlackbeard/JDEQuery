using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S911 - .
/// </summary>
public class F48S911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W3ICU.
        /// </summary>
        public const string W3ICU = "W3ICU";

        /// <summary>
        /// W3ICUA.
        /// </summary>
        public const string W3ICUA = "W3ICUA";

        /// <summary>
        /// W3BCTY.
        /// </summary>
        public const string W3BCTY = "W3BCTY";

        /// <summary>
        /// W3GTYP.
        /// </summary>
        public const string W3GTYP = "W3GTYP";

        /// <summary>
        /// W3KCO.
        /// </summary>
        public const string W3KCO = "W3KCO";

        /// <summary>
        /// W3CO.
        /// </summary>
        public const string W3CO = "W3CO";

        /// <summary>
        /// W3DCT.
        /// </summary>
        public const string W3DCT = "W3DCT";

        /// <summary>
        /// W3DOC.
        /// </summary>
        public const string W3DOC = "W3DOC";

        /// <summary>
        /// W3DGJ.
        /// </summary>
        public const string W3DGJ = "W3DGJ";

        /// <summary>
        /// W3PN.
        /// </summary>
        public const string W3PN = "W3PN";

        /// <summary>
        /// W3FY.
        /// </summary>
        public const string W3FY = "W3FY";

        /// <summary>
        /// W3CTRY.
        /// </summary>
        public const string W3CTRY = "W3CTRY";

        /// <summary>
        /// W3JELN.
        /// </summary>
        public const string W3JELN = "W3JELN";

        /// <summary>
        /// W3MCU.
        /// </summary>
        public const string W3MCU = "W3MCU";

        /// <summary>
        /// W3OBJ.
        /// </summary>
        public const string W3OBJ = "W3OBJ";

        /// <summary>
        /// W3SUB.
        /// </summary>
        public const string W3SUB = "W3SUB";

        /// <summary>
        /// W3SBL.
        /// </summary>
        public const string W3SBL = "W3SBL";

        /// <summary>
        /// W3SBLT.
        /// </summary>
        public const string W3SBLT = "W3SBLT";

        /// <summary>
        /// W3AID.
        /// </summary>
        public const string W3AID = "W3AID";

        /// <summary>
        /// W3AM.
        /// </summary>
        public const string W3AM = "W3AM";

        /// <summary>
        /// W3ANI.
        /// </summary>
        public const string W3ANI = "W3ANI";

        /// <summary>
        /// W3LT.
        /// </summary>
        public const string W3LT = "W3LT";

        /// <summary>
        /// W3CRCD.
        /// </summary>
        public const string W3CRCD = "W3CRCD";

        /// <summary>
        /// W3CRCE.
        /// </summary>
        public const string W3CRCE = "W3CRCE";

        /// <summary>
        /// W3CRCF.
        /// </summary>
        public const string W3CRCF = "W3CRCF";

        /// <summary>
        /// W3AA.
        /// </summary>
        public const string W3AA = "W3AA";

        /// <summary>
        /// W3U.
        /// </summary>
        public const string W3U = "W3U";

        /// <summary>
        /// W3CRR.
        /// </summary>
        public const string W3CRR = "W3CRR";

        /// <summary>
        /// W3ITAM.
        /// </summary>
        public const string W3ITAM = "W3ITAM";

        /// <summary>
        /// W3UM.
        /// </summary>
        public const string W3UM = "W3UM";

        /// <summary>
        /// W3ACR.
        /// </summary>
        public const string W3ACR = "W3ACR";

        /// <summary>
        /// W3CITX.
        /// </summary>
        public const string W3CITX = "W3CITX";

        /// <summary>
        /// W3GLC.
        /// </summary>
        public const string W3GLC = "W3GLC";

        /// <summary>
        /// W3AN8.
        /// </summary>
        public const string W3AN8 = "W3AN8";

        /// <summary>
        /// W3EXA.
        /// </summary>
        public const string W3EXA = "W3EXA";

        /// <summary>
        /// W3EXR.
        /// </summary>
        public const string W3EXR = "W3EXR";

        /// <summary>
        /// W3EQCG.
        /// </summary>
        public const string W3EQCG = "W3EQCG";

        /// <summary>
        /// W3WR01.
        /// </summary>
        public const string W3WR01 = "W3WR01";

        /// <summary>
        /// W3JBCD.
        /// </summary>
        public const string W3JBCD = "W3JBCD";

        /// <summary>
        /// W3JBST.
        /// </summary>
        public const string W3JBST = "W3JBST";

        /// <summary>
        /// W3HMCU.
        /// </summary>
        public const string W3HMCU = "W3HMCU";

        /// <summary>
        /// W3DSVJ.
        /// </summary>
        public const string W3DSVJ = "W3DSVJ";

        /// <summary>
        /// W3UKID.
        /// </summary>
        public const string W3UKID = "W3UKID";

        /// <summary>
        /// W3JOBN.
        /// </summary>
        public const string W3JOBN = "W3JOBN";

        /// <summary>
        /// W3PID.
        /// </summary>
        public const string W3PID = "W3PID";

        /// <summary>
        /// W3USER.
        /// </summary>
        public const string W3USER = "W3USER";

        /// <summary>
        /// W3UPMJ.
        /// </summary>
        public const string W3UPMJ = "W3UPMJ";

        /// <summary>
        /// W3UPMT.
        /// </summary>
        public const string W3UPMT = "W3UPMT";

        /// <summary>
        /// W3TXA1.
        /// </summary>
        public const string W3TXA1 = "W3TXA1";

        /// <summary>
        /// W3EXR1.
        /// </summary>
        public const string W3EXR1 = "W3EXR1";

        /// <summary>
        /// W3TXITM.
        /// </summary>
        public const string W3TXITM = "W3TXITM";

        /// <summary>
        /// W3SFX.
        /// </summary>
        public const string W3SFX = "W3SFX";
    }

    /// <inheritdoc />
    public override string TableName => "F48S911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W3ICU", "W3ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("W3ICUA", "W3ICUA", JdeDataType.Numeric),
        new JdeField("W3BCTY", "W3BCTY", JdeDataType.String, 2),
        new JdeField("W3GTYP", "W3GTYP", JdeDataType.String, 2),
        new JdeField("W3KCO", "W3KCO", JdeDataType.String, 10),
        new JdeField("W3CO", "W3CO", JdeDataType.String, 10, true, true),
        new JdeField("W3DCT", "W3DCT", JdeDataType.String, 4, true, true),
        new JdeField("W3DOC", "W3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("W3DGJ", "W3DGJ", JdeDataType.Numeric),
        new JdeField("W3PN", "W3PN", JdeDataType.Numeric),
        new JdeField("W3FY", "W3FY", JdeDataType.Numeric),
        new JdeField("W3CTRY", "W3CTRY", JdeDataType.Numeric),
        new JdeField("W3JELN", "W3JELN", JdeDataType.Numeric, null, true, true),
        new JdeField("W3MCU", "W3MCU", JdeDataType.String, 24),
        new JdeField("W3OBJ", "W3OBJ", JdeDataType.String, 12),
        new JdeField("W3SUB", "W3SUB", JdeDataType.String, 16),
        new JdeField("W3SBL", "W3SBL", JdeDataType.String, 16, true, true),
        new JdeField("W3SBLT", "W3SBLT", JdeDataType.String, 2, true, true),
        new JdeField("W3AID", "W3AID", JdeDataType.String, 16, true, true),
        new JdeField("W3AM", "W3AM", JdeDataType.String, 2),
        new JdeField("W3ANI", "W3ANI", JdeDataType.String, 58),
        new JdeField("W3LT", "W3LT", JdeDataType.String, 4, true, true),
        new JdeField("W3CRCD", "W3CRCD", JdeDataType.String, 6),
        new JdeField("W3CRCE", "W3CRCE", JdeDataType.String, 6),
        new JdeField("W3CRCF", "W3CRCF", JdeDataType.String, 6),
        new JdeField("W3AA", "W3AA", JdeDataType.Numeric),
        new JdeField("W3U", "W3U", JdeDataType.Numeric),
        new JdeField("W3CRR", "W3CRR", JdeDataType.Numeric),
        new JdeField("W3ITAM", "W3ITAM", JdeDataType.Numeric),
        new JdeField("W3UM", "W3UM", JdeDataType.String, 4),
        new JdeField("W3ACR", "W3ACR", JdeDataType.Numeric),
        new JdeField("W3CITX", "W3CITX", JdeDataType.Numeric),
        new JdeField("W3GLC", "W3GLC", JdeDataType.String, 8),
        new JdeField("W3AN8", "W3AN8", JdeDataType.Numeric),
        new JdeField("W3EXA", "W3EXA", JdeDataType.String, 60),
        new JdeField("W3EXR", "W3EXR", JdeDataType.String, 60),
        new JdeField("W3EQCG", "W3EQCG", JdeDataType.String, 18),
        new JdeField("W3WR01", "W3WR01", JdeDataType.String, 8),
        new JdeField("W3JBCD", "W3JBCD", JdeDataType.String, 12),
        new JdeField("W3JBST", "W3JBST", JdeDataType.String, 8),
        new JdeField("W3HMCU", "W3HMCU", JdeDataType.String, 24),
        new JdeField("W3DSVJ", "W3DSVJ", JdeDataType.Numeric),
        new JdeField("W3UKID", "W3UKID", JdeDataType.Numeric),
        new JdeField("W3JOBN", "W3JOBN", JdeDataType.String, 20),
        new JdeField("W3PID", "W3PID", JdeDataType.String, 20),
        new JdeField("W3USER", "W3USER", JdeDataType.String, 20),
        new JdeField("W3UPMJ", "W3UPMJ", JdeDataType.Numeric),
        new JdeField("W3UPMT", "W3UPMT", JdeDataType.Numeric),
        new JdeField("W3TXA1", "W3TXA1", JdeDataType.String, 20),
        new JdeField("W3EXR1", "W3EXR1", JdeDataType.String, 4),
        new JdeField("W3TXITM", "W3TXITM", JdeDataType.Numeric),
        new JdeField("W3SFX", "W3SFX", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S911_0", "Primary Key on W3ICU, W3CO, W3LT, W3DCT, W3DOC, W3AID, W3SBL, W3SBLT, W3JELN", new[] { "W3ICU", "W3CO", "W3LT", "W3DCT", "W3DOC", "W3AID", "W3SBL", "W3SBLT", "W3JELN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S911_2", "Index on W3ICU", new[] { "W3ICU" }),
        new JdeIndex("F48S911_3", "Index on W3ICUA", new[] { "W3ICUA" }),
        new JdeIndex("F48S911_4", "Index on W3CO, W3LT, W3DCT, W3KCO, W3DOC, W3ANI, W3SBLT, W3SBL", new[] { "W3CO", "W3LT", "W3DCT", "W3KCO", "W3DOC", "W3ANI", "W3SBLT", "W3SBL" })
    };
}
