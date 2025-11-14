using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08336B - .
/// </summary>
public class F08336B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// E2AN8.
        /// </summary>
        public const string E2AN8 = "E2AN8";

        /// <summary>
        /// E2PAN8.
        /// </summary>
        public const string E2PAN8 = "E2PAN8";

        /// <summary>
        /// E2PLAN.
        /// </summary>
        public const string E2PLAN = "E2PLAN";

        /// <summary>
        /// E2AOPT.
        /// </summary>
        public const string E2AOPT = "E2AOPT";

        /// <summary>
        /// E2EFT.
        /// </summary>
        public const string E2EFT = "E2EFT";

        /// <summary>
        /// E2EECD.
        /// </summary>
        public const string E2EECD = "E2EECD";

        /// <summary>
        /// E2EDTE.
        /// </summary>
        public const string E2EDTE = "E2EDTE";

        /// <summary>
        /// E2USER.
        /// </summary>
        public const string E2USER = "E2USER";

        /// <summary>
        /// E2PID.
        /// </summary>
        public const string E2PID = "E2PID";

        /// <summary>
        /// E2JOBN.
        /// </summary>
        public const string E2JOBN = "E2JOBN";

        /// <summary>
        /// E2UPMJ.
        /// </summary>
        public const string E2UPMJ = "E2UPMJ";

        /// <summary>
        /// E2UPMT.
        /// </summary>
        public const string E2UPMT = "E2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08336B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("E2AN8", "E2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("E2PAN8", "E2PAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("E2PLAN", "E2PLAN", JdeDataType.String, 16, true, true),
        new JdeField("E2AOPT", "E2AOPT", JdeDataType.String, 6, true, true),
        new JdeField("E2EFT", "E2EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("E2EECD", "E2EECD", JdeDataType.String, 6),
        new JdeField("E2EDTE", "E2EDTE", JdeDataType.Numeric),
        new JdeField("E2USER", "E2USER", JdeDataType.String, 20),
        new JdeField("E2PID", "E2PID", JdeDataType.String, 20),
        new JdeField("E2JOBN", "E2JOBN", JdeDataType.String, 20),
        new JdeField("E2UPMJ", "E2UPMJ", JdeDataType.Numeric),
        new JdeField("E2UPMT", "E2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08336B_0", "Primary Key on E2AN8, E2PAN8, E2PLAN, E2AOPT, E2EFT", new[] { "E2AN8", "E2PAN8", "E2PLAN", "E2AOPT", "E2EFT" }, isUnique: true, isPrimaryKey: true)
    };
}
