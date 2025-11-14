using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4207 - .
/// </summary>
public class F4207 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMPCTY.
        /// </summary>
        public const string PMPCTY = "PMPCTY";

        /// <summary>
        /// PMPRTY.
        /// </summary>
        public const string PMPRTY = "PMPRTY";

        /// <summary>
        /// PMMCAT.
        /// </summary>
        public const string PMMCAT = "PMMCAT";

        /// <summary>
        /// PMDESC.
        /// </summary>
        public const string PMDESC = "PMDESC";

        /// <summary>
        /// PMCLV.
        /// </summary>
        public const string PMCLV = "PMCLV";

        /// <summary>
        /// PMCXPJ.
        /// </summary>
        public const string PMCXPJ = "PMCXPJ";

        /// <summary>
        /// PMCEFJ.
        /// </summary>
        public const string PMCEFJ = "PMCEFJ";

        /// <summary>
        /// PMOVLP.
        /// </summary>
        public const string PMOVLP = "PMOVLP";

        /// <summary>
        /// PMOVQT.
        /// </summary>
        public const string PMOVQT = "PMOVQT";

        /// <summary>
        /// PMUMC.
        /// </summary>
        public const string PMUMC = "PMUMC";

        /// <summary>
        /// PMCBAS.
        /// </summary>
        public const string PMCBAS = "PMCBAS";

        /// <summary>
        /// PMFVN.
        /// </summary>
        public const string PMFVN = "PMFVN";

        /// <summary>
        /// PMFVA.
        /// </summary>
        public const string PMFVA = "PMFVA";

        /// <summary>
        /// PMFVTY.
        /// </summary>
        public const string PMFVTY = "PMFVTY";

        /// <summary>
        /// PMRPLO.
        /// </summary>
        public const string PMRPLO = "PMRPLO";

        /// <summary>
        /// PMLNTY.
        /// </summary>
        public const string PMLNTY = "PMLNTY";

        /// <summary>
        /// PMITMR.
        /// </summary>
        public const string PMITMR = "PMITMR";

        /// <summary>
        /// PMRPRI.
        /// </summary>
        public const string PMRPRI = "PMRPRI";

        /// <summary>
        /// PMLIM.
        /// </summary>
        public const string PMLIM = "PMLIM";

        /// <summary>
        /// PMQTYT.
        /// </summary>
        public const string PMQTYT = "PMQTYT";

        /// <summary>
        /// PMLINV.
        /// </summary>
        public const string PMLINV = "PMLINV";

        /// <summary>
        /// PMDLIJ.
        /// </summary>
        public const string PMDLIJ = "PMDLIJ";

        /// <summary>
        /// PMCTTL.
        /// </summary>
        public const string PMCTTL = "PMCTTL";

        /// <summary>
        /// PMPNCD.
        /// </summary>
        public const string PMPNCD = "PMPNCD";

        /// <summary>
        /// PMLOTN.
        /// </summary>
        public const string PMLOTN = "PMLOTN";

        /// <summary>
        /// PMPCN.
        /// </summary>
        public const string PMPCN = "PMPCN";

        /// <summary>
        /// PMTYDS.
        /// </summary>
        public const string PMTYDS = "PMTYDS";

        /// <summary>
        /// PMCQTO.
        /// </summary>
        public const string PMCQTO = "PMCQTO";

        /// <summary>
        /// PMCRCD.
        /// </summary>
        public const string PMCRCD = "PMCRCD";

        /// <summary>
        /// PMCRR.
        /// </summary>
        public const string PMCRR = "PMCRR";

        /// <summary>
        /// PMCRRM.
        /// </summary>
        public const string PMCRRM = "PMCRRM";

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
    public override string TableName => "F4207";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMPCTY", "PMPCTY", JdeDataType.String, 2, true, true),
        new JdeField("PMPRTY", "PMPRTY", JdeDataType.String, 2),
        new JdeField("PMMCAT", "PMMCAT", JdeDataType.String, 16, true, true),
        new JdeField("PMDESC", "PMDESC", JdeDataType.String, 60),
        new JdeField("PMCLV", "PMCLV", JdeDataType.String, 6, true, true),
        new JdeField("PMCXPJ", "PMCXPJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PMCEFJ", "PMCEFJ", JdeDataType.Numeric),
        new JdeField("PMOVLP", "PMOVLP", JdeDataType.Numeric),
        new JdeField("PMOVQT", "PMOVQT", JdeDataType.Numeric),
        new JdeField("PMUMC", "PMUMC", JdeDataType.String, 2),
        new JdeField("PMCBAS", "PMCBAS", JdeDataType.String, 2),
        new JdeField("PMFVN", "PMFVN", JdeDataType.Numeric),
        new JdeField("PMFVA", "PMFVA", JdeDataType.String, 16),
        new JdeField("PMFVTY", "PMFVTY", JdeDataType.String, 2),
        new JdeField("PMRPLO", "PMRPLO", JdeDataType.String, 2),
        new JdeField("PMLNTY", "PMLNTY", JdeDataType.String, 4),
        new JdeField("PMITMR", "PMITMR", JdeDataType.Numeric),
        new JdeField("PMRPRI", "PMRPRI", JdeDataType.Numeric),
        new JdeField("PMLIM", "PMLIM", JdeDataType.Numeric),
        new JdeField("PMQTYT", "PMQTYT", JdeDataType.Numeric),
        new JdeField("PMLINV", "PMLINV", JdeDataType.String, 16),
        new JdeField("PMDLIJ", "PMDLIJ", JdeDataType.Numeric),
        new JdeField("PMCTTL", "PMCTTL", JdeDataType.String, 20),
        new JdeField("PMPNCD", "PMPNCD", JdeDataType.String, 20),
        new JdeField("PMLOTN", "PMLOTN", JdeDataType.String, 60),
        new JdeField("PMPCN", "PMPCN", JdeDataType.String, 30),
        new JdeField("PMTYDS", "PMTYDS", JdeDataType.String, 2),
        new JdeField("PMCQTO", "PMCQTO", JdeDataType.Numeric),
        new JdeField("PMCRCD", "PMCRCD", JdeDataType.String, 6),
        new JdeField("PMCRR", "PMCRR", JdeDataType.Numeric),
        new JdeField("PMCRRM", "PMCRRM", JdeDataType.String, 2),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMTDAY", "PMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4207_0", "Primary Key on PMPCTY, PMMCAT, PMCLV, PMCXPJ", new[] { "PMPCTY", "PMMCAT", "PMCLV", "PMCXPJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4207_2", "Index on PMMCAT, PMCLV", new[] { "PMMCAT", "PMCLV" })
    };
}
