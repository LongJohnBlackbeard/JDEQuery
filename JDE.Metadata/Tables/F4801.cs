using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801 - .
/// </summary>
public class F4801 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WADCTO.
        /// </summary>
        public const string WADCTO = "WADCTO";

        /// <summary>
        /// WADOCO.
        /// </summary>
        public const string WADOCO = "WADOCO";

        /// <summary>
        /// WASFXO.
        /// </summary>
        public const string WASFXO = "WASFXO";

        /// <summary>
        /// WARCTO.
        /// </summary>
        public const string WARCTO = "WARCTO";

        /// <summary>
        /// WARORN.
        /// </summary>
        public const string WARORN = "WARORN";

        /// <summary>
        /// WALNID.
        /// </summary>
        public const string WALNID = "WALNID";

        /// <summary>
        /// WAPTWO.
        /// </summary>
        public const string WAPTWO = "WAPTWO";

        /// <summary>
        /// WAPARS.
        /// </summary>
        public const string WAPARS = "WAPARS";

        /// <summary>
        /// WATYPS.
        /// </summary>
        public const string WATYPS = "WATYPS";

        /// <summary>
        /// WAPRTS.
        /// </summary>
        public const string WAPRTS = "WAPRTS";

        /// <summary>
        /// WADL01.
        /// </summary>
        public const string WADL01 = "WADL01";

        /// <summary>
        /// WASTCM.
        /// </summary>
        public const string WASTCM = "WASTCM";

        /// <summary>
        /// WACO.
        /// </summary>
        public const string WACO = "WACO";

        /// <summary>
        /// WAMCU.
        /// </summary>
        public const string WAMCU = "WAMCU";

        /// <summary>
        /// WAMMCU.
        /// </summary>
        public const string WAMMCU = "WAMMCU";

        /// <summary>
        /// WALOCN.
        /// </summary>
        public const string WALOCN = "WALOCN";

        /// <summary>
        /// WAAISL.
        /// </summary>
        public const string WAAISL = "WAAISL";

        /// <summary>
        /// WABIN.
        /// </summary>
        public const string WABIN = "WABIN";

        /// <summary>
        /// WASRST.
        /// </summary>
        public const string WASRST = "WASRST";

        /// <summary>
        /// WADCG.
        /// </summary>
        public const string WADCG = "WADCG";

        /// <summary>
        /// WASUB.
        /// </summary>
        public const string WASUB = "WASUB";

        /// <summary>
        /// WAAN8.
        /// </summary>
        public const string WAAN8 = "WAAN8";

        /// <summary>
        /// WAANO.
        /// </summary>
        public const string WAANO = "WAANO";

        /// <summary>
        /// WAANSA.
        /// </summary>
        public const string WAANSA = "WAANSA";

        /// <summary>
        /// WAANPA.
        /// </summary>
        public const string WAANPA = "WAANPA";

        /// <summary>
        /// WAANP.
        /// </summary>
        public const string WAANP = "WAANP";

        /// <summary>
        /// WADPL.
        /// </summary>
        public const string WADPL = "WADPL";

        /// <summary>
        /// WAANT.
        /// </summary>
        public const string WAANT = "WAANT";

        /// <summary>
        /// WANAN8.
        /// </summary>
        public const string WANAN8 = "WANAN8";

        /// <summary>
        /// WATRDJ.
        /// </summary>
        public const string WATRDJ = "WATRDJ";

        /// <summary>
        /// WASTRT.
        /// </summary>
        public const string WASTRT = "WASTRT";

        /// <summary>
        /// WADRQJ.
        /// </summary>
        public const string WADRQJ = "WADRQJ";

        /// <summary>
        /// WASTRX.
        /// </summary>
        public const string WASTRX = "WASTRX";

        /// <summary>
        /// WADAP.
        /// </summary>
        public const string WADAP = "WADAP";

        /// <summary>
        /// WADAT.
        /// </summary>
        public const string WADAT = "WADAT";

        /// <summary>
        /// WAPPDT.
        /// </summary>
        public const string WAPPDT = "WAPPDT";

        /// <summary>
        /// WAWR01.
        /// </summary>
        public const string WAWR01 = "WAWR01";

        /// <summary>
        /// WAWR02.
        /// </summary>
        public const string WAWR02 = "WAWR02";

        /// <summary>
        /// WAWR03.
        /// </summary>
        public const string WAWR03 = "WAWR03";

        /// <summary>
        /// WAWR04.
        /// </summary>
        public const string WAWR04 = "WAWR04";

        /// <summary>
        /// WAWR05.
        /// </summary>
        public const string WAWR05 = "WAWR05";

        /// <summary>
        /// WAWR06.
        /// </summary>
        public const string WAWR06 = "WAWR06";

        /// <summary>
        /// WAWR07.
        /// </summary>
        public const string WAWR07 = "WAWR07";

        /// <summary>
        /// WAWR08.
        /// </summary>
        public const string WAWR08 = "WAWR08";

        /// <summary>
        /// WAWR09.
        /// </summary>
        public const string WAWR09 = "WAWR09";

        /// <summary>
        /// WAWR10.
        /// </summary>
        public const string WAWR10 = "WAWR10";

        /// <summary>
        /// WAVR01.
        /// </summary>
        public const string WAVR01 = "WAVR01";

        /// <summary>
        /// WAVR02.
        /// </summary>
        public const string WAVR02 = "WAVR02";

        /// <summary>
        /// WAAMTO.
        /// </summary>
        public const string WAAMTO = "WAAMTO";

        /// <summary>
        /// WASETC.
        /// </summary>
        public const string WASETC = "WASETC";

        /// <summary>
        /// WABRT.
        /// </summary>
        public const string WABRT = "WABRT";

        /// <summary>
        /// WAPAYT.
        /// </summary>
        public const string WAPAYT = "WAPAYT";

        /// <summary>
        /// WAAMTC.
        /// </summary>
        public const string WAAMTC = "WAAMTC";

        /// <summary>
        /// WAHRSO.
        /// </summary>
        public const string WAHRSO = "WAHRSO";

        /// <summary>
        /// WAHRSC.
        /// </summary>
        public const string WAHRSC = "WAHRSC";

        /// <summary>
        /// WAAMTA.
        /// </summary>
        public const string WAAMTA = "WAAMTA";

        /// <summary>
        /// WAHRSA.
        /// </summary>
        public const string WAHRSA = "WAHRSA";

        /// <summary>
        /// WAITM.
        /// </summary>
        public const string WAITM = "WAITM";

        /// <summary>
        /// WAAITM.
        /// </summary>
        public const string WAAITM = "WAAITM";

        /// <summary>
        /// WALITM.
        /// </summary>
        public const string WALITM = "WALITM";

        /// <summary>
        /// WANUMB.
        /// </summary>
        public const string WANUMB = "WANUMB";

        /// <summary>
        /// WAAPID.
        /// </summary>
        public const string WAAPID = "WAAPID";

        /// <summary>
        /// WAUORG.
        /// </summary>
        public const string WAUORG = "WAUORG";

        /// <summary>
        /// WASOBK.
        /// </summary>
        public const string WASOBK = "WASOBK";

        /// <summary>
        /// WASOCN.
        /// </summary>
        public const string WASOCN = "WASOCN";

        /// <summary>
        /// WASOQS.
        /// </summary>
        public const string WASOQS = "WASOQS";

        /// <summary>
        /// WAQTYT.
        /// </summary>
        public const string WAQTYT = "WAQTYT";

        /// <summary>
        /// WAUOM.
        /// </summary>
        public const string WAUOM = "WAUOM";

        /// <summary>
        /// WASHNO.
        /// </summary>
        public const string WASHNO = "WASHNO";

        /// <summary>
        /// WAPBTM.
        /// </summary>
        public const string WAPBTM = "WAPBTM";

        /// <summary>
        /// WATBM.
        /// </summary>
        public const string WATBM = "WATBM";

        /// <summary>
        /// WATRT.
        /// </summary>
        public const string WATRT = "WATRT";

        /// <summary>
        /// WASHTY.
        /// </summary>
        public const string WASHTY = "WASHTY";

        /// <summary>
        /// WAPEC.
        /// </summary>
        public const string WAPEC = "WAPEC";

        /// <summary>
        /// WAPPFG.
        /// </summary>
        public const string WAPPFG = "WAPPFG";

        /// <summary>
        /// WABM.
        /// </summary>
        public const string WABM = "WABM";

        /// <summary>
        /// WARTG.
        /// </summary>
        public const string WARTG = "WARTG";

        /// <summary>
        /// WASPRT.
        /// </summary>
        public const string WASPRT = "WASPRT";

        /// <summary>
        /// WAUNCD.
        /// </summary>
        public const string WAUNCD = "WAUNCD";

        /// <summary>
        /// WAINDC.
        /// </summary>
        public const string WAINDC = "WAINDC";

        /// <summary>
        /// WARESC.
        /// </summary>
        public const string WARESC = "WARESC";

        /// <summary>
        /// WAMOH.
        /// </summary>
        public const string WAMOH = "WAMOH";

        /// <summary>
        /// WATDT.
        /// </summary>
        public const string WATDT = "WATDT";

        /// <summary>
        /// WAPOU.
        /// </summary>
        public const string WAPOU = "WAPOU";

        /// <summary>
        /// WAPC.
        /// </summary>
        public const string WAPC = "WAPC";

        /// <summary>
        /// WALTLV.
        /// </summary>
        public const string WALTLV = "WALTLV";

        /// <summary>
        /// WALTCM.
        /// </summary>
        public const string WALTCM = "WALTCM";

        /// <summary>
        /// WACTS1.
        /// </summary>
        public const string WACTS1 = "WACTS1";

        /// <summary>
        /// WALOTN.
        /// </summary>
        public const string WALOTN = "WALOTN";

        /// <summary>
        /// WALOTP.
        /// </summary>
        public const string WALOTP = "WALOTP";

        /// <summary>
        /// WALOTG.
        /// </summary>
        public const string WALOTG = "WALOTG";

        /// <summary>
        /// WARAT1.
        /// </summary>
        public const string WARAT1 = "WARAT1";

        /// <summary>
        /// WARAT2.
        /// </summary>
        public const string WARAT2 = "WARAT2";

        /// <summary>
        /// WADCT.
        /// </summary>
        public const string WADCT = "WADCT";

        /// <summary>
        /// WASBLI.
        /// </summary>
        public const string WASBLI = "WASBLI";

        /// <summary>
        /// WARKCO.
        /// </summary>
        public const string WARKCO = "WARKCO";

        /// <summary>
        /// WABREV.
        /// </summary>
        public const string WABREV = "WABREV";

        /// <summary>
        /// WARREV.
        /// </summary>
        public const string WARREV = "WARREV";

        /// <summary>
        /// WADRWC.
        /// </summary>
        public const string WADRWC = "WADRWC";

        /// <summary>
        /// WARTCH.
        /// </summary>
        public const string WARTCH = "WARTCH";

        /// <summary>
        /// WAPNRQ.
        /// </summary>
        public const string WAPNRQ = "WAPNRQ";

        /// <summary>
        /// WAREAS.
        /// </summary>
        public const string WAREAS = "WAREAS";

        /// <summary>
        /// WAPHSE.
        /// </summary>
        public const string WAPHSE = "WAPHSE";

        /// <summary>
        /// WAXDSP.
        /// </summary>
        public const string WAXDSP = "WAXDSP";

        /// <summary>
        /// WABOMC.
        /// </summary>
        public const string WABOMC = "WABOMC";

        /// <summary>
        /// WAURCD.
        /// </summary>
        public const string WAURCD = "WAURCD";

        /// <summary>
        /// WAURDT.
        /// </summary>
        public const string WAURDT = "WAURDT";

        /// <summary>
        /// WAURAT.
        /// </summary>
        public const string WAURAT = "WAURAT";

        /// <summary>
        /// WAURAB.
        /// </summary>
        public const string WAURAB = "WAURAB";

        /// <summary>
        /// WAURRF.
        /// </summary>
        public const string WAURRF = "WAURRF";

        /// <summary>
        /// WAUSER.
        /// </summary>
        public const string WAUSER = "WAUSER";

        /// <summary>
        /// WAPID.
        /// </summary>
        public const string WAPID = "WAPID";

        /// <summary>
        /// WAJOBN.
        /// </summary>
        public const string WAJOBN = "WAJOBN";

        /// <summary>
        /// WAUPMJ.
        /// </summary>
        public const string WAUPMJ = "WAUPMJ";

        /// <summary>
        /// WATDAY.
        /// </summary>
        public const string WATDAY = "WATDAY";

        /// <summary>
        /// WAAAID.
        /// </summary>
        public const string WAAAID = "WAAAID";

        /// <summary>
        /// WANTST.
        /// </summary>
        public const string WANTST = "WANTST";

        /// <summary>
        /// WAXRTO.
        /// </summary>
        public const string WAXRTO = "WAXRTO";

        /// <summary>
        /// WAESDN.
        /// </summary>
        public const string WAESDN = "WAESDN";

        /// <summary>
        /// WAACDN.
        /// </summary>
        public const string WAACDN = "WAACDN";

        /// <summary>
        /// WASAID.
        /// </summary>
        public const string WASAID = "WASAID";

        /// <summary>
        /// WAMPOS.
        /// </summary>
        public const string WAMPOS = "WAMPOS";

        /// <summary>
        /// WAAPRT.
        /// </summary>
        public const string WAAPRT = "WAAPRT";

        /// <summary>
        /// WAAMLC.
        /// </summary>
        public const string WAAMLC = "WAAMLC";

        /// <summary>
        /// WAAMMC.
        /// </summary>
        public const string WAAMMC = "WAAMMC";

        /// <summary>
        /// WAAMOT.
        /// </summary>
        public const string WAAMOT = "WAAMOT";

        /// <summary>
        /// WALBAM.
        /// </summary>
        public const string WALBAM = "WALBAM";

        /// <summary>
        /// WAMTAM.
        /// </summary>
        public const string WAMTAM = "WAMTAM";
    }

    /// <inheritdoc />
    public override string TableName => "F4801";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WADCTO", "WADCTO", JdeDataType.String, 4),
        new JdeField("WADOCO", "WADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WASFXO", "WASFXO", JdeDataType.String, 6),
        new JdeField("WARCTO", "WARCTO", JdeDataType.String, 4),
        new JdeField("WARORN", "WARORN", JdeDataType.String, 16),
        new JdeField("WALNID", "WALNID", JdeDataType.Numeric),
        new JdeField("WAPTWO", "WAPTWO", JdeDataType.Numeric),
        new JdeField("WAPARS", "WAPARS", JdeDataType.String, 16),
        new JdeField("WATYPS", "WATYPS", JdeDataType.String, 2),
        new JdeField("WAPRTS", "WAPRTS", JdeDataType.String, 2),
        new JdeField("WADL01", "WADL01", JdeDataType.String, 60),
        new JdeField("WASTCM", "WASTCM", JdeDataType.String, 60),
        new JdeField("WACO", "WACO", JdeDataType.String, 10),
        new JdeField("WAMCU", "WAMCU", JdeDataType.String, 24),
        new JdeField("WAMMCU", "WAMMCU", JdeDataType.String, 24),
        new JdeField("WALOCN", "WALOCN", JdeDataType.String, 40),
        new JdeField("WAAISL", "WAAISL", JdeDataType.String, 16),
        new JdeField("WABIN", "WABIN", JdeDataType.String, 16),
        new JdeField("WASRST", "WASRST", JdeDataType.String, 4),
        new JdeField("WADCG", "WADCG", JdeDataType.Numeric),
        new JdeField("WASUB", "WASUB", JdeDataType.String, 16),
        new JdeField("WAAN8", "WAAN8", JdeDataType.Numeric),
        new JdeField("WAANO", "WAANO", JdeDataType.Numeric),
        new JdeField("WAANSA", "WAANSA", JdeDataType.Numeric),
        new JdeField("WAANPA", "WAANPA", JdeDataType.Numeric),
        new JdeField("WAANP", "WAANP", JdeDataType.Numeric),
        new JdeField("WADPL", "WADPL", JdeDataType.Numeric),
        new JdeField("WAANT", "WAANT", JdeDataType.Numeric),
        new JdeField("WANAN8", "WANAN8", JdeDataType.Numeric),
        new JdeField("WATRDJ", "WATRDJ", JdeDataType.Numeric),
        new JdeField("WASTRT", "WASTRT", JdeDataType.Numeric),
        new JdeField("WADRQJ", "WADRQJ", JdeDataType.Numeric),
        new JdeField("WASTRX", "WASTRX", JdeDataType.Numeric),
        new JdeField("WADAP", "WADAP", JdeDataType.Numeric),
        new JdeField("WADAT", "WADAT", JdeDataType.Numeric),
        new JdeField("WAPPDT", "WAPPDT", JdeDataType.Numeric),
        new JdeField("WAWR01", "WAWR01", JdeDataType.String, 8),
        new JdeField("WAWR02", "WAWR02", JdeDataType.String, 6),
        new JdeField("WAWR03", "WAWR03", JdeDataType.String, 6),
        new JdeField("WAWR04", "WAWR04", JdeDataType.String, 6),
        new JdeField("WAWR05", "WAWR05", JdeDataType.String, 6),
        new JdeField("WAWR06", "WAWR06", JdeDataType.String, 6),
        new JdeField("WAWR07", "WAWR07", JdeDataType.String, 6),
        new JdeField("WAWR08", "WAWR08", JdeDataType.String, 6),
        new JdeField("WAWR09", "WAWR09", JdeDataType.String, 6),
        new JdeField("WAWR10", "WAWR10", JdeDataType.String, 6),
        new JdeField("WAVR01", "WAVR01", JdeDataType.String, 50),
        new JdeField("WAVR02", "WAVR02", JdeDataType.String, 50),
        new JdeField("WAAMTO", "WAAMTO", JdeDataType.Numeric),
        new JdeField("WASETC", "WASETC", JdeDataType.Numeric),
        new JdeField("WABRT", "WABRT", JdeDataType.Numeric),
        new JdeField("WAPAYT", "WAPAYT", JdeDataType.String, 10),
        new JdeField("WAAMTC", "WAAMTC", JdeDataType.Numeric),
        new JdeField("WAHRSO", "WAHRSO", JdeDataType.Numeric),
        new JdeField("WAHRSC", "WAHRSC", JdeDataType.Numeric),
        new JdeField("WAAMTA", "WAAMTA", JdeDataType.Numeric),
        new JdeField("WAHRSA", "WAHRSA", JdeDataType.Numeric),
        new JdeField("WAITM", "WAITM", JdeDataType.Numeric),
        new JdeField("WAAITM", "WAAITM", JdeDataType.String, 50),
        new JdeField("WALITM", "WALITM", JdeDataType.String, 50),
        new JdeField("WANUMB", "WANUMB", JdeDataType.Numeric),
        new JdeField("WAAPID", "WAAPID", JdeDataType.String, 24),
        new JdeField("WAUORG", "WAUORG", JdeDataType.Numeric),
        new JdeField("WASOBK", "WASOBK", JdeDataType.Numeric),
        new JdeField("WASOCN", "WASOCN", JdeDataType.Numeric),
        new JdeField("WASOQS", "WASOQS", JdeDataType.Numeric),
        new JdeField("WAQTYT", "WAQTYT", JdeDataType.Numeric),
        new JdeField("WAUOM", "WAUOM", JdeDataType.String, 4),
        new JdeField("WASHNO", "WASHNO", JdeDataType.String, 20),
        new JdeField("WAPBTM", "WAPBTM", JdeDataType.Numeric),
        new JdeField("WATBM", "WATBM", JdeDataType.String, 6),
        new JdeField("WATRT", "WATRT", JdeDataType.String, 6),
        new JdeField("WASHTY", "WASHTY", JdeDataType.String, 2),
        new JdeField("WAPEC", "WAPEC", JdeDataType.String, 2),
        new JdeField("WAPPFG", "WAPPFG", JdeDataType.String, 2),
        new JdeField("WABM", "WABM", JdeDataType.String, 2),
        new JdeField("WARTG", "WARTG", JdeDataType.String, 2),
        new JdeField("WASPRT", "WASPRT", JdeDataType.String, 2),
        new JdeField("WAUNCD", "WAUNCD", JdeDataType.String, 2),
        new JdeField("WAINDC", "WAINDC", JdeDataType.String, 2),
        new JdeField("WARESC", "WARESC", JdeDataType.Numeric),
        new JdeField("WAMOH", "WAMOH", JdeDataType.Numeric),
        new JdeField("WATDT", "WATDT", JdeDataType.Numeric),
        new JdeField("WAPOU", "WAPOU", JdeDataType.Numeric),
        new JdeField("WAPC", "WAPC", JdeDataType.Numeric),
        new JdeField("WALTLV", "WALTLV", JdeDataType.Numeric),
        new JdeField("WALTCM", "WALTCM", JdeDataType.Numeric),
        new JdeField("WACTS1", "WACTS1", JdeDataType.Numeric),
        new JdeField("WALOTN", "WALOTN", JdeDataType.String, 60),
        new JdeField("WALOTP", "WALOTP", JdeDataType.Numeric),
        new JdeField("WALOTG", "WALOTG", JdeDataType.String, 6),
        new JdeField("WARAT1", "WARAT1", JdeDataType.Numeric),
        new JdeField("WARAT2", "WARAT2", JdeDataType.Numeric),
        new JdeField("WADCT", "WADCT", JdeDataType.String, 4),
        new JdeField("WASBLI", "WASBLI", JdeDataType.String, 2),
        new JdeField("WARKCO", "WARKCO", JdeDataType.String, 10),
        new JdeField("WABREV", "WABREV", JdeDataType.String, 6),
        new JdeField("WARREV", "WARREV", JdeDataType.String, 6),
        new JdeField("WADRWC", "WADRWC", JdeDataType.String, 2),
        new JdeField("WARTCH", "WARTCH", JdeDataType.String, 2),
        new JdeField("WAPNRQ", "WAPNRQ", JdeDataType.String, 2),
        new JdeField("WAREAS", "WAREAS", JdeDataType.String, 4),
        new JdeField("WAPHSE", "WAPHSE", JdeDataType.String, 6),
        new JdeField("WAXDSP", "WAXDSP", JdeDataType.String, 6),
        new JdeField("WABOMC", "WABOMC", JdeDataType.String, 2),
        new JdeField("WAURCD", "WAURCD", JdeDataType.String, 4),
        new JdeField("WAURDT", "WAURDT", JdeDataType.Numeric),
        new JdeField("WAURAT", "WAURAT", JdeDataType.Numeric),
        new JdeField("WAURAB", "WAURAB", JdeDataType.Numeric),
        new JdeField("WAURRF", "WAURRF", JdeDataType.String, 30),
        new JdeField("WAUSER", "WAUSER", JdeDataType.String, 20),
        new JdeField("WAPID", "WAPID", JdeDataType.String, 20),
        new JdeField("WAJOBN", "WAJOBN", JdeDataType.String, 20),
        new JdeField("WAUPMJ", "WAUPMJ", JdeDataType.Numeric),
        new JdeField("WATDAY", "WATDAY", JdeDataType.Numeric),
        new JdeField("WAAAID", "WAAAID", JdeDataType.Numeric),
        new JdeField("WANTST", "WANTST", JdeDataType.String, 4),
        new JdeField("WAXRTO", "WAXRTO", JdeDataType.Numeric),
        new JdeField("WAESDN", "WAESDN", JdeDataType.Numeric),
        new JdeField("WAACDN", "WAACDN", JdeDataType.Numeric),
        new JdeField("WASAID", "WASAID", JdeDataType.Numeric),
        new JdeField("WAMPOS", "WAMPOS", JdeDataType.Numeric),
        new JdeField("WAAPRT", "WAAPRT", JdeDataType.String, 6),
        new JdeField("WAAMLC", "WAAMLC", JdeDataType.Numeric),
        new JdeField("WAAMMC", "WAAMMC", JdeDataType.Numeric),
        new JdeField("WAAMOT", "WAAMOT", JdeDataType.Numeric),
        new JdeField("WALBAM", "WALBAM", JdeDataType.Numeric),
        new JdeField("WAMTAM", "WAMTAM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801_0", "Primary Key on WADOCO", new[] { "WADOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4801_10", "Index on WAANPA, WASRST, WADPL", new[] { "WAANPA", "WASRST", "WADPL" }),
        new JdeIndex("F4801_11", "Index on WAANSA, WASRST, WADPL", new[] { "WAANSA", "WASRST", "WADPL" }),
        new JdeIndex("F4801_12", "Index on WATRDJ, WADOCO", new[] { "WATRDJ", "WADOCO" }),
        new JdeIndex("F4801_13", "Index on WASTRX, WADOCO", new[] { "WASTRX", "WADOCO" }),
        new JdeIndex("F4801_14", "Index on WASTRT, WADOCO", new[] { "WASTRT", "WADOCO" }),
        new JdeIndex("F4801_15", "Index on WANUMB, WAWR01, WAWR02, WAWR03, WATYPS, WAPRTS, WADOCO", new[] { "WANUMB", "WAWR01", "WAWR02", "WAWR03", "WATYPS", "WAPRTS", "WADOCO" }),
        new JdeIndex("F4801_16", "Index on WAWR01", new[] { "WAWR01" }),
        new JdeIndex("F4801_17", "Index on WAWR02", new[] { "WAWR02" }),
        new JdeIndex("F4801_18", "Index on WAWR03", new[] { "WAWR03" }),
        new JdeIndex("F4801_19", "Index on WAWR04", new[] { "WAWR04" }),
        new JdeIndex("F4801_2", "Index on WAPARS, WAWR01, WAWR02, WAWR03, WATYPS, WAPRTS, WADOCO", new[] { "WAPARS", "WAWR01", "WAWR02", "WAWR03", "WATYPS", "WAPRTS", "WADOCO" }),
        new JdeIndex("F4801_20", "Index on WAWR05", new[] { "WAWR05" }),
        new JdeIndex("F4801_21", "Index on WAWR06", new[] { "WAWR06" }),
        new JdeIndex("F4801_22", "Index on WAWR07", new[] { "WAWR07" }),
        new JdeIndex("F4801_23", "Index on WAWR08", new[] { "WAWR08" }),
        new JdeIndex("F4801_24", "Index on WAWR09", new[] { "WAWR09" }),
        new JdeIndex("F4801_25", "Index on WAWR10", new[] { "WAWR10" }),
        new JdeIndex("F4801_29", "Index on WADOCO, WASRST, WASTRX", new[] { "WADOCO", "WASRST", "WASTRX" }),
        new JdeIndex("F4801_3", "Index on WAAN8", new[] { "WAAN8" }),
        new JdeIndex("F4801_30", "Index on WANUMB, WASRST, WATRDJ", new[] { "WANUMB", "WASRST", "WATRDJ" }),
        new JdeIndex("F4801_31", "Index on WAITM, WASRST, WATRDJ", new[] { "WAITM", "WASRST", "WATRDJ" }),
        new JdeIndex("F4801_32", "Index on WAAN8, WASRST, WATRDJ", new[] { "WAAN8", "WASRST", "WATRDJ" }),
        new JdeIndex("F4801_33", "Index on WADOCO, WASRST, WATRDJ", new[] { "WADOCO", "WASRST", "WATRDJ" }),
        new JdeIndex("F4801_34", "Index on WARORN, WARCTO, WARKCO", new[] { "WARORN", "WARCTO", "WARKCO" }),
        new JdeIndex("F4801_36", "Index on WAPTWO, WADOCO", new[] { "WAPTWO", "WADOCO" }),
        new JdeIndex("F4801_37", "Index on WAMMCU, WADOCO", new[] { "WAMMCU", "WADOCO" }),
        new JdeIndex("F4801_38", "Index on WAURAT, WACO", new[] { "WAURAT", "WACO" }),
        new JdeIndex("F4801_39", "Index on WALITM, WALNID", new[] { "WALITM", "WALNID" }),
        new JdeIndex("F4801_4", "Index on WAITM, WAMMCU, WADRQJ", new[] { "WAITM", "WAMMCU", "WADRQJ" }),
        new JdeIndex("F4801_40", "Index on WASRST", new[] { "WASRST" }),
        new JdeIndex("F4801_5", "Index on WADOCO, WADCTO", new[] { "WADOCO", "WADCTO" }),
        new JdeIndex("F4801_6", "Index on WAAN8, WAWR01, WADPL", new[] { "WAAN8", "WAWR01", "WADPL" }),
        new JdeIndex("F4801_7", "Index on WAVR01, WASRST, WADPL", new[] { "WAVR01", "WASRST", "WADPL" }),
        new JdeIndex("F4801_8", "Index on WAANO, WASRST, WADPL", new[] { "WAANO", "WASRST", "WADPL" }),
        new JdeIndex("F4801_9", "Index on WAMCU, WAWR01, WADPL", new[] { "WAMCU", "WAWR01", "WADPL" })
    };
}
