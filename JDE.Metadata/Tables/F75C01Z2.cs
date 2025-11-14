using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C01Z2 - .
/// </summary>
public class F75C01Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FFBDS4.
        /// </summary>
        public const string FFBDS4 = "FFBDS4";

        /// <summary>
        /// FFUKID.
        /// </summary>
        public const string FFUKID = "FFUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F75C01Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FFBDS4", "FFBDS4", JdeDataType.String, 800),
        new JdeField("FFUKID", "FFUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C01Z2_0", "Primary Key on FFUKID", new[] { "FFUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
