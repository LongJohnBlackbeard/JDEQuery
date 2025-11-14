using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I100Q - .
/// </summary>
public class F75I100Q : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EFCO.
        /// </summary>
        public const string EFCO = "EFCO";

        /// <summary>
        /// EFLNID.
        /// </summary>
        public const string EFLNID = "EFLNID";

        /// <summary>
        /// EFDCT.
        /// </summary>
        public const string EFDCT = "EFDCT";

        /// <summary>
        /// EFXLIN.
        /// </summary>
        public const string EFXLIN = "EFXLIN";

        /// <summary>
        /// EFSLNE.
        /// </summary>
        public const string EFSLNE = "EFSLNE";

        /// <summary>
        /// EFPAD1.
        /// </summary>
        public const string EFPAD1 = "EFPAD1";

        /// <summary>
        /// EFMLNM.
        /// </summary>
        public const string EFMLNM = "EFMLNM";

        /// <summary>
        /// EFDCTO.
        /// </summary>
        public const string EFDCTO = "EFDCTO";

        /// <summary>
        /// EFN001.
        /// </summary>
        public const string EFN001 = "EFN001";

        /// <summary>
        /// EFALIN.
        /// </summary>
        public const string EFALIN = "EFALIN";

        /// <summary>
        /// EFSPHD.
        /// </summary>
        public const string EFSPHD = "EFSPHD";

        /// <summary>
        /// EFAG.
        /// </summary>
        public const string EFAG = "EFAG";

        /// <summary>
        /// EFAA.
        /// </summary>
        public const string EFAA = "EFAA";

        /// <summary>
        /// EFDGJ.
        /// </summary>
        public const string EFDGJ = "EFDGJ";

        /// <summary>
        /// EFALPH.
        /// </summary>
        public const string EFALPH = "EFALPH";

        /// <summary>
        /// EFADD1.
        /// </summary>
        public const string EFADD1 = "EFADD1";

        /// <summary>
        /// EFADD2.
        /// </summary>
        public const string EFADD2 = "EFADD2";

        /// <summary>
        /// EFADD3.
        /// </summary>
        public const string EFADD3 = "EFADD3";

        /// <summary>
        /// EFADD4.
        /// </summary>
        public const string EFADD4 = "EFADD4";

        /// <summary>
        /// EFADD5.
        /// </summary>
        public const string EFADD5 = "EFADD5";

        /// <summary>
        /// EFADDS.
        /// </summary>
        public const string EFADDS = "EFADDS";

        /// <summary>
        /// EFADDZ.
        /// </summary>
        public const string EFADDZ = "EFADDZ";

        /// <summary>
        /// EFACEQ.
        /// </summary>
        public const string EFACEQ = "EFACEQ";

        /// <summary>
        /// EFYSGN.
        /// </summary>
        public const string EFYSGN = "EFYSGN";

        /// <summary>
        /// EFYDSG.
        /// </summary>
        public const string EFYDSG = "EFYDSG";

        /// <summary>
        /// EFADD11.
        /// </summary>
        public const string EFADD11 = "EFADD11";

        /// <summary>
        /// EFADD12.
        /// </summary>
        public const string EFADD12 = "EFADD12";

        /// <summary>
        /// EFADD13.
        /// </summary>
        public const string EFADD13 = "EFADD13";

        /// <summary>
        /// EFADD14.
        /// </summary>
        public const string EFADD14 = "EFADD14";

        /// <summary>
        /// EFADD15.
        /// </summary>
        public const string EFADD15 = "EFADD15";

        /// <summary>
        /// EFADDSNH.
        /// </summary>
        public const string EFADDSNH = "EFADDSNH";

        /// <summary>
        /// EFADDZNH.
        /// </summary>
        public const string EFADDZNH = "EFADDZNH";

        /// <summary>
        /// EFCONSTR1.
        /// </summary>
        public const string EFCONSTR1 = "EFCONSTR1";

        /// <summary>
        /// EFCONTNO.
        /// </summary>
        public const string EFCONTNO = "EFCONTNO";

        /// <summary>
        /// EFYTN1.
        /// </summary>
        public const string EFYTN1 = "EFYTN1";

        /// <summary>
        /// EFYPN1.
        /// </summary>
        public const string EFYPN1 = "EFYPN1";

        /// <summary>
        /// EFDSVJ.
        /// </summary>
        public const string EFDSVJ = "EFDSVJ";

        /// <summary>
        /// EFYERT.
        /// </summary>
        public const string EFYERT = "EFYERT";

        /// <summary>
        /// EFFLAG.
        /// </summary>
        public const string EFFLAG = "EFFLAG";

        /// <summary>
        /// EFDBT.
        /// </summary>
        public const string EFDBT = "EFDBT";

        /// <summary>
        /// EFTAXC.
        /// </summary>
        public const string EFTAXC = "EFTAXC";

        /// <summary>
        /// EFAN8.
        /// </summary>
        public const string EFAN8 = "EFAN8";

        /// <summary>
        /// EFOPT.
        /// </summary>
        public const string EFOPT = "EFOPT";

        /// <summary>
        /// EFYN01.
        /// </summary>
        public const string EFYN01 = "EFYN01";

        /// <summary>
        /// EFAPTD.
        /// </summary>
        public const string EFAPTD = "EFAPTD";

        /// <summary>
        /// EFADAT.
        /// </summary>
        public const string EFADAT = "EFADAT";

        /// <summary>
        /// EFMATH01.
        /// </summary>
        public const string EFMATH01 = "EFMATH01";

        /// <summary>
        /// EFMATH02.
        /// </summary>
        public const string EFMATH02 = "EFMATH02";

        /// <summary>
        /// EFTORG.
        /// </summary>
        public const string EFTORG = "EFTORG";

        /// <summary>
        /// EFUSER.
        /// </summary>
        public const string EFUSER = "EFUSER";

        /// <summary>
        /// EFPID.
        /// </summary>
        public const string EFPID = "EFPID";

        /// <summary>
        /// EFJOBN.
        /// </summary>
        public const string EFJOBN = "EFJOBN";

        /// <summary>
        /// EFUPMJ.
        /// </summary>
        public const string EFUPMJ = "EFUPMJ";

        /// <summary>
        /// EFUPMT.
        /// </summary>
        public const string EFUPMT = "EFUPMT";

        /// <summary>
        /// EFYTXS.
        /// </summary>
        public const string EFYTXS = "EFYTXS";

        /// <summary>
        /// EFYTXB.
        /// </summary>
        public const string EFYTXB = "EFYTXB";

        /// <summary>
        /// EFMATH03.
        /// </summary>
        public const string EFMATH03 = "EFMATH03";

        /// <summary>
        /// EFAIPD.
        /// </summary>
        public const string EFAIPD = "EFAIPD";

        /// <summary>
        /// EFAMTADJ.
        /// </summary>
        public const string EFAMTADJ = "EFAMTADJ";

        /// <summary>
        /// EFEMAL.
        /// </summary>
        public const string EFEMAL = "EFEMAL";

        /// <summary>
        /// EFAR1.
        /// </summary>
        public const string EFAR1 = "EFAR1";

        /// <summary>
        /// EFPH4.
        /// </summary>
        public const string EFPH4 = "EFPH4";

        /// <summary>
        /// EFAA1.
        /// </summary>
        public const string EFAA1 = "EFAA1";

        /// <summary>
        /// EFAA2.
        /// </summary>
        public const string EFAA2 = "EFAA2";

        /// <summary>
        /// EFUKCHQE.
        /// </summary>
        public const string EFUKCHQE = "EFUKCHQE";

        /// <summary>
        /// EFDATF01.
        /// </summary>
        public const string EFDATF01 = "EFDATF01";

        /// <summary>
        /// EFDATF02.
        /// </summary>
        public const string EFDATF02 = "EFDATF02";

        /// <summary>
        /// EFDATF03.
        /// </summary>
        public const string EFDATF03 = "EFDATF03";

        /// <summary>
        /// EFDATF04.
        /// </summary>
        public const string EFDATF04 = "EFDATF04";

        /// <summary>
        /// EFDATF05.
        /// </summary>
        public const string EFDATF05 = "EFDATF05";

        /// <summary>
        /// EFAFA1.
        /// </summary>
        public const string EFAFA1 = "EFAFA1";

        /// <summary>
        /// EFAFA2.
        /// </summary>
        public const string EFAFA2 = "EFAFA2";

        /// <summary>
        /// EFAFA3.
        /// </summary>
        public const string EFAFA3 = "EFAFA3";

        /// <summary>
        /// EFAFA4.
        /// </summary>
        public const string EFAFA4 = "EFAFA4";

        /// <summary>
        /// EFMATH04.
        /// </summary>
        public const string EFMATH04 = "EFMATH04";

        /// <summary>
        /// EFMATH05.
        /// </summary>
        public const string EFMATH05 = "EFMATH05";

        /// <summary>
        /// EFFFU3.
        /// </summary>
        public const string EFFFU3 = "EFFFU3";

        /// <summary>
        /// EFDL01.
        /// </summary>
        public const string EFDL01 = "EFDL01";

        /// <summary>
        /// EFDSC1.
        /// </summary>
        public const string EFDSC1 = "EFDSC1";

        /// <summary>
        /// EFFLG.
        /// </summary>
        public const string EFFLG = "EFFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I100Q";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EFCO", "EFCO", JdeDataType.String, 10),
        new JdeField("EFLNID", "EFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("EFDCT", "EFDCT", JdeDataType.String, 4, true, true),
        new JdeField("EFXLIN", "EFXLIN", JdeDataType.Numeric),
        new JdeField("EFSLNE", "EFSLNE", JdeDataType.Numeric),
        new JdeField("EFPAD1", "EFPAD1", JdeDataType.String, 80),
        new JdeField("EFMLNM", "EFMLNM", JdeDataType.String, 80),
        new JdeField("EFDCTO", "EFDCTO", JdeDataType.String, 4),
        new JdeField("EFN001", "EFN001", JdeDataType.Numeric),
        new JdeField("EFALIN", "EFALIN", JdeDataType.Numeric),
        new JdeField("EFSPHD", "EFSPHD", JdeDataType.String, 20),
        new JdeField("EFAG", "EFAG", JdeDataType.Numeric),
        new JdeField("EFAA", "EFAA", JdeDataType.Numeric),
        new JdeField("EFDGJ", "EFDGJ", JdeDataType.Numeric),
        new JdeField("EFALPH", "EFALPH", JdeDataType.String, 80),
        new JdeField("EFADD1", "EFADD1", JdeDataType.String, 80),
        new JdeField("EFADD2", "EFADD2", JdeDataType.String, 80),
        new JdeField("EFADD3", "EFADD3", JdeDataType.String, 80),
        new JdeField("EFADD4", "EFADD4", JdeDataType.String, 80),
        new JdeField("EFADD5", "EFADD5", JdeDataType.String, 80),
        new JdeField("EFADDS", "EFADDS", JdeDataType.String, 6),
        new JdeField("EFADDZ", "EFADDZ", JdeDataType.String, 24),
        new JdeField("EFACEQ", "EFACEQ", JdeDataType.Numeric),
        new JdeField("EFYSGN", "EFYSGN", JdeDataType.String, 80),
        new JdeField("EFYDSG", "EFYDSG", JdeDataType.String, 80),
        new JdeField("EFADD11", "EFADD11", JdeDataType.String, 80),
        new JdeField("EFADD12", "EFADD12", JdeDataType.String, 80),
        new JdeField("EFADD13", "EFADD13", JdeDataType.String, 80),
        new JdeField("EFADD14", "EFADD14", JdeDataType.String, 80),
        new JdeField("EFADD15", "EFADD15", JdeDataType.String, 80),
        new JdeField("EFADDSNH", "EFADDSNH", JdeDataType.String, 6),
        new JdeField("EFADDZNH", "EFADDZNH", JdeDataType.String, 24),
        new JdeField("EFCONSTR1", "EFCONSTR1", JdeDataType.String, 512),
        new JdeField("EFCONTNO", "EFCONTNO", JdeDataType.Numeric),
        new JdeField("EFYTN1", "EFYTN1", JdeDataType.String, 80),
        new JdeField("EFYPN1", "EFYPN1", JdeDataType.String, 80),
        new JdeField("EFDSVJ", "EFDSVJ", JdeDataType.Numeric),
        new JdeField("EFYERT", "EFYERT", JdeDataType.Numeric),
        new JdeField("EFFLAG", "EFFLAG", JdeDataType.String, 2),
        new JdeField("EFDBT", "EFDBT", JdeDataType.Numeric),
        new JdeField("EFTAXC", "EFTAXC", JdeDataType.String, 2),
        new JdeField("EFAN8", "EFAN8", JdeDataType.Numeric),
        new JdeField("EFOPT", "EFOPT", JdeDataType.String, 2),
        new JdeField("EFYN01", "EFYN01", JdeDataType.String, 2),
        new JdeField("EFAPTD", "EFAPTD", JdeDataType.Numeric),
        new JdeField("EFADAT", "EFADAT", JdeDataType.Numeric),
        new JdeField("EFMATH01", "EFMATH01", JdeDataType.Numeric),
        new JdeField("EFMATH02", "EFMATH02", JdeDataType.Numeric),
        new JdeField("EFTORG", "EFTORG", JdeDataType.String, 20, true, true),
        new JdeField("EFUSER", "EFUSER", JdeDataType.String, 20),
        new JdeField("EFPID", "EFPID", JdeDataType.String, 20),
        new JdeField("EFJOBN", "EFJOBN", JdeDataType.String, 20, true, true),
        new JdeField("EFUPMJ", "EFUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EFUPMT", "EFUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("EFYTXS", "EFYTXS", JdeDataType.Numeric),
        new JdeField("EFYTXB", "EFYTXB", JdeDataType.Numeric),
        new JdeField("EFMATH03", "EFMATH03", JdeDataType.Numeric),
        new JdeField("EFAIPD", "EFAIPD", JdeDataType.Numeric),
        new JdeField("EFAMTADJ", "EFAMTADJ", JdeDataType.Numeric),
        new JdeField("EFEMAL", "EFEMAL", JdeDataType.String, 512),
        new JdeField("EFAR1", "EFAR1", JdeDataType.String, 12),
        new JdeField("EFPH4", "EFPH4", JdeDataType.String, 40),
        new JdeField("EFAA1", "EFAA1", JdeDataType.Numeric),
        new JdeField("EFAA2", "EFAA2", JdeDataType.Numeric),
        new JdeField("EFUKCHQE", "EFUKCHQE", JdeDataType.Numeric),
        new JdeField("EFDATF01", "EFDATF01", JdeDataType.Numeric),
        new JdeField("EFDATF02", "EFDATF02", JdeDataType.Numeric),
        new JdeField("EFDATF03", "EFDATF03", JdeDataType.Numeric),
        new JdeField("EFDATF04", "EFDATF04", JdeDataType.Numeric),
        new JdeField("EFDATF05", "EFDATF05", JdeDataType.Numeric),
        new JdeField("EFAFA1", "EFAFA1", JdeDataType.Numeric),
        new JdeField("EFAFA2", "EFAFA2", JdeDataType.Numeric),
        new JdeField("EFAFA3", "EFAFA3", JdeDataType.Numeric),
        new JdeField("EFAFA4", "EFAFA4", JdeDataType.Numeric),
        new JdeField("EFMATH04", "EFMATH04", JdeDataType.Numeric),
        new JdeField("EFMATH05", "EFMATH05", JdeDataType.Numeric),
        new JdeField("EFFFU3", "EFFFU3", JdeDataType.String, 20),
        new JdeField("EFDL01", "EFDL01", JdeDataType.String, 60),
        new JdeField("EFDSC1", "EFDSC1", JdeDataType.String, 60),
        new JdeField("EFFLG", "EFFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I100Q_0", "Primary Key on EFTORG, EFLNID, EFDCT, EFJOBN, EFUPMJ, EFUPMT", new[] { "EFTORG", "EFLNID", "EFDCT", "EFJOBN", "EFUPMJ", "EFUPMT" }, isUnique: true, isPrimaryKey: true)
    };
}
