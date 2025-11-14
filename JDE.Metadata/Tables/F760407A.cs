using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760407A - .
/// </summary>
public class F760407A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K4CO.
        /// </summary>
        public const string K4CO = "K4CO";

        /// <summary>
        /// K4A009.
        /// </summary>
        public const string K4A009 = "K4A009";

        /// <summary>
        /// K4ATN.
        /// </summary>
        public const string K4ATN = "K4ATN";

        /// <summary>
        /// K4ATCA.
        /// </summary>
        public const string K4ATCA = "K4ATCA";

        /// <summary>
        /// K4N001.
        /// </summary>
        public const string K4N001 = "K4N001";

        /// <summary>
        /// K4TX2.
        /// </summary>
        public const string K4TX2 = "K4TX2";
    }

    /// <inheritdoc />
    public override string TableName => "F760407A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K4CO", "K4CO", JdeDataType.String, 10, true, true),
        new JdeField("K4A009", "K4A009", JdeDataType.String, 6, true, true),
        new JdeField("K4ATN", "K4ATN", JdeDataType.String, 2),
        new JdeField("K4ATCA", "K4ATCA", JdeDataType.String, 2),
        new JdeField("K4N001", "K4N001", JdeDataType.Numeric),
        new JdeField("K4TX2", "K4TX2", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760407A_0", "Primary Key on K4CO, K4A009", new[] { "K4CO", "K4A009" }, isUnique: true, isPrimaryKey: true)
    };
}
