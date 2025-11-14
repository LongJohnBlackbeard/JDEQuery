using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700002 - .
/// </summary>
public class F700002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L1K74LEDT.
        /// </summary>
        public const string L1K74LEDT = "L1K74LEDT";

        /// <summary>
        /// L1K74NCSR.
        /// </summary>
        public const string L1K74NCSR = "L1K74NCSR";

        /// <summary>
        /// L1K74NLDC.
        /// </summary>
        public const string L1K74NLDC = "L1K74NLDC";

        /// <summary>
        /// L1K74SASR.
        /// </summary>
        public const string L1K74SASR = "L1K74SASR";

        /// <summary>
        /// L1K70GBCI.
        /// </summary>
        public const string L1K70GBCI = "L1K70GBCI";

        /// <summary>
        /// L1K70GCI.
        /// </summary>
        public const string L1K70GCI = "L1K70GCI";
    }

    /// <inheritdoc />
    public override string TableName => "F700002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L1K74LEDT", "L1K74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("L1K74NCSR", "L1K74NCSR", JdeDataType.String, 2),
        new JdeField("L1K74NLDC", "L1K74NLDC", JdeDataType.Numeric),
        new JdeField("L1K74SASR", "L1K74SASR", JdeDataType.String, 2),
        new JdeField("L1K70GBCI", "L1K70GBCI", JdeDataType.String, 2),
        new JdeField("L1K70GCI", "L1K70GCI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700002_0", "Primary Key on L1K74LEDT", new[] { "L1K74LEDT" }, isUnique: true, isPrimaryKey: true)
    };
}
