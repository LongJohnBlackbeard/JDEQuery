using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C10 - .
/// </summary>
public class F43C10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBCNTRTID.
        /// </summary>
        public const string CBCNTRTID = "CBCNTRTID";

        /// <summary>
        /// CBBLUID.
        /// </summary>
        public const string CBBLUID = "CBBLUID";

        /// <summary>
        /// CBMCU.
        /// </summary>
        public const string CBMCU = "CBMCU";

        /// <summary>
        /// CBCNTRTSD.
        /// </summary>
        public const string CBCNTRTSD = "CBCNTRTSD";

        /// <summary>
        /// CBCNTRTED.
        /// </summary>
        public const string CBCNTRTED = "CBCNTRTED";

        /// <summary>
        /// CBRNWTYPE.
        /// </summary>
        public const string CBRNWTYPE = "CBRNWTYPE";

        /// <summary>
        /// CBRNWEDTE.
        /// </summary>
        public const string CBRNWEDTE = "CBRNWEDTE";

        /// <summary>
        /// CBRNWTRM.
        /// </summary>
        public const string CBRNWTRM = "CBRNWTRM";

        /// <summary>
        /// CBRNWUOM.
        /// </summary>
        public const string CBRNWUOM = "CBRNWUOM";

        /// <summary>
        /// CBCNTRTDF.
        /// </summary>
        public const string CBCNTRTDF = "CBCNTRTDF";

        /// <summary>
        /// CBCMDCDE.
        /// </summary>
        public const string CBCMDCDE = "CBCMDCDE";

        /// <summary>
        /// CBCNTRTQTY.
        /// </summary>
        public const string CBCNTRTQTY = "CBCNTRTQTY";

        /// <summary>
        /// CBUOM.
        /// </summary>
        public const string CBUOM = "CBUOM";

        /// <summary>
        /// CBQCONTROL.
        /// </summary>
        public const string CBQCONTROL = "CBQCONTROL";

        /// <summary>
        /// CBMINQTY.
        /// </summary>
        public const string CBMINQTY = "CBMINQTY";

        /// <summary>
        /// CBMAXQTY.
        /// </summary>
        public const string CBMAXQTY = "CBMAXQTY";

        /// <summary>
        /// CBPTC.
        /// </summary>
        public const string CBPTC = "CBPTC";

        /// <summary>
        /// CBCNTRTPT.
        /// </summary>
        public const string CBCNTRTPT = "CBCNTRTPT";

        /// <summary>
        /// CBUOM3.
        /// </summary>
        public const string CBUOM3 = "CBUOM3";

        /// <summary>
        /// CBPRLEVL.
        /// </summary>
        public const string CBPRLEVL = "CBPRLEVL";

        /// <summary>
        /// CBCNTRPRG.
        /// </summary>
        public const string CBCNTRPRG = "CBCNTRPRG";

        /// <summary>
        /// CBPRICEOVR.
        /// </summary>
        public const string CBPRICEOVR = "CBPRICEOVR";

        /// <summary>
        /// CBOVRCOMM.
        /// </summary>
        public const string CBOVRCOMM = "CBOVRCOMM";

        /// <summary>
        /// CBMINPRICE.
        /// </summary>
        public const string CBMINPRICE = "CBMINPRICE";

        /// <summary>
        /// CBMAXPRICE.
        /// </summary>
        public const string CBMAXPRICE = "CBMAXPRICE";

        /// <summary>
        /// CBMEMPRICE.
        /// </summary>
        public const string CBMEMPRICE = "CBMEMPRICE";

        /// <summary>
        /// CBPRICELVL.
        /// </summary>
        public const string CBPRICELVL = "CBPRICELVL";

        /// <summary>
        /// CBASN.
        /// </summary>
        public const string CBASN = "CBASN";

        /// <summary>
        /// CBCNTRAB01.
        /// </summary>
        public const string CBCNTRAB01 = "CBCNTRAB01";

        /// <summary>
        /// CBCNTRAB02.
        /// </summary>
        public const string CBCNTRAB02 = "CBCNTRAB02";

        /// <summary>
        /// CBCNTRAB03.
        /// </summary>
        public const string CBCNTRAB03 = "CBCNTRAB03";

        /// <summary>
        /// CBCNTRAB04.
        /// </summary>
        public const string CBCNTRAB04 = "CBCNTRAB04";

        /// <summary>
        /// CBCNTRAB05.
        /// </summary>
        public const string CBCNTRAB05 = "CBCNTRAB05";

        /// <summary>
        /// CBCNTRAB06.
        /// </summary>
        public const string CBCNTRAB06 = "CBCNTRAB06";

        /// <summary>
        /// CBCNTRAB07.
        /// </summary>
        public const string CBCNTRAB07 = "CBCNTRAB07";

        /// <summary>
        /// CBCNTRAB08.
        /// </summary>
        public const string CBCNTRAB08 = "CBCNTRAB08";

        /// <summary>
        /// CBCNTRAB09.
        /// </summary>
        public const string CBCNTRAB09 = "CBCNTRAB09";

        /// <summary>
        /// CBCNTRAB10.
        /// </summary>
        public const string CBCNTRAB10 = "CBCNTRAB10";

        /// <summary>
        /// CBCNTRAB11.
        /// </summary>
        public const string CBCNTRAB11 = "CBCNTRAB11";

        /// <summary>
        /// CBCNTRAB12.
        /// </summary>
        public const string CBCNTRAB12 = "CBCNTRAB12";

        /// <summary>
        /// CBCNTRT01.
        /// </summary>
        public const string CBCNTRT01 = "CBCNTRT01";

        /// <summary>
        /// CBCNTRT02.
        /// </summary>
        public const string CBCNTRT02 = "CBCNTRT02";

        /// <summary>
        /// CBCNTRT03.
        /// </summary>
        public const string CBCNTRT03 = "CBCNTRT03";

        /// <summary>
        /// CBCNTRT04.
        /// </summary>
        public const string CBCNTRT04 = "CBCNTRT04";

        /// <summary>
        /// CBCNTRT05.
        /// </summary>
        public const string CBCNTRT05 = "CBCNTRT05";

        /// <summary>
        /// CBCNTRT06.
        /// </summary>
        public const string CBCNTRT06 = "CBCNTRT06";

        /// <summary>
        /// CBCNTRT07.
        /// </summary>
        public const string CBCNTRT07 = "CBCNTRT07";

        /// <summary>
        /// CBCNTRT08.
        /// </summary>
        public const string CBCNTRT08 = "CBCNTRT08";

        /// <summary>
        /// CBCNTRT09.
        /// </summary>
        public const string CBCNTRT09 = "CBCNTRT09";

        /// <summary>
        /// CBCNTRT10.
        /// </summary>
        public const string CBCNTRT10 = "CBCNTRT10";

        /// <summary>
        /// CBCNTRT11.
        /// </summary>
        public const string CBCNTRT11 = "CBCNTRT11";

        /// <summary>
        /// CBCNTRT12.
        /// </summary>
        public const string CBCNTRT12 = "CBCNTRT12";

        /// <summary>
        /// CBCNTRT13.
        /// </summary>
        public const string CBCNTRT13 = "CBCNTRT13";

        /// <summary>
        /// CBCNTRT14.
        /// </summary>
        public const string CBCNTRT14 = "CBCNTRT14";

        /// <summary>
        /// CBCNTRT15.
        /// </summary>
        public const string CBCNTRT15 = "CBCNTRT15";

        /// <summary>
        /// CBCNTRTDT1.
        /// </summary>
        public const string CBCNTRTDT1 = "CBCNTRTDT1";

        /// <summary>
        /// CBCNTRTDT2.
        /// </summary>
        public const string CBCNTRTDT2 = "CBCNTRTDT2";

        /// <summary>
        /// CBCNTRTDT3.
        /// </summary>
        public const string CBCNTRTDT3 = "CBCNTRTDT3";

        /// <summary>
        /// CBCNTRTDT4.
        /// </summary>
        public const string CBCNTRTDT4 = "CBCNTRTDT4";

        /// <summary>
        /// CBCNTRTDT5.
        /// </summary>
        public const string CBCNTRTDT5 = "CBCNTRTDT5";

        /// <summary>
        /// CBCNTRTDT6.
        /// </summary>
        public const string CBCNTRTDT6 = "CBCNTRTDT6";

        /// <summary>
        /// CBCNTRPT01.
        /// </summary>
        public const string CBCNTRPT01 = "CBCNTRPT01";

        /// <summary>
        /// CBCNTRPT02.
        /// </summary>
        public const string CBCNTRPT02 = "CBCNTRPT02";

        /// <summary>
        /// CBCNTRPT03.
        /// </summary>
        public const string CBCNTRPT03 = "CBCNTRPT03";

        /// <summary>
        /// CBCNTRPT04.
        /// </summary>
        public const string CBCNTRPT04 = "CBCNTRPT04";

        /// <summary>
        /// CBCNTRPT05.
        /// </summary>
        public const string CBCNTRPT05 = "CBCNTRPT05";

        /// <summary>
        /// CBCNTRPT06.
        /// </summary>
        public const string CBCNTRPT06 = "CBCNTRPT06";

        /// <summary>
        /// CBURCD.
        /// </summary>
        public const string CBURCD = "CBURCD";

        /// <summary>
        /// CBURDT.
        /// </summary>
        public const string CBURDT = "CBURDT";

        /// <summary>
        /// CBURAT.
        /// </summary>
        public const string CBURAT = "CBURAT";

        /// <summary>
        /// CBURAB.
        /// </summary>
        public const string CBURAB = "CBURAB";

        /// <summary>
        /// CBURRF.
        /// </summary>
        public const string CBURRF = "CBURRF";

        /// <summary>
        /// CBTORG.
        /// </summary>
        public const string CBTORG = "CBTORG";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBJOBN.
        /// </summary>
        public const string CBJOBN = "CBJOBN";

        /// <summary>
        /// CBUUPMJ.
        /// </summary>
        public const string CBUUPMJ = "CBUUPMJ";

        /// <summary>
        /// CBITM.
        /// </summary>
        public const string CBITM = "CBITM";

        /// <summary>
        /// CBLITM.
        /// </summary>
        public const string CBLITM = "CBLITM";

        /// <summary>
        /// CBAITM.
        /// </summary>
        public const string CBAITM = "CBAITM";

        /// <summary>
        /// CBPOPPOOL.
        /// </summary>
        public const string CBPOPPOOL = "CBPOPPOOL";

        /// <summary>
        /// CBGEQTYP.
        /// </summary>
        public const string CBGEQTYP = "CBGEQTYP";

        /// <summary>
        /// CBGEQPCT.
        /// </summary>
        public const string CBGEQPCT = "CBGEQPCT";

        /// <summary>
        /// CBPOPASN.
        /// </summary>
        public const string CBPOPASN = "CBPOPASN";

        /// <summary>
        /// CBPOPPTC.
        /// </summary>
        public const string CBPOPPTC = "CBPOPPTC";
    }

    /// <inheritdoc />
    public override string TableName => "F43C10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBCNTRTID", "CBCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CBBLUID", "CBBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("CBMCU", "CBMCU", JdeDataType.String, 24),
        new JdeField("CBCNTRTSD", "CBCNTRTSD", JdeDataType.Date),
        new JdeField("CBCNTRTED", "CBCNTRTED", JdeDataType.Date),
        new JdeField("CBRNWTYPE", "CBRNWTYPE", JdeDataType.String, 6),
        new JdeField("CBRNWEDTE", "CBRNWEDTE", JdeDataType.Date),
        new JdeField("CBRNWTRM", "CBRNWTRM", JdeDataType.Numeric),
        new JdeField("CBRNWUOM", "CBRNWUOM", JdeDataType.String, 6),
        new JdeField("CBCNTRTDF", "CBCNTRTDF", JdeDataType.String, 6),
        new JdeField("CBCMDCDE", "CBCMDCDE", JdeDataType.String, 30),
        new JdeField("CBCNTRTQTY", "CBCNTRTQTY", JdeDataType.Numeric),
        new JdeField("CBUOM", "CBUOM", JdeDataType.String, 4),
        new JdeField("CBQCONTROL", "CBQCONTROL", JdeDataType.String, 2),
        new JdeField("CBMINQTY", "CBMINQTY", JdeDataType.Numeric),
        new JdeField("CBMAXQTY", "CBMAXQTY", JdeDataType.Numeric),
        new JdeField("CBPTC", "CBPTC", JdeDataType.String, 6),
        new JdeField("CBCNTRTPT", "CBCNTRTPT", JdeDataType.String, 6),
        new JdeField("CBUOM3", "CBUOM3", JdeDataType.String, 4),
        new JdeField("CBPRLEVL", "CBPRLEVL", JdeDataType.String, 20),
        new JdeField("CBCNTRPRG", "CBCNTRPRG", JdeDataType.String, 16),
        new JdeField("CBPRICEOVR", "CBPRICEOVR", JdeDataType.Numeric),
        new JdeField("CBOVRCOMM", "CBOVRCOMM", JdeDataType.String, 60),
        new JdeField("CBMINPRICE", "CBMINPRICE", JdeDataType.Numeric),
        new JdeField("CBMAXPRICE", "CBMAXPRICE", JdeDataType.Numeric),
        new JdeField("CBMEMPRICE", "CBMEMPRICE", JdeDataType.Numeric),
        new JdeField("CBPRICELVL", "CBPRICELVL", JdeDataType.String, 20),
        new JdeField("CBASN", "CBASN", JdeDataType.String, 16),
        new JdeField("CBCNTRAB01", "CBCNTRAB01", JdeDataType.Numeric),
        new JdeField("CBCNTRAB02", "CBCNTRAB02", JdeDataType.Numeric),
        new JdeField("CBCNTRAB03", "CBCNTRAB03", JdeDataType.Numeric),
        new JdeField("CBCNTRAB04", "CBCNTRAB04", JdeDataType.Numeric),
        new JdeField("CBCNTRAB05", "CBCNTRAB05", JdeDataType.Numeric),
        new JdeField("CBCNTRAB06", "CBCNTRAB06", JdeDataType.Numeric),
        new JdeField("CBCNTRAB07", "CBCNTRAB07", JdeDataType.Numeric),
        new JdeField("CBCNTRAB08", "CBCNTRAB08", JdeDataType.Numeric),
        new JdeField("CBCNTRAB09", "CBCNTRAB09", JdeDataType.Numeric),
        new JdeField("CBCNTRAB10", "CBCNTRAB10", JdeDataType.Numeric),
        new JdeField("CBCNTRAB11", "CBCNTRAB11", JdeDataType.Numeric),
        new JdeField("CBCNTRAB12", "CBCNTRAB12", JdeDataType.Numeric),
        new JdeField("CBCNTRT01", "CBCNTRT01", JdeDataType.String, 6),
        new JdeField("CBCNTRT02", "CBCNTRT02", JdeDataType.String, 6),
        new JdeField("CBCNTRT03", "CBCNTRT03", JdeDataType.String, 6),
        new JdeField("CBCNTRT04", "CBCNTRT04", JdeDataType.String, 6),
        new JdeField("CBCNTRT05", "CBCNTRT05", JdeDataType.String, 6),
        new JdeField("CBCNTRT06", "CBCNTRT06", JdeDataType.String, 16),
        new JdeField("CBCNTRT07", "CBCNTRT07", JdeDataType.String, 16),
        new JdeField("CBCNTRT08", "CBCNTRT08", JdeDataType.String, 16),
        new JdeField("CBCNTRT09", "CBCNTRT09", JdeDataType.String, 16),
        new JdeField("CBCNTRT10", "CBCNTRT10", JdeDataType.String, 16),
        new JdeField("CBCNTRT11", "CBCNTRT11", JdeDataType.String, 20),
        new JdeField("CBCNTRT12", "CBCNTRT12", JdeDataType.String, 20),
        new JdeField("CBCNTRT13", "CBCNTRT13", JdeDataType.String, 20),
        new JdeField("CBCNTRT14", "CBCNTRT14", JdeDataType.String, 20),
        new JdeField("CBCNTRT15", "CBCNTRT15", JdeDataType.String, 20),
        new JdeField("CBCNTRTDT1", "CBCNTRTDT1", JdeDataType.Numeric),
        new JdeField("CBCNTRTDT2", "CBCNTRTDT2", JdeDataType.Numeric),
        new JdeField("CBCNTRTDT3", "CBCNTRTDT3", JdeDataType.Numeric),
        new JdeField("CBCNTRTDT4", "CBCNTRTDT4", JdeDataType.Numeric),
        new JdeField("CBCNTRTDT5", "CBCNTRTDT5", JdeDataType.Numeric),
        new JdeField("CBCNTRTDT6", "CBCNTRTDT6", JdeDataType.Numeric),
        new JdeField("CBCNTRPT01", "CBCNTRPT01", JdeDataType.String, 2),
        new JdeField("CBCNTRPT02", "CBCNTRPT02", JdeDataType.String, 2),
        new JdeField("CBCNTRPT03", "CBCNTRPT03", JdeDataType.String, 2),
        new JdeField("CBCNTRPT04", "CBCNTRPT04", JdeDataType.String, 2),
        new JdeField("CBCNTRPT05", "CBCNTRPT05", JdeDataType.String, 2),
        new JdeField("CBCNTRPT06", "CBCNTRPT06", JdeDataType.String, 2),
        new JdeField("CBURCD", "CBURCD", JdeDataType.String, 4),
        new JdeField("CBURDT", "CBURDT", JdeDataType.Numeric),
        new JdeField("CBURAT", "CBURAT", JdeDataType.Numeric),
        new JdeField("CBURAB", "CBURAB", JdeDataType.Numeric),
        new JdeField("CBURRF", "CBURRF", JdeDataType.String, 30),
        new JdeField("CBTORG", "CBTORG", JdeDataType.String, 20),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20),
        new JdeField("CBUUPMJ", "CBUUPMJ", JdeDataType.Date),
        new JdeField("CBITM", "CBITM", JdeDataType.Numeric),
        new JdeField("CBLITM", "CBLITM", JdeDataType.String, 50),
        new JdeField("CBAITM", "CBAITM", JdeDataType.String, 50),
        new JdeField("CBPOPPOOL", "CBPOPPOOL", JdeDataType.String, 16),
        new JdeField("CBGEQTYP", "CBGEQTYP", JdeDataType.String, 16),
        new JdeField("CBGEQPCT", "CBGEQPCT", JdeDataType.Numeric),
        new JdeField("CBPOPASN", "CBPOPASN", JdeDataType.String, 16),
        new JdeField("CBPOPPTC", "CBPOPPTC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C10_0", "Primary Key on CBCNTRTID, CBBLUID", new[] { "CBCNTRTID", "CBBLUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C10_2", "Index on CBBLUID", new[] { "CBBLUID" }),
        new JdeIndex("F43C10_3", "Index on CBCNTRTID", new[] { "CBCNTRTID" })
    };
}
