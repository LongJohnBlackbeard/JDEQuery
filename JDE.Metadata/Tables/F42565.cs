using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42565 - .
/// </summary>
public class F42565 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWCTID.
        /// </summary>
        public const string IWCTID = "IWCTID";

        /// <summary>
        /// IWJOBS.
        /// </summary>
        public const string IWJOBS = "IWJOBS";

        /// <summary>
        /// IWDOC.
        /// </summary>
        public const string IWDOC = "IWDOC";

        /// <summary>
        /// IWDCT.
        /// </summary>
        public const string IWDCT = "IWDCT";

        /// <summary>
        /// IWKCO.
        /// </summary>
        public const string IWKCO = "IWKCO";

        /// <summary>
        /// IWDOCO.
        /// </summary>
        public const string IWDOCO = "IWDOCO";

        /// <summary>
        /// IWDCTO.
        /// </summary>
        public const string IWDCTO = "IWDCTO";

        /// <summary>
        /// IWKCOO.
        /// </summary>
        public const string IWKCOO = "IWKCOO";

        /// <summary>
        /// IWLNID.
        /// </summary>
        public const string IWLNID = "IWLNID";

        /// <summary>
        /// IWOSEQ.
        /// </summary>
        public const string IWOSEQ = "IWOSEQ";

        /// <summary>
        /// IWSUBSEQ.
        /// </summary>
        public const string IWSUBSEQ = "IWSUBSEQ";

        /// <summary>
        /// IWAN8.
        /// </summary>
        public const string IWAN8 = "IWAN8";

        /// <summary>
        /// IWSHAN.
        /// </summary>
        public const string IWSHAN = "IWSHAN";

        /// <summary>
        /// IWMCU.
        /// </summary>
        public const string IWMCU = "IWMCU";

        /// <summary>
        /// IWCO.
        /// </summary>
        public const string IWCO = "IWCO";

        /// <summary>
        /// IWITM.
        /// </summary>
        public const string IWITM = "IWITM";

        /// <summary>
        /// IWPRNT.
        /// </summary>
        public const string IWPRNT = "IWPRNT";

        /// <summary>
        /// IWDSC1.
        /// </summary>
        public const string IWDSC1 = "IWDSC1";

        /// <summary>
        /// IWDSC2.
        /// </summary>
        public const string IWDSC2 = "IWDSC2";

        /// <summary>
        /// IWUITM.
        /// </summary>
        public const string IWUITM = "IWUITM";

        /// <summary>
        /// IWUOM.
        /// </summary>
        public const string IWUOM = "IWUOM";

        /// <summary>
        /// IWUOM4.
        /// </summary>
        public const string IWUOM4 = "IWUOM4";

        /// <summary>
        /// IWSOQS.
        /// </summary>
        public const string IWSOQS = "IWSOQS";

        /// <summary>
        /// IWSOBK.
        /// </summary>
        public const string IWSOBK = "IWSOBK";

        /// <summary>
        /// IWSOCN.
        /// </summary>
        public const string IWSOCN = "IWSOCN";

        /// <summary>
        /// IWUPRC.
        /// </summary>
        public const string IWUPRC = "IWUPRC";

        /// <summary>
        /// IWAEXP.
        /// </summary>
        public const string IWAEXP = "IWAEXP";

        /// <summary>
        /// IWECST.
        /// </summary>
        public const string IWECST = "IWECST";

        /// <summary>
        /// IWPCT1.
        /// </summary>
        public const string IWPCT1 = "IWPCT1";

        /// <summary>
        /// IWDRQJ.
        /// </summary>
        public const string IWDRQJ = "IWDRQJ";

        /// <summary>
        /// IWCOMM.
        /// </summary>
        public const string IWCOMM = "IWCOMM";

        /// <summary>
        /// IWLNTY.
        /// </summary>
        public const string IWLNTY = "IWLNTY";

        /// <summary>
        /// IWTXYN.
        /// </summary>
        public const string IWTXYN = "IWTXYN";

        /// <summary>
        /// IWCDSC.
        /// </summary>
        public const string IWCDSC = "IWCDSC";

        /// <summary>
        /// IWIVI.
        /// </summary>
        public const string IWIVI = "IWIVI";

        /// <summary>
        /// IWCITM.
        /// </summary>
        public const string IWCITM = "IWCITM";

        /// <summary>
        /// IWIVD.
        /// </summary>
        public const string IWIVD = "IWIVD";

        /// <summary>
        /// IWRORN.
        /// </summary>
        public const string IWRORN = "IWRORN";

        /// <summary>
        /// IWRCTO.
        /// </summary>
        public const string IWRCTO = "IWRCTO";

        /// <summary>
        /// IWRKCO.
        /// </summary>
        public const string IWRKCO = "IWRKCO";

        /// <summary>
        /// IWINMG.
        /// </summary>
        public const string IWINMG = "IWINMG";

        /// <summary>
        /// IWTAX1.
        /// </summary>
        public const string IWTAX1 = "IWTAX1";

        /// <summary>
        /// IWTXA1.
        /// </summary>
        public const string IWTXA1 = "IWTXA1";

        /// <summary>
        /// IWEXR1.
        /// </summary>
        public const string IWEXR1 = "IWEXR1";

        /// <summary>
        /// IWTAXA.
        /// </summary>
        public const string IWTAXA = "IWTAXA";

        /// <summary>
        /// IWTA1.
        /// </summary>
        public const string IWTA1 = "IWTA1";

        /// <summary>
        /// IWTA2.
        /// </summary>
        public const string IWTA2 = "IWTA2";

        /// <summary>
        /// IWTA3.
        /// </summary>
        public const string IWTA3 = "IWTA3";

        /// <summary>
        /// IWTA4.
        /// </summary>
        public const string IWTA4 = "IWTA4";

        /// <summary>
        /// IWTA5.
        /// </summary>
        public const string IWTA5 = "IWTA5";

        /// <summary>
        /// IWTXR1.
        /// </summary>
        public const string IWTXR1 = "IWTXR1";

        /// <summary>
        /// IWTXR2.
        /// </summary>
        public const string IWTXR2 = "IWTXR2";

        /// <summary>
        /// IWTXR3.
        /// </summary>
        public const string IWTXR3 = "IWTXR3";

        /// <summary>
        /// IWTXR4.
        /// </summary>
        public const string IWTXR4 = "IWTXR4";

        /// <summary>
        /// IWTXR5.
        /// </summary>
        public const string IWTXR5 = "IWTXR5";

        /// <summary>
        /// IWTC2.
        /// </summary>
        public const string IWTC2 = "IWTC2";

        /// <summary>
        /// IWTT3.
        /// </summary>
        public const string IWTT3 = "IWTT3";

        /// <summary>
        /// IWTT4.
        /// </summary>
        public const string IWTT4 = "IWTT4";

        /// <summary>
        /// IWTT5.
        /// </summary>
        public const string IWTT5 = "IWTT5";

        /// <summary>
        /// IWFVTY.
        /// </summary>
        public const string IWFVTY = "IWFVTY";

        /// <summary>
        /// IWHBUS.
        /// </summary>
        public const string IWHBUS = "IWHBUS";

        /// <summary>
        /// IWTRAT.
        /// </summary>
        public const string IWTRAT = "IWTRAT";

        /// <summary>
        /// IWATXA.
        /// </summary>
        public const string IWATXA = "IWATXA";

        /// <summary>
        /// IWSTAM.
        /// </summary>
        public const string IWSTAM = "IWSTAM";

        /// <summary>
        /// IWPTC.
        /// </summary>
        public const string IWPTC = "IWPTC";

        /// <summary>
        /// IWADSC.
        /// </summary>
        public const string IWADSC = "IWADSC";

        /// <summary>
        /// IWUSER.
        /// </summary>
        public const string IWUSER = "IWUSER";

        /// <summary>
        /// IWPID.
        /// </summary>
        public const string IWPID = "IWPID";

        /// <summary>
        /// IWJOBN.
        /// </summary>
        public const string IWJOBN = "IWJOBN";

        /// <summary>
        /// IWUPMJ.
        /// </summary>
        public const string IWUPMJ = "IWUPMJ";

        /// <summary>
        /// IWTDAY.
        /// </summary>
        public const string IWTDAY = "IWTDAY";

        /// <summary>
        /// IWEDOC.
        /// </summary>
        public const string IWEDOC = "IWEDOC";

        /// <summary>
        /// IWEDCT.
        /// </summary>
        public const string IWEDCT = "IWEDCT";

        /// <summary>
        /// IWEKCO.
        /// </summary>
        public const string IWEKCO = "IWEKCO";

        /// <summary>
        /// IWEDLN.
        /// </summary>
        public const string IWEDLN = "IWEDLN";

        /// <summary>
        /// IWSFXO.
        /// </summary>
        public const string IWSFXO = "IWSFXO";

        /// <summary>
        /// IWPA8.
        /// </summary>
        public const string IWPA8 = "IWPA8";

        /// <summary>
        /// IWDSCT.
        /// </summary>
        public const string IWDSCT = "IWDSCT";

        /// <summary>
        /// IWTAXT.
        /// </summary>
        public const string IWTAXT = "IWTAXT";

        /// <summary>
        /// IWTAX2.
        /// </summary>
        public const string IWTAX2 = "IWTAX2";

        /// <summary>
        /// IWTAX3.
        /// </summary>
        public const string IWTAX3 = "IWTAX3";

        /// <summary>
        /// IWTAX4.
        /// </summary>
        public const string IWTAX4 = "IWTAX4";

        /// <summary>
        /// IWTAX5.
        /// </summary>
        public const string IWTAX5 = "IWTAX5";

        /// <summary>
        /// IWATXN.
        /// </summary>
        public const string IWATXN = "IWATXN";

        /// <summary>
        /// IWLPRC.
        /// </summary>
        public const string IWLPRC = "IWLPRC";

        /// <summary>
        /// IWCRCD.
        /// </summary>
        public const string IWCRCD = "IWCRCD";

        /// <summary>
        /// IWCRDC.
        /// </summary>
        public const string IWCRDC = "IWCRDC";

        /// <summary>
        /// IWCRR.
        /// </summary>
        public const string IWCRR = "IWCRR";

        /// <summary>
        /// IWLITM.
        /// </summary>
        public const string IWLITM = "IWLITM";

        /// <summary>
        /// IWCARS.
        /// </summary>
        public const string IWCARS = "IWCARS";

        /// <summary>
        /// IWDMCS.
        /// </summary>
        public const string IWDMCS = "IWDMCS";

        /// <summary>
        /// IWDMCT.
        /// </summary>
        public const string IWDMCT = "IWDMCT";

        /// <summary>
        /// IWRSSN.
        /// </summary>
        public const string IWRSSN = "IWRSSN";

        /// <summary>
        /// IWDTPU.
        /// </summary>
        public const string IWDTPU = "IWDTPU";

        /// <summary>
        /// IWSHPN.
        /// </summary>
        public const string IWSHPN = "IWSHPN";

        /// <summary>
        /// IWDETP.
        /// </summary>
        public const string IWDETP = "IWDETP";

        /// <summary>
        /// IWDCNS.
        /// </summary>
        public const string IWDCNS = "IWDCNS";

        /// <summary>
        /// IWDNTP.
        /// </summary>
        public const string IWDNTP = "IWDNTP";

        /// <summary>
        /// IWEMCU.
        /// </summary>
        public const string IWEMCU = "IWEMCU";

        /// <summary>
        /// IWDNTY.
        /// </summary>
        public const string IWDNTY = "IWDNTY";

        /// <summary>
        /// IWSTPU.
        /// </summary>
        public const string IWSTPU = "IWSTPU";

        /// <summary>
        /// IWSEQN.
        /// </summary>
        public const string IWSEQN = "IWSEQN";

        /// <summary>
        /// IWTEMP.
        /// </summary>
        public const string IWTEMP = "IWTEMP";

        /// <summary>
        /// IWREFN.
        /// </summary>
        public const string IWREFN = "IWREFN";

        /// <summary>
        /// IWREFQ.
        /// </summary>
        public const string IWREFQ = "IWREFQ";

        /// <summary>
        /// IWLOAD.
        /// </summary>
        public const string IWLOAD = "IWLOAD";

        /// <summary>
        /// IWTRP.
        /// </summary>
        public const string IWTRP = "IWTRP";

        /// <summary>
        /// IWMMCO.
        /// </summary>
        public const string IWMMCO = "IWMMCO";

        /// <summary>
        /// IWVMCU.
        /// </summary>
        public const string IWVMCU = "IWVMCU";

        /// <summary>
        /// IWVCF.
        /// </summary>
        public const string IWVCF = "IWVCF";

        /// <summary>
        /// IWMCUS.
        /// </summary>
        public const string IWMCUS = "IWMCUS";

        /// <summary>
        /// IWWGTR.
        /// </summary>
        public const string IWWGTR = "IWWGTR";

        /// <summary>
        /// IWAMBR.
        /// </summary>
        public const string IWAMBR = "IWAMBR";

        /// <summary>
        /// IWBUM5.
        /// </summary>
        public const string IWBUM5 = "IWBUM5";

        /// <summary>
        /// IWBUM4.
        /// </summary>
        public const string IWBUM4 = "IWBUM4";

        /// <summary>
        /// IWBUM3.
        /// </summary>
        public const string IWBUM3 = "IWBUM3";

        /// <summary>
        /// IWSTOK.
        /// </summary>
        public const string IWSTOK = "IWSTOK";

        /// <summary>
        /// IWDTYS.
        /// </summary>
        public const string IWDTYS = "IWDTYS";

        /// <summary>
        /// IWLOTN.
        /// </summary>
        public const string IWLOTN = "IWLOTN";

        /// <summary>
        /// IWAIEP.
        /// </summary>
        public const string IWAIEP = "IWAIEP";

        /// <summary>
        /// IWAILP.
        /// </summary>
        public const string IWAILP = "IWAILP";

        /// <summary>
        /// IWAITR.
        /// </summary>
        public const string IWAITR = "IWAITR";

        /// <summary>
        /// IWAIT1.
        /// </summary>
        public const string IWAIT1 = "IWAIT1";

        /// <summary>
        /// IWAIT2.
        /// </summary>
        public const string IWAIT2 = "IWAIT2";

        /// <summary>
        /// IWAIT3.
        /// </summary>
        public const string IWAIT3 = "IWAIT3";

        /// <summary>
        /// IWAIT4.
        /// </summary>
        public const string IWAIT4 = "IWAIT4";

        /// <summary>
        /// IWAIT5.
        /// </summary>
        public const string IWAIT5 = "IWAIT5";

        /// <summary>
        /// IWAICM.
        /// </summary>
        public const string IWAICM = "IWAICM";

        /// <summary>
        /// IWAITX.
        /// </summary>
        public const string IWAITX = "IWAITX";

        /// <summary>
        /// IWAITA.
        /// </summary>
        public const string IWAITA = "IWAITA";

        /// <summary>
        /// IWAITU.
        /// </summary>
        public const string IWAITU = "IWAITU";

        /// <summary>
        /// IWAIAD.
        /// </summary>
        public const string IWAIAD = "IWAIAD";

        /// <summary>
        /// IWAIX1.
        /// </summary>
        public const string IWAIX1 = "IWAIX1";

        /// <summary>
        /// IWAIX2.
        /// </summary>
        public const string IWAIX2 = "IWAIX2";

        /// <summary>
        /// IWAIX3.
        /// </summary>
        public const string IWAIX3 = "IWAIX3";

        /// <summary>
        /// IWAIS1.
        /// </summary>
        public const string IWAIS1 = "IWAIS1";

        /// <summary>
        /// IWAIS2.
        /// </summary>
        public const string IWAIS2 = "IWAIS2";

        /// <summary>
        /// IWAIS3.
        /// </summary>
        public const string IWAIS3 = "IWAIS3";

        /// <summary>
        /// IWAIS4.
        /// </summary>
        public const string IWAIS4 = "IWAIS4";

        /// <summary>
        /// IWAIS5.
        /// </summary>
        public const string IWAIS5 = "IWAIS5";

        /// <summary>
        /// IWAICC.
        /// </summary>
        public const string IWAICC = "IWAICC";

        /// <summary>
        /// IWAIRR.
        /// </summary>
        public const string IWAIRR = "IWAIRR";

        /// <summary>
        /// IWAITD.
        /// </summary>
        public const string IWAITD = "IWAITD";

        /// <summary>
        /// IWAITS.
        /// </summary>
        public const string IWAITS = "IWAITS";

        /// <summary>
        /// IWSPHD.
        /// </summary>
        public const string IWSPHD = "IWSPHD";

        /// <summary>
        /// IWATAM.
        /// </summary>
        public const string IWATAM = "IWATAM";

        /// <summary>
        /// IWATAT.
        /// </summary>
        public const string IWATAT = "IWATAT";

        /// <summary>
        /// IWAIAM.
        /// </summary>
        public const string IWAIAM = "IWAIAM";

        /// <summary>
        /// IWAIAT.
        /// </summary>
        public const string IWAIAT = "IWAIAT";

        /// <summary>
        /// IWN1FU.
        /// </summary>
        public const string IWN1FU = "IWN1FU";

        /// <summary>
        /// IWN2FU.
        /// </summary>
        public const string IWN2FU = "IWN2FU";

        /// <summary>
        /// IWN3FU.
        /// </summary>
        public const string IWN3FU = "IWN3FU";

        /// <summary>
        /// IWC1FU.
        /// </summary>
        public const string IWC1FU = "IWC1FU";

        /// <summary>
        /// IWC2FU.
        /// </summary>
        public const string IWC2FU = "IWC2FU";

        /// <summary>
        /// IWD1FU.
        /// </summary>
        public const string IWD1FU = "IWD1FU";

        /// <summary>
        /// IWD2FU.
        /// </summary>
        public const string IWD2FU = "IWD2FU";

        /// <summary>
        /// IWS1FU.
        /// </summary>
        public const string IWS1FU = "IWS1FU";

        /// <summary>
        /// IWS2FU.
        /// </summary>
        public const string IWS2FU = "IWS2FU";

        /// <summary>
        /// IWFVTR.
        /// </summary>
        public const string IWFVTR = "IWFVTR";

        /// <summary>
        /// IWBSDVAL.
        /// </summary>
        public const string IWBSDVAL = "IWBSDVAL";

        /// <summary>
        /// IWSRFLAG.
        /// </summary>
        public const string IWSRFLAG = "IWSRFLAG";

        /// <summary>
        /// IWSOOR.
        /// </summary>
        public const string IWSOOR = "IWSOOR";

        /// <summary>
        /// IWRCD.
        /// </summary>
        public const string IWRCD = "IWRCD";

        /// <summary>
        /// IWPBAN.
        /// </summary>
        public const string IWPBAN = "IWPBAN";

        /// <summary>
        /// IWOORN.
        /// </summary>
        public const string IWOORN = "IWOORN";

        /// <summary>
        /// IWODOC.
        /// </summary>
        public const string IWODOC = "IWODOC";

        /// <summary>
        /// IWODCT.
        /// </summary>
        public const string IWODCT = "IWODCT";

        /// <summary>
        /// IWOCTO.
        /// </summary>
        public const string IWOCTO = "IWOCTO";

        /// <summary>
        /// IWFTAN.
        /// </summary>
        public const string IWFTAN = "IWFTAN";

        /// <summary>
        /// IWDOC1.
        /// </summary>
        public const string IWDOC1 = "IWDOC1";

        /// <summary>
        /// IWDCT4.
        /// </summary>
        public const string IWDCT4 = "IWDCT4";

        /// <summary>
        /// IWITMU.
        /// </summary>
        public const string IWITMU = "IWITMU";

        /// <summary>
        /// IWUTAM.
        /// </summary>
        public const string IWUTAM = "IWUTAM";

        /// <summary>
        /// IWUOM2.
        /// </summary>
        public const string IWUOM2 = "IWUOM2";

        /// <summary>
        /// IWSQOR.
        /// </summary>
        public const string IWSQOR = "IWSQOR";

        /// <summary>
        /// IWCIRV.
        /// </summary>
        public const string IWCIRV = "IWCIRV";

        /// <summary>
        /// IWPSJOBNO.
        /// </summary>
        public const string IWPSJOBNO = "IWPSJOBNO";

        /// <summary>
        /// IWJOBSQ.
        /// </summary>
        public const string IWJOBSQ = "IWJOBSQ";

        /// <summary>
        /// IWCARDNO.
        /// </summary>
        public const string IWCARDNO = "IWCARDNO";

        /// <summary>
        /// IWRLIT.
        /// </summary>
        public const string IWRLIT = "IWRLIT";

        /// <summary>
        /// IWKITID.
        /// </summary>
        public const string IWKITID = "IWKITID";

        /// <summary>
        /// IWKITAMTDOM.
        /// </summary>
        public const string IWKITAMTDOM = "IWKITAMTDOM";

        /// <summary>
        /// IWKITAMTFOR.
        /// </summary>
        public const string IWKITAMTFOR = "IWKITAMTFOR";

        /// <summary>
        /// IWKITDIRTY.
        /// </summary>
        public const string IWKITDIRTY = "IWKITDIRTY";

        /// <summary>
        /// IWKTLN.
        /// </summary>
        public const string IWKTLN = "IWKTLN";

        /// <summary>
        /// IWSTKT.
        /// </summary>
        public const string IWSTKT = "IWSTKT";

        /// <summary>
        /// IWRKIT.
        /// </summary>
        public const string IWRKIT = "IWRKIT";

        /// <summary>
        /// IWSIDT.
        /// </summary>
        public const string IWSIDT = "IWSIDT";

        /// <summary>
        /// IWAST.
        /// </summary>
        public const string IWAST = "IWAST";

        /// <summary>
        /// IWTUPRC.
        /// </summary>
        public const string IWTUPRC = "IWTUPRC";

        /// <summary>
        /// IWTAEXP.
        /// </summary>
        public const string IWTAEXP = "IWTAEXP";

        /// <summary>
        /// IWTAIEP.
        /// </summary>
        public const string IWTAIEP = "IWTAIEP";

        /// <summary>
        /// IWUTA.
        /// </summary>
        public const string IWUTA = "IWUTA";

        /// <summary>
        /// IWETA.
        /// </summary>
        public const string IWETA = "IWETA";

        /// <summary>
        /// IWTKITAMTD.
        /// </summary>
        public const string IWTKITAMTD = "IWTKITAMTD";

        /// <summary>
        /// IWTKITAMTF.
        /// </summary>
        public const string IWTKITAMTF = "IWTKITAMTF";

        /// <summary>
        /// IWDTXJ.
        /// </summary>
        public const string IWDTXJ = "IWDTXJ";

        /// <summary>
        /// IWUTP.
        /// </summary>
        public const string IWUTP = "IWUTP";

        /// <summary>
        /// IWOILNTY.
        /// </summary>
        public const string IWOILNTY = "IWOILNTY";

        /// <summary>
        /// IWAEXPO.
        /// </summary>
        public const string IWAEXPO = "IWAEXPO";
    }

    /// <inheritdoc />
    public override string TableName => "F42565";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWCTID", "IWCTID", JdeDataType.String, 30, true, true),
        new JdeField("IWJOBS", "IWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("IWDOC", "IWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IWDCT", "IWDCT", JdeDataType.String, 4, true, true),
        new JdeField("IWKCO", "IWKCO", JdeDataType.String, 10, true, true),
        new JdeField("IWDOCO", "IWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IWDCTO", "IWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("IWKCOO", "IWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IWLNID", "IWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("IWOSEQ", "IWOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IWSUBSEQ", "IWSUBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IWAN8", "IWAN8", JdeDataType.Numeric),
        new JdeField("IWSHAN", "IWSHAN", JdeDataType.Numeric),
        new JdeField("IWMCU", "IWMCU", JdeDataType.String, 24),
        new JdeField("IWCO", "IWCO", JdeDataType.String, 10),
        new JdeField("IWITM", "IWITM", JdeDataType.Numeric),
        new JdeField("IWPRNT", "IWPRNT", JdeDataType.String, 2),
        new JdeField("IWDSC1", "IWDSC1", JdeDataType.String, 60),
        new JdeField("IWDSC2", "IWDSC2", JdeDataType.String, 60),
        new JdeField("IWUITM", "IWUITM", JdeDataType.String, 52),
        new JdeField("IWUOM", "IWUOM", JdeDataType.String, 4),
        new JdeField("IWUOM4", "IWUOM4", JdeDataType.String, 4),
        new JdeField("IWSOQS", "IWSOQS", JdeDataType.Numeric),
        new JdeField("IWSOBK", "IWSOBK", JdeDataType.Numeric),
        new JdeField("IWSOCN", "IWSOCN", JdeDataType.Numeric),
        new JdeField("IWUPRC", "IWUPRC", JdeDataType.Numeric),
        new JdeField("IWAEXP", "IWAEXP", JdeDataType.Numeric),
        new JdeField("IWECST", "IWECST", JdeDataType.Numeric),
        new JdeField("IWPCT1", "IWPCT1", JdeDataType.Numeric),
        new JdeField("IWDRQJ", "IWDRQJ", JdeDataType.Numeric),
        new JdeField("IWCOMM", "IWCOMM", JdeDataType.String, 2),
        new JdeField("IWLNTY", "IWLNTY", JdeDataType.String, 4),
        new JdeField("IWTXYN", "IWTXYN", JdeDataType.String, 2),
        new JdeField("IWCDSC", "IWCDSC", JdeDataType.String, 2),
        new JdeField("IWIVI", "IWIVI", JdeDataType.String, 2),
        new JdeField("IWCITM", "IWCITM", JdeDataType.String, 50),
        new JdeField("IWIVD", "IWIVD", JdeDataType.Numeric),
        new JdeField("IWRORN", "IWRORN", JdeDataType.String, 16),
        new JdeField("IWRCTO", "IWRCTO", JdeDataType.String, 4),
        new JdeField("IWRKCO", "IWRKCO", JdeDataType.String, 10),
        new JdeField("IWINMG", "IWINMG", JdeDataType.String, 20),
        new JdeField("IWTAX1", "IWTAX1", JdeDataType.String, 2),
        new JdeField("IWTXA1", "IWTXA1", JdeDataType.String, 20),
        new JdeField("IWEXR1", "IWEXR1", JdeDataType.String, 4),
        new JdeField("IWTAXA", "IWTAXA", JdeDataType.String, 60),
        new JdeField("IWTA1", "IWTA1", JdeDataType.Numeric),
        new JdeField("IWTA2", "IWTA2", JdeDataType.Numeric),
        new JdeField("IWTA3", "IWTA3", JdeDataType.Numeric),
        new JdeField("IWTA4", "IWTA4", JdeDataType.Numeric),
        new JdeField("IWTA5", "IWTA5", JdeDataType.Numeric),
        new JdeField("IWTXR1", "IWTXR1", JdeDataType.Numeric),
        new JdeField("IWTXR2", "IWTXR2", JdeDataType.Numeric),
        new JdeField("IWTXR3", "IWTXR3", JdeDataType.Numeric),
        new JdeField("IWTXR4", "IWTXR4", JdeDataType.Numeric),
        new JdeField("IWTXR5", "IWTXR5", JdeDataType.Numeric),
        new JdeField("IWTC2", "IWTC2", JdeDataType.String, 2),
        new JdeField("IWTT3", "IWTT3", JdeDataType.String, 2),
        new JdeField("IWTT4", "IWTT4", JdeDataType.String, 2),
        new JdeField("IWTT5", "IWTT5", JdeDataType.String, 2),
        new JdeField("IWFVTY", "IWFVTY", JdeDataType.String, 2),
        new JdeField("IWHBUS", "IWHBUS", JdeDataType.String, 2),
        new JdeField("IWTRAT", "IWTRAT", JdeDataType.Numeric),
        new JdeField("IWATXA", "IWATXA", JdeDataType.Numeric),
        new JdeField("IWSTAM", "IWSTAM", JdeDataType.Numeric),
        new JdeField("IWPTC", "IWPTC", JdeDataType.String, 6),
        new JdeField("IWADSC", "IWADSC", JdeDataType.Numeric),
        new JdeField("IWUSER", "IWUSER", JdeDataType.String, 20),
        new JdeField("IWPID", "IWPID", JdeDataType.String, 20),
        new JdeField("IWJOBN", "IWJOBN", JdeDataType.String, 20),
        new JdeField("IWUPMJ", "IWUPMJ", JdeDataType.Numeric),
        new JdeField("IWTDAY", "IWTDAY", JdeDataType.Numeric),
        new JdeField("IWEDOC", "IWEDOC", JdeDataType.Numeric),
        new JdeField("IWEDCT", "IWEDCT", JdeDataType.String, 4),
        new JdeField("IWEKCO", "IWEKCO", JdeDataType.String, 10),
        new JdeField("IWEDLN", "IWEDLN", JdeDataType.Numeric),
        new JdeField("IWSFXO", "IWSFXO", JdeDataType.String, 6),
        new JdeField("IWPA8", "IWPA8", JdeDataType.Numeric),
        new JdeField("IWDSCT", "IWDSCT", JdeDataType.Numeric),
        new JdeField("IWTAXT", "IWTAXT", JdeDataType.Numeric),
        new JdeField("IWTAX2", "IWTAX2", JdeDataType.Numeric),
        new JdeField("IWTAX3", "IWTAX3", JdeDataType.Numeric),
        new JdeField("IWTAX4", "IWTAX4", JdeDataType.Numeric),
        new JdeField("IWTAX5", "IWTAX5", JdeDataType.Numeric),
        new JdeField("IWATXN", "IWATXN", JdeDataType.Numeric),
        new JdeField("IWLPRC", "IWLPRC", JdeDataType.Numeric),
        new JdeField("IWCRCD", "IWCRCD", JdeDataType.String, 6),
        new JdeField("IWCRDC", "IWCRDC", JdeDataType.String, 6),
        new JdeField("IWCRR", "IWCRR", JdeDataType.Numeric),
        new JdeField("IWLITM", "IWLITM", JdeDataType.String, 50),
        new JdeField("IWCARS", "IWCARS", JdeDataType.Numeric),
        new JdeField("IWDMCS", "IWDMCS", JdeDataType.Numeric),
        new JdeField("IWDMCT", "IWDMCT", JdeDataType.String, 24),
        new JdeField("IWRSSN", "IWRSSN", JdeDataType.Numeric),
        new JdeField("IWDTPU", "IWDTPU", JdeDataType.String, 2),
        new JdeField("IWSHPN", "IWSHPN", JdeDataType.Numeric),
        new JdeField("IWDETP", "IWDETP", JdeDataType.Numeric),
        new JdeField("IWDCNS", "IWDCNS", JdeDataType.String, 2),
        new JdeField("IWDNTP", "IWDNTP", JdeDataType.String, 2),
        new JdeField("IWEMCU", "IWEMCU", JdeDataType.String, 24),
        new JdeField("IWDNTY", "IWDNTY", JdeDataType.Numeric),
        new JdeField("IWSTPU", "IWSTPU", JdeDataType.String, 2),
        new JdeField("IWSEQN", "IWSEQN", JdeDataType.Numeric),
        new JdeField("IWTEMP", "IWTEMP", JdeDataType.Numeric),
        new JdeField("IWREFN", "IWREFN", JdeDataType.String, 60),
        new JdeField("IWREFQ", "IWREFQ", JdeDataType.String, 4),
        new JdeField("IWLOAD", "IWLOAD", JdeDataType.Numeric),
        new JdeField("IWTRP", "IWTRP", JdeDataType.Numeric),
        new JdeField("IWMMCO", "IWMMCO", JdeDataType.String, 10),
        new JdeField("IWVMCU", "IWVMCU", JdeDataType.String, 24),
        new JdeField("IWVCF", "IWVCF", JdeDataType.Numeric),
        new JdeField("IWMCUS", "IWMCUS", JdeDataType.String, 24),
        new JdeField("IWWGTR", "IWWGTR", JdeDataType.Numeric),
        new JdeField("IWAMBR", "IWAMBR", JdeDataType.Numeric),
        new JdeField("IWBUM5", "IWBUM5", JdeDataType.String, 4),
        new JdeField("IWBUM4", "IWBUM4", JdeDataType.String, 4),
        new JdeField("IWBUM3", "IWBUM3", JdeDataType.String, 4),
        new JdeField("IWSTOK", "IWSTOK", JdeDataType.Numeric),
        new JdeField("IWDTYS", "IWDTYS", JdeDataType.String, 4),
        new JdeField("IWLOTN", "IWLOTN", JdeDataType.String, 60),
        new JdeField("IWAIEP", "IWAIEP", JdeDataType.Numeric),
        new JdeField("IWAILP", "IWAILP", JdeDataType.Numeric),
        new JdeField("IWAITR", "IWAITR", JdeDataType.Numeric),
        new JdeField("IWAIT1", "IWAIT1", JdeDataType.Numeric),
        new JdeField("IWAIT2", "IWAIT2", JdeDataType.Numeric),
        new JdeField("IWAIT3", "IWAIT3", JdeDataType.Numeric),
        new JdeField("IWAIT4", "IWAIT4", JdeDataType.Numeric),
        new JdeField("IWAIT5", "IWAIT5", JdeDataType.Numeric),
        new JdeField("IWAICM", "IWAICM", JdeDataType.String, 2),
        new JdeField("IWAITX", "IWAITX", JdeDataType.Numeric),
        new JdeField("IWAITA", "IWAITA", JdeDataType.Numeric),
        new JdeField("IWAITU", "IWAITU", JdeDataType.Numeric),
        new JdeField("IWAIAD", "IWAIAD", JdeDataType.Numeric),
        new JdeField("IWAIX1", "IWAIX1", JdeDataType.String, 2),
        new JdeField("IWAIX2", "IWAIX2", JdeDataType.String, 2),
        new JdeField("IWAIX3", "IWAIX3", JdeDataType.String, 2),
        new JdeField("IWAIS1", "IWAIS1", JdeDataType.Numeric),
        new JdeField("IWAIS2", "IWAIS2", JdeDataType.Numeric),
        new JdeField("IWAIS3", "IWAIS3", JdeDataType.Numeric),
        new JdeField("IWAIS4", "IWAIS4", JdeDataType.Numeric),
        new JdeField("IWAIS5", "IWAIS5", JdeDataType.Numeric),
        new JdeField("IWAICC", "IWAICC", JdeDataType.String, 6),
        new JdeField("IWAIRR", "IWAIRR", JdeDataType.Numeric),
        new JdeField("IWAITD", "IWAITD", JdeDataType.Numeric),
        new JdeField("IWAITS", "IWAITS", JdeDataType.String, 2),
        new JdeField("IWSPHD", "IWSPHD", JdeDataType.String, 20),
        new JdeField("IWATAM", "IWATAM", JdeDataType.Numeric),
        new JdeField("IWATAT", "IWATAT", JdeDataType.Numeric),
        new JdeField("IWAIAM", "IWAIAM", JdeDataType.Numeric),
        new JdeField("IWAIAT", "IWAIAT", JdeDataType.Numeric),
        new JdeField("IWN1FU", "IWN1FU", JdeDataType.Numeric),
        new JdeField("IWN2FU", "IWN2FU", JdeDataType.Numeric),
        new JdeField("IWN3FU", "IWN3FU", JdeDataType.Numeric),
        new JdeField("IWC1FU", "IWC1FU", JdeDataType.String, 2),
        new JdeField("IWC2FU", "IWC2FU", JdeDataType.String, 2),
        new JdeField("IWD1FU", "IWD1FU", JdeDataType.Numeric),
        new JdeField("IWD2FU", "IWD2FU", JdeDataType.Numeric),
        new JdeField("IWS1FU", "IWS1FU", JdeDataType.String, 60),
        new JdeField("IWS2FU", "IWS2FU", JdeDataType.String, 60),
        new JdeField("IWFVTR", "IWFVTR", JdeDataType.Numeric),
        new JdeField("IWBSDVAL", "IWBSDVAL", JdeDataType.Numeric),
        new JdeField("IWSRFLAG", "IWSRFLAG", JdeDataType.String, 2),
        new JdeField("IWSOOR", "IWSOOR", JdeDataType.Numeric),
        new JdeField("IWRCD", "IWRCD", JdeDataType.String, 6),
        new JdeField("IWPBAN", "IWPBAN", JdeDataType.Numeric),
        new JdeField("IWOORN", "IWOORN", JdeDataType.String, 16),
        new JdeField("IWODOC", "IWODOC", JdeDataType.Numeric),
        new JdeField("IWODCT", "IWODCT", JdeDataType.String, 4),
        new JdeField("IWOCTO", "IWOCTO", JdeDataType.String, 4),
        new JdeField("IWFTAN", "IWFTAN", JdeDataType.Numeric),
        new JdeField("IWDOC1", "IWDOC1", JdeDataType.Numeric),
        new JdeField("IWDCT4", "IWDCT4", JdeDataType.String, 4),
        new JdeField("IWITMU", "IWITMU", JdeDataType.String, 2),
        new JdeField("IWUTAM", "IWUTAM", JdeDataType.Numeric),
        new JdeField("IWUOM2", "IWUOM2", JdeDataType.String, 4),
        new JdeField("IWSQOR", "IWSQOR", JdeDataType.Numeric),
        new JdeField("IWCIRV", "IWCIRV", JdeDataType.String, 40),
        new JdeField("IWPSJOBNO", "IWPSJOBNO", JdeDataType.String, 30),
        new JdeField("IWJOBSQ", "IWJOBSQ", JdeDataType.String, 30),
        new JdeField("IWCARDNO", "IWCARDNO", JdeDataType.String, 8),
        new JdeField("IWRLIT", "IWRLIT", JdeDataType.String, 16),
        new JdeField("IWKITID", "IWKITID", JdeDataType.Numeric),
        new JdeField("IWKITAMTDOM", "IWKITAMTDOM", JdeDataType.Numeric),
        new JdeField("IWKITAMTFOR", "IWKITAMTFOR", JdeDataType.Numeric),
        new JdeField("IWKITDIRTY", "IWKITDIRTY", JdeDataType.String, 2),
        new JdeField("IWKTLN", "IWKTLN", JdeDataType.Numeric),
        new JdeField("IWSTKT", "IWSTKT", JdeDataType.String, 2),
        new JdeField("IWRKIT", "IWRKIT", JdeDataType.Numeric),
        new JdeField("IWSIDT", "IWSIDT", JdeDataType.Numeric),
        new JdeField("IWAST", "IWAST", JdeDataType.String, 16),
        new JdeField("IWTUPRC", "IWTUPRC", JdeDataType.Numeric),
        new JdeField("IWTAEXP", "IWTAEXP", JdeDataType.Numeric),
        new JdeField("IWTAIEP", "IWTAIEP", JdeDataType.Numeric),
        new JdeField("IWUTA", "IWUTA", JdeDataType.Numeric),
        new JdeField("IWETA", "IWETA", JdeDataType.Numeric),
        new JdeField("IWTKITAMTD", "IWTKITAMTD", JdeDataType.Numeric),
        new JdeField("IWTKITAMTF", "IWTKITAMTF", JdeDataType.Numeric),
        new JdeField("IWDTXJ", "IWDTXJ", JdeDataType.Numeric),
        new JdeField("IWUTP", "IWUTP", JdeDataType.String, 2),
        new JdeField("IWOILNTY", "IWOILNTY", JdeDataType.String, 2),
        new JdeField("IWAEXPO", "IWAEXPO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42565_0", "Primary Key on IWCTID, IWJOBS, IWDOC, IWDCT, IWKCO, IWDOCO, IWDCTO, IWKCOO, IWLNID, IWOSEQ, IWSUBSEQ", new[] { "IWCTID", "IWJOBS", "IWDOC", "IWDCT", "IWKCO", "IWDOCO", "IWDCTO", "IWKCOO", "IWLNID", "IWOSEQ", "IWSUBSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42565_2", "Index on IWCTID, IWJOBS, IWAN8, IWCRCD, IWCRDC, IWCRR, IWPTC", new[] { "IWCTID", "IWJOBS", "IWAN8", "IWCRCD", "IWCRDC", "IWCRR", "IWPTC" }),
        new JdeIndex("F42565_3", "Index on IWCTID, IWJOBS, IWLITM, IWUPRC, IWUOM, IWLNTY, IWUOM4, IWDOC, IWDCT, IWKCO", new[] { "IWCTID", "IWJOBS", "IWLITM", "IWUPRC", "IWUOM", "IWLNTY", "IWUOM4", "IWDOC", "IWDCT", "IWKCO" }),
        new JdeIndex("F42565_4", "Index on IWCTID, IWJOBS, IWDOCO, IWDCTO, IWKCOO, IWLNID, IWUPRC, IWUOM, IWLNTY, IWUOM4", new[] { "IWCTID", "IWJOBS", "IWDOCO", "IWDCTO", "IWKCOO", "IWLNID", "IWUPRC", "IWUOM", "IWLNTY", "IWUOM4" }),
        new JdeIndex("F42565_5", "Index on IWCTID, IWJOBS", new[] { "IWCTID", "IWJOBS" }),
        new JdeIndex("F42565_6", "Index on IWCTID, IWJOBS, IWDOC, IWDCT, IWKCO, IWDOCO, IWDCTO, IWKCOO, IWKITID, IWLNID, IWOSEQ, IWSUBSEQ", new[] { "IWCTID", "IWJOBS", "IWDOC", "IWDCT", "IWKCO", "IWDOCO", "IWDCTO", "IWKCOO", "IWKITID", "IWLNID", "IWOSEQ", "IWSUBSEQ" }),
        new JdeIndex("F42565_7", "Index on IWCTID, IWJOBS, IWITM, IWUPRC, IWUOM, IWUOM4, IWDOC, IWDCT, IWKCO, IWAST", new[] { "IWCTID", "IWJOBS", "IWITM", "IWUPRC", "IWUOM", "IWUOM4", "IWDOC", "IWDCT", "IWKCO", "IWAST" }),
        new JdeIndex("F42565_8", "Index on IWCTID, IWJOBS, IWDOCO, IWDCTO, IWKCOO, IWLNID, IWUPRC, IWUOM, IWUOM4, IWAST", new[] { "IWCTID", "IWJOBS", "IWDOCO", "IWDCTO", "IWKCOO", "IWLNID", "IWUPRC", "IWUOM", "IWUOM4", "IWAST" })
    };
}
