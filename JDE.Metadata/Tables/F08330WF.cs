using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08330WF - .
/// </summary>
public class F08330WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRAN8.
        /// </summary>
        public const string BRAN8 = "BRAN8";

        /// <summary>
        /// BRSEQ#.
        /// </summary>
        public const string BRSEQ_ = "BRSEQ#";

        /// <summary>
        /// BRSBGR.
        /// </summary>
        public const string BRSBGR = "BRSBGR";

        /// <summary>
        /// BRDL01.
        /// </summary>
        public const string BRDL01 = "BRDL01";

        /// <summary>
        /// BRPLAN.
        /// </summary>
        public const string BRPLAN = "BRPLAN";

        /// <summary>
        /// BRAOPT.
        /// </summary>
        public const string BRAOPT = "BRAOPT";

        /// <summary>
        /// BRDS50.
        /// </summary>
        public const string BRDS50 = "BRDS50";

        /// <summary>
        /// BREFT.
        /// </summary>
        public const string BREFT = "BREFT";

        /// <summary>
        /// BRPCOS.
        /// </summary>
        public const string BRPCOS = "BRPCOS";

        /// <summary>
        /// BRPCRE.
        /// </summary>
        public const string BRPCRE = "BRPCRE";

        /// <summary>
        /// BREEFC.
        /// </summary>
        public const string BREEFC = "BREEFC";

        /// <summary>
        /// BRDBEN.
        /// </summary>
        public const string BRDBEN = "BRDBEN";

        /// <summary>
        /// BRPCPF.
        /// </summary>
        public const string BRPCPF = "BRPCPF";

        /// <summary>
        /// BRCATY.
        /// </summary>
        public const string BRCATY = "BRCATY";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRUPMT.
        /// </summary>
        public const string BRUPMT = "BRUPMT";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08330WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRAN8", "BRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BRSEQ#", "BRSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("BRSBGR", "BRSBGR", JdeDataType.String, 20, true, true),
        new JdeField("BRDL01", "BRDL01", JdeDataType.String, 60),
        new JdeField("BRPLAN", "BRPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BRAOPT", "BRAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BRDS50", "BRDS50", JdeDataType.String, 100),
        new JdeField("BREFT", "BREFT", JdeDataType.Numeric, null, true, true),
        new JdeField("BRPCOS", "BRPCOS", JdeDataType.Numeric),
        new JdeField("BRPCRE", "BRPCRE", JdeDataType.Numeric),
        new JdeField("BREEFC", "BREEFC", JdeDataType.Numeric),
        new JdeField("BRDBEN", "BRDBEN", JdeDataType.String, 2),
        new JdeField("BRPCPF", "BRPCPF", JdeDataType.Numeric),
        new JdeField("BRCATY", "BRCATY", JdeDataType.String, 2),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRUPMT", "BRUPMT", JdeDataType.Numeric),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08330WF_0", "Primary Key on BRAN8, BRSEQ#, BRSBGR, BRPLAN, BRAOPT, BREFT", new[] { "BRAN8", "BRSEQ#", "BRSBGR", "BRPLAN", "BRAOPT", "BREFT" }, isUnique: true, isPrimaryKey: true)
    };
}
