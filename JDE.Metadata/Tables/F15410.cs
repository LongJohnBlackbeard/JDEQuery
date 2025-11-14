using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15410 - .
/// </summary>
public class F15410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N9DOCO.
        /// </summary>
        public const string N9DOCO = "N9DOCO";

        /// <summary>
        /// N9MCU.
        /// </summary>
        public const string N9MCU = "N9MCU";

        /// <summary>
        /// N9UNIT.
        /// </summary>
        public const string N9UNIT = "N9UNIT";

        /// <summary>
        /// N9DBAN.
        /// </summary>
        public const string N9DBAN = "N9DBAN";

        /// <summary>
        /// N9STNR.
        /// </summary>
        public const string N9STNR = "N9STNR";

        /// <summary>
        /// N9PRDC.
        /// </summary>
        public const string N9PRDC = "N9PRDC";

        /// <summary>
        /// N9CTRY.
        /// </summary>
        public const string N9CTRY = "N9CTRY";

        /// <summary>
        /// N9YR.
        /// </summary>
        public const string N9YR = "N9YR";

        /// <summary>
        /// N9BPN.
        /// </summary>
        public const string N9BPN = "N9BPN";

        /// <summary>
        /// N9AN8.
        /// </summary>
        public const string N9AN8 = "N9AN8";

        /// <summary>
        /// N9CO.
        /// </summary>
        public const string N9CO = "N9CO";

        /// <summary>
        /// N9MCUS.
        /// </summary>
        public const string N9MCUS = "N9MCUS";

        /// <summary>
        /// N9ULI.
        /// </summary>
        public const string N9ULI = "N9ULI";

        /// <summary>
        /// N9ULI2.
        /// </summary>
        public const string N9ULI2 = "N9ULI2";

        /// <summary>
        /// N9SH01.
        /// </summary>
        public const string N9SH01 = "N9SH01";

        /// <summary>
        /// N9RM11.
        /// </summary>
        public const string N9RM11 = "N9RM11";

        /// <summary>
        /// N9RM12.
        /// </summary>
        public const string N9RM12 = "N9RM12";

        /// <summary>
        /// N9RM13.
        /// </summary>
        public const string N9RM13 = "N9RM13";

        /// <summary>
        /// N9RM14.
        /// </summary>
        public const string N9RM14 = "N9RM14";

        /// <summary>
        /// N9RM15.
        /// </summary>
        public const string N9RM15 = "N9RM15";

        /// <summary>
        /// N9RM21.
        /// </summary>
        public const string N9RM21 = "N9RM21";

        /// <summary>
        /// N9RM22.
        /// </summary>
        public const string N9RM22 = "N9RM22";

        /// <summary>
        /// N9RM23.
        /// </summary>
        public const string N9RM23 = "N9RM23";

        /// <summary>
        /// N9RM24.
        /// </summary>
        public const string N9RM24 = "N9RM24";

        /// <summary>
        /// N9RM25.
        /// </summary>
        public const string N9RM25 = "N9RM25";

        /// <summary>
        /// N9FLOR.
        /// </summary>
        public const string N9FLOR = "N9FLOR";

        /// <summary>
        /// N9URDT.
        /// </summary>
        public const string N9URDT = "N9URDT";

        /// <summary>
        /// N9URCD.
        /// </summary>
        public const string N9URCD = "N9URCD";

        /// <summary>
        /// N9URAT.
        /// </summary>
        public const string N9URAT = "N9URAT";

        /// <summary>
        /// N9URRF.
        /// </summary>
        public const string N9URRF = "N9URRF";

        /// <summary>
        /// N9USER.
        /// </summary>
        public const string N9USER = "N9USER";

        /// <summary>
        /// N9UPMJ.
        /// </summary>
        public const string N9UPMJ = "N9UPMJ";

        /// <summary>
        /// N9PID.
        /// </summary>
        public const string N9PID = "N9PID";

        /// <summary>
        /// N9JOBN.
        /// </summary>
        public const string N9JOBN = "N9JOBN";

        /// <summary>
        /// N9UPMT.
        /// </summary>
        public const string N9UPMT = "N9UPMT";

        /// <summary>
        /// N9TORG.
        /// </summary>
        public const string N9TORG = "N9TORG";

        /// <summary>
        /// N9ENTJ.
        /// </summary>
        public const string N9ENTJ = "N9ENTJ";

        /// <summary>
        /// N9CRCD.
        /// </summary>
        public const string N9CRCD = "N9CRCD";

        /// <summary>
        /// N9CRR.
        /// </summary>
        public const string N9CRR = "N9CRR";

        /// <summary>
        /// N9CRRM.
        /// </summary>
        public const string N9CRRM = "N9CRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F15410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N9DOCO", "N9DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N9MCU", "N9MCU", JdeDataType.String, 24, true, true),
        new JdeField("N9UNIT", "N9UNIT", JdeDataType.String, 16, true, true),
        new JdeField("N9DBAN", "N9DBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("N9STNR", "N9STNR", JdeDataType.String, 20, true, true),
        new JdeField("N9PRDC", "N9PRDC", JdeDataType.String, 8, true, true),
        new JdeField("N9CTRY", "N9CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("N9YR", "N9YR", JdeDataType.Numeric, null, true, true),
        new JdeField("N9BPN", "N9BPN", JdeDataType.Numeric, null, true, true),
        new JdeField("N9AN8", "N9AN8", JdeDataType.Numeric),
        new JdeField("N9CO", "N9CO", JdeDataType.String, 10),
        new JdeField("N9MCUS", "N9MCUS", JdeDataType.String, 24),
        new JdeField("N9ULI", "N9ULI", JdeDataType.String, 16),
        new JdeField("N9ULI2", "N9ULI2", JdeDataType.String, 16),
        new JdeField("N9SH01", "N9SH01", JdeDataType.Numeric),
        new JdeField("N9RM11", "N9RM11", JdeDataType.String, 8),
        new JdeField("N9RM12", "N9RM12", JdeDataType.String, 8),
        new JdeField("N9RM13", "N9RM13", JdeDataType.String, 8),
        new JdeField("N9RM14", "N9RM14", JdeDataType.String, 8),
        new JdeField("N9RM15", "N9RM15", JdeDataType.String, 8),
        new JdeField("N9RM21", "N9RM21", JdeDataType.String, 8),
        new JdeField("N9RM22", "N9RM22", JdeDataType.String, 8),
        new JdeField("N9RM23", "N9RM23", JdeDataType.String, 8),
        new JdeField("N9RM24", "N9RM24", JdeDataType.String, 8),
        new JdeField("N9RM25", "N9RM25", JdeDataType.String, 8),
        new JdeField("N9FLOR", "N9FLOR", JdeDataType.String, 8),
        new JdeField("N9URDT", "N9URDT", JdeDataType.Numeric),
        new JdeField("N9URCD", "N9URCD", JdeDataType.String, 4),
        new JdeField("N9URAT", "N9URAT", JdeDataType.Numeric),
        new JdeField("N9URRF", "N9URRF", JdeDataType.String, 30),
        new JdeField("N9USER", "N9USER", JdeDataType.String, 20),
        new JdeField("N9UPMJ", "N9UPMJ", JdeDataType.Numeric),
        new JdeField("N9PID", "N9PID", JdeDataType.String, 20),
        new JdeField("N9JOBN", "N9JOBN", JdeDataType.String, 20),
        new JdeField("N9UPMT", "N9UPMT", JdeDataType.Numeric),
        new JdeField("N9TORG", "N9TORG", JdeDataType.String, 20),
        new JdeField("N9ENTJ", "N9ENTJ", JdeDataType.Numeric),
        new JdeField("N9CRCD", "N9CRCD", JdeDataType.String, 6),
        new JdeField("N9CRR", "N9CRR", JdeDataType.Numeric),
        new JdeField("N9CRRM", "N9CRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15410_0", "Primary Key on N9DOCO, N9MCU, N9UNIT, N9DBAN, N9STNR, N9PRDC, N9CTRY, N9YR, N9BPN", new[] { "N9DOCO", "N9MCU", "N9UNIT", "N9DBAN", "N9STNR", "N9PRDC", "N9CTRY", "N9YR", "N9BPN" }, isUnique: true, isPrimaryKey: true)
    };
}
