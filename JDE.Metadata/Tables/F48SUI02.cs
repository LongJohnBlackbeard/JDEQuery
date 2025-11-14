using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48SUI02 - .
/// </summary>
public class F48SUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDVC08A.
        /// </summary>
        public const string WDVC08A = "WDVC08A";

        /// <summary>
        /// WDCO.
        /// </summary>
        public const string WDCO = "WDCO";

        /// <summary>
        /// WDNAME.
        /// </summary>
        public const string WDNAME = "WDNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F48SUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDVC08A", "WDVC08A", JdeDataType.String, 16, true, true),
        new JdeField("WDCO", "WDCO", JdeDataType.String, 10, true, true),
        new JdeField("WDNAME", "WDNAME", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48SUI02_0", "Primary Key on WDVC08A, WDCO", new[] { "WDVC08A", "WDCO" }, isUnique: true, isPrimaryKey: true)
    };
}
