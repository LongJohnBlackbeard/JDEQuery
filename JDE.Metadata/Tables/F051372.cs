using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051372 - .
/// </summary>
public class F051372 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADCHGF.
        /// </summary>
        public const string ADCHGF = "ADCHGF";

        /// <summary>
        /// ADPAYBN.
        /// </summary>
        public const string ADPAYBN = "ADPAYBN";

        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADEST.
        /// </summary>
        public const string ADEST = "ADEST";

        /// <summary>
        /// ADHMCU.
        /// </summary>
        public const string ADHMCU = "ADHMCU";

        /// <summary>
        /// ADPFRQ.
        /// </summary>
        public const string ADPFRQ = "ADPFRQ";

        /// <summary>
        /// ADEFTO.
        /// </summary>
        public const string ADEFTO = "ADEFTO";

        /// <summary>
        /// ADJBCD.
        /// </summary>
        public const string ADJBCD = "ADJBCD";

        /// <summary>
        /// ADJBST.
        /// </summary>
        public const string ADJBST = "ADJBST";

        /// <summary>
        /// ADDL01.
        /// </summary>
        public const string ADDL01 = "ADDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F051372";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADCHGF", "ADCHGF", JdeDataType.String, 2),
        new JdeField("ADPAYBN", "ADPAYBN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADEST", "ADEST", JdeDataType.String, 2),
        new JdeField("ADHMCU", "ADHMCU", JdeDataType.String, 24),
        new JdeField("ADPFRQ", "ADPFRQ", JdeDataType.String, 2),
        new JdeField("ADEFTO", "ADEFTO", JdeDataType.Numeric),
        new JdeField("ADJBCD", "ADJBCD", JdeDataType.String, 12),
        new JdeField("ADJBST", "ADJBST", JdeDataType.String, 8),
        new JdeField("ADDL01", "ADDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051372_0", "Primary Key on ADPAYBN, ADAN8", new[] { "ADPAYBN", "ADAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
