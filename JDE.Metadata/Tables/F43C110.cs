using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C110 - .
/// </summary>
public class F43C110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPCHPRID.
        /// </summary>
        public const string DPCHPRID = "DPCHPRID";

        /// <summary>
        /// DPCHPRDES.
        /// </summary>
        public const string DPCHPRDES = "DPCHPRDES";

        /// <summary>
        /// DPUCNTPT.
        /// </summary>
        public const string DPUCNTPT = "DPUCNTPT";

        /// <summary>
        /// DPCNTRTPT.
        /// </summary>
        public const string DPCNTRTPT = "DPCNTRTPT";

        /// <summary>
        /// DPUCNTDF.
        /// </summary>
        public const string DPUCNTDF = "DPUCNTDF";

        /// <summary>
        /// DPCNTRTDF.
        /// </summary>
        public const string DPCNTRTDF = "DPCNTRTDF";

        /// <summary>
        /// DPUCNTCC.
        /// </summary>
        public const string DPUCNTCC = "DPUCNTCC";

        /// <summary>
        /// DPCMDCDE.
        /// </summary>
        public const string DPCMDCDE = "DPCMDCDE";

        /// <summary>
        /// DPUCQTY.
        /// </summary>
        public const string DPUCQTY = "DPUCQTY";

        /// <summary>
        /// DPCNTRTQTY.
        /// </summary>
        public const string DPCNTRTQTY = "DPCNTRTQTY";

        /// <summary>
        /// DPUTUOM.
        /// </summary>
        public const string DPUTUOM = "DPUTUOM";

        /// <summary>
        /// DPUOM.
        /// </summary>
        public const string DPUOM = "DPUOM";

        /// <summary>
        /// DPUDISOR.
        /// </summary>
        public const string DPUDISOR = "DPUDISOR";

        /// <summary>
        /// DPQCONTROL.
        /// </summary>
        public const string DPQCONTROL = "DPQCONTROL";

        /// <summary>
        /// DPUMINQTY.
        /// </summary>
        public const string DPUMINQTY = "DPUMINQTY";

        /// <summary>
        /// DPMINQTY.
        /// </summary>
        public const string DPMINQTY = "DPMINQTY";

        /// <summary>
        /// DPUMAXQTY.
        /// </summary>
        public const string DPUMAXQTY = "DPUMAXQTY";

        /// <summary>
        /// DPMAXQTY.
        /// </summary>
        public const string DPMAXQTY = "DPMAXQTY";

        /// <summary>
        /// DPUPUOM.
        /// </summary>
        public const string DPUPUOM = "DPUPUOM";

        /// <summary>
        /// DPUOM3.
        /// </summary>
        public const string DPUOM3 = "DPUOM3";

        /// <summary>
        /// DPUPRCAPP.
        /// </summary>
        public const string DPUPRCAPP = "DPUPRCAPP";

        /// <summary>
        /// DPPRICEAPP.
        /// </summary>
        public const string DPPRICEAPP = "DPPRICEAPP";

        /// <summary>
        /// DPUCNTRTPL.
        /// </summary>
        public const string DPUCNTRTPL = "DPUCNTRTPL";

        /// <summary>
        /// DPPRLEVL.
        /// </summary>
        public const string DPPRLEVL = "DPPRLEVL";

        /// <summary>
        /// DPUCPG.
        /// </summary>
        public const string DPUCPG = "DPUCPG";

        /// <summary>
        /// DPCNTRPRG.
        /// </summary>
        public const string DPCNTRPRG = "DPCNTRPRG";

        /// <summary>
        /// DPUPRICOVR.
        /// </summary>
        public const string DPUPRICOVR = "DPUPRICOVR";

        /// <summary>
        /// DPPRICEOVR.
        /// </summary>
        public const string DPPRICEOVR = "DPPRICEOVR";

        /// <summary>
        /// DPUPOCOM.
        /// </summary>
        public const string DPUPOCOM = "DPUPOCOM";

        /// <summary>
        /// DPOVRCOMM.
        /// </summary>
        public const string DPOVRCOMM = "DPOVRCOMM";

        /// <summary>
        /// DPUMINPRC.
        /// </summary>
        public const string DPUMINPRC = "DPUMINPRC";

        /// <summary>
        /// DPMINPRICE.
        /// </summary>
        public const string DPMINPRICE = "DPMINPRICE";

        /// <summary>
        /// DPUMAXPRC.
        /// </summary>
        public const string DPUMAXPRC = "DPUMAXPRC";

        /// <summary>
        /// DPMAXPRICE.
        /// </summary>
        public const string DPMAXPRICE = "DPMAXPRICE";

        /// <summary>
        /// DPUMP.
        /// </summary>
        public const string DPUMP = "DPUMP";

        /// <summary>
        /// DPMEMPRICE.
        /// </summary>
        public const string DPMEMPRICE = "DPMEMPRICE";

        /// <summary>
        /// DPUMPL.
        /// </summary>
        public const string DPUMPL = "DPUMPL";

        /// <summary>
        /// DPPRICELVL.
        /// </summary>
        public const string DPPRICELVL = "DPPRICELVL";

        /// <summary>
        /// DPUPRCADJ.
        /// </summary>
        public const string DPUPRCADJ = "DPUPRCADJ";

        /// <summary>
        /// DPASN.
        /// </summary>
        public const string DPASN = "DPASN";

        /// <summary>
        /// DPCLSID.
        /// </summary>
        public const string DPCLSID = "DPCLSID";

        /// <summary>
        /// DPUCNTAB01.
        /// </summary>
        public const string DPUCNTAB01 = "DPUCNTAB01";

        /// <summary>
        /// DPCNTRAB01.
        /// </summary>
        public const string DPCNTRAB01 = "DPCNTRAB01";

        /// <summary>
        /// DPUCNTAB02.
        /// </summary>
        public const string DPUCNTAB02 = "DPUCNTAB02";

        /// <summary>
        /// DPCNTRAB02.
        /// </summary>
        public const string DPCNTRAB02 = "DPCNTRAB02";

        /// <summary>
        /// DPUCNTAB03.
        /// </summary>
        public const string DPUCNTAB03 = "DPUCNTAB03";

        /// <summary>
        /// DPCNTRAB03.
        /// </summary>
        public const string DPCNTRAB03 = "DPCNTRAB03";

        /// <summary>
        /// DPUCNTAB04.
        /// </summary>
        public const string DPUCNTAB04 = "DPUCNTAB04";

        /// <summary>
        /// DPCNTRAB04.
        /// </summary>
        public const string DPCNTRAB04 = "DPCNTRAB04";

        /// <summary>
        /// DPUCNTAB05.
        /// </summary>
        public const string DPUCNTAB05 = "DPUCNTAB05";

        /// <summary>
        /// DPCNTRAB05.
        /// </summary>
        public const string DPCNTRAB05 = "DPCNTRAB05";

        /// <summary>
        /// DPUCNTAB06.
        /// </summary>
        public const string DPUCNTAB06 = "DPUCNTAB06";

        /// <summary>
        /// DPCNTRAB06.
        /// </summary>
        public const string DPCNTRAB06 = "DPCNTRAB06";

        /// <summary>
        /// DPUCNTAB07.
        /// </summary>
        public const string DPUCNTAB07 = "DPUCNTAB07";

        /// <summary>
        /// DPCNTRAB07.
        /// </summary>
        public const string DPCNTRAB07 = "DPCNTRAB07";

        /// <summary>
        /// DPUCNTAB08.
        /// </summary>
        public const string DPUCNTAB08 = "DPUCNTAB08";

        /// <summary>
        /// DPCNTRAB08.
        /// </summary>
        public const string DPCNTRAB08 = "DPCNTRAB08";

        /// <summary>
        /// DPUCNTAB09.
        /// </summary>
        public const string DPUCNTAB09 = "DPUCNTAB09";

        /// <summary>
        /// DPCNTRAB09.
        /// </summary>
        public const string DPCNTRAB09 = "DPCNTRAB09";

        /// <summary>
        /// DPUCNTAB10.
        /// </summary>
        public const string DPUCNTAB10 = "DPUCNTAB10";

        /// <summary>
        /// DPCNTRAB10.
        /// </summary>
        public const string DPCNTRAB10 = "DPCNTRAB10";

        /// <summary>
        /// DPUCNTAB11.
        /// </summary>
        public const string DPUCNTAB11 = "DPUCNTAB11";

        /// <summary>
        /// DPCNTRAB11.
        /// </summary>
        public const string DPCNTRAB11 = "DPCNTRAB11";

        /// <summary>
        /// DPUCNTAB12.
        /// </summary>
        public const string DPUCNTAB12 = "DPUCNTAB12";

        /// <summary>
        /// DPCNTRAB12.
        /// </summary>
        public const string DPCNTRAB12 = "DPCNTRAB12";

        /// <summary>
        /// DPUCNTCD01.
        /// </summary>
        public const string DPUCNTCD01 = "DPUCNTCD01";

        /// <summary>
        /// DPCNTRT01.
        /// </summary>
        public const string DPCNTRT01 = "DPCNTRT01";

        /// <summary>
        /// DPUCNTCD02.
        /// </summary>
        public const string DPUCNTCD02 = "DPUCNTCD02";

        /// <summary>
        /// DPCNTRT02.
        /// </summary>
        public const string DPCNTRT02 = "DPCNTRT02";

        /// <summary>
        /// DPUCNTCD03.
        /// </summary>
        public const string DPUCNTCD03 = "DPUCNTCD03";

        /// <summary>
        /// DPUCNTCD04.
        /// </summary>
        public const string DPUCNTCD04 = "DPUCNTCD04";

        /// <summary>
        /// DPCNTRT03.
        /// </summary>
        public const string DPCNTRT03 = "DPCNTRT03";

        /// <summary>
        /// DPCNTRT04.
        /// </summary>
        public const string DPCNTRT04 = "DPCNTRT04";

        /// <summary>
        /// DPUCNTCD05.
        /// </summary>
        public const string DPUCNTCD05 = "DPUCNTCD05";

        /// <summary>
        /// DPCNTRT05.
        /// </summary>
        public const string DPCNTRT05 = "DPCNTRT05";

        /// <summary>
        /// DPUCNTCD06.
        /// </summary>
        public const string DPUCNTCD06 = "DPUCNTCD06";

        /// <summary>
        /// DPCNTRT06.
        /// </summary>
        public const string DPCNTRT06 = "DPCNTRT06";

        /// <summary>
        /// DPUCNTCD07.
        /// </summary>
        public const string DPUCNTCD07 = "DPUCNTCD07";

        /// <summary>
        /// DPCNTRT07.
        /// </summary>
        public const string DPCNTRT07 = "DPCNTRT07";

        /// <summary>
        /// DPUCNTCD08.
        /// </summary>
        public const string DPUCNTCD08 = "DPUCNTCD08";

        /// <summary>
        /// DPCNTRT08.
        /// </summary>
        public const string DPCNTRT08 = "DPCNTRT08";

        /// <summary>
        /// DPUCNTCD09.
        /// </summary>
        public const string DPUCNTCD09 = "DPUCNTCD09";

        /// <summary>
        /// DPCNTRT09.
        /// </summary>
        public const string DPCNTRT09 = "DPCNTRT09";

        /// <summary>
        /// DPUCNTCD10.
        /// </summary>
        public const string DPUCNTCD10 = "DPUCNTCD10";

        /// <summary>
        /// DPCNTRT10.
        /// </summary>
        public const string DPCNTRT10 = "DPCNTRT10";

        /// <summary>
        /// DPUCNTCD11.
        /// </summary>
        public const string DPUCNTCD11 = "DPUCNTCD11";

        /// <summary>
        /// DPCNTRT11.
        /// </summary>
        public const string DPCNTRT11 = "DPCNTRT11";

        /// <summary>
        /// DPUCNTCD12.
        /// </summary>
        public const string DPUCNTCD12 = "DPUCNTCD12";

        /// <summary>
        /// DPCNTRT12.
        /// </summary>
        public const string DPCNTRT12 = "DPCNTRT12";

        /// <summary>
        /// DPUCNTCD13.
        /// </summary>
        public const string DPUCNTCD13 = "DPUCNTCD13";

        /// <summary>
        /// DPCNTRT13.
        /// </summary>
        public const string DPCNTRT13 = "DPCNTRT13";

        /// <summary>
        /// DPUCNTCD14.
        /// </summary>
        public const string DPUCNTCD14 = "DPUCNTCD14";

        /// <summary>
        /// DPCNTRT14.
        /// </summary>
        public const string DPCNTRT14 = "DPCNTRT14";

        /// <summary>
        /// DPUCNTCD15.
        /// </summary>
        public const string DPUCNTCD15 = "DPUCNTCD15";

        /// <summary>
        /// DPCNTRT15.
        /// </summary>
        public const string DPCNTRT15 = "DPCNTRT15";

        /// <summary>
        /// DPUCNTDT1.
        /// </summary>
        public const string DPUCNTDT1 = "DPUCNTDT1";

        /// <summary>
        /// DPCNTRTDT1.
        /// </summary>
        public const string DPCNTRTDT1 = "DPCNTRTDT1";

        /// <summary>
        /// DPUCNTDT2.
        /// </summary>
        public const string DPUCNTDT2 = "DPUCNTDT2";

        /// <summary>
        /// DPCNTRTDT2.
        /// </summary>
        public const string DPCNTRTDT2 = "DPCNTRTDT2";

        /// <summary>
        /// DPUCNTDT3.
        /// </summary>
        public const string DPUCNTDT3 = "DPUCNTDT3";

        /// <summary>
        /// DPCNTRTDT3.
        /// </summary>
        public const string DPCNTRTDT3 = "DPCNTRTDT3";

        /// <summary>
        /// DPUCNTDT4.
        /// </summary>
        public const string DPUCNTDT4 = "DPUCNTDT4";

        /// <summary>
        /// DPCNTRTDT4.
        /// </summary>
        public const string DPCNTRTDT4 = "DPCNTRTDT4";

        /// <summary>
        /// DPUCNTDT5.
        /// </summary>
        public const string DPUCNTDT5 = "DPUCNTDT5";

        /// <summary>
        /// DPCNTRTDT5.
        /// </summary>
        public const string DPCNTRTDT5 = "DPCNTRTDT5";

        /// <summary>
        /// DPUCNTDT6.
        /// </summary>
        public const string DPUCNTDT6 = "DPUCNTDT6";

        /// <summary>
        /// DPCNTRTDT6.
        /// </summary>
        public const string DPCNTRTDT6 = "DPCNTRTDT6";

        /// <summary>
        /// DPUCNTP1.
        /// </summary>
        public const string DPUCNTP1 = "DPUCNTP1";

        /// <summary>
        /// DPCNTRPT01.
        /// </summary>
        public const string DPCNTRPT01 = "DPCNTRPT01";

        /// <summary>
        /// DPUCNTP2.
        /// </summary>
        public const string DPUCNTP2 = "DPUCNTP2";

        /// <summary>
        /// DPCNTRPT02.
        /// </summary>
        public const string DPCNTRPT02 = "DPCNTRPT02";

        /// <summary>
        /// DPUCNTP3.
        /// </summary>
        public const string DPUCNTP3 = "DPUCNTP3";

        /// <summary>
        /// DPCNTRPT03.
        /// </summary>
        public const string DPCNTRPT03 = "DPCNTRPT03";

        /// <summary>
        /// DPUCNTP4.
        /// </summary>
        public const string DPUCNTP4 = "DPUCNTP4";

        /// <summary>
        /// DPCNTRPT04.
        /// </summary>
        public const string DPCNTRPT04 = "DPCNTRPT04";

        /// <summary>
        /// DPUCNTP5.
        /// </summary>
        public const string DPUCNTP5 = "DPUCNTP5";

        /// <summary>
        /// DPCNTRPT05.
        /// </summary>
        public const string DPCNTRPT05 = "DPCNTRPT05";

        /// <summary>
        /// DPUCNTP6.
        /// </summary>
        public const string DPUCNTP6 = "DPUCNTP6";

        /// <summary>
        /// DPCNTRPT06.
        /// </summary>
        public const string DPCNTRPT06 = "DPCNTRPT06";

        /// <summary>
        /// DPURCD.
        /// </summary>
        public const string DPURCD = "DPURCD";

        /// <summary>
        /// DPURDT.
        /// </summary>
        public const string DPURDT = "DPURDT";

        /// <summary>
        /// DPURAT.
        /// </summary>
        public const string DPURAT = "DPURAT";

        /// <summary>
        /// DPURAB.
        /// </summary>
        public const string DPURAB = "DPURAB";

        /// <summary>
        /// DPURRF.
        /// </summary>
        public const string DPURRF = "DPURRF";

        /// <summary>
        /// DPTORG.
        /// </summary>
        public const string DPTORG = "DPTORG";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUUPMJ.
        /// </summary>
        public const string DPUUPMJ = "DPUUPMJ";

        /// <summary>
        /// DPPOPPOOL.
        /// </summary>
        public const string DPPOPPOOL = "DPPOPPOOL";

        /// <summary>
        /// DPGEQTYP.
        /// </summary>
        public const string DPGEQTYP = "DPGEQTYP";

        /// <summary>
        /// DPGEQPCT.
        /// </summary>
        public const string DPGEQPCT = "DPGEQPCT";

        /// <summary>
        /// DPPOPASN.
        /// </summary>
        public const string DPPOPASN = "DPPOPASN";

        /// <summary>
        /// DPPOPPTC.
        /// </summary>
        public const string DPPOPPTC = "DPPOPPTC";

        /// <summary>
        /// DPUPOOL.
        /// </summary>
        public const string DPUPOOL = "DPUPOOL";

        /// <summary>
        /// DPUEQTYP.
        /// </summary>
        public const string DPUEQTYP = "DPUEQTYP";

        /// <summary>
        /// DPUEQPCT.
        /// </summary>
        public const string DPUEQPCT = "DPUEQPCT";

        /// <summary>
        /// DPUPOPASN.
        /// </summary>
        public const string DPUPOPASN = "DPUPOPASN";

        /// <summary>
        /// DPUPOPPTC.
        /// </summary>
        public const string DPUPOPPTC = "DPUPOPPTC";
    }

    /// <inheritdoc />
    public override string TableName => "F43C110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPCHPRID", "DPCHPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("DPCHPRDES", "DPCHPRDES", JdeDataType.String, 80),
        new JdeField("DPUCNTPT", "DPUCNTPT", JdeDataType.String, 2),
        new JdeField("DPCNTRTPT", "DPCNTRTPT", JdeDataType.String, 6),
        new JdeField("DPUCNTDF", "DPUCNTDF", JdeDataType.String, 2),
        new JdeField("DPCNTRTDF", "DPCNTRTDF", JdeDataType.String, 6),
        new JdeField("DPUCNTCC", "DPUCNTCC", JdeDataType.String, 2),
        new JdeField("DPCMDCDE", "DPCMDCDE", JdeDataType.String, 30),
        new JdeField("DPUCQTY", "DPUCQTY", JdeDataType.String, 2),
        new JdeField("DPCNTRTQTY", "DPCNTRTQTY", JdeDataType.Numeric),
        new JdeField("DPUTUOM", "DPUTUOM", JdeDataType.String, 2),
        new JdeField("DPUOM", "DPUOM", JdeDataType.String, 4),
        new JdeField("DPUDISOR", "DPUDISOR", JdeDataType.String, 2),
        new JdeField("DPQCONTROL", "DPQCONTROL", JdeDataType.String, 2),
        new JdeField("DPUMINQTY", "DPUMINQTY", JdeDataType.String, 2),
        new JdeField("DPMINQTY", "DPMINQTY", JdeDataType.Numeric),
        new JdeField("DPUMAXQTY", "DPUMAXQTY", JdeDataType.String, 2),
        new JdeField("DPMAXQTY", "DPMAXQTY", JdeDataType.Numeric),
        new JdeField("DPUPUOM", "DPUPUOM", JdeDataType.String, 2),
        new JdeField("DPUOM3", "DPUOM3", JdeDataType.String, 4),
        new JdeField("DPUPRCAPP", "DPUPRCAPP", JdeDataType.String, 2),
        new JdeField("DPPRICEAPP", "DPPRICEAPP", JdeDataType.String, 2),
        new JdeField("DPUCNTRTPL", "DPUCNTRTPL", JdeDataType.String, 2),
        new JdeField("DPPRLEVL", "DPPRLEVL", JdeDataType.String, 20),
        new JdeField("DPUCPG", "DPUCPG", JdeDataType.String, 2),
        new JdeField("DPCNTRPRG", "DPCNTRPRG", JdeDataType.String, 16),
        new JdeField("DPUPRICOVR", "DPUPRICOVR", JdeDataType.String, 2),
        new JdeField("DPPRICEOVR", "DPPRICEOVR", JdeDataType.Numeric),
        new JdeField("DPUPOCOM", "DPUPOCOM", JdeDataType.String, 2),
        new JdeField("DPOVRCOMM", "DPOVRCOMM", JdeDataType.String, 60),
        new JdeField("DPUMINPRC", "DPUMINPRC", JdeDataType.String, 2),
        new JdeField("DPMINPRICE", "DPMINPRICE", JdeDataType.Numeric),
        new JdeField("DPUMAXPRC", "DPUMAXPRC", JdeDataType.String, 2),
        new JdeField("DPMAXPRICE", "DPMAXPRICE", JdeDataType.Numeric),
        new JdeField("DPUMP", "DPUMP", JdeDataType.String, 2),
        new JdeField("DPMEMPRICE", "DPMEMPRICE", JdeDataType.Numeric),
        new JdeField("DPUMPL", "DPUMPL", JdeDataType.String, 2),
        new JdeField("DPPRICELVL", "DPPRICELVL", JdeDataType.String, 20),
        new JdeField("DPUPRCADJ", "DPUPRCADJ", JdeDataType.String, 2),
        new JdeField("DPASN", "DPASN", JdeDataType.String, 16),
        new JdeField("DPCLSID", "DPCLSID", JdeDataType.Numeric),
        new JdeField("DPUCNTAB01", "DPUCNTAB01", JdeDataType.String, 2),
        new JdeField("DPCNTRAB01", "DPCNTRAB01", JdeDataType.Numeric),
        new JdeField("DPUCNTAB02", "DPUCNTAB02", JdeDataType.String, 2),
        new JdeField("DPCNTRAB02", "DPCNTRAB02", JdeDataType.Numeric),
        new JdeField("DPUCNTAB03", "DPUCNTAB03", JdeDataType.String, 2),
        new JdeField("DPCNTRAB03", "DPCNTRAB03", JdeDataType.Numeric),
        new JdeField("DPUCNTAB04", "DPUCNTAB04", JdeDataType.String, 2),
        new JdeField("DPCNTRAB04", "DPCNTRAB04", JdeDataType.Numeric),
        new JdeField("DPUCNTAB05", "DPUCNTAB05", JdeDataType.String, 2),
        new JdeField("DPCNTRAB05", "DPCNTRAB05", JdeDataType.Numeric),
        new JdeField("DPUCNTAB06", "DPUCNTAB06", JdeDataType.String, 2),
        new JdeField("DPCNTRAB06", "DPCNTRAB06", JdeDataType.Numeric),
        new JdeField("DPUCNTAB07", "DPUCNTAB07", JdeDataType.String, 2),
        new JdeField("DPCNTRAB07", "DPCNTRAB07", JdeDataType.Numeric),
        new JdeField("DPUCNTAB08", "DPUCNTAB08", JdeDataType.String, 2),
        new JdeField("DPCNTRAB08", "DPCNTRAB08", JdeDataType.Numeric),
        new JdeField("DPUCNTAB09", "DPUCNTAB09", JdeDataType.String, 2),
        new JdeField("DPCNTRAB09", "DPCNTRAB09", JdeDataType.Numeric),
        new JdeField("DPUCNTAB10", "DPUCNTAB10", JdeDataType.String, 2),
        new JdeField("DPCNTRAB10", "DPCNTRAB10", JdeDataType.Numeric),
        new JdeField("DPUCNTAB11", "DPUCNTAB11", JdeDataType.String, 2),
        new JdeField("DPCNTRAB11", "DPCNTRAB11", JdeDataType.Numeric),
        new JdeField("DPUCNTAB12", "DPUCNTAB12", JdeDataType.String, 2),
        new JdeField("DPCNTRAB12", "DPCNTRAB12", JdeDataType.Numeric),
        new JdeField("DPUCNTCD01", "DPUCNTCD01", JdeDataType.String, 2),
        new JdeField("DPCNTRT01", "DPCNTRT01", JdeDataType.String, 6),
        new JdeField("DPUCNTCD02", "DPUCNTCD02", JdeDataType.String, 2),
        new JdeField("DPCNTRT02", "DPCNTRT02", JdeDataType.String, 6),
        new JdeField("DPUCNTCD03", "DPUCNTCD03", JdeDataType.String, 2),
        new JdeField("DPUCNTCD04", "DPUCNTCD04", JdeDataType.String, 2),
        new JdeField("DPCNTRT03", "DPCNTRT03", JdeDataType.String, 6),
        new JdeField("DPCNTRT04", "DPCNTRT04", JdeDataType.String, 6),
        new JdeField("DPUCNTCD05", "DPUCNTCD05", JdeDataType.String, 2),
        new JdeField("DPCNTRT05", "DPCNTRT05", JdeDataType.String, 6),
        new JdeField("DPUCNTCD06", "DPUCNTCD06", JdeDataType.String, 2),
        new JdeField("DPCNTRT06", "DPCNTRT06", JdeDataType.String, 16),
        new JdeField("DPUCNTCD07", "DPUCNTCD07", JdeDataType.String, 2),
        new JdeField("DPCNTRT07", "DPCNTRT07", JdeDataType.String, 16),
        new JdeField("DPUCNTCD08", "DPUCNTCD08", JdeDataType.String, 2),
        new JdeField("DPCNTRT08", "DPCNTRT08", JdeDataType.String, 16),
        new JdeField("DPUCNTCD09", "DPUCNTCD09", JdeDataType.String, 2),
        new JdeField("DPCNTRT09", "DPCNTRT09", JdeDataType.String, 16),
        new JdeField("DPUCNTCD10", "DPUCNTCD10", JdeDataType.String, 2),
        new JdeField("DPCNTRT10", "DPCNTRT10", JdeDataType.String, 16),
        new JdeField("DPUCNTCD11", "DPUCNTCD11", JdeDataType.String, 2),
        new JdeField("DPCNTRT11", "DPCNTRT11", JdeDataType.String, 20),
        new JdeField("DPUCNTCD12", "DPUCNTCD12", JdeDataType.String, 2),
        new JdeField("DPCNTRT12", "DPCNTRT12", JdeDataType.String, 20),
        new JdeField("DPUCNTCD13", "DPUCNTCD13", JdeDataType.String, 2),
        new JdeField("DPCNTRT13", "DPCNTRT13", JdeDataType.String, 20),
        new JdeField("DPUCNTCD14", "DPUCNTCD14", JdeDataType.String, 2),
        new JdeField("DPCNTRT14", "DPCNTRT14", JdeDataType.String, 20),
        new JdeField("DPUCNTCD15", "DPUCNTCD15", JdeDataType.String, 2),
        new JdeField("DPCNTRT15", "DPCNTRT15", JdeDataType.String, 20),
        new JdeField("DPUCNTDT1", "DPUCNTDT1", JdeDataType.String, 2),
        new JdeField("DPCNTRTDT1", "DPCNTRTDT1", JdeDataType.Numeric),
        new JdeField("DPUCNTDT2", "DPUCNTDT2", JdeDataType.String, 2),
        new JdeField("DPCNTRTDT2", "DPCNTRTDT2", JdeDataType.Numeric),
        new JdeField("DPUCNTDT3", "DPUCNTDT3", JdeDataType.String, 2),
        new JdeField("DPCNTRTDT3", "DPCNTRTDT3", JdeDataType.Numeric),
        new JdeField("DPUCNTDT4", "DPUCNTDT4", JdeDataType.String, 2),
        new JdeField("DPCNTRTDT4", "DPCNTRTDT4", JdeDataType.Numeric),
        new JdeField("DPUCNTDT5", "DPUCNTDT5", JdeDataType.String, 2),
        new JdeField("DPCNTRTDT5", "DPCNTRTDT5", JdeDataType.Numeric),
        new JdeField("DPUCNTDT6", "DPUCNTDT6", JdeDataType.String, 2),
        new JdeField("DPCNTRTDT6", "DPCNTRTDT6", JdeDataType.Numeric),
        new JdeField("DPUCNTP1", "DPUCNTP1", JdeDataType.String, 2),
        new JdeField("DPCNTRPT01", "DPCNTRPT01", JdeDataType.String, 2),
        new JdeField("DPUCNTP2", "DPUCNTP2", JdeDataType.String, 2),
        new JdeField("DPCNTRPT02", "DPCNTRPT02", JdeDataType.String, 2),
        new JdeField("DPUCNTP3", "DPUCNTP3", JdeDataType.String, 2),
        new JdeField("DPCNTRPT03", "DPCNTRPT03", JdeDataType.String, 2),
        new JdeField("DPUCNTP4", "DPUCNTP4", JdeDataType.String, 2),
        new JdeField("DPCNTRPT04", "DPCNTRPT04", JdeDataType.String, 2),
        new JdeField("DPUCNTP5", "DPUCNTP5", JdeDataType.String, 2),
        new JdeField("DPCNTRPT05", "DPCNTRPT05", JdeDataType.String, 2),
        new JdeField("DPUCNTP6", "DPUCNTP6", JdeDataType.String, 2),
        new JdeField("DPCNTRPT06", "DPCNTRPT06", JdeDataType.String, 2),
        new JdeField("DPURCD", "DPURCD", JdeDataType.String, 4),
        new JdeField("DPURDT", "DPURDT", JdeDataType.Numeric),
        new JdeField("DPURAT", "DPURAT", JdeDataType.Numeric),
        new JdeField("DPURAB", "DPURAB", JdeDataType.Numeric),
        new JdeField("DPURRF", "DPURRF", JdeDataType.String, 30),
        new JdeField("DPTORG", "DPTORG", JdeDataType.String, 20),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUUPMJ", "DPUUPMJ", JdeDataType.Date),
        new JdeField("DPPOPPOOL", "DPPOPPOOL", JdeDataType.String, 16),
        new JdeField("DPGEQTYP", "DPGEQTYP", JdeDataType.String, 16),
        new JdeField("DPGEQPCT", "DPGEQPCT", JdeDataType.Numeric),
        new JdeField("DPPOPASN", "DPPOPASN", JdeDataType.String, 16),
        new JdeField("DPPOPPTC", "DPPOPPTC", JdeDataType.String, 6),
        new JdeField("DPUPOOL", "DPUPOOL", JdeDataType.String, 2),
        new JdeField("DPUEQTYP", "DPUEQTYP", JdeDataType.String, 2),
        new JdeField("DPUEQPCT", "DPUEQPCT", JdeDataType.String, 2),
        new JdeField("DPUPOPASN", "DPUPOPASN", JdeDataType.String, 2),
        new JdeField("DPUPOPPTC", "DPUPOPPTC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C110_0", "Primary Key on DPCHPRID", new[] { "DPCHPRID" }, isUnique: true, isPrimaryKey: true)
    };
}
