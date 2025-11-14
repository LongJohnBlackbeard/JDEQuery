using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3711 - .
/// </summary>
public class F3711 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRDOCO.
        /// </summary>
        public const string TRDOCO = "TRDOCO";

        /// <summary>
        /// TRDCTO.
        /// </summary>
        public const string TRDCTO = "TRDCTO";

        /// <summary>
        /// TRKCOO.
        /// </summary>
        public const string TRKCOO = "TRKCOO";

        /// <summary>
        /// TRLNID.
        /// </summary>
        public const string TRLNID = "TRLNID";

        /// <summary>
        /// TRRCTO.
        /// </summary>
        public const string TRRCTO = "TRRCTO";

        /// <summary>
        /// TRRORN.
        /// </summary>
        public const string TRRORN = "TRRORN";

        /// <summary>
        /// TRRKCO.
        /// </summary>
        public const string TRRKCO = "TRRKCO";

        /// <summary>
        /// TRRLLN.
        /// </summary>
        public const string TRRLLN = "TRRLLN";

        /// <summary>
        /// TRMCU.
        /// </summary>
        public const string TRMCU = "TRMCU";

        /// <summary>
        /// TRLOCN.
        /// </summary>
        public const string TRLOCN = "TRLOCN";

        /// <summary>
        /// TRLOTN.
        /// </summary>
        public const string TRLOTN = "TRLOTN";

        /// <summary>
        /// TRAN8.
        /// </summary>
        public const string TRAN8 = "TRAN8";

        /// <summary>
        /// TRCS18.
        /// </summary>
        public const string TRCS18 = "TRCS18";

        /// <summary>
        /// TRITM.
        /// </summary>
        public const string TRITM = "TRITM";

        /// <summary>
        /// TRIT18.
        /// </summary>
        public const string TRIT18 = "TRIT18";

        /// <summary>
        /// TRQTST.
        /// </summary>
        public const string TRQTST = "TRQTST";

        /// <summary>
        /// TRMCU2.
        /// </summary>
        public const string TRMCU2 = "TRMCU2";

        /// <summary>
        /// TRQSPC.
        /// </summary>
        public const string TRQSPC = "TRQSPC";

        /// <summary>
        /// TRHMCU.
        /// </summary>
        public const string TRHMCU = "TRHMCU";

        /// <summary>
        /// TRTSRT.
        /// </summary>
        public const string TRTSRT = "TRTSRT";

        /// <summary>
        /// TRQREV.
        /// </summary>
        public const string TRQREV = "TRQREV";

        /// <summary>
        /// TRQVAL.
        /// </summary>
        public const string TRQVAL = "TRQVAL";

        /// <summary>
        /// TRQPF.
        /// </summary>
        public const string TRQPF = "TRQPF";

        /// <summary>
        /// TRTOVR.
        /// </summary>
        public const string TRTOVR = "TRTOVR";

        /// <summary>
        /// TRMUSE.
        /// </summary>
        public const string TRMUSE = "TRMUSE";

        /// <summary>
        /// TRANO.
        /// </summary>
        public const string TRANO = "TRANO";

        /// <summary>
        /// TRQDAT.
        /// </summary>
        public const string TRQDAT = "TRQDAT";

        /// <summary>
        /// TRQTIM.
        /// </summary>
        public const string TRQTIM = "TRQTIM";

        /// <summary>
        /// TRQDSP.
        /// </summary>
        public const string TRQDSP = "TRQDSP";

        /// <summary>
        /// TRSNBR.
        /// </summary>
        public const string TRSNBR = "TRSNBR";

        /// <summary>
        /// TRQSMP.
        /// </summary>
        public const string TRQSMP = "TRQSMP";

        /// <summary>
        /// TRSMPC.
        /// </summary>
        public const string TRSMPC = "TRSMPC";

        /// <summary>
        /// TRACQT.
        /// </summary>
        public const string TRACQT = "TRACQT";

        /// <summary>
        /// TRACPC.
        /// </summary>
        public const string TRACPC = "TRACPC";

        /// <summary>
        /// TRSY.
        /// </summary>
        public const string TRSY = "TRSY";

        /// <summary>
        /// TRRT.
        /// </summary>
        public const string TRRT = "TRRT";

        /// <summary>
        /// TRAMIN.
        /// </summary>
        public const string TRAMIN = "TRAMIN";

        /// <summary>
        /// TRAMAX.
        /// </summary>
        public const string TRAMAX = "TRAMAX";

        /// <summary>
        /// TRPMIN.
        /// </summary>
        public const string TRPMIN = "TRPMIN";

        /// <summary>
        /// TRPMAX.
        /// </summary>
        public const string TRPMAX = "TRPMAX";

        /// <summary>
        /// TREFFF.
        /// </summary>
        public const string TREFFF = "TREFFF";

        /// <summary>
        /// TREFFT.
        /// </summary>
        public const string TREFFT = "TREFFT";

        /// <summary>
        /// TRQTRG.
        /// </summary>
        public const string TRQTRG = "TRQTRG";

        /// <summary>
        /// TRQSSZ.
        /// </summary>
        public const string TRQSSZ = "TRQSSZ";

        /// <summary>
        /// TRQASZ.
        /// </summary>
        public const string TRQASZ = "TRQASZ";

        /// <summary>
        /// TRQUM.
        /// </summary>
        public const string TRQUM = "TRQUM";

        /// <summary>
        /// TRPTTS.
        /// </summary>
        public const string TRPTTS = "TRPTTS";

        /// <summary>
        /// TRQTC1.
        /// </summary>
        public const string TRQTC1 = "TRQTC1";

        /// <summary>
        /// TRQTC2.
        /// </summary>
        public const string TRQTC2 = "TRQTC2";

        /// <summary>
        /// TRQTC3.
        /// </summary>
        public const string TRQTC3 = "TRQTC3";

        /// <summary>
        /// TRQTC4.
        /// </summary>
        public const string TRQTC4 = "TRQTC4";

        /// <summary>
        /// TRQTC5.
        /// </summary>
        public const string TRQTC5 = "TRQTC5";

        /// <summary>
        /// TRTTTY.
        /// </summary>
        public const string TRTTTY = "TRTTTY";

        /// <summary>
        /// TRMFGR.
        /// </summary>
        public const string TRMFGR = "TRMFGR";

        /// <summary>
        /// TRMRRR.
        /// </summary>
        public const string TRMRRR = "TRMRRR";

        /// <summary>
        /// TRMFGC.
        /// </summary>
        public const string TRMFGC = "TRMFGC";

        /// <summary>
        /// TRPRCR.
        /// </summary>
        public const string TRPRCR = "TRPRCR";

        /// <summary>
        /// TRPRER.
        /// </summary>
        public const string TRPRER = "TRPRER";

        /// <summary>
        /// TRSHPR.
        /// </summary>
        public const string TRSHPR = "TRSHPR";

        /// <summary>
        /// TRBLKR.
        /// </summary>
        public const string TRBLKR = "TRBLKR";

        /// <summary>
        /// TROPSQ.
        /// </summary>
        public const string TROPSQ = "TROPSQ";

        /// <summary>
        /// TROPRS.
        /// </summary>
        public const string TROPRS = "TROPRS";

        /// <summary>
        /// TRBSEQ.
        /// </summary>
        public const string TRBSEQ = "TRBSEQ";

        /// <summary>
        /// TRTRT.
        /// </summary>
        public const string TRTRT = "TRTRT";

        /// <summary>
        /// TRTRP.
        /// </summary>
        public const string TRTRP = "TRTRP";

        /// <summary>
        /// TRTRPL.
        /// </summary>
        public const string TRTRPL = "TRTRPL";

        /// <summary>
        /// TRLCMP.
        /// </summary>
        public const string TRLCMP = "TRLCMP";

        /// <summary>
        /// TRVEHI.
        /// </summary>
        public const string TRVEHI = "TRVEHI";

        /// <summary>
        /// TRRSQQ.
        /// </summary>
        public const string TRRSQQ = "TRRSQQ";

        /// <summary>
        /// TRTTST.
        /// </summary>
        public const string TRTTST = "TRTTST";

        /// <summary>
        /// TRDFCW.
        /// </summary>
        public const string TRDFCW = "TRDFCW";

        /// <summary>
        /// TRQPCD.
        /// </summary>
        public const string TRQPCD = "TRQPCD";

        /// <summary>
        /// TRQTID.
        /// </summary>
        public const string TRQTID = "TRQTID";

        /// <summary>
        /// TRTMHD.
        /// </summary>
        public const string TRTMHD = "TRTMHD";

        /// <summary>
        /// TRRSUM.
        /// </summary>
        public const string TRRSUM = "TRRSUM";

        /// <summary>
        /// TRNUMB.
        /// </summary>
        public const string TRNUMB = "TRNUMB";

        /// <summary>
        /// TRASTM.
        /// </summary>
        public const string TRASTM = "TRASTM";

        /// <summary>
        /// TRQPRP.
        /// </summary>
        public const string TRQPRP = "TRQPRP";

        /// <summary>
        /// TRQDFC.
        /// </summary>
        public const string TRQDFC = "TRQDFC";

        /// <summary>
        /// TRQRTC.
        /// </summary>
        public const string TRQRTC = "TRQRTC";

        /// <summary>
        /// TRMMCU.
        /// </summary>
        public const string TRMMCU = "TRMMCU";

        /// <summary>
        /// TRCDEC.
        /// </summary>
        public const string TRCDEC = "TRCDEC";

        /// <summary>
        /// TRUKID.
        /// </summary>
        public const string TRUKID = "TRUKID";

        /// <summary>
        /// TRDERC.
        /// </summary>
        public const string TRDERC = "TRDERC";

        /// <summary>
        /// TRURCD.
        /// </summary>
        public const string TRURCD = "TRURCD";

        /// <summary>
        /// TRURDT.
        /// </summary>
        public const string TRURDT = "TRURDT";

        /// <summary>
        /// TRURAT.
        /// </summary>
        public const string TRURAT = "TRURAT";

        /// <summary>
        /// TRURRF.
        /// </summary>
        public const string TRURRF = "TRURRF";

        /// <summary>
        /// TRURAB.
        /// </summary>
        public const string TRURAB = "TRURAB";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRTDAY.
        /// </summary>
        public const string TRTDAY = "TRTDAY";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRWLOTN.
        /// </summary>
        public const string TRWLOTN = "TRWLOTN";

        /// <summary>
        /// TRWOPID.
        /// </summary>
        public const string TRWOPID = "TRWOPID";

        /// <summary>
        /// TRRSEXPD.
        /// </summary>
        public const string TRRSEXPD = "TRRSEXPD";

        /// <summary>
        /// TRWVID.
        /// </summary>
        public const string TRWVID = "TRWVID";

        /// <summary>
        /// TRWVTY.
        /// </summary>
        public const string TRWVTY = "TRWVTY";

        /// <summary>
        /// TRTSTRSNM.
        /// </summary>
        public const string TRTSTRSNM = "TRTSTRSNM";

        /// <summary>
        /// TRRSSTS.
        /// </summary>
        public const string TRRSSTS = "TRRSSTS";

        /// <summary>
        /// TRRSCONVID.
        /// </summary>
        public const string TRRSCONVID = "TRRSCONVID";

        /// <summary>
        /// TRFRMRSVAL.
        /// </summary>
        public const string TRFRMRSVAL = "TRFRMRSVAL";

        /// <summary>
        /// TRFRMRSUM.
        /// </summary>
        public const string TRFRMRSUM = "TRFRMRSUM";

        /// <summary>
        /// TRQMRF3.
        /// </summary>
        public const string TRQMRF3 = "TRQMRF3";

        /// <summary>
        /// TRQMCD3.
        /// </summary>
        public const string TRQMCD3 = "TRQMCD3";

        /// <summary>
        /// TRQMAB3.
        /// </summary>
        public const string TRQMAB3 = "TRQMAB3";

        /// <summary>
        /// TRQMNUM3.
        /// </summary>
        public const string TRQMNUM3 = "TRQMNUM3";

        /// <summary>
        /// TRQMDT3.
        /// </summary>
        public const string TRQMDT3 = "TRQMDT3";

        /// <summary>
        /// TRQABLRUL.
        /// </summary>
        public const string TRQABLRUL = "TRQABLRUL";

        /// <summary>
        /// TRCDEC2.
        /// </summary>
        public const string TRCDEC2 = "TRCDEC2";

        /// <summary>
        /// TRPRVQVAL.
        /// </summary>
        public const string TRPRVQVAL = "TRPRVQVAL";

        /// <summary>
        /// TRPRVQDAT.
        /// </summary>
        public const string TRPRVQDAT = "TRPRVQDAT";

        /// <summary>
        /// TRPRVRSNM.
        /// </summary>
        public const string TRPRVRSNM = "TRPRVRSNM";

        /// <summary>
        /// TRNUMT.
        /// </summary>
        public const string TRNUMT = "TRNUMT";

        /// <summary>
        /// TRNUMT3.
        /// </summary>
        public const string TRNUMT3 = "TRNUMT3";

        /// <summary>
        /// TRPRVRSUM.
        /// </summary>
        public const string TRPRVRSUM = "TRPRVRSUM";

        /// <summary>
        /// TRDLAB.
        /// </summary>
        public const string TRDLAB = "TRDLAB";

        /// <summary>
        /// TRMELC.
        /// </summary>
        public const string TRMELC = "TRMELC";

        /// <summary>
        /// TRRNAMAX.
        /// </summary>
        public const string TRRNAMAX = "TRRNAMAX";

        /// <summary>
        /// TRRNAMIN.
        /// </summary>
        public const string TRRNAMIN = "TRRNAMIN";

        /// <summary>
        /// TRRNPMAX.
        /// </summary>
        public const string TRRNPMAX = "TRRNPMAX";

        /// <summary>
        /// TRRNPMIN.
        /// </summary>
        public const string TRRNPMIN = "TRRNPMIN";

        /// <summary>
        /// TRRNQTRG.
        /// </summary>
        public const string TRRNQTRG = "TRRNQTRG";

        /// <summary>
        /// TRBLUID.
        /// </summary>
        public const string TRBLUID = "TRBLUID";

        /// <summary>
        /// TRSBLUID.
        /// </summary>
        public const string TRSBLUID = "TRSBLUID";

        /// <summary>
        /// TRSY1.
        /// </summary>
        public const string TRSY1 = "TRSY1";

        /// <summary>
        /// TRRT1.
        /// </summary>
        public const string TRRT1 = "TRRT1";

        /// <summary>
        /// TRTSTRTY.
        /// </summary>
        public const string TRTSTRTY = "TRTSTRTY";

        /// <summary>
        /// TRWVNUM.
        /// </summary>
        public const string TRWVNUM = "TRWVNUM";

        /// <summary>
        /// TRSMPCNSL.
        /// </summary>
        public const string TRSMPCNSL = "TRSMPCNSL";

        /// <summary>
        /// TRBSNBR.
        /// </summary>
        public const string TRBSNBR = "TRBSNBR";

        /// <summary>
        /// TRWTBID.
        /// </summary>
        public const string TRWTBID = "TRWTBID";
    }

    /// <inheritdoc />
    public override string TableName => "F3711";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRDOCO", "TRDOCO", JdeDataType.Numeric),
        new JdeField("TRDCTO", "TRDCTO", JdeDataType.String, 4),
        new JdeField("TRKCOO", "TRKCOO", JdeDataType.String, 10),
        new JdeField("TRLNID", "TRLNID", JdeDataType.Numeric),
        new JdeField("TRRCTO", "TRRCTO", JdeDataType.String, 4),
        new JdeField("TRRORN", "TRRORN", JdeDataType.String, 16),
        new JdeField("TRRKCO", "TRRKCO", JdeDataType.String, 10),
        new JdeField("TRRLLN", "TRRLLN", JdeDataType.Numeric),
        new JdeField("TRMCU", "TRMCU", JdeDataType.String, 24),
        new JdeField("TRLOCN", "TRLOCN", JdeDataType.String, 40),
        new JdeField("TRLOTN", "TRLOTN", JdeDataType.String, 60),
        new JdeField("TRAN8", "TRAN8", JdeDataType.Numeric),
        new JdeField("TRCS18", "TRCS18", JdeDataType.String, 16),
        new JdeField("TRITM", "TRITM", JdeDataType.Numeric),
        new JdeField("TRIT18", "TRIT18", JdeDataType.String, 16),
        new JdeField("TRQTST", "TRQTST", JdeDataType.String, 50),
        new JdeField("TRMCU2", "TRMCU2", JdeDataType.String, 24),
        new JdeField("TRQSPC", "TRQSPC", JdeDataType.String, 50),
        new JdeField("TRHMCU", "TRHMCU", JdeDataType.String, 24),
        new JdeField("TRTSRT", "TRTSRT", JdeDataType.Numeric),
        new JdeField("TRQREV", "TRQREV", JdeDataType.String, 6),
        new JdeField("TRQVAL", "TRQVAL", JdeDataType.String, 30),
        new JdeField("TRQPF", "TRQPF", JdeDataType.String, 2),
        new JdeField("TRTOVR", "TRTOVR", JdeDataType.String, 2),
        new JdeField("TRMUSE", "TRMUSE", JdeDataType.String, 20),
        new JdeField("TRANO", "TRANO", JdeDataType.Numeric),
        new JdeField("TRQDAT", "TRQDAT", JdeDataType.Numeric),
        new JdeField("TRQTIM", "TRQTIM", JdeDataType.Numeric),
        new JdeField("TRQDSP", "TRQDSP", JdeDataType.String, 6),
        new JdeField("TRSNBR", "TRSNBR", JdeDataType.Numeric),
        new JdeField("TRQSMP", "TRQSMP", JdeDataType.Numeric),
        new JdeField("TRSMPC", "TRSMPC", JdeDataType.Numeric),
        new JdeField("TRACQT", "TRACQT", JdeDataType.Numeric),
        new JdeField("TRACPC", "TRACPC", JdeDataType.Numeric),
        new JdeField("TRSY", "TRSY", JdeDataType.String, 8),
        new JdeField("TRRT", "TRRT", JdeDataType.String, 4),
        new JdeField("TRAMIN", "TRAMIN", JdeDataType.String, 30),
        new JdeField("TRAMAX", "TRAMAX", JdeDataType.String, 30),
        new JdeField("TRPMIN", "TRPMIN", JdeDataType.String, 30),
        new JdeField("TRPMAX", "TRPMAX", JdeDataType.String, 30),
        new JdeField("TREFFF", "TREFFF", JdeDataType.Numeric),
        new JdeField("TREFFT", "TREFFT", JdeDataType.Numeric),
        new JdeField("TRQTRG", "TRQTRG", JdeDataType.String, 30),
        new JdeField("TRQSSZ", "TRQSSZ", JdeDataType.Numeric),
        new JdeField("TRQASZ", "TRQASZ", JdeDataType.Numeric),
        new JdeField("TRQUM", "TRQUM", JdeDataType.String, 6),
        new JdeField("TRPTTS", "TRPTTS", JdeDataType.String, 2),
        new JdeField("TRQTC1", "TRQTC1", JdeDataType.String, 6),
        new JdeField("TRQTC2", "TRQTC2", JdeDataType.String, 6),
        new JdeField("TRQTC3", "TRQTC3", JdeDataType.String, 6),
        new JdeField("TRQTC4", "TRQTC4", JdeDataType.String, 6),
        new JdeField("TRQTC5", "TRQTC5", JdeDataType.String, 6),
        new JdeField("TRTTTY", "TRTTTY", JdeDataType.String, 2),
        new JdeField("TRMFGR", "TRMFGR", JdeDataType.String, 2),
        new JdeField("TRMRRR", "TRMRRR", JdeDataType.String, 2),
        new JdeField("TRMFGC", "TRMFGC", JdeDataType.String, 2),
        new JdeField("TRPRCR", "TRPRCR", JdeDataType.String, 2),
        new JdeField("TRPRER", "TRPRER", JdeDataType.String, 2),
        new JdeField("TRSHPR", "TRSHPR", JdeDataType.String, 2),
        new JdeField("TRBLKR", "TRBLKR", JdeDataType.String, 2),
        new JdeField("TROPSQ", "TROPSQ", JdeDataType.Numeric),
        new JdeField("TROPRS", "TROPRS", JdeDataType.Numeric),
        new JdeField("TRBSEQ", "TRBSEQ", JdeDataType.Numeric),
        new JdeField("TRTRT", "TRTRT", JdeDataType.String, 6),
        new JdeField("TRTRP", "TRTRP", JdeDataType.Numeric),
        new JdeField("TRTRPL", "TRTRPL", JdeDataType.Numeric),
        new JdeField("TRLCMP", "TRLCMP", JdeDataType.Numeric),
        new JdeField("TRVEHI", "TRVEHI", JdeDataType.String, 24),
        new JdeField("TRRSQQ", "TRRSQQ", JdeDataType.Numeric),
        new JdeField("TRTTST", "TRTTST", JdeDataType.String, 2),
        new JdeField("TRDFCW", "TRDFCW", JdeDataType.String, 2),
        new JdeField("TRQPCD", "TRQPCD", JdeDataType.String, 4),
        new JdeField("TRQTID", "TRQTID", JdeDataType.Numeric),
        new JdeField("TRTMHD", "TRTMHD", JdeDataType.String, 60),
        new JdeField("TRRSUM", "TRRSUM", JdeDataType.String, 6),
        new JdeField("TRNUMB", "TRNUMB", JdeDataType.Numeric),
        new JdeField("TRASTM", "TRASTM", JdeDataType.String, 60),
        new JdeField("TRQPRP", "TRQPRP", JdeDataType.String, 20),
        new JdeField("TRQDFC", "TRQDFC", JdeDataType.String, 6),
        new JdeField("TRQRTC", "TRQRTC", JdeDataType.String, 6),
        new JdeField("TRMMCU", "TRMMCU", JdeDataType.String, 24),
        new JdeField("TRCDEC", "TRCDEC", JdeDataType.String, 2),
        new JdeField("TRUKID", "TRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TRDERC", "TRDERC", JdeDataType.String, 160),
        new JdeField("TRURCD", "TRURCD", JdeDataType.String, 4),
        new JdeField("TRURDT", "TRURDT", JdeDataType.Numeric),
        new JdeField("TRURAT", "TRURAT", JdeDataType.Numeric),
        new JdeField("TRURRF", "TRURRF", JdeDataType.String, 30),
        new JdeField("TRURAB", "TRURAB", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRTDAY", "TRTDAY", JdeDataType.Numeric),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRWLOTN", "TRWLOTN", JdeDataType.String, 60),
        new JdeField("TRWOPID", "TRWOPID", JdeDataType.Numeric),
        new JdeField("TRRSEXPD", "TRRSEXPD", JdeDataType.Numeric),
        new JdeField("TRWVID", "TRWVID", JdeDataType.Numeric),
        new JdeField("TRWVTY", "TRWVTY", JdeDataType.String, 2),
        new JdeField("TRTSTRSNM", "TRTSTRSNM", JdeDataType.String, 60),
        new JdeField("TRRSSTS", "TRRSSTS", JdeDataType.String, 2),
        new JdeField("TRRSCONVID", "TRRSCONVID", JdeDataType.String, 60),
        new JdeField("TRFRMRSVAL", "TRFRMRSVAL", JdeDataType.String, 30),
        new JdeField("TRFRMRSUM", "TRFRMRSUM", JdeDataType.String, 6),
        new JdeField("TRQMRF3", "TRQMRF3", JdeDataType.String, 60),
        new JdeField("TRQMCD3", "TRQMCD3", JdeDataType.String, 6),
        new JdeField("TRQMAB3", "TRQMAB3", JdeDataType.Numeric),
        new JdeField("TRQMNUM3", "TRQMNUM3", JdeDataType.Numeric),
        new JdeField("TRQMDT3", "TRQMDT3", JdeDataType.Numeric),
        new JdeField("TRQABLRUL", "TRQABLRUL", JdeDataType.String, 10),
        new JdeField("TRCDEC2", "TRCDEC2", JdeDataType.String, 2),
        new JdeField("TRPRVQVAL", "TRPRVQVAL", JdeDataType.String, 30),
        new JdeField("TRPRVQDAT", "TRPRVQDAT", JdeDataType.Numeric),
        new JdeField("TRPRVRSNM", "TRPRVRSNM", JdeDataType.String, 30),
        new JdeField("TRNUMT", "TRNUMT", JdeDataType.String, 2),
        new JdeField("TRNUMT3", "TRNUMT3", JdeDataType.String, 2),
        new JdeField("TRPRVRSUM", "TRPRVRSUM", JdeDataType.String, 6),
        new JdeField("TRDLAB", "TRDLAB", JdeDataType.Numeric),
        new JdeField("TRMELC", "TRMELC", JdeDataType.String, 20),
        new JdeField("TRRNAMAX", "TRRNAMAX", JdeDataType.String, 30),
        new JdeField("TRRNAMIN", "TRRNAMIN", JdeDataType.String, 30),
        new JdeField("TRRNPMAX", "TRRNPMAX", JdeDataType.String, 30),
        new JdeField("TRRNPMIN", "TRRNPMIN", JdeDataType.String, 30),
        new JdeField("TRRNQTRG", "TRRNQTRG", JdeDataType.String, 30),
        new JdeField("TRBLUID", "TRBLUID", JdeDataType.Numeric),
        new JdeField("TRSBLUID", "TRSBLUID", JdeDataType.Numeric),
        new JdeField("TRSY1", "TRSY1", JdeDataType.String, 8),
        new JdeField("TRRT1", "TRRT1", JdeDataType.String, 4),
        new JdeField("TRTSTRTY", "TRTSTRTY", JdeDataType.String, 6),
        new JdeField("TRWVNUM", "TRWVNUM", JdeDataType.String, 60),
        new JdeField("TRSMPCNSL", "TRSMPCNSL", JdeDataType.String, 4),
        new JdeField("TRBSNBR", "TRBSNBR", JdeDataType.Numeric),
        new JdeField("TRWTBID", "TRWTBID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3711_0", "Primary Key on TRUKID", new[] { "TRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3711_11", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2" }),
        new JdeIndex("F3711_12", "Index on TRQTST, TRITM, TRMCU2, TRMCU, TRLOTN, TRLOCN, TRQPCD", new[] { "TRQTST", "TRITM", "TRMCU2", "TRMCU", "TRLOTN", "TRLOCN", "TRQPCD" }),
        new JdeIndex("F3711_13", "Index on TRDOCO, TRDCTO, TRKCOO, TRLNID, SYS_NC00135$, TRTSRT", new[] { "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "SYS_NC00135$", "TRTSRT" }),
        new JdeIndex("F3711_14", "Index on TRQTST, TRMCU2", new[] { "TRQTST", "TRMCU2" }),
        new JdeIndex("F3711_15", "Index on TRMCU, TRITM, TRQTST, TRMCU2, TRLOTN, TRLOCN, TRDCTO, TRDOCO", new[] { "TRMCU", "TRITM", "TRQTST", "TRMCU2", "TRLOTN", "TRLOCN", "TRDCTO", "TRDOCO" }),
        new JdeIndex("F3711_16", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRTSRT, TRSNBR", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRTSRT", "TRSNBR" }),
        new JdeIndex("F3711_19", "Index on TRLOTN, TRLOCN, TRITM, TRMCU, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, SYS_NC00134$", new[] { "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "SYS_NC00134$" }),
        new JdeIndex("F3711_20", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, SYS_NC00134$", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "SYS_NC00134$" }),
        new JdeIndex("F3711_21", "Index on TRDOCO, TRDCTO, TRKCOO, TRLNID, TRLOTN, TRLOCN, TRMCU, TRITM, TRTRP, TRTRPL, TRLCMP, TRTSRT", new[] { "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRLOTN", "TRLOCN", "TRMCU", "TRITM", "TRTRP", "TRTRPL", "TRLCMP", "TRTSRT" }),
        new JdeIndex("F3711_22", "Index on TRMCU, TRWLOTN, TRTSTRSNM", new[] { "TRMCU", "TRWLOTN", "TRTSTRSNM" }),
        new JdeIndex("F3711_23", "Index on TRWOPID, TRMCU, TRWLOTN, TRTSTRSNM", new[] { "TRWOPID", "TRMCU", "TRWLOTN", "TRTSTRSNM" }),
        new JdeIndex("F3711_24", "Index on TRNUMB, TRMELC, TRQTST, TRTSRT, TRMCU2, TRQDAT, TRQTIM", new[] { "TRNUMB", "TRMELC", "TRQTST", "TRTSRT", "TRMCU2", "TRQDAT", "TRQTIM" }),
        new JdeIndex("F3711_25", "Index on TRBSNBR", new[] { "TRBSNBR" }),
        new JdeIndex("F3711_26", "Index on TRWTBID, TRMCU, TRWLOTN, TRTSTRSNM", new[] { "TRWTBID", "TRMCU", "TRWLOTN", "TRTSTRSNM" }),
        new JdeIndex("F3711_4", "Index on TRDOCO, TRDCTO, TRKCOO, TRLNID, TRLOTN, TRLOCN, TRITM, TRMCU, TRSNBR, TRTSRT", new[] { "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRSNBR", "TRTSRT" }),
        new JdeIndex("F3711_7", "Index on TRLOTN, TRLOCN, TRITM, TRMCU, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2", new[] { "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2" }),
        new JdeIndex("F3711_8", "Index on TRDOCO, TRDCTO, TRKCOO, TRLNID, TRLOTN, TRLOCN, TRITM, TRMCU, TRTSRT, TRSNBR", new[] { "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRTSRT", "TRSNBR" }),
        new JdeIndex("F3711_9", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRSNBR, TRTSRT", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRSNBR", "TRTSRT" })
    };
}
