using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43126T - .
/// </summary>
public class F43126T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P4MATC.
        /// </summary>
        public const string P4MATC = "P4MATC";

        /// <summary>
        /// P4KCOO.
        /// </summary>
        public const string P4KCOO = "P4KCOO";

        /// <summary>
        /// P4DOCO.
        /// </summary>
        public const string P4DOCO = "P4DOCO";

        /// <summary>
        /// P4DCTO.
        /// </summary>
        public const string P4DCTO = "P4DCTO";

        /// <summary>
        /// P4SFXO.
        /// </summary>
        public const string P4SFXO = "P4SFXO";

        /// <summary>
        /// P4LNID.
        /// </summary>
        public const string P4LNID = "P4LNID";

        /// <summary>
        /// P4NLIN.
        /// </summary>
        public const string P4NLIN = "P4NLIN";

        /// <summary>
        /// P4DLNID.
        /// </summary>
        public const string P4DLNID = "P4DLNID";

        /// <summary>
        /// P4DOC.
        /// </summary>
        public const string P4DOC = "P4DOC";

        /// <summary>
        /// P4DCT.
        /// </summary>
        public const string P4DCT = "P4DCT";

        /// <summary>
        /// P4KCO.
        /// </summary>
        public const string P4KCO = "P4KCO";

        /// <summary>
        /// P4SFX.
        /// </summary>
        public const string P4SFX = "P4SFX";

        /// <summary>
        /// P4SFXE.
        /// </summary>
        public const string P4SFXE = "P4SFXE";

        /// <summary>
        /// P4ANI.
        /// </summary>
        public const string P4ANI = "P4ANI";

        /// <summary>
        /// P4RETA.
        /// </summary>
        public const string P4RETA = "P4RETA";

        /// <summary>
        /// P4RETT.
        /// </summary>
        public const string P4RETT = "P4RETT";

        /// <summary>
        /// P4REFA.
        /// </summary>
        public const string P4REFA = "P4REFA";

        /// <summary>
        /// P4REFT.
        /// </summary>
        public const string P4REFT = "P4REFT";

        /// <summary>
        /// P4CRCD.
        /// </summary>
        public const string P4CRCD = "P4CRCD";

        /// <summary>
        /// P4MAFL.
        /// </summary>
        public const string P4MAFL = "P4MAFL";
    }

    /// <inheritdoc />
    public override string TableName => "F43126T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P4MATC", "P4MATC", JdeDataType.String, 2, true, true),
        new JdeField("P4KCOO", "P4KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P4DOCO", "P4DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DCTO", "P4DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P4SFXO", "P4SFXO", JdeDataType.String, 6, true, true),
        new JdeField("P4LNID", "P4LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P4NLIN", "P4NLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DLNID", "P4DLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DOC", "P4DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DCT", "P4DCT", JdeDataType.String, 4),
        new JdeField("P4KCO", "P4KCO", JdeDataType.String, 10),
        new JdeField("P4SFX", "P4SFX", JdeDataType.String, 6),
        new JdeField("P4SFXE", "P4SFXE", JdeDataType.Numeric),
        new JdeField("P4ANI", "P4ANI", JdeDataType.String, 58),
        new JdeField("P4RETA", "P4RETA", JdeDataType.Numeric),
        new JdeField("P4RETT", "P4RETT", JdeDataType.Numeric),
        new JdeField("P4REFA", "P4REFA", JdeDataType.Numeric),
        new JdeField("P4REFT", "P4REFT", JdeDataType.Numeric),
        new JdeField("P4CRCD", "P4CRCD", JdeDataType.String, 6),
        new JdeField("P4MAFL", "P4MAFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43126T_0", "Primary Key on P4MATC, P4DOCO, P4DCTO, P4KCOO, P4SFXO, P4LNID, P4NLIN, P4DLNID, P4DOC", new[] { "P4MATC", "P4DOCO", "P4DCTO", "P4KCOO", "P4SFXO", "P4LNID", "P4NLIN", "P4DLNID", "P4DOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43126T_2", "Index on P4DOC, P4DCT, P4KCO, P4SFX, P4SFXE", new[] { "P4DOC", "P4DCT", "P4KCO", "P4SFX", "P4SFXE" }),
        new JdeIndex("F43126T_3", "Index on P4MATC, P4DOC, P4DCT, P4KCO", new[] { "P4MATC", "P4DOC", "P4DCT", "P4KCO" })
    };
}
