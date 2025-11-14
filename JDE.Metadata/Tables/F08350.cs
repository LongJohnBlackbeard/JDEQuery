using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08350 - .
/// </summary>
public class F08350 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BKDIVC.
        /// </summary>
        public const string BKDIVC = "BKDIVC";

        /// <summary>
        /// BKUNRU.
        /// </summary>
        public const string BKUNRU = "BKUNRU";

        /// <summary>
        /// BKSBGR.
        /// </summary>
        public const string BKSBGR = "BKSBGR";

        /// <summary>
        /// BKSEQ#.
        /// </summary>
        public const string BKSEQ_ = "BKSEQ#";

        /// <summary>
        /// BKSGRU.
        /// </summary>
        public const string BKSGRU = "BKSGRU";
    }

    /// <inheritdoc />
    public override string TableName => "F08350";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BKDIVC", "BKDIVC", JdeDataType.String, 12, true, true),
        new JdeField("BKUNRU", "BKUNRU", JdeDataType.String, 2),
        new JdeField("BKSBGR", "BKSBGR", JdeDataType.String, 20, true, true),
        new JdeField("BKSEQ#", "BKSEQ#", JdeDataType.Numeric),
        new JdeField("BKSGRU", "BKSGRU", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08350_0", "Primary Key on BKDIVC, BKSBGR", new[] { "BKDIVC", "BKSBGR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08350_2", "Index on BKDIVC, BKSEQ#, BKSBGR", new[] { "BKDIVC", "BKSEQ#", "BKSBGR" }),
        new JdeIndex("F08350_3", "Index on SYS_NC00006$, SYS_NC00007$", new[] { "SYS_NC00006$", "SYS_NC00007$" })
    };
}
