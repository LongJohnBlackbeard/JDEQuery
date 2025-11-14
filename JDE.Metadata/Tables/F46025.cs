using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46025 - .
/// </summary>
public class F46025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MQMCU.
        /// </summary>
        public const string MQMCU = "MQMCU";

        /// <summary>
        /// MQPZON.
        /// </summary>
        public const string MQPZON = "MQPZON";

        /// <summary>
        /// MQITM.
        /// </summary>
        public const string MQITM = "MQITM";

        /// <summary>
        /// MQUOM.
        /// </summary>
        public const string MQUOM = "MQUOM";

        /// <summary>
        /// MQMXPT.
        /// </summary>
        public const string MQMXPT = "MQMXPT";

        /// <summary>
        /// MQUSER.
        /// </summary>
        public const string MQUSER = "MQUSER";

        /// <summary>
        /// MQUPMJ.
        /// </summary>
        public const string MQUPMJ = "MQUPMJ";

        /// <summary>
        /// MQTDAY.
        /// </summary>
        public const string MQTDAY = "MQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MQMCU", "MQMCU", JdeDataType.String, 24, true, true),
        new JdeField("MQPZON", "MQPZON", JdeDataType.String, 12, true, true),
        new JdeField("MQITM", "MQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MQUOM", "MQUOM", JdeDataType.String, 4, true, true),
        new JdeField("MQMXPT", "MQMXPT", JdeDataType.Numeric),
        new JdeField("MQUSER", "MQUSER", JdeDataType.String, 20),
        new JdeField("MQUPMJ", "MQUPMJ", JdeDataType.Numeric),
        new JdeField("MQTDAY", "MQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46025_0", "Primary Key on MQMCU, MQPZON, MQITM, MQUOM", new[] { "MQMCU", "MQPZON", "MQITM", "MQUOM" }, isUnique: true, isPrimaryKey: true)
    };
}
