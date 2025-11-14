using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW40 - .
/// </summary>
public class FCW40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCC9PLNB.
        /// </summary>
        public const string TCC9PLNB = "TCC9PLNB";

        /// <summary>
        /// TCC9PLNT.
        /// </summary>
        public const string TCC9PLNT = "TCC9PLNT";

        /// <summary>
        /// TCC9COEF.
        /// </summary>
        public const string TCC9COEF = "TCC9COEF";

        /// <summary>
        /// TCC9RDRL.
        /// </summary>
        public const string TCC9RDRL = "TCC9RDRL";
    }

    /// <inheritdoc />
    public override string TableName => "FCW40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCC9PLNB", "TCC9PLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("TCC9PLNT", "TCC9PLNT", JdeDataType.Numeric, null, true, true),
        new JdeField("TCC9COEF", "TCC9COEF", JdeDataType.Numeric),
        new JdeField("TCC9RDRL", "TCC9RDRL", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW40_0", "Primary Key on TCC9PLNB, TCC9PLNT", new[] { "TCC9PLNB", "TCC9PLNT" }, isUnique: true, isPrimaryKey: true)
    };
}
