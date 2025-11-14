using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F004201 - .
/// </summary>
public class F004201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTDOCO.
        /// </summary>
        public const string PTDOCO = "PTDOCO";

        /// <summary>
        /// PTDCTO.
        /// </summary>
        public const string PTDCTO = "PTDCTO";

        /// <summary>
        /// PTKCOO.
        /// </summary>
        public const string PTKCOO = "PTKCOO";

        /// <summary>
        /// PTSFXO.
        /// </summary>
        public const string PTSFXO = "PTSFXO";

        /// <summary>
        /// PTLNID.
        /// </summary>
        public const string PTLNID = "PTLNID";

        /// <summary>
        /// PTSEQ.
        /// </summary>
        public const string PTSEQ = "PTSEQ";

        /// <summary>
        /// PTPOF.
        /// </summary>
        public const string PTPOF = "PTPOF";

        /// <summary>
        /// PTRYIN.
        /// </summary>
        public const string PTRYIN = "PTRYIN";

        /// <summary>
        /// PTATS.
        /// </summary>
        public const string PTATS = "PTATS";

        /// <summary>
        /// PTPERE.
        /// </summary>
        public const string PTPERE = "PTPERE";

        /// <summary>
        /// PTATRD.
        /// </summary>
        public const string PTATRD = "PTATRD";

        /// <summary>
        /// PTATRM.
        /// </summary>
        public const string PTATRM = "PTATRM";

        /// <summary>
        /// PTABTM.
        /// </summary>
        public const string PTABTM = "PTABTM";

        /// <summary>
        /// PTATRI.
        /// </summary>
        public const string PTATRI = "PTATRI";

        /// <summary>
        /// PTAEXD.
        /// </summary>
        public const string PTAEXD = "PTAEXD";

        /// <summary>
        /// PTSETD.
        /// </summary>
        public const string PTSETD = "PTSETD";

        /// <summary>
        /// PTSTRM.
        /// </summary>
        public const string PTSTRM = "PTSTRM";

        /// <summary>
        /// PTSBTM.
        /// </summary>
        public const string PTSBTM = "PTSBTM";

        /// <summary>
        /// PTSEMD.
        /// </summary>
        public const string PTSEMD = "PTSEMD";

        /// <summary>
        /// PTTRFC.
        /// </summary>
        public const string PTTRFC = "PTTRFC";

        /// <summary>
        /// PTTFEE.
        /// </summary>
        public const string PTTFEE = "PTTFEE";

        /// <summary>
        /// PTALPH.
        /// </summary>
        public const string PTALPH = "PTALPH";

        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTADD1.
        /// </summary>
        public const string PTADD1 = "PTADD1";

        /// <summary>
        /// PTADD2.
        /// </summary>
        public const string PTADD2 = "PTADD2";

        /// <summary>
        /// PTCTY1.
        /// </summary>
        public const string PTCTY1 = "PTCTY1";

        /// <summary>
        /// PTADDS.
        /// </summary>
        public const string PTADDS = "PTADDS";

        /// <summary>
        /// PTMSZC.
        /// </summary>
        public const string PTMSZC = "PTMSZC";

        /// <summary>
        /// PTCTR.
        /// </summary>
        public const string PTCTR = "PTCTR";

        /// <summary>
        /// PTCBNK.
        /// </summary>
        public const string PTCBNK = "PTCBNK";

        /// <summary>
        /// PTCEXP.
        /// </summary>
        public const string PTCEXP = "PTCEXP";

        /// <summary>
        /// PTCARD.
        /// </summary>
        public const string PTCARD = "PTCARD";

        /// <summary>
        /// PTDL01.
        /// </summary>
        public const string PTDL01 = "PTDL01";

        /// <summary>
        /// PTCRCI.
        /// </summary>
        public const string PTCRCI = "PTCRCI";

        /// <summary>
        /// PTCASP.
        /// </summary>
        public const string PTCASP = "PTCASP";

        /// <summary>
        /// PTCHKP.
        /// </summary>
        public const string PTCHKP = "PTCHKP";

        /// <summary>
        /// PTCKNU.
        /// </summary>
        public const string PTCKNU = "PTCKNU";

        /// <summary>
        /// PTOPY1.
        /// </summary>
        public const string PTOPY1 = "PTOPY1";

        /// <summary>
        /// PTOPY2.
        /// </summary>
        public const string PTOPY2 = "PTOPY2";

        /// <summary>
        /// PTCRCD.
        /// </summary>
        public const string PTCRCD = "PTCRCD";

        /// <summary>
        /// PTSHAN.
        /// </summary>
        public const string PTSHAN = "PTSHAN";

        /// <summary>
        /// PTEMCU.
        /// </summary>
        public const string PTEMCU = "PTEMCU";

        /// <summary>
        /// PTMCU.
        /// </summary>
        public const string PTMCU = "PTMCU";

        /// <summary>
        /// PTTRDJ.
        /// </summary>
        public const string PTTRDJ = "PTTRDJ";

        /// <summary>
        /// PTITM.
        /// </summary>
        public const string PTITM = "PTITM";

        /// <summary>
        /// PTLNTY.
        /// </summary>
        public const string PTLNTY = "PTLNTY";

        /// <summary>
        /// PTUORG.
        /// </summary>
        public const string PTUORG = "PTUORG";

        /// <summary>
        /// PTPTC.
        /// </summary>
        public const string PTPTC = "PTPTC";

        /// <summary>
        /// PTTXA1.
        /// </summary>
        public const string PTTXA1 = "PTTXA1";

        /// <summary>
        /// PTTAX1.
        /// </summary>
        public const string PTTAX1 = "PTTAX1";

        /// <summary>
        /// PTEXR1.
        /// </summary>
        public const string PTEXR1 = "PTEXR1";

        /// <summary>
        /// PTSTAM.
        /// </summary>
        public const string PTSTAM = "PTSTAM";

        /// <summary>
        /// PTFUT1.
        /// </summary>
        public const string PTFUT1 = "PTFUT1";

        /// <summary>
        /// PTFUT2.
        /// </summary>
        public const string PTFUT2 = "PTFUT2";

        /// <summary>
        /// PTFUT3.
        /// </summary>
        public const string PTFUT3 = "PTFUT3";

        /// <summary>
        /// PTFUT4.
        /// </summary>
        public const string PTFUT4 = "PTFUT4";

        /// <summary>
        /// PTFUT5.
        /// </summary>
        public const string PTFUT5 = "PTFUT5";

        /// <summary>
        /// PTFFG1.
        /// </summary>
        public const string PTFFG1 = "PTFFG1";

        /// <summary>
        /// PTFFG2.
        /// </summary>
        public const string PTFFG2 = "PTFFG2";

        /// <summary>
        /// PTURCD.
        /// </summary>
        public const string PTURCD = "PTURCD";

        /// <summary>
        /// PTURDT.
        /// </summary>
        public const string PTURDT = "PTURDT";

        /// <summary>
        /// PTURAT.
        /// </summary>
        public const string PTURAT = "PTURAT";

        /// <summary>
        /// PTURAB.
        /// </summary>
        public const string PTURAB = "PTURAB";

        /// <summary>
        /// PTURRF.
        /// </summary>
        public const string PTURRF = "PTURRF";

        /// <summary>
        /// PTTORG.
        /// </summary>
        public const string PTTORG = "PTTORG";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTTDAY.
        /// </summary>
        public const string PTTDAY = "PTTDAY";

        /// <summary>
        /// PTFFG3.
        /// </summary>
        public const string PTFFG3 = "PTFFG3";

        /// <summary>
        /// PTFFG4.
        /// </summary>
        public const string PTFFG4 = "PTFFG4";
    }

    /// <inheritdoc />
    public override string TableName => "F004201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTDOCO", "PTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDCTO", "PTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PTKCOO", "PTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PTSFXO", "PTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PTLNID", "PTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PTSEQ", "PTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PTPOF", "PTPOF", JdeDataType.String, 4, true, true),
        new JdeField("PTRYIN", "PTRYIN", JdeDataType.String, 2),
        new JdeField("PTATS", "PTATS", JdeDataType.String, 4),
        new JdeField("PTPERE", "PTPERE", JdeDataType.String, 6),
        new JdeField("PTATRD", "PTATRD", JdeDataType.Numeric),
        new JdeField("PTATRM", "PTATRM", JdeDataType.Numeric),
        new JdeField("PTABTM", "PTABTM", JdeDataType.String, 60),
        new JdeField("PTATRI", "PTATRI", JdeDataType.String, 50),
        new JdeField("PTAEXD", "PTAEXD", JdeDataType.Numeric),
        new JdeField("PTSETD", "PTSETD", JdeDataType.Numeric),
        new JdeField("PTSTRM", "PTSTRM", JdeDataType.Numeric),
        new JdeField("PTSBTM", "PTSBTM", JdeDataType.Numeric),
        new JdeField("PTSEMD", "PTSEMD", JdeDataType.Numeric),
        new JdeField("PTTRFC", "PTTRFC", JdeDataType.String, 20),
        new JdeField("PTTFEE", "PTTFEE", JdeDataType.Numeric),
        new JdeField("PTALPH", "PTALPH", JdeDataType.String, 80),
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric),
        new JdeField("PTADD1", "PTADD1", JdeDataType.String, 80),
        new JdeField("PTADD2", "PTADD2", JdeDataType.String, 80),
        new JdeField("PTCTY1", "PTCTY1", JdeDataType.String, 50),
        new JdeField("PTADDS", "PTADDS", JdeDataType.String, 6),
        new JdeField("PTMSZC", "PTMSZC", JdeDataType.String, 10),
        new JdeField("PTCTR", "PTCTR", JdeDataType.String, 6),
        new JdeField("PTCBNK", "PTCBNK", JdeDataType.String, 40),
        new JdeField("PTCEXP", "PTCEXP", JdeDataType.Numeric),
        new JdeField("PTCARD", "PTCARD", JdeDataType.String, 8),
        new JdeField("PTDL01", "PTDL01", JdeDataType.String, 60),
        new JdeField("PTCRCI", "PTCRCI", JdeDataType.String, 50),
        new JdeField("PTCASP", "PTCASP", JdeDataType.Numeric),
        new JdeField("PTCHKP", "PTCHKP", JdeDataType.Numeric),
        new JdeField("PTCKNU", "PTCKNU", JdeDataType.String, 50),
        new JdeField("PTOPY1", "PTOPY1", JdeDataType.Numeric),
        new JdeField("PTOPY2", "PTOPY2", JdeDataType.Numeric),
        new JdeField("PTCRCD", "PTCRCD", JdeDataType.String, 6),
        new JdeField("PTSHAN", "PTSHAN", JdeDataType.Numeric),
        new JdeField("PTEMCU", "PTEMCU", JdeDataType.String, 24),
        new JdeField("PTMCU", "PTMCU", JdeDataType.String, 24),
        new JdeField("PTTRDJ", "PTTRDJ", JdeDataType.Numeric),
        new JdeField("PTITM", "PTITM", JdeDataType.Numeric),
        new JdeField("PTLNTY", "PTLNTY", JdeDataType.String, 4),
        new JdeField("PTUORG", "PTUORG", JdeDataType.Numeric),
        new JdeField("PTPTC", "PTPTC", JdeDataType.String, 6),
        new JdeField("PTTXA1", "PTTXA1", JdeDataType.String, 20),
        new JdeField("PTTAX1", "PTTAX1", JdeDataType.String, 2),
        new JdeField("PTEXR1", "PTEXR1", JdeDataType.String, 4),
        new JdeField("PTSTAM", "PTSTAM", JdeDataType.Numeric),
        new JdeField("PTFUT1", "PTFUT1", JdeDataType.Numeric),
        new JdeField("PTFUT2", "PTFUT2", JdeDataType.Numeric),
        new JdeField("PTFUT3", "PTFUT3", JdeDataType.String, 60),
        new JdeField("PTFUT4", "PTFUT4", JdeDataType.String, 50),
        new JdeField("PTFUT5", "PTFUT5", JdeDataType.String, 50),
        new JdeField("PTFFG1", "PTFFG1", JdeDataType.String, 2),
        new JdeField("PTFFG2", "PTFFG2", JdeDataType.String, 2),
        new JdeField("PTURCD", "PTURCD", JdeDataType.String, 4),
        new JdeField("PTURDT", "PTURDT", JdeDataType.Numeric),
        new JdeField("PTURAT", "PTURAT", JdeDataType.Numeric),
        new JdeField("PTURAB", "PTURAB", JdeDataType.Numeric),
        new JdeField("PTURRF", "PTURRF", JdeDataType.String, 30),
        new JdeField("PTTORG", "PTTORG", JdeDataType.String, 20),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric),
        new JdeField("PTFFG3", "PTFFG3", JdeDataType.String, 2),
        new JdeField("PTFFG4", "PTFFG4", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F004201_0", "Primary Key on PTDOCO, PTDCTO, PTKCOO, PTSFXO, PTLNID, PTSEQ, PTPOF", new[] { "PTDOCO", "PTDCTO", "PTKCOO", "PTSFXO", "PTLNID", "PTSEQ", "PTPOF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F004201_4", "Index on PTDOCO, PTDCTO, PTKCOO, PTSFXO, PTSEQ, PTPOF", new[] { "PTDOCO", "PTDCTO", "PTKCOO", "PTSFXO", "PTSEQ", "PTPOF" }),
        new JdeIndex("F004201_5", "Index on PTRYIN, PTDOCO, PTDCTO, PTKCOO, PTPOF", new[] { "PTRYIN", "PTDOCO", "PTDCTO", "PTKCOO", "PTPOF" })
    };
}
