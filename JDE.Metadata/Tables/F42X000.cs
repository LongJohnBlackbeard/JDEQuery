using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X000 - .
/// </summary>
public class F42X000 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCSY.
        /// </summary>
        public const string PCSY = "PCSY";

        /// <summary>
        /// PC42XACTXS.
        /// </summary>
        public const string PC42XACTXS = "PC42XACTXS";

        /// <summary>
        /// PC42XACTT.
        /// </summary>
        public const string PC42XACTT = "PC42XACTT";

        /// <summary>
        /// PC42XCSST.
        /// </summary>
        public const string PC42XCSST = "PC42XCSST";

        /// <summary>
        /// PC42XCSM.
        /// </summary>
        public const string PC42XCSM = "PC42XCSM";

        /// <summary>
        /// PC42XTMB.
        /// </summary>
        public const string PC42XTMB = "PC42XTMB";

        /// <summary>
        /// PC42XTMF.
        /// </summary>
        public const string PC42XTMF = "PC42XTMF";

        /// <summary>
        /// PC42XTRYR.
        /// </summary>
        public const string PC42XTRYR = "PC42XTRYR";

        /// <summary>
        /// PC42XSOOC.
        /// </summary>
        public const string PC42XSOOC = "PC42XSOOC";

        /// <summary>
        /// PC42XBDRD.
        /// </summary>
        public const string PC42XBDRD = "PC42XBDRD";

        /// <summary>
        /// PC42XTOLR.
        /// </summary>
        public const string PC42XTOLR = "PC42XTOLR";

        /// <summary>
        /// PC42XSORT.
        /// </summary>
        public const string PC42XSORT = "PC42XSORT";

        /// <summary>
        /// PCVERS.
        /// </summary>
        public const string PCVERS = "PCVERS";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";

        /// <summary>
        /// PC42XDFTP.
        /// </summary>
        public const string PC42XDFTP = "PC42XDFTP";

        /// <summary>
        /// PC42XSDDAY.
        /// </summary>
        public const string PC42XSDDAY = "PC42XSDDAY";

        /// <summary>
        /// PC42XASD.
        /// </summary>
        public const string PC42XASD = "PC42XASD";

        /// <summary>
        /// PC42XAFP.
        /// </summary>
        public const string PC42XAFP = "PC42XAFP";
    }

    /// <inheritdoc />
    public override string TableName => "F42X000";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCSY", "PCSY", JdeDataType.String, 8, true, true),
        new JdeField("PC42XACTXS", "PC42XACTXS", JdeDataType.String, 2),
        new JdeField("PC42XACTT", "PC42XACTT", JdeDataType.String, 2),
        new JdeField("PC42XCSST", "PC42XCSST", JdeDataType.String, 2),
        new JdeField("PC42XCSM", "PC42XCSM", JdeDataType.Numeric),
        new JdeField("PC42XTMB", "PC42XTMB", JdeDataType.Numeric),
        new JdeField("PC42XTMF", "PC42XTMF", JdeDataType.Numeric),
        new JdeField("PC42XTRYR", "PC42XTRYR", JdeDataType.Numeric),
        new JdeField("PC42XSOOC", "PC42XSOOC", JdeDataType.Numeric),
        new JdeField("PC42XBDRD", "PC42XBDRD", JdeDataType.Numeric),
        new JdeField("PC42XTOLR", "PC42XTOLR", JdeDataType.Numeric),
        new JdeField("PC42XSORT", "PC42XSORT", JdeDataType.String, 2),
        new JdeField("PCVERS", "PCVERS", JdeDataType.String, 20),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric),
        new JdeField("PC42XDFTP", "PC42XDFTP", JdeDataType.Numeric),
        new JdeField("PC42XSDDAY", "PC42XSDDAY", JdeDataType.Numeric),
        new JdeField("PC42XASD", "PC42XASD", JdeDataType.String, 2),
        new JdeField("PC42XAFP", "PC42XAFP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X000_0", "Primary Key on PCSY", new[] { "PCSY" }, isUnique: true, isPrimaryKey: true)
    };
}
