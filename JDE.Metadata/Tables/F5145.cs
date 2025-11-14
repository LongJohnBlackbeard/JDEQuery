using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5145 - .
/// </summary>
public class F5145 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G7OBJ.
        /// </summary>
        public const string G7OBJ = "G7OBJ";

        /// <summary>
        /// G7NNBR.
        /// </summary>
        public const string G7NNBR = "G7NNBR";

        /// <summary>
        /// G7DEF.
        /// </summary>
        public const string G7DEF = "G7DEF";

        /// <summary>
        /// G7PMT.
        /// </summary>
        public const string G7PMT = "G7PMT";

        /// <summary>
        /// G7NMT.
        /// </summary>
        public const string G7NMT = "G7NMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5145";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G7OBJ", "G7OBJ", JdeDataType.String, 12, true, true),
        new JdeField("G7NNBR", "G7NNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("G7DEF", "G7DEF", JdeDataType.Numeric, null, true, true),
        new JdeField("G7PMT", "G7PMT", JdeDataType.Numeric),
        new JdeField("G7NMT", "G7NMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5145_0", "Primary Key on G7NNBR, G7DEF, G7OBJ", new[] { "G7NNBR", "G7DEF", "G7OBJ" }, isUnique: true, isPrimaryKey: true)
    };
}
