using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186410 - .
/// </summary>
public class F186410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTLRSORID.
        /// </summary>
        public const string OTLRSORID = "OTLRSORID";

        /// <summary>
        /// OTSEQ.
        /// </summary>
        public const string OTSEQ = "OTSEQ";

        /// <summary>
        /// OTAOR1.
        /// </summary>
        public const string OTAOR1 = "OTAOR1";

        /// <summary>
        /// OTLRSFID.
        /// </summary>
        public const string OTLRSFID = "OTLRSFID";

        /// <summary>
        /// OTVALS.
        /// </summary>
        public const string OTVALS = "OTVALS";

        /// <summary>
        /// OTTCSEGV.
        /// </summary>
        public const string OTTCSEGV = "OTTCSEGV";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTJOBN.
        /// </summary>
        public const string OTJOBN = "OTJOBN";

        /// <summary>
        /// OTUPMJ.
        /// </summary>
        public const string OTUPMJ = "OTUPMJ";

        /// <summary>
        /// OTTDAY.
        /// </summary>
        public const string OTTDAY = "OTTDAY";

        /// <summary>
        /// OTLRSOP.
        /// </summary>
        public const string OTLRSOP = "OTLRSOP";

        /// <summary>
        /// OTLRSCP.
        /// </summary>
        public const string OTLRSCP = "OTLRSCP";
    }

    /// <inheritdoc />
    public override string TableName => "F186410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTLRSORID", "OTLRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTSEQ", "OTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OTAOR1", "OTAOR1", JdeDataType.String, 6),
        new JdeField("OTLRSFID", "OTLRSFID", JdeDataType.Numeric),
        new JdeField("OTVALS", "OTVALS", JdeDataType.String, 4),
        new JdeField("OTTCSEGV", "OTTCSEGV", JdeDataType.String, 80),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTJOBN", "OTJOBN", JdeDataType.String, 20),
        new JdeField("OTUPMJ", "OTUPMJ", JdeDataType.Numeric),
        new JdeField("OTTDAY", "OTTDAY", JdeDataType.Numeric),
        new JdeField("OTLRSOP", "OTLRSOP", JdeDataType.String, 2),
        new JdeField("OTLRSCP", "OTLRSCP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186410_0", "Primary Key on OTLRSORID, OTSEQ", new[] { "OTLRSORID", "OTSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
