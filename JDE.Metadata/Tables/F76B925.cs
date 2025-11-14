using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B925 - .
/// </summary>
public class F76B925 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAAID.
        /// </summary>
        public const string BAAID = "BAAID";

        /// <summary>
        /// BAB76AGTC.
        /// </summary>
        public const string BAB76AGTC = "BAB76AGTC";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAUPMJ.
        /// </summary>
        public const string BAUPMJ = "BAUPMJ";

        /// <summary>
        /// BAUPMT.
        /// </summary>
        public const string BAUPMT = "BAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B925";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAAID", "BAAID", JdeDataType.String, 16, true, true),
        new JdeField("BAB76AGTC", "BAB76AGTC", JdeDataType.String, 2),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAUPMT", "BAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B925_0", "Primary Key on BAAID", new[] { "BAAID" }, isUnique: true, isPrimaryKey: true)
    };
}
