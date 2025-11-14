using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C11 - .
/// </summary>
public class F43C11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDCNTRTID.
        /// </summary>
        public const string CDCNTRTID = "CDCNTRTID";

        /// <summary>
        /// CDCNTRTDID.
        /// </summary>
        public const string CDCNTRTDID = "CDCNTRTDID";

        /// <summary>
        /// CDBLUID.
        /// </summary>
        public const string CDBLUID = "CDBLUID";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDLITM.
        /// </summary>
        public const string CDLITM = "CDLITM";

        /// <summary>
        /// CDAITM.
        /// </summary>
        public const string CDAITM = "CDAITM";

        /// <summary>
        /// CDCNTRTSD.
        /// </summary>
        public const string CDCNTRTSD = "CDCNTRTSD";

        /// <summary>
        /// CDCNTRTED.
        /// </summary>
        public const string CDCNTRTED = "CDCNTRTED";

        /// <summary>
        /// CDRNWSTE.
        /// </summary>
        public const string CDRNWSTE = "CDRNWSTE";

        /// <summary>
        /// CDCNTRTDF.
        /// </summary>
        public const string CDCNTRTDF = "CDCNTRTDF";

        /// <summary>
        /// CDCMDCDE.
        /// </summary>
        public const string CDCMDCDE = "CDCMDCDE";

        /// <summary>
        /// CDCNTRTQTY.
        /// </summary>
        public const string CDCNTRTQTY = "CDCNTRTQTY";

        /// <summary>
        /// CDUOM.
        /// </summary>
        public const string CDUOM = "CDUOM";

        /// <summary>
        /// CDQCONTROL.
        /// </summary>
        public const string CDQCONTROL = "CDQCONTROL";

        /// <summary>
        /// CDMINQTY.
        /// </summary>
        public const string CDMINQTY = "CDMINQTY";

        /// <summary>
        /// CDMAXQTY.
        /// </summary>
        public const string CDMAXQTY = "CDMAXQTY";

        /// <summary>
        /// CDPRICEAPP.
        /// </summary>
        public const string CDPRICEAPP = "CDPRICEAPP";

        /// <summary>
        /// CDCNTRTPT.
        /// </summary>
        public const string CDCNTRTPT = "CDCNTRTPT";

        /// <summary>
        /// CDUOM3.
        /// </summary>
        public const string CDUOM3 = "CDUOM3";

        /// <summary>
        /// CDPRLEVL.
        /// </summary>
        public const string CDPRLEVL = "CDPRLEVL";

        /// <summary>
        /// CDCNTRPRG.
        /// </summary>
        public const string CDCNTRPRG = "CDCNTRPRG";

        /// <summary>
        /// CDPRICEOVR.
        /// </summary>
        public const string CDPRICEOVR = "CDPRICEOVR";

        /// <summary>
        /// CDOVRCOMM.
        /// </summary>
        public const string CDOVRCOMM = "CDOVRCOMM";

        /// <summary>
        /// CDMINPRICE.
        /// </summary>
        public const string CDMINPRICE = "CDMINPRICE";

        /// <summary>
        /// CDMAXPRICE.
        /// </summary>
        public const string CDMAXPRICE = "CDMAXPRICE";

        /// <summary>
        /// CDMEMPRICE.
        /// </summary>
        public const string CDMEMPRICE = "CDMEMPRICE";

        /// <summary>
        /// CDPRICELVL.
        /// </summary>
        public const string CDPRICELVL = "CDPRICELVL";

        /// <summary>
        /// CDPTC.
        /// </summary>
        public const string CDPTC = "CDPTC";

        /// <summary>
        /// CDASN.
        /// </summary>
        public const string CDASN = "CDASN";

        /// <summary>
        /// CDWVID.
        /// </summary>
        public const string CDWVID = "CDWVID";

        /// <summary>
        /// CDELADV.
        /// </summary>
        public const string CDELADV = "CDELADV";

        /// <summary>
        /// CDFLPD.
        /// </summary>
        public const string CDFLPD = "CDFLPD";

        /// <summary>
        /// CDCNTRAB01.
        /// </summary>
        public const string CDCNTRAB01 = "CDCNTRAB01";

        /// <summary>
        /// CDCNTRAB02.
        /// </summary>
        public const string CDCNTRAB02 = "CDCNTRAB02";

        /// <summary>
        /// CDCNTRAB03.
        /// </summary>
        public const string CDCNTRAB03 = "CDCNTRAB03";

        /// <summary>
        /// CDCNTRAB04.
        /// </summary>
        public const string CDCNTRAB04 = "CDCNTRAB04";

        /// <summary>
        /// CDCNTRAB05.
        /// </summary>
        public const string CDCNTRAB05 = "CDCNTRAB05";

        /// <summary>
        /// CDCNTRAB06.
        /// </summary>
        public const string CDCNTRAB06 = "CDCNTRAB06";

        /// <summary>
        /// CDCNTRAB07.
        /// </summary>
        public const string CDCNTRAB07 = "CDCNTRAB07";

        /// <summary>
        /// CDCNTRAB08.
        /// </summary>
        public const string CDCNTRAB08 = "CDCNTRAB08";

        /// <summary>
        /// CDCNTRAB09.
        /// </summary>
        public const string CDCNTRAB09 = "CDCNTRAB09";

        /// <summary>
        /// CDCNTRAB10.
        /// </summary>
        public const string CDCNTRAB10 = "CDCNTRAB10";

        /// <summary>
        /// CDCNTRAB11.
        /// </summary>
        public const string CDCNTRAB11 = "CDCNTRAB11";

        /// <summary>
        /// CDCNTRAB12.
        /// </summary>
        public const string CDCNTRAB12 = "CDCNTRAB12";

        /// <summary>
        /// CDCNTRT01.
        /// </summary>
        public const string CDCNTRT01 = "CDCNTRT01";

        /// <summary>
        /// CDCNTRT02.
        /// </summary>
        public const string CDCNTRT02 = "CDCNTRT02";

        /// <summary>
        /// CDCNTRT03.
        /// </summary>
        public const string CDCNTRT03 = "CDCNTRT03";

        /// <summary>
        /// CDCNTRT04.
        /// </summary>
        public const string CDCNTRT04 = "CDCNTRT04";

        /// <summary>
        /// CDCNTRT05.
        /// </summary>
        public const string CDCNTRT05 = "CDCNTRT05";

        /// <summary>
        /// CDCNTRT06.
        /// </summary>
        public const string CDCNTRT06 = "CDCNTRT06";

        /// <summary>
        /// CDCNTRT07.
        /// </summary>
        public const string CDCNTRT07 = "CDCNTRT07";

        /// <summary>
        /// CDCNTRT08.
        /// </summary>
        public const string CDCNTRT08 = "CDCNTRT08";

        /// <summary>
        /// CDCNTRT09.
        /// </summary>
        public const string CDCNTRT09 = "CDCNTRT09";

        /// <summary>
        /// CDCNTRT10.
        /// </summary>
        public const string CDCNTRT10 = "CDCNTRT10";

        /// <summary>
        /// CDCNTRT11.
        /// </summary>
        public const string CDCNTRT11 = "CDCNTRT11";

        /// <summary>
        /// CDCNTRT12.
        /// </summary>
        public const string CDCNTRT12 = "CDCNTRT12";

        /// <summary>
        /// CDCNTRT13.
        /// </summary>
        public const string CDCNTRT13 = "CDCNTRT13";

        /// <summary>
        /// CDCNTRT14.
        /// </summary>
        public const string CDCNTRT14 = "CDCNTRT14";

        /// <summary>
        /// CDCNTRT15.
        /// </summary>
        public const string CDCNTRT15 = "CDCNTRT15";

        /// <summary>
        /// CDCNTRTDT1.
        /// </summary>
        public const string CDCNTRTDT1 = "CDCNTRTDT1";

        /// <summary>
        /// CDCNTRTDT2.
        /// </summary>
        public const string CDCNTRTDT2 = "CDCNTRTDT2";

        /// <summary>
        /// CDCNTRTDT3.
        /// </summary>
        public const string CDCNTRTDT3 = "CDCNTRTDT3";

        /// <summary>
        /// CDCNTRTDT4.
        /// </summary>
        public const string CDCNTRTDT4 = "CDCNTRTDT4";

        /// <summary>
        /// CDCNTRTDT5.
        /// </summary>
        public const string CDCNTRTDT5 = "CDCNTRTDT5";

        /// <summary>
        /// CDCNTRTDT6.
        /// </summary>
        public const string CDCNTRTDT6 = "CDCNTRTDT6";

        /// <summary>
        /// CDCNTRPT01.
        /// </summary>
        public const string CDCNTRPT01 = "CDCNTRPT01";

        /// <summary>
        /// CDCNTRPT02.
        /// </summary>
        public const string CDCNTRPT02 = "CDCNTRPT02";

        /// <summary>
        /// CDCNTRPT03.
        /// </summary>
        public const string CDCNTRPT03 = "CDCNTRPT03";

        /// <summary>
        /// CDCNTRPT04.
        /// </summary>
        public const string CDCNTRPT04 = "CDCNTRPT04";

        /// <summary>
        /// CDCNTRPT05.
        /// </summary>
        public const string CDCNTRPT05 = "CDCNTRPT05";

        /// <summary>
        /// CDCNTRPT06.
        /// </summary>
        public const string CDCNTRPT06 = "CDCNTRPT06";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CDTORG.
        /// </summary>
        public const string CDTORG = "CDTORG";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUUPMJ.
        /// </summary>
        public const string CDUUPMJ = "CDUUPMJ";

        /// <summary>
        /// CDPOPPOOL.
        /// </summary>
        public const string CDPOPPOOL = "CDPOPPOOL";

        /// <summary>
        /// CDGEQTYP.
        /// </summary>
        public const string CDGEQTYP = "CDGEQTYP";

        /// <summary>
        /// CDGEQPCT.
        /// </summary>
        public const string CDGEQPCT = "CDGEQPCT";

        /// <summary>
        /// CDPOPASN.
        /// </summary>
        public const string CDPOPASN = "CDPOPASN";

        /// <summary>
        /// CDPOPPTC.
        /// </summary>
        public const string CDPOPPTC = "CDPOPPTC";
    }

    /// <inheritdoc />
    public override string TableName => "F43C11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDCNTRTID", "CDCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCNTRTDID", "CDCNTRTDID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDBLUID", "CDBLUID", JdeDataType.Numeric),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDLITM", "CDLITM", JdeDataType.String, 50),
        new JdeField("CDAITM", "CDAITM", JdeDataType.String, 50),
        new JdeField("CDCNTRTSD", "CDCNTRTSD", JdeDataType.Date),
        new JdeField("CDCNTRTED", "CDCNTRTED", JdeDataType.Date),
        new JdeField("CDRNWSTE", "CDRNWSTE", JdeDataType.String, 6),
        new JdeField("CDCNTRTDF", "CDCNTRTDF", JdeDataType.String, 6),
        new JdeField("CDCMDCDE", "CDCMDCDE", JdeDataType.String, 30),
        new JdeField("CDCNTRTQTY", "CDCNTRTQTY", JdeDataType.Numeric),
        new JdeField("CDUOM", "CDUOM", JdeDataType.String, 4),
        new JdeField("CDQCONTROL", "CDQCONTROL", JdeDataType.String, 2),
        new JdeField("CDMINQTY", "CDMINQTY", JdeDataType.Numeric),
        new JdeField("CDMAXQTY", "CDMAXQTY", JdeDataType.Numeric),
        new JdeField("CDPRICEAPP", "CDPRICEAPP", JdeDataType.String, 2),
        new JdeField("CDCNTRTPT", "CDCNTRTPT", JdeDataType.String, 6),
        new JdeField("CDUOM3", "CDUOM3", JdeDataType.String, 4),
        new JdeField("CDPRLEVL", "CDPRLEVL", JdeDataType.String, 20),
        new JdeField("CDCNTRPRG", "CDCNTRPRG", JdeDataType.String, 16),
        new JdeField("CDPRICEOVR", "CDPRICEOVR", JdeDataType.Numeric),
        new JdeField("CDOVRCOMM", "CDOVRCOMM", JdeDataType.String, 60),
        new JdeField("CDMINPRICE", "CDMINPRICE", JdeDataType.Numeric),
        new JdeField("CDMAXPRICE", "CDMAXPRICE", JdeDataType.Numeric),
        new JdeField("CDMEMPRICE", "CDMEMPRICE", JdeDataType.Numeric),
        new JdeField("CDPRICELVL", "CDPRICELVL", JdeDataType.String, 20),
        new JdeField("CDPTC", "CDPTC", JdeDataType.String, 6),
        new JdeField("CDASN", "CDASN", JdeDataType.String, 16),
        new JdeField("CDWVID", "CDWVID", JdeDataType.Numeric),
        new JdeField("CDELADV", "CDELADV", JdeDataType.String, 2),
        new JdeField("CDFLPD", "CDFLPD", JdeDataType.String, 2),
        new JdeField("CDCNTRAB01", "CDCNTRAB01", JdeDataType.Numeric),
        new JdeField("CDCNTRAB02", "CDCNTRAB02", JdeDataType.Numeric),
        new JdeField("CDCNTRAB03", "CDCNTRAB03", JdeDataType.Numeric),
        new JdeField("CDCNTRAB04", "CDCNTRAB04", JdeDataType.Numeric),
        new JdeField("CDCNTRAB05", "CDCNTRAB05", JdeDataType.Numeric),
        new JdeField("CDCNTRAB06", "CDCNTRAB06", JdeDataType.Numeric),
        new JdeField("CDCNTRAB07", "CDCNTRAB07", JdeDataType.Numeric),
        new JdeField("CDCNTRAB08", "CDCNTRAB08", JdeDataType.Numeric),
        new JdeField("CDCNTRAB09", "CDCNTRAB09", JdeDataType.Numeric),
        new JdeField("CDCNTRAB10", "CDCNTRAB10", JdeDataType.Numeric),
        new JdeField("CDCNTRAB11", "CDCNTRAB11", JdeDataType.Numeric),
        new JdeField("CDCNTRAB12", "CDCNTRAB12", JdeDataType.Numeric),
        new JdeField("CDCNTRT01", "CDCNTRT01", JdeDataType.String, 6),
        new JdeField("CDCNTRT02", "CDCNTRT02", JdeDataType.String, 6),
        new JdeField("CDCNTRT03", "CDCNTRT03", JdeDataType.String, 6),
        new JdeField("CDCNTRT04", "CDCNTRT04", JdeDataType.String, 6),
        new JdeField("CDCNTRT05", "CDCNTRT05", JdeDataType.String, 6),
        new JdeField("CDCNTRT06", "CDCNTRT06", JdeDataType.String, 16),
        new JdeField("CDCNTRT07", "CDCNTRT07", JdeDataType.String, 16),
        new JdeField("CDCNTRT08", "CDCNTRT08", JdeDataType.String, 16),
        new JdeField("CDCNTRT09", "CDCNTRT09", JdeDataType.String, 16),
        new JdeField("CDCNTRT10", "CDCNTRT10", JdeDataType.String, 16),
        new JdeField("CDCNTRT11", "CDCNTRT11", JdeDataType.String, 20),
        new JdeField("CDCNTRT12", "CDCNTRT12", JdeDataType.String, 20),
        new JdeField("CDCNTRT13", "CDCNTRT13", JdeDataType.String, 20),
        new JdeField("CDCNTRT14", "CDCNTRT14", JdeDataType.String, 20),
        new JdeField("CDCNTRT15", "CDCNTRT15", JdeDataType.String, 20),
        new JdeField("CDCNTRTDT1", "CDCNTRTDT1", JdeDataType.Numeric),
        new JdeField("CDCNTRTDT2", "CDCNTRTDT2", JdeDataType.Numeric),
        new JdeField("CDCNTRTDT3", "CDCNTRTDT3", JdeDataType.Numeric),
        new JdeField("CDCNTRTDT4", "CDCNTRTDT4", JdeDataType.Numeric),
        new JdeField("CDCNTRTDT5", "CDCNTRTDT5", JdeDataType.Numeric),
        new JdeField("CDCNTRTDT6", "CDCNTRTDT6", JdeDataType.Numeric),
        new JdeField("CDCNTRPT01", "CDCNTRPT01", JdeDataType.String, 2),
        new JdeField("CDCNTRPT02", "CDCNTRPT02", JdeDataType.String, 2),
        new JdeField("CDCNTRPT03", "CDCNTRPT03", JdeDataType.String, 2),
        new JdeField("CDCNTRPT04", "CDCNTRPT04", JdeDataType.String, 2),
        new JdeField("CDCNTRPT05", "CDCNTRPT05", JdeDataType.String, 2),
        new JdeField("CDCNTRPT06", "CDCNTRPT06", JdeDataType.String, 2),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDTORG", "CDTORG", JdeDataType.String, 20),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUUPMJ", "CDUUPMJ", JdeDataType.Date),
        new JdeField("CDPOPPOOL", "CDPOPPOOL", JdeDataType.String, 16),
        new JdeField("CDGEQTYP", "CDGEQTYP", JdeDataType.String, 16),
        new JdeField("CDGEQPCT", "CDGEQPCT", JdeDataType.Numeric),
        new JdeField("CDPOPASN", "CDPOPASN", JdeDataType.String, 16),
        new JdeField("CDPOPPTC", "CDPOPPTC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C11_0", "Primary Key on CDCNTRTID, CDCNTRTDID", new[] { "CDCNTRTID", "CDCNTRTDID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C11_2", "Index on CDBLUID, CDCNTRTID", new[] { "CDBLUID", "CDCNTRTID" }),
        new JdeIndex("F43C11_3", "Index on CDWVID", new[] { "CDWVID" })
    };
}
