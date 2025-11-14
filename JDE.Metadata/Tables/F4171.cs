using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4171 - .
/// </summary>
public class F4171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I1UKID.
        /// </summary>
        public const string I1UKID = "I1UKID";

        /// <summary>
        /// I1LOTN.
        /// </summary>
        public const string I1LOTN = "I1LOTN";

        /// <summary>
        /// I1LOCN.
        /// </summary>
        public const string I1LOCN = "I1LOCN";

        /// <summary>
        /// I1MCU.
        /// </summary>
        public const string I1MCU = "I1MCU";

        /// <summary>
        /// I1CHRC.
        /// </summary>
        public const string I1CHRC = "I1CHRC";

        /// <summary>
        /// I1CHPP.
        /// </summary>
        public const string I1CHPP = "I1CHPP";

        /// <summary>
        /// I1CHSC.
        /// </summary>
        public const string I1CHSC = "I1CHSC";

        /// <summary>
        /// I1ITM.
        /// </summary>
        public const string I1ITM = "I1ITM";

        /// <summary>
        /// I1LOTC.
        /// </summary>
        public const string I1LOTC = "I1LOTC";

        /// <summary>
        /// I1LOTL.
        /// </summary>
        public const string I1LOTL = "I1LOTL";

        /// <summary>
        /// I1CHCT.
        /// </summary>
        public const string I1CHCT = "I1CHCT";

        /// <summary>
        /// I1PID.
        /// </summary>
        public const string I1PID = "I1PID";

        /// <summary>
        /// I1UPMJ.
        /// </summary>
        public const string I1UPMJ = "I1UPMJ";

        /// <summary>
        /// I1TDAY.
        /// </summary>
        public const string I1TDAY = "I1TDAY";

        /// <summary>
        /// I1USER.
        /// </summary>
        public const string I1USER = "I1USER";

        /// <summary>
        /// I1JOBN.
        /// </summary>
        public const string I1JOBN = "I1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I1UKID", "I1UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I1LOTN", "I1LOTN", JdeDataType.String, 60, true, true),
        new JdeField("I1LOCN", "I1LOCN", JdeDataType.String, 40, true, true),
        new JdeField("I1MCU", "I1MCU", JdeDataType.String, 24, true, true),
        new JdeField("I1CHRC", "I1CHRC", JdeDataType.String, 6),
        new JdeField("I1CHPP", "I1CHPP", JdeDataType.String, 2),
        new JdeField("I1CHSC", "I1CHSC", JdeDataType.String, 2),
        new JdeField("I1ITM", "I1ITM", JdeDataType.Numeric),
        new JdeField("I1LOTC", "I1LOTC", JdeDataType.String, 6),
        new JdeField("I1LOTL", "I1LOTL", JdeDataType.String, 6),
        new JdeField("I1CHCT", "I1CHCT", JdeDataType.Numeric),
        new JdeField("I1PID", "I1PID", JdeDataType.String, 20),
        new JdeField("I1UPMJ", "I1UPMJ", JdeDataType.Numeric),
        new JdeField("I1TDAY", "I1TDAY", JdeDataType.Numeric),
        new JdeField("I1USER", "I1USER", JdeDataType.String, 20),
        new JdeField("I1JOBN", "I1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4171_0", "Primary Key on I1UKID, I1LOTN, I1LOCN, I1MCU", new[] { "I1UKID", "I1LOTN", "I1LOCN", "I1MCU" }, isUnique: true, isPrimaryKey: true)
    };
}
