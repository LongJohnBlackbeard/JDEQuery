using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0012 - .
/// </summary>
public class FD3N0012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCGS5A.
        /// </summary>
        public const string RCGS5A = "RCGS5A";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCGS5A", "RCGS5A", JdeDataType.String, 100, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0012_0", "Primary Key on RCGS5A", new[] { "RCGS5A" }, isUnique: true, isPrimaryKey: true)
    };
}
