using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069117 - .
/// </summary>
public class F069117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YBPDBA.
        /// </summary>
        public const string YBPDBA = "YBPDBA";

        /// <summary>
        /// YBPTAX.
        /// </summary>
        public const string YBPTAX = "YBPTAX";

        /// <summary>
        /// YBTARA.
        /// </summary>
        public const string YBTARA = "YBTARA";
    }

    /// <inheritdoc />
    public override string TableName => "F069117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YBPDBA", "YBPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YBPTAX", "YBPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YBTARA", "YBTARA", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069117_0", "Primary Key on YBPDBA, YBPTAX, YBTARA", new[] { "YBPDBA", "YBPTAX", "YBTARA" }, isUnique: true, isPrimaryKey: true)
    };
}
