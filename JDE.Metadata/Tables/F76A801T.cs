using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A801T - .
/// </summary>
public class F76A801T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V2ADS4.
        /// </summary>
        public const string V2ADS4 = "V2ADS4";

        /// <summary>
        /// V2DOC.
        /// </summary>
        public const string V2DOC = "V2DOC";
    }

    /// <inheritdoc />
    public override string TableName => "F76A801T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V2ADS4", "V2ADS4", JdeDataType.String, 460),
        new JdeField("V2DOC", "V2DOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A801T_0", "Primary Key on V2DOC", new[] { "V2DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
