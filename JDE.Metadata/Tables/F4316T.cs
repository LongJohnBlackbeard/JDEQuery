using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4316T - .
/// </summary>
public class F4316T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P3KCOO.
        /// </summary>
        public const string P3KCOO = "P3KCOO";

        /// <summary>
        /// P3DOCO.
        /// </summary>
        public const string P3DOCO = "P3DOCO";

        /// <summary>
        /// P3DCTO.
        /// </summary>
        public const string P3DCTO = "P3DCTO";

        /// <summary>
        /// P3SFXO.
        /// </summary>
        public const string P3SFXO = "P3SFXO";

        /// <summary>
        /// P3LNID.
        /// </summary>
        public const string P3LNID = "P3LNID";

        /// <summary>
        /// P3DLNID.
        /// </summary>
        public const string P3DLNID = "P3DLNID";

        /// <summary>
        /// P3ANI.
        /// </summary>
        public const string P3ANI = "P3ANI";

        /// <summary>
        /// P3KCO.
        /// </summary>
        public const string P3KCO = "P3KCO";

        /// <summary>
        /// P3RETA.
        /// </summary>
        public const string P3RETA = "P3RETA";

        /// <summary>
        /// P3RETT.
        /// </summary>
        public const string P3RETT = "P3RETT";

        /// <summary>
        /// P3REFA.
        /// </summary>
        public const string P3REFA = "P3REFA";

        /// <summary>
        /// P3REFT.
        /// </summary>
        public const string P3REFT = "P3REFT";

        /// <summary>
        /// P3MASP1.
        /// </summary>
        public const string P3MASP1 = "P3MASP1";

        /// <summary>
        /// P3MASP2.
        /// </summary>
        public const string P3MASP2 = "P3MASP2";

        /// <summary>
        /// P3CRCD.
        /// </summary>
        public const string P3CRCD = "P3CRCD";

        /// <summary>
        /// P3MAFL.
        /// </summary>
        public const string P3MAFL = "P3MAFL";
    }

    /// <inheritdoc />
    public override string TableName => "F4316T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P3KCOO", "P3KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P3DOCO", "P3DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P3DCTO", "P3DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P3SFXO", "P3SFXO", JdeDataType.String, 6, true, true),
        new JdeField("P3LNID", "P3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P3DLNID", "P3DLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P3ANI", "P3ANI", JdeDataType.String, 58),
        new JdeField("P3KCO", "P3KCO", JdeDataType.String, 10),
        new JdeField("P3RETA", "P3RETA", JdeDataType.Numeric),
        new JdeField("P3RETT", "P3RETT", JdeDataType.Numeric),
        new JdeField("P3REFA", "P3REFA", JdeDataType.Numeric),
        new JdeField("P3REFT", "P3REFT", JdeDataType.Numeric),
        new JdeField("P3MASP1", "P3MASP1", JdeDataType.Numeric),
        new JdeField("P3MASP2", "P3MASP2", JdeDataType.Numeric),
        new JdeField("P3CRCD", "P3CRCD", JdeDataType.String, 6),
        new JdeField("P3MAFL", "P3MAFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4316T_0", "Primary Key on P3DOCO, P3DCTO, P3KCOO, P3SFXO, P3LNID, P3DLNID", new[] { "P3DOCO", "P3DCTO", "P3KCOO", "P3SFXO", "P3LNID", "P3DLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
