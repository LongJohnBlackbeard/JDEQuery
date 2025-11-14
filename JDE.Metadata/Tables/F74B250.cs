using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74B250 - .
/// </summary>
public class F74B250 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CP74TRAN.
        /// </summary>
        public const string CP74TRAN = "CP74TRAN";

        /// <summary>
        /// CP74KCTR.
        /// </summary>
        public const string CP74KCTR = "CP74KCTR";

        /// <summary>
        /// CP74KVAT.
        /// </summary>
        public const string CP74KVAT = "CP74KVAT";

        /// <summary>
        /// CP74CCTR.
        /// </summary>
        public const string CP74CCTR = "CP74CCTR";

        /// <summary>
        /// CP74CVAT.
        /// </summary>
        public const string CP74CVAT = "CP74CVAT";

        /// <summary>
        /// CP74TRTN.
        /// </summary>
        public const string CP74TRTN = "CP74TRTN";

        /// <summary>
        /// CPB74PRMQ.
        /// </summary>
        public const string CPB74PRMQ = "CPB74PRMQ";

        /// <summary>
        /// CPB74PRYR.
        /// </summary>
        public const string CPB74PRYR = "CPB74PRYR";

        /// <summary>
        /// CPCO.
        /// </summary>
        public const string CPCO = "CPCO";

        /// <summary>
        /// CPATXA.
        /// </summary>
        public const string CPATXA = "CPATXA";

        /// <summary>
        /// CPB74PRPA.
        /// </summary>
        public const string CPB74PRPA = "CPB74PRPA";

        /// <summary>
        /// CPB74PRPC.
        /// </summary>
        public const string CPB74PRPC = "CPB74PRPC";

        /// <summary>
        /// CPB74PRCP.
        /// </summary>
        public const string CPB74PRCP = "CPB74PRCP";

        /// <summary>
        /// CPURCD.
        /// </summary>
        public const string CPURCD = "CPURCD";

        /// <summary>
        /// CPURDT.
        /// </summary>
        public const string CPURDT = "CPURDT";

        /// <summary>
        /// CPURAT.
        /// </summary>
        public const string CPURAT = "CPURAT";

        /// <summary>
        /// CPURAB.
        /// </summary>
        public const string CPURAB = "CPURAB";

        /// <summary>
        /// CPURRF.
        /// </summary>
        public const string CPURRF = "CPURRF";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";

        /// <summary>
        /// CPCRCD.
        /// </summary>
        public const string CPCRCD = "CPCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F74B250";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CP74TRAN", "CP74TRAN", JdeDataType.String, 60, true, true),
        new JdeField("CP74KCTR", "CP74KCTR", JdeDataType.String, 6, true, true),
        new JdeField("CP74KVAT", "CP74KVAT", JdeDataType.String, 40, true, true),
        new JdeField("CP74CCTR", "CP74CCTR", JdeDataType.String, 6, true, true),
        new JdeField("CP74CVAT", "CP74CVAT", JdeDataType.String, 40, true, true),
        new JdeField("CP74TRTN", "CP74TRTN", JdeDataType.String, 2, true, true),
        new JdeField("CPB74PRMQ", "CPB74PRMQ", JdeDataType.String, 4, true, true),
        new JdeField("CPB74PRYR", "CPB74PRYR", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCO", "CPCO", JdeDataType.String, 10),
        new JdeField("CPATXA", "CPATXA", JdeDataType.Numeric),
        new JdeField("CPB74PRPA", "CPB74PRPA", JdeDataType.Numeric),
        new JdeField("CPB74PRPC", "CPB74PRPC", JdeDataType.String, 2),
        new JdeField("CPB74PRCP", "CPB74PRCP", JdeDataType.String, 2),
        new JdeField("CPURCD", "CPURCD", JdeDataType.String, 4),
        new JdeField("CPURDT", "CPURDT", JdeDataType.Numeric),
        new JdeField("CPURAT", "CPURAT", JdeDataType.Numeric),
        new JdeField("CPURAB", "CPURAB", JdeDataType.Numeric),
        new JdeField("CPURRF", "CPURRF", JdeDataType.String, 30),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric),
        new JdeField("CPCRCD", "CPCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74B250_0", "Primary Key on CP74TRAN, CP74KCTR, CP74KVAT, CP74CCTR, CP74CVAT, CP74TRTN, CPB74PRMQ, CPB74PRYR", new[] { "CP74TRAN", "CP74KCTR", "CP74KVAT", "CP74CCTR", "CP74CVAT", "CP74TRTN", "CPB74PRMQ", "CPB74PRYR" }, isUnique: true, isPrimaryKey: true)
    };
}
