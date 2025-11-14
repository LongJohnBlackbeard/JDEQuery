using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051371 - .
/// </summary>
public class F051371 : JdeTable
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
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADEST.
        /// </summary>
        public const string ADEST = "ADEST";

        /// <summary>
        /// ADMCU3.
        /// </summary>
        public const string ADMCU3 = "ADMCU3";

        /// <summary>
        /// ADPFRQ.
        /// </summary>
        public const string ADPFRQ = "ADPFRQ";

        /// <summary>
        /// ADEXR.
        /// </summary>
        public const string ADEXR = "ADEXR";

        /// <summary>
        /// ADPDBA.
        /// </summary>
        public const string ADPDBA = "ADPDBA";

        /// <summary>
        /// ADDISO.
        /// </summary>
        public const string ADDISO = "ADDISO";

        /// <summary>
        /// ADPGRP.
        /// </summary>
        public const string ADPGRP = "ADPGRP";

        /// <summary>
        /// ADPSDT.
        /// </summary>
        public const string ADPSDT = "ADPSDT";

        /// <summary>
        /// ADPTDT.
        /// </summary>
        public const string ADPTDT = "ADPTDT";

        /// <summary>
        /// ADSFLG.
        /// </summary>
        public const string ADSFLG = "ADSFLG";

        /// <summary>
        /// ADDTAB.
        /// </summary>
        public const string ADDTAB = "ADDTAB";

        /// <summary>
        /// ADPB.
        /// </summary>
        public const string ADPB = "ADPB";

        /// <summary>
        /// ADDESQ.
        /// </summary>
        public const string ADDESQ = "ADDESQ";

        /// <summary>
        /// ADSHFT.
        /// </summary>
        public const string ADSHFT = "ADSHFT";

        /// <summary>
        /// ADAM.
        /// </summary>
        public const string ADAM = "ADAM";

        /// <summary>
        /// ADMCU.
        /// </summary>
        public const string ADMCU = "ADMCU";

        /// <summary>
        /// ADOBJ.
        /// </summary>
        public const string ADOBJ = "ADOBJ";

        /// <summary>
        /// ADSUB.
        /// </summary>
        public const string ADSUB = "ADSUB";

        /// <summary>
        /// ADSBL.
        /// </summary>
        public const string ADSBL = "ADSBL";

        /// <summary>
        /// ADTARA.
        /// </summary>
        public const string ADTARA = "ADTARA";

        /// <summary>
        /// ADWCMP.
        /// </summary>
        public const string ADWCMP = "ADWCMP";

        /// <summary>
        /// ADLMTH.
        /// </summary>
        public const string ADLMTH = "ADLMTH";

        /// <summary>
        /// ADLF.
        /// </summary>
        public const string ADLF = "ADLF";

        /// <summary>
        /// ADPHRW.
        /// </summary>
        public const string ADPHRW = "ADPHRW";

        /// <summary>
        /// ADPCUN.
        /// </summary>
        public const string ADPCUN = "ADPCUN";

        /// <summary>
        /// ADUM.
        /// </summary>
        public const string ADUM = "ADUM";

        /// <summary>
        /// ADPHRT.
        /// </summary>
        public const string ADPHRT = "ADPHRT";

        /// <summary>
        /// ADPPRT.
        /// </summary>
        public const string ADPPRT = "ADPPRT";

        /// <summary>
        /// ADBHRT.
        /// </summary>
        public const string ADBHRT = "ADBHRT";

        /// <summary>
        /// ADPBRT.
        /// </summary>
        public const string ADPBRT = "ADPBRT";

        /// <summary>
        /// ADBDRT.
        /// </summary>
        public const string ADBDRT = "ADBDRT";

        /// <summary>
        /// ADB2RT.
        /// </summary>
        public const string ADB2RT = "ADB2RT";

        /// <summary>
        /// ADRBOB.
        /// </summary>
        public const string ADRBOB = "ADRBOB";

        /// <summary>
        /// ADRBO2.
        /// </summary>
        public const string ADRBO2 = "ADRBO2";

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
        /// ADGPA.
        /// </summary>
        public const string ADGPA = "ADGPA";

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
        /// ADAI.
        /// </summary>
        public const string ADAI = "ADAI";

        /// <summary>
        /// ADLD.
        /// </summary>
        public const string ADLD = "ADLD";

        /// <summary>
        /// ADSEC$.
        /// </summary>
        public const string ADSEC_ = "ADSEC$";

        /// <summary>
        /// ADANN8.
        /// </summary>
        public const string ADANN8 = "ADANN8";

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
        /// ADP001.
        /// </summary>
        public const string ADP001 = "ADP001";

        /// <summary>
        /// ADP002.
        /// </summary>
        public const string ADP002 = "ADP002";

        /// <summary>
        /// ADP003.
        /// </summary>
        public const string ADP003 = "ADP003";

        /// <summary>
        /// ADP004.
        /// </summary>
        public const string ADP004 = "ADP004";

        /// <summary>
        /// ADJBCD.
        /// </summary>
        public const string ADJBCD = "ADJBCD";

        /// <summary>
        /// ADJBST.
        /// </summary>
        public const string ADJBST = "ADJBST";

        /// <summary>
        /// ADHMIN.
        /// </summary>
        public const string ADHMIN = "ADHMIN";

        /// <summary>
        /// ADHMAX.
        /// </summary>
        public const string ADHMAX = "ADHMAX";

        /// <summary>
        /// ADWET.
        /// </summary>
        public const string ADWET = "ADWET";

        /// <summary>
        /// ADEQCG.
        /// </summary>
        public const string ADEQCG = "ADEQCG";

        /// <summary>
        /// ADEQHR.
        /// </summary>
        public const string ADEQHR = "ADEQHR";

        /// <summary>
        /// ADERC.
        /// </summary>
        public const string ADERC = "ADERC";

        /// <summary>
        /// ADQOBJ.
        /// </summary>
        public const string ADQOBJ = "ADQOBJ";

        /// <summary>
        /// ADEQRT.
        /// </summary>
        public const string ADEQRT = "ADEQRT";

        /// <summary>
        /// ADPDED.
        /// </summary>
        public const string ADPDED = "ADPDED";

        /// <summary>
        /// ADDGRP.
        /// </summary>
        public const string ADDGRP = "ADDGRP";

        /// <summary>
        /// ADDPRI.
        /// </summary>
        public const string ADDPRI = "ADDPRI";

        /// <summary>
        /// ADARRR.
        /// </summary>
        public const string ADARRR = "ADARRR";

        /// <summary>
        /// ADQDL.
        /// </summary>
        public const string ADQDL = "ADQDL";

        /// <summary>
        /// ADDW.
        /// </summary>
        public const string ADDW = "ADDW";

        /// <summary>
        /// ADPRTR.
        /// </summary>
        public const string ADPRTR = "ADPRTR";

        /// <summary>
        /// ADSBLT.
        /// </summary>
        public const string ADSBLT = "ADSBLT";

        /// <summary>
        /// ADAAF.
        /// </summary>
        public const string ADAAF = "ADAAF";

        /// <summary>
        /// ADDAAF.
        /// </summary>
        public const string ADDAAF = "ADDAAF";

        /// <summary>
        /// ADUDBA.
        /// </summary>
        public const string ADUDBA = "ADUDBA";

        /// <summary>
        /// ADACEQ.
        /// </summary>
        public const string ADACEQ = "ADACEQ";

        /// <summary>
        /// ADALHR.
        /// </summary>
        public const string ADALHR = "ADALHR";

        /// <summary>
        /// ADUN.
        /// </summary>
        public const string ADUN = "ADUN";

        /// <summary>
        /// ADAMTS.
        /// </summary>
        public const string ADAMTS = "ADAMTS";

        /// <summary>
        /// ADSADL.
        /// </summary>
        public const string ADSADL = "ADSADL";

        /// <summary>
        /// ADWR01.
        /// </summary>
        public const string ADWR01 = "ADWR01";

        /// <summary>
        /// ADCOVA.
        /// </summary>
        public const string ADCOVA = "ADCOVA";

        /// <summary>
        /// ADZOVR.
        /// </summary>
        public const string ADZOVR = "ADZOVR";

        /// <summary>
        /// ADCMAX.
        /// </summary>
        public const string ADCMAX = "ADCMAX";

        /// <summary>
        /// ADUAMT.
        /// </summary>
        public const string ADUAMT = "ADUAMT";

        /// <summary>
        /// ADAR1Y.
        /// </summary>
        public const string ADAR1Y = "ADAR1Y";

        /// <summary>
        /// ADARSY.
        /// </summary>
        public const string ADARSY = "ADARSY";

        /// <summary>
        /// ADRTAB.
        /// </summary>
        public const string ADRTAB = "ADRTAB";

        /// <summary>
        /// ADCTAB.
        /// </summary>
        public const string ADCTAB = "ADCTAB";

        /// <summary>
        /// ADRCCD.
        /// </summary>
        public const string ADRCCD = "ADRCCD";

        /// <summary>
        /// ADPCNO.
        /// </summary>
        public const string ADPCNO = "ADPCNO";

        /// <summary>
        /// ADODBA.
        /// </summary>
        public const string ADODBA = "ADODBA";

        /// <summary>
        /// ADGVCH.
        /// </summary>
        public const string ADGVCH = "ADGVCH";

        /// <summary>
        /// ADPLAN.
        /// </summary>
        public const string ADPLAN = "ADPLAN";

        /// <summary>
        /// ADAOPT.
        /// </summary>
        public const string ADAOPT = "ADAOPT";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADPOS.
        /// </summary>
        public const string ADPOS = "ADPOS";

        /// <summary>
        /// ADHMCU.
        /// </summary>
        public const string ADHMCU = "ADHMCU";

        /// <summary>
        /// ADADP06.
        /// </summary>
        public const string ADADP06 = "ADADP06";

        /// <summary>
        /// ADADP07.
        /// </summary>
        public const string ADADP07 = "ADADP07";

        /// <summary>
        /// ADADP08.
        /// </summary>
        public const string ADADP08 = "ADADP08";

        /// <summary>
        /// ADADP09.
        /// </summary>
        public const string ADADP09 = "ADADP09";

        /// <summary>
        /// ADADP10.
        /// </summary>
        public const string ADADP10 = "ADADP10";

        /// <summary>
        /// ADADP16.
        /// </summary>
        public const string ADADP16 = "ADADP16";

        /// <summary>
        /// ADADP17.
        /// </summary>
        public const string ADADP17 = "ADADP17";

        /// <summary>
        /// ADADP18.
        /// </summary>
        public const string ADADP18 = "ADADP18";

        /// <summary>
        /// ADADP19.
        /// </summary>
        public const string ADADP19 = "ADADP19";

        /// <summary>
        /// ADADP20.
        /// </summary>
        public const string ADADP20 = "ADADP20";

        /// <summary>
        /// ADADP26.
        /// </summary>
        public const string ADADP26 = "ADADP26";

        /// <summary>
        /// ADADP27.
        /// </summary>
        public const string ADADP27 = "ADADP27";

        /// <summary>
        /// ADADP28.
        /// </summary>
        public const string ADADP28 = "ADADP28";

        /// <summary>
        /// ADADP29.
        /// </summary>
        public const string ADADP29 = "ADADP29";

        /// <summary>
        /// ADADP30.
        /// </summary>
        public const string ADADP30 = "ADADP30";

        /// <summary>
        /// ADADP36.
        /// </summary>
        public const string ADADP36 = "ADADP36";

        /// <summary>
        /// ADADP37.
        /// </summary>
        public const string ADADP37 = "ADADP37";

        /// <summary>
        /// ADADP38.
        /// </summary>
        public const string ADADP38 = "ADADP38";

        /// <summary>
        /// ADADP39.
        /// </summary>
        public const string ADADP39 = "ADADP39";

        /// <summary>
        /// ADADP40.
        /// </summary>
        public const string ADADP40 = "ADADP40";
    }

    /// <inheritdoc />
    public override string TableName => "F051371";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADCHGF", "ADCHGF", JdeDataType.String, 2),
        new JdeField("ADPAYBN", "ADPAYBN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADEST", "ADEST", JdeDataType.String, 2),
        new JdeField("ADMCU3", "ADMCU3", JdeDataType.String, 24),
        new JdeField("ADPFRQ", "ADPFRQ", JdeDataType.String, 2),
        new JdeField("ADEXR", "ADEXR", JdeDataType.String, 60),
        new JdeField("ADPDBA", "ADPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("ADDISO", "ADDISO", JdeDataType.String, 2),
        new JdeField("ADPGRP", "ADPGRP", JdeDataType.String, 4),
        new JdeField("ADPSDT", "ADPSDT", JdeDataType.Numeric, null, true, true),
        new JdeField("ADPTDT", "ADPTDT", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSFLG", "ADSFLG", JdeDataType.String, 2),
        new JdeField("ADDTAB", "ADDTAB", JdeDataType.String, 10),
        new JdeField("ADPB", "ADPB", JdeDataType.String, 2),
        new JdeField("ADDESQ", "ADDESQ", JdeDataType.String, 2),
        new JdeField("ADSHFT", "ADSHFT", JdeDataType.String, 2),
        new JdeField("ADAM", "ADAM", JdeDataType.String, 2),
        new JdeField("ADMCU", "ADMCU", JdeDataType.String, 24),
        new JdeField("ADOBJ", "ADOBJ", JdeDataType.String, 12),
        new JdeField("ADSUB", "ADSUB", JdeDataType.String, 16),
        new JdeField("ADSBL", "ADSBL", JdeDataType.String, 16),
        new JdeField("ADTARA", "ADTARA", JdeDataType.String, 20),
        new JdeField("ADWCMP", "ADWCMP", JdeDataType.String, 8),
        new JdeField("ADLMTH", "ADLMTH", JdeDataType.String, 2),
        new JdeField("ADLF", "ADLF", JdeDataType.Numeric),
        new JdeField("ADPHRW", "ADPHRW", JdeDataType.Numeric),
        new JdeField("ADPCUN", "ADPCUN", JdeDataType.Numeric),
        new JdeField("ADUM", "ADUM", JdeDataType.String, 4),
        new JdeField("ADPHRT", "ADPHRT", JdeDataType.Numeric),
        new JdeField("ADPPRT", "ADPPRT", JdeDataType.Numeric),
        new JdeField("ADBHRT", "ADBHRT", JdeDataType.Numeric),
        new JdeField("ADPBRT", "ADPBRT", JdeDataType.Numeric),
        new JdeField("ADBDRT", "ADBDRT", JdeDataType.Numeric),
        new JdeField("ADB2RT", "ADB2RT", JdeDataType.Numeric),
        new JdeField("ADRBOB", "ADRBOB", JdeDataType.String, 12),
        new JdeField("ADRBO2", "ADRBO2", JdeDataType.String, 12),
        new JdeField("ADRTAM", "ADRTAM", JdeDataType.Numeric),
        new JdeField("ADPAYM", "ADPAYM", JdeDataType.Numeric),
        new JdeField("ADSHD", "ADSHD", JdeDataType.Numeric),
        new JdeField("ADCMTH", "ADCMTH", JdeDataType.String, 2),
        new JdeField("ADGPA", "ADGPA", JdeDataType.Numeric),
        new JdeField("ADPPDL", "ADPPDL", JdeDataType.Numeric),
        new JdeField("ADMDL", "ADMDL", JdeDataType.Numeric),
        new JdeField("ADADL", "ADADL", JdeDataType.Numeric),
        new JdeField("ADPPPL", "ADPPPL", JdeDataType.Numeric),
        new JdeField("ADNP", "ADNP", JdeDataType.Numeric),
        new JdeField("ADAD", "ADAD", JdeDataType.Numeric),
        new JdeField("ADAI", "ADAI", JdeDataType.String, 2),
        new JdeField("ADLD", "ADLD", JdeDataType.String, 2),
        new JdeField("ADSEC$", "ADSEC$", JdeDataType.String, 2),
        new JdeField("ADANN8", "ADANN8", JdeDataType.Numeric),
        new JdeField("ADDEP1", "ADDEP1", JdeDataType.String, 2),
        new JdeField("ADDEP2", "ADDEP2", JdeDataType.String, 2),
        new JdeField("ADDEP3", "ADDEP3", JdeDataType.String, 2),
        new JdeField("ADDEP4", "ADDEP4", JdeDataType.String, 2),
        new JdeField("ADDEP5", "ADDEP5", JdeDataType.String, 2),
        new JdeField("ADDEP6", "ADDEP6", JdeDataType.String, 2),
        new JdeField("ADP001", "ADP001", JdeDataType.String, 6),
        new JdeField("ADP002", "ADP002", JdeDataType.String, 6),
        new JdeField("ADP003", "ADP003", JdeDataType.String, 6),
        new JdeField("ADP004", "ADP004", JdeDataType.String, 6),
        new JdeField("ADJBCD", "ADJBCD", JdeDataType.String, 12),
        new JdeField("ADJBST", "ADJBST", JdeDataType.String, 8),
        new JdeField("ADHMIN", "ADHMIN", JdeDataType.Numeric),
        new JdeField("ADHMAX", "ADHMAX", JdeDataType.Numeric),
        new JdeField("ADWET", "ADWET", JdeDataType.String, 2),
        new JdeField("ADEQCG", "ADEQCG", JdeDataType.String, 18),
        new JdeField("ADEQHR", "ADEQHR", JdeDataType.Numeric),
        new JdeField("ADERC", "ADERC", JdeDataType.String, 4),
        new JdeField("ADQOBJ", "ADQOBJ", JdeDataType.String, 12),
        new JdeField("ADEQRT", "ADEQRT", JdeDataType.Numeric),
        new JdeField("ADPDED", "ADPDED", JdeDataType.Numeric),
        new JdeField("ADDGRP", "ADDGRP", JdeDataType.String, 4),
        new JdeField("ADDPRI", "ADDPRI", JdeDataType.Numeric),
        new JdeField("ADARRR", "ADARRR", JdeDataType.String, 2),
        new JdeField("ADQDL", "ADQDL", JdeDataType.Numeric),
        new JdeField("ADDW", "ADDW", JdeDataType.String, 2),
        new JdeField("ADPRTR", "ADPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSBLT", "ADSBLT", JdeDataType.String, 2),
        new JdeField("ADAAF", "ADAAF", JdeDataType.String, 2),
        new JdeField("ADDAAF", "ADDAAF", JdeDataType.String, 2),
        new JdeField("ADUDBA", "ADUDBA", JdeDataType.String, 2),
        new JdeField("ADACEQ", "ADACEQ", JdeDataType.Numeric),
        new JdeField("ADALHR", "ADALHR", JdeDataType.Numeric),
        new JdeField("ADUN", "ADUN", JdeDataType.String, 12),
        new JdeField("ADAMTS", "ADAMTS", JdeDataType.Numeric),
        new JdeField("ADSADL", "ADSADL", JdeDataType.Numeric),
        new JdeField("ADWR01", "ADWR01", JdeDataType.String, 8),
        new JdeField("ADCOVA", "ADCOVA", JdeDataType.Numeric),
        new JdeField("ADZOVR", "ADZOVR", JdeDataType.String, 2),
        new JdeField("ADCMAX", "ADCMAX", JdeDataType.Numeric),
        new JdeField("ADUAMT", "ADUAMT", JdeDataType.Numeric),
        new JdeField("ADAR1Y", "ADAR1Y", JdeDataType.String, 2),
        new JdeField("ADARSY", "ADARSY", JdeDataType.String, 2),
        new JdeField("ADRTAB", "ADRTAB", JdeDataType.String, 10),
        new JdeField("ADCTAB", "ADCTAB", JdeDataType.String, 10),
        new JdeField("ADRCCD", "ADRCCD", JdeDataType.String, 2),
        new JdeField("ADPCNO", "ADPCNO", JdeDataType.Numeric),
        new JdeField("ADODBA", "ADODBA", JdeDataType.String, 2),
        new JdeField("ADGVCH", "ADGVCH", JdeDataType.String, 2),
        new JdeField("ADPLAN", "ADPLAN", JdeDataType.String, 16),
        new JdeField("ADAOPT", "ADAOPT", JdeDataType.String, 6),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADPOS", "ADPOS", JdeDataType.String, 16),
        new JdeField("ADHMCU", "ADHMCU", JdeDataType.String, 24),
        new JdeField("ADADP06", "ADADP06", JdeDataType.String, 2),
        new JdeField("ADADP07", "ADADP07", JdeDataType.String, 2),
        new JdeField("ADADP08", "ADADP08", JdeDataType.String, 2),
        new JdeField("ADADP09", "ADADP09", JdeDataType.String, 2),
        new JdeField("ADADP10", "ADADP10", JdeDataType.String, 2),
        new JdeField("ADADP16", "ADADP16", JdeDataType.Numeric),
        new JdeField("ADADP17", "ADADP17", JdeDataType.Numeric),
        new JdeField("ADADP18", "ADADP18", JdeDataType.Numeric),
        new JdeField("ADADP19", "ADADP19", JdeDataType.Numeric),
        new JdeField("ADADP20", "ADADP20", JdeDataType.Numeric),
        new JdeField("ADADP26", "ADADP26", JdeDataType.String, 40),
        new JdeField("ADADP27", "ADADP27", JdeDataType.String, 40),
        new JdeField("ADADP28", "ADADP28", JdeDataType.String, 40),
        new JdeField("ADADP29", "ADADP29", JdeDataType.String, 40),
        new JdeField("ADADP30", "ADADP30", JdeDataType.String, 40),
        new JdeField("ADADP36", "ADADP36", JdeDataType.Numeric),
        new JdeField("ADADP37", "ADADP37", JdeDataType.Numeric),
        new JdeField("ADADP38", "ADADP38", JdeDataType.Numeric),
        new JdeField("ADADP39", "ADADP39", JdeDataType.Numeric),
        new JdeField("ADADP40", "ADADP40", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051371_0", "Primary Key on ADPAYBN, ADAN8, ADPDBA, ADPSDT, ADPTDT, ADPRTR", new[] { "ADPAYBN", "ADAN8", "ADPDBA", "ADPSDT", "ADPTDT", "ADPRTR" }, isUnique: true, isPrimaryKey: true)
    };
}
