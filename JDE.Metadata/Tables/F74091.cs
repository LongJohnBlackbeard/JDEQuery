using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74091 - .
/// </summary>
public class F74091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HADCT.
        /// </summary>
        public const string HADCT = "HADCT";

        /// <summary>
        /// HATXA1.
        /// </summary>
        public const string HATXA1 = "HATXA1";

        /// <summary>
        /// HAITRG.
        /// </summary>
        public const string HAITRG = "HAITRG";

        /// <summary>
        /// HATCRG.
        /// </summary>
        public const string HATCRG = "HATCRG";
    }

    /// <inheritdoc />
    public override string TableName => "F74091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HADCT", "HADCT", JdeDataType.String, 4, true, true),
        new JdeField("HATXA1", "HATXA1", JdeDataType.String, 20, true, true),
        new JdeField("HAITRG", "HAITRG", JdeDataType.String, 4),
        new JdeField("HATCRG", "HATCRG", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74091_0", "Primary Key on HADCT, HATXA1", new[] { "HADCT", "HATXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
