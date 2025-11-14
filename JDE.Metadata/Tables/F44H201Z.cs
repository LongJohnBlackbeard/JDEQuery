using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H201Z - .
/// </summary>
public class F44H201Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZHBMCUS.
        /// </summary>
        public const string SZHBMCUS = "SZHBMCUS";

        /// <summary>
        /// SZHBLOT.
        /// </summary>
        public const string SZHBLOT = "SZHBLOT";

        /// <summary>
        /// SZLOTADD.
        /// </summary>
        public const string SZLOTADD = "SZLOTADD";

        /// <summary>
        /// SZCTY1.
        /// </summary>
        public const string SZCTY1 = "SZCTY1";

        /// <summary>
        /// SZADDS.
        /// </summary>
        public const string SZADDS = "SZADDS";

        /// <summary>
        /// SZADDZ.
        /// </summary>
        public const string SZADDZ = "SZADDZ";

        /// <summary>
        /// SZLOTCMT.
        /// </summary>
        public const string SZLOTCMT = "SZLOTCMT";

        /// <summary>
        /// SZCPHASE.
        /// </summary>
        public const string SZCPHASE = "SZCPHASE";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZCONSSEQ.
        /// </summary>
        public const string SZCONSSEQ = "SZCONSSEQ";

        /// <summary>
        /// SZHBAREA.
        /// </summary>
        public const string SZHBAREA = "SZHBAREA";

        /// <summary>
        /// SZHBPLAN.
        /// </summary>
        public const string SZHBPLAN = "SZHBPLAN";

        /// <summary>
        /// SZHBELEV.
        /// </summary>
        public const string SZHBELEV = "SZHBELEV";

        /// <summary>
        /// SZSWING.
        /// </summary>
        public const string SZSWING = "SZSWING";

        /// <summary>
        /// SZPSG.
        /// </summary>
        public const string SZPSG = "SZPSG";

        /// <summary>
        /// SZLSWVER.
        /// </summary>
        public const string SZLSWVER = "SZLSWVER";

        /// <summary>
        /// SZLSWPEND.
        /// </summary>
        public const string SZLSWPEND = "SZLSWPEND";

        /// <summary>
        /// SZLSTATHB.
        /// </summary>
        public const string SZLSTATHB = "SZLSTATHB";

        /// <summary>
        /// SZOSELCF.
        /// </summary>
        public const string SZOSELCF = "SZOSELCF";

        /// <summary>
        /// SZCONNXT.
        /// </summary>
        public const string SZCONNXT = "SZCONNXT";

        /// <summary>
        /// SZCONLST.
        /// </summary>
        public const string SZCONLST = "SZCONLST";

        /// <summary>
        /// SZSSACS.
        /// </summary>
        public const string SZSSACS = "SZSSACS";

        /// <summary>
        /// SZDCG.
        /// </summary>
        public const string SZDCG = "SZDCG";

        /// <summary>
        /// SZUSC.
        /// </summary>
        public const string SZUSC = "SZUSC";

        /// <summary>
        /// SZHBSCS.
        /// </summary>
        public const string SZHBSCS = "SZHBSCS";

        /// <summary>
        /// SZCSSEQ.
        /// </summary>
        public const string SZCSSEQ = "SZCSSEQ";

        /// <summary>
        /// SZBYR.
        /// </summary>
        public const string SZBYR = "SZBYR";

        /// <summary>
        /// SZMCUTJ.
        /// </summary>
        public const string SZMCUTJ = "SZMCUTJ";

        /// <summary>
        /// SZSCHTMPT.
        /// </summary>
        public const string SZSCHTMPT = "SZSCHTMPT";

        /// <summary>
        /// SZLGLLOT.
        /// </summary>
        public const string SZLGLLOT = "SZLGLLOT";

        /// <summary>
        /// SZHBBLOCK.
        /// </summary>
        public const string SZHBBLOCK = "SZHBBLOCK";

        /// <summary>
        /// SZHBTRACT.
        /// </summary>
        public const string SZHBTRACT = "SZHBTRACT";

        /// <summary>
        /// SZPARC.
        /// </summary>
        public const string SZPARC = "SZPARC";

        /// <summary>
        /// SZPARCT.
        /// </summary>
        public const string SZPARCT = "SZPARCT";

        /// <summary>
        /// SZBUILD.
        /// </summary>
        public const string SZBUILD = "SZBUILD";

        /// <summary>
        /// SZUNT3.
        /// </summary>
        public const string SZUNT3 = "SZUNT3";

        /// <summary>
        /// SZSFTL.
        /// </summary>
        public const string SZSFTL = "SZSFTL";

        /// <summary>
        /// SZWLT.
        /// </summary>
        public const string SZWLT = "SZWLT";

        /// <summary>
        /// SZDPLT.
        /// </summary>
        public const string SZDPLT = "SZDPLT";

        /// <summary>
        /// SZACLT.
        /// </summary>
        public const string SZACLT = "SZACLT";

        /// <summary>
        /// SZMDLHF.
        /// </summary>
        public const string SZMDLHF = "SZMDLHF";

        /// <summary>
        /// SZSPECHF.
        /// </summary>
        public const string SZSPECHF = "SZSPECHF";

        /// <summary>
        /// SZBSP.
        /// </summary>
        public const string SZBSP = "SZBSP";

        /// <summary>
        /// SZLTP.
        /// </summary>
        public const string SZLTP = "SZLTP";

        /// <summary>
        /// SZLPP.
        /// </summary>
        public const string SZLPP = "SZLPP";

        /// <summary>
        /// SZBLDR.
        /// </summary>
        public const string SZBLDR = "SZBLDR";

        /// <summary>
        /// SZAN8CM01.
        /// </summary>
        public const string SZAN8CM01 = "SZAN8CM01";

        /// <summary>
        /// SZPTDJ.
        /// </summary>
        public const string SZPTDJ = "SZPTDJ";

        /// <summary>
        /// SZPHD.
        /// </summary>
        public const string SZPHD = "SZPHD";

        /// <summary>
        /// SZCTYJ.
        /// </summary>
        public const string SZCTYJ = "SZCTYJ";

        /// <summary>
        /// SZPMN.
        /// </summary>
        public const string SZPMN = "SZPMN";

        /// <summary>
        /// SZPRD.
        /// </summary>
        public const string SZPRD = "SZPRD";

        /// <summary>
        /// SZCPJ.
        /// </summary>
        public const string SZCPJ = "SZCPJ";

        /// <summary>
        /// SZATFN.
        /// </summary>
        public const string SZATFN = "SZATFN";

        /// <summary>
        /// SZRLSDTE.
        /// </summary>
        public const string SZRLSDTE = "SZRLSDTE";

        /// <summary>
        /// SZCOMJ.
        /// </summary>
        public const string SZCOMJ = "SZCOMJ";

        /// <summary>
        /// SZLSRJ.
        /// </summary>
        public const string SZLSRJ = "SZLSRJ";

        /// <summary>
        /// SZLCSJ.
        /// </summary>
        public const string SZLCSJ = "SZLCSJ";

        /// <summary>
        /// SZLCCJ.
        /// </summary>
        public const string SZLCCJ = "SZLCCJ";

        /// <summary>
        /// SZUCSMSF.
        /// </summary>
        public const string SZUCSMSF = "SZUCSMSF";

        /// <summary>
        /// SZUSD1.
        /// </summary>
        public const string SZUSD1 = "SZUSD1";

        /// <summary>
        /// SZUSD2.
        /// </summary>
        public const string SZUSD2 = "SZUSD2";

        /// <summary>
        /// SZUSD3.
        /// </summary>
        public const string SZUSD3 = "SZUSD3";

        /// <summary>
        /// SZUSD4.
        /// </summary>
        public const string SZUSD4 = "SZUSD4";

        /// <summary>
        /// SZUSD5.
        /// </summary>
        public const string SZUSD5 = "SZUSD5";

        /// <summary>
        /// SZUSD6.
        /// </summary>
        public const string SZUSD6 = "SZUSD6";

        /// <summary>
        /// SZUSD7.
        /// </summary>
        public const string SZUSD7 = "SZUSD7";

        /// <summary>
        /// SZUSD8.
        /// </summary>
        public const string SZUSD8 = "SZUSD8";

        /// <summary>
        /// SZUSD9.
        /// </summary>
        public const string SZUSD9 = "SZUSD9";

        /// <summary>
        /// SZUSD10.
        /// </summary>
        public const string SZUSD10 = "SZUSD10";

        /// <summary>
        /// SZUAMT01.
        /// </summary>
        public const string SZUAMT01 = "SZUAMT01";

        /// <summary>
        /// SZUAMT02.
        /// </summary>
        public const string SZUAMT02 = "SZUAMT02";

        /// <summary>
        /// SZUAMT03.
        /// </summary>
        public const string SZUAMT03 = "SZUAMT03";

        /// <summary>
        /// SZUAMT04.
        /// </summary>
        public const string SZUAMT04 = "SZUAMT04";

        /// <summary>
        /// SZUAMT05.
        /// </summary>
        public const string SZUAMT05 = "SZUAMT05";

        /// <summary>
        /// SZUAMT06.
        /// </summary>
        public const string SZUAMT06 = "SZUAMT06";

        /// <summary>
        /// SZOA1.
        /// </summary>
        public const string SZOA1 = "SZOA1";

        /// <summary>
        /// SZOA2.
        /// </summary>
        public const string SZOA2 = "SZOA2";

        /// <summary>
        /// SZUC01.
        /// </summary>
        public const string SZUC01 = "SZUC01";

        /// <summary>
        /// SZUC02.
        /// </summary>
        public const string SZUC02 = "SZUC02";

        /// <summary>
        /// SZUC03.
        /// </summary>
        public const string SZUC03 = "SZUC03";

        /// <summary>
        /// SZUC04.
        /// </summary>
        public const string SZUC04 = "SZUC04";

        /// <summary>
        /// SZUC05.
        /// </summary>
        public const string SZUC05 = "SZUC05";

        /// <summary>
        /// SZUC06.
        /// </summary>
        public const string SZUC06 = "SZUC06";

        /// <summary>
        /// SZLCC01.
        /// </summary>
        public const string SZLCC01 = "SZLCC01";

        /// <summary>
        /// SZLCC02.
        /// </summary>
        public const string SZLCC02 = "SZLCC02";

        /// <summary>
        /// SZLCC03.
        /// </summary>
        public const string SZLCC03 = "SZLCC03";

        /// <summary>
        /// SZLCC04.
        /// </summary>
        public const string SZLCC04 = "SZLCC04";

        /// <summary>
        /// SZLCC05.
        /// </summary>
        public const string SZLCC05 = "SZLCC05";

        /// <summary>
        /// SZLCC06.
        /// </summary>
        public const string SZLCC06 = "SZLCC06";

        /// <summary>
        /// SZLCC07.
        /// </summary>
        public const string SZLCC07 = "SZLCC07";

        /// <summary>
        /// SZLCC08.
        /// </summary>
        public const string SZLCC08 = "SZLCC08";

        /// <summary>
        /// SZLCC09.
        /// </summary>
        public const string SZLCC09 = "SZLCC09";

        /// <summary>
        /// SZLCC10.
        /// </summary>
        public const string SZLCC10 = "SZLCC10";

        /// <summary>
        /// SZACCL.
        /// </summary>
        public const string SZACCL = "SZACCL";

        /// <summary>
        /// SZCLRH.
        /// </summary>
        public const string SZCLRH = "SZCLRH";

        /// <summary>
        /// SZROF.
        /// </summary>
        public const string SZROF = "SZROF";

        /// <summary>
        /// SZBDC.
        /// </summary>
        public const string SZBDC = "SZBDC";

        /// <summary>
        /// SZFSC.
        /// </summary>
        public const string SZFSC = "SZFSC";

        /// <summary>
        /// SZCLPK.
        /// </summary>
        public const string SZCLPK = "SZCLPK";

        /// <summary>
        /// SZDOC01.
        /// </summary>
        public const string SZDOC01 = "SZDOC01";

        /// <summary>
        /// SZDOC02.
        /// </summary>
        public const string SZDOC02 = "SZDOC02";

        /// <summary>
        /// SZDOC03.
        /// </summary>
        public const string SZDOC03 = "SZDOC03";

        /// <summary>
        /// SZDCT01.
        /// </summary>
        public const string SZDCT01 = "SZDCT01";

        /// <summary>
        /// SZDCT02.
        /// </summary>
        public const string SZDCT02 = "SZDCT02";

        /// <summary>
        /// SZDCT03.
        /// </summary>
        public const string SZDCT03 = "SZDCT03";

        /// <summary>
        /// SZCDJ.
        /// </summary>
        public const string SZCDJ = "SZCDJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZRLSN.
        /// </summary>
        public const string SZRLSN = "SZRLSN";

        /// <summary>
        /// SZHBST1.
        /// </summary>
        public const string SZHBST1 = "SZHBST1";

        /// <summary>
        /// SZHBST2.
        /// </summary>
        public const string SZHBST2 = "SZHBST2";

        /// <summary>
        /// SZHBST3.
        /// </summary>
        public const string SZHBST3 = "SZHBST3";

        /// <summary>
        /// SZHBST4.
        /// </summary>
        public const string SZHBST4 = "SZHBST4";

        /// <summary>
        /// SZHBST5.
        /// </summary>
        public const string SZHBST5 = "SZHBST5";

        /// <summary>
        /// SZCRTU.
        /// </summary>
        public const string SZCRTU = "SZCRTU";

        /// <summary>
        /// SZCRTJ.
        /// </summary>
        public const string SZCRTJ = "SZCRTJ";

        /// <summary>
        /// SZCRTT.
        /// </summary>
        public const string SZCRTT = "SZCRTT";

        /// <summary>
        /// SZWRKSTNID.
        /// </summary>
        public const string SZWRKSTNID = "SZWRKSTNID";

        /// <summary>
        /// SZHBOPID.
        /// </summary>
        public const string SZHBOPID = "SZHBOPID";

        /// <summary>
        /// SZUPMB.
        /// </summary>
        public const string SZUPMB = "SZUPMB";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H201Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZHBMCUS", "SZHBMCUS", JdeDataType.String, 24),
        new JdeField("SZHBLOT", "SZHBLOT", JdeDataType.String, 8),
        new JdeField("SZLOTADD", "SZLOTADD", JdeDataType.String, 80),
        new JdeField("SZCTY1", "SZCTY1", JdeDataType.String, 50),
        new JdeField("SZADDS", "SZADDS", JdeDataType.String, 6),
        new JdeField("SZADDZ", "SZADDZ", JdeDataType.String, 24),
        new JdeField("SZLOTCMT", "SZLOTCMT", JdeDataType.String, 80),
        new JdeField("SZCPHASE", "SZCPHASE", JdeDataType.String, 6),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZCONSSEQ", "SZCONSSEQ", JdeDataType.String, 6),
        new JdeField("SZHBAREA", "SZHBAREA", JdeDataType.String, 6),
        new JdeField("SZHBPLAN", "SZHBPLAN", JdeDataType.String, 8),
        new JdeField("SZHBELEV", "SZHBELEV", JdeDataType.String, 6),
        new JdeField("SZSWING", "SZSWING", JdeDataType.String, 2),
        new JdeField("SZPSG", "SZPSG", JdeDataType.Numeric),
        new JdeField("SZLSWVER", "SZLSWVER", JdeDataType.String, 20),
        new JdeField("SZLSWPEND", "SZLSWPEND", JdeDataType.String, 2),
        new JdeField("SZLSTATHB", "SZLSTATHB", JdeDataType.String, 2),
        new JdeField("SZOSELCF", "SZOSELCF", JdeDataType.String, 2),
        new JdeField("SZCONNXT", "SZCONNXT", JdeDataType.String, 6),
        new JdeField("SZCONLST", "SZCONLST", JdeDataType.String, 6),
        new JdeField("SZSSACS", "SZSSACS", JdeDataType.String, 6),
        new JdeField("SZDCG", "SZDCG", JdeDataType.Numeric),
        new JdeField("SZUSC", "SZUSC", JdeDataType.String, 20),
        new JdeField("SZHBSCS", "SZHBSCS", JdeDataType.String, 6),
        new JdeField("SZCSSEQ", "SZCSSEQ", JdeDataType.String, 6),
        new JdeField("SZBYR", "SZBYR", JdeDataType.Numeric),
        new JdeField("SZMCUTJ", "SZMCUTJ", JdeDataType.String, 24),
        new JdeField("SZSCHTMPT", "SZSCHTMPT", JdeDataType.String, 24),
        new JdeField("SZLGLLOT", "SZLGLLOT", JdeDataType.String, 24),
        new JdeField("SZHBBLOCK", "SZHBBLOCK", JdeDataType.String, 24),
        new JdeField("SZHBTRACT", "SZHBTRACT", JdeDataType.String, 24),
        new JdeField("SZPARC", "SZPARC", JdeDataType.String, 40),
        new JdeField("SZPARCT", "SZPARCT", JdeDataType.String, 40),
        new JdeField("SZBUILD", "SZBUILD", JdeDataType.String, 50),
        new JdeField("SZUNT3", "SZUNT3", JdeDataType.String, 16),
        new JdeField("SZSFTL", "SZSFTL", JdeDataType.Numeric),
        new JdeField("SZWLT", "SZWLT", JdeDataType.Numeric),
        new JdeField("SZDPLT", "SZDPLT", JdeDataType.Numeric),
        new JdeField("SZACLT", "SZACLT", JdeDataType.Numeric),
        new JdeField("SZMDLHF", "SZMDLHF", JdeDataType.String, 2),
        new JdeField("SZSPECHF", "SZSPECHF", JdeDataType.String, 2),
        new JdeField("SZBSP", "SZBSP", JdeDataType.Numeric),
        new JdeField("SZLTP", "SZLTP", JdeDataType.Numeric),
        new JdeField("SZLPP", "SZLPP", JdeDataType.Numeric),
        new JdeField("SZBLDR", "SZBLDR", JdeDataType.Numeric),
        new JdeField("SZAN8CM01", "SZAN8CM01", JdeDataType.Numeric),
        new JdeField("SZPTDJ", "SZPTDJ", JdeDataType.Numeric),
        new JdeField("SZPHD", "SZPHD", JdeDataType.Numeric),
        new JdeField("SZCTYJ", "SZCTYJ", JdeDataType.Numeric),
        new JdeField("SZPMN", "SZPMN", JdeDataType.String, 24),
        new JdeField("SZPRD", "SZPRD", JdeDataType.Numeric),
        new JdeField("SZCPJ", "SZCPJ", JdeDataType.Numeric),
        new JdeField("SZATFN", "SZATFN", JdeDataType.Numeric),
        new JdeField("SZRLSDTE", "SZRLSDTE", JdeDataType.Numeric),
        new JdeField("SZCOMJ", "SZCOMJ", JdeDataType.Numeric),
        new JdeField("SZLSRJ", "SZLSRJ", JdeDataType.Numeric),
        new JdeField("SZLCSJ", "SZLCSJ", JdeDataType.Numeric),
        new JdeField("SZLCCJ", "SZLCCJ", JdeDataType.Numeric),
        new JdeField("SZUCSMSF", "SZUCSMSF", JdeDataType.String, 2),
        new JdeField("SZUSD1", "SZUSD1", JdeDataType.Numeric),
        new JdeField("SZUSD2", "SZUSD2", JdeDataType.Numeric),
        new JdeField("SZUSD3", "SZUSD3", JdeDataType.Numeric),
        new JdeField("SZUSD4", "SZUSD4", JdeDataType.Numeric),
        new JdeField("SZUSD5", "SZUSD5", JdeDataType.Numeric),
        new JdeField("SZUSD6", "SZUSD6", JdeDataType.Numeric),
        new JdeField("SZUSD7", "SZUSD7", JdeDataType.Numeric),
        new JdeField("SZUSD8", "SZUSD8", JdeDataType.Numeric),
        new JdeField("SZUSD9", "SZUSD9", JdeDataType.Numeric),
        new JdeField("SZUSD10", "SZUSD10", JdeDataType.Numeric),
        new JdeField("SZUAMT01", "SZUAMT01", JdeDataType.Numeric),
        new JdeField("SZUAMT02", "SZUAMT02", JdeDataType.Numeric),
        new JdeField("SZUAMT03", "SZUAMT03", JdeDataType.Numeric),
        new JdeField("SZUAMT04", "SZUAMT04", JdeDataType.Numeric),
        new JdeField("SZUAMT05", "SZUAMT05", JdeDataType.Numeric),
        new JdeField("SZUAMT06", "SZUAMT06", JdeDataType.Numeric),
        new JdeField("SZOA1", "SZOA1", JdeDataType.Numeric),
        new JdeField("SZOA2", "SZOA2", JdeDataType.Numeric),
        new JdeField("SZUC01", "SZUC01", JdeDataType.String, 2),
        new JdeField("SZUC02", "SZUC02", JdeDataType.String, 2),
        new JdeField("SZUC03", "SZUC03", JdeDataType.String, 2),
        new JdeField("SZUC04", "SZUC04", JdeDataType.String, 2),
        new JdeField("SZUC05", "SZUC05", JdeDataType.String, 2),
        new JdeField("SZUC06", "SZUC06", JdeDataType.String, 2),
        new JdeField("SZLCC01", "SZLCC01", JdeDataType.String, 6),
        new JdeField("SZLCC02", "SZLCC02", JdeDataType.String, 6),
        new JdeField("SZLCC03", "SZLCC03", JdeDataType.String, 6),
        new JdeField("SZLCC04", "SZLCC04", JdeDataType.String, 6),
        new JdeField("SZLCC05", "SZLCC05", JdeDataType.String, 6),
        new JdeField("SZLCC06", "SZLCC06", JdeDataType.String, 6),
        new JdeField("SZLCC07", "SZLCC07", JdeDataType.String, 6),
        new JdeField("SZLCC08", "SZLCC08", JdeDataType.String, 6),
        new JdeField("SZLCC09", "SZLCC09", JdeDataType.String, 6),
        new JdeField("SZLCC10", "SZLCC10", JdeDataType.String, 6),
        new JdeField("SZACCL", "SZACCL", JdeDataType.String, 30),
        new JdeField("SZCLRH", "SZCLRH", JdeDataType.String, 2),
        new JdeField("SZROF", "SZROF", JdeDataType.String, 30),
        new JdeField("SZBDC", "SZBDC", JdeDataType.String, 30),
        new JdeField("SZFSC", "SZFSC", JdeDataType.String, 30),
        new JdeField("SZCLPK", "SZCLPK", JdeDataType.String, 20),
        new JdeField("SZDOC01", "SZDOC01", JdeDataType.Numeric),
        new JdeField("SZDOC02", "SZDOC02", JdeDataType.Numeric),
        new JdeField("SZDOC03", "SZDOC03", JdeDataType.Numeric),
        new JdeField("SZDCT01", "SZDCT01", JdeDataType.String, 4),
        new JdeField("SZDCT02", "SZDCT02", JdeDataType.String, 4),
        new JdeField("SZDCT03", "SZDCT03", JdeDataType.String, 4),
        new JdeField("SZCDJ", "SZCDJ", JdeDataType.Numeric),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZRLSN", "SZRLSN", JdeDataType.String, 6),
        new JdeField("SZHBST1", "SZHBST1", JdeDataType.String, 2),
        new JdeField("SZHBST2", "SZHBST2", JdeDataType.String, 2),
        new JdeField("SZHBST3", "SZHBST3", JdeDataType.String, 2),
        new JdeField("SZHBST4", "SZHBST4", JdeDataType.String, 2),
        new JdeField("SZHBST5", "SZHBST5", JdeDataType.String, 2),
        new JdeField("SZCRTU", "SZCRTU", JdeDataType.String, 20),
        new JdeField("SZCRTJ", "SZCRTJ", JdeDataType.Numeric),
        new JdeField("SZCRTT", "SZCRTT", JdeDataType.Numeric),
        new JdeField("SZWRKSTNID", "SZWRKSTNID", JdeDataType.String, 20),
        new JdeField("SZHBOPID", "SZHBOPID", JdeDataType.String, 20),
        new JdeField("SZUPMB", "SZUPMB", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H201Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H201Z_2", "Index on SZHBMCUS, SZHBLOT", new[] { "SZHBMCUS", "SZHBLOT" }),
        new JdeIndex("F44H201Z_3", "Index on SZHBMCUS, SZHBPLAN, SZHBELEV", new[] { "SZHBMCUS", "SZHBPLAN", "SZHBELEV" }),
        new JdeIndex("F44H201Z_4", "Index on SZHBMCUS, SZHBLOT, SZCSSEQ", new[] { "SZHBMCUS", "SZHBLOT", "SZCSSEQ" })
    };
}
