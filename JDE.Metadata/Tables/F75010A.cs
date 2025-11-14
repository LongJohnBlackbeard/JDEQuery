using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75010A - .
/// </summary>
public class F75010A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUUKID.
        /// </summary>
        public const string BUUKID = "BUUKID";

        /// <summary>
        /// BUBK75.
        /// </summary>
        public const string BUBK75 = "BUBK75";
    }

    /// <inheritdoc />
    public override string TableName => "F75010A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUUKID", "BUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BUBK75", "BUBK75", JdeDataType.String, 700)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75010A_0", "Primary Key on BUUKID", new[] { "BUUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
