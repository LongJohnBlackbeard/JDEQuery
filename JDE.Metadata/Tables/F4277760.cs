using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277760 - .
/// </summary>
public class F4277760 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SROSEQ.
        /// </summary>
        public const string SROSEQ = "SROSEQ";

        /// <summary>
        /// SRAN8.
        /// </summary>
        public const string SRAN8 = "SRAN8";

        /// <summary>
        /// SRCPGP.
        /// </summary>
        public const string SRCPGP = "SRCPGP";

        /// <summary>
        /// SRITM.
        /// </summary>
        public const string SRITM = "SRITM";

        /// <summary>
        /// SRPRGR.
        /// </summary>
        public const string SRPRGR = "SRPRGR";

        /// <summary>
        /// SRMCU.
        /// </summary>
        public const string SRMCU = "SRMCU";

        /// <summary>
        /// SREFTJ.
        /// </summary>
        public const string SREFTJ = "SREFTJ";

        /// <summary>
        /// SREXDJ.
        /// </summary>
        public const string SREXDJ = "SREXDJ";

        /// <summary>
        /// SRSLRELNUM.
        /// </summary>
        public const string SRSLRELNUM = "SRSLRELNUM";

        /// <summary>
        /// SRSLRULTYP.
        /// </summary>
        public const string SRSLRULTYP = "SRSLRULTYP";

        /// <summary>
        /// SRLNMNFLPR.
        /// </summary>
        public const string SRLNMNFLPR = "SRLNMNFLPR";

        /// <summary>
        /// SRORMNFLPR.
        /// </summary>
        public const string SRORMNFLPR = "SRORMNFLPR";

        /// <summary>
        /// SRSLCUSTFN.
        /// </summary>
        public const string SRSLCUSTFN = "SRSLCUSTFN";

        /// <summary>
        /// SRSLPRTCOM.
        /// </summary>
        public const string SRSLPRTCOM = "SRSLPRTCOM";

        /// <summary>
        /// SRSLCANCEL.
        /// </summary>
        public const string SRSLCANCEL = "SRSLCANCEL";

        /// <summary>
        /// SRSLRCODE1.
        /// </summary>
        public const string SRSLRCODE1 = "SRSLRCODE1";

        /// <summary>
        /// SRSLRCODE2.
        /// </summary>
        public const string SRSLRCODE2 = "SRSLRCODE2";

        /// <summary>
        /// SRSLRCODE3.
        /// </summary>
        public const string SRSLRCODE3 = "SRSLRCODE3";

        /// <summary>
        /// SRSLRDATE1.
        /// </summary>
        public const string SRSLRDATE1 = "SRSLRDATE1";

        /// <summary>
        /// SRSLRDATE2.
        /// </summary>
        public const string SRSLRDATE2 = "SRSLRDATE2";

        /// <summary>
        /// SRSLRDATE3.
        /// </summary>
        public const string SRSLRDATE3 = "SRSLRDATE3";

        /// <summary>
        /// SRSLRAMNT1.
        /// </summary>
        public const string SRSLRAMNT1 = "SRSLRAMNT1";

        /// <summary>
        /// SRSLRAMNT2.
        /// </summary>
        public const string SRSLRAMNT2 = "SRSLRAMNT2";

        /// <summary>
        /// SRSLRAMNT3.
        /// </summary>
        public const string SRSLRAMNT3 = "SRSLRAMNT3";

        /// <summary>
        /// SRSLRNUMB1.
        /// </summary>
        public const string SRSLRNUMB1 = "SRSLRNUMB1";

        /// <summary>
        /// SRSLRNUMB2.
        /// </summary>
        public const string SRSLRNUMB2 = "SRSLRNUMB2";

        /// <summary>
        /// SRSLRNUMB3.
        /// </summary>
        public const string SRSLRNUMB3 = "SRSLRNUMB3";

        /// <summary>
        /// SRSLRSTRG1.
        /// </summary>
        public const string SRSLRSTRG1 = "SRSLRSTRG1";

        /// <summary>
        /// SRSLRSTRG2.
        /// </summary>
        public const string SRSLRSTRG2 = "SRSLRSTRG2";

        /// <summary>
        /// SRSLRSTRG3.
        /// </summary>
        public const string SRSLRSTRG3 = "SRSLRSTRG3";

        /// <summary>
        /// SRSLRCHAR1.
        /// </summary>
        public const string SRSLRCHAR1 = "SRSLRCHAR1";

        /// <summary>
        /// SRSLRCHAR2.
        /// </summary>
        public const string SRSLRCHAR2 = "SRSLRCHAR2";

        /// <summary>
        /// SRSLRCHAR3.
        /// </summary>
        public const string SRSLRCHAR3 = "SRSLRCHAR3";

        /// <summary>
        /// SRURCD.
        /// </summary>
        public const string SRURCD = "SRURCD";

        /// <summary>
        /// SRURDT.
        /// </summary>
        public const string SRURDT = "SRURDT";

        /// <summary>
        /// SRURAT.
        /// </summary>
        public const string SRURAT = "SRURAT";

        /// <summary>
        /// SRURAB.
        /// </summary>
        public const string SRURAB = "SRURAB";

        /// <summary>
        /// SRURRF.
        /// </summary>
        public const string SRURRF = "SRURRF";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRTDAY.
        /// </summary>
        public const string SRTDAY = "SRTDAY";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRUTIME.
        /// </summary>
        public const string SRUTIME = "SRUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277760";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SROSEQ", "SROSEQ", JdeDataType.Numeric),
        new JdeField("SRAN8", "SRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SRCPGP", "SRCPGP", JdeDataType.String, 16, true, true),
        new JdeField("SRITM", "SRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SRPRGR", "SRPRGR", JdeDataType.String, 16, true, true),
        new JdeField("SRMCU", "SRMCU", JdeDataType.String, 24, true, true),
        new JdeField("SREFTJ", "SREFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SREXDJ", "SREXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SRSLRELNUM", "SRSLRELNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("SRSLRULTYP", "SRSLRULTYP", JdeDataType.String, 4),
        new JdeField("SRLNMNFLPR", "SRLNMNFLPR", JdeDataType.Numeric),
        new JdeField("SRORMNFLPR", "SRORMNFLPR", JdeDataType.Numeric),
        new JdeField("SRSLCUSTFN", "SRSLCUSTFN", JdeDataType.String, 64),
        new JdeField("SRSLPRTCOM", "SRSLPRTCOM", JdeDataType.String, 2),
        new JdeField("SRSLCANCEL", "SRSLCANCEL", JdeDataType.String, 2),
        new JdeField("SRSLRCODE1", "SRSLRCODE1", JdeDataType.String, 4),
        new JdeField("SRSLRCODE2", "SRSLRCODE2", JdeDataType.String, 4),
        new JdeField("SRSLRCODE3", "SRSLRCODE3", JdeDataType.String, 4),
        new JdeField("SRSLRDATE1", "SRSLRDATE1", JdeDataType.Numeric),
        new JdeField("SRSLRDATE2", "SRSLRDATE2", JdeDataType.Numeric),
        new JdeField("SRSLRDATE3", "SRSLRDATE3", JdeDataType.Numeric),
        new JdeField("SRSLRAMNT1", "SRSLRAMNT1", JdeDataType.Numeric),
        new JdeField("SRSLRAMNT2", "SRSLRAMNT2", JdeDataType.Numeric),
        new JdeField("SRSLRAMNT3", "SRSLRAMNT3", JdeDataType.Numeric),
        new JdeField("SRSLRNUMB1", "SRSLRNUMB1", JdeDataType.Numeric),
        new JdeField("SRSLRNUMB2", "SRSLRNUMB2", JdeDataType.Numeric),
        new JdeField("SRSLRNUMB3", "SRSLRNUMB3", JdeDataType.Numeric),
        new JdeField("SRSLRSTRG1", "SRSLRSTRG1", JdeDataType.String, 60),
        new JdeField("SRSLRSTRG2", "SRSLRSTRG2", JdeDataType.String, 60),
        new JdeField("SRSLRSTRG3", "SRSLRSTRG3", JdeDataType.String, 60),
        new JdeField("SRSLRCHAR1", "SRSLRCHAR1", JdeDataType.String, 2),
        new JdeField("SRSLRCHAR2", "SRSLRCHAR2", JdeDataType.String, 2),
        new JdeField("SRSLRCHAR3", "SRSLRCHAR3", JdeDataType.String, 2),
        new JdeField("SRURCD", "SRURCD", JdeDataType.String, 4),
        new JdeField("SRURDT", "SRURDT", JdeDataType.Numeric),
        new JdeField("SRURAT", "SRURAT", JdeDataType.Numeric),
        new JdeField("SRURAB", "SRURAB", JdeDataType.Numeric),
        new JdeField("SRURRF", "SRURRF", JdeDataType.String, 30),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRTDAY", "SRTDAY", JdeDataType.Numeric),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRUTIME", "SRUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277760_0", "Primary Key on SRAN8, SRCPGP, SRITM, SRPRGR, SRMCU, SREFTJ, SREXDJ, SRSLRELNUM", new[] { "SRAN8", "SRCPGP", "SRITM", "SRPRGR", "SRMCU", "SREFTJ", "SREXDJ", "SRSLRELNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4277760_2", "Unique Index on SROSEQ", new[] { "SROSEQ" }, isUnique: true)
    };
}
