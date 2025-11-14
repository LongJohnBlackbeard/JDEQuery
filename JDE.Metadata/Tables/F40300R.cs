using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40300R - .
/// </summary>
public class F40300R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMUKID.
        /// </summary>
        public const string PMUKID = "PMUKID";

        /// <summary>
        /// PMPRFR.
        /// </summary>
        public const string PMPRFR = "PMPRFR";

        /// <summary>
        /// PMDOCO.
        /// </summary>
        public const string PMDOCO = "PMDOCO";

        /// <summary>
        /// PMDCTO.
        /// </summary>
        public const string PMDCTO = "PMDCTO";

        /// <summary>
        /// PMKCOO.
        /// </summary>
        public const string PMKCOO = "PMKCOO";

        /// <summary>
        /// PMLNID.
        /// </summary>
        public const string PMLNID = "PMLNID";

        /// <summary>
        /// PMDRQJ.
        /// </summary>
        public const string PMDRQJ = "PMDRQJ";

        /// <summary>
        /// PMUORG.
        /// </summary>
        public const string PMUORG = "PMUORG";

        /// <summary>
        /// PMUOM.
        /// </summary>
        public const string PMUOM = "PMUOM";

        /// <summary>
        /// PMMCU.
        /// </summary>
        public const string PMMCU = "PMMCU";

        /// <summary>
        /// PMROUT.
        /// </summary>
        public const string PMROUT = "PMROUT";

        /// <summary>
        /// PMMOT.
        /// </summary>
        public const string PMMOT = "PMMOT";

        /// <summary>
        /// PMPRIO.
        /// </summary>
        public const string PMPRIO = "PMPRIO";

        /// <summary>
        /// PMCARS.
        /// </summary>
        public const string PMCARS = "PMCARS";

        /// <summary>
        /// PMLNTY.
        /// </summary>
        public const string PMLNTY = "PMLNTY";

        /// <summary>
        /// PMLTTR.
        /// </summary>
        public const string PMLTTR = "PMLTTR";

        /// <summary>
        /// PMLOB.
        /// </summary>
        public const string PMLOB = "PMLOB";

        /// <summary>
        /// PMUK01.
        /// </summary>
        public const string PMUK01 = "PMUK01";

        /// <summary>
        /// PMURCD.
        /// </summary>
        public const string PMURCD = "PMURCD";

        /// <summary>
        /// PMURDT.
        /// </summary>
        public const string PMURDT = "PMURDT";

        /// <summary>
        /// PMURAT.
        /// </summary>
        public const string PMURAT = "PMURAT";

        /// <summary>
        /// PMURAB.
        /// </summary>
        public const string PMURAB = "PMURAB";

        /// <summary>
        /// PMURRF.
        /// </summary>
        public const string PMURRF = "PMURRF";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMTDAY.
        /// </summary>
        public const string PMTDAY = "PMTDAY";

        /// <summary>
        /// PMAN8.
        /// </summary>
        public const string PMAN8 = "PMAN8";

        /// <summary>
        /// PMSHAN.
        /// </summary>
        public const string PMSHAN = "PMSHAN";

        /// <summary>
        /// PMPA8.
        /// </summary>
        public const string PMPA8 = "PMPA8";
    }

    /// <inheritdoc />
    public override string TableName => "F40300R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMUKID", "PMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PMPRFR", "PMPRFR", JdeDataType.String, 4),
        new JdeField("PMDOCO", "PMDOCO", JdeDataType.Numeric),
        new JdeField("PMDCTO", "PMDCTO", JdeDataType.String, 4),
        new JdeField("PMKCOO", "PMKCOO", JdeDataType.String, 10),
        new JdeField("PMLNID", "PMLNID", JdeDataType.Numeric),
        new JdeField("PMDRQJ", "PMDRQJ", JdeDataType.Numeric),
        new JdeField("PMUORG", "PMUORG", JdeDataType.Numeric),
        new JdeField("PMUOM", "PMUOM", JdeDataType.String, 4),
        new JdeField("PMMCU", "PMMCU", JdeDataType.String, 24),
        new JdeField("PMROUT", "PMROUT", JdeDataType.String, 6),
        new JdeField("PMMOT", "PMMOT", JdeDataType.String, 6),
        new JdeField("PMPRIO", "PMPRIO", JdeDataType.String, 2),
        new JdeField("PMCARS", "PMCARS", JdeDataType.Numeric),
        new JdeField("PMLNTY", "PMLNTY", JdeDataType.String, 4),
        new JdeField("PMLTTR", "PMLTTR", JdeDataType.String, 6),
        new JdeField("PMLOB", "PMLOB", JdeDataType.String, 6),
        new JdeField("PMUK01", "PMUK01", JdeDataType.Numeric),
        new JdeField("PMURCD", "PMURCD", JdeDataType.String, 4),
        new JdeField("PMURDT", "PMURDT", JdeDataType.Numeric),
        new JdeField("PMURAT", "PMURAT", JdeDataType.Numeric),
        new JdeField("PMURAB", "PMURAB", JdeDataType.Numeric),
        new JdeField("PMURRF", "PMURRF", JdeDataType.String, 30),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMTDAY", "PMTDAY", JdeDataType.Numeric),
        new JdeField("PMAN8", "PMAN8", JdeDataType.Numeric),
        new JdeField("PMSHAN", "PMSHAN", JdeDataType.Numeric),
        new JdeField("PMPA8", "PMPA8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40300R_0", "Primary Key on PMUKID", new[] { "PMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40300R_2", "Index on PMDOCO, PMDCTO, PMKCOO, PMLNID", new[] { "PMDOCO", "PMDCTO", "PMKCOO", "PMLNID" })
    };
}
