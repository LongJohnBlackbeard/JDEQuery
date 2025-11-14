using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4620 - .
/// </summary>
public class F4620 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDUKID.
        /// </summary>
        public const string CDUKID = "CDUKID";

        /// <summary>
        /// CDCROS.
        /// </summary>
        public const string CDCROS = "CDCROS";

        /// <summary>
        /// CDCRID.
        /// </summary>
        public const string CDCRID = "CDCRID";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDLOT.
        /// </summary>
        public const string CDLOT = "CDLOT";

        /// <summary>
        /// CDUOM.
        /// </summary>
        public const string CDUOM = "CDUOM";

        /// <summary>
        /// CDDOCO.
        /// </summary>
        public const string CDDOCO = "CDDOCO";

        /// <summary>
        /// CDDCTO.
        /// </summary>
        public const string CDDCTO = "CDDCTO";

        /// <summary>
        /// CDKCOO.
        /// </summary>
        public const string CDKCOO = "CDKCOO";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDSFXO.
        /// </summary>
        public const string CDSFXO = "CDSFXO";

        /// <summary>
        /// CDCRSS.
        /// </summary>
        public const string CDCRSS = "CDCRSS";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDTQTY.
        /// </summary>
        public const string CDTQTY = "CDTQTY";

        /// <summary>
        /// CDWEIT.
        /// </summary>
        public const string CDWEIT = "CDWEIT";

        /// <summary>
        /// CDSHPN.
        /// </summary>
        public const string CDSHPN = "CDSHPN";

        /// <summary>
        /// CDRSSN.
        /// </summary>
        public const string CDRSSN = "CDRSSN";

        /// <summary>
        /// CDCTSN.
        /// </summary>
        public const string CDCTSN = "CDCTSN";

        /// <summary>
        /// CDSNTY.
        /// </summary>
        public const string CDSNTY = "CDSNTY";

        /// <summary>
        /// CDRFIDF.
        /// </summary>
        public const string CDRFIDF = "CDRFIDF";

        /// <summary>
        /// CDOSEQ.
        /// </summary>
        public const string CDOSEQ = "CDOSEQ";

        /// <summary>
        /// CDPLT.
        /// </summary>
        public const string CDPLT = "CDPLT";

        /// <summary>
        /// CDPAK.
        /// </summary>
        public const string CDPAK = "CDPAK";

        /// <summary>
        /// CDSCCN.
        /// </summary>
        public const string CDSCCN = "CDSCCN";

        /// <summary>
        /// CDSCUM.
        /// </summary>
        public const string CDSCUM = "CDSCUM";

        /// <summary>
        /// CDSCCQ.
        /// </summary>
        public const string CDSCCQ = "CDSCCQ";

        /// <summary>
        /// CDITWT.
        /// </summary>
        public const string CDITWT = "CDITWT";

        /// <summary>
        /// CDUPCN.
        /// </summary>
        public const string CDUPCN = "CDUPCN";

        /// <summary>
        /// CDUPUM.
        /// </summary>
        public const string CDUPUM = "CDUPUM";

        /// <summary>
        /// CDUPQT.
        /// </summary>
        public const string CDUPQT = "CDUPQT";

        /// <summary>
        /// CDCNV5.
        /// </summary>
        public const string CDCNV5 = "CDCNV5";

        /// <summary>
        /// CDPTSK.
        /// </summary>
        public const string CDPTSK = "CDPTSK";

        /// <summary>
        /// CDEQTY.
        /// </summary>
        public const string CDEQTY = "CDEQTY";

        /// <summary>
        /// CDMAXW.
        /// </summary>
        public const string CDMAXW = "CDMAXW";

        /// <summary>
        /// CDGWEI.
        /// </summary>
        public const string CDGWEI = "CDGWEI";

        /// <summary>
        /// CDGRWT.
        /// </summary>
        public const string CDGRWT = "CDGRWT";

        /// <summary>
        /// CDAWGT.
        /// </summary>
        public const string CDAWGT = "CDAWGT";

        /// <summary>
        /// CDUWUM.
        /// </summary>
        public const string CDUWUM = "CDUWUM";

        /// <summary>
        /// CDLGTS.
        /// </summary>
        public const string CDLGTS = "CDLGTS";

        /// <summary>
        /// CDWTHS.
        /// </summary>
        public const string CDWTHS = "CDWTHS";

        /// <summary>
        /// CDHGTS.
        /// </summary>
        public const string CDHGTS = "CDHGTS";

        /// <summary>
        /// CDLUOM.
        /// </summary>
        public const string CDLUOM = "CDLUOM";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

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
        /// CDTDAY.
        /// </summary>
        public const string CDTDAY = "CDTDAY";

        /// <summary>
        /// CDCEQT.
        /// </summary>
        public const string CDCEQT = "CDCEQT";

        /// <summary>
        /// CDCTNI.
        /// </summary>
        public const string CDCTNI = "CDCTNI";

        /// <summary>
        /// CDASID.
        /// </summary>
        public const string CDASID = "CDASID";

        /// <summary>
        /// CDLDTAI.
        /// </summary>
        public const string CDLDTAI = "CDLDTAI";

        /// <summary>
        /// CDCSOC.
        /// </summary>
        public const string CDCSOC = "CDCSOC";

        /// <summary>
        /// CDEXCN.
        /// </summary>
        public const string CDEXCN = "CDEXCN";

        /// <summary>
        /// CDPKCD.
        /// </summary>
        public const string CDPKCD = "CDPKCD";

        /// <summary>
        /// CDPSJOBNO.
        /// </summary>
        public const string CDPSJOBNO = "CDPSJOBNO";

        /// <summary>
        /// CDJOBSQ.
        /// </summary>
        public const string CDJOBSQ = "CDJOBSQ";

        /// <summary>
        /// CDDELBATCH.
        /// </summary>
        public const string CDDELBATCH = "CDDELBATCH";

        /// <summary>
        /// CDPRFCTN.
        /// </summary>
        public const string CDPRFCTN = "CDPRFCTN";

        /// <summary>
        /// CDCTNNUM.
        /// </summary>
        public const string CDCTNNUM = "CDCTNNUM";

        /// <summary>
        /// CDCTNLT.
        /// </summary>
        public const string CDCTNLT = "CDCTNLT";
    }

    /// <inheritdoc />
    public override string TableName => "F4620";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDUKID", "CDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCROS", "CDCROS", JdeDataType.Numeric),
        new JdeField("CDCRID", "CDCRID", JdeDataType.Numeric),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDLOT", "CDLOT", JdeDataType.String, 60),
        new JdeField("CDUOM", "CDUOM", JdeDataType.String, 4),
        new JdeField("CDDOCO", "CDDOCO", JdeDataType.Numeric),
        new JdeField("CDDCTO", "CDDCTO", JdeDataType.String, 4),
        new JdeField("CDKCOO", "CDKCOO", JdeDataType.String, 10),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric),
        new JdeField("CDSFXO", "CDSFXO", JdeDataType.String, 6),
        new JdeField("CDCRSS", "CDCRSS", JdeDataType.String, 4),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDTQTY", "CDTQTY", JdeDataType.Numeric),
        new JdeField("CDWEIT", "CDWEIT", JdeDataType.Numeric),
        new JdeField("CDSHPN", "CDSHPN", JdeDataType.Numeric),
        new JdeField("CDRSSN", "CDRSSN", JdeDataType.Numeric),
        new JdeField("CDCTSN", "CDCTSN", JdeDataType.String, 80),
        new JdeField("CDSNTY", "CDSNTY", JdeDataType.String, 10),
        new JdeField("CDRFIDF", "CDRFIDF", JdeDataType.String, 2),
        new JdeField("CDOSEQ", "CDOSEQ", JdeDataType.Numeric),
        new JdeField("CDPLT", "CDPLT", JdeDataType.String, 36),
        new JdeField("CDPAK", "CDPAK", JdeDataType.String, 36),
        new JdeField("CDSCCN", "CDSCCN", JdeDataType.String, 28),
        new JdeField("CDSCUM", "CDSCUM", JdeDataType.String, 4),
        new JdeField("CDSCCQ", "CDSCCQ", JdeDataType.Numeric),
        new JdeField("CDITWT", "CDITWT", JdeDataType.Numeric),
        new JdeField("CDUPCN", "CDUPCN", JdeDataType.String, 26),
        new JdeField("CDUPUM", "CDUPUM", JdeDataType.String, 4),
        new JdeField("CDUPQT", "CDUPQT", JdeDataType.Numeric),
        new JdeField("CDCNV5", "CDCNV5", JdeDataType.Numeric),
        new JdeField("CDPTSK", "CDPTSK", JdeDataType.Numeric),
        new JdeField("CDEQTY", "CDEQTY", JdeDataType.String, 10),
        new JdeField("CDMAXW", "CDMAXW", JdeDataType.Numeric),
        new JdeField("CDGWEI", "CDGWEI", JdeDataType.Numeric),
        new JdeField("CDGRWT", "CDGRWT", JdeDataType.Numeric),
        new JdeField("CDAWGT", "CDAWGT", JdeDataType.Numeric),
        new JdeField("CDUWUM", "CDUWUM", JdeDataType.String, 4),
        new JdeField("CDLGTS", "CDLGTS", JdeDataType.Numeric),
        new JdeField("CDWTHS", "CDWTHS", JdeDataType.Numeric),
        new JdeField("CDHGTS", "CDHGTS", JdeDataType.Numeric),
        new JdeField("CDLUOM", "CDLUOM", JdeDataType.String, 4),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDTDAY", "CDTDAY", JdeDataType.Numeric),
        new JdeField("CDCEQT", "CDCEQT", JdeDataType.String, 50),
        new JdeField("CDCTNI", "CDCTNI", JdeDataType.Numeric),
        new JdeField("CDASID", "CDASID", JdeDataType.String, 50),
        new JdeField("CDLDTAI", "CDLDTAI", JdeDataType.String, 6),
        new JdeField("CDCSOC", "CDCSOC", JdeDataType.String, 2),
        new JdeField("CDEXCN", "CDEXCN", JdeDataType.String, 2),
        new JdeField("CDPKCD", "CDPKCD", JdeDataType.String, 10),
        new JdeField("CDPSJOBNO", "CDPSJOBNO", JdeDataType.String, 30),
        new JdeField("CDJOBSQ", "CDJOBSQ", JdeDataType.String, 30),
        new JdeField("CDDELBATCH", "CDDELBATCH", JdeDataType.String, 12),
        new JdeField("CDPRFCTN", "CDPRFCTN", JdeDataType.String, 2),
        new JdeField("CDCTNNUM", "CDCTNNUM", JdeDataType.Numeric),
        new JdeField("CDCTNLT", "CDCTNLT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4620_0", "Primary Key on CDUKID", new[] { "CDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4620_2", "Unique Index on CDCRID, CDITM, CDLOT, CDUOM, CDDOCO, CDDCTO, CDKCOO, CDLNID, CDSFXO", new[] { "CDCRID", "CDITM", "CDLOT", "CDUOM", "CDDOCO", "CDDCTO", "CDKCOO", "CDLNID", "CDSFXO" }, isUnique: true),
        new JdeIndex("F4620_3", "Index on CDSHPN, CDCROS", new[] { "CDSHPN", "CDCROS" }),
        new JdeIndex("F4620_4", "Index on CDPTSK, CDDOCO, CDDCTO, CDKCOO, CDLNID, CDUOM, CDLOT", new[] { "CDPTSK", "CDDOCO", "CDDCTO", "CDKCOO", "CDLNID", "CDUOM", "CDLOT" }),
        new JdeIndex("F4620_5", "Index on CDSHPN, CDCRSS", new[] { "CDSHPN", "CDCRSS" }),
        new JdeIndex("F4620_6", "Index on CDSHPN, CDCRID", new[] { "CDSHPN", "CDCRID" }),
        new JdeIndex("F4620_7", "Index on CDSHPN, CDCROS, CDCRID, CDITM, CDLOT, CDUOM", new[] { "CDSHPN", "CDCROS", "CDCRID", "CDITM", "CDLOT", "CDUOM" }),
        new JdeIndex("F4620_8", "Index on CDDOCO, CDDCTO, CDKCOO, CDLNID, CDSFXO, CDPTSK", new[] { "CDDOCO", "CDDCTO", "CDKCOO", "CDLNID", "CDSFXO", "CDPTSK" })
    };
}
