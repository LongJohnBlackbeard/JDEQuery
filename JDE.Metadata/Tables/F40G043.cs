using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G043 - .
/// </summary>
public class F40G043 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSITM.
        /// </summary>
        public const string SSITM = "SSITM";

        /// <summary>
        /// SSMCU.
        /// </summary>
        public const string SSMCU = "SSMCU";

        /// <summary>
        /// SSSITEM.
        /// </summary>
        public const string SSSITEM = "SSSITEM";

        /// <summary>
        /// SSENTID.
        /// </summary>
        public const string SSENTID = "SSENTID";

        /// <summary>
        /// SSLITM.
        /// </summary>
        public const string SSLITM = "SSLITM";

        /// <summary>
        /// SSSTENTY.
        /// </summary>
        public const string SSSTENTY = "SSSTENTY";

        /// <summary>
        /// SSSVALUE.
        /// </summary>
        public const string SSSVALUE = "SSSVALUE";

        /// <summary>
        /// SSGRASDE1.
        /// </summary>
        public const string SSGRASDE1 = "SSGRASDE1";

        /// <summary>
        /// SSGREXPDE1.
        /// </summary>
        public const string SSGREXPDE1 = "SSGREXPDE1";

        /// <summary>
        /// SSURCD.
        /// </summary>
        public const string SSURCD = "SSURCD";

        /// <summary>
        /// SSURDT.
        /// </summary>
        public const string SSURDT = "SSURDT";

        /// <summary>
        /// SSURRF.
        /// </summary>
        public const string SSURRF = "SSURRF";

        /// <summary>
        /// SSURAT.
        /// </summary>
        public const string SSURAT = "SSURAT";

        /// <summary>
        /// SSURAB.
        /// </summary>
        public const string SSURAB = "SSURAB";

        /// <summary>
        /// SSPID.
        /// </summary>
        public const string SSPID = "SSPID";

        /// <summary>
        /// SSTORG.
        /// </summary>
        public const string SSTORG = "SSTORG";

        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSJOBN.
        /// </summary>
        public const string SSJOBN = "SSJOBN";

        /// <summary>
        /// SSUUPMJ.
        /// </summary>
        public const string SSUUPMJ = "SSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G043";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSITM", "SSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SSMCU", "SSMCU", JdeDataType.String, 24, true, true),
        new JdeField("SSSITEM", "SSSITEM", JdeDataType.String, 24, true, true),
        new JdeField("SSENTID", "SSENTID", JdeDataType.Numeric),
        new JdeField("SSLITM", "SSLITM", JdeDataType.String, 50),
        new JdeField("SSSTENTY", "SSSTENTY", JdeDataType.String, 6),
        new JdeField("SSSVALUE", "SSSVALUE", JdeDataType.Numeric),
        new JdeField("SSGRASDE1", "SSGRASDE1", JdeDataType.Date),
        new JdeField("SSGREXPDE1", "SSGREXPDE1", JdeDataType.Date),
        new JdeField("SSURCD", "SSURCD", JdeDataType.String, 4),
        new JdeField("SSURDT", "SSURDT", JdeDataType.Numeric),
        new JdeField("SSURRF", "SSURRF", JdeDataType.String, 30),
        new JdeField("SSURAT", "SSURAT", JdeDataType.Numeric),
        new JdeField("SSURAB", "SSURAB", JdeDataType.Numeric),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20),
        new JdeField("SSTORG", "SSTORG", JdeDataType.String, 20),
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSUUPMJ", "SSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G043_0", "Primary Key on SSITM, SSMCU, SSSITEM", new[] { "SSITM", "SSMCU", "SSSITEM" }, isUnique: true, isPrimaryKey: true)
    };
}
