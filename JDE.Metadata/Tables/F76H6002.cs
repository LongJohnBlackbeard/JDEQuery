using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6002 - .
/// </summary>
public class F76H6002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I1H76LECO.
        /// </summary>
        public const string I1H76LECO = "I1H76LECO";

        /// <summary>
        /// I1CFY.
        /// </summary>
        public const string I1CFY = "I1CFY";

        /// <summary>
        /// I1FFP.
        /// </summary>
        public const string I1FFP = "I1FFP";

        /// <summary>
        /// I1UKID.
        /// </summary>
        public const string I1UKID = "I1UKID";

        /// <summary>
        /// I1VWNM.
        /// </summary>
        public const string I1VWNM = "I1VWNM";

        /// <summary>
        /// I1ACTB.
        /// </summary>
        public const string I1ACTB = "I1ACTB";

        /// <summary>
        /// I1AID.
        /// </summary>
        public const string I1AID = "I1AID";

        /// <summary>
        /// I1LT.
        /// </summary>
        public const string I1LT = "I1LT";

        /// <summary>
        /// I1SBL.
        /// </summary>
        public const string I1SBL = "I1SBL";

        /// <summary>
        /// I1SBLT.
        /// </summary>
        public const string I1SBLT = "I1SBLT";

        /// <summary>
        /// I1ABR1.
        /// </summary>
        public const string I1ABR1 = "I1ABR1";

        /// <summary>
        /// I1ABT1.
        /// </summary>
        public const string I1ABT1 = "I1ABT1";

        /// <summary>
        /// I1ABR2.
        /// </summary>
        public const string I1ABR2 = "I1ABR2";

        /// <summary>
        /// I1ABT2.
        /// </summary>
        public const string I1ABT2 = "I1ABT2";

        /// <summary>
        /// I1ABR3.
        /// </summary>
        public const string I1ABR3 = "I1ABR3";

        /// <summary>
        /// I1ABT3.
        /// </summary>
        public const string I1ABT3 = "I1ABT3";

        /// <summary>
        /// I1ABR4.
        /// </summary>
        public const string I1ABR4 = "I1ABR4";

        /// <summary>
        /// I1ABT4.
        /// </summary>
        public const string I1ABT4 = "I1ABT4";

        /// <summary>
        /// I1ITM.
        /// </summary>
        public const string I1ITM = "I1ITM";

        /// <summary>
        /// I1LEDG.
        /// </summary>
        public const string I1LEDG = "I1LEDG";

        /// <summary>
        /// I1COST.
        /// </summary>
        public const string I1COST = "I1COST";

        /// <summary>
        /// I1CRCX.
        /// </summary>
        public const string I1CRCX = "I1CRCX";

        /// <summary>
        /// I1AA.
        /// </summary>
        public const string I1AA = "I1AA";

        /// <summary>
        /// I1ITMR.
        /// </summary>
        public const string I1ITMR = "I1ITMR";

        /// <summary>
        /// I1MMCU.
        /// </summary>
        public const string I1MMCU = "I1MMCU";

        /// <summary>
        /// I1LOCN.
        /// </summary>
        public const string I1LOCN = "I1LOCN";

        /// <summary>
        /// I1LOTN.
        /// </summary>
        public const string I1LOTN = "I1LOTN";

        /// <summary>
        /// I1USER.
        /// </summary>
        public const string I1USER = "I1USER";

        /// <summary>
        /// I1PID.
        /// </summary>
        public const string I1PID = "I1PID";

        /// <summary>
        /// I1JOBN.
        /// </summary>
        public const string I1JOBN = "I1JOBN";

        /// <summary>
        /// I1UPMJ.
        /// </summary>
        public const string I1UPMJ = "I1UPMJ";

        /// <summary>
        /// I1UPMT.
        /// </summary>
        public const string I1UPMT = "I1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I1H76LECO", "I1H76LECO", JdeDataType.String, 10, true, true),
        new JdeField("I1CFY", "I1CFY", JdeDataType.Numeric, null, true, true),
        new JdeField("I1FFP", "I1FFP", JdeDataType.Numeric, null, true, true),
        new JdeField("I1UKID", "I1UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I1VWNM", "I1VWNM", JdeDataType.Numeric),
        new JdeField("I1ACTB", "I1ACTB", JdeDataType.String, 20),
        new JdeField("I1AID", "I1AID", JdeDataType.String, 16),
        new JdeField("I1LT", "I1LT", JdeDataType.String, 4),
        new JdeField("I1SBL", "I1SBL", JdeDataType.String, 16),
        new JdeField("I1SBLT", "I1SBLT", JdeDataType.String, 2),
        new JdeField("I1ABR1", "I1ABR1", JdeDataType.String, 24),
        new JdeField("I1ABT1", "I1ABT1", JdeDataType.String, 2),
        new JdeField("I1ABR2", "I1ABR2", JdeDataType.String, 24),
        new JdeField("I1ABT2", "I1ABT2", JdeDataType.String, 2),
        new JdeField("I1ABR3", "I1ABR3", JdeDataType.String, 24),
        new JdeField("I1ABT3", "I1ABT3", JdeDataType.String, 2),
        new JdeField("I1ABR4", "I1ABR4", JdeDataType.String, 24),
        new JdeField("I1ABT4", "I1ABT4", JdeDataType.String, 2),
        new JdeField("I1ITM", "I1ITM", JdeDataType.Numeric),
        new JdeField("I1LEDG", "I1LEDG", JdeDataType.String, 4),
        new JdeField("I1COST", "I1COST", JdeDataType.String, 6),
        new JdeField("I1CRCX", "I1CRCX", JdeDataType.String, 6),
        new JdeField("I1AA", "I1AA", JdeDataType.Numeric),
        new JdeField("I1ITMR", "I1ITMR", JdeDataType.Numeric),
        new JdeField("I1MMCU", "I1MMCU", JdeDataType.String, 24),
        new JdeField("I1LOCN", "I1LOCN", JdeDataType.String, 40),
        new JdeField("I1LOTN", "I1LOTN", JdeDataType.String, 60),
        new JdeField("I1USER", "I1USER", JdeDataType.String, 20),
        new JdeField("I1PID", "I1PID", JdeDataType.String, 20),
        new JdeField("I1JOBN", "I1JOBN", JdeDataType.String, 20),
        new JdeField("I1UPMJ", "I1UPMJ", JdeDataType.Numeric),
        new JdeField("I1UPMT", "I1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6002_0", "Primary Key on I1H76LECO, I1CFY, I1FFP, I1UKID", new[] { "I1H76LECO", "I1CFY", "I1FFP", "I1UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H6002_2", "Index on I1H76LECO, I1CFY, I1FFP, SYS_NC00033$", new[] { "I1H76LECO", "I1CFY", "I1FFP", "SYS_NC00033$" })
    };
}
