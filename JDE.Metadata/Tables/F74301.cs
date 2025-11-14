using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74301 - .
/// </summary>
public class F74301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUBK01.
        /// </summary>
        public const string BUBK01 = "BUBK01";

        /// <summary>
        /// BUBK04.
        /// </summary>
        public const string BUBK04 = "BUBK04";
    }

    /// <inheritdoc />
    public override string TableName => "F74301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUBK01", "BUBK01", JdeDataType.String, 22, true, true),
        new JdeField("BUBK04", "BUBK04", JdeDataType.String, 590)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74301_0", "Primary Key on BUBK01", new[] { "BUBK01" }, isUnique: true, isPrimaryKey: true)
    };
}
