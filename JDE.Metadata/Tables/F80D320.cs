using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D320 - .
/// </summary>
public class F80D320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCCFID.
        /// </summary>
        public const string DCCFID = "DCCFID";

        /// <summary>
        /// DCDBC.
        /// </summary>
        public const string DCDBC = "DCDBC";

        /// <summary>
        /// DCSUBSCR.
        /// </summary>
        public const string DCSUBSCR = "DCSUBSCR";

        /// <summary>
        /// DCURCD.
        /// </summary>
        public const string DCURCD = "DCURCD";

        /// <summary>
        /// DCURDT.
        /// </summary>
        public const string DCURDT = "DCURDT";

        /// <summary>
        /// DCURAT.
        /// </summary>
        public const string DCURAT = "DCURAT";

        /// <summary>
        /// DCURAB.
        /// </summary>
        public const string DCURAB = "DCURAB";

        /// <summary>
        /// DCURRF.
        /// </summary>
        public const string DCURRF = "DCURRF";

        /// <summary>
        /// DCUSER.
        /// </summary>
        public const string DCUSER = "DCUSER";

        /// <summary>
        /// DCMKEY.
        /// </summary>
        public const string DCMKEY = "DCMKEY";

        /// <summary>
        /// DCPID.
        /// </summary>
        public const string DCPID = "DCPID";

        /// <summary>
        /// DCUUPMJ.
        /// </summary>
        public const string DCUUPMJ = "DCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCCFID", "DCCFID", JdeDataType.String, 20, true, true),
        new JdeField("DCDBC", "DCDBC", JdeDataType.String, 12),
        new JdeField("DCSUBSCR", "DCSUBSCR", JdeDataType.Numeric),
        new JdeField("DCURCD", "DCURCD", JdeDataType.String, 4),
        new JdeField("DCURDT", "DCURDT", JdeDataType.Numeric),
        new JdeField("DCURAT", "DCURAT", JdeDataType.Numeric),
        new JdeField("DCURAB", "DCURAB", JdeDataType.Numeric),
        new JdeField("DCURRF", "DCURRF", JdeDataType.String, 30),
        new JdeField("DCUSER", "DCUSER", JdeDataType.String, 20),
        new JdeField("DCMKEY", "DCMKEY", JdeDataType.String, 30),
        new JdeField("DCPID", "DCPID", JdeDataType.String, 20),
        new JdeField("DCUUPMJ", "DCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D320_0", "Primary Key on DCCFID", new[] { "DCCFID" }, isUnique: true, isPrimaryKey: true)
    };
}
