using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31113S - .
/// </summary>
public class FF31113S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRUKID.
        /// </summary>
        public const string LRUKID = "LRUKID";

        /// <summary>
        /// LRYST.
        /// </summary>
        public const string LRYST = "LRYST";

        /// <summary>
        /// LRPRODF31.
        /// </summary>
        public const string LRPRODF31 = "LRPRODF31";

        /// <summary>
        /// LRTRSID.
        /// </summary>
        public const string LRTRSID = "LRTRSID";

        /// <summary>
        /// LRMTID.
        /// </summary>
        public const string LRMTID = "LRMTID";

        /// <summary>
        /// LRAN8.
        /// </summary>
        public const string LRAN8 = "LRAN8";

        /// <summary>
        /// LRKIT.
        /// </summary>
        public const string LRKIT = "LRKIT";

        /// <summary>
        /// LRITM.
        /// </summary>
        public const string LRITM = "LRITM";

        /// <summary>
        /// LRLITM.
        /// </summary>
        public const string LRLITM = "LRLITM";

        /// <summary>
        /// LRAITM.
        /// </summary>
        public const string LRAITM = "LRAITM";

        /// <summary>
        /// LRMMCU.
        /// </summary>
        public const string LRMMCU = "LRMMCU";

        /// <summary>
        /// LRMCU.
        /// </summary>
        public const string LRMCU = "LRMCU";

        /// <summary>
        /// LRDFMLINE.
        /// </summary>
        public const string LRDFMLINE = "LRDFMLINE";

        /// <summary>
        /// LROPSQ.
        /// </summary>
        public const string LROPSQ = "LROPSQ";

        /// <summary>
        /// LROPSC.
        /// </summary>
        public const string LROPSC = "LROPSC";

        /// <summary>
        /// LRTYR.
        /// </summary>
        public const string LRTYR = "LRTYR";

        /// <summary>
        /// LRDCT.
        /// </summary>
        public const string LRDCT = "LRDCT";

        /// <summary>
        /// LRLTDATE.
        /// </summary>
        public const string LRLTDATE = "LRLTDATE";

        /// <summary>
        /// LRUCNDJ.
        /// </summary>
        public const string LRUCNDJ = "LRUCNDJ";

        /// <summary>
        /// LRLTSTTIME.
        /// </summary>
        public const string LRLTSTTIME = "LRLTSTTIME";

        /// <summary>
        /// LRLTENTIME.
        /// </summary>
        public const string LRLTENTIME = "LRLTENTIME";

        /// <summary>
        /// LRSHFT.
        /// </summary>
        public const string LRSHFT = "LRSHFT";

        /// <summary>
        /// LRHRT.
        /// </summary>
        public const string LRHRT = "LRHRT";

        /// <summary>
        /// LRHRW.
        /// </summary>
        public const string LRHRW = "LRHRW";

        /// <summary>
        /// LRGPAY.
        /// </summary>
        public const string LRGPAY = "LRGPAY";

        /// <summary>
        /// LRSOQS.
        /// </summary>
        public const string LRSOQS = "LRSOQS";

        /// <summary>
        /// LRSOCN.
        /// </summary>
        public const string LRSOCN = "LRSOCN";

        /// <summary>
        /// LRUOM.
        /// </summary>
        public const string LRUOM = "LRUOM";

        /// <summary>
        /// LRSUMR.
        /// </summary>
        public const string LRSUMR = "LRSUMR";

        /// <summary>
        /// LRSTH.
        /// </summary>
        public const string LRSTH = "LRSTH";

        /// <summary>
        /// LRRCD.
        /// </summary>
        public const string LRRCD = "LRRCD";

        /// <summary>
        /// LRLINE.
        /// </summary>
        public const string LRLINE = "LRLINE";

        /// <summary>
        /// LRVEND.
        /// </summary>
        public const string LRVEND = "LRVEND";

        /// <summary>
        /// LRRKCO.
        /// </summary>
        public const string LRRKCO = "LRRKCO";

        /// <summary>
        /// LRRORN.
        /// </summary>
        public const string LRRORN = "LRRORN";

        /// <summary>
        /// LRRCTO.
        /// </summary>
        public const string LRRCTO = "LRRCTO";

        /// <summary>
        /// LRWMCU.
        /// </summary>
        public const string LRWMCU = "LRWMCU";

        /// <summary>
        /// LRCOST.
        /// </summary>
        public const string LRCOST = "LRCOST";

        /// <summary>
        /// LRNUMB.
        /// </summary>
        public const string LRNUMB = "LRNUMB";

        /// <summary>
        /// LRTUSER.
        /// </summary>
        public const string LRTUSER = "LRTUSER";

        /// <summary>
        /// LRCUSER.
        /// </summary>
        public const string LRCUSER = "LRCUSER";

        /// <summary>
        /// LRURCD.
        /// </summary>
        public const string LRURCD = "LRURCD";

        /// <summary>
        /// LRURDT.
        /// </summary>
        public const string LRURDT = "LRURDT";

        /// <summary>
        /// LRURAT.
        /// </summary>
        public const string LRURAT = "LRURAT";

        /// <summary>
        /// LRURAB.
        /// </summary>
        public const string LRURAB = "LRURAB";

        /// <summary>
        /// LRURRF.
        /// </summary>
        public const string LRURRF = "LRURRF";

        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LRPID.
        /// </summary>
        public const string LRPID = "LRPID";

        /// <summary>
        /// LRMKEY.
        /// </summary>
        public const string LRMKEY = "LRMKEY";

        /// <summary>
        /// LRUUPMJ.
        /// </summary>
        public const string LRUUPMJ = "LRUUPMJ";

        /// <summary>
        /// LRU.
        /// </summary>
        public const string LRU = "LRU";

        /// <summary>
        /// LRAA.
        /// </summary>
        public const string LRAA = "LRAA";

        /// <summary>
        /// LRTRSTS.
        /// </summary>
        public const string LRTRSTS = "LRTRSTS";

        /// <summary>
        /// LRLEANUNIT.
        /// </summary>
        public const string LRLEANUNIT = "LRLEANUNIT";

        /// <summary>
        /// LRLEANAMT.
        /// </summary>
        public const string LRLEANAMT = "LRLEANAMT";

        /// <summary>
        /// LRHRSWRK.
        /// </summary>
        public const string LRHRSWRK = "LRHRSWRK";

        /// <summary>
        /// LRAMTGPAY.
        /// </summary>
        public const string LRAMTGPAY = "LRAMTGPAY";
    }

    /// <inheritdoc />
    public override string TableName => "FF31113S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRUKID", "LRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LRYST", "LRYST", JdeDataType.String, 2),
        new JdeField("LRPRODF31", "LRPRODF31", JdeDataType.Numeric),
        new JdeField("LRTRSID", "LRTRSID", JdeDataType.Numeric),
        new JdeField("LRMTID", "LRMTID", JdeDataType.Numeric),
        new JdeField("LRAN8", "LRAN8", JdeDataType.Numeric),
        new JdeField("LRKIT", "LRKIT", JdeDataType.Numeric),
        new JdeField("LRITM", "LRITM", JdeDataType.Numeric),
        new JdeField("LRLITM", "LRLITM", JdeDataType.String, 50),
        new JdeField("LRAITM", "LRAITM", JdeDataType.String, 50),
        new JdeField("LRMMCU", "LRMMCU", JdeDataType.String, 24),
        new JdeField("LRMCU", "LRMCU", JdeDataType.String, 24),
        new JdeField("LRDFMLINE", "LRDFMLINE", JdeDataType.String, 24),
        new JdeField("LROPSQ", "LROPSQ", JdeDataType.Numeric),
        new JdeField("LROPSC", "LROPSC", JdeDataType.String, 4),
        new JdeField("LRTYR", "LRTYR", JdeDataType.String, 2),
        new JdeField("LRDCT", "LRDCT", JdeDataType.String, 4),
        new JdeField("LRLTDATE", "LRLTDATE", JdeDataType.Date),
        new JdeField("LRUCNDJ", "LRUCNDJ", JdeDataType.Date),
        new JdeField("LRLTSTTIME", "LRLTSTTIME", JdeDataType.Date),
        new JdeField("LRLTENTIME", "LRLTENTIME", JdeDataType.Date),
        new JdeField("LRSHFT", "LRSHFT", JdeDataType.String, 2),
        new JdeField("LRHRT", "LRHRT", JdeDataType.Numeric),
        new JdeField("LRHRW", "LRHRW", JdeDataType.Numeric),
        new JdeField("LRGPAY", "LRGPAY", JdeDataType.Numeric),
        new JdeField("LRSOQS", "LRSOQS", JdeDataType.Numeric),
        new JdeField("LRSOCN", "LRSOCN", JdeDataType.Numeric),
        new JdeField("LRUOM", "LRUOM", JdeDataType.String, 4),
        new JdeField("LRSUMR", "LRSUMR", JdeDataType.String, 2),
        new JdeField("LRSTH", "LRSTH", JdeDataType.Numeric),
        new JdeField("LRRCD", "LRRCD", JdeDataType.String, 6),
        new JdeField("LRLINE", "LRLINE", JdeDataType.String, 24),
        new JdeField("LRVEND", "LRVEND", JdeDataType.Numeric),
        new JdeField("LRRKCO", "LRRKCO", JdeDataType.String, 10),
        new JdeField("LRRORN", "LRRORN", JdeDataType.String, 16),
        new JdeField("LRRCTO", "LRRCTO", JdeDataType.String, 4),
        new JdeField("LRWMCU", "LRWMCU", JdeDataType.String, 24),
        new JdeField("LRCOST", "LRCOST", JdeDataType.String, 6),
        new JdeField("LRNUMB", "LRNUMB", JdeDataType.Numeric),
        new JdeField("LRTUSER", "LRTUSER", JdeDataType.String, 20),
        new JdeField("LRCUSER", "LRCUSER", JdeDataType.String, 20),
        new JdeField("LRURCD", "LRURCD", JdeDataType.String, 4),
        new JdeField("LRURDT", "LRURDT", JdeDataType.Numeric),
        new JdeField("LRURAT", "LRURAT", JdeDataType.Numeric),
        new JdeField("LRURAB", "LRURAB", JdeDataType.Numeric),
        new JdeField("LRURRF", "LRURRF", JdeDataType.String, 30),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRMKEY", "LRMKEY", JdeDataType.String, 30),
        new JdeField("LRUUPMJ", "LRUUPMJ", JdeDataType.Date),
        new JdeField("LRU", "LRU", JdeDataType.Numeric),
        new JdeField("LRAA", "LRAA", JdeDataType.Numeric),
        new JdeField("LRTRSTS", "LRTRSTS", JdeDataType.String, 4),
        new JdeField("LRLEANUNIT", "LRLEANUNIT", JdeDataType.Numeric),
        new JdeField("LRLEANAMT", "LRLEANAMT", JdeDataType.Numeric),
        new JdeField("LRHRSWRK", "LRHRSWRK", JdeDataType.Numeric),
        new JdeField("LRAMTGPAY", "LRAMTGPAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31113S_0", "Primary Key on LRUKID", new[] { "LRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31113S_2", "Index on LRPRODF31, LRTRSID, LROPSQ, LROPSC, LRMCU, LRTYR", new[] { "LRPRODF31", "LRTRSID", "LROPSQ", "LROPSC", "LRMCU", "LRTYR" }),
        new JdeIndex("FF31113S_3", "Index on LRYST, LRPRODF31, LRTRSID, LROPSQ, LROPSC, LRMCU, LRTYR", new[] { "LRYST", "LRPRODF31", "LRTRSID", "LROPSQ", "LROPSC", "LRMCU", "LRTYR" }),
        new JdeIndex("FF31113S_4", "Index on LRPRODF31, LRMTID", new[] { "LRPRODF31", "LRMTID" })
    };
}
