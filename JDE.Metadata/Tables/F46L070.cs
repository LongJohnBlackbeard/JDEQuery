using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L070 - .
/// </summary>
public class F46L070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCAN8.
        /// </summary>
        public const string SCAN8 = "SCAN8";

        /// <summary>
        /// SCLPNSL.
        /// </summary>
        public const string SCLPNSL = "SCLPNSL";

        /// <summary>
        /// SCLPNXR.
        /// </summary>
        public const string SCLPNXR = "SCLPNXR";

        /// <summary>
        /// SCASNDD.
        /// </summary>
        public const string SCASNDD = "SCASNDD";

        /// <summary>
        /// SCRFIDF.
        /// </summary>
        public const string SCRFIDF = "SCRFIDF";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCMKEY.
        /// </summary>
        public const string SCMKEY = "SCMKEY";

        /// <summary>
        /// SCSVRNAME.
        /// </summary>
        public const string SCSVRNAME = "SCSVRNAME";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCTDAY.
        /// </summary>
        public const string SCTDAY = "SCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46L070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24, true, true),
        new JdeField("SCAN8", "SCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SCLPNSL", "SCLPNSL", JdeDataType.Numeric, null, true, true),
        new JdeField("SCLPNXR", "SCLPNXR", JdeDataType.Numeric, null, true, true),
        new JdeField("SCASNDD", "SCASNDD", JdeDataType.String, 20),
        new JdeField("SCRFIDF", "SCRFIDF", JdeDataType.String, 2),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCMKEY", "SCMKEY", JdeDataType.String, 30),
        new JdeField("SCSVRNAME", "SCSVRNAME", JdeDataType.String, 30),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L070_0", "Primary Key on SCMCU, SCAN8, SCLPNSL, SCLPNXR", new[] { "SCMCU", "SCAN8", "SCLPNSL", "SCLPNXR" }, isUnique: true, isPrimaryKey: true)
    };
}
