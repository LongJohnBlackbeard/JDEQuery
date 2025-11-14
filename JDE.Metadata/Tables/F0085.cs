using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0085 - .
/// </summary>
public class F0085 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YNENVN.
        /// </summary>
        public const string YNENVN = "YNENVN";

        /// <summary>
        /// YNFILE.
        /// </summary>
        public const string YNFILE = "YNFILE";

        /// <summary>
        /// YNARF1.
        /// </summary>
        public const string YNARF1 = "YNARF1";
    }

    /// <inheritdoc />
    public override string TableName => "F0085";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YNENVN", "YNENVN", JdeDataType.String, 20, true, true),
        new JdeField("YNFILE", "YNFILE", JdeDataType.String, 20, true, true),
        new JdeField("YNARF1", "YNARF1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0085_0", "Primary Key on YNENVN, YNFILE", new[] { "YNENVN", "YNFILE" }, isUnique: true, isPrimaryKey: true)
    };
}
