using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34UI003 - .
/// </summary>
public class F34UI003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M8DL02.
        /// </summary>
        public const string M8DL02 = "M8DL02";

        /// <summary>
        /// M8EV01.
        /// </summary>
        public const string M8EV01 = "M8EV01";

        /// <summary>
        /// M8QT.
        /// </summary>
        public const string M8QT = "M8QT";

        /// <summary>
        /// M8TQ01.
        /// </summary>
        public const string M8TQ01 = "M8TQ01";

        /// <summary>
        /// M8TQ02.
        /// </summary>
        public const string M8TQ02 = "M8TQ02";

        /// <summary>
        /// M8TQ03.
        /// </summary>
        public const string M8TQ03 = "M8TQ03";

        /// <summary>
        /// M8TQ04.
        /// </summary>
        public const string M8TQ04 = "M8TQ04";

        /// <summary>
        /// M8TQ05.
        /// </summary>
        public const string M8TQ05 = "M8TQ05";

        /// <summary>
        /// M8TQ06.
        /// </summary>
        public const string M8TQ06 = "M8TQ06";

        /// <summary>
        /// M8TQ07.
        /// </summary>
        public const string M8TQ07 = "M8TQ07";

        /// <summary>
        /// M8TQ08.
        /// </summary>
        public const string M8TQ08 = "M8TQ08";

        /// <summary>
        /// M8TQ09.
        /// </summary>
        public const string M8TQ09 = "M8TQ09";

        /// <summary>
        /// M8TQ10.
        /// </summary>
        public const string M8TQ10 = "M8TQ10";

        /// <summary>
        /// M8TQ11.
        /// </summary>
        public const string M8TQ11 = "M8TQ11";

        /// <summary>
        /// M8TQ12.
        /// </summary>
        public const string M8TQ12 = "M8TQ12";

        /// <summary>
        /// M8TQ13.
        /// </summary>
        public const string M8TQ13 = "M8TQ13";

        /// <summary>
        /// M8TQ14.
        /// </summary>
        public const string M8TQ14 = "M8TQ14";

        /// <summary>
        /// M8TQ15.
        /// </summary>
        public const string M8TQ15 = "M8TQ15";

        /// <summary>
        /// M8TQ16.
        /// </summary>
        public const string M8TQ16 = "M8TQ16";

        /// <summary>
        /// M8TQ17.
        /// </summary>
        public const string M8TQ17 = "M8TQ17";

        /// <summary>
        /// M8TQ18.
        /// </summary>
        public const string M8TQ18 = "M8TQ18";

        /// <summary>
        /// M8TQ19.
        /// </summary>
        public const string M8TQ19 = "M8TQ19";

        /// <summary>
        /// M8TQ20.
        /// </summary>
        public const string M8TQ20 = "M8TQ20";

        /// <summary>
        /// M8TQ21.
        /// </summary>
        public const string M8TQ21 = "M8TQ21";

        /// <summary>
        /// M8TQ22.
        /// </summary>
        public const string M8TQ22 = "M8TQ22";

        /// <summary>
        /// M8TQ23.
        /// </summary>
        public const string M8TQ23 = "M8TQ23";

        /// <summary>
        /// M8TQ24.
        /// </summary>
        public const string M8TQ24 = "M8TQ24";

        /// <summary>
        /// M8TQ25.
        /// </summary>
        public const string M8TQ25 = "M8TQ25";

        /// <summary>
        /// M8TQ26.
        /// </summary>
        public const string M8TQ26 = "M8TQ26";

        /// <summary>
        /// M8TQ27.
        /// </summary>
        public const string M8TQ27 = "M8TQ27";

        /// <summary>
        /// M8TQ28.
        /// </summary>
        public const string M8TQ28 = "M8TQ28";

        /// <summary>
        /// M8TQ29.
        /// </summary>
        public const string M8TQ29 = "M8TQ29";

        /// <summary>
        /// M8TQ30.
        /// </summary>
        public const string M8TQ30 = "M8TQ30";

        /// <summary>
        /// M8TQ31.
        /// </summary>
        public const string M8TQ31 = "M8TQ31";

        /// <summary>
        /// M8TQ32.
        /// </summary>
        public const string M8TQ32 = "M8TQ32";

        /// <summary>
        /// M8TQ33.
        /// </summary>
        public const string M8TQ33 = "M8TQ33";

        /// <summary>
        /// M8TQ34.
        /// </summary>
        public const string M8TQ34 = "M8TQ34";

        /// <summary>
        /// M8TQ35.
        /// </summary>
        public const string M8TQ35 = "M8TQ35";

        /// <summary>
        /// M8TQ36.
        /// </summary>
        public const string M8TQ36 = "M8TQ36";

        /// <summary>
        /// M8TQ37.
        /// </summary>
        public const string M8TQ37 = "M8TQ37";

        /// <summary>
        /// M8TQ38.
        /// </summary>
        public const string M8TQ38 = "M8TQ38";

        /// <summary>
        /// M8TQ39.
        /// </summary>
        public const string M8TQ39 = "M8TQ39";

        /// <summary>
        /// M8TQ40.
        /// </summary>
        public const string M8TQ40 = "M8TQ40";

        /// <summary>
        /// M8TQ41.
        /// </summary>
        public const string M8TQ41 = "M8TQ41";

        /// <summary>
        /// M8TQ42.
        /// </summary>
        public const string M8TQ42 = "M8TQ42";

        /// <summary>
        /// M8TQ43.
        /// </summary>
        public const string M8TQ43 = "M8TQ43";

        /// <summary>
        /// M8TQ44.
        /// </summary>
        public const string M8TQ44 = "M8TQ44";

        /// <summary>
        /// M8TQ45.
        /// </summary>
        public const string M8TQ45 = "M8TQ45";

        /// <summary>
        /// M8TQ46.
        /// </summary>
        public const string M8TQ46 = "M8TQ46";

        /// <summary>
        /// M8TQ47.
        /// </summary>
        public const string M8TQ47 = "M8TQ47";

        /// <summary>
        /// M8TQ48.
        /// </summary>
        public const string M8TQ48 = "M8TQ48";

        /// <summary>
        /// M8TQ49.
        /// </summary>
        public const string M8TQ49 = "M8TQ49";

        /// <summary>
        /// M8TQ50.
        /// </summary>
        public const string M8TQ50 = "M8TQ50";

        /// <summary>
        /// M8TQ51.
        /// </summary>
        public const string M8TQ51 = "M8TQ51";

        /// <summary>
        /// M8TQ52.
        /// </summary>
        public const string M8TQ52 = "M8TQ52";

        /// <summary>
        /// M8TQ53.
        /// </summary>
        public const string M8TQ53 = "M8TQ53";

        /// <summary>
        /// M8TQ54.
        /// </summary>
        public const string M8TQ54 = "M8TQ54";

        /// <summary>
        /// M8TQ55.
        /// </summary>
        public const string M8TQ55 = "M8TQ55";

        /// <summary>
        /// M8TQ56.
        /// </summary>
        public const string M8TQ56 = "M8TQ56";

        /// <summary>
        /// M8CTID.
        /// </summary>
        public const string M8CTID = "M8CTID";

        /// <summary>
        /// M8PID.
        /// </summary>
        public const string M8PID = "M8PID";

        /// <summary>
        /// M8UPMJ.
        /// </summary>
        public const string M8UPMJ = "M8UPMJ";

        /// <summary>
        /// M8LNID.
        /// </summary>
        public const string M8LNID = "M8LNID";

        /// <summary>
        /// M8TDAY.
        /// </summary>
        public const string M8TDAY = "M8TDAY";

        /// <summary>
        /// M8JOBS.
        /// </summary>
        public const string M8JOBS = "M8JOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F34UI003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M8DL02", "M8DL02", JdeDataType.String, 60),
        new JdeField("M8EV01", "M8EV01", JdeDataType.String, 2, true, true),
        new JdeField("M8QT", "M8QT", JdeDataType.String, 4),
        new JdeField("M8TQ01", "M8TQ01", JdeDataType.String, 50),
        new JdeField("M8TQ02", "M8TQ02", JdeDataType.String, 50),
        new JdeField("M8TQ03", "M8TQ03", JdeDataType.String, 50),
        new JdeField("M8TQ04", "M8TQ04", JdeDataType.String, 50),
        new JdeField("M8TQ05", "M8TQ05", JdeDataType.String, 50),
        new JdeField("M8TQ06", "M8TQ06", JdeDataType.String, 50),
        new JdeField("M8TQ07", "M8TQ07", JdeDataType.String, 50),
        new JdeField("M8TQ08", "M8TQ08", JdeDataType.String, 50),
        new JdeField("M8TQ09", "M8TQ09", JdeDataType.String, 50),
        new JdeField("M8TQ10", "M8TQ10", JdeDataType.String, 50),
        new JdeField("M8TQ11", "M8TQ11", JdeDataType.String, 50),
        new JdeField("M8TQ12", "M8TQ12", JdeDataType.String, 50),
        new JdeField("M8TQ13", "M8TQ13", JdeDataType.String, 50),
        new JdeField("M8TQ14", "M8TQ14", JdeDataType.String, 50),
        new JdeField("M8TQ15", "M8TQ15", JdeDataType.String, 50),
        new JdeField("M8TQ16", "M8TQ16", JdeDataType.String, 50),
        new JdeField("M8TQ17", "M8TQ17", JdeDataType.String, 50),
        new JdeField("M8TQ18", "M8TQ18", JdeDataType.String, 50),
        new JdeField("M8TQ19", "M8TQ19", JdeDataType.String, 50),
        new JdeField("M8TQ20", "M8TQ20", JdeDataType.String, 50),
        new JdeField("M8TQ21", "M8TQ21", JdeDataType.String, 50),
        new JdeField("M8TQ22", "M8TQ22", JdeDataType.String, 50),
        new JdeField("M8TQ23", "M8TQ23", JdeDataType.String, 50),
        new JdeField("M8TQ24", "M8TQ24", JdeDataType.String, 50),
        new JdeField("M8TQ25", "M8TQ25", JdeDataType.String, 50),
        new JdeField("M8TQ26", "M8TQ26", JdeDataType.String, 50),
        new JdeField("M8TQ27", "M8TQ27", JdeDataType.String, 50),
        new JdeField("M8TQ28", "M8TQ28", JdeDataType.String, 50),
        new JdeField("M8TQ29", "M8TQ29", JdeDataType.String, 50),
        new JdeField("M8TQ30", "M8TQ30", JdeDataType.String, 50),
        new JdeField("M8TQ31", "M8TQ31", JdeDataType.String, 50),
        new JdeField("M8TQ32", "M8TQ32", JdeDataType.String, 50),
        new JdeField("M8TQ33", "M8TQ33", JdeDataType.String, 50),
        new JdeField("M8TQ34", "M8TQ34", JdeDataType.String, 50),
        new JdeField("M8TQ35", "M8TQ35", JdeDataType.String, 50),
        new JdeField("M8TQ36", "M8TQ36", JdeDataType.String, 50),
        new JdeField("M8TQ37", "M8TQ37", JdeDataType.String, 50),
        new JdeField("M8TQ38", "M8TQ38", JdeDataType.String, 50),
        new JdeField("M8TQ39", "M8TQ39", JdeDataType.String, 50),
        new JdeField("M8TQ40", "M8TQ40", JdeDataType.String, 50),
        new JdeField("M8TQ41", "M8TQ41", JdeDataType.String, 50),
        new JdeField("M8TQ42", "M8TQ42", JdeDataType.String, 50),
        new JdeField("M8TQ43", "M8TQ43", JdeDataType.String, 50),
        new JdeField("M8TQ44", "M8TQ44", JdeDataType.String, 50),
        new JdeField("M8TQ45", "M8TQ45", JdeDataType.String, 50),
        new JdeField("M8TQ46", "M8TQ46", JdeDataType.String, 50),
        new JdeField("M8TQ47", "M8TQ47", JdeDataType.String, 50),
        new JdeField("M8TQ48", "M8TQ48", JdeDataType.String, 50),
        new JdeField("M8TQ49", "M8TQ49", JdeDataType.String, 50),
        new JdeField("M8TQ50", "M8TQ50", JdeDataType.String, 50),
        new JdeField("M8TQ51", "M8TQ51", JdeDataType.String, 50),
        new JdeField("M8TQ52", "M8TQ52", JdeDataType.String, 50),
        new JdeField("M8TQ53", "M8TQ53", JdeDataType.String, 50),
        new JdeField("M8TQ54", "M8TQ54", JdeDataType.String, 50),
        new JdeField("M8TQ55", "M8TQ55", JdeDataType.String, 50),
        new JdeField("M8TQ56", "M8TQ56", JdeDataType.String, 50),
        new JdeField("M8CTID", "M8CTID", JdeDataType.String, 30, true, true),
        new JdeField("M8PID", "M8PID", JdeDataType.String, 20, true, true),
        new JdeField("M8UPMJ", "M8UPMJ", JdeDataType.Numeric),
        new JdeField("M8LNID", "M8LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("M8TDAY", "M8TDAY", JdeDataType.Numeric),
        new JdeField("M8JOBS", "M8JOBS", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34UI003_0", "Primary Key on M8JOBS, M8CTID, M8PID, M8LNID, M8EV01", new[] { "M8JOBS", "M8CTID", "M8PID", "M8LNID", "M8EV01" }, isUnique: true, isPrimaryKey: true)
    };
}
