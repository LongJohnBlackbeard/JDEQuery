using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I754 - .
/// </summary>
public class F75I754 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APPYID.
        /// </summary>
        public const string APPYID = "APPYID";

        /// <summary>
        /// APRC5.
        /// </summary>
        public const string APRC5 = "APRC5";

        /// <summary>
        /// API75RCLA.
        /// </summary>
        public const string API75RCLA = "API75RCLA";

        /// <summary>
        /// API75PS.
        /// </summary>
        public const string API75PS = "API75PS";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APTDAY.
        /// </summary>
        public const string APTDAY = "APTDAY";

        /// <summary>
        /// APMATH01.
        /// </summary>
        public const string APMATH01 = "APMATH01";

        /// <summary>
        /// APYS05.
        /// </summary>
        public const string APYS05 = "APYS05";

        /// <summary>
        /// APEV01.
        /// </summary>
        public const string APEV01 = "APEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I754";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APPYID", "APPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("APRC5", "APRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("API75RCLA", "API75RCLA", JdeDataType.String, 2),
        new JdeField("API75PS", "API75PS", JdeDataType.String, 4),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APTDAY", "APTDAY", JdeDataType.Numeric),
        new JdeField("APMATH01", "APMATH01", JdeDataType.Numeric),
        new JdeField("APYS05", "APYS05", JdeDataType.String, 40),
        new JdeField("APEV01", "APEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I754_0", "Primary Key on APPYID, APRC5", new[] { "APPYID", "APRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
