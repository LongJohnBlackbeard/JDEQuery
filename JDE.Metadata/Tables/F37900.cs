using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37900 - .
/// </summary>
public class F37900 : JdeTable
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
        /// TRLOTN.
        /// </summary>
        public const string TRLOTN = "TRLOTN";

        /// <summary>
        /// TRLOCN.
        /// </summary>
        public const string TRLOCN = "TRLOCN";

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
        /// TRVMCU.
        /// </summary>
        public const string TRVMCU = "TRVMCU";

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
        /// TRDOC.
        /// </summary>
        public const string TRDOC = "TRDOC";

        /// <summary>
        /// TRPPDJ.
        /// </summary>
        public const string TRPPDJ = "TRPPDJ";

        /// <summary>
        /// TRSOQS.
        /// </summary>
        public const string TRSOQS = "TRSOQS";

        /// <summary>
        /// TRUOM.
        /// </summary>
        public const string TRUOM = "TRUOM";

        /// <summary>
        /// TRDRQJ.
        /// </summary>
        public const string TRDRQJ = "TRDRQJ";

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
        /// TRUKID.
        /// </summary>
        public const string TRUKID = "TRUKID";

        /// <summary>
        /// TRRSEXPD.
        /// </summary>
        public const string TRRSEXPD = "TRRSEXPD";

        /// <summary>
        /// TRTSTRSNM.
        /// </summary>
        public const string TRTSTRSNM = "TRTSTRSNM";

        /// <summary>
        /// TRRSSTS.
        /// </summary>
        public const string TRRSSTS = "TRRSSTS";

        /// <summary>
        /// TRWLOTN.
        /// </summary>
        public const string TRWLOTN = "TRWLOTN";

        /// <summary>
        /// TRWBID.
        /// </summary>
        public const string TRWBID = "TRWBID";

        /// <summary>
        /// TRWOPID.
        /// </summary>
        public const string TRWOPID = "TRWOPID";

        /// <summary>
        /// TRWVID.
        /// </summary>
        public const string TRWVID = "TRWVID";

        /// <summary>
        /// TRWVTY.
        /// </summary>
        public const string TRWVTY = "TRWVTY";

        /// <summary>
        /// TRWSVT.
        /// </summary>
        public const string TRWSVT = "TRWSVT";

        /// <summary>
        /// TRWVNUM.
        /// </summary>
        public const string TRWVNUM = "TRWVNUM";

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
        /// TRALPH.
        /// </summary>
        public const string TRALPH = "TRALPH";

        /// <summary>
        /// TRLOTG.
        /// </summary>
        public const string TRLOTG = "TRLOTG";

        /// <summary>
        /// TRLOTP.
        /// </summary>
        public const string TRLOTP = "TRLOTP";

        /// <summary>
        /// TRMMEJ.
        /// </summary>
        public const string TRMMEJ = "TRMMEJ";

        /// <summary>
        /// TRBBDJ.
        /// </summary>
        public const string TRBBDJ = "TRBBDJ";

        /// <summary>
        /// TRSBDJ.
        /// </summary>
        public const string TRSBDJ = "TRSBDJ";

        /// <summary>
        /// TRDLEJ.
        /// </summary>
        public const string TRDLEJ = "TRDLEJ";

        /// <summary>
        /// TRU1DJ.
        /// </summary>
        public const string TRU1DJ = "TRU1DJ";

        /// <summary>
        /// TRU2DJ.
        /// </summary>
        public const string TRU2DJ = "TRU2DJ";

        /// <summary>
        /// TRU3DJ.
        /// </summary>
        public const string TRU3DJ = "TRU3DJ";

        /// <summary>
        /// TRU4DJ.
        /// </summary>
        public const string TRU4DJ = "TRU4DJ";

        /// <summary>
        /// TRU5DJ.
        /// </summary>
        public const string TRU5DJ = "TRU5DJ";

        /// <summary>
        /// TRORIG.
        /// </summary>
        public const string TRORIG = "TRORIG";

        /// <summary>
        /// TRCT1.
        /// </summary>
        public const string TRCT1 = "TRCT1";

        /// <summary>
        /// TRLOT1.
        /// </summary>
        public const string TRLOT1 = "TRLOT1";

        /// <summary>
        /// TRLOT2.
        /// </summary>
        public const string TRLOT2 = "TRLOT2";

        /// <summary>
        /// TRLOT3.
        /// </summary>
        public const string TRLOT3 = "TRLOT3";
    }

    /// <inheritdoc />
    public override string TableName => "F37900";

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
        new JdeField("TRLOTN", "TRLOTN", JdeDataType.String, 60),
        new JdeField("TRLOCN", "TRLOCN", JdeDataType.String, 40),
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
        new JdeField("TRVMCU", "TRVMCU", JdeDataType.String, 24),
        new JdeField("TRRSQQ", "TRRSQQ", JdeDataType.Numeric),
        new JdeField("TRTTST", "TRTTST", JdeDataType.String, 2),
        new JdeField("TRDFCW", "TRDFCW", JdeDataType.String, 2),
        new JdeField("TRQPCD", "TRQPCD", JdeDataType.String, 4),
        new JdeField("TRDOC", "TRDOC", JdeDataType.Numeric),
        new JdeField("TRPPDJ", "TRPPDJ", JdeDataType.Numeric),
        new JdeField("TRSOQS", "TRSOQS", JdeDataType.Numeric),
        new JdeField("TRUOM", "TRUOM", JdeDataType.String, 4),
        new JdeField("TRDRQJ", "TRDRQJ", JdeDataType.Numeric),
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
        new JdeField("TRUKID", "TRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TRRSEXPD", "TRRSEXPD", JdeDataType.Numeric),
        new JdeField("TRTSTRSNM", "TRTSTRSNM", JdeDataType.String, 60),
        new JdeField("TRRSSTS", "TRRSSTS", JdeDataType.String, 2),
        new JdeField("TRWLOTN", "TRWLOTN", JdeDataType.String, 60),
        new JdeField("TRWBID", "TRWBID", JdeDataType.String, 60),
        new JdeField("TRWOPID", "TRWOPID", JdeDataType.Numeric),
        new JdeField("TRWVID", "TRWVID", JdeDataType.Numeric),
        new JdeField("TRWVTY", "TRWVTY", JdeDataType.String, 2),
        new JdeField("TRWSVT", "TRWSVT", JdeDataType.String, 8),
        new JdeField("TRWVNUM", "TRWVNUM", JdeDataType.String, 60),
        new JdeField("TRRSCONVID", "TRRSCONVID", JdeDataType.String, 60),
        new JdeField("TRFRMRSVAL", "TRFRMRSVAL", JdeDataType.String, 30),
        new JdeField("TRFRMRSUM", "TRFRMRSUM", JdeDataType.String, 6),
        new JdeField("TRALPH", "TRALPH", JdeDataType.String, 80),
        new JdeField("TRLOTG", "TRLOTG", JdeDataType.String, 6),
        new JdeField("TRLOTP", "TRLOTP", JdeDataType.Numeric),
        new JdeField("TRMMEJ", "TRMMEJ", JdeDataType.Numeric),
        new JdeField("TRBBDJ", "TRBBDJ", JdeDataType.Numeric),
        new JdeField("TRSBDJ", "TRSBDJ", JdeDataType.Numeric),
        new JdeField("TRDLEJ", "TRDLEJ", JdeDataType.Numeric),
        new JdeField("TRU1DJ", "TRU1DJ", JdeDataType.Numeric),
        new JdeField("TRU2DJ", "TRU2DJ", JdeDataType.Numeric),
        new JdeField("TRU3DJ", "TRU3DJ", JdeDataType.Numeric),
        new JdeField("TRU4DJ", "TRU4DJ", JdeDataType.Numeric),
        new JdeField("TRU5DJ", "TRU5DJ", JdeDataType.Numeric),
        new JdeField("TRORIG", "TRORIG", JdeDataType.String, 6),
        new JdeField("TRCT1", "TRCT1", JdeDataType.String, 60),
        new JdeField("TRLOT1", "TRLOT1", JdeDataType.String, 60),
        new JdeField("TRLOT2", "TRLOT2", JdeDataType.String, 60),
        new JdeField("TRLOT3", "TRLOT3", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37900_0", "Primary Key on TRUKID", new[] { "TRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F37900_1", "Index on TRDOCO, TRDCTO, TRKCOO, TRLNID, TRITM, TRMCU, TRLOTN, TRLOCN, TRQTST, TRMCU2", new[] { "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRITM", "TRMCU", "TRLOTN", "TRLOCN", "TRQTST", "TRMCU2" }),
        new JdeIndex("F37900_10", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2" }),
        new JdeIndex("F37900_11", "Index on TRLOTN, TRLOCN, TRITM, TRMCU, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2, SYS_NC00131$", new[] { "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2", "SYS_NC00131$" }),
        new JdeIndex("F37900_12", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2, SYS_NC00131$", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2", "SYS_NC00131$" }),
        new JdeIndex("F37900_2", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRQTST, TRMCU2", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRQTST", "TRMCU2" }),
        new JdeIndex("F37900_4", "Index on TRRORN", new[] { "TRRORN" }),
        new JdeIndex("F37900_6", "Index on TRLOTN, TRLOCN, TRITM, TRMCU, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2, SYS_NC00132$", new[] { "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2", "SYS_NC00132$" }),
        new JdeIndex("F37900_7", "Index on TRTRP, TRTRPL, TRMCU, TRLCMP, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2, SYS_NC00132$", new[] { "TRTRP", "TRTRPL", "TRMCU", "TRLCMP", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2", "SYS_NC00132$" }),
        new JdeIndex("F37900_8", "Index on SYS_NC00133$", new[] { "SYS_NC00133$" }),
        new JdeIndex("F37900_9", "Index on TRLOTN, TRLOCN, TRITM, TRMCU, TRDOCO, TRDCTO, TRKCOO, TRLNID, TRQTST, TRMCU2", new[] { "TRLOTN", "TRLOCN", "TRITM", "TRMCU", "TRDOCO", "TRDCTO", "TRKCOO", "TRLNID", "TRQTST", "TRMCU2" })
    };
}
