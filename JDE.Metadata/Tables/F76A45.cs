using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A45 - .
/// </summary>
public class F76A45 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRACAP.
        /// </summary>
        public const string PRACAP = "PRACAP";
    }

    /// <inheritdoc />
    public override string TableName => "F76A45";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRACAP", "PRACAP", JdeDataType.String, 252, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A45_0", "Primary Key on PRACAP", new[] { "PRACAP" }, isUnique: true, isPrimaryKey: true)
    };
}
