using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N120X - .
/// </summary>
public class FD3N120X : JdeTable
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
    }

    /// <inheritdoc />
    public override string TableName => "FD3N120X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FAAPID", "FAAPID", JdeDataType.String, 24),
        new JdeField("FALOC", "FALOC", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N120X_0", "Primary Key on FANUMB", new[] { "FANUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N120X_2", "Index on FAAPID, FALOC", new[] { "FAAPID", "FALOC" })
    };
}
