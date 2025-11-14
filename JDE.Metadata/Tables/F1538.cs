using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1538 - .
/// </summary>
public class F1538 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NZAN8.
        /// </summary>
        public const string NZAN8 = "NZAN8";

        /// <summary>
        /// NZALPH.
        /// </summary>
        public const string NZALPH = "NZALPH";

        /// <summary>
        /// NZAN8J.
        /// </summary>
        public const string NZAN8J = "NZAN8J";

        /// <summary>
        /// NZDOCO.
        /// </summary>
        public const string NZDOCO = "NZDOCO";

        /// <summary>
        /// NZICU.
        /// </summary>
        public const string NZICU = "NZICU";

        /// <summary>
        /// NZEPCL.
        /// </summary>
        public const string NZEPCL = "NZEPCL";

        /// <summary>
        /// NZEPGR.
        /// </summary>
        public const string NZEPGR = "NZEPGR";

        /// <summary>
        /// NZEPSG.
        /// </summary>
        public const string NZEPSG = "NZEPSG";

        /// <summary>
        /// NZTRBM.
        /// </summary>
        public const string NZTRBM = "NZTRBM";

        /// <summary>
        /// NZTRBY.
        /// </summary>
        public const string NZTRBY = "NZTRBY";

        /// <summary>
        /// NZTRB#.
        /// </summary>
        public const string NZTRB_ = "NZTRB#";

        /// <summary>
        /// NZTREJ.
        /// </summary>
        public const string NZTREJ = "NZTREJ";

        /// <summary>
        /// NZPTBM.
        /// </summary>
        public const string NZPTBM = "NZPTBM";

        /// <summary>
        /// NZPTBY.
        /// </summary>
        public const string NZPTBY = "NZPTBY";

        /// <summary>
        /// NZPTB#.
        /// </summary>
        public const string NZPTB_ = "NZPTB#";

        /// <summary>
        /// NZPTEM.
        /// </summary>
        public const string NZPTEM = "NZPTEM";

        /// <summary>
        /// NZPTEY.
        /// </summary>
        public const string NZPTEY = "NZPTEY";

        /// <summary>
        /// NZPTE#.
        /// </summary>
        public const string NZPTE_ = "NZPTE#";

        /// <summary>
        /// NZCLSX.
        /// </summary>
        public const string NZCLSX = "NZCLSX";

        /// <summary>
        /// NZACTX.
        /// </summary>
        public const string NZACTX = "NZACTX";

        /// <summary>
        /// NZTRNX.
        /// </summary>
        public const string NZTRNX = "NZTRNX";

        /// <summary>
        /// NZEPCP.
        /// </summary>
        public const string NZEPCP = "NZEPCP";

        /// <summary>
        /// NZADEX.
        /// </summary>
        public const string NZADEX = "NZADEX";

        /// <summary>
        /// NZBSEX.
        /// </summary>
        public const string NZBSEX = "NZBSEX";

        /// <summary>
        /// NZBPSM.
        /// </summary>
        public const string NZBPSM = "NZBPSM";

        /// <summary>
        /// NZBPSY.
        /// </summary>
        public const string NZBPSY = "NZBPSY";

        /// <summary>
        /// NZBPS#.
        /// </summary>
        public const string NZBPS_ = "NZBPS#";

        /// <summary>
        /// NZCPFC.
        /// </summary>
        public const string NZCPFC = "NZCPFC";

        /// <summary>
        /// NZCMPF.
        /// </summary>
        public const string NZCMPF = "NZCMPF";

        /// <summary>
        /// NZTOTX.
        /// </summary>
        public const string NZTOTX = "NZTOTX";

        /// <summary>
        /// NZNETX.
        /// </summary>
        public const string NZNETX = "NZNETX";

        /// <summary>
        /// NZEPOF.
        /// </summary>
        public const string NZEPOF = "NZEPOF";

        /// <summary>
        /// NZEPCD.
        /// </summary>
        public const string NZEPCD = "NZEPCD";

        /// <summary>
        /// NZECMP.
        /// </summary>
        public const string NZECMP = "NZECMP";

        /// <summary>
        /// NZDENM.
        /// </summary>
        public const string NZDENM = "NZDENM";

        /// <summary>
        /// NZSHFC.
        /// </summary>
        public const string NZSHFC = "NZSHFC";

        /// <summary>
        /// NZGRSH.
        /// </summary>
        public const string NZGRSH = "NZGRSH";

        /// <summary>
        /// NZGRPL.
        /// </summary>
        public const string NZGRPL = "NZGRPL";

        /// <summary>
        /// NZSGRL.
        /// </summary>
        public const string NZSGRL = "NZSGRL";

        /// <summary>
        /// NZSGAD.
        /// </summary>
        public const string NZSGAD = "NZSGAD";

        /// <summary>
        /// NZGRAD.
        /// </summary>
        public const string NZGRAD = "NZGRAD";

        /// <summary>
        /// NZOCRL.
        /// </summary>
        public const string NZOCRL = "NZOCRL";

        /// <summary>
        /// NZOCPB.
        /// </summary>
        public const string NZOCPB = "NZOCPB";

        /// <summary>
        /// NZOCPE.
        /// </summary>
        public const string NZOCPE = "NZOCPE";

        /// <summary>
        /// NZOCAD.
        /// </summary>
        public const string NZOCAD = "NZOCAD";

        /// <summary>
        /// NZEPLM.
        /// </summary>
        public const string NZEPLM = "NZEPLM";

        /// <summary>
        /// NZNETS.
        /// </summary>
        public const string NZNETS = "NZNETS";

        /// <summary>
        /// NZAG.
        /// </summary>
        public const string NZAG = "NZAG";

        /// <summary>
        /// NZCLSB.
        /// </summary>
        public const string NZCLSB = "NZCLSB";

        /// <summary>
        /// NZFERT.
        /// </summary>
        public const string NZFERT = "NZFERT";

        /// <summary>
        /// NZFEEA.
        /// </summary>
        public const string NZFEEA = "NZFEEA";

        /// <summary>
        /// NZGLC.
        /// </summary>
        public const string NZGLC = "NZGLC";

        /// <summary>
        /// NZSEPI.
        /// </summary>
        public const string NZSEPI = "NZSEPI";

        /// <summary>
        /// NZBCI.
        /// </summary>
        public const string NZBCI = "NZBCI";

        /// <summary>
        /// NZMCU.
        /// </summary>
        public const string NZMCU = "NZMCU";

        /// <summary>
        /// NZUNIT.
        /// </summary>
        public const string NZUNIT = "NZUNIT";

        /// <summary>
        /// NZDL01.
        /// </summary>
        public const string NZDL01 = "NZDL01";

        /// <summary>
        /// NZBRAD.
        /// </summary>
        public const string NZBRAD = "NZBRAD";

        /// <summary>
        /// NZTRAR.
        /// </summary>
        public const string NZTRAR = "NZTRAR";

        /// <summary>
        /// NZCRCD.
        /// </summary>
        public const string NZCRCD = "NZCRCD";

        /// <summary>
        /// NZTXA1.
        /// </summary>
        public const string NZTXA1 = "NZTXA1";

        /// <summary>
        /// NZEXR1.
        /// </summary>
        public const string NZEXR1 = "NZEXR1";

        /// <summary>
        /// NZFEBS.
        /// </summary>
        public const string NZFEBS = "NZFEBS";

        /// <summary>
        /// NZGPCT.
        /// </summary>
        public const string NZGPCT = "NZGPCT";

        /// <summary>
        /// NZUSER.
        /// </summary>
        public const string NZUSER = "NZUSER";

        /// <summary>
        /// NZUPMJ.
        /// </summary>
        public const string NZUPMJ = "NZUPMJ";

        /// <summary>
        /// NZPID.
        /// </summary>
        public const string NZPID = "NZPID";

        /// <summary>
        /// NZJOBN.
        /// </summary>
        public const string NZJOBN = "NZJOBN";

        /// <summary>
        /// NZREDO.
        /// </summary>
        public const string NZREDO = "NZREDO";

        /// <summary>
        /// NZCRRM.
        /// </summary>
        public const string NZCRRM = "NZCRRM";

        /// <summary>
        /// NZFAP.
        /// </summary>
        public const string NZFAP = "NZFAP";

        /// <summary>
        /// NZCDS.
        /// </summary>
        public const string NZCDS = "NZCDS";

        /// <summary>
        /// NZCDSA.
        /// </summary>
        public const string NZCDSA = "NZCDSA";

        /// <summary>
        /// NZCTAM.
        /// </summary>
        public const string NZCTAM = "NZCTAM";

        /// <summary>
        /// NZCTXA.
        /// </summary>
        public const string NZCTXA = "NZCTXA";

        /// <summary>
        /// NZCTXN.
        /// </summary>
        public const string NZCTXN = "NZCTXN";

        /// <summary>
        /// NZAAP.
        /// </summary>
        public const string NZAAP = "NZAAP";

        /// <summary>
        /// NZMSGF.
        /// </summary>
        public const string NZMSGF = "NZMSGF";

        /// <summary>
        /// NZCLAF.
        /// </summary>
        public const string NZCLAF = "NZCLAF";

        /// <summary>
        /// NZCLAA.
        /// </summary>
        public const string NZCLAA = "NZCLAA";

        /// <summary>
        /// NZCAA2.
        /// </summary>
        public const string NZCAA2 = "NZCAA2";

        /// <summary>
        /// NZBLMR.
        /// </summary>
        public const string NZBLMR = "NZBLMR";

        /// <summary>
        /// NZBLGR.
        /// </summary>
        public const string NZBLGR = "NZBLGR";

        /// <summary>
        /// NZUNGR.
        /// </summary>
        public const string NZUNGR = "NZUNGR";

        /// <summary>
        /// NZUPMT.
        /// </summary>
        public const string NZUPMT = "NZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1538";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NZAN8", "NZAN8", JdeDataType.Numeric),
        new JdeField("NZALPH", "NZALPH", JdeDataType.String, 80),
        new JdeField("NZAN8J", "NZAN8J", JdeDataType.Numeric, null, true, true),
        new JdeField("NZDOCO", "NZDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NZICU", "NZICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NZEPCL", "NZEPCL", JdeDataType.String, 8),
        new JdeField("NZEPGR", "NZEPGR", JdeDataType.String, 6),
        new JdeField("NZEPSG", "NZEPSG", JdeDataType.String, 6),
        new JdeField("NZTRBM", "NZTRBM", JdeDataType.Numeric),
        new JdeField("NZTRBY", "NZTRBY", JdeDataType.Numeric),
        new JdeField("NZTRB#", "NZTRB#", JdeDataType.Numeric),
        new JdeField("NZTREJ", "NZTREJ", JdeDataType.Numeric),
        new JdeField("NZPTBM", "NZPTBM", JdeDataType.Numeric),
        new JdeField("NZPTBY", "NZPTBY", JdeDataType.Numeric),
        new JdeField("NZPTB#", "NZPTB#", JdeDataType.Numeric),
        new JdeField("NZPTEM", "NZPTEM", JdeDataType.Numeric),
        new JdeField("NZPTEY", "NZPTEY", JdeDataType.Numeric),
        new JdeField("NZPTE#", "NZPTE#", JdeDataType.Numeric),
        new JdeField("NZCLSX", "NZCLSX", JdeDataType.Numeric),
        new JdeField("NZACTX", "NZACTX", JdeDataType.Numeric),
        new JdeField("NZTRNX", "NZTRNX", JdeDataType.Numeric),
        new JdeField("NZEPCP", "NZEPCP", JdeDataType.Numeric),
        new JdeField("NZADEX", "NZADEX", JdeDataType.Numeric),
        new JdeField("NZBSEX", "NZBSEX", JdeDataType.Numeric),
        new JdeField("NZBPSM", "NZBPSM", JdeDataType.Numeric),
        new JdeField("NZBPSY", "NZBPSY", JdeDataType.Numeric),
        new JdeField("NZBPS#", "NZBPS#", JdeDataType.Numeric),
        new JdeField("NZCPFC", "NZCPFC", JdeDataType.Numeric),
        new JdeField("NZCMPF", "NZCMPF", JdeDataType.Numeric),
        new JdeField("NZTOTX", "NZTOTX", JdeDataType.Numeric),
        new JdeField("NZNETX", "NZNETX", JdeDataType.Numeric),
        new JdeField("NZEPOF", "NZEPOF", JdeDataType.Numeric),
        new JdeField("NZEPCD", "NZEPCD", JdeDataType.String, 4),
        new JdeField("NZECMP", "NZECMP", JdeDataType.String, 2),
        new JdeField("NZDENM", "NZDENM", JdeDataType.Numeric),
        new JdeField("NZSHFC", "NZSHFC", JdeDataType.Numeric),
        new JdeField("NZGRSH", "NZGRSH", JdeDataType.Numeric),
        new JdeField("NZGRPL", "NZGRPL", JdeDataType.Numeric),
        new JdeField("NZSGRL", "NZSGRL", JdeDataType.Numeric),
        new JdeField("NZSGAD", "NZSGAD", JdeDataType.Numeric),
        new JdeField("NZGRAD", "NZGRAD", JdeDataType.Numeric),
        new JdeField("NZOCRL", "NZOCRL", JdeDataType.String, 2),
        new JdeField("NZOCPB", "NZOCPB", JdeDataType.Numeric),
        new JdeField("NZOCPE", "NZOCPE", JdeDataType.Numeric),
        new JdeField("NZOCAD", "NZOCAD", JdeDataType.Numeric),
        new JdeField("NZEPLM", "NZEPLM", JdeDataType.Numeric),
        new JdeField("NZNETS", "NZNETS", JdeDataType.Numeric),
        new JdeField("NZAG", "NZAG", JdeDataType.Numeric),
        new JdeField("NZCLSB", "NZCLSB", JdeDataType.Numeric),
        new JdeField("NZFERT", "NZFERT", JdeDataType.Numeric),
        new JdeField("NZFEEA", "NZFEEA", JdeDataType.Numeric),
        new JdeField("NZGLC", "NZGLC", JdeDataType.String, 8),
        new JdeField("NZSEPI", "NZSEPI", JdeDataType.String, 2, true, true),
        new JdeField("NZBCI", "NZBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NZMCU", "NZMCU", JdeDataType.String, 24),
        new JdeField("NZUNIT", "NZUNIT", JdeDataType.String, 16),
        new JdeField("NZDL01", "NZDL01", JdeDataType.String, 60),
        new JdeField("NZBRAD", "NZBRAD", JdeDataType.String, 8),
        new JdeField("NZTRAR", "NZTRAR", JdeDataType.String, 6),
        new JdeField("NZCRCD", "NZCRCD", JdeDataType.String, 6),
        new JdeField("NZTXA1", "NZTXA1", JdeDataType.String, 20),
        new JdeField("NZEXR1", "NZEXR1", JdeDataType.String, 4),
        new JdeField("NZFEBS", "NZFEBS", JdeDataType.String, 2),
        new JdeField("NZGPCT", "NZGPCT", JdeDataType.Numeric),
        new JdeField("NZUSER", "NZUSER", JdeDataType.String, 20),
        new JdeField("NZUPMJ", "NZUPMJ", JdeDataType.Numeric),
        new JdeField("NZPID", "NZPID", JdeDataType.String, 20),
        new JdeField("NZJOBN", "NZJOBN", JdeDataType.String, 20),
        new JdeField("NZREDO", "NZREDO", JdeDataType.String, 2),
        new JdeField("NZCRRM", "NZCRRM", JdeDataType.String, 2),
        new JdeField("NZFAP", "NZFAP", JdeDataType.Numeric),
        new JdeField("NZCDS", "NZCDS", JdeDataType.Numeric),
        new JdeField("NZCDSA", "NZCDSA", JdeDataType.Numeric),
        new JdeField("NZCTAM", "NZCTAM", JdeDataType.Numeric),
        new JdeField("NZCTXA", "NZCTXA", JdeDataType.Numeric),
        new JdeField("NZCTXN", "NZCTXN", JdeDataType.Numeric),
        new JdeField("NZAAP", "NZAAP", JdeDataType.Numeric),
        new JdeField("NZMSGF", "NZMSGF", JdeDataType.String, 2),
        new JdeField("NZCLAF", "NZCLAF", JdeDataType.Numeric),
        new JdeField("NZCLAA", "NZCLAA", JdeDataType.Numeric),
        new JdeField("NZCAA2", "NZCAA2", JdeDataType.Numeric),
        new JdeField("NZBLMR", "NZBLMR", JdeDataType.String, 2),
        new JdeField("NZBLGR", "NZBLGR", JdeDataType.String, 24),
        new JdeField("NZUNGR", "NZUNGR", JdeDataType.String, 2),
        new JdeField("NZUPMT", "NZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1538_0", "Primary Key on NZICU, NZDOCO, NZSEPI, NZAN8J, NZBCI", new[] { "NZICU", "NZDOCO", "NZSEPI", "NZAN8J", "NZBCI" }, isUnique: true, isPrimaryKey: true)
    };
}
