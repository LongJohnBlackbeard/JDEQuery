using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I07 - .
/// </summary>
public class F42I07 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OQDMCT.
        /// </summary>
        public const string OQDMCT = "OQDMCT";

        /// <summary>
        /// OQDMCS.
        /// </summary>
        public const string OQDMCS = "OQDMCS";

        /// <summary>
        /// OQCNUKID.
        /// </summary>
        public const string OQCNUKID = "OQCNUKID";

        /// <summary>
        /// OQCNQY.
        /// </summary>
        public const string OQCNQY = "OQCNQY";

        /// <summary>
        /// OQDTO.
        /// </summary>
        public const string OQDTO = "OQDTO";

        /// <summary>
        /// OQDES.
        /// </summary>
        public const string OQDES = "OQDES";

        /// <summary>
        /// OQDESY.
        /// </summary>
        public const string OQDESY = "OQDESY";

        /// <summary>
        /// OQITM.
        /// </summary>
        public const string OQITM = "OQITM";

        /// <summary>
        /// OQSEQ.
        /// </summary>
        public const string OQSEQ = "OQSEQ";

        /// <summary>
        /// OQCNQT.
        /// </summary>
        public const string OQCNQT = "OQCNQT";

        /// <summary>
        /// OQAA.
        /// </summary>
        public const string OQAA = "OQAA";

        /// <summary>
        /// OQUOM.
        /// </summary>
        public const string OQUOM = "OQUOM";

        /// <summary>
        /// OQMINQ.
        /// </summary>
        public const string OQMINQ = "OQMINQ";

        /// <summary>
        /// OQMAXQ.
        /// </summary>
        public const string OQMAXQ = "OQMAXQ";

        /// <summary>
        /// OQEFTJ.
        /// </summary>
        public const string OQEFTJ = "OQEFTJ";

        /// <summary>
        /// OQEXDJ.
        /// </summary>
        public const string OQEXDJ = "OQEXDJ";

        /// <summary>
        /// OQUPRC.
        /// </summary>
        public const string OQUPRC = "OQUPRC";

        /// <summary>
        /// OQASN.
        /// </summary>
        public const string OQASN = "OQASN";

        /// <summary>
        /// OQPASN.
        /// </summary>
        public const string OQPASN = "OQPASN";

        /// <summary>
        /// OQMCU.
        /// </summary>
        public const string OQMCU = "OQMCU";

        /// <summary>
        /// OQCRCD.
        /// </summary>
        public const string OQCRCD = "OQCRCD";

        /// <summary>
        /// OQTV01.
        /// </summary>
        public const string OQTV01 = "OQTV01";

        /// <summary>
        /// OQTV02.
        /// </summary>
        public const string OQTV02 = "OQTV02";

        /// <summary>
        /// OQTV03.
        /// </summary>
        public const string OQTV03 = "OQTV03";

        /// <summary>
        /// OQQTY1.
        /// </summary>
        public const string OQQTY1 = "OQQTY1";

        /// <summary>
        /// OQTVUM.
        /// </summary>
        public const string OQTVUM = "OQTVUM";

        /// <summary>
        /// OQRPQT.
        /// </summary>
        public const string OQRPQT = "OQRPQT";

        /// <summary>
        /// OQQEDT.
        /// </summary>
        public const string OQQEDT = "OQQEDT";

        /// <summary>
        /// OQQED3.
        /// </summary>
        public const string OQQED3 = "OQQED3";

        /// <summary>
        /// OQQED2.
        /// </summary>
        public const string OQQED2 = "OQQED2";

        /// <summary>
        /// OQPDP5.
        /// </summary>
        public const string OQPDP5 = "OQPDP5";

        /// <summary>
        /// OQAN8.
        /// </summary>
        public const string OQAN8 = "OQAN8";

        /// <summary>
        /// OQMINQC.
        /// </summary>
        public const string OQMINQC = "OQMINQC";

        /// <summary>
        /// OQMAXQC.
        /// </summary>
        public const string OQMAXQC = "OQMAXQC";

        /// <summary>
        /// OQLOCN.
        /// </summary>
        public const string OQLOCN = "OQLOCN";

        /// <summary>
        /// OQORSH.
        /// </summary>
        public const string OQORSH = "OQORSH";

        /// <summary>
        /// OQRTMD.
        /// </summary>
        public const string OQRTMD = "OQRTMD";

        /// <summary>
        /// OQRPFQ.
        /// </summary>
        public const string OQRPFQ = "OQRPFQ";

        /// <summary>
        /// OQADFY.
        /// </summary>
        public const string OQADFY = "OQADFY";

        /// <summary>
        /// OQSHAN.
        /// </summary>
        public const string OQSHAN = "OQSHAN";

        /// <summary>
        /// OQTIQTY.
        /// </summary>
        public const string OQTIQTY = "OQTIQTY";

        /// <summary>
        /// OQUOM1.
        /// </summary>
        public const string OQUOM1 = "OQUOM1";

        /// <summary>
        /// OQROPI.
        /// </summary>
        public const string OQROPI = "OQROPI";

        /// <summary>
        /// OQRUOM.
        /// </summary>
        public const string OQRUOM = "OQRUOM";

        /// <summary>
        /// OQCYDT.
        /// </summary>
        public const string OQCYDT = "OQCYDT";

        /// <summary>
        /// OQ42IRC.
        /// </summary>
        public const string OQ42IRC = "OQ42IRC";

        /// <summary>
        /// OQCMAN.
        /// </summary>
        public const string OQCMAN = "OQCMAN";

        /// <summary>
        /// OQACKLDT.
        /// </summary>
        public const string OQACKLDT = "OQACKLDT";

        /// <summary>
        /// OQPRCOVRD.
        /// </summary>
        public const string OQPRCOVRD = "OQPRCOVRD";

        /// <summary>
        /// OQRQTYOVRD.
        /// </summary>
        public const string OQRQTYOVRD = "OQRQTYOVRD";

        /// <summary>
        /// OQTOLRQTY.
        /// </summary>
        public const string OQTOLRQTY = "OQTOLRQTY";

        /// <summary>
        /// OQTOLPRICE.
        /// </summary>
        public const string OQTOLPRICE = "OQTOLPRICE";

        /// <summary>
        /// OQOIPR.
        /// </summary>
        public const string OQOIPR = "OQOIPR";

        /// <summary>
        /// OQUITM.
        /// </summary>
        public const string OQUITM = "OQUITM";

        /// <summary>
        /// OQCUSTFN.
        /// </summary>
        public const string OQCUSTFN = "OQCUSTFN";

        /// <summary>
        /// OQTOAN8.
        /// </summary>
        public const string OQTOAN8 = "OQTOAN8";

        /// <summary>
        /// OQFUCHAR3.
        /// </summary>
        public const string OQFUCHAR3 = "OQFUCHAR3";

        /// <summary>
        /// OQFUCHAR4.
        /// </summary>
        public const string OQFUCHAR4 = "OQFUCHAR4";

        /// <summary>
        /// OQFUCHAR5.
        /// </summary>
        public const string OQFUCHAR5 = "OQFUCHAR5";

        /// <summary>
        /// OQFUTNUM1.
        /// </summary>
        public const string OQFUTNUM1 = "OQFUTNUM1";

        /// <summary>
        /// OQFUTNUM2.
        /// </summary>
        public const string OQFUTNUM2 = "OQFUTNUM2";

        /// <summary>
        /// OQFUTNUM3.
        /// </summary>
        public const string OQFUTNUM3 = "OQFUTNUM3";

        /// <summary>
        /// OQFSTR1.
        /// </summary>
        public const string OQFSTR1 = "OQFSTR1";

        /// <summary>
        /// OQFSTR2.
        /// </summary>
        public const string OQFSTR2 = "OQFSTR2";

        /// <summary>
        /// OQFSTR3.
        /// </summary>
        public const string OQFSTR3 = "OQFSTR3";

        /// <summary>
        /// OQFUDT10.
        /// </summary>
        public const string OQFUDT10 = "OQFUDT10";

        /// <summary>
        /// OQFUDT14.
        /// </summary>
        public const string OQFUDT14 = "OQFUDT14";

        /// <summary>
        /// OQFUDT24.
        /// </summary>
        public const string OQFUDT24 = "OQFUDT24";

        /// <summary>
        /// OQURCD.
        /// </summary>
        public const string OQURCD = "OQURCD";

        /// <summary>
        /// OQURDT.
        /// </summary>
        public const string OQURDT = "OQURDT";

        /// <summary>
        /// OQURAT.
        /// </summary>
        public const string OQURAT = "OQURAT";

        /// <summary>
        /// OQURAB.
        /// </summary>
        public const string OQURAB = "OQURAB";

        /// <summary>
        /// OQURRF.
        /// </summary>
        public const string OQURRF = "OQURRF";

        /// <summary>
        /// OQUSER.
        /// </summary>
        public const string OQUSER = "OQUSER";

        /// <summary>
        /// OQPID.
        /// </summary>
        public const string OQPID = "OQPID";

        /// <summary>
        /// OQJOBN.
        /// </summary>
        public const string OQJOBN = "OQJOBN";

        /// <summary>
        /// OQUPMJ.
        /// </summary>
        public const string OQUPMJ = "OQUPMJ";

        /// <summary>
        /// OQTDAY.
        /// </summary>
        public const string OQTDAY = "OQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F42I07";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OQDMCT", "OQDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OQDMCS", "OQDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OQCNUKID", "OQCNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OQCNQY", "OQCNQY", JdeDataType.String, 2),
        new JdeField("OQDTO", "OQDTO", JdeDataType.String, 2),
        new JdeField("OQDES", "OQDES", JdeDataType.String, 24),
        new JdeField("OQDESY", "OQDESY", JdeDataType.String, 4),
        new JdeField("OQITM", "OQITM", JdeDataType.Numeric),
        new JdeField("OQSEQ", "OQSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OQCNQT", "OQCNQT", JdeDataType.Numeric),
        new JdeField("OQAA", "OQAA", JdeDataType.Numeric),
        new JdeField("OQUOM", "OQUOM", JdeDataType.String, 4),
        new JdeField("OQMINQ", "OQMINQ", JdeDataType.Numeric),
        new JdeField("OQMAXQ", "OQMAXQ", JdeDataType.Numeric),
        new JdeField("OQEFTJ", "OQEFTJ", JdeDataType.Numeric),
        new JdeField("OQEXDJ", "OQEXDJ", JdeDataType.Numeric),
        new JdeField("OQUPRC", "OQUPRC", JdeDataType.Numeric),
        new JdeField("OQASN", "OQASN", JdeDataType.String, 16),
        new JdeField("OQPASN", "OQPASN", JdeDataType.String, 16),
        new JdeField("OQMCU", "OQMCU", JdeDataType.String, 24),
        new JdeField("OQCRCD", "OQCRCD", JdeDataType.String, 6),
        new JdeField("OQTV01", "OQTV01", JdeDataType.String, 2),
        new JdeField("OQTV02", "OQTV02", JdeDataType.String, 2),
        new JdeField("OQTV03", "OQTV03", JdeDataType.String, 2),
        new JdeField("OQQTY1", "OQQTY1", JdeDataType.Numeric),
        new JdeField("OQTVUM", "OQTVUM", JdeDataType.String, 4),
        new JdeField("OQRPQT", "OQRPQT", JdeDataType.Numeric),
        new JdeField("OQQEDT", "OQQEDT", JdeDataType.String, 2),
        new JdeField("OQQED3", "OQQED3", JdeDataType.String, 2),
        new JdeField("OQQED2", "OQQED2", JdeDataType.String, 2),
        new JdeField("OQPDP5", "OQPDP5", JdeDataType.String, 6),
        new JdeField("OQAN8", "OQAN8", JdeDataType.Numeric),
        new JdeField("OQMINQC", "OQMINQC", JdeDataType.Numeric),
        new JdeField("OQMAXQC", "OQMAXQC", JdeDataType.Numeric),
        new JdeField("OQLOCN", "OQLOCN", JdeDataType.String, 40),
        new JdeField("OQORSH", "OQORSH", JdeDataType.String, 2),
        new JdeField("OQRTMD", "OQRTMD", JdeDataType.String, 2),
        new JdeField("OQRPFQ", "OQRPFQ", JdeDataType.String, 2),
        new JdeField("OQADFY", "OQADFY", JdeDataType.String, 2),
        new JdeField("OQSHAN", "OQSHAN", JdeDataType.Numeric),
        new JdeField("OQTIQTY", "OQTIQTY", JdeDataType.Numeric),
        new JdeField("OQUOM1", "OQUOM1", JdeDataType.String, 4),
        new JdeField("OQROPI", "OQROPI", JdeDataType.Numeric),
        new JdeField("OQRUOM", "OQRUOM", JdeDataType.String, 4),
        new JdeField("OQCYDT", "OQCYDT", JdeDataType.Numeric),
        new JdeField("OQ42IRC", "OQ42IRC", JdeDataType.String, 6),
        new JdeField("OQCMAN", "OQCMAN", JdeDataType.Numeric),
        new JdeField("OQACKLDT", "OQACKLDT", JdeDataType.Date),
        new JdeField("OQPRCOVRD", "OQPRCOVRD", JdeDataType.String, 2),
        new JdeField("OQRQTYOVRD", "OQRQTYOVRD", JdeDataType.String, 2),
        new JdeField("OQTOLRQTY", "OQTOLRQTY", JdeDataType.Numeric),
        new JdeField("OQTOLPRICE", "OQTOLPRICE", JdeDataType.Numeric),
        new JdeField("OQOIPR", "OQOIPR", JdeDataType.String, 16),
        new JdeField("OQUITM", "OQUITM", JdeDataType.String, 52),
        new JdeField("OQCUSTFN", "OQCUSTFN", JdeDataType.String, 64),
        new JdeField("OQTOAN8", "OQTOAN8", JdeDataType.Numeric),
        new JdeField("OQFUCHAR3", "OQFUCHAR3", JdeDataType.String, 2),
        new JdeField("OQFUCHAR4", "OQFUCHAR4", JdeDataType.String, 2),
        new JdeField("OQFUCHAR5", "OQFUCHAR5", JdeDataType.String, 2),
        new JdeField("OQFUTNUM1", "OQFUTNUM1", JdeDataType.Numeric),
        new JdeField("OQFUTNUM2", "OQFUTNUM2", JdeDataType.Numeric),
        new JdeField("OQFUTNUM3", "OQFUTNUM3", JdeDataType.Numeric),
        new JdeField("OQFSTR1", "OQFSTR1", JdeDataType.String, 100),
        new JdeField("OQFSTR2", "OQFSTR2", JdeDataType.String, 100),
        new JdeField("OQFSTR3", "OQFSTR3", JdeDataType.String, 100),
        new JdeField("OQFUDT10", "OQFUDT10", JdeDataType.Numeric),
        new JdeField("OQFUDT14", "OQFUDT14", JdeDataType.Numeric),
        new JdeField("OQFUDT24", "OQFUDT24", JdeDataType.Numeric),
        new JdeField("OQURCD", "OQURCD", JdeDataType.String, 4),
        new JdeField("OQURDT", "OQURDT", JdeDataType.Numeric),
        new JdeField("OQURAT", "OQURAT", JdeDataType.Numeric),
        new JdeField("OQURAB", "OQURAB", JdeDataType.Numeric),
        new JdeField("OQURRF", "OQURRF", JdeDataType.String, 30),
        new JdeField("OQUSER", "OQUSER", JdeDataType.String, 20),
        new JdeField("OQPID", "OQPID", JdeDataType.String, 20),
        new JdeField("OQJOBN", "OQJOBN", JdeDataType.String, 20),
        new JdeField("OQUPMJ", "OQUPMJ", JdeDataType.Numeric),
        new JdeField("OQTDAY", "OQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I07_0", "Primary Key on OQDMCT, OQDMCS, OQSEQ, OQCNUKID", new[] { "OQDMCT", "OQDMCS", "OQSEQ", "OQCNUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
