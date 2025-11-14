using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CT3 - .
/// </summary>
public class F76CT3 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T3CO.
        /// </summary>
        public const string T3CO = "T3CO";

        /// <summary>
        /// T3PN.
        /// </summary>
        public const string T3PN = "T3PN";

        /// <summary>
        /// T3FY.
        /// </summary>
        public const string T3FY = "T3FY";
    }

    /// <inheritdoc />
    public override string TableName => "F76CT3";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T3CO", "T3CO", JdeDataType.String, 10, true, true),
        new JdeField("T3PN", "T3PN", JdeDataType.Numeric, null, true, true),
        new JdeField("T3FY", "T3FY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CT3_0", "Primary Key on T3CO, T3PN, T3FY", new[] { "T3CO", "T3PN", "T3FY" }, isUnique: true, isPrimaryKey: true)
    };
}
