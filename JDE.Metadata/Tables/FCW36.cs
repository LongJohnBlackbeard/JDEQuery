using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW36 - .
/// </summary>
public class FCW36 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRC9RDRL.
        /// </summary>
        public const string RRC9RDRL = "RRC9RDRL";

        /// <summary>
        /// RRC9RDMD.
        /// </summary>
        public const string RRC9RDMD = "RRC9RDMD";

        /// <summary>
        /// RRC9RDMT.
        /// </summary>
        public const string RRC9RDMT = "RRC9RDMT";

        /// <summary>
        /// RRC9RDPS.
        /// </summary>
        public const string RRC9RDPS = "RRC9RDPS";
    }

    /// <inheritdoc />
    public override string TableName => "FCW36";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRC9RDRL", "RRC9RDRL", JdeDataType.String, 20, true, true),
        new JdeField("RRC9RDMD", "RRC9RDMD", JdeDataType.String, 2),
        new JdeField("RRC9RDMT", "RRC9RDMT", JdeDataType.String, 20),
        new JdeField("RRC9RDPS", "RRC9RDPS", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW36_0", "Primary Key on RRC9RDRL", new[] { "RRC9RDRL" }, isUnique: true, isPrimaryKey: true)
    };
}
