using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B476 - .
/// </summary>
public class F76B476 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BXBKCD.
        /// </summary>
        public const string BXBKCD = "BXBKCD";

        /// <summary>
        /// BXTYTN.
        /// </summary>
        public const string BXTYTN = "BXTYTN";

        /// <summary>
        /// BXBDFATR.
        /// </summary>
        public const string BXBDFATR = "BXBDFATR";

        /// <summary>
        /// BXBDFJDV.
        /// </summary>
        public const string BXBDFJDV = "BXBDFJDV";

        /// <summary>
        /// BXBDFBKV.
        /// </summary>
        public const string BXBDFBKV = "BXBDFBKV";

        /// <summary>
        /// BXDL01.
        /// </summary>
        public const string BXDL01 = "BXDL01";

        /// <summary>
        /// BXPID.
        /// </summary>
        public const string BXPID = "BXPID";

        /// <summary>
        /// BXJOBN.
        /// </summary>
        public const string BXJOBN = "BXJOBN";

        /// <summary>
        /// BXUSER.
        /// </summary>
        public const string BXUSER = "BXUSER";

        /// <summary>
        /// BXUPMJ.
        /// </summary>
        public const string BXUPMJ = "BXUPMJ";

        /// <summary>
        /// BXUPMT.
        /// </summary>
        public const string BXUPMT = "BXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B476";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BXBKCD", "BXBKCD", JdeDataType.String, 6, true, true),
        new JdeField("BXTYTN", "BXTYTN", JdeDataType.String, 16, true, true),
        new JdeField("BXBDFATR", "BXBDFATR", JdeDataType.String, 10, true, true),
        new JdeField("BXBDFJDV", "BXBDFJDV", JdeDataType.String, 60, true, true),
        new JdeField("BXBDFBKV", "BXBDFBKV", JdeDataType.String, 60, true, true),
        new JdeField("BXDL01", "BXDL01", JdeDataType.String, 60),
        new JdeField("BXPID", "BXPID", JdeDataType.String, 20),
        new JdeField("BXJOBN", "BXJOBN", JdeDataType.String, 20),
        new JdeField("BXUSER", "BXUSER", JdeDataType.String, 20),
        new JdeField("BXUPMJ", "BXUPMJ", JdeDataType.Numeric),
        new JdeField("BXUPMT", "BXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B476_0", "Primary Key on BXBKCD, BXTYTN, BXBDFATR, BXBDFJDV, BXBDFBKV", new[] { "BXBKCD", "BXTYTN", "BXBDFATR", "BXBDFJDV", "BXBDFBKV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B476_2", "Index on BXBKCD, BXTYTN, BXBDFATR, BXBDFBKV", new[] { "BXBKCD", "BXTYTN", "BXBDFATR", "BXBDFBKV" })
    };
}
