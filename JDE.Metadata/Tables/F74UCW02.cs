using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UCW02 - .
/// </summary>
public class F74UCW02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVKCO.
        /// </summary>
        public const string CVKCO = "CVKCO";

        /// <summary>
        /// CVDOC.
        /// </summary>
        public const string CVDOC = "CVDOC";

        /// <summary>
        /// CVDCT.
        /// </summary>
        public const string CVDCT = "CVDCT";

        /// <summary>
        /// CVSFX.
        /// </summary>
        public const string CVSFX = "CVSFX";

        /// <summary>
        /// CVSFXE.
        /// </summary>
        public const string CVSFXE = "CVSFXE";

        /// <summary>
        /// CVSPHD.
        /// </summary>
        public const string CVSPHD = "CVSPHD";
    }

    /// <inheritdoc />
    public override string TableName => "F74UCW02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVKCO", "CVKCO", JdeDataType.String, 10, true, true),
        new JdeField("CVDOC", "CVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CVDCT", "CVDCT", JdeDataType.String, 4, true, true),
        new JdeField("CVSFX", "CVSFX", JdeDataType.String, 6, true, true),
        new JdeField("CVSFXE", "CVSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("CVSPHD", "CVSPHD", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UCW02_0", "Primary Key on CVKCO, CVDOC, CVDCT, CVSFX, CVSFXE", new[] { "CVKCO", "CVDOC", "CVDCT", "CVSFX", "CVSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
