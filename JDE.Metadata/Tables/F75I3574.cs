using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3574 - .
/// </summary>
public class F75I3574 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTYCHL.
        /// </summary>
        public const string CTYCHL = "CTYCHL";

        /// <summary>
        /// CTMCU0.
        /// </summary>
        public const string CTMCU0 = "CTMCU0";

        /// <summary>
        /// CTYEXU.
        /// </summary>
        public const string CTYEXU = "CTYEXU";

        /// <summary>
        /// CTACTB.
        /// </summary>
        public const string CTACTB = "CTACTB";

        /// <summary>
        /// CTDOCO.
        /// </summary>
        public const string CTDOCO = "CTDOCO";

        /// <summary>
        /// CTDCTO.
        /// </summary>
        public const string CTDCTO = "CTDCTO";

        /// <summary>
        /// CTKCOO.
        /// </summary>
        public const string CTKCOO = "CTKCOO";

        /// <summary>
        /// CTKCO.
        /// </summary>
        public const string CTKCO = "CTKCO";

        /// <summary>
        /// CTDOC.
        /// </summary>
        public const string CTDOC = "CTDOC";

        /// <summary>
        /// CTDCT.
        /// </summary>
        public const string CTDCT = "CTDCT";

        /// <summary>
        /// CTUKID.
        /// </summary>
        public const string CTUKID = "CTUKID";

        /// <summary>
        /// CTRUKID.
        /// </summary>
        public const string CTRUKID = "CTRUKID";

        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTTRDJ.
        /// </summary>
        public const string CTTRDJ = "CTTRDJ";

        /// <summary>
        /// CTLNID.
        /// </summary>
        public const string CTLNID = "CTLNID";

        /// <summary>
        /// CTNLIN.
        /// </summary>
        public const string CTNLIN = "CTNLIN";

        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTLITM.
        /// </summary>
        public const string CTLITM = "CTLITM";

        /// <summary>
        /// CTAEXP.
        /// </summary>
        public const string CTAEXP = "CTAEXP";

        /// <summary>
        /// CTTRQT.
        /// </summary>
        public const string CTTRQT = "CTTRQT";

        /// <summary>
        /// CTQBAL.
        /// </summary>
        public const string CTQBAL = "CTQBAL";

        /// <summary>
        /// CTUOM.
        /// </summary>
        public const string CTUOM = "CTUOM";

        /// <summary>
        /// CTLOCN.
        /// </summary>
        public const string CTLOCN = "CTLOCN";

        /// <summary>
        /// CTLOTN.
        /// </summary>
        public const string CTLOTN = "CTLOTN";

        /// <summary>
        /// CTODOC.
        /// </summary>
        public const string CTODOC = "CTODOC";

        /// <summary>
        /// CTODCT.
        /// </summary>
        public const string CTODCT = "CTODCT";

        /// <summary>
        /// CTPRFR.
        /// </summary>
        public const string CTPRFR = "CTPRFR";

        /// <summary>
        /// CTUMGP.
        /// </summary>
        public const string CTUMGP = "CTUMGP";

        /// <summary>
        /// CTAQTY.
        /// </summary>
        public const string CTAQTY = "CTAQTY";

        /// <summary>
        /// CTASVL.
        /// </summary>
        public const string CTASVL = "CTASVL";

        /// <summary>
        /// CTYTDU.
        /// </summary>
        public const string CTYTDU = "CTYTDU";

        /// <summary>
        /// CTDTYS.
        /// </summary>
        public const string CTDTYS = "CTDTYS";

        /// <summary>
        /// CTFLAG.
        /// </summary>
        public const string CTFLAG = "CTFLAG";

        /// <summary>
        /// CTASID.
        /// </summary>
        public const string CTASID = "CTASID";

        /// <summary>
        /// CTUFLG.
        /// </summary>
        public const string CTUFLG = "CTUFLG";

        /// <summary>
        /// CTQTY1.
        /// </summary>
        public const string CTQTY1 = "CTQTY1";

        /// <summary>
        /// CTQTY2.
        /// </summary>
        public const string CTQTY2 = "CTQTY2";

        /// <summary>
        /// CTCRCD.
        /// </summary>
        public const string CTCRCD = "CTCRCD";

        /// <summary>
        /// CTCRDC.
        /// </summary>
        public const string CTCRDC = "CTCRDC";

        /// <summary>
        /// CTYUTD.
        /// </summary>
        public const string CTYUTD = "CTYUTD";

        /// <summary>
        /// CTLFDJ.
        /// </summary>
        public const string CTLFDJ = "CTLFDJ";

        /// <summary>
        /// CTPSDJ.
        /// </summary>
        public const string CTPSDJ = "CTPSDJ";

        /// <summary>
        /// CTDT.
        /// </summary>
        public const string CTDT = "CTDT";

        /// <summary>
        /// CTDT1.
        /// </summary>
        public const string CTDT1 = "CTDT1";

        /// <summary>
        /// CTF1A.
        /// </summary>
        public const string CTF1A = "CTF1A";

        /// <summary>
        /// CTF2A.
        /// </summary>
        public const string CTF2A = "CTF2A";

        /// <summary>
        /// CTF3A.
        /// </summary>
        public const string CTF3A = "CTF3A";

        /// <summary>
        /// CTF4A.
        /// </summary>
        public const string CTF4A = "CTF4A";

        /// <summary>
        /// CTC1FU.
        /// </summary>
        public const string CTC1FU = "CTC1FU";

        /// <summary>
        /// CTC2FU.
        /// </summary>
        public const string CTC2FU = "CTC2FU";

        /// <summary>
        /// CTOPT.
        /// </summary>
        public const string CTOPT = "CTOPT";

        /// <summary>
        /// CTF1T.
        /// </summary>
        public const string CTF1T = "CTF1T";

        /// <summary>
        /// CTF2T.
        /// </summary>
        public const string CTF2T = "CTF2T";

        /// <summary>
        /// CTF3T.
        /// </summary>
        public const string CTF3T = "CTF3T";

        /// <summary>
        /// CTACC.
        /// </summary>
        public const string CTACC = "CTACC";

        /// <summary>
        /// CTANS.
        /// </summary>
        public const string CTANS = "CTANS";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTEF01.
        /// </summary>
        public const string CTEF01 = "CTEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3574";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTYCHL", "CTYCHL", JdeDataType.Numeric, null, true, true),
        new JdeField("CTMCU0", "CTMCU0", JdeDataType.String, 24, true, true),
        new JdeField("CTYEXU", "CTYEXU", JdeDataType.Numeric),
        new JdeField("CTACTB", "CTACTB", JdeDataType.String, 20, true, true),
        new JdeField("CTDOCO", "CTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDCTO", "CTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CTKCOO", "CTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CTKCO", "CTKCO", JdeDataType.String, 10),
        new JdeField("CTDOC", "CTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDCT", "CTDCT", JdeDataType.String, 4),
        new JdeField("CTUKID", "CTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTRUKID", "CTRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24),
        new JdeField("CTTRDJ", "CTTRDJ", JdeDataType.Numeric),
        new JdeField("CTLNID", "CTLNID", JdeDataType.Numeric),
        new JdeField("CTNLIN", "CTNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric),
        new JdeField("CTLITM", "CTLITM", JdeDataType.String, 50),
        new JdeField("CTAEXP", "CTAEXP", JdeDataType.Numeric),
        new JdeField("CTTRQT", "CTTRQT", JdeDataType.Numeric),
        new JdeField("CTQBAL", "CTQBAL", JdeDataType.Numeric),
        new JdeField("CTUOM", "CTUOM", JdeDataType.String, 4),
        new JdeField("CTLOCN", "CTLOCN", JdeDataType.String, 40),
        new JdeField("CTLOTN", "CTLOTN", JdeDataType.String, 60),
        new JdeField("CTODOC", "CTODOC", JdeDataType.Numeric),
        new JdeField("CTODCT", "CTODCT", JdeDataType.String, 4),
        new JdeField("CTPRFR", "CTPRFR", JdeDataType.String, 4),
        new JdeField("CTUMGP", "CTUMGP", JdeDataType.String, 4),
        new JdeField("CTAQTY", "CTAQTY", JdeDataType.Numeric),
        new JdeField("CTASVL", "CTASVL", JdeDataType.Numeric),
        new JdeField("CTYTDU", "CTYTDU", JdeDataType.Numeric),
        new JdeField("CTDTYS", "CTDTYS", JdeDataType.String, 4),
        new JdeField("CTFLAG", "CTFLAG", JdeDataType.String, 2),
        new JdeField("CTASID", "CTASID", JdeDataType.String, 50),
        new JdeField("CTUFLG", "CTUFLG", JdeDataType.String, 2),
        new JdeField("CTQTY1", "CTQTY1", JdeDataType.Numeric),
        new JdeField("CTQTY2", "CTQTY2", JdeDataType.Numeric),
        new JdeField("CTCRCD", "CTCRCD", JdeDataType.String, 6),
        new JdeField("CTCRDC", "CTCRDC", JdeDataType.String, 6),
        new JdeField("CTYUTD", "CTYUTD", JdeDataType.Numeric),
        new JdeField("CTLFDJ", "CTLFDJ", JdeDataType.Numeric),
        new JdeField("CTPSDJ", "CTPSDJ", JdeDataType.Numeric),
        new JdeField("CTDT", "CTDT", JdeDataType.Numeric),
        new JdeField("CTDT1", "CTDT1", JdeDataType.Numeric),
        new JdeField("CTF1A", "CTF1A", JdeDataType.Numeric),
        new JdeField("CTF2A", "CTF2A", JdeDataType.Numeric),
        new JdeField("CTF3A", "CTF3A", JdeDataType.Numeric),
        new JdeField("CTF4A", "CTF4A", JdeDataType.Numeric),
        new JdeField("CTC1FU", "CTC1FU", JdeDataType.String, 2),
        new JdeField("CTC2FU", "CTC2FU", JdeDataType.String, 2),
        new JdeField("CTOPT", "CTOPT", JdeDataType.String, 2),
        new JdeField("CTF1T", "CTF1T", JdeDataType.String, 60),
        new JdeField("CTF2T", "CTF2T", JdeDataType.String, 60),
        new JdeField("CTF3T", "CTF3T", JdeDataType.String, 60),
        new JdeField("CTACC", "CTACC", JdeDataType.String, 32),
        new JdeField("CTANS", "CTANS", JdeDataType.String, 50),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTEF01", "CTEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3574_0", "Primary Key on CTYCHL, CTACTB, CTMCU0, CTKCOO, CTDOCO, CTDCTO, CTDOC, CTUKID, CTNLIN, CTRUKID", new[] { "CTYCHL", "CTACTB", "CTMCU0", "CTKCOO", "CTDOCO", "CTDCTO", "CTDOC", "CTUKID", "CTNLIN", "CTRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I3574_3", "Index on CTACTB, CTDOCO, CTDCTO, CTUKID, CTITM, CTPID, CTUSER, CTJOBN, CTUPMT, CTUPMJ", new[] { "CTACTB", "CTDOCO", "CTDCTO", "CTUKID", "CTITM", "CTPID", "CTUSER", "CTJOBN", "CTUPMT", "CTUPMJ" }),
        new JdeIndex("F75I3574_4", "Index on CTDOCO, CTDCTO, CTKCOO, CTLNID, CTNLIN", new[] { "CTDOCO", "CTDCTO", "CTKCOO", "CTLNID", "CTNLIN" })
    };
}
