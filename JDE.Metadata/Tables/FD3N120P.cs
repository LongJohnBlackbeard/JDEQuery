using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N120P - .
/// </summary>
public class FD3N120P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FAAPID.
        /// </summary>
        public const string FAAPID = "FAAPID";

        /// <summary>
        /// FALOC.
        /// </summary>
        public const string FALOC = "FALOC";

        /// <summary>
        /// FAARCQ.
        /// </summary>
        public const string FAARCQ = "FAARCQ";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N120P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FAAPID", "FAAPID", JdeDataType.String, 24),
        new JdeField("FALOC", "FALOC", JdeDataType.String, 24),
        new JdeField("FAARCQ", "FAARCQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N120P_0", "Primary Key on FANUMB", new[] { "FANUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N120P_2", "Index on FANUMB, FAAPID", new[] { "FANUMB", "FAAPID" })
    };
}
