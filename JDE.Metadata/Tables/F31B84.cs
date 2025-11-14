using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B84 - .
/// </summary>
public class F31B84 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OAWOPID.
        /// </summary>
        public const string OAWOPID = "OAWOPID";

        /// <summary>
        /// OAWOPN.
        /// </summary>
        public const string OAWOPN = "OAWOPN";

        /// <summary>
        /// OAITM.
        /// </summary>
        public const string OAITM = "OAITM";

        /// <summary>
        /// OALITM.
        /// </summary>
        public const string OALITM = "OALITM";

        /// <summary>
        /// OAMCU.
        /// </summary>
        public const string OAMCU = "OAMCU";

        /// <summary>
        /// OAADDQTY.
        /// </summary>
        public const string OAADDQTY = "OAADDQTY";

        /// <summary>
        /// OAADTUOM.
        /// </summary>
        public const string OAADTUOM = "OAADTUOM";

        /// <summary>
        /// OAARQTY.
        /// </summary>
        public const string OAARQTY = "OAARQTY";

        /// <summary>
        /// OAADRUM.
        /// </summary>
        public const string OAADRUM = "OAADRUM";

        /// <summary>
        /// OAADDTQ.
        /// </summary>
        public const string OAADDTQ = "OAADDTQ";

        /// <summary>
        /// OAADDTU.
        /// </summary>
        public const string OAADDTU = "OAADDTU";

        /// <summary>
        /// OALOCN.
        /// </summary>
        public const string OALOCN = "OALOCN";

        /// <summary>
        /// OALOTN.
        /// </summary>
        public const string OALOTN = "OALOTN";

        /// <summary>
        /// OAADMT.
        /// </summary>
        public const string OAADMT = "OAADMT";

        /// <summary>
        /// OAGINVCMT.
        /// </summary>
        public const string OAGINVCMT = "OAGINVCMT";

        /// <summary>
        /// OAURAT.
        /// </summary>
        public const string OAURAT = "OAURAT";

        /// <summary>
        /// OAURRF.
        /// </summary>
        public const string OAURRF = "OAURRF";

        /// <summary>
        /// OAURDT.
        /// </summary>
        public const string OAURDT = "OAURDT";

        /// <summary>
        /// OAURCD.
        /// </summary>
        public const string OAURCD = "OAURCD";

        /// <summary>
        /// OAURAB.
        /// </summary>
        public const string OAURAB = "OAURAB";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OAUPMT.
        /// </summary>
        public const string OAUPMT = "OAUPMT";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAJOBN.
        /// </summary>
        public const string OAJOBN = "OAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F31B84";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OAWOPID", "OAWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OAWOPN", "OAWOPN", JdeDataType.Numeric),
        new JdeField("OAITM", "OAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OALITM", "OALITM", JdeDataType.String, 50),
        new JdeField("OAMCU", "OAMCU", JdeDataType.String, 24, true, true),
        new JdeField("OAADDQTY", "OAADDQTY", JdeDataType.Numeric),
        new JdeField("OAADTUOM", "OAADTUOM", JdeDataType.String, 4),
        new JdeField("OAARQTY", "OAARQTY", JdeDataType.Numeric),
        new JdeField("OAADRUM", "OAADRUM", JdeDataType.String, 4),
        new JdeField("OAADDTQ", "OAADDTQ", JdeDataType.Numeric),
        new JdeField("OAADDTU", "OAADDTU", JdeDataType.String, 4),
        new JdeField("OALOCN", "OALOCN", JdeDataType.String, 40),
        new JdeField("OALOTN", "OALOTN", JdeDataType.String, 60),
        new JdeField("OAADMT", "OAADMT", JdeDataType.String, 2),
        new JdeField("OAGINVCMT", "OAGINVCMT", JdeDataType.String, 2),
        new JdeField("OAURAT", "OAURAT", JdeDataType.Numeric),
        new JdeField("OAURRF", "OAURRF", JdeDataType.String, 30),
        new JdeField("OAURDT", "OAURDT", JdeDataType.Numeric),
        new JdeField("OAURCD", "OAURCD", JdeDataType.String, 4),
        new JdeField("OAURAB", "OAURAB", JdeDataType.Numeric),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OAUPMT", "OAUPMT", JdeDataType.Numeric),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAJOBN", "OAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B84_0", "Primary Key on OAWOPID, OAMCU, OAITM", new[] { "OAWOPID", "OAMCU", "OAITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B84_2", "Index on OAWOPID", new[] { "OAWOPID" })
    };
}
