using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4600T1 - .
/// </summary>
public class F4600T1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R1RQBT.
        /// </summary>
        public const string R1RQBT = "R1RQBT";

        /// <summary>
        /// R1RQSQ.
        /// </summary>
        public const string R1RQSQ = "R1RQSQ";

        /// <summary>
        /// R1DTSG.
        /// </summary>
        public const string R1DTSG = "R1DTSG";

        /// <summary>
        /// R1TMSG.
        /// </summary>
        public const string R1TMSG = "R1TMSG";

        /// <summary>
        /// R1DTCNF.
        /// </summary>
        public const string R1DTCNF = "R1DTCNF";

        /// <summary>
        /// R1TMCNF.
        /// </summary>
        public const string R1TMCNF = "R1TMCNF";

        /// <summary>
        /// R1DTCAN.
        /// </summary>
        public const string R1DTCAN = "R1DTCAN";

        /// <summary>
        /// R1TMCAN.
        /// </summary>
        public const string R1TMCAN = "R1TMCAN";

        /// <summary>
        /// R1RFUC1.
        /// </summary>
        public const string R1RFUC1 = "R1RFUC1";

        /// <summary>
        /// R1RFUC2.
        /// </summary>
        public const string R1RFUC2 = "R1RFUC2";

        /// <summary>
        /// R1RFUC3.
        /// </summary>
        public const string R1RFUC3 = "R1RFUC3";

        /// <summary>
        /// R1RFUS1.
        /// </summary>
        public const string R1RFUS1 = "R1RFUS1";

        /// <summary>
        /// R1RFUS2.
        /// </summary>
        public const string R1RFUS2 = "R1RFUS2";

        /// <summary>
        /// R1RFUS3.
        /// </summary>
        public const string R1RFUS3 = "R1RFUS3";

        /// <summary>
        /// R1RFUN1.
        /// </summary>
        public const string R1RFUN1 = "R1RFUN1";

        /// <summary>
        /// R1RFUN2.
        /// </summary>
        public const string R1RFUN2 = "R1RFUN2";

        /// <summary>
        /// R1RFUN3.
        /// </summary>
        public const string R1RFUN3 = "R1RFUN3";

        /// <summary>
        /// R1RFUD1.
        /// </summary>
        public const string R1RFUD1 = "R1RFUD1";

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
    }

    /// <inheritdoc />
    public override string TableName => "F4600T1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R1RQBT", "R1RQBT", JdeDataType.Numeric, null, true, true),
        new JdeField("R1RQSQ", "R1RQSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("R1DTSG", "R1DTSG", JdeDataType.Numeric),
        new JdeField("R1TMSG", "R1TMSG", JdeDataType.Numeric),
        new JdeField("R1DTCNF", "R1DTCNF", JdeDataType.Numeric),
        new JdeField("R1TMCNF", "R1TMCNF", JdeDataType.Numeric),
        new JdeField("R1DTCAN", "R1DTCAN", JdeDataType.Numeric),
        new JdeField("R1TMCAN", "R1TMCAN", JdeDataType.Numeric),
        new JdeField("R1RFUC1", "R1RFUC1", JdeDataType.String, 2),
        new JdeField("R1RFUC2", "R1RFUC2", JdeDataType.String, 2),
        new JdeField("R1RFUC3", "R1RFUC3", JdeDataType.String, 2),
        new JdeField("R1RFUS1", "R1RFUS1", JdeDataType.String, 30),
        new JdeField("R1RFUS2", "R1RFUS2", JdeDataType.String, 30),
        new JdeField("R1RFUS3", "R1RFUS3", JdeDataType.String, 30),
        new JdeField("R1RFUN1", "R1RFUN1", JdeDataType.Numeric),
        new JdeField("R1RFUN2", "R1RFUN2", JdeDataType.Numeric),
        new JdeField("R1RFUN3", "R1RFUN3", JdeDataType.Numeric),
        new JdeField("R1RFUD1", "R1RFUD1", JdeDataType.Numeric),
        new JdeField("R1USER", "R1USER", JdeDataType.String, 20),
        new JdeField("R1PID", "R1PID", JdeDataType.String, 20),
        new JdeField("R1JOBN", "R1JOBN", JdeDataType.String, 20),
        new JdeField("R1UPMJ", "R1UPMJ", JdeDataType.Numeric),
        new JdeField("R1TDAY", "R1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4600T1_0", "Primary Key on R1RQBT, R1RQSQ", new[] { "R1RQBT", "R1RQSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
