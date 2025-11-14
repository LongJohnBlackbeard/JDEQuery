using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277711 - .
/// </summary>
public class F4277711 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDKCOO.
        /// </summary>
        public const string RDKCOO = "RDKCOO";

        /// <summary>
        /// RDDOCO.
        /// </summary>
        public const string RDDOCO = "RDDOCO";

        /// <summary>
        /// RDDCTO.
        /// </summary>
        public const string RDDCTO = "RDDCTO";

        /// <summary>
        /// RDLNID.
        /// </summary>
        public const string RDLNID = "RDLNID";

        /// <summary>
        /// RDOSEQ.
        /// </summary>
        public const string RDOSEQ = "RDOSEQ";

        /// <summary>
        /// RDSLRULTYP.
        /// </summary>
        public const string RDSLRULTYP = "RDSLRULTYP";

        /// <summary>
        /// RDLNMNFLPR.
        /// </summary>
        public const string RDLNMNFLPR = "RDLNMNFLPR";

        /// <summary>
        /// RDSLOVRCD.
        /// </summary>
        public const string RDSLOVRCD = "RDSLOVRCD";

        /// <summary>
        /// RDLINSLMET.
        /// </summary>
        public const string RDLINSLMET = "RDLINSLMET";

        /// <summary>
        /// RDORMNFLPR.
        /// </summary>
        public const string RDORMNFLPR = "RDORMNFLPR";

        /// <summary>
        /// RDORDSLMET.
        /// </summary>
        public const string RDORDSLMET = "RDORDSLMET";

        /// <summary>
        /// RDSLCUSTFN.
        /// </summary>
        public const string RDSLCUSTFN = "RDSLCUSTFN";

        /// <summary>
        /// RDSLRELNUM.
        /// </summary>
        public const string RDSLRELNUM = "RDSLRELNUM";

        /// <summary>
        /// RDSLCANCEL.
        /// </summary>
        public const string RDSLCANCEL = "RDSLCANCEL";

        /// <summary>
        /// RDSLCNOVRD.
        /// </summary>
        public const string RDSLCNOVRD = "RDSLCNOVRD";

        /// <summary>
        /// RDSLPRTCOM.
        /// </summary>
        public const string RDSLPRTCOM = "RDSLPRTCOM";

        /// <summary>
        /// RDRQDQTY.
        /// </summary>
        public const string RDRQDQTY = "RDRQDQTY";

        /// <summary>
        /// RDSLORILIN.
        /// </summary>
        public const string RDSLORILIN = "RDSLORILIN";

        /// <summary>
        /// RDSLMTRLCH.
        /// </summary>
        public const string RDSLMTRLCH = "RDSLMTRLCH";

        /// <summary>
        /// RDSLRCHAR1.
        /// </summary>
        public const string RDSLRCHAR1 = "RDSLRCHAR1";

        /// <summary>
        /// RDSLRCHAR2.
        /// </summary>
        public const string RDSLRCHAR2 = "RDSLRCHAR2";

        /// <summary>
        /// RDSLRCHAR3.
        /// </summary>
        public const string RDSLRCHAR3 = "RDSLRCHAR3";

        /// <summary>
        /// RDSLRSTRG1.
        /// </summary>
        public const string RDSLRSTRG1 = "RDSLRSTRG1";

        /// <summary>
        /// RDSLRSTRG2.
        /// </summary>
        public const string RDSLRSTRG2 = "RDSLRSTRG2";

        /// <summary>
        /// RDSLRSTRG3.
        /// </summary>
        public const string RDSLRSTRG3 = "RDSLRSTRG3";

        /// <summary>
        /// RDSLRAMNT1.
        /// </summary>
        public const string RDSLRAMNT1 = "RDSLRAMNT1";

        /// <summary>
        /// RDSLRAMNT2.
        /// </summary>
        public const string RDSLRAMNT2 = "RDSLRAMNT2";

        /// <summary>
        /// RDSLRAMNT3.
        /// </summary>
        public const string RDSLRAMNT3 = "RDSLRAMNT3";

        /// <summary>
        /// RDSLRNUMB1.
        /// </summary>
        public const string RDSLRNUMB1 = "RDSLRNUMB1";

        /// <summary>
        /// RDSLRNUMB2.
        /// </summary>
        public const string RDSLRNUMB2 = "RDSLRNUMB2";

        /// <summary>
        /// RDSLRNUMB3.
        /// </summary>
        public const string RDSLRNUMB3 = "RDSLRNUMB3";

        /// <summary>
        /// RDSLRDATE1.
        /// </summary>
        public const string RDSLRDATE1 = "RDSLRDATE1";

        /// <summary>
        /// RDSLRDATE2.
        /// </summary>
        public const string RDSLRDATE2 = "RDSLRDATE2";

        /// <summary>
        /// RDSLRDATE3.
        /// </summary>
        public const string RDSLRDATE3 = "RDSLRDATE3";

        /// <summary>
        /// RDSLRCODE1.
        /// </summary>
        public const string RDSLRCODE1 = "RDSLRCODE1";

        /// <summary>
        /// RDSLRCODE2.
        /// </summary>
        public const string RDSLRCODE2 = "RDSLRCODE2";

        /// <summary>
        /// RDSLRCODE3.
        /// </summary>
        public const string RDSLRCODE3 = "RDSLRCODE3";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";

        /// <summary>
        /// RDUTIME.
        /// </summary>
        public const string RDUTIME = "RDUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277711";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDKCOO", "RDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RDDOCO", "RDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RDDCTO", "RDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RDLNID", "RDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDOSEQ", "RDOSEQ", JdeDataType.Numeric),
        new JdeField("RDSLRULTYP", "RDSLRULTYP", JdeDataType.String, 4),
        new JdeField("RDLNMNFLPR", "RDLNMNFLPR", JdeDataType.Numeric),
        new JdeField("RDSLOVRCD", "RDSLOVRCD", JdeDataType.String, 6),
        new JdeField("RDLINSLMET", "RDLINSLMET", JdeDataType.String, 2),
        new JdeField("RDORMNFLPR", "RDORMNFLPR", JdeDataType.Numeric),
        new JdeField("RDORDSLMET", "RDORDSLMET", JdeDataType.String, 2),
        new JdeField("RDSLCUSTFN", "RDSLCUSTFN", JdeDataType.String, 64),
        new JdeField("RDSLRELNUM", "RDSLRELNUM", JdeDataType.Numeric),
        new JdeField("RDSLCANCEL", "RDSLCANCEL", JdeDataType.String, 2),
        new JdeField("RDSLCNOVRD", "RDSLCNOVRD", JdeDataType.String, 2),
        new JdeField("RDSLPRTCOM", "RDSLPRTCOM", JdeDataType.String, 2),
        new JdeField("RDRQDQTY", "RDRQDQTY", JdeDataType.Numeric),
        new JdeField("RDSLORILIN", "RDSLORILIN", JdeDataType.Numeric),
        new JdeField("RDSLMTRLCH", "RDSLMTRLCH", JdeDataType.String, 2),
        new JdeField("RDSLRCHAR1", "RDSLRCHAR1", JdeDataType.String, 2),
        new JdeField("RDSLRCHAR2", "RDSLRCHAR2", JdeDataType.String, 2),
        new JdeField("RDSLRCHAR3", "RDSLRCHAR3", JdeDataType.String, 2),
        new JdeField("RDSLRSTRG1", "RDSLRSTRG1", JdeDataType.String, 60),
        new JdeField("RDSLRSTRG2", "RDSLRSTRG2", JdeDataType.String, 60),
        new JdeField("RDSLRSTRG3", "RDSLRSTRG3", JdeDataType.String, 60),
        new JdeField("RDSLRAMNT1", "RDSLRAMNT1", JdeDataType.Numeric),
        new JdeField("RDSLRAMNT2", "RDSLRAMNT2", JdeDataType.Numeric),
        new JdeField("RDSLRAMNT3", "RDSLRAMNT3", JdeDataType.Numeric),
        new JdeField("RDSLRNUMB1", "RDSLRNUMB1", JdeDataType.Numeric),
        new JdeField("RDSLRNUMB2", "RDSLRNUMB2", JdeDataType.Numeric),
        new JdeField("RDSLRNUMB3", "RDSLRNUMB3", JdeDataType.Numeric),
        new JdeField("RDSLRDATE1", "RDSLRDATE1", JdeDataType.Numeric),
        new JdeField("RDSLRDATE2", "RDSLRDATE2", JdeDataType.Numeric),
        new JdeField("RDSLRDATE3", "RDSLRDATE3", JdeDataType.Numeric),
        new JdeField("RDSLRCODE1", "RDSLRCODE1", JdeDataType.String, 4),
        new JdeField("RDSLRCODE2", "RDSLRCODE2", JdeDataType.String, 4),
        new JdeField("RDSLRCODE3", "RDSLRCODE3", JdeDataType.String, 4),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric),
        new JdeField("RDUTIME", "RDUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277711_0", "Primary Key on RDKCOO, RDDOCO, RDDCTO, RDLNID", new[] { "RDKCOO", "RDDOCO", "RDDCTO", "RDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
