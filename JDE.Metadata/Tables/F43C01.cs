using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C01 - .
/// </summary>
public class F43C01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHCNTRTID.
        /// </summary>
        public const string CHCNTRTID = "CHCNTRTID";

        /// <summary>
        /// CHCNTRTTYP.
        /// </summary>
        public const string CHCNTRTTYP = "CHCNTRTTYP";

        /// <summary>
        /// CHCNTRTNM.
        /// </summary>
        public const string CHCNTRTNM = "CHCNTRTNM";

        /// <summary>
        /// CHCNTRTCD.
        /// </summary>
        public const string CHCNTRTCD = "CHCNTRTCD";

        /// <summary>
        /// CHCNTRTSTS.
        /// </summary>
        public const string CHCNTRTSTS = "CHCNTRTSTS";

        /// <summary>
        /// CHCNTRAMT.
        /// </summary>
        public const string CHCNTRAMT = "CHCNTRAMT";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHCNTRTENT.
        /// </summary>
        public const string CHCNTRTENT = "CHCNTRTENT";

        /// <summary>
        /// CHCNTRCRDC.
        /// </summary>
        public const string CHCNTRCRDC = "CHCNTRCRDC";

        /// <summary>
        /// CHPTC.
        /// </summary>
        public const string CHPTC = "CHPTC";

        /// <summary>
        /// CHCNTRTMGR.
        /// </summary>
        public const string CHCNTRTMGR = "CHCNTRTMGR";

        /// <summary>
        /// CHCNTRTPT.
        /// </summary>
        public const string CHCNTRTPT = "CHCNTRTPT";

        /// <summary>
        /// CHCNTRTDF.
        /// </summary>
        public const string CHCNTRTDF = "CHCNTRTDF";

        /// <summary>
        /// CHOWNERSP.
        /// </summary>
        public const string CHOWNERSP = "CHOWNERSP";

        /// <summary>
        /// CHCNTRTSD.
        /// </summary>
        public const string CHCNTRTSD = "CHCNTRTSD";

        /// <summary>
        /// CHCNTRTED.
        /// </summary>
        public const string CHCNTRTED = "CHCNTRTED";

        /// <summary>
        /// CHRNWTYPE.
        /// </summary>
        public const string CHRNWTYPE = "CHRNWTYPE";

        /// <summary>
        /// CHRNWEDTE.
        /// </summary>
        public const string CHRNWEDTE = "CHRNWEDTE";

        /// <summary>
        /// CHCNTRD.
        /// </summary>
        public const string CHCNTRD = "CHCNTRD";

        /// <summary>
        /// CHRNWTRM.
        /// </summary>
        public const string CHRNWTRM = "CHRNWTRM";

        /// <summary>
        /// CHRNWUOM.
        /// </summary>
        public const string CHRNWUOM = "CHRNWUOM";

        /// <summary>
        /// CHCMDCDE.
        /// </summary>
        public const string CHCMDCDE = "CHCMDCDE";

        /// <summary>
        /// CHGEOCST.
        /// </summary>
        public const string CHGEOCST = "CHGEOCST";

        /// <summary>
        /// CHCNTRTCOM.
        /// </summary>
        public const string CHCNTRTCOM = "CHCNTRTCOM";

        /// <summary>
        /// CHCNTRAB01.
        /// </summary>
        public const string CHCNTRAB01 = "CHCNTRAB01";

        /// <summary>
        /// CHCNTRAB02.
        /// </summary>
        public const string CHCNTRAB02 = "CHCNTRAB02";

        /// <summary>
        /// CHCNTRAB03.
        /// </summary>
        public const string CHCNTRAB03 = "CHCNTRAB03";

        /// <summary>
        /// CHCNTRAB04.
        /// </summary>
        public const string CHCNTRAB04 = "CHCNTRAB04";

        /// <summary>
        /// CHCNTRAB05.
        /// </summary>
        public const string CHCNTRAB05 = "CHCNTRAB05";

        /// <summary>
        /// CHCNTRAB06.
        /// </summary>
        public const string CHCNTRAB06 = "CHCNTRAB06";

        /// <summary>
        /// CHCNTRAB07.
        /// </summary>
        public const string CHCNTRAB07 = "CHCNTRAB07";

        /// <summary>
        /// CHCNTRAB08.
        /// </summary>
        public const string CHCNTRAB08 = "CHCNTRAB08";

        /// <summary>
        /// CHCNTRAB09.
        /// </summary>
        public const string CHCNTRAB09 = "CHCNTRAB09";

        /// <summary>
        /// CHCNTRAB10.
        /// </summary>
        public const string CHCNTRAB10 = "CHCNTRAB10";

        /// <summary>
        /// CHCNTRAB11.
        /// </summary>
        public const string CHCNTRAB11 = "CHCNTRAB11";

        /// <summary>
        /// CHCNTRAB12.
        /// </summary>
        public const string CHCNTRAB12 = "CHCNTRAB12";

        /// <summary>
        /// CHCNTRT01.
        /// </summary>
        public const string CHCNTRT01 = "CHCNTRT01";

        /// <summary>
        /// CHCNTRT02.
        /// </summary>
        public const string CHCNTRT02 = "CHCNTRT02";

        /// <summary>
        /// CHCNTRT03.
        /// </summary>
        public const string CHCNTRT03 = "CHCNTRT03";

        /// <summary>
        /// CHCNTRT04.
        /// </summary>
        public const string CHCNTRT04 = "CHCNTRT04";

        /// <summary>
        /// CHCNTRT05.
        /// </summary>
        public const string CHCNTRT05 = "CHCNTRT05";

        /// <summary>
        /// CHCNTRT06.
        /// </summary>
        public const string CHCNTRT06 = "CHCNTRT06";

        /// <summary>
        /// CHCNTRT07.
        /// </summary>
        public const string CHCNTRT07 = "CHCNTRT07";

        /// <summary>
        /// CHCNTRT08.
        /// </summary>
        public const string CHCNTRT08 = "CHCNTRT08";

        /// <summary>
        /// CHCNTRT09.
        /// </summary>
        public const string CHCNTRT09 = "CHCNTRT09";

        /// <summary>
        /// CHCNTRT10.
        /// </summary>
        public const string CHCNTRT10 = "CHCNTRT10";

        /// <summary>
        /// CHCNTRT11.
        /// </summary>
        public const string CHCNTRT11 = "CHCNTRT11";

        /// <summary>
        /// CHCNTRT12.
        /// </summary>
        public const string CHCNTRT12 = "CHCNTRT12";

        /// <summary>
        /// CHCNTRT13.
        /// </summary>
        public const string CHCNTRT13 = "CHCNTRT13";

        /// <summary>
        /// CHCNTRT14.
        /// </summary>
        public const string CHCNTRT14 = "CHCNTRT14";

        /// <summary>
        /// CHCNTRT15.
        /// </summary>
        public const string CHCNTRT15 = "CHCNTRT15";

        /// <summary>
        /// CHCNTRTDT1.
        /// </summary>
        public const string CHCNTRTDT1 = "CHCNTRTDT1";

        /// <summary>
        /// CHCNTRTDT2.
        /// </summary>
        public const string CHCNTRTDT2 = "CHCNTRTDT2";

        /// <summary>
        /// CHCNTRTDT3.
        /// </summary>
        public const string CHCNTRTDT3 = "CHCNTRTDT3";

        /// <summary>
        /// CHCNTRTDT4.
        /// </summary>
        public const string CHCNTRTDT4 = "CHCNTRTDT4";

        /// <summary>
        /// CHCNTRTDT5.
        /// </summary>
        public const string CHCNTRTDT5 = "CHCNTRTDT5";

        /// <summary>
        /// CHCNTRTDT6.
        /// </summary>
        public const string CHCNTRTDT6 = "CHCNTRTDT6";

        /// <summary>
        /// CHCNTRPT01.
        /// </summary>
        public const string CHCNTRPT01 = "CHCNTRPT01";

        /// <summary>
        /// CHCNTRPT02.
        /// </summary>
        public const string CHCNTRPT02 = "CHCNTRPT02";

        /// <summary>
        /// CHCNTRPT03.
        /// </summary>
        public const string CHCNTRPT03 = "CHCNTRPT03";

        /// <summary>
        /// CHCNTRPT04.
        /// </summary>
        public const string CHCNTRPT04 = "CHCNTRPT04";

        /// <summary>
        /// CHCNTRPT05.
        /// </summary>
        public const string CHCNTRPT05 = "CHCNTRPT05";

        /// <summary>
        /// CHCNTRPT06.
        /// </summary>
        public const string CHCNTRPT06 = "CHCNTRPT06";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHTORG.
        /// </summary>
        public const string CHTORG = "CHTORG";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUUPMJ.
        /// </summary>
        public const string CHUUPMJ = "CHUUPMJ";

        /// <summary>
        /// CHCNTRTBYR.
        /// </summary>
        public const string CHCNTRTBYR = "CHCNTRTBYR";
    }

    /// <inheritdoc />
    public override string TableName => "F43C01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHCNTRTID", "CHCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCNTRTTYP", "CHCNTRTTYP", JdeDataType.String, 20),
        new JdeField("CHCNTRTNM", "CHCNTRTNM", JdeDataType.String, 60),
        new JdeField("CHCNTRTCD", "CHCNTRTCD", JdeDataType.String, 24),
        new JdeField("CHCNTRTSTS", "CHCNTRTSTS", JdeDataType.String, 6),
        new JdeField("CHCNTRAMT", "CHCNTRAMT", JdeDataType.Numeric),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHCNTRTENT", "CHCNTRTENT", JdeDataType.Numeric),
        new JdeField("CHCNTRCRDC", "CHCNTRCRDC", JdeDataType.String, 6),
        new JdeField("CHPTC", "CHPTC", JdeDataType.String, 6),
        new JdeField("CHCNTRTMGR", "CHCNTRTMGR", JdeDataType.Numeric),
        new JdeField("CHCNTRTPT", "CHCNTRTPT", JdeDataType.String, 6),
        new JdeField("CHCNTRTDF", "CHCNTRTDF", JdeDataType.String, 6),
        new JdeField("CHOWNERSP", "CHOWNERSP", JdeDataType.String, 6),
        new JdeField("CHCNTRTSD", "CHCNTRTSD", JdeDataType.Date),
        new JdeField("CHCNTRTED", "CHCNTRTED", JdeDataType.Date),
        new JdeField("CHRNWTYPE", "CHRNWTYPE", JdeDataType.String, 6),
        new JdeField("CHRNWEDTE", "CHRNWEDTE", JdeDataType.Date),
        new JdeField("CHCNTRD", "CHCNTRD", JdeDataType.Date),
        new JdeField("CHRNWTRM", "CHRNWTRM", JdeDataType.Numeric),
        new JdeField("CHRNWUOM", "CHRNWUOM", JdeDataType.String, 6),
        new JdeField("CHCMDCDE", "CHCMDCDE", JdeDataType.String, 30),
        new JdeField("CHGEOCST", "CHGEOCST", JdeDataType.String, 6),
        new JdeField("CHCNTRTCOM", "CHCNTRTCOM", JdeDataType.String, 510),
        new JdeField("CHCNTRAB01", "CHCNTRAB01", JdeDataType.Numeric),
        new JdeField("CHCNTRAB02", "CHCNTRAB02", JdeDataType.Numeric),
        new JdeField("CHCNTRAB03", "CHCNTRAB03", JdeDataType.Numeric),
        new JdeField("CHCNTRAB04", "CHCNTRAB04", JdeDataType.Numeric),
        new JdeField("CHCNTRAB05", "CHCNTRAB05", JdeDataType.Numeric),
        new JdeField("CHCNTRAB06", "CHCNTRAB06", JdeDataType.Numeric),
        new JdeField("CHCNTRAB07", "CHCNTRAB07", JdeDataType.Numeric),
        new JdeField("CHCNTRAB08", "CHCNTRAB08", JdeDataType.Numeric),
        new JdeField("CHCNTRAB09", "CHCNTRAB09", JdeDataType.Numeric),
        new JdeField("CHCNTRAB10", "CHCNTRAB10", JdeDataType.Numeric),
        new JdeField("CHCNTRAB11", "CHCNTRAB11", JdeDataType.Numeric),
        new JdeField("CHCNTRAB12", "CHCNTRAB12", JdeDataType.Numeric),
        new JdeField("CHCNTRT01", "CHCNTRT01", JdeDataType.String, 6),
        new JdeField("CHCNTRT02", "CHCNTRT02", JdeDataType.String, 6),
        new JdeField("CHCNTRT03", "CHCNTRT03", JdeDataType.String, 6),
        new JdeField("CHCNTRT04", "CHCNTRT04", JdeDataType.String, 6),
        new JdeField("CHCNTRT05", "CHCNTRT05", JdeDataType.String, 6),
        new JdeField("CHCNTRT06", "CHCNTRT06", JdeDataType.String, 16),
        new JdeField("CHCNTRT07", "CHCNTRT07", JdeDataType.String, 16),
        new JdeField("CHCNTRT08", "CHCNTRT08", JdeDataType.String, 16),
        new JdeField("CHCNTRT09", "CHCNTRT09", JdeDataType.String, 16),
        new JdeField("CHCNTRT10", "CHCNTRT10", JdeDataType.String, 16),
        new JdeField("CHCNTRT11", "CHCNTRT11", JdeDataType.String, 20),
        new JdeField("CHCNTRT12", "CHCNTRT12", JdeDataType.String, 20),
        new JdeField("CHCNTRT13", "CHCNTRT13", JdeDataType.String, 20),
        new JdeField("CHCNTRT14", "CHCNTRT14", JdeDataType.String, 20),
        new JdeField("CHCNTRT15", "CHCNTRT15", JdeDataType.String, 20),
        new JdeField("CHCNTRTDT1", "CHCNTRTDT1", JdeDataType.Numeric),
        new JdeField("CHCNTRTDT2", "CHCNTRTDT2", JdeDataType.Numeric),
        new JdeField("CHCNTRTDT3", "CHCNTRTDT3", JdeDataType.Numeric),
        new JdeField("CHCNTRTDT4", "CHCNTRTDT4", JdeDataType.Numeric),
        new JdeField("CHCNTRTDT5", "CHCNTRTDT5", JdeDataType.Numeric),
        new JdeField("CHCNTRTDT6", "CHCNTRTDT6", JdeDataType.Numeric),
        new JdeField("CHCNTRPT01", "CHCNTRPT01", JdeDataType.String, 2),
        new JdeField("CHCNTRPT02", "CHCNTRPT02", JdeDataType.String, 2),
        new JdeField("CHCNTRPT03", "CHCNTRPT03", JdeDataType.String, 2),
        new JdeField("CHCNTRPT04", "CHCNTRPT04", JdeDataType.String, 2),
        new JdeField("CHCNTRPT05", "CHCNTRPT05", JdeDataType.String, 2),
        new JdeField("CHCNTRPT06", "CHCNTRPT06", JdeDataType.String, 2),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHTORG", "CHTORG", JdeDataType.String, 20),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUUPMJ", "CHUUPMJ", JdeDataType.Date),
        new JdeField("CHCNTRTBYR", "CHCNTRTBYR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C01_0", "Primary Key on CHCNTRTID", new[] { "CHCNTRTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C01_2", "Unique Index on CHCNTRTCD", new[] { "CHCNTRTCD" }, isUnique: true)
    };
}
