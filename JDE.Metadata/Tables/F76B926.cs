using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B926 - .
/// </summary>
public class F76B926 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAAID.
        /// </summary>
        public const string RAAID = "RAAID";

        /// <summary>
        /// RAB76ACIR.
        /// </summary>
        public const string RAB76ACIR = "RAB76ACIR";

        /// <summary>
        /// RAB76REFA.
        /// </summary>
        public const string RAB76REFA = "RAB76REFA";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B926";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAAID", "RAAID", JdeDataType.String, 16, true, true),
        new JdeField("RAB76ACIR", "RAB76ACIR", JdeDataType.String, 4, true, true),
        new JdeField("RAB76REFA", "RAB76REFA", JdeDataType.String, 60),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B926_0", "Primary Key on RAAID, RAB76ACIR", new[] { "RAAID", "RAB76ACIR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B926_2", "Index on RAB76ACIR, RAB76REFA", new[] { "RAB76ACIR", "RAB76REFA" })
    };
}
