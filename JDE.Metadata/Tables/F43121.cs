using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43121 - .
/// </summary>
public class F43121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRMATC.
        /// </summary>
        public const string PRMATC = "PRMATC";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRKCOO.
        /// </summary>
        public const string PRKCOO = "PRKCOO";

        /// <summary>
        /// PRDOCO.
        /// </summary>
        public const string PRDOCO = "PRDOCO";

        /// <summary>
        /// PRDCTO.
        /// </summary>
        public const string PRDCTO = "PRDCTO";

        /// <summary>
        /// PRSFXO.
        /// </summary>
        public const string PRSFXO = "PRSFXO";

        /// <summary>
        /// PRLNID.
        /// </summary>
        public const string PRLNID = "PRLNID";

        /// <summary>
        /// PRNLIN.
        /// </summary>
        public const string PRNLIN = "PRNLIN";

        /// <summary>
        /// PRALIN.
        /// </summary>
        public const string PRALIN = "PRALIN";

        /// <summary>
        /// PRRTBY.
        /// </summary>
        public const string PRRTBY = "PRRTBY";

        /// <summary>
        /// PRDMCT.
        /// </summary>
        public const string PRDMCT = "PRDMCT";

        /// <summary>
        /// PRDMCS.
        /// </summary>
        public const string PRDMCS = "PRDMCS";

        /// <summary>
        /// PRBALU.
        /// </summary>
        public const string PRBALU = "PRBALU";

        /// <summary>
        /// PRITM.
        /// </summary>
        public const string PRITM = "PRITM";

        /// <summary>
        /// PRLITM.
        /// </summary>
        public const string PRLITM = "PRLITM";

        /// <summary>
        /// PRAITM.
        /// </summary>
        public const string PRAITM = "PRAITM";

        /// <summary>
        /// PRIMCU.
        /// </summary>
        public const string PRIMCU = "PRIMCU";

        /// <summary>
        /// PRLOCN.
        /// </summary>
        public const string PRLOCN = "PRLOCN";

        /// <summary>
        /// PRLOTN.
        /// </summary>
        public const string PRLOTN = "PRLOTN";

        /// <summary>
        /// PRLOTG.
        /// </summary>
        public const string PRLOTG = "PRLOTG";

        /// <summary>
        /// PRLOTP.
        /// </summary>
        public const string PRLOTP = "PRLOTP";

        /// <summary>
        /// PRVRMK.
        /// </summary>
        public const string PRVRMK = "PRVRMK";

        /// <summary>
        /// PRCNID.
        /// </summary>
        public const string PRCNID = "PRCNID";

        /// <summary>
        /// PRNXTR.
        /// </summary>
        public const string PRNXTR = "PRNXTR";

        /// <summary>
        /// PRLTTR.
        /// </summary>
        public const string PRLTTR = "PRLTTR";

        /// <summary>
        /// PRTRDJ.
        /// </summary>
        public const string PRTRDJ = "PRTRDJ";

        /// <summary>
        /// PRRCDJ.
        /// </summary>
        public const string PRRCDJ = "PRRCDJ";

        /// <summary>
        /// PRDRQJ.
        /// </summary>
        public const string PRDRQJ = "PRDRQJ";

        /// <summary>
        /// PRPDDJ.
        /// </summary>
        public const string PRPDDJ = "PRPDDJ";

        /// <summary>
        /// PROPDJ.
        /// </summary>
        public const string PROPDJ = "PROPDJ";

        /// <summary>
        /// PRRCD.
        /// </summary>
        public const string PRRCD = "PRRCD";

        /// <summary>
        /// PRVINV.
        /// </summary>
        public const string PRVINV = "PRVINV";

        /// <summary>
        /// PRPTC.
        /// </summary>
        public const string PRPTC = "PRPTC";

        /// <summary>
        /// PRPST.
        /// </summary>
        public const string PRPST = "PRPST";

        /// <summary>
        /// PRLAND.
        /// </summary>
        public const string PRLAND = "PRLAND";

        /// <summary>
        /// PRPRP5.
        /// </summary>
        public const string PRPRP5 = "PRPRP5";

        /// <summary>
        /// PRLVLA.
        /// </summary>
        public const string PRLVLA = "PRLVLA";

        /// <summary>
        /// PRILOG.
        /// </summary>
        public const string PRILOG = "PRILOG";

        /// <summary>
        /// PRDLOG.
        /// </summary>
        public const string PRDLOG = "PRDLOG";

        /// <summary>
        /// PRRTGC.
        /// </summary>
        public const string PRRTGC = "PRRTGC";

        /// <summary>
        /// PRRCPF.
        /// </summary>
        public const string PRRCPF = "PRRCPF";

        /// <summary>
        /// PRAVCH.
        /// </summary>
        public const string PRAVCH = "PRAVCH";

        /// <summary>
        /// PRLNTY.
        /// </summary>
        public const string PRLNTY = "PRLNTY";

        /// <summary>
        /// PRGLC.
        /// </summary>
        public const string PRGLC = "PRGLC";

        /// <summary>
        /// PRMCU.
        /// </summary>
        public const string PRMCU = "PRMCU";

        /// <summary>
        /// PRCO.
        /// </summary>
        public const string PRCO = "PRCO";

        /// <summary>
        /// PRAID.
        /// </summary>
        public const string PRAID = "PRAID";

        /// <summary>
        /// PRANI.
        /// </summary>
        public const string PRANI = "PRANI";

        /// <summary>
        /// PROMCU.
        /// </summary>
        public const string PROMCU = "PROMCU";

        /// <summary>
        /// PROBJ.
        /// </summary>
        public const string PROBJ = "PROBJ";

        /// <summary>
        /// PRSUB.
        /// </summary>
        public const string PRSUB = "PRSUB";

        /// <summary>
        /// PRASID.
        /// </summary>
        public const string PRASID = "PRASID";

        /// <summary>
        /// PRSBL.
        /// </summary>
        public const string PRSBL = "PRSBL";

        /// <summary>
        /// PRSBLT.
        /// </summary>
        public const string PRSBLT = "PRSBLT";

        /// <summary>
        /// PRKCO.
        /// </summary>
        public const string PRKCO = "PRKCO";

        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRDCT.
        /// </summary>
        public const string PRDCT = "PRDCT";

        /// <summary>
        /// PRSFX.
        /// </summary>
        public const string PRSFX = "PRSFX";

        /// <summary>
        /// PRDGL.
        /// </summary>
        public const string PRDGL = "PRDGL";

        /// <summary>
        /// PRJELN.
        /// </summary>
        public const string PRJELN = "PRJELN";

        /// <summary>
        /// PRVANI.
        /// </summary>
        public const string PRVANI = "PRVANI";

        /// <summary>
        /// PRTX.
        /// </summary>
        public const string PRTX = "PRTX";

        /// <summary>
        /// PREXR1.
        /// </summary>
        public const string PREXR1 = "PREXR1";

        /// <summary>
        /// PRTXA1.
        /// </summary>
        public const string PRTXA1 = "PRTXA1";

        /// <summary>
        /// PRUOM.
        /// </summary>
        public const string PRUOM = "PRUOM";

        /// <summary>
        /// PRUORG.
        /// </summary>
        public const string PRUORG = "PRUORG";

        /// <summary>
        /// PRUPTD.
        /// </summary>
        public const string PRUPTD = "PRUPTD";

        /// <summary>
        /// PRUOPN.
        /// </summary>
        public const string PRUOPN = "PRUOPN";

        /// <summary>
        /// PRUREC.
        /// </summary>
        public const string PRUREC = "PRUREC";

        /// <summary>
        /// PRUCLO.
        /// </summary>
        public const string PRUCLO = "PRUCLO";

        /// <summary>
        /// PRQTYS.
        /// </summary>
        public const string PRQTYS = "PRQTYS";

        /// <summary>
        /// PRQTYR.
        /// </summary>
        public const string PRQTYR = "PRQTYR";

        /// <summary>
        /// PRQTYW.
        /// </summary>
        public const string PRQTYW = "PRQTYW";

        /// <summary>
        /// PRQTYC.
        /// </summary>
        public const string PRQTYC = "PRQTYC";

        /// <summary>
        /// PRQTYJ.
        /// </summary>
        public const string PRQTYJ = "PRQTYJ";

        /// <summary>
        /// PRQTYA.
        /// </summary>
        public const string PRQTYA = "PRQTYA";

        /// <summary>
        /// PRUOM3.
        /// </summary>
        public const string PRUOM3 = "PRUOM3";

        /// <summary>
        /// PRPRRC.
        /// </summary>
        public const string PRPRRC = "PRPRRC";

        /// <summary>
        /// PRECST.
        /// </summary>
        public const string PRECST = "PRECST";

        /// <summary>
        /// PRAPTD.
        /// </summary>
        public const string PRAPTD = "PRAPTD";

        /// <summary>
        /// PRAOPN.
        /// </summary>
        public const string PRAOPN = "PRAOPN";

        /// <summary>
        /// PRAREC.
        /// </summary>
        public const string PRAREC = "PRAREC";

        /// <summary>
        /// PRACLO.
        /// </summary>
        public const string PRACLO = "PRACLO";

        /// <summary>
        /// PRAVCO.
        /// </summary>
        public const string PRAVCO = "PRAVCO";

        /// <summary>
        /// PRVARC.
        /// </summary>
        public const string PRVARC = "PRVARC";

        /// <summary>
        /// PRCRCD.
        /// </summary>
        public const string PRCRCD = "PRCRCD";

        /// <summary>
        /// PRCRR.
        /// </summary>
        public const string PRCRR = "PRCRR";

        /// <summary>
        /// PRFRRC.
        /// </summary>
        public const string PRFRRC = "PRFRRC";

        /// <summary>
        /// PRFEC.
        /// </summary>
        public const string PRFEC = "PRFEC";

        /// <summary>
        /// PRFAP.
        /// </summary>
        public const string PRFAP = "PRFAP";

        /// <summary>
        /// PRFAPT.
        /// </summary>
        public const string PRFAPT = "PRFAPT";

        /// <summary>
        /// PRFREC.
        /// </summary>
        public const string PRFREC = "PRFREC";

        /// <summary>
        /// PRFCLO.
        /// </summary>
        public const string PRFCLO = "PRFCLO";

        /// <summary>
        /// PRURCD.
        /// </summary>
        public const string PRURCD = "PRURCD";

        /// <summary>
        /// PRURDT.
        /// </summary>
        public const string PRURDT = "PRURDT";

        /// <summary>
        /// PRURAT.
        /// </summary>
        public const string PRURAT = "PRURAT";

        /// <summary>
        /// PRURAB.
        /// </summary>
        public const string PRURAB = "PRURAB";

        /// <summary>
        /// PRURRF.
        /// </summary>
        public const string PRURRF = "PRURRF";

        /// <summary>
        /// PRTORG.
        /// </summary>
        public const string PRTORG = "PRTORG";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRTERM.
        /// </summary>
        public const string PRTERM = "PRTERM";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRTDAY.
        /// </summary>
        public const string PRTDAY = "PRTDAY";

        /// <summary>
        /// PRBCRC.
        /// </summary>
        public const string PRBCRC = "PRBCRC";

        /// <summary>
        /// PRSTAM.
        /// </summary>
        public const string PRSTAM = "PRSTAM";

        /// <summary>
        /// PRCTAM.
        /// </summary>
        public const string PRCTAM = "PRCTAM";

        /// <summary>
        /// PRMACT.
        /// </summary>
        public const string PRMACT = "PRMACT";

        /// <summary>
        /// PRPLT.
        /// </summary>
        public const string PRPLT = "PRPLT";

        /// <summary>
        /// PRPAK.
        /// </summary>
        public const string PRPAK = "PRPAK";

        /// <summary>
        /// PRSCCN.
        /// </summary>
        public const string PRSCCN = "PRSCCN";

        /// <summary>
        /// PRSCCQ.
        /// </summary>
        public const string PRSCCQ = "PRSCCQ";

        /// <summary>
        /// PRSCUM.
        /// </summary>
        public const string PRSCUM = "PRSCUM";

        /// <summary>
        /// PRUPCN.
        /// </summary>
        public const string PRUPCN = "PRUPCN";

        /// <summary>
        /// PRUPQT.
        /// </summary>
        public const string PRUPQT = "PRUPQT";

        /// <summary>
        /// PRUPUM.
        /// </summary>
        public const string PRUPUM = "PRUPUM";

        /// <summary>
        /// PRSHPN.
        /// </summary>
        public const string PRSHPN = "PRSHPN";

        /// <summary>
        /// PRVR01.
        /// </summary>
        public const string PRVR01 = "PRVR01";

        /// <summary>
        /// PRVR02.
        /// </summary>
        public const string PRVR02 = "PRVR02";

        /// <summary>
        /// PRFUF3.
        /// </summary>
        public const string PRFUF3 = "PRFUF3";

        /// <summary>
        /// PRFUF4.
        /// </summary>
        public const string PRFUF4 = "PRFUF4";

        /// <summary>
        /// PRFUF5.
        /// </summary>
        public const string PRFUF5 = "PRFUF5";

        /// <summary>
        /// PRFUF6.
        /// </summary>
        public const string PRFUF6 = "PRFUF6";

        /// <summary>
        /// PRMERL.
        /// </summary>
        public const string PRMERL = "PRMERL";

        /// <summary>
        /// PRKTLN.
        /// </summary>
        public const string PRKTLN = "PRKTLN";

        /// <summary>
        /// PRCPNT.
        /// </summary>
        public const string PRCPNT = "PRCPNT";

        /// <summary>
        /// PRVR04.
        /// </summary>
        public const string PRVR04 = "PRVR04";

        /// <summary>
        /// PRVR05.
        /// </summary>
        public const string PRVR05 = "PRVR05";

        /// <summary>
        /// PRUKID.
        /// </summary>
        public const string PRUKID = "PRUKID";

        /// <summary>
        /// PRUOM2.
        /// </summary>
        public const string PRUOM2 = "PRUOM2";

        /// <summary>
        /// PRDUAL.
        /// </summary>
        public const string PRDUAL = "PRDUAL";

        /// <summary>
        /// PRSQOR.
        /// </summary>
        public const string PRSQOR = "PRSQOR";

        /// <summary>
        /// PRXDCK.
        /// </summary>
        public const string PRXDCK = "PRXDCK";

        /// <summary>
        /// PRPOE.
        /// </summary>
        public const string PRPOE = "PRPOE";

        /// <summary>
        /// PRVR03.
        /// </summary>
        public const string PRVR03 = "PRVR03";

        /// <summary>
        /// PRLDNM.
        /// </summary>
        public const string PRLDNM = "PRLDNM";

        /// <summary>
        /// PRCTSN.
        /// </summary>
        public const string PRCTSN = "PRCTSN";

        /// <summary>
        /// PRPROV.
        /// </summary>
        public const string PRPROV = "PRPROV";

        /// <summary>
        /// PRASN.
        /// </summary>
        public const string PRASN = "PRASN";

        /// <summary>
        /// PRPRFLG1.
        /// </summary>
        public const string PRPRFLG1 = "PRPRFLG1";

        /// <summary>
        /// PRPRFLG2.
        /// </summary>
        public const string PRPRFLG2 = "PRPRFLG2";

        /// <summary>
        /// PRMOADJ.
        /// </summary>
        public const string PRMOADJ = "PRMOADJ";

        /// <summary>
        /// PRPS09.
        /// </summary>
        public const string PRPS09 = "PRPS09";

        /// <summary>
        /// PRQTYPY.
        /// </summary>
        public const string PRQTYPY = "PRQTYPY";

        /// <summary>
        /// PRWVID.
        /// </summary>
        public const string PRWVID = "PRWVID";

        /// <summary>
        /// PRCNTRTID.
        /// </summary>
        public const string PRCNTRTID = "PRCNTRTID";

        /// <summary>
        /// PRCNTRTDID.
        /// </summary>
        public const string PRCNTRTDID = "PRCNTRTDID";

        /// <summary>
        /// PRREVFLG.
        /// </summary>
        public const string PRREVFLG = "PRREVFLG";

        /// <summary>
        /// PRAPPFLG.
        /// </summary>
        public const string PRAPPFLG = "PRAPPFLG";

        /// <summary>
        /// PRREVAN8.
        /// </summary>
        public const string PRREVAN8 = "PRREVAN8";

        /// <summary>
        /// PRAPPAN8.
        /// </summary>
        public const string PRAPPAN8 = "PRAPPAN8";

        /// <summary>
        /// PRWOPID.
        /// </summary>
        public const string PRWOPID = "PRWOPID";

        /// <summary>
        /// PRWVTY.
        /// </summary>
        public const string PRWVTY = "PRWVTY";

        /// <summary>
        /// PRJBCD.
        /// </summary>
        public const string PRJBCD = "PRJBCD";

        /// <summary>
        /// PRSRQTY.
        /// </summary>
        public const string PRSRQTY = "PRSRQTY";

        /// <summary>
        /// PRSRUOM.
        /// </summary>
        public const string PRSRUOM = "PRSRUOM";

        /// <summary>
        /// PRNBRU.
        /// </summary>
        public const string PRNBRU = "PRNBRU";

        /// <summary>
        /// PRNEWR.
        /// </summary>
        public const string PRNEWR = "PRNEWR";

        /// <summary>
        /// PRSRRC.
        /// </summary>
        public const string PRSRRC = "PRSRRC";

        /// <summary>
        /// PRFSRRC.
        /// </summary>
        public const string PRFSRRC = "PRFSRRC";

        /// <summary>
        /// PRPMPN.
        /// </summary>
        public const string PRPMPN = "PRPMPN";

        /// <summary>
        /// PRPNS.
        /// </summary>
        public const string PRPNS = "PRPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F43121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRMATC", "PRMATC", JdeDataType.String, 2, true, true),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric),
        new JdeField("PRKCOO", "PRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PRDOCO", "PRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCTO", "PRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PRSFXO", "PRSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PRLNID", "PRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRNLIN", "PRNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRALIN", "PRALIN", JdeDataType.Numeric),
        new JdeField("PRRTBY", "PRRTBY", JdeDataType.String, 4),
        new JdeField("PRDMCT", "PRDMCT", JdeDataType.String, 24),
        new JdeField("PRDMCS", "PRDMCS", JdeDataType.Numeric),
        new JdeField("PRBALU", "PRBALU", JdeDataType.String, 2),
        new JdeField("PRITM", "PRITM", JdeDataType.Numeric),
        new JdeField("PRLITM", "PRLITM", JdeDataType.String, 50),
        new JdeField("PRAITM", "PRAITM", JdeDataType.String, 50),
        new JdeField("PRIMCU", "PRIMCU", JdeDataType.String, 24),
        new JdeField("PRLOCN", "PRLOCN", JdeDataType.String, 40),
        new JdeField("PRLOTN", "PRLOTN", JdeDataType.String, 60),
        new JdeField("PRLOTG", "PRLOTG", JdeDataType.String, 6),
        new JdeField("PRLOTP", "PRLOTP", JdeDataType.Numeric),
        new JdeField("PRVRMK", "PRVRMK", JdeDataType.String, 60),
        new JdeField("PRCNID", "PRCNID", JdeDataType.String, 40),
        new JdeField("PRNXTR", "PRNXTR", JdeDataType.String, 6),
        new JdeField("PRLTTR", "PRLTTR", JdeDataType.String, 6),
        new JdeField("PRTRDJ", "PRTRDJ", JdeDataType.Numeric),
        new JdeField("PRRCDJ", "PRRCDJ", JdeDataType.Numeric),
        new JdeField("PRDRQJ", "PRDRQJ", JdeDataType.Numeric),
        new JdeField("PRPDDJ", "PRPDDJ", JdeDataType.Numeric),
        new JdeField("PROPDJ", "PROPDJ", JdeDataType.Numeric),
        new JdeField("PRRCD", "PRRCD", JdeDataType.String, 6),
        new JdeField("PRVINV", "PRVINV", JdeDataType.String, 50),
        new JdeField("PRPTC", "PRPTC", JdeDataType.String, 6),
        new JdeField("PRPST", "PRPST", JdeDataType.String, 2),
        new JdeField("PRLAND", "PRLAND", JdeDataType.String, 2),
        new JdeField("PRPRP5", "PRPRP5", JdeDataType.String, 6),
        new JdeField("PRLVLA", "PRLVLA", JdeDataType.String, 6),
        new JdeField("PRILOG", "PRILOG", JdeDataType.String, 2),
        new JdeField("PRDLOG", "PRDLOG", JdeDataType.String, 2),
        new JdeField("PRRTGC", "PRRTGC", JdeDataType.String, 2),
        new JdeField("PRRCPF", "PRRCPF", JdeDataType.String, 2),
        new JdeField("PRAVCH", "PRAVCH", JdeDataType.String, 2),
        new JdeField("PRLNTY", "PRLNTY", JdeDataType.String, 4),
        new JdeField("PRGLC", "PRGLC", JdeDataType.String, 8),
        new JdeField("PRMCU", "PRMCU", JdeDataType.String, 24),
        new JdeField("PRCO", "PRCO", JdeDataType.String, 10),
        new JdeField("PRAID", "PRAID", JdeDataType.String, 16),
        new JdeField("PRANI", "PRANI", JdeDataType.String, 58),
        new JdeField("PROMCU", "PROMCU", JdeDataType.String, 24),
        new JdeField("PROBJ", "PROBJ", JdeDataType.String, 12),
        new JdeField("PRSUB", "PRSUB", JdeDataType.String, 16),
        new JdeField("PRASID", "PRASID", JdeDataType.String, 50),
        new JdeField("PRSBL", "PRSBL", JdeDataType.String, 16),
        new JdeField("PRSBLT", "PRSBLT", JdeDataType.String, 2),
        new JdeField("PRKCO", "PRKCO", JdeDataType.String, 10),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCT", "PRDCT", JdeDataType.String, 4),
        new JdeField("PRSFX", "PRSFX", JdeDataType.String, 6),
        new JdeField("PRDGL", "PRDGL", JdeDataType.Numeric),
        new JdeField("PRJELN", "PRJELN", JdeDataType.Numeric),
        new JdeField("PRVANI", "PRVANI", JdeDataType.String, 58),
        new JdeField("PRTX", "PRTX", JdeDataType.String, 2),
        new JdeField("PREXR1", "PREXR1", JdeDataType.String, 4),
        new JdeField("PRTXA1", "PRTXA1", JdeDataType.String, 20),
        new JdeField("PRUOM", "PRUOM", JdeDataType.String, 4),
        new JdeField("PRUORG", "PRUORG", JdeDataType.Numeric),
        new JdeField("PRUPTD", "PRUPTD", JdeDataType.Numeric),
        new JdeField("PRUOPN", "PRUOPN", JdeDataType.Numeric),
        new JdeField("PRUREC", "PRUREC", JdeDataType.Numeric),
        new JdeField("PRUCLO", "PRUCLO", JdeDataType.Numeric),
        new JdeField("PRQTYS", "PRQTYS", JdeDataType.Numeric),
        new JdeField("PRQTYR", "PRQTYR", JdeDataType.Numeric),
        new JdeField("PRQTYW", "PRQTYW", JdeDataType.Numeric),
        new JdeField("PRQTYC", "PRQTYC", JdeDataType.Numeric),
        new JdeField("PRQTYJ", "PRQTYJ", JdeDataType.Numeric),
        new JdeField("PRQTYA", "PRQTYA", JdeDataType.Numeric),
        new JdeField("PRUOM3", "PRUOM3", JdeDataType.String, 4),
        new JdeField("PRPRRC", "PRPRRC", JdeDataType.Numeric),
        new JdeField("PRECST", "PRECST", JdeDataType.Numeric),
        new JdeField("PRAPTD", "PRAPTD", JdeDataType.Numeric),
        new JdeField("PRAOPN", "PRAOPN", JdeDataType.Numeric),
        new JdeField("PRAREC", "PRAREC", JdeDataType.Numeric),
        new JdeField("PRACLO", "PRACLO", JdeDataType.Numeric),
        new JdeField("PRAVCO", "PRAVCO", JdeDataType.Numeric),
        new JdeField("PRVARC", "PRVARC", JdeDataType.Numeric),
        new JdeField("PRCRCD", "PRCRCD", JdeDataType.String, 6),
        new JdeField("PRCRR", "PRCRR", JdeDataType.Numeric),
        new JdeField("PRFRRC", "PRFRRC", JdeDataType.Numeric),
        new JdeField("PRFEC", "PRFEC", JdeDataType.Numeric),
        new JdeField("PRFAP", "PRFAP", JdeDataType.Numeric),
        new JdeField("PRFAPT", "PRFAPT", JdeDataType.Numeric),
        new JdeField("PRFREC", "PRFREC", JdeDataType.Numeric),
        new JdeField("PRFCLO", "PRFCLO", JdeDataType.Numeric),
        new JdeField("PRURCD", "PRURCD", JdeDataType.String, 4),
        new JdeField("PRURDT", "PRURDT", JdeDataType.Numeric),
        new JdeField("PRURAT", "PRURAT", JdeDataType.Numeric),
        new JdeField("PRURAB", "PRURAB", JdeDataType.Numeric),
        new JdeField("PRURRF", "PRURRF", JdeDataType.String, 30),
        new JdeField("PRTORG", "PRTORG", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRTERM", "PRTERM", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRTDAY", "PRTDAY", JdeDataType.Numeric),
        new JdeField("PRBCRC", "PRBCRC", JdeDataType.String, 6),
        new JdeField("PRSTAM", "PRSTAM", JdeDataType.Numeric),
        new JdeField("PRCTAM", "PRCTAM", JdeDataType.Numeric),
        new JdeField("PRMACT", "PRMACT", JdeDataType.String, 2),
        new JdeField("PRPLT", "PRPLT", JdeDataType.String, 36),
        new JdeField("PRPAK", "PRPAK", JdeDataType.String, 36),
        new JdeField("PRSCCN", "PRSCCN", JdeDataType.String, 28),
        new JdeField("PRSCCQ", "PRSCCQ", JdeDataType.Numeric),
        new JdeField("PRSCUM", "PRSCUM", JdeDataType.String, 4),
        new JdeField("PRUPCN", "PRUPCN", JdeDataType.String, 26),
        new JdeField("PRUPQT", "PRUPQT", JdeDataType.Numeric),
        new JdeField("PRUPUM", "PRUPUM", JdeDataType.String, 4),
        new JdeField("PRSHPN", "PRSHPN", JdeDataType.Numeric),
        new JdeField("PRVR01", "PRVR01", JdeDataType.String, 50),
        new JdeField("PRVR02", "PRVR02", JdeDataType.String, 50),
        new JdeField("PRFUF3", "PRFUF3", JdeDataType.String, 2),
        new JdeField("PRFUF4", "PRFUF4", JdeDataType.String, 2),
        new JdeField("PRFUF5", "PRFUF5", JdeDataType.String, 2),
        new JdeField("PRFUF6", "PRFUF6", JdeDataType.String, 2),
        new JdeField("PRMERL", "PRMERL", JdeDataType.String, 6),
        new JdeField("PRKTLN", "PRKTLN", JdeDataType.Numeric),
        new JdeField("PRCPNT", "PRCPNT", JdeDataType.Numeric),
        new JdeField("PRVR04", "PRVR04", JdeDataType.String, 50),
        new JdeField("PRVR05", "PRVR05", JdeDataType.String, 50),
        new JdeField("PRUKID", "PRUKID", JdeDataType.Numeric),
        new JdeField("PRUOM2", "PRUOM2", JdeDataType.String, 4),
        new JdeField("PRDUAL", "PRDUAL", JdeDataType.String, 2),
        new JdeField("PRSQOR", "PRSQOR", JdeDataType.Numeric),
        new JdeField("PRXDCK", "PRXDCK", JdeDataType.String, 2),
        new JdeField("PRPOE", "PRPOE", JdeDataType.String, 12),
        new JdeField("PRVR03", "PRVR03", JdeDataType.String, 50),
        new JdeField("PRLDNM", "PRLDNM", JdeDataType.Numeric),
        new JdeField("PRCTSN", "PRCTSN", JdeDataType.String, 80),
        new JdeField("PRPROV", "PRPROV", JdeDataType.String, 2),
        new JdeField("PRASN", "PRASN", JdeDataType.String, 16),
        new JdeField("PRPRFLG1", "PRPRFLG1", JdeDataType.String, 2),
        new JdeField("PRPRFLG2", "PRPRFLG2", JdeDataType.String, 2),
        new JdeField("PRMOADJ", "PRMOADJ", JdeDataType.String, 2),
        new JdeField("PRPS09", "PRPS09", JdeDataType.String, 2),
        new JdeField("PRQTYPY", "PRQTYPY", JdeDataType.Numeric),
        new JdeField("PRWVID", "PRWVID", JdeDataType.Numeric),
        new JdeField("PRCNTRTID", "PRCNTRTID", JdeDataType.Numeric),
        new JdeField("PRCNTRTDID", "PRCNTRTDID", JdeDataType.Numeric),
        new JdeField("PRREVFLG", "PRREVFLG", JdeDataType.String, 2),
        new JdeField("PRAPPFLG", "PRAPPFLG", JdeDataType.String, 2),
        new JdeField("PRREVAN8", "PRREVAN8", JdeDataType.Numeric),
        new JdeField("PRAPPAN8", "PRAPPAN8", JdeDataType.Numeric),
        new JdeField("PRWOPID", "PRWOPID", JdeDataType.Numeric),
        new JdeField("PRWVTY", "PRWVTY", JdeDataType.String, 2),
        new JdeField("PRJBCD", "PRJBCD", JdeDataType.String, 12),
        new JdeField("PRSRQTY", "PRSRQTY", JdeDataType.Numeric),
        new JdeField("PRSRUOM", "PRSRUOM", JdeDataType.String, 4),
        new JdeField("PRNBRU", "PRNBRU", JdeDataType.String, 2),
        new JdeField("PRNEWR", "PRNEWR", JdeDataType.String, 2),
        new JdeField("PRSRRC", "PRSRRC", JdeDataType.Numeric),
        new JdeField("PRFSRRC", "PRFSRRC", JdeDataType.Numeric),
        new JdeField("PRPMPN", "PRPMPN", JdeDataType.String, 60),
        new JdeField("PRPNS", "PRPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43121_0", "Primary Key on PRMATC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID, PRNLIN, PRDOC", new[] { "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID", "PRNLIN", "PRDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43121_10", "Index on PRMATC, PRDOC, PRDCT, PRKCO", new[] { "PRMATC", "PRDOC", "PRDCT", "PRKCO" }),
        new JdeIndex("F43121_11", "Index on PRWOPID, PRWVTY", new[] { "PRWOPID", "PRWVTY" }),
        new JdeIndex("F43121_12", "Index on PRMATC, PRDOC, PRKCO, PRDCT, PRSFX", new[] { "PRMATC", "PRDOC", "PRKCO", "PRDCT", "PRSFX" }),
        new JdeIndex("F43121_2", "Index on PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID", new[] { "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID" }),
        new JdeIndex("F43121_3", "Index on PRDOC, PRDCT, PRKCO", new[] { "PRDOC", "PRDCT", "PRKCO" }),
        new JdeIndex("F43121_4", "Index on PRMATC, PRITM, PRMCU, PRPDDJ", new[] { "PRMATC", "PRITM", "PRMCU", "PRPDDJ" }),
        new JdeIndex("F43121_5", "Index on PRMATC, PRAN8, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRMCU, PRLNID, PRNLIN", new[] { "PRMATC", "PRAN8", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRMCU", "PRLNID", "PRNLIN" }),
        new JdeIndex("F43121_6", "Index on PRMATC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRMCU, PRLNID, PRNLIN, PRDOC", new[] { "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRMCU", "PRLNID", "PRNLIN", "PRDOC" }),
        new JdeIndex("F43121_7", "Index on PRMATC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID", new[] { "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID" }),
        new JdeIndex("F43121_8", "Index on PRVINV, PRDCT, PRKCO", new[] { "PRVINV", "PRDCT", "PRKCO" }),
        new JdeIndex("F43121_9", "Index on PRSHPN, PRMATC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID, PRNLIN, PRDOC", new[] { "PRSHPN", "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID", "PRNLIN", "PRDOC" })
    };
}
