using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46822 - .
/// </summary>
public class F46822 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RQMCU.
        /// </summary>
        public const string RQMCU = "RQMCU";

        /// <summary>
        /// RQSRUL.
        /// </summary>
        public const string RQSRUL = "RQSRUL";

        /// <summary>
        /// RQDEFI.
        /// </summary>
        public const string RQDEFI = "RQDEFI";

        /// <summary>
        /// RQMATP.
        /// </summary>
        public const string RQMATP = "RQMATP";

        /// <summary>
        /// RQPUTR.
        /// </summary>
        public const string RQPUTR = "RQPUTR";

        /// <summary>
        /// RQRQOP.
        /// </summary>
        public const string RQRQOP = "RQRQOP";

        /// <summary>
        /// RQICHG.
        /// </summary>
        public const string RQICHG = "RQICHG";

        /// <summary>
        /// RQIITR.
        /// </summary>
        public const string RQIITR = "RQIITR";

        /// <summary>
        /// RQUSER.
        /// </summary>
        public const string RQUSER = "RQUSER";

        /// <summary>
        /// RQUPMJ.
        /// </summary>
        public const string RQUPMJ = "RQUPMJ";

        /// <summary>
        /// RQTDAY.
        /// </summary>
        public const string RQTDAY = "RQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46822";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RQMCU", "RQMCU", JdeDataType.String, 24, true, true),
        new JdeField("RQSRUL", "RQSRUL", JdeDataType.String, 12, true, true),
        new JdeField("RQDEFI", "RQDEFI", JdeDataType.String, 20, true, true),
        new JdeField("RQMATP", "RQMATP", JdeDataType.Numeric),
        new JdeField("RQPUTR", "RQPUTR", JdeDataType.String, 4),
        new JdeField("RQRQOP", "RQRQOP", JdeDataType.String, 2),
        new JdeField("RQICHG", "RQICHG", JdeDataType.String, 2),
        new JdeField("RQIITR", "RQIITR", JdeDataType.String, 2),
        new JdeField("RQUSER", "RQUSER", JdeDataType.String, 20),
        new JdeField("RQUPMJ", "RQUPMJ", JdeDataType.Numeric),
        new JdeField("RQTDAY", "RQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46822_0", "Primary Key on RQMCU, RQSRUL, RQDEFI", new[] { "RQMCU", "RQSRUL", "RQDEFI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46822_2", "Index on RQMCU, RQSRUL, RQMATP, RQDEFI", new[] { "RQMCU", "RQSRUL", "RQMATP", "RQDEFI" }),
        new JdeIndex("F46822_3", "Index on RQMCU, RQICHG, RQSRUL, RQDEFI", new[] { "RQMCU", "RQICHG", "RQSRUL", "RQDEFI" })
    };
}
