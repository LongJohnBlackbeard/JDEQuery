using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701740 - .
/// </summary>
public class F0701740 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YQAN8.
        /// </summary>
        public const string YQAN8 = "YQAN8";

        /// <summary>
        /// YQDTEY.
        /// </summary>
        public const string YQDTEY = "YQDTEY";

        /// <summary>
        /// YQTAXX.
        /// </summary>
        public const string YQTAXX = "YQTAXX";

        /// <summary>
        /// YQPFRQ.
        /// </summary>
        public const string YQPFRQ = "YQPFRQ";

        /// <summary>
        /// YQPPNB.
        /// </summary>
        public const string YQPPNB = "YQPPNB";

        /// <summary>
        /// YQCKCN.
        /// </summary>
        public const string YQCKCN = "YQCKCN";

        /// <summary>
        /// YQGPA.
        /// </summary>
        public const string YQGPA = "YQGPA";

        /// <summary>
        /// YQG101.
        /// </summary>
        public const string YQG101 = "YQG101";

        /// <summary>
        /// YQCKDT.
        /// </summary>
        public const string YQCKDT = "YQCKDT";

        /// <summary>
        /// YQG201.
        /// </summary>
        public const string YQG201 = "YQG201";

        /// <summary>
        /// YQHMCO.
        /// </summary>
        public const string YQHMCO = "YQHMCO";

        /// <summary>
        /// YQUPMJ.
        /// </summary>
        public const string YQUPMJ = "YQUPMJ";

        /// <summary>
        /// YQUPMT.
        /// </summary>
        public const string YQUPMT = "YQUPMT";

        /// <summary>
        /// YQUSER.
        /// </summary>
        public const string YQUSER = "YQUSER";

        /// <summary>
        /// YQJOBN.
        /// </summary>
        public const string YQJOBN = "YQJOBN";

        /// <summary>
        /// YQPID.
        /// </summary>
        public const string YQPID = "YQPID";
    }

    /// <inheritdoc />
    public override string TableName => "F0701740";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YQAN8", "YQAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YQDTEY", "YQDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YQTAXX", "YQTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YQPFRQ", "YQPFRQ", JdeDataType.String, 2, true, true),
        new JdeField("YQPPNB", "YQPPNB", JdeDataType.String, 6, true, true),
        new JdeField("YQCKCN", "YQCKCN", JdeDataType.Numeric),
        new JdeField("YQGPA", "YQGPA", JdeDataType.Numeric),
        new JdeField("YQG101", "YQG101", JdeDataType.Numeric),
        new JdeField("YQCKDT", "YQCKDT", JdeDataType.Numeric),
        new JdeField("YQG201", "YQG201", JdeDataType.Numeric),
        new JdeField("YQHMCO", "YQHMCO", JdeDataType.String, 10),
        new JdeField("YQUPMJ", "YQUPMJ", JdeDataType.Numeric),
        new JdeField("YQUPMT", "YQUPMT", JdeDataType.Numeric),
        new JdeField("YQUSER", "YQUSER", JdeDataType.String, 20),
        new JdeField("YQJOBN", "YQJOBN", JdeDataType.String, 20),
        new JdeField("YQPID", "YQPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701740_0", "Primary Key on YQAN8, YQDTEY, YQTAXX, YQPFRQ, YQPPNB", new[] { "YQAN8", "YQDTEY", "YQTAXX", "YQPFRQ", "YQPPNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0701740_2", "Index on YQCKCN", new[] { "YQCKCN" })
    };
}
