using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A80 - .
/// </summary>
public class F34A80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0DL01.
        /// </summary>
        public const string N0DL01 = "N0DL01";

        /// <summary>
        /// N0DSC1.
        /// </summary>
        public const string N0DSC1 = "N0DSC1";

        /// <summary>
        /// N0TUOM.
        /// </summary>
        public const string N0TUOM = "N0TUOM";

        /// <summary>
        /// N0FTPF.
        /// </summary>
        public const string N0FTPF = "N0FTPF";

        /// <summary>
        /// N0APSREST.
        /// </summary>
        public const string N0APSREST = "N0APSREST";

        /// <summary>
        /// N0AVCAP.
        /// </summary>
        public const string N0AVCAP = "N0AVCAP";

        /// <summary>
        /// N0AVCAL.
        /// </summary>
        public const string N0AVCAL = "N0AVCAL";

        /// <summary>
        /// N0RESCD.
        /// </summary>
        public const string N0RESCD = "N0RESCD";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0UPMJ.
        /// </summary>
        public const string N0UPMJ = "N0UPMJ";

        /// <summary>
        /// N0TDAY.
        /// </summary>
        public const string N0TDAY = "N0TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34A80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0DL01", "N0DL01", JdeDataType.String, 60),
        new JdeField("N0DSC1", "N0DSC1", JdeDataType.String, 60),
        new JdeField("N0TUOM", "N0TUOM", JdeDataType.String, 2),
        new JdeField("N0FTPF", "N0FTPF", JdeDataType.Numeric),
        new JdeField("N0APSREST", "N0APSREST", JdeDataType.String, 2),
        new JdeField("N0AVCAP", "N0AVCAP", JdeDataType.Numeric),
        new JdeField("N0AVCAL", "N0AVCAL", JdeDataType.String, 60),
        new JdeField("N0RESCD", "N0RESCD", JdeDataType.String, 24, true, true),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0UPMJ", "N0UPMJ", JdeDataType.Numeric),
        new JdeField("N0TDAY", "N0TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A80_0", "Primary Key on N0RESCD", new[] { "N0RESCD" }, isUnique: true, isPrimaryKey: true)
    };
}
