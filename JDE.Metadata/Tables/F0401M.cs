using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0401M - .
/// </summary>
public class F0401M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A6AN8.
        /// </summary>
        public const string A6AN8 = "A6AN8";

        /// <summary>
        /// A6BKTP.
        /// </summary>
        public const string A6BKTP = "A6BKTP";

        /// <summary>
        /// A6AB1.
        /// </summary>
        public const string A6AB1 = "A6AB1";
    }

    /// <inheritdoc />
    public override string TableName => "F0401M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A6AN8", "A6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A6BKTP", "A6BKTP", JdeDataType.String, 2, true, true),
        new JdeField("A6AB1", "A6AB1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0401M_0", "Primary Key on A6AN8, A6BKTP", new[] { "A6AN8", "A6BKTP" }, isUnique: true, isPrimaryKey: true)
    };
}
