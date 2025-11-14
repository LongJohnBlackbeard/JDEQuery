using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B057 - .
/// </summary>
public class F76B057 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDB76ATCT.
        /// </summary>
        public const string WDB76ATCT = "WDB76ATCT";

        /// <summary>
        /// WDJOBS.
        /// </summary>
        public const string WDJOBS = "WDJOBS";

        /// <summary>
        /// WDB76BLCK.
        /// </summary>
        public const string WDB76BLCK = "WDB76BLCK";

        /// <summary>
        /// WDTAX.
        /// </summary>
        public const string WDTAX = "WDTAX";

        /// <summary>
        /// WDCO.
        /// </summary>
        public const string WDCO = "WDCO";

        /// <summary>
        /// WDB76APID.
        /// </summary>
        public const string WDB76APID = "WDB76APID";

        /// <summary>
        /// WDB76URAB.
        /// </summary>
        public const string WDB76URAB = "WDB76URAB";

        /// <summary>
        /// WDB76URAT.
        /// </summary>
        public const string WDB76URAT = "WDB76URAT";

        /// <summary>
        /// WDB76URRF.
        /// </summary>
        public const string WDB76URRF = "WDB76URRF";

        /// <summary>
        /// WDB76URDT.
        /// </summary>
        public const string WDB76URDT = "WDB76URDT";

        /// <summary>
        /// WDB76URCD.
        /// </summary>
        public const string WDB76URCD = "WDB76URCD";

        /// <summary>
        /// WDUSER.
        /// </summary>
        public const string WDUSER = "WDUSER";

        /// <summary>
        /// WDPID.
        /// </summary>
        public const string WDPID = "WDPID";

        /// <summary>
        /// WDJOBN.
        /// </summary>
        public const string WDJOBN = "WDJOBN";

        /// <summary>
        /// WDUPMJ.
        /// </summary>
        public const string WDUPMJ = "WDUPMJ";

        /// <summary>
        /// WDUPMT.
        /// </summary>
        public const string WDUPMT = "WDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B057";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDB76ATCT", "WDB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WDJOBS", "WDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WDB76BLCK", "WDB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WDTAX", "WDTAX", JdeDataType.String, 40, true, true),
        new JdeField("WDCO", "WDCO", JdeDataType.String, 10, true, true),
        new JdeField("WDB76APID", "WDB76APID", JdeDataType.String, 80, true, true),
        new JdeField("WDB76URAB", "WDB76URAB", JdeDataType.Numeric),
        new JdeField("WDB76URAT", "WDB76URAT", JdeDataType.Numeric),
        new JdeField("WDB76URRF", "WDB76URRF", JdeDataType.String, 30),
        new JdeField("WDB76URDT", "WDB76URDT", JdeDataType.Numeric),
        new JdeField("WDB76URCD", "WDB76URCD", JdeDataType.String, 4),
        new JdeField("WDUSER", "WDUSER", JdeDataType.String, 20),
        new JdeField("WDPID", "WDPID", JdeDataType.String, 20),
        new JdeField("WDJOBN", "WDJOBN", JdeDataType.String, 20),
        new JdeField("WDUPMJ", "WDUPMJ", JdeDataType.Numeric),
        new JdeField("WDUPMT", "WDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B057_0", "Primary Key on WDB76ATCT, WDJOBS, WDB76BLCK, WDTAX, WDCO, WDB76APID", new[] { "WDB76ATCT", "WDJOBS", "WDB76BLCK", "WDTAX", "WDCO", "WDB76APID" }, isUnique: true, isPrimaryKey: true)
    };
}
