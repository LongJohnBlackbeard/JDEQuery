using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03012Z1 - .
/// </summary>
public class F03012Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VOEDUS.
        /// </summary>
        public const string VOEDUS = "VOEDUS";

        /// <summary>
        /// VOEDBT.
        /// </summary>
        public const string VOEDBT = "VOEDBT";

        /// <summary>
        /// VOEDTN.
        /// </summary>
        public const string VOEDTN = "VOEDTN";

        /// <summary>
        /// VOEDLN.
        /// </summary>
        public const string VOEDLN = "VOEDLN";

        /// <summary>
        /// VOEDCT.
        /// </summary>
        public const string VOEDCT = "VOEDCT";

        /// <summary>
        /// VOTYTN.
        /// </summary>
        public const string VOTYTN = "VOTYTN";

        /// <summary>
        /// VOEDFT.
        /// </summary>
        public const string VOEDFT = "VOEDFT";

        /// <summary>
        /// VOEDDT.
        /// </summary>
        public const string VOEDDT = "VOEDDT";

        /// <summary>
        /// VODRIN.
        /// </summary>
        public const string VODRIN = "VODRIN";

        /// <summary>
        /// VOEDDL.
        /// </summary>
        public const string VOEDDL = "VOEDDL";

        /// <summary>
        /// VOEDSP.
        /// </summary>
        public const string VOEDSP = "VOEDSP";

        /// <summary>
        /// VOPNID.
        /// </summary>
        public const string VOPNID = "VOPNID";

        /// <summary>
        /// VOTNAC.
        /// </summary>
        public const string VOTNAC = "VOTNAC";

        /// <summary>
        /// VOAN8.
        /// </summary>
        public const string VOAN8 = "VOAN8";

        /// <summary>
        /// VOCO.
        /// </summary>
        public const string VOCO = "VOCO";

        /// <summary>
        /// VOARC.
        /// </summary>
        public const string VOARC = "VOARC";

        /// <summary>
        /// VOMCUR.
        /// </summary>
        public const string VOMCUR = "VOMCUR";

        /// <summary>
        /// VOOBAR.
        /// </summary>
        public const string VOOBAR = "VOOBAR";

        /// <summary>
        /// VOAIDR.
        /// </summary>
        public const string VOAIDR = "VOAIDR";

        /// <summary>
        /// VOKCOR.
        /// </summary>
        public const string VOKCOR = "VOKCOR";

        /// <summary>
        /// VODCAR.
        /// </summary>
        public const string VODCAR = "VODCAR";

        /// <summary>
        /// VODTAR.
        /// </summary>
        public const string VODTAR = "VODTAR";

        /// <summary>
        /// VOCRCD.
        /// </summary>
        public const string VOCRCD = "VOCRCD";

        /// <summary>
        /// VOTXA1.
        /// </summary>
        public const string VOTXA1 = "VOTXA1";

        /// <summary>
        /// VOEXR1.
        /// </summary>
        public const string VOEXR1 = "VOEXR1";

        /// <summary>
        /// VOACL.
        /// </summary>
        public const string VOACL = "VOACL";

        /// <summary>
        /// VOHDAR.
        /// </summary>
        public const string VOHDAR = "VOHDAR";

        /// <summary>
        /// VOTRAR.
        /// </summary>
        public const string VOTRAR = "VOTRAR";

        /// <summary>
        /// VOSTTO.
        /// </summary>
        public const string VOSTTO = "VOSTTO";

        /// <summary>
        /// VORYIN.
        /// </summary>
        public const string VORYIN = "VORYIN";

        /// <summary>
        /// VOSTMT.
        /// </summary>
        public const string VOSTMT = "VOSTMT";

        /// <summary>
        /// VOARPY.
        /// </summary>
        public const string VOARPY = "VOARPY";

        /// <summary>
        /// VOATCS.
        /// </summary>
        public const string VOATCS = "VOATCS";

        /// <summary>
        /// VOSITO.
        /// </summary>
        public const string VOSITO = "VOSITO";

        /// <summary>
        /// VOSQNL.
        /// </summary>
        public const string VOSQNL = "VOSQNL";

        /// <summary>
        /// VOALGM.
        /// </summary>
        public const string VOALGM = "VOALGM";

        /// <summary>
        /// VOCYCN.
        /// </summary>
        public const string VOCYCN = "VOCYCN";

        /// <summary>
        /// VOBO.
        /// </summary>
        public const string VOBO = "VOBO";

        /// <summary>
        /// VOTSTA.
        /// </summary>
        public const string VOTSTA = "VOTSTA";

        /// <summary>
        /// VOCKHC.
        /// </summary>
        public const string VOCKHC = "VOCKHC";

        /// <summary>
        /// VODLC.
        /// </summary>
        public const string VODLC = "VODLC";

        /// <summary>
        /// VODNLT.
        /// </summary>
        public const string VODNLT = "VODNLT";

        /// <summary>
        /// VOPLCR.
        /// </summary>
        public const string VOPLCR = "VOPLCR";

        /// <summary>
        /// VORVDJ.
        /// </summary>
        public const string VORVDJ = "VORVDJ";

        /// <summary>
        /// VODSO.
        /// </summary>
        public const string VODSO = "VODSO";

        /// <summary>
        /// VOCMGR.
        /// </summary>
        public const string VOCMGR = "VOCMGR";

        /// <summary>
        /// VOCLMG.
        /// </summary>
        public const string VOCLMG = "VOCLMG";

        /// <summary>
        /// VODLQT.
        /// </summary>
        public const string VODLQT = "VODLQT";

        /// <summary>
        /// VODLQJ.
        /// </summary>
        public const string VODLQJ = "VODLQJ";

        /// <summary>
        /// VONBRR.
        /// </summary>
        public const string VONBRR = "VONBRR";

        /// <summary>
        /// VOCOLL.
        /// </summary>
        public const string VOCOLL = "VOCOLL";

        /// <summary>
        /// VONBR1.
        /// </summary>
        public const string VONBR1 = "VONBR1";

        /// <summary>
        /// VONBR2.
        /// </summary>
        public const string VONBR2 = "VONBR2";

        /// <summary>
        /// VONBR3.
        /// </summary>
        public const string VONBR3 = "VONBR3";

        /// <summary>
        /// VONBCL.
        /// </summary>
        public const string VONBCL = "VONBCL";

        /// <summary>
        /// VOAFC.
        /// </summary>
        public const string VOAFC = "VOAFC";

        /// <summary>
        /// VOFD.
        /// </summary>
        public const string VOFD = "VOFD";

        /// <summary>
        /// VOFP.
        /// </summary>
        public const string VOFP = "VOFP";

        /// <summary>
        /// VOCFCE.
        /// </summary>
        public const string VOCFCE = "VOCFCE";

        /// <summary>
        /// VOAB2.
        /// </summary>
        public const string VOAB2 = "VOAB2";

        /// <summary>
        /// VODT1J.
        /// </summary>
        public const string VODT1J = "VODT1J";

        /// <summary>
        /// VODFIJ.
        /// </summary>
        public const string VODFIJ = "VODFIJ";

        /// <summary>
        /// VODLIJ.
        /// </summary>
        public const string VODLIJ = "VODLIJ";

        /// <summary>
        /// VOABC1.
        /// </summary>
        public const string VOABC1 = "VOABC1";

        /// <summary>
        /// VOABC2.
        /// </summary>
        public const string VOABC2 = "VOABC2";

        /// <summary>
        /// VOABC3.
        /// </summary>
        public const string VOABC3 = "VOABC3";

        /// <summary>
        /// VOFNDJ.
        /// </summary>
        public const string VOFNDJ = "VOFNDJ";

        /// <summary>
        /// VODLP.
        /// </summary>
        public const string VODLP = "VODLP";

        /// <summary>
        /// VODB.
        /// </summary>
        public const string VODB = "VODB";

        /// <summary>
        /// VODNBJ.
        /// </summary>
        public const string VODNBJ = "VODNBJ";

        /// <summary>
        /// VOTRW.
        /// </summary>
        public const string VOTRW = "VOTRW";

        /// <summary>
        /// VOTWDJ.
        /// </summary>
        public const string VOTWDJ = "VOTWDJ";

        /// <summary>
        /// VOAVD.
        /// </summary>
        public const string VOAVD = "VOAVD";

        /// <summary>
        /// VOCRCA.
        /// </summary>
        public const string VOCRCA = "VOCRCA";

        /// <summary>
        /// VOAD.
        /// </summary>
        public const string VOAD = "VOAD";

        /// <summary>
        /// VOAFCP.
        /// </summary>
        public const string VOAFCP = "VOAFCP";

        /// <summary>
        /// VOAFCY.
        /// </summary>
        public const string VOAFCY = "VOAFCY";

        /// <summary>
        /// VOASTY.
        /// </summary>
        public const string VOASTY = "VOASTY";

        /// <summary>
        /// VOSPYE.
        /// </summary>
        public const string VOSPYE = "VOSPYE";

        /// <summary>
        /// VOAHB.
        /// </summary>
        public const string VOAHB = "VOAHB";

        /// <summary>
        /// VOALP.
        /// </summary>
        public const string VOALP = "VOALP";

        /// <summary>
        /// VOABAM.
        /// </summary>
        public const string VOABAM = "VOABAM";

        /// <summary>
        /// VOABA1.
        /// </summary>
        public const string VOABA1 = "VOABA1";

        /// <summary>
        /// VOAPRC.
        /// </summary>
        public const string VOAPRC = "VOAPRC";

        /// <summary>
        /// VOMAXO.
        /// </summary>
        public const string VOMAXO = "VOMAXO";

        /// <summary>
        /// VOMINO.
        /// </summary>
        public const string VOMINO = "VOMINO";

        /// <summary>
        /// VOOYTD.
        /// </summary>
        public const string VOOYTD = "VOOYTD";

        /// <summary>
        /// VOOPY.
        /// </summary>
        public const string VOOPY = "VOOPY";

        /// <summary>
        /// VOPOPN.
        /// </summary>
        public const string VOPOPN = "VOPOPN";

        /// <summary>
        /// VODAOJ.
        /// </summary>
        public const string VODAOJ = "VODAOJ";

        /// <summary>
        /// VOAN8R.
        /// </summary>
        public const string VOAN8R = "VOAN8R";

        /// <summary>
        /// VOBADT.
        /// </summary>
        public const string VOBADT = "VOBADT";

        /// <summary>
        /// VOCPGP.
        /// </summary>
        public const string VOCPGP = "VOCPGP";

        /// <summary>
        /// VOORTP.
        /// </summary>
        public const string VOORTP = "VOORTP";

        /// <summary>
        /// VOTRDC.
        /// </summary>
        public const string VOTRDC = "VOTRDC";

        /// <summary>
        /// VOINMG.
        /// </summary>
        public const string VOINMG = "VOINMG";

        /// <summary>
        /// VOEXHD.
        /// </summary>
        public const string VOEXHD = "VOEXHD";

        /// <summary>
        /// VOHOLD.
        /// </summary>
        public const string VOHOLD = "VOHOLD";

        /// <summary>
        /// VOROUT.
        /// </summary>
        public const string VOROUT = "VOROUT";

        /// <summary>
        /// VOSTOP.
        /// </summary>
        public const string VOSTOP = "VOSTOP";

        /// <summary>
        /// VOZON.
        /// </summary>
        public const string VOZON = "VOZON";

        /// <summary>
        /// VOCARS.
        /// </summary>
        public const string VOCARS = "VOCARS";

        /// <summary>
        /// VODEL1.
        /// </summary>
        public const string VODEL1 = "VODEL1";

        /// <summary>
        /// VODEL2.
        /// </summary>
        public const string VODEL2 = "VODEL2";

        /// <summary>
        /// VOLTDT.
        /// </summary>
        public const string VOLTDT = "VOLTDT";

        /// <summary>
        /// VOFRTH.
        /// </summary>
        public const string VOFRTH = "VOFRTH";

        /// <summary>
        /// VOAFT.
        /// </summary>
        public const string VOAFT = "VOAFT";

        /// <summary>
        /// VOAPTS.
        /// </summary>
        public const string VOAPTS = "VOAPTS";

        /// <summary>
        /// VOSBAL.
        /// </summary>
        public const string VOSBAL = "VOSBAL";

        /// <summary>
        /// VOBACK.
        /// </summary>
        public const string VOBACK = "VOBACK";

        /// <summary>
        /// VOPORQ.
        /// </summary>
        public const string VOPORQ = "VOPORQ";

        /// <summary>
        /// VOPRIO.
        /// </summary>
        public const string VOPRIO = "VOPRIO";

        /// <summary>
        /// VOARTO.
        /// </summary>
        public const string VOARTO = "VOARTO";

        /// <summary>
        /// VOINVC.
        /// </summary>
        public const string VOINVC = "VOINVC";

        /// <summary>
        /// VOICON.
        /// </summary>
        public const string VOICON = "VOICON";

        /// <summary>
        /// VOBLFR.
        /// </summary>
        public const string VOBLFR = "VOBLFR";

        /// <summary>
        /// VONIVD.
        /// </summary>
        public const string VONIVD = "VONIVD";

        /// <summary>
        /// VOLEDJ.
        /// </summary>
        public const string VOLEDJ = "VOLEDJ";

        /// <summary>
        /// VOPLST.
        /// </summary>
        public const string VOPLST = "VOPLST";

        /// <summary>
        /// VOMORD.
        /// </summary>
        public const string VOMORD = "VOMORD";

        /// <summary>
        /// VOCMC1.
        /// </summary>
        public const string VOCMC1 = "VOCMC1";

        /// <summary>
        /// VOCMR1.
        /// </summary>
        public const string VOCMR1 = "VOCMR1";

        /// <summary>
        /// VOCMC2.
        /// </summary>
        public const string VOCMC2 = "VOCMC2";

        /// <summary>
        /// VOCMR2.
        /// </summary>
        public const string VOCMR2 = "VOCMR2";

        /// <summary>
        /// VOPALC.
        /// </summary>
        public const string VOPALC = "VOPALC";

        /// <summary>
        /// VOVUMD.
        /// </summary>
        public const string VOVUMD = "VOVUMD";

        /// <summary>
        /// VOWUMD.
        /// </summary>
        public const string VOWUMD = "VOWUMD";

        /// <summary>
        /// VOEDPM.
        /// </summary>
        public const string VOEDPM = "VOEDPM";

        /// <summary>
        /// VOEDII.
        /// </summary>
        public const string VOEDII = "VOEDII";

        /// <summary>
        /// VOEDCI.
        /// </summary>
        public const string VOEDCI = "VOEDCI";

        /// <summary>
        /// VOEDQD.
        /// </summary>
        public const string VOEDQD = "VOEDQD";

        /// <summary>
        /// VOEDAD.
        /// </summary>
        public const string VOEDAD = "VOEDAD";

        /// <summary>
        /// VOEDF1.
        /// </summary>
        public const string VOEDF1 = "VOEDF1";

        /// <summary>
        /// VOEDF2.
        /// </summary>
        public const string VOEDF2 = "VOEDF2";

        /// <summary>
        /// VOSI01.
        /// </summary>
        public const string VOSI01 = "VOSI01";

        /// <summary>
        /// VOSI02.
        /// </summary>
        public const string VOSI02 = "VOSI02";

        /// <summary>
        /// VOSI03.
        /// </summary>
        public const string VOSI03 = "VOSI03";

        /// <summary>
        /// VOSI04.
        /// </summary>
        public const string VOSI04 = "VOSI04";

        /// <summary>
        /// VOSI05.
        /// </summary>
        public const string VOSI05 = "VOSI05";

        /// <summary>
        /// VOCP01.
        /// </summary>
        public const string VOCP01 = "VOCP01";

        /// <summary>
        /// VOASN.
        /// </summary>
        public const string VOASN = "VOASN";

        /// <summary>
        /// VODSPA.
        /// </summary>
        public const string VODSPA = "VODSPA";

        /// <summary>
        /// VOCRMD.
        /// </summary>
        public const string VOCRMD = "VOCRMD";

        /// <summary>
        /// VOPLY.
        /// </summary>
        public const string VOPLY = "VOPLY";

        /// <summary>
        /// VOMAN8.
        /// </summary>
        public const string VOMAN8 = "VOMAN8";

        /// <summary>
        /// VOARL.
        /// </summary>
        public const string VOARL = "VOARL";

        /// <summary>
        /// VOAMCR.
        /// </summary>
        public const string VOAMCR = "VOAMCR";

        /// <summary>
        /// VOAC01.
        /// </summary>
        public const string VOAC01 = "VOAC01";

        /// <summary>
        /// VOAC02.
        /// </summary>
        public const string VOAC02 = "VOAC02";

        /// <summary>
        /// VOAC03.
        /// </summary>
        public const string VOAC03 = "VOAC03";

        /// <summary>
        /// VOAC04.
        /// </summary>
        public const string VOAC04 = "VOAC04";

        /// <summary>
        /// VOAC05.
        /// </summary>
        public const string VOAC05 = "VOAC05";

        /// <summary>
        /// VOAC06.
        /// </summary>
        public const string VOAC06 = "VOAC06";

        /// <summary>
        /// VOAC07.
        /// </summary>
        public const string VOAC07 = "VOAC07";

        /// <summary>
        /// VOAC08.
        /// </summary>
        public const string VOAC08 = "VOAC08";

        /// <summary>
        /// VOAC09.
        /// </summary>
        public const string VOAC09 = "VOAC09";

        /// <summary>
        /// VOAC10.
        /// </summary>
        public const string VOAC10 = "VOAC10";

        /// <summary>
        /// VOAC11.
        /// </summary>
        public const string VOAC11 = "VOAC11";

        /// <summary>
        /// VOAC12.
        /// </summary>
        public const string VOAC12 = "VOAC12";

        /// <summary>
        /// VOAC13.
        /// </summary>
        public const string VOAC13 = "VOAC13";

        /// <summary>
        /// VOAC14.
        /// </summary>
        public const string VOAC14 = "VOAC14";

        /// <summary>
        /// VOAC15.
        /// </summary>
        public const string VOAC15 = "VOAC15";

        /// <summary>
        /// VOAC16.
        /// </summary>
        public const string VOAC16 = "VOAC16";

        /// <summary>
        /// VOAC17.
        /// </summary>
        public const string VOAC17 = "VOAC17";

        /// <summary>
        /// VOAC18.
        /// </summary>
        public const string VOAC18 = "VOAC18";

        /// <summary>
        /// VOAC19.
        /// </summary>
        public const string VOAC19 = "VOAC19";

        /// <summary>
        /// VOAC20.
        /// </summary>
        public const string VOAC20 = "VOAC20";

        /// <summary>
        /// VOAC21.
        /// </summary>
        public const string VOAC21 = "VOAC21";

        /// <summary>
        /// VOAC22.
        /// </summary>
        public const string VOAC22 = "VOAC22";

        /// <summary>
        /// VOAC23.
        /// </summary>
        public const string VOAC23 = "VOAC23";

        /// <summary>
        /// VOAC24.
        /// </summary>
        public const string VOAC24 = "VOAC24";

        /// <summary>
        /// VOAC25.
        /// </summary>
        public const string VOAC25 = "VOAC25";

        /// <summary>
        /// VOAC26.
        /// </summary>
        public const string VOAC26 = "VOAC26";

        /// <summary>
        /// VOAC27.
        /// </summary>
        public const string VOAC27 = "VOAC27";

        /// <summary>
        /// VOAC28.
        /// </summary>
        public const string VOAC28 = "VOAC28";

        /// <summary>
        /// VOAC29.
        /// </summary>
        public const string VOAC29 = "VOAC29";

        /// <summary>
        /// VOAC30.
        /// </summary>
        public const string VOAC30 = "VOAC30";

        /// <summary>
        /// VOSLPG.
        /// </summary>
        public const string VOSLPG = "VOSLPG";

        /// <summary>
        /// VOSLDW.
        /// </summary>
        public const string VOSLDW = "VOSLDW";

        /// <summary>
        /// VOCFPP.
        /// </summary>
        public const string VOCFPP = "VOCFPP";

        /// <summary>
        /// VOCFSP.
        /// </summary>
        public const string VOCFSP = "VOCFSP";

        /// <summary>
        /// VOCFDF.
        /// </summary>
        public const string VOCFDF = "VOCFDF";

        /// <summary>
        /// VORQ01.
        /// </summary>
        public const string VORQ01 = "VORQ01";

        /// <summary>
        /// VORQ02.
        /// </summary>
        public const string VORQ02 = "VORQ02";

        /// <summary>
        /// VORQ03.
        /// </summary>
        public const string VORQ03 = "VORQ03";

        /// <summary>
        /// VORQ04.
        /// </summary>
        public const string VORQ04 = "VORQ04";

        /// <summary>
        /// VORQ05.
        /// </summary>
        public const string VORQ05 = "VORQ05";

        /// <summary>
        /// VORQ06.
        /// </summary>
        public const string VORQ06 = "VORQ06";

        /// <summary>
        /// VORQ07.
        /// </summary>
        public const string VORQ07 = "VORQ07";

        /// <summary>
        /// VORQ08.
        /// </summary>
        public const string VORQ08 = "VORQ08";

        /// <summary>
        /// VORQ09.
        /// </summary>
        public const string VORQ09 = "VORQ09";

        /// <summary>
        /// VODR03.
        /// </summary>
        public const string VODR03 = "VODR03";

        /// <summary>
        /// VODR04.
        /// </summary>
        public const string VODR04 = "VODR04";

        /// <summary>
        /// VODR08.
        /// </summary>
        public const string VODR08 = "VODR08";

        /// <summary>
        /// VODR09.
        /// </summary>
        public const string VODR09 = "VODR09";

        /// <summary>
        /// VOURDT.
        /// </summary>
        public const string VOURDT = "VOURDT";

        /// <summary>
        /// VOURCD.
        /// </summary>
        public const string VOURCD = "VOURCD";

        /// <summary>
        /// VOURAT.
        /// </summary>
        public const string VOURAT = "VOURAT";

        /// <summary>
        /// VOURAB.
        /// </summary>
        public const string VOURAB = "VOURAB";

        /// <summary>
        /// VOURRF.
        /// </summary>
        public const string VOURRF = "VOURRF";

        /// <summary>
        /// VOTORG.
        /// </summary>
        public const string VOTORG = "VOTORG";

        /// <summary>
        /// VOUSER.
        /// </summary>
        public const string VOUSER = "VOUSER";

        /// <summary>
        /// VOPID.
        /// </summary>
        public const string VOPID = "VOPID";

        /// <summary>
        /// VOJOBN.
        /// </summary>
        public const string VOJOBN = "VOJOBN";

        /// <summary>
        /// VOUPMT.
        /// </summary>
        public const string VOUPMT = "VOUPMT";

        /// <summary>
        /// VOUPMJ.
        /// </summary>
        public const string VOUPMJ = "VOUPMJ";

        /// <summary>
        /// VOTDAY.
        /// </summary>
        public const string VOTDAY = "VOTDAY";

        /// <summary>
        /// VOPRGF.
        /// </summary>
        public const string VOPRGF = "VOPRGF";

        /// <summary>
        /// VOBYAL.
        /// </summary>
        public const string VOBYAL = "VOBYAL";

        /// <summary>
        /// VOBSC.
        /// </summary>
        public const string VOBSC = "VOBSC";

        /// <summary>
        /// VOASHL.
        /// </summary>
        public const string VOASHL = "VOASHL";

        /// <summary>
        /// VOPRSN.
        /// </summary>
        public const string VOPRSN = "VOPRSN";

        /// <summary>
        /// VOOPBO.
        /// </summary>
        public const string VOOPBO = "VOOPBO";

        /// <summary>
        /// VOAPSB.
        /// </summary>
        public const string VOAPSB = "VOAPSB";

        /// <summary>
        /// VOTIER1.
        /// </summary>
        public const string VOTIER1 = "VOTIER1";

        /// <summary>
        /// VOPWPCP.
        /// </summary>
        public const string VOPWPCP = "VOPWPCP";

        /// <summary>
        /// VOCUSTS.
        /// </summary>
        public const string VOCUSTS = "VOCUSTS";

        /// <summary>
        /// VOSTOF.
        /// </summary>
        public const string VOSTOF = "VOSTOF";

        /// <summary>
        /// VOTERRID.
        /// </summary>
        public const string VOTERRID = "VOTERRID";

        /// <summary>
        /// VOCIG.
        /// </summary>
        public const string VOCIG = "VOCIG";

        /// <summary>
        /// VODTEE.
        /// </summary>
        public const string VODTEE = "VODTEE";

        /// <summary>
        /// VOGOPASF.
        /// </summary>
        public const string VOGOPASF = "VOGOPASF";
    }

    /// <inheritdoc />
    public override string TableName => "F03012Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VOEDUS", "VOEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VOEDBT", "VOEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VOEDTN", "VOEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VOEDLN", "VOEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VOEDCT", "VOEDCT", JdeDataType.String, 4),
        new JdeField("VOTYTN", "VOTYTN", JdeDataType.String, 16),
        new JdeField("VOEDFT", "VOEDFT", JdeDataType.String, 20),
        new JdeField("VOEDDT", "VOEDDT", JdeDataType.Numeric),
        new JdeField("VODRIN", "VODRIN", JdeDataType.String, 2),
        new JdeField("VOEDDL", "VOEDDL", JdeDataType.Numeric),
        new JdeField("VOEDSP", "VOEDSP", JdeDataType.String, 2),
        new JdeField("VOPNID", "VOPNID", JdeDataType.String, 30),
        new JdeField("VOTNAC", "VOTNAC", JdeDataType.String, 4),
        new JdeField("VOAN8", "VOAN8", JdeDataType.Numeric),
        new JdeField("VOCO", "VOCO", JdeDataType.String, 10),
        new JdeField("VOARC", "VOARC", JdeDataType.String, 8),
        new JdeField("VOMCUR", "VOMCUR", JdeDataType.String, 24),
        new JdeField("VOOBAR", "VOOBAR", JdeDataType.String, 12),
        new JdeField("VOAIDR", "VOAIDR", JdeDataType.String, 16),
        new JdeField("VOKCOR", "VOKCOR", JdeDataType.String, 10),
        new JdeField("VODCAR", "VODCAR", JdeDataType.Numeric),
        new JdeField("VODTAR", "VODTAR", JdeDataType.String, 4),
        new JdeField("VOCRCD", "VOCRCD", JdeDataType.String, 6),
        new JdeField("VOTXA1", "VOTXA1", JdeDataType.String, 20),
        new JdeField("VOEXR1", "VOEXR1", JdeDataType.String, 4),
        new JdeField("VOACL", "VOACL", JdeDataType.Numeric),
        new JdeField("VOHDAR", "VOHDAR", JdeDataType.String, 2),
        new JdeField("VOTRAR", "VOTRAR", JdeDataType.String, 6),
        new JdeField("VOSTTO", "VOSTTO", JdeDataType.String, 2),
        new JdeField("VORYIN", "VORYIN", JdeDataType.String, 2),
        new JdeField("VOSTMT", "VOSTMT", JdeDataType.String, 2),
        new JdeField("VOARPY", "VOARPY", JdeDataType.Numeric),
        new JdeField("VOATCS", "VOATCS", JdeDataType.String, 2),
        new JdeField("VOSITO", "VOSITO", JdeDataType.String, 2),
        new JdeField("VOSQNL", "VOSQNL", JdeDataType.String, 2),
        new JdeField("VOALGM", "VOALGM", JdeDataType.String, 4),
        new JdeField("VOCYCN", "VOCYCN", JdeDataType.String, 4),
        new JdeField("VOBO", "VOBO", JdeDataType.String, 2),
        new JdeField("VOTSTA", "VOTSTA", JdeDataType.String, 4),
        new JdeField("VOCKHC", "VOCKHC", JdeDataType.String, 2),
        new JdeField("VODLC", "VODLC", JdeDataType.Numeric),
        new JdeField("VODNLT", "VODNLT", JdeDataType.String, 2),
        new JdeField("VOPLCR", "VOPLCR", JdeDataType.String, 20),
        new JdeField("VORVDJ", "VORVDJ", JdeDataType.Numeric),
        new JdeField("VODSO", "VODSO", JdeDataType.Numeric),
        new JdeField("VOCMGR", "VOCMGR", JdeDataType.String, 20),
        new JdeField("VOCLMG", "VOCLMG", JdeDataType.String, 20),
        new JdeField("VODLQT", "VODLQT", JdeDataType.Numeric),
        new JdeField("VODLQJ", "VODLQJ", JdeDataType.Numeric),
        new JdeField("VONBRR", "VONBRR", JdeDataType.String, 2),
        new JdeField("VOCOLL", "VOCOLL", JdeDataType.String, 2),
        new JdeField("VONBR1", "VONBR1", JdeDataType.Numeric),
        new JdeField("VONBR2", "VONBR2", JdeDataType.Numeric),
        new JdeField("VONBR3", "VONBR3", JdeDataType.Numeric),
        new JdeField("VONBCL", "VONBCL", JdeDataType.Numeric),
        new JdeField("VOAFC", "VOAFC", JdeDataType.String, 2),
        new JdeField("VOFD", "VOFD", JdeDataType.Numeric),
        new JdeField("VOFP", "VOFP", JdeDataType.Numeric),
        new JdeField("VOCFCE", "VOCFCE", JdeDataType.String, 2),
        new JdeField("VOAB2", "VOAB2", JdeDataType.String, 2),
        new JdeField("VODT1J", "VODT1J", JdeDataType.Numeric),
        new JdeField("VODFIJ", "VODFIJ", JdeDataType.Numeric),
        new JdeField("VODLIJ", "VODLIJ", JdeDataType.Numeric),
        new JdeField("VOABC1", "VOABC1", JdeDataType.String, 2),
        new JdeField("VOABC2", "VOABC2", JdeDataType.String, 2),
        new JdeField("VOABC3", "VOABC3", JdeDataType.String, 2),
        new JdeField("VOFNDJ", "VOFNDJ", JdeDataType.Numeric),
        new JdeField("VODLP", "VODLP", JdeDataType.Numeric),
        new JdeField("VODB", "VODB", JdeDataType.String, 6),
        new JdeField("VODNBJ", "VODNBJ", JdeDataType.Numeric),
        new JdeField("VOTRW", "VOTRW", JdeDataType.String, 6),
        new JdeField("VOTWDJ", "VOTWDJ", JdeDataType.Numeric),
        new JdeField("VOAVD", "VOAVD", JdeDataType.Numeric),
        new JdeField("VOCRCA", "VOCRCA", JdeDataType.String, 6),
        new JdeField("VOAD", "VOAD", JdeDataType.Numeric),
        new JdeField("VOAFCP", "VOAFCP", JdeDataType.Numeric),
        new JdeField("VOAFCY", "VOAFCY", JdeDataType.Numeric),
        new JdeField("VOASTY", "VOASTY", JdeDataType.Numeric),
        new JdeField("VOSPYE", "VOSPYE", JdeDataType.Numeric),
        new JdeField("VOAHB", "VOAHB", JdeDataType.Numeric),
        new JdeField("VOALP", "VOALP", JdeDataType.Numeric),
        new JdeField("VOABAM", "VOABAM", JdeDataType.Numeric),
        new JdeField("VOABA1", "VOABA1", JdeDataType.Numeric),
        new JdeField("VOAPRC", "VOAPRC", JdeDataType.Numeric),
        new JdeField("VOMAXO", "VOMAXO", JdeDataType.Numeric),
        new JdeField("VOMINO", "VOMINO", JdeDataType.Numeric),
        new JdeField("VOOYTD", "VOOYTD", JdeDataType.Numeric),
        new JdeField("VOOPY", "VOOPY", JdeDataType.Numeric),
        new JdeField("VOPOPN", "VOPOPN", JdeDataType.String, 20),
        new JdeField("VODAOJ", "VODAOJ", JdeDataType.Numeric),
        new JdeField("VOAN8R", "VOAN8R", JdeDataType.Numeric),
        new JdeField("VOBADT", "VOBADT", JdeDataType.String, 2),
        new JdeField("VOCPGP", "VOCPGP", JdeDataType.String, 16),
        new JdeField("VOORTP", "VOORTP", JdeDataType.String, 16),
        new JdeField("VOTRDC", "VOTRDC", JdeDataType.Numeric),
        new JdeField("VOINMG", "VOINMG", JdeDataType.String, 20),
        new JdeField("VOEXHD", "VOEXHD", JdeDataType.String, 2),
        new JdeField("VOHOLD", "VOHOLD", JdeDataType.String, 4),
        new JdeField("VOROUT", "VOROUT", JdeDataType.String, 6),
        new JdeField("VOSTOP", "VOSTOP", JdeDataType.String, 6),
        new JdeField("VOZON", "VOZON", JdeDataType.String, 6),
        new JdeField("VOCARS", "VOCARS", JdeDataType.Numeric),
        new JdeField("VODEL1", "VODEL1", JdeDataType.String, 60),
        new JdeField("VODEL2", "VODEL2", JdeDataType.String, 60),
        new JdeField("VOLTDT", "VOLTDT", JdeDataType.Numeric),
        new JdeField("VOFRTH", "VOFRTH", JdeDataType.String, 6),
        new JdeField("VOAFT", "VOAFT", JdeDataType.String, 2),
        new JdeField("VOAPTS", "VOAPTS", JdeDataType.String, 2),
        new JdeField("VOSBAL", "VOSBAL", JdeDataType.String, 2),
        new JdeField("VOBACK", "VOBACK", JdeDataType.String, 2),
        new JdeField("VOPORQ", "VOPORQ", JdeDataType.String, 2),
        new JdeField("VOPRIO", "VOPRIO", JdeDataType.String, 2),
        new JdeField("VOARTO", "VOARTO", JdeDataType.String, 2),
        new JdeField("VOINVC", "VOINVC", JdeDataType.Numeric),
        new JdeField("VOICON", "VOICON", JdeDataType.String, 2),
        new JdeField("VOBLFR", "VOBLFR", JdeDataType.String, 2),
        new JdeField("VONIVD", "VONIVD", JdeDataType.Numeric),
        new JdeField("VOLEDJ", "VOLEDJ", JdeDataType.Numeric),
        new JdeField("VOPLST", "VOPLST", JdeDataType.String, 2),
        new JdeField("VOMORD", "VOMORD", JdeDataType.String, 2),
        new JdeField("VOCMC1", "VOCMC1", JdeDataType.Numeric),
        new JdeField("VOCMR1", "VOCMR1", JdeDataType.Numeric),
        new JdeField("VOCMC2", "VOCMC2", JdeDataType.Numeric),
        new JdeField("VOCMR2", "VOCMR2", JdeDataType.Numeric),
        new JdeField("VOPALC", "VOPALC", JdeDataType.String, 2),
        new JdeField("VOVUMD", "VOVUMD", JdeDataType.String, 4),
        new JdeField("VOWUMD", "VOWUMD", JdeDataType.String, 4),
        new JdeField("VOEDPM", "VOEDPM", JdeDataType.String, 2),
        new JdeField("VOEDII", "VOEDII", JdeDataType.String, 2),
        new JdeField("VOEDCI", "VOEDCI", JdeDataType.String, 2),
        new JdeField("VOEDQD", "VOEDQD", JdeDataType.Numeric),
        new JdeField("VOEDAD", "VOEDAD", JdeDataType.Numeric),
        new JdeField("VOEDF1", "VOEDF1", JdeDataType.String, 2),
        new JdeField("VOEDF2", "VOEDF2", JdeDataType.String, 2),
        new JdeField("VOSI01", "VOSI01", JdeDataType.String, 2),
        new JdeField("VOSI02", "VOSI02", JdeDataType.String, 2),
        new JdeField("VOSI03", "VOSI03", JdeDataType.String, 2),
        new JdeField("VOSI04", "VOSI04", JdeDataType.String, 2),
        new JdeField("VOSI05", "VOSI05", JdeDataType.String, 2),
        new JdeField("VOCP01", "VOCP01", JdeDataType.String, 2),
        new JdeField("VOASN", "VOASN", JdeDataType.String, 16),
        new JdeField("VODSPA", "VODSPA", JdeDataType.String, 2),
        new JdeField("VOCRMD", "VOCRMD", JdeDataType.String, 2),
        new JdeField("VOPLY", "VOPLY", JdeDataType.Numeric),
        new JdeField("VOMAN8", "VOMAN8", JdeDataType.Numeric),
        new JdeField("VOARL", "VOARL", JdeDataType.String, 20),
        new JdeField("VOAMCR", "VOAMCR", JdeDataType.Numeric),
        new JdeField("VOAC01", "VOAC01", JdeDataType.String, 6),
        new JdeField("VOAC02", "VOAC02", JdeDataType.String, 6),
        new JdeField("VOAC03", "VOAC03", JdeDataType.String, 6),
        new JdeField("VOAC04", "VOAC04", JdeDataType.String, 6),
        new JdeField("VOAC05", "VOAC05", JdeDataType.String, 6),
        new JdeField("VOAC06", "VOAC06", JdeDataType.String, 6),
        new JdeField("VOAC07", "VOAC07", JdeDataType.String, 6),
        new JdeField("VOAC08", "VOAC08", JdeDataType.String, 6),
        new JdeField("VOAC09", "VOAC09", JdeDataType.String, 6),
        new JdeField("VOAC10", "VOAC10", JdeDataType.String, 6),
        new JdeField("VOAC11", "VOAC11", JdeDataType.String, 6),
        new JdeField("VOAC12", "VOAC12", JdeDataType.String, 6),
        new JdeField("VOAC13", "VOAC13", JdeDataType.String, 6),
        new JdeField("VOAC14", "VOAC14", JdeDataType.String, 6),
        new JdeField("VOAC15", "VOAC15", JdeDataType.String, 6),
        new JdeField("VOAC16", "VOAC16", JdeDataType.String, 6),
        new JdeField("VOAC17", "VOAC17", JdeDataType.String, 6),
        new JdeField("VOAC18", "VOAC18", JdeDataType.String, 6),
        new JdeField("VOAC19", "VOAC19", JdeDataType.String, 6),
        new JdeField("VOAC20", "VOAC20", JdeDataType.String, 6),
        new JdeField("VOAC21", "VOAC21", JdeDataType.String, 6),
        new JdeField("VOAC22", "VOAC22", JdeDataType.String, 6),
        new JdeField("VOAC23", "VOAC23", JdeDataType.String, 6),
        new JdeField("VOAC24", "VOAC24", JdeDataType.String, 6),
        new JdeField("VOAC25", "VOAC25", JdeDataType.String, 6),
        new JdeField("VOAC26", "VOAC26", JdeDataType.String, 6),
        new JdeField("VOAC27", "VOAC27", JdeDataType.String, 6),
        new JdeField("VOAC28", "VOAC28", JdeDataType.String, 6),
        new JdeField("VOAC29", "VOAC29", JdeDataType.String, 6),
        new JdeField("VOAC30", "VOAC30", JdeDataType.String, 6),
        new JdeField("VOSLPG", "VOSLPG", JdeDataType.String, 20),
        new JdeField("VOSLDW", "VOSLDW", JdeDataType.String, 20),
        new JdeField("VOCFPP", "VOCFPP", JdeDataType.String, 36),
        new JdeField("VOCFSP", "VOCFSP", JdeDataType.String, 36),
        new JdeField("VOCFDF", "VOCFDF", JdeDataType.String, 2),
        new JdeField("VORQ01", "VORQ01", JdeDataType.String, 2),
        new JdeField("VORQ02", "VORQ02", JdeDataType.String, 2),
        new JdeField("VORQ03", "VORQ03", JdeDataType.String, 2),
        new JdeField("VORQ04", "VORQ04", JdeDataType.String, 2),
        new JdeField("VORQ05", "VORQ05", JdeDataType.String, 2),
        new JdeField("VORQ06", "VORQ06", JdeDataType.String, 2),
        new JdeField("VORQ07", "VORQ07", JdeDataType.String, 2),
        new JdeField("VORQ08", "VORQ08", JdeDataType.String, 2),
        new JdeField("VORQ09", "VORQ09", JdeDataType.String, 2),
        new JdeField("VODR03", "VODR03", JdeDataType.String, 4),
        new JdeField("VODR04", "VODR04", JdeDataType.String, 4),
        new JdeField("VODR08", "VODR08", JdeDataType.String, 4),
        new JdeField("VODR09", "VODR09", JdeDataType.String, 4),
        new JdeField("VOURDT", "VOURDT", JdeDataType.Numeric),
        new JdeField("VOURCD", "VOURCD", JdeDataType.String, 4),
        new JdeField("VOURAT", "VOURAT", JdeDataType.Numeric),
        new JdeField("VOURAB", "VOURAB", JdeDataType.Numeric),
        new JdeField("VOURRF", "VOURRF", JdeDataType.String, 30),
        new JdeField("VOTORG", "VOTORG", JdeDataType.String, 20),
        new JdeField("VOUSER", "VOUSER", JdeDataType.String, 20),
        new JdeField("VOPID", "VOPID", JdeDataType.String, 20),
        new JdeField("VOJOBN", "VOJOBN", JdeDataType.String, 20),
        new JdeField("VOUPMT", "VOUPMT", JdeDataType.Numeric),
        new JdeField("VOUPMJ", "VOUPMJ", JdeDataType.Numeric),
        new JdeField("VOTDAY", "VOTDAY", JdeDataType.Numeric),
        new JdeField("VOPRGF", "VOPRGF", JdeDataType.String, 2),
        new JdeField("VOBYAL", "VOBYAL", JdeDataType.String, 2),
        new JdeField("VOBSC", "VOBSC", JdeDataType.String, 20),
        new JdeField("VOASHL", "VOASHL", JdeDataType.String, 2),
        new JdeField("VOPRSN", "VOPRSN", JdeDataType.String, 16),
        new JdeField("VOOPBO", "VOOPBO", JdeDataType.String, 60),
        new JdeField("VOAPSB", "VOAPSB", JdeDataType.String, 2),
        new JdeField("VOTIER1", "VOTIER1", JdeDataType.String, 10),
        new JdeField("VOPWPCP", "VOPWPCP", JdeDataType.Numeric),
        new JdeField("VOCUSTS", "VOCUSTS", JdeDataType.String, 2),
        new JdeField("VOSTOF", "VOSTOF", JdeDataType.String, 2),
        new JdeField("VOTERRID", "VOTERRID", JdeDataType.Numeric),
        new JdeField("VOCIG", "VOCIG", JdeDataType.Numeric),
        new JdeField("VODTEE", "VODTEE", JdeDataType.Date),
        new JdeField("VOGOPASF", "VOGOPASF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03012Z1_0", "Primary Key on VOEDUS, VOEDBT, VOEDTN, VOEDLN", new[] { "VOEDUS", "VOEDBT", "VOEDTN", "VOEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03012Z1_2", "Index on VOEDUS, VOEDBT", new[] { "VOEDUS", "VOEDBT" })
    };
}
