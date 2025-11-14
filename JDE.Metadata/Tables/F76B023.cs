using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B023 - .
/// </summary>
public class F76B023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRBCLF.
        /// </summary>
        public const string BRBCLF = "BRBCLF";

        /// <summary>
        /// BRB76CEST.
        /// </summary>
        public const string BRB76CEST = "BRB76CEST";
    }

    /// <inheritdoc />
    public override string TableName => "F76B023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRBCLF", "BRBCLF", JdeDataType.String, 20, true, true),
        new JdeField("BRB76CEST", "BRB76CEST", JdeDataType.String, 18)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B023_0", "Primary Key on BRBCLF", new[] { "BRBCLF" }, isUnique: true, isPrimaryKey: true)
    };
}
