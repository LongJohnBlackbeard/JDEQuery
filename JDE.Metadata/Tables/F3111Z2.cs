using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3111Z2 - .
/// </summary>
public class F3111Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPEDUS.
        /// </summary>
        public const string WPEDUS = "WPEDUS";

        /// <summary>
        /// WPEDBT.
        /// </summary>
        public const string WPEDBT = "WPEDBT";

        /// <summary>
        /// WPEDTN.
        /// </summary>
        public const string WPEDTN = "WPEDTN";

        /// <summary>
        /// WPEDLN.
        /// </summary>
        public const string WPEDLN = "WPEDLN";

        /// <summary>
        /// WPEDCT.
        /// </summary>
        public const string WPEDCT = "WPEDCT";

        /// <summary>
        /// WPTYTN.
        /// </summary>
        public const string WPTYTN = "WPTYTN";

        /// <summary>
        /// WPEDFT.
        /// </summary>
        public const string WPEDFT = "WPEDFT";

        /// <summary>
        /// WPEDDT.
        /// </summary>
        public const string WPEDDT = "WPEDDT";

        /// <summary>
        /// WPDRIN.
        /// </summary>
        public const string WPDRIN = "WPDRIN";

        /// <summary>
        /// WPEDDL.
        /// </summary>
        public const string WPEDDL = "WPEDDL";

        /// <summary>
        /// WPEDSP.
        /// </summary>
        public const string WPEDSP = "WPEDSP";

        /// <summary>
        /// WPPNID.
        /// </summary>
        public const string WPPNID = "WPPNID";

        /// <summary>
        /// WPTNAC.
        /// </summary>
        public const string WPTNAC = "WPTNAC";

        /// <summary>
        /// WPDOCO.
        /// </summary>
        public const string WPDOCO = "WPDOCO";

        /// <summary>
        /// WPDCTO.
        /// </summary>
        public const string WPDCTO = "WPDCTO";

        /// <summary>
        /// WPSFXO.
        /// </summary>
        public const string WPSFXO = "WPSFXO";

        /// <summary>
        /// WPTBM.
        /// </summary>
        public const string WPTBM = "WPTBM";

        /// <summary>
        /// WPFORQ.
        /// </summary>
        public const string WPFORQ = "WPFORQ";

        /// <summary>
        /// WPITC.
        /// </summary>
        public const string WPITC = "WPITC";

        /// <summary>
        /// WPCOBY.
        /// </summary>
        public const string WPCOBY = "WPCOBY";

        /// <summary>
        /// WPCOTY.
        /// </summary>
        public const string WPCOTY = "WPCOTY";

        /// <summary>
        /// WPCPNT.
        /// </summary>
        public const string WPCPNT = "WPCPNT";

        /// <summary>
        /// WPFRMP.
        /// </summary>
        public const string WPFRMP = "WPFRMP";

        /// <summary>
        /// WPTHRP.
        /// </summary>
        public const string WPTHRP = "WPTHRP";

        /// <summary>
        /// WPFRGD.
        /// </summary>
        public const string WPFRGD = "WPFRGD";

        /// <summary>
        /// WPTHGD.
        /// </summary>
        public const string WPTHGD = "WPTHGD";

        /// <summary>
        /// WPRKCO.
        /// </summary>
        public const string WPRKCO = "WPRKCO";

        /// <summary>
        /// WPRORN.
        /// </summary>
        public const string WPRORN = "WPRORN";

        /// <summary>
        /// WPRCTO.
        /// </summary>
        public const string WPRCTO = "WPRCTO";

        /// <summary>
        /// WPRLLN.
        /// </summary>
        public const string WPRLLN = "WPRLLN";

        /// <summary>
        /// WPOPSQ.
        /// </summary>
        public const string WPOPSQ = "WPOPSQ";

        /// <summary>
        /// WPBSEQ.
        /// </summary>
        public const string WPBSEQ = "WPBSEQ";

        /// <summary>
        /// WPRSCP.
        /// </summary>
        public const string WPRSCP = "WPRSCP";

        /// <summary>
        /// WPSCRP.
        /// </summary>
        public const string WPSCRP = "WPSCRP";

        /// <summary>
        /// WPREWP.
        /// </summary>
        public const string WPREWP = "WPREWP";

        /// <summary>
        /// WPASIP.
        /// </summary>
        public const string WPASIP = "WPASIP";

        /// <summary>
        /// WPCPYP.
        /// </summary>
        public const string WPCPYP = "WPCPYP";

        /// <summary>
        /// WPSTPP.
        /// </summary>
        public const string WPSTPP = "WPSTPP";

        /// <summary>
        /// WPLOVD.
        /// </summary>
        public const string WPLOVD = "WPLOVD";

        /// <summary>
        /// WPCPIT.
        /// </summary>
        public const string WPCPIT = "WPCPIT";

        /// <summary>
        /// WPCPIL.
        /// </summary>
        public const string WPCPIL = "WPCPIL";

        /// <summary>
        /// WPCPIA.
        /// </summary>
        public const string WPCPIA = "WPCPIA";

        /// <summary>
        /// WPCMCU.
        /// </summary>
        public const string WPCMCU = "WPCMCU";

        /// <summary>
        /// WPDSC1.
        /// </summary>
        public const string WPDSC1 = "WPDSC1";

        /// <summary>
        /// WPDSC2.
        /// </summary>
        public const string WPDSC2 = "WPDSC2";

        /// <summary>
        /// WPLOCN.
        /// </summary>
        public const string WPLOCN = "WPLOCN";

        /// <summary>
        /// WPLOTN.
        /// </summary>
        public const string WPLOTN = "WPLOTN";

        /// <summary>
        /// WPAN8.
        /// </summary>
        public const string WPAN8 = "WPAN8";

        /// <summary>
        /// WPLNTY.
        /// </summary>
        public const string WPLNTY = "WPLNTY";

        /// <summary>
        /// WPSERN.
        /// </summary>
        public const string WPSERN = "WPSERN";

        /// <summary>
        /// WPTRDJ.
        /// </summary>
        public const string WPTRDJ = "WPTRDJ";

        /// <summary>
        /// WPDRQJ.
        /// </summary>
        public const string WPDRQJ = "WPDRQJ";

        /// <summary>
        /// WPUORG.
        /// </summary>
        public const string WPUORG = "WPUORG";

        /// <summary>
        /// WPTRQT.
        /// </summary>
        public const string WPTRQT = "WPTRQT";

        /// <summary>
        /// WPSOCN.
        /// </summary>
        public const string WPSOCN = "WPSOCN";

        /// <summary>
        /// WPSOBK.
        /// </summary>
        public const string WPSOBK = "WPSOBK";

        /// <summary>
        /// WPCTS1.
        /// </summary>
        public const string WPCTS1 = "WPCTS1";

        /// <summary>
        /// WPQNTA.
        /// </summary>
        public const string WPQNTA = "WPQNTA";

        /// <summary>
        /// WPUM.
        /// </summary>
        public const string WPUM = "WPUM";

        /// <summary>
        /// WPEA.
        /// </summary>
        public const string WPEA = "WPEA";

        /// <summary>
        /// WPRTG.
        /// </summary>
        public const string WPRTG = "WPRTG";

        /// <summary>
        /// WPMTST.
        /// </summary>
        public const string WPMTST = "WPMTST";

        /// <summary>
        /// WPDCT.
        /// </summary>
        public const string WPDCT = "WPDCT";

        /// <summary>
        /// WPSHNO.
        /// </summary>
        public const string WPSHNO = "WPSHNO";

        /// <summary>
        /// WPMCU.
        /// </summary>
        public const string WPMCU = "WPMCU";

        /// <summary>
        /// WPOMCU.
        /// </summary>
        public const string WPOMCU = "WPOMCU";

        /// <summary>
        /// WPOBJ.
        /// </summary>
        public const string WPOBJ = "WPOBJ";

        /// <summary>
        /// WPSUB.
        /// </summary>
        public const string WPSUB = "WPSUB";

        /// <summary>
        /// WPCMRV.
        /// </summary>
        public const string WPCMRV = "WPCMRV";

        /// <summary>
        /// WPSTRX.
        /// </summary>
        public const string WPSTRX = "WPSTRX";

        /// <summary>
        /// WPPARS.
        /// </summary>
        public const string WPPARS = "WPPARS";

        /// <summary>
        /// WPCOMM.
        /// </summary>
        public const string WPCOMM = "WPCOMM";

        /// <summary>
        /// WPUKID.
        /// </summary>
        public const string WPUKID = "WPUKID";

        /// <summary>
        /// WPURCD.
        /// </summary>
        public const string WPURCD = "WPURCD";

        /// <summary>
        /// WPURDT.
        /// </summary>
        public const string WPURDT = "WPURDT";

        /// <summary>
        /// WPURAT.
        /// </summary>
        public const string WPURAT = "WPURAT";

        /// <summary>
        /// WPURAB.
        /// </summary>
        public const string WPURAB = "WPURAB";

        /// <summary>
        /// WPURRF.
        /// </summary>
        public const string WPURRF = "WPURRF";

        /// <summary>
        /// WPTORG.
        /// </summary>
        public const string WPTORG = "WPTORG";

        /// <summary>
        /// WPPOC.
        /// </summary>
        public const string WPPOC = "WPPOC";

        /// <summary>
        /// WPVEND.
        /// </summary>
        public const string WPVEND = "WPVEND";

        /// <summary>
        /// WPCTS4.
        /// </summary>
        public const string WPCTS4 = "WPCTS4";

        /// <summary>
        /// WPCTS7.
        /// </summary>
        public const string WPCTS7 = "WPCTS7";

        /// <summary>
        /// WPCTS8.
        /// </summary>
        public const string WPCTS8 = "WPCTS8";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPJOBN.
        /// </summary>
        public const string WPJOBN = "WPJOBN";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPTDAY.
        /// </summary>
        public const string WPTDAY = "WPTDAY";

        /// <summary>
        /// WPGLD.
        /// </summary>
        public const string WPGLD = "WPGLD";

        /// <summary>
        /// WPSBFL.
        /// </summary>
        public const string WPSBFL = "WPSBFL";

        /// <summary>
        /// WPAING.
        /// </summary>
        public const string WPAING = "WPAING";

        /// <summary>
        /// WPSSTQ.
        /// </summary>
        public const string WPSSTQ = "WPSSTQ";

        /// <summary>
        /// WPUOM2.
        /// </summary>
        public const string WPUOM2 = "WPUOM2";

        /// <summary>
        /// WPAPSC.
        /// </summary>
        public const string WPAPSC = "WPAPSC";

        /// <summary>
        /// WPPSN.
        /// </summary>
        public const string WPPSN = "WPPSN";

        /// <summary>
        /// WPDLEJ.
        /// </summary>
        public const string WPDLEJ = "WPDLEJ";

        /// <summary>
        /// WPCOST.
        /// </summary>
        public const string WPCOST = "WPCOST";

        /// <summary>
        /// WPCHPP.
        /// </summary>
        public const string WPCHPP = "WPCHPP";

        /// <summary>
        /// WPCPNB.
        /// </summary>
        public const string WPCPNB = "WPCPNB";

        /// <summary>
        /// WPBSEQAN.
        /// </summary>
        public const string WPBSEQAN = "WPBSEQAN";

        /// <summary>
        /// WPESUNC.
        /// </summary>
        public const string WPESUNC = "WPESUNC";

        /// <summary>
        /// WPESUNB.
        /// </summary>
        public const string WPESUNB = "WPESUNB";

        /// <summary>
        /// WPESUNP.
        /// </summary>
        public const string WPESUNP = "WPESUNP";

        /// <summary>
        /// WPEPAAP.
        /// </summary>
        public const string WPEPAAP = "WPEPAAP";

        /// <summary>
        /// WPAMTO.
        /// </summary>
        public const string WPAMTO = "WPAMTO";

        /// <summary>
        /// WPEBILL.
        /// </summary>
        public const string WPEBILL = "WPEBILL";

        /// <summary>
        /// WPACUNC.
        /// </summary>
        public const string WPACUNC = "WPACUNC";

        /// <summary>
        /// WPACUNB.
        /// </summary>
        public const string WPACUNB = "WPACUNB";

        /// <summary>
        /// WPACUNP.
        /// </summary>
        public const string WPACUNP = "WPACUNP";

        /// <summary>
        /// WPAMTA.
        /// </summary>
        public const string WPAMTA = "WPAMTA";

        /// <summary>
        /// WPTOTB.
        /// </summary>
        public const string WPTOTB = "WPTOTB";

        /// <summary>
        /// WPPAAP.
        /// </summary>
        public const string WPPAAP = "WPPAAP";

        /// <summary>
        /// WPCLAMT.
        /// </summary>
        public const string WPCLAMT = "WPCLAMT";

        /// <summary>
        /// WPPAYAB.
        /// </summary>
        public const string WPPAYAB = "WPPAYAB";

        /// <summary>
        /// WPBILL.
        /// </summary>
        public const string WPBILL = "WPBILL";

        /// <summary>
        /// WPDTPAY.
        /// </summary>
        public const string WPDTPAY = "WPDTPAY";

        /// <summary>
        /// WPDTBIL.
        /// </summary>
        public const string WPDTBIL = "WPDTBIL";

        /// <summary>
        /// WPGLCNC.
        /// </summary>
        public const string WPGLCNC = "WPGLCNC";

        /// <summary>
        /// WPGLCCV.
        /// </summary>
        public const string WPGLCCV = "WPGLCCV";

        /// <summary>
        /// WPENTCK.
        /// </summary>
        public const string WPENTCK = "WPENTCK";

        /// <summary>
        /// WPVR02.
        /// </summary>
        public const string WPVR02 = "WPVR02";

        /// <summary>
        /// WPASN4.
        /// </summary>
        public const string WPASN4 = "WPASN4";

        /// <summary>
        /// WPASN2.
        /// </summary>
        public const string WPASN2 = "WPASN2";

        /// <summary>
        /// WPPCOVR.
        /// </summary>
        public const string WPPCOVR = "WPPCOVR";

        /// <summary>
        /// WPMTHPR.
        /// </summary>
        public const string WPMTHPR = "WPMTHPR";

        /// <summary>
        /// WPSAID.
        /// </summary>
        public const string WPSAID = "WPSAID";

        /// <summary>
        /// WPPRODF.
        /// </summary>
        public const string WPPRODF = "WPPRODF";

        /// <summary>
        /// WPPRODM.
        /// </summary>
        public const string WPPRODM = "WPPRODM";

        /// <summary>
        /// WPCOVGR.
        /// </summary>
        public const string WPCOVGR = "WPCOVGR";

        /// <summary>
        /// WPPMTHP.
        /// </summary>
        public const string WPPMTHP = "WPPMTHP";

        /// <summary>
        /// WPPYPRT.
        /// </summary>
        public const string WPPYPRT = "WPPYPRT";

        /// <summary>
        /// WPCRDC.
        /// </summary>
        public const string WPCRDC = "WPCRDC";

        /// <summary>
        /// WPBCRCD.
        /// </summary>
        public const string WPBCRCD = "WPBCRCD";

        /// <summary>
        /// WPBCRR.
        /// </summary>
        public const string WPBCRR = "WPBCRR";

        /// <summary>
        /// WPBCRRM.
        /// </summary>
        public const string WPBCRRM = "WPBCRRM";

        /// <summary>
        /// WPFESUNB.
        /// </summary>
        public const string WPFESUNB = "WPFESUNB";

        /// <summary>
        /// WPFEBILL.
        /// </summary>
        public const string WPFEBILL = "WPFEBILL";

        /// <summary>
        /// WPFACUNB.
        /// </summary>
        public const string WPFACUNB = "WPFACUNB";

        /// <summary>
        /// WPFTOTB.
        /// </summary>
        public const string WPFTOTB = "WPFTOTB";

        /// <summary>
        /// WPPCRCD.
        /// </summary>
        public const string WPPCRCD = "WPPCRCD";

        /// <summary>
        /// WPPCRR.
        /// </summary>
        public const string WPPCRR = "WPPCRR";

        /// <summary>
        /// WPPCRRM.
        /// </summary>
        public const string WPPCRRM = "WPPCRRM";

        /// <summary>
        /// WPFESUNP.
        /// </summary>
        public const string WPFESUNP = "WPFESUNP";

        /// <summary>
        /// WPFEPAAP.
        /// </summary>
        public const string WPFEPAAP = "WPFEPAAP";

        /// <summary>
        /// WPFACUNP.
        /// </summary>
        public const string WPFACUNP = "WPFACUNP";

        /// <summary>
        /// WPFPAAP.
        /// </summary>
        public const string WPFPAAP = "WPFPAAP";

        /// <summary>
        /// WPFAILCD.
        /// </summary>
        public const string WPFAILCD = "WPFAILCD";

        /// <summary>
        /// WPRETPOL.
        /// </summary>
        public const string WPRETPOL = "WPRETPOL";

        /// <summary>
        /// WPDTSUB.
        /// </summary>
        public const string WPDTSUB = "WPDTSUB";

        /// <summary>
        /// WPTMSUB.
        /// </summary>
        public const string WPTMSUB = "WPTMSUB";

        /// <summary>
        /// WPCSLPRT.
        /// </summary>
        public const string WPCSLPRT = "WPCSLPRT";

        /// <summary>
        /// WPMCUCSL.
        /// </summary>
        public const string WPMCUCSL = "WPMCUCSL";

        /// <summary>
        /// WPSRVEND.
        /// </summary>
        public const string WPSRVEND = "WPSRVEND";

        /// <summary>
        /// WPRLOT.
        /// </summary>
        public const string WPRLOT = "WPRLOT";

        /// <summary>
        /// WPTAX1.
        /// </summary>
        public const string WPTAX1 = "WPTAX1";

        /// <summary>
        /// WPUKIDP.
        /// </summary>
        public const string WPUKIDP = "WPUKIDP";

        /// <summary>
        /// WPVMRS31.
        /// </summary>
        public const string WPVMRS31 = "WPVMRS31";

        /// <summary>
        /// WPVMRS32.
        /// </summary>
        public const string WPVMRS32 = "WPVMRS32";

        /// <summary>
        /// WPVMRS33.
        /// </summary>
        public const string WPVMRS33 = "WPVMRS33";
    }

    /// <inheritdoc />
    public override string TableName => "F3111Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPEDUS", "WPEDUS", JdeDataType.String, 20, true, true),
        new JdeField("WPEDBT", "WPEDBT", JdeDataType.String, 30, true, true),
        new JdeField("WPEDTN", "WPEDTN", JdeDataType.String, 44, true, true),
        new JdeField("WPEDLN", "WPEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WPEDCT", "WPEDCT", JdeDataType.String, 4),
        new JdeField("WPTYTN", "WPTYTN", JdeDataType.String, 16),
        new JdeField("WPEDFT", "WPEDFT", JdeDataType.String, 20),
        new JdeField("WPEDDT", "WPEDDT", JdeDataType.Numeric),
        new JdeField("WPDRIN", "WPDRIN", JdeDataType.String, 2),
        new JdeField("WPEDDL", "WPEDDL", JdeDataType.Numeric),
        new JdeField("WPEDSP", "WPEDSP", JdeDataType.String, 2),
        new JdeField("WPPNID", "WPPNID", JdeDataType.String, 30),
        new JdeField("WPTNAC", "WPTNAC", JdeDataType.String, 4),
        new JdeField("WPDOCO", "WPDOCO", JdeDataType.Numeric),
        new JdeField("WPDCTO", "WPDCTO", JdeDataType.String, 4),
        new JdeField("WPSFXO", "WPSFXO", JdeDataType.String, 6),
        new JdeField("WPTBM", "WPTBM", JdeDataType.String, 6),
        new JdeField("WPFORQ", "WPFORQ", JdeDataType.String, 2),
        new JdeField("WPITC", "WPITC", JdeDataType.String, 2),
        new JdeField("WPCOBY", "WPCOBY", JdeDataType.String, 2),
        new JdeField("WPCOTY", "WPCOTY", JdeDataType.String, 2),
        new JdeField("WPCPNT", "WPCPNT", JdeDataType.Numeric),
        new JdeField("WPFRMP", "WPFRMP", JdeDataType.Numeric),
        new JdeField("WPTHRP", "WPTHRP", JdeDataType.Numeric),
        new JdeField("WPFRGD", "WPFRGD", JdeDataType.String, 6),
        new JdeField("WPTHGD", "WPTHGD", JdeDataType.String, 6),
        new JdeField("WPRKCO", "WPRKCO", JdeDataType.String, 10),
        new JdeField("WPRORN", "WPRORN", JdeDataType.String, 16),
        new JdeField("WPRCTO", "WPRCTO", JdeDataType.String, 4),
        new JdeField("WPRLLN", "WPRLLN", JdeDataType.Numeric),
        new JdeField("WPOPSQ", "WPOPSQ", JdeDataType.Numeric),
        new JdeField("WPBSEQ", "WPBSEQ", JdeDataType.Numeric),
        new JdeField("WPRSCP", "WPRSCP", JdeDataType.Numeric),
        new JdeField("WPSCRP", "WPSCRP", JdeDataType.Numeric),
        new JdeField("WPREWP", "WPREWP", JdeDataType.Numeric),
        new JdeField("WPASIP", "WPASIP", JdeDataType.Numeric),
        new JdeField("WPCPYP", "WPCPYP", JdeDataType.Numeric),
        new JdeField("WPSTPP", "WPSTPP", JdeDataType.Numeric),
        new JdeField("WPLOVD", "WPLOVD", JdeDataType.Numeric),
        new JdeField("WPCPIT", "WPCPIT", JdeDataType.Numeric),
        new JdeField("WPCPIL", "WPCPIL", JdeDataType.String, 50),
        new JdeField("WPCPIA", "WPCPIA", JdeDataType.String, 50),
        new JdeField("WPCMCU", "WPCMCU", JdeDataType.String, 24),
        new JdeField("WPDSC1", "WPDSC1", JdeDataType.String, 60),
        new JdeField("WPDSC2", "WPDSC2", JdeDataType.String, 60),
        new JdeField("WPLOCN", "WPLOCN", JdeDataType.String, 40),
        new JdeField("WPLOTN", "WPLOTN", JdeDataType.String, 60),
        new JdeField("WPAN8", "WPAN8", JdeDataType.Numeric),
        new JdeField("WPLNTY", "WPLNTY", JdeDataType.String, 4),
        new JdeField("WPSERN", "WPSERN", JdeDataType.String, 60),
        new JdeField("WPTRDJ", "WPTRDJ", JdeDataType.Numeric),
        new JdeField("WPDRQJ", "WPDRQJ", JdeDataType.Numeric),
        new JdeField("WPUORG", "WPUORG", JdeDataType.Numeric),
        new JdeField("WPTRQT", "WPTRQT", JdeDataType.Numeric),
        new JdeField("WPSOCN", "WPSOCN", JdeDataType.Numeric),
        new JdeField("WPSOBK", "WPSOBK", JdeDataType.Numeric),
        new JdeField("WPCTS1", "WPCTS1", JdeDataType.Numeric),
        new JdeField("WPQNTA", "WPQNTA", JdeDataType.Numeric),
        new JdeField("WPUM", "WPUM", JdeDataType.String, 4),
        new JdeField("WPEA", "WPEA", JdeDataType.Numeric),
        new JdeField("WPRTG", "WPRTG", JdeDataType.String, 2),
        new JdeField("WPMTST", "WPMTST", JdeDataType.String, 4),
        new JdeField("WPDCT", "WPDCT", JdeDataType.String, 4),
        new JdeField("WPSHNO", "WPSHNO", JdeDataType.String, 20),
        new JdeField("WPMCU", "WPMCU", JdeDataType.String, 24),
        new JdeField("WPOMCU", "WPOMCU", JdeDataType.String, 24),
        new JdeField("WPOBJ", "WPOBJ", JdeDataType.String, 12),
        new JdeField("WPSUB", "WPSUB", JdeDataType.String, 16),
        new JdeField("WPCMRV", "WPCMRV", JdeDataType.String, 6),
        new JdeField("WPSTRX", "WPSTRX", JdeDataType.Numeric),
        new JdeField("WPPARS", "WPPARS", JdeDataType.String, 16),
        new JdeField("WPCOMM", "WPCOMM", JdeDataType.String, 2),
        new JdeField("WPUKID", "WPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WPURCD", "WPURCD", JdeDataType.String, 4),
        new JdeField("WPURDT", "WPURDT", JdeDataType.Numeric),
        new JdeField("WPURAT", "WPURAT", JdeDataType.Numeric),
        new JdeField("WPURAB", "WPURAB", JdeDataType.Numeric),
        new JdeField("WPURRF", "WPURRF", JdeDataType.String, 30),
        new JdeField("WPTORG", "WPTORG", JdeDataType.String, 20),
        new JdeField("WPPOC", "WPPOC", JdeDataType.String, 2),
        new JdeField("WPVEND", "WPVEND", JdeDataType.Numeric),
        new JdeField("WPCTS4", "WPCTS4", JdeDataType.Numeric),
        new JdeField("WPCTS7", "WPCTS7", JdeDataType.Numeric),
        new JdeField("WPCTS8", "WPCTS8", JdeDataType.Numeric),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPJOBN", "WPJOBN", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPTDAY", "WPTDAY", JdeDataType.Numeric),
        new JdeField("WPGLD", "WPGLD", JdeDataType.Numeric),
        new JdeField("WPSBFL", "WPSBFL", JdeDataType.String, 2),
        new JdeField("WPAING", "WPAING", JdeDataType.String, 2),
        new JdeField("WPSSTQ", "WPSSTQ", JdeDataType.Numeric),
        new JdeField("WPUOM2", "WPUOM2", JdeDataType.String, 4),
        new JdeField("WPAPSC", "WPAPSC", JdeDataType.String, 2),
        new JdeField("WPPSN", "WPPSN", JdeDataType.Numeric),
        new JdeField("WPDLEJ", "WPDLEJ", JdeDataType.Numeric),
        new JdeField("WPCOST", "WPCOST", JdeDataType.String, 6),
        new JdeField("WPCHPP", "WPCHPP", JdeDataType.String, 2),
        new JdeField("WPCPNB", "WPCPNB", JdeDataType.Numeric),
        new JdeField("WPBSEQAN", "WPBSEQAN", JdeDataType.String, 10),
        new JdeField("WPESUNC", "WPESUNC", JdeDataType.Numeric),
        new JdeField("WPESUNB", "WPESUNB", JdeDataType.Numeric),
        new JdeField("WPESUNP", "WPESUNP", JdeDataType.Numeric),
        new JdeField("WPEPAAP", "WPEPAAP", JdeDataType.Numeric),
        new JdeField("WPAMTO", "WPAMTO", JdeDataType.Numeric),
        new JdeField("WPEBILL", "WPEBILL", JdeDataType.Numeric),
        new JdeField("WPACUNC", "WPACUNC", JdeDataType.Numeric),
        new JdeField("WPACUNB", "WPACUNB", JdeDataType.Numeric),
        new JdeField("WPACUNP", "WPACUNP", JdeDataType.Numeric),
        new JdeField("WPAMTA", "WPAMTA", JdeDataType.Numeric),
        new JdeField("WPTOTB", "WPTOTB", JdeDataType.Numeric),
        new JdeField("WPPAAP", "WPPAAP", JdeDataType.Numeric),
        new JdeField("WPCLAMT", "WPCLAMT", JdeDataType.Numeric),
        new JdeField("WPPAYAB", "WPPAYAB", JdeDataType.String, 2),
        new JdeField("WPBILL", "WPBILL", JdeDataType.String, 2),
        new JdeField("WPDTPAY", "WPDTPAY", JdeDataType.Numeric),
        new JdeField("WPDTBIL", "WPDTBIL", JdeDataType.Numeric),
        new JdeField("WPGLCNC", "WPGLCNC", JdeDataType.String, 8),
        new JdeField("WPGLCCV", "WPGLCCV", JdeDataType.String, 8),
        new JdeField("WPENTCK", "WPENTCK", JdeDataType.String, 6),
        new JdeField("WPVR02", "WPVR02", JdeDataType.String, 50),
        new JdeField("WPASN4", "WPASN4", JdeDataType.String, 16),
        new JdeField("WPASN2", "WPASN2", JdeDataType.String, 16),
        new JdeField("WPPCOVR", "WPPCOVR", JdeDataType.Numeric),
        new JdeField("WPMTHPR", "WPMTHPR", JdeDataType.String, 2),
        new JdeField("WPSAID", "WPSAID", JdeDataType.Numeric),
        new JdeField("WPPRODF", "WPPRODF", JdeDataType.String, 16),
        new JdeField("WPPRODM", "WPPRODM", JdeDataType.String, 16),
        new JdeField("WPCOVGR", "WPCOVGR", JdeDataType.String, 16),
        new JdeField("WPPMTHP", "WPPMTHP", JdeDataType.String, 2),
        new JdeField("WPPYPRT", "WPPYPRT", JdeDataType.String, 2),
        new JdeField("WPCRDC", "WPCRDC", JdeDataType.String, 6),
        new JdeField("WPBCRCD", "WPBCRCD", JdeDataType.String, 6),
        new JdeField("WPBCRR", "WPBCRR", JdeDataType.Numeric),
        new JdeField("WPBCRRM", "WPBCRRM", JdeDataType.String, 2),
        new JdeField("WPFESUNB", "WPFESUNB", JdeDataType.Numeric),
        new JdeField("WPFEBILL", "WPFEBILL", JdeDataType.Numeric),
        new JdeField("WPFACUNB", "WPFACUNB", JdeDataType.Numeric),
        new JdeField("WPFTOTB", "WPFTOTB", JdeDataType.Numeric),
        new JdeField("WPPCRCD", "WPPCRCD", JdeDataType.String, 6),
        new JdeField("WPPCRR", "WPPCRR", JdeDataType.Numeric),
        new JdeField("WPPCRRM", "WPPCRRM", JdeDataType.String, 2),
        new JdeField("WPFESUNP", "WPFESUNP", JdeDataType.Numeric),
        new JdeField("WPFEPAAP", "WPFEPAAP", JdeDataType.Numeric),
        new JdeField("WPFACUNP", "WPFACUNP", JdeDataType.Numeric),
        new JdeField("WPFPAAP", "WPFPAAP", JdeDataType.Numeric),
        new JdeField("WPFAILCD", "WPFAILCD", JdeDataType.String, 16),
        new JdeField("WPRETPOL", "WPRETPOL", JdeDataType.String, 2),
        new JdeField("WPDTSUB", "WPDTSUB", JdeDataType.Numeric),
        new JdeField("WPTMSUB", "WPTMSUB", JdeDataType.Numeric),
        new JdeField("WPCSLPRT", "WPCSLPRT", JdeDataType.Numeric),
        new JdeField("WPMCUCSL", "WPMCUCSL", JdeDataType.String, 24),
        new JdeField("WPSRVEND", "WPSRVEND", JdeDataType.Numeric),
        new JdeField("WPRLOT", "WPRLOT", JdeDataType.String, 60),
        new JdeField("WPTAX1", "WPTAX1", JdeDataType.String, 2),
        new JdeField("WPUKIDP", "WPUKIDP", JdeDataType.Numeric),
        new JdeField("WPVMRS31", "WPVMRS31", JdeDataType.String, 4),
        new JdeField("WPVMRS32", "WPVMRS32", JdeDataType.String, 16),
        new JdeField("WPVMRS33", "WPVMRS33", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3111Z2_0", "Primary Key on WPEDUS, WPEDBT, WPEDTN, WPEDLN, WPUKID", new[] { "WPEDUS", "WPEDBT", "WPEDTN", "WPEDLN", "WPUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3111Z2_2", "Index on WPEDUS, WPEDBT, WPEDTN, WPEDLN, WPOPSQ", new[] { "WPEDUS", "WPEDBT", "WPEDTN", "WPEDLN", "WPOPSQ" })
    };
}
