using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T004Z - .
/// </summary>
public class F75T004Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZHUSER.
        /// </summary>
        public const string ZHUSER = "ZHUSER";

        /// <summary>
        /// ZHJOBN.
        /// </summary>
        public const string ZHJOBN = "ZHJOBN";

        /// <summary>
        /// ZHOKCO.
        /// </summary>
        public const string ZHOKCO = "ZHOKCO";

        /// <summary>
        /// ZHODCT.
        /// </summary>
        public const string ZHODCT = "ZHODCT";

        /// <summary>
        /// ZHODOC.
        /// </summary>
        public const string ZHODOC = "ZHODOC";

        /// <summary>
        /// ZH75TDCT.
        /// </summary>
        public const string ZH75TDCT = "ZH75TDCT";

        /// <summary>
        /// ZH75TTXT.
        /// </summary>
        public const string ZH75TTXT = "ZH75TTXT";

        /// <summary>
        /// ZH75TPGN.
        /// </summary>
        public const string ZH75TPGN = "ZH75TPGN";

        /// <summary>
        /// ZH75TYMH.
        /// </summary>
        public const string ZH75TYMH = "ZH75TYMH";

        /// <summary>
        /// ZH75TVTT.
        /// </summary>
        public const string ZH75TVTT = "ZH75TVTT";

        /// <summary>
        /// ZHTRDJ.
        /// </summary>
        public const string ZHTRDJ = "ZHTRDJ";

        /// <summary>
        /// ZHDGJ.
        /// </summary>
        public const string ZHDGJ = "ZHDGJ";

        /// <summary>
        /// ZH75TGFC.
        /// </summary>
        public const string ZH75TGFC = "ZH75TGFC";

        /// <summary>
        /// ZHEXR1.
        /// </summary>
        public const string ZHEXR1 = "ZHEXR1";

        /// <summary>
        /// ZHTXA1.
        /// </summary>
        public const string ZHTXA1 = "ZHTXA1";

        /// <summary>
        /// ZHTXR1.
        /// </summary>
        public const string ZHTXR1 = "ZHTXR1";

        /// <summary>
        /// ZHBCRC.
        /// </summary>
        public const string ZHBCRC = "ZHBCRC";

        /// <summary>
        /// ZHATXA.
        /// </summary>
        public const string ZHATXA = "ZHATXA";

        /// <summary>
        /// ZHSTAM.
        /// </summary>
        public const string ZHSTAM = "ZHSTAM";

        /// <summary>
        /// ZHAAP.
        /// </summary>
        public const string ZHAAP = "ZHAAP";

        /// <summary>
        /// ZHT75STAM.
        /// </summary>
        public const string ZHT75STAM = "ZHT75STAM";

        /// <summary>
        /// ZHT75ATXA.
        /// </summary>
        public const string ZHT75ATXA = "ZHT75ATXA";

        /// <summary>
        /// ZHT75AAP.
        /// </summary>
        public const string ZHT75AAP = "ZHT75AAP";

        /// <summary>
        /// ZHCRCD.
        /// </summary>
        public const string ZHCRCD = "ZHCRCD";

        /// <summary>
        /// ZHCRR.
        /// </summary>
        public const string ZHCRR = "ZHCRR";

        /// <summary>
        /// ZHT75ANTX.
        /// </summary>
        public const string ZHT75ANTX = "ZHT75ANTX";

        /// <summary>
        /// ZHT75FONT.
        /// </summary>
        public const string ZHT75FONT = "ZHT75FONT";

        /// <summary>
        /// ZHT75AONT.
        /// </summary>
        public const string ZHT75AONT = "ZHT75AONT";

        /// <summary>
        /// ZHCTXA.
        /// </summary>
        public const string ZHCTXA = "ZHCTXA";

        /// <summary>
        /// ZHCTAM.
        /// </summary>
        public const string ZHCTAM = "ZHCTAM";

        /// <summary>
        /// ZHT75FNTX.
        /// </summary>
        public const string ZHT75FNTX = "ZHT75FNTX";

        /// <summary>
        /// ZHFAP.
        /// </summary>
        public const string ZHFAP = "ZHFAP";

        /// <summary>
        /// ZHT75FOAP.
        /// </summary>
        public const string ZHT75FOAP = "ZHT75FOAP";

        /// <summary>
        /// ZHT75FOTA.
        /// </summary>
        public const string ZHT75FOTA = "ZHT75FOTA";

        /// <summary>
        /// ZHT75FOTX.
        /// </summary>
        public const string ZHT75FOTX = "ZHT75FOTX";

        /// <summary>
        /// ZH75TSIT.
        /// </summary>
        public const string ZH75TSIT = "ZH75TSIT";

        /// <summary>
        /// ZH75TZTT.
        /// </summary>
        public const string ZH75TZTT = "ZH75TZTT";

        /// <summary>
        /// ZH75TSTT.
        /// </summary>
        public const string ZH75TSTT = "ZH75TSTT";

        /// <summary>
        /// ZH75TRVT.
        /// </summary>
        public const string ZH75TRVT = "ZH75TRVT";

        /// <summary>
        /// ZH75TFCW.
        /// </summary>
        public const string ZH75TFCW = "ZH75TFCW";

        /// <summary>
        /// ZHAN8.
        /// </summary>
        public const string ZHAN8 = "ZHAN8";

        /// <summary>
        /// ZHAN8R.
        /// </summary>
        public const string ZHAN8R = "ZHAN8R";

        /// <summary>
        /// ZHSHAN.
        /// </summary>
        public const string ZHSHAN = "ZHSHAN";

        /// <summary>
        /// ZHALPH.
        /// </summary>
        public const string ZHALPH = "ZHALPH";

        /// <summary>
        /// ZHT75GUIP.
        /// </summary>
        public const string ZHT75GUIP = "ZHT75GUIP";

        /// <summary>
        /// ZHT75VDNT.
        /// </summary>
        public const string ZHT75VDNT = "ZHT75VDNT";

        /// <summary>
        /// ZHT75VDNF.
        /// </summary>
        public const string ZHT75VDNF = "ZHT75VDNF";

        /// <summary>
        /// ZH75TPUN.
        /// </summary>
        public const string ZH75TPUN = "ZH75TPUN";

        /// <summary>
        /// ZH75TCC4.
        /// </summary>
        public const string ZH75TCC4 = "ZH75TCC4";

        /// <summary>
        /// ZH75TCC5.
        /// </summary>
        public const string ZH75TCC5 = "ZH75TCC5";

        /// <summary>
        /// ZH75TCC6.
        /// </summary>
        public const string ZH75TCC6 = "ZH75TCC6";

        /// <summary>
        /// ZH75TPDM.
        /// </summary>
        public const string ZH75TPDM = "ZH75TPDM";

        /// <summary>
        /// ZH75TPDN.
        /// </summary>
        public const string ZH75TPDN = "ZH75TPDN";

        /// <summary>
        /// ZH75TEPM.
        /// </summary>
        public const string ZH75TEPM = "ZH75TEPM";

        /// <summary>
        /// ZH75TDCU.
        /// </summary>
        public const string ZH75TDCU = "ZH75TDCU";

        /// <summary>
        /// ZH75TDET.
        /// </summary>
        public const string ZH75TDET = "ZH75TDET";

        /// <summary>
        /// ZH75TDEN.
        /// </summary>
        public const string ZH75TDEN = "ZH75TDEN";

        /// <summary>
        /// ZH75TEPD.
        /// </summary>
        public const string ZH75TEPD = "ZH75TEPD";

        /// <summary>
        /// ZH75TMGT.
        /// </summary>
        public const string ZH75TMGT = "ZH75TMGT";

        /// <summary>
        /// ZHT75VRE.
        /// </summary>
        public const string ZHT75VRE = "ZHT75VRE";

        /// <summary>
        /// ZHVDGJ.
        /// </summary>
        public const string ZHVDGJ = "ZHVDGJ";

        /// <summary>
        /// ZHKCO.
        /// </summary>
        public const string ZHKCO = "ZHKCO";

        /// <summary>
        /// ZHDCT.
        /// </summary>
        public const string ZHDCT = "ZHDCT";

        /// <summary>
        /// ZHICU.
        /// </summary>
        public const string ZHICU = "ZHICU";

        /// <summary>
        /// ZHDOC.
        /// </summary>
        public const string ZHDOC = "ZHDOC";

        /// <summary>
        /// ZHKCOO.
        /// </summary>
        public const string ZHKCOO = "ZHKCOO";

        /// <summary>
        /// ZHDCTO.
        /// </summary>
        public const string ZHDCTO = "ZHDCTO";

        /// <summary>
        /// ZHDOCO.
        /// </summary>
        public const string ZHDOCO = "ZHDOCO";

        /// <summary>
        /// ZH75TLNID.
        /// </summary>
        public const string ZH75TLNID = "ZH75TLNID";

        /// <summary>
        /// ZH75TLID.
        /// </summary>
        public const string ZH75TLID = "ZH75TLID";

        /// <summary>
        /// ZHUPMJ.
        /// </summary>
        public const string ZHUPMJ = "ZHUPMJ";

        /// <summary>
        /// ZHTDAY.
        /// </summary>
        public const string ZHTDAY = "ZHTDAY";

        /// <summary>
        /// ZHT75UPMJ.
        /// </summary>
        public const string ZHT75UPMJ = "ZHT75UPMJ";

        /// <summary>
        /// ZHT75TDAY.
        /// </summary>
        public const string ZHT75TDAY = "ZHT75TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T004Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZHUSER", "ZHUSER", JdeDataType.String, 20, true, true),
        new JdeField("ZHJOBN", "ZHJOBN", JdeDataType.String, 20, true, true),
        new JdeField("ZHOKCO", "ZHOKCO", JdeDataType.String, 10, true, true),
        new JdeField("ZHODCT", "ZHODCT", JdeDataType.String, 4, true, true),
        new JdeField("ZHODOC", "ZHODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZH75TDCT", "ZH75TDCT", JdeDataType.String, 6, true, true),
        new JdeField("ZH75TTXT", "ZH75TTXT", JdeDataType.String, 2, true, true),
        new JdeField("ZH75TPGN", "ZH75TPGN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZH75TYMH", "ZH75TYMH", JdeDataType.Numeric),
        new JdeField("ZH75TVTT", "ZH75TVTT", JdeDataType.String, 6),
        new JdeField("ZHTRDJ", "ZHTRDJ", JdeDataType.Numeric),
        new JdeField("ZHDGJ", "ZHDGJ", JdeDataType.Numeric),
        new JdeField("ZH75TGFC", "ZH75TGFC", JdeDataType.String, 4),
        new JdeField("ZHEXR1", "ZHEXR1", JdeDataType.String, 4),
        new JdeField("ZHTXA1", "ZHTXA1", JdeDataType.String, 20),
        new JdeField("ZHTXR1", "ZHTXR1", JdeDataType.Numeric),
        new JdeField("ZHBCRC", "ZHBCRC", JdeDataType.String, 6),
        new JdeField("ZHATXA", "ZHATXA", JdeDataType.Numeric),
        new JdeField("ZHSTAM", "ZHSTAM", JdeDataType.Numeric),
        new JdeField("ZHAAP", "ZHAAP", JdeDataType.Numeric),
        new JdeField("ZHT75STAM", "ZHT75STAM", JdeDataType.Numeric),
        new JdeField("ZHT75ATXA", "ZHT75ATXA", JdeDataType.Numeric),
        new JdeField("ZHT75AAP", "ZHT75AAP", JdeDataType.Numeric),
        new JdeField("ZHCRCD", "ZHCRCD", JdeDataType.String, 6),
        new JdeField("ZHCRR", "ZHCRR", JdeDataType.Numeric),
        new JdeField("ZHT75ANTX", "ZHT75ANTX", JdeDataType.Numeric),
        new JdeField("ZHT75FONT", "ZHT75FONT", JdeDataType.Numeric),
        new JdeField("ZHT75AONT", "ZHT75AONT", JdeDataType.Numeric),
        new JdeField("ZHCTXA", "ZHCTXA", JdeDataType.Numeric),
        new JdeField("ZHCTAM", "ZHCTAM", JdeDataType.Numeric),
        new JdeField("ZHT75FNTX", "ZHT75FNTX", JdeDataType.Numeric),
        new JdeField("ZHFAP", "ZHFAP", JdeDataType.Numeric),
        new JdeField("ZHT75FOAP", "ZHT75FOAP", JdeDataType.Numeric),
        new JdeField("ZHT75FOTA", "ZHT75FOTA", JdeDataType.Numeric),
        new JdeField("ZHT75FOTX", "ZHT75FOTX", JdeDataType.Numeric),
        new JdeField("ZH75TSIT", "ZH75TSIT", JdeDataType.String, 6),
        new JdeField("ZH75TZTT", "ZH75TZTT", JdeDataType.String, 6),
        new JdeField("ZH75TSTT", "ZH75TSTT", JdeDataType.String, 6),
        new JdeField("ZH75TRVT", "ZH75TRVT", JdeDataType.String, 6),
        new JdeField("ZH75TFCW", "ZH75TFCW", JdeDataType.String, 2),
        new JdeField("ZHAN8", "ZHAN8", JdeDataType.Numeric),
        new JdeField("ZHAN8R", "ZHAN8R", JdeDataType.Numeric),
        new JdeField("ZHSHAN", "ZHSHAN", JdeDataType.Numeric),
        new JdeField("ZHALPH", "ZHALPH", JdeDataType.String, 80),
        new JdeField("ZHT75GUIP", "ZHT75GUIP", JdeDataType.String, 8),
        new JdeField("ZHT75VDNT", "ZHT75VDNT", JdeDataType.String, 28),
        new JdeField("ZHT75VDNF", "ZHT75VDNF", JdeDataType.String, 28),
        new JdeField("ZH75TPUN", "ZH75TPUN", JdeDataType.String, 16),
        new JdeField("ZH75TCC4", "ZH75TCC4", JdeDataType.String, 6),
        new JdeField("ZH75TCC5", "ZH75TCC5", JdeDataType.String, 6),
        new JdeField("ZH75TCC6", "ZH75TCC6", JdeDataType.String, 6),
        new JdeField("ZH75TPDM", "ZH75TPDM", JdeDataType.String, 20),
        new JdeField("ZH75TPDN", "ZH75TPDN", JdeDataType.String, 50),
        new JdeField("ZH75TEPM", "ZH75TEPM", JdeDataType.String, 2),
        new JdeField("ZH75TDCU", "ZH75TDCU", JdeDataType.String, 2),
        new JdeField("ZH75TDET", "ZH75TDET", JdeDataType.String, 4),
        new JdeField("ZH75TDEN", "ZH75TDEN", JdeDataType.String, 50),
        new JdeField("ZH75TEPD", "ZH75TEPD", JdeDataType.Numeric),
        new JdeField("ZH75TMGT", "ZH75TMGT", JdeDataType.String, 2),
        new JdeField("ZHT75VRE", "ZHT75VRE", JdeDataType.String, 6),
        new JdeField("ZHVDGJ", "ZHVDGJ", JdeDataType.Numeric),
        new JdeField("ZHKCO", "ZHKCO", JdeDataType.String, 10),
        new JdeField("ZHDCT", "ZHDCT", JdeDataType.String, 4),
        new JdeField("ZHICU", "ZHICU", JdeDataType.Numeric),
        new JdeField("ZHDOC", "ZHDOC", JdeDataType.Numeric),
        new JdeField("ZHKCOO", "ZHKCOO", JdeDataType.String, 10),
        new JdeField("ZHDCTO", "ZHDCTO", JdeDataType.String, 4),
        new JdeField("ZHDOCO", "ZHDOCO", JdeDataType.Numeric),
        new JdeField("ZH75TLNID", "ZH75TLNID", JdeDataType.Numeric),
        new JdeField("ZH75TLID", "ZH75TLID", JdeDataType.Numeric),
        new JdeField("ZHUPMJ", "ZHUPMJ", JdeDataType.Numeric),
        new JdeField("ZHTDAY", "ZHTDAY", JdeDataType.Numeric),
        new JdeField("ZHT75UPMJ", "ZHT75UPMJ", JdeDataType.Numeric),
        new JdeField("ZHT75TDAY", "ZHT75TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T004Z_0", "Primary Key on ZHUSER, ZHJOBN, ZHOKCO, ZHODCT, ZHODOC, ZH75TDCT, ZH75TTXT, ZH75TPGN", new[] { "ZHUSER", "ZHJOBN", "ZHOKCO", "ZHODCT", "ZHODOC", "ZH75TDCT", "ZH75TTXT", "ZH75TPGN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T004Z_2", "Index on ZHUSER, ZHJOBN, ZHOKCO, ZHODCT, ZHODOC, ZH75TDCT, ZH75TTXT, SYS_NC00075$", new[] { "ZHUSER", "ZHJOBN", "ZHOKCO", "ZHODCT", "ZHODOC", "ZH75TDCT", "ZH75TTXT", "SYS_NC00075$" })
    };
}
