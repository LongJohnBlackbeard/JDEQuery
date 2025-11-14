using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0013 - .
/// </summary>
public class FD3N0013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPFVPN.
        /// </summary>
        public const string LPFVPN = "LPFVPN";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPFVPN", "LPFVPN", JdeDataType.String, 200, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0013_0", "Primary Key on LPFVPN", new[] { "LPFVPN" }, isUnique: true, isPrimaryKey: true)
    };
}
