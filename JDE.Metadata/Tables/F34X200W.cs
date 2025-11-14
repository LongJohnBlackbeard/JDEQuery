using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X200W - .
/// </summary>
public class F34X200W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDJOBS.
        /// </summary>
        public const string SDJOBS = "SDJOBS";

        /// <summary>
        /// SDITM.
        /// </summary>
        public const string SDITM = "SDITM";

        /// <summary>
        /// SDMCU.
        /// </summary>
        public const string SDMCU = "SDMCU";

        /// <summary>
        /// SD34XSDDJ.
        /// </summary>
        public const string SD34XSDDJ = "SD34XSDDJ";

        /// <summary>
        /// SD34XSDDJU.
        /// </summary>
        public const string SD34XSDDJU = "SD34XSDDJU";

        /// <summary>
        /// SD34XSDC.
        /// </summary>
        public const string SD34XSDC = "SD34XSDC";

        /// <summary>
        /// SD34XSDDS.
        /// </summary>
        public const string SD34XSDDS = "SD34XSDDS";

        /// <summary>
        /// SD34XSDC1.
        /// </summary>
        public const string SD34XSDC1 = "SD34XSDC1";

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
        /// SDSFXO.
        /// </summary>
        public const string SDSFXO = "SDSFXO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SD34XSDC2.
        /// </summary>
        public const string SD34XSDC2 = "SD34XSDC2";

        /// <summary>
        /// SD34XUKID1.
        /// </summary>
        public const string SD34XUKID1 = "SD34XUKID1";

        /// <summary>
        /// SD34XUKID4.
        /// </summary>
        public const string SD34XUKID4 = "SD34XUKID4";

        /// <summary>
        /// SDUOM.
        /// </summary>
        public const string SDUOM = "SDUOM";

        /// <summary>
        /// SDLOCN.
        /// </summary>
        public const string SDLOCN = "SDLOCN";

        /// <summary>
        /// SDLOTN.
        /// </summary>
        public const string SDLOTN = "SDLOTN";

        /// <summary>
        /// SDSTRT.
        /// </summary>
        public const string SDSTRT = "SDSTRT";

        /// <summary>
        /// SD34XSTRJU.
        /// </summary>
        public const string SD34XSTRJU = "SD34XSTRJU";

        /// <summary>
        /// SDDRQJ.
        /// </summary>
        public const string SDDRQJ = "SDDRQJ";

        /// <summary>
        /// SD34XDRQJU.
        /// </summary>
        public const string SD34XDRQJU = "SD34XDRQJU";

        /// <summary>
        /// SDTRDJ.
        /// </summary>
        public const string SDTRDJ = "SDTRDJ";

        /// <summary>
        /// SDPDDJ.
        /// </summary>
        public const string SDPDDJ = "SDPDDJ";

        /// <summary>
        /// SDDLEJ.
        /// </summary>
        public const string SDDLEJ = "SDDLEJ";

        /// <summary>
        /// SDMMEJ.
        /// </summary>
        public const string SDMMEJ = "SDMMEJ";

        /// <summary>
        /// SD34XSDQ.
        /// </summary>
        public const string SD34XSDQ = "SD34XSDQ";

        /// <summary>
        /// SD34XSDQU.
        /// </summary>
        public const string SD34XSDQU = "SD34XSDQU";

        /// <summary>
        /// SDUOPN.
        /// </summary>
        public const string SDUOPN = "SDUOPN";

        /// <summary>
        /// SDUORG.
        /// </summary>
        public const string SDUORG = "SDUORG";

        /// <summary>
        /// SDUCHG.
        /// </summary>
        public const string SDUCHG = "SDUCHG";

        /// <summary>
        /// SDSOCN.
        /// </summary>
        public const string SDSOCN = "SDSOCN";

        /// <summary>
        /// SDQTYT.
        /// </summary>
        public const string SDQTYT = "SDQTYT";

        /// <summary>
        /// SDSOQS.
        /// </summary>
        public const string SDSOQS = "SDSOQS";

        /// <summary>
        /// SDQTYO.
        /// </summary>
        public const string SDQTYO = "SDQTYO";

        /// <summary>
        /// SDTRQT.
        /// </summary>
        public const string SDTRQT = "SDTRQT";

        /// <summary>
        /// SDQNTA.
        /// </summary>
        public const string SDQNTA = "SDQNTA";

        /// <summary>
        /// SDFQT.
        /// </summary>
        public const string SDFQT = "SDFQT";

        /// <summary>
        /// SDAN8.
        /// </summary>
        public const string SDAN8 = "SDAN8";

        /// <summary>
        /// SD34XVENDU.
        /// </summary>
        public const string SD34XVENDU = "SD34XVENDU";

        /// <summary>
        /// SDSRST.
        /// </summary>
        public const string SDSRST = "SDSRST";

        /// <summary>
        /// SDUNCD.
        /// </summary>
        public const string SDUNCD = "SDUNCD";

        /// <summary>
        /// SDDL01.
        /// </summary>
        public const string SDDL01 = "SDDL01";

        /// <summary>
        /// SDRORN.
        /// </summary>
        public const string SDRORN = "SDRORN";

        /// <summary>
        /// SDRCTO.
        /// </summary>
        public const string SDRCTO = "SDRCTO";

        /// <summary>
        /// SDRKCO.
        /// </summary>
        public const string SDRKCO = "SDRKCO";

        /// <summary>
        /// SDRLLN.
        /// </summary>
        public const string SDRLLN = "SDRLLN";

        /// <summary>
        /// SDPRJM.
        /// </summary>
        public const string SDPRJM = "SDPRJM";

        /// <summary>
        /// SD34XPRJMU.
        /// </summary>
        public const string SD34XPRJMU = "SD34XPRJMU";

        /// <summary>
        /// SDPNS.
        /// </summary>
        public const string SDPNS = "SDPNS";

        /// <summary>
        /// SDPMPN.
        /// </summary>
        public const string SDPMPN = "SDPMPN";

        /// <summary>
        /// SD34XPMPNU.
        /// </summary>
        public const string SD34XPMPNU = "SD34XPMPNU";

        /// <summary>
        /// SDROSID.
        /// </summary>
        public const string SDROSID = "SDROSID";

        /// <summary>
        /// SDROID.
        /// </summary>
        public const string SDROID = "SDROID";

        /// <summary>
        /// SDSY.
        /// </summary>
        public const string SDSY = "SDSY";

        /// <summary>
        /// SDOIND.
        /// </summary>
        public const string SDOIND = "SDOIND";

        /// <summary>
        /// SDWODTF.
        /// </summary>
        public const string SDWODTF = "SDWODTF";

        /// <summary>
        /// SDLOTP.
        /// </summary>
        public const string SDLOTP = "SDLOTP";

        /// <summary>
        /// SDTBM.
        /// </summary>
        public const string SDTBM = "SDTBM";

        /// <summary>
        /// SDRTG.
        /// </summary>
        public const string SDRTG = "SDRTG";

        /// <summary>
        /// SDSHPP.
        /// </summary>
        public const string SDSHPP = "SDSHPP";

        /// <summary>
        /// SDPARS.
        /// </summary>
        public const string SDPARS = "SDPARS";

        /// <summary>
        /// SDACTO.
        /// </summary>
        public const string SDACTO = "SDACTO";

        /// <summary>
        /// SDYR.
        /// </summary>
        public const string SDYR = "SDYR";

        /// <summary>
        /// SDMWDH.
        /// </summary>
        public const string SDMWDH = "SDMWDH";

        /// <summary>
        /// SDSHAN.
        /// </summary>
        public const string SDSHAN = "SDSHAN";

        /// <summary>
        /// SDSO11.
        /// </summary>
        public const string SDSO11 = "SDSO11";

        /// <summary>
        /// SD34XUKID2.
        /// </summary>
        public const string SD34XUKID2 = "SD34XUKID2";

        /// <summary>
        /// SD34XUKID3.
        /// </summary>
        public const string SD34XUKID3 = "SD34XUKID3";

        /// <summary>
        /// SDKIT.
        /// </summary>
        public const string SDKIT = "SDKIT";

        /// <summary>
        /// SDSRDM.
        /// </summary>
        public const string SDSRDM = "SDSRDM";

        /// <summary>
        /// SDLOVD.
        /// </summary>
        public const string SDLOVD = "SDLOVD";

        /// <summary>
        /// SDPLNK.
        /// </summary>
        public const string SDPLNK = "SDPLNK";

        /// <summary>
        /// SDPQOH.
        /// </summary>
        public const string SDPQOH = "SDPQOH";

        /// <summary>
        /// SDQTTR.
        /// </summary>
        public const string SDQTTR = "SDQTTR";

        /// <summary>
        /// SDQTIN.
        /// </summary>
        public const string SDQTIN = "SDQTIN";

        /// <summary>
        /// SDQTO1.
        /// </summary>
        public const string SDQTO1 = "SDQTO1";

        /// <summary>
        /// SDQTO2.
        /// </summary>
        public const string SDQTO2 = "SDQTO2";

        /// <summary>
        /// SD34XEXLQ.
        /// </summary>
        public const string SD34XEXLQ = "SD34XEXLQ";

        /// <summary>
        /// SD34XHLQ.
        /// </summary>
        public const string SD34XHLQ = "SD34XHLQ";

        /// <summary>
        /// SD34XPDSQ.
        /// </summary>
        public const string SD34XPDSQ = "SD34XPDSQ";

        /// <summary>
        /// SDMMCU.
        /// </summary>
        public const string SDMMCU = "SDMMCU";

        /// <summary>
        /// SDLOTG.
        /// </summary>
        public const string SDLOTG = "SDLOTG";

        /// <summary>
        /// SD34XSDQP.
        /// </summary>
        public const string SD34XSDQP = "SD34XSDQP";

        /// <summary>
        /// SD34XSDQPU.
        /// </summary>
        public const string SD34XSDQPU = "SD34XSDQPU";

        /// <summary>
        /// SD34XQCF.
        /// </summary>
        public const string SD34XQCF = "SD34XQCF";

        /// <summary>
        /// SD34XDCF.
        /// </summary>
        public const string SD34XDCF = "SD34XDCF";

        /// <summary>
        /// SD34XDSPF.
        /// </summary>
        public const string SD34XDSPF = "SD34XDSPF";

        /// <summary>
        /// SD34XEXCF.
        /// </summary>
        public const string SD34XEXCF = "SD34XEXCF";

        /// <summary>
        /// SDNXTR.
        /// </summary>
        public const string SDNXTR = "SDNXTR";

        /// <summary>
        /// SDLTTR.
        /// </summary>
        public const string SDLTTR = "SDLTTR";

        /// <summary>
        /// SD34XIMPL.
        /// </summary>
        public const string SD34XIMPL = "SD34XIMPL";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SD34XLATN.
        /// </summary>
        public const string SD34XLATN = "SD34XLATN";

        /// <summary>
        /// SD34XAA.
        /// </summary>
        public const string SD34XAA = "SD34XAA";

        /// <summary>
        /// SD34XUA.
        /// </summary>
        public const string SD34XUA = "SD34XUA";
    }

    /// <inheritdoc />
    public override string TableName => "F34X200W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20, true, true),
        new JdeField("SDJOBS", "SDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SDITM", "SDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SDMCU", "SDMCU", JdeDataType.String, 24, true, true),
        new JdeField("SD34XSDDJ", "SD34XSDDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SD34XSDDJU", "SD34XSDDJU", JdeDataType.Numeric),
        new JdeField("SD34XSDC", "SD34XSDC", JdeDataType.String, 2),
        new JdeField("SD34XSDDS", "SD34XSDDS", JdeDataType.String, 2),
        new JdeField("SD34XSDC1", "SD34XSDC1", JdeDataType.String, 6, true, true),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDSFXO", "SDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SD34XSDC2", "SD34XSDC2", JdeDataType.String, 80, true, true),
        new JdeField("SD34XUKID1", "SD34XUKID1", JdeDataType.Numeric, null, true, true),
        new JdeField("SD34XUKID4", "SD34XUKID4", JdeDataType.Numeric, null, true, true),
        new JdeField("SDUOM", "SDUOM", JdeDataType.String, 4, true, true),
        new JdeField("SDLOCN", "SDLOCN", JdeDataType.String, 40),
        new JdeField("SDLOTN", "SDLOTN", JdeDataType.String, 60),
        new JdeField("SDSTRT", "SDSTRT", JdeDataType.Numeric),
        new JdeField("SD34XSTRJU", "SD34XSTRJU", JdeDataType.Numeric),
        new JdeField("SDDRQJ", "SDDRQJ", JdeDataType.Numeric),
        new JdeField("SD34XDRQJU", "SD34XDRQJU", JdeDataType.Numeric),
        new JdeField("SDTRDJ", "SDTRDJ", JdeDataType.Numeric),
        new JdeField("SDPDDJ", "SDPDDJ", JdeDataType.Numeric),
        new JdeField("SDDLEJ", "SDDLEJ", JdeDataType.Numeric),
        new JdeField("SDMMEJ", "SDMMEJ", JdeDataType.Numeric),
        new JdeField("SD34XSDQ", "SD34XSDQ", JdeDataType.Numeric),
        new JdeField("SD34XSDQU", "SD34XSDQU", JdeDataType.Numeric),
        new JdeField("SDUOPN", "SDUOPN", JdeDataType.Numeric),
        new JdeField("SDUORG", "SDUORG", JdeDataType.Numeric),
        new JdeField("SDUCHG", "SDUCHG", JdeDataType.Numeric),
        new JdeField("SDSOCN", "SDSOCN", JdeDataType.Numeric),
        new JdeField("SDQTYT", "SDQTYT", JdeDataType.Numeric),
        new JdeField("SDSOQS", "SDSOQS", JdeDataType.Numeric),
        new JdeField("SDQTYO", "SDQTYO", JdeDataType.Numeric),
        new JdeField("SDTRQT", "SDTRQT", JdeDataType.Numeric),
        new JdeField("SDQNTA", "SDQNTA", JdeDataType.Numeric),
        new JdeField("SDFQT", "SDFQT", JdeDataType.Numeric),
        new JdeField("SDAN8", "SDAN8", JdeDataType.Numeric),
        new JdeField("SD34XVENDU", "SD34XVENDU", JdeDataType.Numeric),
        new JdeField("SDSRST", "SDSRST", JdeDataType.String, 4),
        new JdeField("SDUNCD", "SDUNCD", JdeDataType.String, 2),
        new JdeField("SDDL01", "SDDL01", JdeDataType.String, 60),
        new JdeField("SDRORN", "SDRORN", JdeDataType.String, 16),
        new JdeField("SDRCTO", "SDRCTO", JdeDataType.String, 4),
        new JdeField("SDRKCO", "SDRKCO", JdeDataType.String, 10),
        new JdeField("SDRLLN", "SDRLLN", JdeDataType.Numeric),
        new JdeField("SDPRJM", "SDPRJM", JdeDataType.Numeric),
        new JdeField("SD34XPRJMU", "SD34XPRJMU", JdeDataType.Numeric),
        new JdeField("SDPNS", "SDPNS", JdeDataType.Numeric),
        new JdeField("SDPMPN", "SDPMPN", JdeDataType.String, 60),
        new JdeField("SD34XPMPNU", "SD34XPMPNU", JdeDataType.String, 60),
        new JdeField("SDROSID", "SDROSID", JdeDataType.Numeric),
        new JdeField("SDROID", "SDROID", JdeDataType.Numeric),
        new JdeField("SDSY", "SDSY", JdeDataType.String, 8),
        new JdeField("SDOIND", "SDOIND", JdeDataType.Numeric),
        new JdeField("SDWODTF", "SDWODTF", JdeDataType.String, 2),
        new JdeField("SDLOTP", "SDLOTP", JdeDataType.Numeric),
        new JdeField("SDTBM", "SDTBM", JdeDataType.String, 6),
        new JdeField("SDRTG", "SDRTG", JdeDataType.String, 2),
        new JdeField("SDSHPP", "SDSHPP", JdeDataType.String, 2),
        new JdeField("SDPARS", "SDPARS", JdeDataType.String, 16),
        new JdeField("SDACTO", "SDACTO", JdeDataType.String, 2),
        new JdeField("SDYR", "SDYR", JdeDataType.Numeric),
        new JdeField("SDMWDH", "SDMWDH", JdeDataType.String, 2),
        new JdeField("SDSHAN", "SDSHAN", JdeDataType.Numeric),
        new JdeField("SDSO11", "SDSO11", JdeDataType.String, 2),
        new JdeField("SD34XUKID2", "SD34XUKID2", JdeDataType.Numeric),
        new JdeField("SD34XUKID3", "SD34XUKID3", JdeDataType.Numeric),
        new JdeField("SDKIT", "SDKIT", JdeDataType.Numeric),
        new JdeField("SDSRDM", "SDSRDM", JdeDataType.Numeric),
        new JdeField("SDLOVD", "SDLOVD", JdeDataType.Numeric),
        new JdeField("SDPLNK", "SDPLNK", JdeDataType.Numeric),
        new JdeField("SDPQOH", "SDPQOH", JdeDataType.Numeric),
        new JdeField("SDQTTR", "SDQTTR", JdeDataType.Numeric),
        new JdeField("SDQTIN", "SDQTIN", JdeDataType.Numeric),
        new JdeField("SDQTO1", "SDQTO1", JdeDataType.Numeric),
        new JdeField("SDQTO2", "SDQTO2", JdeDataType.Numeric),
        new JdeField("SD34XEXLQ", "SD34XEXLQ", JdeDataType.Numeric),
        new JdeField("SD34XHLQ", "SD34XHLQ", JdeDataType.Numeric),
        new JdeField("SD34XPDSQ", "SD34XPDSQ", JdeDataType.Numeric),
        new JdeField("SDMMCU", "SDMMCU", JdeDataType.String, 24),
        new JdeField("SDLOTG", "SDLOTG", JdeDataType.String, 6),
        new JdeField("SD34XSDQP", "SD34XSDQP", JdeDataType.Numeric),
        new JdeField("SD34XSDQPU", "SD34XSDQPU", JdeDataType.Numeric),
        new JdeField("SD34XQCF", "SD34XQCF", JdeDataType.String, 2),
        new JdeField("SD34XDCF", "SD34XDCF", JdeDataType.String, 2),
        new JdeField("SD34XDSPF", "SD34XDSPF", JdeDataType.String, 2),
        new JdeField("SD34XEXCF", "SD34XEXCF", JdeDataType.String, 2),
        new JdeField("SDNXTR", "SDNXTR", JdeDataType.String, 6),
        new JdeField("SDLTTR", "SDLTTR", JdeDataType.String, 6),
        new JdeField("SD34XIMPL", "SD34XIMPL", JdeDataType.String, 2),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SD34XLATN", "SD34XLATN", JdeDataType.Numeric),
        new JdeField("SD34XAA", "SD34XAA", JdeDataType.Numeric),
        new JdeField("SD34XUA", "SD34XUA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X200W_0", "Primary Key on SDUSER, SDJOBS, SDITM, SDMCU, SD34XSDDJ, SD34XSDC1, SDDOCO, SDDCTO, SDKCOO, SDSFXO, SDLNID, SD34XSDC2, SD34XUKID1, SD34XUKID4, SDUOM", new[] { "SDUSER", "SDJOBS", "SDITM", "SDMCU", "SD34XSDDJ", "SD34XSDC1", "SDDOCO", "SDDCTO", "SDKCOO", "SDSFXO", "SDLNID", "SD34XSDC2", "SD34XUKID1", "SD34XUKID4", "SDUOM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34X200W_2", "Index on SDUSER, SDJOBS, SDITM, SDMCU, SD34XSDDJU, SD34XSDC, SD34XSDC1, SDDOCO, SDDCTO, SDKCOO, SDSFXO, SDLNID, SD34XSDC2, SD34XUKID1, SD34XUKID4, SDUOM", new[] { "SDUSER", "SDJOBS", "SDITM", "SDMCU", "SD34XSDDJU", "SD34XSDC", "SD34XSDC1", "SDDOCO", "SDDCTO", "SDKCOO", "SDSFXO", "SDLNID", "SD34XSDC2", "SD34XUKID1", "SD34XUKID4", "SDUOM" }),
        new JdeIndex("F34X200W_3", "Index on SDUPMJ", new[] { "SDUPMJ" }),
        new JdeIndex("F34X200W_4", "Index on SDUSER, SDJOBS, SDUPMJ", new[] { "SDUSER", "SDJOBS", "SDUPMJ" }),
        new JdeIndex("F34X200W_5", "Index on SDUSER, SDJOBS, SDITM, SDMCU, SD34XSDDJ, SD34XSDC1, SD34XSDC2", new[] { "SDUSER", "SDJOBS", "SDITM", "SDMCU", "SD34XSDDJ", "SD34XSDC1", "SD34XSDC2" }),
        new JdeIndex("F34X200W_6", "Index on SDUSER, SDJOBS, SDITM, SDMCU, SD34XSDDJ, SYS_NC00099$", new[] { "SDUSER", "SDJOBS", "SDITM", "SDMCU", "SD34XSDDJ", "SYS_NC00099$" }),
        new JdeIndex("F34X200W_7", "Index on SDUSER, SDJOBS, SDMCU, SDITM, SDUOM", new[] { "SDUSER", "SDJOBS", "SDMCU", "SDITM", "SDUOM" })
    };
}
