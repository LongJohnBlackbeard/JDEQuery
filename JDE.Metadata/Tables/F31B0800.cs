using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0800 - .
/// </summary>
public class F31B0800 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REWOPID.
        /// </summary>
        public const string REWOPID = "REWOPID";

        /// <summary>
        /// REWVID.
        /// </summary>
        public const string REWVID = "REWVID";

        /// <summary>
        /// RELNID.
        /// </summary>
        public const string RELNID = "RELNID";

        /// <summary>
        /// REJOBS.
        /// </summary>
        public const string REJOBS = "REJOBS";

        /// <summary>
        /// REWOOPID.
        /// </summary>
        public const string REWOOPID = "REWOOPID";

        /// <summary>
        /// REDTAI.
        /// </summary>
        public const string REDTAI = "REDTAI";

        /// <summary>
        /// REWERRPID.
        /// </summary>
        public const string REWERRPID = "REWERRPID";

        /// <summary>
        /// REDS02.
        /// </summary>
        public const string REDS02 = "REDS02";

        /// <summary>
        /// REWERRS.
        /// </summary>
        public const string REWERRS = "REWERRS";

        /// <summary>
        /// REWERRT.
        /// </summary>
        public const string REWERRT = "REWERRT";

        /// <summary>
        /// REWERRC.
        /// </summary>
        public const string REWERRC = "REWERRC";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REJOBN.
        /// </summary>
        public const string REJOBN = "REJOBN";

        /// <summary>
        /// REUPMJ.
        /// </summary>
        public const string REUPMJ = "REUPMJ";

        /// <summary>
        /// REUPMT.
        /// </summary>
        public const string REUPMT = "REUPMT";

        /// <summary>
        /// REWVTY.
        /// </summary>
        public const string REWVTY = "REWVTY";

        /// <summary>
        /// REWDOCO.
        /// </summary>
        public const string REWDOCO = "REWDOCO";

        /// <summary>
        /// REMCU.
        /// </summary>
        public const string REMCU = "REMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0800";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REWOPID", "REWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("REWVID", "REWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("RELNID", "RELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("REJOBS", "REJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("REWOOPID", "REWOOPID", JdeDataType.Numeric),
        new JdeField("REDTAI", "REDTAI", JdeDataType.String, 20),
        new JdeField("REWERRPID", "REWERRPID", JdeDataType.String, 22),
        new JdeField("REDS02", "REDS02", JdeDataType.String, 160),
        new JdeField("REWERRS", "REWERRS", JdeDataType.String, 2),
        new JdeField("REWERRT", "REWERRT", JdeDataType.String, 2),
        new JdeField("REWERRC", "REWERRC", JdeDataType.String, 2),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REJOBN", "REJOBN", JdeDataType.String, 20),
        new JdeField("REUPMJ", "REUPMJ", JdeDataType.Numeric),
        new JdeField("REUPMT", "REUPMT", JdeDataType.Numeric),
        new JdeField("REWVTY", "REWVTY", JdeDataType.String, 2),
        new JdeField("REWDOCO", "REWDOCO", JdeDataType.Numeric),
        new JdeField("REMCU", "REMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0800_0", "Primary Key on REWOPID, REWVID, RELNID, REJOBS", new[] { "REWOPID", "REWVID", "RELNID", "REJOBS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0800_2", "Index on REWOPID", new[] { "REWOPID" }),
        new JdeIndex("F31B0800_3", "Index on REJOBS, SYS_NC00020$", new[] { "REJOBS", "SYS_NC00020$" })
    };
}
