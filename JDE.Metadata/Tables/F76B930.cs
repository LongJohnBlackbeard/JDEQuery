using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B930 - .
/// </summary>
public class F76B930 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRB76RECD.
        /// </summary>
        public const string RRB76RECD = "RRB76RECD";

        /// <summary>
        /// RRB76BOTY.
        /// </summary>
        public const string RRB76BOTY = "RRB76BOTY";

        /// <summary>
        /// RRB76SROV.
        /// </summary>
        public const string RRB76SROV = "RRB76SROV";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRJOBN.
        /// </summary>
        public const string RRJOBN = "RRJOBN";

        /// <summary>
        /// RRUPMJ.
        /// </summary>
        public const string RRUPMJ = "RRUPMJ";

        /// <summary>
        /// RRUPMT.
        /// </summary>
        public const string RRUPMT = "RRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B930";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRB76RECD", "RRB76RECD", JdeDataType.String, 8, true, true),
        new JdeField("RRB76BOTY", "RRB76BOTY", JdeDataType.String, 2, true, true),
        new JdeField("RRB76SROV", "RRB76SROV", JdeDataType.String, 2),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRJOBN", "RRJOBN", JdeDataType.String, 20),
        new JdeField("RRUPMJ", "RRUPMJ", JdeDataType.Numeric),
        new JdeField("RRUPMT", "RRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B930_0", "Primary Key on RRB76RECD, RRB76BOTY", new[] { "RRB76RECD", "RRB76BOTY" }, isUnique: true, isPrimaryKey: true)
    };
}
