using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70UI006 - .
/// </summary>
public class F70UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTJOBS.
        /// </summary>
        public const string MTJOBS = "MTJOBS";

        /// <summary>
        /// MTSPHD.
        /// </summary>
        public const string MTSPHD = "MTSPHD";

        /// <summary>
        /// MTDL01.
        /// </summary>
        public const string MTDL01 = "MTDL01";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTJOBN.
        /// </summary>
        public const string MTJOBN = "MTJOBN";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTUPMT.
        /// </summary>
        public const string MTUPMT = "MTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F70UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTJOBS", "MTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("MTSPHD", "MTSPHD", JdeDataType.String, 20, true, true),
        new JdeField("MTDL01", "MTDL01", JdeDataType.String, 60),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20, true, true),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTJOBN", "MTJOBN", JdeDataType.String, 20),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTUPMT", "MTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70UI006_0", "Primary Key on MTJOBS, MTSPHD, MTUSER", new[] { "MTJOBS", "MTSPHD", "MTUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
