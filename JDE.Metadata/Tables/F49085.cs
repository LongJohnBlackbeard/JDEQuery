using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49085 - .
/// </summary>
public class F49085 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDINCY.
        /// </summary>
        public const string IDINCY = "IDINCY";

        /// <summary>
        /// IDDTEY.
        /// </summary>
        public const string IDDTEY = "IDDTEY";

        /// <summary>
        /// IDEFTJ.
        /// </summary>
        public const string IDEFTJ = "IDEFTJ";

        /// <summary>
        /// IDEXDJ.
        /// </summary>
        public const string IDEXDJ = "IDEXDJ";

        /// <summary>
        /// IDIVD.
        /// </summary>
        public const string IDIVD = "IDIVD";
    }

    /// <inheritdoc />
    public override string TableName => "F49085";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDINCY", "IDINCY", JdeDataType.String, 6, true, true),
        new JdeField("IDDTEY", "IDDTEY", JdeDataType.Numeric),
        new JdeField("IDEFTJ", "IDEFTJ", JdeDataType.Numeric),
        new JdeField("IDEXDJ", "IDEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IDIVD", "IDIVD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49085_0", "Primary Key on IDINCY, IDEXDJ", new[] { "IDINCY", "IDEXDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49085_2", "Index on IDINCY, IDDTEY, IDEXDJ", new[] { "IDINCY", "IDDTEY", "IDEXDJ" })
    };
}
