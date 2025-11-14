using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW21 - .
/// </summary>
public class FCW21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WKJOBS.
        /// </summary>
        public const string WKJOBS = "WKJOBS";

        /// <summary>
        /// WKUSER.
        /// </summary>
        public const string WKUSER = "WKUSER";

        /// <summary>
        /// WKKCOO.
        /// </summary>
        public const string WKKCOO = "WKKCOO";

        /// <summary>
        /// WKDOCO.
        /// </summary>
        public const string WKDOCO = "WKDOCO";

        /// <summary>
        /// WKDCTO.
        /// </summary>
        public const string WKDCTO = "WKDCTO";

        /// <summary>
        /// WKLNID.
        /// </summary>
        public const string WKLNID = "WKLNID";

        /// <summary>
        /// WKMCU.
        /// </summary>
        public const string WKMCU = "WKMCU";

        /// <summary>
        /// WKLOCN.
        /// </summary>
        public const string WKLOCN = "WKLOCN";

        /// <summary>
        /// WKLOTN.
        /// </summary>
        public const string WKLOTN = "WKLOTN";

        /// <summary>
        /// WKRECOPT.
        /// </summary>
        public const string WKRECOPT = "WKRECOPT";

        /// <summary>
        /// WKSOQS.
        /// </summary>
        public const string WKSOQS = "WKSOQS";
    }

    /// <inheritdoc />
    public override string TableName => "FCW21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WKJOBS", "WKJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WKUSER", "WKUSER", JdeDataType.String, 20, true, true),
        new JdeField("WKKCOO", "WKKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WKDOCO", "WKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WKDCTO", "WKDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WKLNID", "WKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WKMCU", "WKMCU", JdeDataType.String, 24, true, true),
        new JdeField("WKLOCN", "WKLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WKLOTN", "WKLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WKRECOPT", "WKRECOPT", JdeDataType.String, 2, true, true),
        new JdeField("WKSOQS", "WKSOQS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW21_0", "Primary Key on WKJOBS, WKUSER, WKKCOO, WKDOCO, WKDCTO, WKLNID, WKMCU, WKLOCN, WKLOTN, WKRECOPT", new[] { "WKJOBS", "WKUSER", "WKKCOO", "WKDOCO", "WKDCTO", "WKLNID", "WKMCU", "WKLOCN", "WKLOTN", "WKRECOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
