using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P472T - .
/// </summary>
public class F76P472T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K2HDC.
        /// </summary>
        public const string K2HDC = "K2HDC";

        /// <summary>
        /// K2CKC.
        /// </summary>
        public const string K2CKC = "K2CKC";

        /// <summary>
        /// K2P76PON.
        /// </summary>
        public const string K2P76PON = "K2P76PON";

        /// <summary>
        /// K2DMTJ.
        /// </summary>
        public const string K2DMTJ = "K2DMTJ";

        /// <summary>
        /// K2H76FUA.
        /// </summary>
        public const string K2H76FUA = "K2H76FUA";

        /// <summary>
        /// K2H76FUC.
        /// </summary>
        public const string K2H76FUC = "K2H76FUC";

        /// <summary>
        /// K2H76FUD.
        /// </summary>
        public const string K2H76FUD = "K2H76FUD";

        /// <summary>
        /// K2H76FUR.
        /// </summary>
        public const string K2H76FUR = "K2H76FUR";

        /// <summary>
        /// K2H76FUF.
        /// </summary>
        public const string K2H76FUF = "K2H76FUF";

        /// <summary>
        /// K2USER.
        /// </summary>
        public const string K2USER = "K2USER";

        /// <summary>
        /// K2PID.
        /// </summary>
        public const string K2PID = "K2PID";

        /// <summary>
        /// K2JOBN.
        /// </summary>
        public const string K2JOBN = "K2JOBN";

        /// <summary>
        /// K2UPMJ.
        /// </summary>
        public const string K2UPMJ = "K2UPMJ";

        /// <summary>
        /// K2UPMT.
        /// </summary>
        public const string K2UPMT = "K2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P472T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K2HDC", "K2HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("K2CKC", "K2CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("K2P76PON", "K2P76PON", JdeDataType.Numeric),
        new JdeField("K2DMTJ", "K2DMTJ", JdeDataType.Numeric),
        new JdeField("K2H76FUA", "K2H76FUA", JdeDataType.Numeric),
        new JdeField("K2H76FUC", "K2H76FUC", JdeDataType.String, 20),
        new JdeField("K2H76FUD", "K2H76FUD", JdeDataType.Numeric),
        new JdeField("K2H76FUR", "K2H76FUR", JdeDataType.String, 30),
        new JdeField("K2H76FUF", "K2H76FUF", JdeDataType.String, 2),
        new JdeField("K2USER", "K2USER", JdeDataType.String, 20),
        new JdeField("K2PID", "K2PID", JdeDataType.String, 20),
        new JdeField("K2JOBN", "K2JOBN", JdeDataType.String, 20),
        new JdeField("K2UPMJ", "K2UPMJ", JdeDataType.Numeric),
        new JdeField("K2UPMT", "K2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P472T_0", "Primary Key on K2HDC, K2CKC", new[] { "K2HDC", "K2CKC" }, isUnique: true, isPrimaryKey: true)
    };
}
