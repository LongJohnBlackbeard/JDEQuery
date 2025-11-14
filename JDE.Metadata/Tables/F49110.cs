using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49110 - .
/// </summary>
public class F49110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWBN01.
        /// </summary>
        public const string BWBN01 = "BWBN01";

        /// <summary>
        /// BWMCUZ.
        /// </summary>
        public const string BWMCUZ = "BWMCUZ";

        /// <summary>
        /// BWDCCD.
        /// </summary>
        public const string BWDCCD = "BWDCCD";

        /// <summary>
        /// BWSHPN.
        /// </summary>
        public const string BWSHPN = "BWSHPN";

        /// <summary>
        /// BWRSSN.
        /// </summary>
        public const string BWRSSN = "BWRSSN";

        /// <summary>
        /// BWCTID.
        /// </summary>
        public const string BWCTID = "BWCTID";

        /// <summary>
        /// BWJOBS.
        /// </summary>
        public const string BWJOBS = "BWJOBS";

        /// <summary>
        /// BWSEQN.
        /// </summary>
        public const string BWSEQN = "BWSEQN";

        /// <summary>
        /// BWSDPC.
        /// </summary>
        public const string BWSDPC = "BWSDPC";

        /// <summary>
        /// BWORGN.
        /// </summary>
        public const string BWORGN = "BWORGN";

        /// <summary>
        /// BWANCC.
        /// </summary>
        public const string BWANCC = "BWANCC";

        /// <summary>
        /// BWRAN8.
        /// </summary>
        public const string BWRAN8 = "BWRAN8";

        /// <summary>
        /// BWAN8.
        /// </summary>
        public const string BWAN8 = "BWAN8";

        /// <summary>
        /// BWSHAN.
        /// </summary>
        public const string BWSHAN = "BWSHAN";

        /// <summary>
        /// BWMOT.
        /// </summary>
        public const string BWMOT = "BWMOT";

        /// <summary>
        /// BWCARS.
        /// </summary>
        public const string BWCARS = "BWCARS";

        /// <summary>
        /// BWFRTH.
        /// </summary>
        public const string BWFRTH = "BWFRTH";

        /// <summary>
        /// BWRSDJ.
        /// </summary>
        public const string BWRSDJ = "BWRSDJ";

        /// <summary>
        /// BWRSDT.
        /// </summary>
        public const string BWRSDT = "BWRSDT";

        /// <summary>
        /// BWNPCS.
        /// </summary>
        public const string BWNPCS = "BWNPCS";

        /// <summary>
        /// BWNCTR.
        /// </summary>
        public const string BWNCTR = "BWNCTR";

        /// <summary>
        /// BWWGTS.
        /// </summary>
        public const string BWWGTS = "BWWGTS";

        /// <summary>
        /// BWWTUM.
        /// </summary>
        public const string BWWTUM = "BWWTUM";

        /// <summary>
        /// BWDRCF.
        /// </summary>
        public const string BWDRCF = "BWDRCF";

        /// <summary>
        /// BWDOC.
        /// </summary>
        public const string BWDOC = "BWDOC";

        /// <summary>
        /// BWDCT.
        /// </summary>
        public const string BWDCT = "BWDCT";

        /// <summary>
        /// BWKCO.
        /// </summary>
        public const string BWKCO = "BWKCO";

        /// <summary>
        /// BWDCNS.
        /// </summary>
        public const string BWDCNS = "BWDCNS";

        /// <summary>
        /// BWCO.
        /// </summary>
        public const string BWCO = "BWCO";

        /// <summary>
        /// BWEMCU.
        /// </summary>
        public const string BWEMCU = "BWEMCU";

        /// <summary>
        /// BWMCU.
        /// </summary>
        public const string BWMCU = "BWMCU";

        /// <summary>
        /// BWDTDO.
        /// </summary>
        public const string BWDTDO = "BWDTDO";

        /// <summary>
        /// BWREFQ.
        /// </summary>
        public const string BWREFQ = "BWREFQ";

        /// <summary>
        /// BWREFN.
        /// </summary>
        public const string BWREFN = "BWREFN";

        /// <summary>
        /// BWDOCO.
        /// </summary>
        public const string BWDOCO = "BWDOCO";

        /// <summary>
        /// BWDCTO.
        /// </summary>
        public const string BWDCTO = "BWDCTO";

        /// <summary>
        /// BWKCOO.
        /// </summary>
        public const string BWKCOO = "BWKCOO";

        /// <summary>
        /// BWLNID.
        /// </summary>
        public const string BWLNID = "BWLNID";

        /// <summary>
        /// BWITM.
        /// </summary>
        public const string BWITM = "BWITM";

        /// <summary>
        /// BWSOQS.
        /// </summary>
        public const string BWSOQS = "BWSOQS";

        /// <summary>
        /// BWUOM.
        /// </summary>
        public const string BWUOM = "BWUOM";

        /// <summary>
        /// BWNMFC.
        /// </summary>
        public const string BWNMFC = "BWNMFC";

        /// <summary>
        /// BWITWT.
        /// </summary>
        public const string BWITWT = "BWITWT";

        /// <summary>
        /// BWWGTU.
        /// </summary>
        public const string BWWGTU = "BWWGTU";

        /// <summary>
        /// BWTEMP.
        /// </summary>
        public const string BWTEMP = "BWTEMP";

        /// <summary>
        /// BWSTPU.
        /// </summary>
        public const string BWSTPU = "BWSTPU";

        /// <summary>
        /// BWDNTY.
        /// </summary>
        public const string BWDNTY = "BWDNTY";

        /// <summary>
        /// BWDNTP.
        /// </summary>
        public const string BWDNTP = "BWDNTP";

        /// <summary>
        /// BWDETP.
        /// </summary>
        public const string BWDETP = "BWDETP";

        /// <summary>
        /// BWDTPU.
        /// </summary>
        public const string BWDTPU = "BWDTPU";

        /// <summary>
        /// BWVCF.
        /// </summary>
        public const string BWVCF = "BWVCF";

        /// <summary>
        /// BWPRAS.
        /// </summary>
        public const string BWPRAS = "BWPRAS";

        /// <summary>
        /// BWIQTY.
        /// </summary>
        public const string BWIQTY = "BWIQTY";

        /// <summary>
        /// BWSTUM.
        /// </summary>
        public const string BWSTUM = "BWSTUM";

        /// <summary>
        /// BWBUM6.
        /// </summary>
        public const string BWBUM6 = "BWBUM6";

        /// <summary>
        /// BWAMBR.
        /// </summary>
        public const string BWAMBR = "BWAMBR";

        /// <summary>
        /// BWVUOM.
        /// </summary>
        public const string BWVUOM = "BWVUOM";

        /// <summary>
        /// BWCNMR.
        /// </summary>
        public const string BWCNMR = "BWCNMR";

        /// <summary>
        /// BWLNMB.
        /// </summary>
        public const string BWLNMB = "BWLNMB";

        /// <summary>
        /// BWRTN.
        /// </summary>
        public const string BWRTN = "BWRTN";

        /// <summary>
        /// BWURCD.
        /// </summary>
        public const string BWURCD = "BWURCD";

        /// <summary>
        /// BWURDT.
        /// </summary>
        public const string BWURDT = "BWURDT";

        /// <summary>
        /// BWURAT.
        /// </summary>
        public const string BWURAT = "BWURAT";

        /// <summary>
        /// BWURAB.
        /// </summary>
        public const string BWURAB = "BWURAB";

        /// <summary>
        /// BWURRF.
        /// </summary>
        public const string BWURRF = "BWURRF";

        /// <summary>
        /// BWAETC.
        /// </summary>
        public const string BWAETC = "BWAETC";

        /// <summary>
        /// BWSLN.
        /// </summary>
        public const string BWSLN = "BWSLN";

        /// <summary>
        /// BWCIRV.
        /// </summary>
        public const string BWCIRV = "BWCIRV";

        /// <summary>
        /// BWYEAR1.
        /// </summary>
        public const string BWYEAR1 = "BWYEAR1";

        /// <summary>
        /// BWCSTPO.
        /// </summary>
        public const string BWCSTPO = "BWCSTPO";

        /// <summary>
        /// BWRLNU.
        /// </summary>
        public const string BWRLNU = "BWRLNU";

        /// <summary>
        /// BWPSIG.
        /// </summary>
        public const string BWPSIG = "BWPSIG";

        /// <summary>
        /// BWRORN.
        /// </summary>
        public const string BWRORN = "BWRORN";

        /// <summary>
        /// BWCUMS.
        /// </summary>
        public const string BWCUMS = "BWCUMS";

        /// <summary>
        /// BWETRSC.
        /// </summary>
        public const string BWETRSC = "BWETRSC";

        /// <summary>
        /// BWCITM.
        /// </summary>
        public const string BWCITM = "BWCITM";

        /// <summary>
        /// BWDKID.
        /// </summary>
        public const string BWDKID = "BWDKID";

        /// <summary>
        /// BWETRC.
        /// </summary>
        public const string BWETRC = "BWETRC";

        /// <summary>
        /// BWPSJOBNO.
        /// </summary>
        public const string BWPSJOBNO = "BWPSJOBNO";

        /// <summary>
        /// BWJOBSQ.
        /// </summary>
        public const string BWJOBSQ = "BWJOBSQ";

        /// <summary>
        /// BWDELBATCH.
        /// </summary>
        public const string BWDELBATCH = "BWDELBATCH";

        /// <summary>
        /// BWUKID.
        /// </summary>
        public const string BWUKID = "BWUKID";

        /// <summary>
        /// BWCUMID.
        /// </summary>
        public const string BWCUMID = "BWCUMID";

        /// <summary>
        /// BWGAN8.
        /// </summary>
        public const string BWGAN8 = "BWGAN8";

        /// <summary>
        /// BWGSHAN.
        /// </summary>
        public const string BWGSHAN = "BWGSHAN";

        /// <summary>
        /// BWGCARS.
        /// </summary>
        public const string BWGCARS = "BWGCARS";

        /// <summary>
        /// BWGAN8R.
        /// </summary>
        public const string BWGAN8R = "BWGAN8R";

        /// <summary>
        /// BWORIG.
        /// </summary>
        public const string BWORIG = "BWORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F49110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWBN01", "BWBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("BWMCUZ", "BWMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("BWDCCD", "BWDCCD", JdeDataType.String, 8, true, true),
        new JdeField("BWSHPN", "BWSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWRSSN", "BWRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWCTID", "BWCTID", JdeDataType.String, 30),
        new JdeField("BWJOBS", "BWJOBS", JdeDataType.Numeric),
        new JdeField("BWSEQN", "BWSEQN", JdeDataType.Numeric),
        new JdeField("BWSDPC", "BWSDPC", JdeDataType.String, 2),
        new JdeField("BWORGN", "BWORGN", JdeDataType.Numeric),
        new JdeField("BWANCC", "BWANCC", JdeDataType.Numeric),
        new JdeField("BWRAN8", "BWRAN8", JdeDataType.Numeric),
        new JdeField("BWAN8", "BWAN8", JdeDataType.Numeric),
        new JdeField("BWSHAN", "BWSHAN", JdeDataType.Numeric),
        new JdeField("BWMOT", "BWMOT", JdeDataType.String, 6),
        new JdeField("BWCARS", "BWCARS", JdeDataType.Numeric),
        new JdeField("BWFRTH", "BWFRTH", JdeDataType.String, 6),
        new JdeField("BWRSDJ", "BWRSDJ", JdeDataType.Numeric),
        new JdeField("BWRSDT", "BWRSDT", JdeDataType.Numeric),
        new JdeField("BWNPCS", "BWNPCS", JdeDataType.Numeric),
        new JdeField("BWNCTR", "BWNCTR", JdeDataType.Numeric),
        new JdeField("BWWGTS", "BWWGTS", JdeDataType.Numeric),
        new JdeField("BWWTUM", "BWWTUM", JdeDataType.String, 4),
        new JdeField("BWDRCF", "BWDRCF", JdeDataType.String, 2),
        new JdeField("BWDOC", "BWDOC", JdeDataType.Numeric),
        new JdeField("BWDCT", "BWDCT", JdeDataType.String, 4),
        new JdeField("BWKCO", "BWKCO", JdeDataType.String, 10),
        new JdeField("BWDCNS", "BWDCNS", JdeDataType.String, 2),
        new JdeField("BWCO", "BWCO", JdeDataType.String, 10),
        new JdeField("BWEMCU", "BWEMCU", JdeDataType.String, 24),
        new JdeField("BWMCU", "BWMCU", JdeDataType.String, 24),
        new JdeField("BWDTDO", "BWDTDO", JdeDataType.Numeric),
        new JdeField("BWREFQ", "BWREFQ", JdeDataType.String, 4),
        new JdeField("BWREFN", "BWREFN", JdeDataType.String, 60),
        new JdeField("BWDOCO", "BWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("BWDCTO", "BWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("BWKCOO", "BWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("BWLNID", "BWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BWITM", "BWITM", JdeDataType.Numeric),
        new JdeField("BWSOQS", "BWSOQS", JdeDataType.Numeric),
        new JdeField("BWUOM", "BWUOM", JdeDataType.String, 4),
        new JdeField("BWNMFC", "BWNMFC", JdeDataType.String, 8),
        new JdeField("BWITWT", "BWITWT", JdeDataType.Numeric),
        new JdeField("BWWGTU", "BWWGTU", JdeDataType.String, 4),
        new JdeField("BWTEMP", "BWTEMP", JdeDataType.Numeric),
        new JdeField("BWSTPU", "BWSTPU", JdeDataType.String, 2),
        new JdeField("BWDNTY", "BWDNTY", JdeDataType.Numeric),
        new JdeField("BWDNTP", "BWDNTP", JdeDataType.String, 2),
        new JdeField("BWDETP", "BWDETP", JdeDataType.Numeric),
        new JdeField("BWDTPU", "BWDTPU", JdeDataType.String, 2),
        new JdeField("BWVCF", "BWVCF", JdeDataType.Numeric),
        new JdeField("BWPRAS", "BWPRAS", JdeDataType.String, 2),
        new JdeField("BWIQTY", "BWIQTY", JdeDataType.Numeric),
        new JdeField("BWSTUM", "BWSTUM", JdeDataType.Numeric),
        new JdeField("BWBUM6", "BWBUM6", JdeDataType.String, 4),
        new JdeField("BWAMBR", "BWAMBR", JdeDataType.Numeric),
        new JdeField("BWVUOM", "BWVUOM", JdeDataType.String, 4),
        new JdeField("BWCNMR", "BWCNMR", JdeDataType.String, 48),
        new JdeField("BWLNMB", "BWLNMB", JdeDataType.Numeric),
        new JdeField("BWRTN", "BWRTN", JdeDataType.Numeric),
        new JdeField("BWURCD", "BWURCD", JdeDataType.String, 4),
        new JdeField("BWURDT", "BWURDT", JdeDataType.Numeric),
        new JdeField("BWURAT", "BWURAT", JdeDataType.Numeric),
        new JdeField("BWURAB", "BWURAB", JdeDataType.Numeric),
        new JdeField("BWURRF", "BWURRF", JdeDataType.String, 30),
        new JdeField("BWAETC", "BWAETC", JdeDataType.String, 20),
        new JdeField("BWSLN", "BWSLN", JdeDataType.Numeric),
        new JdeField("BWCIRV", "BWCIRV", JdeDataType.String, 40),
        new JdeField("BWYEAR1", "BWYEAR1", JdeDataType.Numeric),
        new JdeField("BWCSTPO", "BWCSTPO", JdeDataType.String, 60),
        new JdeField("BWRLNU", "BWRLNU", JdeDataType.String, 20),
        new JdeField("BWPSIG", "BWPSIG", JdeDataType.String, 60),
        new JdeField("BWRORN", "BWRORN", JdeDataType.String, 16),
        new JdeField("BWCUMS", "BWCUMS", JdeDataType.Numeric),
        new JdeField("BWETRSC", "BWETRSC", JdeDataType.String, 6),
        new JdeField("BWCITM", "BWCITM", JdeDataType.String, 50),
        new JdeField("BWDKID", "BWDKID", JdeDataType.String, 40),
        new JdeField("BWETRC", "BWETRC", JdeDataType.String, 6),
        new JdeField("BWPSJOBNO", "BWPSJOBNO", JdeDataType.String, 30),
        new JdeField("BWJOBSQ", "BWJOBSQ", JdeDataType.String, 30),
        new JdeField("BWDELBATCH", "BWDELBATCH", JdeDataType.String, 12),
        new JdeField("BWUKID", "BWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BWCUMID", "BWCUMID", JdeDataType.Numeric),
        new JdeField("BWGAN8", "BWGAN8", JdeDataType.Numeric),
        new JdeField("BWGSHAN", "BWGSHAN", JdeDataType.Numeric),
        new JdeField("BWGCARS", "BWGCARS", JdeDataType.Numeric),
        new JdeField("BWGAN8R", "BWGAN8R", JdeDataType.Numeric),
        new JdeField("BWORIG", "BWORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49110_0", "Primary Key on BWBN01, BWMCUZ, BWDCCD, BWSHPN, BWRSSN, BWDOCO, BWDCTO, BWKCOO, BWLNID, BWUKID", new[] { "BWBN01", "BWMCUZ", "BWDCCD", "BWSHPN", "BWRSSN", "BWDOCO", "BWDCTO", "BWKCOO", "BWLNID", "BWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49110_2", "Index on BWBN01, BWMCUZ, BWDCCD, BWSHPN, BWRSSN, BWITM, BWUOM", new[] { "BWBN01", "BWMCUZ", "BWDCCD", "BWSHPN", "BWRSSN", "BWITM", "BWUOM" }),
        new JdeIndex("F49110_3", "Index on BWBN01, BWMCUZ, BWDCCD, BWSHPN, BWRSSN, BWDOCO, BWDCTO, BWKCOO, SYS_NC00089$", new[] { "BWBN01", "BWMCUZ", "BWDCCD", "BWSHPN", "BWRSSN", "BWDOCO", "BWDCTO", "BWKCOO", "SYS_NC00089$" }),
        new JdeIndex("F49110_4", "Index on BWUKID", new[] { "BWUKID" })
    };
}
