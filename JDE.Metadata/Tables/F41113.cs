using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41113 - .
/// </summary>
public class F41113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I8UKID.
        /// </summary>
        public const string I8UKID = "I8UKID";

        /// <summary>
        /// I8MCU.
        /// </summary>
        public const string I8MCU = "I8MCU";

        /// <summary>
        /// I8ITM.
        /// </summary>
        public const string I8ITM = "I8ITM";

        /// <summary>
        /// I8LOTN.
        /// </summary>
        public const string I8LOTN = "I8LOTN";

        /// <summary>
        /// I8LOTC.
        /// </summary>
        public const string I8LOTC = "I8LOTC";

        /// <summary>
        /// I8CHRC.
        /// </summary>
        public const string I8CHRC = "I8CHRC";

        /// <summary>
        /// I8CHPP.
        /// </summary>
        public const string I8CHPP = "I8CHPP";

        /// <summary>
        /// I8LOCN.
        /// </summary>
        public const string I8LOCN = "I8LOCN";

        /// <summary>
        /// I8LITM.
        /// </summary>
        public const string I8LITM = "I8LITM";

        /// <summary>
        /// I8AITM.
        /// </summary>
        public const string I8AITM = "I8AITM";

        /// <summary>
        /// I8PLOT.
        /// </summary>
        public const string I8PLOT = "I8PLOT";

        /// <summary>
        /// I8MMEJ.
        /// </summary>
        public const string I8MMEJ = "I8MMEJ";

        /// <summary>
        /// I8BBDJ.
        /// </summary>
        public const string I8BBDJ = "I8BBDJ";

        /// <summary>
        /// I8BODJ.
        /// </summary>
        public const string I8BODJ = "I8BODJ";

        /// <summary>
        /// I8DLEJ.
        /// </summary>
        public const string I8DLEJ = "I8DLEJ";

        /// <summary>
        /// I8OHDJ.
        /// </summary>
        public const string I8OHDJ = "I8OHDJ";

        /// <summary>
        /// I8SBDJ.
        /// </summary>
        public const string I8SBDJ = "I8SBDJ";

        /// <summary>
        /// I8U1DJ.
        /// </summary>
        public const string I8U1DJ = "I8U1DJ";

        /// <summary>
        /// I8U2DJ.
        /// </summary>
        public const string I8U2DJ = "I8U2DJ";

        /// <summary>
        /// I8U3DJ.
        /// </summary>
        public const string I8U3DJ = "I8U3DJ";

        /// <summary>
        /// I8U4DJ.
        /// </summary>
        public const string I8U4DJ = "I8U4DJ";

        /// <summary>
        /// I8U5DJ.
        /// </summary>
        public const string I8U5DJ = "I8U5DJ";

        /// <summary>
        /// I8USER.
        /// </summary>
        public const string I8USER = "I8USER";

        /// <summary>
        /// I8PID.
        /// </summary>
        public const string I8PID = "I8PID";

        /// <summary>
        /// I8JOBN.
        /// </summary>
        public const string I8JOBN = "I8JOBN";

        /// <summary>
        /// I8UPMJ.
        /// </summary>
        public const string I8UPMJ = "I8UPMJ";

        /// <summary>
        /// I8TDAY.
        /// </summary>
        public const string I8TDAY = "I8TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I8UKID", "I8UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I8MCU", "I8MCU", JdeDataType.String, 24),
        new JdeField("I8ITM", "I8ITM", JdeDataType.Numeric),
        new JdeField("I8LOTN", "I8LOTN", JdeDataType.String, 60),
        new JdeField("I8LOTC", "I8LOTC", JdeDataType.String, 6),
        new JdeField("I8CHRC", "I8CHRC", JdeDataType.String, 6),
        new JdeField("I8CHPP", "I8CHPP", JdeDataType.String, 2),
        new JdeField("I8LOCN", "I8LOCN", JdeDataType.String, 40),
        new JdeField("I8LITM", "I8LITM", JdeDataType.String, 50),
        new JdeField("I8AITM", "I8AITM", JdeDataType.String, 50),
        new JdeField("I8PLOT", "I8PLOT", JdeDataType.String, 60),
        new JdeField("I8MMEJ", "I8MMEJ", JdeDataType.Numeric),
        new JdeField("I8BBDJ", "I8BBDJ", JdeDataType.Numeric),
        new JdeField("I8BODJ", "I8BODJ", JdeDataType.Numeric),
        new JdeField("I8DLEJ", "I8DLEJ", JdeDataType.Numeric),
        new JdeField("I8OHDJ", "I8OHDJ", JdeDataType.Numeric),
        new JdeField("I8SBDJ", "I8SBDJ", JdeDataType.Numeric),
        new JdeField("I8U1DJ", "I8U1DJ", JdeDataType.Numeric),
        new JdeField("I8U2DJ", "I8U2DJ", JdeDataType.Numeric),
        new JdeField("I8U3DJ", "I8U3DJ", JdeDataType.Numeric),
        new JdeField("I8U4DJ", "I8U4DJ", JdeDataType.Numeric),
        new JdeField("I8U5DJ", "I8U5DJ", JdeDataType.Numeric),
        new JdeField("I8USER", "I8USER", JdeDataType.String, 20),
        new JdeField("I8PID", "I8PID", JdeDataType.String, 20),
        new JdeField("I8JOBN", "I8JOBN", JdeDataType.String, 20),
        new JdeField("I8UPMJ", "I8UPMJ", JdeDataType.Numeric),
        new JdeField("I8TDAY", "I8TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41113_0", "Primary Key on I8UKID", new[] { "I8UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
