using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW52 - .
/// </summary>
public class FCW52 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCKIT.
        /// </summary>
        public const string RCKIT = "RCKIT";

        /// <summary>
        /// RCMMCU.
        /// </summary>
        public const string RCMMCU = "RCMMCU";

        /// <summary>
        /// RCTRT.
        /// </summary>
        public const string RCTRT = "RCTRT";

        /// <summary>
        /// RCBQTY.
        /// </summary>
        public const string RCBQTY = "RCBQTY";

        /// <summary>
        /// RCITM.
        /// </summary>
        public const string RCITM = "RCITM";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCTDAY.
        /// </summary>
        public const string RCTDAY = "RCTDAY";

        /// <summary>
        /// RCC9STS.
        /// </summary>
        public const string RCC9STS = "RCC9STS";
    }

    /// <inheritdoc />
    public override string TableName => "FCW52";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCKIT", "RCKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("RCMMCU", "RCMMCU", JdeDataType.String, 24, true, true),
        new JdeField("RCTRT", "RCTRT", JdeDataType.String, 6, true, true),
        new JdeField("RCBQTY", "RCBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("RCITM", "RCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCTDAY", "RCTDAY", JdeDataType.Numeric),
        new JdeField("RCC9STS", "RCC9STS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW52_0", "Primary Key on RCKIT, RCMMCU, RCTRT, RCBQTY, RCITM", new[] { "RCKIT", "RCMMCU", "RCTRT", "RCBQTY", "RCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
