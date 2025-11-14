using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3404 - .
/// </summary>
public class F3404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMF$RP.
        /// </summary>
        public const string PMF_RP = "PMF$RP";

        /// <summary>
        /// PMMMCU.
        /// </summary>
        public const string PMMMCU = "PMMMCU";

        /// <summary>
        /// PMITM.
        /// </summary>
        public const string PMITM = "PMITM";

        /// <summary>
        /// PMCMCU.
        /// </summary>
        public const string PMCMCU = "PMCMCU";

        /// <summary>
        /// PMEFFF.
        /// </summary>
        public const string PMEFFF = "PMEFFF";

        /// <summary>
        /// PMEFFT.
        /// </summary>
        public const string PMEFFT = "PMEFFT";

        /// <summary>
        /// PMFTRP.
        /// </summary>
        public const string PMFTRP = "PMFTRP";

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

        /// <summary>
        /// PMKIT.
        /// </summary>
        public const string PMKIT = "PMKIT";
    }

    /// <inheritdoc />
    public override string TableName => "F3404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMF$RP", "PMF$RP", JdeDataType.Numeric),
        new JdeField("PMMMCU", "PMMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PMITM", "PMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PMCMCU", "PMCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PMEFFF", "PMEFFF", JdeDataType.Numeric),
        new JdeField("PMEFFT", "PMEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("PMFTRP", "PMFTRP", JdeDataType.Numeric),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMTDAY", "PMTDAY", JdeDataType.Numeric),
        new JdeField("PMKIT", "PMKIT", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3404_0", "Primary Key on PMKIT, PMCMCU, PMEFFT, PMMMCU, PMITM", new[] { "PMKIT", "PMCMCU", "PMEFFT", "PMMMCU", "PMITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3404_2", "Index on PMMMCU, PMKIT, PMCMCU, PMITM", new[] { "PMMMCU", "PMKIT", "PMCMCU", "PMITM" })
    };
}
