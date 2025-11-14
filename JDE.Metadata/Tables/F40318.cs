using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40318 - .
/// </summary>
public class F40318 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QCAN8.
        /// </summary>
        public const string QCAN8 = "QCAN8";

        /// <summary>
        /// QCCS18.
        /// </summary>
        public const string QCCS18 = "QCCS18";

        /// <summary>
        /// QCITM.
        /// </summary>
        public const string QCITM = "QCITM";

        /// <summary>
        /// QCIT18.
        /// </summary>
        public const string QCIT18 = "QCIT18";

        /// <summary>
        /// QCEFTJ.
        /// </summary>
        public const string QCEFTJ = "QCEFTJ";

        /// <summary>
        /// QCEXDJ.
        /// </summary>
        public const string QCEXDJ = "QCEXDJ";

        /// <summary>
        /// QCMNQ.
        /// </summary>
        public const string QCMNQ = "QCMNQ";

        /// <summary>
        /// QCMXQ.
        /// </summary>
        public const string QCMXQ = "QCMXQ";

        /// <summary>
        /// QCUOM.
        /// </summary>
        public const string QCUOM = "QCUOM";

        /// <summary>
        /// QCSTAW.
        /// </summary>
        public const string QCSTAW = "QCSTAW";

        /// <summary>
        /// QCTXID.
        /// </summary>
        public const string QCTXID = "QCTXID";

        /// <summary>
        /// QCSTPR.
        /// </summary>
        public const string QCSTPR = "QCSTPR";

        /// <summary>
        /// QCOSEQ.
        /// </summary>
        public const string QCOSEQ = "QCOSEQ";

        /// <summary>
        /// QCEFFF.
        /// </summary>
        public const string QCEFFF = "QCEFFF";

        /// <summary>
        /// QCEFFT.
        /// </summary>
        public const string QCEFFT = "QCEFFT";

        /// <summary>
        /// QCQTSN.
        /// </summary>
        public const string QCQTSN = "QCQTSN";

        /// <summary>
        /// QCMCU.
        /// </summary>
        public const string QCMCU = "QCMCU";

        /// <summary>
        /// QCTSRT.
        /// </summary>
        public const string QCTSRT = "QCTSRT";

        /// <summary>
        /// QCQTST.
        /// </summary>
        public const string QCQTST = "QCQTST";

        /// <summary>
        /// QCTTTY.
        /// </summary>
        public const string QCTTTY = "QCTTTY";

        /// <summary>
        /// QCQREV.
        /// </summary>
        public const string QCQREV = "QCQREV";

        /// <summary>
        /// QCTSSP.
        /// </summary>
        public const string QCTSSP = "QCTSSP";

        /// <summary>
        /// QCMCU2.
        /// </summary>
        public const string QCMCU2 = "QCMCU2";

        /// <summary>
        /// QCSY.
        /// </summary>
        public const string QCSY = "QCSY";

        /// <summary>
        /// QCRT.
        /// </summary>
        public const string QCRT = "QCRT";

        /// <summary>
        /// QCAMIN.
        /// </summary>
        public const string QCAMIN = "QCAMIN";

        /// <summary>
        /// QCAMAX.
        /// </summary>
        public const string QCAMAX = "QCAMAX";

        /// <summary>
        /// QCPMIN.
        /// </summary>
        public const string QCPMIN = "QCPMIN";

        /// <summary>
        /// QCPMAX.
        /// </summary>
        public const string QCPMAX = "QCPMAX";

        /// <summary>
        /// QCQTRG.
        /// </summary>
        public const string QCQTRG = "QCQTRG";

        /// <summary>
        /// QCQSSZ.
        /// </summary>
        public const string QCQSSZ = "QCQSSZ";

        /// <summary>
        /// QCQUM.
        /// </summary>
        public const string QCQUM = "QCQUM";

        /// <summary>
        /// QCQSMP.
        /// </summary>
        public const string QCQSMP = "QCQSMP";

        /// <summary>
        /// QCSMPC.
        /// </summary>
        public const string QCSMPC = "QCSMPC";

        /// <summary>
        /// QCACQT.
        /// </summary>
        public const string QCACQT = "QCACQT";

        /// <summary>
        /// QCACPC.
        /// </summary>
        public const string QCACPC = "QCACPC";

        /// <summary>
        /// QCPTTS.
        /// </summary>
        public const string QCPTTS = "QCPTTS";

        /// <summary>
        /// QCMFGR.
        /// </summary>
        public const string QCMFGR = "QCMFGR";

        /// <summary>
        /// QCMRRR.
        /// </summary>
        public const string QCMRRR = "QCMRRR";

        /// <summary>
        /// QCPRER.
        /// </summary>
        public const string QCPRER = "QCPRER";

        /// <summary>
        /// QCPRCR.
        /// </summary>
        public const string QCPRCR = "QCPRCR";

        /// <summary>
        /// QCMFGC.
        /// </summary>
        public const string QCMFGC = "QCMFGC";

        /// <summary>
        /// QCSHPR.
        /// </summary>
        public const string QCSHPR = "QCSHPR";

        /// <summary>
        /// QCBLKR.
        /// </summary>
        public const string QCBLKR = "QCBLKR";

        /// <summary>
        /// QCOPSQ.
        /// </summary>
        public const string QCOPSQ = "QCOPSQ";

        /// <summary>
        /// QCOPRS.
        /// </summary>
        public const string QCOPRS = "QCOPRS";

        /// <summary>
        /// QCBSEQ.
        /// </summary>
        public const string QCBSEQ = "QCBSEQ";

        /// <summary>
        /// QCTRT.
        /// </summary>
        public const string QCTRT = "QCTRT";

        /// <summary>
        /// QCTMHD.
        /// </summary>
        public const string QCTMHD = "QCTMHD";

        /// <summary>
        /// QCRSUM.
        /// </summary>
        public const string QCRSUM = "QCRSUM";

        /// <summary>
        /// QCNUMB.
        /// </summary>
        public const string QCNUMB = "QCNUMB";

        /// <summary>
        /// QCASTM.
        /// </summary>
        public const string QCASTM = "QCASTM";

        /// <summary>
        /// QCQPRP.
        /// </summary>
        public const string QCQPRP = "QCQPRP";

        /// <summary>
        /// QCTTST.
        /// </summary>
        public const string QCTTST = "QCTTST";

        /// <summary>
        /// QCMMCU.
        /// </summary>
        public const string QCMMCU = "QCMMCU";

        /// <summary>
        /// QCCDEC.
        /// </summary>
        public const string QCCDEC = "QCCDEC";

        /// <summary>
        /// QCURCD.
        /// </summary>
        public const string QCURCD = "QCURCD";

        /// <summary>
        /// QCURDT.
        /// </summary>
        public const string QCURDT = "QCURDT";

        /// <summary>
        /// QCURAT.
        /// </summary>
        public const string QCURAT = "QCURAT";

        /// <summary>
        /// QCURRF.
        /// </summary>
        public const string QCURRF = "QCURRF";

        /// <summary>
        /// QCURAB.
        /// </summary>
        public const string QCURAB = "QCURAB";

        /// <summary>
        /// QCUKID.
        /// </summary>
        public const string QCUKID = "QCUKID";

        /// <summary>
        /// QCACTN.
        /// </summary>
        public const string QCACTN = "QCACTN";

        /// <summary>
        /// QCUSER.
        /// </summary>
        public const string QCUSER = "QCUSER";

        /// <summary>
        /// QCPID.
        /// </summary>
        public const string QCPID = "QCPID";

        /// <summary>
        /// QCUPMJ.
        /// </summary>
        public const string QCUPMJ = "QCUPMJ";

        /// <summary>
        /// QCTDAY.
        /// </summary>
        public const string QCTDAY = "QCTDAY";

        /// <summary>
        /// QCJOBN.
        /// </summary>
        public const string QCJOBN = "QCJOBN";

        /// <summary>
        /// QCDERC.
        /// </summary>
        public const string QCDERC = "QCDERC";
    }

    /// <inheritdoc />
    public override string TableName => "F40318";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QCAN8", "QCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("QCCS18", "QCCS18", JdeDataType.String, 16, true, true),
        new JdeField("QCITM", "QCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("QCIT18", "QCIT18", JdeDataType.String, 16, true, true),
        new JdeField("QCEFTJ", "QCEFTJ", JdeDataType.Numeric),
        new JdeField("QCEXDJ", "QCEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("QCMNQ", "QCMNQ", JdeDataType.Numeric),
        new JdeField("QCMXQ", "QCMXQ", JdeDataType.Numeric),
        new JdeField("QCUOM", "QCUOM", JdeDataType.String, 4),
        new JdeField("QCSTAW", "QCSTAW", JdeDataType.String, 2, true, true),
        new JdeField("QCTXID", "QCTXID", JdeDataType.Numeric),
        new JdeField("QCSTPR", "QCSTPR", JdeDataType.String, 2),
        new JdeField("QCOSEQ", "QCOSEQ", JdeDataType.Numeric),
        new JdeField("QCEFFF", "QCEFFF", JdeDataType.Numeric),
        new JdeField("QCEFFT", "QCEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("QCQTSN", "QCQTSN", JdeDataType.Numeric, null, true, true),
        new JdeField("QCMCU", "QCMCU", JdeDataType.String, 24, true, true),
        new JdeField("QCTSRT", "QCTSRT", JdeDataType.Numeric, null, true, true),
        new JdeField("QCQTST", "QCQTST", JdeDataType.String, 50),
        new JdeField("QCTTTY", "QCTTTY", JdeDataType.String, 2),
        new JdeField("QCQREV", "QCQREV", JdeDataType.String, 6),
        new JdeField("QCTSSP", "QCTSSP", JdeDataType.String, 2),
        new JdeField("QCMCU2", "QCMCU2", JdeDataType.String, 24),
        new JdeField("QCSY", "QCSY", JdeDataType.String, 8),
        new JdeField("QCRT", "QCRT", JdeDataType.String, 4),
        new JdeField("QCAMIN", "QCAMIN", JdeDataType.String, 30),
        new JdeField("QCAMAX", "QCAMAX", JdeDataType.String, 30),
        new JdeField("QCPMIN", "QCPMIN", JdeDataType.String, 30),
        new JdeField("QCPMAX", "QCPMAX", JdeDataType.String, 30),
        new JdeField("QCQTRG", "QCQTRG", JdeDataType.String, 30),
        new JdeField("QCQSSZ", "QCQSSZ", JdeDataType.Numeric),
        new JdeField("QCQUM", "QCQUM", JdeDataType.String, 6),
        new JdeField("QCQSMP", "QCQSMP", JdeDataType.Numeric),
        new JdeField("QCSMPC", "QCSMPC", JdeDataType.Numeric),
        new JdeField("QCACQT", "QCACQT", JdeDataType.Numeric),
        new JdeField("QCACPC", "QCACPC", JdeDataType.Numeric),
        new JdeField("QCPTTS", "QCPTTS", JdeDataType.String, 2),
        new JdeField("QCMFGR", "QCMFGR", JdeDataType.String, 2),
        new JdeField("QCMRRR", "QCMRRR", JdeDataType.String, 2),
        new JdeField("QCPRER", "QCPRER", JdeDataType.String, 2),
        new JdeField("QCPRCR", "QCPRCR", JdeDataType.String, 2),
        new JdeField("QCMFGC", "QCMFGC", JdeDataType.String, 2),
        new JdeField("QCSHPR", "QCSHPR", JdeDataType.String, 2),
        new JdeField("QCBLKR", "QCBLKR", JdeDataType.String, 2),
        new JdeField("QCOPSQ", "QCOPSQ", JdeDataType.Numeric),
        new JdeField("QCOPRS", "QCOPRS", JdeDataType.Numeric),
        new JdeField("QCBSEQ", "QCBSEQ", JdeDataType.Numeric),
        new JdeField("QCTRT", "QCTRT", JdeDataType.String, 6),
        new JdeField("QCTMHD", "QCTMHD", JdeDataType.String, 60),
        new JdeField("QCRSUM", "QCRSUM", JdeDataType.String, 6),
        new JdeField("QCNUMB", "QCNUMB", JdeDataType.Numeric),
        new JdeField("QCASTM", "QCASTM", JdeDataType.String, 60),
        new JdeField("QCQPRP", "QCQPRP", JdeDataType.String, 20),
        new JdeField("QCTTST", "QCTTST", JdeDataType.String, 2),
        new JdeField("QCMMCU", "QCMMCU", JdeDataType.String, 24),
        new JdeField("QCCDEC", "QCCDEC", JdeDataType.String, 2),
        new JdeField("QCURCD", "QCURCD", JdeDataType.String, 4),
        new JdeField("QCURDT", "QCURDT", JdeDataType.Numeric),
        new JdeField("QCURAT", "QCURAT", JdeDataType.Numeric),
        new JdeField("QCURRF", "QCURRF", JdeDataType.String, 30),
        new JdeField("QCURAB", "QCURAB", JdeDataType.Numeric),
        new JdeField("QCUKID", "QCUKID", JdeDataType.Numeric),
        new JdeField("QCACTN", "QCACTN", JdeDataType.String, 2),
        new JdeField("QCUSER", "QCUSER", JdeDataType.String, 20),
        new JdeField("QCPID", "QCPID", JdeDataType.String, 20),
        new JdeField("QCUPMJ", "QCUPMJ", JdeDataType.Numeric),
        new JdeField("QCTDAY", "QCTDAY", JdeDataType.Numeric),
        new JdeField("QCJOBN", "QCJOBN", JdeDataType.String, 20),
        new JdeField("QCDERC", "QCDERC", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40318_0", "Primary Key on QCAN8, QCCS18, QCITM, QCIT18, QCEXDJ, QCMCU, QCSTAW, QCEFFT, QCQTSN, QCTSRT", new[] { "QCAN8", "QCCS18", "QCITM", "QCIT18", "QCEXDJ", "QCMCU", "QCSTAW", "QCEFFT", "QCQTSN", "QCTSRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40318_3", "Index on QCQTST, QCMCU2, QCSTAW", new[] { "QCQTST", "QCMCU2", "QCSTAW" }),
        new JdeIndex("F40318_4", "Index on QCAN8, QCCS18, QCITM, QCIT18, QCEXDJ, QCMCU, QCSTAW, QCTSRT, QCEFFT, QCQTSN", new[] { "QCAN8", "QCCS18", "QCITM", "QCIT18", "QCEXDJ", "QCMCU", "QCSTAW", "QCTSRT", "QCEFFT", "QCQTSN" }),
        new JdeIndex("F40318_5", "Index on QCAN8, QCCS18, QCITM, QCIT18, QCEXDJ, QCMCU, QCSTAW, QCUKID", new[] { "QCAN8", "QCCS18", "QCITM", "QCIT18", "QCEXDJ", "QCMCU", "QCSTAW", "QCUKID" }),
        new JdeIndex("F40318_6", "Index on QCAN8, QCCS18, QCITM, QCIT18, QCSTAW, QCTSRT", new[] { "QCAN8", "QCCS18", "QCITM", "QCIT18", "QCSTAW", "QCTSRT" })
    };
}
