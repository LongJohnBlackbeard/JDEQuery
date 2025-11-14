using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P04W - .
/// </summary>
public class F74P04W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P2KCO.
        /// </summary>
        public const string P2KCO = "P2KCO";

        /// <summary>
        /// P2DCT.
        /// </summary>
        public const string P2DCT = "P2DCT";

        /// <summary>
        /// P2DOC.
        /// </summary>
        public const string P2DOC = "P2DOC";

        /// <summary>
        /// P2SFX.
        /// </summary>
        public const string P2SFX = "P2SFX";

        /// <summary>
        /// P2CRCD.
        /// </summary>
        public const string P2CRCD = "P2CRCD";

        /// <summary>
        /// P2CO.
        /// </summary>
        public const string P2CO = "P2CO";

        /// <summary>
        /// P2MCU.
        /// </summary>
        public const string P2MCU = "P2MCU";

        /// <summary>
        /// P2OBJ.
        /// </summary>
        public const string P2OBJ = "P2OBJ";

        /// <summary>
        /// P2SUB.
        /// </summary>
        public const string P2SUB = "P2SUB";

        /// <summary>
        /// P2AN8.
        /// </summary>
        public const string P2AN8 = "P2AN8";

        /// <summary>
        /// P2DGJ.
        /// </summary>
        public const string P2DGJ = "P2DGJ";

        /// <summary>
        /// P2AG.
        /// </summary>
        public const string P2AG = "P2AG";

        /// <summary>
        /// P2ACR.
        /// </summary>
        public const string P2ACR = "P2ACR";

        /// <summary>
        /// P2AID.
        /// </summary>
        public const string P2AID = "P2AID";

        /// <summary>
        /// P2RMK.
        /// </summary>
        public const string P2RMK = "P2RMK";

        /// <summary>
        /// P2DCTM.
        /// </summary>
        public const string P2DCTM = "P2DCTM";

        /// <summary>
        /// P2PYID.
        /// </summary>
        public const string P2PYID = "P2PYID";

        /// <summary>
        /// P2RC5.
        /// </summary>
        public const string P2RC5 = "P2RC5";

        /// <summary>
        /// P2URCD.
        /// </summary>
        public const string P2URCD = "P2URCD";

        /// <summary>
        /// P2URDT.
        /// </summary>
        public const string P2URDT = "P2URDT";

        /// <summary>
        /// P2URAB.
        /// </summary>
        public const string P2URAB = "P2URAB";

        /// <summary>
        /// P2URAT.
        /// </summary>
        public const string P2URAT = "P2URAT";

        /// <summary>
        /// P2URRF.
        /// </summary>
        public const string P2URRF = "P2URRF";

        /// <summary>
        /// P2USER.
        /// </summary>
        public const string P2USER = "P2USER";

        /// <summary>
        /// P2PID.
        /// </summary>
        public const string P2PID = "P2PID";

        /// <summary>
        /// P2JOBN.
        /// </summary>
        public const string P2JOBN = "P2JOBN";

        /// <summary>
        /// P2UPMJ.
        /// </summary>
        public const string P2UPMJ = "P2UPMJ";

        /// <summary>
        /// P2UPMT.
        /// </summary>
        public const string P2UPMT = "P2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P04W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P2KCO", "P2KCO", JdeDataType.String, 10, true, true),
        new JdeField("P2DCT", "P2DCT", JdeDataType.String, 4, true, true),
        new JdeField("P2DOC", "P2DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("P2SFX", "P2SFX", JdeDataType.String, 6, true, true),
        new JdeField("P2CRCD", "P2CRCD", JdeDataType.String, 6),
        new JdeField("P2CO", "P2CO", JdeDataType.String, 10),
        new JdeField("P2MCU", "P2MCU", JdeDataType.String, 24),
        new JdeField("P2OBJ", "P2OBJ", JdeDataType.String, 12),
        new JdeField("P2SUB", "P2SUB", JdeDataType.String, 16),
        new JdeField("P2AN8", "P2AN8", JdeDataType.Numeric),
        new JdeField("P2DGJ", "P2DGJ", JdeDataType.Numeric),
        new JdeField("P2AG", "P2AG", JdeDataType.Numeric),
        new JdeField("P2ACR", "P2ACR", JdeDataType.Numeric),
        new JdeField("P2AID", "P2AID", JdeDataType.String, 16),
        new JdeField("P2RMK", "P2RMK", JdeDataType.String, 60),
        new JdeField("P2DCTM", "P2DCTM", JdeDataType.String, 4),
        new JdeField("P2PYID", "P2PYID", JdeDataType.Numeric, null, true, true),
        new JdeField("P2RC5", "P2RC5", JdeDataType.Numeric, null, true, true),
        new JdeField("P2URCD", "P2URCD", JdeDataType.String, 4),
        new JdeField("P2URDT", "P2URDT", JdeDataType.Numeric),
        new JdeField("P2URAB", "P2URAB", JdeDataType.Numeric),
        new JdeField("P2URAT", "P2URAT", JdeDataType.Numeric),
        new JdeField("P2URRF", "P2URRF", JdeDataType.String, 30),
        new JdeField("P2USER", "P2USER", JdeDataType.String, 20),
        new JdeField("P2PID", "P2PID", JdeDataType.String, 20),
        new JdeField("P2JOBN", "P2JOBN", JdeDataType.String, 20),
        new JdeField("P2UPMJ", "P2UPMJ", JdeDataType.Numeric),
        new JdeField("P2UPMT", "P2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P04W_0", "Primary Key on P2KCO, P2DCT, P2DOC, P2SFX, P2PYID, P2RC5", new[] { "P2KCO", "P2DCT", "P2DOC", "P2SFX", "P2PYID", "P2RC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74P04W_2", "Index on P2CRCD, P2CO, P2OBJ, P2MCU, P2SUB, P2AN8, P2DGJ", new[] { "P2CRCD", "P2CO", "P2OBJ", "P2MCU", "P2SUB", "P2AN8", "P2DGJ" }),
        new JdeIndex("F74P04W_3", "Index on P2CO", new[] { "P2CO" })
    };
}
