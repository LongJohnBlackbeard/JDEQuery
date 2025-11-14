using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C010 - .
/// </summary>
public class F43C010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HPCTRPRID.
        /// </summary>
        public const string HPCTRPRID = "HPCTRPRID";

        /// <summary>
        /// HPCTRPRDES.
        /// </summary>
        public const string HPCTRPRDES = "HPCTRPRDES";

        /// <summary>
        /// HPUCNTRTYP.
        /// </summary>
        public const string HPUCNTRTYP = "HPUCNTRTYP";

        /// <summary>
        /// HPCNTRTTYP.
        /// </summary>
        public const string HPCNTRTTYP = "HPCNTRTTYP";

        /// <summary>
        /// HPUCNTSTS.
        /// </summary>
        public const string HPUCNTSTS = "HPUCNTSTS";

        /// <summary>
        /// HPCNTRTSTS.
        /// </summary>
        public const string HPCNTRTSTS = "HPCNTRTSTS";

        /// <summary>
        /// HPUCNTENT.
        /// </summary>
        public const string HPUCNTENT = "HPUCNTENT";

        /// <summary>
        /// HPCNTRTENT.
        /// </summary>
        public const string HPCNTRTENT = "HPCNTRTENT";

        /// <summary>
        /// HPUCNTMGR.
        /// </summary>
        public const string HPUCNTMGR = "HPUCNTMGR";

        /// <summary>
        /// HPCNTRTMGR.
        /// </summary>
        public const string HPCNTRTMGR = "HPCNTRTMGR";

        /// <summary>
        /// HPUCNTPT.
        /// </summary>
        public const string HPUCNTPT = "HPUCNTPT";

        /// <summary>
        /// HPCNTRTPT.
        /// </summary>
        public const string HPCNTRTPT = "HPCNTRTPT";

        /// <summary>
        /// HPUCNTDF.
        /// </summary>
        public const string HPUCNTDF = "HPUCNTDF";

        /// <summary>
        /// HPCNTRTDF.
        /// </summary>
        public const string HPCNTRTDF = "HPCNTRTDF";

        /// <summary>
        /// HPUOWNER.
        /// </summary>
        public const string HPUOWNER = "HPUOWNER";

        /// <summary>
        /// HPOWNERSP.
        /// </summary>
        public const string HPOWNERSP = "HPOWNERSP";

        /// <summary>
        /// HPUCNTRTSD.
        /// </summary>
        public const string HPUCNTRTSD = "HPUCNTRTSD";

        /// <summary>
        /// HPCNTRTSD.
        /// </summary>
        public const string HPCNTRTSD = "HPCNTRTSD";

        /// <summary>
        /// HPUCNTRTED.
        /// </summary>
        public const string HPUCNTRTED = "HPUCNTRTED";

        /// <summary>
        /// HPCNTRTED.
        /// </summary>
        public const string HPCNTRTED = "HPCNTRTED";

        /// <summary>
        /// HPURNWTYP.
        /// </summary>
        public const string HPURNWTYP = "HPURNWTYP";

        /// <summary>
        /// HPRNWTYPE.
        /// </summary>
        public const string HPRNWTYPE = "HPRNWTYPE";

        /// <summary>
        /// HPURNWED.
        /// </summary>
        public const string HPURNWED = "HPURNWED";

        /// <summary>
        /// HPRNWEDTE.
        /// </summary>
        public const string HPRNWEDTE = "HPRNWEDTE";

        /// <summary>
        /// HPUCNTRD.
        /// </summary>
        public const string HPUCNTRD = "HPUCNTRD";

        /// <summary>
        /// HPCNTRD.
        /// </summary>
        public const string HPCNTRD = "HPCNTRD";

        /// <summary>
        /// HPURNWTRM.
        /// </summary>
        public const string HPURNWTRM = "HPURNWTRM";

        /// <summary>
        /// HPRNWTRM.
        /// </summary>
        public const string HPRNWTRM = "HPRNWTRM";

        /// <summary>
        /// HPURNWUOM.
        /// </summary>
        public const string HPURNWUOM = "HPURNWUOM";

        /// <summary>
        /// HPRNWUOM.
        /// </summary>
        public const string HPRNWUOM = "HPRNWUOM";

        /// <summary>
        /// HPUCNTCC.
        /// </summary>
        public const string HPUCNTCC = "HPUCNTCC";

        /// <summary>
        /// HPCMDCDE.
        /// </summary>
        public const string HPCMDCDE = "HPCMDCDE";

        /// <summary>
        /// HPUCNTBYR.
        /// </summary>
        public const string HPUCNTBYR = "HPUCNTBYR";

        /// <summary>
        /// HPCNTRTBYR.
        /// </summary>
        public const string HPCNTRTBYR = "HPCNTRTBYR";

        /// <summary>
        /// HPCLSID.
        /// </summary>
        public const string HPCLSID = "HPCLSID";

        /// <summary>
        /// HPCUPDLVL.
        /// </summary>
        public const string HPCUPDLVL = "HPCUPDLVL";

        /// <summary>
        /// HPUCNTAB01.
        /// </summary>
        public const string HPUCNTAB01 = "HPUCNTAB01";

        /// <summary>
        /// HPCNTRAB01.
        /// </summary>
        public const string HPCNTRAB01 = "HPCNTRAB01";

        /// <summary>
        /// HPUCNTAB02.
        /// </summary>
        public const string HPUCNTAB02 = "HPUCNTAB02";

        /// <summary>
        /// HPCNTRAB02.
        /// </summary>
        public const string HPCNTRAB02 = "HPCNTRAB02";

        /// <summary>
        /// HPUCNTAB03.
        /// </summary>
        public const string HPUCNTAB03 = "HPUCNTAB03";

        /// <summary>
        /// HPCNTRAB03.
        /// </summary>
        public const string HPCNTRAB03 = "HPCNTRAB03";

        /// <summary>
        /// HPUCNTAB04.
        /// </summary>
        public const string HPUCNTAB04 = "HPUCNTAB04";

        /// <summary>
        /// HPCNTRAB04.
        /// </summary>
        public const string HPCNTRAB04 = "HPCNTRAB04";

        /// <summary>
        /// HPUCNTAB05.
        /// </summary>
        public const string HPUCNTAB05 = "HPUCNTAB05";

        /// <summary>
        /// HPCNTRAB05.
        /// </summary>
        public const string HPCNTRAB05 = "HPCNTRAB05";

        /// <summary>
        /// HPUCNTAB06.
        /// </summary>
        public const string HPUCNTAB06 = "HPUCNTAB06";

        /// <summary>
        /// HPCNTRAB06.
        /// </summary>
        public const string HPCNTRAB06 = "HPCNTRAB06";

        /// <summary>
        /// HPUCNTAB07.
        /// </summary>
        public const string HPUCNTAB07 = "HPUCNTAB07";

        /// <summary>
        /// HPCNTRAB07.
        /// </summary>
        public const string HPCNTRAB07 = "HPCNTRAB07";

        /// <summary>
        /// HPUCNTAB08.
        /// </summary>
        public const string HPUCNTAB08 = "HPUCNTAB08";

        /// <summary>
        /// HPCNTRAB08.
        /// </summary>
        public const string HPCNTRAB08 = "HPCNTRAB08";

        /// <summary>
        /// HPUCNTAB09.
        /// </summary>
        public const string HPUCNTAB09 = "HPUCNTAB09";

        /// <summary>
        /// HPCNTRAB09.
        /// </summary>
        public const string HPCNTRAB09 = "HPCNTRAB09";

        /// <summary>
        /// HPUCNTAB10.
        /// </summary>
        public const string HPUCNTAB10 = "HPUCNTAB10";

        /// <summary>
        /// HPCNTRAB10.
        /// </summary>
        public const string HPCNTRAB10 = "HPCNTRAB10";

        /// <summary>
        /// HPUCNTAB11.
        /// </summary>
        public const string HPUCNTAB11 = "HPUCNTAB11";

        /// <summary>
        /// HPCNTRAB11.
        /// </summary>
        public const string HPCNTRAB11 = "HPCNTRAB11";

        /// <summary>
        /// HPUCNTAB12.
        /// </summary>
        public const string HPUCNTAB12 = "HPUCNTAB12";

        /// <summary>
        /// HPCNTRAB12.
        /// </summary>
        public const string HPCNTRAB12 = "HPCNTRAB12";

        /// <summary>
        /// HPUCNTCD01.
        /// </summary>
        public const string HPUCNTCD01 = "HPUCNTCD01";

        /// <summary>
        /// HPCNTRT01.
        /// </summary>
        public const string HPCNTRT01 = "HPCNTRT01";

        /// <summary>
        /// HPUCNTCD02.
        /// </summary>
        public const string HPUCNTCD02 = "HPUCNTCD02";

        /// <summary>
        /// HPCNTRT02.
        /// </summary>
        public const string HPCNTRT02 = "HPCNTRT02";

        /// <summary>
        /// HPUCNTCD03.
        /// </summary>
        public const string HPUCNTCD03 = "HPUCNTCD03";

        /// <summary>
        /// HPUCNTCD04.
        /// </summary>
        public const string HPUCNTCD04 = "HPUCNTCD04";

        /// <summary>
        /// HPCNTRT03.
        /// </summary>
        public const string HPCNTRT03 = "HPCNTRT03";

        /// <summary>
        /// HPCNTRT04.
        /// </summary>
        public const string HPCNTRT04 = "HPCNTRT04";

        /// <summary>
        /// HPUCNTCD05.
        /// </summary>
        public const string HPUCNTCD05 = "HPUCNTCD05";

        /// <summary>
        /// HPCNTRT05.
        /// </summary>
        public const string HPCNTRT05 = "HPCNTRT05";

        /// <summary>
        /// HPUCNTCD06.
        /// </summary>
        public const string HPUCNTCD06 = "HPUCNTCD06";

        /// <summary>
        /// HPCNTRT06.
        /// </summary>
        public const string HPCNTRT06 = "HPCNTRT06";

        /// <summary>
        /// HPUCNTCD07.
        /// </summary>
        public const string HPUCNTCD07 = "HPUCNTCD07";

        /// <summary>
        /// HPCNTRT07.
        /// </summary>
        public const string HPCNTRT07 = "HPCNTRT07";

        /// <summary>
        /// HPUCNTCD08.
        /// </summary>
        public const string HPUCNTCD08 = "HPUCNTCD08";

        /// <summary>
        /// HPCNTRT08.
        /// </summary>
        public const string HPCNTRT08 = "HPCNTRT08";

        /// <summary>
        /// HPUCNTCD09.
        /// </summary>
        public const string HPUCNTCD09 = "HPUCNTCD09";

        /// <summary>
        /// HPCNTRT09.
        /// </summary>
        public const string HPCNTRT09 = "HPCNTRT09";

        /// <summary>
        /// HPUCNTCD10.
        /// </summary>
        public const string HPUCNTCD10 = "HPUCNTCD10";

        /// <summary>
        /// HPCNTRT10.
        /// </summary>
        public const string HPCNTRT10 = "HPCNTRT10";

        /// <summary>
        /// HPUCNTCD11.
        /// </summary>
        public const string HPUCNTCD11 = "HPUCNTCD11";

        /// <summary>
        /// HPCNTRT11.
        /// </summary>
        public const string HPCNTRT11 = "HPCNTRT11";

        /// <summary>
        /// HPUCNTCD12.
        /// </summary>
        public const string HPUCNTCD12 = "HPUCNTCD12";

        /// <summary>
        /// HPCNTRT12.
        /// </summary>
        public const string HPCNTRT12 = "HPCNTRT12";

        /// <summary>
        /// HPUCNTCD13.
        /// </summary>
        public const string HPUCNTCD13 = "HPUCNTCD13";

        /// <summary>
        /// HPCNTRT13.
        /// </summary>
        public const string HPCNTRT13 = "HPCNTRT13";

        /// <summary>
        /// HPUCNTCD14.
        /// </summary>
        public const string HPUCNTCD14 = "HPUCNTCD14";

        /// <summary>
        /// HPCNTRT14.
        /// </summary>
        public const string HPCNTRT14 = "HPCNTRT14";

        /// <summary>
        /// HPUCNTCD15.
        /// </summary>
        public const string HPUCNTCD15 = "HPUCNTCD15";

        /// <summary>
        /// HPCNTRT15.
        /// </summary>
        public const string HPCNTRT15 = "HPCNTRT15";

        /// <summary>
        /// HPUCNTDT1.
        /// </summary>
        public const string HPUCNTDT1 = "HPUCNTDT1";

        /// <summary>
        /// HPCNTRTDT1.
        /// </summary>
        public const string HPCNTRTDT1 = "HPCNTRTDT1";

        /// <summary>
        /// HPUCNTDT2.
        /// </summary>
        public const string HPUCNTDT2 = "HPUCNTDT2";

        /// <summary>
        /// HPCNTRTDT2.
        /// </summary>
        public const string HPCNTRTDT2 = "HPCNTRTDT2";

        /// <summary>
        /// HPUCNTDT3.
        /// </summary>
        public const string HPUCNTDT3 = "HPUCNTDT3";

        /// <summary>
        /// HPCNTRTDT3.
        /// </summary>
        public const string HPCNTRTDT3 = "HPCNTRTDT3";

        /// <summary>
        /// HPUCNTDT4.
        /// </summary>
        public const string HPUCNTDT4 = "HPUCNTDT4";

        /// <summary>
        /// HPCNTRTDT4.
        /// </summary>
        public const string HPCNTRTDT4 = "HPCNTRTDT4";

        /// <summary>
        /// HPUCNTDT5.
        /// </summary>
        public const string HPUCNTDT5 = "HPUCNTDT5";

        /// <summary>
        /// HPCNTRTDT5.
        /// </summary>
        public const string HPCNTRTDT5 = "HPCNTRTDT5";

        /// <summary>
        /// HPUCNTDT6.
        /// </summary>
        public const string HPUCNTDT6 = "HPUCNTDT6";

        /// <summary>
        /// HPCNTRTDT6.
        /// </summary>
        public const string HPCNTRTDT6 = "HPCNTRTDT6";

        /// <summary>
        /// HPUCNTP1.
        /// </summary>
        public const string HPUCNTP1 = "HPUCNTP1";

        /// <summary>
        /// HPCNTRPT01.
        /// </summary>
        public const string HPCNTRPT01 = "HPCNTRPT01";

        /// <summary>
        /// HPUCNTP2.
        /// </summary>
        public const string HPUCNTP2 = "HPUCNTP2";

        /// <summary>
        /// HPCNTRPT02.
        /// </summary>
        public const string HPCNTRPT02 = "HPCNTRPT02";

        /// <summary>
        /// HPUCNTP3.
        /// </summary>
        public const string HPUCNTP3 = "HPUCNTP3";

        /// <summary>
        /// HPCNTRPT03.
        /// </summary>
        public const string HPCNTRPT03 = "HPCNTRPT03";

        /// <summary>
        /// HPUCNTP4.
        /// </summary>
        public const string HPUCNTP4 = "HPUCNTP4";

        /// <summary>
        /// HPCNTRPT04.
        /// </summary>
        public const string HPCNTRPT04 = "HPCNTRPT04";

        /// <summary>
        /// HPUCNTP5.
        /// </summary>
        public const string HPUCNTP5 = "HPUCNTP5";

        /// <summary>
        /// HPCNTRPT05.
        /// </summary>
        public const string HPCNTRPT05 = "HPCNTRPT05";

        /// <summary>
        /// HPUCNTP6.
        /// </summary>
        public const string HPUCNTP6 = "HPUCNTP6";

        /// <summary>
        /// HPCNTRPT06.
        /// </summary>
        public const string HPCNTRPT06 = "HPCNTRPT06";

        /// <summary>
        /// HPURCD.
        /// </summary>
        public const string HPURCD = "HPURCD";

        /// <summary>
        /// HPURDT.
        /// </summary>
        public const string HPURDT = "HPURDT";

        /// <summary>
        /// HPURAT.
        /// </summary>
        public const string HPURAT = "HPURAT";

        /// <summary>
        /// HPURAB.
        /// </summary>
        public const string HPURAB = "HPURAB";

        /// <summary>
        /// HPURRF.
        /// </summary>
        public const string HPURRF = "HPURRF";

        /// <summary>
        /// HPTORG.
        /// </summary>
        public const string HPTORG = "HPTORG";

        /// <summary>
        /// HPUSER.
        /// </summary>
        public const string HPUSER = "HPUSER";

        /// <summary>
        /// HPPID.
        /// </summary>
        public const string HPPID = "HPPID";

        /// <summary>
        /// HPJOBN.
        /// </summary>
        public const string HPJOBN = "HPJOBN";

        /// <summary>
        /// HPUUPMJ.
        /// </summary>
        public const string HPUUPMJ = "HPUUPMJ";

        /// <summary>
        /// HPCNTPTCB.
        /// </summary>
        public const string HPCNTPTCB = "HPCNTPTCB";
    }

    /// <inheritdoc />
    public override string TableName => "F43C010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HPCTRPRID", "HPCTRPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("HPCTRPRDES", "HPCTRPRDES", JdeDataType.String, 80),
        new JdeField("HPUCNTRTYP", "HPUCNTRTYP", JdeDataType.String, 2),
        new JdeField("HPCNTRTTYP", "HPCNTRTTYP", JdeDataType.String, 20),
        new JdeField("HPUCNTSTS", "HPUCNTSTS", JdeDataType.String, 2),
        new JdeField("HPCNTRTSTS", "HPCNTRTSTS", JdeDataType.String, 6),
        new JdeField("HPUCNTENT", "HPUCNTENT", JdeDataType.String, 2),
        new JdeField("HPCNTRTENT", "HPCNTRTENT", JdeDataType.Numeric),
        new JdeField("HPUCNTMGR", "HPUCNTMGR", JdeDataType.String, 2),
        new JdeField("HPCNTRTMGR", "HPCNTRTMGR", JdeDataType.Numeric),
        new JdeField("HPUCNTPT", "HPUCNTPT", JdeDataType.String, 2),
        new JdeField("HPCNTRTPT", "HPCNTRTPT", JdeDataType.String, 6),
        new JdeField("HPUCNTDF", "HPUCNTDF", JdeDataType.String, 2),
        new JdeField("HPCNTRTDF", "HPCNTRTDF", JdeDataType.String, 6),
        new JdeField("HPUOWNER", "HPUOWNER", JdeDataType.String, 2),
        new JdeField("HPOWNERSP", "HPOWNERSP", JdeDataType.String, 6),
        new JdeField("HPUCNTRTSD", "HPUCNTRTSD", JdeDataType.String, 2),
        new JdeField("HPCNTRTSD", "HPCNTRTSD", JdeDataType.Date),
        new JdeField("HPUCNTRTED", "HPUCNTRTED", JdeDataType.String, 2),
        new JdeField("HPCNTRTED", "HPCNTRTED", JdeDataType.Date),
        new JdeField("HPURNWTYP", "HPURNWTYP", JdeDataType.String, 2),
        new JdeField("HPRNWTYPE", "HPRNWTYPE", JdeDataType.String, 6),
        new JdeField("HPURNWED", "HPURNWED", JdeDataType.String, 2),
        new JdeField("HPRNWEDTE", "HPRNWEDTE", JdeDataType.Date),
        new JdeField("HPUCNTRD", "HPUCNTRD", JdeDataType.String, 2),
        new JdeField("HPCNTRD", "HPCNTRD", JdeDataType.Date),
        new JdeField("HPURNWTRM", "HPURNWTRM", JdeDataType.String, 2),
        new JdeField("HPRNWTRM", "HPRNWTRM", JdeDataType.Numeric),
        new JdeField("HPURNWUOM", "HPURNWUOM", JdeDataType.String, 2),
        new JdeField("HPRNWUOM", "HPRNWUOM", JdeDataType.String, 6),
        new JdeField("HPUCNTCC", "HPUCNTCC", JdeDataType.String, 2),
        new JdeField("HPCMDCDE", "HPCMDCDE", JdeDataType.String, 30),
        new JdeField("HPUCNTBYR", "HPUCNTBYR", JdeDataType.String, 2),
        new JdeField("HPCNTRTBYR", "HPCNTRTBYR", JdeDataType.Numeric),
        new JdeField("HPCLSID", "HPCLSID", JdeDataType.Numeric),
        new JdeField("HPCUPDLVL", "HPCUPDLVL", JdeDataType.String, 2),
        new JdeField("HPUCNTAB01", "HPUCNTAB01", JdeDataType.String, 2),
        new JdeField("HPCNTRAB01", "HPCNTRAB01", JdeDataType.Numeric),
        new JdeField("HPUCNTAB02", "HPUCNTAB02", JdeDataType.String, 2),
        new JdeField("HPCNTRAB02", "HPCNTRAB02", JdeDataType.Numeric),
        new JdeField("HPUCNTAB03", "HPUCNTAB03", JdeDataType.String, 2),
        new JdeField("HPCNTRAB03", "HPCNTRAB03", JdeDataType.Numeric),
        new JdeField("HPUCNTAB04", "HPUCNTAB04", JdeDataType.String, 2),
        new JdeField("HPCNTRAB04", "HPCNTRAB04", JdeDataType.Numeric),
        new JdeField("HPUCNTAB05", "HPUCNTAB05", JdeDataType.String, 2),
        new JdeField("HPCNTRAB05", "HPCNTRAB05", JdeDataType.Numeric),
        new JdeField("HPUCNTAB06", "HPUCNTAB06", JdeDataType.String, 2),
        new JdeField("HPCNTRAB06", "HPCNTRAB06", JdeDataType.Numeric),
        new JdeField("HPUCNTAB07", "HPUCNTAB07", JdeDataType.String, 2),
        new JdeField("HPCNTRAB07", "HPCNTRAB07", JdeDataType.Numeric),
        new JdeField("HPUCNTAB08", "HPUCNTAB08", JdeDataType.String, 2),
        new JdeField("HPCNTRAB08", "HPCNTRAB08", JdeDataType.Numeric),
        new JdeField("HPUCNTAB09", "HPUCNTAB09", JdeDataType.String, 2),
        new JdeField("HPCNTRAB09", "HPCNTRAB09", JdeDataType.Numeric),
        new JdeField("HPUCNTAB10", "HPUCNTAB10", JdeDataType.String, 2),
        new JdeField("HPCNTRAB10", "HPCNTRAB10", JdeDataType.Numeric),
        new JdeField("HPUCNTAB11", "HPUCNTAB11", JdeDataType.String, 2),
        new JdeField("HPCNTRAB11", "HPCNTRAB11", JdeDataType.Numeric),
        new JdeField("HPUCNTAB12", "HPUCNTAB12", JdeDataType.String, 2),
        new JdeField("HPCNTRAB12", "HPCNTRAB12", JdeDataType.Numeric),
        new JdeField("HPUCNTCD01", "HPUCNTCD01", JdeDataType.String, 2),
        new JdeField("HPCNTRT01", "HPCNTRT01", JdeDataType.String, 6),
        new JdeField("HPUCNTCD02", "HPUCNTCD02", JdeDataType.String, 2),
        new JdeField("HPCNTRT02", "HPCNTRT02", JdeDataType.String, 6),
        new JdeField("HPUCNTCD03", "HPUCNTCD03", JdeDataType.String, 2),
        new JdeField("HPUCNTCD04", "HPUCNTCD04", JdeDataType.String, 2),
        new JdeField("HPCNTRT03", "HPCNTRT03", JdeDataType.String, 6),
        new JdeField("HPCNTRT04", "HPCNTRT04", JdeDataType.String, 6),
        new JdeField("HPUCNTCD05", "HPUCNTCD05", JdeDataType.String, 2),
        new JdeField("HPCNTRT05", "HPCNTRT05", JdeDataType.String, 6),
        new JdeField("HPUCNTCD06", "HPUCNTCD06", JdeDataType.String, 2),
        new JdeField("HPCNTRT06", "HPCNTRT06", JdeDataType.String, 16),
        new JdeField("HPUCNTCD07", "HPUCNTCD07", JdeDataType.String, 2),
        new JdeField("HPCNTRT07", "HPCNTRT07", JdeDataType.String, 16),
        new JdeField("HPUCNTCD08", "HPUCNTCD08", JdeDataType.String, 2),
        new JdeField("HPCNTRT08", "HPCNTRT08", JdeDataType.String, 16),
        new JdeField("HPUCNTCD09", "HPUCNTCD09", JdeDataType.String, 2),
        new JdeField("HPCNTRT09", "HPCNTRT09", JdeDataType.String, 16),
        new JdeField("HPUCNTCD10", "HPUCNTCD10", JdeDataType.String, 2),
        new JdeField("HPCNTRT10", "HPCNTRT10", JdeDataType.String, 16),
        new JdeField("HPUCNTCD11", "HPUCNTCD11", JdeDataType.String, 2),
        new JdeField("HPCNTRT11", "HPCNTRT11", JdeDataType.String, 20),
        new JdeField("HPUCNTCD12", "HPUCNTCD12", JdeDataType.String, 2),
        new JdeField("HPCNTRT12", "HPCNTRT12", JdeDataType.String, 20),
        new JdeField("HPUCNTCD13", "HPUCNTCD13", JdeDataType.String, 2),
        new JdeField("HPCNTRT13", "HPCNTRT13", JdeDataType.String, 20),
        new JdeField("HPUCNTCD14", "HPUCNTCD14", JdeDataType.String, 2),
        new JdeField("HPCNTRT14", "HPCNTRT14", JdeDataType.String, 20),
        new JdeField("HPUCNTCD15", "HPUCNTCD15", JdeDataType.String, 2),
        new JdeField("HPCNTRT15", "HPCNTRT15", JdeDataType.String, 20),
        new JdeField("HPUCNTDT1", "HPUCNTDT1", JdeDataType.String, 2),
        new JdeField("HPCNTRTDT1", "HPCNTRTDT1", JdeDataType.Numeric),
        new JdeField("HPUCNTDT2", "HPUCNTDT2", JdeDataType.String, 2),
        new JdeField("HPCNTRTDT2", "HPCNTRTDT2", JdeDataType.Numeric),
        new JdeField("HPUCNTDT3", "HPUCNTDT3", JdeDataType.String, 2),
        new JdeField("HPCNTRTDT3", "HPCNTRTDT3", JdeDataType.Numeric),
        new JdeField("HPUCNTDT4", "HPUCNTDT4", JdeDataType.String, 2),
        new JdeField("HPCNTRTDT4", "HPCNTRTDT4", JdeDataType.Numeric),
        new JdeField("HPUCNTDT5", "HPUCNTDT5", JdeDataType.String, 2),
        new JdeField("HPCNTRTDT5", "HPCNTRTDT5", JdeDataType.Numeric),
        new JdeField("HPUCNTDT6", "HPUCNTDT6", JdeDataType.String, 2),
        new JdeField("HPCNTRTDT6", "HPCNTRTDT6", JdeDataType.Numeric),
        new JdeField("HPUCNTP1", "HPUCNTP1", JdeDataType.String, 2),
        new JdeField("HPCNTRPT01", "HPCNTRPT01", JdeDataType.String, 2),
        new JdeField("HPUCNTP2", "HPUCNTP2", JdeDataType.String, 2),
        new JdeField("HPCNTRPT02", "HPCNTRPT02", JdeDataType.String, 2),
        new JdeField("HPUCNTP3", "HPUCNTP3", JdeDataType.String, 2),
        new JdeField("HPCNTRPT03", "HPCNTRPT03", JdeDataType.String, 2),
        new JdeField("HPUCNTP4", "HPUCNTP4", JdeDataType.String, 2),
        new JdeField("HPCNTRPT04", "HPCNTRPT04", JdeDataType.String, 2),
        new JdeField("HPUCNTP5", "HPUCNTP5", JdeDataType.String, 2),
        new JdeField("HPCNTRPT05", "HPCNTRPT05", JdeDataType.String, 2),
        new JdeField("HPUCNTP6", "HPUCNTP6", JdeDataType.String, 2),
        new JdeField("HPCNTRPT06", "HPCNTRPT06", JdeDataType.String, 2),
        new JdeField("HPURCD", "HPURCD", JdeDataType.String, 4),
        new JdeField("HPURDT", "HPURDT", JdeDataType.Numeric),
        new JdeField("HPURAT", "HPURAT", JdeDataType.Numeric),
        new JdeField("HPURAB", "HPURAB", JdeDataType.Numeric),
        new JdeField("HPURRF", "HPURRF", JdeDataType.String, 30),
        new JdeField("HPTORG", "HPTORG", JdeDataType.String, 20),
        new JdeField("HPUSER", "HPUSER", JdeDataType.String, 20),
        new JdeField("HPPID", "HPPID", JdeDataType.String, 20),
        new JdeField("HPJOBN", "HPJOBN", JdeDataType.String, 20),
        new JdeField("HPUUPMJ", "HPUUPMJ", JdeDataType.Date),
        new JdeField("HPCNTPTCB", "HPCNTPTCB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C010_0", "Primary Key on HPCTRPRID", new[] { "HPCTRPRID" }, isUnique: true, isPrimaryKey: true)
    };
}
