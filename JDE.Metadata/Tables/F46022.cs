using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46022 - .
/// </summary>
public class F46022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTMCU.
        /// </summary>
        public const string LTMCU = "LTMCU";

        /// <summary>
        /// LTSTY1.
        /// </summary>
        public const string LTSTY1 = "LTSTY1";

        /// <summary>
        /// LTMAXW.
        /// </summary>
        public const string LTMAXW = "LTMAXW";

        /// <summary>
        /// LTGWID.
        /// </summary>
        public const string LTGWID = "LTGWID";

        /// <summary>
        /// LTGDEP.
        /// </summary>
        public const string LTGDEP = "LTGDEP";

        /// <summary>
        /// LTGHET.
        /// </summary>
        public const string LTGHET = "LTGHET";

        /// <summary>
        /// LTGCUB.
        /// </summary>
        public const string LTGCUB = "LTGCUB";

        /// <summary>
        /// LTUWID.
        /// </summary>
        public const string LTUWID = "LTUWID";

        /// <summary>
        /// LTUDEP.
        /// </summary>
        public const string LTUDEP = "LTUDEP";

        /// <summary>
        /// LTUHET.
        /// </summary>
        public const string LTUHET = "LTUHET";

        /// <summary>
        /// LTUCUB.
        /// </summary>
        public const string LTUCUB = "LTUCUB";

        /// <summary>
        /// LTURCD.
        /// </summary>
        public const string LTURCD = "LTURCD";

        /// <summary>
        /// LTURDT.
        /// </summary>
        public const string LTURDT = "LTURDT";

        /// <summary>
        /// LTURAT.
        /// </summary>
        public const string LTURAT = "LTURAT";

        /// <summary>
        /// LTURAB.
        /// </summary>
        public const string LTURAB = "LTURAB";

        /// <summary>
        /// LTURRF.
        /// </summary>
        public const string LTURRF = "LTURRF";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

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
    public override string TableName => "F46022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTMCU", "LTMCU", JdeDataType.String, 24, true, true),
        new JdeField("LTSTY1", "LTSTY1", JdeDataType.String, 12, true, true),
        new JdeField("LTMAXW", "LTMAXW", JdeDataType.Numeric),
        new JdeField("LTGWID", "LTGWID", JdeDataType.Numeric),
        new JdeField("LTGDEP", "LTGDEP", JdeDataType.Numeric),
        new JdeField("LTGHET", "LTGHET", JdeDataType.Numeric),
        new JdeField("LTGCUB", "LTGCUB", JdeDataType.Numeric),
        new JdeField("LTUWID", "LTUWID", JdeDataType.Numeric),
        new JdeField("LTUDEP", "LTUDEP", JdeDataType.Numeric),
        new JdeField("LTUHET", "LTUHET", JdeDataType.Numeric),
        new JdeField("LTUCUB", "LTUCUB", JdeDataType.Numeric),
        new JdeField("LTURCD", "LTURCD", JdeDataType.String, 4),
        new JdeField("LTURDT", "LTURDT", JdeDataType.Numeric),
        new JdeField("LTURAT", "LTURAT", JdeDataType.Numeric),
        new JdeField("LTURAB", "LTURAB", JdeDataType.Numeric),
        new JdeField("LTURRF", "LTURRF", JdeDataType.String, 30),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTTDAY", "LTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46022_0", "Primary Key on LTMCU, LTSTY1", new[] { "LTMCU", "LTSTY1" }, isUnique: true, isPrimaryKey: true)
    };
}
