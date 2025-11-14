using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3210W - .
/// </summary>
public class F3210W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWKY.
        /// </summary>
        public const string SWKY = "SWKY";

        /// <summary>
        /// SWDL01.
        /// </summary>
        public const string SWDL01 = "SWDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F3210W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWKY", "SWKY", JdeDataType.String, 20, true, true),
        new JdeField("SWDL01", "SWDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3210W_0", "Primary Key on SWKY", new[] { "SWKY" }, isUnique: true, isPrimaryKey: true)
    };
}
