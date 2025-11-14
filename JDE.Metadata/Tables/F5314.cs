using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5314 - .
/// </summary>
public class F5314 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D2MCU.
        /// </summary>
        public const string D2MCU = "D2MCU";

        /// <summary>
        /// D2PPCO.
        /// </summary>
        public const string D2PPCO = "D2PPCO";

        /// <summary>
        /// D2CO.
        /// </summary>
        public const string D2CO = "D2CO";

        /// <summary>
        /// D2DL01.
        /// </summary>
        public const string D2DL01 = "D2DL01";

        /// <summary>
        /// D2PST1.
        /// </summary>
        public const string D2PST1 = "D2PST1";

        /// <summary>
        /// D2DRQJ.
        /// </summary>
        public const string D2DRQJ = "D2DRQJ";

        /// <summary>
        /// D2APRD.
        /// </summary>
        public const string D2APRD = "D2APRD";

        /// <summary>
        /// D2AREQ.
        /// </summary>
        public const string D2AREQ = "D2AREQ";

        /// <summary>
        /// D2APRV.
        /// </summary>
        public const string D2APRV = "D2APRV";

        /// <summary>
        /// D2EXTD.
        /// </summary>
        public const string D2EXTD = "D2EXTD";

        /// <summary>
        /// D2RQDD.
        /// </summary>
        public const string D2RQDD = "D2RQDD";

        /// <summary>
        /// D2AAMR.
        /// </summary>
        public const string D2AAMR = "D2AAMR";

        /// <summary>
        /// D2AAFR.
        /// </summary>
        public const string D2AAFR = "D2AAFR";

        /// <summary>
        /// D2AAMS.
        /// </summary>
        public const string D2AAMS = "D2AAMS";

        /// <summary>
        /// D2AAFS.
        /// </summary>
        public const string D2AAFS = "D2AAFS";

        /// <summary>
        /// D2AAMC.
        /// </summary>
        public const string D2AAMC = "D2AAMC";

        /// <summary>
        /// D2AAFC.
        /// </summary>
        public const string D2AAFC = "D2AAFC";

        /// <summary>
        /// D2AMQR.
        /// </summary>
        public const string D2AMQR = "D2AMQR";

        /// <summary>
        /// D2AFQR.
        /// </summary>
        public const string D2AFQR = "D2AFQR";

        /// <summary>
        /// D2AMQS.
        /// </summary>
        public const string D2AMQS = "D2AMQS";

        /// <summary>
        /// D2AFQS.
        /// </summary>
        public const string D2AFQS = "D2AFQS";

        /// <summary>
        /// D2AMQC.
        /// </summary>
        public const string D2AMQC = "D2AMQC";

        /// <summary>
        /// D2AFQC.
        /// </summary>
        public const string D2AFQC = "D2AFQC";

        /// <summary>
        /// D2PCHG.
        /// </summary>
        public const string D2PCHG = "D2PCHG";

        /// <summary>
        /// D2AID.
        /// </summary>
        public const string D2AID = "D2AID";

        /// <summary>
        /// D2ANI.
        /// </summary>
        public const string D2ANI = "D2ANI";

        /// <summary>
        /// D2OBJ.
        /// </summary>
        public const string D2OBJ = "D2OBJ";

        /// <summary>
        /// D2SUB.
        /// </summary>
        public const string D2SUB = "D2SUB";

        /// <summary>
        /// D2DOCO.
        /// </summary>
        public const string D2DOCO = "D2DOCO";

        /// <summary>
        /// D2DCTO.
        /// </summary>
        public const string D2DCTO = "D2DCTO";

        /// <summary>
        /// D2COCH.
        /// </summary>
        public const string D2COCH = "D2COCH";

        /// <summary>
        /// D2LNCT.
        /// </summary>
        public const string D2LNCT = "D2LNCT";

        /// <summary>
        /// D2KCO.
        /// </summary>
        public const string D2KCO = "D2KCO";

        /// <summary>
        /// D2AN8O.
        /// </summary>
        public const string D2AN8O = "D2AN8O";

        /// <summary>
        /// D2OPIM.
        /// </summary>
        public const string D2OPIM = "D2OPIM";

        /// <summary>
        /// D2PCOF.
        /// </summary>
        public const string D2PCOF = "D2PCOF";

        /// <summary>
        /// D2DRVP.
        /// </summary>
        public const string D2DRVP = "D2DRVP";

        /// <summary>
        /// D2CRCL.
        /// </summary>
        public const string D2CRCL = "D2CRCL";

        /// <summary>
        /// D2CRRM.
        /// </summary>
        public const string D2CRRM = "D2CRRM";

        /// <summary>
        /// D2CRCD.
        /// </summary>
        public const string D2CRCD = "D2CRCD";

        /// <summary>
        /// D2CRR.
        /// </summary>
        public const string D2CRR = "D2CRR";

        /// <summary>
        /// D2CRCF.
        /// </summary>
        public const string D2CRCF = "D2CRCF";

        /// <summary>
        /// D2CRRD.
        /// </summary>
        public const string D2CRRD = "D2CRRD";

        /// <summary>
        /// D2USER.
        /// </summary>
        public const string D2USER = "D2USER";

        /// <summary>
        /// D2PID.
        /// </summary>
        public const string D2PID = "D2PID";

        /// <summary>
        /// D2JOBN.
        /// </summary>
        public const string D2JOBN = "D2JOBN";

        /// <summary>
        /// D2UPMJ.
        /// </summary>
        public const string D2UPMJ = "D2UPMJ";

        /// <summary>
        /// D2UPMT.
        /// </summary>
        public const string D2UPMT = "D2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5314";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D2MCU", "D2MCU", JdeDataType.String, 24, true, true),
        new JdeField("D2PPCO", "D2PPCO", JdeDataType.Numeric, null, true, true),
        new JdeField("D2CO", "D2CO", JdeDataType.String, 10),
        new JdeField("D2DL01", "D2DL01", JdeDataType.String, 60),
        new JdeField("D2PST1", "D2PST1", JdeDataType.String, 2),
        new JdeField("D2DRQJ", "D2DRQJ", JdeDataType.Numeric),
        new JdeField("D2APRD", "D2APRD", JdeDataType.Numeric),
        new JdeField("D2AREQ", "D2AREQ", JdeDataType.Numeric),
        new JdeField("D2APRV", "D2APRV", JdeDataType.Numeric),
        new JdeField("D2EXTD", "D2EXTD", JdeDataType.Numeric),
        new JdeField("D2RQDD", "D2RQDD", JdeDataType.Numeric),
        new JdeField("D2AAMR", "D2AAMR", JdeDataType.Numeric),
        new JdeField("D2AAFR", "D2AAFR", JdeDataType.Numeric),
        new JdeField("D2AAMS", "D2AAMS", JdeDataType.Numeric),
        new JdeField("D2AAFS", "D2AAFS", JdeDataType.Numeric),
        new JdeField("D2AAMC", "D2AAMC", JdeDataType.Numeric),
        new JdeField("D2AAFC", "D2AAFC", JdeDataType.Numeric),
        new JdeField("D2AMQR", "D2AMQR", JdeDataType.Numeric),
        new JdeField("D2AFQR", "D2AFQR", JdeDataType.Numeric),
        new JdeField("D2AMQS", "D2AMQS", JdeDataType.Numeric),
        new JdeField("D2AFQS", "D2AFQS", JdeDataType.Numeric),
        new JdeField("D2AMQC", "D2AMQC", JdeDataType.Numeric),
        new JdeField("D2AFQC", "D2AFQC", JdeDataType.Numeric),
        new JdeField("D2PCHG", "D2PCHG", JdeDataType.Numeric),
        new JdeField("D2AID", "D2AID", JdeDataType.String, 16),
        new JdeField("D2ANI", "D2ANI", JdeDataType.String, 58),
        new JdeField("D2OBJ", "D2OBJ", JdeDataType.String, 12),
        new JdeField("D2SUB", "D2SUB", JdeDataType.String, 16),
        new JdeField("D2DOCO", "D2DOCO", JdeDataType.Numeric),
        new JdeField("D2DCTO", "D2DCTO", JdeDataType.String, 4),
        new JdeField("D2COCH", "D2COCH", JdeDataType.String, 6),
        new JdeField("D2LNCT", "D2LNCT", JdeDataType.Numeric),
        new JdeField("D2KCO", "D2KCO", JdeDataType.String, 10),
        new JdeField("D2AN8O", "D2AN8O", JdeDataType.Numeric),
        new JdeField("D2OPIM", "D2OPIM", JdeDataType.String, 30),
        new JdeField("D2PCOF", "D2PCOF", JdeDataType.String, 2),
        new JdeField("D2DRVP", "D2DRVP", JdeDataType.Numeric),
        new JdeField("D2CRCL", "D2CRCL", JdeDataType.String, 2),
        new JdeField("D2CRRM", "D2CRRM", JdeDataType.String, 2),
        new JdeField("D2CRCD", "D2CRCD", JdeDataType.String, 6),
        new JdeField("D2CRR", "D2CRR", JdeDataType.Numeric),
        new JdeField("D2CRCF", "D2CRCF", JdeDataType.String, 6),
        new JdeField("D2CRRD", "D2CRRD", JdeDataType.Numeric),
        new JdeField("D2USER", "D2USER", JdeDataType.String, 20),
        new JdeField("D2PID", "D2PID", JdeDataType.String, 20),
        new JdeField("D2JOBN", "D2JOBN", JdeDataType.String, 20),
        new JdeField("D2UPMJ", "D2UPMJ", JdeDataType.Numeric),
        new JdeField("D2UPMT", "D2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5314_0", "Primary Key on D2MCU, D2PPCO", new[] { "D2MCU", "D2PPCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5314_2", "Index on D2PPCO", new[] { "D2PPCO" }),
        new JdeIndex("F5314_3", "Index on D2MCU, D2PCHG, D2PPCO", new[] { "D2MCU", "D2PCHG", "D2PPCO" }),
        new JdeIndex("F5314_4", "Index on D2MCU, D2DRQJ, D2PPCO", new[] { "D2MCU", "D2DRQJ", "D2PPCO" }),
        new JdeIndex("F5314_5", "Index on D2MCU, SYS_NC00049$", new[] { "D2MCU", "SYS_NC00049$" })
    };
}
