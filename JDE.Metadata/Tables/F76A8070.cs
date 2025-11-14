using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8070 - .
/// </summary>
public class F76A8070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K7AN8.
        /// </summary>
        public const string K7AN8 = "K7AN8";

        /// <summary>
        /// K7A004.
        /// </summary>
        public const string K7A004 = "K7A004";

        /// <summary>
        /// K7DG#.
        /// </summary>
        public const string K7DG_ = "K7DG#";

        /// <summary>
        /// K7DGY.
        /// </summary>
        public const string K7DGY = "K7DGY";

        /// <summary>
        /// K7DGM.
        /// </summary>
        public const string K7DGM = "K7DGM";

        /// <summary>
        /// K7CO.
        /// </summary>
        public const string K7CO = "K7CO";

        /// <summary>
        /// K7ATXA.
        /// </summary>
        public const string K7ATXA = "K7ATXA";

        /// <summary>
        /// K7AG1.
        /// </summary>
        public const string K7AG1 = "K7AG1";

        /// <summary>
        /// K7USER.
        /// </summary>
        public const string K7USER = "K7USER";

        /// <summary>
        /// K7PID.
        /// </summary>
        public const string K7PID = "K7PID";

        /// <summary>
        /// K7UPMJ.
        /// </summary>
        public const string K7UPMJ = "K7UPMJ";

        /// <summary>
        /// K7UPMT.
        /// </summary>
        public const string K7UPMT = "K7UPMT";

        /// <summary>
        /// K7JOBN.
        /// </summary>
        public const string K7JOBN = "K7JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K7AN8", "K7AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("K7A004", "K7A004", JdeDataType.String, 6, true, true),
        new JdeField("K7DG#", "K7DG#", JdeDataType.Numeric, null, true, true),
        new JdeField("K7DGY", "K7DGY", JdeDataType.Numeric, null, true, true),
        new JdeField("K7DGM", "K7DGM", JdeDataType.Numeric, null, true, true),
        new JdeField("K7CO", "K7CO", JdeDataType.String, 10, true, true),
        new JdeField("K7ATXA", "K7ATXA", JdeDataType.Numeric),
        new JdeField("K7AG1", "K7AG1", JdeDataType.Numeric),
        new JdeField("K7USER", "K7USER", JdeDataType.String, 20),
        new JdeField("K7PID", "K7PID", JdeDataType.String, 20),
        new JdeField("K7UPMJ", "K7UPMJ", JdeDataType.Numeric),
        new JdeField("K7UPMT", "K7UPMT", JdeDataType.Numeric),
        new JdeField("K7JOBN", "K7JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8070_0", "Primary Key on K7AN8, K7A004, K7DG#, K7DGY, K7DGM, K7CO", new[] { "K7AN8", "K7A004", "K7DG#", "K7DGY", "K7DGM", "K7CO" }, isUnique: true, isPrimaryKey: true)
    };
}
