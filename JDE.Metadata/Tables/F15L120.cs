using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L120 - .
/// </summary>
public class F15L120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAARAC.
        /// </summary>
        public const string AAARAC = "AAARAC";

        /// <summary>
        /// AARVNB.
        /// </summary>
        public const string AARVNB = "AARVNB";

        /// <summary>
        /// AAAID.
        /// </summary>
        public const string AAAID = "AAAID";

        /// <summary>
        /// AAMCU.
        /// </summary>
        public const string AAMCU = "AAMCU";

        /// <summary>
        /// AADESC.
        /// </summary>
        public const string AADESC = "AADESC";

        /// <summary>
        /// AAURCD.
        /// </summary>
        public const string AAURCD = "AAURCD";

        /// <summary>
        /// AAURDT.
        /// </summary>
        public const string AAURDT = "AAURDT";

        /// <summary>
        /// AAURAT.
        /// </summary>
        public const string AAURAT = "AAURAT";

        /// <summary>
        /// AAURAB.
        /// </summary>
        public const string AAURAB = "AAURAB";

        /// <summary>
        /// AAURRF.
        /// </summary>
        public const string AAURRF = "AAURRF";

        /// <summary>
        /// AATORG.
        /// </summary>
        public const string AATORG = "AATORG";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAMCU2.
        /// </summary>
        public const string AAMCU2 = "AAMCU2";
    }

    /// <inheritdoc />
    public override string TableName => "F15L120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAARAC", "AAARAC", JdeDataType.String, 8, true, true),
        new JdeField("AARVNB", "AARVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("AAAID", "AAAID", JdeDataType.String, 16, true, true),
        new JdeField("AAMCU", "AAMCU", JdeDataType.String, 24, true, true),
        new JdeField("AADESC", "AADESC", JdeDataType.String, 60),
        new JdeField("AAURCD", "AAURCD", JdeDataType.String, 4),
        new JdeField("AAURDT", "AAURDT", JdeDataType.Numeric),
        new JdeField("AAURAT", "AAURAT", JdeDataType.Numeric),
        new JdeField("AAURAB", "AAURAB", JdeDataType.Numeric),
        new JdeField("AAURRF", "AAURRF", JdeDataType.String, 30),
        new JdeField("AATORG", "AATORG", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAMCU2", "AAMCU2", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L120_0", "Primary Key on AAMCU, AARVNB, AAARAC, AAAID", new[] { "AAMCU", "AARVNB", "AAARAC", "AAAID" }, isUnique: true, isPrimaryKey: true)
    };
}
