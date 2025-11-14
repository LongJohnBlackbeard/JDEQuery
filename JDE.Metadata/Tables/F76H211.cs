using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H211 - .
/// </summary>
public class F76H211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SLKCOO.
        /// </summary>
        public const string SLKCOO = "SLKCOO";

        /// <summary>
        /// SLDCTO.
        /// </summary>
        public const string SLDCTO = "SLDCTO";

        /// <summary>
        /// SLDOCO.
        /// </summary>
        public const string SLDOCO = "SLDOCO";

        /// <summary>
        /// SLLNID.
        /// </summary>
        public const string SLLNID = "SLLNID";

        /// <summary>
        /// SLKCO.
        /// </summary>
        public const string SLKCO = "SLKCO";

        /// <summary>
        /// SLDCT.
        /// </summary>
        public const string SLDCT = "SLDCT";

        /// <summary>
        /// SLDOC.
        /// </summary>
        public const string SLDOC = "SLDOC";
    }

    /// <inheritdoc />
    public override string TableName => "F76H211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SLKCOO", "SLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SLDCTO", "SLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SLDOCO", "SLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SLLNID", "SLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SLKCO", "SLKCO", JdeDataType.String, 10, true, true),
        new JdeField("SLDCT", "SLDCT", JdeDataType.String, 4, true, true),
        new JdeField("SLDOC", "SLDOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H211_0", "Primary Key on SLKCOO, SLDCTO, SLDOCO, SLLNID, SLKCO, SLDCT, SLDOC", new[] { "SLKCOO", "SLDCTO", "SLDOCO", "SLLNID", "SLKCO", "SLDCT", "SLDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H211_2", "Index on SLKCO, SLDCT, SLDOC", new[] { "SLKCO", "SLDCT", "SLDOC" })
    };
}
