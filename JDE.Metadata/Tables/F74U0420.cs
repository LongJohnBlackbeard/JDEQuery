using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0420 - .
/// </summary>
public class F74U0420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEUKAPNM.
        /// </summary>
        public const string SEUKAPNM = "SEUKAPNM";

        /// <summary>
        /// SEUKAPDT.
        /// </summary>
        public const string SEUKAPDT = "SEUKAPDT";

        /// <summary>
        /// SEUKAPRF.
        /// </summary>
        public const string SEUKAPRF = "SEUKAPRF";

        /// <summary>
        /// SEDOCO.
        /// </summary>
        public const string SEDOCO = "SEDOCO";

        /// <summary>
        /// SEDCTO.
        /// </summary>
        public const string SEDCTO = "SEDCTO";

        /// <summary>
        /// SEKCOO.
        /// </summary>
        public const string SEKCOO = "SEKCOO";

        /// <summary>
        /// SESFXO.
        /// </summary>
        public const string SESFXO = "SESFXO";

        /// <summary>
        /// SE74UALN.
        /// </summary>
        public const string SE74UALN = "SE74UALN";

        /// <summary>
        /// SELNID.
        /// </summary>
        public const string SELNID = "SELNID";

        /// <summary>
        /// SEUKCENM.
        /// </summary>
        public const string SEUKCENM = "SEUKCENM";

        /// <summary>
        /// SE74UCLN.
        /// </summary>
        public const string SE74UCLN = "SE74UCLN";

        /// <summary>
        /// SE74USPCS.
        /// </summary>
        public const string SE74USPCS = "SE74USPCS";

        /// <summary>
        /// SEAN8.
        /// </summary>
        public const string SEAN8 = "SEAN8";

        /// <summary>
        /// SECO.
        /// </summary>
        public const string SECO = "SECO";

        /// <summary>
        /// SEMCU.
        /// </summary>
        public const string SEMCU = "SEMCU";

        /// <summary>
        /// SEOBJ.
        /// </summary>
        public const string SEOBJ = "SEOBJ";

        /// <summary>
        /// SESUB.
        /// </summary>
        public const string SESUB = "SESUB";

        /// <summary>
        /// SESBL.
        /// </summary>
        public const string SESBL = "SESBL";

        /// <summary>
        /// SESBLT.
        /// </summary>
        public const string SESBLT = "SESBLT";

        /// <summary>
        /// SEGLC.
        /// </summary>
        public const string SEGLC = "SEGLC";

        /// <summary>
        /// SEDGL.
        /// </summary>
        public const string SEDGL = "SEDGL";

        /// <summary>
        /// SEDDJ.
        /// </summary>
        public const string SEDDJ = "SEDDJ";

        /// <summary>
        /// SEDSVJ.
        /// </summary>
        public const string SEDSVJ = "SEDSVJ";

        /// <summary>
        /// SECTRY.
        /// </summary>
        public const string SECTRY = "SECTRY";

        /// <summary>
        /// SEFY.
        /// </summary>
        public const string SEFY = "SEFY";

        /// <summary>
        /// SEPN.
        /// </summary>
        public const string SEPN = "SEPN";

        /// <summary>
        /// SEICU.
        /// </summary>
        public const string SEICU = "SEICU";

        /// <summary>
        /// SEICUT.
        /// </summary>
        public const string SEICUT = "SEICUT";

        /// <summary>
        /// SEDOCZ.
        /// </summary>
        public const string SEDOCZ = "SEDOCZ";

        /// <summary>
        /// SEDCTI.
        /// </summary>
        public const string SEDCTI = "SEDCTI";

        /// <summary>
        /// SEKCOI.
        /// </summary>
        public const string SEKCOI = "SEKCOI";

        /// <summary>
        /// SESFX.
        /// </summary>
        public const string SESFX = "SESFX";

        /// <summary>
        /// SETXA1.
        /// </summary>
        public const string SETXA1 = "SETXA1";

        /// <summary>
        /// SEEXR1.
        /// </summary>
        public const string SEEXR1 = "SEEXR1";

        /// <summary>
        /// SEPTC.
        /// </summary>
        public const string SEPTC = "SEPTC";

        /// <summary>
        /// SEAG.
        /// </summary>
        public const string SEAG = "SEAG";

        /// <summary>
        /// SE74UNT.
        /// </summary>
        public const string SE74UNT = "SE74UNT";

        /// <summary>
        /// SEUKAPAM.
        /// </summary>
        public const string SEUKAPAM = "SEUKAPAM";

        /// <summary>
        /// SEATXA.
        /// </summary>
        public const string SEATXA = "SEATXA";

        /// <summary>
        /// SE74UAVAT.
        /// </summary>
        public const string SE74UAVAT = "SE74UAVAT";

        /// <summary>
        /// SEADSC.
        /// </summary>
        public const string SEADSC = "SEADSC";

        /// <summary>
        /// SEUKAPQT.
        /// </summary>
        public const string SEUKAPQT = "SEUKAPQT";

        /// <summary>
        /// SEUKAPPE.
        /// </summary>
        public const string SEUKAPPE = "SEUKAPPE";

        /// <summary>
        /// SE74UCG.
        /// </summary>
        public const string SE74UCG = "SE74UCG";

        /// <summary>
        /// SE74UCN.
        /// </summary>
        public const string SE74UCN = "SE74UCN";

        /// <summary>
        /// SEUKAPCA.
        /// </summary>
        public const string SEUKAPCA = "SEUKAPCA";

        /// <summary>
        /// SE74UACVAT.
        /// </summary>
        public const string SE74UACVAT = "SE74UACVAT";

        /// <summary>
        /// SEUKAPCQ.
        /// </summary>
        public const string SEUKAPCQ = "SEUKAPCQ";

        /// <summary>
        /// SEUKAPCP.
        /// </summary>
        public const string SEUKAPCP = "SEUKAPCP";

        /// <summary>
        /// SECRRM.
        /// </summary>
        public const string SECRRM = "SECRRM";

        /// <summary>
        /// SECRCD.
        /// </summary>
        public const string SECRCD = "SECRCD";

        /// <summary>
        /// SECRCF.
        /// </summary>
        public const string SECRCF = "SECRCF";

        /// <summary>
        /// SECRR.
        /// </summary>
        public const string SECRR = "SECRR";

        /// <summary>
        /// SEACR.
        /// </summary>
        public const string SEACR = "SEACR";

        /// <summary>
        /// SE74UFNT.
        /// </summary>
        public const string SE74UFNT = "SE74UFNT";

        /// <summary>
        /// SEUKAPFA.
        /// </summary>
        public const string SEUKAPFA = "SEUKAPFA";

        /// <summary>
        /// SECTXA.
        /// </summary>
        public const string SECTXA = "SECTXA";

        /// <summary>
        /// SE74UFAVAT.
        /// </summary>
        public const string SE74UFAVAT = "SE74UFAVAT";

        /// <summary>
        /// SECDS.
        /// </summary>
        public const string SECDS = "SECDS";

        /// <summary>
        /// SE74UFCG.
        /// </summary>
        public const string SE74UFCG = "SE74UFCG";

        /// <summary>
        /// SE74UFCN.
        /// </summary>
        public const string SE74UFCN = "SE74UFCN";

        /// <summary>
        /// SEUKAPFC.
        /// </summary>
        public const string SEUKAPFC = "SEUKAPFC";

        /// <summary>
        /// SE74UFCAV.
        /// </summary>
        public const string SE74UFCAV = "SE74UFCAV";

        /// <summary>
        /// SE74UPRET.
        /// </summary>
        public const string SE74UPRET = "SE74UPRET";

        /// <summary>
        /// SERTNG.
        /// </summary>
        public const string SERTNG = "SERTNG";

        /// <summary>
        /// SE74UCR.
        /// </summary>
        public const string SE74UCR = "SE74UCR";

        /// <summary>
        /// SEFTNG.
        /// </summary>
        public const string SEFTNG = "SEFTNG";

        /// <summary>
        /// SE74UFCR.
        /// </summary>
        public const string SE74UFCR = "SE74UFCR";

        /// <summary>
        /// SE74UMCDR.
        /// </summary>
        public const string SE74UMCDR = "SE74UMCDR";

        /// <summary>
        /// SE74UMCDA.
        /// </summary>
        public const string SE74UMCDA = "SE74UMCDA";

        /// <summary>
        /// SE74UMCDCA.
        /// </summary>
        public const string SE74UMCDCA = "SE74UMCDCA";

        /// <summary>
        /// SE74UFMCDA.
        /// </summary>
        public const string SE74UFMCDA = "SE74UFMCDA";

        /// <summary>
        /// SE74UFMCDC.
        /// </summary>
        public const string SE74UFMCDC = "SE74UFMCDC";

        /// <summary>
        /// SERMK.
        /// </summary>
        public const string SERMK = "SERMK";

        /// <summary>
        /// SEUKURRF.
        /// </summary>
        public const string SEUKURRF = "SEUKURRF";

        /// <summary>
        /// SEUKURDT.
        /// </summary>
        public const string SEUKURDT = "SEUKURDT";

        /// <summary>
        /// SE74UACC1.
        /// </summary>
        public const string SE74UACC1 = "SE74UACC1";

        /// <summary>
        /// SE74UACC2.
        /// </summary>
        public const string SE74UACC2 = "SE74UACC2";

        /// <summary>
        /// SE74UACC3.
        /// </summary>
        public const string SE74UACC3 = "SE74UACC3";

        /// <summary>
        /// SE74UACC4.
        /// </summary>
        public const string SE74UACC4 = "SE74UACC4";

        /// <summary>
        /// SE74UACC5.
        /// </summary>
        public const string SE74UACC5 = "SE74UACC5";

        /// <summary>
        /// SEURAT.
        /// </summary>
        public const string SEURAT = "SEURAT";

        /// <summary>
        /// SEURCD.
        /// </summary>
        public const string SEURCD = "SEURCD";

        /// <summary>
        /// SEURDT.
        /// </summary>
        public const string SEURDT = "SEURDT";

        /// <summary>
        /// SEURAB.
        /// </summary>
        public const string SEURAB = "SEURAB";

        /// <summary>
        /// SEURRF.
        /// </summary>
        public const string SEURRF = "SEURRF";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEUPMJ.
        /// </summary>
        public const string SEUPMJ = "SEUPMJ";

        /// <summary>
        /// SEUPMT.
        /// </summary>
        public const string SEUPMT = "SEUPMT";

        /// <summary>
        /// SEOMCU.
        /// </summary>
        public const string SEOMCU = "SEOMCU";

        /// <summary>
        /// SEAID.
        /// </summary>
        public const string SEAID = "SEAID";

        /// <summary>
        /// SEANI.
        /// </summary>
        public const string SEANI = "SEANI";

        /// <summary>
        /// SE74UPLAD.
        /// </summary>
        public const string SE74UPLAD = "SE74UPLAD";

        /// <summary>
        /// SE74UPMAD.
        /// </summary>
        public const string SE74UPMAD = "SE74UPMAD";

        /// <summary>
        /// SE74UPLAF.
        /// </summary>
        public const string SE74UPLAF = "SE74UPLAF";

        /// <summary>
        /// SE74UPMAF.
        /// </summary>
        public const string SE74UPMAF = "SE74UPMAF";

        /// <summary>
        /// SE74ULMSP.
        /// </summary>
        public const string SE74ULMSP = "SE74ULMSP";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEUKAPNM", "SEUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("SEUKAPDT", "SEUKAPDT", JdeDataType.Numeric),
        new JdeField("SEUKAPRF", "SEUKAPRF", JdeDataType.String, 60),
        new JdeField("SEDOCO", "SEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SEDCTO", "SEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SEKCOO", "SEKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SESFXO", "SESFXO", JdeDataType.String, 6, true, true),
        new JdeField("SE74UALN", "SE74UALN", JdeDataType.Numeric, null, true, true),
        new JdeField("SELNID", "SELNID", JdeDataType.Numeric),
        new JdeField("SEUKCENM", "SEUKCENM", JdeDataType.Numeric),
        new JdeField("SE74UCLN", "SE74UCLN", JdeDataType.Numeric),
        new JdeField("SE74USPCS", "SE74USPCS", JdeDataType.String, 6),
        new JdeField("SEAN8", "SEAN8", JdeDataType.Numeric),
        new JdeField("SECO", "SECO", JdeDataType.String, 10),
        new JdeField("SEMCU", "SEMCU", JdeDataType.String, 24),
        new JdeField("SEOBJ", "SEOBJ", JdeDataType.String, 12),
        new JdeField("SESUB", "SESUB", JdeDataType.String, 16),
        new JdeField("SESBL", "SESBL", JdeDataType.String, 16),
        new JdeField("SESBLT", "SESBLT", JdeDataType.String, 2),
        new JdeField("SEGLC", "SEGLC", JdeDataType.String, 8),
        new JdeField("SEDGL", "SEDGL", JdeDataType.Numeric),
        new JdeField("SEDDJ", "SEDDJ", JdeDataType.Numeric),
        new JdeField("SEDSVJ", "SEDSVJ", JdeDataType.Numeric),
        new JdeField("SECTRY", "SECTRY", JdeDataType.Numeric),
        new JdeField("SEFY", "SEFY", JdeDataType.Numeric),
        new JdeField("SEPN", "SEPN", JdeDataType.Numeric),
        new JdeField("SEICU", "SEICU", JdeDataType.Numeric),
        new JdeField("SEICUT", "SEICUT", JdeDataType.String, 4),
        new JdeField("SEDOCZ", "SEDOCZ", JdeDataType.Numeric),
        new JdeField("SEDCTI", "SEDCTI", JdeDataType.String, 4),
        new JdeField("SEKCOI", "SEKCOI", JdeDataType.String, 10),
        new JdeField("SESFX", "SESFX", JdeDataType.String, 6),
        new JdeField("SETXA1", "SETXA1", JdeDataType.String, 20),
        new JdeField("SEEXR1", "SEEXR1", JdeDataType.String, 4),
        new JdeField("SEPTC", "SEPTC", JdeDataType.String, 6),
        new JdeField("SEAG", "SEAG", JdeDataType.Numeric),
        new JdeField("SE74UNT", "SE74UNT", JdeDataType.Numeric),
        new JdeField("SEUKAPAM", "SEUKAPAM", JdeDataType.Numeric),
        new JdeField("SEATXA", "SEATXA", JdeDataType.Numeric),
        new JdeField("SE74UAVAT", "SE74UAVAT", JdeDataType.Numeric),
        new JdeField("SEADSC", "SEADSC", JdeDataType.Numeric),
        new JdeField("SEUKAPQT", "SEUKAPQT", JdeDataType.Numeric),
        new JdeField("SEUKAPPE", "SEUKAPPE", JdeDataType.Numeric),
        new JdeField("SE74UCG", "SE74UCG", JdeDataType.Numeric),
        new JdeField("SE74UCN", "SE74UCN", JdeDataType.Numeric),
        new JdeField("SEUKAPCA", "SEUKAPCA", JdeDataType.Numeric),
        new JdeField("SE74UACVAT", "SE74UACVAT", JdeDataType.Numeric),
        new JdeField("SEUKAPCQ", "SEUKAPCQ", JdeDataType.Numeric),
        new JdeField("SEUKAPCP", "SEUKAPCP", JdeDataType.Numeric),
        new JdeField("SECRRM", "SECRRM", JdeDataType.String, 2),
        new JdeField("SECRCD", "SECRCD", JdeDataType.String, 6),
        new JdeField("SECRCF", "SECRCF", JdeDataType.String, 6),
        new JdeField("SECRR", "SECRR", JdeDataType.Numeric),
        new JdeField("SEACR", "SEACR", JdeDataType.Numeric),
        new JdeField("SE74UFNT", "SE74UFNT", JdeDataType.Numeric),
        new JdeField("SEUKAPFA", "SEUKAPFA", JdeDataType.Numeric),
        new JdeField("SECTXA", "SECTXA", JdeDataType.Numeric),
        new JdeField("SE74UFAVAT", "SE74UFAVAT", JdeDataType.Numeric),
        new JdeField("SECDS", "SECDS", JdeDataType.Numeric),
        new JdeField("SE74UFCG", "SE74UFCG", JdeDataType.Numeric),
        new JdeField("SE74UFCN", "SE74UFCN", JdeDataType.Numeric),
        new JdeField("SEUKAPFC", "SEUKAPFC", JdeDataType.Numeric),
        new JdeField("SE74UFCAV", "SE74UFCAV", JdeDataType.Numeric),
        new JdeField("SE74UPRET", "SE74UPRET", JdeDataType.Numeric),
        new JdeField("SERTNG", "SERTNG", JdeDataType.Numeric),
        new JdeField("SE74UCR", "SE74UCR", JdeDataType.Numeric),
        new JdeField("SEFTNG", "SEFTNG", JdeDataType.Numeric),
        new JdeField("SE74UFCR", "SE74UFCR", JdeDataType.Numeric),
        new JdeField("SE74UMCDR", "SE74UMCDR", JdeDataType.Numeric),
        new JdeField("SE74UMCDA", "SE74UMCDA", JdeDataType.Numeric),
        new JdeField("SE74UMCDCA", "SE74UMCDCA", JdeDataType.Numeric),
        new JdeField("SE74UFMCDA", "SE74UFMCDA", JdeDataType.Numeric),
        new JdeField("SE74UFMCDC", "SE74UFMCDC", JdeDataType.Numeric),
        new JdeField("SERMK", "SERMK", JdeDataType.String, 60),
        new JdeField("SEUKURRF", "SEUKURRF", JdeDataType.String, 30),
        new JdeField("SEUKURDT", "SEUKURDT", JdeDataType.Numeric),
        new JdeField("SE74UACC1", "SE74UACC1", JdeDataType.String, 6),
        new JdeField("SE74UACC2", "SE74UACC2", JdeDataType.String, 6),
        new JdeField("SE74UACC3", "SE74UACC3", JdeDataType.String, 20),
        new JdeField("SE74UACC4", "SE74UACC4", JdeDataType.String, 20),
        new JdeField("SE74UACC5", "SE74UACC5", JdeDataType.Numeric),
        new JdeField("SEURAT", "SEURAT", JdeDataType.Numeric),
        new JdeField("SEURCD", "SEURCD", JdeDataType.String, 4),
        new JdeField("SEURDT", "SEURDT", JdeDataType.Numeric),
        new JdeField("SEURAB", "SEURAB", JdeDataType.Numeric),
        new JdeField("SEURRF", "SEURRF", JdeDataType.String, 30),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric),
        new JdeField("SEOMCU", "SEOMCU", JdeDataType.String, 24),
        new JdeField("SEAID", "SEAID", JdeDataType.String, 16),
        new JdeField("SEANI", "SEANI", JdeDataType.String, 58),
        new JdeField("SE74UPLAD", "SE74UPLAD", JdeDataType.Numeric),
        new JdeField("SE74UPMAD", "SE74UPMAD", JdeDataType.Numeric),
        new JdeField("SE74UPLAF", "SE74UPLAF", JdeDataType.Numeric),
        new JdeField("SE74UPMAF", "SE74UPMAF", JdeDataType.Numeric),
        new JdeField("SE74ULMSP", "SE74ULMSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0420_0", "Primary Key on SEUKAPNM, SEDOCO, SEDCTO, SEKCOO, SESFXO, SE74UALN", new[] { "SEUKAPNM", "SEDOCO", "SEDCTO", "SEKCOO", "SESFXO", "SE74UALN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0420_2", "Index on SEKCOO, SEDOCO, SEDCTO, SEUKAPNM, SE74UALN", new[] { "SEKCOO", "SEDOCO", "SEDCTO", "SEUKAPNM", "SE74UALN" }),
        new JdeIndex("F74U0420_3", "Index on SEUKAPNM, SEDOCO, SEDCTO, SEKCOO, SESFXO, SELNID", new[] { "SEUKAPNM", "SEDOCO", "SEDCTO", "SEKCOO", "SESFXO", "SELNID" }),
        new JdeIndex("F74U0420_4", "Index on SEMCU", new[] { "SEMCU" })
    };
}
