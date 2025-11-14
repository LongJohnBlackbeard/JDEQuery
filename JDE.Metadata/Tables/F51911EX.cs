using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51911EX - .
/// </summary>
public class F51911EX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GKDCT.
        /// </summary>
        public const string GKDCT = "GKDCT";

        /// <summary>
        /// GKDOC.
        /// </summary>
        public const string GKDOC = "GKDOC";

        /// <summary>
        /// GKCO.
        /// </summary>
        public const string GKCO = "GKCO";

        /// <summary>
        /// GKDGJ.
        /// </summary>
        public const string GKDGJ = "GKDGJ";

        /// <summary>
        /// GKJELN.
        /// </summary>
        public const string GKJELN = "GKJELN";

        /// <summary>
        /// GKEXA.
        /// </summary>
        public const string GKEXA = "GKEXA";
    }

    /// <inheritdoc />
    public override string TableName => "F51911EX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GKDCT", "GKDCT", JdeDataType.String, 4, true, true),
        new JdeField("GKDOC", "GKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GKCO", "GKCO", JdeDataType.String, 10, true, true),
        new JdeField("GKDGJ", "GKDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GKJELN", "GKJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("GKEXA", "GKEXA", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51911EX_0", "Primary Key on GKDCT, GKDOC, GKCO, GKDGJ, GKJELN", new[] { "GKDCT", "GKDOC", "GKCO", "GKDGJ", "GKJELN" }, isUnique: true, isPrimaryKey: true)
    };
}
