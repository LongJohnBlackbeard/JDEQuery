using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07727 - .
/// </summary>
public class F07727 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J7YR.
        /// </summary>
        public const string J7YR = "J7YR";

        /// <summary>
        /// J7HMCO.
        /// </summary>
        public const string J7HMCO = "J7HMCO";

        /// <summary>
        /// J7MCU.
        /// </summary>
        public const string J7MCU = "J7MCU";

        /// <summary>
        /// J7HMCU.
        /// </summary>
        public const string J7HMCU = "J7HMCU";

        /// <summary>
        /// J7AN8.
        /// </summary>
        public const string J7AN8 = "J7AN8";

        /// <summary>
        /// J7SSN.
        /// </summary>
        public const string J7SSN = "J7SSN";

        /// <summary>
        /// J7TARA.
        /// </summary>
        public const string J7TARA = "J7TARA";

        /// <summary>
        /// J7TAXX.
        /// </summary>
        public const string J7TAXX = "J7TAXX";

        /// <summary>
        /// J7T4PP.
        /// </summary>
        public const string J7T4PP = "J7T4PP";

        /// <summary>
        /// J7T4PA.
        /// </summary>
        public const string J7T4PA = "J7T4PA";

        /// <summary>
        /// J7T4PT.
        /// </summary>
        public const string J7T4PT = "J7T4PT";

        /// <summary>
        /// J7T4AP.
        /// </summary>
        public const string J7T4AP = "J7T4AP";

        /// <summary>
        /// J7T4PN.
        /// </summary>
        public const string J7T4PN = "J7T4PN";

        /// <summary>
        /// J7T4IN.
        /// </summary>
        public const string J7T4IN = "J7T4IN";

        /// <summary>
        /// J7T4LS.
        /// </summary>
        public const string J7T4LS = "J7T4LS";

        /// <summary>
        /// J7T4PL.
        /// </summary>
        public const string J7T4PL = "J7T4PL";

        /// <summary>
        /// J7T4SC.
        /// </summary>
        public const string J7T4SC = "J7T4SC";

        /// <summary>
        /// J7T4PS.
        /// </summary>
        public const string J7T4PS = "J7T4PS";

        /// <summary>
        /// J7T4AN.
        /// </summary>
        public const string J7T4AN = "J7T4AN";

        /// <summary>
        /// J7T4RA.
        /// </summary>
        public const string J7T4RA = "J7T4RA";

        /// <summary>
        /// J7T4R1.
        /// </summary>
        public const string J7T4R1 = "J7T4R1";

        /// <summary>
        /// J7WST.
        /// </summary>
        public const string J7WST = "J7WST";

        /// <summary>
        /// J7WCNT.
        /// </summary>
        public const string J7WCNT = "J7WCNT";

        /// <summary>
        /// J7WCTY.
        /// </summary>
        public const string J7WCTY = "J7WCTY";

        /// <summary>
        /// J7USER.
        /// </summary>
        public const string J7USER = "J7USER";

        /// <summary>
        /// J7PID.
        /// </summary>
        public const string J7PID = "J7PID";

        /// <summary>
        /// J7UPMJ.
        /// </summary>
        public const string J7UPMJ = "J7UPMJ";

        /// <summary>
        /// J7DTSP.
        /// </summary>
        public const string J7DTSP = "J7DTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F07727";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J7YR", "J7YR", JdeDataType.Numeric, null, true, true),
        new JdeField("J7HMCO", "J7HMCO", JdeDataType.String, 10, true, true),
        new JdeField("J7MCU", "J7MCU", JdeDataType.String, 24),
        new JdeField("J7HMCU", "J7HMCU", JdeDataType.String, 24),
        new JdeField("J7AN8", "J7AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J7SSN", "J7SSN", JdeDataType.String, 40),
        new JdeField("J7TARA", "J7TARA", JdeDataType.String, 20, true, true),
        new JdeField("J7TAXX", "J7TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J7T4PP", "J7T4PP", JdeDataType.String, 20),
        new JdeField("J7T4PA", "J7T4PA", JdeDataType.Numeric),
        new JdeField("J7T4PT", "J7T4PT", JdeDataType.Numeric),
        new JdeField("J7T4AP", "J7T4AP", JdeDataType.String, 2),
        new JdeField("J7T4PN", "J7T4PN", JdeDataType.Numeric),
        new JdeField("J7T4IN", "J7T4IN", JdeDataType.Numeric),
        new JdeField("J7T4LS", "J7T4LS", JdeDataType.Numeric),
        new JdeField("J7T4PL", "J7T4PL", JdeDataType.Numeric),
        new JdeField("J7T4SC", "J7T4SC", JdeDataType.Numeric),
        new JdeField("J7T4PS", "J7T4PS", JdeDataType.Numeric),
        new JdeField("J7T4AN", "J7T4AN", JdeDataType.Numeric),
        new JdeField("J7T4RA", "J7T4RA", JdeDataType.Numeric),
        new JdeField("J7T4R1", "J7T4R1", JdeDataType.Numeric),
        new JdeField("J7WST", "J7WST", JdeDataType.Numeric),
        new JdeField("J7WCNT", "J7WCNT", JdeDataType.Numeric),
        new JdeField("J7WCTY", "J7WCTY", JdeDataType.Numeric),
        new JdeField("J7USER", "J7USER", JdeDataType.String, 20),
        new JdeField("J7PID", "J7PID", JdeDataType.String, 20),
        new JdeField("J7UPMJ", "J7UPMJ", JdeDataType.Numeric),
        new JdeField("J7DTSP", "J7DTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07727_0", "Primary Key on J7YR, J7HMCO, J7AN8, J7TARA, J7TAXX", new[] { "J7YR", "J7HMCO", "J7AN8", "J7TARA", "J7TAXX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07727_2", "Index on J7YR, J7AN8, J7HMCO, J7TARA, J7TAXX", new[] { "J7YR", "J7AN8", "J7HMCO", "J7TARA", "J7TAXX" }),
        new JdeIndex("F07727_3", "Index on J7YR, J7SSN, J7HMCO", new[] { "J7YR", "J7SSN", "J7HMCO" })
    };
}
