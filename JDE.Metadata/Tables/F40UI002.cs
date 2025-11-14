using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI002 - .
/// </summary>
public class F40UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UTORTP.
        /// </summary>
        public const string UTORTP = "UTORTP";

        /// <summary>
        /// UTAN8.
        /// </summary>
        public const string UTAN8 = "UTAN8";

        /// <summary>
        /// UTOSEQ.
        /// </summary>
        public const string UTOSEQ = "UTOSEQ";

        /// <summary>
        /// UTITM.
        /// </summary>
        public const string UTITM = "UTITM";

        /// <summary>
        /// UTLITM.
        /// </summary>
        public const string UTLITM = "UTLITM";

        /// <summary>
        /// UTAITM.
        /// </summary>
        public const string UTAITM = "UTAITM";

        /// <summary>
        /// UTQTYU.
        /// </summary>
        public const string UTQTYU = "UTQTYU";

        /// <summary>
        /// UTUOM.
        /// </summary>
        public const string UTUOM = "UTUOM";

        /// <summary>
        /// UTLNTY.
        /// </summary>
        public const string UTLNTY = "UTLNTY";

        /// <summary>
        /// UTVEND.
        /// </summary>
        public const string UTVEND = "UTVEND";

        /// <summary>
        /// UTEFTJ.
        /// </summary>
        public const string UTEFTJ = "UTEFTJ";

        /// <summary>
        /// UTEXDJ.
        /// </summary>
        public const string UTEXDJ = "UTEXDJ";

        /// <summary>
        /// UTURCD.
        /// </summary>
        public const string UTURCD = "UTURCD";

        /// <summary>
        /// UTURDT.
        /// </summary>
        public const string UTURDT = "UTURDT";

        /// <summary>
        /// UTURAT.
        /// </summary>
        public const string UTURAT = "UTURAT";

        /// <summary>
        /// UTURAB.
        /// </summary>
        public const string UTURAB = "UTURAB";

        /// <summary>
        /// UTURRF.
        /// </summary>
        public const string UTURRF = "UTURRF";

        /// <summary>
        /// UTLIN.
        /// </summary>
        public const string UTLIN = "UTLIN";

        /// <summary>
        /// UTNLIN.
        /// </summary>
        public const string UTNLIN = "UTNLIN";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UTORTP", "UTORTP", JdeDataType.String, 16, true, true),
        new JdeField("UTAN8", "UTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UTOSEQ", "UTOSEQ", JdeDataType.Numeric),
        new JdeField("UTITM", "UTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("UTLITM", "UTLITM", JdeDataType.String, 50),
        new JdeField("UTAITM", "UTAITM", JdeDataType.String, 50),
        new JdeField("UTQTYU", "UTQTYU", JdeDataType.Numeric),
        new JdeField("UTUOM", "UTUOM", JdeDataType.String, 4, true, true),
        new JdeField("UTLNTY", "UTLNTY", JdeDataType.String, 4),
        new JdeField("UTVEND", "UTVEND", JdeDataType.Numeric),
        new JdeField("UTEFTJ", "UTEFTJ", JdeDataType.Numeric),
        new JdeField("UTEXDJ", "UTEXDJ", JdeDataType.Numeric),
        new JdeField("UTURCD", "UTURCD", JdeDataType.String, 4),
        new JdeField("UTURDT", "UTURDT", JdeDataType.Numeric),
        new JdeField("UTURAT", "UTURAT", JdeDataType.Numeric),
        new JdeField("UTURAB", "UTURAB", JdeDataType.Numeric),
        new JdeField("UTURRF", "UTURRF", JdeDataType.String, 30),
        new JdeField("UTLIN", "UTLIN", JdeDataType.Numeric),
        new JdeField("UTNLIN", "UTNLIN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI002_0", "Primary Key on UTORTP, UTAN8, UTITM, UTUOM", new[] { "UTORTP", "UTAN8", "UTITM", "UTUOM" }, isUnique: true, isPrimaryKey: true)
    };
}
