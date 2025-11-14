using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B058 - .
/// </summary>
public class F76B058 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WJB76ATCT.
        /// </summary>
        public const string WJB76ATCT = "WJB76ATCT";

        /// <summary>
        /// WJJOBS.
        /// </summary>
        public const string WJJOBS = "WJJOBS";

        /// <summary>
        /// WJB76BLCK.
        /// </summary>
        public const string WJB76BLCK = "WJB76BLCK";

        /// <summary>
        /// WJTAX.
        /// </summary>
        public const string WJTAX = "WJTAX";

        /// <summary>
        /// WJCO.
        /// </summary>
        public const string WJCO = "WJCO";

        /// <summary>
        /// WJB76JPID.
        /// </summary>
        public const string WJB76JPID = "WJB76JPID";

        /// <summary>
        /// WJB76SCID.
        /// </summary>
        public const string WJB76SCID = "WJB76SCID";

        /// <summary>
        /// WJB76VRID.
        /// </summary>
        public const string WJB76VRID = "WJB76VRID";

        /// <summary>
        /// WJB76URAB.
        /// </summary>
        public const string WJB76URAB = "WJB76URAB";

        /// <summary>
        /// WJB76URAT.
        /// </summary>
        public const string WJB76URAT = "WJB76URAT";

        /// <summary>
        /// WJB76URRF.
        /// </summary>
        public const string WJB76URRF = "WJB76URRF";

        /// <summary>
        /// WJB76URDT.
        /// </summary>
        public const string WJB76URDT = "WJB76URDT";

        /// <summary>
        /// WJB76URCD.
        /// </summary>
        public const string WJB76URCD = "WJB76URCD";

        /// <summary>
        /// WJUSER.
        /// </summary>
        public const string WJUSER = "WJUSER";

        /// <summary>
        /// WJPID.
        /// </summary>
        public const string WJPID = "WJPID";

        /// <summary>
        /// WJJOBN.
        /// </summary>
        public const string WJJOBN = "WJJOBN";

        /// <summary>
        /// WJUPMJ.
        /// </summary>
        public const string WJUPMJ = "WJUPMJ";

        /// <summary>
        /// WJUPMT.
        /// </summary>
        public const string WJUPMT = "WJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B058";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WJB76ATCT", "WJB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WJJOBS", "WJJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WJB76BLCK", "WJB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WJTAX", "WJTAX", JdeDataType.String, 40, true, true),
        new JdeField("WJCO", "WJCO", JdeDataType.String, 10, true, true),
        new JdeField("WJB76JPID", "WJB76JPID", JdeDataType.String, 80, true, true),
        new JdeField("WJB76SCID", "WJB76SCID", JdeDataType.String, 512, true, true),
        new JdeField("WJB76VRID", "WJB76VRID", JdeDataType.String, 4, true, true),
        new JdeField("WJB76URAB", "WJB76URAB", JdeDataType.Numeric),
        new JdeField("WJB76URAT", "WJB76URAT", JdeDataType.Numeric),
        new JdeField("WJB76URRF", "WJB76URRF", JdeDataType.String, 30),
        new JdeField("WJB76URDT", "WJB76URDT", JdeDataType.Numeric),
        new JdeField("WJB76URCD", "WJB76URCD", JdeDataType.String, 4),
        new JdeField("WJUSER", "WJUSER", JdeDataType.String, 20),
        new JdeField("WJPID", "WJPID", JdeDataType.String, 20),
        new JdeField("WJJOBN", "WJJOBN", JdeDataType.String, 20),
        new JdeField("WJUPMJ", "WJUPMJ", JdeDataType.Numeric),
        new JdeField("WJUPMT", "WJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B058_0", "Primary Key on WJB76ATCT, WJJOBS, WJB76BLCK, WJTAX, WJCO, WJB76JPID, WJB76SCID, WJB76VRID", new[] { "WJB76ATCT", "WJJOBS", "WJB76BLCK", "WJTAX", "WJCO", "WJB76JPID", "WJB76SCID", "WJB76VRID" }, isUnique: true, isPrimaryKey: true)
    };
}
