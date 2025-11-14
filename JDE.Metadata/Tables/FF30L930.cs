using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L930 - .
/// </summary>
public class FF30L930 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRFSCID.
        /// </summary>
        public const string LRFSCID = "LRFSCID";

        /// <summary>
        /// LRTRT.
        /// </summary>
        public const string LRTRT = "LRTRT";

        /// <summary>
        /// LRDFKIT.
        /// </summary>
        public const string LRDFKIT = "LRDFKIT";

        /// <summary>
        /// LRDFMMCU.
        /// </summary>
        public const string LRDFMMCU = "LRDFMMCU";

        /// <summary>
        /// LRALD.
        /// </summary>
        public const string LRALD = "LRALD";

        /// <summary>
        /// LRDSC1.
        /// </summary>
        public const string LRDSC1 = "LRDSC1";

        /// <summary>
        /// LRDFLINE.
        /// </summary>
        public const string LRDFLINE = "LRDFLINE";

        /// <summary>
        /// LRDFMCU.
        /// </summary>
        public const string LRDFMCU = "LRDFMCU";

        /// <summary>
        /// LROPSQ.
        /// </summary>
        public const string LROPSQ = "LROPSQ";

        /// <summary>
        /// LREFFF.
        /// </summary>
        public const string LREFFF = "LREFFF";

        /// <summary>
        /// LREFFT.
        /// </summary>
        public const string LREFFT = "LREFFT";

        /// <summary>
        /// LRBFPF.
        /// </summary>
        public const string LRBFPF = "LRBFPF";

        /// <summary>
        /// LRLAMC.
        /// </summary>
        public const string LRLAMC = "LRLAMC";

        /// <summary>
        /// LRTIMB.
        /// </summary>
        public const string LRTIMB = "LRTIMB";

        /// <summary>
        /// LROPSR.
        /// </summary>
        public const string LROPSR = "LROPSR";

        /// <summary>
        /// LRBQTY.
        /// </summary>
        public const string LRBQTY = "LRBQTY";

        /// <summary>
        /// LRUOM.
        /// </summary>
        public const string LRUOM = "LRUOM";

        /// <summary>
        /// LRPMMST.
        /// </summary>
        public const string LRPMMST = "LRPMMST";

        /// <summary>
        /// LRPMMRT.
        /// </summary>
        public const string LRPMMRT = "LRPMMRT";

        /// <summary>
        /// LRPMMMT.
        /// </summary>
        public const string LRPMMMT = "LRPMMMT";

        /// <summary>
        /// LRPMLST.
        /// </summary>
        public const string LRPMLST = "LRPMLST";

        /// <summary>
        /// LRPMLRT.
        /// </summary>
        public const string LRPMLRT = "LRPMLRT";

        /// <summary>
        /// LRPMLMT.
        /// </summary>
        public const string LRPMLMT = "LRPMLMT";

        /// <summary>
        /// LRPWRT.
        /// </summary>
        public const string LRPWRT = "LRPWRT";

        /// <summary>
        /// LRSETC.
        /// </summary>
        public const string LRSETC = "LRSETC";

        /// <summary>
        /// LRDFQUED.
        /// </summary>
        public const string LRDFQUED = "LRDFQUED";

        /// <summary>
        /// LRLTPC.
        /// </summary>
        public const string LRLTPC = "LRLTPC";

        /// <summary>
        /// LRPOVR.
        /// </summary>
        public const string LRPOVR = "LRPOVR";

        /// <summary>
        /// LRNXOP.
        /// </summary>
        public const string LRNXOP = "LRNXOP";

        /// <summary>
        /// LRDFOPYP.
        /// </summary>
        public const string LRDFOPYP = "LRDFOPYP";

        /// <summary>
        /// LRCPYP.
        /// </summary>
        public const string LRCPYP = "LRCPYP";

        /// <summary>
        /// LRAPID.
        /// </summary>
        public const string LRAPID = "LRAPID";

        /// <summary>
        /// LRSHNO.
        /// </summary>
        public const string LRSHNO = "LRSHNO";

        /// <summary>
        /// LROPSC.
        /// </summary>
        public const string LROPSC = "LROPSC";

        /// <summary>
        /// LRINPE.
        /// </summary>
        public const string LRINPE = "LRINPE";

        /// <summary>
        /// LRJBCD.
        /// </summary>
        public const string LRJBCD = "LRJBCD";

        /// <summary>
        /// LRDFAN8.
        /// </summary>
        public const string LRDFAN8 = "LRDFAN8";

        /// <summary>
        /// LRDFVEND.
        /// </summary>
        public const string LRDFVEND = "LRDFVEND";

        /// <summary>
        /// LRDFPOY.
        /// </summary>
        public const string LRDFPOY = "LRDFPOY";

        /// <summary>
        /// LRCOST.
        /// </summary>
        public const string LRCOST = "LRCOST";

        /// <summary>
        /// LRDFOMCU.
        /// </summary>
        public const string LRDFOMCU = "LRDFOMCU";

        /// <summary>
        /// LROBJ.
        /// </summary>
        public const string LROBJ = "LROBJ";

        /// <summary>
        /// LRSUB.
        /// </summary>
        public const string LRSUB = "LRSUB";

        /// <summary>
        /// LRRREV.
        /// </summary>
        public const string LRRREV = "LRRREV";

        /// <summary>
        /// LRURCD.
        /// </summary>
        public const string LRURCD = "LRURCD";

        /// <summary>
        /// LRURDT.
        /// </summary>
        public const string LRURDT = "LRURDT";

        /// <summary>
        /// LRURAT.
        /// </summary>
        public const string LRURAT = "LRURAT";

        /// <summary>
        /// LRURRF.
        /// </summary>
        public const string LRURRF = "LRURRF";

        /// <summary>
        /// LRURAB.
        /// </summary>
        public const string LRURAB = "LRURAB";

        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LRPID.
        /// </summary>
        public const string LRPID = "LRPID";

        /// <summary>
        /// LRUTIME.
        /// </summary>
        public const string LRUTIME = "LRUTIME";

        /// <summary>
        /// LRJOBN.
        /// </summary>
        public const string LRJOBN = "LRJOBN";

        /// <summary>
        /// LRDFWMCU.
        /// </summary>
        public const string LRDFWMCU = "LRDFWMCU";

        /// <summary>
        /// LRLOCN.
        /// </summary>
        public const string LRLOCN = "LRLOCN";

        /// <summary>
        /// LRRUC.
        /// </summary>
        public const string LRRUC = "LRRUC";

        /// <summary>
        /// LRCAPU.
        /// </summary>
        public const string LRCAPU = "LRCAPU";

        /// <summary>
        /// LRACTB.
        /// </summary>
        public const string LRACTB = "LRACTB";

        /// <summary>
        /// LRDFNUMB.
        /// </summary>
        public const string LRDFNUMB = "LRDFNUMB";

        /// <summary>
        /// LRCBCO.
        /// </summary>
        public const string LRCBCO = "LRCBCO";

        /// <summary>
        /// LRCICO.
        /// </summary>
        public const string LRCICO = "LRCICO";

        /// <summary>
        /// LRIMCO.
        /// </summary>
        public const string LRIMCO = "LRIMCO";

        /// <summary>
        /// LRMPRO.
        /// </summary>
        public const string LRMPRO = "LRMPRO";

        /// <summary>
        /// LRAPSC.
        /// </summary>
        public const string LRAPSC = "LRAPSC";

        /// <summary>
        /// LRMNSP.
        /// </summary>
        public const string LRMNSP = "LRMNSP";

        /// <summary>
        /// LRMXSP.
        /// </summary>
        public const string LRMXSP = "LRMXSP";

        /// <summary>
        /// LRCMPE.
        /// </summary>
        public const string LRCMPE = "LRCMPE";

        /// <summary>
        /// LRCMPC.
        /// </summary>
        public const string LRCMPC = "LRCMPC";

        /// <summary>
        /// LRCPLVLFR.
        /// </summary>
        public const string LRCPLVLFR = "LRCPLVLFR";

        /// <summary>
        /// LRCPLVLTO.
        /// </summary>
        public const string LRCPLVLTO = "LRCPLVLTO";

        /// <summary>
        /// LRCMRQ.
        /// </summary>
        public const string LRCMRQ = "LRCMRQ";

        /// <summary>
        /// LRDFOPC.
        /// </summary>
        public const string LRDFOPC = "LRDFOPC";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L930";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRFSCID", "LRFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("LRTRT", "LRTRT", JdeDataType.String, 6, true, true),
        new JdeField("LRDFKIT", "LRDFKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("LRDFMMCU", "LRDFMMCU", JdeDataType.String, 24, true, true),
        new JdeField("LRALD", "LRALD", JdeDataType.String, 8),
        new JdeField("LRDSC1", "LRDSC1", JdeDataType.String, 60),
        new JdeField("LRDFLINE", "LRDFLINE", JdeDataType.String, 24, true, true),
        new JdeField("LRDFMCU", "LRDFMCU", JdeDataType.String, 24),
        new JdeField("LROPSQ", "LROPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LREFFF", "LREFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("LREFFT", "LREFFT", JdeDataType.Numeric),
        new JdeField("LRBFPF", "LRBFPF", JdeDataType.String, 2),
        new JdeField("LRLAMC", "LRLAMC", JdeDataType.String, 2),
        new JdeField("LRTIMB", "LRTIMB", JdeDataType.String, 2),
        new JdeField("LROPSR", "LROPSR", JdeDataType.Numeric),
        new JdeField("LRBQTY", "LRBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("LRUOM", "LRUOM", JdeDataType.String, 4),
        new JdeField("LRPMMST", "LRPMMST", JdeDataType.Numeric),
        new JdeField("LRPMMRT", "LRPMMRT", JdeDataType.Numeric),
        new JdeField("LRPMMMT", "LRPMMMT", JdeDataType.Numeric),
        new JdeField("LRPMLST", "LRPMLST", JdeDataType.Numeric),
        new JdeField("LRPMLRT", "LRPMLRT", JdeDataType.Numeric),
        new JdeField("LRPMLMT", "LRPMLMT", JdeDataType.Numeric),
        new JdeField("LRPWRT", "LRPWRT", JdeDataType.Numeric),
        new JdeField("LRSETC", "LRSETC", JdeDataType.Numeric),
        new JdeField("LRDFQUED", "LRDFQUED", JdeDataType.Numeric),
        new JdeField("LRLTPC", "LRLTPC", JdeDataType.Numeric),
        new JdeField("LRPOVR", "LRPOVR", JdeDataType.Numeric),
        new JdeField("LRNXOP", "LRNXOP", JdeDataType.Numeric),
        new JdeField("LRDFOPYP", "LRDFOPYP", JdeDataType.Numeric),
        new JdeField("LRCPYP", "LRCPYP", JdeDataType.Numeric),
        new JdeField("LRAPID", "LRAPID", JdeDataType.String, 24),
        new JdeField("LRSHNO", "LRSHNO", JdeDataType.String, 20),
        new JdeField("LROPSC", "LROPSC", JdeDataType.String, 4, true, true),
        new JdeField("LRINPE", "LRINPE", JdeDataType.String, 4),
        new JdeField("LRJBCD", "LRJBCD", JdeDataType.String, 12),
        new JdeField("LRDFAN8", "LRDFAN8", JdeDataType.Numeric),
        new JdeField("LRDFVEND", "LRDFVEND", JdeDataType.Numeric),
        new JdeField("LRDFPOY", "LRDFPOY", JdeDataType.String, 2),
        new JdeField("LRCOST", "LRCOST", JdeDataType.String, 6),
        new JdeField("LRDFOMCU", "LRDFOMCU", JdeDataType.String, 24),
        new JdeField("LROBJ", "LROBJ", JdeDataType.String, 12),
        new JdeField("LRSUB", "LRSUB", JdeDataType.String, 16),
        new JdeField("LRRREV", "LRRREV", JdeDataType.String, 6),
        new JdeField("LRURCD", "LRURCD", JdeDataType.String, 4),
        new JdeField("LRURDT", "LRURDT", JdeDataType.Numeric),
        new JdeField("LRURAT", "LRURAT", JdeDataType.Numeric),
        new JdeField("LRURRF", "LRURRF", JdeDataType.String, 30),
        new JdeField("LRURAB", "LRURAB", JdeDataType.Numeric),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRUTIME", "LRUTIME", JdeDataType.Date),
        new JdeField("LRJOBN", "LRJOBN", JdeDataType.String, 20),
        new JdeField("LRDFWMCU", "LRDFWMCU", JdeDataType.String, 24),
        new JdeField("LRLOCN", "LRLOCN", JdeDataType.String, 40),
        new JdeField("LRRUC", "LRRUC", JdeDataType.Numeric),
        new JdeField("LRCAPU", "LRCAPU", JdeDataType.String, 4),
        new JdeField("LRACTB", "LRACTB", JdeDataType.String, 20),
        new JdeField("LRDFNUMB", "LRDFNUMB", JdeDataType.Numeric),
        new JdeField("LRCBCO", "LRCBCO", JdeDataType.Numeric),
        new JdeField("LRCICO", "LRCICO", JdeDataType.Numeric),
        new JdeField("LRIMCO", "LRIMCO", JdeDataType.Numeric),
        new JdeField("LRMPRO", "LRMPRO", JdeDataType.Numeric),
        new JdeField("LRAPSC", "LRAPSC", JdeDataType.String, 2),
        new JdeField("LRMNSP", "LRMNSP", JdeDataType.Numeric),
        new JdeField("LRMXSP", "LRMXSP", JdeDataType.Numeric),
        new JdeField("LRCMPE", "LRCMPE", JdeDataType.String, 6),
        new JdeField("LRCMPC", "LRCMPC", JdeDataType.String, 20),
        new JdeField("LRCPLVLFR", "LRCPLVLFR", JdeDataType.Numeric),
        new JdeField("LRCPLVLTO", "LRCPLVLTO", JdeDataType.Numeric),
        new JdeField("LRCMRQ", "LRCMRQ", JdeDataType.String, 2),
        new JdeField("LRDFOPC", "LRDFOPC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L930_0", "Primary Key on LRFSCID, LRDFMMCU, LRDFKIT, LRTRT, LRBQTY, LROPSQ, LROPSC, LRDFLINE, LREFFF", new[] { "LRFSCID", "LRDFMMCU", "LRDFKIT", "LRTRT", "LRBQTY", "LROPSQ", "LROPSC", "LRDFLINE", "LREFFF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L930_2", "Index on LRFSCID, LRDFMMCU, LRDFKIT", new[] { "LRFSCID", "LRDFMMCU", "LRDFKIT" })
    };
}
