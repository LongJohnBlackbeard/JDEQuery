using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47012T - .
/// </summary>
public class F47012T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UZEDTY.
        /// </summary>
        public const string UZEDTY = "UZEDTY";

        /// <summary>
        /// UZEDSQ.
        /// </summary>
        public const string UZEDSQ = "UZEDSQ";

        /// <summary>
        /// UZEDOC.
        /// </summary>
        public const string UZEDOC = "UZEDOC";

        /// <summary>
        /// UZEDCT.
        /// </summary>
        public const string UZEDCT = "UZEDCT";

        /// <summary>
        /// UZEKCO.
        /// </summary>
        public const string UZEKCO = "UZEKCO";

        /// <summary>
        /// UZEDLN.
        /// </summary>
        public const string UZEDLN = "UZEDLN";

        /// <summary>
        /// UZEDST.
        /// </summary>
        public const string UZEDST = "UZEDST";

        /// <summary>
        /// UZEDFT.
        /// </summary>
        public const string UZEDFT = "UZEDFT";

        /// <summary>
        /// UZEDDT.
        /// </summary>
        public const string UZEDDT = "UZEDDT";

        /// <summary>
        /// UZEDER.
        /// </summary>
        public const string UZEDER = "UZEDER";

        /// <summary>
        /// UZEDDL.
        /// </summary>
        public const string UZEDDL = "UZEDDL";

        /// <summary>
        /// UZEDSP.
        /// </summary>
        public const string UZEDSP = "UZEDSP";

        /// <summary>
        /// UZEDBT.
        /// </summary>
        public const string UZEDBT = "UZEDBT";

        /// <summary>
        /// UZPNID.
        /// </summary>
        public const string UZPNID = "UZPNID";

        /// <summary>
        /// UZKCOO.
        /// </summary>
        public const string UZKCOO = "UZKCOO";

        /// <summary>
        /// UZDOCO.
        /// </summary>
        public const string UZDOCO = "UZDOCO";

        /// <summary>
        /// UZDCTO.
        /// </summary>
        public const string UZDCTO = "UZDCTO";

        /// <summary>
        /// UZLNID.
        /// </summary>
        public const string UZLNID = "UZLNID";

        /// <summary>
        /// UZSFXO.
        /// </summary>
        public const string UZSFXO = "UZSFXO";

        /// <summary>
        /// UZRSDT.
        /// </summary>
        public const string UZRSDT = "UZRSDT";

        /// <summary>
        /// UZOSEQ.
        /// </summary>
        public const string UZOSEQ = "UZOSEQ";

        /// <summary>
        /// UZMERL.
        /// </summary>
        public const string UZMERL = "UZMERL";

        /// <summary>
        /// UZHDBU.
        /// </summary>
        public const string UZHDBU = "UZHDBU";

        /// <summary>
        /// UZDMBU.
        /// </summary>
        public const string UZDMBU = "UZDMBU";

        /// <summary>
        /// UZBCRC.
        /// </summary>
        public const string UZBCRC = "UZBCRC";

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
        /// UZVR03.
        /// </summary>
        public const string UZVR03 = "UZVR03";

        /// <summary>
        /// UZXDCK.
        /// </summary>
        public const string UZXDCK = "UZXDCK";

        /// <summary>
        /// UZXPTY.
        /// </summary>
        public const string UZXPTY = "UZXPTY";

        /// <summary>
        /// UZCORD.
        /// </summary>
        public const string UZCORD = "UZCORD";

        /// <summary>
        /// UZPEND.
        /// </summary>
        public const string UZPEND = "UZPEND";

        /// <summary>
        /// UZMCLN.
        /// </summary>
        public const string UZMCLN = "UZMCLN";

        /// <summary>
        /// UZODLN.
        /// </summary>
        public const string UZODLN = "UZODLN";

        /// <summary>
        /// UZXKCO.
        /// </summary>
        public const string UZXKCO = "UZXKCO";

        /// <summary>
        /// UZXORN.
        /// </summary>
        public const string UZXORN = "UZXORN";

        /// <summary>
        /// UZXCTO.
        /// </summary>
        public const string UZXCTO = "UZXCTO";

        /// <summary>
        /// UZXLLN.
        /// </summary>
        public const string UZXLLN = "UZXLLN";

        /// <summary>
        /// UZXSFX.
        /// </summary>
        public const string UZXSFX = "UZXSFX";

        /// <summary>
        /// UZPOE.
        /// </summary>
        public const string UZPOE = "UZPOE";

        /// <summary>
        /// UZFXSR.
        /// </summary>
        public const string UZFXSR = "UZFXSR";

        /// <summary>
        /// UZOPOL.
        /// </summary>
        public const string UZOPOL = "UZOPOL";

        /// <summary>
        /// UZOPBO.
        /// </summary>
        public const string UZOPBO = "UZOPBO";

        /// <summary>
        /// UZOPID.
        /// </summary>
        public const string UZOPID = "UZOPID";

        /// <summary>
        /// UZOPCS.
        /// </summary>
        public const string UZOPCS = "UZOPCS";

        /// <summary>
        /// UZOPLL.
        /// </summary>
        public const string UZOPLL = "UZOPLL";

        /// <summary>
        /// UZOPMS.
        /// </summary>
        public const string UZOPMS = "UZOPMS";

        /// <summary>
        /// UZOPSS.
        /// </summary>
        public const string UZOPSS = "UZOPSS";

        /// <summary>
        /// UZOPBA.
        /// </summary>
        public const string UZOPBA = "UZOPBA";

        /// <summary>
        /// UZNUMB.
        /// </summary>
        public const string UZNUMB = "UZNUMB";

        /// <summary>
        /// UZAAID.
        /// </summary>
        public const string UZAAID = "UZAAID";

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

        /// <summary>
        /// UZSPATTN.
        /// </summary>
        public const string UZSPATTN = "UZSPATTN";

        /// <summary>
        /// UZCCIDLN.
        /// </summary>
        public const string UZCCIDLN = "UZCCIDLN";

        /// <summary>
        /// UZCATNM.
        /// </summary>
        public const string UZCATNM = "UZCATNM";

        /// <summary>
        /// UZSHCCIDLN.
        /// </summary>
        public const string UZSHCCIDLN = "UZSHCCIDLN";

        /// <summary>
        /// UZPRAN8.
        /// </summary>
        public const string UZPRAN8 = "UZPRAN8";

        /// <summary>
        /// UZPRCIDLN.
        /// </summary>
        public const string UZPRCIDLN = "UZPRCIDLN";

        /// <summary>
        /// UZOPPID.
        /// </summary>
        public const string UZOPPID = "UZOPPID";

        /// <summary>
        /// UZOSTP.
        /// </summary>
        public const string UZOSTP = "UZOSTP";

        /// <summary>
        /// UZUKID.
        /// </summary>
        public const string UZUKID = "UZUKID";

        /// <summary>
        /// UZEXVAR0.
        /// </summary>
        public const string UZEXVAR0 = "UZEXVAR0";

        /// <summary>
        /// UZEXVAR1.
        /// </summary>
        public const string UZEXVAR1 = "UZEXVAR1";

        /// <summary>
        /// UZEXVAR4.
        /// </summary>
        public const string UZEXVAR4 = "UZEXVAR4";

        /// <summary>
        /// UZEXVAR5.
        /// </summary>
        public const string UZEXVAR5 = "UZEXVAR5";

        /// <summary>
        /// UZEXVAR6.
        /// </summary>
        public const string UZEXVAR6 = "UZEXVAR6";

        /// <summary>
        /// UZEXVAR7.
        /// </summary>
        public const string UZEXVAR7 = "UZEXVAR7";

        /// <summary>
        /// UZEXVAR12.
        /// </summary>
        public const string UZEXVAR12 = "UZEXVAR12";

        /// <summary>
        /// UZEXVAR13.
        /// </summary>
        public const string UZEXVAR13 = "UZEXVAR13";

        /// <summary>
        /// UZEXNM0.
        /// </summary>
        public const string UZEXNM0 = "UZEXNM0";

        /// <summary>
        /// UZEXNM1.
        /// </summary>
        public const string UZEXNM1 = "UZEXNM1";

        /// <summary>
        /// UZEXNM2.
        /// </summary>
        public const string UZEXNM2 = "UZEXNM2";

        /// <summary>
        /// UZEXNMP0.
        /// </summary>
        public const string UZEXNMP0 = "UZEXNMP0";

        /// <summary>
        /// UZEXNMP1.
        /// </summary>
        public const string UZEXNMP1 = "UZEXNMP1";

        /// <summary>
        /// UZEXNMP2.
        /// </summary>
        public const string UZEXNMP2 = "UZEXNMP2";

        /// <summary>
        /// UZEXDT0.
        /// </summary>
        public const string UZEXDT0 = "UZEXDT0";

        /// <summary>
        /// UZEXDT1.
        /// </summary>
        public const string UZEXDT1 = "UZEXDT1";

        /// <summary>
        /// UZEXDT2.
        /// </summary>
        public const string UZEXDT2 = "UZEXDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F47012T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UZEDTY", "UZEDTY", JdeDataType.String, 2),
        new JdeField("UZEDSQ", "UZEDSQ", JdeDataType.Numeric),
        new JdeField("UZEDOC", "UZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("UZEDCT", "UZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("UZEKCO", "UZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("UZEDLN", "UZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("UZEDST", "UZEDST", JdeDataType.String, 12),
        new JdeField("UZEDFT", "UZEDFT", JdeDataType.String, 20),
        new JdeField("UZEDDT", "UZEDDT", JdeDataType.Numeric),
        new JdeField("UZEDER", "UZEDER", JdeDataType.String, 2),
        new JdeField("UZEDDL", "UZEDDL", JdeDataType.Numeric),
        new JdeField("UZEDSP", "UZEDSP", JdeDataType.String, 2),
        new JdeField("UZEDBT", "UZEDBT", JdeDataType.String, 30),
        new JdeField("UZPNID", "UZPNID", JdeDataType.String, 30),
        new JdeField("UZKCOO", "UZKCOO", JdeDataType.String, 10),
        new JdeField("UZDOCO", "UZDOCO", JdeDataType.Numeric),
        new JdeField("UZDCTO", "UZDCTO", JdeDataType.String, 4),
        new JdeField("UZLNID", "UZLNID", JdeDataType.Numeric),
        new JdeField("UZSFXO", "UZSFXO", JdeDataType.String, 6),
        new JdeField("UZRSDT", "UZRSDT", JdeDataType.Numeric),
        new JdeField("UZOSEQ", "UZOSEQ", JdeDataType.Numeric),
        new JdeField("UZMERL", "UZMERL", JdeDataType.String, 6),
        new JdeField("UZHDBU", "UZHDBU", JdeDataType.String, 24),
        new JdeField("UZDMBU", "UZDMBU", JdeDataType.String, 24),
        new JdeField("UZBCRC", "UZBCRC", JdeDataType.String, 6),
        new JdeField("UZSO16", "UZSO16", JdeDataType.String, 2),
        new JdeField("UZSO17", "UZSO17", JdeDataType.String, 2),
        new JdeField("UZSO18", "UZSO18", JdeDataType.String, 2),
        new JdeField("UZSO19", "UZSO19", JdeDataType.String, 2),
        new JdeField("UZSO20", "UZSO20", JdeDataType.String, 2),
        new JdeField("UZVR03", "UZVR03", JdeDataType.String, 50),
        new JdeField("UZXDCK", "UZXDCK", JdeDataType.String, 2),
        new JdeField("UZXPTY", "UZXPTY", JdeDataType.Numeric),
        new JdeField("UZCORD", "UZCORD", JdeDataType.Numeric),
        new JdeField("UZPEND", "UZPEND", JdeDataType.String, 2),
        new JdeField("UZMCLN", "UZMCLN", JdeDataType.Numeric),
        new JdeField("UZODLN", "UZODLN", JdeDataType.Numeric),
        new JdeField("UZXKCO", "UZXKCO", JdeDataType.String, 10),
        new JdeField("UZXORN", "UZXORN", JdeDataType.Numeric),
        new JdeField("UZXCTO", "UZXCTO", JdeDataType.String, 4),
        new JdeField("UZXLLN", "UZXLLN", JdeDataType.Numeric),
        new JdeField("UZXSFX", "UZXSFX", JdeDataType.String, 6),
        new JdeField("UZPOE", "UZPOE", JdeDataType.String, 12),
        new JdeField("UZFXSR", "UZFXSR", JdeDataType.String, 2),
        new JdeField("UZOPOL", "UZOPOL", JdeDataType.Numeric),
        new JdeField("UZOPBO", "UZOPBO", JdeDataType.String, 60),
        new JdeField("UZOPID", "UZOPID", JdeDataType.String, 60),
        new JdeField("UZOPCS", "UZOPCS", JdeDataType.Numeric),
        new JdeField("UZOPLL", "UZOPLL", JdeDataType.String, 2),
        new JdeField("UZOPMS", "UZOPMS", JdeDataType.String, 2),
        new JdeField("UZOPSS", "UZOPSS", JdeDataType.String, 2),
        new JdeField("UZOPBA", "UZOPBA", JdeDataType.String, 2),
        new JdeField("UZNUMB", "UZNUMB", JdeDataType.Numeric),
        new JdeField("UZAAID", "UZAAID", JdeDataType.Numeric),
        new JdeField("UZUSER", "UZUSER", JdeDataType.String, 20),
        new JdeField("UZPID", "UZPID", JdeDataType.String, 20),
        new JdeField("UZJOBN", "UZJOBN", JdeDataType.String, 20),
        new JdeField("UZUPMJ", "UZUPMJ", JdeDataType.Numeric),
        new JdeField("UZTDAY", "UZTDAY", JdeDataType.Numeric),
        new JdeField("UZSPATTN", "UZSPATTN", JdeDataType.String, 100),
        new JdeField("UZCCIDLN", "UZCCIDLN", JdeDataType.Numeric),
        new JdeField("UZCATNM", "UZCATNM", JdeDataType.String, 60),
        new JdeField("UZSHCCIDLN", "UZSHCCIDLN", JdeDataType.Numeric),
        new JdeField("UZPRAN8", "UZPRAN8", JdeDataType.Numeric),
        new JdeField("UZPRCIDLN", "UZPRCIDLN", JdeDataType.Numeric),
        new JdeField("UZOPPID", "UZOPPID", JdeDataType.Numeric),
        new JdeField("UZOSTP", "UZOSTP", JdeDataType.String, 6),
        new JdeField("UZUKID", "UZUKID", JdeDataType.Numeric),
        new JdeField("UZEXVAR0", "UZEXVAR0", JdeDataType.String, 510),
        new JdeField("UZEXVAR1", "UZEXVAR1", JdeDataType.String, 510),
        new JdeField("UZEXVAR4", "UZEXVAR4", JdeDataType.String, 100),
        new JdeField("UZEXVAR5", "UZEXVAR5", JdeDataType.String, 100),
        new JdeField("UZEXVAR6", "UZEXVAR6", JdeDataType.String, 100),
        new JdeField("UZEXVAR7", "UZEXVAR7", JdeDataType.String, 100),
        new JdeField("UZEXVAR12", "UZEXVAR12", JdeDataType.String, 50),
        new JdeField("UZEXVAR13", "UZEXVAR13", JdeDataType.String, 50),
        new JdeField("UZEXNM0", "UZEXNM0", JdeDataType.Numeric),
        new JdeField("UZEXNM1", "UZEXNM1", JdeDataType.Numeric),
        new JdeField("UZEXNM2", "UZEXNM2", JdeDataType.Numeric),
        new JdeField("UZEXNMP0", "UZEXNMP0", JdeDataType.Numeric),
        new JdeField("UZEXNMP1", "UZEXNMP1", JdeDataType.Numeric),
        new JdeField("UZEXNMP2", "UZEXNMP2", JdeDataType.Numeric),
        new JdeField("UZEXDT0", "UZEXDT0", JdeDataType.Date),
        new JdeField("UZEXDT1", "UZEXDT1", JdeDataType.Date),
        new JdeField("UZEXDT2", "UZEXDT2", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47012T_0", "Primary Key on UZEDOC, UZEDCT, UZEKCO, UZEDLN", new[] { "UZEDOC", "UZEDCT", "UZEKCO", "UZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
