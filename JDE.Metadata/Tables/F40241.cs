using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40241 - .
/// </summary>
public class F40241 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDUNSPSC.
        /// </summary>
        public const string CDUNSPSC = "CDUNSPSC";

        /// <summary>
        /// CDUNSPSCDS.
        /// </summary>
        public const string CDUNSPSCDS = "CDUNSPSCDS";
    }

    /// <inheritdoc />
    public override string TableName => "F40241";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDUNSPSC", "CDUNSPSC", JdeDataType.String, 16, true, true),
        new JdeField("CDUNSPSCDS", "CDUNSPSCDS", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40241_0", "Primary Key on CDUNSPSC", new[] { "CDUNSPSC" }, isUnique: true, isPrimaryKey: true)
    };
}
