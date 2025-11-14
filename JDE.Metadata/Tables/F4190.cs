using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4190 - .
/// </summary>
public class F4190 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGGRPR.
        /// </summary>
        public const string IGGRPR = "IGGRPR";

        /// <summary>
        /// IGGRCH.
        /// </summary>
        public const string IGGRCH = "IGGRCH";
    }

    /// <inheritdoc />
    public override string TableName => "F4190";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGGRPR", "IGGRPR", JdeDataType.Numeric, null, true, true),
        new JdeField("IGGRCH", "IGGRCH", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4190_0", "Primary Key on IGGRPR, IGGRCH", new[] { "IGGRPR", "IGGRCH" }, isUnique: true, isPrimaryKey: true)
    };
}
