using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I051 - .
/// </summary>
public class F75I051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INI75SRCT.
        /// </summary>
        public const string INI75SRCT = "INI75SRCT";

        /// <summary>
        /// INI75O2C.
        /// </summary>
        public const string INI75O2C = "INI75O2C";

        /// <summary>
        /// INI75P2P.
        /// </summary>
        public const string INI75P2P = "INI75P2P";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INUPMJ.
        /// </summary>
        public const string INUPMJ = "INUPMJ";

        /// <summary>
        /// INUPMT.
        /// </summary>
        public const string INUPMT = "INUPMT";

        /// <summary>
        /// INJOBN.
        /// </summary>
        public const string INJOBN = "INJOBN";

        /// <summary>
        /// INURCD.
        /// </summary>
        public const string INURCD = "INURCD";

        /// <summary>
        /// INURDT.
        /// </summary>
        public const string INURDT = "INURDT";

        /// <summary>
        /// INURAT.
        /// </summary>
        public const string INURAT = "INURAT";

        /// <summary>
        /// INURAB.
        /// </summary>
        public const string INURAB = "INURAB";

        /// <summary>
        /// INURRF.
        /// </summary>
        public const string INURRF = "INURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F75I051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INI75SRCT", "INI75SRCT", JdeDataType.String, 12, true, true),
        new JdeField("INI75O2C", "INI75O2C", JdeDataType.String, 2),
        new JdeField("INI75P2P", "INI75P2P", JdeDataType.String, 2),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INUPMJ", "INUPMJ", JdeDataType.Numeric),
        new JdeField("INUPMT", "INUPMT", JdeDataType.Numeric),
        new JdeField("INJOBN", "INJOBN", JdeDataType.String, 20),
        new JdeField("INURCD", "INURCD", JdeDataType.String, 4),
        new JdeField("INURDT", "INURDT", JdeDataType.Numeric),
        new JdeField("INURAT", "INURAT", JdeDataType.Numeric),
        new JdeField("INURAB", "INURAB", JdeDataType.Numeric),
        new JdeField("INURRF", "INURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I051_0", "Primary Key on INI75SRCT", new[] { "INI75SRCT" }, isUnique: true, isPrimaryKey: true)
    };
}
