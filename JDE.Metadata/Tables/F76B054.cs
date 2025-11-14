using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B054 - .
/// </summary>
public class F76B054 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMB76ATCT.
        /// </summary>
        public const string WMB76ATCT = "WMB76ATCT";

        /// <summary>
        /// WMJOBS.
        /// </summary>
        public const string WMJOBS = "WMJOBS";

        /// <summary>
        /// WMB76BLCK.
        /// </summary>
        public const string WMB76BLCK = "WMB76BLCK";

        /// <summary>
        /// WMTAX.
        /// </summary>
        public const string WMTAX = "WMTAX";

        /// <summary>
        /// WMCO.
        /// </summary>
        public const string WMCO = "WMCO";

        /// <summary>
        /// WMKY.
        /// </summary>
        public const string WMKY = "WMKY";

        /// <summary>
        /// WMDL01.
        /// </summary>
        public const string WMDL01 = "WMDL01";

        /// <summary>
        /// WMDL02.
        /// </summary>
        public const string WMDL02 = "WMDL02";

        /// <summary>
        /// WMB76URAB.
        /// </summary>
        public const string WMB76URAB = "WMB76URAB";

        /// <summary>
        /// WMB76URAT.
        /// </summary>
        public const string WMB76URAT = "WMB76URAT";

        /// <summary>
        /// WMB76URRF.
        /// </summary>
        public const string WMB76URRF = "WMB76URRF";

        /// <summary>
        /// WMB76URDT.
        /// </summary>
        public const string WMB76URDT = "WMB76URDT";

        /// <summary>
        /// WMB76URCD.
        /// </summary>
        public const string WMB76URCD = "WMB76URCD";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMJOBN.
        /// </summary>
        public const string WMJOBN = "WMJOBN";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";

        /// <summary>
        /// WMUPMT.
        /// </summary>
        public const string WMUPMT = "WMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B054";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMB76ATCT", "WMB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WMJOBS", "WMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WMB76BLCK", "WMB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WMTAX", "WMTAX", JdeDataType.String, 40, true, true),
        new JdeField("WMCO", "WMCO", JdeDataType.String, 10, true, true),
        new JdeField("WMKY", "WMKY", JdeDataType.String, 20, true, true),
        new JdeField("WMDL01", "WMDL01", JdeDataType.String, 60),
        new JdeField("WMDL02", "WMDL02", JdeDataType.String, 60),
        new JdeField("WMB76URAB", "WMB76URAB", JdeDataType.Numeric),
        new JdeField("WMB76URAT", "WMB76URAT", JdeDataType.Numeric),
        new JdeField("WMB76URRF", "WMB76URRF", JdeDataType.String, 30),
        new JdeField("WMB76URDT", "WMB76URDT", JdeDataType.Numeric),
        new JdeField("WMB76URCD", "WMB76URCD", JdeDataType.String, 4),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMJOBN", "WMJOBN", JdeDataType.String, 20),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric),
        new JdeField("WMUPMT", "WMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B054_0", "Primary Key on WMB76ATCT, WMJOBS, WMB76BLCK, WMTAX, WMCO, WMKY", new[] { "WMB76ATCT", "WMJOBS", "WMB76BLCK", "WMTAX", "WMCO", "WMKY" }, isUnique: true, isPrimaryKey: true)
    };
}
