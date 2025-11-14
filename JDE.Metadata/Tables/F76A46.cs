using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A46 - .
/// </summary>
public class F76A46 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPACA1.
        /// </summary>
        public const string VPACA1 = "VPACA1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A46";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPACA1", "VPACA1", JdeDataType.String, 254, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A46_0", "Primary Key on VPACA1", new[] { "VPACA1" }, isUnique: true, isPrimaryKey: true)
    };
}
