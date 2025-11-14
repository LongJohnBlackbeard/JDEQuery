using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41506 - .
/// </summary>
public class F41506 : JdeTable
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
        /// PMMETN.
        /// </summary>
        public const string PMMETN = "PMMETN";

        /// <summary>
        /// PMMETS.
        /// </summary>
        public const string PMMETS = "PMMETS";

        /// <summary>
        /// PMSER#.
        /// </summary>
        public const string PMSER_ = "PMSER#";

        /// <summary>
        /// PMDL01.
        /// </summary>
        public const string PMDL01 = "PMDL01";

        /// <summary>
        /// PMITM.
        /// </summary>
        public const string PMITM = "PMITM";

        /// <summary>
        /// PMITML.
        /// </summary>
        public const string PMITML = "PMITML";

        /// <summary>
        /// PMMXRD.
        /// </summary>
        public const string PMMXRD = "PMMXRD";

        /// <summary>
        /// PMMTUN.
        /// </summary>
        public const string PMMTUN = "PMMTUN";

        /// <summary>
        /// PMBUM1.
        /// </summary>
        public const string PMBUM1 = "PMBUM1";

        /// <summary>
        /// PMTMCP.
        /// </summary>
        public const string PMTMCP = "PMTMCP";

        /// <summary>
        /// PMPCSI.
        /// </summary>
        public const string PMPCSI = "PMPCSI";

        /// <summary>
        /// PMTTHR.
        /// </summary>
        public const string PMTTHR = "PMTTHR";

        /// <summary>
        /// PMBUM0.
        /// </summary>
        public const string PMBUM0 = "PMBUM0";

        /// <summary>
        /// PMDLCA.
        /// </summary>
        public const string PMDLCA = "PMDLCA";

        /// <summary>
        /// PMNDTE.
        /// </summary>
        public const string PMNDTE = "PMNDTE";

        /// <summary>
        /// PMYN01.
        /// </summary>
        public const string PMYN01 = "PMYN01";

        /// <summary>
        /// PMURDT.
        /// </summary>
        public const string PMURDT = "PMURDT";

        /// <summary>
        /// PMURCD.
        /// </summary>
        public const string PMURCD = "PMURCD";

        /// <summary>
        /// PMURAT.
        /// </summary>
        public const string PMURAT = "PMURAT";

        /// <summary>
        /// PMURAB.
        /// </summary>
        public const string PMURAB = "PMURAB";

        /// <summary>
        /// PMURRF.
        /// </summary>
        public const string PMURRF = "PMURRF";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMTDAY.
        /// </summary>
        public const string PMTDAY = "PMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41506";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMMCU", "PMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PMMETN", "PMMETN", JdeDataType.String, 20, true, true),
        new JdeField("PMMETS", "PMMETS", JdeDataType.String, 2),
        new JdeField("PMSER#", "PMSER#", JdeDataType.String, 48),
        new JdeField("PMDL01", "PMDL01", JdeDataType.String, 60),
        new JdeField("PMITM", "PMITM", JdeDataType.Numeric),
        new JdeField("PMITML", "PMITML", JdeDataType.Numeric),
        new JdeField("PMMXRD", "PMMXRD", JdeDataType.Numeric),
        new JdeField("PMMTUN", "PMMTUN", JdeDataType.Numeric),
        new JdeField("PMBUM1", "PMBUM1", JdeDataType.String, 4),
        new JdeField("PMTMCP", "PMTMCP", JdeDataType.String, 2),
        new JdeField("PMPCSI", "PMPCSI", JdeDataType.String, 2),
        new JdeField("PMTTHR", "PMTTHR", JdeDataType.Numeric),
        new JdeField("PMBUM0", "PMBUM0", JdeDataType.String, 4),
        new JdeField("PMDLCA", "PMDLCA", JdeDataType.Numeric),
        new JdeField("PMNDTE", "PMNDTE", JdeDataType.Numeric),
        new JdeField("PMYN01", "PMYN01", JdeDataType.String, 2),
        new JdeField("PMURDT", "PMURDT", JdeDataType.Numeric),
        new JdeField("PMURCD", "PMURCD", JdeDataType.String, 4),
        new JdeField("PMURAT", "PMURAT", JdeDataType.Numeric),
        new JdeField("PMURAB", "PMURAB", JdeDataType.Numeric),
        new JdeField("PMURRF", "PMURRF", JdeDataType.String, 30),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMTDAY", "PMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41506_0", "Primary Key on PMMCU, PMMETN", new[] { "PMMCU", "PMMETN" }, isUnique: true, isPrimaryKey: true)
    };
}
