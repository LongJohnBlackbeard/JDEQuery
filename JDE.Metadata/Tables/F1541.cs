using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1541 - .
/// </summary>
public class F1541 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N8DOCO.
        /// </summary>
        public const string N8DOCO = "N8DOCO";

        /// <summary>
        /// N8MCU.
        /// </summary>
        public const string N8MCU = "N8MCU";

        /// <summary>
        /// N8UNIT.
        /// </summary>
        public const string N8UNIT = "N8UNIT";

        /// <summary>
        /// N8DBAN.
        /// </summary>
        public const string N8DBAN = "N8DBAN";

        /// <summary>
        /// N8PRDC.
        /// </summary>
        public const string N8PRDC = "N8PRDC";

        /// <summary>
        /// N8CTRY.
        /// </summary>
        public const string N8CTRY = "N8CTRY";

        /// <summary>
        /// N8YR.
        /// </summary>
        public const string N8YR = "N8YR";

        /// <summary>
        /// N8AN8.
        /// </summary>
        public const string N8AN8 = "N8AN8";

        /// <summary>
        /// N8CO.
        /// </summary>
        public const string N8CO = "N8CO";

        /// <summary>
        /// N8MCUS.
        /// </summary>
        public const string N8MCUS = "N8MCUS";

        /// <summary>
        /// N8ULI.
        /// </summary>
        public const string N8ULI = "N8ULI";

        /// <summary>
        /// N8SH01.
        /// </summary>
        public const string N8SH01 = "N8SH01";

        /// <summary>
        /// N8SH02.
        /// </summary>
        public const string N8SH02 = "N8SH02";

        /// <summary>
        /// N8SH03.
        /// </summary>
        public const string N8SH03 = "N8SH03";

        /// <summary>
        /// N8SH04.
        /// </summary>
        public const string N8SH04 = "N8SH04";

        /// <summary>
        /// N8SH05.
        /// </summary>
        public const string N8SH05 = "N8SH05";

        /// <summary>
        /// N8SH06.
        /// </summary>
        public const string N8SH06 = "N8SH06";

        /// <summary>
        /// N8SH07.
        /// </summary>
        public const string N8SH07 = "N8SH07";

        /// <summary>
        /// N8SH08.
        /// </summary>
        public const string N8SH08 = "N8SH08";

        /// <summary>
        /// N8SH09.
        /// </summary>
        public const string N8SH09 = "N8SH09";

        /// <summary>
        /// N8SH10.
        /// </summary>
        public const string N8SH10 = "N8SH10";

        /// <summary>
        /// N8SH11.
        /// </summary>
        public const string N8SH11 = "N8SH11";

        /// <summary>
        /// N8SH12.
        /// </summary>
        public const string N8SH12 = "N8SH12";

        /// <summary>
        /// N8RM11.
        /// </summary>
        public const string N8RM11 = "N8RM11";

        /// <summary>
        /// N8RM12.
        /// </summary>
        public const string N8RM12 = "N8RM12";

        /// <summary>
        /// N8RM13.
        /// </summary>
        public const string N8RM13 = "N8RM13";

        /// <summary>
        /// N8RM14.
        /// </summary>
        public const string N8RM14 = "N8RM14";

        /// <summary>
        /// N8RM15.
        /// </summary>
        public const string N8RM15 = "N8RM15";

        /// <summary>
        /// N8FLOR.
        /// </summary>
        public const string N8FLOR = "N8FLOR";

        /// <summary>
        /// N8USER.
        /// </summary>
        public const string N8USER = "N8USER";

        /// <summary>
        /// N8UPMJ.
        /// </summary>
        public const string N8UPMJ = "N8UPMJ";

        /// <summary>
        /// N8PID.
        /// </summary>
        public const string N8PID = "N8PID";

        /// <summary>
        /// N8JOBN.
        /// </summary>
        public const string N8JOBN = "N8JOBN";

        /// <summary>
        /// N8UPMT.
        /// </summary>
        public const string N8UPMT = "N8UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1541";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N8DOCO", "N8DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N8MCU", "N8MCU", JdeDataType.String, 24, true, true),
        new JdeField("N8UNIT", "N8UNIT", JdeDataType.String, 16, true, true),
        new JdeField("N8DBAN", "N8DBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("N8PRDC", "N8PRDC", JdeDataType.String, 8, true, true),
        new JdeField("N8CTRY", "N8CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("N8YR", "N8YR", JdeDataType.Numeric, null, true, true),
        new JdeField("N8AN8", "N8AN8", JdeDataType.Numeric),
        new JdeField("N8CO", "N8CO", JdeDataType.String, 10),
        new JdeField("N8MCUS", "N8MCUS", JdeDataType.String, 24),
        new JdeField("N8ULI", "N8ULI", JdeDataType.String, 16),
        new JdeField("N8SH01", "N8SH01", JdeDataType.Numeric),
        new JdeField("N8SH02", "N8SH02", JdeDataType.Numeric),
        new JdeField("N8SH03", "N8SH03", JdeDataType.Numeric),
        new JdeField("N8SH04", "N8SH04", JdeDataType.Numeric),
        new JdeField("N8SH05", "N8SH05", JdeDataType.Numeric),
        new JdeField("N8SH06", "N8SH06", JdeDataType.Numeric),
        new JdeField("N8SH07", "N8SH07", JdeDataType.Numeric),
        new JdeField("N8SH08", "N8SH08", JdeDataType.Numeric),
        new JdeField("N8SH09", "N8SH09", JdeDataType.Numeric),
        new JdeField("N8SH10", "N8SH10", JdeDataType.Numeric),
        new JdeField("N8SH11", "N8SH11", JdeDataType.Numeric),
        new JdeField("N8SH12", "N8SH12", JdeDataType.Numeric),
        new JdeField("N8RM11", "N8RM11", JdeDataType.String, 8),
        new JdeField("N8RM12", "N8RM12", JdeDataType.String, 8),
        new JdeField("N8RM13", "N8RM13", JdeDataType.String, 8),
        new JdeField("N8RM14", "N8RM14", JdeDataType.String, 8),
        new JdeField("N8RM15", "N8RM15", JdeDataType.String, 8),
        new JdeField("N8FLOR", "N8FLOR", JdeDataType.String, 8),
        new JdeField("N8USER", "N8USER", JdeDataType.String, 20),
        new JdeField("N8UPMJ", "N8UPMJ", JdeDataType.Numeric),
        new JdeField("N8PID", "N8PID", JdeDataType.String, 20),
        new JdeField("N8JOBN", "N8JOBN", JdeDataType.String, 20),
        new JdeField("N8UPMT", "N8UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1541_0", "Primary Key on N8DOCO, N8MCU, N8UNIT, N8DBAN, N8PRDC, N8CTRY, N8YR", new[] { "N8DOCO", "N8MCU", "N8UNIT", "N8DBAN", "N8PRDC", "N8CTRY", "N8YR" }, isUnique: true, isPrimaryKey: true)
    };
}
