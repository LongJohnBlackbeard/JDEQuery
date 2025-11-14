using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4450 - .
/// </summary>
public class F4450 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDMCUS.
        /// </summary>
        public const string JDMCUS = "JDMCUS";

        /// <summary>
        /// JDMCU.
        /// </summary>
        public const string JDMCU = "JDMCU";

        /// <summary>
        /// JDALOT.
        /// </summary>
        public const string JDALOT = "JDALOT";

        /// <summary>
        /// JDSFXO.
        /// </summary>
        public const string JDSFXO = "JDSFXO";

        /// <summary>
        /// JDPL.
        /// </summary>
        public const string JDPL = "JDPL";

        /// <summary>
        /// JDELEV.
        /// </summary>
        public const string JDELEV = "JDELEV";

        /// <summary>
        /// JDSTDJ.
        /// </summary>
        public const string JDSTDJ = "JDSTDJ";

        /// <summary>
        /// JDLNT.
        /// </summary>
        public const string JDLNT = "JDLNT";

        /// <summary>
        /// JDPMN.
        /// </summary>
        public const string JDPMN = "JDPMN";

        /// <summary>
        /// JDCLRH.
        /// </summary>
        public const string JDCLRH = "JDCLRH";

        /// <summary>
        /// JDCLPK.
        /// </summary>
        public const string JDCLPK = "JDCLPK";

        /// <summary>
        /// JDSWG.
        /// </summary>
        public const string JDSWG = "JDSWG";

        /// <summary>
        /// JDBYR.
        /// </summary>
        public const string JDBYR = "JDBYR";

        /// <summary>
        /// JDASC.
        /// </summary>
        public const string JDASC = "JDASC";

        /// <summary>
        /// JDSDJ.
        /// </summary>
        public const string JDSDJ = "JDSDJ";

        /// <summary>
        /// JDEDJ.
        /// </summary>
        public const string JDEDJ = "JDEDJ";

        /// <summary>
        /// JDBSP.
        /// </summary>
        public const string JDBSP = "JDBSP";

        /// <summary>
        /// JDLTP.
        /// </summary>
        public const string JDLTP = "JDLTP";

        /// <summary>
        /// JDINCA.
        /// </summary>
        public const string JDINCA = "JDINCA";

        /// <summary>
        /// JDPN1.
        /// </summary>
        public const string JDPN1 = "JDPN1";

        /// <summary>
        /// JDPN2.
        /// </summary>
        public const string JDPN2 = "JDPN2";

        /// <summary>
        /// JDPN3.
        /// </summary>
        public const string JDPN3 = "JDPN3";

        /// <summary>
        /// JDPN4.
        /// </summary>
        public const string JDPN4 = "JDPN4";

        /// <summary>
        /// JDPN5.
        /// </summary>
        public const string JDPN5 = "JDPN5";

        /// <summary>
        /// JDPN6.
        /// </summary>
        public const string JDPN6 = "JDPN6";

        /// <summary>
        /// JDJOBN.
        /// </summary>
        public const string JDJOBN = "JDJOBN";

        /// <summary>
        /// JDPID.
        /// </summary>
        public const string JDPID = "JDPID";

        /// <summary>
        /// JDUSER.
        /// </summary>
        public const string JDUSER = "JDUSER";

        /// <summary>
        /// JDUPMJ.
        /// </summary>
        public const string JDUPMJ = "JDUPMJ";

        /// <summary>
        /// JDACCL.
        /// </summary>
        public const string JDACCL = "JDACCL";

        /// <summary>
        /// JDBDC.
        /// </summary>
        public const string JDBDC = "JDBDC";

        /// <summary>
        /// JDFSC.
        /// </summary>
        public const string JDFSC = "JDFSC";

        /// <summary>
        /// JDHSTY.
        /// </summary>
        public const string JDHSTY = "JDHSTY";

        /// <summary>
        /// JDUPG.
        /// </summary>
        public const string JDUPG = "JDUPG";

        /// <summary>
        /// JDTSP.
        /// </summary>
        public const string JDTSP = "JDTSP";

        /// <summary>
        /// JDSUB.
        /// </summary>
        public const string JDSUB = "JDSUB";

        /// <summary>
        /// JDDL01.
        /// </summary>
        public const string JDDL01 = "JDDL01";

        /// <summary>
        /// JDROF.
        /// </summary>
        public const string JDROF = "JDROF";

        /// <summary>
        /// JDSLP.
        /// </summary>
        public const string JDSLP = "JDSLP";

        /// <summary>
        /// JDATFN.
        /// </summary>
        public const string JDATFN = "JDATFN";

        /// <summary>
        /// JDCTGJ.
        /// </summary>
        public const string JDCTGJ = "JDCTGJ";

        /// <summary>
        /// JDCRD.
        /// </summary>
        public const string JDCRD = "JDCRD";

        /// <summary>
        /// JDCXD.
        /// </summary>
        public const string JDCXD = "JDCXD";

        /// <summary>
        /// JDLRD.
        /// </summary>
        public const string JDLRD = "JDLRD";

        /// <summary>
        /// JDPTDJ.
        /// </summary>
        public const string JDPTDJ = "JDPTDJ";

        /// <summary>
        /// JDPHD.
        /// </summary>
        public const string JDPHD = "JDPHD";

        /// <summary>
        /// JDCTYJ.
        /// </summary>
        public const string JDCTYJ = "JDCTYJ";

        /// <summary>
        /// JDPRD.
        /// </summary>
        public const string JDPRD = "JDPRD";

        /// <summary>
        /// JDSWD.
        /// </summary>
        public const string JDSWD = "JDSWD";

        /// <summary>
        /// JDSWT.
        /// </summary>
        public const string JDSWT = "JDSWT";

        /// <summary>
        /// JDTAD.
        /// </summary>
        public const string JDTAD = "JDTAD";

        /// <summary>
        /// JDPXD.
        /// </summary>
        public const string JDPXD = "JDPXD";

        /// <summary>
        /// JDOD1.
        /// </summary>
        public const string JDOD1 = "JDOD1";

        /// <summary>
        /// JDOD2.
        /// </summary>
        public const string JDOD2 = "JDOD2";

        /// <summary>
        /// JDOD3.
        /// </summary>
        public const string JDOD3 = "JDOD3";

        /// <summary>
        /// JDLDN.
        /// </summary>
        public const string JDLDN = "JDLDN";

        /// <summary>
        /// JDCN1.
        /// </summary>
        public const string JDCN1 = "JDCN1";

        /// <summary>
        /// JDCN2.
        /// </summary>
        public const string JDCN2 = "JDCN2";

        /// <summary>
        /// JDON1.
        /// </summary>
        public const string JDON1 = "JDON1";

        /// <summary>
        /// JDON2.
        /// </summary>
        public const string JDON2 = "JDON2";

        /// <summary>
        /// JDON3.
        /// </summary>
        public const string JDON3 = "JDON3";

        /// <summary>
        /// JDINR.
        /// </summary>
        public const string JDINR = "JDINR";

        /// <summary>
        /// JDMGA.
        /// </summary>
        public const string JDMGA = "JDMGA";

        /// <summary>
        /// JDDNPT.
        /// </summary>
        public const string JDDNPT = "JDDNPT";

        /// <summary>
        /// JDEMD.
        /// </summary>
        public const string JDEMD = "JDEMD";

        /// <summary>
        /// JDOA1.
        /// </summary>
        public const string JDOA1 = "JDOA1";

        /// <summary>
        /// JDOA2.
        /// </summary>
        public const string JDOA2 = "JDOA2";

        /// <summary>
        /// JDCDJ.
        /// </summary>
        public const string JDCDJ = "JDCDJ";

        /// <summary>
        /// JDSCS.
        /// </summary>
        public const string JDSCS = "JDSCS";

        /// <summary>
        /// JDCPJ.
        /// </summary>
        public const string JDCPJ = "JDCPJ";

        /// <summary>
        /// JDMAD.
        /// </summary>
        public const string JDMAD = "JDMAD";

        /// <summary>
        /// JDLADJ.
        /// </summary>
        public const string JDLADJ = "JDLADJ";

        /// <summary>
        /// JDCTGS.
        /// </summary>
        public const string JDCTGS = "JDCTGS";

        /// <summary>
        /// JDCBK.
        /// </summary>
        public const string JDCBK = "JDCBK";

        /// <summary>
        /// JDUSD1.
        /// </summary>
        public const string JDUSD1 = "JDUSD1";

        /// <summary>
        /// JDUSD2.
        /// </summary>
        public const string JDUSD2 = "JDUSD2";

        /// <summary>
        /// JDUSD3.
        /// </summary>
        public const string JDUSD3 = "JDUSD3";

        /// <summary>
        /// JDUC01.
        /// </summary>
        public const string JDUC01 = "JDUC01";

        /// <summary>
        /// JDUC02.
        /// </summary>
        public const string JDUC02 = "JDUC02";

        /// <summary>
        /// JDUC03.
        /// </summary>
        public const string JDUC03 = "JDUC03";

        /// <summary>
        /// JDF1T.
        /// </summary>
        public const string JDF1T = "JDF1T";

        /// <summary>
        /// JDF2T.
        /// </summary>
        public const string JDF2T = "JDF2T";

        /// <summary>
        /// JDF3T.
        /// </summary>
        public const string JDF3T = "JDF3T";

        /// <summary>
        /// JDF1A.
        /// </summary>
        public const string JDF1A = "JDF1A";

        /// <summary>
        /// JDF2A.
        /// </summary>
        public const string JDF2A = "JDF2A";

        /// <summary>
        /// JDF3A.
        /// </summary>
        public const string JDF3A = "JDF3A";

        /// <summary>
        /// JDPSG.
        /// </summary>
        public const string JDPSG = "JDPSG";

        /// <summary>
        /// JDCLT.
        /// </summary>
        public const string JDCLT = "JDCLT";

        /// <summary>
        /// JDDOC1.
        /// </summary>
        public const string JDDOC1 = "JDDOC1";

        /// <summary>
        /// JDDOC2.
        /// </summary>
        public const string JDDOC2 = "JDDOC2";

        /// <summary>
        /// JDDOC3.
        /// </summary>
        public const string JDDOC3 = "JDDOC3";

        /// <summary>
        /// JDDCT1.
        /// </summary>
        public const string JDDCT1 = "JDDCT1";

        /// <summary>
        /// JDDCT2.
        /// </summary>
        public const string JDDCT2 = "JDDCT2";

        /// <summary>
        /// JDDCT3.
        /// </summary>
        public const string JDDCT3 = "JDDCT3";

        /// <summary>
        /// JDLDR.
        /// </summary>
        public const string JDLDR = "JDLDR";

        /// <summary>
        /// JDASC2.
        /// </summary>
        public const string JDASC2 = "JDASC2";

        /// <summary>
        /// JDASC3.
        /// </summary>
        public const string JDASC3 = "JDASC3";

        /// <summary>
        /// JDCM1.
        /// </summary>
        public const string JDCM1 = "JDCM1";

        /// <summary>
        /// JDCM2.
        /// </summary>
        public const string JDCM2 = "JDCM2";

        /// <summary>
        /// JDCM3.
        /// </summary>
        public const string JDCM3 = "JDCM3";

        /// <summary>
        /// JDUSD4.
        /// </summary>
        public const string JDUSD4 = "JDUSD4";

        /// <summary>
        /// JDUSD5.
        /// </summary>
        public const string JDUSD5 = "JDUSD5";

        /// <summary>
        /// JDUSD6.
        /// </summary>
        public const string JDUSD6 = "JDUSD6";

        /// <summary>
        /// JDPC1.
        /// </summary>
        public const string JDPC1 = "JDPC1";

        /// <summary>
        /// JDPC2.
        /// </summary>
        public const string JDPC2 = "JDPC2";

        /// <summary>
        /// JDPC3.
        /// </summary>
        public const string JDPC3 = "JDPC3";

        /// <summary>
        /// JDCBN.
        /// </summary>
        public const string JDCBN = "JDCBN";

        /// <summary>
        /// JDCLJ.
        /// </summary>
        public const string JDCLJ = "JDCLJ";

        /// <summary>
        /// JDLAG.
        /// </summary>
        public const string JDLAG = "JDLAG";

        /// <summary>
        /// JDPTX.
        /// </summary>
        public const string JDPTX = "JDPTX";

        /// <summary>
        /// JDLNN.
        /// </summary>
        public const string JDLNN = "JDLNN";

        /// <summary>
        /// JDOP1.
        /// </summary>
        public const string JDOP1 = "JDOP1";

        /// <summary>
        /// JDOP2.
        /// </summary>
        public const string JDOP2 = "JDOP2";

        /// <summary>
        /// JDOP3.
        /// </summary>
        public const string JDOP3 = "JDOP3";

        /// <summary>
        /// JDDSN1.
        /// </summary>
        public const string JDDSN1 = "JDDSN1";

        /// <summary>
        /// JDDSN2.
        /// </summary>
        public const string JDDSN2 = "JDDSN2";

        /// <summary>
        /// JDDSC1.
        /// </summary>
        public const string JDDSC1 = "JDDSC1";

        /// <summary>
        /// JDDSC2.
        /// </summary>
        public const string JDDSC2 = "JDDSC2";

        /// <summary>
        /// JDDSC3.
        /// </summary>
        public const string JDDSC3 = "JDDSC3";

        /// <summary>
        /// JDF4A.
        /// </summary>
        public const string JDF4A = "JDF4A";

        /// <summary>
        /// JDF5A.
        /// </summary>
        public const string JDF5A = "JDF5A";

        /// <summary>
        /// JDF6A.
        /// </summary>
        public const string JDF6A = "JDF6A";

        /// <summary>
        /// JDUSD7.
        /// </summary>
        public const string JDUSD7 = "JDUSD7";

        /// <summary>
        /// JDUSD8.
        /// </summary>
        public const string JDUSD8 = "JDUSD8";

        /// <summary>
        /// JDUSD9.
        /// </summary>
        public const string JDUSD9 = "JDUSD9";

        /// <summary>
        /// JDUC04.
        /// </summary>
        public const string JDUC04 = "JDUC04";

        /// <summary>
        /// JDUC05.
        /// </summary>
        public const string JDUC05 = "JDUC05";

        /// <summary>
        /// JDUC06.
        /// </summary>
        public const string JDUC06 = "JDUC06";

        /// <summary>
        /// JDDTKN.
        /// </summary>
        public const string JDDTKN = "JDDTKN";

        /// <summary>
        /// JDSLKF.
        /// </summary>
        public const string JDSLKF = "JDSLKF";

        /// <summary>
        /// JDBLDR.
        /// </summary>
        public const string JDBLDR = "JDBLDR";
    }

    /// <inheritdoc />
    public override string TableName => "F4450";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDMCUS", "JDMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JDMCU", "JDMCU", JdeDataType.String, 24),
        new JdeField("JDALOT", "JDALOT", JdeDataType.String, 8, true, true),
        new JdeField("JDSFXO", "JDSFXO", JdeDataType.String, 6),
        new JdeField("JDPL", "JDPL", JdeDataType.String, 8),
        new JdeField("JDELEV", "JDELEV", JdeDataType.String, 6),
        new JdeField("JDSTDJ", "JDSTDJ", JdeDataType.Numeric),
        new JdeField("JDLNT", "JDLNT", JdeDataType.String, 16),
        new JdeField("JDPMN", "JDPMN", JdeDataType.String, 24),
        new JdeField("JDCLRH", "JDCLRH", JdeDataType.String, 2),
        new JdeField("JDCLPK", "JDCLPK", JdeDataType.String, 20),
        new JdeField("JDSWG", "JDSWG", JdeDataType.String, 2),
        new JdeField("JDBYR", "JDBYR", JdeDataType.Numeric),
        new JdeField("JDASC", "JDASC", JdeDataType.Numeric),
        new JdeField("JDSDJ", "JDSDJ", JdeDataType.Numeric),
        new JdeField("JDEDJ", "JDEDJ", JdeDataType.Numeric),
        new JdeField("JDBSP", "JDBSP", JdeDataType.Numeric),
        new JdeField("JDLTP", "JDLTP", JdeDataType.Numeric),
        new JdeField("JDINCA", "JDINCA", JdeDataType.Numeric),
        new JdeField("JDPN1", "JDPN1", JdeDataType.String, 60),
        new JdeField("JDPN2", "JDPN2", JdeDataType.String, 60),
        new JdeField("JDPN3", "JDPN3", JdeDataType.String, 60),
        new JdeField("JDPN4", "JDPN4", JdeDataType.String, 60),
        new JdeField("JDPN5", "JDPN5", JdeDataType.String, 60),
        new JdeField("JDPN6", "JDPN6", JdeDataType.String, 60),
        new JdeField("JDJOBN", "JDJOBN", JdeDataType.String, 20),
        new JdeField("JDPID", "JDPID", JdeDataType.String, 20),
        new JdeField("JDUSER", "JDUSER", JdeDataType.String, 20),
        new JdeField("JDUPMJ", "JDUPMJ", JdeDataType.Numeric),
        new JdeField("JDACCL", "JDACCL", JdeDataType.String, 30),
        new JdeField("JDBDC", "JDBDC", JdeDataType.String, 30),
        new JdeField("JDFSC", "JDFSC", JdeDataType.String, 30),
        new JdeField("JDHSTY", "JDHSTY", JdeDataType.String, 2),
        new JdeField("JDUPG", "JDUPG", JdeDataType.Numeric),
        new JdeField("JDTSP", "JDTSP", JdeDataType.Numeric),
        new JdeField("JDSUB", "JDSUB", JdeDataType.String, 16),
        new JdeField("JDDL01", "JDDL01", JdeDataType.String, 60),
        new JdeField("JDROF", "JDROF", JdeDataType.String, 30),
        new JdeField("JDSLP", "JDSLP", JdeDataType.Numeric),
        new JdeField("JDATFN", "JDATFN", JdeDataType.Numeric),
        new JdeField("JDCTGJ", "JDCTGJ", JdeDataType.Numeric),
        new JdeField("JDCRD", "JDCRD", JdeDataType.Numeric),
        new JdeField("JDCXD", "JDCXD", JdeDataType.Numeric),
        new JdeField("JDLRD", "JDLRD", JdeDataType.Numeric),
        new JdeField("JDPTDJ", "JDPTDJ", JdeDataType.Numeric),
        new JdeField("JDPHD", "JDPHD", JdeDataType.Numeric),
        new JdeField("JDCTYJ", "JDCTYJ", JdeDataType.Numeric),
        new JdeField("JDPRD", "JDPRD", JdeDataType.Numeric),
        new JdeField("JDSWD", "JDSWD", JdeDataType.Numeric),
        new JdeField("JDSWT", "JDSWT", JdeDataType.String, 16),
        new JdeField("JDTAD", "JDTAD", JdeDataType.Numeric),
        new JdeField("JDPXD", "JDPXD", JdeDataType.Numeric),
        new JdeField("JDOD1", "JDOD1", JdeDataType.Numeric),
        new JdeField("JDOD2", "JDOD2", JdeDataType.Numeric),
        new JdeField("JDOD3", "JDOD3", JdeDataType.Numeric),
        new JdeField("JDLDN", "JDLDN", JdeDataType.String, 60),
        new JdeField("JDCN1", "JDCN1", JdeDataType.String, 60),
        new JdeField("JDCN2", "JDCN2", JdeDataType.String, 60),
        new JdeField("JDON1", "JDON1", JdeDataType.String, 60),
        new JdeField("JDON2", "JDON2", JdeDataType.String, 60),
        new JdeField("JDON3", "JDON3", JdeDataType.String, 60),
        new JdeField("JDINR", "JDINR", JdeDataType.Numeric),
        new JdeField("JDMGA", "JDMGA", JdeDataType.Numeric),
        new JdeField("JDDNPT", "JDDNPT", JdeDataType.Numeric),
        new JdeField("JDEMD", "JDEMD", JdeDataType.Numeric),
        new JdeField("JDOA1", "JDOA1", JdeDataType.Numeric),
        new JdeField("JDOA2", "JDOA2", JdeDataType.Numeric),
        new JdeField("JDCDJ", "JDCDJ", JdeDataType.Numeric),
        new JdeField("JDSCS", "JDSCS", JdeDataType.String, 2),
        new JdeField("JDCPJ", "JDCPJ", JdeDataType.Numeric),
        new JdeField("JDMAD", "JDMAD", JdeDataType.Numeric),
        new JdeField("JDLADJ", "JDLADJ", JdeDataType.Numeric),
        new JdeField("JDCTGS", "JDCTGS", JdeDataType.String, 16),
        new JdeField("JDCBK", "JDCBK", JdeDataType.String, 2),
        new JdeField("JDUSD1", "JDUSD1", JdeDataType.Numeric),
        new JdeField("JDUSD2", "JDUSD2", JdeDataType.Numeric),
        new JdeField("JDUSD3", "JDUSD3", JdeDataType.Numeric),
        new JdeField("JDUC01", "JDUC01", JdeDataType.String, 2),
        new JdeField("JDUC02", "JDUC02", JdeDataType.String, 2),
        new JdeField("JDUC03", "JDUC03", JdeDataType.String, 2),
        new JdeField("JDF1T", "JDF1T", JdeDataType.String, 60),
        new JdeField("JDF2T", "JDF2T", JdeDataType.String, 60),
        new JdeField("JDF3T", "JDF3T", JdeDataType.String, 60),
        new JdeField("JDF1A", "JDF1A", JdeDataType.Numeric),
        new JdeField("JDF2A", "JDF2A", JdeDataType.Numeric),
        new JdeField("JDF3A", "JDF3A", JdeDataType.Numeric),
        new JdeField("JDPSG", "JDPSG", JdeDataType.Numeric),
        new JdeField("JDCLT", "JDCLT", JdeDataType.String, 8),
        new JdeField("JDDOC1", "JDDOC1", JdeDataType.Numeric),
        new JdeField("JDDOC2", "JDDOC2", JdeDataType.Numeric),
        new JdeField("JDDOC3", "JDDOC3", JdeDataType.Numeric),
        new JdeField("JDDCT1", "JDDCT1", JdeDataType.String, 4),
        new JdeField("JDDCT2", "JDDCT2", JdeDataType.String, 4),
        new JdeField("JDDCT3", "JDDCT3", JdeDataType.String, 4),
        new JdeField("JDLDR", "JDLDR", JdeDataType.Numeric),
        new JdeField("JDASC2", "JDASC2", JdeDataType.Numeric),
        new JdeField("JDASC3", "JDASC3", JdeDataType.Numeric),
        new JdeField("JDCM1", "JDCM1", JdeDataType.Numeric),
        new JdeField("JDCM2", "JDCM2", JdeDataType.Numeric),
        new JdeField("JDCM3", "JDCM3", JdeDataType.Numeric),
        new JdeField("JDUSD4", "JDUSD4", JdeDataType.Numeric),
        new JdeField("JDUSD5", "JDUSD5", JdeDataType.Numeric),
        new JdeField("JDUSD6", "JDUSD6", JdeDataType.Numeric),
        new JdeField("JDPC1", "JDPC1", JdeDataType.Numeric),
        new JdeField("JDPC2", "JDPC2", JdeDataType.Numeric),
        new JdeField("JDPC3", "JDPC3", JdeDataType.Numeric),
        new JdeField("JDCBN", "JDCBN", JdeDataType.Numeric),
        new JdeField("JDCLJ", "JDCLJ", JdeDataType.Numeric),
        new JdeField("JDLAG", "JDLAG", JdeDataType.Numeric),
        new JdeField("JDPTX", "JDPTX", JdeDataType.String, 60),
        new JdeField("JDLNN", "JDLNN", JdeDataType.String, 16),
        new JdeField("JDOP1", "JDOP1", JdeDataType.Numeric),
        new JdeField("JDOP2", "JDOP2", JdeDataType.Numeric),
        new JdeField("JDOP3", "JDOP3", JdeDataType.Numeric),
        new JdeField("JDDSN1", "JDDSN1", JdeDataType.Numeric),
        new JdeField("JDDSN2", "JDDSN2", JdeDataType.Numeric),
        new JdeField("JDDSC1", "JDDSC1", JdeDataType.String, 60),
        new JdeField("JDDSC2", "JDDSC2", JdeDataType.String, 60),
        new JdeField("JDDSC3", "JDDSC3", JdeDataType.String, 60),
        new JdeField("JDF4A", "JDF4A", JdeDataType.Numeric),
        new JdeField("JDF5A", "JDF5A", JdeDataType.Numeric),
        new JdeField("JDF6A", "JDF6A", JdeDataType.Numeric),
        new JdeField("JDUSD7", "JDUSD7", JdeDataType.Numeric),
        new JdeField("JDUSD8", "JDUSD8", JdeDataType.Numeric),
        new JdeField("JDUSD9", "JDUSD9", JdeDataType.Numeric),
        new JdeField("JDUC04", "JDUC04", JdeDataType.String, 2),
        new JdeField("JDUC05", "JDUC05", JdeDataType.String, 2),
        new JdeField("JDUC06", "JDUC06", JdeDataType.String, 2),
        new JdeField("JDDTKN", "JDDTKN", JdeDataType.Numeric),
        new JdeField("JDSLKF", "JDSLKF", JdeDataType.String, 2),
        new JdeField("JDBLDR", "JDBLDR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4450_0", "Primary Key on JDMCUS, JDALOT", new[] { "JDMCUS", "JDALOT" }, isUnique: true, isPrimaryKey: true)
    };
}
