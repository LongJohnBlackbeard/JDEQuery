using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D100 - .
/// </summary>
public class F80D100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDDDDAY.
        /// </summary>
        public const string DDDDDAY = "DDDDDAY";

        /// <summary>
        /// DDDDWEEK.
        /// </summary>
        public const string DDDDWEEK = "DDDDWEEK";

        /// <summary>
        /// DDDDMON.
        /// </summary>
        public const string DDDDMON = "DDDDMON";

        /// <summary>
        /// DDDDQTR.
        /// </summary>
        public const string DDDDQTR = "DDDDQTR";

        /// <summary>
        /// DDDDYEAR.
        /// </summary>
        public const string DDDDYEAR = "DDDDYEAR";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDMKEY.
        /// </summary>
        public const string DDMKEY = "DDMKEY";

        /// <summary>
        /// DDUTIME.
        /// </summary>
        public const string DDUTIME = "DDUTIME";

        /// <summary>
        /// DDURCD.
        /// </summary>
        public const string DDURCD = "DDURCD";

        /// <summary>
        /// DDURDT.
        /// </summary>
        public const string DDURDT = "DDURDT";

        /// <summary>
        /// DDURAT.
        /// </summary>
        public const string DDURAT = "DDURAT";

        /// <summary>
        /// DDURAB.
        /// </summary>
        public const string DDURAB = "DDURAB";

        /// <summary>
        /// DDURRF.
        /// </summary>
        public const string DDURRF = "DDURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDDDDAY", "DDDDDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("DDDDWEEK", "DDDDWEEK", JdeDataType.Numeric),
        new JdeField("DDDDMON", "DDDDMON", JdeDataType.String, 12),
        new JdeField("DDDDQTR", "DDDDQTR", JdeDataType.String, 12),
        new JdeField("DDDDYEAR", "DDDDYEAR", JdeDataType.String, 8),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDMKEY", "DDMKEY", JdeDataType.String, 30),
        new JdeField("DDUTIME", "DDUTIME", JdeDataType.Date),
        new JdeField("DDURCD", "DDURCD", JdeDataType.String, 4),
        new JdeField("DDURDT", "DDURDT", JdeDataType.Numeric),
        new JdeField("DDURAT", "DDURAT", JdeDataType.Numeric),
        new JdeField("DDURAB", "DDURAB", JdeDataType.Numeric),
        new JdeField("DDURRF", "DDURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D100_0", "Primary Key on DDDDDAY", new[] { "DDDDDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D100_2", "Index on DDDDYEAR", new[] { "DDDDYEAR" }),
        new JdeIndex("F80D100_3", "Index on DDDDMON", new[] { "DDDDMON" }),
        new JdeIndex("F80D100_4", "Index on DDDDQTR", new[] { "DDDDQTR" }),
        new JdeIndex("F80D100_5", "Index on DDDDWEEK", new[] { "DDDDWEEK" })
    };
}
