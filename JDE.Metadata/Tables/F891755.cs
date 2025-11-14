using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F891755 - .
/// </summary>
public class F891755 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOCRMSOID.
        /// </summary>
        public const string SOCRMSOID = "SOCRMSOID";

        /// <summary>
        /// SODOCO.
        /// </summary>
        public const string SODOCO = "SODOCO";
    }

    /// <inheritdoc />
    public override string TableName => "F891755";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOCRMSOID", "SOCRMSOID", JdeDataType.Numeric, null, true, true),
        new JdeField("SODOCO", "SODOCO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F891755_0", "Primary Key on SOCRMSOID", new[] { "SOCRMSOID" }, isUnique: true, isPrimaryKey: true)
    };
}
