using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08346 - .
/// </summary>
public class F08346 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B4AN8.
        /// </summary>
        public const string B4AN8 = "B4AN8";

        /// <summary>
        /// B4PLAN.
        /// </summary>
        public const string B4PLAN = "B4PLAN";

        /// <summary>
        /// B4EFT.
        /// </summary>
        public const string B4EFT = "B4EFT";

        /// <summary>
        /// B4PDBA.
        /// </summary>
        public const string B4PDBA = "B4PDBA";

        /// <summary>
        /// B4EFTE.
        /// </summary>
        public const string B4EFTE = "B4EFTE";

        /// <summary>
        /// B4PCTD.
        /// </summary>
        public const string B4PCTD = "B4PCTD";
    }

    /// <inheritdoc />
    public override string TableName => "F08346";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B4AN8", "B4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("B4PLAN", "B4PLAN", JdeDataType.String, 16, true, true),
        new JdeField("B4EFT", "B4EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("B4PDBA", "B4PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("B4EFTE", "B4EFTE", JdeDataType.Numeric),
        new JdeField("B4PCTD", "B4PCTD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08346_0", "Primary Key on B4AN8, B4PLAN, B4EFT, B4PDBA", new[] { "B4AN8", "B4PLAN", "B4EFT", "B4PDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
