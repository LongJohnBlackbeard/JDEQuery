using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00189 - .
/// </summary>
public class F00189 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TGCO.
        /// </summary>
        public const string TGCO = "TGCO";

        /// <summary>
        /// TGMCU.
        /// </summary>
        public const string TGMCU = "TGMCU";

        /// <summary>
        /// TGOBJ.
        /// </summary>
        public const string TGOBJ = "TGOBJ";

        /// <summary>
        /// TGSUB.
        /// </summary>
        public const string TGSUB = "TGSUB";

        /// <summary>
        /// TGDCTO.
        /// </summary>
        public const string TGDCTO = "TGDCTO";

        /// <summary>
        /// TGDOCO.
        /// </summary>
        public const string TGDOCO = "TGDOCO";

        /// <summary>
        /// TGSFXO.
        /// </summary>
        public const string TGSFXO = "TGSFXO";

        /// <summary>
        /// TGJELN.
        /// </summary>
        public const string TGJELN = "TGJELN";

        /// <summary>
        /// TGAN8.
        /// </summary>
        public const string TGAN8 = "TGAN8";

        /// <summary>
        /// TGDGL.
        /// </summary>
        public const string TGDGL = "TGDGL";

        /// <summary>
        /// TGDGJ.
        /// </summary>
        public const string TGDGJ = "TGDGJ";

        /// <summary>
        /// TGTXA1.
        /// </summary>
        public const string TGTXA1 = "TGTXA1";

        /// <summary>
        /// TGEXR1.
        /// </summary>
        public const string TGEXR1 = "TGEXR1";

        /// <summary>
        /// TGATXA.
        /// </summary>
        public const string TGATXA = "TGATXA";

        /// <summary>
        /// TGATXN.
        /// </summary>
        public const string TGATXN = "TGATXN";

        /// <summary>
        /// TGSTAM.
        /// </summary>
        public const string TGSTAM = "TGSTAM";

        /// <summary>
        /// TGUTXA.
        /// </summary>
        public const string TGUTXA = "TGUTXA";

        /// <summary>
        /// TGUTX.
        /// </summary>
        public const string TGUTX = "TGUTX";

        /// <summary>
        /// TGRMK.
        /// </summary>
        public const string TGRMK = "TGRMK";

        /// <summary>
        /// TGKCOO.
        /// </summary>
        public const string TGKCOO = "TGKCOO";
    }

    /// <inheritdoc />
    public override string TableName => "F00189";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TGCO", "TGCO", JdeDataType.String, 10),
        new JdeField("TGMCU", "TGMCU", JdeDataType.String, 24),
        new JdeField("TGOBJ", "TGOBJ", JdeDataType.String, 12),
        new JdeField("TGSUB", "TGSUB", JdeDataType.String, 16),
        new JdeField("TGDCTO", "TGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TGDOCO", "TGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TGSFXO", "TGSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TGJELN", "TGJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("TGAN8", "TGAN8", JdeDataType.Numeric),
        new JdeField("TGDGL", "TGDGL", JdeDataType.Numeric),
        new JdeField("TGDGJ", "TGDGJ", JdeDataType.Numeric),
        new JdeField("TGTXA1", "TGTXA1", JdeDataType.String, 20),
        new JdeField("TGEXR1", "TGEXR1", JdeDataType.String, 4),
        new JdeField("TGATXA", "TGATXA", JdeDataType.Numeric),
        new JdeField("TGATXN", "TGATXN", JdeDataType.Numeric),
        new JdeField("TGSTAM", "TGSTAM", JdeDataType.Numeric),
        new JdeField("TGUTXA", "TGUTXA", JdeDataType.Numeric),
        new JdeField("TGUTX", "TGUTX", JdeDataType.Numeric),
        new JdeField("TGRMK", "TGRMK", JdeDataType.String, 60),
        new JdeField("TGKCOO", "TGKCOO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00189_0", "Primary Key on TGDCTO, TGDOCO, TGSFXO, TGJELN, TGKCOO", new[] { "TGDCTO", "TGDOCO", "TGSFXO", "TGJELN", "TGKCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00189_1", "Index on TGDCTO, TGDOCO, TGKCOO, TGSFXO", new[] { "TGDCTO", "TGDOCO", "TGKCOO", "TGSFXO" })
    };
}
