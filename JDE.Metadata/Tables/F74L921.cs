using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L921 - .
/// </summary>
public class F74L921 : JdeTable
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
        /// RAL74ACIR.
        /// </summary>
        public const string RAL74ACIR = "RAL74ACIR";

        /// <summary>
        /// RAL74REFA.
        /// </summary>
        public const string RAL74REFA = "RAL74REFA";

        /// <summary>
        /// RAAN8.
        /// </summary>
        public const string RAAN8 = "RAAN8";

        /// <summary>
        /// RATORG.
        /// </summary>
        public const string RATORG = "RATORG";

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
    public override string TableName => "F74L921";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAAID", "RAAID", JdeDataType.String, 16, true, true),
        new JdeField("RAL74ACIR", "RAL74ACIR", JdeDataType.String, 4, true, true),
        new JdeField("RAL74REFA", "RAL74REFA", JdeDataType.String, 60),
        new JdeField("RAAN8", "RAAN8", JdeDataType.Numeric),
        new JdeField("RATORG", "RATORG", JdeDataType.String, 20),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L921_0", "Primary Key on RAAID, RAL74ACIR", new[] { "RAAID", "RAL74ACIR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74L921_2", "Index on RAL74ACIR, RAL74REFA", new[] { "RAL74ACIR", "RAL74REFA" })
    };
}
