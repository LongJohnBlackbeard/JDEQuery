using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41009 - .
/// </summary>
public class F41009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T9SEG1.
        /// </summary>
        public const string T9SEG1 = "T9SEG1";

        /// <summary>
        /// T9SEG2.
        /// </summary>
        public const string T9SEG2 = "T9SEG2";

        /// <summary>
        /// T9SEG3.
        /// </summary>
        public const string T9SEG3 = "T9SEG3";

        /// <summary>
        /// T9SEG4.
        /// </summary>
        public const string T9SEG4 = "T9SEG4";

        /// <summary>
        /// T9SEG5.
        /// </summary>
        public const string T9SEG5 = "T9SEG5";

        /// <summary>
        /// T9SEG6.
        /// </summary>
        public const string T9SEG6 = "T9SEG6";

        /// <summary>
        /// T9SEG7.
        /// </summary>
        public const string T9SEG7 = "T9SEG7";

        /// <summary>
        /// T9SEG8.
        /// </summary>
        public const string T9SEG8 = "T9SEG8";

        /// <summary>
        /// T9SEG9.
        /// </summary>
        public const string T9SEG9 = "T9SEG9";

        /// <summary>
        /// T9SEG0.
        /// </summary>
        public const string T9SEG0 = "T9SEG0";

        /// <summary>
        /// T9LITM.
        /// </summary>
        public const string T9LITM = "T9LITM";

        /// <summary>
        /// T9MITP.
        /// </summary>
        public const string T9MITP = "T9MITP";

        /// <summary>
        /// T9MRNO.
        /// </summary>
        public const string T9MRNO = "T9MRNO";

        /// <summary>
        /// T9MCNO.
        /// </summary>
        public const string T9MCNO = "T9MCNO";

        /// <summary>
        /// T9TMPL.
        /// </summary>
        public const string T9TMPL = "T9TMPL";

        /// <summary>
        /// T9URCD.
        /// </summary>
        public const string T9URCD = "T9URCD";

        /// <summary>
        /// T9URDT.
        /// </summary>
        public const string T9URDT = "T9URDT";

        /// <summary>
        /// T9URAB.
        /// </summary>
        public const string T9URAB = "T9URAB";

        /// <summary>
        /// T9URRF.
        /// </summary>
        public const string T9URRF = "T9URRF";

        /// <summary>
        /// T9USER.
        /// </summary>
        public const string T9USER = "T9USER";

        /// <summary>
        /// T9PID.
        /// </summary>
        public const string T9PID = "T9PID";

        /// <summary>
        /// T9JOBN.
        /// </summary>
        public const string T9JOBN = "T9JOBN";

        /// <summary>
        /// T9UPMJ.
        /// </summary>
        public const string T9UPMJ = "T9UPMJ";

        /// <summary>
        /// T9TDAY.
        /// </summary>
        public const string T9TDAY = "T9TDAY";

        /// <summary>
        /// T9SGD1.
        /// </summary>
        public const string T9SGD1 = "T9SGD1";

        /// <summary>
        /// T9SGD2.
        /// </summary>
        public const string T9SGD2 = "T9SGD2";

        /// <summary>
        /// T9SGD3.
        /// </summary>
        public const string T9SGD3 = "T9SGD3";

        /// <summary>
        /// T9SGD4.
        /// </summary>
        public const string T9SGD4 = "T9SGD4";

        /// <summary>
        /// T9SGD5.
        /// </summary>
        public const string T9SGD5 = "T9SGD5";

        /// <summary>
        /// T9SGD6.
        /// </summary>
        public const string T9SGD6 = "T9SGD6";

        /// <summary>
        /// T9SGD7.
        /// </summary>
        public const string T9SGD7 = "T9SGD7";

        /// <summary>
        /// T9SGD8.
        /// </summary>
        public const string T9SGD8 = "T9SGD8";

        /// <summary>
        /// T9SGD9.
        /// </summary>
        public const string T9SGD9 = "T9SGD9";

        /// <summary>
        /// T9SGD0.
        /// </summary>
        public const string T9SGD0 = "T9SGD0";

        /// <summary>
        /// T9MISQ1.
        /// </summary>
        public const string T9MISQ1 = "T9MISQ1";

        /// <summary>
        /// T9MISQ2.
        /// </summary>
        public const string T9MISQ2 = "T9MISQ2";

        /// <summary>
        /// T9MISQ3.
        /// </summary>
        public const string T9MISQ3 = "T9MISQ3";

        /// <summary>
        /// T9MISQ4.
        /// </summary>
        public const string T9MISQ4 = "T9MISQ4";

        /// <summary>
        /// T9MISQ5.
        /// </summary>
        public const string T9MISQ5 = "T9MISQ5";

        /// <summary>
        /// T9MISQ6.
        /// </summary>
        public const string T9MISQ6 = "T9MISQ6";

        /// <summary>
        /// T9MISQ7.
        /// </summary>
        public const string T9MISQ7 = "T9MISQ7";

        /// <summary>
        /// T9MISQ8.
        /// </summary>
        public const string T9MISQ8 = "T9MISQ8";

        /// <summary>
        /// T9MISQ9.
        /// </summary>
        public const string T9MISQ9 = "T9MISQ9";

        /// <summary>
        /// T9MISQ0.
        /// </summary>
        public const string T9MISQ0 = "T9MISQ0";
    }

    /// <inheritdoc />
    public override string TableName => "F41009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T9SEG1", "T9SEG1", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG2", "T9SEG2", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG3", "T9SEG3", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG4", "T9SEG4", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG5", "T9SEG5", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG6", "T9SEG6", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG7", "T9SEG7", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG8", "T9SEG8", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG9", "T9SEG9", JdeDataType.String, 20, true, true),
        new JdeField("T9SEG0", "T9SEG0", JdeDataType.String, 20, true, true),
        new JdeField("T9LITM", "T9LITM", JdeDataType.String, 50),
        new JdeField("T9MITP", "T9MITP", JdeDataType.String, 2),
        new JdeField("T9MRNO", "T9MRNO", JdeDataType.Numeric),
        new JdeField("T9MCNO", "T9MCNO", JdeDataType.Numeric),
        new JdeField("T9TMPL", "T9TMPL", JdeDataType.String, 40),
        new JdeField("T9URCD", "T9URCD", JdeDataType.String, 4),
        new JdeField("T9URDT", "T9URDT", JdeDataType.Numeric),
        new JdeField("T9URAB", "T9URAB", JdeDataType.Numeric),
        new JdeField("T9URRF", "T9URRF", JdeDataType.String, 30),
        new JdeField("T9USER", "T9USER", JdeDataType.String, 20),
        new JdeField("T9PID", "T9PID", JdeDataType.String, 20),
        new JdeField("T9JOBN", "T9JOBN", JdeDataType.String, 20),
        new JdeField("T9UPMJ", "T9UPMJ", JdeDataType.Numeric),
        new JdeField("T9TDAY", "T9TDAY", JdeDataType.Numeric),
        new JdeField("T9SGD1", "T9SGD1", JdeDataType.String, 30),
        new JdeField("T9SGD2", "T9SGD2", JdeDataType.String, 30),
        new JdeField("T9SGD3", "T9SGD3", JdeDataType.String, 30),
        new JdeField("T9SGD4", "T9SGD4", JdeDataType.String, 30),
        new JdeField("T9SGD5", "T9SGD5", JdeDataType.String, 30),
        new JdeField("T9SGD6", "T9SGD6", JdeDataType.String, 30),
        new JdeField("T9SGD7", "T9SGD7", JdeDataType.String, 30),
        new JdeField("T9SGD8", "T9SGD8", JdeDataType.String, 30),
        new JdeField("T9SGD9", "T9SGD9", JdeDataType.String, 30),
        new JdeField("T9SGD0", "T9SGD0", JdeDataType.String, 30),
        new JdeField("T9MISQ1", "T9MISQ1", JdeDataType.Numeric),
        new JdeField("T9MISQ2", "T9MISQ2", JdeDataType.Numeric),
        new JdeField("T9MISQ3", "T9MISQ3", JdeDataType.Numeric),
        new JdeField("T9MISQ4", "T9MISQ4", JdeDataType.Numeric),
        new JdeField("T9MISQ5", "T9MISQ5", JdeDataType.Numeric),
        new JdeField("T9MISQ6", "T9MISQ6", JdeDataType.Numeric),
        new JdeField("T9MISQ7", "T9MISQ7", JdeDataType.Numeric),
        new JdeField("T9MISQ8", "T9MISQ8", JdeDataType.Numeric),
        new JdeField("T9MISQ9", "T9MISQ9", JdeDataType.Numeric),
        new JdeField("T9MISQ0", "T9MISQ0", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41009_0", "Primary Key on T9SEG1, T9SEG2, T9SEG3, T9SEG4, T9SEG5, T9SEG6, T9SEG7, T9SEG8, T9SEG9, T9SEG0", new[] { "T9SEG1", "T9SEG2", "T9SEG3", "T9SEG4", "T9SEG5", "T9SEG6", "T9SEG7", "T9SEG8", "T9SEG9", "T9SEG0" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41009_2", "Index on T9SEG1, T9MRNO, T9MCNO", new[] { "T9SEG1", "T9MRNO", "T9MCNO" }),
        new JdeIndex("F41009_3", "Index on T9SEG1, T9MCNO", new[] { "T9SEG1", "T9MCNO" })
    };
}
