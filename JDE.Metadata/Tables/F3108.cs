using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3108 - .
/// </summary>
public class F3108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SJJDOC.
        /// </summary>
        public const string SJJDOC = "SJJDOC";

        /// <summary>
        /// SJDOCO.
        /// </summary>
        public const string SJDOCO = "SJDOCO";

        /// <summary>
        /// SJICU.
        /// </summary>
        public const string SJICU = "SJICU";

        /// <summary>
        /// SJDICJ.
        /// </summary>
        public const string SJDICJ = "SJDICJ";

        /// <summary>
        /// SJDGJ.
        /// </summary>
        public const string SJDGJ = "SJDGJ";

        /// <summary>
        /// SJUSER.
        /// </summary>
        public const string SJUSER = "SJUSER";

        /// <summary>
        /// SJPID.
        /// </summary>
        public const string SJPID = "SJPID";

        /// <summary>
        /// SJJOBN.
        /// </summary>
        public const string SJJOBN = "SJJOBN";

        /// <summary>
        /// SJUPMJ.
        /// </summary>
        public const string SJUPMJ = "SJUPMJ";

        /// <summary>
        /// SJTDAY.
        /// </summary>
        public const string SJTDAY = "SJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SJJDOC", "SJJDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SJDOCO", "SJDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SJICU", "SJICU", JdeDataType.Numeric),
        new JdeField("SJDICJ", "SJDICJ", JdeDataType.Numeric),
        new JdeField("SJDGJ", "SJDGJ", JdeDataType.Numeric),
        new JdeField("SJUSER", "SJUSER", JdeDataType.String, 20),
        new JdeField("SJPID", "SJPID", JdeDataType.String, 20),
        new JdeField("SJJOBN", "SJJOBN", JdeDataType.String, 20),
        new JdeField("SJUPMJ", "SJUPMJ", JdeDataType.Numeric),
        new JdeField("SJTDAY", "SJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3108_0", "Primary Key on SJJDOC, SJDOCO", new[] { "SJJDOC", "SJDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3108_2", "Index on SJDOCO, SJJDOC", new[] { "SJDOCO", "SJJDOC" })
    };
}
