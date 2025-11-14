using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0444 - .
/// </summary>
public class F76A0444 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFRESSQ.
        /// </summary>
        public const string WFRESSQ = "WFRESSQ";

        /// <summary>
        /// WFDMTJ.
        /// </summary>
        public const string WFDMTJ = "WFDMTJ";

        /// <summary>
        /// WFP3.
        /// </summary>
        public const string WFP3 = "WFP3";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0444";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFRESSQ", "WFRESSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDMTJ", "WFDMTJ", JdeDataType.Numeric),
        new JdeField("WFP3", "WFP3", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0444_0", "Primary Key on WFRESSQ", new[] { "WFRESSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A0444_2", "Index on WFDMTJ", new[] { "WFDMTJ" })
    };
}
