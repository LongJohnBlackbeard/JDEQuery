using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B101 - .
/// </summary>
public class F76B101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAAN8.
        /// </summary>
        public const string BAAN8 = "BAAN8";

        /// <summary>
        /// BAB76SVTC.
        /// </summary>
        public const string BAB76SVTC = "BAB76SVTC";

        /// <summary>
        /// BAB76APIS.
        /// </summary>
        public const string BAB76APIS = "BAB76APIS";

        /// <summary>
        /// BAB76CTYC.
        /// </summary>
        public const string BAB76CTYC = "BAB76CTYC";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

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
    public override string TableName => "F76B101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAAN8", "BAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BAB76SVTC", "BAB76SVTC", JdeDataType.String, 20),
        new JdeField("BAB76APIS", "BAB76APIS", JdeDataType.String, 2),
        new JdeField("BAB76CTYC", "BAB76CTYC", JdeDataType.String, 20),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAUPMT", "BAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B101_0", "Primary Key on BAAN8", new[] { "BAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
