using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q41 - .
/// </summary>
public class F43Q41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBEVNU.
        /// </summary>
        public const string RBEVNU = "RBEVNU";

        /// <summary>
        /// RBDCTO.
        /// </summary>
        public const string RBDCTO = "RBDCTO";

        /// <summary>
        /// RBKCOO.
        /// </summary>
        public const string RBKCOO = "RBKCOO";

        /// <summary>
        /// RBEVLN.
        /// </summary>
        public const string RBEVLN = "RBEVLN";

        /// <summary>
        /// RBBIDNUM.
        /// </summary>
        public const string RBBIDNUM = "RBBIDNUM";

        /// <summary>
        /// RBAN8.
        /// </summary>
        public const string RBAN8 = "RBAN8";

        /// <summary>
        /// RBRDLN.
        /// </summary>
        public const string RBRDLN = "RBRDLN";

        /// <summary>
        /// RBUORG.
        /// </summary>
        public const string RBUORG = "RBUORG";

        /// <summary>
        /// RBBIDAMT.
        /// </summary>
        public const string RBBIDAMT = "RBBIDAMT";

        /// <summary>
        /// RBFBDAMT.
        /// </summary>
        public const string RBFBDAMT = "RBFBDAMT";

        /// <summary>
        /// RBITM.
        /// </summary>
        public const string RBITM = "RBITM";

        /// <summary>
        /// RBLITM.
        /// </summary>
        public const string RBLITM = "RBLITM";

        /// <summary>
        /// RBAITM.
        /// </summary>
        public const string RBAITM = "RBAITM";

        /// <summary>
        /// RBCMDCDE.
        /// </summary>
        public const string RBCMDCDE = "RBCMDCDE";

        /// <summary>
        /// RBCCUKID.
        /// </summary>
        public const string RBCCUKID = "RBCCUKID";

        /// <summary>
        /// RBDSC1.
        /// </summary>
        public const string RBDSC1 = "RBDSC1";

        /// <summary>
        /// RBPDDJ.
        /// </summary>
        public const string RBPDDJ = "RBPDDJ";

        /// <summary>
        /// RBBROL.
        /// </summary>
        public const string RBBROL = "RBBROL";

        /// <summary>
        /// RBCRCD.
        /// </summary>
        public const string RBCRCD = "RBCRCD";

        /// <summary>
        /// RBLBQS.
        /// </summary>
        public const string RBLBQS = "RBLBQS";

        /// <summary>
        /// RBURCD.
        /// </summary>
        public const string RBURCD = "RBURCD";

        /// <summary>
        /// RBURDT.
        /// </summary>
        public const string RBURDT = "RBURDT";

        /// <summary>
        /// RBURAT.
        /// </summary>
        public const string RBURAT = "RBURAT";

        /// <summary>
        /// RBURAB.
        /// </summary>
        public const string RBURAB = "RBURAB";

        /// <summary>
        /// RBURRF.
        /// </summary>
        public const string RBURRF = "RBURRF";

        /// <summary>
        /// RBTORG.
        /// </summary>
        public const string RBTORG = "RBTORG";

        /// <summary>
        /// RBUSER.
        /// </summary>
        public const string RBUSER = "RBUSER";

        /// <summary>
        /// RBPID.
        /// </summary>
        public const string RBPID = "RBPID";

        /// <summary>
        /// RBJOBN.
        /// </summary>
        public const string RBJOBN = "RBJOBN";

        /// <summary>
        /// RBUPMJ.
        /// </summary>
        public const string RBUPMJ = "RBUPMJ";

        /// <summary>
        /// RBTDAY.
        /// </summary>
        public const string RBTDAY = "RBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBEVNU", "RBEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RBDCTO", "RBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RBKCOO", "RBKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RBEVLN", "RBEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RBBIDNUM", "RBBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RBAN8", "RBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RBRDLN", "RBRDLN", JdeDataType.Numeric),
        new JdeField("RBUORG", "RBUORG", JdeDataType.Numeric),
        new JdeField("RBBIDAMT", "RBBIDAMT", JdeDataType.Numeric),
        new JdeField("RBFBDAMT", "RBFBDAMT", JdeDataType.Numeric),
        new JdeField("RBITM", "RBITM", JdeDataType.Numeric),
        new JdeField("RBLITM", "RBLITM", JdeDataType.String, 50),
        new JdeField("RBAITM", "RBAITM", JdeDataType.String, 50),
        new JdeField("RBCMDCDE", "RBCMDCDE", JdeDataType.String, 30),
        new JdeField("RBCCUKID", "RBCCUKID", JdeDataType.Numeric),
        new JdeField("RBDSC1", "RBDSC1", JdeDataType.String, 60),
        new JdeField("RBPDDJ", "RBPDDJ", JdeDataType.Numeric),
        new JdeField("RBBROL", "RBBROL", JdeDataType.String, 2),
        new JdeField("RBCRCD", "RBCRCD", JdeDataType.String, 6),
        new JdeField("RBLBQS", "RBLBQS", JdeDataType.Numeric),
        new JdeField("RBURCD", "RBURCD", JdeDataType.String, 4),
        new JdeField("RBURDT", "RBURDT", JdeDataType.Numeric),
        new JdeField("RBURAT", "RBURAT", JdeDataType.Numeric),
        new JdeField("RBURAB", "RBURAB", JdeDataType.Numeric),
        new JdeField("RBURRF", "RBURRF", JdeDataType.String, 30),
        new JdeField("RBTORG", "RBTORG", JdeDataType.String, 20),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20),
        new JdeField("RBPID", "RBPID", JdeDataType.String, 20),
        new JdeField("RBJOBN", "RBJOBN", JdeDataType.String, 20),
        new JdeField("RBUPMJ", "RBUPMJ", JdeDataType.Numeric),
        new JdeField("RBTDAY", "RBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q41_0", "Primary Key on RBEVNU, RBDCTO, RBKCOO, RBEVLN, RBBIDNUM, RBAN8", new[] { "RBEVNU", "RBDCTO", "RBKCOO", "RBEVLN", "RBBIDNUM", "RBAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q41_2", "Index on RBEVNU, RBDCTO, RBKCOO, RBBIDNUM, RBAN8", new[] { "RBEVNU", "RBDCTO", "RBKCOO", "RBBIDNUM", "RBAN8" }),
        new JdeIndex("F43Q41_3", "Index on RBEVNU, RBDCTO, RBKCOO, RBAN8", new[] { "RBEVNU", "RBDCTO", "RBKCOO", "RBAN8" })
    };
}
