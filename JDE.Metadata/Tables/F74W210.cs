using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W210 - .
/// </summary>
public class F74W210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K5HDC.
        /// </summary>
        public const string K5HDC = "K5HDC";

        /// <summary>
        /// K5CKC.
        /// </summary>
        public const string K5CKC = "K5CKC";

        /// <summary>
        /// K5DEJ.
        /// </summary>
        public const string K5DEJ = "K5DEJ";

        /// <summary>
        /// K5TENT.
        /// </summary>
        public const string K5TENT = "K5TENT";

        /// <summary>
        /// K5CRR.
        /// </summary>
        public const string K5CRR = "K5CRR";

        /// <summary>
        /// K5USER.
        /// </summary>
        public const string K5USER = "K5USER";

        /// <summary>
        /// K5PID.
        /// </summary>
        public const string K5PID = "K5PID";

        /// <summary>
        /// K5CTID.
        /// </summary>
        public const string K5CTID = "K5CTID";

        /// <summary>
        /// K5UPMJ.
        /// </summary>
        public const string K5UPMJ = "K5UPMJ";

        /// <summary>
        /// K5UPMT.
        /// </summary>
        public const string K5UPMT = "K5UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74W210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K5HDC", "K5HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("K5CKC", "K5CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("K5DEJ", "K5DEJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K5TENT", "K5TENT", JdeDataType.Numeric, null, true, true),
        new JdeField("K5CRR", "K5CRR", JdeDataType.Numeric),
        new JdeField("K5USER", "K5USER", JdeDataType.String, 20),
        new JdeField("K5PID", "K5PID", JdeDataType.String, 20),
        new JdeField("K5CTID", "K5CTID", JdeDataType.String, 30),
        new JdeField("K5UPMJ", "K5UPMJ", JdeDataType.Numeric),
        new JdeField("K5UPMT", "K5UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W210_0", "Primary Key on K5HDC, K5CKC, K5DEJ, K5TENT", new[] { "K5HDC", "K5CKC", "K5DEJ", "K5TENT" }, isUnique: true, isPrimaryKey: true)
    };
}
