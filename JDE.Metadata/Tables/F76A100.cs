using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A100 - .
/// </summary>
public class F76A100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGCO.
        /// </summary>
        public const string RGCO = "RGCO";

        /// <summary>
        /// RGFLGA.
        /// </summary>
        public const string RGFLGA = "RGFLGA";
    }

    /// <inheritdoc />
    public override string TableName => "F76A100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGCO", "RGCO", JdeDataType.String, 10, true, true),
        new JdeField("RGFLGA", "RGFLGA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A100_0", "Primary Key on RGCO", new[] { "RGCO" }, isUnique: true, isPrimaryKey: true)
    };
}
