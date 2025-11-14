using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A392 - .
/// </summary>
public class F76A392 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C2AAJU.
        /// </summary>
        public const string C2AAJU = "C2AAJU";

        /// <summary>
        /// C2CTRY.
        /// </summary>
        public const string C2CTRY = "C2CTRY";

        /// <summary>
        /// C2FY.
        /// </summary>
        public const string C2FY = "C2FY";

        /// <summary>
        /// C2PN.
        /// </summary>
        public const string C2PN = "C2PN";

        /// <summary>
        /// C2CO.
        /// </summary>
        public const string C2CO = "C2CO";

        /// <summary>
        /// C2ICU.
        /// </summary>
        public const string C2ICU = "C2ICU";

        /// <summary>
        /// C2DCT.
        /// </summary>
        public const string C2DCT = "C2DCT";

        /// <summary>
        /// C2DOC.
        /// </summary>
        public const string C2DOC = "C2DOC";

        /// <summary>
        /// C2KCO.
        /// </summary>
        public const string C2KCO = "C2KCO";

        /// <summary>
        /// C2DGJ.
        /// </summary>
        public const string C2DGJ = "C2DGJ";

        /// <summary>
        /// C2URC1.
        /// </summary>
        public const string C2URC1 = "C2URC1";

        /// <summary>
        /// C2URDT.
        /// </summary>
        public const string C2URDT = "C2URDT";

        /// <summary>
        /// C2URAT.
        /// </summary>
        public const string C2URAT = "C2URAT";

        /// <summary>
        /// C2URAB.
        /// </summary>
        public const string C2URAB = "C2URAB";

        /// <summary>
        /// C2URRF.
        /// </summary>
        public const string C2URRF = "C2URRF";

        /// <summary>
        /// C2TORG.
        /// </summary>
        public const string C2TORG = "C2TORG";

        /// <summary>
        /// C2USER.
        /// </summary>
        public const string C2USER = "C2USER";

        /// <summary>
        /// C2PID.
        /// </summary>
        public const string C2PID = "C2PID";

        /// <summary>
        /// C2UPMJ.
        /// </summary>
        public const string C2UPMJ = "C2UPMJ";

        /// <summary>
        /// C2UPMT.
        /// </summary>
        public const string C2UPMT = "C2UPMT";

        /// <summary>
        /// C2JOBN.
        /// </summary>
        public const string C2JOBN = "C2JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A392";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C2AAJU", "C2AAJU", JdeDataType.String, 20, true, true),
        new JdeField("C2CTRY", "C2CTRY", JdeDataType.Numeric),
        new JdeField("C2FY", "C2FY", JdeDataType.Numeric, null, true, true),
        new JdeField("C2PN", "C2PN", JdeDataType.Numeric, null, true, true),
        new JdeField("C2CO", "C2CO", JdeDataType.String, 10, true, true),
        new JdeField("C2ICU", "C2ICU", JdeDataType.Numeric),
        new JdeField("C2DCT", "C2DCT", JdeDataType.String, 4),
        new JdeField("C2DOC", "C2DOC", JdeDataType.Numeric),
        new JdeField("C2KCO", "C2KCO", JdeDataType.String, 10),
        new JdeField("C2DGJ", "C2DGJ", JdeDataType.Numeric),
        new JdeField("C2URC1", "C2URC1", JdeDataType.String, 6),
        new JdeField("C2URDT", "C2URDT", JdeDataType.Numeric),
        new JdeField("C2URAT", "C2URAT", JdeDataType.Numeric),
        new JdeField("C2URAB", "C2URAB", JdeDataType.Numeric),
        new JdeField("C2URRF", "C2URRF", JdeDataType.String, 30),
        new JdeField("C2TORG", "C2TORG", JdeDataType.String, 20),
        new JdeField("C2USER", "C2USER", JdeDataType.String, 20),
        new JdeField("C2PID", "C2PID", JdeDataType.String, 20),
        new JdeField("C2UPMJ", "C2UPMJ", JdeDataType.Numeric),
        new JdeField("C2UPMT", "C2UPMT", JdeDataType.Numeric),
        new JdeField("C2JOBN", "C2JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A392_0", "Primary Key on C2AAJU, C2FY, C2PN, C2CO", new[] { "C2AAJU", "C2FY", "C2PN", "C2CO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A392_2", "Index on C2AAJU, SYS_NC00022$, SYS_NC00023$, C2CO", new[] { "C2AAJU", "SYS_NC00022$", "SYS_NC00023$", "C2CO" })
    };
}
