using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C576 - .
/// </summary>
public class F76C576 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLJELN.
        /// </summary>
        public const string PLJELN = "PLJELN";

        /// <summary>
        /// PLDL.
        /// </summary>
        public const string PLDL = "PLDL";
    }

    /// <inheritdoc />
    public override string TableName => "F76C576";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLJELN", "PLJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("PLDL", "PLDL", JdeDataType.String, 600)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C576_0", "Primary Key on PLJELN", new[] { "PLJELN" }, isUnique: true, isPrimaryKey: true)
    };
}
