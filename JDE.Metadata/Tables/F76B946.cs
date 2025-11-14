using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B946 - .
/// </summary>
public class F76B946 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBJOBS.
        /// </summary>
        public const string RBJOBS = "RBJOBS";

        /// <summary>
        /// RBB76ABON.
        /// </summary>
        public const string RBB76ABON = "RBB76ABON";

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
        /// RBUPMT.
        /// </summary>
        public const string RBUPMT = "RBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B946";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBJOBS", "RBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RBB76ABON", "RBB76ABON", JdeDataType.Numeric, null, true, true),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20),
        new JdeField("RBPID", "RBPID", JdeDataType.String, 20),
        new JdeField("RBJOBN", "RBJOBN", JdeDataType.String, 20),
        new JdeField("RBUPMJ", "RBUPMJ", JdeDataType.Numeric),
        new JdeField("RBUPMT", "RBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B946_0", "Primary Key on RBJOBS, RBB76ABON", new[] { "RBJOBS", "RBB76ABON" }, isUnique: true, isPrimaryKey: true)
    };
}
