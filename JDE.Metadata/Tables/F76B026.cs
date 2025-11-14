using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B026 - .
/// </summary>
public class F76B026 : JdeTable
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
        /// BAB76ATIV.
        /// </summary>
        public const string BAB76ATIV = "BAB76ATIV";

        /// <summary>
        /// BAB76CONI.
        /// </summary>
        public const string BAB76CONI = "BAB76CONI";

        /// <summary>
        /// BAB76JPQ.
        /// </summary>
        public const string BAB76JPQ = "BAB76JPQ";

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

        /// <summary>
        /// BAB76URAB.
        /// </summary>
        public const string BAB76URAB = "BAB76URAB";

        /// <summary>
        /// BAB76URAT.
        /// </summary>
        public const string BAB76URAT = "BAB76URAT";

        /// <summary>
        /// BAB76URCD.
        /// </summary>
        public const string BAB76URCD = "BAB76URCD";

        /// <summary>
        /// BAB76URDT.
        /// </summary>
        public const string BAB76URDT = "BAB76URDT";

        /// <summary>
        /// BAB76URRF.
        /// </summary>
        public const string BAB76URRF = "BAB76URRF";
    }

    /// <inheritdoc />
    public override string TableName => "F76B026";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAAN8", "BAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BAB76ATIV", "BAB76ATIV", JdeDataType.String, 2),
        new JdeField("BAB76CONI", "BAB76CONI", JdeDataType.String, 4),
        new JdeField("BAB76JPQ", "BAB76JPQ", JdeDataType.String, 4),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAUPMT", "BAUPMT", JdeDataType.Numeric),
        new JdeField("BAB76URAB", "BAB76URAB", JdeDataType.Numeric),
        new JdeField("BAB76URAT", "BAB76URAT", JdeDataType.Numeric),
        new JdeField("BAB76URCD", "BAB76URCD", JdeDataType.String, 4),
        new JdeField("BAB76URDT", "BAB76URDT", JdeDataType.Numeric),
        new JdeField("BAB76URRF", "BAB76URRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B026_0", "Primary Key on BAAN8", new[] { "BAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
