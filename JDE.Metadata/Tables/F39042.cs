using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39042 - .
/// </summary>
public class F39042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCCO.
        /// </summary>
        public const string SCCO = "SCCO";

        /// <summary>
        /// SCSVVM.
        /// </summary>
        public const string SCSVVM = "SCSVVM";

        /// <summary>
        /// SCDGJ.
        /// </summary>
        public const string SCDGJ = "SCDGJ";

        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCSVDT.
        /// </summary>
        public const string SCSVDT = "SCSVDT";

        /// <summary>
        /// SCSVFU.
        /// </summary>
        public const string SCSVFU = "SCSVFU";

        /// <summary>
        /// SCSVF1.
        /// </summary>
        public const string SCSVF1 = "SCSVF1";

        /// <summary>
        /// SCSVF2.
        /// </summary>
        public const string SCSVF2 = "SCSVF2";

        /// <summary>
        /// SCSVF3.
        /// </summary>
        public const string SCSVF3 = "SCSVF3";

        /// <summary>
        /// SCSVF4.
        /// </summary>
        public const string SCSVF4 = "SCSVF4";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCTDAY.
        /// </summary>
        public const string SCTDAY = "SCTDAY";

        /// <summary>
        /// SCSVPM.
        /// </summary>
        public const string SCSVPM = "SCSVPM";
    }

    /// <inheritdoc />
    public override string TableName => "F39042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCCO", "SCCO", JdeDataType.String, 10, true, true),
        new JdeField("SCSVVM", "SCSVVM", JdeDataType.String, 4),
        new JdeField("SCDGJ", "SCDGJ", JdeDataType.Numeric),
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24),
        new JdeField("SCSVDT", "SCSVDT", JdeDataType.Numeric),
        new JdeField("SCSVFU", "SCSVFU", JdeDataType.String, 4),
        new JdeField("SCSVF1", "SCSVF1", JdeDataType.String, 2),
        new JdeField("SCSVF2", "SCSVF2", JdeDataType.String, 2),
        new JdeField("SCSVF3", "SCSVF3", JdeDataType.String, 2),
        new JdeField("SCSVF4", "SCSVF4", JdeDataType.String, 2),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric),
        new JdeField("SCSVPM", "SCSVPM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39042_0", "Primary Key on SCCO", new[] { "SCCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F39042_1", "Unique Index on SCCO, SCSVVM", new[] { "SCCO", "SCSVVM" }, isUnique: true)
    };
}
