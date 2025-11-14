using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4303M - .
/// </summary>
public class F4303M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMMOLG.
        /// </summary>
        public const string PMMOLG = "PMMOLG";

        /// <summary>
        /// PMLGTY.
        /// </summary>
        public const string PMLGTY = "PMLGTY";

        /// <summary>
        /// PMLGNO.
        /// </summary>
        public const string PMLGNO = "PMLGNO";

        /// <summary>
        /// PMDL01.
        /// </summary>
        public const string PMDL01 = "PMDL01";

        /// <summary>
        /// PMEXR.
        /// </summary>
        public const string PMEXR = "PMEXR";

        /// <summary>
        /// PMISSU.
        /// </summary>
        public const string PMISSU = "PMISSU";

        /// <summary>
        /// PMEXPR.
        /// </summary>
        public const string PMEXPR = "PMEXPR";

        /// <summary>
        /// PMREQR.
        /// </summary>
        public const string PMREQR = "PMREQR";

        /// <summary>
        /// PMSTSC.
        /// </summary>
        public const string PMSTSC = "PMSTSC";

        /// <summary>
        /// PMPAYE.
        /// </summary>
        public const string PMPAYE = "PMPAYE";

        /// <summary>
        /// PMRPT1.
        /// </summary>
        public const string PMRPT1 = "PMRPT1";

        /// <summary>
        /// PMRPT2.
        /// </summary>
        public const string PMRPT2 = "PMRPT2";

        /// <summary>
        /// PMRPT3.
        /// </summary>
        public const string PMRPT3 = "PMRPT3";

        /// <summary>
        /// PMAN8.
        /// </summary>
        public const string PMAN8 = "PMAN8";

        /// <summary>
        /// PMSBCD.
        /// </summary>
        public const string PMSBCD = "PMSBCD";

        /// <summary>
        /// PMU.
        /// </summary>
        public const string PMU = "PMU";

        /// <summary>
        /// PMUM.
        /// </summary>
        public const string PMUM = "PMUM";

        /// <summary>
        /// PMUSD1.
        /// </summary>
        public const string PMUSD1 = "PMUSD1";

        /// <summary>
        /// PMCO.
        /// </summary>
        public const string PMCO = "PMCO";

        /// <summary>
        /// PMMCU.
        /// </summary>
        public const string PMMCU = "PMMCU";

        /// <summary>
        /// PMCONO.
        /// </summary>
        public const string PMCONO = "PMCONO";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMUPMT.
        /// </summary>
        public const string PMUPMT = "PMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4303M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMMOLG", "PMMOLG", JdeDataType.String, 20, true, true),
        new JdeField("PMLGTY", "PMLGTY", JdeDataType.String, 2, true, true),
        new JdeField("PMLGNO", "PMLGNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PMDL01", "PMDL01", JdeDataType.String, 60),
        new JdeField("PMEXR", "PMEXR", JdeDataType.String, 60),
        new JdeField("PMISSU", "PMISSU", JdeDataType.Numeric),
        new JdeField("PMEXPR", "PMEXPR", JdeDataType.Numeric),
        new JdeField("PMREQR", "PMREQR", JdeDataType.Numeric),
        new JdeField("PMSTSC", "PMSTSC", JdeDataType.String, 2),
        new JdeField("PMPAYE", "PMPAYE", JdeDataType.String, 2),
        new JdeField("PMRPT1", "PMRPT1", JdeDataType.String, 6),
        new JdeField("PMRPT2", "PMRPT2", JdeDataType.String, 6),
        new JdeField("PMRPT3", "PMRPT3", JdeDataType.String, 6),
        new JdeField("PMAN8", "PMAN8", JdeDataType.Numeric),
        new JdeField("PMSBCD", "PMSBCD", JdeDataType.String, 2),
        new JdeField("PMU", "PMU", JdeDataType.Numeric),
        new JdeField("PMUM", "PMUM", JdeDataType.String, 4),
        new JdeField("PMUSD1", "PMUSD1", JdeDataType.Numeric),
        new JdeField("PMCO", "PMCO", JdeDataType.String, 10),
        new JdeField("PMMCU", "PMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PMCONO", "PMCONO", JdeDataType.Numeric, null, true, true),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMT", "PMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4303M_0", "Primary Key on PMMOLG, PMLGTY, PMLGNO, PMMCU, PMCONO", new[] { "PMMOLG", "PMLGTY", "PMLGNO", "PMMCU", "PMCONO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4303M_2", "Index on PMMOLG, PMLGTY, SYS_NC00027$, PMMCU, PMCONO", new[] { "PMMOLG", "PMLGTY", "SYS_NC00027$", "PMMCU", "PMCONO" })
    };
}
