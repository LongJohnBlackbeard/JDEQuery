using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4582 - .
/// </summary>
public class F76V4582 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRKCO.
        /// </summary>
        public const string DRKCO = "DRKCO";

        /// <summary>
        /// DRDCT.
        /// </summary>
        public const string DRDCT = "DRDCT";

        /// <summary>
        /// DRDOC.
        /// </summary>
        public const string DRDOC = "DRDOC";

        /// <summary>
        /// DRSFX.
        /// </summary>
        public const string DRSFX = "DRSFX";

        /// <summary>
        /// DRSFXE.
        /// </summary>
        public const string DRSFXE = "DRSFXE";

        /// <summary>
        /// DRAUPD.
        /// </summary>
        public const string DRAUPD = "DRAUPD";

        /// <summary>
        /// DRDGL.
        /// </summary>
        public const string DRDGL = "DRDGL";

        /// <summary>
        /// DRIRBI.
        /// </summary>
        public const string DRIRBI = "DRIRBI";

        /// <summary>
        /// DRIRBF.
        /// </summary>
        public const string DRIRBF = "DRIRBF";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4582";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRKCO", "DRKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRDCT", "DRDCT", JdeDataType.String, 4, true, true),
        new JdeField("DRDOC", "DRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DRSFX", "DRSFX", JdeDataType.String, 6, true, true),
        new JdeField("DRSFXE", "DRSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("DRAUPD", "DRAUPD", JdeDataType.String, 2, true, true),
        new JdeField("DRDGL", "DRDGL", JdeDataType.Numeric),
        new JdeField("DRIRBI", "DRIRBI", JdeDataType.Numeric),
        new JdeField("DRIRBF", "DRIRBF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4582_0", "Primary Key on DRKCO, DRDCT, DRDOC, DRSFX, DRSFXE, DRAUPD", new[] { "DRKCO", "DRDCT", "DRDOC", "DRSFX", "DRSFXE", "DRAUPD" }, isUnique: true, isPrimaryKey: true)
    };
}
