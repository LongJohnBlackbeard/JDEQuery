using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N120L - .
/// </summary>
public class FD3N120L : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FALOC.
        /// </summary>
        public const string FALOC = "FALOC";

        /// <summary>
        /// FAMATH01.
        /// </summary>
        public const string FAMATH01 = "FAMATH01";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N120L";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FALOC", "FALOC", JdeDataType.String, 24, true, true),
        new JdeField("FAMATH01", "FAMATH01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N120L_0", "Primary Key on FALOC", new[] { "FALOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N120L_2", "Index on FALOC, FAMATH01", new[] { "FALOC", "FAMATH01" })
    };
}
