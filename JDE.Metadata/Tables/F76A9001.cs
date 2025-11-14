using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A9001 - .
/// </summary>
public class F76A9001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBVJRG.
        /// </summary>
        public const string IBVJRG = "IBVJRG";
    }

    /// <inheritdoc />
    public override string TableName => "F76A9001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBVJRG", "IBVJRG", JdeDataType.String, 180, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A9001_0", "Primary Key on IBVJRG", new[] { "IBVJRG" }, isUnique: true, isPrimaryKey: true)
    };
}
