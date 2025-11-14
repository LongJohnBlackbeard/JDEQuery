using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49299 - .
/// </summary>
public class F49299 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UDDOCO.
        /// </summary>
        public const string UDDOCO = "UDDOCO";

        /// <summary>
        /// UDDCTO.
        /// </summary>
        public const string UDDCTO = "UDDCTO";

        /// <summary>
        /// UDKCOO.
        /// </summary>
        public const string UDKCOO = "UDKCOO";

        /// <summary>
        /// UDLNID.
        /// </summary>
        public const string UDLNID = "UDLNID";

        /// <summary>
        /// UDVMCU.
        /// </summary>
        public const string UDVMCU = "UDVMCU";

        /// <summary>
        /// UDTRP.
        /// </summary>
        public const string UDTRP = "UDTRP";

        /// <summary>
        /// UDLOAD.
        /// </summary>
        public const string UDLOAD = "UDLOAD";

        /// <summary>
        /// UDDSGP.
        /// </summary>
        public const string UDDSGP = "UDDSGP";

        /// <summary>
        /// UDBPFG.
        /// </summary>
        public const string UDBPFG = "UDBPFG";

        /// <summary>
        /// UDDSTN.
        /// </summary>
        public const string UDDSTN = "UDDSTN";

        /// <summary>
        /// UDUM.
        /// </summary>
        public const string UDUM = "UDUM";

        /// <summary>
        /// UDDEFF.
        /// </summary>
        public const string UDDEFF = "UDDEFF";

        /// <summary>
        /// UDDUNC.
        /// </summary>
        public const string UDDUNC = "UDDUNC";

        /// <summary>
        /// UDFDUC.
        /// </summary>
        public const string UDFDUC = "UDFDUC";

        /// <summary>
        /// UDDREV.
        /// </summary>
        public const string UDDREV = "UDDREV";

        /// <summary>
        /// UDFDRV.
        /// </summary>
        public const string UDFDRV = "UDFDRV";

        /// <summary>
        /// UDANUM.
        /// </summary>
        public const string UDANUM = "UDANUM";

        /// <summary>
        /// UDSIDT.
        /// </summary>
        public const string UDSIDT = "UDSIDT";

        /// <summary>
        /// UDINCY.
        /// </summary>
        public const string UDINCY = "UDINCY";

        /// <summary>
        /// UDLDDT.
        /// </summary>
        public const string UDLDDT = "UDLDDT";

        /// <summary>
        /// UDLDTM.
        /// </summary>
        public const string UDLDTM = "UDLDTM";

        /// <summary>
        /// UDDCDT.
        /// </summary>
        public const string UDDCDT = "UDDCDT";

        /// <summary>
        /// UDPCQY.
        /// </summary>
        public const string UDPCQY = "UDPCQY";

        /// <summary>
        /// UDUOMC.
        /// </summary>
        public const string UDUOMC = "UDUOMC";

        /// <summary>
        /// UDTEMP.
        /// </summary>
        public const string UDTEMP = "UDTEMP";

        /// <summary>
        /// UDSTPU.
        /// </summary>
        public const string UDSTPU = "UDSTPU";

        /// <summary>
        /// UDDNTY.
        /// </summary>
        public const string UDDNTY = "UDDNTY";

        /// <summary>
        /// UDDNTP.
        /// </summary>
        public const string UDDNTP = "UDDNTP";

        /// <summary>
        /// UDDETP.
        /// </summary>
        public const string UDDETP = "UDDETP";

        /// <summary>
        /// UDDTPU.
        /// </summary>
        public const string UDDTPU = "UDDTPU";

        /// <summary>
        /// UDVCF.
        /// </summary>
        public const string UDVCF = "UDVCF";

        /// <summary>
        /// UDPRAS.
        /// </summary>
        public const string UDPRAS = "UDPRAS";

        /// <summary>
        /// UDCP01.
        /// </summary>
        public const string UDCP01 = "UDCP01";

        /// <summary>
        /// UDIQTY.
        /// </summary>
        public const string UDIQTY = "UDIQTY";

        /// <summary>
        /// UDSTUM.
        /// </summary>
        public const string UDSTUM = "UDSTUM";

        /// <summary>
        /// UDBUM6.
        /// </summary>
        public const string UDBUM6 = "UDBUM6";

        /// <summary>
        /// UDAMBR.
        /// </summary>
        public const string UDAMBR = "UDAMBR";

        /// <summary>
        /// UDBUM3.
        /// </summary>
        public const string UDBUM3 = "UDBUM3";

        /// <summary>
        /// UDWGTR.
        /// </summary>
        public const string UDWGTR = "UDWGTR";

        /// <summary>
        /// UDBUM5.
        /// </summary>
        public const string UDBUM5 = "UDBUM5";

        /// <summary>
        /// UDFRTV.
        /// </summary>
        public const string UDFRTV = "UDFRTV";

        /// <summary>
        /// UDFRTD.
        /// </summary>
        public const string UDFRTD = "UDFRTD";

        /// <summary>
        /// UDFRCC.
        /// </summary>
        public const string UDFRCC = "UDFRCC";

        /// <summary>
        /// UDFRVC.
        /// </summary>
        public const string UDFRVC = "UDFRVC";

        /// <summary>
        /// UDPVEH.
        /// </summary>
        public const string UDPVEH = "UDPVEH";

        /// <summary>
        /// UDRLNO.
        /// </summary>
        public const string UDRLNO = "UDRLNO";

        /// <summary>
        /// UDMCUR.
        /// </summary>
        public const string UDMCUR = "UDMCUR";

        /// <summary>
        /// UDFLTN.
        /// </summary>
        public const string UDFLTN = "UDFLTN";

        /// <summary>
        /// UDDSNN.
        /// </summary>
        public const string UDDSNN = "UDDSNN";

        /// <summary>
        /// UDARCT.
        /// </summary>
        public const string UDARCT = "UDARCT";

        /// <summary>
        /// UDSORG.
        /// </summary>
        public const string UDSORG = "UDSORG";

        /// <summary>
        /// UDELTM.
        /// </summary>
        public const string UDELTM = "UDELTM";

        /// <summary>
        /// UDPTNR.
        /// </summary>
        public const string UDPTNR = "UDPTNR";

        /// <summary>
        /// UDIAN8.
        /// </summary>
        public const string UDIAN8 = "UDIAN8";

        /// <summary>
        /// UDPTC.
        /// </summary>
        public const string UDPTC = "UDPTC";

        /// <summary>
        /// UDDOC.
        /// </summary>
        public const string UDDOC = "UDDOC";

        /// <summary>
        /// UDDCT.
        /// </summary>
        public const string UDDCT = "UDDCT";

        /// <summary>
        /// UDKCO.
        /// </summary>
        public const string UDKCO = "UDKCO";

        /// <summary>
        /// UDCRR.
        /// </summary>
        public const string UDCRR = "UDCRR";

        /// <summary>
        /// UDCRCD.
        /// </summary>
        public const string UDCRCD = "UDCRCD";

        /// <summary>
        /// UDTXA1.
        /// </summary>
        public const string UDTXA1 = "UDTXA1";

        /// <summary>
        /// UDEXR1.
        /// </summary>
        public const string UDEXR1 = "UDEXR1";

        /// <summary>
        /// UDFRDM.
        /// </summary>
        public const string UDFRDM = "UDFRDM";

        /// <summary>
        /// UDFUPT.
        /// </summary>
        public const string UDFUPT = "UDFUPT";

        /// <summary>
        /// UDRINO.
        /// </summary>
        public const string UDRINO = "UDRINO";

        /// <summary>
        /// UDGLOC.
        /// </summary>
        public const string UDGLOC = "UDGLOC";

        /// <summary>
        /// UDAUTA.
        /// </summary>
        public const string UDAUTA = "UDAUTA";

        /// <summary>
        /// UDALPH.
        /// </summary>
        public const string UDALPH = "UDALPH";

        /// <summary>
        /// UDMET1.
        /// </summary>
        public const string UDMET1 = "UDMET1";

        /// <summary>
        /// UDOPN1.
        /// </summary>
        public const string UDOPN1 = "UDOPN1";

        /// <summary>
        /// UDPNR1.
        /// </summary>
        public const string UDPNR1 = "UDPNR1";

        /// <summary>
        /// UDMET2.
        /// </summary>
        public const string UDMET2 = "UDMET2";

        /// <summary>
        /// UDOPN2.
        /// </summary>
        public const string UDOPN2 = "UDOPN2";

        /// <summary>
        /// UDPNR2.
        /// </summary>
        public const string UDPNR2 = "UDPNR2";

        /// <summary>
        /// UDMET3.
        /// </summary>
        public const string UDMET3 = "UDMET3";

        /// <summary>
        /// UDOPN3.
        /// </summary>
        public const string UDOPN3 = "UDOPN3";

        /// <summary>
        /// UDPNR3.
        /// </summary>
        public const string UDPNR3 = "UDPNR3";

        /// <summary>
        /// UDARDT.
        /// </summary>
        public const string UDARDT = "UDARDT";

        /// <summary>
        /// UDARTM.
        /// </summary>
        public const string UDARTM = "UDARTM";

        /// <summary>
        /// UDDPDT.
        /// </summary>
        public const string UDDPDT = "UDDPDT";

        /// <summary>
        /// UDDETM.
        /// </summary>
        public const string UDDETM = "UDDETM";

        /// <summary>
        /// UDDSTJ.
        /// </summary>
        public const string UDDSTJ = "UDDSTJ";

        /// <summary>
        /// UDSTM.
        /// </summary>
        public const string UDSTM = "UDSTM";

        /// <summary>
        /// UDEND.
        /// </summary>
        public const string UDEND = "UDEND";

        /// <summary>
        /// UDETM.
        /// </summary>
        public const string UDETM = "UDETM";

        /// <summary>
        /// UDTV01.
        /// </summary>
        public const string UDTV01 = "UDTV01";

        /// <summary>
        /// UDTV02.
        /// </summary>
        public const string UDTV02 = "UDTV02";

        /// <summary>
        /// UDTV03.
        /// </summary>
        public const string UDTV03 = "UDTV03";

        /// <summary>
        /// UDTV04.
        /// </summary>
        public const string UDTV04 = "UDTV04";

        /// <summary>
        /// UDTV05.
        /// </summary>
        public const string UDTV05 = "UDTV05";

        /// <summary>
        /// UDTVCD.
        /// </summary>
        public const string UDTVCD = "UDTVCD";

        /// <summary>
        /// UDTVQT.
        /// </summary>
        public const string UDTVQT = "UDTVQT";

        /// <summary>
        /// UDTVDT.
        /// </summary>
        public const string UDTVDT = "UDTVDT";

        /// <summary>
        /// UDTVUM.
        /// </summary>
        public const string UDTVUM = "UDTVUM";

        /// <summary>
        /// UDUSER.
        /// </summary>
        public const string UDUSER = "UDUSER";

        /// <summary>
        /// UDPID.
        /// </summary>
        public const string UDPID = "UDPID";

        /// <summary>
        /// UDJOBN.
        /// </summary>
        public const string UDJOBN = "UDJOBN";

        /// <summary>
        /// UDUPMJ.
        /// </summary>
        public const string UDUPMJ = "UDUPMJ";

        /// <summary>
        /// UDTDAY.
        /// </summary>
        public const string UDTDAY = "UDTDAY";

        /// <summary>
        /// UDSBCK.
        /// </summary>
        public const string UDSBCK = "UDSBCK";

        /// <summary>
        /// UDEDCK.
        /// </summary>
        public const string UDEDCK = "UDEDCK";

        /// <summary>
        /// UDCMDM.
        /// </summary>
        public const string UDCMDM = "UDCMDM";

        /// <summary>
        /// UDBBCK.
        /// </summary>
        public const string UDBBCK = "UDBBCK";

        /// <summary>
        /// UDRQSJ.
        /// </summary>
        public const string UDRQSJ = "UDRQSJ";

        /// <summary>
        /// UDPSDJ.
        /// </summary>
        public const string UDPSDJ = "UDPSDJ";

        /// <summary>
        /// UDADLJ.
        /// </summary>
        public const string UDADLJ = "UDADLJ";

        /// <summary>
        /// UDSUB.
        /// </summary>
        public const string UDSUB = "UDSUB";

        /// <summary>
        /// UDSTTS.
        /// </summary>
        public const string UDSTTS = "UDSTTS";

        /// <summary>
        /// UDRATT.
        /// </summary>
        public const string UDRATT = "UDRATT";

        /// <summary>
        /// UDFUF1.
        /// </summary>
        public const string UDFUF1 = "UDFUF1";

        /// <summary>
        /// UDFRTC.
        /// </summary>
        public const string UDFRTC = "UDFRTC";

        /// <summary>
        /// UDFRAT.
        /// </summary>
        public const string UDFRAT = "UDFRAT";

        /// <summary>
        /// UDAFT.
        /// </summary>
        public const string UDAFT = "UDAFT";

        /// <summary>
        /// UDOMCU.
        /// </summary>
        public const string UDOMCU = "UDOMCU";

        /// <summary>
        /// UDOBJ.
        /// </summary>
        public const string UDOBJ = "UDOBJ";

        /// <summary>
        /// UDLT.
        /// </summary>
        public const string UDLT = "UDLT";

        /// <summary>
        /// UDFAPP.
        /// </summary>
        public const string UDFAPP = "UDFAPP";

        /// <summary>
        /// UDDSPR.
        /// </summary>
        public const string UDDSPR = "UDDSPR";

        /// <summary>
        /// UDDSFT.
        /// </summary>
        public const string UDDSFT = "UDDSFT";

        /// <summary>
        /// UDDMT1.
        /// </summary>
        public const string UDDMT1 = "UDDMT1";

        /// <summary>
        /// UDDMS1.
        /// </summary>
        public const string UDDMS1 = "UDDMS1";

        /// <summary>
        /// UDCOT.
        /// </summary>
        public const string UDCOT = "UDCOT";

        /// <summary>
        /// UDCMGL.
        /// </summary>
        public const string UDCMGL = "UDCMGL";

        /// <summary>
        /// UDBALU.
        /// </summary>
        public const string UDBALU = "UDBALU";

        /// <summary>
        /// UDAPOT.
        /// </summary>
        public const string UDAPOT = "UDAPOT";

        /// <summary>
        /// UDACGD.
        /// </summary>
        public const string UDACGD = "UDACGD";

        /// <summary>
        /// UDANI.
        /// </summary>
        public const string UDANI = "UDANI";

        /// <summary>
        /// UDAID.
        /// </summary>
        public const string UDAID = "UDAID";

        /// <summary>
        /// UDOPOL.
        /// </summary>
        public const string UDOPOL = "UDOPOL";

        /// <summary>
        /// UDOPBO.
        /// </summary>
        public const string UDOPBO = "UDOPBO";

        /// <summary>
        /// UDOPID.
        /// </summary>
        public const string UDOPID = "UDOPID";

        /// <summary>
        /// UDOPCS.
        /// </summary>
        public const string UDOPCS = "UDOPCS";

        /// <summary>
        /// UDOPLL.
        /// </summary>
        public const string UDOPLL = "UDOPLL";

        /// <summary>
        /// UDOPMS.
        /// </summary>
        public const string UDOPMS = "UDOPMS";

        /// <summary>
        /// UDOPSS.
        /// </summary>
        public const string UDOPSS = "UDOPSS";

        /// <summary>
        /// UDOPBA.
        /// </summary>
        public const string UDOPBA = "UDOPBA";

        /// <summary>
        /// UDFXSR.
        /// </summary>
        public const string UDFXSR = "UDFXSR";
    }

    /// <inheritdoc />
    public override string TableName => "F49299";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UDDOCO", "UDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("UDDCTO", "UDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("UDKCOO", "UDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("UDLNID", "UDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("UDVMCU", "UDVMCU", JdeDataType.String, 24),
        new JdeField("UDTRP", "UDTRP", JdeDataType.Numeric),
        new JdeField("UDLOAD", "UDLOAD", JdeDataType.Numeric),
        new JdeField("UDDSGP", "UDDSGP", JdeDataType.String, 6),
        new JdeField("UDBPFG", "UDBPFG", JdeDataType.String, 2),
        new JdeField("UDDSTN", "UDDSTN", JdeDataType.Numeric),
        new JdeField("UDUM", "UDUM", JdeDataType.String, 4),
        new JdeField("UDDEFF", "UDDEFF", JdeDataType.String, 2),
        new JdeField("UDDUNC", "UDDUNC", JdeDataType.Numeric),
        new JdeField("UDFDUC", "UDFDUC", JdeDataType.Numeric),
        new JdeField("UDDREV", "UDDREV", JdeDataType.Numeric),
        new JdeField("UDFDRV", "UDFDRV", JdeDataType.Numeric),
        new JdeField("UDANUM", "UDANUM", JdeDataType.Numeric),
        new JdeField("UDSIDT", "UDSIDT", JdeDataType.Numeric),
        new JdeField("UDINCY", "UDINCY", JdeDataType.String, 6),
        new JdeField("UDLDDT", "UDLDDT", JdeDataType.Numeric),
        new JdeField("UDLDTM", "UDLDTM", JdeDataType.Numeric),
        new JdeField("UDDCDT", "UDDCDT", JdeDataType.Numeric),
        new JdeField("UDPCQY", "UDPCQY", JdeDataType.Numeric),
        new JdeField("UDUOMC", "UDUOMC", JdeDataType.String, 4),
        new JdeField("UDTEMP", "UDTEMP", JdeDataType.Numeric),
        new JdeField("UDSTPU", "UDSTPU", JdeDataType.String, 2),
        new JdeField("UDDNTY", "UDDNTY", JdeDataType.Numeric),
        new JdeField("UDDNTP", "UDDNTP", JdeDataType.String, 2),
        new JdeField("UDDETP", "UDDETP", JdeDataType.Numeric),
        new JdeField("UDDTPU", "UDDTPU", JdeDataType.String, 2),
        new JdeField("UDVCF", "UDVCF", JdeDataType.Numeric),
        new JdeField("UDPRAS", "UDPRAS", JdeDataType.String, 2),
        new JdeField("UDCP01", "UDCP01", JdeDataType.String, 2),
        new JdeField("UDIQTY", "UDIQTY", JdeDataType.Numeric),
        new JdeField("UDSTUM", "UDSTUM", JdeDataType.Numeric),
        new JdeField("UDBUM6", "UDBUM6", JdeDataType.String, 4),
        new JdeField("UDAMBR", "UDAMBR", JdeDataType.Numeric),
        new JdeField("UDBUM3", "UDBUM3", JdeDataType.String, 4),
        new JdeField("UDWGTR", "UDWGTR", JdeDataType.Numeric),
        new JdeField("UDBUM5", "UDBUM5", JdeDataType.String, 4),
        new JdeField("UDFRTV", "UDFRTV", JdeDataType.String, 2),
        new JdeField("UDFRTD", "UDFRTD", JdeDataType.String, 2),
        new JdeField("UDFRCC", "UDFRCC", JdeDataType.Numeric),
        new JdeField("UDFRVC", "UDFRVC", JdeDataType.Numeric),
        new JdeField("UDPVEH", "UDPVEH", JdeDataType.String, 24),
        new JdeField("UDRLNO", "UDRLNO", JdeDataType.String, 26),
        new JdeField("UDMCUR", "UDMCUR", JdeDataType.String, 24),
        new JdeField("UDFLTN", "UDFLTN", JdeDataType.String, 16),
        new JdeField("UDDSNN", "UDDSNN", JdeDataType.String, 10),
        new JdeField("UDARCT", "UDARCT", JdeDataType.String, 10),
        new JdeField("UDSORG", "UDSORG", JdeDataType.String, 30),
        new JdeField("UDELTM", "UDELTM", JdeDataType.Numeric),
        new JdeField("UDPTNR", "UDPTNR", JdeDataType.Numeric),
        new JdeField("UDIAN8", "UDIAN8", JdeDataType.Numeric),
        new JdeField("UDPTC", "UDPTC", JdeDataType.String, 6),
        new JdeField("UDDOC", "UDDOC", JdeDataType.Numeric),
        new JdeField("UDDCT", "UDDCT", JdeDataType.String, 4),
        new JdeField("UDKCO", "UDKCO", JdeDataType.String, 10),
        new JdeField("UDCRR", "UDCRR", JdeDataType.Numeric),
        new JdeField("UDCRCD", "UDCRCD", JdeDataType.String, 6),
        new JdeField("UDTXA1", "UDTXA1", JdeDataType.String, 20),
        new JdeField("UDEXR1", "UDEXR1", JdeDataType.String, 4),
        new JdeField("UDFRDM", "UDFRDM", JdeDataType.String, 2),
        new JdeField("UDFUPT", "UDFUPT", JdeDataType.String, 6),
        new JdeField("UDRINO", "UDRINO", JdeDataType.String, 30),
        new JdeField("UDGLOC", "UDGLOC", JdeDataType.String, 30),
        new JdeField("UDAUTA", "UDAUTA", JdeDataType.String, 60),
        new JdeField("UDALPH", "UDALPH", JdeDataType.String, 80),
        new JdeField("UDMET1", "UDMET1", JdeDataType.String, 20),
        new JdeField("UDOPN1", "UDOPN1", JdeDataType.Numeric),
        new JdeField("UDPNR1", "UDPNR1", JdeDataType.Numeric),
        new JdeField("UDMET2", "UDMET2", JdeDataType.String, 20),
        new JdeField("UDOPN2", "UDOPN2", JdeDataType.Numeric),
        new JdeField("UDPNR2", "UDPNR2", JdeDataType.Numeric),
        new JdeField("UDMET3", "UDMET3", JdeDataType.String, 20),
        new JdeField("UDOPN3", "UDOPN3", JdeDataType.Numeric),
        new JdeField("UDPNR3", "UDPNR3", JdeDataType.Numeric),
        new JdeField("UDARDT", "UDARDT", JdeDataType.Numeric),
        new JdeField("UDARTM", "UDARTM", JdeDataType.Numeric),
        new JdeField("UDDPDT", "UDDPDT", JdeDataType.Numeric),
        new JdeField("UDDETM", "UDDETM", JdeDataType.Numeric),
        new JdeField("UDDSTJ", "UDDSTJ", JdeDataType.Numeric),
        new JdeField("UDSTM", "UDSTM", JdeDataType.Numeric),
        new JdeField("UDEND", "UDEND", JdeDataType.Numeric),
        new JdeField("UDETM", "UDETM", JdeDataType.Numeric),
        new JdeField("UDTV01", "UDTV01", JdeDataType.String, 2),
        new JdeField("UDTV02", "UDTV02", JdeDataType.String, 2),
        new JdeField("UDTV03", "UDTV03", JdeDataType.String, 2),
        new JdeField("UDTV04", "UDTV04", JdeDataType.String, 2),
        new JdeField("UDTV05", "UDTV05", JdeDataType.String, 2),
        new JdeField("UDTVCD", "UDTVCD", JdeDataType.String, 4),
        new JdeField("UDTVQT", "UDTVQT", JdeDataType.Numeric),
        new JdeField("UDTVDT", "UDTVDT", JdeDataType.Numeric),
        new JdeField("UDTVUM", "UDTVUM", JdeDataType.String, 4),
        new JdeField("UDUSER", "UDUSER", JdeDataType.String, 20),
        new JdeField("UDPID", "UDPID", JdeDataType.String, 20),
        new JdeField("UDJOBN", "UDJOBN", JdeDataType.String, 20),
        new JdeField("UDUPMJ", "UDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("UDTDAY", "UDTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("UDSBCK", "UDSBCK", JdeDataType.String, 2),
        new JdeField("UDEDCK", "UDEDCK", JdeDataType.String, 2),
        new JdeField("UDCMDM", "UDCMDM", JdeDataType.String, 2),
        new JdeField("UDBBCK", "UDBBCK", JdeDataType.String, 2),
        new JdeField("UDRQSJ", "UDRQSJ", JdeDataType.Numeric),
        new JdeField("UDPSDJ", "UDPSDJ", JdeDataType.Numeric),
        new JdeField("UDADLJ", "UDADLJ", JdeDataType.Numeric),
        new JdeField("UDSUB", "UDSUB", JdeDataType.String, 16),
        new JdeField("UDSTTS", "UDSTTS", JdeDataType.String, 4),
        new JdeField("UDRATT", "UDRATT", JdeDataType.String, 2),
        new JdeField("UDFUF1", "UDFUF1", JdeDataType.String, 2),
        new JdeField("UDFRTC", "UDFRTC", JdeDataType.String, 2),
        new JdeField("UDFRAT", "UDFRAT", JdeDataType.String, 20),
        new JdeField("UDAFT", "UDAFT", JdeDataType.String, 2),
        new JdeField("UDOMCU", "UDOMCU", JdeDataType.String, 24),
        new JdeField("UDOBJ", "UDOBJ", JdeDataType.String, 12),
        new JdeField("UDLT", "UDLT", JdeDataType.String, 4),
        new JdeField("UDFAPP", "UDFAPP", JdeDataType.String, 2),
        new JdeField("UDDSPR", "UDDSPR", JdeDataType.Numeric),
        new JdeField("UDDSFT", "UDDSFT", JdeDataType.String, 2),
        new JdeField("UDDMT1", "UDDMT1", JdeDataType.String, 24),
        new JdeField("UDDMS1", "UDDMS1", JdeDataType.Numeric),
        new JdeField("UDCOT", "UDCOT", JdeDataType.String, 6),
        new JdeField("UDCMGL", "UDCMGL", JdeDataType.String, 2),
        new JdeField("UDBALU", "UDBALU", JdeDataType.String, 2),
        new JdeField("UDAPOT", "UDAPOT", JdeDataType.Numeric),
        new JdeField("UDACGD", "UDACGD", JdeDataType.String, 6),
        new JdeField("UDANI", "UDANI", JdeDataType.String, 58),
        new JdeField("UDAID", "UDAID", JdeDataType.String, 16),
        new JdeField("UDOPOL", "UDOPOL", JdeDataType.Numeric),
        new JdeField("UDOPBO", "UDOPBO", JdeDataType.String, 60),
        new JdeField("UDOPID", "UDOPID", JdeDataType.String, 60),
        new JdeField("UDOPCS", "UDOPCS", JdeDataType.Numeric),
        new JdeField("UDOPLL", "UDOPLL", JdeDataType.String, 2),
        new JdeField("UDOPMS", "UDOPMS", JdeDataType.String, 2),
        new JdeField("UDOPSS", "UDOPSS", JdeDataType.String, 2),
        new JdeField("UDOPBA", "UDOPBA", JdeDataType.String, 2),
        new JdeField("UDFXSR", "UDFXSR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49299_0", "Primary Key on UDDOCO, UDDCTO, UDKCOO, UDLNID, UDUPMJ, UDTDAY", new[] { "UDDOCO", "UDDCTO", "UDKCOO", "UDLNID", "UDUPMJ", "UDTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
