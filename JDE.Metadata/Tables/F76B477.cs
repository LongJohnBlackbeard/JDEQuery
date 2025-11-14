using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B477 - .
/// </summary>
public class F76B477 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BGGLBA.
        /// </summary>
        public const string BGGLBA = "BGGLBA";

        /// <summary>
        /// BGTYTN.
        /// </summary>
        public const string BGTYTN = "BGTYTN";

        /// <summary>
        /// BGBKCD.
        /// </summary>
        public const string BGBKCD = "BGBKCD";

        /// <summary>
        /// BGBBAN.
        /// </summary>
        public const string BGBBAN = "BGBBAN";

        /// <summary>
        /// BGBBFCN.
        /// </summary>
        public const string BGBBFCN = "BGBBFCN";

        /// <summary>
        /// BGBBDN.
        /// </summary>
        public const string BGBBDN = "BGBBDN";

        /// <summary>
        /// BGPID.
        /// </summary>
        public const string BGPID = "BGPID";

        /// <summary>
        /// BGJOBN.
        /// </summary>
        public const string BGJOBN = "BGJOBN";

        /// <summary>
        /// BGUSER.
        /// </summary>
        public const string BGUSER = "BGUSER";

        /// <summary>
        /// BGUPMJ.
        /// </summary>
        public const string BGUPMJ = "BGUPMJ";

        /// <summary>
        /// BGUPMT.
        /// </summary>
        public const string BGUPMT = "BGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B477";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BGGLBA", "BGGLBA", JdeDataType.String, 16, true, true),
        new JdeField("BGTYTN", "BGTYTN", JdeDataType.String, 16, true, true),
        new JdeField("BGBKCD", "BGBKCD", JdeDataType.String, 6),
        new JdeField("BGBBAN", "BGBBAN", JdeDataType.String, 60),
        new JdeField("BGBBFCN", "BGBBFCN", JdeDataType.Numeric),
        new JdeField("BGBBDN", "BGBBDN", JdeDataType.String, 30),
        new JdeField("BGPID", "BGPID", JdeDataType.String, 20),
        new JdeField("BGJOBN", "BGJOBN", JdeDataType.String, 20),
        new JdeField("BGUSER", "BGUSER", JdeDataType.String, 20),
        new JdeField("BGUPMJ", "BGUPMJ", JdeDataType.Numeric),
        new JdeField("BGUPMT", "BGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B477_0", "Primary Key on BGGLBA, BGTYTN", new[] { "BGGLBA", "BGTYTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B477_2", "Index on BGTYTN, BGBKCD", new[] { "BGTYTN", "BGBKCD" })
    };
}
