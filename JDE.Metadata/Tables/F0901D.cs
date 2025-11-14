using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0901D - .
/// </summary>
public class F0901D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LKLNGP.
        /// </summary>
        public const string LKLNGP = "LKLNGP";

        /// <summary>
        /// LKDL01.
        /// </summary>
        public const string LKDL01 = "LKDL01";

        /// <summary>
        /// LKAID.
        /// </summary>
        public const string LKAID = "LKAID";
    }

    /// <inheritdoc />
    public override string TableName => "F0901D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LKLNGP", "LKLNGP", JdeDataType.String, 4, true, true),
        new JdeField("LKDL01", "LKDL01", JdeDataType.String, 60),
        new JdeField("LKAID", "LKAID", JdeDataType.String, 16, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0901D_0", "Primary Key on LKAID, LKLNGP", new[] { "LKAID", "LKLNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0901D_2", "Index on LKDL01", new[] { "LKDL01" })
    };
}
