using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U203B - .
/// </summary>
public class F74U203B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P574UBLPTN.
        /// </summary>
        public const string P574UBLPTN = "P574UBLPTN";

        /// <summary>
        /// P574UDSC1.
        /// </summary>
        public const string P574UDSC1 = "P574UDSC1";

        /// <summary>
        /// P574UBLPT.
        /// </summary>
        public const string P574UBLPT = "P574UBLPT";

        /// <summary>
        /// P574UOFFDY.
        /// </summary>
        public const string P574UOFFDY = "P574UOFFDY";

        /// <summary>
        /// P574UWKD.
        /// </summary>
        public const string P574UWKD = "P574UWKD";

        /// <summary>
        /// P5EV01.
        /// </summary>
        public const string P5EV01 = "P5EV01";

        /// <summary>
        /// P5URCD.
        /// </summary>
        public const string P5URCD = "P5URCD";

        /// <summary>
        /// P5URDT.
        /// </summary>
        public const string P5URDT = "P5URDT";

        /// <summary>
        /// P5URAT.
        /// </summary>
        public const string P5URAT = "P5URAT";

        /// <summary>
        /// P5URAB.
        /// </summary>
        public const string P5URAB = "P5URAB";

        /// <summary>
        /// P5URRF.
        /// </summary>
        public const string P5URRF = "P5URRF";

        /// <summary>
        /// P5USER.
        /// </summary>
        public const string P5USER = "P5USER";

        /// <summary>
        /// P5PID.
        /// </summary>
        public const string P5PID = "P5PID";

        /// <summary>
        /// P5UPMJ.
        /// </summary>
        public const string P5UPMJ = "P5UPMJ";

        /// <summary>
        /// P5UPMT.
        /// </summary>
        public const string P5UPMT = "P5UPMT";

        /// <summary>
        /// P5JOBN.
        /// </summary>
        public const string P5JOBN = "P5JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U203B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P574UBLPTN", "P574UBLPTN", JdeDataType.String, 10, true, true),
        new JdeField("P574UDSC1", "P574UDSC1", JdeDataType.String, 60),
        new JdeField("P574UBLPT", "P574UBLPT", JdeDataType.String, 2),
        new JdeField("P574UOFFDY", "P574UOFFDY", JdeDataType.Numeric),
        new JdeField("P574UWKD", "P574UWKD", JdeDataType.String, 2),
        new JdeField("P5EV01", "P5EV01", JdeDataType.String, 2),
        new JdeField("P5URCD", "P5URCD", JdeDataType.String, 4),
        new JdeField("P5URDT", "P5URDT", JdeDataType.Numeric),
        new JdeField("P5URAT", "P5URAT", JdeDataType.Numeric),
        new JdeField("P5URAB", "P5URAB", JdeDataType.Numeric),
        new JdeField("P5URRF", "P5URRF", JdeDataType.String, 30),
        new JdeField("P5USER", "P5USER", JdeDataType.String, 20),
        new JdeField("P5PID", "P5PID", JdeDataType.String, 20),
        new JdeField("P5UPMJ", "P5UPMJ", JdeDataType.Numeric),
        new JdeField("P5UPMT", "P5UPMT", JdeDataType.Numeric),
        new JdeField("P5JOBN", "P5JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U203B_0", "Primary Key on P574UBLPTN", new[] { "P574UBLPTN" }, isUnique: true, isPrimaryKey: true)
    };
}
