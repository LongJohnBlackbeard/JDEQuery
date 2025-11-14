using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A394 - .
/// </summary>
public class F76A394 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C4AAJU.
        /// </summary>
        public const string C4AAJU = "C4AAJU";

        /// <summary>
        /// C4CTRY.
        /// </summary>
        public const string C4CTRY = "C4CTRY";

        /// <summary>
        /// C4FY.
        /// </summary>
        public const string C4FY = "C4FY";

        /// <summary>
        /// C4PN.
        /// </summary>
        public const string C4PN = "C4PN";

        /// <summary>
        /// C4CO.
        /// </summary>
        public const string C4CO = "C4CO";

        /// <summary>
        /// C4ITM.
        /// </summary>
        public const string C4ITM = "C4ITM";

        /// <summary>
        /// C4MCU.
        /// </summary>
        public const string C4MCU = "C4MCU";

        /// <summary>
        /// C4LOCN.
        /// </summary>
        public const string C4LOCN = "C4LOCN";

        /// <summary>
        /// C4LOTN.
        /// </summary>
        public const string C4LOTN = "C4LOTN";

        /// <summary>
        /// C4GLPT.
        /// </summary>
        public const string C4GLPT = "C4GLPT";

        /// <summary>
        /// C4MCUS.
        /// </summary>
        public const string C4MCUS = "C4MCUS";

        /// <summary>
        /// C4OBJ.
        /// </summary>
        public const string C4OBJ = "C4OBJ";

        /// <summary>
        /// C4SUB.
        /// </summary>
        public const string C4SUB = "C4SUB";

        /// <summary>
        /// C4NQ01.
        /// </summary>
        public const string C4NQ01 = "C4NQ01";

        /// <summary>
        /// C4AN01.
        /// </summary>
        public const string C4AN01 = "C4AN01";

        /// <summary>
        /// C4ERR.
        /// </summary>
        public const string C4ERR = "C4ERR";

        /// <summary>
        /// C4RMK.
        /// </summary>
        public const string C4RMK = "C4RMK";

        /// <summary>
        /// C4URC1.
        /// </summary>
        public const string C4URC1 = "C4URC1";

        /// <summary>
        /// C4URDT.
        /// </summary>
        public const string C4URDT = "C4URDT";

        /// <summary>
        /// C4URAT.
        /// </summary>
        public const string C4URAT = "C4URAT";

        /// <summary>
        /// C4URAB.
        /// </summary>
        public const string C4URAB = "C4URAB";

        /// <summary>
        /// C4URRF.
        /// </summary>
        public const string C4URRF = "C4URRF";

        /// <summary>
        /// C4TORG.
        /// </summary>
        public const string C4TORG = "C4TORG";

        /// <summary>
        /// C4USER.
        /// </summary>
        public const string C4USER = "C4USER";

        /// <summary>
        /// C4PID.
        /// </summary>
        public const string C4PID = "C4PID";

        /// <summary>
        /// C4UPMJ.
        /// </summary>
        public const string C4UPMJ = "C4UPMJ";

        /// <summary>
        /// C4UPMT.
        /// </summary>
        public const string C4UPMT = "C4UPMT";

        /// <summary>
        /// C4JOBN.
        /// </summary>
        public const string C4JOBN = "C4JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A394";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C4AAJU", "C4AAJU", JdeDataType.String, 20, true, true),
        new JdeField("C4CTRY", "C4CTRY", JdeDataType.Numeric),
        new JdeField("C4FY", "C4FY", JdeDataType.Numeric, null, true, true),
        new JdeField("C4PN", "C4PN", JdeDataType.Numeric, null, true, true),
        new JdeField("C4CO", "C4CO", JdeDataType.String, 10, true, true),
        new JdeField("C4ITM", "C4ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("C4MCU", "C4MCU", JdeDataType.String, 24, true, true),
        new JdeField("C4LOCN", "C4LOCN", JdeDataType.String, 40, true, true),
        new JdeField("C4LOTN", "C4LOTN", JdeDataType.String, 60, true, true),
        new JdeField("C4GLPT", "C4GLPT", JdeDataType.String, 8, true, true),
        new JdeField("C4MCUS", "C4MCUS", JdeDataType.String, 24, true, true),
        new JdeField("C4OBJ", "C4OBJ", JdeDataType.String, 12),
        new JdeField("C4SUB", "C4SUB", JdeDataType.String, 16),
        new JdeField("C4NQ01", "C4NQ01", JdeDataType.Numeric),
        new JdeField("C4AN01", "C4AN01", JdeDataType.Numeric),
        new JdeField("C4ERR", "C4ERR", JdeDataType.String, 2),
        new JdeField("C4RMK", "C4RMK", JdeDataType.String, 60),
        new JdeField("C4URC1", "C4URC1", JdeDataType.String, 6),
        new JdeField("C4URDT", "C4URDT", JdeDataType.Numeric),
        new JdeField("C4URAT", "C4URAT", JdeDataType.Numeric),
        new JdeField("C4URAB", "C4URAB", JdeDataType.Numeric),
        new JdeField("C4URRF", "C4URRF", JdeDataType.String, 30),
        new JdeField("C4TORG", "C4TORG", JdeDataType.String, 20),
        new JdeField("C4USER", "C4USER", JdeDataType.String, 20),
        new JdeField("C4PID", "C4PID", JdeDataType.String, 20),
        new JdeField("C4UPMJ", "C4UPMJ", JdeDataType.Numeric),
        new JdeField("C4UPMT", "C4UPMT", JdeDataType.Numeric),
        new JdeField("C4JOBN", "C4JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A394_0", "Primary Key on C4AAJU, C4FY, C4PN, C4CO, C4ITM, C4MCU, C4LOCN, C4LOTN, C4GLPT, C4MCUS", new[] { "C4AAJU", "C4FY", "C4PN", "C4CO", "C4ITM", "C4MCU", "C4LOCN", "C4LOTN", "C4GLPT", "C4MCUS" }, isUnique: true, isPrimaryKey: true)
    };
}
