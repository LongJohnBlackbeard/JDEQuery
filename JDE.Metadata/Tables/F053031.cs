using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F053031 - .
/// </summary>
public class F053031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EWCALYEAR.
        /// </summary>
        public const string EWCALYEAR = "EWCALYEAR";

        /// <summary>
        /// EWW4TBNO.
        /// </summary>
        public const string EWW4TBNO = "EWW4TBNO";

        /// <summary>
        /// EWW4MARSTT.
        /// </summary>
        public const string EWW4MARSTT = "EWW4MARSTT";

        /// <summary>
        /// EWW4TBWGF.
        /// </summary>
        public const string EWW4TBWGF = "EWW4TBWGF";

        /// <summary>
        /// EWW4TBWGT.
        /// </summary>
        public const string EWW4TBWGT = "EWW4TBWGT";

        /// <summary>
        /// EWW4TBWGE.
        /// </summary>
        public const string EWW4TBWGE = "EWW4TBWGE";

        /// <summary>
        /// EWJOBN.
        /// </summary>
        public const string EWJOBN = "EWJOBN";

        /// <summary>
        /// EWUSER.
        /// </summary>
        public const string EWUSER = "EWUSER";

        /// <summary>
        /// EWPID.
        /// </summary>
        public const string EWPID = "EWPID";

        /// <summary>
        /// EWUPMJ.
        /// </summary>
        public const string EWUPMJ = "EWUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F053031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EWCALYEAR", "EWCALYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("EWW4TBNO", "EWW4TBNO", JdeDataType.String, 2, true, true),
        new JdeField("EWW4MARSTT", "EWW4MARSTT", JdeDataType.String, 2, true, true),
        new JdeField("EWW4TBWGF", "EWW4TBWGF", JdeDataType.Numeric, null, true, true),
        new JdeField("EWW4TBWGT", "EWW4TBWGT", JdeDataType.Numeric),
        new JdeField("EWW4TBWGE", "EWW4TBWGE", JdeDataType.Numeric),
        new JdeField("EWJOBN", "EWJOBN", JdeDataType.String, 20),
        new JdeField("EWUSER", "EWUSER", JdeDataType.String, 20),
        new JdeField("EWPID", "EWPID", JdeDataType.String, 20),
        new JdeField("EWUPMJ", "EWUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F053031_0", "Primary Key on EWCALYEAR, EWW4TBNO, EWW4MARSTT, EWW4TBWGF", new[] { "EWCALYEAR", "EWW4TBNO", "EWW4MARSTT", "EWW4TBWGF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F053031_2", "Index on EWCALYEAR, EWW4TBNO, EWW4MARSTT, SYS_NC00011$", new[] { "EWCALYEAR", "EWW4TBNO", "EWW4MARSTT", "SYS_NC00011$" })
    };
}
