using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47011 - .
/// </summary>
public class F47011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDTY.
        /// </summary>
        public const string SYEDTY = "SYEDTY";

        /// <summary>
        /// SYEDSQ.
        /// </summary>
        public const string SYEDSQ = "SYEDSQ";

        /// <summary>
        /// SYEKCO.
        /// </summary>
        public const string SYEKCO = "SYEKCO";

        /// <summary>
        /// SYEDOC.
        /// </summary>
        public const string SYEDOC = "SYEDOC";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDST.
        /// </summary>
        public const string SYEDST = "SYEDST";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYEDER.
        /// </summary>
        public const string SYEDER = "SYEDER";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYOFRQ.
        /// </summary>
        public const string SYOFRQ = "SYOFRQ";

        /// <summary>
        /// SYNXDJ.
        /// </summary>
        public const string SYNXDJ = "SYNXDJ";

        /// <summary>
        /// SYSSDJ.
        /// </summary>
        public const string SYSSDJ = "SYSSDJ";

        /// <summary>
        /// SYTPUR.
        /// </summary>
        public const string SYTPUR = "SYTPUR";

        /// <summary>
        /// SYKCOO.
        /// </summary>
        public const string SYKCOO = "SYKCOO";

        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYDCTO.
        /// </summary>
        public const string SYDCTO = "SYDCTO";

        /// <summary>
        /// SYSFXO.
        /// </summary>
        public const string SYSFXO = "SYSFXO";

        /// <summary>
        /// SYMCU.
        /// </summary>
        public const string SYMCU = "SYMCU";

        /// <summary>
        /// SYCO.
        /// </summary>
        public const string SYCO = "SYCO";

        /// <summary>
        /// SYOKCO.
        /// </summary>
        public const string SYOKCO = "SYOKCO";

        /// <summary>
        /// SYOORN.
        /// </summary>
        public const string SYOORN = "SYOORN";

        /// <summary>
        /// SYOCTO.
        /// </summary>
        public const string SYOCTO = "SYOCTO";

        /// <summary>
        /// SYRKCO.
        /// </summary>
        public const string SYRKCO = "SYRKCO";

        /// <summary>
        /// SYRORN.
        /// </summary>
        public const string SYRORN = "SYRORN";

        /// <summary>
        /// SYRCTO.
        /// </summary>
        public const string SYRCTO = "SYRCTO";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYSHAN.
        /// </summary>
        public const string SYSHAN = "SYSHAN";

        /// <summary>
        /// SYPA8.
        /// </summary>
        public const string SYPA8 = "SYPA8";

        /// <summary>
        /// SYDRQJ.
        /// </summary>
        public const string SYDRQJ = "SYDRQJ";

        /// <summary>
        /// SYTRDJ.
        /// </summary>
        public const string SYTRDJ = "SYTRDJ";

        /// <summary>
        /// SYPDDJ.
        /// </summary>
        public const string SYPDDJ = "SYPDDJ";

        /// <summary>
        /// SYOPDJ.
        /// </summary>
        public const string SYOPDJ = "SYOPDJ";

        /// <summary>
        /// SYADDJ.
        /// </summary>
        public const string SYADDJ = "SYADDJ";

        /// <summary>
        /// SYCNDJ.
        /// </summary>
        public const string SYCNDJ = "SYCNDJ";

        /// <summary>
        /// SYPEFJ.
        /// </summary>
        public const string SYPEFJ = "SYPEFJ";

        /// <summary>
        /// SYPPDJ.
        /// </summary>
        public const string SYPPDJ = "SYPPDJ";

        /// <summary>
        /// SYPSDJ.
        /// </summary>
        public const string SYPSDJ = "SYPSDJ";

        /// <summary>
        /// SYVR01.
        /// </summary>
        public const string SYVR01 = "SYVR01";

        /// <summary>
        /// SYVR02.
        /// </summary>
        public const string SYVR02 = "SYVR02";

        /// <summary>
        /// SYDEL1.
        /// </summary>
        public const string SYDEL1 = "SYDEL1";

        /// <summary>
        /// SYDEL2.
        /// </summary>
        public const string SYDEL2 = "SYDEL2";

        /// <summary>
        /// SYINMG.
        /// </summary>
        public const string SYINMG = "SYINMG";

        /// <summary>
        /// SYPTC.
        /// </summary>
        public const string SYPTC = "SYPTC";

        /// <summary>
        /// SYRYIN.
        /// </summary>
        public const string SYRYIN = "SYRYIN";

        /// <summary>
        /// SYASN.
        /// </summary>
        public const string SYASN = "SYASN";

        /// <summary>
        /// SYPRGP.
        /// </summary>
        public const string SYPRGP = "SYPRGP";

        /// <summary>
        /// SYTRDC.
        /// </summary>
        public const string SYTRDC = "SYTRDC";

        /// <summary>
        /// SYPCRT.
        /// </summary>
        public const string SYPCRT = "SYPCRT";

        /// <summary>
        /// SYTXA1.
        /// </summary>
        public const string SYTXA1 = "SYTXA1";

        /// <summary>
        /// SYEXR1.
        /// </summary>
        public const string SYEXR1 = "SYEXR1";

        /// <summary>
        /// SYTXCT.
        /// </summary>
        public const string SYTXCT = "SYTXCT";

        /// <summary>
        /// SYATXT.
        /// </summary>
        public const string SYATXT = "SYATXT";

        /// <summary>
        /// SYPRIO.
        /// </summary>
        public const string SYPRIO = "SYPRIO";

        /// <summary>
        /// SYBACK.
        /// </summary>
        public const string SYBACK = "SYBACK";

        /// <summary>
        /// SYSBAL.
        /// </summary>
        public const string SYSBAL = "SYSBAL";

        /// <summary>
        /// SYNTR.
        /// </summary>
        public const string SYNTR = "SYNTR";

        /// <summary>
        /// SYANBY.
        /// </summary>
        public const string SYANBY = "SYANBY";

        /// <summary>
        /// SYCARS.
        /// </summary>
        public const string SYCARS = "SYCARS";

        /// <summary>
        /// SYMOT.
        /// </summary>
        public const string SYMOT = "SYMOT";

        /// <summary>
        /// SYCOT.
        /// </summary>
        public const string SYCOT = "SYCOT";

        /// <summary>
        /// SYROUT.
        /// </summary>
        public const string SYROUT = "SYROUT";

        /// <summary>
        /// SYSTOP.
        /// </summary>
        public const string SYSTOP = "SYSTOP";

        /// <summary>
        /// SYZON.
        /// </summary>
        public const string SYZON = "SYZON";

        /// <summary>
        /// SYCNID.
        /// </summary>
        public const string SYCNID = "SYCNID";

        /// <summary>
        /// SYFRTH.
        /// </summary>
        public const string SYFRTH = "SYFRTH";

        /// <summary>
        /// SYAFT.
        /// </summary>
        public const string SYAFT = "SYAFT";

        /// <summary>
        /// SYRCD.
        /// </summary>
        public const string SYRCD = "SYRCD";

        /// <summary>
        /// SYOTOT.
        /// </summary>
        public const string SYOTOT = "SYOTOT";

        /// <summary>
        /// SYTOTC.
        /// </summary>
        public const string SYTOTC = "SYTOTC";

        /// <summary>
        /// SYWUMD.
        /// </summary>
        public const string SYWUMD = "SYWUMD";

        /// <summary>
        /// SYVUMD.
        /// </summary>
        public const string SYVUMD = "SYVUMD";

        /// <summary>
        /// SYAUTN.
        /// </summary>
        public const string SYAUTN = "SYAUTN";

        /// <summary>
        /// SYCACT.
        /// </summary>
        public const string SYCACT = "SYCACT";

        /// <summary>
        /// SYCEXP.
        /// </summary>
        public const string SYCEXP = "SYCEXP";

        /// <summary>
        /// SYCRMD.
        /// </summary>
        public const string SYCRMD = "SYCRMD";

        /// <summary>
        /// SYCRRM.
        /// </summary>
        public const string SYCRRM = "SYCRRM";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRR.
        /// </summary>
        public const string SYCRR = "SYCRR";

        /// <summary>
        /// SYLNGP.
        /// </summary>
        public const string SYLNGP = "SYLNGP";

        /// <summary>
        /// SYFAP.
        /// </summary>
        public const string SYFAP = "SYFAP";

        /// <summary>
        /// SYFCST.
        /// </summary>
        public const string SYFCST = "SYFCST";

        /// <summary>
        /// SYORBY.
        /// </summary>
        public const string SYORBY = "SYORBY";

        /// <summary>
        /// SYTKBY.
        /// </summary>
        public const string SYTKBY = "SYTKBY";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYIR01.
        /// </summary>
        public const string SYIR01 = "SYIR01";

        /// <summary>
        /// SYIR02.
        /// </summary>
        public const string SYIR02 = "SYIR02";

        /// <summary>
        /// SYIR03.
        /// </summary>
        public const string SYIR03 = "SYIR03";

        /// <summary>
        /// SYIR04.
        /// </summary>
        public const string SYIR04 = "SYIR04";

        /// <summary>
        /// SYIR05.
        /// </summary>
        public const string SYIR05 = "SYIR05";

        /// <summary>
        /// SYVR03.
        /// </summary>
        public const string SYVR03 = "SYVR03";

        /// <summary>
        /// SYSOOR.
        /// </summary>
        public const string SYSOOR = "SYSOOR";

        /// <summary>
        /// SYPMDT.
        /// </summary>
        public const string SYPMDT = "SYPMDT";

        /// <summary>
        /// SYRSDT.
        /// </summary>
        public const string SYRSDT = "SYRSDT";

        /// <summary>
        /// SYRQSJ.
        /// </summary>
        public const string SYRQSJ = "SYRQSJ";

        /// <summary>
        /// SYPSTM.
        /// </summary>
        public const string SYPSTM = "SYPSTM";

        /// <summary>
        /// SYPDTT.
        /// </summary>
        public const string SYPDTT = "SYPDTT";

        /// <summary>
        /// SYOPTT.
        /// </summary>
        public const string SYOPTT = "SYOPTT";

        /// <summary>
        /// SYDRQT.
        /// </summary>
        public const string SYDRQT = "SYDRQT";

        /// <summary>
        /// SYADTM.
        /// </summary>
        public const string SYADTM = "SYADTM";

        /// <summary>
        /// SYADLJ.
        /// </summary>
        public const string SYADLJ = "SYADLJ";

        /// <summary>
        /// SYPBAN.
        /// </summary>
        public const string SYPBAN = "SYPBAN";

        /// <summary>
        /// SYITAN.
        /// </summary>
        public const string SYITAN = "SYITAN";

        /// <summary>
        /// SYFTAN.
        /// </summary>
        public const string SYFTAN = "SYFTAN";

        /// <summary>
        /// SYDVAN.
        /// </summary>
        public const string SYDVAN = "SYDVAN";

        /// <summary>
        /// SYDOC1.
        /// </summary>
        public const string SYDOC1 = "SYDOC1";

        /// <summary>
        /// SYDCT4.
        /// </summary>
        public const string SYDCT4 = "SYDCT4";

        /// <summary>
        /// SYCORD.
        /// </summary>
        public const string SYCORD = "SYCORD";

        /// <summary>
        /// SYBSC.
        /// </summary>
        public const string SYBSC = "SYBSC";

        /// <summary>
        /// SYBCRC.
        /// </summary>
        public const string SYBCRC = "SYBCRC";

        /// <summary>
        /// SYRSHT.
        /// </summary>
        public const string SYRSHT = "SYRSHT";

        /// <summary>
        /// SYHOLD.
        /// </summary>
        public const string SYHOLD = "SYHOLD";

        /// <summary>
        /// SYFUF1.
        /// </summary>
        public const string SYFUF1 = "SYFUF1";

        /// <summary>
        /// SYAUFT.
        /// </summary>
        public const string SYAUFT = "SYAUFT";

        /// <summary>
        /// SYAUFI.
        /// </summary>
        public const string SYAUFI = "SYAUFI";

        /// <summary>
        /// SYOPBO.
        /// </summary>
        public const string SYOPBO = "SYOPBO";

        /// <summary>
        /// SYOPTC.
        /// </summary>
        public const string SYOPTC = "SYOPTC";

        /// <summary>
        /// SYOPLD.
        /// </summary>
        public const string SYOPLD = "SYOPLD";

        /// <summary>
        /// SYOPBK.
        /// </summary>
        public const string SYOPBK = "SYOPBK";

        /// <summary>
        /// SYOPSB.
        /// </summary>
        public const string SYOPSB = "SYOPSB";

        /// <summary>
        /// SYOPPS.
        /// </summary>
        public const string SYOPPS = "SYOPPS";

        /// <summary>
        /// SYOPPL.
        /// </summary>
        public const string SYOPPL = "SYOPPL";

        /// <summary>
        /// SYOPMS.
        /// </summary>
        public const string SYOPMS = "SYOPMS";

        /// <summary>
        /// SYOPSS.
        /// </summary>
        public const string SYOPSS = "SYOPSS";

        /// <summary>
        /// SYOPBA.
        /// </summary>
        public const string SYOPBA = "SYOPBA";

        /// <summary>
        /// SYOPLL.
        /// </summary>
        public const string SYOPLL = "SYOPLL";

        /// <summary>
        /// SYPRAN8.
        /// </summary>
        public const string SYPRAN8 = "SYPRAN8";

        /// <summary>
        /// SYPRCIDLN.
        /// </summary>
        public const string SYPRCIDLN = "SYPRCIDLN";

        /// <summary>
        /// SYOPPID.
        /// </summary>
        public const string SYOPPID = "SYOPPID";

        /// <summary>
        /// SYCCIDLN.
        /// </summary>
        public const string SYCCIDLN = "SYCCIDLN";

        /// <summary>
        /// SYSDATTN.
        /// </summary>
        public const string SYSDATTN = "SYSDATTN";

        /// <summary>
        /// SYSHCCIDLN.
        /// </summary>
        public const string SYSHCCIDLN = "SYSHCCIDLN";

        /// <summary>
        /// SYSPATTN.
        /// </summary>
        public const string SYSPATTN = "SYSPATTN";

        /// <summary>
        /// SYOTIND.
        /// </summary>
        public const string SYOTIND = "SYOTIND";

        /// <summary>
        /// SYEXVAR0.
        /// </summary>
        public const string SYEXVAR0 = "SYEXVAR0";

        /// <summary>
        /// SYEXVAR1.
        /// </summary>
        public const string SYEXVAR1 = "SYEXVAR1";

        /// <summary>
        /// SYEXVAR4.
        /// </summary>
        public const string SYEXVAR4 = "SYEXVAR4";

        /// <summary>
        /// SYEXVAR5.
        /// </summary>
        public const string SYEXVAR5 = "SYEXVAR5";

        /// <summary>
        /// SYEXVAR6.
        /// </summary>
        public const string SYEXVAR6 = "SYEXVAR6";

        /// <summary>
        /// SYEXVAR7.
        /// </summary>
        public const string SYEXVAR7 = "SYEXVAR7";

        /// <summary>
        /// SYEXVAR12.
        /// </summary>
        public const string SYEXVAR12 = "SYEXVAR12";

        /// <summary>
        /// SYEXVAR13.
        /// </summary>
        public const string SYEXVAR13 = "SYEXVAR13";

        /// <summary>
        /// SYEXNM0.
        /// </summary>
        public const string SYEXNM0 = "SYEXNM0";

        /// <summary>
        /// SYEXNM1.
        /// </summary>
        public const string SYEXNM1 = "SYEXNM1";

        /// <summary>
        /// SYEXNM2.
        /// </summary>
        public const string SYEXNM2 = "SYEXNM2";

        /// <summary>
        /// SYEXNMP0.
        /// </summary>
        public const string SYEXNMP0 = "SYEXNMP0";

        /// <summary>
        /// SYEXNMP1.
        /// </summary>
        public const string SYEXNMP1 = "SYEXNMP1";

        /// <summary>
        /// SYEXNMP2.
        /// </summary>
        public const string SYEXNMP2 = "SYEXNMP2";

        /// <summary>
        /// SYEXDT0.
        /// </summary>
        public const string SYEXDT0 = "SYEXDT0";

        /// <summary>
        /// SYEXDT1.
        /// </summary>
        public const string SYEXDT1 = "SYEXDT1";

        /// <summary>
        /// SYEXDT2.
        /// </summary>
        public const string SYEXDT2 = "SYEXDT2";

        /// <summary>
        /// SYPOHP01.
        /// </summary>
        public const string SYPOHP01 = "SYPOHP01";

        /// <summary>
        /// SYPOHP02.
        /// </summary>
        public const string SYPOHP02 = "SYPOHP02";

        /// <summary>
        /// SYPOHP03.
        /// </summary>
        public const string SYPOHP03 = "SYPOHP03";

        /// <summary>
        /// SYPOHP04.
        /// </summary>
        public const string SYPOHP04 = "SYPOHP04";

        /// <summary>
        /// SYPOHP05.
        /// </summary>
        public const string SYPOHP05 = "SYPOHP05";

        /// <summary>
        /// SYPOHP06.
        /// </summary>
        public const string SYPOHP06 = "SYPOHP06";

        /// <summary>
        /// SYPOHP07.
        /// </summary>
        public const string SYPOHP07 = "SYPOHP07";

        /// <summary>
        /// SYPOHP08.
        /// </summary>
        public const string SYPOHP08 = "SYPOHP08";

        /// <summary>
        /// SYPOHP09.
        /// </summary>
        public const string SYPOHP09 = "SYPOHP09";

        /// <summary>
        /// SYPOHP10.
        /// </summary>
        public const string SYPOHP10 = "SYPOHP10";

        /// <summary>
        /// SYPOHP11.
        /// </summary>
        public const string SYPOHP11 = "SYPOHP11";

        /// <summary>
        /// SYPOHP12.
        /// </summary>
        public const string SYPOHP12 = "SYPOHP12";

        /// <summary>
        /// SYPOHC01.
        /// </summary>
        public const string SYPOHC01 = "SYPOHC01";

        /// <summary>
        /// SYPOHC02.
        /// </summary>
        public const string SYPOHC02 = "SYPOHC02";

        /// <summary>
        /// SYPOHC03.
        /// </summary>
        public const string SYPOHC03 = "SYPOHC03";

        /// <summary>
        /// SYPOHC04.
        /// </summary>
        public const string SYPOHC04 = "SYPOHC04";

        /// <summary>
        /// SYPOHC05.
        /// </summary>
        public const string SYPOHC05 = "SYPOHC05";

        /// <summary>
        /// SYPOHC06.
        /// </summary>
        public const string SYPOHC06 = "SYPOHC06";

        /// <summary>
        /// SYPOHC07.
        /// </summary>
        public const string SYPOHC07 = "SYPOHC07";

        /// <summary>
        /// SYPOHC08.
        /// </summary>
        public const string SYPOHC08 = "SYPOHC08";

        /// <summary>
        /// SYPOHC09.
        /// </summary>
        public const string SYPOHC09 = "SYPOHC09";

        /// <summary>
        /// SYPOHC10.
        /// </summary>
        public const string SYPOHC10 = "SYPOHC10";

        /// <summary>
        /// SYPOHC11.
        /// </summary>
        public const string SYPOHC11 = "SYPOHC11";

        /// <summary>
        /// SYPOHC12.
        /// </summary>
        public const string SYPOHC12 = "SYPOHC12";

        /// <summary>
        /// SYPOHD01.
        /// </summary>
        public const string SYPOHD01 = "SYPOHD01";

        /// <summary>
        /// SYPOHD02.
        /// </summary>
        public const string SYPOHD02 = "SYPOHD02";

        /// <summary>
        /// SYPOHAB01.
        /// </summary>
        public const string SYPOHAB01 = "SYPOHAB01";

        /// <summary>
        /// SYPOHAB02.
        /// </summary>
        public const string SYPOHAB02 = "SYPOHAB02";

        /// <summary>
        /// SYPOHP13.
        /// </summary>
        public const string SYPOHP13 = "SYPOHP13";

        /// <summary>
        /// SYPOHU01.
        /// </summary>
        public const string SYPOHU01 = "SYPOHU01";

        /// <summary>
        /// SYPOHU02.
        /// </summary>
        public const string SYPOHU02 = "SYPOHU02";

        /// <summary>
        /// SYRETI.
        /// </summary>
        public const string SYRETI = "SYRETI";

        /// <summary>
        /// SYCLASS01.
        /// </summary>
        public const string SYCLASS01 = "SYCLASS01";

        /// <summary>
        /// SYCLASS02.
        /// </summary>
        public const string SYCLASS02 = "SYCLASS02";

        /// <summary>
        /// SYCLASS03.
        /// </summary>
        public const string SYCLASS03 = "SYCLASS03";

        /// <summary>
        /// SYCLASS04.
        /// </summary>
        public const string SYCLASS04 = "SYCLASS04";

        /// <summary>
        /// SYCLASS05.
        /// </summary>
        public const string SYCLASS05 = "SYCLASS05";

        /// <summary>
        /// SYGAN8.
        /// </summary>
        public const string SYGAN8 = "SYGAN8";

        /// <summary>
        /// SYGSHAN.
        /// </summary>
        public const string SYGSHAN = "SYGSHAN";

        /// <summary>
        /// SYGPA8.
        /// </summary>
        public const string SYGPA8 = "SYGPA8";

        /// <summary>
        /// SYGCARS.
        /// </summary>
        public const string SYGCARS = "SYGCARS";

        /// <summary>
        /// SYGPBAN.
        /// </summary>
        public const string SYGPBAN = "SYGPBAN";

        /// <summary>
        /// SYGITAN.
        /// </summary>
        public const string SYGITAN = "SYGITAN";

        /// <summary>
        /// SYGFTAN.
        /// </summary>
        public const string SYGFTAN = "SYGFTAN";

        /// <summary>
        /// SYGDVAN.
        /// </summary>
        public const string SYGDVAN = "SYGDVAN";

        /// <summary>
        /// SYGPRAN8.
        /// </summary>
        public const string SYGPRAN8 = "SYGPRAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F47011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDTY", "SYEDTY", JdeDataType.String, 2),
        new JdeField("SYEDSQ", "SYEDSQ", JdeDataType.Numeric),
        new JdeField("SYEKCO", "SYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SYEDOC", "SYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric),
        new JdeField("SYEDST", "SYEDST", JdeDataType.String, 12),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYEDER", "SYEDER", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYOFRQ", "SYOFRQ", JdeDataType.String, 2),
        new JdeField("SYNXDJ", "SYNXDJ", JdeDataType.Numeric),
        new JdeField("SYSSDJ", "SYSSDJ", JdeDataType.Numeric),
        new JdeField("SYTPUR", "SYTPUR", JdeDataType.String, 4),
        new JdeField("SYKCOO", "SYKCOO", JdeDataType.String, 10),
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYDCTO", "SYDCTO", JdeDataType.String, 4),
        new JdeField("SYSFXO", "SYSFXO", JdeDataType.String, 6),
        new JdeField("SYMCU", "SYMCU", JdeDataType.String, 24),
        new JdeField("SYCO", "SYCO", JdeDataType.String, 10),
        new JdeField("SYOKCO", "SYOKCO", JdeDataType.String, 10),
        new JdeField("SYOORN", "SYOORN", JdeDataType.String, 16),
        new JdeField("SYOCTO", "SYOCTO", JdeDataType.String, 4),
        new JdeField("SYRKCO", "SYRKCO", JdeDataType.String, 10),
        new JdeField("SYRORN", "SYRORN", JdeDataType.String, 16),
        new JdeField("SYRCTO", "SYRCTO", JdeDataType.String, 4),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYSHAN", "SYSHAN", JdeDataType.Numeric),
        new JdeField("SYPA8", "SYPA8", JdeDataType.Numeric),
        new JdeField("SYDRQJ", "SYDRQJ", JdeDataType.Numeric),
        new JdeField("SYTRDJ", "SYTRDJ", JdeDataType.Numeric),
        new JdeField("SYPDDJ", "SYPDDJ", JdeDataType.Numeric),
        new JdeField("SYOPDJ", "SYOPDJ", JdeDataType.Numeric),
        new JdeField("SYADDJ", "SYADDJ", JdeDataType.Numeric),
        new JdeField("SYCNDJ", "SYCNDJ", JdeDataType.Numeric),
        new JdeField("SYPEFJ", "SYPEFJ", JdeDataType.Numeric),
        new JdeField("SYPPDJ", "SYPPDJ", JdeDataType.Numeric),
        new JdeField("SYPSDJ", "SYPSDJ", JdeDataType.Numeric),
        new JdeField("SYVR01", "SYVR01", JdeDataType.String, 50),
        new JdeField("SYVR02", "SYVR02", JdeDataType.String, 50),
        new JdeField("SYDEL1", "SYDEL1", JdeDataType.String, 60),
        new JdeField("SYDEL2", "SYDEL2", JdeDataType.String, 60),
        new JdeField("SYINMG", "SYINMG", JdeDataType.String, 20),
        new JdeField("SYPTC", "SYPTC", JdeDataType.String, 6),
        new JdeField("SYRYIN", "SYRYIN", JdeDataType.String, 2),
        new JdeField("SYASN", "SYASN", JdeDataType.String, 16),
        new JdeField("SYPRGP", "SYPRGP", JdeDataType.String, 16),
        new JdeField("SYTRDC", "SYTRDC", JdeDataType.Numeric),
        new JdeField("SYPCRT", "SYPCRT", JdeDataType.Numeric),
        new JdeField("SYTXA1", "SYTXA1", JdeDataType.String, 20),
        new JdeField("SYEXR1", "SYEXR1", JdeDataType.String, 4),
        new JdeField("SYTXCT", "SYTXCT", JdeDataType.String, 40),
        new JdeField("SYATXT", "SYATXT", JdeDataType.String, 2),
        new JdeField("SYPRIO", "SYPRIO", JdeDataType.String, 2),
        new JdeField("SYBACK", "SYBACK", JdeDataType.String, 2),
        new JdeField("SYSBAL", "SYSBAL", JdeDataType.String, 2),
        new JdeField("SYNTR", "SYNTR", JdeDataType.String, 4),
        new JdeField("SYANBY", "SYANBY", JdeDataType.Numeric),
        new JdeField("SYCARS", "SYCARS", JdeDataType.Numeric),
        new JdeField("SYMOT", "SYMOT", JdeDataType.String, 6),
        new JdeField("SYCOT", "SYCOT", JdeDataType.String, 6),
        new JdeField("SYROUT", "SYROUT", JdeDataType.String, 6),
        new JdeField("SYSTOP", "SYSTOP", JdeDataType.String, 6),
        new JdeField("SYZON", "SYZON", JdeDataType.String, 6),
        new JdeField("SYCNID", "SYCNID", JdeDataType.String, 40),
        new JdeField("SYFRTH", "SYFRTH", JdeDataType.String, 6),
        new JdeField("SYAFT", "SYAFT", JdeDataType.String, 2),
        new JdeField("SYRCD", "SYRCD", JdeDataType.String, 6),
        new JdeField("SYOTOT", "SYOTOT", JdeDataType.Numeric),
        new JdeField("SYTOTC", "SYTOTC", JdeDataType.Numeric),
        new JdeField("SYWUMD", "SYWUMD", JdeDataType.String, 4),
        new JdeField("SYVUMD", "SYVUMD", JdeDataType.String, 4),
        new JdeField("SYAUTN", "SYAUTN", JdeDataType.String, 20),
        new JdeField("SYCACT", "SYCACT", JdeDataType.String, 50),
        new JdeField("SYCEXP", "SYCEXP", JdeDataType.Numeric),
        new JdeField("SYCRMD", "SYCRMD", JdeDataType.String, 2),
        new JdeField("SYCRRM", "SYCRRM", JdeDataType.String, 2),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRR", "SYCRR", JdeDataType.Numeric),
        new JdeField("SYLNGP", "SYLNGP", JdeDataType.String, 4),
        new JdeField("SYFAP", "SYFAP", JdeDataType.Numeric),
        new JdeField("SYFCST", "SYFCST", JdeDataType.Numeric),
        new JdeField("SYORBY", "SYORBY", JdeDataType.String, 20),
        new JdeField("SYTKBY", "SYTKBY", JdeDataType.String, 20),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYIR01", "SYIR01", JdeDataType.String, 60),
        new JdeField("SYIR02", "SYIR02", JdeDataType.String, 60),
        new JdeField("SYIR03", "SYIR03", JdeDataType.String, 60),
        new JdeField("SYIR04", "SYIR04", JdeDataType.String, 60),
        new JdeField("SYIR05", "SYIR05", JdeDataType.String, 60),
        new JdeField("SYVR03", "SYVR03", JdeDataType.String, 50),
        new JdeField("SYSOOR", "SYSOOR", JdeDataType.Numeric),
        new JdeField("SYPMDT", "SYPMDT", JdeDataType.Numeric),
        new JdeField("SYRSDT", "SYRSDT", JdeDataType.Numeric),
        new JdeField("SYRQSJ", "SYRQSJ", JdeDataType.Numeric),
        new JdeField("SYPSTM", "SYPSTM", JdeDataType.Numeric),
        new JdeField("SYPDTT", "SYPDTT", JdeDataType.Numeric),
        new JdeField("SYOPTT", "SYOPTT", JdeDataType.Numeric),
        new JdeField("SYDRQT", "SYDRQT", JdeDataType.Numeric),
        new JdeField("SYADTM", "SYADTM", JdeDataType.Numeric),
        new JdeField("SYADLJ", "SYADLJ", JdeDataType.Numeric),
        new JdeField("SYPBAN", "SYPBAN", JdeDataType.Numeric),
        new JdeField("SYITAN", "SYITAN", JdeDataType.Numeric),
        new JdeField("SYFTAN", "SYFTAN", JdeDataType.Numeric),
        new JdeField("SYDVAN", "SYDVAN", JdeDataType.Numeric),
        new JdeField("SYDOC1", "SYDOC1", JdeDataType.Numeric),
        new JdeField("SYDCT4", "SYDCT4", JdeDataType.String, 4),
        new JdeField("SYCORD", "SYCORD", JdeDataType.Numeric),
        new JdeField("SYBSC", "SYBSC", JdeDataType.String, 20),
        new JdeField("SYBCRC", "SYBCRC", JdeDataType.String, 6),
        new JdeField("SYRSHT", "SYRSHT", JdeDataType.Numeric),
        new JdeField("SYHOLD", "SYHOLD", JdeDataType.String, 4),
        new JdeField("SYFUF1", "SYFUF1", JdeDataType.String, 2),
        new JdeField("SYAUFT", "SYAUFT", JdeDataType.String, 2),
        new JdeField("SYAUFI", "SYAUFI", JdeDataType.String, 2),
        new JdeField("SYOPBO", "SYOPBO", JdeDataType.String, 60),
        new JdeField("SYOPTC", "SYOPTC", JdeDataType.Numeric),
        new JdeField("SYOPLD", "SYOPLD", JdeDataType.Numeric),
        new JdeField("SYOPBK", "SYOPBK", JdeDataType.Numeric),
        new JdeField("SYOPSB", "SYOPSB", JdeDataType.Numeric),
        new JdeField("SYOPPS", "SYOPPS", JdeDataType.String, 60),
        new JdeField("SYOPPL", "SYOPPL", JdeDataType.String, 2),
        new JdeField("SYOPMS", "SYOPMS", JdeDataType.String, 2),
        new JdeField("SYOPSS", "SYOPSS", JdeDataType.String, 2),
        new JdeField("SYOPBA", "SYOPBA", JdeDataType.String, 2),
        new JdeField("SYOPLL", "SYOPLL", JdeDataType.String, 2),
        new JdeField("SYPRAN8", "SYPRAN8", JdeDataType.Numeric),
        new JdeField("SYPRCIDLN", "SYPRCIDLN", JdeDataType.Numeric),
        new JdeField("SYOPPID", "SYOPPID", JdeDataType.Numeric),
        new JdeField("SYCCIDLN", "SYCCIDLN", JdeDataType.Numeric),
        new JdeField("SYSDATTN", "SYSDATTN", JdeDataType.String, 100),
        new JdeField("SYSHCCIDLN", "SYSHCCIDLN", JdeDataType.Numeric),
        new JdeField("SYSPATTN", "SYSPATTN", JdeDataType.String, 100),
        new JdeField("SYOTIND", "SYOTIND", JdeDataType.String, 2),
        new JdeField("SYEXVAR0", "SYEXVAR0", JdeDataType.String, 510),
        new JdeField("SYEXVAR1", "SYEXVAR1", JdeDataType.String, 510),
        new JdeField("SYEXVAR4", "SYEXVAR4", JdeDataType.String, 100),
        new JdeField("SYEXVAR5", "SYEXVAR5", JdeDataType.String, 100),
        new JdeField("SYEXVAR6", "SYEXVAR6", JdeDataType.String, 100),
        new JdeField("SYEXVAR7", "SYEXVAR7", JdeDataType.String, 100),
        new JdeField("SYEXVAR12", "SYEXVAR12", JdeDataType.String, 50),
        new JdeField("SYEXVAR13", "SYEXVAR13", JdeDataType.String, 50),
        new JdeField("SYEXNM0", "SYEXNM0", JdeDataType.Numeric),
        new JdeField("SYEXNM1", "SYEXNM1", JdeDataType.Numeric),
        new JdeField("SYEXNM2", "SYEXNM2", JdeDataType.Numeric),
        new JdeField("SYEXNMP0", "SYEXNMP0", JdeDataType.Numeric),
        new JdeField("SYEXNMP1", "SYEXNMP1", JdeDataType.Numeric),
        new JdeField("SYEXNMP2", "SYEXNMP2", JdeDataType.Numeric),
        new JdeField("SYEXDT0", "SYEXDT0", JdeDataType.Date),
        new JdeField("SYEXDT1", "SYEXDT1", JdeDataType.Date),
        new JdeField("SYEXDT2", "SYEXDT2", JdeDataType.Date),
        new JdeField("SYPOHP01", "SYPOHP01", JdeDataType.String, 2),
        new JdeField("SYPOHP02", "SYPOHP02", JdeDataType.String, 2),
        new JdeField("SYPOHP03", "SYPOHP03", JdeDataType.String, 2),
        new JdeField("SYPOHP04", "SYPOHP04", JdeDataType.String, 2),
        new JdeField("SYPOHP05", "SYPOHP05", JdeDataType.String, 2),
        new JdeField("SYPOHP06", "SYPOHP06", JdeDataType.String, 2),
        new JdeField("SYPOHP07", "SYPOHP07", JdeDataType.String, 2),
        new JdeField("SYPOHP08", "SYPOHP08", JdeDataType.String, 2),
        new JdeField("SYPOHP09", "SYPOHP09", JdeDataType.String, 2),
        new JdeField("SYPOHP10", "SYPOHP10", JdeDataType.String, 2),
        new JdeField("SYPOHP11", "SYPOHP11", JdeDataType.String, 2),
        new JdeField("SYPOHP12", "SYPOHP12", JdeDataType.String, 2),
        new JdeField("SYPOHC01", "SYPOHC01", JdeDataType.String, 6),
        new JdeField("SYPOHC02", "SYPOHC02", JdeDataType.String, 6),
        new JdeField("SYPOHC03", "SYPOHC03", JdeDataType.String, 6),
        new JdeField("SYPOHC04", "SYPOHC04", JdeDataType.String, 6),
        new JdeField("SYPOHC05", "SYPOHC05", JdeDataType.String, 6),
        new JdeField("SYPOHC06", "SYPOHC06", JdeDataType.String, 6),
        new JdeField("SYPOHC07", "SYPOHC07", JdeDataType.String, 20),
        new JdeField("SYPOHC08", "SYPOHC08", JdeDataType.String, 20),
        new JdeField("SYPOHC09", "SYPOHC09", JdeDataType.String, 20),
        new JdeField("SYPOHC10", "SYPOHC10", JdeDataType.String, 20),
        new JdeField("SYPOHC11", "SYPOHC11", JdeDataType.String, 20),
        new JdeField("SYPOHC12", "SYPOHC12", JdeDataType.String, 20),
        new JdeField("SYPOHD01", "SYPOHD01", JdeDataType.Numeric),
        new JdeField("SYPOHD02", "SYPOHD02", JdeDataType.Numeric),
        new JdeField("SYPOHAB01", "SYPOHAB01", JdeDataType.Numeric),
        new JdeField("SYPOHAB02", "SYPOHAB02", JdeDataType.Numeric),
        new JdeField("SYPOHP13", "SYPOHP13", JdeDataType.String, 60),
        new JdeField("SYPOHU01", "SYPOHU01", JdeDataType.Date),
        new JdeField("SYPOHU02", "SYPOHU02", JdeDataType.Date),
        new JdeField("SYRETI", "SYRETI", JdeDataType.String, 2),
        new JdeField("SYCLASS01", "SYCLASS01", JdeDataType.String, 6),
        new JdeField("SYCLASS02", "SYCLASS02", JdeDataType.String, 6),
        new JdeField("SYCLASS03", "SYCLASS03", JdeDataType.String, 6),
        new JdeField("SYCLASS04", "SYCLASS04", JdeDataType.String, 6),
        new JdeField("SYCLASS05", "SYCLASS05", JdeDataType.String, 6),
        new JdeField("SYGAN8", "SYGAN8", JdeDataType.Numeric),
        new JdeField("SYGSHAN", "SYGSHAN", JdeDataType.Numeric),
        new JdeField("SYGPA8", "SYGPA8", JdeDataType.Numeric),
        new JdeField("SYGCARS", "SYGCARS", JdeDataType.Numeric),
        new JdeField("SYGPBAN", "SYGPBAN", JdeDataType.Numeric),
        new JdeField("SYGITAN", "SYGITAN", JdeDataType.Numeric),
        new JdeField("SYGFTAN", "SYGFTAN", JdeDataType.Numeric),
        new JdeField("SYGDVAN", "SYGDVAN", JdeDataType.Numeric),
        new JdeField("SYGPRAN8", "SYGPRAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47011_0", "Primary Key on SYEDOC, SYEDCT, SYEKCO", new[] { "SYEDOC", "SYEDCT", "SYEKCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F47011_2", "Index on SYEKCO, SYEDCT, SYEDBT", new[] { "SYEKCO", "SYEDCT", "SYEDBT" })
    };
}
