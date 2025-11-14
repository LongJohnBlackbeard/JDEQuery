using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A13 - .
/// </summary>
public class F81A13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M5LDFR.
        /// </summary>
        public const string M5LDFR = "M5LDFR";

        /// <summary>
        /// M5PID.
        /// </summary>
        public const string M5PID = "M5PID";

        /// <summary>
        /// M5VERS.
        /// </summary>
        public const string M5VERS = "M5VERS";

        /// <summary>
        /// M5SQN.
        /// </summary>
        public const string M5SQN = "M5SQN";

        /// <summary>
        /// M5FLDN.
        /// </summary>
        public const string M5FLDN = "M5FLDN";

        /// <summary>
        /// M5FPID.
        /// </summary>
        public const string M5FPID = "M5FPID";

        /// <summary>
        /// M5BVER.
        /// </summary>
        public const string M5BVER = "M5BVER";

        /// <summary>
        /// M5AO.
        /// </summary>
        public const string M5AO = "M5AO";

        /// <summary>
        /// M5SVL.
        /// </summary>
        public const string M5SVL = "M5SVL";

        /// <summary>
        /// M5VALR.
        /// </summary>
        public const string M5VALR = "M5VALR";

        /// <summary>
        /// M5KOPT.
        /// </summary>
        public const string M5KOPT = "M5KOPT";

        /// <summary>
        /// M5AALL.
        /// </summary>
        public const string M5AALL = "M5AALL";

        /// <summary>
        /// M5LUS.
        /// </summary>
        public const string M5LUS = "M5LUS";

        /// <summary>
        /// M5FPD.
        /// </summary>
        public const string M5FPD = "M5FPD";

        /// <summary>
        /// M5UPMJ.
        /// </summary>
        public const string M5UPMJ = "M5UPMJ";

        /// <summary>
        /// M5JOBN.
        /// </summary>
        public const string M5JOBN = "M5JOBN";

        /// <summary>
        /// M5UPMT.
        /// </summary>
        public const string M5UPMT = "M5UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F81A13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M5LDFR", "M5LDFR", JdeDataType.String, 20, true, true),
        new JdeField("M5PID", "M5PID", JdeDataType.String, 20, true, true),
        new JdeField("M5VERS", "M5VERS", JdeDataType.String, 20, true, true),
        new JdeField("M5SQN", "M5SQN", JdeDataType.Numeric, null, true, true),
        new JdeField("M5FLDN", "M5FLDN", JdeDataType.String, 12),
        new JdeField("M5FPID", "M5FPID", JdeDataType.String, 20),
        new JdeField("M5BVER", "M5BVER", JdeDataType.String, 20),
        new JdeField("M5AO", "M5AO", JdeDataType.String, 2),
        new JdeField("M5SVL", "M5SVL", JdeDataType.String, 50),
        new JdeField("M5VALR", "M5VALR", JdeDataType.String, 4),
        new JdeField("M5KOPT", "M5KOPT", JdeDataType.String, 2),
        new JdeField("M5AALL", "M5AALL", JdeDataType.String, 2),
        new JdeField("M5LUS", "M5LUS", JdeDataType.String, 20),
        new JdeField("M5FPD", "M5FPD", JdeDataType.String, 20),
        new JdeField("M5UPMJ", "M5UPMJ", JdeDataType.Numeric),
        new JdeField("M5JOBN", "M5JOBN", JdeDataType.String, 20),
        new JdeField("M5UPMT", "M5UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A13_0", "Primary Key on M5LDFR, M5PID, M5VERS, M5SQN", new[] { "M5LDFR", "M5PID", "M5VERS", "M5SQN" }, isUnique: true, isPrimaryKey: true)
    };
}
