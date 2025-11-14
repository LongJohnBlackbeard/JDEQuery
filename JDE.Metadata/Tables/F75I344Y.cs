using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I344Y - .
/// </summary>
public class F75I344Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDYEXU.
        /// </summary>
        public const string CDYEXU = "CDYEXU";

        /// <summary>
        /// CDBDSN.
        /// </summary>
        public const string CDBDSN = "CDBDSN";

        /// <summary>
        /// CDBDDT.
        /// </summary>
        public const string CDBDDT = "CDBDDT";

        /// <summary>
        /// CDYARN.
        /// </summary>
        public const string CDYARN = "CDYARN";

        /// <summary>
        /// CDAA25.
        /// </summary>
        public const string CDAA25 = "CDAA25";

        /// <summary>
        /// CDYARD.
        /// </summary>
        public const string CDYARD = "CDYARD";

        /// <summary>
        /// CDKCOO.
        /// </summary>
        public const string CDKCOO = "CDKCOO";

        /// <summary>
        /// CDI75AED.
        /// </summary>
        public const string CDI75AED = "CDI75AED";

        /// <summary>
        /// CDDOCO.
        /// </summary>
        public const string CDDOCO = "CDDOCO";

        /// <summary>
        /// CDDCTO.
        /// </summary>
        public const string CDDCTO = "CDDCTO";

        /// <summary>
        /// CDKCO.
        /// </summary>
        public const string CDKCO = "CDKCO";

        /// <summary>
        /// CDDOC.
        /// </summary>
        public const string CDDOC = "CDDOC";

        /// <summary>
        /// CDDCT.
        /// </summary>
        public const string CDDCT = "CDDCT";

        /// <summary>
        /// CDEV01.
        /// </summary>
        public const string CDEV01 = "CDEV01";

        /// <summary>
        /// CDYEXA.
        /// </summary>
        public const string CDYEXA = "CDYEXA";

        /// <summary>
        /// CDASVL.
        /// </summary>
        public const string CDASVL = "CDASVL";

        /// <summary>
        /// CDDES2.
        /// </summary>
        public const string CDDES2 = "CDDES2";

        /// <summary>
        /// CDXOPR.
        /// </summary>
        public const string CDXOPR = "CDXOPR";

        /// <summary>
        /// CDEDER.
        /// </summary>
        public const string CDEDER = "CDEDER";

        /// <summary>
        /// CDSHPJ.
        /// </summary>
        public const string CDSHPJ = "CDSHPJ";

        /// <summary>
        /// CDDATESUB.
        /// </summary>
        public const string CDDATESUB = "CDDATESUB";

        /// <summary>
        /// CDATDJ.
        /// </summary>
        public const string CDATDJ = "CDATDJ";

        /// <summary>
        /// CDREMK.
        /// </summary>
        public const string CDREMK = "CDREMK";

        /// <summary>
        /// CDPBAA.
        /// </summary>
        public const string CDPBAA = "CDPBAA";

        /// <summary>
        /// CDTORG.
        /// </summary>
        public const string CDTORG = "CDTORG";

        /// <summary>
        /// CDDCPER.
        /// </summary>
        public const string CDDCPER = "CDDCPER";

        /// <summary>
        /// CDDCVD.
        /// </summary>
        public const string CDDCVD = "CDDCVD";

        /// <summary>
        /// CDYTDU.
        /// </summary>
        public const string CDYTDU = "CDYTDU";

        /// <summary>
        /// CDYODT.
        /// </summary>
        public const string CDYODT = "CDYODT";

        /// <summary>
        /// CDA301.
        /// </summary>
        public const string CDA301 = "CDA301";

        /// <summary>
        /// CDDESC.
        /// </summary>
        public const string CDDESC = "CDDESC";

        /// <summary>
        /// CDUPRC.
        /// </summary>
        public const string CDUPRC = "CDUPRC";

        /// <summary>
        /// CDTRQT.
        /// </summary>
        public const string CDTRQT = "CDTRQT";

        /// <summary>
        /// CDUORG.
        /// </summary>
        public const string CDUORG = "CDUORG";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDRMK.
        /// </summary>
        public const string CDRMK = "CDRMK";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDI75FTX1.
        /// </summary>
        public const string CDI75FTX1 = "CDI75FTX1";

        /// <summary>
        /// CDYIAM.
        /// </summary>
        public const string CDYIAM = "CDYIAM";

        /// <summary>
        /// CDI75FTX2.
        /// </summary>
        public const string CDI75FTX2 = "CDI75FTX2";

        /// <summary>
        /// CDI75CESS.
        /// </summary>
        public const string CDI75CESS = "CDI75CESS";

        /// <summary>
        /// CDI75SED.
        /// </summary>
        public const string CDI75SED = "CDI75SED";

        /// <summary>
        /// CDBDNO.
        /// </summary>
        public const string CDBDNO = "CDBDNO";
    }

    /// <inheritdoc />
    public override string TableName => "F75I344Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDYEXU", "CDYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("CDBDSN", "CDBDSN", JdeDataType.String, 44, true, true),
        new JdeField("CDBDDT", "CDBDDT", JdeDataType.Numeric),
        new JdeField("CDYARN", "CDYARN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDAA25", "CDAA25", JdeDataType.String, 50),
        new JdeField("CDYARD", "CDYARD", JdeDataType.Numeric),
        new JdeField("CDKCOO", "CDKCOO", JdeDataType.String, 10),
        new JdeField("CDI75AED", "CDI75AED", JdeDataType.Numeric),
        new JdeField("CDDOCO", "CDDOCO", JdeDataType.Numeric),
        new JdeField("CDDCTO", "CDDCTO", JdeDataType.String, 4),
        new JdeField("CDKCO", "CDKCO", JdeDataType.String, 10),
        new JdeField("CDDOC", "CDDOC", JdeDataType.Numeric),
        new JdeField("CDDCT", "CDDCT", JdeDataType.String, 4),
        new JdeField("CDEV01", "CDEV01", JdeDataType.String, 2),
        new JdeField("CDYEXA", "CDYEXA", JdeDataType.Numeric),
        new JdeField("CDASVL", "CDASVL", JdeDataType.Numeric),
        new JdeField("CDDES2", "CDDES2", JdeDataType.String, 70),
        new JdeField("CDXOPR", "CDXOPR", JdeDataType.String, 120),
        new JdeField("CDEDER", "CDEDER", JdeDataType.String, 2, true, true),
        new JdeField("CDSHPJ", "CDSHPJ", JdeDataType.Numeric),
        new JdeField("CDDATESUB", "CDDATESUB", JdeDataType.Numeric),
        new JdeField("CDATDJ", "CDATDJ", JdeDataType.Numeric),
        new JdeField("CDREMK", "CDREMK", JdeDataType.String, 60),
        new JdeField("CDPBAA", "CDPBAA", JdeDataType.Numeric),
        new JdeField("CDTORG", "CDTORG", JdeDataType.String, 20),
        new JdeField("CDDCPER", "CDDCPER", JdeDataType.Numeric),
        new JdeField("CDDCVD", "CDDCVD", JdeDataType.Numeric),
        new JdeField("CDYTDU", "CDYTDU", JdeDataType.Numeric),
        new JdeField("CDYODT", "CDYODT", JdeDataType.Numeric),
        new JdeField("CDA301", "CDA301", JdeDataType.String, 6),
        new JdeField("CDDESC", "CDDESC", JdeDataType.String, 60),
        new JdeField("CDUPRC", "CDUPRC", JdeDataType.Numeric),
        new JdeField("CDTRQT", "CDTRQT", JdeDataType.Numeric),
        new JdeField("CDUORG", "CDUORG", JdeDataType.Numeric),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric),
        new JdeField("CDRMK", "CDRMK", JdeDataType.String, 60),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDI75FTX1", "CDI75FTX1", JdeDataType.Numeric),
        new JdeField("CDYIAM", "CDYIAM", JdeDataType.Numeric),
        new JdeField("CDI75FTX2", "CDI75FTX2", JdeDataType.Numeric),
        new JdeField("CDI75CESS", "CDI75CESS", JdeDataType.Numeric),
        new JdeField("CDI75SED", "CDI75SED", JdeDataType.Numeric),
        new JdeField("CDBDNO", "CDBDNO", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I344Y_0", "Primary Key on CDYEXU, CDBDSN, CDBDNO, CDEDER, CDYARN", new[] { "CDYEXU", "CDBDSN", "CDBDNO", "CDEDER", "CDYARN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I344Y_4", "Index on CDYEXU, CDKCO, CDDOC, CDDCT", new[] { "CDYEXU", "CDKCO", "CDDOC", "CDDCT" }),
        new JdeIndex("F75I344Y_5", "Index on CDYEXU, CDBDSN", new[] { "CDYEXU", "CDBDSN" }),
        new JdeIndex("F75I344Y_6", "Index on CDYARN", new[] { "CDYARN" })
    };
}
