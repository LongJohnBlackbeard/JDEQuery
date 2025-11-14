using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051375 - .
/// </summary>
public class F051375 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADCHGF.
        /// </summary>
        public const string ADCHGF = "ADCHGF";

        /// <summary>
        /// ADPAYBN.
        /// </summary>
        public const string ADPAYBN = "ADPAYBN";

        /// <summary>
        /// ADANN8.
        /// </summary>
        public const string ADANN8 = "ADANN8";

        /// <summary>
        /// ADEXA.
        /// </summary>
        public const string ADEXA = "ADEXA";

        /// <summary>
        /// ADDC.
        /// </summary>
        public const string ADDC = "ADDC";

        /// <summary>
        /// ADPGRP.
        /// </summary>
        public const string ADPGRP = "ADPGRP";

        /// <summary>
        /// ADPAYG.
        /// </summary>
        public const string ADPAYG = "ADPAYG";

        /// <summary>
        /// ADPAYN.
        /// </summary>
        public const string ADPAYN = "ADPAYN";

        /// <summary>
        /// ADDTAB.
        /// </summary>
        public const string ADDTAB = "ADDTAB";

        /// <summary>
        /// ADSPW2.
        /// </summary>
        public const string ADSPW2 = "ADSPW2";

        /// <summary>
        /// ADPB.
        /// </summary>
        public const string ADPB = "ADPB";

        /// <summary>
        /// ADDESQ.
        /// </summary>
        public const string ADDESQ = "ADDESQ";

        /// <summary>
        /// ADMV.
        /// </summary>
        public const string ADMV = "ADMV";

        /// <summary>
        /// ADDISO.
        /// </summary>
        public const string ADDISO = "ADDISO";

        /// <summary>
        /// ADPDBA.
        /// </summary>
        public const string ADPDBA = "ADPDBA";

        /// <summary>
        /// ADPCK.
        /// </summary>
        public const string ADPCK = "ADPCK";

        /// <summary>
        /// ADDEDM.
        /// </summary>
        public const string ADDEDM = "ADDEDM";

        /// <summary>
        /// ADUM.
        /// </summary>
        public const string ADUM = "ADUM";

        /// <summary>
        /// ADRTAM.
        /// </summary>
        public const string ADRTAM = "ADRTAM";

        /// <summary>
        /// ADPAYM.
        /// </summary>
        public const string ADPAYM = "ADPAYM";

        /// <summary>
        /// ADSHD.
        /// </summary>
        public const string ADSHD = "ADSHD";

        /// <summary>
        /// ADCMTH.
        /// </summary>
        public const string ADCMTH = "ADCMTH";

        /// <summary>
        /// ADPPDL.
        /// </summary>
        public const string ADPPDL = "ADPPDL";

        /// <summary>
        /// ADMDL.
        /// </summary>
        public const string ADMDL = "ADMDL";

        /// <summary>
        /// ADADL.
        /// </summary>
        public const string ADADL = "ADADL";

        /// <summary>
        /// ADPPPL.
        /// </summary>
        public const string ADPPPL = "ADPPPL";

        /// <summary>
        /// ADNP.
        /// </summary>
        public const string ADNP = "ADNP";

        /// <summary>
        /// ADAD.
        /// </summary>
        public const string ADAD = "ADAD";

        /// <summary>
        /// ADACO.
        /// </summary>
        public const string ADACO = "ADACO";

        /// <summary>
        /// ADAI.
        /// </summary>
        public const string ADAI = "ADAI";

        /// <summary>
        /// ADHMIN.
        /// </summary>
        public const string ADHMIN = "ADHMIN";

        /// <summary>
        /// ADHMAX.
        /// </summary>
        public const string ADHMAX = "ADHMAX";

        /// <summary>
        /// ADIIAP.
        /// </summary>
        public const string ADIIAP = "ADIIAP";

        /// <summary>
        /// ADDEP1.
        /// </summary>
        public const string ADDEP1 = "ADDEP1";

        /// <summary>
        /// ADDEP2.
        /// </summary>
        public const string ADDEP2 = "ADDEP2";

        /// <summary>
        /// ADDEP3.
        /// </summary>
        public const string ADDEP3 = "ADDEP3";

        /// <summary>
        /// ADDEP4.
        /// </summary>
        public const string ADDEP4 = "ADDEP4";

        /// <summary>
        /// ADDEP5.
        /// </summary>
        public const string ADDEP5 = "ADDEP5";

        /// <summary>
        /// ADDEP6.
        /// </summary>
        public const string ADDEP6 = "ADDEP6";

        /// <summary>
        /// ADTT01.
        /// </summary>
        public const string ADTT01 = "ADTT01";

        /// <summary>
        /// ADTT02.
        /// </summary>
        public const string ADTT02 = "ADTT02";

        /// <summary>
        /// ADTT03.
        /// </summary>
        public const string ADTT03 = "ADTT03";

        /// <summary>
        /// ADTT04.
        /// </summary>
        public const string ADTT04 = "ADTT04";

        /// <summary>
        /// ADTT05.
        /// </summary>
        public const string ADTT05 = "ADTT05";

        /// <summary>
        /// ADTT06.
        /// </summary>
        public const string ADTT06 = "ADTT06";

        /// <summary>
        /// ADTT07.
        /// </summary>
        public const string ADTT07 = "ADTT07";

        /// <summary>
        /// ADTT08.
        /// </summary>
        public const string ADTT08 = "ADTT08";

        /// <summary>
        /// ADTT09.
        /// </summary>
        public const string ADTT09 = "ADTT09";

        /// <summary>
        /// ADTT10.
        /// </summary>
        public const string ADTT10 = "ADTT10";

        /// <summary>
        /// ADTT11.
        /// </summary>
        public const string ADTT11 = "ADTT11";

        /// <summary>
        /// ADTT12.
        /// </summary>
        public const string ADTT12 = "ADTT12";

        /// <summary>
        /// ADTT13.
        /// </summary>
        public const string ADTT13 = "ADTT13";

        /// <summary>
        /// ADTT14.
        /// </summary>
        public const string ADTT14 = "ADTT14";

        /// <summary>
        /// ADTT15.
        /// </summary>
        public const string ADTT15 = "ADTT15";

        /// <summary>
        /// ADNMTH.
        /// </summary>
        public const string ADNMTH = "ADNMTH";

        /// <summary>
        /// ADPDED.
        /// </summary>
        public const string ADPDED = "ADPDED";

        /// <summary>
        /// ADDPRI.
        /// </summary>
        public const string ADDPRI = "ADDPRI";

        /// <summary>
        /// ADDGRP.
        /// </summary>
        public const string ADDGRP = "ADDGRP";

        /// <summary>
        /// ADDBAL.
        /// </summary>
        public const string ADDBAL = "ADDBAL";

        /// <summary>
        /// ADARRR.
        /// </summary>
        public const string ADARRR = "ADARRR";

        /// <summary>
        /// ADNPER.
        /// </summary>
        public const string ADNPER = "ADNPER";

        /// <summary>
        /// ADSVCD.
        /// </summary>
        public const string ADSVCD = "ADSVCD";

        /// <summary>
        /// ADQDL.
        /// </summary>
        public const string ADQDL = "ADQDL";

        /// <summary>
        /// ADSVH.
        /// </summary>
        public const string ADSVH = "ADSVH";

        /// <summary>
        /// ADAAF.
        /// </summary>
        public const string ADAAF = "ADAAF";

        /// <summary>
        /// ADPTCT.
        /// </summary>
        public const string ADPTCT = "ADPTCT";

        /// <summary>
        /// ADCPE.
        /// </summary>
        public const string ADCPE = "ADCPE";

        /// <summary>
        /// ADEFTB.
        /// </summary>
        public const string ADEFTB = "ADEFTB";

        /// <summary>
        /// ADEFTE.
        /// </summary>
        public const string ADEFTE = "ADEFTE";

        /// <summary>
        /// ADACEQ.
        /// </summary>
        public const string ADACEQ = "ADACEQ";

        /// <summary>
        /// ADSADL.
        /// </summary>
        public const string ADSADL = "ADSADL";

        /// <summary>
        /// ADSDED.
        /// </summary>
        public const string ADSDED = "ADSDED";

        /// <summary>
        /// ADAMTS.
        /// </summary>
        public const string ADAMTS = "ADAMTS";

        /// <summary>
        /// ADPR01.
        /// </summary>
        public const string ADPR01 = "ADPR01";

        /// <summary>
        /// ADPR02.
        /// </summary>
        public const string ADPR02 = "ADPR02";

        /// <summary>
        /// ADPR03.
        /// </summary>
        public const string ADPR03 = "ADPR03";

        /// <summary>
        /// ADPR04.
        /// </summary>
        public const string ADPR04 = "ADPR04";

        /// <summary>
        /// ADPR05.
        /// </summary>
        public const string ADPR05 = "ADPR05";

        /// <summary>
        /// ADTASF.
        /// </summary>
        public const string ADTASF = "ADTASF";

        /// <summary>
        /// ADTRPF.
        /// </summary>
        public const string ADTRPF = "ADTRPF";

        /// <summary>
        /// ADSALY.
        /// </summary>
        public const string ADSALY = "ADSALY";

        /// <summary>
        /// ADCOVA.
        /// </summary>
        public const string ADCOVA = "ADCOVA";

        /// <summary>
        /// ADTRID.
        /// </summary>
        public const string ADTRID = "ADTRID";

        /// <summary>
        /// ADTYST.
        /// </summary>
        public const string ADTYST = "ADTYST";

        /// <summary>
        /// ADBENF.
        /// </summary>
        public const string ADBENF = "ADBENF";

        /// <summary>
        /// ADPPPM.
        /// </summary>
        public const string ADPPPM = "ADPPPM";

        /// <summary>
        /// ADEPRI.
        /// </summary>
        public const string ADEPRI = "ADEPRI";

        /// <summary>
        /// ADPTER.
        /// </summary>
        public const string ADPTER = "ADPTER";

        /// <summary>
        /// ADSTAB.
        /// </summary>
        public const string ADSTAB = "ADSTAB";

        /// <summary>
        /// ADCMAX.
        /// </summary>
        public const string ADCMAX = "ADCMAX";

        /// <summary>
        /// ADRTAB.
        /// </summary>
        public const string ADRTAB = "ADRTAB";

        /// <summary>
        /// ADTARA.
        /// </summary>
        public const string ADTARA = "ADTARA";

        /// <summary>
        /// ADHMCO.
        /// </summary>
        public const string ADHMCO = "ADHMCO";

        /// <summary>
        /// ADPGM1.
        /// </summary>
        public const string ADPGM1 = "ADPGM1";

        /// <summary>
        /// ADPGM2.
        /// </summary>
        public const string ADPGM2 = "ADPGM2";

        /// <summary>
        /// ADTDBA.
        /// </summary>
        public const string ADTDBA = "ADTDBA";

        /// <summary>
        /// ADCMHU.
        /// </summary>
        public const string ADCMHU = "ADCMHU";

        /// <summary>
        /// ADBDT.
        /// </summary>
        public const string ADBDT = "ADBDT";

        /// <summary>
        /// ADDBAS.
        /// </summary>
        public const string ADDBAS = "ADDBAS";

        /// <summary>
        /// ADUDBA.
        /// </summary>
        public const string ADUDBA = "ADUDBA";

        /// <summary>
        /// ADAIGR.
        /// </summary>
        public const string ADAIGR = "ADAIGR";

        /// <summary>
        /// ADPR06.
        /// </summary>
        public const string ADPR06 = "ADPR06";

        /// <summary>
        /// ADPR07.
        /// </summary>
        public const string ADPR07 = "ADPR07";

        /// <summary>
        /// ADPR08.
        /// </summary>
        public const string ADPR08 = "ADPR08";

        /// <summary>
        /// ADPR09.
        /// </summary>
        public const string ADPR09 = "ADPR09";

        /// <summary>
        /// ADPR10.
        /// </summary>
        public const string ADPR10 = "ADPR10";

        /// <summary>
        /// ADPR11.
        /// </summary>
        public const string ADPR11 = "ADPR11";

        /// <summary>
        /// ADPR12.
        /// </summary>
        public const string ADPR12 = "ADPR12";

        /// <summary>
        /// ADPR13.
        /// </summary>
        public const string ADPR13 = "ADPR13";

        /// <summary>
        /// ADPR14.
        /// </summary>
        public const string ADPR14 = "ADPR14";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPR15.
        /// </summary>
        public const string ADPR15 = "ADPR15";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADPR16.
        /// </summary>
        public const string ADPR16 = "ADPR16";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADPR17.
        /// </summary>
        public const string ADPR17 = "ADPR17";

        /// <summary>
        /// ADPR18.
        /// </summary>
        public const string ADPR18 = "ADPR18";

        /// <summary>
        /// ADPR19.
        /// </summary>
        public const string ADPR19 = "ADPR19";

        /// <summary>
        /// ADPR20.
        /// </summary>
        public const string ADPR20 = "ADPR20";

        /// <summary>
        /// ADODBA.
        /// </summary>
        public const string ADODBA = "ADODBA";

        /// <summary>
        /// ADSACC.
        /// </summary>
        public const string ADSACC = "ADSACC";

        /// <summary>
        /// ADCALC.
        /// </summary>
        public const string ADCALC = "ADCALC";

        /// <summary>
        /// ADPPRY.
        /// </summary>
        public const string ADPPRY = "ADPPRY";

        /// <summary>
        /// ADGVCH.
        /// </summary>
        public const string ADGVCH = "ADGVCH";

        /// <summary>
        /// ADPRTX.
        /// </summary>
        public const string ADPRTX = "ADPRTX";

        /// <summary>
        /// ADF415.
        /// </summary>
        public const string ADF415 = "ADF415";

        /// <summary>
        /// ADCLCI.
        /// </summary>
        public const string ADCLCI = "ADCLCI";

        /// <summary>
        /// ADRYTP.
        /// </summary>
        public const string ADRYTP = "ADRYTP";

        /// <summary>
        /// ADAFDT.
        /// </summary>
        public const string ADAFDT = "ADAFDT";

        /// <summary>
        /// ADSHDL.
        /// </summary>
        public const string ADSHDL = "ADSHDL";

        /// <summary>
        /// ADCHCK.
        /// </summary>
        public const string ADCHCK = "ADCHCK";

        /// <summary>
        /// ADLVPT.
        /// </summary>
        public const string ADLVPT = "ADLVPT";

        /// <summary>
        /// ADPHISH.
        /// </summary>
        public const string ADPHISH = "ADPHISH";
    }

    /// <inheritdoc />
    public override string TableName => "F051375";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADCHGF", "ADCHGF", JdeDataType.String, 2),
        new JdeField("ADPAYBN", "ADPAYBN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADANN8", "ADANN8", JdeDataType.Numeric),
        new JdeField("ADEXA", "ADEXA", JdeDataType.String, 60),
        new JdeField("ADDC", "ADDC", JdeDataType.String, 80),
        new JdeField("ADPGRP", "ADPGRP", JdeDataType.String, 4),
        new JdeField("ADPAYG", "ADPAYG", JdeDataType.String, 2),
        new JdeField("ADPAYN", "ADPAYN", JdeDataType.String, 2),
        new JdeField("ADDTAB", "ADDTAB", JdeDataType.String, 10),
        new JdeField("ADSPW2", "ADSPW2", JdeDataType.String, 4),
        new JdeField("ADPB", "ADPB", JdeDataType.String, 2),
        new JdeField("ADDESQ", "ADDESQ", JdeDataType.String, 2),
        new JdeField("ADMV", "ADMV", JdeDataType.String, 2),
        new JdeField("ADDISO", "ADDISO", JdeDataType.String, 2),
        new JdeField("ADPDBA", "ADPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("ADPCK", "ADPCK", JdeDataType.String, 2),
        new JdeField("ADDEDM", "ADDEDM", JdeDataType.String, 2),
        new JdeField("ADUM", "ADUM", JdeDataType.String, 4),
        new JdeField("ADRTAM", "ADRTAM", JdeDataType.Numeric),
        new JdeField("ADPAYM", "ADPAYM", JdeDataType.Numeric),
        new JdeField("ADSHD", "ADSHD", JdeDataType.Numeric),
        new JdeField("ADCMTH", "ADCMTH", JdeDataType.String, 2),
        new JdeField("ADPPDL", "ADPPDL", JdeDataType.Numeric),
        new JdeField("ADMDL", "ADMDL", JdeDataType.Numeric),
        new JdeField("ADADL", "ADADL", JdeDataType.Numeric),
        new JdeField("ADPPPL", "ADPPPL", JdeDataType.Numeric),
        new JdeField("ADNP", "ADNP", JdeDataType.Numeric),
        new JdeField("ADAD", "ADAD", JdeDataType.Numeric),
        new JdeField("ADACO", "ADACO", JdeDataType.String, 2),
        new JdeField("ADAI", "ADAI", JdeDataType.String, 2),
        new JdeField("ADHMIN", "ADHMIN", JdeDataType.Numeric),
        new JdeField("ADHMAX", "ADHMAX", JdeDataType.Numeric),
        new JdeField("ADIIAP", "ADIIAP", JdeDataType.String, 2),
        new JdeField("ADDEP1", "ADDEP1", JdeDataType.String, 2),
        new JdeField("ADDEP2", "ADDEP2", JdeDataType.String, 2),
        new JdeField("ADDEP3", "ADDEP3", JdeDataType.String, 2),
        new JdeField("ADDEP4", "ADDEP4", JdeDataType.String, 2),
        new JdeField("ADDEP5", "ADDEP5", JdeDataType.String, 2),
        new JdeField("ADDEP6", "ADDEP6", JdeDataType.String, 2),
        new JdeField("ADTT01", "ADTT01", JdeDataType.String, 4),
        new JdeField("ADTT02", "ADTT02", JdeDataType.String, 4),
        new JdeField("ADTT03", "ADTT03", JdeDataType.String, 4),
        new JdeField("ADTT04", "ADTT04", JdeDataType.String, 4),
        new JdeField("ADTT05", "ADTT05", JdeDataType.String, 4),
        new JdeField("ADTT06", "ADTT06", JdeDataType.String, 4),
        new JdeField("ADTT07", "ADTT07", JdeDataType.String, 4),
        new JdeField("ADTT08", "ADTT08", JdeDataType.String, 4),
        new JdeField("ADTT09", "ADTT09", JdeDataType.String, 4),
        new JdeField("ADTT10", "ADTT10", JdeDataType.String, 4),
        new JdeField("ADTT11", "ADTT11", JdeDataType.String, 4),
        new JdeField("ADTT12", "ADTT12", JdeDataType.String, 4),
        new JdeField("ADTT13", "ADTT13", JdeDataType.String, 4),
        new JdeField("ADTT14", "ADTT14", JdeDataType.String, 4),
        new JdeField("ADTT15", "ADTT15", JdeDataType.String, 4),
        new JdeField("ADNMTH", "ADNMTH", JdeDataType.String, 2),
        new JdeField("ADPDED", "ADPDED", JdeDataType.Numeric),
        new JdeField("ADDPRI", "ADDPRI", JdeDataType.Numeric),
        new JdeField("ADDGRP", "ADDGRP", JdeDataType.String, 4),
        new JdeField("ADDBAL", "ADDBAL", JdeDataType.String, 2),
        new JdeField("ADARRR", "ADARRR", JdeDataType.String, 2),
        new JdeField("ADNPER", "ADNPER", JdeDataType.String, 2),
        new JdeField("ADSVCD", "ADSVCD", JdeDataType.Numeric),
        new JdeField("ADQDL", "ADQDL", JdeDataType.Numeric),
        new JdeField("ADSVH", "ADSVH", JdeDataType.String, 2),
        new JdeField("ADAAF", "ADAAF", JdeDataType.String, 2),
        new JdeField("ADPTCT", "ADPTCT", JdeDataType.String, 2),
        new JdeField("ADCPE", "ADCPE", JdeDataType.Numeric),
        new JdeField("ADEFTB", "ADEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("ADEFTE", "ADEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("ADACEQ", "ADACEQ", JdeDataType.Numeric),
        new JdeField("ADSADL", "ADSADL", JdeDataType.Numeric),
        new JdeField("ADSDED", "ADSDED", JdeDataType.Numeric),
        new JdeField("ADAMTS", "ADAMTS", JdeDataType.Numeric),
        new JdeField("ADPR01", "ADPR01", JdeDataType.String, 6),
        new JdeField("ADPR02", "ADPR02", JdeDataType.String, 6),
        new JdeField("ADPR03", "ADPR03", JdeDataType.String, 6),
        new JdeField("ADPR04", "ADPR04", JdeDataType.String, 6),
        new JdeField("ADPR05", "ADPR05", JdeDataType.String, 6),
        new JdeField("ADTASF", "ADTASF", JdeDataType.String, 2),
        new JdeField("ADTRPF", "ADTRPF", JdeDataType.String, 2),
        new JdeField("ADSALY", "ADSALY", JdeDataType.String, 2),
        new JdeField("ADCOVA", "ADCOVA", JdeDataType.Numeric),
        new JdeField("ADTRID", "ADTRID", JdeDataType.String, 4),
        new JdeField("ADTYST", "ADTYST", JdeDataType.String, 2),
        new JdeField("ADBENF", "ADBENF", JdeDataType.String, 2),
        new JdeField("ADPPPM", "ADPPPM", JdeDataType.Numeric),
        new JdeField("ADEPRI", "ADEPRI", JdeDataType.String, 2),
        new JdeField("ADPTER", "ADPTER", JdeDataType.String, 2),
        new JdeField("ADSTAB", "ADSTAB", JdeDataType.String, 10),
        new JdeField("ADCMAX", "ADCMAX", JdeDataType.Numeric),
        new JdeField("ADRTAB", "ADRTAB", JdeDataType.String, 10),
        new JdeField("ADTARA", "ADTARA", JdeDataType.String, 20),
        new JdeField("ADHMCO", "ADHMCO", JdeDataType.String, 10),
        new JdeField("ADPGM1", "ADPGM1", JdeDataType.String, 20),
        new JdeField("ADPGM2", "ADPGM2", JdeDataType.String, 20),
        new JdeField("ADTDBA", "ADTDBA", JdeDataType.String, 2),
        new JdeField("ADCMHU", "ADCMHU", JdeDataType.String, 2),
        new JdeField("ADBDT", "ADBDT", JdeDataType.String, 8),
        new JdeField("ADDBAS", "ADDBAS", JdeDataType.String, 2),
        new JdeField("ADUDBA", "ADUDBA", JdeDataType.String, 2),
        new JdeField("ADAIGR", "ADAIGR", JdeDataType.String, 2),
        new JdeField("ADPR06", "ADPR06", JdeDataType.String, 6),
        new JdeField("ADPR07", "ADPR07", JdeDataType.String, 6),
        new JdeField("ADPR08", "ADPR08", JdeDataType.String, 6),
        new JdeField("ADPR09", "ADPR09", JdeDataType.String, 6),
        new JdeField("ADPR10", "ADPR10", JdeDataType.String, 6),
        new JdeField("ADPR11", "ADPR11", JdeDataType.String, 6),
        new JdeField("ADPR12", "ADPR12", JdeDataType.String, 6),
        new JdeField("ADPR13", "ADPR13", JdeDataType.String, 6),
        new JdeField("ADPR14", "ADPR14", JdeDataType.String, 6),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPR15", "ADPR15", JdeDataType.String, 6),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADPR16", "ADPR16", JdeDataType.String, 6),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADPR17", "ADPR17", JdeDataType.String, 6),
        new JdeField("ADPR18", "ADPR18", JdeDataType.String, 6),
        new JdeField("ADPR19", "ADPR19", JdeDataType.String, 6),
        new JdeField("ADPR20", "ADPR20", JdeDataType.String, 6),
        new JdeField("ADODBA", "ADODBA", JdeDataType.String, 2),
        new JdeField("ADSACC", "ADSACC", JdeDataType.String, 6),
        new JdeField("ADCALC", "ADCALC", JdeDataType.String, 2),
        new JdeField("ADPPRY", "ADPPRY", JdeDataType.String, 2),
        new JdeField("ADGVCH", "ADGVCH", JdeDataType.String, 2),
        new JdeField("ADPRTX", "ADPRTX", JdeDataType.String, 6),
        new JdeField("ADF415", "ADF415", JdeDataType.String, 6),
        new JdeField("ADCLCI", "ADCLCI", JdeDataType.String, 2),
        new JdeField("ADRYTP", "ADRYTP", JdeDataType.String, 2),
        new JdeField("ADAFDT", "ADAFDT", JdeDataType.String, 8),
        new JdeField("ADSHDL", "ADSHDL", JdeDataType.String, 8),
        new JdeField("ADCHCK", "ADCHCK", JdeDataType.String, 2),
        new JdeField("ADLVPT", "ADLVPT", JdeDataType.String, 2),
        new JdeField("ADPHISH", "ADPHISH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051375_0", "Primary Key on ADPAYBN, ADPDBA, ADEFTB, ADEFTE", new[] { "ADPAYBN", "ADPDBA", "ADEFTB", "ADEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F051375_2", "Index on SYS_NC00134$", new[] { "SYS_NC00134$" })
    };
}
