using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3290 - .
/// </summary>
public class F3290 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C3KIT.
        /// </summary>
        public const string C3KIT = "C3KIT";

        /// <summary>
        /// C3MCU.
        /// </summary>
        public const string C3MCU = "C3MCU";

        /// <summary>
        /// C3DSPI.
        /// </summary>
        public const string C3DSPI = "C3DSPI";

        /// <summary>
        /// C3TXTS.
        /// </summary>
        public const string C3TXTS = "C3TXTS";

        /// <summary>
        /// C3CIDN.
        /// </summary>
        public const string C3CIDN = "C3CIDN";

        /// <summary>
        /// C3CMCU.
        /// </summary>
        public const string C3CMCU = "C3CMCU";

        /// <summary>
        /// C3LNTY.
        /// </summary>
        public const string C3LNTY = "C3LNTY";

        /// <summary>
        /// C3PCFC.
        /// </summary>
        public const string C3PCFC = "C3PCFC";

        /// <summary>
        /// C3URCD.
        /// </summary>
        public const string C3URCD = "C3URCD";

        /// <summary>
        /// C3URDT.
        /// </summary>
        public const string C3URDT = "C3URDT";

        /// <summary>
        /// C3URAT.
        /// </summary>
        public const string C3URAT = "C3URAT";

        /// <summary>
        /// C3URAB.
        /// </summary>
        public const string C3URAB = "C3URAB";

        /// <summary>
        /// C3URRF.
        /// </summary>
        public const string C3URRF = "C3URRF";

        /// <summary>
        /// C3USER.
        /// </summary>
        public const string C3USER = "C3USER";

        /// <summary>
        /// C3PID.
        /// </summary>
        public const string C3PID = "C3PID";

        /// <summary>
        /// C3JOBN.
        /// </summary>
        public const string C3JOBN = "C3JOBN";

        /// <summary>
        /// C3UPMJ.
        /// </summary>
        public const string C3UPMJ = "C3UPMJ";

        /// <summary>
        /// C3TDAY.
        /// </summary>
        public const string C3TDAY = "C3TDAY";

        /// <summary>
        /// C3SOBD.
        /// </summary>
        public const string C3SOBD = "C3SOBD";

        /// <summary>
        /// C3POBD.
        /// </summary>
        public const string C3POBD = "C3POBD";

        /// <summary>
        /// C3WOBD.
        /// </summary>
        public const string C3WOBD = "C3WOBD";

        /// <summary>
        /// C3DYN.
        /// </summary>
        public const string C3DYN = "C3DYN";

        /// <summary>
        /// C3UIDD.
        /// </summary>
        public const string C3UIDD = "C3UIDD";

        /// <summary>
        /// C3DDTEXT.
        /// </summary>
        public const string C3DDTEXT = "C3DDTEXT";
    }

    /// <inheritdoc />
    public override string TableName => "F3290";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C3KIT", "C3KIT", JdeDataType.Numeric, null, true, true),
        new JdeField("C3MCU", "C3MCU", JdeDataType.String, 24, true, true),
        new JdeField("C3DSPI", "C3DSPI", JdeDataType.String, 2),
        new JdeField("C3TXTS", "C3TXTS", JdeDataType.String, 2),
        new JdeField("C3CIDN", "C3CIDN", JdeDataType.String, 2),
        new JdeField("C3CMCU", "C3CMCU", JdeDataType.String, 24),
        new JdeField("C3LNTY", "C3LNTY", JdeDataType.String, 4),
        new JdeField("C3PCFC", "C3PCFC", JdeDataType.String, 2),
        new JdeField("C3URCD", "C3URCD", JdeDataType.String, 4),
        new JdeField("C3URDT", "C3URDT", JdeDataType.Numeric),
        new JdeField("C3URAT", "C3URAT", JdeDataType.Numeric),
        new JdeField("C3URAB", "C3URAB", JdeDataType.Numeric),
        new JdeField("C3URRF", "C3URRF", JdeDataType.String, 30),
        new JdeField("C3USER", "C3USER", JdeDataType.String, 20),
        new JdeField("C3PID", "C3PID", JdeDataType.String, 20),
        new JdeField("C3JOBN", "C3JOBN", JdeDataType.String, 20),
        new JdeField("C3UPMJ", "C3UPMJ", JdeDataType.Numeric),
        new JdeField("C3TDAY", "C3TDAY", JdeDataType.Numeric),
        new JdeField("C3SOBD", "C3SOBD", JdeDataType.String, 2),
        new JdeField("C3POBD", "C3POBD", JdeDataType.String, 2),
        new JdeField("C3WOBD", "C3WOBD", JdeDataType.String, 2),
        new JdeField("C3DYN", "C3DYN", JdeDataType.String, 2),
        new JdeField("C3UIDD", "C3UIDD", JdeDataType.String, 2),
        new JdeField("C3DDTEXT", "C3DDTEXT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3290_0", "Primary Key on C3KIT, C3MCU", new[] { "C3KIT", "C3MCU" }, isUnique: true, isPrimaryKey: true)
    };
}
