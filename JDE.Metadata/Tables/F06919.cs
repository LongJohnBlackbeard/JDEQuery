using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06919 - .
/// </summary>
public class F06919 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YBCCPR.
        /// </summary>
        public const string YBCCPR = "YBCCPR";

        /// <summary>
        /// YBDNCD.
        /// </summary>
        public const string YBDNCD = "YBDNCD";

        /// <summary>
        /// YBDNV.
        /// </summary>
        public const string YBDNV = "YBDNV";

        /// <summary>
        /// YBDNMN.
        /// </summary>
        public const string YBDNMN = "YBDNMN";
    }

    /// <inheritdoc />
    public override string TableName => "F06919";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YBCCPR", "YBCCPR", JdeDataType.String, 6, true, true),
        new JdeField("YBDNCD", "YBDNCD", JdeDataType.String, 6, true, true),
        new JdeField("YBDNV", "YBDNV", JdeDataType.Numeric, null, true, true),
        new JdeField("YBDNMN", "YBDNMN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06919_0", "Primary Key on YBCCPR, YBDNCD, YBDNV", new[] { "YBCCPR", "YBDNCD", "YBDNV" }, isUnique: true, isPrimaryKey: true)
    };
}
