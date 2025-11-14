using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101 - .
/// </summary>
public class F4101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

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
        /// IMSRP1.
        /// </summary>
        public const string IMSRP1 = "IMSRP1";

        /// <summary>
        /// IMSRP2.
        /// </summary>
        public const string IMSRP2 = "IMSRP2";

        /// <summary>
        /// IMSRP3.
        /// </summary>
        public const string IMSRP3 = "IMSRP3";

        /// <summary>
        /// IMSRP4.
        /// </summary>
        public const string IMSRP4 = "IMSRP4";

        /// <summary>
        /// IMSRP5.
        /// </summary>
        public const string IMSRP5 = "IMSRP5";

        /// <summary>
        /// IMSRP6.
        /// </summary>
        public const string IMSRP6 = "IMSRP6";

        /// <summary>
        /// IMSRP7.
        /// </summary>
        public const string IMSRP7 = "IMSRP7";

        /// <summary>
        /// IMSRP8.
        /// </summary>
        public const string IMSRP8 = "IMSRP8";

        /// <summary>
        /// IMSRP9.
        /// </summary>
        public const string IMSRP9 = "IMSRP9";

        /// <summary>
        /// IMSRP0.
        /// </summary>
        public const string IMSRP0 = "IMSRP0";

        /// <summary>
        /// IMPRP1.
        /// </summary>
        public const string IMPRP1 = "IMPRP1";

        /// <summary>
        /// IMPRP2.
        /// </summary>
        public const string IMPRP2 = "IMPRP2";

        /// <summary>
        /// IMPRP3.
        /// </summary>
        public const string IMPRP3 = "IMPRP3";

        /// <summary>
        /// IMPRP4.
        /// </summary>
        public const string IMPRP4 = "IMPRP4";

        /// <summary>
        /// IMPRP5.
        /// </summary>
        public const string IMPRP5 = "IMPRP5";

        /// <summary>
        /// IMPRP6.
        /// </summary>
        public const string IMPRP6 = "IMPRP6";

        /// <summary>
        /// IMPRP7.
        /// </summary>
        public const string IMPRP7 = "IMPRP7";

        /// <summary>
        /// IMPRP8.
        /// </summary>
        public const string IMPRP8 = "IMPRP8";

        /// <summary>
        /// IMPRP9.
        /// </summary>
        public const string IMPRP9 = "IMPRP9";

        /// <summary>
        /// IMPRP0.
        /// </summary>
        public const string IMPRP0 = "IMPRP0";

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
        /// IMVCUD.
        /// </summary>
        public const string IMVCUD = "IMVCUD";

        /// <summary>
        /// IMCARS.
        /// </summary>
        public const string IMCARS = "IMCARS";

        /// <summary>
        /// IMCARP.
        /// </summary>
        public const string IMCARP = "IMCARP";

        /// <summary>
        /// IMSHCN.
        /// </summary>
        public const string IMSHCN = "IMSHCN";

        /// <summary>
        /// IMSHCM.
        /// </summary>
        public const string IMSHCM = "IMSHCM";

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
        /// IMCYCL.
        /// </summary>
        public const string IMCYCL = "IMCYCL";

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
        /// IMPRPO.
        /// </summary>
        public const string IMPRPO = "IMPRPO";

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
        /// IMMPST.
        /// </summary>
        public const string IMMPST = "IMMPST";

        /// <summary>
        /// IMPCTM.
        /// </summary>
        public const string IMPCTM = "IMPCTM";

        /// <summary>
        /// IMMMPC.
        /// </summary>
        public const string IMMMPC = "IMMMPC";

        /// <summary>
        /// IMPTSC.
        /// </summary>
        public const string IMPTSC = "IMPTSC";

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
        /// IMORDW.
        /// </summary>
        public const string IMORDW = "IMORDW";

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
        /// IMUPCN.
        /// </summary>
        public const string IMUPCN = "IMUPCN";

        /// <summary>
        /// IMSCC0.
        /// </summary>
        public const string IMSCC0 = "IMSCC0";

        /// <summary>
        /// IMUMUP.
        /// </summary>
        public const string IMUMUP = "IMUMUP";

        /// <summary>
        /// IMUMDF.
        /// </summary>
        public const string IMUMDF = "IMUMDF";

        /// <summary>
        /// IMUMS0.
        /// </summary>
        public const string IMUMS0 = "IMUMS0";

        /// <summary>
        /// IMUMS1.
        /// </summary>
        public const string IMUMS1 = "IMUMS1";

        /// <summary>
        /// IMUMS2.
        /// </summary>
        public const string IMUMS2 = "IMUMS2";

        /// <summary>
        /// IMUMS3.
        /// </summary>
        public const string IMUMS3 = "IMUMS3";

        /// <summary>
        /// IMUMS4.
        /// </summary>
        public const string IMUMS4 = "IMUMS4";

        /// <summary>
        /// IMUMS5.
        /// </summary>
        public const string IMUMS5 = "IMUMS5";

        /// <summary>
        /// IMUMS6.
        /// </summary>
        public const string IMUMS6 = "IMUMS6";

        /// <summary>
        /// IMUMS7.
        /// </summary>
        public const string IMUMS7 = "IMUMS7";

        /// <summary>
        /// IMUMS8.
        /// </summary>
        public const string IMUMS8 = "IMUMS8";

        /// <summary>
        /// IMPOC.
        /// </summary>
        public const string IMPOC = "IMPOC";

        /// <summary>
        /// IMAVRT.
        /// </summary>
        public const string IMAVRT = "IMAVRT";

        /// <summary>
        /// IMEQTY.
        /// </summary>
        public const string IMEQTY = "IMEQTY";

        /// <summary>
        /// IMWTRQ.
        /// </summary>
        public const string IMWTRQ = "IMWTRQ";

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
        /// IMMIC.
        /// </summary>
        public const string IMMIC = "IMMIC";

        /// <summary>
        /// IMAING.
        /// </summary>
        public const string IMAING = "IMAING";

        /// <summary>
        /// IMBBDD.
        /// </summary>
        public const string IMBBDD = "IMBBDD";

        /// <summary>
        /// IMCMDM.
        /// </summary>
        public const string IMCMDM = "IMCMDM";

        /// <summary>
        /// IMLECM.
        /// </summary>
        public const string IMLECM = "IMLECM";

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
        /// IMDPPO.
        /// </summary>
        public const string IMDPPO = "IMDPPO";

        /// <summary>
        /// IMDUAL.
        /// </summary>
        public const string IMDUAL = "IMDUAL";

        /// <summary>
        /// IMXDCK.
        /// </summary>
        public const string IMXDCK = "IMXDCK";

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
        /// IMLOTC.
        /// </summary>
        public const string IMLOTC = "IMLOTC";

        /// <summary>
        /// IMAPSC.
        /// </summary>
        public const string IMAPSC = "IMAPSC";

        /// <summary>
        /// IMAUOM.
        /// </summary>
        public const string IMAUOM = "IMAUOM";

        /// <summary>
        /// IMCONB.
        /// </summary>
        public const string IMCONB = "IMCONB";

        /// <summary>
        /// IMGCMP.
        /// </summary>
        public const string IMGCMP = "IMGCMP";

        /// <summary>
        /// IMPRI1.
        /// </summary>
        public const string IMPRI1 = "IMPRI1";

        /// <summary>
        /// IMPRI2.
        /// </summary>
        public const string IMPRI2 = "IMPRI2";

        /// <summary>
        /// IMASHL.
        /// </summary>
        public const string IMASHL = "IMASHL";

        /// <summary>
        /// IMVMINV.
        /// </summary>
        public const string IMVMINV = "IMVMINV";

        /// <summary>
        /// IMCMETH.
        /// </summary>
        public const string IMCMETH = "IMCMETH";

        /// <summary>
        /// IMEXPI.
        /// </summary>
        public const string IMEXPI = "IMEXPI";

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
        /// IMKBIT.
        /// </summary>
        public const string IMKBIT = "IMKBIT";

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
        /// IMCOORE.
        /// </summary>
        public const string IMCOORE = "IMCOORE";

        /// <summary>
        /// IMVCPFC.
        /// </summary>
        public const string IMVCPFC = "IMVCPFC";

        /// <summary>
        /// IMPNYN.
        /// </summary>
        public const string IMPNYN = "IMPNYN";
    }

    /// <inheritdoc />
    public override string TableName => "F4101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMLITM", "IMLITM", JdeDataType.String, 50),
        new JdeField("IMAITM", "IMAITM", JdeDataType.String, 50),
        new JdeField("IMDSC1", "IMDSC1", JdeDataType.String, 60),
        new JdeField("IMDSC2", "IMDSC2", JdeDataType.String, 60),
        new JdeField("IMSRTX", "IMSRTX", JdeDataType.String, 60),
        new JdeField("IMALN", "IMALN", JdeDataType.String, 60),
        new JdeField("IMSRP1", "IMSRP1", JdeDataType.String, 6),
        new JdeField("IMSRP2", "IMSRP2", JdeDataType.String, 6),
        new JdeField("IMSRP3", "IMSRP3", JdeDataType.String, 6),
        new JdeField("IMSRP4", "IMSRP4", JdeDataType.String, 6),
        new JdeField("IMSRP5", "IMSRP5", JdeDataType.String, 6),
        new JdeField("IMSRP6", "IMSRP6", JdeDataType.String, 12),
        new JdeField("IMSRP7", "IMSRP7", JdeDataType.String, 12),
        new JdeField("IMSRP8", "IMSRP8", JdeDataType.String, 12),
        new JdeField("IMSRP9", "IMSRP9", JdeDataType.String, 12),
        new JdeField("IMSRP0", "IMSRP0", JdeDataType.String, 12),
        new JdeField("IMPRP1", "IMPRP1", JdeDataType.String, 6),
        new JdeField("IMPRP2", "IMPRP2", JdeDataType.String, 6),
        new JdeField("IMPRP3", "IMPRP3", JdeDataType.String, 6),
        new JdeField("IMPRP4", "IMPRP4", JdeDataType.String, 6),
        new JdeField("IMPRP5", "IMPRP5", JdeDataType.String, 6),
        new JdeField("IMPRP6", "IMPRP6", JdeDataType.String, 12),
        new JdeField("IMPRP7", "IMPRP7", JdeDataType.String, 12),
        new JdeField("IMPRP8", "IMPRP8", JdeDataType.String, 12),
        new JdeField("IMPRP9", "IMPRP9", JdeDataType.String, 12),
        new JdeField("IMPRP0", "IMPRP0", JdeDataType.String, 12),
        new JdeField("IMCDCD", "IMCDCD", JdeDataType.String, 30),
        new JdeField("IMPDGR", "IMPDGR", JdeDataType.String, 6),
        new JdeField("IMDSGP", "IMDSGP", JdeDataType.String, 6),
        new JdeField("IMPRGR", "IMPRGR", JdeDataType.String, 16),
        new JdeField("IMRPRC", "IMRPRC", JdeDataType.String, 16),
        new JdeField("IMORPR", "IMORPR", JdeDataType.String, 16),
        new JdeField("IMBUYR", "IMBUYR", JdeDataType.Numeric),
        new JdeField("IMDRAW", "IMDRAW", JdeDataType.String, 40),
        new JdeField("IMRVNO", "IMRVNO", JdeDataType.String, 4),
        new JdeField("IMDSZE", "IMDSZE", JdeDataType.String, 2),
        new JdeField("IMVCUD", "IMVCUD", JdeDataType.Numeric),
        new JdeField("IMCARS", "IMCARS", JdeDataType.Numeric),
        new JdeField("IMCARP", "IMCARP", JdeDataType.Numeric),
        new JdeField("IMSHCN", "IMSHCN", JdeDataType.String, 6),
        new JdeField("IMSHCM", "IMSHCM", JdeDataType.String, 6),
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
        new JdeField("IMCYCL", "IMCYCL", JdeDataType.String, 6),
        new JdeField("IMGLPT", "IMGLPT", JdeDataType.String, 8),
        new JdeField("IMPLEV", "IMPLEV", JdeDataType.String, 2),
        new JdeField("IMPPLV", "IMPPLV", JdeDataType.String, 2),
        new JdeField("IMCLEV", "IMCLEV", JdeDataType.String, 2),
        new JdeField("IMPRPO", "IMPRPO", JdeDataType.String, 2),
        new JdeField("IMCKAV", "IMCKAV", JdeDataType.String, 2),
        new JdeField("IMBPFG", "IMBPFG", JdeDataType.String, 2),
        new JdeField("IMSRCE", "IMSRCE", JdeDataType.String, 2),
        new JdeField("IMOT1Y", "IMOT1Y", JdeDataType.String, 2),
        new JdeField("IMOT2Y", "IMOT2Y", JdeDataType.String, 2),
        new JdeField("IMSTDP", "IMSTDP", JdeDataType.Numeric),
        new JdeField("IMFRMP", "IMFRMP", JdeDataType.Numeric),
        new JdeField("IMTHRP", "IMTHRP", JdeDataType.Numeric),
        new JdeField("IMSTDG", "IMSTDG", JdeDataType.String, 6),
        new JdeField("IMFRGD", "IMFRGD", JdeDataType.String, 6),
        new JdeField("IMTHGD", "IMTHGD", JdeDataType.String, 6),
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
        new JdeField("IMMPST", "IMMPST", JdeDataType.String, 2),
        new JdeField("IMPCTM", "IMPCTM", JdeDataType.Numeric),
        new JdeField("IMMMPC", "IMMMPC", JdeDataType.Numeric),
        new JdeField("IMPTSC", "IMPTSC", JdeDataType.String, 4),
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
        new JdeField("IMORDW", "IMORDW", JdeDataType.String, 2),
        new JdeField("IMMTF1", "IMMTF1", JdeDataType.Numeric),
        new JdeField("IMMTF2", "IMMTF2", JdeDataType.Numeric),
        new JdeField("IMMTF3", "IMMTF3", JdeDataType.Numeric),
        new JdeField("IMMTF4", "IMMTF4", JdeDataType.Numeric),
        new JdeField("IMMTF5", "IMMTF5", JdeDataType.Numeric),
        new JdeField("IMEXPD", "IMEXPD", JdeDataType.Numeric),
        new JdeField("IMDEFD", "IMDEFD", JdeDataType.Numeric),
        new JdeField("IMSFLT", "IMSFLT", JdeDataType.Numeric),
        new JdeField("IMMAKE", "IMMAKE", JdeDataType.String, 2),
        new JdeField("IMCOBY", "IMCOBY", JdeDataType.String, 2),
        new JdeField("IMLLX", "IMLLX", JdeDataType.Numeric),
        new JdeField("IMCMGL", "IMCMGL", JdeDataType.String, 2),
        new JdeField("IMCOMH", "IMCOMH", JdeDataType.Numeric),
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
        new JdeField("IMUPCN", "IMUPCN", JdeDataType.String, 26),
        new JdeField("IMSCC0", "IMSCC0", JdeDataType.String, 28),
        new JdeField("IMUMUP", "IMUMUP", JdeDataType.String, 4),
        new JdeField("IMUMDF", "IMUMDF", JdeDataType.String, 4),
        new JdeField("IMUMS0", "IMUMS0", JdeDataType.String, 4),
        new JdeField("IMUMS1", "IMUMS1", JdeDataType.String, 4),
        new JdeField("IMUMS2", "IMUMS2", JdeDataType.String, 4),
        new JdeField("IMUMS3", "IMUMS3", JdeDataType.String, 4),
        new JdeField("IMUMS4", "IMUMS4", JdeDataType.String, 4),
        new JdeField("IMUMS5", "IMUMS5", JdeDataType.String, 4),
        new JdeField("IMUMS6", "IMUMS6", JdeDataType.String, 4),
        new JdeField("IMUMS7", "IMUMS7", JdeDataType.String, 4),
        new JdeField("IMUMS8", "IMUMS8", JdeDataType.String, 4),
        new JdeField("IMPOC", "IMPOC", JdeDataType.String, 2),
        new JdeField("IMAVRT", "IMAVRT", JdeDataType.Numeric),
        new JdeField("IMEQTY", "IMEQTY", JdeDataType.String, 10),
        new JdeField("IMWTRQ", "IMWTRQ", JdeDataType.String, 2),
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
        new JdeField("IMMIC", "IMMIC", JdeDataType.String, 2),
        new JdeField("IMAING", "IMAING", JdeDataType.String, 2),
        new JdeField("IMBBDD", "IMBBDD", JdeDataType.Numeric),
        new JdeField("IMCMDM", "IMCMDM", JdeDataType.String, 2),
        new JdeField("IMLECM", "IMLECM", JdeDataType.String, 2),
        new JdeField("IMLEDD", "IMLEDD", JdeDataType.Numeric),
        new JdeField("IMPEFD", "IMPEFD", JdeDataType.Numeric),
        new JdeField("IMSBDD", "IMSBDD", JdeDataType.Numeric),
        new JdeField("IMU1DD", "IMU1DD", JdeDataType.Numeric),
        new JdeField("IMU2DD", "IMU2DD", JdeDataType.Numeric),
        new JdeField("IMU3DD", "IMU3DD", JdeDataType.Numeric),
        new JdeField("IMU4DD", "IMU4DD", JdeDataType.Numeric),
        new JdeField("IMU5DD", "IMU5DD", JdeDataType.Numeric),
        new JdeField("IMDLTL", "IMDLTL", JdeDataType.Numeric),
        new JdeField("IMDPPO", "IMDPPO", JdeDataType.String, 2),
        new JdeField("IMDUAL", "IMDUAL", JdeDataType.String, 2),
        new JdeField("IMXDCK", "IMXDCK", JdeDataType.String, 2),
        new JdeField("IMLAF", "IMLAF", JdeDataType.String, 2),
        new JdeField("IMLTFM", "IMLTFM", JdeDataType.String, 2),
        new JdeField("IMRWLA", "IMRWLA", JdeDataType.String, 2),
        new JdeField("IMLNPA", "IMLNPA", JdeDataType.String, 2),
        new JdeField("IMLOTC", "IMLOTC", JdeDataType.String, 6),
        new JdeField("IMAPSC", "IMAPSC", JdeDataType.String, 2),
        new JdeField("IMAUOM", "IMAUOM", JdeDataType.String, 18),
        new JdeField("IMCONB", "IMCONB", JdeDataType.String, 2),
        new JdeField("IMGCMP", "IMGCMP", JdeDataType.String, 2),
        new JdeField("IMPRI1", "IMPRI1", JdeDataType.Numeric),
        new JdeField("IMPRI2", "IMPRI2", JdeDataType.Numeric),
        new JdeField("IMASHL", "IMASHL", JdeDataType.String, 2),
        new JdeField("IMVMINV", "IMVMINV", JdeDataType.String, 2),
        new JdeField("IMCMETH", "IMCMETH", JdeDataType.String, 2),
        new JdeField("IMEXPI", "IMEXPI", JdeDataType.String, 2),
        new JdeField("IMOPTH", "IMOPTH", JdeDataType.Numeric),
        new JdeField("IMCUTH", "IMCUTH", JdeDataType.Numeric),
        new JdeField("IMUMTH", "IMUMTH", JdeDataType.String, 6),
        new JdeField("IMLMFG", "IMLMFG", JdeDataType.String, 2),
        new JdeField("IMLINE", "IMLINE", JdeDataType.String, 24),
        new JdeField("IMDFTPCT", "IMDFTPCT", JdeDataType.Numeric),
        new JdeField("IMKBIT", "IMKBIT", JdeDataType.String, 2),
        new JdeField("IMDFENDITM", "IMDFENDITM", JdeDataType.String, 2),
        new JdeField("IMKANEXLL", "IMKANEXLL", JdeDataType.String, 2),
        new JdeField("IMSCPSELL", "IMSCPSELL", JdeDataType.String, 2),
        new JdeField("IMMOPTH", "IMMOPTH", JdeDataType.Numeric),
        new JdeField("IMMCUTH", "IMMCUTH", JdeDataType.Numeric),
        new JdeField("IMCUMTH", "IMCUMTH", JdeDataType.String, 6),
        new JdeField("IMATPRN", "IMATPRN", JdeDataType.String, 160),
        new JdeField("IMATPCA", "IMATPCA", JdeDataType.String, 2),
        new JdeField("IMATPAC", "IMATPAC", JdeDataType.String, 10),
        new JdeField("IMCOORE", "IMCOORE", JdeDataType.String, 2),
        new JdeField("IMVCPFC", "IMVCPFC", JdeDataType.String, 40),
        new JdeField("IMPNYN", "IMPNYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101_0", "Primary Key on IMITM", new[] { "IMITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4101_10", "Index on IMURAT", new[] { "IMURAT" }),
        new JdeIndex("F4101_2", "Unique Index on IMLITM", new[] { "IMLITM" }, isUnique: true),
        new JdeIndex("F4101_3", "Unique Index on IMAITM", new[] { "IMAITM" }, isUnique: true),
        new JdeIndex("F4101_4", "Index on IMALN", new[] { "IMALN" }),
        new JdeIndex("F4101_5", "Index on SYS_NC00210$", new[] { "SYS_NC00210$" }),
        new JdeIndex("F4101_6", "Index on IMSEG1, IMSEG2, IMSEG3, IMSEG4, IMSEG5, IMSEG6, IMSEG7, IMSEG8, IMSEG9, IMSEG0", new[] { "IMSEG1", "IMSEG2", "IMSEG3", "IMSEG4", "IMSEG5", "IMSEG6", "IMSEG7", "IMSEG8", "IMSEG9", "IMSEG0" }),
        new JdeIndex("F4101_7", "Index on IMTMPL", new[] { "IMTMPL" }),
        new JdeIndex("F4101_8", "Index on IMDSC1", new[] { "IMDSC1" }),
        new JdeIndex("F4101_9", "Index on IMPRP6", new[] { "IMPRP6" })
    };
}
