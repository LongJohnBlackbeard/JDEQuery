using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F750101 - .
/// </summary>
public class F750101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUBK02.
        /// </summary>
        public const string BUBK02 = "BUBK02";
    }

    /// <inheritdoc />
    public override string TableName => "F750101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUBK02", "BUBK02", JdeDataType.String, 140, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F750101_0", "Primary Key on BUBK02", new[] { "BUBK02" }, isUnique: true, isPrimaryKey: true)
    };
}
