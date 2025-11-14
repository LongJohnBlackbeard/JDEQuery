using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F33133 - .
/// </summary>
public class F33133 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCMMCU.
        /// </summary>
        public const string DCMMCU = "DCMMCU";

        /// <summary>
        /// DCDUEP.
        /// </summary>
        public const string DCDUEP = "DCDUEP";

        /// <summary>
        /// DCDCRP.
        /// </summary>
        public const string DCDCRP = "DCDCRP";
    }

    /// <inheritdoc />
    public override string TableName => "F33133";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCMMCU", "DCMMCU", JdeDataType.String, 24, true, true),
        new JdeField("DCDUEP", "DCDUEP", JdeDataType.String, 2),
        new JdeField("DCDCRP", "DCDCRP", JdeDataType.String, 672)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F33133_0", "Primary Key on DCMMCU", new[] { "DCMMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
