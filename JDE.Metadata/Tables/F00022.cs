using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00022 - .
/// </summary>
public class F00022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UKOBNM.
        /// </summary>
        public const string UKOBNM = "UKOBNM";

        /// <summary>
        /// UKUKID.
        /// </summary>
        public const string UKUKID = "UKUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F00022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UKOBNM", "UKOBNM", JdeDataType.String, 20, true, true),
        new JdeField("UKUKID", "UKUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00022_0", "Primary Key on UKOBNM", new[] { "UKOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
