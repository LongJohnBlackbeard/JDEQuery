using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I013 - .
/// </summary>
public class F42I013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GROIPR.
        /// </summary>
        public const string GROIPR = "GROIPR";

        /// <summary>
        /// GRMCU.
        /// </summary>
        public const string GRMCU = "GRMCU";

        /// <summary>
        /// GRITM.
        /// </summary>
        public const string GRITM = "GRITM";

        /// <summary>
        /// GRLITM.
        /// </summary>
        public const string GRLITM = "GRLITM";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRTDAY.
        /// </summary>
        public const string GRTDAY = "GRTDAY";

        /// <summary>
        /// GRFUCHAR37.
        /// </summary>
        public const string GRFUCHAR37 = "GRFUCHAR37";

        /// <summary>
        /// GRFUCHAR38.
        /// </summary>
        public const string GRFUCHAR38 = "GRFUCHAR38";

        /// <summary>
        /// GRFUCHAR39.
        /// </summary>
        public const string GRFUCHAR39 = "GRFUCHAR39";

        /// <summary>
        /// GRFUNUM37.
        /// </summary>
        public const string GRFUNUM37 = "GRFUNUM37";

        /// <summary>
        /// GRFUNUM38.
        /// </summary>
        public const string GRFUNUM38 = "GRFUNUM38";

        /// <summary>
        /// GRFUNUM39.
        /// </summary>
        public const string GRFUNUM39 = "GRFUNUM39";

        /// <summary>
        /// GRFUTSTR37.
        /// </summary>
        public const string GRFUTSTR37 = "GRFUTSTR37";

        /// <summary>
        /// GRFUTSTR38.
        /// </summary>
        public const string GRFUTSTR38 = "GRFUTSTR38";

        /// <summary>
        /// GRFUTSTR39.
        /// </summary>
        public const string GRFUTSTR39 = "GRFUTSTR39";

        /// <summary>
        /// GRFUDT38.
        /// </summary>
        public const string GRFUDT38 = "GRFUDT38";

        /// <summary>
        /// GRFUDT39.
        /// </summary>
        public const string GRFUDT39 = "GRFUDT39";

        /// <summary>
        /// GRFUDT43.
        /// </summary>
        public const string GRFUDT43 = "GRFUDT43";

        /// <summary>
        /// GRURAT.
        /// </summary>
        public const string GRURAT = "GRURAT";

        /// <summary>
        /// GRURCD.
        /// </summary>
        public const string GRURCD = "GRURCD";

        /// <summary>
        /// GRURDT.
        /// </summary>
        public const string GRURDT = "GRURDT";

        /// <summary>
        /// GRURAB.
        /// </summary>
        public const string GRURAB = "GRURAB";

        /// <summary>
        /// GRURRF.
        /// </summary>
        public const string GRURRF = "GRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GROIPR", "GROIPR", JdeDataType.String, 16, true, true),
        new JdeField("GRMCU", "GRMCU", JdeDataType.String, 24, true, true),
        new JdeField("GRITM", "GRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GRLITM", "GRLITM", JdeDataType.String, 50),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRTDAY", "GRTDAY", JdeDataType.Numeric),
        new JdeField("GRFUCHAR37", "GRFUCHAR37", JdeDataType.String, 2),
        new JdeField("GRFUCHAR38", "GRFUCHAR38", JdeDataType.String, 2),
        new JdeField("GRFUCHAR39", "GRFUCHAR39", JdeDataType.String, 2),
        new JdeField("GRFUNUM37", "GRFUNUM37", JdeDataType.Numeric),
        new JdeField("GRFUNUM38", "GRFUNUM38", JdeDataType.Numeric),
        new JdeField("GRFUNUM39", "GRFUNUM39", JdeDataType.Numeric),
        new JdeField("GRFUTSTR37", "GRFUTSTR37", JdeDataType.String, 100),
        new JdeField("GRFUTSTR38", "GRFUTSTR38", JdeDataType.String, 100),
        new JdeField("GRFUTSTR39", "GRFUTSTR39", JdeDataType.String, 100),
        new JdeField("GRFUDT38", "GRFUDT38", JdeDataType.Numeric),
        new JdeField("GRFUDT39", "GRFUDT39", JdeDataType.Numeric),
        new JdeField("GRFUDT43", "GRFUDT43", JdeDataType.Numeric),
        new JdeField("GRURAT", "GRURAT", JdeDataType.Numeric),
        new JdeField("GRURCD", "GRURCD", JdeDataType.String, 4),
        new JdeField("GRURDT", "GRURDT", JdeDataType.Numeric),
        new JdeField("GRURAB", "GRURAB", JdeDataType.Numeric),
        new JdeField("GRURRF", "GRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I013_0", "Primary Key on GRMCU, GROIPR, GRITM", new[] { "GRMCU", "GROIPR", "GRITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I013_3", "Index on GRMCU, GROIPR", new[] { "GRMCU", "GROIPR" })
    };
}
