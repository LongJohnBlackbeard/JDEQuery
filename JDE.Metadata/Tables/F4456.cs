using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4456 - .
/// </summary>
public class F4456 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JIMCUS.
        /// </summary>
        public const string JIMCUS = "JIMCUS";

        /// <summary>
        /// JIMCU.
        /// </summary>
        public const string JIMCU = "JIMCU";

        /// <summary>
        /// JIALOT.
        /// </summary>
        public const string JIALOT = "JIALOT";

        /// <summary>
        /// JISFXO.
        /// </summary>
        public const string JISFXO = "JISFXO";

        /// <summary>
        /// JIPL.
        /// </summary>
        public const string JIPL = "JIPL";

        /// <summary>
        /// JIELEV.
        /// </summary>
        public const string JIELEV = "JIELEV";

        /// <summary>
        /// JISTDJ.
        /// </summary>
        public const string JISTDJ = "JISTDJ";

        /// <summary>
        /// JILNT.
        /// </summary>
        public const string JILNT = "JILNT";

        /// <summary>
        /// JIPMN.
        /// </summary>
        public const string JIPMN = "JIPMN";

        /// <summary>
        /// JICLRH.
        /// </summary>
        public const string JICLRH = "JICLRH";

        /// <summary>
        /// JICLPK.
        /// </summary>
        public const string JICLPK = "JICLPK";

        /// <summary>
        /// JISWG.
        /// </summary>
        public const string JISWG = "JISWG";

        /// <summary>
        /// JIBYR.
        /// </summary>
        public const string JIBYR = "JIBYR";

        /// <summary>
        /// JIASC.
        /// </summary>
        public const string JIASC = "JIASC";

        /// <summary>
        /// JISDJ.
        /// </summary>
        public const string JISDJ = "JISDJ";

        /// <summary>
        /// JIEDJ.
        /// </summary>
        public const string JIEDJ = "JIEDJ";

        /// <summary>
        /// JIBSP.
        /// </summary>
        public const string JIBSP = "JIBSP";

        /// <summary>
        /// JILTP.
        /// </summary>
        public const string JILTP = "JILTP";

        /// <summary>
        /// JIINCA.
        /// </summary>
        public const string JIINCA = "JIINCA";

        /// <summary>
        /// JIPN1.
        /// </summary>
        public const string JIPN1 = "JIPN1";

        /// <summary>
        /// JIPN2.
        /// </summary>
        public const string JIPN2 = "JIPN2";

        /// <summary>
        /// JIPN3.
        /// </summary>
        public const string JIPN3 = "JIPN3";

        /// <summary>
        /// JIPN4.
        /// </summary>
        public const string JIPN4 = "JIPN4";

        /// <summary>
        /// JIPN5.
        /// </summary>
        public const string JIPN5 = "JIPN5";

        /// <summary>
        /// JIPN6.
        /// </summary>
        public const string JIPN6 = "JIPN6";

        /// <summary>
        /// JIJOBN.
        /// </summary>
        public const string JIJOBN = "JIJOBN";

        /// <summary>
        /// JIPID.
        /// </summary>
        public const string JIPID = "JIPID";

        /// <summary>
        /// JIUSER.
        /// </summary>
        public const string JIUSER = "JIUSER";

        /// <summary>
        /// JIUPMJ.
        /// </summary>
        public const string JIUPMJ = "JIUPMJ";

        /// <summary>
        /// JIACCL.
        /// </summary>
        public const string JIACCL = "JIACCL";

        /// <summary>
        /// JIBDC.
        /// </summary>
        public const string JIBDC = "JIBDC";

        /// <summary>
        /// JIFSC.
        /// </summary>
        public const string JIFSC = "JIFSC";

        /// <summary>
        /// JIHSTY.
        /// </summary>
        public const string JIHSTY = "JIHSTY";

        /// <summary>
        /// JIUPG.
        /// </summary>
        public const string JIUPG = "JIUPG";

        /// <summary>
        /// JITSP.
        /// </summary>
        public const string JITSP = "JITSP";

        /// <summary>
        /// JISUB.
        /// </summary>
        public const string JISUB = "JISUB";

        /// <summary>
        /// JIDL01.
        /// </summary>
        public const string JIDL01 = "JIDL01";

        /// <summary>
        /// JIROF.
        /// </summary>
        public const string JIROF = "JIROF";

        /// <summary>
        /// JISLP.
        /// </summary>
        public const string JISLP = "JISLP";

        /// <summary>
        /// JIATFN.
        /// </summary>
        public const string JIATFN = "JIATFN";

        /// <summary>
        /// JICTGJ.
        /// </summary>
        public const string JICTGJ = "JICTGJ";

        /// <summary>
        /// JICRD.
        /// </summary>
        public const string JICRD = "JICRD";

        /// <summary>
        /// JICXD.
        /// </summary>
        public const string JICXD = "JICXD";

        /// <summary>
        /// JILRD.
        /// </summary>
        public const string JILRD = "JILRD";

        /// <summary>
        /// JIPTDJ.
        /// </summary>
        public const string JIPTDJ = "JIPTDJ";

        /// <summary>
        /// JIPHD.
        /// </summary>
        public const string JIPHD = "JIPHD";

        /// <summary>
        /// JICTYJ.
        /// </summary>
        public const string JICTYJ = "JICTYJ";

        /// <summary>
        /// JIPRD.
        /// </summary>
        public const string JIPRD = "JIPRD";

        /// <summary>
        /// JISWD.
        /// </summary>
        public const string JISWD = "JISWD";

        /// <summary>
        /// JISWT.
        /// </summary>
        public const string JISWT = "JISWT";

        /// <summary>
        /// JITAD.
        /// </summary>
        public const string JITAD = "JITAD";

        /// <summary>
        /// JIPXD.
        /// </summary>
        public const string JIPXD = "JIPXD";

        /// <summary>
        /// JIOD1.
        /// </summary>
        public const string JIOD1 = "JIOD1";

        /// <summary>
        /// JIOD2.
        /// </summary>
        public const string JIOD2 = "JIOD2";

        /// <summary>
        /// JIOD3.
        /// </summary>
        public const string JIOD3 = "JIOD3";

        /// <summary>
        /// JILDN.
        /// </summary>
        public const string JILDN = "JILDN";

        /// <summary>
        /// JICN1.
        /// </summary>
        public const string JICN1 = "JICN1";

        /// <summary>
        /// JICN2.
        /// </summary>
        public const string JICN2 = "JICN2";

        /// <summary>
        /// JION1.
        /// </summary>
        public const string JION1 = "JION1";

        /// <summary>
        /// JION2.
        /// </summary>
        public const string JION2 = "JION2";

        /// <summary>
        /// JION3.
        /// </summary>
        public const string JION3 = "JION3";

        /// <summary>
        /// JIINR.
        /// </summary>
        public const string JIINR = "JIINR";

        /// <summary>
        /// JIMGA.
        /// </summary>
        public const string JIMGA = "JIMGA";

        /// <summary>
        /// JIDNPT.
        /// </summary>
        public const string JIDNPT = "JIDNPT";

        /// <summary>
        /// JIEMD.
        /// </summary>
        public const string JIEMD = "JIEMD";

        /// <summary>
        /// JIOA1.
        /// </summary>
        public const string JIOA1 = "JIOA1";

        /// <summary>
        /// JIOA2.
        /// </summary>
        public const string JIOA2 = "JIOA2";

        /// <summary>
        /// JICDJ.
        /// </summary>
        public const string JICDJ = "JICDJ";

        /// <summary>
        /// JISCS.
        /// </summary>
        public const string JISCS = "JISCS";

        /// <summary>
        /// JICPJ.
        /// </summary>
        public const string JICPJ = "JICPJ";

        /// <summary>
        /// JIMAD.
        /// </summary>
        public const string JIMAD = "JIMAD";

        /// <summary>
        /// JILADJ.
        /// </summary>
        public const string JILADJ = "JILADJ";

        /// <summary>
        /// JICTGS.
        /// </summary>
        public const string JICTGS = "JICTGS";

        /// <summary>
        /// JICBK.
        /// </summary>
        public const string JICBK = "JICBK";

        /// <summary>
        /// JIUSD1.
        /// </summary>
        public const string JIUSD1 = "JIUSD1";

        /// <summary>
        /// JIUSD2.
        /// </summary>
        public const string JIUSD2 = "JIUSD2";

        /// <summary>
        /// JIUSD3.
        /// </summary>
        public const string JIUSD3 = "JIUSD3";

        /// <summary>
        /// JIUC01.
        /// </summary>
        public const string JIUC01 = "JIUC01";

        /// <summary>
        /// JIUC02.
        /// </summary>
        public const string JIUC02 = "JIUC02";

        /// <summary>
        /// JIUC03.
        /// </summary>
        public const string JIUC03 = "JIUC03";

        /// <summary>
        /// JIF1T.
        /// </summary>
        public const string JIF1T = "JIF1T";

        /// <summary>
        /// JIF2T.
        /// </summary>
        public const string JIF2T = "JIF2T";

        /// <summary>
        /// JIF3T.
        /// </summary>
        public const string JIF3T = "JIF3T";

        /// <summary>
        /// JIF1A.
        /// </summary>
        public const string JIF1A = "JIF1A";

        /// <summary>
        /// JIF2A.
        /// </summary>
        public const string JIF2A = "JIF2A";

        /// <summary>
        /// JIF3A.
        /// </summary>
        public const string JIF3A = "JIF3A";

        /// <summary>
        /// JIPSG.
        /// </summary>
        public const string JIPSG = "JIPSG";

        /// <summary>
        /// JICLT.
        /// </summary>
        public const string JICLT = "JICLT";

        /// <summary>
        /// JIDOC1.
        /// </summary>
        public const string JIDOC1 = "JIDOC1";

        /// <summary>
        /// JIDOC2.
        /// </summary>
        public const string JIDOC2 = "JIDOC2";

        /// <summary>
        /// JIDOC3.
        /// </summary>
        public const string JIDOC3 = "JIDOC3";

        /// <summary>
        /// JIDCT1.
        /// </summary>
        public const string JIDCT1 = "JIDCT1";

        /// <summary>
        /// JIDCT2.
        /// </summary>
        public const string JIDCT2 = "JIDCT2";

        /// <summary>
        /// JIDCT3.
        /// </summary>
        public const string JIDCT3 = "JIDCT3";

        /// <summary>
        /// JILDR.
        /// </summary>
        public const string JILDR = "JILDR";

        /// <summary>
        /// JIASC2.
        /// </summary>
        public const string JIASC2 = "JIASC2";

        /// <summary>
        /// JIASC3.
        /// </summary>
        public const string JIASC3 = "JIASC3";

        /// <summary>
        /// JICM1.
        /// </summary>
        public const string JICM1 = "JICM1";

        /// <summary>
        /// JICM2.
        /// </summary>
        public const string JICM2 = "JICM2";

        /// <summary>
        /// JICM3.
        /// </summary>
        public const string JICM3 = "JICM3";

        /// <summary>
        /// JIUSD4.
        /// </summary>
        public const string JIUSD4 = "JIUSD4";

        /// <summary>
        /// JIUSD5.
        /// </summary>
        public const string JIUSD5 = "JIUSD5";

        /// <summary>
        /// JIUSD6.
        /// </summary>
        public const string JIUSD6 = "JIUSD6";

        /// <summary>
        /// JIPC1.
        /// </summary>
        public const string JIPC1 = "JIPC1";

        /// <summary>
        /// JIPC2.
        /// </summary>
        public const string JIPC2 = "JIPC2";

        /// <summary>
        /// JIPC3.
        /// </summary>
        public const string JIPC3 = "JIPC3";

        /// <summary>
        /// JICBN.
        /// </summary>
        public const string JICBN = "JICBN";

        /// <summary>
        /// JICLJ.
        /// </summary>
        public const string JICLJ = "JICLJ";

        /// <summary>
        /// JILAG.
        /// </summary>
        public const string JILAG = "JILAG";

        /// <summary>
        /// JIPTX.
        /// </summary>
        public const string JIPTX = "JIPTX";

        /// <summary>
        /// JILNN.
        /// </summary>
        public const string JILNN = "JILNN";

        /// <summary>
        /// JIOP1.
        /// </summary>
        public const string JIOP1 = "JIOP1";

        /// <summary>
        /// JIOP2.
        /// </summary>
        public const string JIOP2 = "JIOP2";

        /// <summary>
        /// JIOP3.
        /// </summary>
        public const string JIOP3 = "JIOP3";

        /// <summary>
        /// JIDSN1.
        /// </summary>
        public const string JIDSN1 = "JIDSN1";

        /// <summary>
        /// JIDSN2.
        /// </summary>
        public const string JIDSN2 = "JIDSN2";

        /// <summary>
        /// JIDSC1.
        /// </summary>
        public const string JIDSC1 = "JIDSC1";

        /// <summary>
        /// JIDSC2.
        /// </summary>
        public const string JIDSC2 = "JIDSC2";

        /// <summary>
        /// JIDSC3.
        /// </summary>
        public const string JIDSC3 = "JIDSC3";

        /// <summary>
        /// JIF4A.
        /// </summary>
        public const string JIF4A = "JIF4A";

        /// <summary>
        /// JIF5A.
        /// </summary>
        public const string JIF5A = "JIF5A";

        /// <summary>
        /// JIF6A.
        /// </summary>
        public const string JIF6A = "JIF6A";

        /// <summary>
        /// JIUSD7.
        /// </summary>
        public const string JIUSD7 = "JIUSD7";

        /// <summary>
        /// JIUSD8.
        /// </summary>
        public const string JIUSD8 = "JIUSD8";

        /// <summary>
        /// JIUSD9.
        /// </summary>
        public const string JIUSD9 = "JIUSD9";

        /// <summary>
        /// JIUC04.
        /// </summary>
        public const string JIUC04 = "JIUC04";

        /// <summary>
        /// JIUC05.
        /// </summary>
        public const string JIUC05 = "JIUC05";

        /// <summary>
        /// JIUC06.
        /// </summary>
        public const string JIUC06 = "JIUC06";

        /// <summary>
        /// JIDTKN.
        /// </summary>
        public const string JIDTKN = "JIDTKN";

        /// <summary>
        /// JISLKF.
        /// </summary>
        public const string JISLKF = "JISLKF";

        /// <summary>
        /// JIBLDR.
        /// </summary>
        public const string JIBLDR = "JIBLDR";
    }

    /// <inheritdoc />
    public override string TableName => "F4456";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JIMCUS", "JIMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JIMCU", "JIMCU", JdeDataType.String, 24),
        new JdeField("JIALOT", "JIALOT", JdeDataType.String, 8, true, true),
        new JdeField("JISFXO", "JISFXO", JdeDataType.String, 6),
        new JdeField("JIPL", "JIPL", JdeDataType.String, 8),
        new JdeField("JIELEV", "JIELEV", JdeDataType.String, 6),
        new JdeField("JISTDJ", "JISTDJ", JdeDataType.Numeric),
        new JdeField("JILNT", "JILNT", JdeDataType.String, 16),
        new JdeField("JIPMN", "JIPMN", JdeDataType.String, 24),
        new JdeField("JICLRH", "JICLRH", JdeDataType.String, 2),
        new JdeField("JICLPK", "JICLPK", JdeDataType.String, 20),
        new JdeField("JISWG", "JISWG", JdeDataType.String, 2),
        new JdeField("JIBYR", "JIBYR", JdeDataType.Numeric, null, true, true),
        new JdeField("JIASC", "JIASC", JdeDataType.Numeric),
        new JdeField("JISDJ", "JISDJ", JdeDataType.Numeric),
        new JdeField("JIEDJ", "JIEDJ", JdeDataType.Numeric),
        new JdeField("JIBSP", "JIBSP", JdeDataType.Numeric),
        new JdeField("JILTP", "JILTP", JdeDataType.Numeric),
        new JdeField("JIINCA", "JIINCA", JdeDataType.Numeric),
        new JdeField("JIPN1", "JIPN1", JdeDataType.String, 60),
        new JdeField("JIPN2", "JIPN2", JdeDataType.String, 60),
        new JdeField("JIPN3", "JIPN3", JdeDataType.String, 60),
        new JdeField("JIPN4", "JIPN4", JdeDataType.String, 60),
        new JdeField("JIPN5", "JIPN5", JdeDataType.String, 60),
        new JdeField("JIPN6", "JIPN6", JdeDataType.String, 60),
        new JdeField("JIJOBN", "JIJOBN", JdeDataType.String, 20),
        new JdeField("JIPID", "JIPID", JdeDataType.String, 20),
        new JdeField("JIUSER", "JIUSER", JdeDataType.String, 20),
        new JdeField("JIUPMJ", "JIUPMJ", JdeDataType.Numeric),
        new JdeField("JIACCL", "JIACCL", JdeDataType.String, 30),
        new JdeField("JIBDC", "JIBDC", JdeDataType.String, 30),
        new JdeField("JIFSC", "JIFSC", JdeDataType.String, 30),
        new JdeField("JIHSTY", "JIHSTY", JdeDataType.String, 2, true, true),
        new JdeField("JIUPG", "JIUPG", JdeDataType.Numeric),
        new JdeField("JITSP", "JITSP", JdeDataType.Numeric),
        new JdeField("JISUB", "JISUB", JdeDataType.String, 16),
        new JdeField("JIDL01", "JIDL01", JdeDataType.String, 60),
        new JdeField("JIROF", "JIROF", JdeDataType.String, 30),
        new JdeField("JISLP", "JISLP", JdeDataType.Numeric),
        new JdeField("JIATFN", "JIATFN", JdeDataType.Numeric),
        new JdeField("JICTGJ", "JICTGJ", JdeDataType.Numeric),
        new JdeField("JICRD", "JICRD", JdeDataType.Numeric),
        new JdeField("JICXD", "JICXD", JdeDataType.Numeric),
        new JdeField("JILRD", "JILRD", JdeDataType.Numeric),
        new JdeField("JIPTDJ", "JIPTDJ", JdeDataType.Numeric),
        new JdeField("JIPHD", "JIPHD", JdeDataType.Numeric),
        new JdeField("JICTYJ", "JICTYJ", JdeDataType.Numeric),
        new JdeField("JIPRD", "JIPRD", JdeDataType.Numeric),
        new JdeField("JISWD", "JISWD", JdeDataType.Numeric),
        new JdeField("JISWT", "JISWT", JdeDataType.String, 16),
        new JdeField("JITAD", "JITAD", JdeDataType.Numeric),
        new JdeField("JIPXD", "JIPXD", JdeDataType.Numeric),
        new JdeField("JIOD1", "JIOD1", JdeDataType.Numeric),
        new JdeField("JIOD2", "JIOD2", JdeDataType.Numeric),
        new JdeField("JIOD3", "JIOD3", JdeDataType.Numeric),
        new JdeField("JILDN", "JILDN", JdeDataType.String, 60),
        new JdeField("JICN1", "JICN1", JdeDataType.String, 60),
        new JdeField("JICN2", "JICN2", JdeDataType.String, 60),
        new JdeField("JION1", "JION1", JdeDataType.String, 60),
        new JdeField("JION2", "JION2", JdeDataType.String, 60),
        new JdeField("JION3", "JION3", JdeDataType.String, 60),
        new JdeField("JIINR", "JIINR", JdeDataType.Numeric),
        new JdeField("JIMGA", "JIMGA", JdeDataType.Numeric),
        new JdeField("JIDNPT", "JIDNPT", JdeDataType.Numeric),
        new JdeField("JIEMD", "JIEMD", JdeDataType.Numeric),
        new JdeField("JIOA1", "JIOA1", JdeDataType.Numeric),
        new JdeField("JIOA2", "JIOA2", JdeDataType.Numeric),
        new JdeField("JICDJ", "JICDJ", JdeDataType.Numeric),
        new JdeField("JISCS", "JISCS", JdeDataType.String, 2, true, true),
        new JdeField("JICPJ", "JICPJ", JdeDataType.Numeric),
        new JdeField("JIMAD", "JIMAD", JdeDataType.Numeric),
        new JdeField("JILADJ", "JILADJ", JdeDataType.Numeric),
        new JdeField("JICTGS", "JICTGS", JdeDataType.String, 16),
        new JdeField("JICBK", "JICBK", JdeDataType.String, 2),
        new JdeField("JIUSD1", "JIUSD1", JdeDataType.Numeric),
        new JdeField("JIUSD2", "JIUSD2", JdeDataType.Numeric),
        new JdeField("JIUSD3", "JIUSD3", JdeDataType.Numeric),
        new JdeField("JIUC01", "JIUC01", JdeDataType.String, 2),
        new JdeField("JIUC02", "JIUC02", JdeDataType.String, 2),
        new JdeField("JIUC03", "JIUC03", JdeDataType.String, 2),
        new JdeField("JIF1T", "JIF1T", JdeDataType.String, 60),
        new JdeField("JIF2T", "JIF2T", JdeDataType.String, 60),
        new JdeField("JIF3T", "JIF3T", JdeDataType.String, 60),
        new JdeField("JIF1A", "JIF1A", JdeDataType.Numeric),
        new JdeField("JIF2A", "JIF2A", JdeDataType.Numeric),
        new JdeField("JIF3A", "JIF3A", JdeDataType.Numeric),
        new JdeField("JIPSG", "JIPSG", JdeDataType.Numeric),
        new JdeField("JICLT", "JICLT", JdeDataType.String, 8),
        new JdeField("JIDOC1", "JIDOC1", JdeDataType.Numeric),
        new JdeField("JIDOC2", "JIDOC2", JdeDataType.Numeric),
        new JdeField("JIDOC3", "JIDOC3", JdeDataType.Numeric),
        new JdeField("JIDCT1", "JIDCT1", JdeDataType.String, 4),
        new JdeField("JIDCT2", "JIDCT2", JdeDataType.String, 4),
        new JdeField("JIDCT3", "JIDCT3", JdeDataType.String, 4),
        new JdeField("JILDR", "JILDR", JdeDataType.Numeric),
        new JdeField("JIASC2", "JIASC2", JdeDataType.Numeric),
        new JdeField("JIASC3", "JIASC3", JdeDataType.Numeric),
        new JdeField("JICM1", "JICM1", JdeDataType.Numeric),
        new JdeField("JICM2", "JICM2", JdeDataType.Numeric),
        new JdeField("JICM3", "JICM3", JdeDataType.Numeric),
        new JdeField("JIUSD4", "JIUSD4", JdeDataType.Numeric),
        new JdeField("JIUSD5", "JIUSD5", JdeDataType.Numeric),
        new JdeField("JIUSD6", "JIUSD6", JdeDataType.Numeric),
        new JdeField("JIPC1", "JIPC1", JdeDataType.Numeric),
        new JdeField("JIPC2", "JIPC2", JdeDataType.Numeric),
        new JdeField("JIPC3", "JIPC3", JdeDataType.Numeric),
        new JdeField("JICBN", "JICBN", JdeDataType.Numeric),
        new JdeField("JICLJ", "JICLJ", JdeDataType.Numeric),
        new JdeField("JILAG", "JILAG", JdeDataType.Numeric),
        new JdeField("JIPTX", "JIPTX", JdeDataType.String, 60),
        new JdeField("JILNN", "JILNN", JdeDataType.String, 16),
        new JdeField("JIOP1", "JIOP1", JdeDataType.Numeric),
        new JdeField("JIOP2", "JIOP2", JdeDataType.Numeric),
        new JdeField("JIOP3", "JIOP3", JdeDataType.Numeric),
        new JdeField("JIDSN1", "JIDSN1", JdeDataType.Numeric),
        new JdeField("JIDSN2", "JIDSN2", JdeDataType.Numeric),
        new JdeField("JIDSC1", "JIDSC1", JdeDataType.String, 60),
        new JdeField("JIDSC2", "JIDSC2", JdeDataType.String, 60),
        new JdeField("JIDSC3", "JIDSC3", JdeDataType.String, 60),
        new JdeField("JIF4A", "JIF4A", JdeDataType.Numeric),
        new JdeField("JIF5A", "JIF5A", JdeDataType.Numeric),
        new JdeField("JIF6A", "JIF6A", JdeDataType.Numeric),
        new JdeField("JIUSD7", "JIUSD7", JdeDataType.Numeric),
        new JdeField("JIUSD8", "JIUSD8", JdeDataType.Numeric),
        new JdeField("JIUSD9", "JIUSD9", JdeDataType.Numeric),
        new JdeField("JIUC04", "JIUC04", JdeDataType.String, 2),
        new JdeField("JIUC05", "JIUC05", JdeDataType.String, 2),
        new JdeField("JIUC06", "JIUC06", JdeDataType.String, 2),
        new JdeField("JIDTKN", "JIDTKN", JdeDataType.Numeric),
        new JdeField("JISLKF", "JISLKF", JdeDataType.String, 2),
        new JdeField("JIBLDR", "JIBLDR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4456_0", "Primary Key on JIMCUS, JIALOT, JIHSTY, JISCS, JIBYR", new[] { "JIMCUS", "JIALOT", "JIHSTY", "JISCS", "JIBYR" }, isUnique: true, isPrimaryKey: true)
    };
}
