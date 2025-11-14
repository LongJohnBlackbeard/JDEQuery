using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3111ST - .
/// </summary>
public class F3111ST : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMUKID.
        /// </summary>
        public const string WMUKID = "WMUKID";

        /// <summary>
        /// WMPOC.
        /// </summary>
        public const string WMPOC = "WMPOC";

        /// <summary>
        /// WMVEND.
        /// </summary>
        public const string WMVEND = "WMVEND";
    }

    /// <inheritdoc />
    public override string TableName => "F3111ST";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMUKID", "WMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WMPOC", "WMPOC", JdeDataType.String, 2),
        new JdeField("WMVEND", "WMVEND", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3111ST_0", "Primary Key on WMUKID", new[] { "WMUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
