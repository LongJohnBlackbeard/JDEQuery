using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069161 - .
/// </summary>
public class F069161 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEMCU.
        /// </summary>
        public const string JEMCU = "JEMCU";

        /// <summary>
        /// JESBL.
        /// </summary>
        public const string JESBL = "JESBL";

        /// <summary>
        /// JESBLT.
        /// </summary>
        public const string JESBLT = "JESBLT";

        /// <summary>
        /// JEITM.
        /// </summary>
        public const string JEITM = "JEITM";

        /// <summary>
        /// JEUM.
        /// </summary>
        public const string JEUM = "JEUM";
    }

    /// <inheritdoc />
    public override string TableName => "F069161";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEMCU", "JEMCU", JdeDataType.String, 24, true, true),
        new JdeField("JESBL", "JESBL", JdeDataType.String, 16, true, true),
        new JdeField("JESBLT", "JESBLT", JdeDataType.String, 2, true, true),
        new JdeField("JEITM", "JEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("JEUM", "JEUM", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069161_0", "Primary Key on JEMCU, JESBL, JESBLT, JEITM, JEUM", new[] { "JEMCU", "JESBL", "JESBLT", "JEITM", "JEUM" }, isUnique: true, isPrimaryKey: true)
    };
}
