using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R11 - .
/// </summary>
public class F54R11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDDOCO.
        /// </summary>
        public const string CDDOCO = "CDDOCO";

        /// <summary>
        /// CDDCTO.
        /// </summary>
        public const string CDDCTO = "CDDCTO";

        /// <summary>
        /// CDKCOO.
        /// </summary>
        public const string CDKCOO = "CDKCOO";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDCO.
        /// </summary>
        public const string CDCO = "CDCO";

        /// <summary>
        /// CDNUMB.
        /// </summary>
        public const string CDNUMB = "CDNUMB";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDLITM.
        /// </summary>
        public const string CDLITM = "CDLITM";

        /// <summary>
        /// CDDSC1.
        /// </summary>
        public const string CDDSC1 = "CDDSC1";

        /// <summary>
        /// CDDSC2.
        /// </summary>
        public const string CDDSC2 = "CDDSC2";

        /// <summary>
        /// CDQSLD.
        /// </summary>
        public const string CDQSLD = "CDQSLD";

        /// <summary>
        /// CD54RQTYO.
        /// </summary>
        public const string CD54RQTYO = "CD54RQTYO";

        /// <summary>
        /// CD54RQTYS.
        /// </summary>
        public const string CD54RQTYS = "CD54RQTYS";

        /// <summary>
        /// CD54RQTYW.
        /// </summary>
        public const string CD54RQTYW = "CD54RQTYW";

        /// <summary>
        /// CD54RQTYJ.
        /// </summary>
        public const string CD54RQTYJ = "CD54RQTYJ";

        /// <summary>
        /// CD54RQTYC.
        /// </summary>
        public const string CD54RQTYC = "CD54RQTYC";

        /// <summary>
        /// CD54RQTYR.
        /// </summary>
        public const string CD54RQTYR = "CD54RQTYR";

        /// <summary>
        /// CDUOM.
        /// </summary>
        public const string CDUOM = "CDUOM";

        /// <summary>
        /// CDLOCN.
        /// </summary>
        public const string CDLOCN = "CDLOCN";

        /// <summary>
        /// CDLOTN.
        /// </summary>
        public const string CDLOTN = "CDLOTN";

        /// <summary>
        /// CDLNTY.
        /// </summary>
        public const string CDLNTY = "CDLNTY";

        /// <summary>
        /// CD54RIC.
        /// </summary>
        public const string CD54RIC = "CD54RIC";

        /// <summary>
        /// CD54RPM.
        /// </summary>
        public const string CD54RPM = "CD54RPM";

        /// <summary>
        /// CDCRMCU.
        /// </summary>
        public const string CDCRMCU = "CDCRMCU";

        /// <summary>
        /// CDEMCU.
        /// </summary>
        public const string CDEMCU = "CDEMCU";

        /// <summary>
        /// CDRLIT.
        /// </summary>
        public const string CDRLIT = "CDRLIT";

        /// <summary>
        /// CDKTLN.
        /// </summary>
        public const string CDKTLN = "CDKTLN";

        /// <summary>
        /// CDCPNT.
        /// </summary>
        public const string CDCPNT = "CDCPNT";

        /// <summary>
        /// CDRKIT.
        /// </summary>
        public const string CDRKIT = "CDRKIT";

        /// <summary>
        /// CDKTP.
        /// </summary>
        public const string CDKTP = "CDKTP";

        /// <summary>
        /// CDSRP1.
        /// </summary>
        public const string CDSRP1 = "CDSRP1";

        /// <summary>
        /// CDSRP2.
        /// </summary>
        public const string CDSRP2 = "CDSRP2";

        /// <summary>
        /// CDSRP3.
        /// </summary>
        public const string CDSRP3 = "CDSRP3";

        /// <summary>
        /// CDSRP4.
        /// </summary>
        public const string CDSRP4 = "CDSRP4";

        /// <summary>
        /// CDSRP5.
        /// </summary>
        public const string CDSRP5 = "CDSRP5";

        /// <summary>
        /// CDPRP1.
        /// </summary>
        public const string CDPRP1 = "CDPRP1";

        /// <summary>
        /// CDPRP2.
        /// </summary>
        public const string CDPRP2 = "CDPRP2";

        /// <summary>
        /// CDPRP3.
        /// </summary>
        public const string CDPRP3 = "CDPRP3";

        /// <summary>
        /// CDPRP4.
        /// </summary>
        public const string CDPRP4 = "CDPRP4";

        /// <summary>
        /// CDPRP5.
        /// </summary>
        public const string CDPRP5 = "CDPRP5";

        /// <summary>
        /// CDACL1.
        /// </summary>
        public const string CDACL1 = "CDACL1";

        /// <summary>
        /// CDACL2.
        /// </summary>
        public const string CDACL2 = "CDACL2";

        /// <summary>
        /// CDACL3.
        /// </summary>
        public const string CDACL3 = "CDACL3";

        /// <summary>
        /// CDACL4.
        /// </summary>
        public const string CDACL4 = "CDACL4";

        /// <summary>
        /// CDACL5.
        /// </summary>
        public const string CDACL5 = "CDACL5";

        /// <summary>
        /// CDAN8.
        /// </summary>
        public const string CDAN8 = "CDAN8";

        /// <summary>
        /// CDDVAN.
        /// </summary>
        public const string CDDVAN = "CDDVAN";

        /// <summary>
        /// CDPA8.
        /// </summary>
        public const string CDPA8 = "CDPA8";

        /// <summary>
        /// CDPBAN.
        /// </summary>
        public const string CDPBAN = "CDPBAN";

        /// <summary>
        /// CDITAN.
        /// </summary>
        public const string CDITAN = "CDITAN";

        /// <summary>
        /// CDVR01.
        /// </summary>
        public const string CDVR01 = "CDVR01";

        /// <summary>
        /// CDVR02.
        /// </summary>
        public const string CDVR02 = "CDVR02";

        /// <summary>
        /// CDFTAN.
        /// </summary>
        public const string CDFTAN = "CDFTAN";

        /// <summary>
        /// CDSHAN.
        /// </summary>
        public const string CDSHAN = "CDSHAN";

        /// <summary>
        /// CD54RCLS.
        /// </summary>
        public const string CD54RCLS = "CD54RCLS";

        /// <summary>
        /// CDENTJ.
        /// </summary>
        public const string CDENTJ = "CDENTJ";

        /// <summary>
        /// CDTENT.
        /// </summary>
        public const string CDTENT = "CDTENT";

        /// <summary>
        /// CD54RCSD.
        /// </summary>
        public const string CD54RCSD = "CD54RCSD";

        /// <summary>
        /// CD54RCST.
        /// </summary>
        public const string CD54RCST = "CD54RCST";

        /// <summary>
        /// CD54RCDD.
        /// </summary>
        public const string CD54RCDD = "CD54RCDD";

        /// <summary>
        /// CD54RCDT.
        /// </summary>
        public const string CD54RCDT = "CD54RCDT";

        /// <summary>
        /// CD54RCDAD.
        /// </summary>
        public const string CD54RCDAD = "CD54RCDAD";

        /// <summary>
        /// CD54RCDAT.
        /// </summary>
        public const string CD54RCDAT = "CD54RCDAT";

        /// <summary>
        /// CD54RCID.
        /// </summary>
        public const string CD54RCID = "CD54RCID";

        /// <summary>
        /// CD54RCIT.
        /// </summary>
        public const string CD54RCIT = "CD54RCIT";

        /// <summary>
        /// CD54RCPED.
        /// </summary>
        public const string CD54RCPED = "CD54RCPED";

        /// <summary>
        /// CD54RCPET.
        /// </summary>
        public const string CD54RCPET = "CD54RCPET";

        /// <summary>
        /// CD54RCAED.
        /// </summary>
        public const string CD54RCAED = "CD54RCAED";

        /// <summary>
        /// CD54RCAET.
        /// </summary>
        public const string CD54RCAET = "CD54RCAET";

        /// <summary>
        /// CD54RCBSD.
        /// </summary>
        public const string CD54RCBSD = "CD54RCBSD";

        /// <summary>
        /// CD54RCBST.
        /// </summary>
        public const string CD54RCBST = "CD54RCBST";

        /// <summary>
        /// CD54RCBED.
        /// </summary>
        public const string CD54RCBED = "CD54RCBED";

        /// <summary>
        /// CD54RCBET.
        /// </summary>
        public const string CD54RCBET = "CD54RCBET";

        /// <summary>
        /// CDDLIJ.
        /// </summary>
        public const string CDDLIJ = "CDDLIJ";

        /// <summary>
        /// CD54RREF1.
        /// </summary>
        public const string CD54RREF1 = "CD54RREF1";

        /// <summary>
        /// CD54RREF2.
        /// </summary>
        public const string CD54RREF2 = "CD54RREF2";

        /// <summary>
        /// CD54RARSVD.
        /// </summary>
        public const string CD54RARSVD = "CD54RARSVD";

        /// <summary>
        /// CD54RCRD.
        /// </summary>
        public const string CD54RCRD = "CD54RCRD";

        /// <summary>
        /// CD54RCRT.
        /// </summary>
        public const string CD54RCRT = "CD54RCRT";

        /// <summary>
        /// CD54RCRCD.
        /// </summary>
        public const string CD54RCRCD = "CD54RCRCD";

        /// <summary>
        /// CD54RCRCT.
        /// </summary>
        public const string CD54RCRCT = "CD54RCRCT";

        /// <summary>
        /// CD54RMSTRC.
        /// </summary>
        public const string CD54RMSTRC = "CD54RMSTRC";

        /// <summary>
        /// CDPTC.
        /// </summary>
        public const string CDPTC = "CDPTC";

        /// <summary>
        /// CDRYIN.
        /// </summary>
        public const string CDRYIN = "CDRYIN";

        /// <summary>
        /// CDASN.
        /// </summary>
        public const string CDASN = "CDASN";

        /// <summary>
        /// CDPRGP.
        /// </summary>
        public const string CDPRGP = "CDPRGP";

        /// <summary>
        /// CDTRDC.
        /// </summary>
        public const string CDTRDC = "CDTRDC";

        /// <summary>
        /// CDTAX1.
        /// </summary>
        public const string CDTAX1 = "CDTAX1";

        /// <summary>
        /// CDEXR1.
        /// </summary>
        public const string CDEXR1 = "CDEXR1";

        /// <summary>
        /// CDTXCT.
        /// </summary>
        public const string CDTXCT = "CDTXCT";

        /// <summary>
        /// CDHOLD.
        /// </summary>
        public const string CDHOLD = "CDHOLD";

        /// <summary>
        /// CDNTR.
        /// </summary>
        public const string CDNTR = "CDNTR";

        /// <summary>
        /// CDCARS.
        /// </summary>
        public const string CDCARS = "CDCARS";

        /// <summary>
        /// CDMOT.
        /// </summary>
        public const string CDMOT = "CDMOT";

        /// <summary>
        /// CDCOT.
        /// </summary>
        public const string CDCOT = "CDCOT";

        /// <summary>
        /// CDROUT.
        /// </summary>
        public const string CDROUT = "CDROUT";

        /// <summary>
        /// CDSTOP.
        /// </summary>
        public const string CDSTOP = "CDSTOP";

        /// <summary>
        /// CDZON.
        /// </summary>
        public const string CDZON = "CDZON";

        /// <summary>
        /// CDCNID.
        /// </summary>
        public const string CDCNID = "CDCNID";

        /// <summary>
        /// CDFRTH.
        /// </summary>
        public const string CDFRTH = "CDFRTH";

        /// <summary>
        /// CDDEL1.
        /// </summary>
        public const string CDDEL1 = "CDDEL1";

        /// <summary>
        /// CDDEL2.
        /// </summary>
        public const string CDDEL2 = "CDDEL2";

        /// <summary>
        /// CDAFT.
        /// </summary>
        public const string CDAFT = "CDAFT";

        /// <summary>
        /// CDCACT.
        /// </summary>
        public const string CDCACT = "CDCACT";

        /// <summary>
        /// CDCEXP.
        /// </summary>
        public const string CDCEXP = "CDCEXP";

        /// <summary>
        /// CDUPRC.
        /// </summary>
        public const string CDUPRC = "CDUPRC";

        /// <summary>
        /// CDAPUM.
        /// </summary>
        public const string CDAPUM = "CDAPUM";

        /// <summary>
        /// CDPROV.
        /// </summary>
        public const string CDPROV = "CDPROV";

        /// <summary>
        /// CDERC.
        /// </summary>
        public const string CDERC = "CDERC";

        /// <summary>
        /// CDLPRC.
        /// </summary>
        public const string CDLPRC = "CDLPRC";

        /// <summary>
        /// CDUNCS.
        /// </summary>
        public const string CDUNCS = "CDUNCS";

        /// <summary>
        /// CDCSTO.
        /// </summary>
        public const string CDCSTO = "CDCSTO";

        /// <summary>
        /// CDATUM.
        /// </summary>
        public const string CDATUM = "CDATUM";

        /// <summary>
        /// CD54RRUNCS.
        /// </summary>
        public const string CD54RRUNCS = "CD54RRUNCS";

        /// <summary>
        /// CD54RBOD.
        /// </summary>
        public const string CD54RBOD = "CD54RBOD";

        /// <summary>
        /// CDBCRC.
        /// </summary>
        public const string CDBCRC = "CDBCRC";

        /// <summary>
        /// CDCRRM.
        /// </summary>
        public const string CDCRRM = "CDCRRM";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDCRR.
        /// </summary>
        public const string CDCRR = "CDCRR";

        /// <summary>
        /// CDERDT.
        /// </summary>
        public const string CDERDT = "CDERDT";

        /// <summary>
        /// CD54RXRFV.
        /// </summary>
        public const string CD54RXRFV = "CD54RXRFV";

        /// <summary>
        /// CDBILLCRCD.
        /// </summary>
        public const string CDBILLCRCD = "CDBILLCRCD";

        /// <summary>
        /// CDFUP.
        /// </summary>
        public const string CDFUP = "CDFUP";

        /// <summary>
        /// CDFPRC.
        /// </summary>
        public const string CDFPRC = "CDFPRC";

        /// <summary>
        /// CDFUC.
        /// </summary>
        public const string CDFUC = "CDFUC";

        /// <summary>
        /// CD54RRUNCF.
        /// </summary>
        public const string CD54RRUNCF = "CD54RRUNCF";

        /// <summary>
        /// CD54RRTO.
        /// </summary>
        public const string CD54RRTO = "CD54RRTO";

        /// <summary>
        /// CD54RUSRD1.
        /// </summary>
        public const string CD54RUSRD1 = "CD54RUSRD1";

        /// <summary>
        /// CD54RUSRD2.
        /// </summary>
        public const string CD54RUSRD2 = "CD54RUSRD2";

        /// <summary>
        /// CD54RUSRD3.
        /// </summary>
        public const string CD54RUSRD3 = "CD54RUSRD3";

        /// <summary>
        /// CD54RUSRT1.
        /// </summary>
        public const string CD54RUSRT1 = "CD54RUSRT1";

        /// <summary>
        /// CD54RUSRT2.
        /// </summary>
        public const string CD54RUSRT2 = "CD54RUSRT2";

        /// <summary>
        /// CD54RUSRT3.
        /// </summary>
        public const string CD54RUSRT3 = "CD54RUSRT3";

        /// <summary>
        /// CD54RUSNB1.
        /// </summary>
        public const string CD54RUSNB1 = "CD54RUSNB1";

        /// <summary>
        /// CD54RUSNB2.
        /// </summary>
        public const string CD54RUSNB2 = "CD54RUSNB2";

        /// <summary>
        /// CD54RUSNB3.
        /// </summary>
        public const string CD54RUSNB3 = "CD54RUSNB3";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDMKEY.
        /// </summary>
        public const string CDMKEY = "CDMKEY";

        /// <summary>
        /// CDTORG.
        /// </summary>
        public const string CDTORG = "CDTORG";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CD54RDBILL.
        /// </summary>
        public const string CD54RDBILL = "CD54RDBILL";

        /// <summary>
        /// CD54RTEMPL.
        /// </summary>
        public const string CD54RTEMPL = "CD54RTEMPL";

        /// <summary>
        /// CDTXA1.
        /// </summary>
        public const string CDTXA1 = "CDTXA1";

        /// <summary>
        /// CD54RLEASE.
        /// </summary>
        public const string CD54RLEASE = "CD54RLEASE";

        /// <summary>
        /// CD54RLSTY.
        /// </summary>
        public const string CD54RLSTY = "CD54RLSTY";

        /// <summary>
        /// CDRP01.
        /// </summary>
        public const string CDRP01 = "CDRP01";

        /// <summary>
        /// CDRP02.
        /// </summary>
        public const string CDRP02 = "CDRP02";

        /// <summary>
        /// CDRP03.
        /// </summary>
        public const string CDRP03 = "CDRP03";

        /// <summary>
        /// CDRP04.
        /// </summary>
        public const string CDRP04 = "CDRP04";

        /// <summary>
        /// CDRP05.
        /// </summary>
        public const string CDRP05 = "CDRP05";

        /// <summary>
        /// CDRP06.
        /// </summary>
        public const string CDRP06 = "CDRP06";

        /// <summary>
        /// CDRP07.
        /// </summary>
        public const string CDRP07 = "CDRP07";

        /// <summary>
        /// CDRP08.
        /// </summary>
        public const string CDRP08 = "CDRP08";

        /// <summary>
        /// CDRP09.
        /// </summary>
        public const string CDRP09 = "CDRP09";

        /// <summary>
        /// CDRP10.
        /// </summary>
        public const string CDRP10 = "CDRP10";

        /// <summary>
        /// CDRP11.
        /// </summary>
        public const string CDRP11 = "CDRP11";

        /// <summary>
        /// CDRP12.
        /// </summary>
        public const string CDRP12 = "CDRP12";

        /// <summary>
        /// CDRP13.
        /// </summary>
        public const string CDRP13 = "CDRP13";

        /// <summary>
        /// CDRP14.
        /// </summary>
        public const string CDRP14 = "CDRP14";

        /// <summary>
        /// CDRP15.
        /// </summary>
        public const string CDRP15 = "CDRP15";

        /// <summary>
        /// CDRP16.
        /// </summary>
        public const string CDRP16 = "CDRP16";

        /// <summary>
        /// CDRP17.
        /// </summary>
        public const string CDRP17 = "CDRP17";

        /// <summary>
        /// CDRP18.
        /// </summary>
        public const string CDRP18 = "CDRP18";

        /// <summary>
        /// CDRP19.
        /// </summary>
        public const string CDRP19 = "CDRP19";

        /// <summary>
        /// CDRP20.
        /// </summary>
        public const string CDRP20 = "CDRP20";

        /// <summary>
        /// CD54RSALE1.
        /// </summary>
        public const string CD54RSALE1 = "CD54RSALE1";

        /// <summary>
        /// CD54RSALE2.
        /// </summary>
        public const string CD54RSALE2 = "CD54RSALE2";

        /// <summary>
        /// CD54RLNGP.
        /// </summary>
        public const string CD54RLNGP = "CD54RLNGP";

        /// <summary>
        /// CD54RAUTN.
        /// </summary>
        public const string CD54RAUTN = "CD54RAUTN";

        /// <summary>
        /// CD54RIBUM.
        /// </summary>
        public const string CD54RIBUM = "CD54RIBUM";

        /// <summary>
        /// CDTMCU.
        /// </summary>
        public const string CDTMCU = "CDTMCU";

        /// <summary>
        /// CD54RDEF01.
        /// </summary>
        public const string CD54RDEF01 = "CD54RDEF01";

        /// <summary>
        /// CD54RDEF02.
        /// </summary>
        public const string CD54RDEF02 = "CD54RDEF02";

        /// <summary>
        /// CD54RDEF03.
        /// </summary>
        public const string CD54RDEF03 = "CD54RDEF03";

        /// <summary>
        /// CD54RUSRBM.
        /// </summary>
        public const string CD54RUSRBM = "CD54RUSRBM";

        /// <summary>
        /// CD54RUSRLT.
        /// </summary>
        public const string CD54RUSRLT = "CD54RUSRLT";

        /// <summary>
        /// CD54RTS.
        /// </summary>
        public const string CD54RTS = "CD54RTS";

        /// <summary>
        /// CD54RBCRR.
        /// </summary>
        public const string CD54RBCRR = "CD54RBCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F54R11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDDOCO", "CDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDCTO", "CDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CDKCOO", "CDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDCO", "CDCO", JdeDataType.String, 10),
        new JdeField("CDNUMB", "CDNUMB", JdeDataType.Numeric),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDLITM", "CDLITM", JdeDataType.String, 50),
        new JdeField("CDDSC1", "CDDSC1", JdeDataType.String, 60),
        new JdeField("CDDSC2", "CDDSC2", JdeDataType.String, 60),
        new JdeField("CDQSLD", "CDQSLD", JdeDataType.Numeric),
        new JdeField("CD54RQTYO", "CD54RQTYO", JdeDataType.Numeric),
        new JdeField("CD54RQTYS", "CD54RQTYS", JdeDataType.Numeric),
        new JdeField("CD54RQTYW", "CD54RQTYW", JdeDataType.Numeric),
        new JdeField("CD54RQTYJ", "CD54RQTYJ", JdeDataType.Numeric),
        new JdeField("CD54RQTYC", "CD54RQTYC", JdeDataType.Numeric),
        new JdeField("CD54RQTYR", "CD54RQTYR", JdeDataType.Numeric),
        new JdeField("CDUOM", "CDUOM", JdeDataType.String, 4),
        new JdeField("CDLOCN", "CDLOCN", JdeDataType.String, 40),
        new JdeField("CDLOTN", "CDLOTN", JdeDataType.String, 60),
        new JdeField("CDLNTY", "CDLNTY", JdeDataType.String, 4),
        new JdeField("CD54RIC", "CD54RIC", JdeDataType.String, 6),
        new JdeField("CD54RPM", "CD54RPM", JdeDataType.String, 2),
        new JdeField("CDCRMCU", "CDCRMCU", JdeDataType.String, 24),
        new JdeField("CDEMCU", "CDEMCU", JdeDataType.String, 24),
        new JdeField("CDRLIT", "CDRLIT", JdeDataType.String, 16),
        new JdeField("CDKTLN", "CDKTLN", JdeDataType.Numeric),
        new JdeField("CDCPNT", "CDCPNT", JdeDataType.Numeric),
        new JdeField("CDRKIT", "CDRKIT", JdeDataType.Numeric),
        new JdeField("CDKTP", "CDKTP", JdeDataType.Numeric),
        new JdeField("CDSRP1", "CDSRP1", JdeDataType.String, 6),
        new JdeField("CDSRP2", "CDSRP2", JdeDataType.String, 6),
        new JdeField("CDSRP3", "CDSRP3", JdeDataType.String, 6),
        new JdeField("CDSRP4", "CDSRP4", JdeDataType.String, 6),
        new JdeField("CDSRP5", "CDSRP5", JdeDataType.String, 6),
        new JdeField("CDPRP1", "CDPRP1", JdeDataType.String, 6),
        new JdeField("CDPRP2", "CDPRP2", JdeDataType.String, 6),
        new JdeField("CDPRP3", "CDPRP3", JdeDataType.String, 6),
        new JdeField("CDPRP4", "CDPRP4", JdeDataType.String, 6),
        new JdeField("CDPRP5", "CDPRP5", JdeDataType.String, 6),
        new JdeField("CDACL1", "CDACL1", JdeDataType.String, 6),
        new JdeField("CDACL2", "CDACL2", JdeDataType.String, 6),
        new JdeField("CDACL3", "CDACL3", JdeDataType.String, 6),
        new JdeField("CDACL4", "CDACL4", JdeDataType.String, 6),
        new JdeField("CDACL5", "CDACL5", JdeDataType.String, 6),
        new JdeField("CDAN8", "CDAN8", JdeDataType.Numeric),
        new JdeField("CDDVAN", "CDDVAN", JdeDataType.Numeric),
        new JdeField("CDPA8", "CDPA8", JdeDataType.Numeric),
        new JdeField("CDPBAN", "CDPBAN", JdeDataType.Numeric),
        new JdeField("CDITAN", "CDITAN", JdeDataType.Numeric),
        new JdeField("CDVR01", "CDVR01", JdeDataType.String, 50),
        new JdeField("CDVR02", "CDVR02", JdeDataType.String, 50),
        new JdeField("CDFTAN", "CDFTAN", JdeDataType.Numeric),
        new JdeField("CDSHAN", "CDSHAN", JdeDataType.Numeric),
        new JdeField("CD54RCLS", "CD54RCLS", JdeDataType.String, 6),
        new JdeField("CDENTJ", "CDENTJ", JdeDataType.Numeric),
        new JdeField("CDTENT", "CDTENT", JdeDataType.Numeric),
        new JdeField("CD54RCSD", "CD54RCSD", JdeDataType.Numeric),
        new JdeField("CD54RCST", "CD54RCST", JdeDataType.Numeric),
        new JdeField("CD54RCDD", "CD54RCDD", JdeDataType.Numeric),
        new JdeField("CD54RCDT", "CD54RCDT", JdeDataType.Numeric),
        new JdeField("CD54RCDAD", "CD54RCDAD", JdeDataType.Numeric),
        new JdeField("CD54RCDAT", "CD54RCDAT", JdeDataType.Numeric),
        new JdeField("CD54RCID", "CD54RCID", JdeDataType.Numeric),
        new JdeField("CD54RCIT", "CD54RCIT", JdeDataType.Numeric),
        new JdeField("CD54RCPED", "CD54RCPED", JdeDataType.Numeric),
        new JdeField("CD54RCPET", "CD54RCPET", JdeDataType.Numeric),
        new JdeField("CD54RCAED", "CD54RCAED", JdeDataType.Numeric),
        new JdeField("CD54RCAET", "CD54RCAET", JdeDataType.Numeric),
        new JdeField("CD54RCBSD", "CD54RCBSD", JdeDataType.Numeric),
        new JdeField("CD54RCBST", "CD54RCBST", JdeDataType.Numeric),
        new JdeField("CD54RCBED", "CD54RCBED", JdeDataType.Numeric),
        new JdeField("CD54RCBET", "CD54RCBET", JdeDataType.Numeric),
        new JdeField("CDDLIJ", "CDDLIJ", JdeDataType.Numeric),
        new JdeField("CD54RREF1", "CD54RREF1", JdeDataType.String, 100),
        new JdeField("CD54RREF2", "CD54RREF2", JdeDataType.String, 100),
        new JdeField("CD54RARSVD", "CD54RARSVD", JdeDataType.String, 2),
        new JdeField("CD54RCRD", "CD54RCRD", JdeDataType.Numeric),
        new JdeField("CD54RCRT", "CD54RCRT", JdeDataType.Numeric),
        new JdeField("CD54RCRCD", "CD54RCRCD", JdeDataType.Numeric),
        new JdeField("CD54RCRCT", "CD54RCRCT", JdeDataType.Numeric),
        new JdeField("CD54RMSTRC", "CD54RMSTRC", JdeDataType.String, 20),
        new JdeField("CDPTC", "CDPTC", JdeDataType.String, 6),
        new JdeField("CDRYIN", "CDRYIN", JdeDataType.String, 2),
        new JdeField("CDASN", "CDASN", JdeDataType.String, 16),
        new JdeField("CDPRGP", "CDPRGP", JdeDataType.String, 16),
        new JdeField("CDTRDC", "CDTRDC", JdeDataType.Numeric),
        new JdeField("CDTAX1", "CDTAX1", JdeDataType.String, 2),
        new JdeField("CDEXR1", "CDEXR1", JdeDataType.String, 4),
        new JdeField("CDTXCT", "CDTXCT", JdeDataType.String, 40),
        new JdeField("CDHOLD", "CDHOLD", JdeDataType.String, 4),
        new JdeField("CDNTR", "CDNTR", JdeDataType.String, 4),
        new JdeField("CDCARS", "CDCARS", JdeDataType.Numeric),
        new JdeField("CDMOT", "CDMOT", JdeDataType.String, 6),
        new JdeField("CDCOT", "CDCOT", JdeDataType.String, 6),
        new JdeField("CDROUT", "CDROUT", JdeDataType.String, 6),
        new JdeField("CDSTOP", "CDSTOP", JdeDataType.String, 6),
        new JdeField("CDZON", "CDZON", JdeDataType.String, 6),
        new JdeField("CDCNID", "CDCNID", JdeDataType.String, 40),
        new JdeField("CDFRTH", "CDFRTH", JdeDataType.String, 6),
        new JdeField("CDDEL1", "CDDEL1", JdeDataType.String, 60),
        new JdeField("CDDEL2", "CDDEL2", JdeDataType.String, 60),
        new JdeField("CDAFT", "CDAFT", JdeDataType.String, 2),
        new JdeField("CDCACT", "CDCACT", JdeDataType.String, 50),
        new JdeField("CDCEXP", "CDCEXP", JdeDataType.Numeric),
        new JdeField("CDUPRC", "CDUPRC", JdeDataType.Numeric),
        new JdeField("CDAPUM", "CDAPUM", JdeDataType.String, 4),
        new JdeField("CDPROV", "CDPROV", JdeDataType.String, 2),
        new JdeField("CDERC", "CDERC", JdeDataType.String, 4),
        new JdeField("CDLPRC", "CDLPRC", JdeDataType.Numeric),
        new JdeField("CDUNCS", "CDUNCS", JdeDataType.Numeric),
        new JdeField("CDCSTO", "CDCSTO", JdeDataType.String, 2),
        new JdeField("CDATUM", "CDATUM", JdeDataType.String, 4),
        new JdeField("CD54RRUNCS", "CD54RRUNCS", JdeDataType.Numeric),
        new JdeField("CD54RBOD", "CD54RBOD", JdeDataType.String, 2),
        new JdeField("CDBCRC", "CDBCRC", JdeDataType.String, 6),
        new JdeField("CDCRRM", "CDCRRM", JdeDataType.String, 2),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6),
        new JdeField("CDCRR", "CDCRR", JdeDataType.Numeric),
        new JdeField("CDERDT", "CDERDT", JdeDataType.Numeric),
        new JdeField("CD54RXRFV", "CD54RXRFV", JdeDataType.String, 2),
        new JdeField("CDBILLCRCD", "CDBILLCRCD", JdeDataType.String, 6),
        new JdeField("CDFUP", "CDFUP", JdeDataType.Numeric),
        new JdeField("CDFPRC", "CDFPRC", JdeDataType.Numeric),
        new JdeField("CDFUC", "CDFUC", JdeDataType.Numeric),
        new JdeField("CD54RRUNCF", "CD54RRUNCF", JdeDataType.Numeric),
        new JdeField("CD54RRTO", "CD54RRTO", JdeDataType.String, 2),
        new JdeField("CD54RUSRD1", "CD54RUSRD1", JdeDataType.Numeric),
        new JdeField("CD54RUSRD2", "CD54RUSRD2", JdeDataType.Numeric),
        new JdeField("CD54RUSRD3", "CD54RUSRD3", JdeDataType.Numeric),
        new JdeField("CD54RUSRT1", "CD54RUSRT1", JdeDataType.Numeric),
        new JdeField("CD54RUSRT2", "CD54RUSRT2", JdeDataType.Numeric),
        new JdeField("CD54RUSRT3", "CD54RUSRT3", JdeDataType.Numeric),
        new JdeField("CD54RUSNB1", "CD54RUSNB1", JdeDataType.Numeric),
        new JdeField("CD54RUSNB2", "CD54RUSNB2", JdeDataType.Numeric),
        new JdeField("CD54RUSNB3", "CD54RUSNB3", JdeDataType.Numeric),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDMKEY", "CDMKEY", JdeDataType.String, 30),
        new JdeField("CDTORG", "CDTORG", JdeDataType.String, 20),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CD54RDBILL", "CD54RDBILL", JdeDataType.String, 2),
        new JdeField("CD54RTEMPL", "CD54RTEMPL", JdeDataType.String, 2),
        new JdeField("CDTXA1", "CDTXA1", JdeDataType.String, 20),
        new JdeField("CD54RLEASE", "CD54RLEASE", JdeDataType.String, 2),
        new JdeField("CD54RLSTY", "CD54RLSTY", JdeDataType.String, 4),
        new JdeField("CDRP01", "CDRP01", JdeDataType.String, 6),
        new JdeField("CDRP02", "CDRP02", JdeDataType.String, 6),
        new JdeField("CDRP03", "CDRP03", JdeDataType.String, 6),
        new JdeField("CDRP04", "CDRP04", JdeDataType.String, 6),
        new JdeField("CDRP05", "CDRP05", JdeDataType.String, 6),
        new JdeField("CDRP06", "CDRP06", JdeDataType.String, 6),
        new JdeField("CDRP07", "CDRP07", JdeDataType.String, 6),
        new JdeField("CDRP08", "CDRP08", JdeDataType.String, 6),
        new JdeField("CDRP09", "CDRP09", JdeDataType.String, 6),
        new JdeField("CDRP10", "CDRP10", JdeDataType.String, 6),
        new JdeField("CDRP11", "CDRP11", JdeDataType.String, 6),
        new JdeField("CDRP12", "CDRP12", JdeDataType.String, 6),
        new JdeField("CDRP13", "CDRP13", JdeDataType.String, 6),
        new JdeField("CDRP14", "CDRP14", JdeDataType.String, 6),
        new JdeField("CDRP15", "CDRP15", JdeDataType.String, 6),
        new JdeField("CDRP16", "CDRP16", JdeDataType.String, 6),
        new JdeField("CDRP17", "CDRP17", JdeDataType.String, 6),
        new JdeField("CDRP18", "CDRP18", JdeDataType.String, 6),
        new JdeField("CDRP19", "CDRP19", JdeDataType.String, 6),
        new JdeField("CDRP20", "CDRP20", JdeDataType.String, 6),
        new JdeField("CD54RSALE1", "CD54RSALE1", JdeDataType.Numeric),
        new JdeField("CD54RSALE2", "CD54RSALE2", JdeDataType.Numeric),
        new JdeField("CD54RLNGP", "CD54RLNGP", JdeDataType.String, 4),
        new JdeField("CD54RAUTN", "CD54RAUTN", JdeDataType.String, 20),
        new JdeField("CD54RIBUM", "CD54RIBUM", JdeDataType.String, 4),
        new JdeField("CDTMCU", "CDTMCU", JdeDataType.String, 24),
        new JdeField("CD54RDEF01", "CD54RDEF01", JdeDataType.String, 2),
        new JdeField("CD54RDEF02", "CD54RDEF02", JdeDataType.String, 2),
        new JdeField("CD54RDEF03", "CD54RDEF03", JdeDataType.String, 2),
        new JdeField("CD54RUSRBM", "CD54RUSRBM", JdeDataType.String, 2),
        new JdeField("CD54RUSRLT", "CD54RUSRLT", JdeDataType.String, 2),
        new JdeField("CD54RTS", "CD54RTS", JdeDataType.String, 4),
        new JdeField("CD54RBCRR", "CD54RBCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R11_0", "Primary Key on CDDOCO, CDDCTO, CDKCOO, CDLNID", new[] { "CDDOCO", "CDDCTO", "CDKCOO", "CDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R11_2", "Index on CDDOCO, CDDCTO, CDKCOO", new[] { "CDDOCO", "CDDCTO", "CDKCOO" }),
        new JdeIndex("F54R11_3", "Index on CDDOCO, CDDCTO, CDKCOO, CD54RIC", new[] { "CDDOCO", "CDDCTO", "CDKCOO", "CD54RIC" }),
        new JdeIndex("F54R11_4", "Index on CDDOCO, CDDCTO, CDKCOO, CD54RIC, CD54RCLS", new[] { "CDDOCO", "CDDCTO", "CDKCOO", "CD54RIC", "CD54RCLS" }),
        new JdeIndex("F54R11_5", "Index on CDDOCO, CDDCTO, CDKCOO, CD54RCLS", new[] { "CDDOCO", "CDDCTO", "CDKCOO", "CD54RCLS" })
    };
}
