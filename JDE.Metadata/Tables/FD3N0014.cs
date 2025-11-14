using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0014 - .
/// </summary>
public class FD3N0014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDDTA1.
        /// </summary>
        public const string EDDTA1 = "EDDTA1";

        /// <summary>
        /// EDMCU.
        /// </summary>
        public const string EDMCU = "EDMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDDTA1", "EDDTA1", JdeDataType.String, 512, true, true),
        new JdeField("EDMCU", "EDMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0014_0", "Primary Key on EDDTA1", new[] { "EDDTA1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N0014_2", "Index on EDMCU", new[] { "EDMCU" })
    };
}
