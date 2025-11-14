using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A44 - .
/// </summary>
public class F76A44 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPACAP.
        /// </summary>
        public const string VPACAP = "VPACAP";
    }

    /// <inheritdoc />
    public override string TableName => "F76A44";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPACAP", "VPACAP", JdeDataType.String, 252, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A44_0", "Primary Key on VPACAP", new[] { "VPACAP" }, isUnique: true, isPrimaryKey: true)
    };
}
