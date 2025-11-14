using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0790 - .
/// </summary>
public class F31B0790 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVWOPID.
        /// </summary>
        public const string SVWOPID = "SVWOPID";

        /// <summary>
        /// SVWLOTN.
        /// </summary>
        public const string SVWLOTN = "SVWLOTN";

        /// <summary>
        /// SVEURID.
        /// </summary>
        public const string SVEURID = "SVEURID";

        /// <summary>
        /// SVSPECID.
        /// </summary>
        public const string SVSPECID = "SVSPECID";

        /// <summary>
        /// SVSEQNUMB.
        /// </summary>
        public const string SVSEQNUMB = "SVSEQNUMB";

        /// <summary>
        /// SVERRID.
        /// </summary>
        public const string SVERRID = "SVERRID";

        /// <summary>
        /// SVWVNUM.
        /// </summary>
        public const string SVWVNUM = "SVWVNUM";

        /// <summary>
        /// SVWBID.
        /// </summary>
        public const string SVWBID = "SVWBID";

        /// <summary>
        /// SVNCID.
        /// </summary>
        public const string SVNCID = "SVNCID";

        /// <summary>
        /// SVSPECTYPE.
        /// </summary>
        public const string SVSPECTYPE = "SVSPECTYPE";

        /// <summary>
        /// SVTVALC.
        /// </summary>
        public const string SVTVALC = "SVTVALC";

        /// <summary>
        /// SVTVALS.
        /// </summary>
        public const string SVTVALS = "SVTVALS";

        /// <summary>
        /// SVTVALD.
        /// </summary>
        public const string SVTVALD = "SVTVALD";

        /// <summary>
        /// SVTVALN.
        /// </summary>
        public const string SVTVALN = "SVTVALN";

        /// <summary>
        /// SVNCRULE.
        /// </summary>
        public const string SVNCRULE = "SVNCRULE";

        /// <summary>
        /// SVRVALC.
        /// </summary>
        public const string SVRVALC = "SVRVALC";

        /// <summary>
        /// SVRVALS.
        /// </summary>
        public const string SVRVALS = "SVRVALS";

        /// <summary>
        /// SVRVALD.
        /// </summary>
        public const string SVRVALD = "SVRVALD";

        /// <summary>
        /// SVRVALN.
        /// </summary>
        public const string SVRVALN = "SVRVALN";

        /// <summary>
        /// SVVRESULT.
        /// </summary>
        public const string SVVRESULT = "SVVRESULT";

        /// <summary>
        /// SVHSERR.
        /// </summary>
        public const string SVHSERR = "SVHSERR";

        /// <summary>
        /// SVVREASON.
        /// </summary>
        public const string SVVREASON = "SVVREASON";

        /// <summary>
        /// SVVCOMMENT.
        /// </summary>
        public const string SVVCOMMENT = "SVVCOMMENT";

        /// <summary>
        /// SVURAB.
        /// </summary>
        public const string SVURAB = "SVURAB";

        /// <summary>
        /// SVURAT.
        /// </summary>
        public const string SVURAT = "SVURAT";

        /// <summary>
        /// SVURCD.
        /// </summary>
        public const string SVURCD = "SVURCD";

        /// <summary>
        /// SVURDT.
        /// </summary>
        public const string SVURDT = "SVURDT";

        /// <summary>
        /// SVURRF.
        /// </summary>
        public const string SVURRF = "SVURRF";

        /// <summary>
        /// SVJOBN.
        /// </summary>
        public const string SVJOBN = "SVJOBN";

        /// <summary>
        /// SVPID.
        /// </summary>
        public const string SVPID = "SVPID";

        /// <summary>
        /// SVTDAY.
        /// </summary>
        public const string SVTDAY = "SVTDAY";

        /// <summary>
        /// SVUPMJ.
        /// </summary>
        public const string SVUPMJ = "SVUPMJ";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVWAB.
        /// </summary>
        public const string SVWAB = "SVWAB";

        /// <summary>
        /// SVWCD.
        /// </summary>
        public const string SVWCD = "SVWCD";

        /// <summary>
        /// SVWMDT.
        /// </summary>
        public const string SVWMDT = "SVWMDT";

        /// <summary>
        /// SVWNUM.
        /// </summary>
        public const string SVWNUM = "SVWNUM";

        /// <summary>
        /// SVWRF.
        /// </summary>
        public const string SVWRF = "SVWRF";

        /// <summary>
        /// SVWOPN.
        /// </summary>
        public const string SVWOPN = "SVWOPN";

        /// <summary>
        /// SVEURSCD.
        /// </summary>
        public const string SVEURSCD = "SVEURSCD";

        /// <summary>
        /// SVSPECNM.
        /// </summary>
        public const string SVSPECNM = "SVSPECNM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0790";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVWOPID", "SVWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVWLOTN", "SVWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("SVEURID", "SVEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVSPECID", "SVSPECID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVSEQNUMB", "SVSEQNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("SVERRID", "SVERRID", JdeDataType.String, 8),
        new JdeField("SVWVNUM", "SVWVNUM", JdeDataType.String, 60),
        new JdeField("SVWBID", "SVWBID", JdeDataType.String, 60),
        new JdeField("SVNCID", "SVNCID", JdeDataType.Numeric),
        new JdeField("SVSPECTYPE", "SVSPECTYPE", JdeDataType.String, 2),
        new JdeField("SVTVALC", "SVTVALC", JdeDataType.String, 2),
        new JdeField("SVTVALS", "SVTVALS", JdeDataType.String, 40),
        new JdeField("SVTVALD", "SVTVALD", JdeDataType.Numeric),
        new JdeField("SVTVALN", "SVTVALN", JdeDataType.Numeric),
        new JdeField("SVNCRULE", "SVNCRULE", JdeDataType.String, 8),
        new JdeField("SVRVALC", "SVRVALC", JdeDataType.String, 2),
        new JdeField("SVRVALS", "SVRVALS", JdeDataType.String, 40),
        new JdeField("SVRVALD", "SVRVALD", JdeDataType.Numeric),
        new JdeField("SVRVALN", "SVRVALN", JdeDataType.Numeric),
        new JdeField("SVVRESULT", "SVVRESULT", JdeDataType.String, 2),
        new JdeField("SVHSERR", "SVHSERR", JdeDataType.String, 2),
        new JdeField("SVVREASON", "SVVREASON", JdeDataType.String, 4),
        new JdeField("SVVCOMMENT", "SVVCOMMENT", JdeDataType.String, 120),
        new JdeField("SVURAB", "SVURAB", JdeDataType.Numeric),
        new JdeField("SVURAT", "SVURAT", JdeDataType.Numeric),
        new JdeField("SVURCD", "SVURCD", JdeDataType.String, 4),
        new JdeField("SVURDT", "SVURDT", JdeDataType.Numeric),
        new JdeField("SVURRF", "SVURRF", JdeDataType.String, 30),
        new JdeField("SVJOBN", "SVJOBN", JdeDataType.String, 20),
        new JdeField("SVPID", "SVPID", JdeDataType.String, 20),
        new JdeField("SVTDAY", "SVTDAY", JdeDataType.Numeric),
        new JdeField("SVUPMJ", "SVUPMJ", JdeDataType.Numeric),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVWAB", "SVWAB", JdeDataType.Numeric),
        new JdeField("SVWCD", "SVWCD", JdeDataType.String, 6),
        new JdeField("SVWMDT", "SVWMDT", JdeDataType.Numeric),
        new JdeField("SVWNUM", "SVWNUM", JdeDataType.Numeric),
        new JdeField("SVWRF", "SVWRF", JdeDataType.String, 60),
        new JdeField("SVWOPN", "SVWOPN", JdeDataType.Numeric),
        new JdeField("SVEURSCD", "SVEURSCD", JdeDataType.String, 20),
        new JdeField("SVSPECNM", "SVSPECNM", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0790_0", "Primary Key on SVWOPID, SVWLOTN, SVEURID, SVSPECID, SVSEQNUMB", new[] { "SVWOPID", "SVWLOTN", "SVEURID", "SVSPECID", "SVSEQNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
