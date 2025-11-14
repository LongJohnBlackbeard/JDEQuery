using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1391 - .
/// </summary>
public class F1391 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F8MAPT.
        /// </summary>
        public const string F8MAPT = "F8MAPT";

        /// <summary>
        /// F8MTCC.
        /// </summary>
        public const string F8MTCC = "F8MTCC";

        /// <summary>
        /// F8MFCC.
        /// </summary>
        public const string F8MFCC = "F8MFCC";
    }

    /// <inheritdoc />
    public override string TableName => "F1391";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F8MAPT", "F8MAPT", JdeDataType.String, 2, true, true),
        new JdeField("F8MTCC", "F8MTCC", JdeDataType.Numeric, null, true, true),
        new JdeField("F8MFCC", "F8MFCC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1391_0", "Primary Key on F8MAPT, F8MTCC", new[] { "F8MAPT", "F8MTCC" }, isUnique: true, isPrimaryKey: true)
    };
}
