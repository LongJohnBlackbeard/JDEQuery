using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0425 - .
/// </summary>
public class F74U0425 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SFUKCENM.
        /// </summary>
        public const string SFUKCENM = "SFUKCENM";

        /// <summary>
        /// SFUKCEDT.
        /// </summary>
        public const string SFUKCEDT = "SFUKCEDT";

        /// <summary>
        /// SF74UACR.
        /// </summary>
        public const string SF74UACR = "SF74UACR";

        /// <summary>
        /// SFDOCO.
        /// </summary>
        public const string SFDOCO = "SFDOCO";

        /// <summary>
        /// SFDCTO.
        /// </summary>
        public const string SFDCTO = "SFDCTO";

        /// <summary>
        /// SFKCOO.
        /// </summary>
        public const string SFKCOO = "SFKCOO";

        /// <summary>
        /// SFSFXO.
        /// </summary>
        public const string SFSFXO = "SFSFXO";

        /// <summary>
        /// SF74UCLN.
        /// </summary>
        public const string SF74UCLN = "SF74UCLN";

        /// <summary>
        /// SFMATC.
        /// </summary>
        public const string SFMATC = "SFMATC";

        /// <summary>
        /// SFLNID.
        /// </summary>
        public const string SFLNID = "SFLNID";

        /// <summary>
        /// SF74USPCS.
        /// </summary>
        public const string SF74USPCS = "SF74USPCS";

        /// <summary>
        /// SFUKAPNM.
        /// </summary>
        public const string SFUKAPNM = "SFUKAPNM";

        /// <summary>
        /// SF74UALN.
        /// </summary>
        public const string SF74UALN = "SF74UALN";

        /// <summary>
        /// SFAN8.
        /// </summary>
        public const string SFAN8 = "SFAN8";

        /// <summary>
        /// SFCO.
        /// </summary>
        public const string SFCO = "SFCO";

        /// <summary>
        /// SFMCU.
        /// </summary>
        public const string SFMCU = "SFMCU";

        /// <summary>
        /// SFOBJ.
        /// </summary>
        public const string SFOBJ = "SFOBJ";

        /// <summary>
        /// SFSUB.
        /// </summary>
        public const string SFSUB = "SFSUB";

        /// <summary>
        /// SFSBL.
        /// </summary>
        public const string SFSBL = "SFSBL";

        /// <summary>
        /// SFSBLT.
        /// </summary>
        public const string SFSBLT = "SFSBLT";

        /// <summary>
        /// SFGLC.
        /// </summary>
        public const string SFGLC = "SFGLC";

        /// <summary>
        /// SFDGL.
        /// </summary>
        public const string SFDGL = "SFDGL";

        /// <summary>
        /// SFDDJ.
        /// </summary>
        public const string SFDDJ = "SFDDJ";

        /// <summary>
        /// SFDSVJ.
        /// </summary>
        public const string SFDSVJ = "SFDSVJ";

        /// <summary>
        /// SFCTRY.
        /// </summary>
        public const string SFCTRY = "SFCTRY";

        /// <summary>
        /// SFFY.
        /// </summary>
        public const string SFFY = "SFFY";

        /// <summary>
        /// SFPN.
        /// </summary>
        public const string SFPN = "SFPN";

        /// <summary>
        /// SFDOC.
        /// </summary>
        public const string SFDOC = "SFDOC";

        /// <summary>
        /// SFICU.
        /// </summary>
        public const string SFICU = "SFICU";

        /// <summary>
        /// SFICUT.
        /// </summary>
        public const string SFICUT = "SFICUT";

        /// <summary>
        /// SFDOCZ.
        /// </summary>
        public const string SFDOCZ = "SFDOCZ";

        /// <summary>
        /// SFDCTI.
        /// </summary>
        public const string SFDCTI = "SFDCTI";

        /// <summary>
        /// SFKCOI.
        /// </summary>
        public const string SFKCOI = "SFKCOI";

        /// <summary>
        /// SFSFX.
        /// </summary>
        public const string SFSFX = "SFSFX";

        /// <summary>
        /// SFTXA1.
        /// </summary>
        public const string SFTXA1 = "SFTXA1";

        /// <summary>
        /// SFEXR1.
        /// </summary>
        public const string SFEXR1 = "SFEXR1";

        /// <summary>
        /// SFPTC.
        /// </summary>
        public const string SFPTC = "SFPTC";

        /// <summary>
        /// SFAG.
        /// </summary>
        public const string SFAG = "SFAG";

        /// <summary>
        /// SF74UNT.
        /// </summary>
        public const string SF74UNT = "SF74UNT";

        /// <summary>
        /// SFUKCEAM.
        /// </summary>
        public const string SFUKCEAM = "SFUKCEAM";

        /// <summary>
        /// SFATXA.
        /// </summary>
        public const string SFATXA = "SFATXA";

        /// <summary>
        /// SF74UCVAT.
        /// </summary>
        public const string SF74UCVAT = "SF74UCVAT";

        /// <summary>
        /// SFADSC.
        /// </summary>
        public const string SFADSC = "SFADSC";

        /// <summary>
        /// SFUKCEQT.
        /// </summary>
        public const string SFUKCEQT = "SFUKCEQT";

        /// <summary>
        /// SFUKCEPE.
        /// </summary>
        public const string SFUKCEPE = "SFUKCEPE";

        /// <summary>
        /// SF74UCG.
        /// </summary>
        public const string SF74UCG = "SF74UCG";

        /// <summary>
        /// SF74UCN.
        /// </summary>
        public const string SF74UCN = "SF74UCN";

        /// <summary>
        /// SFUKCECA.
        /// </summary>
        public const string SFUKCECA = "SFUKCECA";

        /// <summary>
        /// SF74UCCVAT.
        /// </summary>
        public const string SF74UCCVAT = "SF74UCCVAT";

        /// <summary>
        /// SFUKCECQ.
        /// </summary>
        public const string SFUKCECQ = "SFUKCECQ";

        /// <summary>
        /// SFUKCECP.
        /// </summary>
        public const string SFUKCECP = "SFUKCECP";

        /// <summary>
        /// SFCRRM.
        /// </summary>
        public const string SFCRRM = "SFCRRM";

        /// <summary>
        /// SFCRCD.
        /// </summary>
        public const string SFCRCD = "SFCRCD";

        /// <summary>
        /// SFCRCF.
        /// </summary>
        public const string SFCRCF = "SFCRCF";

        /// <summary>
        /// SFCRR.
        /// </summary>
        public const string SFCRR = "SFCRR";

        /// <summary>
        /// SFACR.
        /// </summary>
        public const string SFACR = "SFACR";

        /// <summary>
        /// SF74UFNT.
        /// </summary>
        public const string SF74UFNT = "SF74UFNT";

        /// <summary>
        /// SFUKCEFA.
        /// </summary>
        public const string SFUKCEFA = "SFUKCEFA";

        /// <summary>
        /// SFCTXA.
        /// </summary>
        public const string SFCTXA = "SFCTXA";

        /// <summary>
        /// SF74UFVAT.
        /// </summary>
        public const string SF74UFVAT = "SF74UFVAT";

        /// <summary>
        /// SFCDS.
        /// </summary>
        public const string SFCDS = "SFCDS";

        /// <summary>
        /// SF74UFCG.
        /// </summary>
        public const string SF74UFCG = "SF74UFCG";

        /// <summary>
        /// SF74UFCN.
        /// </summary>
        public const string SF74UFCN = "SF74UFCN";

        /// <summary>
        /// SFUKCEFC.
        /// </summary>
        public const string SFUKCEFC = "SFUKCEFC";

        /// <summary>
        /// SF74UFCVAT.
        /// </summary>
        public const string SF74UFCVAT = "SF74UFCVAT";

        /// <summary>
        /// SF74UPRET.
        /// </summary>
        public const string SF74UPRET = "SF74UPRET";

        /// <summary>
        /// SFRTNG.
        /// </summary>
        public const string SFRTNG = "SFRTNG";

        /// <summary>
        /// SF74UCR.
        /// </summary>
        public const string SF74UCR = "SF74UCR";

        /// <summary>
        /// SFFTNG.
        /// </summary>
        public const string SFFTNG = "SFFTNG";

        /// <summary>
        /// SF74UFCR.
        /// </summary>
        public const string SF74UFCR = "SF74UFCR";

        /// <summary>
        /// SF74UMCDR.
        /// </summary>
        public const string SF74UMCDR = "SF74UMCDR";

        /// <summary>
        /// SF74UMCDA.
        /// </summary>
        public const string SF74UMCDA = "SF74UMCDA";

        /// <summary>
        /// SF74UMCDCA.
        /// </summary>
        public const string SF74UMCDCA = "SF74UMCDCA";

        /// <summary>
        /// SF74UFMCDA.
        /// </summary>
        public const string SF74UFMCDA = "SF74UFMCDA";

        /// <summary>
        /// SF74UFMCDC.
        /// </summary>
        public const string SF74UFMCDC = "SF74UFMCDC";

        /// <summary>
        /// SFRMK.
        /// </summary>
        public const string SFRMK = "SFRMK";

        /// <summary>
        /// SFUKCEPD.
        /// </summary>
        public const string SFUKCEPD = "SFUKCEPD";

        /// <summary>
        /// SF74UARP.
        /// </summary>
        public const string SF74UARP = "SF74UARP";

        /// <summary>
        /// SF74UARR.
        /// </summary>
        public const string SF74UARR = "SF74UARR";

        /// <summary>
        /// SF74UCCC1.
        /// </summary>
        public const string SF74UCCC1 = "SF74UCCC1";

        /// <summary>
        /// SF74UCCC2.
        /// </summary>
        public const string SF74UCCC2 = "SF74UCCC2";

        /// <summary>
        /// SF74UCCC3.
        /// </summary>
        public const string SF74UCCC3 = "SF74UCCC3";

        /// <summary>
        /// SF74UCCC4.
        /// </summary>
        public const string SF74UCCC4 = "SF74UCCC4";

        /// <summary>
        /// SF74UCCC5.
        /// </summary>
        public const string SF74UCCC5 = "SF74UCCC5";

        /// <summary>
        /// SFURAT.
        /// </summary>
        public const string SFURAT = "SFURAT";

        /// <summary>
        /// SFURCD.
        /// </summary>
        public const string SFURCD = "SFURCD";

        /// <summary>
        /// SFURDT.
        /// </summary>
        public const string SFURDT = "SFURDT";

        /// <summary>
        /// SFURAB.
        /// </summary>
        public const string SFURAB = "SFURAB";

        /// <summary>
        /// SFURRF.
        /// </summary>
        public const string SFURRF = "SFURRF";

        /// <summary>
        /// SFPID.
        /// </summary>
        public const string SFPID = "SFPID";

        /// <summary>
        /// SFJOBN.
        /// </summary>
        public const string SFJOBN = "SFJOBN";

        /// <summary>
        /// SFUSER.
        /// </summary>
        public const string SFUSER = "SFUSER";

        /// <summary>
        /// SFUPMJ.
        /// </summary>
        public const string SFUPMJ = "SFUPMJ";

        /// <summary>
        /// SFUPMT.
        /// </summary>
        public const string SFUPMT = "SFUPMT";

        /// <summary>
        /// SFOMCU.
        /// </summary>
        public const string SFOMCU = "SFOMCU";

        /// <summary>
        /// SFANI.
        /// </summary>
        public const string SFANI = "SFANI";

        /// <summary>
        /// SFAID.
        /// </summary>
        public const string SFAID = "SFAID";

        /// <summary>
        /// SFNLIN.
        /// </summary>
        public const string SFNLIN = "SFNLIN";

        /// <summary>
        /// SF74UPLAD.
        /// </summary>
        public const string SF74UPLAD = "SF74UPLAD";

        /// <summary>
        /// SF74UPMAD.
        /// </summary>
        public const string SF74UPMAD = "SF74UPMAD";

        /// <summary>
        /// SF74UPLAF.
        /// </summary>
        public const string SF74UPLAF = "SF74UPLAF";

        /// <summary>
        /// SF74UPMAF.
        /// </summary>
        public const string SF74UPMAF = "SF74UPMAF";

        /// <summary>
        /// SF74ULMSP.
        /// </summary>
        public const string SF74ULMSP = "SF74ULMSP";

        /// <summary>
        /// SF74UMLMS.
        /// </summary>
        public const string SF74UMLMS = "SF74UMLMS";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0425";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SFUKCENM", "SFUKCENM", JdeDataType.Numeric, null, true, true),
        new JdeField("SFUKCEDT", "SFUKCEDT", JdeDataType.Numeric),
        new JdeField("SF74UACR", "SF74UACR", JdeDataType.String, 30),
        new JdeField("SFDOCO", "SFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SFDCTO", "SFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SFKCOO", "SFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SFSFXO", "SFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SF74UCLN", "SF74UCLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SFMATC", "SFMATC", JdeDataType.String, 2, true, true),
        new JdeField("SFLNID", "SFLNID", JdeDataType.Numeric),
        new JdeField("SF74USPCS", "SF74USPCS", JdeDataType.String, 6),
        new JdeField("SFUKAPNM", "SFUKAPNM", JdeDataType.Numeric),
        new JdeField("SF74UALN", "SF74UALN", JdeDataType.Numeric),
        new JdeField("SFAN8", "SFAN8", JdeDataType.Numeric),
        new JdeField("SFCO", "SFCO", JdeDataType.String, 10),
        new JdeField("SFMCU", "SFMCU", JdeDataType.String, 24),
        new JdeField("SFOBJ", "SFOBJ", JdeDataType.String, 12),
        new JdeField("SFSUB", "SFSUB", JdeDataType.String, 16),
        new JdeField("SFSBL", "SFSBL", JdeDataType.String, 16),
        new JdeField("SFSBLT", "SFSBLT", JdeDataType.String, 2),
        new JdeField("SFGLC", "SFGLC", JdeDataType.String, 8),
        new JdeField("SFDGL", "SFDGL", JdeDataType.Numeric),
        new JdeField("SFDDJ", "SFDDJ", JdeDataType.Numeric),
        new JdeField("SFDSVJ", "SFDSVJ", JdeDataType.Numeric),
        new JdeField("SFCTRY", "SFCTRY", JdeDataType.Numeric),
        new JdeField("SFFY", "SFFY", JdeDataType.Numeric),
        new JdeField("SFPN", "SFPN", JdeDataType.Numeric),
        new JdeField("SFDOC", "SFDOC", JdeDataType.Numeric),
        new JdeField("SFICU", "SFICU", JdeDataType.Numeric),
        new JdeField("SFICUT", "SFICUT", JdeDataType.String, 4),
        new JdeField("SFDOCZ", "SFDOCZ", JdeDataType.Numeric),
        new JdeField("SFDCTI", "SFDCTI", JdeDataType.String, 4),
        new JdeField("SFKCOI", "SFKCOI", JdeDataType.String, 10),
        new JdeField("SFSFX", "SFSFX", JdeDataType.String, 6),
        new JdeField("SFTXA1", "SFTXA1", JdeDataType.String, 20),
        new JdeField("SFEXR1", "SFEXR1", JdeDataType.String, 4),
        new JdeField("SFPTC", "SFPTC", JdeDataType.String, 6),
        new JdeField("SFAG", "SFAG", JdeDataType.Numeric),
        new JdeField("SF74UNT", "SF74UNT", JdeDataType.Numeric),
        new JdeField("SFUKCEAM", "SFUKCEAM", JdeDataType.Numeric),
        new JdeField("SFATXA", "SFATXA", JdeDataType.Numeric),
        new JdeField("SF74UCVAT", "SF74UCVAT", JdeDataType.Numeric),
        new JdeField("SFADSC", "SFADSC", JdeDataType.Numeric),
        new JdeField("SFUKCEQT", "SFUKCEQT", JdeDataType.Numeric),
        new JdeField("SFUKCEPE", "SFUKCEPE", JdeDataType.Numeric),
        new JdeField("SF74UCG", "SF74UCG", JdeDataType.Numeric),
        new JdeField("SF74UCN", "SF74UCN", JdeDataType.Numeric),
        new JdeField("SFUKCECA", "SFUKCECA", JdeDataType.Numeric),
        new JdeField("SF74UCCVAT", "SF74UCCVAT", JdeDataType.Numeric),
        new JdeField("SFUKCECQ", "SFUKCECQ", JdeDataType.Numeric),
        new JdeField("SFUKCECP", "SFUKCECP", JdeDataType.Numeric),
        new JdeField("SFCRRM", "SFCRRM", JdeDataType.String, 2),
        new JdeField("SFCRCD", "SFCRCD", JdeDataType.String, 6),
        new JdeField("SFCRCF", "SFCRCF", JdeDataType.String, 6),
        new JdeField("SFCRR", "SFCRR", JdeDataType.Numeric),
        new JdeField("SFACR", "SFACR", JdeDataType.Numeric),
        new JdeField("SF74UFNT", "SF74UFNT", JdeDataType.Numeric),
        new JdeField("SFUKCEFA", "SFUKCEFA", JdeDataType.Numeric),
        new JdeField("SFCTXA", "SFCTXA", JdeDataType.Numeric),
        new JdeField("SF74UFVAT", "SF74UFVAT", JdeDataType.Numeric),
        new JdeField("SFCDS", "SFCDS", JdeDataType.Numeric),
        new JdeField("SF74UFCG", "SF74UFCG", JdeDataType.Numeric),
        new JdeField("SF74UFCN", "SF74UFCN", JdeDataType.Numeric),
        new JdeField("SFUKCEFC", "SFUKCEFC", JdeDataType.Numeric),
        new JdeField("SF74UFCVAT", "SF74UFCVAT", JdeDataType.Numeric),
        new JdeField("SF74UPRET", "SF74UPRET", JdeDataType.Numeric),
        new JdeField("SFRTNG", "SFRTNG", JdeDataType.Numeric),
        new JdeField("SF74UCR", "SF74UCR", JdeDataType.Numeric),
        new JdeField("SFFTNG", "SFFTNG", JdeDataType.Numeric),
        new JdeField("SF74UFCR", "SF74UFCR", JdeDataType.Numeric),
        new JdeField("SF74UMCDR", "SF74UMCDR", JdeDataType.Numeric),
        new JdeField("SF74UMCDA", "SF74UMCDA", JdeDataType.Numeric),
        new JdeField("SF74UMCDCA", "SF74UMCDCA", JdeDataType.Numeric),
        new JdeField("SF74UFMCDA", "SF74UFMCDA", JdeDataType.Numeric),
        new JdeField("SF74UFMCDC", "SF74UFMCDC", JdeDataType.Numeric),
        new JdeField("SFRMK", "SFRMK", JdeDataType.String, 60),
        new JdeField("SFUKCEPD", "SFUKCEPD", JdeDataType.Numeric),
        new JdeField("SF74UARP", "SF74UARP", JdeDataType.Numeric),
        new JdeField("SF74UARR", "SF74UARR", JdeDataType.Numeric),
        new JdeField("SF74UCCC1", "SF74UCCC1", JdeDataType.String, 6),
        new JdeField("SF74UCCC2", "SF74UCCC2", JdeDataType.String, 6),
        new JdeField("SF74UCCC3", "SF74UCCC3", JdeDataType.String, 20),
        new JdeField("SF74UCCC4", "SF74UCCC4", JdeDataType.String, 20),
        new JdeField("SF74UCCC5", "SF74UCCC5", JdeDataType.Numeric),
        new JdeField("SFURAT", "SFURAT", JdeDataType.Numeric),
        new JdeField("SFURCD", "SFURCD", JdeDataType.String, 4),
        new JdeField("SFURDT", "SFURDT", JdeDataType.Numeric),
        new JdeField("SFURAB", "SFURAB", JdeDataType.Numeric),
        new JdeField("SFURRF", "SFURRF", JdeDataType.String, 30),
        new JdeField("SFPID", "SFPID", JdeDataType.String, 20),
        new JdeField("SFJOBN", "SFJOBN", JdeDataType.String, 20),
        new JdeField("SFUSER", "SFUSER", JdeDataType.String, 20),
        new JdeField("SFUPMJ", "SFUPMJ", JdeDataType.Numeric),
        new JdeField("SFUPMT", "SFUPMT", JdeDataType.Numeric),
        new JdeField("SFOMCU", "SFOMCU", JdeDataType.String, 24),
        new JdeField("SFANI", "SFANI", JdeDataType.String, 58),
        new JdeField("SFAID", "SFAID", JdeDataType.String, 16),
        new JdeField("SFNLIN", "SFNLIN", JdeDataType.Numeric),
        new JdeField("SF74UPLAD", "SF74UPLAD", JdeDataType.Numeric),
        new JdeField("SF74UPMAD", "SF74UPMAD", JdeDataType.Numeric),
        new JdeField("SF74UPLAF", "SF74UPLAF", JdeDataType.Numeric),
        new JdeField("SF74UPMAF", "SF74UPMAF", JdeDataType.Numeric),
        new JdeField("SF74ULMSP", "SF74ULMSP", JdeDataType.Numeric),
        new JdeField("SF74UMLMS", "SF74UMLMS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0425_0", "Primary Key on SFUKCENM, SFDOCO, SFDCTO, SFKCOO, SFSFXO, SF74UCLN, SFMATC", new[] { "SFUKCENM", "SFDOCO", "SFDCTO", "SFKCOO", "SFSFXO", "SF74UCLN", "SFMATC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0425_3", "Index on SFDOCO, SFDCTO, SFKCOO, SFSFXO", new[] { "SFDOCO", "SFDCTO", "SFKCOO", "SFSFXO" }),
        new JdeIndex("F74U0425_4", "Index on SFKCOO, SFDOCO, SFDCTO, SFUKCENM, SF74UCLN", new[] { "SFKCOO", "SFDOCO", "SFDCTO", "SFUKCENM", "SF74UCLN" }),
        new JdeIndex("F74U0425_5", "Index on SFUKCENM, SFDOCO, SFDCTO, SFKCOO, SFSFXO, SF74UCLN", new[] { "SFUKCENM", "SFDOCO", "SFDCTO", "SFKCOO", "SFSFXO", "SF74UCLN" })
    };
}
