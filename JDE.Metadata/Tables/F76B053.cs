using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B053 - .
/// </summary>
public class F76B053 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTB76ATCT.
        /// </summary>
        public const string WTB76ATCT = "WTB76ATCT";

        /// <summary>
        /// WTJOBS.
        /// </summary>
        public const string WTJOBS = "WTJOBS";

        /// <summary>
        /// WTB76BLCK.
        /// </summary>
        public const string WTB76BLCK = "WTB76BLCK";

        /// <summary>
        /// WTTAX.
        /// </summary>
        public const string WTTAX = "WTTAX";

        /// <summary>
        /// WTCO.
        /// </summary>
        public const string WTCO = "WTCO";

        /// <summary>
        /// WTBNOP.
        /// </summary>
        public const string WTBNOP = "WTBNOP";

        /// <summary>
        /// WTBSOP.
        /// </summary>
        public const string WTBSOP = "WTBSOP";

        /// <summary>
        /// WTB76URAB.
        /// </summary>
        public const string WTB76URAB = "WTB76URAB";

        /// <summary>
        /// WTB76URAT.
        /// </summary>
        public const string WTB76URAT = "WTB76URAT";

        /// <summary>
        /// WTB76URRF.
        /// </summary>
        public const string WTB76URRF = "WTB76URRF";

        /// <summary>
        /// WTB76URDT.
        /// </summary>
        public const string WTB76URDT = "WTB76URDT";

        /// <summary>
        /// WTB76URCD.
        /// </summary>
        public const string WTB76URCD = "WTB76URCD";

        /// <summary>
        /// WTUSER.
        /// </summary>
        public const string WTUSER = "WTUSER";

        /// <summary>
        /// WTPID.
        /// </summary>
        public const string WTPID = "WTPID";

        /// <summary>
        /// WTJOBN.
        /// </summary>
        public const string WTJOBN = "WTJOBN";

        /// <summary>
        /// WTUPMJ.
        /// </summary>
        public const string WTUPMJ = "WTUPMJ";

        /// <summary>
        /// WTUPMT.
        /// </summary>
        public const string WTUPMT = "WTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B053";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTB76ATCT", "WTB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WTJOBS", "WTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WTB76BLCK", "WTB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WTTAX", "WTTAX", JdeDataType.String, 40, true, true),
        new JdeField("WTCO", "WTCO", JdeDataType.String, 10, true, true),
        new JdeField("WTBNOP", "WTBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("WTBSOP", "WTBSOP", JdeDataType.String, 4, true, true),
        new JdeField("WTB76URAB", "WTB76URAB", JdeDataType.Numeric),
        new JdeField("WTB76URAT", "WTB76URAT", JdeDataType.Numeric),
        new JdeField("WTB76URRF", "WTB76URRF", JdeDataType.String, 30),
        new JdeField("WTB76URDT", "WTB76URDT", JdeDataType.Numeric),
        new JdeField("WTB76URCD", "WTB76URCD", JdeDataType.String, 4),
        new JdeField("WTUSER", "WTUSER", JdeDataType.String, 20),
        new JdeField("WTPID", "WTPID", JdeDataType.String, 20),
        new JdeField("WTJOBN", "WTJOBN", JdeDataType.String, 20),
        new JdeField("WTUPMJ", "WTUPMJ", JdeDataType.Numeric),
        new JdeField("WTUPMT", "WTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B053_0", "Primary Key on WTB76ATCT, WTJOBS, WTB76BLCK, WTTAX, WTCO, WTBNOP, WTBSOP", new[] { "WTB76ATCT", "WTJOBS", "WTB76BLCK", "WTTAX", "WTCO", "WTBNOP", "WTBSOP" }, isUnique: true, isPrimaryKey: true)
    };
}
