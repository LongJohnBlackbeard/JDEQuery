using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4978 - .
/// </summary>
public class F4978 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGCGC1.
        /// </summary>
        public const string CGCGC1 = "CGCGC1";

        /// <summary>
        /// CGGLC.
        /// </summary>
        public const string CGGLC = "CGGLC";

        /// <summary>
        /// CGTXA1.
        /// </summary>
        public const string CGTXA1 = "CGTXA1";

        /// <summary>
        /// CGEXR1.
        /// </summary>
        public const string CGEXR1 = "CGEXR1";

        /// <summary>
        /// CGURCD.
        /// </summary>
        public const string CGURCD = "CGURCD";

        /// <summary>
        /// CGURDT.
        /// </summary>
        public const string CGURDT = "CGURDT";

        /// <summary>
        /// CGURAT.
        /// </summary>
        public const string CGURAT = "CGURAT";

        /// <summary>
        /// CGURAB.
        /// </summary>
        public const string CGURAB = "CGURAB";

        /// <summary>
        /// CGURRF.
        /// </summary>
        public const string CGURRF = "CGURRF";

        /// <summary>
        /// CGUSER.
        /// </summary>
        public const string CGUSER = "CGUSER";

        /// <summary>
        /// CGPID.
        /// </summary>
        public const string CGPID = "CGPID";

        /// <summary>
        /// CGJOBN.
        /// </summary>
        public const string CGJOBN = "CGJOBN";

        /// <summary>
        /// CGUPMJ.
        /// </summary>
        public const string CGUPMJ = "CGUPMJ";

        /// <summary>
        /// CGTDAY.
        /// </summary>
        public const string CGTDAY = "CGTDAY";

        /// <summary>
        /// CGFAB.
        /// </summary>
        public const string CGFAB = "CGFAB";

        /// <summary>
        /// CGTX.
        /// </summary>
        public const string CGTX = "CGTX";
    }

    /// <inheritdoc />
    public override string TableName => "F4978";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGCGC1", "CGCGC1", JdeDataType.String, 6, true, true),
        new JdeField("CGGLC", "CGGLC", JdeDataType.String, 8),
        new JdeField("CGTXA1", "CGTXA1", JdeDataType.String, 20),
        new JdeField("CGEXR1", "CGEXR1", JdeDataType.String, 4),
        new JdeField("CGURCD", "CGURCD", JdeDataType.String, 4),
        new JdeField("CGURDT", "CGURDT", JdeDataType.Numeric),
        new JdeField("CGURAT", "CGURAT", JdeDataType.Numeric),
        new JdeField("CGURAB", "CGURAB", JdeDataType.Numeric),
        new JdeField("CGURRF", "CGURRF", JdeDataType.String, 30),
        new JdeField("CGUSER", "CGUSER", JdeDataType.String, 20),
        new JdeField("CGPID", "CGPID", JdeDataType.String, 20),
        new JdeField("CGJOBN", "CGJOBN", JdeDataType.String, 20),
        new JdeField("CGUPMJ", "CGUPMJ", JdeDataType.Numeric),
        new JdeField("CGTDAY", "CGTDAY", JdeDataType.Numeric),
        new JdeField("CGFAB", "CGFAB", JdeDataType.String, 2),
        new JdeField("CGTX", "CGTX", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4978_0", "Primary Key on CGCGC1", new[] { "CGCGC1" }, isUnique: true, isPrimaryKey: true)
    };
}
