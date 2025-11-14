using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083201 - .
/// </summary>
public class F083201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B1PLAN.
        /// </summary>
        public const string B1PLAN = "B1PLAN";

        /// <summary>
        /// B1LIN.
        /// </summary>
        public const string B1LIN = "B1LIN";

        /// <summary>
        /// B1DS80.
        /// </summary>
        public const string B1DS80 = "B1DS80";
    }

    /// <inheritdoc />
    public override string TableName => "F083201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B1PLAN", "B1PLAN", JdeDataType.String, 16, true, true),
        new JdeField("B1LIN", "B1LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("B1DS80", "B1DS80", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083201_0", "Primary Key on B1PLAN, B1LIN", new[] { "B1PLAN", "B1LIN" }, isUnique: true, isPrimaryKey: true)
    };
}
