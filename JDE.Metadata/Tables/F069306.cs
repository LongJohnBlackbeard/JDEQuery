using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069306 - .
/// </summary>
public class F069306 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y_1UN.
        /// </summary>
        public const string Y_1UN = "Y_1UN";

        /// <summary>
        /// Y_1MCU.
        /// </summary>
        public const string Y_1MCU = "Y_1MCU";

        /// <summary>
        /// Y_1JBCD.
        /// </summary>
        public const string Y_1JBCD = "Y_1JBCD";

        /// <summary>
        /// Y_1UNL.
        /// </summary>
        public const string Y_1UNL = "Y_1UNL";

        /// <summary>
        /// Y_1USER.
        /// </summary>
        public const string Y_1USER = "Y_1USER";

        /// <summary>
        /// Y_1PID.
        /// </summary>
        public const string Y_1PID = "Y_1PID";

        /// <summary>
        /// Y_1UPMJ.
        /// </summary>
        public const string Y_1UPMJ = "Y_1UPMJ";

        /// <summary>
        /// Y_1DNMN.
        /// </summary>
        public const string Y_1DNMN = "Y_1DNMN";
    }

    /// <inheritdoc />
    public override string TableName => "F069306";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y_1UN", "Y_1UN", JdeDataType.String, 12, true, true),
        new JdeField("Y_1MCU", "Y_1MCU", JdeDataType.String, 24, true, true),
        new JdeField("Y_1JBCD", "Y_1JBCD", JdeDataType.String, 12, true, true),
        new JdeField("Y_1UNL", "Y_1UNL", JdeDataType.String, 12),
        new JdeField("Y_1USER", "Y_1USER", JdeDataType.String, 20),
        new JdeField("Y_1PID", "Y_1PID", JdeDataType.String, 20),
        new JdeField("Y_1UPMJ", "Y_1UPMJ", JdeDataType.Numeric),
        new JdeField("Y_1DNMN", "Y_1DNMN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069306_0", "Primary Key on Y_1MCU, Y_1UN, Y_1JBCD", new[] { "Y_1MCU", "Y_1UN", "Y_1JBCD" }, isUnique: true, isPrimaryKey: true)
    };
}
