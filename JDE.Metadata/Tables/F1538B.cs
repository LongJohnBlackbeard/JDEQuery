using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1538B - .
/// </summary>
public class F1538B : JdeTable
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
        /// NZLSVR.
        /// </summary>
        public const string NZLSVR = "NZLSVR";

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
        /// NZBCI3.
        /// </summary>
        public const string NZBCI3 = "NZBCI3";

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
        /// NZPPUP.
        /// </summary>
        public const string NZPPUP = "NZPPUP";

        /// <summary>
        /// NZEPCN.
        /// </summary>
        public const string NZEPCN = "NZEPCN";

        /// <summary>
        /// NZEPLN.
        /// </summary>
        public const string NZEPLN = "NZEPLN";

        /// <summary>
        /// NZBALN.
        /// </summary>
        public const string NZBALN = "NZBALN";

        /// <summary>
        /// NZBALX.
        /// </summary>
        public const string NZBALX = "NZBALX";

        /// <summary>
        /// NZBANC.
        /// </summary>
        public const string NZBANC = "NZBANC";

        /// <summary>
        /// NZBAXC.
        /// </summary>
        public const string NZBAXC = "NZBAXC";

        /// <summary>
        /// NZBYCN.
        /// </summary>
        public const string NZBYCN = "NZBYCN";

        /// <summary>
        /// NZBYCX.
        /// </summary>
        public const string NZBYCX = "NZBYCX";

        /// <summary>
        /// NZBYLN.
        /// </summary>
        public const string NZBYLN = "NZBYLN";

        /// <summary>
        /// NZBYLX.
        /// </summary>
        public const string NZBYLX = "NZBYLX";

        /// <summary>
        /// NZEPCC.
        /// </summary>
        public const string NZEPCC = "NZEPCC";

        /// <summary>
        /// NZCTCN.
        /// </summary>
        public const string NZCTCN = "NZCTCN";

        /// <summary>
        /// NZCTCX.
        /// </summary>
        public const string NZCTCX = "NZCTCX";

        /// <summary>
        /// NZCTLN.
        /// </summary>
        public const string NZCTLN = "NZCTLN";

        /// <summary>
        /// NZCTLX.
        /// </summary>
        public const string NZCTLX = "NZCTLX";

        /// <summary>
        /// NZURCD.
        /// </summary>
        public const string NZURCD = "NZURCD";

        /// <summary>
        /// NZURDT.
        /// </summary>
        public const string NZURDT = "NZURDT";

        /// <summary>
        /// NZURAT.
        /// </summary>
        public const string NZURAT = "NZURAT";

        /// <summary>
        /// NZURAB.
        /// </summary>
        public const string NZURAB = "NZURAB";

        /// <summary>
        /// NZURRF.
        /// </summary>
        public const string NZURRF = "NZURRF";

        /// <summary>
        /// NZUSER.
        /// </summary>
        public const string NZUSER = "NZUSER";

        /// <summary>
        /// NZPID.
        /// </summary>
        public const string NZPID = "NZPID";

        /// <summary>
        /// NZUPMJ.
        /// </summary>
        public const string NZUPMJ = "NZUPMJ";

        /// <summary>
        /// NZUPMT.
        /// </summary>
        public const string NZUPMT = "NZUPMT";

        /// <summary>
        /// NZJOBN.
        /// </summary>
        public const string NZJOBN = "NZJOBN";

        /// <summary>
        /// NZEACN.
        /// </summary>
        public const string NZEACN = "NZEACN";

        /// <summary>
        /// NZEACM.
        /// </summary>
        public const string NZEACM = "NZEACM";

        /// <summary>
        /// NZEALN.
        /// </summary>
        public const string NZEALN = "NZEALN";

        /// <summary>
        /// NZEALM.
        /// </summary>
        public const string NZEALM = "NZEALM";

        /// <summary>
        /// NZTEXR.
        /// </summary>
        public const string NZTEXR = "NZTEXR";

        /// <summary>
        /// NZCPVA.
        /// </summary>
        public const string NZCPVA = "NZCPVA";

        /// <summary>
        /// NZSFDN.
        /// </summary>
        public const string NZSFDN = "NZSFDN";

        /// <summary>
        /// NZEXCV.
        /// </summary>
        public const string NZEXCV = "NZEXCV";

        /// <summary>
        /// NZCAPA.
        /// </summary>
        public const string NZCAPA = "NZCAPA";

        /// <summary>
        /// NZCRR.
        /// </summary>
        public const string NZCRR = "NZCRR";

        /// <summary>
        /// NZACR.
        /// </summary>
        public const string NZACR = "NZACR";

        /// <summary>
        /// NZCAPID.
        /// </summary>
        public const string NZCAPID = "NZCAPID";

        /// <summary>
        /// NZCAPIDC.
        /// </summary>
        public const string NZCAPIDC = "NZCAPIDC";

        /// <summary>
        /// NZCAPPCT.
        /// </summary>
        public const string NZCAPPCT = "NZCAPPCT";

        /// <summary>
        /// NZCAPPCTC.
        /// </summary>
        public const string NZCAPPCTC = "NZCAPPCTC";

        /// <summary>
        /// NZCAPAMT.
        /// </summary>
        public const string NZCAPAMT = "NZCAPAMT";

        /// <summary>
        /// NZCAPAMTC.
        /// </summary>
        public const string NZCAPAMTC = "NZCAPAMTC";

        /// <summary>
        /// NZACTAMT.
        /// </summary>
        public const string NZACTAMT = "NZACTAMT";

        /// <summary>
        /// NZACTAMTC.
        /// </summary>
        public const string NZACTAMTC = "NZACTAMTC";

        /// <summary>
        /// NZEXSTCAP.
        /// </summary>
        public const string NZEXSTCAP = "NZEXSTCAP";

        /// <summary>
        /// NZEXSTCAPC.
        /// </summary>
        public const string NZEXSTCAPC = "NZEXSTCAPC";

        /// <summary>
        /// NZEXNOCAP.
        /// </summary>
        public const string NZEXNOCAP = "NZEXNOCAP";

        /// <summary>
        /// NZEXNOCAPC.
        /// </summary>
        public const string NZEXNOCAPC = "NZEXNOCAPC";

        /// <summary>
        /// NZCAPADJ.
        /// </summary>
        public const string NZCAPADJ = "NZCAPADJ";

        /// <summary>
        /// NZCAPADJC.
        /// </summary>
        public const string NZCAPADJC = "NZCAPADJC";

        /// <summary>
        /// NZOCGUA.
        /// </summary>
        public const string NZOCGUA = "NZOCGUA";

        /// <summary>
        /// NZEXREDST.
        /// </summary>
        public const string NZEXREDST = "NZEXREDST";

        /// <summary>
        /// NZBILLRAT.
        /// </summary>
        public const string NZBILLRAT = "NZBILLRAT";

        /// <summary>
        /// NZBSEXG.
        /// </summary>
        public const string NZBSEXG = "NZBSEXG";

        /// <summary>
        /// NZCOMADJ.
        /// </summary>
        public const string NZCOMADJ = "NZCOMADJ";

        /// <summary>
        /// NZCLAFAMT.
        /// </summary>
        public const string NZCLAFAMT = "NZCLAFAMT";

        /// <summary>
        /// NZRFREC.
        /// </summary>
        public const string NZRFREC = "NZRFREC";

        /// <summary>
        /// NZRFRECC.
        /// </summary>
        public const string NZRFRECC = "NZRFRECC";

        /// <summary>
        /// NZGLMD.
        /// </summary>
        public const string NZGLMD = "NZGLMD";

        /// <summary>
        /// NZPOCPCT.
        /// </summary>
        public const string NZPOCPCT = "NZPOCPCT";

        /// <summary>
        /// NZEOCPCT.
        /// </summary>
        public const string NZEOCPCT = "NZEOCPCT";

        /// <summary>
        /// NZFEEA2.
        /// </summary>
        public const string NZFEEA2 = "NZFEEA2";

        /// <summary>
        /// NZFEEA3.
        /// </summary>
        public const string NZFEEA3 = "NZFEEA3";

        /// <summary>
        /// NZBEXUOM.
        /// </summary>
        public const string NZBEXUOM = "NZBEXUOM";

        /// <summary>
        /// NZORDNUM.
        /// </summary>
        public const string NZORDNUM = "NZORDNUM";

        /// <summary>
        /// NZLTGRP.
        /// </summary>
        public const string NZLTGRP = "NZLTGRP";

        /// <summary>
        /// NZAECBF.
        /// </summary>
        public const string NZAECBF = "NZAECBF";

        /// <summary>
        /// NZALCBF.
        /// </summary>
        public const string NZALCBF = "NZALCBF";

        /// <summary>
        /// NZACTADJ.
        /// </summary>
        public const string NZACTADJ = "NZACTADJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1538B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NZAN8", "NZAN8", JdeDataType.Numeric),
        new JdeField("NZALPH", "NZALPH", JdeDataType.String, 80),
        new JdeField("NZAN8J", "NZAN8J", JdeDataType.Numeric),
        new JdeField("NZDOCO", "NZDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NZLSVR", "NZLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NZICU", "NZICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NZEPCL", "NZEPCL", JdeDataType.String, 8, true, true),
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
        new JdeField("NZSEPI", "NZSEPI", JdeDataType.String, 2),
        new JdeField("NZBCI", "NZBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NZBCI3", "NZBCI3", JdeDataType.Numeric),
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
        new JdeField("NZPPUP", "NZPPUP", JdeDataType.String, 2),
        new JdeField("NZEPCN", "NZEPCN", JdeDataType.Numeric),
        new JdeField("NZEPLN", "NZEPLN", JdeDataType.Numeric),
        new JdeField("NZBALN", "NZBALN", JdeDataType.Numeric),
        new JdeField("NZBALX", "NZBALX", JdeDataType.Numeric),
        new JdeField("NZBANC", "NZBANC", JdeDataType.Numeric),
        new JdeField("NZBAXC", "NZBAXC", JdeDataType.Numeric),
        new JdeField("NZBYCN", "NZBYCN", JdeDataType.Numeric),
        new JdeField("NZBYCX", "NZBYCX", JdeDataType.Numeric),
        new JdeField("NZBYLN", "NZBYLN", JdeDataType.Numeric),
        new JdeField("NZBYLX", "NZBYLX", JdeDataType.Numeric),
        new JdeField("NZEPCC", "NZEPCC", JdeDataType.String, 2),
        new JdeField("NZCTCN", "NZCTCN", JdeDataType.String, 2),
        new JdeField("NZCTCX", "NZCTCX", JdeDataType.String, 2),
        new JdeField("NZCTLN", "NZCTLN", JdeDataType.String, 2),
        new JdeField("NZCTLX", "NZCTLX", JdeDataType.String, 2),
        new JdeField("NZURCD", "NZURCD", JdeDataType.String, 4),
        new JdeField("NZURDT", "NZURDT", JdeDataType.Numeric),
        new JdeField("NZURAT", "NZURAT", JdeDataType.Numeric),
        new JdeField("NZURAB", "NZURAB", JdeDataType.Numeric),
        new JdeField("NZURRF", "NZURRF", JdeDataType.String, 30),
        new JdeField("NZUSER", "NZUSER", JdeDataType.String, 20),
        new JdeField("NZPID", "NZPID", JdeDataType.String, 20),
        new JdeField("NZUPMJ", "NZUPMJ", JdeDataType.Numeric),
        new JdeField("NZUPMT", "NZUPMT", JdeDataType.Numeric),
        new JdeField("NZJOBN", "NZJOBN", JdeDataType.String, 20),
        new JdeField("NZEACN", "NZEACN", JdeDataType.Numeric),
        new JdeField("NZEACM", "NZEACM", JdeDataType.Numeric),
        new JdeField("NZEALN", "NZEALN", JdeDataType.Numeric),
        new JdeField("NZEALM", "NZEALM", JdeDataType.Numeric),
        new JdeField("NZTEXR", "NZTEXR", JdeDataType.String, 20),
        new JdeField("NZCPVA", "NZCPVA", JdeDataType.Numeric),
        new JdeField("NZSFDN", "NZSFDN", JdeDataType.String, 20),
        new JdeField("NZEXCV", "NZEXCV", JdeDataType.Numeric),
        new JdeField("NZCAPA", "NZCAPA", JdeDataType.Numeric),
        new JdeField("NZCRR", "NZCRR", JdeDataType.Numeric),
        new JdeField("NZACR", "NZACR", JdeDataType.Numeric),
        new JdeField("NZCAPID", "NZCAPID", JdeDataType.String, 20),
        new JdeField("NZCAPIDC", "NZCAPIDC", JdeDataType.String, 20),
        new JdeField("NZCAPPCT", "NZCAPPCT", JdeDataType.Numeric),
        new JdeField("NZCAPPCTC", "NZCAPPCTC", JdeDataType.Numeric),
        new JdeField("NZCAPAMT", "NZCAPAMT", JdeDataType.Numeric),
        new JdeField("NZCAPAMTC", "NZCAPAMTC", JdeDataType.Numeric),
        new JdeField("NZACTAMT", "NZACTAMT", JdeDataType.Numeric),
        new JdeField("NZACTAMTC", "NZACTAMTC", JdeDataType.Numeric),
        new JdeField("NZEXSTCAP", "NZEXSTCAP", JdeDataType.Numeric),
        new JdeField("NZEXSTCAPC", "NZEXSTCAPC", JdeDataType.Numeric),
        new JdeField("NZEXNOCAP", "NZEXNOCAP", JdeDataType.Numeric),
        new JdeField("NZEXNOCAPC", "NZEXNOCAPC", JdeDataType.Numeric),
        new JdeField("NZCAPADJ", "NZCAPADJ", JdeDataType.Numeric),
        new JdeField("NZCAPADJC", "NZCAPADJC", JdeDataType.Numeric),
        new JdeField("NZOCGUA", "NZOCGUA", JdeDataType.Numeric),
        new JdeField("NZEXREDST", "NZEXREDST", JdeDataType.Numeric),
        new JdeField("NZBILLRAT", "NZBILLRAT", JdeDataType.Numeric),
        new JdeField("NZBSEXG", "NZBSEXG", JdeDataType.String, 20),
        new JdeField("NZCOMADJ", "NZCOMADJ", JdeDataType.Numeric),
        new JdeField("NZCLAFAMT", "NZCLAFAMT", JdeDataType.Numeric),
        new JdeField("NZRFREC", "NZRFREC", JdeDataType.Numeric),
        new JdeField("NZRFRECC", "NZRFRECC", JdeDataType.Numeric),
        new JdeField("NZGLMD", "NZGLMD", JdeDataType.String, 2),
        new JdeField("NZPOCPCT", "NZPOCPCT", JdeDataType.Numeric),
        new JdeField("NZEOCPCT", "NZEOCPCT", JdeDataType.Numeric),
        new JdeField("NZFEEA2", "NZFEEA2", JdeDataType.Numeric),
        new JdeField("NZFEEA3", "NZFEEA3", JdeDataType.Numeric),
        new JdeField("NZBEXUOM", "NZBEXUOM", JdeDataType.Numeric),
        new JdeField("NZORDNUM", "NZORDNUM", JdeDataType.Numeric),
        new JdeField("NZLTGRP", "NZLTGRP", JdeDataType.String, 30),
        new JdeField("NZAECBF", "NZAECBF", JdeDataType.String, 2),
        new JdeField("NZALCBF", "NZALCBF", JdeDataType.String, 2),
        new JdeField("NZACTADJ", "NZACTADJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1538B_0", "Primary Key on NZICU, NZDOCO, NZLSVR, NZEPCL, NZBCI", new[] { "NZICU", "NZDOCO", "NZLSVR", "NZEPCL", "NZBCI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1538B_2", "Index on NZICU, NZDOCO, NZLSVR, NZSEPI, NZAN8J", new[] { "NZICU", "NZDOCO", "NZLSVR", "NZSEPI", "NZAN8J" }),
        new JdeIndex("F1538B_3", "Index on NZICU, NZDOCO, NZLSVR, NZEPGR, NZEPSG", new[] { "NZICU", "NZDOCO", "NZLSVR", "NZEPGR", "NZEPSG" })
    };
}
