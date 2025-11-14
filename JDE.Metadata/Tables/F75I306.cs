using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I306 - .
/// </summary>
public class F75I306 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EAYEXU.
        /// </summary>
        public const string EAYEXU = "EAYEXU";

        /// <summary>
        /// EAI75TXTY.
        /// </summary>
        public const string EAI75TXTY = "EAI75TXTY";

        /// <summary>
        /// EAI75TYEX.
        /// </summary>
        public const string EAI75TYEX = "EAI75TYEX";

        /// <summary>
        /// EAAID.
        /// </summary>
        public const string EAAID = "EAAID";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I306";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EAYEXU", "EAYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("EAI75TXTY", "EAI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("EAI75TYEX", "EAI75TYEX", JdeDataType.String, 6, true, true),
        new JdeField("EAAID", "EAAID", JdeDataType.String, 16),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I306_0", "Primary Key on EAYEXU, EAI75TXTY, EAI75TYEX", new[] { "EAYEXU", "EAI75TXTY", "EAI75TYEX" }, isUnique: true, isPrimaryKey: true)
    };
}
