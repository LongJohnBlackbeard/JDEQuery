using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43146T - .
/// </summary>
public class F43146T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P5KCOO.
        /// </summary>
        public const string P5KCOO = "P5KCOO";

        /// <summary>
        /// P5DOCO.
        /// </summary>
        public const string P5DOCO = "P5DOCO";

        /// <summary>
        /// P5DCTO.
        /// </summary>
        public const string P5DCTO = "P5DCTO";

        /// <summary>
        /// P5SFXO.
        /// </summary>
        public const string P5SFXO = "P5SFXO";

        /// <summary>
        /// P5LNID.
        /// </summary>
        public const string P5LNID = "P5LNID";

        /// <summary>
        /// P5DLNID.
        /// </summary>
        public const string P5DLNID = "P5DLNID";

        /// <summary>
        /// P5KCO.
        /// </summary>
        public const string P5KCO = "P5KCO";

        /// <summary>
        /// P5ANI.
        /// </summary>
        public const string P5ANI = "P5ANI";

        /// <summary>
        /// P5MASP1.
        /// </summary>
        public const string P5MASP1 = "P5MASP1";

        /// <summary>
        /// P5MASP2.
        /// </summary>
        public const string P5MASP2 = "P5MASP2";

        /// <summary>
        /// P5MASP3.
        /// </summary>
        public const string P5MASP3 = "P5MASP3";
    }

    /// <inheritdoc />
    public override string TableName => "F43146T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P5KCOO", "P5KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P5DOCO", "P5DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P5DCTO", "P5DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P5SFXO", "P5SFXO", JdeDataType.String, 6, true, true),
        new JdeField("P5LNID", "P5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P5DLNID", "P5DLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P5KCO", "P5KCO", JdeDataType.String, 10),
        new JdeField("P5ANI", "P5ANI", JdeDataType.String, 58),
        new JdeField("P5MASP1", "P5MASP1", JdeDataType.Numeric),
        new JdeField("P5MASP2", "P5MASP2", JdeDataType.Numeric),
        new JdeField("P5MASP3", "P5MASP3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43146T_0", "Primary Key on P5DOCO, P5KCOO, P5DCTO, P5SFXO, P5LNID, P5DLNID", new[] { "P5DOCO", "P5KCOO", "P5DCTO", "P5SFXO", "P5LNID", "P5DLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
