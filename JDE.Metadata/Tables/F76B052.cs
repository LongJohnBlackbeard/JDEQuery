using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B052 - .
/// </summary>
public class F76B052 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WUB76ATCT.
        /// </summary>
        public const string WUB76ATCT = "WUB76ATCT";

        /// <summary>
        /// WUJOBS.
        /// </summary>
        public const string WUJOBS = "WUJOBS";

        /// <summary>
        /// WUB76BLCK.
        /// </summary>
        public const string WUB76BLCK = "WUB76BLCK";

        /// <summary>
        /// WUTAX.
        /// </summary>
        public const string WUTAX = "WUTAX";

        /// <summary>
        /// WUCO.
        /// </summary>
        public const string WUCO = "WUCO";

        /// <summary>
        /// WUUOM1.
        /// </summary>
        public const string WUUOM1 = "WUUOM1";

        /// <summary>
        /// WUB76URAB.
        /// </summary>
        public const string WUB76URAB = "WUB76URAB";

        /// <summary>
        /// WUB76URAT.
        /// </summary>
        public const string WUB76URAT = "WUB76URAT";

        /// <summary>
        /// WUB76URRF.
        /// </summary>
        public const string WUB76URRF = "WUB76URRF";

        /// <summary>
        /// WUB76URDT.
        /// </summary>
        public const string WUB76URDT = "WUB76URDT";

        /// <summary>
        /// WUB76URCD.
        /// </summary>
        public const string WUB76URCD = "WUB76URCD";

        /// <summary>
        /// WUUSER.
        /// </summary>
        public const string WUUSER = "WUUSER";

        /// <summary>
        /// WUPID.
        /// </summary>
        public const string WUPID = "WUPID";

        /// <summary>
        /// WUJOBN.
        /// </summary>
        public const string WUJOBN = "WUJOBN";

        /// <summary>
        /// WUUPMJ.
        /// </summary>
        public const string WUUPMJ = "WUUPMJ";

        /// <summary>
        /// WUUPMT.
        /// </summary>
        public const string WUUPMT = "WUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B052";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WUB76ATCT", "WUB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WUJOBS", "WUJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WUB76BLCK", "WUB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WUTAX", "WUTAX", JdeDataType.String, 40, true, true),
        new JdeField("WUCO", "WUCO", JdeDataType.String, 10, true, true),
        new JdeField("WUUOM1", "WUUOM1", JdeDataType.String, 4, true, true),
        new JdeField("WUB76URAB", "WUB76URAB", JdeDataType.Numeric),
        new JdeField("WUB76URAT", "WUB76URAT", JdeDataType.Numeric),
        new JdeField("WUB76URRF", "WUB76URRF", JdeDataType.String, 30),
        new JdeField("WUB76URDT", "WUB76URDT", JdeDataType.Numeric),
        new JdeField("WUB76URCD", "WUB76URCD", JdeDataType.String, 4),
        new JdeField("WUUSER", "WUUSER", JdeDataType.String, 20),
        new JdeField("WUPID", "WUPID", JdeDataType.String, 20),
        new JdeField("WUJOBN", "WUJOBN", JdeDataType.String, 20),
        new JdeField("WUUPMJ", "WUUPMJ", JdeDataType.Numeric),
        new JdeField("WUUPMT", "WUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B052_0", "Primary Key on WUB76ATCT, WUJOBS, WUB76BLCK, WUTAX, WUCO, WUUOM1", new[] { "WUB76ATCT", "WUJOBS", "WUB76BLCK", "WUTAX", "WUCO", "WUUOM1" }, isUnique: true, isPrimaryKey: true)
    };
}
