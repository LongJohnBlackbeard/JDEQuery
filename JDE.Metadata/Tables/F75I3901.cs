using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3901 - .
/// </summary>
public class F75I3901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COYCHL.
        /// </summary>
        public const string COYCHL = "COYCHL";

        /// <summary>
        /// COTRDJ.
        /// </summary>
        public const string COTRDJ = "COTRDJ";

        /// <summary>
        /// COYEXU.
        /// </summary>
        public const string COYEXU = "COYEXU";

        /// <summary>
        /// CODOCO.
        /// </summary>
        public const string CODOCO = "CODOCO";

        /// <summary>
        /// CODCTO.
        /// </summary>
        public const string CODCTO = "CODCTO";

        /// <summary>
        /// COKCOO.
        /// </summary>
        public const string COKCOO = "COKCOO";

        /// <summary>
        /// COITM.
        /// </summary>
        public const string COITM = "COITM";

        /// <summary>
        /// COLITM.
        /// </summary>
        public const string COLITM = "COLITM";

        /// <summary>
        /// COMCU0.
        /// </summary>
        public const string COMCU0 = "COMCU0";

        /// <summary>
        /// COLNID.
        /// </summary>
        public const string COLNID = "COLNID";

        /// <summary>
        /// COUKID.
        /// </summary>
        public const string COUKID = "COUKID";

        /// <summary>
        /// COMCUX.
        /// </summary>
        public const string COMCUX = "COMCUX";

        /// <summary>
        /// COTRQT.
        /// </summary>
        public const string COTRQT = "COTRQT";

        /// <summary>
        /// COUOM.
        /// </summary>
        public const string COUOM = "COUOM";

        /// <summary>
        /// COUREC.
        /// </summary>
        public const string COUREC = "COUREC";

        /// <summary>
        /// COUOM1.
        /// </summary>
        public const string COUOM1 = "COUOM1";

        /// <summary>
        /// COSOCN.
        /// </summary>
        public const string COSOCN = "COSOCN";

        /// <summary>
        /// COUOM2.
        /// </summary>
        public const string COUOM2 = "COUOM2";

        /// <summary>
        /// COQBAL.
        /// </summary>
        public const string COQBAL = "COQBAL";

        /// <summary>
        /// COUOM3.
        /// </summary>
        public const string COUOM3 = "COUOM3";

        /// <summary>
        /// COLOTN.
        /// </summary>
        public const string COLOTN = "COLOTN";

        /// <summary>
        /// COLOCN.
        /// </summary>
        public const string COLOCN = "COLOCN";

        /// <summary>
        /// COPC.
        /// </summary>
        public const string COPC = "COPC";

        /// <summary>
        /// COAN8.
        /// </summary>
        public const string COAN8 = "COAN8";

        /// <summary>
        /// COKCO.
        /// </summary>
        public const string COKCO = "COKCO";

        /// <summary>
        /// CODOC.
        /// </summary>
        public const string CODOC = "CODOC";

        /// <summary>
        /// CODCT.
        /// </summary>
        public const string CODCT = "CODCT";

        /// <summary>
        /// COUNCS.
        /// </summary>
        public const string COUNCS = "COUNCS";

        /// <summary>
        /// COPRFR.
        /// </summary>
        public const string COPRFR = "COPRFR";

        /// <summary>
        /// COUMGP.
        /// </summary>
        public const string COUMGP = "COUMGP";

        /// <summary>
        /// COAQTY.
        /// </summary>
        public const string COAQTY = "COAQTY";

        /// <summary>
        /// COASVL.
        /// </summary>
        public const string COASVL = "COASVL";

        /// <summary>
        /// COGLQT.
        /// </summary>
        public const string COGLQT = "COGLQT";

        /// <summary>
        /// COUOM4.
        /// </summary>
        public const string COUOM4 = "COUOM4";

        /// <summary>
        /// COYTDU.
        /// </summary>
        public const string COYTDU = "COYTDU";

        /// <summary>
        /// CODTYS.
        /// </summary>
        public const string CODTYS = "CODTYS";

        /// <summary>
        /// COFLAG.
        /// </summary>
        public const string COFLAG = "COFLAG";

        /// <summary>
        /// COASID.
        /// </summary>
        public const string COASID = "COASID";

        /// <summary>
        /// COUFLG.
        /// </summary>
        public const string COUFLG = "COUFLG";

        /// <summary>
        /// COQTY1.
        /// </summary>
        public const string COQTY1 = "COQTY1";

        /// <summary>
        /// COQTY2.
        /// </summary>
        public const string COQTY2 = "COQTY2";

        /// <summary>
        /// COCRCD.
        /// </summary>
        public const string COCRCD = "COCRCD";

        /// <summary>
        /// COCRDC.
        /// </summary>
        public const string COCRDC = "COCRDC";

        /// <summary>
        /// COYUTD.
        /// </summary>
        public const string COYUTD = "COYUTD";

        /// <summary>
        /// COLFDJ.
        /// </summary>
        public const string COLFDJ = "COLFDJ";

        /// <summary>
        /// COPSDJ.
        /// </summary>
        public const string COPSDJ = "COPSDJ";

        /// <summary>
        /// CODT.
        /// </summary>
        public const string CODT = "CODT";

        /// <summary>
        /// COQT1.
        /// </summary>
        public const string COQT1 = "COQT1";

        /// <summary>
        /// COF1A.
        /// </summary>
        public const string COF1A = "COF1A";

        /// <summary>
        /// COF2A.
        /// </summary>
        public const string COF2A = "COF2A";

        /// <summary>
        /// COF3A.
        /// </summary>
        public const string COF3A = "COF3A";

        /// <summary>
        /// COF4A.
        /// </summary>
        public const string COF4A = "COF4A";

        /// <summary>
        /// COC1FU.
        /// </summary>
        public const string COC1FU = "COC1FU";

        /// <summary>
        /// COC2FU.
        /// </summary>
        public const string COC2FU = "COC2FU";

        /// <summary>
        /// COOPT.
        /// </summary>
        public const string COOPT = "COOPT";

        /// <summary>
        /// COF1T.
        /// </summary>
        public const string COF1T = "COF1T";

        /// <summary>
        /// COF2T.
        /// </summary>
        public const string COF2T = "COF2T";

        /// <summary>
        /// COF3T.
        /// </summary>
        public const string COF3T = "COF3T";

        /// <summary>
        /// COACC.
        /// </summary>
        public const string COACC = "COACC";

        /// <summary>
        /// COANS.
        /// </summary>
        public const string COANS = "COANS";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";

        /// <summary>
        /// COEF01.
        /// </summary>
        public const string COEF01 = "COEF01";

        /// <summary>
        /// COMATH01.
        /// </summary>
        public const string COMATH01 = "COMATH01";

        /// <summary>
        /// COMATH02.
        /// </summary>
        public const string COMATH02 = "COMATH02";

        /// <summary>
        /// COMATH03.
        /// </summary>
        public const string COMATH03 = "COMATH03";

        /// <summary>
        /// COA101.
        /// </summary>
        public const string COA101 = "COA101";

        /// <summary>
        /// COA102.
        /// </summary>
        public const string COA102 = "COA102";

        /// <summary>
        /// COA103.
        /// </summary>
        public const string COA103 = "COA103";

        /// <summary>
        /// COA1CC.
        /// </summary>
        public const string COA1CC = "COA1CC";

        /// <summary>
        /// COA3CC.
        /// </summary>
        public const string COA3CC = "COA3CC";

        /// <summary>
        /// COA2CC.
        /// </summary>
        public const string COA2CC = "COA2CC";

        /// <summary>
        /// COADP11.
        /// </summary>
        public const string COADP11 = "COADP11";

        /// <summary>
        /// COADP12.
        /// </summary>
        public const string COADP12 = "COADP12";

        /// <summary>
        /// COADP13.
        /// </summary>
        public const string COADP13 = "COADP13";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COYCHL", "COYCHL", JdeDataType.Numeric, null, true, true),
        new JdeField("COTRDJ", "COTRDJ", JdeDataType.Numeric),
        new JdeField("COYEXU", "COYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("CODOCO", "CODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CODCTO", "CODCTO", JdeDataType.String, 4, true, true),
        new JdeField("COKCOO", "COKCOO", JdeDataType.String, 10),
        new JdeField("COITM", "COITM", JdeDataType.Numeric, null, true, true),
        new JdeField("COLITM", "COLITM", JdeDataType.String, 50),
        new JdeField("COMCU0", "COMCU0", JdeDataType.String, 24, true, true),
        new JdeField("COLNID", "COLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("COUKID", "COUKID", JdeDataType.Numeric),
        new JdeField("COMCUX", "COMCUX", JdeDataType.String, 24),
        new JdeField("COTRQT", "COTRQT", JdeDataType.Numeric),
        new JdeField("COUOM", "COUOM", JdeDataType.String, 4),
        new JdeField("COUREC", "COUREC", JdeDataType.Numeric),
        new JdeField("COUOM1", "COUOM1", JdeDataType.String, 4),
        new JdeField("COSOCN", "COSOCN", JdeDataType.Numeric),
        new JdeField("COUOM2", "COUOM2", JdeDataType.String, 4),
        new JdeField("COQBAL", "COQBAL", JdeDataType.Numeric),
        new JdeField("COUOM3", "COUOM3", JdeDataType.String, 4),
        new JdeField("COLOTN", "COLOTN", JdeDataType.String, 60),
        new JdeField("COLOCN", "COLOCN", JdeDataType.String, 40),
        new JdeField("COPC", "COPC", JdeDataType.Numeric),
        new JdeField("COAN8", "COAN8", JdeDataType.Numeric),
        new JdeField("COKCO", "COKCO", JdeDataType.String, 10),
        new JdeField("CODOC", "CODOC", JdeDataType.Numeric),
        new JdeField("CODCT", "CODCT", JdeDataType.String, 4),
        new JdeField("COUNCS", "COUNCS", JdeDataType.Numeric),
        new JdeField("COPRFR", "COPRFR", JdeDataType.String, 4),
        new JdeField("COUMGP", "COUMGP", JdeDataType.String, 4),
        new JdeField("COAQTY", "COAQTY", JdeDataType.Numeric),
        new JdeField("COASVL", "COASVL", JdeDataType.Numeric),
        new JdeField("COGLQT", "COGLQT", JdeDataType.Numeric),
        new JdeField("COUOM4", "COUOM4", JdeDataType.String, 4),
        new JdeField("COYTDU", "COYTDU", JdeDataType.Numeric),
        new JdeField("CODTYS", "CODTYS", JdeDataType.String, 4),
        new JdeField("COFLAG", "COFLAG", JdeDataType.String, 2, true, true),
        new JdeField("COASID", "COASID", JdeDataType.String, 50),
        new JdeField("COUFLG", "COUFLG", JdeDataType.String, 2),
        new JdeField("COQTY1", "COQTY1", JdeDataType.Numeric),
        new JdeField("COQTY2", "COQTY2", JdeDataType.Numeric),
        new JdeField("COCRCD", "COCRCD", JdeDataType.String, 6),
        new JdeField("COCRDC", "COCRDC", JdeDataType.String, 6),
        new JdeField("COYUTD", "COYUTD", JdeDataType.Numeric),
        new JdeField("COLFDJ", "COLFDJ", JdeDataType.Numeric),
        new JdeField("COPSDJ", "COPSDJ", JdeDataType.Numeric),
        new JdeField("CODT", "CODT", JdeDataType.Numeric),
        new JdeField("COQT1", "COQT1", JdeDataType.Numeric),
        new JdeField("COF1A", "COF1A", JdeDataType.Numeric),
        new JdeField("COF2A", "COF2A", JdeDataType.Numeric),
        new JdeField("COF3A", "COF3A", JdeDataType.Numeric),
        new JdeField("COF4A", "COF4A", JdeDataType.Numeric),
        new JdeField("COC1FU", "COC1FU", JdeDataType.String, 2),
        new JdeField("COC2FU", "COC2FU", JdeDataType.String, 2),
        new JdeField("COOPT", "COOPT", JdeDataType.String, 2),
        new JdeField("COF1T", "COF1T", JdeDataType.String, 60),
        new JdeField("COF2T", "COF2T", JdeDataType.String, 60),
        new JdeField("COF3T", "COF3T", JdeDataType.String, 60),
        new JdeField("COACC", "COACC", JdeDataType.String, 32),
        new JdeField("COANS", "COANS", JdeDataType.String, 50),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric),
        new JdeField("COEF01", "COEF01", JdeDataType.Numeric),
        new JdeField("COMATH01", "COMATH01", JdeDataType.Numeric),
        new JdeField("COMATH02", "COMATH02", JdeDataType.Numeric),
        new JdeField("COMATH03", "COMATH03", JdeDataType.Numeric),
        new JdeField("COA101", "COA101", JdeDataType.String, 2),
        new JdeField("COA102", "COA102", JdeDataType.String, 2),
        new JdeField("COA103", "COA103", JdeDataType.String, 2),
        new JdeField("COA1CC", "COA1CC", JdeDataType.String, 20),
        new JdeField("COA3CC", "COA3CC", JdeDataType.String, 20),
        new JdeField("COA2CC", "COA2CC", JdeDataType.String, 20),
        new JdeField("COADP11", "COADP11", JdeDataType.Numeric),
        new JdeField("COADP12", "COADP12", JdeDataType.Numeric),
        new JdeField("COADP13", "COADP13", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3901_0", "Primary Key on COYCHL, COMCU0, CODOCO, CODCTO, COITM, COYEXU, COLNID, COFLAG", new[] { "COYCHL", "COMCU0", "CODOCO", "CODCTO", "COITM", "COYEXU", "COLNID", "COFLAG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I3901_2", "Index on COYCHL, COTRDJ, COMCU0, COMCUX, COITM", new[] { "COYCHL", "COTRDJ", "COMCU0", "COMCUX", "COITM" })
    };
}
