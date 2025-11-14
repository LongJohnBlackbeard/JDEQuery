using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B112 - .
/// </summary>
public class F31B112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAWGID.
        /// </summary>
        public const string AAWGID = "AAWGID";

        /// <summary>
        /// AAWGNA.
        /// </summary>
        public const string AAWGNA = "AAWGNA";

        /// <summary>
        /// AAWAID.
        /// </summary>
        public const string AAWAID = "AAWAID";

        /// <summary>
        /// AAWANA.
        /// </summary>
        public const string AAWANA = "AAWANA";

        /// <summary>
        /// AAMCU.
        /// </summary>
        public const string AAMCU = "AAMCU";

        /// <summary>
        /// AAWAST.
        /// </summary>
        public const string AAWAST = "AAWAST";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

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
        /// AAURRF.
        /// </summary>
        public const string AAURRF = "AAURRF";

        /// <summary>
        /// AAURAB.
        /// </summary>
        public const string AAURAB = "AAURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAWGID", "AAWGID", JdeDataType.String, 16, true, true),
        new JdeField("AAWGNA", "AAWGNA", JdeDataType.String, 60),
        new JdeField("AAWAID", "AAWAID", JdeDataType.String, 16, true, true),
        new JdeField("AAWANA", "AAWANA", JdeDataType.String, 60),
        new JdeField("AAMCU", "AAMCU", JdeDataType.String, 24),
        new JdeField("AAWAST", "AAWAST", JdeDataType.String, 2),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAURCD", "AAURCD", JdeDataType.String, 4),
        new JdeField("AAURDT", "AAURDT", JdeDataType.Numeric),
        new JdeField("AAURAT", "AAURAT", JdeDataType.Numeric),
        new JdeField("AAURRF", "AAURRF", JdeDataType.String, 30),
        new JdeField("AAURAB", "AAURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B112_0", "Primary Key on AAWAID, AAWGID", new[] { "AAWAID", "AAWGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B112_2", "Index on AAWGID", new[] { "AAWGID" })
    };
}
