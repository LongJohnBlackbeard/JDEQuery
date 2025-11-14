using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C100 - .
/// </summary>
public class F43C100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPCBPRID.
        /// </summary>
        public const string BPCBPRID = "BPCBPRID";

        /// <summary>
        /// BPCBPRDES.
        /// </summary>
        public const string BPCBPRDES = "BPCBPRDES";

        /// <summary>
        /// BPUCNTPT.
        /// </summary>
        public const string BPUCNTPT = "BPUCNTPT";

        /// <summary>
        /// BPCNTRTPT.
        /// </summary>
        public const string BPCNTRTPT = "BPCNTRTPT";

        /// <summary>
        /// BPUCNTDF.
        /// </summary>
        public const string BPUCNTDF = "BPUCNTDF";

        /// <summary>
        /// BPCNTRTDF.
        /// </summary>
        public const string BPCNTRTDF = "BPCNTRTDF";

        /// <summary>
        /// BPUCNTRTSD.
        /// </summary>
        public const string BPUCNTRTSD = "BPUCNTRTSD";

        /// <summary>
        /// BPCNTRTSD.
        /// </summary>
        public const string BPCNTRTSD = "BPCNTRTSD";

        /// <summary>
        /// BPUCNTRTED.
        /// </summary>
        public const string BPUCNTRTED = "BPUCNTRTED";

        /// <summary>
        /// BPCNTRTED.
        /// </summary>
        public const string BPCNTRTED = "BPCNTRTED";

        /// <summary>
        /// BPURNWTYP.
        /// </summary>
        public const string BPURNWTYP = "BPURNWTYP";

        /// <summary>
        /// BPRNWTYPE.
        /// </summary>
        public const string BPRNWTYPE = "BPRNWTYPE";

        /// <summary>
        /// BPURNWED.
        /// </summary>
        public const string BPURNWED = "BPURNWED";

        /// <summary>
        /// BPRNWEDTE.
        /// </summary>
        public const string BPRNWEDTE = "BPRNWEDTE";

        /// <summary>
        /// BPURNWTRM.
        /// </summary>
        public const string BPURNWTRM = "BPURNWTRM";

        /// <summary>
        /// BPRNWTRM.
        /// </summary>
        public const string BPRNWTRM = "BPRNWTRM";

        /// <summary>
        /// BPURNWUOM.
        /// </summary>
        public const string BPURNWUOM = "BPURNWUOM";

        /// <summary>
        /// BPRNWUOM.
        /// </summary>
        public const string BPRNWUOM = "BPRNWUOM";

        /// <summary>
        /// BPUCNTCC.
        /// </summary>
        public const string BPUCNTCC = "BPUCNTCC";

        /// <summary>
        /// BPCMDCDE.
        /// </summary>
        public const string BPCMDCDE = "BPCMDCDE";

        /// <summary>
        /// BPUCQTY.
        /// </summary>
        public const string BPUCQTY = "BPUCQTY";

        /// <summary>
        /// BPCNTRTQTY.
        /// </summary>
        public const string BPCNTRTQTY = "BPCNTRTQTY";

        /// <summary>
        /// BPUTUOM.
        /// </summary>
        public const string BPUTUOM = "BPUTUOM";

        /// <summary>
        /// BPUOM.
        /// </summary>
        public const string BPUOM = "BPUOM";

        /// <summary>
        /// BPUDISOR.
        /// </summary>
        public const string BPUDISOR = "BPUDISOR";

        /// <summary>
        /// BPQCONTROL.
        /// </summary>
        public const string BPQCONTROL = "BPQCONTROL";

        /// <summary>
        /// BPUMINQTY.
        /// </summary>
        public const string BPUMINQTY = "BPUMINQTY";

        /// <summary>
        /// BPMINQTY.
        /// </summary>
        public const string BPMINQTY = "BPMINQTY";

        /// <summary>
        /// BPUMAXQTY.
        /// </summary>
        public const string BPUMAXQTY = "BPUMAXQTY";

        /// <summary>
        /// BPMAXQTY.
        /// </summary>
        public const string BPMAXQTY = "BPMAXQTY";

        /// <summary>
        /// BPUPUOM.
        /// </summary>
        public const string BPUPUOM = "BPUPUOM";

        /// <summary>
        /// BPUOM3.
        /// </summary>
        public const string BPUOM3 = "BPUOM3";

        /// <summary>
        /// BPUCNTRTPL.
        /// </summary>
        public const string BPUCNTRTPL = "BPUCNTRTPL";

        /// <summary>
        /// BPPRLEVL.
        /// </summary>
        public const string BPPRLEVL = "BPPRLEVL";

        /// <summary>
        /// BPUCPG.
        /// </summary>
        public const string BPUCPG = "BPUCPG";

        /// <summary>
        /// BPCNTRPRG.
        /// </summary>
        public const string BPCNTRPRG = "BPCNTRPRG";

        /// <summary>
        /// BPUPRICOVR.
        /// </summary>
        public const string BPUPRICOVR = "BPUPRICOVR";

        /// <summary>
        /// BPPRICEOVR.
        /// </summary>
        public const string BPPRICEOVR = "BPPRICEOVR";

        /// <summary>
        /// BPUPOCOM.
        /// </summary>
        public const string BPUPOCOM = "BPUPOCOM";

        /// <summary>
        /// BPOVRCOMM.
        /// </summary>
        public const string BPOVRCOMM = "BPOVRCOMM";

        /// <summary>
        /// BPUMINPRC.
        /// </summary>
        public const string BPUMINPRC = "BPUMINPRC";

        /// <summary>
        /// BPMINPRICE.
        /// </summary>
        public const string BPMINPRICE = "BPMINPRICE";

        /// <summary>
        /// BPUMAXPRC.
        /// </summary>
        public const string BPUMAXPRC = "BPUMAXPRC";

        /// <summary>
        /// BPMAXPRICE.
        /// </summary>
        public const string BPMAXPRICE = "BPMAXPRICE";

        /// <summary>
        /// BPUMP.
        /// </summary>
        public const string BPUMP = "BPUMP";

        /// <summary>
        /// BPMEMPRICE.
        /// </summary>
        public const string BPMEMPRICE = "BPMEMPRICE";

        /// <summary>
        /// BPUMPL.
        /// </summary>
        public const string BPUMPL = "BPUMPL";

        /// <summary>
        /// BPPRICELVL.
        /// </summary>
        public const string BPPRICELVL = "BPPRICELVL";

        /// <summary>
        /// BPUPRCADJ.
        /// </summary>
        public const string BPUPRCADJ = "BPUPRCADJ";

        /// <summary>
        /// BPASN.
        /// </summary>
        public const string BPASN = "BPASN";

        /// <summary>
        /// BPCLSID.
        /// </summary>
        public const string BPCLSID = "BPCLSID";

        /// <summary>
        /// BPCUPDLVL.
        /// </summary>
        public const string BPCUPDLVL = "BPCUPDLVL";

        /// <summary>
        /// BPUCNTAB01.
        /// </summary>
        public const string BPUCNTAB01 = "BPUCNTAB01";

        /// <summary>
        /// BPCNTRAB01.
        /// </summary>
        public const string BPCNTRAB01 = "BPCNTRAB01";

        /// <summary>
        /// BPUCNTAB02.
        /// </summary>
        public const string BPUCNTAB02 = "BPUCNTAB02";

        /// <summary>
        /// BPCNTRAB02.
        /// </summary>
        public const string BPCNTRAB02 = "BPCNTRAB02";

        /// <summary>
        /// BPUCNTAB03.
        /// </summary>
        public const string BPUCNTAB03 = "BPUCNTAB03";

        /// <summary>
        /// BPCNTRAB03.
        /// </summary>
        public const string BPCNTRAB03 = "BPCNTRAB03";

        /// <summary>
        /// BPUCNTAB04.
        /// </summary>
        public const string BPUCNTAB04 = "BPUCNTAB04";

        /// <summary>
        /// BPCNTRAB04.
        /// </summary>
        public const string BPCNTRAB04 = "BPCNTRAB04";

        /// <summary>
        /// BPUCNTAB05.
        /// </summary>
        public const string BPUCNTAB05 = "BPUCNTAB05";

        /// <summary>
        /// BPCNTRAB05.
        /// </summary>
        public const string BPCNTRAB05 = "BPCNTRAB05";

        /// <summary>
        /// BPUCNTAB06.
        /// </summary>
        public const string BPUCNTAB06 = "BPUCNTAB06";

        /// <summary>
        /// BPCNTRAB06.
        /// </summary>
        public const string BPCNTRAB06 = "BPCNTRAB06";

        /// <summary>
        /// BPUCNTAB07.
        /// </summary>
        public const string BPUCNTAB07 = "BPUCNTAB07";

        /// <summary>
        /// BPCNTRAB07.
        /// </summary>
        public const string BPCNTRAB07 = "BPCNTRAB07";

        /// <summary>
        /// BPUCNTAB08.
        /// </summary>
        public const string BPUCNTAB08 = "BPUCNTAB08";

        /// <summary>
        /// BPCNTRAB08.
        /// </summary>
        public const string BPCNTRAB08 = "BPCNTRAB08";

        /// <summary>
        /// BPUCNTAB09.
        /// </summary>
        public const string BPUCNTAB09 = "BPUCNTAB09";

        /// <summary>
        /// BPCNTRAB09.
        /// </summary>
        public const string BPCNTRAB09 = "BPCNTRAB09";

        /// <summary>
        /// BPUCNTAB10.
        /// </summary>
        public const string BPUCNTAB10 = "BPUCNTAB10";

        /// <summary>
        /// BPCNTRAB10.
        /// </summary>
        public const string BPCNTRAB10 = "BPCNTRAB10";

        /// <summary>
        /// BPUCNTAB11.
        /// </summary>
        public const string BPUCNTAB11 = "BPUCNTAB11";

        /// <summary>
        /// BPCNTRAB11.
        /// </summary>
        public const string BPCNTRAB11 = "BPCNTRAB11";

        /// <summary>
        /// BPUCNTAB12.
        /// </summary>
        public const string BPUCNTAB12 = "BPUCNTAB12";

        /// <summary>
        /// BPCNTRAB12.
        /// </summary>
        public const string BPCNTRAB12 = "BPCNTRAB12";

        /// <summary>
        /// BPUCNTCD01.
        /// </summary>
        public const string BPUCNTCD01 = "BPUCNTCD01";

        /// <summary>
        /// BPCNTRT01.
        /// </summary>
        public const string BPCNTRT01 = "BPCNTRT01";

        /// <summary>
        /// BPUCNTCD02.
        /// </summary>
        public const string BPUCNTCD02 = "BPUCNTCD02";

        /// <summary>
        /// BPCNTRT02.
        /// </summary>
        public const string BPCNTRT02 = "BPCNTRT02";

        /// <summary>
        /// BPUCNTCD03.
        /// </summary>
        public const string BPUCNTCD03 = "BPUCNTCD03";

        /// <summary>
        /// BPUCNTCD04.
        /// </summary>
        public const string BPUCNTCD04 = "BPUCNTCD04";

        /// <summary>
        /// BPCNTRT03.
        /// </summary>
        public const string BPCNTRT03 = "BPCNTRT03";

        /// <summary>
        /// BPCNTRT04.
        /// </summary>
        public const string BPCNTRT04 = "BPCNTRT04";

        /// <summary>
        /// BPUCNTCD05.
        /// </summary>
        public const string BPUCNTCD05 = "BPUCNTCD05";

        /// <summary>
        /// BPCNTRT05.
        /// </summary>
        public const string BPCNTRT05 = "BPCNTRT05";

        /// <summary>
        /// BPUCNTCD06.
        /// </summary>
        public const string BPUCNTCD06 = "BPUCNTCD06";

        /// <summary>
        /// BPCNTRT06.
        /// </summary>
        public const string BPCNTRT06 = "BPCNTRT06";

        /// <summary>
        /// BPUCNTCD07.
        /// </summary>
        public const string BPUCNTCD07 = "BPUCNTCD07";

        /// <summary>
        /// BPCNTRT07.
        /// </summary>
        public const string BPCNTRT07 = "BPCNTRT07";

        /// <summary>
        /// BPUCNTCD08.
        /// </summary>
        public const string BPUCNTCD08 = "BPUCNTCD08";

        /// <summary>
        /// BPCNTRT08.
        /// </summary>
        public const string BPCNTRT08 = "BPCNTRT08";

        /// <summary>
        /// BPUCNTCD09.
        /// </summary>
        public const string BPUCNTCD09 = "BPUCNTCD09";

        /// <summary>
        /// BPCNTRT09.
        /// </summary>
        public const string BPCNTRT09 = "BPCNTRT09";

        /// <summary>
        /// BPUCNTCD10.
        /// </summary>
        public const string BPUCNTCD10 = "BPUCNTCD10";

        /// <summary>
        /// BPCNTRT10.
        /// </summary>
        public const string BPCNTRT10 = "BPCNTRT10";

        /// <summary>
        /// BPUCNTCD11.
        /// </summary>
        public const string BPUCNTCD11 = "BPUCNTCD11";

        /// <summary>
        /// BPCNTRT11.
        /// </summary>
        public const string BPCNTRT11 = "BPCNTRT11";

        /// <summary>
        /// BPUCNTCD12.
        /// </summary>
        public const string BPUCNTCD12 = "BPUCNTCD12";

        /// <summary>
        /// BPCNTRT12.
        /// </summary>
        public const string BPCNTRT12 = "BPCNTRT12";

        /// <summary>
        /// BPUCNTCD13.
        /// </summary>
        public const string BPUCNTCD13 = "BPUCNTCD13";

        /// <summary>
        /// BPCNTRT13.
        /// </summary>
        public const string BPCNTRT13 = "BPCNTRT13";

        /// <summary>
        /// BPUCNTCD14.
        /// </summary>
        public const string BPUCNTCD14 = "BPUCNTCD14";

        /// <summary>
        /// BPCNTRT14.
        /// </summary>
        public const string BPCNTRT14 = "BPCNTRT14";

        /// <summary>
        /// BPUCNTCD15.
        /// </summary>
        public const string BPUCNTCD15 = "BPUCNTCD15";

        /// <summary>
        /// BPCNTRT15.
        /// </summary>
        public const string BPCNTRT15 = "BPCNTRT15";

        /// <summary>
        /// BPUCNTDT1.
        /// </summary>
        public const string BPUCNTDT1 = "BPUCNTDT1";

        /// <summary>
        /// BPCNTRTDT1.
        /// </summary>
        public const string BPCNTRTDT1 = "BPCNTRTDT1";

        /// <summary>
        /// BPUCNTDT2.
        /// </summary>
        public const string BPUCNTDT2 = "BPUCNTDT2";

        /// <summary>
        /// BPCNTRTDT2.
        /// </summary>
        public const string BPCNTRTDT2 = "BPCNTRTDT2";

        /// <summary>
        /// BPUCNTDT3.
        /// </summary>
        public const string BPUCNTDT3 = "BPUCNTDT3";

        /// <summary>
        /// BPCNTRTDT3.
        /// </summary>
        public const string BPCNTRTDT3 = "BPCNTRTDT3";

        /// <summary>
        /// BPUCNTDT4.
        /// </summary>
        public const string BPUCNTDT4 = "BPUCNTDT4";

        /// <summary>
        /// BPCNTRTDT4.
        /// </summary>
        public const string BPCNTRTDT4 = "BPCNTRTDT4";

        /// <summary>
        /// BPUCNTDT5.
        /// </summary>
        public const string BPUCNTDT5 = "BPUCNTDT5";

        /// <summary>
        /// BPCNTRTDT5.
        /// </summary>
        public const string BPCNTRTDT5 = "BPCNTRTDT5";

        /// <summary>
        /// BPUCNTDT6.
        /// </summary>
        public const string BPUCNTDT6 = "BPUCNTDT6";

        /// <summary>
        /// BPCNTRTDT6.
        /// </summary>
        public const string BPCNTRTDT6 = "BPCNTRTDT6";

        /// <summary>
        /// BPUCNTP1.
        /// </summary>
        public const string BPUCNTP1 = "BPUCNTP1";

        /// <summary>
        /// BPCNTRPT01.
        /// </summary>
        public const string BPCNTRPT01 = "BPCNTRPT01";

        /// <summary>
        /// BPUCNTP2.
        /// </summary>
        public const string BPUCNTP2 = "BPUCNTP2";

        /// <summary>
        /// BPCNTRPT02.
        /// </summary>
        public const string BPCNTRPT02 = "BPCNTRPT02";

        /// <summary>
        /// BPUCNTP3.
        /// </summary>
        public const string BPUCNTP3 = "BPUCNTP3";

        /// <summary>
        /// BPCNTRPT03.
        /// </summary>
        public const string BPCNTRPT03 = "BPCNTRPT03";

        /// <summary>
        /// BPUCNTP4.
        /// </summary>
        public const string BPUCNTP4 = "BPUCNTP4";

        /// <summary>
        /// BPCNTRPT04.
        /// </summary>
        public const string BPCNTRPT04 = "BPCNTRPT04";

        /// <summary>
        /// BPUCNTP5.
        /// </summary>
        public const string BPUCNTP5 = "BPUCNTP5";

        /// <summary>
        /// BPCNTRPT05.
        /// </summary>
        public const string BPCNTRPT05 = "BPCNTRPT05";

        /// <summary>
        /// BPUCNTP6.
        /// </summary>
        public const string BPUCNTP6 = "BPUCNTP6";

        /// <summary>
        /// BPCNTRPT06.
        /// </summary>
        public const string BPCNTRPT06 = "BPCNTRPT06";

        /// <summary>
        /// BPURCD.
        /// </summary>
        public const string BPURCD = "BPURCD";

        /// <summary>
        /// BPURDT.
        /// </summary>
        public const string BPURDT = "BPURDT";

        /// <summary>
        /// BPURAT.
        /// </summary>
        public const string BPURAT = "BPURAT";

        /// <summary>
        /// BPURAB.
        /// </summary>
        public const string BPURAB = "BPURAB";

        /// <summary>
        /// BPURRF.
        /// </summary>
        public const string BPURRF = "BPURRF";

        /// <summary>
        /// BPTORG.
        /// </summary>
        public const string BPTORG = "BPTORG";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPJOBN.
        /// </summary>
        public const string BPJOBN = "BPJOBN";

        /// <summary>
        /// BPUUPMJ.
        /// </summary>
        public const string BPUUPMJ = "BPUUPMJ";

        /// <summary>
        /// BPCNTPTCB.
        /// </summary>
        public const string BPCNTPTCB = "BPCNTPTCB";

        /// <summary>
        /// BPCNTCOCB.
        /// </summary>
        public const string BPCNTCOCB = "BPCNTCOCB";

        /// <summary>
        /// BPCNTDFCB.
        /// </summary>
        public const string BPCNTDFCB = "BPCNTDFCB";

        /// <summary>
        /// BPCNTMNPCB.
        /// </summary>
        public const string BPCNTMNPCB = "BPCNTMNPCB";

        /// <summary>
        /// BPCNTMPCB.
        /// </summary>
        public const string BPCNTMPCB = "BPCNTMPCB";

        /// <summary>
        /// BPCNTMPLCB.
        /// </summary>
        public const string BPCNTMPLCB = "BPCNTMPLCB";

        /// <summary>
        /// BPCNTMQCB.
        /// </summary>
        public const string BPCNTMQCB = "BPCNTMQCB";

        /// <summary>
        /// BPCNTMXPCB.
        /// </summary>
        public const string BPCNTMXPCB = "BPCNTMXPCB";

        /// <summary>
        /// BPCNTOPCB.
        /// </summary>
        public const string BPCNTOPCB = "BPCNTOPCB";

        /// <summary>
        /// BPCNTPACB.
        /// </summary>
        public const string BPCNTPACB = "BPCNTPACB";

        /// <summary>
        /// BPCNTPGCB.
        /// </summary>
        public const string BPCNTPGCB = "BPCNTPGCB";

        /// <summary>
        /// BPCNTPUCB.
        /// </summary>
        public const string BPCNTPUCB = "BPCNTPUCB";

        /// <summary>
        /// BPCNTTUCB.
        /// </summary>
        public const string BPCNTTUCB = "BPCNTTUCB";

        /// <summary>
        /// BPCNTXQCB.
        /// </summary>
        public const string BPCNTXQCB = "BPCNTXQCB";

        /// <summary>
        /// BPCNTPLCB.
        /// </summary>
        public const string BPCNTPLCB = "BPCNTPLCB";

        /// <summary>
        /// BPCNTPCCB.
        /// </summary>
        public const string BPCNTPCCB = "BPCNTPCCB";

        /// <summary>
        /// BPCNTCQCB.
        /// </summary>
        public const string BPCNTCQCB = "BPCNTCQCB";

        /// <summary>
        /// BPPOPPOOL.
        /// </summary>
        public const string BPPOPPOOL = "BPPOPPOOL";

        /// <summary>
        /// BPGEQTYP.
        /// </summary>
        public const string BPGEQTYP = "BPGEQTYP";

        /// <summary>
        /// BPGEQPCT.
        /// </summary>
        public const string BPGEQPCT = "BPGEQPCT";

        /// <summary>
        /// BPPOPASN.
        /// </summary>
        public const string BPPOPASN = "BPPOPASN";

        /// <summary>
        /// BPPOPPTC.
        /// </summary>
        public const string BPPOPPTC = "BPPOPPTC";

        /// <summary>
        /// BPUPOOL.
        /// </summary>
        public const string BPUPOOL = "BPUPOOL";

        /// <summary>
        /// BPUEQTYP.
        /// </summary>
        public const string BPUEQTYP = "BPUEQTYP";

        /// <summary>
        /// BPUEQPCT.
        /// </summary>
        public const string BPUEQPCT = "BPUEQPCT";

        /// <summary>
        /// BPUPOPASN.
        /// </summary>
        public const string BPUPOPASN = "BPUPOPASN";

        /// <summary>
        /// BPUPOPPTC.
        /// </summary>
        public const string BPUPOPPTC = "BPUPOPPTC";

        /// <summary>
        /// BPPOOLCB.
        /// </summary>
        public const string BPPOOLCB = "BPPOOLCB";

        /// <summary>
        /// BPGEQTYPCB.
        /// </summary>
        public const string BPGEQTYPCB = "BPGEQTYPCB";

        /// <summary>
        /// BPGEQPCTCB.
        /// </summary>
        public const string BPGEQPCTCB = "BPGEQPCTCB";

        /// <summary>
        /// BPPOPASNCB.
        /// </summary>
        public const string BPPOPASNCB = "BPPOPASNCB";

        /// <summary>
        /// BPPOPPTCCB.
        /// </summary>
        public const string BPPOPPTCCB = "BPPOPPTCCB";
    }

    /// <inheritdoc />
    public override string TableName => "F43C100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPCBPRID", "BPCBPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("BPCBPRDES", "BPCBPRDES", JdeDataType.String, 80),
        new JdeField("BPUCNTPT", "BPUCNTPT", JdeDataType.String, 2),
        new JdeField("BPCNTRTPT", "BPCNTRTPT", JdeDataType.String, 6),
        new JdeField("BPUCNTDF", "BPUCNTDF", JdeDataType.String, 2),
        new JdeField("BPCNTRTDF", "BPCNTRTDF", JdeDataType.String, 6),
        new JdeField("BPUCNTRTSD", "BPUCNTRTSD", JdeDataType.String, 2),
        new JdeField("BPCNTRTSD", "BPCNTRTSD", JdeDataType.Date),
        new JdeField("BPUCNTRTED", "BPUCNTRTED", JdeDataType.String, 2),
        new JdeField("BPCNTRTED", "BPCNTRTED", JdeDataType.Date),
        new JdeField("BPURNWTYP", "BPURNWTYP", JdeDataType.String, 2),
        new JdeField("BPRNWTYPE", "BPRNWTYPE", JdeDataType.String, 6),
        new JdeField("BPURNWED", "BPURNWED", JdeDataType.String, 2),
        new JdeField("BPRNWEDTE", "BPRNWEDTE", JdeDataType.Date),
        new JdeField("BPURNWTRM", "BPURNWTRM", JdeDataType.String, 2),
        new JdeField("BPRNWTRM", "BPRNWTRM", JdeDataType.Numeric),
        new JdeField("BPURNWUOM", "BPURNWUOM", JdeDataType.String, 2),
        new JdeField("BPRNWUOM", "BPRNWUOM", JdeDataType.String, 6),
        new JdeField("BPUCNTCC", "BPUCNTCC", JdeDataType.String, 2),
        new JdeField("BPCMDCDE", "BPCMDCDE", JdeDataType.String, 30),
        new JdeField("BPUCQTY", "BPUCQTY", JdeDataType.String, 2),
        new JdeField("BPCNTRTQTY", "BPCNTRTQTY", JdeDataType.Numeric),
        new JdeField("BPUTUOM", "BPUTUOM", JdeDataType.String, 2),
        new JdeField("BPUOM", "BPUOM", JdeDataType.String, 4),
        new JdeField("BPUDISOR", "BPUDISOR", JdeDataType.String, 2),
        new JdeField("BPQCONTROL", "BPQCONTROL", JdeDataType.String, 2),
        new JdeField("BPUMINQTY", "BPUMINQTY", JdeDataType.String, 2),
        new JdeField("BPMINQTY", "BPMINQTY", JdeDataType.Numeric),
        new JdeField("BPUMAXQTY", "BPUMAXQTY", JdeDataType.String, 2),
        new JdeField("BPMAXQTY", "BPMAXQTY", JdeDataType.Numeric),
        new JdeField("BPUPUOM", "BPUPUOM", JdeDataType.String, 2),
        new JdeField("BPUOM3", "BPUOM3", JdeDataType.String, 4),
        new JdeField("BPUCNTRTPL", "BPUCNTRTPL", JdeDataType.String, 2),
        new JdeField("BPPRLEVL", "BPPRLEVL", JdeDataType.String, 20),
        new JdeField("BPUCPG", "BPUCPG", JdeDataType.String, 2),
        new JdeField("BPCNTRPRG", "BPCNTRPRG", JdeDataType.String, 16),
        new JdeField("BPUPRICOVR", "BPUPRICOVR", JdeDataType.String, 2),
        new JdeField("BPPRICEOVR", "BPPRICEOVR", JdeDataType.Numeric),
        new JdeField("BPUPOCOM", "BPUPOCOM", JdeDataType.String, 2),
        new JdeField("BPOVRCOMM", "BPOVRCOMM", JdeDataType.String, 60),
        new JdeField("BPUMINPRC", "BPUMINPRC", JdeDataType.String, 2),
        new JdeField("BPMINPRICE", "BPMINPRICE", JdeDataType.Numeric),
        new JdeField("BPUMAXPRC", "BPUMAXPRC", JdeDataType.String, 2),
        new JdeField("BPMAXPRICE", "BPMAXPRICE", JdeDataType.Numeric),
        new JdeField("BPUMP", "BPUMP", JdeDataType.String, 2),
        new JdeField("BPMEMPRICE", "BPMEMPRICE", JdeDataType.Numeric),
        new JdeField("BPUMPL", "BPUMPL", JdeDataType.String, 2),
        new JdeField("BPPRICELVL", "BPPRICELVL", JdeDataType.String, 20),
        new JdeField("BPUPRCADJ", "BPUPRCADJ", JdeDataType.String, 2),
        new JdeField("BPASN", "BPASN", JdeDataType.String, 16),
        new JdeField("BPCLSID", "BPCLSID", JdeDataType.Numeric),
        new JdeField("BPCUPDLVL", "BPCUPDLVL", JdeDataType.String, 2),
        new JdeField("BPUCNTAB01", "BPUCNTAB01", JdeDataType.String, 2),
        new JdeField("BPCNTRAB01", "BPCNTRAB01", JdeDataType.Numeric),
        new JdeField("BPUCNTAB02", "BPUCNTAB02", JdeDataType.String, 2),
        new JdeField("BPCNTRAB02", "BPCNTRAB02", JdeDataType.Numeric),
        new JdeField("BPUCNTAB03", "BPUCNTAB03", JdeDataType.String, 2),
        new JdeField("BPCNTRAB03", "BPCNTRAB03", JdeDataType.Numeric),
        new JdeField("BPUCNTAB04", "BPUCNTAB04", JdeDataType.String, 2),
        new JdeField("BPCNTRAB04", "BPCNTRAB04", JdeDataType.Numeric),
        new JdeField("BPUCNTAB05", "BPUCNTAB05", JdeDataType.String, 2),
        new JdeField("BPCNTRAB05", "BPCNTRAB05", JdeDataType.Numeric),
        new JdeField("BPUCNTAB06", "BPUCNTAB06", JdeDataType.String, 2),
        new JdeField("BPCNTRAB06", "BPCNTRAB06", JdeDataType.Numeric),
        new JdeField("BPUCNTAB07", "BPUCNTAB07", JdeDataType.String, 2),
        new JdeField("BPCNTRAB07", "BPCNTRAB07", JdeDataType.Numeric),
        new JdeField("BPUCNTAB08", "BPUCNTAB08", JdeDataType.String, 2),
        new JdeField("BPCNTRAB08", "BPCNTRAB08", JdeDataType.Numeric),
        new JdeField("BPUCNTAB09", "BPUCNTAB09", JdeDataType.String, 2),
        new JdeField("BPCNTRAB09", "BPCNTRAB09", JdeDataType.Numeric),
        new JdeField("BPUCNTAB10", "BPUCNTAB10", JdeDataType.String, 2),
        new JdeField("BPCNTRAB10", "BPCNTRAB10", JdeDataType.Numeric),
        new JdeField("BPUCNTAB11", "BPUCNTAB11", JdeDataType.String, 2),
        new JdeField("BPCNTRAB11", "BPCNTRAB11", JdeDataType.Numeric),
        new JdeField("BPUCNTAB12", "BPUCNTAB12", JdeDataType.String, 2),
        new JdeField("BPCNTRAB12", "BPCNTRAB12", JdeDataType.Numeric),
        new JdeField("BPUCNTCD01", "BPUCNTCD01", JdeDataType.String, 2),
        new JdeField("BPCNTRT01", "BPCNTRT01", JdeDataType.String, 6),
        new JdeField("BPUCNTCD02", "BPUCNTCD02", JdeDataType.String, 2),
        new JdeField("BPCNTRT02", "BPCNTRT02", JdeDataType.String, 6),
        new JdeField("BPUCNTCD03", "BPUCNTCD03", JdeDataType.String, 2),
        new JdeField("BPUCNTCD04", "BPUCNTCD04", JdeDataType.String, 2),
        new JdeField("BPCNTRT03", "BPCNTRT03", JdeDataType.String, 6),
        new JdeField("BPCNTRT04", "BPCNTRT04", JdeDataType.String, 6),
        new JdeField("BPUCNTCD05", "BPUCNTCD05", JdeDataType.String, 2),
        new JdeField("BPCNTRT05", "BPCNTRT05", JdeDataType.String, 6),
        new JdeField("BPUCNTCD06", "BPUCNTCD06", JdeDataType.String, 2),
        new JdeField("BPCNTRT06", "BPCNTRT06", JdeDataType.String, 16),
        new JdeField("BPUCNTCD07", "BPUCNTCD07", JdeDataType.String, 2),
        new JdeField("BPCNTRT07", "BPCNTRT07", JdeDataType.String, 16),
        new JdeField("BPUCNTCD08", "BPUCNTCD08", JdeDataType.String, 2),
        new JdeField("BPCNTRT08", "BPCNTRT08", JdeDataType.String, 16),
        new JdeField("BPUCNTCD09", "BPUCNTCD09", JdeDataType.String, 2),
        new JdeField("BPCNTRT09", "BPCNTRT09", JdeDataType.String, 16),
        new JdeField("BPUCNTCD10", "BPUCNTCD10", JdeDataType.String, 2),
        new JdeField("BPCNTRT10", "BPCNTRT10", JdeDataType.String, 16),
        new JdeField("BPUCNTCD11", "BPUCNTCD11", JdeDataType.String, 2),
        new JdeField("BPCNTRT11", "BPCNTRT11", JdeDataType.String, 20),
        new JdeField("BPUCNTCD12", "BPUCNTCD12", JdeDataType.String, 2),
        new JdeField("BPCNTRT12", "BPCNTRT12", JdeDataType.String, 20),
        new JdeField("BPUCNTCD13", "BPUCNTCD13", JdeDataType.String, 2),
        new JdeField("BPCNTRT13", "BPCNTRT13", JdeDataType.String, 20),
        new JdeField("BPUCNTCD14", "BPUCNTCD14", JdeDataType.String, 2),
        new JdeField("BPCNTRT14", "BPCNTRT14", JdeDataType.String, 20),
        new JdeField("BPUCNTCD15", "BPUCNTCD15", JdeDataType.String, 2),
        new JdeField("BPCNTRT15", "BPCNTRT15", JdeDataType.String, 20),
        new JdeField("BPUCNTDT1", "BPUCNTDT1", JdeDataType.String, 2),
        new JdeField("BPCNTRTDT1", "BPCNTRTDT1", JdeDataType.Numeric),
        new JdeField("BPUCNTDT2", "BPUCNTDT2", JdeDataType.String, 2),
        new JdeField("BPCNTRTDT2", "BPCNTRTDT2", JdeDataType.Numeric),
        new JdeField("BPUCNTDT3", "BPUCNTDT3", JdeDataType.String, 2),
        new JdeField("BPCNTRTDT3", "BPCNTRTDT3", JdeDataType.Numeric),
        new JdeField("BPUCNTDT4", "BPUCNTDT4", JdeDataType.String, 2),
        new JdeField("BPCNTRTDT4", "BPCNTRTDT4", JdeDataType.Numeric),
        new JdeField("BPUCNTDT5", "BPUCNTDT5", JdeDataType.String, 2),
        new JdeField("BPCNTRTDT5", "BPCNTRTDT5", JdeDataType.Numeric),
        new JdeField("BPUCNTDT6", "BPUCNTDT6", JdeDataType.String, 2),
        new JdeField("BPCNTRTDT6", "BPCNTRTDT6", JdeDataType.Numeric),
        new JdeField("BPUCNTP1", "BPUCNTP1", JdeDataType.String, 2),
        new JdeField("BPCNTRPT01", "BPCNTRPT01", JdeDataType.String, 2),
        new JdeField("BPUCNTP2", "BPUCNTP2", JdeDataType.String, 2),
        new JdeField("BPCNTRPT02", "BPCNTRPT02", JdeDataType.String, 2),
        new JdeField("BPUCNTP3", "BPUCNTP3", JdeDataType.String, 2),
        new JdeField("BPCNTRPT03", "BPCNTRPT03", JdeDataType.String, 2),
        new JdeField("BPUCNTP4", "BPUCNTP4", JdeDataType.String, 2),
        new JdeField("BPCNTRPT04", "BPCNTRPT04", JdeDataType.String, 2),
        new JdeField("BPUCNTP5", "BPUCNTP5", JdeDataType.String, 2),
        new JdeField("BPCNTRPT05", "BPCNTRPT05", JdeDataType.String, 2),
        new JdeField("BPUCNTP6", "BPUCNTP6", JdeDataType.String, 2),
        new JdeField("BPCNTRPT06", "BPCNTRPT06", JdeDataType.String, 2),
        new JdeField("BPURCD", "BPURCD", JdeDataType.String, 4),
        new JdeField("BPURDT", "BPURDT", JdeDataType.Numeric),
        new JdeField("BPURAT", "BPURAT", JdeDataType.Numeric),
        new JdeField("BPURAB", "BPURAB", JdeDataType.Numeric),
        new JdeField("BPURRF", "BPURRF", JdeDataType.String, 30),
        new JdeField("BPTORG", "BPTORG", JdeDataType.String, 20),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPJOBN", "BPJOBN", JdeDataType.String, 20),
        new JdeField("BPUUPMJ", "BPUUPMJ", JdeDataType.Date),
        new JdeField("BPCNTPTCB", "BPCNTPTCB", JdeDataType.String, 2),
        new JdeField("BPCNTCOCB", "BPCNTCOCB", JdeDataType.String, 2),
        new JdeField("BPCNTDFCB", "BPCNTDFCB", JdeDataType.String, 2),
        new JdeField("BPCNTMNPCB", "BPCNTMNPCB", JdeDataType.String, 2),
        new JdeField("BPCNTMPCB", "BPCNTMPCB", JdeDataType.String, 2),
        new JdeField("BPCNTMPLCB", "BPCNTMPLCB", JdeDataType.String, 2),
        new JdeField("BPCNTMQCB", "BPCNTMQCB", JdeDataType.String, 2),
        new JdeField("BPCNTMXPCB", "BPCNTMXPCB", JdeDataType.String, 2),
        new JdeField("BPCNTOPCB", "BPCNTOPCB", JdeDataType.String, 2),
        new JdeField("BPCNTPACB", "BPCNTPACB", JdeDataType.String, 2),
        new JdeField("BPCNTPGCB", "BPCNTPGCB", JdeDataType.String, 2),
        new JdeField("BPCNTPUCB", "BPCNTPUCB", JdeDataType.String, 2),
        new JdeField("BPCNTTUCB", "BPCNTTUCB", JdeDataType.String, 2),
        new JdeField("BPCNTXQCB", "BPCNTXQCB", JdeDataType.String, 2),
        new JdeField("BPCNTPLCB", "BPCNTPLCB", JdeDataType.String, 2),
        new JdeField("BPCNTPCCB", "BPCNTPCCB", JdeDataType.String, 2),
        new JdeField("BPCNTCQCB", "BPCNTCQCB", JdeDataType.String, 2),
        new JdeField("BPPOPPOOL", "BPPOPPOOL", JdeDataType.String, 16),
        new JdeField("BPGEQTYP", "BPGEQTYP", JdeDataType.String, 16),
        new JdeField("BPGEQPCT", "BPGEQPCT", JdeDataType.Numeric),
        new JdeField("BPPOPASN", "BPPOPASN", JdeDataType.String, 16),
        new JdeField("BPPOPPTC", "BPPOPPTC", JdeDataType.String, 6),
        new JdeField("BPUPOOL", "BPUPOOL", JdeDataType.String, 2),
        new JdeField("BPUEQTYP", "BPUEQTYP", JdeDataType.String, 2),
        new JdeField("BPUEQPCT", "BPUEQPCT", JdeDataType.String, 2),
        new JdeField("BPUPOPASN", "BPUPOPASN", JdeDataType.String, 2),
        new JdeField("BPUPOPPTC", "BPUPOPPTC", JdeDataType.String, 2),
        new JdeField("BPPOOLCB", "BPPOOLCB", JdeDataType.String, 2),
        new JdeField("BPGEQTYPCB", "BPGEQTYPCB", JdeDataType.String, 2),
        new JdeField("BPGEQPCTCB", "BPGEQPCTCB", JdeDataType.String, 2),
        new JdeField("BPPOPASNCB", "BPPOPASNCB", JdeDataType.String, 2),
        new JdeField("BPPOPPTCCB", "BPPOPPTCCB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C100_0", "Primary Key on BPCBPRID", new[] { "BPCBPRID" }, isUnique: true, isPrimaryKey: true)
    };
}
