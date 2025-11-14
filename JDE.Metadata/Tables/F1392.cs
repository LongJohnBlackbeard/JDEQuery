using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1392 - .
/// </summary>
public class F1392 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GFEQCC.
        /// </summary>
        public const string GFEQCC = "GFEQCC";

        /// <summary>
        /// GFTYDD.
        /// </summary>
        public const string GFTYDD = "GFTYDD";
    }

    /// <inheritdoc />
    public override string TableName => "F1392";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GFEQCC", "GFEQCC", JdeDataType.String, 20, true, true),
        new JdeField("GFTYDD", "GFTYDD", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1392_0", "Primary Key on GFEQCC, GFTYDD", new[] { "GFEQCC", "GFTYDD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1392_2", "Index on GFTYDD, GFEQCC", new[] { "GFTYDD", "GFEQCC" })
    };
}
