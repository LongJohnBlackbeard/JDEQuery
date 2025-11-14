using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T4032 - .
/// </summary>
public class F75T4032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2CO.
        /// </summary>
        public const string A2CO = "A2CO";

        /// <summary>
        /// A275TDSI.
        /// </summary>
        public const string A275TDSI = "A275TDSI";

        /// <summary>
        /// A275TYMD.
        /// </summary>
        public const string A275TYMD = "A275TYMD";

        /// <summary>
        /// A2PSQ.
        /// </summary>
        public const string A2PSQ = "A2PSQ";

        /// <summary>
        /// A275T0672.
        /// </summary>
        public const string A275T0672 = "A275T0672";

        /// <summary>
        /// A275T0673.
        /// </summary>
        public const string A275T0673 = "A275T0673";

        /// <summary>
        /// A275T0674.
        /// </summary>
        public const string A275T0674 = "A275T0674";

        /// <summary>
        /// A275T0696.
        /// </summary>
        public const string A275T0696 = "A275T0696";

        /// <summary>
        /// A275T0697.
        /// </summary>
        public const string A275T0697 = "A275T0697";

        /// <summary>
        /// A275T0702.
        /// </summary>
        public const string A275T0702 = "A275T0702";

        /// <summary>
        /// A275T0703.
        /// </summary>
        public const string A275T0703 = "A275T0703";

        /// <summary>
        /// A275T0704.
        /// </summary>
        public const string A275T0704 = "A275T0704";

        /// <summary>
        /// A275T0726.
        /// </summary>
        public const string A275T0726 = "A275T0726";

        /// <summary>
        /// A275T0727.
        /// </summary>
        public const string A275T0727 = "A275T0727";

        /// <summary>
        /// A275T0732.
        /// </summary>
        public const string A275T0732 = "A275T0732";

        /// <summary>
        /// A275T0733.
        /// </summary>
        public const string A275T0733 = "A275T0733";

        /// <summary>
        /// A275T0734.
        /// </summary>
        public const string A275T0734 = "A275T0734";

        /// <summary>
        /// A275T0742.
        /// </summary>
        public const string A275T0742 = "A275T0742";

        /// <summary>
        /// A275T0743.
        /// </summary>
        public const string A275T0743 = "A275T0743";

        /// <summary>
        /// A275T0744.
        /// </summary>
        public const string A275T0744 = "A275T0744";

        /// <summary>
        /// A275T0766.
        /// </summary>
        public const string A275T0766 = "A275T0766";

        /// <summary>
        /// A275T0767.
        /// </summary>
        public const string A275T0767 = "A275T0767";

        /// <summary>
        /// A275T067.
        /// </summary>
        public const string A275T067 = "A275T067";

        /// <summary>
        /// A275T069.
        /// </summary>
        public const string A275T069 = "A275T069";

        /// <summary>
        /// A275T070.
        /// </summary>
        public const string A275T070 = "A275T070";

        /// <summary>
        /// A275T072.
        /// </summary>
        public const string A275T072 = "A275T072";

        /// <summary>
        /// A275T073.
        /// </summary>
        public const string A275T073 = "A275T073";

        /// <summary>
        /// A275T074.
        /// </summary>
        public const string A275T074 = "A275T074";

        /// <summary>
        /// A275T076.
        /// </summary>
        public const string A275T076 = "A275T076";

        /// <summary>
        /// A2USER.
        /// </summary>
        public const string A2USER = "A2USER";

        /// <summary>
        /// A2PID.
        /// </summary>
        public const string A2PID = "A2PID";

        /// <summary>
        /// A2JOBN.
        /// </summary>
        public const string A2JOBN = "A2JOBN";

        /// <summary>
        /// A2UPMJ.
        /// </summary>
        public const string A2UPMJ = "A2UPMJ";

        /// <summary>
        /// A2TDAY.
        /// </summary>
        public const string A2TDAY = "A2TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T4032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2CO", "A2CO", JdeDataType.String, 10, true, true),
        new JdeField("A275TDSI", "A275TDSI", JdeDataType.String, 10, true, true),
        new JdeField("A275TYMD", "A275TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("A2PSQ", "A2PSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("A275T0672", "A275T0672", JdeDataType.Numeric),
        new JdeField("A275T0673", "A275T0673", JdeDataType.Numeric),
        new JdeField("A275T0674", "A275T0674", JdeDataType.Numeric),
        new JdeField("A275T0696", "A275T0696", JdeDataType.Numeric),
        new JdeField("A275T0697", "A275T0697", JdeDataType.Numeric),
        new JdeField("A275T0702", "A275T0702", JdeDataType.Numeric),
        new JdeField("A275T0703", "A275T0703", JdeDataType.Numeric),
        new JdeField("A275T0704", "A275T0704", JdeDataType.Numeric),
        new JdeField("A275T0726", "A275T0726", JdeDataType.Numeric),
        new JdeField("A275T0727", "A275T0727", JdeDataType.Numeric),
        new JdeField("A275T0732", "A275T0732", JdeDataType.Numeric),
        new JdeField("A275T0733", "A275T0733", JdeDataType.Numeric),
        new JdeField("A275T0734", "A275T0734", JdeDataType.Numeric),
        new JdeField("A275T0742", "A275T0742", JdeDataType.Numeric),
        new JdeField("A275T0743", "A275T0743", JdeDataType.Numeric),
        new JdeField("A275T0744", "A275T0744", JdeDataType.Numeric),
        new JdeField("A275T0766", "A275T0766", JdeDataType.Numeric),
        new JdeField("A275T0767", "A275T0767", JdeDataType.Numeric),
        new JdeField("A275T067", "A275T067", JdeDataType.Numeric),
        new JdeField("A275T069", "A275T069", JdeDataType.Numeric),
        new JdeField("A275T070", "A275T070", JdeDataType.Numeric),
        new JdeField("A275T072", "A275T072", JdeDataType.Numeric),
        new JdeField("A275T073", "A275T073", JdeDataType.Numeric),
        new JdeField("A275T074", "A275T074", JdeDataType.Numeric),
        new JdeField("A275T076", "A275T076", JdeDataType.Numeric),
        new JdeField("A2USER", "A2USER", JdeDataType.String, 20),
        new JdeField("A2PID", "A2PID", JdeDataType.String, 20),
        new JdeField("A2JOBN", "A2JOBN", JdeDataType.String, 20),
        new JdeField("A2UPMJ", "A2UPMJ", JdeDataType.Numeric),
        new JdeField("A2TDAY", "A2TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T4032_0", "Primary Key on A2CO, A275TDSI, A275TYMD, A2PSQ", new[] { "A2CO", "A275TDSI", "A275TYMD", "A2PSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
