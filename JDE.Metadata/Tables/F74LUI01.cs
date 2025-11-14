using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74LUI01 - .
/// </summary>
public class F74LUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTJOBS.
        /// </summary>
        public const string TTJOBS = "TTJOBS";

        /// <summary>
        /// TTAID.
        /// </summary>
        public const string TTAID = "TTAID";

        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTAT1.
        /// </summary>
        public const string TTAT1 = "TTAT1";

        /// <summary>
        /// TTTAX.
        /// </summary>
        public const string TTTAX = "TTTAX";

        /// <summary>
        /// TTALPH.
        /// </summary>
        public const string TTALPH = "TTALPH";

        /// <summary>
        /// TTL74ACIR.
        /// </summary>
        public const string TTL74ACIR = "TTL74ACIR";

        /// <summary>
        /// TTL74REFA.
        /// </summary>
        public const string TTL74REFA = "TTL74REFA";

        /// <summary>
        /// TTL74READ.
        /// </summary>
        public const string TTL74READ = "TTL74READ";

        /// <summary>
        /// TTL74SBI.
        /// </summary>
        public const string TTL74SBI = "TTL74SBI";
    }

    /// <inheritdoc />
    public override string TableName => "F74LUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTJOBS", "TTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TTAID", "TTAID", JdeDataType.String, 16, true, true),
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TTAT1", "TTAT1", JdeDataType.String, 6),
        new JdeField("TTTAX", "TTTAX", JdeDataType.String, 40),
        new JdeField("TTALPH", "TTALPH", JdeDataType.String, 80),
        new JdeField("TTL74ACIR", "TTL74ACIR", JdeDataType.String, 4),
        new JdeField("TTL74REFA", "TTL74REFA", JdeDataType.String, 60),
        new JdeField("TTL74READ", "TTL74READ", JdeDataType.String, 160),
        new JdeField("TTL74SBI", "TTL74SBI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74LUI01_0", "Primary Key on TTJOBS, TTAID, TTAN8", new[] { "TTJOBS", "TTAID", "TTAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
