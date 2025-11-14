using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49695 - .
/// </summary>
public class F49695 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRCO.
        /// </summary>
        public const string DRCO = "DRCO";

        /// <summary>
        /// DREMCU.
        /// </summary>
        public const string DREMCU = "DREMCU";

        /// <summary>
        /// DRMCU.
        /// </summary>
        public const string DRMCU = "DRMCU";

        /// <summary>
        /// DRDCT.
        /// </summary>
        public const string DRDCT = "DRDCT";

        /// <summary>
        /// DRDOC.
        /// </summary>
        public const string DRDOC = "DRDOC";

        /// <summary>
        /// DRKCO.
        /// </summary>
        public const string DRKCO = "DRKCO";

        /// <summary>
        /// DRDTDO.
        /// </summary>
        public const string DRDTDO = "DRDTDO";

        /// <summary>
        /// DRMCUZ.
        /// </summary>
        public const string DRMCUZ = "DRMCUZ";

        /// <summary>
        /// DRDPCR.
        /// </summary>
        public const string DRDPCR = "DRDPCR";

        /// <summary>
        /// DRDCCD.
        /// </summary>
        public const string DRDCCD = "DRDCCD";

        /// <summary>
        /// DRDL01.
        /// </summary>
        public const string DRDL01 = "DRDL01";

        /// <summary>
        /// DRAA.
        /// </summary>
        public const string DRAA = "DRAA";

        /// <summary>
        /// DRCDEC.
        /// </summary>
        public const string DRCDEC = "DRCDEC";

        /// <summary>
        /// DRCRCD.
        /// </summary>
        public const string DRCRCD = "DRCRCD";

        /// <summary>
        /// DRMDTY.
        /// </summary>
        public const string DRMDTY = "DRMDTY";

        /// <summary>
        /// DRDOST.
        /// </summary>
        public const string DRDOST = "DRDOST";

        /// <summary>
        /// DRDCRS.
        /// </summary>
        public const string DRDCRS = "DRDCRS";

        /// <summary>
        /// DRDOCM.
        /// </summary>
        public const string DRDOCM = "DRDOCM";

        /// <summary>
        /// DRDCTM.
        /// </summary>
        public const string DRDCTM = "DRDCTM";

        /// <summary>
        /// DRSFXM.
        /// </summary>
        public const string DRSFXM = "DRSFXM";

        /// <summary>
        /// DRAN8.
        /// </summary>
        public const string DRAN8 = "DRAN8";

        /// <summary>
        /// DRCRPT.
        /// </summary>
        public const string DRCRPT = "DRCRPT";

        /// <summary>
        /// DRCARS.
        /// </summary>
        public const string DRCARS = "DRCARS";

        /// <summary>
        /// DRREFQ.
        /// </summary>
        public const string DRREFQ = "DRREFQ";

        /// <summary>
        /// DRREFN.
        /// </summary>
        public const string DRREFN = "DRREFN";

        /// <summary>
        /// DRURCD.
        /// </summary>
        public const string DRURCD = "DRURCD";

        /// <summary>
        /// DRURDT.
        /// </summary>
        public const string DRURDT = "DRURDT";

        /// <summary>
        /// DRURAT.
        /// </summary>
        public const string DRURAT = "DRURAT";

        /// <summary>
        /// DRURAB.
        /// </summary>
        public const string DRURAB = "DRURAB";

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
        /// DRTDAY.
        /// </summary>
        public const string DRTDAY = "DRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49695";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRCO", "DRCO", JdeDataType.String, 10, true, true),
        new JdeField("DREMCU", "DREMCU", JdeDataType.String, 24, true, true),
        new JdeField("DRMCU", "DRMCU", JdeDataType.String, 24, true, true),
        new JdeField("DRDCT", "DRDCT", JdeDataType.String, 4, true, true),
        new JdeField("DRDOC", "DRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DRKCO", "DRKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRDTDO", "DRDTDO", JdeDataType.Numeric),
        new JdeField("DRMCUZ", "DRMCUZ", JdeDataType.String, 24),
        new JdeField("DRDPCR", "DRDPCR", JdeDataType.String, 2),
        new JdeField("DRDCCD", "DRDCCD", JdeDataType.String, 8),
        new JdeField("DRDL01", "DRDL01", JdeDataType.String, 60),
        new JdeField("DRAA", "DRAA", JdeDataType.Numeric),
        new JdeField("DRCDEC", "DRCDEC", JdeDataType.String, 2),
        new JdeField("DRCRCD", "DRCRCD", JdeDataType.String, 6),
        new JdeField("DRMDTY", "DRMDTY", JdeDataType.String, 2),
        new JdeField("DRDOST", "DRDOST", JdeDataType.String, 4),
        new JdeField("DRDCRS", "DRDCRS", JdeDataType.String, 4),
        new JdeField("DRDOCM", "DRDOCM", JdeDataType.Numeric),
        new JdeField("DRDCTM", "DRDCTM", JdeDataType.String, 4),
        new JdeField("DRSFXM", "DRSFXM", JdeDataType.String, 6),
        new JdeField("DRAN8", "DRAN8", JdeDataType.Numeric),
        new JdeField("DRCRPT", "DRCRPT", JdeDataType.Numeric),
        new JdeField("DRCARS", "DRCARS", JdeDataType.Numeric),
        new JdeField("DRREFQ", "DRREFQ", JdeDataType.String, 4),
        new JdeField("DRREFN", "DRREFN", JdeDataType.String, 60),
        new JdeField("DRURCD", "DRURCD", JdeDataType.String, 4),
        new JdeField("DRURDT", "DRURDT", JdeDataType.Numeric),
        new JdeField("DRURAT", "DRURAT", JdeDataType.Numeric),
        new JdeField("DRURAB", "DRURAB", JdeDataType.Numeric),
        new JdeField("DRURRF", "DRURRF", JdeDataType.String, 30),
        new JdeField("DRUSER", "DRUSER", JdeDataType.String, 20),
        new JdeField("DRPID", "DRPID", JdeDataType.String, 20),
        new JdeField("DRJOBN", "DRJOBN", JdeDataType.String, 20),
        new JdeField("DRUPMJ", "DRUPMJ", JdeDataType.Numeric),
        new JdeField("DRTDAY", "DRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49695_0", "Primary Key on DRCO, DREMCU, DRMCU, DRDCT, DRDOC, DRKCO", new[] { "DRCO", "DREMCU", "DRMCU", "DRDCT", "DRDOC", "DRKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
