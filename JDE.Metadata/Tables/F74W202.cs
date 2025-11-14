using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W202 - .
/// </summary>
public class F74W202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K2DAFN.
        /// </summary>
        public const string K2DAFN = "K2DAFN";

        /// <summary>
        /// K2NXTC.
        /// </summary>
        public const string K2NXTC = "K2NXTC";

        /// <summary>
        /// K2YST.
        /// </summary>
        public const string K2YST = "K2YST";

        /// <summary>
        /// K2HDC.
        /// </summary>
        public const string K2HDC = "K2HDC";

        /// <summary>
        /// K2CKC.
        /// </summary>
        public const string K2CKC = "K2CKC";

        /// <summary>
        /// K2DAER.
        /// </summary>
        public const string K2DAER = "K2DAER";

        /// <summary>
        /// K2PID.
        /// </summary>
        public const string K2PID = "K2PID";

        /// <summary>
        /// K2USER.
        /// </summary>
        public const string K2USER = "K2USER";

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
    public override string TableName => "F74W202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K2DAFN", "K2DAFN", JdeDataType.String, 60, true, true),
        new JdeField("K2NXTC", "K2NXTC", JdeDataType.Numeric, null, true, true),
        new JdeField("K2YST", "K2YST", JdeDataType.String, 2),
        new JdeField("K2HDC", "K2HDC", JdeDataType.Numeric),
        new JdeField("K2CKC", "K2CKC", JdeDataType.Numeric),
        new JdeField("K2DAER", "K2DAER", JdeDataType.String, 4),
        new JdeField("K2PID", "K2PID", JdeDataType.String, 20),
        new JdeField("K2USER", "K2USER", JdeDataType.String, 20),
        new JdeField("K2UPMJ", "K2UPMJ", JdeDataType.Numeric),
        new JdeField("K2UPMT", "K2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W202_0", "Primary Key on K2DAFN, K2NXTC", new[] { "K2DAFN", "K2NXTC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74W202_2", "Index on K2DAFN, K2HDC, K2CKC", new[] { "K2DAFN", "K2HDC", "K2CKC" }),
        new JdeIndex("F74W202_3", "Index on K2HDC, K2CKC", new[] { "K2HDC", "K2CKC" })
    };
}
