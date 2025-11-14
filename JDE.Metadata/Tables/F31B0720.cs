using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0720 - .
/// </summary>
public class F31B0720 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMMCU.
        /// </summary>
        public const string PMMCU = "PMMCU";

        /// <summary>
        /// PMPROTONO.
        /// </summary>
        public const string PMPROTONO = "PMPROTONO";

        /// <summary>
        /// PMPROTONM.
        /// </summary>
        public const string PMPROTONM = "PMPROTONM";

        /// <summary>
        /// PMPROTODS.
        /// </summary>
        public const string PMPROTODS = "PMPROTODS";

        /// <summary>
        /// PMPROTOC1.
        /// </summary>
        public const string PMPROTOC1 = "PMPROTOC1";

        /// <summary>
        /// PMPROTOC2.
        /// </summary>
        public const string PMPROTOC2 = "PMPROTOC2";

        /// <summary>
        /// PMPROTOC3.
        /// </summary>
        public const string PMPROTOC3 = "PMPROTOC3";

        /// <summary>
        /// PMPROTON1.
        /// </summary>
        public const string PMPROTON1 = "PMPROTON1";

        /// <summary>
        /// PMPROTON2.
        /// </summary>
        public const string PMPROTON2 = "PMPROTON2";

        /// <summary>
        /// PMPROTON3.
        /// </summary>
        public const string PMPROTON3 = "PMPROTON3";

        /// <summary>
        /// PMPROTOD1.
        /// </summary>
        public const string PMPROTOD1 = "PMPROTOD1";

        /// <summary>
        /// PMPROTOD2.
        /// </summary>
        public const string PMPROTOD2 = "PMPROTOD2";

        /// <summary>
        /// PMPROTOD3.
        /// </summary>
        public const string PMPROTOD3 = "PMPROTOD3";

        /// <summary>
        /// PMURAB.
        /// </summary>
        public const string PMURAB = "PMURAB";

        /// <summary>
        /// PMURAT.
        /// </summary>
        public const string PMURAT = "PMURAT";

        /// <summary>
        /// PMURCD.
        /// </summary>
        public const string PMURCD = "PMURCD";

        /// <summary>
        /// PMURDT.
        /// </summary>
        public const string PMURDT = "PMURDT";

        /// <summary>
        /// PMURRF.
        /// </summary>
        public const string PMURRF = "PMURRF";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMTDAY.
        /// </summary>
        public const string PMTDAY = "PMTDAY";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMWAB.
        /// </summary>
        public const string PMWAB = "PMWAB";

        /// <summary>
        /// PMWCD.
        /// </summary>
        public const string PMWCD = "PMWCD";

        /// <summary>
        /// PMWMDT.
        /// </summary>
        public const string PMWMDT = "PMWMDT";

        /// <summary>
        /// PMWNUM.
        /// </summary>
        public const string PMWNUM = "PMWNUM";

        /// <summary>
        /// PMWRF.
        /// </summary>
        public const string PMWRF = "PMWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0720";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMMCU", "PMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PMPROTONO", "PMPROTONO", JdeDataType.Numeric, null, true, true),
        new JdeField("PMPROTONM", "PMPROTONM", JdeDataType.String, 24),
        new JdeField("PMPROTODS", "PMPROTODS", JdeDataType.String, 60),
        new JdeField("PMPROTOC1", "PMPROTOC1", JdeDataType.String, 20),
        new JdeField("PMPROTOC2", "PMPROTOC2", JdeDataType.String, 20),
        new JdeField("PMPROTOC3", "PMPROTOC3", JdeDataType.String, 20),
        new JdeField("PMPROTON1", "PMPROTON1", JdeDataType.Numeric),
        new JdeField("PMPROTON2", "PMPROTON2", JdeDataType.Numeric),
        new JdeField("PMPROTON3", "PMPROTON3", JdeDataType.Numeric),
        new JdeField("PMPROTOD1", "PMPROTOD1", JdeDataType.Numeric),
        new JdeField("PMPROTOD2", "PMPROTOD2", JdeDataType.Numeric),
        new JdeField("PMPROTOD3", "PMPROTOD3", JdeDataType.Numeric),
        new JdeField("PMURAB", "PMURAB", JdeDataType.Numeric),
        new JdeField("PMURAT", "PMURAT", JdeDataType.Numeric),
        new JdeField("PMURCD", "PMURCD", JdeDataType.String, 4),
        new JdeField("PMURDT", "PMURDT", JdeDataType.Numeric),
        new JdeField("PMURRF", "PMURRF", JdeDataType.String, 30),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMTDAY", "PMTDAY", JdeDataType.Numeric),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMWAB", "PMWAB", JdeDataType.Numeric),
        new JdeField("PMWCD", "PMWCD", JdeDataType.String, 6),
        new JdeField("PMWMDT", "PMWMDT", JdeDataType.Numeric),
        new JdeField("PMWNUM", "PMWNUM", JdeDataType.Numeric),
        new JdeField("PMWRF", "PMWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0720_0", "Primary Key on PMMCU, PMPROTONO", new[] { "PMMCU", "PMPROTONO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0720_3", "Index on PMPROTONM, PMMCU, PMPROTONO", new[] { "PMPROTONM", "PMMCU", "PMPROTONO" })
    };
}
