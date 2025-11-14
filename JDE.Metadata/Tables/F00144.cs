using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00144 - .
/// </summary>
public class F00144 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L6PTC.
        /// </summary>
        public const string L6PTC = "L6PTC";

        /// <summary>
        /// L6SEQN.
        /// </summary>
        public const string L6SEQN = "L6SEQN";

        /// <summary>
        /// L6DCP.
        /// </summary>
        public const string L6DCP = "L6DCP";

        /// <summary>
        /// L6DDDR.
        /// </summary>
        public const string L6DDDR = "L6DDDR";

        /// <summary>
        /// L6NDDR.
        /// </summary>
        public const string L6NDDR = "L6NDDR";

        /// <summary>
        /// L6PSPL.
        /// </summary>
        public const string L6PSPL = "L6PSPL";
    }

    /// <inheritdoc />
    public override string TableName => "F00144";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L6PTC", "L6PTC", JdeDataType.String, 6, true, true),
        new JdeField("L6SEQN", "L6SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("L6DCP", "L6DCP", JdeDataType.Numeric),
        new JdeField("L6DDDR", "L6DDDR", JdeDataType.String, 10),
        new JdeField("L6NDDR", "L6NDDR", JdeDataType.String, 10),
        new JdeField("L6PSPL", "L6PSPL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00144_0", "Primary Key on L6PTC, L6SEQN", new[] { "L6PTC", "L6SEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00144_5", "Index on L6NDDR", new[] { "L6NDDR" }),
        new JdeIndex("F00144_6", "Index on L6DDDR", new[] { "L6DDDR" })
    };
}
