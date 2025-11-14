using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F071861 - .
/// </summary>
public class F071861 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y8CKCN.
        /// </summary>
        public const string Y8CKCN = "Y8CKCN";

        /// <summary>
        /// Y8STLN.
        /// </summary>
        public const string Y8STLN = "Y8STLN";

        /// <summary>
        /// Y8LNID.
        /// </summary>
        public const string Y8LNID = "Y8LNID";

        /// <summary>
        /// Y8UN.
        /// </summary>
        public const string Y8UN = "Y8UN";

        /// <summary>
        /// Y8MCU.
        /// </summary>
        public const string Y8MCU = "Y8MCU";

        /// <summary>
        /// Y8JBCD.
        /// </summary>
        public const string Y8JBCD = "Y8JBCD";

        /// <summary>
        /// Y8JBST.
        /// </summary>
        public const string Y8JBST = "Y8JBST";

        /// <summary>
        /// Y8SHFT.
        /// </summary>
        public const string Y8SHFT = "Y8SHFT";

        /// <summary>
        /// Y8PPRT.
        /// </summary>
        public const string Y8PPRT = "Y8PPRT";

        /// <summary>
        /// Y8PCUN.
        /// </summary>
        public const string Y8PCUN = "Y8PCUN";

        /// <summary>
        /// Y8ITM.
        /// </summary>
        public const string Y8ITM = "Y8ITM";

        /// <summary>
        /// Y8UM.
        /// </summary>
        public const string Y8UM = "Y8UM";

        /// <summary>
        /// Y8AN8.
        /// </summary>
        public const string Y8AN8 = "Y8AN8";

        /// <summary>
        /// Y8GPA.
        /// </summary>
        public const string Y8GPA = "Y8GPA";

        /// <summary>
        /// Y8WR01.
        /// </summary>
        public const string Y8WR01 = "Y8WR01";

        /// <summary>
        /// Y8UPMJ.
        /// </summary>
        public const string Y8UPMJ = "Y8UPMJ";

        /// <summary>
        /// Y8UPMT.
        /// </summary>
        public const string Y8UPMT = "Y8UPMT";

        /// <summary>
        /// Y8PID.
        /// </summary>
        public const string Y8PID = "Y8PID";

        /// <summary>
        /// Y8JOBN.
        /// </summary>
        public const string Y8JOBN = "Y8JOBN";

        /// <summary>
        /// Y8USER.
        /// </summary>
        public const string Y8USER = "Y8USER";
    }

    /// <inheritdoc />
    public override string TableName => "F071861";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y8CKCN", "Y8CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8STLN", "Y8STLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8LNID", "Y8LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8UN", "Y8UN", JdeDataType.String, 12),
        new JdeField("Y8MCU", "Y8MCU", JdeDataType.String, 24),
        new JdeField("Y8JBCD", "Y8JBCD", JdeDataType.String, 12),
        new JdeField("Y8JBST", "Y8JBST", JdeDataType.String, 8),
        new JdeField("Y8SHFT", "Y8SHFT", JdeDataType.String, 2),
        new JdeField("Y8PPRT", "Y8PPRT", JdeDataType.Numeric),
        new JdeField("Y8PCUN", "Y8PCUN", JdeDataType.Numeric),
        new JdeField("Y8ITM", "Y8ITM", JdeDataType.Numeric),
        new JdeField("Y8UM", "Y8UM", JdeDataType.String, 4),
        new JdeField("Y8AN8", "Y8AN8", JdeDataType.Numeric),
        new JdeField("Y8GPA", "Y8GPA", JdeDataType.Numeric),
        new JdeField("Y8WR01", "Y8WR01", JdeDataType.String, 8),
        new JdeField("Y8UPMJ", "Y8UPMJ", JdeDataType.Numeric),
        new JdeField("Y8UPMT", "Y8UPMT", JdeDataType.Numeric),
        new JdeField("Y8PID", "Y8PID", JdeDataType.String, 20),
        new JdeField("Y8JOBN", "Y8JOBN", JdeDataType.String, 20),
        new JdeField("Y8USER", "Y8USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F071861_0", "Primary Key on Y8CKCN, Y8STLN, Y8LNID", new[] { "Y8CKCN", "Y8STLN", "Y8LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
