using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A120 - .
/// </summary>
public class F34A120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0TRT.
        /// </summary>
        public const string N0TRT = "N0TRT";

        /// <summary>
        /// N0KIT.
        /// </summary>
        public const string N0KIT = "N0KIT";

        /// <summary>
        /// N0MMCU.
        /// </summary>
        public const string N0MMCU = "N0MMCU";

        /// <summary>
        /// N0LINE.
        /// </summary>
        public const string N0LINE = "N0LINE";

        /// <summary>
        /// N0OPSQ.
        /// </summary>
        public const string N0OPSQ = "N0OPSQ";

        /// <summary>
        /// N0EFFF.
        /// </summary>
        public const string N0EFFF = "N0EFFF";

        /// <summary>
        /// N0BQTY.
        /// </summary>
        public const string N0BQTY = "N0BQTY";

        /// <summary>
        /// N0OPSC.
        /// </summary>
        public const string N0OPSC = "N0OPSC";

        /// <summary>
        /// N0MCU.
        /// </summary>
        public const string N0MCU = "N0MCU";

        /// <summary>
        /// N0RESCD.
        /// </summary>
        public const string N0RESCD = "N0RESCD";

        /// <summary>
        /// N0QSCAL.
        /// </summary>
        public const string N0QSCAL = "N0QSCAL";

        /// <summary>
        /// N0APSDUR.
        /// </summary>
        public const string N0APSDUR = "N0APSDUR";

        /// <summary>
        /// N0APSFACT.
        /// </summary>
        public const string N0APSFACT = "N0APSFACT";

        /// <summary>
        /// N0APSREST.
        /// </summary>
        public const string N0APSREST = "N0APSREST";

        /// <summary>
        /// N0CAPREQ.
        /// </summary>
        public const string N0CAPREQ = "N0CAPREQ";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0UPMJ.
        /// </summary>
        public const string N0UPMJ = "N0UPMJ";

        /// <summary>
        /// N0TDAY.
        /// </summary>
        public const string N0TDAY = "N0TDAY";

        /// <summary>
        /// N0DURR.
        /// </summary>
        public const string N0DURR = "N0DURR";

        /// <summary>
        /// N0TUOM.
        /// </summary>
        public const string N0TUOM = "N0TUOM";

        /// <summary>
        /// N0TUOM1.
        /// </summary>
        public const string N0TUOM1 = "N0TUOM1";

        /// <summary>
        /// N0FTPF.
        /// </summary>
        public const string N0FTPF = "N0FTPF";

        /// <summary>
        /// N0DL01.
        /// </summary>
        public const string N0DL01 = "N0DL01";

        /// <summary>
        /// N0DSC1.
        /// </summary>
        public const string N0DSC1 = "N0DSC1";
    }

    /// <inheritdoc />
    public override string TableName => "F34A120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0TRT", "N0TRT", JdeDataType.String, 6, true, true),
        new JdeField("N0KIT", "N0KIT", JdeDataType.Numeric, null, true, true),
        new JdeField("N0MMCU", "N0MMCU", JdeDataType.String, 24, true, true),
        new JdeField("N0LINE", "N0LINE", JdeDataType.String, 24, true, true),
        new JdeField("N0OPSQ", "N0OPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("N0EFFF", "N0EFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("N0BQTY", "N0BQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("N0OPSC", "N0OPSC", JdeDataType.String, 4, true, true),
        new JdeField("N0MCU", "N0MCU", JdeDataType.String, 24, true, true),
        new JdeField("N0RESCD", "N0RESCD", JdeDataType.String, 24, true, true),
        new JdeField("N0QSCAL", "N0QSCAL", JdeDataType.String, 20),
        new JdeField("N0APSDUR", "N0APSDUR", JdeDataType.Numeric),
        new JdeField("N0APSFACT", "N0APSFACT", JdeDataType.Numeric),
        new JdeField("N0APSREST", "N0APSREST", JdeDataType.String, 2),
        new JdeField("N0CAPREQ", "N0CAPREQ", JdeDataType.Numeric),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0UPMJ", "N0UPMJ", JdeDataType.Numeric),
        new JdeField("N0TDAY", "N0TDAY", JdeDataType.Numeric),
        new JdeField("N0DURR", "N0DURR", JdeDataType.String, 2),
        new JdeField("N0TUOM", "N0TUOM", JdeDataType.String, 2),
        new JdeField("N0TUOM1", "N0TUOM1", JdeDataType.String, 2),
        new JdeField("N0FTPF", "N0FTPF", JdeDataType.Numeric),
        new JdeField("N0DL01", "N0DL01", JdeDataType.String, 60),
        new JdeField("N0DSC1", "N0DSC1", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A120_0", "Primary Key on N0TRT, N0KIT, N0MMCU, N0LINE, N0OPSQ, N0EFFF, N0BQTY, N0OPSC, N0MCU, N0RESCD", new[] { "N0TRT", "N0KIT", "N0MMCU", "N0LINE", "N0OPSQ", "N0EFFF", "N0BQTY", "N0OPSC", "N0MCU", "N0RESCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A120_2", "Index on N0TRT, N0KIT, N0MMCU, N0LINE, N0OPSQ, N0BQTY, N0OPSC, N0MCU, N0RESCD", new[] { "N0TRT", "N0KIT", "N0MMCU", "N0LINE", "N0OPSQ", "N0BQTY", "N0OPSC", "N0MCU", "N0RESCD" })
    };
}
