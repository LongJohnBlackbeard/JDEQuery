using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700003 - .
/// </summary>
public class F700003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCK74LEDT.
        /// </summary>
        public const string LCK74LEDT = "LCK74LEDT";

        /// <summary>
        /// LCEUCTRC.
        /// </summary>
        public const string LCEUCTRC = "LCEUCTRC";
    }

    /// <inheritdoc />
    public override string TableName => "F700003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCK74LEDT", "LCK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("LCEUCTRC", "LCEUCTRC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700003_0", "Primary Key on LCK74LEDT", new[] { "LCK74LEDT" }, isUnique: true, isPrimaryKey: true)
    };
}
