using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51002 - .
/// </summary>
public class F51002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GKMCU.
        /// </summary>
        public const string GKMCU = "GKMCU";

        /// <summary>
        /// GKN001.
        /// </summary>
        public const string GKN001 = "GKN001";

        /// <summary>
        /// GKJCNN1.
        /// </summary>
        public const string GKJCNN1 = "GKJCNN1";

        /// <summary>
        /// GKJCNN2.
        /// </summary>
        public const string GKJCNN2 = "GKJCNN2";
    }

    /// <inheritdoc />
    public override string TableName => "F51002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GKMCU", "GKMCU", JdeDataType.String, 24, true, true),
        new JdeField("GKN001", "GKN001", JdeDataType.Numeric),
        new JdeField("GKJCNN1", "GKJCNN1", JdeDataType.String, 2),
        new JdeField("GKJCNN2", "GKJCNN2", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51002_0", "Primary Key on GKMCU", new[] { "GKMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
