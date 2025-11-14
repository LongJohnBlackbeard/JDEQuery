using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI013 - .
/// </summary>
public class F30UI013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LKITM.
        /// </summary>
        public const string LKITM = "LKITM";

        /// <summary>
        /// LKLLX.
        /// </summary>
        public const string LKLLX = "LKLLX";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LKITM", "LKITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LKLLX", "LKLLX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI013_0", "Primary Key on LKITM", new[] { "LKITM" }, isUnique: true, isPrimaryKey: true)
    };
}
