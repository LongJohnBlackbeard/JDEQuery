using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45511W - .
/// </summary>
public class F45511W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWCTID.
        /// </summary>
        public const string SWCTID = "SWCTID";

        /// <summary>
        /// SWJOBS.
        /// </summary>
        public const string SWJOBS = "SWJOBS";

        /// <summary>
        /// SWPEID.
        /// </summary>
        public const string SWPEID = "SWPEID";

        /// <summary>
        /// SWTCID.
        /// </summary>
        public const string SWTCID = "SWTCID";

        /// <summary>
        /// SWDTAI.
        /// </summary>
        public const string SWDTAI = "SWDTAI";

        /// <summary>
        /// SWSASEQVL.
        /// </summary>
        public const string SWSASEQVL = "SWSASEQVL";

        /// <summary>
        /// SWDSCA.
        /// </summary>
        public const string SWDSCA = "SWDSCA";

        /// <summary>
        /// SWSARELTY.
        /// </summary>
        public const string SWSARELTY = "SWSARELTY";

        /// <summary>
        /// SWSAVALUE.
        /// </summary>
        public const string SWSAVALUE = "SWSAVALUE";

        /// <summary>
        /// SWSALSTNB.
        /// </summary>
        public const string SWSALSTNB = "SWSALSTNB";

        /// <summary>
        /// SWSAFLAG.
        /// </summary>
        public const string SWSAFLAG = "SWSAFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F45511W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWCTID", "SWCTID", JdeDataType.String, 30, true, true),
        new JdeField("SWJOBS", "SWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SWPEID", "SWPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWTCID", "SWTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDTAI", "SWDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SWSASEQVL", "SWSASEQVL", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDSCA", "SWDSCA", JdeDataType.String, 80),
        new JdeField("SWSARELTY", "SWSARELTY", JdeDataType.String, 4),
        new JdeField("SWSAVALUE", "SWSAVALUE", JdeDataType.String, 60),
        new JdeField("SWSALSTNB", "SWSALSTNB", JdeDataType.Numeric),
        new JdeField("SWSAFLAG", "SWSAFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45511W_0", "Primary Key on SWCTID, SWJOBS, SWTCID, SWPEID, SWDTAI, SWSASEQVL", new[] { "SWCTID", "SWJOBS", "SWTCID", "SWPEID", "SWDTAI", "SWSASEQVL" }, isUnique: true, isPrimaryKey: true)
    };
}
