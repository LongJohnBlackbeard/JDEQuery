using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B11 - .
/// </summary>
public class F31B11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WGWGID.
        /// </summary>
        public const string WGWGID = "WGWGID";

        /// <summary>
        /// WGWGNA.
        /// </summary>
        public const string WGWGNA = "WGWGNA";

        /// <summary>
        /// WGMCU.
        /// </summary>
        public const string WGMCU = "WGMCU";

        /// <summary>
        /// WGWGTY.
        /// </summary>
        public const string WGWGTY = "WGWGTY";

        /// <summary>
        /// WGGSTU.
        /// </summary>
        public const string WGGSTU = "WGGSTU";

        /// <summary>
        /// WGRSPS.
        /// </summary>
        public const string WGRSPS = "WGRSPS";

        /// <summary>
        /// WGGECM.
        /// </summary>
        public const string WGGECM = "WGGECM";

        /// <summary>
        /// WGUSER.
        /// </summary>
        public const string WGUSER = "WGUSER";

        /// <summary>
        /// WGPID.
        /// </summary>
        public const string WGPID = "WGPID";

        /// <summary>
        /// WGJOBN.
        /// </summary>
        public const string WGJOBN = "WGJOBN";

        /// <summary>
        /// WGUPMJ.
        /// </summary>
        public const string WGUPMJ = "WGUPMJ";

        /// <summary>
        /// WGUPMT.
        /// </summary>
        public const string WGUPMT = "WGUPMT";

        /// <summary>
        /// WGURCD.
        /// </summary>
        public const string WGURCD = "WGURCD";

        /// <summary>
        /// WGURDT.
        /// </summary>
        public const string WGURDT = "WGURDT";

        /// <summary>
        /// WGURAT.
        /// </summary>
        public const string WGURAT = "WGURAT";

        /// <summary>
        /// WGURRF.
        /// </summary>
        public const string WGURRF = "WGURRF";

        /// <summary>
        /// WGURAB.
        /// </summary>
        public const string WGURAB = "WGURAB";

        /// <summary>
        /// WGWCG.
        /// </summary>
        public const string WGWCG = "WGWCG";

        /// <summary>
        /// WGWRF.
        /// </summary>
        public const string WGWRF = "WGWRF";

        /// <summary>
        /// WGWCD.
        /// </summary>
        public const string WGWCD = "WGWCD";

        /// <summary>
        /// WGWAB.
        /// </summary>
        public const string WGWAB = "WGWAB";

        /// <summary>
        /// WGWNUM.
        /// </summary>
        public const string WGWNUM = "WGWNUM";

        /// <summary>
        /// WGWMDT.
        /// </summary>
        public const string WGWMDT = "WGWMDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WGWGID", "WGWGID", JdeDataType.String, 16, true, true),
        new JdeField("WGWGNA", "WGWGNA", JdeDataType.String, 60),
        new JdeField("WGMCU", "WGMCU", JdeDataType.String, 24),
        new JdeField("WGWGTY", "WGWGTY", JdeDataType.String, 6),
        new JdeField("WGGSTU", "WGGSTU", JdeDataType.String, 2),
        new JdeField("WGRSPS", "WGRSPS", JdeDataType.Numeric),
        new JdeField("WGGECM", "WGGECM", JdeDataType.String, 80),
        new JdeField("WGUSER", "WGUSER", JdeDataType.String, 20),
        new JdeField("WGPID", "WGPID", JdeDataType.String, 20),
        new JdeField("WGJOBN", "WGJOBN", JdeDataType.String, 20),
        new JdeField("WGUPMJ", "WGUPMJ", JdeDataType.Numeric),
        new JdeField("WGUPMT", "WGUPMT", JdeDataType.Numeric),
        new JdeField("WGURCD", "WGURCD", JdeDataType.String, 4),
        new JdeField("WGURDT", "WGURDT", JdeDataType.Numeric),
        new JdeField("WGURAT", "WGURAT", JdeDataType.Numeric),
        new JdeField("WGURRF", "WGURRF", JdeDataType.String, 30),
        new JdeField("WGURAB", "WGURAB", JdeDataType.Numeric),
        new JdeField("WGWCG", "WGWCG", JdeDataType.String, 24),
        new JdeField("WGWRF", "WGWRF", JdeDataType.String, 60),
        new JdeField("WGWCD", "WGWCD", JdeDataType.String, 6),
        new JdeField("WGWAB", "WGWAB", JdeDataType.Numeric),
        new JdeField("WGWNUM", "WGWNUM", JdeDataType.Numeric),
        new JdeField("WGWMDT", "WGWMDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B11_0", "Primary Key on WGWGID", new[] { "WGWGID" }, isUnique: true, isPrimaryKey: true)
    };
}
