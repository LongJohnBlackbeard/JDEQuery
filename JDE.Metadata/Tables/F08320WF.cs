using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08320WF - .
/// </summary>
public class F08320WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BVEVET.
        /// </summary>
        public const string BVEVET = "BVEVET";

        /// <summary>
        /// BVAN8.
        /// </summary>
        public const string BVAN8 = "BVAN8";

        /// <summary>
        /// BVSBGR.
        /// </summary>
        public const string BVSBGR = "BVSBGR";

        /// <summary>
        /// BVDL01.
        /// </summary>
        public const string BVDL01 = "BVDL01";

        /// <summary>
        /// BVSEQ#.
        /// </summary>
        public const string BVSEQ_ = "BVSEQ#";

        /// <summary>
        /// BVPLAN.
        /// </summary>
        public const string BVPLAN = "BVPLAN";

        /// <summary>
        /// BVAOPT.
        /// </summary>
        public const string BVAOPT = "BVAOPT";

        /// <summary>
        /// BVDS50.
        /// </summary>
        public const string BVDS50 = "BVDS50";

        /// <summary>
        /// BVDBEN.
        /// </summary>
        public const string BVDBEN = "BVDBEN";

        /// <summary>
        /// BVPCPF.
        /// </summary>
        public const string BVPCPF = "BVPCPF";

        /// <summary>
        /// BVEAOR.
        /// </summary>
        public const string BVEAOR = "BVEAOR";

        /// <summary>
        /// BVFDBA.
        /// </summary>
        public const string BVFDBA = "BVFDBA";

        /// <summary>
        /// BVSDBA.
        /// </summary>
        public const string BVSDBA = "BVSDBA";

        /// <summary>
        /// BVPDDP.
        /// </summary>
        public const string BVPDDP = "BVPDDP";

        /// <summary>
        /// BVPDCP.
        /// </summary>
        public const string BVPDCP = "BVPDCP";

        /// <summary>
        /// BVPCOS.
        /// </summary>
        public const string BVPCOS = "BVPCOS";

        /// <summary>
        /// BVPCRE.
        /// </summary>
        public const string BVPCRE = "BVPCRE";

        /// <summary>
        /// BVDRTM.
        /// </summary>
        public const string BVDRTM = "BVDRTM";

        /// <summary>
        /// BVBRTM.
        /// </summary>
        public const string BVBRTM = "BVBRTM";

        /// <summary>
        /// BVEFT.
        /// </summary>
        public const string BVEFT = "BVEFT";

        /// <summary>
        /// BVMANP.
        /// </summary>
        public const string BVMANP = "BVMANP";

        /// <summary>
        /// BVXDFP.
        /// </summary>
        public const string BVXDFP = "BVXDFP";

        /// <summary>
        /// BVEFTE.
        /// </summary>
        public const string BVEFTE = "BVEFTE";

        /// <summary>
        /// BVEECD.
        /// </summary>
        public const string BVEECD = "BVEECD";

        /// <summary>
        /// BVSL01.
        /// </summary>
        public const string BVSL01 = "BVSL01";

        /// <summary>
        /// BVPID.
        /// </summary>
        public const string BVPID = "BVPID";

        /// <summary>
        /// BVUPMJ.
        /// </summary>
        public const string BVUPMJ = "BVUPMJ";

        /// <summary>
        /// BVUPMT.
        /// </summary>
        public const string BVUPMT = "BVUPMT";

        /// <summary>
        /// BVUSER.
        /// </summary>
        public const string BVUSER = "BVUSER";

        /// <summary>
        /// BVJOBN.
        /// </summary>
        public const string BVJOBN = "BVJOBN";

        /// <summary>
        /// BVCATY.
        /// </summary>
        public const string BVCATY = "BVCATY";

        /// <summary>
        /// BVEEFC.
        /// </summary>
        public const string BVEEFC = "BVEEFC";
    }

    /// <inheritdoc />
    public override string TableName => "F08320WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BVEVET", "BVEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("BVAN8", "BVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BVSBGR", "BVSBGR", JdeDataType.String, 20, true, true),
        new JdeField("BVDL01", "BVDL01", JdeDataType.String, 60),
        new JdeField("BVSEQ#", "BVSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("BVPLAN", "BVPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BVAOPT", "BVAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BVDS50", "BVDS50", JdeDataType.String, 100),
        new JdeField("BVDBEN", "BVDBEN", JdeDataType.String, 2),
        new JdeField("BVPCPF", "BVPCPF", JdeDataType.Numeric),
        new JdeField("BVEAOR", "BVEAOR", JdeDataType.String, 2),
        new JdeField("BVFDBA", "BVFDBA", JdeDataType.Numeric),
        new JdeField("BVSDBA", "BVSDBA", JdeDataType.Numeric),
        new JdeField("BVPDDP", "BVPDDP", JdeDataType.Numeric),
        new JdeField("BVPDCP", "BVPDCP", JdeDataType.Numeric),
        new JdeField("BVPCOS", "BVPCOS", JdeDataType.Numeric),
        new JdeField("BVPCRE", "BVPCRE", JdeDataType.Numeric),
        new JdeField("BVDRTM", "BVDRTM", JdeDataType.Numeric),
        new JdeField("BVBRTM", "BVBRTM", JdeDataType.Numeric),
        new JdeField("BVEFT", "BVEFT", JdeDataType.Numeric),
        new JdeField("BVMANP", "BVMANP", JdeDataType.String, 2),
        new JdeField("BVXDFP", "BVXDFP", JdeDataType.String, 2),
        new JdeField("BVEFTE", "BVEFTE", JdeDataType.Numeric),
        new JdeField("BVEECD", "BVEECD", JdeDataType.String, 6),
        new JdeField("BVSL01", "BVSL01", JdeDataType.String, 2),
        new JdeField("BVPID", "BVPID", JdeDataType.String, 20),
        new JdeField("BVUPMJ", "BVUPMJ", JdeDataType.Numeric),
        new JdeField("BVUPMT", "BVUPMT", JdeDataType.Numeric),
        new JdeField("BVUSER", "BVUSER", JdeDataType.String, 20),
        new JdeField("BVJOBN", "BVJOBN", JdeDataType.String, 20),
        new JdeField("BVCATY", "BVCATY", JdeDataType.String, 2),
        new JdeField("BVEEFC", "BVEEFC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08320WF_0", "Primary Key on BVEVET, BVAN8, BVSBGR, BVSEQ#, BVPLAN, BVAOPT", new[] { "BVEVET", "BVAN8", "BVSBGR", "BVSEQ#", "BVPLAN", "BVAOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
