using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7691SBA - .
/// </summary>
public class F7691SBA : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V3ADS3.
        /// </summary>
        public const string V3ADS3 = "V3ADS3";
    }

    /// <inheritdoc />
    public override string TableName => "F7691SBA";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V3ADS3", "V3ADS3", JdeDataType.String, 160, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7691SBA_0", "Primary Key on V3ADS3", new[] { "V3ADS3" }, isUnique: true, isPrimaryKey: true)
    };
}
