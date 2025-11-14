using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW39 - .
/// </summary>
public class FCW39 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACC9CMR.
        /// </summary>
        public const string ACC9CMR = "ACC9CMR";

        /// <summary>
        /// ACC9ALIAS.
        /// </summary>
        public const string ACC9ALIAS = "ACC9ALIAS";

        /// <summary>
        /// ACC9PRIO.
        /// </summary>
        public const string ACC9PRIO = "ACC9PRIO";

        /// <summary>
        /// ACC9CATEG.
        /// </summary>
        public const string ACC9CATEG = "ACC9CATEG";
    }

    /// <inheritdoc />
    public override string TableName => "FCW39";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACC9CMR", "ACC9CMR", JdeDataType.String, 20, true, true),
        new JdeField("ACC9ALIAS", "ACC9ALIAS", JdeDataType.String, 20, true, true),
        new JdeField("ACC9PRIO", "ACC9PRIO", JdeDataType.Numeric, null, true, true),
        new JdeField("ACC9CATEG", "ACC9CATEG", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW39_0", "Primary Key on ACC9CMR, ACC9ALIAS, ACC9PRIO, ACC9CATEG", new[] { "ACC9CMR", "ACC9ALIAS", "ACC9PRIO", "ACC9CATEG" }, isUnique: true, isPrimaryKey: true)
    };
}
