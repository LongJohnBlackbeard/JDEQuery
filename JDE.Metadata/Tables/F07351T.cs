using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07351T - .
/// </summary>
public class F07351T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y1CKCN.
        /// </summary>
        public const string Y1CKCN = "Y1CKCN";

        /// <summary>
        /// Y1SCKC.
        /// </summary>
        public const string Y1SCKC = "Y1SCKC";

        /// <summary>
        /// Y1SEC.
        /// </summary>
        public const string Y1SEC = "Y1SEC";

        /// <summary>
        /// Y1NQUAL.
        /// </summary>
        public const string Y1NQUAL = "Y1NQUAL";

        /// <summary>
        /// Y1FDFI.
        /// </summary>
        public const string Y1FDFI = "Y1FDFI";

        /// <summary>
        /// Y1IDCC.
        /// </summary>
        public const string Y1IDCC = "Y1IDCC";

        /// <summary>
        /// Y1IAT.
        /// </summary>
        public const string Y1IAT = "Y1IAT";

        /// <summary>
        /// Y1IAT25.
        /// </summary>
        public const string Y1IAT25 = "Y1IAT25";

        /// <summary>
        /// Y1IAT26.
        /// </summary>
        public const string Y1IAT26 = "Y1IAT26";

        /// <summary>
        /// Y1IAT27.
        /// </summary>
        public const string Y1IAT27 = "Y1IAT27";

        /// <summary>
        /// Y1IAT28.
        /// </summary>
        public const string Y1IAT28 = "Y1IAT28";

        /// <summary>
        /// Y1IAT29.
        /// </summary>
        public const string Y1IAT29 = "Y1IAT29";

        /// <summary>
        /// Y1IAT30.
        /// </summary>
        public const string Y1IAT30 = "Y1IAT30";

        /// <summary>
        /// Y1IAT31.
        /// </summary>
        public const string Y1IAT31 = "Y1IAT31";

        /// <summary>
        /// Y1IAT32.
        /// </summary>
        public const string Y1IAT32 = "Y1IAT32";

        /// <summary>
        /// Y1IAT33.
        /// </summary>
        public const string Y1IAT33 = "Y1IAT33";

        /// <summary>
        /// Y1IAT34.
        /// </summary>
        public const string Y1IAT34 = "Y1IAT34";

        /// <summary>
        /// Y1IAT35.
        /// </summary>
        public const string Y1IAT35 = "Y1IAT35";

        /// <summary>
        /// Y1IAT36.
        /// </summary>
        public const string Y1IAT36 = "Y1IAT36";

        /// <summary>
        /// Y1UPMJ.
        /// </summary>
        public const string Y1UPMJ = "Y1UPMJ";

        /// <summary>
        /// Y1UPMT.
        /// </summary>
        public const string Y1UPMT = "Y1UPMT";

        /// <summary>
        /// Y1PID.
        /// </summary>
        public const string Y1PID = "Y1PID";

        /// <summary>
        /// Y1JOBN.
        /// </summary>
        public const string Y1JOBN = "Y1JOBN";

        /// <summary>
        /// Y1USER.
        /// </summary>
        public const string Y1USER = "Y1USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07351T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y1CKCN", "Y1CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1SCKC", "Y1SCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1SEC", "Y1SEC", JdeDataType.String, 6),
        new JdeField("Y1NQUAL", "Y1NQUAL", JdeDataType.String, 4),
        new JdeField("Y1FDFI", "Y1FDFI", JdeDataType.String, 68),
        new JdeField("Y1IDCC", "Y1IDCC", JdeDataType.String, 6),
        new JdeField("Y1IAT", "Y1IAT", JdeDataType.String, 2),
        new JdeField("Y1IAT25", "Y1IAT25", JdeDataType.Numeric),
        new JdeField("Y1IAT26", "Y1IAT26", JdeDataType.Numeric),
        new JdeField("Y1IAT27", "Y1IAT27", JdeDataType.Numeric),
        new JdeField("Y1IAT28", "Y1IAT28", JdeDataType.String, 70),
        new JdeField("Y1IAT29", "Y1IAT29", JdeDataType.String, 70),
        new JdeField("Y1IAT30", "Y1IAT30", JdeDataType.String, 70),
        new JdeField("Y1IAT31", "Y1IAT31", JdeDataType.Numeric),
        new JdeField("Y1IAT32", "Y1IAT32", JdeDataType.Numeric),
        new JdeField("Y1IAT33", "Y1IAT33", JdeDataType.Numeric),
        new JdeField("Y1IAT34", "Y1IAT34", JdeDataType.String, 2),
        new JdeField("Y1IAT35", "Y1IAT35", JdeDataType.String, 2),
        new JdeField("Y1IAT36", "Y1IAT36", JdeDataType.String, 2),
        new JdeField("Y1UPMJ", "Y1UPMJ", JdeDataType.Numeric),
        new JdeField("Y1UPMT", "Y1UPMT", JdeDataType.Numeric),
        new JdeField("Y1PID", "Y1PID", JdeDataType.String, 20),
        new JdeField("Y1JOBN", "Y1JOBN", JdeDataType.String, 20),
        new JdeField("Y1USER", "Y1USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07351T_0", "Primary Key on Y1CKCN, Y1SCKC", new[] { "Y1CKCN", "Y1SCKC" }, isUnique: true, isPrimaryKey: true)
    };
}
