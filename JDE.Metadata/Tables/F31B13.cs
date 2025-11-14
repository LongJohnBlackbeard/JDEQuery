using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B13 - .
/// </summary>
public class F31B13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCMCU.
        /// </summary>
        public const string WCMCU = "WCMCU";

        /// <summary>
        /// WCWUMS.
        /// </summary>
        public const string WCWUMS = "WCWUMS";

        /// <summary>
        /// WCUMVL1.
        /// </summary>
        public const string WCUMVL1 = "WCUMVL1";

        /// <summary>
        /// WCUMWG1.
        /// </summary>
        public const string WCUMWG1 = "WCUMWG1";

        /// <summary>
        /// WCUMDM1.
        /// </summary>
        public const string WCUMDM1 = "WCUMDM1";

        /// <summary>
        /// WCUMAR1.
        /// </summary>
        public const string WCUMAR1 = "WCUMAR1";

        /// <summary>
        /// WCWUMP1.
        /// </summary>
        public const string WCWUMP1 = "WCWUMP1";

        /// <summary>
        /// WCUMT1.
        /// </summary>
        public const string WCUMT1 = "WCUMT1";

        /// <summary>
        /// WCWONN.
        /// </summary>
        public const string WCWONN = "WCWONN";

        /// <summary>
        /// WCWOPN.
        /// </summary>
        public const string WCWOPN = "WCWOPN";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURCD.
        /// </summary>
        public const string WCURCD = "WCURCD";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCSATTHR.
        /// </summary>
        public const string WCSATTHR = "WCSATTHR";

        /// <summary>
        /// WCBOLN.
        /// </summary>
        public const string WCBOLN = "WCBOLN";

        /// <summary>
        /// WCBSNN.
        /// </summary>
        public const string WCBSNN = "WCBSNN";

        /// <summary>
        /// WCINVUP.
        /// </summary>
        public const string WCINVUP = "WCINVUP";

        /// <summary>
        /// WCSGLT.
        /// </summary>
        public const string WCSGLT = "WCSGLT";

        /// <summary>
        /// WCBATP.
        /// </summary>
        public const string WCBATP = "WCBATP";

        /// <summary>
        /// WCOWNRCOD.
        /// </summary>
        public const string WCOWNRCOD = "WCOWNRCOD";

        /// <summary>
        /// WCWACTGM.
        /// </summary>
        public const string WCWACTGM = "WCWACTGM";

        /// <summary>
        /// WCWRF.
        /// </summary>
        public const string WCWRF = "WCWRF";

        /// <summary>
        /// WCWCD.
        /// </summary>
        public const string WCWCD = "WCWCD";

        /// <summary>
        /// WCWAB.
        /// </summary>
        public const string WCWAB = "WCWAB";

        /// <summary>
        /// WCWNUM.
        /// </summary>
        public const string WCWNUM = "WCWNUM";

        /// <summary>
        /// WCWMDT.
        /// </summary>
        public const string WCWMDT = "WCWMDT";

        /// <summary>
        /// WCBTMF.
        /// </summary>
        public const string WCBTMF = "WCBTMF";

        /// <summary>
        /// WCWQTYPOP.
        /// </summary>
        public const string WCWQTYPOP = "WCWQTYPOP";

        /// <summary>
        /// WCWQTYSOP.
        /// </summary>
        public const string WCWQTYSOP = "WCWQTYSOP";

        /// <summary>
        /// WCWTDOCNUM.
        /// </summary>
        public const string WCWTDOCNUM = "WCWTDOCNUM";

        /// <summary>
        /// WCWQTYBOP.
        /// </summary>
        public const string WCWQTYBOP = "WCWQTYBOP";

        /// <summary>
        /// WCWQTY4OP.
        /// </summary>
        public const string WCWQTY4OP = "WCWQTY4OP";

        /// <summary>
        /// WCWQTY5OP.
        /// </summary>
        public const string WCWQTY5OP = "WCWQTY5OP";

        /// <summary>
        /// WCWQTYPOH.
        /// </summary>
        public const string WCWQTYPOH = "WCWQTYPOH";

        /// <summary>
        /// WCWQTYSOH.
        /// </summary>
        public const string WCWQTYSOH = "WCWQTYSOH";

        /// <summary>
        /// WCWQTYBOH.
        /// </summary>
        public const string WCWQTYBOH = "WCWQTYBOH";

        /// <summary>
        /// WCWQTY4OH.
        /// </summary>
        public const string WCWQTY4OH = "WCWQTY4OH";

        /// <summary>
        /// WCWQTY5OH.
        /// </summary>
        public const string WCWQTY5OH = "WCWQTY5OH";

        /// <summary>
        /// WCDLAB.
        /// </summary>
        public const string WCDLAB = "WCDLAB";

        /// <summary>
        /// WCWTBSCT.
        /// </summary>
        public const string WCWTBSCT = "WCWTBSCT";

        /// <summary>
        /// WCVWI.
        /// </summary>
        public const string WCVWI = "WCVWI";

        /// <summary>
        /// WCWSVFLG.
        /// </summary>
        public const string WCWSVFLG = "WCWSVFLG";

        /// <summary>
        /// WCTSTRSNM.
        /// </summary>
        public const string WCTSTRSNM = "WCTSTRSNM";

        /// <summary>
        /// WCWTPEST.
        /// </summary>
        public const string WCWTPEST = "WCWTPEST";

        /// <summary>
        /// WCCTMF.
        /// </summary>
        public const string WCCTMF = "WCCTMF";

        /// <summary>
        /// WCSCUKID.
        /// </summary>
        public const string WCSCUKID = "WCSCUKID";

        /// <summary>
        /// WCACCRNG.
        /// </summary>
        public const string WCACCRNG = "WCACCRNG";

        /// <summary>
        /// WCDTTSTD.
        /// </summary>
        public const string WCDTTSTD = "WCDTTSTD";
    }

    /// <inheritdoc />
    public override string TableName => "F31B13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCMCU", "WCMCU", JdeDataType.String, 24, true, true),
        new JdeField("WCWUMS", "WCWUMS", JdeDataType.String, 2),
        new JdeField("WCUMVL1", "WCUMVL1", JdeDataType.String, 4),
        new JdeField("WCUMWG1", "WCUMWG1", JdeDataType.String, 4),
        new JdeField("WCUMDM1", "WCUMDM1", JdeDataType.String, 4),
        new JdeField("WCUMAR1", "WCUMAR1", JdeDataType.String, 4),
        new JdeField("WCWUMP1", "WCWUMP1", JdeDataType.String, 4),
        new JdeField("WCUMT1", "WCUMT1", JdeDataType.String, 4),
        new JdeField("WCWONN", "WCWONN", JdeDataType.Numeric),
        new JdeField("WCWOPN", "WCWOPN", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURCD", "WCURCD", JdeDataType.String, 4),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCSATTHR", "WCSATTHR", JdeDataType.Numeric),
        new JdeField("WCBOLN", "WCBOLN", JdeDataType.Numeric),
        new JdeField("WCBSNN", "WCBSNN", JdeDataType.Numeric),
        new JdeField("WCINVUP", "WCINVUP", JdeDataType.String, 2),
        new JdeField("WCSGLT", "WCSGLT", JdeDataType.Numeric),
        new JdeField("WCBATP", "WCBATP", JdeDataType.String, 8),
        new JdeField("WCOWNRCOD", "WCOWNRCOD", JdeDataType.String, 12),
        new JdeField("WCWACTGM", "WCWACTGM", JdeDataType.String, 2),
        new JdeField("WCWRF", "WCWRF", JdeDataType.String, 60),
        new JdeField("WCWCD", "WCWCD", JdeDataType.String, 6),
        new JdeField("WCWAB", "WCWAB", JdeDataType.Numeric),
        new JdeField("WCWNUM", "WCWNUM", JdeDataType.Numeric),
        new JdeField("WCWMDT", "WCWMDT", JdeDataType.Numeric),
        new JdeField("WCBTMF", "WCBTMF", JdeDataType.String, 2),
        new JdeField("WCWQTYPOP", "WCWQTYPOP", JdeDataType.String, 2),
        new JdeField("WCWQTYSOP", "WCWQTYSOP", JdeDataType.String, 2),
        new JdeField("WCWTDOCNUM", "WCWTDOCNUM", JdeDataType.Numeric),
        new JdeField("WCWQTYBOP", "WCWQTYBOP", JdeDataType.String, 2),
        new JdeField("WCWQTY4OP", "WCWQTY4OP", JdeDataType.String, 2),
        new JdeField("WCWQTY5OP", "WCWQTY5OP", JdeDataType.String, 2),
        new JdeField("WCWQTYPOH", "WCWQTYPOH", JdeDataType.String, 2),
        new JdeField("WCWQTYSOH", "WCWQTYSOH", JdeDataType.String, 2),
        new JdeField("WCWQTYBOH", "WCWQTYBOH", JdeDataType.String, 2),
        new JdeField("WCWQTY4OH", "WCWQTY4OH", JdeDataType.String, 2),
        new JdeField("WCWQTY5OH", "WCWQTY5OH", JdeDataType.String, 2),
        new JdeField("WCDLAB", "WCDLAB", JdeDataType.Numeric),
        new JdeField("WCWTBSCT", "WCWTBSCT", JdeDataType.Numeric),
        new JdeField("WCVWI", "WCVWI", JdeDataType.String, 2),
        new JdeField("WCWSVFLG", "WCWSVFLG", JdeDataType.String, 2),
        new JdeField("WCTSTRSNM", "WCTSTRSNM", JdeDataType.String, 60),
        new JdeField("WCWTPEST", "WCWTPEST", JdeDataType.String, 2),
        new JdeField("WCCTMF", "WCCTMF", JdeDataType.String, 2),
        new JdeField("WCSCUKID", "WCSCUKID", JdeDataType.Numeric),
        new JdeField("WCACCRNG", "WCACCRNG", JdeDataType.String, 2),
        new JdeField("WCDTTSTD", "WCDTTSTD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B13_0", "Primary Key on WCMCU", new[] { "WCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
