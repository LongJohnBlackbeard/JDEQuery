using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41008D - .
/// </summary>
public class F41008D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S0SEG1.
        /// </summary>
        public const string S0SEG1 = "S0SEG1";

        /// <summary>
        /// S0MRNO.
        /// </summary>
        public const string S0MRNO = "S0MRNO";

        /// <summary>
        /// S0MCNO.
        /// </summary>
        public const string S0MCNO = "S0MCNO";

        /// <summary>
        /// S0LNGP.
        /// </summary>
        public const string S0LNGP = "S0LNGP";

        /// <summary>
        /// S0ITM.
        /// </summary>
        public const string S0ITM = "S0ITM";

        /// <summary>
        /// S0SGD1.
        /// </summary>
        public const string S0SGD1 = "S0SGD1";

        /// <summary>
        /// S0SGD2.
        /// </summary>
        public const string S0SGD2 = "S0SGD2";

        /// <summary>
        /// S0SGD3.
        /// </summary>
        public const string S0SGD3 = "S0SGD3";

        /// <summary>
        /// S0SGD4.
        /// </summary>
        public const string S0SGD4 = "S0SGD4";

        /// <summary>
        /// S0SGD5.
        /// </summary>
        public const string S0SGD5 = "S0SGD5";

        /// <summary>
        /// S0SGD6.
        /// </summary>
        public const string S0SGD6 = "S0SGD6";

        /// <summary>
        /// S0SGD7.
        /// </summary>
        public const string S0SGD7 = "S0SGD7";

        /// <summary>
        /// S0SGD8.
        /// </summary>
        public const string S0SGD8 = "S0SGD8";

        /// <summary>
        /// S0SGD9.
        /// </summary>
        public const string S0SGD9 = "S0SGD9";

        /// <summary>
        /// S0SGD0.
        /// </summary>
        public const string S0SGD0 = "S0SGD0";

        /// <summary>
        /// S0USER.
        /// </summary>
        public const string S0USER = "S0USER";

        /// <summary>
        /// S0PID.
        /// </summary>
        public const string S0PID = "S0PID";

        /// <summary>
        /// S0JOBN.
        /// </summary>
        public const string S0JOBN = "S0JOBN";

        /// <summary>
        /// S0UPMJ.
        /// </summary>
        public const string S0UPMJ = "S0UPMJ";

        /// <summary>
        /// S0TDAY.
        /// </summary>
        public const string S0TDAY = "S0TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41008D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S0SEG1", "S0SEG1", JdeDataType.String, 20, true, true),
        new JdeField("S0MRNO", "S0MRNO", JdeDataType.Numeric, null, true, true),
        new JdeField("S0MCNO", "S0MCNO", JdeDataType.Numeric, null, true, true),
        new JdeField("S0LNGP", "S0LNGP", JdeDataType.String, 4, true, true),
        new JdeField("S0ITM", "S0ITM", JdeDataType.Numeric),
        new JdeField("S0SGD1", "S0SGD1", JdeDataType.String, 30),
        new JdeField("S0SGD2", "S0SGD2", JdeDataType.String, 30),
        new JdeField("S0SGD3", "S0SGD3", JdeDataType.String, 30),
        new JdeField("S0SGD4", "S0SGD4", JdeDataType.String, 30),
        new JdeField("S0SGD5", "S0SGD5", JdeDataType.String, 30),
        new JdeField("S0SGD6", "S0SGD6", JdeDataType.String, 30),
        new JdeField("S0SGD7", "S0SGD7", JdeDataType.String, 30),
        new JdeField("S0SGD8", "S0SGD8", JdeDataType.String, 30),
        new JdeField("S0SGD9", "S0SGD9", JdeDataType.String, 30),
        new JdeField("S0SGD0", "S0SGD0", JdeDataType.String, 30),
        new JdeField("S0USER", "S0USER", JdeDataType.String, 20),
        new JdeField("S0PID", "S0PID", JdeDataType.String, 20),
        new JdeField("S0JOBN", "S0JOBN", JdeDataType.String, 20),
        new JdeField("S0UPMJ", "S0UPMJ", JdeDataType.Numeric),
        new JdeField("S0TDAY", "S0TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41008D_0", "Primary Key on S0SEG1, S0MRNO, S0MCNO, S0LNGP", new[] { "S0SEG1", "S0MRNO", "S0MCNO", "S0LNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41008D_3", "Index on S0ITM", new[] { "S0ITM" })
    };
}
