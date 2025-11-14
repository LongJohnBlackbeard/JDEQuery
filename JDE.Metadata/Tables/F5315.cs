using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5315 - .
/// </summary>
public class F5315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D3MCU.
        /// </summary>
        public const string D3MCU = "D3MCU";

        /// <summary>
        /// D3PCHG.
        /// </summary>
        public const string D3PCHG = "D3PCHG";

        /// <summary>
        /// D3CO.
        /// </summary>
        public const string D3CO = "D3CO";

        /// <summary>
        /// D3DL01.
        /// </summary>
        public const string D3DL01 = "D3DL01";

        /// <summary>
        /// D3PST2.
        /// </summary>
        public const string D3PST2 = "D3PST2";

        /// <summary>
        /// D3DRQJ.
        /// </summary>
        public const string D3DRQJ = "D3DRQJ";

        /// <summary>
        /// D3APRD.
        /// </summary>
        public const string D3APRD = "D3APRD";

        /// <summary>
        /// D3AREQ.
        /// </summary>
        public const string D3AREQ = "D3AREQ";

        /// <summary>
        /// D3APRV.
        /// </summary>
        public const string D3APRV = "D3APRV";

        /// <summary>
        /// D3EXTD.
        /// </summary>
        public const string D3EXTD = "D3EXTD";

        /// <summary>
        /// D3RQDD.
        /// </summary>
        public const string D3RQDD = "D3RQDD";

        /// <summary>
        /// D3AAMR.
        /// </summary>
        public const string D3AAMR = "D3AAMR";

        /// <summary>
        /// D3AAFR.
        /// </summary>
        public const string D3AAFR = "D3AAFR";

        /// <summary>
        /// D3AAMS.
        /// </summary>
        public const string D3AAMS = "D3AAMS";

        /// <summary>
        /// D3AAFS.
        /// </summary>
        public const string D3AAFS = "D3AAFS";

        /// <summary>
        /// D3AAMC.
        /// </summary>
        public const string D3AAMC = "D3AAMC";

        /// <summary>
        /// D3AAFC.
        /// </summary>
        public const string D3AAFC = "D3AAFC";

        /// <summary>
        /// D3AMQR.
        /// </summary>
        public const string D3AMQR = "D3AMQR";

        /// <summary>
        /// D3AFQR.
        /// </summary>
        public const string D3AFQR = "D3AFQR";

        /// <summary>
        /// D3AMQS.
        /// </summary>
        public const string D3AMQS = "D3AMQS";

        /// <summary>
        /// D3AFQS.
        /// </summary>
        public const string D3AFQS = "D3AFQS";

        /// <summary>
        /// D3AMQC.
        /// </summary>
        public const string D3AMQC = "D3AMQC";

        /// <summary>
        /// D3AFQC.
        /// </summary>
        public const string D3AFQC = "D3AFQC";

        /// <summary>
        /// D3AID.
        /// </summary>
        public const string D3AID = "D3AID";

        /// <summary>
        /// D3ANI.
        /// </summary>
        public const string D3ANI = "D3ANI";

        /// <summary>
        /// D3OBJ.
        /// </summary>
        public const string D3OBJ = "D3OBJ";

        /// <summary>
        /// D3SUB.
        /// </summary>
        public const string D3SUB = "D3SUB";

        /// <summary>
        /// D3DOCO.
        /// </summary>
        public const string D3DOCO = "D3DOCO";

        /// <summary>
        /// D3DCTO.
        /// </summary>
        public const string D3DCTO = "D3DCTO";

        /// <summary>
        /// D3COCH.
        /// </summary>
        public const string D3COCH = "D3COCH";

        /// <summary>
        /// D3LNCT.
        /// </summary>
        public const string D3LNCT = "D3LNCT";

        /// <summary>
        /// D3KCO.
        /// </summary>
        public const string D3KCO = "D3KCO";

        /// <summary>
        /// D3AN8O.
        /// </summary>
        public const string D3AN8O = "D3AN8O";

        /// <summary>
        /// D3OPIM.
        /// </summary>
        public const string D3OPIM = "D3OPIM";

        /// <summary>
        /// D3CGOF.
        /// </summary>
        public const string D3CGOF = "D3CGOF";

        /// <summary>
        /// D3DRVP.
        /// </summary>
        public const string D3DRVP = "D3DRVP";

        /// <summary>
        /// D3CRCL.
        /// </summary>
        public const string D3CRCL = "D3CRCL";

        /// <summary>
        /// D3CRRM.
        /// </summary>
        public const string D3CRRM = "D3CRRM";

        /// <summary>
        /// D3CRCD.
        /// </summary>
        public const string D3CRCD = "D3CRCD";

        /// <summary>
        /// D3CRR.
        /// </summary>
        public const string D3CRR = "D3CRR";

        /// <summary>
        /// D3CRCF.
        /// </summary>
        public const string D3CRCF = "D3CRCF";

        /// <summary>
        /// D3CRRD.
        /// </summary>
        public const string D3CRRD = "D3CRRD";

        /// <summary>
        /// D3USER.
        /// </summary>
        public const string D3USER = "D3USER";

        /// <summary>
        /// D3PID.
        /// </summary>
        public const string D3PID = "D3PID";

        /// <summary>
        /// D3JOBN.
        /// </summary>
        public const string D3JOBN = "D3JOBN";

        /// <summary>
        /// D3UPMJ.
        /// </summary>
        public const string D3UPMJ = "D3UPMJ";

        /// <summary>
        /// D3UPMT.
        /// </summary>
        public const string D3UPMT = "D3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D3MCU", "D3MCU", JdeDataType.String, 24, true, true),
        new JdeField("D3PCHG", "D3PCHG", JdeDataType.Numeric, null, true, true),
        new JdeField("D3CO", "D3CO", JdeDataType.String, 10),
        new JdeField("D3DL01", "D3DL01", JdeDataType.String, 60),
        new JdeField("D3PST2", "D3PST2", JdeDataType.String, 2),
        new JdeField("D3DRQJ", "D3DRQJ", JdeDataType.Numeric),
        new JdeField("D3APRD", "D3APRD", JdeDataType.Numeric),
        new JdeField("D3AREQ", "D3AREQ", JdeDataType.Numeric),
        new JdeField("D3APRV", "D3APRV", JdeDataType.Numeric),
        new JdeField("D3EXTD", "D3EXTD", JdeDataType.Numeric),
        new JdeField("D3RQDD", "D3RQDD", JdeDataType.Numeric),
        new JdeField("D3AAMR", "D3AAMR", JdeDataType.Numeric),
        new JdeField("D3AAFR", "D3AAFR", JdeDataType.Numeric),
        new JdeField("D3AAMS", "D3AAMS", JdeDataType.Numeric),
        new JdeField("D3AAFS", "D3AAFS", JdeDataType.Numeric),
        new JdeField("D3AAMC", "D3AAMC", JdeDataType.Numeric),
        new JdeField("D3AAFC", "D3AAFC", JdeDataType.Numeric),
        new JdeField("D3AMQR", "D3AMQR", JdeDataType.Numeric),
        new JdeField("D3AFQR", "D3AFQR", JdeDataType.Numeric),
        new JdeField("D3AMQS", "D3AMQS", JdeDataType.Numeric),
        new JdeField("D3AFQS", "D3AFQS", JdeDataType.Numeric),
        new JdeField("D3AMQC", "D3AMQC", JdeDataType.Numeric),
        new JdeField("D3AFQC", "D3AFQC", JdeDataType.Numeric),
        new JdeField("D3AID", "D3AID", JdeDataType.String, 16),
        new JdeField("D3ANI", "D3ANI", JdeDataType.String, 58),
        new JdeField("D3OBJ", "D3OBJ", JdeDataType.String, 12),
        new JdeField("D3SUB", "D3SUB", JdeDataType.String, 16),
        new JdeField("D3DOCO", "D3DOCO", JdeDataType.Numeric),
        new JdeField("D3DCTO", "D3DCTO", JdeDataType.String, 4),
        new JdeField("D3COCH", "D3COCH", JdeDataType.String, 6),
        new JdeField("D3LNCT", "D3LNCT", JdeDataType.Numeric),
        new JdeField("D3KCO", "D3KCO", JdeDataType.String, 10),
        new JdeField("D3AN8O", "D3AN8O", JdeDataType.Numeric),
        new JdeField("D3OPIM", "D3OPIM", JdeDataType.String, 30),
        new JdeField("D3CGOF", "D3CGOF", JdeDataType.String, 2),
        new JdeField("D3DRVP", "D3DRVP", JdeDataType.Numeric),
        new JdeField("D3CRCL", "D3CRCL", JdeDataType.String, 2),
        new JdeField("D3CRRM", "D3CRRM", JdeDataType.String, 2),
        new JdeField("D3CRCD", "D3CRCD", JdeDataType.String, 6),
        new JdeField("D3CRR", "D3CRR", JdeDataType.Numeric),
        new JdeField("D3CRCF", "D3CRCF", JdeDataType.String, 6),
        new JdeField("D3CRRD", "D3CRRD", JdeDataType.Numeric),
        new JdeField("D3USER", "D3USER", JdeDataType.String, 20),
        new JdeField("D3PID", "D3PID", JdeDataType.String, 20),
        new JdeField("D3JOBN", "D3JOBN", JdeDataType.String, 20),
        new JdeField("D3UPMJ", "D3UPMJ", JdeDataType.Numeric),
        new JdeField("D3UPMT", "D3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5315_0", "Primary Key on D3MCU, D3PCHG", new[] { "D3MCU", "D3PCHG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5315_2", "Index on D3PCHG", new[] { "D3PCHG" }),
        new JdeIndex("F5315_3", "Index on D3MCU, D3DRQJ, D3PCHG", new[] { "D3MCU", "D3DRQJ", "D3PCHG" }),
        new JdeIndex("F5315_4", "Index on D3MCU, SYS_NC00048$", new[] { "D3MCU", "SYS_NC00048$" })
    };
}
