using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4918 - .
/// </summary>
public class F4918 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTVMCU.
        /// </summary>
        public const string LTVMCU = "LTVMCU";

        /// <summary>
        /// LTLDNM.
        /// </summary>
        public const string LTLDNM = "LTLDNM";

        /// <summary>
        /// LTCARS.
        /// </summary>
        public const string LTCARS = "LTCARS";

        /// <summary>
        /// LTQRDJ.
        /// </summary>
        public const string LTQRDJ = "LTQRDJ";

        /// <summary>
        /// LTTME0.
        /// </summary>
        public const string LTTME0 = "LTTME0";

        /// <summary>
        /// LTTDDJ.
        /// </summary>
        public const string LTTDDJ = "LTTDDJ";

        /// <summary>
        /// LTTDTM.
        /// </summary>
        public const string LTTDTM = "LTTDTM";

        /// <summary>
        /// LTATDJ.
        /// </summary>
        public const string LTATDJ = "LTATDJ";

        /// <summary>
        /// LTATTM.
        /// </summary>
        public const string LTATTM = "LTATTM";

        /// <summary>
        /// LTRJDJ.
        /// </summary>
        public const string LTRJDJ = "LTRJDJ";

        /// <summary>
        /// LTRJTM.
        /// </summary>
        public const string LTRJTM = "LTRJTM";

        /// <summary>
        /// LTEDDJ.
        /// </summary>
        public const string LTEDDJ = "LTEDDJ";

        /// <summary>
        /// LTEDTM.
        /// </summary>
        public const string LTEDTM = "LTEDTM";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTTDAY.
        /// </summary>
        public const string LTTDAY = "LTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4918";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTVMCU", "LTVMCU", JdeDataType.String, 24, true, true),
        new JdeField("LTLDNM", "LTLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("LTCARS", "LTCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("LTQRDJ", "LTQRDJ", JdeDataType.Numeric),
        new JdeField("LTTME0", "LTTME0", JdeDataType.Numeric),
        new JdeField("LTTDDJ", "LTTDDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LTTDTM", "LTTDTM", JdeDataType.Numeric, null, true, true),
        new JdeField("LTATDJ", "LTATDJ", JdeDataType.Numeric),
        new JdeField("LTATTM", "LTATTM", JdeDataType.Numeric),
        new JdeField("LTRJDJ", "LTRJDJ", JdeDataType.Numeric),
        new JdeField("LTRJTM", "LTRJTM", JdeDataType.Numeric),
        new JdeField("LTEDDJ", "LTEDDJ", JdeDataType.Numeric),
        new JdeField("LTEDTM", "LTEDTM", JdeDataType.Numeric),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTTDAY", "LTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4918_0", "Primary Key on LTVMCU, LTLDNM, LTCARS, LTTDDJ, LTTDTM", new[] { "LTVMCU", "LTLDNM", "LTCARS", "LTTDDJ", "LTTDTM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4918_6", "Index on LTCARS, SYS_NC00019$, SYS_NC00020$", new[] { "LTCARS", "SYS_NC00019$", "SYS_NC00020$" })
    };
}
