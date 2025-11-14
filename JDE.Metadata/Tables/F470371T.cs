using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470371T - .
/// </summary>
public class F470371T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UZAAID.
        /// </summary>
        public const string UZAAID = "UZAAID";

        /// <summary>
        /// UZACOM.
        /// </summary>
        public const string UZACOM = "UZACOM";

        /// <summary>
        /// UZAID.
        /// </summary>
        public const string UZAID = "UZAID";

        /// <summary>
        /// UZANBY.
        /// </summary>
        public const string UZANBY = "UZANBY";

        /// <summary>
        /// UZANI.
        /// </summary>
        public const string UZANI = "UZANI";

        /// <summary>
        /// UZANTY.
        /// </summary>
        public const string UZANTY = "UZANTY";

        /// <summary>
        /// UZASN.
        /// </summary>
        public const string UZASN = "UZASN";

        /// <summary>
        /// UZBACK.
        /// </summary>
        public const string UZBACK = "UZBACK";

        /// <summary>
        /// UZCLVL.
        /// </summary>
        public const string UZCLVL = "UZCLVL";

        /// <summary>
        /// UZCMCG.
        /// </summary>
        public const string UZCMCG = "UZCMCG";

        /// <summary>
        /// UZCMGL.
        /// </summary>
        public const string UZCMGL = "UZCMGL";

        /// <summary>
        /// UZCMGP.
        /// </summary>
        public const string UZCMGP = "UZCMGP";

        /// <summary>
        /// UZCORD.
        /// </summary>
        public const string UZCORD = "UZCORD";

        /// <summary>
        /// UZDCTO.
        /// </summary>
        public const string UZDCTO = "UZDCTO";

        /// <summary>
        /// UZDMCS.
        /// </summary>
        public const string UZDMCS = "UZDMCS";

        /// <summary>
        /// UZDMCT.
        /// </summary>
        public const string UZDMCT = "UZDMCT";

        /// <summary>
        /// UZDOCO.
        /// </summary>
        public const string UZDOCO = "UZDOCO";

        /// <summary>
        /// UZEDBT.
        /// </summary>
        public const string UZEDBT = "UZEDBT";

        /// <summary>
        /// UZEDCT.
        /// </summary>
        public const string UZEDCT = "UZEDCT";

        /// <summary>
        /// UZEDDL.
        /// </summary>
        public const string UZEDDL = "UZEDDL";

        /// <summary>
        /// UZEDDT.
        /// </summary>
        public const string UZEDDT = "UZEDDT";

        /// <summary>
        /// UZEDER.
        /// </summary>
        public const string UZEDER = "UZEDER";

        /// <summary>
        /// UZEDFT.
        /// </summary>
        public const string UZEDFT = "UZEDFT";

        /// <summary>
        /// UZEDLN.
        /// </summary>
        public const string UZEDLN = "UZEDLN";

        /// <summary>
        /// UZEDOC.
        /// </summary>
        public const string UZEDOC = "UZEDOC";

        /// <summary>
        /// UZEDSP.
        /// </summary>
        public const string UZEDSP = "UZEDSP";

        /// <summary>
        /// UZEDSQ.
        /// </summary>
        public const string UZEDSQ = "UZEDSQ";

        /// <summary>
        /// UZEDST.
        /// </summary>
        public const string UZEDST = "UZEDST";

        /// <summary>
        /// UZEDTY.
        /// </summary>
        public const string UZEDTY = "UZEDTY";

        /// <summary>
        /// UZEKCO.
        /// </summary>
        public const string UZEKCO = "UZEKCO";

        /// <summary>
        /// UZEXR1.
        /// </summary>
        public const string UZEXR1 = "UZEXR1";

        /// <summary>
        /// UZFAPP.
        /// </summary>
        public const string UZFAPP = "UZFAPP";

        /// <summary>
        /// UZFUN2.
        /// </summary>
        public const string UZFUN2 = "UZFUN2";

        /// <summary>
        /// UZKCOO.
        /// </summary>
        public const string UZKCOO = "UZKCOO";

        /// <summary>
        /// UZLNID.
        /// </summary>
        public const string UZLNID = "UZLNID";

        /// <summary>
        /// UZLT.
        /// </summary>
        public const string UZLT = "UZLT";

        /// <summary>
        /// UZMCLN.
        /// </summary>
        public const string UZMCLN = "UZMCLN";

        /// <summary>
        /// UZMERL.
        /// </summary>
        public const string UZMERL = "UZMERL";

        /// <summary>
        /// UZNUMB.
        /// </summary>
        public const string UZNUMB = "UZNUMB";

        /// <summary>
        /// UZOBJ.
        /// </summary>
        public const string UZOBJ = "UZOBJ";

        /// <summary>
        /// UZODLN.
        /// </summary>
        public const string UZODLN = "UZODLN";

        /// <summary>
        /// UZOMCU.
        /// </summary>
        public const string UZOMCU = "UZOMCU";

        /// <summary>
        /// UZORP.
        /// </summary>
        public const string UZORP = "UZORP";

        /// <summary>
        /// UZORPR.
        /// </summary>
        public const string UZORPR = "UZORPR";

        /// <summary>
        /// UZOSEQ.
        /// </summary>
        public const string UZOSEQ = "UZOSEQ";

        /// <summary>
        /// UZPEND.
        /// </summary>
        public const string UZPEND = "UZPEND";

        /// <summary>
        /// UZPOE.
        /// </summary>
        public const string UZPOE = "UZPOE";

        /// <summary>
        /// UZPRGR.
        /// </summary>
        public const string UZPRGR = "UZPRGR";

        /// <summary>
        /// UZPROV.
        /// </summary>
        public const string UZPROV = "UZPROV";

        /// <summary>
        /// UZPRP3.
        /// </summary>
        public const string UZPRP3 = "UZPRP3";

        /// <summary>
        /// UZPRP4.
        /// </summary>
        public const string UZPRP4 = "UZPRP4";

        /// <summary>
        /// UZPRP5.
        /// </summary>
        public const string UZPRP5 = "UZPRP5";

        /// <summary>
        /// UZPSDJ.
        /// </summary>
        public const string UZPSDJ = "UZPSDJ";

        /// <summary>
        /// UZRESL.
        /// </summary>
        public const string UZRESL = "UZRESL";

        /// <summary>
        /// UZRPRC.
        /// </summary>
        public const string UZRPRC = "UZRPRC";

        /// <summary>
        /// UZSBL.
        /// </summary>
        public const string UZSBL = "UZSBL";

        /// <summary>
        /// UZSBLT.
        /// </summary>
        public const string UZSBLT = "UZSBLT";

        /// <summary>
        /// UZSO02.
        /// </summary>
        public const string UZSO02 = "UZSO02";

        /// <summary>
        /// UZSO03.
        /// </summary>
        public const string UZSO03 = "UZSO03";

        /// <summary>
        /// UZSO04.
        /// </summary>
        public const string UZSO04 = "UZSO04";

        /// <summary>
        /// UZSO05.
        /// </summary>
        public const string UZSO05 = "UZSO05";

        /// <summary>
        /// UZSO06.
        /// </summary>
        public const string UZSO06 = "UZSO06";

        /// <summary>
        /// UZSO07.
        /// </summary>
        public const string UZSO07 = "UZSO07";

        /// <summary>
        /// UZSO08.
        /// </summary>
        public const string UZSO08 = "UZSO08";

        /// <summary>
        /// UZSO09.
        /// </summary>
        public const string UZSO09 = "UZSO09";

        /// <summary>
        /// UZSO10.
        /// </summary>
        public const string UZSO10 = "UZSO10";

        /// <summary>
        /// UZSO11.
        /// </summary>
        public const string UZSO11 = "UZSO11";

        /// <summary>
        /// UZSO12.
        /// </summary>
        public const string UZSO12 = "UZSO12";

        /// <summary>
        /// UZSO13.
        /// </summary>
        public const string UZSO13 = "UZSO13";

        /// <summary>
        /// UZSO14.
        /// </summary>
        public const string UZSO14 = "UZSO14";

        /// <summary>
        /// UZSO15.
        /// </summary>
        public const string UZSO15 = "UZSO15";

        /// <summary>
        /// UZSO16.
        /// </summary>
        public const string UZSO16 = "UZSO16";

        /// <summary>
        /// UZSO17.
        /// </summary>
        public const string UZSO17 = "UZSO17";

        /// <summary>
        /// UZSO18.
        /// </summary>
        public const string UZSO18 = "UZSO18";

        /// <summary>
        /// UZSO19.
        /// </summary>
        public const string UZSO19 = "UZSO19";

        /// <summary>
        /// UZSO20.
        /// </summary>
        public const string UZSO20 = "UZSO20";

        /// <summary>
        /// UZSUB.
        /// </summary>
        public const string UZSUB = "UZSUB";

        /// <summary>
        /// UZSWMS.
        /// </summary>
        public const string UZSWMS = "UZSWMS";

        /// <summary>
        /// UZTAX1.
        /// </summary>
        public const string UZTAX1 = "UZTAX1";

        /// <summary>
        /// UZTPC.
        /// </summary>
        public const string UZTPC = "UZTPC";

        /// <summary>
        /// UZTXA1.
        /// </summary>
        public const string UZTXA1 = "UZTXA1";

        /// <summary>
        /// UZUNCD.
        /// </summary>
        public const string UZUNCD = "UZUNCD";

        /// <summary>
        /// UZUPC1.
        /// </summary>
        public const string UZUPC1 = "UZUPC1";

        /// <summary>
        /// UZUPC2.
        /// </summary>
        public const string UZUPC2 = "UZUPC2";

        /// <summary>
        /// UZUPC3.
        /// </summary>
        public const string UZUPC3 = "UZUPC3";

        /// <summary>
        /// UZVEND.
        /// </summary>
        public const string UZVEND = "UZVEND";

        /// <summary>
        /// UZXCTO.
        /// </summary>
        public const string UZXCTO = "UZXCTO";

        /// <summary>
        /// UZXDCK.
        /// </summary>
        public const string UZXDCK = "UZXDCK";

        /// <summary>
        /// UZXKCO.
        /// </summary>
        public const string UZXKCO = "UZXKCO";

        /// <summary>
        /// UZXLLN.
        /// </summary>
        public const string UZXLLN = "UZXLLN";

        /// <summary>
        /// UZXORN.
        /// </summary>
        public const string UZXORN = "UZXORN";

        /// <summary>
        /// UZXPTY.
        /// </summary>
        public const string UZXPTY = "UZXPTY";

        /// <summary>
        /// UZXSFX.
        /// </summary>
        public const string UZXSFX = "UZXSFX";

        /// <summary>
        /// UZEMCU.
        /// </summary>
        public const string UZEMCU = "UZEMCU";

        /// <summary>
        /// UZIR01.
        /// </summary>
        public const string UZIR01 = "UZIR01";

        /// <summary>
        /// UZIR02.
        /// </summary>
        public const string UZIR02 = "UZIR02";

        /// <summary>
        /// UZIR03.
        /// </summary>
        public const string UZIR03 = "UZIR03";

        /// <summary>
        /// UZIR04.
        /// </summary>
        public const string UZIR04 = "UZIR04";

        /// <summary>
        /// UZIR05.
        /// </summary>
        public const string UZIR05 = "UZIR05";

        /// <summary>
        /// UZSBAL.
        /// </summary>
        public const string UZSBAL = "UZSBAL";

        /// <summary>
        /// UZUSER.
        /// </summary>
        public const string UZUSER = "UZUSER";

        /// <summary>
        /// UZPID.
        /// </summary>
        public const string UZPID = "UZPID";

        /// <summary>
        /// UZJOBN.
        /// </summary>
        public const string UZJOBN = "UZJOBN";

        /// <summary>
        /// UZUPMJ.
        /// </summary>
        public const string UZUPMJ = "UZUPMJ";

        /// <summary>
        /// UZTDAY.
        /// </summary>
        public const string UZTDAY = "UZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F470371T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UZAAID", "UZAAID", JdeDataType.Numeric),
        new JdeField("UZACOM", "UZACOM", JdeDataType.String, 2),
        new JdeField("UZAID", "UZAID", JdeDataType.String, 16),
        new JdeField("UZANBY", "UZANBY", JdeDataType.Numeric),
        new JdeField("UZANI", "UZANI", JdeDataType.String, 58),
        new JdeField("UZANTY", "UZANTY", JdeDataType.String, 2),
        new JdeField("UZASN", "UZASN", JdeDataType.String, 16),
        new JdeField("UZBACK", "UZBACK", JdeDataType.String, 2),
        new JdeField("UZCLVL", "UZCLVL", JdeDataType.String, 6),
        new JdeField("UZCMCG", "UZCMCG", JdeDataType.String, 16),
        new JdeField("UZCMGL", "UZCMGL", JdeDataType.String, 2),
        new JdeField("UZCMGP", "UZCMGP", JdeDataType.String, 4),
        new JdeField("UZCORD", "UZCORD", JdeDataType.Numeric),
        new JdeField("UZDCTO", "UZDCTO", JdeDataType.String, 4),
        new JdeField("UZDMCS", "UZDMCS", JdeDataType.Numeric),
        new JdeField("UZDMCT", "UZDMCT", JdeDataType.String, 24),
        new JdeField("UZDOCO", "UZDOCO", JdeDataType.Numeric),
        new JdeField("UZEDBT", "UZEDBT", JdeDataType.String, 30),
        new JdeField("UZEDCT", "UZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("UZEDDL", "UZEDDL", JdeDataType.Numeric),
        new JdeField("UZEDDT", "UZEDDT", JdeDataType.Numeric),
        new JdeField("UZEDER", "UZEDER", JdeDataType.String, 2),
        new JdeField("UZEDFT", "UZEDFT", JdeDataType.String, 20),
        new JdeField("UZEDLN", "UZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("UZEDOC", "UZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("UZEDSP", "UZEDSP", JdeDataType.String, 2),
        new JdeField("UZEDSQ", "UZEDSQ", JdeDataType.Numeric),
        new JdeField("UZEDST", "UZEDST", JdeDataType.String, 12),
        new JdeField("UZEDTY", "UZEDTY", JdeDataType.String, 2),
        new JdeField("UZEKCO", "UZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("UZEXR1", "UZEXR1", JdeDataType.String, 4),
        new JdeField("UZFAPP", "UZFAPP", JdeDataType.String, 2),
        new JdeField("UZFUN2", "UZFUN2", JdeDataType.Numeric),
        new JdeField("UZKCOO", "UZKCOO", JdeDataType.String, 10),
        new JdeField("UZLNID", "UZLNID", JdeDataType.Numeric),
        new JdeField("UZLT", "UZLT", JdeDataType.String, 4),
        new JdeField("UZMCLN", "UZMCLN", JdeDataType.Numeric),
        new JdeField("UZMERL", "UZMERL", JdeDataType.String, 6),
        new JdeField("UZNUMB", "UZNUMB", JdeDataType.Numeric),
        new JdeField("UZOBJ", "UZOBJ", JdeDataType.String, 12),
        new JdeField("UZODLN", "UZODLN", JdeDataType.Numeric),
        new JdeField("UZOMCU", "UZOMCU", JdeDataType.String, 24),
        new JdeField("UZORP", "UZORP", JdeDataType.String, 2),
        new JdeField("UZORPR", "UZORPR", JdeDataType.String, 16),
        new JdeField("UZOSEQ", "UZOSEQ", JdeDataType.Numeric),
        new JdeField("UZPEND", "UZPEND", JdeDataType.String, 2),
        new JdeField("UZPOE", "UZPOE", JdeDataType.String, 12),
        new JdeField("UZPRGR", "UZPRGR", JdeDataType.String, 16),
        new JdeField("UZPROV", "UZPROV", JdeDataType.String, 2),
        new JdeField("UZPRP3", "UZPRP3", JdeDataType.String, 6),
        new JdeField("UZPRP4", "UZPRP4", JdeDataType.String, 6),
        new JdeField("UZPRP5", "UZPRP5", JdeDataType.String, 6),
        new JdeField("UZPSDJ", "UZPSDJ", JdeDataType.Numeric),
        new JdeField("UZRESL", "UZRESL", JdeDataType.String, 2),
        new JdeField("UZRPRC", "UZRPRC", JdeDataType.String, 16),
        new JdeField("UZSBL", "UZSBL", JdeDataType.String, 16),
        new JdeField("UZSBLT", "UZSBLT", JdeDataType.String, 2),
        new JdeField("UZSO02", "UZSO02", JdeDataType.String, 2),
        new JdeField("UZSO03", "UZSO03", JdeDataType.String, 2),
        new JdeField("UZSO04", "UZSO04", JdeDataType.String, 2),
        new JdeField("UZSO05", "UZSO05", JdeDataType.String, 2),
        new JdeField("UZSO06", "UZSO06", JdeDataType.String, 2),
        new JdeField("UZSO07", "UZSO07", JdeDataType.String, 2),
        new JdeField("UZSO08", "UZSO08", JdeDataType.String, 2),
        new JdeField("UZSO09", "UZSO09", JdeDataType.String, 2),
        new JdeField("UZSO10", "UZSO10", JdeDataType.String, 2),
        new JdeField("UZSO11", "UZSO11", JdeDataType.String, 2),
        new JdeField("UZSO12", "UZSO12", JdeDataType.String, 2),
        new JdeField("UZSO13", "UZSO13", JdeDataType.String, 2),
        new JdeField("UZSO14", "UZSO14", JdeDataType.String, 2),
        new JdeField("UZSO15", "UZSO15", JdeDataType.String, 2),
        new JdeField("UZSO16", "UZSO16", JdeDataType.String, 2),
        new JdeField("UZSO17", "UZSO17", JdeDataType.String, 2),
        new JdeField("UZSO18", "UZSO18", JdeDataType.String, 2),
        new JdeField("UZSO19", "UZSO19", JdeDataType.String, 2),
        new JdeField("UZSO20", "UZSO20", JdeDataType.String, 2),
        new JdeField("UZSUB", "UZSUB", JdeDataType.String, 16),
        new JdeField("UZSWMS", "UZSWMS", JdeDataType.String, 2),
        new JdeField("UZTAX1", "UZTAX1", JdeDataType.String, 2),
        new JdeField("UZTPC", "UZTPC", JdeDataType.String, 2),
        new JdeField("UZTXA1", "UZTXA1", JdeDataType.String, 20),
        new JdeField("UZUNCD", "UZUNCD", JdeDataType.String, 2),
        new JdeField("UZUPC1", "UZUPC1", JdeDataType.String, 4),
        new JdeField("UZUPC2", "UZUPC2", JdeDataType.String, 4),
        new JdeField("UZUPC3", "UZUPC3", JdeDataType.String, 4),
        new JdeField("UZVEND", "UZVEND", JdeDataType.Numeric),
        new JdeField("UZXCTO", "UZXCTO", JdeDataType.String, 4),
        new JdeField("UZXDCK", "UZXDCK", JdeDataType.String, 2),
        new JdeField("UZXKCO", "UZXKCO", JdeDataType.String, 10),
        new JdeField("UZXLLN", "UZXLLN", JdeDataType.Numeric),
        new JdeField("UZXORN", "UZXORN", JdeDataType.Numeric),
        new JdeField("UZXPTY", "UZXPTY", JdeDataType.Numeric),
        new JdeField("UZXSFX", "UZXSFX", JdeDataType.String, 6),
        new JdeField("UZEMCU", "UZEMCU", JdeDataType.String, 24),
        new JdeField("UZIR01", "UZIR01", JdeDataType.String, 60),
        new JdeField("UZIR02", "UZIR02", JdeDataType.String, 60),
        new JdeField("UZIR03", "UZIR03", JdeDataType.String, 60),
        new JdeField("UZIR04", "UZIR04", JdeDataType.String, 60),
        new JdeField("UZIR05", "UZIR05", JdeDataType.String, 60),
        new JdeField("UZSBAL", "UZSBAL", JdeDataType.String, 2),
        new JdeField("UZUSER", "UZUSER", JdeDataType.String, 20),
        new JdeField("UZPID", "UZPID", JdeDataType.String, 20),
        new JdeField("UZJOBN", "UZJOBN", JdeDataType.String, 20),
        new JdeField("UZUPMJ", "UZUPMJ", JdeDataType.Numeric),
        new JdeField("UZTDAY", "UZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470371T_0", "Primary Key on UZEDOC, UZEKCO, UZEDLN, UZEDCT", new[] { "UZEDOC", "UZEKCO", "UZEDLN", "UZEDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F470371T_2", "Index on UZEDOC, UZEDCT, UZEKCO", new[] { "UZEDOC", "UZEDCT", "UZEKCO" })
    };
}
