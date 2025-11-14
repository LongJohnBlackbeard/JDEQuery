using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B76 - .
/// </summary>
public class F31B76 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VWWCFGID.
        /// </summary>
        public const string VWWCFGID = "VWWCFGID";

        /// <summary>
        /// VWLNID.
        /// </summary>
        public const string VWLNID = "VWLNID";

        /// <summary>
        /// VWWID.
        /// </summary>
        public const string VWWID = "VWWID";

        /// <summary>
        /// VWMCU.
        /// </summary>
        public const string VWMCU = "VWMCU";

        /// <summary>
        /// VWURCD.
        /// </summary>
        public const string VWURCD = "VWURCD";

        /// <summary>
        /// VWURDT.
        /// </summary>
        public const string VWURDT = "VWURDT";

        /// <summary>
        /// VWURAT.
        /// </summary>
        public const string VWURAT = "VWURAT";

        /// <summary>
        /// VWURAB.
        /// </summary>
        public const string VWURAB = "VWURAB";

        /// <summary>
        /// VWURRF.
        /// </summary>
        public const string VWURRF = "VWURRF";

        /// <summary>
        /// VWUSER.
        /// </summary>
        public const string VWUSER = "VWUSER";

        /// <summary>
        /// VWPID.
        /// </summary>
        public const string VWPID = "VWPID";

        /// <summary>
        /// VWJOBN.
        /// </summary>
        public const string VWJOBN = "VWJOBN";

        /// <summary>
        /// VWUPMJ.
        /// </summary>
        public const string VWUPMJ = "VWUPMJ";

        /// <summary>
        /// VWTDAY.
        /// </summary>
        public const string VWTDAY = "VWTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B76";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VWWCFGID", "VWWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("VWLNID", "VWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VWWID", "VWWID", JdeDataType.String, 24),
        new JdeField("VWMCU", "VWMCU", JdeDataType.String, 24),
        new JdeField("VWURCD", "VWURCD", JdeDataType.String, 4),
        new JdeField("VWURDT", "VWURDT", JdeDataType.Numeric),
        new JdeField("VWURAT", "VWURAT", JdeDataType.Numeric),
        new JdeField("VWURAB", "VWURAB", JdeDataType.Numeric),
        new JdeField("VWURRF", "VWURRF", JdeDataType.String, 30),
        new JdeField("VWUSER", "VWUSER", JdeDataType.String, 20),
        new JdeField("VWPID", "VWPID", JdeDataType.String, 20),
        new JdeField("VWJOBN", "VWJOBN", JdeDataType.String, 20),
        new JdeField("VWUPMJ", "VWUPMJ", JdeDataType.Numeric),
        new JdeField("VWTDAY", "VWTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B76_0", "Primary Key on VWWCFGID, VWLNID", new[] { "VWWCFGID", "VWLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B76_2", "Index on VWWCFGID, VWWID, VWMCU", new[] { "VWWCFGID", "VWWID", "VWMCU" })
    };
}
