using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186201 - .
/// </summary>
public class F186201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EGLRSEGID.
        /// </summary>
        public const string EGLRSEGID = "EGLRSEGID";

        /// <summary>
        /// EGLRSEGN.
        /// </summary>
        public const string EGLRSEGN = "EGLRSEGN";

        /// <summary>
        /// EGLRSEGT.
        /// </summary>
        public const string EGLRSEGT = "EGLRSEGT";

        /// <summary>
        /// EGLRSEGXG.
        /// </summary>
        public const string EGLRSEGXG = "EGLRSEGXG";

        /// <summary>
        /// EGLRSEGST.
        /// </summary>
        public const string EGLRSEGST = "EGLRSEGST";

        /// <summary>
        /// EGUSER.
        /// </summary>
        public const string EGUSER = "EGUSER";

        /// <summary>
        /// EGPID.
        /// </summary>
        public const string EGPID = "EGPID";

        /// <summary>
        /// EGJOBN.
        /// </summary>
        public const string EGJOBN = "EGJOBN";

        /// <summary>
        /// EGUPMJ.
        /// </summary>
        public const string EGUPMJ = "EGUPMJ";

        /// <summary>
        /// EGTDAY.
        /// </summary>
        public const string EGTDAY = "EGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EGLRSEGID", "EGLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("EGLRSEGN", "EGLRSEGN", JdeDataType.String, 60),
        new JdeField("EGLRSEGT", "EGLRSEGT", JdeDataType.String, 12),
        new JdeField("EGLRSEGXG", "EGLRSEGXG", JdeDataType.Numeric),
        new JdeField("EGLRSEGST", "EGLRSEGST", JdeDataType.String, 20),
        new JdeField("EGUSER", "EGUSER", JdeDataType.String, 20),
        new JdeField("EGPID", "EGPID", JdeDataType.String, 20),
        new JdeField("EGJOBN", "EGJOBN", JdeDataType.String, 20),
        new JdeField("EGUPMJ", "EGUPMJ", JdeDataType.Numeric),
        new JdeField("EGTDAY", "EGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186201_0", "Primary Key on EGLRSEGID", new[] { "EGLRSEGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186201_2", "Unique Index on EGLRSEGN", new[] { "EGLRSEGN" }, isUnique: true)
    };
}
