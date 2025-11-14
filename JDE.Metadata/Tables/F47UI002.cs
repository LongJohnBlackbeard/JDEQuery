using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47UI002 - .
/// </summary>
public class F47UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPCTID.
        /// </summary>
        public const string SPCTID = "SPCTID";

        /// <summary>
        /// SPJOBS.
        /// </summary>
        public const string SPJOBS = "SPJOBS";

        /// <summary>
        /// SPHLCF.
        /// </summary>
        public const string SPHLCF = "SPHLCF";

        /// <summary>
        /// SPHLSC.
        /// </summary>
        public const string SPHLSC = "SPHLSC";

        /// <summary>
        /// SPITM.
        /// </summary>
        public const string SPITM = "SPITM";

        /// <summary>
        /// SPSHPN.
        /// </summary>
        public const string SPSHPN = "SPSHPN";

        /// <summary>
        /// SPVC30A.
        /// </summary>
        public const string SPVC30A = "SPVC30A";

        /// <summary>
        /// SPVC30A1.
        /// </summary>
        public const string SPVC30A1 = "SPVC30A1";

        /// <summary>
        /// SPVC30A2.
        /// </summary>
        public const string SPVC30A2 = "SPVC30A2";

        /// <summary>
        /// SPVC30A3.
        /// </summary>
        public const string SPVC30A3 = "SPVC30A3";

        /// <summary>
        /// SPVC30A4.
        /// </summary>
        public const string SPVC30A4 = "SPVC30A4";

        /// <summary>
        /// SPVC30A5.
        /// </summary>
        public const string SPVC30A5 = "SPVC30A5";

        /// <summary>
        /// SPVC30A6.
        /// </summary>
        public const string SPVC30A6 = "SPVC30A6";

        /// <summary>
        /// SPVC30A7.
        /// </summary>
        public const string SPVC30A7 = "SPVC30A7";

        /// <summary>
        /// SPVC30A8.
        /// </summary>
        public const string SPVC30A8 = "SPVC30A8";

        /// <summary>
        /// SPSAD.
        /// </summary>
        public const string SPSAD = "SPSAD";

        /// <summary>
        /// SPSAD1.
        /// </summary>
        public const string SPSAD1 = "SPSAD1";

        /// <summary>
        /// SPSAD2.
        /// </summary>
        public const string SPSAD2 = "SPSAD2";

        /// <summary>
        /// SPSAD3.
        /// </summary>
        public const string SPSAD3 = "SPSAD3";

        /// <summary>
        /// SPSAD4.
        /// </summary>
        public const string SPSAD4 = "SPSAD4";

        /// <summary>
        /// SPSAD5.
        /// </summary>
        public const string SPSAD5 = "SPSAD5";

        /// <summary>
        /// SPSAD6.
        /// </summary>
        public const string SPSAD6 = "SPSAD6";

        /// <summary>
        /// SPSAD7.
        /// </summary>
        public const string SPSAD7 = "SPSAD7";

        /// <summary>
        /// SPSAD8.
        /// </summary>
        public const string SPSAD8 = "SPSAD8";

        /// <summary>
        /// SPDOCO.
        /// </summary>
        public const string SPDOCO = "SPDOCO";

        /// <summary>
        /// SPDCTO.
        /// </summary>
        public const string SPDCTO = "SPDCTO";

        /// <summary>
        /// SPKCOO.
        /// </summary>
        public const string SPKCOO = "SPKCOO";

        /// <summary>
        /// SPLNID.
        /// </summary>
        public const string SPLNID = "SPLNID";

        /// <summary>
        /// SPSEQN.
        /// </summary>
        public const string SPSEQN = "SPSEQN";

        /// <summary>
        /// SPMCU.
        /// </summary>
        public const string SPMCU = "SPMCU";

        /// <summary>
        /// SPAN8.
        /// </summary>
        public const string SPAN8 = "SPAN8";

        /// <summary>
        /// SPSHAN.
        /// </summary>
        public const string SPSHAN = "SPSHAN";

        /// <summary>
        /// SPPLT.
        /// </summary>
        public const string SPPLT = "SPPLT";

        /// <summary>
        /// SPPAK.
        /// </summary>
        public const string SPPAK = "SPPAK";

        /// <summary>
        /// SPSCCN.
        /// </summary>
        public const string SPSCCN = "SPSCCN";

        /// <summary>
        /// SPSOQS.
        /// </summary>
        public const string SPSOQS = "SPSOQS";

        /// <summary>
        /// SPUOM.
        /// </summary>
        public const string SPUOM = "SPUOM";

        /// <summary>
        /// SPSCCQ.
        /// </summary>
        public const string SPSCCQ = "SPSCCQ";

        /// <summary>
        /// SPSCUM.
        /// </summary>
        public const string SPSCUM = "SPSCUM";

        /// <summary>
        /// SPTQTY.
        /// </summary>
        public const string SPTQTY = "SPTQTY";

        /// <summary>
        /// SPCROS.
        /// </summary>
        public const string SPCROS = "SPCROS";

        /// <summary>
        /// SPCRID.
        /// </summary>
        public const string SPCRID = "SPCRID";

        /// <summary>
        /// SPEQTY.
        /// </summary>
        public const string SPEQTY = "SPEQTY";

        /// <summary>
        /// SPCEQT.
        /// </summary>
        public const string SPCEQT = "SPCEQT";

        /// <summary>
        /// SPCTNI.
        /// </summary>
        public const string SPCTNI = "SPCTNI";

        /// <summary>
        /// SPASID.
        /// </summary>
        public const string SPASID = "SPASID";

        /// <summary>
        /// SPLDTAI.
        /// </summary>
        public const string SPLDTAI = "SPLDTAI";

        /// <summary>
        /// SPPKCD.
        /// </summary>
        public const string SPPKCD = "SPPKCD";

        /// <summary>
        /// SPPKLVL.
        /// </summary>
        public const string SPPKLVL = "SPPKLVL";

        /// <summary>
        /// SPCRSS.
        /// </summary>
        public const string SPCRSS = "SPCRSS";

        /// <summary>
        /// SPWEIT.
        /// </summary>
        public const string SPWEIT = "SPWEIT";

        /// <summary>
        /// SPGWEI.
        /// </summary>
        public const string SPGWEI = "SPGWEI";

        /// <summary>
        /// SPGRWT.
        /// </summary>
        public const string SPGRWT = "SPGRWT";

        /// <summary>
        /// SPUWUM.
        /// </summary>
        public const string SPUWUM = "SPUWUM";

        /// <summary>
        /// SPCHGREF.
        /// </summary>
        public const string SPCHGREF = "SPCHGREF";

        /// <summary>
        /// SPCHGAMT.
        /// </summary>
        public const string SPCHGAMT = "SPCHGAMT";

        /// <summary>
        /// SPEXCN.
        /// </summary>
        public const string SPEXCN = "SPEXCN";

        /// <summary>
        /// SPCTSN.
        /// </summary>
        public const string SPCTSN = "SPCTSN";

        /// <summary>
        /// SPGAN8.
        /// </summary>
        public const string SPGAN8 = "SPGAN8";

        /// <summary>
        /// SPGSHAN.
        /// </summary>
        public const string SPGSHAN = "SPGSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F47UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPCTID", "SPCTID", JdeDataType.String, 30, true, true),
        new JdeField("SPJOBS", "SPJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SPHLCF", "SPHLCF", JdeDataType.String, 36, true, true),
        new JdeField("SPHLSC", "SPHLSC", JdeDataType.String, 8),
        new JdeField("SPITM", "SPITM", JdeDataType.Numeric),
        new JdeField("SPSHPN", "SPSHPN", JdeDataType.Numeric),
        new JdeField("SPVC30A", "SPVC30A", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A1", "SPVC30A1", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A2", "SPVC30A2", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A3", "SPVC30A3", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A4", "SPVC30A4", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A5", "SPVC30A5", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A6", "SPVC30A6", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A7", "SPVC30A7", JdeDataType.String, 60, true, true),
        new JdeField("SPVC30A8", "SPVC30A8", JdeDataType.String, 60, true, true),
        new JdeField("SPSAD", "SPSAD", JdeDataType.String, 2),
        new JdeField("SPSAD1", "SPSAD1", JdeDataType.String, 2),
        new JdeField("SPSAD2", "SPSAD2", JdeDataType.String, 2),
        new JdeField("SPSAD3", "SPSAD3", JdeDataType.String, 2),
        new JdeField("SPSAD4", "SPSAD4", JdeDataType.String, 2),
        new JdeField("SPSAD5", "SPSAD5", JdeDataType.String, 2),
        new JdeField("SPSAD6", "SPSAD6", JdeDataType.String, 2),
        new JdeField("SPSAD7", "SPSAD7", JdeDataType.String, 2),
        new JdeField("SPSAD8", "SPSAD8", JdeDataType.String, 2),
        new JdeField("SPDOCO", "SPDOCO", JdeDataType.Numeric),
        new JdeField("SPDCTO", "SPDCTO", JdeDataType.String, 4),
        new JdeField("SPKCOO", "SPKCOO", JdeDataType.String, 10),
        new JdeField("SPLNID", "SPLNID", JdeDataType.Numeric),
        new JdeField("SPSEQN", "SPSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("SPMCU", "SPMCU", JdeDataType.String, 24),
        new JdeField("SPAN8", "SPAN8", JdeDataType.Numeric),
        new JdeField("SPSHAN", "SPSHAN", JdeDataType.Numeric),
        new JdeField("SPPLT", "SPPLT", JdeDataType.String, 36),
        new JdeField("SPPAK", "SPPAK", JdeDataType.String, 36),
        new JdeField("SPSCCN", "SPSCCN", JdeDataType.String, 28),
        new JdeField("SPSOQS", "SPSOQS", JdeDataType.Numeric),
        new JdeField("SPUOM", "SPUOM", JdeDataType.String, 4),
        new JdeField("SPSCCQ", "SPSCCQ", JdeDataType.Numeric),
        new JdeField("SPSCUM", "SPSCUM", JdeDataType.String, 4),
        new JdeField("SPTQTY", "SPTQTY", JdeDataType.Numeric),
        new JdeField("SPCROS", "SPCROS", JdeDataType.Numeric),
        new JdeField("SPCRID", "SPCRID", JdeDataType.Numeric),
        new JdeField("SPEQTY", "SPEQTY", JdeDataType.String, 10),
        new JdeField("SPCEQT", "SPCEQT", JdeDataType.String, 50),
        new JdeField("SPCTNI", "SPCTNI", JdeDataType.Numeric),
        new JdeField("SPASID", "SPASID", JdeDataType.String, 50),
        new JdeField("SPLDTAI", "SPLDTAI", JdeDataType.String, 6),
        new JdeField("SPPKCD", "SPPKCD", JdeDataType.String, 10),
        new JdeField("SPPKLVL", "SPPKLVL", JdeDataType.String, 6),
        new JdeField("SPCRSS", "SPCRSS", JdeDataType.String, 4),
        new JdeField("SPWEIT", "SPWEIT", JdeDataType.Numeric),
        new JdeField("SPGWEI", "SPGWEI", JdeDataType.Numeric),
        new JdeField("SPGRWT", "SPGRWT", JdeDataType.Numeric),
        new JdeField("SPUWUM", "SPUWUM", JdeDataType.String, 4),
        new JdeField("SPCHGREF", "SPCHGREF", JdeDataType.String, 40),
        new JdeField("SPCHGAMT", "SPCHGAMT", JdeDataType.Numeric),
        new JdeField("SPEXCN", "SPEXCN", JdeDataType.String, 2),
        new JdeField("SPCTSN", "SPCTSN", JdeDataType.String, 80),
        new JdeField("SPGAN8", "SPGAN8", JdeDataType.Numeric),
        new JdeField("SPGSHAN", "SPGSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47UI002_0", "Primary Key on SPCTID, SPJOBS, SPHLCF, SPVC30A, SPVC30A1, SPVC30A2, SPVC30A3, SPVC30A4, SPVC30A5, SPVC30A6, SPVC30A7, SPVC30A8, SPSEQN", new[] { "SPCTID", "SPJOBS", "SPHLCF", "SPVC30A", "SPVC30A1", "SPVC30A2", "SPVC30A3", "SPVC30A4", "SPVC30A5", "SPVC30A6", "SPVC30A7", "SPVC30A8", "SPSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F47UI002_2", "Index on SPCHGREF, SPEQTY, SPCRID", new[] { "SPCHGREF", "SPEQTY", "SPCRID" })
    };
}
