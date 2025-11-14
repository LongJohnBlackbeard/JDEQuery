using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087715 - .
/// </summary>
public class F087715 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XMAN8.
        /// </summary>
        public const string XMAN8 = "XMAN8";

        /// <summary>
        /// XMDENT0.
        /// </summary>
        public const string XMDENT0 = "XMDENT0";

        /// <summary>
        /// XMTENT.
        /// </summary>
        public const string XMTENT = "XMTENT";

        /// <summary>
        /// XMSUBJ.
        /// </summary>
        public const string XMSUBJ = "XMSUBJ";

        /// <summary>
        /// XMSUBJT.
        /// </summary>
        public const string XMSUBJT = "XMSUBJT";

        /// <summary>
        /// XMRELN.
        /// </summary>
        public const string XMRELN = "XMRELN";

        /// <summary>
        /// XMJCC.
        /// </summary>
        public const string XMJCC = "XMJCC";

        /// <summary>
        /// XMJCDS.
        /// </summary>
        public const string XMJCDS = "XMJCDS";

        /// <summary>
        /// XMATPA.
        /// </summary>
        public const string XMATPA = "XMATPA";

        /// <summary>
        /// XMSERK.
        /// </summary>
        public const string XMSERK = "XMSERK";

        /// <summary>
        /// XMGAPS.
        /// </summary>
        public const string XMGAPS = "XMGAPS";

        /// <summary>
        /// XMUSA1.
        /// </summary>
        public const string XMUSA1 = "XMUSA1";

        /// <summary>
        /// XMAPRR.
        /// </summary>
        public const string XMAPRR = "XMAPRR";

        /// <summary>
        /// XMUSER.
        /// </summary>
        public const string XMUSER = "XMUSER";

        /// <summary>
        /// XMPID.
        /// </summary>
        public const string XMPID = "XMPID";

        /// <summary>
        /// XMJOBN.
        /// </summary>
        public const string XMJOBN = "XMJOBN";

        /// <summary>
        /// XMUPMJ.
        /// </summary>
        public const string XMUPMJ = "XMUPMJ";

        /// <summary>
        /// XMUPMT.
        /// </summary>
        public const string XMUPMT = "XMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F087715";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XMAN8", "XMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XMDENT0", "XMDENT0", JdeDataType.Numeric, null, true, true),
        new JdeField("XMTENT", "XMTENT", JdeDataType.Numeric, null, true, true),
        new JdeField("XMSUBJ", "XMSUBJ", JdeDataType.String, 60),
        new JdeField("XMSUBJT", "XMSUBJT", JdeDataType.String, 16),
        new JdeField("XMRELN", "XMRELN", JdeDataType.String, 20),
        new JdeField("XMJCC", "XMJCC", JdeDataType.String, 20),
        new JdeField("XMJCDS", "XMJCDS", JdeDataType.String, 60),
        new JdeField("XMATPA", "XMATPA", JdeDataType.String, 2),
        new JdeField("XMSERK", "XMSERK", JdeDataType.Numeric),
        new JdeField("XMGAPS", "XMGAPS", JdeDataType.String, 6),
        new JdeField("XMUSA1", "XMUSA1", JdeDataType.Numeric),
        new JdeField("XMAPRR", "XMAPRR", JdeDataType.String, 10),
        new JdeField("XMUSER", "XMUSER", JdeDataType.String, 20, true, true),
        new JdeField("XMPID", "XMPID", JdeDataType.String, 20),
        new JdeField("XMJOBN", "XMJOBN", JdeDataType.String, 20),
        new JdeField("XMUPMJ", "XMUPMJ", JdeDataType.Numeric),
        new JdeField("XMUPMT", "XMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087715_0", "Primary Key on XMUSER, XMAN8, XMDENT0, XMTENT", new[] { "XMUSER", "XMAN8", "XMDENT0", "XMTENT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F087715_4", "Index on XMSERK", new[] { "XMSERK" }),
        new JdeIndex("F087715_5", "Index on XMUSA1, XMAN8, XMDENT0, XMTENT", new[] { "XMUSA1", "XMAN8", "XMDENT0", "XMTENT" })
    };
}
