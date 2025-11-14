using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0911Z1 - .
/// </summary>
public class F0911Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VNEDUS.
        /// </summary>
        public const string VNEDUS = "VNEDUS";

        /// <summary>
        /// VNEDTY.
        /// </summary>
        public const string VNEDTY = "VNEDTY";

        /// <summary>
        /// VNEDSQ.
        /// </summary>
        public const string VNEDSQ = "VNEDSQ";

        /// <summary>
        /// VNEDTN.
        /// </summary>
        public const string VNEDTN = "VNEDTN";

        /// <summary>
        /// VNEDCT.
        /// </summary>
        public const string VNEDCT = "VNEDCT";

        /// <summary>
        /// VNEDLN.
        /// </summary>
        public const string VNEDLN = "VNEDLN";

        /// <summary>
        /// VNEDTS.
        /// </summary>
        public const string VNEDTS = "VNEDTS";

        /// <summary>
        /// VNEDFT.
        /// </summary>
        public const string VNEDFT = "VNEDFT";

        /// <summary>
        /// VNEDDT.
        /// </summary>
        public const string VNEDDT = "VNEDDT";

        /// <summary>
        /// VNEDER.
        /// </summary>
        public const string VNEDER = "VNEDER";

        /// <summary>
        /// VNEDDL.
        /// </summary>
        public const string VNEDDL = "VNEDDL";

        /// <summary>
        /// VNEDSP.
        /// </summary>
        public const string VNEDSP = "VNEDSP";

        /// <summary>
        /// VNEDTC.
        /// </summary>
        public const string VNEDTC = "VNEDTC";

        /// <summary>
        /// VNEDTR.
        /// </summary>
        public const string VNEDTR = "VNEDTR";

        /// <summary>
        /// VNEDBT.
        /// </summary>
        public const string VNEDBT = "VNEDBT";

        /// <summary>
        /// VNEDGL.
        /// </summary>
        public const string VNEDGL = "VNEDGL";

        /// <summary>
        /// VNEDAN.
        /// </summary>
        public const string VNEDAN = "VNEDAN";

        /// <summary>
        /// VNKCO.
        /// </summary>
        public const string VNKCO = "VNKCO";

        /// <summary>
        /// VNDCT.
        /// </summary>
        public const string VNDCT = "VNDCT";

        /// <summary>
        /// VNDOC.
        /// </summary>
        public const string VNDOC = "VNDOC";

        /// <summary>
        /// VNDGJ.
        /// </summary>
        public const string VNDGJ = "VNDGJ";

        /// <summary>
        /// VNJELN.
        /// </summary>
        public const string VNJELN = "VNJELN";

        /// <summary>
        /// VNEXTL.
        /// </summary>
        public const string VNEXTL = "VNEXTL";

        /// <summary>
        /// VNPOST.
        /// </summary>
        public const string VNPOST = "VNPOST";

        /// <summary>
        /// VNICU.
        /// </summary>
        public const string VNICU = "VNICU";

        /// <summary>
        /// VNICUT.
        /// </summary>
        public const string VNICUT = "VNICUT";

        /// <summary>
        /// VNDICJ.
        /// </summary>
        public const string VNDICJ = "VNDICJ";

        /// <summary>
        /// VNDSYJ.
        /// </summary>
        public const string VNDSYJ = "VNDSYJ";

        /// <summary>
        /// VNTICU.
        /// </summary>
        public const string VNTICU = "VNTICU";

        /// <summary>
        /// VNCO.
        /// </summary>
        public const string VNCO = "VNCO";

        /// <summary>
        /// VNANI.
        /// </summary>
        public const string VNANI = "VNANI";

        /// <summary>
        /// VNAM.
        /// </summary>
        public const string VNAM = "VNAM";

        /// <summary>
        /// VNAID.
        /// </summary>
        public const string VNAID = "VNAID";

        /// <summary>
        /// VNMCU.
        /// </summary>
        public const string VNMCU = "VNMCU";

        /// <summary>
        /// VNOBJ.
        /// </summary>
        public const string VNOBJ = "VNOBJ";

        /// <summary>
        /// VNSUB.
        /// </summary>
        public const string VNSUB = "VNSUB";

        /// <summary>
        /// VNSBL.
        /// </summary>
        public const string VNSBL = "VNSBL";

        /// <summary>
        /// VNSBLT.
        /// </summary>
        public const string VNSBLT = "VNSBLT";

        /// <summary>
        /// VNLT.
        /// </summary>
        public const string VNLT = "VNLT";

        /// <summary>
        /// VNPN.
        /// </summary>
        public const string VNPN = "VNPN";

        /// <summary>
        /// VNCTRY.
        /// </summary>
        public const string VNCTRY = "VNCTRY";

        /// <summary>
        /// VNFY.
        /// </summary>
        public const string VNFY = "VNFY";

        /// <summary>
        /// VNFQ.
        /// </summary>
        public const string VNFQ = "VNFQ";

        /// <summary>
        /// VNCRCD.
        /// </summary>
        public const string VNCRCD = "VNCRCD";

        /// <summary>
        /// VNCRR.
        /// </summary>
        public const string VNCRR = "VNCRR";

        /// <summary>
        /// VNHCRR.
        /// </summary>
        public const string VNHCRR = "VNHCRR";

        /// <summary>
        /// VNHDGJ.
        /// </summary>
        public const string VNHDGJ = "VNHDGJ";

        /// <summary>
        /// VNAA.
        /// </summary>
        public const string VNAA = "VNAA";

        /// <summary>
        /// VNU.
        /// </summary>
        public const string VNU = "VNU";

        /// <summary>
        /// VNUM.
        /// </summary>
        public const string VNUM = "VNUM";

        /// <summary>
        /// VNGLC.
        /// </summary>
        public const string VNGLC = "VNGLC";

        /// <summary>
        /// VNRE.
        /// </summary>
        public const string VNRE = "VNRE";

        /// <summary>
        /// VNEXA.
        /// </summary>
        public const string VNEXA = "VNEXA";

        /// <summary>
        /// VNEXR.
        /// </summary>
        public const string VNEXR = "VNEXR";

        /// <summary>
        /// VNR1.
        /// </summary>
        public const string VNR1 = "VNR1";

        /// <summary>
        /// VNR2.
        /// </summary>
        public const string VNR2 = "VNR2";

        /// <summary>
        /// VNR3.
        /// </summary>
        public const string VNR3 = "VNR3";

        /// <summary>
        /// VNSFX.
        /// </summary>
        public const string VNSFX = "VNSFX";

        /// <summary>
        /// VNODOC.
        /// </summary>
        public const string VNODOC = "VNODOC";

        /// <summary>
        /// VNODCT.
        /// </summary>
        public const string VNODCT = "VNODCT";

        /// <summary>
        /// VNOSFX.
        /// </summary>
        public const string VNOSFX = "VNOSFX";

        /// <summary>
        /// VNPKCO.
        /// </summary>
        public const string VNPKCO = "VNPKCO";

        /// <summary>
        /// VNOKCO.
        /// </summary>
        public const string VNOKCO = "VNOKCO";

        /// <summary>
        /// VNPDCT.
        /// </summary>
        public const string VNPDCT = "VNPDCT";

        /// <summary>
        /// VNAN8.
        /// </summary>
        public const string VNAN8 = "VNAN8";

        /// <summary>
        /// VNCN.
        /// </summary>
        public const string VNCN = "VNCN";

        /// <summary>
        /// VNDKJ.
        /// </summary>
        public const string VNDKJ = "VNDKJ";

        /// <summary>
        /// VNDKC.
        /// </summary>
        public const string VNDKC = "VNDKC";

        /// <summary>
        /// VNASID.
        /// </summary>
        public const string VNASID = "VNASID";

        /// <summary>
        /// VNBRE.
        /// </summary>
        public const string VNBRE = "VNBRE";

        /// <summary>
        /// VNRCND.
        /// </summary>
        public const string VNRCND = "VNRCND";

        /// <summary>
        /// VNSUMM.
        /// </summary>
        public const string VNSUMM = "VNSUMM";

        /// <summary>
        /// VNPRGE.
        /// </summary>
        public const string VNPRGE = "VNPRGE";

        /// <summary>
        /// VNTNN.
        /// </summary>
        public const string VNTNN = "VNTNN";

        /// <summary>
        /// VNALT1.
        /// </summary>
        public const string VNALT1 = "VNALT1";

        /// <summary>
        /// VNALT2.
        /// </summary>
        public const string VNALT2 = "VNALT2";

        /// <summary>
        /// VNALT3.
        /// </summary>
        public const string VNALT3 = "VNALT3";

        /// <summary>
        /// VNALT4.
        /// </summary>
        public const string VNALT4 = "VNALT4";

        /// <summary>
        /// VNALT5.
        /// </summary>
        public const string VNALT5 = "VNALT5";

        /// <summary>
        /// VNALT6.
        /// </summary>
        public const string VNALT6 = "VNALT6";

        /// <summary>
        /// VNALT7.
        /// </summary>
        public const string VNALT7 = "VNALT7";

        /// <summary>
        /// VNALT8.
        /// </summary>
        public const string VNALT8 = "VNALT8";

        /// <summary>
        /// VNALT9.
        /// </summary>
        public const string VNALT9 = "VNALT9";

        /// <summary>
        /// VNALT0.
        /// </summary>
        public const string VNALT0 = "VNALT0";

        /// <summary>
        /// VNALTT.
        /// </summary>
        public const string VNALTT = "VNALTT";

        /// <summary>
        /// VNALTU.
        /// </summary>
        public const string VNALTU = "VNALTU";

        /// <summary>
        /// VNALTV.
        /// </summary>
        public const string VNALTV = "VNALTV";

        /// <summary>
        /// VNALTW.
        /// </summary>
        public const string VNALTW = "VNALTW";

        /// <summary>
        /// VNALTX.
        /// </summary>
        public const string VNALTX = "VNALTX";

        /// <summary>
        /// VNALTZ.
        /// </summary>
        public const string VNALTZ = "VNALTZ";

        /// <summary>
        /// VNDLNA.
        /// </summary>
        public const string VNDLNA = "VNDLNA";

        /// <summary>
        /// VNCFF1.
        /// </summary>
        public const string VNCFF1 = "VNCFF1";

        /// <summary>
        /// VNCFF2.
        /// </summary>
        public const string VNCFF2 = "VNCFF2";

        /// <summary>
        /// VNASM.
        /// </summary>
        public const string VNASM = "VNASM";

        /// <summary>
        /// VNBC.
        /// </summary>
        public const string VNBC = "VNBC";

        /// <summary>
        /// VNVINV.
        /// </summary>
        public const string VNVINV = "VNVINV";

        /// <summary>
        /// VNIVD.
        /// </summary>
        public const string VNIVD = "VNIVD";

        /// <summary>
        /// VNWR01.
        /// </summary>
        public const string VNWR01 = "VNWR01";

        /// <summary>
        /// VNPO.
        /// </summary>
        public const string VNPO = "VNPO";

        /// <summary>
        /// VNPSFX.
        /// </summary>
        public const string VNPSFX = "VNPSFX";

        /// <summary>
        /// VNDCTO.
        /// </summary>
        public const string VNDCTO = "VNDCTO";

        /// <summary>
        /// VNLNID.
        /// </summary>
        public const string VNLNID = "VNLNID";

        /// <summary>
        /// VNWY.
        /// </summary>
        public const string VNWY = "VNWY";

        /// <summary>
        /// VNWN.
        /// </summary>
        public const string VNWN = "VNWN";

        /// <summary>
        /// VNFNLP.
        /// </summary>
        public const string VNFNLP = "VNFNLP";

        /// <summary>
        /// VNOPSQ.
        /// </summary>
        public const string VNOPSQ = "VNOPSQ";

        /// <summary>
        /// VNJBCD.
        /// </summary>
        public const string VNJBCD = "VNJBCD";

        /// <summary>
        /// VNJBST.
        /// </summary>
        public const string VNJBST = "VNJBST";

        /// <summary>
        /// VNHMCU.
        /// </summary>
        public const string VNHMCU = "VNHMCU";

        /// <summary>
        /// VNDOI.
        /// </summary>
        public const string VNDOI = "VNDOI";

        /// <summary>
        /// VNALID.
        /// </summary>
        public const string VNALID = "VNALID";

        /// <summary>
        /// VNALTY.
        /// </summary>
        public const string VNALTY = "VNALTY";

        /// <summary>
        /// VNDSVJ.
        /// </summary>
        public const string VNDSVJ = "VNDSVJ";

        /// <summary>
        /// VNTORG.
        /// </summary>
        public const string VNTORG = "VNTORG";

        /// <summary>
        /// VNREG#.
        /// </summary>
        public const string VNREG_ = "VNREG#";

        /// <summary>
        /// VNPYID.
        /// </summary>
        public const string VNPYID = "VNPYID";

        /// <summary>
        /// VNUSER.
        /// </summary>
        public const string VNUSER = "VNUSER";

        /// <summary>
        /// VNPID.
        /// </summary>
        public const string VNPID = "VNPID";

        /// <summary>
        /// VNJOBN.
        /// </summary>
        public const string VNJOBN = "VNJOBN";

        /// <summary>
        /// VNUPMJ.
        /// </summary>
        public const string VNUPMJ = "VNUPMJ";

        /// <summary>
        /// VNUPMT.
        /// </summary>
        public const string VNUPMT = "VNUPMT";

        /// <summary>
        /// VNCRRM.
        /// </summary>
        public const string VNCRRM = "VNCRRM";

        /// <summary>
        /// VNACR.
        /// </summary>
        public const string VNACR = "VNACR";

        /// <summary>
        /// VNDGM.
        /// </summary>
        public const string VNDGM = "VNDGM";

        /// <summary>
        /// VNDGD.
        /// </summary>
        public const string VNDGD = "VNDGD";

        /// <summary>
        /// VNDGY.
        /// </summary>
        public const string VNDGY = "VNDGY";

        /// <summary>
        /// VNDG#.
        /// </summary>
        public const string VNDG_ = "VNDG#";

        /// <summary>
        /// VNDICM.
        /// </summary>
        public const string VNDICM = "VNDICM";

        /// <summary>
        /// VNDICD.
        /// </summary>
        public const string VNDICD = "VNDICD";

        /// <summary>
        /// VNDICY.
        /// </summary>
        public const string VNDICY = "VNDICY";

        /// <summary>
        /// VNDIC#.
        /// </summary>
        public const string VNDIC_ = "VNDIC#";

        /// <summary>
        /// VNDSYM.
        /// </summary>
        public const string VNDSYM = "VNDSYM";

        /// <summary>
        /// VNDSYD.
        /// </summary>
        public const string VNDSYD = "VNDSYD";

        /// <summary>
        /// VNDSYY.
        /// </summary>
        public const string VNDSYY = "VNDSYY";

        /// <summary>
        /// VNDSY#.
        /// </summary>
        public const string VNDSY_ = "VNDSY#";

        /// <summary>
        /// VNDKM.
        /// </summary>
        public const string VNDKM = "VNDKM";

        /// <summary>
        /// VNDKD.
        /// </summary>
        public const string VNDKD = "VNDKD";

        /// <summary>
        /// VNDKY.
        /// </summary>
        public const string VNDKY = "VNDKY";

        /// <summary>
        /// VNDK#.
        /// </summary>
        public const string VNDK_ = "VNDK#";

        /// <summary>
        /// VNDSVM.
        /// </summary>
        public const string VNDSVM = "VNDSVM";

        /// <summary>
        /// VNDSVD.
        /// </summary>
        public const string VNDSVD = "VNDSVD";

        /// <summary>
        /// VNDSVY.
        /// </summary>
        public const string VNDSVY = "VNDSVY";

        /// <summary>
        /// VNDSV#.
        /// </summary>
        public const string VNDSV_ = "VNDSV#";

        /// <summary>
        /// VNHDGM.
        /// </summary>
        public const string VNHDGM = "VNHDGM";

        /// <summary>
        /// VNHDGD.
        /// </summary>
        public const string VNHDGD = "VNHDGD";

        /// <summary>
        /// VNHDGY.
        /// </summary>
        public const string VNHDGY = "VNHDGY";

        /// <summary>
        /// VNHDG#.
        /// </summary>
        public const string VNHDG_ = "VNHDG#";

        /// <summary>
        /// VNDKCM.
        /// </summary>
        public const string VNDKCM = "VNDKCM";

        /// <summary>
        /// VNDKCD.
        /// </summary>
        public const string VNDKCD = "VNDKCD";

        /// <summary>
        /// VNDKCY.
        /// </summary>
        public const string VNDKCY = "VNDKCY";

        /// <summary>
        /// VNDKC#.
        /// </summary>
        public const string VNDKC_ = "VNDKC#";

        /// <summary>
        /// VNIVDM.
        /// </summary>
        public const string VNIVDM = "VNIVDM";

        /// <summary>
        /// VNIVDD.
        /// </summary>
        public const string VNIVDD = "VNIVDD";

        /// <summary>
        /// VNIVDY.
        /// </summary>
        public const string VNIVDY = "VNIVDY";

        /// <summary>
        /// VNIVD#.
        /// </summary>
        public const string VNIVD_ = "VNIVD#";

        /// <summary>
        /// VNABR1.
        /// </summary>
        public const string VNABR1 = "VNABR1";

        /// <summary>
        /// VNABR2.
        /// </summary>
        public const string VNABR2 = "VNABR2";

        /// <summary>
        /// VNABR3.
        /// </summary>
        public const string VNABR3 = "VNABR3";

        /// <summary>
        /// VNABR4.
        /// </summary>
        public const string VNABR4 = "VNABR4";

        /// <summary>
        /// VNABT1.
        /// </summary>
        public const string VNABT1 = "VNABT1";

        /// <summary>
        /// VNABT2.
        /// </summary>
        public const string VNABT2 = "VNABT2";

        /// <summary>
        /// VNABT3.
        /// </summary>
        public const string VNABT3 = "VNABT3";

        /// <summary>
        /// VNABT4.
        /// </summary>
        public const string VNABT4 = "VNABT4";

        /// <summary>
        /// VNITM.
        /// </summary>
        public const string VNITM = "VNITM";

        /// <summary>
        /// VNPM01.
        /// </summary>
        public const string VNPM01 = "VNPM01";

        /// <summary>
        /// VNPM02.
        /// </summary>
        public const string VNPM02 = "VNPM02";

        /// <summary>
        /// VNPM03.
        /// </summary>
        public const string VNPM03 = "VNPM03";

        /// <summary>
        /// VNPM04.
        /// </summary>
        public const string VNPM04 = "VNPM04";

        /// <summary>
        /// VNPM05.
        /// </summary>
        public const string VNPM05 = "VNPM05";

        /// <summary>
        /// VNPM06.
        /// </summary>
        public const string VNPM06 = "VNPM06";

        /// <summary>
        /// VNPM07.
        /// </summary>
        public const string VNPM07 = "VNPM07";

        /// <summary>
        /// VNPM08.
        /// </summary>
        public const string VNPM08 = "VNPM08";

        /// <summary>
        /// VNPM09.
        /// </summary>
        public const string VNPM09 = "VNPM09";

        /// <summary>
        /// VNPM10.
        /// </summary>
        public const string VNPM10 = "VNPM10";

        /// <summary>
        /// VNBCRC.
        /// </summary>
        public const string VNBCRC = "VNBCRC";

        /// <summary>
        /// VNEXR1.
        /// </summary>
        public const string VNEXR1 = "VNEXR1";

        /// <summary>
        /// VNTXA1.
        /// </summary>
        public const string VNTXA1 = "VNTXA1";

        /// <summary>
        /// VNTXITM.
        /// </summary>
        public const string VNTXITM = "VNTXITM";

        /// <summary>
        /// VNACTB.
        /// </summary>
        public const string VNACTB = "VNACTB";

        /// <summary>
        /// VNSTAM.
        /// </summary>
        public const string VNSTAM = "VNSTAM";

        /// <summary>
        /// VNCTAM.
        /// </summary>
        public const string VNCTAM = "VNCTAM";

        /// <summary>
        /// VNAG.
        /// </summary>
        public const string VNAG = "VNAG";

        /// <summary>
        /// VNAGF.
        /// </summary>
        public const string VNAGF = "VNAGF";

        /// <summary>
        /// VNTKTX.
        /// </summary>
        public const string VNTKTX = "VNTKTX";

        /// <summary>
        /// VNDLNID.
        /// </summary>
        public const string VNDLNID = "VNDLNID";

        /// <summary>
        /// VNCKNU.
        /// </summary>
        public const string VNCKNU = "VNCKNU";

        /// <summary>
        /// VNBUPC.
        /// </summary>
        public const string VNBUPC = "VNBUPC";

        /// <summary>
        /// VNAHBU.
        /// </summary>
        public const string VNAHBU = "VNAHBU";

        /// <summary>
        /// VNEPGC.
        /// </summary>
        public const string VNEPGC = "VNEPGC";

        /// <summary>
        /// VNJPGC.
        /// </summary>
        public const string VNJPGC = "VNJPGC";

        /// <summary>
        /// VNRC5.
        /// </summary>
        public const string VNRC5 = "VNRC5";

        /// <summary>
        /// VNSFXE.
        /// </summary>
        public const string VNSFXE = "VNSFXE";

        /// <summary>
        /// VNOFM.
        /// </summary>
        public const string VNOFM = "VNOFM";
    }

    /// <inheritdoc />
    public override string TableName => "F0911Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VNEDUS", "VNEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VNEDTY", "VNEDTY", JdeDataType.String, 2),
        new JdeField("VNEDSQ", "VNEDSQ", JdeDataType.Numeric),
        new JdeField("VNEDTN", "VNEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VNEDCT", "VNEDCT", JdeDataType.String, 4),
        new JdeField("VNEDLN", "VNEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VNEDTS", "VNEDTS", JdeDataType.String, 12),
        new JdeField("VNEDFT", "VNEDFT", JdeDataType.String, 20),
        new JdeField("VNEDDT", "VNEDDT", JdeDataType.Numeric),
        new JdeField("VNEDER", "VNEDER", JdeDataType.String, 2),
        new JdeField("VNEDDL", "VNEDDL", JdeDataType.Numeric),
        new JdeField("VNEDSP", "VNEDSP", JdeDataType.String, 2),
        new JdeField("VNEDTC", "VNEDTC", JdeDataType.String, 2),
        new JdeField("VNEDTR", "VNEDTR", JdeDataType.String, 2),
        new JdeField("VNEDBT", "VNEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VNEDGL", "VNEDGL", JdeDataType.String, 2),
        new JdeField("VNEDAN", "VNEDAN", JdeDataType.Numeric),
        new JdeField("VNKCO", "VNKCO", JdeDataType.String, 10),
        new JdeField("VNDCT", "VNDCT", JdeDataType.String, 4),
        new JdeField("VNDOC", "VNDOC", JdeDataType.Numeric),
        new JdeField("VNDGJ", "VNDGJ", JdeDataType.Numeric),
        new JdeField("VNJELN", "VNJELN", JdeDataType.Numeric),
        new JdeField("VNEXTL", "VNEXTL", JdeDataType.String, 4),
        new JdeField("VNPOST", "VNPOST", JdeDataType.String, 2),
        new JdeField("VNICU", "VNICU", JdeDataType.Numeric),
        new JdeField("VNICUT", "VNICUT", JdeDataType.String, 4),
        new JdeField("VNDICJ", "VNDICJ", JdeDataType.Numeric),
        new JdeField("VNDSYJ", "VNDSYJ", JdeDataType.Numeric),
        new JdeField("VNTICU", "VNTICU", JdeDataType.Numeric),
        new JdeField("VNCO", "VNCO", JdeDataType.String, 10),
        new JdeField("VNANI", "VNANI", JdeDataType.String, 58),
        new JdeField("VNAM", "VNAM", JdeDataType.String, 2),
        new JdeField("VNAID", "VNAID", JdeDataType.String, 16),
        new JdeField("VNMCU", "VNMCU", JdeDataType.String, 24),
        new JdeField("VNOBJ", "VNOBJ", JdeDataType.String, 12),
        new JdeField("VNSUB", "VNSUB", JdeDataType.String, 16),
        new JdeField("VNSBL", "VNSBL", JdeDataType.String, 16),
        new JdeField("VNSBLT", "VNSBLT", JdeDataType.String, 2),
        new JdeField("VNLT", "VNLT", JdeDataType.String, 4),
        new JdeField("VNPN", "VNPN", JdeDataType.Numeric),
        new JdeField("VNCTRY", "VNCTRY", JdeDataType.Numeric),
        new JdeField("VNFY", "VNFY", JdeDataType.Numeric),
        new JdeField("VNFQ", "VNFQ", JdeDataType.String, 8),
        new JdeField("VNCRCD", "VNCRCD", JdeDataType.String, 6),
        new JdeField("VNCRR", "VNCRR", JdeDataType.Numeric),
        new JdeField("VNHCRR", "VNHCRR", JdeDataType.Numeric),
        new JdeField("VNHDGJ", "VNHDGJ", JdeDataType.Numeric),
        new JdeField("VNAA", "VNAA", JdeDataType.Numeric),
        new JdeField("VNU", "VNU", JdeDataType.Numeric),
        new JdeField("VNUM", "VNUM", JdeDataType.String, 4),
        new JdeField("VNGLC", "VNGLC", JdeDataType.String, 8),
        new JdeField("VNRE", "VNRE", JdeDataType.String, 2),
        new JdeField("VNEXA", "VNEXA", JdeDataType.String, 60),
        new JdeField("VNEXR", "VNEXR", JdeDataType.String, 60),
        new JdeField("VNR1", "VNR1", JdeDataType.String, 16),
        new JdeField("VNR2", "VNR2", JdeDataType.String, 16),
        new JdeField("VNR3", "VNR3", JdeDataType.String, 16),
        new JdeField("VNSFX", "VNSFX", JdeDataType.String, 6),
        new JdeField("VNODOC", "VNODOC", JdeDataType.Numeric),
        new JdeField("VNODCT", "VNODCT", JdeDataType.String, 4),
        new JdeField("VNOSFX", "VNOSFX", JdeDataType.String, 6),
        new JdeField("VNPKCO", "VNPKCO", JdeDataType.String, 10),
        new JdeField("VNOKCO", "VNOKCO", JdeDataType.String, 10),
        new JdeField("VNPDCT", "VNPDCT", JdeDataType.String, 4),
        new JdeField("VNAN8", "VNAN8", JdeDataType.Numeric),
        new JdeField("VNCN", "VNCN", JdeDataType.String, 16),
        new JdeField("VNDKJ", "VNDKJ", JdeDataType.Numeric),
        new JdeField("VNDKC", "VNDKC", JdeDataType.Numeric),
        new JdeField("VNASID", "VNASID", JdeDataType.String, 50),
        new JdeField("VNBRE", "VNBRE", JdeDataType.String, 2),
        new JdeField("VNRCND", "VNRCND", JdeDataType.String, 2),
        new JdeField("VNSUMM", "VNSUMM", JdeDataType.String, 2),
        new JdeField("VNPRGE", "VNPRGE", JdeDataType.String, 2),
        new JdeField("VNTNN", "VNTNN", JdeDataType.String, 2),
        new JdeField("VNALT1", "VNALT1", JdeDataType.String, 2),
        new JdeField("VNALT2", "VNALT2", JdeDataType.String, 2),
        new JdeField("VNALT3", "VNALT3", JdeDataType.String, 2),
        new JdeField("VNALT4", "VNALT4", JdeDataType.String, 2),
        new JdeField("VNALT5", "VNALT5", JdeDataType.String, 2),
        new JdeField("VNALT6", "VNALT6", JdeDataType.String, 2),
        new JdeField("VNALT7", "VNALT7", JdeDataType.String, 2),
        new JdeField("VNALT8", "VNALT8", JdeDataType.String, 2),
        new JdeField("VNALT9", "VNALT9", JdeDataType.String, 2),
        new JdeField("VNALT0", "VNALT0", JdeDataType.String, 2),
        new JdeField("VNALTT", "VNALTT", JdeDataType.String, 2),
        new JdeField("VNALTU", "VNALTU", JdeDataType.String, 2),
        new JdeField("VNALTV", "VNALTV", JdeDataType.String, 2),
        new JdeField("VNALTW", "VNALTW", JdeDataType.String, 2),
        new JdeField("VNALTX", "VNALTX", JdeDataType.String, 2),
        new JdeField("VNALTZ", "VNALTZ", JdeDataType.String, 2),
        new JdeField("VNDLNA", "VNDLNA", JdeDataType.String, 2),
        new JdeField("VNCFF1", "VNCFF1", JdeDataType.String, 2),
        new JdeField("VNCFF2", "VNCFF2", JdeDataType.String, 2),
        new JdeField("VNASM", "VNASM", JdeDataType.String, 2),
        new JdeField("VNBC", "VNBC", JdeDataType.String, 2),
        new JdeField("VNVINV", "VNVINV", JdeDataType.String, 50),
        new JdeField("VNIVD", "VNIVD", JdeDataType.Numeric),
        new JdeField("VNWR01", "VNWR01", JdeDataType.String, 8),
        new JdeField("VNPO", "VNPO", JdeDataType.String, 16),
        new JdeField("VNPSFX", "VNPSFX", JdeDataType.String, 6),
        new JdeField("VNDCTO", "VNDCTO", JdeDataType.String, 4),
        new JdeField("VNLNID", "VNLNID", JdeDataType.Numeric),
        new JdeField("VNWY", "VNWY", JdeDataType.Numeric),
        new JdeField("VNWN", "VNWN", JdeDataType.Numeric),
        new JdeField("VNFNLP", "VNFNLP", JdeDataType.String, 2),
        new JdeField("VNOPSQ", "VNOPSQ", JdeDataType.Numeric),
        new JdeField("VNJBCD", "VNJBCD", JdeDataType.String, 12),
        new JdeField("VNJBST", "VNJBST", JdeDataType.String, 8),
        new JdeField("VNHMCU", "VNHMCU", JdeDataType.String, 24),
        new JdeField("VNDOI", "VNDOI", JdeDataType.Numeric),
        new JdeField("VNALID", "VNALID", JdeDataType.String, 50),
        new JdeField("VNALTY", "VNALTY", JdeDataType.String, 4),
        new JdeField("VNDSVJ", "VNDSVJ", JdeDataType.Numeric),
        new JdeField("VNTORG", "VNTORG", JdeDataType.String, 20),
        new JdeField("VNREG#", "VNREG#", JdeDataType.Numeric),
        new JdeField("VNPYID", "VNPYID", JdeDataType.Numeric),
        new JdeField("VNUSER", "VNUSER", JdeDataType.String, 20),
        new JdeField("VNPID", "VNPID", JdeDataType.String, 20),
        new JdeField("VNJOBN", "VNJOBN", JdeDataType.String, 20),
        new JdeField("VNUPMJ", "VNUPMJ", JdeDataType.Numeric),
        new JdeField("VNUPMT", "VNUPMT", JdeDataType.Numeric),
        new JdeField("VNCRRM", "VNCRRM", JdeDataType.String, 2),
        new JdeField("VNACR", "VNACR", JdeDataType.Numeric),
        new JdeField("VNDGM", "VNDGM", JdeDataType.Numeric),
        new JdeField("VNDGD", "VNDGD", JdeDataType.Numeric),
        new JdeField("VNDGY", "VNDGY", JdeDataType.Numeric),
        new JdeField("VNDG#", "VNDG#", JdeDataType.Numeric),
        new JdeField("VNDICM", "VNDICM", JdeDataType.Numeric),
        new JdeField("VNDICD", "VNDICD", JdeDataType.Numeric),
        new JdeField("VNDICY", "VNDICY", JdeDataType.Numeric),
        new JdeField("VNDIC#", "VNDIC#", JdeDataType.Numeric),
        new JdeField("VNDSYM", "VNDSYM", JdeDataType.Numeric),
        new JdeField("VNDSYD", "VNDSYD", JdeDataType.Numeric),
        new JdeField("VNDSYY", "VNDSYY", JdeDataType.Numeric),
        new JdeField("VNDSY#", "VNDSY#", JdeDataType.Numeric),
        new JdeField("VNDKM", "VNDKM", JdeDataType.Numeric),
        new JdeField("VNDKD", "VNDKD", JdeDataType.Numeric),
        new JdeField("VNDKY", "VNDKY", JdeDataType.Numeric),
        new JdeField("VNDK#", "VNDK#", JdeDataType.Numeric),
        new JdeField("VNDSVM", "VNDSVM", JdeDataType.Numeric),
        new JdeField("VNDSVD", "VNDSVD", JdeDataType.Numeric),
        new JdeField("VNDSVY", "VNDSVY", JdeDataType.Numeric),
        new JdeField("VNDSV#", "VNDSV#", JdeDataType.Numeric),
        new JdeField("VNHDGM", "VNHDGM", JdeDataType.Numeric),
        new JdeField("VNHDGD", "VNHDGD", JdeDataType.Numeric),
        new JdeField("VNHDGY", "VNHDGY", JdeDataType.Numeric),
        new JdeField("VNHDG#", "VNHDG#", JdeDataType.Numeric),
        new JdeField("VNDKCM", "VNDKCM", JdeDataType.Numeric),
        new JdeField("VNDKCD", "VNDKCD", JdeDataType.Numeric),
        new JdeField("VNDKCY", "VNDKCY", JdeDataType.Numeric),
        new JdeField("VNDKC#", "VNDKC#", JdeDataType.Numeric),
        new JdeField("VNIVDM", "VNIVDM", JdeDataType.Numeric),
        new JdeField("VNIVDD", "VNIVDD", JdeDataType.Numeric),
        new JdeField("VNIVDY", "VNIVDY", JdeDataType.Numeric),
        new JdeField("VNIVD#", "VNIVD#", JdeDataType.Numeric),
        new JdeField("VNABR1", "VNABR1", JdeDataType.String, 24),
        new JdeField("VNABR2", "VNABR2", JdeDataType.String, 24),
        new JdeField("VNABR3", "VNABR3", JdeDataType.String, 24),
        new JdeField("VNABR4", "VNABR4", JdeDataType.String, 24),
        new JdeField("VNABT1", "VNABT1", JdeDataType.String, 2),
        new JdeField("VNABT2", "VNABT2", JdeDataType.String, 2),
        new JdeField("VNABT3", "VNABT3", JdeDataType.String, 2),
        new JdeField("VNABT4", "VNABT4", JdeDataType.String, 2),
        new JdeField("VNITM", "VNITM", JdeDataType.Numeric),
        new JdeField("VNPM01", "VNPM01", JdeDataType.String, 2),
        new JdeField("VNPM02", "VNPM02", JdeDataType.String, 2),
        new JdeField("VNPM03", "VNPM03", JdeDataType.String, 2),
        new JdeField("VNPM04", "VNPM04", JdeDataType.String, 2),
        new JdeField("VNPM05", "VNPM05", JdeDataType.String, 2),
        new JdeField("VNPM06", "VNPM06", JdeDataType.String, 2),
        new JdeField("VNPM07", "VNPM07", JdeDataType.String, 2),
        new JdeField("VNPM08", "VNPM08", JdeDataType.String, 2),
        new JdeField("VNPM09", "VNPM09", JdeDataType.String, 2),
        new JdeField("VNPM10", "VNPM10", JdeDataType.String, 2),
        new JdeField("VNBCRC", "VNBCRC", JdeDataType.String, 6),
        new JdeField("VNEXR1", "VNEXR1", JdeDataType.String, 4),
        new JdeField("VNTXA1", "VNTXA1", JdeDataType.String, 20),
        new JdeField("VNTXITM", "VNTXITM", JdeDataType.Numeric),
        new JdeField("VNACTB", "VNACTB", JdeDataType.String, 20),
        new JdeField("VNSTAM", "VNSTAM", JdeDataType.Numeric),
        new JdeField("VNCTAM", "VNCTAM", JdeDataType.Numeric),
        new JdeField("VNAG", "VNAG", JdeDataType.Numeric),
        new JdeField("VNAGF", "VNAGF", JdeDataType.Numeric),
        new JdeField("VNTKTX", "VNTKTX", JdeDataType.String, 2),
        new JdeField("VNDLNID", "VNDLNID", JdeDataType.Numeric),
        new JdeField("VNCKNU", "VNCKNU", JdeDataType.String, 50),
        new JdeField("VNBUPC", "VNBUPC", JdeDataType.String, 2),
        new JdeField("VNAHBU", "VNAHBU", JdeDataType.String, 24),
        new JdeField("VNEPGC", "VNEPGC", JdeDataType.String, 6),
        new JdeField("VNJPGC", "VNJPGC", JdeDataType.String, 6),
        new JdeField("VNRC5", "VNRC5", JdeDataType.Numeric),
        new JdeField("VNSFXE", "VNSFXE", JdeDataType.Numeric),
        new JdeField("VNOFM", "VNOFM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0911Z1_0", "Primary Key on VNEDUS, VNEDBT, VNEDTN, VNEDLN", new[] { "VNEDUS", "VNEDBT", "VNEDTN", "VNEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0911Z1_2", "Index on VNEDBT, VNEDTN, VNEDSP", new[] { "VNEDBT", "VNEDTN", "VNEDSP" }),
        new JdeIndex("F0911Z1_3", "Index on VNEDUS, VNEDBT, VNEDTN, VNDGJ, VNEDLN", new[] { "VNEDUS", "VNEDBT", "VNEDTN", "VNDGJ", "VNEDLN" }),
        new JdeIndex("F0911Z1_4", "Index on VNEDUS, VNEDBT, VNEDTN, SYS_NC00194$", new[] { "VNEDUS", "VNEDBT", "VNEDTN", "SYS_NC00194$" })
    };
}
