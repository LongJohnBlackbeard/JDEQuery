using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1306P - .
/// </summary>
public class F1306P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F5NUMB.
        /// </summary>
        public const string F5NUMB = "F5NUMB";

        /// <summary>
        /// F5APID.
        /// </summary>
        public const string F5APID = "F5APID";

        /// <summary>
        /// F5ASID.
        /// </summary>
        public const string F5ASID = "F5ASID";

        /// <summary>
        /// F5EFR.
        /// </summary>
        public const string F5EFR = "F5EFR";

        /// <summary>
        /// F5EMR.
        /// </summary>
        public const string F5EMR = "F5EMR";

        /// <summary>
        /// F5EOR.
        /// </summary>
        public const string F5EOR = "F5EOR";

        /// <summary>
        /// F5SBL.
        /// </summary>
        public const string F5SBL = "F5SBL";

        /// <summary>
        /// F5SBLT.
        /// </summary>
        public const string F5SBLT = "F5SBLT";

        /// <summary>
        /// F5UPMJ.
        /// </summary>
        public const string F5UPMJ = "F5UPMJ";

        /// <summary>
        /// F5UPMT.
        /// </summary>
        public const string F5UPMT = "F5UPMT";

        /// <summary>
        /// F5USER.
        /// </summary>
        public const string F5USER = "F5USER";

        /// <summary>
        /// F5PID.
        /// </summary>
        public const string F5PID = "F5PID";

        /// <summary>
        /// F5JOBN.
        /// </summary>
        public const string F5JOBN = "F5JOBN";

        /// <summary>
        /// F5EM4R.
        /// </summary>
        public const string F5EM4R = "F5EM4R";

        /// <summary>
        /// F5EM5R.
        /// </summary>
        public const string F5EM5R = "F5EM5R";

        /// <summary>
        /// F5EM6R.
        /// </summary>
        public const string F5EM6R = "F5EM6R";
    }

    /// <inheritdoc />
    public override string TableName => "F1306P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F5NUMB", "F5NUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("F5APID", "F5APID", JdeDataType.String, 24),
        new JdeField("F5ASID", "F5ASID", JdeDataType.String, 50),
        new JdeField("F5EFR", "F5EFR", JdeDataType.Numeric),
        new JdeField("F5EMR", "F5EMR", JdeDataType.Numeric),
        new JdeField("F5EOR", "F5EOR", JdeDataType.Numeric),
        new JdeField("F5SBL", "F5SBL", JdeDataType.String, 16, true, true),
        new JdeField("F5SBLT", "F5SBLT", JdeDataType.String, 2, true, true),
        new JdeField("F5UPMJ", "F5UPMJ", JdeDataType.Numeric),
        new JdeField("F5UPMT", "F5UPMT", JdeDataType.Numeric),
        new JdeField("F5USER", "F5USER", JdeDataType.String, 20),
        new JdeField("F5PID", "F5PID", JdeDataType.String, 20),
        new JdeField("F5JOBN", "F5JOBN", JdeDataType.String, 20),
        new JdeField("F5EM4R", "F5EM4R", JdeDataType.Numeric),
        new JdeField("F5EM5R", "F5EM5R", JdeDataType.Numeric),
        new JdeField("F5EM6R", "F5EM6R", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1306P_0", "Primary Key on F5NUMB, F5SBL, F5SBLT", new[] { "F5NUMB", "F5SBL", "F5SBLT" }, isUnique: true, isPrimaryKey: true)
    };
}
