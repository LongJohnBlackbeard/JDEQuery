using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I380 - .
/// </summary>
public class F75I380 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGYRM.
        /// </summary>
        public const string RGYRM = "RGYRM";

        /// <summary>
        /// RGMT.
        /// </summary>
        public const string RGMT = "RGMT";

        /// <summary>
        /// RGYEXU.
        /// </summary>
        public const string RGYEXU = "RGYEXU";

        /// <summary>
        /// RGMCU.
        /// </summary>
        public const string RGMCU = "RGMCU";

        /// <summary>
        /// RGITM.
        /// </summary>
        public const string RGITM = "RGITM";

        /// <summary>
        /// RGLITM.
        /// </summary>
        public const string RGLITM = "RGLITM";

        /// <summary>
        /// RGOLND.
        /// </summary>
        public const string RGOLND = "RGOLND";

        /// <summary>
        /// RGBPFG.
        /// </summary>
        public const string RGBPFG = "RGBPFG";

        /// <summary>
        /// RGYCHN.
        /// </summary>
        public const string RGYCHN = "RGYCHN";

        /// <summary>
        /// RGTRDJ.
        /// </summary>
        public const string RGTRDJ = "RGTRDJ";

        /// <summary>
        /// RGCLM1.
        /// </summary>
        public const string RGCLM1 = "RGCLM1";

        /// <summary>
        /// RGCLM2.
        /// </summary>
        public const string RGCLM2 = "RGCLM2";

        /// <summary>
        /// RGKCOO.
        /// </summary>
        public const string RGKCOO = "RGKCOO";

        /// <summary>
        /// RGDOCO.
        /// </summary>
        public const string RGDOCO = "RGDOCO";

        /// <summary>
        /// RGDCTO.
        /// </summary>
        public const string RGDCTO = "RGDCTO";

        /// <summary>
        /// RGKCO.
        /// </summary>
        public const string RGKCO = "RGKCO";

        /// <summary>
        /// RGDOC.
        /// </summary>
        public const string RGDOC = "RGDOC";

        /// <summary>
        /// RGDCT.
        /// </summary>
        public const string RGDCT = "RGDCT";

        /// <summary>
        /// RGODOC.
        /// </summary>
        public const string RGODOC = "RGODOC";

        /// <summary>
        /// RGODCT.
        /// </summary>
        public const string RGODCT = "RGODCT";

        /// <summary>
        /// RGLNID.
        /// </summary>
        public const string RGLNID = "RGLNID";

        /// <summary>
        /// RGNLIN.
        /// </summary>
        public const string RGNLIN = "RGNLIN";

        /// <summary>
        /// RGTKID.
        /// </summary>
        public const string RGTKID = "RGTKID";

        /// <summary>
        /// RGLOCN.
        /// </summary>
        public const string RGLOCN = "RGLOCN";

        /// <summary>
        /// RGLOTN.
        /// </summary>
        public const string RGLOTN = "RGLOTN";

        /// <summary>
        /// RGTRQT.
        /// </summary>
        public const string RGTRQT = "RGTRQT";

        /// <summary>
        /// RGTRUM.
        /// </summary>
        public const string RGTRUM = "RGTRUM";

        /// <summary>
        /// RGSTOK.
        /// </summary>
        public const string RGSTOK = "RGSTOK";

        /// <summary>
        /// RGUVM1.
        /// </summary>
        public const string RGUVM1 = "RGUVM1";

        /// <summary>
        /// RGAMBI.
        /// </summary>
        public const string RGAMBI = "RGAMBI";

        /// <summary>
        /// RGAMBU.
        /// </summary>
        public const string RGAMBU = "RGAMBU";

        /// <summary>
        /// RGWGTR.
        /// </summary>
        public const string RGWGTR = "RGWGTR";

        /// <summary>
        /// RGUWUM.
        /// </summary>
        public const string RGUWUM = "RGUWUM";

        /// <summary>
        /// RGPRFR.
        /// </summary>
        public const string RGPRFR = "RGPRFR";

        /// <summary>
        /// RGUMGP.
        /// </summary>
        public const string RGUMGP = "RGUMGP";

        /// <summary>
        /// RGAQTY.
        /// </summary>
        public const string RGAQTY = "RGAQTY";

        /// <summary>
        /// RGASVL.
        /// </summary>
        public const string RGASVL = "RGASVL";

        /// <summary>
        /// RGYTDU.
        /// </summary>
        public const string RGYTDU = "RGYTDU";

        /// <summary>
        /// RGDTYS.
        /// </summary>
        public const string RGDTYS = "RGDTYS";

        /// <summary>
        /// RGFLAG.
        /// </summary>
        public const string RGFLAG = "RGFLAG";

        /// <summary>
        /// RGASID.
        /// </summary>
        public const string RGASID = "RGASID";

        /// <summary>
        /// RGUFLG.
        /// </summary>
        public const string RGUFLG = "RGUFLG";

        /// <summary>
        /// RGYETT.
        /// </summary>
        public const string RGYETT = "RGYETT";

        /// <summary>
        /// RGYMDR.
        /// </summary>
        public const string RGYMDR = "RGYMDR";

        /// <summary>
        /// RGYCDR.
        /// </summary>
        public const string RGYCDR = "RGYCDR";

        /// <summary>
        /// RGYPDR.
        /// </summary>
        public const string RGYPDR = "RGYPDR";

        /// <summary>
        /// RGQTY1.
        /// </summary>
        public const string RGQTY1 = "RGQTY1";

        /// <summary>
        /// RGQTY2.
        /// </summary>
        public const string RGQTY2 = "RGQTY2";

        /// <summary>
        /// RGCRCD.
        /// </summary>
        public const string RGCRCD = "RGCRCD";

        /// <summary>
        /// RGCRDC.
        /// </summary>
        public const string RGCRDC = "RGCRDC";

        /// <summary>
        /// RGYUTD.
        /// </summary>
        public const string RGYUTD = "RGYUTD";

        /// <summary>
        /// RGLFDJ.
        /// </summary>
        public const string RGLFDJ = "RGLFDJ";

        /// <summary>
        /// RGPSDJ.
        /// </summary>
        public const string RGPSDJ = "RGPSDJ";

        /// <summary>
        /// RGDT.
        /// </summary>
        public const string RGDT = "RGDT";

        /// <summary>
        /// RGDT1.
        /// </summary>
        public const string RGDT1 = "RGDT1";

        /// <summary>
        /// RGF1A.
        /// </summary>
        public const string RGF1A = "RGF1A";

        /// <summary>
        /// RGF2A.
        /// </summary>
        public const string RGF2A = "RGF2A";

        /// <summary>
        /// RGF3A.
        /// </summary>
        public const string RGF3A = "RGF3A";

        /// <summary>
        /// RGF4A.
        /// </summary>
        public const string RGF4A = "RGF4A";

        /// <summary>
        /// RGC1FU.
        /// </summary>
        public const string RGC1FU = "RGC1FU";

        /// <summary>
        /// RGC2FU.
        /// </summary>
        public const string RGC2FU = "RGC2FU";

        /// <summary>
        /// RGOPT.
        /// </summary>
        public const string RGOPT = "RGOPT";

        /// <summary>
        /// RGF1T.
        /// </summary>
        public const string RGF1T = "RGF1T";

        /// <summary>
        /// RGF2T.
        /// </summary>
        public const string RGF2T = "RGF2T";

        /// <summary>
        /// RGF3T.
        /// </summary>
        public const string RGF3T = "RGF3T";

        /// <summary>
        /// RGACC.
        /// </summary>
        public const string RGACC = "RGACC";

        /// <summary>
        /// RGANS.
        /// </summary>
        public const string RGANS = "RGANS";

        /// <summary>
        /// RGDCPER.
        /// </summary>
        public const string RGDCPER = "RGDCPER";

        /// <summary>
        /// RGDCVD.
        /// </summary>
        public const string RGDCVD = "RGDCVD";

        /// <summary>
        /// RGCVDPER.
        /// </summary>
        public const string RGCVDPER = "RGCVDPER";

        /// <summary>
        /// RGYODT.
        /// </summary>
        public const string RGYODT = "RGYODT";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGTDAY.
        /// </summary>
        public const string RGTDAY = "RGTDAY";

        /// <summary>
        /// RGI75CESS.
        /// </summary>
        public const string RGI75CESS = "RGI75CESS";

        /// <summary>
        /// RGI75FTX1.
        /// </summary>
        public const string RGI75FTX1 = "RGI75FTX1";

        /// <summary>
        /// RGI75FTX2.
        /// </summary>
        public const string RGI75FTX2 = "RGI75FTX2";

        /// <summary>
        /// RGI75AED.
        /// </summary>
        public const string RGI75AED = "RGI75AED";

        /// <summary>
        /// RGI75BED.
        /// </summary>
        public const string RGI75BED = "RGI75BED";

        /// <summary>
        /// RGI75SED.
        /// </summary>
        public const string RGI75SED = "RGI75SED";

        /// <summary>
        /// RGI75AEDP.
        /// </summary>
        public const string RGI75AEDP = "RGI75AEDP";

        /// <summary>
        /// RGI75BEDP.
        /// </summary>
        public const string RGI75BEDP = "RGI75BEDP";

        /// <summary>
        /// RGI75SEDP.
        /// </summary>
        public const string RGI75SEDP = "RGI75SEDP";

        /// <summary>
        /// RGI75NCDP.
        /// </summary>
        public const string RGI75NCDP = "RGI75NCDP";

        /// <summary>
        /// RGI75CESP.
        /// </summary>
        public const string RGI75CESP = "RGI75CESP";
    }

    /// <inheritdoc />
    public override string TableName => "F75I380";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGYRM", "RGYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("RGMT", "RGMT", JdeDataType.Numeric, null, true, true),
        new JdeField("RGYEXU", "RGYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("RGMCU", "RGMCU", JdeDataType.String, 24, true, true),
        new JdeField("RGITM", "RGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RGLITM", "RGLITM", JdeDataType.String, 50, true, true),
        new JdeField("RGOLND", "RGOLND", JdeDataType.Numeric, null, true, true),
        new JdeField("RGBPFG", "RGBPFG", JdeDataType.String, 2),
        new JdeField("RGYCHN", "RGYCHN", JdeDataType.String, 40),
        new JdeField("RGTRDJ", "RGTRDJ", JdeDataType.Numeric),
        new JdeField("RGCLM1", "RGCLM1", JdeDataType.String, 8),
        new JdeField("RGCLM2", "RGCLM2", JdeDataType.String, 8),
        new JdeField("RGKCOO", "RGKCOO", JdeDataType.String, 10),
        new JdeField("RGDOCO", "RGDOCO", JdeDataType.Numeric),
        new JdeField("RGDCTO", "RGDCTO", JdeDataType.String, 4),
        new JdeField("RGKCO", "RGKCO", JdeDataType.String, 10),
        new JdeField("RGDOC", "RGDOC", JdeDataType.Numeric),
        new JdeField("RGDCT", "RGDCT", JdeDataType.String, 4),
        new JdeField("RGODOC", "RGODOC", JdeDataType.Numeric),
        new JdeField("RGODCT", "RGODCT", JdeDataType.String, 4),
        new JdeField("RGLNID", "RGLNID", JdeDataType.Numeric),
        new JdeField("RGNLIN", "RGNLIN", JdeDataType.Numeric),
        new JdeField("RGTKID", "RGTKID", JdeDataType.String, 16),
        new JdeField("RGLOCN", "RGLOCN", JdeDataType.String, 40),
        new JdeField("RGLOTN", "RGLOTN", JdeDataType.String, 60),
        new JdeField("RGTRQT", "RGTRQT", JdeDataType.Numeric),
        new JdeField("RGTRUM", "RGTRUM", JdeDataType.String, 4),
        new JdeField("RGSTOK", "RGSTOK", JdeDataType.Numeric),
        new JdeField("RGUVM1", "RGUVM1", JdeDataType.String, 4),
        new JdeField("RGAMBI", "RGAMBI", JdeDataType.Numeric),
        new JdeField("RGAMBU", "RGAMBU", JdeDataType.String, 4),
        new JdeField("RGWGTR", "RGWGTR", JdeDataType.Numeric),
        new JdeField("RGUWUM", "RGUWUM", JdeDataType.String, 4),
        new JdeField("RGPRFR", "RGPRFR", JdeDataType.String, 4),
        new JdeField("RGUMGP", "RGUMGP", JdeDataType.String, 4),
        new JdeField("RGAQTY", "RGAQTY", JdeDataType.Numeric),
        new JdeField("RGASVL", "RGASVL", JdeDataType.Numeric),
        new JdeField("RGYTDU", "RGYTDU", JdeDataType.Numeric),
        new JdeField("RGDTYS", "RGDTYS", JdeDataType.String, 4),
        new JdeField("RGFLAG", "RGFLAG", JdeDataType.String, 2),
        new JdeField("RGASID", "RGASID", JdeDataType.String, 50),
        new JdeField("RGUFLG", "RGUFLG", JdeDataType.String, 2),
        new JdeField("RGYETT", "RGYETT", JdeDataType.String, 8),
        new JdeField("RGYMDR", "RGYMDR", JdeDataType.Numeric),
        new JdeField("RGYCDR", "RGYCDR", JdeDataType.Numeric),
        new JdeField("RGYPDR", "RGYPDR", JdeDataType.Numeric),
        new JdeField("RGQTY1", "RGQTY1", JdeDataType.Numeric),
        new JdeField("RGQTY2", "RGQTY2", JdeDataType.Numeric),
        new JdeField("RGCRCD", "RGCRCD", JdeDataType.String, 6),
        new JdeField("RGCRDC", "RGCRDC", JdeDataType.String, 6),
        new JdeField("RGYUTD", "RGYUTD", JdeDataType.Numeric),
        new JdeField("RGLFDJ", "RGLFDJ", JdeDataType.Numeric),
        new JdeField("RGPSDJ", "RGPSDJ", JdeDataType.Numeric),
        new JdeField("RGDT", "RGDT", JdeDataType.Numeric),
        new JdeField("RGDT1", "RGDT1", JdeDataType.Numeric),
        new JdeField("RGF1A", "RGF1A", JdeDataType.Numeric),
        new JdeField("RGF2A", "RGF2A", JdeDataType.Numeric),
        new JdeField("RGF3A", "RGF3A", JdeDataType.Numeric),
        new JdeField("RGF4A", "RGF4A", JdeDataType.Numeric),
        new JdeField("RGC1FU", "RGC1FU", JdeDataType.String, 2),
        new JdeField("RGC2FU", "RGC2FU", JdeDataType.String, 2),
        new JdeField("RGOPT", "RGOPT", JdeDataType.String, 2),
        new JdeField("RGF1T", "RGF1T", JdeDataType.String, 60),
        new JdeField("RGF2T", "RGF2T", JdeDataType.String, 60),
        new JdeField("RGF3T", "RGF3T", JdeDataType.String, 60),
        new JdeField("RGACC", "RGACC", JdeDataType.String, 32),
        new JdeField("RGANS", "RGANS", JdeDataType.String, 50),
        new JdeField("RGDCPER", "RGDCPER", JdeDataType.Numeric),
        new JdeField("RGDCVD", "RGDCVD", JdeDataType.Numeric),
        new JdeField("RGCVDPER", "RGCVDPER", JdeDataType.Numeric),
        new JdeField("RGYODT", "RGYODT", JdeDataType.Numeric),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGTDAY", "RGTDAY", JdeDataType.Numeric),
        new JdeField("RGI75CESS", "RGI75CESS", JdeDataType.Numeric),
        new JdeField("RGI75FTX1", "RGI75FTX1", JdeDataType.Numeric),
        new JdeField("RGI75FTX2", "RGI75FTX2", JdeDataType.Numeric),
        new JdeField("RGI75AED", "RGI75AED", JdeDataType.Numeric),
        new JdeField("RGI75BED", "RGI75BED", JdeDataType.Numeric),
        new JdeField("RGI75SED", "RGI75SED", JdeDataType.Numeric),
        new JdeField("RGI75AEDP", "RGI75AEDP", JdeDataType.Numeric),
        new JdeField("RGI75BEDP", "RGI75BEDP", JdeDataType.Numeric),
        new JdeField("RGI75SEDP", "RGI75SEDP", JdeDataType.Numeric),
        new JdeField("RGI75NCDP", "RGI75NCDP", JdeDataType.Numeric),
        new JdeField("RGI75CESP", "RGI75CESP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I380_0", "Primary Key on RGYRM, RGMT, RGYEXU, RGMCU, RGITM, RGLITM, RGOLND", new[] { "RGYRM", "RGMT", "RGYEXU", "RGMCU", "RGITM", "RGLITM", "RGOLND" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I380_5", "Index on RGYEXU, RGMCU, RGITM, RGTKID, SYS_NC00088$, RGCLM1", new[] { "RGYEXU", "RGMCU", "RGITM", "RGTKID", "SYS_NC00088$", "RGCLM1" }),
        new JdeIndex("F75I380_6", "Index on RGYEXU, RGMCU, RGITM, RGTKID, RGTRDJ, RGCLM1", new[] { "RGYEXU", "RGMCU", "RGITM", "RGTKID", "RGTRDJ", "RGCLM1" }),
        new JdeIndex("F75I380_7", "Index on RGYEXU, RGYRM, RGMT, RGDOC", new[] { "RGYEXU", "RGYRM", "RGMT", "RGDOC" }),
        new JdeIndex("F75I380_8", "Index on SYS_NC00089$, SYS_NC00090$, SYS_NC00091$, SYS_NC00092$", new[] { "SYS_NC00089$", "SYS_NC00090$", "SYS_NC00091$", "SYS_NC00092$" })
    };
}
