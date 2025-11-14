using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I011 - .
/// </summary>
public class F42I011 : JdeTable
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
        /// OQSEQ.
        /// </summary>
        public const string OQSEQ = "OQSEQ";

        /// <summary>
        /// OQAN8.
        /// </summary>
        public const string OQAN8 = "OQAN8";

        /// <summary>
        /// OQSHAN.
        /// </summary>
        public const string OQSHAN = "OQSHAN";

        /// <summary>
        /// OQCMAN.
        /// </summary>
        public const string OQCMAN = "OQCMAN";

        /// <summary>
        /// OQTOAN8.
        /// </summary>
        public const string OQTOAN8 = "OQTOAN8";

        /// <summary>
        /// OQMCU.
        /// </summary>
        public const string OQMCU = "OQMCU";

        /// <summary>
        /// OQITM.
        /// </summary>
        public const string OQITM = "OQITM";

        /// <summary>
        /// OQLITM.
        /// </summary>
        public const string OQLITM = "OQLITM";

        /// <summary>
        /// OQLOCN.
        /// </summary>
        public const string OQLOCN = "OQLOCN";

        /// <summary>
        /// OQOIPR.
        /// </summary>
        public const string OQOIPR = "OQOIPR";

        /// <summary>
        /// OQMINQC.
        /// </summary>
        public const string OQMINQC = "OQMINQC";

        /// <summary>
        /// OQMAXQC.
        /// </summary>
        public const string OQMAXQC = "OQMAXQC";

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
        /// OQTIQTY.
        /// </summary>
        public const string OQTIQTY = "OQTIQTY";

        /// <summary>
        /// OQUOM.
        /// </summary>
        public const string OQUOM = "OQUOM";

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
        /// OQCUSTFN.
        /// </summary>
        public const string OQCUSTFN = "OQCUSTFN";

        /// <summary>
        /// OQPRCOVRD.
        /// </summary>
        public const string OQPRCOVRD = "OQPRCOVRD";

        /// <summary>
        /// OQTOLPRICE.
        /// </summary>
        public const string OQTOLPRICE = "OQTOLPRICE";

        /// <summary>
        /// OQRQTYOVRD.
        /// </summary>
        public const string OQRQTYOVRD = "OQRQTYOVRD";

        /// <summary>
        /// OQTOLRQTY.
        /// </summary>
        public const string OQTOLRQTY = "OQTOLRQTY";

        /// <summary>
        /// OQKITS.
        /// </summary>
        public const string OQKITS = "OQKITS";

        /// <summary>
        /// OQRLIT.
        /// </summary>
        public const string OQRLIT = "OQRLIT";

        /// <summary>
        /// OQKITID.
        /// </summary>
        public const string OQKITID = "OQKITID";

        /// <summary>
        /// OQCPNT.
        /// </summary>
        public const string OQCPNT = "OQCPNT";

        /// <summary>
        /// OQRKIT.
        /// </summary>
        public const string OQRKIT = "OQRKIT";

        /// <summary>
        /// OQKTP.
        /// </summary>
        public const string OQKTP = "OQKTP";

        /// <summary>
        /// OQKITDIRTY.
        /// </summary>
        public const string OQKITDIRTY = "OQKITDIRTY";

        /// <summary>
        /// OQMFLT.
        /// </summary>
        public const string OQMFLT = "OQMFLT";

        /// <summary>
        /// OQTMLT.
        /// </summary>
        public const string OQTMLT = "OQTMLT";

        /// <summary>
        /// OQLRED.
        /// </summary>
        public const string OQLRED = "OQLRED";

        /// <summary>
        /// OQPRSEQ.
        /// </summary>
        public const string OQPRSEQ = "OQPRSEQ";

        /// <summary>
        /// OQMUP.
        /// </summary>
        public const string OQMUP = "OQMUP";

        /// <summary>
        /// OQOIMFJBNM.
        /// </summary>
        public const string OQOIMFJBNM = "OQOIMFJBNM";

        /// <summary>
        /// OQFRSTDT.
        /// </summary>
        public const string OQFRSTDT = "OQFRSTDT";

        /// <summary>
        /// OQFREDDT.
        /// </summary>
        public const string OQFREDDT = "OQFREDDT";

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
        /// OQFUDT4.
        /// </summary>
        public const string OQFUDT4 = "OQFUDT4";

        /// <summary>
        /// OQFUDT17.
        /// </summary>
        public const string OQFUDT17 = "OQFUDT17";

        /// <summary>
        /// OQFUDT27.
        /// </summary>
        public const string OQFUDT27 = "OQFUDT27";

        /// <summary>
        /// OQURAT.
        /// </summary>
        public const string OQURAT = "OQURAT";

        /// <summary>
        /// OQURCD.
        /// </summary>
        public const string OQURCD = "OQURCD";

        /// <summary>
        /// OQURDT.
        /// </summary>
        public const string OQURDT = "OQURDT";

        /// <summary>
        /// OQURAB.
        /// </summary>
        public const string OQURAB = "OQURAB";

        /// <summary>
        /// OQURRF.
        /// </summary>
        public const string OQURRF = "OQURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OQDMCT", "OQDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OQDMCS", "OQDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OQSEQ", "OQSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OQAN8", "OQAN8", JdeDataType.Numeric),
        new JdeField("OQSHAN", "OQSHAN", JdeDataType.Numeric),
        new JdeField("OQCMAN", "OQCMAN", JdeDataType.Numeric),
        new JdeField("OQTOAN8", "OQTOAN8", JdeDataType.Numeric),
        new JdeField("OQMCU", "OQMCU", JdeDataType.String, 24),
        new JdeField("OQITM", "OQITM", JdeDataType.Numeric),
        new JdeField("OQLITM", "OQLITM", JdeDataType.String, 50),
        new JdeField("OQLOCN", "OQLOCN", JdeDataType.String, 40),
        new JdeField("OQOIPR", "OQOIPR", JdeDataType.String, 16),
        new JdeField("OQMINQC", "OQMINQC", JdeDataType.Numeric),
        new JdeField("OQMAXQC", "OQMAXQC", JdeDataType.Numeric),
        new JdeField("OQORSH", "OQORSH", JdeDataType.String, 2),
        new JdeField("OQRTMD", "OQRTMD", JdeDataType.String, 2),
        new JdeField("OQRPFQ", "OQRPFQ", JdeDataType.String, 2),
        new JdeField("OQADFY", "OQADFY", JdeDataType.String, 2),
        new JdeField("OQTIQTY", "OQTIQTY", JdeDataType.Numeric),
        new JdeField("OQUOM", "OQUOM", JdeDataType.String, 4),
        new JdeField("OQROPI", "OQROPI", JdeDataType.Numeric),
        new JdeField("OQRUOM", "OQRUOM", JdeDataType.String, 4),
        new JdeField("OQCYDT", "OQCYDT", JdeDataType.Numeric),
        new JdeField("OQ42IRC", "OQ42IRC", JdeDataType.String, 6),
        new JdeField("OQCUSTFN", "OQCUSTFN", JdeDataType.String, 64),
        new JdeField("OQPRCOVRD", "OQPRCOVRD", JdeDataType.String, 2),
        new JdeField("OQTOLPRICE", "OQTOLPRICE", JdeDataType.Numeric),
        new JdeField("OQRQTYOVRD", "OQRQTYOVRD", JdeDataType.String, 2),
        new JdeField("OQTOLRQTY", "OQTOLRQTY", JdeDataType.Numeric),
        new JdeField("OQKITS", "OQKITS", JdeDataType.String, 2),
        new JdeField("OQRLIT", "OQRLIT", JdeDataType.String, 16),
        new JdeField("OQKITID", "OQKITID", JdeDataType.Numeric),
        new JdeField("OQCPNT", "OQCPNT", JdeDataType.Numeric),
        new JdeField("OQRKIT", "OQRKIT", JdeDataType.Numeric),
        new JdeField("OQKTP", "OQKTP", JdeDataType.Numeric),
        new JdeField("OQKITDIRTY", "OQKITDIRTY", JdeDataType.String, 2),
        new JdeField("OQMFLT", "OQMFLT", JdeDataType.Numeric),
        new JdeField("OQTMLT", "OQTMLT", JdeDataType.Numeric),
        new JdeField("OQLRED", "OQLRED", JdeDataType.Numeric),
        new JdeField("OQPRSEQ", "OQPRSEQ", JdeDataType.Numeric),
        new JdeField("OQMUP", "OQMUP", JdeDataType.Numeric),
        new JdeField("OQOIMFJBNM", "OQOIMFJBNM", JdeDataType.String, 60),
        new JdeField("OQFRSTDT", "OQFRSTDT", JdeDataType.Numeric),
        new JdeField("OQFREDDT", "OQFREDDT", JdeDataType.Numeric),
        new JdeField("OQUSER", "OQUSER", JdeDataType.String, 20),
        new JdeField("OQPID", "OQPID", JdeDataType.String, 20),
        new JdeField("OQJOBN", "OQJOBN", JdeDataType.String, 20),
        new JdeField("OQUPMJ", "OQUPMJ", JdeDataType.Numeric),
        new JdeField("OQTDAY", "OQTDAY", JdeDataType.Numeric),
        new JdeField("OQFUCHAR3", "OQFUCHAR3", JdeDataType.String, 2),
        new JdeField("OQFUCHAR4", "OQFUCHAR4", JdeDataType.String, 2),
        new JdeField("OQFUCHAR5", "OQFUCHAR5", JdeDataType.String, 2),
        new JdeField("OQFUTNUM1", "OQFUTNUM1", JdeDataType.Numeric),
        new JdeField("OQFUTNUM2", "OQFUTNUM2", JdeDataType.Numeric),
        new JdeField("OQFUTNUM3", "OQFUTNUM3", JdeDataType.Numeric),
        new JdeField("OQFSTR1", "OQFSTR1", JdeDataType.String, 100),
        new JdeField("OQFSTR2", "OQFSTR2", JdeDataType.String, 100),
        new JdeField("OQFSTR3", "OQFSTR3", JdeDataType.String, 100),
        new JdeField("OQFUDT4", "OQFUDT4", JdeDataType.Numeric),
        new JdeField("OQFUDT17", "OQFUDT17", JdeDataType.Numeric),
        new JdeField("OQFUDT27", "OQFUDT27", JdeDataType.Numeric),
        new JdeField("OQURAT", "OQURAT", JdeDataType.Numeric),
        new JdeField("OQURCD", "OQURCD", JdeDataType.String, 4),
        new JdeField("OQURDT", "OQURDT", JdeDataType.Numeric),
        new JdeField("OQURAB", "OQURAB", JdeDataType.Numeric),
        new JdeField("OQURRF", "OQURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I011_0", "Primary Key on OQDMCT, OQDMCS, OQSEQ", new[] { "OQDMCT", "OQDMCS", "OQSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I011_2", "Index on OQDMCT, OQDMCS, SYS_NC00067$", new[] { "OQDMCT", "OQDMCS", "SYS_NC00067$" }),
        new JdeIndex("F42I011_3", "Index on OQDMCT, OQDMCS, OQSEQ, OQOIMFJBNM", new[] { "OQDMCT", "OQDMCS", "OQSEQ", "OQOIMFJBNM" })
    };
}
