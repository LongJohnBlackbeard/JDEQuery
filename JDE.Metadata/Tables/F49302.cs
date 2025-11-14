using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49302 - .
/// </summary>
public class F49302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VEVEHI.
        /// </summary>
        public const string VEVEHI = "VEVEHI";

        /// <summary>
        /// VEVTYP.
        /// </summary>
        public const string VEVTYP = "VEVTYP";

        /// <summary>
        /// VEOPEQ.
        /// </summary>
        public const string VEOPEQ = "VEOPEQ";

        /// <summary>
        /// VEEFTJ.
        /// </summary>
        public const string VEEFTJ = "VEEFTJ";

        /// <summary>
        /// VEEXDJ.
        /// </summary>
        public const string VEEXDJ = "VEEXDJ";

        /// <summary>
        /// VEUNTN.
        /// </summary>
        public const string VEUNTN = "VEUNTN";

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
    public override string TableName => "F49302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VEVEHI", "VEVEHI", JdeDataType.String, 24, true, true),
        new JdeField("VEVTYP", "VEVTYP", JdeDataType.String, 24, true, true),
        new JdeField("VEOPEQ", "VEOPEQ", JdeDataType.String, 20, true, true),
        new JdeField("VEEFTJ", "VEEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VEEXDJ", "VEEXDJ", JdeDataType.Numeric),
        new JdeField("VEUNTN", "VEUNTN", JdeDataType.Numeric),
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
        new JdeIndex("F49302_0", "Primary Key on VEVEHI, VEVTYP, VEOPEQ, VEEFTJ", new[] { "VEVEHI", "VEVTYP", "VEOPEQ", "VEEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49302_2", "Index on VEVEHI, VEVTYP, VEEFTJ, VEOPEQ", new[] { "VEVEHI", "VEVTYP", "VEEFTJ", "VEOPEQ" })
    };
}
