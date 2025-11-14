using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R10 - .
/// </summary>
public class F54R10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHDOCO.
        /// </summary>
        public const string CHDOCO = "CHDOCO";

        /// <summary>
        /// CHDCTO.
        /// </summary>
        public const string CHDCTO = "CHDCTO";

        /// <summary>
        /// CHKCOO.
        /// </summary>
        public const string CHKCOO = "CHKCOO";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHCO.
        /// </summary>
        public const string CHCO = "CHCO";

        /// <summary>
        /// CHRKCO.
        /// </summary>
        public const string CHRKCO = "CHRKCO";

        /// <summary>
        /// CHRORN.
        /// </summary>
        public const string CHRORN = "CHRORN";

        /// <summary>
        /// CHRCTO.
        /// </summary>
        public const string CHRCTO = "CHRCTO";

        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHSHAN.
        /// </summary>
        public const string CHSHAN = "CHSHAN";

        /// <summary>
        /// CHDVAN.
        /// </summary>
        public const string CHDVAN = "CHDVAN";

        /// <summary>
        /// CHPA8.
        /// </summary>
        public const string CHPA8 = "CHPA8";

        /// <summary>
        /// CHPBAN.
        /// </summary>
        public const string CHPBAN = "CHPBAN";

        /// <summary>
        /// CHITAN.
        /// </summary>
        public const string CHITAN = "CHITAN";

        /// <summary>
        /// CHFTAN.
        /// </summary>
        public const string CHFTAN = "CHFTAN";

        /// <summary>
        /// CH54RREF1.
        /// </summary>
        public const string CH54RREF1 = "CH54RREF1";

        /// <summary>
        /// CH54RREF2.
        /// </summary>
        public const string CH54RREF2 = "CH54RREF2";

        /// <summary>
        /// CHBLFC.
        /// </summary>
        public const string CHBLFC = "CHBLFC";

        /// <summary>
        /// CH54RCNTST.
        /// </summary>
        public const string CH54RCNTST = "CH54RCNTST";

        /// <summary>
        /// CH54RCTJ.
        /// </summary>
        public const string CH54RCTJ = "CH54RCTJ";

        /// <summary>
        /// CH54RCTT.
        /// </summary>
        public const string CH54RCTT = "CH54RCTT";

        /// <summary>
        /// CH54RCSD.
        /// </summary>
        public const string CH54RCSD = "CH54RCSD";

        /// <summary>
        /// CH54RCST.
        /// </summary>
        public const string CH54RCST = "CH54RCST";

        /// <summary>
        /// CH54RCDD.
        /// </summary>
        public const string CH54RCDD = "CH54RCDD";

        /// <summary>
        /// CH54RCDT.
        /// </summary>
        public const string CH54RCDT = "CH54RCDT";

        /// <summary>
        /// CH54RCDAD.
        /// </summary>
        public const string CH54RCDAD = "CH54RCDAD";

        /// <summary>
        /// CH54RCDAT.
        /// </summary>
        public const string CH54RCDAT = "CH54RCDAT";

        /// <summary>
        /// CH54RCID.
        /// </summary>
        public const string CH54RCID = "CH54RCID";

        /// <summary>
        /// CH54RCIT.
        /// </summary>
        public const string CH54RCIT = "CH54RCIT";

        /// <summary>
        /// CH54RCPED.
        /// </summary>
        public const string CH54RCPED = "CH54RCPED";

        /// <summary>
        /// CH54RCPET.
        /// </summary>
        public const string CH54RCPET = "CH54RCPET";

        /// <summary>
        /// CH54RCAED.
        /// </summary>
        public const string CH54RCAED = "CH54RCAED";

        /// <summary>
        /// CH54RCAET.
        /// </summary>
        public const string CH54RCAET = "CH54RCAET";

        /// <summary>
        /// CH54RCBSD.
        /// </summary>
        public const string CH54RCBSD = "CH54RCBSD";

        /// <summary>
        /// CH54RCBST.
        /// </summary>
        public const string CH54RCBST = "CH54RCBST";

        /// <summary>
        /// CH54RCBED.
        /// </summary>
        public const string CH54RCBED = "CH54RCBED";

        /// <summary>
        /// CH54RCBET.
        /// </summary>
        public const string CH54RCBET = "CH54RCBET";

        /// <summary>
        /// CHDLIJ.
        /// </summary>
        public const string CHDLIJ = "CHDLIJ";

        /// <summary>
        /// CHVR01.
        /// </summary>
        public const string CHVR01 = "CHVR01";

        /// <summary>
        /// CHVR02.
        /// </summary>
        public const string CHVR02 = "CHVR02";

        /// <summary>
        /// CHVR03.
        /// </summary>
        public const string CHVR03 = "CHVR03";

        /// <summary>
        /// CHDEL1.
        /// </summary>
        public const string CHDEL1 = "CHDEL1";

        /// <summary>
        /// CHDEL2.
        /// </summary>
        public const string CHDEL2 = "CHDEL2";

        /// <summary>
        /// CH54RARSVD.
        /// </summary>
        public const string CH54RARSVD = "CH54RARSVD";

        /// <summary>
        /// CH54RCRD.
        /// </summary>
        public const string CH54RCRD = "CH54RCRD";

        /// <summary>
        /// CH54RCRT.
        /// </summary>
        public const string CH54RCRT = "CH54RCRT";

        /// <summary>
        /// CH54RCRCD.
        /// </summary>
        public const string CH54RCRCD = "CH54RCRCD";

        /// <summary>
        /// CH54RCRCT.
        /// </summary>
        public const string CH54RCRCT = "CH54RCRCT";

        /// <summary>
        /// CH54RMSTRC.
        /// </summary>
        public const string CH54RMSTRC = "CH54RMSTRC";

        /// <summary>
        /// CHPTC.
        /// </summary>
        public const string CHPTC = "CHPTC";

        /// <summary>
        /// CHRYIN.
        /// </summary>
        public const string CHRYIN = "CHRYIN";

        /// <summary>
        /// CHASN.
        /// </summary>
        public const string CHASN = "CHASN";

        /// <summary>
        /// CHPRGP.
        /// </summary>
        public const string CHPRGP = "CHPRGP";

        /// <summary>
        /// CHTRDC.
        /// </summary>
        public const string CHTRDC = "CHTRDC";

        /// <summary>
        /// CHEXR1.
        /// </summary>
        public const string CHEXR1 = "CHEXR1";

        /// <summary>
        /// CHTXA1.
        /// </summary>
        public const string CHTXA1 = "CHTXA1";

        /// <summary>
        /// CHTXCT.
        /// </summary>
        public const string CHTXCT = "CHTXCT";

        /// <summary>
        /// CHHOLD.
        /// </summary>
        public const string CHHOLD = "CHHOLD";

        /// <summary>
        /// CHNTR.
        /// </summary>
        public const string CHNTR = "CHNTR";

        /// <summary>
        /// CHCARS.
        /// </summary>
        public const string CHCARS = "CHCARS";

        /// <summary>
        /// CHMOT.
        /// </summary>
        public const string CHMOT = "CHMOT";

        /// <summary>
        /// CHCOT.
        /// </summary>
        public const string CHCOT = "CHCOT";

        /// <summary>
        /// CHROUT.
        /// </summary>
        public const string CHROUT = "CHROUT";

        /// <summary>
        /// CHSTOP.
        /// </summary>
        public const string CHSTOP = "CHSTOP";

        /// <summary>
        /// CHZON.
        /// </summary>
        public const string CHZON = "CHZON";

        /// <summary>
        /// CHCNID.
        /// </summary>
        public const string CHCNID = "CHCNID";

        /// <summary>
        /// CHFRTH.
        /// </summary>
        public const string CHFRTH = "CHFRTH";

        /// <summary>
        /// CHAFT.
        /// </summary>
        public const string CHAFT = "CHAFT";

        /// <summary>
        /// CHCACT.
        /// </summary>
        public const string CHCACT = "CHCACT";

        /// <summary>
        /// CHCEXP.
        /// </summary>
        public const string CHCEXP = "CHCEXP";

        /// <summary>
        /// CHCRRM.
        /// </summary>
        public const string CHCRRM = "CHCRRM";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHCRR.
        /// </summary>
        public const string CHCRR = "CHCRR";

        /// <summary>
        /// CHBCRC.
        /// </summary>
        public const string CHBCRC = "CHBCRC";

        /// <summary>
        /// CHERDT.
        /// </summary>
        public const string CHERDT = "CHERDT";

        /// <summary>
        /// CHBILLCRCD.
        /// </summary>
        public const string CHBILLCRCD = "CHBILLCRCD";

        /// <summary>
        /// CHORBY.
        /// </summary>
        public const string CHORBY = "CHORBY";

        /// <summary>
        /// CHTKBY.
        /// </summary>
        public const string CHTKBY = "CHTKBY";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHENTJ.
        /// </summary>
        public const string CHENTJ = "CHENTJ";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHMKEY.
        /// </summary>
        public const string CHMKEY = "CHMKEY";

        /// <summary>
        /// CHTORG.
        /// </summary>
        public const string CHTORG = "CHTORG";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHTENT.
        /// </summary>
        public const string CHTENT = "CHTENT";

        /// <summary>
        /// CH54RIT.
        /// </summary>
        public const string CH54RIT = "CH54RIT";

        /// <summary>
        /// CH54RIP.
        /// </summary>
        public const string CH54RIP = "CH54RIP";

        /// <summary>
        /// CH54RXRFV.
        /// </summary>
        public const string CH54RXRFV = "CH54RXRFV";

        /// <summary>
        /// CH54RRTO.
        /// </summary>
        public const string CH54RRTO = "CH54RRTO";

        /// <summary>
        /// CH54RUSRD1.
        /// </summary>
        public const string CH54RUSRD1 = "CH54RUSRD1";

        /// <summary>
        /// CH54RUSRD2.
        /// </summary>
        public const string CH54RUSRD2 = "CH54RUSRD2";

        /// <summary>
        /// CH54RUSRD3.
        /// </summary>
        public const string CH54RUSRD3 = "CH54RUSRD3";

        /// <summary>
        /// CH54RUSRT1.
        /// </summary>
        public const string CH54RUSRT1 = "CH54RUSRT1";

        /// <summary>
        /// CH54RUSRT2.
        /// </summary>
        public const string CH54RUSRT2 = "CH54RUSRT2";

        /// <summary>
        /// CH54RUSRT3.
        /// </summary>
        public const string CH54RUSRT3 = "CH54RUSRT3";

        /// <summary>
        /// CH54RUSNB1.
        /// </summary>
        public const string CH54RUSNB1 = "CH54RUSNB1";

        /// <summary>
        /// CH54RUSNB2.
        /// </summary>
        public const string CH54RUSNB2 = "CH54RUSNB2";

        /// <summary>
        /// CH54RUSNB3.
        /// </summary>
        public const string CH54RUSNB3 = "CH54RUSNB3";

        /// <summary>
        /// CH54RTEMPL.
        /// </summary>
        public const string CH54RTEMPL = "CH54RTEMPL";

        /// <summary>
        /// CH54RDBILL.
        /// </summary>
        public const string CH54RDBILL = "CH54RDBILL";

        /// <summary>
        /// CH54RLEASE.
        /// </summary>
        public const string CH54RLEASE = "CH54RLEASE";

        /// <summary>
        /// CH54RLSTY.
        /// </summary>
        public const string CH54RLSTY = "CH54RLSTY";

        /// <summary>
        /// CHRP01.
        /// </summary>
        public const string CHRP01 = "CHRP01";

        /// <summary>
        /// CHRP02.
        /// </summary>
        public const string CHRP02 = "CHRP02";

        /// <summary>
        /// CHRP03.
        /// </summary>
        public const string CHRP03 = "CHRP03";

        /// <summary>
        /// CHRP04.
        /// </summary>
        public const string CHRP04 = "CHRP04";

        /// <summary>
        /// CHRP05.
        /// </summary>
        public const string CHRP05 = "CHRP05";

        /// <summary>
        /// CHRP06.
        /// </summary>
        public const string CHRP06 = "CHRP06";

        /// <summary>
        /// CHRP07.
        /// </summary>
        public const string CHRP07 = "CHRP07";

        /// <summary>
        /// CHRP08.
        /// </summary>
        public const string CHRP08 = "CHRP08";

        /// <summary>
        /// CHRP09.
        /// </summary>
        public const string CHRP09 = "CHRP09";

        /// <summary>
        /// CHRP10.
        /// </summary>
        public const string CHRP10 = "CHRP10";

        /// <summary>
        /// CHRP11.
        /// </summary>
        public const string CHRP11 = "CHRP11";

        /// <summary>
        /// CHRP12.
        /// </summary>
        public const string CHRP12 = "CHRP12";

        /// <summary>
        /// CHRP13.
        /// </summary>
        public const string CHRP13 = "CHRP13";

        /// <summary>
        /// CHRP14.
        /// </summary>
        public const string CHRP14 = "CHRP14";

        /// <summary>
        /// CHRP15.
        /// </summary>
        public const string CHRP15 = "CHRP15";

        /// <summary>
        /// CHRP16.
        /// </summary>
        public const string CHRP16 = "CHRP16";

        /// <summary>
        /// CHRP17.
        /// </summary>
        public const string CHRP17 = "CHRP17";

        /// <summary>
        /// CHRP18.
        /// </summary>
        public const string CHRP18 = "CHRP18";

        /// <summary>
        /// CHRP19.
        /// </summary>
        public const string CHRP19 = "CHRP19";

        /// <summary>
        /// CHRP20.
        /// </summary>
        public const string CHRP20 = "CHRP20";

        /// <summary>
        /// CH54RSALE1.
        /// </summary>
        public const string CH54RSALE1 = "CH54RSALE1";

        /// <summary>
        /// CH54RSALE2.
        /// </summary>
        public const string CH54RSALE2 = "CH54RSALE2";

        /// <summary>
        /// CH54RAUTN.
        /// </summary>
        public const string CH54RAUTN = "CH54RAUTN";

        /// <summary>
        /// CH54RLNGP.
        /// </summary>
        public const string CH54RLNGP = "CH54RLNGP";

        /// <summary>
        /// CH54RRQSB.
        /// </summary>
        public const string CH54RRQSB = "CH54RRQSB";

        /// <summary>
        /// CH54RDEF01.
        /// </summary>
        public const string CH54RDEF01 = "CH54RDEF01";

        /// <summary>
        /// CH54RDEF02.
        /// </summary>
        public const string CH54RDEF02 = "CH54RDEF02";

        /// <summary>
        /// CH54RDEF03.
        /// </summary>
        public const string CH54RDEF03 = "CH54RDEF03";

        /// <summary>
        /// CH54RBCRR.
        /// </summary>
        public const string CH54RBCRR = "CH54RBCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F54R10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHDOCO", "CHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDCTO", "CHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CHKCOO", "CHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHCO", "CHCO", JdeDataType.String, 10),
        new JdeField("CHRKCO", "CHRKCO", JdeDataType.String, 10),
        new JdeField("CHRORN", "CHRORN", JdeDataType.String, 16),
        new JdeField("CHRCTO", "CHRCTO", JdeDataType.String, 4),
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric),
        new JdeField("CHSHAN", "CHSHAN", JdeDataType.Numeric),
        new JdeField("CHDVAN", "CHDVAN", JdeDataType.Numeric),
        new JdeField("CHPA8", "CHPA8", JdeDataType.Numeric),
        new JdeField("CHPBAN", "CHPBAN", JdeDataType.Numeric),
        new JdeField("CHITAN", "CHITAN", JdeDataType.Numeric),
        new JdeField("CHFTAN", "CHFTAN", JdeDataType.Numeric),
        new JdeField("CH54RREF1", "CH54RREF1", JdeDataType.String, 100),
        new JdeField("CH54RREF2", "CH54RREF2", JdeDataType.String, 100),
        new JdeField("CHBLFC", "CHBLFC", JdeDataType.String, 2),
        new JdeField("CH54RCNTST", "CH54RCNTST", JdeDataType.String, 6),
        new JdeField("CH54RCTJ", "CH54RCTJ", JdeDataType.Numeric),
        new JdeField("CH54RCTT", "CH54RCTT", JdeDataType.Numeric),
        new JdeField("CH54RCSD", "CH54RCSD", JdeDataType.Numeric),
        new JdeField("CH54RCST", "CH54RCST", JdeDataType.Numeric),
        new JdeField("CH54RCDD", "CH54RCDD", JdeDataType.Numeric),
        new JdeField("CH54RCDT", "CH54RCDT", JdeDataType.Numeric),
        new JdeField("CH54RCDAD", "CH54RCDAD", JdeDataType.Numeric),
        new JdeField("CH54RCDAT", "CH54RCDAT", JdeDataType.Numeric),
        new JdeField("CH54RCID", "CH54RCID", JdeDataType.Numeric),
        new JdeField("CH54RCIT", "CH54RCIT", JdeDataType.Numeric),
        new JdeField("CH54RCPED", "CH54RCPED", JdeDataType.Numeric),
        new JdeField("CH54RCPET", "CH54RCPET", JdeDataType.Numeric),
        new JdeField("CH54RCAED", "CH54RCAED", JdeDataType.Numeric),
        new JdeField("CH54RCAET", "CH54RCAET", JdeDataType.Numeric),
        new JdeField("CH54RCBSD", "CH54RCBSD", JdeDataType.Numeric),
        new JdeField("CH54RCBST", "CH54RCBST", JdeDataType.Numeric),
        new JdeField("CH54RCBED", "CH54RCBED", JdeDataType.Numeric),
        new JdeField("CH54RCBET", "CH54RCBET", JdeDataType.Numeric),
        new JdeField("CHDLIJ", "CHDLIJ", JdeDataType.Numeric),
        new JdeField("CHVR01", "CHVR01", JdeDataType.String, 50),
        new JdeField("CHVR02", "CHVR02", JdeDataType.String, 50),
        new JdeField("CHVR03", "CHVR03", JdeDataType.String, 50),
        new JdeField("CHDEL1", "CHDEL1", JdeDataType.String, 60),
        new JdeField("CHDEL2", "CHDEL2", JdeDataType.String, 60),
        new JdeField("CH54RARSVD", "CH54RARSVD", JdeDataType.String, 2),
        new JdeField("CH54RCRD", "CH54RCRD", JdeDataType.Numeric),
        new JdeField("CH54RCRT", "CH54RCRT", JdeDataType.Numeric),
        new JdeField("CH54RCRCD", "CH54RCRCD", JdeDataType.Numeric),
        new JdeField("CH54RCRCT", "CH54RCRCT", JdeDataType.Numeric),
        new JdeField("CH54RMSTRC", "CH54RMSTRC", JdeDataType.String, 20),
        new JdeField("CHPTC", "CHPTC", JdeDataType.String, 6),
        new JdeField("CHRYIN", "CHRYIN", JdeDataType.String, 2),
        new JdeField("CHASN", "CHASN", JdeDataType.String, 16),
        new JdeField("CHPRGP", "CHPRGP", JdeDataType.String, 16),
        new JdeField("CHTRDC", "CHTRDC", JdeDataType.Numeric),
        new JdeField("CHEXR1", "CHEXR1", JdeDataType.String, 4),
        new JdeField("CHTXA1", "CHTXA1", JdeDataType.String, 20),
        new JdeField("CHTXCT", "CHTXCT", JdeDataType.String, 40),
        new JdeField("CHHOLD", "CHHOLD", JdeDataType.String, 4),
        new JdeField("CHNTR", "CHNTR", JdeDataType.String, 4),
        new JdeField("CHCARS", "CHCARS", JdeDataType.Numeric),
        new JdeField("CHMOT", "CHMOT", JdeDataType.String, 6),
        new JdeField("CHCOT", "CHCOT", JdeDataType.String, 6),
        new JdeField("CHROUT", "CHROUT", JdeDataType.String, 6),
        new JdeField("CHSTOP", "CHSTOP", JdeDataType.String, 6),
        new JdeField("CHZON", "CHZON", JdeDataType.String, 6),
        new JdeField("CHCNID", "CHCNID", JdeDataType.String, 40),
        new JdeField("CHFRTH", "CHFRTH", JdeDataType.String, 6),
        new JdeField("CHAFT", "CHAFT", JdeDataType.String, 2),
        new JdeField("CHCACT", "CHCACT", JdeDataType.String, 50),
        new JdeField("CHCEXP", "CHCEXP", JdeDataType.Numeric),
        new JdeField("CHCRRM", "CHCRRM", JdeDataType.String, 2),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHCRR", "CHCRR", JdeDataType.Numeric),
        new JdeField("CHBCRC", "CHBCRC", JdeDataType.String, 6),
        new JdeField("CHERDT", "CHERDT", JdeDataType.Numeric),
        new JdeField("CHBILLCRCD", "CHBILLCRCD", JdeDataType.String, 6),
        new JdeField("CHORBY", "CHORBY", JdeDataType.String, 20),
        new JdeField("CHTKBY", "CHTKBY", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHENTJ", "CHENTJ", JdeDataType.Numeric),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHMKEY", "CHMKEY", JdeDataType.String, 30),
        new JdeField("CHTORG", "CHTORG", JdeDataType.String, 20),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHTENT", "CHTENT", JdeDataType.Numeric),
        new JdeField("CH54RIT", "CH54RIT", JdeDataType.String, 4),
        new JdeField("CH54RIP", "CH54RIP", JdeDataType.String, 60),
        new JdeField("CH54RXRFV", "CH54RXRFV", JdeDataType.String, 2),
        new JdeField("CH54RRTO", "CH54RRTO", JdeDataType.String, 2),
        new JdeField("CH54RUSRD1", "CH54RUSRD1", JdeDataType.Numeric),
        new JdeField("CH54RUSRD2", "CH54RUSRD2", JdeDataType.Numeric),
        new JdeField("CH54RUSRD3", "CH54RUSRD3", JdeDataType.Numeric),
        new JdeField("CH54RUSRT1", "CH54RUSRT1", JdeDataType.Numeric),
        new JdeField("CH54RUSRT2", "CH54RUSRT2", JdeDataType.Numeric),
        new JdeField("CH54RUSRT3", "CH54RUSRT3", JdeDataType.Numeric),
        new JdeField("CH54RUSNB1", "CH54RUSNB1", JdeDataType.Numeric),
        new JdeField("CH54RUSNB2", "CH54RUSNB2", JdeDataType.Numeric),
        new JdeField("CH54RUSNB3", "CH54RUSNB3", JdeDataType.Numeric),
        new JdeField("CH54RTEMPL", "CH54RTEMPL", JdeDataType.String, 2),
        new JdeField("CH54RDBILL", "CH54RDBILL", JdeDataType.String, 2),
        new JdeField("CH54RLEASE", "CH54RLEASE", JdeDataType.String, 2),
        new JdeField("CH54RLSTY", "CH54RLSTY", JdeDataType.String, 4),
        new JdeField("CHRP01", "CHRP01", JdeDataType.String, 6),
        new JdeField("CHRP02", "CHRP02", JdeDataType.String, 6),
        new JdeField("CHRP03", "CHRP03", JdeDataType.String, 6),
        new JdeField("CHRP04", "CHRP04", JdeDataType.String, 6),
        new JdeField("CHRP05", "CHRP05", JdeDataType.String, 6),
        new JdeField("CHRP06", "CHRP06", JdeDataType.String, 6),
        new JdeField("CHRP07", "CHRP07", JdeDataType.String, 6),
        new JdeField("CHRP08", "CHRP08", JdeDataType.String, 6),
        new JdeField("CHRP09", "CHRP09", JdeDataType.String, 6),
        new JdeField("CHRP10", "CHRP10", JdeDataType.String, 6),
        new JdeField("CHRP11", "CHRP11", JdeDataType.String, 6),
        new JdeField("CHRP12", "CHRP12", JdeDataType.String, 6),
        new JdeField("CHRP13", "CHRP13", JdeDataType.String, 6),
        new JdeField("CHRP14", "CHRP14", JdeDataType.String, 6),
        new JdeField("CHRP15", "CHRP15", JdeDataType.String, 6),
        new JdeField("CHRP16", "CHRP16", JdeDataType.String, 6),
        new JdeField("CHRP17", "CHRP17", JdeDataType.String, 6),
        new JdeField("CHRP18", "CHRP18", JdeDataType.String, 6),
        new JdeField("CHRP19", "CHRP19", JdeDataType.String, 6),
        new JdeField("CHRP20", "CHRP20", JdeDataType.String, 6),
        new JdeField("CH54RSALE1", "CH54RSALE1", JdeDataType.Numeric),
        new JdeField("CH54RSALE2", "CH54RSALE2", JdeDataType.Numeric),
        new JdeField("CH54RAUTN", "CH54RAUTN", JdeDataType.String, 20),
        new JdeField("CH54RLNGP", "CH54RLNGP", JdeDataType.String, 4),
        new JdeField("CH54RRQSB", "CH54RRQSB", JdeDataType.Numeric),
        new JdeField("CH54RDEF01", "CH54RDEF01", JdeDataType.String, 2),
        new JdeField("CH54RDEF02", "CH54RDEF02", JdeDataType.String, 2),
        new JdeField("CH54RDEF03", "CH54RDEF03", JdeDataType.String, 2),
        new JdeField("CH54RBCRR", "CH54RBCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R10_0", "Primary Key on CHDOCO, CHDCTO, CHKCOO", new[] { "CHDOCO", "CHDCTO", "CHKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
