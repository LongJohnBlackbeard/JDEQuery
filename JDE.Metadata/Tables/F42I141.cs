using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I141 - .
/// </summary>
public class F42I141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OSDMCT.
        /// </summary>
        public const string OSDMCT = "OSDMCT";

        /// <summary>
        /// OSDMCS.
        /// </summary>
        public const string OSDMCS = "OSDMCS";

        /// <summary>
        /// OSSEQ.
        /// </summary>
        public const string OSSEQ = "OSSEQ";

        /// <summary>
        /// OSOIMFJBNM.
        /// </summary>
        public const string OSOIMFJBNM = "OSOIMFJBNM";

        /// <summary>
        /// OSLREPDT.
        /// </summary>
        public const string OSLREPDT = "OSLREPDT";

        /// <summary>
        /// OSSHAN.
        /// </summary>
        public const string OSSHAN = "OSSHAN";

        /// <summary>
        /// OSTOAN8.
        /// </summary>
        public const string OSTOAN8 = "OSTOAN8";

        /// <summary>
        /// OSMCU.
        /// </summary>
        public const string OSMCU = "OSMCU";

        /// <summary>
        /// OSLOCN.
        /// </summary>
        public const string OSLOCN = "OSLOCN";

        /// <summary>
        /// OSITM.
        /// </summary>
        public const string OSITM = "OSITM";

        /// <summary>
        /// OSLITM.
        /// </summary>
        public const string OSLITM = "OSLITM";

        /// <summary>
        /// OSREPFST.
        /// </summary>
        public const string OSREPFST = "OSREPFST";

        /// <summary>
        /// OSOIPR.
        /// </summary>
        public const string OSOIPR = "OSOIPR";

        /// <summary>
        /// OSPRSEQ.
        /// </summary>
        public const string OSPRSEQ = "OSPRSEQ";

        /// <summary>
        /// OSNREPDT.
        /// </summary>
        public const string OSNREPDT = "OSNREPDT";

        /// <summary>
        /// OSFRELNST.
        /// </summary>
        public const string OSFRELNST = "OSFRELNST";

        /// <summary>
        /// OSUSER.
        /// </summary>
        public const string OSUSER = "OSUSER";

        /// <summary>
        /// OSPID.
        /// </summary>
        public const string OSPID = "OSPID";

        /// <summary>
        /// OSJOBN.
        /// </summary>
        public const string OSJOBN = "OSJOBN";

        /// <summary>
        /// OSUPMJ.
        /// </summary>
        public const string OSUPMJ = "OSUPMJ";

        /// <summary>
        /// OSTDAY.
        /// </summary>
        public const string OSTDAY = "OSTDAY";

        /// <summary>
        /// OSFUCHAR61.
        /// </summary>
        public const string OSFUCHAR61 = "OSFUCHAR61";

        /// <summary>
        /// OSFUCHAR62.
        /// </summary>
        public const string OSFUCHAR62 = "OSFUCHAR62";

        /// <summary>
        /// OSFUCHAR63.
        /// </summary>
        public const string OSFUCHAR63 = "OSFUCHAR63";

        /// <summary>
        /// OSFUNUM61.
        /// </summary>
        public const string OSFUNUM61 = "OSFUNUM61";

        /// <summary>
        /// OSFUNUM62.
        /// </summary>
        public const string OSFUNUM62 = "OSFUNUM62";

        /// <summary>
        /// OSFUNUM63.
        /// </summary>
        public const string OSFUNUM63 = "OSFUNUM63";

        /// <summary>
        /// OSFSTR61.
        /// </summary>
        public const string OSFSTR61 = "OSFSTR61";

        /// <summary>
        /// OSFSTR62.
        /// </summary>
        public const string OSFSTR62 = "OSFSTR62";

        /// <summary>
        /// OSFSTR63.
        /// </summary>
        public const string OSFSTR63 = "OSFSTR63";

        /// <summary>
        /// OSFUDT61.
        /// </summary>
        public const string OSFUDT61 = "OSFUDT61";

        /// <summary>
        /// OSFUDT62.
        /// </summary>
        public const string OSFUDT62 = "OSFUDT62";

        /// <summary>
        /// OSFUDT63.
        /// </summary>
        public const string OSFUDT63 = "OSFUDT63";

        /// <summary>
        /// OSURAT.
        /// </summary>
        public const string OSURAT = "OSURAT";

        /// <summary>
        /// OSURCD.
        /// </summary>
        public const string OSURCD = "OSURCD";

        /// <summary>
        /// OSURDT.
        /// </summary>
        public const string OSURDT = "OSURDT";

        /// <summary>
        /// OSURAB.
        /// </summary>
        public const string OSURAB = "OSURAB";

        /// <summary>
        /// OSURRF.
        /// </summary>
        public const string OSURRF = "OSURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OSDMCT", "OSDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OSDMCS", "OSDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OSSEQ", "OSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OSOIMFJBNM", "OSOIMFJBNM", JdeDataType.String, 60, true, true),
        new JdeField("OSLREPDT", "OSLREPDT", JdeDataType.Numeric, null, true, true),
        new JdeField("OSSHAN", "OSSHAN", JdeDataType.Numeric),
        new JdeField("OSTOAN8", "OSTOAN8", JdeDataType.Numeric),
        new JdeField("OSMCU", "OSMCU", JdeDataType.String, 24),
        new JdeField("OSLOCN", "OSLOCN", JdeDataType.String, 40),
        new JdeField("OSITM", "OSITM", JdeDataType.Numeric),
        new JdeField("OSLITM", "OSLITM", JdeDataType.String, 50),
        new JdeField("OSREPFST", "OSREPFST", JdeDataType.Numeric),
        new JdeField("OSOIPR", "OSOIPR", JdeDataType.String, 16),
        new JdeField("OSPRSEQ", "OSPRSEQ", JdeDataType.Numeric),
        new JdeField("OSNREPDT", "OSNREPDT", JdeDataType.Numeric),
        new JdeField("OSFRELNST", "OSFRELNST", JdeDataType.Numeric),
        new JdeField("OSUSER", "OSUSER", JdeDataType.String, 20),
        new JdeField("OSPID", "OSPID", JdeDataType.String, 20),
        new JdeField("OSJOBN", "OSJOBN", JdeDataType.String, 20),
        new JdeField("OSUPMJ", "OSUPMJ", JdeDataType.Numeric),
        new JdeField("OSTDAY", "OSTDAY", JdeDataType.Numeric),
        new JdeField("OSFUCHAR61", "OSFUCHAR61", JdeDataType.String, 2),
        new JdeField("OSFUCHAR62", "OSFUCHAR62", JdeDataType.String, 2),
        new JdeField("OSFUCHAR63", "OSFUCHAR63", JdeDataType.String, 2),
        new JdeField("OSFUNUM61", "OSFUNUM61", JdeDataType.Numeric),
        new JdeField("OSFUNUM62", "OSFUNUM62", JdeDataType.Numeric),
        new JdeField("OSFUNUM63", "OSFUNUM63", JdeDataType.Numeric),
        new JdeField("OSFSTR61", "OSFSTR61", JdeDataType.String, 100),
        new JdeField("OSFSTR62", "OSFSTR62", JdeDataType.String, 100),
        new JdeField("OSFSTR63", "OSFSTR63", JdeDataType.String, 100),
        new JdeField("OSFUDT61", "OSFUDT61", JdeDataType.Numeric),
        new JdeField("OSFUDT62", "OSFUDT62", JdeDataType.Numeric),
        new JdeField("OSFUDT63", "OSFUDT63", JdeDataType.Numeric),
        new JdeField("OSURAT", "OSURAT", JdeDataType.Numeric),
        new JdeField("OSURCD", "OSURCD", JdeDataType.String, 4),
        new JdeField("OSURDT", "OSURDT", JdeDataType.Numeric),
        new JdeField("OSURAB", "OSURAB", JdeDataType.Numeric),
        new JdeField("OSURRF", "OSURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I141_0", "Primary Key on OSDMCT, OSDMCS, OSSEQ, OSOIMFJBNM, OSLREPDT", new[] { "OSDMCT", "OSDMCS", "OSSEQ", "OSOIMFJBNM", "OSLREPDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I141_2", "Index on OSDMCT, OSDMCS, OSSEQ, OSREPFST", new[] { "OSDMCT", "OSDMCS", "OSSEQ", "OSREPFST" })
    };
}
