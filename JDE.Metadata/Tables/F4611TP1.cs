using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4611TP1 - .
/// </summary>
public class F4611TP1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R2SGBT.
        /// </summary>
        public const string R2SGBT = "R2SGBT";

        /// <summary>
        /// R2SGSQ.
        /// </summary>
        public const string R2SGSQ = "R2SGSQ";

        /// <summary>
        /// R2RQBT.
        /// </summary>
        public const string R2RQBT = "R2RQBT";

        /// <summary>
        /// R2RQSQ.
        /// </summary>
        public const string R2RQSQ = "R2RQSQ";

        /// <summary>
        /// R2SDTCNF.
        /// </summary>
        public const string R2SDTCNF = "R2SDTCNF";

        /// <summary>
        /// R2STMCNF.
        /// </summary>
        public const string R2STMCNF = "R2STMCNF";

        /// <summary>
        /// R2SDTCAN.
        /// </summary>
        public const string R2SDTCAN = "R2SDTCAN";

        /// <summary>
        /// R2STMCAN.
        /// </summary>
        public const string R2STMCAN = "R2STMCAN";

        /// <summary>
        /// R2AN8.
        /// </summary>
        public const string R2AN8 = "R2AN8";

        /// <summary>
        /// R2NUMB.
        /// </summary>
        public const string R2NUMB = "R2NUMB";

        /// <summary>
        /// R2SFUC1.
        /// </summary>
        public const string R2SFUC1 = "R2SFUC1";

        /// <summary>
        /// R2SFUC2.
        /// </summary>
        public const string R2SFUC2 = "R2SFUC2";

        /// <summary>
        /// R2SFUC3.
        /// </summary>
        public const string R2SFUC3 = "R2SFUC3";

        /// <summary>
        /// R2SFUS1.
        /// </summary>
        public const string R2SFUS1 = "R2SFUS1";

        /// <summary>
        /// R2SFUS2.
        /// </summary>
        public const string R2SFUS2 = "R2SFUS2";

        /// <summary>
        /// R2SFUS3.
        /// </summary>
        public const string R2SFUS3 = "R2SFUS3";

        /// <summary>
        /// R2SFUN1.
        /// </summary>
        public const string R2SFUN1 = "R2SFUN1";

        /// <summary>
        /// R2SFUN2.
        /// </summary>
        public const string R2SFUN2 = "R2SFUN2";

        /// <summary>
        /// R2SFUN3.
        /// </summary>
        public const string R2SFUN3 = "R2SFUN3";

        /// <summary>
        /// R2SFUD1.
        /// </summary>
        public const string R2SFUD1 = "R2SFUD1";

        /// <summary>
        /// R2USER.
        /// </summary>
        public const string R2USER = "R2USER";

        /// <summary>
        /// R2PID.
        /// </summary>
        public const string R2PID = "R2PID";

        /// <summary>
        /// R2JOBN.
        /// </summary>
        public const string R2JOBN = "R2JOBN";

        /// <summary>
        /// R2UPMJ.
        /// </summary>
        public const string R2UPMJ = "R2UPMJ";

        /// <summary>
        /// R2TDAY.
        /// </summary>
        public const string R2TDAY = "R2TDAY";

        /// <summary>
        /// R2EMPNME.
        /// </summary>
        public const string R2EMPNME = "R2EMPNME";

        /// <summary>
        /// R2EMPSHIFT.
        /// </summary>
        public const string R2EMPSHIFT = "R2EMPSHIFT";

        /// <summary>
        /// R2EMPTRDT.
        /// </summary>
        public const string R2EMPTRDT = "R2EMPTRDT";

        /// <summary>
        /// R2EMPTRTM.
        /// </summary>
        public const string R2EMPTRTM = "R2EMPTRTM";

        /// <summary>
        /// R2EMPELTM.
        /// </summary>
        public const string R2EMPELTM = "R2EMPELTM";

        /// <summary>
        /// R2EMPTRID.
        /// </summary>
        public const string R2EMPTRID = "R2EMPTRID";

        /// <summary>
        /// R2EMPSFTDT.
        /// </summary>
        public const string R2EMPSFTDT = "R2EMPSFTDT";

        /// <summary>
        /// R2EMPSFTTM.
        /// </summary>
        public const string R2EMPSFTTM = "R2EMPSFTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F4611TP1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R2SGBT", "R2SGBT", JdeDataType.Numeric, null, true, true),
        new JdeField("R2SGSQ", "R2SGSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("R2RQBT", "R2RQBT", JdeDataType.Numeric),
        new JdeField("R2RQSQ", "R2RQSQ", JdeDataType.Numeric),
        new JdeField("R2SDTCNF", "R2SDTCNF", JdeDataType.Numeric),
        new JdeField("R2STMCNF", "R2STMCNF", JdeDataType.Numeric),
        new JdeField("R2SDTCAN", "R2SDTCAN", JdeDataType.Numeric),
        new JdeField("R2STMCAN", "R2STMCAN", JdeDataType.Numeric),
        new JdeField("R2AN8", "R2AN8", JdeDataType.Numeric),
        new JdeField("R2NUMB", "R2NUMB", JdeDataType.Numeric),
        new JdeField("R2SFUC1", "R2SFUC1", JdeDataType.String, 2),
        new JdeField("R2SFUC2", "R2SFUC2", JdeDataType.String, 2),
        new JdeField("R2SFUC3", "R2SFUC3", JdeDataType.String, 2),
        new JdeField("R2SFUS1", "R2SFUS1", JdeDataType.String, 30),
        new JdeField("R2SFUS2", "R2SFUS2", JdeDataType.String, 30),
        new JdeField("R2SFUS3", "R2SFUS3", JdeDataType.String, 30),
        new JdeField("R2SFUN1", "R2SFUN1", JdeDataType.Numeric),
        new JdeField("R2SFUN2", "R2SFUN2", JdeDataType.Numeric),
        new JdeField("R2SFUN3", "R2SFUN3", JdeDataType.Numeric),
        new JdeField("R2SFUD1", "R2SFUD1", JdeDataType.Numeric),
        new JdeField("R2USER", "R2USER", JdeDataType.String, 20),
        new JdeField("R2PID", "R2PID", JdeDataType.String, 20),
        new JdeField("R2JOBN", "R2JOBN", JdeDataType.String, 20),
        new JdeField("R2UPMJ", "R2UPMJ", JdeDataType.Numeric),
        new JdeField("R2TDAY", "R2TDAY", JdeDataType.Numeric),
        new JdeField("R2EMPNME", "R2EMPNME", JdeDataType.String, 80),
        new JdeField("R2EMPSHIFT", "R2EMPSHIFT", JdeDataType.String, 20),
        new JdeField("R2EMPTRDT", "R2EMPTRDT", JdeDataType.Numeric),
        new JdeField("R2EMPTRTM", "R2EMPTRTM", JdeDataType.Numeric),
        new JdeField("R2EMPELTM", "R2EMPELTM", JdeDataType.Numeric),
        new JdeField("R2EMPTRID", "R2EMPTRID", JdeDataType.String, 16),
        new JdeField("R2EMPSFTDT", "R2EMPSFTDT", JdeDataType.Numeric),
        new JdeField("R2EMPSFTTM", "R2EMPSFTTM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4611TP1_0", "Primary Key on R2SGBT, R2SGSQ", new[] { "R2SGBT", "R2SGSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4611TP1_2", "Index on R2RQBT, R2RQSQ", new[] { "R2RQBT", "R2RQSQ" })
    };
}
