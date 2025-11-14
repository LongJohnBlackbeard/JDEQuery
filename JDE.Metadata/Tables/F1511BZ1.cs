using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1511BZ1 - .
/// </summary>
public class F1511BZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MBEDUS.
        /// </summary>
        public const string MBEDUS = "MBEDUS";

        /// <summary>
        /// MBEDBT.
        /// </summary>
        public const string MBEDBT = "MBEDBT";

        /// <summary>
        /// MBEDTN.
        /// </summary>
        public const string MBEDTN = "MBEDTN";

        /// <summary>
        /// MBEDLN.
        /// </summary>
        public const string MBEDLN = "MBEDLN";

        /// <summary>
        /// MBEDCT.
        /// </summary>
        public const string MBEDCT = "MBEDCT";

        /// <summary>
        /// MBTYTN.
        /// </summary>
        public const string MBTYTN = "MBTYTN";

        /// <summary>
        /// MBEDFT.
        /// </summary>
        public const string MBEDFT = "MBEDFT";

        /// <summary>
        /// MBEDDT.
        /// </summary>
        public const string MBEDDT = "MBEDDT";

        /// <summary>
        /// MBDRIN.
        /// </summary>
        public const string MBDRIN = "MBDRIN";

        /// <summary>
        /// MBEDDL.
        /// </summary>
        public const string MBEDDL = "MBEDDL";

        /// <summary>
        /// MBEDSP.
        /// </summary>
        public const string MBEDSP = "MBEDSP";

        /// <summary>
        /// MBPNID.
        /// </summary>
        public const string MBPNID = "MBPNID";

        /// <summary>
        /// MBTNAC.
        /// </summary>
        public const string MBTNAC = "MBTNAC";

        /// <summary>
        /// MBUSER.
        /// </summary>
        public const string MBUSER = "MBUSER";

        /// <summary>
        /// MBPID.
        /// </summary>
        public const string MBPID = "MBPID";

        /// <summary>
        /// MBJOBN.
        /// </summary>
        public const string MBJOBN = "MBJOBN";

        /// <summary>
        /// MBUPMJ.
        /// </summary>
        public const string MBUPMJ = "MBUPMJ";

        /// <summary>
        /// MBTDAY.
        /// </summary>
        public const string MBTDAY = "MBTDAY";

        /// <summary>
        /// MBGENT.
        /// </summary>
        public const string MBGENT = "MBGENT";

        /// <summary>
        /// MBICU.
        /// </summary>
        public const string MBICU = "MBICU";

        /// <summary>
        /// MBDOC.
        /// </summary>
        public const string MBDOC = "MBDOC";

        /// <summary>
        /// MBSFX.
        /// </summary>
        public const string MBSFX = "MBSFX";

        /// <summary>
        /// MBDOCO.
        /// </summary>
        public const string MBDOCO = "MBDOCO";

        /// <summary>
        /// MBDCTO.
        /// </summary>
        public const string MBDCTO = "MBDCTO";

        /// <summary>
        /// MBSOSQ.
        /// </summary>
        public const string MBSOSQ = "MBSOSQ";

        /// <summary>
        /// MBMCUS.
        /// </summary>
        public const string MBMCUS = "MBMCUS";

        /// <summary>
        /// MBAN8.
        /// </summary>
        public const string MBAN8 = "MBAN8";

        /// <summary>
        /// MBAN8J.
        /// </summary>
        public const string MBAN8J = "MBAN8J";

        /// <summary>
        /// MBDL01.
        /// </summary>
        public const string MBDL01 = "MBDL01";

        /// <summary>
        /// MBMCU.
        /// </summary>
        public const string MBMCU = "MBMCU";

        /// <summary>
        /// MBOBJ.
        /// </summary>
        public const string MBOBJ = "MBOBJ";

        /// <summary>
        /// MBSUB.
        /// </summary>
        public const string MBSUB = "MBSUB";

        /// <summary>
        /// MBSBL.
        /// </summary>
        public const string MBSBL = "MBSBL";

        /// <summary>
        /// MBAID.
        /// </summary>
        public const string MBAID = "MBAID";

        /// <summary>
        /// MBCO.
        /// </summary>
        public const string MBCO = "MBCO";

        /// <summary>
        /// MBDG.
        /// </summary>
        public const string MBDG = "MBDG";

        /// <summary>
        /// MBDSV.
        /// </summary>
        public const string MBDSV = "MBDSV";

        /// <summary>
        /// MBGLC.
        /// </summary>
        public const string MBGLC = "MBGLC";

        /// <summary>
        /// MBBPN.
        /// </summary>
        public const string MBBPN = "MBBPN";

        /// <summary>
        /// MBYR.
        /// </summary>
        public const string MBYR = "MBYR";

        /// <summary>
        /// MBAG.
        /// </summary>
        public const string MBAG = "MBAG";

        /// <summary>
        /// MBAN01.
        /// </summary>
        public const string MBAN01 = "MBAN01";

        /// <summary>
        /// MBDI.
        /// </summary>
        public const string MBDI = "MBDI";

        /// <summary>
        /// MBDD.
        /// </summary>
        public const string MBDD = "MBDD";

        /// <summary>
        /// MBPTC.
        /// </summary>
        public const string MBPTC = "MBPTC";

        /// <summary>
        /// MBTRAN.
        /// </summary>
        public const string MBTRAN = "MBTRAN";

        /// <summary>
        /// MBSEPI.
        /// </summary>
        public const string MBSEPI = "MBSEPI";

        /// <summary>
        /// MBITMG.
        /// </summary>
        public const string MBITMG = "MBITMG";

        /// <summary>
        /// MBLNID.
        /// </summary>
        public const string MBLNID = "MBLNID";

        /// <summary>
        /// MBDIC.
        /// </summary>
        public const string MBDIC = "MBDIC";

        /// <summary>
        /// MBPDUE.
        /// </summary>
        public const string MBPDUE = "MBPDUE";

        /// <summary>
        /// MBEPCL.
        /// </summary>
        public const string MBEPCL = "MBEPCL";

        /// <summary>
        /// MBDPER.
        /// </summary>
        public const string MBDPER = "MBDPER";

        /// <summary>
        /// MBDPAR.
        /// </summary>
        public const string MBDPAR = "MBDPAR";

        /// <summary>
        /// MBEXCD.
        /// </summary>
        public const string MBEXCD = "MBEXCD";

        /// <summary>
        /// MBBCI.
        /// </summary>
        public const string MBBCI = "MBBCI";

        /// <summary>
        /// MBPRDC.
        /// </summary>
        public const string MBPRDC = "MBPRDC";

        /// <summary>
        /// MBYRO.
        /// </summary>
        public const string MBYRO = "MBYRO";

        /// <summary>
        /// MBCTRY.
        /// </summary>
        public const string MBCTRY = "MBCTRY";

        /// <summary>
        /// MBRPRD.
        /// </summary>
        public const string MBRPRD = "MBRPRD";

        /// <summary>
        /// MBCRCD.
        /// </summary>
        public const string MBCRCD = "MBCRCD";

        /// <summary>
        /// MBCRR.
        /// </summary>
        public const string MBCRR = "MBCRR";

        /// <summary>
        /// MBACR.
        /// </summary>
        public const string MBACR = "MBACR";

        /// <summary>
        /// MBTXA1.
        /// </summary>
        public const string MBTXA1 = "MBTXA1";

        /// <summary>
        /// MBEXR1.
        /// </summary>
        public const string MBEXR1 = "MBEXR1";

        /// <summary>
        /// MBSTAM.
        /// </summary>
        public const string MBSTAM = "MBSTAM";

        /// <summary>
        /// MBATXN.
        /// </summary>
        public const string MBATXN = "MBATXN";

        /// <summary>
        /// MBATXA.
        /// </summary>
        public const string MBATXA = "MBATXA";

        /// <summary>
        /// MBSBLT.
        /// </summary>
        public const string MBSBLT = "MBSBLT";

        /// <summary>
        /// MBCRRM.
        /// </summary>
        public const string MBCRRM = "MBCRRM";

        /// <summary>
        /// MBFAP.
        /// </summary>
        public const string MBFAP = "MBFAP";

        /// <summary>
        /// MBCDS.
        /// </summary>
        public const string MBCDS = "MBCDS";

        /// <summary>
        /// MBCDSA.
        /// </summary>
        public const string MBCDSA = "MBCDSA";

        /// <summary>
        /// MBCTAM.
        /// </summary>
        public const string MBCTAM = "MBCTAM";

        /// <summary>
        /// MBCTXA.
        /// </summary>
        public const string MBCTXA = "MBCTXA";

        /// <summary>
        /// MBCTXN.
        /// </summary>
        public const string MBCTXN = "MBCTXN";

        /// <summary>
        /// MBMI.
        /// </summary>
        public const string MBMI = "MBMI";

        /// <summary>
        /// MBDBAN.
        /// </summary>
        public const string MBDBAN = "MBDBAN";

        /// <summary>
        /// MBUNIT.
        /// </summary>
        public const string MBUNIT = "MBUNIT";

        /// <summary>
        /// MBBLMR.
        /// </summary>
        public const string MBBLMR = "MBBLMR";

        /// <summary>
        /// MBEFFC.
        /// </summary>
        public const string MBEFFC = "MBEFFC";

        /// <summary>
        /// MBSOBT.
        /// </summary>
        public const string MBSOBT = "MBSOBT";

        /// <summary>
        /// MBSBJR.
        /// </summary>
        public const string MBSBJR = "MBSBJR";

        /// <summary>
        /// MBICB1.
        /// </summary>
        public const string MBICB1 = "MBICB1";

        /// <summary>
        /// MBICB2.
        /// </summary>
        public const string MBICB2 = "MBICB2";

        /// <summary>
        /// MBICB3.
        /// </summary>
        public const string MBICB3 = "MBICB3";

        /// <summary>
        /// MBICB4.
        /// </summary>
        public const string MBICB4 = "MBICB4";

        /// <summary>
        /// MBICB5.
        /// </summary>
        public const string MBICB5 = "MBICB5";

        /// <summary>
        /// MBINVP.
        /// </summary>
        public const string MBINVP = "MBINVP";

        /// <summary>
        /// MBPRRB.
        /// </summary>
        public const string MBPRRB = "MBPRRB";

        /// <summary>
        /// MBBCIR.
        /// </summary>
        public const string MBBCIR = "MBBCIR";

        /// <summary>
        /// MBICBC.
        /// </summary>
        public const string MBICBC = "MBICBC";

        /// <summary>
        /// MBPOST.
        /// </summary>
        public const string MBPOST = "MBPOST";

        /// <summary>
        /// MBSOTY.
        /// </summary>
        public const string MBSOTY = "MBSOTY";

        /// <summary>
        /// MBADSC.
        /// </summary>
        public const string MBADSC = "MBADSC";

        /// <summary>
        /// MBODOC.
        /// </summary>
        public const string MBODOC = "MBODOC";

        /// <summary>
        /// MBODCT.
        /// </summary>
        public const string MBODCT = "MBODCT";

        /// <summary>
        /// MBOSFX.
        /// </summary>
        public const string MBOSFX = "MBOSFX";

        /// <summary>
        /// MBKCO.
        /// </summary>
        public const string MBKCO = "MBKCO";

        /// <summary>
        /// MBOKCO.
        /// </summary>
        public const string MBOKCO = "MBOKCO";

        /// <summary>
        /// MBLSVR.
        /// </summary>
        public const string MBLSVR = "MBLSVR";

        /// <summary>
        /// MBBCI3.
        /// </summary>
        public const string MBBCI3 = "MBBCI3";

        /// <summary>
        /// MBVINV.
        /// </summary>
        public const string MBVINV = "MBVINV";

        /// <summary>
        /// MBURCD.
        /// </summary>
        public const string MBURCD = "MBURCD";

        /// <summary>
        /// MBURDT.
        /// </summary>
        public const string MBURDT = "MBURDT";

        /// <summary>
        /// MBURAT.
        /// </summary>
        public const string MBURAT = "MBURAT";

        /// <summary>
        /// MBURAB.
        /// </summary>
        public const string MBURAB = "MBURAB";

        /// <summary>
        /// MBURRF.
        /// </summary>
        public const string MBURRF = "MBURRF";

        /// <summary>
        /// MBLEROUA.
        /// </summary>
        public const string MBLEROUA = "MBLEROUA";

        /// <summary>
        /// MBOLSE.
        /// </summary>
        public const string MBOLSE = "MBOLSE";

        /// <summary>
        /// MBLZNPA.
        /// </summary>
        public const string MBLZNPA = "MBLZNPA";

        /// <summary>
        /// MBNUMB.
        /// </summary>
        public const string MBNUMB = "MBNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F1511BZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MBEDUS", "MBEDUS", JdeDataType.String, 20, true, true),
        new JdeField("MBEDBT", "MBEDBT", JdeDataType.String, 30, true, true),
        new JdeField("MBEDTN", "MBEDTN", JdeDataType.String, 44, true, true),
        new JdeField("MBEDLN", "MBEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("MBEDCT", "MBEDCT", JdeDataType.String, 4),
        new JdeField("MBTYTN", "MBTYTN", JdeDataType.String, 16),
        new JdeField("MBEDFT", "MBEDFT", JdeDataType.String, 20),
        new JdeField("MBEDDT", "MBEDDT", JdeDataType.Numeric),
        new JdeField("MBDRIN", "MBDRIN", JdeDataType.String, 2),
        new JdeField("MBEDDL", "MBEDDL", JdeDataType.Numeric),
        new JdeField("MBEDSP", "MBEDSP", JdeDataType.String, 2),
        new JdeField("MBPNID", "MBPNID", JdeDataType.String, 30),
        new JdeField("MBTNAC", "MBTNAC", JdeDataType.String, 4),
        new JdeField("MBUSER", "MBUSER", JdeDataType.String, 20),
        new JdeField("MBPID", "MBPID", JdeDataType.String, 20),
        new JdeField("MBJOBN", "MBJOBN", JdeDataType.String, 20),
        new JdeField("MBUPMJ", "MBUPMJ", JdeDataType.Numeric),
        new JdeField("MBTDAY", "MBTDAY", JdeDataType.Numeric),
        new JdeField("MBGENT", "MBGENT", JdeDataType.String, 2),
        new JdeField("MBICU", "MBICU", JdeDataType.Numeric),
        new JdeField("MBDOC", "MBDOC", JdeDataType.Numeric),
        new JdeField("MBSFX", "MBSFX", JdeDataType.String, 6),
        new JdeField("MBDOCO", "MBDOCO", JdeDataType.Numeric),
        new JdeField("MBDCTO", "MBDCTO", JdeDataType.String, 4),
        new JdeField("MBSOSQ", "MBSOSQ", JdeDataType.Numeric),
        new JdeField("MBMCUS", "MBMCUS", JdeDataType.String, 24),
        new JdeField("MBAN8", "MBAN8", JdeDataType.Numeric),
        new JdeField("MBAN8J", "MBAN8J", JdeDataType.Numeric),
        new JdeField("MBDL01", "MBDL01", JdeDataType.String, 60),
        new JdeField("MBMCU", "MBMCU", JdeDataType.String, 24),
        new JdeField("MBOBJ", "MBOBJ", JdeDataType.String, 12),
        new JdeField("MBSUB", "MBSUB", JdeDataType.String, 16),
        new JdeField("MBSBL", "MBSBL", JdeDataType.String, 16),
        new JdeField("MBAID", "MBAID", JdeDataType.String, 16),
        new JdeField("MBCO", "MBCO", JdeDataType.String, 10),
        new JdeField("MBDG", "MBDG", JdeDataType.Numeric),
        new JdeField("MBDSV", "MBDSV", JdeDataType.Numeric),
        new JdeField("MBGLC", "MBGLC", JdeDataType.String, 8),
        new JdeField("MBBPN", "MBBPN", JdeDataType.Numeric),
        new JdeField("MBYR", "MBYR", JdeDataType.Numeric),
        new JdeField("MBAG", "MBAG", JdeDataType.Numeric),
        new JdeField("MBAN01", "MBAN01", JdeDataType.Numeric),
        new JdeField("MBDI", "MBDI", JdeDataType.Numeric),
        new JdeField("MBDD", "MBDD", JdeDataType.Numeric),
        new JdeField("MBPTC", "MBPTC", JdeDataType.String, 6),
        new JdeField("MBTRAN", "MBTRAN", JdeDataType.String, 2),
        new JdeField("MBSEPI", "MBSEPI", JdeDataType.String, 2),
        new JdeField("MBITMG", "MBITMG", JdeDataType.String, 6),
        new JdeField("MBLNID", "MBLNID", JdeDataType.Numeric),
        new JdeField("MBDIC", "MBDIC", JdeDataType.Numeric),
        new JdeField("MBPDUE", "MBPDUE", JdeDataType.Numeric),
        new JdeField("MBEPCL", "MBEPCL", JdeDataType.String, 8),
        new JdeField("MBDPER", "MBDPER", JdeDataType.Numeric),
        new JdeField("MBDPAR", "MBDPAR", JdeDataType.Numeric),
        new JdeField("MBEXCD", "MBEXCD", JdeDataType.String, 2),
        new JdeField("MBBCI", "MBBCI", JdeDataType.Numeric),
        new JdeField("MBPRDC", "MBPRDC", JdeDataType.String, 8),
        new JdeField("MBYRO", "MBYRO", JdeDataType.Numeric),
        new JdeField("MBCTRY", "MBCTRY", JdeDataType.Numeric),
        new JdeField("MBRPRD", "MBRPRD", JdeDataType.Numeric),
        new JdeField("MBCRCD", "MBCRCD", JdeDataType.String, 6),
        new JdeField("MBCRR", "MBCRR", JdeDataType.Numeric),
        new JdeField("MBACR", "MBACR", JdeDataType.Numeric),
        new JdeField("MBTXA1", "MBTXA1", JdeDataType.String, 20),
        new JdeField("MBEXR1", "MBEXR1", JdeDataType.String, 4),
        new JdeField("MBSTAM", "MBSTAM", JdeDataType.Numeric),
        new JdeField("MBATXN", "MBATXN", JdeDataType.Numeric),
        new JdeField("MBATXA", "MBATXA", JdeDataType.Numeric),
        new JdeField("MBSBLT", "MBSBLT", JdeDataType.String, 2),
        new JdeField("MBCRRM", "MBCRRM", JdeDataType.String, 2),
        new JdeField("MBFAP", "MBFAP", JdeDataType.Numeric),
        new JdeField("MBCDS", "MBCDS", JdeDataType.Numeric),
        new JdeField("MBCDSA", "MBCDSA", JdeDataType.Numeric),
        new JdeField("MBCTAM", "MBCTAM", JdeDataType.Numeric),
        new JdeField("MBCTXA", "MBCTXA", JdeDataType.Numeric),
        new JdeField("MBCTXN", "MBCTXN", JdeDataType.Numeric),
        new JdeField("MBMI", "MBMI", JdeDataType.String, 2),
        new JdeField("MBDBAN", "MBDBAN", JdeDataType.Numeric),
        new JdeField("MBUNIT", "MBUNIT", JdeDataType.String, 16),
        new JdeField("MBBLMR", "MBBLMR", JdeDataType.String, 2),
        new JdeField("MBEFFC", "MBEFFC", JdeDataType.String, 2),
        new JdeField("MBSOBT", "MBSOBT", JdeDataType.String, 4),
        new JdeField("MBSBJR", "MBSBJR", JdeDataType.String, 2),
        new JdeField("MBICB1", "MBICB1", JdeDataType.String, 24),
        new JdeField("MBICB2", "MBICB2", JdeDataType.String, 24),
        new JdeField("MBICB3", "MBICB3", JdeDataType.String, 24),
        new JdeField("MBICB4", "MBICB4", JdeDataType.String, 24),
        new JdeField("MBICB5", "MBICB5", JdeDataType.String, 24),
        new JdeField("MBINVP", "MBINVP", JdeDataType.String, 2),
        new JdeField("MBPRRB", "MBPRRB", JdeDataType.String, 2),
        new JdeField("MBBCIR", "MBBCIR", JdeDataType.Numeric),
        new JdeField("MBICBC", "MBICBC", JdeDataType.String, 4),
        new JdeField("MBPOST", "MBPOST", JdeDataType.String, 2),
        new JdeField("MBSOTY", "MBSOTY", JdeDataType.String, 4),
        new JdeField("MBADSC", "MBADSC", JdeDataType.Numeric),
        new JdeField("MBODOC", "MBODOC", JdeDataType.Numeric),
        new JdeField("MBODCT", "MBODCT", JdeDataType.String, 4),
        new JdeField("MBOSFX", "MBOSFX", JdeDataType.String, 6),
        new JdeField("MBKCO", "MBKCO", JdeDataType.String, 10),
        new JdeField("MBOKCO", "MBOKCO", JdeDataType.String, 10),
        new JdeField("MBLSVR", "MBLSVR", JdeDataType.Numeric),
        new JdeField("MBBCI3", "MBBCI3", JdeDataType.Numeric),
        new JdeField("MBVINV", "MBVINV", JdeDataType.String, 50),
        new JdeField("MBURCD", "MBURCD", JdeDataType.String, 4),
        new JdeField("MBURDT", "MBURDT", JdeDataType.Numeric),
        new JdeField("MBURAT", "MBURAT", JdeDataType.Numeric),
        new JdeField("MBURAB", "MBURAB", JdeDataType.Numeric),
        new JdeField("MBURRF", "MBURRF", JdeDataType.String, 30),
        new JdeField("MBLEROUA", "MBLEROUA", JdeDataType.String, 2),
        new JdeField("MBOLSE", "MBOLSE", JdeDataType.String, 50),
        new JdeField("MBLZNPA", "MBLZNPA", JdeDataType.String, 2),
        new JdeField("MBNUMB", "MBNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1511BZ1_0", "Primary Key on MBEDUS, MBEDBT, MBEDTN, MBEDLN", new[] { "MBEDUS", "MBEDBT", "MBEDTN", "MBEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
