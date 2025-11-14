using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1541B - .
/// </summary>
public class F1541B : JdeTable
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
        /// N8STNR.
        /// </summary>
        public const string N8STNR = "N8STNR";

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
        /// N8ULI2.
        /// </summary>
        public const string N8ULI2 = "N8ULI2";

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
        /// N8RM21.
        /// </summary>
        public const string N8RM21 = "N8RM21";

        /// <summary>
        /// N8RM22.
        /// </summary>
        public const string N8RM22 = "N8RM22";

        /// <summary>
        /// N8RM23.
        /// </summary>
        public const string N8RM23 = "N8RM23";

        /// <summary>
        /// N8RM24.
        /// </summary>
        public const string N8RM24 = "N8RM24";

        /// <summary>
        /// N8RM25.
        /// </summary>
        public const string N8RM25 = "N8RM25";

        /// <summary>
        /// N8FLOR.
        /// </summary>
        public const string N8FLOR = "N8FLOR";

        /// <summary>
        /// N8URCD.
        /// </summary>
        public const string N8URCD = "N8URCD";

        /// <summary>
        /// N8URDT.
        /// </summary>
        public const string N8URDT = "N8URDT";

        /// <summary>
        /// N8URAT.
        /// </summary>
        public const string N8URAT = "N8URAT";

        /// <summary>
        /// N8URRF.
        /// </summary>
        public const string N8URRF = "N8URRF";

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

        /// <summary>
        /// N8TORG.
        /// </summary>
        public const string N8TORG = "N8TORG";

        /// <summary>
        /// N8ENTJ.
        /// </summary>
        public const string N8ENTJ = "N8ENTJ";

        /// <summary>
        /// N8CRCD.
        /// </summary>
        public const string N8CRCD = "N8CRCD";

        /// <summary>
        /// N8CRR.
        /// </summary>
        public const string N8CRR = "N8CRR";

        /// <summary>
        /// N8CRRM.
        /// </summary>
        public const string N8CRRM = "N8CRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1541B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N8DOCO", "N8DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N8MCU", "N8MCU", JdeDataType.String, 24, true, true),
        new JdeField("N8UNIT", "N8UNIT", JdeDataType.String, 16, true, true),
        new JdeField("N8DBAN", "N8DBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("N8STNR", "N8STNR", JdeDataType.String, 20, true, true),
        new JdeField("N8PRDC", "N8PRDC", JdeDataType.String, 8, true, true),
        new JdeField("N8CTRY", "N8CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("N8YR", "N8YR", JdeDataType.Numeric, null, true, true),
        new JdeField("N8AN8", "N8AN8", JdeDataType.Numeric),
        new JdeField("N8CO", "N8CO", JdeDataType.String, 10),
        new JdeField("N8MCUS", "N8MCUS", JdeDataType.String, 24),
        new JdeField("N8ULI", "N8ULI", JdeDataType.String, 16),
        new JdeField("N8ULI2", "N8ULI2", JdeDataType.String, 16),
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
        new JdeField("N8RM21", "N8RM21", JdeDataType.String, 8),
        new JdeField("N8RM22", "N8RM22", JdeDataType.String, 8),
        new JdeField("N8RM23", "N8RM23", JdeDataType.String, 8),
        new JdeField("N8RM24", "N8RM24", JdeDataType.String, 8),
        new JdeField("N8RM25", "N8RM25", JdeDataType.String, 8),
        new JdeField("N8FLOR", "N8FLOR", JdeDataType.String, 8),
        new JdeField("N8URCD", "N8URCD", JdeDataType.String, 4),
        new JdeField("N8URDT", "N8URDT", JdeDataType.Numeric),
        new JdeField("N8URAT", "N8URAT", JdeDataType.Numeric),
        new JdeField("N8URRF", "N8URRF", JdeDataType.String, 30),
        new JdeField("N8USER", "N8USER", JdeDataType.String, 20),
        new JdeField("N8UPMJ", "N8UPMJ", JdeDataType.Numeric),
        new JdeField("N8PID", "N8PID", JdeDataType.String, 20),
        new JdeField("N8JOBN", "N8JOBN", JdeDataType.String, 20),
        new JdeField("N8UPMT", "N8UPMT", JdeDataType.Numeric),
        new JdeField("N8TORG", "N8TORG", JdeDataType.String, 20),
        new JdeField("N8ENTJ", "N8ENTJ", JdeDataType.Numeric),
        new JdeField("N8CRCD", "N8CRCD", JdeDataType.String, 6),
        new JdeField("N8CRR", "N8CRR", JdeDataType.Numeric),
        new JdeField("N8CRRM", "N8CRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1541B_0", "Primary Key on N8DOCO, N8MCU, N8UNIT, N8DBAN, N8STNR, N8PRDC, N8CTRY, N8YR", new[] { "N8DOCO", "N8MCU", "N8UNIT", "N8DBAN", "N8STNR", "N8PRDC", "N8CTRY", "N8YR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1541B_3", "Index on N8DOCO, N8CTRY, N8YR, N8MCU, N8UNIT, N8DBAN, N8PRDC, N8STNR, N8CO", new[] { "N8DOCO", "N8CTRY", "N8YR", "N8MCU", "N8UNIT", "N8DBAN", "N8PRDC", "N8STNR", "N8CO" }),
        new JdeIndex("F1541B_4", "Index on N8CO, N8MCU, N8DOCO, N8UNIT, N8PRDC", new[] { "N8CO", "N8MCU", "N8DOCO", "N8UNIT", "N8PRDC" }),
        new JdeIndex("F1541B_6", "Index on N8PRDC, N8MCU, N8ULI", new[] { "N8PRDC", "N8MCU", "N8ULI" })
    };
}
