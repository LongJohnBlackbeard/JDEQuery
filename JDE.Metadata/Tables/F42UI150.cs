using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI150 - .
/// </summary>
public class F42UI150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZHJOBS.
        /// </summary>
        public const string ZHJOBS = "ZHJOBS";

        /// <summary>
        /// ZHCTID.
        /// </summary>
        public const string ZHCTID = "ZHCTID";

        /// <summary>
        /// ZHCMLN.
        /// </summary>
        public const string ZHCMLN = "ZHCMLN";

        /// <summary>
        /// ZHSLSM.
        /// </summary>
        public const string ZHSLSM = "ZHSLSM";

        /// <summary>
        /// ZHSLCM.
        /// </summary>
        public const string ZHSLCM = "ZHSLCM";

        /// <summary>
        /// ZHFCA.
        /// </summary>
        public const string ZHFCA = "ZHFCA";

        /// <summary>
        /// ZHAPUN.
        /// </summary>
        public const string ZHAPUN = "ZHAPUN";

        /// <summary>
        /// ZHCCTY.
        /// </summary>
        public const string ZHCCTY = "ZHCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZHJOBS", "ZHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHCTID", "ZHCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZHCMLN", "ZHCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHSLSM", "ZHSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHSLCM", "ZHSLCM", JdeDataType.Numeric),
        new JdeField("ZHFCA", "ZHFCA", JdeDataType.Numeric),
        new JdeField("ZHAPUN", "ZHAPUN", JdeDataType.Numeric),
        new JdeField("ZHCCTY", "ZHCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI150_0", "Primary Key on ZHJOBS, ZHCTID, ZHCMLN, ZHSLSM", new[] { "ZHJOBS", "ZHCTID", "ZHCMLN", "ZHSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
