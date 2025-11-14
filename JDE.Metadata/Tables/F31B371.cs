using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B371 - .
/// </summary>
public class F31B371 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRUKID.
        /// </summary>
        public const string GRUKID = "GRUKID";

        /// <summary>
        /// GRPGOAID.
        /// </summary>
        public const string GRPGOAID = "GRPGOAID";

        /// <summary>
        /// GRPGOAREA.
        /// </summary>
        public const string GRPGOAREA = "GRPGOAREA";

        /// <summary>
        /// GRCGOAID.
        /// </summary>
        public const string GRCGOAID = "GRCGOAID";

        /// <summary>
        /// GRCGOAREA.
        /// </summary>
        public const string GRCGOAREA = "GRCGOAREA";

        /// <summary>
        /// GRURCD.
        /// </summary>
        public const string GRURCD = "GRURCD";

        /// <summary>
        /// GRURDT.
        /// </summary>
        public const string GRURDT = "GRURDT";

        /// <summary>
        /// GRURAT.
        /// </summary>
        public const string GRURAT = "GRURAT";

        /// <summary>
        /// GRURRF.
        /// </summary>
        public const string GRURRF = "GRURRF";

        /// <summary>
        /// GRURAB.
        /// </summary>
        public const string GRURAB = "GRURAB";

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
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B371";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRUKID", "GRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GRPGOAID", "GRPGOAID", JdeDataType.Numeric),
        new JdeField("GRPGOAREA", "GRPGOAREA", JdeDataType.String, 8),
        new JdeField("GRCGOAID", "GRCGOAID", JdeDataType.Numeric),
        new JdeField("GRCGOAREA", "GRCGOAREA", JdeDataType.String, 8),
        new JdeField("GRURCD", "GRURCD", JdeDataType.String, 4),
        new JdeField("GRURDT", "GRURDT", JdeDataType.Numeric),
        new JdeField("GRURAT", "GRURAT", JdeDataType.Numeric),
        new JdeField("GRURRF", "GRURRF", JdeDataType.String, 30),
        new JdeField("GRURAB", "GRURAB", JdeDataType.Numeric),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B371_0", "Primary Key on GRUKID", new[] { "GRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B371_2", "Index on GRPGOAID, GRCGOAID", new[] { "GRPGOAID", "GRCGOAID" }),
        new JdeIndex("F31B371_3", "Index on GRPGOAREA, GRCGOAREA", new[] { "GRPGOAREA", "GRCGOAREA" }),
        new JdeIndex("F31B371_4", "Index on GRPGOAREA", new[] { "GRPGOAREA" }),
        new JdeIndex("F31B371_5", "Index on GRCGOAREA", new[] { "GRCGOAREA" }),
        new JdeIndex("F31B371_6", "Index on GRCGOAID", new[] { "GRCGOAID" })
    };
}
