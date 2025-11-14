using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I790 - .
/// </summary>
public class F75I790 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTJOBS.
        /// </summary>
        public const string WTJOBS = "WTJOBS";

        /// <summary>
        /// WTCTID.
        /// </summary>
        public const string WTCTID = "WTCTID";

        /// <summary>
        /// WTI75SRCT.
        /// </summary>
        public const string WTI75SRCT = "WTI75SRCT";

        /// <summary>
        /// WTDL01.
        /// </summary>
        public const string WTDL01 = "WTDL01";

        /// <summary>
        /// WTYS01.
        /// </summary>
        public const string WTYS01 = "WTYS01";

        /// <summary>
        /// WTYS02.
        /// </summary>
        public const string WTYS02 = "WTYS02";
    }

    /// <inheritdoc />
    public override string TableName => "F75I790";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTJOBS", "WTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WTCTID", "WTCTID", JdeDataType.String, 30, true, true),
        new JdeField("WTI75SRCT", "WTI75SRCT", JdeDataType.String, 12, true, true),
        new JdeField("WTDL01", "WTDL01", JdeDataType.String, 60),
        new JdeField("WTYS01", "WTYS01", JdeDataType.String, 20),
        new JdeField("WTYS02", "WTYS02", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I790_0", "Primary Key on WTJOBS, WTCTID, WTI75SRCT", new[] { "WTJOBS", "WTCTID", "WTI75SRCT" }, isUnique: true, isPrimaryKey: true)
    };
}
