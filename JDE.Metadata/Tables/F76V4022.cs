using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4022 - .
/// </summary>
public class F76V4022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WHV76ISLR.
        /// </summary>
        public const string WHV76ISLR = "WHV76ISLR";

        /// <summary>
        /// WHV76ISLC.
        /// </summary>
        public const string WHV76ISLC = "WHV76ISLC";

        /// <summary>
        /// WHUSER.
        /// </summary>
        public const string WHUSER = "WHUSER";

        /// <summary>
        /// WHPID.
        /// </summary>
        public const string WHPID = "WHPID";

        /// <summary>
        /// WHJOBN.
        /// </summary>
        public const string WHJOBN = "WHJOBN";

        /// <summary>
        /// WHUPMJ.
        /// </summary>
        public const string WHUPMJ = "WHUPMJ";

        /// <summary>
        /// WHUPMT.
        /// </summary>
        public const string WHUPMT = "WHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WHV76ISLR", "WHV76ISLR", JdeDataType.String, 6, true, true),
        new JdeField("WHV76ISLC", "WHV76ISLC", JdeDataType.String, 6),
        new JdeField("WHUSER", "WHUSER", JdeDataType.String, 20),
        new JdeField("WHPID", "WHPID", JdeDataType.String, 20),
        new JdeField("WHJOBN", "WHJOBN", JdeDataType.String, 20),
        new JdeField("WHUPMJ", "WHUPMJ", JdeDataType.Numeric),
        new JdeField("WHUPMT", "WHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4022_0", "Primary Key on WHV76ISLR", new[] { "WHV76ISLR" }, isUnique: true, isPrimaryKey: true)
    };
}
