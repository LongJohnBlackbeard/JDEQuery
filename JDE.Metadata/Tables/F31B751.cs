using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B751 - .
/// </summary>
public class F31B751 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OAWCFGID.
        /// </summary>
        public const string OAWCFGID = "OAWCFGID";

        /// <summary>
        /// OAWCOPCD.
        /// </summary>
        public const string OAWCOPCD = "OAWCOPCD";

        /// <summary>
        /// OAWBOPID.
        /// </summary>
        public const string OAWBOPID = "OAWBOPID";

        /// <summary>
        /// OAWBOPCD.
        /// </summary>
        public const string OAWBOPCD = "OAWBOPCD";

        /// <summary>
        /// OAWFTLOC.
        /// </summary>
        public const string OAWFTLOC = "OAWFTLOC";

        /// <summary>
        /// OAWFTKFM.
        /// </summary>
        public const string OAWFTKFM = "OAWFTKFM";

        /// <summary>
        /// OAWFTKFF.
        /// </summary>
        public const string OAWFTKFF = "OAWFTKFF";

        /// <summary>
        /// OAWFTKVC.
        /// </summary>
        public const string OAWFTKVC = "OAWFTKVC";

        /// <summary>
        /// OAWTVCTY.
        /// </summary>
        public const string OAWTVCTY = "OAWTVCTY";

        /// <summary>
        /// OAWFTKCW.
        /// </summary>
        public const string OAWFTKCW = "OAWFTKCW";

        /// <summary>
        /// OAWTWCTY.
        /// </summary>
        public const string OAWTWCTY = "OAWTWCTY";

        /// <summary>
        /// OAWFTKCR.
        /// </summary>
        public const string OAWFTKCR = "OAWFTKCR";

        /// <summary>
        /// OAWTRCTY.
        /// </summary>
        public const string OAWTRCTY = "OAWTRCTY";

        /// <summary>
        /// OAWFUMTV.
        /// </summary>
        public const string OAWFUMTV = "OAWFUMTV";

        /// <summary>
        /// OAWFUMTW.
        /// </summary>
        public const string OAWFUMTW = "OAWFUMTW";

        /// <summary>
        /// OAWFTSTA.
        /// </summary>
        public const string OAWFTSTA = "OAWFTSTA";

        /// <summary>
        /// OAWFTKTC.
        /// </summary>
        public const string OAWFTKTC = "OAWFTKTC";

        /// <summary>
        /// OAWFTKFC.
        /// </summary>
        public const string OAWFTKFC = "OAWFTKFC";

        /// <summary>
        /// OAWFTKPL.
        /// </summary>
        public const string OAWFTKPL = "OAWFTKPL";

        /// <summary>
        /// OAWFTKHS.
        /// </summary>
        public const string OAWFTKHS = "OAWFTKHS";

        /// <summary>
        /// OAWFTKVS.
        /// </summary>
        public const string OAWFTKVS = "OAWFTKVS";

        /// <summary>
        /// OAWFBAVC.
        /// </summary>
        public const string OAWFBAVC = "OAWFBAVC";

        /// <summary>
        /// OAWFBCST.
        /// </summary>
        public const string OAWFBCST = "OAWFBCST";

        /// <summary>
        /// OAWTTLOC.
        /// </summary>
        public const string OAWTTLOC = "OAWTTLOC";

        /// <summary>
        /// OAWTTKFM.
        /// </summary>
        public const string OAWTTKFM = "OAWTTKFM";

        /// <summary>
        /// OAWTTKFF.
        /// </summary>
        public const string OAWTTKFF = "OAWTTKFF";

        /// <summary>
        /// OAWTTKVC.
        /// </summary>
        public const string OAWTTKVC = "OAWTTKVC";

        /// <summary>
        /// OAWTTVCT.
        /// </summary>
        public const string OAWTTVCT = "OAWTTVCT";

        /// <summary>
        /// OAWTTKCW.
        /// </summary>
        public const string OAWTTKCW = "OAWTTKCW";

        /// <summary>
        /// OAWTTWCT.
        /// </summary>
        public const string OAWTTWCT = "OAWTTWCT";

        /// <summary>
        /// OAWTTKCR.
        /// </summary>
        public const string OAWTTKCR = "OAWTTKCR";

        /// <summary>
        /// OAWTTRCT.
        /// </summary>
        public const string OAWTTRCT = "OAWTTRCT";

        /// <summary>
        /// OAWTUMTV.
        /// </summary>
        public const string OAWTUMTV = "OAWTUMTV";

        /// <summary>
        /// OAWTUMTW.
        /// </summary>
        public const string OAWTUMTW = "OAWTUMTW";

        /// <summary>
        /// OAWTTSTA.
        /// </summary>
        public const string OAWTTSTA = "OAWTTSTA";

        /// <summary>
        /// OAWTTKTC.
        /// </summary>
        public const string OAWTTKTC = "OAWTTKTC";

        /// <summary>
        /// OAWTTKFC.
        /// </summary>
        public const string OAWTTKFC = "OAWTTKFC";

        /// <summary>
        /// OAWTTKPL.
        /// </summary>
        public const string OAWTTKPL = "OAWTTKPL";

        /// <summary>
        /// OAWTTKHS.
        /// </summary>
        public const string OAWTTKHS = "OAWTTKHS";

        /// <summary>
        /// OAWTTKVS.
        /// </summary>
        public const string OAWTTKVS = "OAWTTKVS";

        /// <summary>
        /// OAWTBAVC.
        /// </summary>
        public const string OAWTBAVC = "OAWTBAVC";

        /// <summary>
        /// OAWTBCST.
        /// </summary>
        public const string OAWTBCST = "OAWTBCST";

        /// <summary>
        /// OAWNTKST.
        /// </summary>
        public const string OAWNTKST = "OAWNTKST";

        /// <summary>
        /// OAWNTKHS.
        /// </summary>
        public const string OAWNTKHS = "OAWNTKHS";

        /// <summary>
        /// OAWNTKVS.
        /// </summary>
        public const string OAWNTKVS = "OAWNTKVS";

        /// <summary>
        /// OAWNBAVC.
        /// </summary>
        public const string OAWNBAVC = "OAWNBAVC";

        /// <summary>
        /// OAWFABGC.
        /// </summary>
        public const string OAWFABGC = "OAWFABGC";

        /// <summary>
        /// OAWFABCS.
        /// </summary>
        public const string OAWFABCS = "OAWFABCS";

        /// <summary>
        /// OAWFBTOF.
        /// </summary>
        public const string OAWFBTOF = "OAWFBTOF";

        /// <summary>
        /// OAWFBFOF.
        /// </summary>
        public const string OAWFBFOF = "OAWFBFOF";

        /// <summary>
        /// OAWFAMLT.
        /// </summary>
        public const string OAWFAMLT = "OAWFAMLT";

        /// <summary>
        /// OAWFBSTF.
        /// </summary>
        public const string OAWFBSTF = "OAWFBSTF";

        /// <summary>
        /// OAWNTTAS.
        /// </summary>
        public const string OAWNTTAS = "OAWNTTAS";

        /// <summary>
        /// OAWNTTHS.
        /// </summary>
        public const string OAWNTTHS = "OAWNTTHS";

        /// <summary>
        /// OAWNTTVS.
        /// </summary>
        public const string OAWNTTVS = "OAWNTTVS";

        /// <summary>
        /// OAWTABAC.
        /// </summary>
        public const string OAWTABAC = "OAWTABAC";

        /// <summary>
        /// OAWTABGC.
        /// </summary>
        public const string OAWTABGC = "OAWTABGC";

        /// <summary>
        /// OAWTABCS.
        /// </summary>
        public const string OAWTABCS = "OAWTABCS";

        /// <summary>
        /// OAWTBTOF.
        /// </summary>
        public const string OAWTBTOF = "OAWTBTOF";

        /// <summary>
        /// OAWTBFOF.
        /// </summary>
        public const string OAWTBFOF = "OAWTBFOF";

        /// <summary>
        /// OAWTAMLT.
        /// </summary>
        public const string OAWTAMLT = "OAWTAMLT";

        /// <summary>
        /// OAWTBSTF.
        /// </summary>
        public const string OAWTBSTF = "OAWTBSTF";

        /// <summary>
        /// OAURCD.
        /// </summary>
        public const string OAURCD = "OAURCD";

        /// <summary>
        /// OAURDT.
        /// </summary>
        public const string OAURDT = "OAURDT";

        /// <summary>
        /// OAURAT.
        /// </summary>
        public const string OAURAT = "OAURAT";

        /// <summary>
        /// OAURAB.
        /// </summary>
        public const string OAURAB = "OAURAB";

        /// <summary>
        /// OAURRF.
        /// </summary>
        public const string OAURRF = "OAURRF";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAJOBN.
        /// </summary>
        public const string OAJOBN = "OAJOBN";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OATDAY.
        /// </summary>
        public const string OATDAY = "OATDAY";

        /// <summary>
        /// OAWAOTC.
        /// </summary>
        public const string OAWAOTC = "OAWAOTC";

        /// <summary>
        /// OAWRF.
        /// </summary>
        public const string OAWRF = "OAWRF";

        /// <summary>
        /// OAWCD.
        /// </summary>
        public const string OAWCD = "OAWCD";

        /// <summary>
        /// OAWAB.
        /// </summary>
        public const string OAWAB = "OAWAB";

        /// <summary>
        /// OAWNUM.
        /// </summary>
        public const string OAWNUM = "OAWNUM";

        /// <summary>
        /// OAWMDT.
        /// </summary>
        public const string OAWMDT = "OAWMDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B751";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OAWCFGID", "OAWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("OAWCOPCD", "OAWCOPCD", JdeDataType.String, 20),
        new JdeField("OAWBOPID", "OAWBOPID", JdeDataType.Numeric),
        new JdeField("OAWBOPCD", "OAWBOPCD", JdeDataType.String, 20),
        new JdeField("OAWFTLOC", "OAWFTLOC", JdeDataType.String, 40),
        new JdeField("OAWFTKFM", "OAWFTKFM", JdeDataType.String, 60),
        new JdeField("OAWFTKFF", "OAWFTKFF", JdeDataType.String, 2),
        new JdeField("OAWFTKVC", "OAWFTKVC", JdeDataType.Numeric),
        new JdeField("OAWTVCTY", "OAWTVCTY", JdeDataType.String, 2),
        new JdeField("OAWFTKCW", "OAWFTKCW", JdeDataType.Numeric),
        new JdeField("OAWTWCTY", "OAWTWCTY", JdeDataType.String, 2),
        new JdeField("OAWFTKCR", "OAWFTKCR", JdeDataType.Numeric),
        new JdeField("OAWTRCTY", "OAWTRCTY", JdeDataType.String, 2),
        new JdeField("OAWFUMTV", "OAWFUMTV", JdeDataType.String, 4),
        new JdeField("OAWFUMTW", "OAWFUMTW", JdeDataType.String, 4),
        new JdeField("OAWFTSTA", "OAWFTSTA", JdeDataType.String, 2),
        new JdeField("OAWFTKTC", "OAWFTKTC", JdeDataType.String, 2),
        new JdeField("OAWFTKFC", "OAWFTKFC", JdeDataType.String, 6),
        new JdeField("OAWFTKPL", "OAWFTKPL", JdeDataType.String, 2),
        new JdeField("OAWFTKHS", "OAWFTKHS", JdeDataType.String, 2),
        new JdeField("OAWFTKVS", "OAWFTKVS", JdeDataType.String, 2),
        new JdeField("OAWFBAVC", "OAWFBAVC", JdeDataType.String, 8),
        new JdeField("OAWFBCST", "OAWFBCST", JdeDataType.String, 20),
        new JdeField("OAWTTLOC", "OAWTTLOC", JdeDataType.String, 40),
        new JdeField("OAWTTKFM", "OAWTTKFM", JdeDataType.String, 60),
        new JdeField("OAWTTKFF", "OAWTTKFF", JdeDataType.String, 2),
        new JdeField("OAWTTKVC", "OAWTTKVC", JdeDataType.Numeric),
        new JdeField("OAWTTVCT", "OAWTTVCT", JdeDataType.String, 2),
        new JdeField("OAWTTKCW", "OAWTTKCW", JdeDataType.Numeric),
        new JdeField("OAWTTWCT", "OAWTTWCT", JdeDataType.String, 2),
        new JdeField("OAWTTKCR", "OAWTTKCR", JdeDataType.Numeric),
        new JdeField("OAWTTRCT", "OAWTTRCT", JdeDataType.String, 2),
        new JdeField("OAWTUMTV", "OAWTUMTV", JdeDataType.String, 4),
        new JdeField("OAWTUMTW", "OAWTUMTW", JdeDataType.String, 4),
        new JdeField("OAWTTSTA", "OAWTTSTA", JdeDataType.String, 2),
        new JdeField("OAWTTKTC", "OAWTTKTC", JdeDataType.String, 2),
        new JdeField("OAWTTKFC", "OAWTTKFC", JdeDataType.String, 6),
        new JdeField("OAWTTKPL", "OAWTTKPL", JdeDataType.String, 2),
        new JdeField("OAWTTKHS", "OAWTTKHS", JdeDataType.String, 2),
        new JdeField("OAWTTKVS", "OAWTTKVS", JdeDataType.String, 2),
        new JdeField("OAWTBAVC", "OAWTBAVC", JdeDataType.String, 8),
        new JdeField("OAWTBCST", "OAWTBCST", JdeDataType.String, 20),
        new JdeField("OAWNTKST", "OAWNTKST", JdeDataType.String, 2),
        new JdeField("OAWNTKHS", "OAWNTKHS", JdeDataType.String, 2),
        new JdeField("OAWNTKVS", "OAWNTKVS", JdeDataType.String, 2),
        new JdeField("OAWNBAVC", "OAWNBAVC", JdeDataType.String, 8),
        new JdeField("OAWFABGC", "OAWFABGC", JdeDataType.String, 80),
        new JdeField("OAWFABCS", "OAWFABCS", JdeDataType.String, 20),
        new JdeField("OAWFBTOF", "OAWFBTOF", JdeDataType.String, 2),
        new JdeField("OAWFBFOF", "OAWFBFOF", JdeDataType.String, 2),
        new JdeField("OAWFAMLT", "OAWFAMLT", JdeDataType.String, 16),
        new JdeField("OAWFBSTF", "OAWFBSTF", JdeDataType.String, 2),
        new JdeField("OAWNTTAS", "OAWNTTAS", JdeDataType.String, 2),
        new JdeField("OAWNTTHS", "OAWNTTHS", JdeDataType.String, 2),
        new JdeField("OAWNTTVS", "OAWNTTVS", JdeDataType.String, 2),
        new JdeField("OAWTABAC", "OAWTABAC", JdeDataType.String, 8),
        new JdeField("OAWTABGC", "OAWTABGC", JdeDataType.String, 80),
        new JdeField("OAWTABCS", "OAWTABCS", JdeDataType.String, 20),
        new JdeField("OAWTBTOF", "OAWTBTOF", JdeDataType.String, 2),
        new JdeField("OAWTBFOF", "OAWTBFOF", JdeDataType.String, 2),
        new JdeField("OAWTAMLT", "OAWTAMLT", JdeDataType.String, 16),
        new JdeField("OAWTBSTF", "OAWTBSTF", JdeDataType.String, 2),
        new JdeField("OAURCD", "OAURCD", JdeDataType.String, 4),
        new JdeField("OAURDT", "OAURDT", JdeDataType.Numeric),
        new JdeField("OAURAT", "OAURAT", JdeDataType.Numeric),
        new JdeField("OAURAB", "OAURAB", JdeDataType.Numeric),
        new JdeField("OAURRF", "OAURRF", JdeDataType.String, 30),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAJOBN", "OAJOBN", JdeDataType.String, 20),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OATDAY", "OATDAY", JdeDataType.Numeric),
        new JdeField("OAWAOTC", "OAWAOTC", JdeDataType.String, 2),
        new JdeField("OAWRF", "OAWRF", JdeDataType.String, 60),
        new JdeField("OAWCD", "OAWCD", JdeDataType.String, 6),
        new JdeField("OAWAB", "OAWAB", JdeDataType.Numeric),
        new JdeField("OAWNUM", "OAWNUM", JdeDataType.Numeric),
        new JdeField("OAWMDT", "OAWMDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B751_0", "Primary Key on OAWCFGID", new[] { "OAWCFGID" }, isUnique: true, isPrimaryKey: true)
    };
}
