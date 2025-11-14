using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0802 - .
/// </summary>
public class F76B0802 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMB76ATCT.
        /// </summary>
        public const string UMB76ATCT = "UMB76ATCT";

        /// <summary>
        /// UMJOBS.
        /// </summary>
        public const string UMJOBS = "UMJOBS";

        /// <summary>
        /// UMB76BLCK.
        /// </summary>
        public const string UMB76BLCK = "UMB76BLCK";

        /// <summary>
        /// UMUOM1.
        /// </summary>
        public const string UMUOM1 = "UMUOM1";

        /// <summary>
        /// UMB76URAB.
        /// </summary>
        public const string UMB76URAB = "UMB76URAB";

        /// <summary>
        /// UMB76URAT.
        /// </summary>
        public const string UMB76URAT = "UMB76URAT";

        /// <summary>
        /// UMB76URRF.
        /// </summary>
        public const string UMB76URRF = "UMB76URRF";

        /// <summary>
        /// UMB76URDT.
        /// </summary>
        public const string UMB76URDT = "UMB76URDT";

        /// <summary>
        /// UMB76URCD.
        /// </summary>
        public const string UMB76URCD = "UMB76URCD";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMUPMT.
        /// </summary>
        public const string UMUPMT = "UMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0802";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMB76ATCT", "UMB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("UMJOBS", "UMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("UMB76BLCK", "UMB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("UMUOM1", "UMUOM1", JdeDataType.String, 4, true, true),
        new JdeField("UMB76URAB", "UMB76URAB", JdeDataType.Numeric),
        new JdeField("UMB76URAT", "UMB76URAT", JdeDataType.Numeric),
        new JdeField("UMB76URRF", "UMB76URRF", JdeDataType.String, 30),
        new JdeField("UMB76URDT", "UMB76URDT", JdeDataType.Numeric),
        new JdeField("UMB76URCD", "UMB76URCD", JdeDataType.String, 4),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMUPMT", "UMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0802_0", "Primary Key on UMB76ATCT, UMJOBS, UMB76BLCK, UMUOM1", new[] { "UMB76ATCT", "UMJOBS", "UMB76BLCK", "UMUOM1" }, isUnique: true, isPrimaryKey: true)
    };
}
