using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U02BT - .
/// </summary>
public class F74U02BT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P6DOCO.
        /// </summary>
        public const string P6DOCO = "P6DOCO";

        /// <summary>
        /// P6LNID.
        /// </summary>
        public const string P6LNID = "P6LNID";

        /// <summary>
        /// P674UGENT.
        /// </summary>
        public const string P674UGENT = "P674UGENT";

        /// <summary>
        /// P674URENA.
        /// </summary>
        public const string P674URENA = "P674URENA";

        /// <summary>
        /// P674UBLPTN.
        /// </summary>
        public const string P674UBLPTN = "P674UBLPTN";

        /// <summary>
        /// P674UPYMTH.
        /// </summary>
        public const string P674UPYMTH = "P674UPYMTH";

        /// <summary>
        /// P674UOBR.
        /// </summary>
        public const string P674UOBR = "P674UOBR";

        /// <summary>
        /// P6BCI.
        /// </summary>
        public const string P6BCI = "P6BCI";

        /// <summary>
        /// P674UFSTAG.
        /// </summary>
        public const string P674UFSTAG = "P674UFSTAG";

        /// <summary>
        /// P674ULSTAG.
        /// </summary>
        public const string P674ULSTAG = "P674ULSTAG";

        /// <summary>
        /// P674UREMAG.
        /// </summary>
        public const string P674UREMAG = "P674UREMAG";

        /// <summary>
        /// P674UREMC.
        /// </summary>
        public const string P674UREMC = "P674UREMC";

        /// <summary>
        /// P674UCLPL.
        /// </summary>
        public const string P674UCLPL = "P674UCLPL";

        /// <summary>
        /// P674ULPPD.
        /// </summary>
        public const string P674ULPPD = "P674ULPPD";

        /// <summary>
        /// P674UCLPA.
        /// </summary>
        public const string P674UCLPA = "P674UCLPA";

        /// <summary>
        /// P674UCLWA.
        /// </summary>
        public const string P674UCLWA = "P674UCLWA";

        /// <summary>
        /// P674UFY.
        /// </summary>
        public const string P674UFY = "P674UFY";

        /// <summary>
        /// P6CTRY.
        /// </summary>
        public const string P6CTRY = "P6CTRY";

        /// <summary>
        /// P674ULPD.
        /// </summary>
        public const string P674ULPD = "P674ULPD";

        /// <summary>
        /// P6URCD.
        /// </summary>
        public const string P6URCD = "P6URCD";

        /// <summary>
        /// P6URDT.
        /// </summary>
        public const string P6URDT = "P6URDT";

        /// <summary>
        /// P6URAT.
        /// </summary>
        public const string P6URAT = "P6URAT";

        /// <summary>
        /// P6URAB.
        /// </summary>
        public const string P6URAB = "P6URAB";

        /// <summary>
        /// P6URRF.
        /// </summary>
        public const string P6URRF = "P6URRF";

        /// <summary>
        /// P6USER.
        /// </summary>
        public const string P6USER = "P6USER";

        /// <summary>
        /// P6PID.
        /// </summary>
        public const string P6PID = "P6PID";

        /// <summary>
        /// P6UPMJ.
        /// </summary>
        public const string P6UPMJ = "P6UPMJ";

        /// <summary>
        /// P6UPMT.
        /// </summary>
        public const string P6UPMT = "P6UPMT";

        /// <summary>
        /// P6JOBN.
        /// </summary>
        public const string P6JOBN = "P6JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U02BT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P6DOCO", "P6DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P6LNID", "P6LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P674UGENT", "P674UGENT", JdeDataType.String, 2),
        new JdeField("P674URENA", "P674URENA", JdeDataType.Numeric),
        new JdeField("P674UBLPTN", "P674UBLPTN", JdeDataType.String, 10),
        new JdeField("P674UPYMTH", "P674UPYMTH", JdeDataType.String, 6),
        new JdeField("P674UOBR", "P674UOBR", JdeDataType.Numeric),
        new JdeField("P6BCI", "P6BCI", JdeDataType.Numeric),
        new JdeField("P674UFSTAG", "P674UFSTAG", JdeDataType.Numeric),
        new JdeField("P674ULSTAG", "P674ULSTAG", JdeDataType.Numeric),
        new JdeField("P674UREMAG", "P674UREMAG", JdeDataType.Numeric),
        new JdeField("P674UREMC", "P674UREMC", JdeDataType.Numeric),
        new JdeField("P674UCLPL", "P674UCLPL", JdeDataType.Numeric),
        new JdeField("P674ULPPD", "P674ULPPD", JdeDataType.Numeric),
        new JdeField("P674UCLPA", "P674UCLPA", JdeDataType.Numeric),
        new JdeField("P674UCLWA", "P674UCLWA", JdeDataType.Numeric),
        new JdeField("P674UFY", "P674UFY", JdeDataType.Numeric),
        new JdeField("P6CTRY", "P6CTRY", JdeDataType.Numeric),
        new JdeField("P674ULPD", "P674ULPD", JdeDataType.Numeric),
        new JdeField("P6URCD", "P6URCD", JdeDataType.String, 4),
        new JdeField("P6URDT", "P6URDT", JdeDataType.Numeric),
        new JdeField("P6URAT", "P6URAT", JdeDataType.Numeric),
        new JdeField("P6URAB", "P6URAB", JdeDataType.Numeric),
        new JdeField("P6URRF", "P6URRF", JdeDataType.String, 30),
        new JdeField("P6USER", "P6USER", JdeDataType.String, 20),
        new JdeField("P6PID", "P6PID", JdeDataType.String, 20),
        new JdeField("P6UPMJ", "P6UPMJ", JdeDataType.Numeric),
        new JdeField("P6UPMT", "P6UPMT", JdeDataType.Numeric),
        new JdeField("P6JOBN", "P6JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U02BT_0", "Primary Key on P6DOCO, P6LNID", new[] { "P6DOCO", "P6LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U02BT_2", "Index on P674UBLPTN", new[] { "P674UBLPTN" }),
        new JdeIndex("F74U02BT_4", "Index on P6BCI", new[] { "P6BCI" })
    };
}
