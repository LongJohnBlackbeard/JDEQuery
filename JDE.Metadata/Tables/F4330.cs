using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4330 - .
/// </summary>
public class F4330 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P0KCOO.
        /// </summary>
        public const string P0KCOO = "P0KCOO";

        /// <summary>
        /// P0DOCO.
        /// </summary>
        public const string P0DOCO = "P0DOCO";

        /// <summary>
        /// P0DCTO.
        /// </summary>
        public const string P0DCTO = "P0DCTO";

        /// <summary>
        /// P0LNID.
        /// </summary>
        public const string P0LNID = "P0LNID";

        /// <summary>
        /// P0AN8.
        /// </summary>
        public const string P0AN8 = "P0AN8";

        /// <summary>
        /// P0QPRT.
        /// </summary>
        public const string P0QPRT = "P0QPRT";

        /// <summary>
        /// P0TRDJ.
        /// </summary>
        public const string P0TRDJ = "P0TRDJ";

        /// <summary>
        /// P0RSPO.
        /// </summary>
        public const string P0RSPO = "P0RSPO";

        /// <summary>
        /// P0RQQJ.
        /// </summary>
        public const string P0RQQJ = "P0RQQJ";

        /// <summary>
        /// P0QRDJ.
        /// </summary>
        public const string P0QRDJ = "P0QRDJ";

        /// <summary>
        /// P0PDDJ.
        /// </summary>
        public const string P0PDDJ = "P0PDDJ";

        /// <summary>
        /// P0UREL.
        /// </summary>
        public const string P0UREL = "P0UREL";

        /// <summary>
        /// P0AREL.
        /// </summary>
        public const string P0AREL = "P0AREL";

        /// <summary>
        /// P0SFXO.
        /// </summary>
        public const string P0SFXO = "P0SFXO";
    }

    /// <inheritdoc />
    public override string TableName => "F4330";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P0KCOO", "P0KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P0DOCO", "P0DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P0DCTO", "P0DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P0LNID", "P0LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P0AN8", "P0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("P0QPRT", "P0QPRT", JdeDataType.String, 2),
        new JdeField("P0TRDJ", "P0TRDJ", JdeDataType.Numeric),
        new JdeField("P0RSPO", "P0RSPO", JdeDataType.String, 2),
        new JdeField("P0RQQJ", "P0RQQJ", JdeDataType.Numeric),
        new JdeField("P0QRDJ", "P0QRDJ", JdeDataType.Numeric),
        new JdeField("P0PDDJ", "P0PDDJ", JdeDataType.Numeric),
        new JdeField("P0UREL", "P0UREL", JdeDataType.Numeric),
        new JdeField("P0AREL", "P0AREL", JdeDataType.Numeric),
        new JdeField("P0SFXO", "P0SFXO", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4330_0", "Primary Key on P0DOCO, P0DCTO, P0KCOO, P0SFXO, P0LNID, P0AN8", new[] { "P0DOCO", "P0DCTO", "P0KCOO", "P0SFXO", "P0LNID", "P0AN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4330_2", "Index on P0KCOO, P0DOCO, P0DCTO, P0AN8, P0LNID", new[] { "P0KCOO", "P0DOCO", "P0DCTO", "P0AN8", "P0LNID" }),
        new JdeIndex("F4330_3", "Index on P0KCOO, P0DOCO, P0DCTO, P0TRDJ, P0RQQJ", new[] { "P0KCOO", "P0DOCO", "P0DCTO", "P0TRDJ", "P0RQQJ" })
    };
}
