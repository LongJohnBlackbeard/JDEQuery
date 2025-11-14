using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7608A - .
/// </summary>
public class F7608A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V5AN8.
        /// </summary>
        public const string V5AN8 = "V5AN8";

        /// <summary>
        /// V5A009.
        /// </summary>
        public const string V5A009 = "V5A009";

        /// <summary>
        /// V5A001.
        /// </summary>
        public const string V5A001 = "V5A001";

        /// <summary>
        /// V5TX2.
        /// </summary>
        public const string V5TX2 = "V5TX2";
    }

    /// <inheritdoc />
    public override string TableName => "F7608A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V5AN8", "V5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("V5A009", "V5A009", JdeDataType.String, 6, true, true),
        new JdeField("V5A001", "V5A001", JdeDataType.String, 6),
        new JdeField("V5TX2", "V5TX2", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7608A_0", "Primary Key on V5AN8, V5A009", new[] { "V5AN8", "V5A009" }, isUnique: true, isPrimaryKey: true)
    };
}
