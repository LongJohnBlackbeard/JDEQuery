using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B82 - .
/// </summary>
public class F31B82 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VEWCFGID.
        /// </summary>
        public const string VEWCFGID = "VEWCFGID";

        /// <summary>
        /// VELNID.
        /// </summary>
        public const string VELNID = "VELNID";

        /// <summary>
        /// VEEQPTYP.
        /// </summary>
        public const string VEEQPTYP = "VEEQPTYP";

        /// <summary>
        /// VEURCD.
        /// </summary>
        public const string VEURCD = "VEURCD";

        /// <summary>
        /// VEURDT.
        /// </summary>
        public const string VEURDT = "VEURDT";

        /// <summary>
        /// VEURAT.
        /// </summary>
        public const string VEURAT = "VEURAT";

        /// <summary>
        /// VEURAB.
        /// </summary>
        public const string VEURAB = "VEURAB";

        /// <summary>
        /// VEURRF.
        /// </summary>
        public const string VEURRF = "VEURRF";

        /// <summary>
        /// VEUSER.
        /// </summary>
        public const string VEUSER = "VEUSER";

        /// <summary>
        /// VEPID.
        /// </summary>
        public const string VEPID = "VEPID";

        /// <summary>
        /// VEJOBN.
        /// </summary>
        public const string VEJOBN = "VEJOBN";

        /// <summary>
        /// VEUPMJ.
        /// </summary>
        public const string VEUPMJ = "VEUPMJ";

        /// <summary>
        /// VETDAY.
        /// </summary>
        public const string VETDAY = "VETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B82";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VEWCFGID", "VEWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("VELNID", "VELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VEEQPTYP", "VEEQPTYP", JdeDataType.String, 60),
        new JdeField("VEURCD", "VEURCD", JdeDataType.String, 4),
        new JdeField("VEURDT", "VEURDT", JdeDataType.Numeric),
        new JdeField("VEURAT", "VEURAT", JdeDataType.Numeric),
        new JdeField("VEURAB", "VEURAB", JdeDataType.Numeric),
        new JdeField("VEURRF", "VEURRF", JdeDataType.String, 30),
        new JdeField("VEUSER", "VEUSER", JdeDataType.String, 20),
        new JdeField("VEPID", "VEPID", JdeDataType.String, 20),
        new JdeField("VEJOBN", "VEJOBN", JdeDataType.String, 20),
        new JdeField("VEUPMJ", "VEUPMJ", JdeDataType.Numeric),
        new JdeField("VETDAY", "VETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B82_0", "Primary Key on VEWCFGID, VELNID", new[] { "VEWCFGID", "VELNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B82_2", "Index on VEWCFGID, VEEQPTYP", new[] { "VEWCFGID", "VEEQPTYP" })
    };
}
