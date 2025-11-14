using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46821 - .
/// </summary>
public class F46821 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LXMCU.
        /// </summary>
        public const string LXMCU = "LXMCU";

        /// <summary>
        /// LXSRUL.
        /// </summary>
        public const string LXSRUL = "LXSRUL";

        /// <summary>
        /// LXLOCN.
        /// </summary>
        public const string LXLOCN = "LXLOCN";

        /// <summary>
        /// LXSEQ.
        /// </summary>
        public const string LXSEQ = "LXSEQ";

        /// <summary>
        /// LXUSER.
        /// </summary>
        public const string LXUSER = "LXUSER";

        /// <summary>
        /// LXUPMJ.
        /// </summary>
        public const string LXUPMJ = "LXUPMJ";

        /// <summary>
        /// LXTDAY.
        /// </summary>
        public const string LXTDAY = "LXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46821";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LXMCU", "LXMCU", JdeDataType.String, 24, true, true),
        new JdeField("LXSRUL", "LXSRUL", JdeDataType.String, 12, true, true),
        new JdeField("LXLOCN", "LXLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LXSEQ", "LXSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LXUSER", "LXUSER", JdeDataType.String, 20),
        new JdeField("LXUPMJ", "LXUPMJ", JdeDataType.Numeric),
        new JdeField("LXTDAY", "LXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46821_0", "Primary Key on LXMCU, LXSRUL, LXSEQ, LXLOCN", new[] { "LXMCU", "LXSRUL", "LXSEQ", "LXLOCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46821_2", "Index on LXMCU, LXSRUL, LXLOCN", new[] { "LXMCU", "LXSRUL", "LXLOCN" }),
        new JdeIndex("F46821_3", "Index on LXMCU, LXLOCN, LXSRUL", new[] { "LXMCU", "LXLOCN", "LXSRUL" })
    };
}
