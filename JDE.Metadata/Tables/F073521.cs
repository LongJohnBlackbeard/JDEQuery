using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F073521 - .
/// </summary>
public class F073521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y2CKCN.
        /// </summary>
        public const string Y2CKCN = "Y2CKCN";

        /// <summary>
        /// Y2STLN.
        /// </summary>
        public const string Y2STLN = "Y2STLN";

        /// <summary>
        /// Y2LNID.
        /// </summary>
        public const string Y2LNID = "Y2LNID";

        /// <summary>
        /// Y2UN.
        /// </summary>
        public const string Y2UN = "Y2UN";

        /// <summary>
        /// Y2MCU.
        /// </summary>
        public const string Y2MCU = "Y2MCU";

        /// <summary>
        /// Y2JBCD.
        /// </summary>
        public const string Y2JBCD = "Y2JBCD";

        /// <summary>
        /// Y2JBST.
        /// </summary>
        public const string Y2JBST = "Y2JBST";

        /// <summary>
        /// Y2SHFT.
        /// </summary>
        public const string Y2SHFT = "Y2SHFT";

        /// <summary>
        /// Y2PPRT.
        /// </summary>
        public const string Y2PPRT = "Y2PPRT";

        /// <summary>
        /// Y2PCUN.
        /// </summary>
        public const string Y2PCUN = "Y2PCUN";

        /// <summary>
        /// Y2ITM.
        /// </summary>
        public const string Y2ITM = "Y2ITM";

        /// <summary>
        /// Y2UM.
        /// </summary>
        public const string Y2UM = "Y2UM";

        /// <summary>
        /// Y2AN8.
        /// </summary>
        public const string Y2AN8 = "Y2AN8";

        /// <summary>
        /// Y2GPA.
        /// </summary>
        public const string Y2GPA = "Y2GPA";

        /// <summary>
        /// Y2WR01.
        /// </summary>
        public const string Y2WR01 = "Y2WR01";

        /// <summary>
        /// Y2UPMJ.
        /// </summary>
        public const string Y2UPMJ = "Y2UPMJ";

        /// <summary>
        /// Y2UPMT.
        /// </summary>
        public const string Y2UPMT = "Y2UPMT";

        /// <summary>
        /// Y2PID.
        /// </summary>
        public const string Y2PID = "Y2PID";

        /// <summary>
        /// Y2JOBN.
        /// </summary>
        public const string Y2JOBN = "Y2JOBN";

        /// <summary>
        /// Y2USER.
        /// </summary>
        public const string Y2USER = "Y2USER";
    }

    /// <inheritdoc />
    public override string TableName => "F073521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y2CKCN", "Y2CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y2STLN", "Y2STLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y2LNID", "Y2LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Y2UN", "Y2UN", JdeDataType.String, 12),
        new JdeField("Y2MCU", "Y2MCU", JdeDataType.String, 24),
        new JdeField("Y2JBCD", "Y2JBCD", JdeDataType.String, 12),
        new JdeField("Y2JBST", "Y2JBST", JdeDataType.String, 8),
        new JdeField("Y2SHFT", "Y2SHFT", JdeDataType.String, 2),
        new JdeField("Y2PPRT", "Y2PPRT", JdeDataType.Numeric),
        new JdeField("Y2PCUN", "Y2PCUN", JdeDataType.Numeric),
        new JdeField("Y2ITM", "Y2ITM", JdeDataType.Numeric),
        new JdeField("Y2UM", "Y2UM", JdeDataType.String, 4),
        new JdeField("Y2AN8", "Y2AN8", JdeDataType.Numeric),
        new JdeField("Y2GPA", "Y2GPA", JdeDataType.Numeric),
        new JdeField("Y2WR01", "Y2WR01", JdeDataType.String, 8),
        new JdeField("Y2UPMJ", "Y2UPMJ", JdeDataType.Numeric),
        new JdeField("Y2UPMT", "Y2UPMT", JdeDataType.Numeric),
        new JdeField("Y2PID", "Y2PID", JdeDataType.String, 20),
        new JdeField("Y2JOBN", "Y2JOBN", JdeDataType.String, 20),
        new JdeField("Y2USER", "Y2USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F073521_0", "Primary Key on Y2CKCN, Y2STLN, Y2LNID", new[] { "Y2CKCN", "Y2STLN", "Y2LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
