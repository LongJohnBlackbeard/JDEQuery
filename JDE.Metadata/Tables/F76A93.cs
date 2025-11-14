using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A93 - .
/// </summary>
public class F76A93 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R3ASMI.
        /// </summary>
        public const string R3ASMI = "R3ASMI";
    }

    /// <inheritdoc />
    public override string TableName => "F76A93";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R3ASMI", "R3ASMI", JdeDataType.String, 120, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A93_0", "Primary Key on R3ASMI", new[] { "R3ASMI" }, isUnique: true, isPrimaryKey: true)
    };
}
