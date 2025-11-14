using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41008 - .
/// </summary>
public class F41008 : JdeTable
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
        /// S0SEG2.
        /// </summary>
        public const string S0SEG2 = "S0SEG2";

        /// <summary>
        /// S0SEG3.
        /// </summary>
        public const string S0SEG3 = "S0SEG3";

        /// <summary>
        /// S0SEG4.
        /// </summary>
        public const string S0SEG4 = "S0SEG4";

        /// <summary>
        /// S0SEG5.
        /// </summary>
        public const string S0SEG5 = "S0SEG5";

        /// <summary>
        /// S0SEG6.
        /// </summary>
        public const string S0SEG6 = "S0SEG6";

        /// <summary>
        /// S0SEG7.
        /// </summary>
        public const string S0SEG7 = "S0SEG7";

        /// <summary>
        /// S0SEG8.
        /// </summary>
        public const string S0SEG8 = "S0SEG8";

        /// <summary>
        /// S0SEG9.
        /// </summary>
        public const string S0SEG9 = "S0SEG9";

        /// <summary>
        /// S0SEG0.
        /// </summary>
        public const string S0SEG0 = "S0SEG0";

        /// <summary>
        /// S0ITM.
        /// </summary>
        public const string S0ITM = "S0ITM";

        /// <summary>
        /// S0TMPL.
        /// </summary>
        public const string S0TMPL = "S0TMPL";

        /// <summary>
        /// S0URCD.
        /// </summary>
        public const string S0URCD = "S0URCD";

        /// <summary>
        /// S0URDT.
        /// </summary>
        public const string S0URDT = "S0URDT";

        /// <summary>
        /// S0URAT.
        /// </summary>
        public const string S0URAT = "S0URAT";

        /// <summary>
        /// S0URAB.
        /// </summary>
        public const string S0URAB = "S0URAB";

        /// <summary>
        /// S0URRF.
        /// </summary>
        public const string S0URRF = "S0URRF";

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
    }

    /// <inheritdoc />
    public override string TableName => "F41008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S0SEG1", "S0SEG1", JdeDataType.String, 20, true, true),
        new JdeField("S0MRNO", "S0MRNO", JdeDataType.Numeric, null, true, true),
        new JdeField("S0MCNO", "S0MCNO", JdeDataType.Numeric, null, true, true),
        new JdeField("S0SEG2", "S0SEG2", JdeDataType.String, 20),
        new JdeField("S0SEG3", "S0SEG3", JdeDataType.String, 20),
        new JdeField("S0SEG4", "S0SEG4", JdeDataType.String, 20),
        new JdeField("S0SEG5", "S0SEG5", JdeDataType.String, 20),
        new JdeField("S0SEG6", "S0SEG6", JdeDataType.String, 20),
        new JdeField("S0SEG7", "S0SEG7", JdeDataType.String, 20),
        new JdeField("S0SEG8", "S0SEG8", JdeDataType.String, 20),
        new JdeField("S0SEG9", "S0SEG9", JdeDataType.String, 20),
        new JdeField("S0SEG0", "S0SEG0", JdeDataType.String, 20),
        new JdeField("S0ITM", "S0ITM", JdeDataType.Numeric),
        new JdeField("S0TMPL", "S0TMPL", JdeDataType.String, 40),
        new JdeField("S0URCD", "S0URCD", JdeDataType.String, 4),
        new JdeField("S0URDT", "S0URDT", JdeDataType.Numeric),
        new JdeField("S0URAT", "S0URAT", JdeDataType.Numeric),
        new JdeField("S0URAB", "S0URAB", JdeDataType.Numeric),
        new JdeField("S0URRF", "S0URRF", JdeDataType.String, 30),
        new JdeField("S0USER", "S0USER", JdeDataType.String, 20),
        new JdeField("S0PID", "S0PID", JdeDataType.String, 20),
        new JdeField("S0JOBN", "S0JOBN", JdeDataType.String, 20),
        new JdeField("S0UPMJ", "S0UPMJ", JdeDataType.Numeric),
        new JdeField("S0TDAY", "S0TDAY", JdeDataType.Numeric),
        new JdeField("S0SGD1", "S0SGD1", JdeDataType.String, 30),
        new JdeField("S0SGD2", "S0SGD2", JdeDataType.String, 30),
        new JdeField("S0SGD3", "S0SGD3", JdeDataType.String, 30),
        new JdeField("S0SGD4", "S0SGD4", JdeDataType.String, 30),
        new JdeField("S0SGD5", "S0SGD5", JdeDataType.String, 30),
        new JdeField("S0SGD6", "S0SGD6", JdeDataType.String, 30),
        new JdeField("S0SGD7", "S0SGD7", JdeDataType.String, 30),
        new JdeField("S0SGD8", "S0SGD8", JdeDataType.String, 30),
        new JdeField("S0SGD9", "S0SGD9", JdeDataType.String, 30),
        new JdeField("S0SGD0", "S0SGD0", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41008_0", "Primary Key on S0SEG1, S0MRNO, S0MCNO", new[] { "S0SEG1", "S0MRNO", "S0MCNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41008_2", "Index on S0ITM", new[] { "S0ITM" })
    };
}
