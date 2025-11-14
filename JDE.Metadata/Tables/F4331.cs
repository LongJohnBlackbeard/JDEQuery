using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4331 - .
/// </summary>
public class F4331 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P1DOCO.
        /// </summary>
        public const string P1DOCO = "P1DOCO";

        /// <summary>
        /// P1DCTO.
        /// </summary>
        public const string P1DCTO = "P1DCTO";

        /// <summary>
        /// P1KCOO.
        /// </summary>
        public const string P1KCOO = "P1KCOO";

        /// <summary>
        /// P1AN8.
        /// </summary>
        public const string P1AN8 = "P1AN8";

        /// <summary>
        /// P1LNID.
        /// </summary>
        public const string P1LNID = "P1LNID";

        /// <summary>
        /// P1UORG.
        /// </summary>
        public const string P1UORG = "P1UORG";

        /// <summary>
        /// P1PRRC.
        /// </summary>
        public const string P1PRRC = "P1PRRC";

        /// <summary>
        /// P1PDDJ.
        /// </summary>
        public const string P1PDDJ = "P1PDDJ";

        /// <summary>
        /// P1CNDJ.
        /// </summary>
        public const string P1CNDJ = "P1CNDJ";

        /// <summary>
        /// P1CRCD.
        /// </summary>
        public const string P1CRCD = "P1CRCD";

        /// <summary>
        /// P1SFXO.
        /// </summary>
        public const string P1SFXO = "P1SFXO";

        /// <summary>
        /// P1QRDJ.
        /// </summary>
        public const string P1QRDJ = "P1QRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4331";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P1DOCO", "P1DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P1DCTO", "P1DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P1KCOO", "P1KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P1AN8", "P1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("P1LNID", "P1LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P1UORG", "P1UORG", JdeDataType.Numeric, null, true, true),
        new JdeField("P1PRRC", "P1PRRC", JdeDataType.Numeric),
        new JdeField("P1PDDJ", "P1PDDJ", JdeDataType.Numeric),
        new JdeField("P1CNDJ", "P1CNDJ", JdeDataType.Numeric),
        new JdeField("P1CRCD", "P1CRCD", JdeDataType.String, 6),
        new JdeField("P1SFXO", "P1SFXO", JdeDataType.String, 6, true, true),
        new JdeField("P1QRDJ", "P1QRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4331_0", "Primary Key on P1DOCO, P1DCTO, P1KCOO, P1SFXO, P1AN8, P1LNID, P1UORG", new[] { "P1DOCO", "P1DCTO", "P1KCOO", "P1SFXO", "P1AN8", "P1LNID", "P1UORG" }, isUnique: true, isPrimaryKey: true)
    };
}
