using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I100W - .
/// </summary>
public class F75I100W : JdeTable
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
        /// EFYSGN.
        /// </summary>
        public const string EFYSGN = "EFYSGN";

        /// <summary>
        /// EFYDSG.
        /// </summary>
        public const string EFYDSG = "EFYDSG";

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
    }

    /// <inheritdoc />
    public override string TableName => "F75I100W";

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
        new JdeField("EFYSGN", "EFYSGN", JdeDataType.String, 80),
        new JdeField("EFYDSG", "EFYDSG", JdeDataType.String, 80),
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
        new JdeField("EFUPMT", "EFUPMT", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I100W_0", "Primary Key on EFTORG, EFLNID, EFDCT, EFJOBN, EFUPMJ, EFUPMT", new[] { "EFTORG", "EFLNID", "EFDCT", "EFJOBN", "EFUPMJ", "EFUPMT" }, isUnique: true, isPrimaryKey: true)
    };
}
