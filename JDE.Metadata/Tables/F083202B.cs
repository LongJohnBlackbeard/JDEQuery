using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083202B - .
/// </summary>
public class F083202B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDPLAN.
        /// </summary>
        public const string MDPLAN = "MDPLAN";

        /// <summary>
        /// MDAOPT.
        /// </summary>
        public const string MDAOPT = "MDAOPT";

        /// <summary>
        /// MDMANP.
        /// </summary>
        public const string MDMANP = "MDMANP";

        /// <summary>
        /// MDXDFP.
        /// </summary>
        public const string MDXDFP = "MDXDFP";

        /// <summary>
        /// MDJOBN.
        /// </summary>
        public const string MDJOBN = "MDJOBN";

        /// <summary>
        /// MDUPMJ.
        /// </summary>
        public const string MDUPMJ = "MDUPMJ";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F083202B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDPLAN", "MDPLAN", JdeDataType.String, 16, true, true),
        new JdeField("MDAOPT", "MDAOPT", JdeDataType.String, 6, true, true),
        new JdeField("MDMANP", "MDMANP", JdeDataType.String, 2),
        new JdeField("MDXDFP", "MDXDFP", JdeDataType.String, 2),
        new JdeField("MDJOBN", "MDJOBN", JdeDataType.String, 20),
        new JdeField("MDUPMJ", "MDUPMJ", JdeDataType.Numeric),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083202B_0", "Primary Key on MDPLAN, MDAOPT", new[] { "MDPLAN", "MDAOPT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F083202B_2", "Index on MDPLAN, MDMANP", new[] { "MDPLAN", "MDMANP" }),
        new JdeIndex("F083202B_3", "Index on MDPLAN, MDXDFP", new[] { "MDPLAN", "MDXDFP" })
    };
}
