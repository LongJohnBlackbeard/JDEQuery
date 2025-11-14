using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39122 - .
/// </summary>
public class F39122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVCO.
        /// </summary>
        public const string SVCO = "SVCO";

        /// <summary>
        /// SVUKID.
        /// </summary>
        public const string SVUKID = "SVUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F39122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVCO", "SVCO", JdeDataType.String, 10, true, true),
        new JdeField("SVUKID", "SVUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39122_0", "Primary Key on SVCO", new[] { "SVCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F39122_2", "Index on SVUKID", new[] { "SVUKID" })
    };
}
