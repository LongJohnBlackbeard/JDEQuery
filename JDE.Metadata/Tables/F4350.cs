using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4350 - .
/// </summary>
public class F4350 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H1AN8.
        /// </summary>
        public const string H1AN8 = "H1AN8";

        /// <summary>
        /// H1HLNK.
        /// </summary>
        public const string H1HLNK = "H1HLNK";
    }

    /// <inheritdoc />
    public override string TableName => "F4350";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H1AN8", "H1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("H1HLNK", "H1HLNK", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4350_0", "Primary Key on H1AN8", new[] { "H1AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
