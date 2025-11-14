using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F050612 - .
/// </summary>
public class F050612 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// URURLKID.
        /// </summary>
        public const string URURLKID = "URURLKID";

        /// <summary>
        /// URUKIDSZ.
        /// </summary>
        public const string URUKIDSZ = "URUKIDSZ";

        /// <summary>
        /// URSEQN.
        /// </summary>
        public const string URSEQN = "URSEQN";

        /// <summary>
        /// URLANG.
        /// </summary>
        public const string URLANG = "URLANG";

        /// <summary>
        /// URUSER.
        /// </summary>
        public const string URUSER = "URUSER";

        /// <summary>
        /// URPID.
        /// </summary>
        public const string URPID = "URPID";

        /// <summary>
        /// URJOBN.
        /// </summary>
        public const string URJOBN = "URJOBN";

        /// <summary>
        /// URUPMJ.
        /// </summary>
        public const string URUPMJ = "URUPMJ";

        /// <summary>
        /// URUPMT.
        /// </summary>
        public const string URUPMT = "URUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F050612";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("URURLKID", "URURLKID", JdeDataType.String, 24, true, true),
        new JdeField("URUKIDSZ", "URUKIDSZ", JdeDataType.String, 100, true, true),
        new JdeField("URSEQN", "URSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("URLANG", "URLANG", JdeDataType.String, 4, true, true),
        new JdeField("URUSER", "URUSER", JdeDataType.String, 20),
        new JdeField("URPID", "URPID", JdeDataType.String, 20),
        new JdeField("URJOBN", "URJOBN", JdeDataType.String, 20),
        new JdeField("URUPMJ", "URUPMJ", JdeDataType.Numeric),
        new JdeField("URUPMT", "URUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F050612_0", "Primary Key on URUKIDSZ, URURLKID, URSEQN, URLANG", new[] { "URUKIDSZ", "URURLKID", "URSEQN", "URLANG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F050612_3", "Index on URURLKID, URLANG", new[] { "URURLKID", "URLANG" }),
        new JdeIndex("F050612_4", "Index on URUKIDSZ", new[] { "URUKIDSZ" })
    };
}
