using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4600PU - .
/// </summary>
public class F4600PU : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R1TYFL.
        /// </summary>
        public const string R1TYFL = "R1TYFL";

        /// <summary>
        /// R1OCDE.
        /// </summary>
        public const string R1OCDE = "R1OCDE";

        /// <summary>
        /// R1RQBT.
        /// </summary>
        public const string R1RQBT = "R1RQBT";

        /// <summary>
        /// R1RQSQ.
        /// </summary>
        public const string R1RQSQ = "R1RQSQ";

        /// <summary>
        /// R1KCOO.
        /// </summary>
        public const string R1KCOO = "R1KCOO";

        /// <summary>
        /// R1DOCO.
        /// </summary>
        public const string R1DOCO = "R1DOCO";

        /// <summary>
        /// R1DCTO.
        /// </summary>
        public const string R1DCTO = "R1DCTO";

        /// <summary>
        /// R1LNID.
        /// </summary>
        public const string R1LNID = "R1LNID";

        /// <summary>
        /// R1NLIN.
        /// </summary>
        public const string R1NLIN = "R1NLIN";

        /// <summary>
        /// R1SFXO.
        /// </summary>
        public const string R1SFXO = "R1SFXO";

        /// <summary>
        /// R1AN8.
        /// </summary>
        public const string R1AN8 = "R1AN8";

        /// <summary>
        /// R1SHAN.
        /// </summary>
        public const string R1SHAN = "R1SHAN";

        /// <summary>
        /// R1MCU.
        /// </summary>
        public const string R1MCU = "R1MCU";

        /// <summary>
        /// R1ITM.
        /// </summary>
        public const string R1ITM = "R1ITM";

        /// <summary>
        /// R1LITM.
        /// </summary>
        public const string R1LITM = "R1LITM";

        /// <summary>
        /// R1AITM.
        /// </summary>
        public const string R1AITM = "R1AITM";

        /// <summary>
        /// R1OGRP.
        /// </summary>
        public const string R1OGRP = "R1OGRP";

        /// <summary>
        /// R1OVRQ.
        /// </summary>
        public const string R1OVRQ = "R1OVRQ";

        /// <summary>
        /// R1MERG.
        /// </summary>
        public const string R1MERG = "R1MERG";

        /// <summary>
        /// R1RLIT.
        /// </summary>
        public const string R1RLIT = "R1RLIT";

        /// <summary>
        /// R1KTLN.
        /// </summary>
        public const string R1KTLN = "R1KTLN";

        /// <summary>
        /// R1CPNT.
        /// </summary>
        public const string R1CPNT = "R1CPNT";

        /// <summary>
        /// R1RKIT.
        /// </summary>
        public const string R1RKIT = "R1RKIT";

        /// <summary>
        /// R1KTP.
        /// </summary>
        public const string R1KTP = "R1KTP";

        /// <summary>
        /// R1QTRQ.
        /// </summary>
        public const string R1QTRQ = "R1QTRQ";

        /// <summary>
        /// R1UOM.
        /// </summary>
        public const string R1UOM = "R1UOM";

        /// <summary>
        /// R1LDFS.
        /// </summary>
        public const string R1LDFS = "R1LDFS";

        /// <summary>
        /// R1FLOC.
        /// </summary>
        public const string R1FLOC = "R1FLOC";

        /// <summary>
        /// R1FLOT.
        /// </summary>
        public const string R1FLOT = "R1FLOT";

        /// <summary>
        /// R1STNF.
        /// </summary>
        public const string R1STNF = "R1STNF";

        /// <summary>
        /// R1LDTS.
        /// </summary>
        public const string R1LDTS = "R1LDTS";

        /// <summary>
        /// R1TLOC.
        /// </summary>
        public const string R1TLOC = "R1TLOC";

        /// <summary>
        /// R1TLOT.
        /// </summary>
        public const string R1TLOT = "R1TLOT";

        /// <summary>
        /// R1STNT.
        /// </summary>
        public const string R1STNT = "R1STNT";

        /// <summary>
        /// R1FRMP.
        /// </summary>
        public const string R1FRMP = "R1FRMP";

        /// <summary>
        /// R1THRP.
        /// </summary>
        public const string R1THRP = "R1THRP";

        /// <summary>
        /// R1FRGD.
        /// </summary>
        public const string R1FRGD = "R1FRGD";

        /// <summary>
        /// R1THGD.
        /// </summary>
        public const string R1THGD = "R1THGD";

        /// <summary>
        /// R1EXDP.
        /// </summary>
        public const string R1EXDP = "R1EXDP";

        /// <summary>
        /// R1LNTY.
        /// </summary>
        public const string R1LNTY = "R1LNTY";

        /// <summary>
        /// R1SRP1.
        /// </summary>
        public const string R1SRP1 = "R1SRP1";

        /// <summary>
        /// R1SRP2.
        /// </summary>
        public const string R1SRP2 = "R1SRP2";

        /// <summary>
        /// R1SRP3.
        /// </summary>
        public const string R1SRP3 = "R1SRP3";

        /// <summary>
        /// R1SRP4.
        /// </summary>
        public const string R1SRP4 = "R1SRP4";

        /// <summary>
        /// R1SRP5.
        /// </summary>
        public const string R1SRP5 = "R1SRP5";

        /// <summary>
        /// R1PRIO.
        /// </summary>
        public const string R1PRIO = "R1PRIO";

        /// <summary>
        /// R1ROUT.
        /// </summary>
        public const string R1ROUT = "R1ROUT";

        /// <summary>
        /// R1STOP.
        /// </summary>
        public const string R1STOP = "R1STOP";

        /// <summary>
        /// R1ZON.
        /// </summary>
        public const string R1ZON = "R1ZON";

        /// <summary>
        /// R1CARS.
        /// </summary>
        public const string R1CARS = "R1CARS";

        /// <summary>
        /// R1BACK.
        /// </summary>
        public const string R1BACK = "R1BACK";

        /// <summary>
        /// R1APTS.
        /// </summary>
        public const string R1APTS = "R1APTS";

        /// <summary>
        /// R1COMM.
        /// </summary>
        public const string R1COMM = "R1COMM";

        /// <summary>
        /// R1DSC1.
        /// </summary>
        public const string R1DSC1 = "R1DSC1";

        /// <summary>
        /// R1DSC2.
        /// </summary>
        public const string R1DSC2 = "R1DSC2";

        /// <summary>
        /// R1INMG.
        /// </summary>
        public const string R1INMG = "R1INMG";

        /// <summary>
        /// R1VR01.
        /// </summary>
        public const string R1VR01 = "R1VR01";

        /// <summary>
        /// R1PALC.
        /// </summary>
        public const string R1PALC = "R1PALC";

        /// <summary>
        /// R1MORD.
        /// </summary>
        public const string R1MORD = "R1MORD";

        /// <summary>
        /// R1LCOD.
        /// </summary>
        public const string R1LCOD = "R1LCOD";

        /// <summary>
        /// R1PACK.
        /// </summary>
        public const string R1PACK = "R1PACK";

        /// <summary>
        /// R1RPCK.
        /// </summary>
        public const string R1RPCK = "R1RPCK";

        /// <summary>
        /// R1PSTB.
        /// </summary>
        public const string R1PSTB = "R1PSTB";

        /// <summary>
        /// R1RCDJ.
        /// </summary>
        public const string R1RCDJ = "R1RCDJ";

        /// <summary>
        /// R1TRDJ.
        /// </summary>
        public const string R1TRDJ = "R1TRDJ";

        /// <summary>
        /// R1PDDJ.
        /// </summary>
        public const string R1PDDJ = "R1PDDJ";

        /// <summary>
        /// R1DRQJ.
        /// </summary>
        public const string R1DRQJ = "R1DRQJ";

        /// <summary>
        /// R1ZIP.
        /// </summary>
        public const string R1ZIP = "R1ZIP";

        /// <summary>
        /// R1CNFR.
        /// </summary>
        public const string R1CNFR = "R1CNFR";

        /// <summary>
        /// R1RESX.
        /// </summary>
        public const string R1RESX = "R1RESX";

        /// <summary>
        /// R1PTYN.
        /// </summary>
        public const string R1PTYN = "R1PTYN";

        /// <summary>
        /// R1TREX.
        /// </summary>
        public const string R1TREX = "R1TREX";

        /// <summary>
        /// R1DTCR.
        /// </summary>
        public const string R1DTCR = "R1DTCR";

        /// <summary>
        /// R1TMCR.
        /// </summary>
        public const string R1TMCR = "R1TMCR";

        /// <summary>
        /// R1URCD.
        /// </summary>
        public const string R1URCD = "R1URCD";

        /// <summary>
        /// R1URDT.
        /// </summary>
        public const string R1URDT = "R1URDT";

        /// <summary>
        /// R1URAT.
        /// </summary>
        public const string R1URAT = "R1URAT";

        /// <summary>
        /// R1URAB.
        /// </summary>
        public const string R1URAB = "R1URAB";

        /// <summary>
        /// R1URRF.
        /// </summary>
        public const string R1URRF = "R1URRF";

        /// <summary>
        /// R1USER.
        /// </summary>
        public const string R1USER = "R1USER";

        /// <summary>
        /// R1PID.
        /// </summary>
        public const string R1PID = "R1PID";

        /// <summary>
        /// R1JOBN.
        /// </summary>
        public const string R1JOBN = "R1JOBN";

        /// <summary>
        /// R1UPMJ.
        /// </summary>
        public const string R1UPMJ = "R1UPMJ";

        /// <summary>
        /// R1TDAY.
        /// </summary>
        public const string R1TDAY = "R1TDAY";

        /// <summary>
        /// R1UKID.
        /// </summary>
        public const string R1UKID = "R1UKID";

        /// <summary>
        /// R1DTE.
        /// </summary>
        public const string R1DTE = "R1DTE";

        /// <summary>
        /// R1TICU.
        /// </summary>
        public const string R1TICU = "R1TICU";

        /// <summary>
        /// R1SCHUSER.
        /// </summary>
        public const string R1SCHUSER = "R1SCHUSER";

        /// <summary>
        /// R1SHPN.
        /// </summary>
        public const string R1SHPN = "R1SHPN";

        /// <summary>
        /// R1LDNM.
        /// </summary>
        public const string R1LDNM = "R1LDNM";

        /// <summary>
        /// R1CPNB.
        /// </summary>
        public const string R1CPNB = "R1CPNB";

        /// <summary>
        /// R1VMCU.
        /// </summary>
        public const string R1VMCU = "R1VMCU";

        /// <summary>
        /// R1PSJOBNO.
        /// </summary>
        public const string R1PSJOBNO = "R1PSJOBNO";

        /// <summary>
        /// R1JOBSQ.
        /// </summary>
        public const string R1JOBSQ = "R1JOBSQ";

        /// <summary>
        /// R1DELBATCH.
        /// </summary>
        public const string R1DELBATCH = "R1DELBATCH";
    }

    /// <inheritdoc />
    public override string TableName => "F4600PU";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R1TYFL", "R1TYFL", JdeDataType.String, 2),
        new JdeField("R1OCDE", "R1OCDE", JdeDataType.String, 4),
        new JdeField("R1RQBT", "R1RQBT", JdeDataType.Numeric, null, true, true),
        new JdeField("R1RQSQ", "R1RQSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("R1KCOO", "R1KCOO", JdeDataType.String, 10),
        new JdeField("R1DOCO", "R1DOCO", JdeDataType.Numeric),
        new JdeField("R1DCTO", "R1DCTO", JdeDataType.String, 4),
        new JdeField("R1LNID", "R1LNID", JdeDataType.Numeric),
        new JdeField("R1NLIN", "R1NLIN", JdeDataType.Numeric),
        new JdeField("R1SFXO", "R1SFXO", JdeDataType.String, 6),
        new JdeField("R1AN8", "R1AN8", JdeDataType.Numeric),
        new JdeField("R1SHAN", "R1SHAN", JdeDataType.Numeric),
        new JdeField("R1MCU", "R1MCU", JdeDataType.String, 24),
        new JdeField("R1ITM", "R1ITM", JdeDataType.Numeric),
        new JdeField("R1LITM", "R1LITM", JdeDataType.String, 50),
        new JdeField("R1AITM", "R1AITM", JdeDataType.String, 50),
        new JdeField("R1OGRP", "R1OGRP", JdeDataType.String, 8),
        new JdeField("R1OVRQ", "R1OVRQ", JdeDataType.String, 2),
        new JdeField("R1MERG", "R1MERG", JdeDataType.String, 2),
        new JdeField("R1RLIT", "R1RLIT", JdeDataType.String, 16),
        new JdeField("R1KTLN", "R1KTLN", JdeDataType.Numeric),
        new JdeField("R1CPNT", "R1CPNT", JdeDataType.Numeric),
        new JdeField("R1RKIT", "R1RKIT", JdeDataType.Numeric),
        new JdeField("R1KTP", "R1KTP", JdeDataType.Numeric),
        new JdeField("R1QTRQ", "R1QTRQ", JdeDataType.Numeric),
        new JdeField("R1UOM", "R1UOM", JdeDataType.String, 4),
        new JdeField("R1LDFS", "R1LDFS", JdeDataType.Numeric),
        new JdeField("R1FLOC", "R1FLOC", JdeDataType.String, 40),
        new JdeField("R1FLOT", "R1FLOT", JdeDataType.String, 60),
        new JdeField("R1STNF", "R1STNF", JdeDataType.Numeric),
        new JdeField("R1LDTS", "R1LDTS", JdeDataType.Numeric),
        new JdeField("R1TLOC", "R1TLOC", JdeDataType.String, 40),
        new JdeField("R1TLOT", "R1TLOT", JdeDataType.String, 60),
        new JdeField("R1STNT", "R1STNT", JdeDataType.Numeric),
        new JdeField("R1FRMP", "R1FRMP", JdeDataType.Numeric),
        new JdeField("R1THRP", "R1THRP", JdeDataType.Numeric),
        new JdeField("R1FRGD", "R1FRGD", JdeDataType.String, 6),
        new JdeField("R1THGD", "R1THGD", JdeDataType.String, 6),
        new JdeField("R1EXDP", "R1EXDP", JdeDataType.Numeric),
        new JdeField("R1LNTY", "R1LNTY", JdeDataType.String, 4),
        new JdeField("R1SRP1", "R1SRP1", JdeDataType.String, 6),
        new JdeField("R1SRP2", "R1SRP2", JdeDataType.String, 6),
        new JdeField("R1SRP3", "R1SRP3", JdeDataType.String, 6),
        new JdeField("R1SRP4", "R1SRP4", JdeDataType.String, 6),
        new JdeField("R1SRP5", "R1SRP5", JdeDataType.String, 6),
        new JdeField("R1PRIO", "R1PRIO", JdeDataType.String, 2),
        new JdeField("R1ROUT", "R1ROUT", JdeDataType.String, 6),
        new JdeField("R1STOP", "R1STOP", JdeDataType.String, 6),
        new JdeField("R1ZON", "R1ZON", JdeDataType.String, 6),
        new JdeField("R1CARS", "R1CARS", JdeDataType.Numeric),
        new JdeField("R1BACK", "R1BACK", JdeDataType.String, 2),
        new JdeField("R1APTS", "R1APTS", JdeDataType.String, 2),
        new JdeField("R1COMM", "R1COMM", JdeDataType.String, 2),
        new JdeField("R1DSC1", "R1DSC1", JdeDataType.String, 60),
        new JdeField("R1DSC2", "R1DSC2", JdeDataType.String, 60),
        new JdeField("R1INMG", "R1INMG", JdeDataType.String, 20),
        new JdeField("R1VR01", "R1VR01", JdeDataType.String, 50),
        new JdeField("R1PALC", "R1PALC", JdeDataType.String, 2),
        new JdeField("R1MORD", "R1MORD", JdeDataType.String, 2),
        new JdeField("R1LCOD", "R1LCOD", JdeDataType.String, 4),
        new JdeField("R1PACK", "R1PACK", JdeDataType.String, 8),
        new JdeField("R1RPCK", "R1RPCK", JdeDataType.String, 2),
        new JdeField("R1PSTB", "R1PSTB", JdeDataType.String, 6),
        new JdeField("R1RCDJ", "R1RCDJ", JdeDataType.Numeric),
        new JdeField("R1TRDJ", "R1TRDJ", JdeDataType.Numeric),
        new JdeField("R1PDDJ", "R1PDDJ", JdeDataType.Numeric),
        new JdeField("R1DRQJ", "R1DRQJ", JdeDataType.Numeric),
        new JdeField("R1ZIP", "R1ZIP", JdeDataType.String, 24),
        new JdeField("R1CNFR", "R1CNFR", JdeDataType.String, 2),
        new JdeField("R1RESX", "R1RESX", JdeDataType.String, 2),
        new JdeField("R1PTYN", "R1PTYN", JdeDataType.String, 2),
        new JdeField("R1TREX", "R1TREX", JdeDataType.String, 60),
        new JdeField("R1DTCR", "R1DTCR", JdeDataType.Numeric),
        new JdeField("R1TMCR", "R1TMCR", JdeDataType.Numeric),
        new JdeField("R1URCD", "R1URCD", JdeDataType.String, 4),
        new JdeField("R1URDT", "R1URDT", JdeDataType.Numeric),
        new JdeField("R1URAT", "R1URAT", JdeDataType.Numeric),
        new JdeField("R1URAB", "R1URAB", JdeDataType.Numeric),
        new JdeField("R1URRF", "R1URRF", JdeDataType.String, 30),
        new JdeField("R1USER", "R1USER", JdeDataType.String, 20),
        new JdeField("R1PID", "R1PID", JdeDataType.String, 20),
        new JdeField("R1JOBN", "R1JOBN", JdeDataType.String, 20),
        new JdeField("R1UPMJ", "R1UPMJ", JdeDataType.Numeric),
        new JdeField("R1TDAY", "R1TDAY", JdeDataType.Numeric),
        new JdeField("R1UKID", "R1UKID", JdeDataType.Numeric),
        new JdeField("R1DTE", "R1DTE", JdeDataType.Numeric),
        new JdeField("R1TICU", "R1TICU", JdeDataType.Numeric),
        new JdeField("R1SCHUSER", "R1SCHUSER", JdeDataType.String, 20),
        new JdeField("R1SHPN", "R1SHPN", JdeDataType.Numeric),
        new JdeField("R1LDNM", "R1LDNM", JdeDataType.Numeric),
        new JdeField("R1CPNB", "R1CPNB", JdeDataType.Numeric),
        new JdeField("R1VMCU", "R1VMCU", JdeDataType.String, 24),
        new JdeField("R1PSJOBNO", "R1PSJOBNO", JdeDataType.String, 30),
        new JdeField("R1JOBSQ", "R1JOBSQ", JdeDataType.String, 30),
        new JdeField("R1DELBATCH", "R1DELBATCH", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4600PU_0", "Primary Key on R1RQBT, R1RQSQ", new[] { "R1RQBT", "R1RQSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
