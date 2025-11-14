using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A47 - .
/// </summary>
public class F76A47 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REACA2.
        /// </summary>
        public const string REACA2 = "REACA2";
    }

    /// <inheritdoc />
    public override string TableName => "F76A47";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REACA2", "REACA2", JdeDataType.String, 274, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A47_0", "Primary Key on REACA2", new[] { "REACA2" }, isUnique: true, isPrimaryKey: true)
    };
}
