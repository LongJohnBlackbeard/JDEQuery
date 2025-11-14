using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C9F11 - .
/// </summary>
public class F76C9F11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DFC76FMT.
        /// </summary>
        public const string DFC76FMT = "DFC76FMT";

        /// <summary>
        /// DFAID.
        /// </summary>
        public const string DFAID = "DFAID";

        /// <summary>
        /// DFCTRY.
        /// </summary>
        public const string DFCTRY = "DFCTRY";

        /// <summary>
        /// DFFY.
        /// </summary>
        public const string DFFY = "DFFY";

        /// <summary>
        /// DFLT.
        /// </summary>
        public const string DFLT = "DFLT";

        /// <summary>
        /// DFSBL.
        /// </summary>
        public const string DFSBL = "DFSBL";

        /// <summary>
        /// DFSBLT.
        /// </summary>
        public const string DFSBLT = "DFSBLT";

        /// <summary>
        /// DFCSUM.
        /// </summary>
        public const string DFCSUM = "DFCSUM";

        /// <summary>
        /// DFC76CEPT.
        /// </summary>
        public const string DFC76CEPT = "DFC76CEPT";

        /// <summary>
        /// DFC76STS.
        /// </summary>
        public const string DFC76STS = "DFC76STS";

        /// <summary>
        /// DFAN8.
        /// </summary>
        public const string DFAN8 = "DFAN8";

        /// <summary>
        /// DF76CTAX.
        /// </summary>
        public const string DF76CTAX = "DF76CTAX";

        /// <summary>
        /// DFC76DDCT.
        /// </summary>
        public const string DFC76DDCT = "DFC76DDCT";

        /// <summary>
        /// DFC76TAXA.
        /// </summary>
        public const string DFC76TAXA = "DFC76TAXA";

        /// <summary>
        /// DFAG.
        /// </summary>
        public const string DFAG = "DFAG";

        /// <summary>
        /// DFSEQ.
        /// </summary>
        public const string DFSEQ = "DFSEQ";

        /// <summary>
        /// DFPID.
        /// </summary>
        public const string DFPID = "DFPID";

        /// <summary>
        /// DFVERS.
        /// </summary>
        public const string DFVERS = "DFVERS";

        /// <summary>
        /// DFJOBN.
        /// </summary>
        public const string DFJOBN = "DFJOBN";

        /// <summary>
        /// DFUPMT.
        /// </summary>
        public const string DFUPMT = "DFUPMT";

        /// <summary>
        /// DFUPMJ.
        /// </summary>
        public const string DFUPMJ = "DFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76C9F11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DFC76FMT", "DFC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("DFAID", "DFAID", JdeDataType.String, 16, true, true),
        new JdeField("DFCTRY", "DFCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("DFFY", "DFFY", JdeDataType.Numeric, null, true, true),
        new JdeField("DFLT", "DFLT", JdeDataType.String, 4, true, true),
        new JdeField("DFSBL", "DFSBL", JdeDataType.String, 16, true, true),
        new JdeField("DFSBLT", "DFSBLT", JdeDataType.String, 2, true, true),
        new JdeField("DFCSUM", "DFCSUM", JdeDataType.String, 2),
        new JdeField("DFC76CEPT", "DFC76CEPT", JdeDataType.String, 8),
        new JdeField("DFC76STS", "DFC76STS", JdeDataType.String, 2),
        new JdeField("DFAN8", "DFAN8", JdeDataType.Numeric),
        new JdeField("DF76CTAX", "DF76CTAX", JdeDataType.String, 40),
        new JdeField("DFC76DDCT", "DFC76DDCT", JdeDataType.Numeric),
        new JdeField("DFC76TAXA", "DFC76TAXA", JdeDataType.String, 40),
        new JdeField("DFAG", "DFAG", JdeDataType.Numeric),
        new JdeField("DFSEQ", "DFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DFPID", "DFPID", JdeDataType.String, 20),
        new JdeField("DFVERS", "DFVERS", JdeDataType.String, 20),
        new JdeField("DFJOBN", "DFJOBN", JdeDataType.String, 20),
        new JdeField("DFUPMT", "DFUPMT", JdeDataType.Numeric),
        new JdeField("DFUPMJ", "DFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C9F11_0", "Primary Key on DFC76FMT, DFAID, DFCTRY, DFFY, DFLT, DFSBL, DFSBLT, DFSEQ", new[] { "DFC76FMT", "DFAID", "DFCTRY", "DFFY", "DFLT", "DFSBL", "DFSBLT", "DFSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C9F11_2", "Index on DFSEQ", new[] { "DFSEQ" }),
        new JdeIndex("F76C9F11_3", "Index on DFC76FMT, DFC76CEPT, DF76CTAX", new[] { "DFC76FMT", "DFC76CEPT", "DF76CTAX" })
    };
}
