using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F095051 - .
/// </summary>
public class F095051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GNCKY2.
        /// </summary>
        public const string GNCKY2 = "GNCKY2";
    }

    /// <inheritdoc />
    public override string TableName => "F095051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GNCKY2", "GNCKY2", JdeDataType.String, 240, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F095051_0", "Primary Key on GNCKY2", new[] { "GNCKY2" }, isUnique: true, isPrimaryKey: true)
    };
}
