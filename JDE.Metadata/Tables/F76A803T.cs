using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A803T - .
/// </summary>
public class F76A803T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V4ADS1.
        /// </summary>
        public const string V4ADS1 = "V4ADS1";

        /// <summary>
        /// V4DOC.
        /// </summary>
        public const string V4DOC = "V4DOC";
    }

    /// <inheritdoc />
    public override string TableName => "F76A803T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V4ADS1", "V4ADS1", JdeDataType.String, 1000),
        new JdeField("V4DOC", "V4DOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A803T_0", "Primary Key on V4DOC", new[] { "V4DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
