using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40345R - .
/// </summary>
public class F40345R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRUKID.
        /// </summary>
        public const string CRUKID = "CRUKID";

        /// <summary>
        /// CRREFC.
        /// </summary>
        public const string CRREFC = "CRREFC";

        /// <summary>
        /// CRAN8.
        /// </summary>
        public const string CRAN8 = "CRAN8";

        /// <summary>
        /// CRCS45.
        /// </summary>
        public const string CRCS45 = "CRCS45";

        /// <summary>
        /// CRITM.
        /// </summary>
        public const string CRITM = "CRITM";

        /// <summary>
        /// CRIT45.
        /// </summary>
        public const string CRIT45 = "CRIT45";

        /// <summary>
        /// CREFTJ.
        /// </summary>
        public const string CREFTJ = "CREFTJ";

        /// <summary>
        /// CREXDJ.
        /// </summary>
        public const string CREXDJ = "CREXDJ";

        /// <summary>
        /// CRMNQ.
        /// </summary>
        public const string CRMNQ = "CRMNQ";

        /// <summary>
        /// CRMXQ.
        /// </summary>
        public const string CRMXQ = "CRMXQ";

        /// <summary>
        /// CRUOM.
        /// </summary>
        public const string CRUOM = "CRUOM";

        /// <summary>
        /// CRTXID.
        /// </summary>
        public const string CRTXID = "CRTXID";

        /// <summary>
        /// CRSTPR.
        /// </summary>
        public const string CRSTPR = "CRSTPR";

        /// <summary>
        /// CROSEQ.
        /// </summary>
        public const string CROSEQ = "CROSEQ";

        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CRCRCD.
        /// </summary>
        public const string CRCRCD = "CRCRCD";

        /// <summary>
        /// CRURCD.
        /// </summary>
        public const string CRURCD = "CRURCD";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40345R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRUKID", "CRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRREFC", "CRREFC", JdeDataType.Numeric),
        new JdeField("CRAN8", "CRAN8", JdeDataType.Numeric),
        new JdeField("CRCS45", "CRCS45", JdeDataType.String, 16),
        new JdeField("CRITM", "CRITM", JdeDataType.Numeric),
        new JdeField("CRIT45", "CRIT45", JdeDataType.String, 16),
        new JdeField("CREFTJ", "CREFTJ", JdeDataType.Numeric),
        new JdeField("CREXDJ", "CREXDJ", JdeDataType.Numeric),
        new JdeField("CRMNQ", "CRMNQ", JdeDataType.Numeric),
        new JdeField("CRMXQ", "CRMXQ", JdeDataType.Numeric),
        new JdeField("CRUOM", "CRUOM", JdeDataType.String, 4),
        new JdeField("CRTXID", "CRTXID", JdeDataType.Numeric),
        new JdeField("CRSTPR", "CRSTPR", JdeDataType.String, 2),
        new JdeField("CROSEQ", "CROSEQ", JdeDataType.Numeric),
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24),
        new JdeField("CRCRCD", "CRCRCD", JdeDataType.String, 6),
        new JdeField("CRURCD", "CRURCD", JdeDataType.String, 4),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40345R_0", "Primary Key on CRUKID", new[] { "CRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40345R_2", "Index on CRAN8, CRCS45, CRITM, CRIT45, CREXDJ, CRMXQ, CRUOM, CRCRCD, CRUPMJ, CRTDAY", new[] { "CRAN8", "CRCS45", "CRITM", "CRIT45", "CREXDJ", "CRMXQ", "CRUOM", "CRCRCD", "CRUPMJ", "CRTDAY" })
    };
}
