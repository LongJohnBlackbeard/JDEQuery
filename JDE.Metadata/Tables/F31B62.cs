using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B62 - .
/// </summary>
public class F31B62 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSWFSSID.
        /// </summary>
        public const string SSWFSSID = "SSWFSSID";

        /// <summary>
        /// SSWLN.
        /// </summary>
        public const string SSWLN = "SSWLN";

        /// <summary>
        /// SSUKID.
        /// </summary>
        public const string SSUKID = "SSUKID";

        /// <summary>
        /// SSBSNBR.
        /// </summary>
        public const string SSBSNBR = "SSBSNBR";

        /// <summary>
        /// SSASNBR.
        /// </summary>
        public const string SSASNBR = "SSASNBR";

        /// <summary>
        /// SSSMPTYP.
        /// </summary>
        public const string SSSMPTYP = "SSSMPTYP";

        /// <summary>
        /// SSSCNSL.
        /// </summary>
        public const string SSSCNSL = "SSSCNSL";

        /// <summary>
        /// SSSMPSTS.
        /// </summary>
        public const string SSSMPSTS = "SSSMPSTS";

        /// <summary>
        /// SSDLAB.
        /// </summary>
        public const string SSDLAB = "SSDLAB";

        /// <summary>
        /// SSSMPMTHD.
        /// </summary>
        public const string SSSMPMTHD = "SSSMPMTHD";

        /// <summary>
        /// SSSCUKID.
        /// </summary>
        public const string SSSCUKID = "SSSCUKID";

        /// <summary>
        /// SSSMPCLSR.
        /// </summary>
        public const string SSSMPCLSR = "SSSMPCLSR";

        /// <summary>
        /// SSNBRCNTR.
        /// </summary>
        public const string SSNBRCNTR = "SSNBRCNTR";

        /// <summary>
        /// SSBQSSZ.
        /// </summary>
        public const string SSBQSSZ = "SSBQSSZ";

        /// <summary>
        /// SSQUM.
        /// </summary>
        public const string SSQUM = "SSQUM";

        /// <summary>
        /// SSSMPLR.
        /// </summary>
        public const string SSSMPLR = "SSSMPLR";

        /// <summary>
        /// SSUSMPDT.
        /// </summary>
        public const string SSUSMPDT = "SSUSMPDT";

        /// <summary>
        /// SSUSRQDT.
        /// </summary>
        public const string SSUSRQDT = "SSUSRQDT";

        /// <summary>
        /// SSWTBID.
        /// </summary>
        public const string SSWTBID = "SSWTBID";

        /// <summary>
        /// SSBNCHID.
        /// </summary>
        public const string SSBNCHID = "SSBNCHID";

        /// <summary>
        /// SSCWLOTN.
        /// </summary>
        public const string SSCWLOTN = "SSCWLOTN";

        /// <summary>
        /// SSCWVID.
        /// </summary>
        public const string SSCWVID = "SSCWVID";

        /// <summary>
        /// SSCMCU.
        /// </summary>
        public const string SSCMCU = "SSCMCU";

        /// <summary>
        /// SSMCU.
        /// </summary>
        public const string SSMCU = "SSMCU";

        /// <summary>
        /// SSWVNUM.
        /// </summary>
        public const string SSWVNUM = "SSWVNUM";

        /// <summary>
        /// SSWVTY.
        /// </summary>
        public const string SSWVTY = "SSWVTY";

        /// <summary>
        /// SSWVID.
        /// </summary>
        public const string SSWVID = "SSWVID";

        /// <summary>
        /// SSWBID.
        /// </summary>
        public const string SSWBID = "SSWBID";

        /// <summary>
        /// SSQTST.
        /// </summary>
        public const string SSQTST = "SSQTST";

        /// <summary>
        /// SSTSTRSNM.
        /// </summary>
        public const string SSTSTRSNM = "SSTSTRSNM";

        /// <summary>
        /// SSRSSTS.
        /// </summary>
        public const string SSRSSTS = "SSRSSTS";

        /// <summary>
        /// SSDL01.
        /// </summary>
        public const string SSDL01 = "SSDL01";

        /// <summary>
        /// SSWOPID.
        /// </summary>
        public const string SSWOPID = "SSWOPID";

        /// <summary>
        /// SSWCFGID.
        /// </summary>
        public const string SSWCFGID = "SSWCFGID";

        /// <summary>
        /// SSWCDL01.
        /// </summary>
        public const string SSWCDL01 = "SSWCDL01";

        /// <summary>
        /// SSWCOPCD.
        /// </summary>
        public const string SSWCOPCD = "SSWCOPCD";

        /// <summary>
        /// SSWOPN.
        /// </summary>
        public const string SSWOPN = "SSWOPN";

        /// <summary>
        /// SSWSD.
        /// </summary>
        public const string SSWSD = "SSWSD";

        /// <summary>
        /// SSWOPST.
        /// </summary>
        public const string SSWOPST = "SSWOPST";

        /// <summary>
        /// SSWDOCO.
        /// </summary>
        public const string SSWDOCO = "SSWDOCO";

        /// <summary>
        /// SSWJOBN.
        /// </summary>
        public const string SSWJOBN = "SSWJOBN";

        /// <summary>
        /// SSQTC1.
        /// </summary>
        public const string SSQTC1 = "SSQTC1";

        /// <summary>
        /// SSQTC2.
        /// </summary>
        public const string SSQTC2 = "SSQTC2";

        /// <summary>
        /// SSQTC3.
        /// </summary>
        public const string SSQTC3 = "SSQTC3";

        /// <summary>
        /// SSQTC4.
        /// </summary>
        public const string SSQTC4 = "SSQTC4";

        /// <summary>
        /// SSQTC5.
        /// </summary>
        public const string SSQTC5 = "SSQTC5";

        /// <summary>
        /// SSWTBNAME.
        /// </summary>
        public const string SSWTBNAME = "SSWTBNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F31B62";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSWFSSID", "SSWFSSID", JdeDataType.String, 64, true, true),
        new JdeField("SSWLN", "SSWLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SSUKID", "SSUKID", JdeDataType.Numeric),
        new JdeField("SSBSNBR", "SSBSNBR", JdeDataType.Numeric),
        new JdeField("SSASNBR", "SSASNBR", JdeDataType.String, 40),
        new JdeField("SSSMPTYP", "SSSMPTYP", JdeDataType.String, 4),
        new JdeField("SSSCNSL", "SSSCNSL", JdeDataType.String, 2),
        new JdeField("SSSMPSTS", "SSSMPSTS", JdeDataType.String, 6),
        new JdeField("SSDLAB", "SSDLAB", JdeDataType.Numeric),
        new JdeField("SSSMPMTHD", "SSSMPMTHD", JdeDataType.String, 20),
        new JdeField("SSSCUKID", "SSSCUKID", JdeDataType.Numeric),
        new JdeField("SSSMPCLSR", "SSSMPCLSR", JdeDataType.String, 20),
        new JdeField("SSNBRCNTR", "SSNBRCNTR", JdeDataType.Numeric),
        new JdeField("SSBQSSZ", "SSBQSSZ", JdeDataType.Numeric),
        new JdeField("SSQUM", "SSQUM", JdeDataType.String, 6),
        new JdeField("SSSMPLR", "SSSMPLR", JdeDataType.String, 20),
        new JdeField("SSUSMPDT", "SSUSMPDT", JdeDataType.Date),
        new JdeField("SSUSRQDT", "SSUSRQDT", JdeDataType.Date),
        new JdeField("SSWTBID", "SSWTBID", JdeDataType.Numeric),
        new JdeField("SSBNCHID", "SSBNCHID", JdeDataType.Numeric),
        new JdeField("SSCWLOTN", "SSCWLOTN", JdeDataType.String, 60),
        new JdeField("SSCWVID", "SSCWVID", JdeDataType.Numeric),
        new JdeField("SSCMCU", "SSCMCU", JdeDataType.String, 24),
        new JdeField("SSMCU", "SSMCU", JdeDataType.String, 24),
        new JdeField("SSWVNUM", "SSWVNUM", JdeDataType.String, 60),
        new JdeField("SSWVTY", "SSWVTY", JdeDataType.String, 2),
        new JdeField("SSWVID", "SSWVID", JdeDataType.Numeric),
        new JdeField("SSWBID", "SSWBID", JdeDataType.String, 60),
        new JdeField("SSQTST", "SSQTST", JdeDataType.String, 50),
        new JdeField("SSTSTRSNM", "SSTSTRSNM", JdeDataType.String, 60),
        new JdeField("SSRSSTS", "SSRSSTS", JdeDataType.String, 2),
        new JdeField("SSDL01", "SSDL01", JdeDataType.String, 60),
        new JdeField("SSWOPID", "SSWOPID", JdeDataType.Numeric),
        new JdeField("SSWCFGID", "SSWCFGID", JdeDataType.Numeric),
        new JdeField("SSWCDL01", "SSWCDL01", JdeDataType.String, 60),
        new JdeField("SSWCOPCD", "SSWCOPCD", JdeDataType.String, 20),
        new JdeField("SSWOPN", "SSWOPN", JdeDataType.Numeric),
        new JdeField("SSWSD", "SSWSD", JdeDataType.String, 60),
        new JdeField("SSWOPST", "SSWOPST", JdeDataType.String, 20),
        new JdeField("SSWDOCO", "SSWDOCO", JdeDataType.Numeric),
        new JdeField("SSWJOBN", "SSWJOBN", JdeDataType.Numeric),
        new JdeField("SSQTC1", "SSQTC1", JdeDataType.String, 6),
        new JdeField("SSQTC2", "SSQTC2", JdeDataType.String, 6),
        new JdeField("SSQTC3", "SSQTC3", JdeDataType.String, 6),
        new JdeField("SSQTC4", "SSQTC4", JdeDataType.String, 6),
        new JdeField("SSQTC5", "SSQTC5", JdeDataType.String, 6),
        new JdeField("SSWTBNAME", "SSWTBNAME", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B62_0", "Primary Key on SSWFSSID, SSWLN", new[] { "SSWFSSID", "SSWLN" }, isUnique: true, isPrimaryKey: true)
    };
}
