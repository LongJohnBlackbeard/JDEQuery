using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B22 - .
/// </summary>
public class F03B22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSUKID.
        /// </summary>
        public const string RSUKID = "RSUKID";

        /// <summary>
        /// RSDOC.
        /// </summary>
        public const string RSDOC = "RSDOC";

        /// <summary>
        /// RSDCT.
        /// </summary>
        public const string RSDCT = "RSDCT";

        /// <summary>
        /// RSKCO.
        /// </summary>
        public const string RSKCO = "RSKCO";

        /// <summary>
        /// RSSFX.
        /// </summary>
        public const string RSSFX = "RSSFX";

        /// <summary>
        /// RSAN8.
        /// </summary>
        public const string RSAN8 = "RSAN8";

        /// <summary>
        /// RSCO.
        /// </summary>
        public const string RSCO = "RSCO";

        /// <summary>
        /// RSPA8.
        /// </summary>
        public const string RSPA8 = "RSPA8";

        /// <summary>
        /// RSDFEE.
        /// </summary>
        public const string RSDFEE = "RSDFEE";

        /// <summary>
        /// RSASLC.
        /// </summary>
        public const string RSASLC = "RSASLC";

        /// <summary>
        /// RSFFEE.
        /// </summary>
        public const string RSFFEE = "RSFFEE";

        /// <summary>
        /// RSFSLC.
        /// </summary>
        public const string RSFSLC = "RSFSLC";

        /// <summary>
        /// RSBCRC.
        /// </summary>
        public const string RSBCRC = "RSBCRC";

        /// <summary>
        /// RSCRCD.
        /// </summary>
        public const string RSCRCD = "RSCRCD";

        /// <summary>
        /// RSCRR.
        /// </summary>
        public const string RSCRR = "RSCRR";

        /// <summary>
        /// RSCRRM.
        /// </summary>
        public const string RSCRRM = "RSCRRM";

        /// <summary>
        /// RSPTC.
        /// </summary>
        public const string RSPTC = "RSPTC";

        /// <summary>
        /// RSRMK.
        /// </summary>
        public const string RSRMK = "RSRMK";

        /// <summary>
        /// RSALPH.
        /// </summary>
        public const string RSALPH = "RSALPH";

        /// <summary>
        /// RSAVID.
        /// </summary>
        public const string RSAVID = "RSAVID";

        /// <summary>
        /// RSSERK.
        /// </summary>
        public const string RSSERK = "RSSERK";

        /// <summary>
        /// RSNAPR.
        /// </summary>
        public const string RSNAPR = "RSNAPR";

        /// <summary>
        /// RSRNID.
        /// </summary>
        public const string RSRNID = "RSRNID";

        /// <summary>
        /// RSDGJ.
        /// </summary>
        public const string RSDGJ = "RSDGJ";

        /// <summary>
        /// RSCLMG.
        /// </summary>
        public const string RSCLMG = "RSCLMG";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSNOTJ.
        /// </summary>
        public const string RSNOTJ = "RSNOTJ";

        /// <summary>
        /// RSSTMPP.
        /// </summary>
        public const string RSSTMPP = "RSSTMPP";

        /// <summary>
        /// RSVERAR.
        /// </summary>
        public const string RSVERAR = "RSVERAR";
    }

    /// <inheritdoc />
    public override string TableName => "F03B22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSUKID", "RSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RSDOC", "RSDOC", JdeDataType.Numeric),
        new JdeField("RSDCT", "RSDCT", JdeDataType.String, 4),
        new JdeField("RSKCO", "RSKCO", JdeDataType.String, 10),
        new JdeField("RSSFX", "RSSFX", JdeDataType.String, 6),
        new JdeField("RSAN8", "RSAN8", JdeDataType.Numeric),
        new JdeField("RSCO", "RSCO", JdeDataType.String, 10),
        new JdeField("RSPA8", "RSPA8", JdeDataType.Numeric),
        new JdeField("RSDFEE", "RSDFEE", JdeDataType.Numeric),
        new JdeField("RSASLC", "RSASLC", JdeDataType.Numeric),
        new JdeField("RSFFEE", "RSFFEE", JdeDataType.Numeric),
        new JdeField("RSFSLC", "RSFSLC", JdeDataType.Numeric),
        new JdeField("RSBCRC", "RSBCRC", JdeDataType.String, 6),
        new JdeField("RSCRCD", "RSCRCD", JdeDataType.String, 6),
        new JdeField("RSCRR", "RSCRR", JdeDataType.Numeric),
        new JdeField("RSCRRM", "RSCRRM", JdeDataType.String, 2),
        new JdeField("RSPTC", "RSPTC", JdeDataType.String, 6),
        new JdeField("RSRMK", "RSRMK", JdeDataType.String, 60),
        new JdeField("RSALPH", "RSALPH", JdeDataType.String, 80),
        new JdeField("RSAVID", "RSAVID", JdeDataType.Numeric),
        new JdeField("RSSERK", "RSSERK", JdeDataType.Numeric),
        new JdeField("RSNAPR", "RSNAPR", JdeDataType.String, 2),
        new JdeField("RSRNID", "RSRNID", JdeDataType.Numeric),
        new JdeField("RSDGJ", "RSDGJ", JdeDataType.Numeric),
        new JdeField("RSCLMG", "RSCLMG", JdeDataType.String, 20),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSNOTJ", "RSNOTJ", JdeDataType.Numeric),
        new JdeField("RSSTMPP", "RSSTMPP", JdeDataType.String, 20),
        new JdeField("RSVERAR", "RSVERAR", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B22_0", "Primary Key on RSUKID", new[] { "RSUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
