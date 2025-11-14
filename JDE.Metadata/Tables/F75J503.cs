using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75J503 - .
/// </summary>
public class F75J503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMJ75LMGC.
        /// </summary>
        public const string LMJ75LMGC = "LMJ75LMGC";

        /// <summary>
        /// LMJ75EDFM.
        /// </summary>
        public const string LMJ75EDFM = "LMJ75EDFM";

        /// <summary>
        /// LMJ75LMB.
        /// </summary>
        public const string LMJ75LMB = "LMJ75LMB";

        /// <summary>
        /// LMJ75LMA.
        /// </summary>
        public const string LMJ75LMA = "LMJ75LMA";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMUPMT.
        /// </summary>
        public const string LMUPMT = "LMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75J503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMJ75LMGC", "LMJ75LMGC", JdeDataType.String, 6, true, true),
        new JdeField("LMJ75EDFM", "LMJ75EDFM", JdeDataType.Numeric, null, true, true),
        new JdeField("LMJ75LMB", "LMJ75LMB", JdeDataType.Numeric, null, true, true),
        new JdeField("LMJ75LMA", "LMJ75LMA", JdeDataType.Numeric),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMUPMT", "LMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75J503_0", "Primary Key on LMJ75LMGC, LMJ75EDFM, LMJ75LMB", new[] { "LMJ75LMGC", "LMJ75EDFM", "LMJ75LMB" }, isUnique: true, isPrimaryKey: true)
    };
}
