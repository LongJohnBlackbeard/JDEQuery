using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA004 - .
/// </summary>
public class F90CA004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGAN8.
        /// </summary>
        public const string AGAN8 = "AGAN8";

        /// <summary>
        /// AGEMAN8.
        /// </summary>
        public const string AGEMAN8 = "AGEMAN8";

        /// <summary>
        /// AGDSCRP1.
        /// </summary>
        public const string AGDSCRP1 = "AGDSCRP1";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGAN8", "AGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AGEMAN8", "AGEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AGDSCRP1", "AGDSCRP1", JdeDataType.String, 100, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA004_0", "Primary Key on AGAN8, AGEMAN8, AGDSCRP1", new[] { "AGAN8", "AGEMAN8", "AGDSCRP1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA004_2", "Index on AGAN8", new[] { "AGAN8" }),
        new JdeIndex("F90CA004_3", "Index on AGEMAN8", new[] { "AGEMAN8" }),
        new JdeIndex("F90CA004_4", "Index on AGDSCRP1", new[] { "AGDSCRP1" })
    };
}
