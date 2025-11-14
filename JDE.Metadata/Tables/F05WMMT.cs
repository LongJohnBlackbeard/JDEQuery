using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05WMMT - .
/// </summary>
public class F05WMMT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTMMUID.
        /// </summary>
        public const string MTMMUID = "MTMMUID";

        /// <summary>
        /// MTMMDIR.
        /// </summary>
        public const string MTMMDIR = "MTMMDIR";
    }

    /// <inheritdoc />
    public override string TableName => "F05WMMT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTMMUID", "MTMMUID", JdeDataType.Numeric, null, true, true),
        new JdeField("MTMMDIR", "MTMMDIR", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05WMMT_0", "Primary Key on MTMMUID", new[] { "MTMMUID" }, isUnique: true, isPrimaryKey: true)
    };
}
