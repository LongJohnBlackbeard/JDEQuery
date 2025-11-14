using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051374 - .
/// </summary>
public class F051374 : JdeTable
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
        /// ADSC01.
        /// </summary>
        public const string ADSC01 = "ADSC01";

        /// <summary>
        /// ADXC01.
        /// </summary>
        public const string ADXC01 = "ADXC01";

        /// <summary>
        /// ADAW01.
        /// </summary>
        public const string ADAW01 = "ADAW01";

        /// <summary>
        /// ADPTAX.
        /// </summary>
        public const string ADPTAX = "ADPTAX";

        /// <summary>
        /// ADTARO.
        /// </summary>
        public const string ADTARO = "ADTARO";

        /// <summary>
        /// ADFT01.
        /// </summary>
        public const string ADFT01 = "ADFT01";

        /// <summary>
        /// ADCX01.
        /// </summary>
        public const string ADCX01 = "ADCX01";

        /// <summary>
        /// ADNCCD.
        /// </summary>
        public const string ADNCCD = "ADNCCD";
    }

    /// <inheritdoc />
    public override string TableName => "F051374";

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
        new JdeField("ADSC01", "ADSC01", JdeDataType.String, 6, true, true),
        new JdeField("ADXC01", "ADXC01", JdeDataType.Numeric),
        new JdeField("ADAW01", "ADAW01", JdeDataType.Numeric),
        new JdeField("ADPTAX", "ADPTAX", JdeDataType.String, 4, true, true),
        new JdeField("ADTARO", "ADTARO", JdeDataType.String, 20, true, true),
        new JdeField("ADFT01", "ADFT01", JdeDataType.String, 2),
        new JdeField("ADCX01", "ADCX01", JdeDataType.Numeric),
        new JdeField("ADNCCD", "ADNCCD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051374_0", "Primary Key on ADPAYBN, ADAN8, ADSC01, ADTARO, ADPTAX", new[] { "ADPAYBN", "ADAN8", "ADSC01", "ADTARO", "ADPTAX" }, isUnique: true, isPrimaryKey: true)
    };
}
