using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y415 - .
/// </summary>
public class F74Y415 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVKCO.
        /// </summary>
        public const string RVKCO = "RVKCO";

        /// <summary>
        /// RVDCT.
        /// </summary>
        public const string RVDCT = "RVDCT";

        /// <summary>
        /// RVDOC.
        /// </summary>
        public const string RVDOC = "RVDOC";

        /// <summary>
        /// RVSFX.
        /// </summary>
        public const string RVSFX = "RVSFX";

        /// <summary>
        /// RVSFXE.
        /// </summary>
        public const string RVSFXE = "RVSFXE";

        /// <summary>
        /// RVOKCO.
        /// </summary>
        public const string RVOKCO = "RVOKCO";

        /// <summary>
        /// RVODCT.
        /// </summary>
        public const string RVODCT = "RVODCT";

        /// <summary>
        /// RVODOC.
        /// </summary>
        public const string RVODOC = "RVODOC";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y415";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVKCO", "RVKCO", JdeDataType.String, 10, true, true),
        new JdeField("RVDCT", "RVDCT", JdeDataType.String, 4, true, true),
        new JdeField("RVDOC", "RVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RVSFX", "RVSFX", JdeDataType.String, 6, true, true),
        new JdeField("RVSFXE", "RVSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RVOKCO", "RVOKCO", JdeDataType.String, 10, true, true),
        new JdeField("RVODCT", "RVODCT", JdeDataType.String, 4, true, true),
        new JdeField("RVODOC", "RVODOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y415_0", "Primary Key on RVKCO, RVDCT, RVDOC, RVSFX, RVSFXE, RVOKCO, RVODCT, RVODOC", new[] { "RVKCO", "RVDCT", "RVDOC", "RVSFX", "RVSFXE", "RVOKCO", "RVODCT", "RVODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y415_2", "Index on RVOKCO, RVODCT, RVODOC", new[] { "RVOKCO", "RVODCT", "RVODOC" })
    };
}
