using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00141 - .
/// </summary>
public class F00141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L3PTC.
        /// </summary>
        public const string L3PTC = "L3PTC";

        /// <summary>
        /// L3PTD.
        /// </summary>
        public const string L3PTD = "L3PTD";

        /// <summary>
        /// L3DCP.
        /// </summary>
        public const string L3DCP = "L3DCP";

        /// <summary>
        /// L3DDDR.
        /// </summary>
        public const string L3DDDR = "L3DDDR";

        /// <summary>
        /// L3NDDR.
        /// </summary>
        public const string L3NDDR = "L3NDDR";
    }

    /// <inheritdoc />
    public override string TableName => "F00141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L3PTC", "L3PTC", JdeDataType.String, 6, true, true),
        new JdeField("L3PTD", "L3PTD", JdeDataType.String, 60),
        new JdeField("L3DCP", "L3DCP", JdeDataType.Numeric),
        new JdeField("L3DDDR", "L3DDDR", JdeDataType.String, 10),
        new JdeField("L3NDDR", "L3NDDR", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00141_0", "Primary Key on L3PTC", new[] { "L3PTC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00141_4", "Index on L3NDDR", new[] { "L3NDDR" }),
        new JdeIndex("F00141_5", "Index on L3DDDR", new[] { "L3DDDR" })
    };
}
