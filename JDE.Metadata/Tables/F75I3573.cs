using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3573 - .
/// </summary>
public class F75I3573 : JdeTable
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
        /// COMCU0.
        /// </summary>
        public const string COMCU0 = "COMCU0";

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
        /// COSOCN.
        /// </summary>
        public const string COSOCN = "COSOCN";

        /// <summary>
        /// COQBAL.
        /// </summary>
        public const string COQBAL = "COQBAL";

        /// <summary>
        /// COPC.
        /// </summary>
        public const string COPC = "COPC";

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
    }

    /// <inheritdoc />
    public override string TableName => "F75I3573";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COYCHL", "COYCHL", JdeDataType.Numeric, null, true, true),
        new JdeField("COMCU0", "COMCU0", JdeDataType.String, 24, true, true),
        new JdeField("COTRDJ", "COTRDJ", JdeDataType.Numeric),
        new JdeField("COYEXU", "COYEXU", JdeDataType.Numeric),
        new JdeField("CODOCO", "CODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CODCTO", "CODCTO", JdeDataType.String, 4, true, true),
        new JdeField("COKCOO", "COKCOO", JdeDataType.String, 10, true, true),
        new JdeField("COITM", "COITM", JdeDataType.Numeric, null, true, true),
        new JdeField("COLITM", "COLITM", JdeDataType.String, 50),
        new JdeField("COMCUX", "COMCUX", JdeDataType.String, 24),
        new JdeField("COTRQT", "COTRQT", JdeDataType.Numeric),
        new JdeField("COUOM", "COUOM", JdeDataType.String, 4),
        new JdeField("COUREC", "COUREC", JdeDataType.Numeric),
        new JdeField("COSOCN", "COSOCN", JdeDataType.Numeric),
        new JdeField("COQBAL", "COQBAL", JdeDataType.Numeric),
        new JdeField("COPC", "COPC", JdeDataType.Numeric),
        new JdeField("COPRFR", "COPRFR", JdeDataType.String, 4),
        new JdeField("COUMGP", "COUMGP", JdeDataType.String, 4),
        new JdeField("COAQTY", "COAQTY", JdeDataType.Numeric),
        new JdeField("COASVL", "COASVL", JdeDataType.Numeric),
        new JdeField("COGLQT", "COGLQT", JdeDataType.Numeric),
        new JdeField("COYTDU", "COYTDU", JdeDataType.Numeric),
        new JdeField("CODTYS", "CODTYS", JdeDataType.String, 4),
        new JdeField("COFLAG", "COFLAG", JdeDataType.String, 2),
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
        new JdeField("COEF01", "COEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3573_0", "Primary Key on COYCHL, COMCU0, COKCOO, CODOCO, CODCTO, COITM", new[] { "COYCHL", "COMCU0", "COKCOO", "CODOCO", "CODCTO", "COITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I3573_3", "Index on COTRDJ, COYCHL, COMCU0, COMCUX, COITM", new[] { "COTRDJ", "COYCHL", "COMCU0", "COMCUX", "COITM" })
    };
}
