using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0008 - .
/// </summary>
public class F75Z0008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z8UN.
        /// </summary>
        public const string Z8UN = "Z8UN";

        /// <summary>
        /// Z8MCU.
        /// </summary>
        public const string Z8MCU = "Z8MCU";

        /// <summary>
        /// Z8EFTB.
        /// </summary>
        public const string Z8EFTB = "Z8EFTB";

        /// <summary>
        /// Z8EFTE.
        /// </summary>
        public const string Z8EFTE = "Z8EFTE";

        /// <summary>
        /// Z8JBCD.
        /// </summary>
        public const string Z8JBCD = "Z8JBCD";

        /// <summary>
        /// Z8JBST.
        /// </summary>
        public const string Z8JBST = "Z8JBST";

        /// <summary>
        /// Z8SHFT.
        /// </summary>
        public const string Z8SHFT = "Z8SHFT";

        /// <summary>
        /// Z8SPCRTE.
        /// </summary>
        public const string Z8SPCRTE = "Z8SPCRTE";

        /// <summary>
        /// Z8RELRTE.
        /// </summary>
        public const string Z8RELRTE = "Z8RELRTE";

        /// <summary>
        /// Z8RATE6.
        /// </summary>
        public const string Z8RATE6 = "Z8RATE6";

        /// <summary>
        /// Z8RATE7.
        /// </summary>
        public const string Z8RATE7 = "Z8RATE7";

        /// <summary>
        /// Z8RATE8.
        /// </summary>
        public const string Z8RATE8 = "Z8RATE8";

        /// <summary>
        /// Z8USER.
        /// </summary>
        public const string Z8USER = "Z8USER";

        /// <summary>
        /// Z8PID.
        /// </summary>
        public const string Z8PID = "Z8PID";

        /// <summary>
        /// Z8UPMJ.
        /// </summary>
        public const string Z8UPMJ = "Z8UPMJ";

        /// <summary>
        /// Z8UPMT.
        /// </summary>
        public const string Z8UPMT = "Z8UPMT";

        /// <summary>
        /// Z8JOBN.
        /// </summary>
        public const string Z8JOBN = "Z8JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z8UN", "Z8UN", JdeDataType.String, 12, true, true),
        new JdeField("Z8MCU", "Z8MCU", JdeDataType.String, 24, true, true),
        new JdeField("Z8EFTB", "Z8EFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("Z8EFTE", "Z8EFTE", JdeDataType.Numeric),
        new JdeField("Z8JBCD", "Z8JBCD", JdeDataType.String, 12, true, true),
        new JdeField("Z8JBST", "Z8JBST", JdeDataType.String, 8, true, true),
        new JdeField("Z8SHFT", "Z8SHFT", JdeDataType.String, 2, true, true),
        new JdeField("Z8SPCRTE", "Z8SPCRTE", JdeDataType.Numeric),
        new JdeField("Z8RELRTE", "Z8RELRTE", JdeDataType.Numeric),
        new JdeField("Z8RATE6", "Z8RATE6", JdeDataType.Numeric),
        new JdeField("Z8RATE7", "Z8RATE7", JdeDataType.Numeric),
        new JdeField("Z8RATE8", "Z8RATE8", JdeDataType.Numeric),
        new JdeField("Z8USER", "Z8USER", JdeDataType.String, 20),
        new JdeField("Z8PID", "Z8PID", JdeDataType.String, 20),
        new JdeField("Z8UPMJ", "Z8UPMJ", JdeDataType.Numeric),
        new JdeField("Z8UPMT", "Z8UPMT", JdeDataType.Numeric),
        new JdeField("Z8JOBN", "Z8JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0008_0", "Primary Key on Z8UN, Z8MCU, Z8SHFT, Z8EFTB, Z8JBCD, Z8JBST", new[] { "Z8UN", "Z8MCU", "Z8SHFT", "Z8EFTB", "Z8JBCD", "Z8JBST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75Z0008_2", "Index on Z8UN, Z8MCU, Z8SHFT, Z8JBCD", new[] { "Z8UN", "Z8MCU", "Z8SHFT", "Z8JBCD" })
    };
}
