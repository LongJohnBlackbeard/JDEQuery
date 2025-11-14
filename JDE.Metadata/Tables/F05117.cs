using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05117 - .
/// </summary>
public class F05117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLGOAL.
        /// </summary>
        public const string GLGOAL = "GLGOAL";

        /// <summary>
        /// GLGSEQ.
        /// </summary>
        public const string GLGSEQ = "GLGSEQ";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLJCC.
        /// </summary>
        public const string GLJCC = "GLJCC";

        /// <summary>
        /// GLCMPE.
        /// </summary>
        public const string GLCMPE = "GLCMPE";

        /// <summary>
        /// GLCMPC.
        /// </summary>
        public const string GLCMPC = "GLCMPC";

        /// <summary>
        /// GLCMPV.
        /// </summary>
        public const string GLCMPV = "GLCMPV";
    }

    /// <inheritdoc />
    public override string TableName => "F05117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLGOAL", "GLGOAL", JdeDataType.String, 20, true, true),
        new JdeField("GLGSEQ", "GLGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLJCC", "GLJCC", JdeDataType.String, 20),
        new JdeField("GLCMPE", "GLCMPE", JdeDataType.String, 6),
        new JdeField("GLCMPC", "GLCMPC", JdeDataType.String, 20),
        new JdeField("GLCMPV", "GLCMPV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05117_0", "Primary Key on GLGOAL, GLGSEQ", new[] { "GLGOAL", "GLGSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05117_2", "Index on GLGOAL, GLJCC, GLCMPE, GLCMPC, SYS_NC00012$", new[] { "GLGOAL", "GLJCC", "GLCMPE", "GLCMPC", "SYS_NC00012$" })
    };
}
