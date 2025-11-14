using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186202 - .
/// </summary>
public class F186202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LGLRSEGID.
        /// </summary>
        public const string LGLRSEGID = "LGLRSEGID";

        /// <summary>
        /// LGAN8.
        /// </summary>
        public const string LGAN8 = "LGAN8";

        /// <summary>
        /// LGBEFD.
        /// </summary>
        public const string LGBEFD = "LGBEFD";

        /// <summary>
        /// LGEEFD.
        /// </summary>
        public const string LGEEFD = "LGEEFD";

        /// <summary>
        /// LGUSER.
        /// </summary>
        public const string LGUSER = "LGUSER";

        /// <summary>
        /// LGPID.
        /// </summary>
        public const string LGPID = "LGPID";

        /// <summary>
        /// LGJOBN.
        /// </summary>
        public const string LGJOBN = "LGJOBN";

        /// <summary>
        /// LGUPMJ.
        /// </summary>
        public const string LGUPMJ = "LGUPMJ";

        /// <summary>
        /// LGTDAY.
        /// </summary>
        public const string LGTDAY = "LGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LGLRSEGID", "LGLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("LGAN8", "LGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LGBEFD", "LGBEFD", JdeDataType.Numeric),
        new JdeField("LGEEFD", "LGEEFD", JdeDataType.Numeric),
        new JdeField("LGUSER", "LGUSER", JdeDataType.String, 20),
        new JdeField("LGPID", "LGPID", JdeDataType.String, 20),
        new JdeField("LGJOBN", "LGJOBN", JdeDataType.String, 20),
        new JdeField("LGUPMJ", "LGUPMJ", JdeDataType.Numeric),
        new JdeField("LGTDAY", "LGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186202_0", "Primary Key on LGLRSEGID, LGAN8", new[] { "LGLRSEGID", "LGAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186202_2", "Index on LGLRSEGID", new[] { "LGLRSEGID" })
    };
}
