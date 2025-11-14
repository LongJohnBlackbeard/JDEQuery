using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F053032 - .
/// </summary>
public class F053032 : JdeTable
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
        /// EWW4TBHF.
        /// </summary>
        public const string EWW4TBHF = "EWW4TBHF";

        /// <summary>
        /// EWW4TBHT.
        /// </summary>
        public const string EWW4TBHT = "EWW4TBHT";

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
        /// EWUSER.
        /// </summary>
        public const string EWUSER = "EWUSER";

        /// <summary>
        /// EWJOBN.
        /// </summary>
        public const string EWJOBN = "EWJOBN";

        /// <summary>
        /// EWUPMJ.
        /// </summary>
        public const string EWUPMJ = "EWUPMJ";

        /// <summary>
        /// EWUPMT.
        /// </summary>
        public const string EWUPMT = "EWUPMT";

        /// <summary>
        /// EWPID.
        /// </summary>
        public const string EWPID = "EWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F053032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EWCALYEAR", "EWCALYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("EWW4TBNO", "EWW4TBNO", JdeDataType.String, 2, true, true),
        new JdeField("EWW4MARSTT", "EWW4MARSTT", JdeDataType.String, 2, true, true),
        new JdeField("EWW4TBHF", "EWW4TBHF", JdeDataType.Numeric, null, true, true),
        new JdeField("EWW4TBHT", "EWW4TBHT", JdeDataType.Numeric),
        new JdeField("EWW4TBWGF", "EWW4TBWGF", JdeDataType.Numeric, null, true, true),
        new JdeField("EWW4TBWGT", "EWW4TBWGT", JdeDataType.Numeric),
        new JdeField("EWW4TBWGE", "EWW4TBWGE", JdeDataType.Numeric),
        new JdeField("EWUSER", "EWUSER", JdeDataType.String, 20),
        new JdeField("EWJOBN", "EWJOBN", JdeDataType.String, 20),
        new JdeField("EWUPMJ", "EWUPMJ", JdeDataType.Numeric),
        new JdeField("EWUPMT", "EWUPMT", JdeDataType.Numeric),
        new JdeField("EWPID", "EWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F053032_0", "Primary Key on EWCALYEAR, EWW4TBNO, EWW4MARSTT, EWW4TBHF, EWW4TBWGF", new[] { "EWCALYEAR", "EWW4TBNO", "EWW4MARSTT", "EWW4TBHF", "EWW4TBWGF" }, isUnique: true, isPrimaryKey: true)
    };
}
