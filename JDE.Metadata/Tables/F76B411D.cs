using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B411D - .
/// </summary>
public class F76B411D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDBRNFK.
        /// </summary>
        public const string CDBRNFK = "CDBRNFK";

        /// <summary>
        /// CDFCO.
        /// </summary>
        public const string CDFCO = "CDFCO";

        /// <summary>
        /// CDN001.
        /// </summary>
        public const string CDN001 = "CDN001";

        /// <summary>
        /// CDDCT.
        /// </summary>
        public const string CDDCT = "CDDCT";

        /// <summary>
        /// CDBRMI.
        /// </summary>
        public const string CDBRMI = "CDBRMI";

        /// <summary>
        /// CDBRMD.
        /// </summary>
        public const string CDBRMD = "CDBRMD";

        /// <summary>
        /// CDBSER.
        /// </summary>
        public const string CDBSER = "CDBSER";

        /// <summary>
        /// CDBNNF.
        /// </summary>
        public const string CDBNNF = "CDBNNF";

        /// <summary>
        /// CDBRNFDE.
        /// </summary>
        public const string CDBRNFDE = "CDBRNFDE";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDLITM.
        /// </summary>
        public const string CDLITM = "CDLITM";

        /// <summary>
        /// CDBRD60.
        /// </summary>
        public const string CDBRD60 = "CDBRD60";

        /// <summary>
        /// CDBRTN5.
        /// </summary>
        public const string CDBRTN5 = "CDBRTN5";

        /// <summary>
        /// CDBRNO.
        /// </summary>
        public const string CDBRNO = "CDBRNO";

        /// <summary>
        /// CDBCLF.
        /// </summary>
        public const string CDBCLF = "CDBCLF";

        /// <summary>
        /// CDUORG.
        /// </summary>
        public const string CDUORG = "CDUORG";

        /// <summary>
        /// CDUOM.
        /// </summary>
        public const string CDUOM = "CDUOM";

        /// <summary>
        /// CDPRIC.
        /// </summary>
        public const string CDPRIC = "CDPRIC";

        /// <summary>
        /// CDAEXP.
        /// </summary>
        public const string CDAEXP = "CDAEXP";

        /// <summary>
        /// CDBDES.
        /// </summary>
        public const string CDBDES = "CDBDES";

        /// <summary>
        /// CDBRIPI.
        /// </summary>
        public const string CDBRIPI = "CDBRIPI";

        /// <summary>
        /// CDBRXIPI.
        /// </summary>
        public const string CDBRXIPI = "CDBRXIPI";

        /// <summary>
        /// CDBBTP.
        /// </summary>
        public const string CDBBTP = "CDBBTP";

        /// <summary>
        /// CDBIPI.
        /// </summary>
        public const string CDBIPI = "CDBIPI";

        /// <summary>
        /// CDBST2.
        /// </summary>
        public const string CDBST2 = "CDBST2";

        /// <summary>
        /// CDBRICMS.
        /// </summary>
        public const string CDBRICMS = "CDBRICMS";

        /// <summary>
        /// CDBRXICMS.
        /// </summary>
        public const string CDBRXICMS = "CDBRXICMS";

        /// <summary>
        /// CDBBCL.
        /// </summary>
        public const string CDBBCL = "CDBBCL";

        /// <summary>
        /// CDBRAICMS.
        /// </summary>
        public const string CDBRAICMS = "CDBRAICMS";

        /// <summary>
        /// CDBBIS.
        /// </summary>
        public const string CDBBIS = "CDBBIS";

        /// <summary>
        /// CDBVIS.
        /// </summary>
        public const string CDBVIS = "CDBVIS";

        /// <summary>
        /// CDBRMM.
        /// </summary>
        public const string CDBRMM = "CDBRMM";

        /// <summary>
        /// CDRDOR.
        /// </summary>
        public const string CDRDOR = "CDRDOR";

        /// <summary>
        /// CDC1FU.
        /// </summary>
        public const string CDC1FU = "CDC1FU";

        /// <summary>
        /// CDC2FU.
        /// </summary>
        public const string CDC2FU = "CDC2FU";

        /// <summary>
        /// CDD1FU.
        /// </summary>
        public const string CDD1FU = "CDD1FU";

        /// <summary>
        /// CDD2FU.
        /// </summary>
        public const string CDD2FU = "CDD2FU";

        /// <summary>
        /// CDN1FU.
        /// </summary>
        public const string CDN1FU = "CDN1FU";

        /// <summary>
        /// CDN2FU.
        /// </summary>
        public const string CDN2FU = "CDN2FU";

        /// <summary>
        /// CDN3FU.
        /// </summary>
        public const string CDN3FU = "CDN3FU";

        /// <summary>
        /// CDN4FU.
        /// </summary>
        public const string CDN4FU = "CDN4FU";

        /// <summary>
        /// CDN5FU.
        /// </summary>
        public const string CDN5FU = "CDN5FU";

        /// <summary>
        /// CDN6FU.
        /// </summary>
        public const string CDN6FU = "CDN6FU";

        /// <summary>
        /// CDN7FU.
        /// </summary>
        public const string CDN7FU = "CDN7FU";

        /// <summary>
        /// CDS1FU.
        /// </summary>
        public const string CDS1FU = "CDS1FU";

        /// <summary>
        /// CDS2FU.
        /// </summary>
        public const string CDS2FU = "CDS2FU";

        /// <summary>
        /// CDS3FU.
        /// </summary>
        public const string CDS3FU = "CDS3FU";

        /// <summary>
        /// CDS4FU.
        /// </summary>
        public const string CDS4FU = "CDS4FU";

        /// <summary>
        /// CDGENLNG.
        /// </summary>
        public const string CDGENLNG = "CDGENLNG";

        /// <summary>
        /// CDTORG.
        /// </summary>
        public const string CDTORG = "CDTORG";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76B411D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDBRNFK", "CDBRNFK", JdeDataType.Numeric, null, true, true),
        new JdeField("CDFCO", "CDFCO", JdeDataType.String, 10),
        new JdeField("CDN001", "CDN001", JdeDataType.Numeric),
        new JdeField("CDDCT", "CDDCT", JdeDataType.String, 4),
        new JdeField("CDBRMI", "CDBRMI", JdeDataType.String, 2),
        new JdeField("CDBRMD", "CDBRMD", JdeDataType.String, 4),
        new JdeField("CDBSER", "CDBSER", JdeDataType.String, 4),
        new JdeField("CDBNNF", "CDBNNF", JdeDataType.Numeric),
        new JdeField("CDBRNFDE", "CDBRNFDE", JdeDataType.Numeric),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDLITM", "CDLITM", JdeDataType.String, 50),
        new JdeField("CDBRD60", "CDBRD60", JdeDataType.String, 120),
        new JdeField("CDBRTN5", "CDBRTN5", JdeDataType.String, 10),
        new JdeField("CDBRNO", "CDBRNO", JdeDataType.String, 12),
        new JdeField("CDBCLF", "CDBCLF", JdeDataType.String, 20),
        new JdeField("CDUORG", "CDUORG", JdeDataType.Numeric),
        new JdeField("CDUOM", "CDUOM", JdeDataType.String, 4),
        new JdeField("CDPRIC", "CDPRIC", JdeDataType.Numeric),
        new JdeField("CDAEXP", "CDAEXP", JdeDataType.Numeric),
        new JdeField("CDBDES", "CDBDES", JdeDataType.Numeric),
        new JdeField("CDBRIPI", "CDBRIPI", JdeDataType.String, 2),
        new JdeField("CDBRXIPI", "CDBRXIPI", JdeDataType.Numeric),
        new JdeField("CDBBTP", "CDBBTP", JdeDataType.Numeric),
        new JdeField("CDBIPI", "CDBIPI", JdeDataType.Numeric),
        new JdeField("CDBST2", "CDBST2", JdeDataType.String, 6),
        new JdeField("CDBRICMS", "CDBRICMS", JdeDataType.String, 2),
        new JdeField("CDBRXICMS", "CDBRXICMS", JdeDataType.Numeric),
        new JdeField("CDBBCL", "CDBBCL", JdeDataType.Numeric),
        new JdeField("CDBRAICMS", "CDBRAICMS", JdeDataType.Numeric),
        new JdeField("CDBBIS", "CDBBIS", JdeDataType.Numeric),
        new JdeField("CDBVIS", "CDBVIS", JdeDataType.Numeric),
        new JdeField("CDBRMM", "CDBRMM", JdeDataType.String, 2),
        new JdeField("CDRDOR", "CDRDOR", JdeDataType.String, 2),
        new JdeField("CDC1FU", "CDC1FU", JdeDataType.String, 2),
        new JdeField("CDC2FU", "CDC2FU", JdeDataType.String, 2),
        new JdeField("CDD1FU", "CDD1FU", JdeDataType.Numeric),
        new JdeField("CDD2FU", "CDD2FU", JdeDataType.Numeric),
        new JdeField("CDN1FU", "CDN1FU", JdeDataType.Numeric),
        new JdeField("CDN2FU", "CDN2FU", JdeDataType.Numeric),
        new JdeField("CDN3FU", "CDN3FU", JdeDataType.Numeric),
        new JdeField("CDN4FU", "CDN4FU", JdeDataType.Numeric),
        new JdeField("CDN5FU", "CDN5FU", JdeDataType.Numeric),
        new JdeField("CDN6FU", "CDN6FU", JdeDataType.Numeric),
        new JdeField("CDN7FU", "CDN7FU", JdeDataType.Numeric),
        new JdeField("CDS1FU", "CDS1FU", JdeDataType.String, 60),
        new JdeField("CDS2FU", "CDS2FU", JdeDataType.String, 60),
        new JdeField("CDS3FU", "CDS3FU", JdeDataType.String, 6),
        new JdeField("CDS4FU", "CDS4FU", JdeDataType.String, 6),
        new JdeField("CDGENLNG", "CDGENLNG", JdeDataType.Numeric),
        new JdeField("CDTORG", "CDTORG", JdeDataType.String, 20),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B411D_0", "Primary Key on CDBRNFK, CDLNID", new[] { "CDBRNFK", "CDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
