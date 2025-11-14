using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49170 - .
/// </summary>
public class F49170 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNVMCU.
        /// </summary>
        public const string NNVMCU = "NNVMCU";

        /// <summary>
        /// NNN001.
        /// </summary>
        public const string NNN001 = "NNN001";

        /// <summary>
        /// NNCK01.
        /// </summary>
        public const string NNCK01 = "NNCK01";
    }

    /// <inheritdoc />
    public override string TableName => "F49170";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNVMCU", "NNVMCU", JdeDataType.String, 24, true, true),
        new JdeField("NNN001", "NNN001", JdeDataType.Numeric),
        new JdeField("NNCK01", "NNCK01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49170_0", "Primary Key on NNVMCU", new[] { "NNVMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
