using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01816 - .
/// </summary>
public class F01816 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AOSRCHWRD.
        /// </summary>
        public const string AOSRCHWRD = "AOSRCHWRD";

        /// <summary>
        /// AODUSE.
        /// </summary>
        public const string AODUSE = "AODUSE";
    }

    /// <inheritdoc />
    public override string TableName => "F01816";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AOSRCHWRD", "AOSRCHWRD", JdeDataType.String, 80, true, true),
        new JdeField("AODUSE", "AODUSE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01816_0", "Primary Key on AOSRCHWRD", new[] { "AOSRCHWRD" }, isUnique: true, isPrimaryKey: true)
    };
}
