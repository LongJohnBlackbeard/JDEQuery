using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0480 - .
/// </summary>
public class F74R0480 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPSFXE.
        /// </summary>
        public const string RPSFXE = "RPSFXE";

        /// <summary>
        /// RPEXR1.
        /// </summary>
        public const string RPEXR1 = "RPEXR1";

        /// <summary>
        /// RPITM.
        /// </summary>
        public const string RPITM = "RPITM";

        /// <summary>
        /// RPTXA1.
        /// </summary>
        public const string RPTXA1 = "RPTXA1";

        /// <summary>
        /// RPAG.
        /// </summary>
        public const string RPAG = "RPAG";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0480";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPSFXE", "RPSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RPEXR1", "RPEXR1", JdeDataType.String, 4),
        new JdeField("RPITM", "RPITM", JdeDataType.Numeric),
        new JdeField("RPTXA1", "RPTXA1", JdeDataType.String, 20),
        new JdeField("RPAG", "RPAG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0480_0", "Primary Key on RPKCO, RPDOC, RPDCT, RPSFX, RPSFXE", new[] { "RPKCO", "RPDOC", "RPDCT", "RPSFX", "RPSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R0480_2", "Index on RPKCO, RPDOC, RPDCT, RPAG", new[] { "RPKCO", "RPDOC", "RPDCT", "RPAG" })
    };
}
