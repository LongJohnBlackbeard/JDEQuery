using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B045 - .
/// </summary>
public class F76B045 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCB76LECO.
        /// </summary>
        public const string SCB76LECO = "SCB76LECO";

        /// <summary>
        /// SCB76SCPI.
        /// </summary>
        public const string SCB76SCPI = "SCB76SCPI";

        /// <summary>
        /// SCB76SCPN.
        /// </summary>
        public const string SCB76SCPN = "SCB76SCPN";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B045";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCB76LECO", "SCB76LECO", JdeDataType.String, 10, true, true),
        new JdeField("SCB76SCPI", "SCB76SCPI", JdeDataType.Numeric, null, true, true),
        new JdeField("SCB76SCPN", "SCB76SCPN", JdeDataType.String, 80),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B045_0", "Primary Key on SCB76LECO, SCB76SCPI", new[] { "SCB76LECO", "SCB76SCPI" }, isUnique: true, isPrimaryKey: true)
    };
}
