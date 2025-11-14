using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49015 - .
/// </summary>
public class F49015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STVEHI.
        /// </summary>
        public const string STVEHI = "STVEHI";

        /// <summary>
        /// STVSTA.
        /// </summary>
        public const string STVSTA = "STVSTA";

        /// <summary>
        /// STEFTJ.
        /// </summary>
        public const string STEFTJ = "STEFTJ";

        /// <summary>
        /// STEXDJ.
        /// </summary>
        public const string STEXDJ = "STEXDJ";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STTDAY.
        /// </summary>
        public const string STTDAY = "STTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STVEHI", "STVEHI", JdeDataType.String, 24, true, true),
        new JdeField("STVSTA", "STVSTA", JdeDataType.String, 6, true, true),
        new JdeField("STEFTJ", "STEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("STEXDJ", "STEXDJ", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STTDAY", "STTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49015_0", "Primary Key on STVEHI, STEFTJ, STVSTA", new[] { "STVEHI", "STEFTJ", "STVSTA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49015_2", "Index on STVEHI, STEFTJ, STEXDJ", new[] { "STVEHI", "STEFTJ", "STEXDJ" })
    };
}
