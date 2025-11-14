using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B055 - .
/// </summary>
public class F76B055 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCB76ATCT.
        /// </summary>
        public const string WCB76ATCT = "WCB76ATCT";

        /// <summary>
        /// WCJOBS.
        /// </summary>
        public const string WCJOBS = "WCJOBS";

        /// <summary>
        /// WCB76BLCK.
        /// </summary>
        public const string WCB76BLCK = "WCB76BLCK";

        /// <summary>
        /// WCTAX.
        /// </summary>
        public const string WCTAX = "WCTAX";

        /// <summary>
        /// WCCO.
        /// </summary>
        public const string WCCO = "WCCO";

        /// <summary>
        /// WCMCU.
        /// </summary>
        public const string WCMCU = "WCMCU";

        /// <summary>
        /// WCB76URAB.
        /// </summary>
        public const string WCB76URAB = "WCB76URAB";

        /// <summary>
        /// WCB76URAT.
        /// </summary>
        public const string WCB76URAT = "WCB76URAT";

        /// <summary>
        /// WCB76URRF.
        /// </summary>
        public const string WCB76URRF = "WCB76URRF";

        /// <summary>
        /// WCB76URDT.
        /// </summary>
        public const string WCB76URDT = "WCB76URDT";

        /// <summary>
        /// WCB76URCD.
        /// </summary>
        public const string WCB76URCD = "WCB76URCD";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B055";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCB76ATCT", "WCB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WCJOBS", "WCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WCB76BLCK", "WCB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WCTAX", "WCTAX", JdeDataType.String, 40, true, true),
        new JdeField("WCCO", "WCCO", JdeDataType.String, 10, true, true),
        new JdeField("WCMCU", "WCMCU", JdeDataType.String, 24, true, true),
        new JdeField("WCB76URAB", "WCB76URAB", JdeDataType.Numeric),
        new JdeField("WCB76URAT", "WCB76URAT", JdeDataType.Numeric),
        new JdeField("WCB76URRF", "WCB76URRF", JdeDataType.String, 30),
        new JdeField("WCB76URDT", "WCB76URDT", JdeDataType.Numeric),
        new JdeField("WCB76URCD", "WCB76URCD", JdeDataType.String, 4),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B055_0", "Primary Key on WCB76ATCT, WCJOBS, WCB76BLCK, WCTAX, WCCO, WCMCU", new[] { "WCB76ATCT", "WCJOBS", "WCB76BLCK", "WCTAX", "WCCO", "WCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
