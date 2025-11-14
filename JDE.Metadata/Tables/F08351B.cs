using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08351B - .
/// </summary>
public class F08351B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCDIVC.
        /// </summary>
        public const string PCDIVC = "PCDIVC";

        /// <summary>
        /// PCSBGR.
        /// </summary>
        public const string PCSBGR = "PCSBGR";

        /// <summary>
        /// PCSEQ#.
        /// </summary>
        public const string PCSEQ_ = "PCSEQ#";

        /// <summary>
        /// PCPLAN.
        /// </summary>
        public const string PCPLAN = "PCPLAN";

        /// <summary>
        /// PCEFT.
        /// </summary>
        public const string PCEFT = "PCEFT";
    }

    /// <inheritdoc />
    public override string TableName => "F08351B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCDIVC", "PCDIVC", JdeDataType.String, 12, true, true),
        new JdeField("PCSBGR", "PCSBGR", JdeDataType.String, 20, true, true),
        new JdeField("PCSEQ#", "PCSEQ#", JdeDataType.Numeric),
        new JdeField("PCPLAN", "PCPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PCEFT", "PCEFT", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08351B_0", "Primary Key on PCDIVC, PCSBGR, PCPLAN, PCEFT", new[] { "PCDIVC", "PCSBGR", "PCPLAN", "PCEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
