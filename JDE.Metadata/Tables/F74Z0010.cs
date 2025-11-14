using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Z0010 - .
/// </summary>
public class F74Z0010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZODOC.
        /// </summary>
        public const string ZODOC = "ZODOC";

        /// <summary>
        /// ZODCT.
        /// </summary>
        public const string ZODCT = "ZODCT";

        /// <summary>
        /// ZOCO.
        /// </summary>
        public const string ZOCO = "ZOCO";

        /// <summary>
        /// ZOMCU.
        /// </summary>
        public const string ZOMCU = "ZOMCU";

        /// <summary>
        /// ZODGJ.
        /// </summary>
        public const string ZODGJ = "ZODGJ";

        /// <summary>
        /// ZOODCT.
        /// </summary>
        public const string ZOODCT = "ZOODCT";

        /// <summary>
        /// ZOODOC.
        /// </summary>
        public const string ZOODOC = "ZOODOC";

        /// <summary>
        /// ZOICUT.
        /// </summary>
        public const string ZOICUT = "ZOICUT";

        /// <summary>
        /// ZOICU.
        /// </summary>
        public const string ZOICU = "ZOICU";

        /// <summary>
        /// ZOANI.
        /// </summary>
        public const string ZOANI = "ZOANI";

        /// <summary>
        /// ZOAA.
        /// </summary>
        public const string ZOAA = "ZOAA";

        /// <summary>
        /// ZOCRCD.
        /// </summary>
        public const string ZOCRCD = "ZOCRCD";

        /// <summary>
        /// ZOEXA.
        /// </summary>
        public const string ZOEXA = "ZOEXA";

        /// <summary>
        /// ZODSC1.
        /// </summary>
        public const string ZODSC1 = "ZODSC1";

        /// <summary>
        /// ZOUSER.
        /// </summary>
        public const string ZOUSER = "ZOUSER";

        /// <summary>
        /// ZOJOBN.
        /// </summary>
        public const string ZOJOBN = "ZOJOBN";

        /// <summary>
        /// ZOUPMJ.
        /// </summary>
        public const string ZOUPMJ = "ZOUPMJ";

        /// <summary>
        /// ZOUPMT.
        /// </summary>
        public const string ZOUPMT = "ZOUPMT";

        /// <summary>
        /// ZOPID.
        /// </summary>
        public const string ZOPID = "ZOPID";
    }

    /// <inheritdoc />
    public override string TableName => "F74Z0010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZODOC", "ZODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZODCT", "ZODCT", JdeDataType.String, 4, true, true),
        new JdeField("ZOCO", "ZOCO", JdeDataType.String, 10, true, true),
        new JdeField("ZOMCU", "ZOMCU", JdeDataType.String, 24, true, true),
        new JdeField("ZODGJ", "ZODGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ZOODCT", "ZOODCT", JdeDataType.String, 4),
        new JdeField("ZOODOC", "ZOODOC", JdeDataType.Numeric),
        new JdeField("ZOICUT", "ZOICUT", JdeDataType.String, 4),
        new JdeField("ZOICU", "ZOICU", JdeDataType.Numeric),
        new JdeField("ZOANI", "ZOANI", JdeDataType.String, 58),
        new JdeField("ZOAA", "ZOAA", JdeDataType.Numeric),
        new JdeField("ZOCRCD", "ZOCRCD", JdeDataType.String, 6),
        new JdeField("ZOEXA", "ZOEXA", JdeDataType.String, 60),
        new JdeField("ZODSC1", "ZODSC1", JdeDataType.String, 60),
        new JdeField("ZOUSER", "ZOUSER", JdeDataType.String, 20),
        new JdeField("ZOJOBN", "ZOJOBN", JdeDataType.String, 20),
        new JdeField("ZOUPMJ", "ZOUPMJ", JdeDataType.Numeric),
        new JdeField("ZOUPMT", "ZOUPMT", JdeDataType.Numeric),
        new JdeField("ZOPID", "ZOPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Z0010_0", "Primary Key on ZODOC, ZODCT, ZOCO, ZOMCU, ZODGJ", new[] { "ZODOC", "ZODCT", "ZOCO", "ZOMCU", "ZODGJ" }, isUnique: true, isPrimaryKey: true)
    };
}
