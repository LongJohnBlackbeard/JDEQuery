using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760472A - .
/// </summary>
public class F760472A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K9HDC.
        /// </summary>
        public const string K9HDC = "K9HDC";

        /// <summary>
        /// K9CKC.
        /// </summary>
        public const string K9CKC = "K9CKC";

        /// <summary>
        /// K9AOP.
        /// </summary>
        public const string K9AOP = "K9AOP";

        /// <summary>
        /// K9DMTJ.
        /// </summary>
        public const string K9DMTJ = "K9DMTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F760472A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K9HDC", "K9HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("K9CKC", "K9CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("K9AOP", "K9AOP", JdeDataType.Numeric),
        new JdeField("K9DMTJ", "K9DMTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760472A_0", "Primary Key on K9HDC, K9CKC", new[] { "K9HDC", "K9CKC" }, isUnique: true, isPrimaryKey: true)
    };
}
