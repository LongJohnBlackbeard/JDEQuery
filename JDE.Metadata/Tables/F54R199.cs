using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R199 - .
/// </summary>
public class F54R199 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLDOCO.
        /// </summary>
        public const string DLDOCO = "DLDOCO";

        /// <summary>
        /// DLDCTO.
        /// </summary>
        public const string DLDCTO = "DLDCTO";

        /// <summary>
        /// DLKCOO.
        /// </summary>
        public const string DLKCOO = "DLKCOO";

        /// <summary>
        /// DLLNID.
        /// </summary>
        public const string DLLNID = "DLLNID";

        /// <summary>
        /// DLUKID.
        /// </summary>
        public const string DLUKID = "DLUKID";

        /// <summary>
        /// DL54RLA.
        /// </summary>
        public const string DL54RLA = "DL54RLA";

        /// <summary>
        /// DLMCU.
        /// </summary>
        public const string DLMCU = "DLMCU";

        /// <summary>
        /// DLCO.
        /// </summary>
        public const string DLCO = "DLCO";

        /// <summary>
        /// DLNUMB.
        /// </summary>
        public const string DLNUMB = "DLNUMB";

        /// <summary>
        /// DLITM.
        /// </summary>
        public const string DLITM = "DLITM";

        /// <summary>
        /// DLLITM.
        /// </summary>
        public const string DLLITM = "DLLITM";

        /// <summary>
        /// DLDSC1.
        /// </summary>
        public const string DLDSC1 = "DLDSC1";

        /// <summary>
        /// DLDSC2.
        /// </summary>
        public const string DLDSC2 = "DLDSC2";

        /// <summary>
        /// DLQSLD.
        /// </summary>
        public const string DLQSLD = "DLQSLD";

        /// <summary>
        /// DLUOM.
        /// </summary>
        public const string DLUOM = "DLUOM";

        /// <summary>
        /// DLLOCN.
        /// </summary>
        public const string DLLOCN = "DLLOCN";

        /// <summary>
        /// DLLOTN.
        /// </summary>
        public const string DLLOTN = "DLLOTN";

        /// <summary>
        /// DLLNTY.
        /// </summary>
        public const string DLLNTY = "DLLNTY";

        /// <summary>
        /// DL54RIC.
        /// </summary>
        public const string DL54RIC = "DL54RIC";

        /// <summary>
        /// DL54RPM.
        /// </summary>
        public const string DL54RPM = "DL54RPM";

        /// <summary>
        /// DLCRMCU.
        /// </summary>
        public const string DLCRMCU = "DLCRMCU";

        /// <summary>
        /// DLEMCU.
        /// </summary>
        public const string DLEMCU = "DLEMCU";

        /// <summary>
        /// DLRLIT.
        /// </summary>
        public const string DLRLIT = "DLRLIT";

        /// <summary>
        /// DLKTLN.
        /// </summary>
        public const string DLKTLN = "DLKTLN";

        /// <summary>
        /// DLCPNT.
        /// </summary>
        public const string DLCPNT = "DLCPNT";

        /// <summary>
        /// DLRKIT.
        /// </summary>
        public const string DLRKIT = "DLRKIT";

        /// <summary>
        /// DLKTP.
        /// </summary>
        public const string DLKTP = "DLKTP";

        /// <summary>
        /// DLSRP1.
        /// </summary>
        public const string DLSRP1 = "DLSRP1";

        /// <summary>
        /// DLSRP2.
        /// </summary>
        public const string DLSRP2 = "DLSRP2";

        /// <summary>
        /// DLSRP3.
        /// </summary>
        public const string DLSRP3 = "DLSRP3";

        /// <summary>
        /// DLSRP4.
        /// </summary>
        public const string DLSRP4 = "DLSRP4";

        /// <summary>
        /// DLSRP5.
        /// </summary>
        public const string DLSRP5 = "DLSRP5";

        /// <summary>
        /// DLPRP1.
        /// </summary>
        public const string DLPRP1 = "DLPRP1";

        /// <summary>
        /// DLPRP2.
        /// </summary>
        public const string DLPRP2 = "DLPRP2";

        /// <summary>
        /// DLPRP3.
        /// </summary>
        public const string DLPRP3 = "DLPRP3";

        /// <summary>
        /// DLPRP4.
        /// </summary>
        public const string DLPRP4 = "DLPRP4";

        /// <summary>
        /// DLPRP5.
        /// </summary>
        public const string DLPRP5 = "DLPRP5";

        /// <summary>
        /// DLACL1.
        /// </summary>
        public const string DLACL1 = "DLACL1";

        /// <summary>
        /// DLACL2.
        /// </summary>
        public const string DLACL2 = "DLACL2";

        /// <summary>
        /// DLACL3.
        /// </summary>
        public const string DLACL3 = "DLACL3";

        /// <summary>
        /// DLACL4.
        /// </summary>
        public const string DLACL4 = "DLACL4";

        /// <summary>
        /// DLACL5.
        /// </summary>
        public const string DLACL5 = "DLACL5";

        /// <summary>
        /// DLAN8.
        /// </summary>
        public const string DLAN8 = "DLAN8";

        /// <summary>
        /// DLDVAN.
        /// </summary>
        public const string DLDVAN = "DLDVAN";

        /// <summary>
        /// DLPA8.
        /// </summary>
        public const string DLPA8 = "DLPA8";

        /// <summary>
        /// DLPBAN.
        /// </summary>
        public const string DLPBAN = "DLPBAN";

        /// <summary>
        /// DLITAN.
        /// </summary>
        public const string DLITAN = "DLITAN";

        /// <summary>
        /// DLVR01.
        /// </summary>
        public const string DLVR01 = "DLVR01";

        /// <summary>
        /// DLVR02.
        /// </summary>
        public const string DLVR02 = "DLVR02";

        /// <summary>
        /// DLFTAN.
        /// </summary>
        public const string DLFTAN = "DLFTAN";

        /// <summary>
        /// DLSHAN.
        /// </summary>
        public const string DLSHAN = "DLSHAN";

        /// <summary>
        /// DL54RCLS.
        /// </summary>
        public const string DL54RCLS = "DL54RCLS";

        /// <summary>
        /// DLENTJ.
        /// </summary>
        public const string DLENTJ = "DLENTJ";

        /// <summary>
        /// DLTENT.
        /// </summary>
        public const string DLTENT = "DLTENT";

        /// <summary>
        /// DL54RCSD.
        /// </summary>
        public const string DL54RCSD = "DL54RCSD";

        /// <summary>
        /// DL54RCST.
        /// </summary>
        public const string DL54RCST = "DL54RCST";

        /// <summary>
        /// DL54RCDD.
        /// </summary>
        public const string DL54RCDD = "DL54RCDD";

        /// <summary>
        /// DL54RCDT.
        /// </summary>
        public const string DL54RCDT = "DL54RCDT";

        /// <summary>
        /// DL54RCDAD.
        /// </summary>
        public const string DL54RCDAD = "DL54RCDAD";

        /// <summary>
        /// DL54RCDAT.
        /// </summary>
        public const string DL54RCDAT = "DL54RCDAT";

        /// <summary>
        /// DL54RCID.
        /// </summary>
        public const string DL54RCID = "DL54RCID";

        /// <summary>
        /// DL54RCIT.
        /// </summary>
        public const string DL54RCIT = "DL54RCIT";

        /// <summary>
        /// DL54RCPED.
        /// </summary>
        public const string DL54RCPED = "DL54RCPED";

        /// <summary>
        /// DL54RCPET.
        /// </summary>
        public const string DL54RCPET = "DL54RCPET";

        /// <summary>
        /// DL54RCAED.
        /// </summary>
        public const string DL54RCAED = "DL54RCAED";

        /// <summary>
        /// DL54RCAET.
        /// </summary>
        public const string DL54RCAET = "DL54RCAET";

        /// <summary>
        /// DL54RCBSD.
        /// </summary>
        public const string DL54RCBSD = "DL54RCBSD";

        /// <summary>
        /// DL54RCBST.
        /// </summary>
        public const string DL54RCBST = "DL54RCBST";

        /// <summary>
        /// DL54RCBED.
        /// </summary>
        public const string DL54RCBED = "DL54RCBED";

        /// <summary>
        /// DL54RCBET.
        /// </summary>
        public const string DL54RCBET = "DL54RCBET";

        /// <summary>
        /// DLDLIJ.
        /// </summary>
        public const string DLDLIJ = "DLDLIJ";

        /// <summary>
        /// DL54RREF1.
        /// </summary>
        public const string DL54RREF1 = "DL54RREF1";

        /// <summary>
        /// DL54RREF2.
        /// </summary>
        public const string DL54RREF2 = "DL54RREF2";

        /// <summary>
        /// DL54RARSVD.
        /// </summary>
        public const string DL54RARSVD = "DL54RARSVD";

        /// <summary>
        /// DL54RCRD.
        /// </summary>
        public const string DL54RCRD = "DL54RCRD";

        /// <summary>
        /// DL54RCRT.
        /// </summary>
        public const string DL54RCRT = "DL54RCRT";

        /// <summary>
        /// DL54RCRCD.
        /// </summary>
        public const string DL54RCRCD = "DL54RCRCD";

        /// <summary>
        /// DL54RCRCT.
        /// </summary>
        public const string DL54RCRCT = "DL54RCRCT";

        /// <summary>
        /// DL54RMSTRC.
        /// </summary>
        public const string DL54RMSTRC = "DL54RMSTRC";

        /// <summary>
        /// DLPTC.
        /// </summary>
        public const string DLPTC = "DLPTC";

        /// <summary>
        /// DLRYIN.
        /// </summary>
        public const string DLRYIN = "DLRYIN";

        /// <summary>
        /// DLASN.
        /// </summary>
        public const string DLASN = "DLASN";

        /// <summary>
        /// DLPRGP.
        /// </summary>
        public const string DLPRGP = "DLPRGP";

        /// <summary>
        /// DLTRDC.
        /// </summary>
        public const string DLTRDC = "DLTRDC";

        /// <summary>
        /// DLTAX1.
        /// </summary>
        public const string DLTAX1 = "DLTAX1";

        /// <summary>
        /// DLEXR1.
        /// </summary>
        public const string DLEXR1 = "DLEXR1";

        /// <summary>
        /// DLTXCT.
        /// </summary>
        public const string DLTXCT = "DLTXCT";

        /// <summary>
        /// DLHOLD.
        /// </summary>
        public const string DLHOLD = "DLHOLD";

        /// <summary>
        /// DLNTR.
        /// </summary>
        public const string DLNTR = "DLNTR";

        /// <summary>
        /// DLCARS.
        /// </summary>
        public const string DLCARS = "DLCARS";

        /// <summary>
        /// DLMOT.
        /// </summary>
        public const string DLMOT = "DLMOT";

        /// <summary>
        /// DLCOT.
        /// </summary>
        public const string DLCOT = "DLCOT";

        /// <summary>
        /// DLROUT.
        /// </summary>
        public const string DLROUT = "DLROUT";

        /// <summary>
        /// DLSTOP.
        /// </summary>
        public const string DLSTOP = "DLSTOP";

        /// <summary>
        /// DLZON.
        /// </summary>
        public const string DLZON = "DLZON";

        /// <summary>
        /// DLCNID.
        /// </summary>
        public const string DLCNID = "DLCNID";

        /// <summary>
        /// DLFRTH.
        /// </summary>
        public const string DLFRTH = "DLFRTH";

        /// <summary>
        /// DLDEL1.
        /// </summary>
        public const string DLDEL1 = "DLDEL1";

        /// <summary>
        /// DLDEL2.
        /// </summary>
        public const string DLDEL2 = "DLDEL2";

        /// <summary>
        /// DLAFT.
        /// </summary>
        public const string DLAFT = "DLAFT";

        /// <summary>
        /// DLCACT.
        /// </summary>
        public const string DLCACT = "DLCACT";

        /// <summary>
        /// DLCEXP.
        /// </summary>
        public const string DLCEXP = "DLCEXP";

        /// <summary>
        /// DLUPRC.
        /// </summary>
        public const string DLUPRC = "DLUPRC";

        /// <summary>
        /// DLAPUM.
        /// </summary>
        public const string DLAPUM = "DLAPUM";

        /// <summary>
        /// DLPROV.
        /// </summary>
        public const string DLPROV = "DLPROV";

        /// <summary>
        /// DLERC.
        /// </summary>
        public const string DLERC = "DLERC";

        /// <summary>
        /// DLLPRC.
        /// </summary>
        public const string DLLPRC = "DLLPRC";

        /// <summary>
        /// DLUNCS.
        /// </summary>
        public const string DLUNCS = "DLUNCS";

        /// <summary>
        /// DLCSTO.
        /// </summary>
        public const string DLCSTO = "DLCSTO";

        /// <summary>
        /// DLATUM.
        /// </summary>
        public const string DLATUM = "DLATUM";

        /// <summary>
        /// DL54RRUNCS.
        /// </summary>
        public const string DL54RRUNCS = "DL54RRUNCS";

        /// <summary>
        /// DL54RBOD.
        /// </summary>
        public const string DL54RBOD = "DL54RBOD";

        /// <summary>
        /// DLBCRC.
        /// </summary>
        public const string DLBCRC = "DLBCRC";

        /// <summary>
        /// DLCRRM.
        /// </summary>
        public const string DLCRRM = "DLCRRM";

        /// <summary>
        /// DLCRCD.
        /// </summary>
        public const string DLCRCD = "DLCRCD";

        /// <summary>
        /// DLCRR.
        /// </summary>
        public const string DLCRR = "DLCRR";

        /// <summary>
        /// DLERDT.
        /// </summary>
        public const string DLERDT = "DLERDT";

        /// <summary>
        /// DL54RXRFV.
        /// </summary>
        public const string DL54RXRFV = "DL54RXRFV";

        /// <summary>
        /// DLBILLCRCD.
        /// </summary>
        public const string DLBILLCRCD = "DLBILLCRCD";

        /// <summary>
        /// DLFUP.
        /// </summary>
        public const string DLFUP = "DLFUP";

        /// <summary>
        /// DLFPRC.
        /// </summary>
        public const string DLFPRC = "DLFPRC";

        /// <summary>
        /// DLFUC.
        /// </summary>
        public const string DLFUC = "DLFUC";

        /// <summary>
        /// DL54RRUNCF.
        /// </summary>
        public const string DL54RRUNCF = "DL54RRUNCF";

        /// <summary>
        /// DL54RRTO.
        /// </summary>
        public const string DL54RRTO = "DL54RRTO";

        /// <summary>
        /// DL54RUSRD1.
        /// </summary>
        public const string DL54RUSRD1 = "DL54RUSRD1";

        /// <summary>
        /// DL54RUSRD2.
        /// </summary>
        public const string DL54RUSRD2 = "DL54RUSRD2";

        /// <summary>
        /// DL54RUSRD3.
        /// </summary>
        public const string DL54RUSRD3 = "DL54RUSRD3";

        /// <summary>
        /// DL54RUSRT1.
        /// </summary>
        public const string DL54RUSRT1 = "DL54RUSRT1";

        /// <summary>
        /// DL54RUSRT2.
        /// </summary>
        public const string DL54RUSRT2 = "DL54RUSRT2";

        /// <summary>
        /// DL54RUSRT3.
        /// </summary>
        public const string DL54RUSRT3 = "DL54RUSRT3";

        /// <summary>
        /// DL54RUSNB1.
        /// </summary>
        public const string DL54RUSNB1 = "DL54RUSNB1";

        /// <summary>
        /// DL54RUSNB2.
        /// </summary>
        public const string DL54RUSNB2 = "DL54RUSNB2";

        /// <summary>
        /// DL54RUSNB3.
        /// </summary>
        public const string DL54RUSNB3 = "DL54RUSNB3";

        /// <summary>
        /// DLUSER.
        /// </summary>
        public const string DLUSER = "DLUSER";

        /// <summary>
        /// DLPID.
        /// </summary>
        public const string DLPID = "DLPID";

        /// <summary>
        /// DLUPMJ.
        /// </summary>
        public const string DLUPMJ = "DLUPMJ";

        /// <summary>
        /// DLUPMT.
        /// </summary>
        public const string DLUPMT = "DLUPMT";

        /// <summary>
        /// DLJOBN.
        /// </summary>
        public const string DLJOBN = "DLJOBN";

        /// <summary>
        /// DLMKEY.
        /// </summary>
        public const string DLMKEY = "DLMKEY";

        /// <summary>
        /// DLTORG.
        /// </summary>
        public const string DLTORG = "DLTORG";

        /// <summary>
        /// DLURCD.
        /// </summary>
        public const string DLURCD = "DLURCD";

        /// <summary>
        /// DLURDT.
        /// </summary>
        public const string DLURDT = "DLURDT";

        /// <summary>
        /// DLURAT.
        /// </summary>
        public const string DLURAT = "DLURAT";

        /// <summary>
        /// DLURAB.
        /// </summary>
        public const string DLURAB = "DLURAB";

        /// <summary>
        /// DLURRF.
        /// </summary>
        public const string DLURRF = "DLURRF";

        /// <summary>
        /// DL54RDBILL.
        /// </summary>
        public const string DL54RDBILL = "DL54RDBILL";

        /// <summary>
        /// DL54RTEMPL.
        /// </summary>
        public const string DL54RTEMPL = "DL54RTEMPL";

        /// <summary>
        /// DLTXA1.
        /// </summary>
        public const string DLTXA1 = "DLTXA1";

        /// <summary>
        /// DL54RLEASE.
        /// </summary>
        public const string DL54RLEASE = "DL54RLEASE";

        /// <summary>
        /// DL54RLSTY.
        /// </summary>
        public const string DL54RLSTY = "DL54RLSTY";

        /// <summary>
        /// DLRP01.
        /// </summary>
        public const string DLRP01 = "DLRP01";

        /// <summary>
        /// DLRP02.
        /// </summary>
        public const string DLRP02 = "DLRP02";

        /// <summary>
        /// DLRP03.
        /// </summary>
        public const string DLRP03 = "DLRP03";

        /// <summary>
        /// DLRP04.
        /// </summary>
        public const string DLRP04 = "DLRP04";

        /// <summary>
        /// DLRP05.
        /// </summary>
        public const string DLRP05 = "DLRP05";

        /// <summary>
        /// DLRP06.
        /// </summary>
        public const string DLRP06 = "DLRP06";

        /// <summary>
        /// DLRP07.
        /// </summary>
        public const string DLRP07 = "DLRP07";

        /// <summary>
        /// DLRP08.
        /// </summary>
        public const string DLRP08 = "DLRP08";

        /// <summary>
        /// DLRP09.
        /// </summary>
        public const string DLRP09 = "DLRP09";

        /// <summary>
        /// DLRP10.
        /// </summary>
        public const string DLRP10 = "DLRP10";

        /// <summary>
        /// DLRP11.
        /// </summary>
        public const string DLRP11 = "DLRP11";

        /// <summary>
        /// DLRP12.
        /// </summary>
        public const string DLRP12 = "DLRP12";

        /// <summary>
        /// DLRP13.
        /// </summary>
        public const string DLRP13 = "DLRP13";

        /// <summary>
        /// DLRP14.
        /// </summary>
        public const string DLRP14 = "DLRP14";

        /// <summary>
        /// DLRP15.
        /// </summary>
        public const string DLRP15 = "DLRP15";

        /// <summary>
        /// DLRP16.
        /// </summary>
        public const string DLRP16 = "DLRP16";

        /// <summary>
        /// DLRP17.
        /// </summary>
        public const string DLRP17 = "DLRP17";

        /// <summary>
        /// DLRP18.
        /// </summary>
        public const string DLRP18 = "DLRP18";

        /// <summary>
        /// DLRP19.
        /// </summary>
        public const string DLRP19 = "DLRP19";

        /// <summary>
        /// DLRP20.
        /// </summary>
        public const string DLRP20 = "DLRP20";

        /// <summary>
        /// DL54RSALE1.
        /// </summary>
        public const string DL54RSALE1 = "DL54RSALE1";

        /// <summary>
        /// DL54RSALE2.
        /// </summary>
        public const string DL54RSALE2 = "DL54RSALE2";

        /// <summary>
        /// DL54RLNGP.
        /// </summary>
        public const string DL54RLNGP = "DL54RLNGP";

        /// <summary>
        /// DL54RAUTN.
        /// </summary>
        public const string DL54RAUTN = "DL54RAUTN";

        /// <summary>
        /// DL54RIBUM.
        /// </summary>
        public const string DL54RIBUM = "DL54RIBUM";

        /// <summary>
        /// DLTMCU.
        /// </summary>
        public const string DLTMCU = "DLTMCU";

        /// <summary>
        /// DL54RDEF01.
        /// </summary>
        public const string DL54RDEF01 = "DL54RDEF01";

        /// <summary>
        /// DL54RDEF02.
        /// </summary>
        public const string DL54RDEF02 = "DL54RDEF02";

        /// <summary>
        /// DL54RDEF03.
        /// </summary>
        public const string DL54RDEF03 = "DL54RDEF03";

        /// <summary>
        /// DL54RUSRBM.
        /// </summary>
        public const string DL54RUSRBM = "DL54RUSRBM";

        /// <summary>
        /// DL54RUSRLT.
        /// </summary>
        public const string DL54RUSRLT = "DL54RUSRLT";

        /// <summary>
        /// DL54RTS.
        /// </summary>
        public const string DL54RTS = "DL54RTS";

        /// <summary>
        /// DL54RQTYC.
        /// </summary>
        public const string DL54RQTYC = "DL54RQTYC";

        /// <summary>
        /// DL54RQTYO.
        /// </summary>
        public const string DL54RQTYO = "DL54RQTYO";

        /// <summary>
        /// DL54RQTYS.
        /// </summary>
        public const string DL54RQTYS = "DL54RQTYS";

        /// <summary>
        /// DL54RQTYW.
        /// </summary>
        public const string DL54RQTYW = "DL54RQTYW";

        /// <summary>
        /// DL54RQTYJ.
        /// </summary>
        public const string DL54RQTYJ = "DL54RQTYJ";

        /// <summary>
        /// DL54RQTYR.
        /// </summary>
        public const string DL54RQTYR = "DL54RQTYR";

        /// <summary>
        /// DL54RBCRR.
        /// </summary>
        public const string DL54RBCRR = "DL54RBCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F54R199";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLDOCO", "DLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DLDCTO", "DLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DLKCOO", "DLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DLLNID", "DLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DLUKID", "DLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DL54RLA", "DL54RLA", JdeDataType.String, 4),
        new JdeField("DLMCU", "DLMCU", JdeDataType.String, 24),
        new JdeField("DLCO", "DLCO", JdeDataType.String, 10),
        new JdeField("DLNUMB", "DLNUMB", JdeDataType.Numeric),
        new JdeField("DLITM", "DLITM", JdeDataType.Numeric),
        new JdeField("DLLITM", "DLLITM", JdeDataType.String, 50),
        new JdeField("DLDSC1", "DLDSC1", JdeDataType.String, 60),
        new JdeField("DLDSC2", "DLDSC2", JdeDataType.String, 60),
        new JdeField("DLQSLD", "DLQSLD", JdeDataType.Numeric),
        new JdeField("DLUOM", "DLUOM", JdeDataType.String, 4),
        new JdeField("DLLOCN", "DLLOCN", JdeDataType.String, 40),
        new JdeField("DLLOTN", "DLLOTN", JdeDataType.String, 60),
        new JdeField("DLLNTY", "DLLNTY", JdeDataType.String, 4),
        new JdeField("DL54RIC", "DL54RIC", JdeDataType.String, 6),
        new JdeField("DL54RPM", "DL54RPM", JdeDataType.String, 2),
        new JdeField("DLCRMCU", "DLCRMCU", JdeDataType.String, 24),
        new JdeField("DLEMCU", "DLEMCU", JdeDataType.String, 24),
        new JdeField("DLRLIT", "DLRLIT", JdeDataType.String, 16),
        new JdeField("DLKTLN", "DLKTLN", JdeDataType.Numeric),
        new JdeField("DLCPNT", "DLCPNT", JdeDataType.Numeric),
        new JdeField("DLRKIT", "DLRKIT", JdeDataType.Numeric),
        new JdeField("DLKTP", "DLKTP", JdeDataType.Numeric),
        new JdeField("DLSRP1", "DLSRP1", JdeDataType.String, 6),
        new JdeField("DLSRP2", "DLSRP2", JdeDataType.String, 6),
        new JdeField("DLSRP3", "DLSRP3", JdeDataType.String, 6),
        new JdeField("DLSRP4", "DLSRP4", JdeDataType.String, 6),
        new JdeField("DLSRP5", "DLSRP5", JdeDataType.String, 6),
        new JdeField("DLPRP1", "DLPRP1", JdeDataType.String, 6),
        new JdeField("DLPRP2", "DLPRP2", JdeDataType.String, 6),
        new JdeField("DLPRP3", "DLPRP3", JdeDataType.String, 6),
        new JdeField("DLPRP4", "DLPRP4", JdeDataType.String, 6),
        new JdeField("DLPRP5", "DLPRP5", JdeDataType.String, 6),
        new JdeField("DLACL1", "DLACL1", JdeDataType.String, 6),
        new JdeField("DLACL2", "DLACL2", JdeDataType.String, 6),
        new JdeField("DLACL3", "DLACL3", JdeDataType.String, 6),
        new JdeField("DLACL4", "DLACL4", JdeDataType.String, 6),
        new JdeField("DLACL5", "DLACL5", JdeDataType.String, 6),
        new JdeField("DLAN8", "DLAN8", JdeDataType.Numeric),
        new JdeField("DLDVAN", "DLDVAN", JdeDataType.Numeric),
        new JdeField("DLPA8", "DLPA8", JdeDataType.Numeric),
        new JdeField("DLPBAN", "DLPBAN", JdeDataType.Numeric),
        new JdeField("DLITAN", "DLITAN", JdeDataType.Numeric),
        new JdeField("DLVR01", "DLVR01", JdeDataType.String, 50),
        new JdeField("DLVR02", "DLVR02", JdeDataType.String, 50),
        new JdeField("DLFTAN", "DLFTAN", JdeDataType.Numeric),
        new JdeField("DLSHAN", "DLSHAN", JdeDataType.Numeric),
        new JdeField("DL54RCLS", "DL54RCLS", JdeDataType.String, 6),
        new JdeField("DLENTJ", "DLENTJ", JdeDataType.Numeric),
        new JdeField("DLTENT", "DLTENT", JdeDataType.Numeric),
        new JdeField("DL54RCSD", "DL54RCSD", JdeDataType.Numeric),
        new JdeField("DL54RCST", "DL54RCST", JdeDataType.Numeric),
        new JdeField("DL54RCDD", "DL54RCDD", JdeDataType.Numeric),
        new JdeField("DL54RCDT", "DL54RCDT", JdeDataType.Numeric),
        new JdeField("DL54RCDAD", "DL54RCDAD", JdeDataType.Numeric),
        new JdeField("DL54RCDAT", "DL54RCDAT", JdeDataType.Numeric),
        new JdeField("DL54RCID", "DL54RCID", JdeDataType.Numeric),
        new JdeField("DL54RCIT", "DL54RCIT", JdeDataType.Numeric),
        new JdeField("DL54RCPED", "DL54RCPED", JdeDataType.Numeric),
        new JdeField("DL54RCPET", "DL54RCPET", JdeDataType.Numeric),
        new JdeField("DL54RCAED", "DL54RCAED", JdeDataType.Numeric),
        new JdeField("DL54RCAET", "DL54RCAET", JdeDataType.Numeric),
        new JdeField("DL54RCBSD", "DL54RCBSD", JdeDataType.Numeric),
        new JdeField("DL54RCBST", "DL54RCBST", JdeDataType.Numeric),
        new JdeField("DL54RCBED", "DL54RCBED", JdeDataType.Numeric),
        new JdeField("DL54RCBET", "DL54RCBET", JdeDataType.Numeric),
        new JdeField("DLDLIJ", "DLDLIJ", JdeDataType.Numeric),
        new JdeField("DL54RREF1", "DL54RREF1", JdeDataType.String, 100),
        new JdeField("DL54RREF2", "DL54RREF2", JdeDataType.String, 100),
        new JdeField("DL54RARSVD", "DL54RARSVD", JdeDataType.String, 2),
        new JdeField("DL54RCRD", "DL54RCRD", JdeDataType.Numeric),
        new JdeField("DL54RCRT", "DL54RCRT", JdeDataType.Numeric),
        new JdeField("DL54RCRCD", "DL54RCRCD", JdeDataType.Numeric),
        new JdeField("DL54RCRCT", "DL54RCRCT", JdeDataType.Numeric),
        new JdeField("DL54RMSTRC", "DL54RMSTRC", JdeDataType.String, 20),
        new JdeField("DLPTC", "DLPTC", JdeDataType.String, 6),
        new JdeField("DLRYIN", "DLRYIN", JdeDataType.String, 2),
        new JdeField("DLASN", "DLASN", JdeDataType.String, 16),
        new JdeField("DLPRGP", "DLPRGP", JdeDataType.String, 16),
        new JdeField("DLTRDC", "DLTRDC", JdeDataType.Numeric),
        new JdeField("DLTAX1", "DLTAX1", JdeDataType.String, 2),
        new JdeField("DLEXR1", "DLEXR1", JdeDataType.String, 4),
        new JdeField("DLTXCT", "DLTXCT", JdeDataType.String, 40),
        new JdeField("DLHOLD", "DLHOLD", JdeDataType.String, 4),
        new JdeField("DLNTR", "DLNTR", JdeDataType.String, 4),
        new JdeField("DLCARS", "DLCARS", JdeDataType.Numeric),
        new JdeField("DLMOT", "DLMOT", JdeDataType.String, 6),
        new JdeField("DLCOT", "DLCOT", JdeDataType.String, 6),
        new JdeField("DLROUT", "DLROUT", JdeDataType.String, 6),
        new JdeField("DLSTOP", "DLSTOP", JdeDataType.String, 6),
        new JdeField("DLZON", "DLZON", JdeDataType.String, 6),
        new JdeField("DLCNID", "DLCNID", JdeDataType.String, 40),
        new JdeField("DLFRTH", "DLFRTH", JdeDataType.String, 6),
        new JdeField("DLDEL1", "DLDEL1", JdeDataType.String, 60),
        new JdeField("DLDEL2", "DLDEL2", JdeDataType.String, 60),
        new JdeField("DLAFT", "DLAFT", JdeDataType.String, 2),
        new JdeField("DLCACT", "DLCACT", JdeDataType.String, 50),
        new JdeField("DLCEXP", "DLCEXP", JdeDataType.Numeric),
        new JdeField("DLUPRC", "DLUPRC", JdeDataType.Numeric),
        new JdeField("DLAPUM", "DLAPUM", JdeDataType.String, 4),
        new JdeField("DLPROV", "DLPROV", JdeDataType.String, 2),
        new JdeField("DLERC", "DLERC", JdeDataType.String, 4),
        new JdeField("DLLPRC", "DLLPRC", JdeDataType.Numeric),
        new JdeField("DLUNCS", "DLUNCS", JdeDataType.Numeric),
        new JdeField("DLCSTO", "DLCSTO", JdeDataType.String, 2),
        new JdeField("DLATUM", "DLATUM", JdeDataType.String, 4),
        new JdeField("DL54RRUNCS", "DL54RRUNCS", JdeDataType.Numeric),
        new JdeField("DL54RBOD", "DL54RBOD", JdeDataType.String, 2),
        new JdeField("DLBCRC", "DLBCRC", JdeDataType.String, 6),
        new JdeField("DLCRRM", "DLCRRM", JdeDataType.String, 2),
        new JdeField("DLCRCD", "DLCRCD", JdeDataType.String, 6),
        new JdeField("DLCRR", "DLCRR", JdeDataType.Numeric),
        new JdeField("DLERDT", "DLERDT", JdeDataType.Numeric),
        new JdeField("DL54RXRFV", "DL54RXRFV", JdeDataType.String, 2),
        new JdeField("DLBILLCRCD", "DLBILLCRCD", JdeDataType.String, 6),
        new JdeField("DLFUP", "DLFUP", JdeDataType.Numeric),
        new JdeField("DLFPRC", "DLFPRC", JdeDataType.Numeric),
        new JdeField("DLFUC", "DLFUC", JdeDataType.Numeric),
        new JdeField("DL54RRUNCF", "DL54RRUNCF", JdeDataType.Numeric),
        new JdeField("DL54RRTO", "DL54RRTO", JdeDataType.String, 2),
        new JdeField("DL54RUSRD1", "DL54RUSRD1", JdeDataType.Numeric),
        new JdeField("DL54RUSRD2", "DL54RUSRD2", JdeDataType.Numeric),
        new JdeField("DL54RUSRD3", "DL54RUSRD3", JdeDataType.Numeric),
        new JdeField("DL54RUSRT1", "DL54RUSRT1", JdeDataType.Numeric),
        new JdeField("DL54RUSRT2", "DL54RUSRT2", JdeDataType.Numeric),
        new JdeField("DL54RUSRT3", "DL54RUSRT3", JdeDataType.Numeric),
        new JdeField("DL54RUSNB1", "DL54RUSNB1", JdeDataType.Numeric),
        new JdeField("DL54RUSNB2", "DL54RUSNB2", JdeDataType.Numeric),
        new JdeField("DL54RUSNB3", "DL54RUSNB3", JdeDataType.Numeric),
        new JdeField("DLUSER", "DLUSER", JdeDataType.String, 20),
        new JdeField("DLPID", "DLPID", JdeDataType.String, 20),
        new JdeField("DLUPMJ", "DLUPMJ", JdeDataType.Numeric),
        new JdeField("DLUPMT", "DLUPMT", JdeDataType.Numeric),
        new JdeField("DLJOBN", "DLJOBN", JdeDataType.String, 20),
        new JdeField("DLMKEY", "DLMKEY", JdeDataType.String, 30),
        new JdeField("DLTORG", "DLTORG", JdeDataType.String, 20),
        new JdeField("DLURCD", "DLURCD", JdeDataType.String, 4),
        new JdeField("DLURDT", "DLURDT", JdeDataType.Numeric),
        new JdeField("DLURAT", "DLURAT", JdeDataType.Numeric),
        new JdeField("DLURAB", "DLURAB", JdeDataType.Numeric),
        new JdeField("DLURRF", "DLURRF", JdeDataType.String, 30),
        new JdeField("DL54RDBILL", "DL54RDBILL", JdeDataType.String, 2),
        new JdeField("DL54RTEMPL", "DL54RTEMPL", JdeDataType.String, 2),
        new JdeField("DLTXA1", "DLTXA1", JdeDataType.String, 20),
        new JdeField("DL54RLEASE", "DL54RLEASE", JdeDataType.String, 2),
        new JdeField("DL54RLSTY", "DL54RLSTY", JdeDataType.String, 4),
        new JdeField("DLRP01", "DLRP01", JdeDataType.String, 6),
        new JdeField("DLRP02", "DLRP02", JdeDataType.String, 6),
        new JdeField("DLRP03", "DLRP03", JdeDataType.String, 6),
        new JdeField("DLRP04", "DLRP04", JdeDataType.String, 6),
        new JdeField("DLRP05", "DLRP05", JdeDataType.String, 6),
        new JdeField("DLRP06", "DLRP06", JdeDataType.String, 6),
        new JdeField("DLRP07", "DLRP07", JdeDataType.String, 6),
        new JdeField("DLRP08", "DLRP08", JdeDataType.String, 6),
        new JdeField("DLRP09", "DLRP09", JdeDataType.String, 6),
        new JdeField("DLRP10", "DLRP10", JdeDataType.String, 6),
        new JdeField("DLRP11", "DLRP11", JdeDataType.String, 6),
        new JdeField("DLRP12", "DLRP12", JdeDataType.String, 6),
        new JdeField("DLRP13", "DLRP13", JdeDataType.String, 6),
        new JdeField("DLRP14", "DLRP14", JdeDataType.String, 6),
        new JdeField("DLRP15", "DLRP15", JdeDataType.String, 6),
        new JdeField("DLRP16", "DLRP16", JdeDataType.String, 6),
        new JdeField("DLRP17", "DLRP17", JdeDataType.String, 6),
        new JdeField("DLRP18", "DLRP18", JdeDataType.String, 6),
        new JdeField("DLRP19", "DLRP19", JdeDataType.String, 6),
        new JdeField("DLRP20", "DLRP20", JdeDataType.String, 6),
        new JdeField("DL54RSALE1", "DL54RSALE1", JdeDataType.Numeric),
        new JdeField("DL54RSALE2", "DL54RSALE2", JdeDataType.Numeric),
        new JdeField("DL54RLNGP", "DL54RLNGP", JdeDataType.String, 4),
        new JdeField("DL54RAUTN", "DL54RAUTN", JdeDataType.String, 20),
        new JdeField("DL54RIBUM", "DL54RIBUM", JdeDataType.String, 4),
        new JdeField("DLTMCU", "DLTMCU", JdeDataType.String, 24),
        new JdeField("DL54RDEF01", "DL54RDEF01", JdeDataType.String, 2),
        new JdeField("DL54RDEF02", "DL54RDEF02", JdeDataType.String, 2),
        new JdeField("DL54RDEF03", "DL54RDEF03", JdeDataType.String, 2),
        new JdeField("DL54RUSRBM", "DL54RUSRBM", JdeDataType.String, 2),
        new JdeField("DL54RUSRLT", "DL54RUSRLT", JdeDataType.String, 2),
        new JdeField("DL54RTS", "DL54RTS", JdeDataType.String, 4),
        new JdeField("DL54RQTYC", "DL54RQTYC", JdeDataType.Numeric),
        new JdeField("DL54RQTYO", "DL54RQTYO", JdeDataType.Numeric),
        new JdeField("DL54RQTYS", "DL54RQTYS", JdeDataType.Numeric),
        new JdeField("DL54RQTYW", "DL54RQTYW", JdeDataType.Numeric),
        new JdeField("DL54RQTYJ", "DL54RQTYJ", JdeDataType.Numeric),
        new JdeField("DL54RQTYR", "DL54RQTYR", JdeDataType.Numeric),
        new JdeField("DL54RBCRR", "DL54RBCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R199_0", "Primary Key on DLDOCO, DLDCTO, DLKCOO, DLLNID, DLUKID", new[] { "DLDOCO", "DLDCTO", "DLKCOO", "DLLNID", "DLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R199_2", "Index on DLDOCO, DLDCTO, DLKCOO, DLLNID", new[] { "DLDOCO", "DLDCTO", "DLKCOO", "DLLNID" }),
        new JdeIndex("F54R199_3", "Index on DLDOCO, DLDCTO, DLKCOO, DLLNID, SYS_NC00190$", new[] { "DLDOCO", "DLDCTO", "DLKCOO", "DLLNID", "SYS_NC00190$" })
    };
}
