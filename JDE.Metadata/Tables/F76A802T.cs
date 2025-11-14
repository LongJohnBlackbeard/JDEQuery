using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A802T - .
/// </summary>
public class F76A802T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V3ADS5.
        /// </summary>
        public const string V3ADS5 = "V3ADS5";

        /// <summary>
        /// V3DOC.
        /// </summary>
        public const string V3DOC = "V3DOC";
    }

    /// <inheritdoc />
    public override string TableName => "F76A802T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V3ADS5", "V3ADS5", JdeDataType.String, 260),
        new JdeField("V3DOC", "V3DOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A802T_0", "Primary Key on V3DOC", new[] { "V3DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
