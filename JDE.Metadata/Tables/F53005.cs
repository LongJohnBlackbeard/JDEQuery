using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F53005 - .
/// </summary>
public class F53005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D1MCU.
        /// </summary>
        public const string D1MCU = "D1MCU";

        /// <summary>
        /// D1DTAI.
        /// </summary>
        public const string D1DTAI = "D1DTAI";

        /// <summary>
        /// D1KY.
        /// </summary>
        public const string D1KY = "D1KY";

        /// <summary>
        /// D1DL01.
        /// </summary>
        public const string D1DL01 = "D1DL01";

        /// <summary>
        /// D1DL02.
        /// </summary>
        public const string D1DL02 = "D1DL02";

        /// <summary>
        /// D1SPHD.
        /// </summary>
        public const string D1SPHD = "D1SPHD";

        /// <summary>
        /// D1UDCO.
        /// </summary>
        public const string D1UDCO = "D1UDCO";

        /// <summary>
        /// D1HRDC.
        /// </summary>
        public const string D1HRDC = "D1HRDC";

        /// <summary>
        /// D1USER.
        /// </summary>
        public const string D1USER = "D1USER";

        /// <summary>
        /// D1PID.
        /// </summary>
        public const string D1PID = "D1PID";

        /// <summary>
        /// D1JOBN.
        /// </summary>
        public const string D1JOBN = "D1JOBN";

        /// <summary>
        /// D1UPMJ.
        /// </summary>
        public const string D1UPMJ = "D1UPMJ";

        /// <summary>
        /// D1UPMT.
        /// </summary>
        public const string D1UPMT = "D1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F53005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D1MCU", "D1MCU", JdeDataType.String, 24, true, true),
        new JdeField("D1DTAI", "D1DTAI", JdeDataType.String, 20, true, true),
        new JdeField("D1KY", "D1KY", JdeDataType.String, 20, true, true),
        new JdeField("D1DL01", "D1DL01", JdeDataType.String, 60),
        new JdeField("D1DL02", "D1DL02", JdeDataType.String, 60),
        new JdeField("D1SPHD", "D1SPHD", JdeDataType.String, 20),
        new JdeField("D1UDCO", "D1UDCO", JdeDataType.String, 2),
        new JdeField("D1HRDC", "D1HRDC", JdeDataType.String, 2),
        new JdeField("D1USER", "D1USER", JdeDataType.String, 20),
        new JdeField("D1PID", "D1PID", JdeDataType.String, 20),
        new JdeField("D1JOBN", "D1JOBN", JdeDataType.String, 20),
        new JdeField("D1UPMJ", "D1UPMJ", JdeDataType.Numeric),
        new JdeField("D1UPMT", "D1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F53005_0", "Primary Key on D1MCU, D1DTAI, D1KY", new[] { "D1MCU", "D1DTAI", "D1KY" }, isUnique: true, isPrimaryKey: true)
    };
}
