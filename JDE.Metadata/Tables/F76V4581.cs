using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4581 - .
/// </summary>
public class F76V4581 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HRKCO.
        /// </summary>
        public const string HRKCO = "HRKCO";

        /// <summary>
        /// HRDCT.
        /// </summary>
        public const string HRDCT = "HRDCT";

        /// <summary>
        /// HRDOC.
        /// </summary>
        public const string HRDOC = "HRDOC";

        /// <summary>
        /// HRSFX.
        /// </summary>
        public const string HRSFX = "HRSFX";

        /// <summary>
        /// HRSFXE.
        /// </summary>
        public const string HRSFXE = "HRSFXE";

        /// <summary>
        /// HRCO.
        /// </summary>
        public const string HRCO = "HRCO";

        /// <summary>
        /// HRAN8.
        /// </summary>
        public const string HRAN8 = "HRAN8";

        /// <summary>
        /// HRFY.
        /// </summary>
        public const string HRFY = "HRFY";

        /// <summary>
        /// HRPN.
        /// </summary>
        public const string HRPN = "HRPN";

        /// <summary>
        /// HRIRQ.
        /// </summary>
        public const string HRIRQ = "HRIRQ";

        /// <summary>
        /// HRAC07.
        /// </summary>
        public const string HRAC07 = "HRAC07";

        /// <summary>
        /// HRODCT.
        /// </summary>
        public const string HRODCT = "HRODCT";

        /// <summary>
        /// HRODOC.
        /// </summary>
        public const string HRODOC = "HRODOC";

        /// <summary>
        /// HRAG.
        /// </summary>
        public const string HRAG = "HRAG";

        /// <summary>
        /// HRIRBI.
        /// </summary>
        public const string HRIRBI = "HRIRBI";

        /// <summary>
        /// HRIRBF.
        /// </summary>
        public const string HRIRBF = "HRIRBF";

        /// <summary>
        /// HRIRPC.
        /// </summary>
        public const string HRIRPC = "HRIRPC";

        /// <summary>
        /// HRIRPR.
        /// </summary>
        public const string HRIRPR = "HRIRPR";

        /// <summary>
        /// HRBBIR.
        /// </summary>
        public const string HRBBIR = "HRBBIR";

        /// <summary>
        /// HRIRAG.
        /// </summary>
        public const string HRIRAG = "HRIRAG";

        /// <summary>
        /// HRIRRI.
        /// </summary>
        public const string HRIRRI = "HRIRRI";

        /// <summary>
        /// HRIRRF.
        /// </summary>
        public const string HRIRRF = "HRIRRF";

        /// <summary>
        /// HRTNN.
        /// </summary>
        public const string HRTNN = "HRTNN";

        /// <summary>
        /// HRURDT.
        /// </summary>
        public const string HRURDT = "HRURDT";

        /// <summary>
        /// HRURC1.
        /// </summary>
        public const string HRURC1 = "HRURC1";

        /// <summary>
        /// HRURAB.
        /// </summary>
        public const string HRURAB = "HRURAB";

        /// <summary>
        /// HRURAT.
        /// </summary>
        public const string HRURAT = "HRURAT";

        /// <summary>
        /// HRUPMB.
        /// </summary>
        public const string HRUPMB = "HRUPMB";

        /// <summary>
        /// HRPID.
        /// </summary>
        public const string HRPID = "HRPID";

        /// <summary>
        /// HRUPMJ.
        /// </summary>
        public const string HRUPMJ = "HRUPMJ";

        /// <summary>
        /// HRUPMT.
        /// </summary>
        public const string HRUPMT = "HRUPMT";

        /// <summary>
        /// HRJOBN.
        /// </summary>
        public const string HRJOBN = "HRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4581";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HRKCO", "HRKCO", JdeDataType.String, 10, true, true),
        new JdeField("HRDCT", "HRDCT", JdeDataType.String, 4, true, true),
        new JdeField("HRDOC", "HRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("HRSFX", "HRSFX", JdeDataType.String, 6, true, true),
        new JdeField("HRSFXE", "HRSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("HRCO", "HRCO", JdeDataType.String, 10, true, true),
        new JdeField("HRAN8", "HRAN8", JdeDataType.Numeric),
        new JdeField("HRFY", "HRFY", JdeDataType.Numeric),
        new JdeField("HRPN", "HRPN", JdeDataType.Numeric),
        new JdeField("HRIRQ", "HRIRQ", JdeDataType.Numeric),
        new JdeField("HRAC07", "HRAC07", JdeDataType.String, 6),
        new JdeField("HRODCT", "HRODCT", JdeDataType.String, 4),
        new JdeField("HRODOC", "HRODOC", JdeDataType.Numeric),
        new JdeField("HRAG", "HRAG", JdeDataType.Numeric),
        new JdeField("HRIRBI", "HRIRBI", JdeDataType.Numeric),
        new JdeField("HRIRBF", "HRIRBF", JdeDataType.Numeric),
        new JdeField("HRIRPC", "HRIRPC", JdeDataType.Numeric),
        new JdeField("HRIRPR", "HRIRPR", JdeDataType.Numeric),
        new JdeField("HRBBIR", "HRBBIR", JdeDataType.Numeric),
        new JdeField("HRIRAG", "HRIRAG", JdeDataType.Numeric),
        new JdeField("HRIRRI", "HRIRRI", JdeDataType.Numeric),
        new JdeField("HRIRRF", "HRIRRF", JdeDataType.Numeric),
        new JdeField("HRTNN", "HRTNN", JdeDataType.String, 2),
        new JdeField("HRURDT", "HRURDT", JdeDataType.Numeric),
        new JdeField("HRURC1", "HRURC1", JdeDataType.String, 6),
        new JdeField("HRURAB", "HRURAB", JdeDataType.Numeric),
        new JdeField("HRURAT", "HRURAT", JdeDataType.Numeric),
        new JdeField("HRUPMB", "HRUPMB", JdeDataType.String, 20),
        new JdeField("HRPID", "HRPID", JdeDataType.String, 20),
        new JdeField("HRUPMJ", "HRUPMJ", JdeDataType.Numeric),
        new JdeField("HRUPMT", "HRUPMT", JdeDataType.Numeric),
        new JdeField("HRJOBN", "HRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4581_0", "Primary Key on HRKCO, HRDCT, HRDOC, HRSFX, HRSFXE, HRCO", new[] { "HRKCO", "HRDCT", "HRDOC", "HRSFX", "HRSFXE", "HRCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76V4581_5", "Index on HRCO, HRAC07, HRODCT, HRODOC", new[] { "HRCO", "HRAC07", "HRODCT", "HRODOC" }),
        new JdeIndex("F76V4581_6", "Index on HRTNN, HRURC1, HRURAB", new[] { "HRTNN", "HRURC1", "HRURAB" }),
        new JdeIndex("F76V4581_7", "Index on HRCO, HRAN8, HRFY, HRPN, HRIRQ, HRAC07, HRODCT, HRODOC", new[] { "HRCO", "HRAN8", "HRFY", "HRPN", "HRIRQ", "HRAC07", "HRODCT", "HRODOC" }),
        new JdeIndex("F76V4581_8", "Index on HRKCO, HRODCT, HRODOC", new[] { "HRKCO", "HRODCT", "HRODOC" }),
        new JdeIndex("F76V4581_9", "Index on HRKCO, HRURC1, HRURAB", new[] { "HRKCO", "HRURC1", "HRURAB" })
    };
}
