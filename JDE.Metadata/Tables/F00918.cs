using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00918 - .
/// </summary>
public class F00918 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BBUKID.
        /// </summary>
        public const string BBUKID = "BBUKID";

        /// <summary>
        /// BBBDS4.
        /// </summary>
        public const string BBBDS4 = "BBBDS4";
    }

    /// <inheritdoc />
    public override string TableName => "F00918";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BBUKID", "BBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BBBDS4", "BBBDS4", JdeDataType.String, 800)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00918_0", "Primary Key on BBUKID", new[] { "BBUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
