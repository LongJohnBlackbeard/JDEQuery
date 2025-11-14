using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0524 - .
/// </summary>
public class F76B0524 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABJOBS.
        /// </summary>
        public const string ABJOBS = "ABJOBS";

        /// <summary>
        /// ABB76BLCK.
        /// </summary>
        public const string ABB76BLCK = "ABB76BLCK";

        /// <summary>
        /// ABB76SBPR.
        /// </summary>
        public const string ABB76SBPR = "ABB76SBPR";

        /// <summary>
        /// ABB76RECD.
        /// </summary>
        public const string ABB76RECD = "ABB76RECD";

        /// <summary>
        /// ABB76BSEQ.
        /// </summary>
        public const string ABB76BSEQ = "ABB76BSEQ";

        /// <summary>
        /// ABUSEQ.
        /// </summary>
        public const string ABUSEQ = "ABUSEQ";

        /// <summary>
        /// ABUOM1.
        /// </summary>
        public const string ABUOM1 = "ABUOM1";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0524";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABJOBS", "ABJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ABB76BLCK", "ABB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("ABB76SBPR", "ABB76SBPR", JdeDataType.Numeric, null, true, true),
        new JdeField("ABB76RECD", "ABB76RECD", JdeDataType.String, 8, true, true),
        new JdeField("ABB76BSEQ", "ABB76BSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ABUSEQ", "ABUSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ABUOM1", "ABUOM1", JdeDataType.String, 4),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0524_0", "Primary Key on ABJOBS, ABB76BLCK, ABB76SBPR, ABB76RECD, ABB76BSEQ, ABUSEQ", new[] { "ABJOBS", "ABB76BLCK", "ABB76SBPR", "ABB76RECD", "ABB76BSEQ", "ABUSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0524_2", "Index on ABUOM1, ABJOBS", new[] { "ABUOM1", "ABJOBS" })
    };
}
