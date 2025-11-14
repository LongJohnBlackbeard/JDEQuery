using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B473T - .
/// </summary>
public class F76B473T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W3HDC.
        /// </summary>
        public const string W3HDC = "W3HDC";

        /// <summary>
        /// W3CKC.
        /// </summary>
        public const string W3CKC = "W3CKC";

        /// <summary>
        /// W3RC.
        /// </summary>
        public const string W3RC = "W3RC";

        /// <summary>
        /// W3KCO.
        /// </summary>
        public const string W3KCO = "W3KCO";

        /// <summary>
        /// W3DCT.
        /// </summary>
        public const string W3DCT = "W3DCT";

        /// <summary>
        /// W3DOC.
        /// </summary>
        public const string W3DOC = "W3DOC";

        /// <summary>
        /// W3SFX.
        /// </summary>
        public const string W3SFX = "W3SFX";

        /// <summary>
        /// W3AN8.
        /// </summary>
        public const string W3AN8 = "W3AN8";

        /// <summary>
        /// W3DDJ.
        /// </summary>
        public const string W3DDJ = "W3DDJ";

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
        /// W3BRTXTT.
        /// </summary>
        public const string W3BRTXTT = "W3BRTXTT";

        /// <summary>
        /// W3BRRD.
        /// </summary>
        public const string W3BRRD = "W3BRRD";

        /// <summary>
        /// W3BRALQ.
        /// </summary>
        public const string W3BRALQ = "W3BRALQ";

        /// <summary>
        /// W3AAP.
        /// </summary>
        public const string W3AAP = "W3AAP";

        /// <summary>
        /// W3AA.
        /// </summary>
        public const string W3AA = "W3AA";

        /// <summary>
        /// W3ACR.
        /// </summary>
        public const string W3ACR = "W3ACR";

        /// <summary>
        /// W3CRR.
        /// </summary>
        public const string W3CRR = "W3CRR";

        /// <summary>
        /// W3BRAAD.
        /// </summary>
        public const string W3BRAAD = "W3BRAAD";

        /// <summary>
        /// W3MCU.
        /// </summary>
        public const string W3MCU = "W3MCU";

        /// <summary>
        /// W3GLC.
        /// </summary>
        public const string W3GLC = "W3GLC";

        /// <summary>
        /// W3AN8J.
        /// </summary>
        public const string W3AN8J = "W3AN8J";

        /// <summary>
        /// W3OSFX.
        /// </summary>
        public const string W3OSFX = "W3OSFX";

        /// <summary>
        /// W3BRRCT.
        /// </summary>
        public const string W3BRRCT = "W3BRRCT";

        /// <summary>
        /// W3PTC.
        /// </summary>
        public const string W3PTC = "W3PTC";

        /// <summary>
        /// W3BRTXTP.
        /// </summary>
        public const string W3BRTXTP = "W3BRTXTP";

        /// <summary>
        /// W3ODCT.
        /// </summary>
        public const string W3ODCT = "W3ODCT";

        /// <summary>
        /// W3ODOC.
        /// </summary>
        public const string W3ODOC = "W3ODOC";

        /// <summary>
        /// W3VINV.
        /// </summary>
        public const string W3VINV = "W3VINV";

        /// <summary>
        /// W3TAX.
        /// </summary>
        public const string W3TAX = "W3TAX";

        /// <summary>
        /// W3RMK.
        /// </summary>
        public const string W3RMK = "W3RMK";

        /// <summary>
        /// W3RMK2.
        /// </summary>
        public const string W3RMK2 = "W3RMK2";

        /// <summary>
        /// W3USER.
        /// </summary>
        public const string W3USER = "W3USER";

        /// <summary>
        /// W3PID.
        /// </summary>
        public const string W3PID = "W3PID";

        /// <summary>
        /// W3JOBN.
        /// </summary>
        public const string W3JOBN = "W3JOBN";

        /// <summary>
        /// W3UPMJ.
        /// </summary>
        public const string W3UPMJ = "W3UPMJ";

        /// <summary>
        /// W3UPMT.
        /// </summary>
        public const string W3UPMT = "W3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B473T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W3HDC", "W3HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("W3CKC", "W3CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("W3RC", "W3RC", JdeDataType.String, 2, true, true),
        new JdeField("W3KCO", "W3KCO", JdeDataType.String, 10, true, true),
        new JdeField("W3DCT", "W3DCT", JdeDataType.String, 4, true, true),
        new JdeField("W3DOC", "W3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("W3SFX", "W3SFX", JdeDataType.String, 6, true, true),
        new JdeField("W3AN8", "W3AN8", JdeDataType.Numeric),
        new JdeField("W3DDJ", "W3DDJ", JdeDataType.Numeric),
        new JdeField("W3DGJ", "W3DGJ", JdeDataType.Numeric),
        new JdeField("W3PN", "W3PN", JdeDataType.Numeric),
        new JdeField("W3FY", "W3FY", JdeDataType.Numeric),
        new JdeField("W3BRTXTT", "W3BRTXTT", JdeDataType.Numeric),
        new JdeField("W3BRRD", "W3BRRD", JdeDataType.Numeric),
        new JdeField("W3BRALQ", "W3BRALQ", JdeDataType.Numeric),
        new JdeField("W3AAP", "W3AAP", JdeDataType.Numeric),
        new JdeField("W3AA", "W3AA", JdeDataType.Numeric),
        new JdeField("W3ACR", "W3ACR", JdeDataType.Numeric),
        new JdeField("W3CRR", "W3CRR", JdeDataType.Numeric),
        new JdeField("W3BRAAD", "W3BRAAD", JdeDataType.Numeric),
        new JdeField("W3MCU", "W3MCU", JdeDataType.String, 24),
        new JdeField("W3GLC", "W3GLC", JdeDataType.String, 8),
        new JdeField("W3AN8J", "W3AN8J", JdeDataType.Numeric),
        new JdeField("W3OSFX", "W3OSFX", JdeDataType.String, 6),
        new JdeField("W3BRRCT", "W3BRRCT", JdeDataType.Numeric),
        new JdeField("W3PTC", "W3PTC", JdeDataType.String, 6),
        new JdeField("W3BRTXTP", "W3BRTXTP", JdeDataType.String, 4),
        new JdeField("W3ODCT", "W3ODCT", JdeDataType.String, 4),
        new JdeField("W3ODOC", "W3ODOC", JdeDataType.Numeric),
        new JdeField("W3VINV", "W3VINV", JdeDataType.String, 50),
        new JdeField("W3TAX", "W3TAX", JdeDataType.String, 40),
        new JdeField("W3RMK", "W3RMK", JdeDataType.String, 60),
        new JdeField("W3RMK2", "W3RMK2", JdeDataType.String, 60),
        new JdeField("W3USER", "W3USER", JdeDataType.String, 20),
        new JdeField("W3PID", "W3PID", JdeDataType.String, 20),
        new JdeField("W3JOBN", "W3JOBN", JdeDataType.String, 20),
        new JdeField("W3UPMJ", "W3UPMJ", JdeDataType.Numeric),
        new JdeField("W3UPMT", "W3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B473T_0", "Primary Key on W3HDC, W3CKC, W3RC, W3KCO, W3DCT, W3DOC, W3SFX", new[] { "W3HDC", "W3CKC", "W3RC", "W3KCO", "W3DCT", "W3DOC", "W3SFX" }, isUnique: true, isPrimaryKey: true)
    };
}
