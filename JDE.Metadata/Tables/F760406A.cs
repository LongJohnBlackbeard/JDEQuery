using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760406A - .
/// </summary>
public class F760406A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K6AN8.
        /// </summary>
        public const string K6AN8 = "K6AN8";

        /// <summary>
        /// K6A004.
        /// </summary>
        public const string K6A004 = "K6A004";

        /// <summary>
        /// K6DG#.
        /// </summary>
        public const string K6DG_ = "K6DG#";

        /// <summary>
        /// K6DGY.
        /// </summary>
        public const string K6DGY = "K6DGY";

        /// <summary>
        /// K6DGM.
        /// </summary>
        public const string K6DGM = "K6DGM";

        /// <summary>
        /// K6CO.
        /// </summary>
        public const string K6CO = "K6CO";

        /// <summary>
        /// K6ATXA.
        /// </summary>
        public const string K6ATXA = "K6ATXA";

        /// <summary>
        /// K6AG1.
        /// </summary>
        public const string K6AG1 = "K6AG1";
    }

    /// <inheritdoc />
    public override string TableName => "F760406A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K6AN8", "K6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("K6A004", "K6A004", JdeDataType.String, 6, true, true),
        new JdeField("K6DG#", "K6DG#", JdeDataType.Numeric, null, true, true),
        new JdeField("K6DGY", "K6DGY", JdeDataType.Numeric, null, true, true),
        new JdeField("K6DGM", "K6DGM", JdeDataType.Numeric, null, true, true),
        new JdeField("K6CO", "K6CO", JdeDataType.String, 10, true, true),
        new JdeField("K6ATXA", "K6ATXA", JdeDataType.Numeric),
        new JdeField("K6AG1", "K6AG1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760406A_0", "Primary Key on K6AN8, K6A004, K6DG#, K6DGY, K6DGM, K6CO", new[] { "K6AN8", "K6A004", "K6DG#", "K6DGY", "K6DGM", "K6CO" }, isUnique: true, isPrimaryKey: true)
    };
}
