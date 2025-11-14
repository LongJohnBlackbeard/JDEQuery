using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186602 - .
/// </summary>
public class F186602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFPRTR.
        /// </summary>
        public const string TFPRTR = "TFPRTR";

        /// <summary>
        /// TFLRSBAT.
        /// </summary>
        public const string TFLRSBAT = "TFLRSBAT";

        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFLRSPTN.
        /// </summary>
        public const string TFLRSPTN = "TFLRSPTN";

        /// <summary>
        /// TFLRSCHF.
        /// </summary>
        public const string TFLRSCHF = "TFLRSCHF";

        /// <summary>
        /// TFLRSORID.
        /// </summary>
        public const string TFLRSORID = "TFLRSORID";

        /// <summary>
        /// TFLRSOPT.
        /// </summary>
        public const string TFLRSOPT = "TFLRSOPT";

        /// <summary>
        /// TFLRSODWK.
        /// </summary>
        public const string TFLRSODWK = "TFLRSODWK";

        /// <summary>
        /// TFLRSOHW.
        /// </summary>
        public const string TFLRSOHW = "TFLRSOHW";

        /// <summary>
        /// TFLRSOHR.
        /// </summary>
        public const string TFLRSOHR = "TFLRSOHR";

        /// <summary>
        /// TFLRSOGP.
        /// </summary>
        public const string TFLRSOGP = "TFLRSOGP";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFTDAY.
        /// </summary>
        public const string TFTDAY = "TFTDAY";

        /// <summary>
        /// TFPALF.
        /// </summary>
        public const string TFPALF = "TFPALF";

        /// <summary>
        /// TFRCCD.
        /// </summary>
        public const string TFRCCD = "TFRCCD";

        /// <summary>
        /// TFCKCN.
        /// </summary>
        public const string TFCKCN = "TFCKCN";

        /// <summary>
        /// TFAM.
        /// </summary>
        public const string TFAM = "TFAM";

        /// <summary>
        /// TFCO.
        /// </summary>
        public const string TFCO = "TFCO";

        /// <summary>
        /// TFHMCO.
        /// </summary>
        public const string TFHMCO = "TFHMCO";

        /// <summary>
        /// TFHMCU.
        /// </summary>
        public const string TFHMCU = "TFHMCU";

        /// <summary>
        /// TFMCU.
        /// </summary>
        public const string TFMCU = "TFMCU";

        /// <summary>
        /// TFOBJ.
        /// </summary>
        public const string TFOBJ = "TFOBJ";

        /// <summary>
        /// TFSUB.
        /// </summary>
        public const string TFSUB = "TFSUB";

        /// <summary>
        /// TFRCO.
        /// </summary>
        public const string TFRCO = "TFRCO";

        /// <summary>
        /// TFGMCU.
        /// </summary>
        public const string TFGMCU = "TFGMCU";

        /// <summary>
        /// TFGOBJ.
        /// </summary>
        public const string TFGOBJ = "TFGOBJ";

        /// <summary>
        /// TFGSUB.
        /// </summary>
        public const string TFGSUB = "TFGSUB";

        /// <summary>
        /// TFSBL.
        /// </summary>
        public const string TFSBL = "TFSBL";

        /// <summary>
        /// TFSBLT.
        /// </summary>
        public const string TFSBLT = "TFSBLT";

        /// <summary>
        /// TFWR01.
        /// </summary>
        public const string TFWR01 = "TFWR01";

        /// <summary>
        /// TFMCUO.
        /// </summary>
        public const string TFMCUO = "TFMCUO";

        /// <summary>
        /// TFMAIL.
        /// </summary>
        public const string TFMAIL = "TFMAIL";

        /// <summary>
        /// TFOPSQ.
        /// </summary>
        public const string TFOPSQ = "TFOPSQ";

        /// <summary>
        /// TFRILT.
        /// </summary>
        public const string TFRILT = "TFRILT";

        /// <summary>
        /// TFITM.
        /// </summary>
        public const string TFITM = "TFITM";

        /// <summary>
        /// TFPCUN.
        /// </summary>
        public const string TFPCUN = "TFPCUN";

        /// <summary>
        /// TFUM.
        /// </summary>
        public const string TFUM = "TFUM";

        /// <summary>
        /// TFPPRT.
        /// </summary>
        public const string TFPPRT = "TFPPRT";

        /// <summary>
        /// TFBHRT.
        /// </summary>
        public const string TFBHRT = "TFBHRT";

        /// <summary>
        /// TFPBRT.
        /// </summary>
        public const string TFPBRT = "TFPBRT";

        /// <summary>
        /// TFBDRT.
        /// </summary>
        public const string TFBDRT = "TFBDRT";

        /// <summary>
        /// TFSHRT.
        /// </summary>
        public const string TFSHRT = "TFSHRT";

        /// <summary>
        /// TFSHFT.
        /// </summary>
        public const string TFSHFT = "TFSHFT";

        /// <summary>
        /// TFSHD.
        /// </summary>
        public const string TFSHD = "TFSHD";

        /// <summary>
        /// TFPAYM.
        /// </summary>
        public const string TFPAYM = "TFPAYM";

        /// <summary>
        /// TFLD.
        /// </summary>
        public const string TFLD = "TFLD";

        /// <summary>
        /// TFDPA.
        /// </summary>
        public const string TFDPA = "TFDPA";

        /// <summary>
        /// TFRCPY.
        /// </summary>
        public const string TFRCPY = "TFRCPY";

        /// <summary>
        /// TFSAMT.
        /// </summary>
        public const string TFSAMT = "TFSAMT";

        /// <summary>
        /// TFUN.
        /// </summary>
        public const string TFUN = "TFUN";

        /// <summary>
        /// TFJBCD.
        /// </summary>
        public const string TFJBCD = "TFJBCD";

        /// <summary>
        /// TFJBST.
        /// </summary>
        public const string TFJBST = "TFJBST";

        /// <summary>
        /// TFWST.
        /// </summary>
        public const string TFWST = "TFWST";

        /// <summary>
        /// TFWCNT.
        /// </summary>
        public const string TFWCNT = "TFWCNT";

        /// <summary>
        /// TFWCTY.
        /// </summary>
        public const string TFWCTY = "TFWCTY";

        /// <summary>
        /// TFWCMP.
        /// </summary>
        public const string TFWCMP = "TFWCMP";

        /// <summary>
        /// TFWET.
        /// </summary>
        public const string TFWET = "TFWET";

        /// <summary>
        /// TFGENA.
        /// </summary>
        public const string TFGENA = "TFGENA";

        /// <summary>
        /// TFWCAM.
        /// </summary>
        public const string TFWCAM = "TFWCAM";

        /// <summary>
        /// TFWCMB.
        /// </summary>
        public const string TFWCMB = "TFWCMB";

        /// <summary>
        /// TFGENB.
        /// </summary>
        public const string TFGENB = "TFGENB";

        /// <summary>
        /// TFWCMO.
        /// </summary>
        public const string TFWCMO = "TFWCMO";

        /// <summary>
        /// TFGENO.
        /// </summary>
        public const string TFGENO = "TFGENO";

        /// <summary>
        /// TFWCMX.
        /// </summary>
        public const string TFWCMX = "TFWCMX";

        /// <summary>
        /// TFGENX.
        /// </summary>
        public const string TFGENX = "TFGENX";

        /// <summary>
        /// TFWCBN.
        /// </summary>
        public const string TFWCBN = "TFWCBN";

        /// <summary>
        /// TFHMO.
        /// </summary>
        public const string TFHMO = "TFHMO";

        /// <summary>
        /// TFPB.
        /// </summary>
        public const string TFPB = "TFPB";

        /// <summary>
        /// TFDEDM.
        /// </summary>
        public const string TFDEDM = "TFDEDM";

        /// <summary>
        /// TFSALY.
        /// </summary>
        public const string TFSALY = "TFSALY";

        /// <summary>
        /// TFNMTH.
        /// </summary>
        public const string TFNMTH = "TFNMTH";

        /// <summary>
        /// TFPFRQ.
        /// </summary>
        public const string TFPFRQ = "TFPFRQ";

        /// <summary>
        /// TFFY.
        /// </summary>
        public const string TFFY = "TFFY";

        /// <summary>
        /// TFDGL.
        /// </summary>
        public const string TFDGL = "TFDGL";

        /// <summary>
        /// TFPN.
        /// </summary>
        public const string TFPN = "TFPN";

        /// <summary>
        /// TFDW.
        /// </summary>
        public const string TFDW = "TFDW";

        /// <summary>
        /// TFPPED.
        /// </summary>
        public const string TFPPED = "TFPPED";

        /// <summary>
        /// TFPPP.
        /// </summary>
        public const string TFPPP = "TFPPP";

        /// <summary>
        /// TFDTBT.
        /// </summary>
        public const string TFDTBT = "TFDTBT";

        /// <summary>
        /// TFTCDE.
        /// </summary>
        public const string TFTCDE = "TFTCDE";

        /// <summary>
        /// TFEQCO.
        /// </summary>
        public const string TFEQCO = "TFEQCO";

        /// <summary>
        /// TFEQWO.
        /// </summary>
        public const string TFEQWO = "TFEQWO";

        /// <summary>
        /// TFEQCG.
        /// </summary>
        public const string TFEQCG = "TFEQCG";

        /// <summary>
        /// TFQOBJ.
        /// </summary>
        public const string TFQOBJ = "TFQOBJ";

        /// <summary>
        /// TFERC.
        /// </summary>
        public const string TFERC = "TFERC";

        /// <summary>
        /// TFEQRT.
        /// </summary>
        public const string TFEQRT = "TFEQRT";

        /// <summary>
        /// TFEQGR.
        /// </summary>
        public const string TFEQGR = "TFEQGR";

        /// <summary>
        /// TFEQHR.
        /// </summary>
        public const string TFEQHR = "TFEQHR";

        /// <summary>
        /// TFEXR.
        /// </summary>
        public const string TFEXR = "TFEXR";

        /// <summary>
        /// TFP001.
        /// </summary>
        public const string TFP001 = "TFP001";

        /// <summary>
        /// TFP002.
        /// </summary>
        public const string TFP002 = "TFP002";

        /// <summary>
        /// TFP003.
        /// </summary>
        public const string TFP003 = "TFP003";

        /// <summary>
        /// TFP004.
        /// </summary>
        public const string TFP004 = "TFP004";

        /// <summary>
        /// TFCMMT.
        /// </summary>
        public const string TFCMMT = "TFCMMT";

        /// <summary>
        /// TFCKDT.
        /// </summary>
        public const string TFCKDT = "TFCKDT";

        /// <summary>
        /// TFUAMT.
        /// </summary>
        public const string TFUAMT = "TFUAMT";

        /// <summary>
        /// TFYST.
        /// </summary>
        public const string TFYST = "TFYST";

        /// <summary>
        /// TFICU.
        /// </summary>
        public const string TFICU = "TFICU";

        /// <summary>
        /// TFGICU.
        /// </summary>
        public const string TFGICU = "TFGICU";

        /// <summary>
        /// TFDICJ.
        /// </summary>
        public const string TFDICJ = "TFDICJ";

        /// <summary>
        /// TFANI.
        /// </summary>
        public const string TFANI = "TFANI";

        /// <summary>
        /// TFCTRY.
        /// </summary>
        public const string TFCTRY = "TFCTRY";

        /// <summary>
        /// TFANN8.
        /// </summary>
        public const string TFANN8 = "TFANN8";

        /// <summary>
        /// TFPGRP.
        /// </summary>
        public const string TFPGRP = "TFPGRP";

        /// <summary>
        /// TFPAYG.
        /// </summary>
        public const string TFPAYG = "TFPAYG";

        /// <summary>
        /// TFPAYN.
        /// </summary>
        public const string TFPAYN = "TFPAYN";

        /// <summary>
        /// TFSFLG.
        /// </summary>
        public const string TFSFLG = "TFSFLG";

        /// <summary>
        /// TFWS.
        /// </summary>
        public const string TFWS = "TFWS";

        /// <summary>
        /// TFPCK.
        /// </summary>
        public const string TFPCK = "TFPCK";

        /// <summary>
        /// TFICC.
        /// </summary>
        public const string TFICC = "TFICC";

        /// <summary>
        /// TFICS.
        /// </summary>
        public const string TFICS = "TFICS";

        /// <summary>
        /// TFCMTH.
        /// </summary>
        public const string TFCMTH = "TFCMTH";

        /// <summary>
        /// TFACO.
        /// </summary>
        public const string TFACO = "TFACO";

        /// <summary>
        /// TFAI.
        /// </summary>
        public const string TFAI = "TFAI";

        /// <summary>
        /// TFSEC$.
        /// </summary>
        public const string TFSEC_ = "TFSEC$";

        /// <summary>
        /// TFOHF.
        /// </summary>
        public const string TFOHF = "TFOHF";

        /// <summary>
        /// TFDEP1.
        /// </summary>
        public const string TFDEP1 = "TFDEP1";

        /// <summary>
        /// TFDEP2.
        /// </summary>
        public const string TFDEP2 = "TFDEP2";

        /// <summary>
        /// TFDEP3.
        /// </summary>
        public const string TFDEP3 = "TFDEP3";

        /// <summary>
        /// TFDEP4.
        /// </summary>
        public const string TFDEP4 = "TFDEP4";

        /// <summary>
        /// TFDEP5.
        /// </summary>
        public const string TFDEP5 = "TFDEP5";

        /// <summary>
        /// TFDEP6.
        /// </summary>
        public const string TFDEP6 = "TFDEP6";

        /// <summary>
        /// TFTT01.
        /// </summary>
        public const string TFTT01 = "TFTT01";

        /// <summary>
        /// TFTT02.
        /// </summary>
        public const string TFTT02 = "TFTT02";

        /// <summary>
        /// TFTT03.
        /// </summary>
        public const string TFTT03 = "TFTT03";

        /// <summary>
        /// TFTT04.
        /// </summary>
        public const string TFTT04 = "TFTT04";

        /// <summary>
        /// TFTT05.
        /// </summary>
        public const string TFTT05 = "TFTT05";

        /// <summary>
        /// TFTT06.
        /// </summary>
        public const string TFTT06 = "TFTT06";

        /// <summary>
        /// TFTT07.
        /// </summary>
        public const string TFTT07 = "TFTT07";

        /// <summary>
        /// TFTT08.
        /// </summary>
        public const string TFTT08 = "TFTT08";

        /// <summary>
        /// TFTT09.
        /// </summary>
        public const string TFTT09 = "TFTT09";

        /// <summary>
        /// TFTT10.
        /// </summary>
        public const string TFTT10 = "TFTT10";

        /// <summary>
        /// TFTT11.
        /// </summary>
        public const string TFTT11 = "TFTT11";

        /// <summary>
        /// TFTT12.
        /// </summary>
        public const string TFTT12 = "TFTT12";

        /// <summary>
        /// TFTT13.
        /// </summary>
        public const string TFTT13 = "TFTT13";

        /// <summary>
        /// TFTT14.
        /// </summary>
        public const string TFTT14 = "TFTT14";

        /// <summary>
        /// TFTT15.
        /// </summary>
        public const string TFTT15 = "TFTT15";

        /// <summary>
        /// TFUSR.
        /// </summary>
        public const string TFUSR = "TFUSR";

        /// <summary>
        /// TFEPA.
        /// </summary>
        public const string TFEPA = "TFEPA";

        /// <summary>
        /// TFBFA.
        /// </summary>
        public const string TFBFA = "TFBFA";

        /// <summary>
        /// TFRTWC.
        /// </summary>
        public const string TFRTWC = "TFRTWC";

        /// <summary>
        /// TFGENR.
        /// </summary>
        public const string TFGENR = "TFGENR";

        /// <summary>
        /// TFADV.
        /// </summary>
        public const string TFADV = "TFADV";

        /// <summary>
        /// TFSTIP.
        /// </summary>
        public const string TFSTIP = "TFSTIP";

        /// <summary>
        /// TFALPH.
        /// </summary>
        public const string TFALPH = "TFALPH";

        /// <summary>
        /// TFIIAP.
        /// </summary>
        public const string TFIIAP = "TFIIAP";

        /// <summary>
        /// TFFICM.
        /// </summary>
        public const string TFFICM = "TFFICM";

        /// <summary>
        /// TFDTAB.
        /// </summary>
        public const string TFDTAB = "TFDTAB";

        /// <summary>
        /// TFDTSP.
        /// </summary>
        public const string TFDTSP = "TFDTSP";

        /// <summary>
        /// TFYST1.
        /// </summary>
        public const string TFYST1 = "TFYST1";

        /// <summary>
        /// TFCKCS.
        /// </summary>
        public const string TFCKCS = "TFCKCS";

        /// <summary>
        /// TFALT0.
        /// </summary>
        public const string TFALT0 = "TFALT0";

        /// <summary>
        /// TFPOS.
        /// </summary>
        public const string TFPOS = "TFPOS";

        /// <summary>
        /// TFACTB.
        /// </summary>
        public const string TFACTB = "TFACTB";

        /// <summary>
        /// TFABR1.
        /// </summary>
        public const string TFABR1 = "TFABR1";

        /// <summary>
        /// TFABT1.
        /// </summary>
        public const string TFABT1 = "TFABT1";

        /// <summary>
        /// TFABR2.
        /// </summary>
        public const string TFABR2 = "TFABR2";

        /// <summary>
        /// TFABT2.
        /// </summary>
        public const string TFABT2 = "TFABT2";

        /// <summary>
        /// TFABR3.
        /// </summary>
        public const string TFABR3 = "TFABR3";

        /// <summary>
        /// TFABT3.
        /// </summary>
        public const string TFABT3 = "TFABT3";

        /// <summary>
        /// TFABR4.
        /// </summary>
        public const string TFABR4 = "TFABR4";

        /// <summary>
        /// TFABT4.
        /// </summary>
        public const string TFABT4 = "TFABT4";

        /// <summary>
        /// TFBLGRT.
        /// </summary>
        public const string TFBLGRT = "TFBLGRT";

        /// <summary>
        /// TFRCHGAMT.
        /// </summary>
        public const string TFRCHGAMT = "TFRCHGAMT";

        /// <summary>
        /// TFFBLGRT.
        /// </summary>
        public const string TFFBLGRT = "TFFBLGRT";

        /// <summary>
        /// TFFRCHGAMT.
        /// </summary>
        public const string TFFRCHGAMT = "TFFRCHGAMT";

        /// <summary>
        /// TFCRR.
        /// </summary>
        public const string TFCRR = "TFCRR";

        /// <summary>
        /// TFCRCD.
        /// </summary>
        public const string TFCRCD = "TFCRCD";

        /// <summary>
        /// TFCRDC.
        /// </summary>
        public const string TFCRDC = "TFCRDC";

        /// <summary>
        /// TFRCHGMODE.
        /// </summary>
        public const string TFRCHGMODE = "TFRCHGMODE";

        /// <summary>
        /// TFLTTP.
        /// </summary>
        public const string TFLTTP = "TFLTTP";

        /// <summary>
        /// TFRKID.
        /// </summary>
        public const string TFRKID = "TFRKID";

        /// <summary>
        /// TFTELKFLG.
        /// </summary>
        public const string TFTELKFLG = "TFTELKFLG";

        /// <summary>
        /// TFAPPRCFLG.
        /// </summary>
        public const string TFAPPRCFLG = "TFAPPRCFLG";

        /// <summary>
        /// TFOTRULECD.
        /// </summary>
        public const string TFOTRULECD = "TFOTRULECD";

        /// <summary>
        /// TFTSKID.
        /// </summary>
        public const string TFTSKID = "TFTSKID";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";

        /// <summary>
        /// TFTAXX.
        /// </summary>
        public const string TFTAXX = "TFTAXX";

        /// <summary>
        /// TFSCTR.
        /// </summary>
        public const string TFSCTR = "TFSCTR";

        /// <summary>
        /// TFSCRX.
        /// </summary>
        public const string TFSCRX = "TFSCRX";

        /// <summary>
        /// TFSVH.
        /// </summary>
        public const string TFSVH = "TFSVH";

        /// <summary>
        /// TFTCFD.
        /// </summary>
        public const string TFTCFD = "TFTCFD";

        /// <summary>
        /// TFTCTD.
        /// </summary>
        public const string TFTCTD = "TFTCTD";

        /// <summary>
        /// TFHWPD.
        /// </summary>
        public const string TFHWPD = "TFHWPD";

        /// <summary>
        /// TFINSTID.
        /// </summary>
        public const string TFINSTID = "TFINSTID";

        /// <summary>
        /// TFTCUN.
        /// </summary>
        public const string TFTCUN = "TFTCUN";

        /// <summary>
        /// TFTCHC.
        /// </summary>
        public const string TFTCHC = "TFTCHC";

        /// <summary>
        /// TFTCHB.
        /// </summary>
        public const string TFTCHB = "TFTCHB";

        /// <summary>
        /// TFTCJT.
        /// </summary>
        public const string TFTCJT = "TFTCJT";

        /// <summary>
        /// TFTCJS.
        /// </summary>
        public const string TFTCJS = "TFTCJS";

        /// <summary>
        /// TFTCRT.
        /// </summary>
        public const string TFTCRT = "TFTCRT";

        /// <summary>
        /// TFTCSC.
        /// </summary>
        public const string TFTCSC = "TFTCSC";

        /// <summary>
        /// TFTCSD.
        /// </summary>
        public const string TFTCSD = "TFTCSD";

        /// <summary>
        /// TFTCBR.
        /// </summary>
        public const string TFTCBR = "TFTCBR";

        /// <summary>
        /// TFTCPC.
        /// </summary>
        public const string TFTCPC = "TFTCPC";

        /// <summary>
        /// TFTCWC.
        /// </summary>
        public const string TFTCWC = "TFTCWC";

        /// <summary>
        /// TFTCWS.
        /// </summary>
        public const string TFTCWS = "TFTCWS";

        /// <summary>
        /// TFTCJL.
        /// </summary>
        public const string TFTCJL = "TFTCJL";

        /// <summary>
        /// TFTCANI.
        /// </summary>
        public const string TFTCANI = "TFTCANI";

        /// <summary>
        /// TFTCRFLG.
        /// </summary>
        public const string TFTCRFLG = "TFTCRFLG";

        /// <summary>
        /// TFJBLC.
        /// </summary>
        public const string TFJBLC = "TFJBLC";

        /// <summary>
        /// TFCOPX.
        /// </summary>
        public const string TFCOPX = "TFCOPX";

        /// <summary>
        /// TFBPTX.
        /// </summary>
        public const string TFBPTX = "TFBPTX";

        /// <summary>
        /// TFCOPB.
        /// </summary>
        public const string TFCOPB = "TFCOPB";

        /// <summary>
        /// TFCMED.
        /// </summary>
        public const string TFCMED = "TFCMED";

        /// <summary>
        /// TFCOPR.
        /// </summary>
        public const string TFCOPR = "TFCOPR";

        /// <summary>
        /// TFGLBN.
        /// </summary>
        public const string TFGLBN = "TFGLBN";

        /// <summary>
        /// TFWCEX.
        /// </summary>
        public const string TFWCEX = "TFWCEX";

        /// <summary>
        /// TFGLEX.
        /// </summary>
        public const string TFGLEX = "TFGLEX";

        /// <summary>
        /// TFLDID.
        /// </summary>
        public const string TFLDID = "TFLDID";

        /// <summary>
        /// TFLDED.
        /// </summary>
        public const string TFLDED = "TFLDED";

        /// <summary>
        /// TFTTAP.
        /// </summary>
        public const string TFTTAP = "TFTTAP";

        /// <summary>
        /// TFINVA.
        /// </summary>
        public const string TFINVA = "TFINVA";

        /// <summary>
        /// TFINRA.
        /// </summary>
        public const string TFINRA = "TFINRA";

        /// <summary>
        /// TFINEA.
        /// </summary>
        public const string TFINEA = "TFINEA";

        /// <summary>
        /// TFCRFL.
        /// </summary>
        public const string TFCRFL = "TFCRFL";

        /// <summary>
        /// TFCPTR.
        /// </summary>
        public const string TFCPTR = "TFCPTR";

        /// <summary>
        /// TFPCOR.
        /// </summary>
        public const string TFPCOR = "TFPCOR";

        /// <summary>
        /// TFAUSPTWW.
        /// </summary>
        public const string TFAUSPTWW = "TFAUSPTWW";

        /// <summary>
        /// TFAUBP.
        /// </summary>
        public const string TFAUBP = "TFAUBP";
    }

    /// <inheritdoc />
    public override string TableName => "F186602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFPRTR", "TFPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("TFLRSBAT", "TFLRSBAT", JdeDataType.Numeric, null, true, true),
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric),
        new JdeField("TFLRSPTN", "TFLRSPTN", JdeDataType.Numeric),
        new JdeField("TFLRSCHF", "TFLRSCHF", JdeDataType.String, 2),
        new JdeField("TFLRSORID", "TFLRSORID", JdeDataType.Numeric),
        new JdeField("TFLRSOPT", "TFLRSOPT", JdeDataType.Numeric),
        new JdeField("TFLRSODWK", "TFLRSODWK", JdeDataType.Numeric),
        new JdeField("TFLRSOHW", "TFLRSOHW", JdeDataType.Numeric),
        new JdeField("TFLRSOHR", "TFLRSOHR", JdeDataType.Numeric),
        new JdeField("TFLRSOGP", "TFLRSOGP", JdeDataType.Numeric),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFTDAY", "TFTDAY", JdeDataType.Numeric),
        new JdeField("TFPALF", "TFPALF", JdeDataType.String, 24),
        new JdeField("TFRCCD", "TFRCCD", JdeDataType.String, 2),
        new JdeField("TFCKCN", "TFCKCN", JdeDataType.Numeric),
        new JdeField("TFAM", "TFAM", JdeDataType.String, 2),
        new JdeField("TFCO", "TFCO", JdeDataType.String, 10),
        new JdeField("TFHMCO", "TFHMCO", JdeDataType.String, 10),
        new JdeField("TFHMCU", "TFHMCU", JdeDataType.String, 24),
        new JdeField("TFMCU", "TFMCU", JdeDataType.String, 24),
        new JdeField("TFOBJ", "TFOBJ", JdeDataType.String, 12),
        new JdeField("TFSUB", "TFSUB", JdeDataType.String, 16),
        new JdeField("TFRCO", "TFRCO", JdeDataType.String, 10),
        new JdeField("TFGMCU", "TFGMCU", JdeDataType.String, 24),
        new JdeField("TFGOBJ", "TFGOBJ", JdeDataType.String, 12),
        new JdeField("TFGSUB", "TFGSUB", JdeDataType.String, 16),
        new JdeField("TFSBL", "TFSBL", JdeDataType.String, 16),
        new JdeField("TFSBLT", "TFSBLT", JdeDataType.String, 2),
        new JdeField("TFWR01", "TFWR01", JdeDataType.String, 8),
        new JdeField("TFMCUO", "TFMCUO", JdeDataType.String, 24),
        new JdeField("TFMAIL", "TFMAIL", JdeDataType.String, 20),
        new JdeField("TFOPSQ", "TFOPSQ", JdeDataType.Numeric),
        new JdeField("TFRILT", "TFRILT", JdeDataType.String, 2),
        new JdeField("TFITM", "TFITM", JdeDataType.Numeric),
        new JdeField("TFPCUN", "TFPCUN", JdeDataType.Numeric),
        new JdeField("TFUM", "TFUM", JdeDataType.String, 4),
        new JdeField("TFPPRT", "TFPPRT", JdeDataType.Numeric),
        new JdeField("TFBHRT", "TFBHRT", JdeDataType.Numeric),
        new JdeField("TFPBRT", "TFPBRT", JdeDataType.Numeric),
        new JdeField("TFBDRT", "TFBDRT", JdeDataType.Numeric),
        new JdeField("TFSHRT", "TFSHRT", JdeDataType.Numeric),
        new JdeField("TFSHFT", "TFSHFT", JdeDataType.String, 2),
        new JdeField("TFSHD", "TFSHD", JdeDataType.Numeric),
        new JdeField("TFPAYM", "TFPAYM", JdeDataType.Numeric),
        new JdeField("TFLD", "TFLD", JdeDataType.String, 2),
        new JdeField("TFDPA", "TFDPA", JdeDataType.Numeric),
        new JdeField("TFRCPY", "TFRCPY", JdeDataType.Numeric),
        new JdeField("TFSAMT", "TFSAMT", JdeDataType.Numeric),
        new JdeField("TFUN", "TFUN", JdeDataType.String, 12),
        new JdeField("TFJBCD", "TFJBCD", JdeDataType.String, 12),
        new JdeField("TFJBST", "TFJBST", JdeDataType.String, 8),
        new JdeField("TFWST", "TFWST", JdeDataType.Numeric),
        new JdeField("TFWCNT", "TFWCNT", JdeDataType.Numeric),
        new JdeField("TFWCTY", "TFWCTY", JdeDataType.Numeric),
        new JdeField("TFWCMP", "TFWCMP", JdeDataType.String, 8),
        new JdeField("TFWET", "TFWET", JdeDataType.String, 2),
        new JdeField("TFGENA", "TFGENA", JdeDataType.Numeric),
        new JdeField("TFWCAM", "TFWCAM", JdeDataType.Numeric),
        new JdeField("TFWCMB", "TFWCMB", JdeDataType.Numeric),
        new JdeField("TFGENB", "TFGENB", JdeDataType.Numeric),
        new JdeField("TFWCMO", "TFWCMO", JdeDataType.Numeric),
        new JdeField("TFGENO", "TFGENO", JdeDataType.Numeric),
        new JdeField("TFWCMX", "TFWCMX", JdeDataType.Numeric),
        new JdeField("TFGENX", "TFGENX", JdeDataType.Numeric),
        new JdeField("TFWCBN", "TFWCBN", JdeDataType.Numeric),
        new JdeField("TFHMO", "TFHMO", JdeDataType.Numeric),
        new JdeField("TFPB", "TFPB", JdeDataType.String, 2),
        new JdeField("TFDEDM", "TFDEDM", JdeDataType.String, 2),
        new JdeField("TFSALY", "TFSALY", JdeDataType.String, 2),
        new JdeField("TFNMTH", "TFNMTH", JdeDataType.String, 2),
        new JdeField("TFPFRQ", "TFPFRQ", JdeDataType.String, 2),
        new JdeField("TFFY", "TFFY", JdeDataType.Numeric),
        new JdeField("TFDGL", "TFDGL", JdeDataType.Numeric),
        new JdeField("TFPN", "TFPN", JdeDataType.Numeric),
        new JdeField("TFDW", "TFDW", JdeDataType.String, 2),
        new JdeField("TFPPED", "TFPPED", JdeDataType.Numeric),
        new JdeField("TFPPP", "TFPPP", JdeDataType.String, 2),
        new JdeField("TFDTBT", "TFDTBT", JdeDataType.Numeric),
        new JdeField("TFTCDE", "TFTCDE", JdeDataType.Numeric),
        new JdeField("TFEQCO", "TFEQCO", JdeDataType.String, 10),
        new JdeField("TFEQWO", "TFEQWO", JdeDataType.String, 18),
        new JdeField("TFEQCG", "TFEQCG", JdeDataType.String, 18),
        new JdeField("TFQOBJ", "TFQOBJ", JdeDataType.String, 12),
        new JdeField("TFERC", "TFERC", JdeDataType.String, 4),
        new JdeField("TFEQRT", "TFEQRT", JdeDataType.Numeric),
        new JdeField("TFEQGR", "TFEQGR", JdeDataType.Numeric),
        new JdeField("TFEQHR", "TFEQHR", JdeDataType.Numeric),
        new JdeField("TFEXR", "TFEXR", JdeDataType.String, 60),
        new JdeField("TFP001", "TFP001", JdeDataType.String, 6),
        new JdeField("TFP002", "TFP002", JdeDataType.String, 6),
        new JdeField("TFP003", "TFP003", JdeDataType.String, 6),
        new JdeField("TFP004", "TFP004", JdeDataType.String, 6),
        new JdeField("TFCMMT", "TFCMMT", JdeDataType.String, 2),
        new JdeField("TFCKDT", "TFCKDT", JdeDataType.Numeric),
        new JdeField("TFUAMT", "TFUAMT", JdeDataType.Numeric),
        new JdeField("TFYST", "TFYST", JdeDataType.String, 2),
        new JdeField("TFICU", "TFICU", JdeDataType.Numeric),
        new JdeField("TFGICU", "TFGICU", JdeDataType.Numeric),
        new JdeField("TFDICJ", "TFDICJ", JdeDataType.Numeric),
        new JdeField("TFANI", "TFANI", JdeDataType.String, 58),
        new JdeField("TFCTRY", "TFCTRY", JdeDataType.Numeric),
        new JdeField("TFANN8", "TFANN8", JdeDataType.Numeric),
        new JdeField("TFPGRP", "TFPGRP", JdeDataType.String, 4),
        new JdeField("TFPAYG", "TFPAYG", JdeDataType.String, 2),
        new JdeField("TFPAYN", "TFPAYN", JdeDataType.String, 2),
        new JdeField("TFSFLG", "TFSFLG", JdeDataType.String, 2),
        new JdeField("TFWS", "TFWS", JdeDataType.String, 2),
        new JdeField("TFPCK", "TFPCK", JdeDataType.String, 2),
        new JdeField("TFICC", "TFICC", JdeDataType.String, 2),
        new JdeField("TFICS", "TFICS", JdeDataType.String, 2),
        new JdeField("TFCMTH", "TFCMTH", JdeDataType.String, 2),
        new JdeField("TFACO", "TFACO", JdeDataType.String, 2),
        new JdeField("TFAI", "TFAI", JdeDataType.String, 2),
        new JdeField("TFSEC$", "TFSEC$", JdeDataType.String, 2),
        new JdeField("TFOHF", "TFOHF", JdeDataType.String, 2),
        new JdeField("TFDEP1", "TFDEP1", JdeDataType.String, 2),
        new JdeField("TFDEP2", "TFDEP2", JdeDataType.String, 2),
        new JdeField("TFDEP3", "TFDEP3", JdeDataType.String, 2),
        new JdeField("TFDEP4", "TFDEP4", JdeDataType.String, 2),
        new JdeField("TFDEP5", "TFDEP5", JdeDataType.String, 2),
        new JdeField("TFDEP6", "TFDEP6", JdeDataType.String, 2),
        new JdeField("TFTT01", "TFTT01", JdeDataType.String, 4),
        new JdeField("TFTT02", "TFTT02", JdeDataType.String, 4),
        new JdeField("TFTT03", "TFTT03", JdeDataType.String, 4),
        new JdeField("TFTT04", "TFTT04", JdeDataType.String, 4),
        new JdeField("TFTT05", "TFTT05", JdeDataType.String, 4),
        new JdeField("TFTT06", "TFTT06", JdeDataType.String, 4),
        new JdeField("TFTT07", "TFTT07", JdeDataType.String, 4),
        new JdeField("TFTT08", "TFTT08", JdeDataType.String, 4),
        new JdeField("TFTT09", "TFTT09", JdeDataType.String, 4),
        new JdeField("TFTT10", "TFTT10", JdeDataType.String, 4),
        new JdeField("TFTT11", "TFTT11", JdeDataType.String, 4),
        new JdeField("TFTT12", "TFTT12", JdeDataType.String, 4),
        new JdeField("TFTT13", "TFTT13", JdeDataType.String, 4),
        new JdeField("TFTT14", "TFTT14", JdeDataType.String, 4),
        new JdeField("TFTT15", "TFTT15", JdeDataType.String, 4),
        new JdeField("TFUSR", "TFUSR", JdeDataType.String, 36),
        new JdeField("TFEPA", "TFEPA", JdeDataType.Numeric),
        new JdeField("TFBFA", "TFBFA", JdeDataType.Numeric),
        new JdeField("TFRTWC", "TFRTWC", JdeDataType.Numeric),
        new JdeField("TFGENR", "TFGENR", JdeDataType.Numeric),
        new JdeField("TFADV", "TFADV", JdeDataType.String, 2),
        new JdeField("TFSTIP", "TFSTIP", JdeDataType.String, 2),
        new JdeField("TFALPH", "TFALPH", JdeDataType.String, 80),
        new JdeField("TFIIAP", "TFIIAP", JdeDataType.String, 2),
        new JdeField("TFFICM", "TFFICM", JdeDataType.String, 2),
        new JdeField("TFDTAB", "TFDTAB", JdeDataType.String, 10),
        new JdeField("TFDTSP", "TFDTSP", JdeDataType.Numeric),
        new JdeField("TFYST1", "TFYST1", JdeDataType.String, 2),
        new JdeField("TFCKCS", "TFCKCS", JdeDataType.String, 30),
        new JdeField("TFALT0", "TFALT0", JdeDataType.String, 2),
        new JdeField("TFPOS", "TFPOS", JdeDataType.String, 16),
        new JdeField("TFACTB", "TFACTB", JdeDataType.String, 20),
        new JdeField("TFABR1", "TFABR1", JdeDataType.String, 24),
        new JdeField("TFABT1", "TFABT1", JdeDataType.String, 2),
        new JdeField("TFABR2", "TFABR2", JdeDataType.String, 24),
        new JdeField("TFABT2", "TFABT2", JdeDataType.String, 2),
        new JdeField("TFABR3", "TFABR3", JdeDataType.String, 24),
        new JdeField("TFABT3", "TFABT3", JdeDataType.String, 2),
        new JdeField("TFABR4", "TFABR4", JdeDataType.String, 24),
        new JdeField("TFABT4", "TFABT4", JdeDataType.String, 2),
        new JdeField("TFBLGRT", "TFBLGRT", JdeDataType.Numeric),
        new JdeField("TFRCHGAMT", "TFRCHGAMT", JdeDataType.Numeric),
        new JdeField("TFFBLGRT", "TFFBLGRT", JdeDataType.Numeric),
        new JdeField("TFFRCHGAMT", "TFFRCHGAMT", JdeDataType.Numeric),
        new JdeField("TFCRR", "TFCRR", JdeDataType.Numeric),
        new JdeField("TFCRCD", "TFCRCD", JdeDataType.String, 6),
        new JdeField("TFCRDC", "TFCRDC", JdeDataType.String, 6),
        new JdeField("TFRCHGMODE", "TFRCHGMODE", JdeDataType.String, 2),
        new JdeField("TFLTTP", "TFLTTP", JdeDataType.String, 4),
        new JdeField("TFRKID", "TFRKID", JdeDataType.Numeric),
        new JdeField("TFTELKFLG", "TFTELKFLG", JdeDataType.String, 2),
        new JdeField("TFAPPRCFLG", "TFAPPRCFLG", JdeDataType.String, 2),
        new JdeField("TFOTRULECD", "TFOTRULECD", JdeDataType.String, 6),
        new JdeField("TFTSKID", "TFTSKID", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFTAXX", "TFTAXX", JdeDataType.String, 40),
        new JdeField("TFSCTR", "TFSCTR", JdeDataType.String, 2),
        new JdeField("TFSCRX", "TFSCRX", JdeDataType.String, 2),
        new JdeField("TFSVH", "TFSVH", JdeDataType.String, 2),
        new JdeField("TFTCFD", "TFTCFD", JdeDataType.Numeric),
        new JdeField("TFTCTD", "TFTCTD", JdeDataType.Numeric),
        new JdeField("TFHWPD", "TFHWPD", JdeDataType.Numeric),
        new JdeField("TFINSTID", "TFINSTID", JdeDataType.String, 72),
        new JdeField("TFTCUN", "TFTCUN", JdeDataType.String, 2),
        new JdeField("TFTCHC", "TFTCHC", JdeDataType.String, 2),
        new JdeField("TFTCHB", "TFTCHB", JdeDataType.String, 2),
        new JdeField("TFTCJT", "TFTCJT", JdeDataType.String, 2),
        new JdeField("TFTCJS", "TFTCJS", JdeDataType.String, 2),
        new JdeField("TFTCRT", "TFTCRT", JdeDataType.String, 2),
        new JdeField("TFTCSC", "TFTCSC", JdeDataType.String, 2),
        new JdeField("TFTCSD", "TFTCSD", JdeDataType.String, 2),
        new JdeField("TFTCBR", "TFTCBR", JdeDataType.String, 2),
        new JdeField("TFTCPC", "TFTCPC", JdeDataType.String, 2),
        new JdeField("TFTCWC", "TFTCWC", JdeDataType.String, 2),
        new JdeField("TFTCWS", "TFTCWS", JdeDataType.String, 2),
        new JdeField("TFTCJL", "TFTCJL", JdeDataType.String, 2),
        new JdeField("TFTCANI", "TFTCANI", JdeDataType.String, 2),
        new JdeField("TFTCRFLG", "TFTCRFLG", JdeDataType.String, 2),
        new JdeField("TFJBLC", "TFJBLC", JdeDataType.String, 12),
        new JdeField("TFCOPX", "TFCOPX", JdeDataType.String, 2),
        new JdeField("TFBPTX", "TFBPTX", JdeDataType.Numeric),
        new JdeField("TFCOPB", "TFCOPB", JdeDataType.Numeric),
        new JdeField("TFCMED", "TFCMED", JdeDataType.String, 2),
        new JdeField("TFCOPR", "TFCOPR", JdeDataType.Numeric),
        new JdeField("TFGLBN", "TFGLBN", JdeDataType.Numeric),
        new JdeField("TFWCEX", "TFWCEX", JdeDataType.Numeric),
        new JdeField("TFGLEX", "TFGLEX", JdeDataType.Numeric),
        new JdeField("TFLDID", "TFLDID", JdeDataType.String, 10),
        new JdeField("TFLDED", "TFLDED", JdeDataType.Numeric),
        new JdeField("TFTTAP", "TFTTAP", JdeDataType.String, 2),
        new JdeField("TFINVA", "TFINVA", JdeDataType.String, 58),
        new JdeField("TFINRA", "TFINRA", JdeDataType.String, 58),
        new JdeField("TFINEA", "TFINEA", JdeDataType.String, 58),
        new JdeField("TFCRFL", "TFCRFL", JdeDataType.String, 2),
        new JdeField("TFCPTR", "TFCPTR", JdeDataType.Numeric),
        new JdeField("TFPCOR", "TFPCOR", JdeDataType.String, 2),
        new JdeField("TFAUSPTWW", "TFAUSPTWW", JdeDataType.String, 6),
        new JdeField("TFAUBP", "TFAUBP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186602_0", "Primary Key on TFPRTR, TFLRSBAT", new[] { "TFPRTR", "TFLRSBAT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186602_2", "Index on TFPRTR", new[] { "TFPRTR" }),
        new JdeIndex("F186602_3", "Index on TFAN8", new[] { "TFAN8" }),
        new JdeIndex("F186602_4", "Index on TFLRSPTN, TFLRSBAT", new[] { "TFLRSPTN", "TFLRSBAT" }),
        new JdeIndex("F186602_5", "Index on TFLRSBAT, TFAN8, TFLRSPTN", new[] { "TFLRSBAT", "TFAN8", "TFLRSPTN" }),
        new JdeIndex("F186602_6", "Index on TFPRTR, TFLRSBAT, TFAN8", new[] { "TFPRTR", "TFLRSBAT", "TFAN8" })
    };
}
