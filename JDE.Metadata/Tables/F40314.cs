using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40314 - .
/// </summary>
public class F40314 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PJAN8.
        /// </summary>
        public const string PJAN8 = "PJAN8";

        /// <summary>
        /// PJCS14.
        /// </summary>
        public const string PJCS14 = "PJCS14";

        /// <summary>
        /// PJITM.
        /// </summary>
        public const string PJITM = "PJITM";

        /// <summary>
        /// PJIT14.
        /// </summary>
        public const string PJIT14 = "PJIT14";

        /// <summary>
        /// PJEFTJ.
        /// </summary>
        public const string PJEFTJ = "PJEFTJ";

        /// <summary>
        /// PJEXDJ.
        /// </summary>
        public const string PJEXDJ = "PJEXDJ";

        /// <summary>
        /// PJMNQ.
        /// </summary>
        public const string PJMNQ = "PJMNQ";

        /// <summary>
        /// PJMXQ.
        /// </summary>
        public const string PJMXQ = "PJMXQ";

        /// <summary>
        /// PJUOM.
        /// </summary>
        public const string PJUOM = "PJUOM";

        /// <summary>
        /// PJTXID.
        /// </summary>
        public const string PJTXID = "PJTXID";

        /// <summary>
        /// PJSTPR.
        /// </summary>
        public const string PJSTPR = "PJSTPR";

        /// <summary>
        /// PJOSEQ.
        /// </summary>
        public const string PJOSEQ = "PJOSEQ";

        /// <summary>
        /// PJMCU.
        /// </summary>
        public const string PJMCU = "PJMCU";

        /// <summary>
        /// PJASN.
        /// </summary>
        public const string PJASN = "PJASN";

        /// <summary>
        /// PJURCD.
        /// </summary>
        public const string PJURCD = "PJURCD";

        /// <summary>
        /// PJURDT.
        /// </summary>
        public const string PJURDT = "PJURDT";

        /// <summary>
        /// PJURAT.
        /// </summary>
        public const string PJURAT = "PJURAT";

        /// <summary>
        /// PJURAB.
        /// </summary>
        public const string PJURAB = "PJURAB";

        /// <summary>
        /// PJURRF.
        /// </summary>
        public const string PJURRF = "PJURRF";

        /// <summary>
        /// PJUSER.
        /// </summary>
        public const string PJUSER = "PJUSER";

        /// <summary>
        /// PJPID.
        /// </summary>
        public const string PJPID = "PJPID";

        /// <summary>
        /// PJJOBN.
        /// </summary>
        public const string PJJOBN = "PJJOBN";

        /// <summary>
        /// PJUPMJ.
        /// </summary>
        public const string PJUPMJ = "PJUPMJ";

        /// <summary>
        /// PJTDAY.
        /// </summary>
        public const string PJTDAY = "PJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40314";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PJAN8", "PJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PJCS14", "PJCS14", JdeDataType.String, 16, true, true),
        new JdeField("PJITM", "PJITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PJIT14", "PJIT14", JdeDataType.String, 16, true, true),
        new JdeField("PJEFTJ", "PJEFTJ", JdeDataType.Numeric),
        new JdeField("PJEXDJ", "PJEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PJMNQ", "PJMNQ", JdeDataType.Numeric),
        new JdeField("PJMXQ", "PJMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PJUOM", "PJUOM", JdeDataType.String, 4, true, true),
        new JdeField("PJTXID", "PJTXID", JdeDataType.Numeric),
        new JdeField("PJSTPR", "PJSTPR", JdeDataType.String, 2),
        new JdeField("PJOSEQ", "PJOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PJMCU", "PJMCU", JdeDataType.String, 24),
        new JdeField("PJASN", "PJASN", JdeDataType.String, 16),
        new JdeField("PJURCD", "PJURCD", JdeDataType.String, 4),
        new JdeField("PJURDT", "PJURDT", JdeDataType.Numeric),
        new JdeField("PJURAT", "PJURAT", JdeDataType.Numeric),
        new JdeField("PJURAB", "PJURAB", JdeDataType.Numeric),
        new JdeField("PJURRF", "PJURRF", JdeDataType.String, 30),
        new JdeField("PJUSER", "PJUSER", JdeDataType.String, 20),
        new JdeField("PJPID", "PJPID", JdeDataType.String, 20),
        new JdeField("PJJOBN", "PJJOBN", JdeDataType.String, 20),
        new JdeField("PJUPMJ", "PJUPMJ", JdeDataType.Numeric),
        new JdeField("PJTDAY", "PJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40314_0", "Primary Key on PJAN8, PJCS14, PJITM, PJIT14, PJEXDJ, PJUOM, PJMXQ, PJOSEQ", new[] { "PJAN8", "PJCS14", "PJITM", "PJIT14", "PJEXDJ", "PJUOM", "PJMXQ", "PJOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
