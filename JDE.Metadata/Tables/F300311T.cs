using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F300311T - .
/// </summary>
public class F300311T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHUKID.
        /// </summary>
        public const string EHUKID = "EHUKID";

        /// <summary>
        /// EHRUNLEX.
        /// </summary>
        public const string EHRUNLEX = "EHRUNLEX";

        /// <summary>
        /// EHRUNMEX.
        /// </summary>
        public const string EHRUNMEX = "EHRUNMEX";
    }

    /// <inheritdoc />
    public override string TableName => "F300311T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHRUNLEX", "EHRUNLEX", JdeDataType.Numeric),
        new JdeField("EHRUNMEX", "EHRUNMEX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F300311T_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
