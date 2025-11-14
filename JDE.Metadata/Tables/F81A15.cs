using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A15 - .
/// </summary>
public class F81A15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M7LDFR.
        /// </summary>
        public const string M7LDFR = "M7LDFR";

        /// <summary>
        /// M7PID.
        /// </summary>
        public const string M7PID = "M7PID";

        /// <summary>
        /// M7VERS.
        /// </summary>
        public const string M7VERS = "M7VERS";

        /// <summary>
        /// M7SQN.
        /// </summary>
        public const string M7SQN = "M7SQN";

        /// <summary>
        /// M7FLDN.
        /// </summary>
        public const string M7FLDN = "M7FLDN";

        /// <summary>
        /// M7FPID.
        /// </summary>
        public const string M7FPID = "M7FPID";

        /// <summary>
        /// M7BVER.
        /// </summary>
        public const string M7BVER = "M7BVER";

        /// <summary>
        /// M7KOPT.
        /// </summary>
        public const string M7KOPT = "M7KOPT";

        /// <summary>
        /// M7SAD.
        /// </summary>
        public const string M7SAD = "M7SAD";

        /// <summary>
        /// M7LTOT.
        /// </summary>
        public const string M7LTOT = "M7LTOT";

        /// <summary>
        /// M7PAGE.
        /// </summary>
        public const string M7PAGE = "M7PAGE";

        /// <summary>
        /// M7LUS.
        /// </summary>
        public const string M7LUS = "M7LUS";

        /// <summary>
        /// M7FPD.
        /// </summary>
        public const string M7FPD = "M7FPD";

        /// <summary>
        /// M7UPMJ.
        /// </summary>
        public const string M7UPMJ = "M7UPMJ";

        /// <summary>
        /// M7JOBN.
        /// </summary>
        public const string M7JOBN = "M7JOBN";

        /// <summary>
        /// M7UPMT.
        /// </summary>
        public const string M7UPMT = "M7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F81A15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M7LDFR", "M7LDFR", JdeDataType.String, 20, true, true),
        new JdeField("M7PID", "M7PID", JdeDataType.String, 20, true, true),
        new JdeField("M7VERS", "M7VERS", JdeDataType.String, 20, true, true),
        new JdeField("M7SQN", "M7SQN", JdeDataType.Numeric, null, true, true),
        new JdeField("M7FLDN", "M7FLDN", JdeDataType.String, 12),
        new JdeField("M7FPID", "M7FPID", JdeDataType.String, 20),
        new JdeField("M7BVER", "M7BVER", JdeDataType.String, 20),
        new JdeField("M7KOPT", "M7KOPT", JdeDataType.String, 2),
        new JdeField("M7SAD", "M7SAD", JdeDataType.String, 2),
        new JdeField("M7LTOT", "M7LTOT", JdeDataType.Numeric),
        new JdeField("M7PAGE", "M7PAGE", JdeDataType.String, 2),
        new JdeField("M7LUS", "M7LUS", JdeDataType.String, 20),
        new JdeField("M7FPD", "M7FPD", JdeDataType.String, 20),
        new JdeField("M7UPMJ", "M7UPMJ", JdeDataType.Numeric),
        new JdeField("M7JOBN", "M7JOBN", JdeDataType.String, 20),
        new JdeField("M7UPMT", "M7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A15_0", "Primary Key on M7LDFR, M7PID, M7VERS, M7SQN", new[] { "M7LDFR", "M7PID", "M7VERS", "M7SQN" }, isUnique: true, isPrimaryKey: true)
    };
}
