using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06271 - .
/// </summary>
public class F06271 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JQVERS.
        /// </summary>
        public const string JQVERS = "JQVERS";

        /// <summary>
        /// JQPID.
        /// </summary>
        public const string JQPID = "JQPID";

        /// <summary>
        /// JQDTAI.
        /// </summary>
        public const string JQDTAI = "JQDTAI";

        /// <summary>
        /// JQPHSD.
        /// </summary>
        public const string JQPHSD = "JQPHSD";
    }

    /// <inheritdoc />
    public override string TableName => "F06271";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JQVERS", "JQVERS", JdeDataType.String, 20, true, true),
        new JdeField("JQPID", "JQPID", JdeDataType.String, 20, true, true),
        new JdeField("JQDTAI", "JQDTAI", JdeDataType.String, 20, true, true),
        new JdeField("JQPHSD", "JQPHSD", JdeDataType.String, 60, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06271_0", "Primary Key on JQVERS, JQPID, JQDTAI, JQPHSD", new[] { "JQVERS", "JQPID", "JQDTAI", "JQPHSD" }, isUnique: true, isPrimaryKey: true)
    };
}
