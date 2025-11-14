using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9021 - .
/// </summary>
public class F74R9021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRR74REPN.
        /// </summary>
        public const string DRR74REPN = "DRR74REPN";

        /// <summary>
        /// DRR74SECT.
        /// </summary>
        public const string DRR74SECT = "DRR74SECT";

        /// <summary>
        /// DRR74RROW.
        /// </summary>
        public const string DRR74RROW = "DRR74RROW";

        /// <summary>
        /// DRR74CODT.
        /// </summary>
        public const string DRR74CODT = "DRR74CODT";

        /// <summary>
        /// DRR74CODE.
        /// </summary>
        public const string DRR74CODE = "DRR74CODE";

        /// <summary>
        /// DRD240.
        /// </summary>
        public const string DRD240 = "DRD240";

        /// <summary>
        /// DRR74VISI.
        /// </summary>
        public const string DRR74VISI = "DRR74VISI";

        /// <summary>
        /// DRR74FACT.
        /// </summary>
        public const string DRR74FACT = "DRR74FACT";

        /// <summary>
        /// DRR74CORR.
        /// </summary>
        public const string DRR74CORR = "DRR74CORR";

        /// <summary>
        /// DRURAB.
        /// </summary>
        public const string DRURAB = "DRURAB";

        /// <summary>
        /// DRURAT.
        /// </summary>
        public const string DRURAT = "DRURAT";

        /// <summary>
        /// DRURDT.
        /// </summary>
        public const string DRURDT = "DRURDT";

        /// <summary>
        /// DRURCD.
        /// </summary>
        public const string DRURCD = "DRURCD";

        /// <summary>
        /// DRURRF.
        /// </summary>
        public const string DRURRF = "DRURRF";

        /// <summary>
        /// DRUSER.
        /// </summary>
        public const string DRUSER = "DRUSER";

        /// <summary>
        /// DRPID.
        /// </summary>
        public const string DRPID = "DRPID";

        /// <summary>
        /// DRJOBN.
        /// </summary>
        public const string DRJOBN = "DRJOBN";

        /// <summary>
        /// DRUPMJ.
        /// </summary>
        public const string DRUPMJ = "DRUPMJ";

        /// <summary>
        /// DRUPMT.
        /// </summary>
        public const string DRUPMT = "DRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRR74REPN", "DRR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("DRR74SECT", "DRR74SECT", JdeDataType.String, 4, true, true),
        new JdeField("DRR74RROW", "DRR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("DRR74CODT", "DRR74CODT", JdeDataType.String, 6),
        new JdeField("DRR74CODE", "DRR74CODE", JdeDataType.String, 8),
        new JdeField("DRD240", "DRD240", JdeDataType.String, 480),
        new JdeField("DRR74VISI", "DRR74VISI", JdeDataType.String, 2),
        new JdeField("DRR74FACT", "DRR74FACT", JdeDataType.String, 4),
        new JdeField("DRR74CORR", "DRR74CORR", JdeDataType.String, 2),
        new JdeField("DRURAB", "DRURAB", JdeDataType.Numeric),
        new JdeField("DRURAT", "DRURAT", JdeDataType.Numeric),
        new JdeField("DRURDT", "DRURDT", JdeDataType.Numeric),
        new JdeField("DRURCD", "DRURCD", JdeDataType.String, 4),
        new JdeField("DRURRF", "DRURRF", JdeDataType.String, 30),
        new JdeField("DRUSER", "DRUSER", JdeDataType.String, 20),
        new JdeField("DRPID", "DRPID", JdeDataType.String, 20),
        new JdeField("DRJOBN", "DRJOBN", JdeDataType.String, 20),
        new JdeField("DRUPMJ", "DRUPMJ", JdeDataType.Numeric),
        new JdeField("DRUPMT", "DRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9021_0", "Primary Key on DRR74REPN, DRR74SECT, DRR74RROW", new[] { "DRR74REPN", "DRR74SECT", "DRR74RROW" }, isUnique: true, isPrimaryKey: true)
    };
}
