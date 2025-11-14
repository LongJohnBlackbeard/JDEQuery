using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06933 - .
/// </summary>
public class F06933 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J_1UN.
        /// </summary>
        public const string J_1UN = "J_1UN";

        /// <summary>
        /// J_1MCU.
        /// </summary>
        public const string J_1MCU = "J_1MCU";

        /// <summary>
        /// J_1EFTB.
        /// </summary>
        public const string J_1EFTB = "J_1EFTB";

        /// <summary>
        /// J_1EFTE.
        /// </summary>
        public const string J_1EFTE = "J_1EFTE";

        /// <summary>
        /// J_1JBCD.
        /// </summary>
        public const string J_1JBCD = "J_1JBCD";

        /// <summary>
        /// J_1JBS1.
        /// </summary>
        public const string J_1JBS1 = "J_1JBS1";

        /// <summary>
        /// J_1JBS2.
        /// </summary>
        public const string J_1JBS2 = "J_1JBS2";

        /// <summary>
        /// J_1UNTL.
        /// </summary>
        public const string J_1UNTL = "J_1UNTL";

        /// <summary>
        /// J_1UNTU.
        /// </summary>
        public const string J_1UNTU = "J_1UNTU";

        /// <summary>
        /// J_1MTHC.
        /// </summary>
        public const string J_1MTHC = "J_1MTHC";

        /// <summary>
        /// J_1NJCD.
        /// </summary>
        public const string J_1NJCD = "J_1NJCD";

        /// <summary>
        /// J_1NJST.
        /// </summary>
        public const string J_1NJST = "J_1NJST";

        /// <summary>
        /// J_1BDT.
        /// </summary>
        public const string J_1BDT = "J_1BDT";

        /// <summary>
        /// J_1TBEX.
        /// </summary>
        public const string J_1TBEX = "J_1TBEX";

        /// <summary>
        /// J_1CCAC.
        /// </summary>
        public const string J_1CCAC = "J_1CCAC";

        /// <summary>
        /// J_1CCMF.
        /// </summary>
        public const string J_1CCMF = "J_1CCMF";

        /// <summary>
        /// J_1CCCF.
        /// </summary>
        public const string J_1CCCF = "J_1CCCF";

        /// <summary>
        /// J_1PID.
        /// </summary>
        public const string J_1PID = "J_1PID";

        /// <summary>
        /// J_1USER.
        /// </summary>
        public const string J_1USER = "J_1USER";

        /// <summary>
        /// J_1UPMJ.
        /// </summary>
        public const string J_1UPMJ = "J_1UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06933";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J_1UN", "J_1UN", JdeDataType.String, 12, true, true),
        new JdeField("J_1MCU", "J_1MCU", JdeDataType.String, 24, true, true),
        new JdeField("J_1EFTB", "J_1EFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1EFTE", "J_1EFTE", JdeDataType.Numeric),
        new JdeField("J_1JBCD", "J_1JBCD", JdeDataType.String, 12, true, true),
        new JdeField("J_1JBS1", "J_1JBS1", JdeDataType.String, 8, true, true),
        new JdeField("J_1JBS2", "J_1JBS2", JdeDataType.String, 8),
        new JdeField("J_1UNTL", "J_1UNTL", JdeDataType.Numeric),
        new JdeField("J_1UNTU", "J_1UNTU", JdeDataType.Numeric),
        new JdeField("J_1MTHC", "J_1MTHC", JdeDataType.String, 2),
        new JdeField("J_1NJCD", "J_1NJCD", JdeDataType.String, 12),
        new JdeField("J_1NJST", "J_1NJST", JdeDataType.String, 8),
        new JdeField("J_1BDT", "J_1BDT", JdeDataType.String, 8),
        new JdeField("J_1TBEX", "J_1TBEX", JdeDataType.String, 6),
        new JdeField("J_1CCAC", "J_1CCAC", JdeDataType.String, 2),
        new JdeField("J_1CCMF", "J_1CCMF", JdeDataType.String, 2),
        new JdeField("J_1CCCF", "J_1CCCF", JdeDataType.String, 2),
        new JdeField("J_1PID", "J_1PID", JdeDataType.String, 20),
        new JdeField("J_1USER", "J_1USER", JdeDataType.String, 20),
        new JdeField("J_1UPMJ", "J_1UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06933_0", "Primary Key on J_1UN, J_1MCU, J_1EFTB, J_1JBCD, J_1JBS1", new[] { "J_1UN", "J_1MCU", "J_1EFTB", "J_1JBCD", "J_1JBS1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06933_2", "Index on J_1UN, J_1MCU, J_1EFTE, J_1JBCD, J_1JBS2", new[] { "J_1UN", "J_1MCU", "J_1EFTE", "J_1JBCD", "J_1JBS2" })
    };
}
