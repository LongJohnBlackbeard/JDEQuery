using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B40T - .
/// </summary>
public class F03B40T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBDCID.
        /// </summary>
        public const string RBDCID = "RBDCID";

        /// <summary>
        /// RBSMIFL.
        /// </summary>
        public const string RBSMIFL = "RBSMIFL";
    }

    /// <inheritdoc />
    public override string TableName => "F03B40T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBDCID", "RBDCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RBSMIFL", "RBSMIFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B40T_0", "Primary Key on RBDCID", new[] { "RBDCID" }, isUnique: true, isPrimaryKey: true)
    };
}
