using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4316M - .
/// </summary>
public class F4316M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P4MAMD.
        /// </summary>
        public const string P4MAMD = "P4MAMD";

        /// <summary>
        /// P4ASLN.
        /// </summary>
        public const string P4ASLN = "P4ASLN";

        /// <summary>
        /// P4OMCU.
        /// </summary>
        public const string P4OMCU = "P4OMCU";

        /// <summary>
        /// P4OBJ.
        /// </summary>
        public const string P4OBJ = "P4OBJ";

        /// <summary>
        /// P4SUB.
        /// </summary>
        public const string P4SUB = "P4SUB";

        /// <summary>
        /// P4SBLT.
        /// </summary>
        public const string P4SBLT = "P4SBLT";

        /// <summary>
        /// P4SBL.
        /// </summary>
        public const string P4SBL = "P4SBL";

        /// <summary>
        /// P4MASP.
        /// </summary>
        public const string P4MASP = "P4MASP";
    }

    /// <inheritdoc />
    public override string TableName => "F4316M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P4MAMD", "P4MAMD", JdeDataType.String, 20, true, true),
        new JdeField("P4ASLN", "P4ASLN", JdeDataType.Numeric, null, true, true),
        new JdeField("P4OMCU", "P4OMCU", JdeDataType.String, 24),
        new JdeField("P4OBJ", "P4OBJ", JdeDataType.String, 12),
        new JdeField("P4SUB", "P4SUB", JdeDataType.String, 16),
        new JdeField("P4SBLT", "P4SBLT", JdeDataType.String, 2),
        new JdeField("P4SBL", "P4SBL", JdeDataType.String, 16),
        new JdeField("P4MASP", "P4MASP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4316M_0", "Primary Key on P4MAMD, P4ASLN", new[] { "P4MAMD", "P4ASLN" }, isUnique: true, isPrimaryKey: true)
    };
}
