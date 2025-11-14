using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A01 - .
/// </summary>
public class F81A01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M1PID.
        /// </summary>
        public const string M1PID = "M1PID";

        /// <summary>
        /// M1OPT#.
        /// </summary>
        public const string M1OPT_ = "M1OPT#";

        /// <summary>
        /// M1SQN.
        /// </summary>
        public const string M1SQN = "M1SQN";

        /// <summary>
        /// M1JD.
        /// </summary>
        public const string M1JD = "M1JD";

        /// <summary>
        /// M1FPID.
        /// </summary>
        public const string M1FPID = "M1FPID";

        /// <summary>
        /// M1OBNM.
        /// </summary>
        public const string M1OBNM = "M1OBNM";

        /// <summary>
        /// M1LITN.
        /// </summary>
        public const string M1LITN = "M1LITN";

        /// <summary>
        /// M1BSQN.
        /// </summary>
        public const string M1BSQN = "M1BSQN";

        /// <summary>
        /// M1BCNT.
        /// </summary>
        public const string M1BCNT = "M1BCNT";

        /// <summary>
        /// M1LTBN.
        /// </summary>
        public const string M1LTBN = "M1LTBN";

        /// <summary>
        /// M1TXT1.
        /// </summary>
        public const string M1TXT1 = "M1TXT1";

        /// <summary>
        /// M1LPOD.
        /// </summary>
        public const string M1LPOD = "M1LPOD";

        /// <summary>
        /// M1LDSN.
        /// </summary>
        public const string M1LDSN = "M1LDSN";

        /// <summary>
        /// M1DS01.
        /// </summary>
        public const string M1DS01 = "M1DS01";

        /// <summary>
        /// M1OWTP.
        /// </summary>
        public const string M1OWTP = "M1OWTP";

        /// <summary>
        /// M1DTAI.
        /// </summary>
        public const string M1DTAI = "M1DTAI";

        /// <summary>
        /// M1LUS.
        /// </summary>
        public const string M1LUS = "M1LUS";

        /// <summary>
        /// M1FPD.
        /// </summary>
        public const string M1FPD = "M1FPD";

        /// <summary>
        /// M1UPMJ.
        /// </summary>
        public const string M1UPMJ = "M1UPMJ";

        /// <summary>
        /// M1JOBN.
        /// </summary>
        public const string M1JOBN = "M1JOBN";

        /// <summary>
        /// M1UPMT.
        /// </summary>
        public const string M1UPMT = "M1UPMT";

        /// <summary>
        /// M1GSTS.
        /// </summary>
        public const string M1GSTS = "M1GSTS";
    }

    /// <inheritdoc />
    public override string TableName => "F81A01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M1PID", "M1PID", JdeDataType.String, 20, true, true),
        new JdeField("M1OPT#", "M1OPT#", JdeDataType.Numeric, null, true, true),
        new JdeField("M1SQN", "M1SQN", JdeDataType.Numeric),
        new JdeField("M1JD", "M1JD", JdeDataType.String, 100),
        new JdeField("M1FPID", "M1FPID", JdeDataType.String, 20, true, true),
        new JdeField("M1OBNM", "M1OBNM", JdeDataType.String, 20),
        new JdeField("M1LITN", "M1LITN", JdeDataType.Numeric, null, true, true),
        new JdeField("M1BSQN", "M1BSQN", JdeDataType.Numeric, null, true, true),
        new JdeField("M1BCNT", "M1BCNT", JdeDataType.Numeric),
        new JdeField("M1LTBN", "M1LTBN", JdeDataType.String, 60),
        new JdeField("M1TXT1", "M1TXT1", JdeDataType.String, 100),
        new JdeField("M1LPOD", "M1LPOD", JdeDataType.String, 100),
        new JdeField("M1LDSN", "M1LDSN", JdeDataType.String, 20),
        new JdeField("M1DS01", "M1DS01", JdeDataType.String, 160),
        new JdeField("M1OWTP", "M1OWTP", JdeDataType.String, 4),
        new JdeField("M1DTAI", "M1DTAI", JdeDataType.String, 20),
        new JdeField("M1LUS", "M1LUS", JdeDataType.String, 20),
        new JdeField("M1FPD", "M1FPD", JdeDataType.String, 20),
        new JdeField("M1UPMJ", "M1UPMJ", JdeDataType.Numeric),
        new JdeField("M1JOBN", "M1JOBN", JdeDataType.String, 20),
        new JdeField("M1UPMT", "M1UPMT", JdeDataType.Numeric),
        new JdeField("M1GSTS", "M1GSTS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A01_0", "Primary Key on M1PID, M1OPT#, M1FPID, M1LITN, M1BSQN", new[] { "M1PID", "M1OPT#", "M1FPID", "M1LITN", "M1BSQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F81A01_7", "Index on M1FPID, M1LITN, M1BSQN", new[] { "M1FPID", "M1LITN", "M1BSQN" })
    };
}
