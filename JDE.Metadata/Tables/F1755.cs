using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1755 - .
/// </summary>
public class F1755 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZASTAW.
        /// </summary>
        public const string ZASTAW = "ZASTAW";

        /// <summary>
        /// ZADOCO.
        /// </summary>
        public const string ZADOCO = "ZADOCO";

        /// <summary>
        /// ZAUPMJ.
        /// </summary>
        public const string ZAUPMJ = "ZAUPMJ";

        /// <summary>
        /// ZAUPMT.
        /// </summary>
        public const string ZAUPMT = "ZAUPMT";

        /// <summary>
        /// ZADCTO.
        /// </summary>
        public const string ZADCTO = "ZADCTO";

        /// <summary>
        /// ZAKCOO.
        /// </summary>
        public const string ZAKCOO = "ZAKCOO";

        /// <summary>
        /// ZACT01.
        /// </summary>
        public const string ZACT01 = "ZACT01";

        /// <summary>
        /// ZACT02.
        /// </summary>
        public const string ZACT02 = "ZACT02";

        /// <summary>
        /// ZAPRIOR.
        /// </summary>
        public const string ZAPRIOR = "ZAPRIOR";

        /// <summary>
        /// ZACLST.
        /// </summary>
        public const string ZACLST = "ZACLST";

        /// <summary>
        /// ZADESC.
        /// </summary>
        public const string ZADESC = "ZADESC";

        /// <summary>
        /// ZAISSUE.
        /// </summary>
        public const string ZAISSUE = "ZAISSUE";

        /// <summary>
        /// ZASERK.
        /// </summary>
        public const string ZASERK = "ZASERK";

        /// <summary>
        /// ZASCALL.
        /// </summary>
        public const string ZASCALL = "ZASCALL";

        /// <summary>
        /// ZAVRU.
        /// </summary>
        public const string ZAVRU = "ZAVRU";

        /// <summary>
        /// ZACALLRN.
        /// </summary>
        public const string ZACALLRN = "ZACALLRN";

        /// <summary>
        /// ZATASKNO.
        /// </summary>
        public const string ZATASKNO = "ZATASKNO";

        /// <summary>
        /// ZATIMEZONES.
        /// </summary>
        public const string ZATIMEZONES = "ZATIMEZONES";

        /// <summary>
        /// ZADSAVNAME.
        /// </summary>
        public const string ZADSAVNAME = "ZADSAVNAME";

        /// <summary>
        /// ZAREGION.
        /// </summary>
        public const string ZAREGION = "ZAREGION";

        /// <summary>
        /// ZALNGP.
        /// </summary>
        public const string ZALNGP = "ZALNGP";

        /// <summary>
        /// ZAPARCALL.
        /// </summary>
        public const string ZAPARCALL = "ZAPARCALL";

        /// <summary>
        /// ZACALLQ.
        /// </summary>
        public const string ZACALLQ = "ZACALLQ";

        /// <summary>
        /// ZAAN8.
        /// </summary>
        public const string ZAAN8 = "ZAAN8";

        /// <summary>
        /// ZAPH1.
        /// </summary>
        public const string ZAPH1 = "ZAPH1";

        /// <summary>
        /// ZAANC.
        /// </summary>
        public const string ZAANC = "ZAANC";

        /// <summary>
        /// ZAIDLN.
        /// </summary>
        public const string ZAIDLN = "ZAIDLN";

        /// <summary>
        /// ZAAR1.
        /// </summary>
        public const string ZAAR1 = "ZAAR1";

        /// <summary>
        /// ZACPH.
        /// </summary>
        public const string ZACPH = "ZACPH";

        /// <summary>
        /// ZAWHO1.
        /// </summary>
        public const string ZAWHO1 = "ZAWHO1";

        /// <summary>
        /// ZAREM1.
        /// </summary>
        public const string ZAREM1 = "ZAREM1";

        /// <summary>
        /// ZAFAR1.
        /// </summary>
        public const string ZAFAR1 = "ZAFAR1";

        /// <summary>
        /// ZACFAX1.
        /// </summary>
        public const string ZACFAX1 = "ZACFAX1";

        /// <summary>
        /// ZAAAR1.
        /// </summary>
        public const string ZAAAR1 = "ZAAAR1";

        /// <summary>
        /// ZAPHN1.
        /// </summary>
        public const string ZAPHN1 = "ZAPHN1";

        /// <summary>
        /// ZACTR.
        /// </summary>
        public const string ZACTR = "ZACTR";

        /// <summary>
        /// ZAAN8CT1.
        /// </summary>
        public const string ZAAN8CT1 = "ZAAN8CT1";

        /// <summary>
        /// ZAIDLNC1.
        /// </summary>
        public const string ZAIDLNC1 = "ZAIDLNC1";

        /// <summary>
        /// ZAAR2.
        /// </summary>
        public const string ZAAR2 = "ZAAR2";

        /// <summary>
        /// ZACPHC1.
        /// </summary>
        public const string ZACPHC1 = "ZACPHC1";

        /// <summary>
        /// ZAWHO2.
        /// </summary>
        public const string ZAWHO2 = "ZAWHO2";

        /// <summary>
        /// ZACEML1.
        /// </summary>
        public const string ZACEML1 = "ZACEML1";

        /// <summary>
        /// ZAFAR2.
        /// </summary>
        public const string ZAFAR2 = "ZAFAR2";

        /// <summary>
        /// ZACFAX2.
        /// </summary>
        public const string ZACFAX2 = "ZACFAX2";

        /// <summary>
        /// ZAAAR2.
        /// </summary>
        public const string ZAAAR2 = "ZAAAR2";

        /// <summary>
        /// ZAPHN2.
        /// </summary>
        public const string ZAPHN2 = "ZAPHN2";

        /// <summary>
        /// ZAAN8CT2.
        /// </summary>
        public const string ZAAN8CT2 = "ZAAN8CT2";

        /// <summary>
        /// ZAIDLNC2.
        /// </summary>
        public const string ZAIDLNC2 = "ZAIDLNC2";

        /// <summary>
        /// ZAAR3.
        /// </summary>
        public const string ZAAR3 = "ZAAR3";

        /// <summary>
        /// ZACPHC2.
        /// </summary>
        public const string ZACPHC2 = "ZACPHC2";

        /// <summary>
        /// ZAWHO3.
        /// </summary>
        public const string ZAWHO3 = "ZAWHO3";

        /// <summary>
        /// ZACEML2.
        /// </summary>
        public const string ZACEML2 = "ZACEML2";

        /// <summary>
        /// ZAFAR3.
        /// </summary>
        public const string ZAFAR3 = "ZAFAR3";

        /// <summary>
        /// ZACFAX3.
        /// </summary>
        public const string ZACFAX3 = "ZACFAX3";

        /// <summary>
        /// ZAAAR3.
        /// </summary>
        public const string ZAAAR3 = "ZAAAR3";

        /// <summary>
        /// ZAPHN3.
        /// </summary>
        public const string ZAPHN3 = "ZAPHN3";

        /// <summary>
        /// ZAAN8CT3.
        /// </summary>
        public const string ZAAN8CT3 = "ZAAN8CT3";

        /// <summary>
        /// ZAIDLNC3.
        /// </summary>
        public const string ZAIDLNC3 = "ZAIDLNC3";

        /// <summary>
        /// ZAAR4.
        /// </summary>
        public const string ZAAR4 = "ZAAR4";

        /// <summary>
        /// ZACPHC3.
        /// </summary>
        public const string ZACPHC3 = "ZACPHC3";

        /// <summary>
        /// ZAWHO4.
        /// </summary>
        public const string ZAWHO4 = "ZAWHO4";

        /// <summary>
        /// ZACEML3.
        /// </summary>
        public const string ZACEML3 = "ZACEML3";

        /// <summary>
        /// ZAFAR4.
        /// </summary>
        public const string ZAFAR4 = "ZAFAR4";

        /// <summary>
        /// ZACFAX4.
        /// </summary>
        public const string ZACFAX4 = "ZACFAX4";

        /// <summary>
        /// ZAAAR4.
        /// </summary>
        public const string ZAAAR4 = "ZAAAR4";

        /// <summary>
        /// ZAPHN4.
        /// </summary>
        public const string ZAPHN4 = "ZAPHN4";

        /// <summary>
        /// ZANUMB.
        /// </summary>
        public const string ZANUMB = "ZANUMB";

        /// <summary>
        /// ZAPRODF.
        /// </summary>
        public const string ZAPRODF = "ZAPRODF";

        /// <summary>
        /// ZAPRODM.
        /// </summary>
        public const string ZAPRODM = "ZAPRODM";

        /// <summary>
        /// ZAPRODC.
        /// </summary>
        public const string ZAPRODC = "ZAPRODC";

        /// <summary>
        /// ZAITM.
        /// </summary>
        public const string ZAITM = "ZAITM";

        /// <summary>
        /// ZAMMCU.
        /// </summary>
        public const string ZAMMCU = "ZAMMCU";

        /// <summary>
        /// ZALOTN.
        /// </summary>
        public const string ZALOTN = "ZALOTN";

        /// <summary>
        /// ZAENV.
        /// </summary>
        public const string ZAENV = "ZAENV";

        /// <summary>
        /// ZALANO.
        /// </summary>
        public const string ZALANO = "ZALANO";

        /// <summary>
        /// ZADOCZ.
        /// </summary>
        public const string ZADOCZ = "ZADOCZ";

        /// <summary>
        /// ZARCTO.
        /// </summary>
        public const string ZARCTO = "ZARCTO";

        /// <summary>
        /// ZARKCO.
        /// </summary>
        public const string ZARKCO = "ZARKCO";

        /// <summary>
        /// ZARLIN.
        /// </summary>
        public const string ZARLIN = "ZARLIN";

        /// <summary>
        /// ZACOCH.
        /// </summary>
        public const string ZACOCH = "ZACOCH";

        /// <summary>
        /// ZAOORN.
        /// </summary>
        public const string ZAOORN = "ZAOORN";

        /// <summary>
        /// ZAOCTO.
        /// </summary>
        public const string ZAOCTO = "ZAOCTO";

        /// <summary>
        /// ZAOKCO.
        /// </summary>
        public const string ZAOKCO = "ZAOKCO";

        /// <summary>
        /// ZADOC.
        /// </summary>
        public const string ZADOC = "ZADOC";

        /// <summary>
        /// ZADCT.
        /// </summary>
        public const string ZADCT = "ZADCT";

        /// <summary>
        /// ZAKCO.
        /// </summary>
        public const string ZAKCO = "ZAKCO";

        /// <summary>
        /// ZADOCM.
        /// </summary>
        public const string ZADOCM = "ZADOCM";

        /// <summary>
        /// ZADCTM.
        /// </summary>
        public const string ZADCTM = "ZADCTM";

        /// <summary>
        /// ZAKCOP.
        /// </summary>
        public const string ZAKCOP = "ZAKCOP";

        /// <summary>
        /// ZAENTCK.
        /// </summary>
        public const string ZAENTCK = "ZAENTCK";

        /// <summary>
        /// ZAGWAUT.
        /// </summary>
        public const string ZAGWAUT = "ZAGWAUT";

        /// <summary>
        /// ZABILL.
        /// </summary>
        public const string ZABILL = "ZABILL";

        /// <summary>
        /// ZAMTHPR.
        /// </summary>
        public const string ZAMTHPR = "ZAMTHPR";

        /// <summary>
        /// ZAGLCCV.
        /// </summary>
        public const string ZAGLCCV = "ZAGLCCV";

        /// <summary>
        /// ZAGLCNC.
        /// </summary>
        public const string ZAGLCNC = "ZAGLCNC";

        /// <summary>
        /// ZACOST.
        /// </summary>
        public const string ZACOST = "ZACOST";

        /// <summary>
        /// ZALNTY.
        /// </summary>
        public const string ZALNTY = "ZALNTY";

        /// <summary>
        /// ZARSTM.
        /// </summary>
        public const string ZARSTM = "ZARSTM";

        /// <summary>
        /// ZAHMCU.
        /// </summary>
        public const string ZAHMCU = "ZAHMCU";

        /// <summary>
        /// ZAOBJ.
        /// </summary>
        public const string ZAOBJ = "ZAOBJ";

        /// <summary>
        /// ZASUB.
        /// </summary>
        public const string ZASUB = "ZASUB";

        /// <summary>
        /// ZACSCL.
        /// </summary>
        public const string ZACSCL = "ZACSCL";

        /// <summary>
        /// ZAISNO.
        /// </summary>
        public const string ZAISNO = "ZAISNO";

        /// <summary>
        /// ZAAG.
        /// </summary>
        public const string ZAAG = "ZAAG";

        /// <summary>
        /// ZAACR.
        /// </summary>
        public const string ZAACR = "ZAACR";

        /// <summary>
        /// ZAMODE.
        /// </summary>
        public const string ZAMODE = "ZAMODE";

        /// <summary>
        /// ZACRCD.
        /// </summary>
        public const string ZACRCD = "ZACRCD";

        /// <summary>
        /// ZACRDC.
        /// </summary>
        public const string ZACRDC = "ZACRDC";

        /// <summary>
        /// ZAHRSO.
        /// </summary>
        public const string ZAHRSO = "ZAHRSO";

        /// <summary>
        /// ZAAMTO.
        /// </summary>
        public const string ZAAMTO = "ZAAMTO";

        /// <summary>
        /// ZAFAP.
        /// </summary>
        public const string ZAFAP = "ZAFAP";

        /// <summary>
        /// ZADTBIL.
        /// </summary>
        public const string ZADTBIL = "ZADTBIL";

        /// <summary>
        /// ZAASN3.
        /// </summary>
        public const string ZAASN3 = "ZAASN3";

        /// <summary>
        /// ZACOVGR.
        /// </summary>
        public const string ZACOVGR = "ZACOVGR";

        /// <summary>
        /// ZAMCUZ.
        /// </summary>
        public const string ZAMCUZ = "ZAMCUZ";

        /// <summary>
        /// ZACO.
        /// </summary>
        public const string ZACO = "ZACO";

        /// <summary>
        /// ZAPBTM.
        /// </summary>
        public const string ZAPBTM = "ZAPBTM";

        /// <summary>
        /// ZAEFTB.
        /// </summary>
        public const string ZAEFTB = "ZAEFTB";

        /// <summary>
        /// ZAPETM.
        /// </summary>
        public const string ZAPETM = "ZAPETM";

        /// <summary>
        /// ZAEND.
        /// </summary>
        public const string ZAEND = "ZAEND";

        /// <summary>
        /// ZADX.
        /// </summary>
        public const string ZADX = "ZADX";

        /// <summary>
        /// ZAINRT.
        /// </summary>
        public const string ZAINRT = "ZAINRT";

        /// <summary>
        /// ZAONSDT.
        /// </summary>
        public const string ZAONSDT = "ZAONSDT";

        /// <summary>
        /// ZAONSTM.
        /// </summary>
        public const string ZAONSTM = "ZAONSTM";

        /// <summary>
        /// ZADRQJ.
        /// </summary>
        public const string ZADRQJ = "ZADRQJ";

        /// <summary>
        /// ZADRQT.
        /// </summary>
        public const string ZADRQT = "ZADRQT";

        /// <summary>
        /// ZASESD.
        /// </summary>
        public const string ZASESD = "ZASESD";

        /// <summary>
        /// ZASEED.
        /// </summary>
        public const string ZASEED = "ZASEED";

        /// <summary>
        /// ZASEST.
        /// </summary>
        public const string ZASEST = "ZASEST";

        /// <summary>
        /// ZASEET.
        /// </summary>
        public const string ZASEET = "ZASEET";

        /// <summary>
        /// ZADEF.
        /// </summary>
        public const string ZADEF = "ZADEF";

        /// <summary>
        /// ZADL01.
        /// </summary>
        public const string ZADL01 = "ZADL01";

        /// <summary>
        /// ZATELH.
        /// </summary>
        public const string ZATELH = "ZATELH";

        /// <summary>
        /// ZAEDAYS.
        /// </summary>
        public const string ZAEDAYS = "ZAEDAYS";

        /// <summary>
        /// ZAIDYS.
        /// </summary>
        public const string ZAIDYS = "ZAIDYS";

        /// <summary>
        /// ZACOMD.
        /// </summary>
        public const string ZACOMD = "ZACOMD";

        /// <summary>
        /// ZACDATE.
        /// </summary>
        public const string ZACDATE = "ZACDATE";

        /// <summary>
        /// ZACTIME.
        /// </summary>
        public const string ZACTIME = "ZACTIME";

        /// <summary>
        /// ZAESC1.
        /// </summary>
        public const string ZAESC1 = "ZAESC1";

        /// <summary>
        /// ZAESC2.
        /// </summary>
        public const string ZAESC2 = "ZAESC2";

        /// <summary>
        /// ZAESDTE.
        /// </summary>
        public const string ZAESDTE = "ZAESDTE";

        /// <summary>
        /// ZAESTME.
        /// </summary>
        public const string ZAESTME = "ZAESTME";

        /// <summary>
        /// ZAJC01.
        /// </summary>
        public const string ZAJC01 = "ZAJC01";

        /// <summary>
        /// ZAJC02.
        /// </summary>
        public const string ZAJC02 = "ZAJC02";

        /// <summary>
        /// ZAJC03.
        /// </summary>
        public const string ZAJC03 = "ZAJC03";

        /// <summary>
        /// ZAJC04.
        /// </summary>
        public const string ZAJC04 = "ZAJC04";

        /// <summary>
        /// ZAJC05.
        /// </summary>
        public const string ZAJC05 = "ZAJC05";

        /// <summary>
        /// ZAJC06.
        /// </summary>
        public const string ZAJC06 = "ZAJC06";

        /// <summary>
        /// ZAJC07.
        /// </summary>
        public const string ZAJC07 = "ZAJC07";

        /// <summary>
        /// ZAJC08.
        /// </summary>
        public const string ZAJC08 = "ZAJC08";

        /// <summary>
        /// ZAJC09.
        /// </summary>
        public const string ZAJC09 = "ZAJC09";

        /// <summary>
        /// ZAJC10.
        /// </summary>
        public const string ZAJC10 = "ZAJC10";

        /// <summary>
        /// ZAZE01.
        /// </summary>
        public const string ZAZE01 = "ZAZE01";

        /// <summary>
        /// ZAZE02.
        /// </summary>
        public const string ZAZE02 = "ZAZE02";

        /// <summary>
        /// ZAZE03.
        /// </summary>
        public const string ZAZE03 = "ZAZE03";

        /// <summary>
        /// ZAZE04.
        /// </summary>
        public const string ZAZE04 = "ZAZE04";

        /// <summary>
        /// ZAZE05.
        /// </summary>
        public const string ZAZE05 = "ZAZE05";

        /// <summary>
        /// ZAZE06.
        /// </summary>
        public const string ZAZE06 = "ZAZE06";

        /// <summary>
        /// ZAZE07.
        /// </summary>
        public const string ZAZE07 = "ZAZE07";

        /// <summary>
        /// ZAZE08.
        /// </summary>
        public const string ZAZE08 = "ZAZE08";

        /// <summary>
        /// ZAZE09.
        /// </summary>
        public const string ZAZE09 = "ZAZE09";

        /// <summary>
        /// ZAZE10.
        /// </summary>
        public const string ZAZE10 = "ZAZE10";

        /// <summary>
        /// ZAURAB.
        /// </summary>
        public const string ZAURAB = "ZAURAB";

        /// <summary>
        /// ZAURCD.
        /// </summary>
        public const string ZAURCD = "ZAURCD";

        /// <summary>
        /// ZAURAT.
        /// </summary>
        public const string ZAURAT = "ZAURAT";

        /// <summary>
        /// ZAURDT.
        /// </summary>
        public const string ZAURDT = "ZAURDT";

        /// <summary>
        /// ZAURRF.
        /// </summary>
        public const string ZAURRF = "ZAURRF";

        /// <summary>
        /// ZAEFFT.
        /// </summary>
        public const string ZAEFFT = "ZAEFFT";

        /// <summary>
        /// ZACRTU.
        /// </summary>
        public const string ZACRTU = "ZACRTU";

        /// <summary>
        /// ZAUSER.
        /// </summary>
        public const string ZAUSER = "ZAUSER";

        /// <summary>
        /// ZAPID.
        /// </summary>
        public const string ZAPID = "ZAPID";

        /// <summary>
        /// ZAJOBN.
        /// </summary>
        public const string ZAJOBN = "ZAJOBN";

        /// <summary>
        /// ZATYPS.
        /// </summary>
        public const string ZATYPS = "ZATYPS";

        /// <summary>
        /// ZACRRM.
        /// </summary>
        public const string ZACRRM = "ZACRRM";

        /// <summary>
        /// ZACRR.
        /// </summary>
        public const string ZACRR = "ZACRR";

        /// <summary>
        /// ZAPEFJ.
        /// </summary>
        public const string ZAPEFJ = "ZAPEFJ";

        /// <summary>
        /// ZABLCN.
        /// </summary>
        public const string ZABLCN = "ZABLCN";

        /// <summary>
        /// ZAUM.
        /// </summary>
        public const string ZAUM = "ZAUM";

        /// <summary>
        /// ZAAMTFD.
        /// </summary>
        public const string ZAAMTFD = "ZAAMTFD";

        /// <summary>
        /// ZAAMTFF.
        /// </summary>
        public const string ZAAMTFF = "ZAAMTFF";

        /// <summary>
        /// ZAPCOVR.
        /// </summary>
        public const string ZAPCOVR = "ZAPCOVR";

        /// <summary>
        /// ZAGWAFL.
        /// </summary>
        public const string ZAGWAFL = "ZAGWAFL";

        /// <summary>
        /// ZAGWANC.
        /// </summary>
        public const string ZAGWANC = "ZAGWANC";

        /// <summary>
        /// ZASERP.
        /// </summary>
        public const string ZASERP = "ZASERP";

        /// <summary>
        /// ZAANOB.
        /// </summary>
        public const string ZAANOB = "ZAANOB";

        /// <summary>
        /// ZAUSA5.
        /// </summary>
        public const string ZAUSA5 = "ZAUSA5";

        /// <summary>
        /// ZAVR01.
        /// </summary>
        public const string ZAVR01 = "ZAVR01";

        /// <summary>
        /// ZAMINHR.
        /// </summary>
        public const string ZAMINHR = "ZAMINHR";

        /// <summary>
        /// ZAMINAD.
        /// </summary>
        public const string ZAMINAD = "ZAMINAD";

        /// <summary>
        /// ZAMINAF.
        /// </summary>
        public const string ZAMINAF = "ZAMINAF";

        /// <summary>
        /// ZADSFT.
        /// </summary>
        public const string ZADSFT = "ZADSFT";

        /// <summary>
        /// ZADSPC.
        /// </summary>
        public const string ZADSPC = "ZADSPC";

        /// <summary>
        /// ZAIDSC.
        /// </summary>
        public const string ZAIDSC = "ZAIDSC";

        /// <summary>
        /// ZACIDS.
        /// </summary>
        public const string ZACIDS = "ZACIDS";

        /// <summary>
        /// ZAITAM.
        /// </summary>
        public const string ZAITAM = "ZAITAM";

        /// <summary>
        /// ZACITX.
        /// </summary>
        public const string ZACITX = "ZACITX";

        /// <summary>
        /// ZAJTAX.
        /// </summary>
        public const string ZAJTAX = "ZAJTAX";

        /// <summary>
        /// ZAJTXF.
        /// </summary>
        public const string ZAJTXF = "ZAJTXF";

        /// <summary>
        /// ZAAMTCD.
        /// </summary>
        public const string ZAAMTCD = "ZAAMTCD";

        /// <summary>
        /// ZAAMTCF.
        /// </summary>
        public const string ZAAMTCF = "ZAAMTCF";

        /// <summary>
        /// ZAATXCD.
        /// </summary>
        public const string ZAATXCD = "ZAATXCD";

        /// <summary>
        /// ZAATXCF.
        /// </summary>
        public const string ZAATXCF = "ZAATXCF";

        /// <summary>
        /// ZAEFTJ.
        /// </summary>
        public const string ZAEFTJ = "ZAEFTJ";

        /// <summary>
        /// ZAPTC.
        /// </summary>
        public const string ZAPTC = "ZAPTC";

        /// <summary>
        /// ZARYIN.
        /// </summary>
        public const string ZARYIN = "ZARYIN";

        /// <summary>
        /// ZATAX1.
        /// </summary>
        public const string ZATAX1 = "ZATAX1";

        /// <summary>
        /// ZATXA1.
        /// </summary>
        public const string ZATXA1 = "ZATXA1";

        /// <summary>
        /// ZAPRAN8.
        /// </summary>
        public const string ZAPRAN8 = "ZAPRAN8";

        /// <summary>
        /// ZAPRCNCT.
        /// </summary>
        public const string ZAPRCNCT = "ZAPRCNCT";

        /// <summary>
        /// ZAPRCIDLN.
        /// </summary>
        public const string ZAPRCIDLN = "ZAPRCIDLN";

        /// <summary>
        /// ZAEXR1.
        /// </summary>
        public const string ZAEXR1 = "ZAEXR1";
    }

    /// <inheritdoc />
    public override string TableName => "F1755";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZASTAW", "ZASTAW", JdeDataType.String, 2, true, true),
        new JdeField("ZADOCO", "ZADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAUPMJ", "ZAUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAUPMT", "ZAUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("ZADCTO", "ZADCTO", JdeDataType.String, 4),
        new JdeField("ZAKCOO", "ZAKCOO", JdeDataType.String, 10),
        new JdeField("ZACT01", "ZACT01", JdeDataType.String, 2),
        new JdeField("ZACT02", "ZACT02", JdeDataType.String, 2),
        new JdeField("ZAPRIOR", "ZAPRIOR", JdeDataType.String, 4),
        new JdeField("ZACLST", "ZACLST", JdeDataType.String, 6),
        new JdeField("ZADESC", "ZADESC", JdeDataType.String, 60),
        new JdeField("ZAISSUE", "ZAISSUE", JdeDataType.String, 160),
        new JdeField("ZASERK", "ZASERK", JdeDataType.Numeric),
        new JdeField("ZASCALL", "ZASCALL", JdeDataType.String, 2),
        new JdeField("ZAVRU", "ZAVRU", JdeDataType.String, 40),
        new JdeField("ZACALLRN", "ZACALLRN", JdeDataType.String, 6),
        new JdeField("ZATASKNO", "ZATASKNO", JdeDataType.Numeric),
        new JdeField("ZATIMEZONES", "ZATIMEZONES", JdeDataType.String, 4),
        new JdeField("ZADSAVNAME", "ZADSAVNAME", JdeDataType.String, 20),
        new JdeField("ZAREGION", "ZAREGION", JdeDataType.String, 6),
        new JdeField("ZALNGP", "ZALNGP", JdeDataType.String, 4),
        new JdeField("ZAPARCALL", "ZAPARCALL", JdeDataType.Numeric),
        new JdeField("ZACALLQ", "ZACALLQ", JdeDataType.Numeric),
        new JdeField("ZAAN8", "ZAAN8", JdeDataType.Numeric),
        new JdeField("ZAPH1", "ZAPH1", JdeDataType.String, 40),
        new JdeField("ZAANC", "ZAANC", JdeDataType.Numeric),
        new JdeField("ZAIDLN", "ZAIDLN", JdeDataType.Numeric),
        new JdeField("ZAAR1", "ZAAR1", JdeDataType.String, 12),
        new JdeField("ZACPH", "ZACPH", JdeDataType.String, 40),
        new JdeField("ZAWHO1", "ZAWHO1", JdeDataType.String, 80),
        new JdeField("ZAREM1", "ZAREM1", JdeDataType.String, 80),
        new JdeField("ZAFAR1", "ZAFAR1", JdeDataType.String, 12),
        new JdeField("ZACFAX1", "ZACFAX1", JdeDataType.String, 40),
        new JdeField("ZAAAR1", "ZAAAR1", JdeDataType.String, 12),
        new JdeField("ZAPHN1", "ZAPHN1", JdeDataType.String, 40),
        new JdeField("ZACTR", "ZACTR", JdeDataType.String, 6),
        new JdeField("ZAAN8CT1", "ZAAN8CT1", JdeDataType.Numeric),
        new JdeField("ZAIDLNC1", "ZAIDLNC1", JdeDataType.Numeric),
        new JdeField("ZAAR2", "ZAAR2", JdeDataType.String, 12),
        new JdeField("ZACPHC1", "ZACPHC1", JdeDataType.String, 40),
        new JdeField("ZAWHO2", "ZAWHO2", JdeDataType.String, 80),
        new JdeField("ZACEML1", "ZACEML1", JdeDataType.String, 80),
        new JdeField("ZAFAR2", "ZAFAR2", JdeDataType.String, 12),
        new JdeField("ZACFAX2", "ZACFAX2", JdeDataType.String, 40),
        new JdeField("ZAAAR2", "ZAAAR2", JdeDataType.String, 12),
        new JdeField("ZAPHN2", "ZAPHN2", JdeDataType.String, 40),
        new JdeField("ZAAN8CT2", "ZAAN8CT2", JdeDataType.Numeric),
        new JdeField("ZAIDLNC2", "ZAIDLNC2", JdeDataType.Numeric),
        new JdeField("ZAAR3", "ZAAR3", JdeDataType.String, 12),
        new JdeField("ZACPHC2", "ZACPHC2", JdeDataType.String, 40),
        new JdeField("ZAWHO3", "ZAWHO3", JdeDataType.String, 80),
        new JdeField("ZACEML2", "ZACEML2", JdeDataType.String, 80),
        new JdeField("ZAFAR3", "ZAFAR3", JdeDataType.String, 12),
        new JdeField("ZACFAX3", "ZACFAX3", JdeDataType.String, 40),
        new JdeField("ZAAAR3", "ZAAAR3", JdeDataType.String, 12),
        new JdeField("ZAPHN3", "ZAPHN3", JdeDataType.String, 40),
        new JdeField("ZAAN8CT3", "ZAAN8CT3", JdeDataType.Numeric),
        new JdeField("ZAIDLNC3", "ZAIDLNC3", JdeDataType.Numeric),
        new JdeField("ZAAR4", "ZAAR4", JdeDataType.String, 12),
        new JdeField("ZACPHC3", "ZACPHC3", JdeDataType.String, 40),
        new JdeField("ZAWHO4", "ZAWHO4", JdeDataType.String, 80),
        new JdeField("ZACEML3", "ZACEML3", JdeDataType.String, 80),
        new JdeField("ZAFAR4", "ZAFAR4", JdeDataType.String, 12),
        new JdeField("ZACFAX4", "ZACFAX4", JdeDataType.String, 40),
        new JdeField("ZAAAR4", "ZAAAR4", JdeDataType.String, 12),
        new JdeField("ZAPHN4", "ZAPHN4", JdeDataType.String, 40),
        new JdeField("ZANUMB", "ZANUMB", JdeDataType.Numeric),
        new JdeField("ZAPRODF", "ZAPRODF", JdeDataType.String, 16),
        new JdeField("ZAPRODM", "ZAPRODM", JdeDataType.String, 16),
        new JdeField("ZAPRODC", "ZAPRODC", JdeDataType.String, 20),
        new JdeField("ZAITM", "ZAITM", JdeDataType.Numeric),
        new JdeField("ZAMMCU", "ZAMMCU", JdeDataType.String, 24),
        new JdeField("ZALOTN", "ZALOTN", JdeDataType.String, 60),
        new JdeField("ZAENV", "ZAENV", JdeDataType.String, 20),
        new JdeField("ZALANO", "ZALANO", JdeDataType.Numeric),
        new JdeField("ZADOCZ", "ZADOCZ", JdeDataType.Numeric),
        new JdeField("ZARCTO", "ZARCTO", JdeDataType.String, 4),
        new JdeField("ZARKCO", "ZARKCO", JdeDataType.String, 10),
        new JdeField("ZARLIN", "ZARLIN", JdeDataType.Numeric),
        new JdeField("ZACOCH", "ZACOCH", JdeDataType.String, 6),
        new JdeField("ZAOORN", "ZAOORN", JdeDataType.String, 16),
        new JdeField("ZAOCTO", "ZAOCTO", JdeDataType.String, 4),
        new JdeField("ZAOKCO", "ZAOKCO", JdeDataType.String, 10),
        new JdeField("ZADOC", "ZADOC", JdeDataType.Numeric),
        new JdeField("ZADCT", "ZADCT", JdeDataType.String, 4),
        new JdeField("ZAKCO", "ZAKCO", JdeDataType.String, 10),
        new JdeField("ZADOCM", "ZADOCM", JdeDataType.Numeric),
        new JdeField("ZADCTM", "ZADCTM", JdeDataType.String, 4),
        new JdeField("ZAKCOP", "ZAKCOP", JdeDataType.String, 10),
        new JdeField("ZAENTCK", "ZAENTCK", JdeDataType.String, 6),
        new JdeField("ZAGWAUT", "ZAGWAUT", JdeDataType.String, 8),
        new JdeField("ZABILL", "ZABILL", JdeDataType.String, 2),
        new JdeField("ZAMTHPR", "ZAMTHPR", JdeDataType.String, 2),
        new JdeField("ZAGLCCV", "ZAGLCCV", JdeDataType.String, 8),
        new JdeField("ZAGLCNC", "ZAGLCNC", JdeDataType.String, 8),
        new JdeField("ZACOST", "ZACOST", JdeDataType.String, 6),
        new JdeField("ZALNTY", "ZALNTY", JdeDataType.String, 4),
        new JdeField("ZARSTM", "ZARSTM", JdeDataType.Numeric),
        new JdeField("ZAHMCU", "ZAHMCU", JdeDataType.String, 24),
        new JdeField("ZAOBJ", "ZAOBJ", JdeDataType.String, 12),
        new JdeField("ZASUB", "ZASUB", JdeDataType.String, 16),
        new JdeField("ZACSCL", "ZACSCL", JdeDataType.String, 40),
        new JdeField("ZAISNO", "ZAISNO", JdeDataType.Numeric),
        new JdeField("ZAAG", "ZAAG", JdeDataType.Numeric),
        new JdeField("ZAACR", "ZAACR", JdeDataType.Numeric),
        new JdeField("ZAMODE", "ZAMODE", JdeDataType.String, 2),
        new JdeField("ZACRCD", "ZACRCD", JdeDataType.String, 6),
        new JdeField("ZACRDC", "ZACRDC", JdeDataType.String, 6),
        new JdeField("ZAHRSO", "ZAHRSO", JdeDataType.Numeric),
        new JdeField("ZAAMTO", "ZAAMTO", JdeDataType.Numeric),
        new JdeField("ZAFAP", "ZAFAP", JdeDataType.Numeric),
        new JdeField("ZADTBIL", "ZADTBIL", JdeDataType.Numeric),
        new JdeField("ZAASN3", "ZAASN3", JdeDataType.String, 16),
        new JdeField("ZACOVGR", "ZACOVGR", JdeDataType.String, 16),
        new JdeField("ZAMCUZ", "ZAMCUZ", JdeDataType.String, 24),
        new JdeField("ZACO", "ZACO", JdeDataType.String, 10),
        new JdeField("ZAPBTM", "ZAPBTM", JdeDataType.Numeric),
        new JdeField("ZAEFTB", "ZAEFTB", JdeDataType.Numeric),
        new JdeField("ZAPETM", "ZAPETM", JdeDataType.Numeric),
        new JdeField("ZAEND", "ZAEND", JdeDataType.Numeric),
        new JdeField("ZADX", "ZADX", JdeDataType.Numeric),
        new JdeField("ZAINRT", "ZAINRT", JdeDataType.Numeric),
        new JdeField("ZAONSDT", "ZAONSDT", JdeDataType.Numeric),
        new JdeField("ZAONSTM", "ZAONSTM", JdeDataType.Numeric),
        new JdeField("ZADRQJ", "ZADRQJ", JdeDataType.Numeric),
        new JdeField("ZADRQT", "ZADRQT", JdeDataType.Numeric),
        new JdeField("ZASESD", "ZASESD", JdeDataType.Numeric),
        new JdeField("ZASEED", "ZASEED", JdeDataType.Numeric),
        new JdeField("ZASEST", "ZASEST", JdeDataType.Numeric),
        new JdeField("ZASEET", "ZASEET", JdeDataType.Numeric),
        new JdeField("ZADEF", "ZADEF", JdeDataType.Numeric),
        new JdeField("ZADL01", "ZADL01", JdeDataType.String, 60),
        new JdeField("ZATELH", "ZATELH", JdeDataType.Numeric),
        new JdeField("ZAEDAYS", "ZAEDAYS", JdeDataType.Numeric),
        new JdeField("ZAIDYS", "ZAIDYS", JdeDataType.Numeric),
        new JdeField("ZACOMD", "ZACOMD", JdeDataType.Numeric),
        new JdeField("ZACDATE", "ZACDATE", JdeDataType.Numeric),
        new JdeField("ZACTIME", "ZACTIME", JdeDataType.Numeric),
        new JdeField("ZAESC1", "ZAESC1", JdeDataType.String, 2),
        new JdeField("ZAESC2", "ZAESC2", JdeDataType.String, 2),
        new JdeField("ZAESDTE", "ZAESDTE", JdeDataType.Numeric),
        new JdeField("ZAESTME", "ZAESTME", JdeDataType.Numeric),
        new JdeField("ZAJC01", "ZAJC01", JdeDataType.String, 6),
        new JdeField("ZAJC02", "ZAJC02", JdeDataType.String, 6),
        new JdeField("ZAJC03", "ZAJC03", JdeDataType.String, 6),
        new JdeField("ZAJC04", "ZAJC04", JdeDataType.String, 6),
        new JdeField("ZAJC05", "ZAJC05", JdeDataType.String, 6),
        new JdeField("ZAJC06", "ZAJC06", JdeDataType.String, 6),
        new JdeField("ZAJC07", "ZAJC07", JdeDataType.String, 6),
        new JdeField("ZAJC08", "ZAJC08", JdeDataType.String, 6),
        new JdeField("ZAJC09", "ZAJC09", JdeDataType.String, 6),
        new JdeField("ZAJC10", "ZAJC10", JdeDataType.String, 6),
        new JdeField("ZAZE01", "ZAZE01", JdeDataType.String, 20),
        new JdeField("ZAZE02", "ZAZE02", JdeDataType.String, 20),
        new JdeField("ZAZE03", "ZAZE03", JdeDataType.String, 20),
        new JdeField("ZAZE04", "ZAZE04", JdeDataType.String, 20),
        new JdeField("ZAZE05", "ZAZE05", JdeDataType.String, 20),
        new JdeField("ZAZE06", "ZAZE06", JdeDataType.String, 20),
        new JdeField("ZAZE07", "ZAZE07", JdeDataType.String, 20),
        new JdeField("ZAZE08", "ZAZE08", JdeDataType.String, 20),
        new JdeField("ZAZE09", "ZAZE09", JdeDataType.String, 20),
        new JdeField("ZAZE10", "ZAZE10", JdeDataType.String, 20),
        new JdeField("ZAURAB", "ZAURAB", JdeDataType.Numeric),
        new JdeField("ZAURCD", "ZAURCD", JdeDataType.String, 4),
        new JdeField("ZAURAT", "ZAURAT", JdeDataType.Numeric),
        new JdeField("ZAURDT", "ZAURDT", JdeDataType.Numeric),
        new JdeField("ZAURRF", "ZAURRF", JdeDataType.String, 30),
        new JdeField("ZAEFFT", "ZAEFFT", JdeDataType.Numeric),
        new JdeField("ZACRTU", "ZACRTU", JdeDataType.String, 20),
        new JdeField("ZAUSER", "ZAUSER", JdeDataType.String, 20),
        new JdeField("ZAPID", "ZAPID", JdeDataType.String, 20),
        new JdeField("ZAJOBN", "ZAJOBN", JdeDataType.String, 20),
        new JdeField("ZATYPS", "ZATYPS", JdeDataType.String, 2),
        new JdeField("ZACRRM", "ZACRRM", JdeDataType.String, 2),
        new JdeField("ZACRR", "ZACRR", JdeDataType.Numeric),
        new JdeField("ZAPEFJ", "ZAPEFJ", JdeDataType.Numeric),
        new JdeField("ZABLCN", "ZABLCN", JdeDataType.Numeric),
        new JdeField("ZAUM", "ZAUM", JdeDataType.String, 4),
        new JdeField("ZAAMTFD", "ZAAMTFD", JdeDataType.Numeric),
        new JdeField("ZAAMTFF", "ZAAMTFF", JdeDataType.Numeric),
        new JdeField("ZAPCOVR", "ZAPCOVR", JdeDataType.Numeric),
        new JdeField("ZAGWAFL", "ZAGWAFL", JdeDataType.String, 2),
        new JdeField("ZAGWANC", "ZAGWANC", JdeDataType.String, 8),
        new JdeField("ZASERP", "ZASERP", JdeDataType.String, 16),
        new JdeField("ZAANOB", "ZAANOB", JdeDataType.Numeric),
        new JdeField("ZAUSA5", "ZAUSA5", JdeDataType.Numeric),
        new JdeField("ZAVR01", "ZAVR01", JdeDataType.String, 50),
        new JdeField("ZAMINHR", "ZAMINHR", JdeDataType.Numeric),
        new JdeField("ZAMINAD", "ZAMINAD", JdeDataType.Numeric),
        new JdeField("ZAMINAF", "ZAMINAF", JdeDataType.Numeric),
        new JdeField("ZADSFT", "ZADSFT", JdeDataType.String, 2),
        new JdeField("ZADSPC", "ZADSPC", JdeDataType.Numeric),
        new JdeField("ZAIDSC", "ZAIDSC", JdeDataType.Numeric),
        new JdeField("ZACIDS", "ZACIDS", JdeDataType.Numeric),
        new JdeField("ZAITAM", "ZAITAM", JdeDataType.Numeric),
        new JdeField("ZACITX", "ZACITX", JdeDataType.Numeric),
        new JdeField("ZAJTAX", "ZAJTAX", JdeDataType.Numeric),
        new JdeField("ZAJTXF", "ZAJTXF", JdeDataType.Numeric),
        new JdeField("ZAAMTCD", "ZAAMTCD", JdeDataType.Numeric),
        new JdeField("ZAAMTCF", "ZAAMTCF", JdeDataType.Numeric),
        new JdeField("ZAATXCD", "ZAATXCD", JdeDataType.Numeric),
        new JdeField("ZAATXCF", "ZAATXCF", JdeDataType.Numeric),
        new JdeField("ZAEFTJ", "ZAEFTJ", JdeDataType.Numeric),
        new JdeField("ZAPTC", "ZAPTC", JdeDataType.String, 6),
        new JdeField("ZARYIN", "ZARYIN", JdeDataType.String, 2),
        new JdeField("ZATAX1", "ZATAX1", JdeDataType.String, 2),
        new JdeField("ZATXA1", "ZATXA1", JdeDataType.String, 20),
        new JdeField("ZAPRAN8", "ZAPRAN8", JdeDataType.Numeric),
        new JdeField("ZAPRCNCT", "ZAPRCNCT", JdeDataType.String, 100),
        new JdeField("ZAPRCIDLN", "ZAPRCIDLN", JdeDataType.Numeric),
        new JdeField("ZAEXR1", "ZAEXR1", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1755_0", "Primary Key on ZADOCO, ZASTAW, ZAUPMJ, ZAUPMT", new[] { "ZADOCO", "ZASTAW", "ZAUPMJ", "ZAUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1755_10", "Index on ZADOCO, ZADCTO, ZAKCOO", new[] { "ZADOCO", "ZADCTO", "ZAKCOO" }),
        new JdeIndex("F1755_11", "Index on ZADOCO, ZASTAW", new[] { "ZADOCO", "ZASTAW" }),
        new JdeIndex("F1755_14", "Index on ZAAN8, ZASTAW, ZACLST, SYS_NC00212$, SYS_NC00213$, SYS_NC00214$", new[] { "ZAAN8", "ZASTAW", "ZACLST", "SYS_NC00212$", "SYS_NC00213$", "SYS_NC00214$" }),
        new JdeIndex("F1755_15", "Index on ZACALLQ, ZASTAW, ZAEFTB, SYS_NC00212$, SYS_NC00213$, SYS_NC00214$", new[] { "ZACALLQ", "ZASTAW", "ZAEFTB", "SYS_NC00212$", "SYS_NC00213$", "SYS_NC00214$" }),
        new JdeIndex("F1755_16", "Index on ZAANC, ZASTAW, SYS_NC00212$, SYS_NC00213$, SYS_NC00214$", new[] { "ZAANC", "ZASTAW", "SYS_NC00212$", "SYS_NC00213$", "SYS_NC00214$" }),
        new JdeIndex("F1755_3", "Index on ZACT01, ZAPRIOR, ZAUPMJ", new[] { "ZACT01", "ZAPRIOR", "ZAUPMJ" }),
        new JdeIndex("F1755_4", "Index on ZACT01, ZACLST", new[] { "ZACT01", "ZACLST" }),
        new JdeIndex("F1755_5", "Index on ZAANC", new[] { "ZAANC" }),
        new JdeIndex("F1755_6", "Index on ZAPRODF, ZAPRODM", new[] { "ZAPRODF", "ZAPRODM" }),
        new JdeIndex("F1755_7", "Index on ZASERK", new[] { "ZASERK" }),
        new JdeIndex("F1755_8", "Index on ZANUMB", new[] { "ZANUMB" }),
        new JdeIndex("F1755_9", "Index on ZAITM", new[] { "ZAITM" })
    };
}
