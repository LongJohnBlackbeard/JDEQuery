using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L501 - .
/// </summary>
public class FF30L501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBFSCID.
        /// </summary>
        public const string IBFSCID = "IBFSCID";

        /// <summary>
        /// IBDFITM.
        /// </summary>
        public const string IBDFITM = "IBDFITM";

        /// <summary>
        /// IBDFLITM.
        /// </summary>
        public const string IBDFLITM = "IBDFLITM";

        /// <summary>
        /// IBDFAITM.
        /// </summary>
        public const string IBDFAITM = "IBDFAITM";

        /// <summary>
        /// IBDFMCU.
        /// </summary>
        public const string IBDFMCU = "IBDFMCU";

        /// <summary>
        /// IBDSC1.
        /// </summary>
        public const string IBDSC1 = "IBDSC1";

        /// <summary>
        /// IBDSC2.
        /// </summary>
        public const string IBDSC2 = "IBDSC2";

        /// <summary>
        /// IBSRP1.
        /// </summary>
        public const string IBSRP1 = "IBSRP1";

        /// <summary>
        /// IBSRP2.
        /// </summary>
        public const string IBSRP2 = "IBSRP2";

        /// <summary>
        /// IBSRP3.
        /// </summary>
        public const string IBSRP3 = "IBSRP3";

        /// <summary>
        /// IBSRP4.
        /// </summary>
        public const string IBSRP4 = "IBSRP4";

        /// <summary>
        /// IBSRP5.
        /// </summary>
        public const string IBSRP5 = "IBSRP5";

        /// <summary>
        /// IBSRP6.
        /// </summary>
        public const string IBSRP6 = "IBSRP6";

        /// <summary>
        /// IBSRP7.
        /// </summary>
        public const string IBSRP7 = "IBSRP7";

        /// <summary>
        /// IBSRP8.
        /// </summary>
        public const string IBSRP8 = "IBSRP8";

        /// <summary>
        /// IBSRP9.
        /// </summary>
        public const string IBSRP9 = "IBSRP9";

        /// <summary>
        /// IBSRP0.
        /// </summary>
        public const string IBSRP0 = "IBSRP0";

        /// <summary>
        /// IBPRP1.
        /// </summary>
        public const string IBPRP1 = "IBPRP1";

        /// <summary>
        /// IBPRP2.
        /// </summary>
        public const string IBPRP2 = "IBPRP2";

        /// <summary>
        /// IBPRP3.
        /// </summary>
        public const string IBPRP3 = "IBPRP3";

        /// <summary>
        /// IBPRP4.
        /// </summary>
        public const string IBPRP4 = "IBPRP4";

        /// <summary>
        /// IBPRP5.
        /// </summary>
        public const string IBPRP5 = "IBPRP5";

        /// <summary>
        /// IBPRP6.
        /// </summary>
        public const string IBPRP6 = "IBPRP6";

        /// <summary>
        /// IBPRP7.
        /// </summary>
        public const string IBPRP7 = "IBPRP7";

        /// <summary>
        /// IBPRP8.
        /// </summary>
        public const string IBPRP8 = "IBPRP8";

        /// <summary>
        /// IBPRP9.
        /// </summary>
        public const string IBPRP9 = "IBPRP9";

        /// <summary>
        /// IBPRP0.
        /// </summary>
        public const string IBPRP0 = "IBPRP0";

        /// <summary>
        /// IBCDCD.
        /// </summary>
        public const string IBCDCD = "IBCDCD";

        /// <summary>
        /// IBPDGR.
        /// </summary>
        public const string IBPDGR = "IBPDGR";

        /// <summary>
        /// IBDSGP.
        /// </summary>
        public const string IBDSGP = "IBDSGP";

        /// <summary>
        /// IBDFVEND.
        /// </summary>
        public const string IBDFVEND = "IBDFVEND";

        /// <summary>
        /// IBDFANPL.
        /// </summary>
        public const string IBDFANPL = "IBDFANPL";

        /// <summary>
        /// IBDFBUYR.
        /// </summary>
        public const string IBDFBUYR = "IBDFBUYR";

        /// <summary>
        /// IBROPI.
        /// </summary>
        public const string IBROPI = "IBROPI";

        /// <summary>
        /// IBROQI.
        /// </summary>
        public const string IBROQI = "IBROQI";

        /// <summary>
        /// IBRQMX.
        /// </summary>
        public const string IBRQMX = "IBRQMX";

        /// <summary>
        /// IBRQMN.
        /// </summary>
        public const string IBRQMN = "IBRQMN";

        /// <summary>
        /// IBWOMO.
        /// </summary>
        public const string IBWOMO = "IBWOMO";

        /// <summary>
        /// IBSAFE.
        /// </summary>
        public const string IBSAFE = "IBSAFE";

        /// <summary>
        /// IBABCS.
        /// </summary>
        public const string IBABCS = "IBABCS";

        /// <summary>
        /// IBABCM.
        /// </summary>
        public const string IBABCM = "IBABCM";

        /// <summary>
        /// IBABCI.
        /// </summary>
        public const string IBABCI = "IBABCI";

        /// <summary>
        /// IBOVR.
        /// </summary>
        public const string IBOVR = "IBOVR";

        /// <summary>
        /// IBSHCM.
        /// </summary>
        public const string IBSHCM = "IBSHCM";

        /// <summary>
        /// IBSHCN.
        /// </summary>
        public const string IBSHCN = "IBSHCN";

        /// <summary>
        /// IBSTKT.
        /// </summary>
        public const string IBSTKT = "IBSTKT";

        /// <summary>
        /// IBLNTY.
        /// </summary>
        public const string IBLNTY = "IBLNTY";

        /// <summary>
        /// IBCYCL.
        /// </summary>
        public const string IBCYCL = "IBCYCL";

        /// <summary>
        /// IBINMG.
        /// </summary>
        public const string IBINMG = "IBINMG";

        /// <summary>
        /// IBMPST.
        /// </summary>
        public const string IBMPST = "IBMPST";

        /// <summary>
        /// IBSNS.
        /// </summary>
        public const string IBSNS = "IBSNS";

        /// <summary>
        /// IBMERL.
        /// </summary>
        public const string IBMERL = "IBMERL";

        /// <summary>
        /// IBDFLTLV.
        /// </summary>
        public const string IBDFLTLV = "IBDFLTLV";

        /// <summary>
        /// IBLTMF.
        /// </summary>
        public const string IBLTMF = "IBLTMF";

        /// <summary>
        /// IBLTCM.
        /// </summary>
        public const string IBLTCM = "IBLTCM";

        /// <summary>
        /// IBOPC.
        /// </summary>
        public const string IBOPC = "IBOPC";

        /// <summary>
        /// IBOPV.
        /// </summary>
        public const string IBOPV = "IBOPV";

        /// <summary>
        /// IBMLQ.
        /// </summary>
        public const string IBMLQ = "IBMLQ";

        /// <summary>
        /// IBLTPU.
        /// </summary>
        public const string IBLTPU = "IBLTPU";

        /// <summary>
        /// IBMPSP.
        /// </summary>
        public const string IBMPSP = "IBMPSP";

        /// <summary>
        /// IBMRPP.
        /// </summary>
        public const string IBMRPP = "IBMRPP";

        /// <summary>
        /// IBITC.
        /// </summary>
        public const string IBITC = "IBITC";

        /// <summary>
        /// IBMTF1.
        /// </summary>
        public const string IBMTF1 = "IBMTF1";

        /// <summary>
        /// IBMTF2.
        /// </summary>
        public const string IBMTF2 = "IBMTF2";

        /// <summary>
        /// IBMTF3.
        /// </summary>
        public const string IBMTF3 = "IBMTF3";

        /// <summary>
        /// IBMTF4.
        /// </summary>
        public const string IBMTF4 = "IBMTF4";

        /// <summary>
        /// IBMTF5.
        /// </summary>
        public const string IBMTF5 = "IBMTF5";

        /// <summary>
        /// IBMOVD.
        /// </summary>
        public const string IBMOVD = "IBMOVD";

        /// <summary>
        /// IBQUED.
        /// </summary>
        public const string IBQUED = "IBQUED";

        /// <summary>
        /// IBSETL.
        /// </summary>
        public const string IBSETL = "IBSETL";

        /// <summary>
        /// IBSRNK.
        /// </summary>
        public const string IBSRNK = "IBSRNK";

        /// <summary>
        /// IBSRKF.
        /// </summary>
        public const string IBSRKF = "IBSRKF";

        /// <summary>
        /// IBTIMB.
        /// </summary>
        public const string IBTIMB = "IBTIMB";

        /// <summary>
        /// IBBQTY.
        /// </summary>
        public const string IBBQTY = "IBBQTY";

        /// <summary>
        /// IBEXPD.
        /// </summary>
        public const string IBEXPD = "IBEXPD";

        /// <summary>
        /// IBDEFD.
        /// </summary>
        public const string IBDEFD = "IBDEFD";

        /// <summary>
        /// IBMULT.
        /// </summary>
        public const string IBMULT = "IBMULT";

        /// <summary>
        /// IBSFLT.
        /// </summary>
        public const string IBSFLT = "IBSFLT";

        /// <summary>
        /// IBMAKE.
        /// </summary>
        public const string IBMAKE = "IBMAKE";

        /// <summary>
        /// IBLLX.
        /// </summary>
        public const string IBLLX = "IBLLX";

        /// <summary>
        /// IBTFLA.
        /// </summary>
        public const string IBTFLA = "IBTFLA";

        /// <summary>
        /// IBAVRT.
        /// </summary>
        public const string IBAVRT = "IBAVRT";

        /// <summary>
        /// IBDFTPCT.
        /// </summary>
        public const string IBDFTPCT = "IBDFTPCT";

        /// <summary>
        /// IBDFLINE.
        /// </summary>
        public const string IBDFLINE = "IBDFLINE";

        /// <summary>
        /// IBLBLKAN.
        /// </summary>
        public const string IBLBLKAN = "IBLBLKAN";

        /// <summary>
        /// IBPKUOM.
        /// </summary>
        public const string IBPKUOM = "IBPKUOM";

        /// <summary>
        /// IBPKQTY.
        /// </summary>
        public const string IBPKQTY = "IBPKQTY";

        /// <summary>
        /// IBKANCONT.
        /// </summary>
        public const string IBKANCONT = "IBKANCONT";

        /// <summary>
        /// IBKANTYPE.
        /// </summary>
        public const string IBKANTYPE = "IBKANTYPE";

        /// <summary>
        /// IBDFENDITM.
        /// </summary>
        public const string IBDFENDITM = "IBDFENDITM";

        /// <summary>
        /// IBDFKMCF.
        /// </summary>
        public const string IBDFKMCF = "IBDFKMCF";

        /// <summary>
        /// IBKANEXLL.
        /// </summary>
        public const string IBKANEXLL = "IBKANEXLL";

        /// <summary>
        /// IBUOM1.
        /// </summary>
        public const string IBUOM1 = "IBUOM1";

        /// <summary>
        /// IBUOM2.
        /// </summary>
        public const string IBUOM2 = "IBUOM2";

        /// <summary>
        /// IBUOM3.
        /// </summary>
        public const string IBUOM3 = "IBUOM3";

        /// <summary>
        /// IBUOM4.
        /// </summary>
        public const string IBUOM4 = "IBUOM4";

        /// <summary>
        /// IBUOM6.
        /// </summary>
        public const string IBUOM6 = "IBUOM6";

        /// <summary>
        /// IBUOM8.
        /// </summary>
        public const string IBUOM8 = "IBUOM8";

        /// <summary>
        /// IBUOM9.
        /// </summary>
        public const string IBUOM9 = "IBUOM9";

        /// <summary>
        /// IBUWUM.
        /// </summary>
        public const string IBUWUM = "IBUWUM";

        /// <summary>
        /// IBUVM1.
        /// </summary>
        public const string IBUVM1 = "IBUVM1";

        /// <summary>
        /// IBURCD.
        /// </summary>
        public const string IBURCD = "IBURCD";

        /// <summary>
        /// IBURDT.
        /// </summary>
        public const string IBURDT = "IBURDT";

        /// <summary>
        /// IBURAT.
        /// </summary>
        public const string IBURAT = "IBURAT";

        /// <summary>
        /// IBURAB.
        /// </summary>
        public const string IBURAB = "IBURAB";

        /// <summary>
        /// IBURRF.
        /// </summary>
        public const string IBURRF = "IBURRF";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBMKEY.
        /// </summary>
        public const string IBMKEY = "IBMKEY";

        /// <summary>
        /// IBUUPMJ.
        /// </summary>
        public const string IBUUPMJ = "IBUUPMJ";

        /// <summary>
        /// IBDFLNID.
        /// </summary>
        public const string IBDFLNID = "IBDFLNID";

        /// <summary>
        /// IBDFMMCU.
        /// </summary>
        public const string IBDFMMCU = "IBDFMMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBFSCID", "IBFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("IBDFITM", "IBDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBDFLITM", "IBDFLITM", JdeDataType.String, 50),
        new JdeField("IBDFAITM", "IBDFAITM", JdeDataType.String, 50),
        new JdeField("IBDFMCU", "IBDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBDSC1", "IBDSC1", JdeDataType.String, 60),
        new JdeField("IBDSC2", "IBDSC2", JdeDataType.String, 60),
        new JdeField("IBSRP1", "IBSRP1", JdeDataType.String, 6),
        new JdeField("IBSRP2", "IBSRP2", JdeDataType.String, 6),
        new JdeField("IBSRP3", "IBSRP3", JdeDataType.String, 6),
        new JdeField("IBSRP4", "IBSRP4", JdeDataType.String, 6),
        new JdeField("IBSRP5", "IBSRP5", JdeDataType.String, 6),
        new JdeField("IBSRP6", "IBSRP6", JdeDataType.String, 12),
        new JdeField("IBSRP7", "IBSRP7", JdeDataType.String, 12),
        new JdeField("IBSRP8", "IBSRP8", JdeDataType.String, 12),
        new JdeField("IBSRP9", "IBSRP9", JdeDataType.String, 12),
        new JdeField("IBSRP0", "IBSRP0", JdeDataType.String, 12),
        new JdeField("IBPRP1", "IBPRP1", JdeDataType.String, 6),
        new JdeField("IBPRP2", "IBPRP2", JdeDataType.String, 6),
        new JdeField("IBPRP3", "IBPRP3", JdeDataType.String, 6),
        new JdeField("IBPRP4", "IBPRP4", JdeDataType.String, 6),
        new JdeField("IBPRP5", "IBPRP5", JdeDataType.String, 6),
        new JdeField("IBPRP6", "IBPRP6", JdeDataType.String, 12),
        new JdeField("IBPRP7", "IBPRP7", JdeDataType.String, 12),
        new JdeField("IBPRP8", "IBPRP8", JdeDataType.String, 12),
        new JdeField("IBPRP9", "IBPRP9", JdeDataType.String, 12),
        new JdeField("IBPRP0", "IBPRP0", JdeDataType.String, 12),
        new JdeField("IBCDCD", "IBCDCD", JdeDataType.String, 30),
        new JdeField("IBPDGR", "IBPDGR", JdeDataType.String, 6),
        new JdeField("IBDSGP", "IBDSGP", JdeDataType.String, 6),
        new JdeField("IBDFVEND", "IBDFVEND", JdeDataType.Numeric),
        new JdeField("IBDFANPL", "IBDFANPL", JdeDataType.Numeric),
        new JdeField("IBDFBUYR", "IBDFBUYR", JdeDataType.Numeric),
        new JdeField("IBROPI", "IBROPI", JdeDataType.Numeric),
        new JdeField("IBROQI", "IBROQI", JdeDataType.Numeric),
        new JdeField("IBRQMX", "IBRQMX", JdeDataType.Numeric),
        new JdeField("IBRQMN", "IBRQMN", JdeDataType.Numeric),
        new JdeField("IBWOMO", "IBWOMO", JdeDataType.Numeric),
        new JdeField("IBSAFE", "IBSAFE", JdeDataType.Numeric),
        new JdeField("IBABCS", "IBABCS", JdeDataType.String, 2),
        new JdeField("IBABCM", "IBABCM", JdeDataType.String, 2),
        new JdeField("IBABCI", "IBABCI", JdeDataType.String, 2),
        new JdeField("IBOVR", "IBOVR", JdeDataType.String, 2),
        new JdeField("IBSHCM", "IBSHCM", JdeDataType.String, 6),
        new JdeField("IBSHCN", "IBSHCN", JdeDataType.String, 6),
        new JdeField("IBSTKT", "IBSTKT", JdeDataType.String, 2),
        new JdeField("IBLNTY", "IBLNTY", JdeDataType.String, 4),
        new JdeField("IBCYCL", "IBCYCL", JdeDataType.String, 6),
        new JdeField("IBINMG", "IBINMG", JdeDataType.String, 20),
        new JdeField("IBMPST", "IBMPST", JdeDataType.String, 2),
        new JdeField("IBSNS", "IBSNS", JdeDataType.String, 2),
        new JdeField("IBMERL", "IBMERL", JdeDataType.String, 6),
        new JdeField("IBDFLTLV", "IBDFLTLV", JdeDataType.Numeric),
        new JdeField("IBLTMF", "IBLTMF", JdeDataType.Numeric),
        new JdeField("IBLTCM", "IBLTCM", JdeDataType.Numeric),
        new JdeField("IBOPC", "IBOPC", JdeDataType.String, 2),
        new JdeField("IBOPV", "IBOPV", JdeDataType.Numeric),
        new JdeField("IBMLQ", "IBMLQ", JdeDataType.Numeric),
        new JdeField("IBLTPU", "IBLTPU", JdeDataType.Numeric),
        new JdeField("IBMPSP", "IBMPSP", JdeDataType.String, 2),
        new JdeField("IBMRPP", "IBMRPP", JdeDataType.String, 2),
        new JdeField("IBITC", "IBITC", JdeDataType.String, 2),
        new JdeField("IBMTF1", "IBMTF1", JdeDataType.Numeric),
        new JdeField("IBMTF2", "IBMTF2", JdeDataType.Numeric),
        new JdeField("IBMTF3", "IBMTF3", JdeDataType.Numeric),
        new JdeField("IBMTF4", "IBMTF4", JdeDataType.Numeric),
        new JdeField("IBMTF5", "IBMTF5", JdeDataType.Numeric),
        new JdeField("IBMOVD", "IBMOVD", JdeDataType.Numeric),
        new JdeField("IBQUED", "IBQUED", JdeDataType.Numeric),
        new JdeField("IBSETL", "IBSETL", JdeDataType.Numeric),
        new JdeField("IBSRNK", "IBSRNK", JdeDataType.Numeric),
        new JdeField("IBSRKF", "IBSRKF", JdeDataType.String, 2),
        new JdeField("IBTIMB", "IBTIMB", JdeDataType.String, 2),
        new JdeField("IBBQTY", "IBBQTY", JdeDataType.Numeric),
        new JdeField("IBEXPD", "IBEXPD", JdeDataType.Numeric),
        new JdeField("IBDEFD", "IBDEFD", JdeDataType.Numeric),
        new JdeField("IBMULT", "IBMULT", JdeDataType.Numeric),
        new JdeField("IBSFLT", "IBSFLT", JdeDataType.Numeric),
        new JdeField("IBMAKE", "IBMAKE", JdeDataType.String, 2),
        new JdeField("IBLLX", "IBLLX", JdeDataType.Numeric),
        new JdeField("IBTFLA", "IBTFLA", JdeDataType.String, 4),
        new JdeField("IBAVRT", "IBAVRT", JdeDataType.Numeric),
        new JdeField("IBDFTPCT", "IBDFTPCT", JdeDataType.Numeric),
        new JdeField("IBDFLINE", "IBDFLINE", JdeDataType.String, 24),
        new JdeField("IBLBLKAN", "IBLBLKAN", JdeDataType.String, 6),
        new JdeField("IBPKUOM", "IBPKUOM", JdeDataType.String, 4),
        new JdeField("IBPKQTY", "IBPKQTY", JdeDataType.Numeric),
        new JdeField("IBKANCONT", "IBKANCONT", JdeDataType.String, 4),
        new JdeField("IBKANTYPE", "IBKANTYPE", JdeDataType.String, 6),
        new JdeField("IBDFENDITM", "IBDFENDITM", JdeDataType.String, 2),
        new JdeField("IBDFKMCF", "IBDFKMCF", JdeDataType.String, 2),
        new JdeField("IBKANEXLL", "IBKANEXLL", JdeDataType.String, 2),
        new JdeField("IBUOM1", "IBUOM1", JdeDataType.String, 4),
        new JdeField("IBUOM2", "IBUOM2", JdeDataType.String, 4),
        new JdeField("IBUOM3", "IBUOM3", JdeDataType.String, 4),
        new JdeField("IBUOM4", "IBUOM4", JdeDataType.String, 4),
        new JdeField("IBUOM6", "IBUOM6", JdeDataType.String, 4),
        new JdeField("IBUOM8", "IBUOM8", JdeDataType.String, 4),
        new JdeField("IBUOM9", "IBUOM9", JdeDataType.String, 4),
        new JdeField("IBUWUM", "IBUWUM", JdeDataType.String, 4),
        new JdeField("IBUVM1", "IBUVM1", JdeDataType.String, 4),
        new JdeField("IBURCD", "IBURCD", JdeDataType.String, 4),
        new JdeField("IBURDT", "IBURDT", JdeDataType.Numeric),
        new JdeField("IBURAT", "IBURAT", JdeDataType.Numeric),
        new JdeField("IBURAB", "IBURAB", JdeDataType.Numeric),
        new JdeField("IBURRF", "IBURRF", JdeDataType.String, 30),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBMKEY", "IBMKEY", JdeDataType.String, 30),
        new JdeField("IBUUPMJ", "IBUUPMJ", JdeDataType.Date),
        new JdeField("IBDFLNID", "IBDFLNID", JdeDataType.Numeric),
        new JdeField("IBDFMMCU", "IBDFMMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L501_0", "Primary Key on IBFSCID, IBDFMCU, IBDFITM", new[] { "IBFSCID", "IBDFMCU", "IBDFITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L501_11", "Index on IBFSCID, IBDFITM", new[] { "IBFSCID", "IBDFITM" }),
        new JdeIndex("FF30L501_12", "Index on IBFSCID, IBDFMCU, IBDFLITM", new[] { "IBFSCID", "IBDFMCU", "IBDFLITM" }),
        new JdeIndex("FF30L501_13", "Index on IBFSCID, IBDFMCU, IBDFAITM", new[] { "IBFSCID", "IBDFMCU", "IBDFAITM" }),
        new JdeIndex("FF30L501_14", "Index on IBFSCID, IBDFBUYR", new[] { "IBFSCID", "IBDFBUYR" }),
        new JdeIndex("FF30L501_15", "Index on IBFSCID, IBDFANPL", new[] { "IBFSCID", "IBDFANPL" }),
        new JdeIndex("FF30L501_16", "Index on IBFSCID, IBDFVEND", new[] { "IBFSCID", "IBDFVEND" }),
        new JdeIndex("FF30L501_17", "Index on IBFSCID", new[] { "IBFSCID" }),
        new JdeIndex("FF30L501_18", "Index on IBFSCID, IBDFLINE, IBDFMMCU", new[] { "IBFSCID", "IBDFLINE", "IBDFMMCU" }),
        new JdeIndex("FF30L501_2", "Index on IBDFITM, IBDFMCU", new[] { "IBDFITM", "IBDFMCU" })
    };
}
