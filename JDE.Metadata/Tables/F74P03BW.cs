using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P03BW - .
/// </summary>
public class F74P03BW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P3KCO.
        /// </summary>
        public const string P3KCO = "P3KCO";

        /// <summary>
        /// P3DCT.
        /// </summary>
        public const string P3DCT = "P3DCT";

        /// <summary>
        /// P3DOC.
        /// </summary>
        public const string P3DOC = "P3DOC";

        /// <summary>
        /// P3SFX.
        /// </summary>
        public const string P3SFX = "P3SFX";

        /// <summary>
        /// P3CRCD.
        /// </summary>
        public const string P3CRCD = "P3CRCD";

        /// <summary>
        /// P3CO.
        /// </summary>
        public const string P3CO = "P3CO";

        /// <summary>
        /// P3MCU.
        /// </summary>
        public const string P3MCU = "P3MCU";

        /// <summary>
        /// P3OBJ.
        /// </summary>
        public const string P3OBJ = "P3OBJ";

        /// <summary>
        /// P3SUB.
        /// </summary>
        public const string P3SUB = "P3SUB";

        /// <summary>
        /// P3AN8.
        /// </summary>
        public const string P3AN8 = "P3AN8";

        /// <summary>
        /// P3DGJ.
        /// </summary>
        public const string P3DGJ = "P3DGJ";

        /// <summary>
        /// P3AG.
        /// </summary>
        public const string P3AG = "P3AG";

        /// <summary>
        /// P3ACR.
        /// </summary>
        public const string P3ACR = "P3ACR";

        /// <summary>
        /// P3AID.
        /// </summary>
        public const string P3AID = "P3AID";

        /// <summary>
        /// P3RMK.
        /// </summary>
        public const string P3RMK = "P3RMK";

        /// <summary>
        /// P3DCTM.
        /// </summary>
        public const string P3DCTM = "P3DCTM";

        /// <summary>
        /// P3RC5.
        /// </summary>
        public const string P3RC5 = "P3RC5";

        /// <summary>
        /// P3PYID.
        /// </summary>
        public const string P3PYID = "P3PYID";

        /// <summary>
        /// P3URCD.
        /// </summary>
        public const string P3URCD = "P3URCD";

        /// <summary>
        /// P3URDT.
        /// </summary>
        public const string P3URDT = "P3URDT";

        /// <summary>
        /// P3URAT.
        /// </summary>
        public const string P3URAT = "P3URAT";

        /// <summary>
        /// P3URAB.
        /// </summary>
        public const string P3URAB = "P3URAB";

        /// <summary>
        /// P3URRF.
        /// </summary>
        public const string P3URRF = "P3URRF";

        /// <summary>
        /// P3USER.
        /// </summary>
        public const string P3USER = "P3USER";

        /// <summary>
        /// P3PID.
        /// </summary>
        public const string P3PID = "P3PID";

        /// <summary>
        /// P3JOBN.
        /// </summary>
        public const string P3JOBN = "P3JOBN";

        /// <summary>
        /// P3UPMJ.
        /// </summary>
        public const string P3UPMJ = "P3UPMJ";

        /// <summary>
        /// P3UPMT.
        /// </summary>
        public const string P3UPMT = "P3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P03BW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P3KCO", "P3KCO", JdeDataType.String, 10, true, true),
        new JdeField("P3DCT", "P3DCT", JdeDataType.String, 4, true, true),
        new JdeField("P3DOC", "P3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("P3SFX", "P3SFX", JdeDataType.String, 6, true, true),
        new JdeField("P3CRCD", "P3CRCD", JdeDataType.String, 6),
        new JdeField("P3CO", "P3CO", JdeDataType.String, 10),
        new JdeField("P3MCU", "P3MCU", JdeDataType.String, 24),
        new JdeField("P3OBJ", "P3OBJ", JdeDataType.String, 12),
        new JdeField("P3SUB", "P3SUB", JdeDataType.String, 16),
        new JdeField("P3AN8", "P3AN8", JdeDataType.Numeric),
        new JdeField("P3DGJ", "P3DGJ", JdeDataType.Numeric),
        new JdeField("P3AG", "P3AG", JdeDataType.Numeric),
        new JdeField("P3ACR", "P3ACR", JdeDataType.Numeric),
        new JdeField("P3AID", "P3AID", JdeDataType.String, 16),
        new JdeField("P3RMK", "P3RMK", JdeDataType.String, 60),
        new JdeField("P3DCTM", "P3DCTM", JdeDataType.String, 4),
        new JdeField("P3RC5", "P3RC5", JdeDataType.Numeric, null, true, true),
        new JdeField("P3PYID", "P3PYID", JdeDataType.Numeric, null, true, true),
        new JdeField("P3URCD", "P3URCD", JdeDataType.String, 4),
        new JdeField("P3URDT", "P3URDT", JdeDataType.Numeric),
        new JdeField("P3URAT", "P3URAT", JdeDataType.Numeric),
        new JdeField("P3URAB", "P3URAB", JdeDataType.Numeric),
        new JdeField("P3URRF", "P3URRF", JdeDataType.String, 30),
        new JdeField("P3USER", "P3USER", JdeDataType.String, 20),
        new JdeField("P3PID", "P3PID", JdeDataType.String, 20),
        new JdeField("P3JOBN", "P3JOBN", JdeDataType.String, 20),
        new JdeField("P3UPMJ", "P3UPMJ", JdeDataType.Numeric),
        new JdeField("P3UPMT", "P3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P03BW_0", "Primary Key on P3DOC, P3DCT, P3KCO, P3SFX, P3PYID, P3RC5", new[] { "P3DOC", "P3DCT", "P3KCO", "P3SFX", "P3PYID", "P3RC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74P03BW_2", "Index on P3CRCD, P3CO, P3MCU, P3OBJ, P3SUB, P3AN8, P3DGJ", new[] { "P3CRCD", "P3CO", "P3MCU", "P3OBJ", "P3SUB", "P3AN8", "P3DGJ" }),
        new JdeIndex("F74P03BW_3", "Index on P3CO", new[] { "P3CO" })
    };
}
