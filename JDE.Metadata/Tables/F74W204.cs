using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W204 - .
/// </summary>
public class F74W204 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K4DAFN.
        /// </summary>
        public const string K4DAFN = "K4DAFN";

        /// <summary>
        /// K4NXTC.
        /// </summary>
        public const string K4NXTC = "K4NXTC";

        /// <summary>
        /// K4DARN.
        /// </summary>
        public const string K4DARN = "K4DARN";

        /// <summary>
        /// K4DAER.
        /// </summary>
        public const string K4DAER = "K4DAER";
    }

    /// <inheritdoc />
    public override string TableName => "F74W204";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K4DAFN", "K4DAFN", JdeDataType.String, 60, true, true),
        new JdeField("K4NXTC", "K4NXTC", JdeDataType.Numeric, null, true, true),
        new JdeField("K4DARN", "K4DARN", JdeDataType.Numeric, null, true, true),
        new JdeField("K4DAER", "K4DAER", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W204_0", "Primary Key on K4DAFN, K4NXTC, K4DARN, K4DAER", new[] { "K4DAFN", "K4NXTC", "K4DARN", "K4DAER" }, isUnique: true, isPrimaryKey: true)
    };
}
