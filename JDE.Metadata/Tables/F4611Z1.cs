using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4611Z1 - .
/// </summary>
public class F4611Z1 : JdeTable
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
        /// SZTYFL.
        /// </summary>
        public const string SZTYFL = "SZTYFL";

        /// <summary>
        /// SZOCDE.
        /// </summary>
        public const string SZOCDE = "SZOCDE";

        /// <summary>
        /// SZRQBT.
        /// </summary>
        public const string SZRQBT = "SZRQBT";

        /// <summary>
        /// SZRQSQ.
        /// </summary>
        public const string SZRQSQ = "SZRQSQ";

        /// <summary>
        /// SZSGBT.
        /// </summary>
        public const string SZSGBT = "SZSGBT";

        /// <summary>
        /// SZSGSQ.
        /// </summary>
        public const string SZSGSQ = "SZSGSQ";

        /// <summary>
        /// SZPWAV.
        /// </summary>
        public const string SZPWAV = "SZPWAV";

        /// <summary>
        /// SZPTSK.
        /// </summary>
        public const string SZPTSK = "SZPTSK";

        /// <summary>
        /// SZTRIP.
        /// </summary>
        public const string SZTRIP = "SZTRIP";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZNLIN.
        /// </summary>
        public const string SZNLIN = "SZNLIN";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZCLID.
        /// </summary>
        public const string SZCLID = "SZCLID";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZUML1.
        /// </summary>
        public const string SZUML1 = "SZUML1";

        /// <summary>
        /// SZTQL1.
        /// </summary>
        public const string SZTQL1 = "SZTQL1";

        /// <summary>
        /// SZEQL1.
        /// </summary>
        public const string SZEQL1 = "SZEQL1";

        /// <summary>
        /// SZUML2.
        /// </summary>
        public const string SZUML2 = "SZUML2";

        /// <summary>
        /// SZQPL2.
        /// </summary>
        public const string SZQPL2 = "SZQPL2";

        /// <summary>
        /// SZTQL2.
        /// </summary>
        public const string SZTQL2 = "SZTQL2";

        /// <summary>
        /// SZEQL2.
        /// </summary>
        public const string SZEQL2 = "SZEQL2";

        /// <summary>
        /// SZUML3.
        /// </summary>
        public const string SZUML3 = "SZUML3";

        /// <summary>
        /// SZQPL3.
        /// </summary>
        public const string SZQPL3 = "SZQPL3";

        /// <summary>
        /// SZTQL3.
        /// </summary>
        public const string SZTQL3 = "SZTQL3";

        /// <summary>
        /// SZEQL3.
        /// </summary>
        public const string SZEQL3 = "SZEQL3";

        /// <summary>
        /// SZUML4.
        /// </summary>
        public const string SZUML4 = "SZUML4";

        /// <summary>
        /// SZQPL4.
        /// </summary>
        public const string SZQPL4 = "SZQPL4";

        /// <summary>
        /// SZTQL4.
        /// </summary>
        public const string SZTQL4 = "SZTQL4";

        /// <summary>
        /// SZEQL4.
        /// </summary>
        public const string SZEQL4 = "SZEQL4";

        /// <summary>
        /// SZUML5.
        /// </summary>
        public const string SZUML5 = "SZUML5";

        /// <summary>
        /// SZQPL5.
        /// </summary>
        public const string SZQPL5 = "SZQPL5";

        /// <summary>
        /// SZTQL5.
        /// </summary>
        public const string SZTQL5 = "SZTQL5";

        /// <summary>
        /// SZEQL5.
        /// </summary>
        public const string SZEQL5 = "SZEQL5";

        /// <summary>
        /// SZUOM1.
        /// </summary>
        public const string SZUOM1 = "SZUOM1";

        /// <summary>
        /// SZTQTY.
        /// </summary>
        public const string SZTQTY = "SZTQTY";

        /// <summary>
        /// SZCUBE.
        /// </summary>
        public const string SZCUBE = "SZCUBE";

        /// <summary>
        /// SZVUMD.
        /// </summary>
        public const string SZVUMD = "SZVUMD";

        /// <summary>
        /// SZWEIT.
        /// </summary>
        public const string SZWEIT = "SZWEIT";

        /// <summary>
        /// SZUWUM.
        /// </summary>
        public const string SZUWUM = "SZUWUM";

        /// <summary>
        /// SZLDFS.
        /// </summary>
        public const string SZLDFS = "SZLDFS";

        /// <summary>
        /// SZFLOC.
        /// </summary>
        public const string SZFLOC = "SZFLOC";

        /// <summary>
        /// SZFLOT.
        /// </summary>
        public const string SZFLOT = "SZFLOT";

        /// <summary>
        /// SZSTNF.
        /// </summary>
        public const string SZSTNF = "SZSTNF";

        /// <summary>
        /// SZLDTS.
        /// </summary>
        public const string SZLDTS = "SZLDTS";

        /// <summary>
        /// SZTLOC.
        /// </summary>
        public const string SZTLOC = "SZTLOC";

        /// <summary>
        /// SZTLOT.
        /// </summary>
        public const string SZTLOT = "SZTLOT";

        /// <summary>
        /// SZSTNT.
        /// </summary>
        public const string SZSTNT = "SZSTNT";

        /// <summary>
        /// SZLOTP.
        /// </summary>
        public const string SZLOTP = "SZLOTP";

        /// <summary>
        /// SZLOTG.
        /// </summary>
        public const string SZLOTG = "SZLOTG";

        /// <summary>
        /// SZMERG.
        /// </summary>
        public const string SZMERG = "SZMERG";

        /// <summary>
        /// SZEQTY.
        /// </summary>
        public const string SZEQTY = "SZEQTY";

        /// <summary>
        /// SZCRMT.
        /// </summary>
        public const string SZCRMT = "SZCRMT";

        /// <summary>
        /// SZBACK.
        /// </summary>
        public const string SZBACK = "SZBACK";

        /// <summary>
        /// SZAPTS.
        /// </summary>
        public const string SZAPTS = "SZAPTS";

        /// <summary>
        /// SZCOMM.
        /// </summary>
        public const string SZCOMM = "SZCOMM";

        /// <summary>
        /// SZITCM.
        /// </summary>
        public const string SZITCM = "SZITCM";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZINMG.
        /// </summary>
        public const string SZINMG = "SZINMG";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZPALC.
        /// </summary>
        public const string SZPALC = "SZPALC";

        /// <summary>
        /// SZMORD.
        /// </summary>
        public const string SZMORD = "SZMORD";

        /// <summary>
        /// SZRLIT.
        /// </summary>
        public const string SZRLIT = "SZRLIT";

        /// <summary>
        /// SZKTLN.
        /// </summary>
        public const string SZKTLN = "SZKTLN";

        /// <summary>
        /// SZRKIT.
        /// </summary>
        public const string SZRKIT = "SZRKIT";

        /// <summary>
        /// SZKTP.
        /// </summary>
        public const string SZKTP = "SZKTP";

        /// <summary>
        /// SZKTBL.
        /// </summary>
        public const string SZKTBL = "SZKTBL";

        /// <summary>
        /// SZPTPH.
        /// </summary>
        public const string SZPTPH = "SZPTPH";

        /// <summary>
        /// SZZIP.
        /// </summary>
        public const string SZZIP = "SZZIP";

        /// <summary>
        /// SZSRP1.
        /// </summary>
        public const string SZSRP1 = "SZSRP1";

        /// <summary>
        /// SZSRP2.
        /// </summary>
        public const string SZSRP2 = "SZSRP2";

        /// <summary>
        /// SZSRP3.
        /// </summary>
        public const string SZSRP3 = "SZSRP3";

        /// <summary>
        /// SZSRP4.
        /// </summary>
        public const string SZSRP4 = "SZSRP4";

        /// <summary>
        /// SZSRP5.
        /// </summary>
        public const string SZSRP5 = "SZSRP5";

        /// <summary>
        /// SZPRP6.
        /// </summary>
        public const string SZPRP6 = "SZPRP6";

        /// <summary>
        /// SZPRP7.
        /// </summary>
        public const string SZPRP7 = "SZPRP7";

        /// <summary>
        /// SZPRP8.
        /// </summary>
        public const string SZPRP8 = "SZPRP8";

        /// <summary>
        /// SZPRP9.
        /// </summary>
        public const string SZPRP9 = "SZPRP9";

        /// <summary>
        /// SZMPUT.
        /// </summary>
        public const string SZMPUT = "SZMPUT";

        /// <summary>
        /// SZPUTP.
        /// </summary>
        public const string SZPUTP = "SZPUTP";

        /// <summary>
        /// SZSEQ.
        /// </summary>
        public const string SZSEQ = "SZSEQ";

        /// <summary>
        /// SZRCDJ.
        /// </summary>
        public const string SZRCDJ = "SZRCDJ";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZDRQJ.
        /// </summary>
        public const string SZDRQJ = "SZDRQJ";

        /// <summary>
        /// SZPDDJ.
        /// </summary>
        public const string SZPDDJ = "SZPDDJ";

        /// <summary>
        /// SZPACK.
        /// </summary>
        public const string SZPACK = "SZPACK";

        /// <summary>
        /// SZRPCK.
        /// </summary>
        public const string SZRPCK = "SZRPCK";

        /// <summary>
        /// SZEKEY.
        /// </summary>
        public const string SZEKEY = "SZEKEY";

        /// <summary>
        /// SZCODR.
        /// </summary>
        public const string SZCODR = "SZCODR";

        /// <summary>
        /// SZPSTB.
        /// </summary>
        public const string SZPSTB = "SZPSTB";

        /// <summary>
        /// SZRESX.
        /// </summary>
        public const string SZRESX = "SZRESX";

        /// <summary>
        /// SZPZON.
        /// </summary>
        public const string SZPZON = "SZPZON";

        /// <summary>
        /// SZKZON.
        /// </summary>
        public const string SZKZON = "SZKZON";

        /// <summary>
        /// SZZONR.
        /// </summary>
        public const string SZZONR = "SZZONR";

        /// <summary>
        /// SZAISL.
        /// </summary>
        public const string SZAISL = "SZAISL";

        /// <summary>
        /// SZBIN.
        /// </summary>
        public const string SZBIN = "SZBIN";

        /// <summary>
        /// SZLA03.
        /// </summary>
        public const string SZLA03 = "SZLA03";

        /// <summary>
        /// SZLA04.
        /// </summary>
        public const string SZLA04 = "SZLA04";

        /// <summary>
        /// SZLA05.
        /// </summary>
        public const string SZLA05 = "SZLA05";

        /// <summary>
        /// SZLA06.
        /// </summary>
        public const string SZLA06 = "SZLA06";

        /// <summary>
        /// SZLA07.
        /// </summary>
        public const string SZLA07 = "SZLA07";

        /// <summary>
        /// SZLA08.
        /// </summary>
        public const string SZLA08 = "SZLA08";

        /// <summary>
        /// SZLA09.
        /// </summary>
        public const string SZLA09 = "SZLA09";

        /// <summary>
        /// SZLA10.
        /// </summary>
        public const string SZLA10 = "SZLA10";

        /// <summary>
        /// SZWSQP.
        /// </summary>
        public const string SZWSQP = "SZWSQP";

        /// <summary>
        /// SZWSQQ.
        /// </summary>
        public const string SZWSQQ = "SZWSQQ";

        /// <summary>
        /// SZWSQR.
        /// </summary>
        public const string SZWSQR = "SZWSQR";

        /// <summary>
        /// SZMMTH.
        /// </summary>
        public const string SZMMTH = "SZMMTH";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZSHAN.
        /// </summary>
        public const string SZSHAN = "SZSHAN";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZPRIO.
        /// </summary>
        public const string SZPRIO = "SZPRIO";

        /// <summary>
        /// SZCARS.
        /// </summary>
        public const string SZCARS = "SZCARS";

        /// <summary>
        /// SZROUT.
        /// </summary>
        public const string SZROUT = "SZROUT";

        /// <summary>
        /// SZSTOP.
        /// </summary>
        public const string SZSTOP = "SZSTOP";

        /// <summary>
        /// SZZON.
        /// </summary>
        public const string SZZON = "SZZON";

        /// <summary>
        /// SZCTNF.
        /// </summary>
        public const string SZCTNF = "SZCTNF";

        /// <summary>
        /// SZVSUG.
        /// </summary>
        public const string SZVSUG = "SZVSUG";

        /// <summary>
        /// SZPHAS.
        /// </summary>
        public const string SZPHAS = "SZPHAS";

        /// <summary>
        /// SZRSBT.
        /// </summary>
        public const string SZRSBT = "SZRSBT";

        /// <summary>
        /// SZRSSQ.
        /// </summary>
        public const string SZRSSQ = "SZRSSQ";

        /// <summary>
        /// SZIUSE.
        /// </summary>
        public const string SZIUSE = "SZIUSE";

        /// <summary>
        /// SZTREX.
        /// </summary>
        public const string SZTREX = "SZTREX";

        /// <summary>
        /// SZDTCR.
        /// </summary>
        public const string SZDTCR = "SZDTCR";

        /// <summary>
        /// SZTMCR.
        /// </summary>
        public const string SZTMCR = "SZTMCR";

        /// <summary>
        /// SZDTPT.
        /// </summary>
        public const string SZDTPT = "SZDTPT";

        /// <summary>
        /// SZTMPT.
        /// </summary>
        public const string SZTMPT = "SZTMPT";

        /// <summary>
        /// SZTRPR.
        /// </summary>
        public const string SZTRPR = "SZTRPR";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZRCDS.
        /// </summary>
        public const string SZRCDS = "SZRCDS";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZUKID.
        /// </summary>
        public const string SZUKID = "SZUKID";

        /// <summary>
        /// SZCKID.
        /// </summary>
        public const string SZCKID = "SZCKID";

        /// <summary>
        /// SZCPNB.
        /// </summary>
        public const string SZCPNB = "SZCPNB";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZPSJOBNO.
        /// </summary>
        public const string SZPSJOBNO = "SZPSJOBNO";

        /// <summary>
        /// SZJOBSQ.
        /// </summary>
        public const string SZJOBSQ = "SZJOBSQ";

        /// <summary>
        /// SZDELBATCH.
        /// </summary>
        public const string SZDELBATCH = "SZDELBATCH";
    }

    /// <inheritdoc />
    public override string TableName => "F4611Z1";

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
        new JdeField("SZTYFL", "SZTYFL", JdeDataType.String, 2),
        new JdeField("SZOCDE", "SZOCDE", JdeDataType.String, 4),
        new JdeField("SZRQBT", "SZRQBT", JdeDataType.Numeric),
        new JdeField("SZRQSQ", "SZRQSQ", JdeDataType.Numeric),
        new JdeField("SZSGBT", "SZSGBT", JdeDataType.Numeric),
        new JdeField("SZSGSQ", "SZSGSQ", JdeDataType.Numeric),
        new JdeField("SZPWAV", "SZPWAV", JdeDataType.Numeric),
        new JdeField("SZPTSK", "SZPTSK", JdeDataType.Numeric),
        new JdeField("SZTRIP", "SZTRIP", JdeDataType.Numeric),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZNLIN", "SZNLIN", JdeDataType.Numeric),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZCLID", "SZCLID", JdeDataType.Numeric),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZUML1", "SZUML1", JdeDataType.String, 4),
        new JdeField("SZTQL1", "SZTQL1", JdeDataType.Numeric),
        new JdeField("SZEQL1", "SZEQL1", JdeDataType.String, 10),
        new JdeField("SZUML2", "SZUML2", JdeDataType.String, 4),
        new JdeField("SZQPL2", "SZQPL2", JdeDataType.Numeric),
        new JdeField("SZTQL2", "SZTQL2", JdeDataType.Numeric),
        new JdeField("SZEQL2", "SZEQL2", JdeDataType.String, 10),
        new JdeField("SZUML3", "SZUML3", JdeDataType.String, 4),
        new JdeField("SZQPL3", "SZQPL3", JdeDataType.Numeric),
        new JdeField("SZTQL3", "SZTQL3", JdeDataType.Numeric),
        new JdeField("SZEQL3", "SZEQL3", JdeDataType.String, 10),
        new JdeField("SZUML4", "SZUML4", JdeDataType.String, 4),
        new JdeField("SZQPL4", "SZQPL4", JdeDataType.Numeric),
        new JdeField("SZTQL4", "SZTQL4", JdeDataType.Numeric),
        new JdeField("SZEQL4", "SZEQL4", JdeDataType.String, 10),
        new JdeField("SZUML5", "SZUML5", JdeDataType.String, 4),
        new JdeField("SZQPL5", "SZQPL5", JdeDataType.Numeric),
        new JdeField("SZTQL5", "SZTQL5", JdeDataType.Numeric),
        new JdeField("SZEQL5", "SZEQL5", JdeDataType.String, 10),
        new JdeField("SZUOM1", "SZUOM1", JdeDataType.String, 4),
        new JdeField("SZTQTY", "SZTQTY", JdeDataType.Numeric),
        new JdeField("SZCUBE", "SZCUBE", JdeDataType.Numeric),
        new JdeField("SZVUMD", "SZVUMD", JdeDataType.String, 4),
        new JdeField("SZWEIT", "SZWEIT", JdeDataType.Numeric),
        new JdeField("SZUWUM", "SZUWUM", JdeDataType.String, 4),
        new JdeField("SZLDFS", "SZLDFS", JdeDataType.Numeric),
        new JdeField("SZFLOC", "SZFLOC", JdeDataType.String, 40),
        new JdeField("SZFLOT", "SZFLOT", JdeDataType.String, 60),
        new JdeField("SZSTNF", "SZSTNF", JdeDataType.Numeric),
        new JdeField("SZLDTS", "SZLDTS", JdeDataType.Numeric),
        new JdeField("SZTLOC", "SZTLOC", JdeDataType.String, 40),
        new JdeField("SZTLOT", "SZTLOT", JdeDataType.String, 60),
        new JdeField("SZSTNT", "SZSTNT", JdeDataType.Numeric),
        new JdeField("SZLOTP", "SZLOTP", JdeDataType.Numeric),
        new JdeField("SZLOTG", "SZLOTG", JdeDataType.String, 6),
        new JdeField("SZMERG", "SZMERG", JdeDataType.String, 2),
        new JdeField("SZEQTY", "SZEQTY", JdeDataType.String, 10),
        new JdeField("SZCRMT", "SZCRMT", JdeDataType.String, 2),
        new JdeField("SZBACK", "SZBACK", JdeDataType.String, 2),
        new JdeField("SZAPTS", "SZAPTS", JdeDataType.String, 2),
        new JdeField("SZCOMM", "SZCOMM", JdeDataType.String, 2),
        new JdeField("SZITCM", "SZITCM", JdeDataType.String, 2),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZINMG", "SZINMG", JdeDataType.String, 20),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZPALC", "SZPALC", JdeDataType.String, 2),
        new JdeField("SZMORD", "SZMORD", JdeDataType.String, 2),
        new JdeField("SZRLIT", "SZRLIT", JdeDataType.String, 16),
        new JdeField("SZKTLN", "SZKTLN", JdeDataType.Numeric),
        new JdeField("SZRKIT", "SZRKIT", JdeDataType.Numeric),
        new JdeField("SZKTP", "SZKTP", JdeDataType.Numeric),
        new JdeField("SZKTBL", "SZKTBL", JdeDataType.String, 2),
        new JdeField("SZPTPH", "SZPTPH", JdeDataType.String, 2),
        new JdeField("SZZIP", "SZZIP", JdeDataType.String, 24),
        new JdeField("SZSRP1", "SZSRP1", JdeDataType.String, 6),
        new JdeField("SZSRP2", "SZSRP2", JdeDataType.String, 6),
        new JdeField("SZSRP3", "SZSRP3", JdeDataType.String, 6),
        new JdeField("SZSRP4", "SZSRP4", JdeDataType.String, 6),
        new JdeField("SZSRP5", "SZSRP5", JdeDataType.String, 6),
        new JdeField("SZPRP6", "SZPRP6", JdeDataType.String, 12),
        new JdeField("SZPRP7", "SZPRP7", JdeDataType.String, 12),
        new JdeField("SZPRP8", "SZPRP8", JdeDataType.String, 12),
        new JdeField("SZPRP9", "SZPRP9", JdeDataType.String, 12),
        new JdeField("SZMPUT", "SZMPUT", JdeDataType.String, 12),
        new JdeField("SZPUTP", "SZPUTP", JdeDataType.String, 2),
        new JdeField("SZSEQ", "SZSEQ", JdeDataType.Numeric),
        new JdeField("SZRCDJ", "SZRCDJ", JdeDataType.Numeric),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZPDDJ", "SZPDDJ", JdeDataType.Numeric),
        new JdeField("SZPACK", "SZPACK", JdeDataType.String, 8),
        new JdeField("SZRPCK", "SZRPCK", JdeDataType.String, 2),
        new JdeField("SZEKEY", "SZEKEY", JdeDataType.String, 8),
        new JdeField("SZCODR", "SZCODR", JdeDataType.String, 6),
        new JdeField("SZPSTB", "SZPSTB", JdeDataType.String, 6),
        new JdeField("SZRESX", "SZRESX", JdeDataType.String, 2),
        new JdeField("SZPZON", "SZPZON", JdeDataType.String, 12),
        new JdeField("SZKZON", "SZKZON", JdeDataType.String, 12),
        new JdeField("SZZONR", "SZZONR", JdeDataType.String, 12),
        new JdeField("SZAISL", "SZAISL", JdeDataType.String, 16),
        new JdeField("SZBIN", "SZBIN", JdeDataType.String, 16),
        new JdeField("SZLA03", "SZLA03", JdeDataType.String, 8),
        new JdeField("SZLA04", "SZLA04", JdeDataType.String, 8),
        new JdeField("SZLA05", "SZLA05", JdeDataType.String, 8),
        new JdeField("SZLA06", "SZLA06", JdeDataType.String, 8),
        new JdeField("SZLA07", "SZLA07", JdeDataType.String, 8),
        new JdeField("SZLA08", "SZLA08", JdeDataType.String, 8),
        new JdeField("SZLA09", "SZLA09", JdeDataType.String, 8),
        new JdeField("SZLA10", "SZLA10", JdeDataType.String, 8),
        new JdeField("SZWSQP", "SZWSQP", JdeDataType.Numeric),
        new JdeField("SZWSQQ", "SZWSQQ", JdeDataType.Numeric),
        new JdeField("SZWSQR", "SZWSQR", JdeDataType.Numeric),
        new JdeField("SZMMTH", "SZMMTH", JdeDataType.String, 8),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZSHAN", "SZSHAN", JdeDataType.Numeric),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZPRIO", "SZPRIO", JdeDataType.String, 2),
        new JdeField("SZCARS", "SZCARS", JdeDataType.Numeric),
        new JdeField("SZROUT", "SZROUT", JdeDataType.String, 6),
        new JdeField("SZSTOP", "SZSTOP", JdeDataType.String, 6),
        new JdeField("SZZON", "SZZON", JdeDataType.String, 6),
        new JdeField("SZCTNF", "SZCTNF", JdeDataType.String, 2),
        new JdeField("SZVSUG", "SZVSUG", JdeDataType.String, 2),
        new JdeField("SZPHAS", "SZPHAS", JdeDataType.String, 2),
        new JdeField("SZRSBT", "SZRSBT", JdeDataType.Numeric),
        new JdeField("SZRSSQ", "SZRSSQ", JdeDataType.Numeric),
        new JdeField("SZIUSE", "SZIUSE", JdeDataType.String, 2),
        new JdeField("SZTREX", "SZTREX", JdeDataType.String, 60),
        new JdeField("SZDTCR", "SZDTCR", JdeDataType.Numeric),
        new JdeField("SZTMCR", "SZTMCR", JdeDataType.Numeric),
        new JdeField("SZDTPT", "SZDTPT", JdeDataType.Numeric),
        new JdeField("SZTMPT", "SZTMPT", JdeDataType.Numeric),
        new JdeField("SZTRPR", "SZTRPR", JdeDataType.Numeric),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZRCDS", "SZRCDS", JdeDataType.String, 2),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZUKID", "SZUKID", JdeDataType.Numeric),
        new JdeField("SZCKID", "SZCKID", JdeDataType.Numeric),
        new JdeField("SZCPNB", "SZCPNB", JdeDataType.Numeric),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZPSJOBNO", "SZPSJOBNO", JdeDataType.String, 30),
        new JdeField("SZJOBSQ", "SZJOBSQ", JdeDataType.String, 30),
        new JdeField("SZDELBATCH", "SZDELBATCH", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4611Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
