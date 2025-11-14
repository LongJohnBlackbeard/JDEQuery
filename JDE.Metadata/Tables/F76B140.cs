using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B140 - .
/// </summary>
public class F76B140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIAN8.
        /// </summary>
        public const string AIAN8 = "AIAN8";

        /// <summary>
        /// AIB76INTY.
        /// </summary>
        public const string AIB76INTY = "AIB76INTY";

        /// <summary>
        /// AIB76REEN.
        /// </summary>
        public const string AIB76REEN = "AIB76REEN";

        /// <summary>
        /// AIB76INNU.
        /// </summary>
        public const string AIB76INNU = "AIB76INNU";

        /// <summary>
        /// AIB76ISDJ.
        /// </summary>
        public const string AIB76ISDJ = "AIB76ISDJ";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIAN8", "AIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AIB76INTY", "AIB76INTY", JdeDataType.String, 4, true, true),
        new JdeField("AIB76REEN", "AIB76REEN", JdeDataType.String, 4, true, true),
        new JdeField("AIB76INNU", "AIB76INNU", JdeDataType.String, 50),
        new JdeField("AIB76ISDJ", "AIB76ISDJ", JdeDataType.Numeric),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B140_0", "Primary Key on AIAN8, AIB76INTY, AIB76REEN", new[] { "AIAN8", "AIB76INTY", "AIB76REEN" }, isUnique: true, isPrimaryKey: true)
    };
}
