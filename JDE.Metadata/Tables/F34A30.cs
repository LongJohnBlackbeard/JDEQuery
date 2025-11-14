using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A30 - .
/// </summary>
public class F34A30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0SY.
        /// </summary>
        public const string N0SY = "N0SY";

        /// <summary>
        /// N0RT.
        /// </summary>
        public const string N0RT = "N0RT";

        /// <summary>
        /// N0DL01.
        /// </summary>
        public const string N0DL01 = "N0DL01";

        /// <summary>
        /// N0KY.
        /// </summary>
        public const string N0KY = "N0KY";

        /// <summary>
        /// N0DL02.
        /// </summary>
        public const string N0DL02 = "N0DL02";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0TDAY.
        /// </summary>
        public const string N0TDAY = "N0TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34A30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0SY", "N0SY", JdeDataType.String, 8, true, true),
        new JdeField("N0RT", "N0RT", JdeDataType.String, 4, true, true),
        new JdeField("N0DL01", "N0DL01", JdeDataType.String, 60),
        new JdeField("N0KY", "N0KY", JdeDataType.String, 20, true, true),
        new JdeField("N0DL02", "N0DL02", JdeDataType.String, 60),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0TDAY", "N0TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A30_0", "Primary Key on N0SY, N0RT, N0KY", new[] { "N0SY", "N0RT", "N0KY" }, isUnique: true, isPrimaryKey: true)
    };
}
