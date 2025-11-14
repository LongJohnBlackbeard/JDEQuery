using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40072 - .
/// </summary>
public class F40072 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GIITM.
        /// </summary>
        public const string GIITM = "GIITM";

        /// <summary>
        /// GIPRFR.
        /// </summary>
        public const string GIPRFR = "GIPRFR";

        /// <summary>
        /// GIITTP.
        /// </summary>
        public const string GIITTP = "GIITTP";

        /// <summary>
        /// GIURCD.
        /// </summary>
        public const string GIURCD = "GIURCD";

        /// <summary>
        /// GIURDT.
        /// </summary>
        public const string GIURDT = "GIURDT";

        /// <summary>
        /// GIURAT.
        /// </summary>
        public const string GIURAT = "GIURAT";

        /// <summary>
        /// GIURAB.
        /// </summary>
        public const string GIURAB = "GIURAB";

        /// <summary>
        /// GIURRF.
        /// </summary>
        public const string GIURRF = "GIURRF";

        /// <summary>
        /// GIUSER.
        /// </summary>
        public const string GIUSER = "GIUSER";

        /// <summary>
        /// GIPID.
        /// </summary>
        public const string GIPID = "GIPID";

        /// <summary>
        /// GIJOBN.
        /// </summary>
        public const string GIJOBN = "GIJOBN";

        /// <summary>
        /// GIUPMJ.
        /// </summary>
        public const string GIUPMJ = "GIUPMJ";

        /// <summary>
        /// GITDAY.
        /// </summary>
        public const string GITDAY = "GITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40072";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GIITM", "GIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GIPRFR", "GIPRFR", JdeDataType.String, 4, true, true),
        new JdeField("GIITTP", "GIITTP", JdeDataType.String, 16),
        new JdeField("GIURCD", "GIURCD", JdeDataType.String, 4),
        new JdeField("GIURDT", "GIURDT", JdeDataType.Numeric),
        new JdeField("GIURAT", "GIURAT", JdeDataType.Numeric),
        new JdeField("GIURAB", "GIURAB", JdeDataType.Numeric),
        new JdeField("GIURRF", "GIURRF", JdeDataType.String, 30),
        new JdeField("GIUSER", "GIUSER", JdeDataType.String, 20),
        new JdeField("GIPID", "GIPID", JdeDataType.String, 20),
        new JdeField("GIJOBN", "GIJOBN", JdeDataType.String, 20),
        new JdeField("GIUPMJ", "GIUPMJ", JdeDataType.Numeric),
        new JdeField("GITDAY", "GITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40072_0", "Primary Key on GIITM, GIPRFR", new[] { "GIITM", "GIPRFR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40072_2", "Index on GIITM", new[] { "GIITM" })
    };
}
