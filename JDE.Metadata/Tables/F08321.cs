using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08321 - .
/// </summary>
public class F08321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BEVTAB.
        /// </summary>
        public const string BEVTAB = "BEVTAB";

        /// <summary>
        /// BEVYRS.
        /// </summary>
        public const string BEVYRS = "BEVYRS";

        /// <summary>
        /// BEVPCT.
        /// </summary>
        public const string BEVPCT = "BEVPCT";
    }

    /// <inheritdoc />
    public override string TableName => "F08321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BEVTAB", "BEVTAB", JdeDataType.String, 10, true, true),
        new JdeField("BEVYRS", "BEVYRS", JdeDataType.Numeric, null, true, true),
        new JdeField("BEVPCT", "BEVPCT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08321_0", "Primary Key on BEVTAB, BEVYRS", new[] { "BEVTAB", "BEVYRS" }, isUnique: true, isPrimaryKey: true)
    };
}
