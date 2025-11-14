using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CT2 - .
/// </summary>
public class F76CT2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTCO.
        /// </summary>
        public const string CTCO = "CTCO";

        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTOBJ.
        /// </summary>
        public const string CTOBJ = "CTOBJ";

        /// <summary>
        /// CTSUB.
        /// </summary>
        public const string CTSUB = "CTSUB";

        /// <summary>
        /// CTSFXO.
        /// </summary>
        public const string CTSFXO = "CTSFXO";

        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTICUT.
        /// </summary>
        public const string CTICUT = "CTICUT";

        /// <summary>
        /// CTICU.
        /// </summary>
        public const string CTICU = "CTICU";

        /// <summary>
        /// CTDCTO.
        /// </summary>
        public const string CTDCTO = "CTDCTO";

        /// <summary>
        /// CTDOCO.
        /// </summary>
        public const string CTDOCO = "CTDOCO";

        /// <summary>
        /// CTTRDJ.
        /// </summary>
        public const string CTTRDJ = "CTTRDJ";

        /// <summary>
        /// CTDGL.
        /// </summary>
        public const string CTDGL = "CTDGL";

        /// <summary>
        /// CTDSVJ.
        /// </summary>
        public const string CTDSVJ = "CTDSVJ";

        /// <summary>
        /// CTEXR1.
        /// </summary>
        public const string CTEXR1 = "CTEXR1";

        /// <summary>
        /// CTGL01.
        /// </summary>
        public const string CTGL01 = "CTGL01";

        /// <summary>
        /// CTECST.
        /// </summary>
        public const string CTECST = "CTECST";

        /// <summary>
        /// CTTXA1.
        /// </summary>
        public const string CTTXA1 = "CTTXA1";

        /// <summary>
        /// CTTA1.
        /// </summary>
        public const string CTTA1 = "CTTA1";

        /// <summary>
        /// CTTXR1.
        /// </summary>
        public const string CTTXR1 = "CTTXR1";

        /// <summary>
        /// CTATXA.
        /// </summary>
        public const string CTATXA = "CTATXA";

        /// <summary>
        /// CTSTA1.
        /// </summary>
        public const string CTSTA1 = "CTSTA1";

        /// <summary>
        /// CTSTA2.
        /// </summary>
        public const string CTSTA2 = "CTSTA2";

        /// <summary>
        /// CTAID.
        /// </summary>
        public const string CTAID = "CTAID";

        /// <summary>
        /// CTTAX.
        /// </summary>
        public const string CTTAX = "CTTAX";

        /// <summary>
        /// CTTAXC.
        /// </summary>
        public const string CTTAXC = "CTTAXC";

        /// <summary>
        /// CTALPH.
        /// </summary>
        public const string CTALPH = "CTALPH";

        /// <summary>
        /// CTMCUZ.
        /// </summary>
        public const string CTMCUZ = "CTMCUZ";

        /// <summary>
        /// CTRP20.
        /// </summary>
        public const string CTRP20 = "CTRP20";

        /// <summary>
        /// CTCAGT.
        /// </summary>
        public const string CTCAGT = "CTCAGT";

        /// <summary>
        /// CTCSTC.
        /// </summary>
        public const string CTCSTC = "CTCSTC";

        /// <summary>
        /// CTAC07.
        /// </summary>
        public const string CTAC07 = "CTAC07";

        /// <summary>
        /// CTLNID.
        /// </summary>
        public const string CTLNID = "CTLNID";

        /// <summary>
        /// CT76CPERIO.
        /// </summary>
        public const string CT76CPERIO = "CT76CPERIO";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76CT2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTCO", "CTCO", JdeDataType.String, 10, true, true),
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24),
        new JdeField("CTOBJ", "CTOBJ", JdeDataType.String, 12),
        new JdeField("CTSUB", "CTSUB", JdeDataType.String, 16),
        new JdeField("CTSFXO", "CTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric),
        new JdeField("CTICUT", "CTICUT", JdeDataType.String, 4),
        new JdeField("CTICU", "CTICU", JdeDataType.Numeric),
        new JdeField("CTDCTO", "CTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CTDOCO", "CTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CTTRDJ", "CTTRDJ", JdeDataType.Numeric),
        new JdeField("CTDGL", "CTDGL", JdeDataType.Numeric),
        new JdeField("CTDSVJ", "CTDSVJ", JdeDataType.Numeric),
        new JdeField("CTEXR1", "CTEXR1", JdeDataType.String, 4),
        new JdeField("CTGL01", "CTGL01", JdeDataType.String, 8),
        new JdeField("CTECST", "CTECST", JdeDataType.Numeric),
        new JdeField("CTTXA1", "CTTXA1", JdeDataType.String, 20),
        new JdeField("CTTA1", "CTTA1", JdeDataType.Numeric),
        new JdeField("CTTXR1", "CTTXR1", JdeDataType.Numeric),
        new JdeField("CTATXA", "CTATXA", JdeDataType.Numeric),
        new JdeField("CTSTA1", "CTSTA1", JdeDataType.Numeric),
        new JdeField("CTSTA2", "CTSTA2", JdeDataType.Numeric),
        new JdeField("CTAID", "CTAID", JdeDataType.String, 16),
        new JdeField("CTTAX", "CTTAX", JdeDataType.String, 40, true, true),
        new JdeField("CTTAXC", "CTTAXC", JdeDataType.String, 2),
        new JdeField("CTALPH", "CTALPH", JdeDataType.String, 80),
        new JdeField("CTMCUZ", "CTMCUZ", JdeDataType.String, 24),
        new JdeField("CTRP20", "CTRP20", JdeDataType.String, 6),
        new JdeField("CTCAGT", "CTCAGT", JdeDataType.String, 20),
        new JdeField("CTCSTC", "CTCSTC", JdeDataType.String, 2),
        new JdeField("CTAC07", "CTAC07", JdeDataType.String, 6),
        new JdeField("CTLNID", "CTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CT76CPERIO", "CT76CPERIO", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CT2_0", "Primary Key on CTCO, CTTAX, CTDCTO, CTDOCO, CTSFXO, CTLNID", new[] { "CTCO", "CTTAX", "CTDCTO", "CTDOCO", "CTSFXO", "CTLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76CT2_2", "Index on CTICU, CTICUT, CTDOCO, CTDCTO, CTLNID", new[] { "CTICU", "CTICUT", "CTDOCO", "CTDCTO", "CTLNID" })
    };
}
