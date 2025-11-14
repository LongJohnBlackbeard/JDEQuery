using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0405 - .
/// </summary>
public class F74U0405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHDOCO.
        /// </summary>
        public const string CHDOCO = "CHDOCO";

        /// <summary>
        /// CHDCTO.
        /// </summary>
        public const string CHDCTO = "CHDCTO";

        /// <summary>
        /// CHKCOO.
        /// </summary>
        public const string CHKCOO = "CHKCOO";

        /// <summary>
        /// CHUKCENM.
        /// </summary>
        public const string CHUKCENM = "CHUKCENM";

        /// <summary>
        /// CHSFXO.
        /// </summary>
        public const string CHSFXO = "CHSFXO";

        /// <summary>
        /// CHLNID.
        /// </summary>
        public const string CHLNID = "CHLNID";

        /// <summary>
        /// CHUKCEDT.
        /// </summary>
        public const string CHUKCEDT = "CHUKCEDT";

        /// <summary>
        /// CHDGL.
        /// </summary>
        public const string CHDGL = "CHDGL";

        /// <summary>
        /// CHDSVJ.
        /// </summary>
        public const string CHDSVJ = "CHDSVJ";

        /// <summary>
        /// CHDDJ.
        /// </summary>
        public const string CHDDJ = "CHDDJ";

        /// <summary>
        /// CHUKAPNM.
        /// </summary>
        public const string CHUKAPNM = "CHUKAPNM";

        /// <summary>
        /// CH74UACR.
        /// </summary>
        public const string CH74UACR = "CH74UACR";

        /// <summary>
        /// CHRMK.
        /// </summary>
        public const string CHRMK = "CHRMK";

        /// <summary>
        /// CHPTC.
        /// </summary>
        public const string CHPTC = "CHPTC";

        /// <summary>
        /// CHCRCF.
        /// </summary>
        public const string CHCRCF = "CHCRCF";

        /// <summary>
        /// CHCRR.
        /// </summary>
        public const string CHCRR = "CHCRR";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHCO.
        /// </summary>
        public const string CHCO = "CHCO";

        /// <summary>
        /// CHUKCEAM.
        /// </summary>
        public const string CHUKCEAM = "CHUKCEAM";

        /// <summary>
        /// CHUKCEQT.
        /// </summary>
        public const string CHUKCEQT = "CHUKCEQT";

        /// <summary>
        /// CHUKCEPE.
        /// </summary>
        public const string CHUKCEPE = "CHUKCEPE";

        /// <summary>
        /// CHRTNG.
        /// </summary>
        public const string CHRTNG = "CHRTNG";

        /// <summary>
        /// CH74UPRET.
        /// </summary>
        public const string CH74UPRET = "CH74UPRET";

        /// <summary>
        /// CH74UMCDA.
        /// </summary>
        public const string CH74UMCDA = "CH74UMCDA";

        /// <summary>
        /// CH74UMCDR.
        /// </summary>
        public const string CH74UMCDR = "CH74UMCDR";

        /// <summary>
        /// CH74UNT.
        /// </summary>
        public const string CH74UNT = "CH74UNT";

        /// <summary>
        /// CH74UCVAT.
        /// </summary>
        public const string CH74UCVAT = "CH74UCVAT";

        /// <summary>
        /// CHAG.
        /// </summary>
        public const string CHAG = "CHAG";

        /// <summary>
        /// CH74UPLAD.
        /// </summary>
        public const string CH74UPLAD = "CH74UPLAD";

        /// <summary>
        /// CH74UPMAD.
        /// </summary>
        public const string CH74UPMAD = "CH74UPMAD";

        /// <summary>
        /// CH74ULMSP.
        /// </summary>
        public const string CH74ULMSP = "CH74ULMSP";

        /// <summary>
        /// CHUKCECA.
        /// </summary>
        public const string CHUKCECA = "CHUKCECA";

        /// <summary>
        /// CHUKCECQ.
        /// </summary>
        public const string CHUKCECQ = "CHUKCECQ";

        /// <summary>
        /// CHUKCECP.
        /// </summary>
        public const string CHUKCECP = "CHUKCECP";

        /// <summary>
        /// CH74UCR.
        /// </summary>
        public const string CH74UCR = "CH74UCR";

        /// <summary>
        /// CH74UMCDCA.
        /// </summary>
        public const string CH74UMCDCA = "CH74UMCDCA";

        /// <summary>
        /// CH74UCN.
        /// </summary>
        public const string CH74UCN = "CH74UCN";

        /// <summary>
        /// CH74UCCVAT.
        /// </summary>
        public const string CH74UCCVAT = "CH74UCCVAT";

        /// <summary>
        /// CH74UCG.
        /// </summary>
        public const string CH74UCG = "CH74UCG";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHTXA1.
        /// </summary>
        public const string CHTXA1 = "CHTXA1";

        /// <summary>
        /// CHEXR1.
        /// </summary>
        public const string CHEXR1 = "CHEXR1";

        /// <summary>
        /// CH74UCCC5.
        /// </summary>
        public const string CH74UCCC5 = "CH74UCCC5";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHDOCO", "CHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDCTO", "CHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CHKCOO", "CHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CHUKCENM", "CHUKCENM", JdeDataType.Numeric, null, true, true),
        new JdeField("CHSFXO", "CHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CHLNID", "CHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHUKCEDT", "CHUKCEDT", JdeDataType.Numeric),
        new JdeField("CHDGL", "CHDGL", JdeDataType.Numeric),
        new JdeField("CHDSVJ", "CHDSVJ", JdeDataType.Numeric),
        new JdeField("CHDDJ", "CHDDJ", JdeDataType.Numeric),
        new JdeField("CHUKAPNM", "CHUKAPNM", JdeDataType.Numeric),
        new JdeField("CH74UACR", "CH74UACR", JdeDataType.String, 30),
        new JdeField("CHRMK", "CHRMK", JdeDataType.String, 60),
        new JdeField("CHPTC", "CHPTC", JdeDataType.String, 6),
        new JdeField("CHCRCF", "CHCRCF", JdeDataType.String, 6),
        new JdeField("CHCRR", "CHCRR", JdeDataType.Numeric),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHCO", "CHCO", JdeDataType.String, 10),
        new JdeField("CHUKCEAM", "CHUKCEAM", JdeDataType.Numeric),
        new JdeField("CHUKCEQT", "CHUKCEQT", JdeDataType.Numeric),
        new JdeField("CHUKCEPE", "CHUKCEPE", JdeDataType.Numeric),
        new JdeField("CHRTNG", "CHRTNG", JdeDataType.Numeric),
        new JdeField("CH74UPRET", "CH74UPRET", JdeDataType.Numeric),
        new JdeField("CH74UMCDA", "CH74UMCDA", JdeDataType.Numeric),
        new JdeField("CH74UMCDR", "CH74UMCDR", JdeDataType.Numeric),
        new JdeField("CH74UNT", "CH74UNT", JdeDataType.Numeric),
        new JdeField("CH74UCVAT", "CH74UCVAT", JdeDataType.Numeric),
        new JdeField("CHAG", "CHAG", JdeDataType.Numeric),
        new JdeField("CH74UPLAD", "CH74UPLAD", JdeDataType.Numeric),
        new JdeField("CH74UPMAD", "CH74UPMAD", JdeDataType.Numeric),
        new JdeField("CH74ULMSP", "CH74ULMSP", JdeDataType.Numeric),
        new JdeField("CHUKCECA", "CHUKCECA", JdeDataType.Numeric),
        new JdeField("CHUKCECQ", "CHUKCECQ", JdeDataType.Numeric),
        new JdeField("CHUKCECP", "CHUKCECP", JdeDataType.Numeric),
        new JdeField("CH74UCR", "CH74UCR", JdeDataType.Numeric),
        new JdeField("CH74UMCDCA", "CH74UMCDCA", JdeDataType.Numeric),
        new JdeField("CH74UCN", "CH74UCN", JdeDataType.Numeric),
        new JdeField("CH74UCCVAT", "CH74UCCVAT", JdeDataType.Numeric),
        new JdeField("CH74UCG", "CH74UCG", JdeDataType.Numeric),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHTXA1", "CHTXA1", JdeDataType.String, 20),
        new JdeField("CHEXR1", "CHEXR1", JdeDataType.String, 4),
        new JdeField("CH74UCCC5", "CH74UCCC5", JdeDataType.Numeric),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0405_0", "Primary Key on CHDOCO, CHDCTO, CHKCOO, CHUKCENM, CHSFXO, CHLNID", new[] { "CHDOCO", "CHDCTO", "CHKCOO", "CHUKCENM", "CHSFXO", "CHLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
