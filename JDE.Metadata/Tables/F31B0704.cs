using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0704 - .
/// </summary>
public class F31B0704 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VDSPECID.
        /// </summary>
        public const string VDSPECID = "VDSPECID";

        /// <summary>
        /// VDEURID.
        /// </summary>
        public const string VDEURID = "VDEURID";

        /// <summary>
        /// VDSEQNUMB.
        /// </summary>
        public const string VDSEQNUMB = "VDSEQNUMB";

        /// <summary>
        /// VDNCID.
        /// </summary>
        public const string VDNCID = "VDNCID";

        /// <summary>
        /// VDTVALC.
        /// </summary>
        public const string VDTVALC = "VDTVALC";

        /// <summary>
        /// VDTVALS.
        /// </summary>
        public const string VDTVALS = "VDTVALS";

        /// <summary>
        /// VDTVALD.
        /// </summary>
        public const string VDTVALD = "VDTVALD";

        /// <summary>
        /// VDTVALN.
        /// </summary>
        public const string VDTVALN = "VDTVALN";

        /// <summary>
        /// VDNCRULE.
        /// </summary>
        public const string VDNCRULE = "VDNCRULE";

        /// <summary>
        /// VDHSERR.
        /// </summary>
        public const string VDHSERR = "VDHSERR";

        /// <summary>
        /// VDURAB.
        /// </summary>
        public const string VDURAB = "VDURAB";

        /// <summary>
        /// VDURAT.
        /// </summary>
        public const string VDURAT = "VDURAT";

        /// <summary>
        /// VDURCD.
        /// </summary>
        public const string VDURCD = "VDURCD";

        /// <summary>
        /// VDURDT.
        /// </summary>
        public const string VDURDT = "VDURDT";

        /// <summary>
        /// VDURRF.
        /// </summary>
        public const string VDURRF = "VDURRF";

        /// <summary>
        /// VDJOBN.
        /// </summary>
        public const string VDJOBN = "VDJOBN";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDTDAY.
        /// </summary>
        public const string VDTDAY = "VDTDAY";

        /// <summary>
        /// VDUPMJ.
        /// </summary>
        public const string VDUPMJ = "VDUPMJ";

        /// <summary>
        /// VDUSER.
        /// </summary>
        public const string VDUSER = "VDUSER";

        /// <summary>
        /// VDWAB.
        /// </summary>
        public const string VDWAB = "VDWAB";

        /// <summary>
        /// VDWCD.
        /// </summary>
        public const string VDWCD = "VDWCD";

        /// <summary>
        /// VDWMDT.
        /// </summary>
        public const string VDWMDT = "VDWMDT";

        /// <summary>
        /// VDWNUM.
        /// </summary>
        public const string VDWNUM = "VDWNUM";

        /// <summary>
        /// VDWRF.
        /// </summary>
        public const string VDWRF = "VDWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0704";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VDSPECID", "VDSPECID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDEURID", "VDEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDSEQNUMB", "VDSEQNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("VDNCID", "VDNCID", JdeDataType.Numeric),
        new JdeField("VDTVALC", "VDTVALC", JdeDataType.String, 2),
        new JdeField("VDTVALS", "VDTVALS", JdeDataType.String, 40),
        new JdeField("VDTVALD", "VDTVALD", JdeDataType.Numeric),
        new JdeField("VDTVALN", "VDTVALN", JdeDataType.Numeric),
        new JdeField("VDNCRULE", "VDNCRULE", JdeDataType.String, 8),
        new JdeField("VDHSERR", "VDHSERR", JdeDataType.String, 2),
        new JdeField("VDURAB", "VDURAB", JdeDataType.Numeric),
        new JdeField("VDURAT", "VDURAT", JdeDataType.Numeric),
        new JdeField("VDURCD", "VDURCD", JdeDataType.String, 4),
        new JdeField("VDURDT", "VDURDT", JdeDataType.Numeric),
        new JdeField("VDURRF", "VDURRF", JdeDataType.String, 30),
        new JdeField("VDJOBN", "VDJOBN", JdeDataType.String, 20),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDTDAY", "VDTDAY", JdeDataType.Numeric),
        new JdeField("VDUPMJ", "VDUPMJ", JdeDataType.Numeric),
        new JdeField("VDUSER", "VDUSER", JdeDataType.String, 20),
        new JdeField("VDWAB", "VDWAB", JdeDataType.Numeric),
        new JdeField("VDWCD", "VDWCD", JdeDataType.String, 6),
        new JdeField("VDWMDT", "VDWMDT", JdeDataType.Numeric),
        new JdeField("VDWNUM", "VDWNUM", JdeDataType.Numeric),
        new JdeField("VDWRF", "VDWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0704_0", "Primary Key on VDSPECID, VDEURID, VDSEQNUMB", new[] { "VDSPECID", "VDEURID", "VDSEQNUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0704_2", "Index on VDEURID, VDSPECID, VDSEQNUMB", new[] { "VDEURID", "VDSPECID", "VDSEQNUMB" })
    };
}
