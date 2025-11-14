using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T004 - .
/// </summary>
public class F75T004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TH75TTNF.
        /// </summary>
        public const string TH75TTNF = "TH75TTNF";

        /// <summary>
        /// TH75TRAS.
        /// </summary>
        public const string TH75TRAS = "TH75TRAS";

        /// <summary>
        /// THCO.
        /// </summary>
        public const string THCO = "THCO";

        /// <summary>
        /// TH75TDSI.
        /// </summary>
        public const string TH75TDSI = "TH75TDSI";

        /// <summary>
        /// TH75TAUC.
        /// </summary>
        public const string TH75TAUC = "TH75TAUC";

        /// <summary>
        /// TH75TYMD.
        /// </summary>
        public const string TH75TYMD = "TH75TYMD";

        /// <summary>
        /// TH75TVTT.
        /// </summary>
        public const string TH75TVTT = "TH75TVTT";

        /// <summary>
        /// TH75TDCT.
        /// </summary>
        public const string TH75TDCT = "TH75TDCT";

        /// <summary>
        /// THICU.
        /// </summary>
        public const string THICU = "THICU";

        /// <summary>
        /// THTRDJ.
        /// </summary>
        public const string THTRDJ = "THTRDJ";

        /// <summary>
        /// THDGJ.
        /// </summary>
        public const string THDGJ = "THDGJ";

        /// <summary>
        /// TH75TYMH.
        /// </summary>
        public const string TH75TYMH = "TH75TYMH";

        /// <summary>
        /// TH75TGFC.
        /// </summary>
        public const string TH75TGFC = "TH75TGFC";

        /// <summary>
        /// TH75TTXT.
        /// </summary>
        public const string TH75TTXT = "TH75TTXT";

        /// <summary>
        /// THT75VRE.
        /// </summary>
        public const string THT75VRE = "THT75VRE";

        /// <summary>
        /// THEXR1.
        /// </summary>
        public const string THEXR1 = "THEXR1";

        /// <summary>
        /// THTXA1.
        /// </summary>
        public const string THTXA1 = "THTXA1";

        /// <summary>
        /// THTXR1.
        /// </summary>
        public const string THTXR1 = "THTXR1";

        /// <summary>
        /// THBCRC.
        /// </summary>
        public const string THBCRC = "THBCRC";

        /// <summary>
        /// THATXA.
        /// </summary>
        public const string THATXA = "THATXA";

        /// <summary>
        /// THSTAM.
        /// </summary>
        public const string THSTAM = "THSTAM";

        /// <summary>
        /// THAAP.
        /// </summary>
        public const string THAAP = "THAAP";

        /// <summary>
        /// THT75ATXA.
        /// </summary>
        public const string THT75ATXA = "THT75ATXA";

        /// <summary>
        /// THT75STAM.
        /// </summary>
        public const string THT75STAM = "THT75STAM";

        /// <summary>
        /// THT75AAP.
        /// </summary>
        public const string THT75AAP = "THT75AAP";

        /// <summary>
        /// THCRCD.
        /// </summary>
        public const string THCRCD = "THCRCD";

        /// <summary>
        /// THCRR.
        /// </summary>
        public const string THCRR = "THCRR";

        /// <summary>
        /// THCTXA.
        /// </summary>
        public const string THCTXA = "THCTXA";

        /// <summary>
        /// THCTAM.
        /// </summary>
        public const string THCTAM = "THCTAM";

        /// <summary>
        /// THT75FOTA.
        /// </summary>
        public const string THT75FOTA = "THT75FOTA";

        /// <summary>
        /// THT75FOTX.
        /// </summary>
        public const string THT75FOTX = "THT75FOTX";

        /// <summary>
        /// THT75FOAP.
        /// </summary>
        public const string THT75FOAP = "THT75FOAP";

        /// <summary>
        /// THT75ANTX.
        /// </summary>
        public const string THT75ANTX = "THT75ANTX";

        /// <summary>
        /// THT75AONT.
        /// </summary>
        public const string THT75AONT = "THT75AONT";

        /// <summary>
        /// THT75FONT.
        /// </summary>
        public const string THT75FONT = "THT75FONT";

        /// <summary>
        /// THT75FNTX.
        /// </summary>
        public const string THT75FNTX = "THT75FNTX";

        /// <summary>
        /// THFAP.
        /// </summary>
        public const string THFAP = "THFAP";

        /// <summary>
        /// TH75TUIP.
        /// </summary>
        public const string TH75TUIP = "TH75TUIP";

        /// <summary>
        /// TH75TGRF.
        /// </summary>
        public const string TH75TGRF = "TH75TGRF";

        /// <summary>
        /// TH75TGSF.
        /// </summary>
        public const string TH75TGSF = "TH75TGSF";

        /// <summary>
        /// TH75TGNF.
        /// </summary>
        public const string TH75TGNF = "TH75TGNF";

        /// <summary>
        /// TH75TGNT.
        /// </summary>
        public const string TH75TGNT = "TH75TGNT";

        /// <summary>
        /// TH75TTNT.
        /// </summary>
        public const string TH75TTNT = "TH75TTNT";

        /// <summary>
        /// THT75GUIP.
        /// </summary>
        public const string THT75GUIP = "THT75GUIP";

        /// <summary>
        /// THT75VDNF.
        /// </summary>
        public const string THT75VDNF = "THT75VDNF";

        /// <summary>
        /// THT75VDNT.
        /// </summary>
        public const string THT75VDNT = "THT75VDNT";

        /// <summary>
        /// TH75TSMN.
        /// </summary>
        public const string TH75TSMN = "TH75TSMN";

        /// <summary>
        /// TH75TSMC.
        /// </summary>
        public const string TH75TSMC = "TH75TSMC";

        /// <summary>
        /// TH75TSIT.
        /// </summary>
        public const string TH75TSIT = "TH75TSIT";

        /// <summary>
        /// TH75TZTT.
        /// </summary>
        public const string TH75TZTT = "TH75TZTT";

        /// <summary>
        /// TH75TDCU.
        /// </summary>
        public const string TH75TDCU = "TH75TDCU";

        /// <summary>
        /// TH75TPDM.
        /// </summary>
        public const string TH75TPDM = "TH75TPDM";

        /// <summary>
        /// TH75TPDN.
        /// </summary>
        public const string TH75TPDN = "TH75TPDN";

        /// <summary>
        /// TH75TEPM.
        /// </summary>
        public const string TH75TEPM = "TH75TEPM";

        /// <summary>
        /// TH75TDET.
        /// </summary>
        public const string TH75TDET = "TH75TDET";

        /// <summary>
        /// TH75TDEN.
        /// </summary>
        public const string TH75TDEN = "TH75TDEN";

        /// <summary>
        /// TH75TEPD.
        /// </summary>
        public const string TH75TEPD = "TH75TEPD";

        /// <summary>
        /// TH75TRVT.
        /// </summary>
        public const string TH75TRVT = "TH75TRVT";

        /// <summary>
        /// TH75TSTT.
        /// </summary>
        public const string TH75TSTT = "TH75TSTT";

        /// <summary>
        /// TH75TDDC.
        /// </summary>
        public const string TH75TDDC = "TH75TDDC";

        /// <summary>
        /// TH75TPIT.
        /// </summary>
        public const string TH75TPIT = "TH75TPIT";

        /// <summary>
        /// TH75TIIT.
        /// </summary>
        public const string TH75TIIT = "TH75TIIT";

        /// <summary>
        /// TH75TPUS.
        /// </summary>
        public const string TH75TPUS = "TH75TPUS";

        /// <summary>
        /// TH75TFCW.
        /// </summary>
        public const string TH75TFCW = "TH75TFCW";

        /// <summary>
        /// THAN8.
        /// </summary>
        public const string THAN8 = "THAN8";

        /// <summary>
        /// THAN8R.
        /// </summary>
        public const string THAN8R = "THAN8R";

        /// <summary>
        /// THSHAN.
        /// </summary>
        public const string THSHAN = "THSHAN";

        /// <summary>
        /// THALPH.
        /// </summary>
        public const string THALPH = "THALPH";

        /// <summary>
        /// TH75TPUN.
        /// </summary>
        public const string TH75TPUN = "TH75TPUN";

        /// <summary>
        /// TH75TMGT.
        /// </summary>
        public const string TH75TMGT = "TH75TMGT";

        /// <summary>
        /// THKCO.
        /// </summary>
        public const string THKCO = "THKCO";

        /// <summary>
        /// THDCT.
        /// </summary>
        public const string THDCT = "THDCT";

        /// <summary>
        /// THDOC.
        /// </summary>
        public const string THDOC = "THDOC";

        /// <summary>
        /// THKCOO.
        /// </summary>
        public const string THKCOO = "THKCOO";

        /// <summary>
        /// THDCTO.
        /// </summary>
        public const string THDCTO = "THDCTO";

        /// <summary>
        /// THDOCO.
        /// </summary>
        public const string THDOCO = "THDOCO";

        /// <summary>
        /// THSFXO.
        /// </summary>
        public const string THSFXO = "THSFXO";

        /// <summary>
        /// THDSC1.
        /// </summary>
        public const string THDSC1 = "THDSC1";

        /// <summary>
        /// THUORG.
        /// </summary>
        public const string THUORG = "THUORG";

        /// <summary>
        /// TH75TCC1.
        /// </summary>
        public const string TH75TCC1 = "TH75TCC1";

        /// <summary>
        /// TH75TCC2.
        /// </summary>
        public const string TH75TCC2 = "TH75TCC2";

        /// <summary>
        /// TH75TCC3.
        /// </summary>
        public const string TH75TCC3 = "TH75TCC3";

        /// <summary>
        /// TH75TCC4.
        /// </summary>
        public const string TH75TCC4 = "TH75TCC4";

        /// <summary>
        /// TH75TCC5.
        /// </summary>
        public const string TH75TCC5 = "TH75TCC5";

        /// <summary>
        /// TH75TCC6.
        /// </summary>
        public const string TH75TCC6 = "TH75TCC6";

        /// <summary>
        /// TH75TCC7.
        /// </summary>
        public const string TH75TCC7 = "TH75TCC7";

        /// <summary>
        /// TH75TCC8.
        /// </summary>
        public const string TH75TCC8 = "TH75TCC8";

        /// <summary>
        /// TH75TCC9.
        /// </summary>
        public const string TH75TCC9 = "TH75TCC9";

        /// <summary>
        /// TH75TPCT.
        /// </summary>
        public const string TH75TPCT = "TH75TPCT";

        /// <summary>
        /// THMUSE.
        /// </summary>
        public const string THMUSE = "THMUSE";

        /// <summary>
        /// TH75TSPI.
        /// </summary>
        public const string TH75TSPI = "TH75TSPI";

        /// <summary>
        /// TH75TCRI.
        /// </summary>
        public const string TH75TCRI = "TH75TCRI";

        /// <summary>
        /// TH75TCID.
        /// </summary>
        public const string TH75TCID = "TH75TCID";

        /// <summary>
        /// TH75TCCN.
        /// </summary>
        public const string TH75TCCN = "TH75TCCN";

        /// <summary>
        /// TH75TPYT.
        /// </summary>
        public const string TH75TPYT = "TH75TPYT";

        /// <summary>
        /// TH75TPPS.
        /// </summary>
        public const string TH75TPPS = "TH75TPPS";

        /// <summary>
        /// TH75TPPB.
        /// </summary>
        public const string TH75TPPB = "TH75TPPB";

        /// <summary>
        /// TH75TDGM.
        /// </summary>
        public const string TH75TDGM = "TH75TDGM";

        /// <summary>
        /// THREMK.
        /// </summary>
        public const string THREMK = "THREMK";

        /// <summary>
        /// THURC1.
        /// </summary>
        public const string THURC1 = "THURC1";

        /// <summary>
        /// THURDT.
        /// </summary>
        public const string THURDT = "THURDT";

        /// <summary>
        /// THURAT.
        /// </summary>
        public const string THURAT = "THURAT";

        /// <summary>
        /// THURAB.
        /// </summary>
        public const string THURAB = "THURAB";

        /// <summary>
        /// THURRF.
        /// </summary>
        public const string THURRF = "THURRF";

        /// <summary>
        /// THTORG.
        /// </summary>
        public const string THTORG = "THTORG";

        /// <summary>
        /// THT75UPMJ.
        /// </summary>
        public const string THT75UPMJ = "THT75UPMJ";

        /// <summary>
        /// THT75TDAY.
        /// </summary>
        public const string THT75TDAY = "THT75TDAY";

        /// <summary>
        /// TH75TEXP.
        /// </summary>
        public const string TH75TEXP = "TH75TEXP";

        /// <summary>
        /// THVDGJ.
        /// </summary>
        public const string THVDGJ = "THVDGJ";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THTDAY.
        /// </summary>
        public const string THTDAY = "THTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TH75TTNF", "TH75TTNF", JdeDataType.String, 40, true, true),
        new JdeField("TH75TRAS", "TH75TRAS", JdeDataType.Numeric, null, true, true),
        new JdeField("THCO", "THCO", JdeDataType.String, 10),
        new JdeField("TH75TDSI", "TH75TDSI", JdeDataType.String, 10),
        new JdeField("TH75TAUC", "TH75TAUC", JdeDataType.String, 20),
        new JdeField("TH75TYMD", "TH75TYMD", JdeDataType.Numeric),
        new JdeField("TH75TVTT", "TH75TVTT", JdeDataType.String, 6, true, true),
        new JdeField("TH75TDCT", "TH75TDCT", JdeDataType.String, 6),
        new JdeField("THICU", "THICU", JdeDataType.Numeric),
        new JdeField("THTRDJ", "THTRDJ", JdeDataType.Numeric),
        new JdeField("THDGJ", "THDGJ", JdeDataType.Numeric),
        new JdeField("TH75TYMH", "TH75TYMH", JdeDataType.Numeric, null, true, true),
        new JdeField("TH75TGFC", "TH75TGFC", JdeDataType.String, 4),
        new JdeField("TH75TTXT", "TH75TTXT", JdeDataType.String, 2),
        new JdeField("THT75VRE", "THT75VRE", JdeDataType.String, 6),
        new JdeField("THEXR1", "THEXR1", JdeDataType.String, 4),
        new JdeField("THTXA1", "THTXA1", JdeDataType.String, 20),
        new JdeField("THTXR1", "THTXR1", JdeDataType.Numeric),
        new JdeField("THBCRC", "THBCRC", JdeDataType.String, 6),
        new JdeField("THATXA", "THATXA", JdeDataType.Numeric),
        new JdeField("THSTAM", "THSTAM", JdeDataType.Numeric),
        new JdeField("THAAP", "THAAP", JdeDataType.Numeric),
        new JdeField("THT75ATXA", "THT75ATXA", JdeDataType.Numeric),
        new JdeField("THT75STAM", "THT75STAM", JdeDataType.Numeric),
        new JdeField("THT75AAP", "THT75AAP", JdeDataType.Numeric),
        new JdeField("THCRCD", "THCRCD", JdeDataType.String, 6),
        new JdeField("THCRR", "THCRR", JdeDataType.Numeric),
        new JdeField("THCTXA", "THCTXA", JdeDataType.Numeric),
        new JdeField("THCTAM", "THCTAM", JdeDataType.Numeric),
        new JdeField("THT75FOTA", "THT75FOTA", JdeDataType.Numeric),
        new JdeField("THT75FOTX", "THT75FOTX", JdeDataType.Numeric),
        new JdeField("THT75FOAP", "THT75FOAP", JdeDataType.Numeric),
        new JdeField("THT75ANTX", "THT75ANTX", JdeDataType.Numeric),
        new JdeField("THT75AONT", "THT75AONT", JdeDataType.Numeric),
        new JdeField("THT75FONT", "THT75FONT", JdeDataType.Numeric),
        new JdeField("THT75FNTX", "THT75FNTX", JdeDataType.Numeric),
        new JdeField("THFAP", "THFAP", JdeDataType.Numeric),
        new JdeField("TH75TUIP", "TH75TUIP", JdeDataType.String, 4),
        new JdeField("TH75TGRF", "TH75TGRF", JdeDataType.Numeric),
        new JdeField("TH75TGSF", "TH75TGSF", JdeDataType.Numeric),
        new JdeField("TH75TGNF", "TH75TGNF", JdeDataType.Numeric),
        new JdeField("TH75TGNT", "TH75TGNT", JdeDataType.Numeric),
        new JdeField("TH75TTNT", "TH75TTNT", JdeDataType.String, 40),
        new JdeField("THT75GUIP", "THT75GUIP", JdeDataType.String, 8),
        new JdeField("THT75VDNF", "THT75VDNF", JdeDataType.String, 28),
        new JdeField("THT75VDNT", "THT75VDNT", JdeDataType.String, 28),
        new JdeField("TH75TSMN", "TH75TSMN", JdeDataType.String, 2),
        new JdeField("TH75TSMC", "TH75TSMC", JdeDataType.Numeric),
        new JdeField("TH75TSIT", "TH75TSIT", JdeDataType.String, 6),
        new JdeField("TH75TZTT", "TH75TZTT", JdeDataType.String, 6),
        new JdeField("TH75TDCU", "TH75TDCU", JdeDataType.String, 2),
        new JdeField("TH75TPDM", "TH75TPDM", JdeDataType.String, 20),
        new JdeField("TH75TPDN", "TH75TPDN", JdeDataType.String, 50),
        new JdeField("TH75TEPM", "TH75TEPM", JdeDataType.String, 2),
        new JdeField("TH75TDET", "TH75TDET", JdeDataType.String, 4),
        new JdeField("TH75TDEN", "TH75TDEN", JdeDataType.String, 50),
        new JdeField("TH75TEPD", "TH75TEPD", JdeDataType.Numeric),
        new JdeField("TH75TRVT", "TH75TRVT", JdeDataType.String, 6),
        new JdeField("TH75TSTT", "TH75TSTT", JdeDataType.String, 6),
        new JdeField("TH75TDDC", "TH75TDDC", JdeDataType.String, 2),
        new JdeField("TH75TPIT", "TH75TPIT", JdeDataType.String, 6),
        new JdeField("TH75TIIT", "TH75TIIT", JdeDataType.String, 6),
        new JdeField("TH75TPUS", "TH75TPUS", JdeDataType.String, 6),
        new JdeField("TH75TFCW", "TH75TFCW", JdeDataType.String, 2),
        new JdeField("THAN8", "THAN8", JdeDataType.Numeric),
        new JdeField("THAN8R", "THAN8R", JdeDataType.Numeric),
        new JdeField("THSHAN", "THSHAN", JdeDataType.Numeric),
        new JdeField("THALPH", "THALPH", JdeDataType.String, 80),
        new JdeField("TH75TPUN", "TH75TPUN", JdeDataType.String, 16),
        new JdeField("TH75TMGT", "TH75TMGT", JdeDataType.String, 2),
        new JdeField("THKCO", "THKCO", JdeDataType.String, 10),
        new JdeField("THDCT", "THDCT", JdeDataType.String, 4),
        new JdeField("THDOC", "THDOC", JdeDataType.Numeric),
        new JdeField("THKCOO", "THKCOO", JdeDataType.String, 10),
        new JdeField("THDCTO", "THDCTO", JdeDataType.String, 4),
        new JdeField("THDOCO", "THDOCO", JdeDataType.Numeric),
        new JdeField("THSFXO", "THSFXO", JdeDataType.String, 6),
        new JdeField("THDSC1", "THDSC1", JdeDataType.String, 60),
        new JdeField("THUORG", "THUORG", JdeDataType.Numeric),
        new JdeField("TH75TCC1", "TH75TCC1", JdeDataType.String, 6),
        new JdeField("TH75TCC2", "TH75TCC2", JdeDataType.String, 6),
        new JdeField("TH75TCC3", "TH75TCC3", JdeDataType.String, 6),
        new JdeField("TH75TCC4", "TH75TCC4", JdeDataType.String, 6),
        new JdeField("TH75TCC5", "TH75TCC5", JdeDataType.String, 6),
        new JdeField("TH75TCC6", "TH75TCC6", JdeDataType.String, 6),
        new JdeField("TH75TCC7", "TH75TCC7", JdeDataType.String, 6),
        new JdeField("TH75TCC8", "TH75TCC8", JdeDataType.String, 6),
        new JdeField("TH75TCC9", "TH75TCC9", JdeDataType.String, 6),
        new JdeField("TH75TPCT", "TH75TPCT", JdeDataType.Numeric),
        new JdeField("THMUSE", "THMUSE", JdeDataType.String, 20),
        new JdeField("TH75TSPI", "TH75TSPI", JdeDataType.String, 20),
        new JdeField("TH75TCRI", "TH75TCRI", JdeDataType.String, 20),
        new JdeField("TH75TCID", "TH75TCID", JdeDataType.String, 20),
        new JdeField("TH75TCCN", "TH75TCCN", JdeDataType.String, 32),
        new JdeField("TH75TPYT", "TH75TPYT", JdeDataType.String, 20),
        new JdeField("TH75TPPS", "TH75TPPS", JdeDataType.String, 2),
        new JdeField("TH75TPPB", "TH75TPPB", JdeDataType.Numeric),
        new JdeField("TH75TDGM", "TH75TDGM", JdeDataType.String, 6),
        new JdeField("THREMK", "THREMK", JdeDataType.String, 60),
        new JdeField("THURC1", "THURC1", JdeDataType.String, 6),
        new JdeField("THURDT", "THURDT", JdeDataType.Numeric),
        new JdeField("THURAT", "THURAT", JdeDataType.Numeric),
        new JdeField("THURAB", "THURAB", JdeDataType.Numeric),
        new JdeField("THURRF", "THURRF", JdeDataType.String, 30),
        new JdeField("THTORG", "THTORG", JdeDataType.String, 20),
        new JdeField("THT75UPMJ", "THT75UPMJ", JdeDataType.Numeric),
        new JdeField("THT75TDAY", "THT75TDAY", JdeDataType.Numeric),
        new JdeField("TH75TEXP", "TH75TEXP", JdeDataType.String, 2),
        new JdeField("THVDGJ", "THVDGJ", JdeDataType.Numeric),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THTDAY", "THTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T004_0", "Primary Key on TH75TTNF, TH75TRAS, TH75TYMH, TH75TVTT", new[] { "TH75TTNF", "TH75TRAS", "TH75TYMH", "TH75TVTT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T004_2", "Index on THCO, TH75TDSI", new[] { "THCO", "TH75TDSI" }),
        new JdeIndex("F75T004_6", "Index on TH75TUIP, TH75TGRF, TH75TGSF", new[] { "TH75TUIP", "TH75TGRF", "TH75TGSF" }),
        new JdeIndex("F75T004_7", "Index on THDOC, THDCT, THKCO", new[] { "THDOC", "THDCT", "THKCO" }),
        new JdeIndex("F75T004_8", "Index on TH75TTNF, SYS_NC00115$", new[] { "TH75TTNF", "SYS_NC00115$" })
    };
}
