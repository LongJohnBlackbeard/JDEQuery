using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B411A - .
/// </summary>
public class F76B411A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMKCO.
        /// </summary>
        public const string WMKCO = "WMKCO";

        /// <summary>
        /// WMDCT.
        /// </summary>
        public const string WMDCT = "WMDCT";

        /// <summary>
        /// WMDOC.
        /// </summary>
        public const string WMDOC = "WMDOC";

        /// <summary>
        /// WMOSFX.
        /// </summary>
        public const string WMOSFX = "WMOSFX";

        /// <summary>
        /// WMBRTXTP.
        /// </summary>
        public const string WMBRTXTP = "WMBRTXTP";

        /// <summary>
        /// WMBRTXTT.
        /// </summary>
        public const string WMBRTXTT = "WMBRTXTT";

        /// <summary>
        /// WMAA.
        /// </summary>
        public const string WMAA = "WMAA";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";

        /// <summary>
        /// WMUPMT.
        /// </summary>
        public const string WMUPMT = "WMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B411A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMKCO", "WMKCO", JdeDataType.String, 10, true, true),
        new JdeField("WMDCT", "WMDCT", JdeDataType.String, 4, true, true),
        new JdeField("WMDOC", "WMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WMOSFX", "WMOSFX", JdeDataType.String, 6, true, true),
        new JdeField("WMBRTXTP", "WMBRTXTP", JdeDataType.String, 4, true, true),
        new JdeField("WMBRTXTT", "WMBRTXTT", JdeDataType.Numeric),
        new JdeField("WMAA", "WMAA", JdeDataType.Numeric),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric),
        new JdeField("WMUPMT", "WMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B411A_0", "Primary Key on WMKCO, WMDCT, WMDOC, WMOSFX, WMBRTXTP", new[] { "WMKCO", "WMDCT", "WMDOC", "WMOSFX", "WMBRTXTP" }, isUnique: true, isPrimaryKey: true)
    };
}
