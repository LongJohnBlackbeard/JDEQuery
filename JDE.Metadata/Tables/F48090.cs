using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48090 - .
/// </summary>
public class F48090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W7WODB.
        /// </summary>
        public const string W7WODB = "W7WODB";

        /// <summary>
        /// W7TYWO.
        /// </summary>
        public const string W7TYWO = "W7TYWO";

        /// <summary>
        /// W7DSPF.
        /// </summary>
        public const string W7DSPF = "W7DSPF";

        /// <summary>
        /// W7DL01.
        /// </summary>
        public const string W7DL01 = "W7DL01";

        /// <summary>
        /// W7SY.
        /// </summary>
        public const string W7SY = "W7SY";

        /// <summary>
        /// W7RT.
        /// </summary>
        public const string W7RT = "W7RT";

        /// <summary>
        /// W7GDC0.
        /// </summary>
        public const string W7GDC0 = "W7GDC0";

        /// <summary>
        /// W7GDC1.
        /// </summary>
        public const string W7GDC1 = "W7GDC1";

        /// <summary>
        /// W7GDC2.
        /// </summary>
        public const string W7GDC2 = "W7GDC2";

        /// <summary>
        /// W7GDC3.
        /// </summary>
        public const string W7GDC3 = "W7GDC3";

        /// <summary>
        /// W7GDC5.
        /// </summary>
        public const string W7GDC5 = "W7GDC5";

        /// <summary>
        /// W7GDC6.
        /// </summary>
        public const string W7GDC6 = "W7GDC6";

        /// <summary>
        /// W7GDC8.
        /// </summary>
        public const string W7GDC8 = "W7GDC8";

        /// <summary>
        /// W7GDC9.
        /// </summary>
        public const string W7GDC9 = "W7GDC9";

        /// <summary>
        /// W7USER.
        /// </summary>
        public const string W7USER = "W7USER";

        /// <summary>
        /// W7PID.
        /// </summary>
        public const string W7PID = "W7PID";

        /// <summary>
        /// W7UPMJ.
        /// </summary>
        public const string W7UPMJ = "W7UPMJ";

        /// <summary>
        /// W7TDAY.
        /// </summary>
        public const string W7TDAY = "W7TDAY";

        /// <summary>
        /// W7JOBN.
        /// </summary>
        public const string W7JOBN = "W7JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F48090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W7WODB", "W7WODB", JdeDataType.String, 2, true, true),
        new JdeField("W7TYWO", "W7TYWO", JdeDataType.String, 4, true, true),
        new JdeField("W7DSPF", "W7DSPF", JdeDataType.String, 2),
        new JdeField("W7DL01", "W7DL01", JdeDataType.String, 60),
        new JdeField("W7SY", "W7SY", JdeDataType.String, 8),
        new JdeField("W7RT", "W7RT", JdeDataType.String, 4),
        new JdeField("W7GDC0", "W7GDC0", JdeDataType.String, 20),
        new JdeField("W7GDC1", "W7GDC1", JdeDataType.String, 20),
        new JdeField("W7GDC2", "W7GDC2", JdeDataType.String, 20),
        new JdeField("W7GDC3", "W7GDC3", JdeDataType.String, 60),
        new JdeField("W7GDC5", "W7GDC5", JdeDataType.String, 20),
        new JdeField("W7GDC6", "W7GDC6", JdeDataType.String, 20),
        new JdeField("W7GDC8", "W7GDC8", JdeDataType.String, 20),
        new JdeField("W7GDC9", "W7GDC9", JdeDataType.String, 20),
        new JdeField("W7USER", "W7USER", JdeDataType.String, 20),
        new JdeField("W7PID", "W7PID", JdeDataType.String, 20),
        new JdeField("W7UPMJ", "W7UPMJ", JdeDataType.Numeric),
        new JdeField("W7TDAY", "W7TDAY", JdeDataType.Numeric),
        new JdeField("W7JOBN", "W7JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48090_0", "Primary Key on W7WODB, W7TYWO", new[] { "W7WODB", "W7TYWO" }, isUnique: true, isPrimaryKey: true)
    };
}
