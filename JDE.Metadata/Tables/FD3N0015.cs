using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0015 - .
/// </summary>
public class FD3N0015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCFVPN.
        /// </summary>
        public const string LCFVPN = "LCFVPN";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCFVPN", "LCFVPN", JdeDataType.String, 200, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0015_0", "Primary Key on LCFVPN", new[] { "LCFVPN" }, isUnique: true, isPrimaryKey: true)
    };
}
