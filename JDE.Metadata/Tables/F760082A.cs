using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760082A - .
/// </summary>
public class F760082A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V7ADS3.
        /// </summary>
        public const string V7ADS3 = "V7ADS3";
    }

    /// <inheritdoc />
    public override string TableName => "F760082A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V7ADS3", "V7ADS3", JdeDataType.String, 160, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760082A_0", "Primary Key on V7ADS3", new[] { "V7ADS3" }, isUnique: true, isPrimaryKey: true)
    };
}
