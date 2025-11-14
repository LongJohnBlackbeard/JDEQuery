using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F415311 - .
/// </summary>
public class F415311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T3STPU.
        /// </summary>
        public const string T3STPU = "T3STPU";

        /// <summary>
        /// T3TEMP.
        /// </summary>
        public const string T3TEMP = "T3TEMP";

        /// <summary>
        /// T3CRAF.
        /// </summary>
        public const string T3CRAF = "T3CRAF";

        /// <summary>
        /// T3CRBF.
        /// </summary>
        public const string T3CRBF = "T3CRBF";

        /// <summary>
        /// T3USER.
        /// </summary>
        public const string T3USER = "T3USER";

        /// <summary>
        /// T3PID.
        /// </summary>
        public const string T3PID = "T3PID";

        /// <summary>
        /// T3JOBN.
        /// </summary>
        public const string T3JOBN = "T3JOBN";

        /// <summary>
        /// T3UPMJ.
        /// </summary>
        public const string T3UPMJ = "T3UPMJ";

        /// <summary>
        /// T3TDAY.
        /// </summary>
        public const string T3TDAY = "T3TDAY";

        /// <summary>
        /// T3URCD.
        /// </summary>
        public const string T3URCD = "T3URCD";

        /// <summary>
        /// T3URAT.
        /// </summary>
        public const string T3URAT = "T3URAT";

        /// <summary>
        /// T3URAB.
        /// </summary>
        public const string T3URAB = "T3URAB";

        /// <summary>
        /// T3URRF.
        /// </summary>
        public const string T3URRF = "T3URRF";

        /// <summary>
        /// T3URDT.
        /// </summary>
        public const string T3URDT = "T3URDT";
    }

    /// <inheritdoc />
    public override string TableName => "F415311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T3STPU", "T3STPU", JdeDataType.String, 2, true, true),
        new JdeField("T3TEMP", "T3TEMP", JdeDataType.Numeric, null, true, true),
        new JdeField("T3CRAF", "T3CRAF", JdeDataType.Numeric, null, true, true),
        new JdeField("T3CRBF", "T3CRBF", JdeDataType.Numeric, null, true, true),
        new JdeField("T3USER", "T3USER", JdeDataType.String, 20),
        new JdeField("T3PID", "T3PID", JdeDataType.String, 20),
        new JdeField("T3JOBN", "T3JOBN", JdeDataType.String, 20),
        new JdeField("T3UPMJ", "T3UPMJ", JdeDataType.Numeric),
        new JdeField("T3TDAY", "T3TDAY", JdeDataType.Numeric),
        new JdeField("T3URCD", "T3URCD", JdeDataType.String, 4),
        new JdeField("T3URAT", "T3URAT", JdeDataType.Numeric),
        new JdeField("T3URAB", "T3URAB", JdeDataType.Numeric),
        new JdeField("T3URRF", "T3URRF", JdeDataType.String, 30),
        new JdeField("T3URDT", "T3URDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F415311_0", "Primary Key on T3STPU, T3TEMP, T3CRAF, T3CRBF", new[] { "T3STPU", "T3TEMP", "T3CRAF", "T3CRBF" }, isUnique: true, isPrimaryKey: true)
    };
}
