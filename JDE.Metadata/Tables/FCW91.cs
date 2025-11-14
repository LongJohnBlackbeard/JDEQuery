using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW91 - .
/// </summary>
public class FCW91 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C9JOBS.
        /// </summary>
        public const string C9JOBS = "C9JOBS";

        /// <summary>
        /// C9DOCO.
        /// </summary>
        public const string C9DOCO = "C9DOCO";

        /// <summary>
        /// C9DCTO.
        /// </summary>
        public const string C9DCTO = "C9DCTO";

        /// <summary>
        /// C9LNID.
        /// </summary>
        public const string C9LNID = "C9LNID";

        /// <summary>
        /// C9KCOO.
        /// </summary>
        public const string C9KCOO = "C9KCOO";

        /// <summary>
        /// C9LTTR.
        /// </summary>
        public const string C9LTTR = "C9LTTR";

        /// <summary>
        /// C9NXTR.
        /// </summary>
        public const string C9NXTR = "C9NXTR";

        /// <summary>
        /// C9WRTH.
        /// </summary>
        public const string C9WRTH = "C9WRTH";
    }

    /// <inheritdoc />
    public override string TableName => "FCW91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C9JOBS", "C9JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("C9DOCO", "C9DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("C9DCTO", "C9DCTO", JdeDataType.String, 4, true, true),
        new JdeField("C9LNID", "C9LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("C9KCOO", "C9KCOO", JdeDataType.String, 10, true, true),
        new JdeField("C9LTTR", "C9LTTR", JdeDataType.String, 6),
        new JdeField("C9NXTR", "C9NXTR", JdeDataType.String, 6),
        new JdeField("C9WRTH", "C9WRTH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW91_0", "Primary Key on C9KCOO, C9DOCO, C9DCTO, C9LNID, C9JOBS", new[] { "C9KCOO", "C9DOCO", "C9DCTO", "C9LNID", "C9JOBS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW91_3", "Index on C9LTTR, C9NXTR", new[] { "C9LTTR", "C9NXTR" })
    };
}
