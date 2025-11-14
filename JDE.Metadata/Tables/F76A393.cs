using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A393 - .
/// </summary>
public class F76A393 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C3AAJU.
        /// </summary>
        public const string C3AAJU = "C3AAJU";

        /// <summary>
        /// C3CTRY.
        /// </summary>
        public const string C3CTRY = "C3CTRY";

        /// <summary>
        /// C3FY.
        /// </summary>
        public const string C3FY = "C3FY";

        /// <summary>
        /// C3PN.
        /// </summary>
        public const string C3PN = "C3PN";

        /// <summary>
        /// C3CO.
        /// </summary>
        public const string C3CO = "C3CO";

        /// <summary>
        /// C3ITM.
        /// </summary>
        public const string C3ITM = "C3ITM";

        /// <summary>
        /// C3MCU.
        /// </summary>
        public const string C3MCU = "C3MCU";

        /// <summary>
        /// C3LOCN.
        /// </summary>
        public const string C3LOCN = "C3LOCN";

        /// <summary>
        /// C3LOTN.
        /// </summary>
        public const string C3LOTN = "C3LOTN";

        /// <summary>
        /// C3PRRC.
        /// </summary>
        public const string C3PRRC = "C3PRRC";

        /// <summary>
        /// C3UPRC.
        /// </summary>
        public const string C3UPRC = "C3UPRC";

        /// <summary>
        /// C3UNCS.
        /// </summary>
        public const string C3UNCS = "C3UNCS";

        /// <summary>
        /// C3AMC3.
        /// </summary>
        public const string C3AMC3 = "C3AMC3";

        /// <summary>
        /// C3ERR.
        /// </summary>
        public const string C3ERR = "C3ERR";

        /// <summary>
        /// C3DCTO.
        /// </summary>
        public const string C3DCTO = "C3DCTO";

        /// <summary>
        /// C3DOCO.
        /// </summary>
        public const string C3DOCO = "C3DOCO";

        /// <summary>
        /// C3KCOO.
        /// </summary>
        public const string C3KCOO = "C3KCOO";

        /// <summary>
        /// C3LNID.
        /// </summary>
        public const string C3LNID = "C3LNID";

        /// <summary>
        /// C3NLIN.
        /// </summary>
        public const string C3NLIN = "C3NLIN";

        /// <summary>
        /// C3DOC.
        /// </summary>
        public const string C3DOC = "C3DOC";

        /// <summary>
        /// C3RMK.
        /// </summary>
        public const string C3RMK = "C3RMK";

        /// <summary>
        /// C3URC1.
        /// </summary>
        public const string C3URC1 = "C3URC1";

        /// <summary>
        /// C3URDT.
        /// </summary>
        public const string C3URDT = "C3URDT";

        /// <summary>
        /// C3URAT.
        /// </summary>
        public const string C3URAT = "C3URAT";

        /// <summary>
        /// C3URAB.
        /// </summary>
        public const string C3URAB = "C3URAB";

        /// <summary>
        /// C3URRF.
        /// </summary>
        public const string C3URRF = "C3URRF";

        /// <summary>
        /// C3TORG.
        /// </summary>
        public const string C3TORG = "C3TORG";

        /// <summary>
        /// C3USER.
        /// </summary>
        public const string C3USER = "C3USER";

        /// <summary>
        /// C3PID.
        /// </summary>
        public const string C3PID = "C3PID";

        /// <summary>
        /// C3UPMJ.
        /// </summary>
        public const string C3UPMJ = "C3UPMJ";

        /// <summary>
        /// C3UPMT.
        /// </summary>
        public const string C3UPMT = "C3UPMT";

        /// <summary>
        /// C3JOBN.
        /// </summary>
        public const string C3JOBN = "C3JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A393";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C3AAJU", "C3AAJU", JdeDataType.String, 20, true, true),
        new JdeField("C3CTRY", "C3CTRY", JdeDataType.Numeric),
        new JdeField("C3FY", "C3FY", JdeDataType.Numeric, null, true, true),
        new JdeField("C3PN", "C3PN", JdeDataType.Numeric, null, true, true),
        new JdeField("C3CO", "C3CO", JdeDataType.String, 10, true, true),
        new JdeField("C3ITM", "C3ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("C3MCU", "C3MCU", JdeDataType.String, 24, true, true),
        new JdeField("C3LOCN", "C3LOCN", JdeDataType.String, 40, true, true),
        new JdeField("C3LOTN", "C3LOTN", JdeDataType.String, 60, true, true),
        new JdeField("C3PRRC", "C3PRRC", JdeDataType.Numeric),
        new JdeField("C3UPRC", "C3UPRC", JdeDataType.Numeric),
        new JdeField("C3UNCS", "C3UNCS", JdeDataType.Numeric),
        new JdeField("C3AMC3", "C3AMC3", JdeDataType.Numeric),
        new JdeField("C3ERR", "C3ERR", JdeDataType.String, 2),
        new JdeField("C3DCTO", "C3DCTO", JdeDataType.String, 4),
        new JdeField("C3DOCO", "C3DOCO", JdeDataType.Numeric),
        new JdeField("C3KCOO", "C3KCOO", JdeDataType.String, 10),
        new JdeField("C3LNID", "C3LNID", JdeDataType.Numeric),
        new JdeField("C3NLIN", "C3NLIN", JdeDataType.Numeric),
        new JdeField("C3DOC", "C3DOC", JdeDataType.Numeric),
        new JdeField("C3RMK", "C3RMK", JdeDataType.String, 60),
        new JdeField("C3URC1", "C3URC1", JdeDataType.String, 6),
        new JdeField("C3URDT", "C3URDT", JdeDataType.Numeric),
        new JdeField("C3URAT", "C3URAT", JdeDataType.Numeric),
        new JdeField("C3URAB", "C3URAB", JdeDataType.Numeric),
        new JdeField("C3URRF", "C3URRF", JdeDataType.String, 30),
        new JdeField("C3TORG", "C3TORG", JdeDataType.String, 20),
        new JdeField("C3USER", "C3USER", JdeDataType.String, 20),
        new JdeField("C3PID", "C3PID", JdeDataType.String, 20),
        new JdeField("C3UPMJ", "C3UPMJ", JdeDataType.Numeric),
        new JdeField("C3UPMT", "C3UPMT", JdeDataType.Numeric),
        new JdeField("C3JOBN", "C3JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A393_0", "Primary Key on C3AAJU, C3FY, C3PN, C3CO, C3ITM, C3MCU, C3LOCN, C3LOTN", new[] { "C3AAJU", "C3FY", "C3PN", "C3CO", "C3ITM", "C3MCU", "C3LOCN", "C3LOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
