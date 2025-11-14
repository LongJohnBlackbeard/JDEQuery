using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H201H - .
/// </summary>
public class F44H201H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMHBMCUS.
        /// </summary>
        public const string LMHBMCUS = "LMHBMCUS";

        /// <summary>
        /// LMHBLOT.
        /// </summary>
        public const string LMHBLOT = "LMHBLOT";

        /// <summary>
        /// LMLHSEQ.
        /// </summary>
        public const string LMLHSEQ = "LMLHSEQ";

        /// <summary>
        /// LMLOTADD.
        /// </summary>
        public const string LMLOTADD = "LMLOTADD";

        /// <summary>
        /// LMCTY1.
        /// </summary>
        public const string LMCTY1 = "LMCTY1";

        /// <summary>
        /// LMADDS.
        /// </summary>
        public const string LMADDS = "LMADDS";

        /// <summary>
        /// LMADDZ.
        /// </summary>
        public const string LMADDZ = "LMADDZ";

        /// <summary>
        /// LMLOTCMT.
        /// </summary>
        public const string LMLOTCMT = "LMLOTCMT";

        /// <summary>
        /// LMCPHASE.
        /// </summary>
        public const string LMCPHASE = "LMCPHASE";

        /// <summary>
        /// LMMCU.
        /// </summary>
        public const string LMMCU = "LMMCU";

        /// <summary>
        /// LMCONSSEQ.
        /// </summary>
        public const string LMCONSSEQ = "LMCONSSEQ";

        /// <summary>
        /// LMHBAREA.
        /// </summary>
        public const string LMHBAREA = "LMHBAREA";

        /// <summary>
        /// LMHBPLAN.
        /// </summary>
        public const string LMHBPLAN = "LMHBPLAN";

        /// <summary>
        /// LMHBELEV.
        /// </summary>
        public const string LMHBELEV = "LMHBELEV";

        /// <summary>
        /// LMSWING.
        /// </summary>
        public const string LMSWING = "LMSWING";

        /// <summary>
        /// LMPSG.
        /// </summary>
        public const string LMPSG = "LMPSG";

        /// <summary>
        /// LMLSWVER.
        /// </summary>
        public const string LMLSWVER = "LMLSWVER";

        /// <summary>
        /// LMLSWPEND.
        /// </summary>
        public const string LMLSWPEND = "LMLSWPEND";

        /// <summary>
        /// LMLSTATHB.
        /// </summary>
        public const string LMLSTATHB = "LMLSTATHB";

        /// <summary>
        /// LMOSELCF.
        /// </summary>
        public const string LMOSELCF = "LMOSELCF";

        /// <summary>
        /// LMCONNXT.
        /// </summary>
        public const string LMCONNXT = "LMCONNXT";

        /// <summary>
        /// LMCONLST.
        /// </summary>
        public const string LMCONLST = "LMCONLST";

        /// <summary>
        /// LMSSACS.
        /// </summary>
        public const string LMSSACS = "LMSSACS";

        /// <summary>
        /// LMDCG.
        /// </summary>
        public const string LMDCG = "LMDCG";

        /// <summary>
        /// LMUSC.
        /// </summary>
        public const string LMUSC = "LMUSC";

        /// <summary>
        /// LMHBSCS.
        /// </summary>
        public const string LMHBSCS = "LMHBSCS";

        /// <summary>
        /// LMCSSEQ.
        /// </summary>
        public const string LMCSSEQ = "LMCSSEQ";

        /// <summary>
        /// LMBYR.
        /// </summary>
        public const string LMBYR = "LMBYR";

        /// <summary>
        /// LMMCUTJ.
        /// </summary>
        public const string LMMCUTJ = "LMMCUTJ";

        /// <summary>
        /// LMSCHTMPT.
        /// </summary>
        public const string LMSCHTMPT = "LMSCHTMPT";

        /// <summary>
        /// LMLGLLOT.
        /// </summary>
        public const string LMLGLLOT = "LMLGLLOT";

        /// <summary>
        /// LMHBBLOCK.
        /// </summary>
        public const string LMHBBLOCK = "LMHBBLOCK";

        /// <summary>
        /// LMHBTRACT.
        /// </summary>
        public const string LMHBTRACT = "LMHBTRACT";

        /// <summary>
        /// LMPARC.
        /// </summary>
        public const string LMPARC = "LMPARC";

        /// <summary>
        /// LMPARCT.
        /// </summary>
        public const string LMPARCT = "LMPARCT";

        /// <summary>
        /// LMBUILD.
        /// </summary>
        public const string LMBUILD = "LMBUILD";

        /// <summary>
        /// LMUNT3.
        /// </summary>
        public const string LMUNT3 = "LMUNT3";

        /// <summary>
        /// LMSFTL.
        /// </summary>
        public const string LMSFTL = "LMSFTL";

        /// <summary>
        /// LMWLT.
        /// </summary>
        public const string LMWLT = "LMWLT";

        /// <summary>
        /// LMDPLT.
        /// </summary>
        public const string LMDPLT = "LMDPLT";

        /// <summary>
        /// LMACLT.
        /// </summary>
        public const string LMACLT = "LMACLT";

        /// <summary>
        /// LMMDLHF.
        /// </summary>
        public const string LMMDLHF = "LMMDLHF";

        /// <summary>
        /// LMSPECHF.
        /// </summary>
        public const string LMSPECHF = "LMSPECHF";

        /// <summary>
        /// LMBSP.
        /// </summary>
        public const string LMBSP = "LMBSP";

        /// <summary>
        /// LMLTP.
        /// </summary>
        public const string LMLTP = "LMLTP";

        /// <summary>
        /// LMLPP.
        /// </summary>
        public const string LMLPP = "LMLPP";

        /// <summary>
        /// LMBLDR.
        /// </summary>
        public const string LMBLDR = "LMBLDR";

        /// <summary>
        /// LMAN8CM01.
        /// </summary>
        public const string LMAN8CM01 = "LMAN8CM01";

        /// <summary>
        /// LMPTDJ.
        /// </summary>
        public const string LMPTDJ = "LMPTDJ";

        /// <summary>
        /// LMPHD.
        /// </summary>
        public const string LMPHD = "LMPHD";

        /// <summary>
        /// LMCTYJ.
        /// </summary>
        public const string LMCTYJ = "LMCTYJ";

        /// <summary>
        /// LMPMN.
        /// </summary>
        public const string LMPMN = "LMPMN";

        /// <summary>
        /// LMPRD.
        /// </summary>
        public const string LMPRD = "LMPRD";

        /// <summary>
        /// LMCPJ.
        /// </summary>
        public const string LMCPJ = "LMCPJ";

        /// <summary>
        /// LMATFN.
        /// </summary>
        public const string LMATFN = "LMATFN";

        /// <summary>
        /// LMRLSDTE.
        /// </summary>
        public const string LMRLSDTE = "LMRLSDTE";

        /// <summary>
        /// LMCOMJ.
        /// </summary>
        public const string LMCOMJ = "LMCOMJ";

        /// <summary>
        /// LMLSRJ.
        /// </summary>
        public const string LMLSRJ = "LMLSRJ";

        /// <summary>
        /// LMLCSJ.
        /// </summary>
        public const string LMLCSJ = "LMLCSJ";

        /// <summary>
        /// LMLCCJ.
        /// </summary>
        public const string LMLCCJ = "LMLCCJ";

        /// <summary>
        /// LMUCSMSF.
        /// </summary>
        public const string LMUCSMSF = "LMUCSMSF";

        /// <summary>
        /// LMUSD1.
        /// </summary>
        public const string LMUSD1 = "LMUSD1";

        /// <summary>
        /// LMUSD2.
        /// </summary>
        public const string LMUSD2 = "LMUSD2";

        /// <summary>
        /// LMUSD3.
        /// </summary>
        public const string LMUSD3 = "LMUSD3";

        /// <summary>
        /// LMUSD4.
        /// </summary>
        public const string LMUSD4 = "LMUSD4";

        /// <summary>
        /// LMUSD5.
        /// </summary>
        public const string LMUSD5 = "LMUSD5";

        /// <summary>
        /// LMUSD6.
        /// </summary>
        public const string LMUSD6 = "LMUSD6";

        /// <summary>
        /// LMUSD7.
        /// </summary>
        public const string LMUSD7 = "LMUSD7";

        /// <summary>
        /// LMUSD8.
        /// </summary>
        public const string LMUSD8 = "LMUSD8";

        /// <summary>
        /// LMUSD9.
        /// </summary>
        public const string LMUSD9 = "LMUSD9";

        /// <summary>
        /// LMUSD10.
        /// </summary>
        public const string LMUSD10 = "LMUSD10";

        /// <summary>
        /// LMUAMT01.
        /// </summary>
        public const string LMUAMT01 = "LMUAMT01";

        /// <summary>
        /// LMUAMT02.
        /// </summary>
        public const string LMUAMT02 = "LMUAMT02";

        /// <summary>
        /// LMUAMT03.
        /// </summary>
        public const string LMUAMT03 = "LMUAMT03";

        /// <summary>
        /// LMUAMT04.
        /// </summary>
        public const string LMUAMT04 = "LMUAMT04";

        /// <summary>
        /// LMUAMT05.
        /// </summary>
        public const string LMUAMT05 = "LMUAMT05";

        /// <summary>
        /// LMUAMT06.
        /// </summary>
        public const string LMUAMT06 = "LMUAMT06";

        /// <summary>
        /// LMOA1.
        /// </summary>
        public const string LMOA1 = "LMOA1";

        /// <summary>
        /// LMOA2.
        /// </summary>
        public const string LMOA2 = "LMOA2";

        /// <summary>
        /// LMUC01.
        /// </summary>
        public const string LMUC01 = "LMUC01";

        /// <summary>
        /// LMUC02.
        /// </summary>
        public const string LMUC02 = "LMUC02";

        /// <summary>
        /// LMUC03.
        /// </summary>
        public const string LMUC03 = "LMUC03";

        /// <summary>
        /// LMUC04.
        /// </summary>
        public const string LMUC04 = "LMUC04";

        /// <summary>
        /// LMUC05.
        /// </summary>
        public const string LMUC05 = "LMUC05";

        /// <summary>
        /// LMUC06.
        /// </summary>
        public const string LMUC06 = "LMUC06";

        /// <summary>
        /// LMLCC01.
        /// </summary>
        public const string LMLCC01 = "LMLCC01";

        /// <summary>
        /// LMLCC02.
        /// </summary>
        public const string LMLCC02 = "LMLCC02";

        /// <summary>
        /// LMLCC03.
        /// </summary>
        public const string LMLCC03 = "LMLCC03";

        /// <summary>
        /// LMLCC04.
        /// </summary>
        public const string LMLCC04 = "LMLCC04";

        /// <summary>
        /// LMLCC05.
        /// </summary>
        public const string LMLCC05 = "LMLCC05";

        /// <summary>
        /// LMLCC06.
        /// </summary>
        public const string LMLCC06 = "LMLCC06";

        /// <summary>
        /// LMLCC07.
        /// </summary>
        public const string LMLCC07 = "LMLCC07";

        /// <summary>
        /// LMLCC08.
        /// </summary>
        public const string LMLCC08 = "LMLCC08";

        /// <summary>
        /// LMLCC09.
        /// </summary>
        public const string LMLCC09 = "LMLCC09";

        /// <summary>
        /// LMLCC10.
        /// </summary>
        public const string LMLCC10 = "LMLCC10";

        /// <summary>
        /// LMACCL.
        /// </summary>
        public const string LMACCL = "LMACCL";

        /// <summary>
        /// LMCLRH.
        /// </summary>
        public const string LMCLRH = "LMCLRH";

        /// <summary>
        /// LMROF.
        /// </summary>
        public const string LMROF = "LMROF";

        /// <summary>
        /// LMBDC.
        /// </summary>
        public const string LMBDC = "LMBDC";

        /// <summary>
        /// LMFSC.
        /// </summary>
        public const string LMFSC = "LMFSC";

        /// <summary>
        /// LMCLPK.
        /// </summary>
        public const string LMCLPK = "LMCLPK";

        /// <summary>
        /// LMDOC01.
        /// </summary>
        public const string LMDOC01 = "LMDOC01";

        /// <summary>
        /// LMDOC02.
        /// </summary>
        public const string LMDOC02 = "LMDOC02";

        /// <summary>
        /// LMDOC03.
        /// </summary>
        public const string LMDOC03 = "LMDOC03";

        /// <summary>
        /// LMDCT01.
        /// </summary>
        public const string LMDCT01 = "LMDCT01";

        /// <summary>
        /// LMDCT02.
        /// </summary>
        public const string LMDCT02 = "LMDCT02";

        /// <summary>
        /// LMDCT03.
        /// </summary>
        public const string LMDCT03 = "LMDCT03";

        /// <summary>
        /// LMCDJ.
        /// </summary>
        public const string LMCDJ = "LMCDJ";

        /// <summary>
        /// LMSUB.
        /// </summary>
        public const string LMSUB = "LMSUB";

        /// <summary>
        /// LMCO.
        /// </summary>
        public const string LMCO = "LMCO";

        /// <summary>
        /// LMRLSN.
        /// </summary>
        public const string LMRLSN = "LMRLSN";

        /// <summary>
        /// LMHBST1.
        /// </summary>
        public const string LMHBST1 = "LMHBST1";

        /// <summary>
        /// LMHBST2.
        /// </summary>
        public const string LMHBST2 = "LMHBST2";

        /// <summary>
        /// LMHBST3.
        /// </summary>
        public const string LMHBST3 = "LMHBST3";

        /// <summary>
        /// LMHBST4.
        /// </summary>
        public const string LMHBST4 = "LMHBST4";

        /// <summary>
        /// LMHBST5.
        /// </summary>
        public const string LMHBST5 = "LMHBST5";

        /// <summary>
        /// LMCRTU.
        /// </summary>
        public const string LMCRTU = "LMCRTU";

        /// <summary>
        /// LMCRTJ.
        /// </summary>
        public const string LMCRTJ = "LMCRTJ";

        /// <summary>
        /// LMCRTT.
        /// </summary>
        public const string LMCRTT = "LMCRTT";

        /// <summary>
        /// LMWRKSTNID.
        /// </summary>
        public const string LMWRKSTNID = "LMWRKSTNID";

        /// <summary>
        /// LMHBOPID.
        /// </summary>
        public const string LMHBOPID = "LMHBOPID";

        /// <summary>
        /// LMUPMB.
        /// </summary>
        public const string LMUPMB = "LMUPMB";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMUPMT.
        /// </summary>
        public const string LMUPMT = "LMUPMT";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H201H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMHBMCUS", "LMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("LMHBLOT", "LMHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("LMLHSEQ", "LMLHSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LMLOTADD", "LMLOTADD", JdeDataType.String, 80),
        new JdeField("LMCTY1", "LMCTY1", JdeDataType.String, 50),
        new JdeField("LMADDS", "LMADDS", JdeDataType.String, 6),
        new JdeField("LMADDZ", "LMADDZ", JdeDataType.String, 24),
        new JdeField("LMLOTCMT", "LMLOTCMT", JdeDataType.String, 80),
        new JdeField("LMCPHASE", "LMCPHASE", JdeDataType.String, 6),
        new JdeField("LMMCU", "LMMCU", JdeDataType.String, 24),
        new JdeField("LMCONSSEQ", "LMCONSSEQ", JdeDataType.String, 6),
        new JdeField("LMHBAREA", "LMHBAREA", JdeDataType.String, 6),
        new JdeField("LMHBPLAN", "LMHBPLAN", JdeDataType.String, 8),
        new JdeField("LMHBELEV", "LMHBELEV", JdeDataType.String, 6),
        new JdeField("LMSWING", "LMSWING", JdeDataType.String, 2),
        new JdeField("LMPSG", "LMPSG", JdeDataType.Numeric),
        new JdeField("LMLSWVER", "LMLSWVER", JdeDataType.String, 20),
        new JdeField("LMLSWPEND", "LMLSWPEND", JdeDataType.String, 2),
        new JdeField("LMLSTATHB", "LMLSTATHB", JdeDataType.String, 2),
        new JdeField("LMOSELCF", "LMOSELCF", JdeDataType.String, 2),
        new JdeField("LMCONNXT", "LMCONNXT", JdeDataType.String, 6),
        new JdeField("LMCONLST", "LMCONLST", JdeDataType.String, 6),
        new JdeField("LMSSACS", "LMSSACS", JdeDataType.String, 6),
        new JdeField("LMDCG", "LMDCG", JdeDataType.Numeric),
        new JdeField("LMUSC", "LMUSC", JdeDataType.String, 20),
        new JdeField("LMHBSCS", "LMHBSCS", JdeDataType.String, 6),
        new JdeField("LMCSSEQ", "LMCSSEQ", JdeDataType.String, 6),
        new JdeField("LMBYR", "LMBYR", JdeDataType.Numeric),
        new JdeField("LMMCUTJ", "LMMCUTJ", JdeDataType.String, 24),
        new JdeField("LMSCHTMPT", "LMSCHTMPT", JdeDataType.String, 24),
        new JdeField("LMLGLLOT", "LMLGLLOT", JdeDataType.String, 24),
        new JdeField("LMHBBLOCK", "LMHBBLOCK", JdeDataType.String, 24),
        new JdeField("LMHBTRACT", "LMHBTRACT", JdeDataType.String, 24),
        new JdeField("LMPARC", "LMPARC", JdeDataType.String, 40),
        new JdeField("LMPARCT", "LMPARCT", JdeDataType.String, 40),
        new JdeField("LMBUILD", "LMBUILD", JdeDataType.String, 50),
        new JdeField("LMUNT3", "LMUNT3", JdeDataType.String, 16),
        new JdeField("LMSFTL", "LMSFTL", JdeDataType.Numeric),
        new JdeField("LMWLT", "LMWLT", JdeDataType.Numeric),
        new JdeField("LMDPLT", "LMDPLT", JdeDataType.Numeric),
        new JdeField("LMACLT", "LMACLT", JdeDataType.Numeric),
        new JdeField("LMMDLHF", "LMMDLHF", JdeDataType.String, 2),
        new JdeField("LMSPECHF", "LMSPECHF", JdeDataType.String, 2),
        new JdeField("LMBSP", "LMBSP", JdeDataType.Numeric),
        new JdeField("LMLTP", "LMLTP", JdeDataType.Numeric),
        new JdeField("LMLPP", "LMLPP", JdeDataType.Numeric),
        new JdeField("LMBLDR", "LMBLDR", JdeDataType.Numeric),
        new JdeField("LMAN8CM01", "LMAN8CM01", JdeDataType.Numeric),
        new JdeField("LMPTDJ", "LMPTDJ", JdeDataType.Numeric),
        new JdeField("LMPHD", "LMPHD", JdeDataType.Numeric),
        new JdeField("LMCTYJ", "LMCTYJ", JdeDataType.Numeric),
        new JdeField("LMPMN", "LMPMN", JdeDataType.String, 24),
        new JdeField("LMPRD", "LMPRD", JdeDataType.Numeric),
        new JdeField("LMCPJ", "LMCPJ", JdeDataType.Numeric),
        new JdeField("LMATFN", "LMATFN", JdeDataType.Numeric),
        new JdeField("LMRLSDTE", "LMRLSDTE", JdeDataType.Numeric),
        new JdeField("LMCOMJ", "LMCOMJ", JdeDataType.Numeric),
        new JdeField("LMLSRJ", "LMLSRJ", JdeDataType.Numeric),
        new JdeField("LMLCSJ", "LMLCSJ", JdeDataType.Numeric),
        new JdeField("LMLCCJ", "LMLCCJ", JdeDataType.Numeric),
        new JdeField("LMUCSMSF", "LMUCSMSF", JdeDataType.String, 2),
        new JdeField("LMUSD1", "LMUSD1", JdeDataType.Numeric),
        new JdeField("LMUSD2", "LMUSD2", JdeDataType.Numeric),
        new JdeField("LMUSD3", "LMUSD3", JdeDataType.Numeric),
        new JdeField("LMUSD4", "LMUSD4", JdeDataType.Numeric),
        new JdeField("LMUSD5", "LMUSD5", JdeDataType.Numeric),
        new JdeField("LMUSD6", "LMUSD6", JdeDataType.Numeric),
        new JdeField("LMUSD7", "LMUSD7", JdeDataType.Numeric),
        new JdeField("LMUSD8", "LMUSD8", JdeDataType.Numeric),
        new JdeField("LMUSD9", "LMUSD9", JdeDataType.Numeric),
        new JdeField("LMUSD10", "LMUSD10", JdeDataType.Numeric),
        new JdeField("LMUAMT01", "LMUAMT01", JdeDataType.Numeric),
        new JdeField("LMUAMT02", "LMUAMT02", JdeDataType.Numeric),
        new JdeField("LMUAMT03", "LMUAMT03", JdeDataType.Numeric),
        new JdeField("LMUAMT04", "LMUAMT04", JdeDataType.Numeric),
        new JdeField("LMUAMT05", "LMUAMT05", JdeDataType.Numeric),
        new JdeField("LMUAMT06", "LMUAMT06", JdeDataType.Numeric),
        new JdeField("LMOA1", "LMOA1", JdeDataType.Numeric),
        new JdeField("LMOA2", "LMOA2", JdeDataType.Numeric),
        new JdeField("LMUC01", "LMUC01", JdeDataType.String, 2),
        new JdeField("LMUC02", "LMUC02", JdeDataType.String, 2),
        new JdeField("LMUC03", "LMUC03", JdeDataType.String, 2),
        new JdeField("LMUC04", "LMUC04", JdeDataType.String, 2),
        new JdeField("LMUC05", "LMUC05", JdeDataType.String, 2),
        new JdeField("LMUC06", "LMUC06", JdeDataType.String, 2),
        new JdeField("LMLCC01", "LMLCC01", JdeDataType.String, 6),
        new JdeField("LMLCC02", "LMLCC02", JdeDataType.String, 6),
        new JdeField("LMLCC03", "LMLCC03", JdeDataType.String, 6),
        new JdeField("LMLCC04", "LMLCC04", JdeDataType.String, 6),
        new JdeField("LMLCC05", "LMLCC05", JdeDataType.String, 6),
        new JdeField("LMLCC06", "LMLCC06", JdeDataType.String, 6),
        new JdeField("LMLCC07", "LMLCC07", JdeDataType.String, 6),
        new JdeField("LMLCC08", "LMLCC08", JdeDataType.String, 6),
        new JdeField("LMLCC09", "LMLCC09", JdeDataType.String, 6),
        new JdeField("LMLCC10", "LMLCC10", JdeDataType.String, 6),
        new JdeField("LMACCL", "LMACCL", JdeDataType.String, 30),
        new JdeField("LMCLRH", "LMCLRH", JdeDataType.String, 2),
        new JdeField("LMROF", "LMROF", JdeDataType.String, 30),
        new JdeField("LMBDC", "LMBDC", JdeDataType.String, 30),
        new JdeField("LMFSC", "LMFSC", JdeDataType.String, 30),
        new JdeField("LMCLPK", "LMCLPK", JdeDataType.String, 20),
        new JdeField("LMDOC01", "LMDOC01", JdeDataType.Numeric),
        new JdeField("LMDOC02", "LMDOC02", JdeDataType.Numeric),
        new JdeField("LMDOC03", "LMDOC03", JdeDataType.Numeric),
        new JdeField("LMDCT01", "LMDCT01", JdeDataType.String, 4),
        new JdeField("LMDCT02", "LMDCT02", JdeDataType.String, 4),
        new JdeField("LMDCT03", "LMDCT03", JdeDataType.String, 4),
        new JdeField("LMCDJ", "LMCDJ", JdeDataType.Numeric),
        new JdeField("LMSUB", "LMSUB", JdeDataType.String, 16),
        new JdeField("LMCO", "LMCO", JdeDataType.String, 10),
        new JdeField("LMRLSN", "LMRLSN", JdeDataType.String, 6),
        new JdeField("LMHBST1", "LMHBST1", JdeDataType.String, 2),
        new JdeField("LMHBST2", "LMHBST2", JdeDataType.String, 2),
        new JdeField("LMHBST3", "LMHBST3", JdeDataType.String, 2),
        new JdeField("LMHBST4", "LMHBST4", JdeDataType.String, 2),
        new JdeField("LMHBST5", "LMHBST5", JdeDataType.String, 2),
        new JdeField("LMCRTU", "LMCRTU", JdeDataType.String, 20),
        new JdeField("LMCRTJ", "LMCRTJ", JdeDataType.Numeric),
        new JdeField("LMCRTT", "LMCRTT", JdeDataType.Numeric),
        new JdeField("LMWRKSTNID", "LMWRKSTNID", JdeDataType.String, 20),
        new JdeField("LMHBOPID", "LMHBOPID", JdeDataType.String, 20),
        new JdeField("LMUPMB", "LMUPMB", JdeDataType.String, 20),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMUPMT", "LMUPMT", JdeDataType.Numeric),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H201H_0", "Primary Key on LMHBMCUS, LMHBLOT, LMLHSEQ", new[] { "LMHBMCUS", "LMHBLOT", "LMLHSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
