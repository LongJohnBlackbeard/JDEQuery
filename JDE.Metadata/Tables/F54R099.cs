using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R099 - .
/// </summary>
public class F54R099 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HLDOCO.
        /// </summary>
        public const string HLDOCO = "HLDOCO";

        /// <summary>
        /// HLDCTO.
        /// </summary>
        public const string HLDCTO = "HLDCTO";

        /// <summary>
        /// HLKCOO.
        /// </summary>
        public const string HLKCOO = "HLKCOO";

        /// <summary>
        /// HLUKID.
        /// </summary>
        public const string HLUKID = "HLUKID";

        /// <summary>
        /// HL54RLA.
        /// </summary>
        public const string HL54RLA = "HL54RLA";

        /// <summary>
        /// HLMCU.
        /// </summary>
        public const string HLMCU = "HLMCU";

        /// <summary>
        /// HLCO.
        /// </summary>
        public const string HLCO = "HLCO";

        /// <summary>
        /// HLRKCO.
        /// </summary>
        public const string HLRKCO = "HLRKCO";

        /// <summary>
        /// HLRORN.
        /// </summary>
        public const string HLRORN = "HLRORN";

        /// <summary>
        /// HLRCTO.
        /// </summary>
        public const string HLRCTO = "HLRCTO";

        /// <summary>
        /// HLAN8.
        /// </summary>
        public const string HLAN8 = "HLAN8";

        /// <summary>
        /// HLSHAN.
        /// </summary>
        public const string HLSHAN = "HLSHAN";

        /// <summary>
        /// HLDVAN.
        /// </summary>
        public const string HLDVAN = "HLDVAN";

        /// <summary>
        /// HLPA8.
        /// </summary>
        public const string HLPA8 = "HLPA8";

        /// <summary>
        /// HLPBAN.
        /// </summary>
        public const string HLPBAN = "HLPBAN";

        /// <summary>
        /// HLITAN.
        /// </summary>
        public const string HLITAN = "HLITAN";

        /// <summary>
        /// HLFTAN.
        /// </summary>
        public const string HLFTAN = "HLFTAN";

        /// <summary>
        /// HL54RREF1.
        /// </summary>
        public const string HL54RREF1 = "HL54RREF1";

        /// <summary>
        /// HL54RREF2.
        /// </summary>
        public const string HL54RREF2 = "HL54RREF2";

        /// <summary>
        /// HLBLFC.
        /// </summary>
        public const string HLBLFC = "HLBLFC";

        /// <summary>
        /// HL54RCNTST.
        /// </summary>
        public const string HL54RCNTST = "HL54RCNTST";

        /// <summary>
        /// HL54RCTJ.
        /// </summary>
        public const string HL54RCTJ = "HL54RCTJ";

        /// <summary>
        /// HL54RCTT.
        /// </summary>
        public const string HL54RCTT = "HL54RCTT";

        /// <summary>
        /// HL54RCSD.
        /// </summary>
        public const string HL54RCSD = "HL54RCSD";

        /// <summary>
        /// HL54RCST.
        /// </summary>
        public const string HL54RCST = "HL54RCST";

        /// <summary>
        /// HL54RCDD.
        /// </summary>
        public const string HL54RCDD = "HL54RCDD";

        /// <summary>
        /// HL54RCDT.
        /// </summary>
        public const string HL54RCDT = "HL54RCDT";

        /// <summary>
        /// HL54RCDAD.
        /// </summary>
        public const string HL54RCDAD = "HL54RCDAD";

        /// <summary>
        /// HL54RCDAT.
        /// </summary>
        public const string HL54RCDAT = "HL54RCDAT";

        /// <summary>
        /// HL54RCID.
        /// </summary>
        public const string HL54RCID = "HL54RCID";

        /// <summary>
        /// HL54RCIT.
        /// </summary>
        public const string HL54RCIT = "HL54RCIT";

        /// <summary>
        /// HL54RCPED.
        /// </summary>
        public const string HL54RCPED = "HL54RCPED";

        /// <summary>
        /// HL54RCPET.
        /// </summary>
        public const string HL54RCPET = "HL54RCPET";

        /// <summary>
        /// HL54RCAED.
        /// </summary>
        public const string HL54RCAED = "HL54RCAED";

        /// <summary>
        /// HL54RCAET.
        /// </summary>
        public const string HL54RCAET = "HL54RCAET";

        /// <summary>
        /// HL54RCBSD.
        /// </summary>
        public const string HL54RCBSD = "HL54RCBSD";

        /// <summary>
        /// HL54RCBST.
        /// </summary>
        public const string HL54RCBST = "HL54RCBST";

        /// <summary>
        /// HL54RCBED.
        /// </summary>
        public const string HL54RCBED = "HL54RCBED";

        /// <summary>
        /// HL54RCBET.
        /// </summary>
        public const string HL54RCBET = "HL54RCBET";

        /// <summary>
        /// HLDLIJ.
        /// </summary>
        public const string HLDLIJ = "HLDLIJ";

        /// <summary>
        /// HLVR01.
        /// </summary>
        public const string HLVR01 = "HLVR01";

        /// <summary>
        /// HLVR02.
        /// </summary>
        public const string HLVR02 = "HLVR02";

        /// <summary>
        /// HLVR03.
        /// </summary>
        public const string HLVR03 = "HLVR03";

        /// <summary>
        /// HLDEL1.
        /// </summary>
        public const string HLDEL1 = "HLDEL1";

        /// <summary>
        /// HLDEL2.
        /// </summary>
        public const string HLDEL2 = "HLDEL2";

        /// <summary>
        /// HL54RARSVD.
        /// </summary>
        public const string HL54RARSVD = "HL54RARSVD";

        /// <summary>
        /// HL54RCRD.
        /// </summary>
        public const string HL54RCRD = "HL54RCRD";

        /// <summary>
        /// HL54RCRT.
        /// </summary>
        public const string HL54RCRT = "HL54RCRT";

        /// <summary>
        /// HL54RCRCD.
        /// </summary>
        public const string HL54RCRCD = "HL54RCRCD";

        /// <summary>
        /// HL54RCRCT.
        /// </summary>
        public const string HL54RCRCT = "HL54RCRCT";

        /// <summary>
        /// HL54RMSTRC.
        /// </summary>
        public const string HL54RMSTRC = "HL54RMSTRC";

        /// <summary>
        /// HLPTC.
        /// </summary>
        public const string HLPTC = "HLPTC";

        /// <summary>
        /// HLRYIN.
        /// </summary>
        public const string HLRYIN = "HLRYIN";

        /// <summary>
        /// HLASN.
        /// </summary>
        public const string HLASN = "HLASN";

        /// <summary>
        /// HLPRGP.
        /// </summary>
        public const string HLPRGP = "HLPRGP";

        /// <summary>
        /// HLTRDC.
        /// </summary>
        public const string HLTRDC = "HLTRDC";

        /// <summary>
        /// HLEXR1.
        /// </summary>
        public const string HLEXR1 = "HLEXR1";

        /// <summary>
        /// HLTXA1.
        /// </summary>
        public const string HLTXA1 = "HLTXA1";

        /// <summary>
        /// HLTXCT.
        /// </summary>
        public const string HLTXCT = "HLTXCT";

        /// <summary>
        /// HLHOLD.
        /// </summary>
        public const string HLHOLD = "HLHOLD";

        /// <summary>
        /// HLNTR.
        /// </summary>
        public const string HLNTR = "HLNTR";

        /// <summary>
        /// HLCARS.
        /// </summary>
        public const string HLCARS = "HLCARS";

        /// <summary>
        /// HLMOT.
        /// </summary>
        public const string HLMOT = "HLMOT";

        /// <summary>
        /// HLCOT.
        /// </summary>
        public const string HLCOT = "HLCOT";

        /// <summary>
        /// HLROUT.
        /// </summary>
        public const string HLROUT = "HLROUT";

        /// <summary>
        /// HLSTOP.
        /// </summary>
        public const string HLSTOP = "HLSTOP";

        /// <summary>
        /// HLZON.
        /// </summary>
        public const string HLZON = "HLZON";

        /// <summary>
        /// HLCNID.
        /// </summary>
        public const string HLCNID = "HLCNID";

        /// <summary>
        /// HLFRTH.
        /// </summary>
        public const string HLFRTH = "HLFRTH";

        /// <summary>
        /// HLAFT.
        /// </summary>
        public const string HLAFT = "HLAFT";

        /// <summary>
        /// HLCACT.
        /// </summary>
        public const string HLCACT = "HLCACT";

        /// <summary>
        /// HLCEXP.
        /// </summary>
        public const string HLCEXP = "HLCEXP";

        /// <summary>
        /// HLCRRM.
        /// </summary>
        public const string HLCRRM = "HLCRRM";

        /// <summary>
        /// HLCRCD.
        /// </summary>
        public const string HLCRCD = "HLCRCD";

        /// <summary>
        /// HLCRR.
        /// </summary>
        public const string HLCRR = "HLCRR";

        /// <summary>
        /// HLBCRC.
        /// </summary>
        public const string HLBCRC = "HLBCRC";

        /// <summary>
        /// HLERDT.
        /// </summary>
        public const string HLERDT = "HLERDT";

        /// <summary>
        /// HLBILLCRCD.
        /// </summary>
        public const string HLBILLCRCD = "HLBILLCRCD";

        /// <summary>
        /// HLORBY.
        /// </summary>
        public const string HLORBY = "HLORBY";

        /// <summary>
        /// HLTKBY.
        /// </summary>
        public const string HLTKBY = "HLTKBY";

        /// <summary>
        /// HLUPMJ.
        /// </summary>
        public const string HLUPMJ = "HLUPMJ";

        /// <summary>
        /// HLENTJ.
        /// </summary>
        public const string HLENTJ = "HLENTJ";

        /// <summary>
        /// HLUSER.
        /// </summary>
        public const string HLUSER = "HLUSER";

        /// <summary>
        /// HLPID.
        /// </summary>
        public const string HLPID = "HLPID";

        /// <summary>
        /// HLUPMT.
        /// </summary>
        public const string HLUPMT = "HLUPMT";

        /// <summary>
        /// HLJOBN.
        /// </summary>
        public const string HLJOBN = "HLJOBN";

        /// <summary>
        /// HLMKEY.
        /// </summary>
        public const string HLMKEY = "HLMKEY";

        /// <summary>
        /// HLTORG.
        /// </summary>
        public const string HLTORG = "HLTORG";

        /// <summary>
        /// HLURCD.
        /// </summary>
        public const string HLURCD = "HLURCD";

        /// <summary>
        /// HLURDT.
        /// </summary>
        public const string HLURDT = "HLURDT";

        /// <summary>
        /// HLURAT.
        /// </summary>
        public const string HLURAT = "HLURAT";

        /// <summary>
        /// HLURAB.
        /// </summary>
        public const string HLURAB = "HLURAB";

        /// <summary>
        /// HLURRF.
        /// </summary>
        public const string HLURRF = "HLURRF";

        /// <summary>
        /// HLTENT.
        /// </summary>
        public const string HLTENT = "HLTENT";

        /// <summary>
        /// HL54RIT.
        /// </summary>
        public const string HL54RIT = "HL54RIT";

        /// <summary>
        /// HL54RIP.
        /// </summary>
        public const string HL54RIP = "HL54RIP";

        /// <summary>
        /// HL54RXRFV.
        /// </summary>
        public const string HL54RXRFV = "HL54RXRFV";

        /// <summary>
        /// HL54RRTO.
        /// </summary>
        public const string HL54RRTO = "HL54RRTO";

        /// <summary>
        /// HL54RUSRD1.
        /// </summary>
        public const string HL54RUSRD1 = "HL54RUSRD1";

        /// <summary>
        /// HL54RUSRD2.
        /// </summary>
        public const string HL54RUSRD2 = "HL54RUSRD2";

        /// <summary>
        /// HL54RUSRD3.
        /// </summary>
        public const string HL54RUSRD3 = "HL54RUSRD3";

        /// <summary>
        /// HL54RUSRT1.
        /// </summary>
        public const string HL54RUSRT1 = "HL54RUSRT1";

        /// <summary>
        /// HL54RUSRT2.
        /// </summary>
        public const string HL54RUSRT2 = "HL54RUSRT2";

        /// <summary>
        /// HL54RUSRT3.
        /// </summary>
        public const string HL54RUSRT3 = "HL54RUSRT3";

        /// <summary>
        /// HL54RUSNB1.
        /// </summary>
        public const string HL54RUSNB1 = "HL54RUSNB1";

        /// <summary>
        /// HL54RUSNB2.
        /// </summary>
        public const string HL54RUSNB2 = "HL54RUSNB2";

        /// <summary>
        /// HL54RUSNB3.
        /// </summary>
        public const string HL54RUSNB3 = "HL54RUSNB3";

        /// <summary>
        /// HL54RTEMPL.
        /// </summary>
        public const string HL54RTEMPL = "HL54RTEMPL";

        /// <summary>
        /// HL54RDBILL.
        /// </summary>
        public const string HL54RDBILL = "HL54RDBILL";

        /// <summary>
        /// HL54RLEASE.
        /// </summary>
        public const string HL54RLEASE = "HL54RLEASE";

        /// <summary>
        /// HL54RLSTY.
        /// </summary>
        public const string HL54RLSTY = "HL54RLSTY";

        /// <summary>
        /// HLRP01.
        /// </summary>
        public const string HLRP01 = "HLRP01";

        /// <summary>
        /// HLRP02.
        /// </summary>
        public const string HLRP02 = "HLRP02";

        /// <summary>
        /// HLRP03.
        /// </summary>
        public const string HLRP03 = "HLRP03";

        /// <summary>
        /// HLRP04.
        /// </summary>
        public const string HLRP04 = "HLRP04";

        /// <summary>
        /// HLRP05.
        /// </summary>
        public const string HLRP05 = "HLRP05";

        /// <summary>
        /// HLRP06.
        /// </summary>
        public const string HLRP06 = "HLRP06";

        /// <summary>
        /// HLRP07.
        /// </summary>
        public const string HLRP07 = "HLRP07";

        /// <summary>
        /// HLRP08.
        /// </summary>
        public const string HLRP08 = "HLRP08";

        /// <summary>
        /// HLRP09.
        /// </summary>
        public const string HLRP09 = "HLRP09";

        /// <summary>
        /// HLRP10.
        /// </summary>
        public const string HLRP10 = "HLRP10";

        /// <summary>
        /// HLRP11.
        /// </summary>
        public const string HLRP11 = "HLRP11";

        /// <summary>
        /// HLRP12.
        /// </summary>
        public const string HLRP12 = "HLRP12";

        /// <summary>
        /// HLRP13.
        /// </summary>
        public const string HLRP13 = "HLRP13";

        /// <summary>
        /// HLRP14.
        /// </summary>
        public const string HLRP14 = "HLRP14";

        /// <summary>
        /// HLRP15.
        /// </summary>
        public const string HLRP15 = "HLRP15";

        /// <summary>
        /// HLRP16.
        /// </summary>
        public const string HLRP16 = "HLRP16";

        /// <summary>
        /// HLRP17.
        /// </summary>
        public const string HLRP17 = "HLRP17";

        /// <summary>
        /// HLRP18.
        /// </summary>
        public const string HLRP18 = "HLRP18";

        /// <summary>
        /// HLRP19.
        /// </summary>
        public const string HLRP19 = "HLRP19";

        /// <summary>
        /// HLRP20.
        /// </summary>
        public const string HLRP20 = "HLRP20";

        /// <summary>
        /// HL54RSALE1.
        /// </summary>
        public const string HL54RSALE1 = "HL54RSALE1";

        /// <summary>
        /// HL54RSALE2.
        /// </summary>
        public const string HL54RSALE2 = "HL54RSALE2";

        /// <summary>
        /// HL54RAUTN.
        /// </summary>
        public const string HL54RAUTN = "HL54RAUTN";

        /// <summary>
        /// HL54RLNGP.
        /// </summary>
        public const string HL54RLNGP = "HL54RLNGP";

        /// <summary>
        /// HL54RRQSB.
        /// </summary>
        public const string HL54RRQSB = "HL54RRQSB";

        /// <summary>
        /// HL54RDEF01.
        /// </summary>
        public const string HL54RDEF01 = "HL54RDEF01";

        /// <summary>
        /// HL54RDEF02.
        /// </summary>
        public const string HL54RDEF02 = "HL54RDEF02";

        /// <summary>
        /// HL54RDEF03.
        /// </summary>
        public const string HL54RDEF03 = "HL54RDEF03";

        /// <summary>
        /// HL54RBCRR.
        /// </summary>
        public const string HL54RBCRR = "HL54RBCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F54R099";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HLDOCO", "HLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HLDCTO", "HLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("HLKCOO", "HLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("HLUKID", "HLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("HL54RLA", "HL54RLA", JdeDataType.String, 4),
        new JdeField("HLMCU", "HLMCU", JdeDataType.String, 24),
        new JdeField("HLCO", "HLCO", JdeDataType.String, 10),
        new JdeField("HLRKCO", "HLRKCO", JdeDataType.String, 10),
        new JdeField("HLRORN", "HLRORN", JdeDataType.String, 16),
        new JdeField("HLRCTO", "HLRCTO", JdeDataType.String, 4),
        new JdeField("HLAN8", "HLAN8", JdeDataType.Numeric),
        new JdeField("HLSHAN", "HLSHAN", JdeDataType.Numeric),
        new JdeField("HLDVAN", "HLDVAN", JdeDataType.Numeric),
        new JdeField("HLPA8", "HLPA8", JdeDataType.Numeric),
        new JdeField("HLPBAN", "HLPBAN", JdeDataType.Numeric),
        new JdeField("HLITAN", "HLITAN", JdeDataType.Numeric),
        new JdeField("HLFTAN", "HLFTAN", JdeDataType.Numeric),
        new JdeField("HL54RREF1", "HL54RREF1", JdeDataType.String, 100),
        new JdeField("HL54RREF2", "HL54RREF2", JdeDataType.String, 100),
        new JdeField("HLBLFC", "HLBLFC", JdeDataType.String, 2),
        new JdeField("HL54RCNTST", "HL54RCNTST", JdeDataType.String, 6),
        new JdeField("HL54RCTJ", "HL54RCTJ", JdeDataType.Numeric),
        new JdeField("HL54RCTT", "HL54RCTT", JdeDataType.Numeric),
        new JdeField("HL54RCSD", "HL54RCSD", JdeDataType.Numeric),
        new JdeField("HL54RCST", "HL54RCST", JdeDataType.Numeric),
        new JdeField("HL54RCDD", "HL54RCDD", JdeDataType.Numeric),
        new JdeField("HL54RCDT", "HL54RCDT", JdeDataType.Numeric),
        new JdeField("HL54RCDAD", "HL54RCDAD", JdeDataType.Numeric),
        new JdeField("HL54RCDAT", "HL54RCDAT", JdeDataType.Numeric),
        new JdeField("HL54RCID", "HL54RCID", JdeDataType.Numeric),
        new JdeField("HL54RCIT", "HL54RCIT", JdeDataType.Numeric),
        new JdeField("HL54RCPED", "HL54RCPED", JdeDataType.Numeric),
        new JdeField("HL54RCPET", "HL54RCPET", JdeDataType.Numeric),
        new JdeField("HL54RCAED", "HL54RCAED", JdeDataType.Numeric),
        new JdeField("HL54RCAET", "HL54RCAET", JdeDataType.Numeric),
        new JdeField("HL54RCBSD", "HL54RCBSD", JdeDataType.Numeric),
        new JdeField("HL54RCBST", "HL54RCBST", JdeDataType.Numeric),
        new JdeField("HL54RCBED", "HL54RCBED", JdeDataType.Numeric),
        new JdeField("HL54RCBET", "HL54RCBET", JdeDataType.Numeric),
        new JdeField("HLDLIJ", "HLDLIJ", JdeDataType.Numeric),
        new JdeField("HLVR01", "HLVR01", JdeDataType.String, 50),
        new JdeField("HLVR02", "HLVR02", JdeDataType.String, 50),
        new JdeField("HLVR03", "HLVR03", JdeDataType.String, 50),
        new JdeField("HLDEL1", "HLDEL1", JdeDataType.String, 60),
        new JdeField("HLDEL2", "HLDEL2", JdeDataType.String, 60),
        new JdeField("HL54RARSVD", "HL54RARSVD", JdeDataType.String, 2),
        new JdeField("HL54RCRD", "HL54RCRD", JdeDataType.Numeric),
        new JdeField("HL54RCRT", "HL54RCRT", JdeDataType.Numeric),
        new JdeField("HL54RCRCD", "HL54RCRCD", JdeDataType.Numeric),
        new JdeField("HL54RCRCT", "HL54RCRCT", JdeDataType.Numeric),
        new JdeField("HL54RMSTRC", "HL54RMSTRC", JdeDataType.String, 20),
        new JdeField("HLPTC", "HLPTC", JdeDataType.String, 6),
        new JdeField("HLRYIN", "HLRYIN", JdeDataType.String, 2),
        new JdeField("HLASN", "HLASN", JdeDataType.String, 16),
        new JdeField("HLPRGP", "HLPRGP", JdeDataType.String, 16),
        new JdeField("HLTRDC", "HLTRDC", JdeDataType.Numeric),
        new JdeField("HLEXR1", "HLEXR1", JdeDataType.String, 4),
        new JdeField("HLTXA1", "HLTXA1", JdeDataType.String, 20),
        new JdeField("HLTXCT", "HLTXCT", JdeDataType.String, 40),
        new JdeField("HLHOLD", "HLHOLD", JdeDataType.String, 4),
        new JdeField("HLNTR", "HLNTR", JdeDataType.String, 4),
        new JdeField("HLCARS", "HLCARS", JdeDataType.Numeric),
        new JdeField("HLMOT", "HLMOT", JdeDataType.String, 6),
        new JdeField("HLCOT", "HLCOT", JdeDataType.String, 6),
        new JdeField("HLROUT", "HLROUT", JdeDataType.String, 6),
        new JdeField("HLSTOP", "HLSTOP", JdeDataType.String, 6),
        new JdeField("HLZON", "HLZON", JdeDataType.String, 6),
        new JdeField("HLCNID", "HLCNID", JdeDataType.String, 40),
        new JdeField("HLFRTH", "HLFRTH", JdeDataType.String, 6),
        new JdeField("HLAFT", "HLAFT", JdeDataType.String, 2),
        new JdeField("HLCACT", "HLCACT", JdeDataType.String, 50),
        new JdeField("HLCEXP", "HLCEXP", JdeDataType.Numeric),
        new JdeField("HLCRRM", "HLCRRM", JdeDataType.String, 2),
        new JdeField("HLCRCD", "HLCRCD", JdeDataType.String, 6),
        new JdeField("HLCRR", "HLCRR", JdeDataType.Numeric),
        new JdeField("HLBCRC", "HLBCRC", JdeDataType.String, 6),
        new JdeField("HLERDT", "HLERDT", JdeDataType.Numeric),
        new JdeField("HLBILLCRCD", "HLBILLCRCD", JdeDataType.String, 6),
        new JdeField("HLORBY", "HLORBY", JdeDataType.String, 20),
        new JdeField("HLTKBY", "HLTKBY", JdeDataType.String, 20),
        new JdeField("HLUPMJ", "HLUPMJ", JdeDataType.Numeric),
        new JdeField("HLENTJ", "HLENTJ", JdeDataType.Numeric),
        new JdeField("HLUSER", "HLUSER", JdeDataType.String, 20),
        new JdeField("HLPID", "HLPID", JdeDataType.String, 20),
        new JdeField("HLUPMT", "HLUPMT", JdeDataType.Numeric),
        new JdeField("HLJOBN", "HLJOBN", JdeDataType.String, 20),
        new JdeField("HLMKEY", "HLMKEY", JdeDataType.String, 30),
        new JdeField("HLTORG", "HLTORG", JdeDataType.String, 20),
        new JdeField("HLURCD", "HLURCD", JdeDataType.String, 4),
        new JdeField("HLURDT", "HLURDT", JdeDataType.Numeric),
        new JdeField("HLURAT", "HLURAT", JdeDataType.Numeric),
        new JdeField("HLURAB", "HLURAB", JdeDataType.Numeric),
        new JdeField("HLURRF", "HLURRF", JdeDataType.String, 30),
        new JdeField("HLTENT", "HLTENT", JdeDataType.Numeric),
        new JdeField("HL54RIT", "HL54RIT", JdeDataType.String, 4),
        new JdeField("HL54RIP", "HL54RIP", JdeDataType.String, 60),
        new JdeField("HL54RXRFV", "HL54RXRFV", JdeDataType.String, 2),
        new JdeField("HL54RRTO", "HL54RRTO", JdeDataType.String, 2),
        new JdeField("HL54RUSRD1", "HL54RUSRD1", JdeDataType.Numeric),
        new JdeField("HL54RUSRD2", "HL54RUSRD2", JdeDataType.Numeric),
        new JdeField("HL54RUSRD3", "HL54RUSRD3", JdeDataType.Numeric),
        new JdeField("HL54RUSRT1", "HL54RUSRT1", JdeDataType.Numeric),
        new JdeField("HL54RUSRT2", "HL54RUSRT2", JdeDataType.Numeric),
        new JdeField("HL54RUSRT3", "HL54RUSRT3", JdeDataType.Numeric),
        new JdeField("HL54RUSNB1", "HL54RUSNB1", JdeDataType.Numeric),
        new JdeField("HL54RUSNB2", "HL54RUSNB2", JdeDataType.Numeric),
        new JdeField("HL54RUSNB3", "HL54RUSNB3", JdeDataType.Numeric),
        new JdeField("HL54RTEMPL", "HL54RTEMPL", JdeDataType.String, 2),
        new JdeField("HL54RDBILL", "HL54RDBILL", JdeDataType.String, 2),
        new JdeField("HL54RLEASE", "HL54RLEASE", JdeDataType.String, 2),
        new JdeField("HL54RLSTY", "HL54RLSTY", JdeDataType.String, 4),
        new JdeField("HLRP01", "HLRP01", JdeDataType.String, 6),
        new JdeField("HLRP02", "HLRP02", JdeDataType.String, 6),
        new JdeField("HLRP03", "HLRP03", JdeDataType.String, 6),
        new JdeField("HLRP04", "HLRP04", JdeDataType.String, 6),
        new JdeField("HLRP05", "HLRP05", JdeDataType.String, 6),
        new JdeField("HLRP06", "HLRP06", JdeDataType.String, 6),
        new JdeField("HLRP07", "HLRP07", JdeDataType.String, 6),
        new JdeField("HLRP08", "HLRP08", JdeDataType.String, 6),
        new JdeField("HLRP09", "HLRP09", JdeDataType.String, 6),
        new JdeField("HLRP10", "HLRP10", JdeDataType.String, 6),
        new JdeField("HLRP11", "HLRP11", JdeDataType.String, 6),
        new JdeField("HLRP12", "HLRP12", JdeDataType.String, 6),
        new JdeField("HLRP13", "HLRP13", JdeDataType.String, 6),
        new JdeField("HLRP14", "HLRP14", JdeDataType.String, 6),
        new JdeField("HLRP15", "HLRP15", JdeDataType.String, 6),
        new JdeField("HLRP16", "HLRP16", JdeDataType.String, 6),
        new JdeField("HLRP17", "HLRP17", JdeDataType.String, 6),
        new JdeField("HLRP18", "HLRP18", JdeDataType.String, 6),
        new JdeField("HLRP19", "HLRP19", JdeDataType.String, 6),
        new JdeField("HLRP20", "HLRP20", JdeDataType.String, 6),
        new JdeField("HL54RSALE1", "HL54RSALE1", JdeDataType.Numeric),
        new JdeField("HL54RSALE2", "HL54RSALE2", JdeDataType.Numeric),
        new JdeField("HL54RAUTN", "HL54RAUTN", JdeDataType.String, 20),
        new JdeField("HL54RLNGP", "HL54RLNGP", JdeDataType.String, 4),
        new JdeField("HL54RRQSB", "HL54RRQSB", JdeDataType.Numeric),
        new JdeField("HL54RDEF01", "HL54RDEF01", JdeDataType.String, 2),
        new JdeField("HL54RDEF02", "HL54RDEF02", JdeDataType.String, 2),
        new JdeField("HL54RDEF03", "HL54RDEF03", JdeDataType.String, 2),
        new JdeField("HL54RBCRR", "HL54RBCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R099_0", "Primary Key on HLDOCO, HLDCTO, HLKCOO, HLUKID", new[] { "HLDOCO", "HLDCTO", "HLKCOO", "HLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R099_2", "Index on HLDOCO, HLDCTO, HLKCOO", new[] { "HLDOCO", "HLDCTO", "HLKCOO" }),
        new JdeIndex("F54R099_3", "Index on HLDOCO, HLDCTO, HLKCOO, SYS_NC00141$", new[] { "HLDOCO", "HLDCTO", "HLKCOO", "SYS_NC00141$" })
    };
}
