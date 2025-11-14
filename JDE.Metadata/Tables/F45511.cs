using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45511 - .
/// </summary>
public class F45511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDSANAME.
        /// </summary>
        public const string SDSANAME = "SDSANAME";

        /// <summary>
        /// SDDTAI.
        /// </summary>
        public const string SDDTAI = "SDDTAI";

        /// <summary>
        /// SDSASEQVL.
        /// </summary>
        public const string SDSASEQVL = "SDSASEQVL";

        /// <summary>
        /// SDSARELTY.
        /// </summary>
        public const string SDSARELTY = "SDSARELTY";

        /// <summary>
        /// SDSAVALUE.
        /// </summary>
        public const string SDSAVALUE = "SDSAVALUE";

        /// <summary>
        /// SDDSCA.
        /// </summary>
        public const string SDDSCA = "SDDSCA";

        /// <summary>
        /// SDSALSTNB.
        /// </summary>
        public const string SDSALSTNB = "SDSALSTNB";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F45511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDSANAME", "SDSANAME", JdeDataType.String, 20, true, true),
        new JdeField("SDDTAI", "SDDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SDSASEQVL", "SDSASEQVL", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSARELTY", "SDSARELTY", JdeDataType.String, 4),
        new JdeField("SDSAVALUE", "SDSAVALUE", JdeDataType.String, 60),
        new JdeField("SDDSCA", "SDDSCA", JdeDataType.String, 80),
        new JdeField("SDSALSTNB", "SDSALSTNB", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45511_0", "Primary Key on SDSANAME, SDDTAI, SDSASEQVL", new[] { "SDSANAME", "SDDTAI", "SDSASEQVL" }, isUnique: true, isPrimaryKey: true)
    };
}
