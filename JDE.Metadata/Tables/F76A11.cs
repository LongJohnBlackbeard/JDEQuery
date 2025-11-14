using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A11 - .
/// </summary>
public class F76A11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFAID.
        /// </summary>
        public const string TFAID = "TFAID";

        /// <summary>
        /// TFAID2.
        /// </summary>
        public const string TFAID2 = "TFAID2";

        /// <summary>
        /// TFANI.
        /// </summary>
        public const string TFANI = "TFANI";

        /// <summary>
        /// TFANI2.
        /// </summary>
        public const string TFANI2 = "TFANI2";
    }

    /// <inheritdoc />
    public override string TableName => "F76A11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFAID", "TFAID", JdeDataType.String, 16, true, true),
        new JdeField("TFAID2", "TFAID2", JdeDataType.String, 16),
        new JdeField("TFANI", "TFANI", JdeDataType.String, 58),
        new JdeField("TFANI2", "TFANI2", JdeDataType.String, 58)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A11_0", "Primary Key on TFAID", new[] { "TFAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A11_2", "Index on TFAID2", new[] { "TFAID2" })
    };
}
