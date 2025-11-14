using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P473T - .
/// </summary>
public class F76P473T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K3HDC.
        /// </summary>
        public const string K3HDC = "K3HDC";

        /// <summary>
        /// K3CKC.
        /// </summary>
        public const string K3CKC = "K3CKC";

        /// <summary>
        /// K3RC.
        /// </summary>
        public const string K3RC = "K3RC";

        /// <summary>
        /// K3DCT.
        /// </summary>
        public const string K3DCT = "K3DCT";

        /// <summary>
        /// K3DOC.
        /// </summary>
        public const string K3DOC = "K3DOC";

        /// <summary>
        /// K3KCO.
        /// </summary>
        public const string K3KCO = "K3KCO";

        /// <summary>
        /// K3SFX.
        /// </summary>
        public const string K3SFX = "K3SFX";

        /// <summary>
        /// K3AN8.
        /// </summary>
        public const string K3AN8 = "K3AN8";

        /// <summary>
        /// K3AG.
        /// </summary>
        public const string K3AG = "K3AG";

        /// <summary>
        /// K3ACR.
        /// </summary>
        public const string K3ACR = "K3ACR";

        /// <summary>
        /// K3CRR.
        /// </summary>
        public const string K3CRR = "K3CRR";

        /// <summary>
        /// K3RMK.
        /// </summary>
        public const string K3RMK = "K3RMK";

        /// <summary>
        /// K3P76CC01.
        /// </summary>
        public const string K3P76CC01 = "K3P76CC01";

        /// <summary>
        /// K3P76CC02.
        /// </summary>
        public const string K3P76CC02 = "K3P76CC02";

        /// <summary>
        /// K3P76CC03.
        /// </summary>
        public const string K3P76CC03 = "K3P76CC03";

        /// <summary>
        /// K3P76CC04.
        /// </summary>
        public const string K3P76CC04 = "K3P76CC04";

        /// <summary>
        /// K3P76CC05.
        /// </summary>
        public const string K3P76CC05 = "K3P76CC05";

        /// <summary>
        /// K3P76CC06.
        /// </summary>
        public const string K3P76CC06 = "K3P76CC06";

        /// <summary>
        /// K3P76CC07.
        /// </summary>
        public const string K3P76CC07 = "K3P76CC07";

        /// <summary>
        /// K3P76CC08.
        /// </summary>
        public const string K3P76CC08 = "K3P76CC08";

        /// <summary>
        /// K3P76CC09.
        /// </summary>
        public const string K3P76CC09 = "K3P76CC09";

        /// <summary>
        /// K3P76CC10.
        /// </summary>
        public const string K3P76CC10 = "K3P76CC10";

        /// <summary>
        /// K3H76FUA.
        /// </summary>
        public const string K3H76FUA = "K3H76FUA";

        /// <summary>
        /// K3H76FUC.
        /// </summary>
        public const string K3H76FUC = "K3H76FUC";

        /// <summary>
        /// K3H76FUD.
        /// </summary>
        public const string K3H76FUD = "K3H76FUD";

        /// <summary>
        /// K3H76FUR.
        /// </summary>
        public const string K3H76FUR = "K3H76FUR";

        /// <summary>
        /// K3H76FUF.
        /// </summary>
        public const string K3H76FUF = "K3H76FUF";

        /// <summary>
        /// K3USER.
        /// </summary>
        public const string K3USER = "K3USER";

        /// <summary>
        /// K3PID.
        /// </summary>
        public const string K3PID = "K3PID";

        /// <summary>
        /// K3JOBN.
        /// </summary>
        public const string K3JOBN = "K3JOBN";

        /// <summary>
        /// K3UPMJ.
        /// </summary>
        public const string K3UPMJ = "K3UPMJ";

        /// <summary>
        /// K3UPMT.
        /// </summary>
        public const string K3UPMT = "K3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P473T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K3HDC", "K3HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("K3CKC", "K3CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("K3RC", "K3RC", JdeDataType.String, 2, true, true),
        new JdeField("K3DCT", "K3DCT", JdeDataType.String, 4, true, true),
        new JdeField("K3DOC", "K3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("K3KCO", "K3KCO", JdeDataType.String, 10, true, true),
        new JdeField("K3SFX", "K3SFX", JdeDataType.String, 6, true, true),
        new JdeField("K3AN8", "K3AN8", JdeDataType.Numeric),
        new JdeField("K3AG", "K3AG", JdeDataType.Numeric),
        new JdeField("K3ACR", "K3ACR", JdeDataType.Numeric),
        new JdeField("K3CRR", "K3CRR", JdeDataType.Numeric),
        new JdeField("K3RMK", "K3RMK", JdeDataType.String, 60),
        new JdeField("K3P76CC01", "K3P76CC01", JdeDataType.String, 6),
        new JdeField("K3P76CC02", "K3P76CC02", JdeDataType.String, 6),
        new JdeField("K3P76CC03", "K3P76CC03", JdeDataType.String, 6),
        new JdeField("K3P76CC04", "K3P76CC04", JdeDataType.String, 6),
        new JdeField("K3P76CC05", "K3P76CC05", JdeDataType.String, 6),
        new JdeField("K3P76CC06", "K3P76CC06", JdeDataType.String, 6),
        new JdeField("K3P76CC07", "K3P76CC07", JdeDataType.String, 6),
        new JdeField("K3P76CC08", "K3P76CC08", JdeDataType.String, 6),
        new JdeField("K3P76CC09", "K3P76CC09", JdeDataType.String, 6),
        new JdeField("K3P76CC10", "K3P76CC10", JdeDataType.String, 6),
        new JdeField("K3H76FUA", "K3H76FUA", JdeDataType.Numeric),
        new JdeField("K3H76FUC", "K3H76FUC", JdeDataType.String, 20),
        new JdeField("K3H76FUD", "K3H76FUD", JdeDataType.Numeric),
        new JdeField("K3H76FUR", "K3H76FUR", JdeDataType.String, 30),
        new JdeField("K3H76FUF", "K3H76FUF", JdeDataType.String, 2),
        new JdeField("K3USER", "K3USER", JdeDataType.String, 20),
        new JdeField("K3PID", "K3PID", JdeDataType.String, 20),
        new JdeField("K3JOBN", "K3JOBN", JdeDataType.String, 20),
        new JdeField("K3UPMJ", "K3UPMJ", JdeDataType.Numeric),
        new JdeField("K3UPMT", "K3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P473T_0", "Primary Key on K3HDC, K3CKC, K3RC, K3DCT, K3DOC, K3KCO, K3SFX", new[] { "K3HDC", "K3CKC", "K3RC", "K3DCT", "K3DOC", "K3KCO", "K3SFX" }, isUnique: true, isPrimaryKey: true)
    };
}
