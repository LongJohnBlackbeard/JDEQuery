using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101B - .
/// </summary>
public class F4101B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMMCU.
        /// </summary>
        public const string IMMCU = "IMMCU";

        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMSTAW.
        /// </summary>
        public const string IMSTAW = "IMSTAW";

        /// <summary>
        /// IMEFFT.
        /// </summary>
        public const string IMEFFT = "IMEFFT";

        /// <summary>
        /// IMDOC.
        /// </summary>
        public const string IMDOC = "IMDOC";

        /// <summary>
        /// IMDCT.
        /// </summary>
        public const string IMDCT = "IMDCT";

        /// <summary>
        /// IMEFFF.
        /// </summary>
        public const string IMEFFF = "IMEFFF";

        /// <summary>
        /// IMSERK.
        /// </summary>
        public const string IMSERK = "IMSERK";

        /// <summary>
        /// IMPDGR.
        /// </summary>
        public const string IMPDGR = "IMPDGR";

        /// <summary>
        /// IMDSGP.
        /// </summary>
        public const string IMDSGP = "IMDSGP";

        /// <summary>
        /// IMDNTB.
        /// </summary>
        public const string IMDNTB = "IMDNTB";

        /// <summary>
        /// IMSTCN.
        /// </summary>
        public const string IMSTCN = "IMSTCN";

        /// <summary>
        /// IMRPTM.
        /// </summary>
        public const string IMRPTM = "IMRPTM";

        /// <summary>
        /// IMRQTC.
        /// </summary>
        public const string IMRQTC = "IMRQTC";

        /// <summary>
        /// IMLPGP.
        /// </summary>
        public const string IMLPGP = "IMLPGP";

        /// <summary>
        /// IMCAVP.
        /// </summary>
        public const string IMCAVP = "IMCAVP";

        /// <summary>
        /// IMDNTY.
        /// </summary>
        public const string IMDNTY = "IMDNTY";

        /// <summary>
        /// IMDNTP.
        /// </summary>
        public const string IMDNTP = "IMDNTP";

        /// <summary>
        /// IMDETP.
        /// </summary>
        public const string IMDETP = "IMDETP";

        /// <summary>
        /// IMDTPU.
        /// </summary>
        public const string IMDTPU = "IMDTPU";

        /// <summary>
        /// IMCOEX.
        /// </summary>
        public const string IMCOEX = "IMCOEX";

        /// <summary>
        /// IMTMMN.
        /// </summary>
        public const string IMTMMN = "IMTMMN";

        /// <summary>
        /// IMTPUM.
        /// </summary>
        public const string IMTPUM = "IMTPUM";

        /// <summary>
        /// IMTMMX.
        /// </summary>
        public const string IMTMMX = "IMTMMX";

        /// <summary>
        /// IMTPUX.
        /// </summary>
        public const string IMTPUX = "IMTPUX";

        /// <summary>
        /// IMDSMN.
        /// </summary>
        public const string IMDSMN = "IMDSMN";

        /// <summary>
        /// IMDNTM.
        /// </summary>
        public const string IMDNTM = "IMDNTM";

        /// <summary>
        /// IMDNMX.
        /// </summary>
        public const string IMDNMX = "IMDNMX";

        /// <summary>
        /// IMDNTX.
        /// </summary>
        public const string IMDNTX = "IMDNTX";

        /// <summary>
        /// IMLPGV.
        /// </summary>
        public const string IMLPGV = "IMLPGV";

        /// <summary>
        /// IMTPU1.
        /// </summary>
        public const string IMTPU1 = "IMTPU1";

        /// <summary>
        /// IMMNVC.
        /// </summary>
        public const string IMMNVC = "IMMNVC";

        /// <summary>
        /// IMMXVC.
        /// </summary>
        public const string IMMXVC = "IMMXVC";

        /// <summary>
        /// IMSTVL.
        /// </summary>
        public const string IMSTVL = "IMSTVL";

        /// <summary>
        /// IMBUM0.
        /// </summary>
        public const string IMBUM0 = "IMBUM0";

        /// <summary>
        /// IMLRFG.
        /// </summary>
        public const string IMLRFG = "IMLRFG";

        /// <summary>
        /// IMHCOR.
        /// </summary>
        public const string IMHCOR = "IMHCOR";

        /// <summary>
        /// IMACOR.
        /// </summary>
        public const string IMACOR = "IMACOR";

        /// <summary>
        /// IMABBL.
        /// </summary>
        public const string IMABBL = "IMABBL";

        /// <summary>
        /// IMATWH.
        /// </summary>
        public const string IMATWH = "IMATWH";

        /// <summary>
        /// IMRPLT.
        /// </summary>
        public const string IMRPLT = "IMRPLT";

        /// <summary>
        /// IMBCAT.
        /// </summary>
        public const string IMBCAT = "IMBCAT";

        /// <summary>
        /// IMFCAT.
        /// </summary>
        public const string IMFCAT = "IMFCAT";

        /// <summary>
        /// IMRECD.
        /// </summary>
        public const string IMRECD = "IMRECD";

        /// <summary>
        /// IMRTOB.
        /// </summary>
        public const string IMRTOB = "IMRTOB";

        /// <summary>
        /// IMURCD.
        /// </summary>
        public const string IMURCD = "IMURCD";

        /// <summary>
        /// IMURAT.
        /// </summary>
        public const string IMURAT = "IMURAT";

        /// <summary>
        /// IMURAB.
        /// </summary>
        public const string IMURAB = "IMURAB";

        /// <summary>
        /// IMURRF.
        /// </summary>
        public const string IMURRF = "IMURRF";

        /// <summary>
        /// IMURDT.
        /// </summary>
        public const string IMURDT = "IMURDT";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMTDAY.
        /// </summary>
        public const string IMTDAY = "IMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4101B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMMCU", "IMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMSTAW", "IMSTAW", JdeDataType.String, 2, true, true),
        new JdeField("IMEFFT", "IMEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDOC", "IMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDCT", "IMDCT", JdeDataType.String, 4, true, true),
        new JdeField("IMEFFF", "IMEFFF", JdeDataType.Numeric),
        new JdeField("IMSERK", "IMSERK", JdeDataType.Numeric),
        new JdeField("IMPDGR", "IMPDGR", JdeDataType.String, 6),
        new JdeField("IMDSGP", "IMDSGP", JdeDataType.String, 6),
        new JdeField("IMDNTB", "IMDNTB", JdeDataType.String, 8),
        new JdeField("IMSTCN", "IMSTCN", JdeDataType.String, 8),
        new JdeField("IMRPTM", "IMRPTM", JdeDataType.String, 8),
        new JdeField("IMRQTC", "IMRQTC", JdeDataType.String, 2),
        new JdeField("IMLPGP", "IMLPGP", JdeDataType.String, 2),
        new JdeField("IMCAVP", "IMCAVP", JdeDataType.String, 2),
        new JdeField("IMDNTY", "IMDNTY", JdeDataType.Numeric),
        new JdeField("IMDNTP", "IMDNTP", JdeDataType.String, 2),
        new JdeField("IMDETP", "IMDETP", JdeDataType.Numeric),
        new JdeField("IMDTPU", "IMDTPU", JdeDataType.String, 2),
        new JdeField("IMCOEX", "IMCOEX", JdeDataType.Numeric),
        new JdeField("IMTMMN", "IMTMMN", JdeDataType.Numeric),
        new JdeField("IMTPUM", "IMTPUM", JdeDataType.String, 2),
        new JdeField("IMTMMX", "IMTMMX", JdeDataType.Numeric),
        new JdeField("IMTPUX", "IMTPUX", JdeDataType.String, 2),
        new JdeField("IMDSMN", "IMDSMN", JdeDataType.Numeric),
        new JdeField("IMDNTM", "IMDNTM", JdeDataType.String, 2),
        new JdeField("IMDNMX", "IMDNMX", JdeDataType.Numeric),
        new JdeField("IMDNTX", "IMDNTX", JdeDataType.String, 2),
        new JdeField("IMLPGV", "IMLPGV", JdeDataType.Numeric),
        new JdeField("IMTPU1", "IMTPU1", JdeDataType.String, 2),
        new JdeField("IMMNVC", "IMMNVC", JdeDataType.Numeric),
        new JdeField("IMMXVC", "IMMXVC", JdeDataType.Numeric),
        new JdeField("IMSTVL", "IMSTVL", JdeDataType.Numeric),
        new JdeField("IMBUM0", "IMBUM0", JdeDataType.String, 4),
        new JdeField("IMLRFG", "IMLRFG", JdeDataType.String, 2),
        new JdeField("IMHCOR", "IMHCOR", JdeDataType.String, 2),
        new JdeField("IMACOR", "IMACOR", JdeDataType.String, 2),
        new JdeField("IMABBL", "IMABBL", JdeDataType.String, 2),
        new JdeField("IMATWH", "IMATWH", JdeDataType.String, 2),
        new JdeField("IMRPLT", "IMRPLT", JdeDataType.String, 6),
        new JdeField("IMBCAT", "IMBCAT", JdeDataType.String, 6),
        new JdeField("IMFCAT", "IMFCAT", JdeDataType.String, 6),
        new JdeField("IMRECD", "IMRECD", JdeDataType.Numeric),
        new JdeField("IMRTOB", "IMRTOB", JdeDataType.String, 2),
        new JdeField("IMURCD", "IMURCD", JdeDataType.String, 4),
        new JdeField("IMURAT", "IMURAT", JdeDataType.Numeric),
        new JdeField("IMURAB", "IMURAB", JdeDataType.Numeric),
        new JdeField("IMURRF", "IMURRF", JdeDataType.String, 30),
        new JdeField("IMURDT", "IMURDT", JdeDataType.Numeric),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101B_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
