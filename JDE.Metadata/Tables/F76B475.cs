using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B475 - .
/// </summary>
public class F76B475 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLBKCD.
        /// </summary>
        public const string BLBKCD = "BLBKCD";

        /// <summary>
        /// BLTYTN.
        /// </summary>
        public const string BLTYTN = "BLTYTN";

        /// <summary>
        /// BLPYIN.
        /// </summary>
        public const string BLPYIN = "BLPYIN";

        /// <summary>
        /// BLBDFLAY.
        /// </summary>
        public const string BLBDFLAY = "BLBDFLAY";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLJOBN.
        /// </summary>
        public const string BLJOBN = "BLJOBN";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLUPMJ.
        /// </summary>
        public const string BLUPMJ = "BLUPMJ";

        /// <summary>
        /// BLUPMT.
        /// </summary>
        public const string BLUPMT = "BLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B475";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLBKCD", "BLBKCD", JdeDataType.String, 6, true, true),
        new JdeField("BLTYTN", "BLTYTN", JdeDataType.String, 16, true, true),
        new JdeField("BLPYIN", "BLPYIN", JdeDataType.String, 2, true, true),
        new JdeField("BLBDFLAY", "BLBDFLAY", JdeDataType.String, 20),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLJOBN", "BLJOBN", JdeDataType.String, 20),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLUPMJ", "BLUPMJ", JdeDataType.Numeric),
        new JdeField("BLUPMT", "BLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B475_0", "Primary Key on BLBKCD, BLTYTN, BLPYIN", new[] { "BLBKCD", "BLTYTN", "BLPYIN" }, isUnique: true, isPrimaryKey: true)
    };
}
