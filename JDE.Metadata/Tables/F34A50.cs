using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A50 - .
/// </summary>
public class F34A50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IEOPERROR.
        /// </summary>
        public const string IEOPERROR = "IEOPERROR";

        /// <summary>
        /// IEOWERROR.
        /// </summary>
        public const string IEOWERROR = "IEOWERROR";
    }

    /// <inheritdoc />
    public override string TableName => "F34A50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IEOPERROR", "IEOPERROR", JdeDataType.String, 80, true, true),
        new JdeField("IEOWERROR", "IEOWERROR", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A50_0", "Primary Key on IEOPERROR", new[] { "IEOPERROR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A50_2", "Index on IEOWERROR", new[] { "IEOWERROR" })
    };
}
