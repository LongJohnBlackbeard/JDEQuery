using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41006 - .
/// </summary>
public class F41006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IKTRNT.
        /// </summary>
        public const string IKTRNT = "IKTRNT";

        /// <summary>
        /// IKDCT.
        /// </summary>
        public const string IKDCT = "IKDCT";
    }

    /// <inheritdoc />
    public override string TableName => "F41006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IKTRNT", "IKTRNT", JdeDataType.String, 2, true, true),
        new JdeField("IKDCT", "IKDCT", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41006_0", "Primary Key on IKTRNT, IKDCT", new[] { "IKTRNT", "IKDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
