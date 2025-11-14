using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277719 - .
/// </summary>
public class F4277719 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDKCOO.
        /// </summary>
        public const string HDKCOO = "HDKCOO";

        /// <summary>
        /// HDDOCO.
        /// </summary>
        public const string HDDOCO = "HDDOCO";

        /// <summary>
        /// HDDCTO.
        /// </summary>
        public const string HDDCTO = "HDDCTO";

        /// <summary>
        /// HDLNID.
        /// </summary>
        public const string HDLNID = "HDLNID";

        /// <summary>
        /// HDOSEQ.
        /// </summary>
        public const string HDOSEQ = "HDOSEQ";

        /// <summary>
        /// HDSLRULTYP.
        /// </summary>
        public const string HDSLRULTYP = "HDSLRULTYP";

        /// <summary>
        /// HDLNMNFLPR.
        /// </summary>
        public const string HDLNMNFLPR = "HDLNMNFLPR";

        /// <summary>
        /// HDSLOVRCD.
        /// </summary>
        public const string HDSLOVRCD = "HDSLOVRCD";

        /// <summary>
        /// HDLINSLMET.
        /// </summary>
        public const string HDLINSLMET = "HDLINSLMET";

        /// <summary>
        /// HDORMNFLPR.
        /// </summary>
        public const string HDORMNFLPR = "HDORMNFLPR";

        /// <summary>
        /// HDORDSLMET.
        /// </summary>
        public const string HDORDSLMET = "HDORDSLMET";

        /// <summary>
        /// HDSLCUSTFN.
        /// </summary>
        public const string HDSLCUSTFN = "HDSLCUSTFN";

        /// <summary>
        /// HDSLRELNUM.
        /// </summary>
        public const string HDSLRELNUM = "HDSLRELNUM";

        /// <summary>
        /// HDSLCANCEL.
        /// </summary>
        public const string HDSLCANCEL = "HDSLCANCEL";

        /// <summary>
        /// HDSLCNOVRD.
        /// </summary>
        public const string HDSLCNOVRD = "HDSLCNOVRD";

        /// <summary>
        /// HDSLPRTCOM.
        /// </summary>
        public const string HDSLPRTCOM = "HDSLPRTCOM";

        /// <summary>
        /// HDRQDQTY.
        /// </summary>
        public const string HDRQDQTY = "HDRQDQTY";

        /// <summary>
        /// HDSLORILIN.
        /// </summary>
        public const string HDSLORILIN = "HDSLORILIN";

        /// <summary>
        /// HDSLMTRLCH.
        /// </summary>
        public const string HDSLMTRLCH = "HDSLMTRLCH";

        /// <summary>
        /// HDSLRCHAR1.
        /// </summary>
        public const string HDSLRCHAR1 = "HDSLRCHAR1";

        /// <summary>
        /// HDSLRCHAR2.
        /// </summary>
        public const string HDSLRCHAR2 = "HDSLRCHAR2";

        /// <summary>
        /// HDSLRCHAR3.
        /// </summary>
        public const string HDSLRCHAR3 = "HDSLRCHAR3";

        /// <summary>
        /// HDSLRSTRG1.
        /// </summary>
        public const string HDSLRSTRG1 = "HDSLRSTRG1";

        /// <summary>
        /// HDSLRSTRG2.
        /// </summary>
        public const string HDSLRSTRG2 = "HDSLRSTRG2";

        /// <summary>
        /// HDSLRSTRG3.
        /// </summary>
        public const string HDSLRSTRG3 = "HDSLRSTRG3";

        /// <summary>
        /// HDSLRAMNT1.
        /// </summary>
        public const string HDSLRAMNT1 = "HDSLRAMNT1";

        /// <summary>
        /// HDSLRAMNT2.
        /// </summary>
        public const string HDSLRAMNT2 = "HDSLRAMNT2";

        /// <summary>
        /// HDSLRAMNT3.
        /// </summary>
        public const string HDSLRAMNT3 = "HDSLRAMNT3";

        /// <summary>
        /// HDSLRNUMB1.
        /// </summary>
        public const string HDSLRNUMB1 = "HDSLRNUMB1";

        /// <summary>
        /// HDSLRNUMB2.
        /// </summary>
        public const string HDSLRNUMB2 = "HDSLRNUMB2";

        /// <summary>
        /// HDSLRNUMB3.
        /// </summary>
        public const string HDSLRNUMB3 = "HDSLRNUMB3";

        /// <summary>
        /// HDSLRDATE1.
        /// </summary>
        public const string HDSLRDATE1 = "HDSLRDATE1";

        /// <summary>
        /// HDSLRDATE2.
        /// </summary>
        public const string HDSLRDATE2 = "HDSLRDATE2";

        /// <summary>
        /// HDSLRDATE3.
        /// </summary>
        public const string HDSLRDATE3 = "HDSLRDATE3";

        /// <summary>
        /// HDSLRCODE1.
        /// </summary>
        public const string HDSLRCODE1 = "HDSLRCODE1";

        /// <summary>
        /// HDSLRCODE2.
        /// </summary>
        public const string HDSLRCODE2 = "HDSLRCODE2";

        /// <summary>
        /// HDSLRCODE3.
        /// </summary>
        public const string HDSLRCODE3 = "HDSLRCODE3";

        /// <summary>
        /// HDURCD.
        /// </summary>
        public const string HDURCD = "HDURCD";

        /// <summary>
        /// HDURDT.
        /// </summary>
        public const string HDURDT = "HDURDT";

        /// <summary>
        /// HDURAT.
        /// </summary>
        public const string HDURAT = "HDURAT";

        /// <summary>
        /// HDURAB.
        /// </summary>
        public const string HDURAB = "HDURAB";

        /// <summary>
        /// HDURRF.
        /// </summary>
        public const string HDURRF = "HDURRF";

        /// <summary>
        /// HDUSER.
        /// </summary>
        public const string HDUSER = "HDUSER";

        /// <summary>
        /// HDPID.
        /// </summary>
        public const string HDPID = "HDPID";

        /// <summary>
        /// HDJOBN.
        /// </summary>
        public const string HDJOBN = "HDJOBN";

        /// <summary>
        /// HDUPMJ.
        /// </summary>
        public const string HDUPMJ = "HDUPMJ";

        /// <summary>
        /// HDTDAY.
        /// </summary>
        public const string HDTDAY = "HDTDAY";

        /// <summary>
        /// HDUTIME.
        /// </summary>
        public const string HDUTIME = "HDUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277719";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDKCOO", "HDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("HDDOCO", "HDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HDDCTO", "HDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("HDLNID", "HDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("HDOSEQ", "HDOSEQ", JdeDataType.Numeric),
        new JdeField("HDSLRULTYP", "HDSLRULTYP", JdeDataType.String, 4),
        new JdeField("HDLNMNFLPR", "HDLNMNFLPR", JdeDataType.Numeric),
        new JdeField("HDSLOVRCD", "HDSLOVRCD", JdeDataType.String, 6),
        new JdeField("HDLINSLMET", "HDLINSLMET", JdeDataType.String, 2),
        new JdeField("HDORMNFLPR", "HDORMNFLPR", JdeDataType.Numeric),
        new JdeField("HDORDSLMET", "HDORDSLMET", JdeDataType.String, 2),
        new JdeField("HDSLCUSTFN", "HDSLCUSTFN", JdeDataType.String, 64),
        new JdeField("HDSLRELNUM", "HDSLRELNUM", JdeDataType.Numeric),
        new JdeField("HDSLCANCEL", "HDSLCANCEL", JdeDataType.String, 2),
        new JdeField("HDSLCNOVRD", "HDSLCNOVRD", JdeDataType.String, 2),
        new JdeField("HDSLPRTCOM", "HDSLPRTCOM", JdeDataType.String, 2),
        new JdeField("HDRQDQTY", "HDRQDQTY", JdeDataType.Numeric),
        new JdeField("HDSLORILIN", "HDSLORILIN", JdeDataType.Numeric),
        new JdeField("HDSLMTRLCH", "HDSLMTRLCH", JdeDataType.String, 2),
        new JdeField("HDSLRCHAR1", "HDSLRCHAR1", JdeDataType.String, 2),
        new JdeField("HDSLRCHAR2", "HDSLRCHAR2", JdeDataType.String, 2),
        new JdeField("HDSLRCHAR3", "HDSLRCHAR3", JdeDataType.String, 2),
        new JdeField("HDSLRSTRG1", "HDSLRSTRG1", JdeDataType.String, 60),
        new JdeField("HDSLRSTRG2", "HDSLRSTRG2", JdeDataType.String, 60),
        new JdeField("HDSLRSTRG3", "HDSLRSTRG3", JdeDataType.String, 60),
        new JdeField("HDSLRAMNT1", "HDSLRAMNT1", JdeDataType.Numeric),
        new JdeField("HDSLRAMNT2", "HDSLRAMNT2", JdeDataType.Numeric),
        new JdeField("HDSLRAMNT3", "HDSLRAMNT3", JdeDataType.Numeric),
        new JdeField("HDSLRNUMB1", "HDSLRNUMB1", JdeDataType.Numeric),
        new JdeField("HDSLRNUMB2", "HDSLRNUMB2", JdeDataType.Numeric),
        new JdeField("HDSLRNUMB3", "HDSLRNUMB3", JdeDataType.Numeric),
        new JdeField("HDSLRDATE1", "HDSLRDATE1", JdeDataType.Numeric),
        new JdeField("HDSLRDATE2", "HDSLRDATE2", JdeDataType.Numeric),
        new JdeField("HDSLRDATE3", "HDSLRDATE3", JdeDataType.Numeric),
        new JdeField("HDSLRCODE1", "HDSLRCODE1", JdeDataType.String, 4),
        new JdeField("HDSLRCODE2", "HDSLRCODE2", JdeDataType.String, 4),
        new JdeField("HDSLRCODE3", "HDSLRCODE3", JdeDataType.String, 4),
        new JdeField("HDURCD", "HDURCD", JdeDataType.String, 4),
        new JdeField("HDURDT", "HDURDT", JdeDataType.Numeric),
        new JdeField("HDURAT", "HDURAT", JdeDataType.Numeric),
        new JdeField("HDURAB", "HDURAB", JdeDataType.Numeric),
        new JdeField("HDURRF", "HDURRF", JdeDataType.String, 30),
        new JdeField("HDUSER", "HDUSER", JdeDataType.String, 20),
        new JdeField("HDPID", "HDPID", JdeDataType.String, 20),
        new JdeField("HDJOBN", "HDJOBN", JdeDataType.String, 20),
        new JdeField("HDUPMJ", "HDUPMJ", JdeDataType.Numeric),
        new JdeField("HDTDAY", "HDTDAY", JdeDataType.Numeric),
        new JdeField("HDUTIME", "HDUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277719_0", "Primary Key on HDKCOO, HDDOCO, HDDCTO, HDLNID", new[] { "HDKCOO", "HDDOCO", "HDDCTO", "HDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
