using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B032 - .
/// </summary>
public class F76B032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMB76TNF.
        /// </summary>
        public const string LMB76TNF = "LMB76TNF";

        /// <summary>
        /// LMB76MOTY.
        /// </summary>
        public const string LMB76MOTY = "LMB76MOTY";

        /// <summary>
        /// LMB76LAK.
        /// </summary>
        public const string LMB76LAK = "LMB76LAK";

        /// <summary>
        /// LMB76EFL.
        /// </summary>
        public const string LMB76EFL = "LMB76EFL";

        /// <summary>
        /// LMB76SMF.
        /// </summary>
        public const string LMB76SMF = "LMB76SMF";

        /// <summary>
        /// LMB76SEF.
        /// </summary>
        public const string LMB76SEF = "LMB76SEF";

        /// <summary>
        /// LMB76STE.
        /// </summary>
        public const string LMB76STE = "LMB76STE";

        /// <summary>
        /// LMB76URAB.
        /// </summary>
        public const string LMB76URAB = "LMB76URAB";

        /// <summary>
        /// LMB76URAT.
        /// </summary>
        public const string LMB76URAT = "LMB76URAT";

        /// <summary>
        /// LMB76URRF.
        /// </summary>
        public const string LMB76URRF = "LMB76URRF";

        /// <summary>
        /// LMB76URDT.
        /// </summary>
        public const string LMB76URDT = "LMB76URDT";

        /// <summary>
        /// LMB76URCD.
        /// </summary>
        public const string LMB76URCD = "LMB76URCD";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMUPMT.
        /// </summary>
        public const string LMUPMT = "LMUPMT";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMB76TNF", "LMB76TNF", JdeDataType.String, 20, true, true),
        new JdeField("LMB76MOTY", "LMB76MOTY", JdeDataType.String, 4),
        new JdeField("LMB76LAK", "LMB76LAK", JdeDataType.Numeric),
        new JdeField("LMB76EFL", "LMB76EFL", JdeDataType.String, 2),
        new JdeField("LMB76SMF", "LMB76SMF", JdeDataType.String, 2),
        new JdeField("LMB76SEF", "LMB76SEF", JdeDataType.String, 2),
        new JdeField("LMB76STE", "LMB76STE", JdeDataType.String, 60),
        new JdeField("LMB76URAB", "LMB76URAB", JdeDataType.Numeric),
        new JdeField("LMB76URAT", "LMB76URAT", JdeDataType.Numeric),
        new JdeField("LMB76URRF", "LMB76URRF", JdeDataType.String, 30),
        new JdeField("LMB76URDT", "LMB76URDT", JdeDataType.Numeric),
        new JdeField("LMB76URCD", "LMB76URCD", JdeDataType.String, 4),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMUPMT", "LMUPMT", JdeDataType.Numeric),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B032_0", "Primary Key on LMB76TNF", new[] { "LMB76TNF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B032_1", "Unique Index on LMB76TNF, LMB76MOTY", new[] { "LMB76TNF", "LMB76MOTY" }, isUnique: true),
        new JdeIndex("F76B032_2", "Index on LMB76MOTY", new[] { "LMB76MOTY" })
    };
}
