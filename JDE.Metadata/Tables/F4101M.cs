using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101M - .
/// </summary>
public class F4101M : JdeTable
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
        /// IMITBR.
        /// </summary>
        public const string IMITBR = "IMITBR";

        /// <summary>
        /// IMDRAW.
        /// </summary>
        public const string IMDRAW = "IMDRAW";

        /// <summary>
        /// IMRVNO.
        /// </summary>
        public const string IMRVNO = "IMRVNO";

        /// <summary>
        /// IMDSZE.
        /// </summary>
        public const string IMDSZE = "IMDSZE";

        /// <summary>
        /// IMMPST.
        /// </summary>
        public const string IMMPST = "IMMPST";

        /// <summary>
        /// IMSNS.
        /// </summary>
        public const string IMSNS = "IMSNS";

        /// <summary>
        /// IMLTLV.
        /// </summary>
        public const string IMLTLV = "IMLTLV";

        /// <summary>
        /// IMLTMF.
        /// </summary>
        public const string IMLTMF = "IMLTMF";

        /// <summary>
        /// IMLTCM.
        /// </summary>
        public const string IMLTCM = "IMLTCM";

        /// <summary>
        /// IMOPC.
        /// </summary>
        public const string IMOPC = "IMOPC";

        /// <summary>
        /// IMOPV.
        /// </summary>
        public const string IMOPV = "IMOPV";

        /// <summary>
        /// IMACQ.
        /// </summary>
        public const string IMACQ = "IMACQ";

        /// <summary>
        /// IMMLQ.
        /// </summary>
        public const string IMMLQ = "IMMLQ";

        /// <summary>
        /// IMLTPU.
        /// </summary>
        public const string IMLTPU = "IMLTPU";

        /// <summary>
        /// IMMPSP.
        /// </summary>
        public const string IMMPSP = "IMMPSP";

        /// <summary>
        /// IMMRPP.
        /// </summary>
        public const string IMMRPP = "IMMRPP";

        /// <summary>
        /// IMITC.
        /// </summary>
        public const string IMITC = "IMITC";

        /// <summary>
        /// IMMTF1.
        /// </summary>
        public const string IMMTF1 = "IMMTF1";

        /// <summary>
        /// IMMTF2.
        /// </summary>
        public const string IMMTF2 = "IMMTF2";

        /// <summary>
        /// IMMTF3.
        /// </summary>
        public const string IMMTF3 = "IMMTF3";

        /// <summary>
        /// IMMTF4.
        /// </summary>
        public const string IMMTF4 = "IMMTF4";

        /// <summary>
        /// IMMTF5.
        /// </summary>
        public const string IMMTF5 = "IMMTF5";

        /// <summary>
        /// IMTIMB.
        /// </summary>
        public const string IMTIMB = "IMTIMB";

        /// <summary>
        /// IMQUED.
        /// </summary>
        public const string IMQUED = "IMQUED";

        /// <summary>
        /// IMSETL.
        /// </summary>
        public const string IMSETL = "IMSETL";

        /// <summary>
        /// IMOT1Y.
        /// </summary>
        public const string IMOT1Y = "IMOT1Y";

        /// <summary>
        /// IMOT2Y.
        /// </summary>
        public const string IMOT2Y = "IMOT2Y";

        /// <summary>
        /// IMSTDP.
        /// </summary>
        public const string IMSTDP = "IMSTDP";

        /// <summary>
        /// IMFRMP.
        /// </summary>
        public const string IMFRMP = "IMFRMP";

        /// <summary>
        /// IMTHRP.
        /// </summary>
        public const string IMTHRP = "IMTHRP";

        /// <summary>
        /// IMSRNK.
        /// </summary>
        public const string IMSRNK = "IMSRNK";

        /// <summary>
        /// IMSRKF.
        /// </summary>
        public const string IMSRKF = "IMSRKF";

        /// <summary>
        /// IMMERL.
        /// </summary>
        public const string IMMERL = "IMMERL";

        /// <summary>
        /// IMSTDG.
        /// </summary>
        public const string IMSTDG = "IMSTDG";

        /// <summary>
        /// IMFRGD.
        /// </summary>
        public const string IMFRGD = "IMFRGD";

        /// <summary>
        /// IMTHGD.
        /// </summary>
        public const string IMTHGD = "IMTHGD";

        /// <summary>
        /// IMECO.
        /// </summary>
        public const string IMECO = "IMECO";

        /// <summary>
        /// IMECTY.
        /// </summary>
        public const string IMECTY = "IMECTY";

        /// <summary>
        /// IMECOD.
        /// </summary>
        public const string IMECOD = "IMECOD";

        /// <summary>
        /// IMPOC.
        /// </summary>
        public const string IMPOC = "IMPOC";

        /// <summary>
        /// IMAVRT.
        /// </summary>
        public const string IMAVRT = "IMAVRT";

        /// <summary>
        /// IMPTSC.
        /// </summary>
        public const string IMPTSC = "IMPTSC";

        /// <summary>
        /// IMPRPO.
        /// </summary>
        public const string IMPRPO = "IMPRPO";

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

        /// <summary>
        /// IMAING.
        /// </summary>
        public const string IMAING = "IMAING";

        /// <summary>
        /// IMCONB.
        /// </summary>
        public const string IMCONB = "IMCONB";

        /// <summary>
        /// IMPRI1.
        /// </summary>
        public const string IMPRI1 = "IMPRI1";

        /// <summary>
        /// IMPRI2.
        /// </summary>
        public const string IMPRI2 = "IMPRI2";

        /// <summary>
        /// IMGCMP.
        /// </summary>
        public const string IMGCMP = "IMGCMP";

        /// <summary>
        /// IMAPSC.
        /// </summary>
        public const string IMAPSC = "IMAPSC";

        /// <summary>
        /// IMLTCV.
        /// </summary>
        public const string IMLTCV = "IMLTCV";

        /// <summary>
        /// IMEXPI.
        /// </summary>
        public const string IMEXPI = "IMEXPI";

        /// <summary>
        /// IMKBIT.
        /// </summary>
        public const string IMKBIT = "IMKBIT";

        /// <summary>
        /// IMOPTH.
        /// </summary>
        public const string IMOPTH = "IMOPTH";

        /// <summary>
        /// IMCUTH.
        /// </summary>
        public const string IMCUTH = "IMCUTH";

        /// <summary>
        /// IMUMTH.
        /// </summary>
        public const string IMUMTH = "IMUMTH";

        /// <summary>
        /// IMLMFG.
        /// </summary>
        public const string IMLMFG = "IMLMFG";

        /// <summary>
        /// IMLINE.
        /// </summary>
        public const string IMLINE = "IMLINE";

        /// <summary>
        /// IMDFTPCT.
        /// </summary>
        public const string IMDFTPCT = "IMDFTPCT";

        /// <summary>
        /// IMDFENDITM.
        /// </summary>
        public const string IMDFENDITM = "IMDFENDITM";

        /// <summary>
        /// IMKANEXLL.
        /// </summary>
        public const string IMKANEXLL = "IMKANEXLL";

        /// <summary>
        /// IMSCPSELL.
        /// </summary>
        public const string IMSCPSELL = "IMSCPSELL";

        /// <summary>
        /// IMMOPTH.
        /// </summary>
        public const string IMMOPTH = "IMMOPTH";

        /// <summary>
        /// IMMCUTH.
        /// </summary>
        public const string IMMCUTH = "IMMCUTH";

        /// <summary>
        /// IMCUMTH.
        /// </summary>
        public const string IMCUMTH = "IMCUMTH";

        /// <summary>
        /// IMATPRN.
        /// </summary>
        public const string IMATPRN = "IMATPRN";

        /// <summary>
        /// IMATPCA.
        /// </summary>
        public const string IMATPCA = "IMATPCA";

        /// <summary>
        /// IMATPAC.
        /// </summary>
        public const string IMATPAC = "IMATPAC";

        /// <summary>
        /// IMVCPFC.
        /// </summary>
        public const string IMVCPFC = "IMVCPFC";
    }

    /// <inheritdoc />
    public override string TableName => "F4101M";

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
        new JdeField("IMITBR", "IMITBR", JdeDataType.String, 2),
        new JdeField("IMDRAW", "IMDRAW", JdeDataType.String, 40),
        new JdeField("IMRVNO", "IMRVNO", JdeDataType.String, 4),
        new JdeField("IMDSZE", "IMDSZE", JdeDataType.String, 2),
        new JdeField("IMMPST", "IMMPST", JdeDataType.String, 2),
        new JdeField("IMSNS", "IMSNS", JdeDataType.String, 2),
        new JdeField("IMLTLV", "IMLTLV", JdeDataType.Numeric),
        new JdeField("IMLTMF", "IMLTMF", JdeDataType.Numeric),
        new JdeField("IMLTCM", "IMLTCM", JdeDataType.Numeric),
        new JdeField("IMOPC", "IMOPC", JdeDataType.String, 2),
        new JdeField("IMOPV", "IMOPV", JdeDataType.Numeric),
        new JdeField("IMACQ", "IMACQ", JdeDataType.Numeric),
        new JdeField("IMMLQ", "IMMLQ", JdeDataType.Numeric),
        new JdeField("IMLTPU", "IMLTPU", JdeDataType.Numeric),
        new JdeField("IMMPSP", "IMMPSP", JdeDataType.String, 2),
        new JdeField("IMMRPP", "IMMRPP", JdeDataType.String, 2),
        new JdeField("IMITC", "IMITC", JdeDataType.String, 2),
        new JdeField("IMMTF1", "IMMTF1", JdeDataType.Numeric),
        new JdeField("IMMTF2", "IMMTF2", JdeDataType.Numeric),
        new JdeField("IMMTF3", "IMMTF3", JdeDataType.Numeric),
        new JdeField("IMMTF4", "IMMTF4", JdeDataType.Numeric),
        new JdeField("IMMTF5", "IMMTF5", JdeDataType.Numeric),
        new JdeField("IMTIMB", "IMTIMB", JdeDataType.String, 2),
        new JdeField("IMQUED", "IMQUED", JdeDataType.Numeric),
        new JdeField("IMSETL", "IMSETL", JdeDataType.Numeric),
        new JdeField("IMOT1Y", "IMOT1Y", JdeDataType.String, 2),
        new JdeField("IMOT2Y", "IMOT2Y", JdeDataType.String, 2),
        new JdeField("IMSTDP", "IMSTDP", JdeDataType.Numeric),
        new JdeField("IMFRMP", "IMFRMP", JdeDataType.Numeric),
        new JdeField("IMTHRP", "IMTHRP", JdeDataType.Numeric),
        new JdeField("IMSRNK", "IMSRNK", JdeDataType.Numeric),
        new JdeField("IMSRKF", "IMSRKF", JdeDataType.String, 2),
        new JdeField("IMMERL", "IMMERL", JdeDataType.String, 6),
        new JdeField("IMSTDG", "IMSTDG", JdeDataType.String, 6),
        new JdeField("IMFRGD", "IMFRGD", JdeDataType.String, 6),
        new JdeField("IMTHGD", "IMTHGD", JdeDataType.String, 6),
        new JdeField("IMECO", "IMECO", JdeDataType.String, 24),
        new JdeField("IMECTY", "IMECTY", JdeDataType.String, 4),
        new JdeField("IMECOD", "IMECOD", JdeDataType.Numeric),
        new JdeField("IMPOC", "IMPOC", JdeDataType.String, 2),
        new JdeField("IMAVRT", "IMAVRT", JdeDataType.Numeric),
        new JdeField("IMPTSC", "IMPTSC", JdeDataType.String, 4),
        new JdeField("IMPRPO", "IMPRPO", JdeDataType.String, 2),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric),
        new JdeField("IMAING", "IMAING", JdeDataType.String, 2),
        new JdeField("IMCONB", "IMCONB", JdeDataType.String, 2),
        new JdeField("IMPRI1", "IMPRI1", JdeDataType.Numeric),
        new JdeField("IMPRI2", "IMPRI2", JdeDataType.Numeric),
        new JdeField("IMGCMP", "IMGCMP", JdeDataType.String, 2),
        new JdeField("IMAPSC", "IMAPSC", JdeDataType.String, 2),
        new JdeField("IMLTCV", "IMLTCV", JdeDataType.Numeric),
        new JdeField("IMEXPI", "IMEXPI", JdeDataType.String, 2),
        new JdeField("IMKBIT", "IMKBIT", JdeDataType.String, 2),
        new JdeField("IMOPTH", "IMOPTH", JdeDataType.Numeric),
        new JdeField("IMCUTH", "IMCUTH", JdeDataType.Numeric),
        new JdeField("IMUMTH", "IMUMTH", JdeDataType.String, 6),
        new JdeField("IMLMFG", "IMLMFG", JdeDataType.String, 2),
        new JdeField("IMLINE", "IMLINE", JdeDataType.String, 24),
        new JdeField("IMDFTPCT", "IMDFTPCT", JdeDataType.Numeric),
        new JdeField("IMDFENDITM", "IMDFENDITM", JdeDataType.String, 2),
        new JdeField("IMKANEXLL", "IMKANEXLL", JdeDataType.String, 2),
        new JdeField("IMSCPSELL", "IMSCPSELL", JdeDataType.String, 2),
        new JdeField("IMMOPTH", "IMMOPTH", JdeDataType.Numeric),
        new JdeField("IMMCUTH", "IMMCUTH", JdeDataType.Numeric),
        new JdeField("IMCUMTH", "IMCUMTH", JdeDataType.String, 6),
        new JdeField("IMATPRN", "IMATPRN", JdeDataType.String, 160),
        new JdeField("IMATPCA", "IMATPCA", JdeDataType.String, 2),
        new JdeField("IMATPAC", "IMATPAC", JdeDataType.String, 10),
        new JdeField("IMVCPFC", "IMVCPFC", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101M_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
