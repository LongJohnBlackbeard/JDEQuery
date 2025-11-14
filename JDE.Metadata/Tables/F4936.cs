using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4936 - .
/// </summary>
public class F4936 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWCVID.
        /// </summary>
        public const string CWCVID = "CWCVID";

        /// <summary>
        /// CWEFTJ.
        /// </summary>
        public const string CWEFTJ = "CWEFTJ";

        /// <summary>
        /// CWOSEQ.
        /// </summary>
        public const string CWOSEQ = "CWOSEQ";

        /// <summary>
        /// CWVEHI.
        /// </summary>
        public const string CWVEHI = "CWVEHI";

        /// <summary>
        /// CWDUMV.
        /// </summary>
        public const string CWDUMV = "CWDUMV";

        /// <summary>
        /// CWRLNO.
        /// </summary>
        public const string CWRLNO = "CWRLNO";

        /// <summary>
        /// CWEXDJ.
        /// </summary>
        public const string CWEXDJ = "CWEXDJ";

        /// <summary>
        /// CWURCD.
        /// </summary>
        public const string CWURCD = "CWURCD";

        /// <summary>
        /// CWURDT.
        /// </summary>
        public const string CWURDT = "CWURDT";

        /// <summary>
        /// CWURAT.
        /// </summary>
        public const string CWURAT = "CWURAT";

        /// <summary>
        /// CWURAB.
        /// </summary>
        public const string CWURAB = "CWURAB";

        /// <summary>
        /// CWURRF.
        /// </summary>
        public const string CWURRF = "CWURRF";

        /// <summary>
        /// CWUSER.
        /// </summary>
        public const string CWUSER = "CWUSER";

        /// <summary>
        /// CWPID.
        /// </summary>
        public const string CWPID = "CWPID";

        /// <summary>
        /// CWJOBN.
        /// </summary>
        public const string CWJOBN = "CWJOBN";

        /// <summary>
        /// CWUPMJ.
        /// </summary>
        public const string CWUPMJ = "CWUPMJ";

        /// <summary>
        /// CWTDAY.
        /// </summary>
        public const string CWTDAY = "CWTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4936";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWCVID", "CWCVID", JdeDataType.String, 24, true, true),
        new JdeField("CWEFTJ", "CWEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CWOSEQ", "CWOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CWVEHI", "CWVEHI", JdeDataType.String, 24),
        new JdeField("CWDUMV", "CWDUMV", JdeDataType.String, 2),
        new JdeField("CWRLNO", "CWRLNO", JdeDataType.String, 26),
        new JdeField("CWEXDJ", "CWEXDJ", JdeDataType.Numeric),
        new JdeField("CWURCD", "CWURCD", JdeDataType.String, 4),
        new JdeField("CWURDT", "CWURDT", JdeDataType.Numeric),
        new JdeField("CWURAT", "CWURAT", JdeDataType.Numeric),
        new JdeField("CWURAB", "CWURAB", JdeDataType.Numeric),
        new JdeField("CWURRF", "CWURRF", JdeDataType.String, 30),
        new JdeField("CWUSER", "CWUSER", JdeDataType.String, 20),
        new JdeField("CWPID", "CWPID", JdeDataType.String, 20),
        new JdeField("CWJOBN", "CWJOBN", JdeDataType.String, 20),
        new JdeField("CWUPMJ", "CWUPMJ", JdeDataType.Numeric),
        new JdeField("CWTDAY", "CWTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4936_0", "Primary Key on CWCVID, CWEFTJ, CWOSEQ", new[] { "CWCVID", "CWEFTJ", "CWOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4936_2", "Index on CWVEHI", new[] { "CWVEHI" })
    };
}
