using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0404 - .
/// </summary>
public class F75A0404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZMAUSPTSED.
        /// </summary>
        public const string ZMAUSPTSED = "ZMAUSPTSED";

        /// <summary>
        /// ZMAUSPTEED.
        /// </summary>
        public const string ZMAUSPTEED = "ZMAUSPTEED";

        /// <summary>
        /// ZMAUSPTCGI.
        /// </summary>
        public const string ZMAUSPTCGI = "ZMAUSPTCGI";

        /// <summary>
        /// ZMCO.
        /// </summary>
        public const string ZMCO = "ZMCO";

        /// <summary>
        /// ZMUSER.
        /// </summary>
        public const string ZMUSER = "ZMUSER";

        /// <summary>
        /// ZMPID.
        /// </summary>
        public const string ZMPID = "ZMPID";

        /// <summary>
        /// ZMUPMJ.
        /// </summary>
        public const string ZMUPMJ = "ZMUPMJ";

        /// <summary>
        /// ZMUPMT.
        /// </summary>
        public const string ZMUPMT = "ZMUPMT";

        /// <summary>
        /// ZMJOBN.
        /// </summary>
        public const string ZMJOBN = "ZMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZMAUSPTSED", "ZMAUSPTSED", JdeDataType.Numeric, null, true, true),
        new JdeField("ZMAUSPTEED", "ZMAUSPTEED", JdeDataType.Numeric, null, true, true),
        new JdeField("ZMAUSPTCGI", "ZMAUSPTCGI", JdeDataType.String, 16, true, true),
        new JdeField("ZMCO", "ZMCO", JdeDataType.String, 10, true, true),
        new JdeField("ZMUSER", "ZMUSER", JdeDataType.String, 20),
        new JdeField("ZMPID", "ZMPID", JdeDataType.String, 20),
        new JdeField("ZMUPMJ", "ZMUPMJ", JdeDataType.Numeric),
        new JdeField("ZMUPMT", "ZMUPMT", JdeDataType.Numeric),
        new JdeField("ZMJOBN", "ZMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0404_0", "Primary Key on ZMAUSPTSED, ZMAUSPTEED, ZMAUSPTCGI, ZMCO", new[] { "ZMAUSPTSED", "ZMAUSPTEED", "ZMAUSPTCGI", "ZMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A0404_2", "Index on ZMCO", new[] { "ZMCO" }),
        new JdeIndex("F75A0404_3", "Index on ZMAUSPTCGI", new[] { "ZMAUSPTCGI" })
    };
}
