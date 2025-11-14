using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A43 - .
/// </summary>
public class F76A43 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFCKY2.
        /// </summary>
        public const string PFCKY2 = "PFCKY2";
    }

    /// <inheritdoc />
    public override string TableName => "F76A43";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFCKY2", "PFCKY2", JdeDataType.String, 240, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A43_0", "Primary Key on PFCKY2", new[] { "PFCKY2" }, isUnique: true, isPrimaryKey: true)
    };
}
