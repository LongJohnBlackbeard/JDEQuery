using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F11UI001 - .
/// </summary>
public class F11UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCVC08A.
        /// </summary>
        public const string LCVC08A = "LCVC08A";

        /// <summary>
        /// LCCO.
        /// </summary>
        public const string LCCO = "LCCO";

        /// <summary>
        /// LCNAME.
        /// </summary>
        public const string LCNAME = "LCNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F11UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCVC08A", "LCVC08A", JdeDataType.String, 16, true, true),
        new JdeField("LCCO", "LCCO", JdeDataType.String, 10, true, true),
        new JdeField("LCNAME", "LCNAME", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F11UI001_0", "Primary Key on LCVC08A, LCCO", new[] { "LCVC08A", "LCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
