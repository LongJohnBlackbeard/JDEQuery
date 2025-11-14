using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B051 - .
/// </summary>
public class F76B051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WIB76ATCT.
        /// </summary>
        public const string WIB76ATCT = "WIB76ATCT";

        /// <summary>
        /// WIJOBS.
        /// </summary>
        public const string WIJOBS = "WIJOBS";

        /// <summary>
        /// WIB76BLCK.
        /// </summary>
        public const string WIB76BLCK = "WIB76BLCK";

        /// <summary>
        /// WITAX.
        /// </summary>
        public const string WITAX = "WITAX";

        /// <summary>
        /// WICO.
        /// </summary>
        public const string WICO = "WICO";

        /// <summary>
        /// WIITM.
        /// </summary>
        public const string WIITM = "WIITM";

        /// <summary>
        /// WIB76URAB.
        /// </summary>
        public const string WIB76URAB = "WIB76URAB";

        /// <summary>
        /// WIB76URAT.
        /// </summary>
        public const string WIB76URAT = "WIB76URAT";

        /// <summary>
        /// WIB76URRF.
        /// </summary>
        public const string WIB76URRF = "WIB76URRF";

        /// <summary>
        /// WIB76URDT.
        /// </summary>
        public const string WIB76URDT = "WIB76URDT";

        /// <summary>
        /// WIB76URCD.
        /// </summary>
        public const string WIB76URCD = "WIB76URCD";

        /// <summary>
        /// WIUSER.
        /// </summary>
        public const string WIUSER = "WIUSER";

        /// <summary>
        /// WIPID.
        /// </summary>
        public const string WIPID = "WIPID";

        /// <summary>
        /// WIJOBN.
        /// </summary>
        public const string WIJOBN = "WIJOBN";

        /// <summary>
        /// WIUPMJ.
        /// </summary>
        public const string WIUPMJ = "WIUPMJ";

        /// <summary>
        /// WIUPMT.
        /// </summary>
        public const string WIUPMT = "WIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WIB76ATCT", "WIB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WIJOBS", "WIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WIB76BLCK", "WIB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WITAX", "WITAX", JdeDataType.String, 40, true, true),
        new JdeField("WICO", "WICO", JdeDataType.String, 10, true, true),
        new JdeField("WIITM", "WIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WIB76URAB", "WIB76URAB", JdeDataType.Numeric),
        new JdeField("WIB76URAT", "WIB76URAT", JdeDataType.Numeric),
        new JdeField("WIB76URRF", "WIB76URRF", JdeDataType.String, 30),
        new JdeField("WIB76URDT", "WIB76URDT", JdeDataType.Numeric),
        new JdeField("WIB76URCD", "WIB76URCD", JdeDataType.String, 4),
        new JdeField("WIUSER", "WIUSER", JdeDataType.String, 20),
        new JdeField("WIPID", "WIPID", JdeDataType.String, 20),
        new JdeField("WIJOBN", "WIJOBN", JdeDataType.String, 20),
        new JdeField("WIUPMJ", "WIUPMJ", JdeDataType.Numeric),
        new JdeField("WIUPMT", "WIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B051_0", "Primary Key on WIB76ATCT, WIJOBS, WIB76BLCK, WITAX, WICO, WIITM", new[] { "WIB76ATCT", "WIJOBS", "WIB76BLCK", "WITAX", "WICO", "WIITM" }, isUnique: true, isPrimaryKey: true)
    };
}
