using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C4F01 - .
/// </summary>
public class F76C4F01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPC76FMT.
        /// </summary>
        public const string FPC76FMT = "FPC76FMT";

        /// <summary>
        /// FPPYID.
        /// </summary>
        public const string FPPYID = "FPPYID";

        /// <summary>
        /// FPRC5.
        /// </summary>
        public const string FPRC5 = "FPRC5";

        /// <summary>
        /// FPC76CEPT.
        /// </summary>
        public const string FPC76CEPT = "FPC76CEPT";

        /// <summary>
        /// FPC76STS.
        /// </summary>
        public const string FPC76STS = "FPC76STS";

        /// <summary>
        /// FPAN8.
        /// </summary>
        public const string FPAN8 = "FPAN8";

        /// <summary>
        /// FP76CTAX.
        /// </summary>
        public const string FP76CTAX = "FP76CTAX";

        /// <summary>
        /// FPC76TAXA.
        /// </summary>
        public const string FPC76TAXA = "FPC76TAXA";

        /// <summary>
        /// FPC76DDCT.
        /// </summary>
        public const string FPC76DDCT = "FPC76DDCT";

        /// <summary>
        /// FPAA1.
        /// </summary>
        public const string FPAA1 = "FPAA1";

        /// <summary>
        /// FPAA2.
        /// </summary>
        public const string FPAA2 = "FPAA2";

        /// <summary>
        /// FPSEQ.
        /// </summary>
        public const string FPSEQ = "FPSEQ";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPJOBN.
        /// </summary>
        public const string FPJOBN = "FPJOBN";

        /// <summary>
        /// FPUPMT.
        /// </summary>
        public const string FPUPMT = "FPUPMT";

        /// <summary>
        /// FPUPMJ.
        /// </summary>
        public const string FPUPMJ = "FPUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76C4F01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPC76FMT", "FPC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("FPPYID", "FPPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPRC5", "FPRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("FPC76CEPT", "FPC76CEPT", JdeDataType.String, 8),
        new JdeField("FPC76STS", "FPC76STS", JdeDataType.String, 2),
        new JdeField("FPAN8", "FPAN8", JdeDataType.Numeric),
        new JdeField("FP76CTAX", "FP76CTAX", JdeDataType.String, 40),
        new JdeField("FPC76TAXA", "FPC76TAXA", JdeDataType.String, 40),
        new JdeField("FPC76DDCT", "FPC76DDCT", JdeDataType.Numeric),
        new JdeField("FPAA1", "FPAA1", JdeDataType.Numeric),
        new JdeField("FPAA2", "FPAA2", JdeDataType.Numeric),
        new JdeField("FPSEQ", "FPSEQ", JdeDataType.Numeric),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPJOBN", "FPJOBN", JdeDataType.String, 20),
        new JdeField("FPUPMT", "FPUPMT", JdeDataType.Numeric),
        new JdeField("FPUPMJ", "FPUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C4F01_0", "Primary Key on FPC76FMT, FPPYID, FPRC5", new[] { "FPC76FMT", "FPPYID", "FPRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C4F01_2", "Index on FPSEQ", new[] { "FPSEQ" }),
        new JdeIndex("F76C4F01_3", "Index on FPC76FMT, FPC76CEPT, FP76CTAX", new[] { "FPC76FMT", "FPC76CEPT", "FP76CTAX" })
    };
}
