using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW35 - .
/// </summary>
public class FCW35 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROC9RDTY.
        /// </summary>
        public const string ROC9RDTY = "ROC9RDTY";

        /// <summary>
        /// ROC9RDNM.
        /// </summary>
        public const string ROC9RDNM = "ROC9RDNM";

        /// <summary>
        /// ROC9RDST.
        /// </summary>
        public const string ROC9RDST = "ROC9RDST";

        /// <summary>
        /// ROC9RDEND.
        /// </summary>
        public const string ROC9RDEND = "ROC9RDEND";

        /// <summary>
        /// ROC9RDVL.
        /// </summary>
        public const string ROC9RDVL = "ROC9RDVL";
    }

    /// <inheritdoc />
    public override string TableName => "FCW35";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROC9RDTY", "ROC9RDTY", JdeDataType.String, 2, true, true),
        new JdeField("ROC9RDNM", "ROC9RDNM", JdeDataType.String, 20, true, true),
        new JdeField("ROC9RDST", "ROC9RDST", JdeDataType.Numeric, null, true, true),
        new JdeField("ROC9RDEND", "ROC9RDEND", JdeDataType.Numeric, null, true, true),
        new JdeField("ROC9RDVL", "ROC9RDVL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW35_0", "Primary Key on ROC9RDTY, ROC9RDNM, ROC9RDST, ROC9RDEND", new[] { "ROC9RDTY", "ROC9RDNM", "ROC9RDST", "ROC9RDEND" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW35_2", "Index on ROC9RDTY, ROC9RDNM", new[] { "ROC9RDTY", "ROC9RDNM" })
    };
}
