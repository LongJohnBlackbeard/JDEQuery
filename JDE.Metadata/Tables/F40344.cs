using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40344 - .
/// </summary>
public class F40344 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAAN8.
        /// </summary>
        public const string SAAN8 = "SAAN8";

        /// <summary>
        /// SACS44.
        /// </summary>
        public const string SACS44 = "SACS44";

        /// <summary>
        /// SAITM.
        /// </summary>
        public const string SAITM = "SAITM";

        /// <summary>
        /// SAIT44.
        /// </summary>
        public const string SAIT44 = "SAIT44";

        /// <summary>
        /// SAEFTJ.
        /// </summary>
        public const string SAEFTJ = "SAEFTJ";

        /// <summary>
        /// SAEXDJ.
        /// </summary>
        public const string SAEXDJ = "SAEXDJ";

        /// <summary>
        /// SAMNQ.
        /// </summary>
        public const string SAMNQ = "SAMNQ";

        /// <summary>
        /// SAMXQ.
        /// </summary>
        public const string SAMXQ = "SAMXQ";

        /// <summary>
        /// SAUOM.
        /// </summary>
        public const string SAUOM = "SAUOM";

        /// <summary>
        /// SATXID.
        /// </summary>
        public const string SATXID = "SATXID";

        /// <summary>
        /// SASTPR.
        /// </summary>
        public const string SASTPR = "SASTPR";

        /// <summary>
        /// SAOSEQ.
        /// </summary>
        public const string SAOSEQ = "SAOSEQ";

        /// <summary>
        /// SAMCU.
        /// </summary>
        public const string SAMCU = "SAMCU";

        /// <summary>
        /// SALOB.
        /// </summary>
        public const string SALOB = "SALOB";

        /// <summary>
        /// SASLSM.
        /// </summary>
        public const string SASLSM = "SASLSM";

        /// <summary>
        /// SASLCM.
        /// </summary>
        public const string SASLCM = "SASLCM";

        /// <summary>
        /// SAURCD.
        /// </summary>
        public const string SAURCD = "SAURCD";

        /// <summary>
        /// SAURDT.
        /// </summary>
        public const string SAURDT = "SAURDT";

        /// <summary>
        /// SAURAT.
        /// </summary>
        public const string SAURAT = "SAURAT";

        /// <summary>
        /// SAURAB.
        /// </summary>
        public const string SAURAB = "SAURAB";

        /// <summary>
        /// SAURRF.
        /// </summary>
        public const string SAURRF = "SAURRF";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SATDAY.
        /// </summary>
        public const string SATDAY = "SATDAY";

        /// <summary>
        /// SAFCA.
        /// </summary>
        public const string SAFCA = "SAFCA";

        /// <summary>
        /// SAAPUN.
        /// </summary>
        public const string SAAPUN = "SAAPUN";

        /// <summary>
        /// SACMCR.
        /// </summary>
        public const string SACMCR = "SACMCR";

        /// <summary>
        /// SACMLN.
        /// </summary>
        public const string SACMLN = "SACMLN";

        /// <summary>
        /// SACCTY.
        /// </summary>
        public const string SACCTY = "SACCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F40344";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAAN8", "SAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SACS44", "SACS44", JdeDataType.String, 16, true, true),
        new JdeField("SAITM", "SAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SAIT44", "SAIT44", JdeDataType.String, 16, true, true),
        new JdeField("SAEFTJ", "SAEFTJ", JdeDataType.Numeric),
        new JdeField("SAEXDJ", "SAEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SAMNQ", "SAMNQ", JdeDataType.Numeric),
        new JdeField("SAMXQ", "SAMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SAUOM", "SAUOM", JdeDataType.String, 4, true, true),
        new JdeField("SATXID", "SATXID", JdeDataType.Numeric),
        new JdeField("SASTPR", "SASTPR", JdeDataType.String, 2),
        new JdeField("SAOSEQ", "SAOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SAMCU", "SAMCU", JdeDataType.String, 24),
        new JdeField("SALOB", "SALOB", JdeDataType.String, 6),
        new JdeField("SASLSM", "SASLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("SASLCM", "SASLCM", JdeDataType.Numeric),
        new JdeField("SAURCD", "SAURCD", JdeDataType.String, 4),
        new JdeField("SAURDT", "SAURDT", JdeDataType.Numeric),
        new JdeField("SAURAT", "SAURAT", JdeDataType.Numeric),
        new JdeField("SAURAB", "SAURAB", JdeDataType.Numeric),
        new JdeField("SAURRF", "SAURRF", JdeDataType.String, 30),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SATDAY", "SATDAY", JdeDataType.Numeric),
        new JdeField("SAFCA", "SAFCA", JdeDataType.Numeric),
        new JdeField("SAAPUN", "SAAPUN", JdeDataType.Numeric),
        new JdeField("SACMCR", "SACMCR", JdeDataType.String, 6),
        new JdeField("SACMLN", "SACMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SACCTY", "SACCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40344_0", "Primary Key on SAAN8, SACS44, SAITM, SAIT44, SAEXDJ, SAUOM, SAMXQ, SAOSEQ, SASLSM, SACMLN", new[] { "SAAN8", "SACS44", "SAITM", "SAIT44", "SAEXDJ", "SAUOM", "SAMXQ", "SAOSEQ", "SASLSM", "SACMLN" }, isUnique: true, isPrimaryKey: true)
    };
}
