using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701741 - .
/// </summary>
public class F0701741 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDAN8.
        /// </summary>
        public const string YDAN8 = "YDAN8";

        /// <summary>
        /// YDDTEY.
        /// </summary>
        public const string YDDTEY = "YDDTEY";

        /// <summary>
        /// YDTAXX.
        /// </summary>
        public const string YDTAXX = "YDTAXX";

        /// <summary>
        /// YDPFRQ.
        /// </summary>
        public const string YDPFRQ = "YDPFRQ";

        /// <summary>
        /// YDPPNB.
        /// </summary>
        public const string YDPPNB = "YDPPNB";

        /// <summary>
        /// YDCKCN.
        /// </summary>
        public const string YDCKCN = "YDCKCN";

        /// <summary>
        /// YDGPA.
        /// </summary>
        public const string YDGPA = "YDGPA";

        /// <summary>
        /// YDG101.
        /// </summary>
        public const string YDG101 = "YDG101";

        /// <summary>
        /// YDCKDT.
        /// </summary>
        public const string YDCKDT = "YDCKDT";

        /// <summary>
        /// YDG201.
        /// </summary>
        public const string YDG201 = "YDG201";

        /// <summary>
        /// YDHMCO.
        /// </summary>
        public const string YDHMCO = "YDHMCO";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDUPMT.
        /// </summary>
        public const string YDUPMT = "YDUPMT";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDJOBN.
        /// </summary>
        public const string YDJOBN = "YDJOBN";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F0701741";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDAN8", "YDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YDDTEY", "YDDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YDTAXX", "YDTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YDPFRQ", "YDPFRQ", JdeDataType.String, 2, true, true),
        new JdeField("YDPPNB", "YDPPNB", JdeDataType.String, 6, true, true),
        new JdeField("YDCKCN", "YDCKCN", JdeDataType.Numeric),
        new JdeField("YDGPA", "YDGPA", JdeDataType.Numeric),
        new JdeField("YDG101", "YDG101", JdeDataType.Numeric),
        new JdeField("YDCKDT", "YDCKDT", JdeDataType.Numeric),
        new JdeField("YDG201", "YDG201", JdeDataType.Numeric),
        new JdeField("YDHMCO", "YDHMCO", JdeDataType.String, 10),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDUPMT", "YDUPMT", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDJOBN", "YDJOBN", JdeDataType.String, 20),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701741_0", "Primary Key on YDAN8, YDDTEY, YDTAXX, YDPFRQ, YDPPNB", new[] { "YDAN8", "YDDTEY", "YDTAXX", "YDPFRQ", "YDPPNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0701741_2", "Index on YDCKCN", new[] { "YDCKCN" })
    };
}
