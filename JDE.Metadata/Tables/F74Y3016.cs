using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y3016 - .
/// </summary>
public class F74Y3016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLKCOO.
        /// </summary>
        public const string RLKCOO = "RLKCOO";

        /// <summary>
        /// RLDCTO.
        /// </summary>
        public const string RLDCTO = "RLDCTO";

        /// <summary>
        /// RLDOCO.
        /// </summary>
        public const string RLDOCO = "RLDOCO";

        /// <summary>
        /// RLSFXO.
        /// </summary>
        public const string RLSFXO = "RLSFXO";

        /// <summary>
        /// RLLNID.
        /// </summary>
        public const string RLLNID = "RLLNID";

        /// <summary>
        /// RLI74RELE.
        /// </summary>
        public const string RLI74RELE = "RLI74RELE";

        /// <summary>
        /// RLI74TRSEC.
        /// </summary>
        public const string RLI74TRSEC = "RLI74TRSEC";

        /// <summary>
        /// RLI74REVCH.
        /// </summary>
        public const string RLI74REVCH = "RLI74REVCH";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLUPMT.
        /// </summary>
        public const string RLUPMT = "RLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y3016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLKCOO", "RLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RLDCTO", "RLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RLDOCO", "RLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RLSFXO", "RLSFXO", JdeDataType.String, 6, true, true),
        new JdeField("RLLNID", "RLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RLI74RELE", "RLI74RELE", JdeDataType.String, 4),
        new JdeField("RLI74TRSEC", "RLI74TRSEC", JdeDataType.String, 2),
        new JdeField("RLI74REVCH", "RLI74REVCH", JdeDataType.String, 2),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLUPMT", "RLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y3016_0", "Primary Key on RLKCOO, RLDCTO, RLDOCO, RLSFXO, RLLNID", new[] { "RLKCOO", "RLDCTO", "RLDOCO", "RLSFXO", "RLLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
