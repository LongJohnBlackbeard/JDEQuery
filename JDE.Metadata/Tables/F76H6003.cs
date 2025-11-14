using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6003 - .
/// </summary>
public class F76H6003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I2H76LECO.
        /// </summary>
        public const string I2H76LECO = "I2H76LECO";

        /// <summary>
        /// I2CFY.
        /// </summary>
        public const string I2CFY = "I2CFY";

        /// <summary>
        /// I2FFP.
        /// </summary>
        public const string I2FFP = "I2FFP";

        /// <summary>
        /// I2UKID.
        /// </summary>
        public const string I2UKID = "I2UKID";

        /// <summary>
        /// I2LT.
        /// </summary>
        public const string I2LT = "I2LT";

        /// <summary>
        /// I2MCU.
        /// </summary>
        public const string I2MCU = "I2MCU";

        /// <summary>
        /// I2CSPL.
        /// </summary>
        public const string I2CSPL = "I2CSPL";

        /// <summary>
        /// I2ACTB.
        /// </summary>
        public const string I2ACTB = "I2ACTB";

        /// <summary>
        /// I2DRCD.
        /// </summary>
        public const string I2DRCD = "I2DRCD";

        /// <summary>
        /// I2EFFF.
        /// </summary>
        public const string I2EFFF = "I2EFFF";

        /// <summary>
        /// I2ITM.
        /// </summary>
        public const string I2ITM = "I2ITM";

        /// <summary>
        /// I2ABR1.
        /// </summary>
        public const string I2ABR1 = "I2ABR1";

        /// <summary>
        /// I2ABT1.
        /// </summary>
        public const string I2ABT1 = "I2ABT1";

        /// <summary>
        /// I2ABR2.
        /// </summary>
        public const string I2ABR2 = "I2ABR2";

        /// <summary>
        /// I2ABT2.
        /// </summary>
        public const string I2ABT2 = "I2ABT2";

        /// <summary>
        /// I2ABR3.
        /// </summary>
        public const string I2ABR3 = "I2ABR3";

        /// <summary>
        /// I2ABT3.
        /// </summary>
        public const string I2ABT3 = "I2ABT3";

        /// <summary>
        /// I2ABR4.
        /// </summary>
        public const string I2ABR4 = "I2ABR4";

        /// <summary>
        /// I2ABT4.
        /// </summary>
        public const string I2ABT4 = "I2ABT4";

        /// <summary>
        /// I2SBL.
        /// </summary>
        public const string I2SBL = "I2SBL";

        /// <summary>
        /// I2SBLT.
        /// </summary>
        public const string I2SBLT = "I2SBLT";

        /// <summary>
        /// I2LEDG.
        /// </summary>
        public const string I2LEDG = "I2LEDG";

        /// <summary>
        /// I2COST.
        /// </summary>
        public const string I2COST = "I2COST";

        /// <summary>
        /// I2RATE.
        /// </summary>
        public const string I2RATE = "I2RATE";

        /// <summary>
        /// I2ITMR.
        /// </summary>
        public const string I2ITMR = "I2ITMR";

        /// <summary>
        /// I2MMCU.
        /// </summary>
        public const string I2MMCU = "I2MMCU";

        /// <summary>
        /// I2LOCN.
        /// </summary>
        public const string I2LOCN = "I2LOCN";

        /// <summary>
        /// I2LOTN.
        /// </summary>
        public const string I2LOTN = "I2LOTN";

        /// <summary>
        /// I2USER.
        /// </summary>
        public const string I2USER = "I2USER";

        /// <summary>
        /// I2PID.
        /// </summary>
        public const string I2PID = "I2PID";

        /// <summary>
        /// I2JOBN.
        /// </summary>
        public const string I2JOBN = "I2JOBN";

        /// <summary>
        /// I2UPMJ.
        /// </summary>
        public const string I2UPMJ = "I2UPMJ";

        /// <summary>
        /// I2UPMT.
        /// </summary>
        public const string I2UPMT = "I2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I2H76LECO", "I2H76LECO", JdeDataType.String, 10, true, true),
        new JdeField("I2CFY", "I2CFY", JdeDataType.Numeric, null, true, true),
        new JdeField("I2FFP", "I2FFP", JdeDataType.Numeric, null, true, true),
        new JdeField("I2UKID", "I2UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I2LT", "I2LT", JdeDataType.String, 4),
        new JdeField("I2MCU", "I2MCU", JdeDataType.String, 24),
        new JdeField("I2CSPL", "I2CSPL", JdeDataType.String, 20),
        new JdeField("I2ACTB", "I2ACTB", JdeDataType.String, 20),
        new JdeField("I2DRCD", "I2DRCD", JdeDataType.String, 20),
        new JdeField("I2EFFF", "I2EFFF", JdeDataType.Numeric),
        new JdeField("I2ITM", "I2ITM", JdeDataType.Numeric),
        new JdeField("I2ABR1", "I2ABR1", JdeDataType.String, 24),
        new JdeField("I2ABT1", "I2ABT1", JdeDataType.String, 2),
        new JdeField("I2ABR2", "I2ABR2", JdeDataType.String, 24),
        new JdeField("I2ABT2", "I2ABT2", JdeDataType.String, 2),
        new JdeField("I2ABR3", "I2ABR3", JdeDataType.String, 24),
        new JdeField("I2ABT3", "I2ABT3", JdeDataType.String, 2),
        new JdeField("I2ABR4", "I2ABR4", JdeDataType.String, 24),
        new JdeField("I2ABT4", "I2ABT4", JdeDataType.String, 2),
        new JdeField("I2SBL", "I2SBL", JdeDataType.String, 16),
        new JdeField("I2SBLT", "I2SBLT", JdeDataType.String, 2),
        new JdeField("I2LEDG", "I2LEDG", JdeDataType.String, 4),
        new JdeField("I2COST", "I2COST", JdeDataType.String, 6),
        new JdeField("I2RATE", "I2RATE", JdeDataType.Numeric),
        new JdeField("I2ITMR", "I2ITMR", JdeDataType.Numeric),
        new JdeField("I2MMCU", "I2MMCU", JdeDataType.String, 24),
        new JdeField("I2LOCN", "I2LOCN", JdeDataType.String, 40),
        new JdeField("I2LOTN", "I2LOTN", JdeDataType.String, 60),
        new JdeField("I2USER", "I2USER", JdeDataType.String, 20),
        new JdeField("I2PID", "I2PID", JdeDataType.String, 20),
        new JdeField("I2JOBN", "I2JOBN", JdeDataType.String, 20),
        new JdeField("I2UPMJ", "I2UPMJ", JdeDataType.Numeric),
        new JdeField("I2UPMT", "I2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6003_0", "Primary Key on I2H76LECO, I2CFY, I2FFP, I2UKID", new[] { "I2H76LECO", "I2CFY", "I2FFP", "I2UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H6003_2", "Index on I2H76LECO, I2CFY, I2FFP, SYS_NC00034$", new[] { "I2H76LECO", "I2CFY", "I2FFP", "SYS_NC00034$" })
    };
}
