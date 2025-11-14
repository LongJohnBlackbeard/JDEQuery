using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3711Z1 - .
/// </summary>
public class F3711Z1 : JdeTable
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
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZRCTO.
        /// </summary>
        public const string SZRCTO = "SZRCTO";

        /// <summary>
        /// SZRORN.
        /// </summary>
        public const string SZRORN = "SZRORN";

        /// <summary>
        /// SZRKCO.
        /// </summary>
        public const string SZRKCO = "SZRKCO";

        /// <summary>
        /// SZRLLN.
        /// </summary>
        public const string SZRLLN = "SZRLLN";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZCS18.
        /// </summary>
        public const string SZCS18 = "SZCS18";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZIT18.
        /// </summary>
        public const string SZIT18 = "SZIT18";

        /// <summary>
        /// SZQTST.
        /// </summary>
        public const string SZQTST = "SZQTST";

        /// <summary>
        /// SZMCU2.
        /// </summary>
        public const string SZMCU2 = "SZMCU2";

        /// <summary>
        /// SZQSPC.
        /// </summary>
        public const string SZQSPC = "SZQSPC";

        /// <summary>
        /// SZHMCU.
        /// </summary>
        public const string SZHMCU = "SZHMCU";

        /// <summary>
        /// SZTSRT.
        /// </summary>
        public const string SZTSRT = "SZTSRT";

        /// <summary>
        /// SZQREV.
        /// </summary>
        public const string SZQREV = "SZQREV";

        /// <summary>
        /// SZQVAL.
        /// </summary>
        public const string SZQVAL = "SZQVAL";

        /// <summary>
        /// SZQPF.
        /// </summary>
        public const string SZQPF = "SZQPF";

        /// <summary>
        /// SZTOVR.
        /// </summary>
        public const string SZTOVR = "SZTOVR";

        /// <summary>
        /// SZMUSE.
        /// </summary>
        public const string SZMUSE = "SZMUSE";

        /// <summary>
        /// SZANO.
        /// </summary>
        public const string SZANO = "SZANO";

        /// <summary>
        /// SZQDAT.
        /// </summary>
        public const string SZQDAT = "SZQDAT";

        /// <summary>
        /// SZQTIM.
        /// </summary>
        public const string SZQTIM = "SZQTIM";

        /// <summary>
        /// SZQDSP.
        /// </summary>
        public const string SZQDSP = "SZQDSP";

        /// <summary>
        /// SZSNBR.
        /// </summary>
        public const string SZSNBR = "SZSNBR";

        /// <summary>
        /// SZQSMP.
        /// </summary>
        public const string SZQSMP = "SZQSMP";

        /// <summary>
        /// SZSMPC.
        /// </summary>
        public const string SZSMPC = "SZSMPC";

        /// <summary>
        /// SZACQT.
        /// </summary>
        public const string SZACQT = "SZACQT";

        /// <summary>
        /// SZACPC.
        /// </summary>
        public const string SZACPC = "SZACPC";

        /// <summary>
        /// SZSY.
        /// </summary>
        public const string SZSY = "SZSY";

        /// <summary>
        /// SZRT.
        /// </summary>
        public const string SZRT = "SZRT";

        /// <summary>
        /// SZAMIN.
        /// </summary>
        public const string SZAMIN = "SZAMIN";

        /// <summary>
        /// SZAMAX.
        /// </summary>
        public const string SZAMAX = "SZAMAX";

        /// <summary>
        /// SZPMIN.
        /// </summary>
        public const string SZPMIN = "SZPMIN";

        /// <summary>
        /// SZPMAX.
        /// </summary>
        public const string SZPMAX = "SZPMAX";

        /// <summary>
        /// SZEFFF.
        /// </summary>
        public const string SZEFFF = "SZEFFF";

        /// <summary>
        /// SZEFFT.
        /// </summary>
        public const string SZEFFT = "SZEFFT";

        /// <summary>
        /// SZQTRG.
        /// </summary>
        public const string SZQTRG = "SZQTRG";

        /// <summary>
        /// SZQSSZ.
        /// </summary>
        public const string SZQSSZ = "SZQSSZ";

        /// <summary>
        /// SZQASZ.
        /// </summary>
        public const string SZQASZ = "SZQASZ";

        /// <summary>
        /// SZQUM.
        /// </summary>
        public const string SZQUM = "SZQUM";

        /// <summary>
        /// SZPTTS.
        /// </summary>
        public const string SZPTTS = "SZPTTS";

        /// <summary>
        /// SZQTC1.
        /// </summary>
        public const string SZQTC1 = "SZQTC1";

        /// <summary>
        /// SZQTC2.
        /// </summary>
        public const string SZQTC2 = "SZQTC2";

        /// <summary>
        /// SZQTC3.
        /// </summary>
        public const string SZQTC3 = "SZQTC3";

        /// <summary>
        /// SZQTC4.
        /// </summary>
        public const string SZQTC4 = "SZQTC4";

        /// <summary>
        /// SZQTC5.
        /// </summary>
        public const string SZQTC5 = "SZQTC5";

        /// <summary>
        /// SZTTTY.
        /// </summary>
        public const string SZTTTY = "SZTTTY";

        /// <summary>
        /// SZMFGR.
        /// </summary>
        public const string SZMFGR = "SZMFGR";

        /// <summary>
        /// SZMRRR.
        /// </summary>
        public const string SZMRRR = "SZMRRR";

        /// <summary>
        /// SZMFGC.
        /// </summary>
        public const string SZMFGC = "SZMFGC";

        /// <summary>
        /// SZPRCR.
        /// </summary>
        public const string SZPRCR = "SZPRCR";

        /// <summary>
        /// SZPRER.
        /// </summary>
        public const string SZPRER = "SZPRER";

        /// <summary>
        /// SZSHPR.
        /// </summary>
        public const string SZSHPR = "SZSHPR";

        /// <summary>
        /// SZBLKR.
        /// </summary>
        public const string SZBLKR = "SZBLKR";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZOPRS.
        /// </summary>
        public const string SZOPRS = "SZOPRS";

        /// <summary>
        /// SZBSEQ.
        /// </summary>
        public const string SZBSEQ = "SZBSEQ";

        /// <summary>
        /// SZTRT.
        /// </summary>
        public const string SZTRT = "SZTRT";

        /// <summary>
        /// SZTRP.
        /// </summary>
        public const string SZTRP = "SZTRP";

        /// <summary>
        /// SZTRPL.
        /// </summary>
        public const string SZTRPL = "SZTRPL";

        /// <summary>
        /// SZLCMP.
        /// </summary>
        public const string SZLCMP = "SZLCMP";

        /// <summary>
        /// SZVEHI.
        /// </summary>
        public const string SZVEHI = "SZVEHI";

        /// <summary>
        /// SZRSQQ.
        /// </summary>
        public const string SZRSQQ = "SZRSQQ";

        /// <summary>
        /// SZTTST.
        /// </summary>
        public const string SZTTST = "SZTTST";

        /// <summary>
        /// SZDFCW.
        /// </summary>
        public const string SZDFCW = "SZDFCW";

        /// <summary>
        /// SZQPCD.
        /// </summary>
        public const string SZQPCD = "SZQPCD";

        /// <summary>
        /// SZQTID.
        /// </summary>
        public const string SZQTID = "SZQTID";

        /// <summary>
        /// SZTMHD.
        /// </summary>
        public const string SZTMHD = "SZTMHD";

        /// <summary>
        /// SZRSUM.
        /// </summary>
        public const string SZRSUM = "SZRSUM";

        /// <summary>
        /// SZNUMB.
        /// </summary>
        public const string SZNUMB = "SZNUMB";

        /// <summary>
        /// SZASTM.
        /// </summary>
        public const string SZASTM = "SZASTM";

        /// <summary>
        /// SZQPRP.
        /// </summary>
        public const string SZQPRP = "SZQPRP";

        /// <summary>
        /// SZQDFC.
        /// </summary>
        public const string SZQDFC = "SZQDFC";

        /// <summary>
        /// SZQRTC.
        /// </summary>
        public const string SZQRTC = "SZQRTC";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZCDEC.
        /// </summary>
        public const string SZCDEC = "SZCDEC";

        /// <summary>
        /// SZUKID.
        /// </summary>
        public const string SZUKID = "SZUKID";

        /// <summary>
        /// SZDERC.
        /// </summary>
        public const string SZDERC = "SZDERC";

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
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZQMRF3.
        /// </summary>
        public const string SZQMRF3 = "SZQMRF3";

        /// <summary>
        /// SZQMCD3.
        /// </summary>
        public const string SZQMCD3 = "SZQMCD3";

        /// <summary>
        /// SZQMAB3.
        /// </summary>
        public const string SZQMAB3 = "SZQMAB3";

        /// <summary>
        /// SZQMNUM3.
        /// </summary>
        public const string SZQMNUM3 = "SZQMNUM3";

        /// <summary>
        /// SZQMDT3.
        /// </summary>
        public const string SZQMDT3 = "SZQMDT3";

        /// <summary>
        /// SZTSTRTY.
        /// </summary>
        public const string SZTSTRTY = "SZTSTRTY";

        /// <summary>
        /// SZMELC.
        /// </summary>
        public const string SZMELC = "SZMELC";

        /// <summary>
        /// SZPRVRSNM.
        /// </summary>
        public const string SZPRVRSNM = "SZPRVRSNM";

        /// <summary>
        /// SZPRVQVAL.
        /// </summary>
        public const string SZPRVQVAL = "SZPRVQVAL";

        /// <summary>
        /// SZPRVQDAT.
        /// </summary>
        public const string SZPRVQDAT = "SZPRVQDAT";

        /// <summary>
        /// SZPRVRSUM.
        /// </summary>
        public const string SZPRVRSUM = "SZPRVRSUM";

        /// <summary>
        /// SZDLAB.
        /// </summary>
        public const string SZDLAB = "SZDLAB";

        /// <summary>
        /// SZNUMT.
        /// </summary>
        public const string SZNUMT = "SZNUMT";

        /// <summary>
        /// SZNUMT3.
        /// </summary>
        public const string SZNUMT3 = "SZNUMT3";

        /// <summary>
        /// SZRNAMAX.
        /// </summary>
        public const string SZRNAMAX = "SZRNAMAX";

        /// <summary>
        /// SZRNAMIN.
        /// </summary>
        public const string SZRNAMIN = "SZRNAMIN";

        /// <summary>
        /// SZRNPMAX.
        /// </summary>
        public const string SZRNPMAX = "SZRNPMAX";

        /// <summary>
        /// SZRNPMIN.
        /// </summary>
        public const string SZRNPMIN = "SZRNPMIN";

        /// <summary>
        /// SZRNQTRG.
        /// </summary>
        public const string SZRNQTRG = "SZRNQTRG";

        /// <summary>
        /// SZSY1.
        /// </summary>
        public const string SZSY1 = "SZSY1";

        /// <summary>
        /// SZRT1.
        /// </summary>
        public const string SZRT1 = "SZRT1";

        /// <summary>
        /// SZWVNUM.
        /// </summary>
        public const string SZWVNUM = "SZWVNUM";

        /// <summary>
        /// SZBLUID.
        /// </summary>
        public const string SZBLUID = "SZBLUID";

        /// <summary>
        /// SZSBLUID.
        /// </summary>
        public const string SZSBLUID = "SZSBLUID";

        /// <summary>
        /// SZWLOTN.
        /// </summary>
        public const string SZWLOTN = "SZWLOTN";

        /// <summary>
        /// SZWOPID.
        /// </summary>
        public const string SZWOPID = "SZWOPID";

        /// <summary>
        /// SZRSEXPD.
        /// </summary>
        public const string SZRSEXPD = "SZRSEXPD";

        /// <summary>
        /// SZWVID.
        /// </summary>
        public const string SZWVID = "SZWVID";

        /// <summary>
        /// SZWVTY.
        /// </summary>
        public const string SZWVTY = "SZWVTY";

        /// <summary>
        /// SZTSTRSNM.
        /// </summary>
        public const string SZTSTRSNM = "SZTSTRSNM";

        /// <summary>
        /// SZRSSTS.
        /// </summary>
        public const string SZRSSTS = "SZRSSTS";

        /// <summary>
        /// SZRSCONVID.
        /// </summary>
        public const string SZRSCONVID = "SZRSCONVID";

        /// <summary>
        /// SZFRMRSVAL.
        /// </summary>
        public const string SZFRMRSVAL = "SZFRMRSVAL";

        /// <summary>
        /// SZFRMRSUM.
        /// </summary>
        public const string SZFRMRSUM = "SZFRMRSUM";

        /// <summary>
        /// SZQABLRUL.
        /// </summary>
        public const string SZQABLRUL = "SZQABLRUL";

        /// <summary>
        /// SZCDEC2.
        /// </summary>
        public const string SZCDEC2 = "SZCDEC2";

        /// <summary>
        /// SZSMPCNSL.
        /// </summary>
        public const string SZSMPCNSL = "SZSMPCNSL";

        /// <summary>
        /// SZBSNBR.
        /// </summary>
        public const string SZBSNBR = "SZBSNBR";
    }

    /// <inheritdoc />
    public override string TableName => "F3711Z1";

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
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZRCTO", "SZRCTO", JdeDataType.String, 4),
        new JdeField("SZRORN", "SZRORN", JdeDataType.String, 16),
        new JdeField("SZRKCO", "SZRKCO", JdeDataType.String, 10),
        new JdeField("SZRLLN", "SZRLLN", JdeDataType.Numeric),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZCS18", "SZCS18", JdeDataType.String, 16),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZIT18", "SZIT18", JdeDataType.String, 16),
        new JdeField("SZQTST", "SZQTST", JdeDataType.String, 50),
        new JdeField("SZMCU2", "SZMCU2", JdeDataType.String, 24),
        new JdeField("SZQSPC", "SZQSPC", JdeDataType.String, 50),
        new JdeField("SZHMCU", "SZHMCU", JdeDataType.String, 24),
        new JdeField("SZTSRT", "SZTSRT", JdeDataType.Numeric),
        new JdeField("SZQREV", "SZQREV", JdeDataType.String, 6),
        new JdeField("SZQVAL", "SZQVAL", JdeDataType.String, 30),
        new JdeField("SZQPF", "SZQPF", JdeDataType.String, 2),
        new JdeField("SZTOVR", "SZTOVR", JdeDataType.String, 2),
        new JdeField("SZMUSE", "SZMUSE", JdeDataType.String, 20),
        new JdeField("SZANO", "SZANO", JdeDataType.Numeric),
        new JdeField("SZQDAT", "SZQDAT", JdeDataType.Numeric),
        new JdeField("SZQTIM", "SZQTIM", JdeDataType.Numeric),
        new JdeField("SZQDSP", "SZQDSP", JdeDataType.String, 6),
        new JdeField("SZSNBR", "SZSNBR", JdeDataType.Numeric),
        new JdeField("SZQSMP", "SZQSMP", JdeDataType.Numeric),
        new JdeField("SZSMPC", "SZSMPC", JdeDataType.Numeric),
        new JdeField("SZACQT", "SZACQT", JdeDataType.Numeric),
        new JdeField("SZACPC", "SZACPC", JdeDataType.Numeric),
        new JdeField("SZSY", "SZSY", JdeDataType.String, 8),
        new JdeField("SZRT", "SZRT", JdeDataType.String, 4),
        new JdeField("SZAMIN", "SZAMIN", JdeDataType.String, 30),
        new JdeField("SZAMAX", "SZAMAX", JdeDataType.String, 30),
        new JdeField("SZPMIN", "SZPMIN", JdeDataType.String, 30),
        new JdeField("SZPMAX", "SZPMAX", JdeDataType.String, 30),
        new JdeField("SZEFFF", "SZEFFF", JdeDataType.Numeric),
        new JdeField("SZEFFT", "SZEFFT", JdeDataType.Numeric),
        new JdeField("SZQTRG", "SZQTRG", JdeDataType.String, 30),
        new JdeField("SZQSSZ", "SZQSSZ", JdeDataType.Numeric),
        new JdeField("SZQASZ", "SZQASZ", JdeDataType.Numeric),
        new JdeField("SZQUM", "SZQUM", JdeDataType.String, 6),
        new JdeField("SZPTTS", "SZPTTS", JdeDataType.String, 2),
        new JdeField("SZQTC1", "SZQTC1", JdeDataType.String, 6),
        new JdeField("SZQTC2", "SZQTC2", JdeDataType.String, 6),
        new JdeField("SZQTC3", "SZQTC3", JdeDataType.String, 6),
        new JdeField("SZQTC4", "SZQTC4", JdeDataType.String, 6),
        new JdeField("SZQTC5", "SZQTC5", JdeDataType.String, 6),
        new JdeField("SZTTTY", "SZTTTY", JdeDataType.String, 2),
        new JdeField("SZMFGR", "SZMFGR", JdeDataType.String, 2),
        new JdeField("SZMRRR", "SZMRRR", JdeDataType.String, 2),
        new JdeField("SZMFGC", "SZMFGC", JdeDataType.String, 2),
        new JdeField("SZPRCR", "SZPRCR", JdeDataType.String, 2),
        new JdeField("SZPRER", "SZPRER", JdeDataType.String, 2),
        new JdeField("SZSHPR", "SZSHPR", JdeDataType.String, 2),
        new JdeField("SZBLKR", "SZBLKR", JdeDataType.String, 2),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZOPRS", "SZOPRS", JdeDataType.Numeric),
        new JdeField("SZBSEQ", "SZBSEQ", JdeDataType.Numeric),
        new JdeField("SZTRT", "SZTRT", JdeDataType.String, 6),
        new JdeField("SZTRP", "SZTRP", JdeDataType.Numeric),
        new JdeField("SZTRPL", "SZTRPL", JdeDataType.Numeric),
        new JdeField("SZLCMP", "SZLCMP", JdeDataType.Numeric),
        new JdeField("SZVEHI", "SZVEHI", JdeDataType.String, 24),
        new JdeField("SZRSQQ", "SZRSQQ", JdeDataType.Numeric),
        new JdeField("SZTTST", "SZTTST", JdeDataType.String, 2),
        new JdeField("SZDFCW", "SZDFCW", JdeDataType.String, 2),
        new JdeField("SZQPCD", "SZQPCD", JdeDataType.String, 4),
        new JdeField("SZQTID", "SZQTID", JdeDataType.Numeric),
        new JdeField("SZTMHD", "SZTMHD", JdeDataType.String, 60),
        new JdeField("SZRSUM", "SZRSUM", JdeDataType.String, 6),
        new JdeField("SZNUMB", "SZNUMB", JdeDataType.Numeric),
        new JdeField("SZASTM", "SZASTM", JdeDataType.String, 60),
        new JdeField("SZQPRP", "SZQPRP", JdeDataType.String, 20),
        new JdeField("SZQDFC", "SZQDFC", JdeDataType.String, 6),
        new JdeField("SZQRTC", "SZQRTC", JdeDataType.String, 6),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZCDEC", "SZCDEC", JdeDataType.String, 2),
        new JdeField("SZUKID", "SZUKID", JdeDataType.Numeric),
        new JdeField("SZDERC", "SZDERC", JdeDataType.String, 160),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZQMRF3", "SZQMRF3", JdeDataType.String, 60),
        new JdeField("SZQMCD3", "SZQMCD3", JdeDataType.String, 6),
        new JdeField("SZQMAB3", "SZQMAB3", JdeDataType.Numeric),
        new JdeField("SZQMNUM3", "SZQMNUM3", JdeDataType.Numeric),
        new JdeField("SZQMDT3", "SZQMDT3", JdeDataType.Numeric),
        new JdeField("SZTSTRTY", "SZTSTRTY", JdeDataType.String, 6),
        new JdeField("SZMELC", "SZMELC", JdeDataType.String, 20),
        new JdeField("SZPRVRSNM", "SZPRVRSNM", JdeDataType.String, 30),
        new JdeField("SZPRVQVAL", "SZPRVQVAL", JdeDataType.String, 30),
        new JdeField("SZPRVQDAT", "SZPRVQDAT", JdeDataType.Numeric),
        new JdeField("SZPRVRSUM", "SZPRVRSUM", JdeDataType.String, 6),
        new JdeField("SZDLAB", "SZDLAB", JdeDataType.Numeric),
        new JdeField("SZNUMT", "SZNUMT", JdeDataType.String, 2),
        new JdeField("SZNUMT3", "SZNUMT3", JdeDataType.String, 2),
        new JdeField("SZRNAMAX", "SZRNAMAX", JdeDataType.String, 30),
        new JdeField("SZRNAMIN", "SZRNAMIN", JdeDataType.String, 30),
        new JdeField("SZRNPMAX", "SZRNPMAX", JdeDataType.String, 30),
        new JdeField("SZRNPMIN", "SZRNPMIN", JdeDataType.String, 30),
        new JdeField("SZRNQTRG", "SZRNQTRG", JdeDataType.String, 30),
        new JdeField("SZSY1", "SZSY1", JdeDataType.String, 8),
        new JdeField("SZRT1", "SZRT1", JdeDataType.String, 4),
        new JdeField("SZWVNUM", "SZWVNUM", JdeDataType.String, 60),
        new JdeField("SZBLUID", "SZBLUID", JdeDataType.Numeric),
        new JdeField("SZSBLUID", "SZSBLUID", JdeDataType.Numeric),
        new JdeField("SZWLOTN", "SZWLOTN", JdeDataType.String, 60),
        new JdeField("SZWOPID", "SZWOPID", JdeDataType.Numeric),
        new JdeField("SZRSEXPD", "SZRSEXPD", JdeDataType.Numeric),
        new JdeField("SZWVID", "SZWVID", JdeDataType.Numeric),
        new JdeField("SZWVTY", "SZWVTY", JdeDataType.String, 2),
        new JdeField("SZTSTRSNM", "SZTSTRSNM", JdeDataType.String, 60),
        new JdeField("SZRSSTS", "SZRSSTS", JdeDataType.String, 2),
        new JdeField("SZRSCONVID", "SZRSCONVID", JdeDataType.String, 60),
        new JdeField("SZFRMRSVAL", "SZFRMRSVAL", JdeDataType.String, 30),
        new JdeField("SZFRMRSUM", "SZFRMRSUM", JdeDataType.String, 6),
        new JdeField("SZQABLRUL", "SZQABLRUL", JdeDataType.String, 10),
        new JdeField("SZCDEC2", "SZCDEC2", JdeDataType.String, 2),
        new JdeField("SZSMPCNSL", "SZSMPCNSL", JdeDataType.String, 4),
        new JdeField("SZBSNBR", "SZBSNBR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3711Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3711Z1_1", "Index on SZUKID", new[] { "SZUKID" })
    };
}
