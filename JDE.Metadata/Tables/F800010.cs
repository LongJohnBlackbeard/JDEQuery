using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F800010 - .
/// </summary>
public class F800010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDJDATE.
        /// </summary>
        public const string TDJDATE = "TDJDATE";

        /// <summary>
        /// TDYRMNDY.
        /// </summary>
        public const string TDYRMNDY = "TDYRMNDY";

        /// <summary>
        /// TDDAYNMBR.
        /// </summary>
        public const string TDDAYNMBR = "TDDAYNMBR";

        /// <summary>
        /// TDMNTHNMBR.
        /// </summary>
        public const string TDMNTHNMBR = "TDMNTHNMBR";

        /// <summary>
        /// TDCALQTR.
        /// </summary>
        public const string TDCALQTR = "TDCALQTR";

        /// <summary>
        /// TDCQTRNMBR.
        /// </summary>
        public const string TDCQTRNMBR = "TDCQTRNMBR";

        /// <summary>
        /// TDYEARNMBR.
        /// </summary>
        public const string TDYEARNMBR = "TDYEARNMBR";

        /// <summary>
        /// TDWKNMBR.
        /// </summary>
        public const string TDWKNMBR = "TDWKNMBR";

        /// <summary>
        /// TDDAYTEXT.
        /// </summary>
        public const string TDDAYTEXT = "TDDAYTEXT";

        /// <summary>
        /// TDMNTHTEXT.
        /// </summary>
        public const string TDMNTHTEXT = "TDMNTHTEXT";

        /// <summary>
        /// TDLSTDAYMN.
        /// </summary>
        public const string TDLSTDAYMN = "TDLSTDAYMN";

        /// <summary>
        /// TDFISPER.
        /// </summary>
        public const string TDFISPER = "TDFISPER";

        /// <summary>
        /// TDFISQTR.
        /// </summary>
        public const string TDFISQTR = "TDFISQTR";

        /// <summary>
        /// TDFQTRNMBR.
        /// </summary>
        public const string TDFQTRNMBR = "TDFQTRNMBR";

        /// <summary>
        /// TDFISYEAR.
        /// </summary>
        public const string TDFISYEAR = "TDFISYEAR";

        /// <summary>
        /// TDFSPRTEXT.
        /// </summary>
        public const string TDFSPRTEXT = "TDFSPRTEXT";

        /// <summary>
        /// TDLSTDAYFP.
        /// </summary>
        public const string TDLSTDAYFP = "TDLSTDAYFP";
    }

    /// <inheritdoc />
    public override string TableName => "F800010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDJDATE", "TDJDATE", JdeDataType.Numeric, null, true, true),
        new JdeField("TDYRMNDY", "TDYRMNDY", JdeDataType.String, 20),
        new JdeField("TDDAYNMBR", "TDDAYNMBR", JdeDataType.Numeric),
        new JdeField("TDMNTHNMBR", "TDMNTHNMBR", JdeDataType.Numeric),
        new JdeField("TDCALQTR", "TDCALQTR", JdeDataType.String, 20),
        new JdeField("TDCQTRNMBR", "TDCQTRNMBR", JdeDataType.Numeric),
        new JdeField("TDYEARNMBR", "TDYEARNMBR", JdeDataType.Numeric),
        new JdeField("TDWKNMBR", "TDWKNMBR", JdeDataType.Numeric),
        new JdeField("TDDAYTEXT", "TDDAYTEXT", JdeDataType.String, 60),
        new JdeField("TDMNTHTEXT", "TDMNTHTEXT", JdeDataType.String, 60),
        new JdeField("TDLSTDAYMN", "TDLSTDAYMN", JdeDataType.String, 2),
        new JdeField("TDFISPER", "TDFISPER", JdeDataType.Numeric),
        new JdeField("TDFISQTR", "TDFISQTR", JdeDataType.String, 20),
        new JdeField("TDFQTRNMBR", "TDFQTRNMBR", JdeDataType.Numeric),
        new JdeField("TDFISYEAR", "TDFISYEAR", JdeDataType.Numeric),
        new JdeField("TDFSPRTEXT", "TDFSPRTEXT", JdeDataType.String, 60),
        new JdeField("TDLSTDAYFP", "TDLSTDAYFP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F800010_0", "Primary Key on TDJDATE", new[] { "TDJDATE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F800010_2", "Index on TDFISYEAR, TDFISPER, SYS_NC00018$", new[] { "TDFISYEAR", "TDFISPER", "SYS_NC00018$" })
    };
}
