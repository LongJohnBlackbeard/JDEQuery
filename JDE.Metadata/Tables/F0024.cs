using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0024 - .
/// </summary>
public class F0024 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UGUSR1.
        /// </summary>
        public const string UGUSR1 = "UGUSR1";

        /// <summary>
        /// UGUSR2.
        /// </summary>
        public const string UGUSR2 = "UGUSR2";
    }

    /// <inheritdoc />
    public override string TableName => "F0024";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UGUSR1", "UGUSR1", JdeDataType.String, 20, true, true),
        new JdeField("UGUSR2", "UGUSR2", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0024_0", "Primary Key on UGUSR1, UGUSR2", new[] { "UGUSR1", "UGUSR2" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0024_2", "Unique Index on UGUSR2, UGUSR1", new[] { "UGUSR2", "UGUSR1" }, isUnique: true)
    };
}
