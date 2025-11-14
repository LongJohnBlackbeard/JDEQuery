using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08338 - .
/// </summary>
public class F08338 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// E7AN8.
        /// </summary>
        public const string E7AN8 = "E7AN8";

        /// <summary>
        /// E7PLAN.
        /// </summary>
        public const string E7PLAN = "E7PLAN";

        /// <summary>
        /// E7AOPT.
        /// </summary>
        public const string E7AOPT = "E7AOPT";

        /// <summary>
        /// E7EFT.
        /// </summary>
        public const string E7EFT = "E7EFT";

        /// <summary>
        /// E7EFTE.
        /// </summary>
        public const string E7EFTE = "E7EFTE";

        /// <summary>
        /// E7PCP#.
        /// </summary>
        public const string E7PCP_ = "E7PCP#";

        /// <summary>
        /// E7GEN1.
        /// </summary>
        public const string E7GEN1 = "E7GEN1";

        /// <summary>
        /// E7GEN2.
        /// </summary>
        public const string E7GEN2 = "E7GEN2";

        /// <summary>
        /// E7GEN3.
        /// </summary>
        public const string E7GEN3 = "E7GEN3";

        /// <summary>
        /// E7EECD.
        /// </summary>
        public const string E7EECD = "E7EECD";

        /// <summary>
        /// E7EDTE.
        /// </summary>
        public const string E7EDTE = "E7EDTE";

        /// <summary>
        /// E7USER.
        /// </summary>
        public const string E7USER = "E7USER";

        /// <summary>
        /// E7PID.
        /// </summary>
        public const string E7PID = "E7PID";

        /// <summary>
        /// E7JOBN.
        /// </summary>
        public const string E7JOBN = "E7JOBN";

        /// <summary>
        /// E7UPMJ.
        /// </summary>
        public const string E7UPMJ = "E7UPMJ";

        /// <summary>
        /// E7UPMT.
        /// </summary>
        public const string E7UPMT = "E7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08338";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("E7AN8", "E7AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("E7PLAN", "E7PLAN", JdeDataType.String, 16, true, true),
        new JdeField("E7AOPT", "E7AOPT", JdeDataType.String, 6, true, true),
        new JdeField("E7EFT", "E7EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("E7EFTE", "E7EFTE", JdeDataType.Numeric),
        new JdeField("E7PCP#", "E7PCP#", JdeDataType.String, 40),
        new JdeField("E7GEN1", "E7GEN1", JdeDataType.String, 20),
        new JdeField("E7GEN2", "E7GEN2", JdeDataType.String, 20),
        new JdeField("E7GEN3", "E7GEN3", JdeDataType.String, 20),
        new JdeField("E7EECD", "E7EECD", JdeDataType.String, 6),
        new JdeField("E7EDTE", "E7EDTE", JdeDataType.Numeric),
        new JdeField("E7USER", "E7USER", JdeDataType.String, 20),
        new JdeField("E7PID", "E7PID", JdeDataType.String, 20),
        new JdeField("E7JOBN", "E7JOBN", JdeDataType.String, 20),
        new JdeField("E7UPMJ", "E7UPMJ", JdeDataType.Numeric),
        new JdeField("E7UPMT", "E7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08338_0", "Primary Key on E7AN8, E7PLAN, E7AOPT, E7EFT", new[] { "E7AN8", "E7PLAN", "E7AOPT", "E7EFT" }, isUnique: true, isPrimaryKey: true)
    };
}
