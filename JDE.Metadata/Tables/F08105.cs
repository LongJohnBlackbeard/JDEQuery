using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08105 - .
/// </summary>
public class F08105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HMREQN.
        /// </summary>
        public const string HMREQN = "HMREQN";

        /// <summary>
        /// HMAN8.
        /// </summary>
        public const string HMAN8 = "HMAN8";

        /// <summary>
        /// HMDTAV.
        /// </summary>
        public const string HMDTAV = "HMDTAV";

        /// <summary>
        /// HMCRST.
        /// </summary>
        public const string HMCRST = "HMCRST";

        /// <summary>
        /// HMCRSD.
        /// </summary>
        public const string HMCRSD = "HMCRSD";

        /// <summary>
        /// HMUSER.
        /// </summary>
        public const string HMUSER = "HMUSER";

        /// <summary>
        /// HMPID.
        /// </summary>
        public const string HMPID = "HMPID";

        /// <summary>
        /// HMUPMJ.
        /// </summary>
        public const string HMUPMJ = "HMUPMJ";

        /// <summary>
        /// HMJOBN.
        /// </summary>
        public const string HMJOBN = "HMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HMREQN", "HMREQN", JdeDataType.Numeric, null, true, true),
        new JdeField("HMAN8", "HMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HMDTAV", "HMDTAV", JdeDataType.Numeric),
        new JdeField("HMCRST", "HMCRST", JdeDataType.String, 6),
        new JdeField("HMCRSD", "HMCRSD", JdeDataType.Numeric),
        new JdeField("HMUSER", "HMUSER", JdeDataType.String, 20),
        new JdeField("HMPID", "HMPID", JdeDataType.String, 20),
        new JdeField("HMUPMJ", "HMUPMJ", JdeDataType.Numeric),
        new JdeField("HMJOBN", "HMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08105_0", "Primary Key on HMREQN, HMAN8", new[] { "HMREQN", "HMAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08105_2", "Index on HMAN8", new[] { "HMAN8" })
    };
}
