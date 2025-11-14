using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051373 - .
/// </summary>
public class F051373 : JdeTable
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
        /// ADSEQ.
        /// </summary>
        public const string ADSEQ = "ADSEQ";

        /// <summary>
        /// ADPSDT.
        /// </summary>
        public const string ADPSDT = "ADPSDT";

        /// <summary>
        /// ADPTDT.
        /// </summary>
        public const string ADPTDT = "ADPTDT";

        /// <summary>
        /// ADFOA#.
        /// </summary>
        public const string ADFOA_ = "ADFOA#";

        /// <summary>
        /// ADIFO#.
        /// </summary>
        public const string ADIFO_ = "ADIFO#";

        /// <summary>
        /// ADBDM.
        /// </summary>
        public const string ADBDM = "ADBDM";

        /// <summary>
        /// ADTCOD.
        /// </summary>
        public const string ADTCOD = "ADTCOD";

        /// <summary>
        /// ADGPA.
        /// </summary>
        public const string ADGPA = "ADGPA";

        /// <summary>
        /// ADFPCD.
        /// </summary>
        public const string ADFPCD = "ADFPCD";
    }

    /// <inheritdoc />
    public override string TableName => "F051373";

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
        new JdeField("ADSEQ", "ADSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ADPSDT", "ADPSDT", JdeDataType.Numeric),
        new JdeField("ADPTDT", "ADPTDT", JdeDataType.Numeric),
        new JdeField("ADFOA#", "ADFOA#", JdeDataType.String, 34, true, true),
        new JdeField("ADIFO#", "ADIFO#", JdeDataType.String, 18),
        new JdeField("ADBDM", "ADBDM", JdeDataType.String, 2, true, true),
        new JdeField("ADTCOD", "ADTCOD", JdeDataType.String, 4),
        new JdeField("ADGPA", "ADGPA", JdeDataType.Numeric),
        new JdeField("ADFPCD", "ADFPCD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051373_0", "Primary Key on ADPAYBN, ADAN8, ADSEQ, ADFOA#, ADBDM", new[] { "ADPAYBN", "ADAN8", "ADSEQ", "ADFOA#", "ADBDM" }, isUnique: true, isPrimaryKey: true)
    };
}
