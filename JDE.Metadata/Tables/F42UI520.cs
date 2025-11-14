using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI520 - .
/// </summary>
public class F42UI520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S8SEQ.
        /// </summary>
        public const string S8SEQ = "S8SEQ";

        /// <summary>
        /// S8DOCO.
        /// </summary>
        public const string S8DOCO = "S8DOCO";

        /// <summary>
        /// S8DCTO.
        /// </summary>
        public const string S8DCTO = "S8DCTO";

        /// <summary>
        /// S8KCOO.
        /// </summary>
        public const string S8KCOO = "S8KCOO";

        /// <summary>
        /// S8MCU.
        /// </summary>
        public const string S8MCU = "S8MCU";

        /// <summary>
        /// S8AN8.
        /// </summary>
        public const string S8AN8 = "S8AN8";

        /// <summary>
        /// S8SHAN.
        /// </summary>
        public const string S8SHAN = "S8SHAN";

        /// <summary>
        /// S8MLNM.
        /// </summary>
        public const string S8MLNM = "S8MLNM";

        /// <summary>
        /// S8TAD1.
        /// </summary>
        public const string S8TAD1 = "S8TAD1";

        /// <summary>
        /// S8TAD2.
        /// </summary>
        public const string S8TAD2 = "S8TAD2";

        /// <summary>
        /// S8TAD3.
        /// </summary>
        public const string S8TAD3 = "S8TAD3";

        /// <summary>
        /// S8TAD4.
        /// </summary>
        public const string S8TAD4 = "S8TAD4";

        /// <summary>
        /// S8TAD5.
        /// </summary>
        public const string S8TAD5 = "S8TAD5";

        /// <summary>
        /// S8TAD6.
        /// </summary>
        public const string S8TAD6 = "S8TAD6";

        /// <summary>
        /// S8MLN1.
        /// </summary>
        public const string S8MLN1 = "S8MLN1";

        /// <summary>
        /// S8PAD1.
        /// </summary>
        public const string S8PAD1 = "S8PAD1";

        /// <summary>
        /// S8PAD2.
        /// </summary>
        public const string S8PAD2 = "S8PAD2";

        /// <summary>
        /// S8PAD3.
        /// </summary>
        public const string S8PAD3 = "S8PAD3";

        /// <summary>
        /// S8PAD4.
        /// </summary>
        public const string S8PAD4 = "S8PAD4";

        /// <summary>
        /// S8PAD5.
        /// </summary>
        public const string S8PAD5 = "S8PAD5";

        /// <summary>
        /// S8PAD6.
        /// </summary>
        public const string S8PAD6 = "S8PAD6";

        /// <summary>
        /// S8TRDJ.
        /// </summary>
        public const string S8TRDJ = "S8TRDJ";

        /// <summary>
        /// S8DRQJ.
        /// </summary>
        public const string S8DRQJ = "S8DRQJ";

        /// <summary>
        /// S8TKBY.
        /// </summary>
        public const string S8TKBY = "S8TKBY";

        /// <summary>
        /// S8DEL1.
        /// </summary>
        public const string S8DEL1 = "S8DEL1";

        /// <summary>
        /// S8DEL2.
        /// </summary>
        public const string S8DEL2 = "S8DEL2";

        /// <summary>
        /// S8CRR.
        /// </summary>
        public const string S8CRR = "S8CRR";

        /// <summary>
        /// S8CRDC.
        /// </summary>
        public const string S8CRDC = "S8CRDC";

        /// <summary>
        /// S8CRCD.
        /// </summary>
        public const string S8CRCD = "S8CRCD";

        /// <summary>
        /// S8FRTH.
        /// </summary>
        public const string S8FRTH = "S8FRTH";

        /// <summary>
        /// S8PTC.
        /// </summary>
        public const string S8PTC = "S8PTC";

        /// <summary>
        /// S8CORD.
        /// </summary>
        public const string S8CORD = "S8CORD";

        /// <summary>
        /// S8ORBY.
        /// </summary>
        public const string S8ORBY = "S8ORBY";

        /// <summary>
        /// S8RKCO.
        /// </summary>
        public const string S8RKCO = "S8RKCO";

        /// <summary>
        /// S8RORN.
        /// </summary>
        public const string S8RORN = "S8RORN";

        /// <summary>
        /// S8RCTO.
        /// </summary>
        public const string S8RCTO = "S8RCTO";

        /// <summary>
        /// S8VR01.
        /// </summary>
        public const string S8VR01 = "S8VR01";

        /// <summary>
        /// S8ANBY.
        /// </summary>
        public const string S8ANBY = "S8ANBY";

        /// <summary>
        /// S8TOT1.
        /// </summary>
        public const string S8TOT1 = "S8TOT1";

        /// <summary>
        /// S8TOT2.
        /// </summary>
        public const string S8TOT2 = "S8TOT2";

        /// <summary>
        /// S8INMG.
        /// </summary>
        public const string S8INMG = "S8INMG";

        /// <summary>
        /// S8URCD.
        /// </summary>
        public const string S8URCD = "S8URCD";

        /// <summary>
        /// S8URDT.
        /// </summary>
        public const string S8URDT = "S8URDT";

        /// <summary>
        /// S8URAT.
        /// </summary>
        public const string S8URAT = "S8URAT";

        /// <summary>
        /// S8URAB.
        /// </summary>
        public const string S8URAB = "S8URAB";

        /// <summary>
        /// S8URRF.
        /// </summary>
        public const string S8URRF = "S8URRF";

        /// <summary>
        /// S8USER.
        /// </summary>
        public const string S8USER = "S8USER";

        /// <summary>
        /// S8PID.
        /// </summary>
        public const string S8PID = "S8PID";

        /// <summary>
        /// S8JOBN.
        /// </summary>
        public const string S8JOBN = "S8JOBN";

        /// <summary>
        /// S8UPMJ.
        /// </summary>
        public const string S8UPMJ = "S8UPMJ";

        /// <summary>
        /// S8TDAY.
        /// </summary>
        public const string S8TDAY = "S8TDAY";

        /// <summary>
        /// S8CTID.
        /// </summary>
        public const string S8CTID = "S8CTID";

        /// <summary>
        /// S8JOBS.
        /// </summary>
        public const string S8JOBS = "S8JOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S8SEQ", "S8SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("S8DOCO", "S8DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("S8DCTO", "S8DCTO", JdeDataType.String, 4, true, true),
        new JdeField("S8KCOO", "S8KCOO", JdeDataType.String, 10, true, true),
        new JdeField("S8MCU", "S8MCU", JdeDataType.String, 24),
        new JdeField("S8AN8", "S8AN8", JdeDataType.Numeric),
        new JdeField("S8SHAN", "S8SHAN", JdeDataType.Numeric),
        new JdeField("S8MLNM", "S8MLNM", JdeDataType.String, 80),
        new JdeField("S8TAD1", "S8TAD1", JdeDataType.String, 80),
        new JdeField("S8TAD2", "S8TAD2", JdeDataType.String, 80),
        new JdeField("S8TAD3", "S8TAD3", JdeDataType.String, 80),
        new JdeField("S8TAD4", "S8TAD4", JdeDataType.String, 80),
        new JdeField("S8TAD5", "S8TAD5", JdeDataType.String, 80),
        new JdeField("S8TAD6", "S8TAD6", JdeDataType.String, 80),
        new JdeField("S8MLN1", "S8MLN1", JdeDataType.String, 80),
        new JdeField("S8PAD1", "S8PAD1", JdeDataType.String, 80),
        new JdeField("S8PAD2", "S8PAD2", JdeDataType.String, 80),
        new JdeField("S8PAD3", "S8PAD3", JdeDataType.String, 80),
        new JdeField("S8PAD4", "S8PAD4", JdeDataType.String, 80),
        new JdeField("S8PAD5", "S8PAD5", JdeDataType.String, 80),
        new JdeField("S8PAD6", "S8PAD6", JdeDataType.String, 80),
        new JdeField("S8TRDJ", "S8TRDJ", JdeDataType.Numeric),
        new JdeField("S8DRQJ", "S8DRQJ", JdeDataType.Numeric),
        new JdeField("S8TKBY", "S8TKBY", JdeDataType.String, 20),
        new JdeField("S8DEL1", "S8DEL1", JdeDataType.String, 60),
        new JdeField("S8DEL2", "S8DEL2", JdeDataType.String, 60),
        new JdeField("S8CRR", "S8CRR", JdeDataType.Numeric),
        new JdeField("S8CRDC", "S8CRDC", JdeDataType.String, 6),
        new JdeField("S8CRCD", "S8CRCD", JdeDataType.String, 6),
        new JdeField("S8FRTH", "S8FRTH", JdeDataType.String, 6),
        new JdeField("S8PTC", "S8PTC", JdeDataType.String, 6),
        new JdeField("S8CORD", "S8CORD", JdeDataType.Numeric),
        new JdeField("S8ORBY", "S8ORBY", JdeDataType.String, 20),
        new JdeField("S8RKCO", "S8RKCO", JdeDataType.String, 10),
        new JdeField("S8RORN", "S8RORN", JdeDataType.String, 16),
        new JdeField("S8RCTO", "S8RCTO", JdeDataType.String, 4),
        new JdeField("S8VR01", "S8VR01", JdeDataType.String, 50),
        new JdeField("S8ANBY", "S8ANBY", JdeDataType.Numeric),
        new JdeField("S8TOT1", "S8TOT1", JdeDataType.Numeric),
        new JdeField("S8TOT2", "S8TOT2", JdeDataType.Numeric),
        new JdeField("S8INMG", "S8INMG", JdeDataType.String, 20),
        new JdeField("S8URCD", "S8URCD", JdeDataType.String, 4),
        new JdeField("S8URDT", "S8URDT", JdeDataType.Numeric),
        new JdeField("S8URAT", "S8URAT", JdeDataType.Numeric),
        new JdeField("S8URAB", "S8URAB", JdeDataType.Numeric),
        new JdeField("S8URRF", "S8URRF", JdeDataType.String, 30),
        new JdeField("S8USER", "S8USER", JdeDataType.String, 20),
        new JdeField("S8PID", "S8PID", JdeDataType.String, 20),
        new JdeField("S8JOBN", "S8JOBN", JdeDataType.String, 20),
        new JdeField("S8UPMJ", "S8UPMJ", JdeDataType.Numeric),
        new JdeField("S8TDAY", "S8TDAY", JdeDataType.Numeric),
        new JdeField("S8CTID", "S8CTID", JdeDataType.String, 30),
        new JdeField("S8JOBS", "S8JOBS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI520_0", "Primary Key on S8SEQ, S8DOCO, S8DCTO, S8KCOO", new[] { "S8SEQ", "S8DOCO", "S8DCTO", "S8KCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI520_2", "Index on S8DOCO, S8DCTO, S8KCOO", new[] { "S8DOCO", "S8DCTO", "S8KCOO" })
    };
}
