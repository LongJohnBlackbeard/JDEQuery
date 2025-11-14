using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G01M - .
/// </summary>
public class F52G01M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMDOCO.
        /// </summary>
        public const string CMDOCO = "CMDOCO";

        /// <summary>
        /// CMDCTO.
        /// </summary>
        public const string CMDCTO = "CMDCTO";

        /// <summary>
        /// CMKCOO.
        /// </summary>
        public const string CMKCOO = "CMKCOO";

        /// <summary>
        /// CMGCSE.
        /// </summary>
        public const string CMGCSE = "CMGCSE";

        /// <summary>
        /// CMMODNU.
        /// </summary>
        public const string CMMODNU = "CMMODNU";

        /// <summary>
        /// CMMODREV.
        /// </summary>
        public const string CMMODREV = "CMMODREV";

        /// <summary>
        /// CMMODTY.
        /// </summary>
        public const string CMMODTY = "CMMODTY";

        /// <summary>
        /// CMMODDT.
        /// </summary>
        public const string CMMODDT = "CMMODDT";

        /// <summary>
        /// CMMODDE.
        /// </summary>
        public const string CMMODDE = "CMMODDE";

        /// <summary>
        /// CMMODGL.
        /// </summary>
        public const string CMMODGL = "CMMODGL";

        /// <summary>
        /// CMDL01.
        /// </summary>
        public const string CMDL01 = "CMDL01";

        /// <summary>
        /// CMDC.
        /// </summary>
        public const string CMDC = "CMDC";

        /// <summary>
        /// CMDL02.
        /// </summary>
        public const string CMDL02 = "CMDL02";

        /// <summary>
        /// CMDL03.
        /// </summary>
        public const string CMDL03 = "CMDL03";

        /// <summary>
        /// CMODCM.
        /// </summary>
        public const string CMODCM = "CMODCM";

        /// <summary>
        /// CMOCNC.
        /// </summary>
        public const string CMOCNC = "CMOCNC";

        /// <summary>
        /// CMAN8O.
        /// </summary>
        public const string CMAN8O = "CMAN8O";

        /// <summary>
        /// CMMCIF.
        /// </summary>
        public const string CMMCIF = "CMMCIF";

        /// <summary>
        /// CMNTEF.
        /// </summary>
        public const string CMNTEF = "CMNTEF";

        /// <summary>
        /// CMRCTL.
        /// </summary>
        public const string CMRCTL = "CMRCTL";

        /// <summary>
        /// CMANOB.
        /// </summary>
        public const string CMANOB = "CMANOB";

        /// <summary>
        /// CMADCM.
        /// </summary>
        public const string CMADCM = "CMADCM";

        /// <summary>
        /// CMAN8K.
        /// </summary>
        public const string CMAN8K = "CMAN8K";

        /// <summary>
        /// CMUSA1.
        /// </summary>
        public const string CMUSA1 = "CMUSA1";

        /// <summary>
        /// CMUSA2.
        /// </summary>
        public const string CMUSA2 = "CMUSA2";

        /// <summary>
        /// CMUSA3.
        /// </summary>
        public const string CMUSA3 = "CMUSA3";

        /// <summary>
        /// CMUSA4.
        /// </summary>
        public const string CMUSA4 = "CMUSA4";

        /// <summary>
        /// CMUSA5.
        /// </summary>
        public const string CMUSA5 = "CMUSA5";

        /// <summary>
        /// CMDS.
        /// </summary>
        public const string CMDS = "CMDS";

        /// <summary>
        /// CMCT.
        /// </summary>
        public const string CMCT = "CMCT";

        /// <summary>
        /// CMMCUS.
        /// </summary>
        public const string CMMCUS = "CMMCUS";

        /// <summary>
        /// CMJMCU.
        /// </summary>
        public const string CMJMCU = "CMJMCU";

        /// <summary>
        /// CMCO.
        /// </summary>
        public const string CMCO = "CMCO";

        /// <summary>
        /// CMPCTN.
        /// </summary>
        public const string CMPCTN = "CMPCTN";

        /// <summary>
        /// CMPCTT.
        /// </summary>
        public const string CMPCTT = "CMPCTT";

        /// <summary>
        /// CMPCKO.
        /// </summary>
        public const string CMPCKO = "CMPCKO";

        /// <summary>
        /// CMRTNR.
        /// </summary>
        public const string CMRTNR = "CMRTNR";

        /// <summary>
        /// CMRGLC.
        /// </summary>
        public const string CMRGLC = "CMRGLC";

        /// <summary>
        /// CMRTN1.
        /// </summary>
        public const string CMRTN1 = "CMRTN1";

        /// <summary>
        /// CMEXR1.
        /// </summary>
        public const string CMEXR1 = "CMEXR1";

        /// <summary>
        /// CMTXA1.
        /// </summary>
        public const string CMTXA1 = "CMTXA1";

        /// <summary>
        /// CMINVF.
        /// </summary>
        public const string CMINVF = "CMINVF";

        /// <summary>
        /// CMAIAB.
        /// </summary>
        public const string CMAIAB = "CMAIAB";

        /// <summary>
        /// CMCTOV.
        /// </summary>
        public const string CMCTOV = "CMCTOV";

        /// <summary>
        /// CMPTC.
        /// </summary>
        public const string CMPTC = "CMPTC";

        /// <summary>
        /// CMBLWP.
        /// </summary>
        public const string CMBLWP = "CMBLWP";

        /// <summary>
        /// CMPYWP.
        /// </summary>
        public const string CMPYWP = "CMPYWP";

        /// <summary>
        /// CMBROV.
        /// </summary>
        public const string CMBROV = "CMBROV";

        /// <summary>
        /// CMFSLV.
        /// </summary>
        public const string CMFSLV = "CMFSLV";

        /// <summary>
        /// CMCRCD.
        /// </summary>
        public const string CMCRCD = "CMCRCD";

        /// <summary>
        /// CMCRCF.
        /// </summary>
        public const string CMCRCF = "CMCRCF";

        /// <summary>
        /// CMCRRM.
        /// </summary>
        public const string CMCRRM = "CMCRRM";

        /// <summary>
        /// CMNTEX.
        /// </summary>
        public const string CMNTEX = "CMNTEX";

        /// <summary>
        /// CMRNTE.
        /// </summary>
        public const string CMRNTE = "CMRNTE";

        /// <summary>
        /// CMERDB.
        /// </summary>
        public const string CMERDB = "CMERDB";

        /// <summary>
        /// CMLMEX.
        /// </summary>
        public const string CMLMEX = "CMLMEX";

        /// <summary>
        /// CMMCIA.
        /// </summary>
        public const string CMMCIA = "CMMCIA";

        /// <summary>
        /// CMCSDT.
        /// </summary>
        public const string CMCSDT = "CMCSDT";

        /// <summary>
        /// CMCDTE.
        /// </summary>
        public const string CMCDTE = "CMCDTE";

        /// <summary>
        /// CMUSD1.
        /// </summary>
        public const string CMUSD1 = "CMUSD1";

        /// <summary>
        /// CMUSD2.
        /// </summary>
        public const string CMUSD2 = "CMUSD2";

        /// <summary>
        /// CMUSD3.
        /// </summary>
        public const string CMUSD3 = "CMUSD3";

        /// <summary>
        /// CMUSD4.
        /// </summary>
        public const string CMUSD4 = "CMUSD4";

        /// <summary>
        /// CMUSD5.
        /// </summary>
        public const string CMUSD5 = "CMUSD5";

        /// <summary>
        /// CMUSD6.
        /// </summary>
        public const string CMUSD6 = "CMUSD6";

        /// <summary>
        /// CMUSD7.
        /// </summary>
        public const string CMUSD7 = "CMUSD7";

        /// <summary>
        /// CMUSD8.
        /// </summary>
        public const string CMUSD8 = "CMUSD8";

        /// <summary>
        /// CMUSD9.
        /// </summary>
        public const string CMUSD9 = "CMUSD9";

        /// <summary>
        /// CMAI01.
        /// </summary>
        public const string CMAI01 = "CMAI01";

        /// <summary>
        /// CMAI02.
        /// </summary>
        public const string CMAI02 = "CMAI02";

        /// <summary>
        /// CMAI03.
        /// </summary>
        public const string CMAI03 = "CMAI03";

        /// <summary>
        /// CMAI04.
        /// </summary>
        public const string CMAI04 = "CMAI04";

        /// <summary>
        /// CMAI05.
        /// </summary>
        public const string CMAI05 = "CMAI05";

        /// <summary>
        /// CMAI06.
        /// </summary>
        public const string CMAI06 = "CMAI06";

        /// <summary>
        /// CMAI07.
        /// </summary>
        public const string CMAI07 = "CMAI07";

        /// <summary>
        /// CMAI08.
        /// </summary>
        public const string CMAI08 = "CMAI08";

        /// <summary>
        /// CMAI09.
        /// </summary>
        public const string CMAI09 = "CMAI09";

        /// <summary>
        /// CMAI10.
        /// </summary>
        public const string CMAI10 = "CMAI10";

        /// <summary>
        /// CMAI11.
        /// </summary>
        public const string CMAI11 = "CMAI11";

        /// <summary>
        /// CMAI12.
        /// </summary>
        public const string CMAI12 = "CMAI12";

        /// <summary>
        /// CMAI13.
        /// </summary>
        public const string CMAI13 = "CMAI13";

        /// <summary>
        /// CMAI14.
        /// </summary>
        public const string CMAI14 = "CMAI14";

        /// <summary>
        /// CMAI15.
        /// </summary>
        public const string CMAI15 = "CMAI15";

        /// <summary>
        /// CMAI16.
        /// </summary>
        public const string CMAI16 = "CMAI16";

        /// <summary>
        /// CMAI17.
        /// </summary>
        public const string CMAI17 = "CMAI17";

        /// <summary>
        /// CMAI18.
        /// </summary>
        public const string CMAI18 = "CMAI18";

        /// <summary>
        /// CMAI19.
        /// </summary>
        public const string CMAI19 = "CMAI19";

        /// <summary>
        /// CMAI20.
        /// </summary>
        public const string CMAI20 = "CMAI20";

        /// <summary>
        /// CMCRR.
        /// </summary>
        public const string CMCRR = "CMCRR";

        /// <summary>
        /// CMCRRD.
        /// </summary>
        public const string CMCRRD = "CMCRRD";

        /// <summary>
        /// CMCTF2.
        /// </summary>
        public const string CMCTF2 = "CMCTF2";

        /// <summary>
        /// CMCTF3.
        /// </summary>
        public const string CMCTF3 = "CMCTF3";

        /// <summary>
        /// CMCTF4.
        /// </summary>
        public const string CMCTF4 = "CMCTF4";

        /// <summary>
        /// CMCTF5.
        /// </summary>
        public const string CMCTF5 = "CMCTF5";

        /// <summary>
        /// CMBCTK.
        /// </summary>
        public const string CMBCTK = "CMBCTK";

        /// <summary>
        /// CMCLNU.
        /// </summary>
        public const string CMCLNU = "CMCLNU";

        /// <summary>
        /// CMCLTT.
        /// </summary>
        public const string CMCLTT = "CMCLTT";

        /// <summary>
        /// CMCLKO.
        /// </summary>
        public const string CMCLKO = "CMCLKO";

        /// <summary>
        /// CMFCCM.
        /// </summary>
        public const string CMFCCM = "CMFCCM";

        /// <summary>
        /// CMBURTC.
        /// </summary>
        public const string CMBURTC = "CMBURTC";

        /// <summary>
        /// CMCCFLG.
        /// </summary>
        public const string CMCCFLG = "CMCCFLG";

        /// <summary>
        /// CMBURTAC.
        /// </summary>
        public const string CMBURTAC = "CMBURTAC";

        /// <summary>
        /// CMACFLG.
        /// </summary>
        public const string CMACFLG = "CMACFLG";

        /// <summary>
        /// CMBURTI.
        /// </summary>
        public const string CMBURTI = "CMBURTI";

        /// <summary>
        /// CMICFLG.
        /// </summary>
        public const string CMICFLG = "CMICFLG";

        /// <summary>
        /// CMBURTR.
        /// </summary>
        public const string CMBURTR = "CMBURTR";

        /// <summary>
        /// CMRCFLG.
        /// </summary>
        public const string CMRCFLG = "CMRCFLG";

        /// <summary>
        /// CMTOCC.
        /// </summary>
        public const string CMTOCC = "CMTOCC";

        /// <summary>
        /// CMTOCS.
        /// </summary>
        public const string CMTOCS = "CMTOCS";

        /// <summary>
        /// CMPRCO.
        /// </summary>
        public const string CMPRCO = "CMPRCO";

        /// <summary>
        /// CMOWOR.
        /// </summary>
        public const string CMOWOR = "CMOWOR";

        /// <summary>
        /// CMPOPF.
        /// </summary>
        public const string CMPOPF = "CMPOPF";

        /// <summary>
        /// CMPOPT.
        /// </summary>
        public const string CMPOPT = "CMPOPT";

        /// <summary>
        /// CMEPOP.
        /// </summary>
        public const string CMEPOP = "CMEPOP";

        /// <summary>
        /// CMPOTA.
        /// </summary>
        public const string CMPOTA = "CMPOTA";

        /// <summary>
        /// CMAWCOST.
        /// </summary>
        public const string CMAWCOST = "CMAWCOST";

        /// <summary>
        /// CMAWFE.
        /// </summary>
        public const string CMAWFE = "CMAWFE";

        /// <summary>
        /// CMAWAFE.
        /// </summary>
        public const string CMAWAFE = "CMAWAFE";

        /// <summary>
        /// CMFUNDC.
        /// </summary>
        public const string CMFUNDC = "CMFUNDC";

        /// <summary>
        /// CMFUNF.
        /// </summary>
        public const string CMFUNF = "CMFUNF";

        /// <summary>
        /// CMFUNAF.
        /// </summary>
        public const string CMFUNAF = "CMFUNAF";

        /// <summary>
        /// CMRICO.
        /// </summary>
        public const string CMRICO = "CMRICO";

        /// <summary>
        /// CMRIFE.
        /// </summary>
        public const string CMRIFE = "CMRIFE";

        /// <summary>
        /// CMRIAWF.
        /// </summary>
        public const string CMRIAWF = "CMRIAWF";

        /// <summary>
        /// CMRETMX.
        /// </summary>
        public const string CMRETMX = "CMRETMX";

        /// <summary>
        /// CMPOTAF.
        /// </summary>
        public const string CMPOTAF = "CMPOTAF";

        /// <summary>
        /// CMAWCOSTF.
        /// </summary>
        public const string CMAWCOSTF = "CMAWCOSTF";

        /// <summary>
        /// CMAWFEF.
        /// </summary>
        public const string CMAWFEF = "CMAWFEF";

        /// <summary>
        /// CMAWAFEF.
        /// </summary>
        public const string CMAWAFEF = "CMAWAFEF";

        /// <summary>
        /// CMFUNDCF.
        /// </summary>
        public const string CMFUNDCF = "CMFUNDCF";

        /// <summary>
        /// CMFUNFF.
        /// </summary>
        public const string CMFUNFF = "CMFUNFF";

        /// <summary>
        /// CMFUNAFF.
        /// </summary>
        public const string CMFUNAFF = "CMFUNAFF";

        /// <summary>
        /// CMRICOF.
        /// </summary>
        public const string CMRICOF = "CMRICOF";

        /// <summary>
        /// CMRIFEF.
        /// </summary>
        public const string CMRIFEF = "CMRIFEF";

        /// <summary>
        /// CMRIAWFF.
        /// </summary>
        public const string CMRIAWFF = "CMRIAWFF";

        /// <summary>
        /// CMRETMXF.
        /// </summary>
        public const string CMRETMXF = "CMRETMXF";

        /// <summary>
        /// CMBILLST.
        /// </summary>
        public const string CMBILLST = "CMBILLST";

        /// <summary>
        /// CMBILLMET.
        /// </summary>
        public const string CMBILLMET = "CMBILLMET";

        /// <summary>
        /// CMBILLFRE.
        /// </summary>
        public const string CMBILLFRE = "CMBILLFRE";

        /// <summary>
        /// CMBILLLIM.
        /// </summary>
        public const string CMBILLLIM = "CMBILLLIM";

        /// <summary>
        /// CMBILLGRP.
        /// </summary>
        public const string CMBILLGRP = "CMBILLGRP";

        /// <summary>
        /// CMBILLOVT.
        /// </summary>
        public const string CMBILLOVT = "CMBILLOVT";

        /// <summary>
        /// CMREVST.
        /// </summary>
        public const string CMREVST = "CMREVST";

        /// <summary>
        /// CMREVMET.
        /// </summary>
        public const string CMREVMET = "CMREVMET";

        /// <summary>
        /// CMREVLIM.
        /// </summary>
        public const string CMREVLIM = "CMREVLIM";

        /// <summary>
        /// CMCAB1.
        /// </summary>
        public const string CMCAB1 = "CMCAB1";

        /// <summary>
        /// CMCAB2.
        /// </summary>
        public const string CMCAB2 = "CMCAB2";

        /// <summary>
        /// CMCAB3.
        /// </summary>
        public const string CMCAB3 = "CMCAB3";

        /// <summary>
        /// CMCAB4.
        /// </summary>
        public const string CMCAB4 = "CMCAB4";

        /// <summary>
        /// CMCAB5.
        /// </summary>
        public const string CMCAB5 = "CMCAB5";

        /// <summary>
        /// CMCAB6.
        /// </summary>
        public const string CMCAB6 = "CMCAB6";

        /// <summary>
        /// CMCAB7.
        /// </summary>
        public const string CMCAB7 = "CMCAB7";

        /// <summary>
        /// CMCAB8.
        /// </summary>
        public const string CMCAB8 = "CMCAB8";

        /// <summary>
        /// CMCAB9.
        /// </summary>
        public const string CMCAB9 = "CMCAB9";

        /// <summary>
        /// CMCAB10.
        /// </summary>
        public const string CMCAB10 = "CMCAB10";

        /// <summary>
        /// CMCAB11.
        /// </summary>
        public const string CMCAB11 = "CMCAB11";

        /// <summary>
        /// CMCAB12.
        /// </summary>
        public const string CMCAB12 = "CMCAB12";

        /// <summary>
        /// CMCAB13.
        /// </summary>
        public const string CMCAB13 = "CMCAB13";

        /// <summary>
        /// CMCAB14.
        /// </summary>
        public const string CMCAB14 = "CMCAB14";

        /// <summary>
        /// CMCAB15.
        /// </summary>
        public const string CMCAB15 = "CMCAB15";

        /// <summary>
        /// CMCLCA.
        /// </summary>
        public const string CMCLCA = "CMCLCA";

        /// <summary>
        /// CMSUBLAB.
        /// </summary>
        public const string CMSUBLAB = "CMSUBLAB";

        /// <summary>
        /// CMALLEV.
        /// </summary>
        public const string CMALLEV = "CMALLEV";

        /// <summary>
        /// CMALDES.
        /// </summary>
        public const string CMALDES = "CMALDES";

        /// <summary>
        /// CMACRNCF.
        /// </summary>
        public const string CMACRNCF = "CMACRNCF";

        /// <summary>
        /// CMACRNAF.
        /// </summary>
        public const string CMACRNAF = "CMACRNAF";

        /// <summary>
        /// CMGOVPR.
        /// </summary>
        public const string CMGOVPR = "CMGOVPR";

        /// <summary>
        /// CMLOER.
        /// </summary>
        public const string CMLOER = "CMLOER";

        /// <summary>
        /// CMTHRS.
        /// </summary>
        public const string CMTHRS = "CMTHRS";

        /// <summary>
        /// CMVARP.
        /// </summary>
        public const string CMVARP = "CMVARP";

        /// <summary>
        /// CMSECOA.
        /// </summary>
        public const string CMSECOA = "CMSECOA";

        /// <summary>
        /// CMDABA.
        /// </summary>
        public const string CMDABA = "CMDABA";

        /// <summary>
        /// CMCASCO.
        /// </summary>
        public const string CMCASCO = "CMCASCO";

        /// <summary>
        /// CMTINACO.
        /// </summary>
        public const string CMTINACO = "CMTINACO";

        /// <summary>
        /// CMFDCL.
        /// </summary>
        public const string CMFDCL = "CMFDCL";

        /// <summary>
        /// CMQCOPR.
        /// </summary>
        public const string CMQCOPR = "CMQCOPR";

        /// <summary>
        /// CMKEYP.
        /// </summary>
        public const string CMKEYP = "CMKEYP";

        /// <summary>
        /// CMVTGR.
        /// </summary>
        public const string CMVTGR = "CMVTGR";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G01M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMDOCO", "CMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CMDCTO", "CMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CMKCOO", "CMKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CMGCSE", "CMGCSE", JdeDataType.Numeric, null, true, true),
        new JdeField("CMMODNU", "CMMODNU", JdeDataType.String, 20),
        new JdeField("CMMODREV", "CMMODREV", JdeDataType.String, 6),
        new JdeField("CMMODTY", "CMMODTY", JdeDataType.String, 2),
        new JdeField("CMMODDT", "CMMODDT", JdeDataType.Numeric),
        new JdeField("CMMODDE", "CMMODDE", JdeDataType.String, 60),
        new JdeField("CMMODGL", "CMMODGL", JdeDataType.Numeric),
        new JdeField("CMDL01", "CMDL01", JdeDataType.String, 60),
        new JdeField("CMDC", "CMDC", JdeDataType.String, 80),
        new JdeField("CMDL02", "CMDL02", JdeDataType.String, 60),
        new JdeField("CMDL03", "CMDL03", JdeDataType.String, 60),
        new JdeField("CMODCM", "CMODCM", JdeDataType.String, 50),
        new JdeField("CMOCNC", "CMOCNC", JdeDataType.String, 40),
        new JdeField("CMAN8O", "CMAN8O", JdeDataType.Numeric),
        new JdeField("CMMCIF", "CMMCIF", JdeDataType.Numeric),
        new JdeField("CMNTEF", "CMNTEF", JdeDataType.Numeric),
        new JdeField("CMRCTL", "CMRCTL", JdeDataType.String, 2),
        new JdeField("CMANOB", "CMANOB", JdeDataType.Numeric),
        new JdeField("CMADCM", "CMADCM", JdeDataType.String, 50),
        new JdeField("CMAN8K", "CMAN8K", JdeDataType.Numeric),
        new JdeField("CMUSA1", "CMUSA1", JdeDataType.Numeric),
        new JdeField("CMUSA2", "CMUSA2", JdeDataType.Numeric),
        new JdeField("CMUSA3", "CMUSA3", JdeDataType.Numeric),
        new JdeField("CMUSA4", "CMUSA4", JdeDataType.Numeric),
        new JdeField("CMUSA5", "CMUSA5", JdeDataType.Numeric),
        new JdeField("CMDS", "CMDS", JdeDataType.String, 4),
        new JdeField("CMCT", "CMCT", JdeDataType.String, 8),
        new JdeField("CMMCUS", "CMMCUS", JdeDataType.String, 24),
        new JdeField("CMJMCU", "CMJMCU", JdeDataType.String, 24),
        new JdeField("CMCO", "CMCO", JdeDataType.String, 10),
        new JdeField("CMPCTN", "CMPCTN", JdeDataType.Numeric),
        new JdeField("CMPCTT", "CMPCTT", JdeDataType.String, 4),
        new JdeField("CMPCKO", "CMPCKO", JdeDataType.String, 10),
        new JdeField("CMRTNR", "CMRTNR", JdeDataType.String, 6),
        new JdeField("CMRGLC", "CMRGLC", JdeDataType.String, 8),
        new JdeField("CMRTN1", "CMRTN1", JdeDataType.String, 6),
        new JdeField("CMEXR1", "CMEXR1", JdeDataType.String, 4),
        new JdeField("CMTXA1", "CMTXA1", JdeDataType.String, 20),
        new JdeField("CMINVF", "CMINVF", JdeDataType.String, 20),
        new JdeField("CMAIAB", "CMAIAB", JdeDataType.String, 2),
        new JdeField("CMCTOV", "CMCTOV", JdeDataType.String, 2),
        new JdeField("CMPTC", "CMPTC", JdeDataType.String, 6),
        new JdeField("CMBLWP", "CMBLWP", JdeDataType.String, 2),
        new JdeField("CMPYWP", "CMPYWP", JdeDataType.String, 2),
        new JdeField("CMBROV", "CMBROV", JdeDataType.String, 2),
        new JdeField("CMFSLV", "CMFSLV", JdeDataType.String, 2),
        new JdeField("CMCRCD", "CMCRCD", JdeDataType.String, 6),
        new JdeField("CMCRCF", "CMCRCF", JdeDataType.String, 6),
        new JdeField("CMCRRM", "CMCRRM", JdeDataType.String, 2),
        new JdeField("CMNTEX", "CMNTEX", JdeDataType.Numeric),
        new JdeField("CMRNTE", "CMRNTE", JdeDataType.Numeric),
        new JdeField("CMERDB", "CMERDB", JdeDataType.String, 2),
        new JdeField("CMLMEX", "CMLMEX", JdeDataType.String, 2),
        new JdeField("CMMCIA", "CMMCIA", JdeDataType.Numeric),
        new JdeField("CMCSDT", "CMCSDT", JdeDataType.Numeric),
        new JdeField("CMCDTE", "CMCDTE", JdeDataType.Numeric),
        new JdeField("CMUSD1", "CMUSD1", JdeDataType.Numeric),
        new JdeField("CMUSD2", "CMUSD2", JdeDataType.Numeric),
        new JdeField("CMUSD3", "CMUSD3", JdeDataType.Numeric),
        new JdeField("CMUSD4", "CMUSD4", JdeDataType.Numeric),
        new JdeField("CMUSD5", "CMUSD5", JdeDataType.Numeric),
        new JdeField("CMUSD6", "CMUSD6", JdeDataType.Numeric),
        new JdeField("CMUSD7", "CMUSD7", JdeDataType.Numeric),
        new JdeField("CMUSD8", "CMUSD8", JdeDataType.Numeric),
        new JdeField("CMUSD9", "CMUSD9", JdeDataType.Numeric),
        new JdeField("CMAI01", "CMAI01", JdeDataType.String, 6),
        new JdeField("CMAI02", "CMAI02", JdeDataType.String, 6),
        new JdeField("CMAI03", "CMAI03", JdeDataType.String, 6),
        new JdeField("CMAI04", "CMAI04", JdeDataType.String, 6),
        new JdeField("CMAI05", "CMAI05", JdeDataType.String, 6),
        new JdeField("CMAI06", "CMAI06", JdeDataType.String, 6),
        new JdeField("CMAI07", "CMAI07", JdeDataType.String, 6),
        new JdeField("CMAI08", "CMAI08", JdeDataType.String, 6),
        new JdeField("CMAI09", "CMAI09", JdeDataType.String, 6),
        new JdeField("CMAI10", "CMAI10", JdeDataType.String, 6),
        new JdeField("CMAI11", "CMAI11", JdeDataType.String, 20),
        new JdeField("CMAI12", "CMAI12", JdeDataType.String, 20),
        new JdeField("CMAI13", "CMAI13", JdeDataType.String, 20),
        new JdeField("CMAI14", "CMAI14", JdeDataType.String, 20),
        new JdeField("CMAI15", "CMAI15", JdeDataType.String, 20),
        new JdeField("CMAI16", "CMAI16", JdeDataType.String, 20),
        new JdeField("CMAI17", "CMAI17", JdeDataType.String, 20),
        new JdeField("CMAI18", "CMAI18", JdeDataType.String, 20),
        new JdeField("CMAI19", "CMAI19", JdeDataType.String, 20),
        new JdeField("CMAI20", "CMAI20", JdeDataType.String, 20),
        new JdeField("CMCRR", "CMCRR", JdeDataType.Numeric),
        new JdeField("CMCRRD", "CMCRRD", JdeDataType.Numeric),
        new JdeField("CMCTF2", "CMCTF2", JdeDataType.String, 2),
        new JdeField("CMCTF3", "CMCTF3", JdeDataType.String, 2),
        new JdeField("CMCTF4", "CMCTF4", JdeDataType.String, 2),
        new JdeField("CMCTF5", "CMCTF5", JdeDataType.String, 2),
        new JdeField("CMBCTK", "CMBCTK", JdeDataType.String, 20),
        new JdeField("CMCLNU", "CMCLNU", JdeDataType.Numeric),
        new JdeField("CMCLTT", "CMCLTT", JdeDataType.String, 4),
        new JdeField("CMCLKO", "CMCLKO", JdeDataType.String, 10),
        new JdeField("CMFCCM", "CMFCCM", JdeDataType.String, 2),
        new JdeField("CMBURTC", "CMBURTC", JdeDataType.String, 10),
        new JdeField("CMCCFLG", "CMCCFLG", JdeDataType.String, 2),
        new JdeField("CMBURTAC", "CMBURTAC", JdeDataType.String, 10),
        new JdeField("CMACFLG", "CMACFLG", JdeDataType.String, 2),
        new JdeField("CMBURTI", "CMBURTI", JdeDataType.String, 10),
        new JdeField("CMICFLG", "CMICFLG", JdeDataType.String, 2),
        new JdeField("CMBURTR", "CMBURTR", JdeDataType.String, 10),
        new JdeField("CMRCFLG", "CMRCFLG", JdeDataType.String, 2),
        new JdeField("CMTOCC", "CMTOCC", JdeDataType.String, 8),
        new JdeField("CMTOCS", "CMTOCS", JdeDataType.String, 8),
        new JdeField("CMPRCO", "CMPRCO", JdeDataType.String, 60),
        new JdeField("CMOWOR", "CMOWOR", JdeDataType.String, 24),
        new JdeField("CMPOPF", "CMPOPF", JdeDataType.Numeric),
        new JdeField("CMPOPT", "CMPOPT", JdeDataType.Numeric),
        new JdeField("CMEPOP", "CMEPOP", JdeDataType.String, 2),
        new JdeField("CMPOTA", "CMPOTA", JdeDataType.Numeric),
        new JdeField("CMAWCOST", "CMAWCOST", JdeDataType.Numeric),
        new JdeField("CMAWFE", "CMAWFE", JdeDataType.Numeric),
        new JdeField("CMAWAFE", "CMAWAFE", JdeDataType.Numeric),
        new JdeField("CMFUNDC", "CMFUNDC", JdeDataType.Numeric),
        new JdeField("CMFUNF", "CMFUNF", JdeDataType.Numeric),
        new JdeField("CMFUNAF", "CMFUNAF", JdeDataType.Numeric),
        new JdeField("CMRICO", "CMRICO", JdeDataType.Numeric),
        new JdeField("CMRIFE", "CMRIFE", JdeDataType.Numeric),
        new JdeField("CMRIAWF", "CMRIAWF", JdeDataType.Numeric),
        new JdeField("CMRETMX", "CMRETMX", JdeDataType.Numeric),
        new JdeField("CMPOTAF", "CMPOTAF", JdeDataType.Numeric),
        new JdeField("CMAWCOSTF", "CMAWCOSTF", JdeDataType.Numeric),
        new JdeField("CMAWFEF", "CMAWFEF", JdeDataType.Numeric),
        new JdeField("CMAWAFEF", "CMAWAFEF", JdeDataType.Numeric),
        new JdeField("CMFUNDCF", "CMFUNDCF", JdeDataType.Numeric),
        new JdeField("CMFUNFF", "CMFUNFF", JdeDataType.Numeric),
        new JdeField("CMFUNAFF", "CMFUNAFF", JdeDataType.Numeric),
        new JdeField("CMRICOF", "CMRICOF", JdeDataType.Numeric),
        new JdeField("CMRIFEF", "CMRIFEF", JdeDataType.Numeric),
        new JdeField("CMRIAWFF", "CMRIAWFF", JdeDataType.Numeric),
        new JdeField("CMRETMXF", "CMRETMXF", JdeDataType.Numeric),
        new JdeField("CMBILLST", "CMBILLST", JdeDataType.String, 2),
        new JdeField("CMBILLMET", "CMBILLMET", JdeDataType.String, 2),
        new JdeField("CMBILLFRE", "CMBILLFRE", JdeDataType.String, 6),
        new JdeField("CMBILLLIM", "CMBILLLIM", JdeDataType.String, 2),
        new JdeField("CMBILLGRP", "CMBILLGRP", JdeDataType.String, 6),
        new JdeField("CMBILLOVT", "CMBILLOVT", JdeDataType.String, 2),
        new JdeField("CMREVST", "CMREVST", JdeDataType.String, 2),
        new JdeField("CMREVMET", "CMREVMET", JdeDataType.String, 2),
        new JdeField("CMREVLIM", "CMREVLIM", JdeDataType.String, 2),
        new JdeField("CMCAB1", "CMCAB1", JdeDataType.Numeric),
        new JdeField("CMCAB2", "CMCAB2", JdeDataType.Numeric),
        new JdeField("CMCAB3", "CMCAB3", JdeDataType.Numeric),
        new JdeField("CMCAB4", "CMCAB4", JdeDataType.Numeric),
        new JdeField("CMCAB5", "CMCAB5", JdeDataType.Numeric),
        new JdeField("CMCAB6", "CMCAB6", JdeDataType.Numeric),
        new JdeField("CMCAB7", "CMCAB7", JdeDataType.Numeric),
        new JdeField("CMCAB8", "CMCAB8", JdeDataType.Numeric),
        new JdeField("CMCAB9", "CMCAB9", JdeDataType.Numeric),
        new JdeField("CMCAB10", "CMCAB10", JdeDataType.Numeric),
        new JdeField("CMCAB11", "CMCAB11", JdeDataType.Numeric),
        new JdeField("CMCAB12", "CMCAB12", JdeDataType.Numeric),
        new JdeField("CMCAB13", "CMCAB13", JdeDataType.Numeric),
        new JdeField("CMCAB14", "CMCAB14", JdeDataType.Numeric),
        new JdeField("CMCAB15", "CMCAB15", JdeDataType.Numeric),
        new JdeField("CMCLCA", "CMCLCA", JdeDataType.String, 2),
        new JdeField("CMSUBLAB", "CMSUBLAB", JdeDataType.String, 2),
        new JdeField("CMALLEV", "CMALLEV", JdeDataType.String, 2),
        new JdeField("CMALDES", "CMALDES", JdeDataType.String, 24),
        new JdeField("CMACRNCF", "CMACRNCF", JdeDataType.String, 2),
        new JdeField("CMACRNAF", "CMACRNAF", JdeDataType.String, 2),
        new JdeField("CMGOVPR", "CMGOVPR", JdeDataType.String, 20),
        new JdeField("CMLOER", "CMLOER", JdeDataType.String, 2),
        new JdeField("CMTHRS", "CMTHRS", JdeDataType.Numeric),
        new JdeField("CMVARP", "CMVARP", JdeDataType.Numeric),
        new JdeField("CMSECOA", "CMSECOA", JdeDataType.String, 2),
        new JdeField("CMDABA", "CMDABA", JdeDataType.String, 2),
        new JdeField("CMCASCO", "CMCASCO", JdeDataType.String, 2),
        new JdeField("CMTINACO", "CMTINACO", JdeDataType.String, 2),
        new JdeField("CMFDCL", "CMFDCL", JdeDataType.String, 2),
        new JdeField("CMQCOPR", "CMQCOPR", JdeDataType.String, 2),
        new JdeField("CMKEYP", "CMKEYP", JdeDataType.String, 2),
        new JdeField("CMVTGR", "CMVTGR", JdeDataType.String, 2),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G01M_0", "Primary Key on CMDOCO, CMDCTO, CMKCOO, CMGCSE", new[] { "CMDOCO", "CMDCTO", "CMKCOO", "CMGCSE" }, isUnique: true, isPrimaryKey: true)
    };
}
