using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W201 - .
/// </summary>
public class F74W201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K1DAFN.
        /// </summary>
        public const string K1DAFN = "K1DAFN";

        /// <summary>
        /// K1PYIN.
        /// </summary>
        public const string K1PYIN = "K1PYIN";

        /// <summary>
        /// K1DEJ.
        /// </summary>
        public const string K1DEJ = "K1DEJ";

        /// <summary>
        /// K1TENT.
        /// </summary>
        public const string K1TENT = "K1TENT";

        /// <summary>
        /// K1DAFE.
        /// </summary>
        public const string K1DAFE = "K1DAFE";

        /// <summary>
        /// K1PID.
        /// </summary>
        public const string K1PID = "K1PID";

        /// <summary>
        /// K1USER.
        /// </summary>
        public const string K1USER = "K1USER";

        /// <summary>
        /// K1UPMJ.
        /// </summary>
        public const string K1UPMJ = "K1UPMJ";

        /// <summary>
        /// K1UPMT.
        /// </summary>
        public const string K1UPMT = "K1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74W201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K1DAFN", "K1DAFN", JdeDataType.String, 60, true, true),
        new JdeField("K1PYIN", "K1PYIN", JdeDataType.String, 2),
        new JdeField("K1DEJ", "K1DEJ", JdeDataType.Numeric),
        new JdeField("K1TENT", "K1TENT", JdeDataType.Numeric),
        new JdeField("K1DAFE", "K1DAFE", JdeDataType.String, 2),
        new JdeField("K1PID", "K1PID", JdeDataType.String, 20),
        new JdeField("K1USER", "K1USER", JdeDataType.String, 20),
        new JdeField("K1UPMJ", "K1UPMJ", JdeDataType.Numeric),
        new JdeField("K1UPMT", "K1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W201_0", "Primary Key on K1DAFN", new[] { "K1DAFN" }, isUnique: true, isPrimaryKey: true)
    };
}
