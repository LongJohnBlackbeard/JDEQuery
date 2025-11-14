using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08345 - .
/// </summary>
public class F08345 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B3PLAN.
        /// </summary>
        public const string B3PLAN = "B3PLAN";

        /// <summary>
        /// B3PDBA.
        /// </summary>
        public const string B3PDBA = "B3PDBA";
    }

    /// <inheritdoc />
    public override string TableName => "F08345";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B3PLAN", "B3PLAN", JdeDataType.String, 16, true, true),
        new JdeField("B3PDBA", "B3PDBA", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08345_0", "Primary Key on B3PLAN, B3PDBA", new[] { "B3PLAN", "B3PDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
