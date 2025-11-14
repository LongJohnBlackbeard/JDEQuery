using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F89000 - .
/// </summary>
public class F89000 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T1LNGP.
        /// </summary>
        public const string T1LNGP = "T1LNGP";

        /// <summary>
        /// T1SY.
        /// </summary>
        public const string T1SY = "T1SY";
    }

    /// <inheritdoc />
    public override string TableName => "F89000";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T1LNGP", "T1LNGP", JdeDataType.String, 4, true, true),
        new JdeField("T1SY", "T1SY", JdeDataType.String, 8, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F89000_0", "Primary Key on T1LNGP, T1SY", new[] { "T1LNGP", "T1SY" }, isUnique: true, isPrimaryKey: true)
    };
}
