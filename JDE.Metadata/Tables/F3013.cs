using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3013 - .
/// </summary>
public class F3013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CYDOCO.
        /// </summary>
        public const string CYDOCO = "CYDOCO";

        /// <summary>
        /// CYDCTO.
        /// </summary>
        public const string CYDCTO = "CYDCTO";

        /// <summary>
        /// CYPSQ.
        /// </summary>
        public const string CYPSQ = "CYPSQ";

        /// <summary>
        /// CYRSQ.
        /// </summary>
        public const string CYRSQ = "CYRSQ";

        /// <summary>
        /// CYKIT.
        /// </summary>
        public const string CYKIT = "CYKIT";

        /// <summary>
        /// CYMMCU.
        /// </summary>
        public const string CYMMCU = "CYMMCU";

        /// <summary>
        /// CYECPR.
        /// </summary>
        public const string CYECPR = "CYECPR";

        /// <summary>
        /// CYTIC.
        /// </summary>
        public const string CYTIC = "CYTIC";

        /// <summary>
        /// CYITM.
        /// </summary>
        public const string CYITM = "CYITM";

        /// <summary>
        /// CYCMCU.
        /// </summary>
        public const string CYCMCU = "CYCMCU";

        /// <summary>
        /// CYTBM.
        /// </summary>
        public const string CYTBM = "CYTBM";

        /// <summary>
        /// CYBQTY.
        /// </summary>
        public const string CYBQTY = "CYBQTY";

        /// <summary>
        /// CYUOM.
        /// </summary>
        public const string CYUOM = "CYUOM";

        /// <summary>
        /// CYCPNT.
        /// </summary>
        public const string CYCPNT = "CYCPNT";

        /// <summary>
        /// CYOPSQ.
        /// </summary>
        public const string CYOPSQ = "CYOPSQ";

        /// <summary>
        /// CYQNTY.
        /// </summary>
        public const string CYQNTY = "CYQNTY";

        /// <summary>
        /// CYFORQ.
        /// </summary>
        public const string CYFORQ = "CYFORQ";

        /// <summary>
        /// CYUM.
        /// </summary>
        public const string CYUM = "CYUM";

        /// <summary>
        /// CYFRV.
        /// </summary>
        public const string CYFRV = "CYFRV";

        /// <summary>
        /// CYTRV.
        /// </summary>
        public const string CYTRV = "CYTRV";

        /// <summary>
        /// CYSRV.
        /// </summary>
        public const string CYSRV = "CYSRV";

        /// <summary>
        /// CYRVNO.
        /// </summary>
        public const string CYRVNO = "CYRVNO";

        /// <summary>
        /// CYEFFF.
        /// </summary>
        public const string CYEFFF = "CYEFFF";

        /// <summary>
        /// CYEFFT.
        /// </summary>
        public const string CYEFFT = "CYEFFT";

        /// <summary>
        /// CYFSER.
        /// </summary>
        public const string CYFSER = "CYFSER";

        /// <summary>
        /// CYTSER.
        /// </summary>
        public const string CYTSER = "CYTSER";

        /// <summary>
        /// CYUSER.
        /// </summary>
        public const string CYUSER = "CYUSER";

        /// <summary>
        /// CYPID.
        /// </summary>
        public const string CYPID = "CYPID";

        /// <summary>
        /// CYUPMJ.
        /// </summary>
        public const string CYUPMJ = "CYUPMJ";

        /// <summary>
        /// CYTDAY.
        /// </summary>
        public const string CYTDAY = "CYTDAY";

        /// <summary>
        /// CYJOBN.
        /// </summary>
        public const string CYJOBN = "CYJOBN";

        /// <summary>
        /// CYITC.
        /// </summary>
        public const string CYITC = "CYITC";

        /// <summary>
        /// CYLOVD.
        /// </summary>
        public const string CYLOVD = "CYLOVD";

        /// <summary>
        /// CYPRIC.
        /// </summary>
        public const string CYPRIC = "CYPRIC";

        /// <summary>
        /// CYUNCS.
        /// </summary>
        public const string CYUNCS = "CYUNCS";

        /// <summary>
        /// CYFRGD.
        /// </summary>
        public const string CYFRGD = "CYFRGD";

        /// <summary>
        /// CYTHGD.
        /// </summary>
        public const string CYTHGD = "CYTHGD";

        /// <summary>
        /// CYFRMP.
        /// </summary>
        public const string CYFRMP = "CYFRMP";

        /// <summary>
        /// CYTHRP.
        /// </summary>
        public const string CYTHRP = "CYTHRP";

        /// <summary>
        /// CYOPTK.
        /// </summary>
        public const string CYOPTK = "CYOPTK";

        /// <summary>
        /// CYSCRP.
        /// </summary>
        public const string CYSCRP = "CYSCRP";

        /// <summary>
        /// CYFTRC.
        /// </summary>
        public const string CYFTRC = "CYFTRC";

        /// <summary>
        /// CYFORV.
        /// </summary>
        public const string CYFORV = "CYFORV";

        /// <summary>
        /// CYBSEQ.
        /// </summary>
        public const string CYBSEQ = "CYBSEQ";

        /// <summary>
        /// CYPRTA.
        /// </summary>
        public const string CYPRTA = "CYPRTA";

        /// <summary>
        /// CYLNTY.
        /// </summary>
        public const string CYLNTY = "CYLNTY";

        /// <summary>
        /// CYDSC1.
        /// </summary>
        public const string CYDSC1 = "CYDSC1";

        /// <summary>
        /// CYFTRP.
        /// </summary>
        public const string CYFTRP = "CYFTRP";

        /// <summary>
        /// CYF$RP.
        /// </summary>
        public const string CYF_RP = "CYF$RP";

        /// <summary>
        /// CYSBNT.
        /// </summary>
        public const string CYSBNT = "CYSBNT";

        /// <summary>
        /// CYSTRC.
        /// </summary>
        public const string CYSTRC = "CYSTRC";

        /// <summary>
        /// CYENDC.
        /// </summary>
        public const string CYENDC = "CYENDC";

        /// <summary>
        /// CYAPSC.
        /// </summary>
        public const string CYAPSC = "CYAPSC";

        /// <summary>
        /// CYCPNB.
        /// </summary>
        public const string CYCPNB = "CYCPNB";

        /// <summary>
        /// CYBSEQAN.
        /// </summary>
        public const string CYBSEQAN = "CYBSEQAN";
    }

    /// <inheritdoc />
    public override string TableName => "F3013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CYDOCO", "CYDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CYDCTO", "CYDCTO", JdeDataType.String, 4),
        new JdeField("CYPSQ", "CYPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CYRSQ", "CYRSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CYKIT", "CYKIT", JdeDataType.Numeric),
        new JdeField("CYMMCU", "CYMMCU", JdeDataType.String, 24),
        new JdeField("CYECPR", "CYECPR", JdeDataType.String, 2),
        new JdeField("CYTIC", "CYTIC", JdeDataType.String, 2),
        new JdeField("CYITM", "CYITM", JdeDataType.Numeric),
        new JdeField("CYCMCU", "CYCMCU", JdeDataType.String, 24),
        new JdeField("CYTBM", "CYTBM", JdeDataType.String, 6),
        new JdeField("CYBQTY", "CYBQTY", JdeDataType.Numeric),
        new JdeField("CYUOM", "CYUOM", JdeDataType.String, 4),
        new JdeField("CYCPNT", "CYCPNT", JdeDataType.Numeric),
        new JdeField("CYOPSQ", "CYOPSQ", JdeDataType.Numeric),
        new JdeField("CYQNTY", "CYQNTY", JdeDataType.Numeric),
        new JdeField("CYFORQ", "CYFORQ", JdeDataType.String, 2),
        new JdeField("CYUM", "CYUM", JdeDataType.String, 4),
        new JdeField("CYFRV", "CYFRV", JdeDataType.String, 6),
        new JdeField("CYTRV", "CYTRV", JdeDataType.String, 6),
        new JdeField("CYSRV", "CYSRV", JdeDataType.String, 6),
        new JdeField("CYRVNO", "CYRVNO", JdeDataType.String, 4),
        new JdeField("CYEFFF", "CYEFFF", JdeDataType.Numeric),
        new JdeField("CYEFFT", "CYEFFT", JdeDataType.Numeric),
        new JdeField("CYFSER", "CYFSER", JdeDataType.String, 50),
        new JdeField("CYTSER", "CYTSER", JdeDataType.String, 50),
        new JdeField("CYUSER", "CYUSER", JdeDataType.String, 20),
        new JdeField("CYPID", "CYPID", JdeDataType.String, 20),
        new JdeField("CYUPMJ", "CYUPMJ", JdeDataType.Numeric),
        new JdeField("CYTDAY", "CYTDAY", JdeDataType.Numeric),
        new JdeField("CYJOBN", "CYJOBN", JdeDataType.String, 20),
        new JdeField("CYITC", "CYITC", JdeDataType.String, 2),
        new JdeField("CYLOVD", "CYLOVD", JdeDataType.Numeric),
        new JdeField("CYPRIC", "CYPRIC", JdeDataType.Numeric),
        new JdeField("CYUNCS", "CYUNCS", JdeDataType.Numeric),
        new JdeField("CYFRGD", "CYFRGD", JdeDataType.String, 6),
        new JdeField("CYTHGD", "CYTHGD", JdeDataType.String, 6),
        new JdeField("CYFRMP", "CYFRMP", JdeDataType.Numeric),
        new JdeField("CYTHRP", "CYTHRP", JdeDataType.Numeric),
        new JdeField("CYOPTK", "CYOPTK", JdeDataType.String, 2),
        new JdeField("CYSCRP", "CYSCRP", JdeDataType.Numeric),
        new JdeField("CYFTRC", "CYFTRC", JdeDataType.String, 2),
        new JdeField("CYFORV", "CYFORV", JdeDataType.String, 2),
        new JdeField("CYBSEQ", "CYBSEQ", JdeDataType.Numeric),
        new JdeField("CYPRTA", "CYPRTA", JdeDataType.String, 2),
        new JdeField("CYLNTY", "CYLNTY", JdeDataType.String, 4),
        new JdeField("CYDSC1", "CYDSC1", JdeDataType.String, 60),
        new JdeField("CYFTRP", "CYFTRP", JdeDataType.Numeric),
        new JdeField("CYF$RP", "CYF$RP", JdeDataType.Numeric),
        new JdeField("CYSBNT", "CYSBNT", JdeDataType.Numeric),
        new JdeField("CYSTRC", "CYSTRC", JdeDataType.Numeric),
        new JdeField("CYENDC", "CYENDC", JdeDataType.Numeric),
        new JdeField("CYAPSC", "CYAPSC", JdeDataType.String, 2),
        new JdeField("CYCPNB", "CYCPNB", JdeDataType.Numeric),
        new JdeField("CYBSEQAN", "CYBSEQAN", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3013_0", "Primary Key on CYDOCO, CYPSQ, CYRSQ", new[] { "CYDOCO", "CYPSQ", "CYRSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3013_1", "Index on CYECPR, CYKIT, CYMMCU, CYTBM, CYBQTY, CYSRV", new[] { "CYECPR", "CYKIT", "CYMMCU", "CYTBM", "CYBQTY", "CYSRV" }),
        new JdeIndex("F3013_2", "Index on CYECPR, CYITM, CYMMCU, CYTBM, CYBQTY, CYTRV", new[] { "CYECPR", "CYITM", "CYMMCU", "CYTBM", "CYBQTY", "CYTRV" }),
        new JdeIndex("F3013_3", "Index on CYITM, CYDOCO", new[] { "CYITM", "CYDOCO" }),
        new JdeIndex("F3013_5", "Index on CYDOCO, CYDCTO", new[] { "CYDOCO", "CYDCTO" }),
        new JdeIndex("F3013_6", "Index on CYDOCO, SYS_NC00056$", new[] { "CYDOCO", "SYS_NC00056$" }),
        new JdeIndex("F3013_7", "Index on CYECPR, CYKIT, CYMMCU, CYTBM, SYS_NC00057$, SYS_NC00058$", new[] { "CYECPR", "CYKIT", "CYMMCU", "CYTBM", "SYS_NC00057$", "SYS_NC00058$" }),
        new JdeIndex("F3013_8", "Index on CYECPR, CYITM, CYMMCU, CYTBM, SYS_NC00057$, SYS_NC00058$", new[] { "CYECPR", "CYITM", "CYMMCU", "CYTBM", "SYS_NC00057$", "SYS_NC00058$" })
    };
}
