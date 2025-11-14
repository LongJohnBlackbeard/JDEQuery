using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0456 - .
/// </summary>
public class F76A0456 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// X1AN8.
        /// </summary>
        public const string X1AN8 = "X1AN8";

        /// <summary>
        /// X1A011.
        /// </summary>
        public const string X1A011 = "X1A011";

        /// <summary>
        /// X1DG#.
        /// </summary>
        public const string X1DG_ = "X1DG#";

        /// <summary>
        /// X1DGY.
        /// </summary>
        public const string X1DGY = "X1DGY";

        /// <summary>
        /// X1DGM.
        /// </summary>
        public const string X1DGM = "X1DGM";

        /// <summary>
        /// X1CO.
        /// </summary>
        public const string X1CO = "X1CO";

        /// <summary>
        /// X1ATXA.
        /// </summary>
        public const string X1ATXA = "X1ATXA";

        /// <summary>
        /// X1AG1.
        /// </summary>
        public const string X1AG1 = "X1AG1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0456";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("X1AN8", "X1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("X1A011", "X1A011", JdeDataType.String, 6, true, true),
        new JdeField("X1DG#", "X1DG#", JdeDataType.Numeric, null, true, true),
        new JdeField("X1DGY", "X1DGY", JdeDataType.Numeric, null, true, true),
        new JdeField("X1DGM", "X1DGM", JdeDataType.Numeric, null, true, true),
        new JdeField("X1CO", "X1CO", JdeDataType.String, 10, true, true),
        new JdeField("X1ATXA", "X1ATXA", JdeDataType.Numeric),
        new JdeField("X1AG1", "X1AG1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0456_0", "Primary Key on X1AN8, X1A011, X1DG#, X1DGY, X1DGM, X1CO", new[] { "X1AN8", "X1A011", "X1DG#", "X1DGY", "X1DGM", "X1CO" }, isUnique: true, isPrimaryKey: true)
    };
}
