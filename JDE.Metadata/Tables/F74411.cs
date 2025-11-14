using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74411 - .
/// </summary>
public class F74411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSKCO.
        /// </summary>
        public const string RSKCO = "RSKCO";

        /// <summary>
        /// RSDCT.
        /// </summary>
        public const string RSDCT = "RSDCT";

        /// <summary>
        /// RSDOC.
        /// </summary>
        public const string RSDOC = "RSDOC";

        /// <summary>
        /// RSSFX.
        /// </summary>
        public const string RSSFX = "RSSFX";

        /// <summary>
        /// RSIRC1.
        /// </summary>
        public const string RSIRC1 = "RSIRC1";

        /// <summary>
        /// RSDIY.
        /// </summary>
        public const string RSDIY = "RSDIY";

        /// <summary>
        /// RSAN8.
        /// </summary>
        public const string RSAN8 = "RSAN8";

        /// <summary>
        /// RSVINV.
        /// </summary>
        public const string RSVINV = "RSVINV";

        /// <summary>
        /// RSIVD.
        /// </summary>
        public const string RSIVD = "RSIVD";

        /// <summary>
        /// RSIRAG.
        /// </summary>
        public const string RSIRAG = "RSIRAG";

        /// <summary>
        /// RSIRIV.
        /// </summary>
        public const string RSIRIV = "RSIRIV";

        /// <summary>
        /// RSIRNS.
        /// </summary>
        public const string RSIRNS = "RSIRNS";

        /// <summary>
        /// RSIRP.
        /// </summary>
        public const string RSIRP = "RSIRP";

        /// <summary>
        /// RSIRBI.
        /// </summary>
        public const string RSIRBI = "RSIRBI";

        /// <summary>
        /// RSIRSO.
        /// </summary>
        public const string RSIRSO = "RSIRSO";

        /// <summary>
        /// RSIRRI.
        /// </summary>
        public const string RSIRRI = "RSIRRI";

        /// <summary>
        /// RSIRRP.
        /// </summary>
        public const string RSIRRP = "RSIRRP";

        /// <summary>
        /// RSIRSA.
        /// </summary>
        public const string RSIRSA = "RSIRSA";

        /// <summary>
        /// RSIRVE.
        /// </summary>
        public const string RSIRVE = "RSIRVE";

        /// <summary>
        /// RSIRQ.
        /// </summary>
        public const string RSIRQ = "RSIRQ";

        /// <summary>
        /// RSCRCD.
        /// </summary>
        public const string RSCRCD = "RSCRCD";

        /// <summary>
        /// RSCRR.
        /// </summary>
        public const string RSCRR = "RSCRR";

        /// <summary>
        /// RSCO.
        /// </summary>
        public const string RSCO = "RSCO";

        /// <summary>
        /// RSCRRM.
        /// </summary>
        public const string RSCRRM = "RSCRRM";

        /// <summary>
        /// RSIRAF.
        /// </summary>
        public const string RSIRAF = "RSIRAF";

        /// <summary>
        /// RSIRVF.
        /// </summary>
        public const string RSIRVF = "RSIRVF";

        /// <summary>
        /// RSIRNF.
        /// </summary>
        public const string RSIRNF = "RSIRNF";

        /// <summary>
        /// RSIRBF.
        /// </summary>
        public const string RSIRBF = "RSIRBF";

        /// <summary>
        /// RSIRSF.
        /// </summary>
        public const string RSIRSF = "RSIRSF";

        /// <summary>
        /// RSIRRF.
        /// </summary>
        public const string RSIRRF = "RSIRRF";

        /// <summary>
        /// RSIRFP.
        /// </summary>
        public const string RSIRFP = "RSIRFP";

        /// <summary>
        /// RSAA1.
        /// </summary>
        public const string RSAA1 = "RSAA1";

        /// <summary>
        /// RSAA.
        /// </summary>
        public const string RSAA = "RSAA";

        /// <summary>
        /// RSIWSD.
        /// </summary>
        public const string RSIWSD = "RSIWSD";

        /// <summary>
        /// RSIWSF.
        /// </summary>
        public const string RSIWSF = "RSIWSF";
    }

    /// <inheritdoc />
    public override string TableName => "F74411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSKCO", "RSKCO", JdeDataType.String, 10, true, true),
        new JdeField("RSDCT", "RSDCT", JdeDataType.String, 4, true, true),
        new JdeField("RSDOC", "RSDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RSSFX", "RSSFX", JdeDataType.String, 6, true, true),
        new JdeField("RSIRC1", "RSIRC1", JdeDataType.String, 4),
        new JdeField("RSDIY", "RSDIY", JdeDataType.Numeric),
        new JdeField("RSAN8", "RSAN8", JdeDataType.Numeric),
        new JdeField("RSVINV", "RSVINV", JdeDataType.String, 50),
        new JdeField("RSIVD", "RSIVD", JdeDataType.Numeric),
        new JdeField("RSIRAG", "RSIRAG", JdeDataType.Numeric),
        new JdeField("RSIRIV", "RSIRIV", JdeDataType.Numeric),
        new JdeField("RSIRNS", "RSIRNS", JdeDataType.Numeric),
        new JdeField("RSIRP", "RSIRP", JdeDataType.Numeric),
        new JdeField("RSIRBI", "RSIRBI", JdeDataType.Numeric),
        new JdeField("RSIRSO", "RSIRSO", JdeDataType.Numeric),
        new JdeField("RSIRRI", "RSIRRI", JdeDataType.Numeric),
        new JdeField("RSIRRP", "RSIRRP", JdeDataType.Numeric),
        new JdeField("RSIRSA", "RSIRSA", JdeDataType.String, 2),
        new JdeField("RSIRVE", "RSIRVE", JdeDataType.String, 60),
        new JdeField("RSIRQ", "RSIRQ", JdeDataType.Numeric),
        new JdeField("RSCRCD", "RSCRCD", JdeDataType.String, 6),
        new JdeField("RSCRR", "RSCRR", JdeDataType.Numeric),
        new JdeField("RSCO", "RSCO", JdeDataType.String, 10),
        new JdeField("RSCRRM", "RSCRRM", JdeDataType.String, 2),
        new JdeField("RSIRAF", "RSIRAF", JdeDataType.Numeric),
        new JdeField("RSIRVF", "RSIRVF", JdeDataType.Numeric),
        new JdeField("RSIRNF", "RSIRNF", JdeDataType.Numeric),
        new JdeField("RSIRBF", "RSIRBF", JdeDataType.Numeric),
        new JdeField("RSIRSF", "RSIRSF", JdeDataType.Numeric),
        new JdeField("RSIRRF", "RSIRRF", JdeDataType.Numeric),
        new JdeField("RSIRFP", "RSIRFP", JdeDataType.Numeric),
        new JdeField("RSAA1", "RSAA1", JdeDataType.Numeric),
        new JdeField("RSAA", "RSAA", JdeDataType.Numeric),
        new JdeField("RSIWSD", "RSIWSD", JdeDataType.Numeric),
        new JdeField("RSIWSF", "RSIWSF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74411_0", "Primary Key on RSKCO, RSDCT, RSDOC, RSSFX", new[] { "RSKCO", "RSDCT", "RSDOC", "RSSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74411_2", "Index on RSKCO, RSDCT, RSAN8", new[] { "RSKCO", "RSDCT", "RSAN8" })
    };
}
