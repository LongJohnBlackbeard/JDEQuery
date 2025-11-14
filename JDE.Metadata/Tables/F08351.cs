using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08351 - .
/// </summary>
public class F08351 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUDIVC.
        /// </summary>
        public const string BUDIVC = "BUDIVC";

        /// <summary>
        /// BUSBGR.
        /// </summary>
        public const string BUSBGR = "BUSBGR";

        /// <summary>
        /// BUPLAN.
        /// </summary>
        public const string BUPLAN = "BUPLAN";

        /// <summary>
        /// BUMANP.
        /// </summary>
        public const string BUMANP = "BUMANP";

        /// <summary>
        /// BUEFT.
        /// </summary>
        public const string BUEFT = "BUEFT";

        /// <summary>
        /// BUEFTE.
        /// </summary>
        public const string BUEFTE = "BUEFTE";

        /// <summary>
        /// BUXDFP.
        /// </summary>
        public const string BUXDFP = "BUXDFP";
    }

    /// <inheritdoc />
    public override string TableName => "F08351";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUDIVC", "BUDIVC", JdeDataType.String, 12, true, true),
        new JdeField("BUSBGR", "BUSBGR", JdeDataType.String, 20, true, true),
        new JdeField("BUPLAN", "BUPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BUMANP", "BUMANP", JdeDataType.String, 2),
        new JdeField("BUEFT", "BUEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("BUEFTE", "BUEFTE", JdeDataType.Numeric),
        new JdeField("BUXDFP", "BUXDFP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08351_0", "Primary Key on BUDIVC, BUSBGR, BUPLAN, BUEFT", new[] { "BUDIVC", "BUSBGR", "BUPLAN", "BUEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08351_2", "Index on BUPLAN, BUDIVC, BUSBGR, BUEFT", new[] { "BUPLAN", "BUDIVC", "BUSBGR", "BUEFT" })
    };
}
