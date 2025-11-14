using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H9905 - .
/// </summary>
public class F44H9905 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MHAN8.
        /// </summary>
        public const string MHAN8 = "MHAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F44H9905";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MHAN8", "MHAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H9905_0", "Primary Key on MHAN8", new[] { "MHAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
