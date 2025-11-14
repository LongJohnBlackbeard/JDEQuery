using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101A - .
/// </summary>
public class F4101A : JdeTable
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
        /// IMLITM.
        /// </summary>
        public const string IMLITM = "IMLITM";

        /// <summary>
        /// IMAITM.
        /// </summary>
        public const string IMAITM = "IMAITM";

        /// <summary>
        /// IMDSC1.
        /// </summary>
        public const string IMDSC1 = "IMDSC1";

        /// <summary>
        /// IMDSC2.
        /// </summary>
        public const string IMDSC2 = "IMDSC2";

        /// <summary>
        /// IMSRTX.
        /// </summary>
        public const string IMSRTX = "IMSRTX";

        /// <summary>
        /// IMALN.
        /// </summary>
        public const string IMALN = "IMALN";

        /// <summary>
        /// IMCDCD.
        /// </summary>
        public const string IMCDCD = "IMCDCD";

        /// <summary>
        /// IMPDGR.
        /// </summary>
        public const string IMPDGR = "IMPDGR";

        /// <summary>
        /// IMDSGP.
        /// </summary>
        public const string IMDSGP = "IMDSGP";

        /// <summary>
        /// IMPRGR.
        /// </summary>
        public const string IMPRGR = "IMPRGR";

        /// <summary>
        /// IMRPRC.
        /// </summary>
        public const string IMRPRC = "IMRPRC";

        /// <summary>
        /// IMORPR.
        /// </summary>
        public const string IMORPR = "IMORPR";

        /// <summary>
        /// IMBUYR.
        /// </summary>
        public const string IMBUYR = "IMBUYR";

        /// <summary>
        /// IMVCUD.
        /// </summary>
        public const string IMVCUD = "IMVCUD";

        /// <summary>
        /// IMUOM1.
        /// </summary>
        public const string IMUOM1 = "IMUOM1";

        /// <summary>
        /// IMUOM2.
        /// </summary>
        public const string IMUOM2 = "IMUOM2";

        /// <summary>
        /// IMUOM3.
        /// </summary>
        public const string IMUOM3 = "IMUOM3";

        /// <summary>
        /// IMUOM4.
        /// </summary>
        public const string IMUOM4 = "IMUOM4";

        /// <summary>
        /// IMUOM6.
        /// </summary>
        public const string IMUOM6 = "IMUOM6";

        /// <summary>
        /// IMUOM8.
        /// </summary>
        public const string IMUOM8 = "IMUOM8";

        /// <summary>
        /// IMUOM9.
        /// </summary>
        public const string IMUOM9 = "IMUOM9";

        /// <summary>
        /// IMUWUM.
        /// </summary>
        public const string IMUWUM = "IMUWUM";

        /// <summary>
        /// IMUVM1.
        /// </summary>
        public const string IMUVM1 = "IMUVM1";

        /// <summary>
        /// IMSUTM.
        /// </summary>
        public const string IMSUTM = "IMSUTM";

        /// <summary>
        /// IMUMVW.
        /// </summary>
        public const string IMUMVW = "IMUMVW";

        /// <summary>
        /// IMGLPT.
        /// </summary>
        public const string IMGLPT = "IMGLPT";

        /// <summary>
        /// IMPLEV.
        /// </summary>
        public const string IMPLEV = "IMPLEV";

        /// <summary>
        /// IMPPLV.
        /// </summary>
        public const string IMPPLV = "IMPPLV";

        /// <summary>
        /// IMCLEV.
        /// </summary>
        public const string IMCLEV = "IMCLEV";

        /// <summary>
        /// IMCKAV.
        /// </summary>
        public const string IMCKAV = "IMCKAV";

        /// <summary>
        /// IMBPFG.
        /// </summary>
        public const string IMBPFG = "IMBPFG";

        /// <summary>
        /// IMSRCE.
        /// </summary>
        public const string IMSRCE = "IMSRCE";

        /// <summary>
        /// IMCOTY.
        /// </summary>
        public const string IMCOTY = "IMCOTY";

        /// <summary>
        /// IMSTKT.
        /// </summary>
        public const string IMSTKT = "IMSTKT";

        /// <summary>
        /// IMLNTY.
        /// </summary>
        public const string IMLNTY = "IMLNTY";

        /// <summary>
        /// IMCONT.
        /// </summary>
        public const string IMCONT = "IMCONT";

        /// <summary>
        /// IMBACK.
        /// </summary>
        public const string IMBACK = "IMBACK";

        /// <summary>
        /// IMIFLA.
        /// </summary>
        public const string IMIFLA = "IMIFLA";

        /// <summary>
        /// IMTFLA.
        /// </summary>
        public const string IMTFLA = "IMTFLA";

        /// <summary>
        /// IMINMG.
        /// </summary>
        public const string IMINMG = "IMINMG";

        /// <summary>
        /// IMABCS.
        /// </summary>
        public const string IMABCS = "IMABCS";

        /// <summary>
        /// IMABCM.
        /// </summary>
        public const string IMABCM = "IMABCM";

        /// <summary>
        /// IMABCI.
        /// </summary>
        public const string IMABCI = "IMABCI";

        /// <summary>
        /// IMOVR.
        /// </summary>
        public const string IMOVR = "IMOVR";

        /// <summary>
        /// IMWARR.
        /// </summary>
        public const string IMWARR = "IMWARR";

        /// <summary>
        /// IMCMCG.
        /// </summary>
        public const string IMCMCG = "IMCMCG";

        /// <summary>
        /// IMSRNR.
        /// </summary>
        public const string IMSRNR = "IMSRNR";

        /// <summary>
        /// IMPMTH.
        /// </summary>
        public const string IMPMTH = "IMPMTH";

        /// <summary>
        /// IMFIFO.
        /// </summary>
        public const string IMFIFO = "IMFIFO";

        /// <summary>
        /// IMLOTS.
        /// </summary>
        public const string IMLOTS = "IMLOTS";

        /// <summary>
        /// IMSLD.
        /// </summary>
        public const string IMSLD = "IMSLD";

        /// <summary>
        /// IMANPL.
        /// </summary>
        public const string IMANPL = "IMANPL";

        /// <summary>
        /// IMPCTM.
        /// </summary>
        public const string IMPCTM = "IMPCTM";

        /// <summary>
        /// IMMMPC.
        /// </summary>
        public const string IMMMPC = "IMMMPC";

        /// <summary>
        /// IMORDW.
        /// </summary>
        public const string IMORDW = "IMORDW";

        /// <summary>
        /// IMEXPD.
        /// </summary>
        public const string IMEXPD = "IMEXPD";

        /// <summary>
        /// IMDEFD.
        /// </summary>
        public const string IMDEFD = "IMDEFD";

        /// <summary>
        /// IMSFLT.
        /// </summary>
        public const string IMSFLT = "IMSFLT";

        /// <summary>
        /// IMMAKE.
        /// </summary>
        public const string IMMAKE = "IMMAKE";

        /// <summary>
        /// IMCOBY.
        /// </summary>
        public const string IMCOBY = "IMCOBY";

        /// <summary>
        /// IMLLX.
        /// </summary>
        public const string IMLLX = "IMLLX";

        /// <summary>
        /// IMCMGL.
        /// </summary>
        public const string IMCMGL = "IMCMGL";

        /// <summary>
        /// IMCOMH.
        /// </summary>
        public const string IMCOMH = "IMCOMH";

        /// <summary>
        /// IMVEND.
        /// </summary>
        public const string IMVEND = "IMVEND";

        /// <summary>
        /// IMORIG.
        /// </summary>
        public const string IMORIG = "IMORIG";

        /// <summary>
        /// IMWOMO.
        /// </summary>
        public const string IMWOMO = "IMWOMO";

        /// <summary>
        /// IMSERV.
        /// </summary>
        public const string IMSERV = "IMSERV";

        /// <summary>
        /// IMFUF1.
        /// </summary>
        public const string IMFUF1 = "IMFUF1";

        /// <summary>
        /// IMTX.
        /// </summary>
        public const string IMTX = "IMTX";

        /// <summary>
        /// IMTAX1.
        /// </summary>
        public const string IMTAX1 = "IMTAX1";

        /// <summary>
        /// IMMRPD.
        /// </summary>
        public const string IMMRPD = "IMMRPD";

        /// <summary>
        /// IMMRPC.
        /// </summary>
        public const string IMMRPC = "IMMRPC";

        /// <summary>
        /// IMMOVD.
        /// </summary>
        public const string IMMOVD = "IMMOVD";

        /// <summary>
        /// IMBQTY.
        /// </summary>
        public const string IMBQTY = "IMBQTY";

        /// <summary>
        /// IMLFDJ.
        /// </summary>
        public const string IMLFDJ = "IMLFDJ";

        /// <summary>
        /// IMMLOT.
        /// </summary>
        public const string IMMLOT = "IMMLOT";

        /// <summary>
        /// IMLOCN.
        /// </summary>
        public const string IMLOCN = "IMLOCN";

        /// <summary>
        /// IMLOTN.
        /// </summary>
        public const string IMLOTN = "IMLOTN";

        /// <summary>
        /// IMURCD.
        /// </summary>
        public const string IMURCD = "IMURCD";

        /// <summary>
        /// IMURDT.
        /// </summary>
        public const string IMURDT = "IMURDT";

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
        /// IMTMPL.
        /// </summary>
        public const string IMTMPL = "IMTMPL";

        /// <summary>
        /// IMSEG1.
        /// </summary>
        public const string IMSEG1 = "IMSEG1";

        /// <summary>
        /// IMSEG2.
        /// </summary>
        public const string IMSEG2 = "IMSEG2";

        /// <summary>
        /// IMSEG3.
        /// </summary>
        public const string IMSEG3 = "IMSEG3";

        /// <summary>
        /// IMSEG4.
        /// </summary>
        public const string IMSEG4 = "IMSEG4";

        /// <summary>
        /// IMSEG5.
        /// </summary>
        public const string IMSEG5 = "IMSEG5";

        /// <summary>
        /// IMSEG6.
        /// </summary>
        public const string IMSEG6 = "IMSEG6";

        /// <summary>
        /// IMSEG7.
        /// </summary>
        public const string IMSEG7 = "IMSEG7";

        /// <summary>
        /// IMSEG8.
        /// </summary>
        public const string IMSEG8 = "IMSEG8";

        /// <summary>
        /// IMSEG9.
        /// </summary>
        public const string IMSEG9 = "IMSEG9";

        /// <summary>
        /// IMSEG0.
        /// </summary>
        public const string IMSEG0 = "IMSEG0";

        /// <summary>
        /// IMCMDM.
        /// </summary>
        public const string IMCMDM = "IMCMDM";

        /// <summary>
        /// IMDPPO.
        /// </summary>
        public const string IMDPPO = "IMDPPO";

        /// <summary>
        /// IMDUAL.
        /// </summary>
        public const string IMDUAL = "IMDUAL";

        /// <summary>
        /// IMLECM.
        /// </summary>
        public const string IMLECM = "IMLECM";

        /// <summary>
        /// IMMIC.
        /// </summary>
        public const string IMMIC = "IMMIC";

        /// <summary>
        /// IMXDCK.
        /// </summary>
        public const string IMXDCK = "IMXDCK";

        /// <summary>
        /// IMBBDD.
        /// </summary>
        public const string IMBBDD = "IMBBDD";

        /// <summary>
        /// IMAING.
        /// </summary>
        public const string IMAING = "IMAING";

        /// <summary>
        /// IMLEDD.
        /// </summary>
        public const string IMLEDD = "IMLEDD";

        /// <summary>
        /// IMPEFD.
        /// </summary>
        public const string IMPEFD = "IMPEFD";

        /// <summary>
        /// IMSBDD.
        /// </summary>
        public const string IMSBDD = "IMSBDD";

        /// <summary>
        /// IMU1DD.
        /// </summary>
        public const string IMU1DD = "IMU1DD";

        /// <summary>
        /// IMU2DD.
        /// </summary>
        public const string IMU2DD = "IMU2DD";

        /// <summary>
        /// IMU3DD.
        /// </summary>
        public const string IMU3DD = "IMU3DD";

        /// <summary>
        /// IMU4DD.
        /// </summary>
        public const string IMU4DD = "IMU4DD";

        /// <summary>
        /// IMU5DD.
        /// </summary>
        public const string IMU5DD = "IMU5DD";

        /// <summary>
        /// IMDLTL.
        /// </summary>
        public const string IMDLTL = "IMDLTL";

        /// <summary>
        /// IMLOTC.
        /// </summary>
        public const string IMLOTC = "IMLOTC";

        /// <summary>
        /// IMCMETH.
        /// </summary>
        public const string IMCMETH = "IMCMETH";

        /// <summary>
        /// IMLAF.
        /// </summary>
        public const string IMLAF = "IMLAF";

        /// <summary>
        /// IMLTFM.
        /// </summary>
        public const string IMLTFM = "IMLTFM";

        /// <summary>
        /// IMRWLA.
        /// </summary>
        public const string IMRWLA = "IMRWLA";

        /// <summary>
        /// IMLNPA.
        /// </summary>
        public const string IMLNPA = "IMLNPA";

        /// <summary>
        /// IMASHL.
        /// </summary>
        public const string IMASHL = "IMASHL";

        /// <summary>
        /// IMVMINV.
        /// </summary>
        public const string IMVMINV = "IMVMINV";

        /// <summary>
        /// IMTNAC.
        /// </summary>
        public const string IMTNAC = "IMTNAC";

        /// <summary>
        /// IMCOORE.
        /// </summary>
        public const string IMCOORE = "IMCOORE";

        /// <summary>
        /// IMPNYN.
        /// </summary>
        public const string IMPNYN = "IMPNYN";
    }

    /// <inheritdoc />
    public override string TableName => "F4101A";

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
        new JdeField("IMLITM", "IMLITM", JdeDataType.String, 50),
        new JdeField("IMAITM", "IMAITM", JdeDataType.String, 50),
        new JdeField("IMDSC1", "IMDSC1", JdeDataType.String, 60),
        new JdeField("IMDSC2", "IMDSC2", JdeDataType.String, 60),
        new JdeField("IMSRTX", "IMSRTX", JdeDataType.String, 60),
        new JdeField("IMALN", "IMALN", JdeDataType.String, 60),
        new JdeField("IMCDCD", "IMCDCD", JdeDataType.String, 30),
        new JdeField("IMPDGR", "IMPDGR", JdeDataType.String, 6),
        new JdeField("IMDSGP", "IMDSGP", JdeDataType.String, 6),
        new JdeField("IMPRGR", "IMPRGR", JdeDataType.String, 16),
        new JdeField("IMRPRC", "IMRPRC", JdeDataType.String, 16),
        new JdeField("IMORPR", "IMORPR", JdeDataType.String, 16),
        new JdeField("IMBUYR", "IMBUYR", JdeDataType.Numeric),
        new JdeField("IMVCUD", "IMVCUD", JdeDataType.Numeric),
        new JdeField("IMUOM1", "IMUOM1", JdeDataType.String, 4),
        new JdeField("IMUOM2", "IMUOM2", JdeDataType.String, 4),
        new JdeField("IMUOM3", "IMUOM3", JdeDataType.String, 4),
        new JdeField("IMUOM4", "IMUOM4", JdeDataType.String, 4),
        new JdeField("IMUOM6", "IMUOM6", JdeDataType.String, 4),
        new JdeField("IMUOM8", "IMUOM8", JdeDataType.String, 4),
        new JdeField("IMUOM9", "IMUOM9", JdeDataType.String, 4),
        new JdeField("IMUWUM", "IMUWUM", JdeDataType.String, 4),
        new JdeField("IMUVM1", "IMUVM1", JdeDataType.String, 4),
        new JdeField("IMSUTM", "IMSUTM", JdeDataType.String, 4),
        new JdeField("IMUMVW", "IMUMVW", JdeDataType.String, 2),
        new JdeField("IMGLPT", "IMGLPT", JdeDataType.String, 8),
        new JdeField("IMPLEV", "IMPLEV", JdeDataType.String, 2),
        new JdeField("IMPPLV", "IMPPLV", JdeDataType.String, 2),
        new JdeField("IMCLEV", "IMCLEV", JdeDataType.String, 2),
        new JdeField("IMCKAV", "IMCKAV", JdeDataType.String, 2),
        new JdeField("IMBPFG", "IMBPFG", JdeDataType.String, 2),
        new JdeField("IMSRCE", "IMSRCE", JdeDataType.String, 2),
        new JdeField("IMCOTY", "IMCOTY", JdeDataType.String, 2),
        new JdeField("IMSTKT", "IMSTKT", JdeDataType.String, 2),
        new JdeField("IMLNTY", "IMLNTY", JdeDataType.String, 4),
        new JdeField("IMCONT", "IMCONT", JdeDataType.String, 2),
        new JdeField("IMBACK", "IMBACK", JdeDataType.String, 2),
        new JdeField("IMIFLA", "IMIFLA", JdeDataType.String, 4),
        new JdeField("IMTFLA", "IMTFLA", JdeDataType.String, 4),
        new JdeField("IMINMG", "IMINMG", JdeDataType.String, 20),
        new JdeField("IMABCS", "IMABCS", JdeDataType.String, 2),
        new JdeField("IMABCM", "IMABCM", JdeDataType.String, 2),
        new JdeField("IMABCI", "IMABCI", JdeDataType.String, 2),
        new JdeField("IMOVR", "IMOVR", JdeDataType.String, 2),
        new JdeField("IMWARR", "IMWARR", JdeDataType.String, 16),
        new JdeField("IMCMCG", "IMCMCG", JdeDataType.String, 16),
        new JdeField("IMSRNR", "IMSRNR", JdeDataType.String, 2),
        new JdeField("IMPMTH", "IMPMTH", JdeDataType.String, 2),
        new JdeField("IMFIFO", "IMFIFO", JdeDataType.String, 2),
        new JdeField("IMLOTS", "IMLOTS", JdeDataType.String, 2),
        new JdeField("IMSLD", "IMSLD", JdeDataType.Numeric),
        new JdeField("IMANPL", "IMANPL", JdeDataType.Numeric),
        new JdeField("IMPCTM", "IMPCTM", JdeDataType.Numeric),
        new JdeField("IMMMPC", "IMMMPC", JdeDataType.Numeric),
        new JdeField("IMORDW", "IMORDW", JdeDataType.String, 2),
        new JdeField("IMEXPD", "IMEXPD", JdeDataType.Numeric),
        new JdeField("IMDEFD", "IMDEFD", JdeDataType.Numeric),
        new JdeField("IMSFLT", "IMSFLT", JdeDataType.Numeric),
        new JdeField("IMMAKE", "IMMAKE", JdeDataType.String, 2),
        new JdeField("IMCOBY", "IMCOBY", JdeDataType.String, 2),
        new JdeField("IMLLX", "IMLLX", JdeDataType.Numeric),
        new JdeField("IMCMGL", "IMCMGL", JdeDataType.String, 2),
        new JdeField("IMCOMH", "IMCOMH", JdeDataType.Numeric),
        new JdeField("IMVEND", "IMVEND", JdeDataType.Numeric),
        new JdeField("IMORIG", "IMORIG", JdeDataType.String, 6),
        new JdeField("IMWOMO", "IMWOMO", JdeDataType.Numeric),
        new JdeField("IMSERV", "IMSERV", JdeDataType.Numeric),
        new JdeField("IMFUF1", "IMFUF1", JdeDataType.String, 2),
        new JdeField("IMTX", "IMTX", JdeDataType.String, 2),
        new JdeField("IMTAX1", "IMTAX1", JdeDataType.String, 2),
        new JdeField("IMMRPD", "IMMRPD", JdeDataType.String, 2),
        new JdeField("IMMRPC", "IMMRPC", JdeDataType.String, 2),
        new JdeField("IMMOVD", "IMMOVD", JdeDataType.Numeric),
        new JdeField("IMBQTY", "IMBQTY", JdeDataType.Numeric),
        new JdeField("IMLFDJ", "IMLFDJ", JdeDataType.Numeric),
        new JdeField("IMMLOT", "IMMLOT", JdeDataType.String, 2),
        new JdeField("IMLOCN", "IMLOCN", JdeDataType.String, 40),
        new JdeField("IMLOTN", "IMLOTN", JdeDataType.String, 60),
        new JdeField("IMURCD", "IMURCD", JdeDataType.String, 4),
        new JdeField("IMURDT", "IMURDT", JdeDataType.Numeric),
        new JdeField("IMURAT", "IMURAT", JdeDataType.Numeric),
        new JdeField("IMURAB", "IMURAB", JdeDataType.Numeric),
        new JdeField("IMURRF", "IMURRF", JdeDataType.String, 30),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric),
        new JdeField("IMTMPL", "IMTMPL", JdeDataType.String, 40),
        new JdeField("IMSEG1", "IMSEG1", JdeDataType.String, 20),
        new JdeField("IMSEG2", "IMSEG2", JdeDataType.String, 20),
        new JdeField("IMSEG3", "IMSEG3", JdeDataType.String, 20),
        new JdeField("IMSEG4", "IMSEG4", JdeDataType.String, 20),
        new JdeField("IMSEG5", "IMSEG5", JdeDataType.String, 20),
        new JdeField("IMSEG6", "IMSEG6", JdeDataType.String, 20),
        new JdeField("IMSEG7", "IMSEG7", JdeDataType.String, 20),
        new JdeField("IMSEG8", "IMSEG8", JdeDataType.String, 20),
        new JdeField("IMSEG9", "IMSEG9", JdeDataType.String, 20),
        new JdeField("IMSEG0", "IMSEG0", JdeDataType.String, 20),
        new JdeField("IMCMDM", "IMCMDM", JdeDataType.String, 2),
        new JdeField("IMDPPO", "IMDPPO", JdeDataType.String, 2),
        new JdeField("IMDUAL", "IMDUAL", JdeDataType.String, 2),
        new JdeField("IMLECM", "IMLECM", JdeDataType.String, 2),
        new JdeField("IMMIC", "IMMIC", JdeDataType.String, 2),
        new JdeField("IMXDCK", "IMXDCK", JdeDataType.String, 2),
        new JdeField("IMBBDD", "IMBBDD", JdeDataType.Numeric),
        new JdeField("IMAING", "IMAING", JdeDataType.String, 2),
        new JdeField("IMLEDD", "IMLEDD", JdeDataType.Numeric),
        new JdeField("IMPEFD", "IMPEFD", JdeDataType.Numeric),
        new JdeField("IMSBDD", "IMSBDD", JdeDataType.Numeric),
        new JdeField("IMU1DD", "IMU1DD", JdeDataType.Numeric),
        new JdeField("IMU2DD", "IMU2DD", JdeDataType.Numeric),
        new JdeField("IMU3DD", "IMU3DD", JdeDataType.Numeric),
        new JdeField("IMU4DD", "IMU4DD", JdeDataType.Numeric),
        new JdeField("IMU5DD", "IMU5DD", JdeDataType.Numeric),
        new JdeField("IMDLTL", "IMDLTL", JdeDataType.Numeric),
        new JdeField("IMLOTC", "IMLOTC", JdeDataType.String, 6),
        new JdeField("IMCMETH", "IMCMETH", JdeDataType.String, 2),
        new JdeField("IMLAF", "IMLAF", JdeDataType.String, 2),
        new JdeField("IMLTFM", "IMLTFM", JdeDataType.String, 2),
        new JdeField("IMRWLA", "IMRWLA", JdeDataType.String, 2),
        new JdeField("IMLNPA", "IMLNPA", JdeDataType.String, 2),
        new JdeField("IMASHL", "IMASHL", JdeDataType.String, 2),
        new JdeField("IMVMINV", "IMVMINV", JdeDataType.String, 2),
        new JdeField("IMTNAC", "IMTNAC", JdeDataType.String, 4),
        new JdeField("IMCOORE", "IMCOORE", JdeDataType.String, 2),
        new JdeField("IMPNYN", "IMPNYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101A_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
