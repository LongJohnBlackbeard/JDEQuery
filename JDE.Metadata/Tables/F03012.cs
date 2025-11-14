using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03012 - .
/// </summary>
public class F03012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIAN8.
        /// </summary>
        public const string AIAN8 = "AIAN8";

        /// <summary>
        /// AICO.
        /// </summary>
        public const string AICO = "AICO";

        /// <summary>
        /// AIARC.
        /// </summary>
        public const string AIARC = "AIARC";

        /// <summary>
        /// AIMCUR.
        /// </summary>
        public const string AIMCUR = "AIMCUR";

        /// <summary>
        /// AIOBAR.
        /// </summary>
        public const string AIOBAR = "AIOBAR";

        /// <summary>
        /// AIAIDR.
        /// </summary>
        public const string AIAIDR = "AIAIDR";

        /// <summary>
        /// AIKCOR.
        /// </summary>
        public const string AIKCOR = "AIKCOR";

        /// <summary>
        /// AIDCAR.
        /// </summary>
        public const string AIDCAR = "AIDCAR";

        /// <summary>
        /// AIDTAR.
        /// </summary>
        public const string AIDTAR = "AIDTAR";

        /// <summary>
        /// AICRCD.
        /// </summary>
        public const string AICRCD = "AICRCD";

        /// <summary>
        /// AITXA1.
        /// </summary>
        public const string AITXA1 = "AITXA1";

        /// <summary>
        /// AIEXR1.
        /// </summary>
        public const string AIEXR1 = "AIEXR1";

        /// <summary>
        /// AIACL.
        /// </summary>
        public const string AIACL = "AIACL";

        /// <summary>
        /// AIHDAR.
        /// </summary>
        public const string AIHDAR = "AIHDAR";

        /// <summary>
        /// AITRAR.
        /// </summary>
        public const string AITRAR = "AITRAR";

        /// <summary>
        /// AISTTO.
        /// </summary>
        public const string AISTTO = "AISTTO";

        /// <summary>
        /// AIRYIN.
        /// </summary>
        public const string AIRYIN = "AIRYIN";

        /// <summary>
        /// AISTMT.
        /// </summary>
        public const string AISTMT = "AISTMT";

        /// <summary>
        /// AIARPY.
        /// </summary>
        public const string AIARPY = "AIARPY";

        /// <summary>
        /// AIATCS.
        /// </summary>
        public const string AIATCS = "AIATCS";

        /// <summary>
        /// AISITO.
        /// </summary>
        public const string AISITO = "AISITO";

        /// <summary>
        /// AISQNL.
        /// </summary>
        public const string AISQNL = "AISQNL";

        /// <summary>
        /// AIALGM.
        /// </summary>
        public const string AIALGM = "AIALGM";

        /// <summary>
        /// AICYCN.
        /// </summary>
        public const string AICYCN = "AICYCN";

        /// <summary>
        /// AIBO.
        /// </summary>
        public const string AIBO = "AIBO";

        /// <summary>
        /// AITSTA.
        /// </summary>
        public const string AITSTA = "AITSTA";

        /// <summary>
        /// AICKHC.
        /// </summary>
        public const string AICKHC = "AICKHC";

        /// <summary>
        /// AIDLC.
        /// </summary>
        public const string AIDLC = "AIDLC";

        /// <summary>
        /// AIDNLT.
        /// </summary>
        public const string AIDNLT = "AIDNLT";

        /// <summary>
        /// AIPLCR.
        /// </summary>
        public const string AIPLCR = "AIPLCR";

        /// <summary>
        /// AIRVDJ.
        /// </summary>
        public const string AIRVDJ = "AIRVDJ";

        /// <summary>
        /// AIDSO.
        /// </summary>
        public const string AIDSO = "AIDSO";

        /// <summary>
        /// AICMGR.
        /// </summary>
        public const string AICMGR = "AICMGR";

        /// <summary>
        /// AICLMG.
        /// </summary>
        public const string AICLMG = "AICLMG";

        /// <summary>
        /// AIDLQT.
        /// </summary>
        public const string AIDLQT = "AIDLQT";

        /// <summary>
        /// AIDLQJ.
        /// </summary>
        public const string AIDLQJ = "AIDLQJ";

        /// <summary>
        /// AINBRR.
        /// </summary>
        public const string AINBRR = "AINBRR";

        /// <summary>
        /// AICOLL.
        /// </summary>
        public const string AICOLL = "AICOLL";

        /// <summary>
        /// AINBR1.
        /// </summary>
        public const string AINBR1 = "AINBR1";

        /// <summary>
        /// AINBR2.
        /// </summary>
        public const string AINBR2 = "AINBR2";

        /// <summary>
        /// AINBR3.
        /// </summary>
        public const string AINBR3 = "AINBR3";

        /// <summary>
        /// AINBCL.
        /// </summary>
        public const string AINBCL = "AINBCL";

        /// <summary>
        /// AIAFC.
        /// </summary>
        public const string AIAFC = "AIAFC";

        /// <summary>
        /// AIFD.
        /// </summary>
        public const string AIFD = "AIFD";

        /// <summary>
        /// AIFP.
        /// </summary>
        public const string AIFP = "AIFP";

        /// <summary>
        /// AICFCE.
        /// </summary>
        public const string AICFCE = "AICFCE";

        /// <summary>
        /// AIAB2.
        /// </summary>
        public const string AIAB2 = "AIAB2";

        /// <summary>
        /// AIDT1J.
        /// </summary>
        public const string AIDT1J = "AIDT1J";

        /// <summary>
        /// AIDFIJ.
        /// </summary>
        public const string AIDFIJ = "AIDFIJ";

        /// <summary>
        /// AIDLIJ.
        /// </summary>
        public const string AIDLIJ = "AIDLIJ";

        /// <summary>
        /// AIABC1.
        /// </summary>
        public const string AIABC1 = "AIABC1";

        /// <summary>
        /// AIABC2.
        /// </summary>
        public const string AIABC2 = "AIABC2";

        /// <summary>
        /// AIABC3.
        /// </summary>
        public const string AIABC3 = "AIABC3";

        /// <summary>
        /// AIFNDJ.
        /// </summary>
        public const string AIFNDJ = "AIFNDJ";

        /// <summary>
        /// AIDLP.
        /// </summary>
        public const string AIDLP = "AIDLP";

        /// <summary>
        /// AIDB.
        /// </summary>
        public const string AIDB = "AIDB";

        /// <summary>
        /// AIDNBJ.
        /// </summary>
        public const string AIDNBJ = "AIDNBJ";

        /// <summary>
        /// AITRW.
        /// </summary>
        public const string AITRW = "AITRW";

        /// <summary>
        /// AITWDJ.
        /// </summary>
        public const string AITWDJ = "AITWDJ";

        /// <summary>
        /// AIAVD.
        /// </summary>
        public const string AIAVD = "AIAVD";

        /// <summary>
        /// AICRCA.
        /// </summary>
        public const string AICRCA = "AICRCA";

        /// <summary>
        /// AIAD.
        /// </summary>
        public const string AIAD = "AIAD";

        /// <summary>
        /// AIAFCP.
        /// </summary>
        public const string AIAFCP = "AIAFCP";

        /// <summary>
        /// AIAFCY.
        /// </summary>
        public const string AIAFCY = "AIAFCY";

        /// <summary>
        /// AIASTY.
        /// </summary>
        public const string AIASTY = "AIASTY";

        /// <summary>
        /// AISPYE.
        /// </summary>
        public const string AISPYE = "AISPYE";

        /// <summary>
        /// AIAHB.
        /// </summary>
        public const string AIAHB = "AIAHB";

        /// <summary>
        /// AIALP.
        /// </summary>
        public const string AIALP = "AIALP";

        /// <summary>
        /// AIABAM.
        /// </summary>
        public const string AIABAM = "AIABAM";

        /// <summary>
        /// AIABA1.
        /// </summary>
        public const string AIABA1 = "AIABA1";

        /// <summary>
        /// AIAPRC.
        /// </summary>
        public const string AIAPRC = "AIAPRC";

        /// <summary>
        /// AIMAXO.
        /// </summary>
        public const string AIMAXO = "AIMAXO";

        /// <summary>
        /// AIMINO.
        /// </summary>
        public const string AIMINO = "AIMINO";

        /// <summary>
        /// AIOYTD.
        /// </summary>
        public const string AIOYTD = "AIOYTD";

        /// <summary>
        /// AIOPY.
        /// </summary>
        public const string AIOPY = "AIOPY";

        /// <summary>
        /// AIPOPN.
        /// </summary>
        public const string AIPOPN = "AIPOPN";

        /// <summary>
        /// AIDAOJ.
        /// </summary>
        public const string AIDAOJ = "AIDAOJ";

        /// <summary>
        /// AIAN8R.
        /// </summary>
        public const string AIAN8R = "AIAN8R";

        /// <summary>
        /// AIBADT.
        /// </summary>
        public const string AIBADT = "AIBADT";

        /// <summary>
        /// AICPGP.
        /// </summary>
        public const string AICPGP = "AICPGP";

        /// <summary>
        /// AIORTP.
        /// </summary>
        public const string AIORTP = "AIORTP";

        /// <summary>
        /// AITRDC.
        /// </summary>
        public const string AITRDC = "AITRDC";

        /// <summary>
        /// AIINMG.
        /// </summary>
        public const string AIINMG = "AIINMG";

        /// <summary>
        /// AIEXHD.
        /// </summary>
        public const string AIEXHD = "AIEXHD";

        /// <summary>
        /// AIHOLD.
        /// </summary>
        public const string AIHOLD = "AIHOLD";

        /// <summary>
        /// AIROUT.
        /// </summary>
        public const string AIROUT = "AIROUT";

        /// <summary>
        /// AISTOP.
        /// </summary>
        public const string AISTOP = "AISTOP";

        /// <summary>
        /// AIZON.
        /// </summary>
        public const string AIZON = "AIZON";

        /// <summary>
        /// AICARS.
        /// </summary>
        public const string AICARS = "AICARS";

        /// <summary>
        /// AIDEL1.
        /// </summary>
        public const string AIDEL1 = "AIDEL1";

        /// <summary>
        /// AIDEL2.
        /// </summary>
        public const string AIDEL2 = "AIDEL2";

        /// <summary>
        /// AILTDT.
        /// </summary>
        public const string AILTDT = "AILTDT";

        /// <summary>
        /// AIFRTH.
        /// </summary>
        public const string AIFRTH = "AIFRTH";

        /// <summary>
        /// AIAFT.
        /// </summary>
        public const string AIAFT = "AIAFT";

        /// <summary>
        /// AIAPTS.
        /// </summary>
        public const string AIAPTS = "AIAPTS";

        /// <summary>
        /// AISBAL.
        /// </summary>
        public const string AISBAL = "AISBAL";

        /// <summary>
        /// AIBACK.
        /// </summary>
        public const string AIBACK = "AIBACK";

        /// <summary>
        /// AIPORQ.
        /// </summary>
        public const string AIPORQ = "AIPORQ";

        /// <summary>
        /// AIPRIO.
        /// </summary>
        public const string AIPRIO = "AIPRIO";

        /// <summary>
        /// AIARTO.
        /// </summary>
        public const string AIARTO = "AIARTO";

        /// <summary>
        /// AIINVC.
        /// </summary>
        public const string AIINVC = "AIINVC";

        /// <summary>
        /// AIICON.
        /// </summary>
        public const string AIICON = "AIICON";

        /// <summary>
        /// AIBLFR.
        /// </summary>
        public const string AIBLFR = "AIBLFR";

        /// <summary>
        /// AINIVD.
        /// </summary>
        public const string AINIVD = "AINIVD";

        /// <summary>
        /// AILEDJ.
        /// </summary>
        public const string AILEDJ = "AILEDJ";

        /// <summary>
        /// AIPLST.
        /// </summary>
        public const string AIPLST = "AIPLST";

        /// <summary>
        /// AIMORD.
        /// </summary>
        public const string AIMORD = "AIMORD";

        /// <summary>
        /// AICMC1.
        /// </summary>
        public const string AICMC1 = "AICMC1";

        /// <summary>
        /// AICMR1.
        /// </summary>
        public const string AICMR1 = "AICMR1";

        /// <summary>
        /// AICMC2.
        /// </summary>
        public const string AICMC2 = "AICMC2";

        /// <summary>
        /// AICMR2.
        /// </summary>
        public const string AICMR2 = "AICMR2";

        /// <summary>
        /// AIPALC.
        /// </summary>
        public const string AIPALC = "AIPALC";

        /// <summary>
        /// AIVUMD.
        /// </summary>
        public const string AIVUMD = "AIVUMD";

        /// <summary>
        /// AIWUMD.
        /// </summary>
        public const string AIWUMD = "AIWUMD";

        /// <summary>
        /// AIEDPM.
        /// </summary>
        public const string AIEDPM = "AIEDPM";

        /// <summary>
        /// AIEDII.
        /// </summary>
        public const string AIEDII = "AIEDII";

        /// <summary>
        /// AIEDCI.
        /// </summary>
        public const string AIEDCI = "AIEDCI";

        /// <summary>
        /// AIEDQD.
        /// </summary>
        public const string AIEDQD = "AIEDQD";

        /// <summary>
        /// AIEDAD.
        /// </summary>
        public const string AIEDAD = "AIEDAD";

        /// <summary>
        /// AIEDF1.
        /// </summary>
        public const string AIEDF1 = "AIEDF1";

        /// <summary>
        /// AIEDF2.
        /// </summary>
        public const string AIEDF2 = "AIEDF2";

        /// <summary>
        /// AISI01.
        /// </summary>
        public const string AISI01 = "AISI01";

        /// <summary>
        /// AISI02.
        /// </summary>
        public const string AISI02 = "AISI02";

        /// <summary>
        /// AISI03.
        /// </summary>
        public const string AISI03 = "AISI03";

        /// <summary>
        /// AISI04.
        /// </summary>
        public const string AISI04 = "AISI04";

        /// <summary>
        /// AISI05.
        /// </summary>
        public const string AISI05 = "AISI05";

        /// <summary>
        /// AIURCD.
        /// </summary>
        public const string AIURCD = "AIURCD";

        /// <summary>
        /// AIURAT.
        /// </summary>
        public const string AIURAT = "AIURAT";

        /// <summary>
        /// AIURAB.
        /// </summary>
        public const string AIURAB = "AIURAB";

        /// <summary>
        /// AIURDT.
        /// </summary>
        public const string AIURDT = "AIURDT";

        /// <summary>
        /// AIURRF.
        /// </summary>
        public const string AIURRF = "AIURRF";

        /// <summary>
        /// AICP01.
        /// </summary>
        public const string AICP01 = "AICP01";

        /// <summary>
        /// AIASN.
        /// </summary>
        public const string AIASN = "AIASN";

        /// <summary>
        /// AIDSPA.
        /// </summary>
        public const string AIDSPA = "AIDSPA";

        /// <summary>
        /// AICRMD.
        /// </summary>
        public const string AICRMD = "AICRMD";

        /// <summary>
        /// AIPLY.
        /// </summary>
        public const string AIPLY = "AIPLY";

        /// <summary>
        /// AIMAN8.
        /// </summary>
        public const string AIMAN8 = "AIMAN8";

        /// <summary>
        /// AIARL.
        /// </summary>
        public const string AIARL = "AIARL";

        /// <summary>
        /// AIAMCR.
        /// </summary>
        public const string AIAMCR = "AIAMCR";

        /// <summary>
        /// AIAC01.
        /// </summary>
        public const string AIAC01 = "AIAC01";

        /// <summary>
        /// AIAC02.
        /// </summary>
        public const string AIAC02 = "AIAC02";

        /// <summary>
        /// AIAC03.
        /// </summary>
        public const string AIAC03 = "AIAC03";

        /// <summary>
        /// AIAC04.
        /// </summary>
        public const string AIAC04 = "AIAC04";

        /// <summary>
        /// AIAC05.
        /// </summary>
        public const string AIAC05 = "AIAC05";

        /// <summary>
        /// AIAC06.
        /// </summary>
        public const string AIAC06 = "AIAC06";

        /// <summary>
        /// AIAC07.
        /// </summary>
        public const string AIAC07 = "AIAC07";

        /// <summary>
        /// AIAC08.
        /// </summary>
        public const string AIAC08 = "AIAC08";

        /// <summary>
        /// AIAC09.
        /// </summary>
        public const string AIAC09 = "AIAC09";

        /// <summary>
        /// AIAC10.
        /// </summary>
        public const string AIAC10 = "AIAC10";

        /// <summary>
        /// AIAC11.
        /// </summary>
        public const string AIAC11 = "AIAC11";

        /// <summary>
        /// AIAC12.
        /// </summary>
        public const string AIAC12 = "AIAC12";

        /// <summary>
        /// AIAC13.
        /// </summary>
        public const string AIAC13 = "AIAC13";

        /// <summary>
        /// AIAC14.
        /// </summary>
        public const string AIAC14 = "AIAC14";

        /// <summary>
        /// AIAC15.
        /// </summary>
        public const string AIAC15 = "AIAC15";

        /// <summary>
        /// AIAC16.
        /// </summary>
        public const string AIAC16 = "AIAC16";

        /// <summary>
        /// AIAC17.
        /// </summary>
        public const string AIAC17 = "AIAC17";

        /// <summary>
        /// AIAC18.
        /// </summary>
        public const string AIAC18 = "AIAC18";

        /// <summary>
        /// AIAC19.
        /// </summary>
        public const string AIAC19 = "AIAC19";

        /// <summary>
        /// AIAC20.
        /// </summary>
        public const string AIAC20 = "AIAC20";

        /// <summary>
        /// AIAC21.
        /// </summary>
        public const string AIAC21 = "AIAC21";

        /// <summary>
        /// AIAC22.
        /// </summary>
        public const string AIAC22 = "AIAC22";

        /// <summary>
        /// AIAC23.
        /// </summary>
        public const string AIAC23 = "AIAC23";

        /// <summary>
        /// AIAC24.
        /// </summary>
        public const string AIAC24 = "AIAC24";

        /// <summary>
        /// AIAC25.
        /// </summary>
        public const string AIAC25 = "AIAC25";

        /// <summary>
        /// AIAC26.
        /// </summary>
        public const string AIAC26 = "AIAC26";

        /// <summary>
        /// AIAC27.
        /// </summary>
        public const string AIAC27 = "AIAC27";

        /// <summary>
        /// AIAC28.
        /// </summary>
        public const string AIAC28 = "AIAC28";

        /// <summary>
        /// AIAC29.
        /// </summary>
        public const string AIAC29 = "AIAC29";

        /// <summary>
        /// AIAC30.
        /// </summary>
        public const string AIAC30 = "AIAC30";

        /// <summary>
        /// AISLPG.
        /// </summary>
        public const string AISLPG = "AISLPG";

        /// <summary>
        /// AISLDW.
        /// </summary>
        public const string AISLDW = "AISLDW";

        /// <summary>
        /// AICFPP.
        /// </summary>
        public const string AICFPP = "AICFPP";

        /// <summary>
        /// AICFSP.
        /// </summary>
        public const string AICFSP = "AICFSP";

        /// <summary>
        /// AICFDF.
        /// </summary>
        public const string AICFDF = "AICFDF";

        /// <summary>
        /// AIRQ01.
        /// </summary>
        public const string AIRQ01 = "AIRQ01";

        /// <summary>
        /// AIRQ02.
        /// </summary>
        public const string AIRQ02 = "AIRQ02";

        /// <summary>
        /// AIDR03.
        /// </summary>
        public const string AIDR03 = "AIDR03";

        /// <summary>
        /// AIDR04.
        /// </summary>
        public const string AIDR04 = "AIDR04";

        /// <summary>
        /// AIRQ03.
        /// </summary>
        public const string AIRQ03 = "AIRQ03";

        /// <summary>
        /// AIRQ04.
        /// </summary>
        public const string AIRQ04 = "AIRQ04";

        /// <summary>
        /// AIRQ05.
        /// </summary>
        public const string AIRQ05 = "AIRQ05";

        /// <summary>
        /// AIRQ06.
        /// </summary>
        public const string AIRQ06 = "AIRQ06";

        /// <summary>
        /// AIRQ07.
        /// </summary>
        public const string AIRQ07 = "AIRQ07";

        /// <summary>
        /// AIRQ08.
        /// </summary>
        public const string AIRQ08 = "AIRQ08";

        /// <summary>
        /// AIDR08.
        /// </summary>
        public const string AIDR08 = "AIDR08";

        /// <summary>
        /// AIDR09.
        /// </summary>
        public const string AIDR09 = "AIDR09";

        /// <summary>
        /// AIRQ09.
        /// </summary>
        public const string AIRQ09 = "AIRQ09";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIPRGF.
        /// </summary>
        public const string AIPRGF = "AIPRGF";

        /// <summary>
        /// AIBYAL.
        /// </summary>
        public const string AIBYAL = "AIBYAL";

        /// <summary>
        /// AIBSC.
        /// </summary>
        public const string AIBSC = "AIBSC";

        /// <summary>
        /// AIASHL.
        /// </summary>
        public const string AIASHL = "AIASHL";

        /// <summary>
        /// AIPRSN.
        /// </summary>
        public const string AIPRSN = "AIPRSN";

        /// <summary>
        /// AIOPBO.
        /// </summary>
        public const string AIOPBO = "AIOPBO";

        /// <summary>
        /// AIAPSB.
        /// </summary>
        public const string AIAPSB = "AIAPSB";

        /// <summary>
        /// AITIER1.
        /// </summary>
        public const string AITIER1 = "AITIER1";

        /// <summary>
        /// AIPWPCP.
        /// </summary>
        public const string AIPWPCP = "AIPWPCP";

        /// <summary>
        /// AICUSTS.
        /// </summary>
        public const string AICUSTS = "AICUSTS";

        /// <summary>
        /// AISTOF.
        /// </summary>
        public const string AISTOF = "AISTOF";

        /// <summary>
        /// AITERRID.
        /// </summary>
        public const string AITERRID = "AITERRID";

        /// <summary>
        /// AICIG.
        /// </summary>
        public const string AICIG = "AICIG";

        /// <summary>
        /// AITORG.
        /// </summary>
        public const string AITORG = "AITORG";

        /// <summary>
        /// AIDTEE.
        /// </summary>
        public const string AIDTEE = "AIDTEE";

        /// <summary>
        /// AISYNCS.
        /// </summary>
        public const string AISYNCS = "AISYNCS";

        /// <summary>
        /// AICAAD.
        /// </summary>
        public const string AICAAD = "AICAAD";

        /// <summary>
        /// AIGOPASF.
        /// </summary>
        public const string AIGOPASF = "AIGOPASF";
    }

    /// <inheritdoc />
    public override string TableName => "F03012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIAN8", "AIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AICO", "AICO", JdeDataType.String, 10, true, true),
        new JdeField("AIARC", "AIARC", JdeDataType.String, 8),
        new JdeField("AIMCUR", "AIMCUR", JdeDataType.String, 24),
        new JdeField("AIOBAR", "AIOBAR", JdeDataType.String, 12),
        new JdeField("AIAIDR", "AIAIDR", JdeDataType.String, 16),
        new JdeField("AIKCOR", "AIKCOR", JdeDataType.String, 10),
        new JdeField("AIDCAR", "AIDCAR", JdeDataType.Numeric),
        new JdeField("AIDTAR", "AIDTAR", JdeDataType.String, 4),
        new JdeField("AICRCD", "AICRCD", JdeDataType.String, 6),
        new JdeField("AITXA1", "AITXA1", JdeDataType.String, 20),
        new JdeField("AIEXR1", "AIEXR1", JdeDataType.String, 4),
        new JdeField("AIACL", "AIACL", JdeDataType.Numeric),
        new JdeField("AIHDAR", "AIHDAR", JdeDataType.String, 2),
        new JdeField("AITRAR", "AITRAR", JdeDataType.String, 6),
        new JdeField("AISTTO", "AISTTO", JdeDataType.String, 2),
        new JdeField("AIRYIN", "AIRYIN", JdeDataType.String, 2),
        new JdeField("AISTMT", "AISTMT", JdeDataType.String, 2),
        new JdeField("AIARPY", "AIARPY", JdeDataType.Numeric),
        new JdeField("AIATCS", "AIATCS", JdeDataType.String, 2),
        new JdeField("AISITO", "AISITO", JdeDataType.String, 2),
        new JdeField("AISQNL", "AISQNL", JdeDataType.String, 2),
        new JdeField("AIALGM", "AIALGM", JdeDataType.String, 4),
        new JdeField("AICYCN", "AICYCN", JdeDataType.String, 4),
        new JdeField("AIBO", "AIBO", JdeDataType.String, 2),
        new JdeField("AITSTA", "AITSTA", JdeDataType.String, 4),
        new JdeField("AICKHC", "AICKHC", JdeDataType.String, 2),
        new JdeField("AIDLC", "AIDLC", JdeDataType.Numeric),
        new JdeField("AIDNLT", "AIDNLT", JdeDataType.String, 2),
        new JdeField("AIPLCR", "AIPLCR", JdeDataType.String, 20),
        new JdeField("AIRVDJ", "AIRVDJ", JdeDataType.Numeric),
        new JdeField("AIDSO", "AIDSO", JdeDataType.Numeric),
        new JdeField("AICMGR", "AICMGR", JdeDataType.String, 20),
        new JdeField("AICLMG", "AICLMG", JdeDataType.String, 20),
        new JdeField("AIDLQT", "AIDLQT", JdeDataType.Numeric),
        new JdeField("AIDLQJ", "AIDLQJ", JdeDataType.Numeric),
        new JdeField("AINBRR", "AINBRR", JdeDataType.String, 2),
        new JdeField("AICOLL", "AICOLL", JdeDataType.String, 2),
        new JdeField("AINBR1", "AINBR1", JdeDataType.Numeric),
        new JdeField("AINBR2", "AINBR2", JdeDataType.Numeric),
        new JdeField("AINBR3", "AINBR3", JdeDataType.Numeric),
        new JdeField("AINBCL", "AINBCL", JdeDataType.Numeric),
        new JdeField("AIAFC", "AIAFC", JdeDataType.String, 2),
        new JdeField("AIFD", "AIFD", JdeDataType.Numeric),
        new JdeField("AIFP", "AIFP", JdeDataType.Numeric),
        new JdeField("AICFCE", "AICFCE", JdeDataType.String, 2),
        new JdeField("AIAB2", "AIAB2", JdeDataType.String, 2),
        new JdeField("AIDT1J", "AIDT1J", JdeDataType.Numeric),
        new JdeField("AIDFIJ", "AIDFIJ", JdeDataType.Numeric),
        new JdeField("AIDLIJ", "AIDLIJ", JdeDataType.Numeric),
        new JdeField("AIABC1", "AIABC1", JdeDataType.String, 2),
        new JdeField("AIABC2", "AIABC2", JdeDataType.String, 2),
        new JdeField("AIABC3", "AIABC3", JdeDataType.String, 2),
        new JdeField("AIFNDJ", "AIFNDJ", JdeDataType.Numeric),
        new JdeField("AIDLP", "AIDLP", JdeDataType.Numeric),
        new JdeField("AIDB", "AIDB", JdeDataType.String, 6),
        new JdeField("AIDNBJ", "AIDNBJ", JdeDataType.Numeric),
        new JdeField("AITRW", "AITRW", JdeDataType.String, 6),
        new JdeField("AITWDJ", "AITWDJ", JdeDataType.Numeric),
        new JdeField("AIAVD", "AIAVD", JdeDataType.Numeric),
        new JdeField("AICRCA", "AICRCA", JdeDataType.String, 6),
        new JdeField("AIAD", "AIAD", JdeDataType.Numeric),
        new JdeField("AIAFCP", "AIAFCP", JdeDataType.Numeric),
        new JdeField("AIAFCY", "AIAFCY", JdeDataType.Numeric),
        new JdeField("AIASTY", "AIASTY", JdeDataType.Numeric),
        new JdeField("AISPYE", "AISPYE", JdeDataType.Numeric),
        new JdeField("AIAHB", "AIAHB", JdeDataType.Numeric),
        new JdeField("AIALP", "AIALP", JdeDataType.Numeric),
        new JdeField("AIABAM", "AIABAM", JdeDataType.Numeric),
        new JdeField("AIABA1", "AIABA1", JdeDataType.Numeric),
        new JdeField("AIAPRC", "AIAPRC", JdeDataType.Numeric),
        new JdeField("AIMAXO", "AIMAXO", JdeDataType.Numeric),
        new JdeField("AIMINO", "AIMINO", JdeDataType.Numeric),
        new JdeField("AIOYTD", "AIOYTD", JdeDataType.Numeric),
        new JdeField("AIOPY", "AIOPY", JdeDataType.Numeric),
        new JdeField("AIPOPN", "AIPOPN", JdeDataType.String, 20),
        new JdeField("AIDAOJ", "AIDAOJ", JdeDataType.Numeric),
        new JdeField("AIAN8R", "AIAN8R", JdeDataType.Numeric),
        new JdeField("AIBADT", "AIBADT", JdeDataType.String, 2),
        new JdeField("AICPGP", "AICPGP", JdeDataType.String, 16),
        new JdeField("AIORTP", "AIORTP", JdeDataType.String, 16),
        new JdeField("AITRDC", "AITRDC", JdeDataType.Numeric),
        new JdeField("AIINMG", "AIINMG", JdeDataType.String, 20),
        new JdeField("AIEXHD", "AIEXHD", JdeDataType.String, 2),
        new JdeField("AIHOLD", "AIHOLD", JdeDataType.String, 4),
        new JdeField("AIROUT", "AIROUT", JdeDataType.String, 6),
        new JdeField("AISTOP", "AISTOP", JdeDataType.String, 6),
        new JdeField("AIZON", "AIZON", JdeDataType.String, 6),
        new JdeField("AICARS", "AICARS", JdeDataType.Numeric),
        new JdeField("AIDEL1", "AIDEL1", JdeDataType.String, 60),
        new JdeField("AIDEL2", "AIDEL2", JdeDataType.String, 60),
        new JdeField("AILTDT", "AILTDT", JdeDataType.Numeric),
        new JdeField("AIFRTH", "AIFRTH", JdeDataType.String, 6),
        new JdeField("AIAFT", "AIAFT", JdeDataType.String, 2),
        new JdeField("AIAPTS", "AIAPTS", JdeDataType.String, 2),
        new JdeField("AISBAL", "AISBAL", JdeDataType.String, 2),
        new JdeField("AIBACK", "AIBACK", JdeDataType.String, 2),
        new JdeField("AIPORQ", "AIPORQ", JdeDataType.String, 2),
        new JdeField("AIPRIO", "AIPRIO", JdeDataType.String, 2),
        new JdeField("AIARTO", "AIARTO", JdeDataType.String, 2),
        new JdeField("AIINVC", "AIINVC", JdeDataType.Numeric),
        new JdeField("AIICON", "AIICON", JdeDataType.String, 2),
        new JdeField("AIBLFR", "AIBLFR", JdeDataType.String, 2),
        new JdeField("AINIVD", "AINIVD", JdeDataType.Numeric),
        new JdeField("AILEDJ", "AILEDJ", JdeDataType.Numeric),
        new JdeField("AIPLST", "AIPLST", JdeDataType.String, 2),
        new JdeField("AIMORD", "AIMORD", JdeDataType.String, 2),
        new JdeField("AICMC1", "AICMC1", JdeDataType.Numeric),
        new JdeField("AICMR1", "AICMR1", JdeDataType.Numeric),
        new JdeField("AICMC2", "AICMC2", JdeDataType.Numeric),
        new JdeField("AICMR2", "AICMR2", JdeDataType.Numeric),
        new JdeField("AIPALC", "AIPALC", JdeDataType.String, 2),
        new JdeField("AIVUMD", "AIVUMD", JdeDataType.String, 4),
        new JdeField("AIWUMD", "AIWUMD", JdeDataType.String, 4),
        new JdeField("AIEDPM", "AIEDPM", JdeDataType.String, 2),
        new JdeField("AIEDII", "AIEDII", JdeDataType.String, 2),
        new JdeField("AIEDCI", "AIEDCI", JdeDataType.String, 2),
        new JdeField("AIEDQD", "AIEDQD", JdeDataType.Numeric),
        new JdeField("AIEDAD", "AIEDAD", JdeDataType.Numeric),
        new JdeField("AIEDF1", "AIEDF1", JdeDataType.String, 2),
        new JdeField("AIEDF2", "AIEDF2", JdeDataType.String, 2),
        new JdeField("AISI01", "AISI01", JdeDataType.String, 2),
        new JdeField("AISI02", "AISI02", JdeDataType.String, 2),
        new JdeField("AISI03", "AISI03", JdeDataType.String, 2),
        new JdeField("AISI04", "AISI04", JdeDataType.String, 2),
        new JdeField("AISI05", "AISI05", JdeDataType.String, 2),
        new JdeField("AIURCD", "AIURCD", JdeDataType.String, 4),
        new JdeField("AIURAT", "AIURAT", JdeDataType.Numeric),
        new JdeField("AIURAB", "AIURAB", JdeDataType.Numeric),
        new JdeField("AIURDT", "AIURDT", JdeDataType.Numeric),
        new JdeField("AIURRF", "AIURRF", JdeDataType.String, 30),
        new JdeField("AICP01", "AICP01", JdeDataType.String, 2),
        new JdeField("AIASN", "AIASN", JdeDataType.String, 16),
        new JdeField("AIDSPA", "AIDSPA", JdeDataType.String, 2),
        new JdeField("AICRMD", "AICRMD", JdeDataType.String, 2),
        new JdeField("AIPLY", "AIPLY", JdeDataType.Numeric),
        new JdeField("AIMAN8", "AIMAN8", JdeDataType.Numeric),
        new JdeField("AIARL", "AIARL", JdeDataType.String, 20),
        new JdeField("AIAMCR", "AIAMCR", JdeDataType.Numeric),
        new JdeField("AIAC01", "AIAC01", JdeDataType.String, 6),
        new JdeField("AIAC02", "AIAC02", JdeDataType.String, 6),
        new JdeField("AIAC03", "AIAC03", JdeDataType.String, 6),
        new JdeField("AIAC04", "AIAC04", JdeDataType.String, 6),
        new JdeField("AIAC05", "AIAC05", JdeDataType.String, 6),
        new JdeField("AIAC06", "AIAC06", JdeDataType.String, 6),
        new JdeField("AIAC07", "AIAC07", JdeDataType.String, 6),
        new JdeField("AIAC08", "AIAC08", JdeDataType.String, 6),
        new JdeField("AIAC09", "AIAC09", JdeDataType.String, 6),
        new JdeField("AIAC10", "AIAC10", JdeDataType.String, 6),
        new JdeField("AIAC11", "AIAC11", JdeDataType.String, 6),
        new JdeField("AIAC12", "AIAC12", JdeDataType.String, 6),
        new JdeField("AIAC13", "AIAC13", JdeDataType.String, 6),
        new JdeField("AIAC14", "AIAC14", JdeDataType.String, 6),
        new JdeField("AIAC15", "AIAC15", JdeDataType.String, 6),
        new JdeField("AIAC16", "AIAC16", JdeDataType.String, 6),
        new JdeField("AIAC17", "AIAC17", JdeDataType.String, 6),
        new JdeField("AIAC18", "AIAC18", JdeDataType.String, 6),
        new JdeField("AIAC19", "AIAC19", JdeDataType.String, 6),
        new JdeField("AIAC20", "AIAC20", JdeDataType.String, 6),
        new JdeField("AIAC21", "AIAC21", JdeDataType.String, 6),
        new JdeField("AIAC22", "AIAC22", JdeDataType.String, 6),
        new JdeField("AIAC23", "AIAC23", JdeDataType.String, 6),
        new JdeField("AIAC24", "AIAC24", JdeDataType.String, 6),
        new JdeField("AIAC25", "AIAC25", JdeDataType.String, 6),
        new JdeField("AIAC26", "AIAC26", JdeDataType.String, 6),
        new JdeField("AIAC27", "AIAC27", JdeDataType.String, 6),
        new JdeField("AIAC28", "AIAC28", JdeDataType.String, 6),
        new JdeField("AIAC29", "AIAC29", JdeDataType.String, 6),
        new JdeField("AIAC30", "AIAC30", JdeDataType.String, 6),
        new JdeField("AISLPG", "AISLPG", JdeDataType.String, 20),
        new JdeField("AISLDW", "AISLDW", JdeDataType.String, 20),
        new JdeField("AICFPP", "AICFPP", JdeDataType.String, 36),
        new JdeField("AICFSP", "AICFSP", JdeDataType.String, 36),
        new JdeField("AICFDF", "AICFDF", JdeDataType.String, 2),
        new JdeField("AIRQ01", "AIRQ01", JdeDataType.String, 2),
        new JdeField("AIRQ02", "AIRQ02", JdeDataType.String, 2),
        new JdeField("AIDR03", "AIDR03", JdeDataType.String, 4),
        new JdeField("AIDR04", "AIDR04", JdeDataType.String, 4),
        new JdeField("AIRQ03", "AIRQ03", JdeDataType.String, 2),
        new JdeField("AIRQ04", "AIRQ04", JdeDataType.String, 2),
        new JdeField("AIRQ05", "AIRQ05", JdeDataType.String, 2),
        new JdeField("AIRQ06", "AIRQ06", JdeDataType.String, 2),
        new JdeField("AIRQ07", "AIRQ07", JdeDataType.String, 2),
        new JdeField("AIRQ08", "AIRQ08", JdeDataType.String, 2),
        new JdeField("AIDR08", "AIDR08", JdeDataType.String, 4),
        new JdeField("AIDR09", "AIDR09", JdeDataType.String, 4),
        new JdeField("AIRQ09", "AIRQ09", JdeDataType.String, 2),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIPRGF", "AIPRGF", JdeDataType.String, 2),
        new JdeField("AIBYAL", "AIBYAL", JdeDataType.String, 2),
        new JdeField("AIBSC", "AIBSC", JdeDataType.String, 20),
        new JdeField("AIASHL", "AIASHL", JdeDataType.String, 2),
        new JdeField("AIPRSN", "AIPRSN", JdeDataType.String, 16),
        new JdeField("AIOPBO", "AIOPBO", JdeDataType.String, 60),
        new JdeField("AIAPSB", "AIAPSB", JdeDataType.String, 2),
        new JdeField("AITIER1", "AITIER1", JdeDataType.String, 10),
        new JdeField("AIPWPCP", "AIPWPCP", JdeDataType.Numeric),
        new JdeField("AICUSTS", "AICUSTS", JdeDataType.String, 2),
        new JdeField("AISTOF", "AISTOF", JdeDataType.String, 2),
        new JdeField("AITERRID", "AITERRID", JdeDataType.Numeric),
        new JdeField("AICIG", "AICIG", JdeDataType.Numeric),
        new JdeField("AITORG", "AITORG", JdeDataType.String, 20),
        new JdeField("AIDTEE", "AIDTEE", JdeDataType.Date),
        new JdeField("AISYNCS", "AISYNCS", JdeDataType.Numeric),
        new JdeField("AICAAD", "AICAAD", JdeDataType.Numeric),
        new JdeField("AIGOPASF", "AIGOPASF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03012_0", "Primary Key on AIAN8, AICO", new[] { "AIAN8", "AICO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03012_2", "Unique Index on AIPLY, AIAN8, AICO", new[] { "AIPLY", "AIAN8", "AICO" }, isUnique: true),
        new JdeIndex("F03012_3", "Index on AIAN8", new[] { "AIAN8" }),
        new JdeIndex("F03012_4", "Index on AICO, AIAN8", new[] { "AICO", "AIAN8" }),
        new JdeIndex("F03012_5", "Index on AICIG, AIAN8, AICO", new[] { "AICIG", "AIAN8", "AICO" }),
        new JdeIndex("F03012_6", "Index on AITERRID, AIAN8, AICO", new[] { "AITERRID", "AIAN8", "AICO" }),
        new JdeIndex("F03012_7", "Index on AICPGP, AIAC01, AIAC02, AIAC03, AIAC04, AIAC05, AIAC06, AIAC07, AIAC08, AIAC09, AIAC10, AIAC11, AIAC12, AIAC13, AIAC14, AIAC15", new[] { "AICPGP", "AIAC01", "AIAC02", "AIAC03", "AIAC04", "AIAC05", "AIAC06", "AIAC07", "AIAC08", "AIAC09", "AIAC10", "AIAC11", "AIAC12", "AIAC13", "AIAC14", "AIAC15" })
    };
}
