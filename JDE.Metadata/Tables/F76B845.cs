using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B845 - .
/// </summary>
public class F76B845 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBJOBS.
        /// </summary>
        public const string JBJOBS = "JBJOBS";

        /// <summary>
        /// JBPQTR.
        /// </summary>
        public const string JBPQTR = "JBPQTR";

        /// <summary>
        /// JBB76RECD.
        /// </summary>
        public const string JBB76RECD = "JBB76RECD";

        /// <summary>
        /// JBAID.
        /// </summary>
        public const string JBAID = "JBAID";

        /// <summary>
        /// JBB76FCAO.
        /// </summary>
        public const string JBB76FCAO = "JBB76FCAO";

        /// <summary>
        /// JBCDC1.
        /// </summary>
        public const string JBCDC1 = "JBCDC1";

        /// <summary>
        /// JBB76AGTC.
        /// </summary>
        public const string JBB76AGTC = "JBB76AGTC";

        /// <summary>
        /// JBBLAMT.
        /// </summary>
        public const string JBBLAMT = "JBBLAMT";

        /// <summary>
        /// JBB76FFFB.
        /// </summary>
        public const string JBB76FFFB = "JBB76FFFB";

        /// <summary>
        /// JBB76FFCB.
        /// </summary>
        public const string JBB76FFCB = "JBB76FFCB";

        /// <summary>
        /// JBUSER.
        /// </summary>
        public const string JBUSER = "JBUSER";

        /// <summary>
        /// JBPID.
        /// </summary>
        public const string JBPID = "JBPID";

        /// <summary>
        /// JBJOBN.
        /// </summary>
        public const string JBJOBN = "JBJOBN";

        /// <summary>
        /// JBUPMJ.
        /// </summary>
        public const string JBUPMJ = "JBUPMJ";

        /// <summary>
        /// JBUPMT.
        /// </summary>
        public const string JBUPMT = "JBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B845";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBJOBS", "JBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("JBPQTR", "JBPQTR", JdeDataType.String, 2, true, true),
        new JdeField("JBB76RECD", "JBB76RECD", JdeDataType.String, 8, true, true),
        new JdeField("JBAID", "JBAID", JdeDataType.String, 16, true, true),
        new JdeField("JBB76FCAO", "JBB76FCAO", JdeDataType.String, 20, true, true),
        new JdeField("JBCDC1", "JBCDC1", JdeDataType.String, 2, true, true),
        new JdeField("JBB76AGTC", "JBB76AGTC", JdeDataType.String, 2),
        new JdeField("JBBLAMT", "JBBLAMT", JdeDataType.Numeric),
        new JdeField("JBB76FFFB", "JBB76FFFB", JdeDataType.Numeric),
        new JdeField("JBB76FFCB", "JBB76FFCB", JdeDataType.Numeric),
        new JdeField("JBUSER", "JBUSER", JdeDataType.String, 20),
        new JdeField("JBPID", "JBPID", JdeDataType.String, 20),
        new JdeField("JBJOBN", "JBJOBN", JdeDataType.String, 20),
        new JdeField("JBUPMJ", "JBUPMJ", JdeDataType.Numeric),
        new JdeField("JBUPMT", "JBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B845_0", "Primary Key on JBJOBS, JBPQTR, JBB76RECD, JBAID, JBB76FCAO, JBCDC1", new[] { "JBJOBS", "JBPQTR", "JBB76RECD", "JBAID", "JBB76FCAO", "JBCDC1" }, isUnique: true, isPrimaryKey: true)
    };
}
