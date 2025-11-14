using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01132 - .
/// </summary>
public class F01132 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CYSERK.
        /// </summary>
        public const string CYSERK = "CYSERK";

        /// <summary>
        /// CYLIN.
        /// </summary>
        public const string CYLIN = "CYLIN";

        /// <summary>
        /// CYWTXT.
        /// </summary>
        public const string CYWTXT = "CYWTXT";

        /// <summary>
        /// CYCMDF.
        /// </summary>
        public const string CYCMDF = "CYCMDF";

        /// <summary>
        /// CYUPMJ.
        /// </summary>
        public const string CYUPMJ = "CYUPMJ";

        /// <summary>
        /// CYENTT.
        /// </summary>
        public const string CYENTT = "CYENTT";
    }

    /// <inheritdoc />
    public override string TableName => "F01132";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CYSERK", "CYSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("CYLIN", "CYLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("CYWTXT", "CYWTXT", JdeDataType.String, 160),
        new JdeField("CYCMDF", "CYCMDF", JdeDataType.String, 2, true, true),
        new JdeField("CYUPMJ", "CYUPMJ", JdeDataType.Numeric),
        new JdeField("CYENTT", "CYENTT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01132_0", "Primary Key on CYSERK, CYCMDF, CYLIN", new[] { "CYSERK", "CYCMDF", "CYLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
