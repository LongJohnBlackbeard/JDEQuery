using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40096 - .
/// </summary>
public class F40096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DQTERM.
        /// </summary>
        public const string DQTERM = "DQTERM";

        /// <summary>
        /// DQPID.
        /// </summary>
        public const string DQPID = "DQPID";

        /// <summary>
        /// DQOUTQ.
        /// </summary>
        public const string DQOUTQ = "DQOUTQ";
    }

    /// <inheritdoc />
    public override string TableName => "F40096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DQTERM", "DQTERM", JdeDataType.String, 20, true, true),
        new JdeField("DQPID", "DQPID", JdeDataType.String, 20, true, true),
        new JdeField("DQOUTQ", "DQOUTQ", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40096_0", "Primary Key on DQTERM, DQPID", new[] { "DQTERM", "DQPID" }, isUnique: true, isPrimaryKey: true)
    };
}
