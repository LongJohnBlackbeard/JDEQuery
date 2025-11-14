using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31122S - .
/// </summary>
public class F31122S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTYST.
        /// </summary>
        public const string WTYST = "WTYST";

        /// <summary>
        /// WTDOCO.
        /// </summary>
        public const string WTDOCO = "WTDOCO";

        /// <summary>
        /// WTDCTO.
        /// </summary>
        public const string WTDCTO = "WTDCTO";

        /// <summary>
        /// WTAN8.
        /// </summary>
        public const string WTAN8 = "WTAN8";

        /// <summary>
        /// WTPRTR.
        /// </summary>
        public const string WTPRTR = "WTPRTR";

        /// <summary>
        /// WTKIT.
        /// </summary>
        public const string WTKIT = "WTKIT";

        /// <summary>
        /// WTKITL.
        /// </summary>
        public const string WTKITL = "WTKITL";

        /// <summary>
        /// WTKITA.
        /// </summary>
        public const string WTKITA = "WTKITA";

        /// <summary>
        /// WTMMCU.
        /// </summary>
        public const string WTMMCU = "WTMMCU";

        /// <summary>
        /// WTMCU.
        /// </summary>
        public const string WTMCU = "WTMCU";

        /// <summary>
        /// WTOPSQ.
        /// </summary>
        public const string WTOPSQ = "WTOPSQ";

        /// <summary>
        /// WTOPST.
        /// </summary>
        public const string WTOPST = "WTOPST";

        /// <summary>
        /// WTTYR.
        /// </summary>
        public const string WTTYR = "WTTYR";

        /// <summary>
        /// WTEXR.
        /// </summary>
        public const string WTEXR = "WTEXR";

        /// <summary>
        /// WTICU.
        /// </summary>
        public const string WTICU = "WTICU";

        /// <summary>
        /// WTDCT.
        /// </summary>
        public const string WTDCT = "WTDCT";

        /// <summary>
        /// WTDGL.
        /// </summary>
        public const string WTDGL = "WTDGL";

        /// <summary>
        /// WTPBDT.
        /// </summary>
        public const string WTPBDT = "WTPBDT";

        /// <summary>
        /// WTPBTM.
        /// </summary>
        public const string WTPBTM = "WTPBTM";

        /// <summary>
        /// WTPETM.
        /// </summary>
        public const string WTPETM = "WTPETM";

        /// <summary>
        /// WTSHFT.
        /// </summary>
        public const string WTSHFT = "WTSHFT";

        /// <summary>
        /// WTAPID.
        /// </summary>
        public const string WTAPID = "WTAPID";

        /// <summary>
        /// WTEBRT.
        /// </summary>
        public const string WTEBRT = "WTEBRT";

        /// <summary>
        /// WTHRT.
        /// </summary>
        public const string WTHRT = "WTHRT";

        /// <summary>
        /// WTHRW.
        /// </summary>
        public const string WTHRW = "WTHRW";

        /// <summary>
        /// WTHREQ.
        /// </summary>
        public const string WTHREQ = "WTHREQ";

        /// <summary>
        /// WTGPAY.
        /// </summary>
        public const string WTGPAY = "WTGPAY";

        /// <summary>
        /// WTSOQS.
        /// </summary>
        public const string WTSOQS = "WTSOQS";

        /// <summary>
        /// WTSOCN.
        /// </summary>
        public const string WTSOCN = "WTSOCN";

        /// <summary>
        /// WTUOM.
        /// </summary>
        public const string WTUOM = "WTUOM";

        /// <summary>
        /// WTSUMR.
        /// </summary>
        public const string WTSUMR = "WTSUMR";

        /// <summary>
        /// WTUSER.
        /// </summary>
        public const string WTUSER = "WTUSER";

        /// <summary>
        /// WTUPMJ.
        /// </summary>
        public const string WTUPMJ = "WTUPMJ";

        /// <summary>
        /// WTTDAY.
        /// </summary>
        public const string WTTDAY = "WTTDAY";

        /// <summary>
        /// WTPID.
        /// </summary>
        public const string WTPID = "WTPID";

        /// <summary>
        /// WTJOBN.
        /// </summary>
        public const string WTJOBN = "WTJOBN";

        /// <summary>
        /// WTUKID.
        /// </summary>
        public const string WTUKID = "WTUKID";

        /// <summary>
        /// WTRCD.
        /// </summary>
        public const string WTRCD = "WTRCD";

        /// <summary>
        /// WTSTH.
        /// </summary>
        public const string WTSTH = "WTSTH";

        /// <summary>
        /// WTLINE.
        /// </summary>
        public const string WTLINE = "WTLINE";

        /// <summary>
        /// WTURCD.
        /// </summary>
        public const string WTURCD = "WTURCD";

        /// <summary>
        /// WTURDT.
        /// </summary>
        public const string WTURDT = "WTURDT";

        /// <summary>
        /// WTURAT.
        /// </summary>
        public const string WTURAT = "WTURAT";

        /// <summary>
        /// WTURAB.
        /// </summary>
        public const string WTURAB = "WTURAB";

        /// <summary>
        /// WTURRF.
        /// </summary>
        public const string WTURRF = "WTURRF";

        /// <summary>
        /// WTACTB.
        /// </summary>
        public const string WTACTB = "WTACTB";

        /// <summary>
        /// WTNUMB.
        /// </summary>
        public const string WTNUMB = "WTNUMB";

        /// <summary>
        /// WTSOHR.
        /// </summary>
        public const string WTSOHR = "WTSOHR";

        /// <summary>
        /// WTSORE.
        /// </summary>
        public const string WTSORE = "WTSORE";
    }

    /// <inheritdoc />
    public override string TableName => "F31122S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTYST", "WTYST", JdeDataType.String, 2),
        new JdeField("WTDOCO", "WTDOCO", JdeDataType.Numeric),
        new JdeField("WTDCTO", "WTDCTO", JdeDataType.String, 4),
        new JdeField("WTAN8", "WTAN8", JdeDataType.Numeric),
        new JdeField("WTPRTR", "WTPRTR", JdeDataType.Numeric),
        new JdeField("WTKIT", "WTKIT", JdeDataType.Numeric),
        new JdeField("WTKITL", "WTKITL", JdeDataType.String, 50),
        new JdeField("WTKITA", "WTKITA", JdeDataType.String, 50),
        new JdeField("WTMMCU", "WTMMCU", JdeDataType.String, 24),
        new JdeField("WTMCU", "WTMCU", JdeDataType.String, 24),
        new JdeField("WTOPSQ", "WTOPSQ", JdeDataType.Numeric),
        new JdeField("WTOPST", "WTOPST", JdeDataType.String, 4),
        new JdeField("WTTYR", "WTTYR", JdeDataType.String, 2),
        new JdeField("WTEXR", "WTEXR", JdeDataType.String, 60),
        new JdeField("WTICU", "WTICU", JdeDataType.Numeric),
        new JdeField("WTDCT", "WTDCT", JdeDataType.String, 4),
        new JdeField("WTDGL", "WTDGL", JdeDataType.Numeric),
        new JdeField("WTPBDT", "WTPBDT", JdeDataType.Numeric),
        new JdeField("WTPBTM", "WTPBTM", JdeDataType.Numeric),
        new JdeField("WTPETM", "WTPETM", JdeDataType.Numeric),
        new JdeField("WTSHFT", "WTSHFT", JdeDataType.String, 2),
        new JdeField("WTAPID", "WTAPID", JdeDataType.String, 24),
        new JdeField("WTEBRT", "WTEBRT", JdeDataType.Numeric),
        new JdeField("WTHRT", "WTHRT", JdeDataType.Numeric),
        new JdeField("WTHRW", "WTHRW", JdeDataType.Numeric),
        new JdeField("WTHREQ", "WTHREQ", JdeDataType.Numeric),
        new JdeField("WTGPAY", "WTGPAY", JdeDataType.Numeric),
        new JdeField("WTSOQS", "WTSOQS", JdeDataType.Numeric),
        new JdeField("WTSOCN", "WTSOCN", JdeDataType.Numeric),
        new JdeField("WTUOM", "WTUOM", JdeDataType.String, 4),
        new JdeField("WTSUMR", "WTSUMR", JdeDataType.String, 2),
        new JdeField("WTUSER", "WTUSER", JdeDataType.String, 20),
        new JdeField("WTUPMJ", "WTUPMJ", JdeDataType.Numeric),
        new JdeField("WTTDAY", "WTTDAY", JdeDataType.Numeric),
        new JdeField("WTPID", "WTPID", JdeDataType.String, 20),
        new JdeField("WTJOBN", "WTJOBN", JdeDataType.String, 20),
        new JdeField("WTUKID", "WTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WTRCD", "WTRCD", JdeDataType.String, 6),
        new JdeField("WTSTH", "WTSTH", JdeDataType.Numeric),
        new JdeField("WTLINE", "WTLINE", JdeDataType.String, 24),
        new JdeField("WTURCD", "WTURCD", JdeDataType.String, 4),
        new JdeField("WTURDT", "WTURDT", JdeDataType.Numeric),
        new JdeField("WTURAT", "WTURAT", JdeDataType.Numeric),
        new JdeField("WTURAB", "WTURAB", JdeDataType.Numeric),
        new JdeField("WTURRF", "WTURRF", JdeDataType.String, 30),
        new JdeField("WTACTB", "WTACTB", JdeDataType.String, 20),
        new JdeField("WTNUMB", "WTNUMB", JdeDataType.Numeric),
        new JdeField("WTSOHR", "WTSOHR", JdeDataType.String, 2),
        new JdeField("WTSORE", "WTSORE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31122S_0", "Primary Key on WTUKID", new[] { "WTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
