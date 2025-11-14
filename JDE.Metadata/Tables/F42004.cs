using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42004 - .
/// </summary>
public class F42004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMAN8.
        /// </summary>
        public const string CMAN8 = "CMAN8";

        /// <summary>
        /// CMCCTY.
        /// </summary>
        public const string CMCCTY = "CMCCTY";

        /// <summary>
        /// CMCEFJ.
        /// </summary>
        public const string CMCEFJ = "CMCEFJ";

        /// <summary>
        /// CMCXPJ.
        /// </summary>
        public const string CMCXPJ = "CMCXPJ";

        /// <summary>
        /// CMPWRD.
        /// </summary>
        public const string CMPWRD = "CMPWRD";

        /// <summary>
        /// CMAC01.
        /// </summary>
        public const string CMAC01 = "CMAC01";

        /// <summary>
        /// CMAC04.
        /// </summary>
        public const string CMAC04 = "CMAC04";

        /// <summary>
        /// CMDCTO.
        /// </summary>
        public const string CMDCTO = "CMDCTO";

        /// <summary>
        /// CMFRTH.
        /// </summary>
        public const string CMFRTH = "CMFRTH";

        /// <summary>
        /// CMLFAC.
        /// </summary>
        public const string CMLFAC = "CMLFAC";

        /// <summary>
        /// CMAFXC.
        /// </summary>
        public const string CMAFXC = "CMAFXC";

        /// <summary>
        /// CMMGM.
        /// </summary>
        public const string CMMGM = "CMMGM";

        /// <summary>
        /// CMCPCT.
        /// </summary>
        public const string CMCPCT = "CMCPCT";

        /// <summary>
        /// CMENTJ.
        /// </summary>
        public const string CMENTJ = "CMENTJ";

        /// <summary>
        /// CMENTB.
        /// </summary>
        public const string CMENTB = "CMENTB";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMRPMB.
        /// </summary>
        public const string CMRPMB = "CMRPMB";

        /// <summary>
        /// CMFCA.
        /// </summary>
        public const string CMFCA = "CMFCA";

        /// <summary>
        /// CMAPUN.
        /// </summary>
        public const string CMAPUN = "CMAPUN";

        /// <summary>
        /// CMMCU.
        /// </summary>
        public const string CMMCU = "CMMCU";

        /// <summary>
        /// CMCMCR.
        /// </summary>
        public const string CMCMCR = "CMCMCR";

        /// <summary>
        /// CMCMLN.
        /// </summary>
        public const string CMCMLN = "CMCMLN";
    }

    /// <inheritdoc />
    public override string TableName => "F42004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMAN8", "CMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCCTY", "CMCCTY", JdeDataType.String, 2),
        new JdeField("CMCEFJ", "CMCEFJ", JdeDataType.Numeric),
        new JdeField("CMCXPJ", "CMCXPJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CMPWRD", "CMPWRD", JdeDataType.String, 20),
        new JdeField("CMAC01", "CMAC01", JdeDataType.String, 6),
        new JdeField("CMAC04", "CMAC04", JdeDataType.String, 6),
        new JdeField("CMDCTO", "CMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CMFRTH", "CMFRTH", JdeDataType.String, 6),
        new JdeField("CMLFAC", "CMLFAC", JdeDataType.Numeric),
        new JdeField("CMAFXC", "CMAFXC", JdeDataType.Numeric),
        new JdeField("CMMGM", "CMMGM", JdeDataType.Numeric),
        new JdeField("CMCPCT", "CMCPCT", JdeDataType.Numeric),
        new JdeField("CMENTJ", "CMENTJ", JdeDataType.Numeric),
        new JdeField("CMENTB", "CMENTB", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMRPMB", "CMRPMB", JdeDataType.String, 20),
        new JdeField("CMFCA", "CMFCA", JdeDataType.Numeric),
        new JdeField("CMAPUN", "CMAPUN", JdeDataType.Numeric),
        new JdeField("CMMCU", "CMMCU", JdeDataType.String, 24),
        new JdeField("CMCMCR", "CMCMCR", JdeDataType.String, 6, true, true),
        new JdeField("CMCMLN", "CMCMLN", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42004_0", "Primary Key on CMAN8, CMDCTO, CMCXPJ, CMCMLN, CMCMCR", new[] { "CMAN8", "CMDCTO", "CMCXPJ", "CMCMLN", "CMCMCR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42004_2", "Index on CMAN8, CMDCTO", new[] { "CMAN8", "CMDCTO" })
    };
}
