using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A11 - .
/// </summary>
public class F34A11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N1KEY.
        /// </summary>
        public const string N1KEY = "N1KEY";

        /// <summary>
        /// N1NFLF.
        /// </summary>
        public const string N1NFLF = "N1NFLF";

        /// <summary>
        /// N1FFU2.
        /// </summary>
        public const string N1FFU2 = "N1FFU2";

        /// <summary>
        /// N1X1.
        /// </summary>
        public const string N1X1 = "N1X1";

        /// <summary>
        /// N1X2.
        /// </summary>
        public const string N1X2 = "N1X2";

        /// <summary>
        /// N1URCD.
        /// </summary>
        public const string N1URCD = "N1URCD";

        /// <summary>
        /// N1URDT.
        /// </summary>
        public const string N1URDT = "N1URDT";

        /// <summary>
        /// N1URAT.
        /// </summary>
        public const string N1URAT = "N1URAT";

        /// <summary>
        /// N1URAB.
        /// </summary>
        public const string N1URAB = "N1URAB";

        /// <summary>
        /// N1URRF.
        /// </summary>
        public const string N1URRF = "N1URRF";

        /// <summary>
        /// N1USER.
        /// </summary>
        public const string N1USER = "N1USER";

        /// <summary>
        /// N1PID.
        /// </summary>
        public const string N1PID = "N1PID";

        /// <summary>
        /// N1JOBN.
        /// </summary>
        public const string N1JOBN = "N1JOBN";

        /// <summary>
        /// N1UPMJ.
        /// </summary>
        public const string N1UPMJ = "N1UPMJ";

        /// <summary>
        /// N1TDAY.
        /// </summary>
        public const string N1TDAY = "N1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34A11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N1KEY", "N1KEY", JdeDataType.String, 20, true, true),
        new JdeField("N1NFLF", "N1NFLF", JdeDataType.String, 500),
        new JdeField("N1FFU2", "N1FFU2", JdeDataType.String, 2),
        new JdeField("N1X1", "N1X1", JdeDataType.String, 2),
        new JdeField("N1X2", "N1X2", JdeDataType.String, 2),
        new JdeField("N1URCD", "N1URCD", JdeDataType.String, 4),
        new JdeField("N1URDT", "N1URDT", JdeDataType.Numeric),
        new JdeField("N1URAT", "N1URAT", JdeDataType.Numeric),
        new JdeField("N1URAB", "N1URAB", JdeDataType.Numeric),
        new JdeField("N1URRF", "N1URRF", JdeDataType.String, 30),
        new JdeField("N1USER", "N1USER", JdeDataType.String, 20),
        new JdeField("N1PID", "N1PID", JdeDataType.String, 20),
        new JdeField("N1JOBN", "N1JOBN", JdeDataType.String, 20),
        new JdeField("N1UPMJ", "N1UPMJ", JdeDataType.Numeric),
        new JdeField("N1TDAY", "N1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A11_0", "Primary Key on N1KEY", new[] { "N1KEY" }, isUnique: true, isPrimaryKey: true)
    };
}
