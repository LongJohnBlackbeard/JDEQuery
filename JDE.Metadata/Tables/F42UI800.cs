using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI800 - .
/// </summary>
public class F42UI800 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDCTID.
        /// </summary>
        public const string SDCTID = "SDCTID";

        /// <summary>
        /// SDJOBS.
        /// </summary>
        public const string SDJOBS = "SDJOBS";

        /// <summary>
        /// SDMCU.
        /// </summary>
        public const string SDMCU = "SDMCU";

        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDDOC.
        /// </summary>
        public const string SDDOC = "SDDOC";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDKCO.
        /// </summary>
        public const string SDKCO = "SDKCO";

        /// <summary>
        /// SDEMCU.
        /// </summary>
        public const string SDEMCU = "SDEMCU";

        /// <summary>
        /// SDITM.
        /// </summary>
        public const string SDITM = "SDITM";

        /// <summary>
        /// SDLITM.
        /// </summary>
        public const string SDLITM = "SDLITM";

        /// <summary>
        /// SDAITM.
        /// </summary>
        public const string SDAITM = "SDAITM";

        /// <summary>
        /// SDCRR.
        /// </summary>
        public const string SDCRR = "SDCRR";

        /// <summary>
        /// SDCRDC.
        /// </summary>
        public const string SDCRDC = "SDCRDC";

        /// <summary>
        /// SDCRCD.
        /// </summary>
        public const string SDCRCD = "SDCRCD";

        /// <summary>
        /// SDCRCA.
        /// </summary>
        public const string SDCRCA = "SDCRCA";

        /// <summary>
        /// SDAEXP.
        /// </summary>
        public const string SDAEXP = "SDAEXP";

        /// <summary>
        /// SDECST.
        /// </summary>
        public const string SDECST = "SDECST";

        /// <summary>
        /// SDFUP.
        /// </summary>
        public const string SDFUP = "SDFUP";

        /// <summary>
        /// SDFEA.
        /// </summary>
        public const string SDFEA = "SDFEA";

        /// <summary>
        /// SDFUC.
        /// </summary>
        public const string SDFUC = "SDFUC";

        /// <summary>
        /// SDFEC.
        /// </summary>
        public const string SDFEC = "SDFEC";

        /// <summary>
        /// SDXEXP.
        /// </summary>
        public const string SDXEXP = "SDXEXP";

        /// <summary>
        /// SDXCST.
        /// </summary>
        public const string SDXCST = "SDXCST";

        /// <summary>
        /// SDXFEC.
        /// </summary>
        public const string SDXFEC = "SDXFEC";

        /// <summary>
        /// SDNXTR.
        /// </summary>
        public const string SDNXTR = "SDNXTR";

        /// <summary>
        /// SDLTTR.
        /// </summary>
        public const string SDLTTR = "SDLTTR";

        /// <summary>
        /// SDQTYT.
        /// </summary>
        public const string SDQTYT = "SDQTYT";

        /// <summary>
        /// SDPQOR.
        /// </summary>
        public const string SDPQOR = "SDPQOR";

        /// <summary>
        /// SDPN.
        /// </summary>
        public const string SDPN = "SDPN";

        /// <summary>
        /// SDFY.
        /// </summary>
        public const string SDFY = "SDFY";

        /// <summary>
        /// SDDGL.
        /// </summary>
        public const string SDDGL = "SDDGL";

        /// <summary>
        /// SDSO02.
        /// </summary>
        public const string SDSO02 = "SDSO02";

        /// <summary>
        /// SDAN8.
        /// </summary>
        public const string SDAN8 = "SDAN8";

        /// <summary>
        /// SDSHAN.
        /// </summary>
        public const string SDSHAN = "SDSHAN";

        /// <summary>
        /// SDIVD.
        /// </summary>
        public const string SDIVD = "SDIVD";

        /// <summary>
        /// SDALPH.
        /// </summary>
        public const string SDALPH = "SDALPH";

        /// <summary>
        /// SDLOTN.
        /// </summary>
        public const string SDLOTN = "SDLOTN";

        /// <summary>
        /// SDLOCN.
        /// </summary>
        public const string SDLOCN = "SDLOCN";

        /// <summary>
        /// SDPRGR.
        /// </summary>
        public const string SDPRGR = "SDPRGR";

        /// <summary>
        /// SDCLVL.
        /// </summary>
        public const string SDCLVL = "SDCLVL";

        /// <summary>
        /// SDUORG.
        /// </summary>
        public const string SDUORG = "SDUORG";

        /// <summary>
        /// SDSOQS.
        /// </summary>
        public const string SDSOQS = "SDSOQS";

        /// <summary>
        /// SDSOCN.
        /// </summary>
        public const string SDSOCN = "SDSOCN";

        /// <summary>
        /// SDSOBK.
        /// </summary>
        public const string SDSOBK = "SDSOBK";

        /// <summary>
        /// SDCOMM.
        /// </summary>
        public const string SDCOMM = "SDCOMM";

        /// <summary>
        /// SDOTQY.
        /// </summary>
        public const string SDOTQY = "SDOTQY";

        /// <summary>
        /// SDRCD.
        /// </summary>
        public const string SDRCD = "SDRCD";

        /// <summary>
        /// SDUOM.
        /// </summary>
        public const string SDUOM = "SDUOM";

        /// <summary>
        /// SDUNCS.
        /// </summary>
        public const string SDUNCS = "SDUNCS";

        /// <summary>
        /// SDGLC.
        /// </summary>
        public const string SDGLC = "SDGLC";

        /// <summary>
        /// SDTCST.
        /// </summary>
        public const string SDTCST = "SDTCST";

        /// <summary>
        /// SDTRDJ.
        /// </summary>
        public const string SDTRDJ = "SDTRDJ";

        /// <summary>
        /// SDLNTY.
        /// </summary>
        public const string SDLNTY = "SDLNTY";

        /// <summary>
        /// SDSRP1.
        /// </summary>
        public const string SDSRP1 = "SDSRP1";

        /// <summary>
        /// SDSRP2.
        /// </summary>
        public const string SDSRP2 = "SDSRP2";

        /// <summary>
        /// SDSRP3.
        /// </summary>
        public const string SDSRP3 = "SDSRP3";

        /// <summary>
        /// SDSRP4.
        /// </summary>
        public const string SDSRP4 = "SDSRP4";

        /// <summary>
        /// SDSRP5.
        /// </summary>
        public const string SDSRP5 = "SDSRP5";

        /// <summary>
        /// SDFRTH.
        /// </summary>
        public const string SDFRTH = "SDFRTH";

        /// <summary>
        /// SDPROV.
        /// </summary>
        public const string SDPROV = "SDPROV";

        /// <summary>
        /// SDATXT.
        /// </summary>
        public const string SDATXT = "SDATXT";

        /// <summary>
        /// SDEV01.
        /// </summary>
        public const string SDEV01 = "SDEV01";

        /// <summary>
        /// SDAC01.
        /// </summary>
        public const string SDAC01 = "SDAC01";

        /// <summary>
        /// SDAC02.
        /// </summary>
        public const string SDAC02 = "SDAC02";

        /// <summary>
        /// SDAC03.
        /// </summary>
        public const string SDAC03 = "SDAC03";

        /// <summary>
        /// SDAC04.
        /// </summary>
        public const string SDAC04 = "SDAC04";

        /// <summary>
        /// SDAC05.
        /// </summary>
        public const string SDAC05 = "SDAC05";

        /// <summary>
        /// SDWRTH.
        /// </summary>
        public const string SDWRTH = "SDWRTH";

        /// <summary>
        /// SDRYIN.
        /// </summary>
        public const string SDRYIN = "SDRYIN";

        /// <summary>
        /// SDCO.
        /// </summary>
        public const string SDCO = "SDCO";

        /// <summary>
        /// SDMPSP.
        /// </summary>
        public const string SDMPSP = "SDMPSP";

        /// <summary>
        /// SDANUM.
        /// </summary>
        public const string SDANUM = "SDANUM";

        /// <summary>
        /// SDSO09.
        /// </summary>
        public const string SDSO09 = "SDSO09";

        /// <summary>
        /// SDITWT.
        /// </summary>
        public const string SDITWT = "SDITWT";

        /// <summary>
        /// SDWUOM.
        /// </summary>
        public const string SDWUOM = "SDWUOM";

        /// <summary>
        /// SDSIDT.
        /// </summary>
        public const string SDSIDT = "SDSIDT";

        /// <summary>
        /// SDINCY.
        /// </summary>
        public const string SDINCY = "SDINCY";

        /// <summary>
        /// SDPDDJ.
        /// </summary>
        public const string SDPDDJ = "SDPDDJ";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";

        /// <summary>
        /// SDPSR.
        /// </summary>
        public const string SDPSR = "SDPSR";

        /// <summary>
        /// SDPSRY.
        /// </summary>
        public const string SDPSRY = "SDPSRY";

        /// <summary>
        /// SDDTO.
        /// </summary>
        public const string SDDTO = "SDDTO";

        /// <summary>
        /// SDDMCT.
        /// </summary>
        public const string SDDMCT = "SDDMCT";

        /// <summary>
        /// SDDMCS.
        /// </summary>
        public const string SDDMCS = "SDDMCS";

        /// <summary>
        /// SDSEQ.
        /// </summary>
        public const string SDSEQ = "SDSEQ";

        /// <summary>
        /// SDDEFF.
        /// </summary>
        public const string SDDEFF = "SDDEFF";

        /// <summary>
        /// SDDREV.
        /// </summary>
        public const string SDDREV = "SDDREV";

        /// <summary>
        /// SDFDRV.
        /// </summary>
        public const string SDFDRV = "SDFDRV";

        /// <summary>
        /// SDFDUC.
        /// </summary>
        public const string SDFDUC = "SDFDUC";

        /// <summary>
        /// SDDUNC.
        /// </summary>
        public const string SDDUNC = "SDDUNC";

        /// <summary>
        /// SDPSR1.
        /// </summary>
        public const string SDPSR1 = "SDPSR1";

        /// <summary>
        /// SDPSY2.
        /// </summary>
        public const string SDPSY2 = "SDPSY2";

        /// <summary>
        /// SDDTO2.
        /// </summary>
        public const string SDDTO2 = "SDDTO2";

        /// <summary>
        /// SDDMT1.
        /// </summary>
        public const string SDDMT1 = "SDDMT1";

        /// <summary>
        /// SDDMS1.
        /// </summary>
        public const string SDDMS1 = "SDDMS1";

        /// <summary>
        /// SDSEQ5.
        /// </summary>
        public const string SDSEQ5 = "SDSEQ5";

        /// <summary>
        /// SDUOM2.
        /// </summary>
        public const string SDUOM2 = "SDUOM2";

        /// <summary>
        /// SDSQOR.
        /// </summary>
        public const string SDSQOR = "SDSQOR";

        /// <summary>
        /// SDSO16.
        /// </summary>
        public const string SDSO16 = "SDSO16";

        /// <summary>
        /// SDDRQJ.
        /// </summary>
        public const string SDDRQJ = "SDDRQJ";

        /// <summary>
        /// SDN1FU.
        /// </summary>
        public const string SDN1FU = "SDN1FU";

        /// <summary>
        /// SDN2FU.
        /// </summary>
        public const string SDN2FU = "SDN2FU";

        /// <summary>
        /// SDN3FU.
        /// </summary>
        public const string SDN3FU = "SDN3FU";

        /// <summary>
        /// SDC1FU.
        /// </summary>
        public const string SDC1FU = "SDC1FU";

        /// <summary>
        /// SDC2FU.
        /// </summary>
        public const string SDC2FU = "SDC2FU";

        /// <summary>
        /// SDD1FU.
        /// </summary>
        public const string SDD1FU = "SDD1FU";

        /// <summary>
        /// SDD2FU.
        /// </summary>
        public const string SDD2FU = "SDD2FU";

        /// <summary>
        /// SDS1FU.
        /// </summary>
        public const string SDS1FU = "SDS1FU";

        /// <summary>
        /// SDS2FU.
        /// </summary>
        public const string SDS2FU = "SDS2FU";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI800";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDCTID", "SDCTID", JdeDataType.String, 30, true, true),
        new JdeField("SDJOBS", "SDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SDMCU", "SDMCU", JdeDataType.String, 24),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDOC", "SDDOC", JdeDataType.Numeric),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDKCO", "SDKCO", JdeDataType.String, 10),
        new JdeField("SDEMCU", "SDEMCU", JdeDataType.String, 24),
        new JdeField("SDITM", "SDITM", JdeDataType.Numeric),
        new JdeField("SDLITM", "SDLITM", JdeDataType.String, 50),
        new JdeField("SDAITM", "SDAITM", JdeDataType.String, 50),
        new JdeField("SDCRR", "SDCRR", JdeDataType.Numeric),
        new JdeField("SDCRDC", "SDCRDC", JdeDataType.String, 6),
        new JdeField("SDCRCD", "SDCRCD", JdeDataType.String, 6),
        new JdeField("SDCRCA", "SDCRCA", JdeDataType.String, 6),
        new JdeField("SDAEXP", "SDAEXP", JdeDataType.Numeric),
        new JdeField("SDECST", "SDECST", JdeDataType.Numeric),
        new JdeField("SDFUP", "SDFUP", JdeDataType.Numeric),
        new JdeField("SDFEA", "SDFEA", JdeDataType.Numeric),
        new JdeField("SDFUC", "SDFUC", JdeDataType.Numeric),
        new JdeField("SDFEC", "SDFEC", JdeDataType.Numeric),
        new JdeField("SDXEXP", "SDXEXP", JdeDataType.Numeric),
        new JdeField("SDXCST", "SDXCST", JdeDataType.Numeric),
        new JdeField("SDXFEC", "SDXFEC", JdeDataType.Numeric),
        new JdeField("SDNXTR", "SDNXTR", JdeDataType.String, 6),
        new JdeField("SDLTTR", "SDLTTR", JdeDataType.String, 6),
        new JdeField("SDQTYT", "SDQTYT", JdeDataType.Numeric),
        new JdeField("SDPQOR", "SDPQOR", JdeDataType.Numeric),
        new JdeField("SDPN", "SDPN", JdeDataType.Numeric),
        new JdeField("SDFY", "SDFY", JdeDataType.Numeric),
        new JdeField("SDDGL", "SDDGL", JdeDataType.Numeric),
        new JdeField("SDSO02", "SDSO02", JdeDataType.String, 2),
        new JdeField("SDAN8", "SDAN8", JdeDataType.Numeric),
        new JdeField("SDSHAN", "SDSHAN", JdeDataType.Numeric),
        new JdeField("SDIVD", "SDIVD", JdeDataType.Numeric),
        new JdeField("SDALPH", "SDALPH", JdeDataType.String, 80),
        new JdeField("SDLOTN", "SDLOTN", JdeDataType.String, 60),
        new JdeField("SDLOCN", "SDLOCN", JdeDataType.String, 40),
        new JdeField("SDPRGR", "SDPRGR", JdeDataType.String, 16),
        new JdeField("SDCLVL", "SDCLVL", JdeDataType.String, 6),
        new JdeField("SDUORG", "SDUORG", JdeDataType.Numeric),
        new JdeField("SDSOQS", "SDSOQS", JdeDataType.Numeric),
        new JdeField("SDSOCN", "SDSOCN", JdeDataType.Numeric),
        new JdeField("SDSOBK", "SDSOBK", JdeDataType.Numeric),
        new JdeField("SDCOMM", "SDCOMM", JdeDataType.String, 2),
        new JdeField("SDOTQY", "SDOTQY", JdeDataType.String, 2),
        new JdeField("SDRCD", "SDRCD", JdeDataType.String, 6),
        new JdeField("SDUOM", "SDUOM", JdeDataType.String, 4),
        new JdeField("SDUNCS", "SDUNCS", JdeDataType.Numeric),
        new JdeField("SDGLC", "SDGLC", JdeDataType.String, 8),
        new JdeField("SDTCST", "SDTCST", JdeDataType.Numeric),
        new JdeField("SDTRDJ", "SDTRDJ", JdeDataType.Numeric),
        new JdeField("SDLNTY", "SDLNTY", JdeDataType.String, 4),
        new JdeField("SDSRP1", "SDSRP1", JdeDataType.String, 6),
        new JdeField("SDSRP2", "SDSRP2", JdeDataType.String, 6),
        new JdeField("SDSRP3", "SDSRP3", JdeDataType.String, 6),
        new JdeField("SDSRP4", "SDSRP4", JdeDataType.String, 6),
        new JdeField("SDSRP5", "SDSRP5", JdeDataType.String, 6),
        new JdeField("SDFRTH", "SDFRTH", JdeDataType.String, 6),
        new JdeField("SDPROV", "SDPROV", JdeDataType.String, 2),
        new JdeField("SDATXT", "SDATXT", JdeDataType.String, 2),
        new JdeField("SDEV01", "SDEV01", JdeDataType.String, 2),
        new JdeField("SDAC01", "SDAC01", JdeDataType.String, 6),
        new JdeField("SDAC02", "SDAC02", JdeDataType.String, 6),
        new JdeField("SDAC03", "SDAC03", JdeDataType.String, 6),
        new JdeField("SDAC04", "SDAC04", JdeDataType.String, 6),
        new JdeField("SDAC05", "SDAC05", JdeDataType.String, 6),
        new JdeField("SDWRTH", "SDWRTH", JdeDataType.String, 2),
        new JdeField("SDRYIN", "SDRYIN", JdeDataType.String, 2),
        new JdeField("SDCO", "SDCO", JdeDataType.String, 10),
        new JdeField("SDMPSP", "SDMPSP", JdeDataType.String, 2),
        new JdeField("SDANUM", "SDANUM", JdeDataType.Numeric),
        new JdeField("SDSO09", "SDSO09", JdeDataType.String, 2),
        new JdeField("SDITWT", "SDITWT", JdeDataType.Numeric),
        new JdeField("SDWUOM", "SDWUOM", JdeDataType.String, 4),
        new JdeField("SDSIDT", "SDSIDT", JdeDataType.Numeric),
        new JdeField("SDINCY", "SDINCY", JdeDataType.String, 6),
        new JdeField("SDPDDJ", "SDPDDJ", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric),
        new JdeField("SDPSR", "SDPSR", JdeDataType.String, 24),
        new JdeField("SDPSRY", "SDPSRY", JdeDataType.String, 4),
        new JdeField("SDDTO", "SDDTO", JdeDataType.String, 2),
        new JdeField("SDDMCT", "SDDMCT", JdeDataType.String, 24),
        new JdeField("SDDMCS", "SDDMCS", JdeDataType.Numeric),
        new JdeField("SDSEQ", "SDSEQ", JdeDataType.Numeric),
        new JdeField("SDDEFF", "SDDEFF", JdeDataType.String, 2),
        new JdeField("SDDREV", "SDDREV", JdeDataType.Numeric),
        new JdeField("SDFDRV", "SDFDRV", JdeDataType.Numeric),
        new JdeField("SDFDUC", "SDFDUC", JdeDataType.Numeric),
        new JdeField("SDDUNC", "SDDUNC", JdeDataType.Numeric),
        new JdeField("SDPSR1", "SDPSR1", JdeDataType.String, 24),
        new JdeField("SDPSY2", "SDPSY2", JdeDataType.String, 4),
        new JdeField("SDDTO2", "SDDTO2", JdeDataType.String, 2),
        new JdeField("SDDMT1", "SDDMT1", JdeDataType.String, 24),
        new JdeField("SDDMS1", "SDDMS1", JdeDataType.Numeric),
        new JdeField("SDSEQ5", "SDSEQ5", JdeDataType.Numeric),
        new JdeField("SDUOM2", "SDUOM2", JdeDataType.String, 4),
        new JdeField("SDSQOR", "SDSQOR", JdeDataType.Numeric),
        new JdeField("SDSO16", "SDSO16", JdeDataType.String, 2),
        new JdeField("SDDRQJ", "SDDRQJ", JdeDataType.Numeric),
        new JdeField("SDN1FU", "SDN1FU", JdeDataType.Numeric),
        new JdeField("SDN2FU", "SDN2FU", JdeDataType.Numeric),
        new JdeField("SDN3FU", "SDN3FU", JdeDataType.Numeric),
        new JdeField("SDC1FU", "SDC1FU", JdeDataType.String, 2),
        new JdeField("SDC2FU", "SDC2FU", JdeDataType.String, 2),
        new JdeField("SDD1FU", "SDD1FU", JdeDataType.Numeric),
        new JdeField("SDD2FU", "SDD2FU", JdeDataType.Numeric),
        new JdeField("SDS1FU", "SDS1FU", JdeDataType.String, 60),
        new JdeField("SDS2FU", "SDS2FU", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI800_0", "Primary Key on SDCTID, SDJOBS, SDDOCO, SDDCTO, SDKCOO, SDLNID", new[] { "SDCTID", "SDJOBS", "SDDOCO", "SDDCTO", "SDKCOO", "SDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI800_2", "Index on SDCTID, SDJOBS", new[] { "SDCTID", "SDJOBS" }),
        new JdeIndex("F42UI800_3", "Index on SDCTID, SDJOBS, SDDOC, SDDCT, SDKCO", new[] { "SDCTID", "SDJOBS", "SDDOC", "SDDCT", "SDKCO" })
    };
}
