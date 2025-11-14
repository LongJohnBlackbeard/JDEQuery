using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07992 - .
/// </summary>
public class F07992 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YQSSN.
        /// </summary>
        public const string YQSSN = "YQSSN";

        /// <summary>
        /// YQUKID.
        /// </summary>
        public const string YQUKID = "YQUKID";

        /// <summary>
        /// YQDOCM.
        /// </summary>
        public const string YQDOCM = "YQDOCM";

        /// <summary>
        /// YQPTAX.
        /// </summary>
        public const string YQPTAX = "YQPTAX";

        /// <summary>
        /// YQTARA.
        /// </summary>
        public const string YQTARA = "YQTARA";

        /// <summary>
        /// YQGPA.
        /// </summary>
        public const string YQGPA = "YQGPA";

        /// <summary>
        /// YQPSTF.
        /// </summary>
        public const string YQPSTF = "YQPSTF";

        /// <summary>
        /// YQUPMJ.
        /// </summary>
        public const string YQUPMJ = "YQUPMJ";

        /// <summary>
        /// YQUPMT.
        /// </summary>
        public const string YQUPMT = "YQUPMT";

        /// <summary>
        /// YQPID.
        /// </summary>
        public const string YQPID = "YQPID";

        /// <summary>
        /// YQJOBN.
        /// </summary>
        public const string YQJOBN = "YQJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F07992";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YQSSN", "YQSSN", JdeDataType.String, 40, true, true),
        new JdeField("YQUKID", "YQUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("YQDOCM", "YQDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("YQPTAX", "YQPTAX", JdeDataType.String, 4),
        new JdeField("YQTARA", "YQTARA", JdeDataType.String, 20),
        new JdeField("YQGPA", "YQGPA", JdeDataType.Numeric),
        new JdeField("YQPSTF", "YQPSTF", JdeDataType.String, 2),
        new JdeField("YQUPMJ", "YQUPMJ", JdeDataType.Numeric),
        new JdeField("YQUPMT", "YQUPMT", JdeDataType.Numeric),
        new JdeField("YQPID", "YQPID", JdeDataType.String, 20),
        new JdeField("YQJOBN", "YQJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07992_0", "Primary Key on YQDOCM, YQSSN, YQUKID", new[] { "YQDOCM", "YQSSN", "YQUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
