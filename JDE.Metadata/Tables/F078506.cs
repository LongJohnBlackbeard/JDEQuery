using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078506 - .
/// </summary>
public class F078506 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YJHMCO.
        /// </summary>
        public const string YJHMCO = "YJHMCO";

        /// <summary>
        /// YJDL01.
        /// </summary>
        public const string YJDL01 = "YJDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F078506";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YJHMCO", "YJHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YJDL01", "YJDL01", JdeDataType.String, 60, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078506_0", "Primary Key on YJHMCO, YJDL01", new[] { "YJHMCO", "YJDL01" }, isUnique: true, isPrimaryKey: true)
    };
}
