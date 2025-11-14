using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06147 - .
/// </summary>
public class F06147 : JdeTable
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
        /// YDPDBA.
        /// </summary>
        public const string YDPDBA = "YDPDBA";

        /// <summary>
        /// YDDTE.
        /// </summary>
        public const string YDDTE = "YDDTE";

        /// <summary>
        /// YDTAXX.
        /// </summary>
        public const string YDTAXX = "YDTAXX";

        /// <summary>
        /// YDHMCO.
        /// </summary>
        public const string YDHMCO = "YDHMCO";

        /// <summary>
        /// YDBWPY.
        /// </summary>
        public const string YDBWPY = "YDBWPY";

        /// <summary>
        /// YDBWBB.
        /// </summary>
        public const string YDBWBB = "YDBWBB";

        /// <summary>
        /// YDFY$.
        /// </summary>
        public const string YDFY_ = "YDFY$";

        /// <summary>
        /// YDBHPY.
        /// </summary>
        public const string YDBHPY = "YDBHPY";

        /// <summary>
        /// YDBHBB.
        /// </summary>
        public const string YDBHBB = "YDBHBB";

        /// <summary>
        /// YDFYH.
        /// </summary>
        public const string YDFYH = "YDFYH";

        /// <summary>
        /// YDBIPY.
        /// </summary>
        public const string YDBIPY = "YDBIPY";

        /// <summary>
        /// YDBIBB.
        /// </summary>
        public const string YDBIBB = "YDBIBB";

        /// <summary>
        /// YDFYP.
        /// </summary>
        public const string YDFYP = "YDFYP";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F06147";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDAN8", "YDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YDPDBA", "YDPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YDDTE", "YDDTE", JdeDataType.Numeric, null, true, true),
        new JdeField("YDTAXX", "YDTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YDHMCO", "YDHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YDBWPY", "YDBWPY", JdeDataType.Numeric),
        new JdeField("YDBWBB", "YDBWBB", JdeDataType.Numeric),
        new JdeField("YDFY$", "YDFY$", JdeDataType.Numeric),
        new JdeField("YDBHPY", "YDBHPY", JdeDataType.Numeric),
        new JdeField("YDBHBB", "YDBHBB", JdeDataType.Numeric),
        new JdeField("YDFYH", "YDFYH", JdeDataType.Numeric),
        new JdeField("YDBIPY", "YDBIPY", JdeDataType.Numeric),
        new JdeField("YDBIBB", "YDBIBB", JdeDataType.Numeric),
        new JdeField("YDFYP", "YDFYP", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06147_0", "Primary Key on YDAN8, YDPDBA, YDDTE, YDTAXX, YDHMCO", new[] { "YDAN8", "YDPDBA", "YDDTE", "YDTAXX", "YDHMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06147_2", "Index on YDAN8, YDDTE, YDPDBA", new[] { "YDAN8", "YDDTE", "YDPDBA" }),
        new JdeIndex("F06147_3", "Index on YDAN8, YDPDBA, SYS_NC00018$", new[] { "YDAN8", "YDPDBA", "SYS_NC00018$" })
    };
}
