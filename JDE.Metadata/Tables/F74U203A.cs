using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U203A - .
/// </summary>
public class F74U203A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P474UBLPTN.
        /// </summary>
        public const string P474UBLPTN = "P474UBLPTN";

        /// <summary>
        /// P474UDSC1.
        /// </summary>
        public const string P474UDSC1 = "P474UDSC1";

        /// <summary>
        /// P474UDCT.
        /// </summary>
        public const string P474UDCT = "P474UDCT";

        /// <summary>
        /// P474UFPA.
        /// </summary>
        public const string P474UFPA = "P474UFPA";

        /// <summary>
        /// P474UWKLY.
        /// </summary>
        public const string P474UWKLY = "P474UWKLY";

        /// <summary>
        /// P474UDTPN.
        /// </summary>
        public const string P474UDTPN = "P474UDTPN";

        /// <summary>
        /// P474UBLBK1.
        /// </summary>
        public const string P474UBLBK1 = "P474UBLBK1";

        /// <summary>
        /// P474UBLBK2.
        /// </summary>
        public const string P474UBLBK2 = "P474UBLBK2";

        /// <summary>
        /// P474UBLBK3.
        /// </summary>
        public const string P474UBLBK3 = "P474UBLBK3";

        /// <summary>
        /// P474UBLBK4.
        /// </summary>
        public const string P474UBLBK4 = "P474UBLBK4";

        /// <summary>
        /// P474UBLBK5.
        /// </summary>
        public const string P474UBLBK5 = "P474UBLBK5";

        /// <summary>
        /// P474UBLBK6.
        /// </summary>
        public const string P474UBLBK6 = "P474UBLBK6";

        /// <summary>
        /// P474UBLBK7.
        /// </summary>
        public const string P474UBLBK7 = "P474UBLBK7";

        /// <summary>
        /// P474UBLBK8.
        /// </summary>
        public const string P474UBLBK8 = "P474UBLBK8";

        /// <summary>
        /// P474UBLBK9.
        /// </summary>
        public const string P474UBLBK9 = "P474UBLBK9";

        /// <summary>
        /// P474UBLBKA.
        /// </summary>
        public const string P474UBLBKA = "P474UBLBKA";

        /// <summary>
        /// P474UBLBKB.
        /// </summary>
        public const string P474UBLBKB = "P474UBLBKB";

        /// <summary>
        /// P474UBLBKC.
        /// </summary>
        public const string P474UBLBKC = "P474UBLBKC";

        /// <summary>
        /// P474UNOBP.
        /// </summary>
        public const string P474UNOBP = "P474UNOBP";

        /// <summary>
        /// P4EV02.
        /// </summary>
        public const string P4EV02 = "P4EV02";

        /// <summary>
        /// P4URCD.
        /// </summary>
        public const string P4URCD = "P4URCD";

        /// <summary>
        /// P4URDT.
        /// </summary>
        public const string P4URDT = "P4URDT";

        /// <summary>
        /// P4URAB.
        /// </summary>
        public const string P4URAB = "P4URAB";

        /// <summary>
        /// P4URRF.
        /// </summary>
        public const string P4URRF = "P4URRF";

        /// <summary>
        /// P4USER.
        /// </summary>
        public const string P4USER = "P4USER";

        /// <summary>
        /// P4PID.
        /// </summary>
        public const string P4PID = "P4PID";

        /// <summary>
        /// P4UPMJ.
        /// </summary>
        public const string P4UPMJ = "P4UPMJ";

        /// <summary>
        /// P4UPMT.
        /// </summary>
        public const string P4UPMT = "P4UPMT";

        /// <summary>
        /// P4JOBN.
        /// </summary>
        public const string P4JOBN = "P4JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U203A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P474UBLPTN", "P474UBLPTN", JdeDataType.String, 10, true, true),
        new JdeField("P474UDSC1", "P474UDSC1", JdeDataType.String, 60),
        new JdeField("P474UDCT", "P474UDCT", JdeDataType.String, 4),
        new JdeField("P474UFPA", "P474UFPA", JdeDataType.String, 2),
        new JdeField("P474UWKLY", "P474UWKLY", JdeDataType.String, 2),
        new JdeField("P474UDTPN", "P474UDTPN", JdeDataType.String, 2),
        new JdeField("P474UBLBK1", "P474UBLBK1", JdeDataType.String, 20),
        new JdeField("P474UBLBK2", "P474UBLBK2", JdeDataType.String, 20),
        new JdeField("P474UBLBK3", "P474UBLBK3", JdeDataType.String, 20),
        new JdeField("P474UBLBK4", "P474UBLBK4", JdeDataType.String, 20),
        new JdeField("P474UBLBK5", "P474UBLBK5", JdeDataType.String, 20),
        new JdeField("P474UBLBK6", "P474UBLBK6", JdeDataType.String, 20),
        new JdeField("P474UBLBK7", "P474UBLBK7", JdeDataType.String, 20),
        new JdeField("P474UBLBK8", "P474UBLBK8", JdeDataType.String, 20),
        new JdeField("P474UBLBK9", "P474UBLBK9", JdeDataType.String, 20),
        new JdeField("P474UBLBKA", "P474UBLBKA", JdeDataType.String, 20),
        new JdeField("P474UBLBKB", "P474UBLBKB", JdeDataType.String, 20),
        new JdeField("P474UBLBKC", "P474UBLBKC", JdeDataType.String, 20),
        new JdeField("P474UNOBP", "P474UNOBP", JdeDataType.Numeric),
        new JdeField("P4EV02", "P4EV02", JdeDataType.String, 2),
        new JdeField("P4URCD", "P4URCD", JdeDataType.String, 4),
        new JdeField("P4URDT", "P4URDT", JdeDataType.Numeric),
        new JdeField("P4URAB", "P4URAB", JdeDataType.Numeric),
        new JdeField("P4URRF", "P4URRF", JdeDataType.String, 30),
        new JdeField("P4USER", "P4USER", JdeDataType.String, 20),
        new JdeField("P4PID", "P4PID", JdeDataType.String, 20),
        new JdeField("P4UPMJ", "P4UPMJ", JdeDataType.Numeric),
        new JdeField("P4UPMT", "P4UPMT", JdeDataType.Numeric),
        new JdeField("P4JOBN", "P4JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U203A_0", "Primary Key on P474UBLPTN", new[] { "P474UBLPTN" }, isUnique: true, isPrimaryKey: true)
    };
}
