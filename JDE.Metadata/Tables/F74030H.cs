using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74030H - .
/// </summary>
public class F74030H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NLAN8.
        /// </summary>
        public const string NLAN8 = "NLAN8";

        /// <summary>
        /// NLBNK.
        /// </summary>
        public const string NLBNK = "NLBNK";

        /// <summary>
        /// NLCRC.
        /// </summary>
        public const string NLCRC = "NLCRC";

        /// <summary>
        /// NLBRK.
        /// </summary>
        public const string NLBRK = "NLBRK";

        /// <summary>
        /// NLBKT.
        /// </summary>
        public const string NLBKT = "NLBKT";

        /// <summary>
        /// NLDL01.
        /// </summary>
        public const string NLDL01 = "NLDL01";

        /// <summary>
        /// NLBKA.
        /// </summary>
        public const string NLBKA = "NLBKA";

        /// <summary>
        /// NLSWF.
        /// </summary>
        public const string NLSWF = "NLSWF";

        /// <summary>
        /// NLGPN.
        /// </summary>
        public const string NLGPN = "NLGPN";

        /// <summary>
        /// NLKCP.
        /// </summary>
        public const string NLKCP = "NLKCP";

        /// <summary>
        /// NLKGV.
        /// </summary>
        public const string NLKGV = "NLKGV";

        /// <summary>
        /// NLNOC.
        /// </summary>
        public const string NLNOC = "NLNOC";

        /// <summary>
        /// NLSDD.
        /// </summary>
        public const string NLSDD = "NLSDD";

        /// <summary>
        /// NLDDT.
        /// </summary>
        public const string NLDDT = "NLDDT";

        /// <summary>
        /// NLCRCD.
        /// </summary>
        public const string NLCRCD = "NLCRCD";

        /// <summary>
        /// NLSWFT.
        /// </summary>
        public const string NLSWFT = "NLSWFT";

        /// <summary>
        /// NLCSU.
        /// </summary>
        public const string NLCSU = "NLCSU";

        /// <summary>
        /// NLCCX.
        /// </summary>
        public const string NLCCX = "NLCCX";

        /// <summary>
        /// NLCVC.
        /// </summary>
        public const string NLCVC = "NLCVC";

        /// <summary>
        /// NLCB1.
        /// </summary>
        public const string NLCB1 = "NLCB1";

        /// <summary>
        /// NLCB2.
        /// </summary>
        public const string NLCB2 = "NLCB2";

        /// <summary>
        /// NLCB3.
        /// </summary>
        public const string NLCB3 = "NLCB3";

        /// <summary>
        /// NLCB4.
        /// </summary>
        public const string NLCB4 = "NLCB4";

        /// <summary>
        /// NLCGG.
        /// </summary>
        public const string NLCGG = "NLCGG";

        /// <summary>
        /// NLARTN.
        /// </summary>
        public const string NLARTN = "NLARTN";

        /// <summary>
        /// NLA1.
        /// </summary>
        public const string NLA1 = "NLA1";

        /// <summary>
        /// NLA2.
        /// </summary>
        public const string NLA2 = "NLA2";

        /// <summary>
        /// NLHAN.
        /// </summary>
        public const string NLHAN = "NLHAN";

        /// <summary>
        /// NLMTB.
        /// </summary>
        public const string NLMTB = "NLMTB";

        /// <summary>
        /// NLAGB.
        /// </summary>
        public const string NLAGB = "NLAGB";

        /// <summary>
        /// NLTTP.
        /// </summary>
        public const string NLTTP = "NLTTP";

        /// <summary>
        /// NLUSER.
        /// </summary>
        public const string NLUSER = "NLUSER";

        /// <summary>
        /// NLUPMJ.
        /// </summary>
        public const string NLUPMJ = "NLUPMJ";

        /// <summary>
        /// NLUPMT.
        /// </summary>
        public const string NLUPMT = "NLUPMT";

        /// <summary>
        /// NLPID.
        /// </summary>
        public const string NLPID = "NLPID";

        /// <summary>
        /// NLJOBN.
        /// </summary>
        public const string NLJOBN = "NLJOBN";

        /// <summary>
        /// NLUKID.
        /// </summary>
        public const string NLUKID = "NLUKID";

        /// <summary>
        /// NLACTN.
        /// </summary>
        public const string NLACTN = "NLACTN";

        /// <summary>
        /// NLSRID.
        /// </summary>
        public const string NLSRID = "NLSRID";
    }

    /// <inheritdoc />
    public override string TableName => "F74030H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NLAN8", "NLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NLBNK", "NLBNK", JdeDataType.String, 68),
        new JdeField("NLCRC", "NLCRC", JdeDataType.String, 6, true, true),
        new JdeField("NLBRK", "NLBRK", JdeDataType.String, 2),
        new JdeField("NLBKT", "NLBKT", JdeDataType.String, 2),
        new JdeField("NLDL01", "NLDL01", JdeDataType.String, 60),
        new JdeField("NLBKA", "NLBKA", JdeDataType.Numeric),
        new JdeField("NLSWF", "NLSWF", JdeDataType.String, 68),
        new JdeField("NLGPN", "NLGPN", JdeDataType.String, 2),
        new JdeField("NLKCP", "NLKCP", JdeDataType.String, 2),
        new JdeField("NLKGV", "NLKGV", JdeDataType.String, 2),
        new JdeField("NLNOC", "NLNOC", JdeDataType.String, 2),
        new JdeField("NLSDD", "NLSDD", JdeDataType.String, 6),
        new JdeField("NLDDT", "NLDDT", JdeDataType.String, 60),
        new JdeField("NLCRCD", "NLCRCD", JdeDataType.String, 6),
        new JdeField("NLSWFT", "NLSWFT", JdeDataType.String, 30),
        new JdeField("NLCSU", "NLCSU", JdeDataType.String, 2),
        new JdeField("NLCCX", "NLCCX", JdeDataType.String, 2),
        new JdeField("NLCVC", "NLCVC", JdeDataType.String, 2),
        new JdeField("NLCB1", "NLCB1", JdeDataType.String, 4),
        new JdeField("NLCB2", "NLCB2", JdeDataType.String, 4),
        new JdeField("NLCB3", "NLCB3", JdeDataType.String, 4),
        new JdeField("NLCB4", "NLCB4", JdeDataType.String, 4),
        new JdeField("NLCGG", "NLCGG", JdeDataType.String, 4),
        new JdeField("NLARTN", "NLARTN", JdeDataType.String, 4),
        new JdeField("NLA1", "NLA1", JdeDataType.String, 80),
        new JdeField("NLA2", "NLA2", JdeDataType.String, 80),
        new JdeField("NLHAN", "NLHAN", JdeDataType.String, 8),
        new JdeField("NLMTB", "NLMTB", JdeDataType.Numeric),
        new JdeField("NLAGB", "NLAGB", JdeDataType.String, 2),
        new JdeField("NLTTP", "NLTTP", JdeDataType.String, 4),
        new JdeField("NLUSER", "NLUSER", JdeDataType.String, 20),
        new JdeField("NLUPMJ", "NLUPMJ", JdeDataType.Numeric),
        new JdeField("NLUPMT", "NLUPMT", JdeDataType.Numeric),
        new JdeField("NLPID", "NLPID", JdeDataType.String, 20),
        new JdeField("NLJOBN", "NLJOBN", JdeDataType.String, 20),
        new JdeField("NLUKID", "NLUKID", JdeDataType.Numeric),
        new JdeField("NLACTN", "NLACTN", JdeDataType.String, 2),
        new JdeField("NLSRID", "NLSRID", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74030H_0", "Primary Key on NLAN8, NLCRC", new[] { "NLAN8", "NLCRC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74030H_2", "Index on NLBNK", new[] { "NLBNK" })
    };
}
