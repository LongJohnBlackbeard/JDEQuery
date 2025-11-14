using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1760 - .
/// </summary>
public class F1760 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZBDOCO.
        /// </summary>
        public const string ZBDOCO = "ZBDOCO";

        /// <summary>
        /// ZBSBLT.
        /// </summary>
        public const string ZBSBLT = "ZBSBLT";

        /// <summary>
        /// ZBLNID.
        /// </summary>
        public const string ZBLNID = "ZBLNID";

        /// <summary>
        /// ZBOPSQ.
        /// </summary>
        public const string ZBOPSQ = "ZBOPSQ";

        /// <summary>
        /// ZBDCTO.
        /// </summary>
        public const string ZBDCTO = "ZBDCTO";

        /// <summary>
        /// ZBKCO.
        /// </summary>
        public const string ZBKCO = "ZBKCO";

        /// <summary>
        /// ZBAN8.
        /// </summary>
        public const string ZBAN8 = "ZBAN8";

        /// <summary>
        /// ZBSTRT.
        /// </summary>
        public const string ZBSTRT = "ZBSTRT";

        /// <summary>
        /// ZBSTRX.
        /// </summary>
        public const string ZBSTRX = "ZBSTRX";

        /// <summary>
        /// ZBPBTM.
        /// </summary>
        public const string ZBPBTM = "ZBPBTM";

        /// <summary>
        /// ZBPETM.
        /// </summary>
        public const string ZBPETM = "ZBPETM";

        /// <summary>
        /// ZBRCK7.
        /// </summary>
        public const string ZBRCK7 = "ZBRCK7";

        /// <summary>
        /// ZBDSC1.
        /// </summary>
        public const string ZBDSC1 = "ZBDSC1";

        /// <summary>
        /// ZBPHRW.
        /// </summary>
        public const string ZBPHRW = "ZBPHRW";

        /// <summary>
        /// ZBDATE.
        /// </summary>
        public const string ZBDATE = "ZBDATE";

        /// <summary>
        /// ZBANI.
        /// </summary>
        public const string ZBANI = "ZBANI";

        /// <summary>
        /// ZBHMCU.
        /// </summary>
        public const string ZBHMCU = "ZBHMCU";

        /// <summary>
        /// ZBOBJ.
        /// </summary>
        public const string ZBOBJ = "ZBOBJ";

        /// <summary>
        /// ZBSUB.
        /// </summary>
        public const string ZBSUB = "ZBSUB";

        /// <summary>
        /// ZBWRKT.
        /// </summary>
        public const string ZBWRKT = "ZBWRKT";

        /// <summary>
        /// ZBPBRT.
        /// </summary>
        public const string ZBPBRT = "ZBPBRT";

        /// <summary>
        /// ZBASN3.
        /// </summary>
        public const string ZBASN3 = "ZBASN3";

        /// <summary>
        /// ZBBILL.
        /// </summary>
        public const string ZBBILL = "ZBBILL";

        /// <summary>
        /// ZBDTBIL.
        /// </summary>
        public const string ZBDTBIL = "ZBDTBIL";

        /// <summary>
        /// ZBCRRM.
        /// </summary>
        public const string ZBCRRM = "ZBCRRM";

        /// <summary>
        /// ZBCRDC.
        /// </summary>
        public const string ZBCRDC = "ZBCRDC";

        /// <summary>
        /// ZBCRCD.
        /// </summary>
        public const string ZBCRCD = "ZBCRCD";

        /// <summary>
        /// ZBACR.
        /// </summary>
        public const string ZBACR = "ZBACR";

        /// <summary>
        /// ZBAG.
        /// </summary>
        public const string ZBAG = "ZBAG";

        /// <summary>
        /// ZBAMTO.
        /// </summary>
        public const string ZBAMTO = "ZBAMTO";

        /// <summary>
        /// ZBFAP.
        /// </summary>
        public const string ZBFAP = "ZBFAP";

        /// <summary>
        /// ZBHRSO.
        /// </summary>
        public const string ZBHRSO = "ZBHRSO";

        /// <summary>
        /// ZBCOST.
        /// </summary>
        public const string ZBCOST = "ZBCOST";

        /// <summary>
        /// ZBMCUZ.
        /// </summary>
        public const string ZBMCUZ = "ZBMCUZ";

        /// <summary>
        /// ZBPDBA.
        /// </summary>
        public const string ZBPDBA = "ZBPDBA";

        /// <summary>
        /// ZBURAB.
        /// </summary>
        public const string ZBURAB = "ZBURAB";

        /// <summary>
        /// ZBURCD.
        /// </summary>
        public const string ZBURCD = "ZBURCD";

        /// <summary>
        /// ZBURAT.
        /// </summary>
        public const string ZBURAT = "ZBURAT";

        /// <summary>
        /// ZBURDT.
        /// </summary>
        public const string ZBURDT = "ZBURDT";

        /// <summary>
        /// ZBURRF.
        /// </summary>
        public const string ZBURRF = "ZBURRF";

        /// <summary>
        /// ZBCRTU.
        /// </summary>
        public const string ZBCRTU = "ZBCRTU";

        /// <summary>
        /// ZBUSER.
        /// </summary>
        public const string ZBUSER = "ZBUSER";

        /// <summary>
        /// ZBUPMJ.
        /// </summary>
        public const string ZBUPMJ = "ZBUPMJ";

        /// <summary>
        /// ZBUPMT.
        /// </summary>
        public const string ZBUPMT = "ZBUPMT";

        /// <summary>
        /// ZBJOBN.
        /// </summary>
        public const string ZBJOBN = "ZBJOBN";

        /// <summary>
        /// ZBPID.
        /// </summary>
        public const string ZBPID = "ZBPID";

        /// <summary>
        /// ZBPCOVR.
        /// </summary>
        public const string ZBPCOVR = "ZBPCOVR";

        /// <summary>
        /// ZBCOVGR.
        /// </summary>
        public const string ZBCOVGR = "ZBCOVGR";

        /// <summary>
        /// ZBGLCCV.
        /// </summary>
        public const string ZBGLCCV = "ZBGLCCV";

        /// <summary>
        /// ZBGLCNC.
        /// </summary>
        public const string ZBGLCNC = "ZBGLCNC";

        /// <summary>
        /// ZBGWAFL.
        /// </summary>
        public const string ZBGWAFL = "ZBGWAFL";

        /// <summary>
        /// ZBGWAUT.
        /// </summary>
        public const string ZBGWAUT = "ZBGWAUT";

        /// <summary>
        /// ZBGWANC.
        /// </summary>
        public const string ZBGWANC = "ZBGWANC";

        /// <summary>
        /// ZBENTCK.
        /// </summary>
        public const string ZBENTCK = "ZBENTCK";

        /// <summary>
        /// ZBUM.
        /// </summary>
        public const string ZBUM = "ZBUM";

        /// <summary>
        /// ZBCCR.
        /// </summary>
        public const string ZBCCR = "ZBCCR";

        /// <summary>
        /// ZBTBDT.
        /// </summary>
        public const string ZBTBDT = "ZBTBDT";

        /// <summary>
        /// ZBHRBL.
        /// </summary>
        public const string ZBHRBL = "ZBHRBL";

        /// <summary>
        /// ZBPHRT.
        /// </summary>
        public const string ZBPHRT = "ZBPHRT";

        /// <summary>
        /// ZBARTBD.
        /// </summary>
        public const string ZBARTBD = "ZBARTBD";

        /// <summary>
        /// ZBARTBF.
        /// </summary>
        public const string ZBARTBF = "ZBARTBF";

        /// <summary>
        /// ZBANC.
        /// </summary>
        public const string ZBANC = "ZBANC";

        /// <summary>
        /// ZBLANO.
        /// </summary>
        public const string ZBLANO = "ZBLANO";

        /// <summary>
        /// ZBANOB.
        /// </summary>
        public const string ZBANOB = "ZBANOB";

        /// <summary>
        /// ZBUSA5.
        /// </summary>
        public const string ZBUSA5 = "ZBUSA5";

        /// <summary>
        /// ZBVR01.
        /// </summary>
        public const string ZBVR01 = "ZBVR01";

        /// <summary>
        /// ZBMINHR.
        /// </summary>
        public const string ZBMINHR = "ZBMINHR";

        /// <summary>
        /// ZBMINAD.
        /// </summary>
        public const string ZBMINAD = "ZBMINAD";

        /// <summary>
        /// ZBMINAF.
        /// </summary>
        public const string ZBMINAF = "ZBMINAF";

        /// <summary>
        /// ZBDSFT.
        /// </summary>
        public const string ZBDSFT = "ZBDSFT";

        /// <summary>
        /// ZBDSPC.
        /// </summary>
        public const string ZBDSPC = "ZBDSPC";

        /// <summary>
        /// ZBIDSC.
        /// </summary>
        public const string ZBIDSC = "ZBIDSC";

        /// <summary>
        /// ZBCIDS.
        /// </summary>
        public const string ZBCIDS = "ZBCIDS";

        /// <summary>
        /// ZBITAM.
        /// </summary>
        public const string ZBITAM = "ZBITAM";

        /// <summary>
        /// ZBCITX.
        /// </summary>
        public const string ZBCITX = "ZBCITX";

        /// <summary>
        /// ZBJTAX.
        /// </summary>
        public const string ZBJTAX = "ZBJTAX";

        /// <summary>
        /// ZBJTXF.
        /// </summary>
        public const string ZBJTXF = "ZBJTXF";

        /// <summary>
        /// ZBAMTCD.
        /// </summary>
        public const string ZBAMTCD = "ZBAMTCD";

        /// <summary>
        /// ZBAMTCF.
        /// </summary>
        public const string ZBAMTCF = "ZBAMTCF";

        /// <summary>
        /// ZBATXCD.
        /// </summary>
        public const string ZBATXCD = "ZBATXCD";

        /// <summary>
        /// ZBATXCF.
        /// </summary>
        public const string ZBATXCF = "ZBATXCF";

        /// <summary>
        /// ZBEFTJ.
        /// </summary>
        public const string ZBEFTJ = "ZBEFTJ";

        /// <summary>
        /// ZBPTC.
        /// </summary>
        public const string ZBPTC = "ZBPTC";

        /// <summary>
        /// ZBRYIN.
        /// </summary>
        public const string ZBRYIN = "ZBRYIN";

        /// <summary>
        /// ZBTAX1.
        /// </summary>
        public const string ZBTAX1 = "ZBTAX1";

        /// <summary>
        /// ZBTXA1.
        /// </summary>
        public const string ZBTXA1 = "ZBTXA1";

        /// <summary>
        /// ZBEXR1.
        /// </summary>
        public const string ZBEXR1 = "ZBEXR1";

        /// <summary>
        /// ZBMTHPR.
        /// </summary>
        public const string ZBMTHPR = "ZBMTHPR";

        /// <summary>
        /// ZBCRR.
        /// </summary>
        public const string ZBCRR = "ZBCRR";

        /// <summary>
        /// ZBPEFJ.
        /// </summary>
        public const string ZBPEFJ = "ZBPEFJ";

        /// <summary>
        /// ZBCO.
        /// </summary>
        public const string ZBCO = "ZBCO";

        /// <summary>
        /// ZBMCU.
        /// </summary>
        public const string ZBMCU = "ZBMCU";

        /// <summary>
        /// ZBDTWRK.
        /// </summary>
        public const string ZBDTWRK = "ZBDTWRK";
    }

    /// <inheritdoc />
    public override string TableName => "F1760";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZBDOCO", "ZBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBSBLT", "ZBSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ZBLNID", "ZBLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBOPSQ", "ZBOPSQ", JdeDataType.Numeric),
        new JdeField("ZBDCTO", "ZBDCTO", JdeDataType.String, 4),
        new JdeField("ZBKCO", "ZBKCO", JdeDataType.String, 10),
        new JdeField("ZBAN8", "ZBAN8", JdeDataType.Numeric),
        new JdeField("ZBSTRT", "ZBSTRT", JdeDataType.Numeric),
        new JdeField("ZBSTRX", "ZBSTRX", JdeDataType.Numeric),
        new JdeField("ZBPBTM", "ZBPBTM", JdeDataType.Numeric),
        new JdeField("ZBPETM", "ZBPETM", JdeDataType.Numeric),
        new JdeField("ZBRCK7", "ZBRCK7", JdeDataType.Numeric),
        new JdeField("ZBDSC1", "ZBDSC1", JdeDataType.String, 60),
        new JdeField("ZBPHRW", "ZBPHRW", JdeDataType.Numeric),
        new JdeField("ZBDATE", "ZBDATE", JdeDataType.String, 16),
        new JdeField("ZBANI", "ZBANI", JdeDataType.String, 58),
        new JdeField("ZBHMCU", "ZBHMCU", JdeDataType.String, 24),
        new JdeField("ZBOBJ", "ZBOBJ", JdeDataType.String, 12),
        new JdeField("ZBSUB", "ZBSUB", JdeDataType.String, 16),
        new JdeField("ZBWRKT", "ZBWRKT", JdeDataType.String, 4),
        new JdeField("ZBPBRT", "ZBPBRT", JdeDataType.Numeric),
        new JdeField("ZBASN3", "ZBASN3", JdeDataType.String, 16),
        new JdeField("ZBBILL", "ZBBILL", JdeDataType.String, 2),
        new JdeField("ZBDTBIL", "ZBDTBIL", JdeDataType.Numeric),
        new JdeField("ZBCRRM", "ZBCRRM", JdeDataType.String, 2),
        new JdeField("ZBCRDC", "ZBCRDC", JdeDataType.String, 6),
        new JdeField("ZBCRCD", "ZBCRCD", JdeDataType.String, 6),
        new JdeField("ZBACR", "ZBACR", JdeDataType.Numeric),
        new JdeField("ZBAG", "ZBAG", JdeDataType.Numeric),
        new JdeField("ZBAMTO", "ZBAMTO", JdeDataType.Numeric),
        new JdeField("ZBFAP", "ZBFAP", JdeDataType.Numeric),
        new JdeField("ZBHRSO", "ZBHRSO", JdeDataType.Numeric),
        new JdeField("ZBCOST", "ZBCOST", JdeDataType.String, 6),
        new JdeField("ZBMCUZ", "ZBMCUZ", JdeDataType.String, 24),
        new JdeField("ZBPDBA", "ZBPDBA", JdeDataType.Numeric),
        new JdeField("ZBURAB", "ZBURAB", JdeDataType.Numeric),
        new JdeField("ZBURCD", "ZBURCD", JdeDataType.String, 4),
        new JdeField("ZBURAT", "ZBURAT", JdeDataType.Numeric),
        new JdeField("ZBURDT", "ZBURDT", JdeDataType.Numeric),
        new JdeField("ZBURRF", "ZBURRF", JdeDataType.String, 30),
        new JdeField("ZBCRTU", "ZBCRTU", JdeDataType.String, 20),
        new JdeField("ZBUSER", "ZBUSER", JdeDataType.String, 20),
        new JdeField("ZBUPMJ", "ZBUPMJ", JdeDataType.Numeric),
        new JdeField("ZBUPMT", "ZBUPMT", JdeDataType.Numeric),
        new JdeField("ZBJOBN", "ZBJOBN", JdeDataType.String, 20),
        new JdeField("ZBPID", "ZBPID", JdeDataType.String, 20),
        new JdeField("ZBPCOVR", "ZBPCOVR", JdeDataType.Numeric),
        new JdeField("ZBCOVGR", "ZBCOVGR", JdeDataType.String, 16),
        new JdeField("ZBGLCCV", "ZBGLCCV", JdeDataType.String, 8),
        new JdeField("ZBGLCNC", "ZBGLCNC", JdeDataType.String, 8),
        new JdeField("ZBGWAFL", "ZBGWAFL", JdeDataType.String, 2),
        new JdeField("ZBGWAUT", "ZBGWAUT", JdeDataType.String, 8),
        new JdeField("ZBGWANC", "ZBGWANC", JdeDataType.String, 8),
        new JdeField("ZBENTCK", "ZBENTCK", JdeDataType.String, 6),
        new JdeField("ZBUM", "ZBUM", JdeDataType.String, 4),
        new JdeField("ZBCCR", "ZBCCR", JdeDataType.String, 20),
        new JdeField("ZBTBDT", "ZBTBDT", JdeDataType.Numeric),
        new JdeField("ZBHRBL", "ZBHRBL", JdeDataType.Numeric),
        new JdeField("ZBPHRT", "ZBPHRT", JdeDataType.Numeric),
        new JdeField("ZBARTBD", "ZBARTBD", JdeDataType.Numeric),
        new JdeField("ZBARTBF", "ZBARTBF", JdeDataType.Numeric),
        new JdeField("ZBANC", "ZBANC", JdeDataType.Numeric),
        new JdeField("ZBLANO", "ZBLANO", JdeDataType.Numeric),
        new JdeField("ZBANOB", "ZBANOB", JdeDataType.Numeric),
        new JdeField("ZBUSA5", "ZBUSA5", JdeDataType.Numeric),
        new JdeField("ZBVR01", "ZBVR01", JdeDataType.String, 50),
        new JdeField("ZBMINHR", "ZBMINHR", JdeDataType.Numeric),
        new JdeField("ZBMINAD", "ZBMINAD", JdeDataType.Numeric),
        new JdeField("ZBMINAF", "ZBMINAF", JdeDataType.Numeric),
        new JdeField("ZBDSFT", "ZBDSFT", JdeDataType.String, 2),
        new JdeField("ZBDSPC", "ZBDSPC", JdeDataType.Numeric),
        new JdeField("ZBIDSC", "ZBIDSC", JdeDataType.Numeric),
        new JdeField("ZBCIDS", "ZBCIDS", JdeDataType.Numeric),
        new JdeField("ZBITAM", "ZBITAM", JdeDataType.Numeric),
        new JdeField("ZBCITX", "ZBCITX", JdeDataType.Numeric),
        new JdeField("ZBJTAX", "ZBJTAX", JdeDataType.Numeric),
        new JdeField("ZBJTXF", "ZBJTXF", JdeDataType.Numeric),
        new JdeField("ZBAMTCD", "ZBAMTCD", JdeDataType.Numeric),
        new JdeField("ZBAMTCF", "ZBAMTCF", JdeDataType.Numeric),
        new JdeField("ZBATXCD", "ZBATXCD", JdeDataType.Numeric),
        new JdeField("ZBATXCF", "ZBATXCF", JdeDataType.Numeric),
        new JdeField("ZBEFTJ", "ZBEFTJ", JdeDataType.Numeric),
        new JdeField("ZBPTC", "ZBPTC", JdeDataType.String, 6),
        new JdeField("ZBRYIN", "ZBRYIN", JdeDataType.String, 2),
        new JdeField("ZBTAX1", "ZBTAX1", JdeDataType.String, 2),
        new JdeField("ZBTXA1", "ZBTXA1", JdeDataType.String, 20),
        new JdeField("ZBEXR1", "ZBEXR1", JdeDataType.String, 4),
        new JdeField("ZBMTHPR", "ZBMTHPR", JdeDataType.String, 2),
        new JdeField("ZBCRR", "ZBCRR", JdeDataType.Numeric),
        new JdeField("ZBPEFJ", "ZBPEFJ", JdeDataType.Numeric),
        new JdeField("ZBCO", "ZBCO", JdeDataType.String, 10),
        new JdeField("ZBMCU", "ZBMCU", JdeDataType.String, 24),
        new JdeField("ZBDTWRK", "ZBDTWRK", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1760_0", "Primary Key on ZBDOCO, ZBSBLT, ZBLNID", new[] { "ZBDOCO", "ZBSBLT", "ZBLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1760_4", "Index on ZBDOCO, ZBSBLT, ZBAN8", new[] { "ZBDOCO", "ZBSBLT", "ZBAN8" }),
        new JdeIndex("F1760_7", "Index on ZBAN8, ZBDOCO, ZBSBLT, ZBLNID", new[] { "ZBAN8", "ZBDOCO", "ZBSBLT", "ZBLNID" }),
        new JdeIndex("F1760_8", "Index on ZBDOCO, ZBSBLT, ZBDTBIL", new[] { "ZBDOCO", "ZBSBLT", "ZBDTBIL" }),
        new JdeIndex("F1760_9", "Index on ZBDOCO, ZBSBLT, ZBTBDT", new[] { "ZBDOCO", "ZBSBLT", "ZBTBDT" })
    };
}
