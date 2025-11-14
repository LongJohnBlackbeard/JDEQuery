using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0901WO - .
/// </summary>
public class F0901WO : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WOSRCHWRD.
        /// </summary>
        public const string WOSRCHWRD = "WOSRCHWRD";

        /// <summary>
        /// WODUSE.
        /// </summary>
        public const string WODUSE = "WODUSE";
    }

    /// <inheritdoc />
    public override string TableName => "F0901WO";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WOSRCHWRD", "WOSRCHWRD", JdeDataType.String, 80, true, true),
        new JdeField("WODUSE", "WODUSE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0901WO_0", "Primary Key on WOSRCHWRD", new[] { "WOSRCHWRD" }, isUnique: true, isPrimaryKey: true)
    };
}
